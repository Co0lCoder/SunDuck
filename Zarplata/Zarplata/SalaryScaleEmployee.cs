// Работник с зарплатой по окладу

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarplata
{
/// <summary>
/// Работник с зарплатой по окладу
/// </summary>
 [Serializable]
	public class SalaryScaleEmployee : IEmployee
	{
		private string _name;
		private string _lastName;
		private string _secondName = "";
		private double _salaryScale;
		private double _additionalPayment = 0;
		private int _workDays;
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
		/// Оклад
		/// </summary>
		public double SalaryScale
		{
			get
			{
				return _salaryScale;
			}
			set
			{
				_salaryScale = Validator.Validate(value);
			}
		}

		/// <summary>
		/// Дополнительная выплата
		/// </summary>
		public double AdditionalPayment
		{
			get
			{
				return _additionalPayment;
			}
			set
			{
				_additionalPayment = Validator.Validate(value);
			}
		}

		/// <summary>
		/// Чило рабочих дней в периоде
		/// </summary>
		public int WorkDays
		{
			get
			{
				return _workDays;
			}
			set
			{
				_workDays = Validator.Validate(value);
			}
		}

		/// <summary>
		/// Расчет зарплаты (по периоду времени)
		/// </summary>
		public int Salary
		{
			get
			{
				double salary = _salaryScale * _timeWorked.TotalDays / _workDays;
				salary += AdditionalPayment;
				return (int)Math.Floor(salary);
			}
		}

		/// <summary>
		/// Текстовое представление отработанного времени
		/// </summary>
		/// <returns></returns>
		public string GetTimeWorked()
		{
			return _timeWorked.TotalDays.ToString() + " days (at norm " +
				_workDays.ToString() + " days)";
		}

		/// <summary>
		/// Текстовое представление условий оплаты
		/// </summary>
		/// <returns></returns>
		public string GetPaymentData()
		{
			string s = "Salary scale: " + _salaryScale.ToString();
			if (_additionalPayment != 0)
				s += ", additional payment: " + _additionalPayment.ToString();
			return s;
		}

		/// <summary>
		/// Конструктор
		/// </summary>
		/// <param name="lastname">Фамилия</param>
		/// <param name="name">Имя</param>
		/// <param name="secondName">Отчество</param>
		/// <param name="hourPayment">Часовая оплата</param>
		SalaryScaleEmployee(string lastname, string name, string secondName, double salaryScale)
		{
			Name = name;
			LastName = lastname;
			SecondName = secondName;
			SalaryScale = salaryScale;
		}

		/// <summary>
		/// Конструктор без параметров
		/// </summary>
		public SalaryScaleEmployee()
		{ }

		/// <summary>
		/// Информация о работнике и его зарплате
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			string s = LastName + " " + Name + " " + SecondName;
			s += " (" + GetPaymentData() + "; days worked: " + GetTimeWorked() + "): ";
			s += Salary + " rub.";
			return s;
		}

	}
}
