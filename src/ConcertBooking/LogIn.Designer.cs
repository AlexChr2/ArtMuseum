namespace Ergasia3.src.ConcertBooking
{
	partial class LogIn
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
			loginButton = new Button();
			passwordTextbox = new TextBox();
			label2 = new Label();
			label1 = new Label();
			usernameTextbox = new TextBox();
			label3 = new Label();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.MediumSlateBlue;
			panel1.Controls.Add(loginButton);
			panel1.Controls.Add(passwordTextbox);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(label1);
			panel1.Controls.Add(usernameTextbox);
			panel1.Controls.Add(label3);
			panel1.Location = new Point(3, 2);
			panel1.Margin = new Padding(3, 2, 3, 2);
			panel1.Name = "panel1";
			panel1.Size = new Size(423, 393);
			panel1.TabIndex = 1;
			// 
			// loginButton
			// 
			loginButton.BackColor = Color.DarkSlateBlue;
			loginButton.Font = new Font("Lucida Calligraphy", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			loginButton.ForeColor = Color.Snow;
			loginButton.Location = new Point(56, 292);
			loginButton.Margin = new Padding(3, 2, 3, 2);
			loginButton.Name = "loginButton";
			loginButton.Size = new Size(298, 50);
			loginButton.TabIndex = 25;
			loginButton.Text = "Log in";
			loginButton.UseVisualStyleBackColor = false;
			loginButton.Click += loginButton_Click;
			// 
			// passwordTextbox
			// 
			passwordTextbox.BackColor = Color.Snow;
			passwordTextbox.Font = new Font("Nirmala UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			passwordTextbox.ForeColor = Color.SlateGray;
			passwordTextbox.Location = new Point(56, 219);
			passwordTextbox.Margin = new Padding(3, 2, 3, 2);
			passwordTextbox.MaxLength = 32;
			passwordTextbox.Name = "passwordTextbox";
			passwordTextbox.PasswordChar = '*';
			passwordTextbox.Size = new Size(298, 36);
			passwordTextbox.TabIndex = 24;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.FlatStyle = FlatStyle.Flat;
			label2.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.DarkSlateBlue;
			label2.Location = new Point(56, 190);
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
			label1.Location = new Point(157, 21);
			label1.Name = "label1";
			label1.Size = new Size(108, 34);
			label1.TabIndex = 22;
			label1.Text = "Log in";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// usernameTextbox
			// 
			usernameTextbox.BackColor = Color.Snow;
			usernameTextbox.Font = new Font("Nirmala UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
			usernameTextbox.ForeColor = Color.SlateGray;
			usernameTextbox.Location = new Point(56, 127);
			usernameTextbox.Margin = new Padding(3, 2, 3, 2);
			usernameTextbox.MaxLength = 32;
			usernameTextbox.Name = "usernameTextbox";
			usernameTextbox.PlaceholderText = "Username";
			usernameTextbox.Size = new Size(298, 36);
			usernameTextbox.TabIndex = 18;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.FlatStyle = FlatStyle.Flat;
			label3.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.DarkSlateBlue;
			label3.Location = new Point(56, 98);
			label3.Name = "label3";
			label3.Size = new Size(190, 22);
			label3.TabIndex = 17;
			label3.Text = "Username or Email";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// LogIn
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.SlateBlue;
			ClientSize = new Size(428, 396);
			Controls.Add(panel1);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Margin = new Padding(3, 2, 3, 2);
			Name = "LogIn";
			StartPosition = FormStartPosition.CenterScreen;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private Button loginButton;
		private TextBox passwordTextbox;
		private Label label2;
		private Label label1;
		private TextBox usernameTextbox;
		private Label label3;
	}
}