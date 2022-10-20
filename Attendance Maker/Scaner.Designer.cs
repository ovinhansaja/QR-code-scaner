namespace Attendance_Maker
{
    partial class Scaner
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_form_close = new FontAwesome.Sharp.IconButton();
            this.btn_form_mini = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_index = new System.Windows.Forms.TextBox();
            this.QRscaner = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_device = new System.Windows.Forms.ComboBox();
            this.rb_teacher = new System.Windows.Forms.RadioButton();
            this.rb_staff = new System.Windows.Forms.RadioButton();
            this.rb_student = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QRscaner)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btn_form_close);
            this.panel1.Controls.Add(this.btn_form_mini);
            this.panel1.Location = new System.Drawing.Point(26, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 45);
            this.panel1.TabIndex = 16;
            // 
            // btn_form_close
            // 
            this.btn_form_close.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_form_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btn_form_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_form_close.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_form_close.FlatAppearance.BorderSize = 0;
            this.btn_form_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_form_close.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btn_form_close.IconColor = System.Drawing.Color.Black;
            this.btn_form_close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_form_close.IconSize = 30;
            this.btn_form_close.Location = new System.Drawing.Point(610, 2);
            this.btn_form_close.Name = "btn_form_close";
            this.btn_form_close.Size = new System.Drawing.Size(48, 41);
            this.btn_form_close.TabIndex = 7;
            this.btn_form_close.UseVisualStyleBackColor = false;
            this.btn_form_close.Click += new System.EventHandler(this.btn_form_close_Click);
            // 
            // btn_form_mini
            // 
            this.btn_form_mini.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_form_mini.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.btn_form_mini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_form_mini.FlatAppearance.BorderSize = 0;
            this.btn_form_mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_form_mini.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btn_form_mini.IconColor = System.Drawing.Color.Black;
            this.btn_form_mini.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_form_mini.IconSize = 30;
            this.btn_form_mini.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_form_mini.Location = new System.Drawing.Point(559, 4);
            this.btn_form_mini.Name = "btn_form_mini";
            this.btn_form_mini.Size = new System.Drawing.Size(48, 36);
            this.btn_form_mini.TabIndex = 8;
            this.btn_form_mini.UseVisualStyleBackColor = false;
            this.btn_form_mini.Click += new System.EventHandler(this.btn_form_mini_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txt_index);
            this.panel2.Controls.Add(this.QRscaner);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmb_device);
            this.panel2.Controls.Add(this.rb_teacher);
            this.panel2.Controls.Add(this.rb_staff);
            this.panel2.Controls.Add(this.rb_student);
            this.panel2.Location = new System.Drawing.Point(26, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(657, 569);
            this.panel2.TabIndex = 17;
            // 
            // txt_index
            // 
            this.txt_index.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_index.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_index.Location = new System.Drawing.Point(90, 518);
            this.txt_index.Name = "txt_index";
            this.txt_index.Size = new System.Drawing.Size(475, 26);
            this.txt_index.TabIndex = 6;
            // 
            // QRscaner
            // 
            this.QRscaner.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.QRscaner.Location = new System.Drawing.Point(90, 96);
            this.QRscaner.Name = "QRscaner";
            this.QRscaner.Size = new System.Drawing.Size(475, 416);
            this.QRscaner.TabIndex = 5;
            this.QRscaner.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Device";
            // 
            // cmb_device
            // 
            this.cmb_device.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_device.FormattingEnabled = true;
            this.cmb_device.Location = new System.Drawing.Point(165, 60);
            this.cmb_device.Name = "cmb_device";
            this.cmb_device.Size = new System.Drawing.Size(400, 30);
            this.cmb_device.TabIndex = 3;
            // 
            // rb_teacher
            // 
            this.rb_teacher.AutoSize = true;
            this.rb_teacher.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_teacher.Location = new System.Drawing.Point(281, 24);
            this.rb_teacher.Name = "rb_teacher";
            this.rb_teacher.Size = new System.Drawing.Size(108, 30);
            this.rb_teacher.TabIndex = 2;
            this.rb_teacher.TabStop = true;
            this.rb_teacher.Text = "Teacher";
            this.rb_teacher.UseVisualStyleBackColor = true;
            // 
            // rb_staff
            // 
            this.rb_staff.AutoSize = true;
            this.rb_staff.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_staff.Location = new System.Drawing.Point(429, 24);
            this.rb_staff.Name = "rb_staff";
            this.rb_staff.Size = new System.Drawing.Size(79, 30);
            this.rb_staff.TabIndex = 1;
            this.rb_staff.TabStop = true;
            this.rb_staff.Text = "Staff";
            this.rb_staff.UseVisualStyleBackColor = true;
            // 
            // rb_student
            // 
            this.rb_student.AutoSize = true;
            this.rb_student.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_student.Location = new System.Drawing.Point(138, 24);
            this.rb_student.Name = "rb_student";
            this.rb_student.Size = new System.Drawing.Size(107, 30);
            this.rb_student.TabIndex = 0;
            this.rb_student.TabStop = true;
            this.rb_student.Text = "Student";
            this.rb_student.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(211, 667);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 43);
            this.button1.TabIndex = 6;
            this.button1.Text = "Scan";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(374, 667);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 43);
            this.button2.TabIndex = 18;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Scaner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(717, 756);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Scaner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scaner";
            this.Load += new System.EventHandler(this.Scaner_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QRscaner)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btn_form_close;
        private FontAwesome.Sharp.IconButton btn_form_mini;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox QRscaner;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_device;
        private System.Windows.Forms.RadioButton rb_teacher;
        private System.Windows.Forms.RadioButton rb_staff;
        private System.Windows.Forms.RadioButton rb_student;
        private System.Windows.Forms.TextBox txt_index;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer;
    }
}