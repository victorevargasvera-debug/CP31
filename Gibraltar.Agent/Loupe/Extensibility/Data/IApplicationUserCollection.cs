using System;
using System.Collections;
using System.Collections.Generic;

namespace Loupe.Extensibility.Data
{
	// Token: 0x02000080 RID: 128
	internal interface IApplicationUserCollection : global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.IApplicationUser>, global::System.Collections.Generic.ICollection<global::Loupe.Extensibility.Data.IApplicationUser>, global::System.Collections.Generic.IEnumerable<global::Loupe.Extensibility.Data.IApplicationUser>, global::System.Collections.IEnumerable
	{
		// Token: 0x060005FB RID: 1531
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		void Clear();

		// Token: 0x060005FC RID: 1532
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		void Add(global::Loupe.Extensibility.Data.IApplicationUser item);

		// Token: 0x060005FD RID: 1533
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		void Remove(global::Loupe.Extensibility.Data.IApplicationUser item);

		// Token: 0x060005FE RID: 1534
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		void Insert(int index, global::Loupe.Extensibility.Data.IApplicationUser item);

		// Token: 0x060005FF RID: 1535
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		void RemoveAt(int index);
	}
}
