namespace Ergasia3.src.ConcertBooking
{
	partial class Account
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
			this.label11 = new Label();
			this.label12 = new Label();
			this.label13 = new Label();
			this.button1 = new Button();
			this.SuspendLayout();
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = SystemColors.Control;
			this.label11.Font = new Font( "Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.label11.Location = new Point( 183, 265 );
			this.label11.Name = "label11";
			this.label11.Size = new Size( 135, 28 );
			this.label11.TabIndex = 25;
			this.label11.Text = "TotalCostField";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = SystemColors.Control;
			this.label12.Font = new Font( "Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.label12.Location = new Point( 183, 157 );
			this.label12.Name = "label12";
			this.label12.Size = new Size( 210, 28 );
			this.label12.TabIndex = 23;
			this.label12.Text = "BookingDateTimeField";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BackColor = SystemColors.Control;
			this.label13.Font = new Font( "Nirmala UI", 12F, FontStyle.Regular, GraphicsUnit.Point,   0 );
			this.label13.Location = new Point( 183, 210 );
			this.label13.Name = "label13";
			this.label13.Size = new Size( 206, 28 );
			this.label13.TabIndex = 24;
			this.label13.Text = "NumberOfTicketsField";
			// 
			// button1
			// 
			this.button1.Location = new Point( 385, 227 );
			this.button1.Name = "button1";
			this.button1.Size = new Size( 233, 66 );
			this.button1.TabIndex = 22;
			this.button1.Text = "Submit";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// Account
			// 
			AutoScaleDimensions = new SizeF( 8F, 20F );
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size( 800, 450 );
			Controls.Add( this.label11 );
			Controls.Add( this.label12 );
			Controls.Add( this.label13 );
			Controls.Add( this.button1 );
			Name = "Account";
			Text = "Account";
			this.ResumeLayout( false );
			this.PerformLayout();
		}

		#endregion

		private Label label11;
		private Label label12;
		private Label label13;
		private Button button1;
	}
}