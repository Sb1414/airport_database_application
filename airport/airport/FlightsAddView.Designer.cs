namespace airport
{
	partial class FlightsAddView
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
			this.textBoxCode = new System.Windows.Forms.TextBox();
			this.textBoxDepartureAirport = new System.Windows.Forms.TextBox();
			this.buttonOk = new System.Windows.Forms.Button();
			this.comboBoxDepartureAirport = new System.Windows.Forms.ComboBox();
			this.comboBoxArrivalAirport = new System.Windows.Forms.ComboBox();
			this.textBoxArrivalAirport = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// textBoxCode
			// 
			this.textBoxCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxCode.Location = new System.Drawing.Point(89, 204);
			this.textBoxCode.Name = "textBoxCode";
			this.textBoxCode.Size = new System.Drawing.Size(266, 20);
			this.textBoxCode.TabIndex = 11;
			// 
			// textBoxDepartureAirport
			// 
			this.textBoxDepartureAirport.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxDepartureAirport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxDepartureAirport.Location = new System.Drawing.Point(89, 25);
			this.textBoxDepartureAirport.Name = "textBoxDepartureAirport";
			this.textBoxDepartureAirport.Size = new System.Drawing.Size(266, 20);
			this.textBoxDepartureAirport.TabIndex = 9;
			// 
			// buttonOk
			// 
			this.buttonOk.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonOk.FlatAppearance.BorderSize = 0;
			this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOk.Location = new System.Drawing.Point(143, 262);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(158, 33);
			this.buttonOk.TabIndex = 8;
			this.buttonOk.Text = "ок";
			this.buttonOk.UseVisualStyleBackColor = false;
			// 
			// comboBoxDepartureAirport
			// 
			this.comboBoxDepartureAirport.FormattingEnabled = true;
			this.comboBoxDepartureAirport.Location = new System.Drawing.Point(89, 51);
			this.comboBoxDepartureAirport.Name = "comboBoxDepartureAirport";
			this.comboBoxDepartureAirport.Size = new System.Drawing.Size(266, 24);
			this.comboBoxDepartureAirport.TabIndex = 12;
			// 
			// comboBoxArrivalAirport
			// 
			this.comboBoxArrivalAirport.FormattingEnabled = true;
			this.comboBoxArrivalAirport.Location = new System.Drawing.Point(89, 149);
			this.comboBoxArrivalAirport.Name = "comboBoxArrivalAirport";
			this.comboBoxArrivalAirport.Size = new System.Drawing.Size(266, 24);
			this.comboBoxArrivalAirport.TabIndex = 14;
			// 
			// textBoxArrivalAirport
			// 
			this.textBoxArrivalAirport.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxArrivalAirport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxArrivalAirport.Location = new System.Drawing.Point(89, 123);
			this.textBoxArrivalAirport.Name = "textBoxArrivalAirport";
			this.textBoxArrivalAirport.Size = new System.Drawing.Size(266, 20);
			this.textBoxArrivalAirport.TabIndex = 13;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(89, 81);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(223, 20);
			this.checkBox1.TabIndex = 15;
			this.checkBox1.Text = "изменить аэропорт отправки";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// FlightsAddView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(445, 340);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.comboBoxArrivalAirport);
			this.Controls.Add(this.textBoxArrivalAirport);
			this.Controls.Add(this.comboBoxDepartureAirport);
			this.Controls.Add(this.textBoxCode);
			this.Controls.Add(this.textBoxDepartureAirport);
			this.Controls.Add(this.buttonOk);
			this.Name = "FlightsAddView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Рейс";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxCode;
		private System.Windows.Forms.TextBox textBoxDepartureAirport;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.ComboBox comboBoxDepartureAirport;
		private System.Windows.Forms.ComboBox comboBoxArrivalAirport;
		private System.Windows.Forms.TextBox textBoxArrivalAirport;
		private System.Windows.Forms.CheckBox checkBox1;
	}
}