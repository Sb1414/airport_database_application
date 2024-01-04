namespace airport
{
	partial class PlanesAddView
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
			this.textBoxCapacity = new System.Windows.Forms.TextBox();
			this.textBoxModel = new System.Windows.Forms.TextBox();
			this.buttonOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBoxCapacity
			// 
			this.textBoxCapacity.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxCapacity.Location = new System.Drawing.Point(70, 85);
			this.textBoxCapacity.Name = "textBoxCapacity";
			this.textBoxCapacity.Size = new System.Drawing.Size(266, 20);
			this.textBoxCapacity.TabIndex = 10;
			this.textBoxCapacity.Enter += new System.EventHandler(this.textBoxCapacity_Enter);
			this.textBoxCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCapacity_KeyPress);
			this.textBoxCapacity.Leave += new System.EventHandler(this.textBoxCapacity_Leave);
			// 
			// textBoxModel
			// 
			this.textBoxModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxModel.Location = new System.Drawing.Point(70, 39);
			this.textBoxModel.Name = "textBoxModel";
			this.textBoxModel.Size = new System.Drawing.Size(266, 20);
			this.textBoxModel.TabIndex = 9;
			this.textBoxModel.Enter += new System.EventHandler(this.textBoxModel_Enter);
			this.textBoxModel.Leave += new System.EventHandler(this.textBoxModel_Leave);
			// 
			// buttonOk
			// 
			this.buttonOk.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonOk.FlatAppearance.BorderSize = 0;
			this.buttonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonOk.Location = new System.Drawing.Point(124, 145);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(158, 33);
			this.buttonOk.TabIndex = 8;
			this.buttonOk.Text = "ок";
			this.buttonOk.UseVisualStyleBackColor = false;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			// 
			// PlanesAddView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(407, 204);
			this.Controls.Add(this.textBoxCapacity);
			this.Controls.Add(this.textBoxModel);
			this.Controls.Add(this.buttonOk);
			this.Name = "PlanesAddView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Самолёт";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxCapacity;
		private System.Windows.Forms.TextBox textBoxModel;
		private System.Windows.Forms.Button buttonOk;
	}
}