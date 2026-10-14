using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002C1 RID: 705
	public interface IAlphabetMapper
	{
		// Token: 0x1700044B RID: 1099
		// (get) Token: 0x06001F62 RID: 8034
		int Radix { get; }

		// Token: 0x06001F63 RID: 8035
		byte[] ConvertToIndexes(char[] input);

		// Token: 0x06001F64 RID: 8036
		char[] ConvertToChars(byte[] input);
	}
}
