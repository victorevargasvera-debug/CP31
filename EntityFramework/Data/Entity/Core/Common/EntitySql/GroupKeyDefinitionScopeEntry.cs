using System;
using System.Data.Entity.Core.Common.CommandTrees;

namespace System.Data.Entity.Core.Common.EntitySql
{
	// Token: 0x02000656 RID: 1622
	internal sealed class GroupKeyDefinitionScopeEntry : global::System.Data.Entity.Core.Common.EntitySql.ScopeEntry, global::System.Data.Entity.Core.Common.EntitySql.IGroupExpressionExtendedInfo, global::System.Data.Entity.Core.Common.EntitySql.IGetAlternativeName
	{
		// Token: 0x06004E15 RID: 19989 RVA: 0x00118053 File Offset: 0x00116253
		internal GroupKeyDefinitionScopeEntry(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression varBasedExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression groupVarBasedExpression, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression groupAggBasedExpression, string[] alternativeName) : base(global::System.Data.Entity.Core.Common.EntitySql.ScopeEntryKind.GroupKeyDefinition)
		{
			this._varBasedExpression = varBasedExpression;
			this._groupVarBasedExpression = groupVarBasedExpression;
			this._groupAggBasedExpression = groupAggBasedExpression;
			this._alternativeName = alternativeName;
		}

		// Token: 0x06004E16 RID: 19990 RVA: 0x00118079 File Offset: 0x00116279
		internal override global::System.Data.Entity.Core.Common.CommandTrees.DbExpression GetExpression(string refName, global::System.Data.Entity.Core.Common.EntitySql.ErrorContext errCtx)
		{
			return this._varBasedExpression;
		}

		// Token: 0x17000F07 RID: 3847
		// (get) Token: 0x06004E17 RID: 19991 RVA: 0x00118081 File Offset: 0x00116281
		global::System.Data.Entity.Core.Common.CommandTrees.DbExpression global::System.Data.Entity.Core.Common.EntitySql.IGroupExpressionExtendedInfo.GroupVarBasedExpression
		{
			get
			{
				return this._groupVarBasedExpression;
			}
		}

		// Token: 0x17000F08 RID: 3848
		// (get) Token: 0x06004E18 RID: 19992 RVA: 0x00118089 File Offset: 0x00116289
		global::System.Data.Entity.Core.Common.CommandTrees.DbExpression global::System.Data.Entity.Core.Common.EntitySql.IGroupExpressionExtendedInfo.GroupAggBasedExpression
		{
			get
			{
				return this._groupAggBasedExpression;
			}
		}

		// Token: 0x17000F09 RID: 3849
		// (get) Token: 0x06004E19 RID: 19993 RVA: 0x00118091 File Offset: 0x00116291
		string[] global::System.Data.Entity.Core.Common.EntitySql.IGetAlternativeName.AlternativeName
		{
			get
			{
				return this._alternativeName;
			}
		}

		// Token: 0x04001C4A RID: 7242
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _varBasedExpression;

		// Token: 0x04001C4B RID: 7243
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _groupVarBasedExpression;

		// Token: 0x04001C4C RID: 7244
		private readonly global::System.Data.Entity.Core.Common.CommandTrees.DbExpression _groupAggBasedExpression;

		// Token: 0x04001C4D RID: 7245
		private readonly string[] _alternativeName;
	}
}
