using System;

namespace JetBrains.Annotations
{
	// Token: 0x02000193 RID: 403
	[global::System.AttributeUsage(global::System.AttributeTargets.Constructor | global::System.AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
	internal sealed class StringFormatMethodAttribute : global::System.Attribute
	{
		// Token: 0x0600114F RID: 4431 RVA: 0x0002DEA0 File Offset: 0x0002C0A0
		public StringFormatMethodAttribute(string formatParameterName)
		{
			this.FormatParameterName = formatParameterName;
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06001150 RID: 4432 RVA: 0x0002DEAF File Offset: 0x0002C0AF
		// (set) Token: 0x06001151 RID: 4433 RVA: 0x0002DEB7 File Offset: 0x0002C0B7
		public string FormatParameterName { get; private set; }
	}
}
