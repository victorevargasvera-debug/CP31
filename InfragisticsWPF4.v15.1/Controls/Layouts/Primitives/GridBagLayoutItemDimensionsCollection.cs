using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows;

namespace Infragistics.Controls.Layouts.Primitives
{
	// Token: 0x02000051 RID: 81
	public class GridBagLayoutItemDimensionsCollection : global::System.Collections.ICollection, global::System.Collections.IEnumerable
	{
		// Token: 0x06000323 RID: 803 RVA: 0x0000C92C File Offset: 0x0000AB2C
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

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000324 RID: 804 RVA: 0x0000C969 File Offset: 0x0000AB69
		public double[] ColumnDims
		{
			get
			{
				return this._columnDims;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000325 RID: 805 RVA: 0x0000C971 File Offset: 0x0000AB71
		public global::System.Windows.Size MaximumSize
		{
			get
			{
				return this._maximumSize;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000326 RID: 806 RVA: 0x0000C979 File Offset: 0x0000AB79
		public global::System.Windows.Size MinimumSize
		{
			get
			{
				return this._minimumSize;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000327 RID: 807 RVA: 0x0000C981 File Offset: 0x0000AB81
		public global::System.Windows.Size PreferredSize
		{
			get
			{
				return this._preferredSize;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000328 RID: 808 RVA: 0x0000C989 File Offset: 0x0000AB89
		public double[] RowDims
		{
			get
			{
				return this._rowDims;
			}
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0000C991 File Offset: 0x0000AB91
		internal void Add(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem key, global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensions itemDimensions)
		{
			this._mappings[key] = itemDimensions;
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0000C9A0 File Offset: 0x0000ABA0
		internal void InitializeLayoutSizes(global::System.Windows.Size preferredSize, global::System.Windows.Size minimumSize, global::System.Windows.Size maximumSize)
		{
			this._preferredSize = preferredSize;
			this._minimumSize = minimumSize;
			this._maximumSize = maximumSize;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000C9B7 File Offset: 0x0000ABB7
		public bool Exists(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem key)
		{
			return this._mappings.ContainsKey(key);
		}

		// Token: 0x17000069 RID: 105
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

		// Token: 0x0600032D RID: 813 RVA: 0x0000C9E8 File Offset: 0x0000ABE8
		void global::System.Collections.ICollection.CopyTo(global::System.Array array, int index)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600032E RID: 814 RVA: 0x0000C9EF File Offset: 0x0000ABEF
		bool global::System.Collections.ICollection.IsSynchronized
		{
			get
			{
				return ((global::System.Collections.ICollection)this._mappings).IsSynchronized;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600032F RID: 815 RVA: 0x0000C9FC File Offset: 0x0000ABFC
		int global::System.Collections.ICollection.Count
		{
			get
			{
				return this._mappings.Count;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000330 RID: 816 RVA: 0x0000CA09 File Offset: 0x0000AC09
		object global::System.Collections.ICollection.SyncRoot
		{
			get
			{
				return ((global::System.Collections.ICollection)this._mappings).SyncRoot;
			}
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000CA16 File Offset: 0x0000AC16
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this._mappings.Keys.GetEnumerator();
		}

		// Token: 0x040000FE RID: 254
		private double[] _columnDims;

		// Token: 0x040000FF RID: 255
		private double[] _rowDims;

		// Token: 0x04000100 RID: 256
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, global::Infragistics.Controls.Layouts.Primitives.GridBagLayoutItemDimensions> _mappings;

		// Token: 0x04000101 RID: 257
		private global::System.Windows.Size _preferredSize;

		// Token: 0x04000102 RID: 258
		private global::System.Windows.Size _minimumSize;

		// Token: 0x04000103 RID: 259
		private global::System.Windows.Size _maximumSize;
	}
}
