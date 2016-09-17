using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace SereneClean.Northwind
{
	public partial class FreightFormatterAttribute : CustomFormatterAttribute
	{
		public const string Key = "SereneClean.Northwind.FreightFormatter";

		public FreightFormatterAttribute()
			: base(Key)
		{
		}
	}
}

