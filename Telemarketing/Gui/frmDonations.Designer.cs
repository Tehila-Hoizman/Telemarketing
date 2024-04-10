namespace Telemarketing.Gui
{
    partial class frmDonations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDonations));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_find = new System.Windows.Forms.ComboBox();
            this.cmb_ordedBy = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.PictureBox();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox37 = new System.Windows.Forms.PictureBox();
            this.pictureBox36 = new System.Windows.Forms.PictureBox();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.btn_showDonation = new System.Windows.Forms.Button();
            this.btn_deleteDonation = new System.Windows.Forms.Button();
            this.btn_setDonation = new System.Windows.Forms.Button();
            this.btn_addDonation = new System.Windows.Forms.Button();
            this.pictureBox39 = new System.Windows.Forms.PictureBox();
            this.label37 = new System.Windows.Forms.Label();
            this.dgv_donations = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_donations)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(565, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 48;
            this.label2.Text = "סנן לפי:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(285, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 47;
            this.label1.Text = "מיין לפי:";
            // 
            // cmb_find
            // 
            this.cmb_find.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_find.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_find.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.cmb_find.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_find.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_find.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_find.ForeColor = System.Drawing.Color.White;
            this.cmb_find.FormattingEnabled = true;
            this.cmb_find.Items.AddRange(new object[] {
            "אשראי",
            "צ\'ק",
            "מזומן",
            "הצג הכל"});
            this.cmb_find.Location = new System.Drawing.Point(372, 52);
            this.cmb_find.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_find.Name = "cmb_find";
            this.cmb_find.Size = new System.Drawing.Size(191, 33);
            this.cmb_find.TabIndex = 46;
            this.cmb_find.SelectedIndexChanged += new System.EventHandler(this.cmb_find_SelectedIndexChanged);
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
            "תאריך",
            "תורם",
            "טלפנית",
            "פרויקט"});
            this.cmb_ordedBy.Location = new System.Drawing.Point(93, 52);
            this.cmb_ordedBy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_ordedBy.Name = "cmb_ordedBy";
            this.cmb_ordedBy.Size = new System.Drawing.Size(191, 33);
            this.cmb_ordedBy.TabIndex = 45;
            this.cmb_ordedBy.SelectedIndexChanged += new System.EventHandler(this.cmb_ordedBy_SelectedIndexChanged);
            // 
            // btn_search
            // 
            this.btn_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(1036, 105);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(39, 34);
            this.btn_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_search.TabIndex = 44;
            this.btn_search.TabStop = false;
            // 
            // tb_search
            // 
            this.tb_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tb_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_search.ForeColor = System.Drawing.Color.White;
            this.tb_search.Location = new System.Drawing.Point(1072, 105);
            this.tb_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_search.Multiline = true;
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(138, 34);
            this.tb_search.TabIndex = 43;
            this.tb_search.Text = "חפש תרומה...";
            this.tb_search.Click += new System.EventHandler(this.tb_search_Click);
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1050, 288);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox37
            // 
            this.pictureBox37.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox37.Image")));
            this.pictureBox37.Location = new System.Drawing.Point(1050, 353);
            this.pictureBox37.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox37.Name = "pictureBox37";
            this.pictureBox37.Size = new System.Drawing.Size(32, 30);
            this.pictureBox37.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox37.TabIndex = 40;
            this.pictureBox37.TabStop = false;
            this.pictureBox37.Visible = false;
            // 
            // pictureBox36
            // 
            this.pictureBox36.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox36.Image")));
            this.pictureBox36.Location = new System.Drawing.Point(1050, 225);
            this.pictureBox36.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.Size = new System.Drawing.Size(32, 30);
            this.pictureBox36.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox36.TabIndex = 41;
            this.pictureBox36.TabStop = false;
            // 
            // pictureBox35
            // 
            this.pictureBox35.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox35.Image")));
            this.pictureBox35.Location = new System.Drawing.Point(1050, 160);
            this.pictureBox35.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(32, 30);
            this.pictureBox35.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox35.TabIndex = 42;
            this.pictureBox35.TabStop = false;
            // 
            // btn_showDonation
            // 
            this.btn_showDonation.BackColor = System.Drawing.Color.Transparent;
            this.btn_showDonation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.btn_showDonation.FlatAppearance.BorderSize = 2;
            this.btn_showDonation.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_showDonation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_showDonation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_showDonation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showDonation.ForeColor = System.Drawing.Color.White;
            this.btn_showDonation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_showDonation.Location = new System.Drawing.Point(1036, 282);
            this.btn_showDonation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_showDonation.Name = "btn_showDonation";
            this.btn_showDonation.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.btn_showDonation.Size = new System.Drawing.Size(173, 43);
            this.btn_showDonation.TabIndex = 35;
            this.btn_showDonation.Text = "הצגת תרומה";
            this.btn_showDonation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_showDonation.UseVisualStyleBackColor = false;
            this.btn_showDonation.Click += new System.EventHandler(this.btn_showDonation_Click);
            // 
            // btn_deleteDonation
            // 
            this.btn_deleteDonation.BackColor = System.Drawing.Color.Transparent;
            this.btn_deleteDonation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.btn_deleteDonation.FlatAppearance.BorderSize = 2;
            this.btn_deleteDonation.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_deleteDonation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_deleteDonation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_deleteDonation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deleteDonation.ForeColor = System.Drawing.Color.White;
            this.btn_deleteDonation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deleteDonation.Location = new System.Drawing.Point(1036, 346);
            this.btn_deleteDonation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_deleteDonation.Name = "btn_deleteDonation";
            this.btn_deleteDonation.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.btn_deleteDonation.Size = new System.Drawing.Size(173, 43);
            this.btn_deleteDonation.TabIndex = 34;
            this.btn_deleteDonation.Text = "מחיקת תרומה";
            this.btn_deleteDonation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_deleteDonation.UseVisualStyleBackColor = false;
            this.btn_deleteDonation.Visible = false;
            this.btn_deleteDonation.Click += new System.EventHandler(this.btn_deleteDonation_Click);
            // 
            // btn_setDonation
            // 
            this.btn_setDonation.BackColor = System.Drawing.Color.Transparent;
            this.btn_setDonation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.btn_setDonation.FlatAppearance.BorderSize = 2;
            this.btn_setDonation.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_setDonation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_setDonation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_setDonation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setDonation.ForeColor = System.Drawing.Color.White;
            this.btn_setDonation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setDonation.Location = new System.Drawing.Point(1036, 218);
            this.btn_setDonation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_setDonation.Name = "btn_setDonation";
            this.btn_setDonation.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.btn_setDonation.Size = new System.Drawing.Size(173, 43);
            this.btn_setDonation.TabIndex = 36;
            this.btn_setDonation.Text = "עריכת תרומה";
            this.btn_setDonation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setDonation.UseVisualStyleBackColor = false;
            this.btn_setDonation.Click += new System.EventHandler(this.btn_setDonation_Click);
            // 
            // btn_addDonation
            // 
            this.btn_addDonation.BackColor = System.Drawing.Color.Transparent;
            this.btn_addDonation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.btn_addDonation.FlatAppearance.BorderSize = 2;
            this.btn_addDonation.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_addDonation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_addDonation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_addDonation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addDonation.ForeColor = System.Drawing.Color.White;
            this.btn_addDonation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addDonation.Location = new System.Drawing.Point(1036, 154);
            this.btn_addDonation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addDonation.Name = "btn_addDonation";
            this.btn_addDonation.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.btn_addDonation.Size = new System.Drawing.Size(173, 43);
            this.btn_addDonation.TabIndex = 37;
            this.btn_addDonation.Text = "תרומה חדשה";
            this.btn_addDonation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addDonation.UseVisualStyleBackColor = false;
            this.btn_addDonation.Click += new System.EventHandler(this.btn_addDonation_Click);
            // 
            // pictureBox39
            // 
            this.pictureBox39.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox39.Image")));
            this.pictureBox39.Location = new System.Drawing.Point(965, 52);
            this.pictureBox39.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox39.Name = "pictureBox39";
            this.pictureBox39.Size = new System.Drawing.Size(48, 45);
            this.pictureBox39.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox39.TabIndex = 32;
            this.pictureBox39.TabStop = false;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label37.ForeColor = System.Drawing.Color.White;
            this.label37.Location = new System.Drawing.Point(889, 57);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(76, 28);
            this.label37.TabIndex = 31;
            this.label37.Text = "תרומות";
            // 
            // dgv_donations
            // 
            this.dgv_donations.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_donations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_donations.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_donations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_donations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_donations.ColumnHeadersHeight = 29;
            this.dgv_donations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_donations.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_donations.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_donations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgv_donations.Location = new System.Drawing.Point(93, 105);
            this.dgv_donations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_donations.MultiSelect = false;
            this.dgv_donations.Name = "dgv_donations";
            this.dgv_donations.ReadOnly = true;
            this.dgv_donations.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_donations.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_donations.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_donations.RowHeadersWidth = 30;
            this.dgv_donations.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_donations.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_donations.RowTemplate.Height = 24;
            this.dgv_donations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_donations.Size = new System.Drawing.Size(920, 507);
            this.dgv_donations.TabIndex = 30;
            this.dgv_donations.VirtualMode = true;
            // 
            // frmDonations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1300, 635);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_find);
            this.Controls.Add(this.cmb_ordedBy);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox37);
            this.Controls.Add(this.pictureBox36);
            this.Controls.Add(this.pictureBox35);
            this.Controls.Add(this.btn_showDonation);
            this.Controls.Add(this.btn_deleteDonation);
            this.Controls.Add(this.btn_setDonation);
            this.Controls.Add(this.btn_addDonation);
            this.Controls.Add(this.pictureBox39);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.dgv_donations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDonations";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDonations";
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_donations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_find;
        private System.Windows.Forms.ComboBox cmb_ordedBy;
        private System.Windows.Forms.PictureBox btn_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox37;
        private System.Windows.Forms.PictureBox pictureBox36;
        private System.Windows.Forms.PictureBox pictureBox35;
        private System.Windows.Forms.Button btn_showDonation;
        private System.Windows.Forms.Button btn_deleteDonation;
        private System.Windows.Forms.Button btn_setDonation;
        private System.Windows.Forms.Button btn_addDonation;
        private System.Windows.Forms.PictureBox pictureBox39;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.DataGridView dgv_donations;
    }
}