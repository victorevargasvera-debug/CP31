using System;

namespace NPOI.Util
{
	// Token: 0x02000286 RID: 646
	public class PngUtils
	{
		// Token: 0x0600115B RID: 4443 RVA: 0x0000253E File Offset: 0x0000073E
		private PngUtils()
		{
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x00034594 File Offset: 0x00032794
		public static bool MatchesPngHeader(byte[] data, int offset)
		{
			if (data == null || data.Length - offset < global::NPOI.Util.PngUtils.PNG_FILE_HEADER.Length)
			{
				return false;
			}
			for (int i = 0; i < global::NPOI.Util.PngUtils.PNG_FILE_HEADER.Length; i++)
			{
				if (global::NPOI.Util.PngUtils.PNG_FILE_HEADER[i] != data[i + offset])
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x04000757 RID: 1879
		private static byte[] PNG_FILE_HEADER = new byte[]
		{
			137,
			80,
			78,
			71,
			13,
			10,
			26,
			10
		};
	}
}
