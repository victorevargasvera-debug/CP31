using System;

namespace NLog
{
	// Token: 0x02000017 RID: 23
	[global::System.AttributeUsage(global::System.AttributeTargets.Constructor | global::System.AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
	public sealed class MessageTemplateFormatMethodAttribute : global::System.Attribute
	{
		// Token: 0x06000433 RID: 1075 RVA: 0x00008510 File Offset: 0x00006710
		public MessageTemplateFormatMethodAttribute(string parameterName)
		{
			this.ParameterName = parameterName;
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x0000851F File Offset: 0x0000671F
		public string ParameterName { get; }
	}
}
