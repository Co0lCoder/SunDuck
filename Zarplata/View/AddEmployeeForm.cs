using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Zarplata;

namespace View
{
	/// <summary>
	/// Форма добавления сотрудника
	/// </summary>
	public partial class AddEmployeeForm : Form
	{
		/// <summary>
		/// Данные сотрудника - результат работы формы
		/// </summary>
		public IEmployee Employee = null;

		/// <summary>
		/// Конструктор
		/// </summary>
		public AddEmployeeForm()
		{
			InitializeComponent();
			ScaleCheckedChanged(null, null);
		}

		/// <summary>
		/// Выбран тип оплаты - почасовая
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void HourlyCheckedChanged(object sender, EventArgs e)
		{
			SetHourlyPaymentView();
		}

		/// <summary>
		/// Настройка формы для сотрудника с почасовой оплатой
		/// </summary>
		protected virtual void SetHourlyPaymentView()
		{
			_salaryRate.Text = "Payment for hour";
			_timeUnits.Text = "hours";

			_additional.Visible = false;
			_additionalText.Visible = false;
			_increase.Visible = false;
			_increaseText.Visible = false;
			_workTime.Visible = false;
			_workTimeText.Visible = false;
			_mrot.Visible = false;
			_mrotText.Visible = false;
		}

	/// <summary>
	/// Выбран тип оплаты - по окладу
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void ScaleCheckedChanged(object sender, EventArgs e)
		{
			SetSalaryScaleView();
		}

		/// <summary>
		/// Настройка формы для сотрудника с оплатой по окладу
		/// </summary>
		protected virtual void SetSalaryScaleView()
		{
			_salaryRate.Text = "Salary scale";
			_timeUnits.Text = "days";

			_additional.Visible = true;
			_additionalText.Visible = true;
			_workTime.Visible = true;
			_workTimeText.Visible = true;
			_increase.Visible = false;
			_increaseText.Visible = false;
			_mrot.Visible = false;
			_mrotText.Visible = false;
		}

		/// <summary>
		/// Выбран тип оплаты - по ставке
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RateCheckedChanged(object sender, EventArgs e)
		{
			SetRateView();
		}

		/// <summary>
		/// Настройка формы для сотрудника с оплатой по ставке
		/// </summary>
		protected virtual void SetRateView()
		{
			_salaryRate.Text = "Rate";
			_timeUnits.Text = "days";

			_additional.Visible = true;
			_additionalText.Visible = true;
			_workTime.Visible = true;
			_workTimeText.Visible = true;
			_increase.Visible = true;
			_increaseText.Visible = true;
			_mrot.Visible = true;
			_mrotText.Visible = true;
			_mrotText.Text = RatePaymentEmployee.Mrot.ToString();
		}

		/// <summary>
		/// Кнопка Ok
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OkClick(object sender, EventArgs e)
		{
			if (_hourly.Checked)
				Employee = CreateHourlyPaymentEmployee();
			else if (_rate.Checked)
				Employee = CreateRatePaymentEmployee();
			else
				Employee = CreateSalaryScaleEmployee();
			if (Employee == null)
				DialogResult = DialogResult.None;
		}

		/// <summary>
		/// Получение ФИО из формы
		/// </summary>
		/// <param name="employee"></param>
		/// <param name="textBox"></param>
		private void GetName(IEmployee employee, out TextBox textBox)
		{
			textBox = _firstNameText;
			employee.Name = textBox.Text;
			textBox = _secondNameText;
			employee.SecondName = textBox.Text;
			textBox = _lastNameText;
			employee.LastName = textBox.Text;
		}

		/// <summary>
		/// Создание сотрудника с почасовой оплатой
		/// </summary>
		/// <returns></returns>
		private HourlyPaymentEmployee CreateHourlyPaymentEmployee()
		{
			HourlyPaymentEmployee employee = new HourlyPaymentEmployee();
			TextBox textBox = null;
			try
			{
				GetName(employee, out textBox);
				textBox = _rateText;
				employee.HourPayment = double.Parse(_rateText.Text);
				textBox = _timeWorkedText;
				int hours = int.Parse(_timeWorkedText.Text);
				employee.TimeWorked = new TimeSpan(hours, 0, 0);
			}
			catch(Exception exception)
			{
				textBox.Select();
				textBox.SelectAll();
				MessageBox.Show(exception.Message + 
					"\r\nИсправьте данные в выделенной строке ввода.");
				employee = null;
			}
			return employee;
		}

		/// <summary>
		/// Создание сотрудника с оплатой по окладу
		/// </summary>
		/// <returns></returns>
		private SalaryScaleEmployee CreateSalaryScaleEmployee()
		{
			SalaryScaleEmployee employee = new SalaryScaleEmployee();
			TextBox textBox = null;
			try
			{
				GetName(employee, out textBox);
				textBox = _rateText;
				employee.SalaryScale = double.Parse(_rateText.Text);
				textBox = _timeWorkedText;
				int days = int.Parse(_timeWorkedText.Text);
				employee.TimeWorked = new TimeSpan(days, 0, 0, 0);
				textBox = _workTimeText;
				days = int.Parse(textBox.Text);
				employee.WorkDays = days;
				textBox = _additionalText;
				employee.AdditionalPayment = double.Parse(textBox.Text);
			}
			catch (Exception exception)
			{
				textBox.Select();
				textBox.SelectAll();
				MessageBox.Show(exception.Message +
					"\r\nИсправьте данные в выделенной строке ввода.");
				employee = null;
			}
			return employee;
		}
		
		/// <summary>
		/// Создание сотрудника с оплатой по ставке
		/// </summary>
		/// <returns></returns>
		private RatePaymentEmployee CreateRatePaymentEmployee()
		{
			RatePaymentEmployee employee = new RatePaymentEmployee();
			TextBox textBox = null;
			try
			{
				GetName(employee, out textBox);
				textBox = _rateText;
				employee.Rate = double.Parse(_rateText.Text);
				textBox = _timeWorkedText;
				int days = int.Parse(_timeWorkedText.Text);
				employee.TimeWorked = new TimeSpan(days, 0, 0, 0);
				textBox = _workTimeText;
				days = int.Parse(textBox.Text);
				employee.WorkTime = new TimeSpan(days, 0, 0, 0);
				textBox = _additionalText;
				employee.AdditionalPayment = double.Parse(textBox.Text);
				textBox = _increaseText;
				employee.Increase = double.Parse(textBox.Text);
				textBox = _mrotText;
				double mrot = double.Parse(textBox.Text);
				RatePaymentEmployee.Mrot = mrot;
			}
			catch (Exception exception)
			{
				textBox.Select();
				textBox.SelectAll();
				MessageBox.Show(exception.Message +
					"\r\nИсправьте данные в выделенной строке ввода.");
				employee = null;
			}
			return employee;
		}
	}
}

