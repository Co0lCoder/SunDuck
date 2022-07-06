namespace View
{
	partial class AddEmployeeForm
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
			this._payMent = new System.Windows.Forms.GroupBox();
			this._rate = new System.Windows.Forms.RadioButton();
			this._scale = new System.Windows.Forms.RadioButton();
			this._hourly = new System.Windows.Forms.RadioButton();
			this._paymentData = new System.Windows.Forms.GroupBox();
			this._workTime = new System.Windows.Forms.Label();
			this._increase = new System.Windows.Forms.Label();
			this._increaseText = new System.Windows.Forms.TextBox();
			this._workTimeText = new System.Windows.Forms.TextBox();
			this._additionalText = new System.Windows.Forms.TextBox();
			this._additional = new System.Windows.Forms.Label();
			this._timeUnits = new System.Windows.Forms.Label();
			this._timeWorkedText = new System.Windows.Forms.TextBox();
			this._timeWorked = new System.Windows.Forms.Label();
			this._mrotText = new System.Windows.Forms.TextBox();
			this._mrot = new System.Windows.Forms.Label();
			this._rateText = new System.Windows.Forms.TextBox();
			this._salaryRate = new System.Windows.Forms.Label();
			this._ok = new System.Windows.Forms.Button();
			this._cancel = new System.Windows.Forms.Button();
			this._name.SuspendLayout();
			this._payMent.SuspendLayout();
			this._paymentData.SuspendLayout();
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
			this._name.TabIndex = 0;
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
			// _payMent
			// 
			this._payMent.Controls.Add(this._rate);
			this._payMent.Controls.Add(this._scale);
			this._payMent.Controls.Add(this._hourly);
			this._payMent.Location = new System.Drawing.Point(384, 12);
			this._payMent.Name = "_payMent";
			this._payMent.Size = new System.Drawing.Size(143, 100);
			this._payMent.TabIndex = 1;
			this._payMent.TabStop = false;
			this._payMent.Text = "Payment mode";
			// 
			// _rate
			// 
			this._rate.AutoSize = true;
			this._rate.Location = new System.Drawing.Point(6, 71);
			this._rate.Name = "_rate";
			this._rate.Size = new System.Drawing.Size(91, 17);
			this._rate.TabIndex = 2;
			this._rate.Text = "Rate payment";
			this._rate.UseVisualStyleBackColor = true;
			this._rate.CheckedChanged += new System.EventHandler(this.RateCheckedChanged);
			// 
			// _scale
			// 
			this._scale.AutoSize = true;
			this._scale.Checked = true;
			this._scale.Location = new System.Drawing.Point(6, 44);
			this._scale.Name = "_scale";
			this._scale.Size = new System.Drawing.Size(127, 17);
			this._scale.TabIndex = 1;
			this._scale.TabStop = true;
			this._scale.Text = "Sailary scale payment";
			this._scale.UseVisualStyleBackColor = true;
			this._scale.CheckedChanged += new System.EventHandler(this.ScaleCheckedChanged);
			// 
			// _hourly
			// 
			this._hourly.AutoSize = true;
			this._hourly.Location = new System.Drawing.Point(6, 18);
			this._hourly.Name = "_hourly";
			this._hourly.Size = new System.Drawing.Size(98, 17);
			this._hourly.TabIndex = 0;
			this._hourly.Text = "Hourly payment";
			this._hourly.UseVisualStyleBackColor = true;
			this._hourly.CheckedChanged += new System.EventHandler(this.HourlyCheckedChanged);
			// 
			// _paymentData
			// 
			this._paymentData.Controls.Add(this._workTime);
			this._paymentData.Controls.Add(this._increase);
			this._paymentData.Controls.Add(this._increaseText);
			this._paymentData.Controls.Add(this._workTimeText);
			this._paymentData.Controls.Add(this._additionalText);
			this._paymentData.Controls.Add(this._additional);
			this._paymentData.Controls.Add(this._timeUnits);
			this._paymentData.Controls.Add(this._timeWorkedText);
			this._paymentData.Controls.Add(this._timeWorked);
			this._paymentData.Controls.Add(this._mrotText);
			this._paymentData.Controls.Add(this._mrot);
			this._paymentData.Controls.Add(this._rateText);
			this._paymentData.Controls.Add(this._salaryRate);
			this._paymentData.Location = new System.Drawing.Point(12, 118);
			this._paymentData.Name = "_paymentData";
			this._paymentData.Size = new System.Drawing.Size(515, 98);
			this._paymentData.TabIndex = 2;
			this._paymentData.TabStop = false;
			this._paymentData.Text = "Payment Data";
			// 
			// _workTime
			// 
			this._workTime.AutoSize = true;
			this._workTime.Location = new System.Drawing.Point(354, 46);
			this._workTime.Name = "_workTime";
			this._workTime.Size = new System.Drawing.Size(71, 13);
			this._workTime.TabIndex = 13;
			this._workTime.Text = "Full work time";
			// 
			// _increase
			// 
			this._increase.AutoSize = true;
			this._increase.Location = new System.Drawing.Point(10, 73);
			this._increase.Name = "_increase";
			this._increase.Size = new System.Drawing.Size(48, 13);
			this._increase.TabIndex = 11;
			this._increase.Text = "Increase";
			// 
			// _increaseText
			// 
			this._increaseText.Location = new System.Drawing.Point(117, 70);
			this._increaseText.Name = "_increaseText";
			this._increaseText.Size = new System.Drawing.Size(100, 20);
			this._increaseText.TabIndex = 4;
			// 
			// _workTimeText
			// 
			this._workTimeText.Location = new System.Drawing.Point(431, 43);
			this._workTimeText.Name = "_workTimeText";
			this._workTimeText.Size = new System.Drawing.Size(38, 20);
			this._workTimeText.TabIndex = 3;
			// 
			// _additionalText
			// 
			this._additionalText.Location = new System.Drawing.Point(117, 43);
			this._additionalText.Name = "_additionalText";
			this._additionalText.Size = new System.Drawing.Size(100, 20);
			this._additionalText.TabIndex = 2;
			// 
			// _additional
			// 
			this._additional.AutoSize = true;
			this._additional.Location = new System.Drawing.Point(10, 46);
			this._additional.Name = "_additional";
			this._additional.Size = new System.Drawing.Size(101, 13);
			this._additional.TabIndex = 7;
			this._additional.Text = "Additional payments";
			// 
			// _timeUnits
			// 
			this._timeUnits.AutoSize = true;
			this._timeUnits.Location = new System.Drawing.Point(470, 20);
			this._timeUnits.Name = "_timeUnits";
			this._timeUnits.Size = new System.Drawing.Size(35, 13);
			this._timeUnits.TabIndex = 6;
			this._timeUnits.Text = "day(s)";
			// 
			// _timeWorkedText
			// 
			this._timeWorkedText.Location = new System.Drawing.Point(431, 17);
			this._timeWorkedText.Name = "_timeWorkedText";
			this._timeWorkedText.Size = new System.Drawing.Size(38, 20);
			this._timeWorkedText.TabIndex = 1;
			// 
			// _timeWorked
			// 
			this._timeWorked.AutoSize = true;
			this._timeWorked.Location = new System.Drawing.Point(354, 20);
			this._timeWorked.Name = "_timeWorked";
			this._timeWorked.Size = new System.Drawing.Size(68, 13);
			this._timeWorked.TabIndex = 4;
			this._timeWorked.Text = "Time worked";
			// 
			// _mrotText
			// 
			this._mrotText.Location = new System.Drawing.Point(431, 70);
			this._mrotText.Name = "_mrotText";
			this._mrotText.Size = new System.Drawing.Size(38, 20);
			this._mrotText.TabIndex = 5;
			// 
			// _mrot
			// 
			this._mrot.AutoSize = true;
			this._mrot.Location = new System.Drawing.Point(354, 73);
			this._mrot.Name = "_mrot";
			this._mrot.Size = new System.Drawing.Size(39, 13);
			this._mrot.TabIndex = 2;
			this._mrot.Text = "MROT";
			// 
			// _rateText
			// 
			this._rateText.Location = new System.Drawing.Point(117, 17);
			this._rateText.Name = "_rateText";
			this._rateText.Size = new System.Drawing.Size(100, 20);
			this._rateText.TabIndex = 0;
			// 
			// _salaryRate
			// 
			this._salaryRate.AutoSize = true;
			this._salaryRate.Location = new System.Drawing.Point(10, 20);
			this._salaryRate.Name = "_salaryRate";
			this._salaryRate.Size = new System.Drawing.Size(30, 13);
			this._salaryRate.TabIndex = 0;
			this._salaryRate.Text = "Rate";
			// 
			// _ok
			// 
			this._ok.DialogResult = System.Windows.Forms.DialogResult.OK;
			this._ok.Location = new System.Drawing.Point(533, 12);
			this._ok.Name = "_ok";
			this._ok.Size = new System.Drawing.Size(75, 23);
			this._ok.TabIndex = 3;
			this._ok.Text = "OK";
			this._ok.UseVisualStyleBackColor = true;
			this._ok.Click += new System.EventHandler(this.OkClick);
			// 
			// _cancel
			// 
			this._cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this._cancel.Location = new System.Drawing.Point(533, 41);
			this._cancel.Name = "_cancel";
			this._cancel.Size = new System.Drawing.Size(75, 23);
			this._cancel.TabIndex = 4;
			this._cancel.Text = "Cancel";
			this._cancel.UseVisualStyleBackColor = true;
			// 
			// AddEmployeeForm
			// 
			this.AcceptButton = this._ok;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this._cancel;
			this.ClientSize = new System.Drawing.Size(615, 221);
			this.Controls.Add(this._cancel);
			this.Controls.Add(this._ok);
			this.Controls.Add(this._paymentData);
			this.Controls.Add(this._payMent);
			this.Controls.Add(this._name);
			this.Name = "AddEmployeeForm";
			this.Text = " Employee Data";
			this._name.ResumeLayout(false);
			this._name.PerformLayout();
			this._payMent.ResumeLayout(false);
			this._payMent.PerformLayout();
			this._paymentData.ResumeLayout(false);
			this._paymentData.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox _name;
		private System.Windows.Forms.Label _lastName;
		private System.Windows.Forms.Label _secondName;
		private System.Windows.Forms.Label _firstName;
		private System.Windows.Forms.GroupBox _payMent;
		private System.Windows.Forms.GroupBox _paymentData;
		private System.Windows.Forms.Label _salaryRate;
		private System.Windows.Forms.TextBox _mrotText;
		private System.Windows.Forms.Label _mrot;
		private System.Windows.Forms.Label _timeUnits;
		private System.Windows.Forms.Label _timeWorked;
		private System.Windows.Forms.Label _workTime;
		private System.Windows.Forms.Label _increase;
		private System.Windows.Forms.Label _additional;
		private System.Windows.Forms.Button _ok;
		private System.Windows.Forms.Button _cancel;
		protected System.Windows.Forms.TextBox _rateText;
		protected System.Windows.Forms.TextBox _timeWorkedText;
		protected System.Windows.Forms.TextBox _increaseText;
		protected System.Windows.Forms.TextBox _workTimeText;
		protected System.Windows.Forms.TextBox _additionalText;
		protected System.Windows.Forms.TextBox _lastNameText;
		protected System.Windows.Forms.TextBox _secondNameText;
		protected System.Windows.Forms.TextBox _firstNameText;
		protected System.Windows.Forms.RadioButton _rate;
		protected System.Windows.Forms.RadioButton _scale;
		protected System.Windows.Forms.RadioButton _hourly;
	}
}