using System;
using System.Collections.Generic;
using Infragistics.Collections;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000270 RID: 624
	public class ChildBandCollection : global::Infragistics.Collections.CollectionBase<global::Infragistics.Controls.Grids.Primitives.ChildBand>
	{
		// Token: 0x1700065E RID: 1630
		public global::Infragistics.Controls.Grids.Primitives.ChildBand this[string key]
		{
			get
			{
				foreach (global::Infragistics.Controls.Grids.Primitives.ChildBand childBand in this.Items)
				{
					if (childBand.ColumnLayout.Key == key)
					{
						return childBand;
					}
				}
				return null;
			}
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x0004C3AC File Offset: 0x0004A5AC
		internal void Sort(global::System.Collections.Generic.IComparer<global::Infragistics.Controls.Grids.Primitives.ChildBand> comparer)
		{
			global::Infragistics.Controls.Grids.Primitives.ChildBand[] array = new global::Infragistics.Controls.Grids.Primitives.ChildBand[this.Items.Count];
			this.Items.CopyTo(array, 0);
			global::System.Array.Sort<global::Infragistics.Controls.Grids.Primitives.ChildBand>(array, comparer);
			this.Items.Clear();
			foreach (global::Infragistics.Controls.Grids.Primitives.ChildBand item in array)
			{
				this.Items.Add(item);
			}
		}
	}
}
