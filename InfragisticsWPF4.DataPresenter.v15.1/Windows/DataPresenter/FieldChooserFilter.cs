using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000126 RID: 294
	public class FieldChooserFilter : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x06001152 RID: 4434 RVA: 0x0004C8E8 File Offset: 0x0004AAE8
		public FieldChooserFilter()
		{
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x0004C8F0 File Offset: 0x0004AAF0
		public FieldChooserFilter(string description, global::System.Predicate<global::Infragistics.Windows.DataPresenter.Field> filter, string toolTip)
		{
			this._description = description;
			this._filter = filter;
			this._toolTip = toolTip;
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06001154 RID: 4436 RVA: 0x0004C90D File Offset: 0x0004AB0D
		// (set) Token: 0x06001155 RID: 4437 RVA: 0x0004C915 File Offset: 0x0004AB15
		[global::System.ComponentModel.Bindable(true)]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (this._description != value)
				{
					this._description = value;
					base.RaisePropertyChangedEvent("Description");
				}
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06001156 RID: 4438 RVA: 0x0004C937 File Offset: 0x0004AB37
		// (set) Token: 0x06001157 RID: 4439 RVA: 0x0004C93F File Offset: 0x0004AB3F
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Predicate<global::Infragistics.Windows.DataPresenter.Field> Filter
		{
			get
			{
				return this._filter;
			}
			set
			{
				if (this._filter != value)
				{
					this._filter = value;
					base.RaisePropertyChangedEvent("Filter");
				}
			}
		}

		// Token: 0x17000449 RID: 1097
		// (get) Token: 0x06001158 RID: 4440 RVA: 0x0004C961 File Offset: 0x0004AB61
		// (set) Token: 0x06001159 RID: 4441 RVA: 0x0004C969 File Offset: 0x0004AB69
		[global::System.ComponentModel.Bindable(true)]
		public object ToolTip
		{
			get
			{
				return this._toolTip;
			}
			set
			{
				if (this._toolTip != value)
				{
					this._toolTip = value;
					base.RaisePropertyChangedEvent("ToolTip");
				}
			}
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x0004C986 File Offset: 0x0004AB86
		internal global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Field> GetMatchingFields(global::Infragistics.Windows.DataPresenter.FieldLayout fl)
		{
			return this.GetMatchingFields(global::Infragistics.Windows.DataPresenter.FieldChooserGroup.DefaultFieldFilter.Filter(fl.Fields));
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x0004C999 File Offset: 0x0004AB99
		internal global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Field> GetMatchingFields(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Field> fields)
		{
			if (this._filter == null)
			{
				return fields;
			}
			return global::Infragistics.Windows.DataPresenter.GridUtilities.Filter<global::Infragistics.Windows.DataPresenter.Field>(fields, this._filter);
		}

		// Token: 0x04000704 RID: 1796
		private string _description;

		// Token: 0x04000705 RID: 1797
		private global::System.Predicate<global::Infragistics.Windows.DataPresenter.Field> _filter;

		// Token: 0x04000706 RID: 1798
		private object _toolTip;
	}
}
