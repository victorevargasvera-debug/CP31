using System;

namespace JetBrains.Annotations
{
	// Token: 0x0200019E RID: 414
	[global::JetBrains.Annotations.MeansImplicitUse]
	internal sealed class PublicAPIAttribute : global::System.Attribute
	{
		// Token: 0x06001175 RID: 4469 RVA: 0x0002E02F File Offset: 0x0002C22F
		public PublicAPIAttribute()
		{
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x0002E037 File Offset: 0x0002C237
		public PublicAPIAttribute([global::JetBrains.Annotations.NotNull] string comment)
		{
			this.Comment = comment;
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06001177 RID: 4471 RVA: 0x0002E046 File Offset: 0x0002C246
		// (set) Token: 0x06001178 RID: 4472 RVA: 0x0002E04E File Offset: 0x0002C24E
		[global::JetBrains.Annotations.NotNull]
		public string Comment { get; private set; }
	}
}
