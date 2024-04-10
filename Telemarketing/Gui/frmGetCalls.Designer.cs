namespace Telemarketing.Gui
{
    partial class frmGetCalls
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGetCalls));
            this.pnl_getCall = new System.Windows.Forms.Panel();
            this.pnl_timeToBack = new System.Windows.Forms.Panel();
            this.lbl_timeToBack = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtb_timeToBack = new System.Windows.Forms.MaskedTextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.pnl_options = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.btn_callBack = new System.Windows.Forms.Button();
            this.btn_noAnswer = new System.Windows.Forms.Button();
            this.btn_Refused = new System.Windows.Forms.Button();
            this.btn_newDonation = new System.Windows.Forms.Button();
            this.rtb_note = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.lbl_address = new System.Windows.Forms.Label();
            this.lbl_donor = new System.Windows.Forms.Label();
            this.pnl_getCall.SuspendLayout();
            this.pnl_timeToBack.SuspendLayout();
            this.pnl_options.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_getCall
            // 
            this.pnl_getCall.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_getCall.Controls.Add(this.pnl_timeToBack);
            this.pnl_getCall.Controls.Add(this.pnl_options);
            this.pnl_getCall.Controls.Add(this.rtb_note);
            this.pnl_getCall.Controls.Add(this.label1);
            this.pnl_getCall.Controls.Add(this.label6);
            this.pnl_getCall.Controls.Add(this.pictureBox4);
            this.pnl_getCall.Controls.Add(this.label2);
            this.pnl_getCall.Controls.Add(this.lbl_status);
            this.pnl_getCall.Controls.Add(this.lbl_phone);
            this.pnl_getCall.Controls.Add(this.lbl_address);
            this.pnl_getCall.Controls.Add(this.lbl_donor);
            this.pnl_getCall.Location = new System.Drawing.Point(288, 68);
            this.pnl_getCall.Name = "pnl_getCall";
            this.pnl_getCall.Size = new System.Drawing.Size(733, 464);
            this.pnl_getCall.TabIndex = 1;
            // 
            // pnl_timeToBack
            // 
            this.pnl_timeToBack.Controls.Add(this.lbl_timeToBack);
            this.pnl_timeToBack.Controls.Add(this.label3);
            this.pnl_timeToBack.Controls.Add(this.mtb_timeToBack);
            this.pnl_timeToBack.Controls.Add(this.btn_cancel);
            this.pnl_timeToBack.Controls.Add(this.btn_save);
            this.pnl_timeToBack.Location = new System.Drawing.Point(394, 312);
            this.pnl_timeToBack.Name = "pnl_timeToBack";
            this.pnl_timeToBack.Size = new System.Drawing.Size(329, 134);
            this.pnl_timeToBack.TabIndex = 32;
            this.pnl_timeToBack.Visible = false;
            this.pnl_timeToBack.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_timeToBack_Paint);
            // 
            // lbl_timeToBack
            // 
            this.lbl_timeToBack.AutoSize = true;
            this.lbl_timeToBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_timeToBack.Location = new System.Drawing.Point(33, 54);
            this.lbl_timeToBack.Name = "lbl_timeToBack";
            this.lbl_timeToBack.Size = new System.Drawing.Size(64, 16);
            this.lbl_timeToBack.TabIndex = 11;
            this.lbl_timeToBack.Text = "שדה חובה";
            this.lbl_timeToBack.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(240, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "זמן חזרה:";
            // 
            // mtb_timeToBack
            // 
            this.mtb_timeToBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.mtb_timeToBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.mtb_timeToBack.ForeColor = System.Drawing.Color.White;
            this.mtb_timeToBack.Location = new System.Drawing.Point(34, 15);
            this.mtb_timeToBack.Mask = "00/00/0000 90:00";
            this.mtb_timeToBack.Name = "mtb_timeToBack";
            this.mtb_timeToBack.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.mtb_timeToBack.Size = new System.Drawing.Size(200, 34);
            this.mtb_timeToBack.TabIndex = 31;
            this.mtb_timeToBack.ValidatingType = typeof(System.DateTime);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(35)))), ((int)(((byte)(224)))));
            this.btn_cancel.FlatAppearance.BorderSize = 2;
            this.btn_cancel.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(35)))), ((int)(((byte)(224)))));
            this.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(35)))), ((int)(((byte)(224)))));
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancel.Location = new System.Drawing.Point(124, 80);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.btn_cancel.Size = new System.Drawing.Size(86, 33);
            this.btn_cancel.TabIndex = 26;
            this.btn_cancel.Text = "ביטול";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.Transparent;
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.btn_save.FlatAppearance.BorderSize = 2;
            this.btn_save.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_save.Location = new System.Drawing.Point(28, 80);
            this.btn_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_save.Name = "btn_save";
            this.btn_save.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.btn_save.Size = new System.Drawing.Size(86, 33);
            this.btn_save.TabIndex = 26;
            this.btn_save.Text = "אישור";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pnl_options
            // 
            this.pnl_options.Controls.Add(this.pictureBox3);
            this.pnl_options.Controls.Add(this.pictureBox2);
            this.pnl_options.Controls.Add(this.pictureBox1);
            this.pnl_options.Controls.Add(this.pictureBox35);
            this.pnl_options.Controls.Add(this.btn_callBack);
            this.pnl_options.Controls.Add(this.btn_noAnswer);
            this.pnl_options.Controls.Add(this.btn_Refused);
            this.pnl_options.Controls.Add(this.btn_newDonation);
            this.pnl_options.Location = new System.Drawing.Point(26, 309);
            this.pnl_options.Name = "pnl_options";
            this.pnl_options.Size = new System.Drawing.Size(702, 78);
            this.pnl_options.TabIndex = 33;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(558, 26);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 27;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(402, 26);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(244, 26);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox35
            // 
            this.pictureBox35.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox35.Image")));
            this.pictureBox35.Location = new System.Drawing.Point(42, 26);
            this.pictureBox35.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(32, 30);
            this.pictureBox35.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox35.TabIndex = 27;
            this.pictureBox35.TabStop = false;
            // 
            // btn_callBack
            // 
            this.btn_callBack.BackColor = System.Drawing.Color.Transparent;
            this.btn_callBack.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.btn_callBack.FlatAppearance.BorderSize = 2;
            this.btn_callBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_callBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_callBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_callBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_callBack.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_callBack.ForeColor = System.Drawing.Color.White;
            this.btn_callBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_callBack.Location = new System.Drawing.Point(541, 18);
            this.btn_callBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_callBack.Name = "btn_callBack";
            this.btn_callBack.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.btn_callBack.Size = new System.Drawing.Size(133, 43);
            this.btn_callBack.TabIndex = 26;
            this.btn_callBack.Text = "השהיה";
            this.btn_callBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_callBack.UseVisualStyleBackColor = false;
            this.btn_callBack.Click += new System.EventHandler(this.btn_callBack_Click);
            // 
            // btn_noAnswer
            // 
            this.btn_noAnswer.BackColor = System.Drawing.Color.Transparent;
            this.btn_noAnswer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.btn_noAnswer.FlatAppearance.BorderSize = 2;
            this.btn_noAnswer.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_noAnswer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_noAnswer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_noAnswer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_noAnswer.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_noAnswer.ForeColor = System.Drawing.Color.White;
            this.btn_noAnswer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_noAnswer.Location = new System.Drawing.Point(385, 18);
            this.btn_noAnswer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_noAnswer.Name = "btn_noAnswer";
            this.btn_noAnswer.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.btn_noAnswer.Size = new System.Drawing.Size(133, 43);
            this.btn_noAnswer.TabIndex = 26;
            this.btn_noAnswer.Text = "לא ענה";
            this.btn_noAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_noAnswer.UseVisualStyleBackColor = false;
            this.btn_noAnswer.Click += new System.EventHandler(this.btn_noAnswer_Click);
            // 
            // btn_Refused
            // 
            this.btn_Refused.BackColor = System.Drawing.Color.Transparent;
            this.btn_Refused.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.btn_Refused.FlatAppearance.BorderSize = 2;
            this.btn_Refused.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_Refused.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_Refused.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_Refused.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refused.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_Refused.ForeColor = System.Drawing.Color.White;
            this.btn_Refused.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Refused.Location = new System.Drawing.Point(229, 18);
            this.btn_Refused.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Refused.Name = "btn_Refused";
            this.btn_Refused.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.btn_Refused.Size = new System.Drawing.Size(133, 43);
            this.btn_Refused.TabIndex = 26;
            this.btn_Refused.Text = "סירב";
            this.btn_Refused.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Refused.UseVisualStyleBackColor = false;
            this.btn_Refused.Click += new System.EventHandler(this.btn_Refused_Click);
            // 
            // btn_newDonation
            // 
            this.btn_newDonation.BackColor = System.Drawing.Color.Transparent;
            this.btn_newDonation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(63)))), ((int)(((byte)(255)))));
            this.btn_newDonation.FlatAppearance.BorderSize = 2;
            this.btn_newDonation.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_newDonation.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_newDonation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.btn_newDonation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newDonation.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_newDonation.ForeColor = System.Drawing.Color.White;
            this.btn_newDonation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_newDonation.Location = new System.Drawing.Point(25, 18);
            this.btn_newDonation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_newDonation.Name = "btn_newDonation";
            this.btn_newDonation.Padding = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.btn_newDonation.Size = new System.Drawing.Size(181, 43);
            this.btn_newDonation.TabIndex = 26;
            this.btn_newDonation.Text = "פתיחת תרומה";
            this.btn_newDonation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_newDonation.UseVisualStyleBackColor = false;
            this.btn_newDonation.Click += new System.EventHandler(this.btn_newDonation_Click);
            // 
            // rtb_note
            // 
            this.rtb_note.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.rtb_note.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_note.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.rtb_note.ForeColor = System.Drawing.Color.White;
            this.rtb_note.Location = new System.Drawing.Point(51, 242);
            this.rtb_note.Name = "rtb_note";
            this.rtb_note.Size = new System.Drawing.Size(649, 52);
            this.rtb_note.TabIndex = 32;
            this.rtb_note.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(590, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "הוספת הערה";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(337, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 35);
            this.label6.TabIndex = 28;
            this.label6.Text = "חיוג לתורם";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(279, 34);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(65, 59);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 30;
            this.pictureBox4.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(419, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 28);
            this.label2.TabIndex = 29;
            this.label2.Text = "תורם:";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_status.ForeColor = System.Drawing.Color.White;
            this.lbl_status.Location = new System.Drawing.Point(192, 166);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(53, 28);
            this.lbl_status.TabIndex = 28;
            this.lbl_status.Text = "פעיל";
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_phone.ForeColor = System.Drawing.Color.White;
            this.lbl_phone.Location = new System.Drawing.Point(301, 166);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(122, 28);
            this.lbl_phone.TabIndex = 28;
            this.lbl_phone.Text = "0556790601";
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_address.ForeColor = System.Drawing.Color.White;
            this.lbl_address.Location = new System.Drawing.Point(466, 166);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(130, 28);
            this.lbl_address.TabIndex = 28;
            this.lbl_address.Text = "רש\"י 26 אלעד";
            // 
            // lbl_donor
            // 
            this.lbl_donor.AutoSize = true;
            this.lbl_donor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lbl_donor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(35)))), ((int)(((byte)(224)))));
            this.lbl_donor.Location = new System.Drawing.Point(281, 106);
            this.lbl_donor.Name = "lbl_donor";
            this.lbl_donor.Size = new System.Drawing.Size(132, 28);
            this.lbl_donor.TabIndex = 28;
            this.lbl_donor.Text = "תהילה הויזמן";
            // 
            // frmGetCalls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(1300, 635);
            this.Controls.Add(this.pnl_getCall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGetCalls";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGetCalls";
            this.Load += new System.EventHandler(this.frmGetCalls_Load);
            this.pnl_getCall.ResumeLayout(false);
            this.pnl_getCall.PerformLayout();
            this.pnl_timeToBack.ResumeLayout(false);
            this.pnl_timeToBack.PerformLayout();
            this.pnl_options.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_getCall;
        private System.Windows.Forms.Panel pnl_timeToBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtb_timeToBack;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Panel pnl_options;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox35;
        private System.Windows.Forms.Button btn_callBack;
        private System.Windows.Forms.Button btn_noAnswer;
        private System.Windows.Forms.Button btn_Refused;
        private System.Windows.Forms.Button btn_newDonation;
        private System.Windows.Forms.RichTextBox rtb_note;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label lbl_donor;
        private System.Windows.Forms.Label lbl_timeToBack;
    }
}