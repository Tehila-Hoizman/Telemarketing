namespace Telemarketing.Gui
{
    partial class frmOneEmployee
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_currentStatus = new System.Windows.Forms.Label();
            this.pnl_close = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_houseNumber = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_level = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_lastName = new System.Windows.Forms.Label();
            this.lbl_firstName = new System.Windows.Forms.Label();
            this.pnl_savingOption = new System.Windows.Forms.Panel();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.cmb_level = new System.Windows.Forms.ComboBox();
            this.cmb_currentStatus = new System.Windows.Forms.ComboBox();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_usename = new System.Windows.Forms.TextBox();
            this.tb_level = new System.Windows.Forms.TextBox();
            this.tB_phone = new System.Windows.Forms.TextBox();
            this.tb_lastName = new System.Windows.Forms.TextBox();
            this.tb_firstName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.pnl_close.SuspendLayout();
            this.pnl_savingOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_username);
            this.panel1.Controls.Add(this.lbl_currentStatus);
            this.panel1.Controls.Add(this.pnl_close);
            this.panel1.Controls.Add(this.lbl_status);
            this.panel1.Controls.Add(this.lbl_houseNumber);
            this.panel1.Controls.Add(this.lbl_password);
            this.panel1.Controls.Add(this.lbl_level);
            this.panel1.Controls.Add(this.lbl_phone);
            this.panel1.Controls.Add(this.lbl_lastName);
            this.panel1.Controls.Add(this.lbl_firstName);
            this.panel1.Controls.Add(this.pnl_savingOption);
            this.panel1.Controls.Add(this.cmb_level);
            this.panel1.Controls.Add(this.cmb_currentStatus);
            this.panel1.Controls.Add(this.cmb_status);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.tb_password);
            this.panel1.Controls.Add(this.tb_usename);
            this.panel1.Controls.Add(this.tb_level);
            this.panel1.Controls.Add(this.tB_phone);
            this.panel1.Controls.Add(this.tb_lastName);
            this.panel1.Controls.Add(this.tb_firstName);
            this.panel1.Location = new System.Drawing.Point(244, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(795, 462);
            this.panel1.TabIndex = 38;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_username.Location = new System.Drawing.Point(603, 195);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(0, 16);
            this.lbl_username.TabIndex = 16;
            // 
            // lbl_currentStatus
            // 
            this.lbl_currentStatus.AutoSize = true;
            this.lbl_currentStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_currentStatus.Location = new System.Drawing.Point(424, 282);
            this.lbl_currentStatus.Name = "lbl_currentStatus";
            this.lbl_currentStatus.Size = new System.Drawing.Size(0, 16);
            this.lbl_currentStatus.TabIndex = 15;
            this.lbl_currentStatus.Visible = false;
            // 
            // pnl_close
            // 
            this.pnl_close.Controls.Add(this.btn_close);
            this.pnl_close.Location = new System.Drawing.Point(3, 390);
            this.pnl_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_close.Name = "pnl_close";
            this.pnl_close.Size = new System.Drawing.Size(149, 63);
            this.pnl_close.TabIndex = 5;
            this.pnl_close.Visible = false;
            this.pnl_close.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_close_Paint);
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(19, 11);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(127, 38);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "סגור";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_status.Location = new System.Drawing.Point(611, 285);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 16);
            this.lbl_status.TabIndex = 14;
            // 
            // lbl_houseNumber
            // 
            this.lbl_houseNumber.AutoSize = true;
            this.lbl_houseNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_houseNumber.Location = new System.Drawing.Point(219, 194);
            this.lbl_houseNumber.Name = "lbl_houseNumber";
            this.lbl_houseNumber.Size = new System.Drawing.Size(0, 16);
            this.lbl_houseNumber.TabIndex = 12;
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_password.Location = new System.Drawing.Point(380, 194);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(0, 16);
            this.lbl_password.TabIndex = 11;
            // 
            // lbl_level
            // 
            this.lbl_level.AutoSize = true;
            this.lbl_level.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_level.Location = new System.Drawing.Point(32, 102);
            this.lbl_level.Name = "lbl_level";
            this.lbl_level.Size = new System.Drawing.Size(0, 16);
            this.lbl_level.TabIndex = 10;
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_phone.Location = new System.Drawing.Point(219, 105);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(0, 16);
            this.lbl_phone.TabIndex = 9;
            // 
            // lbl_lastName
            // 
            this.lbl_lastName.AutoSize = true;
            this.lbl_lastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_lastName.Location = new System.Drawing.Point(413, 106);
            this.lbl_lastName.Name = "lbl_lastName";
            this.lbl_lastName.Size = new System.Drawing.Size(0, 16);
            this.lbl_lastName.TabIndex = 8;
            // 
            // lbl_firstName
            // 
            this.lbl_firstName.AutoSize = true;
            this.lbl_firstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_firstName.Location = new System.Drawing.Point(608, 106);
            this.lbl_firstName.Name = "lbl_firstName";
            this.lbl_firstName.Size = new System.Drawing.Size(0, 16);
            this.lbl_firstName.TabIndex = 7;
            // 
            // pnl_savingOption
            // 
            this.pnl_savingOption.Controls.Add(this.btn_cancel);
            this.pnl_savingOption.Controls.Add(this.btn_save);
            this.pnl_savingOption.Location = new System.Drawing.Point(28, 346);
            this.pnl_savingOption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl_savingOption.Name = "pnl_savingOption";
            this.pnl_savingOption.Size = new System.Drawing.Size(304, 63);
            this.pnl_savingOption.TabIndex = 5;
            this.pnl_savingOption.Visible = false;
            // 
            // btn_cancel
            // 
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(35)))), ((int)(((byte)(224)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(159, 14);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(127, 38);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "ביטול";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(13, 14);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(120, 38);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "שמור";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cmb_level
            // 
            this.cmb_level.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_level.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_level.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.cmb_level.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_level.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_level.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmb_level.ForeColor = System.Drawing.Color.White;
            this.cmb_level.FormattingEnabled = true;
            this.cmb_level.ItemHeight = 22;
            this.cmb_level.Items.AddRange(new object[] {
            "מנהל",
            "טלפנית",
            "אחר"});
            this.cmb_level.Location = new System.Drawing.Point(27, 66);
            this.cmb_level.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_level.Name = "cmb_level";
            this.cmb_level.Size = new System.Drawing.Size(161, 30);
            this.cmb_level.TabIndex = 2;
            this.cmb_level.EnabledChanged += new System.EventHandler(this.cmb_currentStatus_EnabledChanged);
            // 
            // cmb_currentStatus
            // 
            this.cmb_currentStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_currentStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_currentStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.cmb_currentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_currentStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_currentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmb_currentStatus.ForeColor = System.Drawing.Color.White;
            this.cmb_currentStatus.FormattingEnabled = true;
            this.cmb_currentStatus.ItemHeight = 22;
            this.cmb_currentStatus.Items.AddRange(new object[] {
            "מחובר",
            "לא מחובר"});
            this.cmb_currentStatus.Location = new System.Drawing.Point(420, 250);
            this.cmb_currentStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_currentStatus.Name = "cmb_currentStatus";
            this.cmb_currentStatus.Size = new System.Drawing.Size(161, 30);
            this.cmb_currentStatus.TabIndex = 2;
            this.cmb_currentStatus.Visible = false;
            this.cmb_currentStatus.EnabledChanged += new System.EventHandler(this.cmb_currentStatus_EnabledChanged);
            // 
            // cmb_status
            // 
            this.cmb_status.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_status.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.cmb_status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_status.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmb_status.ForeColor = System.Drawing.Color.White;
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.ItemHeight = 22;
            this.cmb_status.Items.AddRange(new object[] {
            "פעיל",
            "לא פעיל"});
            this.cmb_status.Location = new System.Drawing.Point(607, 250);
            this.cmb_status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(161, 30);
            this.cmb_status.TabIndex = 2;
            this.cmb_status.SelectedIndexChanged += new System.EventHandler(this.cmb_status_SelectedIndexChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(496, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "סטטוס נוכחי";
            this.label9.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(687, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "סטטוס כללי";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(519, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "סיסמה";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(678, 138);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "שם משתמש";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(151, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "דרגה";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(337, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "טלפון";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(488, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "שם משפחה";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(703, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "שם פרטי";
            // 
            // tb_password
            // 
            this.tb_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tb_password.ForeColor = System.Drawing.Color.White;
            this.tb_password.Location = new System.Drawing.Point(408, 159);
            this.tb_password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_password.Multiline = true;
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(161, 34);
            this.tb_password.TabIndex = 0;
            // 
            // tb_usename
            // 
            this.tb_usename.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tb_usename.ForeColor = System.Drawing.Color.White;
            this.tb_usename.Location = new System.Drawing.Point(603, 159);
            this.tb_usename.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_usename.Multiline = true;
            this.tb_usename.Name = "tb_usename";
            this.tb_usename.Size = new System.Drawing.Size(161, 34);
            this.tb_usename.TabIndex = 0;
            // 
            // tb_level
            // 
            this.tb_level.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tb_level.ForeColor = System.Drawing.Color.White;
            this.tb_level.Location = new System.Drawing.Point(32, 192);
            this.tb_level.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_level.Multiline = true;
            this.tb_level.Name = "tb_level";
            this.tb_level.Size = new System.Drawing.Size(161, 34);
            this.tb_level.TabIndex = 0;
            this.tb_level.Visible = false;
            // 
            // tB_phone
            // 
            this.tB_phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tB_phone.ForeColor = System.Drawing.Color.White;
            this.tB_phone.Location = new System.Drawing.Point(215, 66);
            this.tB_phone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tB_phone.Multiline = true;
            this.tB_phone.Name = "tB_phone";
            this.tB_phone.Size = new System.Drawing.Size(161, 34);
            this.tB_phone.TabIndex = 0;
            // 
            // tb_lastName
            // 
            this.tb_lastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tb_lastName.ForeColor = System.Drawing.Color.White;
            this.tb_lastName.Location = new System.Drawing.Point(408, 66);
            this.tb_lastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_lastName.Multiline = true;
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(161, 34);
            this.tb_lastName.TabIndex = 0;
            // 
            // tb_firstName
            // 
            this.tb_firstName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tb_firstName.ForeColor = System.Drawing.Color.White;
            this.tb_firstName.Location = new System.Drawing.Point(603, 66);
            this.tb_firstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_firstName.Multiline = true;
            this.tb_firstName.Name = "tb_firstName";
            this.tb_firstName.Size = new System.Drawing.Size(161, 34);
            this.tb_firstName.TabIndex = 0;
            // 
            // frmOneEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1300, 635);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOneEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOneEmployee";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnl_close.ResumeLayout(false);
            this.pnl_savingOption.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_currentStatus;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_houseNumber;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_level;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_lastName;
        private System.Windows.Forms.Label lbl_firstName;
        private System.Windows.Forms.Panel pnl_savingOption;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel pnl_close;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.ComboBox cmb_currentStatus;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_usename;
        private System.Windows.Forms.TextBox tb_level;
        private System.Windows.Forms.TextBox tB_phone;
        private System.Windows.Forms.TextBox tb_lastName;
        private System.Windows.Forms.TextBox tb_firstName;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.ComboBox cmb_level;
    }
}