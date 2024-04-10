namespace Telemarketing.Gui
{
    partial class frmProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProject));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_search = new System.Windows.Forms.PictureBox();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.pnl_projectDetail = new System.Windows.Forms.Panel();
            this.nud_bonus = new System.Windows.Forms.NumericUpDown();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_target = new System.Windows.Forms.TextBox();
            this.tb_projectName = new System.Windows.Forms.TextBox();
            this.tb_kod = new System.Windows.Forms.TextBox();
            this.pictureBox39 = new System.Windows.Forms.PictureBox();
            this.label37 = new System.Windows.Forms.Label();
            this.pictureBox36 = new System.Windows.Forms.PictureBox();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.btn_setCity = new System.Windows.Forms.Button();
            this.btn_addCity = new System.Windows.Forms.Button();
            this.dgv_projects = new System.Windows.Forms.DataGridView();
            this.btn_close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).BeginInit();
            this.pnl_projectDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_bonus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_projects)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btn_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(623, 33);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(38, 34);
            this.btn_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_search.TabIndex = 48;
            this.btn_search.TabStop = false;
            // 
            // tb_search
            // 
            this.tb_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.tb_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_search.ForeColor = System.Drawing.Color.White;
            this.tb_search.Location = new System.Drawing.Point(657, 33);
            this.tb_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_search.Multiline = true;
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(150, 34);
            this.tb_search.TabIndex = 47;
            this.tb_search.Text = "חפש פרויקט...";
            this.tb_search.Click += new System.EventHandler(this.tb_search_Click);
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // pnl_projectDetail
            // 
            this.pnl_projectDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_projectDetail.Controls.Add(this.nud_bonus);
            this.pnl_projectDetail.Controls.Add(this.cmb_status);
            this.pnl_projectDetail.Controls.Add(this.label8);
            this.pnl_projectDetail.Controls.Add(this.label7);
            this.pnl_projectDetail.Controls.Add(this.label5);
            this.pnl_projectDetail.Controls.Add(this.lblError);
            this.pnl_projectDetail.Controls.Add(this.btn_cancel);
            this.pnl_projectDetail.Controls.Add(this.btn_save);
            this.pnl_projectDetail.Controls.Add(this.label6);
            this.pnl_projectDetail.Controls.Add(this.label4);
            this.pnl_projectDetail.Controls.Add(this.label2);
            this.pnl_projectDetail.Controls.Add(this.label3);
            this.pnl_projectDetail.Controls.Add(this.label1);
            this.pnl_projectDetail.Controls.Add(this.tb_target);
            this.pnl_projectDetail.Controls.Add(this.tb_projectName);
            this.pnl_projectDetail.Controls.Add(this.tb_kod);
            this.pnl_projectDetail.Location = new System.Drawing.Point(84, 79);
            this.pnl_projectDetail.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_projectDetail.Name = "pnl_projectDetail";
            this.pnl_projectDetail.Size = new System.Drawing.Size(240, 436);
            this.pnl_projectDetail.TabIndex = 46;
            this.pnl_projectDetail.Visible = false;
            // 
            // nud_bonus
            // 
            this.nud_bonus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.nud_bonus.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nud_bonus.ForeColor = System.Drawing.Color.White;
            this.nud_bonus.Location = new System.Drawing.Point(74, 287);
            this.nud_bonus.Name = "nud_bonus";
            this.nud_bonus.Size = new System.Drawing.Size(128, 30);
            this.nud_bonus.TabIndex = 50;
            // 
            // cmb_status
            // 
            this.cmb_status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_status.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.cmb_status.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cmb_status.DropDownHeight = 170;
            this.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_status.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmb_status.ForeColor = System.Drawing.Color.White;
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.IntegralHeight = false;
            this.cmb_status.ItemHeight = 22;
            this.cmb_status.Items.AddRange(new object[] {
            "פעיל",
            "לא פעיל"});
            this.cmb_status.Location = new System.Drawing.Point(41, 223);
            this.cmb_status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(161, 30);
            this.cmb_status.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label8.Location = new System.Drawing.Point(68, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 16);
            this.label8.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label7.Location = new System.Drawing.Point(111, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label5.Location = new System.Drawing.Point(43, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 4;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblError.Location = new System.Drawing.Point(43, 131);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 16);
            this.lblError.TabIndex = 4;
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(35)))), ((int)(((byte)(224)))));
            this.btn_cancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(35)))), ((int)(((byte)(224)))));
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(35)))), ((int)(((byte)(224)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(111, 340);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(77, 38);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "ביטול";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.btn_save.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(40, 339);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(65, 38);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "שמור";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(74, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "אחוז בונוס מעיסקה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(150, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "סטטוס";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(126, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "שם פרויקט";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(136, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "סכום יעד";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(173, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "קוד";
            // 
            // tb_target
            // 
            this.tb_target.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tb_target.ForeColor = System.Drawing.Color.White;
            this.tb_target.Location = new System.Drawing.Point(41, 152);
            this.tb_target.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_target.Multiline = true;
            this.tb_target.Name = "tb_target";
            this.tb_target.Size = new System.Drawing.Size(161, 34);
            this.tb_target.TabIndex = 2;
            this.tb_target.TextChanged += new System.EventHandler(this.tb_target_TextChanged);
            // 
            // tb_projectName
            // 
            this.tb_projectName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tb_projectName.ForeColor = System.Drawing.Color.White;
            this.tb_projectName.Location = new System.Drawing.Point(43, 95);
            this.tb_projectName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_projectName.Multiline = true;
            this.tb_projectName.Name = "tb_projectName";
            this.tb_projectName.Size = new System.Drawing.Size(161, 34);
            this.tb_projectName.TabIndex = 2;
            // 
            // tb_kod
            // 
            this.tb_kod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tb_kod.ForeColor = System.Drawing.Color.White;
            this.tb_kod.Location = new System.Drawing.Point(43, 32);
            this.tb_kod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_kod.Multiline = true;
            this.tb_kod.Name = "tb_kod";
            this.tb_kod.ReadOnly = true;
            this.tb_kod.Size = new System.Drawing.Size(161, 34);
            this.tb_kod.TabIndex = 2;
            // 
            // pictureBox39
            // 
            this.pictureBox39.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox39.Image")));
            this.pictureBox39.Location = new System.Drawing.Point(934, 33);
            this.pictureBox39.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox39.Name = "pictureBox39";
            this.pictureBox39.Size = new System.Drawing.Size(49, 34);
            this.pictureBox39.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox39.TabIndex = 45;
            this.pictureBox39.TabStop = false;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label37.ForeColor = System.Drawing.Color.White;
            this.label37.Location = new System.Drawing.Point(836, 39);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(92, 28);
            this.label37.TabIndex = 44;
            this.label37.Text = "פרויקטים";
            // 
            // pictureBox36
            // 
            this.pictureBox36.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox36.Image")));
            this.pictureBox36.Location = new System.Drawing.Point(1014, 154);
            this.pictureBox36.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.Size = new System.Drawing.Size(32, 30);
            this.pictureBox36.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox36.TabIndex = 42;
            this.pictureBox36.TabStop = false;
            // 
            // pictureBox35
            // 
            this.pictureBox35.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox35.Image")));
            this.pictureBox35.Location = new System.Drawing.Point(1014, 87);
            this.pictureBox35.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(32, 30);
            this.pictureBox35.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox35.TabIndex = 43;
            this.pictureBox35.TabStop = false;
            // 
            // btn_setCity
            // 
            this.btn_setCity.BackColor = System.Drawing.Color.Transparent;
            this.btn_setCity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.btn_setCity.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_setCity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_setCity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_setCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setCity.ForeColor = System.Drawing.Color.White;
            this.btn_setCity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setCity.Location = new System.Drawing.Point(1000, 146);
            this.btn_setCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_setCity.Name = "btn_setCity";
            this.btn_setCity.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.btn_setCity.Size = new System.Drawing.Size(174, 43);
            this.btn_setCity.TabIndex = 39;
            this.btn_setCity.Text = "עריכת פרויקט";
            this.btn_setCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setCity.UseVisualStyleBackColor = false;
            this.btn_setCity.Click += new System.EventHandler(this.btn_setCity_Click);
            // 
            // btn_addCity
            // 
            this.btn_addCity.BackColor = System.Drawing.Color.Transparent;
            this.btn_addCity.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.btn_addCity.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_addCity.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_addCity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_addCity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addCity.ForeColor = System.Drawing.Color.White;
            this.btn_addCity.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addCity.Location = new System.Drawing.Point(1000, 81);
            this.btn_addCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addCity.Name = "btn_addCity";
            this.btn_addCity.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.btn_addCity.Size = new System.Drawing.Size(174, 43);
            this.btn_addCity.TabIndex = 40;
            this.btn_addCity.Text = "הוספת פרויקט";
            this.btn_addCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addCity.UseVisualStyleBackColor = false;
            this.btn_addCity.Click += new System.EventHandler(this.btn_addCity_Click);
            // 
            // dgv_projects
            // 
            this.dgv_projects.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_projects.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_projects.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_projects.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_projects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_projects.ColumnHeadersHeight = 29;
            this.dgv_projects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_projects.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_projects.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_projects.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgv_projects.Location = new System.Drawing.Point(347, 79);
            this.dgv_projects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_projects.MultiSelect = false;
            this.dgv_projects.Name = "dgv_projects";
            this.dgv_projects.ReadOnly = true;
            this.dgv_projects.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_projects.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_projects.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_projects.RowHeadersWidth = 51;
            this.dgv_projects.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_projects.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_projects.RowTemplate.Height = 24;
            this.dgv_projects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_projects.Size = new System.Drawing.Size(636, 488);
            this.dgv_projects.TabIndex = 37;
            this.dgv_projects.VirtualMode = true;
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.btn_close.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(84, 508);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(129, 38);
            this.btn_close.TabIndex = 49;
            this.btn_close.Text = "סגור";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // frmProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1282, 588);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.pnl_projectDetail);
            this.Controls.Add(this.pictureBox39);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.pictureBox36);
            this.Controls.Add(this.pictureBox35);
            this.Controls.Add(this.btn_setCity);
            this.Controls.Add(this.btn_addCity);
            this.Controls.Add(this.dgv_projects);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProject";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProject";
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).EndInit();
            this.pnl_projectDetail.ResumeLayout(false);
            this.pnl_projectDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_bonus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_projects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Panel pnl_projectDetail;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_projectName;
        private System.Windows.Forms.TextBox tb_kod;
        private System.Windows.Forms.PictureBox pictureBox39;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.PictureBox pictureBox36;
        private System.Windows.Forms.PictureBox pictureBox35;
        private System.Windows.Forms.Button btn_setCity;
        private System.Windows.Forms.Button btn_addCity;
        private System.Windows.Forms.DataGridView dgv_projects;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_target;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_bonus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}