using System;
using SevenZip.Compression.LZMA;

namespace SevenZip
{
	// Token: 0x02000005 RID: 5
	[global::System.Serializable]
	internal class InvalidParamException : global::System.ApplicationException
	{
		// Token: 0x0600000D RID: 13 RVA: 0x000028C8 File Offset: 0x00000AC8
		public InvalidParamException()
		{
			int a_ = 19;
			base..ctor(global::SevenZip.Compression.LZMA.Decoder.b("攫䀭䘯匱堳張尷ᨹ氻弽㈿⍁⥃⍅㱇⽉㹋", a_));
		}
	}
}
