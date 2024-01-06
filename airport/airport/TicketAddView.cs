using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace airport
{
	public partial class TicketAddView : Form
	{
		string connectionString;
		private int selectedFlightCapacity;
		public TicketAddView(string connectionString)
		{
			this.connectionString = connectionString;
			InitializeComponent();
			FlightsTable();

			buttonOk.Text = "добавить";
			buttonOk.DialogResult = DialogResult.OK;
			this.AcceptButton = buttonOk;
		}

		public int FlightsID
		{
			get
			{
				if (dataGridView1.CurrentRow != null)
				{
					return Convert.ToInt32(dataGridView1.CurrentRow.Cells["id"].Value);
				} else
				{
					return 1;
				}
			}
		}
		public int SelectedRowNumber => Convert.ToInt32(numericUpDown1.Value);
		public int SelectedSeatID
		{
			get
			{
				DataRowView selectedDataRow = comboBoxSeats.SelectedItem as DataRowView;

				if (selectedDataRow != null)
				{
					object idValue = selectedDataRow.Row["Id"];

					if (idValue != null)
					{
						return Convert.ToInt32(idValue);
					}
				}

				return -1;
			}
		}



		private void FlightsTable()
		{
			using (SQLiteConnection connection =
					   new SQLiteConnection(connectionString))
			{
				connection.Open();

				string query = @"SELECT Flights.Id, A1.City || ' (' || A1.Code || ')' AS DepartureAirport,
								   A2.City || ' (' || A2.Code || ')' AS ArrivalAirport, DepartureTime, ArrivalTime, Capacity
								   FROM Flights
								JOIN Airports A2 on A2.Id = Flights.ArrivalAirportID
								JOIN Airports A1 on A1.Id = Flights.DepartureAirportID
								JOIN Planes P on P.Id = Flights.PlaneID";

				using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
				{
					using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
					{
						DataTable dt = new DataTable();
						adapter.Fill(dt);
						dataGridView1.DataSource = dt;
					}
					colls();
				}
			}
		}

		private void colls()
		{
			dataGridView1.Columns["Id"].Visible = false;
			dataGridView1.Columns["Capacity"].Visible = false;
			dataGridView1.Columns["DepartureAirport"].HeaderText = "Отправка из";
			dataGridView1.Columns["ArrivalAirport"].HeaderText = "Прибытие в";
			dataGridView1.Columns["DepartureTime"].HeaderText = "Время вылета";
			dataGridView1.Columns["ArrivalTime"].HeaderText = "Время прибытия";
		}

		private void textBoxSearch_TextChanged(object sender, EventArgs e)
		{
			try
			{
				DataView dv = ((DataTable)dataGridView1.DataSource).DefaultView;
				dv.RowFilter = $"DepartureAirport LIKE '%{textBoxSearch.Text}%' OR ArrivalAirport LIKE '%{textBoxSearch.Text}%'";
			}
			catch (Exception)
			{
				FlightsTable();
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			// проверка наличия выбранной строки в dataGridView1
			if (dataGridView1.CurrentRow != null)
			{
				// получение количества мест в самолете выбранного рейса
				selectedFlightCapacity = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Capacity"].Value);
				// обновление ограничений ввода 
				UpdateRowConstraints();
				// выполнение запроса для получения свободных мест в комбобоксе
				UpdateSeatsComboBox();
			}
		}

		private void UpdateRowConstraints()
		{
			// установка максимального значения numericUpDown1
			numericUpDown1.Maximum = Math.Max(1, selectedFlightCapacity / 6);
			// установка минимального значения numericUpDown1
			numericUpDown1.Minimum = 1;
			// обнуление значения numericUpDown1
			numericUpDown1.Value = 1;
		}

		private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
		{
		}

		private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			// выполнение запроса для получения свободных мест в комбобоксе
			UpdateSeatsComboBox();
		}

		private void UpdateSeatsComboBox()
		{
			// проверка наличия выбранной строки в dataGridView1 и значения в numericUpDown1
			if (dataGridView1.CurrentRow != null && numericUpDown1.Value > 0)
			{
				int selectedRowNumber = Convert.ToInt32(numericUpDown1.Value);
				int selectedFlightID = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);

				// выполнение запроса для получения свободных мест в комбобоксе
				string query = @"SELECT SC.Id, SC.NameSeat FROM SeatsCategories SC
								LEFT JOIN Tickets T ON SC.Id = T.SeatID AND T.RowNumber = @RowNumber AND T.FlightID = @FlightID
								WHERE T.Id IS NULL";

				using (SQLiteConnection connection = new SQLiteConnection(connectionString))
				{
					connection.Open();

					using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
					{
						cmd.Parameters.AddWithValue("@RowNumber", selectedRowNumber);
						cmd.Parameters.AddWithValue("@FlightID", selectedFlightID);

						using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
						{
							DataTable dt = new DataTable();
							adapter.Fill(dt);

							// заполнение комбобокса данными
							comboBoxSeats.DisplayMember = "NameSeat";
							comboBoxSeats.ValueMember = "Id";
							comboBoxSeats.DataSource = dt;
							comboBoxSeats.DropDownStyle = ComboBoxStyle.DropDownList;
						}
					}
				}
			}
		}
	}
}
