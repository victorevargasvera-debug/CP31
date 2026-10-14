using System;
using System.IO;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020005FA RID: 1530
	public class BerSetGenerator : global::Org.BouncyCastle.Asn1.BerGenerator
	{
		// Token: 0x0600391D RID: 14621 RVA: 0x0010B499 File Offset: 0x00109699
		public BerSetGenerator(global::System.IO.Stream outStream) : base(outStream)
		{
			base.WriteBerHeader(49);
		}

		// Token: 0x0600391E RID: 14622 RVA: 0x0010B4AA File Offset: 0x001096AA
		public BerSetGenerator(global::System.IO.Stream outStream, int tagNo, bool isExplicit) : base(outStream, tagNo, isExplicit)
		{
			base.WriteBerHeader(49);
		}
	}
}
