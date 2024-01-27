namespace Ergasia3.src.Frontend.CinemaHall
{
	partial class ProjectionHall
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
			this.panel3 = new Panel();
			this.button1 = new Button();
			this.button2 = new Button();
			this.button4 = new Button();
			this.panel2 = new Panel();
			this.label2 = new Label();
			this.label1 = new Label();
			this.panel1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = Color.DarkSlateBlue;
			this.panel1.Controls.Add( this.panel3 );
			this.panel1.Controls.Add( this.panel2 );
			this.panel1.Location = new Point( 5, 66 );
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size( 865, 505 );
			this.panel1.TabIndex = 1;
			// 
			// panel3
			// 
			this.panel3.BackColor = Color.MediumSlateBlue;
			this.panel3.Controls.Add( this.button1 );
			this.panel3.Controls.Add( this.button2 );
			this.panel3.Controls.Add( this.button4 );
			this.panel3.Location = new Point( 3, 385 );
			this.panel3.Name = "panel3";
			this.panel3.Size = new Size( 859, 117 );
			this.panel3.TabIndex = 45;
			// 
			// button1
			// 
			this.button1.BackColor = Color.DarkSlateBlue;
			this.button1.Font = new Font( "Lucida Bright", 16.2F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.button1.ForeColor = Color.Snow;
			this.button1.Location = new Point( 645, 24 );
			this.button1.Name = "button1";
			this.button1.Size = new Size( 136, 67 );
			this.button1.TabIndex = 49;
			this.button1.Text = ">>";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = Color.DarkSlateBlue;
			this.button2.Font = new Font( "Lucida Bright", 16.2F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.button2.ForeColor = Color.Snow;
			this.button2.Location = new Point( 82, 24 );
			this.button2.Name = "button2";
			this.button2.Size = new Size( 136, 67 );
			this.button2.TabIndex = 48;
			this.button2.Text = "<<";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button4
			// 
			this.button4.BackColor = Color.DarkSlateBlue;
			this.button4.Font = new Font( "Lucida Calligraphy", 13.8F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.button4.ForeColor = Color.Snow;
			this.button4.Location = new Point( 349, 24 );
			this.button4.Name = "button4";
			this.button4.Size = new Size( 180, 67 );
			this.button4.TabIndex = 46;
			this.button4.Text = "Play";
			this.button4.UseVisualStyleBackColor = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = Color.MediumSlateBlue;
			this.panel2.Controls.Add( this.label2 );
			this.panel2.Location = new Point( 3, 3 );
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size( 859, 376 );
			this.panel2.TabIndex = 46;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.FlatStyle = FlatStyle.Flat;
			this.label2.Font = new Font( "Lucida Bright", 16.2F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.label2.ForeColor = Color.SeaShell;
			this.label2.Location = new Point( 220, 161 );
			this.label2.Name = "label2";
			this.label2.Size = new Size( 422, 62 );
			this.label2.TabIndex = 45;
			this.label2.Text = "Dynamic projection of some\r\nartistic video of the museum.";
			this.label2.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.FlatStyle = FlatStyle.Flat;
			this.label1.Font = new Font( "Lucida Bright", 22.2F, FontStyle.Bold, GraphicsUnit.Point,   0 );
			this.label1.ForeColor = Color.SeaShell;
			this.label1.Location = new Point( 300, 9 );
			this.label1.Name = "label1";
			this.label1.Size = new Size( 284, 42 );
			this.label1.TabIndex = 44;
			this.label1.Text = "Projection hall";
			this.label1.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// ProjectionHall
			// 
			AutoScaleDimensions = new SizeF( 8F, 20F );
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DarkSlateBlue;
			ClientSize = new Size( 875, 576 );
			Controls.Add( this.label1 );
			Controls.Add( this.panel1 );
			FormBorderStyle = FormBorderStyle.FixedToolWindow;
			Name = "ProjectionHall";
			StartPosition = FormStartPosition.CenterScreen;
			this.panel1.ResumeLayout( false );
			this.panel3.ResumeLayout( false );
			this.panel2.ResumeLayout( false );
			this.panel2.PerformLayout();
			this.ResumeLayout( false );
			this.PerformLayout();
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private Label label2;
		private Panel panel2;
		private Panel panel3;
		private Button button1;
		private Button button2;
		private Button button4;
	}
}