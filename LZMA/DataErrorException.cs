using System;
using SevenZip.Compression.LZMA;

namespace SevenZip
{
	// Token: 0x02000004 RID: 4
	[global::System.Serializable]
	internal class DataErrorException : global::System.ApplicationException
	{
		// Token: 0x0600000C RID: 12 RVA: 0x0000289C File Offset: 0x00000A9C
		public DataErrorException()
		{
			int a_ = 3;
			base..ctor(global::SevenZip.Compression.LZMA.Decoder.b("堛缝吟䌡У挥娧堩䌫尭", a_));
		}
	}
}
