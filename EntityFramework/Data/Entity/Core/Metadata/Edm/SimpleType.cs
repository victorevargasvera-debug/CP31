using System;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004FA RID: 1274
	public abstract class SimpleType : global::System.Data.Entity.Core.Metadata.Edm.EdmType
	{
		// Token: 0x06003F1C RID: 16156 RVA: 0x000D0E55 File Offset: 0x000CF055
		internal SimpleType()
		{
		}

		// Token: 0x06003F1D RID: 16157 RVA: 0x000D0E5D File Offset: 0x000CF05D
		internal SimpleType(string name, string namespaceName, global::System.Data.Entity.Core.Metadata.Edm.DataSpace dataSpace) : base(name, namespaceName, dataSpace)
		{
		}
	}
}
