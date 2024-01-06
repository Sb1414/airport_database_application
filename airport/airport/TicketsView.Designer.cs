namespace airport
{
	partial class TicketsView
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.buttonDeleteFlight = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.dataGridViewPassengers = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPassengers)).BeginInit();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(567, 470);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(179, 20);
			this.textBox1.TabIndex = 31;
			// 
			// buttonDeleteFlight
			// 
			this.buttonDeleteFlight.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonDeleteFlight.FlatAppearance.BorderSize = 0;
			this.buttonDeleteFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDeleteFlight.Location = new System.Drawing.Point(382, 470);
			this.buttonDeleteFlight.Name = "buttonDeleteFlight";
			this.buttonDeleteFlight.Size = new System.Drawing.Size(179, 26);
			this.buttonDeleteFlight.TabIndex = 30;
			this.buttonDeleteFlight.Text = "Удалить билет";
			this.buttonDeleteFlight.UseVisualStyleBackColor = false;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(197, 470);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(179, 26);
			this.button2.TabIndex = 29;
			this.button2.Text = "Редактировать билет";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Location = new System.Drawing.Point(12, 470);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(179, 26);
			this.button3.TabIndex = 28;
			this.button3.Text = "Добавить билет";
			this.button3.UseVisualStyleBackColor = false;
			// 
			// dataGridViewTickets
			// 
			this.dataGridViewTickets.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridViewTickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewTickets.Location = new System.Drawing.Point(12, 260);
			this.dataGridViewTickets.Name = "dataGridViewTickets";
			this.dataGridViewTickets.RowHeadersWidth = 51;
			this.dataGridViewTickets.RowTemplate.Height = 24;
			this.dataGridViewTickets.Size = new System.Drawing.Size(734, 204);
			this.dataGridViewTickets.TabIndex = 27;
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxSearch.Location = new System.Drawing.Point(564, 234);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(178, 20);
			this.textBoxSearch.TabIndex = 26;
			// 
			// buttonDelete
			// 
			this.buttonDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonDelete.FlatAppearance.BorderSize = 0;
			this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDelete.Location = new System.Drawing.Point(380, 228);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(178, 26);
			this.buttonDelete.TabIndex = 25;
			this.buttonDelete.Text = "Удалить пассажира";
			this.buttonDelete.UseVisualStyleBackColor = false;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonEdit
			// 
			this.buttonEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonEdit.FlatAppearance.BorderSize = 0;
			this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEdit.Location = new System.Drawing.Point(196, 228);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(178, 26);
			this.buttonEdit.TabIndex = 24;
			this.buttonEdit.Text = "Редактировать";
			this.buttonEdit.UseVisualStyleBackColor = false;
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonAdd.FlatAppearance.BorderSize = 0;
			this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAdd.Location = new System.Drawing.Point(12, 228);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(178, 26);
			this.buttonAdd.TabIndex = 23;
			this.buttonAdd.Text = "Добавить пассажира";
			this.buttonAdd.UseVisualStyleBackColor = false;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// dataGridViewPassengers
			// 
			this.dataGridViewPassengers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridViewPassengers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewPassengers.Location = new System.Drawing.Point(12, 12);
			this.dataGridViewPassengers.Name = "dataGridViewPassengers";
			this.dataGridViewPassengers.RowHeadersWidth = 51;
			this.dataGridViewPassengers.RowTemplate.Height = 24;
			this.dataGridViewPassengers.Size = new System.Drawing.Size(734, 210);
			this.dataGridViewPassengers.TabIndex = 22;
			this.dataGridViewPassengers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPassengers_CellClick);
			// 
			// TicketsView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(753, 501);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.buttonDeleteFlight);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.dataGridViewTickets);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.dataGridViewPassengers);
			this.Name = "TicketsView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Пассажиры и билеты";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPassengers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button buttonDeleteFlight;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.DataGridView dataGridViewTickets;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.DataGridView dataGridViewPassengers;
	}
}