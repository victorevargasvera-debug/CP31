using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioInformation
{
	// Token: 0x020001A9 RID: 425
	[global::System.Serializable]
	public class FLASHport : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600454B RID: 17739 RVA: 0x00406A7C File Offset: 0x00404C7C
		public FLASHport(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600454C RID: 17740 RVA: 0x00406A98 File Offset: 0x00404C98
		protected FLASHport(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600454D RID: 17741 RVA: 0x00406AB0 File Offset: 0x00404CB0
		public override void Init()
		{
			int a_ = 0;
			short num = (short)994969702;
			short num2 = num;
			num = (short)550897766;
			switch (num2 == num)
			{
			}
			num = (short)1876754432;
			short num3 = num;
			num = (short)269090817;
			if (num != 0)
			{
			}
			num = (short)788398080;
			if (num != 0)
			{
			}
			this.radInfoFLASHportFLASHcode_A8132 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("杻響ￎ퇠폢헤ퟦ\ud9e8\udbea샬\udfee쇰쏲열쟶째", a_), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ軆ꟈ귊ꋌ觎鷐鋒蛔鿖꧘듚꿜ꯞ꟠꿢ꓤ듦ꇨ裪苬诮铰곲듴쿶죸죺쿼", a_), global::CommonResources.AcgResources.ID_FLASHCODE, 29);
			this.radInfoFLASHportFLASHcode_A8132.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoFLASHportFLASHcode_A8132.DataTransferOrder = -1;
			this.radInfoFLASHportIButton_A8217 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("杻﯊﷌ￎ", a_), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ軆ꟈ귊ꋌ觎鷐鋒蛔鿖꧘듚꿜ꯞ꣠ꇢ郤鏦鷨蓪菬냮냰쯲쟴웶컸", a_), global::CommonResources.AcgResources.ID_IBUTTON, 12);
			this.radInfoFLASHportIButton_A8217.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoFLASHportIButton_A8217.DataTransferOrder = -1;
			this.radInfoFLASHportLastUpgradeSource_A8387 = new global::AcpBusinessLayer.AcpRangeField<int, string>(3, new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.UnpackAndpackExtProgmgSrc(), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ軆ꟈ귊ꋌ觎鷐鋒蛔鿖꧘듚꿜ꯞ균苢雤鏦볨鯪諬鷮郰韲郴ꓶ雸軺迼鳾搀専䐄㼆㨈㌊㨌", a_), global::CommonResources.AcgResources.ID_LASTUPGRADESOURCE, 0, 43, 1);
			this.radInfoFLASHportLastUpgradeSource_A8387.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoFLASHportLastUpgradeSource_A8387.DataTransferOrder = -1;
			this.radInfoFLASHportLastUpgradeSource_A8387.ShowHexValue = false;
			this.radInfoLabtoolLastFLASHKeyDateStampData_A8388 = new global::AcpBusinessLayer.AcpFieldX<long, string>(0L, new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.DateTimeFormatConverter(), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ軆ꟈ귊ꋌ菎냐뇒ꇔ룖뛘럚釜뻞鋠韢ꏤꯦ꣨룪ꗬꓮ铰諲뇴零跸黺껼课怀渂甄䌆栈缊氌倎倐⬒☔⼖℘", a_), global::CommonResources.AcgResources.ID_LASTFLASHEDTIMEANDDATE);
			this.radInfoLabtoolLastFLASHKeyDateStampData_A8388.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoLabtoolLastFLASHKeyDateStampData_A8388.DataTransferOrder = -1;
			this.radInfoFLASHportNumberofTimesFlashed_A8581 = new global::AcpBusinessLayer.AcpField<int>(0, this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ軆ꟈ귊ꋌ觎鷐鋒蛔鿖꧘듚꿜ꯞ꿠離裤藦賨駪苬觮ꗰ髲飴鋶諸뷺釼黾爀欂怄挆嘈䨊㔌㨎⤐−", a_), global::CommonResources.AcgResources.ID_NUMBEROFTIMESFLASHED);
			this.radInfoFLASHportNumberofTimesFlashed_A8581.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoFLASHportNumberofTimesFlashed_A8581.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蟀迂蓄铆臈믊ꋌ뷎ꗐ", a_);
			base.Id = 10111;
			base.UIName = global::CommonResources.AcgResources.ID_FLASHPORT;
			base.DataTransferOrder = 4;
		}

		// Token: 0x0600454E RID: 17742 RVA: 0x00406CE4 File Offset: 0x00404EE4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 3;
			short num = (short)1546190856;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雃Ʂ곇菉ꋋ꣍뿏铑飓韕诗鋙곛뇝鋟雡ꫣ鏥藧裩觫鳭鿯铱ꃳ鿵闷鿹迻룽泿持眃清洇渉匋伍⠏✑Ⱃ✕", a_)))
					{
						num = (short)9961488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4CC;
				case 1:
					if (producerFields != null)
					{
						num = (short)282722304;
						short num3 = num;
						num = (short)135921671;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4CC;
				case 2:
					goto IL_1CF;
				case 3:
					goto IL_14C;
				case 4:
					goto IL_456;
				case 5:
					goto IL_134;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雃Ʂ곇菉ꋋ꣍뿏铑飓韕诗鋙곛뇝鋟雡ꋣꫥꧧ맩ꓫ跭鿯雱釳꧵맷싹췻췽㋿", a_)))
					{
						num = (short)1647247377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_456;
				case 7:
					num = (short)1970077702;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_7B;
					}
					continue;
				case 9:
					goto IL_9E;
				case 10:
					goto IL_326;
				case 11:
					num = (short)1086259201;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
				{
					num = (short)1436426621;
					short num4 = num;
					num = (short)1776492925;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14C;
					default:
						num = (short)1602355200;
						if (num != 0)
						{
						}
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雃Ʂ곇菉ꋋ꣍뿏黑뗓듕곗뗙돛닝곟菡韣鋥껧ꛩ귫뷭룯맱釳迵볷鯹裻鯽叿瘁攃欅砇三洋稍焏䴑唓⸕⬗∙␛", a_)))
						{
							num = (short)869007374;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CF;
					}
					break;
				}
				case 13:
					this.radInfoFLASHportLastUpgradeSource_A8387 = new global::AcpBusinessLayer.AcpRangeField<int, string>(3, new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.UnpackAndpackExtProgmgSrc(), this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇菉ꋋ꣍뿏铑飓韕诗鋙곛뇝鋟雡꣣蟥鯧黩맫黭韯胱闳鋵鷷꧹鏻诽狿愁愃夅䤇㈉㼋㘍✏", a_), global::CommonResources.AcgResources.ID_LASTUPGRADESOURCE);
					this.radInfoFLASHportLastUpgradeSource_A8387.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoFLASHportLastUpgradeSource_A8387.DataTransferOrder = -1;
					this.radInfoFLASHportLastUpgradeSource_A8387.ShowHexValue = false;
					num = (short)539885577;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					this.radInfoLabtoolLastFLASHKeyDateStampData_A8388 = new global::AcpBusinessLayer.AcpFieldX<long, string>(0L, new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.DateTimeFormatConverter(), this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇菉ꋋ꣍뿏黑뗓듕곗뗙돛닝곟菡韣鋥껧ꛩ귫뷭룯맱釳迵볷鯹裻鯽叿瘁攃欅砇三洋稍焏䴑唓⸕⬗∙␛", a_), global::CommonResources.AcgResources.ID_LASTFLASHEDTIMEANDDATE);
					this.radInfoLabtoolLastFLASHKeyDateStampData_A8388.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoLabtoolLastFLASHKeyDateStampData_A8388.DataTransferOrder = -1;
					num = (short)262537218;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					num = (short)2017918977;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雃Ʂ곇菉ꋋ꣍뿏铑飓韕诗鋙곛뇝鋟雡귣ꓥ鷧黩飫臭黯귱뗳컵쫷쯹쯻", a_)))
					{
						num = (short)574685202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_134;
				case 16:
					this.radInfoFLASHportNumberofTimesFlashed_A8581 = new global::AcpBusinessLayer.AcpField<int>(0, this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇菉ꋋ꣍뿏铑飓韕诗鋙곛뇝鋟雡ꫣ鏥藧裩觫鳭鿯铱ꃳ鿵闷鿹迻룽泿持眃清洇渉匋伍⠏✑Ⱃ✕", a_), global::CommonResources.AcgResources.ID_NUMBEROFTIMESFLASHED);
					this.radInfoFLASHportNumberofTimesFlashed_A8581.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoFLASHportNumberofTimesFlashed_A8581.DataTransferOrder = -1;
					num = (short)74842122;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					this.radInfoFLASHportFLASHcode_A8132 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("韛ﳋￍ﷏\ud9df쿡퓣훥\ud8e7\udae9\udceb\udeed\uddef싱쓳웵죷쫹쳻", a_), this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇菉ꋋ꣍뿏铑飓韕诗鋙곛뇝鋟雡ꋣꫥꧧ맩ꓫ跭鿯雱釳꧵맷싹췻췽㋿", a_), global::CommonResources.AcgResources.ID_FLASHCODE, 29);
					this.radInfoFLASHportFLASHcode_A8132.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoFLASHportFLASHcode_A8132.DataTransferOrder = -1;
					num = (short)867762180;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					this.radInfoFLASHportIButton_A8217 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("韛ﳋﻍ", a_), this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇菉ꋋ꣍뿏铑飓韕诗鋙곛뇝鋟雡귣ꓥ鷧黩飫臭黯귱뗳컵쫷쯹쯻", a_), global::CommonResources.AcgResources.ID_IBUTTON, 12);
					this.radInfoFLASHportIButton_A8217.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoFLASHportIButton_A8217.DataTransferOrder = -1;
					num = (short)1487601669;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_7B:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)964427787;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_9E:
				num = (short)210894860;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_14C:
				if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("雃Ʂ곇菉ꋋ꣍뿏铑飓韕诗鋙곛뇝鋟雡꣣蟥鯧黩맫黭韯胱闳鋵鷷꧹鏻诽狿愁愃夅䤇㈉㼋㘍✏", a_)))
				{
					num = (short)692715533;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_9E;
				IL_134:
				num = (short)590151683;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1CF:
				num = (short)1245380608;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_456:
				num = (short)1631584271;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_326:
			IL_4CC:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("苃諅觇駉蓋뻍뿏ꃑꃓ", a_);
			base.Id = 10111;
			base.UIName = global::CommonResources.AcgResources.ID_FLASHPORT;
			base.DataTransferOrder = 4;
		}

		// Token: 0x0600454F RID: 17743 RVA: 0x004071F0 File Offset: 0x004053F0
		public override void PopulateReferences()
		{
			short num = (short)1862863708;
			short num2 = num;
			num = (short)800263004;
			switch (num2 == num)
			{
			}
			num = (short)420347904;
			short num3 = num;
			num = (short)1603403777;
			if (num != 0)
			{
			}
			num = (short)2079195136;
			if (num != 0)
			{
			}
		}

		// Token: 0x06004550 RID: 17744 RVA: 0x0040729C File Offset: 0x0040549C
		public override void DropReferences()
		{
			short num = (short)1052765546;
			short num2 = num;
			num = (short)1696001386;
			switch (num2 == num)
			{
			}
			num = (short)1517944832;
			short num3 = num;
			num = (short)693043201;
			if (num != 0)
			{
			}
			num = (short)1826684928;
			if (num != 0)
			{
			}
		}

		// Token: 0x06004551 RID: 17745 RVA: 0x00407348 File Offset: 0x00405548
		public override void SetConstraints()
		{
			short num = (short)497885204;
			short num2 = num;
			num = (short)62136340;
			switch (num2 == num)
			{
			}
			num = (short)1239613440;
			short num3 = num;
			num = (short)259915776;
			if (num != 0)
			{
			}
			num = (short)618594305;
			if (num != 0)
			{
			}
			this.radInfoFLASHportFLASHcode_A8132.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoFLASHportIButton_A8217.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoFLASHportLastUpgradeSource_A8387.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoLabtoolLastFLASHKeyDateStampData_A8388.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoFLASHportNumberofTimesFlashed_A8581.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x06004552 RID: 17746 RVA: 0x00407464 File Offset: 0x00405664
		public override void SetupDependencies()
		{
			short num = (short)1105145959;
			short num2 = num;
			num = (short)2086023271;
			switch (num2 == num)
			{
			}
			num = (short)1593114624;
			short num3 = num;
			num = (short)1555169281;
			if (num != 0)
			{
			}
			num = (short)1283784704;
			if (num != 0)
			{
			}
		}

		// Token: 0x1700238A RID: 9098
		// (get) Token: 0x06004553 RID: 17747 RVA: 0x0040750C File Offset: 0x0040570C
		public bool HasDiffs
		{
			get
			{
				short num = (short)959853278;
				short num2 = num;
				num = (short)561722078;
				switch (num2 == num)
				{
				}
				num = (short)1948188672;
				short num3 = num;
				num = (short)1440415744;
				if (num != 0)
				{
				}
				num = (short)748945409;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x1700238B RID: 9099
		// (get) Token: 0x06004554 RID: 17748 RVA: 0x004075BC File Offset: 0x004057BC
		// (set) Token: 0x06004555 RID: 17749 RVA: 0x00407670 File Offset: 0x00405870
		public string RadInfoFLASHportFLASHcode_A8132Value
		{
			get
			{
				short num = (short)817525409;
				short num2 = num;
				num = (short)550072993;
				switch (num2 == num)
				{
				}
				num = (short)955514880;
				short num3 = num;
				num = (short)201195521;
				if (num != 0)
				{
				}
				num = (short)1368129536;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportFLASHcode_A8132.Value;
			}
			set
			{
				short num = (short)1633288193;
				if (num != 0)
				{
				}
				num = (short)1174528586;
				short num2 = num;
				num = (short)214032970;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1992032256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1635516416;
				if (num != 0)
				{
				}
				this.radInfoFLASHportFLASHcode_A8132.Value = value;
			}
		}

		// Token: 0x1700238C RID: 9100
		// (get) Token: 0x06004556 RID: 17750 RVA: 0x00407724 File Offset: 0x00405924
		public global::AcpBusinessLayer.AcpField<string> RadInfoFLASHportFLASHcode_A8132
		{
			get
			{
				short num = (short)1871312914;
				short num2 = num;
				num = (short)1517418514;
				switch (num2 == num)
				{
				}
				num = (short)597098496;
				short num3 = num;
				num = (short)1821835265;
				if (num != 0)
				{
				}
				num = (short)752222208;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportFLASHcode_A8132;
			}
		}

		// Token: 0x1700238D RID: 9101
		// (get) Token: 0x06004557 RID: 17751 RVA: 0x004077D4 File Offset: 0x004059D4
		// (set) Token: 0x06004558 RID: 17752 RVA: 0x00407888 File Offset: 0x00405A88
		public string RadInfoFLASHportFLASHcode_A8132_UIValue
		{
			get
			{
				short num = (short)1650180355;
				short num2 = num;
				num = (short)1497088259;
				switch (num2 == num)
				{
				}
				num = (short)1183383552;
				short num3 = num;
				num = (short)253362177;
				if (num != 0)
				{
				}
				num = (short)57475072;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportFLASHcode_A8132.Value;
			}
			set
			{
				short num = (short)978745169;
				short num2 = num;
				num = (short)672102225;
				switch (num2 == num)
				{
				}
				num = (short)1138032640;
				short num3 = num;
				num = (short)1681391616;
				if (num != 0)
				{
				}
				num = (short)740622337;
				if (num != 0)
				{
				}
				this.radInfoFLASHportFLASHcode_A8132.Value = value;
			}
		}

		// Token: 0x1700238E RID: 9102
		// (get) Token: 0x06004559 RID: 17753 RVA: 0x00407940 File Offset: 0x00405B40
		// (set) Token: 0x0600455A RID: 17754 RVA: 0x004079F4 File Offset: 0x00405BF4
		public bool RadInfoFLASHportFLASHcode_A8132_Applicable
		{
			get
			{
				short num = (short)1030443152;
				short num2 = num;
				num = (short)360075408;
				switch (num2 == num)
				{
				}
				num = (short)929693696;
				short num3 = num;
				num = (short)1785856001;
				if (num != 0)
				{
				}
				num = (short)1558708224;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportFLASHcode_A8132.Applicable;
			}
			set
			{
				short num = (short)1064610597;
				short num2 = num;
				num = (short)888515365;
				switch (num2 == num)
				{
				}
				num = (short)908918784;
				short num3 = num;
				num = (short)1752498177;
				if (num != 0)
				{
				}
				num = (short)1432420352;
				if (num != 0)
				{
				}
				this.radInfoFLASHportFLASHcode_A8132.Applicable = value;
			}
		}

		// Token: 0x1700238F RID: 9103
		// (get) Token: 0x0600455B RID: 17755 RVA: 0x00407AAC File Offset: 0x00405CAC
		// (set) Token: 0x0600455C RID: 17756 RVA: 0x00407B64 File Offset: 0x00405D64
		public bool RadInfoFLASHportFLASHcode_A8132_Valid
		{
			get
			{
				short num = (short)2093630658;
				short num2 = num;
				num = (short)499205314;
				switch (num2 == num)
				{
				}
				num = (short)1851654144;
				short num3 = num;
				num = (short)1575682048;
				if (num != 0)
				{
				}
				num = (short)731709441;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportFLASHcode_A8132.Valid;
			}
			set
			{
				short num = (short)1570864553;
				short num2 = num;
				num = (short)436043177;
				switch (num2 == num)
				{
				}
				num = (short)413663232;
				short num3 = num;
				num = (short)1117978625;
				if (num != 0)
				{
				}
				num = (short)113639424;
				if (num != 0)
				{
				}
				this.radInfoFLASHportFLASHcode_A8132.Valid = value;
			}
		}

		// Token: 0x17002390 RID: 9104
		// (get) Token: 0x0600455D RID: 17757 RVA: 0x00407C1C File Offset: 0x00405E1C
		// (set) Token: 0x0600455E RID: 17758 RVA: 0x00407CD0 File Offset: 0x00405ED0
		public bool RadInfoFLASHportFLASHcode_A8132_Visible
		{
			get
			{
				short num = (short)719817676;
				short num2 = num;
				num = (short)720407500;
				switch (num2 == num)
				{
				}
				num = (short)595853312;
				short num3 = num;
				num = (short)429785089;
				if (num != 0)
				{
				}
				num = (short)22216704;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportFLASHcode_A8132.Visible;
			}
			set
			{
				short num = (short)225408668;
				short num2 = num;
				num = (short)1122268828;
				switch (num2 == num)
				{
				}
				num = (short)2106064896;
				short num3 = num;
				num = (short)1256587265;
				if (num != 0)
				{
				}
				num = (short)151584768;
				if (num != 0)
				{
				}
				this.radInfoFLASHportFLASHcode_A8132.Visible = value;
			}
		}

		// Token: 0x17002391 RID: 9105
		// (get) Token: 0x0600455F RID: 17759 RVA: 0x00407D88 File Offset: 0x00405F88
		// (set) Token: 0x06004560 RID: 17760 RVA: 0x00407E40 File Offset: 0x00406040
		public bool RadInfoFLASHportFLASHcode_A8132_Editable
		{
			get
			{
				short num = (short)1895460326;
				short num2 = num;
				num = (short)464809446;
				switch (num2 == num)
				{
				}
				num = (short)1119354880;
				short num3 = num;
				num = (short)703987713;
				if (num != 0)
				{
				}
				num = (short)68943872;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportFLASHcode_A8132.Editable;
			}
			set
			{
				short num = (short)174547188;
				short num2 = num;
				num = (short)766796020;
				switch (num2 == num)
				{
				}
				num = (short)608960512;
				short num3 = num;
				num = (short)1067843585;
				if (num != 0)
				{
				}
				num = (short)1351155712;
				if (num != 0)
				{
				}
				this.radInfoFLASHportFLASHcode_A8132.Editable = value;
			}
		}

		// Token: 0x17002392 RID: 9106
		// (get) Token: 0x06004561 RID: 17761 RVA: 0x00407EF4 File Offset: 0x004060F4
		internal string RadInfoFLASHportFLASHcode_A8132_UILabel
		{
			get
			{
				short num = (short)460918811;
				short num2 = num;
				num = (short)1094193179;
				switch (num2 == num)
				{
				}
				num = (short)292945920;
				short num3 = num;
				num = (short)988479488;
				if (num != 0)
				{
				}
				num = (short)65536001;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportFLASHcode_A8132.UIName;
			}
		}

		// Token: 0x17002393 RID: 9107
		// (get) Token: 0x06004562 RID: 17762 RVA: 0x00407FA8 File Offset: 0x004061A8
		// (set) Token: 0x06004563 RID: 17763 RVA: 0x0040805C File Offset: 0x0040625C
		internal bool RadInfoFLASHportFLASHcode_A8132_HiddenStatic
		{
			get
			{
				short num = (short)1516700395;
				short num2 = num;
				num = (short)1291453163;
				switch (num2 == num)
				{
				}
				num = (short)964755456;
				short num3 = num;
				num = (short)1397030913;
				if (num != 0)
				{
				}
				num = (short)679477248;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportFLASHcode_A8132.HiddenStatic;
			}
			set
			{
				short num = (short)1169428066;
				short num2 = num;
				num = (short)252644962;
				switch (num2 == num)
				{
				}
				num = (short)825950208;
				short num3 = num;
				num = (short)301006849;
				if (num != 0)
				{
				}
				num = (short)498925568;
				if (num != 0)
				{
				}
				this.radInfoFLASHportFLASHcode_A8132.HiddenStatic = value;
			}
		}

		// Token: 0x17002394 RID: 9108
		// (get) Token: 0x06004564 RID: 17764 RVA: 0x00408114 File Offset: 0x00406314
		// (set) Token: 0x06004565 RID: 17765 RVA: 0x004081CC File Offset: 0x004063CC
		internal bool RadInfoFLASHportFLASHcode_A8132_HiddenDynamic
		{
			get
			{
				short num = (short)1269324392;
				short num2 = num;
				num = (short)1663785576;
				switch (num2 == num)
				{
				}
				num = (short)2112684032;
				short num3 = num;
				num = (short)1288044544;
				if (num != 0)
				{
				}
				num = (short)537460737;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportFLASHcode_A8132.HiddenDynamic;
			}
			set
			{
				short num = (short)1487362338;
				short num2 = num;
				num = (short)190732578;
				switch (num2 == num)
				{
				}
				num = (short)906166272;
				short num3 = num;
				num = (short)2033319937;
				if (num != 0)
				{
				}
				num = (short)371589120;
				if (num != 0)
				{
				}
				this.radInfoFLASHportFLASHcode_A8132.HiddenDynamic = value;
			}
		}

		// Token: 0x17002395 RID: 9109
		// (get) Token: 0x06004566 RID: 17766 RVA: 0x00408284 File Offset: 0x00406484
		public bool RadInfoFLASHportFLASHcode_A8132_HasDiffs
		{
			get
			{
				short num = (short)623379042;
				short num2 = num;
				num = (short)1201144418;
				switch (num2 == num)
				{
				}
				num = (short)230948864;
				short num3 = num;
				num = (short)613613568;
				if (num != 0)
				{
				}
				num = (short)1990000641;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportFLASHcode_A8132._HasDiffs;
			}
		}

		// Token: 0x17002396 RID: 9110
		// (get) Token: 0x06004567 RID: 17767 RVA: 0x00408338 File Offset: 0x00406538
		// (set) Token: 0x06004568 RID: 17768 RVA: 0x004083EC File Offset: 0x004065EC
		public string RadInfoFLASHportIButton_A8217Value
		{
			get
			{
				short num = (short)872832712;
				short num2 = num;
				num = (short)1941987016;
				switch (num2 == num)
				{
				}
				num = (short)783613952;
				short num3 = num;
				num = (short)900202497;
				if (num != 0)
				{
				}
				num = (short)513802240;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportIButton_A8217.Value;
			}
			set
			{
				short num = (short)1970864129;
				if (num != 0)
				{
				}
				num = (short)575509703;
				short num2 = num;
				num = (short)766219463;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1850343424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1568473088;
				if (num != 0)
				{
				}
				this.radInfoFLASHportIButton_A8217.Value = value;
			}
		}

		// Token: 0x17002397 RID: 9111
		// (get) Token: 0x06004569 RID: 17769 RVA: 0x004084A0 File Offset: 0x004066A0
		public global::AcpBusinessLayer.AcpField<string> RadInfoFLASHportIButton_A8217
		{
			get
			{
				short num = (short)1135791322;
				short num2 = num;
				num = (short)1017367770;
				switch (num2 == num)
				{
				}
				num = (short)1770389504;
				short num3 = num;
				num = (short)1092681729;
				if (num != 0)
				{
				}
				num = (short)1924595712;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportIButton_A8217;
			}
		}

		// Token: 0x17002398 RID: 9112
		// (get) Token: 0x0600456A RID: 17770 RVA: 0x00408554 File Offset: 0x00406754
		// (set) Token: 0x0600456B RID: 17771 RVA: 0x00408608 File Offset: 0x00406808
		public string RadInfoFLASHportIButton_A8217_UIValue
		{
			get
			{
				short num = (short)2106207161;
				short num2 = num;
				num = (short)25504697;
				switch (num2 == num)
				{
				}
				num = (short)1746206720;
				short num3 = num;
				num = (short)709951489;
				if (num != 0)
				{
				}
				num = (short)168099840;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportIButton_A8217.Value;
			}
			set
			{
				short num = (short)113727067;
				short num2 = num;
				num = (short)171136603;
				switch (num2 == num)
				{
				}
				num = (short)530382848;
				short num3 = num;
				num = (short)1501888512;
				if (num != 0)
				{
				}
				num = (short)975634433;
				if (num != 0)
				{
				}
				this.radInfoFLASHportIButton_A8217.Value = value;
			}
		}

		// Token: 0x17002399 RID: 9113
		// (get) Token: 0x0600456C RID: 17772 RVA: 0x004086BC File Offset: 0x004068BC
		// (set) Token: 0x0600456D RID: 17773 RVA: 0x00408770 File Offset: 0x00406970
		public bool RadInfoFLASHportIButton_A8217_Applicable
		{
			get
			{
				short num = (short)1012072449;
				if (num != 0)
				{
				}
				num = (short)700417134;
				short num2 = num;
				num = (short)1392018542;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1734541312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1852375040;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportIButton_A8217.Applicable;
			}
			set
			{
				short num = (short)40348410;
				short num2 = num;
				num = (short)94677754;
				switch (num2 == num)
				{
				}
				num = (short)174718976;
				short num3 = num;
				num = (short)490012672;
				if (num != 0)
				{
				}
				num = (short)12320769;
				if (num != 0)
				{
				}
				this.radInfoFLASHportIButton_A8217.Applicable = value;
			}
		}

		// Token: 0x1700239A RID: 9114
		// (get) Token: 0x0600456E RID: 17774 RVA: 0x00408824 File Offset: 0x00406A24
		// (set) Token: 0x0600456F RID: 17775 RVA: 0x004088D8 File Offset: 0x00406AD8
		public bool RadInfoFLASHportIButton_A8217_Valid
		{
			get
			{
				short num = (short)2040914368;
				short num2 = num;
				num = (short)176349632;
				switch (num2 == num)
				{
				}
				num = (short)1161953280;
				short num3 = num;
				num = (short)624361473;
				if (num != 0)
				{
				}
				num = (short)35717120;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportIButton_A8217.Valid;
			}
			set
			{
				short num = (short)1423979270;
				short num2 = num;
				num = (short)374485766;
				switch (num2 == num)
				{
				}
				num = (short)1888485376;
				short num3 = num;
				num = (short)1409941504;
				if (num != 0)
				{
				}
				num = (short)1187446785;
				if (num != 0)
				{
				}
				this.radInfoFLASHportIButton_A8217.Valid = value;
			}
		}

		// Token: 0x1700239B RID: 9115
		// (get) Token: 0x06004570 RID: 17776 RVA: 0x00408990 File Offset: 0x00406B90
		// (set) Token: 0x06004571 RID: 17777 RVA: 0x00408A48 File Offset: 0x00406C48
		public bool RadInfoFLASHportIButton_A8217_Visible
		{
			get
			{
				short num = (short)83165185;
				if (num != 0)
				{
				}
				num = (short)1814223109;
				short num2 = num;
				num = (short)14997765;
				switch (num2 == num)
				{
				default:
				{
					num = (short)359858176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)660144128;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportIButton_A8217.Visible;
			}
			set
			{
				short num = (short)910453254;
				short num2 = num;
				num = (short)433220102;
				switch (num2 == num)
				{
				}
				num = (short)417923072;
				short num3 = num;
				num = (short)1684602881;
				if (num != 0)
				{
				}
				num = (short)1131151360;
				if (num != 0)
				{
				}
				this.radInfoFLASHportIButton_A8217.Visible = value;
			}
		}

		// Token: 0x1700239C RID: 9116
		// (get) Token: 0x06004572 RID: 17778 RVA: 0x00408B00 File Offset: 0x00406D00
		// (set) Token: 0x06004573 RID: 17779 RVA: 0x00408BB4 File Offset: 0x00406DB4
		public bool RadInfoFLASHportIButton_A8217_Editable
		{
			get
			{
				short num = (short)501692985;
				short num2 = num;
				num = (short)1728461369;
				switch (num2 == num)
				{
				}
				num = (short)1727332352;
				short num3 = num;
				num = (short)1588920321;
				if (num != 0)
				{
				}
				num = (short)1948254208;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportIButton_A8217.Editable;
			}
			set
			{
				short num = (short)1829261806;
				short num2 = num;
				num = (short)1999196654;
				switch (num2 == num)
				{
				}
				num = (short)614858752;
				short num3 = num;
				num = (short)308871169;
				if (num != 0)
				{
				}
				num = (short)365428736;
				if (num != 0)
				{
				}
				this.radInfoFLASHportIButton_A8217.Editable = value;
			}
		}

		// Token: 0x1700239D RID: 9117
		// (get) Token: 0x06004574 RID: 17780 RVA: 0x00408C6C File Offset: 0x00406E6C
		internal string RadInfoFLASHportIButton_A8217_UILabel
		{
			get
			{
				short num = (short)271908865;
				if (num != 0)
				{
				}
				num = (short)458261889;
				short num2 = num;
				num = (short)2017166721;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1274740736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1309868032;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportIButton_A8217.UIName;
			}
		}

		// Token: 0x1700239E RID: 9118
		// (get) Token: 0x06004575 RID: 17781 RVA: 0x00408D20 File Offset: 0x00406F20
		// (set) Token: 0x06004576 RID: 17782 RVA: 0x00408DD4 File Offset: 0x00406FD4
		internal bool RadInfoFLASHportIButton_A8217_HiddenStatic
		{
			get
			{
				short num = (short)2119697840;
				short num2 = num;
				num = (short)2045576624;
				switch (num2 == num)
				{
				}
				num = (short)1533935616;
				short num3 = num;
				num = (short)1176109056;
				if (num != 0)
				{
				}
				num = (short)632029185;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportIButton_A8217.HiddenStatic;
			}
			set
			{
				short num = (short)56666864;
				short num2 = num;
				num = (short)2077076208;
				switch (num2 == num)
				{
				}
				num = (short)1956380672;
				short num3 = num;
				num = (short)345636865;
				if (num != 0)
				{
				}
				num = (short)583991296;
				if (num != 0)
				{
				}
				this.radInfoFLASHportIButton_A8217.HiddenStatic = value;
			}
		}

		// Token: 0x1700239F RID: 9119
		// (get) Token: 0x06004577 RID: 17783 RVA: 0x00408E8C File Offset: 0x0040708C
		// (set) Token: 0x06004578 RID: 17784 RVA: 0x00408F40 File Offset: 0x00407140
		internal bool RadInfoFLASHportIButton_A8217_HiddenDynamic
		{
			get
			{
				short num = (short)629909781;
				short num2 = num;
				num = (short)671852821;
				switch (num2 == num)
				{
				}
				num = (short)1630142464;
				short num3 = num;
				num = (short)1846149121;
				if (num != 0)
				{
				}
				num = (short)1676279808;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportIButton_A8217.HiddenDynamic;
			}
			set
			{
				short num = (short)881168864;
				short num2 = num;
				num = (short)1114018272;
				switch (num2 == num)
				{
				}
				num = (short)399376384;
				short num3 = num;
				num = (short)1189216257;
				if (num != 0)
				{
				}
				num = (short)1287585792;
				if (num != 0)
				{
				}
				this.radInfoFLASHportIButton_A8217.HiddenDynamic = value;
			}
		}

		// Token: 0x170023A0 RID: 9120
		// (get) Token: 0x06004579 RID: 17785 RVA: 0x00408FF4 File Offset: 0x004071F4
		public bool RadInfoFLASHportIButton_A8217_HasDiffs
		{
			get
			{
				short num = (short)1471975325;
				short num2 = num;
				num = (short)1244827549;
				switch (num2 == num)
				{
				}
				num = (short)2082668544;
				short num3 = num;
				num = (short)1551368192;
				if (num != 0)
				{
				}
				num = (short)1605435393;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportIButton_A8217._HasDiffs;
			}
		}

		// Token: 0x170023A1 RID: 9121
		// (get) Token: 0x0600457A RID: 17786 RVA: 0x004090A8 File Offset: 0x004072A8
		// (set) Token: 0x0600457B RID: 17787 RVA: 0x0040915C File Offset: 0x0040735C
		public int RadInfoFLASHportLastUpgradeSource_A8387Value
		{
			get
			{
				short num = (short)2120542205;
				short num2 = num;
				num = (short)1892345853;
				switch (num2 == num)
				{
				}
				num = (short)762445824;
				short num3 = num;
				num = (short)1262288897;
				if (num != 0)
				{
				}
				num = (short)329580544;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportLastUpgradeSource_A8387.Value;
			}
			set
			{
				short num = (short)1505673247;
				short num2 = num;
				num = (short)810860575;
				switch (num2 == num)
				{
				}
				num = (short)820314112;
				short num3 = num;
				num = (short)1043202048;
				if (num != 0)
				{
				}
				num = (short)1947598849;
				if (num != 0)
				{
				}
				this.radInfoFLASHportLastUpgradeSource_A8387.Value = value;
			}
		}

		// Token: 0x170023A2 RID: 9122
		// (get) Token: 0x0600457C RID: 17788 RVA: 0x00409210 File Offset: 0x00407410
		public global::AcpBusinessLayer.AcpRangeField<int, string> RadInfoFLASHportLastUpgradeSource_A8387
		{
			get
			{
				short num = (short)233368394;
				short num2 = num;
				num = (short)366668618;
				switch (num2 == num)
				{
				}
				num = (short)1744240640;
				short num3 = num;
				num = (short)2050883584;
				if (num != 0)
				{
				}
				num = (short)2037645313;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportLastUpgradeSource_A8387;
			}
		}

		// Token: 0x170023A3 RID: 9123
		// (get) Token: 0x0600457D RID: 17789 RVA: 0x004092C0 File Offset: 0x004074C0
		// (set) Token: 0x0600457E RID: 17790 RVA: 0x00409374 File Offset: 0x00407574
		public string RadInfoFLASHportLastUpgradeSource_A8387_UIValue
		{
			get
			{
				short num = (short)1589197091;
				short num2 = num;
				num = (short)1454913827;
				switch (num2 == num)
				{
				}
				num = (short)2114650112;
				short num3 = num;
				num = (short)1035993089;
				if (num != 0)
				{
				}
				num = (short)806158336;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportLastUpgradeSource_A8387.UIValue;
			}
			set
			{
				short num = (short)711312827;
				short num2 = num;
				num = (short)373671355;
				switch (num2 == num)
				{
				}
				num = (short)373424128;
				short num3 = num;
				num = (short)1843462144;
				if (num != 0)
				{
				}
				num = (short)1178140673;
				if (num != 0)
				{
				}
				this.radInfoFLASHportLastUpgradeSource_A8387.UIValue = value;
			}
		}

		// Token: 0x170023A4 RID: 9124
		// (get) Token: 0x0600457F RID: 17791 RVA: 0x00409428 File Offset: 0x00407628
		// (set) Token: 0x06004580 RID: 17792 RVA: 0x004094DC File Offset: 0x004076DC
		internal int RadInfoFLASHportLastUpgradeSource_A8387Min
		{
			get
			{
				short num = (short)488446173;
				short num2 = num;
				num = (short)1978144989;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2001862656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2039283713;
				if (num != 0)
				{
				}
				num = (short)797769728;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportLastUpgradeSource_A8387.Min;
			}
			set
			{
				short num = (short)10382997;
				short num2 = num;
				num = (short)1996517013;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2021064704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)227409920;
				if (num != 0)
				{
				}
				num = (short)370999297;
				if (num != 0)
				{
				}
				this.radInfoFLASHportLastUpgradeSource_A8387.Min = value;
			}
		}

		// Token: 0x170023A5 RID: 9125
		// (get) Token: 0x06004581 RID: 17793 RVA: 0x00409594 File Offset: 0x00407794
		// (set) Token: 0x06004582 RID: 17794 RVA: 0x00409648 File Offset: 0x00407848
		internal int RadInfoFLASHportLastUpgradeSource_A8387Max
		{
			get
			{
				short num = (short)773718017;
				if (num != 0)
				{
				}
				num = (short)1414201344;
				short num2 = num;
				num = (short)1255747880;
				short num3 = num;
				num = (short)1137258792;
				switch (num3 == num)
				{
				}
				num = (short)995229696;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportLastUpgradeSource_A8387.Max;
			}
			set
			{
				short num = (short)1154088961;
				if (num != 0)
				{
				}
				num = (short)1018167296;
				short num2 = num;
				num = (short)131540680;
				short num3 = num;
				num = (short)1624385224;
				switch (num3 == num)
				{
				}
				num = (short)557711360;
				if (num != 0)
				{
				}
				this.radInfoFLASHportLastUpgradeSource_A8387.Max = value;
			}
		}

		// Token: 0x170023A6 RID: 9126
		// (get) Token: 0x06004583 RID: 17795 RVA: 0x00409700 File Offset: 0x00407900
		// (set) Token: 0x06004584 RID: 17796 RVA: 0x004097B8 File Offset: 0x004079B8
		internal int RadInfoFLASHportLastUpgradeSource_A8387Step
		{
			get
			{
				short num = (short)1562378241;
				if (num != 0)
				{
				}
				num = (short)446300160;
				short num2 = num;
				num = (short)1982995257;
				short num3 = num;
				num = (short)1274551097;
				switch (num3 == num)
				{
				}
				num = (short)1169489920;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportLastUpgradeSource_A8387.StepSize;
			}
			set
			{
				short num = (short)1971717499;
				short num2 = num;
				num = (short)1662059899;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2003107840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1356529664;
				if (num != 0)
				{
				}
				num = (short)903544833;
				if (num != 0)
				{
				}
				this.radInfoFLASHportLastUpgradeSource_A8387.StepSize = value;
			}
		}

		// Token: 0x170023A7 RID: 9127
		// (get) Token: 0x06004585 RID: 17797 RVA: 0x0040986C File Offset: 0x00407A6C
		// (set) Token: 0x06004586 RID: 17798 RVA: 0x00409920 File Offset: 0x00407B20
		public bool RadInfoFLASHportLastUpgradeSource_A8387_Applicable
		{
			get
			{
				short num = (short)1349260059;
				short num2 = num;
				num = (short)598741787;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1329659904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)506134529;
				if (num != 0)
				{
				}
				num = (short)1157562368;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportLastUpgradeSource_A8387.Applicable;
			}
			set
			{
				short num = (short)1671672052;
				short num2 = num;
				num = (short)1096003828;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1733165056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1400832001;
				if (num != 0)
				{
				}
				num = (short)1042808832;
				if (num != 0)
				{
				}
				this.radInfoFLASHportLastUpgradeSource_A8387.Applicable = value;
			}
		}

		// Token: 0x170023A8 RID: 9128
		// (get) Token: 0x06004587 RID: 17799 RVA: 0x004099D4 File Offset: 0x00407BD4
		// (set) Token: 0x06004588 RID: 17800 RVA: 0x00409A88 File Offset: 0x00407C88
		public bool RadInfoFLASHportLastUpgradeSource_A8387_Valid
		{
			get
			{
				short num = (short)567710792;
				short num2 = num;
				num = (short)513643592;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1064042496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)541130752;
				if (num != 0)
				{
				}
				num = (short)1001324545;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportLastUpgradeSource_A8387.Valid;
			}
			set
			{
				short num = (short)1634016689;
				short num2 = num;
				num = (short)1068572081;
				switch (num2 == num)
				{
				default:
				{
					num = (short)133431296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)664469504;
				if (num != 0)
				{
				}
				num = (short)555155457;
				if (num != 0)
				{
				}
				this.radInfoFLASHportLastUpgradeSource_A8387.Valid = value;
			}
		}

		// Token: 0x170023A9 RID: 9129
		// (get) Token: 0x06004589 RID: 17801 RVA: 0x00409B40 File Offset: 0x00407D40
		// (set) Token: 0x0600458A RID: 17802 RVA: 0x00409BF8 File Offset: 0x00407DF8
		public bool RadInfoFLASHportLastUpgradeSource_A8387_Visible
		{
			get
			{
				short num = (short)503239071;
				short num2 = num;
				num = (short)556978591;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1332674560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)680919041;
				if (num != 0)
				{
				}
				num = (short)982974464;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportLastUpgradeSource_A8387.Visible;
			}
			set
			{
				short num = (short)1014013463;
				short num2 = num;
				num = (short)1807785495;
				switch (num2 == num)
				{
				default:
				{
					num = (short)863043584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)380960768;
				if (num != 0)
				{
				}
				num = (short)1094320129;
				if (num != 0)
				{
				}
				this.radInfoFLASHportLastUpgradeSource_A8387.Visible = value;
			}
		}

		// Token: 0x170023AA RID: 9130
		// (get) Token: 0x0600458B RID: 17803 RVA: 0x00409CB0 File Offset: 0x00407EB0
		// (set) Token: 0x0600458C RID: 17804 RVA: 0x00409D64 File Offset: 0x00407F64
		public bool RadInfoFLASHportLastUpgradeSource_A8387_Editable
		{
			get
			{
				short num = (short)1425909191;
				short num2 = num;
				num = (short)1629922759;
				switch (num2 == num)
				{
				default:
				{
					num = (short)187170816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)688324609;
				if (num != 0)
				{
				}
				num = (short)338952192;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportLastUpgradeSource_A8387.Editable;
			}
			set
			{
				short num = (short)1341765265;
				short num2 = num;
				num = (short)1815918225;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1326120960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)945881089;
				if (num != 0)
				{
				}
				num = (short)512819200;
				if (num != 0)
				{
				}
				this.radInfoFLASHportLastUpgradeSource_A8387.Editable = value;
			}
		}

		// Token: 0x170023AB RID: 9131
		// (get) Token: 0x0600458D RID: 17805 RVA: 0x00409E1C File Offset: 0x0040801C
		internal string RadInfoFLASHportLastUpgradeSource_A8387_UILabel
		{
			get
			{
				short num = (short)649765302;
				short num2 = num;
				num = (short)1821352374;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1196556288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)476774401;
				if (num != 0)
				{
				}
				num = (short)1697513472;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportLastUpgradeSource_A8387.UIName;
			}
		}

		// Token: 0x170023AC RID: 9132
		// (get) Token: 0x0600458E RID: 17806 RVA: 0x00409ED4 File Offset: 0x004080D4
		// (set) Token: 0x0600458F RID: 17807 RVA: 0x00409F8C File Offset: 0x0040818C
		internal bool RadInfoFLASHportLastUpgradeSource_A8387_HiddenStatic
		{
			get
			{
				short num = (short)376585364;
				short num2 = num;
				num = (short)1035549844;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1344405504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)889978881;
				if (num != 0)
				{
				}
				num = (short)1013579776;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportLastUpgradeSource_A8387.HiddenStatic;
			}
			set
			{
				short num = (short)622120023;
				short num2 = num;
				num = (short)1860750423;
				switch (num2 == num)
				{
				default:
				{
					num = (short)464781312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1770127360;
				if (num != 0)
				{
				}
				num = (short)1088225281;
				if (num != 0)
				{
				}
				this.radInfoFLASHportLastUpgradeSource_A8387.HiddenStatic = value;
			}
		}

		// Token: 0x170023AD RID: 9133
		// (get) Token: 0x06004590 RID: 17808 RVA: 0x0040A040 File Offset: 0x00408240
		// (set) Token: 0x06004591 RID: 17809 RVA: 0x0040A0F8 File Offset: 0x004082F8
		internal bool RadInfoFLASHportLastUpgradeSource_A8387_HiddenDynamic
		{
			get
			{
				short num = (short)1964338895;
				short num2 = num;
				num = (short)21655247;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1406074880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1421082625;
				if (num != 0)
				{
				}
				num = (short)34865152;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportLastUpgradeSource_A8387.HiddenDynamic;
			}
			set
			{
				short num = (short)1047361567;
				short num2 = num;
				num = (short)1661564959;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1764098048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)206110721;
				if (num != 0)
				{
				}
				num = (short)1602158592;
				if (num != 0)
				{
				}
				this.radInfoFLASHportLastUpgradeSource_A8387.HiddenDynamic = value;
			}
		}

		// Token: 0x170023AE RID: 9134
		// (get) Token: 0x06004592 RID: 17810 RVA: 0x0040A1AC File Offset: 0x004083AC
		public bool RadInfoFLASHportLastUpgradeSource_A8387_HasDiffs
		{
			get
			{
				short num = (short)1742826428;
				short num2 = num;
				num = (short)1099262908;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1681588224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1132331009;
				if (num != 0)
				{
				}
				num = (short)703660032;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportLastUpgradeSource_A8387._HasDiffs;
			}
		}

		// Token: 0x170023AF RID: 9135
		// (get) Token: 0x06004593 RID: 17811 RVA: 0x0040A25C File Offset: 0x0040845C
		// (set) Token: 0x06004594 RID: 17812 RVA: 0x0040A310 File Offset: 0x00408510
		public long RadInfoLabtoolLastFLASHKeyDateStampData_A8388Value
		{
			get
			{
				short num = (short)1792218018;
				short num2 = num;
				num = (short)280302498;
				switch (num2 == num)
				{
				default:
				{
					num = (short)899219456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)615710720;
				if (num != 0)
				{
				}
				num = (short)2066939905;
				if (num != 0)
				{
				}
				return this.radInfoLabtoolLastFLASHKeyDateStampData_A8388.Value;
			}
			set
			{
				short num = (short)557863314;
				short num2 = num;
				num = (short)127488402;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1657077760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1866727425;
				if (num != 0)
				{
				}
				num = (short)237568000;
				if (num != 0)
				{
				}
				this.radInfoLabtoolLastFLASHKeyDateStampData_A8388.Value = value;
			}
		}

		// Token: 0x170023B0 RID: 9136
		// (get) Token: 0x06004595 RID: 17813 RVA: 0x0040A3C4 File Offset: 0x004085C4
		public global::AcpBusinessLayer.AcpFieldX<long, string> RadInfoLabtoolLastFLASHKeyDateStampData_A8388
		{
			get
			{
				short num = (short)220790785;
				if (num != 0)
				{
				}
				num = (short)687603712;
				short num2 = num;
				num = (short)824452270;
				short num3 = num;
				num = (short)1576412334;
				switch (num3 == num)
				{
				}
				num = (short)184942592;
				if (num != 0)
				{
				}
				return this.radInfoLabtoolLastFLASHKeyDateStampData_A8388;
			}
		}

		// Token: 0x170023B1 RID: 9137
		// (get) Token: 0x06004596 RID: 17814 RVA: 0x0040A478 File Offset: 0x00408678
		// (set) Token: 0x06004597 RID: 17815 RVA: 0x0040A530 File Offset: 0x00408730
		public string RadInfoLabtoolLastFLASHKeyDateStampData_A8388_UIValue
		{
			get
			{
				short num = (short)443017316;
				short num2 = num;
				num = (short)2127816804;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1307967488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1834024961;
				if (num != 0)
				{
				}
				num = (short)130744320;
				if (num != 0)
				{
				}
				return this.radInfoLabtoolLastFLASHKeyDateStampData_A8388.UIValue;
			}
			set
			{
				short num = (short)875060035;
				short num2 = num;
				num = (short)452549443;
				switch (num2 == num)
				{
				default:
				{
					num = (short)103088128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)848953345;
				if (num != 0)
				{
				}
				num = (short)1020461056;
				if (num != 0)
				{
				}
				this.radInfoLabtoolLastFLASHKeyDateStampData_A8388.UIValue = value;
			}
		}

		// Token: 0x170023B2 RID: 9138
		// (get) Token: 0x06004598 RID: 17816 RVA: 0x0040A5E4 File Offset: 0x004087E4
		// (set) Token: 0x06004599 RID: 17817 RVA: 0x0040A698 File Offset: 0x00408898
		public bool RadInfoLabtoolLastFLASHKeyDateStampData_A8388_Applicable
		{
			get
			{
				short num = (short)737174826;
				short num2 = num;
				num = (short)421291306;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1082982400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1289486337;
				if (num != 0)
				{
				}
				num = (short)1755643904;
				if (num != 0)
				{
				}
				return this.radInfoLabtoolLastFLASHKeyDateStampData_A8388.Applicable;
			}
			set
			{
				short num = (short)204865537;
				if (num != 0)
				{
				}
				num = (short)638713856;
				short num2 = num;
				num = (short)1630230997;
				short num3 = num;
				num = (short)1091852757;
				switch (num3 == num)
				{
				}
				num = (short)445382656;
				if (num != 0)
				{
				}
				this.radInfoLabtoolLastFLASHKeyDateStampData_A8388.Applicable = value;
			}
		}

		// Token: 0x170023B3 RID: 9139
		// (get) Token: 0x0600459A RID: 17818 RVA: 0x0040A74C File Offset: 0x0040894C
		// (set) Token: 0x0600459B RID: 17819 RVA: 0x0040A800 File Offset: 0x00408A00
		public bool RadInfoLabtoolLastFLASHKeyDateStampData_A8388_Valid
		{
			get
			{
				short num = (short)269450369;
				short num2 = num;
				num = (short)581008513;
				switch (num2 == num)
				{
				default:
				{
					num = (short)470351872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1254293504;
				if (num != 0)
				{
				}
				num = (short)1609957377;
				if (num != 0)
				{
				}
				return this.radInfoLabtoolLastFLASHKeyDateStampData_A8388.Valid;
			}
			set
			{
				short num = (short)2090008577;
				if (num != 0)
				{
				}
				num = (short)469762048;
				short num2 = num;
				num = (short)112315083;
				short num3 = num;
				num = (short)1391971019;
				switch (num3 == num)
				{
				}
				num = (short)329842688;
				if (num != 0)
				{
				}
				this.radInfoLabtoolLastFLASHKeyDateStampData_A8388.Valid = value;
			}
		}

		// Token: 0x170023B4 RID: 9140
		// (get) Token: 0x0600459C RID: 17820 RVA: 0x0040A8B4 File Offset: 0x00408AB4
		// (set) Token: 0x0600459D RID: 17821 RVA: 0x0040A968 File Offset: 0x00408B68
		public bool RadInfoLabtoolLastFLASHKeyDateStampData_A8388_Visible
		{
			get
			{
				short num = (short)309817636;
				short num2 = num;
				num = (short)1396273444;
				switch (num2 == num)
				{
				default:
				{
					num = (short)881524736;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)484835328;
				if (num != 0)
				{
				}
				num = (short)649265153;
				if (num != 0)
				{
				}
				return this.radInfoLabtoolLastFLASHKeyDateStampData_A8388.Visible;
			}
			set
			{
				short num = (short)261374530;
				short num2 = num;
				num = (short)1517961794;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1929117696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)334168064;
				if (num != 0)
				{
				}
				num = (short)76611585;
				if (num != 0)
				{
				}
				this.radInfoLabtoolLastFLASHKeyDateStampData_A8388.Visible = value;
			}
		}

		// Token: 0x170023B5 RID: 9141
		// (get) Token: 0x0600459E RID: 17822 RVA: 0x0040AA1C File Offset: 0x00408C1C
		// (set) Token: 0x0600459F RID: 17823 RVA: 0x0040AAD4 File Offset: 0x00408CD4
		public bool RadInfoLabtoolLastFLASHKeyDateStampData_A8388_Editable
		{
			get
			{
				short num = (short)2082829181;
				short num2 = num;
				num = (short)830239613;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1282211840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)348717056;
				if (num != 0)
				{
				}
				num = (short)2045771777;
				if (num != 0)
				{
				}
				return this.radInfoLabtoolLastFLASHKeyDateStampData_A8388.Editable;
			}
			set
			{
				short num = (short)140401572;
				short num2 = num;
				num = (short)934697892;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1587609600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)825556992;
				if (num != 0)
				{
				}
				num = (short)507379713;
				if (num != 0)
				{
				}
				this.radInfoLabtoolLastFLASHKeyDateStampData_A8388.Editable = value;
			}
		}

		// Token: 0x170023B6 RID: 9142
		// (get) Token: 0x060045A0 RID: 17824 RVA: 0x0040AB8C File Offset: 0x00408D8C
		internal string RadInfoLabtoolLastFLASHKeyDateStampData_A8388_UILabel
		{
			get
			{
				short num = (short)38995743;
				short num2 = num;
				num = (short)1989609247;
				switch (num2 == num)
				{
				default:
				{
					num = (short)817496064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1438121985;
				if (num != 0)
				{
				}
				num = (short)1784414208;
				if (num != 0)
				{
				}
				return this.radInfoLabtoolLastFLASHKeyDateStampData_A8388.UIName;
			}
		}

		// Token: 0x170023B7 RID: 9143
		// (get) Token: 0x060045A1 RID: 17825 RVA: 0x0040AC3C File Offset: 0x00408E3C
		// (set) Token: 0x060045A2 RID: 17826 RVA: 0x0040ACF4 File Offset: 0x00408EF4
		internal bool RadInfoLabtoolLastFLASHKeyDateStampData_A8388_HiddenStatic
		{
			get
			{
				short num = (short)188945115;
				short num2 = num;
				num = (short)5903067;
				switch (num2 == num)
				{
				default:
				{
					num = (short)824967168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2010382337;
				if (num != 0)
				{
				}
				num = (short)829816832;
				if (num != 0)
				{
				}
				return this.radInfoLabtoolLastFLASHKeyDateStampData_A8388.HiddenStatic;
			}
			set
			{
				short num = (short)275972097;
				if (num != 0)
				{
				}
				num = (short)1026424832;
				short num2 = num;
				num = (short)1083303878;
				short num3 = num;
				num = (short)254207942;
				switch (num3 == num)
				{
				}
				num = (short)784007168;
				if (num != 0)
				{
				}
				this.radInfoLabtoolLastFLASHKeyDateStampData_A8388.HiddenStatic = value;
			}
		}

		// Token: 0x170023B8 RID: 9144
		// (get) Token: 0x060045A3 RID: 17827 RVA: 0x0040ADA8 File Offset: 0x00408FA8
		// (set) Token: 0x060045A4 RID: 17828 RVA: 0x0040AE5C File Offset: 0x0040905C
		internal bool RadInfoLabtoolLastFLASHKeyDateStampData_A8388_HiddenDynamic
		{
			get
			{
				short num = (short)228086598;
				short num2 = num;
				num = (short)671503174;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1621164032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)505806848;
				if (num != 0)
				{
				}
				num = (short)1559887873;
				if (num != 0)
				{
				}
				return this.radInfoLabtoolLastFLASHKeyDateStampData_A8388.HiddenDynamic;
			}
			set
			{
				short num = (short)1605076017;
				short num2 = num;
				num = (short)1356235825;
				switch (num2 == num)
				{
				default:
				{
					num = (short)14942208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)200474624;
				if (num != 0)
				{
				}
				num = (short)1797586945;
				if (num != 0)
				{
				}
				this.radInfoLabtoolLastFLASHKeyDateStampData_A8388.HiddenDynamic = value;
			}
		}

		// Token: 0x170023B9 RID: 9145
		// (get) Token: 0x060045A5 RID: 17829 RVA: 0x0040AF10 File Offset: 0x00409110
		public bool RadInfoLabtoolLastFLASHKeyDateStampData_A8388_HasDiffs
		{
			get
			{
				short num = (short)1252574855;
				short num2 = num;
				num = (short)1785775751;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2002190336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)735969281;
				if (num != 0)
				{
				}
				num = (short)1322385408;
				if (num != 0)
				{
				}
				return this.radInfoLabtoolLastFLASHKeyDateStampData_A8388._HasDiffs;
			}
		}

		// Token: 0x170023BA RID: 9146
		// (get) Token: 0x060045A6 RID: 17830 RVA: 0x0040AFC4 File Offset: 0x004091C4
		// (set) Token: 0x060045A7 RID: 17831 RVA: 0x0040B078 File Offset: 0x00409278
		public int RadInfoFLASHportNumberofTimesFlashed_A8581Value
		{
			get
			{
				short num = (short)477179274;
				short num2 = num;
				num = (short)1703882122;
				switch (num2 == num)
				{
				default:
				{
					num = (short)282329088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1106706432;
				if (num != 0)
				{
				}
				num = (short)88342529;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportNumberofTimesFlashed_A8581.Value;
			}
			set
			{
				short num = (short)499828201;
				short num2 = num;
				num = (short)1014416873;
				switch (num2 == num)
				{
				default:
				{
					num = (short)941031424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)252444673;
				if (num != 0)
				{
				}
				num = (short)1391591424;
				if (num != 0)
				{
				}
				this.radInfoFLASHportNumberofTimesFlashed_A8581.Value = value;
			}
		}

		// Token: 0x170023BB RID: 9147
		// (get) Token: 0x060045A8 RID: 17832 RVA: 0x0040B130 File Offset: 0x00409330
		public global::AcpBusinessLayer.AcpField<int> RadInfoFLASHportNumberofTimesFlashed_A8581
		{
			get
			{
				short num = (short)87425025;
				if (num != 0)
				{
				}
				num = (short)1468334080;
				short num2 = num;
				num = (short)1859107090;
				short num3 = num;
				num = (short)850049298;
				switch (num3 == num)
				{
				}
				num = (short)1196687360;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportNumberofTimesFlashed_A8581;
			}
		}

		// Token: 0x170023BC RID: 9148
		// (get) Token: 0x060045A9 RID: 17833 RVA: 0x0040B1DC File Offset: 0x004093DC
		// (set) Token: 0x060045AA RID: 17834 RVA: 0x0040B294 File Offset: 0x00409494
		public int RadInfoFLASHportNumberofTimesFlashed_A8581_UIValue
		{
			get
			{
				short num = (short)2006689265;
				short num2 = num;
				num = (short)898672113;
				switch (num2 == num)
				{
				default:
				{
					num = (short)460062720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1794506752;
				if (num != 0)
				{
				}
				num = (short)700579841;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportNumberofTimesFlashed_A8581.Value;
			}
			set
			{
				short num = (short)331363388;
				short num2 = num;
				num = (short)775107644;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1105395712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)142671873;
				if (num != 0)
				{
				}
				num = (short)721158144;
				if (num != 0)
				{
				}
				this.radInfoFLASHportNumberofTimesFlashed_A8581.Value = value;
			}
		}

		// Token: 0x170023BD RID: 9149
		// (get) Token: 0x060045AB RID: 17835 RVA: 0x0040B34C File Offset: 0x0040954C
		// (set) Token: 0x060045AC RID: 17836 RVA: 0x0040B400 File Offset: 0x00409600
		public bool RadInfoFLASHportNumberofTimesFlashed_A8581_Applicable
		{
			get
			{
				short num = (short)2113057762;
				short num2 = num;
				num = (short)1502720994;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2010906624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1495400449;
				if (num != 0)
				{
				}
				num = (short)1887371264;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportNumberofTimesFlashed_A8581.Applicable;
			}
			set
			{
				short num = (short)873686937;
				short num2 = num;
				num = (short)107571097;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2062548992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2136932353;
				if (num != 0)
				{
				}
				num = (short)554827776;
				if (num != 0)
				{
				}
				this.radInfoFLASHportNumberofTimesFlashed_A8581.Applicable = value;
			}
		}

		// Token: 0x170023BE RID: 9150
		// (get) Token: 0x060045AD RID: 17837 RVA: 0x0040B4B8 File Offset: 0x004096B8
		// (set) Token: 0x060045AE RID: 17838 RVA: 0x0040B570 File Offset: 0x00409770
		public bool RadInfoFLASHportNumberofTimesFlashed_A8581_Valid
		{
			get
			{
				short num = (short)1886782761;
				short num2 = num;
				num = (short)558892329;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2025979904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1554120705;
				if (num != 0)
				{
				}
				num = (short)1606287360;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportNumberofTimesFlashed_A8581.Valid;
			}
			set
			{
				short num = (short)512422532;
				short num2 = num;
				num = (short)426963588;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2140602368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1962213376;
				if (num != 0)
				{
				}
				num = (short)1880752129;
				if (num != 0)
				{
				}
				this.radInfoFLASHportNumberofTimesFlashed_A8581.Valid = value;
			}
		}

		// Token: 0x170023BF RID: 9151
		// (get) Token: 0x060045AF RID: 17839 RVA: 0x0040B628 File Offset: 0x00409828
		// (set) Token: 0x060045B0 RID: 17840 RVA: 0x0040B6D8 File Offset: 0x004098D8
		public bool RadInfoFLASHportNumberofTimesFlashed_A8581_Visible
		{
			get
			{
				short num = (short)609153065;
				short num2 = num;
				num = (short)1275916329;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2146369536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)566296577;
				if (num != 0)
				{
				}
				num = (short)1134493696;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportNumberofTimesFlashed_A8581.Visible;
			}
			set
			{
				short num = (short)1003311880;
				short num2 = num;
				num = (short)2099663624;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1643118592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1630535681;
				if (num != 0)
				{
				}
				num = (short)927858688;
				if (num != 0)
				{
				}
				this.radInfoFLASHportNumberofTimesFlashed_A8581.Visible = value;
			}
		}

		// Token: 0x170023C0 RID: 9152
		// (get) Token: 0x060045B1 RID: 17841 RVA: 0x0040B790 File Offset: 0x00409990
		// (set) Token: 0x060045B2 RID: 17842 RVA: 0x0040B844 File Offset: 0x00409A44
		public bool RadInfoFLASHportNumberofTimesFlashed_A8581_Editable
		{
			get
			{
				short num = (short)1701452710;
				short num2 = num;
				num = (short)1553210278;
				switch (num2 == num)
				{
				default:
				{
					num = (short)9764864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)267321344;
				if (num != 0)
				{
				}
				num = (short)871956481;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportNumberofTimesFlashed_A8581.Editable;
			}
			set
			{
				short num = (short)104026447;
				short num2 = num;
				num = (short)276648271;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1702756352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)268632065;
				if (num != 0)
				{
				}
				num = (short)645660672;
				if (num != 0)
				{
				}
				this.radInfoFLASHportNumberofTimesFlashed_A8581.Editable = value;
			}
		}

		// Token: 0x170023C1 RID: 9153
		// (get) Token: 0x060045B3 RID: 17843 RVA: 0x0040B8F8 File Offset: 0x00409AF8
		internal string RadInfoFLASHportNumberofTimesFlashed_A8581_UILabel
		{
			get
			{
				short num = (short)1208447787;
				short num2 = num;
				num = (short)1642820395;
				switch (num2 == num)
				{
				default:
				{
					num = (short)834011136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1383268353;
				if (num != 0)
				{
				}
				num = (short)1192886272;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportNumberofTimesFlashed_A8581.UIName;
			}
		}

		// Token: 0x170023C2 RID: 9154
		// (get) Token: 0x060045B4 RID: 17844 RVA: 0x0040B9AC File Offset: 0x00409BAC
		// (set) Token: 0x060045B5 RID: 17845 RVA: 0x0040BA64 File Offset: 0x00409C64
		internal bool RadInfoFLASHportNumberofTimesFlashed_A8581_HiddenStatic
		{
			get
			{
				short num = (short)1118424422;
				short num2 = num;
				num = (short)212716902;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1181876224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1295712257;
				if (num != 0)
				{
				}
				num = (short)781189120;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportNumberofTimesFlashed_A8581.HiddenStatic;
			}
			set
			{
				short num = (short)1792913944;
				short num2 = num;
				num = (short)2141172248;
				switch (num2 == num)
				{
				default:
				{
					num = (short)484900864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1372717056;
				if (num != 0)
				{
				}
				num = (short)846790657;
				if (num != 0)
				{
				}
				this.radInfoFLASHportNumberofTimesFlashed_A8581.HiddenStatic = value;
			}
		}

		// Token: 0x170023C3 RID: 9155
		// (get) Token: 0x060045B6 RID: 17846 RVA: 0x0040BB18 File Offset: 0x00409D18
		// (set) Token: 0x060045B7 RID: 17847 RVA: 0x0040BBCC File Offset: 0x00409DCC
		internal bool RadInfoFLASHportNumberofTimesFlashed_A8581_HiddenDynamic
		{
			get
			{
				short num = (short)1685833546;
				short num2 = num;
				num = (short)683132746;
				switch (num2 == num)
				{
				default:
				{
					num = (short)933036032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1293615105;
				if (num != 0)
				{
				}
				num = (short)758841344;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportNumberofTimesFlashed_A8581.HiddenDynamic;
			}
			set
			{
				short num = (short)1495157222;
				short num2 = num;
				num = (short)2146585062;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1273364480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1554710528;
				if (num != 0)
				{
				}
				num = (short)1259929601;
				if (num != 0)
				{
				}
				this.radInfoFLASHportNumberofTimesFlashed_A8581.HiddenDynamic = value;
			}
		}

		// Token: 0x170023C4 RID: 9156
		// (get) Token: 0x060045B8 RID: 17848 RVA: 0x0040BC84 File Offset: 0x00409E84
		public bool RadInfoFLASHportNumberofTimesFlashed_A8581_HasDiffs
		{
			get
			{
				short num = (short)1090472131;
				short num2 = num;
				num = (short)1850165443;
				switch (num2 == num)
				{
				default:
				{
					num = (short)171442176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1087963136;
				if (num != 0)
				{
				}
				num = (short)1247346689;
				if (num != 0)
				{
				}
				return this.radInfoFLASHportNumberofTimesFlashed_A8581._HasDiffs;
			}
		}

		// Token: 0x060045B9 RID: 17849 RVA: 0x0040BD38 File Offset: 0x00409F38
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						num2 = (short)1949171713;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)591396866;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					case 2:
					{
						num2 = (short)867355524;
						short num3 = num2;
						num2 = (short)978176900;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_26;
						default:
							num2 = (short)908984320;
							if (num2 != 0)
							{
							}
							result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
							num2 = (short)1801453571;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 3:
						goto IL_AF;
					case 4:
						if (base.ParentRecset != null)
						{
							num2 = (short)650379264;
							short num4 = num2;
							num2 = (short)1048313856;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					goto IL_24;
				}
				IL_AF:
				num2 = (short)192151553;
				if (num2 != 0)
				{
				}
				return result;
			}
			IL_24:
			result = null;
			IL_26:
			num2 = (short)1835401220;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04001A7A RID: 6778
		private global::AcpBusinessLayer.AcpField<string> radInfoFLASHportFLASHcode_A8132;

		// Token: 0x04001A7B RID: 6779
		private global::AcpBusinessLayer.AcpField<string> radInfoFLASHportIButton_A8217;

		// Token: 0x04001A7C RID: 6780
		private global::AcpBusinessLayer.AcpRangeField<int, string> radInfoFLASHportLastUpgradeSource_A8387;

		// Token: 0x04001A7D RID: 6781
		private global::AcpBusinessLayer.AcpFieldX<long, string> radInfoLabtoolLastFLASHKeyDateStampData_A8388;

		// Token: 0x04001A7E RID: 6782
		private global::AcpBusinessLayer.AcpField<int> radInfoFLASHportNumberofTimesFlashed_A8581;
	}
}
