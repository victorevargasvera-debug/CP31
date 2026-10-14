using System;

namespace Org.BouncyCastle.Math.Field
{
	// Token: 0x02000203 RID: 515
	internal class PrimeField : global::Org.BouncyCastle.Math.Field.IFiniteField
	{
		// Token: 0x06001431 RID: 5169 RVA: 0x0005F699 File Offset: 0x0005D899
		internal PrimeField(global::Org.BouncyCastle.Math.BigInteger characteristic)
		{
			this.characteristic = characteristic;
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06001432 RID: 5170 RVA: 0x0005F6A8 File Offset: 0x0005D8A8
		public virtual global::Org.BouncyCastle.Math.BigInteger Characteristic
		{
			get
			{
				return this.characteristic;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06001433 RID: 5171 RVA: 0x0005F6B0 File Offset: 0x0005D8B0
		public virtual int Dimension
		{
			get
			{
				return 1;
			}
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x0005F6B4 File Offset: 0x0005D8B4
		public override bool Equals(object obj)
		{
			if (this == obj)
			{
				return true;
			}
			global::Org.BouncyCastle.Math.Field.PrimeField other = obj as global::Org.BouncyCastle.Math.Field.PrimeField;
			return other != null && this.characteristic.Equals(other.characteristic);
		}

		// Token: 0x06001435 RID: 5173 RVA: 0x0005F6E4 File Offset: 0x0005D8E4
		public override int GetHashCode()
		{
			return this.characteristic.GetHashCode();
		}

		// Token: 0x0400093A RID: 2362
		protected readonly global::Org.BouncyCastle.Math.BigInteger characteristic;
	}
}
