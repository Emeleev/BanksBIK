using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Windows.Forms;


namespace SpkBIK
{
    class WorkWithDBF
    {
        private OleDbConnection ConOdbc = null;
        private OleDbDataAdapter adp;
        public DataSet ds;
        private OleDbCommandBuilder cb;
        private System.Data.OleDb.OleDbCommand OdbcCom;
    
        /// <summary>
        /// Открытие подключения
        /// </summary>
        /// <param name="Command">SQL команда</param>
        public void CreateConnection(string Command)
        {
            try
            {
                ds = new DataSet();

                if (ConOdbc != null)
                {
                    try
                    {
                        ConOdbc.Open();
                        OdbcCom = ConOdbc.CreateCommand();
                        OdbcCom.CommandType = CommandType.Text;
                        OdbcCom.CommandText = Command;

                        
                    }
                    catch (Exception errorMsg)
                    {
                        MessageBox.Show("Ошибка при подключении к БД. Текст ошибки: " + errorMsg.Message, "Внимание");
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Непредвиденная ошибка! Функция CreateConnection. " + error.Message, "Внимание");
            }
        }

        /// <summary>
        /// Выполнение запроса
        /// </summary>
        public void ExecuteConnection()
        {
            try
            {
                adp = new OleDbDataAdapter(OdbcCom);
                adp.FillError += new FillErrorEventHandler(adp_FillError);
                cb = new OleDbCommandBuilder();
                cb.DataAdapter = adp;
                adp.Fill(ds);
                ConOdbc.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Непредвиденная ошибка! Функция ExecuteConnection. " + error.Message, "Внимание");
            }
        }

        /// <summary>
        /// Выполнение запроса
        /// </summary>
        public void ExecuteConnectionNonQuery()
        {
            try
            {
                OdbcCom.ExecuteNonQuery();              
                ConOdbc.Close();
            }
            catch (Exception error)
            {
                MessageBox.Show("Непредвиденная ошибка! Функция ExecuteConnection. " + error.Message, "Внимание");
            }
        }

        void adp_FillError(object sender, FillErrorEventArgs e)
        {
            MessageBox.Show(e.Errors.Message);
        }

        

        /// <summary>
        /// Добавление нового параметра в запрос
        /// </summary>
        /// <param name="namePar">имя переменной параметра</param>
        /// <param name="size">размерность</param>
        /// <param name="valuePar">значение</param>
        public void AddParameter(string namePar, int size, string valuePar)
        {
            try
            {
                if (valuePar.Trim() == "")
                    OdbcCom.Parameters.Add(namePar, OleDbType.VarChar, size).Value = DBNull.Value;
                else
                    OdbcCom.Parameters.Add(namePar, OleDbType.VarChar, size).Value = valuePar;
            }
            catch (Exception error)
            {
                MessageBox.Show("Непредвиденная ошибка! Функция AddParameter. " + error.Message, "Внимание");
            }
        }
    
        /// <summary>
        /// Основная функция класса WorkWithDBF
        /// </summary>
        public WorkWithDBF()
        {
            try
            {
                //Формирование строки подключения к файлам dbf
                this.ConOdbc = new System.Data.OleDb.OleDbConnection();
                ConOdbc.ConnectionString = @"Provider = Microsoft.Jet.OLEDB.4.0;" +
                    "Data Source=" + Properties.Settings.Default.PathSpr + "; Extended Properties=dBASE IV";
            }
            catch (Exception error)
            {
                MessageBox.Show("Непредвиденная ошибка! Функция WorkWithDBF. " + error.Message, "Внимание");
            }
        }
    }
}
