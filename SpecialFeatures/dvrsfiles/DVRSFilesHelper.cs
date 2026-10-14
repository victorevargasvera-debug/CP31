using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpUtility;
using CommonResources;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.EntityModel;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.DVRSFiles.List;

namespace SpecialFeatures.DVRSFiles
{
	// Token: 0x02000122 RID: 290
	public class DVRSFilesHelper
	{
		// Token: 0x06000F73 RID: 3955 RVA: 0x0015A73C File Offset: 0x0015893C
		private static global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles a(string A_0, bool A_1, string A_2 = "")
		{
			short num = (short)274629287;
			short num2 = num;
			num = (short)459309735;
			global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles astrodvrsfiles;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_A5:
				num = (short)34734080;
				short num3 = num;
				num = (short)1383006209;
				if (num != 0)
				{
				}
				astrodvrsfiles.PackageName = A_2;
				num = (short)1704067075;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)1517223936;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_6C;
				}
				break;
			}
			for (;;)
			{
				IL_56:
				switch (num4)
				{
				case 0:
					goto IL_138;
				case 1:
					astrodvrsfiles.PackageName = global::System.IO.Path.GetFileNameWithoutExtension(A_0);
					num = (short)949878784;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (string.IsNullOrEmpty(A_2))
					{
						num = (short)2018443265;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A5;
				case 3:
					goto IL_113;
				}
				goto IL_6C;
			}
			IL_113:
			IL_138:
			global::Motorola.CommonCPS.Server.EntityModel.RMFile rmfile = new global::Motorola.CommonCPS.Server.EntityModel.RMFile
			{
				Url = A_0
			};
			astrodvrsfiles.RMFile = rmfile;
			global::SpecialFeatures.DVRSFiles.DVRSFilesHelper.a(A_0, astrodvrsfiles, A_1);
			return astrodvrsfiles;
			IL_6C:
			astrodvrsfiles = new global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles();
			num = (short)673972226;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_56;
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x0015A8A4 File Offset: 0x00158AA4
		public static global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles AnalysisDVRSFilePackageInfo(string filePath)
		{
			try
			{
				return global::SpecialFeatures.DVRSFiles.DVRSFilesHelper.a(filePath, true, "");
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::System.Exception)
			{
				global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.AnaysisPackageFailed);
			}
			short num = (short)1313981451;
			short num2 = num;
			num = (short)1267319819;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles result;
				return result;
			}
			case 1:
				break;
			default:
			{
				num = (short)835649536;
				short num3 = num;
				break;
			}
			}
			num = (short)1762197505;
			if (num != 0)
			{
			}
			num = (short)1334706176;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x0015A990 File Offset: 0x00158B90
		private static global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles a(string A_0, global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles A_1, bool A_2)
		{
			int a_ = 3;
			short num;
			try
			{
				num = (short)113049600;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					global::System.IO.FileStream fileStream = new global::System.IO.FileStream(A_0, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
					try
					{
						switch (0)
						{
						case 0:
							goto IL_6F;
						}
						byte[] array3;
						int num3;
						byte[] array4;
						global::System.Text.ASCIIEncoding asciiencoding;
						byte[] array5;
						global::System.Globalization.CultureInfo invariantCulture;
						int num4;
						byte[] array6;
						byte[] array7;
						int num8;
						for (;;)
						{
							IL_3C:
							byte[] array;
							switch (num2)
							{
							case 0:
								goto IL_2D7;
							case 1:
							{
								if (array[0] == 0)
								{
									num = (short)2083848196;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								byte[] array2 = new byte[1];
								global::System.Array.Copy(array3, 16, array2, num3, 1);
								global::SpecialFeatures.DVRSFiles.DVRSFilesHelper.a(A_0, array2, A_1);
								global::System.Array.Copy(array3, 20, array4, num3, 23);
								string @string = asciiencoding.GetString(array4);
								A_1.ConfigDataName = @string.Trim(new char[1]);
								global::System.Array.Copy(array3, 44, array5, num3, 15);
								string string2 = asciiencoding.GetString(array5);
								string format = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﾅ쎍\udd8f뮕킗튙펟톡", a_);
								global::System.DateTime value = global::System.DateTime.ParseExact(string2, format, invariantCulture);
								A_1.DVRSTimestamp = new global::System.DateTime?(value);
								num = (short)96731144;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								goto IL_189;
							case 3:
								if (fileStream.Read(array3, num3, num4) == num4)
								{
									num = (short)1420754953;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_339;
							case 4:
								goto IL_1EF;
							case 5:
								num = (short)1414725642;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
							{
								long? num5;
								long num6;
								if (num5.GetValueOrDefault() == num6 & num5 != null)
								{
									num = (short)541261826;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								long? num7;
								A_1.DVRSFileHash = num7;
								global::System.Array.Copy(array3, 18, array6, num3, 1);
								num = (short)1207304199;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
								if (A_2)
								{
									num = (short)2119761925;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_18E;
							case 8:
								goto IL_298;
							case 9:
							{
								int sourceIndex = 60;
								global::System.Array.Copy(array3, sourceIndex, array7, num3, num8);
								uint num9 = global::System.BitConverter.ToUInt32(array7, 0);
								long? num7 = new long?((long)((ulong)num9));
								long? num5 = num7;
								long num6 = 0L;
								num = (short)197722118;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 10:
								if (array6[0] < 2)
								{
									num = (short)176685056;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_18E;
							}
							goto IL_6F;
							IL_18E:
							A_1.PackageVersion = array6[0].ToString();
							array = new byte[1];
							global::System.Array.Copy(array3, 19, array, num3, 1);
							num = (short)79167489;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_189:
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_DVRS_File_Hashcode_Extration_Failed, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_DVRS_File_Hashcode_Extration_Failed);
						IL_1EF:
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_DVRS_File_Invalid_File_Type, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_DVRS_File_Invalid_File_Type);
						IL_298:
						break;
						IL_2D7:
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_DVRS_File_Version_Not_Allowed, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_DVRS_File_Version_Not_Allowed);
						IL_339:
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_DVRS_File_Hashcode_Extration_Failed, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_DVRS_File_Hashcode_Extration_Failed);
						IL_6F:
						int num10 = 64;
						num8 = 4;
						num4 = 64;
						array3 = new byte[num10];
						array7 = new byte[num8];
						array6 = new byte[1];
						array4 = new byte[23];
						array5 = new byte[15];
						asciiencoding = new global::System.Text.ASCIIEncoding();
						invariantCulture = global::System.Globalization.CultureInfo.InvariantCulture;
						num3 = 0;
						num = (short)1662189571;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_3C;
					}
					finally
					{
						num = (short)388366337;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_3FD;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_37B;
								}
								continue;
							case 2:
								((global::System.IDisposable)fileStream).Dispose();
								num = (short)146407424;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_37B:
							num = (short)693343610;
							short num11 = num;
							num = (short)880186746;
							switch ((num11 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1511653376;
								if (num != 0)
								{
								}
								if (fileStream == null)
								{
									goto IL_3FF;
								}
								num = (short)773914626;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
						}
						IL_3FD:
						IL_3FF:;
					}
					break;
				}
				}
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::System.Exception ex)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_DVRS_File_Hashcode_Extration_Failed, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_DVRS_File_Hashcode_Extration_Failed, ex);
			}
			num = (short)298385408;
			short num12 = num;
			num = (short)1745879041;
			if (num != 0)
			{
			}
			return A_1;
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x0015AE54 File Offset: 0x00159054
		private static void a(string A_0, byte[] A_1, global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles A_2)
		{
			int a_ = 3;
			short num = (short)590807040;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				int num3 = -1;
				global::System.IO.FileStream fileStream = new global::System.IO.FileStream(A_0, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
				try
				{
					switch (0)
					{
					case 0:
						goto IL_18A;
					}
					byte[] array4;
					int num5;
					for (;;)
					{
						IL_3F:
						string text;
						string @string;
						string str;
						uint num4;
						switch (num2)
						{
						case 0:
							goto IL_3B4;
						case 1:
							if (!(text == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킅\uda87튉", a_)))
							{
								num = (short)1865154616;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3B4;
						case 2:
							goto IL_3B4;
						case 3:
							if (!(@string == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뚅몇", a_)))
							{
								num = (short)626393156;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1301938233;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							byte[] array = new byte[6];
							byte[] array2;
							global::System.Array.Copy(array2, num3 - 1 + 20, array, 0, 6);
							byte[] array3 = new byte[2];
							global::System.Array.Copy(array2, num3 - 1 + 20 + 6, array3, 0, 2);
							text = "";
							str = "";
							global::System.Text.ASCIIEncoding asciiencoding = new global::System.Text.ASCIIEncoding();
							string string2 = asciiencoding.GetString(array);
							@string = asciiencoding.GetString(array3);
							string a = string2.ToUpper();
							num = (short)1290731574;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							if (num4 != 451766088U)
							{
								num = (short)2002452505;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)546373685;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							num = (short)1837367297;
							if (num != 0)
							{
							}
							str = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("놅뢇몉", a_);
							num = (short)619446272;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_3B4;
						case 8:
							goto IL_3B4;
						case 9:
							num = (short)312541226;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							goto IL_3B4;
						case 11:
							goto IL_3B4;
						case 12:
							if (num4 <= 485321326U)
							{
								num = (short)861863977;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1758789701;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							str = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펅삇첉ꆋ슍", a_);
							num = (short)513736720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							if (!(@string == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뚅릇", a_)))
							{
								num = (short)1825701955;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							str = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킅삇첉", a_);
							num = (short)1782841406;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
						{
							string a;
							if (!(a == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("놅\ude87몉뒋붍좏", a_)))
							{
								num = (short)247005236;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							text = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슅\ude87\ud889", a_);
							num = (short)1602093107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 16:
							goto IL_3B4;
						case 17:
							num = (short)1693646903;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
						{
							string string2;
							A_2.DVRType = string2 + @string;
							num = (short)123338776;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 19:
							if (num4 != 518876564U)
							{
								num = (short)772276244;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)335216689;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
							num = (short)590020616;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 21:
							if (!(@string == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뚅뺇", a_)))
							{
								num = (short)1644429378;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)555024423;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 22:
							if (fileStream.Read(array4, 0, num5 + 1) == num5 + 1)
							{
								num = (short)865599515;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_789;
						case 23:
							num = (short)1954742291;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 24:
							goto IL_456;
						case 25:
							num = (short)1003094089;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 26:
							goto IL_3B4;
						case 27:
							num3 = (int)array4[num5];
							num = (short)1077084232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 28:
							num = (short)630587439;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 29:
							num = (short)295501858;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 30:
							goto IL_1E1;
						case 31:
							if (num3 != -1)
							{
								num = (short)558170145;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_E3B;
						case 32:
							goto IL_3E9;
						case 33:
						{
							int num6 = num3 + 28;
							byte[] array2 = new byte[num6];
							num = (short)1551106091;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 34:
							if (num4 != 485321326U)
							{
								num = (short)629735498;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)639238190;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 35:
							goto IL_3B4;
						case 36:
							num = (short)1713438790;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 37:
							num = (short)213516302;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 38:
							goto IL_3B4;
						case 39:
							if (!(text == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킅\uda87튉", a_)))
							{
								num = (short)1628438587;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3B4;
						case 40:
							if (!(@string == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뚅벇", a_)))
							{
								num = (short)338362432;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)96534529;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 41:
							num = (short)482869253;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 42:
							goto IL_3B4;
						case 43:
						{
							byte[] array2;
							int num6;
							if (fileStream.Read(array2, 0, num6) == num6)
							{
								num = (short)510787588;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_E0E;
						}
						case 44:
							goto IL_3B4;
						case 45:
							num = (short)287047695;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 46:
							if (!(@string == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뚅붇", a_)))
							{
								num = (short)781385805;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1588068400;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 47:
							goto IL_3B4;
						case 48:
							if (!(text == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킅\uda87튉", a_)))
							{
								num = (short)1130758150;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3B4;
						case 49:
							if (!(@string == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뚅뮇", a_)))
							{
								num = (short)1111687196;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1353121868;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 50:
							goto IL_1E1;
						case 51:
							goto IL_1E1;
						case 52:
							num = (short)506921025;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 53:
							if (!(@string == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뚅뾇", a_)))
							{
								num = (short)2024407049;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)296288319;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 54:
						{
							string a;
							if (!(a == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("놅\ude87몉뒋릍좏", a_)))
							{
								num = (short)401473581;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							text = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킅\uda87튉", a_);
							num = (short)647888926;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 55:
							if (num4 != 502098945U)
							{
								num = (short)986775575;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)6815784;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 56:
							str = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펅삇첉ꆋ욍ꊏ", a_);
							num = (short)1779040327;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 57:
							if (text == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킅\uda87튉", a_))
							{
								num = (short)787415101;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							str = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펅삇첉ꆋ슍ꊏ", a_);
							num = (short)554762251;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 58:
							goto IL_3B4;
						case 59:
							str = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뺅뢇몉", a_);
							num = (short)1693646858;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 60:
							if (num4 != 535654183U)
							{
								num = (short)631701540;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1673986051;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 61:
							str = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펅삇첉", a_);
							num = (short)1844772871;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 62:
							goto IL_3B4;
						case 63:
							if (!(text == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킅\uda87튉", a_)))
							{
								num = (short)706478093;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3B4;
						case 64:
							num = (short)1548877850;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 65:
						{
							string a;
							if (!(a == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("놅\ude87몉떋붍좏", a_)))
							{
								num = (short)2070675536;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							text = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("슅\ude87\ud889ꆋ슍좏", a_);
							num = (short)1260257330;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 66:
							num = (short)1086259258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 67:
							num = (short)1377894479;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 68:
							num = (short)314638338;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 69:
							if (num4 <= 518876564U)
							{
								num = (short)1734017041;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1542848572;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 70:
							if (num4 == 552431802U)
							{
								num = (short)1568276517;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3B4;
						case 71:
							goto IL_3B4;
						case 72:
							goto IL_789;
						case 73:
							if (num4 != 468543707U)
							{
								num = (short)257097757;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)583598101;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 74:
							num = (short)1517355046;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 75:
							str = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("놅ꞇ늉벋뺍", a_);
							num = (short)1340080206;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 76:
							if (text == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킅\uda87튉", a_))
							{
								num = (short)2010120267;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							str = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펅삇첉ꆋ욍", a_);
							num = (short)1010630691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 77:
							num = (short)2118713388;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 78:
							goto IL_3B4;
						case 79:
							goto IL_3B4;
						case 80:
							num = (short)1953497106;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18A;
						IL_1E1:
						num4 = global::<PrivateImplementationDetails>.ComputeStringHash(@string);
						num = (short)316407820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3B4:
						A_2.DVRType = text + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꚅ", a_) + str;
						num = (short)1284046880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_789:
						num = (short)1186922527;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_3E9:
					IL_456:
					goto IL_F06;
					IL_E0E:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_DVRS_File_Parsing_Hardware_Part_Number_Failed, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_DVRS_File_Parsing_Hardware_Part_Number_Failed);
					IL_E3B:
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_DVRS_File_Parsing_Hardware_Part_Number_Failed, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_DVRS_File_Parsing_Hardware_Part_Number_Failed);
					IL_18A:
					num5 = (int)A_1[0];
					array4 = new byte[num5 + 1];
					num = (short)547029014;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_3F;
				}
				finally
				{
					num = (short)1542717442;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_F03;
						case 1:
						{
							num = (short)1104881782;
							short num7 = num;
							num = (short)1563961462;
							switch ((num7 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							default:
								num = (short)2050883584;
								if (num != 0)
								{
								}
								((global::System.IDisposable)fileStream).Dispose();
								num = (short)2136276992;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_E7D;
							}
							continue;
						}
						IL_E7D:
						if (fileStream == null)
						{
							break;
						}
						num = (short)2029191169;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_F03:;
				}
				IL_F06:
				num = (short)256835584;
				short num8 = num;
				return;
			}
			}
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x0015BDB0 File Offset: 0x00159FB0
		public static global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles[] GenerateNewDVRSFilePackageData(global::Motorola.CommonCPS.Server.EntityModel.Package[] serverDVRSPackages, string outPutDir)
		{
			short num = (short)1408696320;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5E;
				}
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles> list;
				global::System.Collections.Generic.List<string> list3;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>.Enumerator enumerator;
					global::SpecialFeatures.DVRSFiles.List.DVRSFileListRecSet dvrsfileListRecSet;
					global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>> list2;
					int num5;
					switch (num2)
					{
					case 0:
					{
						num = (short)596377600;
						short num3 = num;
						goto IL_28A;
					}
					case 1:
						num = (short)1409417217;
						if (num != 0)
						{
						}
						goto IL_312;
					case 2:
						try
						{
							num = (short)416743428;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								IL_172:
								switch (num2)
								{
								case 0:
									goto IL_277;
								case 2:
									while (enumerator.MoveNext())
									{
										global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair = enumerator.Current;
										list.Add(global::SpecialFeatures.DVRSFiles.DVRSFilesHelper.a(keyValuePair.Value, false, keyValuePair.Key));
										num = (short)2011688315;
										short num4 = num;
										num = (short)1131539835;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											num = (short)1018757120;
											if (num != 0)
											{
											}
											num = (short)415498241;
											num2 = (int)((global::System.IntPtr)num);
											goto IL_172;
										}
									}
									num = (short)1284636675;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)218038272;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_18D;
									}
									continue;
								}
								IL_21C:
								num = (short)1548943362;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_18D:
								goto IL_21C;
							}
							IL_277:
							goto IL_870;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_28A;
					case 3:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = dvrsfileListRecSet.GetEnumerator();
						num = (short)501153798;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)1007812613;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (dvrsfileListRecSet.Count > 0)
						{
							num = (short)1828061187;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AA;
					case 6:
						try
						{
							num = (short)1005781005;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
								global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerRecset dvrsfileListInnerRecset;
								global::SpecialFeatures.DVRSFiles.List.DVRSFileList dvrsfileList;
								switch (num2)
								{
								case 0:
									if (!enumerator2.MoveNext())
									{
										num = (short)534839298;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_732;
								case 2:
									num = (short)352649219;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_7AB;
								case 4:
									num = (short)407961609;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									try
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator3 = dvrsfileListInnerRecset.GetEnumerator();
										try
										{
											num = (short)739377156;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
													goto IL_681;
												case 2:
												{
													if (!enumerator3.MoveNext())
													{
														num = (short)1631977475;
														num2 = (int)((global::System.IntPtr)num);
														continue;
													}
													global::SpecialFeatures.DVRSFiles.List.DVRSFileListInner dvrsfileListInner = (global::SpecialFeatures.DVRSFiles.List.DVRSFileListInner)enumerator3.Current;
													string hex = dvrsfileListInner.DVRSFileListInnerSection.DVRSConfigDVRSFileData_A43734Value;
													byte[] array = global::System.Linq.Enumerable.Range(0, hex.Length / 2).Select(delegate(int x)
													{
														short num6 = (short)1262162512;
														short num7 = num6;
														num6 = (short)226759248;
														switch (num7 == num6)
														{
														default:
														{
															num6 = (short)1127743488;
															short num8 = num6;
															break;
														}
														case true:
															break;
														}
														num6 = (short)1233649665;
														if (num6 != 0)
														{
														}
														num6 = (short)1250426880;
														if (num6 != 0)
														{
														}
														return global::System.Convert.ToByte(hex.Substring(x * 2, 2), 16);
													}).ToArray<byte>();
													int count = array.Length;
													global::System.IO.BinaryWriter binaryWriter;
													binaryWriter.Write(array, 0, count);
													num = (short)989593601;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												case 3:
													num = (short)1245184000;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 4:
													switch (0)
													{
													case 0:
														goto IL_5A2;
													}
													continue;
												}
												IL_62A:
												num = (short)1566507010;
												num2 = (int)((global::System.IntPtr)num);
												continue;
												IL_5A2:
												goto IL_62A;
											}
											IL_681:;
										}
										finally
										{
											num = (short)1540227074;
											num2 = (int)((global::System.IntPtr)num);
											for (;;)
											{
												switch (num2)
												{
												case 0:
													goto IL_6EE;
												case 1:
													enumerator3.Dispose();
													num = (short)497287168;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												case 2:
													switch (0)
													{
													case 0:
														goto IL_6B6;
													}
													continue;
												}
												IL_6B6:
												if (enumerator3 == null)
												{
													break;
												}
												num = (short)1367474177;
												num2 = (int)((global::System.IntPtr)num);
											}
											IL_6EE:;
										}
										goto IL_4BF;
									}
									catch (global::System.Exception)
									{
										string message = global::CommonResources.AppResources.Failed_to_generate_file.AcpStringFormat(new object[]
										{
											dvrsfileList.Labtool.DVRSConfigDVRSFileName_A43736Value
										});
										global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, message);
										goto IL_4BF;
									}
									finally
									{
										global::System.IO.BinaryWriter binaryWriter;
										binaryWriter.Close();
									}
									goto IL_732;
									IL_4BF:
									string text;
									global::System.Collections.Generic.KeyValuePair<string, string> item = new global::System.Collections.Generic.KeyValuePair<string, string>(dvrsfileList.Labtool.DVRSConfigDVRSFileName_A43736Value, text);
									list2.Add(item);
									num = (short)1186004993;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									if (dvrsfileListInnerRecset.Count > 0)
									{
										num = (short)1262223368;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 7:
									if (dvrsfileList.Labtool.DVRSConfigDVRSFileName_A43736_Valid)
									{
										num = (short)793575428;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 8:
									num = (short)1592524807;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									if (!list3.Contains(dvrsfileList.Labtool.DVRSConfigDVRSFileName_A43736Value))
									{
										num = (short)1514602506;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 10:
								{
									string extension = global::System.IO.Path.GetExtension(dvrsfileList.Labtool.DVRSConfigDVRSFileName_A43736Value);
									string text = global::System.IO.Path.Combine(outPutDir, global::System.Guid.NewGuid().ToString() + extension);
									global::System.IO.BinaryWriter binaryWriter = new global::System.IO.BinaryWriter(new global::System.IO.FileStream(text, global::System.IO.FileMode.Create, global::System.IO.FileAccess.Write, global::System.IO.FileShare.None), global::System.Text.Encoding.ASCII);
									num = (short)507772933;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									num = (short)1339555846;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									if (dvrsfileListInnerRecset != null)
									{
										num = (short)772603915;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 13:
									switch (0)
									{
									case 0:
										goto IL_3B1;
									}
									continue;
								}
								IL_47D:
								num = (short)88211456;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3B1:
								goto IL_47D;
								IL_732:
								dvrsfileList = (global::SpecialFeatures.DVRSFiles.List.DVRSFileList)enumerator2.Current;
								dvrsfileListInnerRecset = (dvrsfileList.Labtool.EmbeddedRecset as global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerRecset);
								num = (short)2052194316;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_7AB:
							goto IL_2AA;
						}
						finally
						{
							num = (short)303824898;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
								switch (num2)
								{
								case 0:
									goto IL_81B;
								case 1:
									enumerator2.Dispose();
									num = (short)490799104;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_7E2;
									}
									continue;
								}
								IL_7E2:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)979566593;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_81B:;
						}
						goto IL_81E;
					case 7:
					{
						if (num5 >= serverDVRSPackages.Length)
						{
							num = (short)2078605322;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles astrodvrsfiles = (global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles)serverDVRSPackages[num5];
						list3.Add(astrodvrsfiles.PackageName);
						num5++;
						num = (short)1682309121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_312;
					case 9:
						if (dvrsfileListRecSet != null)
						{
							num = (short)2105475076;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AA;
					case 10:
						goto IL_81E;
					case 11:
						if (serverDVRSPackages != null)
						{
							num = (short)1336410112;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_81E;
					}
					goto IL_5E;
					IL_28A:
					num5 = 0;
					num = (short)488833032;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2AA:
					enumerator = list2.GetEnumerator();
					num = (short)524746754;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_312:
					num = (short)189988871;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_81E:
					list2 = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>();
					dvrsfileListRecSet = (global::AcpCommonLib.FeatureManager.GetFeature(4234) as global::SpecialFeatures.DVRSFiles.List.DVRSFileListRecSet);
					num = (short)114819081;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_870:
				return list.ToArray();
				IL_5E:
				list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles>();
				list3 = new global::System.Collections.Generic.List<string>();
				num = (short)2096431115;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x0015C6B0 File Offset: 0x0015A8B0
		private static byte[] b(string A_0)
		{
			short num = (short)1483711955;
			short num2 = num;
			num = (short)745317843;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_FE:
				num = (short)718733312;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)117243904;
				if (num != 0)
				{
				}
				num = (short)42401792;
				num3 = (int)num;
				switch (num3)
				{
				default:
					switch (0)
					{
					case 0:
						goto IL_B2;
					}
					break;
				}
				break;
			}
			byte[] array;
			int num5;
			int num6;
			char[] array2;
			for (;;)
			{
				IL_73:
				num = (short)495517696;
				short num4 = num;
				switch (num3)
				{
				case 0:
					return array;
				case 1:
					goto IL_E2;
				case 2:
					num = (short)959512577;
					if (num != 0)
					{
					}
					goto IL_E2;
				case 3:
					if (num5 >= num6)
					{
						goto IL_FE;
					}
					A_0.CopyTo(num5 * 2, array2, 0, 2);
					array[num5] = global::System.Convert.ToByte(new string(array2), 16);
					num5++;
					num = (short)1490681858;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_B2;
				IL_E2:
				num = (short)390266883;
				num3 = (int)((global::System.IntPtr)num);
			}
			return array;
			IL_B2:
			num6 = A_0.Length / 2;
			array = new byte[num6];
			array2 = new char[2];
			num5 = 0;
			num = (short)2021916673;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_73;
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x0015C83C File Offset: 0x0015AA3C
		public static void AttachDVRSFileReference(global::Motorola.CommonCPS.Server.EntityModel.APXTemplate template)
		{
			short num = (short)1970323064;
			short num2 = num;
			num = (short)1639235192;
			switch (num2 == num)
			{
			}
			num = (short)1414987777;
			if (num != 0)
			{
			}
			num = (short)1016266752;
			short num3 = num;
			num = (short)799866880;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles[] collection = global::SpecialFeatures.DVRSFiles.DVRSFilesHelper.GenerateNewDVRSFilePackageData(null, global::SpecialFeatures.DVRSFiles.DVRSFilesHelper.TempFolder);
			template.ASTRODVRSFiles = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles>(collection);
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x0015C900 File Offset: 0x0015AB00
		public static global::System.Collections.Generic.List<string> GetDVRSFileListFromCP()
		{
			short num = (short)798949376;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_42;
				}
				global::SpecialFeatures.DVRSFiles.List.DVRSFileListRecSet dvrsfileListRecSet;
				global::System.Collections.Generic.List<string> list;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						if (dvrsfileListRecSet.Count > 0)
						{
							num = (short)1482162177;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return list;
					case 1:
						num = (short)1730215937;
						if (num != 0)
						{
						}
						goto IL_2E8;
					case 2:
						if (dvrsfileListRecSet != null)
						{
							num = (short)549978112;
							short num3 = num;
							num = (short)1010696196;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return list;
					case 3:
					{
						num = (short)1934349456;
						short num4 = num;
						num = (short)1845613712;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_B5;
						default:
							num = (short)1029570560;
							if (num != 0)
							{
							}
							try
							{
								num = (short)1827536904;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)228720643;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
									{
										global::SpecialFeatures.DVRSFiles.List.DVRSFileList dvrsfileList;
										if (dvrsfileList.Labtool.DVRSConfigDVRSFileName_A43736_Valid)
										{
											num = (short)1984167943;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
										goto IL_278;
									case 3:
									{
										global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerRecset dvrsfileListInnerRecset;
										if (dvrsfileListInnerRecset.Count > 0)
										{
											num = (short)752484358;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 5:
									{
										global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerRecset dvrsfileListInnerRecset;
										if (dvrsfileListInnerRecset != null)
										{
											num = (short)71106560;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 6:
										num = (short)4456449;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
									{
										global::SpecialFeatures.DVRSFiles.List.DVRSFileList dvrsfileList;
										list.Add(dvrsfileList.Labtool.DVRSConfigDVRSFileName_A43736Value.ToLower());
										num = (short)2006319108;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 8:
										switch (0)
										{
										case 0:
											goto IL_10E;
										}
										continue;
									case 9:
										num = (short)660996098;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 10:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)50331657;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::SpecialFeatures.DVRSFiles.List.DVRSFileList dvrsfileList = (global::SpecialFeatures.DVRSFiles.List.DVRSFileList)enumerator.Current;
										global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerRecset dvrsfileListInnerRecset = dvrsfileList.Labtool.EmbeddedRecset as global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerRecset;
										num = (short)762511365;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_19A:
									num = (short)1885470730;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_10E:
									goto IL_19A;
								}
								IL_278:
								return list;
							}
							finally
							{
								num = (short)778371072;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_2B0;
										}
										continue;
									case 1:
										goto IL_2E5;
									case 2:
										enumerator.Dispose();
										num = (short)518717441;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_2B0:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1918107650;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_2E5:;
							}
							goto IL_2E8;
						}
						break;
					}
					case 4:
						goto IL_B5;
					}
					goto IL_42;
					IL_B5:
					num = (short)1819672576;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E8:
					enumerator = dvrsfileListRecSet.GetEnumerator();
					num = (short)1673658371;
					num2 = (int)((global::System.IntPtr)num);
				}
				return list;
				IL_42:
				list = new global::System.Collections.Generic.List<string>();
				dvrsfileListRecSet = (global::AcpCommonLib.FeatureManager.GetFeature(4234) as global::SpecialFeatures.DVRSFiles.List.DVRSFileListRecSet);
				num = (short)471465986;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x0015CCE8 File Offset: 0x0015AEE8
		private static void a(string A_0)
		{
			short num;
			try
			{
				num = (short)404333600;
				short num2 = num;
				num = (short)1439736864;
				switch (num2 == num)
				{
				}
				num = (short)1593442304;
				if (num != 0)
				{
				}
				num = (short)1109393409;
				if (num != 0)
				{
				}
				global::System.IO.File.SetAttributes(A_0, global::System.IO.FileAttributes.Normal);
				global::System.IO.File.Delete(A_0);
			}
			catch
			{
			}
			num = (short)1236336640;
			short num3 = num;
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x0015CDB8 File Offset: 0x0015AFB8
		public static void UpdateDVRSFilesContent(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles> templateDVRSFiles, global::Motorola.CommonCPS.Server.EntityModel.APXTemplate template)
		{
			int a_ = 19;
			short num = (short)1955528704;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_69;
				}
				global::System.Collections.Generic.List<string> dvrsfileListFromCP;
				global::System.Collections.Generic.List<string> list;
				global::System.Collections.Generic.Dictionary<global::System.Guid, string> dictionary;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles>.Enumerator enumerator4;
				for (;;)
				{
					IL_32:
					global::SpecialFeatures.DVRSFiles.List.DVRSFileListRecSet dvrsfileListRecSet;
					global::System.Collections.Generic.List<string>.Enumerator enumerator;
					global::System.Collections.Generic.List<string> list2;
					switch (num2)
					{
					case 0:
						goto IL_64F;
					case 1:
						goto IL_8C1;
					case 2:
						if (dvrsfileListRecSet != null)
						{
							num = (short)1032454145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_474;
					case 3:
						goto IL_79D;
					case 4:
						if (!dvrsfileListFromCP.SequenceEqual(list))
						{
							num = (short)129564679;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C1;
					case 5:
						try
						{
							num = (short)1060634629;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									try
									{
										num = (short)166264835;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												if (!enumerator.MoveNext())
												{
													num = (short)2061631493;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												string text = enumerator.Current;
												num = (short)58327046;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
												goto IL_2ED;
											case 3:
												switch (0)
												{
												case 0:
													goto IL_222;
												}
												continue;
											case 4:
											{
												string text;
												global::SpecialFeatures.DVRSFiles.List.DVRSFileLabtoolSection dvrsfileLabtoolSection;
												global::SpecialFeatures.DVRSFiles.DVRSFilesHelper.populateDvrsFileDbRecords(dvrsfileLabtoolSection, text);
												num = (short)1261305857;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 5:
												num = (short)1006764034;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 6:
											{
												string text;
												global::SpecialFeatures.DVRSFiles.List.DVRSFileLabtoolSection dvrsfileLabtoolSection;
												if (string.Compare(global::System.IO.Path.GetFileName(text), dvrsfileLabtoolSection.DVRSConfigDVRSFileName_A43736Value, true) == 0)
												{
													num = (short)248184836;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											}
											IL_295:
											num = (short)1348665344;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_222:
											goto IL_295;
										}
										IL_2ED:
										break;
									}
									finally
									{
										((global::System.IDisposable)enumerator).Dispose();
									}
									goto IL_300;
								case 1:
								{
									global::SpecialFeatures.DVRSFiles.List.DVRSFileLabtoolSection dvrsfileLabtoolSection;
									if (dvrsfileLabtoolSection.DVRSConfigDVRSFileName_A43736_Valid)
									{
										num = (short)693960711;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)1751842822;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::SpecialFeatures.DVRSFiles.List.DVRSFileLabtoolSection dvrsfileLabtoolSection = ((global::SpecialFeatures.DVRSFiles.List.DVRSFileList)enumerator2.Current)[10893] as global::SpecialFeatures.DVRSFiles.List.DVRSFileLabtoolSection;
									num = (short)24182785;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_318;
								case 4:
									enumerator = list2.GetEnumerator();
									num = (short)700514304;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_E7;
									}
									continue;
								case 6:
									goto IL_300;
								case 7:
									num = (short)870252552;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::SpecialFeatures.DVRSFiles.List.DVRSFileLabtoolSection dvrsfileLabtoolSection;
									if (dvrsfileLabtoolSection.DVRSConfigDVRSFileName_A43736Object != null)
									{
										num = (short)145293316;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_120:
								num = (short)1860435970;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E7:
								goto IL_120;
								IL_300:
								num = (short)1267859459;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_318:
							goto IL_474;
						}
						finally
						{
							num = (short)1628504066;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
								switch (num2)
								{
								case 0:
									goto IL_387;
								case 1:
									enumerator2.Dispose();
									num = (short)1155923968;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_350;
									}
									continue;
								}
								IL_350:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)566165505;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_387:;
						}
						goto IL_38A;
					case 6:
						goto IL_38A;
					case 7:
					{
						num = (short)2359296;
						short num3 = num;
						global::System.Collections.Generic.Dictionary<global::System.Guid, string>.Enumerator enumerator3 = dictionary.GetEnumerator();
						num = (short)632094720;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (list2.Count > 0)
						{
							num = (short)993656843;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_474;
					case 9:
						try
						{
							num = (short)880607233;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (!enumerator.MoveNext())
									{
										num = (short)699924483;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::SpecialFeatures.DVRSFiles.DVRSFilesHelper.a(enumerator.Current);
									goto IL_57D;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_56F;
									}
									continue;
								case 2:
									goto IL_63C;
								case 3:
									num = (short)316014594;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_56F;
								IL_57D:
								num = (short)1870921732;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_595:
								num = (short)1262942070;
								short num4 = num;
								num = (short)1836250998;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_57D;
								default:
									num = (short)1080557568;
									if (num != 0)
									{
									}
									num = (short)613154816;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_56F:
								goto IL_595;
							}
							IL_63C:
							goto IL_904;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto Block_6;
					case 10:
						if (dvrsfileListRecSet.Count > 0)
						{
							num = (short)1602879494;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_474;
					case 11:
					{
						num = (short)671875073;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = dvrsfileListRecSet.GetEnumerator();
						num = (short)2125660165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_69;
					IL_38A:
					num = (short)360382472;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_7:
					try
					{
						IL_79D:
						num = (short)1625292802;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								if (!enumerator4.MoveNext())
								{
									num = (short)1961754628;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles astrodvrsfiles = enumerator4.Current;
								list.Add(astrodvrsfiles.PackageName.ToLower());
								num = (short)1072889861;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								goto IL_8AE;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_7DD;
								}
								continue;
							case 3:
								try
								{
									global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles astrodvrsfiles;
									dictionary.Add(astrodvrsfiles.Uuid, astrodvrsfiles.PackageName);
								}
								catch
								{
								}
								break;
							case 4:
								num = (short)2012151809;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
							{
								global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles astrodvrsfiles;
								if (dvrsfileListFromCP.Contains(astrodvrsfiles.PackageName.ToLower()))
								{
									num = (short)314507267;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_856:
							num = (short)76808192;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_7DD:
							goto IL_856;
						}
						IL_8AE:
						goto IL_3F6;
					}
					finally
					{
						((global::System.IDisposable)enumerator4).Dispose();
					}
					goto IL_8C1;
					IL_3F6:
					list2 = new global::System.Collections.Generic.List<string>();
					dvrsfileListFromCP.Sort();
					list.Sort();
					num = (short)137822212;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_6:
					try
					{
						IL_64F:
						num = (short)100728833;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::System.Collections.Generic.Dictionary<global::System.Guid, string>.Enumerator enumerator3;
								if (!enumerator3.MoveNext())
								{
									num = (short)572850179;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.KeyValuePair<global::System.Guid, string> keyValuePair = enumerator3.Current;
								string text2 = global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().DownloadPackage(keyValuePair.Key);
								global::System.IO.File.Copy(text2, text2.Replace(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뢕", a_), ""), true);
								global::SpecialFeatures.DVRSFiles.DVRSFilesHelper.a(text2);
								text2 = text2.Replace(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뢕", a_), "");
								list2.Add(text2.Replace(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("릕", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪕", a_)));
								num = (short)658178052;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								switch (0)
								{
								case 0:
									goto IL_68A;
								}
								continue;
							case 2:
								goto IL_78A;
							case 3:
								num = (short)1190854658;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_733:
							num = (short)1883766784;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_68A:
							goto IL_733;
						}
						IL_78A:
						goto IL_4C1;
					}
					finally
					{
						global::System.Collections.Generic.Dictionary<global::System.Guid, string>.Enumerator enumerator3;
						((global::System.IDisposable)enumerator3).Dispose();
					}
					goto Block_7;
					IL_474:
					enumerator = list2.GetEnumerator();
					num = (short)861732873;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4C1:
					dvrsfileListRecSet = (global::AcpCommonLib.FeatureManager.GetFeature(4234) as global::SpecialFeatures.DVRSFiles.List.DVRSFileListRecSet);
					num = (short)1008664578;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8C1:
					num = (short)90832906;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_904:
				global::SpecialFeatures.DVRSFiles.DVRSFilesHelper.UpdateDVRSFileReference(template);
				return;
				IL_69:
				dvrsfileListFromCP = global::SpecialFeatures.DVRSFiles.DVRSFilesHelper.GetDVRSFileListFromCP();
				list = new global::System.Collections.Generic.List<string>();
				dictionary = new global::System.Collections.Generic.Dictionary<global::System.Guid, string>();
				enumerator4 = templateDVRSFiles.GetEnumerator();
				num = (short)435552259;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x0015D764 File Offset: 0x0015B964
		public static void UpdateDVRSFileReference(global::Motorola.CommonCPS.Server.EntityModel.APXTemplate template)
		{
			short num = (short)1092747264;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4A;
				}
				int num5;
				global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles[] array;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles astrodvrsfiles;
						template.ASTRODVRSFiles.Add(astrodvrsfiles);
						goto IL_A7;
					}
					case 1:
					{
						global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles astrodvrsfiles;
						if (astrodvrsfiles == null)
						{
							goto IL_7D;
						}
						num = (short)1706559642;
						short num3 = num;
						num = (short)667879578;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A7;
						default:
						{
							num = (short)1886322688;
							if (num != 0)
							{
							}
							num = (short)830210048;
							short num4 = num;
							num = (short)1566244865;
							if (num != 0)
							{
							}
							num = (short)1036517376;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
						return;
					case 3:
						goto IL_1AD;
					case 4:
						goto IL_7D;
					case 5:
					{
						if (num5 >= array.Length)
						{
							num = (short)218365954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles package = array[num5];
						global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles astrodvrsfiles = global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().UploadDVRSFilePackage(package) as global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles;
						num = (short)1730609153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_1AD;
					}
					goto IL_4A;
					IL_7D:
					num5++;
					num = (short)1180827654;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A7:
					num = (short)2034171908;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1AD:
					num = (short)502005765;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_4A:
				global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles[] array2 = global::SpecialFeatures.DVRSFiles.DVRSFilesHelper.GenerateNewDVRSFilePackageData(null, global::SpecialFeatures.DVRSFiles.DVRSFilesHelper.TempFolder);
				template.ASTRODVRSFiles.Clear();
				array = array2;
				num5 = 0;
				num = (short)1819869187;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x0015D95C File Offset: 0x0015BB5C
		public static global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles> GetExistingPackageData(global::Motorola.CommonCPS.Server.EntityModel.Package[] serverDVRSFilesPackages)
		{
			short num = (short)955121664;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_82;
				}
				global::System.Collections.Generic.List<string> list2;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles> list3;
				for (;;)
				{
					IL_27:
					global::Motorola.CommonCPS.Server.EntityModel.Package[] array;
					int num4;
					switch (num2)
					{
					case 0:
						goto IL_3EC;
					case 1:
						goto IL_50B;
					case 2:
					{
						global::System.Collections.Generic.List<string> list;
						global::SpecialFeatures.DVRSFiles.List.DVRSFileLabtoolSection dvrsfileLabtoolSection;
						list.Add(dvrsfileLabtoolSection.DVRSConfigDVRSFileName_A43736Value);
						num = (short)2089746435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_C7;
					case 4:
					{
						global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
						global::SpecialFeatures.DVRSFiles.List.DVRSFileListRecSet dvrsfileListRecSet = global::AcpCommonLib.FeatureManager.GetFeature(4234) as global::SpecialFeatures.DVRSFiles.List.DVRSFileListRecSet;
						num = (short)1193607184;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::SpecialFeatures.DVRSFiles.List.DVRSFileLabtoolSection dvrsfileLabtoolSection;
						if (list2.Contains(dvrsfileLabtoolSection.DVRSConfigDVRSFileName_A43736Value))
						{
							num = (short)850067458;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C7;
					}
					case 6:
					{
						num = (short)1038850285;
						short num3 = num;
						num = (short)2015926509;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_50B;
						default:
						{
							num = (short)2000093184;
							if (num != 0)
							{
							}
							global::SpecialFeatures.DVRSFiles.List.DVRSFileListRecSet dvrsfileListRecSet;
							global::SpecialFeatures.DVRSFiles.List.DVRSFileLabtoolSection dvrsfileLabtoolSection = dvrsfileListRecSet[0][10893] as global::SpecialFeatures.DVRSFiles.List.DVRSFileLabtoolSection;
							num = (short)1330118666;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 7:
						array = serverDVRSFilesPackages;
						num4 = 0;
						num = (short)561578002;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						num = (short)2022637568;
						short num5 = num;
						num = (short)3932164;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						num = (short)118882305;
						if (num != 0)
						{
						}
						if (num4 >= array.Length)
						{
							num = (short)1447493640;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles astrodvrsfiles = (global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles)array[num4];
						list2.Add(astrodvrsfiles.PackageName);
						num4++;
						num = (short)923009024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						global::SpecialFeatures.DVRSFiles.List.DVRSFileLabtoolSection dvrsfileLabtoolSection;
						if (dvrsfileLabtoolSection.DVRSConfigDVRSFileName_A43736_Valid)
						{
							num = (short)1155137537;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C7;
					}
					case 11:
						goto IL_338;
					case 12:
						if (serverDVRSFilesPackages != null)
						{
							num = (short)332595207;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21D;
					case 13:
					{
						global::SpecialFeatures.DVRSFiles.List.DVRSFileListRecSet dvrsfileListRecSet;
						if (dvrsfileListRecSet.Count > 0)
						{
							num = (short)772079622;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_552;
					}
					case 14:
						goto IL_338;
					case 15:
						try
						{
							num = (short)2083979265;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.List<string>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)2046164995;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string b = enumerator.Current;
									num = (short)389873670;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_261;
									}
									continue;
								case 2:
									goto IL_307;
								case 3:
									num = (short)677838852;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_325;
								case 5:
								{
									global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles astrodvrsfiles2;
									list3.Add(astrodvrsfiles2);
									num = (short)1974599682;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									string b;
									global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles astrodvrsfiles2;
									if (string.Equals(astrodvrsfiles2.PackageName, b, global::System.StringComparison.CurrentCultureIgnoreCase))
									{
										num = (short)1932918789;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_263:
								num = (short)1821835264;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_261:
								goto IL_263;
							}
							IL_307:
							IL_325:
							goto IL_19E;
						}
						finally
						{
							global::System.Collections.Generic.List<string>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_338;
						IL_19E:
						num4++;
						num = (short)1061486606;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						global::SpecialFeatures.DVRSFiles.List.DVRSFileListRecSet dvrsfileListRecSet;
						if (dvrsfileListRecSet != null)
						{
							num = (short)1275658259;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_552;
					}
					case 17:
					{
						if (num4 >= array.Length)
						{
							num = (short)15597588;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles astrodvrsfiles2 = (global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles)array[num4];
						global::System.Collections.Generic.List<string> list;
						global::System.Collections.Generic.List<string>.Enumerator enumerator = list.GetEnumerator();
						num = (short)786956303;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						goto IL_3EC;
					case 19:
						num = (short)1072300045;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						return list3;
					}
					goto IL_82;
					IL_C7:
					array = serverDVRSFilesPackages;
					num4 = 0;
					num = (short)36962315;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_338:
					num = (short)1090912273;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3EC:
					num = (short)331022345;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_50B:
					num = (short)2141650949;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_21D:
				return null;
				IL_552:
				return null;
				IL_82:
				list3 = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles>();
				list2 = new global::System.Collections.Generic.List<string>();
				num = (short)423624716;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x0015DEDC File Offset: 0x0015C0DC
		public static void ApplyDVRSFileDataFromTemplateUsingCruncherData(global::Motorola.CommonCPS.Server.EntityModel.APXTemplate currentTpl, global::Motorola.CommonCPS.Server.EntityModel.CruncherData cruncherData)
		{
			short num = (short)2131099648;
			switch (num)
			{
			default:
			{
				num = (short)828309504;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)586600531;
						short num3 = num;
						num = (short)535941203;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)72744960;
							if (num != 0)
							{
							}
							num = (short)1942552577;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_CE;
							}
							continue;
						}
						break;
					}
					case 1:
						if (currentTpl.ASTRODVRSFiles.Any<global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles>())
						{
							num = (short)1218379781;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E1;
					case 2:
						goto IL_39D;
					case 3:
						return;
					case 4:
						try
						{
							num = (short)803274758;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								bool flag;
								switch (num2)
								{
								case 0:
								{
									global::System.Guid? packageUUID2;
									global::System.Guid empty;
									flag = (packageUUID2.GetValueOrDefault() != empty);
									goto IL_26B;
								}
								case 1:
									num = (short)1752367115;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::System.Guid? packageUUID2;
									global::SpecialFeatures.DVRSFiles.List.DVRSFileListRecSet dvrsfileListRecSet;
									global::SpecialFeatures.DVRSFiles.DVRSFilesHelper.PopulateDvrsFileDbRecordsFromCruncherData(dvrsfileListRecSet[0][10893] as global::SpecialFeatures.DVRSFiles.List.DVRSFileLabtoolSection, cruncherData.DVRSFilesContent.First(delegate(global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.Package, byte[]> f)
									{
										switch (0)
										{
										case 0:
											goto IL_20;
										}
										int num5;
										global::System.Guid? fileUuid;
										short num6;
										global::System.Guid? packageUUID2;
										for (;;)
										{
											IL_0A:
											switch (num5)
											{
											case 0:
												if (fileUuid == null)
												{
													goto IL_131;
												}
												goto IL_14D;
											case 1:
											{
												num6 = (short)613265471;
												short num7 = num6;
												num6 = (short)1836560447;
												switch ((num7 == num6) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_131;
												default:
													goto IL_A7;
												}
												break;
											}
											case 2:
												if (fileUuid != null != (packageUUID2 != null))
												{
													num6 = (short)2011299841;
													num5 = (int)((global::System.IntPtr)num6);
													continue;
												}
												num6 = (short)782696448;
												num5 = (int)((global::System.IntPtr)num6);
												continue;
											case 3:
												goto IL_149;
											}
											goto IL_20;
											IL_131:
											num6 = (short)1941766147;
											num5 = (int)((global::System.IntPtr)num6);
										}
										IL_A7:
										num6 = (short)394330112;
										if (num6 != 0)
										{
										}
										num6 = (short)1564934144;
										short num8 = num6;
										return false;
										IL_149:
										num6 = (short)229769217;
										if (num6 != 0)
										{
										}
										return true;
										IL_14D:
										return fileUuid.GetValueOrDefault() == packageUUID2.GetValueOrDefault();
										IL_20:
										fileUuid = f.Key.FileUuid;
										packageUUID2 = CS$<>8__locals1.packageUUID;
										num6 = (short)556007426;
										num5 = (int)((global::System.IntPtr)num6);
										goto IL_0A;
									}));
									num = (short)2135883778;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									flag = false;
									goto IL_26B;
								case 5:
								{
									global::SpecialFeatures.DVRSFiles.List.DVRSFileListRecSet dvrsfileListRecSet;
									string packageName;
									if (!global::SpecialFeatures.DVRSFiles.DVRSFilesHelper.a(dvrsfileListRecSet, packageName))
									{
										num = (short)1051131907;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_156;
									}
									continue;
								case 7:
								{
									global::System.Guid? packageUUID2;
									if (packageUUID2 == null)
									{
										num = (short)1876951041;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)963379213;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									num = (short)949288970;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1344077832;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles astrodvrsfiles = enumerator.Current;
									string packageName = astrodvrsfiles.PackageName;
									global::System.Guid? packageUUID = astrodvrsfiles.FileUuid;
									global::SpecialFeatures.DVRSFiles.List.DVRSFileListRecSet dvrsfileListRecSet = global::AcpCommonLib.FeatureManager.GetFeature(4234) as global::SpecialFeatures.DVRSFiles.List.DVRSFileListRecSet;
									global::System.Guid? packageUUID2 = packageUUID;
									global::System.Guid empty = global::System.Guid.Empty;
									num = (short)124256263;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									goto IL_38A;
								case 11:
									flag = true;
									goto IL_26B;
								case 12:
									num = (short)1809186820;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
								{
									global::System.Guid? packageUUID2;
									if (packageUUID2 == null)
									{
										num = (short)199098380;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1333067776;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
									num = (short)1757020165;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_196:
								num = (short)584712201;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_26B:
								if (flag)
								{
									num = (short)1379663886;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_156:
								goto IL_196;
							}
							IL_38A:
							return;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_39D;
					case 5:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles>.Enumerator enumerator = currentTpl.ASTRODVRSFiles.GetEnumerator();
						num = (short)156041216;
						short num4 = num;
						num = (short)2050359300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_CE:
					if (currentTpl.ASTRODVRSFiles != null)
					{
						num = (short)1335033858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3E1;
					IL_39D:
					num = (short)815464449;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3E1:
					global::SpecialFeatures.DVRSFiles.DVRSFilesHelper.a();
					num = (short)111738883;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x0015E35C File Offset: 0x0015C55C
		public static void ApplyDVRSFileDataFromTemplate(global::Motorola.CommonCPS.Server.EntityModel.APXTemplate currentTpl)
		{
			short num = (short)1702035456;
			switch (num)
			{
			default:
			{
				num = (short)1075904512;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1133576193;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
					{
						num = (short)578319770;
						short num3 = num;
						num = (short)943748506;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1629618176;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_CE;
							}
							continue;
						}
						break;
					}
					case 1:
						if (currentTpl.ASTRODVRSFiles.Any<global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles>())
						{
							num = (short)1243414533;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31A;
					case 2:
						goto IL_2D7;
					case 3:
						return;
					case 4:
						try
						{
							num = (short)1275396096;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_13E;
									}
									continue;
								case 1:
									num = (short)538968071;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::System.Guid uuid;
									if (uuid != global::System.Guid.Empty)
									{
										num = (short)309526536;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)516554753;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles astrodvrsfiles = enumerator.Current;
									string packageName = astrodvrsfiles.PackageName;
									global::System.Guid uuid = astrodvrsfiles.Uuid;
									global::SpecialFeatures.DVRSFiles.List.DVRSFileListRecSet dvrsfileListRecSet = global::AcpCommonLib.FeatureManager.GetFeature(4234) as global::SpecialFeatures.DVRSFiles.List.DVRSFileListRecSet;
									num = (short)2094661634;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									string packageName;
									global::SpecialFeatures.DVRSFiles.List.DVRSFileListRecSet dvrsfileListRecSet;
									if (!global::SpecialFeatures.DVRSFiles.DVRSFilesHelper.a(dvrsfileListRecSet, packageName))
									{
										num = (short)1921056774;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									try
									{
										global::SpecialFeatures.DVRSFiles.List.DVRSFileListRecSet dvrsfileListRecSet;
										string text;
										global::SpecialFeatures.DVRSFiles.DVRSFilesHelper.populateDvrsFileDbRecords(dvrsfileListRecSet[0][10893] as global::SpecialFeatures.DVRSFiles.List.DVRSFileLabtoolSection, text);
										try
										{
											global::System.IO.File.Delete(text);
										}
										catch (global::System.Exception)
										{
										}
										break;
									}
									catch (global::System.Exception)
									{
										string text;
										string message = global::CommonResources.AppResources.Failed_to_open.AcpStringFormat(new object[]
										{
											text
										});
										global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, message);
										break;
									}
									goto IL_269;
								case 6:
								{
									global::System.Guid uuid;
									string text = global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().DownloadPackage(uuid);
									num = (short)1948778501;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									goto IL_2C4;
								case 8:
									goto IL_269;
								}
								IL_143:
								num = (short)294649859;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_13E:
								goto IL_143;
								IL_269:
								num = (short)1670643716;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2C4:
							return;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_2D7;
					case 5:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles>.Enumerator enumerator = currentTpl.ASTRODVRSFiles.GetEnumerator();
						num = (short)661716992;
						short num4 = num;
						num = (short)1879441412;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_CE:
					if (currentTpl.ASTRODVRSFiles != null)
					{
						num = (short)1252327426;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_31A;
					IL_2D7:
					num = (short)692387841;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_31A:
					global::SpecialFeatures.DVRSFiles.DVRSFilesHelper.a();
					num = (short)137494531;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x0015E744 File Offset: 0x0015C944
		private static void a()
		{
			int a_ = 19;
			switch (0)
			{
			case 0:
				goto IL_2D;
			}
			int num;
			short num2;
			global::SpecialFeatures.DVRSFiles.List.DVRSFileListRecSet dvrsfileListRecSet;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1667235840;
					short num3 = num2;
					if (dvrsfileListRecSet.Count > 0)
					{
						num2 = (short)1131085825;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 1:
				{
					global::SpecialFeatures.DVRSFiles.List.DVRSFileLabtoolSection dvrsfileLabtoolSection = dvrsfileListRecSet[0][10893] as global::SpecialFeatures.DVRSFiles.List.DVRSFileLabtoolSection;
					dvrsfileLabtoolSection.DVRSConfigDVRSFileName_A43736Object.Value = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튕캗좙쾛뺝쮡좣쎥袧鮩", a_);
					global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerRecset dvrsfileListInnerRecset = dvrsfileLabtoolSection.EmbeddedRecset as global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerRecset;
					num2 = (short)466987322;
					short num4 = num2;
					num2 = (short)1534568762;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1189150720;
						if (num2 != 0)
						{
						}
						num2 = (short)1888288770;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
				{
					num2 = (short)1356398593;
					if (num2 != 0)
					{
					}
					global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerRecset dvrsfileListInnerRecset;
					if (dvrsfileListInnerRecset != null)
					{
						num2 = (short)1875247107;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 3:
				{
					global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerRecset dvrsfileListInnerRecset;
					dvrsfileListInnerRecset.Clear();
					num2 = (short)198705156;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					return;
				}
				goto IL_2D;
			}
			return;
			IL_2D:
			dvrsfileListRecSet = (global::AcpCommonLib.FeatureManager.GetFeature(4234) as global::SpecialFeatures.DVRSFiles.List.DVRSFileListRecSet);
			num2 = (short)1003356160;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x0015E8F8 File Offset: 0x0015CAF8
		private static bool a(global::SpecialFeatures.DVRSFiles.List.DVRSFileListRecSet A_0, string A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_55;
			}
			short num;
			bool result;
			for (;;)
			{
				IL_0A:
				num = (short)917438465;
				if (num != 0)
				{
				}
				int num2;
				switch (num2)
				{
				case 0:
					num = (short)1268318210;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_BA;
				case 2:
				{
					num = (short)1747779584;
					short num3 = num;
					if (A_0.Count > 0)
					{
						num = (short)1801519108;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				}
				case 3:
					goto IL_F5;
				case 4:
					num = (short)1651507206;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					result = true;
					num = (short)1370685443;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if ((A_0[0][10893] as global::SpecialFeatures.DVRSFiles.List.DVRSFileLabtoolSection).DVRSConfigDVRSFileName_A43736Value.ToLower() == A_1.ToLower())
					{
						num = (short)999686149;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				}
				goto IL_55;
			}
			IL_F5:
			return result;
			IL_55:
			result = false;
			num = (short)1824248578;
			short num4 = num;
			num = (short)994497282;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_BA:
				if (A_0 != null)
				{
					num = (short)846200832;
					int num2 = (int)((global::System.IntPtr)num);
					goto IL_0A;
				}
				break;
			default:
			{
				num = (short)1284308992;
				if (num != 0)
				{
				}
				num = (short)667746305;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			}
			return result;
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x0015EAD0 File Offset: 0x0015CCD0
		public static void populateDvrsFileDbRecords(global::SpecialFeatures.DVRSFiles.List.DVRSFileLabtoolSection labTool, string dvrsFilePath)
		{
			short num = (short)343015425;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1819738114;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_42;
					}
					continue;
				case 2:
				{
					num = (short)825556992;
					short num3 = num;
					if (!string.IsNullOrEmpty(dvrsFilePath))
					{
						num = (short)1041825796;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				case 3:
					return;
				case 4:
				{
					global::System.IO.FileStream fileStream = new global::System.IO.FileStream(dvrsFilePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
					byte[] array = new byte[fileStream.Length];
					fileStream.Read(array, 0, (int)fileStream.Length);
					fileStream.Close();
					labTool.DVRSConfigDVRSFileName_A43736Object.Value = global::System.IO.Path.GetFileNameWithoutExtension(dvrsFilePath);
					global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerRecset dvrsfileListInnerRecset = labTool.EmbeddedRecset as global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerRecset;
					num = (short)1996947462;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
				{
					num = (short)1773600769;
					if (num != 0)
					{
					}
					byte[] array;
					global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerRecset dvrsfileListInnerRecset;
					global::SpecialFeatures.DVRSFiles.DVRSFilesHelper.a(array, dvrsfileListInnerRecset);
					num = (short)87031811;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
				{
					global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerRecset dvrsfileListInnerRecset;
					if (dvrsfileListInnerRecset != null)
					{
						num = (short)1407254533;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				}
				IL_42:
				num = (short)944084865;
				short num4 = num;
				num = (short)220370817;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1809842176;
					if (num != 0)
					{
					}
					if (labTool == null)
					{
						return;
					}
					break;
				}
				num = (short)708575232;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x0015ECC0 File Offset: 0x0015CEC0
		private static void a(byte[] A_0, global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerRecset A_1)
		{
			int a_ = 14;
			short num = (short)743768064;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_53;
				}
				byte[] array;
				int num5;
				int num6;
				int num8;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
					{
						int num3;
						if (num3 > 0)
						{
							num = (short)1962541059;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 1:
						goto IL_C4;
					case 2:
						num = (short)1534197761;
						if (num != 0)
						{
						}
						goto IL_C4;
					case 3:
					{
						global::SpecialFeatures.DVRSFiles.List.DVRSFileListInner dvrsfileListInner = A_1.AddDefaultRecord() as global::SpecialFeatures.DVRSFiles.List.DVRSFileListInner;
						int num3;
						global::System.Array.Copy(A_0, A_0.Length - num3, array, 0, num3);
						string text = global::System.BitConverter.ToString(array);
						dvrsfileListInner.DVRSFileListInnerSection.DVRSConfigDVRSFileData_A43734Value = text.Replace(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("벐", a_), "");
						global::System.Array.Clear(array, 0, array.Length);
						num = (short)886893254;
						short num4 = num;
						num = (short)895937222;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_178;
						default:
							num = (short)937689088;
							if (num != 0)
							{
							}
							num = (short)1506476036;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						return;
					case 5:
					{
						int num3 = A_0.Length % 8;
						num = (short)44826624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						if (num5 >= num6)
						{
							num = (short)892141573;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1758396416;
						short num7 = num;
						global::SpecialFeatures.DVRSFiles.List.DVRSFileListInner dvrsfileListInner2 = A_1.AddDefaultRecord() as global::SpecialFeatures.DVRSFiles.List.DVRSFileListInner;
						global::System.Array.Copy(A_0, num8, array, 0, 8);
						string text2 = global::System.BitConverter.ToString(array);
						dvrsfileListInner2.DVRSFileListInnerSection.DVRSConfigDVRSFileData_A43734Value = text2.Replace(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("벐", a_), "");
						global::System.Array.Clear(array, 0, array.Length);
						num8 += 8;
						num5++;
						goto IL_178;
					}
					}
					goto IL_53;
					IL_C4:
					num = (short)1905786886;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_178:
					num = (short)1966211074;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_53:
				A_1.Clear();
				array = new byte[8];
				num5 = 0;
				num8 = 0;
				num6 = A_0.Length / 8;
				num5 = 0;
				num = (short)324796417;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x0015EF44 File Offset: 0x0015D144
		public static void PopulateDvrsFileDbRecordsFromCruncherData(global::SpecialFeatures.DVRSFiles.List.DVRSFileLabtoolSection labTool, global::System.Collections.Generic.KeyValuePair<global::Motorola.CommonCPS.Server.EntityModel.Package, byte[]> dvrsFileContent)
		{
			int a_ = 2;
			short num = (short)1508048902;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerRecset dvrsfileListInnerRecset;
					if (dvrsfileListInnerRecset != null)
					{
						goto IL_92;
					}
					return;
				}
				case 1:
				{
					global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles astrodvrsfiles = dvrsFileContent.Key as global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles;
					num = (short)509149184;
					short num3 = num;
					num = (short)1803223045;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
				{
					global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerRecset dvrsfileListInnerRecset;
					global::SpecialFeatures.DVRSFiles.DVRSFilesHelper.a(dvrsFileContent.Value, dvrsfileListInnerRecset);
					num = (short)1823670276;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
				{
					global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles astrodvrsfiles;
					labTool.DVRSConfigDVRSFileName_A43736Object.Value = astrodvrsfiles.PackageName;
					num = (short)466550791;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					return;
				case 5:
				{
					num = (short)1589575681;
					if (num != 0)
					{
					}
					num = (short)1561351002;
					short num4 = num;
					num = (short)550523738;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_92;
					default:
					{
						num = (short)2135556096;
						if (num != 0)
						{
						}
						global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles astrodvrsfiles;
						if (astrodvrsfiles != null)
						{
							num = (short)532283395;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AB;
					}
					}
					break;
				}
				case 6:
					switch (0)
					{
					case 0:
						goto IL_4E;
					}
					continue;
				case 7:
				{
					global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerRecset dvrsfileListInnerRecset = labTool.EmbeddedRecset as global::SpecialFeatures.DVRSFiles.List.DVRSFileListInnerRecset;
					num = (short)1785397248;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_4E:
				if (labTool != null)
				{
					num = (short)34013185;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return;
				IL_92:
				num = (short)995622914;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_AB:
			throw new global::Motorola.Common.CustomException.CommonException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("톄力꾎랖붜爵펠톢쪤햦覨쾪\ud8ac\uddae\ud8b0\uddb2튴鞶\ud8b8쮺춼펾룀ꫂꯄꃆ迊鯌鷎苐돔뻖뗘뻚﷜ꯞ軠쏢ꛤ裦跨軪鷬菮蓰铲", a_));
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x0015F148 File Offset: 0x0015D348
		// Note: this type is marked as 'beforefieldinit'.
		static DVRSFilesHelper()
		{
			short num = (short)1619511138;
			short num2 = num;
			num = (short)1246087010;
			switch (num2 == num)
			{
			default:
			{
				num = (short)638582784;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)678625281;
			if (num != 0)
			{
			}
			num = (short)1383923712;
			if (num != 0)
			{
			}
			global::SpecialFeatures.DVRSFiles.DVRSFilesHelper.TempFolder = global::System.IO.Path.GetTempPath();
		}

		// Token: 0x0400080C RID: 2060
		internal static string TempFolder;

		// Token: 0x0400080D RID: 2061
		public const string EXTENSIONDCD = ".dcd";
	}
}
