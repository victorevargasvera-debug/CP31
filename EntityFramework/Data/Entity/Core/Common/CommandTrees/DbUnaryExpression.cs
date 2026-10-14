using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006E4 RID: 1764
	public abstract class DbUnaryExpression : global::System.Data.Entity.Core.Common.CommandTrees.DbExpression
	{
		// Token: 0x060051B8 RID: 20920 RVA: 0x00123596 File Offset: 0x00121796
		internal DbUnaryExpression()
		{
		}

		// Token: 0x060051B9 RID: 20921 RVA: 0x0012359E File Offset: 0x0012179E
		internal DbUnaryExpression(global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind kind, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression argument) : base(kind, resultType, true)
		{
			this._argument = argument;
		}

		// Token: 0x17000FFA RID: 4090
		// (get) Token: 0x060051BA RID: 20922 RVA: 0x001235B0 File Offset: 0x001217B0
		public virtual global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Argument
		{
			get
			{
				return this._argument;
			}
		}

		// Token: 0x04001DDB RID: 7643
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _argument;
	}
}
