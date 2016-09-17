using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace SereneClean.Northwind
{
	public partial class NotesEditorAttribute : CustomEditorAttribute
	{
		public const string Key = "SereneClean.Northwind.NotesEditor";

		public NotesEditorAttribute()
			: base(Key)
		{
		}
	}
}

