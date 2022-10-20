namespace Attendance_Maker
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_next = new System.Windows.Forms.Button();
            this.btn_form_close = new FontAwesome.Sharp.IconButton();
            this.btn_form_mini = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 51);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(651, 322);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btn_form_close);
            this.panel1.Controls.Add(this.btn_form_mini);
            this.panel1.Location = new System.Drawing.Point(25, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(661, 45);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(245, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 56);
            this.label1.TabIndex = 16;
            this.label1.Text = "Welcome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(188, 401);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(336, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "Attendance Marking System";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(79, 582);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(551, 26);
            this.label3.TabIndex = 18;
            this.label3.Text = "Please Press ADD Button and Scan Your Institute ID Card";
            // 
            // Btn_next
            // 
            this.Btn_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(0)))));
            this.Btn_next.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_next.FlatAppearance.BorderSize = 0;
            this.Btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_next.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_next.Location = new System.Drawing.Point(277, 480);
            this.Btn_next.Name = "Btn_next";
            this.Btn_next.Size = new System.Drawing.Size(143, 48);
            this.Btn_next.TabIndex = 19;
            this.Btn_next.Text = "ADD";
            this.Btn_next.UseVisualStyleBackColor = false;
            this.Btn_next.Click += new System.EventHandler(this.Btn_next_Click);
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
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(717, 663);
            this.Controls.Add(this.Btn_next);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_next;
        private FontAwesome.Sharp.IconButton btn_form_close;
        private FontAwesome.Sharp.IconButton btn_form_mini;
    }
}

