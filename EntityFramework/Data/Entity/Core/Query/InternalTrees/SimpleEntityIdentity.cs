using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Globalization;
using System.Text;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003E6 RID: 998
	internal class SimpleEntityIdentity : global::System.Data.Entity.Core.Query.InternalTrees.EntityIdentity
	{
		// Token: 0x06002F0A RID: 12042 RVA: 0x00094561 File Offset: 0x00092761
		internal SimpleEntityIdentity(global::System.Data.Entity.Core.Metadata.Edm.EntitySet entitySet, global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap[] keyColumns) : base(keyColumns)
		{
			this.m_entitySet = entitySet;
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x06002F0B RID: 12043 RVA: 0x00094571 File Offset: 0x00092771
		internal global::System.Data.Entity.Core.Metadata.Edm.EntitySet EntitySet
		{
			get
			{
				return this.m_entitySet;
			}
		}

		// Token: 0x06002F0C RID: 12044 RVA: 0x0009457C File Offset: 0x0009277C
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			string text = string.Empty;
			stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, "[(ES={0}) (Keys={", new object[]
			{
				this.EntitySet.Name
			});
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

		// Token: 0x04000FDA RID: 4058
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EntitySet m_entitySet;
	}
}
