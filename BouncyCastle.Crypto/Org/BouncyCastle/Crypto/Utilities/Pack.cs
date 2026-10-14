using System;

namespace Org.BouncyCastle.Crypto.Utilities
{
	// Token: 0x020002F1 RID: 753
	internal sealed class Pack
	{
		// Token: 0x06002013 RID: 8211 RVA: 0x00090B98 File Offset: 0x0008ED98
		private Pack()
		{
		}

		// Token: 0x06002014 RID: 8212 RVA: 0x00090BA0 File Offset: 0x0008EDA0
		internal static void UInt16_To_BE(ushort n, byte[] bs)
		{
			bs[0] = (byte)(n >> 8);
			bs[1] = (byte)n;
		}

		// Token: 0x06002015 RID: 8213 RVA: 0x00090BAE File Offset: 0x0008EDAE
		internal static void UInt16_To_BE(ushort n, byte[] bs, int off)
		{
			bs[off] = (byte)(n >> 8);
			bs[off + 1] = (byte)n;
		}

		// Token: 0x06002016 RID: 8214 RVA: 0x00090BC0 File Offset: 0x0008EDC0
		internal static void UInt16_To_BE(ushort[] ns, byte[] bs, int off)
		{
			for (int i = 0; i < ns.Length; i++)
			{
				global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt16_To_BE(ns[i], bs, off);
				off += 2;
			}
		}

		// Token: 0x06002017 RID: 8215 RVA: 0x00090BEC File Offset: 0x0008EDEC
		internal static void UInt16_To_BE(ushort[] ns, int nsOff, int nsLen, byte[] bs, int bsOff)
		{
			for (int i = 0; i < nsLen; i++)
			{
				global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt16_To_BE(ns[nsOff + i], bs, bsOff);
				bsOff += 2;
			}
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x00090C18 File Offset: 0x0008EE18
		internal static byte[] UInt16_To_BE(ushort n)
		{
			byte[] bs = new byte[2];
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt16_To_BE(n, bs, 0);
			return bs;
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x00090C35 File Offset: 0x0008EE35
		internal static byte[] UInt16_To_BE(ushort[] ns)
		{
			return global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt16_To_BE(ns, 0, ns.Length);
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x00090C44 File Offset: 0x0008EE44
		internal static byte[] UInt16_To_BE(ushort[] ns, int nsOff, int nsLen)
		{
			byte[] bs = new byte[2 * nsLen];
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt16_To_BE(ns, nsOff, nsLen, bs, 0);
			return bs;
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x00090C65 File Offset: 0x0008EE65
		internal static ushort BE_To_UInt16(byte[] bs, int off)
		{
			return (ushort)((int)bs[off] << 8 | (int)bs[off + 1]);
		}

		// Token: 0x0600201C RID: 8220 RVA: 0x00090C73 File Offset: 0x0008EE73
		internal static void BE_To_UInt16(byte[] bs, int bsOff, ushort[] ns, int nsOff)
		{
			ns[nsOff] = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt16(bs, bsOff);
		}

		// Token: 0x0600201D RID: 8221 RVA: 0x00090C7F File Offset: 0x0008EE7F
		internal static ushort[] BE_To_UInt16(byte[] bs)
		{
			return global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt16(bs, 0, bs.Length);
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x00090C8C File Offset: 0x0008EE8C
		internal static ushort[] BE_To_UInt16(byte[] bs, int off, int len)
		{
			if ((len & 1) != 0)
			{
				throw new global::System.ArgumentException("must be a multiple of 2", "len");
			}
			ushort[] ns = new ushort[len / 2];
			for (int i = 0; i < len; i += 2)
			{
				global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt16(bs, off + i, ns, i >> 1);
			}
			return ns;
		}

		// Token: 0x0600201F RID: 8223 RVA: 0x00090CD1 File Offset: 0x0008EED1
		internal static void UInt32_To_BE(uint n, byte[] bs)
		{
			bs[0] = (byte)(n >> 24);
			bs[1] = (byte)(n >> 16);
			bs[2] = (byte)(n >> 8);
			bs[3] = (byte)n;
		}

		// Token: 0x06002020 RID: 8224 RVA: 0x00090CEF File Offset: 0x0008EEEF
		internal static void UInt32_To_BE(uint n, byte[] bs, int off)
		{
			bs[off] = (byte)(n >> 24);
			bs[off + 1] = (byte)(n >> 16);
			bs[off + 2] = (byte)(n >> 8);
			bs[off + 3] = (byte)n;
		}

		// Token: 0x06002021 RID: 8225 RVA: 0x00090D14 File Offset: 0x0008EF14
		internal static void UInt32_To_BE(uint[] ns, byte[] bs, int off)
		{
			for (int i = 0; i < ns.Length; i++)
			{
				global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(ns[i], bs, off);
				off += 4;
			}
		}

		// Token: 0x06002022 RID: 8226 RVA: 0x00090D40 File Offset: 0x0008EF40
		internal static void UInt32_To_BE(uint[] ns, int nsOff, int nsLen, byte[] bs, int bsOff)
		{
			for (int i = 0; i < nsLen; i++)
			{
				global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(ns[nsOff + i], bs, bsOff);
				bsOff += 4;
			}
		}

		// Token: 0x06002023 RID: 8227 RVA: 0x00090D6C File Offset: 0x0008EF6C
		internal static byte[] UInt32_To_BE(uint n)
		{
			byte[] bs = new byte[4];
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(n, bs, 0);
			return bs;
		}

		// Token: 0x06002024 RID: 8228 RVA: 0x00090D8C File Offset: 0x0008EF8C
		internal static byte[] UInt32_To_BE(uint[] ns)
		{
			byte[] bs = new byte[4 * ns.Length];
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(ns, bs, 0);
			return bs;
		}

		// Token: 0x06002025 RID: 8229 RVA: 0x00090DAD File Offset: 0x0008EFAD
		internal static uint BE_To_UInt32(byte[] bs)
		{
			return (uint)((int)bs[0] << 24 | (int)bs[1] << 16 | (int)bs[2] << 8 | (int)bs[3]);
		}

		// Token: 0x06002026 RID: 8230 RVA: 0x00090DC6 File Offset: 0x0008EFC6
		internal static uint BE_To_UInt32(byte[] bs, int off)
		{
			return (uint)((int)bs[off] << 24 | (int)bs[off + 1] << 16 | (int)bs[off + 2] << 8 | (int)bs[off + 3]);
		}

		// Token: 0x06002027 RID: 8231 RVA: 0x00090DE8 File Offset: 0x0008EFE8
		internal static void BE_To_UInt32(byte[] bs, int off, uint[] ns)
		{
			for (int i = 0; i < ns.Length; i++)
			{
				ns[i] = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(bs, off);
				off += 4;
			}
		}

		// Token: 0x06002028 RID: 8232 RVA: 0x00090E14 File Offset: 0x0008F014
		internal static void BE_To_UInt32(byte[] bs, int bsOff, uint[] ns, int nsOff, int nsLen)
		{
			for (int i = 0; i < nsLen; i++)
			{
				ns[nsOff + i] = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(bs, bsOff);
				bsOff += 4;
			}
		}

		// Token: 0x06002029 RID: 8233 RVA: 0x00090E40 File Offset: 0x0008F040
		internal static byte[] UInt64_To_BE(ulong n)
		{
			byte[] bs = new byte[8];
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(n, bs, 0);
			return bs;
		}

		// Token: 0x0600202A RID: 8234 RVA: 0x00090E5D File Offset: 0x0008F05D
		internal static void UInt64_To_BE(ulong n, byte[] bs)
		{
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE((uint)(n >> 32), bs);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE((uint)n, bs, 4);
		}

		// Token: 0x0600202B RID: 8235 RVA: 0x00090E73 File Offset: 0x0008F073
		internal static void UInt64_To_BE(ulong n, byte[] bs, int off)
		{
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE((uint)(n >> 32), bs, off);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE((uint)n, bs, off + 4);
		}

		// Token: 0x0600202C RID: 8236 RVA: 0x00090E8C File Offset: 0x0008F08C
		internal static byte[] UInt64_To_BE(ulong[] ns)
		{
			byte[] bs = new byte[8 * ns.Length];
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(ns, bs, 0);
			return bs;
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x00090EB0 File Offset: 0x0008F0B0
		internal static void UInt64_To_BE(ulong[] ns, byte[] bs, int off)
		{
			for (int i = 0; i < ns.Length; i++)
			{
				global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(ns[i], bs, off);
				off += 8;
			}
		}

		// Token: 0x0600202E RID: 8238 RVA: 0x00090EDC File Offset: 0x0008F0DC
		internal static void UInt64_To_BE(ulong[] ns, int nsOff, int nsLen, byte[] bs, int bsOff)
		{
			for (int i = 0; i < nsLen; i++)
			{
				global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(ns[nsOff + i], bs, bsOff);
				bsOff += 8;
			}
		}

		// Token: 0x0600202F RID: 8239 RVA: 0x00090F08 File Offset: 0x0008F108
		internal static ulong BE_To_UInt64(byte[] bs, int off)
		{
			ulong num = (ulong)global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(bs, off);
			uint lo = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(bs, off + 4);
			return num << 32 | (ulong)lo;
		}

		// Token: 0x06002030 RID: 8240 RVA: 0x00090F30 File Offset: 0x0008F130
		internal static void BE_To_UInt64(byte[] bs, int off, ulong[] ns)
		{
			for (int i = 0; i < ns.Length; i++)
			{
				ns[i] = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt64(bs, off);
				off += 8;
			}
		}

		// Token: 0x06002031 RID: 8241 RVA: 0x00090F5C File Offset: 0x0008F15C
		internal static void BE_To_UInt64(byte[] bs, int bsOff, ulong[] ns, int nsOff, int nsLen)
		{
			for (int i = 0; i < nsLen; i++)
			{
				ns[nsOff + i] = global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt64(bs, bsOff);
				bsOff += 8;
			}
		}

		// Token: 0x06002032 RID: 8242 RVA: 0x00090F87 File Offset: 0x0008F187
		internal static void UInt16_To_LE(ushort n, byte[] bs)
		{
			bs[0] = (byte)n;
			bs[1] = (byte)(n >> 8);
		}

		// Token: 0x06002033 RID: 8243 RVA: 0x00090F95 File Offset: 0x0008F195
		internal static void UInt16_To_LE(ushort n, byte[] bs, int off)
		{
			bs[off] = (byte)n;
			bs[off + 1] = (byte)(n >> 8);
		}

		// Token: 0x06002034 RID: 8244 RVA: 0x00090FA5 File Offset: 0x0008F1A5
		internal static ushort LE_To_UInt16(byte[] bs)
		{
			return (ushort)((int)bs[0] | (int)bs[1] << 8);
		}

		// Token: 0x06002035 RID: 8245 RVA: 0x00090FB1 File Offset: 0x0008F1B1
		internal static ushort LE_To_UInt16(byte[] bs, int off)
		{
			return (ushort)((int)bs[off] | (int)bs[off + 1] << 8);
		}

		// Token: 0x06002036 RID: 8246 RVA: 0x00090FC0 File Offset: 0x0008F1C0
		internal static byte[] UInt32_To_LE(uint n)
		{
			byte[] bs = new byte[4];
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(n, bs, 0);
			return bs;
		}

		// Token: 0x06002037 RID: 8247 RVA: 0x00090FDD File Offset: 0x0008F1DD
		internal static void UInt32_To_LE(uint n, byte[] bs)
		{
			bs[0] = (byte)n;
			bs[1] = (byte)(n >> 8);
			bs[2] = (byte)(n >> 16);
			bs[3] = (byte)(n >> 24);
		}

		// Token: 0x06002038 RID: 8248 RVA: 0x00090FFB File Offset: 0x0008F1FB
		internal static void UInt32_To_LE(uint n, byte[] bs, int off)
		{
			bs[off] = (byte)n;
			bs[off + 1] = (byte)(n >> 8);
			bs[off + 2] = (byte)(n >> 16);
			bs[off + 3] = (byte)(n >> 24);
		}

		// Token: 0x06002039 RID: 8249 RVA: 0x00091020 File Offset: 0x0008F220
		internal static byte[] UInt32_To_LE(uint[] ns)
		{
			byte[] bs = new byte[4 * ns.Length];
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(ns, bs, 0);
			return bs;
		}

		// Token: 0x0600203A RID: 8250 RVA: 0x00091044 File Offset: 0x0008F244
		internal static void UInt32_To_LE(uint[] ns, byte[] bs, int off)
		{
			for (int i = 0; i < ns.Length; i++)
			{
				global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(ns[i], bs, off);
				off += 4;
			}
		}

		// Token: 0x0600203B RID: 8251 RVA: 0x00091070 File Offset: 0x0008F270
		internal static void UInt32_To_LE(uint[] ns, int nsOff, int nsLen, byte[] bs, int bsOff)
		{
			for (int i = 0; i < nsLen; i++)
			{
				global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE(ns[nsOff + i], bs, bsOff);
				bsOff += 4;
			}
		}

		// Token: 0x0600203C RID: 8252 RVA: 0x0009109C File Offset: 0x0008F29C
		internal static uint LE_To_UInt32(byte[] bs)
		{
			return (uint)((int)bs[0] | (int)bs[1] << 8 | (int)bs[2] << 16 | (int)bs[3] << 24);
		}

		// Token: 0x0600203D RID: 8253 RVA: 0x000910B5 File Offset: 0x0008F2B5
		internal static uint LE_To_UInt32(byte[] bs, int off)
		{
			return (uint)((int)bs[off] | (int)bs[off + 1] << 8 | (int)bs[off + 2] << 16 | (int)bs[off + 3] << 24);
		}

		// Token: 0x0600203E RID: 8254 RVA: 0x000910D4 File Offset: 0x0008F2D4
		internal static void LE_To_UInt32(byte[] bs, int off, uint[] ns)
		{
			for (int i = 0; i < ns.Length; i++)
			{
				ns[i] = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs, off);
				off += 4;
			}
		}

		// Token: 0x0600203F RID: 8255 RVA: 0x00091100 File Offset: 0x0008F300
		internal static void LE_To_UInt32(byte[] bs, int bOff, uint[] ns, int nOff, int count)
		{
			for (int i = 0; i < count; i++)
			{
				ns[nOff + i] = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs, bOff);
				bOff += 4;
			}
		}

		// Token: 0x06002040 RID: 8256 RVA: 0x0009112C File Offset: 0x0008F32C
		internal static uint[] LE_To_UInt32(byte[] bs, int off, int count)
		{
			uint[] ns = new uint[count];
			for (int i = 0; i < ns.Length; i++)
			{
				ns[i] = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs, off);
				off += 4;
			}
			return ns;
		}

		// Token: 0x06002041 RID: 8257 RVA: 0x00091160 File Offset: 0x0008F360
		internal static byte[] UInt64_To_LE(ulong n)
		{
			byte[] bs = new byte[8];
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_LE(n, bs, 0);
			return bs;
		}

		// Token: 0x06002042 RID: 8258 RVA: 0x0009117D File Offset: 0x0008F37D
		internal static void UInt64_To_LE(ulong n, byte[] bs)
		{
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE((uint)n, bs);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE((uint)(n >> 32), bs, 4);
		}

		// Token: 0x06002043 RID: 8259 RVA: 0x00091193 File Offset: 0x0008F393
		internal static void UInt64_To_LE(ulong n, byte[] bs, int off)
		{
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE((uint)n, bs, off);
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_LE((uint)(n >> 32), bs, off + 4);
		}

		// Token: 0x06002044 RID: 8260 RVA: 0x000911AC File Offset: 0x0008F3AC
		internal static byte[] UInt64_To_LE(ulong[] ns)
		{
			byte[] bs = new byte[8 * ns.Length];
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_LE(ns, bs, 0);
			return bs;
		}

		// Token: 0x06002045 RID: 8261 RVA: 0x000911D0 File Offset: 0x0008F3D0
		internal static void UInt64_To_LE(ulong[] ns, byte[] bs, int off)
		{
			for (int i = 0; i < ns.Length; i++)
			{
				global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_LE(ns[i], bs, off);
				off += 8;
			}
		}

		// Token: 0x06002046 RID: 8262 RVA: 0x000911FC File Offset: 0x0008F3FC
		internal static void UInt64_To_LE(ulong[] ns, int nsOff, int nsLen, byte[] bs, int bsOff)
		{
			for (int i = 0; i < nsLen; i++)
			{
				global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_LE(ns[nsOff + i], bs, bsOff);
				bsOff += 8;
			}
		}

		// Token: 0x06002047 RID: 8263 RVA: 0x00091228 File Offset: 0x0008F428
		internal static ulong LE_To_UInt64(byte[] bs)
		{
			uint lo = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs);
			return (ulong)global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs, 4) << 32 | (ulong)lo;
		}

		// Token: 0x06002048 RID: 8264 RVA: 0x0009124C File Offset: 0x0008F44C
		internal static ulong LE_To_UInt64(byte[] bs, int off)
		{
			uint lo = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs, off);
			return (ulong)global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(bs, off + 4) << 32 | (ulong)lo;
		}

		// Token: 0x06002049 RID: 8265 RVA: 0x00091274 File Offset: 0x0008F474
		internal static void LE_To_UInt64(byte[] bs, int off, ulong[] ns)
		{
			for (int i = 0; i < ns.Length; i++)
			{
				ns[i] = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt64(bs, off);
				off += 8;
			}
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x000912A0 File Offset: 0x0008F4A0
		internal static void LE_To_UInt64(byte[] bs, int bsOff, ulong[] ns, int nsOff, int nsLen)
		{
			for (int i = 0; i < nsLen; i++)
			{
				ns[nsOff + i] = global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt64(bs, bsOff);
				bsOff += 8;
			}
		}
	}
}
