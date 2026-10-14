using System;

namespace Gibraltar.Data
{
	// Token: 0x020000EB RID: 235
	internal class LogicNode<D> : global::Gibraltar.Data.LogicNode, global::Gibraltar.Data.ILogicNode<D>
	{
		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x060009BC RID: 2492 RVA: 0x00017648 File Offset: 0x00015848
		// (set) Token: 0x060009BD RID: 2493 RVA: 0x00017650 File Offset: 0x00015850
		public global::Gibraltar.Data.ILogicNode<D> NextOnTrue
		{
			get
			{
				return this.m_NextOnTrue;
			}
			set
			{
				this.m_NextOnTrue = value;
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x060009BE RID: 2494 RVA: 0x0001765C File Offset: 0x0001585C
		// (set) Token: 0x060009BF RID: 2495 RVA: 0x00017664 File Offset: 0x00015864
		public global::Gibraltar.Data.ILogicNode<D> NextOnFalse
		{
			get
			{
				return this.m_NextOnFalse;
			}
			set
			{
				this.m_NextOnFalse = value;
			}
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x00017670 File Offset: 0x00015870
		public LogicNode(bool result)
		{
			this.m_Result = result;
			this.m_NextOnTrue = null;
			this.m_NextOnFalse = null;
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x00017690 File Offset: 0x00015890
		public LogicNode(global::Gibraltar.Data.LogicNode<D> original)
		{
			this.m_Result = original.m_Result;
			this.m_NextOnTrue = null;
			this.m_NextOnFalse = null;
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x000176B4 File Offset: 0x000158B4
		public global::Gibraltar.Data.ILogicNode<D> Clone()
		{
			return new global::Gibraltar.Data.LogicNode<D>(this);
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x000176BC File Offset: 0x000158BC
		public bool EvaluateNode(D dataset)
		{
			return this.m_Result;
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x000176C4 File Offset: 0x000158C4
		public override string ToString()
		{
			return this.m_Result.ToString();
		}

		// Token: 0x04000257 RID: 599
		private readonly bool m_Result;

		// Token: 0x04000258 RID: 600
		private global::Gibraltar.Data.ILogicNode<D> m_NextOnTrue;

		// Token: 0x04000259 RID: 601
		private global::Gibraltar.Data.ILogicNode<D> m_NextOnFalse;
	}
}
