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
			this.buttonPlanes = new System.Windows.Forms.Button();
			this.buttonPassengers = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// buttonAirlines
			// 
			this.buttonAirlines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(181)))), ((int)(((byte)(232)))));
			this.buttonAirlines.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonAirlines.FlatAppearance.BorderSize = 2;
			this.buttonAirlines.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonAirlines.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonAirlines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAirlines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonAirlines.Location = new System.Drawing.Point(46, 166);
			this.buttonAirlines.Name = "buttonAirlines";
			this.buttonAirlines.Size = new System.Drawing.Size(203, 71);
			this.buttonAirlines.TabIndex = 0;
			this.buttonAirlines.Text = "Терминалы";
			this.buttonAirlines.UseVisualStyleBackColor = false;
			this.buttonAirlines.Click += new System.EventHandler(this.buttonAirlines_Click);
			// 
			// buttonPlanes
			// 
			this.buttonPlanes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(181)))), ((int)(((byte)(232)))));
			this.buttonPlanes.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonPlanes.FlatAppearance.BorderSize = 2;
			this.buttonPlanes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonPlanes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonPlanes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPlanes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonPlanes.Location = new System.Drawing.Point(402, 291);
			this.buttonPlanes.Name = "buttonPlanes";
			this.buttonPlanes.Size = new System.Drawing.Size(203, 71);
			this.buttonPlanes.TabIndex = 1;
			this.buttonPlanes.Text = "Самолеты и рейсы";
			this.buttonPlanes.UseVisualStyleBackColor = false;
			this.buttonPlanes.Click += new System.EventHandler(this.buttonPlanes_Click);
			// 
			// buttonPassengers
			// 
			this.buttonPassengers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(181)))), ((int)(((byte)(232)))));
			this.buttonPassengers.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.buttonPassengers.FlatAppearance.BorderSize = 2;
			this.buttonPassengers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
			this.buttonPassengers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
			this.buttonPassengers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPassengers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonPassengers.Location = new System.Drawing.Point(46, 367);
			this.buttonPassengers.Name = "buttonPassengers";
			this.buttonPassengers.Size = new System.Drawing.Size(203, 71);
			this.buttonPassengers.TabIndex = 2;
			this.buttonPassengers.Text = "Пассажиры и билеты";
			this.buttonPassengers.UseVisualStyleBackColor = false;
			this.buttonPassengers.Click += new System.EventHandler(this.buttonPassengers_Click);
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(606, 44);
			this.label1.TabIndex = 9;
			this.label1.Text = "Аэропорт";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::airport.Properties.Resources.main;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(630, 522);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonPassengers);
			this.Controls.Add(this.buttonPlanes);
			this.Controls.Add(this.buttonAirlines);
			this.DoubleBuffered = true;
			this.Name = "MainView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "аэропорт";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonAirlines;
		private System.Windows.Forms.Button buttonPlanes;
		private System.Windows.Forms.Button buttonPassengers;
		private System.Windows.Forms.Label label1;
	}
}

