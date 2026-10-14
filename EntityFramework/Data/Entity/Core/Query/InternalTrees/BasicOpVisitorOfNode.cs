using System;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x02000380 RID: 896
	internal abstract class BasicOpVisitorOfNode : global::System.Data.Entity.Core.Query.InternalTrees.BasicOpVisitorOfT<global::System.Data.Entity.Core.Query.InternalTrees.Node>
	{
		// Token: 0x06002B64 RID: 11108 RVA: 0x0008CB30 File Offset: 0x0008AD30
		protected override void VisitChildren(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			for (int i = 0; i < n.Children.Count; i++)
			{
				n.Children[i] = base.VisitNode(n.Children[i]);
			}
		}

		// Token: 0x06002B65 RID: 11109 RVA: 0x0008CB74 File Offset: 0x0008AD74
		protected override void VisitChildrenReverse(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			for (int i = n.Children.Count - 1; i >= 0; i--)
			{
				n.Children[i] = base.VisitNode(n.Children[i]);
			}
		}

		// Token: 0x06002B66 RID: 11110 RVA: 0x0008CBB7 File Offset: 0x0008ADB7
		protected override global::System.Data.Entity.Core.Query.InternalTrees.Node VisitDefault(global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			this.VisitChildren(n);
			return n;
		}

		// Token: 0x06002B67 RID: 11111 RVA: 0x0008CBC1 File Offset: 0x0008ADC1
		protected override global::System.Data.Entity.Core.Query.InternalTrees.Node VisitAncillaryOpDefault(global::System.Data.Entity.Core.Query.InternalTrees.AncillaryOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitDefault(n);
		}

		// Token: 0x06002B68 RID: 11112 RVA: 0x0008CBCA File Offset: 0x0008ADCA
		protected override global::System.Data.Entity.Core.Query.InternalTrees.Node VisitPhysicalOpDefault(global::System.Data.Entity.Core.Query.InternalTrees.PhysicalOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitDefault(n);
		}

		// Token: 0x06002B69 RID: 11113 RVA: 0x0008CBD3 File Offset: 0x0008ADD3
		protected override global::System.Data.Entity.Core.Query.InternalTrees.Node VisitRelOpDefault(global::System.Data.Entity.Core.Query.InternalTrees.RelOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitDefault(n);
		}

		// Token: 0x06002B6A RID: 11114 RVA: 0x0008CBDC File Offset: 0x0008ADDC
		protected override global::System.Data.Entity.Core.Query.InternalTrees.Node VisitScalarOpDefault(global::System.Data.Entity.Core.Query.InternalTrees.ScalarOp op, global::System.Data.Entity.Core.Query.InternalTrees.Node n)
		{
			return this.VisitDefault(n);
		}
	}
}
