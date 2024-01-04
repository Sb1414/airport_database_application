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
	public partial class PlanesAddView : Form
	{
		public PlanesAddView()
		{
			InitializeComponent();
			textBoxModel.Text = "Модель";
			textBoxModel.ForeColor = Color.FromArgb(127, 128, 132);
			textBoxCapacity.Text = "Вместимость";
			textBoxCapacity.ForeColor = Color.FromArgb(127, 128, 132);

			buttonOk.Text = "добавить";
			buttonOk.DialogResult = DialogResult.OK;
			this.AcceptButton = buttonOk;
		}

		public PlanesAddView(string model, int capacity)
		{
			InitializeComponent();

			textBoxModel.Text = model;
			textBoxCapacity.Text = capacity.ToString();			
			textBoxModel.ForeColor = Color.FromArgb(230, 179, 51);
			textBoxCapacity.ForeColor = Color.FromArgb(230, 179, 51);

			buttonOk.Text = "обновить";
			buttonOk.DialogResult = DialogResult.OK;
			this.AcceptButton = buttonOk;
		}

		public string Model => textBoxModel.Text;
		public int Capacity => Convert.ToInt32(textBoxCapacity.Text);

		private void textBoxModel_Enter(object sender, EventArgs e)
		{
			if (textBoxModel.Text == "Модель")
			{
				textBoxModel.Text = "";
				textBoxModel.ForeColor = Color.FromArgb(230, 179, 51);
			}
		}

		private void textBoxCapacity_Enter(object sender, EventArgs e)
		{
			if (textBoxCapacity.Text == "Вместимость")
			{
				textBoxCapacity.Text = "";
				textBoxCapacity.ForeColor = Color.FromArgb(230, 179, 51);
			}
		}

		private void textBoxModel_Leave(object sender, EventArgs e)
		{
			if (textBoxModel.Text == "")
			{
				textBoxModel.Text = "Модель";
				textBoxModel.ForeColor = Color.FromArgb(127, 128, 132);
			}
		}

		private void textBoxCapacity_Leave(object sender, EventArgs e)
		{
			if (textBoxCapacity.Text == "")
			{
				textBoxCapacity.Text = "Вместимость";
				textBoxCapacity.ForeColor = Color.FromArgb(127, 128, 132);
			}
		}

		private void textBoxCapacity_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
			{
				e.Handled = true;
			}
		}

		private void buttonOk_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(textBoxCapacity.Text) || textBoxCapacity.Text == "Вместимость" ||
			string.IsNullOrWhiteSpace(textBoxModel.Text) || textBoxModel.Text == "Модель")
			{
				MessageBox.Show("Поля заполнены некорректно", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.DialogResult = DialogResult.None; // предотвращение срабатывания DialogResult.OK
			}
		}
	}
}
