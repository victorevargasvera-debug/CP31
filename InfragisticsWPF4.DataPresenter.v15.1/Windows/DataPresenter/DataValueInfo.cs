using System;
using System.Collections.Generic;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000A1 RID: 161
	public class DataValueInfo : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x060007F0 RID: 2032 RVA: 0x000223C9 File Offset: 0x000205C9
		private DataValueInfo(object value, global::System.DateTime timeStamp, object tag)
		{
			this._value = value;
			this._timeStamp = timeStamp;
			this._tag = tag;
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060007F1 RID: 2033 RVA: 0x000223E6 File Offset: 0x000205E6
		// (set) Token: 0x060007F2 RID: 2034 RVA: 0x000223EE File Offset: 0x000205EE
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

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x00022402 File Offset: 0x00020602
		public global::System.DateTime TimeStamp
		{
			get
			{
				return this._timeStamp;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060007F4 RID: 2036 RVA: 0x0002240A File Offset: 0x0002060A
		public object Value
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x00022412 File Offset: 0x00020612
		private static global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataValueInfo> InfoCache
		{
			get
			{
				if (global::Infragistics.Windows.DataPresenter.DataValueInfo._InfoCache == null)
				{
					global::Infragistics.Windows.DataPresenter.DataValueInfo._InfoCache = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataValueInfo>(100);
				}
				return global::Infragistics.Windows.DataPresenter.DataValueInfo._InfoCache;
			}
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x0002242C File Offset: 0x0002062C
		internal static global::Infragistics.Windows.DataPresenter.DataValueInfo Create(object value, global::System.DateTime timeStamp, object tag)
		{
			int num = global::Infragistics.Windows.DataPresenter.DataValueInfo.InfoCache.Count - 1;
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

		// Token: 0x060007F7 RID: 2039 RVA: 0x00022482 File Offset: 0x00020682
		internal static void Release(global::Infragistics.Windows.DataPresenter.DataValueInfo info)
		{
			if (info == null || global::Infragistics.Windows.DataPresenter.DataValueInfo.InfoCache.Count > 300)
			{
				return;
			}
			info._value = null;
			info._tag = null;
			global::Infragistics.Windows.DataPresenter.DataValueInfo._InfoCache.Add(info);
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x000224B2 File Offset: 0x000206B2
		internal void SetTimeStamp(global::System.DateTime newTimeStamp)
		{
			this._timeStamp = newTimeStamp;
			base.RaisePropertyChangedEvent("TimeStamp");
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x000224C6 File Offset: 0x000206C6
		internal void SetValue(object newValue)
		{
			this._value = newValue;
			base.RaisePropertyChangedEvent("Value");
		}

		// Token: 0x0400034B RID: 843
		private object _value;

		// Token: 0x0400034C RID: 844
		private global::System.DateTime _timeStamp;

		// Token: 0x0400034D RID: 845
		private object _tag;

		// Token: 0x0400034E RID: 846
		[global::System.ThreadStatic]
		private static global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataValueInfo> _InfoCache;
	}
}
