namespace airport
{
	partial class PassengerAddView
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
			this.textBoxMiddleName = new System.Windows.Forms.TextBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxLastName = new System.Windows.Forms.TextBox();
			this.buttonOk = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.textBoxPassportNumber = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBoxMiddleName
			// 
			this.textBoxMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxMiddleName.Location = new System.Drawing.Point(70, 129);
			this.textBoxMiddleName.Name = "textBoxMiddleName";
			this.textBoxMiddleName.Size = new System.Drawing.Size(266, 20);
			this.textBoxMiddleName.TabIndex = 11;
			this.textBoxMiddleName.Enter += new System.EventHandler(this.textBoxCode_Enter);
			this.textBoxMiddleName.Leave += new System.EventHandler(this.textBoxCode_Leave);
			// 
			// textBoxName
			// 
			this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxName.Location = new System.Drawing.Point(70, 82);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(266, 20);
			this.textBoxName.TabIndex = 10;
			this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
			this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
			// 
			// textBoxLastName
			// 
			this.textBoxLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxLastName.Location = new System.Drawing.Point(70, 36);
			this.textBoxLastName.Name = "textBoxLastName";
			this.textBoxLastName.Size = new System.Drawing.Size(266, 20);
			this.textBoxLastName.TabIndex = 9;
			this.textBoxLastName.Enter += new System.EventHandler(this.textBoxCity_Enter);
			this.textBoxLastName.Leave += new System.EventHandler(this.textBoxCity_Leave);
			// 
			// buttonOk
			// 
			this.buttonOk.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonOk.FlatAppearance.BorderSize = 0;
			this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOk.Location = new System.Drawing.Point(119, 286);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(158, 33);
			this.buttonOk.TabIndex = 8;
			this.buttonOk.Text = "ок";
			this.buttonOk.UseVisualStyleBackColor = false;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(70, 184);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(266, 22);
			this.dateTimePicker1.TabIndex = 12;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(67, 165);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(269, 16);
			this.label2.TabIndex = 20;
			this.label2.Text = "Дата рождения";
			// 
			// textBoxPassportNumber
			// 
			this.textBoxPassportNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxPassportNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxPassportNumber.Location = new System.Drawing.Point(70, 242);
			this.textBoxPassportNumber.Name = "textBoxPassportNumber";
			this.textBoxPassportNumber.Size = new System.Drawing.Size(266, 20);
			this.textBoxPassportNumber.TabIndex = 21;
			this.textBoxPassportNumber.TextChanged += new System.EventHandler(this.textBoxPassportNumber_TextChanged);
			this.textBoxPassportNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPassportNumber_KeyPress);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(67, 223);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(269, 16);
			this.label1.TabIndex = 22;
			this.label1.Text = "Серия и номер паспорта";
			// 
			// PassengerAddView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(399, 338);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBoxPassportNumber);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.textBoxMiddleName);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.textBoxLastName);
			this.Controls.Add(this.buttonOk);
			this.Name = "PassengerAddView";
			this.Text = "PassengerAddView";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxMiddleName;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxLastName;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxPassportNumber;
		private System.Windows.Forms.Label label1;
	}
}