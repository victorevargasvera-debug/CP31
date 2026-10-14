using System;
using System.IO;

namespace NPOI.Util
{
	// Token: 0x02000272 RID: 626
	public class IOUtils
	{
		// Token: 0x06001087 RID: 4231 RVA: 0x00032958 File Offset: 0x00030B58
		public static byte[] PeekFirst8Bytes(global::NPOI.Util.InputStream stream)
		{
			stream.Mark(8);
			byte[] array = new byte[8];
			int num = global::NPOI.Util.IOUtils.ReadFully(stream, array);
			if (num < 1)
			{
				throw new global::NPOI.EmptyFileException();
			}
			if (stream is global::NPOI.Util.PushbackInputStream)
			{
				stream.Position -= (long)num;
			}
			else
			{
				stream.Reset();
			}
			return array;
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x000329A8 File Offset: 0x00030BA8
		public static byte[] PeekFirst8Bytes(global::System.IO.Stream stream)
		{
			long position = stream.Position;
			byte[] array = new byte[8];
			int num = global::NPOI.Util.IOUtils.ReadFully(stream, array);
			if (num < 1)
			{
				throw new global::NPOI.EmptyFileException();
			}
			if (stream is global::NPOI.Util.PushbackInputStream)
			{
				stream.Position -= (long)num;
			}
			else
			{
				stream.Position = position;
			}
			return array;
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x000329F6 File Offset: 0x00030BF6
		public static byte[] ToByteArray(global::System.IO.Stream stream)
		{
			return global::NPOI.Util.IOUtils.ToByteArray(stream, int.MaxValue);
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x00032A04 File Offset: 0x00030C04
		public static byte[] ToByteArray(global::System.IO.Stream stream, int length)
		{
			global::NPOI.Util.ByteArrayOutputStream byteArrayOutputStream = new global::NPOI.Util.ByteArrayOutputStream((length == int.MaxValue) ? 4096 : length);
			byte[] array = new byte[4096];
			int num = 0;
			int num2;
			do
			{
				num2 = stream.Read(array, 0, global::System.Math.Min(array.Length, length - num));
				num += global::System.Math.Max(num2, 0);
				if (num2 > 0)
				{
					byteArrayOutputStream.Write(array, 0, num2);
				}
			}
			while (num < length && num2 > 0);
			if (length != 2147483647 && num < length)
			{
				throw new global::System.IO.IOException("unexpected EOF");
			}
			return byteArrayOutputStream.ToByteArray();
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x00032A84 File Offset: 0x00030C84
		public static byte[] ToByteArray(global::NPOI.Util.ByteBuffer buffer, int length)
		{
			if (buffer.HasBuffer && buffer.Offset == 0)
			{
				return buffer.Buffer;
			}
			byte[] array = new byte[length];
			buffer.Read(array);
			return array;
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x00032AB8 File Offset: 0x00030CB8
		public static int ReadFully(global::System.IO.Stream stream, byte[] b)
		{
			return global::NPOI.Util.IOUtils.ReadFully(stream, b, 0, b.Length);
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x00032AC8 File Offset: 0x00030CC8
		public static int ReadFully(global::System.IO.Stream stream, byte[] b, int off, int len)
		{
			int num = 0;
			for (;;)
			{
				int num2 = stream.Read(b, off + num, len - num - off);
				if (num2 <= 0)
				{
					break;
				}
				num += num2;
				if (num == len)
				{
					return num;
				}
			}
			if (num != 0)
			{
				return num;
			}
			return -1;
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x00032AFC File Offset: 0x00030CFC
		public static void Copy(global::System.IO.Stream inp, global::System.IO.Stream out1)
		{
			byte[] array = new byte[4096];
			int count;
			while ((count = inp.Read(array, 0, array.Length)) > 0)
			{
				out1.Write(array, 0, count);
			}
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x00032B2F File Offset: 0x00030D2F
		public static long CalculateChecksum(byte[] data)
		{
			return (long)new global::NPOI.Util.CRC32().ByteCRC(ref data);
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x00032B40 File Offset: 0x00030D40
		public static void CloseQuietly(global::System.IO.Stream closeable)
		{
			if (closeable == null)
			{
				return;
			}
			try
			{
				closeable.Close();
			}
			catch (global::System.Exception ex)
			{
				global::NPOI.Util.POILogger poilogger = global::NPOI.Util.IOUtils.logger;
				int level = 7;
				string str = "Unable to close resource: ";
				global::System.Exception ex2 = ex;
				poilogger.Log(level, str + ((ex2 != null) ? ex2.ToString() : null), ex);
			}
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x00032B90 File Offset: 0x00030D90
		public static void CloseQuietly(global::NPOI.Util.ICloseable closeable)
		{
			if (closeable == null)
			{
				return;
			}
			try
			{
				closeable.Close();
			}
			catch (global::System.Exception ex)
			{
				global::NPOI.Util.POILogger poilogger = global::NPOI.Util.IOUtils.logger;
				int level = 7;
				string str = "Unable to close resource: ";
				global::System.Exception ex2 = ex;
				poilogger.Log(level, str + ((ex2 != null) ? ex2.ToString() : null), ex);
			}
		}

		// Token: 0x04000736 RID: 1846
		private static global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.Util.IOUtils));
	}
}
