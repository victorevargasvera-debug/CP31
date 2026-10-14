using System;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006C2 RID: 1730
	public sealed class DbGroupExpressionBinding
	{
		// Token: 0x060050FA RID: 20730 RVA: 0x00121978 File Offset: 0x0011FB78
		internal DbGroupExpressionBinding(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input, global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression inputRef, global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression groupRef)
		{
			this._expr = input;
			this._varRef = inputRef;
			this._groupVarRef = groupRef;
		}

		// Token: 0x17000FBC RID: 4028
		// (get) Token: 0x060050FB RID: 20731 RVA: 0x00121995 File Offset: 0x0011FB95
		public global::System.Data.Entity.Core.Common.CommandTrees.DbExpression Expression
		{
			get
			{
				return this._expr;
			}
		}

		// Token: 0x17000FBD RID: 4029
		// (get) Token: 0x060050FC RID: 20732 RVA: 0x0012199D File Offset: 0x0011FB9D
		public string VariableName
		{
			get
			{
				return this._varRef.VariableName;
			}
		}

		// Token: 0x17000FBE RID: 4030
		// (get) Token: 0x060050FD RID: 20733 RVA: 0x001219AA File Offset: 0x0011FBAA
		public global::System.Data.Entity.Core.Metadata.Edm.TypeUsage VariableType
		{
			get
			{
				return this._varRef.ResultType;
			}
		}

		// Token: 0x17000FBF RID: 4031
		// (get) Token: 0x060050FE RID: 20734 RVA: 0x001219B7 File Offset: 0x0011FBB7
		public global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression Variable
		{
			get
			{
				return this._varRef;
			}
		}

		// Token: 0x17000FC0 RID: 4032
		// (get) Token: 0x060050FF RID: 20735 RVA: 0x001219BF File Offset: 0x0011FBBF
		public string GroupVariableName
		{
			get
			{
				return this._groupVarRef.VariableName;
			}
		}

		// Token: 0x17000FC1 RID: 4033
		// (get) Token: 0x06005100 RID: 20736 RVA: 0x001219CC File Offset: 0x0011FBCC
		public global::System.Data.Entity.Core.Metadata.Edm.TypeUsage GroupVariableType
		{
			get
			{
				return this._groupVarRef.ResultType;
			}
		}

		// Token: 0x17000FC2 RID: 4034
		// (get) Token: 0x06005101 RID: 20737 RVA: 0x001219D9 File Offset: 0x0011FBD9
		public global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression GroupVariable
		{
			get
			{
				return this._groupVarRef;
			}
		}

		// Token: 0x17000FC3 RID: 4035
		// (get) Token: 0x06005102 RID: 20738 RVA: 0x001219E1 File Offset: 0x0011FBE1
		public global::System.Data.Entity.Core.Common.CommandTrees.DbGroupAggregate GroupAggregate
		{
			get
			{
				if (this._groupAggregate == null)
				{
					this._groupAggregate = global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.DbExpressionBuilder.GroupAggregate(this.GroupVariable);
				}
				return this._groupAggregate;
			}
		}

		// Token: 0x04001DA4 RID: 7588
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _expr;

		// Token: 0x04001DA5 RID: 7589
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression _varRef;

		// Token: 0x04001DA6 RID: 7590
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression _groupVarRef;

		// Token: 0x04001DA7 RID: 7591
		private global::System.Data.Entity.Core.Common.CommandTrees.DbGroupAggregate _groupAggregate;
	}
}
