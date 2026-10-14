using System;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003A1 RID: 929
	internal abstract class EntityIdentity
	{
		// Token: 0x06002D37 RID: 11575 RVA: 0x00090B67 File Offset: 0x0008ED67
		internal EntityIdentity(global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] keyColumns)
		{
			this.m_keys = keyColumns;
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x06002D38 RID: 11576 RVA: 0x00090B76 File Offset: 0x0008ED76
		internal global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] Keys
		{
			get
			{
				return this.m_keys;
			}
		}

		// Token: 0x04000F22 RID: 3874
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] m_keys;
	}
}
