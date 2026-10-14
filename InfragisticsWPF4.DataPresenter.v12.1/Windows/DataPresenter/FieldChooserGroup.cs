using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000108 RID: 264
	public class FieldChooserGroup : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x06000DE6 RID: 3558 RVA: 0x0003BCB1 File Offset: 0x00039EB1
		public FieldChooserGroup(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.FieldChooserFilter fieldFilter)
		{
			this._fieldLayout = fieldLayout;
			this._fieldFilter = fieldFilter;
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x0003BCC8 File Offset: 0x00039EC8
		public override bool Equals(object obj)
		{
			global::Infragistics.Windows.DataPresenter.FieldChooserGroup fieldChooserGroup = obj as global::Infragistics.Windows.DataPresenter.FieldChooserGroup;
			return fieldChooserGroup != null && fieldChooserGroup._fieldFilter == this._fieldFilter && fieldChooserGroup._fieldLayout == this._fieldLayout;
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x0003BCFE File Offset: 0x00039EFE
		public override int GetHashCode()
		{
			return ((this._fieldLayout != null) ? this._fieldLayout.GetHashCode() : 0) ^ ((this._fieldFilter != null) ? this._fieldFilter.GetHashCode() : 0);
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x0003BD30 File Offset: 0x00039F30
		public override string ToString()
		{
			string text = (this._fieldLayout != null) ? this._fieldLayout.Description : string.Empty;
			string text2 = (this._fieldFilter != null) ? this._fieldFilter.Description : string.Empty;
			if (text2.Length > 0)
			{
				return text + " - " + text2;
			}
			return text;
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000DEA RID: 3562 RVA: 0x0003BD8A File Offset: 0x00039F8A
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.FieldChooserFilter FieldFilter
		{
			get
			{
				return this._fieldFilter;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000DEB RID: 3563 RVA: 0x0003BD92 File Offset: 0x00039F92
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._fieldLayout;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000DEC RID: 3564 RVA: 0x0003BD9A File Offset: 0x00039F9A
		[global::System.ComponentModel.Bindable(true)]
		public bool HasFieldFilter
		{
			get
			{
				return null != this._fieldFilter;
			}
		}

		// Token: 0x06000DED RID: 3565 RVA: 0x0003BDA8 File Offset: 0x00039FA8
		internal global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Field> GetMatchingFields()
		{
			global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Field> enumerable = null;
			if (this._fieldLayout != null)
			{
				enumerable = global::Infragistics.Windows.DataPresenter.FieldChooserGroup.DefaultFieldFilter.Filter(this._fieldLayout.Fields);
				if (this._fieldFilter != null)
				{
					enumerable = this._fieldFilter.GetMatchingFields(enumerable);
				}
			}
			return enumerable;
		}

		// Token: 0x04000563 RID: 1379
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x04000564 RID: 1380
		private global::Infragistics.Windows.DataPresenter.FieldChooserFilter _fieldFilter;

		// Token: 0x02000109 RID: 265
		internal class DefaultFieldFilter : global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria
		{
			// Token: 0x06000DEE RID: 3566 RVA: 0x0003BDE8 File Offset: 0x00039FE8
			public bool MeetsCriteria(object item)
			{
				global::Infragistics.Windows.DataPresenter.Field field = item as global::Infragistics.Windows.DataPresenter.Field;
				return field != null && !field.IsExpandableResolved && global::Infragistics.Windows.DataPresenter.AllowFieldHiding.Never != field.AllowHidingResolved;
			}

			// Token: 0x06000DEF RID: 3567 RVA: 0x0003BE13 File Offset: 0x0003A013
			public static global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Field> Filter(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Field> fields)
			{
				return global::Infragistics.Windows.DataPresenter.GridUtilities.Filter<global::Infragistics.Windows.DataPresenter.Field>(fields, new global::Infragistics.Windows.DataPresenter.FieldChooserGroup.DefaultFieldFilter());
			}
		}
	}
}
