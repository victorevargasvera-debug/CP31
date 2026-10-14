using System;

namespace Org.BouncyCastle.Math.Raw
{
	// Token: 0x020001FA RID: 506
	internal abstract class Nat512
	{
		// Token: 0x0600140D RID: 5133 RVA: 0x0005F1E4 File Offset: 0x0005D3E4
		public static void Mul(uint[] x, uint[] y, uint[] zz)
		{
			global::Org.BouncyCastle.Math.Raw.Nat256.Mul(x, y, zz);
			global::Org.BouncyCastle.Math.Raw.Nat256.Mul(x, 8, y, 8, zz, 16);
			uint c24 = global::Org.BouncyCastle.Math.Raw.Nat256.AddToEachOther(zz, 8, zz, 16);
			uint c25 = c24 + global::Org.BouncyCastle.Math.Raw.Nat256.AddTo(zz, 0, zz, 8, 0U);
			c24 += global::Org.BouncyCastle.Math.Raw.Nat256.AddTo(zz, 24, zz, 16, c25);
			uint[] dx = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			uint[] dy = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			bool neg = global::Org.BouncyCastle.Math.Raw.Nat256.Diff(x, 8, x, 0, dx, 0) != global::Org.BouncyCastle.Math.Raw.Nat256.Diff(y, 8, y, 0, dy, 0);
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat256.Mul(dx, dy, tt);
			c24 += (neg ? global::Org.BouncyCastle.Math.Raw.Nat.AddTo(16, tt, 0, zz, 8) : ((uint)global::Org.BouncyCastle.Math.Raw.Nat.SubFrom(16, tt, 0, zz, 8)));
			global::Org.BouncyCastle.Math.Raw.Nat.AddWordAt(32, c24, zz, 24);
		}

		// Token: 0x0600140E RID: 5134 RVA: 0x0005F294 File Offset: 0x0005D494
		public static void Square(uint[] x, uint[] zz)
		{
			global::Org.BouncyCastle.Math.Raw.Nat256.Square(x, zz);
			global::Org.BouncyCastle.Math.Raw.Nat256.Square(x, 8, zz, 16);
			uint c24 = global::Org.BouncyCastle.Math.Raw.Nat256.AddToEachOther(zz, 8, zz, 16);
			uint c25 = c24 + global::Org.BouncyCastle.Math.Raw.Nat256.AddTo(zz, 0, zz, 8, 0U);
			c24 += global::Org.BouncyCastle.Math.Raw.Nat256.AddTo(zz, 24, zz, 16, c25);
			uint[] dx = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.Raw.Nat256.Diff(x, 8, x, 0, dx, 0);
			uint[] i = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat256.Square(dx, i);
			c24 += (uint)global::Org.BouncyCastle.Math.Raw.Nat.SubFrom(16, i, 0, zz, 8);
			global::Org.BouncyCastle.Math.Raw.Nat.AddWordAt(32, c24, zz, 24);
		}
	}
}
