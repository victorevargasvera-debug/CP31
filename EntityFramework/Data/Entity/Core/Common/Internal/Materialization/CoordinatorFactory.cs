using System;
using System.Collections.ObjectModel;

namespace System.Data.Entity.Core.Common.Internal.Materialization
{
	// Token: 0x02000638 RID: 1592
	internal abstract class CoordinatorFactory
	{
		// Token: 0x06004CB8 RID: 19640 RVA: 0x0010E120 File Offset: 0x0010C320
		protected CoordinatorFactory(int depth, int stateSlot, global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, bool> hasData, global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, bool> setKeys, global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, bool> checkKeys, global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory[] nestedCoordinators, global::System.Data.Entity.Core.Common.Internal.Materialization.RecordStateFactory[] recordStateFactories)
		{
			this.Depth = depth;
			this.StateSlot = stateSlot;
			this.IsLeafResult = (nestedCoordinators.Length == 0);
			if (hasData == null)
			{
				this.HasData = global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory._alwaysTrue;
			}
			else
			{
				this.HasData = hasData;
			}
			if (setKeys == null)
			{
				this.SetKeys = global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory._alwaysTrue;
			}
			else
			{
				this.SetKeys = setKeys;
			}
			if (checkKeys == null)
			{
				if (this.IsLeafResult)
				{
					this.CheckKeys = global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory._alwaysFalse;
				}
				else
				{
					this.CheckKeys = global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory._alwaysTrue;
				}
			}
			else
			{
				this.CheckKeys = checkKeys;
			}
			this.NestedCoordinators = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory>(nestedCoordinators);
			this.RecordStateFactories = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordStateFactory>(recordStateFactories);
			this.IsSimple = (this.IsLeafResult && checkKeys == null && hasData == null);
		}

		// Token: 0x06004CB9 RID: 19641
		internal abstract global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator CreateCoordinator(global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator parent, global::System.Data.Entity.Core.Common.Internal.Materialization.Coordinator next);

		// Token: 0x04001B1F RID: 6943
		private static readonly global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, bool> _alwaysTrue = (global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper s) => true;

		// Token: 0x04001B20 RID: 6944
		private static readonly global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, bool> _alwaysFalse = (global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper s) => false;

		// Token: 0x04001B21 RID: 6945
		internal readonly int Depth;

		// Token: 0x04001B22 RID: 6946
		internal readonly int StateSlot;

		// Token: 0x04001B23 RID: 6947
		internal readonly global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, bool> HasData;

		// Token: 0x04001B24 RID: 6948
		internal readonly global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, bool> SetKeys;

		// Token: 0x04001B25 RID: 6949
		internal readonly global::System.Func<global::System.Data.Entity.Core.Common.Internal.Materialization.Shaper, bool> CheckKeys;

		// Token: 0x04001B26 RID: 6950
		internal readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.Internal.Materialization.CoordinatorFactory> NestedCoordinators;

		// Token: 0x04001B27 RID: 6951
		internal readonly bool IsLeafResult;

		// Token: 0x04001B28 RID: 6952
		internal readonly bool IsSimple;

		// Token: 0x04001B29 RID: 6953
		internal readonly global::System.Collections.ObjectModel.ReadOnlyCollection<global::System.Data.Entity.Core.Common.Internal.Materialization.RecordStateFactory> RecordStateFactories;
	}
}
