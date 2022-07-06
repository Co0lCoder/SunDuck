using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zarplata;

namespace ConsoleLoader
{
	public class Program
	{
		private static void Main(string[] args)
		{
			List<IEmployee> employees = new List<IEmployee>();

			while (true)
			{
				try
				{
					int menuItem = GetMenuItem();
					IEmployee employee = null;
					switch (menuItem)
					{
						case 1:
							employee = CreateHourlyPaymentEmployee();
							break;
						case 2:
							employee = CreateSalaryScalePaymentEmployee();
							break;
						case 3:
							employee = CreateRatePaymentEmployee();
							break;
						case 4:
							InputMrot();
							break;
						case 5:
							PrintEmployees(employees);
							break;
						case 0:
							return;
					}
					if (employee != null)
						employees.Add(employee);
				}
				catch(Exception exception)
				{
					Console.WriteLine("\nОшибка ввода данных. " + exception.Message);
					Console.WriteLine("Попробуйте повторить ввод.");
					Console.WriteLine("Нажмите любую клавишу для продолжения...");
					Console.ReadKey();
				}
			}
		}

		/// <summary>
		/// Распечатка данных о сотрудниках
		/// </summary>
		/// <param name="employees"></param>
		private static void PrintEmployees(List<IEmployee> employees)
		{
			Console.WriteLine("Данные о заработной плате сотрудников:");
			for (int i = 0; i < employees.Count; i++)
				Console.WriteLine("   " + (i + 1).ToString() + ". " + employees[i]);
			Console.WriteLine("Нажмите любую клавишу для продолжения...");
			Console.ReadKey();
		}

		/// <summary>
		/// Ввод ФИО сотрудника
		/// </summary>
		/// <param name="employee"></param>
		private static void InputNames(IEmployee employee)
		{
			Console.Write("Фамилия сотрудника: ");
			employee.LastName = Console.ReadLine().Trim();
			Console.Write("Имя сотрудника: ");
			employee.Name = Console.ReadLine().Trim();
			Console.Write("Отчество сотрудника: ");
			employee.SecondName = Console.ReadLine().Trim();
		}

		/// <summary>
		/// Ввод сотрудника с почасовой оплатой
		/// </summary>
		/// <returns></returns>
		private static HourlyPaymentEmployee CreateHourlyPaymentEmployee()
		{
			HourlyPaymentEmployee employee = new HourlyPaymentEmployee();
			InputNames(employee);
			Console.Write("Оплата за час работы: ");
			double hourlyPaiment = double.Parse(Console.ReadLine());
			employee.HourPayment = hourlyPaiment;
			Console.Write("Сколько часов отработал: ");
			int hoursWorked = int.Parse(Console.ReadLine());
			employee.TimeWorked = new TimeSpan(hoursWorked, 0, 0);
			return employee;
		}


		/// <summary>
		/// Ввод сотрудника с опатой по окладу
		/// </summary>
		/// <returns></returns>
		private static SalaryScaleEmployee CreateSalaryScalePaymentEmployee()
		{ 
			SalaryScaleEmployee employee = new SalaryScaleEmployee();
			InputNames(employee);

			Console.Write("Оклад: ");
			double salaryScale = double.Parse(Console.ReadLine());
			employee.SalaryScale = salaryScale;
			Console.Write("Сколько дней отработал: ");
			int daysWorked = int.Parse(Console.ReadLine());
			employee.TimeWorked = new TimeSpan(daysWorked, 0, 0, 0);
			Console.Write("Сколько рабочих дней в месяце: ");
			int workeDays = int.Parse(Console.ReadLine());
			employee.WorkDays = workeDays;
			Console.Write("Размер дополнительных выплат: ");
			int additionalPayment = int.Parse(Console.ReadLine());
			employee.AdditionalPayment = additionalPayment;

			return employee;
		}

		/// <summary>
		/// Ввод сотрудника с опатой по ставке
		/// </summary>
		/// <returns></returns>
		private static RatePaymentEmployee CreateRatePaymentEmployee()
		{
			RatePaymentEmployee employee = new RatePaymentEmployee();
			InputNames(employee);

			Console.Write("Тарифный коэффициент: ");
			double rate = double.Parse(Console.ReadLine());
			employee.Rate = rate;
			Console.Write("Сколько дней отработал: ");
			int daysWorked = int.Parse(Console.ReadLine());
			employee.TimeWorked = new TimeSpan(daysWorked, 0, 0, 0);
			Console.Write("Расчетное время ставки (дни): ");
			int workTime = int.Parse(Console.ReadLine());
			employee.WorkTime = new TimeSpan(workTime, 0, 0, 0);
			Console.Write("Надбавка (проценты): ");
			double increase  = double.Parse(Console.ReadLine());
			employee.Increase = increase;
			Console.Write("Размер дополнительных выплат: ");
			int additionalPayment = int.Parse(Console.ReadLine());
			employee.AdditionalPayment = additionalPayment;

			return employee;
		}

		private static void InputMrot()
		{
			Console.WriteLine("Текущее значение МРОТ установлено на уровне " +
				RatePaymentEmployee.Mrot.ToString() + ".");
			Console.Write("Введите новое значение МРОТ (Enter чтобы оставить " +
				"текущее значение): ");
			string s = Console.ReadLine();
			if (s == "")
				return;
			else RatePaymentEmployee.Mrot = double.Parse(s);
		}

		/// <summary>
		/// Реализация меню
		/// </summary>
		/// <returns></returns>
		private static int GetMenuItem()
		{
			Console.Clear();
			Console.WriteLine("Программа учета заработной платы сотрудников\n");
			Console.WriteLine("Выберите пункт меню:");
			Console.WriteLine("    1 - Ввести данные сотрудника с почасовой оплатой труда");
			Console.WriteLine("    2 - Ввести данные сотрудника с оплатой по окладу");
			Console.WriteLine("    3 - Ввести данные сотрудника с оплатой по ставке");
			Console.WriteLine("    4 - Корректировать величину МРОТ");
			Console.WriteLine("    5 - Вывести данные о введенных сотрудниках");
			Console.WriteLine("    0 - Завершение работы\n");

			while (true)
			{
				char key = Console.ReadKey().KeyChar;
				if (key < '0' || key > '5')
					Console.WriteLine(" Выберите пункт меню от 0 до 5.");
				else
				{
					Console.WriteLine();
					return key - '0';
				}
			}
		}
	}
}
