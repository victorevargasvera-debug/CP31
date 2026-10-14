using System;

namespace System.Data.Entity.Hierarchy
{
	// Token: 0x020002C8 RID: 712
	[global::System.Serializable]
	public abstract class DbHierarchyServices
	{
		// Token: 0x0600223B RID: 8763
		public abstract global::System.Data.Entity.Hierarchy.HierarchyId GetAncestor(int n);

		// Token: 0x0600223C RID: 8764
		public abstract global::System.Data.Entity.Hierarchy.HierarchyId GetDescendant(global::System.Data.Entity.Hierarchy.HierarchyId child1, global::System.Data.Entity.Hierarchy.HierarchyId child2);

		// Token: 0x0600223D RID: 8765
		public abstract short GetLevel();

		// Token: 0x0600223E RID: 8766 RVA: 0x0005FB25 File Offset: 0x0005DD25
		public static global::System.Data.Entity.Hierarchy.HierarchyId GetRoot()
		{
			return new global::System.Data.Entity.Hierarchy.HierarchyId("/");
		}

		// Token: 0x0600223F RID: 8767
		public abstract bool IsDescendantOf(global::System.Data.Entity.Hierarchy.HierarchyId parent);

		// Token: 0x06002240 RID: 8768
		public abstract global::System.Data.Entity.Hierarchy.HierarchyId GetReparentedValue(global::System.Data.Entity.Hierarchy.HierarchyId oldRoot, global::System.Data.Entity.Hierarchy.HierarchyId newRoot);

		// Token: 0x06002241 RID: 8769 RVA: 0x0005FB31 File Offset: 0x0005DD31
		public static global::System.Data.Entity.Hierarchy.HierarchyId Parse(string input)
		{
			return new global::System.Data.Entity.Hierarchy.HierarchyId(input);
		}
	}
}
