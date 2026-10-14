using System;

namespace NPOI.WP.UserModel
{
	// Token: 0x02000009 RID: 9
	public interface ICharacterRun
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002B RID: 43
		// (set) Token: 0x0600002C RID: 44
		bool IsBold { get; set; }

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600002D RID: 45
		// (set) Token: 0x0600002E RID: 46
		bool IsItalic { get; set; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600002F RID: 47
		// (set) Token: 0x06000030 RID: 48
		bool IsSmallCaps { get; set; }

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000031 RID: 49
		// (set) Token: 0x06000032 RID: 50
		bool IsCapitalized { get; set; }

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000033 RID: 51
		// (set) Token: 0x06000034 RID: 52
		bool IsStrikeThrough { get; set; }

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000035 RID: 53
		// (set) Token: 0x06000036 RID: 54
		bool IsDoubleStrikeThrough { get; set; }

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000037 RID: 55
		// (set) Token: 0x06000038 RID: 56
		bool IsShadowed { get; set; }

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000039 RID: 57
		// (set) Token: 0x0600003A RID: 58
		bool IsEmbossed { get; set; }

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003B RID: 59
		// (set) Token: 0x0600003C RID: 60
		bool IsImprinted { get; set; }

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600003D RID: 61
		// (set) Token: 0x0600003E RID: 62
		double FontSize { get; set; }

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600003F RID: 63
		// (set) Token: 0x06000040 RID: 64
		int CharacterSpacing { get; set; }

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000041 RID: 65
		// (set) Token: 0x06000042 RID: 66
		int Kerning { get; set; }

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000043 RID: 67
		bool IsHighlighted { get; }

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000044 RID: 68
		string FontName { get; }

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000045 RID: 69
		string Text { get; }
	}
}
