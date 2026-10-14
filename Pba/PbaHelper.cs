using System;
using System.IO;
using Motorola.Common.CommonLib;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000023 RID: 35
	public class PbaHelper
	{
		// Token: 0x0600011C RID: 284 RVA: 0x000154D0 File Offset: 0x000136D0
		public static byte[] FileToByte(string filePath)
		{
			short num = (short)1601241089;
			int num2 = (int)((global::System.IntPtr)num);
			byte[] bytesFromStream;
			for (;;)
			{
				global::System.IO.Stream stream;
				switch (num2)
				{
				case 0:
					goto IL_9B;
				case 1:
				{
					num = (short)1674411210;
					short num3 = num;
					num = (short)936672458;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9B;
					default:
						num = (short)126615552;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_7B;
						}
						continue;
					}
					break;
				}
				case 2:
					try
					{
						bytesFromStream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.GetBytesFromStream(stream);
						goto IL_173;
					}
					finally
					{
						num = (short)1278083073;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								((global::System.IDisposable)stream).Dispose();
								num = (short)1257570306;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_E2;
								}
								continue;
							case 2:
								goto IL_117;
							}
							IL_E2:
							if (stream == null)
							{
								break;
							}
							num = (short)250544128;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_117:;
					}
					goto IL_11A;
				}
				IL_7B:
				if (!global::System.IO.File.Exists(filePath))
				{
					num = (short)457703424;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_11A:
				num = (short)1660747777;
				if (num != 0)
				{
				}
				stream = global::Motorola.Common.CommonLib.EnDecryptStreamHelper.Instance.CreateCryptoFlStream(filePath, global::System.IO.FileAccess.Read);
				num = (short)21037058;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_9B:
			throw new global::System.ApplicationException();
			IL_173:
			num = (short)124715008;
			short num4 = num;
			return bytesFromStream;
		}
	}
}
