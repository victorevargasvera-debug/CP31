using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.Entity.Core.Common.EntitySql.AST;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Linq;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x02000653 RID: 1619
	internal abstract class GroupAggregateInfo
	{
		// Token: 0x06004E07 RID: 19975 RVA: 0x00117D69 File Offset: 0x00115F69
		protected GroupAggregateInfo(global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateKind aggregateKind, global::System.Data.Entity.Core.Common.EntitySql.AST.GroupAggregateExpr astNode, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx, global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateInfo containingAggregate, global::System.Data.Entity.Core.Common.EntitySql.ScopeRegion definingScopeRegion)
		{
			this.AggregateKind = aggregateKind;
			this.AstNode = astNode;
			this.ErrCtx = errCtx;
			this.DefiningScopeRegion = definingScopeRegion;
			this.SetContainingAggregate(containingAggregate);
		}

		// Token: 0x06004E08 RID: 19976 RVA: 0x00117D96 File Offset: 0x00115F96
		protected void AttachToAstNode(string aggregateName, global::System.Data.Entity.Core.Metadata.Edm.TypeUsage resultType)
		{
			this.AggregateName = aggregateName;
			this.AggregateStubExpression = resultType.Null();
			this.AstNode.AggregateInfo = this;
		}

		// Token: 0x06004E09 RID: 19977 RVA: 0x00117DB7 File Offset: 0x00115FB7
		internal void DetachFromAstNode()
		{
			this.AstNode.AggregateInfo = null;
		}

		// Token: 0x06004E0A RID: 19978 RVA: 0x00117DC8 File Offset: 0x00115FC8
		internal void UpdateScopeIndex(int referencedScopeIndex, global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			global::System.Data.Entity.Core.Common.EntitySql.ScopeRegion definingScopeRegion = sr.GetDefiningScopeRegion(referencedScopeIndex);
			if (this._innermostReferencedScopeRegion == null || this._innermostReferencedScopeRegion.ScopeRegionIndex < definingScopeRegion.ScopeRegionIndex)
			{
				this._innermostReferencedScopeRegion = definingScopeRegion;
			}
		}

		// Token: 0x17000F04 RID: 3844
		// (get) Token: 0x06004E0B RID: 19979 RVA: 0x00117DFF File Offset: 0x00115FFF
		// (set) Token: 0x06004E0C RID: 19980 RVA: 0x00117E07 File Offset: 0x00116007
		internal global::System.Data.Entity.Core.Common.EntitySql.ScopeRegion InnermostReferencedScopeRegion
		{
			get
			{
				return this._innermostReferencedScopeRegion;
			}
			set
			{
				this._innermostReferencedScopeRegion = value;
			}
		}

		// Token: 0x06004E0D RID: 19981 RVA: 0x00117E10 File Offset: 0x00116010
		internal void ValidateAndComputeEvaluatingScopeRegion(global::System.Data.Entity.Core.Common.EntitySql.SemanticResolver sr)
		{
			this._evaluatingScopeRegion = (this._innermostReferencedScopeRegion ?? this.DefiningScopeRegion);
			if (!this._evaluatingScopeRegion.IsAggregating)
			{
				int scopeRegionIndex = this._evaluatingScopeRegion.ScopeRegionIndex;
				this._evaluatingScopeRegion = null;
				foreach (global::System.Data.Entity.Core.Common.EntitySql.ScopeRegion scopeRegion in sr.ScopeRegions.Skip(scopeRegionIndex))
				{
					if (scopeRegion.IsAggregating)
					{
						this._evaluatingScopeRegion = scopeRegion;
						break;
					}
				}
				if (this._evaluatingScopeRegion == null)
				{
					throw new global::System.Data.Entity.Core.EntitySqlException(global::System.Data.Entity.Resources.Strings.GroupVarNotFoundInScope);
				}
			}
			this.ValidateContainedAggregates(this._evaluatingScopeRegion.ScopeRegionIndex, this.DefiningScopeRegion.ScopeRegionIndex);
		}

		// Token: 0x06004E0E RID: 19982 RVA: 0x00117ED4 File Offset: 0x001160D4
		private void ValidateContainedAggregates(int outerBoundaryScopeRegionIndex, int innerBoundaryScopeRegionIndex)
		{
			if (this._containedAggregates != null)
			{
				foreach (global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateInfo groupAggregateInfo in this._containedAggregates)
				{
					if (groupAggregateInfo.EvaluatingScopeRegion.ScopeRegionIndex >= outerBoundaryScopeRegionIndex && groupAggregateInfo.EvaluatingScopeRegion.ScopeRegionIndex <= innerBoundaryScopeRegionIndex)
					{
						int num;
						int num2;
						string p = global::System.Data.Entity.Core.EntitySqlException.FormatErrorContext(this.ErrCtx.CommandText, this.ErrCtx.InputPosition, this.ErrCtx.ErrorContextInfo, this.ErrCtx.UseContextInfoAsResourceIdentifier, out num, out num2);
						throw new global::System.Data.Entity.Core.EntitySqlException(global::System.Data.Entity.Resources.Strings.NestedAggregateCannotBeUsedInAggregate(global::System.Data.Entity.Core.EntitySqlException.FormatErrorContext(groupAggregateInfo.ErrCtx.CommandText, groupAggregateInfo.ErrCtx.InputPosition, groupAggregateInfo.ErrCtx.ErrorContextInfo, groupAggregateInfo.ErrCtx.UseContextInfoAsResourceIdentifier, out num, out num2), p));
					}
					groupAggregateInfo.ValidateContainedAggregates(outerBoundaryScopeRegionIndex, innerBoundaryScopeRegionIndex);
				}
			}
		}

		// Token: 0x06004E0F RID: 19983 RVA: 0x00117FD4 File Offset: 0x001161D4
		internal void SetContainingAggregate(global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateInfo containingAggregate)
		{
			if (this._containingAggregate != null)
			{
				this._containingAggregate.RemoveContainedAggregate(this);
			}
			this._containingAggregate = containingAggregate;
			if (this._containingAggregate != null)
			{
				this._containingAggregate.AddContainedAggregate(this);
			}
		}

		// Token: 0x06004E10 RID: 19984 RVA: 0x00118005 File Offset: 0x00116205
		private void AddContainedAggregate(global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateInfo containedAggregate)
		{
			if (this._containedAggregates == null)
			{
				this._containedAggregates = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateInfo>();
			}
			this._containedAggregates.Add(containedAggregate);
		}

		// Token: 0x06004E11 RID: 19985 RVA: 0x00118026 File Offset: 0x00116226
		private void RemoveContainedAggregate(global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateInfo containedAggregate)
		{
			this._containedAggregates.Remove(containedAggregate);
		}

		// Token: 0x17000F05 RID: 3845
		// (get) Token: 0x06004E12 RID: 19986 RVA: 0x00118035 File Offset: 0x00116235
		internal global::System.Data.Entity.Core.Common.EntitySql.ScopeRegion EvaluatingScopeRegion
		{
			get
			{
				return this._evaluatingScopeRegion;
			}
		}

		// Token: 0x17000F06 RID: 3846
		// (get) Token: 0x06004E13 RID: 19987 RVA: 0x0011803D File Offset: 0x0011623D
		internal global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateInfo ContainingAggregate
		{
			get
			{
				return this._containingAggregate;
			}
		}

		// Token: 0x04001C3B RID: 7227
		private global::System.Data.Entity.Core.Common.EntitySql.ScopeRegion _innermostReferencedScopeRegion;

		// Token: 0x04001C3C RID: 7228
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateInfo> _containedAggregates;

		// Token: 0x04001C3D RID: 7229
		internal readonly global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateKind AggregateKind;

		// Token: 0x04001C3E RID: 7230
		internal readonly global::System.Data.Entity.Core.Common.EntitySql.AST.GroupAggregateExpr AstNode;

		// Token: 0x04001C3F RID: 7231
		internal readonly global::System.Data.Entity.Core.Common.EntitySql.ErrorContext ErrCtx;

		// Token: 0x04001C40 RID: 7232
		internal readonly global::System.Data.Entity.Core.Common.EntitySql.ScopeRegion DefiningScopeRegion;

		// Token: 0x04001C41 RID: 7233
		private global::System.Data.Entity.Core.Common.EntitySql.ScopeRegion _evaluatingScopeRegion;

		// Token: 0x04001C42 RID: 7234
		private global::System.Data.Entity.Core.Common.EntitySql.GroupAggregateInfo _containingAggregate;

		// Token: 0x04001C43 RID: 7235
		internal string AggregateName;

		// Token: 0x04001C44 RID: 7236
		internal global::System.Data.Entity.Core.Common.CommandTrees.DbNullExpression AggregateStubExpression;
	}
}
