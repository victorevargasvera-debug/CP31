using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cmp;

namespace Org.BouncyCastle.Cmp
{
	// Token: 0x02000562 RID: 1378
	public class GeneralPkiMessage
	{
		// Token: 0x060034AF RID: 13487 RVA: 0x000FB9F1 File Offset: 0x000F9BF1
		private static global::Org.BouncyCastle.Asn1.Cmp.PkiMessage ParseBytes(byte[] encoding)
		{
			return global::Org.BouncyCastle.Asn1.Cmp.PkiMessage.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(encoding));
		}

		// Token: 0x060034B0 RID: 13488 RVA: 0x000FB9FE File Offset: 0x000F9BFE
		public GeneralPkiMessage(global::Org.BouncyCastle.Asn1.Cmp.PkiMessage pkiMessage)
		{
			this.pkiMessage = pkiMessage;
		}

		// Token: 0x060034B1 RID: 13489 RVA: 0x000FBA0D File Offset: 0x000F9C0D
		public GeneralPkiMessage(byte[] encoding) : this(global::Org.BouncyCastle.Cmp.GeneralPkiMessage.ParseBytes(encoding))
		{
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x060034B2 RID: 13490 RVA: 0x000FBA1B File Offset: 0x000F9C1B
		public global::Org.BouncyCastle.Asn1.Cmp.PkiHeader Header
		{
			get
			{
				return this.pkiMessage.Header;
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x060034B3 RID: 13491 RVA: 0x000FBA28 File Offset: 0x000F9C28
		public global::Org.BouncyCastle.Asn1.Cmp.PkiBody Body
		{
			get
			{
				return this.pkiMessage.Body;
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x060034B4 RID: 13492 RVA: 0x000FBA35 File Offset: 0x000F9C35
		public bool HasProtection
		{
			get
			{
				return this.pkiMessage.Protection != null;
			}
		}

		// Token: 0x060034B5 RID: 13493 RVA: 0x000FBA45 File Offset: 0x000F9C45
		public global::Org.BouncyCastle.Asn1.Cmp.PkiMessage ToAsn1Structure()
		{
			return this.pkiMessage;
		}

		// Token: 0x04001791 RID: 6033
		private readonly global::Org.BouncyCastle.Asn1.Cmp.PkiMessage pkiMessage;
	}
}
