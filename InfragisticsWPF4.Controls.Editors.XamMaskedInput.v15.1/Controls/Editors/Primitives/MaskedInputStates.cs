using System;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x02000008 RID: 8
	[global::System.Flags]
	public enum MaskedInputStates : long
	{
		// Token: 0x0400002A RID: 42
		Character = 1L,
		// Token: 0x0400002B RID: 43
		FirstCharacter = 2L,
		// Token: 0x0400002C RID: 44
		LastCharacter = 4L,
		// Token: 0x0400002D RID: 45
		FirstSection = 8L,
		// Token: 0x0400002E RID: 46
		LastSection = 16L,
		// Token: 0x0400002F RID: 47
		FirstCharacterInSection = 32L,
		// Token: 0x04000030 RID: 48
		LastCharacterInSection = 64L,
		// Token: 0x04000031 RID: 49
		AfterLastCharacter = 256L,
		// Token: 0x04000032 RID: 50
		Selected = 512L,
		// Token: 0x04000033 RID: 51
		Uninitialized = 1024L,
		// Token: 0x04000034 RID: 52
		FirstEditSection = 2048L,
		// Token: 0x04000035 RID: 53
		LastEditSection = 4096L,
		// Token: 0x04000036 RID: 54
		NotInEditMode = 8192L,
		// Token: 0x04000037 RID: 55
		TabBySections = 16384L,
		// Token: 0x04000038 RID: 56
		NextSectionFraction = 32768L,
		// Token: 0x04000039 RID: 57
		CanSpinDown = 65536L,
		// Token: 0x0400003A RID: 58
		CanSpinUp = 131072L,
		// Token: 0x0400003B RID: 59
		CanUndo = 262144L,
		// Token: 0x0400003C RID: 60
		CanRedo = 524288L,
		// Token: 0x0400003D RID: 61
		HasDropDown = 1048576L,
		// Token: 0x0400003E RID: 62
		IsDropDownOpen = 2097152L,
		// Token: 0x0400003F RID: 63
		IsReadOnly = 4194304L,
		// Token: 0x04000040 RID: 64
		All = 4294967295L
	}
}
