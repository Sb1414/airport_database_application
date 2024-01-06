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
			this.textBoxDepartureAirport = new System.Windows.Forms.TextBox();
			this.buttonOk = new System.Windows.Forms.Button();
			this.comboBoxDepartureAirport = new System.Windows.Forms.ComboBox();
			this.comboBoxArrivalAirport = new System.Windows.Forms.ComboBox();
			this.textBoxArrivalAirport = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.departureDay = new System.Windows.Forms.DateTimePicker();
			this.departureTime = new System.Windows.Forms.DateTimePicker();
			this.arrivalTime = new System.Windows.Forms.DateTimePicker();
			this.arrivalDay = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxDepartureAirport
			// 
			this.textBoxDepartureAirport.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxDepartureAirport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxDepartureAirport.Location = new System.Drawing.Point(49, 30);
			this.textBoxDepartureAirport.Name = "textBoxDepartureAirport";
			this.textBoxDepartureAirport.Size = new System.Drawing.Size(266, 20);
			this.textBoxDepartureAirport.TabIndex = 9;
			// 
			// buttonOk
			// 
			this.buttonOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(244)))));
			this.buttonOk.FlatAppearance.BorderSize = 0;
			this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOk.Location = new System.Drawing.Point(105, 383);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(158, 33);
			this.buttonOk.TabIndex = 8;
			this.buttonOk.Text = "ок";
			this.buttonOk.UseVisualStyleBackColor = false;
			// 
			// comboBoxDepartureAirport
			// 
			this.comboBoxDepartureAirport.FormattingEnabled = true;
			this.comboBoxDepartureAirport.Location = new System.Drawing.Point(49, 56);
			this.comboBoxDepartureAirport.Name = "comboBoxDepartureAirport";
			this.comboBoxDepartureAirport.Size = new System.Drawing.Size(266, 24);
			this.comboBoxDepartureAirport.TabIndex = 12;
			// 
			// comboBoxArrivalAirport
			// 
			this.comboBoxArrivalAirport.FormattingEnabled = true;
			this.comboBoxArrivalAirport.Location = new System.Drawing.Point(49, 164);
			this.comboBoxArrivalAirport.Name = "comboBoxArrivalAirport";
			this.comboBoxArrivalAirport.Size = new System.Drawing.Size(266, 24);
			this.comboBoxArrivalAirport.TabIndex = 14;
			// 
			// textBoxArrivalAirport
			// 
			this.textBoxArrivalAirport.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxArrivalAirport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxArrivalAirport.Location = new System.Drawing.Point(49, 138);
			this.textBoxArrivalAirport.Name = "textBoxArrivalAirport";
			this.textBoxArrivalAirport.Size = new System.Drawing.Size(266, 20);
			this.textBoxArrivalAirport.TabIndex = 13;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(49, 86);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(223, 20);
			this.checkBox1.TabIndex = 15;
			this.checkBox1.Text = "изменить аэропорт отправки";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(46, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(269, 16);
			this.label1.TabIndex = 18;
			this.label1.Text = "Аэропорт отправки";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(46, 119);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(269, 16);
			this.label2.TabIndex = 19;
			this.label2.Text = "Аэропорт прибытия";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(46, 205);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(269, 16);
			this.label3.TabIndex = 20;
			this.label3.Text = "Дата вылета, время";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(46, 262);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(269, 16);
			this.label4.TabIndex = 21;
			this.label4.Text = "Дата прибытия, время";
			// 
			// departureDay
			// 
			this.departureDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.departureDay.Location = new System.Drawing.Point(49, 227);
			this.departureDay.Name = "departureDay";
			this.departureDay.Size = new System.Drawing.Size(142, 22);
			this.departureDay.TabIndex = 22;
			// 
			// departureTime
			// 
			this.departureTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.departureTime.Location = new System.Drawing.Point(197, 227);
			this.departureTime.Name = "departureTime";
			this.departureTime.Size = new System.Drawing.Size(118, 22);
			this.departureTime.TabIndex = 23;
			// 
			// arrivalTime
			// 
			this.arrivalTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.arrivalTime.Location = new System.Drawing.Point(197, 281);
			this.arrivalTime.Name = "arrivalTime";
			this.arrivalTime.Size = new System.Drawing.Size(118, 22);
			this.arrivalTime.TabIndex = 25;
			// 
			// arrivalDay
			// 
			this.arrivalDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.arrivalDay.Location = new System.Drawing.Point(49, 281);
			this.arrivalDay.Name = "arrivalDay";
			this.arrivalDay.Size = new System.Drawing.Size(142, 22);
			this.arrivalDay.TabIndex = 24;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(46, 315);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(269, 16);
			this.label5.TabIndex = 26;
			this.label5.Text = "Стоимость билета на рейс";
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.Location = new System.Drawing.Point(49, 334);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(266, 22);
			this.numericUpDown1.TabIndex = 27;
			this.numericUpDown1.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
			// 
			// FlightsAddView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(373, 428);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.arrivalTime);
			this.Controls.Add(this.arrivalDay);
			this.Controls.Add(this.departureTime);
			this.Controls.Add(this.departureDay);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.comboBoxArrivalAirport);
			this.Controls.Add(this.textBoxArrivalAirport);
			this.Controls.Add(this.comboBoxDepartureAirport);
			this.Controls.Add(this.textBoxDepartureAirport);
			this.Controls.Add(this.buttonOk);
			this.Name = "FlightsAddView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Рейс";
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox textBoxDepartureAirport;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.ComboBox comboBoxDepartureAirport;
		private System.Windows.Forms.ComboBox comboBoxArrivalAirport;
		private System.Windows.Forms.TextBox textBoxArrivalAirport;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DateTimePicker departureDay;
		private System.Windows.Forms.DateTimePicker departureTime;
		private System.Windows.Forms.DateTimePicker arrivalTime;
		private System.Windows.Forms.DateTimePicker arrivalDay;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown numericUpDown1;
	}
}