using System;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020005E4 RID: 1508
	[global::System.Serializable]
	public class Asn1ParsingException : global::System.InvalidOperationException
	{
		// Token: 0x06003893 RID: 14483 RVA: 0x00109F82 File Offset: 0x00108182
		public Asn1ParsingException()
		{
		}

		// Token: 0x06003894 RID: 14484 RVA: 0x00109F8A File Offset: 0x0010818A
		public Asn1ParsingException(string message) : base(message)
		{
		}

		// Token: 0x06003895 RID: 14485 RVA: 0x00109F93 File Offset: 0x00108193
		public Asn1ParsingException(string message, global::System.Exception exception) : base(message, exception)
		{
		}
	}
}
