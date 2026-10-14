using System;
using System.IO;
using System.Linq;
using System.Text;
using NLog.Common;

namespace NLog.Internal
{
	// Token: 0x02000126 RID: 294
	public static class StreamHelpers
	{
		// Token: 0x06000DAB RID: 3499 RVA: 0x00022818 File Offset: 0x00020A18
		public static void CopyAndSkipBom(this global::System.IO.Stream input, global::System.IO.Stream output, global::System.Text.Encoding encoding)
		{
			int num = global::NLog.Internal.EncodingHelpers.Utf8BOM.Length;
			byte[] array = new byte[num];
			long position = input.Position;
			input.Read(array, 0, num);
			if (array.SequenceEqual(global::NLog.Internal.EncodingHelpers.Utf8BOM))
			{
				global::NLog.Common.InternalLogger.Debug("input has UTF8 BOM");
			}
			else
			{
				global::NLog.Common.InternalLogger.Debug("input hasn't a UTF8 BOM");
				input.Position = position;
			}
			input.Copy(output);
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x00022876 File Offset: 0x00020A76
		public static void Copy(this global::System.IO.Stream input, global::System.IO.Stream output)
		{
			input.CopyWithOffset(output, 0);
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00022880 File Offset: 0x00020A80
		public static void CopyWithOffset(this global::System.IO.Stream input, global::System.IO.Stream output, int offset)
		{
			if (offset < 0)
			{
				throw new global::System.ArgumentException("negative offset");
			}
			if (offset > 0)
			{
				input.Seek((long)offset, global::System.IO.SeekOrigin.Current);
			}
			byte[] array = new byte[4096];
			int count;
			while ((count = input.Read(array, 0, array.Length)) > 0)
			{
				output.Write(array, 0, count);
			}
		}
	}
}
