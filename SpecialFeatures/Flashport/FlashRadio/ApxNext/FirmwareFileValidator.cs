using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using Motorola.Common.CustomException;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Comms.Util;

namespace SpecialFeatures.Flashport.FlashRadio.ApxNext
{
	// Token: 0x020000F5 RID: 245
	public class FirmwareFileValidator
	{
		// Token: 0x06000DF1 RID: 3569 RVA: 0x0000314A File Offset: 0x0000134A
		public FirmwareFileValidator(global::SpecialFeatures.Comms.Util.IIOCompressionHelper ioCompressionHelper)
		{
			this.f = ioCompressionHelper;
		}

		// Token: 0x06000DF2 RID: 3570 RVA: 0x00134D8C File Offset: 0x00132F8C
		public bool IsItApxNextFwFile(string upgradeFile)
		{
			int a_ = 19;
			string extension;
			short num;
			for (;;)
			{
				extension = global::System.IO.Path.GetExtension(upgradeFile);
				if (!string.IsNullOrEmpty(upgradeFile))
				{
					break;
				}
				num = (short)1735000064;
				short num2 = num;
				num = (short)1419161467;
				short num3 = num;
				num = (short)435269499;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_90;
				}
			}
			return extension.Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뢕", a_), global::System.StringComparison.OrdinalIgnoreCase);
			IL_90:
			num = (short)878379008;
			if (num != 0)
			{
			}
			num = (short)1538457601;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06000DF3 RID: 3571 RVA: 0x00134E68 File Offset: 0x00133068
		public void VerifyFirmwareContent(string upgradeFile)
		{
			int a_ = 12;
			short num = (short)1583005940;
			short num2 = num;
			num = (short)1728561396;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)405798912;
				short num3 = num;
				num = (short)1395392512;
				if (num != 0)
				{
				}
				num = (short)766443521;
				if (num != 0)
				{
				}
				bool flag = true;
				global::System.IO.Compression.ZipArchive zipArchive = this.f.OpenRead(upgradeFile);
				try
				{
					num = (short)1016856579;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerable<string> source;
						switch (num4)
						{
						case 0:
							goto IL_1F8;
						case 1:
							goto IL_211;
						case 2:
							flag &= source.Any(delegate(string structure)
							{
								int a_2 = 8;
								while (!structure.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﶊﲒ뢖ﾘ횠슢힤슦蚨", a_2)))
								{
									short num5 = (short)337969152;
									short num6 = num5;
									num5 = (short)680525825;
									if (num5 != 0)
									{
									}
									num5 = (short)767478349;
									short num7 = num5;
									num5 = (short)416139853;
									switch ((num7 == num5) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num5 = (short)2090270720;
										if (num5 != 0)
										{
										}
										return false;
									}
								}
								return structure.EndsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꖊ", a_2));
							});
							num = (short)806617092;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_F4;
							}
							continue;
						case 4:
							if (!flag)
							{
								num = (short)316080133;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1F8;
						case 5:
							global::SpecialFeatures.CommonExceptionHelper.ConvertExceptiontAndThrow(new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_APX_NEXT_Firmware_Package_Invalid_Structure));
							num = (short)936181760;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_F4:
						source = zipArchive.Entries.Select(delegate(global::System.IO.Compression.ZipArchiveEntry entry)
						{
							short num5 = (short)280689717;
							short num6 = num5;
							num5 = (short)1354955829;
							switch (num6 == num5)
							{
							default:
							{
								num5 = (short)1912864768;
								short num7 = num5;
								break;
							}
							case true:
								break;
							}
							num5 = (short)1919811585;
							if (num5 != 0)
							{
							}
							num5 = (short)534708224;
							if (num5 != 0)
							{
							}
							return entry.FullName;
						});
						flag &= source.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("朗뢔殺ﲘﲜﮞ삠힢쒤", a_));
						flag &= source.Contains(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﾎ璉ﾚ뎜ﶞ좠춢", a_));
						num = (short)1748893698;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_1F8:
						num = (short)291241985;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_211:;
				}
				finally
				{
					num = (short)1052377088;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_244;
							}
							continue;
						case 1:
							((global::System.IDisposable)zipArchive).Dispose();
							num = (short)80019458;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_27A;
						}
						IL_244:
						if (zipArchive == null)
						{
							break;
						}
						num = (short)1091633153;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_27A:;
				}
				break;
			}
			}
		}

		// Token: 0x04000739 RID: 1849
		private const string a = ".bbf";

		// Token: 0x0400073A RID: 1850
		private const string b = ".zip";

		// Token: 0x0400073B RID: 1851
		private const string c = "msi-metadata";

		// Token: 0x0400073C RID: 1852
		private const string d = "payload.bin";

		// Token: 0x0400073D RID: 1853
		private const string e = "vendor/firmware/";

		// Token: 0x0400073E RID: 1854
		private readonly global::SpecialFeatures.Comms.Util.IIOCompressionHelper f;
	}
}
