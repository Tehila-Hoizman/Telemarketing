namespace Telemarketing.Gui
{
    partial class frmEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployees));
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
            this.pictureBox36 = new System.Windows.Forms.PictureBox();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.btn_showEmployee = new System.Windows.Forms.Button();
            this.btn_setEmployee = new System.Windows.Forms.Button();
            this.btn_addEmployee = new System.Windows.Forms.Button();
            this.pictureBox39 = new System.Windows.Forms.PictureBox();
            this.label37 = new System.Windows.Forms.Label();
            this.dgv_employees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employees)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(565, 58);
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
            this.label1.Location = new System.Drawing.Point(285, 58);
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
            "פעילים",
            "לא פעילים",
            "מחוברים",
            "לא מחוברים",
            "הצג הכל"});
            this.cmb_find.Location = new System.Drawing.Point(371, 53);
            this.cmb_find.Name = "cmb_find";
            this.cmb_find.Size = new System.Drawing.Size(190, 33);
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
            "קוד תורם",
            "שם פרטי",
            "שם משפחה",
            "סטטוס כללי",
            "מצב נוכחי",
            "דרגה"});
            this.cmb_ordedBy.Location = new System.Drawing.Point(93, 53);
            this.cmb_ordedBy.Name = "cmb_ordedBy";
            this.cmb_ordedBy.Size = new System.Drawing.Size(190, 33);
            this.cmb_ordedBy.TabIndex = 45;
            this.cmb_ordedBy.SelectedIndexChanged += new System.EventHandler(this.cmb_ordedBy_SelectedIndexChanged);
            // 
            // btn_search
            // 
            this.btn_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(1035, 106);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(40, 34);
            this.btn_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_search.TabIndex = 44;
            this.btn_search.TabStop = false;
            // 
            // tb_search
            // 
            this.tb_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.tb_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_search.ForeColor = System.Drawing.Color.White;
            this.tb_search.Location = new System.Drawing.Point(1071, 106);
            this.tb_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_search.Multiline = true;
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(138, 34);
            this.tb_search.TabIndex = 43;
            this.tb_search.Text = "חפש עובד...";
            this.tb_search.Click += new System.EventHandler(this.tb_search_Click);
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1051, 290);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox36
            // 
            this.pictureBox36.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox36.Image")));
            this.pictureBox36.Location = new System.Drawing.Point(1051, 228);
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
            this.pictureBox35.Location = new System.Drawing.Point(1051, 163);
            this.pictureBox35.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(32, 30);
            this.pictureBox35.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox35.TabIndex = 42;
            this.pictureBox35.TabStop = false;
            // 
            // btn_showEmployee
            // 
            this.btn_showEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btn_showEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.btn_showEmployee.FlatAppearance.BorderSize = 2;
            this.btn_showEmployee.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_showEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_showEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_showEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_showEmployee.ForeColor = System.Drawing.Color.White;
            this.btn_showEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_showEmployee.Location = new System.Drawing.Point(1035, 284);
            this.btn_showEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_showEmployee.Name = "btn_showEmployee";
            this.btn_showEmployee.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.btn_showEmployee.Size = new System.Drawing.Size(174, 43);
            this.btn_showEmployee.TabIndex = 35;
            this.btn_showEmployee.Text = "הצגת עובד";
            this.btn_showEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_showEmployee.UseVisualStyleBackColor = false;
            this.btn_showEmployee.Click += new System.EventHandler(this.btn_showEmployee_Click);
            // 
            // btn_setEmployee
            // 
            this.btn_setEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btn_setEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.btn_setEmployee.FlatAppearance.BorderSize = 2;
            this.btn_setEmployee.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_setEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_setEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_setEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_setEmployee.ForeColor = System.Drawing.Color.White;
            this.btn_setEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setEmployee.Location = new System.Drawing.Point(1035, 220);
            this.btn_setEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_setEmployee.Name = "btn_setEmployee";
            this.btn_setEmployee.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.btn_setEmployee.Size = new System.Drawing.Size(174, 43);
            this.btn_setEmployee.TabIndex = 36;
            this.btn_setEmployee.Text = "עריכת עובד";
            this.btn_setEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_setEmployee.UseVisualStyleBackColor = false;
            this.btn_setEmployee.Click += new System.EventHandler(this.btn_setEmployee_Click);
            // 
            // btn_addEmployee
            // 
            this.btn_addEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btn_addEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.btn_addEmployee.FlatAppearance.BorderSize = 2;
            this.btn_addEmployee.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_addEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_addEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_addEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addEmployee.ForeColor = System.Drawing.Color.White;
            this.btn_addEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addEmployee.Location = new System.Drawing.Point(1035, 155);
            this.btn_addEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_addEmployee.Name = "btn_addEmployee";
            this.btn_addEmployee.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.btn_addEmployee.Size = new System.Drawing.Size(174, 43);
            this.btn_addEmployee.TabIndex = 37;
            this.btn_addEmployee.Text = "הוספת עובד";
            this.btn_addEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_addEmployee.UseVisualStyleBackColor = false;
            this.btn_addEmployee.Click += new System.EventHandler(this.btn_addEmployee_Click);
            this.btn_addEmployee.Enter += new System.EventHandler(this.btn_addEmployee_Enter);
            this.btn_addEmployee.Leave += new System.EventHandler(this.btn_addEmployee_Leave);
            // 
            // pictureBox39
            // 
            this.pictureBox39.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox39.Image")));
            this.pictureBox39.Location = new System.Drawing.Point(968, 53);
            this.pictureBox39.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox39.Name = "pictureBox39";
            this.pictureBox39.Size = new System.Drawing.Size(45, 34);
            this.pictureBox39.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox39.TabIndex = 32;
            this.pictureBox39.TabStop = false;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label37.ForeColor = System.Drawing.Color.White;
            this.label37.Location = new System.Drawing.Point(888, 58);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(69, 28);
            this.label37.TabIndex = 31;
            this.label37.Text = "עובדים";
            // 
            // dgv_employees
            // 
            this.dgv_employees.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_employees.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_employees.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgv_employees.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_employees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_employees.ColumnHeadersHeight = 29;
            this.dgv_employees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_employees.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_employees.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_employees.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.dgv_employees.Location = new System.Drawing.Point(93, 106);
            this.dgv_employees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_employees.MultiSelect = false;
            this.dgv_employees.Name = "dgv_employees";
            this.dgv_employees.ReadOnly = true;
            this.dgv_employees.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_employees.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_employees.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_employees.RowHeadersWidth = 30;
            this.dgv_employees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_employees.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_employees.RowTemplate.Height = 24;
            this.dgv_employees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_employees.Size = new System.Drawing.Size(920, 507);
            this.dgv_employees.TabIndex = 30;
            this.dgv_employees.VirtualMode = true;
            // 
            // frmEmployees
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
            this.Controls.Add(this.pictureBox36);
            this.Controls.Add(this.pictureBox35);
            this.Controls.Add(this.btn_showEmployee);
            this.Controls.Add(this.btn_setEmployee);
            this.Controls.Add(this.btn_addEmployee);
            this.Controls.Add(this.pictureBox39);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.dgv_employees);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEmployees";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEmployees";
            ((System.ComponentModel.ISupportInitialize)(this.btn_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_employees)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox36;
        private System.Windows.Forms.PictureBox pictureBox35;
        private System.Windows.Forms.Button btn_showEmployee;
        private System.Windows.Forms.Button btn_setEmployee;
        private System.Windows.Forms.Button btn_addEmployee;
        private System.Windows.Forms.PictureBox pictureBox39;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.DataGridView dgv_employees;
    }
}