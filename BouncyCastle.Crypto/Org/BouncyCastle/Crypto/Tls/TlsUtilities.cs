using System;
using System.Collections;
using System.IO;
using System.Net.Sockets;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Nist;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Date;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000393 RID: 915
	public abstract class TlsUtilities
	{
		// Token: 0x06002503 RID: 9475 RVA: 0x000A0699 File Offset: 0x0009E899
		public static void CheckUint8(int i)
		{
			if (!global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsValidUint8(i))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
		}

		// Token: 0x06002504 RID: 9476 RVA: 0x000A06AB File Offset: 0x0009E8AB
		public static void CheckUint8(long i)
		{
			if (!global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsValidUint8(i))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
		}

		// Token: 0x06002505 RID: 9477 RVA: 0x000A06BD File Offset: 0x0009E8BD
		public static void CheckUint16(int i)
		{
			if (!global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsValidUint16(i))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
		}

		// Token: 0x06002506 RID: 9478 RVA: 0x000A06CF File Offset: 0x0009E8CF
		public static void CheckUint16(long i)
		{
			if (!global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsValidUint16(i))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
		}

		// Token: 0x06002507 RID: 9479 RVA: 0x000A06E1 File Offset: 0x0009E8E1
		public static void CheckUint24(int i)
		{
			if (!global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsValidUint24(i))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
		}

		// Token: 0x06002508 RID: 9480 RVA: 0x000A06F3 File Offset: 0x0009E8F3
		public static void CheckUint24(long i)
		{
			if (!global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsValidUint24(i))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
		}

		// Token: 0x06002509 RID: 9481 RVA: 0x000A0705 File Offset: 0x0009E905
		public static void CheckUint32(long i)
		{
			if (!global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsValidUint32(i))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
		}

		// Token: 0x0600250A RID: 9482 RVA: 0x000A0717 File Offset: 0x0009E917
		public static void CheckUint48(long i)
		{
			if (!global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsValidUint48(i))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
		}

		// Token: 0x0600250B RID: 9483 RVA: 0x000A0729 File Offset: 0x0009E929
		public static void CheckUint64(long i)
		{
			if (!global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsValidUint64(i))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
		}

		// Token: 0x0600250C RID: 9484 RVA: 0x000A073B File Offset: 0x0009E93B
		public static bool IsValidUint8(int i)
		{
			return (i & 255) == i;
		}

		// Token: 0x0600250D RID: 9485 RVA: 0x000A0747 File Offset: 0x0009E947
		public static bool IsValidUint8(long i)
		{
			return (i & 255L) == i;
		}

		// Token: 0x0600250E RID: 9486 RVA: 0x000A0754 File Offset: 0x0009E954
		public static bool IsValidUint16(int i)
		{
			return (i & 65535) == i;
		}

		// Token: 0x0600250F RID: 9487 RVA: 0x000A0760 File Offset: 0x0009E960
		public static bool IsValidUint16(long i)
		{
			return (i & 65535L) == i;
		}

		// Token: 0x06002510 RID: 9488 RVA: 0x000A076D File Offset: 0x0009E96D
		public static bool IsValidUint24(int i)
		{
			return (i & 16777215) == i;
		}

		// Token: 0x06002511 RID: 9489 RVA: 0x000A0779 File Offset: 0x0009E979
		public static bool IsValidUint24(long i)
		{
			return (i & 16777215L) == i;
		}

		// Token: 0x06002512 RID: 9490 RVA: 0x000A0786 File Offset: 0x0009E986
		public static bool IsValidUint32(long i)
		{
			return (i & (long)((ulong)-1)) == i;
		}

		// Token: 0x06002513 RID: 9491 RVA: 0x000A078F File Offset: 0x0009E98F
		public static bool IsValidUint48(long i)
		{
			return (i & 281474976710655L) == i;
		}

		// Token: 0x06002514 RID: 9492 RVA: 0x000A079F File Offset: 0x0009E99F
		public static bool IsValidUint64(long i)
		{
			return true;
		}

		// Token: 0x06002515 RID: 9493 RVA: 0x000A07A2 File Offset: 0x0009E9A2
		public static bool IsSsl(global::Org.BouncyCastle.Crypto.Tls.TlsContext context)
		{
			return context.ServerVersion.IsSsl;
		}

		// Token: 0x06002516 RID: 9494 RVA: 0x000A07AF File Offset: 0x0009E9AF
		public static bool IsTlsV11(global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion version)
		{
			return global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion.TLSv11.IsEqualOrEarlierVersionOf(version.GetEquivalentTLSVersion());
		}

		// Token: 0x06002517 RID: 9495 RVA: 0x000A07C1 File Offset: 0x0009E9C1
		public static bool IsTlsV11(global::Org.BouncyCastle.Crypto.Tls.TlsContext context)
		{
			return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTlsV11(context.ServerVersion);
		}

		// Token: 0x06002518 RID: 9496 RVA: 0x000A07CE File Offset: 0x0009E9CE
		public static bool IsTlsV12(global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion version)
		{
			return global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion.TLSv12.IsEqualOrEarlierVersionOf(version.GetEquivalentTLSVersion());
		}

		// Token: 0x06002519 RID: 9497 RVA: 0x000A07E0 File Offset: 0x0009E9E0
		public static bool IsTlsV12(global::Org.BouncyCastle.Crypto.Tls.TlsContext context)
		{
			return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTlsV12(context.ServerVersion);
		}

		// Token: 0x0600251A RID: 9498 RVA: 0x000A07ED File Offset: 0x0009E9ED
		public static void WriteUint8(byte i, global::System.IO.Stream output)
		{
			output.WriteByte(i);
		}

		// Token: 0x0600251B RID: 9499 RVA: 0x000A07F6 File Offset: 0x0009E9F6
		public static void WriteUint8(byte i, byte[] buf, int offset)
		{
			buf[offset] = i;
		}

		// Token: 0x0600251C RID: 9500 RVA: 0x000A07FC File Offset: 0x0009E9FC
		public static void WriteUint16(int i, global::System.IO.Stream output)
		{
			output.WriteByte((byte)(i >> 8));
			output.WriteByte((byte)i);
		}

		// Token: 0x0600251D RID: 9501 RVA: 0x000A0810 File Offset: 0x0009EA10
		public static void WriteUint16(int i, byte[] buf, int offset)
		{
			buf[offset] = (byte)(i >> 8);
			buf[offset + 1] = (byte)i;
		}

		// Token: 0x0600251E RID: 9502 RVA: 0x000A0820 File Offset: 0x0009EA20
		public static void WriteUint24(int i, global::System.IO.Stream output)
		{
			output.WriteByte((byte)(i >> 16));
			output.WriteByte((byte)(i >> 8));
			output.WriteByte((byte)i);
		}

		// Token: 0x0600251F RID: 9503 RVA: 0x000A083F File Offset: 0x0009EA3F
		public static void WriteUint24(int i, byte[] buf, int offset)
		{
			buf[offset] = (byte)(i >> 16);
			buf[offset + 1] = (byte)(i >> 8);
			buf[offset + 2] = (byte)i;
		}

		// Token: 0x06002520 RID: 9504 RVA: 0x000A0859 File Offset: 0x0009EA59
		public static void WriteUint32(long i, global::System.IO.Stream output)
		{
			output.WriteByte((byte)(i >> 24));
			output.WriteByte((byte)(i >> 16));
			output.WriteByte((byte)(i >> 8));
			output.WriteByte((byte)i);
		}

		// Token: 0x06002521 RID: 9505 RVA: 0x000A0883 File Offset: 0x0009EA83
		public static void WriteUint32(long i, byte[] buf, int offset)
		{
			buf[offset] = (byte)(i >> 24);
			buf[offset + 1] = (byte)(i >> 16);
			buf[offset + 2] = (byte)(i >> 8);
			buf[offset + 3] = (byte)i;
		}

		// Token: 0x06002522 RID: 9506 RVA: 0x000A08A7 File Offset: 0x0009EAA7
		public static void WriteUint48(long i, global::System.IO.Stream output)
		{
			output.WriteByte((byte)(i >> 40));
			output.WriteByte((byte)(i >> 32));
			output.WriteByte((byte)(i >> 24));
			output.WriteByte((byte)(i >> 16));
			output.WriteByte((byte)(i >> 8));
			output.WriteByte((byte)i);
		}

		// Token: 0x06002523 RID: 9507 RVA: 0x000A08E7 File Offset: 0x0009EAE7
		public static void WriteUint48(long i, byte[] buf, int offset)
		{
			buf[offset] = (byte)(i >> 40);
			buf[offset + 1] = (byte)(i >> 32);
			buf[offset + 2] = (byte)(i >> 24);
			buf[offset + 3] = (byte)(i >> 16);
			buf[offset + 4] = (byte)(i >> 8);
			buf[offset + 5] = (byte)i;
		}

		// Token: 0x06002524 RID: 9508 RVA: 0x000A0920 File Offset: 0x0009EB20
		public static void WriteUint64(long i, global::System.IO.Stream output)
		{
			output.WriteByte((byte)(i >> 56));
			output.WriteByte((byte)(i >> 48));
			output.WriteByte((byte)(i >> 40));
			output.WriteByte((byte)(i >> 32));
			output.WriteByte((byte)(i >> 24));
			output.WriteByte((byte)(i >> 16));
			output.WriteByte((byte)(i >> 8));
			output.WriteByte((byte)i);
		}

		// Token: 0x06002525 RID: 9509 RVA: 0x000A0984 File Offset: 0x0009EB84
		public static void WriteUint64(long i, byte[] buf, int offset)
		{
			buf[offset] = (byte)(i >> 56);
			buf[offset + 1] = (byte)(i >> 48);
			buf[offset + 2] = (byte)(i >> 40);
			buf[offset + 3] = (byte)(i >> 32);
			buf[offset + 4] = (byte)(i >> 24);
			buf[offset + 5] = (byte)(i >> 16);
			buf[offset + 6] = (byte)(i >> 8);
			buf[offset + 7] = (byte)i;
		}

		// Token: 0x06002526 RID: 9510 RVA: 0x000A09DB File Offset: 0x0009EBDB
		public static void WriteOpaque8(byte[] buf, global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8((byte)buf.Length, output);
			output.Write(buf, 0, buf.Length);
		}

		// Token: 0x06002527 RID: 9511 RVA: 0x000A09F2 File Offset: 0x0009EBF2
		public static void WriteOpaque16(byte[] buf, global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(buf.Length, output);
			output.Write(buf, 0, buf.Length);
		}

		// Token: 0x06002528 RID: 9512 RVA: 0x000A0A08 File Offset: 0x0009EC08
		public static void WriteOpaque24(byte[] buf, global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint24(buf.Length, output);
			output.Write(buf, 0, buf.Length);
		}

		// Token: 0x06002529 RID: 9513 RVA: 0x000A0A1E File Offset: 0x0009EC1E
		public static void WriteUint8Array(byte[] uints, global::System.IO.Stream output)
		{
			output.Write(uints, 0, uints.Length);
		}

		// Token: 0x0600252A RID: 9514 RVA: 0x000A0A2C File Offset: 0x0009EC2C
		public static void WriteUint8Array(byte[] uints, byte[] buf, int offset)
		{
			for (int i = 0; i < uints.Length; i++)
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(uints[i], buf, offset);
				offset++;
			}
		}

		// Token: 0x0600252B RID: 9515 RVA: 0x000A0A56 File Offset: 0x0009EC56
		public static void WriteUint8ArrayWithUint8Length(byte[] uints, global::System.IO.Stream output)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint8(uints.Length);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8((byte)uints.Length, output);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8Array(uints, output);
		}

		// Token: 0x0600252C RID: 9516 RVA: 0x000A0A71 File Offset: 0x0009EC71
		public static void WriteUint8ArrayWithUint8Length(byte[] uints, byte[] buf, int offset)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint8(uints.Length);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8((byte)uints.Length, buf, offset);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8Array(uints, buf, offset + 1);
		}

		// Token: 0x0600252D RID: 9517 RVA: 0x000A0A90 File Offset: 0x0009EC90
		public static void WriteUint16Array(int[] uints, global::System.IO.Stream output)
		{
			for (int i = 0; i < uints.Length; i++)
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(uints[i], output);
			}
		}

		// Token: 0x0600252E RID: 9518 RVA: 0x000A0AB4 File Offset: 0x0009ECB4
		public static void WriteUint16Array(int[] uints, byte[] buf, int offset)
		{
			for (int i = 0; i < uints.Length; i++)
			{
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(uints[i], buf, offset);
				offset += 2;
			}
		}

		// Token: 0x0600252F RID: 9519 RVA: 0x000A0ADE File Offset: 0x0009ECDE
		public static void WriteUint16ArrayWithUint16Length(int[] uints, global::System.IO.Stream output)
		{
			int i = 2 * uints.Length;
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint16(i);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(i, output);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16Array(uints, output);
		}

		// Token: 0x06002530 RID: 9520 RVA: 0x000A0AF8 File Offset: 0x0009ECF8
		public static void WriteUint16ArrayWithUint16Length(int[] uints, byte[] buf, int offset)
		{
			int i = 2 * uints.Length;
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint16(i);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(i, buf, offset);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16Array(uints, buf, offset + 2);
		}

		// Token: 0x06002531 RID: 9521 RVA: 0x000A0B16 File Offset: 0x0009ED16
		public static byte DecodeUint8(byte[] buf)
		{
			if (buf == null)
			{
				throw new global::System.ArgumentNullException("buf");
			}
			if (buf.Length != 1)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(50);
			}
			return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(buf, 0);
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x000A0B3C File Offset: 0x0009ED3C
		public static byte[] DecodeUint8ArrayWithUint8Length(byte[] buf)
		{
			if (buf == null)
			{
				throw new global::System.ArgumentNullException("buf");
			}
			int count = (int)global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(buf, 0);
			if (buf.Length != count + 1)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(50);
			}
			byte[] uints = new byte[count];
			for (int i = 0; i < count; i++)
			{
				uints[i] = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(buf, i + 1);
			}
			return uints;
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x000A0B8F File Offset: 0x0009ED8F
		public static byte[] EncodeOpaque8(byte[] buf)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint8(buf.Length);
			return global::Org.BouncyCastle.Utilities.Arrays.Prepend(buf, (byte)buf.Length);
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x000A0BA4 File Offset: 0x0009EDA4
		public static byte[] EncodeUint8(byte val)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint8((int)val);
			byte[] extensionData = new byte[1];
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(val, extensionData, 0);
			return extensionData;
		}

		// Token: 0x06002535 RID: 9525 RVA: 0x000A0BC8 File Offset: 0x0009EDC8
		public static byte[] EncodeUint8ArrayWithUint8Length(byte[] uints)
		{
			byte[] result = new byte[1 + uints.Length];
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8ArrayWithUint8Length(uints, result, 0);
			return result;
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x000A0BEC File Offset: 0x0009EDEC
		public static byte[] EncodeUint16ArrayWithUint16Length(int[] uints)
		{
			int length = 2 * uints.Length;
			byte[] result = new byte[2 + length];
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16ArrayWithUint16Length(uints, result, 0);
			return result;
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x000A0C11 File Offset: 0x0009EE11
		public static byte ReadUint8(global::System.IO.Stream input)
		{
			int num = input.ReadByte();
			if (num < 0)
			{
				throw new global::System.IO.EndOfStreamException();
			}
			return (byte)num;
		}

		// Token: 0x06002538 RID: 9528 RVA: 0x000A0C24 File Offset: 0x0009EE24
		public static byte ReadUint8(byte[] buf, int offset)
		{
			return buf[offset];
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x000A0C2C File Offset: 0x0009EE2C
		public static int ReadUint16(global::System.IO.Stream input)
		{
			int num = input.ReadByte();
			int i2 = input.ReadByte();
			if (i2 < 0)
			{
				throw new global::System.IO.EndOfStreamException();
			}
			return num << 8 | i2;
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x000A0C54 File Offset: 0x0009EE54
		public static int ReadUint16(byte[] buf, int offset)
		{
			return (int)buf[offset] << 8 | (int)buf[++offset];
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x000A0C64 File Offset: 0x0009EE64
		public static int ReadUint24(global::System.IO.Stream input)
		{
			int num = input.ReadByte();
			int i2 = input.ReadByte();
			int i3 = input.ReadByte();
			if (i3 < 0)
			{
				throw new global::System.IO.EndOfStreamException();
			}
			return num << 16 | i2 << 8 | i3;
		}

		// Token: 0x0600253C RID: 9532 RVA: 0x000A0C98 File Offset: 0x0009EE98
		public static int ReadUint24(byte[] buf, int offset)
		{
			return (int)buf[offset] << 16 | (int)buf[++offset] << 8 | (int)buf[++offset];
		}

		// Token: 0x0600253D RID: 9533 RVA: 0x000A0CB4 File Offset: 0x0009EEB4
		public static long ReadUint32(global::System.IO.Stream input)
		{
			int num = input.ReadByte();
			int i2 = input.ReadByte();
			int i3 = input.ReadByte();
			int i4 = input.ReadByte();
			if (i4 < 0)
			{
				throw new global::System.IO.EndOfStreamException();
			}
			return (long)((ulong)(num << 24 | i2 << 16 | i3 << 8 | i4));
		}

		// Token: 0x0600253E RID: 9534 RVA: 0x000A0CF5 File Offset: 0x0009EEF5
		public static long ReadUint32(byte[] buf, int offset)
		{
			return (long)((ulong)((int)buf[offset] << 24 | (int)buf[++offset] << 16 | (int)buf[++offset] << 8 | (int)buf[++offset]));
		}

		// Token: 0x0600253F RID: 9535 RVA: 0x000A0D20 File Offset: 0x0009EF20
		public static long ReadUint48(global::System.IO.Stream input)
		{
			long num = (long)global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint24(input);
			int lo = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint24(input);
			return (num & (long)((ulong)-1)) << 24 | ((long)lo & (long)((ulong)-1));
		}

		// Token: 0x06002540 RID: 9536 RVA: 0x000A0D48 File Offset: 0x0009EF48
		public static long ReadUint48(byte[] buf, int offset)
		{
			long num = (long)global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint24(buf, offset);
			int lo = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint24(buf, offset + 3);
			return (num & (long)((ulong)-1)) << 24 | ((long)lo & (long)((ulong)-1));
		}

		// Token: 0x06002541 RID: 9537 RVA: 0x000A0D74 File Offset: 0x0009EF74
		public static byte[] ReadAllOrNothing(int length, global::System.IO.Stream input)
		{
			if (length < 1)
			{
				return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes;
			}
			byte[] buf = new byte[length];
			int read = global::Org.BouncyCastle.Utilities.IO.Streams.ReadFully(input, buf);
			if (read == 0)
			{
				return null;
			}
			if (read != length)
			{
				throw new global::System.IO.EndOfStreamException();
			}
			return buf;
		}

		// Token: 0x06002542 RID: 9538 RVA: 0x000A0DAC File Offset: 0x0009EFAC
		public static byte[] ReadFully(int length, global::System.IO.Stream input)
		{
			if (length < 1)
			{
				return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes;
			}
			byte[] buf = new byte[length];
			if (length != global::Org.BouncyCastle.Utilities.IO.Streams.ReadFully(input, buf))
			{
				throw new global::System.IO.EndOfStreamException();
			}
			return buf;
		}

		// Token: 0x06002543 RID: 9539 RVA: 0x000A0DDB File Offset: 0x0009EFDB
		public static void ReadFully(byte[] buf, global::System.IO.Stream input)
		{
			if (global::Org.BouncyCastle.Utilities.IO.Streams.ReadFully(input, buf, 0, buf.Length) < buf.Length)
			{
				throw new global::System.IO.EndOfStreamException();
			}
		}

		// Token: 0x06002544 RID: 9540 RVA: 0x000A0DF3 File Offset: 0x0009EFF3
		public static byte[] ReadOpaque8(global::System.IO.Stream input)
		{
			byte[] array = new byte[(int)global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(input)];
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadFully(array, input);
			return array;
		}

		// Token: 0x06002545 RID: 9541 RVA: 0x000A0E07 File Offset: 0x0009F007
		public static byte[] ReadOpaque16(global::System.IO.Stream input)
		{
			byte[] array = new byte[global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(input)];
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadFully(array, input);
			return array;
		}

		// Token: 0x06002546 RID: 9542 RVA: 0x000A0E1B File Offset: 0x0009F01B
		public static byte[] ReadOpaque24(global::System.IO.Stream input)
		{
			return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadFully(global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint24(input), input);
		}

		// Token: 0x06002547 RID: 9543 RVA: 0x000A0E2C File Offset: 0x0009F02C
		public static byte[] ReadUint8Array(int count, global::System.IO.Stream input)
		{
			byte[] uints = new byte[count];
			for (int i = 0; i < count; i++)
			{
				uints[i] = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(input);
			}
			return uints;
		}

		// Token: 0x06002548 RID: 9544 RVA: 0x000A0E58 File Offset: 0x0009F058
		public static int[] ReadUint16Array(int count, global::System.IO.Stream input)
		{
			int[] uints = new int[count];
			for (int i = 0; i < count; i++)
			{
				uints[i] = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(input);
			}
			return uints;
		}

		// Token: 0x06002549 RID: 9545 RVA: 0x000A0E82 File Offset: 0x0009F082
		public static global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion ReadVersion(byte[] buf, int offset)
		{
			return global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion.Get((int)buf[offset], (int)buf[offset + 1]);
		}

		// Token: 0x0600254A RID: 9546 RVA: 0x000A0E94 File Offset: 0x0009F094
		public static global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion ReadVersion(global::System.IO.Stream input)
		{
			int major = input.ReadByte();
			int i2 = input.ReadByte();
			if (i2 < 0)
			{
				throw new global::System.IO.EndOfStreamException();
			}
			return global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion.Get(major, i2);
		}

		// Token: 0x0600254B RID: 9547 RVA: 0x000A0EBE File Offset: 0x0009F0BE
		public static int ReadVersionRaw(byte[] buf, int offset)
		{
			return (int)buf[offset] << 8 | (int)buf[offset + 1];
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x000A0ECC File Offset: 0x0009F0CC
		public static int ReadVersionRaw(global::System.IO.Stream input)
		{
			int num = input.ReadByte();
			int i2 = input.ReadByte();
			if (i2 < 0)
			{
				throw new global::System.IO.EndOfStreamException();
			}
			return num << 8 | i2;
		}

		// Token: 0x0600254D RID: 9549 RVA: 0x000A0EF4 File Offset: 0x0009F0F4
		public static global::Org.BouncyCastle.Asn1.Asn1Object ReadAsn1Object(byte[] encoding)
		{
			global::System.IO.MemoryStream input = new global::System.IO.MemoryStream(encoding, false);
			global::Org.BouncyCastle.Asn1.Asn1Object result = new global::Org.BouncyCastle.Asn1.Asn1InputStream(input, encoding.Length).ReadObject();
			if (result == null)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(50);
			}
			if (input.Position != input.Length)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(50);
			}
			return result;
		}

		// Token: 0x0600254E RID: 9550 RVA: 0x000A0F3A File Offset: 0x0009F13A
		public static global::Org.BouncyCastle.Asn1.Asn1Object ReadDerObject(byte[] encoding)
		{
			global::Org.BouncyCastle.Asn1.Asn1Object asn1Object = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadAsn1Object(encoding);
			if (!global::Org.BouncyCastle.Utilities.Arrays.AreEqual(asn1Object.GetEncoded("DER"), encoding))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(50);
			}
			return asn1Object;
		}

		// Token: 0x0600254F RID: 9551 RVA: 0x000A0F60 File Offset: 0x0009F160
		public static void WriteGmtUnixTime(byte[] buf, int offset)
		{
			int t = (int)(global::Org.BouncyCastle.Utilities.Date.DateTimeUtilities.CurrentUnixMs() / 1000L);
			buf[offset] = (byte)(t >> 24);
			buf[offset + 1] = (byte)(t >> 16);
			buf[offset + 2] = (byte)(t >> 8);
			buf[offset + 3] = (byte)t;
		}

		// Token: 0x06002550 RID: 9552 RVA: 0x000A0F9D File Offset: 0x0009F19D
		public static void WriteVersion(global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion version, global::System.IO.Stream output)
		{
			output.WriteByte((byte)version.MajorVersion);
			output.WriteByte((byte)version.MinorVersion);
		}

		// Token: 0x06002551 RID: 9553 RVA: 0x000A0FB9 File Offset: 0x0009F1B9
		public static void WriteVersion(global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion version, byte[] buf, int offset)
		{
			buf[offset] = (byte)version.MajorVersion;
			buf[offset + 1] = (byte)version.MinorVersion;
		}

		// Token: 0x06002552 RID: 9554 RVA: 0x000A0FD1 File Offset: 0x0009F1D1
		public static global::System.Collections.IList GetAllSignatureAlgorithms()
		{
			global::System.Collections.IList list = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(4);
			list.Add(0);
			list.Add(1);
			list.Add(2);
			list.Add(3);
			return list;
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x000A100D File Offset: 0x0009F20D
		public static global::System.Collections.IList GetDefaultDssSignatureAlgorithms()
		{
			return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.VectorOfOne(new global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm(2, 2));
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x000A101B File Offset: 0x0009F21B
		public static global::System.Collections.IList GetDefaultECDsaSignatureAlgorithms()
		{
			return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.VectorOfOne(new global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm(2, 3));
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x000A1029 File Offset: 0x0009F229
		public static global::System.Collections.IList GetDefaultRsaSignatureAlgorithms()
		{
			return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.VectorOfOne(new global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm(2, 1));
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x000A1037 File Offset: 0x0009F237
		public static byte[] GetExtensionData(global::System.Collections.IDictionary extensions, int extensionType)
		{
			if (extensions != null)
			{
				return (byte[])extensions[extensionType];
			}
			return null;
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x000A1050 File Offset: 0x0009F250
		public static global::System.Collections.IList GetDefaultSupportedSignatureAlgorithms()
		{
			byte[] hashAlgorithms = new byte[]
			{
				2,
				3,
				4,
				5,
				6
			};
			byte[] signatureAlgorithms = new byte[]
			{
				1,
				2,
				3
			};
			global::System.Collections.IList result = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();
			for (int i = 0; i < signatureAlgorithms.Length; i++)
			{
				for (int j = 0; j < hashAlgorithms.Length; j++)
				{
					result.Add(new global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm(hashAlgorithms[j], signatureAlgorithms[i]));
				}
			}
			return result;
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x000A10BC File Offset: 0x0009F2BC
		public static global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm GetSignatureAndHashAlgorithm(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, global::Org.BouncyCastle.Crypto.Tls.TlsSignerCredentials signerCredentials)
		{
			global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm signatureAndHashAlgorithm = null;
			if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTlsV12(context))
			{
				signatureAndHashAlgorithm = signerCredentials.SignatureAndHashAlgorithm;
				if (signatureAndHashAlgorithm == null)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
				}
			}
			return signatureAndHashAlgorithm;
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x000A10E8 File Offset: 0x0009F2E8
		public static bool HasExpectedEmptyExtensionData(global::System.Collections.IDictionary extensions, int extensionType, byte alertDescription)
		{
			byte[] extension_data = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions, extensionType);
			if (extension_data == null)
			{
				return false;
			}
			if (extension_data.Length != 0)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription);
			}
			return true;
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x000A110E File Offset: 0x0009F30E
		public static global::Org.BouncyCastle.Crypto.Tls.TlsSession ImportSession(byte[] sessionID, global::Org.BouncyCastle.Crypto.Tls.SessionParameters sessionParameters)
		{
			return new global::Org.BouncyCastle.Crypto.Tls.TlsSessionImpl(sessionID, sessionParameters);
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x000A1117 File Offset: 0x0009F317
		public static bool IsSignatureAlgorithmsExtensionAllowed(global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion clientVersion)
		{
			return global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion.TLSv12.IsEqualOrEarlierVersionOf(clientVersion.GetEquivalentTLSVersion());
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x000A1129 File Offset: 0x0009F329
		public static void AddSignatureAlgorithmsExtension(global::System.Collections.IDictionary extensions, global::System.Collections.IList supportedSignatureAlgorithms)
		{
			extensions[13] = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateSignatureAlgorithmsExtension(supportedSignatureAlgorithms);
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x000A1140 File Offset: 0x0009F340
		public static global::System.Collections.IList GetSignatureAlgorithmsExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions, 13);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadSignatureAlgorithmsExtension(extensionData);
			}
			return null;
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x000A1164 File Offset: 0x0009F364
		public static byte[] CreateSignatureAlgorithmsExtension(global::System.Collections.IList supportedSignatureAlgorithms)
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EncodeSupportedSignatureAlgorithms(supportedSignatureAlgorithms, false, buf);
			return buf.ToArray();
		}

		// Token: 0x0600255F RID: 9567 RVA: 0x000A1188 File Offset: 0x0009F388
		public static global::System.Collections.IList ReadSignatureAlgorithmsExtension(byte[] extensionData)
		{
			if (extensionData == null)
			{
				throw new global::System.ArgumentNullException("extensionData");
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream(extensionData, false);
			global::System.Collections.IList result = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ParseSupportedSignatureAlgorithms(false, buf);
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(buf);
			return result;
		}

		// Token: 0x06002560 RID: 9568 RVA: 0x000A11B8 File Offset: 0x0009F3B8
		public static void EncodeSupportedSignatureAlgorithms(global::System.Collections.IList supportedSignatureAlgorithms, bool allowAnonymous, global::System.IO.Stream output)
		{
			if (supportedSignatureAlgorithms == null)
			{
				throw new global::System.ArgumentNullException("supportedSignatureAlgorithms");
			}
			if (supportedSignatureAlgorithms.Count < 1 || supportedSignatureAlgorithms.Count >= 32768)
			{
				throw new global::System.ArgumentException("must have length from 1 to (2^15 - 1)", "supportedSignatureAlgorithms");
			}
			int i = 2 * supportedSignatureAlgorithms.Count;
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint16(i);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(i, output);
			foreach (object obj in supportedSignatureAlgorithms)
			{
				global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm entry = (global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm)obj;
				if (!allowAnonymous && entry.Signature == 0)
				{
					throw new global::System.ArgumentException("SignatureAlgorithm.anonymous MUST NOT appear in the signature_algorithms extension");
				}
				entry.Encode(output);
			}
		}

		// Token: 0x06002561 RID: 9569 RVA: 0x000A126C File Offset: 0x0009F46C
		public static global::System.Collections.IList ParseSupportedSignatureAlgorithms(bool allowAnonymous, global::System.IO.Stream input)
		{
			int length = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(input);
			if (length < 2 || (length & 1) != 0)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(50);
			}
			int count = length / 2;
			global::System.Collections.IList supportedSignatureAlgorithms = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(count);
			for (int i = 0; i < count; i++)
			{
				global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm entry = global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm.Parse(input);
				if (!allowAnonymous && entry.Signature == 0)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
				}
				supportedSignatureAlgorithms.Add(entry);
			}
			return supportedSignatureAlgorithms;
		}

		// Token: 0x06002562 RID: 9570 RVA: 0x000A12D0 File Offset: 0x0009F4D0
		public static void VerifySupportedSignatureAlgorithm(global::System.Collections.IList supportedSignatureAlgorithms, global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm signatureAlgorithm)
		{
			if (supportedSignatureAlgorithms == null)
			{
				throw new global::System.ArgumentNullException("supportedSignatureAlgorithms");
			}
			if (supportedSignatureAlgorithms.Count < 1 || supportedSignatureAlgorithms.Count >= 32768)
			{
				throw new global::System.ArgumentException("must have length from 1 to (2^15 - 1)", "supportedSignatureAlgorithms");
			}
			if (signatureAlgorithm == null)
			{
				throw new global::System.ArgumentNullException("signatureAlgorithm");
			}
			if (signatureAlgorithm.Signature != 0)
			{
				foreach (object obj in supportedSignatureAlgorithms)
				{
					global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm entry = (global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm)obj;
					if (entry.Hash == signatureAlgorithm.Hash && entry.Signature == signatureAlgorithm.Signature)
					{
						return;
					}
				}
			}
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
		}

		// Token: 0x06002563 RID: 9571 RVA: 0x000A1390 File Offset: 0x0009F590
		public static byte[] PRF(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, byte[] secret, string asciiLabel, byte[] seed, int size)
		{
			if (context.ServerVersion.IsSsl)
			{
				throw new global::System.InvalidOperationException("No PRF available for SSLv3 session");
			}
			byte[] label = global::Org.BouncyCastle.Utilities.Strings.ToByteArray(asciiLabel);
			byte[] labelSeed = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.Concat(label, seed);
			int prfAlgorithm = context.SecurityParameters.PrfAlgorithm;
			if (prfAlgorithm == 0)
			{
				return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.PRF_legacy(secret, label, labelSeed, size);
			}
			global::Org.BouncyCastle.Crypto.IDigest digest = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreatePrfHash(prfAlgorithm);
			byte[] buf = new byte[size];
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.HMacHash(digest, secret, labelSeed, buf);
			return buf;
		}

		// Token: 0x06002564 RID: 9572 RVA: 0x000A13F8 File Offset: 0x0009F5F8
		public static byte[] PRF_legacy(byte[] secret, string asciiLabel, byte[] seed, int size)
		{
			byte[] label = global::Org.BouncyCastle.Utilities.Strings.ToByteArray(asciiLabel);
			byte[] labelSeed = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.Concat(label, seed);
			return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.PRF_legacy(secret, label, labelSeed, size);
		}

		// Token: 0x06002565 RID: 9573 RVA: 0x000A1420 File Offset: 0x0009F620
		internal static byte[] PRF_legacy(byte[] secret, byte[] label, byte[] labelSeed, int size)
		{
			int s_half = (secret.Length + 1) / 2;
			byte[] s = new byte[s_half];
			byte[] s2 = new byte[s_half];
			global::System.Array.Copy(secret, 0, s, 0, s_half);
			global::System.Array.Copy(secret, secret.Length - s_half, s2, 0, s_half);
			byte[] b = new byte[size];
			byte[] b2 = new byte[size];
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.HMacHash(global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(1), s, labelSeed, b);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.HMacHash(global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(2), s2, labelSeed, b2);
			for (int i = 0; i < size; i++)
			{
				byte[] array = b;
				int num = i;
				array[num] ^= b2[i];
			}
			return b;
		}

		// Token: 0x06002566 RID: 9574 RVA: 0x000A14AC File Offset: 0x0009F6AC
		internal static byte[] Concat(byte[] a, byte[] b)
		{
			byte[] c = new byte[a.Length + b.Length];
			global::System.Array.Copy(a, 0, c, 0, a.Length);
			global::System.Array.Copy(b, 0, c, a.Length, b.Length);
			return c;
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x000A14E4 File Offset: 0x0009F6E4
		internal static void HMacHash(global::Org.BouncyCastle.Crypto.IDigest digest, byte[] secret, byte[] seed, byte[] output)
		{
			global::Org.BouncyCastle.Crypto.Macs.HMac mac = new global::Org.BouncyCastle.Crypto.Macs.HMac(digest);
			mac.Init(new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(secret));
			byte[] a = seed;
			int size = digest.GetDigestSize();
			int iterations = (output.Length + size - 1) / size;
			byte[] buf = new byte[mac.GetMacSize()];
			byte[] buf2 = new byte[mac.GetMacSize()];
			for (int i = 0; i < iterations; i++)
			{
				mac.BlockUpdate(a, 0, a.Length);
				mac.DoFinal(buf, 0);
				a = buf;
				mac.BlockUpdate(a, 0, a.Length);
				mac.BlockUpdate(seed, 0, seed.Length);
				mac.DoFinal(buf2, 0);
				global::System.Array.Copy(buf2, 0, output, size * i, global::System.Math.Min(size, output.Length - size * i));
			}
		}

		// Token: 0x06002568 RID: 9576 RVA: 0x000A1594 File Offset: 0x0009F794
		internal static void ValidateKeyUsage(global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure c, int keyUsageBits)
		{
			global::Org.BouncyCastle.Asn1.X509.X509Extensions exts = c.TbsCertificate.Extensions;
			if (exts != null)
			{
				global::Org.BouncyCastle.Asn1.X509.X509Extension ext = exts.GetExtension(global::Org.BouncyCastle.Asn1.X509.X509Extensions.KeyUsage);
				if (ext != null && ((int)global::Org.BouncyCastle.Asn1.X509.KeyUsage.GetInstance(ext).GetBytes()[0] & keyUsageBits) != keyUsageBits)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(46);
				}
			}
		}

		// Token: 0x06002569 RID: 9577 RVA: 0x000A15DC File Offset: 0x0009F7DC
		internal static byte[] CalculateKeyBlock(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, int size)
		{
			global::Org.BouncyCastle.Crypto.Tls.SecurityParameters securityParameters = context.SecurityParameters;
			byte[] master_secret = securityParameters.MasterSecret;
			byte[] seed = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.Concat(securityParameters.ServerRandom, securityParameters.ClientRandom);
			if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSsl(context))
			{
				return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CalculateKeyBlock_Ssl(master_secret, seed, size);
			}
			return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.PRF(context, master_secret, "key expansion", seed, size);
		}

		// Token: 0x0600256A RID: 9578 RVA: 0x000A1628 File Offset: 0x0009F828
		internal static byte[] CalculateKeyBlock_Ssl(byte[] master_secret, byte[] random, int size)
		{
			global::Org.BouncyCastle.Crypto.IDigest md5 = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(1);
			global::Org.BouncyCastle.Crypto.IDigest sha = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(2);
			int md5Size = md5.GetDigestSize();
			byte[] shatmp = new byte[sha.GetDigestSize()];
			byte[] tmp = new byte[size + md5Size];
			int i = 0;
			int pos = 0;
			while (pos < size)
			{
				byte[] ssl3Const = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.SSL3_CONST[i];
				sha.BlockUpdate(ssl3Const, 0, ssl3Const.Length);
				sha.BlockUpdate(master_secret, 0, master_secret.Length);
				sha.BlockUpdate(random, 0, random.Length);
				sha.DoFinal(shatmp, 0);
				md5.BlockUpdate(master_secret, 0, master_secret.Length);
				md5.BlockUpdate(shatmp, 0, shatmp.Length);
				md5.DoFinal(tmp, pos);
				pos += md5Size;
				i++;
			}
			return global::Org.BouncyCastle.Utilities.Arrays.CopyOfRange(tmp, 0, size);
		}

		// Token: 0x0600256B RID: 9579 RVA: 0x000A16DC File Offset: 0x0009F8DC
		internal static byte[] CalculateMasterSecret(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, byte[] pre_master_secret)
		{
			global::Org.BouncyCastle.Crypto.Tls.SecurityParameters securityParameters = context.SecurityParameters;
			byte[] seed = securityParameters.IsExtendedMasterSecret ? securityParameters.SessionHash : global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.Concat(securityParameters.ClientRandom, securityParameters.ServerRandom);
			if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSsl(context))
			{
				return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CalculateMasterSecret_Ssl(pre_master_secret, seed);
			}
			string asciiLabel = securityParameters.IsExtendedMasterSecret ? global::Org.BouncyCastle.Crypto.Tls.ExporterLabel.extended_master_secret : "master secret";
			return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.PRF(context, pre_master_secret, asciiLabel, seed, 48);
		}

		// Token: 0x0600256C RID: 9580 RVA: 0x000A1744 File Offset: 0x0009F944
		internal static byte[] CalculateMasterSecret_Ssl(byte[] pre_master_secret, byte[] random)
		{
			global::Org.BouncyCastle.Crypto.IDigest md5 = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(1);
			global::Org.BouncyCastle.Crypto.IDigest sha = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(2);
			int md5Size = md5.GetDigestSize();
			byte[] shatmp = new byte[sha.GetDigestSize()];
			byte[] rval = new byte[md5Size * 3];
			int pos = 0;
			for (int i = 0; i < 3; i++)
			{
				byte[] ssl3Const = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.SSL3_CONST[i];
				sha.BlockUpdate(ssl3Const, 0, ssl3Const.Length);
				sha.BlockUpdate(pre_master_secret, 0, pre_master_secret.Length);
				sha.BlockUpdate(random, 0, random.Length);
				sha.DoFinal(shatmp, 0);
				md5.BlockUpdate(pre_master_secret, 0, pre_master_secret.Length);
				md5.BlockUpdate(shatmp, 0, shatmp.Length);
				md5.DoFinal(rval, pos);
				pos += md5Size;
			}
			return rval;
		}

		// Token: 0x0600256D RID: 9581 RVA: 0x000A17F0 File Offset: 0x0009F9F0
		internal static byte[] CalculateVerifyData(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, string asciiLabel, byte[] handshakeHash)
		{
			if (global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSsl(context))
			{
				return handshakeHash;
			}
			global::Org.BouncyCastle.Crypto.Tls.SecurityParameters securityParameters = context.SecurityParameters;
			byte[] master_secret = securityParameters.MasterSecret;
			int verify_data_length = securityParameters.VerifyDataLength;
			return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.PRF(context, master_secret, asciiLabel, handshakeHash, verify_data_length);
		}

		// Token: 0x0600256E RID: 9582 RVA: 0x000A1824 File Offset: 0x0009FA24
		public static global::Org.BouncyCastle.Crypto.IDigest CreateHash(byte hashAlgorithm)
		{
			switch (hashAlgorithm)
			{
			case 1:
				return new global::Org.BouncyCastle.Crypto.Digests.MD5Digest();
			case 2:
				return new global::Org.BouncyCastle.Crypto.Digests.Sha1Digest();
			case 3:
				return new global::Org.BouncyCastle.Crypto.Digests.Sha224Digest();
			case 4:
				return new global::Org.BouncyCastle.Crypto.Digests.Sha256Digest();
			case 5:
				return new global::Org.BouncyCastle.Crypto.Digests.Sha384Digest();
			case 6:
				return new global::Org.BouncyCastle.Crypto.Digests.Sha512Digest();
			default:
				throw new global::System.ArgumentException("unknown HashAlgorithm", "hashAlgorithm");
			}
		}

		// Token: 0x0600256F RID: 9583 RVA: 0x000A1888 File Offset: 0x0009FA88
		public static global::Org.BouncyCastle.Crypto.IDigest CreateHash(global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm signatureAndHashAlgorithm)
		{
			if (signatureAndHashAlgorithm != null)
			{
				return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(signatureAndHashAlgorithm.Hash);
			}
			return new global::Org.BouncyCastle.Crypto.Tls.CombinedHash();
		}

		// Token: 0x06002570 RID: 9584 RVA: 0x000A18AC File Offset: 0x0009FAAC
		public static global::Org.BouncyCastle.Crypto.IDigest CloneHash(byte hashAlgorithm, global::Org.BouncyCastle.Crypto.IDigest hash)
		{
			switch (hashAlgorithm)
			{
			case 1:
				return new global::Org.BouncyCastle.Crypto.Digests.MD5Digest((global::Org.BouncyCastle.Crypto.Digests.MD5Digest)hash);
			case 2:
				return new global::Org.BouncyCastle.Crypto.Digests.Sha1Digest((global::Org.BouncyCastle.Crypto.Digests.Sha1Digest)hash);
			case 3:
				return new global::Org.BouncyCastle.Crypto.Digests.Sha224Digest((global::Org.BouncyCastle.Crypto.Digests.Sha224Digest)hash);
			case 4:
				return new global::Org.BouncyCastle.Crypto.Digests.Sha256Digest((global::Org.BouncyCastle.Crypto.Digests.Sha256Digest)hash);
			case 5:
				return new global::Org.BouncyCastle.Crypto.Digests.Sha384Digest((global::Org.BouncyCastle.Crypto.Digests.Sha384Digest)hash);
			case 6:
				return new global::Org.BouncyCastle.Crypto.Digests.Sha512Digest((global::Org.BouncyCastle.Crypto.Digests.Sha512Digest)hash);
			default:
				throw new global::System.ArgumentException("unknown HashAlgorithm", "hashAlgorithm");
			}
		}

		// Token: 0x06002571 RID: 9585 RVA: 0x000A1932 File Offset: 0x0009FB32
		public static global::Org.BouncyCastle.Crypto.IDigest CreatePrfHash(int prfAlgorithm)
		{
			if (prfAlgorithm == 0)
			{
				return new global::Org.BouncyCastle.Crypto.Tls.CombinedHash();
			}
			return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetHashAlgorithmForPrfAlgorithm(prfAlgorithm));
		}

		// Token: 0x06002572 RID: 9586 RVA: 0x000A1948 File Offset: 0x0009FB48
		public static global::Org.BouncyCastle.Crypto.IDigest ClonePrfHash(int prfAlgorithm, global::Org.BouncyCastle.Crypto.IDigest hash)
		{
			if (prfAlgorithm == 0)
			{
				return new global::Org.BouncyCastle.Crypto.Tls.CombinedHash((global::Org.BouncyCastle.Crypto.Tls.CombinedHash)hash);
			}
			return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CloneHash(global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetHashAlgorithmForPrfAlgorithm(prfAlgorithm), hash);
		}

		// Token: 0x06002573 RID: 9587 RVA: 0x000A1965 File Offset: 0x0009FB65
		public static byte GetHashAlgorithmForPrfAlgorithm(int prfAlgorithm)
		{
			switch (prfAlgorithm)
			{
			case 0:
				throw new global::System.ArgumentException("legacy PRF not a valid algorithm", "prfAlgorithm");
			case 1:
				return 4;
			case 2:
				return 5;
			default:
				throw new global::System.ArgumentException("unknown PrfAlgorithm", "prfAlgorithm");
			}
		}

		// Token: 0x06002574 RID: 9588 RVA: 0x000A19A0 File Offset: 0x0009FBA0
		public static global::Org.BouncyCastle.Asn1.DerObjectIdentifier GetOidForHashAlgorithm(byte hashAlgorithm)
		{
			switch (hashAlgorithm)
			{
			case 1:
				return global::Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5;
			case 2:
				return global::Org.BouncyCastle.Asn1.X509.X509ObjectIdentifiers.IdSha1;
			case 3:
				return global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha224;
			case 4:
				return global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256;
			case 5:
				return global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha384;
			case 6:
				return global::Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512;
			default:
				throw new global::System.ArgumentException("unknown HashAlgorithm", "hashAlgorithm");
			}
		}

		// Token: 0x06002575 RID: 9589 RVA: 0x000A1A04 File Offset: 0x0009FC04
		internal static short GetClientCertificateType(global::Org.BouncyCastle.Crypto.Tls.Certificate clientCertificate, global::Org.BouncyCastle.Crypto.Tls.Certificate serverCertificate)
		{
			if (clientCertificate.IsEmpty)
			{
				return -1;
			}
			global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure x509Cert = clientCertificate.GetCertificateAt(0);
			global::Org.BouncyCastle.Asn1.X509.SubjectPublicKeyInfo keyInfo = x509Cert.SubjectPublicKeyInfo;
			short result;
			try
			{
				global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter publicKey = global::Org.BouncyCastle.Security.PublicKeyFactory.CreateKey(keyInfo);
				if (publicKey.IsPrivate)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
				}
				if (publicKey is global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)
				{
					global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ValidateKeyUsage(x509Cert, 128);
					result = 1;
				}
				else if (publicKey is global::Org.BouncyCastle.Crypto.Parameters.DsaPublicKeyParameters)
				{
					global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ValidateKeyUsage(x509Cert, 128);
					result = 2;
				}
				else
				{
					if (!(publicKey is global::Org.BouncyCastle.Crypto.Parameters.ECPublicKeyParameters))
					{
						throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(43);
					}
					global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ValidateKeyUsage(x509Cert, 128);
					result = 64;
				}
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(43, e);
			}
			return result;
		}

		// Token: 0x06002576 RID: 9590 RVA: 0x000A1AAC File Offset: 0x0009FCAC
		internal static void TrackHashAlgorithms(global::Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash handshakeHash, global::System.Collections.IList supportedSignatureAlgorithms)
		{
			if (supportedSignatureAlgorithms != null)
			{
				foreach (object obj in supportedSignatureAlgorithms)
				{
					byte hashAlgorithm = ((global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm)obj).Hash;
					if (global::Org.BouncyCastle.Crypto.Tls.HashAlgorithm.IsRecognized(hashAlgorithm))
					{
						handshakeHash.TrackHashAlgorithm(hashAlgorithm);
					}
				}
			}
		}

		// Token: 0x06002577 RID: 9591 RVA: 0x000A1B10 File Offset: 0x0009FD10
		public static bool HasSigningCapability(byte clientCertificateType)
		{
			return clientCertificateType - 1 <= 1 || clientCertificateType == 64;
		}

		// Token: 0x06002578 RID: 9592 RVA: 0x000A1B20 File Offset: 0x0009FD20
		public static global::Org.BouncyCastle.Crypto.Tls.TlsSigner CreateTlsSigner(byte clientCertificateType)
		{
			if (clientCertificateType == 1)
			{
				return new global::Org.BouncyCastle.Crypto.Tls.TlsRsaSigner();
			}
			if (clientCertificateType == 2)
			{
				return new global::Org.BouncyCastle.Crypto.Tls.TlsDssSigner();
			}
			if (clientCertificateType != 64)
			{
				throw new global::System.ArgumentException("not a type with signing capability", "clientCertificateType");
			}
			return new global::Org.BouncyCastle.Crypto.Tls.TlsECDsaSigner();
		}

		// Token: 0x06002579 RID: 9593 RVA: 0x000A1B54 File Offset: 0x0009FD54
		private static byte[][] GenSsl3Const()
		{
			int i = 10;
			byte[][] arr = new byte[i][];
			for (int j = 0; j < i; j++)
			{
				byte[] b = new byte[j + 1];
				global::Org.BouncyCastle.Utilities.Arrays.Fill(b, (byte)(65 + j));
				arr[j] = b;
			}
			return arr;
		}

		// Token: 0x0600257A RID: 9594 RVA: 0x000A1B90 File Offset: 0x0009FD90
		private static global::System.Collections.IList VectorOfOne(object obj)
		{
			global::System.Collections.IList list = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(1);
			list.Add(obj);
			return list;
		}

		// Token: 0x0600257B RID: 9595 RVA: 0x000A1BA0 File Offset: 0x0009FDA0
		public static int GetCipherType(int ciphersuite)
		{
			int encryptionAlgorithm = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetEncryptionAlgorithm(ciphersuite);
			switch (encryptionAlgorithm)
			{
			case 0:
			case 1:
			case 2:
				return 0;
			case 3:
			case 4:
			case 5:
			case 6:
			case 7:
			case 8:
			case 9:
			case 12:
			case 13:
			case 14:
				return 1;
			case 10:
			case 11:
			case 15:
			case 16:
			case 17:
			case 18:
			case 19:
			case 20:
			case 21:
				break;
			default:
				if (encryptionAlgorithm - 103 > 1)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
				}
				break;
			}
			return 2;
		}

		// Token: 0x0600257C RID: 9596 RVA: 0x000A1C28 File Offset: 0x0009FE28
		public static int GetEncryptionAlgorithm(int ciphersuite)
		{
			switch (ciphersuite)
			{
			case 1:
				return 0;
			case 2:
			case 44:
			case 45:
			case 46:
				return 0;
			case 3:
			case 6:
			case 7:
			case 8:
			case 9:
			case 11:
			case 12:
			case 14:
			case 15:
			case 17:
			case 18:
			case 20:
			case 21:
			case 23:
			case 25:
			case 26:
			case 28:
			case 29:
			case 30:
			case 31:
			case 32:
			case 33:
			case 34:
			case 35:
			case 36:
			case 37:
			case 38:
			case 39:
			case 40:
			case 41:
			case 42:
			case 43:
			case 71:
			case 72:
			case 73:
			case 74:
			case 75:
			case 76:
			case 77:
			case 78:
			case 79:
			case 80:
			case 81:
			case 82:
			case 83:
			case 84:
			case 85:
			case 86:
			case 87:
			case 88:
			case 89:
			case 90:
			case 91:
			case 92:
			case 93:
			case 94:
			case 95:
			case 96:
			case 97:
			case 98:
			case 99:
			case 100:
			case 101:
			case 102:
			case 110:
			case 111:
			case 112:
			case 113:
			case 114:
			case 115:
			case 116:
			case 117:
			case 118:
			case 119:
			case 120:
			case 121:
			case 122:
			case 123:
			case 124:
			case 125:
			case 126:
			case 127:
			case 128:
			case 129:
			case 130:
			case 131:
				goto IL_627;
			case 4:
			case 24:
				return 2;
			case 5:
			case 138:
			case 142:
			case 146:
				return 2;
			case 10:
			case 13:
			case 16:
			case 19:
			case 22:
			case 27:
			case 139:
			case 143:
			case 147:
				break;
			case 47:
			case 48:
			case 49:
			case 50:
			case 51:
			case 52:
			case 60:
			case 62:
			case 63:
			case 64:
			case 103:
			case 108:
			case 140:
			case 144:
			case 148:
			case 174:
			case 178:
			case 182:
				return 8;
			case 53:
			case 54:
			case 55:
			case 56:
			case 57:
			case 58:
			case 61:
			case 104:
			case 105:
			case 106:
			case 107:
			case 109:
			case 141:
			case 145:
			case 149:
			case 175:
			case 179:
			case 183:
				return 9;
			case 59:
			case 176:
			case 180:
			case 184:
				return 0;
			case 65:
			case 66:
			case 67:
			case 68:
			case 69:
			case 70:
			case 186:
			case 187:
			case 188:
			case 189:
			case 190:
			case 191:
				return 12;
			case 132:
			case 133:
			case 134:
			case 135:
			case 136:
			case 137:
			case 192:
			case 193:
			case 194:
			case 195:
			case 196:
			case 197:
				return 13;
			case 150:
			case 151:
			case 152:
			case 153:
			case 154:
			case 155:
				return 14;
			case 156:
			case 158:
			case 160:
			case 162:
			case 164:
			case 166:
			case 168:
			case 170:
			case 172:
				return 10;
			case 157:
			case 159:
			case 161:
			case 163:
			case 165:
			case 167:
			case 169:
			case 171:
			case 173:
				return 11;
			case 177:
			case 181:
			case 185:
				return 0;
			default:
				switch (ciphersuite)
				{
				case 49153:
				case 49158:
				case 49163:
				case 49168:
				case 49173:
				case 49209:
					return 0;
				case 49154:
				case 49159:
				case 49164:
				case 49169:
				case 49174:
				case 49203:
					return 2;
				case 49155:
				case 49160:
				case 49165:
				case 49170:
				case 49175:
				case 49178:
				case 49179:
				case 49180:
				case 49204:
					break;
				case 49156:
				case 49161:
				case 49166:
				case 49171:
				case 49176:
				case 49181:
				case 49182:
				case 49183:
				case 49187:
				case 49189:
				case 49191:
				case 49193:
				case 49205:
				case 49207:
					return 8;
				case 49157:
				case 49162:
				case 49167:
				case 49172:
				case 49177:
				case 49184:
				case 49185:
				case 49186:
				case 49188:
				case 49190:
				case 49192:
				case 49194:
				case 49206:
				case 49208:
					return 9;
				case 49195:
				case 49197:
				case 49199:
				case 49201:
					return 10;
				case 49196:
				case 49198:
				case 49200:
				case 49202:
					return 11;
				case 49210:
					return 0;
				case 49211:
					return 0;
				case 49212:
				case 49213:
				case 49214:
				case 49215:
				case 49216:
				case 49217:
				case 49218:
				case 49219:
				case 49220:
				case 49221:
				case 49222:
				case 49223:
				case 49224:
				case 49225:
				case 49226:
				case 49227:
				case 49228:
				case 49229:
				case 49230:
				case 49231:
				case 49232:
				case 49233:
				case 49234:
				case 49235:
				case 49236:
				case 49237:
				case 49238:
				case 49239:
				case 49240:
				case 49241:
				case 49242:
				case 49243:
				case 49244:
				case 49245:
				case 49246:
				case 49247:
				case 49248:
				case 49249:
				case 49250:
				case 49251:
				case 49252:
				case 49253:
				case 49254:
				case 49255:
				case 49256:
				case 49257:
				case 49258:
				case 49259:
				case 49260:
				case 49261:
				case 49262:
				case 49263:
				case 49264:
				case 49265:
					goto IL_627;
				case 49266:
				case 49268:
				case 49270:
				case 49272:
				case 49300:
				case 49302:
				case 49304:
				case 49306:
					return 12;
				case 49267:
				case 49269:
				case 49271:
				case 49273:
				case 49301:
				case 49303:
				case 49305:
				case 49307:
					return 13;
				case 49274:
				case 49276:
				case 49278:
				case 49280:
				case 49282:
				case 49284:
				case 49286:
				case 49288:
				case 49290:
				case 49292:
				case 49294:
				case 49296:
				case 49298:
					return 19;
				case 49275:
				case 49277:
				case 49279:
				case 49281:
				case 49283:
				case 49285:
				case 49287:
				case 49289:
				case 49291:
				case 49293:
				case 49295:
				case 49297:
				case 49299:
					return 20;
				case 49308:
				case 49310:
				case 49316:
				case 49318:
				case 49324:
					return 15;
				case 49309:
				case 49311:
				case 49317:
				case 49319:
				case 49325:
					return 17;
				case 49312:
				case 49314:
				case 49320:
				case 49322:
				case 49326:
					return 16;
				case 49313:
				case 49315:
				case 49321:
				case 49323:
				case 49327:
					return 18;
				default:
					if (ciphersuite - 52392 > 6)
					{
						goto IL_627;
					}
					return 21;
				}
				break;
			}
			return 7;
			IL_627:
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
		}

		// Token: 0x0600257D RID: 9597 RVA: 0x000A2264 File Offset: 0x000A0464
		public static int GetKeyExchangeAlgorithm(int ciphersuite)
		{
			switch (ciphersuite)
			{
			case 1:
			case 2:
			case 4:
			case 5:
			case 10:
			case 47:
			case 53:
			case 59:
			case 60:
			case 61:
			case 65:
			case 132:
			case 150:
			case 156:
			case 157:
			case 186:
			case 192:
				return 1;
			case 3:
			case 6:
			case 7:
			case 8:
			case 9:
			case 11:
			case 12:
			case 14:
			case 15:
			case 17:
			case 18:
			case 20:
			case 21:
			case 23:
			case 25:
			case 26:
			case 28:
			case 29:
			case 30:
			case 31:
			case 32:
			case 33:
			case 34:
			case 35:
			case 36:
			case 37:
			case 38:
			case 39:
			case 40:
			case 41:
			case 42:
			case 43:
			case 71:
			case 72:
			case 73:
			case 74:
			case 75:
			case 76:
			case 77:
			case 78:
			case 79:
			case 80:
			case 81:
			case 82:
			case 83:
			case 84:
			case 85:
			case 86:
			case 87:
			case 88:
			case 89:
			case 90:
			case 91:
			case 92:
			case 93:
			case 94:
			case 95:
			case 96:
			case 97:
			case 98:
			case 99:
			case 100:
			case 101:
			case 102:
			case 110:
			case 111:
			case 112:
			case 113:
			case 114:
			case 115:
			case 116:
			case 117:
			case 118:
			case 119:
			case 120:
			case 121:
			case 122:
			case 123:
			case 124:
			case 125:
			case 126:
			case 127:
			case 128:
			case 129:
			case 130:
			case 131:
				goto IL_640;
			case 13:
			case 48:
			case 54:
			case 62:
			case 66:
			case 104:
			case 133:
			case 151:
			case 164:
			case 165:
			case 187:
			case 193:
				return 7;
			case 16:
			case 49:
			case 55:
			case 63:
			case 67:
			case 105:
			case 134:
			case 152:
			case 160:
			case 161:
			case 188:
			case 194:
				return 9;
			case 19:
			case 50:
			case 56:
			case 64:
			case 68:
			case 106:
			case 135:
			case 153:
			case 162:
			case 163:
			case 189:
			case 195:
				return 3;
			case 22:
			case 51:
			case 57:
			case 69:
			case 103:
			case 107:
			case 136:
			case 154:
			case 158:
			case 159:
			case 190:
			case 196:
				return 5;
			case 24:
			case 27:
			case 52:
			case 58:
			case 70:
			case 108:
			case 109:
			case 137:
			case 155:
			case 166:
			case 167:
			case 191:
			case 197:
				break;
			case 44:
			case 138:
			case 139:
			case 140:
			case 141:
			case 168:
			case 169:
			case 174:
			case 175:
			case 176:
			case 177:
				return 13;
			case 45:
			case 142:
			case 143:
			case 144:
			case 145:
			case 170:
			case 171:
			case 178:
			case 179:
			case 180:
			case 181:
				return 14;
			case 46:
			case 146:
			case 147:
			case 148:
			case 149:
			case 172:
			case 173:
			case 182:
			case 183:
			case 184:
			case 185:
				return 15;
			default:
				switch (ciphersuite)
				{
				case 49153:
				case 49154:
				case 49155:
				case 49156:
				case 49157:
				case 49189:
				case 49190:
				case 49197:
				case 49198:
				case 49268:
				case 49269:
				case 49288:
				case 49289:
					return 16;
				case 49158:
				case 49159:
				case 49160:
				case 49161:
				case 49162:
				case 49187:
				case 49188:
				case 49195:
				case 49196:
				case 49266:
				case 49267:
				case 49286:
				case 49287:
				case 49324:
				case 49325:
				case 49326:
				case 49327:
					break;
				case 49163:
				case 49164:
				case 49165:
				case 49166:
				case 49167:
				case 49193:
				case 49194:
				case 49201:
				case 49202:
				case 49272:
				case 49273:
				case 49292:
				case 49293:
					return 18;
				case 49168:
				case 49169:
				case 49170:
				case 49171:
				case 49172:
				case 49191:
				case 49192:
				case 49199:
				case 49200:
				case 49270:
				case 49271:
				case 49290:
				case 49291:
					return 19;
				case 49173:
				case 49174:
				case 49175:
				case 49176:
				case 49177:
					return 20;
				case 49178:
				case 49181:
				case 49184:
					return 21;
				case 49179:
				case 49182:
				case 49185:
					return 23;
				case 49180:
				case 49183:
				case 49186:
					return 22;
				case 49203:
				case 49204:
				case 49205:
				case 49206:
				case 49207:
				case 49208:
				case 49209:
				case 49210:
				case 49211:
				case 49306:
				case 49307:
					return 24;
				case 49212:
				case 49213:
				case 49214:
				case 49215:
				case 49216:
				case 49217:
				case 49218:
				case 49219:
				case 49220:
				case 49221:
				case 49222:
				case 49223:
				case 49224:
				case 49225:
				case 49226:
				case 49227:
				case 49228:
				case 49229:
				case 49230:
				case 49231:
				case 49232:
				case 49233:
				case 49234:
				case 49235:
				case 49236:
				case 49237:
				case 49238:
				case 49239:
				case 49240:
				case 49241:
				case 49242:
				case 49243:
				case 49244:
				case 49245:
				case 49246:
				case 49247:
				case 49248:
				case 49249:
				case 49250:
				case 49251:
				case 49252:
				case 49253:
				case 49254:
				case 49255:
				case 49256:
				case 49257:
				case 49258:
				case 49259:
				case 49260:
				case 49261:
				case 49262:
				case 49263:
				case 49264:
				case 49265:
					goto IL_640;
				case 49274:
				case 49275:
				case 49308:
				case 49309:
				case 49312:
				case 49313:
					return 1;
				case 49276:
				case 49277:
				case 49310:
				case 49311:
				case 49314:
				case 49315:
					return 5;
				case 49278:
				case 49279:
					return 9;
				case 49280:
				case 49281:
					return 3;
				case 49282:
				case 49283:
					return 7;
				case 49284:
				case 49285:
					return 11;
				case 49294:
				case 49295:
				case 49300:
				case 49301:
				case 49316:
				case 49317:
				case 49320:
				case 49321:
					return 13;
				case 49296:
				case 49297:
				case 49302:
				case 49303:
				case 49318:
				case 49319:
				case 49322:
				case 49323:
					return 14;
				case 49298:
				case 49299:
				case 49304:
				case 49305:
					return 15;
				default:
					switch (ciphersuite)
					{
					case 52392:
						return 19;
					case 52393:
						break;
					case 52394:
						return 5;
					case 52395:
						return 13;
					case 52396:
						return 24;
					case 52397:
						return 14;
					case 52398:
						return 1;
					default:
						goto IL_640;
					}
					break;
				}
				return 17;
			}
			return 11;
			IL_640:
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
		}

		// Token: 0x0600257E RID: 9598 RVA: 0x000A28B8 File Offset: 0x000A0AB8
		public static int GetMacAlgorithm(int ciphersuite)
		{
			switch (ciphersuite)
			{
			case 1:
			case 4:
			case 24:
				return 1;
			case 2:
			case 5:
			case 10:
			case 13:
			case 16:
			case 19:
			case 22:
			case 27:
			case 44:
			case 45:
			case 46:
			case 47:
			case 48:
			case 49:
			case 50:
			case 51:
			case 52:
			case 53:
			case 54:
			case 55:
			case 56:
			case 57:
			case 58:
			case 65:
			case 66:
			case 67:
			case 68:
			case 69:
			case 70:
			case 132:
			case 133:
			case 134:
			case 135:
			case 136:
			case 137:
			case 138:
			case 139:
			case 140:
			case 141:
			case 142:
			case 143:
			case 144:
			case 145:
			case 146:
			case 147:
			case 148:
			case 149:
			case 150:
			case 151:
			case 152:
			case 153:
			case 154:
			case 155:
				return 2;
			case 3:
			case 6:
			case 7:
			case 8:
			case 9:
			case 11:
			case 12:
			case 14:
			case 15:
			case 17:
			case 18:
			case 20:
			case 21:
			case 23:
			case 25:
			case 26:
			case 28:
			case 29:
			case 30:
			case 31:
			case 32:
			case 33:
			case 34:
			case 35:
			case 36:
			case 37:
			case 38:
			case 39:
			case 40:
			case 41:
			case 42:
			case 43:
			case 71:
			case 72:
			case 73:
			case 74:
			case 75:
			case 76:
			case 77:
			case 78:
			case 79:
			case 80:
			case 81:
			case 82:
			case 83:
			case 84:
			case 85:
			case 86:
			case 87:
			case 88:
			case 89:
			case 90:
			case 91:
			case 92:
			case 93:
			case 94:
			case 95:
			case 96:
			case 97:
			case 98:
			case 99:
			case 100:
			case 101:
			case 102:
			case 110:
			case 111:
			case 112:
			case 113:
			case 114:
			case 115:
			case 116:
			case 117:
			case 118:
			case 119:
			case 120:
			case 121:
			case 122:
			case 123:
			case 124:
			case 125:
			case 126:
			case 127:
			case 128:
			case 129:
			case 130:
			case 131:
				goto IL_5F8;
			case 59:
			case 60:
			case 61:
			case 62:
			case 63:
			case 64:
			case 103:
			case 104:
			case 105:
			case 106:
			case 107:
			case 108:
			case 109:
			case 174:
			case 176:
			case 178:
			case 180:
			case 182:
			case 184:
			case 186:
			case 187:
			case 188:
			case 189:
			case 190:
			case 191:
			case 192:
			case 193:
			case 194:
			case 195:
			case 196:
			case 197:
				return 3;
			case 156:
			case 157:
			case 158:
			case 159:
			case 160:
			case 161:
			case 162:
			case 163:
			case 164:
			case 165:
			case 166:
			case 167:
			case 168:
			case 169:
			case 170:
			case 171:
			case 172:
			case 173:
				break;
			case 175:
			case 177:
			case 179:
			case 181:
			case 183:
			case 185:
				return 4;
			default:
				switch (ciphersuite)
				{
				case 49153:
				case 49154:
				case 49155:
				case 49156:
				case 49157:
				case 49158:
				case 49159:
				case 49160:
				case 49161:
				case 49162:
				case 49163:
				case 49164:
				case 49165:
				case 49166:
				case 49167:
				case 49168:
				case 49169:
				case 49170:
				case 49171:
				case 49172:
				case 49173:
				case 49174:
				case 49175:
				case 49176:
				case 49177:
				case 49178:
				case 49179:
				case 49180:
				case 49181:
				case 49182:
				case 49183:
				case 49184:
				case 49185:
				case 49186:
				case 49203:
				case 49204:
				case 49205:
				case 49206:
				case 49209:
					return 2;
				case 49187:
				case 49189:
				case 49191:
				case 49193:
				case 49207:
				case 49210:
				case 49266:
				case 49268:
				case 49270:
				case 49272:
				case 49300:
				case 49302:
				case 49304:
				case 49306:
					return 3;
				case 49188:
				case 49190:
				case 49192:
				case 49194:
				case 49208:
				case 49211:
				case 49267:
				case 49269:
				case 49271:
				case 49273:
				case 49301:
				case 49303:
				case 49305:
				case 49307:
					return 4;
				case 49195:
				case 49196:
				case 49197:
				case 49198:
				case 49199:
				case 49200:
				case 49201:
				case 49202:
				case 49274:
				case 49275:
				case 49276:
				case 49277:
				case 49278:
				case 49279:
				case 49280:
				case 49281:
				case 49282:
				case 49283:
				case 49284:
				case 49285:
				case 49286:
				case 49287:
				case 49288:
				case 49289:
				case 49290:
				case 49291:
				case 49292:
				case 49293:
				case 49294:
				case 49295:
				case 49296:
				case 49297:
				case 49298:
				case 49299:
				case 49308:
				case 49309:
				case 49310:
				case 49311:
				case 49312:
				case 49313:
				case 49314:
				case 49315:
				case 49316:
				case 49317:
				case 49318:
				case 49319:
				case 49320:
				case 49321:
				case 49322:
				case 49323:
				case 49324:
				case 49325:
				case 49326:
				case 49327:
					break;
				case 49212:
				case 49213:
				case 49214:
				case 49215:
				case 49216:
				case 49217:
				case 49218:
				case 49219:
				case 49220:
				case 49221:
				case 49222:
				case 49223:
				case 49224:
				case 49225:
				case 49226:
				case 49227:
				case 49228:
				case 49229:
				case 49230:
				case 49231:
				case 49232:
				case 49233:
				case 49234:
				case 49235:
				case 49236:
				case 49237:
				case 49238:
				case 49239:
				case 49240:
				case 49241:
				case 49242:
				case 49243:
				case 49244:
				case 49245:
				case 49246:
				case 49247:
				case 49248:
				case 49249:
				case 49250:
				case 49251:
				case 49252:
				case 49253:
				case 49254:
				case 49255:
				case 49256:
				case 49257:
				case 49258:
				case 49259:
				case 49260:
				case 49261:
				case 49262:
				case 49263:
				case 49264:
				case 49265:
					goto IL_5F8;
				default:
					if (ciphersuite - 52392 > 6)
					{
						goto IL_5F8;
					}
					break;
				}
				break;
			}
			return 0;
			IL_5F8:
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
		}

		// Token: 0x0600257F RID: 9599 RVA: 0x000A2EC4 File Offset: 0x000A10C4
		public static global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion GetMinimumVersion(int ciphersuite)
		{
			if (ciphersuite <= 197)
			{
				if (ciphersuite <= 109)
				{
					if (ciphersuite - 59 > 5 && ciphersuite - 103 > 6)
					{
						goto IL_70;
					}
				}
				else if (ciphersuite - 156 > 17 && ciphersuite - 186 > 11)
				{
					goto IL_70;
				}
			}
			else if (ciphersuite <= 49299)
			{
				if (ciphersuite - 49187 > 15 && ciphersuite - 49266 > 33)
				{
					goto IL_70;
				}
			}
			else if (ciphersuite - 49308 > 19 && ciphersuite - 52392 > 6)
			{
				goto IL_70;
			}
			return global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion.TLSv12;
			IL_70:
			return global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion.SSLv3;
		}

		// Token: 0x06002580 RID: 9600 RVA: 0x000A2F46 File Offset: 0x000A1146
		public static bool IsAeadCipherSuite(int ciphersuite)
		{
			return 2 == global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetCipherType(ciphersuite);
		}

		// Token: 0x06002581 RID: 9601 RVA: 0x000A2F51 File Offset: 0x000A1151
		public static bool IsBlockCipherSuite(int ciphersuite)
		{
			return 1 == global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetCipherType(ciphersuite);
		}

		// Token: 0x06002582 RID: 9602 RVA: 0x000A2F5C File Offset: 0x000A115C
		public static bool IsStreamCipherSuite(int ciphersuite)
		{
			return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetCipherType(ciphersuite) == 0;
		}

		// Token: 0x06002583 RID: 9603 RVA: 0x000A2F68 File Offset: 0x000A1168
		public static bool IsValidCipherSuiteForSignatureAlgorithms(int cipherSuite, global::System.Collections.IList sigAlgs)
		{
			int keyExchangeAlgorithm;
			try
			{
				keyExchangeAlgorithm = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetKeyExchangeAlgorithm(cipherSuite);
			}
			catch (global::System.IO.IOException)
			{
				return true;
			}
			switch (keyExchangeAlgorithm)
			{
			case 3:
			case 4:
			case 22:
				return sigAlgs.Contains(2);
			case 5:
			case 6:
			case 19:
			case 23:
				return sigAlgs.Contains(1);
			case 11:
			case 12:
			case 20:
				return sigAlgs.Contains(0);
			case 17:
				return sigAlgs.Contains(3);
			}
			return true;
		}

		// Token: 0x06002584 RID: 9604 RVA: 0x000A302C File Offset: 0x000A122C
		public static bool IsValidCipherSuiteForVersion(int cipherSuite, global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion serverVersion)
		{
			return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetMinimumVersion(cipherSuite).IsEqualOrEarlierVersionOf(serverVersion.GetEquivalentTLSVersion());
		}

		// Token: 0x06002585 RID: 9605 RVA: 0x000A3040 File Offset: 0x000A1240
		public static global::System.Collections.IList GetUsableSignatureAlgorithms(global::System.Collections.IList sigHashAlgs)
		{
			if (sigHashAlgs == null)
			{
				return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetAllSignatureAlgorithms();
			}
			global::System.Collections.IList v = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList(4);
			v.Add(0);
			foreach (object obj in sigHashAlgs)
			{
				byte sigAlg = ((global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm)obj).Signature;
				if (!v.Contains(sigAlg))
				{
					v.Add(sigAlg);
				}
			}
			return v;
		}

		// Token: 0x06002586 RID: 9606 RVA: 0x000A30CC File Offset: 0x000A12CC
		public static bool IsTimeout(global::System.Net.Sockets.SocketException e)
		{
			return global::System.Net.Sockets.SocketError.TimedOut == e.SocketErrorCode;
		}

		// Token: 0x04000EDD RID: 3805
		public static readonly byte[] EmptyBytes = new byte[0];

		// Token: 0x04000EDE RID: 3806
		public static readonly short[] EmptyShorts = new short[0];

		// Token: 0x04000EDF RID: 3807
		public static readonly int[] EmptyInts = new int[0];

		// Token: 0x04000EE0 RID: 3808
		public static readonly long[] EmptyLongs = new long[0];

		// Token: 0x04000EE1 RID: 3809
		internal static readonly byte[] SSL_CLIENT = new byte[]
		{
			67,
			76,
			78,
			84
		};

		// Token: 0x04000EE2 RID: 3810
		internal static readonly byte[] SSL_SERVER = new byte[]
		{
			83,
			82,
			86,
			82
		};

		// Token: 0x04000EE3 RID: 3811
		internal static readonly byte[][] SSL3_CONST = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GenSsl3Const();
	}
}
