namespace SpkBIK
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cb_pzn = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_reg = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_bic = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbt_new = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbt_edit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbt_del = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbt_update = new System.Windows.Forms.ToolStripButton();
            this.dGW_sprbic = new System.Windows.Forms.DataGridView();
            this.VKEY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PZN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RGN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TNP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NNP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ADR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RKC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAMEP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NEWNUM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REGN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OKPO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DT_IZM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KSNP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_IN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATE_CH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.новаяЗаписьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGW_sprbic)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cb_pzn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tb_reg);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tb_bic);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 76);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(801, 43);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Очистить фильтр";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(720, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Применить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cb_pzn
            // 
            this.cb_pzn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_pzn.FormattingEnabled = true;
            this.cb_pzn.Location = new System.Drawing.Point(434, 45);
            this.cb_pzn.Name = "cb_pzn";
            this.cb_pzn.Size = new System.Drawing.Size(260, 21);
            this.cb_pzn.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(402, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Тип";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(195, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Регион";
            // 
            // tb_reg
            // 
            this.tb_reg.Location = new System.Drawing.Point(244, 45);
            this.tb_reg.Name = "tb_reg";
            this.tb_reg.Size = new System.Drawing.Size(136, 20);
            this.tb_reg.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "БИК";
            // 
            // tb_bic
            // 
            this.tb_bic.Location = new System.Drawing.Point(40, 45);
            this.tb_bic.Name = "tb_bic";
            this.tb_bic.Size = new System.Drawing.Size(136, 20);
            this.tb_bic.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(25, 25);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbt_new,
            this.toolStripSeparator1,
            this.tsbt_edit,
            this.toolStripSeparator2,
            this.tsbt_del,
            this.toolStripSeparator3,
            this.tsbt_update});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(925, 32);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbt_new
            // 
            this.tsbt_new.Image = ((System.Drawing.Image)(resources.GetObject("tsbt_new.Image")));
            this.tsbt_new.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbt_new.Name = "tsbt_new";
            this.tsbt_new.Size = new System.Drawing.Size(110, 29);
            this.tsbt_new.Text = "Новая запись";
            this.tsbt_new.Click += new System.EventHandler(this.tsbt_new_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // tsbt_edit
            // 
            this.tsbt_edit.Image = ((System.Drawing.Image)(resources.GetObject("tsbt_edit.Image")));
            this.tsbt_edit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbt_edit.Name = "tsbt_edit";
            this.tsbt_edit.Size = new System.Drawing.Size(116, 29);
            this.tsbt_edit.Text = "Редактировать";
            this.tsbt_edit.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // tsbt_del
            // 
            this.tsbt_del.Image = ((System.Drawing.Image)(resources.GetObject("tsbt_del.Image")));
            this.tsbt_del.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbt_del.Name = "tsbt_del";
            this.tsbt_del.Size = new System.Drawing.Size(80, 29);
            this.tsbt_del.Text = "Удалить";
            this.tsbt_del.Click += new System.EventHandler(this.tsbt_del_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 32);
            // 
            // tsbt_update
            // 
            this.tsbt_update.Image = ((System.Drawing.Image)(resources.GetObject("tsbt_update.Image")));
            this.tsbt_update.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbt_update.Name = "tsbt_update";
            this.tsbt_update.Size = new System.Drawing.Size(90, 29);
            this.tsbt_update.Text = "Обновить";
            this.tsbt_update.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // dGW_sprbic
            // 
            this.dGW_sprbic.AllowUserToAddRows = false;
            this.dGW_sprbic.AllowUserToDeleteRows = false;
            this.dGW_sprbic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGW_sprbic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VKEY,
            this.REAL,
            this.PZN,
            this.UER,
            this.RGN,
            this.IND,
            this.TNP,
            this.NNP,
            this.ADR,
            this.RKC,
            this.NAMEP,
            this.NEWNUM,
            this.TELEF,
            this.REGN,
            this.OKPO,
            this.DT_IZM,
            this.KSNP,
            this.DATE_IN,
            this.DATE_CH});
            this.dGW_sprbic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dGW_sprbic.Location = new System.Drawing.Point(0, 76);
            this.dGW_sprbic.Name = "dGW_sprbic";
            this.dGW_sprbic.ReadOnly = true;
            this.dGW_sprbic.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGW_sprbic.Size = new System.Drawing.Size(925, 485);
            this.dGW_sprbic.TabIndex = 1;
            // 
            // VKEY
            // 
            this.VKEY.DataPropertyName = "VKEY";
            this.VKEY.HeaderText = "VKEY";
            this.VKEY.Name = "VKEY";
            this.VKEY.ReadOnly = true;
            this.VKEY.Visible = false;
            // 
            // REAL
            // 
            this.REAL.DataPropertyName = "REAL";
            this.REAL.HeaderText = "Код контроля";
            this.REAL.Name = "REAL";
            this.REAL.ReadOnly = true;
            // 
            // PZN
            // 
            this.PZN.DataPropertyName = "PZN";
            this.PZN.HeaderText = "Тип участника расчетов";
            this.PZN.Name = "PZN";
            this.PZN.ReadOnly = true;
            this.PZN.Width = 200;
            // 
            // UER
            // 
            this.UER.DataPropertyName = "UER";
            this.UER.HeaderText = "Тип участника ЭР";
            this.UER.Name = "UER";
            this.UER.ReadOnly = true;
            this.UER.Width = 200;
            // 
            // RGN
            // 
            this.RGN.DataPropertyName = "RGN";
            this.RGN.HeaderText = "Регион";
            this.RGN.Name = "RGN";
            this.RGN.ReadOnly = true;
            this.RGN.Width = 200;
            // 
            // IND
            // 
            this.IND.DataPropertyName = "IND";
            this.IND.HeaderText = "Индекс";
            this.IND.Name = "IND";
            this.IND.ReadOnly = true;
            // 
            // TNP
            // 
            this.TNP.DataPropertyName = "TNP";
            this.TNP.HeaderText = "Тип населенного пункта";
            this.TNP.Name = "TNP";
            this.TNP.ReadOnly = true;
            // 
            // NNP
            // 
            this.NNP.DataPropertyName = "NNP";
            this.NNP.HeaderText = "Населенный пункт";
            this.NNP.Name = "NNP";
            this.NNP.ReadOnly = true;
            this.NNP.Width = 150;
            // 
            // ADR
            // 
            this.ADR.DataPropertyName = "ADR";
            this.ADR.HeaderText = "Адрес";
            this.ADR.Name = "ADR";
            this.ADR.ReadOnly = true;
            this.ADR.Width = 200;
            // 
            // RKC
            // 
            this.RKC.DataPropertyName = "RKC";
            this.RKC.HeaderText = "БИК РКЦ";
            this.RKC.Name = "RKC";
            this.RKC.ReadOnly = true;
            // 
            // NAMEP
            // 
            this.NAMEP.DataPropertyName = "NAMEP";
            this.NAMEP.HeaderText = "Наименование";
            this.NAMEP.Name = "NAMEP";
            this.NAMEP.ReadOnly = true;
            this.NAMEP.Width = 200;
            // 
            // NEWNUM
            // 
            this.NEWNUM.DataPropertyName = "NEWNUM";
            this.NEWNUM.HeaderText = "БИК";
            this.NEWNUM.Name = "NEWNUM";
            this.NEWNUM.ReadOnly = true;
            // 
            // TELEF
            // 
            this.TELEF.DataPropertyName = "TELEF";
            this.TELEF.HeaderText = "Телефон";
            this.TELEF.Name = "TELEF";
            this.TELEF.ReadOnly = true;
            // 
            // REGN
            // 
            this.REGN.DataPropertyName = "REGN";
            this.REGN.HeaderText = "Рег. номер";
            this.REGN.Name = "REGN";
            this.REGN.ReadOnly = true;
            // 
            // OKPO
            // 
            this.OKPO.DataPropertyName = "OKPO";
            this.OKPO.HeaderText = "Код ОКПО";
            this.OKPO.Name = "OKPO";
            this.OKPO.ReadOnly = true;
            // 
            // DT_IZM
            // 
            this.DT_IZM.DataPropertyName = "DT_IZM";
            this.DT_IZM.HeaderText = "Дата послед. изменения";
            this.DT_IZM.Name = "DT_IZM";
            this.DT_IZM.ReadOnly = true;
            // 
            // KSNP
            // 
            this.KSNP.DataPropertyName = "KSNP";
            this.KSNP.HeaderText = "Номер счета";
            this.KSNP.Name = "KSNP";
            this.KSNP.ReadOnly = true;
            this.KSNP.Width = 160;
            // 
            // DATE_IN
            // 
            this.DATE_IN.DataPropertyName = "DATE_IN";
            this.DATE_IN.HeaderText = "Дата включ. инф.";
            this.DATE_IN.Name = "DATE_IN";
            this.DATE_IN.ReadOnly = true;
            // 
            // DATE_CH
            // 
            this.DATE_CH.DataPropertyName = "DATE_CH";
            this.DATE_CH.HeaderText = "Дата контроля";
            this.DATE_CH.Name = "DATE_CH";
            this.DATE_CH.ReadOnly = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.новаяЗаписьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.обновитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 92);
            // 
            // новаяЗаписьToolStripMenuItem
            // 
            this.новаяЗаписьToolStripMenuItem.Name = "новаяЗаписьToolStripMenuItem";
            this.новаяЗаписьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.новаяЗаписьToolStripMenuItem.Text = "Новая запись";
            this.новаяЗаписьToolStripMenuItem.Click += new System.EventHandler(this.новаяЗаписьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            this.обновитьToolStripMenuItem.Click += new System.EventHandler(this.обновитьToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 561);
            this.Controls.Add(this.dGW_sprbic);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(940, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Справочник БИК РФ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGW_sprbic)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dGW_sprbic;
        private System.Windows.Forms.ComboBox cb_pzn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_reg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_bic;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbt_new;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbt_edit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbt_del;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbt_update;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn VKEY;
        private System.Windows.Forms.DataGridViewTextBoxColumn REAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn PZN;
        private System.Windows.Forms.DataGridViewTextBoxColumn UER;
        private System.Windows.Forms.DataGridViewTextBoxColumn RGN;
        private System.Windows.Forms.DataGridViewTextBoxColumn IND;
        private System.Windows.Forms.DataGridViewTextBoxColumn TNP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NNP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ADR;
        private System.Windows.Forms.DataGridViewTextBoxColumn RKC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAMEP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NEWNUM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEF;
        private System.Windows.Forms.DataGridViewTextBoxColumn REGN;
        private System.Windows.Forms.DataGridViewTextBoxColumn OKPO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DT_IZM;
        private System.Windows.Forms.DataGridViewTextBoxColumn KSNP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_IN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATE_CH;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem новаяЗаписьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;

    }
}

