using System;

namespace System.Data.Entity.Core.Common.Internal.Materialization
{
	// Token: 0x02000637 RID: 1591
	internal abstract class Coordinator
	{
		// Token: 0x17000ED7 RID: 3799
		// (get) Token: 0x06004CAD RID: 19629 RVA: 0x0010E00A File Offset: 0x0010C20A
		// (set) Token: 0x06004CAE RID: 19630 RVA: 0x0010E012 File Offset: 0x0010C212
		public global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator Child { get; protected set; }

		// Token: 0x17000ED8 RID: 3800
		// (get) Token: 0x06004CAF RID: 19631 RVA: 0x0010E01B File Offset: 0x0010C21B
		// (set) Token: 0x06004CB0 RID: 19632 RVA: 0x0010E023 File Offset: 0x0010C223
		public bool IsEntered { get; protected set; }

		// Token: 0x17000ED9 RID: 3801
		// (get) Token: 0x06004CB1 RID: 19633 RVA: 0x0010E02C File Offset: 0x0010C22C
		internal bool IsRoot
		{
			get
			{
				return this.Parent == null;
			}
		}

		// Token: 0x06004CB2 RID: 19634 RVA: 0x0010E037 File Offset: 0x0010C237
		protected Coordinator(global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory coordinatorFactory, global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator parent, global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator next)
		{
			this.CoordinatorFactory = coordinatorFactory;
			this.Parent = parent;
			this.Next = next;
		}

		// Token: 0x06004CB3 RID: 19635 RVA: 0x0010E054 File Offset: 0x0010C254
		internal void Initialize(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper shaper)
		{
			this.ResetCollection(shaper);
			shaper.State[this.CoordinatorFactory.StateSlot] = this;
			if (this.Child != null)
			{
				this.Child.Initialize(shaper);
			}
			if (this.Next != null)
			{
				this.Next.Initialize(shaper);
			}
		}

		// Token: 0x06004CB4 RID: 19636 RVA: 0x0010E0A4 File Offset: 0x0010C2A4
		internal int MaxDistanceToLeaf()
		{
			int num = 0;
			for (global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator coordinator = this.Child; coordinator != null; coordinator = coordinator.Next)
			{
				num = global::System.Math.Max(num, coordinator.MaxDistanceToLeaf() + 1);
			}
			return num;
		}

		// Token: 0x06004CB5 RID: 19637
		internal abstract void ResetCollection(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper shaper);

		// Token: 0x06004CB6 RID: 19638 RVA: 0x0010E0D8 File Offset: 0x0010C2D8
		internal bool HasNextElement(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper shaper)
		{
			bool result = false;
			if (!this.IsEntered || !this.CoordinatorFactory.CheckKeys(shaper))
			{
				this.CoordinatorFactory.SetKeys(shaper);
				this.IsEntered = true;
				result = true;
			}
			return result;
		}

		// Token: 0x06004CB7 RID: 19639
		internal abstract void ReadNextElement(global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper shaper);

		// Token: 0x04001B1A RID: 6938
		internal readonly global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory CoordinatorFactory;

		// Token: 0x04001B1B RID: 6939
		internal readonly global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator Parent;

		// Token: 0x04001B1D RID: 6941
		internal readonly global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator Next;
	}
}
