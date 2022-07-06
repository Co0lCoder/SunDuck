using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Zarplata;

namespace View
{
	/// <summary>
	/// Главная форма
	/// </summary>
	public partial class EmployeesForm : Form
	{
		private List<IEmployee> _employees = new List<IEmployee>();

		/// <summary>
		/// Конструктор
		/// </summary>
		public EmployeesForm()
		{
			InitializeComponent();
		}

		/// <summary>
		/// Кнопка Add Employee
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void AddClick(object sender, EventArgs e)
		{
			AddEmployeeForm addForm = new AddEmployeeForm();
			if (addForm.ShowDialog() == DialogResult.OK)
				AddEmployee(addForm.Employee);
		}

		private void AddEmployee(IEmployee employee)
		{
			if (employee == null)
				return;

			_employees.Add(employee);
			AddEmployeeToTable(employee);
		}


		private void AddEmployeeToTable(IEmployee employee)
		{
			int row = _employeeTable.Rows.Add();
			string name = employee.LastName + " " + employee.Name;
			if (employee.SecondName != "")
				name += " " + employee.SecondName;
			_employeeTable.Rows[row].Cells[0].Value = name;
			_employeeTable.Rows[row].Cells[1].Value = employee.GetPaymentData();
			_employeeTable.Rows[row].Cells[2].Value = employee.GetTimeWorked();
			_employeeTable.Rows[row].Cells[3].Value = employee.Salary;
		}

		/// <summary>
		/// Кнопка Remove Employee
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void RemoveClick(object sender, EventArgs e)
		{
			for (int i = _employees.Count - 1; i >= 0; i--)
			{
				if (_employeeTable.Rows[i].Selected)
				{
					_employeeTable.Rows.RemoveAt(i);
					_employees.RemoveAt(i);
				}
			}
		}

		/// <summary>
		/// Кнопка Add Random Data
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void _random_Click(object sender, EventArgs e)
		{
			AddRandomEmployeeForm addForm = new AddRandomEmployeeForm();
			if (addForm.ShowDialog() == DialogResult.OK)
				AddEmployee(addForm.Employee);
		}

		private void _search_Click(object sender, EventArgs e)
		{
			SearchForm searchForm = new SearchForm();
			if (searchForm.ShowDialog() == DialogResult.OK)
			{
				double workedFrom = searchForm.TimeWorkedFrom.TotalHours;
				double workedTo = searchForm.TimeWorkedTo.TotalHours;
				double salaryFrom = searchForm.SalaryFrom;
				double salaryTo = searchForm.SalaryTo;
				string firstName = searchForm.FirstName;
				string secondName = searchForm.SecondName;
				string lastName = searchForm.LastName;

				_employeeTable.SelectAll();
				for (int row = 0; row < _employeeTable.Rows.Count; row++)
				{
					IEmployee employee = _employees[row];

					if (lastName != "" && employee.LastName != lastName)
						_employeeTable.Rows[row].Selected = false;
					if (firstName != "" && employee.Name != firstName)
						_employeeTable.Rows[row].Selected = false;
					if (secondName != "" && employee.SecondName != secondName)
						_employeeTable.Rows[row].Selected = false;
					if (workedFrom != 0 && 
						employee.TimeWorked.TotalHours < workedFrom)
						_employeeTable.Rows[row].Selected = false;
					if (workedTo != 0 &&
						employee.TimeWorked.TotalHours > workedTo)
						_employeeTable.Rows[row].Selected = false;
					if (salaryFrom != 0 && employee.Salary < salaryFrom)
						_employeeTable.Rows[row].Selected = false;
					if (salaryTo != 0 && employee.Salary > salaryTo)
						_employeeTable.Rows[row].Selected = false;
				}
			}
		}

		/// <summary>
		/// Кнопка Save Data
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SaveClick(object sender, EventArgs e)
		{
			SaveFileDialog save = new SaveFileDialog();
			save.InitialDirectory = Application.StartupPath;
			save.Filter = "Employees file (*.empl)|*.empl|All files(*.*)|*.*";
			if (save.ShowDialog() == DialogResult.OK)
			{
				try
				{
					BinaryFormatter formatter = new BinaryFormatter();
					using (FileStream fs = new FileStream(
						save.FileName, FileMode.OpenOrCreate))
					{
						formatter.Serialize(fs, _employees);
						fs.Close();
					}
				}
				catch (Exception exception)
				{
					MessageBox.Show("Во время сохранения произошла ошибка: " +
						Environment.NewLine + exception.Message, "Ошибка сохранения файла",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

	/// <summary>
	/// Кнопка Load Data
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private void LoadClick(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			open.InitialDirectory = Application.StartupPath;
			open.Filter = "Employees file (*.empl)|*.empl|All files(*.*)|*.*";
			open.Multiselect = false;

			if (open.ShowDialog() == DialogResult.OK)
			{
				using (FileStream fs = new FileStream(open.FileName, FileMode.OpenOrCreate))
					try
					{
						BinaryFormatter formatter = new BinaryFormatter();
						List<IEmployee> newEmployees = (List<IEmployee>)formatter.Deserialize(fs);
						_employees.Clear();
						_employees = null;
						_employees = newEmployees;
						_employeeTable.Rows.Clear();
						for (int i = 0; i < _employees.Count; i++)
						{
							IEmployee employee = _employees[i];
							AddEmployeeToTable(employee);
            }
					}
					catch (Exception ex)
					{
						MessageBox.Show("Во время загрузки файла произошла ошибка: " +
								Environment.NewLine + ex.Message, "Ошибка открытия файла",
								MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
			}
		}
	}
}
