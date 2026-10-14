using System;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x0200048E RID: 1166
	internal sealed class ClrEnumType : global::System.Data.Entity.Core.Metadata.Edm.EnumType
	{
		// Token: 0x060039E5 RID: 14821 RVA: 0x000BDD44 File Offset: 0x000BBF44
		internal ClrEnumType(global::System.Type clrType, string cspaceNamespaceName, string cspaceTypeName) : base(clrType)
		{
			this._type = clrType;
			this._cspaceTypeName = cspaceNamespaceName + "." + cspaceTypeName;
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x060039E6 RID: 14822 RVA: 0x000BDD66 File Offset: 0x000BBF66
		internal override global::System.Type ClrType
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x060039E7 RID: 14823 RVA: 0x000BDD6E File Offset: 0x000BBF6E
		internal string CSpaceTypeName
		{
			get
			{
				return this._cspaceTypeName;
			}
		}

		// Token: 0x04001351 RID: 4945
		private readonly global::System.Type _type;

		// Token: 0x04001352 RID: 4946
		private readonly string _cspaceTypeName;
	}
}
