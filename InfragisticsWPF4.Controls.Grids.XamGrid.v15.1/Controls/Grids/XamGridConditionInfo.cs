using System;
using System.ComponentModel;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000EB RID: 235
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	[global::System.ComponentModel.Browsable(false)]
	public class XamGridConditionInfo : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x060007B4 RID: 1972 RVA: 0x0001FCF0 File Offset: 0x0001DEF0
		public XamGridConditionInfo(global::Infragistics.Controls.Grids.XamGridConditionInfoGroup parentGroup)
		{
			this.Group = parentGroup;
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x060007B5 RID: 1973 RVA: 0x0001FCFF File Offset: 0x0001DEFF
		// (set) Token: 0x060007B6 RID: 1974 RVA: 0x0001FD08 File Offset: 0x0001DF08
		public global::Infragistics.Controls.Grids.XamGridConditionInfoGroup Group
		{
			get
			{
				return this._group;
			}
			set
			{
				if (this._group != null)
				{
					this._group.InfoObjects.Remove(this);
				}
				this._group = value;
				if (this._group != null)
				{
					this._group.InfoObjects.Add(this);
				}
				this.OnPropertyChanged("Group");
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x060007B7 RID: 1975 RVA: 0x0001FD5A File Offset: 0x0001DF5A
		// (set) Token: 0x060007B8 RID: 1976 RVA: 0x0001FD62 File Offset: 0x0001DF62
		public global::Infragistics.Controls.Grids.FilterOperand FilterOperand
		{
			get
			{
				return this._filterOperand;
			}
			set
			{
				if (this._filterOperand != value)
				{
					this._filterOperand = value;
					if (this._filterOperand != null && !this._filterOperand.RequiresFilteringInput)
					{
						this.FilterValue = null;
					}
					this.OnPropertyChanged("FilterOperand");
				}
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x0001FD9B File Offset: 0x0001DF9B
		// (set) Token: 0x060007BA RID: 1978 RVA: 0x0001FDA4 File Offset: 0x0001DFA4
		public object FilterValue
		{
			get
			{
				return this._filterValue;
			}
			set
			{
				if (this._filterValue != value)
				{
					if (value is string && string.IsNullOrEmpty(value as string))
					{
						this._filterValue = null;
					}
					else
					{
						this._filterValue = value;
					}
					this.OnPropertyChanged("Value");
					this.OnPropertyChanged("FilterValue");
				}
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x060007BB RID: 1979 RVA: 0x0001FDF5 File Offset: 0x0001DFF5
		// (set) Token: 0x060007BC RID: 1980 RVA: 0x0001FDFD File Offset: 0x0001DFFD
		public object Value
		{
			get
			{
				return this._filterValue;
			}
			set
			{
				this.FilterValue = value;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x060007BD RID: 1981 RVA: 0x0001FE06 File Offset: 0x0001E006
		// (set) Token: 0x060007BE RID: 1982 RVA: 0x0001FE0E File Offset: 0x0001E00E
		public string ErrorMessage
		{
			get
			{
				return this._errorMessage;
			}
			set
			{
				if (this._errorMessage != value)
				{
					this._errorMessage = value;
					this.OnPropertyChanged("ErrorMessage");
				}
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x060007BF RID: 1983 RVA: 0x0001FE30 File Offset: 0x0001E030
		public bool HasError
		{
			get
			{
				return !string.IsNullOrEmpty(this._errorMessage);
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x0001FE40 File Offset: 0x0001E040
		public string InfoObjectName
		{
			get
			{
				if (this.Group != null)
				{
					return this.Group.LevelName + "." + this.Group.InfoObjects.IndexOf(this);
				}
				return "NoGroup";
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060007C1 RID: 1985 RVA: 0x0001FE7C File Offset: 0x0001E07C
		// (remove) Token: 0x060007C2 RID: 1986 RVA: 0x0001FEB4 File Offset: 0x0001E0B4
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x060007C3 RID: 1987 RVA: 0x0001FEE9 File Offset: 0x0001E0E9
		protected virtual void OnPropertyChanged(string name)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
			}
		}

		// Token: 0x040001E3 RID: 483
		private global::Infragistics.Controls.Grids.XamGridConditionInfoGroup _group;

		// Token: 0x040001E4 RID: 484
		private global::Infragistics.Controls.Grids.FilterOperand _filterOperand;

		// Token: 0x040001E5 RID: 485
		private object _filterValue;

		// Token: 0x040001E6 RID: 486
		private string _errorMessage;
	}
}
