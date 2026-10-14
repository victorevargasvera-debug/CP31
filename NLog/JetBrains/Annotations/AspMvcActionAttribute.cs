using System;

namespace JetBrains.Annotations
{
	// Token: 0x020001A2 RID: 418
	[global::System.AttributeUsage(global::System.AttributeTargets.Method | global::System.AttributeTargets.Parameter)]
	internal sealed class AspMvcActionAttribute : global::System.Attribute
	{
		// Token: 0x0600117F RID: 4479 RVA: 0x0002E08F File Offset: 0x0002C28F
		public AspMvcActionAttribute()
		{
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x0002E097 File Offset: 0x0002C297
		public AspMvcActionAttribute([global::JetBrains.Annotations.NotNull] string anonymousProperty)
		{
			this.AnonymousProperty = anonymousProperty;
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06001181 RID: 4481 RVA: 0x0002E0A6 File Offset: 0x0002C2A6
		// (set) Token: 0x06001182 RID: 4482 RVA: 0x0002E0AE File Offset: 0x0002C2AE
		[global::JetBrains.Annotations.NotNull]
		public string AnonymousProperty { get; private set; }
	}
}
