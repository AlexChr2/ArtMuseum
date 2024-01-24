namespace Ergasia3.src.ExhibitionHall
{
	partial class HallSelection
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
			this.groupBox1 = new GroupBox();
			this.pictureBox1 = new PictureBox();
			this.button4 = new Button();
			this.button2 = new Button();
			this.button1 = new Button();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			(( System.ComponentModel.ISupportInitialize )this.pictureBox1).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = Color.SlateBlue;
			this.panel1.Controls.Add( this.groupBox1 );
			this.panel1.ForeColor = Color.RosyBrown;
			this.panel1.Location = new Point( 2, 3 );
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size( 510, 341 );
			this.panel1.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add( this.pictureBox1 );
			this.groupBox1.Controls.Add( this.button4 );
			this.groupBox1.Controls.Add( this.button2 );
			this.groupBox1.Controls.Add( this.button1 );
			this.groupBox1.Font = new Font( "Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.groupBox1.ForeColor = Color.PeachPuff;
			this.groupBox1.Location = new Point( 10, 26 );
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new Size( 490, 307 );
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Category Selection";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = Properties.Resources.ArtLogo;
			this.pictureBox1.Location = new Point( 227, 44 );
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size( 257, 233 );
			this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// button4
			// 
			this.button4.BackColor = Color.Wheat;
			this.button4.Font = new Font( "Lucida Calligraphy", 12F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.button4.ForeColor = Color.SlateBlue;
			this.button4.Location = new Point( 41, 44 );
			this.button4.Name = "button4";
			this.button4.Size = new Size( 147, 51 );
			this.button4.TabIndex = 4;
			this.button4.Text = "ART";
			this.button4.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = Color.Wheat;
			this.button2.Font = new Font( "Verdana Pro Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point,   161 );
			this.button2.ForeColor = Color.SlateBlue;
			this.button2.Location = new Point( 41, 226 );
			this.button2.Name = "button2";
			this.button2.Size = new Size( 147, 51 );
			this.button2.TabIndex = 5;
			this.button2.Text = "MOVIES";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button1
			// 
			this.button1.BackColor = Color.Wheat;
			this.button1.Font = new Font( "Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point,   161 );
			this.button1.ForeColor = Color.SlateBlue;
			this.button1.Location = new Point( 41, 136 );
			this.button1.Name = "button1";
			this.button1.Size = new Size( 147, 51 );
			this.button1.TabIndex = 0;
			this.button1.Text = "MUSIC";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// HallSelection
			// 
			AutoScaleDimensions = new SizeF( 8F, 20F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSlateBlue;
			ClientSize = new Size( 514, 348 );
			Controls.Add( this.panel1 );
			ForeColor = Color.Transparent;
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "HallSelection";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "HallSelection";
			this.panel1.ResumeLayout( false );
			this.groupBox1.ResumeLayout( false );
			(( System.ComponentModel.ISupportInitialize )this.pictureBox1).EndInit();
			this.ResumeLayout( false );
		}

		#endregion

		private Panel panel1;
		private Button button1;
		private Button button2;
		private Button button4;
		private GroupBox groupBox1;
		private PictureBox pictureBox1;
	}
}