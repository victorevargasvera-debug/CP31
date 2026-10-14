using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.CommonBase.Enums;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x020000AC RID: 172
	public class ASTROTemplateService : global::Motorola.CommonCPS.RadioManagement.SharedServices.TemplateServiceBase, global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROTemplateService, global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateService, global::Motorola.CommonCPS.RadioManagement.SharedServices.IService
	{
		// Token: 0x06000A39 RID: 2617 RVA: 0x000780A4 File Offset: 0x000762A4
		public ASTROTemplateService(global::Motorola.CommonCPS.RadioManagement.SharedServices.IServerAccessor serverAccessor, global::Motorola.CommonCPS.RadioManagement.SharedServices.IASTROValidationService astroValidationService) : base(serverAccessor, astroValidationService)
		{
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x000780BC File Offset: 0x000762BC
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem> CloneRadioSystem(global::Motorola.CommonCPS.Server.EntityModel.APXTemplate source, global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug target, bool isApply = true)
		{
			int a_ = 5;
			short num = (short)1737687041;
			if (num != 0)
			{
			}
			num = (short)337772544;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_126;
				}
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem> list;
				global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem[] array2;
				int num6;
				for (;;)
				{
					IL_57:
					int num4;
					global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? systemSubType;
					global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType astroSystemSubType;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType;
						if (systemType.GetValueOrDefault() == astroSystemType & systemType != null)
						{
							num = (short)857866288;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem> source2;
						CS$<>8__locals1.system.RadioId = source2.FirstOrDefault<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>().RadioId;
						num = (short)1684733975;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_979;
					case 2:
					{
						global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem> source2 = target.APXRadioSystems.Where(delegate(global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem s)
						{
							short num7 = (short)1327759360;
							int num8 = (int)num7;
							switch (num8)
							{
							default:
							{
								num7 = (short)4196096;
								short num9 = num7;
								num7 = (short)2114193152;
								switch ((num9 == num7) ? 1 : 0)
								{
								case 0:
								case 2:
									IL_14F:
									if (!s.SystemName.Equals(CS$<>8__locals1.system.SystemName))
									{
										goto IL_21E;
									}
									num7 = (short)334102530;
									num8 = (int)((global::System.IntPtr)num7);
									break;
								default:
									num7 = (short)637599744;
									if (num7 != 0)
									{
									}
									switch (0)
									{
									case 0:
										goto IL_91;
									}
									break;
								}
								global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType2;
								global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType3;
								for (;;)
								{
									IL_72:
									switch (num8)
									{
									case 0:
									{
										global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? systemSubType2;
										global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? systemSubType3;
										if (systemSubType2.GetValueOrDefault() == systemSubType3.GetValueOrDefault() & systemSubType2 != null == (systemSubType3 != null))
										{
											num7 = (short)185466883;
											num8 = (int)((global::System.IntPtr)num7);
											continue;
										}
										goto IL_21E;
									}
									case 1:
										if (systemType2.GetValueOrDefault() == systemType3.GetValueOrDefault() & systemType2 != null == (systemType3 != null))
										{
											num7 = (short)1331232772;
											num8 = (int)((global::System.IntPtr)num7);
											continue;
										}
										goto IL_21E;
									case 2:
										goto IL_183;
									case 3:
										num7 = (short)553844741;
										num8 = (int)((global::System.IntPtr)num7);
										continue;
									case 4:
									{
										num7 = (short)1490878464;
										short num10 = num7;
										global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? systemSubType2 = s.SystemSubType;
										global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType? systemSubType3 = CS$<>8__locals1.system.SystemSubType;
										num7 = (short)1175584768;
										num8 = (int)((global::System.IntPtr)num7);
										continue;
									}
									case 5:
										goto IL_14F;
									}
									goto IL_91;
								}
								IL_183:
								int? systemId = s.SystemId;
								int? systemId2 = CS$<>8__locals1.system.SystemId;
								return systemId.GetValueOrDefault() == systemId2.GetValueOrDefault() & systemId != null == (systemId2 != null);
								IL_91:
								systemType2 = s.SystemType;
								systemType3 = CS$<>8__locals1.system.SystemType;
								num7 = (short)507052033;
								num8 = (int)((global::System.IntPtr)num7);
								goto IL_72;
								IL_21E:
								num7 = (short)920977409;
								if (num7 != 0)
								{
								}
								return false;
							}
							}
						});
						num = (short)1032454188;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem> source2;
						CS$<>8__locals1.system.RadioId = source2.FirstOrDefault<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>().RadioId;
						num = (short)938999809;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)910032925;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						return list;
					case 6:
					{
						global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem> source2;
						CS$<>8__locals1.system.RadioId = source2.FirstOrDefault<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>().RadioId;
						num = (short)724566024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_979;
					case 8:
						goto IL_979;
					case 9:
						goto IL_979;
					case 10:
					{
						global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem> source2;
						CS$<>8__locals1.system.RadioId = source2.FirstOrDefault<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>().RadioId;
						num = (short)1610416168;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						int value;
						if (value >= 1)
						{
							num = (short)42074116;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E7;
					}
					case 12:
						num = (short)607780899;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						num = (short)1611137024;
						short num3 = num;
						global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem[] array = array2;
						num4 = 0;
						num = (short)2036269075;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_979;
					case 15:
						num = (short)122290219;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						int value;
						if (value >= 1)
						{
							num = (short)387514417;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CF;
					}
					case 17:
						goto IL_979;
					case 18:
						goto IL_979;
					case 19:
						goto IL_4A6;
					case 20:
						if (isApply)
						{
							num = (short)951386127;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_979;
					case 21:
						if (!CS$<>8__locals1.system.ExpandedMDCIDRange)
						{
							num = (short)165609510;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2060582942;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
					{
						int value;
						if (value <= 16777211)
						{
							num = (short)95682563;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_35C;
					}
					case 23:
						goto IL_979;
					case 24:
						if (!(systemSubType.GetValueOrDefault() == astroSystemSubType & systemSubType != null))
						{
							num = (short)2050949148;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_979;
					case 25:
						num = (short)742653974;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						goto IL_252;
					case 27:
						if (array2 != null)
						{
							num = (short)1101266957;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return list;
					case 28:
						CS$<>8__locals1.system.RadioId = new int?(0);
						num = (short)1563688978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
					{
						int value;
						if (value <= 57070)
						{
							num = (short)2122907689;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E7;
					}
					case 30:
					{
						int value;
						if (value >= 1)
						{
							num = (short)481296415;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3BA;
					}
					case 31:
						num = (short)826867757;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
					{
						global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem> source2;
						CS$<>8__locals1.system.RadioId = source2.FirstOrDefault<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>().RadioId;
						num = (short)660996113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
					{
						string text;
						if (!text.Contains(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("\uda9b", a_)))
						{
							num = (short)86442016;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E7;
					}
					case 34:
						num = (short)1137836053;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
					{
						int value;
						if (value >= 1)
						{
							num = (short)1452867609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_35C;
					}
					case 36:
					{
						global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem[] array;
						if (num4 >= array.Length)
						{
							num = (short)1674969093;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem system = array[num4];
						num = (short)439746580;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 37:
						goto IL_4A6;
					case 38:
					{
						int value;
						string text = value.ToString(global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("쒛", a_), global::System.Globalization.CultureInfo.InvariantCulture).ToUpperInvariant();
						num = (short)115867659;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
					{
						int value;
						if (value <= 9999999)
						{
							num = (short)581763082;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CF;
					}
					case 40:
						goto IL_979;
					case 41:
						num = (short)987037729;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						if (systemSubType.GetValueOrDefault() == astroSystemSubType & systemSubType != null)
						{
							num = (short)970522658;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						systemSubType = CS$<>8__locals1.system.SystemSubType;
						astroSystemSubType = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.DVRS;
						num = (short)298647578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						if (target.APXRadioSystems != null)
						{
							num = (short)331546626;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_979;
					case 44:
					{
						global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem> source2;
						if (source2.Count<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>() == 1)
						{
							num = (short)1579548718;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						systemSubType = CS$<>8__locals1.system.SystemSubType;
						astroSystemSubType = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.QCII;
						num = (short)184614936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 45:
					{
						int value;
						if (value <= 65534)
						{
							num = (short)1377566726;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3BA;
					}
					case 46:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType = CS$<>8__locals1.system.SystemType;
						global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType astroSystemType = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.CONVENTIONAL;
						num = (short)1961492480;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 47:
						goto IL_979;
					case 48:
					{
						global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem> source2;
						int value = source2.FirstOrDefault<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>().RadioId.Value;
						systemSubType = CS$<>8__locals1.system.SystemSubType;
						astroSystemSubType = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemSubType.MDC;
						num = (short)264765482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 49:
					{
						num = (short)97274565;
						short num5 = num;
						num = (short)1897548485;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_252;
						default:
							num = (short)765919232;
							if (num != 0)
							{
							}
							num = (short)1559560231;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_126;
					IL_252:
					if (systemSubType.GetValueOrDefault() == astroSystemSubType & systemSubType != null)
					{
						num = (short)763625484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1015808016;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2CF:
					CS$<>8__locals1.system.RadioId = new int?(0);
					num = (short)545194031;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_35C:
					CS$<>8__locals1.system.RadioId = new int?(0);
					num = (short)1824784398;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3BA:
					CS$<>8__locals1.system.RadioId = new int?(0);
					num = (short)1463156745;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4A6:
					num = (short)182255652;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4E7:
					CS$<>8__locals1.system.RadioId = new int?(0);
					num = (short)1920663559;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_979:
					CS$<>8__locals1.system.OrderId = new int?(num6);
					list.Add(CS$<>8__locals1.system);
					num6++;
					num4++;
					num = (short)610795557;
					num2 = (int)((global::System.IntPtr)num);
				}
				return list;
				IL_126:
				list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>();
				array2 = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceUtility.XMLToEntityCollections<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>(source.RadioSystems);
				num6 = 1;
				num = (short)337117211;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_57;
			}
			}
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00078A8C File Offset: 0x00076C8C
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile> CloneDataProfile(global::Motorola.CommonCPS.Server.EntityModel.APXTemplate source, global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug target, bool isApply = true)
		{
			short num = (short)1063976960;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5B;
				}
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile> list;
				int num4;
				global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile[] array;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						if (target.APXDataProfiles != null)
						{
							num = (short)323485703;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DA;
					case 1:
						if (isApply)
						{
							num = (short)878641158;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DA;
					case 2:
						goto IL_318;
					case 3:
						goto IL_219;
					case 4:
					{
						num = (short)664797184;
						short num3 = num;
						num = (short)673579009;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile> source2;
						global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile apxdataProfile = source2.FirstOrDefault<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>();
						CS$<>8__locals1.profile.PeerIP = apxdataProfile.PeerIP;
						CS$<>8__locals1.profile.SubscriberIP = apxdataProfile.SubscriberIP;
						CS$<>8__locals1.profile.AirInterfaceAddress = apxdataProfile.AirInterfaceAddress;
						CS$<>8__locals1.profile.AstroBluetoothDunPeerIp = apxdataProfile.AstroBluetoothDunPeerIp;
						CS$<>8__locals1.profile.AstroBluetoothDunSubscriberIp = apxdataProfile.AstroBluetoothDunSubscriberIp;
						num = (short)882376706;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_219;
					case 6:
						num = (short)1186267136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile> source2 = target.APXDataProfiles.Where(delegate(global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile p)
						{
							short num7;
							if (p.Name.Equals(CS$<>8__locals1.profile.Name))
							{
								num7 = (short)1462810271;
								short num8 = num7;
								num7 = (short)547010207;
								switch ((num8 == num7) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
								{
									num7 = (short)1812660224;
									if (num7 != 0)
									{
									}
									num7 = (short)826015744;
									short num9 = num7;
									int? systemType = p.SystemType;
									int? systemType2 = CS$<>8__locals1.profile.SystemType;
									return systemType.GetValueOrDefault() == systemType2.GetValueOrDefault() & systemType != null == (systemType2 != null);
								}
								}
							}
							num7 = (short)38862849;
							if (num7 != 0)
							{
							}
							return false;
						});
						num = (short)2126774282;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						return list;
					case 9:
					{
						if (num4 >= array.Length)
						{
							num = (short)1151664136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile profile = array[num4];
						num = (short)969342977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile> source2;
						if (source2.Count<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>() == 1)
						{
							num = (short)328728580;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DA;
					}
					}
					goto IL_5B;
					IL_219:
					num = (short)674234377;
					num2 = (int)((global::System.IntPtr)num);
				}
				return list;
				IL_5B:
				list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>();
				global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile[] array2 = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceUtility.XMLToEntityCollections<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>(source.DataProfiles);
				int num5 = 1;
				array = array2;
				num4 = 0;
				num = (short)566224582;
				short num6 = num;
				num = (short)1449191110;
				switch ((num6 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_318:
					break;
				default:
					num = (short)817627136;
					if (num != 0)
					{
					}
					num = (short)1588592643;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				IL_DA:
				CS$<>8__locals1.profile.OrderId = new int?(num5);
				list.Add(CS$<>8__locals1.profile);
				num5++;
				num4++;
				num = (short)1625227269;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00078DB8 File Offset: 0x00076FB8
		public void CloneConstraintFields(global::Motorola.CommonCPS.Server.EntityModel.APXRadio targetRadio, global::Motorola.CommonCPS.Server.EntityModel.APXTemplate source)
		{
			short num = (short)1362100224;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_146;
				}
				global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug;
				bool? flag;
				for (;;)
				{
					IL_27:
					int? num3;
					int num4;
					global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug apxcodeplug2;
					string flashCode;
					switch (num2)
					{
					case 0:
						num3 = apxcodeplug.HomeSystemId;
						num = (short)350552068;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (num3 != null)
						{
							num = (short)1141309443;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_57B;
					case 2:
						if (num3.GetValueOrDefault() == num4 & num3 != null)
						{
							num = (short)900333608;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_369;
					case 3:
						goto IL_C96;
					case 4:
						if (num3 != null)
						{
							num = (short)1879965719;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_328;
					case 5:
						if (flag != null)
						{
							num = (short)1649672222;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_846;
					case 6:
						goto IL_457;
					case 7:
						goto IL_328;
					case 8:
						goto IL_200;
					case 9:
						apxcodeplug.AstroOtarEnable = source.AstroOtarEnable;
						num = (short)328859708;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_5FE;
					case 11:
						if (targetRadio.CurrentCodeplug == null)
						{
							num = (short)689111105;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2037514253;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_364;
					case 13:
						if (targetRadio != null)
						{
							num = (short)1938948141;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 14:
						apxcodeplug.BluetoothPANNetworkBaseAddress = source.BluetoothPANNetworkBaseAddress;
						num = (short)474349615;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (num3 != null)
						{
							num = (short)1005912096;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7BB;
					case 16:
						num3 = apxcodeplug.OwnerWacnId;
						num = (short)1539506227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						num = (short)999686155;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_8FB;
					case 19:
						goto IL_801;
					case 20:
						if (num3.GetValueOrDefault() == num4 & num3 != null)
						{
							num = (short)335544320;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_66E;
					case 21:
						apxcodeplug.DVRSHardwareEnable = source.DVRSHardwareEnable;
						num = (short)112787482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (num3 != null)
						{
							num = (short)1875968059;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_200;
					case 23:
						goto IL_66E;
					case 24:
						if (flag != null)
						{
							num = (short)1649737796;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5FE;
					case 25:
						if (targetRadio.CurrentCodeplug != null)
						{
							num = (short)775553057;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 26:
						goto IL_2DE;
					case 27:
						num3 = apxcodeplug.OwnerAdvKeyType;
						num = (short)215941174;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						apxcodeplug.RadioAliasEnable = source.RadioAliasEnable;
						num = (short)1685061650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						apxcodeplug.P25LocationReporting = source.P25LocationReporting;
						num = (short)1393885248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						apxcodeplug.BluetoothEnable = source.BluetoothEnable;
						num = (short)1835663398;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						if (flag != null)
						{
							num = (short)1507917833;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6F0;
					case 32:
						apxcodeplug.BluetoothDunPeerIpAssignmentType = source.BluetoothDunPeerIpAssignmentType;
						num = (short)1316552762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						apxcodeplug2 = (targetRadio.CurrentCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
						num3 = apxcodeplug2.OwnerAdvKeyType;
						num = (short)1833107519;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						num3 = apxcodeplug.OwnerAdvKeyType;
						num4 = 0;
						num = (short)1009844244;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						if (flag != null)
						{
							num = (short)988807230;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_801;
					case 36:
						if (source.BluetoothPANNetworkBaseAddress != null)
						{
							num = (short)292225038;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A03;
					case 37:
						num3 = apxcodeplug2.OwnerAdvKeyType;
						num4 = 0;
						num = (short)1756561449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						goto IL_846;
					case 39:
						if (num3.GetValueOrDefault() == num4 & num3 != null)
						{
							num = (short)523304976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_19C;
					case 40:
						num3 = apxcodeplug2.OwnerWacnId;
						num = (short)1785987078;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						if (num3.GetValueOrDefault() == num4 & num3 != null)
						{
							num = (short)23199800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C96;
					case 42:
						goto IL_369;
					case 43:
						goto IL_57B;
					case 44:
						if (flag != null)
						{
							num = (short)1489633309;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B05;
					case 45:
						num = (short)997654553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						if (flag != null)
						{
							num = (short)926941212;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8FB;
					case 47:
						goto IL_A03;
					case 48:
						if (flag == null)
						{
							num = (short)324993073;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = apxcodeplug2.AskRequired;
						num = (short)963903555;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						goto IL_3AD;
					case 50:
						if (flag != null)
						{
							num = (short)1385168957;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A4B;
					case 51:
						num = (short)1074790401;
						if (num != 0)
						{
						}
						if (num3 == null)
						{
							num = (short)636420103;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_19C;
					case 52:
						if (flag != null)
						{
							num = (short)777256981;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2DE;
					case 53:
						if (global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().AstroParseFlashCode(flashCode, source.ModelNumber).ContainsKey(32))
						{
							num = (short)31719451;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CF0;
					case 54:
						if (num3 != null)
						{
							num = (short)1590558754;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_328;
					case 55:
						if (targetRadio != null)
						{
							num = (short)897908753;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_892;
					case 56:
					{
						num3 = apxcodeplug2.HomeSystemId;
						num = (short)1245087458;
						short num5 = num;
						num = (short)2095548130;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_457;
						default:
							num = (short)939458560;
							if (num != 0)
							{
							}
							num = (short)622919681;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 57:
						apxcodeplug.AskRequired = new bool?(false);
						num = (short)701890629;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
						goto IL_7BB;
					case 59:
					{
						num = (short)433520640;
						short num6 = num;
						apxcodeplug.SecureOperation = source.SecureOperation;
						num = (short)371916808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 60:
						goto IL_6F0;
					case 61:
						apxcodeplug.OtarEnable = source.OtarEnable;
						num = (short)487260226;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
						apxcodeplug.AESEnable = source.AESEnable;
						num = (short)1610874899;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
						if (num3 != null)
						{
							num = (short)1503199269;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_57B;
					case 64:
						goto IL_B05;
					case 65:
						goto IL_892;
					case 66:
						goto IL_A4B;
					case 67:
						if (flag == null)
						{
							num = (short)632356921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 68:
						apxcodeplug.LocationEnable = source.LocationEnable;
						num = (short)63963146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
						goto IL_4A7;
					}
					goto IL_146;
					IL_200:
					flag = source.AESEnable;
					num = (short)1699086371;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2DE:
					flag = source.AstroOtarEnable;
					num = (short)1536360479;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_328:
					apxcodeplug.OwnerAdvKeyType = source.OwnerAdvKeyType;
					apxcodeplug.HomeSystemId = source.HomeSystemId;
					apxcodeplug.OwnerWacnId = source.OwnerWacnId;
					num = (short)90112012;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_369:
					flag = apxcodeplug2.DisableWriteProtect;
					num = (short)838926384;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_457:
					if (num3 == null)
					{
						num = (short)790298667;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_369;
					IL_57B:
					apxcodeplug.OwnerAdvKeyType = new int?(0);
					apxcodeplug.HomeSystemId = new int?(0);
					apxcodeplug.OwnerWacnId = new int?(0);
					num = (short)1800405034;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5FE:
					flag = source.P25LocationReporting;
					num = (short)1810825260;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_66E:
					num3 = apxcodeplug.OwnerAdvKeyType;
					num4 = 1;
					num = (short)1221263399;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6F0:
					num3 = source.SecureOperation;
					num = (short)1150287894;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7BB:
					flag = source.BluetoothEnable;
					num = (short)250085381;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_801:
					num3 = source.BluetoothDunPeerIpAssignmentType;
					num = (short)1427963919;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_846:
					flag = source.LocationEnable;
					num = (short)884080664;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_892:
					new global::System.Collections.Generic.Dictionary<int, string>();
					flashCode = global::Motorola.CommonCPS.RadioManagement.SharedServices.RMCExportInterface.GetInstance().AstroDecodeFlashCode(source.AstroPurchasedFlashCode);
					num = (short)623312949;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8FB:
					flag = source.OtarEnable;
					num = (short)676397106;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A03:
					num = (short)1080754231;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A4B:
					flag = source.DVRSHardwareEnable;
					num = (short)458096692;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B05:
					apxcodeplug.UserNameDisplayTextSize = new int?(source.UserNameDisplayTextSize);
					apxcodeplug.UserLoginUnitIDTextSize = new int?(source.UserLoginUnitIDTextSize);
					apxcodeplug.UserLoginUnitIDEnable = new bool?(source.UserLoginUnitIDEnable);
					num = (short)1392574500;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C96:
					num3 = apxcodeplug2.OwnerAdvKeyType;
					num4 = 1;
					num = (short)1673199618;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_19C:
				apxcodeplug.DisableWriteProtect = new bool?(false);
				apxcodeplug.AskRequired = new bool?(true);
				return;
				IL_364:
				goto IL_19C;
				IL_3AD:
				apxcodeplug.DisableWriteProtect = new bool?(false);
				return;
				IL_4A7:
				return;
				IL_CF0:
				apxcodeplug.OwnerAdvKeyType = new int?(0);
				apxcodeplug.HomeSystemId = new int?(0);
				apxcodeplug.OwnerWacnId = new int?(0);
				apxcodeplug.DisableWriteProtect = new bool?(false);
				apxcodeplug.AskRequired = new bool?(false);
				return;
				IL_146:
				apxcodeplug = (targetRadio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug);
				flag = source.RadioAliasEnable;
				num = (short)465174574;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00079AF4 File Offset: 0x00077CF4
		public override global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> PrepareUploadTemplateAndRadio(global::Motorola.CommonCPS.Server.EntityModel.Template source, global::Motorola.CommonCPS.Server.EntityModel.Radio targetDevice, bool isApply = true)
		{
			short num = (short)1981874176;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B2;
				}
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> result;
				global::Motorola.CommonCPS.Server.EntityModel.APXRadio apxradio;
				bool flag;
				global::Motorola.CommonCPS.Server.EntityModel.APXTemplate apxtemplate;
				bool flag2;
				string message;
				for (;;)
				{
					IL_27:
					int? num5;
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem>.Enumerator enumerator2;
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem> apxradioSystems;
					int? num7;
					int num8;
					switch (num2)
					{
					case 0:
						goto IL_286;
					case 1:
						return result;
					case 2:
						if (apxradio.WorkingCodeplug == null)
						{
							num = (short)1946812437;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_286;
					case 3:
					{
						global::System.Guid? templateUuid;
						if (templateUuid.Equals(source.Uuid))
						{
							num = (short)2067267613;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_45C;
					}
					case 4:
						if (flag)
						{
							num = (short)1908342816;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 5:
						flag2 = this.a(apxtemplate, apxradio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug, apxradio.ModelNumber);
						num = (short)543490060;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						num = (short)699662336;
						short num3 = num;
						int? num4 = null;
						num = (short)734134285;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (apxradio.CurrentCodeplug != null)
						{
							num = (short)533135391;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_761;
					case 8:
					{
						global::System.Guid? templateUuid = apxradio.WorkingCodeplug.TemplateUuid;
						num = (short)1112408067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_45C;
					case 10:
						goto IL_698;
					case 11:
					{
						global::System.Guid? templateUuid;
						if (templateUuid != null)
						{
							num = (short)1221656595;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_761;
					}
					case 12:
						goto IL_5E6;
					case 13:
					{
						int? num4;
						num5 = num4;
						goto IL_409;
					}
					case 14:
						apxradio.WorkingCodeplug.CodeplugVersion = apxtemplate.CodeplugVersion;
						apxradio.WorkingCodeplug.FirmwareVersion = apxtemplate.FirmwareVersion;
						((global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug)apxradio.WorkingCodeplug).AstroEnableFlashCode = ((global::Motorola.CommonCPS.Server.EntityModel.APXTemplate)source).AstroEnableFlashCode;
						((global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug)apxradio.WorkingCodeplug).AstroPurchasedFlashCode = ((global::Motorola.CommonCPS.Server.EntityModel.APXTemplate)source).AstroPurchasedFlashCode;
						flag2 = true;
						flag = true;
						num = (short)788070416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						int? changeIndicator;
						num5 = new int?(changeIndicator.GetValueOrDefault() & 16);
						goto IL_409;
					}
					case 16:
						goto IL_5E6;
					case 17:
					{
						int? changeIndicator;
						if (changeIndicator == null)
						{
							num = (short)1532690438;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2127101967;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						try
						{
							num = (short)1567686656;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_4DA;
									}
									continue;
								case 2:
									num = (short)1482293252;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)784465922;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile item = enumerator.Current;
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile> apxdataProfiles;
									apxdataProfiles.Add(item);
									num = (short)212533249;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_553;
								}
								IL_4DC:
								num = (short)609878019;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4DA:
								goto IL_4DC;
							}
							IL_553:
							goto IL_7A8;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_566;
						IL_7A8:
						num = (short)857735172;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)687865857;
						if (num != 0)
						{
						}
						num = (short)129105945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (flag2)
						{
							num = (short)1957494807;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 21:
						goto IL_248;
					case 22:
						if (apxradio.WorkingCodeplug.Template != null)
						{
							num = (short)1923874824;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_719;
					case 23:
						goto IL_566;
					case 24:
					{
						try
						{
							num = (short)276758528;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									num = (short)904729668;
									short num6 = num;
									num = (short)2026574916;
									switch ((num6 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_1DC;
									default:
										num = (short)1570832384;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_1BC;
										}
										continue;
									}
									break;
								}
								case 2:
									num = (short)1354301444;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									if (!enumerator2.MoveNext())
									{
										goto IL_1DC;
									}
									global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem item2 = enumerator2.Current;
									apxradioSystems.Add(item2);
									num = (short)827654145;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_235;
								}
								IL_1BE:
								num = (short)1191051267;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1BC:
								goto IL_1BE;
								IL_1DC:
								num = (short)361234434;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_235:
							goto IL_6C6;
						}
						finally
						{
							((global::System.IDisposable)enumerator2).Dispose();
						}
						goto IL_248;
						IL_6C6:
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile> apxdataProfiles = (apxradio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).APXDataProfiles;
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile> list = this.CloneDataProfile(apxtemplate, apxradio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug, isApply);
						apxdataProfiles.Clear();
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXDataProfile>.Enumerator enumerator = list.GetEnumerator();
						num = (short)1417674770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						if (!this.a(apxtemplate, apxradio.CurrentCodeplug, apxradio.ModelNumber, out message))
						{
							num = (short)1217331210;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_761;
					case 26:
					{
						if (apxradio.WorkingCodeplug.Template == null)
						{
							num = (short)538181646;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int? changeIndicator = apxradio.WorkingCodeplug.ChangeIndicator;
						num = (short)466092049;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						if (!(num7.GetValueOrDefault() == num8 & num7 != null))
						{
							num = (short)1826357253;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag2 = this.a(apxtemplate, apxradio.CurrentCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug, apxradio.ModelNumber);
						num = (short)558039068;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						goto IL_5E6;
					case 29:
						goto IL_719;
					case 30:
						if (apxradio.WorkingCodeplug.Template == null)
						{
							num = (short)1243414537;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 31:
					{
						global::System.Guid? templateUuid = apxradio.CurrentCodeplug.TemplateUuid;
						num = (short)60162059;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
					{
						apxradio.ModelNumber = source.ModelNumber;
						apxradio.ProductFamily = source.ProductFamily;
						int num9 = 0;
						global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().PopulateRadioFeaturesFromCodeplug(apxradio, source, out num9);
						result = this.a(apxradio);
						num = (short)2056388609;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_B2;
					IL_248:
					apxradio.WorkingCodeplug = new global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug
					{
						RadioUuid = new global::System.Guid?(apxradio.Uuid)
					};
					num = (short)2080047104;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_286:
					num = (short)1676214294;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_409:
					num7 = num5;
					num8 = 0;
					num = (short)1205731355;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_45C:
					num = (short)2109407239;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_566:
					apxradio.WorkingCodeplug.TemplateUuid = new global::System.Guid?(source.Uuid);
					apxradio.WorkingCodeplug.Template = source;
					this.CloneConstraintFields(apxradio, apxtemplate);
					apxradioSystems = (apxradio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug).APXRadioSystems;
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.APXRadioSystem> list2 = this.CloneRadioSystem(apxtemplate, apxradio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug, isApply);
					apxradioSystems.Clear();
					enumerator2 = list2.GetEnumerator();
					num = (short)1094385688;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5E6:
					num = (short)1960706068;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_719:
					num = (short)1224081438;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_761:
					num = (short)1293090842;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_698:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error, message);
				IL_B2:
				flag2 = true;
				flag = false;
				result = null;
				apxtemplate = (source as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate);
				apxradio = (targetDevice as global::Motorola.CommonCPS.Server.EntityModel.APXRadio);
				num = (short)1250164738;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x0007A458 File Offset: 0x00078658
		public override bool CloneCheck(global::Motorola.CommonCPS.Server.EntityModel.Template source, global::Motorola.CommonCPS.Server.EntityModel.Radio targetDevice, global::Motorola.CommonCPS.RadioManagement.CommonBase.Enums.CommandType? cmdType)
		{
			short num = (short)1797455872;
			switch (num)
			{
			default:
			{
				num = (short)1894776864;
				int num2 = (int)((global::System.IntPtr)num);
				string message;
				for (;;)
				{
					global::Motorola.CommonCPS.Server.EntityModel.APXTemplate apxtemplate;
					global::Motorola.CommonCPS.Server.EntityModel.APXRadio apxradio;
					bool flag;
					int? num3;
					bool flag3;
					bool flag4;
					int num6;
					int? num7;
					switch (num2)
					{
					case 0:
						num = (short)227213348;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_2EA;
					case 2:
						if (!this.a(apxtemplate, apxradio.CurrentCodeplug, apxradio.ModelNumber, out message))
						{
							num = (short)1552023557;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4DF;
					case 3:
						num = (short)1039269910;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (apxradio.WorkingCodeplug != null)
						{
							num = (short)1665400871;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 5:
						goto IL_193;
					case 6:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles>.Enumerator enumerator = apxtemplate.ASTRODVRSFiles.GetEnumerator();
						num = (short)1561722910;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_2EA;
					case 8:
					{
						bool? dvrshardwareEnable;
						bool flag2;
						if (dvrshardwareEnable.GetValueOrDefault() == flag2 & dvrshardwareEnable != null)
						{
							num = (short)1663959046;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					}
					case 9:
						if (num3 != null)
						{
							num = (short)2026766365;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C3;
					case 10:
						num = (short)1310261261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)775553066;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						global::System.Guid? templateUuid;
						if (templateUuid != null)
						{
							num = (short)303366168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4DF;
					}
					case 13:
						if (apxradio.CurrentCodeplug != null)
						{
							num = (short)1582432293;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4DF;
					case 14:
						if (apxradio.WorkingCodeplug != null)
						{
							num = (short)1680932880;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3AA;
					case 15:
					{
						global::System.Guid? templateUuid;
						global::System.Guid uuid;
						flag3 = (templateUuid.GetValueOrDefault() == uuid);
						goto IL_38A;
					}
					case 16:
					{
						global::System.Guid? templateUuid = apxradio.WorkingCodeplug.TemplateUuid;
						global::System.Guid uuid = apxtemplate.Uuid;
						num = (short)1916731435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_3A5;
					case 18:
						flag4 = false;
						goto IL_60D;
					case 19:
					{
						int? num4 = null;
						num = (short)1220083753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						return true;
					case 21:
					{
						num = (short)658964481;
						if (num != 0)
						{
						}
						bool? dvrshardwareEnable = apxtemplate.DVRSHardwareEnable;
						bool flag2 = true;
						num = (short)157941768;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						flag3 = true;
						goto IL_38A;
					case 23:
						if (apxradio.WorkingCodeplug != null)
						{
							num = (short)2037841953;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2EA;
					case 24:
						num = (short)570687490;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						global::System.Guid? templateUuid;
						if (templateUuid == null)
						{
							num = (short)197787648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)594280476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
					{
						global::System.Guid? templateUuid;
						if (templateUuid == null)
						{
							num = (short)1952972803;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1394606095;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						if (flag)
						{
							num = (short)1634992149;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 28:
					{
						global::System.Guid? templateUuid;
						global::System.Guid uuid;
						flag4 = (templateUuid.GetValueOrDefault() == uuid);
						goto IL_60D;
					}
					case 29:
					{
						int? changeIndicator = apxradio.WorkingCodeplug.ChangeIndicator;
						num = (short)1103364131;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
						try
						{
							num = (short)1115684871;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_8F7;
								case 1:
									num = (short)1327693828;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1005780997;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles astrodvrsfiles = enumerator.Current;
									num = (short)591593478;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_8D1;
								case 4:
								{
									global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles astrodvrsfiles;
									if (!this.a(astrodvrsfiles))
									{
										num = (short)1606746115;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									num = (short)334919658;
									short num5 = num;
									num = (short)1771796458;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_878;
									default:
										num = (short)750583808;
										if (num != 0)
										{
										}
										num = (short)888602624;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles astrodvrsfiles;
									if (astrodvrsfiles.Uuid != global::System.Guid.Empty)
									{
										goto IL_878;
									}
									break;
								}
								case 7:
									switch (0)
									{
									case 0:
										goto IL_7BA;
									}
									continue;
								}
								IL_7BC:
								num = (short)2066415618;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_7BA:
								goto IL_7BC;
								IL_878:
								num = (short)881262593;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_8D1:
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_DVRS_File_Version_Not_Allowed);
							IL_8F7:
							return flag;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_90A;
					case 31:
					{
						global::System.Guid? templateUuid;
						if (templateUuid == null)
						{
							num = (short)1701117996;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1937178649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
						switch (0)
						{
						case 0:
							goto IL_F7;
						}
						continue;
					case 33:
						num3 = apxradio.WorkingCodeplug.ChangeIndicator;
						num = (short)119406601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						if (!(num3.GetValueOrDefault() == num6 & num3 != null))
						{
							num = (short)987562024;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C3;
					case 35:
					{
						int? changeIndicator;
						if (changeIndicator == null)
						{
							num = (short)914161683;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1285423142;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 36:
						flag4 = true;
						goto IL_60D;
					case 37:
					{
						global::System.Guid? templateUuid = apxradio.CurrentCodeplug.TemplateUuid;
						num = (short)322633740;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 38:
					{
						int? changeIndicator;
						num7 = new int?(changeIndicator.GetValueOrDefault() & 16);
						goto IL_90A;
					}
					case 39:
					{
						global::System.Guid? templateUuid = apxradio.WorkingCodeplug.TemplateUuid;
						global::System.Guid uuid = apxtemplate.Uuid;
						num = (short)24182815;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 40:
						flag = this.a(apxtemplate, apxradio.WorkingCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug, apxradio.ModelNumber);
						num = (short)1743257601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
					{
						int? num4;
						num7 = num4;
						goto IL_90A;
					}
					case 42:
						flag3 = false;
						goto IL_38A;
					case 43:
					{
						global::System.Guid? templateUuid;
						if (templateUuid == null)
						{
							num = (short)432144395;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1788280858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 44:
						num = (short)408682514;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_F7:
					if (targetDevice.RadioStatus == 0)
					{
						num = (short)1894711316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					flag = false;
					apxtemplate = (source as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate);
					apxradio = (targetDevice as global::Motorola.CommonCPS.Server.EntityModel.APXRadio);
					num = (short)203096078;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C3:
					flag = this.a(apxtemplate, apxradio.CurrentCodeplug as global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug, apxradio.ModelNumber);
					num = (short)975110151;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2EA:
					num = (short)510459931;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_38A:
					if (flag3)
					{
						num = (short)1258356753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_3AA:
					num = (short)529334276;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4DF:
					num = (short)1789001751;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_60D:
					if (!flag4)
					{
						num = (short)1619853322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return flag;
					IL_90A:
					num3 = num7;
					num6 = 0;
					num = (short)236126208;
					short num8 = num;
					num = (short)149159970;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_193:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_Generic_Error, message);
				IL_3A5:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Radio_Already_Applied_This_Template);
			}
			}
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x0007AE08 File Offset: 0x00079008
		public override void UpLoadVAFile(global::Motorola.CommonCPS.Server.EntityModel.Template template)
		{
			short num = (short)1101864264;
			short num2 = num;
			num = (short)1446976840;
			switch (num2 == num)
			{
			}
			num = (short)2146631680;
			if (num != 0)
			{
			}
			num = (short)199426048;
			short num3 = num;
			num = (short)313458689;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> vaPackages = (template as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate).ASTROVoiceAnnouncements.ToList<global::Motorola.CommonCPS.Server.EntityModel.Package>();
			base.UploadVAPackages(vaPackages);
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x0007AED0 File Offset: 0x000790D0
		public override void UpLoadCACertificateFile(global::Motorola.CommonCPS.Server.EntityModel.Template template)
		{
			short num = (short)1207279793;
			short num2 = num;
			num = (short)1769185457;
			switch (num2 == num)
			{
			}
			num = (short)649592833;
			if (num != 0)
			{
			}
			num = (short)397606912;
			short num3 = num;
			num = (short)2018115584;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> caCertificatePackages = (template as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate).ASTROCACertificates.ToList<global::Motorola.CommonCPS.Server.EntityModel.Package>();
			base.UploadCACertificatePackages(caCertificatePackages);
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x0007AF90 File Offset: 0x00079190
		public override void UpLoadDVRSFile(global::Motorola.CommonCPS.Server.EntityModel.Template template)
		{
			short num = (short)320324433;
			short num2 = num;
			num = (short)62571345;
			switch (num2 == num)
			{
			}
			num = (short)1336868865;
			if (num != 0)
			{
			}
			num = (short)1089011712;
			short num3 = num;
			num = (short)1156513792;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Package> dVRSFilePackages = (template as global::Motorola.CommonCPS.Server.EntityModel.APXTemplate).ASTRODVRSFiles.ToList<global::Motorola.CommonCPS.Server.EntityModel.Package>();
			base.UploadDVRSFilePackages(dVRSFilePackages);
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x0007B054 File Offset: 0x00079254
		public override string GetArchieveFileTypeOfPAC()
		{
			int a_ = 18;
			short num = (short)1666744245;
			short num2 = num;
			num = (short)218988469;
			switch (num2 == num)
			{
			}
			num = (short)221315073;
			if (num != 0)
			{
			}
			num = (short)686817280;
			short num3 = num;
			num = (short)1435107328;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.SharedServices.SyncDataForASTROUpgradeForTemplateMode.b("螨욪캬", a_);
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0007B114 File Offset: 0x00079314
		private bool a(global::Motorola.CommonCPS.Server.EntityModel.Template A_0, global::Motorola.CommonCPS.Server.EntityModel.Codeplug A_1, string A_2, out string A_3)
		{
			short num = (short)1435500547;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)2047336571;
				short num3 = num;
				num = (short)140828795;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return true;
				default:
					num = (short)1893400576;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						num = (short)996343815;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1C2;
					case 2:
						if (A_1 == null)
						{
							num = (short)1874264065;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						A_3 = string.Empty;
						num = (short)1492713476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_90;
						}
						continue;
					case 4:
						if (A_0.CodeplugVersion.Substring(0, 1).Equals(A_1.CodeplugVersion.Substring(0, 1), global::System.StringComparison.Ordinal))
						{
							num = (short)832176129;
							if (num != 0)
							{
							}
							num = (short)697630720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F5;
					case 5:
						goto IL_102;
					case 6:
						num = (short)1865809922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (A_0.ModelNumber.Substring(0, 3).Equals(A_2.Substring(0, 3), global::System.StringComparison.Ordinal))
						{
							num = (short)1864564741;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F5;
					}
					IL_90:
					if (A_0 == null)
					{
						goto IL_1C6;
					}
					num = (short)547160070;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_102:
			return true;
			IL_1C2:
			IL_1C6:
			num = (short)182124544;
			short num4 = num;
			throw new global::System.ArgumentNullException();
			IL_1F5:
			A_3 = global::Motorola.CommonCPS.ResourceRepository.Resources.SelectTemplate_Dismatch_Error;
			return false;
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x0007B320 File Offset: 0x00079520
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> a(global::Motorola.CommonCPS.Server.EntityModel.Radio device)
		{
			short num = (short)1779499008;
			switch (num)
			{
			default:
			{
				num = (short)1908736003;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> list;
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest>();
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature>.Enumerator enumerator = device.RadioFeatures.GetEnumerator();
						num = (short)2043740162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (device.RadioFeatures.Count > 0)
						{
							num = (short)162070528;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24A;
					case 2:
						num = (short)1764491265;
						if (num != 0)
						{
						}
						try
						{
							num = (short)166133763;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									num = (short)1535354839;
									short num3 = num;
									num = (short)454207447;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_1A1;
									default:
										num = (short)683540480;
										if (num != 0)
										{
										}
										num = (short)2041774082;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_1A1;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_B7;
									}
									continue;
								case 4:
								{
									global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)956825601;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.RadioFeature radioFeature = enumerator.Current;
									list.Add(new global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest(radioFeature.FeatureName, (global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureStatus)radioFeature.CurrentStatus, null, null, "", true));
									num = (short)1457717248;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_B9:
								num = (short)510132228;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_B7:
								goto IL_B9;
							}
							IL_1A1:
							return list;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeature>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1B1;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_57;
						}
						continue;
					case 4:
						goto IL_1B1;
					}
					IL_57:
					if (device.RadioFeatures != null)
					{
						num = (short)1142947844;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_24A;
					IL_1B1:
					num = (short)1095106561;
					num2 = (int)((global::System.IntPtr)num);
				}
				return list;
				IL_24A:
				num = (short)1207107584;
				short num4 = num;
				return null;
			}
			}
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x0007B5C0 File Offset: 0x000797C0
		private bool a(global::Motorola.CommonCPS.Server.EntityModel.APXTemplate A_0, global::Motorola.CommonCPS.Server.EntityModel.APXCodeplug A_1, string A_2)
		{
			short num = (short)965017602;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (A_1.AstroEnableFlashCode == null)
					{
						num = (short)1823211521;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FD;
				case 1:
					goto IL_AE;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 3:
					num = (short)1565130752;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_34:
				if (A_0.Codeplugs == null)
				{
					break;
				}
				num = (short)1795031043;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_52:
			num = (short)653983745;
			if (num != 0)
			{
			}
			return false;
			IL_AE:
			num = (short)1074569691;
			short num3 = num;
			num = (short)2007474651;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_52;
			default:
				num = (short)1128726528;
				if (num != 0)
				{
				}
				goto IL_52;
			}
			IL_FD:
			num = (short)100794368;
			short num4 = num;
			((global::Motorola.CommonCPS.RadioManagement.SharedServices.ITemplateOperation)global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance()).ValidateAstroCompatibility(A_1, A_0, A_2);
			return true;
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x0007B708 File Offset: 0x00079908
		private bool a(global::Motorola.CommonCPS.Server.EntityModel.ASTRODVRSFiles A_0)
		{
			short num = (short)751939599;
			short num2 = num;
			num = (short)1055502351;
			switch (num2 == num)
			{
			}
			num = (short)621150209;
			if (num != 0)
			{
			}
			num = (short)594280448;
			short num3 = num;
			num = (short)1376976896;
			if (num != 0)
			{
			}
			return int.Parse(A_0.PackageVersion) >= 2;
		}
	}
}
