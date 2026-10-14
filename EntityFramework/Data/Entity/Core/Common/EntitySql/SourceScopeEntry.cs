using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x0200066C RID: 1644
	internal sealed class SourceScopeEntry : global::System.Data.Entity.Core.Common.EntitySql.ScopeEntry, global::System.Data.Entity.Core.Common.EntitySql.IGroupExpressionExtendedInfo, global::System.Data.Entity.Core.Common.EntitySql.IGetAlternativeName
	{
		// Token: 0x06004EE8 RID: 20200 RVA: 0x0011E659 File Offset: 0x0011C859
		internal SourceScopeEntry(global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression varRef) : this(varRef, null)
		{
		}

		// Token: 0x06004EE9 RID: 20201 RVA: 0x0011E663 File Offset: 0x0011C863
		internal SourceScopeEntry(global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression varRef, string[] alternativeName) : base(global::System.Data.Entity.Core.Common.EntitySql.ScopeEntryKind.SourceVar)
		{
			this._varBasedExpression = varRef;
			this._alternativeName = alternativeName;
		}

		// Token: 0x06004EEA RID: 20202 RVA: 0x0011E67A File Offset: 0x0011C87A
		internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression GetExpression(string refName, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx)
		{
			return this._varBasedExpression;
		}

		// Token: 0x17000F2F RID: 3887
		// (get) Token: 0x06004EEB RID: 20203 RVA: 0x0011E682 File Offset: 0x0011C882
		global::System.Data.Entity.Core.Common.CommandTrees.DbExpression global::System.Data.Entity.Core.Common.EntitySql.IGroupExpressionExtendedInfo.GroupVarBasedExpression
		{
			get
			{
				return this._groupVarBasedExpression;
			}
		}

		// Token: 0x17000F30 RID: 3888
		// (get) Token: 0x06004EEC RID: 20204 RVA: 0x0011E68A File Offset: 0x0011C88A
		global::System.Data.Entity.Core.Common.CommandTrees.DbExpression global::System.Data.Entity.Core.Common.EntitySql.IGroupExpressionExtendedInfo.GroupAggBasedExpression
		{
			get
			{
				return this._groupAggBasedExpression;
			}
		}

		// Token: 0x17000F31 RID: 3889
		// (get) Token: 0x06004EED RID: 20205 RVA: 0x0011E692 File Offset: 0x0011C892
		// (set) Token: 0x06004EEE RID: 20206 RVA: 0x0011E69A File Offset: 0x0011C89A
		internal bool IsJoinClauseLeftExpr { get; set; }

		// Token: 0x17000F32 RID: 3890
		// (get) Token: 0x06004EEF RID: 20207 RVA: 0x0011E6A3 File Offset: 0x0011C8A3
		string[] global::System.Data.Entity.Core.Common.EntitySql.IGetAlternativeName.AlternativeName
		{
			get
			{
				return this._alternativeName;
			}
		}

		// Token: 0x06004EF0 RID: 20208 RVA: 0x0011E6AC File Offset: 0x0011C8AC
		internal global::System.Data.Entity.Core.Common.EntitySql.SourceScopeEntry AddParentVar(global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression parentVarRef)
		{
			if (this._propRefs == null)
			{
				this._propRefs = new global::System.Collections.Generic.List<string>(2);
				this._propRefs.Add(((global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression)this._varBasedExpression).VariableName);
			}
			this._varBasedExpression = parentVarRef;
			for (int i = this._propRefs.Count - 1; i >= 0; i--)
			{
				this._varBasedExpression = this._varBasedExpression.Property(this._propRefs[i]);
			}
			this._propRefs.Add(parentVarRef.VariableName);
			return this;
		}

		// Token: 0x06004EF1 RID: 20209 RVA: 0x0011E736 File Offset: 0x0011C936
		internal void ReplaceParentVar(global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression parentVarRef)
		{
			if (this._propRefs == null)
			{
				this._varBasedExpression = parentVarRef;
				return;
			}
			this._propRefs.RemoveAt(this._propRefs.Count - 1);
			this.AddParentVar(parentVarRef);
		}

		// Token: 0x06004EF2 RID: 20210 RVA: 0x0011E768 File Offset: 0x0011C968
		internal void AdjustToGroupVar(global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression parentVarRef, global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression parentGroupVarRef, global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression groupAggRef)
		{
			this.ReplaceParentVar(parentVarRef);
			this._groupVarBasedExpression = parentGroupVarRef;
			this._groupAggBasedExpression = groupAggRef;
			if (this._propRefs != null)
			{
				for (int i = this._propRefs.Count - 2; i >= 0; i--)
				{
					this._groupVarBasedExpression = this._groupVarBasedExpression.Property(this._propRefs[i]);
					this._groupAggBasedExpression = this._groupAggBasedExpression.Property(this._propRefs[i]);
				}
			}
		}

		// Token: 0x06004EF3 RID: 20211 RVA: 0x0011E7E4 File Offset: 0x0011C9E4
		internal void RollbackAdjustmentToGroupVar(global::System.Data.Entity.Core.Common.CommandTrees.DbVariableReferenceExpression pregroupParentVarRef)
		{
			this._groupVarBasedExpression = null;
			this._groupAggBasedExpression = null;
			this.ReplaceParentVar(pregroupParentVarRef);
		}

		// Token: 0x04001C80 RID: 7296
		private readonly string[] _alternativeName;

		// Token: 0x04001C81 RID: 7297
		private global::System.Collections.Generic.List<string> _propRefs;

		// Token: 0x04001C82 RID: 7298
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _varBasedExpression;

		// Token: 0x04001C83 RID: 7299
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _groupVarBasedExpression;

		// Token: 0x04001C84 RID: 7300
		private global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _groupAggBasedExpression;
	}
}
