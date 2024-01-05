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
	public partial class FlightsAddView : Form
	{
		public FlightsAddView()
		{
			InitializeComponent();			

			buttonOk.Text = "добавить";
			buttonOk.DialogResult = DialogResult.OK;
			this.AcceptButton = buttonOk;
		}


	}
}
