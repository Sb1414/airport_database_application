using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airport
{
	public partial class AirlinesView : Form
	{
		string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

		public AirlinesView()
		{
			InitializeComponent();
			LoadAirlines();
		}

		private void LoadAirlines()
		{
			using (SQLiteConnection connection = new SQLiteConnection(connectionString))
			{
				connection.Open();

				string query = "SELECT * FROM Airlines";

				using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
				{
					using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd))
					{
						DataTable dt = new DataTable();
						adapter.Fill(dt);
						dataGridViewAirlines.DataSource = dt;
					}
					dataGridViewAirlines.Columns["Id"].Visible = false;
					dataGridViewAirlines.Columns["Name"].HeaderText = "Название";
					dataGridViewAirlines.Columns["Code"].HeaderText = "Код";
				}
			}
			/*if (dataGridViewAirlines.Rows.Count > 0)
			{
				dataGridViewAirlines_CellClick(dataGridViewAirlines, new DataGridViewCellEventArgs(0, 0));
			}*/
		}
	}
}
