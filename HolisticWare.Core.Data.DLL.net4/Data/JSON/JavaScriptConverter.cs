using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using System.Collections.ObjectModel;

namespace Core.Data.JSON
{
	public partial class JavaScriptConverter
	{
		public virtual IDictionary<string, object> Serialize(object obj, JavaScriptSerializer serializer)
		{
			throw new NotImplementedException();
		}

		public virtual object Deserialize(IDictionary<string, object> dictionary, Type type, JavaScriptSerializer serializer)
		{
			throw new NotImplementedException();
		}

		public virtual IEnumerable<Type> SupportedTypes
		{
			get 
				{
					throw new NotImplementedException();
					
					return new ReadOnlyCollection<Type>(new List<Type>(new Type[] { typeof(object) })); 
				}
		}
	}
}
