using System;
using System.IO;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x02000619 RID: 1561
	public class DerSetGenerator : global::Org.BouncyCastle.Asn1.DerGenerator
	{
		// Token: 0x06003A49 RID: 14921 RVA: 0x0010E7F8 File Offset: 0x0010C9F8
		public DerSetGenerator(global::System.IO.Stream outStream) : base(outStream)
		{
		}

		// Token: 0x06003A4A RID: 14922 RVA: 0x0010E80C File Offset: 0x0010CA0C
		public DerSetGenerator(global::System.IO.Stream outStream, int tagNo, bool isExplicit) : base(outStream, tagNo, isExplicit)
		{
		}

		// Token: 0x06003A4B RID: 14923 RVA: 0x0010E822 File Offset: 0x0010CA22
		public override void AddObject(global::Org.BouncyCastle.Asn1.Asn1Encodable obj)
		{
			obj.EncodeTo(this._bOut, "DER");
		}

		// Token: 0x06003A4C RID: 14924 RVA: 0x0010E835 File Offset: 0x0010CA35
		public override void AddObject(global::Org.BouncyCastle.Asn1.Asn1Object obj)
		{
			obj.EncodeTo(this._bOut, "DER");
		}

		// Token: 0x06003A4D RID: 14925 RVA: 0x0010E848 File Offset: 0x0010CA48
		public override global::System.IO.Stream GetRawOutputStream()
		{
			return this._bOut;
		}

		// Token: 0x06003A4E RID: 14926 RVA: 0x0010E850 File Offset: 0x0010CA50
		public override void Close()
		{
			base.WriteDerEncoded(49, this._bOut.ToArray());
		}

		// Token: 0x040019AA RID: 6570
		private readonly global::System.IO.MemoryStream _bOut = new global::System.IO.MemoryStream();
	}
}
