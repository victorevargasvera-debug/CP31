using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x0200077E RID: 1918
	public class PkiConfirmContent : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06004444 RID: 17476 RVA: 0x00130768 File Offset: 0x0012E968
		public static global::Org.BouncyCastle.Asn1.Cmp.PkiConfirmContent GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cmp.PkiConfirmContent)
			{
				return (global::Org.BouncyCastle.Asn1.Cmp.PkiConfirmContent)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Null)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.PkiConfirmContent();
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06004446 RID: 17478 RVA: 0x001307A9 File Offset: 0x0012E9A9
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return global::Org.BouncyCastle.Asn1.DerNull.Instance;
		}
	}
}
