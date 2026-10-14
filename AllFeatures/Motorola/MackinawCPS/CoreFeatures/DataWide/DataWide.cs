using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DataWide
{
	// Token: 0x020004E0 RID: 1248
	[global::System.Serializable]
	public class DataWide : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x0600A47A RID: 42106 RVA: 0x00997E2C File Offset: 0x0099602C
		public DataWide(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 17;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("雑뗓ꋕ맗龎诛럝蓟蟡", a_);
			base.UIName = global::CommonResources.AcgResources.ID_DATAWIDE;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("鏑룓뫕黗뿙뷛ꫝ闟郡臣闥폧ꧩ菫菭胯鷱髳鏵雷軹ꃻ뫽懿瘁攃★䬇攉戋栍礏甑愓搕礗渙甛焝丟縡怣䜥尧䬩ఫ礭夯嘱儳樵簷嬹䠻弽᜿⭁⁃⍅晇㉉ⵋ⍍㱏", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DataWide.General(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DataWide.POP25(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DataWide.LTE(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DataWide.WIFI(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DataWide.ExternalDataModem(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATList(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataUserList(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DataWide.QuickTextMessageList(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataProtocolConfiguration(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DataWide.LabtoolDATA_CFG(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x0600A47B RID: 42107 RVA: 0x00997F10 File Offset: 0x00996110
		protected DataWide(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 18;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("韒듔ꏖ룘ﯚ諜뛞藠蛢", a_);
			base.UIName = global::CommonResources.AcgResources.ID_DATAWIDE;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("鋒맔믖鿘뻚볜ꯞ铠釢胤铦틨꣪苬苮臰鳲鯴鋶韸迺ꇼ믾怀眂搄✆䨈搊挌椎砐琒怔攖砘漚琜瀞传缢愤䘦崨䨪ബ砮堰圲倴欶紸娺䤼帾ᙀ⩂⅄≆杈㍊ⱌ≎㵐", a_);
			this.a(info, context);
		}

		// Token: 0x1700526A RID: 21098
		// (get) Token: 0x0600A47C RID: 42108 RVA: 0x00997F6C File Offset: 0x0099616C
		public global::Motorola.MackinawCPS.CoreFeatures.DataWide.General General
		{
			get
			{
				short num = (short)1555758975;
				short num2 = num;
				num = (short)1650786175;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1402863616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1889140737;
				if (num != 0)
				{
				}
				num = (short)1948188672;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DataWide.General)base[10066];
			}
		}

		// Token: 0x1700526B RID: 21099
		// (get) Token: 0x0600A47D RID: 42109 RVA: 0x00998024 File Offset: 0x00996224
		public global::Motorola.MackinawCPS.CoreFeatures.DataWide.POP25 POP25
		{
			get
			{
				short num = (short)2001538919;
				short num2 = num;
				num = (short)1007816551;
				switch (num2 == num)
				{
				default:
				{
					num = (short)434569216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1808007169;
				if (num != 0)
				{
				}
				num = (short)347209728;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DataWide.POP25)base[10065];
			}
		}

		// Token: 0x1700526C RID: 21100
		// (get) Token: 0x0600A47E RID: 42110 RVA: 0x009980E0 File Offset: 0x009962E0
		public global::Motorola.MackinawCPS.CoreFeatures.DataWide.LTE LTE
		{
			get
			{
				short num = (short)1693606470;
				short num2 = num;
				num = (short)1296392774;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1217462272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1695809537;
				if (num != 0)
				{
				}
				num = (short)241762304;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DataWide.LTE)base[10782];
			}
		}

		// Token: 0x1700526D RID: 21101
		// (get) Token: 0x0600A47F RID: 42111 RVA: 0x0099819C File Offset: 0x0099639C
		public global::Motorola.MackinawCPS.CoreFeatures.DataWide.WIFI WIFI
		{
			get
			{
				short num = (short)253665438;
				short num2 = num;
				num = (short)1316135070;
				switch (num2 == num)
				{
				default:
				{
					num = (short)775618560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1151991809;
				if (num != 0)
				{
				}
				num = (short)467730432;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DataWide.WIFI)base[10793];
			}
		}

		// Token: 0x1700526E RID: 21102
		// (get) Token: 0x0600A480 RID: 42112 RVA: 0x00998254 File Offset: 0x00996454
		public global::Motorola.MackinawCPS.CoreFeatures.DataWide.ExternalDataModem ExternalDataModem
		{
			get
			{
				short num = (short)554842347;
				short num2 = num;
				num = (short)1916156139;
				switch (num2 == num)
				{
				default:
				{
					num = (short)801701888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1210974209;
				if (num != 0)
				{
				}
				num = (short)80936960;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DataWide.ExternalDataModem)base[10849];
			}
		}

		// Token: 0x1700526F RID: 21103
		// (get) Token: 0x0600A481 RID: 42113 RVA: 0x00998310 File Offset: 0x00996510
		public global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATList NATList
		{
			get
			{
				short num = (short)325482554;
				short num2 = num;
				num = (short)2045212730;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1633484800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1444675585;
				if (num != 0)
				{
				}
				num = (short)1830354944;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATList)base[10067];
			}
		}

		// Token: 0x17005270 RID: 21104
		// (get) Token: 0x0600A482 RID: 42114 RVA: 0x009983CC File Offset: 0x009965CC
		public global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataUserList DataUserList
		{
			get
			{
				short num = (short)1827667969;
				if (num != 0)
				{
				}
				num = (short)1325531136;
				short num2 = num;
				num = (short)28187348;
				short num3 = num;
				num = (short)2015304404;
				switch (num3 == num)
				{
				}
				num = (short)614006784;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataUserList)base[10069];
			}
		}

		// Token: 0x17005271 RID: 21105
		// (get) Token: 0x0600A483 RID: 42115 RVA: 0x00998488 File Offset: 0x00996688
		public global::Motorola.MackinawCPS.CoreFeatures.DataWide.QuickTextMessageList QuickTextMessageList
		{
			get
			{
				short num = (short)1875251339;
				short num2 = num;
				num = (short)1221464203;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1326383104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1025179649;
				if (num != 0)
				{
				}
				num = (short)475004928;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DataWide.QuickTextMessageList)base[10071];
			}
		}

		// Token: 0x17005272 RID: 21106
		// (get) Token: 0x0600A484 RID: 42116 RVA: 0x00998540 File Offset: 0x00996740
		public global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataProtocolConfiguration DataProtocolConfiguration
		{
			get
			{
				short num = (short)1581740581;
				short num2 = num;
				num = (short)401895973;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1075249152;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)170393601;
				if (num != 0)
				{
				}
				num = (short)886833152;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataProtocolConfiguration)base[10503];
			}
		}

		// Token: 0x17005273 RID: 21107
		// (get) Token: 0x0600A485 RID: 42117 RVA: 0x009985F8 File Offset: 0x009967F8
		public global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration PortConfiguration
		{
			get
			{
				short num = (short)828178433;
				if (num != 0)
				{
				}
				num = (short)1826684928;
				short num2 = num;
				num = (short)811040587;
				short num3 = num;
				num = (short)2047639371;
				switch (num3 == num)
				{
				}
				num = (short)2025652224;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DataWide.PortConfiguration)base[10632];
			}
		}

		// Token: 0x17005274 RID: 21108
		// (get) Token: 0x0600A486 RID: 42118 RVA: 0x009986B4 File Offset: 0x009968B4
		public global::Motorola.MackinawCPS.CoreFeatures.DataWide.LabtoolDATA_CFG LabtoolDATA_CFG
		{
			get
			{
				short num = (short)1613778884;
				short num2 = num;
				num = (short)1344229316;
				switch (num2 == num)
				{
				default:
				{
					num = (short)693633024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)277544961;
				if (num != 0)
				{
				}
				num = (short)1165361152;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.DataWide.LabtoolDATA_CFG)base[10073];
			}
		}

		// Token: 0x0600A487 RID: 42119 RVA: 0x0099876C File Offset: 0x0099696C
		public static global::AcpCommonLib.IAcpFeatureNode GetDataWide()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			global::AcpCommonLib.IAcpFeatureNode result;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2028)[0];
					num2 = (short)839778305;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return result;
				case 2:
					return result;
				case 3:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)73990144;
						short num3 = num2;
						num2 = (short)1608974336;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_F8;
				}
				goto IL_20;
			}
			IL_F8:
			result = global::AcpCommonLib.FeatureManager.GetFeature(2028)[0];
			goto IL_109;
			IL_20:
			result = null;
			num2 = (short)1696106847;
			short num4 = num2;
			num2 = (short)299600223;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_109:
				num2 = (short)2003173378;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)924319744;
				if (num2 != 0)
				{
				}
				num2 = (short)712245249;
				if (num2 != 0)
				{
				}
				num2 = (short)1376059395;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600A488 RID: 42120 RVA: 0x009988CC File Offset: 0x00996ACC
		private void a(global::System.Runtime.Serialization.SerializationInfo A_0, global::System.Runtime.Serialization.StreamingContext A_1)
		{
			short num = (short)1162942729;
			short num2 = num;
			num = (short)1403918601;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1528823808;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1566507008;
			if (num != 0)
			{
			}
			num = (short)768475137;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x0600A489 RID: 42121 RVA: 0x0099897C File Offset: 0x00996B7C
		private void a()
		{
			short num = (short)238354436;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)2104623104;
					short num3 = num;
					num = (short)1206321155;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					return;
				case 2:
					base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.DataWide.LTE(this));
					num = (short)1911947265;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (this.LTE == null)
					{
						num = (short)1918631938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				}
				IL_38:
				num = (short)1099804304;
				short num4 = num;
				num = (short)588951184;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					num = (short)1699872768;
					if (num != 0)
					{
					}
					if (global::AcpCommonLib.AppInfoManager.DndOperation)
					{
						return;
					}
					num = (short)1797259265;
					if (num != 0)
					{
					}
					num = (short)1490157568;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}
	}
}
