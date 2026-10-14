using System;
using System.Data.Entity.Hierarchy;
using System.Data.Entity.SqlServer.Resources;

namespace System.Data.Entity.SqlServer
{
	// Token: 0x0200000E RID: 14
	public static class SqlHierarchyIdFunctions
	{
		// Token: 0x060000EA RID: 234 RVA: 0x00003AD4 File Offset: 0x00001CD4
		[global::System.Data.Entity.DbFunction("SqlServer", "GetAncestor")]
		public static global::System.Data.Entity.Hierarchy.HierarchyId GetAncestor(global::System.Data.Entity.Hierarchy.HierarchyId hierarchyIdValue, int n)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00003AE0 File Offset: 0x00001CE0
		[global::System.Data.Entity.DbFunction("SqlServer", "GetDescendant")]
		public static global::System.Data.Entity.Hierarchy.HierarchyId GetDescendant(global::System.Data.Entity.Hierarchy.HierarchyId hierarchyIdValue, global::System.Data.Entity.Hierarchy.HierarchyId child1, global::System.Data.Entity.Hierarchy.HierarchyId child2)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00003AEC File Offset: 0x00001CEC
		[global::System.Data.Entity.DbFunction("SqlServer", "GetLevel")]
		public static short GetLevel(global::System.Data.Entity.Hierarchy.HierarchyId hierarchyIdValue)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00003AF8 File Offset: 0x00001CF8
		[global::System.Data.Entity.DbFunction("SqlServer", "GetRoot")]
		public static global::System.Data.Entity.Hierarchy.HierarchyId GetRoot()
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00003B04 File Offset: 0x00001D04
		[global::System.Data.Entity.DbFunction("SqlServer", "IsDescendantOf")]
		public static bool IsDescendantOf(global::System.Data.Entity.Hierarchy.HierarchyId hierarchyIdValue, global::System.Data.Entity.Hierarchy.HierarchyId parent)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00003B10 File Offset: 0x00001D10
		[global::System.Data.Entity.DbFunction("SqlServer", "GetReparentedValue")]
		public static global::System.Data.Entity.Hierarchy.HierarchyId GetReparentedValue(global::System.Data.Entity.Hierarchy.HierarchyId hierarchyIdValue, global::System.Data.Entity.Hierarchy.HierarchyId oldRoot, global::System.Data.Entity.Hierarchy.HierarchyId newRoot)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.ELinq_DbFunctionDirectCall);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00003B1C File Offset: 0x00001D1C
		[global::System.Data.Entity.DbFunction("SqlServer", "Parse")]
		public static global::System.Data.Entity.Hierarchy.HierarchyId Parse(string input)
		{
			throw new global::System.NotSupportedException(global::System.Data.Entity.SqlServer.Resources.Strings.ELinq_DbFunctionDirectCall);
		}
	}
}
