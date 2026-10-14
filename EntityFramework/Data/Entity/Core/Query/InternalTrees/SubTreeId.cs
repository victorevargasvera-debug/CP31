using System;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003F1 RID: 1009
	internal class SubTreeId
	{
		// Token: 0x06002F3E RID: 12094 RVA: 0x0009495B File Offset: 0x00092B5B
		internal SubTreeId(global::System.Data.Entity.Core.Query.InternalTrees.RuleProcessingContext context, global::System.Data.Entity.Core.Query.InternalTrees.Node node, global::System.Data.Entity.Core.Query.InternalTrees.Node parent, int childIndex)
		{
			this.m_subTreeRoot = node;
			this.m_parent = parent;
			this.m_childIndex = childIndex;
			this.m_hashCode = context.GetHashCode(node);
		}

		// Token: 0x06002F3F RID: 12095 RVA: 0x00094986 File Offset: 0x00092B86
		public override int GetHashCode()
		{
			return this.m_hashCode;
		}

		// Token: 0x06002F40 RID: 12096 RVA: 0x00094990 File Offset: 0x00092B90
		public override bool Equals(object obj)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.SubTreeId subTreeId = obj as global::System.Data.Entity.Core.Query.InternalTrees.SubTreeId;
			return subTreeId != null && this.m_hashCode == subTreeId.m_hashCode && (subTreeId.m_subTreeRoot == this.m_subTreeRoot || (subTreeId.m_parent == this.m_parent && subTreeId.m_childIndex == this.m_childIndex));
		}

		// Token: 0x04000FEB RID: 4075
		public global::System.Data.Entity.Core.Query.InternalTrees.Node m_subTreeRoot;

		// Token: 0x04000FEC RID: 4076
		private readonly int m_hashCode;

		// Token: 0x04000FED RID: 4077
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.Node m_parent;

		// Token: 0x04000FEE RID: 4078
		private readonly int m_childIndex;
	}
}
