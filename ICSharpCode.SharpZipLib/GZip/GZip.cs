using System;
using System.IO;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.GZip
{
	// Token: 0x0200004F RID: 79
	public static class GZip
	{
		// Token: 0x060003E4 RID: 996 RVA: 0x00012154 File Offset: 0x00010354
		public static void Decompress(global::System.IO.Stream inStream, global::System.IO.Stream outStream, bool isStreamOwner)
		{
			if (inStream == null)
			{
				throw new global::System.ArgumentNullException("inStream", "Input stream is null");
			}
			if (outStream == null)
			{
				throw new global::System.ArgumentNullException("outStream", "Output stream is null");
			}
			try
			{
				using (global::ICSharpCode.SharpZipLib.GZip.GZipInputStream gzipInputStream = new global::ICSharpCode.SharpZipLib.GZip.GZipInputStream(inStream))
				{
					gzipInputStream.IsStreamOwner = isStreamOwner;
					global::ICSharpCode.SharpZipLib.Core.StreamUtils.Copy(gzipInputStream, outStream, new byte[4096]);
				}
			}
			finally
			{
				if (isStreamOwner)
				{
					outStream.Dispose();
				}
			}
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x000121DC File Offset: 0x000103DC
		public static void Compress(global::System.IO.Stream inStream, global::System.IO.Stream outStream, bool isStreamOwner, int bufferSize = 512, int level = 6)
		{
			if (inStream == null)
			{
				throw new global::System.ArgumentNullException("inStream", "Input stream is null");
			}
			if (outStream == null)
			{
				throw new global::System.ArgumentNullException("outStream", "Output stream is null");
			}
			if (bufferSize < 512)
			{
				throw new global::System.ArgumentOutOfRangeException("bufferSize", "Deflate buffer size must be >= 512");
			}
			if (level < 0 || level > 9)
			{
				throw new global::System.ArgumentOutOfRangeException("level", "Compression level must be 0-9");
			}
			try
			{
				using (global::ICSharpCode.SharpZipLib.GZip.GZipOutputStream gzipOutputStream = new global::ICSharpCode.SharpZipLib.GZip.GZipOutputStream(outStream, bufferSize))
				{
					gzipOutputStream.SetLevel(level);
					gzipOutputStream.IsStreamOwner = isStreamOwner;
					global::ICSharpCode.SharpZipLib.Core.StreamUtils.Copy(inStream, gzipOutputStream, new byte[bufferSize]);
				}
			}
			finally
			{
				if (isStreamOwner)
				{
					inStream.Dispose();
				}
			}
		}
	}
}
