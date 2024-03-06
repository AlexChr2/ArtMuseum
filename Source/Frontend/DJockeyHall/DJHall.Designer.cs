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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( DJHall ) );
			ListViewGroup listViewGroup1 = new ListViewGroup( "TItle", HorizontalAlignment.Left );
			ListViewGroup listViewGroup2 = new ListViewGroup( "Artist", HorizontalAlignment.Left );
			ListViewGroup listViewGroup3 = new ListViewGroup( "Category", HorizontalAlignment.Left );
			this.panel6 = new Panel();
			this.panel5 = new Panel();
			this.panel15 = new Panel();
			this.label3 = new Label();
			this.panel7 = new Panel();
			this.panel4 = new Panel();
			this.panel3 = new Panel();
			this.mediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
			this.songsListView = new ListView();
			this.columnHeader1 = new ColumnHeader();
			this.columnHeader2 = new ColumnHeader();
			this.columnHeader3 = new ColumnHeader();
			this.columnHeader4 = new ColumnHeader();
			this.panel2 = new Panel();
			this.panel20 = new Panel();
			this.panel18 = new Panel();
			this.panel1 = new Panel();
			this.panel9 = new Panel();
			this.nextSongBtn = new Button();
			this.prevSongBtn = new Button();
			this.pauseButton = new Button();
			this.panel16 = new Panel();
			this.panel14 = new Panel();
			this.BPM_scrollbar = new VScrollBar();
			this.label4 = new Label();
			this.panel11 = new Panel();
			this.pictureBox1 = new PictureBox();
			this.panel8 = new Panel();
			this.panel12 = new Panel();
			this.panel17 = new Panel();
			this.label2 = new Label();
			this.BPM_textLbl = new Label();
			this.panel13 = new Panel();
			this.playingSongLbl = new TextBox();
			this.panel10 = new Panel();
			this.pictureBox2 = new PictureBox();
			this.panel6.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel15.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			(( System.ComponentModel.ISupportInitialize )this.mediaPlayer).BeginInit();
			this.panel2.SuspendLayout();
			this.panel20.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel9.SuspendLayout();
			this.panel16.SuspendLayout();
			this.panel14.SuspendLayout();
			this.panel11.SuspendLayout();
			(( System.ComponentModel.ISupportInitialize )this.pictureBox1).BeginInit();
			this.panel8.SuspendLayout();
			this.panel12.SuspendLayout();
			this.panel17.SuspendLayout();
			this.panel13.SuspendLayout();
			this.panel10.SuspendLayout();
			(( System.ComponentModel.ISupportInitialize )this.pictureBox2).BeginInit();
			this.SuspendLayout();
			// 
			// panel6
			// 
			this.panel6.BackColor = Color.MediumSlateBlue;
			this.panel6.Controls.Add( this.panel5 );
			this.panel6.Controls.Add( this.panel7 );
			this.panel6.ForeColor = SystemColors.ControlText;
			this.panel6.Location = new Point( 3, 3 );
			this.panel6.Name = "panel6";
			this.panel6.Size = new Size( 1139, 565 );
			this.panel6.TabIndex = 16;
			// 
			// panel5
			// 
			this.panel5.BackColor = Color.DarkSlateBlue;
			this.panel5.Controls.Add( this.panel15 );
			this.panel5.ForeColor = SystemColors.ControlText;
			this.panel5.Location = new Point( 3, 3 );
			this.panel5.Name = "panel5";
			this.panel5.Size = new Size( 1133, 56 );
			this.panel5.TabIndex = 33;
			// 
			// panel15
			// 
			this.panel15.BackColor = Color.MediumSlateBlue;
			this.panel15.Controls.Add( this.label3 );
			this.panel15.ForeColor = SystemColors.ControlText;
			this.panel15.Location = new Point( 3, 3 );
			this.panel15.Name = "panel15";
			this.panel15.Size = new Size( 1127, 51 );
			this.panel15.TabIndex = 0;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = Color.MediumSlateBlue;
			this.label3.FlatStyle = FlatStyle.Flat;
			this.label3.Font = new Font( "Lucida Bright", 22.2F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.label3.ForeColor = Color.Snow;
			this.label3.Location = new Point( 493, 4 );
			this.label3.Name = "label3";
			this.label3.Size = new Size( 142, 42 );
			this.label3.TabIndex = 22;
			this.label3.Text = "DJ hall";
			this.label3.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// panel7
			// 
			this.panel7.BackColor = Color.DarkSlateBlue;
			this.panel7.Controls.Add( this.panel4 );
			this.panel7.ForeColor = SystemColors.ControlText;
			this.panel7.Location = new Point( 3, 61 );
			this.panel7.Name = "panel7";
			this.panel7.Size = new Size( 1133, 499 );
			this.panel7.TabIndex = 16;
			// 
			// panel4
			// 
			this.panel4.BackColor = Color.MediumSlateBlue;
			this.panel4.Controls.Add( this.panel3 );
			this.panel4.Controls.Add( this.panel2 );
			this.panel4.Controls.Add( this.panel1 );
			this.panel4.ForeColor = SystemColors.ControlText;
			this.panel4.Location = new Point( 3, 3 );
			this.panel4.Name = "panel4";
			this.panel4.Size = new Size( 1127, 493 );
			this.panel4.TabIndex = 11;
			// 
			// panel3
			// 
			this.panel3.BackColor = Color.DarkSlateBlue;
			this.panel3.Controls.Add( this.mediaPlayer );
			this.panel3.Controls.Add( this.songsListView );
			this.panel3.ForeColor = SystemColors.ControlText;
			this.panel3.Location = new Point( 421, 3 );
			this.panel3.Name = "panel3";
			this.panel3.Size = new Size( 703, 344 );
			this.panel3.TabIndex = 1;
			// 
			// mediaPlayer
			// 
			this.mediaPlayer.Enabled = true;
			this.mediaPlayer.Location = new Point( 251, 157 );
			this.mediaPlayer.Margin = new Padding( 3, 4, 3, 4 );
			this.mediaPlayer.Name = "mediaPlayer";
			this.mediaPlayer.OcxState = ( AxHost.State )resources.GetObject( "mediaPlayer.OcxState" );
			this.mediaPlayer.Size = new Size( 172, 61 );
			this.mediaPlayer.TabIndex = 2;
			// 
			// songsListView
			// 
			this.songsListView.BackColor = Color.MediumSlateBlue;
			this.songsListView.BorderStyle = BorderStyle.None;
			this.songsListView.Columns.AddRange( new ColumnHeader[] { this.columnHeader1, this.columnHeader2, this.columnHeader3, this.columnHeader4 } );
			this.songsListView.Font = new Font( "Lucida Bright", 10.8F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.songsListView.ForeColor = Color.Snow;
			this.songsListView.GridLines = true;
			listViewGroup1.Header = "TItle";
			listViewGroup1.Name = "Title";
			listViewGroup2.Header = "Artist";
			listViewGroup2.Name = "Artist";
			listViewGroup3.Header = "Category";
			listViewGroup3.Name = "Category";
			this.songsListView.Groups.AddRange( new ListViewGroup[] { listViewGroup1, listViewGroup2, listViewGroup3 } );
			this.songsListView.Location = new Point( 5, 3 );
			this.songsListView.Name = "songsListView";
			this.songsListView.Size = new Size( 696, 339 );
			this.songsListView.TabIndex = 1;
			this.songsListView.UseCompatibleStateImageBehavior = false;
			this.songsListView.View = View.Details;
			this.songsListView.SelectedIndexChanged += this.songsListView_SelIndexChanged;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Title";
			this.columnHeader1.Width = 174;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Artist";
			this.columnHeader2.Width = 174;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Category";
			this.columnHeader3.Width = 174;
			// 
			// columnHeader4
			// 
			this.columnHeader4.Text = "Duration";
			this.columnHeader4.Width = 174;
			// 
			// panel2
			// 
			this.panel2.BackColor = Color.DarkSlateBlue;
			this.panel2.Controls.Add( this.panel20 );
			this.panel2.ForeColor = SystemColors.ControlText;
			this.panel2.Location = new Point( 421, 349 );
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size( 703, 139 );
			this.panel2.TabIndex = 1;
			// 
			// panel20
			// 
			this.panel20.BackColor = Color.MediumSlateBlue;
			this.panel20.Controls.Add( this.panel18 );
			this.panel20.ForeColor = SystemColors.ControlText;
			this.panel20.Location = new Point( 5, 3 );
			this.panel20.Name = "panel20";
			this.panel20.Size = new Size( 696, 132 );
			this.panel20.TabIndex = 17;
			// 
			// panel18
			// 
			this.panel18.BackColor = Color.DarkSlateBlue;
			this.panel18.ForeColor = SystemColors.ControlText;
			this.panel18.Location = new Point( 381, 5 );
			this.panel18.Name = "panel18";
			this.panel18.Size = new Size( 5, 120 );
			this.panel18.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.BackColor = Color.DarkSlateBlue;
			this.panel1.Controls.Add( this.panel9 );
			this.panel1.Controls.Add( this.panel8 );
			this.panel1.ForeColor = SystemColors.ControlText;
			this.panel1.Location = new Point( 3, 3 );
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size( 416, 485 );
			this.panel1.TabIndex = 0;
			// 
			// panel9
			// 
			this.panel9.BackColor = Color.MediumSlateBlue;
			this.panel9.Controls.Add( this.nextSongBtn );
			this.panel9.Controls.Add( this.prevSongBtn );
			this.panel9.Controls.Add( this.pauseButton );
			this.panel9.Controls.Add( this.panel16 );
			this.panel9.Controls.Add( this.panel11 );
			this.panel9.ForeColor = SystemColors.ControlText;
			this.panel9.Location = new Point( 3, 115 );
			this.panel9.Name = "panel9";
			this.panel9.Size = new Size( 410, 368 );
			this.panel9.TabIndex = 64;
			// 
			// nextSongBtn
			// 
			this.nextSongBtn.BackColor = Color.DarkSlateBlue;
			this.nextSongBtn.Font = new Font( "Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.nextSongBtn.ForeColor = Color.Snow;
			this.nextSongBtn.Location = new Point( 304, 293 );
			this.nextSongBtn.Name = "nextSongBtn";
			this.nextSongBtn.Padding = new Padding( 5, 0, 0, 1 );
			this.nextSongBtn.Size = new Size( 85, 60 );
			this.nextSongBtn.TabIndex = 74;
			this.nextSongBtn.Text = ">>";
			this.nextSongBtn.UseVisualStyleBackColor = false;
			this.nextSongBtn.Click += this.nextSongBtn_Click;
			// 
			// prevSongBtn
			// 
			this.prevSongBtn.BackColor = Color.DarkSlateBlue;
			this.prevSongBtn.Font = new Font( "Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.prevSongBtn.ForeColor = Color.Snow;
			this.prevSongBtn.Location = new Point( 22, 293 );
			this.prevSongBtn.Name = "prevSongBtn";
			this.prevSongBtn.Padding = new Padding( 1, 0, 0, 1 );
			this.prevSongBtn.Size = new Size( 85, 60 );
			this.prevSongBtn.TabIndex = 73;
			this.prevSongBtn.Text = "<<";
			this.prevSongBtn.UseVisualStyleBackColor = false;
			this.prevSongBtn.Click += this.prevSongBtn_Click;
			// 
			// pauseButton
			// 
			this.pauseButton.BackColor = Color.DarkSlateBlue;
			this.pauseButton.Font = new Font( "Lucida Bright", 16.2F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.pauseButton.ForeColor = Color.Snow;
			this.pauseButton.Location = new Point( 133, 293 );
			this.pauseButton.Name = "pauseButton";
			this.pauseButton.Padding = new Padding( 9, 0, 0, 3 );
			this.pauseButton.Size = new Size( 145, 60 );
			this.pauseButton.TabIndex = 72;
			this.pauseButton.Text = "|>";
			this.pauseButton.UseVisualStyleBackColor = false;
			this.pauseButton.Click += this.pauseButton_Click;
			// 
			// panel16
			// 
			this.panel16.BackColor = Color.DarkSlateBlue;
			this.panel16.Controls.Add( this.panel14 );
			this.panel16.ForeColor = SystemColors.ControlText;
			this.panel16.Location = new Point( 3, 3 );
			this.panel16.Name = "panel16";
			this.panel16.Size = new Size( 91, 279 );
			this.panel16.TabIndex = 71;
			// 
			// panel14
			// 
			this.panel14.BackColor = Color.MediumSlateBlue;
			this.panel14.Controls.Add( this.BPM_scrollbar );
			this.panel14.Controls.Add( this.label4 );
			this.panel14.ForeColor = SystemColors.ControlText;
			this.panel14.Location = new Point( 3, 3 );
			this.panel14.Name = "panel14";
			this.panel14.Size = new Size( 85, 273 );
			this.panel14.TabIndex = 69;
			// 
			// BPM_scrollbar
			// 
			this.BPM_scrollbar.Location = new Point( 22, 19 );
			this.BPM_scrollbar.Maximum = 220;
			this.BPM_scrollbar.Minimum = 80;
			this.BPM_scrollbar.Name = "BPM_scrollbar";
			this.BPM_scrollbar.Size = new Size( 41, 207 );
			this.BPM_scrollbar.TabIndex = 60;
			this.BPM_scrollbar.Value = 80;
			this.BPM_scrollbar.ValueChanged += this.BPM_scrollbar_ValueChanged;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = Color.MediumSlateBlue;
			this.label4.FlatStyle = FlatStyle.Flat;
			this.label4.Font = new Font( "Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.label4.ForeColor = Color.DarkSlateBlue;
			this.label4.Location = new Point( 16, 235 );
			this.label4.Name = "label4";
			this.label4.Size = new Size( 53, 23 );
			this.label4.TabIndex = 71;
			this.label4.Text = "BPM";
			this.label4.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// panel11
			// 
			this.panel11.BackColor = Color.DarkSlateBlue;
			this.panel11.Controls.Add( this.pictureBox1 );
			this.panel11.ForeColor = SystemColors.ControlText;
			this.panel11.Location = new Point( 95, 3 );
			this.panel11.Name = "panel11";
			this.panel11.Size = new Size( 312, 279 );
			this.panel11.TabIndex = 68;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = Color.MediumSlateBlue;
			this.pictureBox1.ForeColor = SystemColors.ControlText;
			this.pictureBox1.Image = Properties.Resources.ArtLogo;
			this.pictureBox1.Location = new Point( 3, 3 );
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new Size( 306, 273 );
			this.pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 67;
			this.pictureBox1.TabStop = false;
			// 
			// panel8
			// 
			this.panel8.BackColor = Color.MediumSlateBlue;
			this.panel8.Controls.Add( this.panel12 );
			this.panel8.Controls.Add( this.panel10 );
			this.panel8.ForeColor = SystemColors.ControlText;
			this.panel8.Location = new Point( 3, 3 );
			this.panel8.Name = "panel8";
			this.panel8.Size = new Size( 410, 108 );
			this.panel8.TabIndex = 63;
			// 
			// panel12
			// 
			this.panel12.BackColor = Color.DarkSlateBlue;
			this.panel12.Controls.Add( this.panel17 );
			this.panel12.Controls.Add( this.panel13 );
			this.panel12.ForeColor = SystemColors.ControlText;
			this.panel12.Location = new Point( 3, 3 );
			this.panel12.Name = "panel12";
			this.panel12.Size = new Size( 405, 59 );
			this.panel12.TabIndex = 17;
			// 
			// panel17
			// 
			this.panel17.BackColor = Color.MediumSlateBlue;
			this.panel17.Controls.Add( this.label2 );
			this.panel17.Controls.Add( this.BPM_textLbl );
			this.panel17.ForeColor = SystemColors.ControlText;
			this.panel17.Location = new Point( 304, 3 );
			this.panel17.Name = "panel17";
			this.panel17.Size = new Size( 97, 52 );
			this.panel17.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = Color.MediumSlateBlue;
			this.label2.FlatStyle = FlatStyle.Flat;
			this.label2.Font = new Font( "Lucida Bright", 9F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.label2.ForeColor = Color.Snow;
			this.label2.Location = new Point( 56, 21 );
			this.label2.Name = "label2";
			this.label2.Size = new Size( 38, 17 );
			this.label2.TabIndex = 72;
			this.label2.Text = "BPM";
			this.label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// BPM_textLbl
			// 
			this.BPM_textLbl.AutoSize = true;
			this.BPM_textLbl.BackColor = Color.MediumSlateBlue;
			this.BPM_textLbl.FlatStyle = FlatStyle.Flat;
			this.BPM_textLbl.Font = new Font( "Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.BPM_textLbl.ForeColor = Color.DarkSlateBlue;
			this.BPM_textLbl.Location = new Point( 5, 13 );
			this.BPM_textLbl.Name = "BPM_textLbl";
			this.BPM_textLbl.Size = new Size( 54, 26 );
			this.BPM_textLbl.TabIndex = 46;
			this.BPM_textLbl.Text = "120";
			this.BPM_textLbl.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// panel13
			// 
			this.panel13.BackColor = Color.MediumSlateBlue;
			this.panel13.Controls.Add( this.playingSongLbl );
			this.panel13.ForeColor = SystemColors.ControlText;
			this.panel13.Location = new Point( 3, 3 );
			this.panel13.Name = "panel13";
			this.panel13.Size = new Size( 299, 52 );
			this.panel13.TabIndex = 0;
			// 
			// playingSongLbl
			// 
			this.playingSongLbl.BackColor = Color.MediumSlateBlue;
			this.playingSongLbl.BorderStyle = BorderStyle.None;
			this.playingSongLbl.Font = new Font( "Lucida Bright", 10.8F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.playingSongLbl.ForeColor = Color.Snow;
			this.playingSongLbl.Location = new Point( 16, 16 );
			this.playingSongLbl.Name = "playingSongLbl";
			this.playingSongLbl.ReadOnly = true;
			this.playingSongLbl.Size = new Size( 270, 22 );
			this.playingSongLbl.TabIndex = 0;
			this.playingSongLbl.Text = "ArtistTitleCategory";
			// 
			// panel10
			// 
			this.panel10.BackColor = Color.DarkSlateBlue;
			this.panel10.Controls.Add( this.pictureBox2 );
			this.panel10.ForeColor = SystemColors.ControlText;
			this.panel10.Location = new Point( 3, 64 );
			this.panel10.Name = "panel10";
			this.panel10.Size = new Size( 405, 41 );
			this.panel10.TabIndex = 17;
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = Color.MediumSlateBlue;
			this.pictureBox2.ForeColor = SystemColors.ControlText;
			this.pictureBox2.Location = new Point( 3, 3 );
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new Size( 398, 35 );
			this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 17;
			this.pictureBox2.TabStop = false;
			// 
			// DJHall
			// 
			AutoScaleDimensions = new SizeF( 8F, 20F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSlateBlue;
			ClientSize = new Size( 1144, 571 );
			Controls.Add( this.panel6 );
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Margin = new Padding( 3, 4, 3, 4 );
			MaximizeBox = false;
			Name = "DJHall";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "";
			this.FormClosed += this.DigitalDJ_FormClosed;
			this.Shown += this.DigitalDJForm_Shown;
			this.panel6.ResumeLayout( false );
			this.panel5.ResumeLayout( false );
			this.panel15.ResumeLayout( false );
			this.panel15.PerformLayout();
			this.panel7.ResumeLayout( false );
			this.panel4.ResumeLayout( false );
			this.panel3.ResumeLayout( false );
			(( System.ComponentModel.ISupportInitialize )this.mediaPlayer).EndInit();
			this.panel2.ResumeLayout( false );
			this.panel20.ResumeLayout( false );
			this.panel1.ResumeLayout( false );
			this.panel9.ResumeLayout( false );
			this.panel16.ResumeLayout( false );
			this.panel14.ResumeLayout( false );
			this.panel14.PerformLayout();
			this.panel11.ResumeLayout( false );
			(( System.ComponentModel.ISupportInitialize )this.pictureBox1).EndInit();
			this.panel8.ResumeLayout( false );
			this.panel12.ResumeLayout( false );
			this.panel17.ResumeLayout( false );
			this.panel17.PerformLayout();
			this.panel13.ResumeLayout( false );
			this.panel13.PerformLayout();
			this.panel10.ResumeLayout( false );
			(( System.ComponentModel.ISupportInitialize )this.pictureBox2).EndInit();
			this.ResumeLayout( false );
		}

		#endregion
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
		private Button nextSongBtn;
		private Button prevSongBtn;
		private Button pauseButton;
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
		private TextBox playingSongLbl;
		private Panel panel18;
		private AxWMPLib.AxWindowsMediaPlayer mediaPlayer;
	}
}
