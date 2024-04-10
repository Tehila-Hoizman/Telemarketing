namespace Telemarketing.Gui
{
    partial class frmConversation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConversation));
            this.dgv_conversations = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_ordedBy = new System.Windows.Forms.ComboBox();
            this.pictureBox39 = new System.Windows.Forms.PictureBox();
            this.label37 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_conversations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_conversations
            // 
            this.dgv_conversations.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_conversations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_conversations.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_conversations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_conversations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_conversations.ColumnHeadersHeight = 29;
            this.dgv_conversations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_conversations.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_conversations.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_conversations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgv_conversations.Location = new System.Drawing.Point(41, 93);
            this.dgv_conversations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_conversations.MultiSelect = false;
            this.dgv_conversations.Name = "dgv_conversations";
            this.dgv_conversations.ReadOnly = true;
            this.dgv_conversations.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_conversations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_conversations.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_conversations.RowHeadersWidth = 30;
            this.dgv_conversations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_conversations.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgv_conversations.RowTemplate.Height = 24;
            this.dgv_conversations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_conversations.Size = new System.Drawing.Size(1199, 460);
            this.dgv_conversations.TabIndex = 9;
            this.dgv_conversations.VirtualMode = true;
            this.dgv_conversations.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_conversations_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(233, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 53;
            this.label1.Text = "מיין לפי:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmb_ordedBy
            // 
            this.cmb_ordedBy.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_ordedBy.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_ordedBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.cmb_ordedBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ordedBy.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_ordedBy.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ordedBy.ForeColor = System.Drawing.Color.White;
            this.cmb_ordedBy.FormattingEnabled = true;
            this.cmb_ordedBy.Items.AddRange(new object[] {
            "תורם",
            "טלפנית",
            "תאריך",
            "זמן חזרה"});
            this.cmb_ordedBy.Location = new System.Drawing.Point(41, 47);
            this.cmb_ordedBy.Name = "cmb_ordedBy";
            this.cmb_ordedBy.Size = new System.Drawing.Size(190, 33);
            this.cmb_ordedBy.TabIndex = 51;
            this.cmb_ordedBy.SelectedIndexChanged += new System.EventHandler(this.cmb_ordedBy_SelectedIndexChanged);
            // 
            // pictureBox39
            // 
            this.pictureBox39.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox39.Image")));
            this.pictureBox39.Location = new System.Drawing.Point(1195, 42);
            this.pictureBox39.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox39.Name = "pictureBox39";
            this.pictureBox39.Size = new System.Drawing.Size(45, 34);
            this.pictureBox39.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox39.TabIndex = 50;
            this.pictureBox39.TabStop = false;
            this.pictureBox39.Click += new System.EventHandler(this.pictureBox39_Click);
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label37.ForeColor = System.Drawing.Color.White;
            this.label37.Location = new System.Drawing.Point(1123, 47);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(66, 28);
            this.label37.TabIndex = 49;
            this.label37.Text = "שיחות";
            this.label37.Click += new System.EventHandler(this.label37_Click);
            // 
            // frmConversation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1282, 588);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_ordedBy);
            this.Controls.Add(this.pictureBox39);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.dgv_conversations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConversation";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmConversation";
            this.Load += new System.EventHandler(this.frmConversation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_conversations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_conversations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_ordedBy;
        private System.Windows.Forms.PictureBox pictureBox39;
        private System.Windows.Forms.Label label37;
    }
}