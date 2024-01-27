namespace Ergasia3.src.Frontend.ExhibitionHall
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
			this.nextButton = new Button();
			this.label2 = new Label();
			this.panel2 = new Panel();
			this.panel4 = new Panel();
			this.pictureBox1 = new PictureBox();
			this.panel1 = new Panel();
			this.infoTextBox = new RichTextBox();
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
			this.AttractionPanel.Location = new Point( 3, 3 );
			this.AttractionPanel.Name = "AttractionPanel";
			this.AttractionPanel.Size = new Size( 905, 519 );
			this.AttractionPanel.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.BackColor = Color.DarkSlateBlue;
			this.panel3.Controls.Add( this.panel5 );
			this.panel3.Location = new Point( 835, 69 );
			this.panel3.Name = "panel3";
			this.panel3.Size = new Size( 67, 444 );
			this.panel3.TabIndex = 25;
			// 
			// panel5
			// 
			this.panel5.BackColor = Color.MediumSlateBlue;
			this.panel5.Controls.Add( this.nextButton );
			this.panel5.Location = new Point( 3, 5 );
			this.panel5.Name = "panel5";
			this.panel5.Size = new Size( 61, 432 );
			this.panel5.TabIndex = 7;
			// 
			// nextButton
			// 
			this.nextButton.BackColor = Color.DarkSlateBlue;
			this.nextButton.Font = new Font( "Lucida Calligraphy", 12F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.nextButton.ForeColor = Color.Snow;
			this.nextButton.Location = new Point( 3, 109 );
			this.nextButton.Name = "nextButton";
			this.nextButton.Size = new Size( 55, 203 );
			this.nextButton.TabIndex = 6;
			this.nextButton.Text = "N\r\nE\r\nX\r\nT";
			this.nextButton.UseVisualStyleBackColor = false;
			this.nextButton.Click += this.nextButton_Click;
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
			this.panel2.Location = new Point( 3, 69 );
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size( 826, 444 );
			this.panel2.TabIndex = 3;
			// 
			// panel4
			// 
			this.panel4.BackColor = Color.DarkSlateBlue;
			this.panel4.Controls.Add( this.pictureBox1 );
			this.panel4.Location = new Point( 6, 5 );
			this.panel4.Name = "panel4";
			this.panel4.Size = new Size( 261, 432 );
			this.panel4.TabIndex = 6;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = Color.MediumSlateBlue;
			this.pictureBox1.Location = new Point( 3, 3 );
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size( 253, 424 );
			this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = Color.MediumSlateBlue;
			this.panel1.Controls.Add( this.infoTextBox );
			this.panel1.Location = new Point( 273, 9 );
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size( 545, 423 );
			this.panel1.TabIndex = 4;
			// 
			// infoTextBox
			// 
			this.infoTextBox.BackColor = Color.MediumSlateBlue;
			this.infoTextBox.BorderStyle = BorderStyle.None;
			this.infoTextBox.Font = new Font( "Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.infoTextBox.ForeColor = Color.Snow;
			this.infoTextBox.Location = new Point( 3, 4 );
			this.infoTextBox.Margin = new Padding( 3, 4, 3, 4 );
			this.infoTextBox.Name = "infoTextBox";
			this.infoTextBox.ReadOnly = true;
			this.infoTextBox.Size = new Size( 538, 419 );
			this.infoTextBox.TabIndex = 0;
			this.infoTextBox.Text = "";
			// 
			// MatterHall
			// 
			AutoScaleDimensions = new SizeF( 8F, 20F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSlateBlue;
			ClientSize = new Size( 912, 525 );
			Controls.Add( this.AttractionPanel );
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			MaximumSize = new Size( 930, 572 );
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
			this.ResumeLayout( false );
		}

		#endregion

		private Panel AttractionPanel;
		private Panel panel2;
		private PictureBox pictureBox1;
		private Panel panel1;
		private Button nextButton;
		private Label label2;
		private Panel panel3;
		private Panel panel4;
		private Panel panel5;
		private RichTextBox infoTextBox;
	}
}