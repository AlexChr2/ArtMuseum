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
			this.panel4 = new Panel();
			this.panel6 = new Panel();
			this.PreviousBtn = new Button();
			this.panel3 = new Panel();
			this.panel5 = new Panel();
			this.NextBtn = new Button();
			this.label2 = new Label();
			this.panel2 = new Panel();
			this.ImagePbx = new PictureBox();
			this.panel1 = new Panel();
			this.InformationTxtbx = new RichTextBox();
			this.AttractionPanel.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel2.SuspendLayout();
			(( System.ComponentModel.ISupportInitialize )this.ImagePbx).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// AttractionPanel
			// 
			this.AttractionPanel.BackColor = Color.MediumSlateBlue;
			this.AttractionPanel.Controls.Add( this.panel4 );
			this.AttractionPanel.Controls.Add( this.panel3 );
			this.AttractionPanel.Controls.Add( this.label2 );
			this.AttractionPanel.Controls.Add( this.panel2 );
			this.AttractionPanel.Location = new Point( 3, 3 );
			this.AttractionPanel.Name = "AttractionPanel";
			this.AttractionPanel.Size = new Size( 972, 510 );
			this.AttractionPanel.TabIndex = 0;
			// 
			// panel4
			// 
			this.panel4.BackColor = Color.DarkSlateBlue;
			this.panel4.Controls.Add( this.panel6 );
			this.panel4.Location = new Point( 2, 63 );
			this.panel4.Name = "panel4";
			this.panel4.Size = new Size( 67, 444 );
			this.panel4.TabIndex = 26;
			// 
			// panel6
			// 
			this.panel6.BackColor = Color.MediumSlateBlue;
			this.panel6.Controls.Add( this.PreviousBtn );
			this.panel6.Location = new Point( 3, 2 );
			this.panel6.Name = "panel6";
			this.panel6.Size = new Size( 61, 438 );
			this.panel6.TabIndex = 7;
			// 
			// PreviousBtn
			// 
			this.PreviousBtn.BackColor = Color.DarkSlateBlue;
			this.PreviousBtn.Font = new Font( "Lucida Calligraphy", 12F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.PreviousBtn.ForeColor = Color.Snow;
			this.PreviousBtn.Location = new Point( 3, 107 );
			this.PreviousBtn.Name = "PreviousBtn";
			this.PreviousBtn.Size = new Size( 54, 222 );
			this.PreviousBtn.TabIndex = 6;
			this.PreviousBtn.Text = "<";
			this.PreviousBtn.UseVisualStyleBackColor = false;
			this.PreviousBtn.Click += this.PreviousBtn_Click;
			// 
			// panel3
			// 
			this.panel3.BackColor = Color.DarkSlateBlue;
			this.panel3.Controls.Add( this.panel5 );
			this.panel3.Location = new Point( 903, 63 );
			this.panel3.Name = "panel3";
			this.panel3.Size = new Size( 67, 444 );
			this.panel3.TabIndex = 25;
			// 
			// panel5
			// 
			this.panel5.BackColor = Color.MediumSlateBlue;
			this.panel5.Controls.Add( this.NextBtn );
			this.panel5.Location = new Point( 3, 2 );
			this.panel5.Name = "panel5";
			this.panel5.Size = new Size( 61, 438 );
			this.panel5.TabIndex = 7;
			// 
			// NextBtn
			// 
			this.NextBtn.BackColor = Color.DarkSlateBlue;
			this.NextBtn.Font = new Font( "Lucida Calligraphy", 10.2F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.NextBtn.ForeColor = Color.Snow;
			this.NextBtn.Location = new Point( 3, 107 );
			this.NextBtn.Name = "NextBtn";
			this.NextBtn.Size = new Size( 54, 222 );
			this.NextBtn.TabIndex = 6;
			this.NextBtn.Text = ">";
			this.NextBtn.UseVisualStyleBackColor = false;
			this.NextBtn.Click += this.NextBtn_Click;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.FlatStyle = FlatStyle.Flat;
			this.label2.Font = new Font( "Lucida Bright", 22.2F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.label2.ForeColor = Color.Snow;
			this.label2.Location = new Point( 314, 6 );
			this.label2.Name = "label2";
			this.label2.Size = new Size( 388, 42 );
			this.label2.TabIndex = 24;
			this.label2.Text = "General information";
			this.label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.BackColor = Color.DarkSlateBlue;
			this.panel2.Controls.Add( this.ImagePbx );
			this.panel2.Controls.Add( this.panel1 );
			this.panel2.Location = new Point( 72, 63 );
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size( 829, 444 );
			this.panel2.TabIndex = 3;
			// 
			// ImagePbx
			// 
			this.ImagePbx.BackColor = Color.MediumSlateBlue;
			this.ImagePbx.Location = new Point( 3, 3 );
			this.ImagePbx.Name = "ImagePbx";
			this.ImagePbx.Size = new Size( 265, 438 );
			this.ImagePbx.SizeMode = PictureBoxSizeMode.StretchImage;
			this.ImagePbx.TabIndex = 0;
			this.ImagePbx.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = Color.MediumSlateBlue;
			this.panel1.Controls.Add( this.InformationTxtbx );
			this.panel1.Location = new Point( 270, 3 );
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size( 556, 438 );
			this.panel1.TabIndex = 4;
			// 
			// InformationTxtbx
			// 
			this.InformationTxtbx.BackColor = Color.MediumSlateBlue;
			this.InformationTxtbx.BorderStyle = BorderStyle.None;
			this.InformationTxtbx.Font = new Font( "Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.InformationTxtbx.ForeColor = Color.Snow;
			this.InformationTxtbx.Location = new Point( 4, 4 );
			this.InformationTxtbx.Margin = new Padding( 3, 4, 3, 4 );
			this.InformationTxtbx.Name = "InformationTxtbx";
			this.InformationTxtbx.ReadOnly = true;
			this.InformationTxtbx.Size = new Size( 549, 430 );
			this.InformationTxtbx.TabIndex = 0;
			this.InformationTxtbx.Text = "";
			// 
			// MatterHall
			// 
			AutoScaleDimensions = new SizeF( 8F, 20F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSlateBlue;
			ClientSize = new Size( 978, 517 );
			Controls.Add( this.AttractionPanel );
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "MatterHall";
			StartPosition = FormStartPosition.CenterScreen;
			this.FormClosed += this.MatterHall_FormClosed;
			this.Shown += this.MatterHall_Shown;
			this.AttractionPanel.ResumeLayout( false );
			this.AttractionPanel.PerformLayout();
			this.panel4.ResumeLayout( false );
			this.panel6.ResumeLayout( false );
			this.panel3.ResumeLayout( false );
			this.panel5.ResumeLayout( false );
			this.panel2.ResumeLayout( false );
			(( System.ComponentModel.ISupportInitialize )this.ImagePbx).EndInit();
			this.panel1.ResumeLayout( false );
			this.ResumeLayout( false );
		}

		#endregion

		private Panel AttractionPanel;
		private Panel panel2;
		private PictureBox ImagePbx;
		private Panel panel1;
		private Button NextBtn;
		private Label label2;
		private Panel panel3;
		private Panel panel5;
		private RichTextBox InformationTxtbx;
		private Panel panel4;
		private Panel panel6;
		private Button PreviousBtn;
	}
}