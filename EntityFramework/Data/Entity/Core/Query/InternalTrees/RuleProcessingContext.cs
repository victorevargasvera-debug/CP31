using System;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003DB RID: 987
	internal abstract class RuleProcessingContext
	{
		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06002ED8 RID: 11992 RVA: 0x000941BB File Offset: 0x000923BB
		internal global::System.Data.Entity.Core.Query.InternalTrees.Command Command
		{
			get
			{
				return this.m_command;
			}
		}

		// Token: 0x06002ED9 RID: 11993 RVA: 0x000941C3 File Offset: 0x000923C3
		internal virtual void PreProcess(global::System.Data.Entity.Core.Query.InternalTrees.Node node)
		{
		}

		// Token: 0x06002EDA RID: 11994 RVA: 0x000941C5 File Offset: 0x000923C5
		internal virtual void PreProcessSubTree(global::System.Data.Entity.Core.Query.InternalTrees.Node node)
		{
		}

		// Token: 0x06002EDB RID: 11995 RVA: 0x000941C7 File Offset: 0x000923C7
		internal virtual void PostProcess(global::System.Data.Entity.Core.Query.InternalTrees.Node node, global::System.Data.Entity.Core.Query.InternalTrees.Rule rule)
		{
		}

		// Token: 0x06002EDC RID: 11996 RVA: 0x000941C9 File Offset: 0x000923C9
		internal virtual void PostProcessSubTree(global::System.Data.Entity.Core.Query.InternalTrees.Node node)
		{
		}

		// Token: 0x06002EDD RID: 11997 RVA: 0x000941CB File Offset: 0x000923CB
		internal virtual int GetHashCode(global::System.Data.Entity.Core.Query.InternalTrees.Node node)
		{
			return node.GetHashCode();
		}

		// Token: 0x06002EDE RID: 11998 RVA: 0x000941D3 File Offset: 0x000923D3
		internal RuleProcessingContext(global::System.Data.Entity.Core.Query.InternalTrees.Command command)
		{
			this.m_command = command;
		}

		// Token: 0x04000FD0 RID: 4048
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.Command m_command;
	}
}
