namespace Ergasia3.src.ConcertBooking
{
	partial class SignUp
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && (components != null) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			panel1 = new Panel();
			signUpButton = new Button();
			passwordTextBox = new TextBox();
			label2 = new Label();
			label1 = new Label();
			emailTextBox = new TextBox();
			label3 = new Label();
			usernameTextbox = new TextBox();
			label6 = new Label();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.MediumSlateBlue;
			panel1.Controls.Add(signUpButton);
			panel1.Controls.Add(passwordTextBox);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(emailTextBox);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(usernameTextbox);
			panel1.Controls.Add(label6);
			panel1.Location = new Point(2, 2);
			panel1.Margin = new Padding(3, 2, 3, 2);
			panel1.Name = "panel1";
			panel1.Size = new Size(423, 488);
			panel1.TabIndex = 0;
			// 
			// signUpButton
			// 
			signUpButton.BackColor = Color.DarkSlateBlue;
			signUpButton.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			signUpButton.ForeColor = Color.Snow;
			signUpButton.Location = new Point(56, 390);
			signUpButton.Margin = new Padding(3, 2, 3, 2);
			signUpButton.Name = "signUpButton";
			signUpButton.Size = new Size(298, 50);
			signUpButton.TabIndex = 25;
			signUpButton.Text = "Sign up";
			signUpButton.UseVisualStyleBackColor = false;
			signUpButton.Click += signUpButton_Click;
			// 
			// passwordTextBox
			// 
			passwordTextBox.BackColor = Color.Snow;
			passwordTextBox.Font = new Font("Nirmala UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			passwordTextBox.ForeColor = Color.SlateGray;
			passwordTextBox.Location = new Point(56, 308);
			passwordTextBox.Margin = new Padding(3, 2, 3, 2);
			passwordTextBox.MaxLength = 32;
			passwordTextBox.Name = "passwordTextBox";
			passwordTextBox.PasswordChar = '*';
			passwordTextBox.Size = new Size(298, 36);
			passwordTextBox.TabIndex = 24;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.FlatStyle = FlatStyle.Flat;
			label2.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.DarkSlateBlue;
			label2.Location = new Point(56, 279);
			label2.Name = "label2";
			label2.Size = new Size(104, 22);
			label2.TabIndex = 23;
			label2.Text = "Password";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.FlatStyle = FlatStyle.Flat;
			label1.Font = new Font("Lucida Bright", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.DarkSlateBlue;
			label1.Location = new Point(145, 19);
			label1.Name = "label1";
			label1.Size = new Size(127, 34);
			label1.TabIndex = 22;
			label1.Text = "Sign up";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// emailTextBox
			// 
			emailTextBox.BackColor = Color.Snow;
			emailTextBox.Font = new Font("Nirmala UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			emailTextBox.ForeColor = Color.SlateGray;
			emailTextBox.Location = new Point(56, 216);
			emailTextBox.Margin = new Padding(3, 2, 3, 2);
			emailTextBox.MaxLength = 64;
			emailTextBox.Name = "emailTextBox";
			emailTextBox.PlaceholderText = "example@domain.com";
			emailTextBox.Size = new Size(298, 36);
			emailTextBox.TabIndex = 18;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.FlatStyle = FlatStyle.Flat;
			label3.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.DarkSlateBlue;
			label3.Location = new Point(56, 187);
			label3.Name = "label3";
			label3.Size = new Size(61, 22);
			label3.TabIndex = 17;
			label3.Text = "Email";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// usernameTextbox
			// 
			usernameTextbox.BackColor = Color.Snow;
			usernameTextbox.Font = new Font("Nirmala UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			usernameTextbox.ForeColor = Color.SlateGray;
			usernameTextbox.Location = new Point(56, 125);
			usernameTextbox.Margin = new Padding(3, 2, 3, 2);
			usernameTextbox.MaxLength = 32;
			usernameTextbox.Name = "usernameTextbox";
			usernameTextbox.PlaceholderText = "Username";
			usernameTextbox.Size = new Size(298, 36);
			usernameTextbox.TabIndex = 16;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.FlatStyle = FlatStyle.Flat;
			label6.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label6.ForeColor = Color.DarkSlateBlue;
			label6.Location = new Point(56, 96);
			label6.Name = "label6";
			label6.Size = new Size(105, 22);
			label6.TabIndex = 15;
			label6.Text = "Username";
			label6.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// SignUp
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.SlateBlue;
			ClientSize = new Size(427, 491);
			Controls.Add(panel1);
			ForeColor = SystemColors.ControlText;
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Margin = new Padding(3, 2, 3, 2);
			Name = "SignUp";
			StartPosition = FormStartPosition.CenterScreen;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Label label6;
		private TextBox usernameTextbox;
		private TextBox emailTextBox;
		private Label label3;
		private Label label1;
		private TextBox passwordTextBox;
		private Label label2;
		private Button signUpButton;
	}
}