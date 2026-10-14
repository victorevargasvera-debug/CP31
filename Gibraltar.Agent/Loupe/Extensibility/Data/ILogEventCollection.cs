using System;
using System.Collections;
using System.Collections.Generic;

namespace Loupe.Extensibility.Data
{
	// Token: 0x02000089 RID: 137
	internal interface ILogEventCollection : global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.ILogEvent>, global::System.Collections.Generic.ICollection<global::Loupe.Extensibility.Data.ILogEvent>, global::System.Collections.Generic.IEnumerable<global::Loupe.Extensibility.Data.ILogEvent>, global::System.Collections.IEnumerable
	{
		// Token: 0x0600064F RID: 1615
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		void Clear();

		// Token: 0x06000650 RID: 1616
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		void Add(global::Loupe.Extensibility.Data.ILogEvent item);

		// Token: 0x06000651 RID: 1617
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		void Remove(global::Loupe.Extensibility.Data.ILogEvent item);

		// Token: 0x06000652 RID: 1618
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		void Insert(int index, global::Loupe.Extensibility.Data.ILogEvent item);

		// Token: 0x06000653 RID: 1619
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		void RemoveAt(int index);
	}
}
