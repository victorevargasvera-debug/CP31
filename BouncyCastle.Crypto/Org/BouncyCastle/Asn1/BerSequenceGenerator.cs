using System;
using System.IO;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020005F7 RID: 1527
	public class BerSequenceGenerator : global::Org.BouncyCastle.Asn1.BerGenerator
	{
		// Token: 0x0600390E RID: 14606 RVA: 0x0010B3B1 File Offset: 0x001095B1
		public BerSequenceGenerator(global::System.IO.Stream outStream) : base(outStream)
		{
			base.WriteBerHeader(48);
		}

		// Token: 0x0600390F RID: 14607 RVA: 0x0010B3C2 File Offset: 0x001095C2
		public BerSequenceGenerator(global::System.IO.Stream outStream, int tagNo, bool isExplicit) : base(outStream, tagNo, isExplicit)
		{
			base.WriteBerHeader(48);
		}
	}
}
