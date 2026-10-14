using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioInformation
{
	// Token: 0x020001A8 RID: 424
	[global::System.Serializable]
	public class RadioInformation : global::AcpBusinessLayer.FeatureNode
	{
		// Token: 0x0600453E RID: 17726 RVA: 0x00406038 File Offset: 0x00404238
		public RadioInformation(global::AcpBusinessLayer.Recordset parent)
		{
			int a_ = 15;
			base..ctor(parent);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("苏돑냓뿕럗龎闛냝蛟跡難该觧黩藫臭黯", a_);
			base.UIName = global::CommonResources.AcgResources.ID_RADIOINFORMATION;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("量뻑룓郕뷗믙꣛ꯝ鋟蟡韣\udde5ꯧ藩臫黭鿯鳱釳飵賷꛹껻鿽擿欁欃★䄇搉樋愍戏缑甓戕焗甙爛䈝爟䌡䀣伥䜧挩䈫䠭弯䀱夳圵䰷匹医倽渿㩁╃⭅⑇", a_);
			global::Common.CodeplugStatus status = global::Common.CodeplugStatusManager.Status;
			global::Common.CodeplugStatusManager.Status = global::Common.CodeplugStatus.Opening;
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.General(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Tracking(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.FLASHport(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.AdvancedSystemKeyInfo(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.DepotKeyInfo(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.FrequencyRanges(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.OptionExpansionBoard(this));
			base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Labtool(this));
			global::Common.CodeplugStatusManager.Status = status;
		}

		// Token: 0x0600453F RID: 17727 RVA: 0x004060F8 File Offset: 0x004042F8
		protected RadioInformation(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 19;
			base..ctor(info, context);
			base.FeatureName = global::AllFeatures.CodeplugGuid.b("蛓럕볗동돛ﻝ꧟賡苣觥髧蟩跫髭駯鷱髳", a_);
			base.UIName = global::CommonResources.AcgResources.ID_RADIOINFORMATION;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("闓뫕듗鳙맛뿝铟韡難菥鯧퇩꿫臭鷯英鯳飵鷷铹裻ꋽ勿持怃漅朇⨉䔋怍瘏紑易笕礗渙甛焝丟縡瘣䜥䰧䌩䌫札帯吱嬳䐵唷嬹䠻圽⼿ⱁ橃㹅⥇❉⁋", a_);
			this.a(info, context);
		}

		// Token: 0x17002382 RID: 9090
		// (get) Token: 0x06004540 RID: 17728 RVA: 0x00406154 File Offset: 0x00404354
		public global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.General General
		{
			get
			{
				short num = (short)965496992;
				short num2 = num;
				num = (short)1882476704;
				switch (num2 == num)
				{
				}
				num = (short)147652608;
				short num3 = num;
				num = (short)684589057;
				if (num != 0)
				{
				}
				num = (short)1840185344;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.General)base[10108];
			}
		}

		// Token: 0x17002383 RID: 9091
		// (get) Token: 0x06004541 RID: 17729 RVA: 0x0040620C File Offset: 0x0040440C
		public global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Tracking Tracking
		{
			get
			{
				short num = (short)1302945614;
				short num2 = num;
				num = (short)856907598;
				switch (num2 == num)
				{
				}
				num = (short)2037710848;
				short num3 = num;
				num = (short)814546945;
				if (num != 0)
				{
				}
				num = (short)243400704;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Tracking)base[10109];
			}
		}

		// Token: 0x17002384 RID: 9092
		// (get) Token: 0x06004542 RID: 17730 RVA: 0x004062C4 File Offset: 0x004044C4
		public global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.FLASHport FLASHport
		{
			get
			{
				short num = (short)1222840495;
				short num2 = num;
				num = (short)1267601583;
				switch (num2 == num)
				{
				}
				num = (short)1880162304;
				short num3 = num;
				num = (short)1518534657;
				if (num != 0)
				{
				}
				num = (short)1734344704;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.FLASHport)base[10111];
			}
		}

		// Token: 0x17002385 RID: 9093
		// (get) Token: 0x06004543 RID: 17731 RVA: 0x00406380 File Offset: 0x00404580
		public global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.AdvancedSystemKeyInfo AdvancedSystemKeyInfo
		{
			get
			{
				short num = (short)960796271;
				short num2 = num;
				num = (short)1388090991;
				switch (num2 == num)
				{
				}
				num = (short)1760690176;
				short num3 = num;
				num = (short)398721025;
				if (num != 0)
				{
				}
				num = (short)253034496;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.AdvancedSystemKeyInfo)base[10112];
			}
		}

		// Token: 0x17002386 RID: 9094
		// (get) Token: 0x06004544 RID: 17732 RVA: 0x00406438 File Offset: 0x00404638
		public global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.DepotKeyInfo DepotKeyInfo
		{
			get
			{
				short num = (short)1575485441;
				if (num != 0)
				{
				}
				num = (short)1476623845;
				short num2 = num;
				num = (short)1758559717;
				switch (num2 == num)
				{
				default:
				{
					num = (short)770834432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1219559424;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.DepotKeyInfo)base[10803];
			}
		}

		// Token: 0x17002387 RID: 9095
		// (get) Token: 0x06004545 RID: 17733 RVA: 0x004064F0 File Offset: 0x004046F0
		public global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.FrequencyRanges FrequencyRanges
		{
			get
			{
				short num = (short)457392996;
				short num2 = num;
				num = (short)1173832548;
				switch (num2 == num)
				{
				}
				num = (short)1959198720;
				short num3 = num;
				num = (short)120193024;
				if (num != 0)
				{
				}
				num = (short)1901723649;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.FrequencyRanges)base[10110];
			}
		}

		// Token: 0x17002388 RID: 9096
		// (get) Token: 0x06004546 RID: 17734 RVA: 0x004065A8 File Offset: 0x004047A8
		public global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.OptionExpansionBoard OptionExpansionBoard
		{
			get
			{
				short num = (short)771794089;
				short num2 = num;
				num = (short)1141089449;
				switch (num2 == num)
				{
				}
				num = (short)1806696448;
				short num3 = num;
				num = (short)1219624961;
				if (num != 0)
				{
				}
				num = (short)2009792512;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.OptionExpansionBoard)base[10631];
			}
		}

		// Token: 0x17002389 RID: 9097
		// (get) Token: 0x06004547 RID: 17735 RVA: 0x00406660 File Offset: 0x00404860
		public global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Labtool Labtool
		{
			get
			{
				short num = (short)491513137;
				short num2 = num;
				num = (short)1445979441;
				switch (num2 == num)
				{
				}
				num = (short)1648820224;
				short num3 = num;
				num = (short)1884356609;
				if (num != 0)
				{
				}
				num = (short)617545728;
				if (num != 0)
				{
				}
				return (global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Labtool)base[10107];
			}
		}

		// Token: 0x06004548 RID: 17736 RVA: 0x00406714 File Offset: 0x00404914
		public static global::AcpCommonLib.IAcpFeatureNode GetRadioInformation()
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpFeatureNode result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)798949378;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_57;
				case 1:
					goto IL_7D;
				case 2:
				{
					num2 = (short)165256974;
					short num3 = num2;
					num2 = (short)554671886;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_57;
					default:
						num2 = (short)895287297;
						if (num2 != 0)
						{
						}
						num2 = (short)1206976512;
						if (num2 != 0)
						{
						}
						result = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2049)[0];
						num2 = (short)490668035;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					return result;
				}
				goto IL_20;
				IL_57:
				result = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0];
				num2 = (short)1064173569;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_7D:
			num2 = (short)748748800;
			short num4 = num2;
			return result;
			IL_20:
			result = null;
			num2 = (short)841875456;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06004549 RID: 17737 RVA: 0x00406870 File Offset: 0x00404A70
		private void a(global::System.Runtime.Serialization.SerializationInfo A_0, global::System.Runtime.Serialization.StreamingContext A_1)
		{
			short num = (short)1654949821;
			short num2 = num;
			num = (short)1761707965;
			switch (num2 == num)
			{
			}
			num = (short)680853504;
			short num3 = num;
			num = (short)24182785;
			if (num != 0)
			{
			}
			num = (short)1396506624;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x0600454A RID: 17738 RVA: 0x0040691C File Offset: 0x00404B1C
		private void a()
		{
			short num = (short)814153729;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 2:
				{
					num = (short)1323314004;
					short num3 = num;
					num = (short)531311444;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_64;
					default:
						num = (short)124125184;
						if (num != 0)
						{
						}
						if (this.OptionExpansionBoard == null)
						{
							num = (short)1827274753;
							if (num != 0)
							{
							}
							num = (short)560005124;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					break;
				}
				case 3:
				{
					num = (short)11862016;
					short num4 = num;
					num = (short)971898882;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					base.AddFeatureSection(new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.OptionExpansionBoard(this));
					goto IL_64;
				}
				IL_38:
				if (!global::AcpCommonLib.AppInfoManager.DndOperation)
				{
					num = (short)1330380803;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_64:
				num = (short)916914176;
				num2 = (int)((global::System.IntPtr)num);
			}
		}
	}
}
