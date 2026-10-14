using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200009B RID: 155
	public class DataValueInfo : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x06000768 RID: 1896 RVA: 0x0001F3F0 File Offset: 0x0001D5F0
		private DataValueInfo(object value, global::System.DateTime timeStamp, object tag)
		{
			this._value = value;
			this._timeStamp = timeStamp;
			this._tag = tag;
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x0001F40D File Offset: 0x0001D60D
		// (set) Token: 0x0600076A RID: 1898 RVA: 0x0001F415 File Offset: 0x0001D615
		public object Tag
		{
			get
			{
				return this._tag;
			}
			set
			{
				this._tag = value;
				base.RaisePropertyChangedEvent("Tag");
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x0600076B RID: 1899 RVA: 0x0001F429 File Offset: 0x0001D629
		public global::System.DateTime TimeStamp
		{
			get
			{
				return this._timeStamp;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x0600076C RID: 1900 RVA: 0x0001F431 File Offset: 0x0001D631
		public object Value
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x0001F43C File Offset: 0x0001D63C
		internal static global::Infragistics.Windows.DataPresenter.DataValueInfo Create(object value, global::System.DateTime timeStamp, object tag)
		{
			int num = global::Infragistics.Windows.DataPresenter.DataValueInfo._InfoCache.Count - 1;
			global::Infragistics.Windows.DataPresenter.DataValueInfo dataValueInfo;
			if (num >= 0)
			{
				dataValueInfo = global::Infragistics.Windows.DataPresenter.DataValueInfo._InfoCache[num];
				global::Infragistics.Windows.DataPresenter.DataValueInfo._InfoCache.RemoveAt(num);
				dataValueInfo._tag = tag;
				dataValueInfo._timeStamp = timeStamp;
				dataValueInfo._value = value;
			}
			else
			{
				dataValueInfo = new global::Infragistics.Windows.DataPresenter.DataValueInfo(value, timeStamp, tag);
			}
			return dataValueInfo;
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x0001F492 File Offset: 0x0001D692
		internal static void Release(global::Infragistics.Windows.DataPresenter.DataValueInfo info)
		{
			if (info == null || global::Infragistics.Windows.DataPresenter.DataValueInfo._InfoCache.Count > 300)
			{
				return;
			}
			info._value = null;
			info._tag = null;
			global::Infragistics.Windows.DataPresenter.DataValueInfo._InfoCache.Add(info);
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0001F4C2 File Offset: 0x0001D6C2
		internal void SetTimeStamp(global::System.DateTime newTimeStamp)
		{
			this._timeStamp = newTimeStamp;
			base.RaisePropertyChangedEvent("TimeStamp");
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x0001F4D6 File Offset: 0x0001D6D6
		internal void SetValue(object newValue)
		{
			this._value = newValue;
			base.RaisePropertyChangedEvent("Value");
		}

		// Token: 0x04000305 RID: 773
		private object _value;

		// Token: 0x04000306 RID: 774
		private global::System.DateTime _timeStamp;

		// Token: 0x04000307 RID: 775
		private object _tag;

		// Token: 0x04000308 RID: 776
		[global::System.ThreadStatic]
		private static global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataValueInfo> _InfoCache = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataValueInfo>(100);
	}
}
