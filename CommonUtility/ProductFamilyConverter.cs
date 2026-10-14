using System;
using System.Collections.Generic;
using System.Reflection;
using Motorola.Common.Communication.CommonUtil;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace CommonUtility
{
	// Token: 0x0200004C RID: 76
	public class ProductFamilyConverter
	{
		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000193 RID: 403 RVA: 0x0002C33C File Offset: 0x0002A53C
		public static global::CommonUtility.ProductFamilyConverter Instance
		{
			get
			{
				short num = (short)505872384;
				short num2 = num;
				num = (short)1094332411;
				short num3 = num;
				num = (short)246558715;
				switch (num3 == num)
				{
				}
				num = (short)1686896640;
				if (num != 0)
				{
				}
				num = (short)926613505;
				if (num != 0)
				{
				}
				return global::CommonUtility.ProductFamilyConverter.b;
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0002C3E8 File Offset: 0x0002A5E8
		public global::Motorola.CommonCPS.Server.CommonDBConstants.PACType ToPacType(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily)
		{
			int a_ = 12;
			short num = (short)954097364;
			short num2 = num;
			num = (short)1358126804;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_C0;
			case 1:
				break;
			default:
			{
				num = (short)478412800;
				short num3 = num;
				break;
			}
			}
			num = (short)1626144769;
			if (num != 0)
			{
			}
			num = (short)493092864;
			if (num != 0)
			{
			}
			if (this.a.ContainsKey(productFamily))
			{
				return this.a[productFamily];
			}
			IL_C0:
			throw new global::System.Exception(global::CommonUtility.VersionUtility.b("琼儾㝀≂⥄⹆ⵈ歊㵌㵎㹐㝒⁔㑖ⵘᵚ㱜㉞ࡠརᱤ", a_));
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0002C4C8 File Offset: 0x0002A6C8
		public static global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily FromCCCProductFamily(global::Motorola.Common.Communication.CommonUtil.ProductFamily productFamily, int? prodFamilyFromRMC = 1)
		{
			int a_ = 14;
			short num = (short)1936588819;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_3C9;
				case 1:
					if (productFamily == global::Motorola.Common.Communication.CommonUtil.ProductFamily.DMR3Controller)
					{
						num = (short)85196821;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2093154318;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.VRC;
				case 3:
					if (productFamily == global::Motorola.Common.Communication.CommonUtil.ProductFamily.PhoenixRadio)
					{
						num = (short)29687833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)582090767;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (productFamily == global::Motorola.Common.Communication.CommonUtil.ProductFamily.AMPRadio)
					{
						num = (short)1637285911;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1697316870;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					return global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Paradise;
				case 6:
					if (productFamily == global::Motorola.Common.Communication.CommonUtil.ProductFamily.MatrixRadio)
					{
						num = (short)1814888465;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1935671305;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (productFamily == global::Motorola.Common.Communication.CommonUtil.ProductFamily.VRC)
					{
						num = (short)1468923906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_478;
				case 8:
				{
					num = (short)906231808;
					short num3 = num;
					int? num4;
					int num5;
					if (num4.GetValueOrDefault() == num5 & num4 != null)
					{
						num = (short)131661846;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.APX;
				}
				case 9:
					if (productFamily == global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseRadio)
					{
						num = (short)779943941;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)283312131;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					num = (short)486728655;
					short num6 = num;
					num = (short)1597563855;
					switch ((num6 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_144;
					default:
						num = (short)830799872;
						if (num != 0)
						{
						}
						if (productFamily == global::Motorola.Common.Communication.CommonUtil.ProductFamily.PBBRadio)
						{
							num = (short)992477196;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1180499969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 11:
					return global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.ParadiseRepeater;
				case 12:
					return global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.PBB;
				case 13:
					return global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.MNIS;
				case 14:
					if (productFamily == global::Motorola.Common.Communication.CommonUtil.ProductFamily.MNIS)
					{
						num = (short)1321205773;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1913192455;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					if (productFamily == global::Motorola.Common.Communication.CommonUtil.ProductFamily.MatrixRepeaterRadio)
					{
						num = (short)1089601556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_144;
				case 16:
					if (productFamily == global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseRepeaterRadio)
					{
						num = (short)1522204683;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)129499160;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					return global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Matrix;
				case 18:
				{
					int? num4 = prodFamilyFromRMC;
					int num5 = 4096;
					num = (short)1426587656;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 19:
					switch (0)
					{
					case 0:
						goto IL_95;
					}
					continue;
				case 20:
					return global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.MatrixRepeater;
				case 21:
					return global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.DMR3Controller;
				case 22:
					return global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP;
				case 23:
					return global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP;
				case 24:
					if (productFamily == global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseLightRadio)
					{
						num = (short)137887744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1987706890;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					return global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Phoenix;
				}
				IL_95:
				if (productFamily == global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio)
				{
					num = (short)2031550482;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)705626116;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_144:
				num = (short)1094975504;
				num2 = (int)((global::System.IntPtr)num);
			}
			return global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.PBB;
			IL_3C9:
			num = (short)925499393;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.ParadiseLight;
			IL_478:
			throw new global::System.Exception(global::CommonUtility.VersionUtility.b("嘾⽀㕂⑄⭆⁈⽊浌㽎⍐㱒ㅔ≖㩘⽚絜ᥞ`๢౤୦ၨ", a_));
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0002C960 File Offset: 0x0002AB60
		public static global::Motorola.Common.Communication.CommonUtil.ProductFamily ToCCCProduectFamily(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily)
		{
			int a_ = 7;
			short num = (short)1517223953;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (productFamily == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Phoenix)
					{
						num = (short)595197953;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)958922773;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return global::Motorola.Common.Communication.CommonUtil.ProductFamily.PhoenixRadio;
				case 2:
					return global::Motorola.Common.Communication.CommonUtil.ProductFamily.PBBRadio;
				case 3:
					if (productFamily == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.ParadiseLight)
					{
						num = (short)1339949078;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)679673865;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.VRC == productFamily)
					{
						num = (short)1354694668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_40D;
				case 5:
					return global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseRepeaterRadio;
				case 6:
					if (productFamily == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.ParadiseRepeater)
					{
						num = (short)1295646725;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)843513859;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					return global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseRadio;
				case 8:
					if (global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.DMR3Controller == productFamily)
					{
						num = (short)1671102483;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1661403146;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (productFamily == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.PBB)
					{
						num = (short)1143406594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)615120904;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.MNIS == productFamily)
					{
						num = (short)624689166;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)553451524;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (productFamily == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP)
					{
						num = (short)1217789965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)503119892;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					return global::Motorola.Common.Communication.CommonUtil.ProductFamily.VRC;
				case 13:
				{
					num = (short)1480253833;
					short num3 = num;
					num = (short)857268617;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_3B3;
					}
					goto Block_12;
				}
				case 14:
					return global::Motorola.Common.Communication.CommonUtil.ProductFamily.MNIS;
				case 15:
					goto IL_230;
				case 16:
					return global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio;
				case 17:
					switch (0)
					{
					case 0:
						goto IL_8E;
					}
					continue;
				case 18:
					return global::Motorola.Common.Communication.CommonUtil.ProductFamily.MatrixRepeaterRadio;
				case 19:
					return global::Motorola.Common.Communication.CommonUtil.ProductFamily.DMR3Controller;
				case 20:
					if (productFamily == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Matrix)
					{
						num = (short)1324089359;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1762328599;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					if (productFamily == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.MatrixRepeater)
					{
						num = (short)820576274;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)388628486;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					return global::Motorola.Common.Communication.CommonUtil.ProductFamily.ParadiseLightRadio;
				case 23:
					if (productFamily == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Paradise)
					{
						num = (short)994705415;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)951058432;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_8E:
				if (productFamily == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.APX)
				{
					num = (short)1598488592;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)722599947;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio;
			IL_230:
			num = (short)950599681;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.CommonUtil.ProductFamily.MatrixRadio;
			Block_12:
			num = (short)841089024;
			short num4 = num;
			IL_3B3:
			num = (short)1928200192;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.CommonUtil.ProductFamily.AMPRadio;
			IL_40D:
			throw new global::System.Exception(global::CommonUtility.VersionUtility.b("儷吹䨻弽ⰿ⭁⁃晅㡇㡉⍋⩍╏ㅑ⁓癕ṗ㭙ㅛ㝝౟᭡", a_));
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0002CD90 File Offset: 0x0002AF90
		private ProductFamilyConverter()
		{
			int a_ = 2;
			this.a = new global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily, global::Motorola.CommonCPS.Server.CommonDBConstants.PACType>();
			base..ctor();
			global::System.Type typeFromHandle = typeof(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily);
			typeFromHandle.GetFields();
			foreach (object obj in global::System.Enum.GetValues(typeFromHandle))
			{
				global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily key = (global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily)obj;
				global::System.Reflection.MemberInfo[] member = typeFromHandle.GetMember(key.ToString());
				if (member.Length == 0)
				{
					throw new global::System.Exception(global::CommonUtility.VersionUtility.b("娲嬴䄶堸场吼嬾慀㍂㝄⡆ⵈ㹊⹌㭎㝐㉒㡔㹖㕘≚", a_));
				}
				global::Motorola.CommonCPS.Server.CommonDBConstants.DefinedPACTypeAttribute[] array = (global::Motorola.CommonCPS.Server.CommonDBConstants.DefinedPACTypeAttribute[])member[0].GetCustomAttributes(typeof(global::Motorola.CommonCPS.Server.CommonDBConstants.DefinedPACTypeAttribute), false);
				if (array != null && array.Length >= 1)
				{
					if (this.a.ContainsKey(key))
					{
						throw new global::System.Exception(global::CommonUtility.VersionUtility.b("圲䀴䜶唸刺帼帾㕀♂⅄杆㥈㥊≌⭎⑐げ⅔睖㽘㩚ぜ㙞ൠᩢ", a_));
					}
					this.a[key] = array[0].PacType;
				}
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0002CEB0 File Offset: 0x0002B0B0
		// Note: this type is marked as 'beforefieldinit'.
		static ProductFamilyConverter()
		{
			short num = (short)511442944;
			short num2 = num;
			num = (short)392100560;
			short num3 = num;
			num = (short)2011822800;
			switch (num3 == num)
			{
			}
			num = (short)1639645184;
			if (num != 0)
			{
			}
			num = (short)946339841;
			if (num != 0)
			{
			}
			global::CommonUtility.ProductFamilyConverter.b = new global::CommonUtility.ProductFamilyConverter();
		}

		// Token: 0x04000109 RID: 265
		private readonly global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily, global::Motorola.CommonCPS.Server.CommonDBConstants.PACType> a;

		// Token: 0x0400010A RID: 266
		private static global::CommonUtility.ProductFamilyConverter b;
	}
}
