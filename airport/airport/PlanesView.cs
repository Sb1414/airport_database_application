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
			dataGridViewFlights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
			if (dataGridViewPlanes.Rows.Count > 0)
			{
				dataGridViewPlanes_CellClick(dataGridViewPlanes, new DataGridViewCellEventArgs(0, 0));
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

		private void dataGridViewPlanes_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex >= 0 && e.RowIndex < dataGridViewPlanes.Rows.Count)
				{
					int plane_id = Convert.ToInt32(dataGridViewPlanes.Rows[e.RowIndex].Cells["id"].Value);

					string query = @"SELECT Flights.Id, DepartureAirportID, A1.City || ' (' || A1.Code || ')' AS DepartureAirport,
									   ArrivalAirportID, A2.City || ' (' || A2.Code || ')' AS ArrivalAirport, DepartureTime, ArrivalTime
									   FROM Flights
								JOIN Airports A2 on A2.Id = Flights.ArrivalAirportID
								JOIN Airports A1 on A1.Id = Flights.DepartureAirportID
								JOIN Planes P on P.Id = Flights.PlaneID
								WHERE PlaneID = @plane_id";

					using (SQLiteConnection connection = new SQLiteConnection(connectionString))
					{
						connection.Open();

						SQLiteCommand command = new SQLiteCommand(query, connection);
						command.Parameters.AddWithValue("@plane_id", plane_id);

						using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
						{
							DataTable dt = new DataTable();
							adapter.Fill(dt);

							dataGridViewFlights.DataSource = dt;
						}
						colls();
					}
				}
			}
			catch (Exception)
			{
				dataGridViewFlights.DataSource = null;
			}
		}

		private void colls()
		{
			dataGridViewFlights.Columns["Id"].Visible = false;
			dataGridViewFlights.Columns["DepartureAirportID"].Visible = false;
			dataGridViewFlights.Columns["ArrivalAirportID"].Visible = false;
			dataGridViewFlights.Columns["DepartureAirport"].HeaderText = "Отправка из";
			dataGridViewFlights.Columns["ArrivalAirport"].HeaderText = "Прибытие в";
			dataGridViewFlights.Columns["DepartureTime"].HeaderText = "Время вылета";
			dataGridViewFlights.Columns["ArrivalTime"].HeaderText = "Время прибытия";
		}

		private void addFlight_Click(object sender, EventArgs e)
		{
			try
			{
				if (dataGridViewPlanes.CurrentRow == null)
				{
					throw new Exception("Не выбран самолёт для добавления рейса");
				}

				int plane_id = Convert.ToInt32(dataGridViewPlanes.CurrentRow.Cells["Id"].Value);

				FlightsAddView add = new FlightsAddView(connectionString);

				if (add.ShowDialog() == DialogResult.OK)
				{
					int DepartureAirportID = add.idDeparture;
					int ArrivalAirportID = add.idArrival;
					string DepartureTime = add.DepartureTime;
					string ArrivalTime = add.ArrivalTime;

					using (SQLiteConnection connection = new SQLiteConnection(connectionString))
					{
						connection.Open();

						using (SQLiteCommand cmd = new SQLiteCommand(
							"INSERT INTO Flights (PlaneID, DepartureAirportID, ArrivalAirportID, DepartureTime, ArrivalTime) " +
							"VALUES (@PlaneID, @DepartureAirportID, @ArrivalAirportID, @DepartureTime, @ArrivalTime)", connection))
						{
							cmd.Parameters.AddWithValue("@DepartureAirportID", DepartureAirportID);
							cmd.Parameters.AddWithValue("@PlaneID", plane_id);
							cmd.Parameters.AddWithValue("@ArrivalAirportID", ArrivalAirportID);
							cmd.Parameters.AddWithValue("@DepartureTime", DepartureTime);
							cmd.Parameters.AddWithValue("@ArrivalTime", ArrivalTime);

							cmd.ExecuteNonQuery();
						}
						LoadPlanes();
					}
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
			}
		}

		private void editFlight_Click(object sender, EventArgs e)
		{
			try
			{
				if (dataGridViewFlights.CurrentRow == null)
				{
					throw new Exception("Не выбран рейс для редактирования");
				}
				int plane_id = Convert.ToInt32(dataGridViewPlanes.CurrentRow.Cells["Id"].Value);
				int id = Convert.ToInt32(dataGridViewFlights.CurrentRow.Cells["Id"].Value);
				int DepartureAirportID = Convert.ToInt32(dataGridViewFlights.CurrentRow.Cells["DepartureAirportID"].Value);
				int ArrivalAirportID = Convert.ToInt32(dataGridViewFlights.CurrentRow.Cells["ArrivalAirportID"].Value);
				string DepartureTime = dataGridViewFlights.CurrentRow.Cells["DepartureTime"].Value?.ToString();
				string ArrivalTime = dataGridViewFlights.CurrentRow.Cells["ArrivalTime"].Value?.ToString();

				FlightsAddView add = new FlightsAddView(connectionString, DepartureAirportID, ArrivalAirportID, DepartureTime, ArrivalTime);
				if (add.ShowDialog() == DialogResult.OK)
				{
					DepartureAirportID = add.idDeparture;
					ArrivalAirportID = add.idArrival;
					DepartureTime = add.DepartureTime;
					ArrivalTime = add.ArrivalTime;

					using (SQLiteConnection connection = new SQLiteConnection(connectionString))
					{
						connection.Open();
						using (SQLiteCommand cmd = new SQLiteCommand(
							"UPDATE Flights SET PlaneID = @PlaneID, DepartureAirportID = @DepartureAirportID, ArrivalAirportID = @ArrivalAirportID, " +
							"DepartureTime = @DepartureTime, ArrivalTime = @ArrivalTime WHERE Id = @id", connection))
						{
							cmd.Parameters.AddWithValue("@DepartureAirportID", DepartureAirportID);
							cmd.Parameters.AddWithValue("@PlaneID", plane_id);
							cmd.Parameters.AddWithValue("@ArrivalAirportID", ArrivalAirportID);
							cmd.Parameters.AddWithValue("@DepartureTime", DepartureTime);
							cmd.Parameters.AddWithValue("@ArrivalTime", ArrivalTime);
							cmd.Parameters.AddWithValue("@id", id);

							cmd.ExecuteNonQuery();
						}
						LoadPlanes();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
			}
		}

		private void buttonDeleteFlight_Click(object sender, EventArgs e)
		{
			try
			{
				if (dataGridViewFlights.CurrentRow == null)
				{
					throw new Exception("не выбран рейс");
				}
				DialogResult res = MessageBox.Show("Точно удалить рейс?", "Предупреждение", MessageBoxButtons.OKCancel);
				if (res == DialogResult.OK)
				{
					int id = Convert.ToInt32(dataGridViewFlights.CurrentRow.Cells["Id"].Value);
					using (SQLiteConnection connection = new SQLiteConnection(connectionString))
					{
						connection.Open();
						using (SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Flights WHERE Id = @id", connection))
						{
							cmd.Parameters.AddWithValue("@id", id);
							cmd.ExecuteNonQuery();
						}
					}
					LoadPlanes();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "ошибка", MessageBoxButtons.OK);
			}
		}
	}
}
