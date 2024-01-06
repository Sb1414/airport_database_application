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
			this.buttonDeleteTicket = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.buttonAddTicket = new System.Windows.Forms.Button();
			this.dataGridViewTickets = new System.Windows.Forms.DataGridView();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.dataGridViewPassengers = new System.Windows.Forms.DataGridView();
			this.buttonPrintTicket = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewTickets)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPassengers)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonDeleteTicket
			// 
			this.buttonDeleteTicket.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonDeleteTicket.FlatAppearance.BorderSize = 0;
			this.buttonDeleteTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDeleteTicket.Location = new System.Drawing.Point(382, 470);
			this.buttonDeleteTicket.Name = "buttonDeleteTicket";
			this.buttonDeleteTicket.Size = new System.Drawing.Size(179, 26);
			this.buttonDeleteTicket.TabIndex = 30;
			this.buttonDeleteTicket.Text = "Удалить билет";
			this.buttonDeleteTicket.UseVisualStyleBackColor = false;
			this.buttonDeleteTicket.Click += new System.EventHandler(this.buttonDeleteTicket_Click);
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
			this.button2.Click += new System.EventHandler(this.editTicket_Click);
			// 
			// buttonAddTicket
			// 
			this.buttonAddTicket.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonAddTicket.FlatAppearance.BorderSize = 0;
			this.buttonAddTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAddTicket.Location = new System.Drawing.Point(12, 470);
			this.buttonAddTicket.Name = "buttonAddTicket";
			this.buttonAddTicket.Size = new System.Drawing.Size(179, 26);
			this.buttonAddTicket.TabIndex = 28;
			this.buttonAddTicket.Text = "Добавить билет";
			this.buttonAddTicket.UseVisualStyleBackColor = false;
			this.buttonAddTicket.Click += new System.EventHandler(this.buttonAddTicket_Click);
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
			// buttonPrintTicket
			// 
			this.buttonPrintTicket.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonPrintTicket.FlatAppearance.BorderSize = 0;
			this.buttonPrintTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonPrintTicket.Location = new System.Drawing.Point(567, 470);
			this.buttonPrintTicket.Name = "buttonPrintTicket";
			this.buttonPrintTicket.Size = new System.Drawing.Size(179, 26);
			this.buttonPrintTicket.TabIndex = 31;
			this.buttonPrintTicket.Text = "Вывести посадочный";
			this.buttonPrintTicket.UseVisualStyleBackColor = false;
			this.buttonPrintTicket.Click += new System.EventHandler(this.buttonPrintTicket_Click);
			// 
			// TicketsView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(753, 501);
			this.Controls.Add(this.buttonPrintTicket);
			this.Controls.Add(this.buttonDeleteTicket);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.buttonAddTicket);
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
		private System.Windows.Forms.Button buttonDeleteTicket;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button buttonAddTicket;
		private System.Windows.Forms.DataGridView dataGridViewTickets;
		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.DataGridView dataGridViewPassengers;
		private System.Windows.Forms.Button buttonPrintTicket;
	}
}