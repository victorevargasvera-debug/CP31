using System;
using System.Collections.Generic;
using System.Text;
using NLog.Common;

namespace NLog.Targets.Wrappers
{
	// Token: 0x02000062 RID: 98
	public abstract class CompoundTargetBase : global::NLog.Targets.Target
	{
		// Token: 0x060007F4 RID: 2036 RVA: 0x000145BC File Offset: 0x000127BC
		protected CompoundTargetBase(params global::NLog.Targets.Target[] targets)
		{
			this.Targets = new global::System.Collections.Generic.List<global::NLog.Targets.Target>(targets);
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x000145D0 File Offset: 0x000127D0
		// (set) Token: 0x060007F6 RID: 2038 RVA: 0x000145D8 File Offset: 0x000127D8
		public global::System.Collections.Generic.IList<global::NLog.Targets.Target> Targets { get; private set; }

		// Token: 0x060007F7 RID: 2039 RVA: 0x000145E4 File Offset: 0x000127E4
		public override string ToString()
		{
			string value = string.Empty;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(base.ToString());
			stringBuilder.Append("(");
			foreach (global::NLog.Targets.Target target in this.Targets)
			{
				stringBuilder.Append(value);
				stringBuilder.Append(target.ToString());
				value = ", ";
			}
			stringBuilder.Append(")");
			return stringBuilder.ToString();
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x0001467C File Offset: 0x0001287C
		protected override void Write(global::NLog.LogEventInfo logEvent)
		{
			throw new global::System.NotSupportedException("This target must not be invoked in a synchronous way.");
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x00014688 File Offset: 0x00012888
		protected override void FlushAsync(global::NLog.Common.AsyncContinuation asyncContinuation)
		{
			global::NLog.Common.AsyncHelpers.ForEachItemInParallel<global::NLog.Targets.Target>(this.Targets, asyncContinuation, delegate(global::NLog.Targets.Target t, global::NLog.Common.AsyncContinuation c)
			{
				t.Flush(c);
			});
		}
	}
}
