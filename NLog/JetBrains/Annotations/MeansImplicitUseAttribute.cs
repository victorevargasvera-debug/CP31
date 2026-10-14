using System;

namespace JetBrains.Annotations
{
	// Token: 0x0200019B RID: 411
	[global::System.AttributeUsage(global::System.AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
	internal sealed class MeansImplicitUseAttribute : global::System.Attribute
	{
		// Token: 0x0600116D RID: 4461 RVA: 0x0002DFD9 File Offset: 0x0002C1D9
		public MeansImplicitUseAttribute() : this(global::JetBrains.Annotations.ImplicitUseKindFlags.Default, global::JetBrains.Annotations.ImplicitUseTargetFlags.Default)
		{
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x0002DFE3 File Offset: 0x0002C1E3
		public MeansImplicitUseAttribute(global::JetBrains.Annotations.ImplicitUseKindFlags useKindFlags) : this(useKindFlags, global::JetBrains.Annotations.ImplicitUseTargetFlags.Default)
		{
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x0002DFED File Offset: 0x0002C1ED
		public MeansImplicitUseAttribute(global::JetBrains.Annotations.ImplicitUseTargetFlags targetFlags) : this(global::JetBrains.Annotations.ImplicitUseKindFlags.Default, targetFlags)
		{
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x0002DFF7 File Offset: 0x0002C1F7
		public MeansImplicitUseAttribute(global::JetBrains.Annotations.ImplicitUseKindFlags useKindFlags, global::JetBrains.Annotations.ImplicitUseTargetFlags targetFlags)
		{
			this.UseKindFlags = useKindFlags;
			this.TargetFlags = targetFlags;
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06001171 RID: 4465 RVA: 0x0002E00D File Offset: 0x0002C20D
		// (set) Token: 0x06001172 RID: 4466 RVA: 0x0002E015 File Offset: 0x0002C215
		[global::JetBrains.Annotations.UsedImplicitly]
		public global::JetBrains.Annotations.ImplicitUseKindFlags UseKindFlags { get; private set; }

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06001173 RID: 4467 RVA: 0x0002E01E File Offset: 0x0002C21E
		// (set) Token: 0x06001174 RID: 4468 RVA: 0x0002E026 File Offset: 0x0002C226
		[global::JetBrains.Annotations.UsedImplicitly]
		public global::JetBrains.Annotations.ImplicitUseTargetFlags TargetFlags { get; private set; }
	}
}
