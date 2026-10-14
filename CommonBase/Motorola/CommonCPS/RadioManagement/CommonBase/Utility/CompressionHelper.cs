using System;
using System.IO;
using System.IO.Compression;

namespace Motorola.CommonCPS.RadioManagement.CommonBase.Utility
{
	// Token: 0x0200000D RID: 13
	public static class CompressionHelper
	{
		// Token: 0x06000047 RID: 71 RVA: 0x000069E8 File Offset: 0x00004BE8
		public static string Compress(byte[] inputBytes)
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			short num;
			string result;
			try
			{
				global::System.IO.Compression.GZipStream gzipStream = new global::System.IO.Compression.GZipStream(memoryStream, global::System.IO.Compression.CompressionMode.Compress);
				try
				{
					gzipStream.Write(inputBytes, 0, inputBytes.Length);
				}
				finally
				{
					num = (short)539754498;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_85;
						case 1:
							((global::System.IDisposable)gzipStream).Dispose();
							num = (short)275972096;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_50;
							}
							continue;
						}
						IL_50:
						if (gzipStream == null)
						{
							break;
						}
						num = (short)98238465;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_85:;
				}
				result = global::System.Convert.ToBase64String(memoryStream.ToArray());
			}
			finally
			{
				num = (short)672661506;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_14D;
					case 1:
					{
						num = (short)366663930;
						short num3 = num;
						num = (short)1543559418;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)727449600;
							if (num != 0)
							{
							}
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)2032271360;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_C9;
						}
						continue;
					}
					IL_C9:
					if (memoryStream == null)
					{
						break;
					}
					num = (short)720568321;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_14D:;
			}
			num = (short)275513345;
			if (num != 0)
			{
			}
			num = (short)1944453120;
			short num4 = num;
			return result;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00006BB4 File Offset: 0x00004DB4
		public static byte[] Decompress(string input)
		{
			short num = (short)2030305280;
			switch (num)
			{
			default:
			{
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(global::System.Convert.FromBase64String(input));
				byte[] result;
				try
				{
					global::System.IO.Compression.GZipStream gzipStream = new global::System.IO.Compression.GZipStream(memoryStream, global::System.IO.Compression.CompressionMode.Decompress);
					try
					{
						global::System.IO.MemoryStream memoryStream2 = new global::System.IO.MemoryStream();
						try
						{
							gzipStream.CopyTo(memoryStream2);
							result = memoryStream2.ToArray();
						}
						finally
						{
							num = (short)1446510594;
							int num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_B9;
								case 1:
									((global::System.IDisposable)memoryStream2).Dispose();
									num = (short)1441792000;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_82;
									}
									continue;
								}
								IL_82:
								if (memoryStream2 == null)
								{
									break;
								}
								num = (short)1765474305;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_B9:;
						}
					}
					finally
					{
						num = (short)331546626;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_125;
							case 1:
								((global::System.IDisposable)gzipStream).Dispose();
								num = (short)773259264;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_EE;
								}
								continue;
							}
							IL_EE:
							if (gzipStream == null)
							{
								break;
							}
							num = (short)891289601;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_125:;
					}
				}
				finally
				{
					num = (short)749862914;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_1E0;
						case 1:
						{
							num = (short)795224188;
							short num3 = num;
							num = (short)1700276348;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)130220032;
								if (num != 0)
								{
								}
								((global::System.IDisposable)memoryStream).Dispose();
								num = (short)1456472064;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_15A;
							}
							continue;
						}
						IL_15A:
						if (memoryStream == null)
						{
							break;
						}
						num = (short)1680211969;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1E0:;
				}
				num = (short)1293746177;
				if (num != 0)
				{
				}
				num = (short)1494614016;
				short num4 = num;
				return result;
			}
			}
		}
	}
}
