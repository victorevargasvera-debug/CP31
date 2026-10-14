using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x0200009C RID: 156
	[global::System.Flags]
	public enum MaskedEditorStates : long
	{
		// Token: 0x0400030A RID: 778
		Character = 1L,
		// Token: 0x0400030B RID: 779
		FirstCharacter = 2L,
		// Token: 0x0400030C RID: 780
		LastCharacter = 4L,
		// Token: 0x0400030D RID: 781
		FirstSection = 8L,
		// Token: 0x0400030E RID: 782
		LastSection = 16L,
		// Token: 0x0400030F RID: 783
		FirstCharacterInSection = 32L,
		// Token: 0x04000310 RID: 784
		LastCharacterInSection = 64L,
		// Token: 0x04000311 RID: 785
		AfterLastCharacter = 256L,
		// Token: 0x04000312 RID: 786
		Selected = 512L,
		// Token: 0x04000313 RID: 787
		Uninitialized = 1024L,
		// Token: 0x04000314 RID: 788
		FirstEditSection = 2048L,
		// Token: 0x04000315 RID: 789
		LastEditSection = 4096L,
		// Token: 0x04000316 RID: 790
		NotInEditMode = 8192L,
		// Token: 0x04000317 RID: 791
		TabBySections = 16384L,
		// Token: 0x04000318 RID: 792
		NextSectionFraction = 32768L,
		// Token: 0x04000319 RID: 793
		CanSpinDown = 65536L,
		// Token: 0x0400031A RID: 794
		CanSpinUp = 131072L,
		// Token: 0x0400031B RID: 795
		CanUndo = 262144L,
		// Token: 0x0400031C RID: 796
		CanRedo = 524288L,
		// Token: 0x0400031D RID: 797
		HasDropDown = 1048576L,
		// Token: 0x0400031E RID: 798
		IsDropDownOpen = 2097152L,
		// Token: 0x0400031F RID: 799
		All = 4294967295L
	}
}
