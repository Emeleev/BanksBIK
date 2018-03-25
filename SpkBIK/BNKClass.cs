using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace SpkBIK
{
    class BNKClass
    {
        public string VKEY ="0",
            REAL = "",
            PZN = "",
            UER = "",
            RGN = "",
            IND = "",
            TNP = "",
            NNP = "",
            ADR = "",
            NEWNUM = "",
            RKC = "",
            NAMEP = "",
            TELEF = "",
            REGN = "",
            OKPO = "",
            DT_IZM = "",
            KSNP = "",
            DATE_IN = "",
            DATE_CH = "";

        /// <summary>
        /// Выборка данных
        /// </summary>
        public void SelectData()
        {
            //Объявляем класс работы с DBF файлами
            WorkWithDBF wwd = new WorkWithDBF();
            DataSet ds = new DataSet();

            wwd.CreateConnection(SqlQuery.strSqlQuerySelectRecord);
            wwd.AddParameter("@strVKEY", 8, VKEY);
            wwd.ExecuteConnection();

            //Загрузка данных в элементы
            if (wwd.ds.Tables[0].Rows.Count == 1)
            {
                REAL = wwd.ds.Tables[0].Rows[0]["REAL"].ToString();
                IND = wwd.ds.Tables[0].Rows[0]["IND"].ToString();
                NNP = wwd.ds.Tables[0].Rows[0]["NNP"].ToString();
                TELEF = wwd.ds.Tables[0].Rows[0]["TELEF"].ToString();
                RKC = wwd.ds.Tables[0].Rows[0]["RKC"].ToString();
                NAMEP = wwd.ds.Tables[0].Rows[0]["NAMEP"].ToString();
                NEWNUM = wwd.ds.Tables[0].Rows[0]["NEWNUM"].ToString();
                ADR = wwd.ds.Tables[0].Rows[0]["ADR"].ToString();
                REGN = wwd.ds.Tables[0].Rows[0]["REGN"].ToString();
                OKPO = wwd.ds.Tables[0].Rows[0]["OKPO"].ToString();
                KSNP = wwd.ds.Tables[0].Rows[0]["KSNP"].ToString();
                DT_IZM = wwd.ds.Tables[0].Rows[0]["DT_IZM"].ToString();
                DATE_IN = wwd.ds.Tables[0].Rows[0]["DATE_IN"].ToString();
                if (wwd.ds.Tables[0].Rows[0]["DATE_CH"] != DBNull.Value)
                    DATE_CH = wwd.ds.Tables[0].Rows[0]["DATE_CH"].ToString();
                else
                    DATE_CH = "01.01.1900";

                PZN = wwd.ds.Tables[0].Rows[0]["PZN"].ToString();
                UER = wwd.ds.Tables[0].Rows[0]["UER"].ToString();
                RGN = wwd.ds.Tables[0].Rows[0]["RGN"].ToString();            
                TNP = wwd.ds.Tables[0].Rows[0]["TNP"].ToString();
                if (TNP == "")
                    TNP = "0";
                if (PZN == "")
                    PZN = "0";
                if (UER == "")
                    UER = "0";
                if (RGN == "")
                    RGN = "0";

            }

            
        }

        /// <summary>
        /// Добавить/Отредактировать запись
        /// </summary>
        public void UpdateData(int mode)
        {
       
            string vkey_pzn = "",
                vkey_uer = "",
                vkey_tnp = "",
                vkey_rgn = "";

            try
            {
                if (PZN != "0")
                {
                    WorkWithDBF wwd_pzn = new WorkWithDBF();
                    wwd_pzn.CreateConnection(SqlQuery.strSqlQuerySelectVkeyPZN);
                    wwd_pzn.AddParameter("@strPZN", 8, PZN);
                    wwd_pzn.ExecuteConnection();
                    vkey_pzn = wwd_pzn.ds.Tables[0].Rows[0]["PZN"].ToString();
                }
                else
                {
                    vkey_pzn = "";
                }

                if (UER != "0")
                {
                    WorkWithDBF wwd_uer = new WorkWithDBF();
                    wwd_uer.CreateConnection(SqlQuery.strSqlQuerySelectVkeyUER);
                    wwd_uer.AddParameter("@strUER", 8, UER);
                    wwd_uer.ExecuteConnection();
                    vkey_uer = wwd_uer.ds.Tables[0].Rows[0]["UER"].ToString();
                }
                else
                {
                    vkey_uer = "";
                }

                if (TNP != "0")
                {
                    WorkWithDBF wwd_tnp = new WorkWithDBF();
                    wwd_tnp.CreateConnection(SqlQuery.strSqlQuerySelectVkeyTNP);
                    wwd_tnp.AddParameter("@strTNP", 8, TNP);
                    wwd_tnp.ExecuteConnection();
                    vkey_tnp = wwd_tnp.ds.Tables[0].Rows[0]["TNP"].ToString();
                }
                else
                {
                    vkey_tnp = "";
                }

                if (RGN != "0")
                {
                    WorkWithDBF wwd_rgn = new WorkWithDBF();
                    wwd_rgn.CreateConnection(SqlQuery.strSqlQuerySelectVkeyRGN);
                    wwd_rgn.AddParameter("@strRGN", 8, RGN);
                    wwd_rgn.ExecuteConnection();
                    vkey_rgn = wwd_rgn.ds.Tables[0].Rows[0]["RGN"].ToString();
                }
                else
                    vkey_rgn = "";

                WorkWithDBF wwd = new WorkWithDBF();
                if(mode == 1)
                    wwd.CreateConnection(SqlQuery.strSqlQueryUpdateData);
                else if(mode == 2)
                    wwd.CreateConnection(SqlQuery.strSqlQueryInsertData);

                wwd.AddParameter("@strREAL", 4, REAL);
                wwd.AddParameter("@strADR", 30, ADR);
                wwd.AddParameter("@strNAMEp", 45, NAMEP);              
                wwd.AddParameter("@strTELEF", 25, TELEF);
                wwd.AddParameter("@strREGN", 9, REGN);
                wwd.AddParameter("@strNEWNUM", 9, NEWNUM);
                wwd.AddParameter("@strOKPO", 8, OKPO);
                wwd.AddParameter("@strKSNP", 20, KSNP);
                wwd.AddParameter("@strNNP", 25, NNP);
                wwd.AddParameter("@strDTIZM", 10, DT_IZM);                
                wwd.AddParameter("@strDATEIN", 10, DATE_IN);
                wwd.AddParameter("@strDATECH", 10, DATE_CH);
                wwd.AddParameter("@strPZN", 8, vkey_pzn);
                wwd.AddParameter("@strUER", 8, vkey_uer);
                wwd.AddParameter("@strTNP", 8, vkey_tnp);
                wwd.AddParameter("@strRGN", 8, vkey_rgn);
                wwd.AddParameter("@strIND", 6, IND);
                if(mode == 1)
                    wwd.AddParameter("@strVKEY", 8, VKEY);
                else
                    wwd.AddParameter("@strVKEY", 8, NEWNUM);

                wwd.ExecuteConnectionNonQuery();
            }
            catch (Exception error)
            {
                MessageBox.Show("Ошибка при обновлении данных! " + error.Message, "Внимание");
            }
        }

        /// <summary>
        /// Удалить запись
        /// </summary>
        public void DeleteData()
        {
            try
            {
                WorkWithDBF wwd = new WorkWithDBF();
                wwd.CreateConnection(SqlQuery.strSqlQueryDeleteData);
                wwd.AddParameter("@strVKEY", 8, VKEY);
                wwd.ExecuteConnection();
            }
            catch (Exception error)
            {
                MessageBox.Show("Ошибка при удалении данных! " + error.Message, "Внимание");
            }
        }

        /// <summary>
        /// Проверка поля БИК
        /// </summary>
        public int SelectCountVKEY(int mode)
        {   
            int cn = 0;
            
            try
            {
        
                //Объявляем класс работы с DBF файлами
                WorkWithDBF wwd = new WorkWithDBF();        
                if(mode == 1)
                    wwd.CreateConnection(SqlQuery.strSqlQuerySelectUpd);
                else
                    wwd.CreateConnection(SqlQuery.strSqlQuerySelectIns);
                wwd.AddParameter("@strNEWNUM", 9, NEWNUM);
                wwd.AddParameter("@strVKEY", 8, VKEY);
                wwd.ExecuteConnection();
                cn = Convert.ToInt32(wwd.ds.Tables[0].Rows[0]["CN"]);
           
            }
            catch (Exception error)
            {
                MessageBox.Show("Ошибка при получении списка БИК! " + error.Message, "Внимание");
            }

            return cn;

        }

        
    }
}
