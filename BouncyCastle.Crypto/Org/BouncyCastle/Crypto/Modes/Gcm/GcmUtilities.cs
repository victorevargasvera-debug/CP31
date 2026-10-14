using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Modes.Gcm
{
	// Token: 0x02000444 RID: 1092
	internal abstract class GcmUtilities
	{
		// Token: 0x06002A4C RID: 10828 RVA: 0x000B52B1 File Offset: 0x000B34B1
		internal static byte[] OneAsBytes()
		{
			byte[] array = new byte[16];
			array[0] = 128;
			return array;
		}

		// Token: 0x06002A4D RID: 10829 RVA: 0x000B52C2 File Offset: 0x000B34C2
		internal static uint[] OneAsUints()
		{
			uint[] array = new uint[4];
			array[0] = 2147483648U;
			return array;
		}

		// Token: 0x06002A4E RID: 10830 RVA: 0x000B52D2 File Offset: 0x000B34D2
		internal static ulong[] OneAsUlongs()
		{
			ulong[] array = new ulong[2];
			array[0] = 9223372036854775808UL;
			return array;
		}

		// Token: 0x06002A4F RID: 10831 RVA: 0x000B52E6 File Offset: 0x000B34E6
		internal static byte[] AsBytes(uint[] x)
		{
			return global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(x);
		}

		// Token: 0x06002A50 RID: 10832 RVA: 0x000B52EE File Offset: 0x000B34EE
		internal static void AsBytes(uint[] x, byte[] z)
		{
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt32_To_BE(x, z, 0);
		}

		// Token: 0x06002A51 RID: 10833 RVA: 0x000B52F8 File Offset: 0x000B34F8
		internal static byte[] AsBytes(ulong[] x)
		{
			byte[] z = new byte[16];
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(x, z, 0);
			return z;
		}

		// Token: 0x06002A52 RID: 10834 RVA: 0x000B5316 File Offset: 0x000B3516
		internal static void AsBytes(ulong[] x, byte[] z)
		{
			global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(x, z, 0);
		}

		// Token: 0x06002A53 RID: 10835 RVA: 0x000B5320 File Offset: 0x000B3520
		internal static uint[] AsUints(byte[] bs)
		{
			uint[] output = new uint[4];
			global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(bs, 0, output);
			return output;
		}

		// Token: 0x06002A54 RID: 10836 RVA: 0x000B533D File Offset: 0x000B353D
		internal static void AsUints(byte[] bs, uint[] output)
		{
			global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt32(bs, 0, output);
		}

		// Token: 0x06002A55 RID: 10837 RVA: 0x000B5348 File Offset: 0x000B3548
		internal static ulong[] AsUlongs(byte[] x)
		{
			ulong[] z = new ulong[2];
			global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt64(x, 0, z);
			return z;
		}

		// Token: 0x06002A56 RID: 10838 RVA: 0x000B5365 File Offset: 0x000B3565
		internal static void AsUlongs(byte[] x, ulong[] z)
		{
			global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt64(x, 0, z);
		}

		// Token: 0x06002A57 RID: 10839 RVA: 0x000B536F File Offset: 0x000B356F
		internal static void AsUlongs(byte[] x, ulong[] z, int zOff)
		{
			global::Org.BouncyCastle.Crypto.Utilities.Pack.BE_To_UInt64(x, 0, z, zOff, 2);
		}

		// Token: 0x06002A58 RID: 10840 RVA: 0x000B537B File Offset: 0x000B357B
		internal static void Copy(uint[] x, uint[] z)
		{
			z[0] = x[0];
			z[1] = x[1];
			z[2] = x[2];
			z[3] = x[3];
		}

		// Token: 0x06002A59 RID: 10841 RVA: 0x000B5395 File Offset: 0x000B3595
		internal static void Copy(ulong[] x, ulong[] z)
		{
			z[0] = x[0];
			z[1] = x[1];
		}

		// Token: 0x06002A5A RID: 10842 RVA: 0x000B53A3 File Offset: 0x000B35A3
		internal static void Copy(ulong[] x, int xOff, ulong[] z, int zOff)
		{
			z[zOff] = x[xOff];
			z[zOff + 1] = x[xOff + 1];
		}

		// Token: 0x06002A5B RID: 10843 RVA: 0x000B53B8 File Offset: 0x000B35B8
		internal static void DivideP(ulong[] x, ulong[] z)
		{
			ulong x2 = x[0];
			ulong x3 = x[1];
			ulong i = x2 >> 63;
			x2 ^= (i & 16212958658533785600UL);
			z[0] = (x2 << 1 | x3 >> 63);
			z[1] = (x3 << 1 | -i);
		}

		// Token: 0x06002A5C RID: 10844 RVA: 0x000B53F4 File Offset: 0x000B35F4
		internal static void DivideP(ulong[] x, int xOff, ulong[] z, int zOff)
		{
			ulong x2 = x[xOff];
			ulong x3 = x[xOff + 1];
			ulong i = x2 >> 63;
			x2 ^= (i & 16212958658533785600UL);
			z[zOff] = (x2 << 1 | x3 >> 63);
			z[zOff + 1] = (x3 << 1 | -i);
		}

		// Token: 0x06002A5D RID: 10845 RVA: 0x000B5434 File Offset: 0x000B3634
		internal static void Multiply(byte[] x, byte[] y)
		{
			ulong[] x2 = global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.AsUlongs(x);
			ulong[] t2 = global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.AsUlongs(y);
			global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.Multiply(x2, t2);
			global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.AsBytes(x2, x);
		}

		// Token: 0x06002A5E RID: 10846 RVA: 0x000B545C File Offset: 0x000B365C
		internal static void Multiply(uint[] x, uint[] y)
		{
			uint y2 = y[0];
			uint y3 = y[1];
			uint y4 = y[2];
			uint y5 = y[3];
			uint z0 = 0U;
			uint z = 0U;
			uint z2 = 0U;
			uint z3 = 0U;
			for (int i = 0; i < 4; i++)
			{
				int bits = (int)x[i];
				for (int j = 0; j < 32; j++)
				{
					uint m = (uint)(bits >> 31);
					bits <<= 1;
					z0 ^= (y2 & m);
					z ^= (y3 & m);
					z2 ^= (y4 & m);
					z3 ^= (y5 & m);
					uint m2 = (uint)((int)((int)y5 << 31) >> 8);
					y5 = (y5 >> 1 | y4 << 31);
					y4 = (y4 >> 1 | y3 << 31);
					y3 = (y3 >> 1 | y2 << 31);
					y2 = (y2 >> 1 ^ (m2 & 3774873600U));
				}
			}
			x[0] = z0;
			x[1] = z;
			x[2] = z2;
			x[3] = z3;
		}

		// Token: 0x06002A5F RID: 10847 RVA: 0x000B5524 File Offset: 0x000B3724
		internal static void Multiply(ulong[] x, ulong[] y)
		{
			ulong num = x[0];
			ulong x2 = x[1];
			ulong y2 = y[0];
			ulong y3 = y[1];
			ulong x0r = global::Org.BouncyCastle.Utilities.Longs.Reverse(num);
			ulong x1r = global::Org.BouncyCastle.Utilities.Longs.Reverse(x2);
			ulong y0r = global::Org.BouncyCastle.Utilities.Longs.Reverse(y2);
			ulong y1r = global::Org.BouncyCastle.Utilities.Longs.Reverse(y3);
			ulong h0 = global::Org.BouncyCastle.Utilities.Longs.Reverse(global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.ImplMul64(x0r, y0r));
			ulong h = global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.ImplMul64(num, y2) << 1;
			ulong h2 = global::Org.BouncyCastle.Utilities.Longs.Reverse(global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.ImplMul64(x1r, y1r));
			ulong h3 = global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.ImplMul64(x2, y3) << 1;
			ulong h4 = global::Org.BouncyCastle.Utilities.Longs.Reverse(global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.ImplMul64(x0r ^ x1r, y0r ^ y1r));
			ulong h5 = global::Org.BouncyCastle.Crypto.Modes.Gcm.GcmUtilities.ImplMul64(num ^ x2, y2 ^ y3) << 1;
			ulong z0 = h0;
			ulong z = h ^ h0 ^ h2 ^ h4;
			ulong z2 = h2 ^ h ^ h3 ^ h5;
			ulong z3 = h3;
			z ^= (z3 ^ z3 >> 1 ^ z3 >> 2 ^ z3 >> 7);
			z2 ^= (z3 << 62 ^ z3 << 57);
			z0 ^= (z2 ^ z2 >> 1 ^ z2 >> 2 ^ z2 >> 7);
			z ^= (z2 << 63 ^ z2 << 62 ^ z2 << 57);
			x[0] = z0;
			x[1] = z;
		}

		// Token: 0x06002A60 RID: 10848 RVA: 0x000B5638 File Offset: 0x000B3838
		internal static void MultiplyP(uint[] x)
		{
			uint x2 = x[0];
			uint x3 = x[1];
			uint x4 = x[2];
			uint x5 = x[3];
			uint i = (uint)((int)((int)x5 << 31) >> 31);
			x[0] = (x2 >> 1 ^ (i & 3774873600U));
			x[1] = (x3 >> 1 | x2 << 31);
			x[2] = (x4 >> 1 | x3 << 31);
			x[3] = (x5 >> 1 | x4 << 31);
		}

		// Token: 0x06002A61 RID: 10849 RVA: 0x000B5690 File Offset: 0x000B3890
		internal static void MultiplyP(uint[] x, uint[] z)
		{
			uint x2 = x[0];
			uint x3 = x[1];
			uint x4 = x[2];
			uint x5 = x[3];
			uint i = (uint)((int)((int)x5 << 31) >> 31);
			z[0] = (x2 >> 1 ^ (i & 3774873600U));
			z[1] = (x3 >> 1 | x2 << 31);
			z[2] = (x4 >> 1 | x3 << 31);
			z[3] = (x5 >> 1 | x4 << 31);
		}

		// Token: 0x06002A62 RID: 10850 RVA: 0x000B56E8 File Offset: 0x000B38E8
		internal static void MultiplyP(ulong[] x)
		{
			ulong x2 = x[0];
			ulong x3 = x[1];
			ulong i = x3 << 63 >> 63;
			x[0] = (x2 >> 1 ^ (i & 16212958658533785600UL));
			x[1] = (x3 >> 1 | x2 << 63);
		}

		// Token: 0x06002A63 RID: 10851 RVA: 0x000B5724 File Offset: 0x000B3924
		internal static void MultiplyP(ulong[] x, ulong[] z)
		{
			ulong x2 = x[0];
			ulong x3 = x[1];
			ulong i = x3 << 63 >> 63;
			z[0] = (x2 >> 1 ^ (i & 16212958658533785600UL));
			z[1] = (x3 >> 1 | x2 << 63);
		}

		// Token: 0x06002A64 RID: 10852 RVA: 0x000B5760 File Offset: 0x000B3960
		internal static void MultiplyP3(ulong[] x, ulong[] z)
		{
			ulong x2 = x[0];
			ulong x3 = x[1];
			ulong c = x3 << 61;
			z[0] = (x2 >> 3 ^ c ^ c >> 1 ^ c >> 2 ^ c >> 7);
			z[1] = (x3 >> 3 | x2 << 61);
		}

		// Token: 0x06002A65 RID: 10853 RVA: 0x000B579C File Offset: 0x000B399C
		internal static void MultiplyP3(ulong[] x, int xOff, ulong[] z, int zOff)
		{
			ulong x2 = x[xOff];
			ulong x3 = x[xOff + 1];
			ulong c = x3 << 61;
			z[zOff] = (x2 >> 3 ^ c ^ c >> 1 ^ c >> 2 ^ c >> 7);
			z[zOff + 1] = (x3 >> 3 | x2 << 61);
		}

		// Token: 0x06002A66 RID: 10854 RVA: 0x000B57DC File Offset: 0x000B39DC
		internal static void MultiplyP4(ulong[] x, ulong[] z)
		{
			ulong x2 = x[0];
			ulong x3 = x[1];
			ulong c = x3 << 60;
			z[0] = (x2 >> 4 ^ c ^ c >> 1 ^ c >> 2 ^ c >> 7);
			z[1] = (x3 >> 4 | x2 << 60);
		}

		// Token: 0x06002A67 RID: 10855 RVA: 0x000B5818 File Offset: 0x000B3A18
		internal static void MultiplyP4(ulong[] x, int xOff, ulong[] z, int zOff)
		{
			ulong x2 = x[xOff];
			ulong x3 = x[xOff + 1];
			ulong c = x3 << 60;
			z[zOff] = (x2 >> 4 ^ c ^ c >> 1 ^ c >> 2 ^ c >> 7);
			z[zOff + 1] = (x3 >> 4 | x2 << 60);
		}

		// Token: 0x06002A68 RID: 10856 RVA: 0x000B5858 File Offset: 0x000B3A58
		internal static void MultiplyP7(ulong[] x, ulong[] z)
		{
			ulong x2 = x[0];
			ulong x3 = x[1];
			ulong c = x3 << 57;
			z[0] = (x2 >> 7 ^ c ^ c >> 1 ^ c >> 2 ^ c >> 7);
			z[1] = (x3 >> 7 | x2 << 57);
		}

		// Token: 0x06002A69 RID: 10857 RVA: 0x000B5894 File Offset: 0x000B3A94
		internal static void MultiplyP7(ulong[] x, int xOff, ulong[] z, int zOff)
		{
			ulong x2 = x[xOff];
			ulong x3 = x[xOff + 1];
			ulong c = x3 << 57;
			z[zOff] = (x2 >> 7 ^ c ^ c >> 1 ^ c >> 2 ^ c >> 7);
			z[zOff + 1] = (x3 >> 7 | x2 << 57);
		}

		// Token: 0x06002A6A RID: 10858 RVA: 0x000B58D4 File Offset: 0x000B3AD4
		internal static void MultiplyP8(uint[] x)
		{
			uint x2 = x[0];
			uint x3 = x[1];
			uint x4 = x[2];
			uint x5 = x[3];
			uint c = x5 << 24;
			x[0] = (x2 >> 8 ^ c ^ c >> 1 ^ c >> 2 ^ c >> 7);
			x[1] = (x3 >> 8 | x2 << 24);
			x[2] = (x4 >> 8 | x3 << 24);
			x[3] = (x5 >> 8 | x4 << 24);
		}

		// Token: 0x06002A6B RID: 10859 RVA: 0x000B5930 File Offset: 0x000B3B30
		internal static void MultiplyP8(uint[] x, uint[] y)
		{
			uint x2 = x[0];
			uint x3 = x[1];
			uint x4 = x[2];
			uint x5 = x[3];
			uint c = x5 << 24;
			y[0] = (x2 >> 8 ^ c ^ c >> 1 ^ c >> 2 ^ c >> 7);
			y[1] = (x3 >> 8 | x2 << 24);
			y[2] = (x4 >> 8 | x3 << 24);
			y[3] = (x5 >> 8 | x4 << 24);
		}

		// Token: 0x06002A6C RID: 10860 RVA: 0x000B598C File Offset: 0x000B3B8C
		internal static void MultiplyP8(ulong[] x)
		{
			ulong x2 = x[0];
			ulong x3 = x[1];
			ulong c = x3 << 56;
			x[0] = (x2 >> 8 ^ c ^ c >> 1 ^ c >> 2 ^ c >> 7);
			x[1] = (x3 >> 8 | x2 << 56);
		}

		// Token: 0x06002A6D RID: 10861 RVA: 0x000B59C8 File Offset: 0x000B3BC8
		internal static void MultiplyP8(ulong[] x, ulong[] y)
		{
			ulong x2 = x[0];
			ulong x3 = x[1];
			ulong c = x3 << 56;
			y[0] = (x2 >> 8 ^ c ^ c >> 1 ^ c >> 2 ^ c >> 7);
			y[1] = (x3 >> 8 | x2 << 56);
		}

		// Token: 0x06002A6E RID: 10862 RVA: 0x000B5A04 File Offset: 0x000B3C04
		internal static void MultiplyP8(ulong[] x, int xOff, ulong[] y, int yOff)
		{
			ulong x2 = x[xOff];
			ulong x3 = x[xOff + 1];
			ulong c = x3 << 56;
			y[yOff] = (x2 >> 8 ^ c ^ c >> 1 ^ c >> 2 ^ c >> 7);
			y[yOff + 1] = (x3 >> 8 | x2 << 56);
		}

		// Token: 0x06002A6F RID: 10863 RVA: 0x000B5A44 File Offset: 0x000B3C44
		internal static void Square(ulong[] x, ulong[] z)
		{
			ulong[] t = new ulong[4];
			global::Org.BouncyCastle.Math.Raw.Interleave.Expand64To128Rev(x[0], t, 0);
			global::Org.BouncyCastle.Math.Raw.Interleave.Expand64To128Rev(x[1], t, 2);
			ulong z2 = t[0];
			ulong z3 = t[1];
			ulong z4 = t[2];
			ulong z5 = t[3];
			z3 ^= (z5 ^ z5 >> 1 ^ z5 >> 2 ^ z5 >> 7);
			z4 ^= (z5 << 62 ^ z5 << 57);
			z2 ^= (z4 ^ z4 >> 1 ^ z4 >> 2 ^ z4 >> 7);
			z3 ^= (z4 << 63 ^ z4 << 62 ^ z4 << 57);
			z[0] = z2;
			z[1] = z3;
		}

		// Token: 0x06002A70 RID: 10864 RVA: 0x000B5AC8 File Offset: 0x000B3CC8
		internal static void Xor(byte[] x, byte[] y)
		{
			int i = 0;
			do
			{
				int num = i;
				x[num] ^= y[i];
				i++;
				int num2 = i;
				x[num2] ^= y[i];
				i++;
				int num3 = i;
				x[num3] ^= y[i];
				i++;
				int num4 = i;
				x[num4] ^= y[i];
				i++;
			}
			while (i < 16);
		}

		// Token: 0x06002A71 RID: 10865 RVA: 0x000B5B28 File Offset: 0x000B3D28
		internal static void Xor(byte[] x, byte[] y, int yOff)
		{
			int i = 0;
			do
			{
				int num = i;
				x[num] ^= y[yOff + i];
				i++;
				int num2 = i;
				x[num2] ^= y[yOff + i];
				i++;
				int num3 = i;
				x[num3] ^= y[yOff + i];
				i++;
				int num4 = i;
				x[num4] ^= y[yOff + i];
				i++;
			}
			while (i < 16);
		}

		// Token: 0x06002A72 RID: 10866 RVA: 0x000B5B90 File Offset: 0x000B3D90
		internal static void Xor(byte[] x, int xOff, byte[] y, int yOff, byte[] z, int zOff)
		{
			int i = 0;
			do
			{
				z[zOff + i] = (x[xOff + i] ^ y[yOff + i]);
				i++;
				z[zOff + i] = (x[xOff + i] ^ y[yOff + i]);
				i++;
				z[zOff + i] = (x[xOff + i] ^ y[yOff + i]);
				i++;
				z[zOff + i] = (x[xOff + i] ^ y[yOff + i]);
				i++;
			}
			while (i < 16);
		}

		// Token: 0x06002A73 RID: 10867 RVA: 0x000B5C00 File Offset: 0x000B3E00
		internal static void Xor(byte[] x, byte[] y, int yOff, int yLen)
		{
			while (--yLen >= 0)
			{
				int num = yLen;
				x[num] ^= y[yOff + yLen];
			}
		}

		// Token: 0x06002A74 RID: 10868 RVA: 0x000B5C1E File Offset: 0x000B3E1E
		internal static void Xor(byte[] x, int xOff, byte[] y, int yOff, int len)
		{
			while (--len >= 0)
			{
				int num = xOff + len;
				x[num] ^= y[yOff + len];
			}
		}

		// Token: 0x06002A75 RID: 10869 RVA: 0x000B5C44 File Offset: 0x000B3E44
		internal static void Xor(byte[] x, byte[] y, byte[] z)
		{
			int i = 0;
			do
			{
				z[i] = (x[i] ^ y[i]);
				i++;
				z[i] = (x[i] ^ y[i]);
				i++;
				z[i] = (x[i] ^ y[i]);
				i++;
				z[i] = (x[i] ^ y[i]);
				i++;
			}
			while (i < 16);
		}

		// Token: 0x06002A76 RID: 10870 RVA: 0x000B5C94 File Offset: 0x000B3E94
		internal static void Xor(uint[] x, uint[] y)
		{
			x[0] ^= y[0];
			x[1] ^= y[1];
			x[2] ^= y[2];
			x[3] ^= y[3];
		}

		// Token: 0x06002A77 RID: 10871 RVA: 0x000B5CCE File Offset: 0x000B3ECE
		internal static void Xor(uint[] x, uint[] y, uint[] z)
		{
			z[0] = (x[0] ^ y[0]);
			z[1] = (x[1] ^ y[1]);
			z[2] = (x[2] ^ y[2]);
			z[3] = (x[3] ^ y[3]);
		}

		// Token: 0x06002A78 RID: 10872 RVA: 0x000B5CF8 File Offset: 0x000B3EF8
		internal static void Xor(ulong[] x, ulong[] y)
		{
			x[0] ^= y[0];
			x[1] ^= y[1];
		}

		// Token: 0x06002A79 RID: 10873 RVA: 0x000B5D16 File Offset: 0x000B3F16
		internal static void Xor(ulong[] x, int xOff, ulong[] y, int yOff)
		{
			x[xOff] ^= y[yOff];
			x[xOff + 1] ^= y[yOff + 1];
		}

		// Token: 0x06002A7A RID: 10874 RVA: 0x000B5D38 File Offset: 0x000B3F38
		internal static void Xor(ulong[] x, ulong[] y, ulong[] z)
		{
			z[0] = (x[0] ^ y[0]);
			z[1] = (x[1] ^ y[1]);
		}

		// Token: 0x06002A7B RID: 10875 RVA: 0x000B5D4E File Offset: 0x000B3F4E
		internal static void Xor(ulong[] x, int xOff, ulong[] y, int yOff, ulong[] z, int zOff)
		{
			z[zOff] = (x[xOff] ^ y[yOff]);
			z[zOff + 1] = (x[xOff + 1] ^ y[yOff + 1]);
		}

		// Token: 0x06002A7C RID: 10876 RVA: 0x000B5D70 File Offset: 0x000B3F70
		private static ulong ImplMul64(ulong x, ulong y)
		{
			ulong num = x & 1229782938247303441UL;
			ulong x2 = x & 2459565876494606882UL;
			ulong x3 = x & 4919131752989213764UL;
			ulong x4 = x & 9838263505978427528UL;
			ulong y2 = y & 1229782938247303441UL;
			ulong y3 = y & 2459565876494606882UL;
			ulong y4 = y & 4919131752989213764UL;
			ulong y5 = y & 9838263505978427528UL;
			ulong z0 = num * y2 ^ x2 * y5 ^ x3 * y4 ^ x4 * y3;
			ulong z = num * y3 ^ x2 * y2 ^ x3 * y5 ^ x4 * y4;
			ulong z2 = num * y4 ^ x2 * y3 ^ x3 * y2 ^ x4 * y5;
			ulong z3 = num * y5 ^ x2 * y4 ^ x3 * y3 ^ x4 * y2;
			z0 &= 1229782938247303441UL;
			z &= 2459565876494606882UL;
			z2 &= 4919131752989213764UL;
			z3 &= 9838263505978427528UL;
			return z0 | z | z2 | z3;
		}

		// Token: 0x04001168 RID: 4456
		private const uint E1 = 3774873600U;

		// Token: 0x04001169 RID: 4457
		private const ulong E1UL = 16212958658533785600UL;
	}
}
