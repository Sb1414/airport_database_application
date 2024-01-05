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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.buttonDeleteFlight = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.dataGridViewFlights = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlanes)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).BeginInit();
			this.SuspendLayout();
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxSearch.Location = new System.Drawing.Point(413, 193);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(178, 20);
			this.textBoxSearch.TabIndex = 11;
			this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
			// 
			// buttonDelete
			// 
			this.buttonDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonDelete.FlatAppearance.BorderSize = 0;
			this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDelete.Location = new System.Drawing.Point(413, 95);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(178, 40);
			this.buttonDelete.TabIndex = 10;
			this.buttonDelete.Text = "Удалить самолет";
			this.buttonDelete.UseVisualStyleBackColor = false;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonEdit
			// 
			this.buttonEdit.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonEdit.FlatAppearance.BorderSize = 0;
			this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonEdit.Location = new System.Drawing.Point(413, 49);
			this.buttonEdit.Name = "buttonEdit";
			this.buttonEdit.Size = new System.Drawing.Size(178, 40);
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
			this.buttonAdd.Location = new System.Drawing.Point(413, 3);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(178, 40);
			this.buttonAdd.TabIndex = 8;
			this.buttonAdd.Text = "Добавить самолет";
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
			this.dataGridViewPlanes.Size = new System.Drawing.Size(405, 210);
			this.dataGridViewPlanes.TabIndex = 7;
			this.dataGridViewPlanes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPlanes_CellClick);
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(597, 193);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(179, 20);
			this.textBox1.TabIndex = 21;
			// 
			// buttonDeleteFlight
			// 
			this.buttonDeleteFlight.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.buttonDeleteFlight.FlatAppearance.BorderSize = 0;
			this.buttonDeleteFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.buttonDeleteFlight.Location = new System.Drawing.Point(597, 95);
			this.buttonDeleteFlight.Name = "buttonDeleteFlight";
			this.buttonDeleteFlight.Size = new System.Drawing.Size(179, 40);
			this.buttonDeleteFlight.TabIndex = 20;
			this.buttonDeleteFlight.Text = "Удалить рейс";
			this.buttonDeleteFlight.UseVisualStyleBackColor = false;
			this.buttonDeleteFlight.Click += new System.EventHandler(this.buttonDeleteFlight_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Location = new System.Drawing.Point(597, 49);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(179, 40);
			this.button2.TabIndex = 19;
			this.button2.Text = "Редактировать рейс";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.editFlight_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Location = new System.Drawing.Point(597, 3);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(179, 40);
			this.button3.TabIndex = 18;
			this.button3.Text = "Добавить рейс";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.addFlight_Click);
			// 
			// dataGridViewFlights
			// 
			this.dataGridViewFlights.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
			this.dataGridViewFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewFlights.Location = new System.Drawing.Point(2, 219);
			this.dataGridViewFlights.Name = "dataGridViewFlights";
			this.dataGridViewFlights.RowHeadersWidth = 51;
			this.dataGridViewFlights.RowTemplate.Height = 24;
			this.dataGridViewFlights.Size = new System.Drawing.Size(774, 204);
			this.dataGridViewFlights.TabIndex = 17;
			// 
			// PlanesView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(788, 430);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.buttonDeleteFlight);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.dataGridViewFlights);
			this.Controls.Add(this.textBoxSearch);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonEdit);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.dataGridViewPlanes);
			this.Name = "PlanesView";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Самолеты";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlanes)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxSearch;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonEdit;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.DataGridView dataGridViewPlanes;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button buttonDeleteFlight;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.DataGridView dataGridViewFlights;
	}
}