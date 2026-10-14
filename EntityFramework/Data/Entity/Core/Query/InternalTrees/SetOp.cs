using System;

namespace System.Data.Entity.Core.Query.InternalTrees
{
	// Token: 0x020003E2 RID: 994
	internal abstract class SetOp : global::System.Data.Entity.Core.Query.InternalTrees.RelOp
	{
		// Token: 0x06002F00 RID: 12032 RVA: 0x000944DE File Offset: 0x000926DE
		internal SetOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType opType, global::System.Data.Entity.Core.Query.InternalTrees.VarVec outputs, global::System.Data.Entity.Core.Query.InternalTrees.VarMap left, global::System.Data.Entity.Core.Query.InternalTrees.VarMap right) : this(opType)
		{
			this.m_varMap = new global::System.Data.Entity.Core.Query.InternalTrees.VarMap[2];
			this.m_varMap[0] = left;
			this.m_varMap[1] = right;
			this.m_outputVars = outputs;
		}

		// Token: 0x06002F01 RID: 12033 RVA: 0x0009450D File Offset: 0x0009270D
		protected SetOp(global::System.Data.Entity.Core.Query.InternalTrees.OpType opType) : base(opType)
		{
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x06002F02 RID: 12034 RVA: 0x00094516 File Offset: 0x00092716
		internal override int Arity
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x06002F03 RID: 12035 RVA: 0x00094519 File Offset: 0x00092719
		internal global::System.Data.Entity.Core.Query.InternalTrees.VarMap[] VarMap
		{
			get
			{
				return this.m_varMap;
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x06002F04 RID: 12036 RVA: 0x00094521 File Offset: 0x00092721
		internal global::System.Data.Entity.Core.Query.InternalTrees.VarVec Outputs
		{
			get
			{
				return this.m_outputVars;
			}
		}

		// Token: 0x04000FD8 RID: 4056
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.VarMap[] m_varMap;

		// Token: 0x04000FD9 RID: 4057
		private readonly global::System.Data.Entity.Core.Query.InternalTrees.VarVec m_outputVars;
	}
}
