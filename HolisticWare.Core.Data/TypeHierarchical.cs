using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HolisticWare.Core.Data
{
	public partial class TypeHierarchical<T>
	{

		//-------------------------------------------------------------------------
		# region Property IEnumerable<T> Children w Event post (ChildrenChanged)
		/// <summary>
		/// Children
		/// </summary>
		public
		  IEnumerable<T>
		  Children
		{
			get
			{
				return children;
			} // Children.get
			set
			{
				//if (children != value)		// do not write if equivalent/equal/same
				{
					// for multi threading apps uncomment lines beginnig with //MT:
					//MT: lock(children) // MultiThread safe				
					{
						children = value;
						if (null != ChildrenChanged)
						{
							ChildrenChanged(this, new EventArgs());
						}
					}
				}
			} // Children.set
		} // Children

		/// <summary>
		/// private member field for holding Children data
		/// </summary>
		private
			IEnumerable<T>
			children
			;

		///<summary>
		/// Event for wiring BusinessLogic object changes and presentation
		/// layer notifications.
		/// ChildrenChanged (<propertyname>Changed) is intercepted by Windows Forms
		/// 1.x and 2.0 event dispatcher 
		/// and for some CLR types by WPF event dispatcher 
		/// usually INotifyPropertyChanged and PropertyChanged event
		///</summary>
		public
			event
			EventHandler
			ChildrenChanged
			;
		# endregion Property IEnumerable<T> Children w Event post (ChildrenChanged)
		//-------------------------------------------------------------------------	
	}
}
