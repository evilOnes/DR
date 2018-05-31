namespace ATC_cs
{
    partial class newPhone
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        public void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.cb_idA = new System.Windows.Forms.ComboBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_zadol = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_done = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_zadol)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Новый телефон";
            // 
            // tb_phone
            // 
            this.tb_phone.Location = new System.Drawing.Point(12, 64);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(100, 20);
            this.tb_phone.TabIndex = 1;
            // 
            // cb_idA
            // 
            this.cb_idA.FormattingEnabled = true;
            this.cb_idA.Location = new System.Drawing.Point(120, 64);
            this.cb_idA.Name = "cb_idA";
            this.cb_idA.Size = new System.Drawing.Size(73, 21);
            this.cb_idA.TabIndex = 2;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(12, 155);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(181, 20);
            this.date.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Код абонента";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Номер";
            // 
            // nud_zadol
            // 
            this.nud_zadol.DecimalPlaces = 2;
            this.nud_zadol.Location = new System.Drawing.Point(90, 100);
            this.nud_zadol.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nud_zadol.Name = "nud_zadol";
            this.nud_zadol.Size = new System.Drawing.Size(103, 20);
            this.nud_zadol.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Задолжность";
            // 
            // btn_done
            // 
            this.btn_done.Location = new System.Drawing.Point(133, 200);
            this.btn_done.Name = "btn_done";
            this.btn_done.Size = new System.Drawing.Size(60, 23);
            this.btn_done.TabIndex = 10;
            this.btn_done.Text = "Создать";
            this.btn_done.UseVisualStyleBackColor = true;
            this.btn_done.Click += new System.EventHandler(this.btn_done_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(12, 200);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(60, 23);
            this.btn_cancel.TabIndex = 9;
            this.btn_cancel.Text = "Отмена";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // newPhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 240);
            this.Controls.Add(this.btn_done);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nud_zadol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.date);
            this.Controls.Add(this.cb_idA);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.label1);
            this.Name = "newPhone";
            this.Text = "newPhone";
            this.Load += new System.EventHandler(this.newPhone_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_zadol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox tb_phone;
        public System.Windows.Forms.ComboBox cb_idA;
        public System.Windows.Forms.DateTimePicker date;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.NumericUpDown nud_zadol;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btn_done;
        public System.Windows.Forms.Button btn_cancel;
    }
}