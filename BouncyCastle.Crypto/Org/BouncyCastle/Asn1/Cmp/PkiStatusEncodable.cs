using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x02000786 RID: 1926
	public class PkiStatusEncodable : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x0600448A RID: 17546 RVA: 0x001310ED File Offset: 0x0012F2ED
		private PkiStatusEncodable(global::Org.BouncyCastle.Asn1.Cmp.PkiStatus status) : this(new global::Org.BouncyCastle.Asn1.DerInteger((int)status))
		{
		}

		// Token: 0x0600448B RID: 17547 RVA: 0x001310FB File Offset: 0x0012F2FB
		private PkiStatusEncodable(global::Org.BouncyCastle.Asn1.DerInteger status)
		{
			this.status = status;
		}

		// Token: 0x0600448C RID: 17548 RVA: 0x0013110A File Offset: 0x0012F30A
		public static global::Org.BouncyCastle.Asn1.Cmp.PkiStatusEncodable GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cmp.PkiStatusEncodable)
			{
				return (global::Org.BouncyCastle.Asn1.Cmp.PkiStatusEncodable)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.DerInteger)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.PkiStatusEncodable((global::Org.BouncyCastle.Asn1.DerInteger)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x0600448D RID: 17549 RVA: 0x00131149 File Offset: 0x0012F349
		public virtual global::Org.BouncyCastle.Math.BigInteger Value
		{
			get
			{
				return this.status.Value;
			}
		}

		// Token: 0x0600448E RID: 17550 RVA: 0x00131156 File Offset: 0x0012F356
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return this.status;
		}

		// Token: 0x0400213D RID: 8509
		public static readonly global::Org.BouncyCastle.Asn1.Cmp.PkiStatusEncodable granted = new global::Org.BouncyCastle.Asn1.Cmp.PkiStatusEncodable(global::Org.BouncyCastle.Asn1.Cmp.PkiStatus.Granted);

		// Token: 0x0400213E RID: 8510
		public static readonly global::Org.BouncyCastle.Asn1.Cmp.PkiStatusEncodable grantedWithMods = new global::Org.BouncyCastle.Asn1.Cmp.PkiStatusEncodable(global::Org.BouncyCastle.Asn1.Cmp.PkiStatus.GrantedWithMods);

		// Token: 0x0400213F RID: 8511
		public static readonly global::Org.BouncyCastle.Asn1.Cmp.PkiStatusEncodable rejection = new global::Org.BouncyCastle.Asn1.Cmp.PkiStatusEncodable(global::Org.BouncyCastle.Asn1.Cmp.PkiStatus.Rejection);

		// Token: 0x04002140 RID: 8512
		public static readonly global::Org.BouncyCastle.Asn1.Cmp.PkiStatusEncodable waiting = new global::Org.BouncyCastle.Asn1.Cmp.PkiStatusEncodable(global::Org.BouncyCastle.Asn1.Cmp.PkiStatus.Waiting);

		// Token: 0x04002141 RID: 8513
		public static readonly global::Org.BouncyCastle.Asn1.Cmp.PkiStatusEncodable revocationWarning = new global::Org.BouncyCastle.Asn1.Cmp.PkiStatusEncodable(global::Org.BouncyCastle.Asn1.Cmp.PkiStatus.RevocationWarning);

		// Token: 0x04002142 RID: 8514
		public static readonly global::Org.BouncyCastle.Asn1.Cmp.PkiStatusEncodable revocationNotification = new global::Org.BouncyCastle.Asn1.Cmp.PkiStatusEncodable(global::Org.BouncyCastle.Asn1.Cmp.PkiStatus.RevocationNotification);

		// Token: 0x04002143 RID: 8515
		public static readonly global::Org.BouncyCastle.Asn1.Cmp.PkiStatusEncodable keyUpdateWaiting = new global::Org.BouncyCastle.Asn1.Cmp.PkiStatusEncodable(global::Org.BouncyCastle.Asn1.Cmp.PkiStatus.KeyUpdateWarning);

		// Token: 0x04002144 RID: 8516
		private readonly global::Org.BouncyCastle.Asn1.DerInteger status;
	}
}
