namespace ATC_cs
{
    partial class catalog_Phones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        private void InitializeComponent()
        {
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_abonents = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_search = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_abonents)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(17, 347);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(80, 28);
            this.btn_cancel.TabIndex = 34;
            this.btn_cancel.Text = "Назад";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(319, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 29);
            this.label5.TabIndex = 33;
            this.label5.Text = "Справочник телефонов";
            // 
            // dgv_abonents
            // 
            this.dgv_abonents.AllowUserToAddRows = false;
            this.dgv_abonents.AllowUserToDeleteRows = false;
            this.dgv_abonents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_abonents.Location = new System.Drawing.Point(17, 139);
            this.dgv_abonents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_abonents.Name = "dgv_abonents";
            this.dgv_abonents.ReadOnly = true;
            this.dgv_abonents.Size = new System.Drawing.Size(911, 191);
            this.dgv_abonents.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Поиск";
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_search.Location = new System.Drawing.Point(83, 93);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(845, 30);
            this.tb_search.TabIndex = 35;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // catalog_Phones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 384);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_abonents);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "catalog_Phones";
            this.Text = "catalog_Phones";
            this.Load += new System.EventHandler(this.catalog_Phones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_abonents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_abonents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_search;
    }
}