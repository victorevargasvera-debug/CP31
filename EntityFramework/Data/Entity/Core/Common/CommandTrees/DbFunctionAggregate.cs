using System;
using System.Data.Entity.Core.Common.CommandTrees.Internal;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006BD RID: 1725
	public sealed class DbFunctionAggregate : global::System.Data.Entity.Core.Common.CommandTrees.DbAggregate
	{
		// Token: 0x060050E3 RID: 20707 RVA: 0x00121795 File Offset: 0x0011F995
		internal DbFunctionAggregate(global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType, global::System.Data.Entity.Core.Common.CommandTrees.Internal.DbExpressionList arguments, global::System.Data.Entity.Core.Metadata.Edm.EdmFunction function, bool isDistinct) : base(resultType, arguments)
		{
			this._aggregateFunction = function;
			this._distinct = isDistinct;
		}

		// Token: 0x17000FB2 RID: 4018
		// (get) Token: 0x060050E4 RID: 20708 RVA: 0x001217AE File Offset: 0x0011F9AE
		public bool Distinct
		{
			get
			{
				return this._distinct;
			}
		}

		// Token: 0x17000FB3 RID: 4019
		// (get) Token: 0x060050E5 RID: 20709 RVA: 0x001217B6 File Offset: 0x0011F9B6
		public global::System.Data.Entity.Core.Metadata.Edm.EdmFunction Function
		{
			get
			{
				return this._aggregateFunction;
			}
		}

		// Token: 0x04001D99 RID: 7577
		private readonly bool _distinct;

		// Token: 0x04001D9A RID: 7578
		private readonly global::System.Data.Entity.Core.Metadata.Edm.EdmFunction _aggregateFunction;
	}
}
