using System;

namespace JetBrains.Annotations
{
	// Token: 0x0200019A RID: 410
	[global::System.AttributeUsage(global::System.AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	internal sealed class UsedImplicitlyAttribute : global::System.Attribute
	{
		// Token: 0x06001165 RID: 4453 RVA: 0x0002DF83 File Offset: 0x0002C183
		public UsedImplicitlyAttribute() : this(global::JetBrains.Annotations.ImplicitUseKindFlags.Default, global::JetBrains.Annotations.ImplicitUseTargetFlags.Default)
		{
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x0002DF8D File Offset: 0x0002C18D
		public UsedImplicitlyAttribute(global::JetBrains.Annotations.ImplicitUseKindFlags useKindFlags) : this(useKindFlags, global::JetBrains.Annotations.ImplicitUseTargetFlags.Default)
		{
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x0002DF97 File Offset: 0x0002C197
		public UsedImplicitlyAttribute(global::JetBrains.Annotations.ImplicitUseTargetFlags targetFlags) : this(global::JetBrains.Annotations.ImplicitUseKindFlags.Default, targetFlags)
		{
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x0002DFA1 File Offset: 0x0002C1A1
		public UsedImplicitlyAttribute(global::JetBrains.Annotations.ImplicitUseKindFlags useKindFlags, global::JetBrains.Annotations.ImplicitUseTargetFlags targetFlags)
		{
			this.UseKindFlags = useKindFlags;
			this.TargetFlags = targetFlags;
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06001169 RID: 4457 RVA: 0x0002DFB7 File Offset: 0x0002C1B7
		// (set) Token: 0x0600116A RID: 4458 RVA: 0x0002DFBF File Offset: 0x0002C1BF
		public global::JetBrains.Annotations.ImplicitUseKindFlags UseKindFlags { get; private set; }

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x0600116B RID: 4459 RVA: 0x0002DFC8 File Offset: 0x0002C1C8
		// (set) Token: 0x0600116C RID: 4460 RVA: 0x0002DFD0 File Offset: 0x0002C1D0
		public global::JetBrains.Annotations.ImplicitUseTargetFlags TargetFlags { get; private set; }
	}
}
