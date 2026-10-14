using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Utilities;
using System.Globalization;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x02000550 RID: 1360
	public sealed class ModificationFunctionParameterBinding : global::System.Data.Entity.Core.Mapping.MappingItem
	{
		// Token: 0x060042DE RID: 17118 RVA: 0x000E52E2 File Offset: 0x000E34E2
		public ModificationFunctionParameterBinding(global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter parameter, global::System.Data.Entity.Core.Mapping.ModificationFunctionMemberPath memberPath, bool isCurrent)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter>(parameter, "parameter");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Mapping.ModificationFunctionMemberPath>(memberPath, "memberPath");
			this._parameter = parameter;
			this._memberPath = memberPath;
			this._isCurrent = isCurrent;
		}

		// Token: 0x17000D3D RID: 3389
		// (get) Token: 0x060042DF RID: 17119 RVA: 0x000E5317 File Offset: 0x000E3517
		public global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter Parameter
		{
			get
			{
				return this._parameter;
			}
		}

		// Token: 0x17000D3E RID: 3390
		// (get) Token: 0x060042E0 RID: 17120 RVA: 0x000E531F File Offset: 0x000E351F
		public global::System.Data.Entity.Core.Mapping.ModificationFunctionMemberPath MemberPath
		{
			get
			{
				return this._memberPath;
			}
		}

		// Token: 0x17000D3F RID: 3391
		// (get) Token: 0x060042E1 RID: 17121 RVA: 0x000E5327 File Offset: 0x000E3527
		public bool IsCurrent
		{
			get
			{
				return this._isCurrent;
			}
		}

		// Token: 0x060042E2 RID: 17122 RVA: 0x000E532F File Offset: 0x000E352F
		public override string ToString()
		{
			return string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "@{0}->{1}{2}", new object[]
			{
				this.Parameter,
				this.IsCurrent ? "+" : "-",
				this.MemberPath
			});
		}

		// Token: 0x060042E3 RID: 17123 RVA: 0x000E536F File Offset: 0x000E356F
		internal override void SetReadOnly()
		{
			global::System.Data.Entity.Core.Mapping.MappingItem.SetReadOnly(this._memberPath);
			base.SetReadOnly();
		}

		// Token: 0x04001789 RID: 6025
		private readonly global::System.Data.Entity.Core.Metadata.Edm.FunctionParameter _parameter;

		// Token: 0x0400178A RID: 6026
		private readonly global::System.Data.Entity.Core.Mapping.ModificationFunctionMemberPath _memberPath;

		// Token: 0x0400178B RID: 6027
		private readonly bool _isCurrent;
	}
}
