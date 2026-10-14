using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;

namespace Infragistics.Controls.Layouts.Primitives
{
	// Token: 0x0200003D RID: 61
	public class GridBagLayoutItemDimensionsCollection : global::System.Collections.ICollection, global::System.Collections.IEnumerable
	{
		// Token: 0x06000292 RID: 658 RVA: 0x0000AEA0 File Offset: 0x000090A0
		internal GridBagLayoutItemDimensionsCollection(double[] columnDims, double[] rowDims)
		{
			if (columnDims == null)
			{
				throw new global::System.ArgumentNullException("columnDims");
			}
			if (rowDims == null)
			{
				throw new global::System.ArgumentNullException("rowDims ");
			}
			this._columnDims = columnDims;
			this._rowDims = rowDims;
			this._mappings = new global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensions>();
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x06000293 RID: 659 RVA: 0x0000AEDD File Offset: 0x000090DD
		public double[] ColumnDims
		{
			get
			{
				return this._columnDims;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x06000294 RID: 660 RVA: 0x0000AEE5 File Offset: 0x000090E5
		public global::System.Windows.Size MaximumSize
		{
			get
			{
				return this._maximumSize;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000295 RID: 661 RVA: 0x0000AEED File Offset: 0x000090ED
		public global::System.Windows.Size MinimumSize
		{
			get
			{
				return this._minimumSize;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000296 RID: 662 RVA: 0x0000AEF5 File Offset: 0x000090F5
		public global::System.Windows.Size PreferredSize
		{
			get
			{
				return this._preferredSize;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000297 RID: 663 RVA: 0x0000AEFD File Offset: 0x000090FD
		public double[] RowDims
		{
			get
			{
				return this._rowDims;
			}
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000AF05 File Offset: 0x00009105
		internal void Add(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem key, global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensions itemDimensions)
		{
			this._mappings[key] = itemDimensions;
		}

		// Token: 0x06000299 RID: 665 RVA: 0x0000AF14 File Offset: 0x00009114
		internal void InitializeLayoutSizes(global::System.Windows.Size preferredSize, global::System.Windows.Size minimumSize, global::System.Windows.Size maximumSize)
		{
			this._preferredSize = preferredSize;
			this._minimumSize = minimumSize;
			this._maximumSize = maximumSize;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000AF2B File Offset: 0x0000912B
		public bool Exists(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem key)
		{
			return this._mappings.ContainsKey(key);
		}

		// Token: 0x1700005A RID: 90
		public global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensions this[global::Infragistics.Controls.Layouts.Primitives.ILayoutItem key]
		{
			get
			{
				global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensions result;
				if (this._mappings.TryGetValue(key, out result))
				{
					return result;
				}
				return null;
			}
		}

		// Token: 0x0600029C RID: 668 RVA: 0x0000AF5C File Offset: 0x0000915C
		void global::System.Collections.ICollection.CopyTo(global::System.Array array, int index)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x0600029D RID: 669 RVA: 0x0000AF63 File Offset: 0x00009163
		bool global::System.Collections.ICollection.IsSynchronized
		{
			get
			{
				return ((global::System.Collections.ICollection)this._mappings).IsSynchronized;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600029E RID: 670 RVA: 0x0000AF70 File Offset: 0x00009170
		int global::System.Collections.ICollection.Count
		{
			get
			{
				return this._mappings.Count;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600029F RID: 671 RVA: 0x0000AF7D File Offset: 0x0000917D
		object global::System.Collections.ICollection.SyncRoot
		{
			get
			{
				return ((global::System.Collections.ICollection)this._mappings).SyncRoot;
			}
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0000AF8A File Offset: 0x0000918A
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this._mappings.Keys.GetEnumerator();
		}

		// Token: 0x040000A3 RID: 163
		private double[] _columnDims;

		// Token: 0x040000A4 RID: 164
		private double[] _rowDims;

		// Token: 0x040000A5 RID: 165
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensions> _mappings;

		// Token: 0x040000A6 RID: 166
		private global::System.Windows.Size _preferredSize;

		// Token: 0x040000A7 RID: 167
		private global::System.Windows.Size _minimumSize;

		// Token: 0x040000A8 RID: 168
		private global::System.Windows.Size _maximumSize;
	}
}
