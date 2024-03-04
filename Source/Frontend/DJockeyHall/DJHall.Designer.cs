namespace Ergasia3.Source.Frontend.DJockeyHall
{
	partial class DJHall
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			ListViewGroup listViewGroup1 = new ListViewGroup("TItle", HorizontalAlignment.Left);
			ListViewGroup listViewGroup2 = new ListViewGroup("Artist", HorizontalAlignment.Left);
			ListViewGroup listViewGroup3 = new ListViewGroup("Category", HorizontalAlignment.Left);
			colorDialog1 = new ColorDialog();
			panel6 = new Panel();
			panel5 = new Panel();
			panel15 = new Panel();
			label3 = new Label();
			panel7 = new Panel();
			panel4 = new Panel();
			panel3 = new Panel();
			songsListView = new ListView();
			columnHeader1 = new ColumnHeader();
			columnHeader2 = new ColumnHeader();
			columnHeader3 = new ColumnHeader();
			columnHeader4 = new ColumnHeader();
			panel2 = new Panel();
			panel20 = new Panel();
			panel18 = new Panel();
			panel1 = new Panel();
			panel9 = new Panel();
			button1 = new Button();
			button2 = new Button();
			button4 = new Button();
			panel16 = new Panel();
			panel14 = new Panel();
			BPM_scrollbar = new VScrollBar();
			label4 = new Label();
			panel11 = new Panel();
			pictureBox1 = new PictureBox();
			panel8 = new Panel();
			panel12 = new Panel();
			panel17 = new Panel();
			label2 = new Label();
			BPM_textLbl = new Label();
			panel13 = new Panel();
			textBox1 = new TextBox();
			panel10 = new Panel();
			pictureBox2 = new PictureBox();
			panel6.SuspendLayout();
			panel5.SuspendLayout();
			panel15.SuspendLayout();
			panel7.SuspendLayout();
			panel4.SuspendLayout();
			panel3.SuspendLayout();
			panel2.SuspendLayout();
			panel20.SuspendLayout();
			panel1.SuspendLayout();
			panel9.SuspendLayout();
			panel16.SuspendLayout();
			panel14.SuspendLayout();
			panel11.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			panel8.SuspendLayout();
			panel12.SuspendLayout();
			panel17.SuspendLayout();
			panel13.SuspendLayout();
			panel10.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
			SuspendLayout();
			// 
			// panel6
			// 
			panel6.BackColor = Color.MediumSlateBlue;
			panel6.Controls.Add(panel5);
			panel6.Controls.Add(panel7);
			panel6.Location = new Point(3, 2);
			panel6.Margin = new Padding(3, 2, 3, 2);
			panel6.Name = "panel6";
			panel6.Size = new Size(997, 424);
			panel6.TabIndex = 16;
			// 
			// panel5
			// 
			panel5.BackColor = Color.DarkSlateBlue;
			panel5.Controls.Add(panel15);
			panel5.Location = new Point(3, 2);
			panel5.Margin = new Padding(3, 2, 3, 2);
			panel5.Name = "panel5";
			panel5.Size = new Size(991, 42);
			panel5.TabIndex = 33;
			// 
			// panel15
			// 
			panel15.BackColor = Color.MediumSlateBlue;
			panel15.Controls.Add(label3);
			panel15.Location = new Point(3, 2);
			panel15.Margin = new Padding(3, 2, 3, 2);
			panel15.Name = "panel15";
			panel15.Size = new Size(986, 38);
			panel15.TabIndex = 0;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.FlatStyle = FlatStyle.Flat;
			label3.Font = new Font("Lucida Bright", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label3.ForeColor = Color.Snow;
			label3.Location = new Point(431, 3);
			label3.Name = "label3";
			label3.Size = new Size(119, 34);
			label3.TabIndex = 22;
			label3.Text = "DJ hall";
			label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// panel7
			// 
			panel7.BackColor = Color.DarkSlateBlue;
			panel7.Controls.Add(panel4);
			panel7.Location = new Point(3, 46);
			panel7.Margin = new Padding(3, 2, 3, 2);
			panel7.Name = "panel7";
			panel7.Size = new Size(991, 374);
			panel7.TabIndex = 16;
			// 
			// panel4
			// 
			panel4.BackColor = Color.MediumSlateBlue;
			panel4.Controls.Add(panel3);
			panel4.Controls.Add(panel2);
			panel4.Controls.Add(panel1);
			panel4.Location = new Point(3, 2);
			panel4.Margin = new Padding(3, 2, 3, 2);
			panel4.Name = "panel4";
			panel4.Size = new Size(986, 370);
			panel4.TabIndex = 11;
			// 
			// panel3
			// 
			panel3.BackColor = Color.DarkSlateBlue;
			panel3.Controls.Add(songsListView);
			panel3.Location = new Point(368, 2);
			panel3.Margin = new Padding(3, 2, 3, 2);
			panel3.Name = "panel3";
			panel3.Size = new Size(615, 258);
			panel3.TabIndex = 1;
			// 
			// songsListView
			// 
			songsListView.BackColor = Color.MediumSlateBlue;
			songsListView.BorderStyle = BorderStyle.None;
			songsListView.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
			songsListView.Font = new Font("Lucida Bright", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			songsListView.ForeColor = Color.Snow;
			songsListView.GridLines = true;
			listViewGroup1.Header = "TItle";
			listViewGroup1.Name = "Title";
			listViewGroup2.Header = "Artist";
			listViewGroup2.Name = "Artist";
			listViewGroup3.Header = "Category";
			listViewGroup3.Name = "Category";
			songsListView.Groups.AddRange(new ListViewGroup[] { listViewGroup1, listViewGroup2, listViewGroup3 });
			songsListView.Location = new Point(4, 2);
			songsListView.Margin = new Padding(3, 2, 3, 2);
			songsListView.Name = "songsListView";
			songsListView.Size = new Size(609, 254);
			songsListView.TabIndex = 1;
			songsListView.UseCompatibleStateImageBehavior = false;
			songsListView.View = View.Details;
			// 
			// columnHeader1
			// 
			columnHeader1.Text = "Title";
			columnHeader1.Width = 174;
			// 
			// columnHeader2
			// 
			columnHeader2.Text = "Artist";
			columnHeader2.Width = 174;
			// 
			// columnHeader3
			// 
			columnHeader3.Text = "Category";
			columnHeader3.Width = 174;
			// 
			// columnHeader4
			// 
			columnHeader4.Text = "Duration";
			columnHeader4.Width = 174;
			// 
			// panel2
			// 
			panel2.BackColor = Color.DarkSlateBlue;
			panel2.Controls.Add(panel20);
			panel2.Location = new Point(368, 262);
			panel2.Margin = new Padding(3, 2, 3, 2);
			panel2.Name = "panel2";
			panel2.Size = new Size(615, 104);
			panel2.TabIndex = 1;
			// 
			// panel20
			// 
			panel20.BackColor = Color.MediumSlateBlue;
			panel20.Controls.Add(panel18);
			panel20.Location = new Point(4, 2);
			panel20.Margin = new Padding(3, 2, 3, 2);
			panel20.Name = "panel20";
			panel20.Size = new Size(609, 99);
			panel20.TabIndex = 17;
			// 
			// panel18
			// 
			panel18.BackColor = Color.DarkSlateBlue;
			panel18.Location = new Point(333, 4);
			panel18.Margin = new Padding(3, 2, 3, 2);
			panel18.Name = "panel18";
			panel18.Size = new Size(4, 90);
			panel18.TabIndex = 0;
			// 
			// panel1
			// 
			panel1.BackColor = Color.DarkSlateBlue;
			panel1.Controls.Add(panel9);
			panel1.Controls.Add(panel8);
			panel1.Location = new Point(3, 2);
			panel1.Margin = new Padding(3, 2, 3, 2);
			panel1.Name = "panel1";
			panel1.Size = new Size(364, 364);
			panel1.TabIndex = 0;
			// 
			// panel9
			// 
			panel9.BackColor = Color.MediumSlateBlue;
			panel9.Controls.Add(button1);
			panel9.Controls.Add(button2);
			panel9.Controls.Add(button4);
			panel9.Controls.Add(panel16);
			panel9.Controls.Add(panel11);
			panel9.Location = new Point(3, 86);
			panel9.Margin = new Padding(3, 2, 3, 2);
			panel9.Name = "panel9";
			panel9.Size = new Size(359, 276);
			panel9.TabIndex = 64;
			// 
			// button1
			// 
			button1.BackColor = Color.DarkSlateBlue;
			button1.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button1.ForeColor = Color.Snow;
			button1.Location = new Point(266, 220);
			button1.Margin = new Padding(3, 2, 3, 2);
			button1.Name = "button1";
			button1.Padding = new Padding(4, 0, 0, 1);
			button1.Size = new Size(74, 45);
			button1.TabIndex = 74;
			button1.Text = ">>";
			button1.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			button2.BackColor = Color.DarkSlateBlue;
			button2.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button2.ForeColor = Color.Snow;
			button2.Location = new Point(19, 220);
			button2.Margin = new Padding(3, 2, 3, 2);
			button2.Name = "button2";
			button2.Padding = new Padding(1, 0, 0, 1);
			button2.Size = new Size(74, 45);
			button2.TabIndex = 73;
			button2.Text = "<<";
			button2.UseVisualStyleBackColor = false;
			// 
			// button4
			// 
			button4.BackColor = Color.DarkSlateBlue;
			button4.Font = new Font("Lucida Bright", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
			button4.ForeColor = Color.Snow;
			button4.Location = new Point(116, 220);
			button4.Margin = new Padding(3, 2, 3, 2);
			button4.Name = "button4";
			button4.Padding = new Padding(8, 0, 0, 2);
			button4.Size = new Size(127, 45);
			button4.TabIndex = 72;
			button4.Text = "|>";
			button4.UseVisualStyleBackColor = false;
			// 
			// panel16
			// 
			panel16.BackColor = Color.DarkSlateBlue;
			panel16.Controls.Add(panel14);
			panel16.Location = new Point(3, 2);
			panel16.Margin = new Padding(3, 2, 3, 2);
			panel16.Name = "panel16";
			panel16.Size = new Size(80, 209);
			panel16.TabIndex = 71;
			// 
			// panel14
			// 
			panel14.BackColor = Color.MediumSlateBlue;
			panel14.Controls.Add(BPM_scrollbar);
			panel14.Controls.Add(label4);
			panel14.Location = new Point(3, 2);
			panel14.Margin = new Padding(3, 2, 3, 2);
			panel14.Name = "panel14";
			panel14.Size = new Size(74, 205);
			panel14.TabIndex = 69;
			// 
			// BPM_scrollbar
			// 
			BPM_scrollbar.Location = new Point(19, 14);
			BPM_scrollbar.Maximum = 220;
			BPM_scrollbar.Minimum = 80;
			BPM_scrollbar.Name = "BPM_scrollbar";
			BPM_scrollbar.Size = new Size(41, 155);
			BPM_scrollbar.TabIndex = 60;
			BPM_scrollbar.Value = 80;
			BPM_scrollbar.ValueChanged += BPM_scrollbar_ValueChanged;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.FlatStyle = FlatStyle.Flat;
			label4.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label4.ForeColor = Color.DarkSlateBlue;
			label4.Location = new Point(14, 176);
			label4.Name = "label4";
			label4.Size = new Size(43, 18);
			label4.TabIndex = 71;
			label4.Text = "BPM";
			label4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// panel11
			// 
			panel11.BackColor = Color.DarkSlateBlue;
			panel11.Controls.Add(pictureBox1);
			panel11.Location = new Point(83, 2);
			panel11.Margin = new Padding(3, 2, 3, 2);
			panel11.Name = "panel11";
			panel11.Size = new Size(273, 209);
			panel11.TabIndex = 68;
			// 
			// pictureBox1
			// 
			pictureBox1.BackColor = Color.MediumSlateBlue;
			pictureBox1.Image = Properties.Resources.ArtLogo;
			pictureBox1.Location = new Point(3, 2);
			pictureBox1.Margin = new Padding(3, 2, 3, 2);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(268, 205);
			pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox1.TabIndex = 67;
			pictureBox1.TabStop = false;
			// 
			// panel8
			// 
			panel8.BackColor = Color.MediumSlateBlue;
			panel8.Controls.Add(panel12);
			panel8.Controls.Add(panel10);
			panel8.Location = new Point(3, 2);
			panel8.Margin = new Padding(3, 2, 3, 2);
			panel8.Name = "panel8";
			panel8.Size = new Size(359, 81);
			panel8.TabIndex = 63;
			// 
			// panel12
			// 
			panel12.BackColor = Color.DarkSlateBlue;
			panel12.Controls.Add(panel17);
			panel12.Controls.Add(panel13);
			panel12.Location = new Point(3, 2);
			panel12.Margin = new Padding(3, 2, 3, 2);
			panel12.Name = "panel12";
			panel12.Size = new Size(354, 44);
			panel12.TabIndex = 17;
			// 
			// panel17
			// 
			panel17.BackColor = Color.MediumSlateBlue;
			panel17.Controls.Add(label2);
			panel17.Controls.Add(BPM_textLbl);
			panel17.Location = new Point(266, 2);
			panel17.Margin = new Padding(3, 2, 3, 2);
			panel17.Name = "panel17";
			panel17.Size = new Size(85, 39);
			panel17.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.FlatStyle = FlatStyle.Flat;
			label2.Font = new Font("Lucida Bright", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
			label2.ForeColor = Color.Snow;
			label2.Location = new Point(49, 16);
			label2.Name = "label2";
			label2.Size = new Size(32, 15);
			label2.TabIndex = 72;
			label2.Text = "BPM";
			label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// BPM_textLbl
			// 
			BPM_textLbl.AutoSize = true;
			BPM_textLbl.FlatStyle = FlatStyle.Flat;
			BPM_textLbl.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			BPM_textLbl.ForeColor = Color.DarkSlateBlue;
			BPM_textLbl.Location = new Point(4, 10);
			BPM_textLbl.Name = "BPM_textLbl";
			BPM_textLbl.Size = new Size(46, 22);
			BPM_textLbl.TabIndex = 46;
			BPM_textLbl.Text = "120";
			BPM_textLbl.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// panel13
			// 
			panel13.BackColor = Color.MediumSlateBlue;
			panel13.Controls.Add(textBox1);
			panel13.Location = new Point(3, 2);
			panel13.Margin = new Padding(3, 2, 3, 2);
			panel13.Name = "panel13";
			panel13.Size = new Size(262, 39);
			panel13.TabIndex = 0;
			// 
			// textBox1
			// 
			textBox1.BackColor = Color.MediumSlateBlue;
			textBox1.BorderStyle = BorderStyle.None;
			textBox1.Font = new Font("Lucida Bright", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
			textBox1.ForeColor = Color.Snow;
			textBox1.Location = new Point(14, 12);
			textBox1.Margin = new Padding(3, 2, 3, 2);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(236, 17);
			textBox1.TabIndex = 0;
			textBox1.Text = "ArtistTitleCategory";
			// 
			// panel10
			// 
			panel10.BackColor = Color.DarkSlateBlue;
			panel10.Controls.Add(pictureBox2);
			panel10.Location = new Point(3, 48);
			panel10.Margin = new Padding(3, 2, 3, 2);
			panel10.Name = "panel10";
			panel10.Size = new Size(354, 31);
			panel10.TabIndex = 17;
			// 
			// pictureBox2
			// 
			pictureBox2.BackColor = Color.MediumSlateBlue;
			pictureBox2.Location = new Point(3, 2);
			pictureBox2.Margin = new Padding(3, 2, 3, 2);
			pictureBox2.Name = "pictureBox2";
			pictureBox2.Size = new Size(348, 26);
			pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			pictureBox2.TabIndex = 17;
			pictureBox2.TabStop = false;
			// 
			// DJHall
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSlateBlue;
			ClientSize = new Size(1001, 428);
			Controls.Add(panel6);
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			MaximizeBox = false;
			Name = "DJHall";
			StartPosition = FormStartPosition.CenterScreen;
			FormClosed += DigitalDJ_FormClosed;
			Shown += DigitalDJForm_Shown;
			panel6.ResumeLayout(false);
			panel5.ResumeLayout(false);
			panel15.ResumeLayout(false);
			panel15.PerformLayout();
			panel7.ResumeLayout(false);
			panel4.ResumeLayout(false);
			panel3.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel20.ResumeLayout(false);
			panel1.ResumeLayout(false);
			panel9.ResumeLayout(false);
			panel16.ResumeLayout(false);
			panel14.ResumeLayout(false);
			panel14.PerformLayout();
			panel11.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			panel8.ResumeLayout(false);
			panel12.ResumeLayout(false);
			panel17.ResumeLayout(false);
			panel17.PerformLayout();
			panel13.ResumeLayout(false);
			panel13.PerformLayout();
			panel10.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
			ResumeLayout(false);
		}

		#endregion
		private ColorDialog colorDialog1;
		private Panel panel6;
		private Panel panel7;
		private Panel panel4;
		private Panel panel3;
		private ListView songsListView;
		private ColumnHeader columnHeader1;
		private ColumnHeader columnHeader2;
		private ColumnHeader columnHeader3;
		private ColumnHeader columnHeader4;
		private Panel panel2;
		private Panel panel20;
		private Panel panel1;
		private Panel panel9;
		private Button button1;
		private Button button2;
		private Button button4;
		private Panel panel16;
		private Panel panel14;
		private VScrollBar BPM_scrollbar;
		private Panel panel11;
		private PictureBox pictureBox1;
		private Panel panel8;
		private Panel panel5;
		private Panel panel15;
		private Label label3;
		private Label label4;
		private Panel panel10;
		private PictureBox pictureBox2;
		private Panel panel12;
		private Panel panel13;
		private Panel panel17;
		private Label label2;
		private Label BPM_textLbl;
		private TextBox textBox1;
		private Panel panel18;
	}
}
