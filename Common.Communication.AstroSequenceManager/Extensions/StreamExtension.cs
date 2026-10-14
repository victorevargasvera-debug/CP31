using System;
using System.IO;

namespace Motorola.Common.Communication.Extensions
{
	// Token: 0x02000035 RID: 53
	public static class StreamExtension
	{
		// Token: 0x06000191 RID: 401 RVA: 0x00028014 File Offset: 0x00026214
		public static byte[] ToArrayBytes(this global::System.IO.Stream stream)
		{
			short num = (short)1982870866;
			short num2 = num;
			num = (short)651900242;
			byte[] result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)807469056;
				short num3 = num;
				num = (short)127729665;
				if (num != 0)
				{
				}
				num = (short)1604517888;
				if (num != 0)
				{
				}
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				try
				{
					stream.CopyTo(memoryStream);
					result = memoryStream.ToArray();
				}
				finally
				{
					num = (short)1959264256;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_E2;
							}
							continue;
						case 1:
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)544276482;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_117;
						}
						IL_E2:
						if (memoryStream == null)
						{
							break;
						}
						num = (short)2092433409;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_117:;
				}
				break;
			}
			}
			return result;
		}
	}
}
