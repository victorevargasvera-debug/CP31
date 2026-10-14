using System;

namespace JetBrains.Annotations
{
	// Token: 0x02000199 RID: 409
	[global::System.AttributeUsage(global::System.AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
	[global::JetBrains.Annotations.BaseTypeRequired(typeof(global::System.Attribute))]
	internal sealed class BaseTypeRequiredAttribute : global::System.Attribute
	{
		// Token: 0x06001162 RID: 4450 RVA: 0x0002DF63 File Offset: 0x0002C163
		public BaseTypeRequiredAttribute([global::JetBrains.Annotations.NotNull] global::System.Type baseType)
		{
			this.BaseType = baseType;
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06001163 RID: 4451 RVA: 0x0002DF72 File Offset: 0x0002C172
		// (set) Token: 0x06001164 RID: 4452 RVA: 0x0002DF7A File Offset: 0x0002C17A
		[global::JetBrains.Annotations.NotNull]
		public global::System.Type BaseType { get; private set; }
	}
}
