namespace Ergasia3.src.ExhibitionHall
{
	partial class ExhibitionHall
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
			this.InformationPanel = new Panel();
			this.label2 = new Label();
			this.panel1 = new Panel();
			this.label4 = new Label();
			this.button1 = new Button();
			this.AttractionPanel.SuspendLayout();
			this.InformationPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// AttractionPanel
			// 
			this.AttractionPanel.BackColor = SystemColors.GradientInactiveCaption;
			this.AttractionPanel.Controls.Add( this.panel1 );
			this.AttractionPanel.Controls.Add( this.InformationPanel );
			this.AttractionPanel.Location = new Point( 12, 12 );
			this.AttractionPanel.Name = "AttractionPanel";
			this.AttractionPanel.Size = new Size( 822, 498 );
			this.AttractionPanel.TabIndex = 0;
			// 
			// InformationPanel
			// 
			this.InformationPanel.BackColor = SystemColors.ControlDark;
			this.InformationPanel.Controls.Add( this.label2 );
			this.InformationPanel.Location = new Point( 422, 3 );
			this.InformationPanel.Name = "InformationPanel";
			this.InformationPanel.Size = new Size( 397, 492 );
			this.InformationPanel.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = SystemColors.Control;
			this.label2.Font = new Font( "Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.label2.Location = new Point( 24, 184 );
			this.label2.Name = "label2";
			this.label2.Size = new Size( 348, 112 );
			this.label2.TabIndex = 1;
			this.label2.Text = "Here we might place some regular\r\ninformation about the overall integrity\r\nof the corresponding image at the\r\nleft panel.";
			// 
			// panel1
			// 
			this.panel1.BackColor = SystemColors.GradientActiveCaption;
			this.panel1.Controls.Add( this.label4 );
			this.panel1.Location = new Point( 3, 3 );
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size( 413, 492 );
			this.panel1.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = SystemColors.Control;
			this.label4.Font = new Font( "Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.label4.Location = new Point( 33, 196 );
			this.label4.Name = "label4";
			this.label4.Size = new Size( 329, 84 );
			this.label4.TabIndex = 0;
			this.label4.Text = "Here we might place some photo of \r\nsomething really important for the\r\nmuseum";
			// 
			// button1
			// 
			this.button1.BackColor = SystemColors.MenuHighlight;
			this.button1.Location = new Point( 840, 183 );
			this.button1.Name = "button1";
			this.button1.Size = new Size( 33, 141 );
			this.button1.TabIndex = 1;
			this.button1.Text = "Next";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// ExhibitionHall
			// 
			AutoScaleDimensions = new SizeF( 8F, 20F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.Menu;
			ClientSize = new Size( 885, 522 );
			Controls.Add( this.button1 );
			Controls.Add( this.AttractionPanel );
			Name = "ExhibitionHall";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ExhibitionHall";
			this.AttractionPanel.ResumeLayout( false );
			this.InformationPanel.ResumeLayout( false );
			this.InformationPanel.PerformLayout();
			this.panel1.ResumeLayout( false );
			this.panel1.PerformLayout();
			this.ResumeLayout( false );
		}

		#endregion

		private Panel AttractionPanel;
		private Panel InformationPanel;
		private Label label2;
		private Panel panel1;
		private Label label4;
		private Button button1;
	}
}