using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace SereneClean.Northwind
{
	public partial class CustomerEditorAttribute : LookupEditorBaseAttribute
	{
		public const string Key = "SereneClean.Northwind.CustomerEditor";

		public CustomerEditorAttribute()
			: base(Key)
		{
		}
	}
}

