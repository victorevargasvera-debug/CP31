using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;

namespace Motorola.MackinawCPS.CoreFeatures.Buttons
{
	// Token: 0x02000411 RID: 1041
	[global::System.Serializable]
	public class Buttons : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x06008EA9 RID: 36521 RVA: 0x0086A6F4 File Offset: 0x008688F4
		public Buttons(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 2;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("臂냄돆뷈꓊ꏌ볎", a_);
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("苂꧄ꯆ迈껊곌믎ꓐꇒ냔ꓖ飚닜닞釠賢诤苦蟨鿪뇬뷮郰韲鳴飶\ud9f8뻺迼飾渀洂樄樆怈栊縌⼎刐簒笔焖瀘簚栜洞䀠圢䰤䠦䜨眪測䀮弰䜲䜴堶唸䠺愼紾㑀㝂ㅄ⡆❈㡊ᅌൎ⑐❒⅔㡖㝘⡚獜❞`๢।", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.Buttons.General(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButton(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.Buttons.SideArrowButtons(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x06008EAA RID: 36522 RVA: 0x0086A770 File Offset: 0x00868970
		protected Buttons(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 8;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("诈뻊만믎뻐뷒ꛔ", a_);
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("裈ꟊꇌ觎듐닒ꇔꋖꯘ뻚껜ꋠ賢裤韦蛨藪裬臮藰꿲ꟴ零鷸鋺鋼\udffe䐀焂戄栆月搊怌明爐怒㔔吖瘘甚笜瘞䘠嘢圤䘦崨䈪䈬䄮洰瀲娴夶䴸䤺刼匾㉀ὂ݄㉆㵈㽊≌ⅎ≐དྷ᝔≖ⵘ⽚㉜ㅞበ䵢ᵤ٦Ѩݪ", a_);
		}

		// Token: 0x1700480A RID: 18442
		// (get) Token: 0x06008EAB RID: 36523 RVA: 0x0086A7B8 File Offset: 0x008689B8
		public global::Motorola.MackinawCPS.CoreFeatures.Buttons.General General
		{
			get
			{
				short num = (short)2079326208;
				short num2 = num;
				num = (short)134651759;
				short num3 = num;
				num = (short)2110758767;
				switch (num3 == num)
				{
				}
				num = (short)1144913921;
				if (num != 0)
				{
				}
				num = (short)1397555200;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.Buttons.General)base[10091];
			}
		}

		// Token: 0x1700480B RID: 18443
		// (get) Token: 0x06008EAC RID: 36524 RVA: 0x0086A874 File Offset: 0x00868A74
		public global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButton DataButton
		{
			get
			{
				short num = (short)398458880;
				short num2 = num;
				num = (short)870454918;
				short num3 = num;
				num = (short)1372001926;
				switch (num3 == num)
				{
				}
				num = (short)318636032;
				if (num != 0)
				{
				}
				num = (short)1038811137;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButton)base[10089];
			}
		}

		// Token: 0x1700480C RID: 18444
		// (get) Token: 0x06008EAD RID: 36525 RVA: 0x0086A92C File Offset: 0x00868B2C
		public global::Motorola.MackinawCPS.CoreFeatures.Buttons.SideArrowButtons SideArrowButtons
		{
			get
			{
				short num = (short)1132134400;
				short num2 = num;
				num = (short)1009768647;
				short num3 = num;
				num = (short)357816519;
				switch (num3 == num)
				{
				}
				num = (short)266665985;
				if (num != 0)
				{
				}
				num = (short)949944320;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.Buttons.SideArrowButtons)base[10745];
			}
		}

		// Token: 0x06008EAE RID: 36526 RVA: 0x0086A9E8 File Offset: 0x00868BE8
		public static global::AcpCommonLib.IAcpFeatureNode GetButtons()
		{
			switch (0)
			{
			case 0:
				goto IL_6A;
			}
			short num;
			int num3;
			global::AcpCommonLib.IAcpFeatureNode result;
			for (;;)
			{
				IL_0A:
				num = (short)1536569819;
				short num2 = num;
				num = (short)595866075;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)643629056;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
						{
							goto IL_DC;
						}
						result = global::AcpCommonLib.FeatureManager.GetFeature(2042)[0];
						num = (short)349896706;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return result;
					case 2:
						return result;
					case 3:
						result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2042)[0];
						num = (short)531496961;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6A;
				}
				IL_DC:
				num = (short)2038628355;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_6A:
			num = (short)1901461505;
			if (num != 0)
			{
			}
			result = null;
			num = (short)1803681792;
			short num4 = num;
			num = (short)484900864;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}
	}
}
