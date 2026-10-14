using System;
using NLog.Config;

namespace NLog.Conditions
{
	// Token: 0x0200017D RID: 381
	[global::System.AttributeUsage(global::System.AttributeTargets.Method, AllowMultiple = true)]
	public sealed class ConditionMethodAttribute : global::NLog.Config.NameBaseAttribute
	{
		// Token: 0x06001067 RID: 4199 RVA: 0x0002B3F4 File Offset: 0x000295F4
		public ConditionMethodAttribute(string name) : base(name)
		{
		}
	}
}
