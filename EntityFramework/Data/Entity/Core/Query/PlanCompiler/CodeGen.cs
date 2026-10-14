using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Query.InternalTrees;

namespace System.Data.Entity.Core.Query.PlanCompiler
{
	// Token: 0x02000333 RID: 819
	internal class CodeGen
	{
		// Token: 0x0600270D RID: 9997 RVA: 0x00070393 File Offset: 0x0006E593
		internal static void Process(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler compilerState, out global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.ProviderCommandInfo> childCommands, out global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap resultColumnMap, out int columnCount)
		{
			new global::System.Data.Entity.Core.Query.PlanCompiler.CodeGen(compilerState).Process(out childCommands, out resultColumnMap, out columnCount);
		}

		// Token: 0x0600270E RID: 9998 RVA: 0x000703A3 File Offset: 0x0006E5A3
		private CodeGen(global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler compilerState)
		{
			this.m_compilerState = compilerState;
		}

		// Token: 0x0600270F RID: 9999 RVA: 0x000703B4 File Offset: 0x0006E5B4
		private void Process(out global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.ProviderCommandInfo> childCommands, out global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap resultColumnMap, out int columnCount)
		{
			global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp physicalProjectOp = (global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp)this.Command.Root.Op;
			this.m_subCommands = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node>(new global::System.Data.Entity.Core.Query.InternalTrees.Node[]
			{
				this.Command.Root
			});
			childCommands = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.PlanCompiler.ProviderCommandInfo>(new global::System.Data.Entity.Core.Query.PlanCompiler.ProviderCommandInfo[]
			{
				global::System.Data.Entity.Core.Query.PlanCompiler.ProviderCommandInfoUtils.Create(this.Command, this.Command.Root)
			});
			resultColumnMap = this.BuildResultColumnMap(physicalProjectOp);
			columnCount = physicalProjectOp.Outputs.Count;
		}

		// Token: 0x06002710 RID: 10000 RVA: 0x00070434 File Offset: 0x0006E634
		private global::System.Data.Entity.Core.Query.InternalTrees.ColumnMap BuildResultColumnMap(global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp projectOp)
		{
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Collections.Generic.KeyValuePair<int, int>> varToCommandColumnMap = this.BuildVarMap();
			return global::System.Data.Entity.Core.Query.PlanCompiler.ColumnMapTranslator.Translate(projectOp.ColumnMap, varToCommandColumnMap);
		}

		// Token: 0x06002711 RID: 10001 RVA: 0x00070454 File Offset: 0x0006E654
		private global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Collections.Generic.KeyValuePair<int, int>> BuildVarMap()
		{
			global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Collections.Generic.KeyValuePair<int, int>> dictionary = new global::System.Collections.Generic.Dictionary<global::System.Data.Entity.Core.Query.InternalTrees.Var, global::System.Collections.Generic.KeyValuePair<int, int>>();
			int num = 0;
			foreach (global::System.Data.Entity.Core.Query.InternalTrees.Node node in this.m_subCommands)
			{
				global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp physicalProjectOp = (global::System.Data.Entity.Core.Query.InternalTrees.PhysicalProjectOp)node.Op;
				int num2 = 0;
				foreach (global::System.Data.Entity.Core.Query.InternalTrees.Var key in physicalProjectOp.Outputs)
				{
					global::System.Collections.Generic.KeyValuePair<int, int> value = new global::System.Collections.Generic.KeyValuePair<int, int>(num, num2);
					dictionary[key] = value;
					num2++;
				}
				num++;
			}
			return dictionary;
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x06002712 RID: 10002 RVA: 0x0007050C File Offset: 0x0006E70C
		private global::System.Data.Entity.Core.Query.InternalTrees.Command Command
		{
			get
			{
				return this.m_compilerState.Command;
			}
		}

		// Token: 0x04000DA1 RID: 3489
		private readonly global::System.Data.Entity.Core.Query.PlanCompiler.PlanCompiler m_compilerState;

		// Token: 0x04000DA2 RID: 3490
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.Query.InternalTrees.Node> m_subCommands;
	}
}
