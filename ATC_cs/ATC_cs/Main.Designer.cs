namespace ATC_cs
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_abonents = new System.Windows.Forms.DataGridView();
            this.btn_newTariff = new System.Windows.Forms.Button();
            this.btn_newAbonent = new System.Windows.Forms.Button();
            this.tb_tariff = new System.Windows.Forms.TextBox();
            this.tb_date = new System.Windows.Forms.TextBox();
            this.tb_abonent = new System.Windows.Forms.TextBox();
            this.btn_newPhone = new System.Windows.Forms.Button();
            this.cb_phone = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.телефонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.абонентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тарифыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_abonents)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_abonents
            // 
            this.dgv_abonents.AllowUserToAddRows = false;
            this.dgv_abonents.AllowUserToDeleteRows = false;
            this.dgv_abonents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_abonents.Location = new System.Drawing.Point(288, 53);
            this.dgv_abonents.Name = "dgv_abonents";
            this.dgv_abonents.ReadOnly = true;
            this.dgv_abonents.Size = new System.Drawing.Size(874, 238);
            this.dgv_abonents.TabIndex = 27;
            this.dgv_abonents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_abonents_CellContentClick);
            // 
            // btn_newTariff
            // 
            this.btn_newTariff.Location = new System.Drawing.Point(220, 131);
            this.btn_newTariff.Name = "btn_newTariff";
            this.btn_newTariff.Size = new System.Drawing.Size(43, 20);
            this.btn_newTariff.TabIndex = 26;
            this.btn_newTariff.Text = "...";
            this.btn_newTariff.UseVisualStyleBackColor = true;
            // 
            // btn_newAbonent
            // 
            this.btn_newAbonent.Location = new System.Drawing.Point(221, 80);
            this.btn_newAbonent.Name = "btn_newAbonent";
            this.btn_newAbonent.Size = new System.Drawing.Size(42, 20);
            this.btn_newAbonent.TabIndex = 24;
            this.btn_newAbonent.Text = "...";
            this.btn_newAbonent.UseVisualStyleBackColor = true;
            // 
            // tb_tariff
            // 
            this.tb_tariff.Location = new System.Drawing.Point(117, 131);
            this.tb_tariff.Name = "tb_tariff";
            this.tb_tariff.Size = new System.Drawing.Size(97, 20);
            this.tb_tariff.TabIndex = 23;
            // 
            // tb_date
            // 
            this.tb_date.Location = new System.Drawing.Point(117, 105);
            this.tb_date.Name = "tb_date";
            this.tb_date.Size = new System.Drawing.Size(97, 20);
            this.tb_date.TabIndex = 22;
            // 
            // tb_abonent
            // 
            this.tb_abonent.Location = new System.Drawing.Point(117, 80);
            this.tb_abonent.Name = "tb_abonent";
            this.tb_abonent.Size = new System.Drawing.Size(98, 20);
            this.tb_abonent.TabIndex = 21;
            // 
            // btn_newPhone
            // 
            this.btn_newPhone.Location = new System.Drawing.Point(221, 54);
            this.btn_newPhone.Name = "btn_newPhone";
            this.btn_newPhone.Size = new System.Drawing.Size(42, 20);
            this.btn_newPhone.TabIndex = 20;
            this.btn_newPhone.Text = "...";
            this.btn_newPhone.UseVisualStyleBackColor = true;
            this.btn_newPhone.Click += new System.EventHandler(this.btn_newPhone_Click);
            // 
            // cb_phone
            // 
            this.cb_phone.FormattingEnabled = true;
            this.cb_phone.Location = new System.Drawing.Point(117, 53);
            this.cb_phone.Name = "cb_phone";
            this.cb_phone.Size = new System.Drawing.Size(98, 21);
            this.cb_phone.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Тариф";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Дата рождения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Абонент";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Телефон";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.операцииToolStripMenuItem,
            this.справочникиToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1174, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // операцииToolStripMenuItem
            // 
            this.операцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.печатьToolStripMenuItem});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.печатьToolStripMenuItem.Text = "Печать";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.телефонToolStripMenuItem,
            this.абонентToolStripMenuItem,
            this.тарифыToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // телефонToolStripMenuItem
            // 
            this.телефонToolStripMenuItem.Name = "телефонToolStripMenuItem";
            this.телефонToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.телефонToolStripMenuItem.Text = "Телефоны";
            // 
            // абонентToolStripMenuItem
            // 
            this.абонентToolStripMenuItem.Name = "абонентToolStripMenuItem";
            this.абонентToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.абонентToolStripMenuItem.Text = "Абоненты";
            // 
            // тарифыToolStripMenuItem
            // 
            this.тарифыToolStripMenuItem.Name = "тарифыToolStripMenuItem";
            this.тарифыToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.тарифыToolStripMenuItem.Text = "Тарифы";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem1});
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.оПрограммеToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem1
            // 
            this.оПрограммеToolStripMenuItem1.Name = "оПрограммеToolStripMenuItem1";
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.оПрограммеToolStripMenuItem1.Text = "О программе";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 331);
            this.Controls.Add(this.dgv_abonents);
            this.Controls.Add(this.btn_newTariff);
            this.Controls.Add(this.btn_newAbonent);
            this.Controls.Add(this.tb_tariff);
            this.Controls.Add(this.tb_date);
            this.Controls.Add(this.tb_abonent);
            this.Controls.Add(this.btn_newPhone);
            this.Controls.Add(this.cb_phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Main";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_abonents)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_abonents;
        private System.Windows.Forms.Button btn_newTariff;
        private System.Windows.Forms.Button btn_newAbonent;
        private System.Windows.Forms.TextBox tb_tariff;
        private System.Windows.Forms.TextBox tb_date;
        private System.Windows.Forms.TextBox tb_abonent;
        private System.Windows.Forms.Button btn_newPhone;
        private System.Windows.Forms.ComboBox cb_phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem телефонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem абонентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тарифыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
    }
}

