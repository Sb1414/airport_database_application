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
	public partial class AirportAddView : Form
	{
		public AirportAddView()
		{
			InitializeComponent();

			textBoxCity.Text = "Город";
			textBoxCity.ForeColor = Color.FromArgb(127, 128, 132);
			textBoxName.Text = "Название";
			textBoxName.ForeColor = Color.FromArgb(127, 128, 132);
			textBoxCode.Text = "Код";
			textBoxCode.ForeColor = Color.FromArgb(127, 128, 132);

			buttonOk.Text = "добавить";
			buttonOk.DialogResult = DialogResult.OK;
			this.AcceptButton = buttonOk;
		}

		public string City => textBoxCity.Text;
		public string Code => textBoxCode.Text;
		public string AirName => textBoxName.Text;

		private void textBoxCity_Enter(object sender, EventArgs e)
		{
			if (textBoxCity.Text == "Город")
			{
				textBoxCity.Text = "";
				textBoxCity.ForeColor = Color.FromArgb(230, 179, 51);
			}
		}

		private void textBoxName_Enter(object sender, EventArgs e)
		{
			if (textBoxName.Text == "Название")
			{
				textBoxName.Text = "";
				textBoxName.ForeColor = Color.FromArgb(230, 179, 51);
			}
		}

		private void textBoxCode_Enter(object sender, EventArgs e)
		{
			if (textBoxCode.Text == "Код")
			{
				textBoxCode.Text = "";
				textBoxCode.ForeColor = Color.FromArgb(230, 179, 51);
			}
		}

		private void textBoxCity_Leave(object sender, EventArgs e)
		{
			if (textBoxCity.Text == "")
			{
				textBoxCity.Text = "Город";
				textBoxCity.ForeColor = Color.FromArgb(127, 128, 132);
			}
		}

		private void textBoxName_Leave(object sender, EventArgs e)
		{
			if (textBoxName.Text == "")
			{
				textBoxName.Text = "Название";
				textBoxName.ForeColor = Color.FromArgb(127, 128, 132);
			}
		}

		private void textBoxCode_Leave(object sender, EventArgs e)
		{
			if (textBoxCode.Text == "")
			{
				textBoxCode.Text = "Код";
				textBoxCode.ForeColor = Color.FromArgb(127, 128, 132);
			}
		}

		private void textBoxCity_KeyPress(object sender, KeyPressEventArgs e)
		{
			// проверка на буквы, дефис и пробел
			if (!char.IsLetter(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != ' ' && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}

			// автоматическое преобразование первой буквы в заглавную
			if (char.IsLower(e.KeyChar) && textBoxCity.SelectionStart == 0)
			{
				if (textBoxCity.Text.Length == 0)
				{
					textBoxCity.Text = char.ToUpper(e.KeyChar).ToString();
				}
				else
				{
					textBoxCity.Text = char.ToUpper(e.KeyChar) + textBoxCity.Text.Substring(1);
				}

				textBoxCity.SelectionStart = 1;
				e.Handled = true;
			}
		}

		private void textBoxCode_TextChanged(object sender, EventArgs e)
		{
			// ограничение длины ввода в textBoxCode до 3 символов
			if (textBoxCode.Text.Length > 3)
			{
				textBoxCode.Text = textBoxCode.Text.Substring(0, 3);
				textBoxCode.SelectionStart = textBoxCode.Text.Length;
			}
		}

		private void textBoxCode_KeyPress(object sender, KeyPressEventArgs e)
		{
			// проверка на латинские буквы и преобразование в заглавные
			if (char.IsLetter(e.KeyChar))
			{
				textBoxCode.Text += char.ToUpper(e.KeyChar);
				textBoxCode.SelectionStart = textBoxCode.Text.Length;
				e.Handled = true;
			}
			else if (!char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxCity.Text) || textBoxCity.Text == "Город" ||
			string.IsNullOrWhiteSpace(textBoxName.Text) || textBoxName.Text == "Название" ||
			string.IsNullOrWhiteSpace(textBoxCode.Text) || textBoxCode.Text == "Код")
			{
				MessageBox.Show("Поля заполнены некорректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.DialogResult = DialogResult.None; // предотвращение срабатывания DialogResult.OK
			}
		}

		
	}
}
