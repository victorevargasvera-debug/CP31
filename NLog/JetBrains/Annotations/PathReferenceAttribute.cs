using System;

namespace JetBrains.Annotations
{
	// Token: 0x020001A1 RID: 417
	[global::System.AttributeUsage(global::System.AttributeTargets.Parameter)]
	internal class PathReferenceAttribute : global::System.Attribute
	{
		// Token: 0x0600117B RID: 4475 RVA: 0x0002E067 File Offset: 0x0002C267
		public PathReferenceAttribute()
		{
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x0002E06F File Offset: 0x0002C26F
		public PathReferenceAttribute([global::JetBrains.Annotations.PathReference] string basePath)
		{
			this.BasePath = basePath;
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x0600117D RID: 4477 RVA: 0x0002E07E File Offset: 0x0002C27E
		// (set) Token: 0x0600117E RID: 4478 RVA: 0x0002E086 File Offset: 0x0002C286
		[global::JetBrains.Annotations.NotNull]
		public string BasePath { get; private set; }
	}
}
