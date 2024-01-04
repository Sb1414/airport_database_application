namespace airport
{
	partial class AirportAddView
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
			this.buttonOk = new System.Windows.Forms.Button();
			this.textBoxCity = new System.Windows.Forms.TextBox();
			this.textBoxName = new System.Windows.Forms.TextBox();
			this.textBoxCode = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonOk
			// 
			this.buttonOk.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonOk.FlatAppearance.BorderSize = 0;
			this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOk.Location = new System.Drawing.Point(131, 184);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(158, 33);
			this.buttonOk.TabIndex = 4;
			this.buttonOk.Text = "ок";
			this.buttonOk.UseVisualStyleBackColor = false;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// textBoxCity
			// 
			this.textBoxCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxCity.Location = new System.Drawing.Point(77, 33);
			this.textBoxCity.Name = "textBoxCity";
			this.textBoxCity.Size = new System.Drawing.Size(266, 20);
			this.textBoxCity.TabIndex = 5;
			this.textBoxCity.Enter += new System.EventHandler(this.textBoxCity_Enter);
			this.textBoxCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCity_KeyPress);
			this.textBoxCity.Leave += new System.EventHandler(this.textBoxCity_Leave);
			// 
			// textBoxName
			// 
			this.textBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxName.Location = new System.Drawing.Point(77, 79);
			this.textBoxName.Name = "textBoxName";
			this.textBoxName.Size = new System.Drawing.Size(266, 20);
			this.textBoxName.TabIndex = 6;
			this.textBoxName.Enter += new System.EventHandler(this.textBoxName_Enter);
			this.textBoxName.Leave += new System.EventHandler(this.textBoxName_Leave);
			// 
			// textBoxCode
			// 
			this.textBoxCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxCode.Location = new System.Drawing.Point(77, 126);
			this.textBoxCode.Name = "textBoxCode";
			this.textBoxCode.Size = new System.Drawing.Size(266, 20);
			this.textBoxCode.TabIndex = 7;
			this.textBoxCode.TextChanged += new System.EventHandler(this.textBoxCode_TextChanged);
			this.textBoxCode.Enter += new System.EventHandler(this.textBoxCode_Enter);
			this.textBoxCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCode_KeyPress);
			this.textBoxCode.Leave += new System.EventHandler(this.textBoxCode_Leave);
			// 
			// AirportAddView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(412, 247);
			this.Controls.Add(this.textBoxCode);
			this.Controls.Add(this.textBoxName);
			this.Controls.Add(this.textBoxCity);
			this.Controls.Add(this.buttonOk);
			this.Name = "AirportAddView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Аэропорт";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.TextBox textBoxCity;
		private System.Windows.Forms.TextBox textBoxName;
		private System.Windows.Forms.TextBox textBoxCode;
	}
}