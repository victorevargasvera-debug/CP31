using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000262 RID: 610
	public class ReadOnlyKeyedColumnBaseCollection<T> : global::System.Collections.ObjectModel.ReadOnlyCollection<T> where T : global::Infragistics.Controls.Grids.ColumnBase
	{
		// Token: 0x06001390 RID: 5008 RVA: 0x00049AE1 File Offset: 0x00047CE1
		public ReadOnlyKeyedColumnBaseCollection(global::System.Collections.Generic.IList<T> list) : base(list)
		{
		}

		// Token: 0x170005E0 RID: 1504
		public T this[string key]
		{
			get
			{
				T result = default(T);
				foreach (T t in base.Items)
				{
					if (t.Key == key)
					{
						result = t;
						break;
					}
				}
				return result;
			}
		}
	}
}
