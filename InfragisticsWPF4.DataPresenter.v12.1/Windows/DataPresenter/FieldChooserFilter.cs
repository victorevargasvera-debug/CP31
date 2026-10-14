using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200010A RID: 266
	public class FieldChooserFilter : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x06000DF1 RID: 3569 RVA: 0x0003BE28 File Offset: 0x0003A028
		public FieldChooserFilter()
		{
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x0003BE30 File Offset: 0x0003A030
		public FieldChooserFilter(string description, global::System.Predicate<global::Infragistics.Windows.DataPresenter.Field> filter, string toolTip)
		{
			this._description = description;
			this._filter = filter;
			this._toolTip = toolTip;
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000DF3 RID: 3571 RVA: 0x0003BE4D File Offset: 0x0003A04D
		// (set) Token: 0x06000DF4 RID: 3572 RVA: 0x0003BE55 File Offset: 0x0003A055
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

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x0003BE77 File Offset: 0x0003A077
		// (set) Token: 0x06000DF6 RID: 3574 RVA: 0x0003BE7F File Offset: 0x0003A07F
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

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000DF7 RID: 3575 RVA: 0x0003BEA1 File Offset: 0x0003A0A1
		// (set) Token: 0x06000DF8 RID: 3576 RVA: 0x0003BEA9 File Offset: 0x0003A0A9
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

		// Token: 0x06000DF9 RID: 3577 RVA: 0x0003BEC6 File Offset: 0x0003A0C6
		internal global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Field> GetMatchingFields(global::Infragistics.Windows.DataPresenter.FieldLayout fl)
		{
			return this.GetMatchingFields(global::Infragistics.Windows.DataPresenter.FieldChooserGroup.DefaultFieldFilter.Filter(fl.Fields));
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x0003BED9 File Offset: 0x0003A0D9
		internal global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Field> GetMatchingFields(global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.Field> fields)
		{
			if (this._filter == null)
			{
				return fields;
			}
			return global::Infragistics.Windows.DataPresenter.GridUtilities.Filter<global::Infragistics.Windows.DataPresenter.Field>(fields, this._filter);
		}

		// Token: 0x04000565 RID: 1381
		private string _description;

		// Token: 0x04000566 RID: 1382
		private global::System.Predicate<global::Infragistics.Windows.DataPresenter.Field> _filter;

		// Token: 0x04000567 RID: 1383
		private object _toolTip;
	}
}
