using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
	/// <summary>
	/// Класс ввода данных для поиска
	/// </summary>
	public partial class SearchForm : Form
	{
		/// <summary>
		/// Конструктор
		/// </summary>
		public SearchForm()
		{
			InitializeComponent();
			_fromTimeUnits.SelectedIndex = 1;
			_toTimeUnits.SelectedIndex = 1;
		}

		/// <summary>
		/// Свойство - имя
		/// </summary>
		public string FirstName
		{
			get
			{
				return _firstNameText.Text;
			}
		}

		/// <summary>
		/// Свойство - отчество
		/// </summary>
		public string SecondName
		{
			get
			{
				return _secondNameText.Text;
			}
		}

		/// <summary>
		/// Свойство - фамилия
		/// </summary>
		public string LastName
		{
			get
			{
				return _lastNameText.Text;
			}
		}

		/// <summary>
		/// Минимальный размер зарплаты, от которого происходит поиск
		/// </summary>
		public double SalaryFrom
		{
			get
			{
				if (_salaryFrom.Text.Trim() == "")
					return 0;
				else
					return double.Parse(_salaryFrom.Text);
			}
		}

		/// <summary>
		/// Максимальный размер зарплаты, до которого происходит поиск
		/// </summary>
		public double SalaryTo
		{
			get
			{
				if (_salaryTo.Text.Trim() == "")
					return 0;
				else
					return double.Parse(_salaryTo.Text);
			}
		}

		/// <summary>
		/// Минимальное отработанное время, от которого происходит поиск
		/// </summary>
		public TimeSpan TimeWorkedFrom
		{
			get
			{
				int time = 0;
        if (_timeWorkedFrom.Text.Trim() != "")
					time = int.Parse(_timeWorkedFrom.Text);
				if (_fromTimeUnits.SelectedIndex == 0)
					return new TimeSpan(time, 0, 0);
				else
					return new TimeSpan(time, 0, 0, 0);
			}
		}

		/// <summary>
		/// Максимальное отработанное время, до которого происходит поиск
		/// </summary>
		public TimeSpan TimeWorkedTo
		{
			get
			{
				int time = 0;
				if (_timeWorkedTo.Text.Trim() != "")
					time = int.Parse(_timeWorkedTo.Text);
				if (_toTimeUnits.SelectedIndex == 0)
					return new TimeSpan(time, 0, 0);
				else
					return new TimeSpan(time, 0, 0, 0);
			}
		}

		/// <summary>
		/// Кнопка OK
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OkClick(object sender, EventArgs e)
		{
			TextBox textBox = _timeWorkedFrom;
			try
			{
				if (textBox.Text.Trim() != "")
					int.Parse(textBox.Text);
				textBox = _timeWorkedTo;
				if (textBox.Text.Trim() != "")
					int.Parse(textBox.Text);
				textBox = _salaryFrom;
				if (textBox.Text.Trim() != "")
					double.Parse(textBox.Text);
				textBox = _salaryTo;
				if (textBox.Text.Trim() != "")
					double.Parse(textBox.Text);
			}
			catch(Exception exception)
			{
				textBox.Select();
				textBox.SelectAll();
				MessageBox.Show(exception.Message +
					"\r\nИсправьте данные в выделенной строке ввода.");
				DialogResult = DialogResult.None;
			}
    }
	}
}
