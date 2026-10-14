using System;
using System.IO;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020005F5 RID: 1525
	[global::System.Obsolete("Use 'Asn1OutputStream' instead")]
	public class BerOutputStream : global::Org.BouncyCastle.Asn1.DerOutputStream
	{
		// Token: 0x06003903 RID: 14595 RVA: 0x0010B30E File Offset: 0x0010950E
		[global::System.Obsolete("Use 'Asn1OutputStream.Create' instead")]
		public BerOutputStream(global::System.IO.Stream os) : base(os)
		{
		}

		// Token: 0x06003904 RID: 14596 RVA: 0x0010B317 File Offset: 0x00109517
		public override void WriteObject(global::Org.BouncyCastle.Asn1.Asn1Encodable encodable)
		{
			global::Org.BouncyCastle.Asn1.Asn1OutputStream.Create(this.s).WriteObject(encodable);
		}

		// Token: 0x06003905 RID: 14597 RVA: 0x0010B32A File Offset: 0x0010952A
		public override void WriteObject(global::Org.BouncyCastle.Asn1.Asn1Object primitive)
		{
			global::Org.BouncyCastle.Asn1.Asn1OutputStream.Create(this.s).WriteObject(primitive);
		}
	}
}
