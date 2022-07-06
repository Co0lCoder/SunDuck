// Сотрудник с оплатой по ставке

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarplata
{
	/// <summary>
	/// Работник с оплатой по ставке
	/// </summary>
	[Serializable]
	public class RatePaymentEmployee : IEmployee
	{
		private static double _mrot = 15279;

		private string _name;
		private string _lastName;
		private string _secondName = "";
		private double _rate;
		private double _increase = 0;
		private double _additionalPayment = 0;
		private TimeSpan _workTime;
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
		/// МРОТ (минимальный размер оплаты труда)
		/// </summary>
		public static double Mrot
		{
			get
			{
				return _mrot;
			}
			set
			{
				_mrot = Validator.Validate(value);
			}
		}

		/// <summary>
		/// Ставка
		/// </summary>
		public double Rate
		{
			get
			{
				return _rate;
			}
			set
			{
				_rate = Validator.Validate(value);
			}
		}

		/// <summary>
		/// Надбавка (в процентах)
		/// </summary>
		public double Increase
		{
			get
			{
				return _increase;
			}
			set
			{
				_increase = Validator.Validate(value);
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
		/// Величина периода ставки
		/// </summary>
		public TimeSpan WorkTime
		{
			get
			{
				return _workTime;
			}
			set
			{
				_workTime = Validator.Validate(value);
			}
		}

		/// <summary>
		/// Расчет зарплаты 
		/// </summary>
		public int Salary
		{
			get
			{
				double salary = _mrot * _rate * (1 + _increase / 100) + _additionalPayment;
				salary *= _timeWorked.TotalHours / _workTime.TotalHours;
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
				_workTime.TotalDays.ToString() + " days)";
		}

		/// <summary>
		/// Текстовое представление условий оплаты
		/// </summary>
		/// <returns></returns>
		public string GetPaymentData()
		{
			string s = "Rate: " + (_rate * _mrot).ToString();
			if (_increase != 0)
				s += ", increase: " + _increase.ToString() + "%";
			if (_additionalPayment != 0)
				s += ", additional payment: " + _additionalPayment.ToString();
			return s;
		}

		/// <summary>
		/// Конструктор без параметров
		/// </summary>
		public RatePaymentEmployee()
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
