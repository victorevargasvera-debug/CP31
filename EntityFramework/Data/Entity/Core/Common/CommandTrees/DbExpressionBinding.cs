using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006B7 RID: 1719
	public sealed class DbExpressionBinding
	{
		// Token: 0x0600507E RID: 20606 RVA: 0x001216C2 File Offset: 0x0011F8C2
		internal DbExpressionBinding(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input, global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression varRef)
		{
			this._expr = input;
			this._varRef = varRef;
		}

		// Token: 0x17000FAC RID: 4012
		// (get) Token: 0x0600507F RID: 20607 RVA: 0x001216D8 File Offset: 0x0011F8D8
		public global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Expression
		{
			get
			{
				return this._expr;
			}
		}

		// Token: 0x17000FAD RID: 4013
		// (get) Token: 0x06005080 RID: 20608 RVA: 0x001216E0 File Offset: 0x0011F8E0
		public string VariableName
		{
			get
			{
				return this._varRef.VariableName;
			}
		}

		// Token: 0x17000FAE RID: 4014
		// (get) Token: 0x06005081 RID: 20609 RVA: 0x001216ED File Offset: 0x0011F8ED
		public global::System.Data.Entity.Core.Metadata.Edm.TypeUsage VariableType
		{
			get
			{
				return this._varRef.ResultType;
			}
		}

		// Token: 0x17000FAF RID: 4015
		// (get) Token: 0x06005082 RID: 20610 RVA: 0x001216FA File Offset: 0x0011F8FA
		public global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression Variable
		{
			get
			{
				return this._varRef;
			}
		}

		// Token: 0x04001D58 RID: 7512
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _expr;

		// Token: 0x04001D59 RID: 7513
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression _varRef;
	}
}
