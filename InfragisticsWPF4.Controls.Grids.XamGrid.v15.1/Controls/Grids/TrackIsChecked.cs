using System;
using System.ComponentModel;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000ED RID: 237
	public abstract class TrackIsChecked : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x1700026C RID: 620
		// (get) Token: 0x060007D0 RID: 2000 RVA: 0x000200E9 File Offset: 0x0001E2E9
		// (set) Token: 0x060007D1 RID: 2001 RVA: 0x000200F4 File Offset: 0x0001E2F4
		public bool? IsChecked
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
					if (this.Parent != null)
					{
						this.Parent.InvalidateIsChecked();
					}
					this.InvalidateChildren(value);
					this.OnPropertyChanged("IsChecked");
				}
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x060007D2 RID: 2002 RVA: 0x0002015E File Offset: 0x0001E35E
		// (set) Token: 0x060007D3 RID: 2003 RVA: 0x00020166 File Offset: 0x0001E366
		public global::Infragistics.Controls.Grids.TrackIsChecked Parent { get; set; }

		// Token: 0x060007D4 RID: 2004 RVA: 0x0002016F File Offset: 0x0001E36F
		protected internal virtual void ChangeSilent(bool? newValue)
		{
			this._isChecked = newValue;
			this.OnPropertyChanged("IsChecked");
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x00020183 File Offset: 0x0001E383
		protected internal virtual void InvalidateIsChecked()
		{
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x00020185 File Offset: 0x0001E385
		protected internal virtual void InvalidateChildren(bool? newValue)
		{
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00020187 File Offset: 0x0001E387
		protected virtual void OnPropertyChanged(string name)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
			}
		}

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x060007D8 RID: 2008 RVA: 0x000201A4 File Offset: 0x0001E3A4
		// (remove) Token: 0x060007D9 RID: 2009 RVA: 0x000201DC File Offset: 0x0001E3DC
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x040001ED RID: 493
		private bool? _isChecked;
	}
}
