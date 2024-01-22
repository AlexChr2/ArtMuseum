namespace Ergasia3.src
{
	partial class ConcertBooking
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
			this.label4 = new Label();
			this.label1 = new Label();
			this.label2 = new Label();
			this.label7 = new Label();
			this.button1 = new Button();
			this.panel2 = new Panel();
			this.panel3 = new Panel();
			this.label11 = new Label();
			this.label12 = new Label();
			this.label13 = new Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = SystemColors.GradientActiveCaption;
			this.panel1.Controls.Add( this.panel3 );
			this.panel1.Controls.Add( this.panel2 );
			this.panel1.Controls.Add( this.button1 );
			this.panel1.Controls.Add( this.label7 );
			this.panel1.Location = new Point( 12, 12 );
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size( 464, 701 );
			this.panel1.TabIndex = 0;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = SystemColors.Control;
			this.label4.Font = new Font( "Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.label4.Location = new Point( 63, 39 );
			this.label4.Name = "label4";
			this.label4.Size = new Size( 106, 28 );
			this.label4.TabIndex = 1;
			this.label4.Text = "NameField";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = SystemColors.Control;
			this.label1.Font = new Font( "Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.label1.Location = new Point( 63, 94 );
			this.label1.Name = "label1";
			this.label1.Size = new Size( 101, 28 );
			this.label1.TabIndex = 2;
			this.label1.Text = "EmailField";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = SystemColors.Control;
			this.label2.Font = new Font( "Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.label2.Location = new Point( 63, 147 );
			this.label2.Name = "label2";
			this.label2.Size = new Size( 139, 28 );
			this.label2.TabIndex = 5;
			this.label2.Text = "PhoneNumber";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = SystemColors.Control;
			this.label7.Font = new Font( "Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.label7.Location = new Point( 160, 506 );
			this.label7.Name = "label7";
			this.label7.Size = new Size( 136, 28 );
			this.label7.TabIndex = 9;
			this.label7.Text = "FeedBackField";
			// 
			// button1
			// 
			this.button1.Location = new Point( 113, 587 );
			this.button1.Name = "button1";
			this.button1.Size = new Size( 233, 66 );
			this.button1.TabIndex = 10;
			this.button1.Text = "Submit";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// panel2
			// 
			this.panel2.BackColor = SystemColors.ActiveCaption;
			this.panel2.Controls.Add( this.label4 );
			this.panel2.Controls.Add( this.label1 );
			this.panel2.Controls.Add( this.label2 );
			this.panel2.Location = new Point( 3, 3 );
			this.panel2.Name = "panel2";
			this.panel2.Size = new Size( 458, 229 );
			this.panel2.TabIndex = 11;
			// 
			// panel3
			// 
			this.panel3.BackColor = SystemColors.ActiveCaption;
			this.panel3.Controls.Add( this.label11 );
			this.panel3.Controls.Add( this.label12 );
			this.panel3.Controls.Add( this.label13 );
			this.panel3.Location = new Point( 3, 238 );
			this.panel3.Name = "panel3";
			this.panel3.Size = new Size( 461, 229 );
			this.panel3.TabIndex = 12;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = SystemColors.Control;
			this.label11.Font = new Font( "Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.label11.Location = new Point( 63, 149 );
			this.label11.Name = "label11";
			this.label11.Size = new Size( 135, 28 );
			this.label11.TabIndex = 8;
			this.label11.Text = "TotalCostField";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = SystemColors.Control;
			this.label12.Font = new Font( "Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.label12.Location = new Point( 63, 41 );
			this.label12.Name = "label12";
			this.label12.Size = new Size( 210, 28 );
			this.label12.TabIndex = 6;
			this.label12.Text = "BookingDateTimeField";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BackColor = SystemColors.Control;
			this.label13.Font = new Font( "Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.label13.Location = new Point( 63, 94 );
			this.label13.Name = "label13";
			this.label13.Size = new Size( 206, 28 );
			this.label13.TabIndex = 7;
			this.label13.Text = "NumberOfTicketsField";
			// 
			// ConcertBooking
			// 
			AutoScaleDimensions = new SizeF( 8F, 20F );
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size( 488, 725 );
			Controls.Add( this.panel1 );
			Name = "ConcertBooking";
			Text = "ConcertBooking";
			this.panel1.ResumeLayout( false );
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout( false );
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout( false );
			this.panel3.PerformLayout();
			this.ResumeLayout( false );
		}

		#endregion

		private Panel panel1;
		private Label label1;
		private Label label4;
		private Label label2;
		private Label label7;
		private Button button1;
		private Panel panel3;
		private Label label11;
		private Label label12;
		private Label label13;
		private Panel panel2;
	}
}