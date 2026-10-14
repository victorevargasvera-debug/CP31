using System;
using Motorola.Common.CustomException;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Flashport.FlashRadio.ApxNext
{
	// Token: 0x020000F7 RID: 247
	public class MetadataFileValidator
	{
		// Token: 0x06000DF8 RID: 3576 RVA: 0x00135354 File Offset: 0x00133554
		public static void VerifyMetadataFileContent(global::SpecialFeatures.Flashport.FlashRadio.MetadataFile metadataFile)
		{
			short num = (short)1610478591;
			short num2 = num;
			num = (short)1217262591;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1080623104;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)826277889;
			if (num != 0)
			{
			}
			num = (short)1502937088;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Flashport.FlashRadio.ApxNext.MetadataFileValidator.a(metadataFile);
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x00135404 File Offset: 0x00133604
		public static void VerifyAllowedTargetDevice(global::SpecialFeatures.Flashport.FlashRadio.MetadataFile metadataFile, string targetDeviceCode)
		{
			int a_ = 12;
			short num = (short)569638912;
			switch (num)
			{
			default:
				for (;;)
				{
					IL_26:
					num = (short)1528233985;
					if (num != 0)
					{
					}
					num = (short)658309122;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)1579860717;
						short num3 = num;
						num = (short)722322157;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_26;
						default:
						{
							num = (short)1913520128;
							if (num != 0)
							{
							}
							string value;
							bool flag;
							switch (num2)
							{
							case 0:
								goto IL_1BB;
							case 1:
							{
								int num4;
								if (num4 > -1)
								{
									num = (short)389873672;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								string targetDevice;
								value = targetDevice.Substring(0, 3).ToLower();
								num = (short)774635524;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_F9;
								}
								continue;
							case 3:
								if (string.IsNullOrEmpty(metadataFile.TargetDevice))
								{
									num = (short)2077229069;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_2F3;
							case 4:
								goto IL_11C;
							case 5:
								goto IL_2F3;
							case 6:
							{
								string targetDevice = metadataFile.TargetDevice;
								int num4 = targetDevice.IndexOf(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킎", a_));
								value = string.Empty;
								num = (short)763363329;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
								global::SpecialFeatures.CommonExceptionHelper.ConvertExceptiontAndThrow(new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_APX_NEXT_Firmware_Metadata_Invalid_Target_Device));
								num = (short)168165390;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
							{
								num = (short)260636672;
								short num5 = num;
								int num4;
								string targetDevice;
								value = targetDevice.Substring(0, num4).ToLower();
								num = (short)1904934922;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 9:
								if (!string.IsNullOrEmpty(targetDeviceCode))
								{
									num = (short)2116943878;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1BB;
							case 10:
								goto IL_11C;
							case 11:
								if (!flag)
								{
									num = (short)192282631;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								return;
							case 12:
								num = (short)1407713283;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 13:
								goto IL_18F;
							case 14:
								return;
							}
							IL_F9:
							if (metadataFile != null)
							{
								num = (short)1385365516;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							goto IL_18F;
							IL_11C:
							flag = targetDeviceCode.Equals(value);
							num = (short)1185742848;
							num2 = (int)((global::System.IntPtr)num);
							break;
							IL_18F:
							global::SpecialFeatures.CommonExceptionHelper.ConvertExceptiontAndThrow(new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_APX_NEXT_Firmware_Metadata_Invalid_Content));
							num = (short)939065349;
							num2 = (int)((global::System.IntPtr)num);
							break;
							IL_1BB:
							num = (short)1454505995;
							num2 = (int)((global::System.IntPtr)num);
							break;
							IL_2F3:
							flag = true;
							num = (short)1346830345;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						}
					}
				}
				return;
			}
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x00135748 File Offset: 0x00133948
		public static bool VerifyIsTargetDevice(global::SpecialFeatures.Flashport.FlashRadio.MetadataFile metadataFile, string targetDeviceCode)
		{
			int a_ = 12;
			short num = (short)96010240;
			switch (num)
			{
			default:
			{
				num = (short)337229531;
				short num2 = num;
				num = (short)389330651;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_25C:
					num = (short)339279878;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)459341824;
					if (num != 0)
					{
					}
					num = (short)539230213;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				bool result;
				for (;;)
				{
					string value;
					switch (num3)
					{
					case 0:
						goto IL_1C7;
					case 1:
						goto IL_1C2;
					case 2:
					{
						int num4;
						if (num4 > -1)
						{
							num = (short)1746534408;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						string targetDevice;
						value = targetDevice.Substring(0, 3).ToLower();
						num = (short)507772928;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (string.IsNullOrEmpty(metadataFile.TargetDevice))
						{
							num = (short)1993277451;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25A;
					case 4:
					{
						string targetDevice = metadataFile.TargetDevice;
						int num4 = targetDevice.IndexOf(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킎", a_));
						value = string.Empty;
						num = (short)1770979328;
						short num5 = num;
						num = (short)1885208578;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_CA;
						}
						continue;
					case 6:
						if (!string.IsNullOrEmpty(targetDeviceCode))
						{
							num = (short)280494084;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29C;
					case 7:
						goto IL_1C7;
					case 8:
					{
						int num4;
						string targetDevice;
						value = targetDevice.Substring(0, num4).ToLower();
						num = (short)483459079;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						num = (short)1808400387;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_1E7;
					case 11:
						goto IL_19A;
					}
					IL_CA:
					if (metadataFile != null)
					{
						num = (short)1679491081;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_19A:
					global::SpecialFeatures.CommonExceptionHelper.ConvertExceptiontAndThrow(new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_APX_NEXT_Firmware_Metadata_Invalid_Content));
					num = (short)1729298433;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C7:
					result = targetDeviceCode.Equals(value);
					num = (short)1029242890;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1C2:
				goto IL_25A;
				IL_1E7:
				goto IL_29C;
				IL_25A:
				result = true;
				goto IL_25C;
				IL_29C:
				num = (short)2008547329;
				if (num != 0)
				{
				}
				return result;
			}
			}
		}

		// Token: 0x06000DFB RID: 3579 RVA: 0x00135A1C File Offset: 0x00133C1C
		private static void a(global::SpecialFeatures.Flashport.FlashRadio.MetadataFile A_0)
		{
			int a_ = 1;
			short num = (short)1541275653;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				string text;
				switch (num2)
				{
				case 0:
					if (!(text == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_)))
					{
						num = (short)1240072192;
						short num3 = num;
						num = (short)805568525;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1284243481;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)1851523086;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_1A2;
				case 3:
					goto IL_47F;
				case 4:
					goto IL_503;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_9A;
					}
					continue;
				case 6:
					num = (short)1261895690;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					global::SpecialFeatures.CommonExceptionHelper.ConvertExceptiontAndThrow(new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_APX_NEXT_Firmware_Metadata_Invalid_Content));
					num = (short)34013210;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)400162832;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (!string.IsNullOrEmpty(A_0.PostBuildIncremental))
					{
						num = (short)1329397771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C6;
				case 10:
					global::SpecialFeatures.CommonExceptionHelper.ConvertExceptiontAndThrow(new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_APX_NEXT_Firmware_Metadata_Invalid_Content));
					num = (short)1338114063;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					num = (short)1505624084;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (!string.IsNullOrEmpty(A_0.BpFirmware))
					{
						num = (short)1542914065;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_267;
				case 13:
					goto IL_225;
				case 14:
					if (string.IsNullOrEmpty(A_0.BpFirmware))
					{
						num = (short)1288568835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 15:
					goto IL_30B;
				case 16:
					if (!(text == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힇ﾉﲋ", a_)))
					{
						num = (short)2139815942;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)586481682;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					num = (short)1883701270;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					if (!string.IsNullOrEmpty(A_0.PostBuildIncremental))
					{
						num = (short)2120744983;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_267;
				case 19:
					if (string.IsNullOrEmpty(A_0.PreBuildIncremental))
					{
						num = (short)1999175684;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 20:
					if (!string.IsNullOrEmpty(A_0.BpFirmware))
					{
						num = (short)282591256;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C6;
				case 21:
				{
					num = (short)2106130433;
					if (num != 0)
					{
					}
					if (text == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﲍﲑﾕ聯", a_))
					{
						num = (short)2039480329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1225284314;
					short num4 = num;
					num = (short)1317886682;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_225;
					default:
						num = (short)476708864;
						if (num != 0)
						{
						}
						num = (short)1811808264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 22:
					if (string.IsNullOrEmpty(A_0.PreBuildIncremental))
					{
						num = (short)1990787074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 23:
					num = (short)781385740;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					num = (short)695664659;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					if (!string.IsNullOrEmpty(A_0.PostBuildIncremental))
					{
						num = (short)2071789569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_277;
				case 26:
					goto IL_1A7;
				}
				IL_9A:
				if (string.IsNullOrEmpty(A_0.OtaPackage))
				{
					num = (short)1308884999;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1A7:
				text = A_0.OtaPackage.ToLower();
				num = (short)1443627008;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_225:
				num = (short)557121557;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C6:
			global::SpecialFeatures.CommonExceptionHelper.ConvertExceptiontAndThrow(new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_APX_NEXT_Firmware_Metadata_Invalid_Content));
			return;
			IL_1A2:
			IL_267:
			global::SpecialFeatures.CommonExceptionHelper.ConvertExceptiontAndThrow(new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_APX_NEXT_Firmware_Metadata_Invalid_Content));
			return;
			IL_277:
			global::SpecialFeatures.CommonExceptionHelper.ConvertExceptiontAndThrow(new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_APX_NEXT_Firmware_Metadata_Invalid_Content));
			return;
			IL_30B:
			return;
			IL_47F:
			goto IL_277;
			IL_503:
			goto IL_C6;
		}

		// Token: 0x04000742 RID: 1858
		private const int a = 3;

		// Token: 0x04000743 RID: 1859
		private const string b = "_";

		// Token: 0x04000744 RID: 1860
		private const string c = "full";

		// Token: 0x04000745 RID: 1861
		private const string d = "differential";

		// Token: 0x04000746 RID: 1862
		private const string e = "bp_update";
	}
}
