using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using AcpASKLib;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AcpSecurityLib;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ConventionalWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Security
{
	// Token: 0x02000045 RID: 69
	public static class ASKConstraints
	{
		// Token: 0x0600077A RID: 1914 RVA: 0x0006E410 File Offset: 0x0006C610
		static ASKConstraints()
		{
			short num = (short)335208949;
			short num2 = num;
			num = (short)1669718517;
			switch (num2 == num)
			{
			}
			num = (short)552534017;
			if (num != 0)
			{
			}
			num = (short)105054208;
			short num3 = num;
			num = (short)951910400;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Security.ASKConstraints.a = null;
			global::SpecialFeatures.Security.ASKConstraints.b = global::SpecialFeatures.Security.ProtectionOption.UNSPECIFIED;
			global::SpecialFeatures.Security.ASKConstraints.c = false;
			global::SpecialFeatures.Security.ASKConstraints.e = new global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, global::AcpCommonLib.IAcpField>();
			global::SpecialFeatures.Security.ASKConstraints.f = -1;
			global::SpecialFeatures.Security.ASKConstraints.a = new global::AcpASKLib.SystemKeyLoadedEventHandler(global::SpecialFeatures.Security.ASKConstraints.a);
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x0006E4EC File Offset: 0x0006C6EC
		public static void Initialize()
		{
			short num = (short)512800691;
			short num2 = num;
			num = (short)571389875;
			switch (num2 == num)
			{
			}
			num = (short)1802895361;
			if (num != 0)
			{
			}
			num = (short)1894121472;
			short num3 = num;
			num = (short)1096286208;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Security.ASKConstraints.e.Clear();
			global::AcpBusinessLayer.AcpConstraints.IsPermissionGranted = new global::AcpCommonLib.InternalConstraint(global::SpecialFeatures.Security.ASKConstraints.IsPermissionGranted);
			global::AcpBusinessLayer.AcpConstraints.IsValuePermitted = new global::AcpCommonLib.InternalConstraint(global::SpecialFeatures.Security.ASKConstraints.IsValuePermitted);
			global::SpecialFeatures.Security.ASKConstraints.a();
			global::SpecialFeatures.Security.ASKConstraints.b = global::SpecialFeatures.Security.RadioAccessValidator.GetCodeplugProtectionOption();
			global::AcpSecurityLib.SecurityManager.SystemKeyLoadedEvent += global::SpecialFeatures.Security.ASKConstraints.a;
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x0006E5D8 File Offset: 0x0006C7D8
		internal static bool IsPermissionGranted(global::AcpCommonLib.IAcpField self)
		{
			short num = (short)1030750208;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B4;
				}
				bool result;
				for (;;)
				{
					IL_29:
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
					object obj;
					global::SpecialFeatures.Security.FieldMapInfo fieldMapInfo;
					string cpsFieldName;
					switch (num2)
					{
					case 0:
					{
						global::AcpCommonLib.IAcpField acpField;
						if (self.Name == acpField.Name)
						{
							num = (short)1874198534;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 1:
						if (global::AcpCommonLib.AppInfoManager.AppType == global::AcpCommonLib.ApplicationType.CPS)
						{
							num = (short)1784217623;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
					{
						global::AcpCommonLib.IAcpField acpField;
						int value = ((global::AcpBusinessLayer.AcpField<int>)acpField).Value;
						global::AcpASKLib.AccessElementIDType elementID = global::SpecialFeatures.Security.FieldMapManager.GetElementID(self);
						bool trkSysGeneralAskRequired;
						bool bAskOnly = global::SpecialFeatures.Security.ASKConstraints.IsASKRequired(trkSysGeneralAskRequired);
						global::AcpASKLib.KeyType keyType;
						result = global::AcpSecurityLib.SecurityManager.IsFieldEditable(elementID, keyType, value, bAskOnly);
						num = (short)974061573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general;
						if (general != null)
						{
							num = (short)434503688;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_58E;
					}
					case 4:
						if (trunkingSystem != null)
						{
							num = (short)747569170;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 5:
						return result;
					case 6:
						num = (short)499712017;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)1411645441;
						if (num != 0)
						{
						}
						goto IL_58E;
					case 8:
						num = (short)965410840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (self == null)
						{
							num = (short)30670879;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1031798805;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						trunkingSystem.General.TrkSysGeneralSystemKeyPresent_A9241.Value = global::SpecialFeatures.Security.ASKConstraints.b(self);
						num = (short)1292107783;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						obj = null;
						goto IL_470;
					case 12:
						goto IL_1E4;
					case 13:
					{
						global::AcpCommonLib.IAcpField acpField;
						if (acpField != null)
						{
							num = (short)1727266832;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 14:
						return result;
					case 15:
						if (fieldMapInfo != null)
						{
							num = (short)1079574540;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 16:
						num = (short)635371539;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (fieldMapInfo is global::SpecialFeatures.Security.KeyFieldMapInfo)
						{
							num = (short)327614493;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 18:
					{
						global::AcpCommonLib.ConstraintManager.Suspend();
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general = trunkingSystem.General;
						num = (short)1355874307;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						global::AcpASKLib.KeyType keyType;
						if (keyType != global::AcpASKLib.KeyType.UNDEFINED_KEY)
						{
							num = (short)1283981339;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 20:
						if (!global::AcpSecurityLib.SecurityManager.IsSpecialKeyLoaded)
						{
							num = (short)559153184;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 21:
						cpsFieldName = self.Name;
						goto IL_1A4;
					case 22:
					{
						global::AcpCommonLib.IAcpField acpField;
						bool trkSysGeneralAskRequired;
						global::AcpASKLib.KeyType keyType;
						global::SpecialFeatures.Security.FieldMapManager.GetKeyFieldInfo(self, out keyType, out acpField, out trkSysGeneralAskRequired);
						num = (short)1337589760;
						short num3 = num;
						num = (short)1271595021;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						num = (short)152174601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general;
						if (general.TrkSysGeneralSystemKeyPresent_A9241 != null)
						{
							num = (short)1495269386;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_58E;
					}
					case 25:
					{
						global::AcpCommonLib.IAcpFeatureSection parent = self.Parent;
						if (parent == null)
						{
							num = (short)710934539;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						obj = parent.Parent;
						goto IL_470;
					}
					case 26:
						cpsFieldName = null;
						goto IL_1A4;
					case 27:
					{
						num = (short)100943875;
						short num4 = num;
						num = (short)1798522883;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1E4;
						default:
							num = (short)1965359104;
							if (num != 0)
							{
							}
							num = (short)569770014;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 28:
						if (!(fieldMapInfo is global::SpecialFeatures.Security.RefKeyFieldMapInfo))
						{
							num = (short)726401046;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 29:
						num = (short)409862169;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
					{
						global::AcpCommonLib.IAcpField acpField;
						if (self.Name != acpField.Name)
						{
							num = (short)509804546;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1277100032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
						num = (short)1264713754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						num = (short)492044289;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B4;
					IL_1A4:
					fieldMapInfo = global::SpecialFeatures.Security.FieldMapManager.GetFieldMapInfo(cpsFieldName);
					num = (short)1436614671;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E4:
					num = (short)258277404;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_470:
					trunkingSystem = (obj as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
					num = (short)1215823876;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_58E:
					global::AcpCommonLib.ConstraintManager.Resume();
					num = (short)1633943566;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_B4:
				result = true;
				num = (short)2061434900;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x0006EB94 File Offset: 0x0006CD94
		internal static bool IsValuePermitted(global::AcpCommonLib.IAcpField self)
		{
			switch (0)
			{
			case 0:
				goto IL_5C;
			}
			int num;
			short num2;
			bool flag;
			bool flag2;
			for (;;)
			{
				IL_0A:
				global::SpecialFeatures.Security.FieldMapInfo fieldMapInfo;
				string cpsFieldName;
				switch (num)
				{
				case 0:
					goto IL_2B8;
				case 1:
					if (fieldMapInfo is global::SpecialFeatures.Security.KeyFieldMapInfo)
					{
						num2 = (short)1128202255;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1608712200;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					cpsFieldName = self.Name;
					goto IL_19F;
				case 3:
					if (self == null)
					{
						num2 = (short)1064108039;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)308150274;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (global::AcpCommonLib.AppInfoManager.AppType == global::AcpCommonLib.ApplicationType.CPS)
					{
						num2 = (short)1775173643;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_350;
				case 5:
					num2 = (short)1566048257;
					if (num2 != 0)
					{
					}
					flag = global::SpecialFeatures.Security.ASKConstraints.e(self);
					num2 = (short)1372323840;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (global::SpecialFeatures.Security.ASKConstraints.c(self))
					{
						goto IL_10A;
					}
					goto IL_2B8;
				case 7:
					num2 = (short)1336934409;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (fieldMapInfo is global::SpecialFeatures.Security.RefKeyFieldMapInfo)
					{
						num2 = (short)1084030988;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_350;
				case 9:
					cpsFieldName = null;
					goto IL_19F;
				case 10:
					if (fieldMapInfo != null)
					{
						num2 = (short)1813118989;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_350;
				case 11:
					num2 = (short)2034630659;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
				{
					num2 = (short)1090125824;
					short num3 = num2;
					flag2 = global::SpecialFeatures.Security.ASKConstraints.a((global::AcpBusinessLayer.AcpRecRefField)self);
					num2 = (short)229376017;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 13:
				{
					num2 = (short)758872375;
					short num4 = num2;
					num2 = (short)872446263;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10A;
					default:
						num2 = (short)1280835584;
						if (num2 != 0)
						{
						}
						num2 = (short)1423900678;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 14:
					num2 = (short)1579286532;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					flag2 = global::SpecialFeatures.Security.ASKConstraints.d(self);
					num2 = (short)2111766546;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					if (!global::AcpSecurityLib.SecurityManager.IsSpecialKeyLoaded)
					{
						num2 = (short)175308814;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_350;
				case 17:
					goto IL_203;
				case 18:
					goto IL_313;
				}
				goto IL_5C;
				IL_10A:
				num2 = (short)1150156805;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_19F:
				fieldMapInfo = global::SpecialFeatures.Security.FieldMapManager.GetFieldMapInfo(cpsFieldName);
				num2 = (short)53346314;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2B8:
				num2 = (short)1000275969;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_203:
			IL_313:
			IL_350:
			return flag && flag2;
			IL_5C:
			flag2 = true;
			flag = true;
			num2 = (short)1568473104;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x0006EEF4 File Offset: 0x0006D0F4
		private static bool e(global::AcpCommonLib.IAcpField A_0)
		{
			short num = (short)167706624;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_86;
				}
				global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
				bool flag;
				for (;;)
				{
					IL_27:
					global::AcpCommonLib.IAcpField acpField;
					global::AcpASKLib.KeyType keyType;
					switch (num2)
					{
					case 0:
					{
						num = (short)195035136;
						short num3 = num;
						num = (short)1788018699;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)612171790;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (!global::SpecialFeatures.Security.ASKConstraints.c)
						{
							num = (short)644284437;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5C7;
					case 3:
						return true;
					case 4:
						if (acpField != null)
						{
							num = (short)1416495109;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_55C;
					case 5:
						num = (short)1257832456;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						IL_172:
						int value = ((global::AcpBusinessLayer.AcpField<int>)acpField).Value;
						global::AcpASKLib.AccessElementIDType elementID = global::SpecialFeatures.Security.FieldMapManager.GetElementID(acpFieldBase);
						bool bAskOnly = global::SpecialFeatures.Security.ASKConstraints.IsASKRequired(false);
						num = (short)1786314759;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						int value;
						global::AcpASKLib.AccessElementIDType elementID;
						bool bAskOnly;
						if (!global::AcpSecurityLib.SecurityManager.IsFieldEditable(elementID, keyType, value, bAskOnly))
						{
							num = (short)752746514;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_53C;
					}
					case 8:
						if (keyType != global::AcpASKLib.KeyType.UNDEFINED_KEY)
						{
							num = (short)1142751238;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_55C;
					case 9:
						goto IL_53C;
					case 10:
						goto IL_5C7;
					case 11:
						if (acpFieldBase.Valid)
						{
							num = (short)183697423;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5C7;
					case 12:
						if (global::SpecialFeatures.Security.ASKConstraints.c(acpFieldBase))
						{
							num = (short)1188167681;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 13:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_215;
							}
							int num4;
							int num5;
							for (;;)
							{
								IL_1C2:
								switch (num2)
								{
								case 0:
									goto IL_337;
								case 1:
									if (!global::SpecialFeatures.Security.ASKConstraints.e.ContainsKey(acpFieldBase))
									{
										num = (short)1232797711;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4D1;
								case 2:
									num = (short)2145452033;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::AcpBusinessLayer.AcpSimpleRangeField acpSimpleRangeField = (global::AcpBusinessLayer.AcpSimpleRangeField)acpFieldBase;
									num4 = global::System.Convert.ToInt32((string)acpSimpleRangeField.Converter.Convert(acpSimpleRangeField.Value, null, acpSimpleRangeField.ConverterParameterObject, null));
									num = (short)1276903441;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_337;
								case 5:
									num = (short)1630404616;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									if (acpFieldBase is global::AcpBusinessLayer.AcpNumericKeyField)
									{
										num = (short)315883525;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_32C;
								case 7:
									goto IL_4EA;
								case 8:
								{
									global::AcpBusinessLayer.AcpNumericKeyField acpNumericKeyField = (global::AcpBusinessLayer.AcpNumericKeyField)acpFieldBase;
									num4 = acpNumericKeyField.NumericValue;
									if (!int.TryParse(acpNumericKeyField.DefaultValue, out num5))
									{
										num = (short)25821196;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_337;
								}
								case 9:
									if (!flag)
									{
										num = (short)1120665602;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4D1;
								case 10:
									if (num4 != num5)
									{
										num = (short)1675493389;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4D1;
								case 11:
									goto IL_4D1;
								case 12:
									num5 = -1;
									num = (short)322174980;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									num = (short)752943122;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
								{
									global::AcpBusinessLayer.AcpField<int> acpField2 = (global::AcpBusinessLayer.AcpField<int>)acpFieldBase;
									num4 = acpField2.Value;
									num5 = acpField2.DefaultValue;
									num = (short)569835520;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 15:
									global::SpecialFeatures.Security.ASKConstraints.e.Add(acpFieldBase, acpFieldBase);
									num = (short)201326603;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									if (acpFieldBase is global::AcpBusinessLayer.AcpField<int>)
									{
										num = (short)36372494;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2036465670;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
									goto IL_2E1;
								case 18:
									if (acpFieldBase is global::AcpBusinessLayer.AcpSimpleRangeField)
									{
										num = (short)1332543491;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2E1;
								}
								goto IL_215;
								IL_2E1:
								int value;
								global::AcpASKLib.AccessElementIDType elementID;
								bool bAskOnly;
								flag = global::AcpSecurityLib.SecurityManager.IsRangeValueValid(elementID, keyType, value, num4, bAskOnly);
								num = (short)1454309385;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_337:
								num = (short)297598986;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4D1:
								num = (short)633602055;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_32C:
							throw new global::System.Exception(global::CommonResources.AppResources.Unsupported_Range_Field);
							IL_4EA:
							return flag;
							IL_215:
							num5 = 0;
							num4 = 0;
							num = (short)237109264;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1C2;
						}
						catch (global::System.Exception)
						{
							throw new global::System.Exception(global::CommonResources.AppResources.Unsupported_Range_Field);
						}
						goto IL_4FB;
					case 14:
						if (!acpFieldBase.Calling)
						{
							num = (short)452526080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5C7;
					case 15:
						num = (short)1410138114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (global::SpecialFeatures.Security.ASKConstraints.a(acpFieldBase))
						{
							num = (short)741474314;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 17:
						if (global::SpecialFeatures.Security.ASKConstraints.a(acpFieldBase))
						{
							num = (short)1051787273;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 18:
						num = (short)2081357841;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)1793392641;
						if (num != 0)
						{
						}
						if (acpFieldBase.DisableASKRangeValidation)
						{
							num = (short)1235419139;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4FB;
					case 20:
						return flag;
					case 21:
						num = (short)1576271888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_86;
					IL_55C:
					num = (short)796757298;
					short num6 = num;
					num = (short)1212058930;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_172;
					default:
						num = (short)281935872;
						if (num != 0)
						{
						}
						flag = false;
						num = (short)1732509716;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_4FB:
					num = (short)715063308;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_53C:
					num = (short)695533581;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5C7:
					bool flag2;
					global::SpecialFeatures.Security.FieldMapManager.GetKeyFieldInfo(acpFieldBase, out keyType, out acpField, out flag2);
					num = (short)1042612228;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_86:
				acpFieldBase = (A_0 as global::AcpBusinessLayer.AcpFieldBase);
				flag = true;
				num = (short)22609939;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x0006F67C File Offset: 0x0006D87C
		private static bool d(global::AcpCommonLib.IAcpField A_0)
		{
			short num = (short)2100756480;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7E;
				}
				bool flag;
				for (;;)
				{
					IL_27:
					global::AcpCommonLib.IAcpField acpField;
					global::AcpASKLib.KeyType keyType;
					global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
					bool flag2;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
					switch (num2)
					{
					case 0:
						num = (short)449118212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (global::SpecialFeatures.Security.ASKConstraints.c)
						{
							num = (short)1311309834;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 2:
					{
						int value = ((global::AcpBusinessLayer.AcpField<int>)acpField).Value;
						bool bAskOnly = global::SpecialFeatures.Security.ASKConstraints.IsASKRequired(false);
						flag = global::AcpSecurityLib.SecurityManager.IsSystemKeyLoaded(value, (byte)keyType, bAskOnly);
						num = (short)959643653;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_257;
					case 4:
						if (acpFieldBase.Valid)
						{
							num = (short)750518290;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_35F;
					case 5:
						if (flag && flag2)
						{
							num = (short)355270668;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13E;
					case 6:
						trunkingSystem.General.TrkSysGeneralSystemKeyPresent_A9241.Value = flag;
						num = (short)1984823299;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (acpField != null)
						{
							num = (short)1437663248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F5;
					case 8:
						num = (short)2048000013;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						return flag;
					case 10:
						num = (short)2060648449;
						if (num != 0)
						{
						}
						goto IL_35F;
					case 11:
						goto IL_27F;
					case 12:
					{
						int value;
						flag = global::SpecialFeatures.Security.RadioAccessValidator.IsHardwareAskLoaded(value, global::AcpSecurityLib.SecurityManager.LoadedASKs);
						num = (short)1376911379;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						if (acpFieldBase.Name == acpField.Name)
						{
							num = (short)948895746;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 14:
						if (keyType != global::AcpASKLib.KeyType.UNDEFINED_KEY)
						{
							num = (short)340852744;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F5;
					case 15:
						if (trunkingSystem != null)
						{
							num = (short)191954950;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_257;
					case 16:
						num = (short)1433796622;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (!acpFieldBase.Calling)
						{
							num = (short)649068544;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_35F;
					case 18:
						num = (short)1953431553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_13E;
					}
					goto IL_7E;
					IL_13E:
					trunkingSystem = (acpFieldBase.Parent.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
					num = (short)1357053967;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_257:
					acpFieldBase.Parent.Parent.CalculateEditability();
					num = (short)1183252491;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_35F:
					global::SpecialFeatures.Security.FieldMapManager.GetKeyFieldInfo(acpFieldBase, out keyType, out acpField, out flag2);
					num = (short)536936455;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_27F:
				return flag;
				IL_2F5:
				flag = false;
				goto IL_2F7;
				IL_7E:
				num = (short)942063628;
				short num3 = num;
				num = (short)2002960396;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_2F7:
					num = (short)318242825;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				default:
				{
					num = (short)1605697536;
					short num4 = num;
					num = (short)2082603008;
					if (num != 0)
					{
					}
					flag = true;
					global::AcpBusinessLayer.AcpFieldBase acpFieldBase = A_0 as global::AcpBusinessLayer.AcpFieldBase;
					num = (short)561774609;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
				break;
			}
			}
		}

		// Token: 0x06000780 RID: 1920 RVA: 0x0006FA9C File Offset: 0x0006DC9C
		private static bool a(global::AcpBusinessLayer.AcpRecRefField A_0)
		{
			short num = (short)55115776;
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
				bool result;
				for (;;)
				{
					IL_28:
					global::AcpCommonLib.IAcpField acpField;
					bool trkSysGeneralAskRequired;
					global::AcpASKLib.KeyType keyType;
					switch (num2)
					{
					case 0:
						goto IL_135;
					case 1:
						goto IL_228;
					case 2:
						if (acpField != null)
						{
							num = (short)1674510342;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 3:
					{
						int value = ((global::AcpBusinessLayer.AcpField<int>)acpField).Value;
						bool bAskOnly = global::SpecialFeatures.Security.ASKConstraints.IsASKRequired(trkSysGeneralAskRequired);
						result = global::AcpSecurityLib.SecurityManager.IsSystemKeyLoaded(value, (byte)keyType, bAskOnly);
						A_0.Parent.Parent.CalculateEditability();
						num = (short)485097476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_130;
					case 5:
						if (A_0.Valid)
						{
							num = (short)84344842;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_135;
					case 6:
						num = (short)773652481;
						if (num != 0)
						{
						}
						num = (short)1750597643;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)996868101;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						if (global::SpecialFeatures.Security.ASKConstraints.c)
						{
							num = (short)1053229056;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1273167872;
						short num3 = num;
						result = true;
						num = (short)1534263297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (!A_0.Calling)
						{
							num = (short)1548288007;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_135;
					case 10:
						num = (short)838926344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (keyType != global::AcpASKLib.KeyType.UNDEFINED_KEY)
						{
							num = (short)961937411;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					goto IL_5F;
					IL_135:
					global::SpecialFeatures.Security.FieldMapManager.GetKeyFieldInfo(A_0, out keyType, out acpField, out trkSysGeneralAskRequired);
					num = (short)722141186;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_130:
				return result;
				IL_5F:
				result = false;
				num = (short)1421148347;
				short num4 = num;
				num = (short)1228144827;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_228:
					break;
				default:
					num = (short)1543176192;
					if (num != 0)
					{
					}
					num = (short)152174601;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				return result;
			}
			}
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x0006FD54 File Offset: 0x0006DF54
		private static void a(global::AcpCommonLib.IAcpFeatureNode A_0, global::AcpCommonLib.IAcpField A_1, global::AcpASKLib.KeyType A_2, global::AcpASKLib.AccessRecord A_3, global::AcpCommonLib.UndoRedo.ContainerTask A_4)
		{
			int a_ = 16;
			short num = (short)1038155776;
			switch (num)
			{
			default:
			{
				num = (short)1597964289;
				if (num != 0)
				{
				}
				num = (short)1168048128;
				short num2 = num;
				global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator = A_0.FeatureSectionsCollection.GetEnumerator();
				try
				{
					num = (short)2020868101;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::AcpBusinessLayer.FeatureSection featureSection;
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator3;
						switch (num3)
						{
						case 0:
							goto IL_7B4;
						case 1:
							try
							{
								num = (short)1872429058;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)2022506497;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::SpecialFeatures.Security.ASKConstraints.a(enumerator2.Current, A_1, A_2, A_3, A_4);
										num = (short)1001652228;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										num = (short)1873674243;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_63D;
										}
										continue;
									case 3:
										goto IL_6B4;
									}
									IL_667:
									num = (short)891551744;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_63D:
									goto IL_667;
								}
								IL_6B4:;
							}
							finally
							{
								num = (short)165871618;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										goto IL_708;
									case 1:
									{
										num = (short)275562336;
										short num4 = num;
										num = (short)708231008;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_708;
										default:
											goto IL_759;
										}
										break;
									}
									case 2:
										switch (0)
										{
										case 0:
											goto IL_6EB;
										}
										continue;
									}
									IL_6EB:
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
									if (enumerator2 != null)
									{
										num = (short)1889927168;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_771;
									IL_708:
									enumerator2.Dispose();
									num = (short)223150081;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_759:
								num = (short)2066087936;
								if (num != 0)
								{
								}
								IL_771:;
							}
							goto IL_772;
						case 2:
							if (featureSection.HasEmbeddedRecset)
							{
								num = (short)1838743558;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_772;
						case 3:
							num = (short)2013134848;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (!enumerator.MoveNext())
							{
								num = (short)1299841027;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							featureSection = (global::AcpBusinessLayer.FeatureSection)enumerator.Current;
							num = (short)1544880130;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							switch (0)
							{
							case 0:
								goto IL_CC;
							}
							continue;
						case 6:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = ((global::AcpBusinessLayer.Recordset)featureSection.EmbeddedRecset).GetEnumerator();
							num = (short)1222770689;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							try
							{
								num = (short)1562837015;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
									string text;
									global::SpecialFeatures.Security.FieldMapInfo fieldMapInfo;
									switch (num3)
									{
									case 0:
										if (A_1 == null)
										{
											num = (short)345964566;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)1196687362;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										global::SpecialFeatures.Security.ASKConstraints.a(acpFieldBase, A_4);
										num = (short)255000586;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										text = A_1.Name;
										goto IL_37E;
									case 3:
										if (A_3 != null)
										{
											num = (short)889258000;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::SpecialFeatures.Security.ASKConstraints.a(acpFieldBase, A_4);
										num = (short)1107296280;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										if (fieldMapInfo != null)
										{
											num = (short)1032781836;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									case 6:
										if (A_2 != global::AcpASKLib.KeyType.ADVANCED_WACN_KEY)
										{
											num = (short)385810441;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									case 7:
										num = (short)365363219;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
										num = (short)2014380035;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 9:
										goto IL_289;
									case 11:
										text = null;
										goto IL_37E;
									case 12:
										num = (short)1490616320;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 13:
										num = (short)79888390;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 14:
										if (!(fieldMapInfo is global::SpecialFeatures.Security.RefKeyFieldMapInfo))
										{
											num = (short)76677128;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									case 15:
									{
										global::AcpASKLib.AccessElementIDType id;
										if (!A_3.IsAccessElementEnabled(id))
										{
											num = (short)1650393089;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										acpFieldBase.Calling = true;
										acpFieldBase.CalculateValidity();
										acpFieldBase.Calling = false;
										num = (short)1974796293;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 16:
									{
										global::AcpASKLib.AccessElementIDType id = fieldMapInfo.ID;
										num = (short)916979727;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 17:
										if (acpFieldBase != null)
										{
											num = (short)854392857;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									case 18:
										if (acpFieldBase.Name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("잒ﲖ쪘\ud89e쒠춢삤햦좨잪삮잰횲잴횶\udeb8\udeba욾뇀ꛂ髄蛆ﻈﳊ﷎", a_))
										{
											num = (short)1899364365;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_289;
									case 19:
										goto IL_552;
									case 20:
										num = (short)9043982;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 21:
										if (!enumerator3.MoveNext())
										{
											num = (short)1710096391;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										acpFieldBase = (global::AcpBusinessLayer.AcpFieldBase)enumerator3.Current;
										num = (short)1372454929;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 22:
										num = (short)747634699;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 23:
										switch (0)
										{
										case 0:
											goto IL_1D3;
										}
										continue;
									case 25:
										num = (short)2137653266;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_1D8:
									num = (short)784203797;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_1D3:
									goto IL_1D8;
									IL_289:
									fieldMapInfo = global::SpecialFeatures.Security.FieldMapManager.GetFieldMapInfo(acpFieldBase.Name);
									num = (short)857145348;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_37E:
									if (!(text != acpFieldBase.Name))
									{
										goto IL_1D8;
									}
									num = (short)1374879764;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_552:;
							}
							finally
							{
								num = (short)2021654530;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										enumerator3.Dispose();
										num = (short)1689976833;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_5BD;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_587;
										}
										continue;
									}
									IL_587:
									if (enumerator3 == null)
									{
										break;
									}
									num = (short)1038221312;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_5BD:;
							}
							break;
						}
						IL_5C0:
						num = (short)853278724;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_CC:
						goto IL_5C0;
						IL_772:
						enumerator3 = featureSection.FieldsCollection.GetEnumerator();
						num = (short)810156039;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_7B4:;
				}
				finally
				{
					num = (short)1451556866;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1969815553;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_81D;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_7E8;
							}
							continue;
						}
						IL_7E8:
						if (enumerator == null)
						{
							break;
						}
						num = (short)660275200;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_81D:;
				}
				return;
			}
			}
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x000705D0 File Offset: 0x0006E7D0
		private static void c(global::AcpCommonLib.IAcpFeatureSection A_0, global::AcpCommonLib.UndoRedo.ContainerTask A_1)
		{
			short num = (short)765591552;
			switch (num)
			{
			default:
			{
				num = (short)855441416;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1067319300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::AcpASKLib.KeyType trunkingKeyType = global::SpecialFeatures.Security.FieldMapManager.GetTrunkingKeyType(A_0.Parent);
						global::AcpCommonLib.IAcpField trunkingSysIDField = global::SpecialFeatures.Security.FieldMapManager.GetTrunkingSysIDField(A_0.Parent);
						num = (short)1037107207;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_200;
					case 3:
					{
						num = (short)813236224;
						short num3 = num;
						global::AcpASKLib.KeyType trunkingKeyType;
						if (trunkingKeyType != global::AcpASKLib.KeyType.UNDEFINED_KEY)
						{
							num = (short)794820614;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 4:
						if (global::AcpCommonLib.AppInfoManager.AppType == global::AcpCommonLib.ApplicationType.CPS)
						{
							num = (short)61210625;
							if (num != 0)
							{
							}
							num = (short)1072758785;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						try
						{
							num = (short)315490308;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)74186753;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_143;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)720764928;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
									global::AcpASKLib.KeyType trunkingKeyType;
									global::AcpCommonLib.IAcpField trunkingSysIDField;
									global::AcpASKLib.AccessRecord systemAccessLevel;
									global::SpecialFeatures.Security.ASKConstraints.a(featureNode, trunkingSysIDField, trunkingKeyType, systemAccessLevel, A_1);
									featureNode.CalculateValidity();
									num = (short)639434755;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_C7;
									}
									continue;
								}
								IL_C9:
								num = (short)1610153986;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_C7:
								goto IL_C9;
							}
							IL_143:
							return;
						}
						finally
						{
							num = (short)1202520066;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_1FD;
								case 1:
									enumerator.Dispose();
									num = (short)1924005888;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									num = (short)1519120696;
									short num4 = num;
									num = (short)1591800120;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
										num = (short)289669120;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_1C7;
										}
										continue;
									}
									break;
								}
								}
								IL_1C7:
								if (enumerator == null)
								{
									break;
								}
								num = (short)874250241;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1FD:;
						}
						goto IL_200;
					case 6:
					{
						global::AcpASKLib.KeyType trunkingKeyType;
						global::AcpCommonLib.IAcpField trunkingSysIDField;
						global::AcpASKLib.AccessRecord systemAccessLevel = global::AcpSecurityLib.SecurityManager.GetSystemAccessLevel(((global::AcpBusinessLayer.AcpField<int>)trunkingSysIDField).Value, trunkingKeyType);
						global::AcpCommonLib.IAcpFeatureNode parent = trunkingSysIDField.Parent.Parent;
						global::SpecialFeatures.Security.ASKConstraints.a(parent, trunkingSysIDField, trunkingKeyType, systemAccessLevel, A_1);
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = ((global::AcpBusinessLayer.FeatureNode)parent).ReferencingNodes.GetEnumerator();
						num = (short)610009093;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::AcpCommonLib.IAcpField trunkingSysIDField;
						if (trunkingSysIDField != null)
						{
							num = (short)230359042;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 8:
						switch (0)
						{
						case 0:
							goto IL_69;
						}
						continue;
					}
					IL_69:
					if (!global::AcpSecurityLib.SecurityManager.IsSpecialKeyLoaded)
					{
						num = (short)827260928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_200:
					num = (short)1740177411;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06000783 RID: 1923 RVA: 0x00070960 File Offset: 0x0006EB60
		private static void d(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1649672199;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				global::SpecialFeatures.Security.Feature feature;
				switch (num2)
				{
				case 0:
					goto IL_3E1;
				case 1:
				{
					num = (short)853344256;
					short num3 = num;
					num = (short)1290797059;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					try
					{
						num = (short)865337348;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								if (!enumerator.MoveNext())
								{
									num = (short)535625731;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::SpecialFeatures.Security.ASKConstraints.d(enumerator.Current);
								num = (short)1462108162;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_20F;
							case 3:
								num = (short)527171585;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_1A2;
								}
								continue;
							}
							IL_1C5:
							num = (short)235208704;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1A2:
							goto IL_1C5;
						}
						IL_20F:
						return;
					}
					finally
					{
						num = (short)2084306946;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_2C1;
							case 1:
								enumerator.Dispose();
								num = (short)6160384;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
							{
								num = (short)1871275951;
								short num4 = num;
								num = (short)80177071;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									continue;
								default:
									num = (short)537067520;
									if (num != 0)
									{
									}
									switch (0)
									{
									case 0:
										goto IL_28E;
									}
									continue;
								}
								break;
							}
							}
							IL_28E:
							if (enumerator == null)
							{
								break;
							}
							num = (short)304873473;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_2C1:;
					}
					goto Block_5;
				case 3:
					if (A_0 != null)
					{
						num = (short)1012596742;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					goto IL_2C4;
				case 5:
					if (feature != null)
					{
						num = (short)1903165440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
					num = (short)862846977;
					if (num != 0)
					{
					}
					feature = global::SpecialFeatures.Security.FieldMapManager.GetFeature((global::SpecialFeatures.Security.CpsFeatureID)A_0.Parent.RecsetId);
					num = (short)2057568261;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				}
				IL_44:
				if (!global::AcpCommonLib.ConstraintManager.Suspended)
				{
					num = (short)1478885377;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				Block_5:
				global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Security.FieldMapInfo> enumerator2;
				try
				{
					IL_2C4:
					num = (short)58327044;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)2141978625;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_375;
						case 2:
							if (!enumerator2.MoveNext())
							{
								num = (short)39190528;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::SpecialFeatures.Security.ASKConstraints.a(enumerator2.Current.CPSFieldName, A_0);
							num = (short)931266563;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_2FD;
							}
							continue;
						}
						IL_2FF:
						num = (short)401735682;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2FD:
						goto IL_2FF;
					}
					IL_375:
					goto IL_8D;
				}
				finally
				{
					num = (short)2113863682;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_3DE;
						case 1:
							enumerator2.Dispose();
							num = (short)1723006976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_3AA;
							}
							continue;
						}
						IL_3AA:
						if (enumerator2 == null)
						{
							break;
						}
						num = (short)544604161;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_3DE:;
				}
				goto IL_3E1;
				IL_8D:
				enumerator = ((global::AcpBusinessLayer.FeatureNode)A_0).ReferencingNodes.GetEnumerator();
				num = (short)1883504642;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3E1:
				enumerator2 = feature.FieldMap.GetEnumerator();
				num = (short)603848708;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000784 RID: 1924 RVA: 0x00070D94 File Offset: 0x0006EF94
		internal static void SystemTypeValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1891565569;
			if (num != 0)
			{
			}
			num = (short)1817642192;
			short num2 = num;
			num = (short)1080493264;
			switch (num2 == num)
			{
			default:
			{
				num = (short)389545984;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1885863936;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Security.ASKConstraints.b(self, task);
		}

		// Token: 0x06000785 RID: 1925 RVA: 0x00070E44 File Offset: 0x0006F044
		internal static void CoverageTypeValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)458449750;
			short num2 = num;
			num = (short)1031299926;
			switch (num2 == num)
			{
			}
			num = (short)1246560256;
			short num3 = num;
			num = (short)873857024;
			if (num != 0)
			{
			}
			num = (short)1914961921;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Security.ASKConstraints.b(self, task);
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x00070EF4 File Offset: 0x0006F0F4
		private static void b(global::AcpCommonLib.IAcpFeatureSection A_0, global::AcpCommonLib.UndoRedo.ContainerTask A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general;
			int num4;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)323354626;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_8F;
				case 2:
				{
					num2 = (short)1666676087;
					short num3 = num2;
					num2 = (short)616134007;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_8F;
					default:
						num2 = (short)1070989313;
						if (num2 != 0)
						{
						}
						num2 = (short)1067450368;
						if (num2 != 0)
						{
						}
						if (global::SpecialFeatures.Security.FieldMapManager.GetTrunkingKeyType(A_0.Parent) == global::AcpASKLib.KeyType.ADVANCED_WACN_KEY)
						{
							num2 = (short)1370423304;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_B1;
					}
					break;
				}
				case 3:
					num2 = (short)438173697;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					A_1.AddTask(new global::AcpBusinessLayer.UndoRedo.SetValueTask(general.TrkSysGeneralSystemKeyType_A38853, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.LOVs.TrkSysGeneralSystemKeyType_A38853LovStrs[num4]));
					global::SpecialFeatures.Security.ASKConstraints.c(A_0, A_1);
					num2 = (short)655032325;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					return;
				case 6:
					goto IL_B1;
				case 7:
					if (general.TrkSysGeneralSystemKeyType_A38853.Value != num4)
					{
						num2 = (short)1388052483;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 8:
					num4 = 1;
					num2 = (short)1954807814;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (general != null)
					{
						num2 = (short)1660747776;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_38;
				IL_8F:
				if (A_1 != null)
				{
					num2 = (short)1643708420;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				break;
				IL_B1:
				num2 = (short)174850048;
				short num5 = num2;
				num2 = (short)100532231;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_38:
			num4 = 0;
			general = (A_0 as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General);
			num2 = (short)2074345481;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x0007112C File Offset: 0x0006F32C
		private static bool c(global::AcpCommonLib.IAcpField A_0)
		{
			short num = (short)1107218110;
			short num2 = num;
			num = (short)1127468734;
			switch (num2 == num)
			{
			}
			num = (short)1996947456;
			short num3 = num;
			num = (short)1258422273;
			if (num != 0)
			{
			}
			num = (short)2048196608;
			if (num != 0)
			{
			}
			return global::AcpSecurityLib.SecurityManager.IsRangeField(global::SpecialFeatures.Security.FieldMapManager.GetElementID(A_0));
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x000711E0 File Offset: 0x0006F3E0
		private static void a(object A_0, global::AcpASKLib.SystemKeyLoadedEventArgs A_1)
		{
			short num = (short)575639944;
			short num2 = num;
			num = (short)1950192008;
			switch (num2 == num)
			{
			}
			num = (short)455016448;
			short num3 = num;
			num = (short)2039676928;
			if (num != 0)
			{
			}
			num = (short)161218561;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Security.ASKConstraints.e();
			global::SpecialFeatures.Security.ASKConstraints.f();
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x00071294 File Offset: 0x0006F494
		private static void f()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset trunkingSystemRecset;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_2CB;
				case 1:
					return;
				case 2:
					if (trunkingSystemRecset == null)
					{
						num2 = (short)1805778945;
						if (num2 != 0)
						{
						}
						num2 = (short)252968961;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2AC;
				}
				goto IL_1C;
			}
			return;
			IL_2AC:
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = trunkingSystemRecset.GetEnumerator();
			goto IL_2B3;
			IL_2CB:
			try
			{
				num2 = (short)86114312;
				int num = (int)((global::System.IntPtr)num2);
				for (;;)
				{
					switch (num)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)enumerator.Current;
						if (trunkingSystem == null)
						{
							num2 = (short)238878723;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general = trunkingSystem.General;
						if (general == null)
						{
							num2 = (short)248119303;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						global::AcpBusinessLayer.AcpField<bool> trkSysGeneralAskRequired_A = general.TrkSysGeneralAskRequired_A44909;
						if (trkSysGeneralAskRequired_A == null)
						{
							num2 = (short)1962016770;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						trkSysGeneralAskRequired_A.CalculateEditability();
						num2 = (short)1205403649;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 4:
						num2 = (short)2132082693;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						goto IL_240;
					case 6:
						if (!enumerator.MoveNext())
						{
							num2 = (short)1731526660;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1748238336;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 8:
						switch (0)
						{
						case 0:
							goto IL_14A;
						}
						continue;
					}
					IL_19B:
					num2 = (short)612302854;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_14A:
					goto IL_19B;
				}
				IL_240:
				return;
			}
			finally
			{
				num2 = (short)888799234;
				int num = (int)((global::System.IntPtr)num2);
				for (;;)
				{
					switch (num)
					{
					case 0:
						goto IL_2A9;
					case 1:
						enumerator.Dispose();
						num2 = (short)1341325312;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_275;
						}
						continue;
					}
					IL_275:
					if (enumerator == null)
					{
						break;
					}
					num2 = (short)1507852289;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_2A9:;
			}
			goto IL_2AC;
			IL_1C:
			num2 = (short)1175902346;
			short num3 = num2;
			num2 = (short)2059065482;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_2B3:
				num2 = (short)1969225728;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1392508928;
				short num4 = num2;
				num2 = (short)2146631680;
				if (num2 != 0)
				{
				}
				trunkingSystemRecset = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset)global::AcpCommonLib.FeatureManager.GetFeature(2064);
				num2 = (short)129368066;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600078A RID: 1930 RVA: 0x00071590 File Offset: 0x0006F790
		private static void e()
		{
			short num = (short)1900609536;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)300220416;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1198981120;
					short num3 = num;
					global::System.Collections.IEnumerator enumerator3;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_7E;
						}
						continue;
					case 1:
						try
						{
							num = (short)467533826;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Security.FieldMapInfo> enumerator;
								global::SpecialFeatures.Security.Feature feature2;
								switch (num2)
								{
								case 0:
									goto IL_40C;
								case 1:
									num = (short)86638592;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_E4;
									}
									continue;
								case 3:
								{
									global::AcpCommonLib.IAcpRecordset feature;
									if (feature != null)
									{
										num = (short)571277318;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									try
									{
										num = (short)409010177;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												if (!enumerator.MoveNext())
												{
													num = (short)390922244;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::SpecialFeatures.Security.FieldMapInfo fieldMapInfo = enumerator.Current;
												global::AcpCommonLib.IAcpRecordset feature;
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = ((global::AcpBusinessLayer.Recordset)feature).GetEnumerator();
												num = (short)6946818;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 1:
												switch (0)
												{
												case 0:
													goto IL_1AE;
												}
												continue;
											case 2:
												try
												{
													num = (short)2124873729;
													num2 = (int)((global::System.IntPtr)num);
													for (;;)
													{
														switch (num2)
														{
														case 1:
															switch (0)
															{
															case 0:
																goto IL_24F;
															}
															continue;
														case 2:
															num = (short)1762787331;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 3:
															goto IL_2CC;
														case 4:
														{
															global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
															if (!enumerator2.MoveNext())
															{
																num = (short)2058027010;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															global::AcpCommonLib.IAcpFeatureNode a_ = enumerator2.Current;
															global::SpecialFeatures.Security.FieldMapInfo fieldMapInfo;
															global::SpecialFeatures.Security.ASKConstraints.a(fieldMapInfo.CPSFieldName, a_);
															num = (short)1189937152;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														}
														IL_27F:
														num = (short)602144772;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_24F:
														goto IL_27F;
													}
													IL_2CC:
													break;
												}
												finally
												{
													num = (short)1125449728;
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
																goto IL_303;
															}
															continue;
														case 1:
															goto IL_33C;
														case 2:
															enumerator2.Dispose();
															num = (short)1556807681;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														IL_303:
														if (enumerator2 == null)
														{
															break;
														}
														num = (short)2023817218;
														num2 = (int)((global::System.IntPtr)num);
													}
													IL_33C:;
												}
												goto IL_33F;
											case 3:
												goto IL_358;
											case 4:
												goto IL_33F;
											}
											IL_1B0:
											num = (short)970194944;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_1AE:
											goto IL_1B0;
											IL_33F:
											num = (short)395771907;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_358:
										break;
									}
									finally
									{
										num = (short)1560346624;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_390;
												}
												continue;
											case 1:
												goto IL_3C6;
											case 2:
												enumerator.Dispose();
												num = (short)603324417;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_390:
											if (enumerator == null)
											{
												break;
											}
											num = (short)850591746;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_3C6:;
									}
									goto IL_3C9;
								case 5:
								{
									if (!enumerator3.MoveNext())
									{
										num = (short)1316356097;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									feature2 = (global::SpecialFeatures.Security.Feature)enumerator3.Current;
									global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature((int)feature2.FeatureID);
									num = (short)1142816771;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_3C9;
								}
								IL_133:
								num = (short)1117192197;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E4:
								goto IL_133;
								IL_3C9:
								enumerator = feature2.FieldMap.GetEnumerator();
								num = (short)1303117828;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_40C:
							goto IL_52A;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_42E;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_41B:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)571277314;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4D6;
								case 1:
									goto IL_4D4;
								case 2:
								{
									num = (short)706902663;
									short num4 = num;
									num = (short)1563392647;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)1171521536;
										if (num != 0)
										{
										}
										disposable.Dispose();
										num = (short)513081345;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								goto IL_42E;
							}
							IL_4D4:
							IL_4D6:
							goto EndFinally_17;
							IL_42E:
							disposable = (enumerator3 as global::System.IDisposable);
							num = (short)180092928;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_41B;
							EndFinally_17:;
						}
						goto IL_4D7;
						IL_52A:
						global::SpecialFeatures.Security.ASKConstraints.d();
						global::SpecialFeatures.Security.ASKConstraints.c();
						global::SpecialFeatures.Security.ASKConstraints.b();
						num = (short)1896480770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return;
					case 3:
						goto IL_4D7;
					}
					IL_7E:
					if (!global::AcpCommonLib.ConstraintManager.Suspended)
					{
						num = (short)207486979;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_4D7:
					enumerator3 = global::SpecialFeatures.Security.FieldMapManager.Features.GetEnumerator();
					num = (short)41943041;
					if (num != 0)
					{
					}
					num = (short)250740737;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x00071B3C File Offset: 0x0006FD3C
		private static void a(string A_0, global::AcpCommonLib.IAcpFeatureNode A_1)
		{
			short num = (short)1481506816;
			short num2 = num;
			num = (short)773193728;
			switch (num)
			{
			default:
			{
				num = (short)1757085697;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator = A_1.FeatureSectionsCollection.GetEnumerator();
				try
				{
					num = (short)991952899;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator3;
						global::AcpBusinessLayer.FeatureSection featureSection;
						switch (num3)
						{
						case 0:
							try
							{
								num = (short)842072065;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)850460676;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.IAcpFeatureNode a_ = enumerator2.Current;
										global::SpecialFeatures.Security.ASKConstraints.a(A_0, a_);
										num = (short)1338114050;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										switch (0)
										{
										case 0:
											goto IL_448;
										}
										continue;
									case 3:
										goto IL_4BC;
									case 4:
										num = (short)1990524931;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_44A:
									num = (short)916062208;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_448:
									goto IL_44A;
								}
								IL_4BC:;
							}
							finally
							{
								num = (short)1861287936;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_4F0;
										}
										continue;
									case 1:
										goto IL_526;
									case 2:
										enumerator2.Dispose();
										num = (short)1191837697;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_4F0:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)500367362;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_526:;
							}
							goto IL_529;
						case 1:
							try
							{
								num = (short)844824586;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::AcpCommonLib.IAcpField acpField;
									switch (num3)
									{
									case 0:
										if (!global::SpecialFeatures.Security.ASKConstraints.b(acpField))
										{
											num = (short)802291713;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_321;
									case 1:
										goto IL_2AE;
									case 2:
										num = (short)2103640064;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										if (global::SpecialFeatures.Security.ASKConstraints.c)
										{
											num = (short)1716649988;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_345;
									case 4:
										goto IL_321;
									case 5:
										goto IL_35D;
									case 6:
										num = (short)472121347;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
										goto IL_345;
									case 8:
										if (!enumerator3.MoveNext())
										{
											num = (short)1572536327;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										acpField = enumerator3.Current;
										num = (short)1005584395;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 9:
										goto IL_340;
									case 10:
										switch (0)
										{
										case 0:
											goto IL_19C;
										}
										continue;
									case 11:
										if (acpField.Name == A_0)
										{
											num = (short)1777795086;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									case 12:
										if (!global::AcpSecurityLib.SecurityManager.IsSpecialKeyLoaded)
										{
											num = (short)1214316550;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_321;
									case 13:
										if (!acpField.Valid)
										{
											num = (short)557711362;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_2AE;
									case 14:
										acpField.CalculateEditability();
										num = (short)1563426829;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_19E:
									num = (short)1398407176;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_19C:
									goto IL_19E;
									IL_2AE:
									num = (short)846135308;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_321:
									acpField.CalculateValidity();
									num = (short)236060681;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_345:
									num = (short)348389381;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_340:
								IL_35D:;
							}
							finally
							{
								num = (short)83492864;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_391;
										}
										continue;
									case 1:
										goto IL_3C9;
									case 2:
										enumerator3.Dispose();
										num = (short)1821442049;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_391:
									if (enumerator3 == null)
									{
										break;
									}
									num = (short)2071199746;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_3C9:;
							}
							break;
						case 2:
							num = (short)1104674822;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_C1;
							}
							continue;
						case 4:
							if (featureSection.HasEmbeddedRecset)
							{
								num = (short)1223360519;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_529;
						case 5:
							if (!enumerator.MoveNext())
							{
								num = (short)669908994;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							featureSection = (global::AcpBusinessLayer.FeatureSection)enumerator.Current;
							num = (short)792854532;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_56C;
						case 7:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = ((global::AcpBusinessLayer.Recordset)featureSection.EmbeddedRecset).GetEnumerator();
							num = (short)835125248;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_3CC:
						num = (short)555679749;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_C1:
						goto IL_3CC;
						IL_529:
						enumerator3 = featureSection.FieldsCollection.GetEnumerator();
						num = (short)1205993473;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_56C:;
				}
				finally
				{
					num = (short)1646395392;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							num = (short)779675929;
							short num4 = num;
							num = (short)588704025;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							default:
								num = (short)62128128;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_5EF;
								}
								continue;
							}
							break;
						}
						case 1:
							goto IL_627;
						case 2:
							enumerator.Dispose();
							num = (short)2040528897;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_5EF:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1910898690;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_627:;
				}
				return;
			}
			}
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x000721C0 File Offset: 0x000703C0
		private static void d()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (radioWide != null)
					{
						num2 = (short)1364721666;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					return;
				case 2:
				{
					num2 = (short)643325610;
					short num3 = num2;
					num2 = (short)980967082;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1103101953;
						if (num2 != 0)
						{
						}
						num2 = (short)211353600;
						if (num2 != 0)
						{
						}
						radioWide.General.RadWideGeneralASKRequired_A37152.CalculateEditability();
						num2 = (short)604700673;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num2 = (short)667222016;
			short num4 = num2;
			num2 = (short)1655373824;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x000722F8 File Offset: 0x000704F8
		private static void c()
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			for (;;)
			{
				IL_0A:
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWideRecset conventionalWideRecset;
				switch (num)
				{
				case 0:
					if (conventionalWideRecset != null)
					{
						num2 = (short)2015690755;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					if (radioWide != null)
					{
						num2 = (short)899088386;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_10E;
				case 2:
				{
					num2 = (short)1383097540;
					short num3 = num2;
					num2 = (short)1679189188;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_11E;
					default:
						num2 = (short)1623654401;
						if (num2 != 0)
						{
						}
						num2 = (short)101711872;
						if (num2 != 0)
						{
						}
						radioWide.UserInformationAndPasswords.RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.CalculateEditability();
						radioWide.UserInformationAndPasswords.RadWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395.CalculateEditability();
						num2 = (short)1276444676;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					((global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWide)conventionalWideRecset[0]).ASTROData.CnvWideConventionalCustomerID_41558.CalculateEditability();
					((global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWide)conventionalWideRecset[0]).ASTROData.CnvWideConventionalCustomerID_41558.CalculateApplicability();
					((global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWide)conventionalWideRecset[0]).ASTROData.CnvWideConventionalCustomerID_41558.CalculateValidity();
					num2 = (short)1359478789;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_10E;
				case 5:
					return;
				}
				goto IL_28;
				IL_11E:
				num2 = (short)1103495168;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_10E:
				conventionalWideRecset = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWideRecset)global::AcpCommonLib.FeatureManager.GetFeature(2024);
				goto IL_11E;
			}
			return;
			IL_28:
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num2 = (short)636026880;
			short num4 = num2;
			num2 = (short)1515847681;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x00072510 File Offset: 0x00070710
		private static void b()
		{
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			short num;
			global::AcpCommonLib.IAcpRecordset feature;
			for (;;)
			{
				IL_0A:
				num = (short)305725440;
				short num2 = num;
				int num3;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				switch (num3)
				{
				case 0:
					num = (short)1172439042;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_B9;
				case 2:
					if (feature.Count != 0)
					{
						num = (short)239861763;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
					goto IL_252;
				case 4:
					num = (short)739704833;
					if (num != 0)
					{
					}
					try
					{
						num = (short)765591554;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_1E4;
							case 1:
								num = (short)195035136;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_11D;
								}
								continue;
							case 3:
							{
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
								if (!trunkingSystem.Features.TrkSysFeaturesRadioInhibit_A8833.Valid)
								{
									num = (short)544997382;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1770258433;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
								num = (short)1349648387;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
							{
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
								trunkingSystem.Features.TrkSysFeaturesRadioInhibit_A8833.CalculateValidity();
								num = (short)481558532;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_16A:
							num = (short)2032599045;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_11D:
							goto IL_16A;
						}
						IL_1E4:
						return;
					}
					finally
					{
						num = (short)38535168;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_21A;
								}
								continue;
							case 1:
								goto IL_24F;
							case 2:
								enumerator.Dispose();
								num = (short)471793665;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_21A:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1148387330;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_24F:;
					}
					goto IL_252;
				}
				break;
				IL_252:
				enumerator = ((global::AcpBusinessLayer.Recordset)feature).GetEnumerator();
				num = (short)461832196;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_4D:
			feature = global::AcpCommonLib.FeatureManager.GetFeature(2064);
			num = (short)1315244414;
			short num4 = num;
			num = (short)477825406;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_B9:
				if (feature != null)
				{
					num = (short)435552256;
					int num3 = (int)((global::System.IntPtr)num);
					goto IL_0A;
				}
				break;
			default:
			{
				num = (short)989528064;
				if (num != 0)
				{
				}
				num = (short)42795009;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x0007281C File Offset: 0x00070A1C
		private static bool e(global::AcpCommonLib.IAcpFeatureSection A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_6D;
			}
			short num;
			int num3;
			bool result;
			for (;;)
			{
				IL_0A:
				num = (short)456392704;
				short num2 = num;
				switch (num3)
				{
				case 0:
					goto IL_1A9;
				case 1:
					return result;
				case 2:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWideRecset conventionalWideRecset;
					if (conventionalWideRecset != null)
					{
						num = (short)1255866375;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				}
				case 3:
					if (global::AcpCommonLib.AppInfoManager.AppType == global::AcpCommonLib.ApplicationType.CPS)
					{
						num = (short)2098528266;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 4:
					if (global::AcpCommonLib.AppInfoManager.AppType != global::AcpCommonLib.ApplicationType.DEPOT)
					{
						goto IL_8E;
					}
					goto IL_190;
				case 5:
					num = (short)613220361;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					return result;
				case 7:
					num = (short)327024648;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWideRecset conventionalWideRecset;
					if (!((global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWide)conventionalWideRecset[0]).ASTROData.CnvWideConventionalCustomerID_41558.Editable)
					{
						num = (short)629211147;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = global::SpecialFeatures.Security.RadioAccessValidator.CheckIfCustomerIDIsInACK(((global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWide)conventionalWideRecset[0]).ASTROData.CnvWideConventionalCustomerID_41558.Value);
					num = (short)138280961;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					if (global::AcpCommonLib.AppInfoManager.AppType == global::AcpCommonLib.ApplicationType.LABTOOL)
					{
						num = (short)811073548;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)753532931;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWideRecset conventionalWideRecset = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWideRecset)global::AcpCommonLib.FeatureManager.GetFeature(2024);
					num = (short)667484162;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 11:
				{
					num = (short)1683084471;
					short num4 = num;
					num = (short)1102959799;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_8E;
					default:
						num = (short)1827733504;
						if (num != 0)
						{
						}
						result = true;
						num = (short)24641542;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 12:
					goto IL_190;
				}
				goto IL_6D;
				IL_8E:
				num = (short)1933049861;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_190:
				result = true;
				num = (short)393150464;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_1A9:
			num = (short)857538561;
			if (num != 0)
			{
			}
			return result;
			IL_6D:
			result = false;
			num = (short)719060996;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00072AD0 File Offset: 0x00070CD0
		private static void c(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)1832714240;
			switch (num)
			{
			default:
			{
				num = (short)447807488;
				short num2 = num;
				global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator = A_0.FeatureSectionsCollection.GetEnumerator();
				try
				{
					num = (short)1557331969;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::AcpBusinessLayer.FeatureSection featureSection;
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator3;
						switch (num3)
						{
						case 0:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = ((global::AcpBusinessLayer.Recordset)featureSection.EmbeddedRecset).GetEnumerator();
							num = (short)1306984454;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_9B;
							}
							continue;
						case 2:
							if (featureSection.HasEmbeddedRecset)
							{
								num = (short)622133248;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_56D;
						case 3:
							goto IL_5AE;
						case 4:
							if (!enumerator.MoveNext())
							{
								num = (short)1509031941;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							featureSection = (global::AcpBusinessLayer.FeatureSection)enumerator.Current;
							num = (short)1628635138;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							num = (short)1741029379;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							try
							{
								num = (short)288817152;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_48B;
										}
										continue;
									case 1:
										goto IL_4FC;
									case 2:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)147193860;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::SpecialFeatures.Security.ASKConstraints.c(enumerator2.Current);
										num = (short)1144913923;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										num = (short)1747320833;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_4B0:
									num = (short)1138491394;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_48B:
									goto IL_4B0;
								}
								IL_4FC:;
							}
							finally
							{
								num = (short)1979252737;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
									switch (num3)
									{
									case 0:
										enumerator2.Dispose();
										num = (short)556269570;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_532;
										}
										continue;
									case 2:
										goto IL_56A;
									}
									IL_532:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)1777401856;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_56A:;
							}
							goto IL_56D;
						case 7:
							try
							{
								num = (short)2023620614;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										num = (short)1346633740;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_24D;
									case 3:
									{
										global::AcpCommonLib.IAcpField acpField;
										if (acpField.Protected)
										{
											num = (short)80281611;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 4:
									{
										global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
										acpFieldBase.Valid = (global::AcpBusinessLayer.AcpConstraints.IsValuePermitted(acpFieldBase) && acpFieldBase.Valid);
										num = (short)2067922954;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
									{
										num = (short)178300663;
										short num4 = num;
										num = (short)540911351;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_24D;
										default:
											num = (short)1136590848;
											if (num != 0)
											{
											}
											num = (short)318832644;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 6:
										switch (0)
										{
										case 0:
											goto IL_176;
										}
										continue;
									case 7:
										num = (short)1325727746;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
									{
										global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
										if (acpFieldBase.Valid)
										{
											num = (short)779419661;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 9:
									{
										global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
										if (acpFieldBase != null)
										{
											num = (short)1225392135;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 10:
										goto IL_1F4;
									case 11:
									{
										global::AcpCommonLib.IAcpField acpField;
										global::AcpBusinessLayer.AcpFieldBase acpFieldBase = acpField as global::AcpBusinessLayer.AcpFieldBase;
										num = (short)399179785;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 12:
										goto IL_3A2;
									case 13:
									{
										global::AcpBusinessLayer.AcpFieldBase acpFieldBase;
										acpFieldBase.CalculateValidity();
										num = (short)1290010625;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 14:
									{
										if (!enumerator3.MoveNext())
										{
											num = (short)583532544;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.IAcpField acpField = enumerator3.Current;
										num = (short)1011548163;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									goto IL_176;
									IL_1F4:
									num = (short)1059913736;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_24D:
									if (global::AcpBusinessLayer.AcpConstraints.IsValuePermitted != null)
									{
										num = (short)66191365;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1F4;
									IL_31E:
									num = (short)926482446;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_176:
									goto IL_31E;
								}
								IL_3A2:;
							}
							finally
							{
								num = (short)338100225;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										enumerator3.Dispose();
										num = (short)270925826;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_3D6;
										}
										continue;
									case 2:
										goto IL_40E;
									}
									IL_3D6:
									if (enumerator3 == null)
									{
										break;
									}
									num = (short)1157169152;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_40E:;
							}
							break;
						}
						IL_411:
						num = (short)2061500420;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_9B:
						goto IL_411;
						IL_56D:
						enumerator3 = featureSection.FieldsCollection.GetEnumerator();
						num = (short)526254087;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_5AE:;
				}
				finally
				{
					num = (short)1146028033;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)476446722;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)580648961;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_60D;
							}
							continue;
						case 2:
							goto IL_644;
						}
						IL_60D:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1948450816;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_644:;
				}
				return;
			}
			}
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00073170 File Offset: 0x00071370
		private static void a(global::AcpCommonLib.IAcpField A_0, global::AcpCommonLib.UndoRedo.ContainerTask A_1)
		{
			int a_ = 16;
			short num;
			if (A_0 is global::AcpBusinessLayer.AcpKeyField)
			{
				for (;;)
				{
					num = (short)351212255;
					short num2 = num;
					num = (short)1591874271;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_76;
					}
					break;
				}
				num = (short)1600913408;
				short num3 = num;
				IL_76:
				num = (short)1287716864;
				if (num != 0)
				{
				}
				A_1.AddTask(new global::AcpBusinessLayer.UndoRedo.SetValueTask((global::AcpBusinessLayer.AcpKeyField)A_0, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꊒ", a_)));
				return;
			}
			num = (short)1938817025;
			if (num != 0)
			{
			}
			((global::AcpBusinessLayer.AcpFieldBase)A_0).ResetToDefaultWithUndo(A_1);
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x0007325C File Offset: 0x0007145C
		public static void KeyFieldValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1005584384;
			short num2 = num;
			num = (short)272401998;
			short num3 = num;
			num = (short)2130216526;
			switch (num3 == num)
			{
			}
			num = (short)2025586689;
			if (num != 0)
			{
			}
			num = (short)945553408;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Security.ASKConstraints.c(self, task);
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x0007330C File Offset: 0x0007150C
		public static void RefKeyFieldValueSetter(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			int a_ = 15;
			short num = (short)1992097792;
			switch (num)
			{
			default:
			{
				num = (short)1518927874;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::AcpCommonLib.IAcpField acpField;
						if (acpField != null)
						{
							num = (short)1311637509;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 1:
					{
						global::AcpCommonLib.IAcpField acpField;
						global::AcpASKLib.KeyType keyType;
						global::AcpASKLib.AccessRecord systemAccessLevel = global::AcpSecurityLib.SecurityManager.GetSystemAccessLevel(((global::AcpBusinessLayer.AcpField<int>)acpField).Value, keyType);
						global::SpecialFeatures.Security.ASKConstraints.a(self.Parent, acpField, keyType, systemAccessLevel, task);
						num = (short)993656838;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_72;
						}
						continue;
					case 3:
					{
						global::AcpCommonLib.IAcpField acpField;
						global::AcpASKLib.KeyType keyType;
						bool flag;
						global::SpecialFeatures.Security.FieldMapManager.GetKeyFieldInfo(global::SpecialFeatures.Security.ASKConstraints.a(self, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욑ﶕ좗ﾙ\ud99d얟첡솣풥즧용ﾫ힭쎯욱톳\udbb5﮹薻貽", a_)), out keyType, out acpField, out flag);
						num = (short)2018574336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)1698693128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_176;
					case 6:
						goto IL_21F;
					case 7:
					{
						global::AcpASKLib.KeyType keyType;
						if (keyType == global::AcpASKLib.KeyType.UNDEFINED_KEY)
						{
							return;
						}
						num = (short)1344860367;
						short num3 = num;
						num = (short)1510404303;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_176;
						default:
							num = (short)829095936;
							if (num != 0)
							{
							}
							num = (short)1328873473;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
						if (global::AcpCommonLib.AppInfoManager.AppType == global::AcpCommonLib.ApplicationType.CPS)
						{
							num = (short)1082261507;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_72:
					if (!global::AcpSecurityLib.SecurityManager.IsSpecialKeyLoaded)
					{
						num = (short)2075131908;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_176:
					num = (short)218693633;
					if (num != 0)
					{
					}
					num = (short)1291190279;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_21F:
				num = (short)613220352;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00073564 File Offset: 0x00071764
		private static void a(global::AcpCommonLib.IAcpFeatureSection A_0, global::AcpCommonLib.UndoRedo.ContainerTask A_1)
		{
			short num = (short)1870659584;
			short num2 = num;
			num = (short)2136469557;
			short num3 = num;
			num = (short)1604644917;
			switch (num3 == num)
			{
			}
			num = (short)475725824;
			if (num != 0)
			{
			}
			num = (short)1376387073;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Security.ASKConstraints.e();
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x00073614 File Offset: 0x00071814
		private static global::AcpCommonLib.IAcpField a(global::AcpCommonLib.IAcpFeatureSection A_0, string A_1)
		{
			short num = (short)1230438401;
			if (num != 0)
			{
			}
			num = (short)1336934400;
			short num2 = num;
			global::AcpCommonLib.IAcpField result = null;
			global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator = A_0.FieldsCollection.GetEnumerator();
			try
			{
				num = (short)1129644034;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
					{
						global::AcpCommonLib.IAcpField acpField;
						result = acpField;
						num = (short)428802054;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_1A9;
					case 2:
						goto IL_74;
					case 3:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)761004036;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpField acpField = enumerator.Current;
						num = (short)1777218253;
						short num4 = num;
						num = (short)546517709;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_74;
						default:
							num = (short)1084424192;
							if (num != 0)
							{
							}
							num = (short)178913285;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						num = (short)853671937;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::AcpCommonLib.IAcpField acpField;
						if (acpField.Name == A_1)
						{
							num = (short)1440874496;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						goto IL_18D;
					}
					goto IL_A0;
					IL_74:
					switch (0)
					{
					case 0:
						IL_A0:
						goto IL_134;
					}
					continue;
					IL_134:
					num = (short)1134952451;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_18D:
				IL_1A9:;
			}
			finally
			{
				num = (short)600178689;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1717501954;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_1DB;
						}
						continue;
					case 2:
						goto IL_210;
					}
					IL_1DB:
					if (enumerator == null)
					{
						break;
					}
					num = (short)502923264;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_210:;
			}
			return result;
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x00073854 File Offset: 0x00071A54
		private static bool d(global::AcpCommonLib.IAcpFeatureSection A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_4C;
			}
			short num;
			int num3;
			bool result;
			for (;;)
			{
				IL_0A:
				num = (short)1951006720;
				short num2 = num;
				switch (num3)
				{
				case 0:
					if (global::AcpCommonLib.AppInfoManager.AppType != global::AcpCommonLib.ApplicationType.DEPOT)
					{
						num = (short)676593665;
						if (num != 0)
						{
						}
						num = (short)363921411;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AA;
				case 1:
					goto IL_AA;
				case 2:
					return result;
				case 3:
					goto IL_A8;
				case 4:
				{
					if (global::AcpCommonLib.AppInfoManager.AppType != global::AcpCommonLib.ApplicationType.LABTOOL)
					{
						return result;
					}
					num = (short)819525396;
					short num4 = num;
					num = (short)492893972;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A8;
					default:
						num = (short)376700928;
						if (num != 0)
						{
						}
						num = (short)1920466945;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_4C;
				IL_A8:
				num = (short)2056716292;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_AA:
				result = true;
				num = (short)684916738;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_4C:
			result = false;
			num = (short)989986816;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000797 RID: 1943 RVA: 0x000739B0 File Offset: 0x00071BB0
		private static bool c(global::AcpCommonLib.IAcpFeatureSection A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_99;
				case 1:
					if (global::AcpCommonLib.AppInfoManager.AppType == global::AcpCommonLib.ApplicationType.LABTOOL)
					{
						num2 = (short)1363804160;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = global::SpecialFeatures.Security.RadioAccessValidator.CheckIfIsACK();
					num2 = (short)1466761224;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)1578696704;
					short num3 = num2;
					if (global::ConstraintHelper.UtilityMack.IsOpenFromRmcOrInCxfEditingMode)
					{
						num2 = (short)317063172;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1693122563;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					goto IL_193;
				case 4:
					result = false;
					num2 = (short)743505925;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
				{
					num2 = (short)124846000;
					short num4 = num2;
					num2 = (short)766377904;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_193;
					default:
						goto IL_141;
					}
					break;
				}
				case 6:
					num2 = (short)2113601537;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_B4;
				case 8:
					return result;
				}
				goto IL_34;
				IL_99:
				result = true;
				num2 = (short)83034119;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_193:
				if (global::AcpCommonLib.AppInfoManager.AppType == global::AcpCommonLib.ApplicationType.DEPOT)
				{
					goto IL_99;
				}
				num2 = (short)879689729;
				if (num2 != 0)
				{
				}
				num2 = (short)1874722822;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_B4:
			return result;
			IL_141:
			num2 = (short)1652359168;
			if (num2 != 0)
			{
			}
			return result;
			IL_34:
			result = false;
			num2 = (short)374538242;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x00073BA0 File Offset: 0x00071DA0
		private static bool b(global::AcpCommonLib.IAcpFeatureSection A_0)
		{
			short num = (short)1704067072;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_74;
				}
				bool result;
				for (;;)
				{
					IL_29:
					int sysId;
					global::AcpASKLib.KeyType type;
					switch (num2)
					{
					case 0:
						result = false;
						num = (short)431816710;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						sysId = global::SpecialFeatures.Security.RadioAccessValidator.GetCodeplugOwnerSystemID();
						type = global::AcpASKLib.KeyType.ADVANCED_SYSTEM_KEY;
						num = (short)1473576965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_319;
					case 3:
						goto IL_22A;
					case 4:
						if (global::AcpCommonLib.AppInfoManager.AppType != global::AcpCommonLib.ApplicationType.DEPOT)
						{
							num = (short)1814167559;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22F;
					case 5:
						goto IL_208;
					case 6:
						goto IL_1E1;
					case 7:
					{
						num = (short)1133641728;
						short num3 = num;
						num = (short)1356529678;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (global::ConstraintHelper.UtilityMack.IsOpenFromRmcOrInCxfEditingMode)
						{
							num = (short)512753664;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1319305220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						int codeplugOwnerKeyType;
						if (codeplugOwnerKeyType == 1)
						{
							num = (short)9371660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_208;
					}
					case 10:
					{
						num = (short)114161935;
						short num4 = num;
						num = (short)1090124047;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_319;
						default:
							num = (short)335478784;
							if (num != 0)
							{
							}
							goto IL_22F;
						}
						break;
					}
					case 11:
						goto IL_208;
					case 12:
						sysId = global::SpecialFeatures.Security.RadioAccessValidator.GetCodeplugOwnerWACNID();
						type = global::AcpASKLib.KeyType.ADVANCED_WACN_KEY;
						num = (short)111083531;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						sysId = 0;
						type = global::AcpASKLib.KeyType.UNDEFINED_KEY;
						int codeplugOwnerKeyType = global::SpecialFeatures.Security.RadioAccessValidator.GetCodeplugOwnerKeyType();
						num = (short)939851791;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						if (global::AcpCommonLib.AppInfoManager.AppType == global::AcpCommonLib.ApplicationType.LABTOOL)
						{
							num = (short)1188954122;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1424031746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						int codeplugOwnerKeyType;
						if (codeplugOwnerKeyType == 0)
						{
							num = (short)608370689;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1052966921;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						goto IL_24A;
					}
					goto IL_74;
					IL_208:
					result = global::AcpSecurityLib.SecurityManager.IsUnLimitedASKLoaded(sysId, type, false);
					num = (short)46661635;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_22F:
					result = true;
					num = (short)258277392;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_319:
					if (global::SpecialFeatures.Security.ASKConstraints.b != global::SpecialFeatures.Security.ProtectionOption.HARDWARE)
					{
						break;
					}
					num = (short)1386807309;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1E1:
				IL_22A:
				return result;
				IL_24A:
				num = (short)1627127809;
				if (num != 0)
				{
				}
				return result;
				IL_74:
				result = false;
				num = (short)35389448;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x00073EEC File Offset: 0x000720EC
		internal static bool IsASKRequired(bool trkSysGeneralAskRequired = false)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				int num;
				bool flag;
				switch (num)
				{
				case 0:
					flag = global::SpecialFeatures.Security.RadioAccessValidator.GetCodeplugASKRequiredFlag();
					goto IL_18E;
				case 1:
					goto IL_1A7;
				case 2:
				{
					num2 = (short)288292864;
					short num3 = num2;
					num2 = (short)1394606091;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					flag = true;
					goto IL_18E;
				case 4:
					num2 = (short)58392576;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (global::SpecialFeatures.Security.RadioAccessValidator.GetCodeplugProtectionOption() == global::SpecialFeatures.Security.ProtectionOption.HARDWARE)
					{
						num2 = (short)423952394;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 6:
					goto IL_189;
				case 7:
					goto IL_1E3;
				case 8:
					if (global::SpecialFeatures.Security.RadioAccessValidator.GetCodeplugProtectionOption() == global::SpecialFeatures.Security.ProtectionOption.UNSPECIFIED)
					{
						num2 = (short)763494402;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_200;
				case 9:
					if (!trkSysGeneralAskRequired)
					{
						num2 = (short)699138052;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1951399939;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					num2 = (short)592379905;
					if (num2 != 0)
					{
					}
					num2 = (short)1947009033;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (!global::SpecialFeatures.Security.RadioAccessValidator.IsCpgConvOnly())
					{
						num2 = (short)996605959;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_200;
				}
				goto IL_40;
				IL_18E:
				result = flag;
				num2 = (short)919273473;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_200:
				num2 = (short)1339490309;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_189:
			IL_1A7:
			return result;
			IL_1E3:
			result = true;
			goto IL_172;
			IL_40:
			num2 = (short)959844450;
			short num4 = num2;
			num2 = (short)337186914;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_172:
				num2 = (short)1906900998;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1988427776;
				if (num2 != 0)
				{
				}
				result = false;
				num2 = (short)1532887048;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00074138 File Offset: 0x00072338
		private static bool b(global::AcpCommonLib.IAcpField A_0)
		{
			short num = (short)567279616;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_92;
				}
				global::AcpASKLib.KeyType keyType;
				bool result;
				global::AcpCommonLib.IAcpField acpField;
				for (;;)
				{
					IL_28:
					num = (short)1027014656;
					short num3 = num;
					num = (short)1656160257;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						if (keyType != global::AcpASKLib.KeyType.UNDEFINED_KEY)
						{
							num = (short)167116803;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 1:
						if (acpField != null)
						{
							num = (short)1010827266;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
						num = (short)939720704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_197;
					case 4:
						return result;
					}
					goto IL_92;
				}
				return result;
				IL_92:
				result = false;
				bool trkSysGeneralAskRequired;
				global::SpecialFeatures.Security.FieldMapManager.GetKeyFieldInfo(A_0, out keyType, out acpField, out trkSysGeneralAskRequired);
				num = (short)1181012109;
				short num4 = num;
				num = (short)1457508493;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_197:
					int value = ((global::AcpBusinessLayer.AcpField<int>)acpField).Value;
					bool bAskOnly = global::SpecialFeatures.Security.ASKConstraints.IsASKRequired(trkSysGeneralAskRequired);
					result = global::AcpSecurityLib.SecurityManager.IsSystemKeyLoaded(value, (byte)keyType, bAskOnly);
					num = (short)397082628;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				default:
					num = (short)248774656;
					if (num != 0)
					{
					}
					num = (short)1454440449;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				break;
			}
			}
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x000742E0 File Offset: 0x000724E0
		private static bool a(global::AcpCommonLib.IAcpField A_0)
		{
			short num = (short)891092993;
			if (num != 0)
			{
			}
			num = (short)1522115894;
			short num2 = num;
			num = (short)1389077814;
			switch (num2 == num)
			{
			}
			num = (short)451280896;
			short num3 = num;
			num = (short)1568866304;
			if (num != 0)
			{
			}
			return global::SpecialFeatures.Security.ASKConstraints.e.ContainsKey(A_0);
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00074398 File Offset: 0x00072598
		private static void a()
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
			for (;;)
			{
				IL_0A:
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWideRecset conventionalWideRecset;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset;
				switch (num)
				{
				case 0:
					goto IL_185;
				case 1:
				{
					num2 = (short)545652736;
					short num3 = num2;
					((global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWide)conventionalWideRecset[0]).ASTROData.CnvWideConventionalCustomerID_41558.IsValid = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Security.ASKConstraints.e);
					((global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWide)conventionalWideRecset[0]).ASTROData.CnvWideConventionalCustomerID_41558.IsEditable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Security.ASKConstraints.c);
					num2 = (short)1800536067;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					global::SpecialFeatures.Security.ASKConstraints.b((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide)radioWideRecset[0]);
					((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide)radioWideRecset[0]).General.RadWideGeneralASKRequired_A37152.IsEditable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Security.ASKConstraints.b);
					((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide)radioWideRecset[0]).UserInformationAndPasswords.RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.IsEditable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Security.ASKConstraints.c);
					((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide)radioWideRecset[0]).UserInformationAndPasswords.RadWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395.IsEditable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Security.ASKConstraints.c);
					((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide)radioWideRecset[0]).General.RadWideGeneralOwnerAdvancedKeyType_A38663.IsEditable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Security.ASKConstraints.d);
					((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide)radioWideRecset[0]).General.RadWideGeneralOwnerSystemID_A37153.IsEditable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Security.ASKConstraints.d);
					((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide)radioWideRecset[0]).General.RadWideGeneralOwnerWACNID_A38656.IsEditable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Security.ASKConstraints.d);
					num2 = (short)831717376;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return;
				case 4:
					try
					{
						num2 = (short)635109377;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 1:
								switch (0)
								{
								case 0:
									goto IL_230;
								}
								continue;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num2 = (short)200867844;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)enumerator.Current;
								global::SpecialFeatures.Security.ASKConstraints.b(trunkingSystem);
								trunkingSystem.General.TrkSysGeneralSystemID_A9239.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::SpecialFeatures.Security.ASKConstraints.KeyFieldValueSetter);
								trunkingSystem.General.TrkSysGeneralHomeWACNID_A8205.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::SpecialFeatures.Security.ASKConstraints.KeyFieldValueSetter);
								trunkingSystem.General.TrkSysGeneralCoverageType_A7782.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::SpecialFeatures.Security.ASKConstraints.CoverageTypeValueSetter);
								trunkingSystem.General.TrkSysGeneralSystemType_A9252.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::SpecialFeatures.Security.ASKConstraints.SystemTypeValueSetter);
								trunkingSystem.General.TrkSysGeneralAskRequired_A44909.IsEditable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Security.ASKConstraints.a);
								num2 = (short)1218838528;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 3:
								goto IL_33D;
							case 4:
								num2 = (short)226557955;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_235:
							num2 = (short)45940738;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_230:
							goto IL_235;
						}
						IL_33D:
						goto IL_5E8;
					}
					finally
					{
						num2 = (short)355008512;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_372;
								}
								continue;
							case 1:
								goto IL_3A8;
							case 2:
								enumerator.Dispose();
								num2 = (short)372506625;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_372:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)1009451010;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_3A8:;
					}
					goto IL_3AB;
				case 5:
					if (conventionalWideRecset != null)
					{
						num2 = (short)1574436865;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 6:
					num2 = (short)1987706881;
					if (num2 != 0)
					{
					}
					try
					{
						num2 = (short)892469249;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_562;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_497;
								}
								continue;
							case 2:
								goto IL_529;
							case 3:
								goto IL_57A;
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num2 = (short)486080512;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality)enumerator.Current;
								global::SpecialFeatures.Security.ASKConstraints.b(trunkingPersonality);
								trunkingPersonality.General.TrkPerGeneralSystem_A9237.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::SpecialFeatures.Security.ASKConstraints.RefKeyFieldValueSetter);
								num2 = (short)1619329026;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							}
							goto IL_497;
							IL_529:
							num2 = (short)1530658820;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_497:
							num2 = (short)1713255817;
							short num4 = num2;
							num2 = (short)413283721;
							switch ((num4 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_562:
								num2 = (short)1234501635;
								num = (int)((global::System.IntPtr)num2);
								break;
							default:
								num2 = (short)580059136;
								if (num2 != 0)
								{
								}
								goto IL_529;
							}
						}
						IL_57A:
						goto IL_3AB;
					}
					finally
					{
						num2 = (short)791674880;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_5B1;
								}
								continue;
							case 1:
								goto IL_5E5;
							case 2:
								enumerator.Dispose();
								num2 = (short)415498241;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_5B1:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)828506114;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_5E5:;
					}
					goto IL_5E8;
				case 7:
					if (radioWideRecset != null)
					{
						num2 = (short)1333198850;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_185;
				}
				goto IL_30;
				IL_185:
				conventionalWideRecset = (global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWideRecset)global::AcpCommonLib.FeatureManager.GetFeature(2024);
				num2 = (short)1740832773;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_3AB:
				radioWideRecset = (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)global::AcpCommonLib.FeatureManager.GetFeature(2045);
				num2 = (short)867106823;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_5E8:
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset trunkingPersonalityRecset = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset)global::AcpCommonLib.FeatureManager.GetFeature(2072);
				trunkingPersonalityRecset.CollectionChanged += global::SpecialFeatures.Security.ASKConstraints.OnTopLevelRecordsetEventHandler;
				enumerator = trunkingPersonalityRecset.GetEnumerator();
				num2 = (short)1511653382;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_30:
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset trunkingSystemRecset = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset)global::AcpCommonLib.FeatureManager.GetFeature(2064);
			trunkingSystemRecset.CollectionChanged += global::SpecialFeatures.Security.ASKConstraints.OnTopLevelRecordsetEventHandler;
			enumerator = trunkingSystemRecset.GetEnumerator();
			num2 = (short)515768324;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00074A2C File Offset: 0x00072C2C
		public static void OnTopLevelRecordsetEventHandler(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			short num = (short)1754136578;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.IEnumerator enumerator;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1438842880;
					short num3 = num;
					enumerator = e.OldItems.GetEnumerator();
					num = (short)735641601;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_D0;
				case 2:
					num = (short)569311233;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_62;
					}
					continue;
				case 3:
					goto IL_295;
				case 4:
					try
					{
						num = (short)796917763;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
								trunkingSystem.General.TrkSysGeneralAskRequired_A44909.CalculateEditability();
								num = (short)874577922;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								goto IL_222;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_156;
								}
								continue;
							case 4:
							{
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
								if (trunkingSystem != null)
								{
									num = (short)268566528;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1600126982;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								object obj = enumerator.Current;
								global::SpecialFeatures.Security.ASKConstraints.b((global::AcpCommonLib.IAcpFeatureNode)obj);
								global::SpecialFeatures.Security.ASKConstraints.c((global::AcpCommonLib.IAcpFeatureNode)obj);
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = obj as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
								num = (short)1071972356;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
								num = (short)196804609;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_1A8:
							num = (short)1460731909;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_156:
							goto IL_1A8;
						}
						IL_222:
						goto IL_437;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_243;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_231:
							switch (num2)
							{
							case 0:
								if (disposable != null)
								{
									num = (short)303890434;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_294;
							case 1:
								goto IL_292;
							case 2:
								disposable.Dispose();
								num = (short)359989249;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_243;
						}
						IL_292:
						IL_294:
						goto EndFinally_13;
						IL_243:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)710279168;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_231;
						EndFinally_13:;
					}
					goto IL_295;
				case 5:
					if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
					{
						num = (short)189923328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_62:
				if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Add)
				{
					num = (short)568983555;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1410727941;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_295:
				global::SpecialFeatures.Security.ASKConstraints.c = true;
				enumerator = e.NewItems.GetEnumerator();
				num = (short)798687236;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D0:
			try
			{
				num = (short)726073345;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_3AE;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_2FD;
						}
						continue;
					case 2:
						goto IL_372;
					case 3:
						goto IL_3C6;
					case 4:
						if (!enumerator.MoveNext())
						{
							num = (short)857014272;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SpecialFeatures.Security.ASKConstraints.a((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current);
						num = (short)430833666;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2FD;
					IL_372:
					num = (short)1393491972;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2FD:
					num = (short)1937847947;
					short num4 = num;
					num = (short)1080243851;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_3AE:
						num = (short)953548803;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)1079050240;
						if (num != 0)
						{
						}
						goto IL_372;
					}
				}
				IL_3C6:
				return;
			}
			finally
			{
				switch (0)
				{
				case 0:
					goto IL_3E4;
				}
				global::System.IDisposable disposable;
				for (;;)
				{
					IL_3D2:
					switch (num2)
					{
					case 0:
						if (disposable != null)
						{
							num = (short)1570045954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_436;
					case 1:
						goto IL_434;
					case 2:
						disposable.Dispose();
						num = (short)1406205953;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3E4;
				}
				IL_434:
				IL_436:
				goto EndFinally_12;
				IL_3E4:
				disposable = (enumerator as global::System.IDisposable);
				num = (short)1495072768;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_3D2;
				EndFinally_12:;
			}
			IL_437:
			global::SpecialFeatures.Security.ASKConstraints.c = false;
		}

		// Token: 0x0600079E RID: 1950 RVA: 0x00074EAC File Offset: 0x000730AC
		public static void OnEmbeddedRecordsetEventHandler(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			short num = (short)961019906;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.IEnumerator enumerator;
			bool flag;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					enumerator = e.OldItems.GetEnumerator();
					num = (short)1394606080;
					short num3 = num;
					num = (short)794361857;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_AC;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 3:
					goto IL_247;
				case 4:
					try
					{
						num = (short)1989541889;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)162660355;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_14F;
								}
								continue;
							case 3:
								goto IL_1D0;
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1777729536;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								object obj = enumerator.Current;
								global::SpecialFeatures.Security.ASKConstraints.b((global::AcpCommonLib.IAcpFeatureNode)obj);
								global::SpecialFeatures.Security.ASKConstraints.c((global::AcpCommonLib.IAcpFeatureNode)obj);
								num = (short)135135234;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_182:
							num = (short)1075707908;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_14F:
							goto IL_182;
						}
						IL_1D0:
						goto IL_3EA;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_1F1;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_1DF:
							switch (num2)
							{
							case 0:
								if (disposable != null)
								{
									num = (short)246218754;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_246;
							case 1:
								goto IL_244;
							case 2:
								disposable.Dispose();
								num = (short)1808400385;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1F1;
						}
						IL_244:
						IL_246:
						goto EndFinally_12;
						IL_1F1:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)1830813696;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_1DF;
						EndFinally_12:;
					}
					goto IL_247;
				case 5:
					if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
					{
						num = (short)1203437568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_3C:
				if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Add)
				{
					num = (short)1066598403;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1741357061;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_247:
				flag = global::SpecialFeatures.Security.ASKConstraints.c;
				global::SpecialFeatures.Security.ASKConstraints.c = true;
				enumerator = e.NewItems.GetEnumerator();
				num = (short)317259780;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_AC:
			num = (short)467861505;
			if (num != 0)
			{
			}
			try
			{
				num = (short)279969793;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_300;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_2B3;
						}
						continue;
					case 2:
						if (!enumerator.MoveNext())
						{
							num = (short)1004273668;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SpecialFeatures.Security.ASKConstraints.a((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current);
						num = (short)2005336064;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_378;
					case 4:
						goto IL_361;
					}
					goto IL_2B3;
					IL_300:
					num = (short)1447690242;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2B3:
					num = (short)1295658848;
					short num4 = num;
					num = (short)984166240;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_361:
						num = (short)1654390787;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)1007026176;
						if (num != 0)
						{
						}
						goto IL_300;
					}
				}
				IL_378:
				return;
			}
			finally
			{
				switch (0)
				{
				case 0:
					goto IL_396;
				}
				global::System.IDisposable disposable;
				for (;;)
				{
					IL_384:
					switch (num2)
					{
					case 0:
						if (disposable != null)
						{
							num = (short)1281032194;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E9;
					case 1:
						goto IL_3E7;
					case 2:
						disposable.Dispose();
						num = (short)31653889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_396;
				}
				IL_3E7:
				IL_3E9:
				goto EndFinally_11;
				IL_396:
				disposable = (enumerator as global::System.IDisposable);
				num = (short)205127680;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_384;
				EndFinally_11:;
			}
			IL_3EA:
			global::SpecialFeatures.Security.ASKConstraints.c = flag;
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x000752C8 File Offset: 0x000734C8
		private static void b(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)2097086464;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7C;
				}
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
				for (;;)
				{
					IL_29:
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator4;
					switch (num2)
					{
					case 0:
						if (trunkingSystem.General.TrkSysGeneralSystemID_A9239 != null)
						{
							num = (short)887160832;
							short num3 = num;
							num = (short)1217462286;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8C9;
					case 1:
						goto IL_8C9;
					case 2:
						if (radioWide == null)
						{
							num = (short)907935753;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1182203914;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (radioWide.General.RadWideGeneralASKRequired_A37152 != null)
						{
							num = (short)1802895376;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9C2;
					case 4:
						goto IL_558;
					case 5:
						if (trunkingSystem == null)
						{
							num = (short)824246280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1925709835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						try
						{
							num = (short)2145189889;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									num = (short)1071487611;
									short num4 = num;
									num = (short)1172871803;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
									{
										num = (short)1593638912;
										if (num != 0)
										{
										}
										global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)645398530;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.IAcpRecordset acpRecordset = enumerator.Current;
										((global::AcpBusinessLayer.Recordset)acpRecordset).CollectionChanged += global::SpecialFeatures.Security.ASKConstraints.OnEmbeddedRecordsetEventHandler;
										global::System.Collections.IEnumerator enumerator2 = ((global::System.Collections.IEnumerable)acpRecordset).GetEnumerator();
										num = (short)770441219;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_644;
									}
									continue;
								case 2:
									num = (short)2123628548;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									try
									{
										num = (short)2129395713;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												global::System.Collections.IEnumerator enumerator2;
												if (!enumerator2.MoveNext())
												{
													num = (short)1407451138;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::SpecialFeatures.Security.ASKConstraints.b((global::AcpCommonLib.IAcpFeatureNode)enumerator2.Current);
												num = (short)390201347;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 1:
												switch (0)
												{
												case 0:
													goto IL_6C6;
												}
												continue;
											case 2:
												num = (short)2097086468;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
												goto IL_73F;
											}
											IL_6F1:
											num = (short)1816920064;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_6C6:
											goto IL_6F1;
										}
										IL_73F:;
									}
									finally
									{
										switch (0)
										{
										case 0:
											goto IL_75E;
										}
										global::System.IDisposable disposable;
										for (;;)
										{
											IL_74B:
											switch (num2)
											{
											case 0:
												disposable.Dispose();
												num = (short)1721171970;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												if (disposable != null)
												{
													num = (short)2110259200;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_7B5;
											case 2:
												goto IL_7B3;
											}
											goto IL_75E;
										}
										IL_7B3:
										IL_7B5:
										break;
										IL_75E:
										global::System.Collections.IEnumerator enumerator2;
										disposable = (enumerator2 as global::System.IDisposable);
										num = (short)239009793;
										num2 = (int)((global::System.IntPtr)num);
										goto IL_74B;
									}
									break;
								case 4:
									goto IL_857;
								}
								IL_7B6:
								num = (short)460652544;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_644:
								goto IL_7B6;
							}
							IL_857:
							return;
						}
						finally
						{
							num = (short)1092419585;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)347865090;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_88E;
									}
									continue;
								case 2:
									goto IL_8C6;
								}
								IL_88E:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1650262016;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_8C6:;
						}
						goto IL_8C9;
					case 7:
						num = (short)1649278979;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						radioWide = (A_0 as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
						num = (short)181075970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)573702161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (radioWide.General != null)
						{
							num = (short)530251783;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_558;
					case 11:
						if (trunkingSystem.General != null)
						{
							num = (short)562692109;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_558;
					case 12:
						goto IL_9C2;
					case 13:
						num = (short)491978752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						trunkingSystem.General.TrkSysGeneralSystemID_A9239.NotifyPropertyChanging = true;
						num = (short)165412865;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						try
						{
							num = (short)966459393;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_3E8;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_120;
									}
									continue;
								case 2:
									try
									{
										num = (short)917700610;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												num = (short)80609292;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
											{
												global::AcpCommonLib.IAcpField acpField;
												if (!acpField.Valid)
												{
													num = (short)260702219;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 2:
												switch (0)
												{
												case 0:
													goto IL_1DE;
												}
												continue;
											case 3:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator3;
												if (!enumerator3.MoveNext())
												{
													num = (short)335216640;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::AcpCommonLib.IAcpField acpField = enumerator3.Current;
												num = (short)1773797381;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
											{
												global::AcpCommonLib.IAcpField acpField;
												if (global::SpecialFeatures.Security.ASKConstraints.c(acpField))
												{
													num = (short)1324154887;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 5:
											{
												global::AcpCommonLib.IAcpField acpField;
												if (global::SpecialFeatures.Security.FieldMapManager.GetFieldMapInfo(acpField.Name) != null)
												{
													num = (short)833355786;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 6:
											{
												global::AcpCommonLib.IAcpField acpField;
												if (!global::SpecialFeatures.Security.ASKConstraints.e.ContainsKey(acpField))
												{
													num = (short)2112749576;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 7:
												num = (short)1333002246;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 8:
											{
												global::AcpCommonLib.IAcpField acpField;
												global::SpecialFeatures.Security.ASKConstraints.e.Add(acpField, acpField);
												num = (short)315490313;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 10:
											{
												global::AcpCommonLib.IAcpField acpField;
												acpField.Protected = true;
												num = (short)1185742849;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 11:
												num = (short)851509252;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 12:
												goto IL_376;
											}
											IL_2B8:
											num = (short)1736376323;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_1DE:
											goto IL_2B8;
										}
										IL_376:
										break;
									}
									finally
									{
										num = (short)987299841;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator3;
											switch (num2)
											{
											case 0:
												enumerator3.Dispose();
												num = (short)760676354;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_3AE;
												}
												continue;
											case 2:
												goto IL_3E5;
											}
											IL_3AE:
											if (enumerator3 == null)
											{
												break;
											}
											num = (short)1452670976;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_3E5:;
									}
									goto IL_3E8;
								case 3:
								{
									if (!enumerator4.MoveNext())
									{
										num = (short)1650655232;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator3 = enumerator4.Current.FieldsCollection.GetEnumerator();
									num = (short)584843266;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_400;
								}
								IL_122:
								num = (short)465436675;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_120:
								goto IL_122;
								IL_3E8:
								num = (short)1785659396;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_400:
							goto IL_50F;
						}
						finally
						{
							num = (short)1521549313;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator4.Dispose();
									num = (short)284753922;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_439;
									}
									continue;
								case 2:
									goto IL_46F;
								}
								IL_439:
								if (enumerator4 == null)
								{
									break;
								}
								num = (short)1444478976;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_46F:;
						}
						goto IL_472;
						IL_50F:
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpRecordset> enumerator = A_0.EmbeddedRecordsets.GetEnumerator();
						num = (short)1214382086;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						goto IL_472;
					case 17:
						goto IL_558;
					case 18:
						goto IL_558;
					}
					goto IL_7C;
					IL_472:
					radioWide.General.RadWideGeneralASKRequired_A37152.NotifyPropertyChanging = true;
					num = (short)227344396;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_558:
					enumerator4 = A_0.FeatureSectionsCollection.GetEnumerator();
					num = (short)829489167;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8C9:
					trunkingSystem.General.PropertyChanging += global::SpecialFeatures.Security.ASKConstraints.TrkSysGeneral_PropertyChanging;
					trunkingSystem.General.PropertyChanged += global::SpecialFeatures.Security.ASKConstraints.TrkSysGeneral_PropertyChanged;
					num = (short)1266286596;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9C2:
					radioWide.General.PropertyChanged += global::SpecialFeatures.Security.ASKConstraints.RadWideGeneral_PropertyChanged;
					num = (short)773586962;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_7C:
				trunkingSystem = (A_0 as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
				num = (short)88014849;
				if (num != 0)
				{
				}
				num = (short)261488645;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00075D30 File Offset: 0x00073F30
		private static void a(global::AcpCommonLib.IAcpFeatureNode A_0)
		{
			short num = (short)643497984;
			switch (num)
			{
			default:
			{
				num = (short)401473537;
				if (num != 0)
				{
				}
				num = (short)795410432;
				short num2 = num;
				global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpFeatureSection> enumerator = A_0.FeatureSectionsCollection.GetEnumerator();
				try
				{
					num = (short)648216577;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::AcpBusinessLayer.FeatureSection featureSection;
						global::System.Collections.Generic.IEnumerator<global::AcpCommonLib.IAcpField> enumerator3;
						switch (num3)
						{
						case 0:
							num = (short)589234183;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_C1;
							}
							continue;
						case 2:
							if (!enumerator.MoveNext())
							{
								num = (short)1724907520;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							featureSection = (global::AcpBusinessLayer.FeatureSection)enumerator.Current;
							num = (short)1797455878;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							try
							{
								num = (short)1996029953;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
									{
										num = (short)1837651028;
										short num4 = num;
										num = (short)1423922260;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
										{
											num = (short)113639424;
											if (num != 0)
											{
											}
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
											if (!enumerator2.MoveNext())
											{
												num = (short)378535938;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::SpecialFeatures.Security.ASKConstraints.a(enumerator2.Current);
											num = (short)1249116163;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										}
										break;
									}
									case 1:
										switch (0)
										{
										case 0:
											goto IL_370;
										}
										continue;
									case 2:
										num = (short)1871511556;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										goto IL_433;
									}
									IL_394:
									num = (short)1713373184;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_370:
									goto IL_394;
								}
								IL_433:;
							}
							finally
							{
								num = (short)542769153;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
									switch (num3)
									{
									case 0:
										enumerator2.Dispose();
										num = (short)1157824514;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_469;
										}
										continue;
									case 2:
										goto IL_4A1;
									}
									IL_469:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)1583742976;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_4A1:;
							}
							goto IL_4A4;
						case 4:
							try
							{
								num = (short)356450306;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
									{
										global::AcpCommonLib.IAcpField acpField;
										if (acpField.Protected)
										{
											num = (short)846987267;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 1:
									{
										global::AcpCommonLib.IAcpField acpField;
										global::SpecialFeatures.Security.ASKConstraints.e.Remove(acpField);
										num = (short)600047621;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										switch (0)
										{
										case 0:
											goto IL_182;
										}
										continue;
									case 3:
										num = (short)1339424774;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
									{
										if (!enumerator3.MoveNext())
										{
											num = (short)367984647;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.IAcpField acpField = enumerator3.Current;
										num = (short)1392640000;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
									{
										global::AcpCommonLib.IAcpField acpField;
										if (global::SpecialFeatures.Security.ASKConstraints.e.ContainsKey(acpField))
										{
											num = (short)863764481;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 7:
										num = (short)591462408;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
										goto IL_286;
									}
									IL_184:
									num = (short)1034420228;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_182:
									goto IL_184;
								}
								IL_286:;
							}
							finally
							{
								num = (short)163708929;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										enumerator3.Dispose();
										num = (short)1375076354;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_2BA;
										}
										continue;
									case 2:
										goto IL_2F1;
									}
									IL_2BA:
									if (enumerator3 == null)
									{
										break;
									}
									num = (short)843317248;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_2F1:;
							}
							break;
						case 5:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = ((global::AcpBusinessLayer.Recordset)featureSection.EmbeddedRecset).GetEnumerator();
							num = (short)1635975171;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							if (featureSection.HasEmbeddedRecset)
							{
								num = (short)558956549;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4A4;
						case 7:
							goto IL_4E6;
						}
						IL_2F4:
						num = (short)1741488130;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_C1:
						goto IL_2F4;
						IL_4A4:
						enumerator3 = featureSection.FieldsCollection.GetEnumerator();
						num = (short)1932853252;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_4E6:;
				}
				finally
				{
					num = (short)2005336065;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1000013826;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_51A;
							}
							continue;
						case 2:
							goto IL_54F;
						}
						IL_51A:
						if (enumerator == null)
						{
							break;
						}
						num = (short)19267584;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_54F:;
				}
				return;
			}
			}
		}

		// Token: 0x060007A1 RID: 1953 RVA: 0x000762DC File Offset: 0x000744DC
		internal static void TrkSysGeneral_PropertyChanging(object sender, global::System.ComponentModel.PropertyChangingEventArgs e)
		{
			int a_ = 4;
			short num = (short)147454923;
			short num2 = num;
			num = (short)836959179;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)679149568;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_92;
				}
				int num3;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general;
				for (;;)
				{
					IL_5C:
					string text;
					bool flag;
					switch (num3)
					{
					case 0:
						return;
					case 1:
						num = (short)1123614726;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						text = e.PropertyName;
						goto IL_154;
					case 3:
						goto IL_248;
					case 4:
						flag = (null != null);
						goto IL_1BB;
					case 5:
						if (e == null)
						{
							num = (short)639565835;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)880607234;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return;
					case 7:
						text = null;
						goto IL_154;
					case 8:
						general.TrkSysGeneralAskRequired_A44909.IsEditable = new global::AcpCommonLib.StateConstraint(global::SpecialFeatures.Security.ASKConstraints.a);
						num = (short)1266155523;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						global::AcpBusinessLayer.AcpField<bool> trkSysGeneralAskRequired_A = general.TrkSysGeneralAskRequired_A44909;
						if (trkSysGeneralAskRequired_A == null)
						{
							num = (short)1733165060;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = (trkSysGeneralAskRequired_A.IsEditable != null);
						goto IL_1BB;
					}
					case 10:
						if (general == null)
						{
							num = (short)1508638721;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)186187781;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)1173291009;
						if (num != 0)
						{
						}
						num = (short)1898315783;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_92;
					IL_154:
					if (text != global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("펆ﮈ\ude8c풒練ﲘﲜ\udaa2횤펦첨욪貴薶誸芺\udebe귀뛂ꃄ", a_))
					{
						num = (short)486735872;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::SpecialFeatures.Security.ASKConstraints.f = general.TrkSysGeneralSystemID_A9239Value;
					num = (short)1176109065;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BB:
					if (!flag)
					{
						return;
					}
					num = (short)108986376;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_248:
				num = (short)1967587328;
				short num4 = num;
				return;
				IL_92:
				general = (sender as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General);
				num = (short)2079981578;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_5C;
			}
			}
		}

		// Token: 0x060007A2 RID: 1954 RVA: 0x0007655C File Offset: 0x0007475C
		private static bool a(global::AcpCommonLib.IAcpFeatureSection A_0)
		{
			short num = (short)619839504;
			int num2 = (int)((global::System.IntPtr)num);
			int sysId;
			for (;;)
			{
				object obj;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
				bool flag;
				switch (num2)
				{
				case 0:
					obj = null;
					goto IL_241;
				case 1:
					if (global::SpecialFeatures.Security.ASKConstraints.b != global::SpecialFeatures.Security.ProtectionOption.HARDWARE)
					{
						num = (short)1119223811;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					sysId = 0;
					num = (short)4718605;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)11403264;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return false;
				case 4:
					flag = (trunkingSystem.General != null);
					goto IL_1D8;
				case 5:
					sysId = trunkingSystem.General.TrkSysGeneralSystemID_A9239Value;
					num = (short)1050935308;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (trunkingSystem == null)
					{
						num = (short)1540751374;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)646119428;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					num = (short)1549467649;
					if (num != 0)
					{
					}
					if (trunkingSystem.General != null)
					{
						num = (short)699990021;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_321;
				case 8:
					flag = (null != null);
					goto IL_1D8;
				case 9:
					goto IL_1D3;
				case 10:
					num = (short)1211170827;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (trunkingSystem.General.TrkSysGeneralSystemID_A9239Value == 1)
					{
						num = (short)1055981585;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2E4;
				case 12:
					goto IL_21D;
				case 13:
					if (trunkingSystem != null)
					{
						num = (short)463011849;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_321;
				case 14:
					num = (short)1316552712;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					obj = A_0.Parent;
					goto IL_241;
				case 16:
				{
					num = (short)1202276675;
					short num3 = num;
					num = (short)215363;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D3;
					default:
						num = (short)384106496;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_B6;
						}
						continue;
					}
					break;
				}
				case 17:
					goto IL_14C;
				}
				IL_B6:
				if (A_0 == null)
				{
					num = (short)291307522;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)326369295;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1D3:
				num = (short)485949447;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1D8:
				if (flag)
				{
					num = (short)2020212746;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_2E4;
				IL_241:
				trunkingSystem = (obj as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
				num = (short)4456454;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2E4:
				num = (short)32309249;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_14C:
			num = (short)1949892608;
			short num4 = num;
			return false;
			IL_21D:
			IL_321:
			return global::AcpSecurityLib.SecurityManager.IsUnLimitedASKLoaded(sysId, global::AcpASKLib.KeyType.ADVANCED_SYSTEM_KEY, false);
		}

		// Token: 0x060007A3 RID: 1955 RVA: 0x00076894 File Offset: 0x00074A94
		internal static void TrkSysGeneral_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			int a_ = 13;
			switch (0)
			{
			case 0:
				goto IL_95;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general;
			short num2;
			bool flag;
			for (;;)
			{
				IL_13:
				global::AcpASKLib.KeyType trunkingKeyType;
				switch (num)
				{
				case 0:
					if (general == null)
					{
						num2 = (short)978059293;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)351076374;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					if (!(e.PropertyName == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒏ﾓ얕\udb9bﮝ캟잡횣장쒧囹햫\uddad쒯ힱ\ud9b3ﶵ\uddb7쎹잽낿ꟁ鯃蟅﯇﯍蓑뗓뫕귗뿙", a_)))
					{
						num2 = (short)1573715991;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)285510183;
					short num3 = num2;
					num2 = (short)1699973671;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14D;
					default:
						num2 = (short)1554186240;
						if (num2 != 0)
						{
						}
						num2 = (short)1971650567;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					num2 = (short)61866001;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (!(e.PropertyName == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒏ﾓ얕\udb9bﮝ캟잡횣장쒧쎫\ud8ad햯삱햳통\uddb7얻캽ꖿ鷁藃ￇﻋ重蛏돑룓뿕볗", a_)))
					{
						num2 = (short)140115992;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_117;
				case 4:
					goto IL_14D;
				case 5:
					flag = true;
					num2 = (short)1108082706;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					return;
				case 7:
					goto IL_117;
				case 8:
					goto IL_411;
				case 9:
					if (flag)
					{
						num2 = (short)1160577050;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 10:
					goto IL_249;
				case 11:
					goto IL_249;
				case 12:
					if (trunkingKeyType == global::AcpASKLib.KeyType.ADVANCED_SYSTEM_KEY)
					{
						num2 = (short)799932432;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_371;
				case 13:
					if (global::SpecialFeatures.Security.ASKConstraints.f == 1)
					{
						num2 = (short)1206845445;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::SpecialFeatures.Security.ASKConstraints.d(general.Parent);
					num2 = (short)436404245;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					if (!global::SpecialFeatures.Security.RadioAccessValidator.IsHardwareAskLoaded(general.TrkSysGeneralSystemID_A9239Value, global::AcpSecurityLib.SecurityManager.LoadedASKs))
					{
						num2 = (short)558563353;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_55F;
				case 15:
				{
					num2 = (short)1079508992;
					short num4 = num2;
					general.TrkSysGeneralSystemID_A9239.Valid = false;
					num2 = (short)1183711240;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 16:
					num2 = (short)20643853;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					if (general.TrkSysGeneralAskRequired_A44909Value)
					{
						num2 = (short)649592862;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_55F;
				case 18:
					goto IL_371;
				case 19:
					num2 = (short)1028063244;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					num2 = (short)1065091086;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 21:
					num2 = (short)1809580033;
					if (num2 != 0)
					{
					}
					goto IL_371;
				case 22:
					if (e.PropertyName == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒏ﾓ얕\udb9bﮝ캟잡횣장쒧\udfab얭ힱ얳쎵톷좹\ud9bb\udabd龿菁韛飍뇏뻑ꇓ돕", a_))
					{
						num2 = (short)867762178;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_55F;
				case 23:
					if (e.PropertyName == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쒏ﾓ얕\udb9bﮝ캟잡횣장쒧囹햫\uddad쒯ힱ\ud9b3ﾵﲷﶻ螽ﷃ郅꧇ꛉ맋ꯍ", a_))
					{
						num2 = (short)1000210451;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_249;
				case 24:
					num2 = (short)1881997313;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
					general.TrkSysGeneralHomeWACNID_A8205.ResetToDefault();
					general.TrkSysGeneralCoverageType_A7782.ResetToDefault();
					general.TrkSysGeneralSystemType_A9252.ResetToDefault();
					num2 = (short)2058551323;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 26:
					global::SpecialFeatures.Security.ASKConstraints.c = true;
					global::SpecialFeatures.Security.ASKConstraints.d(general.Parent);
					global::SpecialFeatures.Security.ASKConstraints.c = false;
					num2 = (short)364314630;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 27:
					goto IL_55F;
				case 28:
					if (!general.TrkSysGeneralSystemID_A9239.Valid)
					{
						num2 = (short)1748697108;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_55F;
				case 29:
					return;
				case 30:
					num2 = (short)522977284;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_95;
				IL_117:
				flag = true;
				num2 = (short)1739390986;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_14D:
				if (!global::SpecialFeatures.Security.RadioAccessValidator.IsHardwareAskLoaded(general.TrkSysGeneralSystemID_A9239Value, global::AcpSecurityLib.SecurityManager.LoadedASKs))
				{
					num2 = (short)1777270799;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_411;
				IL_249:
				num2 = (short)100794377;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_371:
				global::SpecialFeatures.Security.ASKConstraints.f = -1;
				num2 = (short)150142987;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_411:
				general.TrkSysGeneralSystemID_A9239.CalculateValidity();
				num2 = (short)1202454556;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_55F:
				trunkingKeyType = global::SpecialFeatures.Security.FieldMapManager.GetTrunkingKeyType(general.Parent);
				num2 = (short)1817903107;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_95:
			flag = false;
			general = (sender as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General);
			num2 = (short)136314880;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060007A4 RID: 1956 RVA: 0x00076E60 File Offset: 0x00075060
		internal static void RadWideGeneral_PropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			int a_ = 12;
			short num = (short)1134624771;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset trunkingSystemRecset;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				switch (num2)
				{
				case 0:
					num = (short)1383596033;
					if (num != 0)
					{
					}
					if (trunkingSystemRecset != null)
					{
						num = (short)1276313601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
				{
					num = (short)1313210368;
					short num3 = num;
					goto IL_24E;
				}
				case 2:
					try
					{
						num = (short)890699781;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_155;
							case 1:
								goto IL_1E0;
							case 2:
							{
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
								if (global::SpecialFeatures.Security.FieldMapManager.GetTrunkingKeyType(trunkingSystem.General.Parent) == global::AcpASKLib.KeyType.ADVANCED_SYSTEM_KEY)
								{
									num = (short)1540358150;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_155;
							}
							case 3:
								goto IL_1C7;
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1032519683;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem)enumerator.Current;
								num = (short)30539778;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								switch (0)
								{
								case 0:
									goto IL_BA;
								}
								continue;
							case 6:
							{
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
								global::SpecialFeatures.Security.ASKConstraints.d(trunkingSystem.General.Parent);
								global::SpecialFeatures.Security.ASKConstraints.d();
								global::SpecialFeatures.Security.ASKConstraints.c();
								global::SpecialFeatures.Security.ASKConstraints.b();
								num = (short)780468224;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							goto IL_BA;
							IL_155:
							num = (short)1733951492;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_BA:
							num = (short)178371961;
							short num4 = num;
							num = (short)75283833;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_1C7:
								num = (short)1330905089;
								num2 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)679280640;
								if (num != 0)
								{
								}
								goto IL_155;
							}
						}
						IL_1E0:
						return;
					}
					finally
					{
						num = (short)1828651010;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)144900097;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_24B;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_216;
								}
								continue;
							}
							IL_216:
							if (enumerator == null)
							{
								break;
							}
							num = (short)579338240;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_24B:;
					}
					goto IL_24E;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_41;
					}
					continue;
				case 4:
					trunkingSystemRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset);
					num = (short)342753280;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_41:
				if (e.PropertyName == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udd8e슔ﺖﶘﺚ\uda9c爵쾠욢힤욦얨ﺬ횲쒴슶킸즺\ud8bc\udbbe黀苂ﻊￌ駎냐뿒ꃔ닖", a_))
				{
					num = (short)1674510340;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_24E:
				enumerator = trunkingSystemRecset.GetEnumerator();
				num = (short)563871746;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x040002EE RID: 750
		private static global::AcpASKLib.SystemKeyLoadedEventHandler a;

		// Token: 0x040002EF RID: 751
		private static global::SpecialFeatures.Security.ProtectionOption b;

		// Token: 0x040002F0 RID: 752
		private static bool c;

		// Token: 0x040002F1 RID: 753
		private const int d = 1;

		// Token: 0x040002F2 RID: 754
		private static global::System.Collections.Generic.Dictionary<global::AcpCommonLib.IAcpField, global::AcpCommonLib.IAcpField> e;

		// Token: 0x040002F3 RID: 755
		private static int f;
	}
}
