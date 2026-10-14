using System;
using AcpBusinessLayer;
using AcpCommonLib;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.ConventionalSystem;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;

namespace SpecialFeatures.Ucl.Contact
{
	// Token: 0x02000215 RID: 533
	internal class UclContactConstraints
	{
		// Token: 0x06001B30 RID: 6960 RVA: 0x00230988 File Offset: 0x0022EB88
		internal static bool conUCLContactsValidity(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)538883637;
			short num2 = num;
			num = (short)1296676405;
			switch (num2 == num)
			{
			}
			num = (short)1668808705;
			if (num != 0)
			{
			}
			num = (short)734134272;
			if (num != 0)
			{
			}
			num = (short)991428608;
			short num3 = num;
			return true;
		}

		// Token: 0x06001B31 RID: 6961 RVA: 0x00230A34 File Offset: 0x0022EC34
		internal static bool conIsAstroSystemAliasValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			global::SpecialFeatures.Ucl.Contact.AstroCallListCallListSection astroCallListCallListSection;
			global::AcpBusinessLayer.AcpListField cnvSysGeneralSystemType_A;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1055981572;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_C2;
				case 2:
				{
					num2 = (short)639107073;
					if (num2 != 0)
					{
					}
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = ((global::AcpBusinessLayer.FeatureNode)astroCallListCallListSection.UclAstroCnv_SystemAlias_A00022Object.RefRecset[index - 1]) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
					cnvSysGeneralSystemType_A = conventionalSystem.General.CnvSysGeneralSystemType_A13262;
					num2 = (short)2041380864;
					short num3 = num2;
					num2 = (short)421789703;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (index != 0)
					{
						num2 = (short)1830748169;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 4:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem;
					if (conventionalSystem.General.ConvConfigConvSystemFeatRSISys_A41838.Value)
					{
						num2 = (short)200015873;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 5:
					if (astroCallListCallListSection.UclAstroCnv_SystemAlias_A00022Object.RefRecset != null)
					{
						num2 = (short)1228931074;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 6:
					goto IL_190;
				case 7:
					if (cnvSysGeneralSystemType_A.Value == 0)
					{
						num2 = (short)486866944;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_192;
				case 8:
					while (index != 65535)
					{
						num2 = (short)1772426228;
						short num4 = num2;
						num2 = (short)750457844;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)1643708416;
							if (num2 != 0)
							{
							}
							num2 = (short)682950661;
							num = (int)((global::System.IntPtr)num2);
							goto IL_0A;
						}
					}
					num2 = (short)1329922054;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					num2 = (short)1831403528;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_38;
			}
			IL_C2:
			goto IL_192;
			IL_190:
			return true;
			IL_192:
			return cnvSysGeneralSystemType_A.Value == 2;
			IL_38:
			astroCallListCallListSection = (self as global::SpecialFeatures.Ucl.Contact.AstroCallListCallListSection);
			astroCallListCallListSection.UclAstroCnv_IndividualID_A00024Object.CalculateValidityAcrossRecset();
			num2 = (short)1369440259;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001B32 RID: 6962 RVA: 0x00230C90 File Offset: 0x0022EE90
		internal static bool conSetAstroSysGroupNumber(global::AcpCommonLib.IAcpFeatureSection self)
		{
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_38;
				}
				int num;
				global::SpecialFeatures.Ucl.Contact.AstroCallListCallListSection astroCallListCallListSection;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return true;
					case 1:
					{
						if (astroCallListCallListSection.UclAstroCnv_SystemAlias_A00022Value == 65535)
						{
							num2 = (short)912850949;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						global::AcpBusinessLayer.FeatureNode referencedNode = astroCallListCallListSection.UclAstroCnv_SystemAlias_A00022Object.ReferencedNode;
						num2 = (short)1734606850;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 2:
					{
						global::AcpBusinessLayer.FeatureNode referencedNode;
						if (referencedNode != null)
						{
							num2 = (short)128712711;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						astroCallListCallListSection.UclAstroCnv_SystemGroupNumber_A00023Object.PointedField = astroCallListCallListSection.UclAstroCnv_CustomizedSysGrpNumber_A00027Object;
						num2 = (short)1759707145;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 3:
						astroCallListCallListSection.UclAstroCnv_SystemGroupNumber_A00023Object.PointedField = null;
						num2 = (short)809893888;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						return true;
					case 5:
					{
						num2 = (short)539230208;
						short num3 = num2;
						num2 = (short)1247215617;
						if (num2 != 0)
						{
						}
						astroCallListCallListSection.UclAstroCnv_SystemGroupNumber_A00023Object.PointedField = astroCallListCallListSection.UclAstroCnv_CustomizedSysGrpNumber_A00027Object;
						num2 = (short)1374486536;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 6:
					{
						if (astroCallListCallListSection.UclAstroCnv_SystemAlias_A00022Value != 0)
						{
							num2 = (short)2079457281;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1068098033;
						short num4 = num2;
						num2 = (short)524607985;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)763035648;
							if (num2 != 0)
							{
							}
							num2 = (short)1182662659;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 7:
					{
						global::AcpBusinessLayer.FeatureNode referencedNode;
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = referencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
						astroCallListCallListSection.UclAstroCnv_SystemGroupNumber_A00023Object.PointedField = conventionalSystem.General.CnvSysGeneralSystemGroupNumber_A21960;
						num2 = (short)102105092;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 8:
						return true;
					case 9:
						return true;
					}
					break;
				}
				IL_38:
				astroCallListCallListSection = (self as global::SpecialFeatures.Ucl.Contact.AstroCallListCallListSection);
				num2 = (short)1176174598;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			return true;
		}

		// Token: 0x06001B33 RID: 6963 RVA: 0x00230EF8 File Offset: 0x0022F0F8
		internal static bool conIsAstroIndividualIdValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1770127360;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_AA;
				}
				global::SpecialFeatures.Ucl.Contact.AstroCallListCallListSection astroCallListCallListSection;
				for (;;)
				{
					IL_27:
					bool flag;
					int num5;
					switch (num2)
					{
					case 0:
						num = (short)1232863256;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (astroCallListCallListSection.UclAstroCnv_SystemAlias_A00022_UIValue != global::CommonResources.AppResources._Unassigned_)
						{
							num = (short)694353920;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_193;
					case 2:
						if (astroCallListCallListSection.UclAstroCnv_IndividualID_A00024Value > 16777215)
						{
							num = (short)1019936772;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_472;
					case 3:
						if (astroCallListCallListSection.UclAstroCnv_SystemAlias_A00022_UIValue == global::CommonResources.AppResources._Unassigned_)
						{
							num = (short)25493512;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4DE;
					case 4:
						num = (short)1014169611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						if (astroCallListCallListSection.UclAstroCnv_SystemAlias_A00022_UIValue == astroCallListCallListSection.UclAstroCnv_SystemAlias_A00022Object.InvalidText)
						{
							num = (short)1469972505;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SpecialFeatures.Ucl.Contact.AstroCallListRecset astroCallListRecset = (global::SpecialFeatures.Ucl.Contact.AstroCallListRecset)astroCallListCallListSection.ParentRecset;
						num = (short)222035981;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						num = (short)1129089605;
						short num3 = num;
						num = (short)3902021;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_FC;
						default:
							num = (short)835387392;
							if (num != 0)
							{
							}
							goto IL_528;
						}
						break;
					}
					case 7:
					{
						global::SpecialFeatures.Ucl.Contact.AstroCallListRecset astroCallListRecset;
						if (((global::SpecialFeatures.Ucl.Contact.AstroCallList)astroCallListRecset[0]).IsDefaultNode())
						{
							num = (short)2034368522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_248;
					}
					case 8:
						num = (short)561250319;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)674234369;
						if (num != 0)
						{
						}
						if (astroCallListCallListSection.UclAstroCnv_IndividualID_A00024Value > 65535)
						{
							num = (short)1641218074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_528;
					case 10:
						return false;
					case 11:
						if (astroCallListCallListSection.UclAstroCnv_ListinfoCallType_A00025Value != 0)
						{
							num = (short)1422131214;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 12:
						return true;
					case 13:
					{
						num = (short)1059651584;
						short num4 = num;
						global::SpecialFeatures.Ucl.Contact.AstroCallListRecset astroCallListRecset;
						if (astroCallListRecset.Count == 1)
						{
							num = (short)1076559902;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_248;
					}
					case 14:
						goto IL_472;
					case 15:
						if (!(astroCallListCallListSection.UclAstroCnv_IndividualID_A00024_UIValue != global::CommonResources.AppResources.Unassigned_ID))
						{
							num = (short)1902772244;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 16:
						flag = true;
						num = (short)1928331285;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						global::SpecialFeatures.Ucl.Contact.AstroCallListRecset astroCallListRecset;
						if (num5 >= astroCallListRecset.Count)
						{
							num = (short)1322188819;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FC;
					}
					case 18:
						goto IL_35C;
					case 19:
						goto IL_269;
					case 20:
						goto IL_4DE;
					case 21:
						goto IL_269;
					case 22:
						goto IL_193;
					case 23:
						if (flag)
						{
							num = (short)1774649356;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 24:
						if (!(astroCallListCallListSection.UclAstroCnv_IndividualID_A00024_UIValue == global::CommonResources.AppResources.Unassigned_ID))
						{
							num = (short)331415574;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 25:
						return false;
					case 26:
						num = (short)1329004572;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
					{
						global::SpecialFeatures.Ucl.Contact.AstroCallListRecset astroCallListRecset;
						if (!((global::SpecialFeatures.Ucl.Contact.AstroCallList)astroCallListRecset[num5]).IsDefaultNode())
						{
							num = (short)1185808400;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5++;
						num = (short)1711669266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						if (astroCallListCallListSection.UclAstroCnv_ListinfoCallType_A00025Value != 1)
						{
							num = (short)460587014;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 29:
						goto IL_35C;
					case 30:
						num = (short)748158983;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AA;
					IL_FC:
					num = (short)980025371;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_193:
					num = (short)646709250;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_248:
					flag = false;
					num5 = 0;
					num = (short)345243677;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_269:
					num = (short)565313559;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_35C:
					num = (short)544735249;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_472:
					num = (short)1616445449;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4DE:
					num = (short)1311965185;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_528:
					num = (short)1813839877;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_AA:
				astroCallListCallListSection = (self as global::SpecialFeatures.Ucl.Contact.AstroCallListCallListSection);
				num = (short)911081475;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06001B34 RID: 6964 RVA: 0x002314A0 File Offset: 0x0022F6A0
		internal static bool conIsAstroCallTypeValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			global::SpecialFeatures.Ucl.Contact.AstroCallListCallListSection astroCallListCallListSection;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1748844975;
					short num3 = num2;
					num2 = (short)742539695;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
					{
						num2 = (short)382271489;
						if (num2 != 0)
						{
						}
						num2 = (short)128188416;
						short num4 = num2;
						num2 = (short)1781530624;
						if (num2 != 0)
						{
						}
						goto IL_6D;
					}
					}
					break;
				}
				case 1:
					if (index != 1)
					{
						num2 = (short)1578893312;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 2:
					if (astroCallListCallListSection.UclAstroCnv_SystemAlias_A00022_UIValue == global::CommonResources.AppResources._Unassigned_)
					{
						num2 = (short)1733427204;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_6D;
				case 3:
					if (astroCallListCallListSection.UclAstroCnv_SystemAlias_A00022_UIValue == astroCallListCallListSection.UclAstroCnv_SystemAlias_A00022Object.InvalidText)
					{
						num2 = (short)999686149;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 4:
					num2 = (short)472317953;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_B5;
				}
				goto IL_28;
				IL_6D:
				num2 = (short)1174274051;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_B5:
			return false;
			IL_28:
			astroCallListCallListSection = (self as global::SpecialFeatures.Ucl.Contact.AstroCallListCallListSection);
			num2 = (short)2087190530;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001B35 RID: 6965 RVA: 0x00231638 File Offset: 0x0022F838
		internal static bool conIsCustomizedAstroSystem(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1130103235;
			short num2 = num;
			num = (short)135070147;
			switch (num2 == num)
			{
			}
			num = (short)2038562817;
			if (num != 0)
			{
			}
			num = (short)379256832;
			short num3 = num;
			num = (short)1902510080;
			if (num != 0)
			{
			}
			return (self as global::SpecialFeatures.Ucl.Contact.AstroCallListCallListSection).UclAstroCnv_SystemAlias_A00022Value == 65535;
		}

		// Token: 0x06001B36 RID: 6966 RVA: 0x002316F4 File Offset: 0x0022F8F4
		internal static bool conIsNotCustomizedAstroSystem(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1784464680;
			short num2 = num;
			num = (short)855164200;
			switch (num2 == num)
			{
			}
			num = (short)646840321;
			if (num != 0)
			{
			}
			num = (short)1795031040;
			short num3 = num;
			num = (short)2042101760;
			if (num != 0)
			{
			}
			return (self as global::SpecialFeatures.Ucl.Contact.AstroCallListCallListSection).UclAstroCnv_SystemAlias_A00022Value != 65535;
		}

		// Token: 0x06001B37 RID: 6967 RVA: 0x002317B0 File Offset: 0x0022F9B0
		internal static bool conIsMDCSystemAliasValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			short num2;
			global::SpecialFeatures.Ucl.Contact.MDCCallListCallListSection mdccallListCallListSection;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_159;
				case 1:
					if (index == 65535)
					{
						goto IL_142;
					}
					num2 = (short)844824579;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (index != 0)
					{
						num2 = (short)2138767364;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 3:
					if (mdccallListCallListSection.UclMDCCnv_SystemAlias_A00028Object.RefRecset != null)
					{
						num2 = (short)458620933;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 4:
					num2 = (short)1809776641;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_11E;
				}
				goto IL_28;
			}
			IL_11E:
			return (((global::AcpBusinessLayer.FeatureNode)mdccallListCallListSection.UclMDCCnv_SystemAlias_A00028Object.RefRecset[index - 1]) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem).General.CnvSysGeneralSystemType_A13262.Value == 1;
			IL_159:
			num2 = (short)1100087296;
			short num3 = num2;
			return true;
			IL_28:
			mdccallListCallListSection = (self as global::SpecialFeatures.Ucl.Contact.MDCCallListCallListSection);
			mdccallListCallListSection.UclMDCCnv_PrimaryID_A00030Object.CalculateValidityAcrossRecset();
			num2 = (short)683718749;
			short num4 = num2;
			num2 = (short)877967453;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_142:
				num2 = (short)392757248;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)416088064;
				if (num2 != 0)
				{
				}
				num2 = (short)700645377;
				if (num2 != 0)
				{
				}
				num2 = (short)1568669698;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06001B38 RID: 6968 RVA: 0x00231974 File Offset: 0x0022FB74
		internal static bool conSetMDCSysGroupNumber(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num2;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_38;
				}
				int num;
				global::SpecialFeatures.Ucl.Contact.MDCCallListCallListSection mdccallListCallListSection;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return true;
					case 1:
					{
						if (mdccallListCallListSection.UclMDCCnv_SystemAlias_A00028Value == 65535)
						{
							num2 = (short)2082078720;
							short num3 = num2;
							num2 = (short)2096955397;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						global::AcpBusinessLayer.FeatureNode referencedNode = mdccallListCallListSection.UclMDCCnv_SystemAlias_A00028Object.ReferencedNode;
						num2 = (short)1175126018;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 2:
					{
						global::AcpBusinessLayer.FeatureNode referencedNode;
						if (referencedNode != null)
						{
							num2 = (short)974585863;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						mdccallListCallListSection.UclMDCCnv_SystemGroupNumber_A00029Object.PointedField = mdccallListCallListSection.UclMDCCnv_CustomizedSysGrpNumber_A00032Object;
						num2 = (short)940507145;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 3:
						mdccallListCallListSection.UclMDCCnv_SystemGroupNumber_A00029Object.PointedField = null;
						num2 = (short)286261248;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						goto IL_FB;
					case 5:
						mdccallListCallListSection.UclMDCCnv_SystemGroupNumber_A00029Object.PointedField = mdccallListCallListSection.UclMDCCnv_CustomizedSysGrpNumber_A00032Object;
						num2 = (short)463863816;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
					{
						if (mdccallListCallListSection.UclMDCCnv_SystemAlias_A00028Value != 0)
						{
							num2 = (short)1956118529;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1771326335;
						short num4 = num2;
						num2 = (short)440224639;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)1158283264;
							if (num2 != 0)
							{
							}
							num2 = (short)1217593347;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 7:
					{
						global::AcpBusinessLayer.FeatureNode referencedNode;
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem conventionalSystem = referencedNode as global::Motorola.MackinawCPS.CoreFeatures.ConventionalSystem.ConventionalSystem;
						mdccallListCallListSection.UclMDCCnv_SystemGroupNumber_A00029Object.PointedField = conventionalSystem.General.CnvSysGeneralSystemGroupNumber_A21960;
						num2 = (short)97189892;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 8:
						goto IL_129;
					case 9:
						return true;
					}
					break;
				}
				IL_38:
				mdccallListCallListSection = (self as global::SpecialFeatures.Ucl.Contact.MDCCallListCallListSection);
				num2 = (short)899547142;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_FB:
			return true;
			IL_129:
			num2 = (short)1716584449;
			if (num2 != 0)
			{
			}
			return true;
		}

		// Token: 0x06001B39 RID: 6969 RVA: 0x00231BE0 File Offset: 0x0022FDE0
		internal static bool conIsPrimaryIdValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)527630336;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8A;
				}
				global::SpecialFeatures.Ucl.Contact.MDCCallListCallListSection mdccallListCallListSection;
				for (;;)
				{
					IL_27:
					int num4;
					bool flag;
					switch (num2)
					{
					case 0:
						if (mdccallListCallListSection.UclMDCCnv_SystemAlias_A00028_UIValue == global::CommonResources.AppResources._Unassigned_)
						{
							num = (short)1806172179;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EC;
					case 1:
						goto IL_373;
					case 2:
						goto IL_1EC;
					case 3:
					{
						global::SpecialFeatures.Ucl.Contact.MDCCallListRecset mdccallListRecset;
						if (((global::SpecialFeatures.Ucl.Contact.MDCCallList)mdccallListRecset[0]).IsDefaultNode())
						{
							num = (short)440860678;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F7;
					}
					case 4:
						goto IL_1AB;
					case 5:
					{
						num = (short)253985399;
						short num3 = num;
						num = (short)1204716151;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_324;
						default:
							num = (short)176685056;
							if (num != 0)
							{
							}
							goto IL_1AB;
						}
						break;
					}
					case 6:
						return false;
					case 7:
						goto IL_324;
					case 8:
						if (!(mdccallListCallListSection.UclMDCCnv_PrimaryID_A00030_UIValue != global::CommonResources.AppResources.Unassigned_ID))
						{
							num = (short)561840130;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 9:
					{
						global::SpecialFeatures.Ucl.Contact.MDCCallListRecset mdccallListRecset;
						if (!((global::SpecialFeatures.Ucl.Contact.MDCCallList)mdccallListRecset[num4]).IsDefaultNode())
						{
							num = (short)1497759766;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4++;
						num = (short)2107899908;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						if (!(mdccallListCallListSection.UclMDCCnv_PrimaryID_A00030_UIValue == global::CommonResources.AppResources.Unassigned_ID))
						{
							num = (short)689635335;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 11:
						num = (short)1921843203;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_371;
					case 13:
						num = (short)874119178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (flag)
						{
							num = (short)1215496210;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 15:
					{
						global::SpecialFeatures.Ucl.Contact.MDCCallListRecset mdccallListRecset;
						if (mdccallListRecset.Count == 1)
						{
							num = (short)1445330955;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F7;
					}
					case 16:
					{
						global::SpecialFeatures.Ucl.Contact.MDCCallListRecset mdccallListRecset;
						if (num4 >= mdccallListRecset.Count)
						{
							num = (short)1521418257;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)529203209;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_373;
					case 18:
						goto IL_3AB;
					case 19:
						num = (short)289734664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
					{
						if (mdccallListCallListSection.UclMDCCnv_SystemAlias_A00028_UIValue == mdccallListCallListSection.UclMDCCnv_SystemAlias_A00028Object.InvalidText)
						{
							num = (short)1447886860;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SpecialFeatures.Ucl.Contact.MDCCallListRecset mdccallListRecset = (global::SpecialFeatures.Ucl.Contact.MDCCallListRecset)mdccallListCallListSection.ParentRecset;
						num = (short)227868687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						num = (short)1837498369;
						if (num != 0)
						{
						}
						if (mdccallListCallListSection.UclMDCCnv_SystemAlias_A00028_UIValue != global::CommonResources.AppResources._Unassigned_)
						{
							num = (short)1122828301;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_324;
					case 22:
						flag = true;
						num = (short)1820131329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8A;
					IL_F7:
					flag = false;
					num4 = 0;
					num = (short)241369093;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1AB:
					num = (short)1674248208;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1EC:
					num = (short)64946197;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_324:
					num = (short)1138622484;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_373:
					num = (short)1742864398;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_371:
				return false;
				IL_3AB:
				num = (short)1374158848;
				short num5 = num;
				return true;
				IL_8A:
				mdccallListCallListSection = (self as global::SpecialFeatures.Ucl.Contact.MDCCallListCallListSection);
				num = (short)739311616;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06001B3A RID: 6970 RVA: 0x0023205C File Offset: 0x0023025C
		internal static bool conIsCustomizedMDCSystem(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)856066004;
			short num2 = num;
			num = (short)604342228;
			switch (num2 == num)
			{
			}
			num = (short)519962624;
			if (num != 0)
			{
			}
			num = (short)617152512;
			short num3 = num;
			num = (short)1782906881;
			if (num != 0)
			{
			}
			return (self as global::SpecialFeatures.Ucl.Contact.MDCCallListCallListSection).UclMDCCnv_SystemAlias_A00028Value == 65535;
		}

		// Token: 0x06001B3B RID: 6971 RVA: 0x00232118 File Offset: 0x00230318
		internal static bool conIsNotCustomizedMDCSystem(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)355504813;
			short num2 = num;
			num = (short)1317507757;
			switch (num2 == num)
			{
			}
			num = (short)70385665;
			if (num != 0)
			{
			}
			num = (short)1947598848;
			if (num != 0)
			{
			}
			num = (short)394002432;
			short num3 = num;
			return (self as global::SpecialFeatures.Ucl.Contact.MDCCallListCallListSection).UclMDCCnv_SystemAlias_A00028Value != 65535;
		}

		// Token: 0x06001B3C RID: 6972 RVA: 0x002321D4 File Offset: 0x002303D4
		internal static bool conTrk25SystemAliasIsValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			short num2;
			global::SpecialFeatures.Ucl.Contact.TrunkingCallListCallListSection trunkingCallListCallListSection;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_18A;
				case 1:
					goto IL_E3;
				case 2:
				{
					if (index == 65535)
					{
						num2 = (short)773521408;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1522204672;
					short num3 = num2;
					num2 = (short)2141978629;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (index != 0)
					{
						num2 = (short)1986002945;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 4:
					goto IL_14C;
				case 5:
					if (trunkingCallListCallListSection.UclAstro25Trk_SystemAlias_A00010Object.RefRecset != null)
					{
						num2 = (short)1224409092;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				goto IL_28;
			}
			IL_E3:
			goto IL_150;
			IL_14C:
			return (((global::AcpBusinessLayer.FeatureNode)trunkingCallListCallListSection.UclAstro25Trk_SystemAlias_A00010Object.RefRecset[index - 1]) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem).General.TrkSysGeneralSystemType_A9252.Value == 3;
			IL_18A:
			return true;
			IL_28:
			trunkingCallListCallListSection = (self as global::SpecialFeatures.Ucl.Contact.TrunkingCallListCallListSection);
			trunkingCallListCallListSection.UclAstro25Trk_IndividualID_A00013Object.CalculateValidityAcrossRecset();
			num2 = (short)701936965;
			short num4 = num2;
			num2 = (short)1673442629;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_150:
				num2 = (short)1079443458;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1610612737;
				if (num2 != 0)
				{
				}
				num2 = (short)140771328;
				if (num2 != 0)
				{
				}
				num2 = (short)243859459;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06001B3D RID: 6973 RVA: 0x002323A0 File Offset: 0x002305A0
		internal static bool conSetTrkSystemIDs(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			global::SpecialFeatures.Ucl.Contact.TrunkingCallListCallListSection trunkingCallListCallListSection;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (trunkingCallListCallListSection.UclAstro25Trk_SystemAlias_A00010Value == 65535)
					{
						num2 = (short)2087911432;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::AcpBusinessLayer.FeatureNode referencedNode = trunkingCallListCallListSection.UclAstro25Trk_SystemAlias_A00010Object.ReferencedNode;
					num2 = (short)1033699334;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_19A;
				case 2:
				{
					global::AcpBusinessLayer.FeatureNode referencedNode;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = referencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
					trunkingCallListCallListSection.UclAstro25Trk_HomeSystemID_A00012Object.PointedField = trunkingSystem.General.TrkSysGeneralSystemID_A9239;
					trunkingCallListCallListSection.UclAstro25Trk_WACNID_A00011Object.PointedField = trunkingSystem.General.TrkSysGeneralHomeWACNID_A8205;
					num2 = (short)1996554244;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (trunkingCallListCallListSection.UclAstro25Trk_SystemAlias_A00010Value == 0)
					{
						num2 = (short)457048071;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)112394240;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_C3;
				case 5:
					goto IL_15C;
				case 6:
				{
					num2 = (short)473665639;
					short num3 = num2;
					num2 = (short)1851691111;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
					{
						num2 = (short)1324679168;
						if (num2 != 0)
						{
						}
						global::AcpBusinessLayer.FeatureNode referencedNode;
						if (referencedNode != null)
						{
							num2 = (short)1668284418;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						trunkingCallListCallListSection.UclAstro25Trk_HomeSystemID_A00012Object.PointedField = trunkingCallListCallListSection.UclAstro25Trk_CustomizedHomeSystemID_A00016Object;
						trunkingCallListCallListSection.UclAstro25Trk_WACNID_A00011Object.PointedField = trunkingCallListCallListSection.UclAstro25Trk_CustomizedWACNID_A00015Object;
						num2 = (short)1846935553;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 7:
					trunkingCallListCallListSection.UclAstro25Trk_HomeSystemID_A00012Object.PointedField = null;
					trunkingCallListCallListSection.UclAstro25Trk_WACNID_A00011Object.PointedField = null;
					num2 = (short)120782853;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					trunkingCallListCallListSection.UclAstro25Trk_HomeSystemID_A00012Object.PointedField = trunkingCallListCallListSection.UclAstro25Trk_CustomizedHomeSystemID_A00016Object;
					trunkingCallListCallListSection.UclAstro25Trk_WACNID_A00011Object.PointedField = trunkingCallListCallListSection.UclAstro25Trk_CustomizedWACNID_A00015Object;
					num2 = (short)1787297801;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_128;
				}
				goto IL_38;
			}
			IL_C3:
			num2 = (short)1793064961;
			if (num2 != 0)
			{
			}
			IL_128:
			IL_15C:
			return true;
			IL_19A:
			num2 = (short)1480654848;
			short num4 = num2;
			return true;
			IL_38:
			trunkingCallListCallListSection = (self as global::SpecialFeatures.Ucl.Contact.TrunkingCallListCallListSection);
			num2 = (short)1014431747;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001B3E RID: 6974 RVA: 0x00232648 File Offset: 0x00230848
		internal static bool conIsTrkIndividualIdValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1315504128;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8B;
				}
				global::SpecialFeatures.Ucl.Contact.TrunkingCallListCallListSection trunkingCallListCallListSection;
				for (;;)
				{
					IL_28:
					bool flag;
					int num4;
					switch (num2)
					{
					case 0:
						goto IL_190;
					case 1:
					{
						global::SpecialFeatures.Ucl.Contact.TrunkingCallListRecset trunkingCallListRecset;
						if (trunkingCallListRecset.Count == 1)
						{
							goto IL_44A;
						}
						goto IL_FB;
					}
					case 2:
						if (flag)
						{
							num = (short)752680981;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 3:
					{
						num = (short)1465596642;
						short num3 = num;
						num = (short)1621179106;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_44A;
						default:
						{
							num = (short)1456144384;
							if (num != 0)
							{
							}
							if (trunkingCallListCallListSection.UclAstro25Trk_SystemAlias_A00010_UIValue == trunkingCallListCallListSection.UclAstro25Trk_SystemAlias_A00010Object.InvalidText)
							{
								num = (short)1005912071;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::SpecialFeatures.Ucl.Contact.TrunkingCallListRecset trunkingCallListRecset = (global::SpecialFeatures.Ucl.Contact.TrunkingCallListRecset)trunkingCallListCallListSection.ParentRecset;
							num = (short)1957101569;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 4:
						num = (short)729546753;
						if (num != 0)
						{
						}
						flag = true;
						num = (short)1542914057;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (!(trunkingCallListCallListSection.UclAstro25Trk_IndividualID_A00013_UIValue != global::CommonResources.AppResources.Unassigned_ID))
						{
							num = (short)96403469;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 6:
					{
						global::SpecialFeatures.Ucl.Contact.TrunkingCallListRecset trunkingCallListRecset;
						if (!((global::SpecialFeatures.Ucl.Contact.TrunkingCallList)trunkingCallListRecset[num4]).IsDefaultNode())
						{
							num = (short)381288452;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4++;
						num = (short)317587456;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_370;
					case 8:
					{
						global::SpecialFeatures.Ucl.Contact.TrunkingCallListRecset trunkingCallListRecset;
						if (num4 >= trunkingCallListRecset.Count)
						{
							num = (short)633012246;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)217972742;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_372;
					case 10:
					{
						global::SpecialFeatures.Ucl.Contact.TrunkingCallListRecset trunkingCallListRecset;
						if (((global::SpecialFeatures.Ucl.Contact.TrunkingCallList)trunkingCallListRecset[0]).IsDefaultNode())
						{
							num = (short)628752402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FB;
					}
					case 11:
						num = (short)1016594442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (trunkingCallListCallListSection.UclAstro25Trk_SystemAlias_A00010_UIValue != global::CommonResources.AppResources._Unassigned_)
						{
							num = (short)1085603857;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D9;
					case 13:
						goto IL_1CE;
					case 14:
						if (!(trunkingCallListCallListSection.UclAstro25Trk_IndividualID_A00013_UIValue == global::CommonResources.AppResources.Unassigned_ID))
						{
							num = (short)1390411795;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 15:
						if (trunkingCallListCallListSection.UclAstro25Trk_SystemAlias_A00010_UIValue == global::CommonResources.AppResources._Unassigned_)
						{
							num = (short)1817706512;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CE;
					case 16:
						num = (short)31653893;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						num = (short)218628110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						return false;
					case 19:
						goto IL_2D9;
					case 20:
					{
						num = (short)1724448768;
						short num5 = num;
						goto IL_190;
					}
					case 21:
						return true;
					case 22:
						goto IL_372;
					}
					goto IL_8B;
					IL_FB:
					flag = false;
					num4 = 0;
					num = (short)684064788;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_190:
					num = (short)314114056;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CE:
					num = (short)305004556;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D9:
					num = (short)348258307;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_372:
					num = (short)1095434242;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_44A:
					num = (short)760414219;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_370:
				return false;
				IL_8B:
				trunkingCallListCallListSection = (self as global::SpecialFeatures.Ucl.Contact.TrunkingCallListCallListSection);
				num = (short)1962344463;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06001B3F RID: 6975 RVA: 0x00232AC0 File Offset: 0x00230CC0
		internal static bool conIsCustomizedAstro25System(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)334377061;
			short num2 = num;
			num = (short)2043228261;
			switch (num2 == num)
			{
			}
			num = (short)754319361;
			if (num != 0)
			{
			}
			num = (short)944373760;
			if (num != 0)
			{
			}
			num = (short)1155727360;
			short num3 = num;
			return (self as global::SpecialFeatures.Ucl.Contact.TrunkingCallListCallListSection).UclAstro25Trk_SystemAlias_A00010Value == 65535;
		}

		// Token: 0x06001B40 RID: 6976 RVA: 0x00232B80 File Offset: 0x00230D80
		internal static bool conIsNotCustomizedAstro25System(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1149565041;
			short num2 = num;
			num = (short)1688205425;
			switch (num2 == num)
			{
			}
			num = (short)408682496;
			if (num != 0)
			{
			}
			num = (short)665649153;
			if (num != 0)
			{
			}
			num = (short)219676672;
			short num3 = num;
			return (self as global::SpecialFeatures.Ucl.Contact.TrunkingCallListCallListSection).UclAstro25Trk_SystemAlias_A00010Value != 65535;
		}

		// Token: 0x06001B41 RID: 6977 RVA: 0x00232C40 File Offset: 0x00230E40
		internal static bool conIsTrkType2SystemAliasValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			short num2;
			global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListCallListSection trunkingT2CallListCallListSection;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_18D;
				case 1:
					goto IL_BA;
				case 2:
				{
					if (index == 65535)
					{
						num2 = (short)526647296;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1881276416;
					short num3 = num2;
					num2 = (short)521207813;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (index != 0)
					{
						num2 = (short)1388380161;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 4:
					goto IL_14F;
				case 5:
					if (trunkingT2CallListCallListSection.UclT2Trk_SystemAlias_A00017Object.RefRecset != null)
					{
						num2 = (short)1442709508;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				goto IL_28;
			}
			IL_BA:
			num2 = (short)592969729;
			if (num2 != 0)
			{
			}
			goto IL_153;
			IL_14F:
			return (((global::AcpBusinessLayer.FeatureNode)trunkingT2CallListCallListSection.UclT2Trk_SystemAlias_A00017Object.RefRecset[index - 1]) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem).General.TrkSysGeneralSystemType_A9252.Value == 2;
			IL_18D:
			return true;
			IL_28:
			trunkingT2CallListCallListSection = (self as global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListCallListSection);
			trunkingT2CallListCallListSection.UclT2Trk_IndividualID_A00019Object.CalculateValidityAcrossRecset();
			num2 = (short)808879422;
			short num4 = num2;
			num2 = (short)1336313150;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_153:
				num2 = (short)2098003970;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1169948672;
				if (num2 != 0)
				{
				}
				num2 = (short)1850998787;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06001B42 RID: 6978 RVA: 0x00232E10 File Offset: 0x00231010
		internal static bool conSetType2SystemID(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListCallListSection trunkingT2CallListCallListSection;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (trunkingT2CallListCallListSection.UclT2Trk_SystemAlias_A00017Value == 65535)
					{
						num2 = (short)1147076616;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::AcpBusinessLayer.FeatureNode referencedNode = trunkingT2CallListCallListSection.UclT2Trk_SystemAlias_A00017Object.ReferencedNode;
					num2 = (short)748093446;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_154;
				case 2:
				{
					global::AcpBusinessLayer.FeatureNode referencedNode;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = referencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
					trunkingT2CallListCallListSection.UclT2Trk_SystemID_A00018Object.PointedField = trunkingSystem.General.TrkSysGeneralSystemID_A9239;
					num2 = (short)1323302916;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					if (trunkingT2CallListCallListSection.UclT2Trk_SystemAlias_A00017Value == 0)
					{
						num2 = (short)1334837255;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1976565760;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_D2;
				case 5:
					goto IL_127;
				case 6:
				{
					num2 = (short)1376625208;
					short num3 = num2;
					num2 = (short)838312504;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
					{
						num2 = (short)319488000;
						if (num2 != 0)
						{
						}
						global::AcpBusinessLayer.FeatureNode referencedNode;
						if (referencedNode != null)
						{
							num2 = (short)530448386;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						trunkingT2CallListCallListSection.UclT2Trk_SystemID_A00018Object.PointedField = trunkingT2CallListCallListSection.UclT2Trk_CustomizedSystemID_A00021Object;
						num2 = (short)1603731457;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 7:
					num2 = (short)156958721;
					if (num2 != 0)
					{
					}
					trunkingT2CallListCallListSection.UclT2Trk_SystemID_A00018Object.PointedField = null;
					num2 = (short)1557594117;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					trunkingT2CallListCallListSection.UclT2Trk_SystemID_A00018Object.PointedField = trunkingT2CallListCallListSection.UclT2Trk_CustomizedSystemID_A00021Object;
					num2 = (short)1213005833;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_FF;
				}
				goto IL_38;
			}
			IL_D2:
			IL_FF:
			IL_127:
			return true;
			IL_154:
			num2 = (short)145883136;
			short num4 = num2;
			return true;
			IL_38:
			trunkingT2CallListCallListSection = (self as global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListCallListSection);
			num2 = (short)2032533507;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06001B43 RID: 6979 RVA: 0x00233074 File Offset: 0x00231274
		internal static bool conIsT2IndividualIdValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1804861440;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8A;
				}
				global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListCallListSection trunkingT2CallListCallListSection;
				for (;;)
				{
					IL_27:
					bool flag;
					int num4;
					switch (num2)
					{
					case 0:
						goto IL_18D;
					case 1:
					{
						global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListRecset trunkingT2CallListRecset;
						if (trunkingT2CallListRecset.Count == 1)
						{
							goto IL_448;
						}
						goto IL_FA;
					}
					case 2:
						if (flag)
						{
							num = (short)1038155797;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 3:
					{
						num = (short)1822565808;
						short num3 = num;
						num = (short)1191716272;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_448;
						default:
						{
							num = (short)393740288;
							if (num != 0)
							{
							}
							if (trunkingT2CallListCallListSection.UclT2Trk_SystemAlias_A00017_UIValue == trunkingT2CallListCallListSection.UclT2Trk_SystemAlias_A00017Object.InvalidText)
							{
								num = (short)289341447;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListRecset trunkingT2CallListRecset = (global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListRecset)trunkingT2CallListCallListSection.ParentRecset;
							num = (short)419823617;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 4:
						flag = true;
						num = (short)1705181193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (!(trunkingT2CallListCallListSection.UclT2Trk_IndividualID_A00019_UIValue != global::CommonResources.AppResources.Unassigned_ID))
						{
							num = (short)1762263053;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 6:
					{
						global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListRecset trunkingT2CallListRecset;
						if (!((global::SpecialFeatures.Ucl.Contact.TrunkingT2CallList)trunkingT2CallListRecset[num4]).IsDefaultNode())
						{
							num = (short)835190788;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4++;
						num = (short)1513422848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_348;
					case 8:
					{
						global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListRecset trunkingT2CallListRecset;
						if (num4 >= trunkingT2CallListRecset.Count)
						{
							num = (short)1451098134;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)895090694;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_34A;
					case 10:
					{
						global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListRecset trunkingT2CallListRecset;
						if (((global::SpecialFeatures.Ucl.Contact.TrunkingT2CallList)trunkingT2CallListRecset[0]).IsDefaultNode())
						{
							num = (short)1450115090;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FA;
					}
					case 11:
						num = (short)45285386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (trunkingT2CallListCallListSection.UclT2Trk_SystemAlias_A00017_UIValue != global::CommonResources.AppResources._Unassigned_)
						{
							num = (short)791019537;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B0;
					case 13:
						goto IL_1CC;
					case 14:
						if (!(trunkingT2CallListCallListSection.UclT2Trk_IndividualID_A00019_UIValue == global::CommonResources.AppResources.Unassigned_ID))
						{
							num = (short)676069395;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 15:
						if (trunkingT2CallListCallListSection.UclT2Trk_SystemAlias_A00017_UIValue == global::CommonResources.AppResources._Unassigned_)
						{
							num = (short)1282015248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CC;
					case 16:
						num = (short)518258689;
						if (num != 0)
						{
						}
						num = (short)321912837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						num = (short)752287758;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						return false;
					case 19:
						goto IL_2B0;
					case 20:
					{
						num = (short)535429120;
						short num5 = num;
						goto IL_18D;
					}
					case 21:
						return true;
					case 22:
						goto IL_34A;
					}
					goto IL_8A;
					IL_FA:
					flag = false;
					num4 = 0;
					num = (short)2071396372;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18D:
					num = (short)254935048;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CC:
					num = (short)423952396;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2B0:
					num = (short)1833959427;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_34A:
					num = (short)1564934146;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_448:
					num = (short)737148939;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_348:
				return false;
				IL_8A:
				trunkingT2CallListCallListSection = (self as global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListCallListSection);
				num = (short)1168441359;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06001B44 RID: 6980 RVA: 0x002334EC File Offset: 0x002316EC
		internal static bool conIsCustomizedT2System(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1619137456;
			short num2 = num;
			num = (short)504370096;
			switch (num2 == num)
			{
			}
			num = (short)1234829313;
			if (num != 0)
			{
			}
			num = (short)1627652096;
			if (num != 0)
			{
			}
			num = (short)363200512;
			short num3 = num;
			return (self as global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListCallListSection).UclT2Trk_SystemAlias_A00017Value == 65535;
		}

		// Token: 0x06001B45 RID: 6981 RVA: 0x002335A8 File Offset: 0x002317A8
		internal static bool conIsNotCustomizedT2System(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1953103873;
			if (num != 0)
			{
			}
			num = (short)1252772504;
			short num2 = num;
			num = (short)1142934168;
			switch (num2 == num)
			{
			}
			num = (short)2051670016;
			if (num != 0)
			{
			}
			num = (short)719585280;
			short num3 = num;
			return (self as global::SpecialFeatures.Ucl.Contact.TrunkingT2CallListCallListSection).UclT2Trk_SystemAlias_A00017Value != 65535;
		}

		// Token: 0x06001B46 RID: 6982 RVA: 0x00233668 File Offset: 0x00231868
		internal static bool conIsPhoneCategoryTypeValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1623916544;
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
				global::SpecialFeatures.Ucl.Contact.PhoneCallListRecset phoneCallListRecset;
				global::SpecialFeatures.Ucl.Contact.PhoneCallListCallListSection phoneCallListCallListSection;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						num = (short)1870266388;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_11D;
					case 2:
						goto IL_3AA;
					case 3:
					{
						global::SpecialFeatures.Ucl.Contact.PhoneCallList phoneCallList;
						if ((global::SpecialFeatures.Ucl.Contact.PhoneCallList)self.Parent == phoneCallList)
						{
							num = (short)381943829;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SpecialFeatures.Ucl.Contact.PhoneCallList phoneCallList2 = phoneCallListRecset[1] as global::SpecialFeatures.Ucl.Contact.PhoneCallList;
						num = (short)1590034441;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_303;
					case 5:
						if (index == 1)
						{
							num = (short)276496394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 6:
						if (index != 0)
						{
							num = (short)2060320769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 7:
						if (index != 0)
						{
							num = (short)1858207756;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 8:
						if (phoneCallListCallListSection.UclPhone_ListinfoPhoneCategory_A00034Value == 0)
						{
							num = (short)1480392723;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11D;
					case 9:
					{
						global::SpecialFeatures.Ucl.Contact.PhoneCallList phoneCallList;
						global::SpecialFeatures.Ucl.Contact.PhoneCallList phoneCallList2;
						if (phoneCallList.CallListPhone.UclPhone_ListinfoPhoneCategory_A00034Value == phoneCallList2.CallListPhone.UclPhone_ListinfoPhoneCategory_A00034Value)
						{
							num = (short)1931280384;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)833224712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_423;
					case 11:
						if (phoneCallListCallListSection.UclPhone_ListinfoPhoneCategory_A00034Value == 0)
						{
							num = (short)1344012304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 12:
						goto IL_22F;
					case 13:
					{
						num = (short)565444609;
						if (num != 0)
						{
						}
						num = (short)1422646976;
						short num3 = num;
						num = (short)284090048;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3AA;
						default:
							num = (short)50397184;
							if (num != 0)
							{
							}
							if (phoneCallListCallListSection.UclPhone_ListinfoPhoneCategory_A00034Value == 1)
							{
								num = (short)1543176210;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return false;
						}
						break;
					}
					case 14:
					{
						if (phoneCallListRecset.Count < 2)
						{
							num = (short)192479247;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						phoneCallListCallListSection.UclPhone_PhoneNumber_A00033Object.CalculateValidity();
						global::SpecialFeatures.Ucl.Contact.PhoneCallList phoneCallList = phoneCallListRecset[0] as global::SpecialFeatures.Ucl.Contact.PhoneCallList;
						num = (short)19333123;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						return true;
					case 16:
						num = (short)1430913029;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (index == 1)
						{
							num = (short)71761924;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 18:
						num = (short)646905873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)1456406534;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (phoneCallListCallListSection.UclPhone_ListinfoPhoneCategory_A00034Value == 1)
						{
							num = (short)1867579394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22F;
					case 21:
						return true;
					}
					goto IL_86;
					IL_11D:
					num = (short)260440077;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_22F:
					num = (short)1558642699;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3AA:
					num = (short)2120810503;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_303:
				num = (short)1624440832;
				short num4 = num;
				return true;
				IL_423:
				return true;
				IL_86:
				phoneCallListCallListSection = (self as global::SpecialFeatures.Ucl.Contact.PhoneCallListCallListSection);
				phoneCallListRecset = (phoneCallListCallListSection.ParentRecset as global::SpecialFeatures.Ucl.Contact.PhoneCallListRecset);
				num = (short)756416526;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06001B47 RID: 6983 RVA: 0x00233AA0 File Offset: 0x00231CA0
		internal static bool conIsPhoneNumberValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num;
			global::SpecialFeatures.Ucl.Contact.PhoneCallListRecset phoneCallListRecset;
			short num3;
			for (;;)
			{
				IL_0A:
				int num2;
				bool flag;
				switch (num)
				{
				case 0:
					return true;
				case 1:
					if (num2 >= phoneCallListRecset.Count)
					{
						num3 = (short)1486553093;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num3 = (short)784924683;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 2:
					goto IL_1AA;
				case 3:
					if (((global::SpecialFeatures.Ucl.Contact.PhoneCallList)phoneCallListRecset[0]).IsDefaultNode())
					{
						num3 = (short)1593704456;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return true;
				case 4:
					flag = true;
					num3 = (short)292814855;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 5:
					goto IL_8E;
				case 6:
					if (phoneCallListRecset.Count == 1)
					{
						num3 = (short)1637285898;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_257;
				case 7:
					goto IL_8E;
				case 8:
				{
					num3 = (short)1274940728;
					short num4 = num3;
					num3 = (short)14486840;
					switch ((num4 == num3) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_257;
					default:
						goto IL_146;
					}
					break;
				}
				case 9:
					if (flag)
					{
						num3 = (short)362151936;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 10:
					num3 = (short)2140340227;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 11:
				{
					num3 = (short)277151745;
					if (num3 != 0)
					{
					}
					if (!((global::SpecialFeatures.Ucl.Contact.PhoneCallList)phoneCallListRecset[num2]).IsDefaultNode())
					{
						num3 = (short)1107623940;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					num2++;
					num3 = (short)1875378176;
					short num5 = num3;
					num3 = (short)388497420;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 12:
					goto IL_1AA;
				}
				goto IL_44;
				IL_8E:
				num3 = (short)351141897;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_1AA:
				num3 = (short)915013633;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_257:
				flag = false;
				num2 = 0;
				num3 = (short)983433218;
				num = (int)((global::System.IntPtr)num3);
			}
			return true;
			IL_146:
			num3 = (short)665845760;
			if (num3 != 0)
			{
			}
			return false;
			IL_44:
			phoneCallListRecset = (global::SpecialFeatures.Ucl.Contact.PhoneCallListRecset)(self as global::SpecialFeatures.Ucl.Contact.PhoneCallListCallListSection).ParentRecset;
			num3 = (short)203882502;
			num = (int)((global::System.IntPtr)num3);
			goto IL_0A;
		}
	}
}
