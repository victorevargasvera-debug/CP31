using System;
using System.Collections.Generic;
using System.Globalization;
using NLog.Common;
using NLog.Config;
using NLog.Internal;

namespace NLog.Targets
{
	// Token: 0x02000046 RID: 70
	public abstract class MethodCallTargetBase : global::NLog.Targets.Target
	{
		// Token: 0x060006A8 RID: 1704 RVA: 0x00010638 File Offset: 0x0000E838
		protected MethodCallTargetBase()
		{
			this.Parameters = new global::System.Collections.Generic.List<global::NLog.Targets.MethodCallParameter>();
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x0001064B File Offset: 0x0000E84B
		// (set) Token: 0x060006AA RID: 1706 RVA: 0x00010653 File Offset: 0x0000E853
		[global::NLog.Config.ArrayParameter(typeof(global::NLog.Targets.MethodCallParameter), "parameter")]
		public global::System.Collections.Generic.IList<global::NLog.Targets.MethodCallParameter> Parameters { get; private set; }

		// Token: 0x060006AB RID: 1707 RVA: 0x0001065C File Offset: 0x0000E85C
		protected override void Write(global::NLog.Common.AsyncLogEventInfo logEvent)
		{
			object[] array = (this.Parameters.Count > 0) ? new object[this.Parameters.Count] : global::NLog.Internal.ArrayHelper.Empty<object>();
			for (int i = 0; i < array.Length; i++)
			{
				global::NLog.Targets.MethodCallParameter methodCallParameter = this.Parameters[i];
				string value = base.RenderLogEvent(methodCallParameter.Layout, logEvent.LogEvent);
				array[i] = global::System.Convert.ChangeType(value, methodCallParameter.ParameterType, global::System.Globalization.CultureInfo.InvariantCulture);
			}
			this.DoInvoke(array, logEvent);
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x000106DA File Offset: 0x0000E8DA
		protected virtual void DoInvoke(object[] parameters, global::NLog.Common.AsyncLogEventInfo logEvent)
		{
			this.DoInvoke(parameters, logEvent.Continuation);
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x000106EC File Offset: 0x0000E8EC
		protected virtual void DoInvoke(object[] parameters, global::NLog.Common.AsyncContinuation continuation)
		{
			try
			{
				this.DoInvoke(parameters);
				continuation(null);
			}
			catch (global::System.Exception exception)
			{
				if (exception.MustBeRethrown())
				{
					throw;
				}
				continuation(exception);
			}
		}

		// Token: 0x060006AE RID: 1710
		protected abstract void DoInvoke(object[] parameters);
	}
}
