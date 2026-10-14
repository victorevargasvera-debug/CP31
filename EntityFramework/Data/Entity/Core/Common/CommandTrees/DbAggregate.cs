using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees.Internal;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006A4 RID: 1700
	public abstract class DbAggregate
	{
		// Token: 0x06005005 RID: 20485 RVA: 0x00120DB4 File Offset: 0x0011EFB4
		internal DbAggregate(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType, global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList arguments)
		{
			this._type = resultType;
			this._args = arguments;
		}

		// Token: 0x17000F94 RID: 3988
		// (get) Token: 0x06005006 RID: 20486 RVA: 0x00120DCA File Offset: 0x0011EFCA
		public global::System.Data.Entity.Core.Metadata.Edm.TypeUsage ResultType
		{
			get
			{
				return this._type;
			}
		}

		// Token: 0x17000F95 RID: 3989
		// (get) Token: 0x06005007 RID: 20487 RVA: 0x00120DD2 File Offset: 0x0011EFD2
		public global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> Arguments
		{
			get
			{
				return this._args;
			}
		}

		// Token: 0x04001D3D RID: 7485
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList _args;

		// Token: 0x04001D3E RID: 7486
		private readonly global::System.Data.Entity.Core.Metadata.Edm.TypeUsage _type;
	}
}
