using System;
using System.IO;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.BZip2
{
	// Token: 0x02000075 RID: 117
	public static class BZip2
	{
		// Token: 0x060004B6 RID: 1206 RVA: 0x0001481C File Offset: 0x00012A1C
		public static void Decompress(global::System.IO.Stream inStream, global::System.IO.Stream outStream, bool isStreamOwner)
		{
			if (inStream == null)
			{
				throw new global::System.ArgumentNullException("inStream");
			}
			if (outStream == null)
			{
				throw new global::System.ArgumentNullException("outStream");
			}
			try
			{
				using (global::ICSharpCode.SharpZipLib.BZip2.BZip2InputStream bzip2InputStream = new global::ICSharpCode.SharpZipLib.BZip2.BZip2InputStream(inStream))
				{
					bzip2InputStream.IsStreamOwner = isStreamOwner;
					global::ICSharpCode.SharpZipLib.Core.StreamUtils.Copy(bzip2InputStream, outStream, new byte[4096]);
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

		// Token: 0x060004B7 RID: 1207 RVA: 0x00014898 File Offset: 0x00012A98
		public static void Compress(global::System.IO.Stream inStream, global::System.IO.Stream outStream, bool isStreamOwner, int level)
		{
			if (inStream == null)
			{
				throw new global::System.ArgumentNullException("inStream");
			}
			if (outStream == null)
			{
				throw new global::System.ArgumentNullException("outStream");
			}
			try
			{
				using (global::ICSharpCode.SharpZipLib.BZip2.BZip2OutputStream bzip2OutputStream = new global::ICSharpCode.SharpZipLib.BZip2.BZip2OutputStream(outStream, level))
				{
					bzip2OutputStream.IsStreamOwner = isStreamOwner;
					global::ICSharpCode.SharpZipLib.Core.StreamUtils.Copy(inStream, bzip2OutputStream, new byte[4096]);
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
