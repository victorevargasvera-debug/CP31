using System;

namespace JetBrains.Annotations
{
	// Token: 0x020001A4 RID: 420
	[global::System.AttributeUsage(global::System.AttributeTargets.Method | global::System.AttributeTargets.Parameter)]
	internal sealed class AspMvcControllerAttribute : global::System.Attribute
	{
		// Token: 0x06001187 RID: 4487 RVA: 0x0002E0DF File Offset: 0x0002C2DF
		public AspMvcControllerAttribute()
		{
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x0002E0E7 File Offset: 0x0002C2E7
		public AspMvcControllerAttribute([global::JetBrains.Annotations.NotNull] string anonymousProperty)
		{
			this.AnonymousProperty = anonymousProperty;
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06001189 RID: 4489 RVA: 0x0002E0F6 File Offset: 0x0002C2F6
		// (set) Token: 0x0600118A RID: 4490 RVA: 0x0002E0FE File Offset: 0x0002C2FE
		[global::JetBrains.Annotations.NotNull]
		public string AnonymousProperty { get; private set; }
	}
}
