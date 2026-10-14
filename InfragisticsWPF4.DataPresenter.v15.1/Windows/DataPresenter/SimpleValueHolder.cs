using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200020D RID: 525
	internal class SimpleValueHolder<T> : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x06001FB4 RID: 8116 RVA: 0x00089D48 File Offset: 0x00087F48
		public SimpleValueHolder(T initialValue)
		{
			this._value = initialValue;
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06001FB5 RID: 8117 RVA: 0x00089D57 File Offset: 0x00087F57
		// (set) Token: 0x06001FB6 RID: 8118 RVA: 0x00089D60 File Offset: 0x00087F60
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

		// Token: 0x1400006C RID: 108
		// (add) Token: 0x06001FB7 RID: 8119 RVA: 0x00089DA4 File Offset: 0x00087FA4
		// (remove) Token: 0x06001FB8 RID: 8120 RVA: 0x00089DDC File Offset: 0x00087FDC
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x04000D57 RID: 3415
		private T _value;
	}
}
