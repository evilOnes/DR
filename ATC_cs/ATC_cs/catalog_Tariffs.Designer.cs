﻿namespace ATC_cs
{
    partial class catalog_Tariffs
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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_abonents)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(12, 287);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(60, 23);
            this.btn_cancel.TabIndex = 34;
            this.btn_cancel.Text = "Назад";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(238, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 24);
            this.label5.TabIndex = 33;
            this.label5.Text = "Справочник тарифов";
            // 
            // dgv_abonents
            // 
            this.dgv_abonents.AllowUserToAddRows = false;
            this.dgv_abonents.AllowUserToDeleteRows = false;
            this.dgv_abonents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_abonents.Location = new System.Drawing.Point(12, 54);
            this.dgv_abonents.Name = "dgv_abonents";
            this.dgv_abonents.ReadOnly = true;
            this.dgv_abonents.Size = new System.Drawing.Size(683, 219);
            this.dgv_abonents.TabIndex = 32;
            // 
            // catalog_Tariffs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 324);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgv_abonents);
            this.Name = "catalog_Tariffs";
            this.Text = "catalog_Tariffs";
            this.Load += new System.EventHandler(this.catalog_Tariffs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_abonents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btn_cancel;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_abonents;
    }
}