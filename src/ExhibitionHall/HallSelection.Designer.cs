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
			panel1 = new Panel();
			panel2 = new Panel();
			moviesButton = new Button();
			musicButton = new Button();
			artButton = new Button();
			pictureBox1 = new PictureBox();
			label1 = new Label();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// panel1
			// 
			panel1.BackColor = Color.SlateBlue;
			panel1.Controls.Add(panel2);
			panel1.Controls.Add(label1);
			panel1.ForeColor = Color.RosyBrown;
			panel1.Location = new Point(2, 2);
			panel1.Margin = new Padding(3, 2, 3, 2);
			panel1.Name = "panel1";
			panel1.Size = new Size(470, 280);
			panel1.TabIndex = 0;
			// 
			// panel2
			// 
			panel2.BackColor = Color.MediumSlateBlue;
			panel2.Controls.Add(moviesButton);
			panel2.Controls.Add(musicButton);
			panel2.Controls.Add(artButton);
			panel2.Controls.Add(pictureBox1);
			panel2.Location = new Point(3, 54);
			panel2.Margin = new Padding(3, 2, 3, 2);
			panel2.Name = "panel2";
			panel2.Size = new Size(465, 224);
			panel2.TabIndex = 24;
			// 
			// moviesButton
			// 
			moviesButton.BackColor = Color.DarkSlateBlue;
			moviesButton.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			moviesButton.ForeColor = Color.Snow;
			moviesButton.Location = new Point(36, 167);
			moviesButton.Margin = new Padding(3, 2, 3, 2);
			moviesButton.Name = "moviesButton";
			moviesButton.Size = new Size(129, 38);
			moviesButton.TabIndex = 12;
			moviesButton.Text = "Movies";
			moviesButton.UseVisualStyleBackColor = false;
			moviesButton.Click += moviesButton_Click;
			// 
			// musicButton
			// 
			musicButton.BackColor = Color.DarkSlateBlue;
			musicButton.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			musicButton.ForeColor = Color.Snow;
			musicButton.Location = new Point(36, 94);
			musicButton.Margin = new Padding(3, 2, 3, 2);
			musicButton.Name = "musicButton";
			musicButton.Size = new Size(129, 38);
			musicButton.TabIndex = 11;
			musicButton.Text = "Music";
			musicButton.UseVisualStyleBackColor = false;
			musicButton.Click += musicButton_Click;
			// 
			// artButton
			// 
			artButton.BackColor = Color.DarkSlateBlue;
			artButton.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			artButton.ForeColor = Color.Snow;
			artButton.Location = new Point(36, 22);
			artButton.Margin = new Padding(3, 2, 3, 2);
			artButton.Name = "artButton";
			artButton.Size = new Size(129, 38);
			artButton.TabIndex = 8;
			artButton.Text = "Art";
			artButton.UseVisualStyleBackColor = false;
			artButton.Click += artButton_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.MediumSlateBlue;
			pictureBox1.Image = Properties.Resources.ArtLogo;
			pictureBox1.Location = new Point(204, 22);
			pictureBox1.Margin = new Padding(3, 2, 3, 2);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(234, 184);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 10;
			pictureBox1.TabStop = false;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.FlatStyle = FlatStyle.Flat;
			label1.Font = new Font("Lucida Bright", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label1.ForeColor = Color.SeaShell;
			label1.Location = new Point(110, 4);
			label1.Name = "label1";
			label1.Size = new Size(242, 34);
			label1.TabIndex = 23;
			label1.Text = "Select category";
			label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// HallSelection
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.Snow;
			ClientSize = new Size(474, 284);
			Controls.Add(panel1);
			ForeColor = Color.Transparent;
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Margin = new Padding(3, 2, 3, 2);
			Name = "HallSelection";
			StartPosition = FormStartPosition.CenterScreen;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel panel1;
		private PictureBox pictureBox1;
		private Button artButton;
		private Label label1;
		private Panel panel2;
		private Button moviesButton;
		private Button musicButton;
	}
}