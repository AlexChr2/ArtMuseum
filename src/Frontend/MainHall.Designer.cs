namespace Ergasia3.src.Frontend
{
	partial class MainHall
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
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = Color.MediumSlateBlue;
			this.panel1.Location = new Point( 4, 4 );
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size( 523, 536 );
			this.panel1.TabIndex = 0;
			// 
			// MainHall
			// 
			AutoScaleDimensions = new SizeF( 8F, 20F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSlateBlue;
			ClientSize = new Size( 530, 544 );
			Controls.Add( this.panel1 );
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "MainHall";
			StartPosition = FormStartPosition.CenterScreen;
			this.ResumeLayout( false );
		}

		#endregion

		private Panel panel1;
	}
}