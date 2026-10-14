using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x0200020F RID: 527
	public class F2mFieldElement : global::Org.BouncyCastle.Math.EC.AbstractF2mFieldElement
	{
		// Token: 0x060014EE RID: 5358 RVA: 0x00062104 File Offset: 0x00060304
		[global::System.Obsolete("Use ECCurve.FromBigInteger to construct field elements")]
		public F2mFieldElement(int m, int k1, int k2, int k3, global::Org.BouncyCastle.Math.BigInteger x)
		{
			if (x == null || x.SignValue < 0 || x.BitLength > m)
			{
				throw new global::System.ArgumentException("value invalid in F2m field element", "x");
			}
			if (k2 == 0 && k3 == 0)
			{
				this.representation = 2;
				this.ks = new int[]
				{
					k1
				};
			}
			else
			{
				if (k2 >= k3)
				{
					throw new global::System.ArgumentException("k2 must be smaller than k3");
				}
				if (k2 <= 0)
				{
					throw new global::System.ArgumentException("k2 must be larger than 0");
				}
				this.representation = 3;
				this.ks = new int[]
				{
					k1,
					k2,
					k3
				};
			}
			this.m = m;
			this.x = new global::Org.BouncyCastle.Math.EC.LongArray(x);
		}

		// Token: 0x060014EF RID: 5359 RVA: 0x000621B2 File Offset: 0x000603B2
		[global::System.Obsolete("Use ECCurve.FromBigInteger to construct field elements")]
		public F2mFieldElement(int m, int k, global::Org.BouncyCastle.Math.BigInteger x) : this(m, k, 0, 0, x)
		{
		}

		// Token: 0x060014F0 RID: 5360 RVA: 0x000621BF File Offset: 0x000603BF
		internal F2mFieldElement(int m, int[] ks, global::Org.BouncyCastle.Math.EC.LongArray x)
		{
			this.m = m;
			this.representation = ((ks.Length == 1) ? 2 : 3);
			this.ks = ks;
			this.x = x;
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x060014F1 RID: 5361 RVA: 0x000621EC File Offset: 0x000603EC
		public override int BitLength
		{
			get
			{
				return this.x.Degree();
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x060014F2 RID: 5362 RVA: 0x000621F9 File Offset: 0x000603F9
		public override bool IsOne
		{
			get
			{
				return this.x.IsOne();
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x060014F3 RID: 5363 RVA: 0x00062206 File Offset: 0x00060406
		public override bool IsZero
		{
			get
			{
				return this.x.IsZero();
			}
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x00062213 File Offset: 0x00060413
		public override bool TestBitZero()
		{
			return this.x.TestBitZero();
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x00062220 File Offset: 0x00060420
		public override global::Org.BouncyCastle.Math.BigInteger ToBigInteger()
		{
			return this.x.ToBigInteger();
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x060014F6 RID: 5366 RVA: 0x0006222D File Offset: 0x0006042D
		public override string FieldName
		{
			get
			{
				return "F2m";
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x060014F7 RID: 5367 RVA: 0x00062234 File Offset: 0x00060434
		public override int FieldSize
		{
			get
			{
				return this.m;
			}
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x0006223C File Offset: 0x0006043C
		public static void CheckFieldElements(global::Org.BouncyCastle.Math.EC.ECFieldElement a, global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			if (!(a is global::Org.BouncyCastle.Math.EC.F2mFieldElement) || !(b is global::Org.BouncyCastle.Math.EC.F2mFieldElement))
			{
				throw new global::System.ArgumentException("Field elements are not both instances of F2mFieldElement");
			}
			global::Org.BouncyCastle.Math.EC.F2mFieldElement aF2m = (global::Org.BouncyCastle.Math.EC.F2mFieldElement)a;
			global::Org.BouncyCastle.Math.EC.F2mFieldElement bF2m = (global::Org.BouncyCastle.Math.EC.F2mFieldElement)b;
			if (aF2m.representation != bF2m.representation)
			{
				throw new global::System.ArgumentException("One of the F2m field elements has incorrect representation");
			}
			if (aF2m.m != bF2m.m || !global::Org.BouncyCastle.Utilities.Arrays.AreEqual(aF2m.ks, bF2m.ks))
			{
				throw new global::System.ArgumentException("Field elements are not elements of the same field F2m");
			}
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x000622B8 File Offset: 0x000604B8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Add(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			global::Org.BouncyCastle.Math.EC.LongArray iarrClone = this.x.Copy();
			global::Org.BouncyCastle.Math.EC.F2mFieldElement bF2m = (global::Org.BouncyCastle.Math.EC.F2mFieldElement)b;
			iarrClone.AddShiftedByWords(bF2m.x, 0);
			return new global::Org.BouncyCastle.Math.EC.F2mFieldElement(this.m, this.ks, iarrClone);
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x000622F7 File Offset: 0x000604F7
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement AddOne()
		{
			return new global::Org.BouncyCastle.Math.EC.F2mFieldElement(this.m, this.ks, this.x.AddOne());
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x00062315 File Offset: 0x00060515
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Subtract(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			return this.Add(b);
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x0006231E File Offset: 0x0006051E
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Multiply(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			return new global::Org.BouncyCastle.Math.EC.F2mFieldElement(this.m, this.ks, this.x.ModMultiply(((global::Org.BouncyCastle.Math.EC.F2mFieldElement)b).x, this.m, this.ks));
		}

		// Token: 0x060014FD RID: 5373 RVA: 0x00062353 File Offset: 0x00060553
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement MultiplyMinusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement b, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			return this.MultiplyPlusProduct(b, x, y);
		}

		// Token: 0x060014FE RID: 5374 RVA: 0x00062360 File Offset: 0x00060560
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement MultiplyPlusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement b, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			global::Org.BouncyCastle.Math.EC.LongArray ax = this.x;
			global::Org.BouncyCastle.Math.EC.LongArray bx = ((global::Org.BouncyCastle.Math.EC.F2mFieldElement)b).x;
			global::Org.BouncyCastle.Math.EC.LongArray longArray = ((global::Org.BouncyCastle.Math.EC.F2mFieldElement)x).x;
			global::Org.BouncyCastle.Math.EC.LongArray yx = ((global::Org.BouncyCastle.Math.EC.F2mFieldElement)y).x;
			global::Org.BouncyCastle.Math.EC.LongArray ab = ax.Multiply(bx, this.m, this.ks);
			global::Org.BouncyCastle.Math.EC.LongArray xy = longArray.Multiply(yx, this.m, this.ks);
			if (ab == ax || ab == bx)
			{
				ab = ab.Copy();
			}
			ab.AddShiftedByWords(xy, 0);
			ab.Reduce(this.m, this.ks);
			return new global::Org.BouncyCastle.Math.EC.F2mFieldElement(this.m, this.ks, ab);
		}

		// Token: 0x060014FF RID: 5375 RVA: 0x000623FC File Offset: 0x000605FC
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Divide(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			global::Org.BouncyCastle.Math.EC.ECFieldElement bInv = b.Invert();
			return this.Multiply(bInv);
		}

		// Token: 0x06001500 RID: 5376 RVA: 0x00062417 File Offset: 0x00060617
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Negate()
		{
			return this;
		}

		// Token: 0x06001501 RID: 5377 RVA: 0x0006241A File Offset: 0x0006061A
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Square()
		{
			return new global::Org.BouncyCastle.Math.EC.F2mFieldElement(this.m, this.ks, this.x.ModSquare(this.m, this.ks));
		}

		// Token: 0x06001502 RID: 5378 RVA: 0x00062444 File Offset: 0x00060644
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement SquareMinusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			return this.SquarePlusProduct(x, y);
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x00062450 File Offset: 0x00060650
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement SquarePlusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			global::Org.BouncyCastle.Math.EC.LongArray ax = this.x;
			global::Org.BouncyCastle.Math.EC.LongArray longArray = ((global::Org.BouncyCastle.Math.EC.F2mFieldElement)x).x;
			global::Org.BouncyCastle.Math.EC.LongArray yx = ((global::Org.BouncyCastle.Math.EC.F2mFieldElement)y).x;
			global::Org.BouncyCastle.Math.EC.LongArray aa = ax.Square(this.m, this.ks);
			global::Org.BouncyCastle.Math.EC.LongArray xy = longArray.Multiply(yx, this.m, this.ks);
			if (aa == ax)
			{
				aa = aa.Copy();
			}
			aa.AddShiftedByWords(xy, 0);
			aa.Reduce(this.m, this.ks);
			return new global::Org.BouncyCastle.Math.EC.F2mFieldElement(this.m, this.ks, aa);
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x000624D8 File Offset: 0x000606D8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement SquarePow(int pow)
		{
			if (pow >= 1)
			{
				return new global::Org.BouncyCastle.Math.EC.F2mFieldElement(this.m, this.ks, this.x.ModSquareN(pow, this.m, this.ks));
			}
			return this;
		}

		// Token: 0x06001505 RID: 5381 RVA: 0x00062509 File Offset: 0x00060709
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Invert()
		{
			return new global::Org.BouncyCastle.Math.EC.F2mFieldElement(this.m, this.ks, this.x.ModInverse(this.m, this.ks));
		}

		// Token: 0x06001506 RID: 5382 RVA: 0x00062533 File Offset: 0x00060733
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Sqrt()
		{
			if (!this.x.IsZero() && !this.x.IsOne())
			{
				return this.SquarePow(this.m - 1);
			}
			return this;
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06001507 RID: 5383 RVA: 0x0006255F File Offset: 0x0006075F
		public int Representation
		{
			get
			{
				return this.representation;
			}
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06001508 RID: 5384 RVA: 0x00062567 File Offset: 0x00060767
		public int M
		{
			get
			{
				return this.m;
			}
		}

		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06001509 RID: 5385 RVA: 0x0006256F File Offset: 0x0006076F
		public int K1
		{
			get
			{
				return this.ks[0];
			}
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x0600150A RID: 5386 RVA: 0x00062579 File Offset: 0x00060779
		public int K2
		{
			get
			{
				if (this.ks.Length < 2)
				{
					return 0;
				}
				return this.ks[1];
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x0600150B RID: 5387 RVA: 0x00062590 File Offset: 0x00060790
		public int K3
		{
			get
			{
				if (this.ks.Length < 3)
				{
					return 0;
				}
				return this.ks[2];
			}
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x000625A8 File Offset: 0x000607A8
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			global::Org.BouncyCastle.Math.EC.F2mFieldElement other = obj as global::Org.BouncyCastle.Math.EC.F2mFieldElement;
			return other != null && this.Equals(other);
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x000625D0 File Offset: 0x000607D0
		public virtual bool Equals(global::Org.BouncyCastle.Math.EC.F2mFieldElement other)
		{
			return this.m == other.m && this.representation == other.representation && global::Org.BouncyCastle.Utilities.Arrays.AreEqual(this.ks, other.ks) && this.x.Equals(other.x);
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x0006261F File Offset: 0x0006081F
		public override int GetHashCode()
		{
			return this.x.GetHashCode() ^ this.m ^ global::Org.BouncyCastle.Utilities.Arrays.GetHashCode(this.ks);
		}

		// Token: 0x04000959 RID: 2393
		public const int Gnb = 1;

		// Token: 0x0400095A RID: 2394
		public const int Tpb = 2;

		// Token: 0x0400095B RID: 2395
		public const int Ppb = 3;

		// Token: 0x0400095C RID: 2396
		private int representation;

		// Token: 0x0400095D RID: 2397
		private int m;

		// Token: 0x0400095E RID: 2398
		private int[] ks;

		// Token: 0x0400095F RID: 2399
		internal global::Org.BouncyCastle.Math.EC.LongArray x;
	}
}
