using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x02000083 RID: 131
	public interface IViewsCollection : global::System.Collections.Generic.IEnumerable<object>, global::System.Collections.IEnumerable, global::System.Collections.Specialized.INotifyCollectionChanged
	{
		// Token: 0x06000384 RID: 900
		bool Contains(object value);
	}
}
