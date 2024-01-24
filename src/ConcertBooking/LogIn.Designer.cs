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
			this.panel1 = new Panel();
			this.button4 = new Button();
			this.textBox3 = new TextBox();
			this.label2 = new Label();
			this.label1 = new Label();
			this.textBox2 = new TextBox();
			this.label3 = new Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = Color.Snow;
			this.panel1.Controls.Add( this.button4 );
			this.panel1.Controls.Add( this.textBox3 );
			this.panel1.Controls.Add( this.label2 );
			this.panel1.Controls.Add( this.label1 );
			this.panel1.Controls.Add( this.textBox2 );
			this.panel1.Controls.Add( this.label3 );
			this.panel1.Location = new Point( 3, 2 );
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size( 483, 524 );
			this.panel1.TabIndex = 1;
			// 
			// button4
			// 
			this.button4.BackColor = Color.DarkSlateBlue;
			this.button4.Font = new Font( "Lucida Calligraphy", 13.8F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.button4.ForeColor = Color.Snow;
			this.button4.Location = new Point( 64, 390 );
			this.button4.Name = "button4";
			this.button4.Size = new Size( 340, 67 );
			this.button4.TabIndex = 25;
			this.button4.Text = "Log in";
			this.button4.UseVisualStyleBackColor = false;
			// 
			// textBox3
			// 
			this.textBox3.BackColor = Color.Snow;
			this.textBox3.Font = new Font( "Nirmala UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.textBox3.ForeColor = Color.SlateGray;
			this.textBox3.Location = new Point( 64, 292 );
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new Size( 340, 43 );
			this.textBox3.TabIndex = 24;
			this.textBox3.Text = "Password";
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
			this.label1.ForeColor = Color.DarkSlateBlue;
			this.label1.Location = new Point( 179, 28 );
			this.label1.Name = "label1";
			this.label1.Size = new Size( 131, 42 );
			this.label1.TabIndex = 22;
			this.label1.Text = "Log in";
			this.label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// textBox2
			// 
			this.textBox2.BackColor = Color.Snow;
			this.textBox2.Font = new Font( "Nirmala UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.textBox2.ForeColor = Color.SlateGray;
			this.textBox2.Location = new Point( 64, 169 );
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new Size( 340, 43 );
			this.textBox2.TabIndex = 18;
			this.textBox2.Text = "Email";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.FlatStyle = FlatStyle.Flat;
			this.label3.Font = new Font( "Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.label3.ForeColor = Color.DarkSlateBlue;
			this.label3.Location = new Point( 64, 130 );
			this.label3.Name = "label3";
			this.label3.Size = new Size( 76, 26 );
			this.label3.TabIndex = 17;
			this.label3.Text = "Email";
			this.label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// LogIn
			// 
			AutoScaleDimensions = new SizeF( 8F, 20F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.SlateBlue;
			ClientSize = new Size( 489, 528 );
			Controls.Add( this.panel1 );
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "LogIn";
			StartPosition = FormStartPosition.CenterScreen;
			this.panel1.ResumeLayout( false );
			this.panel1.PerformLayout();
			this.ResumeLayout( false );
		}

		#endregion

		private Panel panel1;
		private Button button4;
		private TextBox textBox3;
		private Label label2;
		private Label label1;
		private TextBox textBox2;
		private Label label3;
	}
}