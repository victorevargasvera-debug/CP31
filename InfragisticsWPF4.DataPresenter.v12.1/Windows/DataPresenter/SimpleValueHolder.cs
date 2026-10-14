using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001E3 RID: 483
	internal class SimpleValueHolder<T> : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x06001B9A RID: 7066 RVA: 0x00075D54 File Offset: 0x00073F54
		public SimpleValueHolder(T initialValue)
		{
			this._value = initialValue;
		}

		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x06001B9B RID: 7067 RVA: 0x00075D63 File Offset: 0x00073F63
		// (set) Token: 0x06001B9C RID: 7068 RVA: 0x00075D6C File Offset: 0x00073F6C
		public T Value
		{
			get
			{
				return this._value;
			}
			set
			{
				if (global::System.Collections.Generic.EqualityComparer<T>.Default.Equals(this._value, value))
				{
					return;
				}
				this._value = value;
				global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
				if (propertyChanged != null)
				{
					propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs("Value"));
				}
			}
		}

		// Token: 0x1400006B RID: 107
		// (add) Token: 0x06001B9D RID: 7069 RVA: 0x00075DB0 File Offset: 0x00073FB0
		// (remove) Token: 0x06001B9E RID: 7070 RVA: 0x00075DE8 File Offset: 0x00073FE8
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x04000B65 RID: 2917
		private T _value;
	}
}
