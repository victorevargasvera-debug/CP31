using System;

namespace Org.BouncyCastle.Math.Raw
{
	// Token: 0x020001F8 RID: 504
	internal abstract class Nat384
	{
		// Token: 0x060013FF RID: 5119 RVA: 0x0005EE38 File Offset: 0x0005D038
		public static void Mul(uint[] x, uint[] y, uint[] zz)
		{
			global::Org.BouncyCastle.Math.Raw.Nat192.Mul(x, y, zz);
			global::Org.BouncyCastle.Math.Raw.Nat192.Mul(x, 6, y, 6, zz, 12);
			uint c18 = global::Org.BouncyCastle.Math.Raw.Nat192.AddToEachOther(zz, 6, zz, 12);
			uint c19 = c18 + global::Org.BouncyCastle.Math.Raw.Nat192.AddTo(zz, 0, zz, 6, 0U);
			c18 += global::Org.BouncyCastle.Math.Raw.Nat192.AddTo(zz, 18, zz, 12, c19);
			uint[] dx = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
			uint[] dy = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
			bool neg = global::Org.BouncyCastle.Math.Raw.Nat192.Diff(x, 6, x, 0, dx, 0) != global::Org.BouncyCastle.Math.Raw.Nat192.Diff(y, 6, y, 0, dy, 0);
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat192.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat192.Mul(dx, dy, tt);
			c18 += (neg ? global::Org.BouncyCastle.Math.Raw.Nat.AddTo(12, tt, 0, zz, 6) : ((uint)global::Org.BouncyCastle.Math.Raw.Nat.SubFrom(12, tt, 0, zz, 6)));
			global::Org.BouncyCastle.Math.Raw.Nat.AddWordAt(24, c18, zz, 18);
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x0005EEE8 File Offset: 0x0005D0E8
		public static void Square(uint[] x, uint[] zz)
		{
			global::Org.BouncyCastle.Math.Raw.Nat192.Square(x, zz);
			global::Org.BouncyCastle.Math.Raw.Nat192.Square(x, 6, zz, 12);
			uint c18 = global::Org.BouncyCastle.Math.Raw.Nat192.AddToEachOther(zz, 6, zz, 12);
			uint c19 = c18 + global::Org.BouncyCastle.Math.Raw.Nat192.AddTo(zz, 0, zz, 6, 0U);
			c18 += global::Org.BouncyCastle.Math.Raw.Nat192.AddTo(zz, 18, zz, 12, c19);
			uint[] dx = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
			global::Org.BouncyCastle.Math.Raw.Nat192.Diff(x, 6, x, 0, dx, 0);
			uint[] i = global::Org.BouncyCastle.Math.Raw.Nat192.CreateExt();
			global::Org.BouncyCastle.Math.Raw.Nat192.Square(dx, i);
			c18 += (uint)global::Org.BouncyCastle.Math.Raw.Nat.SubFrom(12, i, 0, zz, 6);
			global::Org.BouncyCastle.Math.Raw.Nat.AddWordAt(24, c18, zz, 18);
		}
	}
}
