using System;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003CC RID: 972
	internal sealed class PatternMatchRule : global::System.Data.Entity.Core.Query.InternalTrees.Rule
	{
		// Token: 0x06002E93 RID: 11923 RVA: 0x00093C53 File Offset: 0x00091E53
		internal PatternMatchRule(global::System.Data.Entity.Core.Query.InternalTrees.Node pattern, global::System.Data.Entity.Core.Query.InternalTrees.Rule.ProcessNodeDelegate processDelegate) : base(pattern.Op.OpType, processDelegate)
		{
			this.m_pattern = pattern;
		}

		// Token: 0x06002E94 RID: 11924 RVA: 0x00093C70 File Offset: 0x00091E70
		private bool Match(global::System.Data.Entity.Core.Query.InternalTrees.Node pattern, global::System.Data.Entity.Core.Query.InternalTrees.Node original)
		{
			if (pattern.Op.OpType == global::System.Data.Entity.Core.Query.InternalTrees.OpType.Leaf)
			{
				return true;
			}
			if (pattern.Op.OpType != original.Op.OpType)
			{
				return false;
			}
			if (pattern.Children.Count != original.Children.Count)
			{
				return false;
			}
			for (int i = 0; i < pattern.Children.Count; i++)
			{
				if (!this.Match(pattern.Children[i], original.Children[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06002E95 RID: 11925 RVA: 0x00093CFB File Offset: 0x00091EFB
		internal override bool Match(global::System.Data.Entity.Core.Query.InternalTrees.Node node)
		{
			return this.Match(this.m_pattern, node);
		}

		// Token: 0x04000FB7 RID: 4023
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.Node m_pattern;
	}
}
