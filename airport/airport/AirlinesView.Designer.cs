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
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAirlines)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewAirlines
			// 
			this.dataGridViewAirlines.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridViewAirlines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewAirlines.Location = new System.Drawing.Point(12, 12);
			this.dataGridViewAirlines.Name = "dataGridViewAirlines";
			this.dataGridViewAirlines.RowHeadersWidth = 51;
			this.dataGridViewAirlines.RowTemplate.Height = 24;
			this.dataGridViewAirlines.Size = new System.Drawing.Size(819, 438);
			this.dataGridViewAirlines.TabIndex = 0;
			// 
			// buttonAdd
			// 
			this.buttonAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonAdd.FlatAppearance.BorderSize = 0;
			this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonAdd.Location = new System.Drawing.Point(12, 456);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(158, 40);
			this.buttonAdd.TabIndex = 1;
			this.buttonAdd.Text = "Добавить";
			this.buttonAdd.UseVisualStyleBackColor = false;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// buttonEdit
			// 
			this.buttonEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonEdit.FlatAppearance.BorderSize = 0;
			this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEdit.Location = new System.Drawing.Point(176, 456);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(158, 40);
			this.buttonEdit.TabIndex = 2;
			this.buttonEdit.Text = "Редактировать";
			this.buttonEdit.UseVisualStyleBackColor = false;
			// 
			// buttonDelete
			// 
			this.buttonDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonDelete.FlatAppearance.BorderSize = 0;
			this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDelete.Location = new System.Drawing.Point(340, 456);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(158, 40);
			this.buttonDelete.TabIndex = 3;
			this.buttonDelete.Text = "Удалить";
			this.buttonDelete.UseVisualStyleBackColor = false;
			// 
			// AirlinesView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(843, 522);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.dataGridViewAirlines);
			this.Name = "AirlinesView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Аэропорты";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewAirlines)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewAirlines;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Button buttonDelete;
	}
}