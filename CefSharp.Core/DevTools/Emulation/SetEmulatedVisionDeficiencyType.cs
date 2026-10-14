using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Emulation
{
	// Token: 0x0200028F RID: 655
	public enum SetEmulatedVisionDeficiencyType
	{
		// Token: 0x04000AB2 RID: 2738
		[global::System.Runtime.Serialization.EnumMember(Value = "none")]
		None,
		// Token: 0x04000AB3 RID: 2739
		[global::System.Runtime.Serialization.EnumMember(Value = "blurredVision")]
		BlurredVision,
		// Token: 0x04000AB4 RID: 2740
		[global::System.Runtime.Serialization.EnumMember(Value = "reducedContrast")]
		ReducedContrast,
		// Token: 0x04000AB5 RID: 2741
		[global::System.Runtime.Serialization.EnumMember(Value = "achromatopsia")]
		Achromatopsia,
		// Token: 0x04000AB6 RID: 2742
		[global::System.Runtime.Serialization.EnumMember(Value = "deuteranopia")]
		Deuteranopia,
		// Token: 0x04000AB7 RID: 2743
		[global::System.Runtime.Serialization.EnumMember(Value = "protanopia")]
		Protanopia,
		// Token: 0x04000AB8 RID: 2744
		[global::System.Runtime.Serialization.EnumMember(Value = "tritanopia")]
		Tritanopia
	}
}
