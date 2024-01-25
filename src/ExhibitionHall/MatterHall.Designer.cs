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
			AttractionPanel = new Panel();
			panel3 = new Panel();
			panel5 = new Panel();
			nextButton = new Button();
			label2 = new Label();
			panel2 = new Panel();
			panel4 = new Panel();
			pictureBox1 = new PictureBox();
			panel1 = new Panel();
			infoTextBox = new RichTextBox();
			AttractionPanel.SuspendLayout();
			panel3.SuspendLayout();
			panel5.SuspendLayout();
			panel2.SuspendLayout();
			panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// AttractionPanel
			// 
			AttractionPanel.BackColor = Color.SlateBlue;
			AttractionPanel.Controls.Add(panel3);
			AttractionPanel.Controls.Add(label2);
			AttractionPanel.Controls.Add(panel2);
			AttractionPanel.Location = new Point(3, 2);
			AttractionPanel.Margin = new Padding(3, 2, 3, 2);
			AttractionPanel.Name = "AttractionPanel";
			AttractionPanel.Size = new Size(792, 389);
			AttractionPanel.TabIndex = 0;
			// 
			// panel3
			// 
			panel3.BackColor = Color.DarkSlateBlue;
			panel3.Controls.Add(panel5);
			panel3.Location = new Point(731, 52);
			panel3.Margin = new Padding(3, 2, 3, 2);
			panel3.Name = "panel3";
			panel3.Size = new Size(59, 333);
			panel3.TabIndex = 25;
			// 
			// panel5
			// 
			panel5.BackColor = Color.MediumSlateBlue;
			panel5.Controls.Add(nextButton);
			panel5.Location = new Point(3, 6);
			panel5.Margin = new Padding(3, 2, 3, 2);
			panel5.Name = "panel5";
			panel5.Size = new Size(61, 381);
			panel5.TabIndex = 7;
			// 
			// nextButton
			// 
			nextButton.BackColor = Color.DarkSlateBlue;
			nextButton.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			nextButton.ForeColor = Color.Snow;
			nextButton.Location = new Point(5, 87);
			nextButton.Margin = new Padding(3, 2, 3, 2);
			nextButton.Name = "nextButton";
			nextButton.Size = new Size(48, 152);
			nextButton.TabIndex = 6;
			nextButton.Text = "N\r\nE\r\nX\r\nT";
			nextButton.UseVisualStyleBackColor = false;
			nextButton.Click += nextButton_Click;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.FlatStyle = FlatStyle.Flat;
			label2.Font = new Font("Lucida Bright", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.SeaShell;
			label2.Location = new Point(251, 5);
			label2.Name = "label2";
			label2.Size = new Size(320, 34);
			label2.TabIndex = 24;
			label2.Text = "General information";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			panel2.BackColor = Color.DarkSlateBlue;
			panel2.Controls.Add(panel4);
			panel2.Controls.Add(panel1);
			panel2.Location = new Point(3, 52);
			panel2.Margin = new Padding(3, 2, 3, 2);
			panel2.Name = "panel2";
			panel2.Size = new Size(723, 333);
			panel2.TabIndex = 3;
			// 
			// panel4
			// 
			panel4.BackColor = Color.DarkSlateBlue;
			panel4.Controls.Add(pictureBox1);
			panel4.Location = new Point(5, 4);
			panel4.Margin = new Padding(3, 2, 3, 2);
			panel4.Name = "panel4";
			panel4.Size = new Size(228, 324);
			panel4.TabIndex = 6;
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.MediumSlateBlue;
			pictureBox1.Image = Properties.Resources.ArtLogo;
			pictureBox1.Location = new Point(3, 2);
			pictureBox1.Margin = new Padding(3, 2, 3, 2);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(221, 318);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 0;
			pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			panel1.BackColor = Color.MediumSlateBlue;
			panel1.Controls.Add(infoTextBox);
			panel1.Location = new Point(239, 7);
			panel1.Margin = new Padding(3, 2, 3, 2);
			panel1.Name = "panel1";
			panel1.Size = new Size(477, 317);
			panel1.TabIndex = 4;
			// 
			// infoTextBox
			// 
			infoTextBox.BackColor = Color.MediumSlateBlue;
			infoTextBox.BorderStyle = BorderStyle.None;
			infoTextBox.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			infoTextBox.ForeColor = Color.Snow;
			infoTextBox.Location = new Point(3, 3);
			infoTextBox.Name = "infoTextBox";
			infoTextBox.ReadOnly = true;
			infoTextBox.Size = new Size(471, 314);
			infoTextBox.TabIndex = 0;
			infoTextBox.Text = "";
			// 
			// MatterHall
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSlateBlue;
			ClientSize = new Size(798, 394);
			Controls.Add(AttractionPanel);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Margin = new Padding(3, 2, 3, 2);
			Name = "MatterHall";
			StartPosition = FormStartPosition.CenterScreen;
			Shown += MatterHall_Shown;
			AttractionPanel.ResumeLayout(false);
			AttractionPanel.PerformLayout();
			panel3.ResumeLayout(false);
			panel5.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel1.ResumeLayout(false);
			ResumeLayout(false);
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