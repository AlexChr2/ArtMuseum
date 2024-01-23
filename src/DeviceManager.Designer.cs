namespace Ergasia3.src
{
	partial class DeviceManager
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
			this.label2 = new Label();
			this.label3 = new Label();
			this.label4 = new Label();
			this.label5 = new Label();
			this.label6 = new Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = SystemColors.GradientActiveCaption;
			this.panel1.Controls.Add( this.label5 );
			this.panel1.Controls.Add( this.label6 );
			this.panel1.Controls.Add( this.label3 );
			this.panel1.Controls.Add( this.label4 );
			this.panel1.Controls.Add( this.label2 );
			this.panel1.Controls.Add( this.label1 );
			this.panel1.Location = new Point( 12, 12 );
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size( 512, 586 );
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = SystemColors.ButtonFace;
			this.label1.Font = new Font( "Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.label1.Location = new Point( 36, 40 );
			this.label1.Name = "label1";
			this.label1.Size = new Size( 26, 168 );
			this.label1.TabIndex = 0;
			this.label1.Text = "L\r\nI\r\nG\r\nH\r\nT\r\nS";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = SystemColors.ButtonFace;
			this.label2.Font = new Font( "Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.label2.Location = new Point( 108, 66 );
			this.label2.Name = "label2";
			this.label2.Size = new Size( 337, 112 );
			this.label2.TabIndex = 1;
			this.label2.Text = "Here we will probably place some\r\ngradient for the lights of the museum\r\nin order to create an aesthetic \r\natmosphere.";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = SystemColors.ButtonFace;
			this.label3.Font = new Font( "Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.label3.Location = new Point( 108, 280 );
			this.label3.Name = "label3";
			this.label3.Size = new Size( 364, 84 );
			this.label3.TabIndex = 3;
			this.label3.Text = "Here we will probably place a numerical\r\nbar, which will contain the vocal range of\r\nthe overall audio inside the museum.";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = SystemColors.ButtonFace;
			this.label4.Font = new Font( "Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.label4.Location = new Point( 36, 250 );
			this.label4.Name = "label4";
			this.label4.Size = new Size( 27, 140 );
			this.label4.TabIndex = 2;
			this.label4.Text = "A\r\nU\r\nD\r\nI\r\nO";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = SystemColors.ButtonFace;
			this.label5.Font = new Font( "Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.label5.Location = new Point( 108, 449 );
			this.label5.Name = "label5";
			this.label5.Size = new Size( 357, 84 );
			this.label5.TabIndex = 5;
			this.label5.Text = "Here we will probably place a numerical\r\nbar, which will contain the range of the\r\nheat temperature inside the museum.";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = SystemColors.ButtonFace;
			this.label6.Font = new Font( "Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.label6.Location = new Point( 36, 435 );
			this.label6.Name = "label6";
			this.label6.Size = new Size( 26, 112 );
			this.label6.TabIndex = 4;
			this.label6.Text = "H\r\nE\r\nA\r\nT";
			// 
			// DeviceManager
			// 
			AutoScaleDimensions = new SizeF( 8F, 20F );
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size( 536, 611 );
			Controls.Add( this.panel1 );
			Name = "DeviceManager";
			Text = "DeviceManager";
			this.panel1.ResumeLayout( false );
			this.panel1.PerformLayout();
			this.ResumeLayout( false );
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private Label label2;
		private Label label5;
		private Label label6;
		private Label label3;
		private Label label4;
	}
}