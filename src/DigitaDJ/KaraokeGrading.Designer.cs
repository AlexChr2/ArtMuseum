namespace Ergasia3.src
{
	partial class KaraokeGrading
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			infoLabel = new Label();
			gradeScrollBar = new HScrollBar();
			okButton = new Button();
			scrollbarIndicator = new Label();
			SuspendLayout();
			// 
			// infoLabel
			// 
			infoLabel.AutoSize = true;
			infoLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			infoLabel.Location = new Point(12, 19);
			infoLabel.Name = "infoLabel";
			infoLabel.Size = new Size(197, 50);
			infoLabel.TabIndex = 0;
			infoLabel.Text = "Please give a grade to\r\nthe performance:";
			// 
			// gradeScrollBar
			// 
			gradeScrollBar.LargeChange = 1;
			gradeScrollBar.Location = new Point(223, 37);
			gradeScrollBar.Maximum = 10;
			gradeScrollBar.Minimum = 1;
			gradeScrollBar.Name = "gradeScrollBar";
			gradeScrollBar.Size = new Size(179, 20);
			gradeScrollBar.TabIndex = 1;
			gradeScrollBar.Value = 1;
			gradeScrollBar.ValueChanged += gradeScrollBar_ValueChanged;
			// 
			// okButton
			// 
			okButton.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			okButton.Location = new Point(288, 77);
			okButton.Name = "okButton";
			okButton.Size = new Size(55, 33);
			okButton.TabIndex = 2;
			okButton.Text = "OK";
			okButton.UseVisualStyleBackColor = true;
			okButton.Click += okButton_Click;
			// 
			// scrollbarIndicator
			// 
			scrollbarIndicator.AutoSize = true;
			scrollbarIndicator.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
			scrollbarIndicator.Location = new Point(303, 9);
			scrollbarIndicator.Name = "scrollbarIndicator";
			scrollbarIndicator.Size = new Size(23, 25);
			scrollbarIndicator.TabIndex = 3;
			scrollbarIndicator.Text = "3";
			// 
			// KaraokeGrading
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(479, 122);
			Controls.Add(scrollbarIndicator);
			Controls.Add(okButton);
			Controls.Add(gradeScrollBar);
			Controls.Add(infoLabel);
			Name = "KaraokeGrading";
			Text = "Karaoke Grading";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label infoLabel;
		private HScrollBar gradeScrollBar;
		private Button okButton;
		private Label scrollbarIndicator;
	}
}