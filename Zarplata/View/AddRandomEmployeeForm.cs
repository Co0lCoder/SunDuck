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
	/// Генерация сотрудника
	/// </summary>
	public partial class AddRandomEmployeeForm : AddEmployeeForm
	{
		private Random _random = new Random();

		/// <summary>
		/// Конструктор
		/// </summary>
		public AddRandomEmployeeForm()
		{
			InitializeComponent();

			int index = _random.Next(_maleNames.Length);
			string name = _maleNames[index];
			if (name.Last<char>() == 's')
				name += "son";
			else
			{
				int random = _random.Next(10);
				if (random < 5)
					name += "s";
				else if (random < 8)
					name += "son";
				else
					name = "Mc" + name;
			}

			_lastNameText.Text = name;
			index = _random.Next(_maleNames.Length);
			name = _maleNames[index];
			_secondNameText.Text = name;

			bool male = (_random.NextDouble() > 0.5);
			if (male)
			{
				index = _random.Next(_maleNames.Length);
				_firstNameText.Text = _maleNames[index];
			}
			else
			{
				index = _random.Next(_femaleNames.Length);
				_firstNameText.Text = _femaleNames[index];
			}

			switch (_random.Next(3))
			{
				case 0:
					_hourly.Checked = true;
					break;
				case 1:
					_scale.Checked = true;
					break;
				case 2:
					_rate.Checked = true;
					break;
			}

		}

		/// <summary>
		/// Мужские имена
		/// </summary>
		private string[] _maleNames =
		{
			"Abraham", "Adam", "Adrian", "Alan", "Alex", "Alfred",	"Andrew",
			"Benjamin", "Bernard", "Blake", "Brandon", "Brian", "Bruce", "Bryan",
			"Carl", "Carlos", "Charles", "Christopher", "Connor", "Christian",
			"Daniel", "David", "Dennis", "Diego", "Dominic", "Donald", "Douglas",
			"Edward", "Elijah", "Eric", "Ethan", "Evan", "Francis", "Fred",
			"Gabriel", "Geoffrey", "George", "Gilbert", "Gordon", "Gregory",
			"Harold", "Harry", "Henry", "Herbert", "Howard", "Hugh", "Hunter",
			"Ian", "Isaac", "Isaiah", "Jack", "Jacob", "Jaden", "Jake", "James",
			"Jeffery", "John", "Jonathan", "Joseph", "Joshua", "Julian", "Justin",
			"Keith", "Kevin", "Kyle", "Landon", "Lawrence", "Leon", "Lewis",
			"Lucas", "Luke", "Martin", "Mason", "Matthew", "Michael", "Nathan",
			"Nicholas", "Norman", "Oliver", "Oscar", "Oswald", "Owen", "Patrick",
			"Peter", "Philip", "Ralph", "Raymond", "Reginald", "Richard", "Robert",
			"Rodrigo", "Roger", "Ronald", "Ryan", "Samuel", "Sebastian", "Simon",
			"Stanley", "Steven", "Thomas", "Timothy", "Tyler", "Wallace", "Walter",
			"William", "Xavier", "Zachary"
		};

		/// <summary>
		/// Женские имена
		/// </summary>
		private string[] _femaleNames =
		{
			"Abigail", "Ada", "Agatha", "Alexa", "Alexandra", "Alexis", "Alice",
			"Amanda", "Amber", "Amelia", "Angelina", "Anita", "Ann", "Audrey",
			"Barbara", "Beatrice", "Belinda", "Brianna", "Bridjet", "Brooke",
			"Caroline", "Catherine", "Chloe", "Christine", "Daisy", "Danielle",
			"Diana", "Dorothy", "Eleanor", "Elizabeth", "Ella", "Emily", "Emma",
			"Fiona", "Florence", "Freda", "Gloria", "Hailey", "Helen", "Isabel",
			"Isabella", "Jada", "Jane", "Jasmine", "Jennifer", "Jessica",
			"Josephine", "Julia", "Kaitlyn", "Kathryn", "Kayla", "Kimberly",
			"Kylie", "Laura", "Lauren", "Leah", "Leonora", "Leslie", "Lillian",
			"Linda", "Lorna", "Luccile", "Lucy", "Margaret", "Maria", "Marisa",
			"Mary", "Megan", "Melanie", "Melissa", "Michelle", "Monica", "Nancy",
			"Natalie", "Nicole", "Nora", "Olivia", "Paige", "Pamela", "Patricia",
			"Pauline", "Penelope", "Rachel", "Rebecca", "Rita", "Rosalind",
			"Rose", "Samantha", "Sandra", "Sara", "Sarah", "Sharon", "Sheila",
			"Shirley", "Sophia", "Stephanie", "Susan", "Sylvia", "Taylor",
			"Trinity", "Vanessa", "Victoria", "Violet", "Virginia", "Zoe"
		};

		/// <summary>
		/// Данные для сотрудника с почасовой оплатой
		/// </summary>
		protected override void SetHourlyPaymentView()
		{
			base.SetHourlyPaymentView();
			_rateText.Text = _random.Next(1000).ToString();
			_timeWorkedText.Text = _random.Next(200).ToString();
		}

		/// <summary>
		/// Данные для сотрудника оплатой по окладу
		/// </summary>
		protected override void SetSalaryScaleView()
		{
			base.SetSalaryScaleView();
			_rateText.Text = _random.Next(1000).ToString();
			int worked = _random.Next(32);
      _timeWorkedText.Text = worked.ToString();
			_workTimeText.Text = _random.Next(worked, 32).ToString();
			_additionalText.Text = _random.Next(100000).ToString();
		}

		/// <summary>
		/// Данные для сотрудника оплатой по ставке
		/// </summary>
		protected override void SetRateView()
		{
			base.SetRateView();
			_rateText.Text = _random.Next(20).ToString();
			_additionalText.Text = _random.Next(100000).ToString();
			int worked = _random.Next(32);
			_timeWorkedText.Text = worked.ToString();
			_workTimeText.Text = _random.Next(worked, 32).ToString();
			_increaseText.Text = _random.Next(200).ToString();
    }
	}
}
