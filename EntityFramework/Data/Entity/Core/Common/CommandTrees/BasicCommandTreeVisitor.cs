using System;
using System.Collections.Generic;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees
{
	// Token: 0x020006A2 RID: 1698
	public abstract class BasicCommandTreeVisitor : global::System.Data.Entity.Core.Common.CommandTrees.BasicExpressionVisitor
	{
		// Token: 0x06004FBF RID: 20415 RVA: 0x001203A7 File Offset: 0x0011E5A7
		protected virtual void VisitSetClause(global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause setClause)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause>(setClause, "setClause");
			this.VisitExpression(setClause.Property);
			this.VisitExpression(setClause.Value);
		}

		// Token: 0x06004FC0 RID: 20416 RVA: 0x001203CD File Offset: 0x0011E5CD
		protected virtual void VisitModificationClause(global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause modificationClause)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause>(modificationClause, "modificationClause");
			this.VisitSetClause((global::System.Data.Entity.Core.Common.CommandTrees.DbSetClause)modificationClause);
		}

		// Token: 0x06004FC1 RID: 20417 RVA: 0x001203E8 File Offset: 0x0011E5E8
		protected virtual void VisitModificationClauses(global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause> modificationClauses)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationClause>>(modificationClauses, "modificationClauses");
			for (int i = 0; i < modificationClauses.Count; i++)
			{
				this.VisitModificationClause(modificationClauses[i]);
			}
		}

		// Token: 0x06004FC2 RID: 20418 RVA: 0x00120420 File Offset: 0x0011E620
		public virtual void VisitCommandTree(global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree commandTree)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree>(commandTree, "commandTree");
			switch (commandTree.CommandTreeKind)
			{
			case global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTreeKind.Query:
				this.VisitQueryCommandTree((global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree)commandTree);
				return;
			case global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTreeKind.Update:
				this.VisitUpdateCommandTree((global::System.Data.Entity.Core.Common.CommandTrees.DbUpdateCommandTree)commandTree);
				return;
			case global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTreeKind.Insert:
				this.VisitInsertCommandTree((global::System.Data.Entity.Core.Common.CommandTrees.DbInsertCommandTree)commandTree);
				return;
			case global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTreeKind.Delete:
				this.VisitDeleteCommandTree((global::System.Data.Entity.Core.Common.CommandTrees.DbDeleteCommandTree)commandTree);
				return;
			case global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTreeKind.Function:
				this.VisitFunctionCommandTree((global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionCommandTree)commandTree);
				return;
			default:
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x06004FC3 RID: 20419 RVA: 0x001204A2 File Offset: 0x0011E6A2
		protected virtual void VisitDeleteCommandTree(global::System.Data.Entity.Core.Common.CommandTrees.DbDeleteCommandTree deleteTree)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbDeleteCommandTree>(deleteTree, "deleteTree");
			this.VisitExpressionBindingPre(deleteTree.Target);
			this.VisitExpression(deleteTree.Predicate);
			this.VisitExpressionBindingPost(deleteTree.Target);
		}

		// Token: 0x06004FC4 RID: 20420 RVA: 0x001204D4 File Offset: 0x0011E6D4
		protected virtual void VisitFunctionCommandTree(global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionCommandTree functionTree)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionCommandTree>(functionTree, "functionTree");
		}

		// Token: 0x06004FC5 RID: 20421 RVA: 0x001204E4 File Offset: 0x0011E6E4
		protected virtual void VisitInsertCommandTree(global::System.Data.Entity.Core.Common.CommandTrees.DbInsertCommandTree insertTree)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbInsertCommandTree>(insertTree, "insertTree");
			this.VisitExpressionBindingPre(insertTree.Target);
			this.VisitModificationClauses(insertTree.SetClauses);
			if (insertTree.Returning != null)
			{
				this.VisitExpression(insertTree.Returning);
			}
			this.VisitExpressionBindingPost(insertTree.Target);
		}

		// Token: 0x06004FC6 RID: 20422 RVA: 0x00120535 File Offset: 0x0011E735
		protected virtual void VisitQueryCommandTree(global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree queryTree)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbQueryCommandTree>(queryTree, "queryTree");
			this.VisitExpression(queryTree.Query);
		}

		// Token: 0x06004FC7 RID: 20423 RVA: 0x00120550 File Offset: 0x0011E750
		protected virtual void VisitUpdateCommandTree(global::System.Data.Entity.Core.Common.CommandTrees.DbUpdateCommandTree updateTree)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbUpdateCommandTree>(updateTree, "updateTree");
			this.VisitExpressionBindingPre(updateTree.Target);
			this.VisitModificationClauses(updateTree.SetClauses);
			this.VisitExpression(updateTree.Predicate);
			if (updateTree.Returning != null)
			{
				this.VisitExpression(updateTree.Returning);
			}
			this.VisitExpressionBindingPost(updateTree.Target);
		}
	}
}
