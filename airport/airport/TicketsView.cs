using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airport
{
	public partial class TicketsView : Form
	{
		string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
		public TicketsView()
		{
			InitializeComponent();
			LoadPassengers();
			dataGridViewPassengers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewTickets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
		}

		private void LoadPassengers()
		{
			using (SQLiteConnection connection = new SQLiteConnection(connectionString))
			{
				connection.Open();

				string query = "SELECT * FROM Passengers";

				using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
				{
					using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
					{
						DataTable dt = new DataTable();
						adapter.Fill(dt);
						dataGridViewPassengers.DataSource = dt;
					}
					dataGridViewPassengers.Columns["Id"].Visible = false;
					dataGridViewPassengers.Columns["FirstName"].HeaderText = "Имя";
					dataGridViewPassengers.Columns["LastName"].HeaderText = "Фамилия";
					dataGridViewPassengers.Columns["MiddleName"].HeaderText = "Отчество";
					dataGridViewPassengers.Columns["DateOfBirth"].HeaderText = "Дата рождения";
					dataGridViewPassengers.Columns["PassportNumber"].HeaderText = "Паспорт";
				}
			}
			if (dataGridViewPassengers.Rows.Count > 0)
			{
				dataGridViewPassengers_CellClick(dataGridViewPassengers, new DataGridViewCellEventArgs(0, 0));
			}
		}

		private void dataGridViewPassengers_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.RowIndex >= 0 && e.RowIndex < dataGridViewPassengers.Rows.Count)
				{
					int PassengerID = Convert.ToInt32(dataGridViewPassengers.Rows[e.RowIndex].Cells["id"].Value);

					string query = @"SELECT Tickets.Id, FlightID, A1.City || ' (' || A1.Code || ')' AS DepartureAirport, 
									   A2.City || ' (' || A2.Code || ')' AS ArrivalAirport, F.DepartureTime, F.ArrivalTime,
									   RowNumber || SC.NameSeat AS seat, (F.Price + SC.Price) AS TotalPrice, p2.Model, PassengerID, SeatID FROM Tickets
								JOIN Passengers P on P.Id = Tickets.PassengerID
								JOIN Flights F on F.Id = Tickets.FlightID
								JOIN Airports A1 on A1.Id = F.DepartureAirportID
								JOIN Airports A2 on A2.Id = F.ArrivalAirportID
								JOIN Planes P2 on P2.Id = F.PlaneID
								JOIN SeatsCategories SC on SC.Id = Tickets.SeatID
								WHERE PassengerID = @PassengerID";

					using (SQLiteConnection connection = new SQLiteConnection(connectionString))
					{
						connection.Open();

						SQLiteCommand command = new SQLiteCommand(query, connection);
						command.Parameters.AddWithValue("@PassengerID", PassengerID);

						using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
						{
							DataTable dt = new DataTable();
							adapter.Fill(dt);

							dataGridViewTickets.DataSource = dt;
						}
						colls();
					}
				}
			}
			catch (Exception)
			{
				dataGridViewTickets.DataSource = null;
			}
		}

		private void colls()
		{
			dataGridViewTickets.Columns["Id"].Visible = false;
			dataGridViewTickets.Columns["FlightID"].Visible = false;
			dataGridViewTickets.Columns["PassengerID"].Visible = false;
			dataGridViewTickets.Columns["ArrivalTime"].Visible = false;
			dataGridViewTickets.Columns["SeatID"].Visible = false;
			dataGridViewTickets.Columns["DepartureAirport"].HeaderText = "Отправка из";
			dataGridViewTickets.Columns["ArrivalAirport"].HeaderText = "Прибытие в";
			dataGridViewTickets.Columns["DepartureTime"].HeaderText = "Время вылета";
			// dataGridViewTickets.Columns["ArrivalTime"].HeaderText = "Время прибытия";
			dataGridViewTickets.Columns["seat"].HeaderText = "Место";
			dataGridViewTickets.Columns["Model"].HeaderText = "Самолёт";
			dataGridViewTickets.Columns["TotalPrice"].HeaderText = "Стоимость билета";
			dataGridViewTickets.Columns["TotalPrice"].DefaultCellStyle.Format = "C2";
			dataGridViewTickets.Columns["TotalPrice"].DefaultCellStyle.FormatProvider = new CultureInfo("ru-RU");
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			try
			{
				PassengerAddView add = new PassengerAddView();

				if (add.ShowDialog() == DialogResult.OK)
				{
					string FirstName = add.FirstName;
					string LastName = add.LastName;
					string MiddleName = add.MiddleName;
					DateTime DateOfBirth = add.DateOfBirth;
					string PassportNumber = add.PassportNumber;

					using (SQLiteConnection connection = new SQLiteConnection(connectionString))
					{
						connection.Open();
						using (SQLiteCommand cmd = new SQLiteCommand(
							"INSERT INTO Passengers (FirstName, LastName, MiddleName, DateOfBirth, PassportNumber) " +
							"VALUES (@FirstName, @LastName, @MiddleName, @DateOfBirth, @PassportNumber)",
							connection))
						{
							cmd.Parameters.AddWithValue("@FirstName", FirstName);
							cmd.Parameters.AddWithValue("@LastName", LastName);
							cmd.Parameters.AddWithValue("@MiddleName", MiddleName);
							cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
							cmd.Parameters.AddWithValue("@PassportNumber", PassportNumber);

							int rowsUpdated = cmd.ExecuteNonQuery();
							if (rowsUpdated > 0)
							{
								LoadPassengers();
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
				if (dataGridViewPassengers.CurrentRow == null)
				{
					throw new Exception("не выбран пассажир");
				}
				int id = Convert.ToInt32(dataGridViewPassengers.CurrentRow.Cells["Id"].Value);
				string FirstName = dataGridViewPassengers.CurrentRow.Cells["FirstName"].Value.ToString();
				string LastName = dataGridViewPassengers.CurrentRow.Cells["LastName"].Value.ToString();
				string MiddleName = dataGridViewPassengers.CurrentRow.Cells["MiddleName"].Value.ToString();
				DateTime DateOfBirth = Convert.ToDateTime(dataGridViewPassengers.CurrentRow.Cells["DateOfBirth"].Value);
				string PassportNumber = dataGridViewPassengers.CurrentRow.Cells["PassportNumber"].Value.ToString();

				PassengerAddView add = new PassengerAddView(FirstName, LastName, MiddleName, DateOfBirth, PassportNumber);

				if (add.ShowDialog() == DialogResult.OK)
				{
					FirstName = add.FirstName;
					LastName = add.LastName;
					MiddleName = add.MiddleName;
					DateOfBirth = add.DateOfBirth;
					PassportNumber = add.PassportNumber;

					using (SQLiteConnection connection = new SQLiteConnection(connectionString))
					{
						connection.Open();
						using (SQLiteCommand cmd = new SQLiteCommand(
							"UPDATE Passengers SET FirstName = @FirstName, LastName = @LastName, MiddleName = @MiddleName, " +
							"DateOfBirth = @DateOfBirth, PassportNumber = @PassportNumber WHERE Id = @id", connection))
						{
							cmd.Parameters.AddWithValue("@FirstName", FirstName);
							cmd.Parameters.AddWithValue("@LastName", LastName);
							cmd.Parameters.AddWithValue("@MiddleName", MiddleName);
							cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
							cmd.Parameters.AddWithValue("@PassportNumber", PassportNumber);
							cmd.Parameters.AddWithValue("@id", id);
							int rowsUpdated = cmd.ExecuteNonQuery();
							if (rowsUpdated > 0)
							{
								LoadPassengers();
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
				if (dataGridViewPassengers.CurrentRow == null)
				{
					throw new Exception("не выбран пассажир");
				}
				DialogResult res = MessageBox.Show("Точно удалить пассажира?", "Предупреждение", MessageBoxButtons.OKCancel);
				if (res == DialogResult.OK)
				{
					int id = Convert.ToInt32(dataGridViewPassengers.CurrentRow.Cells["Id"].Value);

					using (SQLiteConnection connection = new SQLiteConnection(connectionString))
					{
						connection.Open();
						using (SQLiteCommand cmd = new SQLiteCommand("DELETE FROM Passengers WHERE Id = @id", connection))
						{
							cmd.Parameters.AddWithValue("@id", id);
							cmd.ExecuteNonQuery();
						}
					}
					LoadPassengers();
				}				
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "ошибка", MessageBoxButtons.OK);
			}
		}

		private void buttonAddTicket_Click(object sender, EventArgs e)
		{
			try
			{
				if (dataGridViewPassengers.CurrentRow == null)
				{
					throw new Exception("Не выбран пассажир для регистрации на рейс");
				}

				int PassengerID = Convert.ToInt32(dataGridViewPassengers.CurrentRow.Cells["Id"].Value);
				
				TicketAddView add = new TicketAddView(connectionString);

				if (add.ShowDialog() == DialogResult.OK)
				{
					int FlightID = add.FlightsID;
					int RowNumber = add.SelectedRowNumber;
					int SeatID = add.SelectedSeatID;

					using (SQLiteConnection connection = new SQLiteConnection(connectionString))
					{
						connection.Open();

						using (SQLiteCommand cmd = new SQLiteCommand(
							"INSERT INTO Tickets (FlightID, PassengerID, RowNumber, SeatID) " +
							"VALUES (@FlightID, @PassengerID, @RowNumber, @SeatID)", connection))
						{
							cmd.Parameters.AddWithValue("@FlightID", FlightID);
							cmd.Parameters.AddWithValue("@PassengerID", PassengerID);
							cmd.Parameters.AddWithValue("@RowNumber", RowNumber);
							cmd.Parameters.AddWithValue("@SeatID", SeatID);

							cmd.ExecuteNonQuery();
						}
						LoadPassengers();
					}
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
			}
		}
	}
}
