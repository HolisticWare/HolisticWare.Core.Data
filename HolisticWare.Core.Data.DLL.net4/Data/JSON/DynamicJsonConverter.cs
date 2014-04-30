﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Collections.ObjectModel;

namespace Core.Data.JSON
{
	public class DynamicJsonConverter : JavaScriptConverter
	{
		public override object Deserialize(IDictionary<string, object> dictionary, Type type, JavaScriptSerializer serializer)
		{
			if (dictionary == null)
				throw new ArgumentNullException("dictionary");

			if (type == typeof(object))
			{
				return new DynamicJsonObject(dictionary);
			}

			return null;
		}

		public override IDictionary<string, object> Serialize(object obj, JavaScriptSerializer serializer)
		{
			throw new NotImplementedException();
		}

		public override IEnumerable<Type> SupportedTypes
		{
			get { return new ReadOnlyCollection<Type>(new List<Type>(new Type[] { typeof(object) })); }
		}
	}
}
