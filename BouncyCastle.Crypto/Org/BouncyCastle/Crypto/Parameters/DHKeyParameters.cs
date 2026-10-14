using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Pkcs;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003CA RID: 970
	public class DHKeyParameters : global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter
	{
		// Token: 0x06002713 RID: 10003 RVA: 0x000AA29A File Offset: 0x000A849A
		protected DHKeyParameters(bool isPrivate, global::Org.BouncyCastle.Crypto.Parameters.DHParameters parameters) : this(isPrivate, parameters, global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.DhKeyAgreement)
		{
		}

		// Token: 0x06002714 RID: 10004 RVA: 0x000AA2A9 File Offset: 0x000A84A9
		protected DHKeyParameters(bool isPrivate, global::Org.BouncyCastle.Crypto.Parameters.DHParameters parameters, global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithmOid) : base(isPrivate)
		{
			this.parameters = parameters;
			this.algorithmOid = algorithmOid;
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06002715 RID: 10005 RVA: 0x000AA2C0 File Offset: 0x000A84C0
		public global::Org.BouncyCastle.Crypto.Parameters.DHParameters Parameters
		{
			get
			{
				return this.parameters;
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06002716 RID: 10006 RVA: 0x000AA2C8 File Offset: 0x000A84C8
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier AlgorithmOid
		{
			get
			{
				return this.algorithmOid;
			}
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x000AA2D0 File Offset: 0x000A84D0
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			global::Org.BouncyCastle.Crypto.Parameters.DHKeyParameters other = obj as global::Org.BouncyCastle.Crypto.Parameters.DHKeyParameters;
			return other != null && this.Equals(other);
		}

		// Token: 0x06002718 RID: 10008 RVA: 0x000AA2F6 File Offset: 0x000A84F6
		protected bool Equals(global::Org.BouncyCastle.Crypto.Parameters.DHKeyParameters other)
		{
			return object.Equals(this.parameters, other.parameters) && base.Equals(other);
		}

		// Token: 0x06002719 RID: 10009 RVA: 0x000AA314 File Offset: 0x000A8514
		public override int GetHashCode()
		{
			int hc = base.GetHashCode();
			if (this.parameters != null)
			{
				hc ^= this.parameters.GetHashCode();
			}
			return hc;
		}

		// Token: 0x04000FDD RID: 4061
		private readonly global::Org.BouncyCastle.Crypto.Parameters.DHParameters parameters;

		// Token: 0x04000FDE RID: 4062
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithmOid;
	}
}
