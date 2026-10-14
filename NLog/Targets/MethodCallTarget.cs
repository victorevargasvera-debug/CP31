using System;
using NLog.Common;
using NLog.Internal;

namespace NLog.Targets
{
	// Token: 0x02000045 RID: 69
	[global::NLog.Targets.Target("MethodCall")]
	public sealed class MethodCallTarget : global::NLog.Targets.MethodCallTargetBase
	{
		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600069D RID: 1693 RVA: 0x000104A8 File Offset: 0x0000E6A8
		// (set) Token: 0x0600069E RID: 1694 RVA: 0x000104B0 File Offset: 0x0000E6B0
		public string ClassName { get; set; }

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600069F RID: 1695 RVA: 0x000104B9 File Offset: 0x0000E6B9
		// (set) Token: 0x060006A0 RID: 1696 RVA: 0x000104C1 File Offset: 0x0000E6C1
		public string MethodName { get; set; }

		// Token: 0x060006A1 RID: 1697 RVA: 0x000104CA File Offset: 0x0000E6CA
		public MethodCallTarget()
		{
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x000104D2 File Offset: 0x0000E6D2
		public MethodCallTarget(string name) : this(name, null)
		{
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x000104DC File Offset: 0x0000E6DC
		public MethodCallTarget(string name, global::System.Action<global::NLog.LogEventInfo, object[]> logEventAction) : this()
		{
			base.Name = name;
			this._logEventAction = logEventAction;
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x000104F4 File Offset: 0x0000E6F4
		protected override void InitializeTarget()
		{
			base.InitializeTarget();
			if (this.ClassName != null && this.MethodName != null)
			{
				global::System.Type type = global::System.Type.GetType(this.ClassName);
				if (type != null)
				{
					global::NLog.Targets.MethodCallTarget.<>c__DisplayClass12_0 CS$<>8__locals1 = new global::NLog.Targets.MethodCallTarget.<>c__DisplayClass12_0();
					CS$<>8__locals1.methodInfo = type.GetMethod(this.MethodName);
					if (CS$<>8__locals1.methodInfo == null)
					{
						global::NLog.Common.InternalLogger.Warn<string, string>("Initialize MethodCallTarget, method '{0}' in class '{1}' not found - it should be static", this.MethodName, this.ClassName);
						return;
					}
					int neededParameters = CS$<>8__locals1.methodInfo.GetParameters().Length;
					this._logEventAction = delegate(global::NLog.LogEventInfo logEvent, object[] parameters)
					{
						if (neededParameters - parameters.Length > 0)
						{
							object[] array = new object[neededParameters];
							for (int i = 0; i < parameters.Length; i++)
							{
								array[i] = parameters[i];
							}
							for (int j = parameters.Length; j < neededParameters; j++)
							{
								array[j] = global::System.Type.Missing;
							}
							parameters = array;
						}
						CS$<>8__locals1.methodInfo.Invoke(null, parameters);
					};
					return;
				}
				else
				{
					global::NLog.Common.InternalLogger.Warn<string>("Initialize MethodCallTarget, class '{0}' not found", this.ClassName);
				}
			}
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x000105B8 File Offset: 0x0000E7B8
		protected override void DoInvoke(object[] parameters, global::NLog.Common.AsyncLogEventInfo logEvent)
		{
			try
			{
				this.ExecuteLogMethod(parameters, logEvent.LogEvent);
				logEvent.Continuation(null);
			}
			catch (global::System.Exception exception)
			{
				if (exception.MustBeRethrown())
				{
					throw;
				}
				logEvent.Continuation(exception);
			}
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0001060C File Offset: 0x0000E80C
		protected override void DoInvoke(object[] parameters)
		{
			this.ExecuteLogMethod(parameters, null);
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x00010616 File Offset: 0x0000E816
		private void ExecuteLogMethod(object[] parameters, global::NLog.LogEventInfo logEvent)
		{
			if (this._logEventAction != null)
			{
				this._logEventAction(logEvent, parameters);
				return;
			}
			global::NLog.Common.InternalLogger.Trace("No invoke because class/method was not found or set");
		}

		// Token: 0x04000139 RID: 313
		private global::System.Action<global::NLog.LogEventInfo, object[]> _logEventAction;
	}
}
