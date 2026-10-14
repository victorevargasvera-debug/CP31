using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Globalization;
using System.Text;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x0200039B RID: 923
	internal class DiscriminatedEntityIdentity : global::System.Data.Entity.Core.Query.InternalTrees.EntityIdentity
	{
		// Token: 0x06002CEE RID: 11502 RVA: 0x0008F3F4 File Offset: 0x0008D5F4
		internal DiscriminatedEntityIdentity(global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap entitySetColumn, global::System.Data.Entity.Core.Metadata.Edm.EntitySet[] entitySetMap, global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] keyColumns) : base(keyColumns)
		{
			this.m_entitySetColumn = entitySetColumn;
			this.m_entitySetMap = entitySetMap;
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x06002CEF RID: 11503 RVA: 0x0008F40B File Offset: 0x0008D60B
		internal global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap EntitySetColumnMap
		{
			get
			{
				return this.m_entitySetColumn;
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x06002CF0 RID: 11504 RVA: 0x0008F413 File Offset: 0x0008D613
		internal global::System.Data.Entity.Core.Metadata.Edm.EntitySet[] EntitySetMap
		{
			get
			{
				return this.m_entitySetMap;
			}
		}

		// Token: 0x06002CF1 RID: 11505 RVA: 0x0008F41C File Offset: 0x0008D61C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			string text = string.Empty;
			stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, "[(Keys={", new object[0]);
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap simpleColumnMap in base.Keys)
			{
				stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, "{0}{1}", new object[]
				{
					text,
					simpleColumnMap
				});
				text = ",";
			}
			stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, "})]", new object[0]);
			return stringBuilder.ToString();
		}

		// Token: 0x04000F18 RID: 3864
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap m_entitySetColumn;

		// Token: 0x04000F19 RID: 3865
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntitySet[] m_entitySetMap;
	}
}
