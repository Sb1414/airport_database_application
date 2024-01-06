using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airport
{
	public partial class OutView : Form
	{
		string conn;
		public OutView(int id, string connect)
		{
			this.conn = connect;
			InitializeComponent();
			LoadTicketData(id);
		}

		private void LoadTicketData(int ticketId)
		{
			using (SQLiteConnection connection = new SQLiteConnection(conn))
			{
				connection.Open();

				string query = @"SELECT 
                            P.FirstName || ' ' || P.LastName || ' ' || P.MiddleName AS PassengerName,
                            P.PassportNumber,
                            A1.Code AS DepartureAirportCode,
							A1.City AS DepartureCity,
							A2.Code AS ArrivalAirportCode,
                            A2.City AS ArrivalCity,
                            F.DepartureTime,
                            strftime('%Y-%m-%d %H:%M:%S', datetime(F.DepartureTime, '-20 minutes')) AS AdjustedDepartureTime,
							RowNumber || SC.NameSeat AS SeatName,
                            P2.Model AS PlaneModel,
                            F.Id AS FlightID,
                            T.Id AS TicketID
                        FROM Tickets T
                        JOIN Passengers P ON P.Id = T.PassengerID
                        JOIN Flights F ON F.Id = T.FlightID
                        JOIN Airports A1 ON A1.Id = F.DepartureAirportID
                        JOIN Airports A2 ON A2.Id = F.ArrivalAirportID
                        JOIN Planes P2 ON P2.Id = F.PlaneID
                        JOIN SeatsCategories SC ON SC.Id = T.SeatID
                        WHERE T.Id = @TicketID";

				using (SQLiteCommand cmd = new SQLiteCommand(query, connection))
				{
					cmd.Parameters.AddWithValue("@TicketID", ticketId);

					using (SQLiteDataReader reader = cmd.ExecuteReader())
					{
						if (reader.Read())
						{
							string departureCityCode = $"{reader["DepartureCity"]} / {reader["DepartureAirportCode"]}";
							string arrivalCityCode = $"{reader["ArrivalCity"]} / {reader["ArrivalAirportCode"]}";
							string plane = $"{reader["FlightID"]}-{reader["PlaneModel"]}";

							labelDepartureCityCode.Text = departureCityCode;
							labelArrivalCityCode.Text = arrivalCityCode;
							labelPassengerName.Text = reader["PassengerName"].ToString();
							labelPassportNumber.Text = reader["PassportNumber"].ToString();							
							labelDepartureTime.Text = Convert.ToDateTime(reader["DepartureTime"]).ToString("yyyy-MM-dd HH:mm:ss");
							labelArrivalTime.Text = Convert.ToDateTime(reader["AdjustedDepartureTime"]).ToString("HH:mm");
							labelSeat.Text = reader["SeatName"].ToString();
							labelFlightID.Text = plane;
							labelTicketID.Text = reader["TicketID"].ToString();
							label3.Text = "Э";
						}
					}
				}
			}
		}

	}
}
