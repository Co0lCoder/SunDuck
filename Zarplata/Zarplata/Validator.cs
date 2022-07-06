// Валидатор данных

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zarplata
{
	/// <summary>
	/// Валидатор вводимых данных
	/// </summary>
	public class Validator
	{
		/// <summary>
		/// Валидация строки
		/// </summary>
		/// <param name="value">Валидируемая строка</param>
		/// <param name="canBeEmpty">Флаг того, что допускается строка нулевой длины</param>
		/// <returns></returns>
		public static string Validate(string value, bool canBeEmpty = false)
		{
			if (value == null || (!canBeEmpty && value == ""))
        throw new Exception("Строка не может быть пустой.");
			return value;
		}

		/// <summary>
		/// Валидация промежутка отработанного времени
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		public static TimeSpan Validate(TimeSpan value)
		{
			if (value == null)
				throw new Exception("Отработанное время не может быть null.");
			if (value.TotalHours < 0)
				throw new Exception("Отработанное время не может быть отрицательным.");
			if (value.TotalDays > 366)
				throw new Exception("Отработанное время не может превышать год.");
			return value;
		}

		/// <summary>
		/// Валидация параметра зарплаты
		/// </summary>
		/// <param name="payment"></param>
		public static double Validate(double payment)
		{
			if (payment < 0)
				throw new Exception("Плата должна быть больше нуля.");
			return payment;
		}


		public static int Validate(int value)
		{
			if (value < 0)
				throw new Exception("Значение должно быть неотрицательным.");
			return value;
		}
	}
}
