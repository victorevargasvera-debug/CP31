using System;
using System.ComponentModel;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020000E4 RID: 228
	public class FilterValueProxy : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x06000747 RID: 1863 RVA: 0x0001F1E5 File Offset: 0x0001D3E5
		public FilterValueProxy()
		{
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x0001F1ED File Offset: 0x0001D3ED
		public FilterValueProxy(object value) : this(value, false)
		{
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x0001F1F7 File Offset: 0x0001D3F7
		public FilterValueProxy(object value, bool isChecked)
		{
			this._value = value;
			this._isChecked = isChecked;
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x0001F20D File Offset: 0x0001D40D
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x0001F215 File Offset: 0x0001D415
		public object Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if (this._value != value)
				{
					this._value = value;
					this.OnPropertyChanged("Value");
				}
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x0001F234 File Offset: 0x0001D434
		public string ContentString
		{
			get
			{
				object obj = this.Value;
				if (this.DataType == typeof(string) && string.IsNullOrEmpty((string)obj))
				{
					return this.EmptyString;
				}
				if (obj == null)
				{
					return this.NullString;
				}
				if (this.ConvertedValue != null)
				{
					obj = this.ConvertedValue;
				}
				if (!string.IsNullOrEmpty(this.FormatString))
				{
					return string.Format(this.FormatString, obj);
				}
				return obj.ToString();
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x0001F2AC File Offset: 0x0001D4AC
		// (set) Token: 0x0600074E RID: 1870 RVA: 0x0001F2B4 File Offset: 0x0001D4B4
		public object ConvertedValue
		{
			get
			{
				return this._convertedValue;
			}
			set
			{
				if (this._convertedValue != value)
				{
					this._convertedValue = value;
					this.OnPropertyChanged("ConvertedValue");
				}
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x0600074F RID: 1871 RVA: 0x0001F2D1 File Offset: 0x0001D4D1
		// (set) Token: 0x06000750 RID: 1872 RVA: 0x0001F2D9 File Offset: 0x0001D4D9
		public bool IsChecked
		{
			get
			{
				return this._isChecked;
			}
			set
			{
				if (this._isChecked != value)
				{
					this._isChecked = value;
					this.OnPropertyChanged("IsChecked");
				}
			}
		}

		// Token: 0x1700023F RID: 575
		// (get) Token: 0x06000751 RID: 1873 RVA: 0x0001F2F6 File Offset: 0x0001D4F6
		// (set) Token: 0x06000752 RID: 1874 RVA: 0x0001F2FE File Offset: 0x0001D4FE
		public global::Infragistics.Controls.Grids.Column Column { get; set; }

		// Token: 0x17000240 RID: 576
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x0001F307 File Offset: 0x0001D507
		// (set) Token: 0x06000754 RID: 1876 RVA: 0x0001F30F File Offset: 0x0001D50F
		internal string FormatString { get; set; }

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x0001F318 File Offset: 0x0001D518
		// (set) Token: 0x06000756 RID: 1878 RVA: 0x0001F320 File Offset: 0x0001D520
		internal global::System.Type DataType { get; set; }

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x0001F329 File Offset: 0x0001D529
		// (set) Token: 0x06000758 RID: 1880 RVA: 0x0001F331 File Offset: 0x0001D531
		internal string EmptyString { get; set; }

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x06000759 RID: 1881 RVA: 0x0001F33A File Offset: 0x0001D53A
		// (set) Token: 0x0600075A RID: 1882 RVA: 0x0001F342 File Offset: 0x0001D542
		internal string NullString { get; set; }

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x0600075B RID: 1883 RVA: 0x0001F34C File Offset: 0x0001D54C
		// (remove) Token: 0x0600075C RID: 1884 RVA: 0x0001F384 File Offset: 0x0001D584
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x0600075D RID: 1885 RVA: 0x0001F3BC File Offset: 0x0001D5BC
		protected virtual void OnPropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x040001D2 RID: 466
		private object _value;

		// Token: 0x040001D3 RID: 467
		private bool _isChecked;

		// Token: 0x040001D4 RID: 468
		private object _convertedValue;
	}
}
