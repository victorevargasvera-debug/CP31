using System;
using System.Collections;
using System.Collections.Generic;

namespace Infragistics.Controls.Layouts.Primitives
{
	// Token: 0x0200006F RID: 111
	public class LayoutItemsCollection : global::System.Collections.Generic.ICollection<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem>, global::System.Collections.Generic.IEnumerable<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem>, global::System.Collections.IEnumerable
	{
		// Token: 0x06000423 RID: 1059 RVA: 0x00011B3D File Offset: 0x0000FD3D
		public LayoutItemsCollection(global::Infragistics.Controls.Layouts.Primitives.LayoutManagerBase layoutManager)
		{
			if (layoutManager == null)
			{
				throw new global::System.ArgumentNullException("layoutManager");
			}
			this._layoutManager = layoutManager;
			this._layoutItems = new global::System.Collections.Generic.List<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem>();
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x00011B65 File Offset: 0x0000FD65
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

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x00011B80 File Offset: 0x0000FD80
		private global::Infragistics.Controls.Layouts.Primitives.LayoutManagerBase LayoutManager
		{
			get
			{
				return this._layoutManager;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x00011B88 File Offset: 0x0000FD88
		protected global::System.Collections.Generic.List<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem> LayoutItems
		{
			get
			{
				return this._layoutItems;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x00011B90 File Offset: 0x0000FD90
		public int Count
		{
			get
			{
				return this.LayoutItems.Count;
			}
		}

		// Token: 0x1700009A RID: 154
		public global::Infragistics.Controls.Layouts.Primitives.ILayoutItem this[int index]
		{
			get
			{
				return this.GetItem(index);
			}
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x00011BA8 File Offset: 0x0000FDA8
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

		// Token: 0x0600042A RID: 1066 RVA: 0x00011BFC File Offset: 0x0000FDFC
		private void OnLayoutChanged()
		{
			this.LayoutManager.InternalOnLayoutChanged();
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00011C09 File Offset: 0x0000FE09
		private void ValidateConstraintObject(object constraint)
		{
			this.LayoutManager.InternalValidateConstraints(constraint);
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x00011C17 File Offset: 0x0000FE17
		public void Add(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem item)
		{
			this.Add(item, null);
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x00011C21 File Offset: 0x0000FE21
		public void Add(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem item, object constraint)
		{
			this.InternalSetConstraint(item, constraint, -1);
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00011C2C File Offset: 0x0000FE2C
		public bool Contains(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem item)
		{
			return this.LayoutItemsConstraints.ContainsKey(item);
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00011C3A File Offset: 0x0000FE3A
		public void Clear()
		{
			this.LayoutItems.Clear();
			this.LayoutItemsConstraints.Clear();
			this.OnLayoutChanged();
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x00011C58 File Offset: 0x0000FE58
		public void CopyTo(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem[] array, int arrayIndex)
		{
			this._layoutItems.CopyTo(array, arrayIndex);
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x00011C68 File Offset: 0x0000FE68
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

		// Token: 0x06000432 RID: 1074 RVA: 0x00011CA7 File Offset: 0x0000FEA7
		public global::Infragistics.Controls.Layouts.Primitives.ILayoutItem GetItem(int index)
		{
			return this.LayoutItems[index];
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00011CB5 File Offset: 0x0000FEB5
		public int IndexOf(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem item)
		{
			return this.LayoutItems.IndexOf(item);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00011CC3 File Offset: 0x0000FEC3
		public void Insert(int index, global::Infragistics.Controls.Layouts.Primitives.ILayoutItem item)
		{
			this.Insert(index, item, null);
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00011CCE File Offset: 0x0000FECE
		public void Insert(int index, global::Infragistics.Controls.Layouts.Primitives.ILayoutItem item, object constraint)
		{
			this.InternalSetConstraint(item, constraint, index);
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x00011CD9 File Offset: 0x0000FED9
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

		// Token: 0x06000437 RID: 1079 RVA: 0x00011D0C File Offset: 0x0000FF0C
		public void RemoveAt(int index)
		{
			this.LayoutItems.RemoveAt(index);
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x00011D1A File Offset: 0x0000FF1A
		public void SetConstraint(global::Infragistics.Controls.Layouts.Primitives.ILayoutItem item, object constraint)
		{
			this.InternalSetConstraint(item, constraint, -1);
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x00011D25 File Offset: 0x0000FF25
		bool global::System.Collections.Generic.ICollection<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem>.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00011D28 File Offset: 0x0000FF28
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this._layoutItems.GetEnumerator();
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00011D3A File Offset: 0x0000FF3A
		global::System.Collections.Generic.IEnumerator<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem> global::System.Collections.Generic.IEnumerable<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem>.GetEnumerator()
		{
			return this._layoutItems.GetEnumerator();
		}

		// Token: 0x04000197 RID: 407
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem, object> _layoutItemsConstraints;

		// Token: 0x04000198 RID: 408
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Layouts.Primitives.ILayoutItem> _layoutItems;

		// Token: 0x04000199 RID: 409
		private global::Infragistics.Controls.Layouts.Primitives.LayoutManagerBase _layoutManager;
	}
}
