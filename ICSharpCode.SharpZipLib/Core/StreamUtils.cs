using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x0200006F RID: 111
	public sealed class StreamUtils
	{
		// Token: 0x0600048C RID: 1164 RVA: 0x00013FFD File Offset: 0x000121FD
		public static void ReadFully(global::System.IO.Stream stream, byte[] buffer)
		{
			global::ICSharpCode.SharpZipLib.Core.StreamUtils.ReadFully(stream, buffer, 0, buffer.Length);
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x0001400C File Offset: 0x0001220C
		public static void ReadFully(global::System.IO.Stream stream, byte[] buffer, int offset, int count)
		{
			if (stream == null)
			{
				throw new global::System.ArgumentNullException("stream");
			}
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			if (offset < 0 || offset > buffer.Length)
			{
				throw new global::System.ArgumentOutOfRangeException("offset");
			}
			if (count < 0 || offset + count > buffer.Length)
			{
				throw new global::System.ArgumentOutOfRangeException("count");
			}
			while (count > 0)
			{
				int num = stream.Read(buffer, offset, count);
				if (num <= 0)
				{
					throw new global::System.IO.EndOfStreamException();
				}
				offset += num;
				count -= num;
			}
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00014084 File Offset: 0x00012284
		public static int ReadRequestedBytes(global::System.IO.Stream stream, byte[] buffer, int offset, int count)
		{
			if (stream == null)
			{
				throw new global::System.ArgumentNullException("stream");
			}
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			if (offset < 0 || offset > buffer.Length)
			{
				throw new global::System.ArgumentOutOfRangeException("offset");
			}
			if (count < 0 || offset + count > buffer.Length)
			{
				throw new global::System.ArgumentOutOfRangeException("count");
			}
			int num = 0;
			while (count > 0)
			{
				int num2 = stream.Read(buffer, offset, count);
				if (num2 <= 0)
				{
					break;
				}
				offset += num2;
				count -= num2;
				num += num2;
			}
			return num;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00014100 File Offset: 0x00012300
		public static void Copy(global::System.IO.Stream source, global::System.IO.Stream destination, byte[] buffer)
		{
			if (source == null)
			{
				throw new global::System.ArgumentNullException("source");
			}
			if (destination == null)
			{
				throw new global::System.ArgumentNullException("destination");
			}
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			if (buffer.Length < 128)
			{
				throw new global::System.ArgumentException("Buffer is too small", "buffer");
			}
			bool flag = true;
			while (flag)
			{
				int num = source.Read(buffer, 0, buffer.Length);
				if (num > 0)
				{
					destination.Write(buffer, 0, num);
				}
				else
				{
					destination.Flush();
					flag = false;
				}
			}
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x0001417B File Offset: 0x0001237B
		public static void Copy(global::System.IO.Stream source, global::System.IO.Stream destination, byte[] buffer, global::ICSharpCode.SharpZipLib.Core.ProgressHandler progressHandler, global::System.TimeSpan updateInterval, object sender, string name)
		{
			global::ICSharpCode.SharpZipLib.Core.StreamUtils.Copy(source, destination, buffer, progressHandler, updateInterval, sender, name, -1L);
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00014190 File Offset: 0x00012390
		public static void Copy(global::System.IO.Stream source, global::System.IO.Stream destination, byte[] buffer, global::ICSharpCode.SharpZipLib.Core.ProgressHandler progressHandler, global::System.TimeSpan updateInterval, object sender, string name, long fixedTarget)
		{
			if (source == null)
			{
				throw new global::System.ArgumentNullException("source");
			}
			if (destination == null)
			{
				throw new global::System.ArgumentNullException("destination");
			}
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			if (buffer.Length < 128)
			{
				throw new global::System.ArgumentException("Buffer is too small", "buffer");
			}
			if (progressHandler == null)
			{
				throw new global::System.ArgumentNullException("progressHandler");
			}
			bool flag = true;
			global::System.DateTime now = global::System.DateTime.Now;
			long num = 0L;
			long target = 0L;
			if (fixedTarget >= 0L)
			{
				target = fixedTarget;
			}
			else if (source.CanSeek)
			{
				target = source.Length - source.Position;
			}
			global::ICSharpCode.SharpZipLib.Core.ProgressEventArgs progressEventArgs = new global::ICSharpCode.SharpZipLib.Core.ProgressEventArgs(name, num, target);
			progressHandler(sender, progressEventArgs);
			bool flag2 = true;
			while (flag)
			{
				int num2 = source.Read(buffer, 0, buffer.Length);
				if (num2 > 0)
				{
					num += (long)num2;
					flag2 = false;
					destination.Write(buffer, 0, num2);
				}
				else
				{
					destination.Flush();
					flag = false;
				}
				if (global::System.DateTime.Now - now > updateInterval)
				{
					flag2 = true;
					now = global::System.DateTime.Now;
					progressEventArgs = new global::ICSharpCode.SharpZipLib.Core.ProgressEventArgs(name, num, target);
					progressHandler(sender, progressEventArgs);
					flag = progressEventArgs.ContinueRunning;
				}
			}
			if (!flag2)
			{
				progressEventArgs = new global::ICSharpCode.SharpZipLib.Core.ProgressEventArgs(name, num, target);
				progressHandler(sender, progressEventArgs);
			}
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x000142BD File Offset: 0x000124BD
		private StreamUtils()
		{
		}
	}
}
