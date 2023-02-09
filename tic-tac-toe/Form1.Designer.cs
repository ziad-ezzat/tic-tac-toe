namespace tic_tac_toe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.gb_playreOne = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_playerone = new System.Windows.Forms.TextBox();
            this.rb_X_playerone = new System.Windows.Forms.RadioButton();
            this.rb_O_playerone = new System.Windows.Forms.RadioButton();
            this.btn_start = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_playertwo = new System.Windows.Forms.TextBox();
            this.rb_X_playertwo = new System.Windows.Forms.RadioButton();
            this.rb_O_playertwo = new System.Windows.Forms.RadioButton();
            this.gb_playreOne.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Tan;
            this.Title.Font = new System.Drawing.Font("Showcard Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(187, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(411, 46);
            this.Title.TabIndex = 0;
            this.Title.Text = "Hello in my XO Game";
            this.Title.Click += new System.EventHandler(this.label1_Click);
            // 
            // gb_playreOne
            // 
            this.gb_playreOne.BackColor = System.Drawing.Color.BurlyWood;
            this.gb_playreOne.Controls.Add(this.label3);
            this.gb_playreOne.Controls.Add(this.tb_playerone);
            this.gb_playreOne.Controls.Add(this.rb_X_playerone);
            this.gb_playreOne.Controls.Add(this.rb_O_playerone);
            this.gb_playreOne.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gb_playreOne.Location = new System.Drawing.Point(45, 107);
            this.gb_playreOne.Name = "gb_playreOne";
            this.gb_playreOne.Size = new System.Drawing.Size(240, 184);
            this.gb_playreOne.TabIndex = 1;
            this.gb_playreOne.TabStop = false;
            this.gb_playreOne.Text = "Player One";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Enter your name";
            // 
            // tb_playerone
            // 
            this.tb_playerone.Location = new System.Drawing.Point(52, 68);
            this.tb_playerone.Name = "tb_playerone";
            this.tb_playerone.Size = new System.Drawing.Size(132, 24);
            this.tb_playerone.TabIndex = 2;
            // 
            // rb_X_playerone
            // 
            this.rb_X_playerone.AutoSize = true;
            this.rb_X_playerone.Location = new System.Drawing.Point(52, 117);
            this.rb_X_playerone.Name = "rb_X_playerone";
            this.rb_X_playerone.Size = new System.Drawing.Size(36, 21);
            this.rb_X_playerone.TabIndex = 3;
            this.rb_X_playerone.TabStop = true;
            this.rb_X_playerone.Text = "X";
            this.rb_X_playerone.UseVisualStyleBackColor = true;
            this.rb_X_playerone.Click += new System.EventHandler(this.rb_X_playerone_CheckedChanged);
            // 
            // rb_O_playerone
            // 
            this.rb_O_playerone.AutoSize = true;
            this.rb_O_playerone.Location = new System.Drawing.Point(157, 117);
            this.rb_O_playerone.Name = "rb_O_playerone";
            this.rb_O_playerone.Size = new System.Drawing.Size(36, 21);
            this.rb_O_playerone.TabIndex = 2;
            this.rb_O_playerone.TabStop = true;
            this.rb_O_playerone.Text = "O";
            this.rb_O_playerone.UseVisualStyleBackColor = true;
            this.rb_O_playerone.Click += new System.EventHandler(this.rb_O_playerone_CheckedChanged);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_start.Font = new System.Drawing.Font("Showcard Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_start.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_start.Location = new System.Drawing.Point(303, 372);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(202, 66);
            this.btn_start.TabIndex = 2;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.BurlyWood;
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tb_playertwo);
            this.groupBox3.Controls.Add(this.rb_X_playertwo);
            this.groupBox3.Controls.Add(this.rb_O_playertwo);
            this.groupBox3.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(511, 107);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 184);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Player Two";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Enter your name";
            // 
            // tb_playertwo
            // 
            this.tb_playertwo.Location = new System.Drawing.Point(52, 68);
            this.tb_playertwo.Name = "tb_playertwo";
            this.tb_playertwo.Size = new System.Drawing.Size(132, 24);
            this.tb_playertwo.TabIndex = 2;
            // 
            // rb_X_playertwo
            // 
            this.rb_X_playertwo.AutoSize = true;
            this.rb_X_playertwo.Location = new System.Drawing.Point(52, 117);
            this.rb_X_playertwo.Name = "rb_X_playertwo";
            this.rb_X_playertwo.Size = new System.Drawing.Size(36, 21);
            this.rb_X_playertwo.TabIndex = 3;
            this.rb_X_playertwo.TabStop = true;
            this.rb_X_playertwo.Text = "X";
            this.rb_X_playertwo.UseVisualStyleBackColor = true;
            this.rb_X_playertwo.Click += new System.EventHandler(this.rb_X_playertwo_CheckedChanged);
            // 
            // rb_O_playertwo
            // 
            this.rb_O_playertwo.AutoSize = true;
            this.rb_O_playertwo.Location = new System.Drawing.Point(157, 117);
            this.rb_O_playertwo.Name = "rb_O_playertwo";
            this.rb_O_playertwo.Size = new System.Drawing.Size(36, 21);
            this.rb_O_playertwo.TabIndex = 2;
            this.rb_O_playertwo.TabStop = true;
            this.rb_O_playertwo.Text = "O";
            this.rb_O_playertwo.UseVisualStyleBackColor = true;
            this.rb_O_playertwo.Click += new System.EventHandler(this.rb_O_playertwo_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.gb_playreOne);
            this.Controls.Add(this.Title);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_playreOne.ResumeLayout(false);
            this.gb_playreOne.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title;
        private GroupBox gb_playreOne;
        private Label label3;
        private TextBox tb_playerone;
        private RadioButton rb_X_playerone;
        private RadioButton rb_O_playerone;
        private Button btn_start;
        private GroupBox groupBox3;
        private Label label4;
        private TextBox tb_playertwo;
        private RadioButton rb_X_playertwo;
        private RadioButton rb_O_playertwo;
    }
}