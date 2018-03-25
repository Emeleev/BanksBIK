using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpkBIK
{
    public partial class Action : Form
    {
        private BNKClass bnk = new BNKClass();
        private int mode;

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="mode">Режим: 1 - просмотр данных/редактирование данных, 2 - добавление новой записи</param>
        /// <param name="VKEY">идентификатор записи справочника БИК</param>
        public Action(int modetmp, string VKEY)
        {
            try
            {
                InitializeComponent();

                mode = modetmp;

                Directory dr_pzn = new Directory();
                dr_pzn.DirectorySelect(SqlQuery.strSqlQuerySelectPZN, 2);

                cb_pzn.DataSource = dr_pzn.theList;
                cb_pzn.DisplayMember = "Name";
                cb_pzn.ValueMember = "Id";
                               

                Directory dr_uer = new Directory();
                dr_uer.DirectorySelect(SqlQuery.strSqlQuerySelectUER, 2);

                cb_uer.DataSource = dr_uer.theList;
                cb_uer.DisplayMember = "Name";
                cb_uer.ValueMember = "Id";

                Directory dr_rgn = new Directory();
                dr_rgn.DirectorySelect(SqlQuery.strSqlQuerySelectRGN, 2);

                cb_rgn.DataSource = dr_rgn.theList;
                cb_rgn.DisplayMember = "Name";
                cb_rgn.ValueMember = "Id";

                Directory dr_tnp = new Directory();
                dr_tnp.DirectorySelect(SqlQuery.strSqlQuerySelectTNP, 2);

                cb_tnp.DataSource = dr_tnp.theList;
                cb_tnp.DisplayMember = "Name";
                cb_tnp.ValueMember = "Id";


                //просмотр данных/редактирование данных
                if (mode == 1)
                {                       
                    bnk.VKEY = VKEY;
                    bnk.SelectData();

                    tb_REAL.Text = bnk.REAL;
                    tb_IND.Text = bnk.IND;
                    tb_NNP.Text = bnk.NNP;
                    tb_TELEF.Text = bnk.TELEF;
                    tb_RKC.Text = bnk.RKC;
                    tb_NAMEP.Text = bnk.NAMEP;
                    tb_NEWNUM.Text = bnk.NEWNUM;
                    tb_ADR.Text = bnk.ADR;
                    tb_REGN.Text = bnk.REGN;
                    tb_OKPO.Text = bnk.OKPO;
                    tb_KSNP.Text = bnk.KSNP;
                    dtp_DT_IZM.Value = Convert.ToDateTime(bnk.DT_IZM);
                    dtp_DATE_IN.Value = Convert.ToDateTime(bnk.DATE_IN);
                    dtp_DATE_CH.Value = Convert.ToDateTime(bnk.DATE_CH);                   

                    cb_pzn.SelectedValue = bnk.PZN;
                    cb_uer.SelectedValue = bnk.UER;
                    cb_rgn.SelectedValue = bnk.RGN;                    
                    cb_tnp.SelectedValue = bnk.TNP;

                    
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Непредвиденная ошибка! Функция Action. " + error.Message, "Внимание");
            }
        }

        private void Action_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Сохранение данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_save_Click(object sender, EventArgs e)
        {
            try
            {

                string errorMsg = "";


                int cn = 0;


                bnk.REAL = tb_REAL.Text.Trim();
                bnk.IND = tb_IND.Text.Trim();
                bnk.ADR = tb_ADR.Text;
                bnk.NNP = tb_NNP.Text.Trim();
                bnk.TELEF = tb_TELEF.Text.Trim();
                bnk.RKC = tb_RKC.Text.Trim();
                bnk.NAMEP = tb_NAMEP.Text.Trim();
                bnk.NEWNUM = tb_NEWNUM.Text.Trim();
                bnk.REGN = tb_REGN.Text.Trim();
                bnk.OKPO = tb_OKPO.Text.Trim();
                bnk.KSNP = tb_KSNP.Text.Trim();

                bnk.DT_IZM = dtp_DT_IZM.Value.ToString();
                bnk.DATE_IN = dtp_DATE_IN.Value.ToString();
                bnk.DATE_CH = dtp_DATE_CH.Value.ToString();

                bnk.PZN = cb_pzn.SelectedValue.ToString();
                bnk.UER = cb_uer.SelectedValue.ToString();
                bnk.RGN = cb_rgn.SelectedValue.ToString();
                bnk.TNP = cb_tnp.SelectedValue.ToString();

                //Проверка заполнения обязательных полей

                if (bnk.UER == "0")
                    errorMsg = errorMsg + "Не заполнено поле Наименование типа участника (пользователя) системы электронных расчетов.\n";
                if (bnk.RGN == "0")
                    errorMsg = errorMsg + "Не заполнено поле Наименование территории Российской федерации.\n";
                if (bnk.NAMEP.Trim() == "")
                    errorMsg = errorMsg + "Не заполнено поле Наименование участника расчетов.\n";
                if (bnk.NEWNUM.Trim() == "")
                    errorMsg = errorMsg + "Не заполнено поле БИК банка.\n";
                if (bnk.DT_IZM.Trim() == "")
                    errorMsg = errorMsg + "Не заполнено поле Дата последнего изменения записи.\n";
                if (bnk.DATE_IN.Trim() == "")
                    errorMsg = errorMsg + "Не заполнено поле Дата включения информации об участнике расчетов в ЭБД.\n";

                if (errorMsg == "")
                {
                    //Проверка существования БИК
                    cn = bnk.SelectCountVKEY(mode);

                    if (cn == 0)
                    {
                        bnk.UpdateData(mode);
                        UpdateDelegate.EventHandler();
                        Close();
                    }
                    else
                    {

                        MessageBox.Show("Запись с номером БИК " + bnk.NEWNUM + " уже существует!", "Внимание");

                    }
                }
                else
                {
                    MessageBox.Show(errorMsg, "Внимание");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("ОШибка при сохранении данных. " + error.Message, "Внимание");
            }
        }
    }
}
