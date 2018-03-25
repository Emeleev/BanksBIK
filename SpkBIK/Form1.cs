using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
/*
 * Авто: Емелеев Руслан
 * Эл. адрес: emeleev@bk.ru
 * Дата создания: 25.03.2018
 * Описание: Справочник БИК
 */

namespace SpkBIK
{
    public partial class Form1 : Form
    {
        private bool flagError = false;

        //Функция делегата
        void funcUpdateDelegate()
        {
            UpdateData();
        }

        public Form1()
        {
            InitializeComponent();

            //Делегат обновления данных
            UpdateDelegate.EventHandler = new UpdateDelegate.MyEvent(funcUpdateDelegate);

            //Действие после загрузки формы
            this.Load +=new EventHandler(Form1_Load);
            //Действие при двойном клике мышки по таблице
            dGW_sprbic.MouseDoubleClick += new MouseEventHandler(dGW_sprbic_MouseDoubleClick);
            //Действие при клике правой клавишей мышки по таблице (вызов контекстного меню)
            dGW_sprbic.CellMouseClick += new DataGridViewCellMouseEventHandler(dGW_sprbic_CellMouseClick);

            //Проверка параметров
            TestDB();

            //Если ошибок нет
            if (flagError == false)
            {
                //Данные для элемента ComboBox Тип участника расчетов
                Directory dr_pzn = new Directory();
                dr_pzn.DirectorySelect(SqlQuery.strSqlQuerySelectPZN, 1);

                cb_pzn.DataSource = dr_pzn.theList;
                cb_pzn.DisplayMember = "Name";
                cb_pzn.ValueMember = "Id";

                //Вывод данных в таблицу
                UpdateData();  
            }
        }

        void  Form1_Load(object sender, EventArgs e)
        {         
            //Если при проверки параметров были обнаружены ошибки, закрываем приложение
            if (flagError == true)
            {
                Close();
            }
        }
      

        //Проверка параметров программы 
        private void TestDB()
        {
            if (!File.Exists(Path.Combine(Properties.Settings.Default.PathSpr, "BNKSEEK.DBF")))
            {
                MessageBox.Show("Ошибка! Не найден файл BNKSEEK.DBF! Проверьте правильность пути '" + Properties.Settings.Default.PathSpr + "' в параметрах программы.\nПриложение будет закрыто!", "Внимание");
                flagError = true;
            }
        }

        private void dGW_sprbic_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!e.RowIndex.Equals(-1) && !e.ColumnIndex.Equals(-1) && e.Button.Equals(MouseButtons.Right))
            {
                contextMenuStrip1.Show(Control.MousePosition.X, Control.MousePosition.Y);
                dGW_sprbic.CurrentCell = dGW_sprbic[e.ColumnIndex, e.RowIndex];
                dGW_sprbic.CurrentRow.Selected = true;

            } 
        }

        /// <summary>
        /// Обновление данных в ьаблице
        /// </summary>
        private void UpdateData()
        {
           
            //Объявляем класс работы с DBF файлами
            WorkWithDBF wwd = new WorkWithDBF();
            DataSet ds = new DataSet();
                               
            wwd.CreateConnection(SqlQuery.strSqlQuerySelect);
            wwd.AddParameter("@strBIC", 10, tb_bic.Text.Trim());
            wwd.AddParameter("@strREG", 50, tb_reg.Text.Trim());
            wwd.AddParameter("@strPZN", 10, cb_pzn.SelectedValue.ToString());
            wwd.ExecuteConnection();

            ds = wwd.ds;

            //Если данные получены, выводим на форму
            if (ds.Tables.Count > 0)
            {
                dGW_sprbic.DataSource = ds.Tables[0];
            }
        }

        /// <summary>
        /// Добавить новую запись
        /// </summary>
        private void AddData()
        {
            Action act = new Action(2, "");
            act.ShowDialog();
        }
        
        
        /// <summary>
        /// Открыть запись на просмотр\редактирование
        /// </summary>
        private void EditData()
        {
            if (dGW_sprbic.SelectedRows.Count == 1)
            {
                Action act = new Action(1, dGW_sprbic.CurrentRow.Cells[0].Value.ToString());
                act.ShowDialog();
            }
        }

        
        /// <summary>
        /// Удаление записи
        /// </summary>
        private void DelData()
        {
            if (dGW_sprbic.SelectedRows.Count == 1)
            {
                if (
                    MessageBox.Show("Будет выполнено удаление записи. Продолжить?", "Внимание", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes
                )
                {
                    BNKClass bnk = new BNKClass();
                    bnk.VKEY = dGW_sprbic.CurrentRow.Cells[0].Value.ToString();
                    bnk.DeleteData();
                    UpdateData();
                }
            }
        }

        //Действие при двойном клике мышки по таблице
        private void dGW_sprbic_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        //Действие при нажатии кнопки "Очистить фильтр"
        private void button2_Click(object sender, EventArgs e)
        {
            tb_bic.Text = "";
            tb_reg.Text = "";
            cb_pzn.SelectedValue = "0";
            UpdateData();
        }

        //Действие при нажатии кнопки "Редактировать"
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            EditData();
        }

        //Действие при выборе меню Редактировать контекстного меню
        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditData();
        }

        //Действие при выборе меню Обновить контекстного меню
        private void обновитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void tsbt_del_Click(object sender, EventArgs e)
        {
            DelData();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelData();
        }

        private void tsbt_new_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void новаяЗаписьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddData();
        }
    }
}
