using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200064D RID: 1613
	public class CrlNumber : global::Org.BouncyCastle.Asn1.DerInteger
	{
		// Token: 0x06003BB9 RID: 15289 RVA: 0x0011250A File Offset: 0x0011070A
		public CrlNumber(global::Org.BouncyCastle.Math.BigInteger number) : base(number)
		{
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06003BBA RID: 15290 RVA: 0x00112513 File Offset: 0x00110713
		public global::Org.BouncyCastle.Math.BigInteger Number
		{
			get
			{
				return base.PositiveValue;
			}
		}

		// Token: 0x06003BBB RID: 15291 RVA: 0x0011251B File Offset: 0x0011071B
		public override string ToString()
		{
			string str = "CRLNumber: ";
			global::Org.BouncyCastle.Math.BigInteger number = this.Number;
			return str + ((number != null) ? number.ToString() : null);
		}
	}
}
