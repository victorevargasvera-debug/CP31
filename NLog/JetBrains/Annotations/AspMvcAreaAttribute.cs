using System;

namespace JetBrains.Annotations
{
	// Token: 0x020001A3 RID: 419
	[global::System.AttributeUsage(global::System.AttributeTargets.Parameter)]
	internal sealed class AspMvcAreaAttribute : global::JetBrains.Annotations.PathReferenceAttribute
	{
		// Token: 0x06001183 RID: 4483 RVA: 0x0002E0B7 File Offset: 0x0002C2B7
		public AspMvcAreaAttribute()
		{
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x0002E0BF File Offset: 0x0002C2BF
		public AspMvcAreaAttribute([global::JetBrains.Annotations.NotNull] string anonymousProperty)
		{
			this.AnonymousProperty = anonymousProperty;
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06001185 RID: 4485 RVA: 0x0002E0CE File Offset: 0x0002C2CE
		// (set) Token: 0x06001186 RID: 4486 RVA: 0x0002E0D6 File Offset: 0x0002C2D6
		[global::JetBrains.Annotations.NotNull]
		public string AnonymousProperty { get; private set; }
	}
}
