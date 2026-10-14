using System;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003C1 RID: 961
	internal class NodeCounter : global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<int>
	{
		// Token: 0x06002DFF RID: 11775 RVA: 0x000918A9 File Offset: 0x0008FAA9
		internal static int Count(global::System.Data.Entity.Core.Query.InternalTrees.Node subTree)
		{
			return new global::System.Data.Entity.Core.Query.InternalTrees.NodeCounter().VisitNode(subTree);
		}

		// Token: 0x06002E00 RID: 11776 RVA: 0x000918B8 File Offset: 0x0008FAB8
		protected override int VisitDefault(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			int num = 1;
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node n2 in n.Children)
			{
				num += base.VisitNode(n2);
			}
			return num;
		}
	}
}
