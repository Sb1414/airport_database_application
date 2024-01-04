using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airport
{
	public partial class PlanesView : Form
	{
		string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
		public PlanesView()
		{
			InitializeComponent();
			LoadPlanes();
			dataGridViewPlanes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

		private void LoadPlanes()
		{
			using (SQLiteConnection connection = new SQLiteConnection(connectionString))
			{
				connection.Open();

				string query = "SELECT * FROM Planes";

				using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
				{
					using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
					{
						DataTable dt = new DataTable();
						adapter.Fill(dt);
						dataGridViewPlanes.DataSource = dt;
					}
					dataGridViewPlanes.Columns["Id"].Visible = false;
					dataGridViewPlanes.Columns["Model"].HeaderText = "Модель";
					dataGridViewPlanes.Columns["Capacity"].HeaderText = "Количество посадочных мест";
				}
			}
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			try
			{
				PlanesAddView add = new PlanesAddView();

				if (add.ShowDialog() == DialogResult.OK)
				{
					string model = add.Model;
					int capacity = add.Capacity;

					using (SQLiteConnection connection = new SQLiteConnection(connectionString))
					{
						connection.Open();
						using (SQLiteCommand cmd = new SQLiteCommand(
							"INSERT INTO Planes (Model, Capacity) " +
							"VALUES (@Model, @Capacity)",
							connection))
						{
							cmd.Parameters.AddWithValue("@Model", model);
							cmd.Parameters.AddWithValue("@Capacity", capacity);

							int rowsUpdated = cmd.ExecuteNonQuery();
							if (rowsUpdated > 0)
							{
								LoadPlanes();
							}
							else
							{
								MessageBox.Show("ошибка добавления данных");
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "ошибка", MessageBoxButtons.OK);
			}
		}

		private void buttonEdit_Click(object sender, EventArgs e)
		{
			try
			{
				if (dataGridViewPlanes.CurrentRow == null)
				{
					throw new Exception("не выбран самолёт");
				}
				int id = Convert.ToInt32(dataGridViewPlanes.CurrentRow.Cells["Id"].Value);
				string model = dataGridViewPlanes.CurrentRow.Cells["Model"].Value.ToString();
				int capacity = Convert.ToInt32(dataGridViewPlanes.CurrentRow.Cells["Capacity"].Value);

				PlanesAddView add = new PlanesAddView(model, capacity);

				if (add.ShowDialog() == DialogResult.OK)
				{
					model = add.Model;
					capacity = add.Capacity;

					using (SQLiteConnection connection = new SQLiteConnection(connectionString))
					{
						connection.Open();
						using (SQLiteCommand cmd = new SQLiteCommand(
							"UPDATE Planes SET Model = @Model, Capacity = @Capacity WHERE Id = @id", connection))
						{
							cmd.Parameters.AddWithValue("@Model", model);
							cmd.Parameters.AddWithValue("@Capacity", capacity);
							cmd.Parameters.AddWithValue("@id", id);
							int rowsUpdated = cmd.ExecuteNonQuery();
							if (rowsUpdated > 0)
							{
								LoadPlanes();
							}
							else
							{
								MessageBox.Show("ошибка обновления данных");
							}
						}
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "ошибка", MessageBoxButtons.OK);
			}
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			try
			{
				if (dataGridViewPlanes.CurrentRow != null)
				{
					DialogResult res = MessageBox.Show("Точно удалить самолёт?", "Предупреждение", MessageBoxButtons.OKCancel);
					if (res == DialogResult.OK)
					{
						int id = Convert.ToInt32(dataGridViewPlanes.CurrentRow.Cells["Id"].Value);

						using (SQLiteConnection connection = new SQLiteConnection(connectionString))
						{
							connection.Open();
							using (SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Planes WHERE Id = @id", connection))
							{
								cmd.Parameters.AddWithValue("@id", id);
								cmd.ExecuteNonQuery();
							}
						}
						LoadPlanes();
					}
				}
				else
				{
					throw new Exception("Не выбран самолёт");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "ошибка", MessageBoxButtons.OK);
			}
		}

		private void textBoxSearch_TextChanged(object sender, EventArgs e)
		{
			try
			{
				DataView dv = ((DataTable)dataGridViewPlanes.DataSource).DefaultView;
				dv.RowFilter = $"Model LIKE '%{textBoxSearch.Text}%'";
			}
			catch (Exception)
			{
				LoadPlanes();
			}
		}
	}
}
