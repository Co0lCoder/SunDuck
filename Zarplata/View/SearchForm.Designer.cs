namespace View
{
	partial class SearchForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this._name = new System.Windows.Forms.GroupBox();
			this._lastNameText = new System.Windows.Forms.TextBox();
			this._secondNameText = new System.Windows.Forms.TextBox();
			this._firstNameText = new System.Windows.Forms.TextBox();
			this._lastName = new System.Windows.Forms.Label();
			this._secondName = new System.Windows.Forms.Label();
			this._firstName = new System.Windows.Forms.Label();
			this._timeWorked = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this._timeWorkedFrom = new System.Windows.Forms.TextBox();
			this._fromTimeUnits = new System.Windows.Forms.ComboBox();
			this._toTimeUnits = new System.Windows.Forms.ComboBox();
			this._timeWorkedTo = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this._salaryTo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this._salaryFrom = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this._ok = new System.Windows.Forms.Button();
			this._cancel = new System.Windows.Forms.Button();
			this._name.SuspendLayout();
			this._timeWorked.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// _name
			// 
			this._name.Controls.Add(this._lastNameText);
			this._name.Controls.Add(this._secondNameText);
			this._name.Controls.Add(this._firstNameText);
			this._name.Controls.Add(this._lastName);
			this._name.Controls.Add(this._secondName);
			this._name.Controls.Add(this._firstName);
			this._name.Location = new System.Drawing.Point(12, 12);
			this._name.Name = "_name";
			this._name.Size = new System.Drawing.Size(366, 100);
			this._name.TabIndex = 1;
			this._name.TabStop = false;
			this._name.Text = "Name";
			// 
			// _lastNameText
			// 
			this._lastNameText.Location = new System.Drawing.Point(86, 70);
			this._lastNameText.Name = "_lastNameText";
			this._lastNameText.Size = new System.Drawing.Size(274, 20);
			this._lastNameText.TabIndex = 5;
			// 
			// _secondNameText
			// 
			this._secondNameText.Location = new System.Drawing.Point(86, 43);
			this._secondNameText.Name = "_secondNameText";
			this._secondNameText.Size = new System.Drawing.Size(274, 20);
			this._secondNameText.TabIndex = 4;
			// 
			// _firstNameText
			// 
			this._firstNameText.Location = new System.Drawing.Point(86, 17);
			this._firstNameText.Name = "_firstNameText";
			this._firstNameText.Size = new System.Drawing.Size(274, 20);
			this._firstNameText.TabIndex = 3;
			// 
			// _lastName
			// 
			this._lastName.AutoSize = true;
			this._lastName.Location = new System.Drawing.Point(6, 73);
			this._lastName.Name = "_lastName";
			this._lastName.Size = new System.Drawing.Size(58, 13);
			this._lastName.TabIndex = 2;
			this._lastName.Text = "Last Name";
			// 
			// _secondName
			// 
			this._secondName.AutoSize = true;
			this._secondName.Location = new System.Drawing.Point(7, 46);
			this._secondName.Name = "_secondName";
			this._secondName.Size = new System.Drawing.Size(73, 13);
			this._secondName.TabIndex = 1;
			this._secondName.Text = "Second name";
			// 
			// _firstName
			// 
			this._firstName.AutoSize = true;
			this._firstName.Location = new System.Drawing.Point(7, 20);
			this._firstName.Name = "_firstName";
			this._firstName.Size = new System.Drawing.Size(57, 13);
			this._firstName.TabIndex = 0;
			this._firstName.Text = "First Name";
			// 
			// _timeWorked
			// 
			this._timeWorked.Controls.Add(this._toTimeUnits);
			this._timeWorked.Controls.Add(this._timeWorkedTo);
			this._timeWorked.Controls.Add(this.label2);
			this._timeWorked.Controls.Add(this._fromTimeUnits);
			this._timeWorked.Controls.Add(this._timeWorkedFrom);
			this._timeWorked.Controls.Add(this.label1);
			this._timeWorked.Location = new System.Drawing.Point(12, 119);
			this._timeWorked.Name = "_timeWorked";
			this._timeWorked.Size = new System.Drawing.Size(216, 75);
			this._timeWorked.TabIndex = 2;
			this._timeWorked.TabStop = false;
			this._timeWorked.Text = "Time worked";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(27, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "from";
			// 
			// _timeWorkedFrom
			// 
			this._timeWorkedFrom.Location = new System.Drawing.Point(44, 20);
			this._timeWorkedFrom.Name = "_timeWorkedFrom";
			this._timeWorkedFrom.Size = new System.Drawing.Size(105, 20);
			this._timeWorkedFrom.TabIndex = 1;
			// 
			// _fromTimeUnits
			// 
			this._fromTimeUnits.FormattingEnabled = true;
			this._fromTimeUnits.Items.AddRange(new object[] {
            "hours",
            "days"});
			this._fromTimeUnits.Location = new System.Drawing.Point(155, 20);
			this._fromTimeUnits.Name = "_fromTimeUnits";
			this._fromTimeUnits.Size = new System.Drawing.Size(55, 21);
			this._fromTimeUnits.TabIndex = 2;
			// 
			// _toTimeUnits
			// 
			this._toTimeUnits.FormattingEnabled = true;
			this._toTimeUnits.Items.AddRange(new object[] {
            "hours",
            "days"});
			this._toTimeUnits.Location = new System.Drawing.Point(155, 46);
			this._toTimeUnits.Name = "_toTimeUnits";
			this._toTimeUnits.Size = new System.Drawing.Size(55, 21);
			this._toTimeUnits.TabIndex = 5;
			// 
			// _timeWorkedTo
			// 
			this._timeWorkedTo.Location = new System.Drawing.Point(44, 46);
			this._timeWorkedTo.Name = "_timeWorkedTo";
			this._timeWorkedTo.Size = new System.Drawing.Size(105, 20);
			this._timeWorkedTo.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(16, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "to";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this._salaryTo);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this._salaryFrom);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Location = new System.Drawing.Point(234, 119);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(138, 75);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Salary";
			// 
			// _salaryTo
			// 
			this._salaryTo.Location = new System.Drawing.Point(43, 46);
			this._salaryTo.Name = "_salaryTo";
			this._salaryTo.Size = new System.Drawing.Size(89, 20);
			this._salaryTo.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 49);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(16, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "to";
			// 
			// _salaryFrom
			// 
			this._salaryFrom.Location = new System.Drawing.Point(43, 20);
			this._salaryFrom.Name = "_salaryFrom";
			this._salaryFrom.Size = new System.Drawing.Size(89, 20);
			this._salaryFrom.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 23);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(27, 13);
			this.label4.TabIndex = 5;
			this.label4.Text = "from";
			// 
			// _ok
			// 
			this._ok.DialogResult = System.Windows.Forms.DialogResult.OK;
			this._ok.Location = new System.Drawing.Point(384, 12);
			this._ok.Name = "_ok";
			this._ok.Size = new System.Drawing.Size(75, 23);
			this._ok.TabIndex = 4;
			this._ok.Text = "OK";
			this._ok.UseVisualStyleBackColor = true;
			this._ok.Click += new System.EventHandler(this.OkClick);
			// 
			// _cancel
			// 
			this._cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._cancel.Location = new System.Drawing.Point(384, 41);
			this._cancel.Name = "_cancel";
			this._cancel.Size = new System.Drawing.Size(75, 23);
			this._cancel.TabIndex = 5;
			this._cancel.Text = "Cancel";
			this._cancel.UseVisualStyleBackColor = true;
			// 
			// SearchForm
			// 
			this.AcceptButton = this._ok;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this._cancel;
			this.ClientSize = new System.Drawing.Size(464, 200);
			this.Controls.Add(this._cancel);
			this.Controls.Add(this._ok);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this._timeWorked);
			this.Controls.Add(this._name);
			this.Name = "SearchForm";
			this.Text = "Search Employees";
			this._name.ResumeLayout(false);
			this._name.PerformLayout();
			this._timeWorked.ResumeLayout(false);
			this._timeWorked.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox _name;
		protected System.Windows.Forms.TextBox _lastNameText;
		protected System.Windows.Forms.TextBox _secondNameText;
		protected System.Windows.Forms.TextBox _firstNameText;
		private System.Windows.Forms.Label _lastName;
		private System.Windows.Forms.Label _secondName;
		private System.Windows.Forms.Label _firstName;
		private System.Windows.Forms.GroupBox _timeWorked;
		private System.Windows.Forms.ComboBox _toTimeUnits;
		private System.Windows.Forms.TextBox _timeWorkedTo;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox _fromTimeUnits;
		private System.Windows.Forms.TextBox _timeWorkedFrom;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox _salaryTo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox _salaryFrom;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button _ok;
		private System.Windows.Forms.Button _cancel;
	}
}