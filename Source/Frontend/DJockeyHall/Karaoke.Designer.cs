namespace Ergasia3.Source.Frontend.DJockeyHall
{
	partial class Karaoke
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
			this.panel1 = new Panel();
			this.panel2 = new Panel();
			this.panel3 = new Panel();
			this.panel5 = new Panel();
			this.panel6 = new Panel();
			this.helpLbl = new LinkLabel();
			this.label2 = new Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = Color.MediumSlateBlue;
			this.panel1.Controls.Add( this.panel2 );
			this.panel1.Controls.Add( this.panel5 );
			this.panel1.ForeColor = SystemColors.ControlText;
			this.panel1.Location = new Point( 3, 2 );
			this.panel1.Margin = new Padding( 3, 2, 3, 2 );
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size( 529, 418 );
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = Color.DarkSlateBlue;
			this.panel2.Controls.Add( this.panel3 );
			this.panel2.ForeColor = SystemColors.ControlText;
			this.panel2.Location = new Point( 3, 46 );
			this.panel2.Margin = new Padding( 3, 2, 3, 2 );
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size( 524, 369 );
			this.panel2.TabIndex = 34;
			// 
			// panel3
			// 
			this.panel3.BackColor = Color.MediumSlateBlue;
			this.panel3.ForeColor = SystemColors.ControlText;
			this.panel3.Location = new Point( 3, 2 );
			this.panel3.Margin = new Padding( 3, 2, 3, 2 );
			this.panel3.Name = "panel3";
			this.panel3.Size = new Size( 519, 364 );
			this.panel3.TabIndex = 1;
			// 
			// panel5
			// 
			this.panel5.BackColor = Color.DarkSlateBlue;
			this.panel5.Controls.Add( this.panel6 );
			this.panel5.ForeColor = SystemColors.ControlText;
			this.panel5.Location = new Point( 3, 2 );
			this.panel5.Margin = new Padding( 3, 2, 3, 2 );
			this.panel5.Name = "panel5";
			this.panel5.Size = new Size( 524, 42 );
			this.panel5.TabIndex = 33;
			// 
			// panel6
			// 
			this.panel6.BackColor = Color.MediumSlateBlue;
			this.panel6.Controls.Add( this.helpLbl );
			this.panel6.Controls.Add( this.label2 );
			this.panel6.ForeColor = SystemColors.ControlText;
			this.panel6.Location = new Point( 3, 2 );
			this.panel6.Margin = new Padding( 3, 2, 3, 2 );
			this.panel6.Name = "panel6";
			this.panel6.Size = new Size( 519, 38 );
			this.panel6.TabIndex = 0;
			// 
			// helpLbl
			// 
			this.helpLbl.ActiveLinkColor = Color.Snow;
			this.helpLbl.AutoSize = true;
			this.helpLbl.BackColor = Color.MediumSlateBlue;
			this.helpLbl.Font = new Font( "Lucida Console", 16.2F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.helpLbl.ForeColor = SystemColors.ControlText;
			this.helpLbl.LinkColor = Color.DarkSlateBlue;
			this.helpLbl.Location = new Point( 8, 8 );
			this.helpLbl.Name = "helpLbl";
			this.helpLbl.Size = new Size( 24, 22 );
			this.helpLbl.TabIndex = 25;
			this.helpLbl.TabStop = true;
			this.helpLbl.Text = "?";
			this.helpLbl.VisitedLinkColor = Color.Snow;
			this.helpLbl.LinkClicked += this.helpLbl_LinkClicked;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = Color.MediumSlateBlue;
			this.label2.FlatStyle = FlatStyle.Flat;
			this.label2.Font = new Font( "Lucida Bright", 22.2F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.label2.ForeColor = Color.Snow;
			this.label2.Location = new Point( 190, 3 );
			this.label2.Name = "label2";
			this.label2.Size = new Size( 140, 34 );
			this.label2.TabIndex = 22;
			this.label2.Text = "Karaoke";
			this.label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// Karaoke
			// 
			this.AutoScaleDimensions = new SizeF( 7F, 15F );
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.DarkSlateBlue;
			this.ClientSize = new Size( 534, 422 );
			this.Controls.Add( this.panel1 );
			this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
			this.Name = "Karaoke";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.panel1.ResumeLayout( false );
			this.panel2.ResumeLayout( false );
			this.panel5.ResumeLayout( false );
			this.panel6.ResumeLayout( false );
			this.panel6.PerformLayout();
			this.ResumeLayout( false );
		}

		#endregion

		private Panel panel1;
		private Panel panel5;
		private Panel panel6;
		private Label label2;
		private Panel panel2;
		private Panel panel3;
		private LinkLabel helpLbl;
	}
}