using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000124 RID: 292
	public class FieldChooserGroup : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x06001147 RID: 4423 RVA: 0x0004C771 File Offset: 0x0004A971
		public FieldChooserGroup(global::Infragistics.Windows.DataPresenter.FieldLayout fieldLayout, global::Infragistics.Windows.DataPresenter.FieldChooserFilter fieldFilter)
		{
			this._fieldLayout = fieldLayout;
			this._fieldFilter = fieldFilter;
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x0004C788 File Offset: 0x0004A988
		public override bool Equals(object obj)
		{
			global::Infragistics.Windows.DataPresenter.FieldChooserGroup fieldChooserGroup = obj as global::Infragistics.Windows.DataPresenter.FieldChooserGroup;
			return fieldChooserGroup != null && fieldChooserGroup._fieldFilter == this._fieldFilter && fieldChooserGroup._fieldLayout == this._fieldLayout;
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x0004C7BE File Offset: 0x0004A9BE
		public override int GetHashCode()
		{
			return ((this._fieldLayout != null) ? this._fieldLayout.GetHashCode() : 0) ^ ((this._fieldFilter != null) ? this._fieldFilter.GetHashCode() : 0);
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x0004C7F0 File Offset: 0x0004A9F0
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

		// Token: 0x17000444 RID: 1092
		// (get) Token: 0x0600114B RID: 4427 RVA: 0x0004C84A File Offset: 0x0004AA4A
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.FieldChooserFilter FieldFilter
		{
			get
			{
				return this._fieldFilter;
			}
		}

		// Token: 0x17000445 RID: 1093
		// (get) Token: 0x0600114C RID: 4428 RVA: 0x0004C852 File Offset: 0x0004AA52
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.FieldLayout FieldLayout
		{
			get
			{
				return this._fieldLayout;
			}
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x0600114D RID: 4429 RVA: 0x0004C85A File Offset: 0x0004AA5A
		[global::System.ComponentModel.Bindable(true)]
		public bool HasFieldFilter
		{
			get
			{
				return null != this._fieldFilter;
			}
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x0004C868 File Offset: 0x0004AA68
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

		// Token: 0x04000702 RID: 1794
		private global::Infragistics.Windows.DataPresenter.FieldLayout _fieldLayout;

		// Token: 0x04000703 RID: 1795
		private global::Infragistics.Windows.DataPresenter.FieldChooserFilter _fieldFilter;

		// Token: 0x02000125 RID: 293
		internal class DefaultFieldFilter : global::Infragistics.Windows.DataPresenter.GridUtilities.IMeetsCriteria
		{
			// Token: 0x0600114F RID: 4431 RVA: 0x0004C8A8 File Offset: 0x0004AAA8
			public bool MeetsCriteria(object item)
			{
				global::Infragistics.Windows.DataPresenter.Field field = item as global::Infragistics.Windows.DataPresenter.Field;
				return field != null && !field.IsExpandableResolved && global::Infragistics.Windows.DataPresenter.AllowFieldHiding.Never != field.AllowHidingResolved;
			}

			// Token: 0x06001150 RID: 4432 RVA: 0x0004C8D3 File Offset: 0x0004AAD3
			public static global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Field> Filter(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Field> fields)
			{
				return global::Infragistics.Windows.DataPresenter.GridUtilities.Filter<global::Infragistics.Windows.DataPresenter.Field>(fields, new global::Infragistics.Windows.DataPresenter.FieldChooserGroup.DefaultFieldFilter());
			}
		}
	}
}
