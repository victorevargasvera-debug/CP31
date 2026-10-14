using System;
using System.Collections;
using System.Collections.Generic;

namespace Infragistics.Controls.Layouts.Primitives
{
	// Token: 0x0200005B RID: 91
	public class LayoutItemsCollection : global::System.Collections.Generic.ICollection<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem>, global::System.Collections.Generic.IEnumerable<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem>, global::System.Collections.IEnumerable
	{
		// Token: 0x0600038E RID: 910 RVA: 0x0000FED5 File Offset: 0x0000E0D5
		public LayoutItemsCollection(global::Infragistics.Controls.Layouts.Primitives.LayoutManagerBase layoutManager)
		{
			if (layoutManager == null)
			{
				throw new global::System.ArgumentNullException("layoutManager");
			}
			this._layoutManager = layoutManager;
			this._layoutItems = new global::System.Collections.Generic.List<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem>();
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600038F RID: 911 RVA: 0x0000FEFD File Offset: 0x0000E0FD
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, object> LayoutItemsConstraints
		{
			get
			{
				if (this._layoutItemsConstraints == null)
				{
					this._layoutItemsConstraints = new global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, object>();
				}
				return this._layoutItemsConstraints;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000390 RID: 912 RVA: 0x0000FF18 File Offset: 0x0000E118
		private global::Infragistics.Controls.Layouts.Primitives.LayoutManagerBase LayoutManager
		{
			get
			{
				return this._layoutManager;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000391 RID: 913 RVA: 0x0000FF20 File Offset: 0x0000E120
		protected global::System.Collections.Generic.List<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem> LayoutItems
		{
			get
			{
				return this._layoutItems;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000392 RID: 914 RVA: 0x0000FF28 File Offset: 0x0000E128
		public int Count
		{
			get
			{
				return this.LayoutItems.Count;
			}
		}

		// Token: 0x1700008B RID: 139
		public global::Infragistics.Controls.Layouts.Primitives.ILayoutItem this[int index]
		{
			get
			{
				return this.GetItem(index);
			}
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000FF40 File Offset: 0x0000E140
		private void InternalSetConstraint(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem item, object constraint, int index)
		{
			this.ValidateConstraintObject(constraint);
			if (!this.LayoutItemsConstraints.ContainsKey(item))
			{
				if (index < 0)
				{
					this.LayoutItems.Add(item);
				}
				else
				{
					this.LayoutItems.Insert(index, item);
				}
			}
			this.LayoutItemsConstraints[item] = constraint;
			this.OnLayoutChanged();
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000FF94 File Offset: 0x0000E194
		private void OnLayoutChanged()
		{
			this.LayoutManager.InternalOnLayoutChanged();
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0000FFA1 File Offset: 0x0000E1A1
		private void ValidateConstraintObject(object constraint)
		{
			this.LayoutManager.InternalValidateConstraints(constraint);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0000FFAF File Offset: 0x0000E1AF
		public void Add(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem item)
		{
			this.Add(item, null);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0000FFB9 File Offset: 0x0000E1B9
		public void Add(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem item, object constraint)
		{
			this.InternalSetConstraint(item, constraint, -1);
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0000FFC4 File Offset: 0x0000E1C4
		public bool Contains(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem item)
		{
			return this.LayoutItemsConstraints.ContainsKey(item);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0000FFD2 File Offset: 0x0000E1D2
		public void Clear()
		{
			this.LayoutItems.Clear();
			this.LayoutItemsConstraints.Clear();
			this.OnLayoutChanged();
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0000FFF0 File Offset: 0x0000E1F0
		public void CopyTo(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem[] array, int arrayIndex)
		{
			this._layoutItems.CopyTo(array, arrayIndex);
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00010000 File Offset: 0x0000E200
		public object GetConstraint(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem item)
		{
			object result;
			if (!this.LayoutItemsConstraints.TryGetValue(item, out result))
			{
				throw new global::System.ArgumentException(global::SR.GetString("LE_GridBag_ItemNotInLayoutItems", new object[]
				{
					item
				}), "item");
			}
			return result;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0001003F File Offset: 0x0000E23F
		public global::Infragistics.Controls.Layouts.Primitives.ILayoutItem GetItem(int index)
		{
			return this.LayoutItems[index];
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0001004D File Offset: 0x0000E24D
		public int IndexOf(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem item)
		{
			return this.LayoutItems.IndexOf(item);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0001005B File Offset: 0x0000E25B
		public void Insert(int index, global::Infragistics.Controls.Layouts.Primitives.ILayoutItem item)
		{
			this.Insert(index, item, null);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00010066 File Offset: 0x0000E266
		public void Insert(int index, global::Infragistics.Controls.Layouts.Primitives.ILayoutItem item, object constraint)
		{
			this.InternalSetConstraint(item, constraint, index);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00010071 File Offset: 0x0000E271
		public bool Remove(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem item)
		{
			if (this.LayoutItemsConstraints.ContainsKey(item))
			{
				this.LayoutItems.Remove(item);
				this.LayoutItemsConstraints.Remove(item);
				this.OnLayoutChanged();
				return true;
			}
			return false;
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x000100A4 File Offset: 0x0000E2A4
		public void RemoveAt(int index)
		{
			this.LayoutItems.RemoveAt(index);
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x000100B2 File Offset: 0x0000E2B2
		public void SetConstraint(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem item, object constraint)
		{
			this.InternalSetConstraint(item, constraint, -1);
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x000100BD File Offset: 0x0000E2BD
		bool global::System.Collections.Generic.ICollection<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x000100C0 File Offset: 0x0000E2C0
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this._layoutItems.GetEnumerator();
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x000100D2 File Offset: 0x0000E2D2
		global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem> global::System.Collections.Generic.IEnumerable<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem>.GetEnumerator()
		{
			return this._layoutItems.GetEnumerator();
		}

		// Token: 0x0400013C RID: 316
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, object> _layoutItemsConstraints;

		// Token: 0x0400013D RID: 317
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem> _layoutItems;

		// Token: 0x0400013E RID: 318
		private global::Infragistics.Controls.Layouts.Primitives.LayoutManagerBase _layoutManager;
	}
}
