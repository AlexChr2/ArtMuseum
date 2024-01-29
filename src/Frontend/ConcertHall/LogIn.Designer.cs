namespace Ergasia3.src.Frontend.ConcertHall
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
			this.panel1 = new Panel();
			this.loginButton = new Button();
			this.passwordTextbox = new TextBox();
			this.label2 = new Label();
			this.label1 = new Label();
			this.usernameTextbox = new TextBox();
			this.label3 = new Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = Color.MediumSlateBlue;
			this.panel1.Controls.Add( this.loginButton );
			this.panel1.Controls.Add( this.passwordTextbox );
			this.panel1.Controls.Add( this.label2 );
			this.panel1.Controls.Add( this.label1 );
			this.panel1.Controls.Add( this.usernameTextbox );
			this.panel1.Controls.Add( this.label3 );
			this.panel1.Location = new Point( 3, 3 );
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size( 483, 505 );
			this.panel1.TabIndex = 1;
			// 
			// loginButton
			// 
			this.loginButton.BackColor = Color.DarkSlateBlue;
			this.loginButton.Font = new Font( "Lucida Calligraphy", 13.8F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.loginButton.ForeColor = Color.Snow;
			this.loginButton.Location = new Point( 64, 386 );
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new Size( 341, 67 );
			this.loginButton.TabIndex = 25;
			this.loginButton.Text = "Log in";
			this.loginButton.UseVisualStyleBackColor = false;
			this.loginButton.Click += this.loginButton_Click;
			// 
			// passwordTextbox
			// 
			this.passwordTextbox.BackColor = Color.Snow;
			this.passwordTextbox.Font = new Font( "Nirmala UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.passwordTextbox.ForeColor = Color.SlateGray;
			this.passwordTextbox.Location = new Point( 64, 292 );
			this.passwordTextbox.MaxLength = 32;
			this.passwordTextbox.Name = "passwordTextbox";
			this.passwordTextbox.PasswordChar = '*';
			this.passwordTextbox.Size = new Size( 340, 43 );
			this.passwordTextbox.TabIndex = 24;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.FlatStyle = FlatStyle.Flat;
			this.label2.Font = new Font( "Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.label2.ForeColor = Color.DarkSlateBlue;
			this.label2.Location = new Point( 64, 253 );
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
			this.label1.Location = new Point( 180, 28 );
			this.label1.Name = "label1";
			this.label1.Size = new Size( 131, 42 );
			this.label1.TabIndex = 22;
			this.label1.Text = "Log in";
			this.label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// usernameTextbox
			// 
			this.usernameTextbox.BackColor = Color.Snow;
			this.usernameTextbox.Font = new Font( "Nirmala UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.usernameTextbox.ForeColor = Color.SlateGray;
			this.usernameTextbox.Location = new Point( 64, 169 );
			this.usernameTextbox.MaxLength = 32;
			this.usernameTextbox.Name = "usernameTextbox";
			this.usernameTextbox.PlaceholderText = "Username";
			this.usernameTextbox.Size = new Size( 340, 43 );
			this.usernameTextbox.TabIndex = 18;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.FlatStyle = FlatStyle.Flat;
			this.label3.Font = new Font( "Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.label3.ForeColor = Color.DarkSlateBlue;
			this.label3.Location = new Point( 64, 131 );
			this.label3.Name = "label3";
			this.label3.Size = new Size( 232, 26 );
			this.label3.TabIndex = 17;
			this.label3.Text = "Username or Email";
			this.label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// LogIn
			// 
			AutoScaleDimensions = new SizeF( 8F, 20F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSlateBlue;
			ClientSize = new Size( 489, 511 );
			Controls.Add( this.panel1 );
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "LogIn";
			StartPosition = FormStartPosition.CenterScreen;
			this.FormClosed += this.LogIn_FormClosed;
			this.panel1.ResumeLayout( false );
			this.panel1.PerformLayout();
			this.ResumeLayout( false );
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