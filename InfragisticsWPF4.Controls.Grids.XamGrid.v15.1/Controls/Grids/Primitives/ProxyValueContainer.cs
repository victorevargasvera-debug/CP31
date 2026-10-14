using System;
using System.ComponentModel;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000081 RID: 129
	public class ProxyValueContainer : global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x000150D9 File Offset: 0x000132D9
		// (set) Token: 0x06000479 RID: 1145 RVA: 0x000150E1 File Offset: 0x000132E1
		public object ProxyValue1
		{
			get
			{
				return this._proxyValue1;
			}
			set
			{
				if (this._proxyValue1 != value)
				{
					this._proxyValue1 = value;
					this.OnPropertyChanged("ProxyValue1");
				}
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x000150FE File Offset: 0x000132FE
		// (set) Token: 0x0600047B RID: 1147 RVA: 0x00015106 File Offset: 0x00013306
		public object ProxyValue2
		{
			get
			{
				return this._proxyValue2;
			}
			set
			{
				if (this._proxyValue2 != value)
				{
					this._proxyValue2 = value;
					this.OnPropertyChanged("ProxyValue2");
				}
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600047C RID: 1148 RVA: 0x00015124 File Offset: 0x00013324
		// (remove) Token: 0x0600047D RID: 1149 RVA: 0x0001515C File Offset: 0x0001335C
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x0600047E RID: 1150 RVA: 0x00015191 File Offset: 0x00013391
		protected virtual void OnPropertyChanged(string name)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(name));
			}
		}

		// Token: 0x04000130 RID: 304
		private object _proxyValue1;

		// Token: 0x04000131 RID: 305
		private object _proxyValue2;
	}
}
