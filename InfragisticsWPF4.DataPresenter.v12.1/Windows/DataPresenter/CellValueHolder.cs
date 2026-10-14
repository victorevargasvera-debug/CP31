using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200007D RID: 125
	public class CellValueHolder
	{
		// Token: 0x0600061A RID: 1562 RVA: 0x000180E6 File Offset: 0x000162E6
		internal CellValueHolder(global::Infragistics.Windows.DataPresenter.CellValueHolder source)
		{
			this._value = source._value;
			this._isDisplayText = source._isDisplayText;
			this._ignore = source._ignore;
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x00018112 File Offset: 0x00016312
		public CellValueHolder(object value, bool isDisplayText)
		{
			this._value = value;
			this._isDisplayText = isDisplayText;
		}

		// Token: 0x170001AD RID: 429
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x00018128 File Offset: 0x00016328
		// (set) Token: 0x0600061D RID: 1565 RVA: 0x00018130 File Offset: 0x00016330
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

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x00018139 File Offset: 0x00016339
		// (set) Token: 0x0600061F RID: 1567 RVA: 0x00018141 File Offset: 0x00016341
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

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x0001814A File Offset: 0x0001634A
		// (set) Token: 0x06000621 RID: 1569 RVA: 0x00018152 File Offset: 0x00016352
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

		// Token: 0x06000622 RID: 1570 RVA: 0x0001815B File Offset: 0x0001635B
		internal virtual global::Infragistics.Windows.DataPresenter.CellValueHolder Clone()
		{
			return new global::Infragistics.Windows.DataPresenter.CellValueHolder(this);
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00018163 File Offset: 0x00016363
		internal void Initialize(object value, bool isDisplayText)
		{
			this._value = value;
			this._isDisplayText = isDisplayText;
		}

		// Token: 0x040001D7 RID: 471
		private object _value;

		// Token: 0x040001D8 RID: 472
		private bool _isDisplayText;

		// Token: 0x040001D9 RID: 473
		private bool _ignore;
	}
}
