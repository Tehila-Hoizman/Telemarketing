namespace Telemarketing
{
    partial class Form1
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
            this.dgv_donors = new System.Windows.Forms.DataGridView();
            this.dgv_cities = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_donors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cities)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_donors
            // 
            this.dgv_donors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_donors.Location = new System.Drawing.Point(112, 41);
            this.dgv_donors.Name = "dgv_donors";
            this.dgv_donors.RowHeadersWidth = 51;
            this.dgv_donors.RowTemplate.Height = 24;
            this.dgv_donors.Size = new System.Drawing.Size(676, 73);
            this.dgv_donors.TabIndex = 0;
            // 
            // dgv_cities
            // 
            this.dgv_cities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cities.Location = new System.Drawing.Point(112, 155);
            this.dgv_cities.Name = "dgv_cities";
            this.dgv_cities.RowHeadersWidth = 51;
            this.dgv_cities.RowTemplate.Height = 24;
            this.dgv_cities.Size = new System.Drawing.Size(676, 73);
            this.dgv_cities.TabIndex = 0;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(112, 258);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(676, 73);
            this.dataGridView3.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dgv_cities);
            this.Controls.Add(this.dgv_donors);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_donors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cities)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_donors;
        private System.Windows.Forms.DataGridView dgv_cities;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}

