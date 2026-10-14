using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x0200020E RID: 526
	public abstract class AbstractF2mFieldElement : global::Org.BouncyCastle.Math.EC.ECFieldElement
	{
		// Token: 0x060014EA RID: 5354 RVA: 0x00062018 File Offset: 0x00060218
		public virtual global::Org.BouncyCastle.Math.EC.ECFieldElement HalfTrace()
		{
			int fieldSize = this.FieldSize;
			if ((fieldSize & 1) == 0)
			{
				throw new global::System.InvalidOperationException("Half-trace only defined for odd m");
			}
			int i = fieldSize + 1 >> 1;
			int j = 31 - global::Org.BouncyCastle.Utilities.Integers.NumberOfLeadingZeros(i);
			int nk = 1;
			global::Org.BouncyCastle.Math.EC.ECFieldElement ht = this;
			while (j > 0)
			{
				ht = ht.SquarePow(nk << 1).Add(ht);
				nk = i >> (--j & 31);
				if ((nk & 1) != 0)
				{
					ht = ht.SquarePow(2).Add(this);
				}
			}
			return ht;
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x060014EB RID: 5355 RVA: 0x00062083 File Offset: 0x00060283
		public virtual bool HasFastTrace
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060014EC RID: 5356 RVA: 0x00062088 File Offset: 0x00060288
		public virtual int Trace()
		{
			int i = this.FieldSize;
			int j = 31 - global::Org.BouncyCastle.Utilities.Integers.NumberOfLeadingZeros(i);
			int mk = 1;
			global::Org.BouncyCastle.Math.EC.ECFieldElement tr = this;
			while (j > 0)
			{
				tr = tr.SquarePow(mk).Add(tr);
				mk = i >> (--j & 31);
				if ((mk & 1) != 0)
				{
					tr = tr.Square().Add(this);
				}
			}
			if (tr.IsZero)
			{
				return 0;
			}
			if (tr.IsOne)
			{
				return 1;
			}
			throw new global::System.InvalidOperationException("Internal error in trace calculation");
		}
	}
}
