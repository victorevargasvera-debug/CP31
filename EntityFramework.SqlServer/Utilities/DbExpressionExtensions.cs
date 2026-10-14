using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;

namespace System.Data.Entity.SqlServer.Utilities
{
	// Token: 0x0200001B RID: 27
	internal static class DbExpressionExtensions
	{
		// Token: 0x0600036F RID: 879 RVA: 0x0000EA2E File Offset: 0x0000CC2E
		public static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> GetLeafNodes(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression root, global::System.Data.Entity.Core.Common.CommandTrees.DbExpressionKind kind, global::System.Func<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>> getChildNodes)
		{
			global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression> nodes = new global::System.Collections.Generic.Stack<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>();
			nodes.Push(root);
			while (nodes.Count > 0)
			{
				global::System.Data.Entity.Core.Common.CommandTrees.DbExpression dbExpression = nodes.Pop();
				if (dbExpression.ExpressionKind != kind)
				{
					yield return dbExpression;
				}
				else
				{
					foreach (global::System.Data.Entity.Core.Common.CommandTrees.DbExpression item in getChildNodes(dbExpression).Reverse<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>())
					{
						nodes.Push(item);
					}
				}
			}
			yield break;
		}
	}
}
