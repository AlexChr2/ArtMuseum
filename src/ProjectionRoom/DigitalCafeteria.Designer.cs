namespace Ergasia3.src.ProjectionRoom
{
	partial class DigitalCafeteria
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
			this.label2 = new Label();
			this.panel2 = new Panel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = SystemColors.GradientActiveCaption;
			this.panel1.Controls.Add( this.panel2 );
			this.panel1.Location = new Point( 12, 12 );
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size( 793, 476 );
			this.panel1.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = SystemColors.Control;
			this.label2.Font = new Font( "Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.label2.Location = new Point( 16, 15 );
			this.label2.Name = "label2";
			this.label2.Size = new Size( 118, 28 );
			this.label2.TabIndex = 7;
			this.label2.Text = "FoodPicture";
			// 
			// panel2
			// 
			this.panel2.Controls.Add( this.label2 );
			this.panel2.Location = new Point( 311, 52 );
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size( 250, 125 );
			this.panel2.TabIndex = 8;
			// 
			// DigitalCafeteria
			// 
			AutoScaleDimensions = new SizeF( 8F, 20F );
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size( 817, 500 );
			Controls.Add( this.panel1 );
			Name = "DigitalCafeteria";
			Text = "DigitalCafeteria";
			this.panel1.ResumeLayout( false );
			this.panel2.ResumeLayout( false );
			this.panel2.PerformLayout();
			this.ResumeLayout( false );
		}

		#endregion

		private Panel panel1;
		private Panel panel2;
		private Label label2;
	}
}