namespace airport
{
	partial class AirlinesView
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridViewAirlines = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAirlines)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewAirlines
			// 
			this.dataGridViewAirlines.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridViewAirlines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAirlines.Location = new System.Drawing.Point(12, 28);
			this.dataGridViewAirlines.Name = "dataGridViewAirlines";
			this.dataGridViewAirlines.RowHeadersWidth = 51;
			this.dataGridViewAirlines.RowTemplate.Height = 24;
			this.dataGridViewAirlines.Size = new System.Drawing.Size(819, 278);
			this.dataGridViewAirlines.TabIndex = 0;
			// 
			// AirlinesView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(843, 522);
			this.Controls.Add(this.dataGridViewAirlines);
			this.Name = "AirlinesView";
			this.Text = "AirlinesView";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAirlines)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewAirlines;
	}
}