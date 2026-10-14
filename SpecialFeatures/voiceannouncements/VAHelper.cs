using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AcpBusinessLayer;
using AcpCommonLib;
using ACPVoiceAnnouncementLib;
using CommonResources;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.EntityModel;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.VoiceAnnouncements.List;

namespace SpecialFeatures.VoiceAnnouncements
{
	// Token: 0x02000011 RID: 17
	public class VAHelper
	{
		// Token: 0x0600003B RID: 59 RVA: 0x000082CC File Offset: 0x000064CC
		public static void UpdateVAContent(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement> templateVoiceFiles, global::Motorola.CommonCPS.Server.EntityModel.APXTemplate template)
		{
			int a_ = 1;
			short num = (short)1182400512;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_68;
				}
				global::System.Collections.Generic.Dictionary<global::System.Guid, string> dictionary;
				global::System.Collections.Generic.List<string> vafileListFromCP;
				global::System.Collections.Generic.List<string> list2;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement>.Enumerator enumerator4;
				for (;;)
				{
					IL_31:
					global::System.Collections.Generic.List<string> list;
					global::System.Collections.Generic.List<string>.Enumerator enumerator2;
					global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet voiceAnnouncementListRecSet;
					switch (num2)
					{
					case 0:
						goto IL_7E6;
					case 1:
						goto IL_3EC;
					case 2:
						try
						{
							num = (short)999292929;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1221328899;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList = (global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList)enumerator.Current;
									num = (short)1434714117;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_E6;
									}
									continue;
								case 2:
									goto IL_37B;
								case 3:
									goto IL_361;
								case 4:
								{
									global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList;
									if (voiceAnnouncementList.General.VoiceFileName_A21220Object != null)
									{
										num = (short)1024983046;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList;
									if (voiceAnnouncementList.General.VoiceFileName_A21220_Valid)
									{
										num = (short)2021130247;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									enumerator2 = list.GetEnumerator();
									num = (short)264503304;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									num = (short)490799108;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									try
									{
										num = (short)1692467201;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList;
												global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList2 = voiceAnnouncementList;
												string text;
												global::AcpBusinessLayer.AcpVoiceFileStruct acpVoiceFileStruct = new global::AcpBusinessLayer.AcpVoiceFileStruct(text);
												voiceAnnouncementList2.General.VoiceAnnouncementEncodeType_A22264.SetValue(1);
												voiceAnnouncementList2.General.VoiceAnnouncementFileHashcode_A24563.SetValue(acpVoiceFileStruct.hashcode);
												voiceAnnouncementList2.General.VoiceFileDataInfo_A21213.SetValue(acpVoiceFileStruct);
												voiceAnnouncementList2.General.VoiceFileName_A21220Object.Value = global::System.IO.Path.GetFileNameWithoutExtension(text);
												num = (short)530055170;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 1:
												switch (0)
												{
												case 0:
													goto IL_224;
												}
												continue;
											case 2:
												goto IL_2F1;
											case 3:
												goto IL_34E;
											case 4:
											{
												global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList;
												string text;
												if (string.Compare(global::System.IO.Path.GetFileNameWithoutExtension(text), voiceAnnouncementList.General.VoiceFileName_A21220Value, true) == 0)
												{
													num = (short)1466695680;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 5:
												num = (short)1566507011;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 6:
											{
												if (!enumerator2.MoveNext())
												{
													num = (short)1560805381;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												string text = enumerator2.Current;
												num = (short)1882390532;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											IL_2F6:
											num = (short)905576454;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_224:
											goto IL_2F6;
										}
										IL_2F1:
										IL_34E:
										break;
									}
									finally
									{
										((global::System.IDisposable)enumerator2).Dispose();
									}
									goto IL_361;
								}
								IL_129:
								num = (short)1443627008;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E6:
								goto IL_129;
								IL_361:
								num = (short)1957101570;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_37B:
							goto IL_4AD;
						}
						finally
						{
							num = (short)871563264;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_3B2;
									}
									continue;
								case 1:
									goto IL_3E9;
								case 2:
									enumerator.Dispose();
									num = (short)1791623169;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3B2:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2032926722;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3E9:;
						}
						goto IL_3EC;
					case 3:
						try
						{
							num = (short)1831600130;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									goto IL_682;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_5B1;
									}
									continue;
								case 3:
									goto IL_668;
								case 4:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)56688643;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)742696210;
									short num3 = num;
									num = (short)1878828306;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_668;
									default:
										num = (short)2024275968;
										if (num != 0)
										{
										}
										global::SpecialFeatures.VoiceAnnouncements.VAHelper.a(enumerator2.Current);
										num = (short)822411264;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_627:
								num = (short)1996750852;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5B1:
								goto IL_627;
								IL_668:
								num = (short)138412033;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_682:
							goto IL_971;
						}
						finally
						{
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto Block_6;
					case 4:
						if (list.Count > 0)
						{
							num = (short)1227096071;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4AD;
					case 5:
					{
						global::System.Collections.Generic.Dictionary<global::System.Guid, string>.Enumerator enumerator3 = dictionary.GetEnumerator();
						num = (short)364642312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_908;
					case 7:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = voiceAnnouncementListRecSet.GetEnumerator();
						num = (short)1609564162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_695;
					case 9:
						if (!vafileListFromCP.SequenceEqual(list2))
						{
							num = (short)2008285184;
							short num4 = num;
							num = (short)2003763205;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4FA;
					case 10:
						if (voiceAnnouncementListRecSet.Count > 0)
						{
							num = (short)713752577;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4AD;
					case 11:
						if (voiceAnnouncementListRecSet != null)
						{
							num = (short)1164312582;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4AD;
					}
					goto IL_68;
					IL_3EC:
					num = (short)10944516;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_7:
					try
					{
						IL_7E6:
						num = (short)1060306945;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								try
								{
									global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement astrovoiceAnnouncement;
									dictionary.Add(astrovoiceAnnouncement.Uuid, astrovoiceAnnouncement.PackageName);
								}
								catch
								{
								}
								break;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_824;
								}
								continue;
							case 2:
								goto IL_8F5;
							case 3:
							{
								global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement astrovoiceAnnouncement;
								if (vafileListFromCP.Contains(astrovoiceAnnouncement.PackageName.ToLower()))
								{
									num = (short)468451328;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 4:
								num = (short)1340735490;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
							{
								if (!enumerator4.MoveNext())
								{
									num = (short)801177604;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement astrovoiceAnnouncement = enumerator4.Current;
								list2.Add(astrovoiceAnnouncement.PackageName.ToLower());
								num = (short)1441857539;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_89C:
							num = (short)381550597;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_824:
							goto IL_89C;
						}
						IL_8F5:
						goto IL_42D;
					}
					finally
					{
						((global::System.IDisposable)enumerator4).Dispose();
					}
					goto IL_908;
					IL_42D:
					list = new global::System.Collections.Generic.List<string>();
					vafileListFromCP.Sort();
					list2.Sort();
					num = (short)1024655369;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_6:
					try
					{
						IL_695:
						num = (short)1729953794;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
								goto IL_7D3;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_6CF;
								}
								continue;
							case 3:
								num = (short)1187250177;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								global::System.Collections.Generic.Dictionary<global::System.Guid, string>.Enumerator enumerator3;
								if (!enumerator3.MoveNext())
								{
									num = (short)989462531;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.KeyValuePair<global::System.Guid, string> keyValuePair = enumerator3.Current;
								string text2 = global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().DownloadPackage(keyValuePair.Key);
								global::System.IO.File.Copy(text2, text2.Replace(global::System.IO.Path.GetExtension(text2), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꪃﺇ", a_)), true);
								global::SpecialFeatures.VoiceAnnouncements.VAHelper.a(text2);
								text2 = text2.Replace(global::System.IO.Path.GetExtension(text2), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꪃﺇ", a_));
								list.Add(text2.Replace(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꮃ", a_), global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud883", a_)));
								num = (short)1577648128;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_77C:
							num = (short)1821376516;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_6CF:
							goto IL_77C;
						}
						IL_7D3:
						goto IL_4FA;
					}
					finally
					{
						global::System.Collections.Generic.Dictionary<global::System.Guid, string>.Enumerator enumerator3;
						((global::System.IDisposable)enumerator3).Dispose();
					}
					goto Block_7;
					IL_4AD:
					enumerator2 = list.GetEnumerator();
					num = (short)402849795;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4FA:
					new global::System.Collections.Generic.List<global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementInfo>();
					voiceAnnouncementListRecSet = (global::AcpCommonLib.FeatureManager.GetFeature(2300) as global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet);
					num = (short)2070806539;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_908:
					num = (short)1625423873;
					if (num != 0)
					{
					}
					num = (short)732889098;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_971:
				global::SpecialFeatures.VoiceAnnouncements.VAHelper.UpdateVoiceAnnouncemnetReference(template);
				return;
				IL_68:
				vafileListFromCP = global::SpecialFeatures.VoiceAnnouncements.VAHelper.GetVAFileListFromCP();
				list2 = new global::System.Collections.Generic.List<string>();
				dictionary = new global::System.Collections.Generic.Dictionary<global::System.Guid, string>();
				enumerator4 = templateVoiceFiles.GetEnumerator();
				num = (short)149094400;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00008CE4 File Offset: 0x00006EE4
		public static void UpdateVoiceAnnouncemnetReference(global::Motorola.CommonCPS.Server.EntityModel.APXTemplate template)
		{
			short num = (short)9502720;
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
				int num3;
				global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement[] array;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement astrovoiceAnnouncement;
						template.ASTROVoiceAnnouncements.Add(astrovoiceAnnouncement);
						num = (short)276168708;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_13D;
					case 2:
						goto IL_13D;
					case 3:
					{
						if (num3 >= array.Length)
						{
							goto IL_15F;
						}
						global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement package = array[num3];
						global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement astrovoiceAnnouncement = global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().UploadVAPackage(package) as global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement;
						num = (short)1853095937;
						if (num != 0)
						{
						}
						num = (short)1153040389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_7E;
					case 5:
					{
						global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement astrovoiceAnnouncement;
						if (astrovoiceAnnouncement != null)
						{
							num = (short)499974144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7E;
					}
					case 6:
					{
						num = (short)8613680;
						short num4 = num;
						num = (short)17657648;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_15F;
						case 1:
							goto IL_1D9;
						}
						goto Block_2;
					}
					}
					goto IL_4A;
					IL_7E:
					num3++;
					num = (short)1002831874;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_13D:
					num = (short)1593114627;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15F:
					num = (short)2055077894;
					num2 = (int)((global::System.IntPtr)num);
				}
				Block_2:
				num = (short)336592896;
				short num5 = num;
				IL_1D9:
				num = (short)671678464;
				if (num != 0)
				{
				}
				return;
				IL_4A:
				global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement[] array2 = global::SpecialFeatures.VoiceAnnouncements.VAHelper.GenerateNewVAPackageData(null, global::SpecialFeatures.VoiceAnnouncements.VAHelper.TempFolder);
				template.ASTROVoiceAnnouncements.Clear();
				array = array2;
				num3 = 0;
				num = (short)2089549825;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00008EE4 File Offset: 0x000070E4
		public static void AttachVoiceAnnouncemnetReference(global::Motorola.CommonCPS.Server.EntityModel.APXTemplate template)
		{
			short num = (short)115408896;
			short num2 = num;
			num = (short)1202699608;
			short num3 = num;
			num = (short)1775156568;
			switch (num3 == num)
			{
			}
			num = (short)1612840961;
			if (num != 0)
			{
			}
			num = (short)836304896;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement[] collection = global::SpecialFeatures.VoiceAnnouncements.VAHelper.GenerateNewVAPackageData(null, global::SpecialFeatures.VoiceAnnouncements.VAHelper.TempFolder);
			template.ASTROVoiceAnnouncements = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement>(collection);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00008FA4 File Offset: 0x000071A4
		public static global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement AnaysisVAPackageInfo(string filePath)
		{
			int a_ = 1;
			short num;
			global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement result;
			try
			{
				num = (short)1104543745;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_8A;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_3D;
						}
						continue;
					case 2:
						filePath = global::SpecialFeatures.VoiceAnnouncements.VAHelper.c(filePath);
						num = (short)783810560;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_AD;
					}
					IL_3D:
					if (filePath.EndsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꪃﲉ", a_)))
					{
						num = (short)1863581698;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_8A:
					result = global::SpecialFeatures.VoiceAnnouncements.VAHelper.a(filePath, "");
					num = (short)45285379;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_AD:
				goto IL_13E;
			}
			catch (global::Motorola.Common.CustomException.CommonException)
			{
				throw;
			}
			catch (global::System.Exception)
			{
				global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.AnaysisPackageFailed);
			}
			num = (short)1591345152;
			short num3 = num;
			num = (short)1503565592;
			short num4 = num;
			num = (short)2127271704;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_13E:
				num = (short)1832779777;
				if (num != 0)
				{
				}
				return result;
			default:
				num = (short)116457472;
				if (num != 0)
				{
				}
				return null;
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00009134 File Offset: 0x00007334
		public static global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement> GetExistPackageData(global::Motorola.CommonCPS.Server.EntityModel.Package[] serverVAPackages)
		{
			short num = (short)417071104;
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
				global::System.Collections.Generic.List<string> list2;
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement> list3;
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
							num = (short)1721237512;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement astrovoiceAnnouncement = (global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement)array[num3];
						global::System.Collections.Generic.List<string> list;
						global::System.Collections.Generic.List<string>.Enumerator enumerator = list.GetEnumerator();
						num = (short)695468043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_2EF;
					case 2:
						goto IL_3D0;
					case 3:
						if (serverVAPackages != null)
						{
							num = (short)870580231;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D5;
					case 4:
					{
						int num3;
						global::Motorola.CommonCPS.Server.EntityModel.Package[] array;
						if (num3 >= array.Length)
						{
							num = (short)1257832460;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement astrovoiceAnnouncement2 = (global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement)array[num3];
						list2.Add(astrovoiceAnnouncement2.PackageName);
						num3++;
						num = (short)1541996546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_3D0;
					case 6:
						goto IL_2EF;
					case 7:
					{
						global::Motorola.CommonCPS.Server.EntityModel.Package[] array = serverVAPackages;
						int num3 = 0;
						num = (short)1968046085;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						return list3;
					case 9:
					{
						num = (short)1332740097;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
						new global::System.Collections.Generic.List<global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementInfo>();
						global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet voiceAnnouncementListRecSet = global::AcpCommonLib.FeatureManager.GetFeature(2300) as global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet;
						num = (short)1638072335;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet voiceAnnouncementListRecSet;
						if (voiceAnnouncementListRecSet.Count > 0)
						{
							num = (short)36962320;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_683;
					}
					case 11:
					{
						try
						{
							num = (short)2030305281;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement astrovoiceAnnouncement;
									list3.Add(astrovoiceAnnouncement);
									num = (short)2028339203;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_21A;
									}
									continue;
								case 2:
								{
									global::System.Collections.Generic.List<string>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)870252548;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string b = enumerator.Current;
									num = (short)1704132613;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_2BF;
								case 4:
									num = (short)1713504262;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement astrovoiceAnnouncement;
									string b;
									if (string.Equals(astrovoiceAnnouncement.PackageName, b, global::System.StringComparison.CurrentCultureIgnoreCase))
									{
										num = (short)608043008;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									goto IL_2DC;
								}
								IL_21C:
								num = (short)369164290;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_21A:
								goto IL_21C;
							}
							IL_2BF:
							IL_2DC:
							goto IL_164;
						}
						finally
						{
							global::System.Collections.Generic.List<string>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_2EF;
						IL_164:
						int num3;
						num3++;
						num = (short)1952382977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						num = (short)1511587849;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)2144796682;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						num = (short)1382678528;
						short num4 = num;
						try
						{
							num = (short)36765697;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)689242117;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList = (global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList)enumerator2.Current;
									num = (short)1137573892;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_49E;
									}
									continue;
								case 2:
								{
									global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList;
									if (list2.Contains(voiceAnnouncementList.General.VoiceFileName_A21220Value))
									{
										num = (short)1800273927;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList;
									if (voiceAnnouncementList.General.VoiceFileName_A21220_Valid)
									{
										num = (short)235274246;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									for (;;)
									{
										num = (short)1861511318;
										short num5 = num;
										num = (short)1620928662;
										switch ((num5 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											goto IL_5E0;
										}
									}
									IL_5E0:
									num = (short)596443136;
									if (num != 0)
									{
									}
									num = (short)627441672;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									num = (short)983302146;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::System.Collections.Generic.List<string> list;
									global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList;
									list.Add(voiceAnnouncementList.General.VoiceFileName_A21220Value);
									num = (short)779550723;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									goto IL_60F;
								}
								IL_56B:
								num = (short)1177747456;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_49E:
								goto IL_56B;
							}
							IL_60F:
							goto IL_B8;
						}
						finally
						{
							num = (short)1797783552;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_648;
									}
									continue;
								case 1:
									enumerator2.Dispose();
									num = (short)1529806850;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_680;
								}
								IL_648:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)1745551361;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_680:;
						}
						goto IL_683;
						IL_B8:
						global::Motorola.CommonCPS.Server.EntityModel.Package[] array = serverVAPackages;
						int num3 = 0;
						num = (short)1473642502;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
					{
						global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet voiceAnnouncementListRecSet;
						if (voiceAnnouncementListRecSet != null)
						{
							num = (short)989462541;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_683;
					}
					case 16:
					{
						global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet voiceAnnouncementListRecSet;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = voiceAnnouncementListRecSet.GetEnumerator();
						num = (short)1209925646;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_72;
					IL_2EF:
					num = (short)852623360;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3D0:
					num = (short)21495812;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1D5:
				return null;
				IL_683:
				return null;
				IL_72:
				list3 = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement>();
				list2 = new global::System.Collections.Generic.List<string>();
				num = (short)2030567427;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000097FC File Offset: 0x000079FC
		public static global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement[] GenerateNewVAPackageData(global::Motorola.CommonCPS.Server.EntityModel.Package[] serverVAPackages, string outPutDir)
		{
			int a_ = 6;
			short num = (short)263716864;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6B;
				}
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement> list;
				global::System.Collections.Generic.List<string> list2;
				for (;;)
				{
					IL_30:
					global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet voiceAnnouncementListRecSet;
					global::System.Collections.Generic.List<global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementInfo>.Enumerator enumerator3;
					global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate acpvoiceAnnouncementInflateDeflate;
					global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>> list3;
					global::System.Collections.Generic.List<global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementInfo> list4;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1341980672;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_609;
									}
									continue;
								case 1:
									num = (short)678756356;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)2006450177;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair = enumerator.Current;
									list.Add(global::SpecialFeatures.VoiceAnnouncements.VAHelper.a(keyValuePair.Value, keyValuePair.Key));
									num = (short)1787232258;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_698;
								}
								IL_645:
								num = (short)781385731;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_609:
								goto IL_645;
							}
							IL_698:
							goto IL_76B;
						}
						finally
						{
							global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_6AB;
					case 1:
						goto IL_253;
					case 2:
						if (voiceAnnouncementListRecSet.Count > 0)
						{
							num = (short)1052573704;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6AB;
					case 3:
						if (serverVAPackages != null)
						{
							num = (short)2080899077;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_556;
					case 4:
					{
						int num3;
						if (num3 >= serverVAPackages.Length)
						{
							num = (short)310837255;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement astrovoiceAnnouncement = (global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement)serverVAPackages[num3];
						list2.Add(astrovoiceAnnouncement.PackageName);
						num3++;
						num = (short)1607008266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						int num3 = 0;
						num = (short)932642817;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (voiceAnnouncementListRecSet != null)
						{
							num = (short)1747517451;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6AB;
					case 7:
						goto IL_556;
					case 8:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = voiceAnnouncementListRecSet.GetEnumerator();
						num = (short)1917321228;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						try
						{
							num = (short)1896153089;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator3.MoveNext())
									{
										num = (short)1186594819;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementInfo acpmotVoiceAnnouncementInfo = enumerator3.Current;
									string text = global::System.IO.Path.Combine(outPutDir, global::System.Guid.NewGuid().ToString() + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꞈﮌ", a_));
									num = (short)1743193605;
									short num4 = num;
									num = (short)1478100485;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_C4;
									default:
										num = (short)1293615104;
										if (num != 0)
										{
										}
										num = (short)1863516162;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									goto IL_C4;
								case 2:
								{
									global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementInfo acpmotVoiceAnnouncementInfo;
									string text;
									if (acpvoiceAnnouncementInflateDeflate.DeflateFile(acpmotVoiceAnnouncementInfo, text) == global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.VOICE_FILE_CONVERT_SUCCESS)
									{
										num = (short)57868292;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									num = (short)1902968838;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementInfo acpmotVoiceAnnouncementInfo;
									string text;
									global::System.Collections.Generic.KeyValuePair<string, string> item = new global::System.Collections.Generic.KeyValuePair<string, string>(acpmotVoiceAnnouncementInfo.FileName, text);
									list3.Add(item);
									num = (short)1959919621;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_243;
								}
								goto IL_F1;
								IL_C4:
								switch (0)
								{
								case 0:
									IL_F1:
									goto IL_1EB;
								}
								continue;
								IL_1EB:
								num = (short)1160380416;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_243:
							goto IL_292;
						}
						finally
						{
							((global::System.IDisposable)enumerator3).Dispose();
						}
						goto IL_253;
						IL_292:
						global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>.Enumerator enumerator = list3.GetEnumerator();
						num = (short)1902837760;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						num = (short)1343881217;
						if (num != 0)
						{
						}
						goto IL_253;
					case 11:
					{
						num = (short)1552809984;
						short num5 = num;
						num = (short)1994653698;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						try
						{
							num = (short)1755054081;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1609564166;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_366;
									}
									continue;
								case 2:
								{
									global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList;
									global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementInfo item2 = new global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementInfo(voiceAnnouncementList.General.VoiceFileName_A21220Value, voiceAnnouncementList.General.VoiceFileDataInfo_A21213Value.compressionType, voiceAnnouncementList.General.VoiceFileDataInfo_A21213Value.compressionParam, voiceAnnouncementList.General.VoiceFileDataInfo_A21213Value.voiceData.GetBuffer(), (int)voiceAnnouncementList.General.VoiceFileDataInfo_A21213Value.voiceData.Length);
									list4.Add(item2);
									num = (short)1036189701;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)1650524164;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList = (global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList)enumerator2.Current;
									num = (short)1712455687;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)813694984;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList;
									if (!list2.Contains(voiceAnnouncementList.General.VoiceFileName_A21220Value))
									{
										num = (short)1141374978;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList;
									if (voiceAnnouncementList.General.VoiceFileName_A21220_Valid)
									{
										num = (short)951320576;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									goto IL_4E2;
								}
								IL_36B:
								num = (short)666238979;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_366:
								goto IL_36B;
							}
							IL_4E2:
							goto IL_6AB;
						}
						finally
						{
							num = (short)2117140480;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_51A;
									}
									continue;
								case 1:
									enumerator2.Dispose();
									num = (short)1652097026;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_553;
								}
								IL_51A:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)1315766273;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_553:;
						}
						goto IL_556;
					}
					goto IL_6B;
					IL_253:
					num = (short)1010040836;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_556:
					list4 = new global::System.Collections.Generic.List<global::ACPVoiceAnnouncementLib.ACPMotVoiceAnnouncementInfo>();
					voiceAnnouncementListRecSet = (global::AcpCommonLib.FeatureManager.GetFeature(2300) as global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet);
					num = (short)982581254;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6AB:
					acpvoiceAnnouncementInflateDeflate = new global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate();
					list3 = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>();
					enumerator3 = list4.GetEnumerator();
					num = (short)464322569;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_76B:
				return list.ToArray();
				IL_6B:
				list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement>();
				list2 = new global::System.Collections.Generic.List<string>();
				num = (short)1039007747;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00009FC8 File Offset: 0x000081C8
		public static global::System.Collections.Generic.List<string> GetVAFileListFromCP()
		{
			short num = (short)294322176;
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
				global::System.Collections.Generic.List<string> list;
				global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet voiceAnnouncementListRecSet;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						num = (short)2094465028;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_292;
					case 2:
						try
						{
							num = (short)317128709;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1708785668;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList = (global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList)enumerator.Current;
									num = (short)378455862;
									short num3 = num;
									num = (short)1184614198;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_D1;
									default:
										num = (short)1954873344;
										if (num != 0)
										{
										}
										num = (short)933953538;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList;
									list.Add(voiceAnnouncementList.General.VoiceFileName_A21220Value.ToLower());
									num = (short)1089404934;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementList voiceAnnouncementList;
									if (voiceAnnouncementList.General.VoiceFileName_A21220_Valid)
									{
										num = (short)1689845761;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_21F;
								case 4:
									num = (short)1442185219;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_D1;
								}
								goto IL_FE;
								IL_D1:
								switch (0)
								{
								case 0:
									IL_FE:
									goto IL_199;
								}
								continue;
								IL_199:
								num = (short)133038080;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_21F:
							return list;
						}
						finally
						{
							num = (short)1805451265;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1530200066;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_257;
									}
									continue;
								case 2:
									goto IL_28F;
								}
								IL_257:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1190199296;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_28F:;
						}
						goto IL_292;
					case 3:
						if (voiceAnnouncementListRecSet != null)
						{
							num = (short)1915551744;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return list;
					case 4:
						if (voiceAnnouncementListRecSet.Count > 0)
						{
							num = (short)1713504257;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return list;
					}
					goto IL_42;
					IL_292:
					num = (short)10682368;
					short num4 = num;
					enumerator = voiceAnnouncementListRecSet.GetEnumerator();
					num = (short)1340342274;
					num2 = (int)((global::System.IntPtr)num);
				}
				return list;
				IL_42:
				list = new global::System.Collections.Generic.List<string>();
				voiceAnnouncementListRecSet = (global::AcpCommonLib.FeatureManager.GetFeature(2300) as global::SpecialFeatures.VoiceAnnouncements.List.VoiceAnnouncementListRecSet);
				num = (short)721879041;
				if (num != 0)
				{
				}
				num = (short)2042560515;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000A314 File Offset: 0x00008514
		private static string c(string A_0)
		{
			int a_ = 19;
			short num = (short)1214709761;
			if (num != 0)
			{
			}
			global::System.IO.Path.GetDirectoryName(A_0);
			global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate acpvoiceAnnouncementInflateDeflate = new global::ACPVoiceAnnouncementLib.ACPVoiceAnnouncementInflateDeflate();
			string text = global::SpecialFeatures.VoiceAnnouncements.VAHelper.TempFolder + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪕", a_) + (global::System.IO.Path.GetFileNameWithoutExtension(A_0) + global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뢕ﶛ", a_));
			global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes a_2 = acpvoiceAnnouncementInflateDeflate.DeflateFile(A_0, text);
			if (!string.IsNullOrEmpty(global::SpecialFeatures.VoiceAnnouncements.VAHelper.a(a_2)))
			{
				for (;;)
				{
					num = (short)1679633210;
					short num2 = num;
					num = (short)1398942522;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_E6;
					}
					break;
				}
				num = (short)311623680;
				short num3 = num;
				IL_E6:
				num = (short)1215037440;
				if (num != 0)
				{
				}
				throw global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::SpecialFeatures.VoiceAnnouncements.VAHelper.a(a_2));
			}
			return text;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x0000A42C File Offset: 0x0000862C
		private static string a(global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes A_0)
		{
			short num = (short)2012610572;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (A_0 == global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.INPUT_FILE_SIZE_ERROR)
					{
						num = (short)1138622477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)751239169;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (A_0 == global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.OUTPUT_FILE_ERROR)
					{
						num = (short)609943560;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)657850370;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (A_0 == global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.INPUT_FILE_DOES_NOT_EXIST)
					{
						num = (short)277413897;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)16973827;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (A_0 == global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.INPUT_FILE_ERROR)
					{
						num = (short)1270677504;
						short num3 = num;
						num = (short)492961798;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_293;
				case 4:
					goto IL_1DB;
				case 5:
					goto IL_C8;
				case 6:
					goto IL_1A0;
				case 7:
					if (A_0 == global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.OUTPUT_VOICE_FILE_ALREADY_EXISTS)
					{
						num = (short)2138374148;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1049493514;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_136;
				case 9:
					goto IL_FF;
				case 10:
					if (A_0 != global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.INPUT_FILE_FORMAT_ERROR)
					{
						num = (short)836370443;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_230;
				case 11:
					num = (short)1600716800;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				case 13:
					goto IL_222;
				}
				IL_5C:
				if (A_0 == global::ACPVoiceAnnouncementLib.ACPInflateDeflateCodes.VOICE_FILE_CONVERT_SUCCESS)
				{
					num = (short)1053227679;
					short num4 = num;
					num = (short)363002527;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_13B;
					default:
						num = (short)990511104;
						if (num != 0)
						{
						}
						num = (short)1315766277;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				else
				{
					num = (short)1137836039;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_C8:
			return string.Empty;
			IL_FF:
			return global::CommonResources.AppResources.Failed_Input_wav_file_does_not_exist;
			IL_136:
			return global::CommonResources.AppResources.Failed_Unable_to_generate_output_mva_file;
			IL_13B:
			return global::CommonResources.AppResources.Voice_Announcement_Already_Exists;
			IL_1A0:
			return global::CommonResources.AppResources.Failed_Input_wav_file_error;
			IL_1DB:
			goto IL_13B;
			IL_222:
			IL_230:
			num = (short)1596784641;
			if (num != 0)
			{
			}
			return global::CommonResources.AppResources.Failed_Wav_file_format_needs_to_be;
			IL_293:
			return global::CommonResources.AppResources.Failed_Id;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000A6D4 File Offset: 0x000088D4
		private static global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement a(string A_0, string A_1 = "")
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement astrovoiceAnnouncement;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_A3;
				case 1:
				{
					num2 = (short)916528307;
					short num3 = num2;
					num2 = (short)645143731;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3A;
					default:
						num2 = (short)139591680;
						if (num2 != 0)
						{
						}
						num2 = (short)126091265;
						if (num2 != 0)
						{
						}
						astrovoiceAnnouncement.PackageName = global::System.IO.Path.GetFileNameWithoutExtension(A_0);
						num2 = (short)437518339;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_3A;
				case 3:
					goto IL_13D;
				}
				goto IL_20;
				IL_3A:
				if (string.IsNullOrEmpty(A_1))
				{
					num2 = (short)555024384;
					short num4 = num2;
					num2 = (short)199819265;
					num = (int)((global::System.IntPtr)num2);
				}
				else
				{
					astrovoiceAnnouncement.PackageName = A_1;
					num2 = (short)1111228416;
					num = (int)((global::System.IntPtr)num2);
				}
			}
			IL_A3:
			IL_13D:
			global::Motorola.CommonCPS.Server.EntityModel.RMFile rmfile = new global::Motorola.CommonCPS.Server.EntityModel.RMFile
			{
				Url = A_0
			};
			astrovoiceAnnouncement.RMFile = rmfile;
			return astrovoiceAnnouncement;
			IL_20:
			astrovoiceAnnouncement = new global::Motorola.CommonCPS.Server.EntityModel.ASTROVoiceAnnouncement();
			num2 = (short)1959133186;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000A838 File Offset: 0x00008A38
		private static string[] b(string A_0)
		{
			short num = (short)818479105;
			if (num != 0)
			{
			}
			num = (short)1405616128;
			short num2 = num;
			num = (short)1637535487;
			short num3 = num;
			num = (short)997248767;
			switch (num3 == num)
			{
			}
			num = (short)1173487616;
			if (num != 0)
			{
			}
			return new string[]
			{
				global::System.IO.Path.GetFileName(A_0)
			};
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000A8F0 File Offset: 0x00008AF0
		private static void a(string A_0)
		{
			short num;
			try
			{
				num = (short)545998675;
				short num2 = num;
				num = (short)1608206163;
				switch (num2 == num)
				{
				}
				num = (short)1294729216;
				if (num != 0)
				{
				}
				global::System.IO.File.SetAttributes(A_0, global::System.IO.FileAttributes.Normal);
				global::System.IO.File.Delete(A_0);
			}
			catch
			{
			}
			num = (short)319684608;
			short num3 = num;
			num = (short)435683329;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000A9C0 File Offset: 0x00008BC0
		// Note: this type is marked as 'beforefieldinit'.
		static VAHelper()
		{
			short num = (short)1903755265;
			if (num != 0)
			{
			}
			num = (short)1248722944;
			short num2 = num;
			num = (short)229654104;
			short num3 = num;
			num = (short)1758019160;
			switch (num3 == num)
			{
			}
			num = (short)128188416;
			if (num != 0)
			{
			}
			global::SpecialFeatures.VoiceAnnouncements.VAHelper.TempFolder = global::System.IO.Path.GetTempPath();
		}

		// Token: 0x04000019 RID: 25
		public const string EXTENTIONWAV = ".wav";

		// Token: 0x0400001A RID: 26
		public const string EXTENTIONMVA = ".mva";

		// Token: 0x0400001B RID: 27
		internal static string TempFolder;
	}
}
