using System;
using System.Collections;
using System.Windows.Threading;

namespace Infragistics
{
	// Token: 0x0200003C RID: 60
	public interface IFastItemsSource
	{
		// Token: 0x170000DB RID: 219
		object this[int i]
		{
			get;
		}

		// Token: 0x0600037D RID: 893
		int IndexOf(object item);

		// Token: 0x0600037E RID: 894
		global::Infragistics.IFastItemColumn<double> RegisterColumn(string propertyName);

		// Token: 0x0600037F RID: 895
		void DeregisterColumn(global::Infragistics.IFastItemColumnPropertyName fastItemColumn);

		// Token: 0x06000380 RID: 896
		global::Infragistics.IFastItemColumn<int> RegisterColumnInt(string propertyName);

		// Token: 0x06000381 RID: 897
		global::Infragistics.IFastItemColumn<object> RegisterColumnObject(string propertyName);

		// Token: 0x06000382 RID: 898
		global::Infragistics.IFastItemColumn<global::System.DateTime> RegisterColumnDateTime(string propertyName);

		// Token: 0x14000007 RID: 7
		// (add) Token: 0x06000383 RID: 899
		// (remove) Token: 0x06000384 RID: 900
		event global::System.EventHandler<global::Infragistics.FastItemsSourceEventArgs> Event;

		// Token: 0x06000385 RID: 901
		global::System.Collections.IList ContentsAsIList();

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000386 RID: 902
		int Count { get; }

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000387 RID: 903
		// (set) Token: 0x06000388 RID: 904
		global::System.Windows.Threading.Dispatcher Dispatcher { get; set; }
	}
}
