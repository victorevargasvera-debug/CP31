using System;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003E4 RID: 996
	public class ElGamalKeyParameters : global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter
	{
		// Token: 0x060027CD RID: 10189 RVA: 0x000ABB10 File Offset: 0x000A9D10
		protected ElGamalKeyParameters(bool isPrivate, global::Org.BouncyCastle.Crypto.Parameters.ElGamalParameters parameters) : base(isPrivate)
		{
			this.parameters = parameters;
		}

		// Token: 0x1700055B RID: 1371
		// (get) Token: 0x060027CE RID: 10190 RVA: 0x000ABB20 File Offset: 0x000A9D20
		public global::Org.BouncyCastle.Crypto.Parameters.ElGamalParameters Parameters
		{
			get
			{
				return this.parameters;
			}
		}

		// Token: 0x060027CF RID: 10191 RVA: 0x000ABB28 File Offset: 0x000A9D28
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			global::Org.BouncyCastle.Crypto.Parameters.ElGamalKeyParameters other = obj as global::Org.BouncyCastle.Crypto.Parameters.ElGamalKeyParameters;
			return other != null && this.Equals(other);
		}

		// Token: 0x060027D0 RID: 10192 RVA: 0x000ABB4E File Offset: 0x000A9D4E
		protected bool Equals(global::Org.BouncyCastle.Crypto.Parameters.ElGamalKeyParameters other)
		{
			return object.Equals(this.parameters, other.parameters) && base.Equals(other);
		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x000ABB6C File Offset: 0x000A9D6C
		public override int GetHashCode()
		{
			int hc = base.GetHashCode();
			if (this.parameters != null)
			{
				hc ^= this.parameters.GetHashCode();
			}
			return hc;
		}

		// Token: 0x0400101C RID: 4124
		private readonly global::Org.BouncyCastle.Crypto.Parameters.ElGamalParameters parameters;
	}
}
