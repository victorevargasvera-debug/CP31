using System;
using System.Data.Entity.Utilities;
using System.Threading;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x02000493 RID: 1171
	internal sealed class ClrComplexType : global::System.Data.Entity.Core.Metadata.Edm.ComplexType
	{
		// Token: 0x060039FD RID: 14845 RVA: 0x000BE068 File Offset: 0x000BC268
		internal ClrComplexType(global::System.Type clrType, string cspaceNamespaceName, string cspaceTypeName) : base(global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(clrType, "clrType").Name, clrType.NestingNamespace() ?? string.Empty, global::System.Data.Entity.Core.Metadata.Edm.DataSpace.OSpace)
		{
			this._type = clrType;
			this._cspaceTypeName = cspaceNamespaceName + "." + cspaceTypeName;
			base.Abstract = clrType.IsAbstract();
		}

		// Token: 0x060039FE RID: 14846 RVA: 0x000BE0C0 File Offset: 0x000BC2C0
		internal static global::System.Data.Entity.Core.Metadata.Edm.ClrComplexType CreateReadonlyClrComplexType(global::System.Type clrType, string cspaceNamespaceName, string cspaceTypeName)
		{
			global::System.Data.Entity.Core.Metadata.Edm.ClrComplexType clrComplexType = new global::System.Data.Entity.Core.Metadata.Edm.ClrComplexType(clrType, cspaceNamespaceName, cspaceTypeName);
			clrComplexType.SetReadOnly();
			return clrComplexType;
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x060039FF RID: 14847 RVA: 0x000BE0D0 File Offset: 0x000BC2D0
		// (set) Token: 0x06003A00 RID: 14848 RVA: 0x000BE0D8 File Offset: 0x000BC2D8
		internal global::System.Func<object> Constructor
		{
			get
			{
				return this._constructor;
			}
			set
			{
				global::System.Threading.Interlocked.CompareExchange<global::System.Func<object>>(ref this._constructor, value, null);
			}
		}

		// Token: 0x17000B18 RID: 2840
		// (get) Token: 0x06003A01 RID: 14849 RVA: 0x000BE0E8 File Offset: 0x000BC2E8
		internal override global::System.Type ClrType
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x17000B19 RID: 2841
		// (get) Token: 0x06003A02 RID: 14850 RVA: 0x000BE0F0 File Offset: 0x000BC2F0
		internal string CSpaceTypeName
		{
			get
			{
				return this._cspaceTypeName;
			}
		}

		// Token: 0x04001359 RID: 4953
		private readonly global::System.Type _type;

		// Token: 0x0400135A RID: 4954
		private global::System.Func<object> _constructor;

		// Token: 0x0400135B RID: 4955
		private readonly string _cspaceTypeName;
	}
}
