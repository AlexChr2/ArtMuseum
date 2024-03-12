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
			this.label2 = new Label();
			this.SignUpLbl = new LinkLabel();
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
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size( 605, 557 );
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = Color.DarkSlateBlue;
			this.panel2.Controls.Add( this.panel3 );
			this.panel2.ForeColor = SystemColors.ControlText;
			this.panel2.Location = new Point( 3, 62 );
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size( 599, 492 );
			this.panel2.TabIndex = 34;
			// 
			// panel3
			// 
			this.panel3.BackColor = Color.MediumSlateBlue;
			this.panel3.ForeColor = SystemColors.ControlText;
			this.panel3.Location = new Point( 3, 3 );
			this.panel3.Name = "panel3";
			this.panel3.Size = new Size( 593, 486 );
			this.panel3.TabIndex = 1;
			// 
			// panel5
			// 
			this.panel5.BackColor = Color.DarkSlateBlue;
			this.panel5.Controls.Add( this.panel6 );
			this.panel5.ForeColor = SystemColors.ControlText;
			this.panel5.Location = new Point( 3, 3 );
			this.panel5.Name = "panel5";
			this.panel5.Size = new Size( 599, 56 );
			this.panel5.TabIndex = 33;
			// 
			// panel6
			// 
			this.panel6.BackColor = Color.MediumSlateBlue;
			this.panel6.Controls.Add( this.SignUpLbl );
			this.panel6.Controls.Add( this.label2 );
			this.panel6.ForeColor = SystemColors.ControlText;
			this.panel6.Location = new Point( 3, 3 );
			this.panel6.Name = "panel6";
			this.panel6.Size = new Size( 593, 50 );
			this.panel6.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = Color.MediumSlateBlue;
			this.label2.FlatStyle = FlatStyle.Flat;
			this.label2.Font = new Font( "Lucida Bright", 22.2F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.label2.ForeColor = Color.Snow;
			this.label2.Location = new Point( 217, 4 );
			this.label2.Name = "label2";
			this.label2.Size = new Size( 173, 42 );
			this.label2.TabIndex = 22;
			this.label2.Text = "Karaoke";
			this.label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// SignUpLbl
			// 
			this.SignUpLbl.ActiveLinkColor = Color.Snow;
			this.SignUpLbl.AutoSize = true;
			this.SignUpLbl.BackColor = Color.MediumSlateBlue;
			this.SignUpLbl.Font = new Font( "Lucida Console", 16.2F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.SignUpLbl.ForeColor = SystemColors.ControlText;
			this.SignUpLbl.LinkColor = Color.DarkSlateBlue;
			this.SignUpLbl.Location = new Point( 9, 11 );
			this.SignUpLbl.Name = "SignUpLbl";
			this.SignUpLbl.Size = new Size( 30, 28 );
			this.SignUpLbl.TabIndex = 25;
			this.SignUpLbl.TabStop = true;
			this.SignUpLbl.Text = "?";
			this.SignUpLbl.VisitedLinkColor = Color.Snow;
			// 
			// Karaoke
			// 
			this.AutoScaleDimensions = new SizeF( 8F, 20F );
			this.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.DarkSlateBlue;
			this.ClientSize = new Size( 610, 562 );
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
		private LinkLabel SignUpLbl;
	}
}