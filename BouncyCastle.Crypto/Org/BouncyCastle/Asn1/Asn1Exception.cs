using System;
using System.IO;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020005DC RID: 1500
	[global::System.Serializable]
	public class Asn1Exception : global::System.IO.IOException
	{
		// Token: 0x06003846 RID: 14406 RVA: 0x001091F9 File Offset: 0x001073F9
		public Asn1Exception()
		{
		}

		// Token: 0x06003847 RID: 14407 RVA: 0x00109201 File Offset: 0x00107401
		public Asn1Exception(string message) : base(message)
		{
		}

		// Token: 0x06003848 RID: 14408 RVA: 0x0010920A File Offset: 0x0010740A
		public Asn1Exception(string message, global::System.Exception exception) : base(message, exception)
		{
		}
	}
}
