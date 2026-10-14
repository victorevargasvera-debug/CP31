using System;

namespace JetBrains.Annotations
{
	// Token: 0x020001AF RID: 431
	[global::System.AttributeUsage(global::System.AttributeTargets.Property | global::System.AttributeTargets.Field | global::System.AttributeTargets.Parameter, Inherited = true)]
	internal sealed class HtmlAttributeValueAttribute : global::System.Attribute
	{
		// Token: 0x06001198 RID: 4504 RVA: 0x0002E177 File Offset: 0x0002C377
		public HtmlAttributeValueAttribute([global::JetBrains.Annotations.NotNull] string name)
		{
			this.Name = name;
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06001199 RID: 4505 RVA: 0x0002E186 File Offset: 0x0002C386
		// (set) Token: 0x0600119A RID: 4506 RVA: 0x0002E18E File Offset: 0x0002C38E
		[global::JetBrains.Annotations.NotNull]
		public string Name { get; private set; }
	}
}
