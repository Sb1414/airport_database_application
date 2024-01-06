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
			this.buttonAdd = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAirlines)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewAirlines
			// 
			this.dataGridViewAirlines.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.dataGridViewAirlines.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.dataGridViewAirlines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAirlines.Location = new System.Drawing.Point(12, 12);
			this.dataGridViewAirlines.Name = "dataGridViewAirlines";
			this.dataGridViewAirlines.RowHeadersWidth = 51;
			this.dataGridViewAirlines.RowTemplate.Height = 24;
			this.dataGridViewAirlines.Size = new System.Drawing.Size(722, 410);
			this.dataGridViewAirlines.TabIndex = 0;
			// 
			// buttonAdd
			// 
			this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(244)))));
			this.buttonAdd.FlatAppearance.BorderSize = 0;
			this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAdd.Location = new System.Drawing.Point(11, 428);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(158, 29);
			this.buttonAdd.TabIndex = 1;
			this.buttonAdd.Text = "Добавить";
			this.buttonAdd.UseVisualStyleBackColor = false;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonEdit
			// 
			this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(244)))));
			this.buttonEdit.FlatAppearance.BorderSize = 0;
			this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEdit.Location = new System.Drawing.Point(175, 428);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(158, 29);
			this.buttonEdit.TabIndex = 2;
			this.buttonEdit.Text = "Редактировать";
			this.buttonEdit.UseVisualStyleBackColor = false;
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(202)))), ((int)(((byte)(244)))));
			this.buttonDelete.FlatAppearance.BorderSize = 0;
			this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDelete.Location = new System.Drawing.Point(339, 428);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(158, 29);
			this.buttonDelete.TabIndex = 3;
			this.buttonDelete.Text = "Удалить";
			this.buttonDelete.UseVisualStyleBackColor = false;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxSearch.Location = new System.Drawing.Point(505, 428);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(229, 20);
			this.textBoxSearch.TabIndex = 6;
			this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
			// 
			// AirlinesView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(738, 461);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.dataGridViewAirlines);
			this.Name = "AirlinesView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Аэропорты";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAirlines)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewAirlines;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.TextBox textBoxSearch;
	}
}