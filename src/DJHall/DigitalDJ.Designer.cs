namespace Ergasia3.src.DJHall
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
			this.colorDialog1 = new ColorDialog();
			this.panel5 = new Panel();
			this.panel4 = new Panel();
			this.panel6 = new Panel();
			this.panel7 = new Panel();
			this.panel1 = new Panel();
			this.panel2 = new Panel();
			this.panel3 = new Panel();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel5
			// 
			this.panel5.BackColor = Color.MediumSlateBlue;
			this.panel5.Location = new Point( 3, 3 );
			this.panel5.Name = "panel5";
			this.panel5.Size = new Size( 1148, 122 );
			this.panel5.TabIndex = 12;
			// 
			// panel4
			// 
			this.panel4.BackColor = Color.MediumSlateBlue;
			this.panel4.Location = new Point( 3, 131 );
			this.panel4.Name = "panel4";
			this.panel4.Size = new Size( 1148, 210 );
			this.panel4.TabIndex = 11;
			// 
			// panel6
			// 
			this.panel6.BackColor = Color.MediumSlateBlue;
			this.panel6.Controls.Add( this.panel1 );
			this.panel6.Controls.Add( this.panel7 );
			this.panel6.Location = new Point( 3, 3 );
			this.panel6.Name = "panel6";
			this.panel6.Size = new Size( 1160, 724 );
			this.panel6.TabIndex = 16;
			// 
			// panel7
			// 
			this.panel7.BackColor = Color.DarkSlateBlue;
			this.panel7.Controls.Add( this.panel4 );
			this.panel7.Controls.Add( this.panel5 );
			this.panel7.Location = new Point( 3, 3 );
			this.panel7.Name = "panel7";
			this.panel7.Size = new Size( 1154, 344 );
			this.panel7.TabIndex = 16;
			// 
			// panel1
			// 
			this.panel1.BackColor = Color.DarkSlateBlue;
			this.panel1.Controls.Add( this.panel3 );
			this.panel1.Controls.Add( this.panel2 );
			this.panel1.Location = new Point( 3, 353 );
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size( 1154, 368 );
			this.panel1.TabIndex = 17;
			// 
			// panel2
			// 
			this.panel2.BackColor = Color.MediumSlateBlue;
			this.panel2.Location = new Point( 3, 3 );
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size( 652, 362 );
			this.panel2.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.BackColor = Color.MediumSlateBlue;
			this.panel3.Location = new Point( 661, 3 );
			this.panel3.Name = "panel3";
			this.panel3.Size = new Size( 490, 362 );
			this.panel3.TabIndex = 1;
			// 
			// DigitalDJForm
			// 
			AutoScaleDimensions = new SizeF( 8F, 20F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSlateBlue;
			ClientSize = new Size( 1167, 729 );
			Controls.Add( this.panel6 );
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Margin = new Padding( 3, 4, 3, 4 );
			MaximizeBox = false;
			Name = "DigitalDJForm";
			StartPosition = FormStartPosition.CenterScreen;
			this.Shown += this.DigitalDJForm_Shown;
			this.panel6.ResumeLayout( false );
			this.panel7.ResumeLayout( false );
			this.panel1.ResumeLayout( false );
			this.ResumeLayout( false );
		}

		#endregion
		private ColorDialog colorDialog1;
		private Panel panel4;
		private Panel panel5;
		private Panel panel6;
		private Panel panel7;
		private Panel panel1;
		private Panel panel2;
		private Panel panel3;
	}
}
