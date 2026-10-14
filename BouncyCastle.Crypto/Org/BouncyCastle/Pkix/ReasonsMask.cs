using System;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Pkix
{
	// Token: 0x020001A5 RID: 421
	internal class ReasonsMask
	{
		// Token: 0x06000FDB RID: 4059 RVA: 0x0003CB88 File Offset: 0x0003AD88
		internal ReasonsMask(int reasons)
		{
			this._reasons = reasons;
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x0003CB97 File Offset: 0x0003AD97
		internal ReasonsMask() : this(0)
		{
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x0003CBA0 File Offset: 0x0003ADA0
		internal void AddReasons(global::Org.BouncyCastle.Pkix.ReasonsMask mask)
		{
			this._reasons |= mask.Reasons.IntValue;
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x0003CBBA File Offset: 0x0003ADBA
		internal bool IsAllReasons
		{
			get
			{
				return this._reasons == global::Org.BouncyCastle.Pkix.ReasonsMask.AllReasons._reasons;
			}
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x0003CBCE File Offset: 0x0003ADCE
		internal global::Org.BouncyCastle.Pkix.ReasonsMask Intersect(global::Org.BouncyCastle.Pkix.ReasonsMask mask)
		{
			global::Org.BouncyCastle.Pkix.ReasonsMask reasonsMask = new global::Org.BouncyCastle.Pkix.ReasonsMask();
			reasonsMask.AddReasons(new global::Org.BouncyCastle.Pkix.ReasonsMask(this._reasons & mask.Reasons.IntValue));
			return reasonsMask;
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x0003CBF2 File Offset: 0x0003ADF2
		internal bool HasNewReasons(global::Org.BouncyCastle.Pkix.ReasonsMask mask)
		{
			return (this._reasons | (mask.Reasons.IntValue ^ this._reasons)) != 0;
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000FE1 RID: 4065 RVA: 0x0003CC10 File Offset: 0x0003AE10
		public global::Org.BouncyCastle.Asn1.X509.ReasonFlags Reasons
		{
			get
			{
				return new global::Org.BouncyCastle.Asn1.X509.ReasonFlags(this._reasons);
			}
		}

		// Token: 0x0400088D RID: 2189
		private int _reasons;

		// Token: 0x0400088E RID: 2190
		internal static readonly global::Org.BouncyCastle.Pkix.ReasonsMask AllReasons = new global::Org.BouncyCastle.Pkix.ReasonsMask(33023);
	}
}
