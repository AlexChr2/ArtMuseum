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
			playsongLabel = new Label();
			playsongCombobox = new ComboBox();
			changeBPMLabel = new Label();
			BPMscrollbar = new HScrollBar();
			songplaysequenceLabel = new Label();
			songplaysequenceListbox = new ListBox();
			songcategoryLabel = new Label();
			songcategoryCombobox = new ComboBox();
			colorDialog1 = new ColorDialog();
			colorButton = new Button();
			configurationbackupButton = new Button();
			audiencesongrequestsButton = new Button();
			partytimeButton = new Button();
			specialfxButton = new Button();
			SuspendLayout();
			// 
			// playsongLabel
			// 
			playsongLabel.AutoSize = true;
			playsongLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			playsongLabel.Location = new Point(12, 23);
			playsongLabel.Name = "playsongLabel";
			playsongLabel.Size = new Size(97, 25);
			playsongLabel.TabIndex = 0;
			playsongLabel.Text = "Play song:";
			// 
			// playsongCombobox
			// 
			playsongCombobox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			playsongCombobox.FormattingEnabled = true;
			playsongCombobox.Items.AddRange(new object[] { "Song1", "Song2", "Song3", "Song4", "Song5" });
			playsongCombobox.Location = new Point(115, 23);
			playsongCombobox.Name = "playsongCombobox";
			playsongCombobox.Size = new Size(166, 33);
			playsongCombobox.TabIndex = 1;
			// 
			// changeBPMLabel
			// 
			changeBPMLabel.AutoSize = true;
			changeBPMLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			changeBPMLabel.Location = new Point(12, 79);
			changeBPMLabel.Name = "changeBPMLabel";
			changeBPMLabel.Size = new Size(125, 25);
			changeBPMLabel.TabIndex = 2;
			changeBPMLabel.Text = "Change BPM:";
			// 
			// BPMscrollbar
			// 
			BPMscrollbar.Location = new Point(140, 82);
			BPMscrollbar.Name = "BPMscrollbar";
			BPMscrollbar.Size = new Size(155, 22);
			BPMscrollbar.TabIndex = 3;
			// 
			// songplaysequenceLabel
			// 
			songplaysequenceLabel.AutoSize = true;
			songplaysequenceLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			songplaysequenceLabel.Location = new Point(12, 133);
			songplaysequenceLabel.Name = "songplaysequenceLabel";
			songplaysequenceLabel.Size = new Size(184, 25);
			songplaysequenceLabel.TabIndex = 4;
			songplaysequenceLabel.Text = "Song play sequence:";
			// 
			// songplaysequenceListbox
			// 
			songplaysequenceListbox.FormattingEnabled = true;
			songplaysequenceListbox.ItemHeight = 15;
			songplaysequenceListbox.Items.AddRange(new object[] { "Song5", "Song3", "Song2", "Song1", "Song8" });
			songplaysequenceListbox.Location = new Point(202, 133);
			songplaysequenceListbox.Name = "songplaysequenceListbox";
			songplaysequenceListbox.Size = new Size(120, 94);
			songplaysequenceListbox.TabIndex = 6;
			// 
			// songcategoryLabel
			// 
			songcategoryLabel.AutoSize = true;
			songcategoryLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			songcategoryLabel.Location = new Point(12, 243);
			songcategoryLabel.Name = "songcategoryLabel";
			songcategoryLabel.Size = new Size(137, 25);
			songcategoryLabel.TabIndex = 7;
			songcategoryLabel.Text = "Song category:";
			// 
			// songcategoryCombobox
			// 
			songcategoryCombobox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			songcategoryCombobox.FormattingEnabled = true;
			songcategoryCombobox.Items.AddRange(new object[] { "Category1", "Category2", "Category3" });
			songcategoryCombobox.Location = new Point(155, 243);
			songcategoryCombobox.Name = "songcategoryCombobox";
			songcategoryCombobox.Size = new Size(166, 33);
			songcategoryCombobox.TabIndex = 8;
			// 
			// colorButton
			// 
			colorButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			colorButton.Location = new Point(364, 228);
			colorButton.Name = "colorButton";
			colorButton.Size = new Size(78, 63);
			colorButton.TabIndex = 9;
			colorButton.Text = "Choose a color";
			colorButton.UseVisualStyleBackColor = true;
			colorButton.Click += colorButton_Click;
			// 
			// configurationbackupButton
			// 
			configurationbackupButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			configurationbackupButton.Location = new Point(8, 296);
			configurationbackupButton.Name = "configurationbackupButton";
			configurationbackupButton.Size = new Size(165, 52);
			configurationbackupButton.TabIndex = 10;
			configurationbackupButton.Text = "Create configuration backup";
			configurationbackupButton.UseVisualStyleBackColor = true;
			configurationbackupButton.Click += configurationbackupButton_Click;
			// 
			// audiencesongrequestsButton
			// 
			audiencesongrequestsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			audiencesongrequestsButton.Location = new Point(179, 296);
			audiencesongrequestsButton.Name = "audiencesongrequestsButton";
			audiencesongrequestsButton.Size = new Size(132, 52);
			audiencesongrequestsButton.TabIndex = 11;
			audiencesongrequestsButton.Text = "Audience song requests";
			audiencesongrequestsButton.UseVisualStyleBackColor = true;
			audiencesongrequestsButton.Click += audiencesongrequestsButton_Click;
			// 
			// partytimeButton
			// 
			partytimeButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			partytimeButton.Location = new Point(317, 305);
			partytimeButton.Name = "partytimeButton";
			partytimeButton.Size = new Size(97, 34);
			partytimeButton.TabIndex = 12;
			partytimeButton.Text = "Party Time!";
			partytimeButton.UseVisualStyleBackColor = true;
			partytimeButton.Click += partytimeButton_Click;
			// 
			// specialfxButton
			// 
			specialfxButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
			specialfxButton.Location = new Point(420, 305);
			specialfxButton.Name = "specialfxButton";
			specialfxButton.Size = new Size(97, 34);
			specialfxButton.TabIndex = 13;
			specialfxButton.Text = "Special FX";
			specialfxButton.UseVisualStyleBackColor = true;
			specialfxButton.Click += specialfxButton_Click;
			// 
			// DigitalDJForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(526, 370);
			Controls.Add(specialfxButton);
			Controls.Add(partytimeButton);
			Controls.Add(audiencesongrequestsButton);
			Controls.Add(configurationbackupButton);
			Controls.Add(colorButton);
			Controls.Add(songcategoryCombobox);
			Controls.Add(songcategoryLabel);
			Controls.Add(songplaysequenceListbox);
			Controls.Add(songplaysequenceLabel);
			Controls.Add(BPMscrollbar);
			Controls.Add(changeBPMLabel);
			Controls.Add(playsongCombobox);
			Controls.Add(playsongLabel);
			MaximizeBox = false;
			Name = "DigitalDJForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Digital DJ";
			Shown += DigitalDJForm_Shown;
			ResumeLayout(false);
			PerformLayout();
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
