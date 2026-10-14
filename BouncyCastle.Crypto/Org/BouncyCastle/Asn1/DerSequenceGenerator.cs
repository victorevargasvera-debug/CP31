using System;
using System.IO;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x02000616 RID: 1558
	public class DerSequenceGenerator : global::Org.BouncyCastle.Asn1.DerGenerator
	{
		// Token: 0x06003A36 RID: 14902 RVA: 0x0010E670 File Offset: 0x0010C870
		public DerSequenceGenerator(global::System.IO.Stream outStream) : base(outStream)
		{
		}

		// Token: 0x06003A37 RID: 14903 RVA: 0x0010E684 File Offset: 0x0010C884
		public DerSequenceGenerator(global::System.IO.Stream outStream, int tagNo, bool isExplicit) : base(outStream, tagNo, isExplicit)
		{
		}

		// Token: 0x06003A38 RID: 14904 RVA: 0x0010E69A File Offset: 0x0010C89A
		public override void AddObject(global::Org.BouncyCastle.Asn1.Asn1Encodable obj)
		{
			obj.EncodeTo(this._bOut, "DER");
		}

		// Token: 0x06003A39 RID: 14905 RVA: 0x0010E6AD File Offset: 0x0010C8AD
		public override void AddObject(global::Org.BouncyCastle.Asn1.Asn1Object obj)
		{
			obj.EncodeTo(this._bOut, "DER");
		}

		// Token: 0x06003A3A RID: 14906 RVA: 0x0010E6C0 File Offset: 0x0010C8C0
		public override global::System.IO.Stream GetRawOutputStream()
		{
			return this._bOut;
		}

		// Token: 0x06003A3B RID: 14907 RVA: 0x0010E6C8 File Offset: 0x0010C8C8
		public override void Close()
		{
			base.WriteDerEncoded(48, this._bOut.ToArray());
		}

		// Token: 0x040019A7 RID: 6567
		private readonly global::System.IO.MemoryStream _bOut = new global::System.IO.MemoryStream();
	}
}
