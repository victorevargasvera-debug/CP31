using System;
using System.IO;

namespace Org.BouncyCastle.Utilities.IO
{
	// Token: 0x02000054 RID: 84
	public sealed class Streams
	{
		// Token: 0x060003BD RID: 957 RVA: 0x00013E29 File Offset: 0x00012029
		private Streams()
		{
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00013E34 File Offset: 0x00012034
		public static void Drain(global::System.IO.Stream inStr)
		{
			byte[] bs = new byte[4096];
			while (inStr.Read(bs, 0, bs.Length) > 0)
			{
			}
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00013E5C File Offset: 0x0001205C
		public static byte[] ReadAll(global::System.IO.Stream inStr)
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			global::Org.BouncyCastle.Utilities.IO.Streams.PipeAll(inStr, buf);
			return buf.ToArray();
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00013E7C File Offset: 0x0001207C
		public static byte[] ReadAllLimited(global::System.IO.Stream inStr, int limit)
		{
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			global::Org.BouncyCastle.Utilities.IO.Streams.PipeAllLimited(inStr, (long)limit, buf);
			return buf.ToArray();
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00013E9F File Offset: 0x0001209F
		public static int ReadFully(global::System.IO.Stream inStr, byte[] buf)
		{
			return global::Org.BouncyCastle.Utilities.IO.Streams.ReadFully(inStr, buf, 0, buf.Length);
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00013EAC File Offset: 0x000120AC
		public static int ReadFully(global::System.IO.Stream inStr, byte[] buf, int off, int len)
		{
			int totalRead;
			int numRead;
			for (totalRead = 0; totalRead < len; totalRead += numRead)
			{
				numRead = inStr.Read(buf, off + totalRead, len - totalRead);
				if (numRead < 1)
				{
					break;
				}
			}
			return totalRead;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00013ED8 File Offset: 0x000120D8
		public static void PipeAll(global::System.IO.Stream inStr, global::System.IO.Stream outStr)
		{
			global::Org.BouncyCastle.Utilities.IO.Streams.PipeAll(inStr, outStr, 4096);
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00013EE8 File Offset: 0x000120E8
		public static void PipeAll(global::System.IO.Stream inStr, global::System.IO.Stream outStr, int bufferSize)
		{
			byte[] bs = new byte[bufferSize];
			int numRead;
			while ((numRead = inStr.Read(bs, 0, bs.Length)) > 0)
			{
				outStr.Write(bs, 0, numRead);
			}
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00013F18 File Offset: 0x00012118
		public static long PipeAllLimited(global::System.IO.Stream inStr, long limit, global::System.IO.Stream outStr)
		{
			byte[] bs = new byte[4096];
			long total = 0L;
			int numRead;
			while ((numRead = inStr.Read(bs, 0, bs.Length)) > 0)
			{
				if (limit - total < (long)numRead)
				{
					throw new global::Org.BouncyCastle.Utilities.IO.StreamOverflowException("Data Overflow");
				}
				total += (long)numRead;
				outStr.Write(bs, 0, numRead);
			}
			return total;
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00013F66 File Offset: 0x00012166
		public static void WriteBufTo(global::System.IO.MemoryStream buf, global::System.IO.Stream output)
		{
			buf.WriteTo(output);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00013F70 File Offset: 0x00012170
		public static int WriteBufTo(global::System.IO.MemoryStream buf, byte[] output, int offset)
		{
			int size = (int)buf.Length;
			global::Org.BouncyCastle.Utilities.IO.Streams.WriteBufTo(buf, new global::System.IO.MemoryStream(output, offset, size));
			return size;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00013F94 File Offset: 0x00012194
		public static void WriteZeroes(global::System.IO.Stream outStr, long count)
		{
			byte[] zeroes = new byte[4096];
			while (count > 4096L)
			{
				outStr.Write(zeroes, 0, 4096);
				count -= 4096L;
			}
			outStr.Write(zeroes, 0, (int)count);
		}

		// Token: 0x0400027A RID: 634
		private const int BufferSize = 4096;
	}
}
