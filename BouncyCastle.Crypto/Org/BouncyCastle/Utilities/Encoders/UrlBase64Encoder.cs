using System;

namespace Org.BouncyCastle.Utilities.Encoders
{
	// Token: 0x02000068 RID: 104
	public class UrlBase64Encoder : global::Org.BouncyCastle.Utilities.Encoders.Base64Encoder
	{
		// Token: 0x0600043A RID: 1082 RVA: 0x00015B16 File Offset: 0x00013D16
		public UrlBase64Encoder()
		{
			this.encodingTable[this.encodingTable.Length - 2] = 45;
			this.encodingTable[this.encodingTable.Length - 1] = 95;
			this.padding = 46;
			base.InitialiseDecodingTable();
		}
	}
}
