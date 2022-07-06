// Интерфейс IEmployee

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarplata
{
	/// <summary>
	/// Интерфейс - наемный работник
	/// </summary>
	public interface IEmployee
	{
		/// <summary>
		/// Имя работника
		/// </summary>
		string Name
		{
			get;
			set;
		}

		/// <summary>
		/// Фамилия работника
		/// </summary>
		string LastName
		{
			get;
			set;
		}

		/// <summary>
		/// Отчество работника
		/// </summary>
		string SecondName
		{
			get;
			set;
		}

		/// <summary>
		/// Отработанное время
		/// </summary>
		TimeSpan TimeWorked
		{
			get;
			set;
		}

		/// <summary>
		/// Заработная плата
		/// </summary>
		int Salary
		{
			get;
		}

		/// <summary>
		/// Текстовое представление отработанного времени
		/// </summary>
		/// <returns></returns>
		string GetTimeWorked();

		/// <summary>
		/// Данные платежа
		/// </summary>
		/// <returns></returns>
		string GetPaymentData();
	}
}
