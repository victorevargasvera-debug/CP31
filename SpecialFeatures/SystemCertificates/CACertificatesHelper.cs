using System;
using System.Collections.Generic;
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
using SpecialFeatures.SystemCertificates.List;

namespace SpecialFeatures.SystemCertificates
{
	// Token: 0x020001A3 RID: 419
	public class CACertificatesHelper
	{
		// Token: 0x060013CF RID: 5071 RVA: 0x001CB1D4 File Offset: 0x001C93D4
		private static global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates a(string A_0, string A_1 = "")
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates astrocacertificates;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_A1;
				case 1:
					goto IL_13D;
				case 2:
					if (string.IsNullOrEmpty(A_1))
					{
						num2 = (short)666304515;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					astrocacertificates.PackageName = A_1;
					goto IL_8A;
				case 3:
				{
					astrocacertificates.PackageName = global::System.IO.Path.GetFileName(A_0);
					num2 = (short)600861052;
					short num3 = num2;
					num2 = (short)1391487356;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_8A;
					default:
						num2 = (short)967180288;
						if (num2 != 0)
						{
						}
						num2 = (short)1289486337;
						if (num2 != 0)
						{
						}
						num2 = (short)357302273;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_20;
				IL_8A:
				num2 = (short)573964288;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_A1:
			IL_13D:
			global::Motorola.CommonCPS.Server.EntityModel.RMFile rmfile = new global::Motorola.CommonCPS.Server.EntityModel.RMFile
			{
				Url = A_0
			};
			astrocacertificates.RMFile = rmfile;
			return astrocacertificates;
			IL_20:
			num2 = (short)1948188672;
			short num4 = num2;
			astrocacertificates = new global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates();
			num2 = (short)1166606338;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060013D0 RID: 5072 RVA: 0x001CB338 File Offset: 0x001C9538
		public static global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates AnalysisCACertificatePackageInfo(string filePath)
		{
			try
			{
				global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates result = global::SpecialFeatures.SystemCertificates.CACertificatesHelper.a(filePath, "");
				goto IL_4C;
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::System.Exception)
			{
				global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.AnaysisPackageFailed);
			}
			IL_1F:
			short num = (short)396886016;
			short num2 = num;
			return null;
			IL_4C:
			num = (short)2136670209;
			if (num != 0)
			{
			}
			num = (short)688285659;
			short num3 = num;
			num = (short)521365467;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_1F;
			default:
			{
				num = (short)610598912;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates result;
				return result;
			}
			}
		}

		// Token: 0x060013D1 RID: 5073 RVA: 0x001CB424 File Offset: 0x001C9624
		public static global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates[] GenerateNewCACertificatePackageData(global::Motorola.CommonCPS.Server.EntityModel.Package[] serverCACertPackages, string outPutDir)
		{
			short num = (short)997851136;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5F;
				}
				global::System.Collections.Generic.List<string> list;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates> list2;
				for (;;)
				{
					IL_28:
					global::SpecialFeatures.SystemCertificates.List.SystemCertificateListRecSet systemCertificateListRecSet;
					int num3;
					global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>.Enumerator enumerator2;
					global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>> list3;
					switch (num2)
					{
					case 0:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = systemCertificateListRecSet.GetEnumerator();
						num = (short)1399193610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)1684930561;
						if (num != 0)
						{
						}
						goto IL_206;
					case 2:
						goto IL_290;
					case 3:
						if (systemCertificateListRecSet != null)
						{
							num = (short)257163272;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_227;
					case 4:
						goto IL_5E3;
					case 5:
						if (serverCACertPackages != null)
						{
							num = (short)94437377;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5E3;
					case 6:
					{
						if (num3 >= serverCACertPackages.Length)
						{
							num = (short)2102394884;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates astrocacertificates = (global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates)serverCACertPackages[num3];
						list.Add(astrocacertificates.PackageName);
						num3++;
						num = (short)257228811;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (systemCertificateListRecSet.Count > 0)
						{
							num = (short)1651245056;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_227;
					case 8:
						num = (short)55836679;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						try
						{
							num = (short)1903755265;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)89456642;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair = enumerator2.Current;
									list2.Add(global::SpecialFeatures.SystemCertificates.CACertificatesHelper.a(keyValuePair.Value, keyValuePair.Key));
									num = (short)1101070340;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_167;
									}
									continue;
								case 2:
									num = (short)1433468931;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_1F3;
								}
								IL_1A3:
								num = (short)2051473408;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_167:
								goto IL_1A3;
							}
							IL_1F3:
							goto IL_634;
						}
						finally
						{
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_206;
					case 10:
						goto IL_2D0;
						try
						{
							for (;;)
							{
								IL_2D0:
								num = (short)309198851;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										num = (short)865784231;
										short num4 = num;
										num = (short)152818087;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_2D0;
										default:
										{
											num = (short)1492451328;
											if (num != 0)
											{
											}
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
											if (!enumerator.MoveNext())
											{
												num = (short)1698562052;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::SpecialFeatures.SystemCertificates.List.SystemCertificateList systemCertificateList = (global::SpecialFeatures.SystemCertificates.List.SystemCertificateList)enumerator.Current;
											num = (short)306380809;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										}
										break;
									}
									case 1:
									{
										global::SpecialFeatures.SystemCertificates.List.SystemCertificateList systemCertificateList;
										if (!list.Contains(systemCertificateList.General.SecSysCertGeneralCertificateFilename_A43634Value))
										{
											num = (short)1517027336;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
										goto IL_572;
									case 3:
										switch (0)
										{
										case 0:
											goto IL_31F;
										}
										continue;
									case 4:
										num = (short)806092802;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
									{
										global::SpecialFeatures.SystemCertificates.List.SystemCertificateList systemCertificateList;
										try
										{
											global::System.IO.BinaryWriter binaryWriter;
											byte[] array;
											int count;
											binaryWriter.Write(array, 0, count);
											goto IL_498;
										}
										catch (global::System.Exception)
										{
											string message = global::CommonResources.AppResources.Failed_to_generate_file.AcpStringFormat(new object[]
											{
												systemCertificateList.General.SecSysCertGeneralCertificateFilename_A43634Value
											});
											global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, message);
											goto IL_498;
										}
										finally
										{
											global::System.IO.BinaryWriter binaryWriter;
											binaryWriter.Close();
										}
										break;
										IL_498:
										string text;
										global::System.Collections.Generic.KeyValuePair<string, string> item = new global::System.Collections.Generic.KeyValuePair<string, string>(systemCertificateList.General.SecSysCertGeneralCertificateFilename_A43634Value, text);
										list3.Add(item);
										num = (short)1539047429;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 7:
										num = (short)913899521;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
									{
										global::SpecialFeatures.SystemCertificates.List.SystemCertificateList systemCertificateList;
										string extension = global::System.IO.Path.GetExtension(systemCertificateList.General.SecSysCertGeneralCertificateFilename_A43634Value);
										string text = global::System.IO.Path.Combine(outPutDir, global::System.Guid.NewGuid().ToString() + extension);
										byte[] array = systemCertificateList.General.SecSysCertGeneralCertificateFileData_A43635Value.voiceData.ToArray();
										int count = array.Length;
										global::System.IO.BinaryWriter binaryWriter = new global::System.IO.BinaryWriter(new global::System.IO.FileStream(text, global::System.IO.FileMode.Create, global::System.IO.FileAccess.Write, global::System.IO.FileShare.None), global::System.Text.Encoding.ASCII);
										num = (short)1974861830;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 9:
									{
										global::SpecialFeatures.SystemCertificates.List.SystemCertificateList systemCertificateList;
										if (systemCertificateList.General.SecSysCertGeneralCertificateFilename_A43634_Valid)
										{
											num = (short)606535687;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									IL_40E:
									num = (short)2066939904;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_31F:
									goto IL_40E;
								}
							}
							IL_572:
							goto IL_227;
						}
						finally
						{
							num = (short)2120810498;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1308622849;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_5E0;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_5A9;
									}
									continue;
								}
								IL_5A9:
								if (enumerator == null)
								{
									break;
								}
								num = (short)883884032;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5E0:;
						}
						goto IL_5E3;
					case 11:
						goto IL_290;
					}
					goto IL_5F;
					IL_206:
					num3 = 0;
					num = (short)1385037826;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_227:
					enumerator2 = list3.GetEnumerator();
					num = (short)1711079433;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_290:
					num = (short)1389559814;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5E3:
					list3 = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>();
					systemCertificateListRecSet = (global::AcpCommonLib.FeatureManager.GetFeature(4228) as global::SpecialFeatures.SystemCertificates.List.SystemCertificateListRecSet);
					num = (short)647168003;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_634:
				num = (short)167378944;
				short num5 = num;
				return list2.ToArray();
				IL_5F:
				list2 = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates>();
				list = new global::System.Collections.Generic.List<string>();
				num = (short)1002700805;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060013D2 RID: 5074 RVA: 0x001CBAF8 File Offset: 0x001C9CF8
		public static void AttachCACertificateReference(global::Motorola.CommonCPS.Server.EntityModel.APXTemplate template)
		{
			short num = (short)406569303;
			short num2 = num;
			num = (short)653115735;
			switch (num2 == num)
			{
			}
			num = (short)629342208;
			short num3 = num;
			num = (short)2042232833;
			if (num != 0)
			{
			}
			num = (short)1259012096;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates[] collection = global::SpecialFeatures.SystemCertificates.CACertificatesHelper.GenerateNewCACertificatePackageData(null, global::SpecialFeatures.SystemCertificates.CACertificatesHelper.TempFolder);
			template.ASTROCACertificates = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates>(collection);
		}

		// Token: 0x060013D3 RID: 5075 RVA: 0x001CBBBC File Offset: 0x001C9DBC
		public static global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates> GetExistPackageData(global::Motorola.CommonCPS.Server.EntityModel.Package[] serverCACertPackages)
		{
			short num = (short)445710336;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_72;
				}
				global::System.Collections.Generic.List<string> list;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates> list3;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						int num3;
						global::Motorola.CommonCPS.Server.EntityModel.Package[] array;
						if (num3 >= array.Length)
						{
							num = (short)1011023874;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates astrocacertificates = (global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates)array[num3];
						list.Add(astrocacertificates.PackageName);
						num3++;
						num = (short)1855848463;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_2F2;
					case 2:
					{
						num = (short)1673396224;
						short num4 = num;
						num = (short)2000289798;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						num = (short)790560776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (serverCACertPackages != null)
						{
							num = (short)1836253194;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D9;
					case 5:
					{
						num = (short)445972481;
						if (num != 0)
						{
						}
						int num3;
						global::Motorola.CommonCPS.Server.EntityModel.Package[] array;
						if (num3 >= array.Length)
						{
							num = (short)624951303;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates astrocacertificates2 = (global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates)array[num3];
						global::System.Collections.Generic.List<string> list2;
						global::System.Collections.Generic.List<string>.Enumerator enumerator = list2.GetEnumerator();
						num = (short)2138570768;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::System.Collections.Generic.List<string> list2 = new global::System.Collections.Generic.List<string>();
						global::SpecialFeatures.SystemCertificates.List.SystemCertificateListRecSet systemCertificateListRecSet = global::AcpCommonLib.FeatureManager.GetFeature(4228) as global::SpecialFeatures.SystemCertificates.List.SystemCertificateListRecSet;
						num = (short)1576009740;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						return list3;
					case 8:
					{
						global::SpecialFeatures.SystemCertificates.List.SystemCertificateListRecSet systemCertificateListRecSet;
						if (systemCertificateListRecSet.Count > 0)
						{
							num = (short)116260877;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_677;
					}
					case 9:
						goto IL_3CC;
					case 10:
					{
						global::Motorola.CommonCPS.Server.EntityModel.Package[] array = serverCACertPackages;
						int num3 = 0;
						num = (short)1061552137;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_2F2;
					case 12:
					{
						global::SpecialFeatures.SystemCertificates.List.SystemCertificateListRecSet systemCertificateListRecSet;
						if (systemCertificateListRecSet != null)
						{
							num = (short)566558723;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_677;
					}
					case 13:
					{
						global::SpecialFeatures.SystemCertificates.List.SystemCertificateListRecSet systemCertificateListRecSet;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = systemCertificateListRecSet.GetEnumerator();
						num = (short)642711566;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						try
						{
							num = (short)797376514;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									global::SpecialFeatures.SystemCertificates.List.SystemCertificateList systemCertificateList;
									if (list.Contains(systemCertificateList.General.SecSysCertGeneralCertificateFilename_A43634Value))
									{
										num = (short)2059010051;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_465;
								case 3:
								{
									global::System.Collections.Generic.List<string> list2;
									global::SpecialFeatures.SystemCertificates.List.SystemCertificateList systemCertificateList;
									list2.Add(systemCertificateList.General.SecSysCertGeneralCertificateFilename_A43634Value);
									num = (short)1783562240;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)1072758789;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::SpecialFeatures.SystemCertificates.List.SystemCertificateList systemCertificateList = (global::SpecialFeatures.SystemCertificates.List.SystemCertificateList)enumerator2.Current;
									num = (short)151794508;
									short num5 = num;
									num = (short)1331901260;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_465;
									default:
										num = (short)455802880;
										if (num != 0)
										{
										}
										num = (short)1731002376;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									num = (short)1485570055;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									num = (short)824967169;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_605;
								case 8:
								{
									global::SpecialFeatures.SystemCertificates.List.SystemCertificateList systemCertificateList;
									if (systemCertificateList.General.SecSysCertGeneralCertificateFilename_A43634_Valid)
									{
										num = (short)181665798;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								goto IL_49A;
								IL_465:
								switch (0)
								{
								case 0:
									IL_49A:
									goto IL_5AE;
								}
								continue;
								IL_5AE:
								num = (short)1135345668;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_605:
							goto IL_B7;
						}
						finally
						{
							num = (short)1184825346;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
								switch (num2)
								{
								case 0:
									goto IL_674;
								case 1:
									enumerator2.Dispose();
									num = (short)445972480;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_63C;
									}
									continue;
								}
								IL_63C:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)2118975489;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_674:;
						}
						goto IL_677;
						IL_B7:
						global::Motorola.CommonCPS.Server.EntityModel.Package[] array = serverCACertPackages;
						int num3 = 0;
						num = (short)1464598529;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						goto IL_3CC;
					case 16:
					{
						try
						{
							num = (short)889257984;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_21F;
									}
									continue;
								case 1:
								{
									global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates astrocacertificates2;
									string b;
									if (string.Equals(astrocacertificates2.PackageName, b, global::System.StringComparison.CurrentCultureIgnoreCase))
									{
										num = (short)1795620866;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates astrocacertificates2;
									list3.Add(astrocacertificates2);
									num = (short)1772814339;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_2C0;
								case 4:
									goto IL_2DF;
								case 5:
								{
									global::System.Collections.Generic.List<string>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1460535302;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string b = enumerator.Current;
									num = (short)1824915457;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)1144127492;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_221:
								num = (short)1369047045;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_21F:
								goto IL_221;
							}
							IL_2C0:
							IL_2DF:
							goto IL_18E;
						}
						finally
						{
							global::System.Collections.Generic.List<string>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_2F2;
						IL_18E:
						int num3;
						num3++;
						num = (short)772145163;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_72;
					IL_2F2:
					num = (short)2136604677;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3CC:
					num = (short)1683881984;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1D9:
				return null;
				IL_677:
				return null;
				IL_72:
				list3 = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates>();
				list = new global::System.Collections.Generic.List<string>();
				num = (short)368181252;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060013D4 RID: 5076 RVA: 0x001CC278 File Offset: 0x001CA478
		public static global::System.Collections.Generic.List<string> GetCACertificateFileListFromCP()
		{
			short num = (short)1197015040;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1902837760;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_6B;
				}
				global::SpecialFeatures.SystemCertificates.List.SystemCertificateListRecSet systemCertificateListRecSet;
				global::System.Collections.Generic.List<string> list;
				for (;;)
				{
					IL_50:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						num = (short)1041629185;
						if (num != 0)
						{
						}
						if (systemCertificateListRecSet.Count > 0)
						{
							num = (short)1558773762;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return list;
					case 1:
						num = (short)804323328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_27D;
					case 3:
						try
						{
							num = (short)1626406916;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)114884610;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1C0;
								case 3:
								{
									global::SpecialFeatures.SystemCertificates.List.SystemCertificateList systemCertificateList;
									list.Add(systemCertificateList.General.SecSysCertGeneralCertificateFilename_A43634Value.ToLower());
									num = (short)1736245249;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_F8;
									}
									continue;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1794179072;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::SpecialFeatures.SystemCertificates.List.SystemCertificateList systemCertificateList = (global::SpecialFeatures.SystemCertificates.List.SystemCertificateList)enumerator.Current;
									num = (short)315817990;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::SpecialFeatures.SystemCertificates.List.SystemCertificateList systemCertificateList;
									if (systemCertificateList.General.SecSysCertGeneralCertificateFilename_A43634_Valid)
									{
										num = (short)1337262083;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_140:
								num = (short)449970181;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F8:
								goto IL_140;
							}
							IL_1C0:
							return list;
						}
						finally
						{
							num = (short)1008992258;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_231;
								case 1:
									enumerator.Dispose();
									goto IL_219;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1F8;
									}
									continue;
								}
								IL_1F8:
								if (enumerator != null)
								{
									num = (short)160497665;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_231;
								IL_219:
								num = (short)358023168;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_231:
								num = (short)1846364314;
								short num4 = num;
								num = (short)397297818;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_219;
								default:
									goto IL_265;
								}
							}
							IL_265:
							num = (short)1597571072;
							if (num != 0)
							{
							}
						}
						goto IL_27D;
					case 4:
						if (systemCertificateListRecSet != null)
						{
							num = (short)1575092225;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return list;
					}
					goto IL_6B;
					IL_27D:
					enumerator = systemCertificateListRecSet.GetEnumerator();
					num = (short)1620574211;
					num2 = (int)((global::System.IntPtr)num);
				}
				return list;
				IL_6B:
				list = new global::System.Collections.Generic.List<string>();
				systemCertificateListRecSet = (global::AcpCommonLib.FeatureManager.GetFeature(4228) as global::SpecialFeatures.SystemCertificates.List.SystemCertificateListRecSet);
				num = (short)725483524;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_50;
			}
			}
		}

		// Token: 0x060013D5 RID: 5077 RVA: 0x001CC5AC File Offset: 0x001CA7AC
		private static void a(string A_0)
		{
			short num;
			try
			{
				num = (short)807594088;
				short num2 = num;
				num = (short)2039933032;
				switch (num2 == num)
				{
				}
				num = (short)348454912;
				if (num != 0)
				{
				}
				global::System.IO.File.SetAttributes(A_0, global::System.IO.FileAttributes.Normal);
				global::System.IO.File.Delete(A_0);
			}
			catch
			{
			}
			num = (short)481755137;
			if (num != 0)
			{
			}
			num = (short)1477967872;
			short num3 = num;
		}

		// Token: 0x060013D6 RID: 5078 RVA: 0x001CC67C File Offset: 0x001CA87C
		public static void UpdateCACertificateContent(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates> templateCACertificateFiles, global::Motorola.CommonCPS.Server.EntityModel.APXTemplate template)
		{
			int a_ = 4;
			short num = (short)6488064;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_67;
				}
				global::System.Collections.Generic.List<string> cacertificateFileListFromCP;
				global::System.Collections.Generic.List<string> list2;
				global::System.Collections.Generic.Dictionary<global::System.Guid, string> dictionary;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates>.Enumerator enumerator4;
				for (;;)
				{
					IL_30:
					global::System.Collections.Generic.List<string> list;
					global::System.Collections.Generic.List<string>.Enumerator enumerator;
					global::SpecialFeatures.SystemCertificates.List.SystemCertificateListRecSet systemCertificateListRecSet;
					switch (num2)
					{
					case 0:
						goto IL_67B;
					case 1:
						goto IL_934;
					case 2:
						goto IL_411;
					case 3:
						if (list.Count > 0)
						{
							num = (short)1264648203;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A8;
					case 4:
						if (!cacertificateFileListFromCP.SequenceEqual(list2))
						{
							num = (short)625147911;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_51D;
					case 5:
						try
						{
							num = (short)385482758;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::SpecialFeatures.SystemCertificates.List.SystemCertificateList systemCertificateList;
									if (systemCertificateList.General.SecSysCertGeneralCertificateFilename_A43634_Valid)
									{
										num = (short)1678639106;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									goto IL_39F;
								case 2:
									num = (short)604831752;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_387;
								case 4:
									enumerator = list.GetEnumerator();
									num = (short)1947271175;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)699006979;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::SpecialFeatures.SystemCertificates.List.SystemCertificateList systemCertificateList = (global::SpecialFeatures.SystemCertificates.List.SystemCertificateList)enumerator2.Current;
									num = (short)342491136;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_E6;
									}
									continue;
								case 7:
									try
									{
										num = (short)840302596;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												if (!enumerator.MoveNext())
												{
													num = (short)1172635649;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												string text = enumerator.Current;
												num = (short)365559814;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 1:
												num = (short)1676410882;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												goto IL_374;
											case 3:
											{
												global::SpecialFeatures.SystemCertificates.List.SystemCertificateList systemCertificateList;
												global::SpecialFeatures.SystemCertificates.List.SystemCertificateList systemCertificateList2 = systemCertificateList;
												string text;
												global::System.IO.FileStream fileStream = new global::System.IO.FileStream(text, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
												byte[] array = new byte[fileStream.Length];
												fileStream.Read(array, 0, (int)fileStream.Length);
												global::AcpBusinessLayer.AcpVoiceFileStruct value = new global::AcpBusinessLayer.AcpVoiceFileStruct(text);
												value.voicefile = text;
												value.voiceData = new global::System.IO.MemoryStream(array, 0, array.Length, true, true);
												systemCertificateList2.General.SecSysCertGeneralCertificateFileData_A43635.SetValue(value);
												systemCertificateList2.General.SecSysCertGeneralCertificateFilename_A43634Object.Value = global::System.IO.Path.GetFileName(text);
												num = (short)1124794373;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
												switch (0)
												{
												case 0:
													goto IL_228;
												}
												continue;
											case 5:
												goto IL_319;
											case 6:
											{
												global::SpecialFeatures.SystemCertificates.List.SystemCertificateList systemCertificateList;
												string text;
												if (string.Compare(global::System.IO.Path.GetFileName(text), systemCertificateList.General.SecSysCertGeneralCertificateFilename_A43634Value, true) == 0)
												{
													num = (short)1248460803;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											}
											IL_31E:
											num = (short)388169728;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_228:
											goto IL_31E;
										}
										IL_319:
										IL_374:
										break;
									}
									finally
									{
										((global::System.IDisposable)enumerator).Dispose();
									}
									goto IL_387;
								case 8:
								{
									global::SpecialFeatures.SystemCertificates.List.SystemCertificateList systemCertificateList;
									if (systemCertificateList.General.SecSysCertGeneralCertificateFilename_A43634Object != null)
									{
										num = (short)1982791684;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_12A:
								num = (short)297336837;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E6:
								goto IL_12A;
								IL_387:
								num = (short)608567297;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_39F:
							goto IL_4A8;
						}
						finally
						{
							num = (short)811794434;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
								switch (num2)
								{
								case 0:
									goto IL_40E;
								case 1:
									enumerator2.Dispose();
									num = (short)940703744;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_3D6;
									}
									continue;
								}
								IL_3D6:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)2126249985;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_40E:;
						}
						goto IL_411;
					case 6:
						if (systemCertificateListRecSet.Count > 0)
						{
							num = (short)153550850;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A8;
					case 7:
					{
						global::System.Collections.Generic.Dictionary<global::System.Guid, string>.Enumerator enumerator3 = dictionary.GetEnumerator();
						num = (short)637796352;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						try
						{
							num = (short)1487470596;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)498204674;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_668;
								case 3:
									if (!enumerator.MoveNext())
									{
										num = (short)1257373696;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::SpecialFeatures.SystemCertificates.CACertificatesHelper.a(enumerator.Current);
									num = (short)1179582465;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_5F2;
									}
									continue;
								}
								IL_618:
								num = (short)1516896259;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5F2:
								goto IL_618;
							}
							IL_668:
							goto IL_977;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto Block_6;
					case 9:
						goto IL_7CA;
					case 10:
						num = (short)422182913;
						if (num != 0)
						{
						}
						if (systemCertificateListRecSet != null)
						{
							num = (short)263782401;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A8;
					case 11:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = systemCertificateListRecSet.GetEnumerator();
						num = (short)1004929029;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_67;
					IL_411:
					num = (short)868352003;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_7:
					try
					{
						IL_7CA:
						num = (short)296878083;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								try
								{
									global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates astrocacertificates;
									dictionary.Add(astrocacertificates.Uuid, astrocacertificates.PackageName);
								}
								catch
								{
								}
								break;
							case 1:
								num = (short)387121154;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_921;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_808;
								}
								continue;
							case 4:
							{
								global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates astrocacertificates;
								if (cacertificateFileListFromCP.Contains(astrocacertificates.PackageName.ToLower()))
								{
									num = (short)1845755904;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
							{
								if (!enumerator4.MoveNext())
								{
									goto IL_8EE;
								}
								global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates astrocacertificates = enumerator4.Current;
								list2.Add(astrocacertificates.PackageName.ToLower());
								num = (short)653983748;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_87E:
							num = (short)273725320;
							short num3 = num;
							num = (short)1265874824;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_8EE:
								num = (short)103284737;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							default:
								num = (short)1236992000;
								if (num != 0)
								{
								}
								num = (short)632356869;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_808:
							goto IL_87E;
						}
						IL_921:
						goto IL_453;
					}
					finally
					{
						((global::System.IDisposable)enumerator4).Dispose();
					}
					goto IL_934;
					IL_453:
					list = new global::System.Collections.Generic.List<string>();
					cacertificateFileListFromCP.Sort();
					list2.Sort();
					num = (short)1490157572;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_6:
					try
					{
						IL_67B:
						num = (short)979828738;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)1791688705;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_7B7;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_6B5;
								}
								continue;
							case 4:
							{
								global::System.Collections.Generic.Dictionary<global::System.Guid, string>.Enumerator enumerator3;
								if (!enumerator3.MoveNext())
								{
									num = (short)1505558528;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.KeyValuePair<global::System.Guid, string> keyValuePair = enumerator3.Current;
								string text2 = global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().DownloadPackage(keyValuePair.Key);
								global::System.IO.File.Copy(text2, text2.Replace(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꦆﶈﶌ", a_), ""), true);
								global::SpecialFeatures.SystemCertificates.CACertificatesHelper.a(text2);
								text2 = text2.Replace(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꦆﶈﶌ", a_), "");
								list.Add(text2.Replace(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꢆ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb86", a_)));
								num = (short)1023344643;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_75F:
							num = (short)457113604;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_6B5:
							goto IL_75F;
						}
						IL_7B7:
						goto IL_51D;
					}
					finally
					{
						global::System.Collections.Generic.Dictionary<global::System.Guid, string>.Enumerator enumerator3;
						((global::System.IDisposable)enumerator3).Dispose();
					}
					goto Block_7;
					IL_4A8:
					enumerator = list.GetEnumerator();
					num = (short)767033344;
					short num4 = num;
					num = (short)856555528;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_51D:
					systemCertificateListRecSet = (global::AcpCommonLib.FeatureManager.GetFeature(4228) as global::SpecialFeatures.SystemCertificates.List.SystemCertificateListRecSet);
					num = (short)197066762;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_934:
					num = (short)279511046;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_977:
				global::SpecialFeatures.SystemCertificates.CACertificatesHelper.UpdateCACertificateReference(template);
				return;
				IL_67:
				cacertificateFileListFromCP = global::SpecialFeatures.SystemCertificates.CACertificatesHelper.GetCACertificateFileListFromCP();
				list2 = new global::System.Collections.Generic.List<string>();
				dictionary = new global::System.Collections.Generic.Dictionary<global::System.Guid, string>();
				enumerator4 = templateCACertificateFiles.GetEnumerator();
				num = (short)959250441;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060013D7 RID: 5079 RVA: 0x001CD09C File Offset: 0x001CB29C
		public static void UpdateCACertificateReference(global::Motorola.CommonCPS.Server.EntityModel.APXTemplate template)
		{
			short num = (short)788135936;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4C;
				}
				int num3;
				global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates[] array;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						return;
					case 1:
						goto IL_1B0;
					case 2:
					{
						if (num3 >= array.Length)
						{
							goto IL_1D0;
						}
						global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates package = array[num3];
						global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates astrocacertificates = global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().UploadCACertificatePackage(package) as global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates;
						num = (short)1441136646;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates astrocacertificates;
						template.ASTROCACertificates.Add(astrocacertificates);
						num = (short)2102788101;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_1B0;
					case 5:
						goto IL_81;
					case 6:
					{
						global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates astrocacertificates;
						if (astrocacertificates != null)
						{
							num = (short)768212995;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_81;
					}
					}
					goto IL_4C;
					IL_81:
					num = (short)680013067;
					short num4 = num;
					num = (short)692464907;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_1D0:
						num = (short)862388224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						break;
					default:
					{
						num = (short)989069312;
						short num5 = num;
						break;
					}
					}
					num = (short)1516961793;
					if (num != 0)
					{
					}
					num = (short)1719205888;
					if (num != 0)
					{
					}
					num3++;
					num = (short)865796097;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B0:
					num = (short)2133393410;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_4C:
				global::Motorola.CommonCPS.Server.EntityModel.ASTROCACertificates[] array2 = global::SpecialFeatures.SystemCertificates.CACertificatesHelper.GenerateNewCACertificatePackageData(null, global::SpecialFeatures.SystemCertificates.CACertificatesHelper.TempFolder);
				template.ASTROCACertificates.Clear();
				array = array2;
				num3 = 0;
				num = (short)592969732;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x060013D9 RID: 5081 RVA: 0x001CD294 File Offset: 0x001CB494
		// Note: this type is marked as 'beforefieldinit'.
		static CACertificatesHelper()
		{
			short num = (short)423746880;
			short num2 = num;
			num = (short)70049088;
			switch (num2 == num)
			{
			}
			num = (short)369229825;
			if (num != 0)
			{
			}
			num = (short)1789788160;
			short num3 = num;
			num = (short)1462173696;
			if (num != 0)
			{
			}
			global::SpecialFeatures.SystemCertificates.CACertificatesHelper.TempFolder = global::System.IO.Path.GetTempPath();
		}

		// Token: 0x04000AF6 RID: 2806
		internal static string TempFolder;
	}
}
