using System;
using System.Collections;
using System.Collections.Generic;

namespace Loupe.Extensibility.Data
{
	// Token: 0x0200006A RID: 106
	internal interface ILogMessageCollection : global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.ILogMessage>, global::System.Collections.Generic.ICollection<global::Loupe.Extensibility.Data.ILogMessage>, global::System.Collections.Generic.IEnumerable<global::Loupe.Extensibility.Data.ILogMessage>, global::System.Collections.IEnumerable
	{
		// Token: 0x06000534 RID: 1332
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		void Clear();

		// Token: 0x06000535 RID: 1333
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		void Add(global::Loupe.Extensibility.Data.ILogMessage item);

		// Token: 0x06000536 RID: 1334
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		void Remove(global::Loupe.Extensibility.Data.ILogMessage item);

		// Token: 0x06000537 RID: 1335
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		void Insert(int index, global::Loupe.Extensibility.Data.ILogMessage item);

		// Token: 0x06000538 RID: 1336
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		void RemoveAt(int index);

		// Token: 0x17000225 RID: 549
		global::Loupe.Extensibility.Data.ILogMessage this[global::System.Guid key]
		{
			get;
		}
	}
}
