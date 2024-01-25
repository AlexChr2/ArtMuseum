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
			this.panel3 = new Panel();
			this.panel5 = new Panel();
			this.button4 = new Button();
			this.label2 = new Label();
			this.panel2 = new Panel();
			this.panel4 = new Panel();
			this.pictureBox1 = new PictureBox();
			this.panel1 = new Panel();
			this.label1 = new Label();
			this.AttractionPanel.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel4.SuspendLayout();
			(( System.ComponentModel.ISupportInitialize )this.pictureBox1).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// AttractionPanel
			// 
			this.AttractionPanel.BackColor = Color.SlateBlue;
			this.AttractionPanel.Controls.Add( this.panel3 );
			this.AttractionPanel.Controls.Add( this.label2 );
			this.AttractionPanel.Controls.Add( this.panel2 );
			this.AttractionPanel.Location = new Point( 3, 2 );
			this.AttractionPanel.Name = "AttractionPanel";
			this.AttractionPanel.Size = new Size( 905, 470 );
			this.AttractionPanel.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.BackColor = Color.DarkSlateBlue;
			this.panel3.Controls.Add( this.panel5 );
			this.panel3.Location = new Point( 835, 70 );
			this.panel3.Name = "panel3";
			this.panel3.Size = new Size( 67, 393 );
			this.panel3.TabIndex = 25;
			// 
			// panel5
			// 
			this.panel5.BackColor = Color.MediumSlateBlue;
			this.panel5.Controls.Add( this.button4 );
			this.panel5.Location = new Point( 3, 6 );
			this.panel5.Name = "panel5";
			this.panel5.Size = new Size( 61, 381 );
			this.panel5.TabIndex = 7;
			// 
			// button4
			// 
			this.button4.BackColor = Color.DarkSlateBlue;
			this.button4.Font = new Font( "Lucida Calligraphy", 12F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.button4.ForeColor = Color.Snow;
			this.button4.Location = new Point( 3, 92 );
			this.button4.Name = "button4";
			this.button4.Size = new Size( 55, 202 );
			this.button4.TabIndex = 6;
			this.button4.Text = "N\r\nE\r\nX\r\nT";
			this.button4.UseVisualStyleBackColor = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.FlatStyle = FlatStyle.Flat;
			this.label2.Font = new Font( "Lucida Bright", 22.2F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.label2.ForeColor = Color.SeaShell;
			this.label2.Location = new Point( 287, 7 );
			this.label2.Name = "label2";
			this.label2.Size = new Size( 388, 42 );
			this.label2.TabIndex = 24;
			this.label2.Text = "General information";
			this.label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.BackColor = Color.DarkSlateBlue;
			this.panel2.Controls.Add( this.panel4 );
			this.panel2.Controls.Add( this.panel1 );
			this.panel2.Location = new Point( 3, 70 );
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size( 826, 394 );
			this.panel2.TabIndex = 3;
			// 
			// panel4
			// 
			this.panel4.BackColor = Color.DarkSlateBlue;
			this.panel4.Controls.Add( this.pictureBox1 );
			this.panel4.Location = new Point( 6, 6 );
			this.panel4.Name = "panel4";
			this.panel4.Size = new Size( 298, 381 );
			this.panel4.TabIndex = 6;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = Color.MediumSlateBlue;
			this.pictureBox1.Image = Properties.Resources.ArtLogo;
			this.pictureBox1.Location = new Point( 3, 3 );
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size( 289, 378 );
			this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = Color.MediumSlateBlue;
			this.panel1.Controls.Add( this.label1 );
			this.panel1.Location = new Point( 310, 9 );
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size( 509, 378 );
			this.panel1.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.FlatStyle = FlatStyle.Flat;
			this.label1.Font = new Font( "Lucida Bright", 16.2F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.label1.ForeColor = Color.SeaShell;
			this.label1.Location = new Point( 112, 155 );
			this.label1.Name = "label1";
			this.label1.Size = new Size( 303, 62 );
			this.label1.TabIndex = 5;
			this.label1.Text = "General information \r\nabout the image.";
			this.label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// MatterHall
			// 
			AutoScaleDimensions = new SizeF( 8F, 20F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSlateBlue;
			ClientSize = new Size( 912, 477 );
			Controls.Add( this.AttractionPanel );
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "MatterHall";
			StartPosition = FormStartPosition.CenterScreen;
			this.Shown += this.MatterHall_Shown;
			this.AttractionPanel.ResumeLayout( false );
			this.AttractionPanel.PerformLayout();
			this.panel3.ResumeLayout( false );
			this.panel5.ResumeLayout( false );
			this.panel2.ResumeLayout( false );
			this.panel4.ResumeLayout( false );
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
		private Label label2;
		private Panel panel3;
		private Panel panel4;
		private Panel panel5;
	}
}