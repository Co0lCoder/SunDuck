namespace View
{
	partial class EmployeesForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel1 = new System.Windows.Forms.Panel();
			this._load = new System.Windows.Forms.Button();
			this._save = new System.Windows.Forms.Button();
			this._search = new System.Windows.Forms.Button();
#if DEBUG
			this._random = new System.Windows.Forms.Button();
#endif
			this._remove = new System.Windows.Forms.Button();
			this._add = new System.Windows.Forms.Button();
			this._employeesFrame = new System.Windows.Forms.GroupBox();
			this._employeeTable = new System.Windows.Forms.DataGridView();
			this._name = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._paymentData = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._timeWorked = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this._payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			this._employeesFrame.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this._employeeTable)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this._load);
			this.panel1.Controls.Add(this._save);
			this.panel1.Controls.Add(this._search);
			this.panel1.Controls.Add(this._random);
			this.panel1.Controls.Add(this._remove);
			this.panel1.Controls.Add(this._add);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 314);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(925, 31);
			this.panel1.TabIndex = 0;
			// 
			// _load
			// 
			this._load.Location = new System.Drawing.Point(517, 4);
			this._load.Name = "_load";
			this._load.Size = new System.Drawing.Size(120, 23);
			this._load.TabIndex = 5;
			this._load.Text = "Load Data";
			this._load.UseVisualStyleBackColor = true;
			this._load.Click += new System.EventHandler(this.LoadClick);
			// 
			// _save
			// 
			this._save.Location = new System.Drawing.Point(391, 4);
			this._save.Name = "_save";
			this._save.Size = new System.Drawing.Size(120, 23);
			this._save.TabIndex = 4;
			this._save.Text = "Save Data";
			this._save.UseVisualStyleBackColor = true;
			this._save.Click += new System.EventHandler(this.SaveClick);
			// 
			// _search
			// 
			this._search.Location = new System.Drawing.Point(265, 4);
			this._search.Name = "_search";
			this._search.Size = new System.Drawing.Size(120, 23);
			this._search.TabIndex = 3;
			this._search.Text = "Search";
			this._search.UseVisualStyleBackColor = true;
			this._search.Click += new System.EventHandler(this._search_Click);
#if DEBUG
			// 
			// _random
			// 
			this._random.Location = new System.Drawing.Point(643, 4);
			this._random.Name = "_random";
			this._random.Size = new System.Drawing.Size(120, 23);
			this._random.TabIndex = 2;
			this._random.Text = "Create Random Data";
			this._random.UseVisualStyleBackColor = true;
			this._random.Click += new System.EventHandler(this._random_Click);
#endif
			// 
			// _remove
			// 
			this._remove.Location = new System.Drawing.Point(139, 4);
			this._remove.Name = "_remove";
			this._remove.Size = new System.Drawing.Size(120, 23);
			this._remove.TabIndex = 1;
			this._remove.Text = "Remove Employee";
			this._remove.UseVisualStyleBackColor = true;
			this._remove.Click += new System.EventHandler(this.RemoveClick);
			// 
			// _add
			// 
			this._add.Location = new System.Drawing.Point(13, 4);
			this._add.Name = "_add";
			this._add.Size = new System.Drawing.Size(120, 23);
			this._add.TabIndex = 0;
			this._add.Text = "Add Employee";
			this._add.UseVisualStyleBackColor = true;
			this._add.Click += new System.EventHandler(this.AddClick);
			// 
			// _employeesFrame
			// 
			this._employeesFrame.Controls.Add(this._employeeTable);
			this._employeesFrame.Dock = System.Windows.Forms.DockStyle.Fill;
			this._employeesFrame.Location = new System.Drawing.Point(0, 0);
			this._employeesFrame.Name = "_employeesFrame";
			this._employeesFrame.Size = new System.Drawing.Size(925, 314);
			this._employeesFrame.TabIndex = 2;
			this._employeesFrame.TabStop = false;
			this._employeesFrame.Text = "Employee Data and Payments";
			// 
			// _employeeTable
			// 
			this._employeeTable.AllowUserToAddRows = false;
			this._employeeTable.AllowUserToDeleteRows = false;
			this._employeeTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this._employeeTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this._employeeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this._employeeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._name,
            this._paymentData,
            this._timeWorked,
            this._payment});
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this._employeeTable.DefaultCellStyle = dataGridViewCellStyle1;
			this._employeeTable.Dock = System.Windows.Forms.DockStyle.Fill;
			this._employeeTable.Location = new System.Drawing.Point(3, 16);
			this._employeeTable.Name = "_employeeTable";
			this._employeeTable.ReadOnly = true;
			this._employeeTable.RowHeadersVisible = false;
			this._employeeTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this._employeeTable.Size = new System.Drawing.Size(919, 295);
			this._employeeTable.TabIndex = 0;
			// 
			// _name
			// 
			this._name.FillWeight = 60F;
			this._name.HeaderText = "Name";
			this._name.Name = "_name";
			this._name.ReadOnly = true;
			// 
			// _paymentData
			// 
			this._paymentData.HeaderText = "Payment Data";
			this._paymentData.Name = "_paymentData";
			this._paymentData.ReadOnly = true;
			// 
			// _timeWorked
			// 
			this._timeWorked.FillWeight = 20F;
			this._timeWorked.HeaderText = "Time Worked";
			this._timeWorked.Name = "_timeWorked";
			this._timeWorked.ReadOnly = true;
			// 
			// _payment
			// 
			this._payment.FillWeight = 20F;
			this._payment.HeaderText = "Payment";
			this._payment.Name = "_payment";
			this._payment.ReadOnly = true;
			// 
			// EmployeesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(925, 345);
			this.Controls.Add(this._employeesFrame);
			this.Controls.Add(this.panel1);
			this.MinimumSize = new System.Drawing.Size(800, 200);
			this.Name = "EmployeesForm";
			this.Text = "Employees";
			this.panel1.ResumeLayout(false);
			this._employeesFrame.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this._employeeTable)).EndInit();
			this.ResumeLayout(false);

		}

#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button _add;
		private System.Windows.Forms.Button _remove;
		private System.Windows.Forms.GroupBox _employeesFrame;
		private System.Windows.Forms.DataGridView _employeeTable;
		private System.Windows.Forms.Button _random;
		private System.Windows.Forms.DataGridViewTextBoxColumn _name;
		private System.Windows.Forms.DataGridViewTextBoxColumn _paymentData;
		private System.Windows.Forms.DataGridViewTextBoxColumn _timeWorked;
		private System.Windows.Forms.DataGridViewTextBoxColumn _payment;
		private System.Windows.Forms.Button _search;
		private System.Windows.Forms.Button _load;
		private System.Windows.Forms.Button _save;
	}
}

