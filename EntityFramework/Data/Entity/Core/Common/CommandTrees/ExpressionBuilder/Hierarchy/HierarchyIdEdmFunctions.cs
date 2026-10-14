using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.Hierarchy
{
	// Token: 0x020006FD RID: 1789
	public static class HierarchyIdEdmFunctions
	{
		// Token: 0x06005495 RID: 21653 RVA: 0x0012F3F4 File Offset: 0x0012D5F4
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression HierarchyIdParse(global::System.Data.Entity.Core.Common.CommandTrees.DbExpression input)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(input, "input");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("HierarchyIdParse", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				input
			});
		}

		// Token: 0x06005496 RID: 21654 RVA: 0x0012F416 File Offset: 0x0012D616
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression HierarchyIdGetRoot()
		{
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("HierarchyIdGetRoot", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[0]);
		}

		// Token: 0x06005497 RID: 21655 RVA: 0x0012F428 File Offset: 0x0012D628
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GetAncestor(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression hierarchyIdValue, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression n)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(hierarchyIdValue, "hierarchyIdValue");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(n, "n");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GetAncestor", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				hierarchyIdValue,
				n
			});
		}

		// Token: 0x06005498 RID: 21656 RVA: 0x0012F45C File Offset: 0x0012D65C
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GetDescendant(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression hierarchyIdValue, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression child1, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression child2)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(hierarchyIdValue, "hierarchyIdValue");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(child1, "child1");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(child2, "child2");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GetDescendant", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				hierarchyIdValue,
				child1,
				child2
			});
		}

		// Token: 0x06005499 RID: 21657 RVA: 0x0012F4A9 File Offset: 0x0012D6A9
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GetLevel(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression hierarchyIdValue)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(hierarchyIdValue, "hierarchyIdValue");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GetLevel", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				hierarchyIdValue
			});
		}

		// Token: 0x0600549A RID: 21658 RVA: 0x0012F4CB File Offset: 0x0012D6CB
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression IsDescendantOf(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression hierarchyIdValue, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression parent)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(hierarchyIdValue, "hierarchyIdValue");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(parent, "parent");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("IsDescendantOf", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				hierarchyIdValue,
				parent
			});
		}

		// Token: 0x0600549B RID: 21659 RVA: 0x0012F500 File Offset: 0x0012D700
		public static global::System.Data.Entity.Core.Common.CommandTrees.DbFunctionExpression GetReparentedValue(this global::System.Data.Entity.Core.Common.CommandTrees.DbExpression hierarchyIdValue, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression oldRoot, global::System.Data.Entity.Core.Common.CommandTrees.DbExpression newRoot)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(hierarchyIdValue, "hierarchyIdValue");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(oldRoot, "oldRoot");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Common.CommandTrees.DbExpression>(newRoot, "newRoot");
			return global::System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder.EdmFunctions.InvokeCanonicalFunction("GetReparentedValue", new global::System.Data.Entity.Core.Common.CommandTrees.DbExpression[]
			{
				hierarchyIdValue,
				oldRoot,
				newRoot
			});
		}
	}
}
