namespace airport
{
	partial class PlanesView
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
			this.textBoxSearch = new System.Windows.Forms.TextBox();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonEdit = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.dataGridViewPlanes = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlanes)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxSearch.Location = new System.Drawing.Point(330, 155);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(158, 20);
			this.textBoxSearch.TabIndex = 11;
			this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
			// 
			// buttonDelete
			// 
			this.buttonDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonDelete.FlatAppearance.BorderSize = 0;
			this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDelete.Location = new System.Drawing.Point(330, 95);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(158, 40);
			this.buttonDelete.TabIndex = 10;
			this.buttonDelete.Text = "Удалить";
			this.buttonDelete.UseVisualStyleBackColor = false;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonEdit
			// 
			this.buttonEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonEdit.FlatAppearance.BorderSize = 0;
			this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEdit.Location = new System.Drawing.Point(330, 49);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(158, 40);
			this.buttonEdit.TabIndex = 9;
			this.buttonEdit.Text = "Редактировать";
			this.buttonEdit.UseVisualStyleBackColor = false;
			this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonAdd.FlatAppearance.BorderSize = 0;
			this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAdd.Location = new System.Drawing.Point(330, 3);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(158, 40);
			this.buttonAdd.TabIndex = 8;
			this.buttonAdd.Text = "Добавить";
			this.buttonAdd.UseVisualStyleBackColor = false;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// dataGridViewPlanes
			// 
			this.dataGridViewPlanes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridViewPlanes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewPlanes.Location = new System.Drawing.Point(2, 3);
			this.dataGridViewPlanes.Name = "dataGridViewPlanes";
			this.dataGridViewPlanes.RowHeadersWidth = 51;
			this.dataGridViewPlanes.RowTemplate.Height = 24;
			this.dataGridViewPlanes.Size = new System.Drawing.Size(322, 256);
			this.dataGridViewPlanes.TabIndex = 7;
			// 
			// PlanesView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(492, 262);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.dataGridViewPlanes);
			this.Name = "PlanesView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Самолеты";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlanes)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.DataGridView dataGridViewPlanes;
	}
}