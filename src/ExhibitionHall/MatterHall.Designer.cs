namespace Ergasia3.src.ExhibitionHall
{
	partial class MatterHall
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
			this.AttractionPanel = new Panel();
			this.panel2 = new Panel();
			this.pictureBox1 = new PictureBox();
			this.panel1 = new Panel();
			this.label1 = new Label();
			this.button4 = new Button();
			this.AttractionPanel.SuspendLayout();
			this.panel2.SuspendLayout();
			(( System.ComponentModel.ISupportInitialize )this.pictureBox1).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// AttractionPanel
			// 
			this.AttractionPanel.BackColor = Color.SlateBlue;
			this.AttractionPanel.Controls.Add( this.button4 );
			this.AttractionPanel.Controls.Add( this.panel1 );
			this.AttractionPanel.Controls.Add( this.panel2 );
			this.AttractionPanel.Location = new Point( 3, 2 );
			this.AttractionPanel.Name = "AttractionPanel";
			this.AttractionPanel.Size = new Size( 950, 517 );
			this.AttractionPanel.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = Color.MediumSlateBlue;
			this.panel2.Controls.Add( this.pictureBox1 );
			this.panel2.Location = new Point( 3, 3 );
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size( 441, 511 );
			this.panel2.TabIndex = 3;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = Properties.Resources.ArtLogo;
			this.pictureBox1.Location = new Point( 3, 3 );
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size( 435, 502 );
			this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = Color.MediumSlateBlue;
			this.panel1.Controls.Add( this.label1 );
			this.panel1.Location = new Point( 447, 3 );
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size( 437, 511 );
			this.panel1.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.FlatStyle = FlatStyle.Flat;
			this.label1.Font = new Font( "Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.label1.ForeColor = Color.SeaShell;
			this.label1.Location = new Point( 106, 223 );
			this.label1.Name = "label1";
			this.label1.Size = new Size( 253, 52 );
			this.label1.TabIndex = 5;
			this.label1.Text = "General information \r\nabout the image.";
			this.label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// button4
			// 
			this.button4.BackColor = Color.LightSteelBlue;
			this.button4.Font = new Font( "Lucida Calligraphy", 12F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.button4.ForeColor = Color.DimGray;
			this.button4.Location = new Point( 890, 150 );
			this.button4.Name = "button4";
			this.button4.Size = new Size( 51, 200 );
			this.button4.TabIndex = 6;
			this.button4.Text = "N\r\nE\r\nX\r\nT";
			this.button4.UseVisualStyleBackColor = false;
			// 
			// ExhibitionHall
			// 
			AutoScaleDimensions = new SizeF( 8F, 20F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Snow;
			ClientSize = new Size( 956, 522 );
			Controls.Add( this.AttractionPanel );
			Name = "ExhibitionHall";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ExhibitionHall";
			this.AttractionPanel.ResumeLayout( false );
			this.panel2.ResumeLayout( false );
			(( System.ComponentModel.ISupportInitialize )this.pictureBox1).EndInit();
			this.panel1.ResumeLayout( false );
			this.panel1.PerformLayout();
			this.ResumeLayout( false );
		}

		#endregion

		private Panel AttractionPanel;
		private Panel panel2;
		private PictureBox pictureBox1;
		private Panel panel1;
		private Label label1;
		private Button button4;
	}
}