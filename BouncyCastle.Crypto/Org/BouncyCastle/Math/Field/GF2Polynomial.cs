using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.Field
{
	// Token: 0x020001FE RID: 510
	internal class GF2Polynomial : global::Org.BouncyCastle.Math.Field.IPolynomial
	{
		// Token: 0x06001425 RID: 5157 RVA: 0x0005F625 File Offset: 0x0005D825
		internal GF2Polynomial(int[] exponents)
		{
			this.exponents = global::Org.BouncyCastle.Utilities.Arrays.Clone(exponents);
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06001426 RID: 5158 RVA: 0x0005F639 File Offset: 0x0005D839
		public virtual int Degree
		{
			get
			{
				return this.exponents[this.exponents.Length - 1];
			}
		}

		// Token: 0x06001427 RID: 5159 RVA: 0x0005F64C File Offset: 0x0005D84C
		public virtual int[] GetExponentsPresent()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.exponents);
		}

		// Token: 0x06001428 RID: 5160 RVA: 0x0005F65C File Offset: 0x0005D85C
		public override bool Equals(object obj)
		{
			if (this == obj)
			{
				return true;
			}
			global::Org.BouncyCastle.Math.Field.GF2Polynomial other = obj as global::Org.BouncyCastle.Math.Field.GF2Polynomial;
			return other != null && global::Org.BouncyCastle.Utilities.Arrays.AreEqual(this.exponents, other.exponents);
		}

		// Token: 0x06001429 RID: 5161 RVA: 0x0005F68C File Offset: 0x0005D88C
		public override int GetHashCode()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.exponents);
		}

		// Token: 0x04000939 RID: 2361
		protected readonly int[] exponents;
	}
}
