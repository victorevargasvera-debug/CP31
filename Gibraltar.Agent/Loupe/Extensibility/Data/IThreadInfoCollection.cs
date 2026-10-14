using System;
using System.Collections;
using System.Collections.Generic;

namespace Loupe.Extensibility.Data
{
	// Token: 0x0200007B RID: 123
	internal interface IThreadInfoCollection : global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.IThreadInfo>, global::System.Collections.Generic.ICollection<global::Loupe.Extensibility.Data.IThreadInfo>, global::System.Collections.Generic.IEnumerable<global::Loupe.Extensibility.Data.IThreadInfo>, global::System.Collections.IEnumerable
	{
		// Token: 0x060005F6 RID: 1526
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		void Clear();

		// Token: 0x060005F7 RID: 1527
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		void Add(global::Loupe.Extensibility.Data.IThreadInfo item);

		// Token: 0x060005F8 RID: 1528
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		void Remove(global::Loupe.Extensibility.Data.IThreadInfo item);

		// Token: 0x060005F9 RID: 1529
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		void Insert(int index, global::Loupe.Extensibility.Data.IThreadInfo item);

		// Token: 0x060005FA RID: 1530
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		void RemoveAt(int index);
	}
}
