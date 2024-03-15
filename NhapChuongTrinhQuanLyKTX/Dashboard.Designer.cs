namespace NhapChuongTrinhQuanLyKTX
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.btnStudentLiving = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnLeavedStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnStudentFee = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdateDeleteStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnNewStudent = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageRooms = new Guna.UI2.WinForms.Guna2Button();
            this.btnManager = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnNewEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.btnManager)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(692, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(620, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chương trình quản lý KTX sinh viên";
            // 
            // btnExit
            // 
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Image = global::NhapChuongTrinhQuanLyKTX.Properties.Resources.Close;
            this.btnExit.ImageSize = new System.Drawing.Size(35, 35);
            this.btnExit.Location = new System.Drawing.Point(1780, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressedColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Size = new System.Drawing.Size(75, 56);
            this.btnExit.TabIndex = 15;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnStudentLiving
            // 
            this.btnStudentLiving.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStudentLiving.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnStudentLiving.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStudentLiving.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStudentLiving.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStudentLiving.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStudentLiving.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnStudentLiving.ForeColor = System.Drawing.Color.White;
            this.btnStudentLiving.Image = global::NhapChuongTrinhQuanLyKTX.Properties.Resources.List_of_Paid___Dues_Students1;
            this.btnStudentLiving.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStudentLiving.ImageSize = new System.Drawing.Size(30, 30);
            this.btnStudentLiving.Location = new System.Drawing.Point(14, 494);
            this.btnStudentLiving.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStudentLiving.Name = "btnStudentLiving";
            this.btnStudentLiving.Size = new System.Drawing.Size(367, 79);
            this.btnStudentLiving.TabIndex = 14;
            this.btnStudentLiving.Text = "Trạng Thái Phòng Sinh Viên";
            this.btnStudentLiving.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStudentLiving.Click += new System.EventHandler(this.btnStudentLiving_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Black;
            this.btnLogOut.Image = global::NhapChuongTrinhQuanLyKTX.Properties.Resources.logout;
            this.btnLogOut.Location = new System.Drawing.Point(1322, 16);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.PressedColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogOut.Size = new System.Drawing.Size(202, 56);
            this.btnLogOut.TabIndex = 13;
            this.btnLogOut.Text = "Đăng Xuất";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnLeavedStudent
            // 
            this.btnLeavedStudent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLeavedStudent.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnLeavedStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLeavedStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLeavedStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLeavedStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLeavedStudent.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnLeavedStudent.ForeColor = System.Drawing.Color.White;
            this.btnLeavedStudent.Image = global::NhapChuongTrinhQuanLyKTX.Properties.Resources.Leaved_students;
            this.btnLeavedStudent.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLeavedStudent.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLeavedStudent.Location = new System.Drawing.Point(14, 580);
            this.btnLeavedStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLeavedStudent.Name = "btnLeavedStudent";
            this.btnLeavedStudent.Size = new System.Drawing.Size(367, 79);
            this.btnLeavedStudent.TabIndex = 7;
            this.btnLeavedStudent.Text = "Sinh Viên Trả Phòng";
            this.btnLeavedStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLeavedStudent.Click += new System.EventHandler(this.btnLeavedStudent_Click);
            // 
            // btnStudentFee
            // 
            this.btnStudentFee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnStudentFee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnStudentFee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStudentFee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStudentFee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStudentFee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStudentFee.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnStudentFee.ForeColor = System.Drawing.Color.White;
            this.btnStudentFee.Image = global::NhapChuongTrinhQuanLyKTX.Properties.Resources.Fees;
            this.btnStudentFee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStudentFee.ImageSize = new System.Drawing.Size(30, 30);
            this.btnStudentFee.Location = new System.Drawing.Point(14, 408);
            this.btnStudentFee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStudentFee.Name = "btnStudentFee";
            this.btnStudentFee.Size = new System.Drawing.Size(367, 79);
            this.btnStudentFee.TabIndex = 6;
            this.btnStudentFee.Text = "Thanh Toán Phí Phòng";
            this.btnStudentFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnStudentFee.Click += new System.EventHandler(this.btnStudentFee_Click);
            // 
            // btnUpdateDeleteStudent
            // 
            this.btnUpdateDeleteStudent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnUpdateDeleteStudent.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUpdateDeleteStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateDeleteStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateDeleteStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateDeleteStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateDeleteStudent.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnUpdateDeleteStudent.ForeColor = System.Drawing.Color.White;
            this.btnUpdateDeleteStudent.Image = global::NhapChuongTrinhQuanLyKTX.Properties.Resources.Update___Delete_Student;
            this.btnUpdateDeleteStudent.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateDeleteStudent.ImageSize = new System.Drawing.Size(30, 30);
            this.btnUpdateDeleteStudent.Location = new System.Drawing.Point(14, 321);
            this.btnUpdateDeleteStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdateDeleteStudent.Name = "btnUpdateDeleteStudent";
            this.btnUpdateDeleteStudent.Size = new System.Drawing.Size(367, 79);
            this.btnUpdateDeleteStudent.TabIndex = 5;
            this.btnUpdateDeleteStudent.Text = "Cập nhật - Xóa Sinh Viên";
            this.btnUpdateDeleteStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateDeleteStudent.Click += new System.EventHandler(this.btnUpdateDeleteStudent_Click);
            // 
            // btnNewStudent
            // 
            this.btnNewStudent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNewStudent.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNewStudent.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNewStudent.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNewStudent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewStudent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNewStudent.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnNewStudent.ForeColor = System.Drawing.Color.White;
            this.btnNewStudent.Image = global::NhapChuongTrinhQuanLyKTX.Properties.Resources.new_student;
            this.btnNewStudent.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNewStudent.ImageSize = new System.Drawing.Size(30, 30);
            this.btnNewStudent.Location = new System.Drawing.Point(14, 235);
            this.btnNewStudent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.Size = new System.Drawing.Size(367, 79);
            this.btnNewStudent.TabIndex = 4;
            this.btnNewStudent.Text = "Thêm Sinh Viên";
            this.btnNewStudent.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNewStudent.Click += new System.EventHandler(this.btnNewStudent_Click);
            // 
            // btnManageRooms
            // 
            this.btnManageRooms.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnManageRooms.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnManageRooms.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnManageRooms.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageRooms.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageRooms.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageRooms.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageRooms.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnManageRooms.ForeColor = System.Drawing.Color.White;
            this.btnManageRooms.Image = global::NhapChuongTrinhQuanLyKTX.Properties.Resources.room;
            this.btnManageRooms.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageRooms.ImageSize = new System.Drawing.Size(30, 30);
            this.btnManageRooms.Location = new System.Drawing.Point(14, 149);
            this.btnManageRooms.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnManageRooms.Name = "btnManageRooms";
            this.btnManageRooms.Size = new System.Drawing.Size(367, 79);
            this.btnManageRooms.TabIndex = 3;
            this.btnManageRooms.Text = "Quản Lý Phòng";
            this.btnManageRooms.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnManageRooms.Click += new System.EventHandler(this.btnManageRooms_Click);
            // 
            // btnManager
            // 
            this.btnManager.Image = ((System.Drawing.Image)(resources.GetObject("btnManager.Image")));
            this.btnManager.ImageRotate = 0F;
            this.btnManager.Location = new System.Drawing.Point(387, 149);
            this.btnManager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(1350, 1050);
            this.btnManager.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnManager.TabIndex = 2;
            this.btnManager.TabStop = false;
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNewEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnNewEmployee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNewEmployee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNewEmployee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewEmployee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNewEmployee.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnNewEmployee.ForeColor = System.Drawing.Color.White;
            this.btnNewEmployee.Image = global::NhapChuongTrinhQuanLyKTX.Properties.Resources.new_student;
            this.btnNewEmployee.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNewEmployee.ImageSize = new System.Drawing.Size(30, 30);
            this.btnNewEmployee.Location = new System.Drawing.Point(14, 667);
            this.btnNewEmployee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(367, 79);
            this.btnNewEmployee.TabIndex = 16;
            this.btnNewEmployee.Text = "Thêm Nhân Viên";
            this.btnNewEmployee.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnNewEmployee.Click += new System.EventHandler(this.NewEmployee_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::NhapChuongTrinhQuanLyKTX.Properties.Resources.Update___Delete_Student;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button1.Location = new System.Drawing.Point(14, 754);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(367, 79);
            this.guna2Button1.TabIndex = 17;
            this.guna2Button1.Text = "Cập nhật - Xóa Nhân Viên";
            this.guna2Button1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Button2.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::NhapChuongTrinhQuanLyKTX.Properties.Resources.List_of_Paid___Dues_Students1;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button2.Location = new System.Drawing.Point(22, 841);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(343, 79);
            this.guna2Button2.TabIndex = 18;
            this.guna2Button2.Text = "Danh Sách Nhân Viên";
            this.guna2Button2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2Button3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Image = global::NhapChuongTrinhQuanLyKTX.Properties.Resources.List_of_Paid___Dues_Students1;
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button3.Location = new System.Drawing.Point(22, 928);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(343, 79);
            this.guna2Button3.TabIndex = 19;
            this.guna2Button3.Text = "Nhân Viên Đã Nghỉ Việc";
            this.guna2Button3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1863, 1200);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnNewEmployee);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStudentLiving);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnLeavedStudent);
            this.Controls.Add(this.btnStudentFee);
            this.Controls.Add(this.btnUpdateDeleteStudent);
            this.Controls.Add(this.btnNewStudent);
            this.Controls.Add(this.btnManageRooms);
            this.Controls.Add(this.btnManager);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            ((System.ComponentModel.ISupportInitialize)(this.btnManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2PictureBox btnManager;
        private Guna.UI2.WinForms.Guna2Button btnManageRooms;
        private Guna.UI2.WinForms.Guna2Button btnNewStudent;
        private Guna.UI2.WinForms.Guna2Button btnStudentFee;
        private Guna.UI2.WinForms.Guna2Button btnLeavedStudent;
        private Guna.UI2.WinForms.Guna2Button btnUpdateDeleteStudent;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private Guna.UI2.WinForms.Guna2Button btnStudentLiving;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button btnNewEmployee;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
    }
}