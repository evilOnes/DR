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
            this.btn_newPhone = new System.Windows.Forms.Button();
            this.cb_phone = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.операцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.телефонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.абонентToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тарифыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_done = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_tariff = new System.Windows.Forms.ComboBox();
            this.cb_abonent = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.nud_summa = new System.Windows.Forms.NumericUpDown();
            this.nud_zadol = new System.Windows.Forms.NumericUpDown();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_abonents)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_summa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_zadol)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_abonents
            // 
            this.dgv_abonents.AllowUserToAddRows = false;
            this.dgv_abonents.AllowUserToDeleteRows = false;
            this.dgv_abonents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_abonents.Location = new System.Drawing.Point(315, 53);
            this.dgv_abonents.Name = "dgv_abonents";
            this.dgv_abonents.ReadOnly = true;
            this.dgv_abonents.Size = new System.Drawing.Size(806, 238);
            this.dgv_abonents.TabIndex = 27;
            this.dgv_abonents.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_abonents_CellContentClick);
            // 
            // btn_newTariff
            // 
            this.btn_newTariff.Location = new System.Drawing.Point(220, 172);
            this.btn_newTariff.Name = "btn_newTariff";
            this.btn_newTariff.Size = new System.Drawing.Size(43, 20);
            this.btn_newTariff.TabIndex = 26;
            this.btn_newTariff.Text = "...";
            this.btn_newTariff.UseVisualStyleBackColor = true;
            this.btn_newTariff.Click += new System.EventHandler(this.btn_newTariff_Click);
            // 
            // btn_newAbonent
            // 
            this.btn_newAbonent.Location = new System.Drawing.Point(221, 121);
            this.btn_newAbonent.Name = "btn_newAbonent";
            this.btn_newAbonent.Size = new System.Drawing.Size(42, 20);
            this.btn_newAbonent.TabIndex = 24;
            this.btn_newAbonent.Text = "...";
            this.btn_newAbonent.UseVisualStyleBackColor = true;
            this.btn_newAbonent.Click += new System.EventHandler(this.btn_newAbonent_Click);
            // 
            // btn_newPhone
            // 
            this.btn_newPhone.Location = new System.Drawing.Point(221, 95);
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
            this.cb_phone.Location = new System.Drawing.Point(117, 94);
            this.cb_phone.Name = "cb_phone";
            this.cb_phone.Size = new System.Drawing.Size(98, 21);
            this.cb_phone.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Тариф";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Дата рождения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Абонент";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 102);
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
            this.печатьToolStripMenuItem});
            this.операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            this.операцииToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.операцииToolStripMenuItem.Text = "Операции";
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.печатьToolStripMenuItem.Text = "Печать";
            this.печатьToolStripMenuItem.Click += new System.EventHandler(this.печатьToolStripMenuItem_Click);
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
            this.телефонToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.телефонToolStripMenuItem.Text = "Телефоны";
            this.телефонToolStripMenuItem.Click += new System.EventHandler(this.телефонToolStripMenuItem_Click);
            // 
            // абонентToolStripMenuItem
            // 
            this.абонентToolStripMenuItem.Name = "абонентToolStripMenuItem";
            this.абонентToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.абонентToolStripMenuItem.Text = "Абоненты";
            this.абонентToolStripMenuItem.Click += new System.EventHandler(this.абонентToolStripMenuItem_Click);
            // 
            // тарифыToolStripMenuItem
            // 
            this.тарифыToolStripMenuItem.Name = "тарифыToolStripMenuItem";
            this.тарифыToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.тарифыToolStripMenuItem.Text = "Тарифы";
            this.тарифыToolStripMenuItem.Click += new System.EventHandler(this.тарифыToolStripMenuItem_Click);
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
            this.оПрограммеToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.оПрограммеToolStripMenuItem1.Text = "О программе";
            this.оПрограммеToolStripMenuItem1.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem1_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // btn_done
            // 
            this.btn_done.Location = new System.Drawing.Point(184, 268);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(79, 23);
            this.btn_done.TabIndex = 28;
            this.btn_done.Text = "Выполнить";
            this.btn_done.UseVisualStyleBackColor = true;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(11, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(286, 24);
            this.label5.TabIndex = 29;
            this.label5.Text = "Добавление / редактирование";
            // 
            // cb_tariff
            // 
            this.cb_tariff.FormattingEnabled = true;
            this.cb_tariff.Location = new System.Drawing.Point(116, 171);
            this.cb_tariff.Name = "cb_tariff";
            this.cb_tariff.Size = new System.Drawing.Size(99, 21);
            this.cb_tariff.TabIndex = 30;
            // 
            // cb_abonent
            // 
            this.cb_abonent.FormattingEnabled = true;
            this.cb_abonent.Location = new System.Drawing.Point(117, 122);
            this.cb_abonent.Name = "cb_abonent";
            this.cb_abonent.Size = new System.Drawing.Size(98, 21);
            this.cb_abonent.TabIndex = 31;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(116, 147);
            this.date.MaxDate = new System.DateTime(7998, 12, 31, 0, 0, 0, 0);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(99, 20);
            this.date.TabIndex = 32;
            // 
            // nud_summa
            // 
            this.nud_summa.Location = new System.Drawing.Point(116, 198);
            this.nud_summa.Maximum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            0});
            this.nud_summa.Name = "nud_summa";
            this.nud_summa.Size = new System.Drawing.Size(99, 20);
            this.nud_summa.TabIndex = 33;
            // 
            // nud_zadol
            // 
            this.nud_zadol.Location = new System.Drawing.Point(116, 224);
            this.nud_zadol.Maximum = new decimal(new int[] {
            1661992960,
            1808227885,
            5,
            0});
            this.nud_zadol.Name = "nud_zadol";
            this.nud_zadol.Size = new System.Drawing.Size(99, 20);
            this.nud_zadol.TabIndex = 34;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(15, 268);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(79, 23);
            this.btn_delete.TabIndex = 35;
            this.btn_delete.Text = "Удалить";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Сумма";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Задолжность";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 331);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.nud_zadol);
            this.Controls.Add(this.nud_summa);
            this.Controls.Add(this.date);
            this.Controls.Add(this.cb_abonent);
            this.Controls.Add(this.cb_tariff);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.dgv_abonents);
            this.Controls.Add(this.btn_newTariff);
            this.Controls.Add(this.btn_newAbonent);
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
            ((System.ComponentModel.ISupportInitialize)(this.nud_summa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_zadol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_abonents;
        private System.Windows.Forms.Button btn_newTariff;
        private System.Windows.Forms.Button btn_newAbonent;
        private System.Windows.Forms.Button btn_newPhone;
        private System.Windows.Forms.ComboBox cb_phone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem операцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem телефонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem абонентToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тарифыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        public System.Windows.Forms.Button btn_done;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_tariff;
        private System.Windows.Forms.ComboBox cb_abonent;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.NumericUpDown nud_summa;
        private System.Windows.Forms.NumericUpDown nud_zadol;
        public System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

