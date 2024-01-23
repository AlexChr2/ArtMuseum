namespace Ergasia3
{
	partial class DigitalDJForm
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
			this.playsongLabel = new Label();
			this.playsongCombobox = new ComboBox();
			this.changeBPMLabel = new Label();
			this.BPMscrollbar = new HScrollBar();
			this.songplaysequenceLabel = new Label();
			this.songplaysequenceListbox = new ListBox();
			this.songcategoryLabel = new Label();
			this.songcategoryCombobox = new ComboBox();
			this.colorDialog1 = new ColorDialog();
			this.colorButton = new Button();
			this.configurationbackupButton = new Button();
			this.audiencesongrequestsButton = new Button();
			this.partytimeButton = new Button();
			this.specialfxButton = new Button();
			this.SuspendLayout();
			// 
			// playsongLabel
			// 
			this.playsongLabel.AutoSize = true;
			this.playsongLabel.Font = new Font( "Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.playsongLabel.Location = new Point( 14, 31 );
			this.playsongLabel.Name = "playsongLabel";
			this.playsongLabel.Size = new Size( 121, 32 );
			this.playsongLabel.TabIndex = 0;
			this.playsongLabel.Text = "Play song:";
			// 
			// playsongCombobox
			// 
			this.playsongCombobox.Font = new Font( "Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.playsongCombobox.FormattingEnabled = true;
			this.playsongCombobox.Items.AddRange( new object[] { "Song1", "Song2", "Song3", "Song4", "Song5" } );
			this.playsongCombobox.Location = new Point( 148, 31 );
			this.playsongCombobox.Margin = new Padding( 3, 4, 3, 4 );
			this.playsongCombobox.Name = "playsongCombobox";
			this.playsongCombobox.Size = new Size( 189, 40 );
			this.playsongCombobox.TabIndex = 1;
			// 
			// changeBPMLabel
			// 
			this.changeBPMLabel.AutoSize = true;
			this.changeBPMLabel.Font = new Font( "Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.changeBPMLabel.Location = new Point( 14, 105 );
			this.changeBPMLabel.Name = "changeBPMLabel";
			this.changeBPMLabel.Size = new Size( 157, 32 );
			this.changeBPMLabel.TabIndex = 2;
			this.changeBPMLabel.Text = "Change BPM:";
			// 
			// BPMscrollbar
			// 
			this.BPMscrollbar.Location = new Point( 160, 109 );
			this.BPMscrollbar.Name = "BPMscrollbar";
			this.BPMscrollbar.Size = new Size( 177, 22 );
			this.BPMscrollbar.TabIndex = 3;
			// 
			// songplaysequenceLabel
			// 
			this.songplaysequenceLabel.AutoSize = true;
			this.songplaysequenceLabel.Font = new Font( "Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.songplaysequenceLabel.Location = new Point( 14, 177 );
			this.songplaysequenceLabel.Name = "songplaysequenceLabel";
			this.songplaysequenceLabel.Size = new Size( 234, 32 );
			this.songplaysequenceLabel.TabIndex = 4;
			this.songplaysequenceLabel.Text = "Song play sequence:";
			// 
			// songplaysequenceListbox
			// 
			this.songplaysequenceListbox.FormattingEnabled = true;
			this.songplaysequenceListbox.Items.AddRange( new object[] { "Song5", "Song3", "Song2", "Song1", "Song8" } );
			this.songplaysequenceListbox.Location = new Point( 231, 177 );
			this.songplaysequenceListbox.Margin = new Padding( 3, 4, 3, 4 );
			this.songplaysequenceListbox.Name = "songplaysequenceListbox";
			this.songplaysequenceListbox.Size = new Size( 137, 124 );
			this.songplaysequenceListbox.TabIndex = 6;
			// 
			// songcategoryLabel
			// 
			this.songcategoryLabel.AutoSize = true;
			this.songcategoryLabel.Font = new Font( "Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.songcategoryLabel.Location = new Point( 14, 324 );
			this.songcategoryLabel.Name = "songcategoryLabel";
			this.songcategoryLabel.Size = new Size( 173, 32 );
			this.songcategoryLabel.TabIndex = 7;
			this.songcategoryLabel.Text = "Song category:";
			// 
			// songcategoryCombobox
			// 
			this.songcategoryCombobox.Font = new Font( "Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.songcategoryCombobox.FormattingEnabled = true;
			this.songcategoryCombobox.Items.AddRange( new object[] { "Category1", "Category2", "Category3" } );
			this.songcategoryCombobox.Location = new Point( 177, 324 );
			this.songcategoryCombobox.Margin = new Padding( 3, 4, 3, 4 );
			this.songcategoryCombobox.Name = "songcategoryCombobox";
			this.songcategoryCombobox.Size = new Size( 189, 40 );
			this.songcategoryCombobox.TabIndex = 8;
			// 
			// colorButton
			// 
			this.colorButton.Font = new Font( "Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.colorButton.Location = new Point( 416, 304 );
			this.colorButton.Margin = new Padding( 3, 4, 3, 4 );
			this.colorButton.Name = "colorButton";
			this.colorButton.Size = new Size( 89, 84 );
			this.colorButton.TabIndex = 9;
			this.colorButton.Text = "Choose a color";
			this.colorButton.UseVisualStyleBackColor = true;
			this.colorButton.Click += this.colorButton_Click;
			// 
			// configurationbackupButton
			// 
			this.configurationbackupButton.Font = new Font( "Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.configurationbackupButton.Location = new Point( 9, 395 );
			this.configurationbackupButton.Margin = new Padding( 3, 4, 3, 4 );
			this.configurationbackupButton.Name = "configurationbackupButton";
			this.configurationbackupButton.Size = new Size( 189, 69 );
			this.configurationbackupButton.TabIndex = 10;
			this.configurationbackupButton.Text = "Create configuration backup";
			this.configurationbackupButton.UseVisualStyleBackColor = true;
			this.configurationbackupButton.Click += this.configurationbackupButton_Click;
			// 
			// audiencesongrequestsButton
			// 
			this.audiencesongrequestsButton.Font = new Font( "Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.audiencesongrequestsButton.Location = new Point( 205, 395 );
			this.audiencesongrequestsButton.Margin = new Padding( 3, 4, 3, 4 );
			this.audiencesongrequestsButton.Name = "audiencesongrequestsButton";
			this.audiencesongrequestsButton.Size = new Size( 151, 69 );
			this.audiencesongrequestsButton.TabIndex = 11;
			this.audiencesongrequestsButton.Text = "Audience song requests";
			this.audiencesongrequestsButton.UseVisualStyleBackColor = true;
			this.audiencesongrequestsButton.Click += this.audiencesongrequestsButton_Click;
			// 
			// partytimeButton
			// 
			this.partytimeButton.Font = new Font( "Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.partytimeButton.Location = new Point( 362, 407 );
			this.partytimeButton.Margin = new Padding( 3, 4, 3, 4 );
			this.partytimeButton.Name = "partytimeButton";
			this.partytimeButton.Size = new Size( 111, 45 );
			this.partytimeButton.TabIndex = 12;
			this.partytimeButton.Text = "Party Time!";
			this.partytimeButton.UseVisualStyleBackColor = true;
			this.partytimeButton.Click += this.partytimeButton_Click;
			// 
			// specialfxButton
			// 
			this.specialfxButton.Font = new Font( "Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.specialfxButton.Location = new Point( 480, 407 );
			this.specialfxButton.Margin = new Padding( 3, 4, 3, 4 );
			this.specialfxButton.Name = "specialfxButton";
			this.specialfxButton.Size = new Size( 111, 45 );
			this.specialfxButton.TabIndex = 13;
			this.specialfxButton.Text = "Special FX";
			this.specialfxButton.UseVisualStyleBackColor = true;
			this.specialfxButton.Click += this.specialfxButton_Click;
			// 
			// DigitalDJForm
			// 
			AutoScaleDimensions = new SizeF( 8F, 20F );
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size( 761, 621 );
			Controls.Add( this.specialfxButton );
			Controls.Add( this.partytimeButton );
			Controls.Add( this.audiencesongrequestsButton );
			Controls.Add( this.configurationbackupButton );
			Controls.Add( this.colorButton );
			Controls.Add( this.songcategoryCombobox );
			Controls.Add( this.songcategoryLabel );
			Controls.Add( this.songplaysequenceListbox );
			Controls.Add( this.songplaysequenceLabel );
			Controls.Add( this.BPMscrollbar );
			Controls.Add( this.changeBPMLabel );
			Controls.Add( this.playsongCombobox );
			Controls.Add( this.playsongLabel );
			Margin = new Padding( 3, 4, 3, 4 );
			MaximizeBox = false;
			Name = "DigitalDJForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Digital DJ";
			this.Shown += this.DigitalDJForm_Shown;
			this.ResumeLayout( false );
			this.PerformLayout();
		}

		#endregion

		private Label playsongLabel;
		private ComboBox playsongCombobox;
		private Label changeBPMLabel;
		private HScrollBar BPMscrollbar;
		private Label songplaysequenceLabel;
		private ListBox songplaysequenceListbox;
		private Label songcategoryLabel;
		private ComboBox songcategoryCombobox;
		private ColorDialog colorDialog1;
		private Button colorButton;
		private Button configurationbackupButton;
		private Button audiencesongrequestsButton;
		private Button partytimeButton;
		private Button specialfxButton;
	}
}
