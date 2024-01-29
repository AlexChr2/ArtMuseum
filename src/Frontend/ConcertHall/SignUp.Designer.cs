namespace Ergasia3.src.Frontend.ConcertHall
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
			this.panel1 = new Panel();
			this.signUpButton = new Button();
			this.passwordTextBox = new TextBox();
			this.label2 = new Label();
			this.label1 = new Label();
			this.emailTextBox = new TextBox();
			this.label3 = new Label();
			this.usernameTextbox = new TextBox();
			this.label6 = new Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = Color.MediumSlateBlue;
			this.panel1.Controls.Add( this.signUpButton );
			this.panel1.Controls.Add( this.passwordTextBox );
			this.panel1.Controls.Add( this.label2 );
			this.panel1.Controls.Add( this.label1 );
			this.panel1.Controls.Add( this.emailTextBox );
			this.panel1.Controls.Add( this.label3 );
			this.panel1.Controls.Add( this.usernameTextbox );
			this.panel1.Controls.Add( this.label6 );
			this.panel1.Location = new Point( 2, 3 );
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size( 474, 622 );
			this.panel1.TabIndex = 0;
			// 
			// signUpButton
			// 
			this.signUpButton.BackColor = Color.DarkSlateBlue;
			this.signUpButton.Font = new Font( "Lucida Calligraphy", 13.8F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.signUpButton.ForeColor = Color.Snow;
			this.signUpButton.Location = new Point( 63, 505 );
			this.signUpButton.Name = "signUpButton";
			this.signUpButton.Size = new Size( 341, 67 );
			this.signUpButton.TabIndex = 25;
			this.signUpButton.Text = "Sign up";
			this.signUpButton.UseVisualStyleBackColor = false;
			this.signUpButton.Click += this.signUpButton_Click;
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.BackColor = Color.Snow;
			this.passwordTextBox.Font = new Font( "Nirmala UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.passwordTextBox.ForeColor = Color.SlateGray;
			this.passwordTextBox.Location = new Point( 64, 411 );
			this.passwordTextBox.MaxLength = 32;
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.PasswordChar = '*';
			this.passwordTextBox.Size = new Size( 340, 43 );
			this.passwordTextBox.TabIndex = 24;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.FlatStyle = FlatStyle.Flat;
			this.label2.Font = new Font( "Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.label2.ForeColor = Color.DarkSlateBlue;
			this.label2.Location = new Point( 64, 372 );
			this.label2.Name = "label2";
			this.label2.Size = new Size( 126, 26 );
			this.label2.TabIndex = 23;
			this.label2.Text = "Password";
			this.label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.FlatStyle = FlatStyle.Flat;
			this.label1.Font = new Font( "Lucida Bright", 22.2F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.label1.ForeColor = Color.Snow;
			this.label1.Location = new Point( 167, 25 );
			this.label1.Name = "label1";
			this.label1.Size = new Size( 156, 42 );
			this.label1.TabIndex = 22;
			this.label1.Text = "Sign up";
			this.label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// emailTextBox
			// 
			this.emailTextBox.BackColor = Color.Snow;
			this.emailTextBox.Font = new Font( "Nirmala UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.emailTextBox.ForeColor = Color.SlateGray;
			this.emailTextBox.Location = new Point( 64, 288 );
			this.emailTextBox.MaxLength = 64;
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.PlaceholderText = "example@domain.com";
			this.emailTextBox.Size = new Size( 340, 43 );
			this.emailTextBox.TabIndex = 18;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.FlatStyle = FlatStyle.Flat;
			this.label3.Font = new Font( "Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.label3.ForeColor = Color.DarkSlateBlue;
			this.label3.Location = new Point( 64, 249 );
			this.label3.Name = "label3";
			this.label3.Size = new Size( 76, 26 );
			this.label3.TabIndex = 17;
			this.label3.Text = "Email";
			this.label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// usernameTextbox
			// 
			this.usernameTextbox.BackColor = Color.Snow;
			this.usernameTextbox.Font = new Font( "Nirmala UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.usernameTextbox.ForeColor = Color.SlateGray;
			this.usernameTextbox.Location = new Point( 64, 167 );
			this.usernameTextbox.MaxLength = 32;
			this.usernameTextbox.Name = "usernameTextbox";
			this.usernameTextbox.PlaceholderText = "Username";
			this.usernameTextbox.Size = new Size( 340, 43 );
			this.usernameTextbox.TabIndex = 16;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.FlatStyle = FlatStyle.Flat;
			this.label6.Font = new Font( "Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.label6.ForeColor = Color.DarkSlateBlue;
			this.label6.Location = new Point( 64, 128 );
			this.label6.Name = "label6";
			this.label6.Size = new Size( 128, 26 );
			this.label6.TabIndex = 15;
			this.label6.Text = "Username";
			this.label6.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// SignUp
			// 
			AutoScaleDimensions = new SizeF( 8F, 20F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSlateBlue;
			ClientSize = new Size( 478, 628 );
			Controls.Add( this.panel1 );
			ForeColor = SystemColors.ControlText;
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "SignUp";
			StartPosition = FormStartPosition.CenterScreen;
			this.panel1.ResumeLayout( false );
			this.panel1.PerformLayout();
			this.ResumeLayout( false );
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