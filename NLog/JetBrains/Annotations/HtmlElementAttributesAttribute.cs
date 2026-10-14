using System;

namespace JetBrains.Annotations
{
	// Token: 0x020001AE RID: 430
	[global::System.AttributeUsage(global::System.AttributeTargets.Property | global::System.AttributeTargets.Field | global::System.AttributeTargets.Parameter, Inherited = true)]
	internal sealed class HtmlElementAttributesAttribute : global::System.Attribute
	{
		// Token: 0x06001194 RID: 4500 RVA: 0x0002E14F File Offset: 0x0002C34F
		public HtmlElementAttributesAttribute()
		{
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x0002E157 File Offset: 0x0002C357
		public HtmlElementAttributesAttribute([global::JetBrains.Annotations.NotNull] string name)
		{
			this.Name = name;
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06001196 RID: 4502 RVA: 0x0002E166 File Offset: 0x0002C366
		// (set) Token: 0x06001197 RID: 4503 RVA: 0x0002E16E File Offset: 0x0002C36E
		[global::JetBrains.Annotations.NotNull]
		public string Name { get; private set; }
	}
}
