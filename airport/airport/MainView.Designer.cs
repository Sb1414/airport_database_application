namespace airport
{
	partial class MainView
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonAirlines = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// buttonAirlines
			// 
			this.buttonAirlines.Location = new System.Drawing.Point(46, 41);
			this.buttonAirlines.Name = "buttonAirlines";
			this.buttonAirlines.Size = new System.Drawing.Size(203, 63);
			this.buttonAirlines.TabIndex = 0;
			this.buttonAirlines.Text = "Аэропорты";
			this.buttonAirlines.UseVisualStyleBackColor = true;
			this.buttonAirlines.Click += new System.EventHandler(this.buttonAirlines_Click);
			// 
			// MainView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(894, 522);
			this.Controls.Add(this.buttonAirlines);
			this.Name = "MainView";
			this.Text = "Авиакомпания";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonAirlines;
	}
}

