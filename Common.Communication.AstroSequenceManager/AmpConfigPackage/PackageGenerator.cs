using System;
using System.IO;
using System.IO.Compression;
using Motorola.Common.Communication.Extensions;
using Motorola.Common.Communication.Pba;

namespace Motorola.Common.Communication.AmpConfigPackage
{
	// Token: 0x0200003A RID: 58
	public class PackageGenerator
	{
		// Token: 0x060001AC RID: 428 RVA: 0x0002B180 File Offset: 0x00029380
		public byte[] GeneratePackage(global::Motorola.Common.Communication.Pba.PbaObject pba)
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			short num;
			byte[] result;
			try
			{
				num = (short)1496449025;
				if (num != 0)
				{
				}
				this.a(memoryStream, pba);
				result = memoryStream.ToArray();
			}
			finally
			{
				num = (short)199819264;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_72;
						}
						continue;
					case 1:
						goto IL_A6;
					case 2:
						((global::System.IDisposable)memoryStream).Dispose();
						num = (short)2115043329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_72:
					if (memoryStream == null)
					{
						break;
					}
					num = (short)1184301058;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A6:
				num = (short)1298930534;
				short num3 = num;
				num = (short)564468582;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_A6;
				default:
					num = (short)909836288;
					if (num != 0)
					{
					}
					break;
				}
			}
			num = (short)1871970304;
			short num4 = num;
			return result;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0002B2C0 File Offset: 0x000294C0
		private void a(global::System.IO.Stream A_0, global::Motorola.Common.Communication.Pba.PbaObject A_1)
		{
			int a_ = 3;
			short num = (short)877854721;
			if (num != 0)
			{
			}
			num = (short)888078336;
			switch (num)
			{
			default:
			{
				global::System.IO.Compression.ZipArchive zipArchive = new global::System.IO.Compression.ZipArchive(A_0, global::System.IO.Compression.ZipArchiveMode.Create, true);
				try
				{
					global::System.IO.Stream stream = zipArchive.CreateEntry(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("뻲铴駶郸鷺飼賾甀ⴂ約樆攈", a_)).Open();
					try
					{
						global::System.IO.MemoryStream memoryStream = global::Motorola.Common.Communication.AmpConfigPackage.ManifestXmlHelper.CreateManifest(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("郲髴鏶鳸诺釼諾昀ⴂ昄樆礈", a_));
						try
						{
							memoryStream.WriteTo(stream);
							goto IL_23A;
						}
						finally
						{
							num = (short)1310261250;
							int num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									((global::System.IDisposable)memoryStream).Dispose();
									num = (short)738131969;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_100;
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
								num = (short)134479872;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_100:;
						}
					}
					finally
					{
						num = (short)689045506;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							num = (short)973601179;
							short num3 = num;
							num = (short)1230895515;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1B9;
							default:
								num = (short)1231224832;
								if (num != 0)
								{
								}
								switch (num2)
								{
								case 0:
									((global::System.IDisposable)stream).Dispose();
									num = (short)723517441;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_1B9;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_180;
									}
									continue;
								}
								IL_180:
								if (stream == null)
								{
									goto IL_1BB;
								}
								num = (short)1862795264;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
						}
						IL_1B9:
						IL_1BB:;
					}
					global::System.IO.Stream stream2;
					byte[] array;
					try
					{
						IL_1BC:
						stream2.Write(array, 0, array.Length);
						goto IL_2CC;
					}
					finally
					{
						num = (short)1219690498;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								((global::System.IDisposable)stream2).Dispose();
								num = (short)1284308993;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_237;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_200;
								}
								continue;
							}
							IL_200:
							if (stream2 == null)
							{
								break;
							}
							num = (short)1361641472;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_237:;
					}
					IL_23A:
					global::System.IO.Compression.ZipArchiveEntry zipArchiveEntry = zipArchive.CreateEntry(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("郲髴鏶鳸诺釼諾昀ⴂ昄樆礈", a_));
					array = A_1.ToCmpBytes();
					stream2 = zipArchiveEntry.Open();
					goto IL_1BC;
				}
				finally
				{
					num = (short)824639490;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							((global::System.IDisposable)zipArchive).Dispose();
							num = (short)1563361281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_2C9;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_294;
							}
							continue;
						}
						IL_294:
						if (zipArchive == null)
						{
							break;
						}
						num = (short)741343232;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2C9:;
				}
				IL_2CC:
				num = (short)851378176;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0002B63C File Offset: 0x0002983C
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(102288697 + A_1) + (global::System.IntPtr)93 + (global::System.IntPtr)43 + (global::System.IntPtr)46);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_5C;
			}
			IL_29:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_5C:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_29;
		}

		// Token: 0x040000DB RID: 219
		private const string a = "Manifest.xml";

		// Token: 0x040000DC RID: 220
		private const string b = "codeplug.cmp";
	}
}
