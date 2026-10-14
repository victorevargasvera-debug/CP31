using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net;
using System.Text.RegularExpressions;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;
using SharedUtility.Arguments;
using SharedUtility.Attributes;

namespace SharedUtility
{
	// Token: 0x0200000B RID: 11
	public static class SharedConstrains
	{
		// Token: 0x0600001C RID: 28 RVA: 0x00003954 File Offset: 0x00001B54
		[global::Motorola.CommonCPS.Server.EntityModel.ProductCPVersion(Product = (global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.APX | global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.PBB | global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP), Version = "-14.00.00")]
		[global::SharedUtility.Attributes.ConstraintID("ConIndividualIDRangeCheck")]
		public static bool ShareConstraint_ConIndividualIDRangeCheck_01(global::SharedUtility.Arguments.IArgumentOfSharedConstraint args, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
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
					num2 = (short)1137573888;
					short num3 = num2;
					num2 = (short)771817474;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
				{
					int num4;
					int num5;
					if (num4 <= num5)
					{
						num2 = (short)819003392;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1ED;
				}
				case 3:
				{
					string individualID_A = (args as global::SharedUtility.Arguments.ArgOfConIndividualIDRangeCheck).IndividualID_A8287;
					int num4 = 0;
					if (!int.TryParse(individualID_A, out num4))
					{
						num2 = (short)391774214;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)175308801;
					if (num2 != 0)
					{
					}
					int num6 = 1;
					int num5 = 9999999;
					(args as global::SharedUtility.Arguments.ArgOfConIndividualIDRangeCheck).Min = num6;
					(args as global::SharedUtility.Arguments.ArgOfConIndividualIDRangeCheck).Max = num5;
					num2 = (short)1313800197;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
				{
					num2 = (short)2130186206;
					short num7 = num2;
					num2 = (short)1754795998;
					switch ((num7 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_54;
					default:
						goto IL_108;
					}
					break;
				}
				case 5:
				{
					int num4;
					int num6;
					if (num4 >= num6)
					{
						num2 = (short)1038548993;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1ED;
				}
				case 6:
					goto IL_167;
				case 7:
					if (!(args is global::SharedUtility.Arguments.ArgOfConIndividualIDRangeCheck))
					{
						goto IL_54;
					}
					num2 = (short)1158479875;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_30;
				IL_54:
				num2 = (short)555024388;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_108:
			num2 = (short)635699200;
			if (num2 != 0)
			{
			}
			return true;
			IL_167:
			error = global::Motorola.Common.CustomException.CommonErrorCode.Error_RadioID_Empty;
			return false;
			IL_1ED:
			error = global::Motorola.Common.CustomException.CommonErrorCode.Error_RadioID_OutOfRange;
			return false;
			IL_30:
			error = global::Motorola.Common.CustomException.CommonErrorCode.None;
			num2 = (short)1332674567;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003B58 File Offset: 0x00001D58
		[global::Motorola.CommonCPS.Server.EntityModel.ProductCPVersion(Product = (global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.APX | global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.PBB | global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP), Version = "14.00.00")]
		[global::SharedUtility.Attributes.ConstraintID("ConIndividualIDRangeCheck")]
		public static bool ShareConstraint_ConIndividualIDRangeCheck_02(global::SharedUtility.Arguments.IArgumentOfSharedConstraint args, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			short num = (short)138870784;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_5C;
				}
				for (;;)
				{
					IL_29:
					int num3;
					int num5;
					switch (num2)
					{
					case 0:
						num3 = 16777211;
						num = (short)461045765;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						string individualID_A = (args as global::SharedUtility.Arguments.ArgOfConIndividualIDRangeCheck).IndividualID_A8287;
						int num4 = 0;
						if (!int.TryParse(individualID_A, out num4))
						{
							num = (short)749862914;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5 = 1;
						num3 = 9999999;
						num = (short)1670905860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_1D6;
					case 3:
					{
						int num4;
						if (num4 >= num5)
						{
							num = (short)954007553;
							if (num != 0)
							{
							}
							num = (short)603979782;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28F;
					}
					case 4:
					{
						bool isSystemTypeDVRS;
						if (isSystemTypeDVRS)
						{
							num = (short)283836416;
							short num6 = num;
							num = (short)1171849216;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_99;
					}
					case 5:
						goto IL_99;
					case 6:
					{
						num = (short)1732703827;
						short num7 = num;
						num = (short)1558640211;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1D6;
						default:
							num = (short)697499648;
							if (num != 0)
							{
							}
							num = (short)373424136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						return true;
					case 8:
					{
						int num4;
						if (num4 <= num3)
						{
							num = (short)2000486409;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28F;
					}
					case 9:
						return true;
					case 10:
					{
						if (!(args is global::SharedUtility.Arguments.ArgOfConIndividualIDRangeCheck))
						{
							num = (short)1934884871;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bool isSystemTypeDVRS = (args as global::SharedUtility.Arguments.ArgOfConIndividualIDRangeCheck).IsSystemTypeDVRS;
						num = (short)1385889793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_5C;
					IL_99:
					(args as global::SharedUtility.Arguments.ArgOfConIndividualIDRangeCheck).Min = num5;
					(args as global::SharedUtility.Arguments.ArgOfConIndividualIDRangeCheck).Max = num3;
					num = (short)1175257091;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_1D6:
				error = global::Motorola.Common.CustomException.CommonErrorCode.Error_RadioID_Empty;
				return false;
				IL_28F:
				error = global::Motorola.Common.CustomException.CommonErrorCode.Error_RadioID_OutOfRange;
				return false;
				IL_5C:
				error = global::Motorola.Common.CustomException.CommonErrorCode.None;
				num = (short)747372554;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003DFC File Offset: 0x00001FFC
		[global::SharedUtility.Attributes.ConstraintID("ConAddtionalMDCIDChecked")]
		[global::Motorola.CommonCPS.Server.EntityModel.ProductCPVersion(Product = (global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.APX | global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.PBB | global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP))]
		public static bool ShareConstraint_ConAddtionalMDCIDChecked_01(global::SharedUtility.Arguments.IArgumentOfSharedConstraint args, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			int a_ = 3;
			short num = (short)1768357888;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8D;
				}
				for (;;)
				{
					IL_32:
					int num4;
					int num5;
					switch (num2)
					{
					case 0:
						goto IL_338;
					case 1:
						return true;
					case 2:
						goto IL_1CB;
					case 3:
						goto IL_3C7;
					case 4:
					{
						int num3;
						if (num3 <= 57070)
						{
							num = (short)1696923667;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_297;
					}
					case 5:
						IL_40C:
						num = (short)1436680193;
						if (num != 0)
						{
						}
						num4 = 57070;
						num = (short)456196102;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_1D0;
					case 7:
					{
						int num3;
						if (num3 <= num4)
						{
							num = (short)2074738705;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_139;
					}
					case 8:
					{
						bool expandedMDCIDRange_A;
						if (!expandedMDCIDRange_A)
						{
							num = (short)845479951;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3CC;
					}
					case 9:
						error = global::Motorola.Common.CustomException.CommonErrorCode.Error_RadioID_OutOfRange;
						num = (short)803799040;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						bool expandedMDCIDRange_A;
						if (expandedMDCIDRange_A)
						{
							num = (short)1455685641;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						error = global::Motorola.Common.CustomException.CommonErrorCode.Error_RadioID_Contain_F;
						num = (short)99418124;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						num = (short)1412694023;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_292;
					case 13:
					{
						int num3;
						if (num3 >= num5)
						{
							num = (short)538902539;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_139;
					}
					case 14:
					{
						string text;
						if (text.Contains(global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.b("㡽", a_)))
						{
							num = (short)1267073027;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3CC;
					}
					case 15:
						num = (short)897384452;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						string mdcprimaryIDhex_A = (args as global::SharedUtility.Arguments.ArgOfConAddtionalMDCIDChecked).MDCPrimaryIDhex_A8744;
						int num3 = 0;
						if (!int.TryParse(mdcprimaryIDhex_A, out num3))
						{
							num = (short)1217396738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text = num3.ToString(global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.b("♽", a_), global::System.Globalization.CultureInfo.InvariantCulture);
						num = (short)1561460744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						return true;
					case 18:
					{
						bool expandedMDCIDRange_A;
						if (!expandedMDCIDRange_A)
						{
							num = (short)1190854661;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D0;
					}
					case 19:
						num = (short)1065943054;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
					{
						if (!(args is global::SharedUtility.Arguments.ArgOfConAddtionalMDCIDChecked))
						{
							num = (short)258932737;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bool expandedMDCIDRange_A = (args as global::SharedUtility.Arguments.ArgOfConAddtionalMDCIDChecked).ExpandedMDCIDRange_A41761;
						num = (short)508166160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_8D;
					IL_139:
					num = (short)646119434;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D0:
					(args as global::SharedUtility.Arguments.ArgOfConAddtionalMDCIDChecked).Min = num5;
					(args as global::SharedUtility.Arguments.ArgOfConAddtionalMDCIDChecked).Max = num4;
					num = (short)1788341755;
					short num6 = num;
					num = (short)1042083323;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_40C;
					default:
						num = (short)686030848;
						if (num != 0)
						{
						}
						num = (short)1943928845;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_3CC:
					num5 = 1;
					num4 = 65534;
					num = (short)1562771474;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_1CB:
				error = global::Motorola.Common.CustomException.CommonErrorCode.Error_RadioID_Empty;
				return false;
				IL_292:
				goto IL_438;
				IL_297:
				int min = 1;
				int max = 57070;
				(args as global::SharedUtility.Arguments.ArgOfConAddtionalMDCIDChecked).Min = min;
				(args as global::SharedUtility.Arguments.ArgOfConAddtionalMDCIDChecked).Max = max;
				error = global::Motorola.Common.CustomException.CommonErrorCode.Error_RadioID_Contain_F;
				return false;
				IL_338:
				goto IL_438;
				IL_3C7:
				goto IL_297;
				IL_438:
				num = (short)296288256;
				short num7 = num;
				return false;
				IL_8D:
				error = global::Motorola.Common.CustomException.CommonErrorCode.None;
				num = (short)1581252628;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x0000426C File Offset: 0x0000246C
		[global::SharedUtility.Attributes.ConstraintID("ConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_ASTRO25")]
		[global::Motorola.CommonCPS.Server.EntityModel.ProductCPVersion(Product = (global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.APX | global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.PBB | global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP))]
		public static bool ShareConstraint_ConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_ASTRO25_01(global::SharedUtility.Arguments.IArgumentOfSharedConstraint args, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			short num = (short)2099314688;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_5E;
				}
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.List<int> trunkingGroupIDsOfDataProfile;
					switch (num2)
					{
					case 0:
					{
						string unitID_A = (args as global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_ASTRO25).UnitID_A12651;
						int num3 = 0;
						if (!int.TryParse(unitID_A, out num3))
						{
							num = (short)2098069508;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num4 = 1;
						int num5 = 16777211;
						(args as global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_ASTRO25).Min = num4;
						(args as global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_ASTRO25).Max = num5;
						num = (short)666894345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)1536294915;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						int num3;
						if (trunkingGroupIDsOfDataProfile.Contains(num3))
						{
							num = (short)132972551;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 3:
					{
						int num3;
						int num5;
						if (num3 <= num5)
						{
							num = (short)721420294;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B4;
					}
					case 4:
						goto IL_1D0;
					case 5:
						num = (short)1979318274;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_1E0;
					case 7:
						goto IL_D9;
					case 8:
						return true;
					case 9:
					{
						int num3;
						int num4;
						if (num3 >= num4)
						{
							num = (short)2080178176;
							short num6 = num;
							num = (short)601227265;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B4;
					}
					case 10:
						if (trunkingGroupIDsOfDataProfile != null)
						{
							num = (short)1809121285;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 11:
					{
						if (!(args is global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_ASTRO25))
						{
							num = (short)98172936;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)90938784;
						short num7 = num;
						num = (short)2028903840;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1E0;
						default:
							num = (short)289079296;
							if (num != 0)
							{
							}
							num = (short)1142882304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_5E;
					IL_1E0:
					trunkingGroupIDsOfDataProfile = (args as global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_ASTRO25).TrunkingGroupIDsOfDataProfile;
					num = (short)640155658;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_D9:
				num = (short)525991937;
				if (num != 0)
				{
				}
				error = global::Motorola.Common.CustomException.CommonErrorCode.Error_RadioID_DupWithTgIDs;
				return false;
				IL_1D0:
				error = global::Motorola.Common.CustomException.CommonErrorCode.Error_RadioID_Empty;
				return false;
				IL_2B4:
				error = global::Motorola.Common.CustomException.CommonErrorCode.Error_RadioID_OutOfRange;
				return false;
				IL_5E:
				error = global::Motorola.Common.CustomException.CommonErrorCode.None;
				num = (short)1856569355;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00004538 File Offset: 0x00002738
		[global::SharedUtility.Attributes.ConstraintID("ConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII")]
		[global::Motorola.CommonCPS.Server.EntityModel.ProductCPVersion(Product = (global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.APX | global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.PBB | global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP))]
		public static bool ShareConstraint_ConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII_01(global::SharedUtility.Arguments.IArgumentOfSharedConstraint args, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
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
					num2 = (short)2125201409;
					if (num2 != 0)
					{
					}
					num2 = (short)385941504;
					short num3 = num2;
					num2 = (short)1262944258;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
				{
					int num4;
					int num5;
					if (num4 <= num5)
					{
						num2 = (short)304807936;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1ED;
				}
				case 3:
				{
					string unitID_A = (args as global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII).UnitID_A12651;
					int num4 = 0;
					if (!int.TryParse(unitID_A, out num4))
					{
						num2 = (short)23724038;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					int num6 = 1;
					int num5 = 65534;
					(args as global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII).Min = num6;
					(args as global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII).Max = num5;
					num2 = (short)1237516293;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
				{
					num2 = (short)1109701489;
					short num7 = num2;
					num2 = (short)1920906097;
					switch ((num7 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_52;
					default:
						goto IL_10A;
					}
					break;
				}
				case 5:
				{
					int num4;
					int num6;
					if (num4 >= num6)
					{
						num2 = (short)121765889;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1ED;
				}
				case 6:
					goto IL_16A;
				case 7:
					if (!(args is global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII))
					{
						goto IL_52;
					}
					num2 = (short)140443651;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_30;
				IL_52:
				num2 = (short)1815609348;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_10A:
			num2 = (short)1916469248;
			if (num2 != 0)
			{
			}
			return true;
			IL_16A:
			error = global::Motorola.Common.CustomException.CommonErrorCode.Error_RadioID_Empty;
			return false;
			IL_1ED:
			error = global::Motorola.Common.CustomException.CommonErrorCode.Error_RadioID_OutOfRange;
			return false;
			IL_30:
			error = global::Motorola.Common.CustomException.CommonErrorCode.None;
			num2 = (short)2015297543;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x0000473C File Offset: 0x0000293C
		public static bool DataProfileBluetoothDUNSubIPApplicable(bool? autoGenerateIPs, bool? bluetoothEnable, global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType, bool? natEnable, global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode)
		{
			short num = (short)822673408;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				bool? flag;
				bool flag2;
				for (;;)
				{
					switch (0)
					{
					case 0:
						goto IL_6B;
					}
					for (;;)
					{
						IL_28:
						num = (short)231342080;
						short num3 = num;
						bool isAutoGenerateIPAddress;
						switch (num2)
						{
						case 0:
							num = (short)1502085122;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_183;
						case 2:
							isAutoGenerateIPAddress = true;
							goto IL_138;
						case 3:
							isAutoGenerateIPAddress = false;
							goto IL_138;
						case 4:
							if (!(flag.GetValueOrDefault() == flag2 & flag != null))
							{
								num = (short)594870272;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1064632323;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
						IL_138:
						flag = natEnable;
						flag2 = true;
						bool nATEnable = flag.GetValueOrDefault() == flag2 & flag != null;
						global::SharedUtility.SharedSystemType_A21320 systemType2 = global::SharedUtility.SharedConstrains.a(systemType);
						if (!global::SharedUtility.SharedConstrains.ConApplicable_DataProfilesGeneralBTDUNSUIPAddress_A41126(isAutoGenerateIPAddress, systemType2, nATEnable, packetDataMode))
						{
							return false;
						}
						num = (short)402980865;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_6B:
					flag = autoGenerateIPs;
					flag2 = false;
					num = (short)1402098885;
					short num4 = num;
					num = (short)2146653381;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)923336704;
						if (num != 0)
						{
						}
						num = (short)810287108;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_28;
					}
				}
				IL_183:
				num = (short)265420801;
				if (num != 0)
				{
				}
				flag = bluetoothEnable;
				flag2 = true;
				return flag.GetValueOrDefault() == flag2 & flag != null;
			}
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000490C File Offset: 0x00002B0C
		public static bool ConVisibleAndEditable_DataProfilesGeneralBTDUNSUIPAddress_A41126(bool isAutoGenerateIPAddress, global::SharedUtility.SharedSystemType_A21320 systemType)
		{
			short num = (short)703004675;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_D9;
				case 1:
					num = (short)1936719874;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (systemType != global::SharedUtility.SharedSystemType_A21320.CONVENTIONAL)
					{
						goto IL_C2;
					}
					return true;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				}
				IL_34:
				num = (short)1271791617;
				if (num != 0)
				{
				}
				num = (short)1767833600;
				short num3 = num;
				if (!isAutoGenerateIPAddress)
				{
					num = (short)1335623681;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)75716194;
				short num4 = num;
				num = (short)732649058;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_110;
				}
				IL_C2:
				num = (short)2054815744;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_D9:
			return systemType == global::SharedUtility.SharedSystemType_A21320.CONVENTIONALBROADBAND;
			IL_110:
			num = (short)1144389632;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00004A40 File Offset: 0x00002C40
		public static bool ConApplicable_DataProfilesGeneralBTDUNSUIPAddress_A41126(bool isAutoGenerateIPAddress, global::SharedUtility.SharedSystemType_A21320 systemType, bool nATEnable, global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode)
		{
			short num = (short)2007367683;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_F3;
				case 1:
					num = (short)729153538;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (nATEnable)
					{
						goto IL_B6;
					}
					return true;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				}
				IL_35:
				if (global::SharedUtility.SharedConstrains.ConVisibleAndEditable_DataProfilesGeneralBTDUNSUIPAddress_A41126(isAutoGenerateIPAddress, systemType))
				{
					num = (short)1127022592;
					short num3 = num;
					num = (short)664338433;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)232123412;
				short num4 = num;
				num = (short)1216408596;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_129;
				}
				IL_B6:
				num = (short)683409409;
				if (num != 0)
				{
				}
				num = (short)297009152;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_F3:
			global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode2 = packetDataMode;
			global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode packetDataMode3 = global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode.FNE;
			return !(packetDataMode2.GetValueOrDefault() == packetDataMode3 & packetDataMode2 != null);
			IL_129:
			num = (short)1383006208;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00004B90 File Offset: 0x00002D90
		private static global::SharedUtility.SharedSystemType_A21320 a(global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? A_0)
		{
			short num = (short)845742084;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)361562112;
					short num3 = num;
					global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType valueOrDefault = A_0.GetValueOrDefault();
					num = (short)639107075;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					num = (short)216203266;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_74;
				case 3:
				{
					global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType valueOrDefault;
					switch (valueOrDefault)
					{
					case global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.TRUNCKING:
						goto IL_FE;
					case global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.CONVENTIONAL:
						return global::SharedUtility.SharedSystemType_A21320.CONVENTIONAL;
					case global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.BROADBANDONLY:
						return global::SharedUtility.SharedSystemType_A21320.BROADBANDONLY;
					case global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.CONVENTIONALBROADBAND:
						return global::SharedUtility.SharedSystemType_A21320.CONVENTIONALBROADBAND;
					case global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType.TRUNKINGBROADBAND:
						return global::SharedUtility.SharedSystemType_A21320.TRUNKINGBROADBAND;
					default:
						num = (short)1080623105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				}
				IL_3A:
				if (A_0 == null)
				{
					goto IL_172;
				}
				num = (short)1954807808;
				num2 = (int)((global::System.IntPtr)num);
			}
			return global::SharedUtility.SharedSystemType_A21320.BROADBANDONLY;
			IL_74:
			goto IL_172;
			IL_FE:
			num = (short)1344440113;
			short num4 = num;
			num = (short)1720485681;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return global::SharedUtility.SharedSystemType_A21320.CONVENTIONALBROADBAND;
			default:
				num = (short)1336410113;
				if (num != 0)
				{
				}
				num = (short)354680832;
				if (num != 0)
				{
				}
				return global::SharedUtility.SharedSystemType_A21320.TRUNKING;
			}
			return global::SharedUtility.SharedSystemType_A21320.CONVENTIONAL;
			IL_172:
			throw new global::System.ArgumentOutOfRangeException();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00004D14 File Offset: 0x00002F14
		public static bool DataProfileBluetoothDUNPeerIPEditable(bool? autoGenerateIPs, bool? bluetoothEnable, global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType, global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType, bool? natEnable, global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode)
		{
			short num = (short)1317666816;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_56;
				}
				bool? flag3;
				bool flag4;
				bool nATEnable;
				bool autoGenerateIPAddress;
				for (;;)
				{
					IL_27:
					bool flag;
					bool flag2;
					switch (num2)
					{
					case 0:
						goto IL_C8;
					case 1:
					{
						num = (short)809678607;
						short num3 = num;
						num = (short)226211599;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_C8;
						default:
							num = (short)1578434560;
							if (num != 0)
							{
							}
							flag = false;
							goto IL_17E;
						}
						break;
					}
					case 2:
						flag2 = true;
						goto IL_1F7;
					case 3:
						if (!(flag3.GetValueOrDefault() == flag4 & flag3 != null))
						{
							num = (short)1820917760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)838270981;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						flag2 = false;
						goto IL_1F7;
					case 5:
						flag = true;
						goto IL_17E;
					case 6:
						num = (short)437256194;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (flag3.GetValueOrDefault() == flag4 & flag3 != null)
						{
							num = (short)79298561;
							if (num != 0)
							{
							}
							num = (short)1850867720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 8:
						goto IL_1F2;
					case 9:
						if (!(flag3.GetValueOrDefault() == flag4 & flag3 != null))
						{
							num = (short)1365311494;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)851443716;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_56;
					IL_C8:
					num = (short)215416833;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_17E:
					nATEnable = flag;
					flag3 = bluetoothEnable;
					flag4 = true;
					num = (short)910884871;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F7:
					autoGenerateIPAddress = flag2;
					flag3 = natEnable;
					flag4 = true;
					num = (short)1595539456;
					short num4 = num;
					num = (short)748683267;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1F2:
				global::SharedUtility.SharedSystemType_A21320 dataProfileType;
				return global::SharedUtility.SharedConstrains.ConDataProBTDUNPeerIPAddressesIsApplicable_Internal_A41127(dataProfileType, autoGenerateIPAddress, bluetoothDunPeerIpAssignmentType.Value, nATEnable, packetDataMode.Value);
				IL_56:
				dataProfileType = global::SharedUtility.SharedConstrains.a(systemType);
				flag3 = autoGenerateIPs;
				flag4 = false;
				num = (short)452329481;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00004F9C File Offset: 0x0000319C
		public static bool ConDataProBTDUNPeerIPAddressesIsApplicable_Internal_A41127(global::SharedUtility.SharedSystemType_A21320 dataProfileType, bool autoGenerateIPAddress, global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType bluetoothDialupNetworkingAddressesPeerIPAddressAssignmentType, bool nATEnable, global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode packetDataMode)
		{
			if (!global::SharedUtility.SharedConstrains.ConApplicable_DataProfilesGeneralBTDUNSUIPAddress_A41126(autoGenerateIPAddress, dataProfileType, nATEnable, new global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode?(packetDataMode)))
			{
				short num = (short)931594240;
				short num2 = num;
				num = (short)317652993;
				if (num != 0)
				{
				}
				num = (short)716144445;
				short num3 = num;
				num = (short)1432846141;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1924595712;
					if (num != 0)
					{
					}
					return false;
				}
			}
			return bluetoothDialupNetworkingAddressesPeerIPAddressAssignmentType == global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType.DYNAMIC;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00005060 File Offset: 0x00003260
		public static bool DataProfileSubIPandPeerIPEditable(bool? autoGenerateIPs, global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType, bool? natEnable, global::Motorola.CommonCPS.Server.CommonDBConstants.PacketDataMode? packetDataMode)
		{
			short num = (short)2057633792;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_47;
				}
				bool result;
				bool? flag;
				bool flag2;
				global::SharedUtility.SharedSystemType_A21320 systemType2;
				for (;;)
				{
					IL_28:
					bool isAutoGenerateIPAddress;
					switch (num2)
					{
					case 0:
						num = (short)2074083329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						isAutoGenerateIPAddress = true;
						goto IL_11D;
					case 2:
						goto IL_1AA;
					case 3:
						isAutoGenerateIPAddress = false;
						goto IL_11D;
					case 4:
						result = true;
						goto IL_192;
					case 5:
					{
						num = (short)1166523448;
						short num3 = num;
						num = (short)2041035832;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_192;
						default:
							num = (short)444989440;
							if (num != 0)
							{
							}
							if (!(flag.GetValueOrDefault() == flag2 & flag != null))
							{
								num = (short)963182592;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)2082471939;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_47;
					IL_11D:
					flag = natEnable;
					flag2 = true;
					bool nATEnable = flag.GetValueOrDefault() == flag2 & flag != null;
					if (global::SharedUtility.SharedConstrains.ConApplicable_DataProfilesGeneralBTDUNSUIPAddress_A41126(isAutoGenerateIPAddress, systemType2, nATEnable, packetDataMode))
					{
						num = (short)1564999680;
						short num4 = num;
						num = (short)901447684;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_192:
					num = (short)2025979906;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1AA:
				num = (short)1777795073;
				if (num != 0)
				{
				}
				return result;
				IL_47:
				result = false;
				systemType2 = global::SharedUtility.SharedConstrains.a(systemType);
				flag = autoGenerateIPs;
				flag2 = false;
				num = (short)82837509;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00005244 File Offset: 0x00003444
		public static bool AirInterfaceIPEditable(bool? autoGenerateIPs, global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemType? systemType)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			bool? flag;
			bool flag2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1136132096;
					short num3 = num2;
					num2 = (short)2006835067;
					short num4 = num2;
					num2 = (short)706076539;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_DB;
					}
					break;
				}
				case 1:
					if (!(flag.GetValueOrDefault() == flag2 & flag != null))
					{
						num2 = (short)35913731;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)927924224;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_131;
				case 3:
					num2 = (short)1111687170;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			IL_DB:
			num2 = (short)1239941121;
			if (num2 != 0)
			{
			}
			num2 = (short)1762000896;
			if (num2 != 0)
			{
			}
			bool isAutoGenerateIPAddress = false;
			goto IL_134;
			IL_131:
			isAutoGenerateIPAddress = true;
			IL_134:
			global::SharedUtility.SharedSystemType_A21320 systemType2 = global::SharedUtility.SharedConstrains.a(systemType);
			return global::SharedUtility.SharedConstrains.ConVisibleAndEditable_DataProfilesGeneralBTDUNSUIPAddress_A41126(isAutoGenerateIPAddress, systemType2);
			IL_20:
			flag = autoGenerateIPs;
			flag2 = false;
			num2 = (short)943194113;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00005394 File Offset: 0x00003594
		public static bool OtarIDEditable(bool? otarEnable, bool? astroOtarEnable, global::Motorola.CommonCPS.Server.CommonDBConstants.SecureOperation? secureOperation)
		{
			short num = (short)498335744;
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
				bool? flag;
				bool flag2;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						flag = astroOtarEnable;
						flag2 = true;
						num = (short)1623523330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)1584005121;
						if (num != 0)
						{
						}
						goto IL_E9;
					case 2:
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)923664390;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E9;
					case 3:
						num = (short)1049296901;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						return true;
					case 5:
						if (secureOperation == null)
						{
							num = (short)335282180;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 6:
					{
						num = (short)1767650009;
						short num3 = num;
						num = (short)1607152345;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_102;
						default:
						{
							num = (short)310181888;
							if (num != 0)
							{
							}
							num = (short)1973878784;
							short num4 = num;
							global::Motorola.CommonCPS.Server.CommonDBConstants.SecureOperation? secureOperation2 = secureOperation;
							global::Motorola.CommonCPS.Server.CommonDBConstants.SecureOperation secureOperation3 = global::Motorola.CommonCPS.Server.CommonDBConstants.SecureOperation.HARDWARE;
							num = (short)1974468615;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 7:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.SecureOperation? secureOperation2;
						global::Motorola.CommonCPS.Server.CommonDBConstants.SecureOperation secureOperation3;
						if (!(secureOperation2.GetValueOrDefault() == secureOperation3 & secureOperation2 != null))
						{
							num = (short)1331036161;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 8:
						if (astroOtarEnable != null)
						{
							num = (short)2142044163;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 9:
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)982122496;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E9;
					case 10:
						num = (short)327483400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_102;
					}
					goto IL_5E;
					IL_E9:
					num = (short)1193410571;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_102:
					if (otarEnable == null)
					{
						break;
					}
					num = (short)1198981130;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_5E:
				flag = otarEnable;
				flag2 = true;
				num = (short)1498349577;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00005648 File Offset: 0x00003848
		public static bool OtarIDEditable_7175(bool? otarEnable, bool? astroOtarEnable, global::Motorola.CommonCPS.Server.CommonDBConstants.SecureOperation? secureOperation, bool? aesEnable)
		{
			short num = (short)11141120;
			switch (num)
			{
			default:
			{
				num = (short)434241546;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool flag;
					switch (num2)
					{
					case 0:
						num = (short)1831403521;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (astroOtarEnable != null)
						{
							num = (short)1653080070;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 2:
					{
						bool? flag2;
						bool flag3;
						flag = (flag2.GetValueOrDefault() == flag3 & flag2 != null);
						goto IL_285;
					}
					case 3:
						return true;
					case 4:
					{
						bool? flag2;
						bool flag3;
						if (flag2.GetValueOrDefault() == flag3 & flag2 != null)
						{
							num = (short)130482183;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)911474688;
						short num3 = num;
						num = (short)615579656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (secureOperation != null)
						{
							num = (short)1800732684;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 6:
					{
						num = (short)213813952;
						short num4 = num;
						num = (short)1055099584;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_33;
						default:
							num = (short)453246976;
							if (num != 0)
							{
							}
							num = (short)2050949125;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
					{
						num = (short)1162346497;
						if (num != 0)
						{
						}
						bool? flag2 = astroOtarEnable;
						bool flag3 = true;
						num = (short)1294925826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						flag = false;
						goto IL_285;
					case 9:
					{
						if (aesEnable == null)
						{
							num = (short)699269123;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bool? flag2 = otarEnable;
						bool flag3 = true;
						num = (short)325976068;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_33;
					case 11:
						return true;
					case 12:
						num = (short)728367113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_78;
					IL_33:
					switch (0)
					{
					case 0:
						IL_78:
						if (otarEnable == null)
						{
							return true;
						}
						num = (short)1583546368;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					continue;
					IL_285:
					global::Motorola.CommonCPS.Server.CommonDBConstants.SecureOperation? secureOperation2 = secureOperation;
					global::Motorola.CommonCPS.Server.CommonDBConstants.SecureOperation secureOperation3 = global::Motorola.CommonCPS.Server.CommonDBConstants.SecureOperation.HARDWARE;
					bool flag4;
					if (!(secureOperation2.GetValueOrDefault() == secureOperation3 & secureOperation2 != null))
					{
						secureOperation2 = secureOperation;
						secureOperation3 = global::Motorola.CommonCPS.Server.CommonDBConstants.SecureOperation.SOFTWARE;
						if (secureOperation2.GetValueOrDefault() == secureOperation3 & secureOperation2 != null)
						{
							bool? flag2 = aesEnable;
							bool flag3 = true;
							flag4 = (flag2.GetValueOrDefault() == flag3 & flag2 != null);
						}
						else
						{
							flag4 = false;
						}
					}
					else
					{
						flag4 = true;
					}
					bool flag5 = flag4;
					if (!flag || !flag5)
					{
						return false;
					}
					num = (short)2046165003;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
			}
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00005954 File Offset: 0x00003B54
		public static bool RadioAliasEditable(bool? radioAliasEnable)
		{
			short num = (short)594122136;
			short num2 = num;
			num = (short)1387500952;
			switch (num2 == num)
			{
			}
			num = (short)827326465;
			if (num != 0)
			{
			}
			num = (short)1917059072;
			if (num != 0)
			{
			}
			num = (short)805175296;
			short num3 = num;
			bool? flag = radioAliasEnable;
			bool flag2 = false;
			return !(flag.GetValueOrDefault() == flag2 & flag != null);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00005A18 File Offset: 0x00003C18
		public static bool UserLoginUnitIDEnable(bool? userLoginUnitIDEnable)
		{
			short num = (short)351366785;
			short num2 = num;
			num = (short)1221488257;
			switch (num2 == num)
			{
			}
			num = (short)2065629185;
			if (num != 0)
			{
			}
			num = (short)213909504;
			if (num != 0)
			{
			}
			num = (short)1066008576;
			short num3 = num;
			bool? flag = userLoginUnitIDEnable;
			bool flag2 = false;
			return !(flag.GetValueOrDefault() == flag2 & flag != null);
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00005AD8 File Offset: 0x00003CD8
		public static bool DVRSHardwareEnable(bool? dvrsHardwareEnable)
		{
			short num = (short)1888327444;
			short num2 = num;
			num = (short)2010486548;
			switch (num2 == num)
			{
			}
			num = (short)1863712768;
			if (num != 0)
			{
			}
			num = (short)2119565313;
			if (num != 0)
			{
			}
			num = (short)686096384;
			short num3 = num;
			bool? flag = dvrsHardwareEnable;
			bool flag2 = false;
			return !(flag.GetValueOrDefault() == flag2 & flag != null);
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00005B9C File Offset: 0x00003D9C
		public static bool BluetoothDUNPeerIPEditable(bool? bluetoothEnable, global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? assignmentType)
		{
			short num = (short)629342208;
			switch (num)
			{
			default:
			{
				num = (short)1236664323;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1217767612;
						short num3 = num;
						num = (short)1749592252;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_17A;
						default:
							goto IL_13E;
						}
						break;
					}
					case 1:
						if (assignmentType != null)
						{
							goto IL_17A;
						}
						return true;
					case 2:
						num = (short)67502081;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_5C;
						}
						continue;
					case 4:
					{
						bool? flag = bluetoothEnable;
						bool flag2 = true;
						num = (short)1319829509;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						num = (short)1450311681;
						if (num != 0)
						{
						}
						bool? flag;
						bool flag2;
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)1900281856;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_197;
					}
					}
					IL_5C:
					if (bluetoothEnable != null)
					{
						num = (short)212205570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
					IL_17A:
					num = (short)98566148;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_13E:
				num = (short)480575488;
				if (num != 0)
				{
				}
				global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType = assignmentType;
				global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType bluetoothDunPeerIpAssignmentType2 = global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType.DYNAMIC;
				return bluetoothDunPeerIpAssignmentType.GetValueOrDefault() == bluetoothDunPeerIpAssignmentType2 & bluetoothDunPeerIpAssignmentType != null;
				IL_197:
				num = (short)1495531520;
				short num4 = num;
				return false;
			}
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00005D6C File Offset: 0x00003F6C
		public static bool BluetoothDUNSubscriberIPEditable(bool? bluetoothEnable)
		{
			short num = (short)1911659210;
			short num2 = num;
			num = (short)853514954;
			switch (num2 == num)
			{
			}
			num = (short)1471086593;
			if (num != 0)
			{
			}
			num = (short)2136276992;
			if (num != 0)
			{
			}
			num = (short)271450112;
			short num3 = num;
			bool? flag = bluetoothEnable;
			bool flag2 = false;
			return !(flag.GetValueOrDefault() == flag2 & flag != null);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00005E2C File Offset: 0x0000402C
		public static bool BluetoothFriendlyNameEditable(bool? bluetoothEnable)
		{
			short num = (short)665197346;
			short num2 = num;
			num = (short)1748769570;
			switch (num2 == num)
			{
			}
			num = (short)1183449088;
			if (num != 0)
			{
			}
			num = (short)49872897;
			if (num != 0)
			{
			}
			num = (short)24641536;
			short num3 = num;
			bool? flag = bluetoothEnable;
			bool flag2 = false;
			return !(flag.GetValueOrDefault() == flag2 & flag != null);
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00005EF0 File Offset: 0x000040F0
		public static bool ValidateDataWideSubscriberIP(string subscriberIP, string peerIP, string bluetoothDUNPeerIP, string bluetoothDUNSubscriberIP, bool? bluetoothEnable, global::System.Collections.Generic.List<string> dataprofilePeerIPs, global::System.Collections.Generic.List<string> dataprofileAirInterfaceIPs, global::System.Collections.Generic.List<string> dataprofileAutomaticRegistrationServerIPs, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			switch (0)
			{
			case 0:
				goto IL_94;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				bool? flag;
				bool flag2;
				switch (num)
				{
				case 0:
					goto IL_2AB;
				case 1:
				{
					num2 = (short)988443008;
					short num3 = num2;
					num2 = (short)226718080;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D9;
					default:
						num2 = (short)925827072;
						if (num2 != 0)
						{
						}
						if (error == global::Motorola.Common.CustomException.CommonErrorCode.None)
						{
							num2 = (short)1225195520;
							short num4 = num2;
							num2 = (short)173473818;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_356;
					}
					break;
				}
				case 2:
					if (bluetoothDUNPeerIP != null)
					{
						num2 = (short)264765464;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_53B;
				case 3:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubIP_NoSame_PeerIP;
					num2 = (short)1226637330;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)2095120406;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_356;
				case 6:
					goto IL_53B;
				case 7:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_BluetoothDUNSubIP_NoSame_SubIP;
					num2 = (short)712441861;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					num2 = (short)434044930;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					num2 = (short)1030815745;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					num2 = (short)594870273;
					if (num2 != 0)
					{
					}
					if (error == global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num2 = (short)1899167748;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_48C;
				case 11:
					if (bluetoothDUNPeerIP.Trim().Equals(subscriberIP.Trim()))
					{
						num2 = (short)2032992287;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_53B;
				case 12:
					if (bluetoothDUNSubscriberIP != null)
					{
						num2 = (short)2010775561;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_356;
				case 13:
					if (error == global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num2 = (short)975568921;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2AB;
				case 14:
					num2 = (short)1812398090;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					goto IL_1D9;
				case 16:
					num2 = (short)422707215;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					num2 = (short)1168506907;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					goto IL_48C;
				case 19:
					if (!(flag.GetValueOrDefault() == flag2 & flag != null))
					{
						num2 = (short)244056072;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_356;
				case 20:
					if (error != global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num2 = (short)1332805664;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 21:
					if (bluetoothDUNSubscriberIP.Trim().Equals(subscriberIP.Trim()))
					{
						num2 = (short)1780416519;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_356;
				case 22:
					if (subscriberIP.Trim().Equals(peerIP.Trim()))
					{
						num2 = (short)1275592707;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_48C;
				case 23:
					if (error == global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num2 = (short)1275265052;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_53B;
				case 24:
					num2 = (short)128450583;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
					global::SharedUtility.SharedConstrains.SharedCon_ConSubIpAddress1Valid_External(subscriberIP, dataprofilePeerIPs, dataprofileAirInterfaceIPs, dataprofileAutomaticRegistrationServerIPs, out error);
					num2 = (short)652410880;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 26:
					num2 = (short)1120534549;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 27:
					if (global::SharedUtility.Utility.ValidateIPFormat(subscriberIP, out error))
					{
						num2 = (short)108462096;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2AB;
				case 28:
					num2 = (short)947388427;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 29:
					return result;
				case 30:
					if (!string.IsNullOrEmpty(subscriberIP))
					{
						num2 = (short)22806545;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2AB;
				case 31:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_BluetoothDUNPeerIP_NoSame_SubIP;
					num2 = (short)373358598;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 32:
					result = false;
					num2 = (short)664535069;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_94;
				IL_1D9:
				if (peerIP != null)
				{
					num2 = (short)1165885454;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_48C;
				IL_2AB:
				num2 = (short)1865023508;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_356:
				num2 = (short)396165133;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_48C:
				flag = bluetoothEnable;
				flag2 = false;
				num2 = (short)1579089939;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_53B:
				num2 = (short)983052;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_94:
			error = global::Motorola.Common.CustomException.CommonErrorCode.None;
			result = true;
			num2 = (short)1426259998;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00006474 File Offset: 0x00004674
		public static bool SharedCon_ConSubIpAddress1Valid_External(string subscriberIP_A9222, global::System.Collections.Generic.List<string> dataprofilePeerIPs_A8523, global::System.Collections.Generic.List<string> dataprofileAirInterfaceIPs_A9220, global::System.Collections.Generic.List<string> dataprofileAutomaticRegistrationServerIPs_A7524, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			short num = (short)1234239488;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_77;
				}
				bool result;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						if (error == global::Motorola.Common.CustomException.CommonErrorCode.None)
						{
							num = (short)936968203;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E2;
					case 1:
						num = (short)1940389891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return result;
					case 3:
						if (error == global::Motorola.Common.CustomException.CommonErrorCode.None)
						{
							num = (short)1413939208;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_605;
					case 4:
						if (dataprofileAirInterfaceIPs_A9220 != null)
						{
							num = (short)152174605;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_661;
					case 5:
						num = (short)563281921;
						if (num != 0)
						{
						}
						goto IL_2C7;
					case 6:
						try
						{
							num = (short)873005060;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									string text;
									if (subscriberIP_A9222.Trim().Equals(text.Trim()))
									{
										num = (short)1636106243;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									goto IL_245;
								case 2:
								{
									global::System.Collections.Generic.List<string>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1949106182;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string text = enumerator.Current;
									num = (short)1136590848;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubAirInterfaceIP_NoSame_SubIP;
									num = (short)396230657;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_1EF;
									}
									continue;
								case 5:
									goto IL_2B4;
								case 6:
									num = (short)2087321605;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1F1:
								num = (short)1213005826;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1EF:
								goto IL_1F1;
							}
							IL_245:
							IL_2B4:
							goto IL_661;
						}
						finally
						{
							global::System.Collections.Generic.List<string>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto Block_4;
					case 7:
						goto IL_421;
						try
						{
							for (;;)
							{
								IL_421:
								num = (short)2095579140;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)599785477;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
									{
										global::System.Collections.Generic.List<string>.Enumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1583218688;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										string text2 = enumerator.Current;
										num = (short)617086978;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
									{
										string text2;
										if (subscriberIP_A9222.Trim().Equals(text2.Trim()))
										{
											num = (short)260964358;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 3:
										goto IL_55F;
									case 4:
										switch (0)
										{
										case 0:
											goto IL_463;
										}
										continue;
									case 5:
										goto IL_57C;
									case 6:
										error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubIP_NoSame_AutomaticRegistrationServerAddressIP;
										num = (short)1426391043;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_4B4:
									num = (short)702726220;
									short num3 = num;
									num = (short)862306380;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_421;
									default:
										num = (short)320274432;
										if (num != 0)
										{
										}
										num = (short)1611857921;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_463:
									goto IL_4B4;
								}
							}
							IL_55F:
							IL_57C:
							goto IL_3E2;
						}
						finally
						{
							global::System.Collections.Generic.List<string>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_58F;
					case 8:
					{
						global::System.Collections.Generic.List<string>.Enumerator enumerator = dataprofilePeerIPs_A8523.GetEnumerator();
						num = (short)1604648965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (dataprofileAutomaticRegistrationServerIPs_A7524 != null)
						{
							num = (short)535625738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E2;
					case 10:
						num = (short)224460800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						global::System.Collections.Generic.List<string>.Enumerator enumerator = dataprofileAutomaticRegistrationServerIPs_A7524.GetEnumerator();
						num = (short)1085407239;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						global::System.Collections.Generic.List<string>.Enumerator enumerator = dataprofileAirInterfaceIPs_A9220.GetEnumerator();
						num = (short)369819654;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_58F;
					case 14:
						if (error == global::Motorola.Common.CustomException.CommonErrorCode.None)
						{
							num = (short)149487628;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_661;
					case 15:
						if (dataprofilePeerIPs_A8523 != null)
						{
							num = (short)2105737217;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_605;
					case 16:
					{
						result = false;
						num = (short)1501298688;
						short num4 = num;
						num = (short)1066926082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						if (error != global::Motorola.Common.CustomException.CommonErrorCode.None)
						{
							num = (short)368181264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					goto IL_77;
					IL_3E2:
					num = (short)567017489;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_4:
					try
					{
						IL_2C7:
						num = (short)880148484;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								string text3;
								if (subscriberIP_A9222.Trim().Equals(text3.Trim()))
								{
									num = (short)1006895107;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								num = (short)1372782597;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_32A;
							case 3:
								error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubIP_NoSame_ProfilePeerIP;
								num = (short)541392898;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_30A;
								}
								continue;
							case 5:
								goto IL_3CF;
							case 6:
							{
								global::System.Collections.Generic.List<string>.Enumerator enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)870973441;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								string text3 = enumerator.Current;
								num = (short)2096300032;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_32F:
							num = (short)1582301190;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_30A:
							goto IL_32F;
						}
						IL_32A:
						IL_3CF:
						goto IL_605;
					}
					finally
					{
						global::System.Collections.Generic.List<string>.Enumerator enumerator;
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_3E2;
					IL_58F:
					num = (short)1405681678;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_605:
					num = (short)1019346948;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_661:
					num = (short)259588105;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_77:
				result = true;
				error = global::Motorola.Common.CustomException.CommonErrorCode.None;
				num = (short)593362959;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00006B6C File Offset: 0x00004D6C
		public static bool SharedCon_ConSubIpAddress1Valid_External(bool DVRSMSUOperation, string subscriberIP_A9222, global::System.Collections.Generic.List<string> dataprofilePeerIPs_A8523, global::System.Collections.Generic.List<string> dataprofileAirInterfaceIPs_A9220, global::System.Collections.Generic.List<string> dataprofileAutomaticRegistrationServerIPs_A7524, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			short num = (short)381222912;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_76;
				}
				bool result;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (error == global::Motorola.Common.CustomException.CommonErrorCode.None)
						{
							num = (short)1820196872;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_65D;
					case 1:
						if (dataprofilePeerIPs_A8523 != null)
						{
							num = (short)371130379;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5D6;
					case 2:
						goto IL_29D;
					case 3:
						num = (short)1658126353;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_55F;
					case 5:
						if (dataprofileAirInterfaceIPs_A9220 != null)
						{
							num = (short)1035927556;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_65D;
					case 6:
					{
						global::System.Collections.Generic.List<string>.Enumerator enumerator = dataprofileAutomaticRegistrationServerIPs_A7524.GetEnumerator();
						num = (short)282722314;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (dataprofileAutomaticRegistrationServerIPs_A7524 != null)
						{
							num = (short)305987587;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B5;
					case 8:
					{
						global::System.Collections.Generic.List<string>.Enumerator enumerator = dataprofileAirInterfaceIPs_A9220.GetEnumerator();
						num = (short)1370619920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (error != global::Motorola.Common.CustomException.CommonErrorCode.None)
						{
							num = (short)1671364623;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 10:
						goto IL_3F3;
						try
						{
							for (;;)
							{
								IL_3F3:
								num = (short)1573781504;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_435;
										}
										continue;
									case 1:
										num = (short)297271298;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_54C;
									case 3:
									{
										global::System.Collections.Generic.List<string>.Enumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1785331713;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										string text = enumerator.Current;
										num = (short)1447297030;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubIP_NoSame_AutomaticRegistrationServerAddressIP;
										num = (short)1238892549;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
										goto IL_52F;
									case 6:
									{
										string text;
										if (subscriberIP_A9222.Trim().Equals(text.Trim()))
										{
											num = (short)1033568260;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									IL_485:
									num = (short)850843893;
									short num3 = num;
									num = (short)1107351797;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_3F3;
									default:
										num = (short)1272578048;
										if (num != 0)
										{
										}
										num = (short)439156739;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_435:
									goto IL_485;
								}
							}
							IL_52F:
							IL_54C:
							goto IL_3B5;
						}
						finally
						{
							global::System.Collections.Generic.List<string>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_55F;
					case 11:
						num = (short)1951465484;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (error == global::Motorola.Common.CustomException.CommonErrorCode.None)
						{
							num = (short)1882062862;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5D6;
					case 13:
						goto IL_156;
					case 14:
					{
						global::System.Collections.Generic.List<string>.Enumerator enumerator = dataprofilePeerIPs_A8523.GetEnumerator();
						num = (short)43581442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						result = false;
						num = (short)506134541;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)2024013825;
						if (num != 0)
						{
						}
						try
						{
							num = (short)1878720512;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1C8;
									}
									continue;
								case 1:
								{
									string text2;
									if (subscriberIP_A9222.Trim().Equals(text2.Trim()))
									{
										num = (short)18743301;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_28A;
								case 3:
									goto IL_21C;
								case 4:
									num = (short)1409941506;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubAirInterfaceIP_NoSame_SubIP;
									num = (short)1716191235;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::System.Collections.Generic.List<string>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)23920644;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									string text2 = enumerator.Current;
									num = (short)391905281;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1CA:
								num = (short)277676038;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1C8:
								goto IL_1CA;
							}
							IL_21C:
							IL_28A:
							goto IL_65D;
						}
						finally
						{
							global::System.Collections.Generic.List<string>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto Block_4;
					case 17:
						if (error == global::Motorola.Common.CustomException.CommonErrorCode.None)
						{
							num = (short)921042950;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B5;
					}
					goto IL_76;
					IL_3B5:
					num = (short)996671497;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_4:
					try
					{
						IL_29D:
						num = (short)2006253568;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_2DF;
								}
								continue;
							case 1:
							{
								string text3;
								if (subscriberIP_A9222.Trim().Equals(text3.Trim()))
								{
									num = (short)20119557;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
								goto IL_3A2;
							case 3:
								num = (short)1362231298;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								global::System.Collections.Generic.List<string>.Enumerator enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)450756611;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								string text3 = enumerator.Current;
								num = (short)1643708417;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubIP_NoSame_ProfilePeerIP;
								num = (short)424411142;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								goto IL_2FE;
							}
							IL_303:
							num = (short)260243460;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_2DF:
							goto IL_303;
						}
						IL_2FE:
						IL_3A2:
						goto IL_5D6;
					}
					finally
					{
						global::System.Collections.Generic.List<string>.Enumerator enumerator;
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_3B5;
					IL_55F:
					num = (short)178388992;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5D6:
					num = (short)24903685;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_65D:
					num = (short)960102407;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_156:
				num = (short)1993801728;
				short num4 = num;
				return result;
				IL_76:
				result = true;
				error = global::Motorola.Common.CustomException.CommonErrorCode.None;
				num = (short)1900545;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00007264 File Offset: 0x00005464
		public static bool ValidateDataWidePeerIP(string peerIP, string subscriberIP, string bluetoothDUNPeerIP, string bluetoothDUNSubscriberIP, bool? bluetoothEnable, global::System.Collections.Generic.List<string> airInterfaceIPs, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			switch (0)
			{
			case 0:
				goto IL_80;
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
					if (airInterfaceIPs != null)
					{
						num2 = (short)1016135701;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_34F;
				case 1:
					num2 = (short)1318387725;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					result = false;
					num2 = (short)1496317959;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (global::SharedUtility.SharedConstrains.SharedCon_ConEnsureSameSubnetBetweenDCEAndDTE_Internal(peerIP, subscriberIP, out error))
					{
						num2 = (short)1775108122;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_34F;
				case 4:
					num2 = (short)1434320899;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_BluetoothDUNPeerIP_NoSame_PeerIP;
					num2 = (short)1499660300;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (peerIP.Trim().Equals(bluetoothDUNPeerIP.Trim()))
					{
						num2 = (short)1957429253;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_28F;
				case 7:
					return result;
				case 8:
					goto IL_34F;
				case 9:
					goto IL_C5;
				case 10:
				{
					bool? flag;
					bool flag2;
					if (!(flag.GetValueOrDefault() == flag2 & flag != null))
					{
						num2 = (short)1052966935;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_C5;
				}
				case 11:
					if (!string.IsNullOrEmpty(peerIP))
					{
						num2 = (short)1403912196;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_34F;
				case 12:
					goto IL_28F;
				case 13:
					if (error == global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num2 = (short)1105788943;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_28F;
				case 14:
					if (error != global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num2 = (short)313917442;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 15:
					num2 = (short)802226182;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					if (error == global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num2 = (short)1367670808;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_34F;
				case 17:
					num2 = (short)1976369153;
					if (num2 != 0)
					{
					}
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_BluetoothDUNSubIP_NoSame_PeerIP;
					num2 = (short)1542914057;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					num2 = (short)1336999956;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					num2 = (short)363593750;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					if (peerIP.Trim().Equals(bluetoothDUNSubscriberIP.Trim()))
					{
						num2 = (short)2035613713;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_C5;
				case 21:
				{
					num2 = (short)678232064;
					short num3 = num2;
					num2 = (short)98500624;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 22:
					if (error == global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num2 = (short)1871249426;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_C5;
				case 23:
					num2 = (short)654573595;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					global::SharedUtility.SharedConstrains.SharedCon_ConEnsureSameSubnetBetweenDCEAndDTE_External(peerIP, airInterfaceIPs, out error);
					num2 = (short)1936392200;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
					if (bluetoothDUNSubscriberIP != null)
					{
						goto IL_2F9;
					}
					goto IL_C5;
				case 26:
				{
					bool? flag = bluetoothEnable;
					bool flag2 = false;
					num2 = (short)1303969802;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 27:
					if (bluetoothDUNPeerIP != null)
					{
						num2 = (short)453246977;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_28F;
				}
				goto IL_80;
				IL_C5:
				num2 = (short)1431044096;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_28F:
				num2 = (short)924569084;
				short num4 = num2;
				num2 = (short)39505404;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_2F9:
					num2 = (short)1492058131;
					num = (int)((global::System.IntPtr)num2);
					continue;
				default:
					num2 = (short)501940224;
					if (num2 != 0)
					{
					}
					num2 = (short)2096627737;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				IL_34F:
				num2 = (short)1078525966;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_80:
			error = global::Motorola.Common.CustomException.CommonErrorCode.None;
			result = true;
			num2 = (short)2147287051;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00007724 File Offset: 0x00005924
		public static bool SharedCon_ConEnsureSameSubnetBetweenDCEAndDTE_Internal(string peerIP_A8524, string SubIP1_A9222, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
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
					if (peerIP_A8524.Trim().Equals(SubIP1_A9222.Trim()))
					{
						num2 = (short)1882914825;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_AB;
				case 1:
					return result;
				case 2:
					num2 = (short)970915840;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_AB;
				case 4:
					num2 = (short)2047934465;
					if (num2 != 0)
					{
					}
					num2 = (short)1636827142;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_85;
				case 6:
					if (SubIP1_A9222 != null)
					{
						num2 = (short)755892232;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_AB;
				case 7:
					result = false;
					num2 = (short)1691484161;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					num2 = (short)1211367434;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubIP_NoSame_PeerIP;
					num2 = (short)1540227075;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (error == global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num2 = (short)1834024962;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_AB;
				case 11:
				{
					num2 = (short)67261210;
					short num3 = num2;
					num2 = (short)2021085978;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_85;
					default:
						num2 = (short)2111504384;
						if (num2 != 0)
						{
						}
						if (error != global::Motorola.Common.CustomException.CommonErrorCode.None)
						{
							num2 = (short)1492647943;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				}
				goto IL_40;
				IL_85:
				if (global::SharedUtility.Utility.ValidateIPFormat(peerIP_A8524, out error))
				{
					num2 = (short)2046492676;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				IL_AB:
				num2 = (short)1253048331;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_40:
			error = global::Motorola.Common.CustomException.CommonErrorCode.None;
			result = true;
			num2 = (short)1628831744;
			short num4 = num2;
			num2 = (short)1556676613;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00007988 File Offset: 0x00005B88
		public static bool SharedCon_ConEnsureSameSubnetBetweenDCEAndDTE_External(bool DVRSMSUOperation, string peerIP__A41818, string peerIP_A8524, global::System.Collections.Generic.List<string> airInterfaceIPs__A9220, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			switch (0)
			{
			case 0:
				goto IL_7E;
			}
			short num;
			int num3;
			bool result;
			for (;;)
			{
				IL_0A:
				num = (short)1573453824;
				short num2 = num;
				switch (num3)
				{
				case 0:
					result = false;
					num = (short)228130821;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (airInterfaceIPs__A9220 != null)
					{
						num = (short)1771765770;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_247;
				case 2:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_PeerIP_NoSame_PeerIPLink2;
					num = (short)1538195469;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (DVRSMSUOperation)
					{
						num = (short)776339471;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_161;
				case 4:
					num = (short)1784414217;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					return result;
				case 6:
					if (error == global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num = (short)1885732868;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_161;
				case 7:
					if (global::SharedUtility.Utility.ValidateIPFormat(peerIP_A8524, out error))
					{
						num = (short)1063911435;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_247;
				case 8:
					goto IL_282;
					try
					{
						for (;;)
						{
							IL_282:
							num = (short)945029120;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_2C2;
									}
									continue;
								case 1:
								{
									global::System.Collections.Generic.List<string>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)195297285;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									string text = enumerator.Current;
									num = (short)1727725572;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_3D8;
								case 3:
									error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_PeerIP_NoSame_AirInterfaceIP;
									num = (short)539099142;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									num = (short)1432245588;
									short num4 = num;
									num = (short)1805145428;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_282;
									default:
									{
										num = (short)1175388160;
										if (num != 0)
										{
										}
										string text;
										if (peerIP_A8524.Trim().Equals(text.Trim()))
										{
											num = (short)1130823683;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									break;
								}
								case 5:
									num = (short)894894082;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_2E5;
								}
								IL_381:
								num = (short)1668087809;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_2C2:
								goto IL_381;
							}
						}
						IL_2E5:
						IL_3D8:
						goto IL_247;
					}
					finally
					{
						global::System.Collections.Generic.List<string>.Enumerator enumerator;
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_3EB;
				case 9:
					if (peerIP_A8524.Trim().Equals(peerIP__A41818.Trim()))
					{
						num = (short)982122498;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_161;
				case 10:
					num = (short)1969094663;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
				{
					num = (short)405798913;
					if (num != 0)
					{
					}
					global::System.Collections.Generic.List<string>.Enumerator enumerator = airInterfaceIPs__A9220.GetEnumerator();
					num = (short)188874760;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 12:
					goto IL_3EB;
				case 13:
					goto IL_161;
				case 14:
					if (error != global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num = (short)1134755840;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 15:
					num = (short)2106523664;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (peerIP__A41818 != null)
					{
						num = (short)670564364;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_161;
				}
				goto IL_7E;
				IL_161:
				num = (short)1190330382;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_247:
				num = (short)457048067;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_3EB:
				num = (short)518258694;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_7E:
			error = global::Motorola.Common.CustomException.CommonErrorCode.None;
			result = true;
			num = (short)1821900801;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00007DD8 File Offset: 0x00005FD8
		public static bool SharedCon_ConEnsureSameSubnetBetweenDCEAndDTE_External(string peerIP_A8524, global::System.Collections.Generic.List<string> airInterfaceIPs__A9220, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
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
				{
					global::System.Collections.Generic.List<string>.Enumerator enumerator = airInterfaceIPs__A9220.GetEnumerator();
					num2 = (short)503119878;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					if (airInterfaceIPs__A9220 != null)
					{
						num2 = (short)2119237636;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_69;
				case 2:
					result = false;
					goto IL_28E;
				case 3:
				{
					num2 = (short)1802895360;
					short num3 = num2;
					num2 = (short)1813592544;
					short num4 = num2;
					num2 = (short)753285600;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_28E;
					default:
						num2 = (short)1961492480;
						if (num2 != 0)
						{
						}
						if (error != global::Motorola.Common.CustomException.CommonErrorCode.None)
						{
							num2 = (short)1410007042;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				case 4:
					goto IL_229;
				case 5:
					return result;
				case 6:
					try
					{
						num2 = (short)2021851136;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_15A;
								}
								continue;
							case 1:
								num2 = (short)1539440642;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								goto IL_216;
							case 3:
							{
								global::System.Collections.Generic.List<string>.Enumerator enumerator;
								if (!enumerator.MoveNext())
								{
									num2 = (short)1505755137;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								string text = enumerator.Current;
								num2 = (short)211681286;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							case 4:
								error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_PeerIP_NoSame_AirInterfaceIP;
								num2 = (short)1187512325;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 5:
								goto IL_1AC;
							case 6:
							{
								string text;
								if (peerIP_A8524.Trim().Equals(text.Trim()))
								{
									num2 = (short)624951300;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							}
							IL_15C:
							num2 = (short)837681155;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_15A:
							goto IL_15C;
						}
						IL_1AC:
						IL_216:
						goto IL_69;
					}
					finally
					{
						global::System.Collections.Generic.List<string>.Enumerator enumerator;
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_229;
				case 7:
					if (global::SharedUtility.Utility.ValidateIPFormat(peerIP_A8524, out error))
					{
						num2 = (short)490405889;
						if (num2 != 0)
						{
						}
						num2 = (short)1809711104;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_69;
				}
				goto IL_30;
				IL_69:
				num2 = (short)586219523;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_229:
				num2 = (short)1622671367;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_28E:
				num2 = (short)1534328837;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_30:
			error = global::Motorola.Common.CustomException.CommonErrorCode.None;
			result = true;
			num2 = (short)551878657;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000080D0 File Offset: 0x000062D0
		public static bool ValidateDataWideBluetoothDUNSubscriberIP(string bluetoothDUNSubscriberIP, string bluetoothDUNPeerIP, string subscriberIP, string peerIP, global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? btPeerIPAssignmentType, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			bool result;
			short num2;
			for (;;)
			{
				IL_0A:
				bool flag;
				switch (num)
				{
				case 0:
					goto IL_47;
				case 1:
					flag = false;
					goto IL_191;
				case 2:
					return result;
				case 3:
					num2 = (short)160235521;
					if (num2 != 0)
					{
					}
					num2 = (short)1746796550;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)1322319877;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					flag = global::SharedUtility.SharedConstrains.ConDataWideBTDUNSUIPAddressesIsValid_External(bluetoothDUNSubscriberIP, bluetoothDUNPeerIP, btPeerIPAssignmentType, out error);
					goto IL_191;
				case 6:
				{
					if (global::SharedUtility.SharedConstrains.ConDataWideBTDUNSUIPAddressesIsValid_Internal(bluetoothDUNSubscriberIP, subscriberIP, peerIP, out error))
					{
						num2 = (short)838336516;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1015859360;
					short num3 = num2;
					num2 = (short)1709033632;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_47;
					case 1:
						break;
					default:
					{
						num2 = (short)1641283584;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)1941438464;
					if (num2 != 0)
					{
					}
					num2 = (short)1274019841;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_2C;
				IL_47:
				if (!string.IsNullOrEmpty(bluetoothDUNSubscriberIP))
				{
					num2 = (short)1147011075;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				break;
				IL_191:
				result = flag;
				num2 = (short)1220280322;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_2C:
			error = global::Motorola.Common.CustomException.CommonErrorCode.None;
			result = true;
			num2 = (short)1768554496;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000828C File Offset: 0x0000648C
		public static bool ConDataWideBTDUNSUIPAddressesIsValid_Internal(string selfIP_A41120, string SubIP1_A9222, string PeerIP1_A8524, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			switch (0)
			{
			case 0:
				goto IL_54;
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
				{
					num2 = (short)26542080;
					short num3 = num2;
					if (error == global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num2 = (short)1378811905;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_172;
				}
				case 1:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_BluetoothDUNSubIP_NoSame_PeerIP;
					num2 = (short)507904009;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					if (error == global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						return result;
					}
					num2 = (short)336890033;
					short num4 = num2;
					num2 = (short)1052215473;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)1825570816;
						if (num2 != 0)
						{
						}
						num2 = (short)456065036;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					if (selfIP_A41120.Trim().Equals(SubIP1_A9222.Trim()))
					{
						num2 = (short)590807048;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2B4;
				case 4:
					num2 = (short)1033371648;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)825163777;
					if (num2 != 0)
					{
					}
					num2 = (short)2004156429;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (global::SharedUtility.Utility.ValidateIPFormat(selfIP_A41120, out error))
					{
						num2 = (short)1017249799;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_172;
				case 7:
					num2 = (short)2026110991;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_BluetoothDUNSubIP_NoSame_SubIP;
					num2 = (short)510590990;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_172;
				case 10:
					return result;
				case 11:
					if (!string.IsNullOrEmpty(PeerIP1_A8524))
					{
						num2 = (short)2067660805;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_172;
				case 12:
					result = false;
					num2 = (short)1886584842;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					if (selfIP_A41120.Trim().Equals(PeerIP1_A8524.Trim()))
					{
						num2 = (short)2116616196;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_172;
				case 14:
					goto IL_2B4;
				case 15:
					if (!string.IsNullOrEmpty(SubIP1_A9222))
					{
						num2 = (short)1970536464;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2B4;
				case 16:
					num2 = (short)434176003;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_54;
				IL_172:
				num2 = (short)1331560450;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2B4:
				num2 = (short)1566375947;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_54:
			result = true;
			num2 = (short)2075197446;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000085AC File Offset: 0x000067AC
		public static bool ConDataWideBTDUNSUIPAddressesIsValid_External(string selfIP_A41120, string btDUNPeerIP_A41123, global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? btDunPeerType, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			switch (0)
			{
			case 0:
				goto IL_5C;
			}
			bool result;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					result = false;
					num2 = (short)741343237;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (error == global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num2 = (short)1103888399;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_192;
				case 2:
				{
					global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType;
					global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType bluetoothDunPeerIpAssignmentType2;
					if (bluetoothDunPeerIpAssignmentType.GetValueOrDefault() == bluetoothDunPeerIpAssignmentType2 & bluetoothDunPeerIpAssignmentType != null)
					{
						num2 = (short)2144206854;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_192;
				}
				case 3:
				{
					num2 = (short)764608512;
					short num3 = num2;
					num2 = (short)2115043342;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					num2 = (short)928514055;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_268;
				case 6:
					num2 = (short)1244659713;
					if (num2 != 0)
					{
					}
					goto IL_2FE;
				case 7:
					if (selfIP_A41120.Trim().Equals(btDUNPeerIP_A41123.Trim()))
					{
						num2 = (short)147652620;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E6;
				case 8:
					if (global::SharedUtility.Utility.ValidateIPFormat(selfIP_A41120, out error))
					{
						num2 = (short)1637220355;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_192;
				case 9:
					if (!string.IsNullOrEmpty(btDUNPeerIP_A41123))
					{
						num2 = (short)237109252;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E6;
				case 10:
					if (error != global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num2 = (short)2144206848;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 11:
					goto IL_192;
				case 12:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_BluetoothDUNSubIP_NoSame_BDUNPeerIP;
					num2 = (short)2051276816;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubnetMismatch;
					num2 = (short)1355808779;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					if (btDunPeerType != null)
					{
						num2 = (short)1063649297;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2FE;
				case 15:
					num2 = (short)1110442002;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					goto IL_E6;
				case 17:
				{
					global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType = btDunPeerType;
					global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType bluetoothDunPeerIpAssignmentType2 = global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType.DYNAMIC;
					num2 = (short)1832910850;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 18:
					if (!global::SharedUtility.SharedConstrains.IsSameSubnet(selfIP_A41120, btDUNPeerIP_A41123))
					{
						num2 = (short)485949453;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_192;
				}
				goto IL_5C;
				IL_E6:
				num2 = (short)69206017;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_192:
				num2 = (short)1255800842;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2FE:
				num2 = (short)641007625;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_268:
			num2 = (short)309105806;
			short num4 = num2;
			num2 = (short)171480206;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_5C:
				result = true;
				num2 = (short)254410760;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
				num2 = (short)2009464832;
				if (num2 != 0)
				{
				}
				break;
			}
			return result;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x0000891C File Offset: 0x00006B1C
		[global::SharedUtility.Attributes.ConstraintID("ValidateDataWideBluetoothDUNPeerIP")]
		public static bool ValidateDataWideBluetoothDUNPeerIP_00(global::SharedUtility.Arguments.IArgumentOfSharedConstraint args, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			short num = (short)1358046012;
			short num2 = num;
			num = (short)672539452;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1711341568;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1466236929;
			if (num != 0)
			{
			}
			num = (short)1760690176;
			if (num != 0)
			{
			}
			return global::SharedUtility.SharedConstrains.ValidateDataWideBluetoothDUNPeerIP_01(args, out error);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000089D0 File Offset: 0x00006BD0
		[global::SharedUtility.Attributes.ConstraintID("ValidateDataWideBluetoothDUNPeerIP")]
		[global::Motorola.CommonCPS.Server.EntityModel.ProductCPVersion(Product = (global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.APX | global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.PBB | global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP), Version = "-12.00.00")]
		public static bool ValidateDataWideBluetoothDUNPeerIP_01(global::SharedUtility.Arguments.IArgumentOfSharedConstraint args, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			short num = (short)2067267584;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_D0;
				}
				bool result;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						if (error == global::Motorola.Common.CustomException.CommonErrorCode.None)
						{
							num = (short)1075707915;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5D4;
					case 1:
						return result;
					case 2:
					{
						num = (short)904921088;
						short num3 = num;
						error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_BluetoothDUNSubIP_NoSame_BDUNPeerIP;
						num = (short)1363345446;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						if (!(args is global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint))
						{
							num = (short)1824391169;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string bluetoothDUNPeerIP = (args as global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint).BluetoothDUNPeerIP;
						string bluetoothDUNSubscriberIP = (args as global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint).BluetoothDUNSubscriberIP;
						string serialLinkSubscriberIP = (args as global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint).SerialLinkSubscriberIP;
						string serialLinkPeerIP = (args as global::SharedUtility.Arguments.Apx_ArgumentOfSharedConstraint).SerialLinkPeerIP;
						num = (short)1762066437;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_BluetoothDUNPeerIP_NoSame_SubIP;
						num = (short)1385299983;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						string bluetoothDUNPeerIP;
						if (!string.IsNullOrEmpty(bluetoothDUNPeerIP))
						{
							num = (short)542375971;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E4;
					}
					case 6:
						goto IL_2E4;
					case 7:
					{
						string serialLinkPeerIP;
						if (serialLinkPeerIP != null)
						{
							num = (short)274726934;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_52F;
					}
					case 8:
						if (error == global::Motorola.Common.CustomException.CommonErrorCode.None)
						{
							num = (short)706543625;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4F2;
					case 9:
						num = (short)401866781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						return result;
					case 11:
						num = (short)2078933023;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						string bluetoothDUNPeerIP;
						string serialLinkPeerIP;
						if (bluetoothDUNPeerIP.Trim().Equals(serialLinkPeerIP.Trim()))
						{
							num = (short)1935015949;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_52F;
					}
					case 13:
						error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_BluetoothDUNPeerIP_NoSame_PeerIP;
						num = (short)564592668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						num = (short)1652949024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_5D4;
					case 16:
						if (error == global::Motorola.Common.CustomException.CommonErrorCode.None)
						{
							num = (short)455475223;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_52F;
					case 17:
					{
						num = (short)663769926;
						short num4 = num;
						num = (short)15684422;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_511;
						default:
							num = (short)1924136960;
							if (num != 0)
							{
							}
							num = (short)1215889416;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 18:
						error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_BluetoothDUNSubIP_NoSame_BDUNPeerIP;
						num = (short)1234305050;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						result = false;
						num = (short)964427786;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (error == global::Motorola.Common.CustomException.CommonErrorCode.None)
						{
							goto IL_511;
						}
						goto IL_2E4;
					case 21:
						num = (short)2115436574;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						num = (short)1426980880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						num = (short)112001036;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
					{
						string bluetoothDUNPeerIP;
						if (global::SharedUtility.Utility.ValidateIPFormat(bluetoothDUNPeerIP, out error))
						{
							num = (short)1445265441;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E4;
					}
					case 25:
						if (error != global::Motorola.Common.CustomException.CommonErrorCode.None)
						{
							num = (short)461045779;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 26:
						goto IL_455;
					case 27:
					{
						string serialLinkSubscriberIP;
						if (serialLinkSubscriberIP != null)
						{
							num = (short)1604452389;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5D4;
					}
					case 28:
						goto IL_52F;
					case 29:
					{
						string bluetoothDUNPeerIP;
						string bluetoothDUNSubscriberIP;
						if (bluetoothDUNPeerIP.Trim().Equals(bluetoothDUNSubscriberIP.Trim()))
						{
							num = (short)2014707714;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4F2;
					}
					case 30:
					{
						string bluetoothDUNPeerIP;
						string bluetoothDUNSubscriberIP;
						if (bluetoothDUNPeerIP.Trim().Equals(bluetoothDUNSubscriberIP.Trim()))
						{
							num = (short)1141964818;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_455;
					}
					case 31:
					{
						string bluetoothDUNPeerIP;
						string serialLinkSubscriberIP;
						if (bluetoothDUNPeerIP.Trim().Equals(serialLinkSubscriberIP.Trim()))
						{
							num = (short)504168452;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5D4;
					}
					case 32:
					{
						string bluetoothDUNPeerIP;
						string bluetoothDUNSubscriberIP;
						if (!global::SharedUtility.SharedConstrains.IsSameSubnet(bluetoothDUNSubscriberIP, bluetoothDUNPeerIP))
						{
							num = (short)483196964;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2E4;
					}
					case 33:
						num = (short)682229799;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
					{
						string bluetoothDUNSubscriberIP;
						if (bluetoothDUNSubscriberIP != null)
						{
							num = (short)1247084561;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4F2;
					}
					case 35:
						num = (short)1248133144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubnetMismatch;
						num = (short)84803590;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						num = (short)179961857;
						if (num != 0)
						{
						}
						num = (short)1745354752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						goto IL_4F2;
					case 39:
					{
						string bluetoothDUNSubscriberIP;
						if (!string.IsNullOrEmpty(bluetoothDUNSubscriberIP))
						{
							num = (short)716374037;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_455;
					}
					}
					goto IL_D0;
					IL_2E4:
					num = (short)699662361;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_455:
					num = (short)1307967515;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4F2:
					num = (short)37158932;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_511:
					num = (short)1956249614;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_52F:
					num = (short)1977745442;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5D4:
					num = (short)1535508487;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_D0:
				error = global::Motorola.Common.CustomException.CommonErrorCode.None;
				result = true;
				num = (short)865927171;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000090AC File Offset: 0x000072AC
		[global::Motorola.CommonCPS.Server.EntityModel.ProductCPVersion(Product = (global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.APX | global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.PBB | global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP), Version = "12.00.00-")]
		[global::SharedUtility.Attributes.ConstraintID("ValidateDataWideBluetoothDUNPeerIP")]
		public static bool ValidateDataWideBluetoothDUNPeerIP_02(global::SharedUtility.Arguments.IArgumentOfSharedConstraint args, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			short num = (short)964013052;
			short num2 = num;
			num = (short)1295297532;
			switch (num2 == num)
			{
			}
			num = (short)1841430528;
			if (num != 0)
			{
			}
			num = (short)315228160;
			short num3 = num;
			num = (short)780664833;
			if (num != 0)
			{
			}
			return global::SharedUtility.SharedConstrains.ValidateDataWideBluetoothDUNPeerIP_01(args, out error);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00009160 File Offset: 0x00007360
		public static bool ValidateUserName(string userName, int? userNameDisplayTextSize, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
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
					num2 = (short)2141061121;
					if (num2 != 0)
					{
					}
					num2 = (short)1993670659;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return result;
				case 2:
				{
					num2 = (short)1062960061;
					short num3 = num2;
					num2 = (short)289831869;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
					{
						num2 = (short)1353252864;
						if (num2 != 0)
						{
						}
						num2 = (short)734330880;
						short num4 = num2;
						num2 = (short)1530920965;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 3:
					if (userNameDisplayTextSize != null)
					{
						num2 = (short)680525826;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1BA;
				case 4:
					return result;
				case 5:
				{
					int length = userName.TrimEnd(global::System.Array.Empty<char>()).Length;
					int? num5 = userNameDisplayTextSize;
					if (length > num5.GetValueOrDefault() & num5 != null)
					{
						num2 = (short)632750086;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1BA;
				}
				case 6:
					result = false;
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_UserName_OverChars;
					num2 = (short)617807873;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (userName != null)
					{
						num2 = (short)1911291904;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_30;
				IL_1BA:
				result = global::SharedUtility.SharedConstrains.SharedCon_ValidateUserNameCharacters(userName, out error);
				num2 = (short)161218564;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_30:
			error = global::Motorola.Common.CustomException.CommonErrorCode.None;
			result = true;
			num2 = (short)1051066375;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000934C File Offset: 0x0000754C
		public static bool SharedCon_ValidateUserNameCharacters(string userName, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::System.Text.RegularExpressions.Regex userNameRegex;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)631743854;
					short num3 = num2;
					num2 = (short)1343726958;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4E;
					default:
					{
						num2 = (short)904790016;
						if (num2 != 0)
						{
						}
						num2 = (short)1611071488;
						short num4 = num2;
						if (!userNameRegex.IsMatch(userName, 0))
						{
							num2 = (short)430833665;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					}
					break;
				}
				case 1:
					result = false;
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_UserName_InvalidChars;
					num2 = (short)1719599107;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)1478295553;
					if (num2 != 0)
					{
					}
					num2 = (short)663420928;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return result;
				case 4:
					if (!string.IsNullOrEmpty(userName))
					{
						goto IL_4E;
					}
					return result;
				}
				goto IL_24;
				IL_4E:
				num2 = (short)1773469698;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = true;
			error = global::Motorola.Common.CustomException.CommonErrorCode.None;
			userNameRegex = global::SharedUtility.SharedUtilityConstant.UserNameRegex;
			num2 = (short)743702532;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000094C0 File Offset: 0x000076C0
		public static bool ValidateUserPIN(string userPIN, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			bool result;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					result = true;
					num2 = (short)87031817;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_21F;
				case 2:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_UserPin_OverChars;
					result = false;
					num2 = (short)378077190;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)1598750721;
					if (num2 != 0)
					{
					}
					global::System.Text.RegularExpressions.Regex userPinRegex;
					if (userPinRegex.IsMatch(userPIN, 0))
					{
						num2 = (short)2078998529;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_UserPin_FormatError;
					result = false;
					num2 = (short)73269252;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					return result;
				case 5:
					if (string.IsNullOrEmpty(userPIN))
					{
						num2 = (short)678428672;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1152843783;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					return result;
				case 7:
					if (userPIN.Length > 20)
					{
						num2 = (short)2098790402;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)998703107;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					return result;
				case 9:
					return result;
				}
				goto IL_38;
			}
			return result;
			IL_38:
			num2 = (short)550368055;
			short num3 = num2;
			num2 = (short)1167389495;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_21F:
				num2 = (short)652148736;
				short num4 = num2;
				result = true;
				num2 = (short)2102788104;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1575878656;
				if (num2 != 0)
				{
				}
				global::System.Text.RegularExpressions.Regex userPinRegex = global::SharedUtility.SharedUtilityConstant.UserPinRegex;
				error = global::Motorola.Common.CustomException.CommonErrorCode.None;
				result = true;
				num2 = (short)1389297669;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000096F4 File Offset: 0x000078F4
		public static bool ValidateUserLoginUnitID(string userLoginUnitID, int? userLoginUnitIDTextSize, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			switch (0)
			{
			case 0:
				goto IL_44;
			}
			int num;
			bool result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_UserLoginUnitID_Exceed_User_Login_UnitID_Text_Size;
					num2 = (short)1578696707;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (error != global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						goto IL_243;
					}
					return result;
				case 3:
					goto IL_C9;
				case 4:
					goto IL_227;
				case 5:
				{
					num2 = (short)495255552;
					short num3 = num2;
					num2 = (short)337575948;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					result = false;
					num2 = (short)226623488;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num2 = (short)347799562;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (userLoginUnitID != null)
					{
						num2 = (short)806551559;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_C9;
				case 9:
					global::SharedUtility.SharedConstrains.SharedCon_ValidateUserLoginUnitIDCharacters(userLoginUnitID, out error);
					num2 = (short)619053060;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (userLoginUnitIDTextSize != null)
					{
						num2 = (short)162136069;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_C9;
				case 11:
					if (error == global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num2 = (short)1541144585;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_227;
				case 12:
				{
					int length = userLoginUnitID.Length;
					int? num4 = userLoginUnitIDTextSize;
					if (length > num4.GetValueOrDefault() & num4 != null)
					{
						num2 = (short)145293313;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_C9;
				}
				}
				goto IL_44;
				IL_C9:
				num2 = (short)1319457202;
				short num5 = num2;
				num2 = (short)219763122;
				switch ((num5 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_243:
					num2 = (short)1376649222;
					num = (int)((global::System.IntPtr)num2);
					continue;
				default:
					num2 = (short)1292238848;
					if (num2 != 0)
					{
					}
					num2 = (short)2074738699;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				IL_227:
				num2 = (short)2122448898;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_44:
			num2 = (short)727646209;
			if (num2 != 0)
			{
			}
			error = global::Motorola.Common.CustomException.CommonErrorCode.None;
			result = true;
			num2 = (short)1165885448;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00009984 File Offset: 0x00007B84
		public static bool SharedCon_ValidateUserLoginUnitIDCharacters(string userLoginUnitID, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			switch (0)
			{
			case 0:
				goto IL_50;
			}
			int num;
			short num2;
			bool result;
			global::System.Text.RegularExpressions.Regex userLoginUnitIDRegex;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)754581511;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_299;
				case 2:
					num2 = (short)501219329;
					if (num2 != 0)
					{
					}
					goto IL_19B;
				case 3:
					result = false;
					num2 = (short)764805129;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_19B;
				case 5:
					if (error == global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num2 = (short)574554112;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_19B;
				case 6:
					if (userLoginUnitID.Length != 0)
					{
						num2 = (short)990380045;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_299;
				case 7:
					if (userLoginUnitIDRegex.IsMatch(userLoginUnitID, 0))
					{
						num2 = (short)768606222;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_UserLoginUnitID_FormatError;
					num2 = (short)1375928322;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (error != global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num2 = (short)410845187;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 9:
					return result;
				case 10:
					num2 = (short)1194655750;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (!string.IsNullOrEmpty(userLoginUnitID))
					{
						num2 = (short)1408958474;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_19B;
				case 12:
					if (userLoginUnitID.TrimEnd(global::System.Array.Empty<char>()).Length == 0)
					{
						num2 = (short)722796559;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_299;
				case 13:
					num2 = (short)233897996;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
				{
					result = true;
					num2 = (short)547731151;
					short num3 = num2;
					num2 = (short)600225487;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)1289617408;
						if (num2 != 0)
						{
						}
						num2 = (short)546766852;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 15:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_UserLoginUnitID_CannotAllWhiteSpace;
					num2 = (short)565182465;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_50;
				IL_19B:
				num2 = (short)112590856;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_299:
				num2 = (short)1598488581;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_50:
			num2 = (short)892403712;
			short num4 = num2;
			result = true;
			error = global::Motorola.Common.CustomException.CommonErrorCode.None;
			userLoginUnitIDRegex = global::SharedUtility.SharedUtilityConstant.UserLoginUnitIDRegex;
			num2 = (short)2104360971;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00009C88 File Offset: 0x00007E88
		public static bool ValidateDeviceBluetoothFriendlyName(string bluetoothFriendlyName, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (bluetoothFriendlyName.Length > 14)
					{
						num2 = (short)1170472961;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_114;
				case 1:
				{
					num2 = (short)1876020757;
					short num3 = num2;
					num2 = (short)1041485333;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_80;
					default:
						goto IL_B7;
					}
					break;
				}
				case 2:
					num2 = (short)1949827073;
					if (num2 != 0)
					{
					}
					if (!string.IsNullOrEmpty(bluetoothFriendlyName))
					{
						num2 = (short)1903427587;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_114;
				case 3:
					goto IL_80;
				}
				goto IL_20;
				IL_80:
				num2 = (short)1158610944;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_B7:
			num2 = (short)1507459072;
			if (num2 != 0)
			{
			}
			error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_BluetoothName_Over14Chars;
			return false;
			IL_114:
			num2 = (short)1144061952;
			short num4 = num2;
			return true;
			IL_20:
			error = global::Motorola.Common.CustomException.CommonErrorCode.None;
			num2 = (short)1728249858;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00009DD4 File Offset: 0x00007FD4
		public static bool ValidateDataProfilePeerIP(string peerIP, string dataWidePeerIP, string dataProfileType, string subscriberIP, string dataWideSubscriberIP, string airInterfaceIP, string bluetoothDunSubscriberIP, string bluetoothDUNPeerIP, bool? bluetoothEnable, global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? assignmentType, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			short num = (short)884932608;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				bool result;
				for (;;)
				{
					IL_1D:
					switch (0)
					{
					case 0:
						goto IL_93;
					}
					for (;;)
					{
						IL_27:
						num = (short)1726742528;
						short num3 = num;
						switch (num2)
						{
						case 0:
							return result;
						case 1:
						{
							global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType;
							global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType bluetoothDunPeerIpAssignmentType2;
							if (bluetoothDunPeerIpAssignmentType.GetValueOrDefault() == bluetoothDunPeerIpAssignmentType2 & bluetoothDunPeerIpAssignmentType != null)
							{
								num = (short)1245052934;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_202;
						}
						case 2:
							goto IL_202;
						case 3:
							result = false;
							num = (short)2088763392;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (error != global::Motorola.Common.CustomException.CommonErrorCode.None)
							{
								num = (short)1880489987;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 5:
						{
							bool? flag;
							bool flag2;
							if (flag.GetValueOrDefault() == flag2 & flag != null)
							{
								num = (short)1367277580;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_202;
						}
						case 6:
							num = (short)1271595021;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_202;
						case 8:
							error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileBluetoothDUNPeerIP_NoSame_ProfilePeerIP;
							num = (short)1768226818;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
						{
							bool? flag = bluetoothEnable;
							bool flag2 = true;
							num = (short)1309343749;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							if (global::SharedUtility.SharedConstrains.SharedCon_ValidateDataProfilePeerIP(peerIP, dataWidePeerIP, dataProfileType, subscriberIP, dataWideSubscriberIP, airInterfaceIP, out error))
							{
								num = (short)1189478409;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_202;
						case 11:
						{
							if (peerIP.Trim().Equals(bluetoothDunSubscriberIP))
							{
								num = (short)392232974;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType = assignmentType;
							global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType bluetoothDunPeerIpAssignmentType2 = global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType.DYNAMIC;
							num = (short)259588097;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
							num = (short)1561985035;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							if (peerIP.Trim().Equals(bluetoothDUNPeerIP))
							{
								num = (short)1519058952;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_202;
						case 14:
							error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileBluetoothDUNSubIP_NoSame_ProfilePeerIP;
							num = (short)863895559;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
						IL_202:
						num = (short)2105442732;
						short num4 = num;
						num = (short)1413710252;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1D;
						default:
							num = (short)2041970689;
							if (num != 0)
							{
							}
							num = (short)2132672512;
							if (num != 0)
							{
							}
							num = (short)1097138180;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_93:
					error = global::Motorola.Common.CustomException.CommonErrorCode.None;
					result = true;
					num = (short)1286275082;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				return result;
			}
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000A110 File Offset: 0x00008310
		public static bool SharedCon_ValidateDataProfilePeerIP(string peerIP, string dataWidePeerIP, string dataProfType, string subscriberIP, string dataWideSubscriberIP, string airInterfaceIP, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			int a_ = 15;
			switch (0)
			{
			case 0:
				goto IL_75;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (peerIP.Trim().Equals(dataWideSubscriberIP))
					{
						num2 = (short)1984233486;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1486815239;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfilePeerIP_NoSame_AirInterfaceIP;
					num2 = (short)1143668744;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (!(dataProfType == global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.b("쎉좋톍쒏삑솓\ud895펗펙튛\ud99d", a_)))
					{
						num2 = (short)931659797;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_23D;
				case 3:
					if (!string.IsNullOrEmpty(dataWidePeerIP))
					{
						num2 = (short)1273692175;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1E3;
				case 4:
					goto IL_1E3;
				case 5:
					if (dataProfType == global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.b("쎉좋톍쒏삑솓\ud895펗펙튛\ud99d", a_))
					{
						goto IL_334;
					}
					goto IL_1E3;
				case 6:
					num2 = (short)206438416;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (peerIP.Trim().Equals(airInterfaceIP.Trim()))
					{
						num2 = (short)1693319169;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1516896258;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					goto IL_1E3;
				case 9:
					num2 = (short)1196818433;
					if (num2 != 0)
					{
					}
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileSubIP_NoSame_ProfilePeerIP;
					num2 = (short)1125646349;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					return result;
				case 11:
					goto IL_23D;
				case 12:
					if (!peerIP.Trim().Equals(dataWidePeerIP.Trim()))
					{
						num2 = (short)1628045329;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1E3;
				case 13:
					goto IL_1E3;
				case 14:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubIP_NoSame_ProfilePeerIP;
					num2 = (short)1420427268;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					num2 = (short)198049804;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
				{
					num2 = (short)2040725504;
					short num3 = num2;
					if (peerIP.Trim().Equals(subscriberIP.Trim()))
					{
						num2 = (short)1989607433;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)159186944;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 17:
				{
					num2 = (short)66236717;
					short num4 = num2;
					num2 = (short)1652142381;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_334;
					default:
						num2 = (short)449249280;
						if (num2 != 0)
						{
						}
						error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfilePeerIP_Same_DataWidePeerIP;
						num2 = (short)1768620052;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 18:
					if (global::SharedUtility.Utility.ValidateIPFormat(peerIP, out error))
					{
						num2 = (short)277872646;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1E3;
				case 19:
					if (error != global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num2 = (short)328990742;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 20:
					goto IL_1E3;
				case 21:
					num2 = (short)1665597445;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					result = false;
					num2 = (short)1746599946;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_75;
				IL_1E3:
				num2 = (short)1466171411;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_23D:
				num2 = (short)1686962179;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_334:
				num2 = (short)1766981643;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_75:
			result = true;
			error = global::Motorola.Common.CustomException.CommonErrorCode.None;
			num2 = (short)647692306;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000A558 File Offset: 0x00008758
		public static bool ValidateDataProfileSubscriberIP(string subscriberIP, string dataWideSubscriberIP, string dataProfileType, string peerIP, bool? bluetoothEnable, string bluetoothDunSubscriberIP, string bluetoothDUNPeerIP, string airInterfaceIP, string autoRegServerIP, global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? assignmentType, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			short num = (short)1196228608;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				bool result;
				for (;;)
				{
					IL_1E:
					switch (0)
					{
					case 0:
						goto IL_94;
					}
					for (;;)
					{
						IL_28:
						num = (short)592510976;
						short num3 = num;
						switch (num2)
						{
						case 0:
							return result;
						case 1:
						{
							global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType;
							global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType bluetoothDunPeerIpAssignmentType2;
							if (bluetoothDunPeerIpAssignmentType.GetValueOrDefault() == bluetoothDunPeerIpAssignmentType2 & bluetoothDunPeerIpAssignmentType != null)
							{
								num = (short)1875836934;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_22B;
						}
						case 2:
							goto IL_22B;
						case 3:
							result = false;
							num = (short)1523777536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							if (error != global::Motorola.Common.CustomException.CommonErrorCode.None)
							{
								num = (short)971702275;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 5:
						{
							bool? flag;
							bool flag2;
							if (flag.GetValueOrDefault() == flag2 & flag != null)
							{
								num = (short)2077032460;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_22B;
						}
						case 6:
							num = (short)313458701;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_22B;
						case 8:
							error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileBluetoothDUNPeerIP_NoSame_ProfileSubIP;
							num = (short)636157954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
						{
							bool? flag = bluetoothEnable;
							bool flag2 = true;
							num = (short)1204486145;
							if (num != 0)
							{
							}
							num = (short)1017839621;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							if (global::SharedUtility.SharedConstrains.SharedCon_ValidateDataProfileSubscriberIP(subscriberIP, dataWideSubscriberIP, dataProfileType, peerIP, autoRegServerIP, airInterfaceIP, out error))
							{
								num = (short)1697906697;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_22B;
						case 11:
						{
							if (subscriberIP.Trim().Equals(bluetoothDunSubscriberIP))
							{
								num = (short)1992753166;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType = assignmentType;
							global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType bluetoothDunPeerIpAssignmentType2 = global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType.DYNAMIC;
							num = (short)846135297;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
							num = (short)639303691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							if (subscriberIP.Trim().Equals(bluetoothDUNPeerIP))
							{
								num = (short)2062549000;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_22B;
						case 14:
							error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_BluetoothDUNSubIP_NoSame_SubIP;
							num = (short)680853511;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
						IL_22B:
						num = (short)1584086780;
						short num4 = num;
						num = (short)33636092;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1E;
						default:
							num = (short)1021181952;
							if (num != 0)
							{
							}
							num = (short)62521348;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_94:
					result = true;
					error = global::Motorola.Common.CustomException.CommonErrorCode.None;
					num = (short)2134114314;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				return result;
			}
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000A894 File Offset: 0x00008A94
		public static bool SharedCon_ValidateDataProfileSubscriberIP(string subscriberIP, string dataWideSubscriberIP, string dataProfType, string peerIP, string autoRegServerIP, string airInterfaceIP, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			int a_ = 4;
			switch (0)
			{
			case 0:
				goto IL_75;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (subscriberIP.Trim().Equals(autoRegServerIP))
					{
						num2 = (short)591527950;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)929300487;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileSubIP_NoSame_AirInterfaceIP;
					num2 = (short)1140326408;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (!(dataProfType == global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.b("㙾얀\udc82톄햆\udc88얊욌욎\udf90풒", a_)))
					{
						num2 = (short)1507917845;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_290;
				case 3:
					if (!string.IsNullOrEmpty(dataWideSubscriberIP))
					{
						num2 = (short)143458319;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_209;
				case 4:
					goto IL_209;
				case 5:
					if (dataProfType == global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.b("㙾얀\udc82톄햆\udc88얊욌욎\udf90풒힔얖횘\uda9a\ud99c\udd9e", a_))
					{
						goto IL_38C;
					}
					goto IL_209;
				case 6:
					num2 = (short)411828240;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (subscriberIP.Trim().Equals(airInterfaceIP))
					{
						num2 = (short)876347393;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1782579202;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					goto IL_209;
				case 9:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileSubIP_NoSame_ProfilePeerIP;
					num2 = (short)1739390989;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					return result;
				case 11:
					goto IL_290;
				case 12:
					num2 = (short)620232705;
					if (num2 != 0)
					{
					}
					if (!subscriberIP.Trim().Equals(dataWideSubscriberIP.Trim()))
					{
						num2 = (short)1684865041;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_209;
				case 13:
					goto IL_209;
				case 14:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileSubIP_NoSame_AutomaticRegistrationServerAddressIP;
					num2 = (short)1991966724;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					num2 = (short)1222049804;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					if (subscriberIP.Trim().Equals(peerIP.Trim()))
					{
						num2 = (short)709165065;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)194904064;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
				{
					num2 = (short)38520145;
					short num3 = num2;
					num2 = (short)1464124753;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_38C;
					default:
						num2 = (short)635437056;
						if (num2 != 0)
						{
						}
						error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileSubscriberIP_Same_DataWideSubscriberIP;
						num2 = (short)187432980;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 18:
					if (global::SharedUtility.Utility.ValidateIPFormat(subscriberIP, out error))
					{
						num2 = (short)565379078;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_209;
				case 19:
					if (error != global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num2 = (short)774701078;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 20:
					goto IL_209;
				case 21:
					num2 = (short)2144927749;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
				{
					num2 = (short)707395584;
					short num4 = num2;
					result = false;
					num2 = (short)1261961226;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_75;
				IL_209:
				num2 = (short)2069495827;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_290:
				num2 = (short)1980628995;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_38C:
				num2 = (short)559349771;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_75:
			result = true;
			error = global::Motorola.Common.CustomException.CommonErrorCode.None;
			num2 = (short)1501495314;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000ACDC File Offset: 0x00008EDC
		public static bool ValidateDataProfileBluetoothDUNPeerIP(string bluetoothDUNPeerIP, string dataWideBluetoothDunPeerIP, string dataProfType, string subscriberIP, string peerIP, string bluetoothDunSubscriberIP, string airInterfaceIP, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			int a_ = 7;
			switch (0)
			{
			case 0:
				goto IL_95;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (dataProfType == global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.b("쮁삃\ud985\udc87\ud889\ud98b삍\udb8f\udb91\uda93톕\uda97좙펛\udf9d", a_))
					{
						num2 = (short)167116803;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_272;
				case 1:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubAirInterfaceIP_NoSame_ProfileBlueToothDUNPeerIP;
					num2 = (short)1432485904;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return result;
				case 3:
					goto IL_4E6;
				case 4:
					if (!(dataProfType == global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.b("쮁삃\ud985\udc87\ud889\ud98b삍\udb8f\udb91\uda93톕", a_)))
					{
						num2 = (short)201588743;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4E6;
				case 5:
					if (bluetoothDUNPeerIP.Trim().Equals(subscriberIP.Trim()))
					{
						num2 = (short)682491926;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)67436565;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileBluetoothDUNPeerIP_Same_DataWideBluetoothDUNPeerIP;
					num2 = (short)536412188;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num2 = (short)522518528;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (global::SharedUtility.Utility.ValidateIPFormat(bluetoothDUNPeerIP, out error))
					{
						num2 = (short)500695055;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_272;
				case 9:
					if (bluetoothDUNPeerIP.Trim().Equals(airInterfaceIP.Trim()))
					{
						num2 = (short)1058865153;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3C5;
				case 10:
					goto IL_1DA;
				case 11:
					goto IL_2D7;
				case 12:
					if (error == global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num2 = (short)324861971;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1DA;
				case 13:
				{
					num2 = (short)416612352;
					short num3 = num2;
					if (error != global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num2 = (short)411959313;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 14:
					goto IL_3C5;
				case 15:
					num2 = (short)728170501;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					goto IL_3C5;
				case 17:
					result = false;
					num2 = (short)1548681218;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					num2 = (short)104005659;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					goto IL_12B;
				case 20:
					if (!global::SharedUtility.SharedConstrains.IsSameSubnet(bluetoothDunSubscriberIP, bluetoothDUNPeerIP))
					{
						num2 = (short)1244397592;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1DA;
				case 21:
					if (bluetoothDUNPeerIP.Trim().Equals(peerIP.Trim()))
					{
						num2 = (short)650313751;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)752353289;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileBluetoothDUNPeerIP_NoSame_ProfileSubIP;
					num2 = (short)1311571998;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 23:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileBluetoothDUNPeerIP_NoSame_ProfilePeerIP;
					num2 = (short)269025294;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubnetMismatch;
					num2 = (short)286130177;
					if (num2 != 0)
					{
					}
					num2 = (short)48496650;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
					if (!string.IsNullOrEmpty(dataWideBluetoothDunPeerIP))
					{
						num2 = (short)369360914;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_272;
				case 26:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileBluetoothDUNSubIP_NoSame_ProfileBDUNPeerIP;
					num2 = (short)1559363595;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 27:
					if (!bluetoothDUNPeerIP.Trim().Equals(dataWideBluetoothDunPeerIP.Trim()))
					{
						num2 = (short)1639251974;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_272;
				case 28:
					goto IL_272;
				case 29:
					if (bluetoothDUNPeerIP.Trim().Equals(bluetoothDunSubscriberIP))
					{
						num2 = (short)856358938;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2D7;
				case 30:
					goto IL_3C5;
				}
				goto IL_95;
				IL_12B:
				num2 = (short)724893716;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1DA:
				num2 = (short)848728248;
				short num4 = num2;
				num2 = (short)1953009848;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_12B;
				default:
					num2 = (short)1709441024;
					if (num2 != 0)
					{
					}
					num2 = (short)560922628;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				IL_272:
				num2 = (short)1748041741;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2D7:
				num2 = (short)3014668;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_3C5:
				num2 = (short)1208221725;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_4E6:
				num2 = (short)1274085401;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_95:
			result = true;
			error = global::Motorola.Common.CustomException.CommonErrorCode.None;
			num2 = (short)64028680;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000B25C File Offset: 0x0000945C
		public static bool ValidateDataProfileBluetoothDUNSubscriberIP(string bluetoothDunSubscriberIp, string dataWideBluetoothDunSubscriberIP, string dataProfType, string subscriberIP, string peerIP, string bluetoothDUNPeerIP, string airInterfaceIP, string autoRegServerIP, global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? assignmentType, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			int a_ = 8;
			switch (0)
			{
			case 0:
				goto IL_9D;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubAirInterfaceIP_NoSame_ProfileBlueToothDUNSubIP;
					num2 = (short)359596056;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (!(dataProfType == global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.b("쪂솄\ud886\udd88\ud98a\ud88c솎\uda90\uda92\udb94킖", a_)))
					{
						num2 = (short)986316807;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_511;
				case 2:
					return result;
				case 3:
					goto IL_22C;
				case 4:
					goto IL_511;
				case 5:
				{
					num2 = (short)801131381;
					short num3 = num2;
					num2 = (short)240274293;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_113;
					default:
						num2 = (short)1777729536;
						if (num2 != 0)
						{
						}
						error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileBluetoothDUNSubIP_NoSame_ProfileSubIP;
						num2 = (short)384237591;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 6:
					if (dataProfType == global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.b("쪂솄\ud886\udd88\ud98a\ud88c솎\uda90\uda92\udb94킖\udb98즚튜\ude9e", a_))
					{
						goto IL_113;
					}
					goto IL_279;
				case 7:
					num2 = (short)1972764678;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileBluetoothDUNSubIP_NoSame_ProfileBDUNPeerIP;
					num2 = (short)1599406105;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileBluetoothDUNSubIP_NoSame_ProfilePeerIP;
					num2 = (short)1003946010;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (global::SharedUtility.Utility.ValidateIPFormat(bluetoothDunSubscriberIp, out error))
					{
						num2 = (short)129564689;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_279;
				case 11:
				{
					if (bluetoothDunSubscriberIp.Trim().Equals(airInterfaceIP.Trim()))
					{
						num2 = (short)1560674304;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType = assignmentType;
					global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType bluetoothDunPeerIpAssignmentType2 = global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType.DYNAMIC;
					num2 = (short)1058537503;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 12:
					if (bluetoothDunSubscriberIp.Trim().Equals(peerIP.Trim()))
					{
						num2 = (short)1854406665;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)24641547;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
				{
					num2 = (short)587137024;
					short num4 = num2;
					result = false;
					num2 = (short)1856045058;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 14:
					if (error == global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num2 = (short)499187733;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_22C;
				case 15:
					if (!string.IsNullOrEmpty(dataWideBluetoothDunSubscriberIP))
					{
						num2 = (short)1571291163;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_279;
				case 16:
					if (bluetoothDunSubscriberIp.Trim().Equals(bluetoothDUNPeerIP.Trim()))
					{
						num2 = (short)1579876360;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2DE;
				case 17:
					num2 = (short)743702546;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					if (bluetoothDunSubscriberIp.Trim().Equals(subscriberIP))
					{
						num2 = (short)1655504901;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1545666572;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					if (error != global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num2 = (short)925040653;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 20:
					if (!global::SharedUtility.SharedConstrains.IsSameSubnet(bluetoothDunSubscriberIp, bluetoothDUNPeerIP))
					{
						num2 = (short)352452630;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_22C;
				case 21:
					num2 = (short)59768852;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubnetMismatch;
					num2 = (short)1933574147;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 23:
					goto IL_22C;
				case 24:
					goto IL_22C;
				case 25:
					num2 = (short)907149313;
					if (num2 != 0)
					{
					}
					goto IL_2DE;
				case 26:
					goto IL_22C;
				case 27:
					num2 = (short)1941962782;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 28:
					num2 = (short)1485570064;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 29:
					goto IL_279;
				case 30:
					if (!bluetoothDunSubscriberIp.Trim().Equals(dataWideBluetoothDunSubscriberIP.Trim()))
					{
						num2 = (short)293666848;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_279;
				case 31:
				{
					global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType;
					global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType bluetoothDunPeerIpAssignmentType2;
					if (bluetoothDunPeerIpAssignmentType.GetValueOrDefault() == bluetoothDunPeerIpAssignmentType2 & bluetoothDunPeerIpAssignmentType != null)
					{
						num2 = (short)851509276;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_22C;
				}
				case 32:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileBluetoothDUNSubIP_Same_DataWideBluetoothDUNSubIP;
					num2 = (short)137101341;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_9D;
				IL_113:
				num2 = (short)1906900996;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_22C:
				num2 = (short)559808513;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_279:
				num2 = (short)45744147;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2DE:
				num2 = (short)722337806;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_511:
				num2 = (short)1401290767;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_9D:
			result = true;
			error = global::Motorola.Common.CustomException.CommonErrorCode.None;
			num2 = (short)1454899210;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000B828 File Offset: 0x00009A28
		public static bool IsSameSubnet(string IPAddress1, string IPAddress2)
		{
			short num = (short)431489024;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_BA;
				}
				bool result;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						global::System.Net.IPAddress ipaddress;
						if (ipaddress != null)
						{
							num = (short)1239220229;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29C;
					}
					case 1:
						num = (short)1758855186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_300;
					case 3:
						goto IL_3A4;
					case 4:
					{
						byte[] addressBytes;
						byte[] addressBytes2;
						if (addressBytes[0] == addressBytes2[0])
						{
							num = (short)826015771;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 5:
						num = (short)1069482018;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_159;
					case 7:
					{
						byte[] addressBytes;
						byte[] addressBytes2;
						if (addressBytes[1] == addressBytes2[1])
						{
							num = (short)2126970901;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 8:
					{
						byte[] addressBytes;
						byte[] addressBytes2;
						if (addressBytes[0] == addressBytes2[0])
						{
							num = (short)797376513;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 9:
					{
						byte b;
						if (b <= 223)
						{
							num = (short)1474166795;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 10:
					{
						byte b;
						if (b >= 192)
						{
							num = (short)735051805;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 11:
						num = (short)355532808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (!string.IsNullOrEmpty(IPAddress1))
						{
							num = (short)1658978323;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D1;
					case 13:
						return result;
					case 14:
					{
						global::System.Net.IPAddress ipaddress;
						byte[] addressBytes = ipaddress.GetAddressBytes();
						global::System.Net.IPAddress ipaddress2;
						byte[] addressBytes2 = ipaddress2.GetAddressBytes();
						byte b = addressBytes[0];
						num = (short)555024408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
					{
						byte[] addressBytes;
						byte[] addressBytes2;
						if (addressBytes[0] == addressBytes2[0])
						{
							num = (short)570753047;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 16:
					{
						global::System.Net.IPAddress ipaddress = global::SharedUtility.Utility.a(IPAddress1);
						global::System.Net.IPAddress ipaddress2 = global::SharedUtility.Utility.a(IPAddress2);
						num = (short)408027136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						num = (short)1872887834;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						byte[] addressBytes;
						byte[] addressBytes2;
						if (addressBytes[1] == addressBytes2[1])
						{
							num = (short)744751126;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 19:
						num = (short)722731041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
					{
						byte[] addressBytes;
						byte[] addressBytes2;
						if (addressBytes[2] == addressBytes2[2])
						{
							num = (short)1378418720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 21:
						result = true;
						num = (short)559153158;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						num = (short)1932001300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						result = true;
						num = (short)1468399646;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
					{
						byte b;
						if (b <= 127)
						{
							num = (short)310837276;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)627703839;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						num = (short)1914241028;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
					{
						byte b;
						if (b <= 191)
						{
							num = (short)559153177;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_559;
					}
					case 27:
						num = (short)2024341511;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						num = (short)1614348289;
						if (num != 0)
						{
						}
						num = (short)1527250959;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						num = (short)1733754889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						return result;
					case 31:
					{
						byte b;
						if (b >= 128)
						{
							num = (short)291045393;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_559;
					}
					case 32:
						result = true;
						num = (short)1359413251;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						if (!string.IsNullOrEmpty(IPAddress2))
						{
							num = (short)1142358032;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D1;
					case 34:
					{
						global::System.Net.IPAddress ipaddress2;
						if (ipaddress2 != null)
						{
							num = (short)1462370318;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29C;
					}
					}
					goto IL_BA;
					IL_29C:
					result = true;
					num = (short)740663037;
					short num3 = num;
					num = (short)1814798077;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_300;
					default:
						num = (short)1241841664;
						if (num != 0)
						{
						}
						num = (short)1444216834;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_3D1:
					result = true;
					num = (short)967704589;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_559:
					num = (short)1084096522;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_159:
				IL_300:
				return result;
				IL_3A4:
				num = (short)97189888;
				short num4 = num;
				return result;
				IL_BA:
				result = false;
				num = (short)1423769612;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x0000BE10 File Offset: 0x0000A010
		public static bool ValidateDataProfileAirInterfaceIP(string airInterfaceIP, string bluetoothDUNPeerIP, string bluetoothDunSubscriberIP, string subscriberIP, string peerIP, string autoRegServerIP, string dataWidePeerIP, string dataWideSubscriberIP, global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemARSMode? arsMode, bool? bluetoothEnable, global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? assignmentType, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			short num = (short)1995571200;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8C;
				}
				bool result;
				for (;;)
				{
					IL_28:
					num = (short)590479360;
					short num3 = num;
					bool bluetoothEnable2;
					global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemARSMode arsMode2;
					bool? flag;
					bool flag2;
					switch (num2)
					{
					case 0:
						return result;
					case 1:
						return result;
					case 2:
						if (global::SharedUtility.Utility.ValidateIPFormat(airInterfaceIP, out error))
						{
							num = (short)1893728262;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = false;
						num = (short)1430061057;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						bluetoothEnable2 = false;
						goto IL_158;
					case 4:
						bluetoothEnable2 = true;
						goto IL_158;
					case 5:
						if (!global::SharedUtility.SharedConstrains.SharedCon_ValidateDataProfileAirInterfaceIP_DataWide_SerialLink1(airInterfaceIP, dataWideSubscriberIP, dataWidePeerIP, autoRegServerIP, arsMode2, out error))
						{
							num = (short)526123015;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 6:
						goto IL_CF;
					case 7:
						goto IL_2EA;
					case 8:
					{
						if (!global::SharedUtility.SharedConstrains.SharedCon_ValidateDataProfileAirInterfaceIP_DataPrf_SerialLink1(airInterfaceIP, subscriberIP, peerIP, out error))
						{
							goto IL_2EA;
						}
						num = (short)741751025;
						short num4 = num;
						num = (short)975255793;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_CF;
						default:
							num = (short)1413677056;
							if (num != 0)
							{
							}
							num = (short)1691549707;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 9:
						num = (short)940834824;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (!(flag.GetValueOrDefault() == flag2 & flag != null))
						{
							num = (short)571080716;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)660799492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)1341194245;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)1063321603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8C;
					IL_CF:
					flag = bluetoothEnable;
					flag2 = true;
					num = (short)1129971722;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_158:
					global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType? bluetoothDunPeerIpAssignmentType = assignmentType;
					global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType bluetoothDunPeerIpAssignmentType2 = global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType.DYNAMIC;
					global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType assignmentType2 = (bluetoothDunPeerIpAssignmentType.GetValueOrDefault() == bluetoothDunPeerIpAssignmentType2 & bluetoothDunPeerIpAssignmentType != null) ? global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType.DYNAMIC : global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType.STATIC;
					arsMode2 = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemARSMode.DISABLED;
					global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemARSMode? astroSystemARSMode = arsMode;
					global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemARSMode astroSystemARSMode2 = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemARSMode.SERVER;
					if (astroSystemARSMode.GetValueOrDefault() == astroSystemARSMode2 & astroSystemARSMode != null)
					{
						goto IL_1BB;
					}
					astroSystemARSMode = arsMode;
					astroSystemARSMode2 = global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemARSMode.ENHANCEDSERVER;
					if (astroSystemARSMode.GetValueOrDefault() == astroSystemARSMode2 & astroSystemARSMode != null)
					{
						goto IL_1BB;
					}
					IL_1C5:
					if (global::SharedUtility.SharedConstrains.SharedCon_ValidateDataProfileAirInterfaceIP_BT(bluetoothEnable2, assignmentType2, airInterfaceIP, bluetoothDUNPeerIP, bluetoothDunSubscriberIP, out error))
					{
						num = (short)1710424065;
						if (num != 0)
						{
						}
						num = (short)1943339017;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2EA;
					IL_1BB:
					arsMode2 = arsMode.Value;
					goto IL_1C5;
					IL_2EA:
					result = false;
					num = (short)1208352768;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_8C:
				result = true;
				error = global::Motorola.Common.CustomException.CommonErrorCode.None;
				num = (short)596639746;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x0000C140 File Offset: 0x0000A340
		public static bool SharedCon_ValidateDataProfileAirInterfaceIP_BT(bool bluetoothEnable, global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType assignmentType, string airInterfaceIP, string bluetoothDUNPeerIP, string bluetoothDunSubscriberIP, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			switch (0)
			{
			case 0:
				goto IL_44;
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
					if (error != global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num2 = (short)1502674954;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					if (airInterfaceIP.Trim().Equals(bluetoothDUNPeerIP.Trim()))
					{
						num2 = (short)2026504197;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_A1;
				case 2:
					if (airInterfaceIP.Trim().Equals(bluetoothDunSubscriberIP.Trim()))
					{
						num2 = (short)144769035;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_227;
				case 3:
					goto IL_227;
				case 4:
				{
					num2 = (short)952220759;
					short num3 = num2;
					num2 = (short)1612692567;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15D;
					default:
						num2 = (short)987168768;
						if (num2 != 0)
						{
						}
						num2 = (short)989003788;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubAirInterfaceIP_NoSame_BlueToothDUNPeerIP;
					num2 = (short)1389690883;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_176;
				case 7:
					goto IL_227;
				case 8:
					num2 = (short)198377473;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (bluetoothEnable)
					{
						num2 = (short)560857092;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_227;
				case 10:
					goto IL_15D;
				case 11:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubAirInterfaceIP_NoSame_BlueToothDUNSubIP;
					num2 = (short)984612871;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					if (assignmentType == global::Motorola.CommonCPS.Server.CommonDBConstants.BluetoothDunPeerIpAssignmentType.DYNAMIC)
					{
						num2 = (short)1523384328;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_A1;
				}
				goto IL_44;
				IL_A1:
				num2 = (short)1398538241;
				if (num2 != 0)
				{
				}
				num2 = (short)156958722;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_15D:
				result = false;
				num2 = (short)915865606;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_227:
				num2 = (short)343605248;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_176:
			num2 = (short)382468096;
			short num4 = num2;
			return result;
			IL_44:
			result = true;
			error = global::Motorola.Common.CustomException.CommonErrorCode.None;
			num2 = (short)1171128329;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x0000C3D4 File Offset: 0x0000A5D4
		public static bool SharedCon_ValidateDataProfileAirInterfaceIP_DataPrf_SerialLink1(string airInterfaceIP, string subscriberIP, string peerIP, out global::Motorola.Common.CustomException.CommonErrorCode error)
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
					if (airInterfaceIP.Trim().Equals(peerIP.Trim()))
					{
						num2 = (short)1816657924;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_7E;
				case 1:
				{
					num2 = (short)986545149;
					short num3 = num2;
					num2 = (short)54819837;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1FD;
					default:
						num2 = (short)328204288;
						if (num2 != 0)
						{
						}
						goto IL_7E;
					}
					break;
				}
				case 2:
					return result;
				case 3:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubAirInterfaceIP_NoSame_ProfileSubIP;
					num2 = (short)1736310792;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_1FD;
				case 5:
					if (airInterfaceIP.Trim().Equals(subscriberIP.Trim()))
					{
						num2 = (short)464257027;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1292238849;
					if (num2 != 0)
					{
					}
					num2 = (short)1918435328;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					result = false;
					num2 = (short)632881154;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (error != global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num2 = (short)454164486;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 8:
					goto IL_7E;
				}
				goto IL_34;
				IL_7E:
				num2 = (short)720044039;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1FD:
				error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubAirInterfaceIP_NoSame_ProfilePeerIP;
				num2 = (short)863240192;
				short num4 = num2;
				num2 = (short)516423681;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_34:
			result = true;
			error = global::Motorola.Common.CustomException.CommonErrorCode.None;
			num2 = (short)1172635653;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x0000C5E4 File Offset: 0x0000A7E4
		public static bool SharedCon_ValidateDataProfileAirInterfaceIP_DataWide_SerialLink1(string airInterfaceIP, string dataWideSubscriberIP, string dataWidePeerIP, string autoRegServerIP, global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemARSMode arsMode, out global::Motorola.Common.CustomException.CommonErrorCode error)
		{
			short num = (short)1454374913;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_76;
			}
			int num2;
			bool result;
			for (;;)
			{
				IL_30:
				switch (num2)
				{
				case 0:
					if (error != global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num = (short)504823810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A9;
				case 1:
					goto IL_1E3;
				case 2:
					result = false;
					num = (short)573702155;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)334626825;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (arsMode != global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemARSMode.SERVER)
					{
						num = (short)1463746563;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E3;
				case 5:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubAirInterfaceIP_NoSame_AutomaticRegistrationServerAddressIP;
					num = (short)1986461706;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubAirInterfaceIP_NoSame_SubIP;
					num = (short)1416036360;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_18A;
				case 8:
					goto IL_18A;
				case 9:
				{
					num = (short)63438848;
					short num3 = num;
					if (arsMode == global::Motorola.CommonCPS.Server.CommonDBConstants.AstroSystemARSMode.ENHANCEDSERVER)
					{
						num = (short)569573377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_18A;
				}
				case 10:
					goto IL_18A;
				case 11:
					goto IL_2A9;
				case 12:
					if (airInterfaceIP.Trim().Equals(dataWideSubscriberIP))
					{
						num = (short)246546438;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1760231438;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubAirInterfaceIP_NoSame_PeerIP;
					num = (short)2036858887;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					IL_15D:
					if (airInterfaceIP.Trim().Equals(dataWidePeerIP))
					{
						num = (short)911081485;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1810300932;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					if (airInterfaceIP.Trim().Equals(autoRegServerIP.Trim()))
					{
						num = (short)1510998021;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_18A;
				}
				goto IL_76;
				IL_2A9:
				num = (short)860764922;
				short num4 = num;
				num = (short)937048826;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_15D;
				default:
					goto IL_2DF;
				}
				IL_18A:
				num = (short)1977483264;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E3:
				num = (short)348585999;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_2DF:
			num = (short)119013376;
			if (num != 0)
			{
			}
			return result;
			IL_76:
			result = true;
			error = global::Motorola.Common.CustomException.CommonErrorCode.None;
			num = (short)124256268;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_30;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x0000C8E8 File Offset: 0x0000AAE8
		public static bool ShareValidation_SubscriberIPAddress_A21157_Before7145(string self_A21157, string mobileComputerIPAddress_A8523, string automaticRegistrationServerAddress_A7524, string airInterfaceIPAddress_A9220, string bluetoothPANNetworkAddress_41983, bool? isMobile, bool? QA00583, bool? bluetoothBluetoothEnable_A37028, out global::Motorola.Common.CustomException.CommonErrorCode error, bool IsValidationFromRMC = true)
		{
			switch (0)
			{
			case 0:
				goto IL_64;
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
					if (global::SharedUtility.SharedConstrains.b(isMobile, QA00583))
					{
						num2 = (short)484769794;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_18B;
				case 1:
					goto IL_18B;
				case 2:
					num2 = (short)1872756745;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (self_A21157.Trim().Equals(automaticRegistrationServerAddress_A7524))
					{
						num2 = (short)1178861587;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1629487108;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (self_A21157.Trim().Equals(airInterfaceIPAddress_A9220))
					{
						num2 = (short)448790541;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1195048975;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_18B;
				case 6:
				{
					num2 = (short)1090715648;
					short num3 = num2;
					self_A21157.Trim().Equals(bluetoothPANNetworkAddress_41983);
					num2 = (short)526581761;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
					goto IL_18B;
				case 8:
				{
					num2 = (short)1075695223;
					short num4 = num2;
					num2 = (short)2063519351;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_210;
					default:
						num2 = (short)488046592;
						if (num2 != 0)
						{
						}
						result = false;
						num2 = (short)273285140;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 9:
					if (global::SharedUtility.SharedConstrains.a(bluetoothBluetoothEnable_A37028))
					{
						num2 = (short)1771634694;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_18B;
				case 10:
					if (self_A21157.Trim().Equals(mobileComputerIPAddress_A8523.Trim()))
					{
						num2 = (short)979566603;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1588592641;
					if (num2 != 0)
					{
					}
					num2 = (short)248184835;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					goto IL_210;
				case 12:
					goto IL_18B;
				case 13:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileSubIP_NoSame_AirInterfaceIP;
					num2 = (short)1760821253;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					num2 = (short)171638784;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					if (IsValidationFromRMC)
					{
						num2 = (short)850853902;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_18B;
				case 16:
					if (global::SharedUtility.Utility.ValidateIPFormat(self_A21157, out error))
					{
						num2 = (short)1961426961;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_18B;
				case 17:
					num2 = (short)1110966282;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					if (error != global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num2 = (short)172294152;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 19:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileSubIP_NoSame_AutomaticRegistrationServerAddressIP;
					num2 = (short)1908670476;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					return result;
				}
				goto IL_64;
				IL_18B:
				num2 = (short)47251474;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_210:
				error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileSubIP_NoSame_ProfilePeerIP;
				num2 = (short)455475207;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_64:
			result = true;
			error = global::Motorola.Common.CustomException.CommonErrorCode.None;
			num2 = (short)1121452048;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x0000CCBC File Offset: 0x0000AEBC
		private static bool b(bool? A_0, bool? A_1)
		{
			bool? flag;
			bool flag2;
			short num;
			for (;;)
			{
				flag = A_0;
				flag2 = false;
				if (flag.GetValueOrDefault() == flag2 & flag != null)
				{
					break;
				}
				num = (short)919968740;
				short num2 = num;
				num = (short)1131977700;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_B3;
				}
			}
			num = (short)1413414912;
			short num3 = num;
			num = (short)827588609;
			if (num != 0)
			{
			}
			flag = A_1;
			flag2 = true;
			return flag.GetValueOrDefault() == flag2 & flag != null;
			IL_B3:
			num = (short)1039532032;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000CD94 File Offset: 0x0000AF94
		private static bool a(bool? A_0)
		{
			short num = (short)777892490;
			short num2 = num;
			num = (short)849261194;
			switch (num2 == num)
			{
			}
			num = (short)307691520;
			short num3 = num;
			num = (short)1850408960;
			if (num != 0)
			{
			}
			num = (short)976617473;
			if (num != 0)
			{
			}
			bool? flag = A_0;
			bool flag2 = true;
			return flag.GetValueOrDefault() == flag2 & flag != null;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000CE54 File Offset: 0x0000B054
		public static bool ShareValidation_SubscriberIPAddress_A21157_7145To715(string self_A21157, string mobileComputerIPAddress_A8523, string automaticRegistrationServerAddress_A7524, string airInterfaceIPAddress_A9220, string bluetoothPANNetworkAddress_41983, bool? isMobile, bool? QA00583, bool? bluetoothBluetoothEnable_A37028, bool? QA03344, bool? Q806, string internalRadioSubnet_A42073, out global::Motorola.Common.CustomException.CommonErrorCode error, bool IsValidationFromRMC = true)
		{
			switch (0)
			{
			case 0:
				goto IL_A4;
			}
			short num;
			int num2;
			bool result;
			for (;;)
			{
				IL_0A:
				num = (short)991756289;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					if (global::SharedUtility.SharedConstrains.b(isMobile, QA00583, QA03344, Q806))
					{
						num = (short)628359181;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EC;
				case 1:
					if (global::SharedUtility.SharedConstrains.a(bluetoothBluetoothEnable_A37028))
					{
						num = (short)757530645;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EC;
				case 2:
					if (global::SharedUtility.SharedConstrains.a(QA03344, Q806))
					{
						num = (short)1154416652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B9;
				case 3:
					if (self_A21157.Trim().Equals(airInterfaceIPAddress_A9220))
					{
						num = (short)472449030;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)363593739;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)1464795136;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_EC;
				case 6:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileSubIP_NoSame_AirInterfaceIP;
					num = (short)1141506055;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_2B9;
				case 8:
					result = false;
					num = (short)1834287113;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_258;
				case 10:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileSubIP_NoSame_ProfilePeerIP;
					num = (short)77529113;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (IsValidationFromRMC)
					{
						num = (short)1966407684;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EC;
				case 12:
					self_A21157.Trim().Equals(internalRadioSubnet_A42073);
					num = (short)1751515156;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					num = (short)788463617;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					goto IL_2B7;
				case 15:
					num = (short)505413634;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (self_A21157.Trim().Equals(mobileComputerIPAddress_A8523.Trim()))
					{
						num = (short)431357962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1470693394;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					if (IsValidationFromRMC)
					{
						num = (short)1078132751;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B9;
				case 18:
				{
					if (self_A21157.Trim().Equals(automaticRegistrationServerAddress_A7524))
					{
						num = (short)1101529107;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1530445870;
					short num3 = num;
					num = (short)1861337134;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2B7;
					default:
						num = (short)615579648;
						if (num != 0)
						{
						}
						num = (short)722731011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 19:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileSubIP_NoSame_AutomaticRegistrationServerAddressIP;
					num = (short)2042757134;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					goto IL_2B9;
				case 21:
					num = (short)1801781272;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					if (global::SharedUtility.Utility.ValidateIPFormat(self_A21157, out error))
					{
						num = (short)994967575;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B9;
				case 23:
					num = (short)1757872144;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					if (!self_A21157.Trim().Equals(bluetoothPANNetworkAddress_41983))
					{
						num = (short)207880197;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B9;
				case 25:
					goto IL_2B9;
				case 26:
					if (error != global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num = (short)1738932232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_471;
				}
				goto IL_A4;
				IL_EC:
				num = (short)1385365521;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2B9:
				num = (short)609091610;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2B7:
				goto IL_2B9;
			}
			IL_258:
			IL_471:
			num = (short)577699840;
			short num4 = num;
			return result;
			IL_A4:
			result = true;
			error = global::Motorola.Common.CustomException.CommonErrorCode.None;
			num = (short)1863581718;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x0000D2FC File Offset: 0x0000B4FC
		private static bool b(bool? A_0, bool? A_1, bool? A_2, bool? A_3)
		{
			switch (0)
			{
			case 0:
				goto IL_4F;
			}
			short num;
			int num2;
			bool? flag;
			bool flag2;
			for (;;)
			{
				IL_0A:
				num = (short)152109057;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					num = (short)1184734813;
					short num3 = num;
					num = (short)403152477;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_131;
					default:
						num = (short)1953038336;
						if (num != 0)
						{
						}
						flag = A_2;
						flag2 = true;
						num = (short)838074369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
				{
					num = (short)349765632;
					short num4 = num;
					if (flag.GetValueOrDefault() == flag2 & flag != null)
					{
						num = (short)435683333;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 2:
					if (flag.GetValueOrDefault() == flag2 & flag != null)
					{
						num = (short)895549444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 3:
					if (flag.GetValueOrDefault() == flag2 & flag != null)
					{
						num = (short)202702848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 4:
					goto IL_131;
				case 5:
					goto IL_12C;
				}
				goto IL_4F;
				IL_131:
				flag = A_1;
				flag2 = true;
				num = (short)1215102979;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_12C:
			flag = A_3;
			flag2 = true;
			return !(flag.GetValueOrDefault() == flag2 & flag != null);
			IL_4F:
			flag = A_0;
			flag2 = false;
			num = (short)621346818;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x0000D4D8 File Offset: 0x0000B6D8
		private static bool a(bool? A_0, bool? A_1)
		{
			short num;
			bool? flag;
			bool flag2;
			for (;;)
			{
				num = (short)1666449409;
				if (num != 0)
				{
				}
				num = (short)1586561024;
				short num2 = num;
				flag = A_0;
				flag2 = true;
				if (flag.GetValueOrDefault() == flag2 & flag != null)
				{
					break;
				}
				num = (short)1314207239;
				short num3 = num;
				num = (short)85865991;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_B7;
				}
			}
			flag = A_1;
			flag2 = true;
			return flag.GetValueOrDefault() == flag2 & flag != null;
			IL_B7:
			num = (short)1467613184;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000D5B4 File Offset: 0x0000B7B4
		public static bool ShareValidation_SubscriberIPAddress_A21157_715To7155(string self_A21157, string mobileComputerIPAddress_A8523, string automaticRegistrationServerAddress_A7524, string airInterfaceIPAddress_A9220, string bluetoothPANNetworkAddress_41983, bool? isMobile, bool? QA00583, bool? bluetoothBluetoothEnable_A37028, bool? QA03344, bool? Q806, string internalRadioSubnet_A42073, string locServerIPAddr_A42333, bool? GA00229, bool? G806, bool? W947, bool? QA00782, bool? Q947, bool? DataProfFeaturesDirLocReg_A4233, bool? RadWideLocationLocationEnable_A8448, bool? RadWideLocP25LocationReporting_42412, bool? DataProfFeaturesARSMode_A7465EqualServer, out global::Motorola.Common.CustomException.CommonErrorCode error, bool IsValidationFromRMC = true)
		{
			switch (0)
			{
			case 0:
				goto IL_9C;
			}
			int num;
			bool result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					result = false;
					num2 = (short)2143092745;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_2E9;
				case 2:
					num2 = (short)1081081875;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (global::SharedUtility.SharedConstrains.a(bluetoothBluetoothEnable_A37028))
					{
						num2 = (short)552796174;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_148;
				case 4:
					if (IsValidationFromRMC)
					{
						num2 = (short)1095434268;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2E9;
				case 5:
					if (global::SharedUtility.SharedConstrains.a(GA00229, G806, W947, QA00782, Q806, Q947, QA03344))
					{
						num2 = (short)2111307808;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2E9;
				case 6:
					if (self_A21157.Trim().Equals(airInterfaceIPAddress_A9220))
					{
						num2 = (short)622919705;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)224002055;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (IsValidationFromRMC)
					{
						num2 = (short)521994263;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_148;
				case 8:
					goto IL_2E9;
				case 9:
					return result;
				case 10:
					if (global::SharedUtility.SharedConstrains.a(DataProfFeaturesDirLocReg_A4233, RadWideLocationLocationEnable_A8448, RadWideLocP25LocationReporting_42412, DataProfFeaturesARSMode_A7465EqualServer))
					{
						num2 = (short)542703647;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2E9;
				case 11:
					if (error != global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num2 = (short)1545928704;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 12:
					num2 = (short)997195779;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileSubIP_NoSame_AutomaticRegistrationServerAddressIP;
					num2 = (short)239599617;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					num2 = (short)651689999;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					if (!self_A21157.Trim().Equals(bluetoothPANNetworkAddress_41983))
					{
						num2 = (short)375062562;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2E9;
				case 16:
					if (self_A21157.Trim().Equals(mobileComputerIPAddress_A8523.Trim()))
					{
						num2 = (short)1877671966;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)630915090;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					if (global::SharedUtility.SharedConstrains.b(isMobile, QA00583, QA03344, Q806))
					{
						num2 = (short)447807500;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_148;
				case 18:
					if (self_A21157.Trim().Equals(automaticRegistrationServerAddress_A7524))
					{
						num2 = (short)562298893;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1285357574;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					if (global::SharedUtility.SharedConstrains.a(QA03344, Q806))
					{
						num2 = (short)868417563;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_10A;
				case 20:
					if (global::SharedUtility.Utility.ValidateIPFormat(self_A21157, out error))
					{
						num2 = (short)1424359448;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2E9;
				case 21:
					goto IL_2E9;
				case 22:
					goto IL_10A;
				case 23:
					num2 = (short)282132497;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					num2 = (short)1789526017;
					if (num2 != 0)
					{
					}
					num2 = (short)671547408;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileSubIP_NoSame_AirInterfaceIP;
					num2 = (short)1330315285;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 26:
					if (IsValidationFromRMC)
					{
						num2 = (short)1379663874;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_10A;
				case 27:
					num2 = (short)327221277;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 28:
					num2 = (short)1814953989;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 29:
					if (!self_A21157.Trim().Equals(internalRadioSubnet_A42073))
					{
						num2 = (short)1990066198;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2E9;
				case 30:
					goto IL_47A;
				case 31:
				{
					num2 = (short)1320948997;
					short num3 = num2;
					num2 = (short)1879053573;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_47A;
					default:
						num2 = (short)1765670912;
						if (num2 != 0)
						{
						}
						self_A21157.Trim().Equals(locServerIPAddr_A42333);
						num2 = (short)671940616;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 32:
				{
					num2 = (short)844496896;
					short num4 = num2;
					num2 = (short)320274442;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 33:
					goto IL_2E9;
				case 34:
					goto IL_148;
				}
				goto IL_9C;
				IL_10A:
				num2 = (short)862453764;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_148:
				num2 = (short)829358106;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2E9:
				num2 = (short)525008907;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_47A:
				error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileSubIP_NoSame_ProfilePeerIP;
				num2 = (short)872480801;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_9C:
			result = true;
			error = global::Motorola.Common.CustomException.CommonErrorCode.None;
			num2 = (short)476315668;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000DBA0 File Offset: 0x0000BDA0
		private static bool a(bool? A_0, bool? A_1, bool? A_2, bool? A_3)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			bool? flag;
			bool flag2;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_16E;
				case 1:
					flag = A_1;
					flag2 = true;
					num2 = (short)331743235;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (flag.GetValueOrDefault() == flag2 & flag != null)
					{
						num2 = (short)572456961;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_19A;
				case 3:
					if (flag.GetValueOrDefault() == flag2 & flag != null)
					{
						num2 = (short)130351104;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_19A;
				case 4:
					goto IL_123;
				case 5:
					if (flag.GetValueOrDefault() == flag2 & flag != null)
					{
						num2 = (short)839647236;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_19A;
				}
				goto IL_28;
			}
			IL_123:
			flag = A_3;
			flag2 = false;
			return flag.GetValueOrDefault() == flag2 & flag != null;
			IL_19A:
			num2 = (short)2117861376;
			short num3 = num2;
			return false;
			IL_28:
			num2 = (short)55562148;
			short num4 = num2;
			num2 = (short)1407373220;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_16E:
				num2 = (short)1674969089;
				if (num2 != 0)
				{
				}
				flag = A_2;
				flag2 = true;
				num2 = (short)1442775045;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)329777152;
				if (num2 != 0)
				{
				}
				flag = A_0;
				flag2 = true;
				num2 = (short)1028390914;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000DD74 File Offset: 0x0000BF74
		private static bool a(bool? A_0, bool? A_1, bool? A_2, bool? A_3, bool? A_4, bool? A_5, bool? A_6)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			short num2;
			bool? flag;
			bool flag2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
				{
					num2 = (short)651100160;
					short num3 = num2;
					flag = A_1;
					flag2 = true;
					num2 = (short)769327111;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_166;
				case 2:
					flag = A_2;
					flag2 = true;
					num2 = (short)559611908;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					flag = A_4;
					flag2 = true;
					num2 = (short)727187466;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_186;
				case 5:
					if (flag.GetValueOrDefault() == flag2 & flag != null)
					{
						num2 = (short)1617756160;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_284;
				case 6:
					if (flag.GetValueOrDefault() == flag2 & flag != null)
					{
						num2 = (short)1891172355;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 7:
					if (flag.GetValueOrDefault() == flag2 & flag != null)
					{
						num2 = (short)1909653506;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_284;
				case 8:
					if (!(flag.GetValueOrDefault() == flag2 & flag != null))
					{
						num2 = (short)929955841;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 9:
					flag = A_5;
					flag2 = true;
					num2 = (short)2127167489;
					if (num2 != 0)
					{
					}
					num2 = (short)697565192;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (flag.GetValueOrDefault() == flag2 & flag != null)
					{
						num2 = (short)916586505;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 11:
					goto IL_284;
				}
				goto IL_40;
				IL_284:
				flag = A_3;
				flag2 = true;
				num2 = (short)2129330182;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_166:
			flag = A_6;
			flag2 = true;
			return !(flag.GetValueOrDefault() == flag2 & flag != null);
			IL_40:
			num2 = (short)211312727;
			short num4 = num2;
			num2 = (short)1534222423;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_186:
				if (!(flag.GetValueOrDefault() == flag2 & flag != null))
				{
					num2 = (short)159907851;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				return false;
			default:
			{
				num2 = (short)791019520;
				if (num2 != 0)
				{
				}
				flag = A_0;
				flag2 = true;
				num2 = (short)727777285;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000E054 File Offset: 0x0000C254
		public static bool ShareValidation_SubscriberIPAddress_A21157_After7155(string self_A21157, string mobileComputerIPAddress_A8523, string automaticRegistrationServerAddress_A7524, string airInterfaceIPAddress_A9220, string bluetoothPANNetworkAddress_41983, bool? isMobile, bool? QA00583, bool? bluetoothBluetoothEnable_A37028, bool? QA03344, bool? Q806, string internalRadioSubnet_A42073, string locServerIPAddr_A42333, bool? GA00229, bool? G806, bool? W947, bool? QA00782, bool? Q947, bool? DataProfFeaturesDirLocReg_A4233, bool? RadWideLocationLocationEnable_A8448, bool? RadWideLocP25LocationReporting_42412, bool? DataProfFeaturesARSMode_A7465EqualServer, bool? H91TGD9PW5AN, bool? H91TGD9PW8AN, bool? HK2060A, bool? H91TGD9PW6AN, bool? H91TGD9PW7AN, out global::Motorola.Common.CustomException.CommonErrorCode error, bool IsValidationFromRMC = true)
		{
			switch (0)
			{
			case 0:
				goto IL_9C;
			}
			int num;
			bool result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					result = false;
					num2 = (short)678756361;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_2EE;
				case 2:
					num2 = (short)651821075;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (global::SharedUtility.SharedConstrains.a(bluetoothBluetoothEnable_A37028))
					{
						num2 = (short)1551106062;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_121;
				case 4:
					if (IsValidationFromRMC)
					{
						num2 = (short)994050076;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2EE;
				case 5:
					if (global::SharedUtility.SharedConstrains.a(GA00229, G806, W947, QA00782, Q806, Q947, QA03344, H91TGD9PW5AN, H91TGD9PW8AN, HK2060A, H91TGD9PW6AN, H91TGD9PW7AN))
					{
						num2 = (short)1140064288;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2EE;
				case 6:
					if (self_A21157.Trim().Equals(airInterfaceIPAddress_A9220))
					{
						num2 = (short)1769930777;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2040070151;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (IsValidationFromRMC)
					{
						num2 = (short)76808215;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_121;
				case 8:
					goto IL_2EE;
				case 9:
					return result;
				case 10:
				{
					num2 = (short)787349504;
					short num3 = num2;
					if (global::SharedUtility.SharedConstrains.a(DataProfFeaturesDirLocReg_A4233, RadWideLocationLocationEnable_A8448, RadWideLocP25LocationReporting_42412, DataProfFeaturesARSMode_A7465EqualServer))
					{
						num2 = (short)262668319;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2EE;
				}
				case 11:
					if (error != global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num2 = (short)997654528;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 12:
					num2 = (short)1642528771;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileSubIP_NoSame_AutomaticRegistrationServerAddressIP;
					num2 = (short)684982273;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					num2 = (short)1092747279;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					if (!self_A21157.Trim().Equals(bluetoothPANNetworkAddress_41983))
					{
						num2 = (short)538116130;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2EE;
				case 16:
					if (self_A21157.Trim().Equals(mobileComputerIPAddress_A8523.Trim()))
					{
						num2 = (short)504234014;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1819344914;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					if (global::SharedUtility.SharedConstrains.b(isMobile, QA00583, QA03344, Q806))
					{
						num2 = (short)1502150668;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_121;
				case 18:
					if (self_A21157.Trim().Equals(automaticRegistrationServerAddress_A7524))
					{
						num2 = (short)1533018125;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1359609862;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					if (global::SharedUtility.SharedConstrains.a(QA03344, Q806))
					{
						num2 = (short)262012955;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E4;
				case 20:
					if (global::SharedUtility.Utility.ValidateIPFormat(self_A21157, out error))
					{
						num2 = (short)658767896;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2EE;
				case 21:
					goto IL_2EE;
				case 22:
					goto IL_E4;
				case 23:
					num2 = (short)1935933457;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					num2 = (short)1811283984;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileSubIP_NoSame_AirInterfaceIP;
					num2 = (short)985595925;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 26:
					if (IsValidationFromRMC)
					{
						num2 = (short)309264386;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E4;
				case 27:
					num2 = (short)1423638557;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 28:
					num2 = (short)341311493;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 29:
					if (!self_A21157.Trim().Equals(internalRadioSubnet_A42073))
					{
						num2 = (short)2141454358;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2EE;
				case 30:
					goto IL_47C;
				case 31:
				{
					num2 = (short)319750000;
					short num4 = num2;
					num2 = (short)768802672;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_47C;
					default:
						num2 = (short)1560412161;
						if (num2 != 0)
						{
						}
						num2 = (short)1855193088;
						if (num2 != 0)
						{
						}
						self_A21157.Trim().Equals(locServerIPAddr_A42333);
						num2 = (short)1055850504;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 32:
					num2 = (short)197459978;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 33:
					goto IL_2EE;
				case 34:
					goto IL_121;
				}
				goto IL_9C;
				IL_E4:
				num2 = (short)1083375620;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_121:
				num2 = (short)10420250;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2EE:
				num2 = (short)1936261131;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_47C:
				error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileSubIP_NoSame_ProfilePeerIP;
				num2 = (short)106561569;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_9C:
			result = true;
			error = global::Motorola.Common.CustomException.CommonErrorCode.None;
			num2 = (short)506462228;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000E648 File Offset: 0x0000C848
		private static bool a(bool? A_0, bool? A_1, bool? A_2, bool? A_3, bool? A_4, bool? A_5, bool? A_6, bool? A_7, bool? A_8, bool? A_9, bool? A_10, bool? A_11)
		{
			short num = (short)400687105;
			if (num != 0)
			{
			}
			num = (short)1766588416;
			short num2 = num;
			num = (short)1322327169;
			short num3 = num;
			num = (short)540679297;
			switch (num3 == num)
			{
			}
			num = (short)1095565312;
			if (num != 0)
			{
			}
			bool flag = global::SharedUtility.SharedConstrains.a(A_0, A_1, A_2, A_3, A_4, A_5, A_6);
			bool? flag2 = A_7;
			bool flag3 = true;
			bool flag4;
			if (!(flag2.GetValueOrDefault() == flag3 & flag2 != null))
			{
				flag2 = A_8;
				flag3 = true;
				if (!(flag2.GetValueOrDefault() == flag3 & flag2 != null))
				{
					flag2 = A_10;
					flag3 = true;
					if (!(flag2.GetValueOrDefault() == flag3 & flag2 != null))
					{
						flag2 = A_11;
						flag3 = true;
						flag4 = !(flag2.GetValueOrDefault() == flag3 & flag2 != null);
						goto IL_119;
					}
				}
			}
			flag4 = false;
			IL_119:
			bool flag5 = flag4;
			return flag && flag5;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000E774 File Offset: 0x0000C974
		public static bool ShareValidation_DataProfGeneralMobileComputerIPAddress_A8523_Before7145(string self_A8523, string subscriberIPAddress_A21157, string airInterfaceIPAddress_A9220, string subscriberIPAddress1_A9222, string bluetoothPANNetworkAddress_41983, bool? isMobile, bool? QA00583, bool? bluetoothBluetoothEnable_A37028, string BTDUNSUIPAddress_A41126, bool? isPORTABLE, bool? Q498, bool? G298, bool? Q947, bool? Q806, bool? W947, bool? G806, bool? DataProfileType_A21320EqualConventional, bool? autoGenerateIPAddress_A19320, bool? NATEnable_A38866, bool? PacketDataMode_A8689EqualFNE, string BTDUNPeerIPAddress_A41127, bool? BTDUNPeerIPAddressAssignmentType_A41128EqualDynamic, out global::Motorola.Common.CustomException.CommonErrorCode error, bool IsValidationFromRMC = true)
		{
			switch (0)
			{
			case 0:
				goto IL_B0;
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
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileSubIP_NoSame_ProfilePeerIP;
					num2 = (short)1805647885;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (self_A8523.Trim().Equals(BTDUNSUIPAddress_A41126))
					{
						num2 = (short)421462038;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_F7;
				case 2:
					num2 = (short)408748033;
					if (num2 != 0)
					{
					}
					num2 = (short)169869315;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (global::SharedUtility.SharedConstrains.a(DataProfileType_A21320EqualConventional, autoGenerateIPAddress_A19320, bluetoothBluetoothEnable_A37028, NATEnable_A38866, PacketDataMode_A8689EqualFNE))
					{
						num2 = (short)549781535;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_F7;
				case 4:
					if (self_A8523.Trim().Equals(BTDUNPeerIPAddress_A41127))
					{
						num2 = (short)1999306788;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_265;
				case 5:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_SubIP_NoSame_ProfilePeerIP;
					num2 = (short)434765833;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (!self_A8523.Trim().Equals(bluetoothPANNetworkAddress_41983))
					{
						num2 = (short)365297701;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_265;
				case 7:
				{
					bool? flag;
					bool flag2;
					if (flag.GetValueOrDefault() == flag2 & flag != null)
					{
						num2 = (short)1706688542;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2A0;
				}
				case 8:
					if (self_A8523.Trim().Equals(subscriberIPAddress1_A9222))
					{
						num2 = (short)872284165;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1148583950;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_265;
				case 10:
				{
					num2 = (short)56435571;
					short num3 = num2;
					num2 = (short)146940787;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5CF;
					default:
						num2 = (short)1532493824;
						if (num2 != 0)
						{
						}
						result = false;
						num2 = (short)1144782868;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 11:
					if (IsValidationFromRMC)
					{
						num2 = (short)1797062689;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_265;
				case 12:
					num2 = (short)300089372;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					goto IL_265;
				case 14:
					if (IsValidationFromRMC)
					{
						num2 = (short)503644172;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2A0;
				case 15:
					if (self_A8523.Trim().Equals(airInterfaceIPAddress_A9220))
					{
						num2 = (short)253296664;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1361838088;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					num2 = (short)2022375462;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					if (global::SharedUtility.SharedConstrains.a(QA00583, isPORTABLE, Q498, G298, Q947, Q806, W947, G806))
					{
						num2 = (short)932446208;
						short num4 = num2;
						num2 = (short)2068119568;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_265;
				case 18:
					if (error != global::Motorola.Common.CustomException.CommonErrorCode.None)
					{
						num2 = (short)1650851850;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 19:
					num2 = (short)238223364;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					return result;
				case 21:
					goto IL_5CF;
				case 22:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileBluetoothDUNSubIP_NoSame_ProfilePeerIP;
					num2 = (short)1433403426;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 23:
					goto IL_265;
				case 24:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfilePeerIP_NoSame_AirInterfaceIP;
					num2 = (short)498401303;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
					if (global::SharedUtility.Utility.ValidateIPFormat(self_A8523, out error))
					{
						num2 = (short)1141309469;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_265;
				case 26:
					if (self_A8523.Trim().Equals(subscriberIPAddress_A21157.Trim()))
					{
						num2 = (short)884211712;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1452670991;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 27:
					if (IsValidationFromRMC)
					{
						num2 = (short)795279381;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_F7;
				case 28:
					if (global::SharedUtility.SharedConstrains.b(isMobile, QA00583))
					{
						num2 = (short)1927938083;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2A0;
				case 29:
					num2 = (short)1390608410;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 30:
					num2 = (short)525467654;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 31:
					num2 = (short)1577910273;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 32:
					if (global::SharedUtility.SharedConstrains.a(QA00583, isPORTABLE, Q498, G298, Q947, Q806, W947, G806))
					{
						num2 = (short)1191182338;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_F7;
				case 33:
					num2 = (short)547684369;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 34:
					goto IL_265;
				case 35:
				{
					bool? flag = bluetoothBluetoothEnable_A37028;
					bool flag2 = true;
					num2 = (short)1485045767;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 36:
					error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_ProfileBluetoothDUNPeerIP_NoSame_ProfilePeerIP;
					num2 = (short)1544880167;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 37:
					goto IL_2A0;
				case 38:
					if (global::SharedUtility.SharedConstrains.a(DataProfileType_A21320EqualConventional, autoGenerateIPAddress_A19320, bluetoothBluetoothEnable_A37028, BTDUNPeerIPAddressAssignmentType_A41128EqualDynamic, NATEnable_A38866, PacketDataMode_A8689EqualFNE))
					{
						num2 = (short)964231187;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_265;
				case 39:
					goto IL_265;
				}
				goto IL_B0;
				IL_F7:
				num2 = (short)924450827;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_265:
				num2 = (short)1353187346;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2A0:
				num2 = (short)1410793499;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_5CF:
				num2 = (short)833028128;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_B0:
			result = true;
			error = global::Motorola.Common.CustomException.CommonErrorCode.None;
			num2 = (short)2113732633;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000EE30 File Offset: 0x0000D030
		private static bool a(bool? A_0, bool? A_1, bool? A_2, bool? A_3, bool? A_4, bool? A_5, bool? A_6, bool? A_7)
		{
			switch (0)
			{
			case 0:
				goto IL_94;
			}
			short num;
			int num3;
			bool? flag;
			bool flag2;
			for (;;)
			{
				IL_0A:
				num = (short)258932352;
				short num2 = num;
				num = (short)757857920;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_286;
				default:
					num = (short)737083392;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						flag = A_3;
						flag2 = true;
						num = (short)1323237382;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (!(flag.GetValueOrDefault() == flag2 & flag != null))
						{
							num = (short)844627968;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 2:
						flag = A_4;
						flag2 = true;
						num = (short)1203961860;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)1954873349;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 4:
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)1433141261;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23B;
					case 5:
						goto IL_286;
					case 6:
						if (!(flag.GetValueOrDefault() == flag2 & flag != null))
						{
							num = (short)2121072642;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 7:
						if (!(flag.GetValueOrDefault() == flag2 & flag != null))
						{
							num = (short)276627464;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 8:
						goto IL_23B;
					case 9:
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)671940619;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 10:
						flag = A_2;
						flag2 = true;
						num = (short)1406140417;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						num = (short)1151598592;
						short num4 = num;
						flag = A_0;
						flag2 = true;
						num = (short)1364131841;
						if (num != 0)
						{
						}
						num = (short)1343291404;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num = (short)1919352842;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 13:
						flag = A_5;
						flag2 = true;
						num = (short)234291207;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_94;
					IL_23B:
					flag = A_6;
					flag2 = true;
					num = (short)174718979;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			return false;
			IL_286:
			flag = A_7;
			flag2 = true;
			return flag.GetValueOrDefault() == flag2 & flag != null;
			IL_94:
			flag = A_1;
			flag2 = true;
			num = (short)1814560777;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000F16C File Offset: 0x0000D36C
		private static bool a(bool? A_0, bool? A_1, bool? A_2, bool? A_3, bool? A_4)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			bool? flag;
			bool flag2;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (flag.GetValueOrDefault() == flag2 & flag != null)
					{
						num2 = (short)951713798;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 1:
					if (flag.GetValueOrDefault() == flag2 & flag != null)
					{
						num2 = (short)901709827;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 2:
				{
					num2 = (short)1412890624;
					short num3 = num2;
					flag = A_1;
					flag2 = false;
					num2 = (short)236650497;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					flag = A_2;
					flag2 = true;
					num2 = (short)456785927;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					flag = A_3;
					flag2 = true;
					num2 = (short)1595277312;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (flag.GetValueOrDefault() == flag2 & flag != null)
					{
						num2 = (short)660930562;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 6:
					goto IL_DF;
				case 7:
				{
					num2 = (short)1723474561;
					short num4 = num2;
					num2 = (short)143860353;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
						num2 = (short)1897267200;
						if (num2 != 0)
						{
						}
						if (flag.GetValueOrDefault() == flag2 & flag != null)
						{
							num2 = (short)1818296324;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					}
					break;
				}
				}
				goto IL_30;
			}
			IL_DF:
			num2 = (short)787480577;
			if (num2 != 0)
			{
			}
			flag = A_4;
			flag2 = true;
			return !(flag.GetValueOrDefault() == flag2 & flag != null);
			IL_30:
			flag = A_0;
			flag2 = true;
			num2 = (short)1976107013;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000F394 File Offset: 0x0000D594
		private static bool a(bool? A_0, bool? A_1, bool? A_2, bool? A_3, bool? A_4, bool? A_5)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			bool? flag;
			bool flag2;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					flag = A_4;
					flag2 = true;
					num2 = (short)1938292745;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					flag = A_2;
					flag2 = true;
					num2 = (short)516620291;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (flag.GetValueOrDefault() == flag2 & flag != null)
					{
						num2 = (short)551092224;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 3:
					if (flag.GetValueOrDefault() == flag2 & flag != null)
					{
						num2 = (short)1988952069;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 4:
				{
					flag = A_1;
					flag2 = false;
					num2 = (short)743332865;
					short num3 = num2;
					num2 = (short)2006604801;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_51;
					default:
						num2 = (short)366280704;
						if (num2 != 0)
						{
						}
						num2 = (short)876740616;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
				{
					num2 = (short)1673592833;
					if (num2 != 0)
					{
					}
					num2 = (short)2107834368;
					short num4 = num2;
					flag = A_3;
					flag2 = true;
					num2 = (short)1651113986;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					goto IL_26A;
				case 7:
					goto IL_51;
				case 8:
					if (flag.GetValueOrDefault() == flag2 & flag != null)
					{
						num2 = (short)1939931137;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 9:
					if (flag.GetValueOrDefault() == flag2 & flag != null)
					{
						num2 = (short)1647575046;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				goto IL_38;
				IL_51:
				if (!(flag.GetValueOrDefault() == flag2 & flag != null))
				{
					return false;
				}
				num2 = (short)310575108;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_26A:
			flag = A_5;
			flag2 = true;
			return !(flag.GetValueOrDefault() == flag2 & flag != null);
			IL_38:
			flag = A_0;
			flag2 = true;
			num2 = (short)980877319;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000F614 File Offset: 0x0000D814
		public static bool ValidateRadioIP(ref string radioIP, bool? bluetoothEnable, out global::Motorola.Common.CustomException.CommonErrorCode error, bool autoCorrect = true)
		{
			short num = (short)481061106;
			short num2 = num;
			num = (short)1294166258;
			bool result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			case 1:
				break;
			default:
			{
				num = (short)508624896;
				short num3 = num;
				break;
			}
			}
			num = (short)527630337;
			if (num != 0)
			{
			}
			num = (short)44367872;
			if (num != 0)
			{
			}
			error = global::Motorola.Common.CustomException.CommonErrorCode.None;
			bool flag = true;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_CD;
				}
				int num4;
				string text;
				for (;;)
				{
					IL_AB:
					switch (num4)
					{
					case 0:
						flag = global::SharedUtility.Utility.IsIPValid(bluetoothEnable, ref text, autoCorrect);
						num = (short)156762117;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_PCRSubScriberIP_NotProperFormat;
						num = (short)36831238;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_180;
					case 3:
						goto IL_199;
					case 4:
						if (!string.IsNullOrWhiteSpace(text))
						{
							num = (short)1780154368;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_180;
					case 5:
						if (!flag)
						{
							num = (short)1973813249;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						radioIP = text;
						num = (short)1787297794;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_180;
					}
					goto IL_CD;
					IL_180:
					result = flag;
					num = (short)1891172355;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_199:
				return result;
				IL_CD:
				text = radioIP;
				num = (short)2142306308;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_AB;
			}
			catch
			{
				error = global::Motorola.Common.CustomException.CommonErrorCode.Constrain_IP_NotProperFormat;
				result = false;
			}
			return result;
		}
	}
}
