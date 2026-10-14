using System;

namespace JetBrains.Annotations
{
	// Token: 0x02000197 RID: 407
	[global::System.AttributeUsage(global::System.AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	internal sealed class LocalizationRequiredAttribute : global::System.Attribute
	{
		// Token: 0x0600115D RID: 4445 RVA: 0x0002DF32 File Offset: 0x0002C132
		public LocalizationRequiredAttribute() : this(true)
		{
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x0002DF3B File Offset: 0x0002C13B
		public LocalizationRequiredAttribute(bool required)
		{
			this.Required = required;
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x0600115F RID: 4447 RVA: 0x0002DF4A File Offset: 0x0002C14A
		// (set) Token: 0x06001160 RID: 4448 RVA: 0x0002DF52 File Offset: 0x0002C152
		public bool Required { get; private set; }
	}
}
