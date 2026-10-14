using System;
using System.Collections;

namespace Infragistics
{
	// Token: 0x02000040 RID: 64
	public interface IFastItemsSourceProvider
	{
		// Token: 0x060003A9 RID: 937
		global::Infragistics.IFastItemsSource GetFastItemsSource(global::System.Collections.IEnumerable target);

		// Token: 0x060003AA RID: 938
		global::Infragistics.IFastItemsSource ReleaseFastItemsSource(global::System.Collections.IEnumerable itemsSource);
	}
}
