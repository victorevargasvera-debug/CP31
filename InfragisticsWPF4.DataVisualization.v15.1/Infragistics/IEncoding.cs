using System;

namespace Infragistics
{
	// Token: 0x0200002E RID: 46
	public interface IEncoding
	{
		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002C6 RID: 710
		char FallbackCharacter { get; }

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060002C7 RID: 711
		int CodePage { get; }

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060002C8 RID: 712
		string Name { get; }

		// Token: 0x060002C9 RID: 713
		int GetChars(byte[] bytes, int byteIndex, int byteCount, char[] chars, int charIndex);

		// Token: 0x060002CA RID: 714
		int GetMaxByteCount(int charCount);

		// Token: 0x060002CB RID: 715
		int GetMaxCharCount(int byteCount);

		// Token: 0x060002CC RID: 716
		int GetCharCount(byte[] bytes, int index, int count);

		// Token: 0x060002CD RID: 717
		int GetByteCount(char[] chars, int index, int count);

		// Token: 0x060002CE RID: 718
		int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex);
	}
}
