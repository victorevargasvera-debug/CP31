using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Globalization;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003F8 RID: 1016
	internal abstract class Var
	{
		// Token: 0x06002F67 RID: 12135 RVA: 0x00094DAF File Offset: 0x00092FAF
		internal Var(int id, global::System.Data.Entity.Core.Query.InternalTrees.VarType varType, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage type)
		{
			this._id = id;
			this._varType = varType;
			this._type = type;
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x06002F68 RID: 12136 RVA: 0x00094DCC File Offset: 0x00092FCC
		internal int Id
		{
			get
			{
				return this._id;
			}
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x06002F69 RID: 12137 RVA: 0x00094DD4 File Offset: 0x00092FD4
		internal global::System.Data.Entity.Core.Query.InternalTrees.VarType VarType
		{
			get
			{
				return this._varType;
			}
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x06002F6A RID: 12138 RVA: 0x00094DDC File Offset: 0x00092FDC
		internal global::System.Data.Entity.Core.Metadata.Edm.TypeUsage Type
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x06002F6B RID: 12139 RVA: 0x00094DE4 File Offset: 0x00092FE4
		internal virtual bool TryGetName(out string name)
		{
			name = null;
			return false;
		}

		// Token: 0x06002F6C RID: 12140 RVA: 0x00094DEA File Offset: 0x00092FEA
		public override string ToString()
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}", new object[]
			{
				this.Id
			});
		}

		// Token: 0x04001000 RID: 4096
		private readonly int _id;

		// Token: 0x04001001 RID: 4097
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.VarType _varType;

		// Token: 0x04001002 RID: 4098
		private readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage _type;
	}
}
