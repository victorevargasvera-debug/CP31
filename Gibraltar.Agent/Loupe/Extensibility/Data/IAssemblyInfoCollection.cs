using System;
using System.Collections;
using System.Collections.Generic;

namespace Loupe.Extensibility.Data
{
	// Token: 0x02000061 RID: 97
	internal interface IAssemblyInfoCollection : global::System.Collections.Generic.IList<global::Loupe.Extensibility.Data.IAssemblyInfo>, global::System.Collections.Generic.ICollection<global::Loupe.Extensibility.Data.IAssemblyInfo>, global::System.Collections.Generic.IEnumerable<global::Loupe.Extensibility.Data.IAssemblyInfo>, global::System.Collections.IEnumerable
	{
		// Token: 0x060004FA RID: 1274
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		void Clear();

		// Token: 0x060004FB RID: 1275
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		void Add(global::Loupe.Extensibility.Data.IAssemblyInfo item);

		// Token: 0x060004FC RID: 1276
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		void Remove(global::Loupe.Extensibility.Data.IAssemblyInfo item);

		// Token: 0x060004FD RID: 1277
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		void Insert(int index, global::Loupe.Extensibility.Data.IAssemblyInfo item);

		// Token: 0x060004FE RID: 1278
		[global::System.Obsolete("Not a valid operation.  This is a read-only collection.", true)]
		void RemoveAt(int index);
	}
}
