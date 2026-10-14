using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000C6 RID: 198
	public class FilterMenuTrackingObject : global::System.ComponentModel.INotifyPropertyChanged, global::Infragistics.IProvidePropertyPersistenceSettings
	{
		// Token: 0x060006CF RID: 1743 RVA: 0x0001DBA7 File Offset: 0x0001BDA7
		public FilterMenuTrackingObject()
		{
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x0001DBBA File Offset: 0x0001BDBA
		public FilterMenuTrackingObject(global::Infragistics.Controls.Grids.FilterOperand fo)
		{
			this.FilterOperands.Add(fo);
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x0001DBD9 File Offset: 0x0001BDD9
		public global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterOperand> FilterOperands
		{
			get
			{
				if (this._filterOperands == null)
				{
					this._filterOperands = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterOperand>();
				}
				return this._filterOperands;
			}
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x060006D2 RID: 1746 RVA: 0x0001DBF4 File Offset: 0x0001BDF4
		// (set) Token: 0x060006D3 RID: 1747 RVA: 0x0001DBFC File Offset: 0x0001BDFC
		public bool IsSeparator { get; set; }

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x060006D4 RID: 1748 RVA: 0x0001DC05 File Offset: 0x0001BE05
		public bool IsCheckable
		{
			get
			{
				return !this.IsSeparator && this.FilterOperands != null && this.FilterOperands.Count > 0;
			}
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x0001DC30 File Offset: 0x0001BE30
		// (set) Token: 0x060006D5 RID: 1749 RVA: 0x0001DC27 File Offset: 0x0001BE27
		public string Label
		{
			get
			{
				if (!string.IsNullOrEmpty(this._label))
				{
					return this._label;
				}
				if (this.FilterOperands.Count > 0)
				{
					return this.FilterOperands[0].DisplayName;
				}
				return "";
			}
			set
			{
				this._label = value;
			}
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x0001DC6B File Offset: 0x0001BE6B
		// (set) Token: 0x060006D8 RID: 1752 RVA: 0x0001DC73 File Offset: 0x0001BE73
		public bool IsChecked
		{
			get
			{
				return this._isChecked;
			}
			set
			{
				if (value != this._isChecked)
				{
					this._isChecked = value;
					this.OnPropertyChanged("IsChecked");
				}
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x060006D9 RID: 1753 RVA: 0x0001DC90 File Offset: 0x0001BE90
		public global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterMenuTrackingObject> Children
		{
			get
			{
				if (this._children == null)
				{
					this._children = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterMenuTrackingObject>();
				}
				return this._children;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x060006DA RID: 1754 RVA: 0x0001DCAB File Offset: 0x0001BEAB
		// (set) Token: 0x060006DB RID: 1755 RVA: 0x0001DCB3 File Offset: 0x0001BEB3
		public global::Infragistics.Controls.Grids.FilterColumnSettings FilterColumnSettings { get; protected internal set; }

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x060006DC RID: 1756 RVA: 0x0001DCBC File Offset: 0x0001BEBC
		// (set) Token: 0x060006DD RID: 1757 RVA: 0x0001DCC4 File Offset: 0x0001BEC4
		internal bool IsCustomOption { get; set; }

		// Token: 0x060006DE RID: 1758 RVA: 0x0001DCCD File Offset: 0x0001BECD
		protected virtual void OnPropertyChanged(string name)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060006DF RID: 1759 RVA: 0x0001DCEC File Offset: 0x0001BEEC
		// (remove) Token: 0x060006E0 RID: 1760 RVA: 0x0001DD24 File Offset: 0x0001BF24
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x0001DD5C File Offset: 0x0001BF5C
		protected virtual global::System.Collections.Generic.List<string> PropertiesToIgnore
		{
			get
			{
				if (this._propertiesThatShouldntBePersisted == null)
				{
					this._propertiesThatShouldntBePersisted = new global::System.Collections.Generic.List<string>
					{
						"FilterColumnSettings"
					};
				}
				return this._propertiesThatShouldntBePersisted;
			}
		}

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x0001DD8F File Offset: 0x0001BF8F
		global::System.Collections.Generic.List<string> global::Infragistics.IProvidePropertyPersistenceSettings.PropertiesToIgnore
		{
			get
			{
				return this.PropertiesToIgnore;
			}
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060006E3 RID: 1763 RVA: 0x0001DD97 File Offset: 0x0001BF97
		protected virtual global::System.Collections.Generic.List<string> PriorityProperties
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x0001DD9A File Offset: 0x0001BF9A
		global::System.Collections.Generic.List<string> global::Infragistics.IProvidePropertyPersistenceSettings.PriorityProperties
		{
			get
			{
				return this.PriorityProperties;
			}
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x0001DDA2 File Offset: 0x0001BFA2
		protected virtual void FinishedLoadingPersistence()
		{
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0001DDA4 File Offset: 0x0001BFA4
		void global::Infragistics.IProvidePropertyPersistenceSettings.FinishedLoadingPersistence()
		{
			this.FinishedLoadingPersistence();
		}

		// Token: 0x040001B9 RID: 441
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterMenuTrackingObject> _children = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterMenuTrackingObject>();

		// Token: 0x040001BA RID: 442
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.FilterOperand> _filterOperands;

		// Token: 0x040001BB RID: 443
		private string _label;

		// Token: 0x040001BC RID: 444
		private bool _isChecked;

		// Token: 0x040001BE RID: 446
		private global::System.Collections.Generic.List<string> _propertiesThatShouldntBePersisted;
	}
}
