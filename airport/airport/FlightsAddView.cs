﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace airport
{
	public partial class FlightsAddView : Form
	{
		string connectionString;
		public FlightsAddView(string connectionString)
		{
			this.connectionString = connectionString;
			InitializeComponent();
			AddDepartureAirportMap();
			AddArrivalAirportMap();

			buttonOk.Text = "добавить";
			buttonOk.DialogResult = DialogResult.OK;
			this.AcceptButton = buttonOk;
		}

		public string DepartureTime => $"{departureDay.Value:yyyy-MM-dd} {departureTime.Value:HH:mm:ss}";
		public string ArrivalTime => $"{arrivalDay.Value:yyyy-MM-dd} {arrivalTime.Value:HH:mm:ss}";
		public int idDeparture => comboBoxDepartureAirport.SelectedItem != null ? (int)comboBoxDepartureAirport.SelectedValue : -1;
		public int idArrival => comboBoxArrivalAirport.SelectedItem != null ? (int)comboBoxArrivalAirport.SelectedValue : -1;

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked)
			{
				comboBoxDepartureAirport.Enabled = false;
				textBoxDepartureAirport.Enabled = false;
			} else
			{
				comboBoxDepartureAirport.Enabled = true;
				textBoxDepartureAirport.Enabled = true;
			}
		}

		private void AddDepartureAirportMap()
		{
			using (SQLiteConnection connection = new SQLiteConnection(connectionString))
			{
				connection.Open();

				string query = "SELECT id, City || ' - ' || Name || ' (' || Code || ')' AS airport FROM Airports";

				Dictionary<int, string> airports = new Dictionary<int, string>();

				using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
				{
					using (SQLiteDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							int airports_id = Convert.ToInt32(reader["id"]);
							string airports_name = reader["airport"].ToString();

							airports.Add(airports_id, airports_name);
						}
					}
				}
				// сортировка данных в словаре
				var sorted = airports.OrderBy(x => x.Value).ToDictionary(pair => pair.Key, pair => pair.Value);

				// BindingSource для обновления данных ComboBox при изменении текста в TextBox
				BindingSource bindingSource = new BindingSource(sorted, null);

				comboBoxDepartureAirport.DataSource = bindingSource;
				comboBoxDepartureAirport.DisplayMember = "Value";
				comboBoxDepartureAirport.ValueMember = "Key";
				comboBoxDepartureAirport.DropDownStyle = ComboBoxStyle.DropDownList;

				// добавление обработчика события TextChanged для TextBox
				textBoxDepartureAirport.TextChanged += (sender, e) =>
				{
					// фильтрация данных в ComboBox на основе введенного текста в TextBox
					string searchText = textBoxDepartureAirport.Text.ToLower();
					var filtered = sorted.Where(x => x.Value.ToLower().Contains(searchText)).ToDictionary(pair => pair.Key, pair => pair.Value);
					bindingSource.DataSource = new BindingSource(filtered, null);
				};

				// установка выбранного элемента с id равным 1
				comboBoxDepartureAirport.SelectedIndex = 1;
				
			}
		}

		private void AddArrivalAirportMap()
		{
			using (SQLiteConnection connection = new SQLiteConnection(connectionString))
			{
				connection.Open();

				string query = "SELECT id, City || ' - ' || Name || ' (' || Code || ')' AS airport FROM Airports";

				Dictionary<int, string> airports = new Dictionary<int, string>();

				using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
				{
					using (SQLiteDataReader reader = cmd.ExecuteReader())
					{
						while (reader.Read())
						{
							int airports_id = Convert.ToInt32(reader["id"]);
							string airports_name = reader["airport"].ToString();

							airports.Add(airports_id, airports_name);
						}
					}
				}
				// сортировка данных в словаре
				var sorted = airports.OrderBy(x => x.Value).ToDictionary(pair => pair.Key, pair => pair.Value);

				// BindingSource для обновления данных ComboBox при изменении текста в TextBox
				BindingSource bindingSource = new BindingSource(sorted, null);

				comboBoxArrivalAirport.DataSource = bindingSource;
				comboBoxArrivalAirport.DisplayMember = "Value";
				comboBoxArrivalAirport.ValueMember = "Key";
				comboBoxArrivalAirport.DropDownStyle = ComboBoxStyle.DropDownList;

				// добавление обработчика события TextChanged для TextBox
				textBoxArrivalAirport.TextChanged += (sender, e) =>
				{
					// фильтрация данных в ComboBox на основе введенного текста в TextBox
					string searchText = textBoxArrivalAirport.Text.ToLower();
					var filtered = sorted.Where(x => x.Value.ToLower().Contains(searchText)).ToDictionary(pair => pair.Key, pair => pair.Value);
					bindingSource.DataSource = new BindingSource(filtered, null);
				};
			}
		}
	}
}
