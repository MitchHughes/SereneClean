using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace SereneClean.Northwind
{
	public partial class EmployeeFormatterAttribute : CustomFormatterAttribute
	{
		public const string Key = "SereneClean.Northwind.EmployeeFormatter";

		public EmployeeFormatterAttribute()
			: base(Key)
		{
		}

		public String GenderProperty
		{
			get { return GetOption<String>("genderProperty"); }
			set { SetOption("genderProperty", value); }
		}
	}
}

