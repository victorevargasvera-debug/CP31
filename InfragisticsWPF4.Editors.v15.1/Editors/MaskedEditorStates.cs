using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000A3 RID: 163
	[global::System.Flags]
	public enum MaskedEditorStates : long
	{
		// Token: 0x04000340 RID: 832
		Character = 1L,
		// Token: 0x04000341 RID: 833
		FirstCharacter = 2L,
		// Token: 0x04000342 RID: 834
		LastCharacter = 4L,
		// Token: 0x04000343 RID: 835
		FirstSection = 8L,
		// Token: 0x04000344 RID: 836
		LastSection = 16L,
		// Token: 0x04000345 RID: 837
		FirstCharacterInSection = 32L,
		// Token: 0x04000346 RID: 838
		LastCharacterInSection = 64L,
		// Token: 0x04000347 RID: 839
		AfterLastCharacter = 256L,
		// Token: 0x04000348 RID: 840
		Selected = 512L,
		// Token: 0x04000349 RID: 841
		Uninitialized = 1024L,
		// Token: 0x0400034A RID: 842
		FirstEditSection = 2048L,
		// Token: 0x0400034B RID: 843
		LastEditSection = 4096L,
		// Token: 0x0400034C RID: 844
		NotInEditMode = 8192L,
		// Token: 0x0400034D RID: 845
		TabBySections = 16384L,
		// Token: 0x0400034E RID: 846
		NextSectionFraction = 32768L,
		// Token: 0x0400034F RID: 847
		CanSpinDown = 65536L,
		// Token: 0x04000350 RID: 848
		CanSpinUp = 131072L,
		// Token: 0x04000351 RID: 849
		CanUndo = 262144L,
		// Token: 0x04000352 RID: 850
		CanRedo = 524288L,
		// Token: 0x04000353 RID: 851
		HasDropDown = 1048576L,
		// Token: 0x04000354 RID: 852
		IsDropDownOpen = 2097152L,
		// Token: 0x04000355 RID: 853
		All = 4294967295L
	}
}
