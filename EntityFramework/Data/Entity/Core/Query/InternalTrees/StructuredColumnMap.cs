using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Globalization;
using System.Text;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003F0 RID: 1008
	internal abstract class StructuredColumnMap : global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap
	{
		// Token: 0x06002F3A RID: 12090 RVA: 0x000948C8 File Offset: 0x00092AC8
		internal StructuredColumnMap(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type, string name, global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap[] properties) : base(type, name)
		{
			this.m_properties = properties;
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x06002F3B RID: 12091 RVA: 0x000948D9 File Offset: 0x00092AD9
		internal virtual global::System.Data.Entity.Core.Query.InternalTrees.SimpleColumnMap NullSentinel
		{
			get
			{
				return null;
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x06002F3C RID: 12092 RVA: 0x000948DC File Offset: 0x00092ADC
		internal global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap[] Properties
		{
			get
			{
				return this.m_properties;
			}
		}

		// Token: 0x06002F3D RID: 12093 RVA: 0x000948E4 File Offset: 0x00092AE4
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			string text = string.Empty;
			stringBuilder.Append("{");
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap columnMap in this.Properties)
			{
				stringBuilder.AppendFormat(global::System.Globalization.CultureInfo.InvariantCulture, "{0}{1}", new object[]
				{
					text,
					columnMap
				});
				text = ",";
			}
			stringBuilder.Append("}");
			return stringBuilder.ToString();
		}

		// Token: 0x04000FEA RID: 4074
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap[] m_properties;
	}
}
