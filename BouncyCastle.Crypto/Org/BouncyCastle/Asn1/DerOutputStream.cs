using System;
using System.IO;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x02000612 RID: 1554
	[global::System.Obsolete("Use 'Asn1OutputStream' instead")]
	public class DerOutputStream : global::Org.BouncyCastle.Utilities.IO.FilterStream
	{
		// Token: 0x06003A1D RID: 14877 RVA: 0x0010E38C File Offset: 0x0010C58C
		[global::System.Obsolete("Use 'Asn1OutputStream.Create' instead")]
		public DerOutputStream(global::System.IO.Stream os) : base(os)
		{
		}

		// Token: 0x06003A1E RID: 14878 RVA: 0x0010E395 File Offset: 0x0010C595
		public virtual void WriteObject(global::Org.BouncyCastle.Asn1.Asn1Encodable encodable)
		{
			global::Org.BouncyCastle.Asn1.Asn1OutputStream.Create(this.s, "DER").WriteObject(encodable);
		}

		// Token: 0x06003A1F RID: 14879 RVA: 0x0010E3AD File Offset: 0x0010C5AD
		public virtual void WriteObject(global::Org.BouncyCastle.Asn1.Asn1Object primitive)
		{
			global::Org.BouncyCastle.Asn1.Asn1OutputStream.Create(this.s, "DER").WriteObject(primitive);
		}
	}
}
