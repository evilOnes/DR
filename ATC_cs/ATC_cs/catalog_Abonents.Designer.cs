namespace ATC_cs
{
    partial class catalog_Abonents
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
            this.dgv_abonents = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_abonents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_abonents
            // 
            this.dgv_abonents.AllowUserToAddRows = false;
            this.dgv_abonents.AllowUserToDeleteRows = false;
            this.dgv_abonents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_abonents.Location = new System.Drawing.Point(16, 142);
            this.dgv_abonents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_abonents.Name = "dgv_abonents";
            this.dgv_abonents.ReadOnly = true;
            this.dgv_abonents.Size = new System.Drawing.Size(911, 194);
            this.dgv_abonents.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(317, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(285, 29);
            this.label5.TabIndex = 30;
            this.label5.Text = "Справочник абонентов";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(16, 353);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(80, 28);
            this.btn_cancel.TabIndex = 31;
            this.btn_cancel.Text = "Назад";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_search.Location = new System.Drawing.Point(82, 104);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(845, 30);
            this.tb_search.TabIndex = 32;
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Поиск";
            // 
            // catalog_Abonents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 396);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_abonents);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "catalog_Abonents";
            this.Text = "catalog_Abonents";
            this.Load += new System.EventHandler(this.catalog_Abonents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_abonents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_abonents;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label label1;
    }
}