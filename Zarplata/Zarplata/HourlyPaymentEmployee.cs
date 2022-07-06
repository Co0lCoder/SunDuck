// Работник с почасовой зарплатой

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarplata
{
	/// <summary>
	/// Работник с почасовой оплатой
	/// </summary>
	[Serializable]
	public class HourlyPaymentEmployee : IEmployee
	{
		private string _name;
		private string _lastName;
		private string _secondName = "";
		private double _hourPayment;
		private TimeSpan _timeWorked;

		/// <summary>
		/// Имя работника
		/// </summary>
		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = Validator.Validate(value);
			}
		}

		/// <summary>
		/// Фамилия работника
		/// </summary>
		public string LastName
		{
			get
			{
				return _lastName;
			}
			set
			{
				_lastName = Validator.Validate(value);
			}
		}

		/// <summary>
		/// Отчество работника
		/// </summary>
		public string SecondName
		{
			get
			{
				return _secondName;
			}
			set
			{
				if (value != null)
					_secondName = value;
			}
		}

		/// <summary>
		/// Плата за час работы
		/// </summary>
		public double HourPayment
		{
			get
			{
				return _hourPayment;
			}
			set
			{
				_hourPayment = Validator.Validate(value);
			}
		}

		/// <summary>
		/// Отработанное время
		/// </summary>
		public TimeSpan TimeWorked
		{
			get
			{
				return _timeWorked;
			}
			set
			{
				_timeWorked = Validator.Validate(value);
			}
		}

		/// <summary>
		/// Расчет зарплаты
		/// </summary>
		public int Salary
		{
			get
			{
				double salary = _hourPayment * _timeWorked.TotalHours;
				return (int)Math.Floor(salary);
			}
		}

		/// <summary>
		/// Текстовое представление отработанного времени
		/// </summary>
		/// <returns></returns>
		public string GetTimeWorked()
		{
			return _timeWorked.TotalHours.ToString() + " hours";
		}

		/// <summary>
		/// Текстовое представление условий оплаты
		/// </summary>
		/// <returns></returns>
		public string GetPaymentData()
		{
			return "Hourly payment: " + _hourPayment.ToString();
		}

		/// <summary>
		/// Конструктор по умолчанию
		/// </summary>
		public HourlyPaymentEmployee()
		{	}

		/// <summary>
		/// Информация о работнике и его зарплате
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			string s = LastName + " " + Name + " " + SecondName;
			s += " (" + GetPaymentData() + "; hours worked: " + GetTimeWorked() + "): ";
			s += Salary + " rub.";
			return s;
		}

	}
}
