using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000082 RID: 130
	public class CellValueHolder
	{
		// Token: 0x06000695 RID: 1685 RVA: 0x0001A666 File Offset: 0x00018866
		internal CellValueHolder(global::Infragistics.Windows.DataPresenter.CellValueHolder source)
		{
			this._value = source._value;
			this._isDisplayText = source._isDisplayText;
			this._ignore = source._ignore;
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x0001A692 File Offset: 0x00018892
		public CellValueHolder(object value, bool isDisplayText)
		{
			this._value = value;
			this._isDisplayText = isDisplayText;
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000697 RID: 1687 RVA: 0x0001A6A8 File Offset: 0x000188A8
		// (set) Token: 0x06000698 RID: 1688 RVA: 0x0001A6B0 File Offset: 0x000188B0
		public bool IsDisplayText
		{
			get
			{
				return this._isDisplayText;
			}
			set
			{
				this._isDisplayText = value;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000699 RID: 1689 RVA: 0x0001A6B9 File Offset: 0x000188B9
		// (set) Token: 0x0600069A RID: 1690 RVA: 0x0001A6C1 File Offset: 0x000188C1
		public object Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x0600069B RID: 1691 RVA: 0x0001A6CA File Offset: 0x000188CA
		// (set) Token: 0x0600069C RID: 1692 RVA: 0x0001A6D2 File Offset: 0x000188D2
		internal bool Ignore
		{
			get
			{
				return this._ignore;
			}
			set
			{
				this._ignore = value;
			}
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x0001A6DB File Offset: 0x000188DB
		internal virtual global::Infragistics.Windows.DataPresenter.CellValueHolder Clone()
		{
			return new global::Infragistics.Windows.DataPresenter.CellValueHolder(this);
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0001A6E3 File Offset: 0x000188E3
		internal void Initialize(object value, bool isDisplayText)
		{
			this._value = value;
			this._isDisplayText = isDisplayText;
		}

		// Token: 0x04000213 RID: 531
		private object _value;

		// Token: 0x04000214 RID: 532
		private bool _isDisplayText;

		// Token: 0x04000215 RID: 533
		private bool _ignore;
	}
}
