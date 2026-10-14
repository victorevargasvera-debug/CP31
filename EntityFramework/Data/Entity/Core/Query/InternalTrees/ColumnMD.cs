using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x0200038C RID: 908
	internal class ColumnMD
	{
		// Token: 0x06002C16 RID: 11286 RVA: 0x0008E0D7 File Offset: 0x0008C2D7
		internal ColumnMD(string name, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			this.m_name = name;
			this.m_type = type;
		}

		// Token: 0x06002C17 RID: 11287 RVA: 0x0008E0ED File Offset: 0x0008C2ED
		internal ColumnMD(global::System.Data.Entity.Core.Metadata.Edm.EdmMember property) : this(property.Name, property.TypeUsage)
		{
			this.m_property = property;
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06002C18 RID: 11288 RVA: 0x0008E108 File Offset: 0x0008C308
		internal string Name
		{
			get
			{
				return this.m_name;
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06002C19 RID: 11289 RVA: 0x0008E110 File Offset: 0x0008C310
		internal global::System.Data.Entity.Core.Metadata.Edm.TypeUsage Type
		{
			get
			{
				return this.m_type;
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06002C1A RID: 11290 RVA: 0x0008E118 File Offset: 0x0008C318
		internal bool IsNullable
		{
			get
			{
				return this.m_property == null || global::System.Data.Entity.Core.Metadata.Edm.TypeSemantics.IsNullable(this.m_property);
			}
		}

		// Token: 0x06002C1B RID: 11291 RVA: 0x0008E12F File Offset: 0x0008C32F
		public override string ToString()
		{
			return this.m_name;
		}

		// Token: 0x04000EED RID: 3821
		private readonly string m_name;

		// Token: 0x04000EEE RID: 3822
		private readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage m_type;

		// Token: 0x04000EEF RID: 3823
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmMember m_property;
	}
}
