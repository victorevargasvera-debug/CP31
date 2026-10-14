using System;
using NLog.Common;

namespace NLog.Targets.Wrappers
{
	// Token: 0x0200006A RID: 106
	[global::NLog.Targets.Target("RandomizeGroup", IsCompound = true)]
	public class RandomizeGroupTarget : global::NLog.Targets.Wrappers.CompoundTargetBase
	{
		// Token: 0x06000840 RID: 2112 RVA: 0x00014FB5 File Offset: 0x000131B5
		public RandomizeGroupTarget() : this(new global::NLog.Targets.Target[0])
		{
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00014FC3 File Offset: 0x000131C3
		public RandomizeGroupTarget(string name, params global::NLog.Targets.Target[] targets) : this(targets)
		{
			base.Name = name;
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x00014FD3 File Offset: 0x000131D3
		public RandomizeGroupTarget(params global::NLog.Targets.Target[] targets) : base(targets)
		{
			base.OptimizeBufferReuse = (base.GetType() == typeof(global::NLog.Targets.Wrappers.RandomizeGroupTarget));
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00015004 File Offset: 0x00013204
		protected override void Write(global::NLog.Common.AsyncLogEventInfo logEvent)
		{
			if (base.Targets.Count == 0)
			{
				logEvent.Continuation(null);
				return;
			}
			global::System.Random random = this._random;
			int index;
			lock (random)
			{
				index = this._random.Next(base.Targets.Count);
			}
			base.Targets[index].WriteAsyncLogEvent(logEvent);
		}

		// Token: 0x040001E2 RID: 482
		private readonly global::System.Random _random = new global::System.Random();
	}
}
