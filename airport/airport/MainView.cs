using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airport
{
	public partial class MainView : Form
	{
		public MainView()
		{
			InitializeComponent();
		}

		private void buttonAirlines_Click(object sender, EventArgs e)
		{
			new AirlinesView().Show();
		}

		private void buttonPlanes_Click(object sender, EventArgs e)
		{
			new PlanesView().Show();
		}

		private void buttonPassengers_Click(object sender, EventArgs e)
		{
			new TicketsView().Show();
		}
	}
}
