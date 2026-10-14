using System;

namespace NLog.Targets
{
	// Token: 0x02000028 RID: 40
	[global::NLog.Targets.Target("Chainsaw")]
	public class ChainsawTarget : global::NLog.Targets.NLogViewerTarget
	{
		// Token: 0x060004A8 RID: 1192 RVA: 0x00009791 File Offset: 0x00007991
		public ChainsawTarget()
		{
			base.IncludeNLogData = false;
			base.OptimizeBufferReuse = (base.GetType() == typeof(global::NLog.Targets.ChainsawTarget));
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x000097BB File Offset: 0x000079BB
		public ChainsawTarget(string name) : this()
		{
			base.Name = name;
		}
	}
}
