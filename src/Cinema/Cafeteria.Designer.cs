namespace Ergasia3.src.Cinema
{
	partial class Cafeteria
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
			this.label1 = new Label();
			this.panel2 = new Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = Color.MediumSlateBlue;
			this.panel1.Controls.Add( this.panel2 );
			this.panel1.Location = new Point( 5, 76 );
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size( 533, 583 );
			this.panel1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.FlatStyle = FlatStyle.Flat;
			this.label1.Font = new Font( "Lucida Bright", 22.2F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.label1.ForeColor = Color.SeaShell;
			this.label1.Location = new Point( 182, 9 );
			this.label1.Name = "label1";
			this.label1.Size = new Size( 184, 42 );
			this.label1.TabIndex = 45;
			this.label1.Text = "Cafeteria";
			this.label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// panel2
			// 
			this.panel2.Location = new Point( 7, 3 );
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size( 521, 362 );
			this.panel2.TabIndex = 0;
			// 
			// Cafeteria
			// 
			AutoScaleDimensions = new SizeF( 8F, 20F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSlateBlue;
			ClientSize = new Size( 541, 733 );
			Controls.Add( this.label1 );
			Controls.Add( this.panel1 );
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "Cafeteria";
			StartPosition = FormStartPosition.CenterScreen;
			this.panel1.ResumeLayout( false );
			this.ResumeLayout( false );
			this.PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private Panel panel2;
	}
}