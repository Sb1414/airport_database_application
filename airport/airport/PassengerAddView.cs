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
	public partial class PassengerAddView : Form
	{
		public PassengerAddView()
		{
			InitializeComponent();
			textBoxLastName.Text = "Фамилия";
			textBoxLastName.ForeColor = Color.FromArgb(127, 128, 132);
			textBoxName.Text = "Имя";
			textBoxName.ForeColor = Color.FromArgb(127, 128, 132);
			textBoxMiddleName.Text = "Отчество";
			textBoxMiddleName.ForeColor = Color.FromArgb(127, 128, 132);

			buttonOk.Text = "добавить";
			buttonOk.DialogResult = DialogResult.OK;
			this.AcceptButton = buttonOk;
		}

		public PassengerAddView(string lastName, string name, string middleName, DateTime dateTime, string passport)
		{
			InitializeComponent();

			textBoxLastName.Text = lastName;
			textBoxName.Text = name;
			textBoxMiddleName.Text = middleName;
			textBoxPassportNumber.Text = passport;
			textBoxLastName.ForeColor = Color.Black;
			textBoxName.ForeColor = Color.Black;
			textBoxMiddleName.ForeColor = Color.Black;
			textBoxPassportNumber.ForeColor = Color.Black;
			dateTimePicker1.Value = dateTime;

			buttonOk.Text = "обновить";
			buttonOk.DialogResult = DialogResult.OK;
			this.AcceptButton = buttonOk;
		}

		public string LastName => textBoxLastName.Text;
		public string MiddleName => textBoxMiddleName.Text;
		public string FirstName => textBoxName.Text;
		public DateTime DateOfBirth => dateTimePicker1.Value;
		public string PassportNumber => textBoxPassportNumber.Text;

		private void textBoxCity_Enter(object sender, EventArgs e)
		{
			if (textBoxLastName.Text == "Фамилия")
			{
				textBoxLastName.Text = "";
				textBoxLastName.ForeColor = Color.Black;
			}
		}

		private void textBoxName_Enter(object sender, EventArgs e)
		{
			if (textBoxName.Text == "Имя")
			{
				textBoxName.Text = "";
				textBoxName.ForeColor = Color.Black;
			}
		}

		private void textBoxCode_Enter(object sender, EventArgs e)
		{
			if (textBoxMiddleName.Text == "Отчество")
			{
				textBoxMiddleName.Text = "";
				textBoxMiddleName.ForeColor = Color.Black;
			}
		}

		private void textBoxCity_Leave(object sender, EventArgs e)
		{
			if (textBoxLastName.Text == "")
			{
				textBoxLastName.Text = "Фамилия";
				textBoxLastName.ForeColor = Color.FromArgb(127, 128, 132);
			}
		}

		private void textBoxName_Leave(object sender, EventArgs e)
		{
			if (textBoxName.Text == "")
			{
				textBoxName.Text = "Имя";
				textBoxName.ForeColor = Color.FromArgb(127, 128, 132);
			}
		}

		private void textBoxCode_Leave(object sender, EventArgs e)
		{
			if (textBoxMiddleName.Text == "")
			{
				textBoxMiddleName.Text = "Отчество";
				textBoxMiddleName.ForeColor = Color.FromArgb(127, 128, 132);
			}
		}

		private void textBoxPassportNumber_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
		}

		private void textBoxPassportNumber_TextChanged(object sender, EventArgs e)
		{
			// проверка на максимальную длину
			if (textBoxPassportNumber.Text.Length > 10)
			{
				textBoxPassportNumber.Text = textBoxPassportNumber.Text.Substring(0, 10);
				textBoxPassportNumber.SelectionStart = 10;
			}
		}
	}
}
