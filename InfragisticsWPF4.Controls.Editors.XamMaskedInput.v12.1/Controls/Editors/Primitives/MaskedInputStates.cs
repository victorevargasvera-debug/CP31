using System;

namespace Infragistics.Controls.Editors.Primitives
{
	// Token: 0x02000009 RID: 9
	[global::System.Flags]
	public enum MaskedInputStates : long
	{
		// Token: 0x04000029 RID: 41
		Character = 1L,
		// Token: 0x0400002A RID: 42
		FirstCharacter = 2L,
		// Token: 0x0400002B RID: 43
		LastCharacter = 4L,
		// Token: 0x0400002C RID: 44
		FirstSection = 8L,
		// Token: 0x0400002D RID: 45
		LastSection = 16L,
		// Token: 0x0400002E RID: 46
		FirstCharacterInSection = 32L,
		// Token: 0x0400002F RID: 47
		LastCharacterInSection = 64L,
		// Token: 0x04000030 RID: 48
		AfterLastCharacter = 256L,
		// Token: 0x04000031 RID: 49
		Selected = 512L,
		// Token: 0x04000032 RID: 50
		Uninitialized = 1024L,
		// Token: 0x04000033 RID: 51
		FirstEditSection = 2048L,
		// Token: 0x04000034 RID: 52
		LastEditSection = 4096L,
		// Token: 0x04000035 RID: 53
		NotInEditMode = 8192L,
		// Token: 0x04000036 RID: 54
		TabBySections = 16384L,
		// Token: 0x04000037 RID: 55
		NextSectionFraction = 32768L,
		// Token: 0x04000038 RID: 56
		CanSpinDown = 65536L,
		// Token: 0x04000039 RID: 57
		CanSpinUp = 131072L,
		// Token: 0x0400003A RID: 58
		CanUndo = 262144L,
		// Token: 0x0400003B RID: 59
		CanRedo = 524288L,
		// Token: 0x0400003C RID: 60
		HasDropDown = 1048576L,
		// Token: 0x0400003D RID: 61
		IsDropDownOpen = 2097152L,
		// Token: 0x0400003E RID: 62
		All = 4294967295L
	}
}
