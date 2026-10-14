using System;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003D0 RID: 976
	public abstract class DsaKeyParameters : global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter
	{
		// Token: 0x06002741 RID: 10049 RVA: 0x000AA924 File Offset: 0x000A8B24
		protected DsaKeyParameters(bool isPrivate, global::Org.BouncyCastle.Crypto.Parameters.DsaParameters parameters) : base(isPrivate)
		{
			this.parameters = parameters;
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06002742 RID: 10050 RVA: 0x000AA934 File Offset: 0x000A8B34
		public global::Org.BouncyCastle.Crypto.Parameters.DsaParameters Parameters
		{
			get
			{
				return this.parameters;
			}
		}

		// Token: 0x06002743 RID: 10051 RVA: 0x000AA93C File Offset: 0x000A8B3C
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			global::Org.BouncyCastle.Crypto.Parameters.DsaKeyParameters other = obj as global::Org.BouncyCastle.Crypto.Parameters.DsaKeyParameters;
			return other != null && this.Equals(other);
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x000AA962 File Offset: 0x000A8B62
		protected bool Equals(global::Org.BouncyCastle.Crypto.Parameters.DsaKeyParameters other)
		{
			return object.Equals(this.parameters, other.parameters) && base.Equals(other);
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x000AA980 File Offset: 0x000A8B80
		public override int GetHashCode()
		{
			int hc = base.GetHashCode();
			if (this.parameters != null)
			{
				hc ^= this.parameters.GetHashCode();
			}
			return hc;
		}

		// Token: 0x04000FEC RID: 4076
		private readonly global::Org.BouncyCastle.Crypto.Parameters.DsaParameters parameters;
	}
}
