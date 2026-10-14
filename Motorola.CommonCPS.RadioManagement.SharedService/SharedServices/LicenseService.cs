using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x0200002B RID: 43
	internal abstract class LicenseService : global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceBase, global::Motorola.CommonCPS.RadioManagement.SharedServices.ILicenseService, global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x06000523 RID: 1315 RVA: 0x00032100 File Offset: 0x00030300
		public LicenseService(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor serverAccessor) : base(serverAccessor)
		{
		}

		// Token: 0x06000524 RID: 1316 RVA: 0x00032114 File Offset: 0x00030314
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo> QueryAppEIDInfo(string EID, out string warning)
		{
			int a_ = 13;
			short num = (short)186187776;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_48;
				}
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
					{
						num = (short)1054670848;
						short num3 = num;
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo> list;
						if (list.Count == 0)
						{
							num = (short)1119092738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return list;
					}
					case 1:
						try
						{
							num = (short)2104623117;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.CommonCPS.Server.EntityModel.EntitlementResponseItem entitlementResponseItem;
								int num4;
								switch (num2)
								{
								case 0:
								{
									string @string;
									global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? region;
									global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo item = new global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo(EID, entitlementResponseItem.activationId, entitlementResponseItem.productName, @string, entitlementResponseItem.totalCount.ToString(global::System.Globalization.CultureInfo.CurrentCulture), entitlementResponseItem.availableCount.ToString(global::System.Globalization.CultureInfo.CurrentCulture), num4.ToString(global::System.Globalization.CultureInfo.CurrentCulture))
									{
										EnterQtyFocus = true,
										Region = region
									};
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo> list;
									list.Add(item);
									num = (short)1192361986;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_259;
								case 3:
								{
									if (!global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.IsAppLicense_RadioManagement(entitlementResponseItem.productName))
									{
										string @string;
										global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? region;
										this.GetFeatureNameRegion(entitlementResponseItem.productName, out @string, out region);
										num = (short)9175041;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1978286824;
									short num5 = num;
									num = (short)1479951080;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_353;
									default:
										num = (short)1406795776;
										if (num != 0)
										{
										}
										num = (short)2137063436;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									warning = global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_QueryEID_UnSupported_AppCFS;
									num = (short)1266286603;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_353;
								case 6:
									goto IL_259;
								case 7:
									num = (short)1635647498;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									string @string;
									if (!string.IsNullOrEmpty(@string))
									{
										num = (short)2112684032;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.EntitlementResponseItem>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)173473799;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									entitlementResponseItem = enumerator.Current;
									num = (short)1441071109;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									goto IL_3DA;
								case 12:
								{
									string @string = global::Motorola.CommonCPS.ResourceRepository.Resources.ResourceManager.GetString(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("ﮧﺫ", a_));
									num = (short)2115239942;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 13:
									switch (0)
									{
									case 0:
										goto IL_147;
									}
									continue;
								}
								IL_14C:
								num = (short)526581769;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_147:
								goto IL_14C;
								IL_259:
								num4 = 0;
								num = (short)653852680;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_353:
								if (!global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.DeviceOperation.IsValidAppLicense(entitlementResponseItem.productName))
								{
									num = (short)255983620;
									num2 = (int)((global::System.IntPtr)num);
								}
								else
								{
									global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? region = null;
									num = (short)1555300355;
									num2 = (int)((global::System.IntPtr)num);
								}
							}
							IL_3DA:
							goto IL_84;
						}
						finally
						{
							num = (short)1244528641;
							if (num != 0)
							{
							}
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.EntitlementResponseItem>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_414;
						IL_84:
						num = (short)118358016;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_E4;
					case 3:
					{
						global::Motorola.CommonCPS.Server.EntityModel.EntitlementList entitlementList = global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioManagementSoftwareLicenseAdapter.Instance.QueryAppLicensesFromEntitlementID(EID);
						if (entitlementList.entitlementItems.Count == 0)
						{
							goto Block_1;
						}
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDInfo>();
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.EntitlementResponseItem>.Enumerator enumerator = entitlementList.entitlementItems.GetEnumerator();
						num = (short)1605894145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_48;
				}
				Block_1:
				goto IL_414;
				IL_E4:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Sfc_No_Features_On_Server);
				IL_414:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Sfc_No_Features_On_Server);
				IL_48:
				warning = string.Empty;
				num = (short)2038956035;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
		}

		// Token: 0x06000525 RID: 1317 RVA: 0x00032598 File Offset: 0x00030798
		public bool FilterLicenseByRegion(string licenseName, global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName region)
		{
			short num = (short)1587478528;
			switch (num)
			{
			default:
			{
				num = (short)1711996937;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? regionName;
						global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName regionName2;
						if (!(regionName.GetValueOrDefault() == regionName2 & regionName != null))
						{
							goto IL_161;
						}
						return false;
					}
					case 1:
						return true;
					case 2:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? regionName3;
						global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? regionName = regionName3;
						global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName regionName2 = region;
						num = (short)1665925127;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_8E;
					case 4:
					{
						num = (short)1367315138;
						short num3 = num;
						num = (short)966300354;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_161;
						default:
							goto IL_113;
						}
						break;
					}
					case 5:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? regionName3;
						if (regionName3 != null)
						{
							num = (short)252575750;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 6:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? regionName3;
						global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? regionName = regionName3;
						global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName regionName2 = global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName.NULL;
						num = (short)1706950656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? regionName;
						global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName regionName2;
						if (regionName.GetValueOrDefault() == regionName2 & regionName != null)
						{
							num = (short)731643908;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 8:
					{
						if (region == global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName.NULL)
						{
							num = (short)73859073;
							if (num != 0)
							{
							}
							num = (short)146472960;
							short num4 = num;
							num = (short)1961230337;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text = null;
						global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? regionName3 = null;
						this.SplitRawLicenseName(licenseName, out text, out regionName3);
						num = (short)1725759493;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						switch (0)
						{
						case 0:
							goto IL_6D;
						}
						continue;
					}
					IL_6D:
					if (string.IsNullOrEmpty(licenseName))
					{
						num = (short)1024196611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1407320072;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_161:
					num = (short)470614018;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_8E:
				throw new global::System.ArgumentNullException();
				IL_113:
				num = (short)1848508416;
				if (num != 0)
				{
				}
				return true;
			}
			}
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x00032810 File Offset: 0x00030A10
		public bool SplitRawLicenseName(string rawLicenseName, out string licenseName, out global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? region)
		{
			int a_ = 14;
			switch (0)
			{
			case 0:
				goto IL_49;
			}
			int num;
			short num3;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					int num2;
					if (num2 <= 0)
					{
						num3 = (short)1784479749;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					string text = rawLicenseName.Substring(0, num2);
					licenseName = rawLicenseName.Substring(num2 + 1);
					num3 = (short)61734915;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 1:
					return true;
				case 2:
				{
					string text;
					global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName value;
					if (!global::System.Enum.TryParse<global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName>(text, out value))
					{
						num3 = (short)1352466441;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					region = new global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName?(value);
					num3 = (short)822870016;
					short num4 = num3;
					num3 = (short)1135607809;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 3:
				{
					string text;
					if (!string.IsNullOrEmpty(text))
					{
						goto IL_257;
					}
					return true;
				}
				case 4:
				{
					region = new global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName?(global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName.EMEA);
					num3 = (short)285941488;
					short num5 = num3;
					num3 = (short)1487085296;
					switch ((num5 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_257;
					default:
						num3 = (short)244580352;
						if (num3 != 0)
						{
						}
						num3 = (short)283901962;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					break;
				}
				case 5:
					return false;
				case 6:
				{
					string text;
					if (string.Equals(text, global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("", a_), global::System.StringComparison.Ordinal))
					{
						num3 = (short)252182532;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)1015873538;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 7:
					goto IL_87;
				case 8:
					num3 = (short)190906374;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 9:
					return false;
				case 10:
					return true;
				case 11:
				{
					if (string.IsNullOrEmpty(rawLicenseName))
					{
						num3 = (short)528482311;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					int num2 = rawLicenseName.IndexOf('_');
					num3 = (short)551682048;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				}
				goto IL_49;
				IL_257:
				num3 = (short)2085683201;
				if (num3 != 0)
				{
				}
				num3 = (short)850591752;
				num = (int)((global::System.IntPtr)num3);
			}
			IL_87:
			throw new global::System.ArgumentNullException();
			IL_49:
			region = null;
			licenseName = null;
			num3 = (short)1320812555;
			num = (int)((global::System.IntPtr)num3);
			goto IL_13;
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x00032ABC File Offset: 0x00030CBC
		public virtual global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.SharedServices.AppLicenseInfo> GetRadioMgmtFeature()
		{
			short num = (short)931790848;
			switch (num)
			{
			default:
			{
				num = (short)493158400;
				short num2 = num;
				global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.SharedServices.AppLicenseInfo> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SharedServices.AppLicenseInfo>();
				global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.RadioManagementLicenseInfo> radioManagementFeature = base.ServerAccessor.GetRadioManagementFeature();
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ApplicationFeatureSummary> source = base.ServerAccessor.ListApplicationFeatureSummaries();
				global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.Server.EntityModel.RadioManagementLicenseInfo> enumerator = radioManagementFeature.GetEnumerator();
				try
				{
					num = (short)1056112644;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							num = (short)1097728001;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_1E9;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)2008088576;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.RadioManagementLicenseInfo radioManagementLicenseInfo = enumerator.Current;
							global::Motorola.CommonCPS.RadioManagement.SharedServices.AppLicenseInfo info = new global::Motorola.CommonCPS.RadioManagement.SharedServices.AppLicenseInfo();
							info.Region = new global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName?(radioManagementLicenseInfo.Region);
							global::System.Collections.Generic.KeyValuePair<string, string> radioMgmtFeatureName = this.GetRadioMgmtFeatureName(new global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName?(radioManagementLicenseInfo.Region));
							info.RawFeatureCode = radioMgmtFeatureName.Key;
							info.FeatureName = radioMgmtFeatureName.Value;
							info.FeatureType = global::Motorola.CommonCPS.Server.CommonDBConstants.AppLicenseType.RadioManagement;
							info.RadioCapacity = radioManagementLicenseInfo.RadioCapacity;
							info.UsedRadioCount = radioManagementLicenseInfo.UsedRadioCount;
							info.AppFeatureSummary = source.Where(delegate(global::Motorola.CommonCPS.Server.EntityModel.ApplicationFeatureSummary ft)
							{
								short num5 = (short)1472266241;
								if (num5 != 0)
								{
								}
								num5 = (short)382650516;
								short num6 = num5;
								num5 = (short)1258145940;
								switch (num6 == num5)
								{
								}
								num5 = (short)1720254464;
								if (num5 != 0)
								{
								}
								num5 = (short)749469696;
								short num7 = num5;
								return ft.FeatureName == info.RawFeatureCode;
							}).FirstOrDefault<global::Motorola.CommonCPS.Server.EntityModel.ApplicationFeatureSummary>();
							list.Add(info);
							num = (short)1091633154;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							switch (0)
							{
							case 0:
								goto IL_A8;
							}
							continue;
						}
						IL_193:
						num = (short)563281923;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_A8:
						goto IL_193;
					}
					IL_1E9:;
				}
				finally
				{
					num = (short)1049100290;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_2AA;
						case 1:
							enumerator.Dispose();
							goto IL_292;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_220;
							}
							continue;
						}
						IL_220:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1724649362;
						short num4 = num;
						num = (short)2029653906;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1013186560;
							if (num != 0)
							{
							}
							num = (short)1403387905;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_292:
						num = (short)1313275904;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_2AA:;
				}
				num = (short)1488912385;
				if (num != 0)
				{
				}
				return list;
			}
			}
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00032DBC File Offset: 0x00030FBC
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.SharedServices.AppLicenseInfo> GetRegisteredAppLicenses()
		{
			short num = (short)91424166;
			short num2 = num;
			num = (short)1848182182;
			switch (num2 == num)
			{
			}
			num = (short)1445462016;
			if (num != 0)
			{
			}
			num = (short)2133983232;
			short num3 = num;
			num = (short)1976107009;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.DeviceOperation.GetRegisteredAppLicenses();
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00032E74 File Offset: 0x00031074
		public virtual global::System.Collections.Generic.List<string> GetAppLicenseNames(global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? region = null)
		{
			short num = (short)770866996;
			short num2 = num;
			num = (short)1031765812;
			switch (num2 == num)
			{
			}
			num = (short)273285121;
			if (num != 0)
			{
			}
			num = (short)809369600;
			short num3 = num;
			num = (short)1990524928;
			if (num != 0)
			{
			}
			return new global::System.Collections.Generic.List<string>();
		}

		// Token: 0x0600052A RID: 1322 RVA: 0x00032F20 File Offset: 0x00031120
		public bool IsAppLicenseSupport_RRP(global::System.Collections.Generic.IList<global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName?> regionList)
		{
			short num = (short)90794421;
			short num2 = num;
			num = (short)618424757;
			switch (num2 == num)
			{
			}
			num = (short)742195201;
			if (num != 0)
			{
			}
			num = (short)1822031872;
			short num3 = num;
			num = (short)896466944;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.DeviceOperation.IsAppLicenseSupport_RRP(regionList);
		}

		// Token: 0x0600052B RID: 1323 RVA: 0x00032FDC File Offset: 0x000311DC
		public global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<string, string>> GetAppLicenseComments()
		{
			short num = (short)1921515520;
			switch (num)
			{
			default:
			{
				num = (short)1353973760;
				short num2 = num;
				num = (short)884670465;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.IList<global::System.Collections.Generic.KeyValuePair<string, string>> list = new global::System.Collections.Generic.List<global::System.Collections.Generic.KeyValuePair<string, string>>();
				using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ApplicationFeatureSummary>.Enumerator enumerator = base.ServerAccessor.ListApplicationFeatureSummaries().GetEnumerator())
				{
					num = (short)1840578564;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							num = (short)1614217217;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_19E;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1754923008;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.EntityModel.ApplicationFeatureSummary applicationFeatureSummary = enumerator.Current;
							global::System.Collections.Generic.KeyValuePair<string, string> item = new global::System.Collections.Generic.KeyValuePair<string, string>(applicationFeatureSummary.FeatureName, applicationFeatureSummary.Comments);
							list.Add(item);
							num = (short)763297794;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							switch (0)
							{
							case 0:
								goto IL_C2;
							}
							continue;
						}
						IL_FD:
						num = (short)1596013520;
						short num4 = num;
						num = (short)1645624272;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)11993088;
							if (num != 0)
							{
							}
							num = (short)460783619;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_C2:
						goto IL_FD;
					}
					IL_19E:;
				}
				return list;
			}
			}
		}

		// Token: 0x0600052C RID: 1324 RVA: 0x000331B4 File Offset: 0x000313B4
		public string GenerateHostID()
		{
			short num = (short)2000224258;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_118;
				case 1:
					global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerHostID = base.ServerAccessor.GenerateHostID();
					goto IL_DB;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				if (!string.IsNullOrEmpty(global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerHostID))
				{
					break;
				}
				num = (short)1127816980;
				short num3 = num;
				num = (short)1132601108;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1837432832;
					if (num != 0)
					{
					}
					num = (short)1972502528;
					short num4 = num;
					num = (short)1763966977;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_DB:
				num = (short)80216065;
				if (num != 0)
				{
				}
				num = (short)1994326016;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_118:
			return global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerHostID;
		}

		// Token: 0x0600052D RID: 1325 RVA: 0x000332E0 File Offset: 0x000314E0
		public void EnableFeature_CLL(global::Motorola.CommonCPS.Server.EntityModel.FeatureResponseObject referenceReq, string hostID, byte[] capabilityResponse)
		{
			short num = (short)104955014;
			short num2 = num;
			num = (short)972323974;
			switch (num2 == num)
			{
			}
			num = (short)1672282113;
			if (num != 0)
			{
			}
			num = (short)314048512;
			short num3 = num;
			num = (short)989069312;
			if (num != 0)
			{
			}
			base.ServerAccessor.EnableFeature_CLL(referenceReq, hostID, capabilityResponse);
		}

		// Token: 0x0600052E RID: 1326 RVA: 0x00033398 File Offset: 0x00031598
		public void EnableFeature_Radio(string radioID, byte[] capabilityResponse)
		{
			short num = (short)114191485;
			short num2 = num;
			num = (short)1771727997;
			switch (num2 == num)
			{
			}
			num = (short)370802689;
			if (num != 0)
			{
			}
			num = (short)265093120;
			short num3 = num;
			num = (short)1220542464;
			if (num != 0)
			{
			}
			base.ServerAccessor.EnableFeature_Radio(radioID, capabilityResponse);
		}

		// Token: 0x0600052F RID: 1327
		public abstract global::System.Collections.Generic.KeyValuePair<string, string> GetRadioMgmtFeatureName(global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? region);

		// Token: 0x06000530 RID: 1328 RVA: 0x00033450 File Offset: 0x00031650
		public bool SubmitAppLicense(string AID, int count)
		{
			short num = (short)1375093664;
			short num2 = num;
			num = (short)1204437920;
			switch (num2 == num)
			{
			}
			num = (short)1975058433;
			if (num != 0)
			{
			}
			num = (short)15400960;
			short num3 = num;
			num = (short)2117140480;
			if (num != 0)
			{
			}
			string hostID = this.GenerateHostID();
			global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest request = global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioManagementSoftwareLicenseAdapter.Instance.CreateActivationRequest(hostID, AID, count);
			string empty = string.Empty;
			byte[] capabilityResponse = global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioManagementSoftwareLicenseAdapter.Instance.SubmitAppLicense(request, hostID, AID, out empty);
			this.EnableFeature_CLL(null, hostID, capabilityResponse);
			return true;
		}

		// Token: 0x06000531 RID: 1329 RVA: 0x00033530 File Offset: 0x00031730
		protected virtual bool IsValidProduct(string productName)
		{
			short num = (short)1765907150;
			short num2 = num;
			num = (short)232364750;
			switch (num2 == num)
			{
			}
			num = (short)1386610689;
			if (num != 0)
			{
			}
			num = (short)2043936768;
			short num3 = num;
			num = (short)1309736960;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06000532 RID: 1330 RVA: 0x000335DC File Offset: 0x000317DC
		public void SubmitAppLicenseFile(byte[] licenseFile)
		{
			short num = (short)1318649856;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3C;
				}
				bool flag;
				string text;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						goto IL_E3;
					case 1:
						if (!flag)
						{
							num = (short)1480654848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_281;
					case 2:
					{
						num = (short)929890305;
						if (num != 0)
						{
						}
						try
						{
							using (global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.FeatureItem>.Enumerator enumerator = global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioManagementSoftwareLicenseAdapter.Instance.QueryFeaturesFromResponse(licenseFile, text, string.Empty, string.Empty, false).features.GetEnumerator())
							{
								num = (short)685506566;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_241;
									case 1:
									{
										num = (short)1640287703;
										short num3 = num;
										num = (short)758304215;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_16E;
										default:
											num = (short)503840768;
											if (num != 0)
											{
											}
											flag = true;
											num = (short)1979711490;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
										goto IL_241;
									case 3:
										goto IL_259;
									case 4:
									{
										if (!enumerator.MoveNext())
										{
											goto IL_16E;
										}
										global::Motorola.CommonCPS.Server.EntityModel.FeatureItem featureItem = enumerator.Current;
										num = (short)101384197;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
									{
										global::Motorola.CommonCPS.Server.EntityModel.FeatureItem featureItem;
										if (this.IsValidProduct(featureItem.featureName))
										{
											num = (short)576520193;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 6:
										switch (0)
										{
										case 0:
											goto IL_14E;
										}
										continue;
									}
									IL_150:
									num = (short)1987379204;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_14E:
									goto IL_150;
									IL_16E:
									num = (short)1580072960;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_241:
									num = (short)132907011;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_259:;
							}
							goto IL_83;
						}
						catch
						{
							flag = false;
							goto IL_83;
						}
						goto IL_276;
						IL_83:
						num = (short)506003456;
						short num4 = num;
						num = (short)1526661121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_3C;
				}
				IL_E3:
				IL_276:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.CommonCPS.ResourceRepository.Resources.Licenses_FileFormat);
				IL_281:
				this.EnableFeature_CLL(null, text, licenseFile);
				return;
				IL_3C:
				text = this.GenerateHostID();
				flag = false;
				num = (short)1009647618;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000533 RID: 1331 RVA: 0x000338A8 File Offset: 0x00031AA8
		public byte[] RecoverAppLicense(out string warningMsg, bool isUpdateToServer = true)
		{
			short num = (short)2059665409;
			if (num != 0)
			{
			}
			num = (short)1636892672;
			short num2 = num;
			num = (short)20922703;
			short num3 = num;
			num = (short)326779215;
			string hostID;
			byte[] array;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_FB:
				this.EnableFeature_CLL(null, hostID, array);
				num = (short)271187968;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)2142896128;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_B8;
				}
				break;
			}
			for (;;)
			{
				IL_A6:
				switch (num4)
				{
				case 0:
					return array;
				case 1:
					if (isUpdateToServer)
					{
						num = (short)1398013954;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return array;
				case 2:
					goto IL_F9;
				}
				goto IL_B8;
			}
			IL_F9:
			goto IL_FB;
			IL_B8:
			hostID = this.GenerateHostID();
			array = global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioManagementSoftwareLicenseAdapter.Instance.RecoverAppLicense(hostID, out warningMsg);
			num = (short)1189740545;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_A6;
		}

		// Token: 0x06000534 RID: 1332 RVA: 0x000339D0 File Offset: 0x00031BD0
		public virtual global::Motorola.CommonCPS.Server.EntityModel.FeatureList GetAppLicensesFromLicenseServer()
		{
			global::Motorola.CommonCPS.Server.EntityModel.FeatureList result;
			for (;;)
			{
				IL_00:
				short num = (short)19464192;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)1201209345;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					byte[] array;
					string text;
					for (;;)
					{
						IL_4E:
						switch (num2)
						{
						case 0:
							return result;
						case 1:
						{
							if (array == null)
							{
								return result;
							}
							num = (short)533780338;
							short num3 = num;
							num = (short)1979635570;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num = (short)1436090368;
								short num4 = num;
								num = (short)1548484608;
								if (num != 0)
								{
								}
								num = (short)363528194;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 2:
							result = global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioManagementSoftwareLicenseAdapter.Instance.QueryFeaturesFromResponse(array, text, string.Empty, string.Empty, false);
							num = (short)1811415040;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					IL_61:
					result = null;
					text = this.GenerateHostID();
					string empty = string.Empty;
					array = global::Motorola.CommonCPS.RadioManagement.SoftwareLicenseAdapter.RadioManagementSoftwareLicenseAdapter.Instance.RecoverAppLicense(text, out empty);
					num = (short)574488577;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_4E;
				}
				}
			}
			return result;
		}

		// Token: 0x06000535 RID: 1333 RVA: 0x00033B3C File Offset: 0x00031D3C
		public global::Motorola.CommonCPS.Server.EntityModel.ApplicationFeatureSummary UpdateAppLicense(global::Motorola.CommonCPS.Server.EntityModel.ApplicationFeatureSummary summary, string comment)
		{
			short num = (short)1858536899;
			short num2 = num;
			num = (short)2111636931;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2030305280;
				if (num != 0)
				{
				}
				num = (short)628686849;
				if (num != 0)
				{
				}
				if (summary == null)
				{
					return null;
				}
				num = (short)1213857792;
				short num3 = num;
				break;
			}
			}
			global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet();
			validateEntitySet.RelatedObject = new global::System.Guid?(summary.Uuid);
			validateEntitySet.Type = global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.ApplicationFeatureSummary;
			validateEntitySet.ValidateEntityList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ValidatedField>();
			global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.AppendValidatedField(validateEntitySet.ValidateEntityList, summary);
			return base.ServerAccessor.UpdateApplicationFeatureComments(summary.FeatureName, comment, validateEntitySet);
		}

		// Token: 0x06000536 RID: 1334 RVA: 0x00033C34 File Offset: 0x00031E34
		protected virtual void GetFeatureNameRegion(string rawLicenseName, out string featureName, out global::Motorola.CommonCPS.Server.CommonDBConstants.RegionName? region)
		{
			short num = (short)319444988;
			short num2 = num;
			num = (short)119756796;
			switch (num2 == num)
			{
			}
			num = (short)888799233;
			if (num != 0)
			{
			}
			num = (short)2136408064;
			if (num != 0)
			{
			}
			num = (short)206241792;
			short num3 = num;
			featureName = string.Empty;
			region = null;
		}
	}
}
