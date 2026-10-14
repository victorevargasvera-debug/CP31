using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.DVRSWide
{
	// Token: 0x020004B0 RID: 1200
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06009DB7 RID: 40375 RVA: 0x0093564C File Offset: 0x0093384C
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06009DB8 RID: 40376 RVA: 0x00935668 File Offset: 0x00933868
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06009DB9 RID: 40377 RVA: 0x00935680 File Offset: 0x00933880
		public override void Init()
		{
			int a_ = 2;
			short num = (short)1438291095;
			short num2 = num;
			num = (short)1101436055;
			switch (num2 == num)
			{
			}
			num = (short)598802433;
			if (num != 0)
			{
			}
			num = (short)1717174272;
			short num3 = num;
			num = (short)1079377920;
			if (num != 0)
			{
			}
			this.radWideLabtoolDVRSFatalError_A7910 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("釂꓄ꏆ黈ꋊ꧌꫎鷐닒럔ꏖ뛘듚뇜鯞럠뇢뛤ꇦ裨鿪賬菮듰臲蟴飶诸ꓺ볼죾㠀㈂㔄", a_), global::CommonResources.AcgResources.ID_DVRSFATALERROR);
			this.radWideLabtoolDVRSFatalError_A7910.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radWideLabtoolDVRSFatalError_A7910.DataTransferOrder = -1;
			this.radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("釂꓄ꏆ賈맊꫌ꃎ蛐뫒뇔닖鷘닚뫜뛞闠苢觤뇦賨菪蓬賮蓰鿲铴藶꯸黺跼髾怀眂怄甆娈爊縌笎琐縒儔䄖䬘䠚唜縞匠䜢判䘦嬨个栬䄮倰儲头制昸稺਼ؾ灀牂", a_), global::CommonResources.AcgResources.ID_DVRSHARDWAREENABLE);
			this.radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.DataTransferOrder = 1;
			this.dVRSWideGeneralVIPCtrlofDVRS_A41798 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蟂鏄闆髈鳊꓌ꯎ듐铒냔맖볘꧚볜돞럠ꫢ뗤ꓦ鷨駪臬胮韰럲ꏴꗶ꫸ꓺ볼쯾\u3000㐂㰄㼆", a_), global::CommonResources.AcgResources.ID_VIPCONTROLOFDVRS, global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.LOVs.DVRSWideGeneralVIPCtrlofDVRS_A41798LovStrs);
			this.dVRSWideGeneralVIPCtrlofDVRS_A41798.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dVRSWideGeneralVIPCtrlofDVRS_A41798.DataTransferOrder = 2;
			this.dVRSWideGeneralInCarMonitor_A41799 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蟂鏄闆髈鳊꓌ꯎ듐铒냔맖볘꧚볜돞꣠跢ꛤ蛦鯨ꛪ苬臮飰蟲髴藶꛸뫺짼컾㘀㨂㰄", a_), global::CommonResources.AcgResources.ID_INCARMONITOR, global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.LOVs.DVRSWideGeneralInCarMonitor_A41799LovStrs);
			this.dVRSWideGeneralInCarMonitor_A41799.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dVRSWideGeneralInCarMonitor_A41799.DataTransferOrder = 3;
			this.dVRSWideLabtoolDVRSSyncFieldsHash_A41811 = new global::AcpBusinessLayer.AcpField<long>(0L, this, global::AllFeatures.CodeplugGuid.b("蟂鏄闆髈鳊꓌ꯎ듐鿒듔뗖귘듚닜돞ꗠ뗢럤듦뫨鋪菬賮런髲郴鯶鷸裺뗼黾爀欂娄䘆㴈㨊㔌㸎‐", a_), global::CommonResources.AcgResources.ID_DVRSSYNCFIELDSHASH);
			this.dVRSWideLabtoolDVRSSyncFieldsHash_A41811.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.dVRSWideLabtoolDVRSSyncFieldsHash_A41811.DataTransferOrder = -1;
			this.dVRSWideLabtoolVrId_A43727 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("蟂鏄闆髈鳊꓌ꯎ듐鿒듔뗖귘듚닜돞럠釢곤菦뛨ꫪ\ud9ec\udcee웰쇲싴", a_), global::CommonResources.AcgResources.ID_VRID, 0, 16777215, null, null, 0, 1);
			this.dVRSWideLabtoolVrId_A43727.IgnoreOnCompare = true;
			this.dVRSWideLabtoolVrId_A43727.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dVRSWideLabtoolVrId_A43727.DataTransferOrder = -1;
			this.dVRSWideLabtoolVrId_A43727.ShowHexValue = true;
			this.dVRSWideGeneralChannelOnlyDisplay_A41811 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蟂鏄闆髈鳊꓌ꯎ듐铒냔맖볘꧚볜돞ꋠ询蓤触蟨軪臬ꃮ鿰鿲賴돶郸裺跼鏾怀稂娄䘆㴈㨊㔌㸎‐", a_), global::CommonResources.AcgResources.ID_CHANNELONLYDISPLAY);
			this.dVRSWideGeneralChannelOnlyDisplay_A41811.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.dVRSWideGeneralChannelOnlyDisplay_A41811.DataTransferOrder = 4;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蓂ꃄ꧆곈맊곌ꏎ", a_);
			base.Id = 10758;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06009DBA RID: 40378 RVA: 0x0093591C File Offset: 0x00933B1C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 13;
			short num = (short)1049886731;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諍蛏胑蟓臕뇗뻙맛鋝臟胡郣觥蟧蛩꣫룭ꋯꇱꟳ迵雷駹뫻韽旿渁怃甅䀇欉缋昍伏匑–✕‗⬙ⴛ", a_)))
					{
						goto IL_2B5;
					}
					goto IL_442;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諍蛏胑蟓臕뇗뻙맛駝藟賡臣铥觧蛩꿫蛭釯鳱髳鏵铷뗹鋻鋽秿䘁洃甅砇昉洋眍伏匑–✕‗⬙ⴛ", a_)))
					{
						num = (short)1341259791;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_623;
				case 2:
					this.dVRSWideGeneralInCarMonitor_A41799 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("諍蛏胑蟓臕뇗뻙맛駝藟賡臣铥觧蛩ꗫ胭돯鏱蛳믵韷铹闻諽濿瀁嬃䜅㰇㬉㬋㜍⤏", a_), global::CommonResources.AcgResources.ID_INCARMONITOR, global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.LOVs.DVRSWideGeneralInCarMonitor_A41799LovStrs);
					this.dVRSWideGeneralInCarMonitor_A41799.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dVRSWideGeneralInCarMonitor_A41799.DataTransferOrder = 3;
					num = (short)1203765270;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諍蛏胑蟓臕뇗뻙맛駝藟賡臣铥觧蛩ꗫ胭돯鏱蛳믵韷铹闻諽濿瀁嬃䜅㰇㬉㬋㜍⤏", a_)))
					{
						num = (short)425525250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_283;
				case 4:
					goto IL_5D7;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧껩뫫볭ꏯ등闳苵駷雹맻賽狿洁瘃夅䤇㴉㔋㼍‏", a_)))
					{
						num = (short)2073886728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_37F;
				case 6:
					goto IL_3F5;
				case 7:
					goto IL_442;
				case 8:
					this.radWideLabtoolDVRSFatalError_A7910 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙郛뿝苟雡诣觥蓧껩뫫볭ꏯ등闳苵駷雹맻賽狿洁瘃夅䤇㴉㔋㼍‏", a_), global::CommonResources.AcgResources.ID_DVRSFATALERROR);
					this.radWideLabtoolDVRSFatalError_A7910.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radWideLabtoolDVRSFatalError_A7910.DataTransferOrder = -1;
					num = (short)1346830354;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諍蛏胑蟓臕뇗뻙맛駝藟賡臣铥觧蛩뫫꟭ꃯ뇱胳蓵铷闹髻뫽囿倁圃夅䤇㸉㴋㤍⤏⨑", a_)))
					{
						num = (short)1446772748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5D7;
				case 10:
					num = (short)1953431571;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					switch (0)
					{
					case 0:
						goto IL_93;
					}
					continue;
				case 12:
					this.dVRSWideGeneralVIPCtrlofDVRS_A41798 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("諍蛏胑蟓臕뇗뻙맛駝藟賡臣铥觧蛩뫫꟭ꃯ뇱胳蓵铷闹髻뫽囿倁圃夅䤇㸉㴋㤍⤏⨑", a_), global::CommonResources.AcgResources.ID_VIPCONTROLOFDVRS, global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.LOVs.DVRSWideGeneralVIPCtrlofDVRS_A41798LovStrs);
					this.dVRSWideGeneralVIPCtrlofDVRS_A41798.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dVRSWideGeneralVIPCtrlofDVRS_A41798.DataTransferOrder = 2;
					num = (short)127860740;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					goto IL_58C;
				case 14:
					goto IL_321;
				case 15:
					this.dVRSWideGeneralChannelOnlyDisplay_A41811 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("諍蛏胑蟓臕뇗뻙맛駝藟賡臣铥觧蛩꿫蛭釯鳱髳鏵铷뗹鋻鋽秿䘁洃甅砇昉洋眍伏匑–✕‗⬙ⴛ", a_), global::CommonResources.AcgResources.ID_CHANNELONLYDISPLAY);
					this.dVRSWideGeneralChannelOnlyDisplay_A41811.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.dVRSWideGeneralChannelOnlyDisplay_A41811.DataTransferOrder = 4;
					num = (short)715063310;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諍蛏胑蟓臕뇗뻙맛鋝臟胡郣觥蟧蛩뫫鳭맯雱꯳럵쳷짹쯻쳽㟿", a_)))
					{
						num = (short)618004503;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3F5;
				case 17:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗뗙诛럝蓟蟡ꃣ迥迧菩飫迭鳯ꓱ釳黵釷駹觻鋽懿瀁嘃挅砇漉洋稍甏怑䜓漕欗渙礛猝搟琡瘣甥性䬩師䨭䜯匱䘳匵紷吹崻尽ⰿ❁ᭃ݅罇獉絋罍", a_)))
					{
						num = (short)1710817301;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_58C;
				case 18:
					goto IL_37F;
				case 19:
				{
					num = (short)1529169175;
					short num3 = num;
					num = (short)1367426327;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2B5;
					default:
						num = (short)798818304;
						if (num != 0)
						{
						}
						if (producerFields != null)
						{
							num = (short)2079129620;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_623;
					}
					break;
				}
				case 20:
					num = (short)887816197;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
				{
					num = (short)610992129;
					if (num != 0)
					{
					}
					num = (short)850788352;
					short num4 = num;
					this.radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑釓ꓕ뿗뗙诛럝蓟蟡ꃣ迥迧菩飫迭鳯ꓱ釳黵釷駹觻鋽懿瀁嘃挅砇漉洋稍甏怑䜓漕欗渙礛猝搟琡瘣甥性䬩師䨭䜯匱䘳匵紷吹崻尽ⰿ❁ᭃ݅罇獉絋罍", a_), global::CommonResources.AcgResources.ID_DVRSHARDWAREENABLE);
					this.radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.DataTransferOrder = 1;
					num = (short)108199949;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 22:
					goto IL_283;
				case 23:
					this.dVRSWideLabtoolVrId_A43727 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("諍蛏胑蟓臕뇗뻙맛鋝臟胡郣觥蟧蛩뫫鳭맯雱꯳럵쳷짹쯻쳽㟿", a_), global::CommonResources.AcgResources.ID_VRID, 0, 16777215, null, null, 0, 1);
					this.dVRSWideLabtoolVrId_A43727.IgnoreOnCompare = true;
					this.dVRSWideLabtoolVrId_A43727.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dVRSWideLabtoolVrId_A43727.DataTransferOrder = -1;
					this.dVRSWideLabtoolVrId_A43727.ShowHexValue = true;
					num = (short)452657158;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					this.dVRSWideLabtoolDVRSSyncFieldsHash_A41811 = new global::AcpBusinessLayer.AcpField<long>(0L, this, global::AllFeatures.CodeplugGuid.b("諍蛏胑蟓臕뇗뻙맛鋝臟胡郣觥蟧蛩꣫룭ꋯꇱꟳ迵雷駹뫻韽旿渁怃甅䀇欉缋昍伏匑–✕‗⬙ⴛ", a_), global::CommonResources.AcgResources.ID_DVRSSYNCFIELDSHASH);
					this.dVRSWideLabtoolDVRSSyncFieldsHash_A41811.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.dVRSWideLabtoolDVRSSyncFieldsHash_A41811.DataTransferOrder = -1;
					num = (short)1007091719;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_93:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1759772682;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_283:
				num = (short)1625161728;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2B5:
				num = (short)919076888;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_37F:
				num = (short)2018770961;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3F5:
				num = (short)155189249;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_442:
				num = (short)1306329104;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_58C:
				num = (short)1863778313;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5D7:
				num = (short)1224278019;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_321:
			IL_623:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("觍뗏병뇓ꓕ맗뛙", a_);
			base.Id = 10758;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06009DBB RID: 40379 RVA: 0x00935F80 File Offset: 0x00934180
		public override void PopulateReferences()
		{
			short num = (short)1451400303;
			short num2 = num;
			num = (short)1433574511;
			switch (num2 == num)
			{
			}
			num = (short)1844772864;
			short num3 = num;
			num = (short)1954021377;
			if (num != 0)
			{
			}
			num = (short)1857945600;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009DBC RID: 40380 RVA: 0x0093602C File Offset: 0x0093422C
		public override void DropReferences()
		{
			short num = (short)1793039276;
			short num2 = num;
			num = (short)364878764;
			switch (num2 == num)
			{
			}
			num = (short)1704394752;
			short num3 = num;
			num = (short)712704000;
			if (num != 0)
			{
			}
			num = (short)325582849;
			if (num != 0)
			{
			}
		}

		// Token: 0x06009DBD RID: 40381 RVA: 0x009360D8 File Offset: 0x009342D8
		public override void SetConstraints()
		{
			short num = (short)2137484146;
			short num2 = num;
			num = (short)1417177970;
			switch (num2 == num)
			{
			}
			num = (short)1469317120;
			short num3 = num;
			num = (short)82771969;
			if (num != 0)
			{
			}
			num = (short)932446208;
			if (num != 0)
			{
			}
			this.radWideLabtoolDVRSFatalError_A7910.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWideConstraints.ConDVRSHardWareIsApplicable);
			this.radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWideConstraints.ConDVRSHardWareIsValid);
			this.dVRSWideGeneralVIPCtrlofDVRS_A41798.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWideConstraints.ConDVRSHardWareIsEnabled);
			this.dVRSWideGeneralInCarMonitor_A41799.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWideConstraints.ConDVRSHardWareIsEnabled);
			this.dVRSWideLabtoolDVRSSyncFieldsHash_A41811.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.dVRSWideGeneralChannelOnlyDisplay_A41811.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWideConstraints.ConDVRSHardWareIsEnabled);
			this.dVRSWideGeneralChannelOnlyDisplay_A41811.IsEditable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWideConstraints.ConDVRSHardWareIsEnabled);
		}

		// Token: 0x06009DBE RID: 40382 RVA: 0x00936234 File Offset: 0x00934434
		public override void SetupDependencies()
		{
			short num = (short)296173105;
			short num2 = num;
			num = (short)996884017;
			switch (num2 == num)
			{
			}
			num = (short)1072562176;
			short num3 = num;
			num = (short)663027713;
			if (num != 0)
			{
			}
			num = (short)84803584;
			if (num != 0)
			{
			}
			this.radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.dVRSWideGeneralVIPCtrlofDVRS_A41798);
			this.radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.dVRSWideGeneralInCarMonitor_A41799);
			this.RefRadioWide.Features.RadWideAdvancedRFModem_A8972.AddDependentObject(this.radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911);
			this.radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.AddDependentObject(this.dVRSWideGeneralChannelOnlyDisplay_A41811);
		}

		// Token: 0x17004F31 RID: 20273
		// (get) Token: 0x06009DBF RID: 40383 RVA: 0x0093632C File Offset: 0x0093452C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1501987896;
				short num2 = num;
				num = (short)647595064;
				switch (num2 == num)
				{
				}
				num = (short)1359740928;
				short num3 = num;
				num = (short)1070399489;
				if (num != 0)
				{
				}
				num = (short)482541568;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004F32 RID: 20274
		// (get) Token: 0x06009DC0 RID: 40384 RVA: 0x009363DC File Offset: 0x009345DC
		// (set) Token: 0x06009DC1 RID: 40385 RVA: 0x00936494 File Offset: 0x00934694
		public bool RadWideLabtoolDVRSFatalError_A7910Value
		{
			get
			{
				short num = (short)464892056;
				short num2 = num;
				num = (short)1338355864;
				switch (num2 == num)
				{
				}
				num = (short)271712256;
				short num3 = num;
				num = (short)259915776;
				if (num != 0)
				{
				}
				num = (short)2022178817;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDVRSFatalError_A7910.Value;
			}
			set
			{
				short num = (short)924061392;
				short num2 = num;
				num = (short)909512400;
				switch (num2 == num)
				{
				}
				num = (short)195952640;
				short num3 = num;
				num = (short)2070609920;
				if (num != 0)
				{
				}
				num = (short)675414017;
				if (num != 0)
				{
				}
				this.radWideLabtoolDVRSFatalError_A7910.Value = value;
			}
		}

		// Token: 0x17004F33 RID: 20275
		// (get) Token: 0x06009DC2 RID: 40386 RVA: 0x00936548 File Offset: 0x00934748
		public global::AcpBusinessLayer.AcpField<bool> RadWideLabtoolDVRSFatalError_A7910
		{
			get
			{
				short num = (short)585938636;
				short num2 = num;
				num = (short)1673901772;
				switch (num2 == num)
				{
				}
				num = (short)296288256;
				short num3 = num;
				num = (short)1650524161;
				if (num != 0)
				{
				}
				num = (short)1873739776;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDVRSFatalError_A7910;
			}
		}

		// Token: 0x17004F34 RID: 20276
		// (get) Token: 0x06009DC3 RID: 40387 RVA: 0x009365F8 File Offset: 0x009347F8
		// (set) Token: 0x06009DC4 RID: 40388 RVA: 0x009366B0 File Offset: 0x009348B0
		public bool RadWideLabtoolDVRSFatalError_A7910_UIValue
		{
			get
			{
				short num = (short)254976551;
				short num2 = num;
				num = (short)1312334375;
				switch (num2 == num)
				{
				}
				num = (short)1095630848;
				short num3 = num;
				num = (short)2141716480;
				if (num != 0)
				{
				}
				num = (short)294322177;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDVRSFatalError_A7910.Value;
			}
			set
			{
				short num = (short)275184708;
				short num2 = num;
				num = (short)2013330500;
				switch (num2 == num)
				{
				}
				num = (short)1437859840;
				short num3 = num;
				num = (short)1351155712;
				if (num != 0)
				{
				}
				num = (short)1564934145;
				if (num != 0)
				{
				}
				this.radWideLabtoolDVRSFatalError_A7910.Value = value;
			}
		}

		// Token: 0x17004F35 RID: 20277
		// (get) Token: 0x06009DC5 RID: 40389 RVA: 0x00936764 File Offset: 0x00934964
		// (set) Token: 0x06009DC6 RID: 40390 RVA: 0x0093681C File Offset: 0x00934A1C
		public bool RadWideLabtoolDVRSFatalError_A7910_Applicable
		{
			get
			{
				short num = (short)376297487;
				short num2 = num;
				num = (short)374396943;
				switch (num2 == num)
				{
				}
				num = (short)660013056;
				short num3 = num;
				num = (short)1889075200;
				if (num != 0)
				{
				}
				num = (short)1771110401;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDVRSFatalError_A7910.Applicable;
			}
			set
			{
				short num = (short)1659854347;
				short num2 = num;
				num = (short)907238923;
				switch (num2 == num)
				{
				}
				num = (short)1347616768;
				short num3 = num;
				num = (short)688062464;
				if (num != 0)
				{
				}
				num = (short)1790640129;
				if (num != 0)
				{
				}
				this.radWideLabtoolDVRSFatalError_A7910.Applicable = value;
			}
		}

		// Token: 0x17004F36 RID: 20278
		// (get) Token: 0x06009DC7 RID: 40391 RVA: 0x009368D4 File Offset: 0x00934AD4
		// (set) Token: 0x06009DC8 RID: 40392 RVA: 0x00936988 File Offset: 0x00934B88
		public bool RadWideLabtoolDVRSFatalError_A7910_Valid
		{
			get
			{
				short num = (short)1664831661;
				short num2 = num;
				num = (short)404377773;
				switch (num2 == num)
				{
				}
				num = (short)628555776;
				short num3 = num;
				num = (short)2041970688;
				if (num != 0)
				{
				}
				num = (short)1631911937;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDVRSFatalError_A7910.Valid;
			}
			set
			{
				short num = (short)377235370;
				short num2 = num;
				num = (short)309340074;
				switch (num2 == num)
				{
				}
				num = (short)1788280832;
				short num3 = num;
				num = (short)2093154304;
				if (num != 0)
				{
				}
				num = (short)565706753;
				if (num != 0)
				{
				}
				this.radWideLabtoolDVRSFatalError_A7910.Valid = value;
			}
		}

		// Token: 0x17004F37 RID: 20279
		// (get) Token: 0x06009DC9 RID: 40393 RVA: 0x00936A40 File Offset: 0x00934C40
		// (set) Token: 0x06009DCA RID: 40394 RVA: 0x00936AF4 File Offset: 0x00934CF4
		public bool RadWideLabtoolDVRSFatalError_A7910_Visible
		{
			get
			{
				short num = (short)382475481;
				short num2 = num;
				num = (short)267721945;
				switch (num2 == num)
				{
				}
				num = (short)1636761600;
				short num3 = num;
				num = (short)194641920;
				if (num != 0)
				{
				}
				num = (short)1832583169;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDVRSFatalError_A7910.Visible;
			}
			set
			{
				short num = (short)1226783443;
				short num2 = num;
				num = (short)248068819;
				switch (num2 == num)
				{
				}
				num = (short)1893662720;
				short num3 = num;
				num = (short)1786118144;
				if (num != 0)
				{
				}
				num = (short)666763265;
				if (num != 0)
				{
				}
				this.radWideLabtoolDVRSFatalError_A7910.Visible = value;
			}
		}

		// Token: 0x17004F38 RID: 20280
		// (get) Token: 0x06009DCB RID: 40395 RVA: 0x00936BA8 File Offset: 0x00934DA8
		// (set) Token: 0x06009DCC RID: 40396 RVA: 0x00936C5C File Offset: 0x00934E5C
		public bool RadWideLabtoolDVRSFatalError_A7910_Editable
		{
			get
			{
				short num = (short)1763485903;
				short num2 = num;
				num = (short)312715471;
				switch (num2 == num)
				{
				}
				num = (short)977338368;
				short num3 = num;
				num = (short)1776418817;
				if (num != 0)
				{
				}
				num = (short)598802432;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDVRSFatalError_A7910.Editable;
			}
			set
			{
				short num = (short)1852674575;
				short num2 = num;
				num = (short)1613271567;
				switch (num2 == num)
				{
				}
				num = (short)2090008576;
				short num3 = num;
				num = (short)1773338625;
				if (num != 0)
				{
				}
				num = (short)1588854784;
				if (num != 0)
				{
				}
				this.radWideLabtoolDVRSFatalError_A7910.Editable = value;
			}
		}

		// Token: 0x17004F39 RID: 20281
		// (get) Token: 0x06009DCD RID: 40397 RVA: 0x00936D10 File Offset: 0x00934F10
		internal string RadWideLabtoolDVRSFatalError_A7910_UILabel
		{
			get
			{
				short num = (short)148611835;
				short num2 = num;
				num = (short)1933681403;
				switch (num2 == num)
				{
				}
				num = (short)275447808;
				short num3 = num;
				num = (short)1608122368;
				if (num != 0)
				{
				}
				num = (short)365690881;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDVRSFatalError_A7910.UIName;
			}
		}

		// Token: 0x17004F3A RID: 20282
		// (get) Token: 0x06009DCE RID: 40398 RVA: 0x00936DC4 File Offset: 0x00934FC4
		// (set) Token: 0x06009DCF RID: 40399 RVA: 0x00936E74 File Offset: 0x00935074
		internal bool RadWideLabtoolDVRSFatalError_A7910_HiddenStatic
		{
			get
			{
				short num = (short)1204117553;
				short num2 = num;
				num = (short)1531994161;
				switch (num2 == num)
				{
				}
				num = (short)1089601536;
				short num3 = num;
				num = (short)896532481;
				if (num != 0)
				{
				}
				num = (short)841613312;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDVRSFatalError_A7910.HiddenStatic;
			}
			set
			{
				short num = (short)1096226065;
				short num2 = num;
				num = (short)723129617;
				switch (num2 == num)
				{
				}
				num = (short)641138688;
				short num3 = num;
				num = (short)61669377;
				if (num != 0)
				{
				}
				num = (short)2005532672;
				if (num != 0)
				{
				}
				this.radWideLabtoolDVRSFatalError_A7910.HiddenStatic = value;
			}
		}

		// Token: 0x17004F3B RID: 20283
		// (get) Token: 0x06009DD0 RID: 40400 RVA: 0x00936F2C File Offset: 0x0093512C
		// (set) Token: 0x06009DD1 RID: 40401 RVA: 0x00936FE0 File Offset: 0x009351E0
		internal bool RadWideLabtoolDVRSFatalError_A7910_HiddenDynamic
		{
			get
			{
				short num = (short)1374158849;
				if (num != 0)
				{
				}
				num = (short)1891512909;
				short num2 = num;
				num = (short)59388493;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1628176384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)236650496;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDVRSFatalError_A7910.HiddenDynamic;
			}
			set
			{
				short num = (short)1844482485;
				short num2 = num;
				num = (short)203133365;
				switch (num2 == num)
				{
				}
				num = (short)1189478400;
				short num3 = num;
				num = (short)279117825;
				if (num != 0)
				{
				}
				num = (short)79953920;
				if (num != 0)
				{
				}
				this.radWideLabtoolDVRSFatalError_A7910.HiddenDynamic = value;
			}
		}

		// Token: 0x17004F3C RID: 20284
		// (get) Token: 0x06009DD2 RID: 40402 RVA: 0x00937094 File Offset: 0x00935294
		public bool RadWideLabtoolDVRSFatalError_A7910_HasDiffs
		{
			get
			{
				short num = (short)356777985;
				if (num != 0)
				{
				}
				num = (short)1213803729;
				short num2 = num;
				num = (short)1683762385;
				switch (num2 == num)
				{
				default:
				{
					num = (short)658767872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)290586624;
				if (num != 0)
				{
				}
				return this.radWideLabtoolDVRSFatalError_A7910._HasDiffs;
			}
		}

		// Token: 0x17004F3D RID: 20285
		// (get) Token: 0x06009DD3 RID: 40403 RVA: 0x0093714C File Offset: 0x0093534C
		// (set) Token: 0x06009DD4 RID: 40404 RVA: 0x009371FC File Offset: 0x009353FC
		public bool RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911Value
		{
			get
			{
				short num = (short)1114764908;
				short num2 = num;
				num = (short)1268446828;
				switch (num2 == num)
				{
				}
				num = (short)477102080;
				short num3 = num;
				num = (short)155779072;
				if (num != 0)
				{
				}
				num = (short)1705377793;
				if (num != 0)
				{
				}
				return this.radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value;
			}
			set
			{
				short num = (short)1710587021;
				short num2 = num;
				num = (short)282754189;
				switch (num2 == num)
				{
				}
				num = (short)1212284928;
				short num3 = num;
				num = (short)1108475905;
				if (num != 0)
				{
				}
				num = (short)1197998080;
				if (num != 0)
				{
				}
				this.radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value = value;
			}
		}

		// Token: 0x17004F3E RID: 20286
		// (get) Token: 0x06009DD5 RID: 40405 RVA: 0x009372B0 File Offset: 0x009354B0
		public global::AcpBusinessLayer.AcpField<bool> RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911
		{
			get
			{
				short num = (short)1091568005;
				short num2 = num;
				num = (short)910229893;
				switch (num2 == num)
				{
				}
				num = (short)851968000;
				short num3 = num;
				num = (short)4849665;
				if (num != 0)
				{
				}
				num = (short)71434240;
				if (num != 0)
				{
				}
				return this.radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911;
			}
		}

		// Token: 0x17004F3F RID: 20287
		// (get) Token: 0x06009DD6 RID: 40406 RVA: 0x00937360 File Offset: 0x00935560
		// (set) Token: 0x06009DD7 RID: 40407 RVA: 0x00937414 File Offset: 0x00935614
		public bool RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911_UIValue
		{
			get
			{
				short num = (short)1914109953;
				if (num != 0)
				{
				}
				num = (short)1342970238;
				short num2 = num;
				num = (short)1586895230;
				switch (num2 == num)
				{
				default:
				{
					num = (short)520421376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)758775808;
				if (num != 0)
				{
				}
				return this.radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value;
			}
			set
			{
				short num = (short)1649642590;
				short num2 = num;
				num = (short)976850014;
				switch (num2 == num)
				{
				}
				num = (short)1608581120;
				short num3 = num;
				num = (short)1836646400;
				if (num != 0)
				{
				}
				num = (short)391118849;
				if (num != 0)
				{
				}
				this.radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value = value;
			}
		}

		// Token: 0x17004F40 RID: 20288
		// (get) Token: 0x06009DD8 RID: 40408 RVA: 0x009374CC File Offset: 0x009356CC
		// (set) Token: 0x06009DD9 RID: 40409 RVA: 0x00937580 File Offset: 0x00935780
		public bool RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911_Applicable
		{
			get
			{
				short num = (short)264843934;
				short num2 = num;
				num = (short)1269641886;
				switch (num2 == num)
				{
				}
				num = (short)440139776;
				short num3 = num;
				num = (short)517079041;
				if (num != 0)
				{
				}
				num = (short)593690624;
				if (num != 0)
				{
				}
				return this.radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Applicable;
			}
			set
			{
				short num = (short)834136279;
				short num2 = num;
				num = (short)1684990167;
				switch (num2 == num)
				{
				}
				num = (short)1259929600;
				short num3 = num;
				num = (short)633798657;
				if (num != 0)
				{
				}
				num = (short)1227751424;
				if (num != 0)
				{
				}
				this.radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Applicable = value;
			}
		}

		// Token: 0x17004F41 RID: 20289
		// (get) Token: 0x06009DDA RID: 40410 RVA: 0x00937638 File Offset: 0x00935838
		// (set) Token: 0x06009DDB RID: 40411 RVA: 0x009376EC File Offset: 0x009358EC
		public bool RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911_Valid
		{
			get
			{
				short num = (short)295831036;
				short num2 = num;
				num = (short)1860306428;
				switch (num2 == num)
				{
				}
				num = (short)246939648;
				short num3 = num;
				num = (short)2075394048;
				if (num != 0)
				{
				}
				num = (short)1227554817;
				if (num != 0)
				{
				}
				return this.radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Valid;
			}
			set
			{
				short num = (short)2133984016;
				short num2 = num;
				num = (short)1170604816;
				switch (num2 == num)
				{
				}
				num = (short)1364393984;
				short num3 = num;
				num = (short)485425153;
				if (num != 0)
				{
				}
				num = (short)766246912;
				if (num != 0)
				{
				}
				this.radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Valid = value;
			}
		}

		// Token: 0x17004F42 RID: 20290
		// (get) Token: 0x06009DDC RID: 40412 RVA: 0x009377A4 File Offset: 0x009359A4
		// (set) Token: 0x06009DDD RID: 40413 RVA: 0x00937858 File Offset: 0x00935A58
		public bool RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911_Visible
		{
			get
			{
				short num = (short)1820403940;
				short num2 = num;
				num = (short)654649572;
				switch (num2 == num)
				{
				}
				num = (short)2003763200;
				short num3 = num;
				num = (short)111804417;
				if (num != 0)
				{
				}
				num = (short)1477181440;
				if (num != 0)
				{
				}
				return this.radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Visible;
			}
			set
			{
				short num = (short)1849910427;
				short num2 = num;
				num = (short)1149461659;
				switch (num2 == num)
				{
				}
				num = (short)73007104;
				short num3 = num;
				num = (short)2090991617;
				if (num != 0)
				{
				}
				num = (short)1345323008;
				if (num != 0)
				{
				}
				this.radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Visible = value;
			}
		}

		// Token: 0x17004F43 RID: 20291
		// (get) Token: 0x06009DDE RID: 40414 RVA: 0x00937910 File Offset: 0x00935B10
		// (set) Token: 0x06009DDF RID: 40415 RVA: 0x009379C4 File Offset: 0x00935BC4
		public bool RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911_Editable
		{
			get
			{
				short num = (short)1010210079;
				short num2 = num;
				num = (short)466851103;
				switch (num2 == num)
				{
				}
				num = (short)825294848;
				short num3 = num;
				num = (short)1063911425;
				if (num != 0)
				{
				}
				num = (short)1563951104;
				if (num != 0)
				{
				}
				return this.radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Editable;
			}
			set
			{
				short num = (short)792999082;
				short num2 = num;
				num = (short)1485059242;
				switch (num2 == num)
				{
				}
				num = (short)1145372672;
				short num3 = num;
				num = (short)778108929;
				if (num != 0)
				{
				}
				num = (short)24707072;
				if (num != 0)
				{
				}
				this.radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Editable = value;
			}
		}

		// Token: 0x17004F44 RID: 20292
		// (get) Token: 0x06009DE0 RID: 40416 RVA: 0x00937A78 File Offset: 0x00935C78
		internal string RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911_UILabel
		{
			get
			{
				short num = (short)306595700;
				short num2 = num;
				num = (short)1801996148;
				switch (num2 == num)
				{
				}
				num = (short)1186267136;
				short num3 = num;
				num = (short)451018753;
				if (num != 0)
				{
				}
				num = (short)1937375232;
				if (num != 0)
				{
				}
				return this.radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.UIName;
			}
		}

		// Token: 0x17004F45 RID: 20293
		// (get) Token: 0x06009DE1 RID: 40417 RVA: 0x00937B2C File Offset: 0x00935D2C
		// (set) Token: 0x06009DE2 RID: 40418 RVA: 0x00937BE4 File Offset: 0x00935DE4
		internal bool RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911_HiddenStatic
		{
			get
			{
				short num = (short)1316345258;
				short num2 = num;
				num = (short)2135283114;
				switch (num2 == num)
				{
				}
				num = (short)629997568;
				short num3 = num;
				num = (short)2133196801;
				if (num != 0)
				{
				}
				num = (short)1701249024;
				if (num != 0)
				{
				}
				return this.radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.HiddenStatic;
			}
			set
			{
				short num = (short)1486618423;
				short num2 = num;
				num = (short)1218903863;
				switch (num2 == num)
				{
				}
				num = (short)331415552;
				short num3 = num;
				num = (short)1103167489;
				if (num != 0)
				{
				}
				num = (short)1124139008;
				if (num != 0)
				{
				}
				this.radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.HiddenStatic = value;
			}
		}

		// Token: 0x17004F46 RID: 20294
		// (get) Token: 0x06009DE3 RID: 40419 RVA: 0x00937C9C File Offset: 0x00935E9C
		// (set) Token: 0x06009DE4 RID: 40420 RVA: 0x00937D54 File Offset: 0x00935F54
		internal bool RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911_HiddenDynamic
		{
			get
			{
				short num = (short)1268595826;
				short num2 = num;
				num = (short)976436338;
				switch (num2 == num)
				{
				}
				num = (short)993001472;
				short num3 = num;
				num = (short)2073952256;
				if (num != 0)
				{
				}
				num = (short)1381892097;
				if (num != 0)
				{
				}
				return this.radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.HiddenDynamic;
			}
			set
			{
				short num = (short)1836908545;
				if (num != 0)
				{
				}
				num = (short)1603905770;
				short num2 = num;
				num = (short)90286314;
				switch (num2 == num)
				{
				default:
				{
					num = (short)857079808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1095630848;
				if (num != 0)
				{
				}
				this.radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.HiddenDynamic = value;
			}
		}

		// Token: 0x17004F47 RID: 20295
		// (get) Token: 0x06009DE5 RID: 40421 RVA: 0x00937E08 File Offset: 0x00936008
		public bool RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911_HasDiffs
		{
			get
			{
				short num = (short)1087655253;
				short num2 = num;
				num = (short)1496862037;
				switch (num2 == num)
				{
				}
				num = (short)1564409856;
				short num3 = num;
				num = (short)1398996993;
				if (num != 0)
				{
				}
				num = (short)1537081344;
				if (num != 0)
				{
				}
				return this.radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911._HasDiffs;
			}
		}

		// Token: 0x17004F48 RID: 20296
		// (get) Token: 0x06009DE6 RID: 40422 RVA: 0x00937EC0 File Offset: 0x009360C0
		// (set) Token: 0x06009DE7 RID: 40423 RVA: 0x00937F78 File Offset: 0x00936178
		public int DVRSWideGeneralVIPCtrlofDVRS_A41798Value
		{
			get
			{
				short num = (short)1107022054;
				short num2 = num;
				num = (short)978899174;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1507655680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)964952064;
				if (num != 0)
				{
				}
				num = (short)1775566849;
				if (num != 0)
				{
				}
				return this.dVRSWideGeneralVIPCtrlofDVRS_A41798.Value;
			}
			set
			{
				short num = (short)4957421;
				short num2 = num;
				num = (short)509781229;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1647771648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)808255488;
				if (num != 0)
				{
				}
				num = (short)1060503553;
				if (num != 0)
				{
				}
				this.dVRSWideGeneralVIPCtrlofDVRS_A41798.Value = value;
			}
		}

		// Token: 0x17004F49 RID: 20297
		// (get) Token: 0x06009DE8 RID: 40424 RVA: 0x00938030 File Offset: 0x00936230
		// (set) Token: 0x06009DE9 RID: 40425 RVA: 0x009380E0 File Offset: 0x009362E0
		public string DVRSWideGeneralVIPCtrlofDVRS_A41798_UIValue
		{
			get
			{
				short num = (short)197812508;
				short num2 = num;
				num = (short)1725063452;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1236860928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1323565057;
				if (num != 0)
				{
				}
				num = (short)439681024;
				if (num != 0)
				{
				}
				return this.dVRSWideGeneralVIPCtrlofDVRS_A41798.UIValue;
			}
			set
			{
				short num = (short)1660485633;
				if (num != 0)
				{
				}
				num = (short)292683776;
				short num2 = num;
				num = (short)2109489031;
				short num3 = num;
				num = (short)1789607815;
				switch (num3 == num)
				{
				}
				num = (short)802750464;
				if (num != 0)
				{
				}
				this.dVRSWideGeneralVIPCtrlofDVRS_A41798.UIValue = value;
			}
		}

		// Token: 0x17004F4A RID: 20298
		// (get) Token: 0x06009DEA RID: 40426 RVA: 0x00938194 File Offset: 0x00936394
		public global::AcpBusinessLayer.AcpListField DVRSWideGeneralVIPCtrlofDVRS_A41798
		{
			get
			{
				short num = (short)280363009;
				if (num != 0)
				{
				}
				num = (short)1821179904;
				short num2 = num;
				num = (short)176293936;
				short num3 = num;
				num = (short)1346766896;
				switch (num3 == num)
				{
				}
				num = (short)1307049984;
				if (num != 0)
				{
				}
				return this.dVRSWideGeneralVIPCtrlofDVRS_A41798;
			}
		}

		// Token: 0x17004F4B RID: 20299
		// (get) Token: 0x06009DEB RID: 40427 RVA: 0x00938244 File Offset: 0x00936444
		// (set) Token: 0x06009DEC RID: 40428 RVA: 0x009382FC File Offset: 0x009364FC
		public bool DVRSWideGeneralVIPCtrlofDVRS_A41798_Applicable
		{
			get
			{
				short num = (short)1065560059;
				short num2 = num;
				num = (short)908142587;
				switch (num2 == num)
				{
				default:
				{
					num = (short)457375744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1027473409;
				if (num != 0)
				{
				}
				num = (short)311689216;
				if (num != 0)
				{
				}
				return this.dVRSWideGeneralVIPCtrlofDVRS_A41798.Applicable;
			}
			set
			{
				short num = (short)1676017665;
				if (num != 0)
				{
				}
				num = (short)2114322432;
				short num2 = num;
				num = (short)916733261;
				short num3 = num;
				num = (short)453131597;
				switch (num3 == num)
				{
				}
				num = (short)1469841408;
				if (num != 0)
				{
				}
				this.dVRSWideGeneralVIPCtrlofDVRS_A41798.Applicable = value;
			}
		}

		// Token: 0x17004F4C RID: 20300
		// (get) Token: 0x06009DED RID: 40429 RVA: 0x009383B0 File Offset: 0x009365B0
		// (set) Token: 0x06009DEE RID: 40430 RVA: 0x00938464 File Offset: 0x00936664
		public bool DVRSWideGeneralVIPCtrlofDVRS_A41798_Valid
		{
			get
			{
				short num = (short)299631077;
				short num2 = num;
				num = (short)1101857253;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1187315712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)279511041;
				if (num != 0)
				{
				}
				num = (short)1112408064;
				if (num != 0)
				{
				}
				return this.dVRSWideGeneralVIPCtrlofDVRS_A41798.Valid;
			}
			set
			{
				short num = (short)1009223905;
				short num2 = num;
				num = (short)1381337313;
				switch (num2 == num)
				{
				default:
				{
					num = (short)661716992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)313589760;
				if (num != 0)
				{
				}
				num = (short)1252065281;
				if (num != 0)
				{
				}
				this.dVRSWideGeneralVIPCtrlofDVRS_A41798.Valid = value;
			}
		}

		// Token: 0x17004F4D RID: 20301
		// (get) Token: 0x06009DEF RID: 40431 RVA: 0x00938518 File Offset: 0x00936718
		// (set) Token: 0x06009DF0 RID: 40432 RVA: 0x009385C8 File Offset: 0x009367C8
		public bool DVRSWideGeneralVIPCtrlofDVRS_A41798_Visible
		{
			get
			{
				short num = (short)195035137;
				if (num != 0)
				{
				}
				num = (short)247136256;
				short num2 = num;
				num = (short)635473961;
				short num3 = num;
				num = (short)1944096809;
				switch (num3 == num)
				{
				}
				num = (short)1769144320;
				if (num != 0)
				{
				}
				return this.dVRSWideGeneralVIPCtrlofDVRS_A41798.Visible;
			}
			set
			{
				short num = (short)1050935297;
				if (num != 0)
				{
				}
				num = (short)1561788416;
				short num2 = num;
				num = (short)21902438;
				short num3 = num;
				num = (short)675165286;
				switch (num3 == num)
				{
				}
				num = (short)1185349632;
				if (num != 0)
				{
				}
				this.dVRSWideGeneralVIPCtrlofDVRS_A41798.Visible = value;
			}
		}

		// Token: 0x17004F4E RID: 20302
		// (get) Token: 0x06009DF1 RID: 40433 RVA: 0x0093867C File Offset: 0x0093687C
		// (set) Token: 0x06009DF2 RID: 40434 RVA: 0x00938734 File Offset: 0x00936934
		public bool DVRSWideGeneralVIPCtrlofDVRS_A41798_Editable
		{
			get
			{
				short num = (short)1891315717;
				short num2 = num;
				num = (short)276312069;
				switch (num2 == num)
				{
				default:
				{
					num = (short)412614656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)974389249;
				if (num != 0)
				{
				}
				num = (short)1642921984;
				if (num != 0)
				{
				}
				return this.dVRSWideGeneralVIPCtrlofDVRS_A41798.Editable;
			}
			set
			{
				short num = (short)1414031906;
				short num2 = num;
				num = (short)391670306;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1128660992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)203489281;
				if (num != 0)
				{
				}
				num = (short)382402560;
				if (num != 0)
				{
				}
				this.dVRSWideGeneralVIPCtrlofDVRS_A41798.Editable = value;
			}
		}

		// Token: 0x17004F4F RID: 20303
		// (get) Token: 0x06009DF3 RID: 40435 RVA: 0x009387EC File Offset: 0x009369EC
		internal string DVRSWideGeneralVIPCtrlofDVRS_A41798_UILabel
		{
			get
			{
				short num = (short)1685195255;
				short num2 = num;
				num = (short)1767705079;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1598881792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1498677249;
				if (num != 0)
				{
				}
				num = (short)1668218880;
				if (num != 0)
				{
				}
				return this.dVRSWideGeneralVIPCtrlofDVRS_A41798.UIName;
			}
		}

		// Token: 0x17004F50 RID: 20304
		// (get) Token: 0x06009DF4 RID: 40436 RVA: 0x009388A0 File Offset: 0x00936AA0
		// (set) Token: 0x06009DF5 RID: 40437 RVA: 0x00938954 File Offset: 0x00936B54
		internal bool DVRSWideGeneralVIPCtrlofDVRS_A41798_HiddenStatic
		{
			get
			{
				short num = (short)152321696;
				short num2 = num;
				num = (short)755711648;
				switch (num2 == num)
				{
				default:
				{
					num = (short)40894464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)849412097;
				if (num != 0)
				{
				}
				num = (short)971767808;
				if (num != 0)
				{
				}
				return this.dVRSWideGeneralVIPCtrlofDVRS_A41798.HiddenStatic;
			}
			set
			{
				short num = (short)183453636;
				short num2 = num;
				num = (short)1363756996;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1238630400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1641021441;
				if (num != 0)
				{
				}
				num = (short)932642816;
				if (num != 0)
				{
				}
				this.dVRSWideGeneralVIPCtrlofDVRS_A41798.HiddenStatic = value;
			}
		}

		// Token: 0x17004F51 RID: 20305
		// (get) Token: 0x06009DF6 RID: 40438 RVA: 0x00938A08 File Offset: 0x00936C08
		// (set) Token: 0x06009DF7 RID: 40439 RVA: 0x00938ABC File Offset: 0x00936CBC
		internal bool DVRSWideGeneralVIPCtrlofDVRS_A41798_HiddenDynamic
		{
			get
			{
				short num = (short)1369440257;
				if (num != 0)
				{
				}
				num = (short)168493056;
				short num2 = num;
				num = (short)1730152362;
				short num3 = num;
				num = (short)615253930;
				switch (num3 == num)
				{
				}
				num = (short)222756864;
				if (num != 0)
				{
				}
				return this.dVRSWideGeneralVIPCtrlofDVRS_A41798.HiddenDynamic;
			}
			set
			{
				short num = (short)1660792594;
				short num2 = num;
				num = (short)1142140690;
				switch (num2 == num)
				{
				default:
				{
					num = (short)717553664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)56557569;
				if (num != 0)
				{
				}
				num = (short)654180352;
				if (num != 0)
				{
				}
				this.dVRSWideGeneralVIPCtrlofDVRS_A41798.HiddenDynamic = value;
			}
		}

		// Token: 0x17004F52 RID: 20306
		// (get) Token: 0x06009DF8 RID: 40440 RVA: 0x00938B74 File Offset: 0x00936D74
		public bool DVRSWideGeneralVIPCtrlofDVRS_A41798_HasDiffs
		{
			get
			{
				short num = (short)648082770;
				short num2 = num;
				num = (short)1133245778;
				switch (num2 == num)
				{
				default:
				{
					num = (short)489816064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1400897536;
				if (num != 0)
				{
				}
				num = (short)1099825153;
				if (num != 0)
				{
				}
				return this.dVRSWideGeneralVIPCtrlofDVRS_A41798._HasDiffs;
			}
		}

		// Token: 0x17004F53 RID: 20307
		// (get) Token: 0x06009DF9 RID: 40441 RVA: 0x00938C24 File Offset: 0x00936E24
		// (set) Token: 0x06009DFA RID: 40442 RVA: 0x00938CD8 File Offset: 0x00936ED8
		public int DVRSWideGeneralInCarMonitor_A41799Value
		{
			get
			{
				short num = (short)102705774;
				short num2 = num;
				num = (short)170404462;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1257635840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1773862913;
				if (num != 0)
				{
				}
				num = (short)1734082560;
				if (num != 0)
				{
				}
				return this.dVRSWideGeneralInCarMonitor_A41799.Value;
			}
			set
			{
				short num = (short)414936968;
				short num2 = num;
				num = (short)1996648328;
				switch (num2 == num)
				{
				default:
				{
					num = (short)472711168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1252786177;
				if (num != 0)
				{
				}
				num = (short)984809472;
				if (num != 0)
				{
				}
				this.dVRSWideGeneralInCarMonitor_A41799.Value = value;
			}
		}

		// Token: 0x17004F54 RID: 20308
		// (get) Token: 0x06009DFB RID: 40443 RVA: 0x00938D8C File Offset: 0x00936F8C
		// (set) Token: 0x06009DFC RID: 40444 RVA: 0x00938E40 File Offset: 0x00937040
		public string DVRSWideGeneralInCarMonitor_A41799_UIValue
		{
			get
			{
				short num = (short)145560429;
				short num2 = num;
				num = (short)63181677;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1822162944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1409155073;
				if (num != 0)
				{
				}
				num = (short)795213824;
				if (num != 0)
				{
				}
				return this.dVRSWideGeneralInCarMonitor_A41799.UIValue;
			}
			set
			{
				short num = (short)1339937298;
				short num2 = num;
				num = (short)736154130;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1921581056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)886833152;
				if (num != 0)
				{
				}
				num = (short)464388097;
				if (num != 0)
				{
				}
				this.dVRSWideGeneralInCarMonitor_A41799.UIValue = value;
			}
		}

		// Token: 0x17004F55 RID: 20309
		// (get) Token: 0x06009DFD RID: 40445 RVA: 0x00938EF4 File Offset: 0x009370F4
		public global::AcpBusinessLayer.AcpListField DVRSWideGeneralInCarMonitor_A41799
		{
			get
			{
				short num = (short)1258969850;
				short num2 = num;
				num = (short)922704634;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1958608896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1209729025;
				if (num != 0)
				{
				}
				num = (short)1248395264;
				if (num != 0)
				{
				}
				return this.dVRSWideGeneralInCarMonitor_A41799;
			}
		}

		// Token: 0x17004F56 RID: 20310
		// (get) Token: 0x06009DFE RID: 40446 RVA: 0x00938FA8 File Offset: 0x009371A8
		// (set) Token: 0x06009DFF RID: 40447 RVA: 0x00939060 File Offset: 0x00937260
		public bool DVRSWideGeneralInCarMonitor_A41799_Applicable
		{
			get
			{
				short num = (short)1907894216;
				short num2 = num;
				num = (short)1438132168;
				switch (num2 == num)
				{
				default:
				{
					num = (short)935198720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)179503105;
				if (num != 0)
				{
				}
				num = (short)410910720;
				if (num != 0)
				{
				}
				return this.dVRSWideGeneralInCarMonitor_A41799.Applicable;
			}
			set
			{
				short num = (short)1632092942;
				short num2 = num;
				num = (short)834585358;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1397096448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1699348481;
				if (num != 0)
				{
				}
				num = (short)1102577664;
				if (num != 0)
				{
				}
				this.dVRSWideGeneralInCarMonitor_A41799.Applicable = value;
			}
		}

		// Token: 0x17004F57 RID: 20311
		// (get) Token: 0x06009E00 RID: 40448 RVA: 0x00939114 File Offset: 0x00937314
		// (set) Token: 0x06009E01 RID: 40449 RVA: 0x009391C8 File Offset: 0x009373C8
		public bool DVRSWideGeneralInCarMonitor_A41799_Valid
		{
			get
			{
				short num = (short)2041284538;
				short num2 = num;
				num = (short)1795590074;
				switch (num2 == num)
				{
				default:
				{
					num = (short)990576640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)897384449;
				if (num != 0)
				{
				}
				num = (short)1207631872;
				if (num != 0)
				{
				}
				return this.dVRSWideGeneralInCarMonitor_A41799.Valid;
			}
			set
			{
				short num = (short)1861748265;
				short num2 = num;
				num = (short)138217001;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1199570944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)379518977;
				if (num != 0)
				{
				}
				num = (short)235274240;
				if (num != 0)
				{
				}
				this.dVRSWideGeneralInCarMonitor_A41799.Valid = value;
			}
		}

		// Token: 0x17004F58 RID: 20312
		// (get) Token: 0x06009E02 RID: 40450 RVA: 0x00939280 File Offset: 0x00937480
		// (set) Token: 0x06009E03 RID: 40451 RVA: 0x00939334 File Offset: 0x00937534
		public bool DVRSWideGeneralInCarMonitor_A41799_Visible
		{
			get
			{
				short num = (short)1384603995;
				short num2 = num;
				num = (short)1767399771;
				switch (num2 == num)
				{
				default:
				{
					num = (short)782630912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1293942784;
				if (num != 0)
				{
				}
				num = (short)1754726401;
				if (num != 0)
				{
				}
				return this.dVRSWideGeneralInCarMonitor_A41799.Visible;
			}
			set
			{
				short num = (short)332053604;
				short num2 = num;
				num = (short)1663614052;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1901985792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1080229889;
				if (num != 0)
				{
				}
				num = (short)1752956928;
				if (num != 0)
				{
				}
				this.dVRSWideGeneralInCarMonitor_A41799.Visible = value;
			}
		}

		// Token: 0x17004F59 RID: 20313
		// (get) Token: 0x06009E04 RID: 40452 RVA: 0x009393E8 File Offset: 0x009375E8
		// (set) Token: 0x06009E05 RID: 40453 RVA: 0x0093949C File Offset: 0x0093769C
		public bool DVRSWideGeneralInCarMonitor_A41799_Editable
		{
			get
			{
				short num = (short)21078980;
				short num2 = num;
				num = (short)627876804;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1477705728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1339949057;
				if (num != 0)
				{
				}
				num = (short)2120417280;
				if (num != 0)
				{
				}
				return this.dVRSWideGeneralInCarMonitor_A41799.Editable;
			}
			set
			{
				short num = (short)1843995582;
				short num2 = num;
				num = (short)1612325822;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1563951104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1137311744;
				if (num != 0)
				{
				}
				num = (short)1083506689;
				if (num != 0)
				{
				}
				this.dVRSWideGeneralInCarMonitor_A41799.Editable = value;
			}
		}

		// Token: 0x17004F5A RID: 20314
		// (get) Token: 0x06009E06 RID: 40454 RVA: 0x00939550 File Offset: 0x00937750
		internal string DVRSWideGeneralInCarMonitor_A41799_UILabel
		{
			get
			{
				short num = (short)1605921831;
				short num2 = num;
				num = (short)1673686055;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1067712512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2028994561;
				if (num != 0)
				{
				}
				num = (short)903675904;
				if (num != 0)
				{
				}
				return this.dVRSWideGeneralInCarMonitor_A41799.UIName;
			}
		}

		// Token: 0x17004F5B RID: 20315
		// (get) Token: 0x06009E07 RID: 40455 RVA: 0x00939604 File Offset: 0x00937804
		// (set) Token: 0x06009E08 RID: 40456 RVA: 0x009396B8 File Offset: 0x009378B8
		internal bool DVRSWideGeneralInCarMonitor_A41799_HiddenStatic
		{
			get
			{
				short num = (short)680518903;
				short num2 = num;
				num = (short)717546743;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1581776896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)125435904;
				if (num != 0)
				{
				}
				num = (short)1579089921;
				if (num != 0)
				{
				}
				return this.dVRSWideGeneralInCarMonitor_A41799.HiddenStatic;
			}
			set
			{
				short num = (short)74957006;
				short num2 = num;
				num = (short)1119207630;
				switch (num2 == num)
				{
				default:
				{
					num = (short)892796928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)983957505;
				if (num != 0)
				{
				}
				num = (short)585367552;
				if (num != 0)
				{
				}
				this.dVRSWideGeneralInCarMonitor_A41799.HiddenStatic = value;
			}
		}

		// Token: 0x17004F5C RID: 20316
		// (get) Token: 0x06009E09 RID: 40457 RVA: 0x0093976C File Offset: 0x0093796C
		// (set) Token: 0x06009E0A RID: 40458 RVA: 0x00939820 File Offset: 0x00937A20
		internal bool DVRSWideGeneralInCarMonitor_A41799_HiddenDynamic
		{
			get
			{
				short num = (short)1540720611;
				short num2 = num;
				num = (short)1278445539;
				switch (num2 == num)
				{
				default:
				{
					num = (short)541196288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1266941953;
				if (num != 0)
				{
				}
				num = (short)810680320;
				if (num != 0)
				{
				}
				return this.dVRSWideGeneralInCarMonitor_A41799.HiddenDynamic;
			}
			set
			{
				short num = (short)1164547408;
				short num2 = num;
				num = (short)1842845008;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1150287872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1437728769;
				if (num != 0)
				{
				}
				num = (short)1680277504;
				if (num != 0)
				{
				}
				this.dVRSWideGeneralInCarMonitor_A41799.HiddenDynamic = value;
			}
		}

		// Token: 0x17004F5D RID: 20317
		// (get) Token: 0x06009E0B RID: 40459 RVA: 0x009398D8 File Offset: 0x00937AD8
		public bool DVRSWideGeneralInCarMonitor_A41799_HasDiffs
		{
			get
			{
				short num = (short)341916934;
				short num2 = num;
				num = (short)618675462;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1820393472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2621441;
				if (num != 0)
				{
				}
				num = (short)584384512;
				if (num != 0)
				{
				}
				return this.dVRSWideGeneralInCarMonitor_A41799._HasDiffs;
			}
		}

		// Token: 0x17004F5E RID: 20318
		// (get) Token: 0x06009E0C RID: 40460 RVA: 0x0093998C File Offset: 0x00937B8C
		// (set) Token: 0x06009E0D RID: 40461 RVA: 0x00939A40 File Offset: 0x00937C40
		public long DVRSWideLabtoolDVRSSyncFieldsHash_A41811Value
		{
			get
			{
				short num = (short)1572864001;
				if (num != 0)
				{
				}
				num = (short)1551892480;
				short num2 = num;
				num = (short)1598814549;
				short num3 = num;
				num = (short)1487927637;
				switch (num3 == num)
				{
				}
				num = (short)120520704;
				if (num != 0)
				{
				}
				return this.dVRSWideLabtoolDVRSSyncFieldsHash_A41811.Value;
			}
			set
			{
				short num = (short)1013051778;
				short num2 = num;
				num = (short)1620570498;
				switch (num2 == num)
				{
				default:
				{
					num = (short)568852480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)869924865;
				if (num != 0)
				{
				}
				num = (short)70516736;
				if (num != 0)
				{
				}
				this.dVRSWideLabtoolDVRSSyncFieldsHash_A41811.Value = value;
			}
		}

		// Token: 0x17004F5F RID: 20319
		// (get) Token: 0x06009E0E RID: 40462 RVA: 0x00939AF4 File Offset: 0x00937CF4
		public global::AcpBusinessLayer.AcpField<long> DVRSWideLabtoolDVRSSyncFieldsHash_A41811
		{
			get
			{
				short num = (short)2139574032;
				short num2 = num;
				num = (short)1088048912;
				switch (num2 == num)
				{
				default:
				{
					num = (short)378994688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1436286976;
				if (num != 0)
				{
				}
				num = (short)720699393;
				if (num != 0)
				{
				}
				return this.dVRSWideLabtoolDVRSSyncFieldsHash_A41811;
			}
		}

		// Token: 0x17004F60 RID: 20320
		// (get) Token: 0x06009E0F RID: 40463 RVA: 0x00939BA0 File Offset: 0x00937DA0
		// (set) Token: 0x06009E10 RID: 40464 RVA: 0x00939C58 File Offset: 0x00937E58
		public long DVRSWideLabtoolDVRSSyncFieldsHash_A41811_UIValue
		{
			get
			{
				short num = (short)1717711033;
				short num2 = num;
				num = (short)533868729;
				switch (num2 == num)
				{
				default:
				{
					num = (short)882966528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)168493056;
				if (num != 0)
				{
				}
				num = (short)709951489;
				if (num != 0)
				{
				}
				return this.dVRSWideLabtoolDVRSSyncFieldsHash_A41811.Value;
			}
			set
			{
				short num = (short)186671093;
				short num2 = num;
				num = (short)1650155509;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2099052544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1513750529;
				if (num != 0)
				{
				}
				num = (short)1791688704;
				if (num != 0)
				{
				}
				this.dVRSWideLabtoolDVRSSyncFieldsHash_A41811.Value = value;
			}
		}

		// Token: 0x17004F61 RID: 20321
		// (get) Token: 0x06009E11 RID: 40465 RVA: 0x00939D10 File Offset: 0x00937F10
		// (set) Token: 0x06009E12 RID: 40466 RVA: 0x00939DC4 File Offset: 0x00937FC4
		public bool DVRSWideLabtoolDVRSSyncFieldsHash_A41811_Applicable
		{
			get
			{
				short num = (short)94860754;
				short num2 = num;
				num = (short)2056156626;
				switch (num2 == num)
				{
				default:
				{
					num = (short)961675264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)942604288;
				if (num != 0)
				{
				}
				num = (short)207618049;
				if (num != 0)
				{
				}
				return this.dVRSWideLabtoolDVRSSyncFieldsHash_A41811.Applicable;
			}
			set
			{
				short num = (short)983289514;
				short num2 = num;
				num = (short)1376964266;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1638203392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)297402369;
				if (num != 0)
				{
				}
				num = (short)146276352;
				if (num != 0)
				{
				}
				this.dVRSWideLabtoolDVRSSyncFieldsHash_A41811.Applicable = value;
			}
		}

		// Token: 0x17004F62 RID: 20322
		// (get) Token: 0x06009E13 RID: 40467 RVA: 0x00939E7C File Offset: 0x0093807C
		// (set) Token: 0x06009E14 RID: 40468 RVA: 0x00939F30 File Offset: 0x00938130
		public bool DVRSWideLabtoolDVRSSyncFieldsHash_A41811_Valid
		{
			get
			{
				short num = (short)1899036673;
				if (num != 0)
				{
				}
				num = (short)1952907264;
				short num2 = num;
				num = (short)620689631;
				short num3 = num;
				num = (short)1133115615;
				switch (num3 == num)
				{
				}
				num = (short)1275265024;
				if (num != 0)
				{
				}
				return this.dVRSWideLabtoolDVRSSyncFieldsHash_A41811.Valid;
			}
			set
			{
				short num = (short)1637415545;
				short num2 = num;
				num = (short)1765538425;
				switch (num2 == num)
				{
				default:
				{
					num = (short)224264192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)650641408;
				if (num != 0)
				{
				}
				num = (short)1385955329;
				if (num != 0)
				{
				}
				this.dVRSWideLabtoolDVRSSyncFieldsHash_A41811.Valid = value;
			}
		}

		// Token: 0x17004F63 RID: 20323
		// (get) Token: 0x06009E15 RID: 40469 RVA: 0x00939FE8 File Offset: 0x009381E8
		// (set) Token: 0x06009E16 RID: 40470 RVA: 0x0093A09C File Offset: 0x0093829C
		public bool DVRSWideLabtoolDVRSSyncFieldsHash_A41811_Visible
		{
			get
			{
				short num = (short)873237288;
				short num2 = num;
				num = (short)1596492584;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1935605760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)326762496;
				if (num != 0)
				{
				}
				num = (short)977666049;
				if (num != 0)
				{
				}
				return this.dVRSWideLabtoolDVRSSyncFieldsHash_A41811.Visible;
			}
			set
			{
				short num = (short)1080292873;
				short num2 = num;
				num = (short)45151753;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1169686528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)489160704;
				if (num != 0)
				{
				}
				num = (short)1123876865;
				if (num != 0)
				{
				}
				this.dVRSWideLabtoolDVRSSyncFieldsHash_A41811.Visible = value;
			}
		}

		// Token: 0x17004F64 RID: 20324
		// (get) Token: 0x06009E17 RID: 40471 RVA: 0x0093A150 File Offset: 0x00938350
		// (set) Token: 0x06009E18 RID: 40472 RVA: 0x0093A204 File Offset: 0x00938404
		public bool DVRSWideLabtoolDVRSSyncFieldsHash_A41811_Editable
		{
			get
			{
				short num = (short)213057455;
				short num2 = num;
				num = (short)201064367;
				switch (num2 == num)
				{
				}
				num = (short)1795227648;
				if (num != 0)
				{
				}
				num = (short)1981874176;
				short num3 = num;
				num = (short)280690689;
				if (num != 0)
				{
				}
				return this.dVRSWideLabtoolDVRSSyncFieldsHash_A41811.Editable;
			}
			set
			{
				short num = (short)334155264;
				short num2 = num;
				num = (short)1643236864;
				switch (num2 == num)
				{
				}
				num = (short)2109603841;
				if (num != 0)
				{
				}
				num = (short)843382784;
				short num3 = num;
				num = (short)1100808192;
				if (num != 0)
				{
				}
				this.dVRSWideLabtoolDVRSSyncFieldsHash_A41811.Editable = value;
			}
		}

		// Token: 0x17004F65 RID: 20325
		// (get) Token: 0x06009E19 RID: 40473 RVA: 0x0093A2BC File Offset: 0x009384BC
		internal string DVRSWideLabtoolDVRSSyncFieldsHash_A41811_UILabel
		{
			get
			{
				short num = (short)1251823652;
				short num2 = num;
				num = (short)1413173284;
				switch (num2 == num)
				{
				}
				num = (short)541065216;
				if (num != 0)
				{
				}
				num = (short)1036713984;
				short num3 = num;
				num = (short)766443521;
				if (num != 0)
				{
				}
				return this.dVRSWideLabtoolDVRSSyncFieldsHash_A41811.UIName;
			}
		}

		// Token: 0x17004F66 RID: 20326
		// (get) Token: 0x06009E1A RID: 40474 RVA: 0x0093A370 File Offset: 0x00938570
		// (set) Token: 0x06009E1B RID: 40475 RVA: 0x0093A428 File Offset: 0x00938628
		internal bool DVRSWideLabtoolDVRSSyncFieldsHash_A41811_HiddenStatic
		{
			get
			{
				short num = (short)541065217;
				if (num != 0)
				{
				}
				num = (short)497764127;
				short num2 = num;
				num = (short)2004764447;
				switch (num2 == num)
				{
				}
				num = (short)834732032;
				short num3 = num;
				num = (short)1192165376;
				if (num != 0)
				{
				}
				return this.dVRSWideLabtoolDVRSSyncFieldsHash_A41811.HiddenStatic;
			}
			set
			{
				short num = (short)1830256252;
				short num2 = num;
				num = (short)2030075516;
				switch (num2 == num)
				{
				}
				num = (short)309264385;
				if (num != 0)
				{
				}
				num = (short)499580928;
				short num3 = num;
				num = (short)133890048;
				if (num != 0)
				{
				}
				this.dVRSWideLabtoolDVRSSyncFieldsHash_A41811.HiddenStatic = value;
			}
		}

		// Token: 0x17004F67 RID: 20327
		// (get) Token: 0x06009E1C RID: 40476 RVA: 0x0093A4DC File Offset: 0x009386DC
		// (set) Token: 0x06009E1D RID: 40477 RVA: 0x0093A594 File Offset: 0x00938794
		internal bool DVRSWideLabtoolDVRSSyncFieldsHash_A41811_HiddenDynamic
		{
			get
			{
				short num = (short)1911021005;
				short num2 = num;
				num = (short)2078596557;
				switch (num2 == num)
				{
				}
				num = (short)827457537;
				if (num != 0)
				{
				}
				num = (short)1001521152;
				short num3 = num;
				num = (short)226951168;
				if (num != 0)
				{
				}
				return this.dVRSWideLabtoolDVRSSyncFieldsHash_A41811.HiddenDynamic;
			}
			set
			{
				short num = (short)1420820481;
				if (num != 0)
				{
				}
				num = (short)1968815481;
				short num2 = num;
				num = (short)1986510201;
				switch (num2 == num)
				{
				}
				num = (short)53346304;
				short num3 = num;
				num = (short)406781952;
				if (num != 0)
				{
				}
				this.dVRSWideLabtoolDVRSSyncFieldsHash_A41811.HiddenDynamic = value;
			}
		}

		// Token: 0x17004F68 RID: 20328
		// (get) Token: 0x06009E1E RID: 40478 RVA: 0x0093A648 File Offset: 0x00938848
		public bool DVRSWideLabtoolDVRSSyncFieldsHash_A41811_HasDiffs
		{
			get
			{
				short num = (short)1358549722;
				short num2 = num;
				num = (short)85709530;
				switch (num2 == num)
				{
				}
				num = (short)2146172928;
				if (num != 0)
				{
				}
				num = (short)1808793600;
				short num3 = num;
				num = (short)310247425;
				if (num != 0)
				{
				}
				return this.dVRSWideLabtoolDVRSSyncFieldsHash_A41811._HasDiffs;
			}
		}

		// Token: 0x17004F69 RID: 20329
		// (get) Token: 0x06009E1F RID: 40479 RVA: 0x0093A6FC File Offset: 0x009388FC
		// (set) Token: 0x06009E20 RID: 40480 RVA: 0x0093A7B0 File Offset: 0x009389B0
		public int DVRSWideLabtoolVrId_A43727Value
		{
			get
			{
				short num = (short)372965377;
				if (num != 0)
				{
				}
				num = (short)403572258;
				short num2 = num;
				num = (short)1997538850;
				switch (num2 == num)
				{
				}
				num = (short)1740505088;
				short num3 = num;
				num = (short)165871616;
				if (num != 0)
				{
				}
				return this.dVRSWideLabtoolVrId_A43727.Value;
			}
			set
			{
				short num = (short)594024382;
				short num2 = num;
				num = (short)1080104894;
				switch (num2 == num)
				{
				}
				num = (short)1226244097;
				if (num != 0)
				{
				}
				num = (short)408289280;
				short num3 = num;
				num = (short)228917248;
				if (num != 0)
				{
				}
				this.dVRSWideLabtoolVrId_A43727.Value = value;
			}
		}

		// Token: 0x17004F6A RID: 20330
		// (get) Token: 0x06009E21 RID: 40481 RVA: 0x0093A864 File Offset: 0x00938A64
		public global::AcpBusinessLayer.AcpSimpleRangeField DVRSWideLabtoolVrId_A43727
		{
			get
			{
				short num = (short)966935841;
				short num2 = num;
				num = (short)1658078497;
				switch (num2 == num)
				{
				}
				num = (short)1684275200;
				if (num != 0)
				{
				}
				num = (short)1093206016;
				short num3 = num;
				num = (short)308477953;
				if (num != 0)
				{
				}
				return this.dVRSWideLabtoolVrId_A43727;
			}
		}

		// Token: 0x17004F6B RID: 20331
		// (get) Token: 0x06009E22 RID: 40482 RVA: 0x0093A914 File Offset: 0x00938B14
		// (set) Token: 0x06009E23 RID: 40483 RVA: 0x0093A9C8 File Offset: 0x00938BC8
		public int DVRSWideLabtoolVrId_A43727_UIValue
		{
			get
			{
				short num = (short)1298595841;
				if (num != 0)
				{
				}
				num = (short)1210163265;
				short num2 = num;
				num = (short)6791233;
				switch (num2 == num)
				{
				}
				num = (short)940244992;
				short num3 = num;
				num = (short)1097400320;
				if (num != 0)
				{
				}
				return this.dVRSWideLabtoolVrId_A43727.Value;
			}
			set
			{
				short num = (short)20068132;
				short num2 = num;
				num = (short)1046230820;
				switch (num2 == num)
				{
				}
				num = (short)2099904513;
				if (num != 0)
				{
				}
				num = (short)1327366144;
				short num3 = num;
				num = (short)472645632;
				if (num != 0)
				{
				}
				this.dVRSWideLabtoolVrId_A43727.Value = value;
			}
		}

		// Token: 0x17004F6C RID: 20332
		// (get) Token: 0x06009E24 RID: 40484 RVA: 0x0093AA80 File Offset: 0x00938C80
		// (set) Token: 0x06009E25 RID: 40485 RVA: 0x0093AB34 File Offset: 0x00938D34
		public string DVRSWideLabtoolVrId_A43727_HexUIValue
		{
			get
			{
				short num = (short)1348116617;
				short num2 = num;
				num = (short)1679925385;
				switch (num2 == num)
				{
				}
				num = (short)1260978177;
				if (num != 0)
				{
				}
				num = (short)515178496;
				short num3 = num;
				num = (short)1092878336;
				if (num != 0)
				{
				}
				return this.dVRSWideLabtoolVrId_A43727.HexUIValue;
			}
			set
			{
				short num = (short)740543613;
				short num2 = num;
				num = (short)179948669;
				switch (num2 == num)
				{
				}
				num = (short)1066074113;
				if (num != 0)
				{
				}
				num = (short)490274816;
				short num3 = num;
				num = (short)2049441792;
				if (num != 0)
				{
				}
				this.dVRSWideLabtoolVrId_A43727.HexUIValue = value;
			}
		}

		// Token: 0x17004F6D RID: 20333
		// (get) Token: 0x06009E26 RID: 40486 RVA: 0x0093ABE8 File Offset: 0x00938DE8
		// (set) Token: 0x06009E27 RID: 40487 RVA: 0x0093ACA0 File Offset: 0x00938EA0
		public bool DVRSWideLabtoolVrId_A43727_Applicable
		{
			get
			{
				short num = (short)1395977317;
				short num2 = num;
				num = (short)1221323877;
				switch (num2 == num)
				{
				}
				num = (short)319160320;
				if (num != 0)
				{
				}
				num = (short)1691156480;
				short num3 = num;
				num = (short)1039204353;
				if (num != 0)
				{
				}
				return this.dVRSWideLabtoolVrId_A43727.Applicable;
			}
			set
			{
				short num = (short)1687097511;
				short num2 = num;
				num = (short)2115899559;
				switch (num2 == num)
				{
				}
				num = (short)1660878849;
				if (num != 0)
				{
				}
				num = (short)97189888;
				short num3 = num;
				num = (short)77332480;
				if (num != 0)
				{
				}
				this.dVRSWideLabtoolVrId_A43727.Applicable = value;
			}
		}

		// Token: 0x17004F6E RID: 20334
		// (get) Token: 0x06009E28 RID: 40488 RVA: 0x0093AD54 File Offset: 0x00938F54
		// (set) Token: 0x06009E29 RID: 40489 RVA: 0x0093AE08 File Offset: 0x00939008
		public bool DVRSWideLabtoolVrId_A43727_Valid
		{
			get
			{
				short num = (short)325960670;
				short num2 = num;
				num = (short)1257882590;
				switch (num2 == num)
				{
				}
				num = (short)216793088;
				if (num != 0)
				{
				}
				num = (short)1032257536;
				short num3 = num;
				num = (short)2039873537;
				if (num != 0)
				{
				}
				return this.dVRSWideLabtoolVrId_A43727.Valid;
			}
			set
			{
				short num = (short)380536106;
				short num2 = num;
				num = (short)1350272298;
				switch (num2 == num)
				{
				}
				num = (short)4653056;
				if (num != 0)
				{
				}
				num = (short)899350528;
				short num3 = num;
				num = (short)145620993;
				if (num != 0)
				{
				}
				this.dVRSWideLabtoolVrId_A43727.Valid = value;
			}
		}

		// Token: 0x17004F6F RID: 20335
		// (get) Token: 0x06009E2A RID: 40490 RVA: 0x0093AEBC File Offset: 0x009390BC
		// (set) Token: 0x06009E2B RID: 40491 RVA: 0x0093AF70 File Offset: 0x00939170
		public bool DVRSWideLabtoolVrId_A43727_Visible
		{
			get
			{
				short num = (short)1405307177;
				short num2 = num;
				num = (short)173164841;
				switch (num2 == num)
				{
				}
				num = (short)1854275584;
				if (num != 0)
				{
				}
				num = (short)1687289856;
				short num3 = num;
				num = (short)267649025;
				if (num != 0)
				{
				}
				return this.dVRSWideLabtoolVrId_A43727.Visible;
			}
			set
			{
				short num = (short)552318653;
				short num2 = num;
				num = (short)1370011325;
				switch (num2 == num)
				{
				}
				num = (short)1076625409;
				if (num != 0)
				{
				}
				num = (short)533594112;
				short num3 = num;
				num = (short)387186688;
				if (num != 0)
				{
				}
				this.dVRSWideLabtoolVrId_A43727.Visible = value;
			}
		}

		// Token: 0x17004F70 RID: 20336
		// (get) Token: 0x06009E2C RID: 40492 RVA: 0x0093B028 File Offset: 0x00939228
		// (set) Token: 0x06009E2D RID: 40493 RVA: 0x0093B0E0 File Offset: 0x009392E0
		public bool DVRSWideLabtoolVrId_A43727_Editable
		{
			get
			{
				short num = (short)1551610484;
				short num2 = num;
				num = (short)929280628;
				switch (num2 == num)
				{
				}
				num = (short)1524891648;
				if (num != 0)
				{
				}
				num = (short)1364262912;
				short num3 = num;
				num = (short)1642397697;
				if (num != 0)
				{
				}
				return this.dVRSWideLabtoolVrId_A43727.Editable;
			}
			set
			{
				short num = (short)126732964;
				short num2 = num;
				num = (short)1114753700;
				switch (num2 == num)
				{
				}
				num = (short)1664024576;
				if (num != 0)
				{
				}
				num = (short)304283648;
				short num3 = num;
				num = (short)1993277441;
				if (num != 0)
				{
				}
				this.dVRSWideLabtoolVrId_A43727.Editable = value;
			}
		}

		// Token: 0x17004F71 RID: 20337
		// (get) Token: 0x06009E2E RID: 40494 RVA: 0x0093B198 File Offset: 0x00939398
		internal string DVRSWideLabtoolVrId_A43727_UILabel
		{
			get
			{
				short num = (short)2041951677;
				short num2 = num;
				num = (short)1003140541;
				switch (num2 == num)
				{
				}
				num = (short)1564475393;
				if (num != 0)
				{
				}
				num = (short)978780160;
				short num3 = num;
				num = (short)854196224;
				if (num != 0)
				{
				}
				return this.dVRSWideLabtoolVrId_A43727.UIName;
			}
		}

		// Token: 0x17004F72 RID: 20338
		// (get) Token: 0x06009E2F RID: 40495 RVA: 0x0093B24C File Offset: 0x0093944C
		// (set) Token: 0x06009E30 RID: 40496 RVA: 0x0093B304 File Offset: 0x00939504
		internal bool DVRSWideLabtoolVrId_A43727_HiddenStatic
		{
			get
			{
				short num = (short)288424912;
				short num2 = num;
				num = (short)1329005520;
				switch (num2 == num)
				{
				}
				num = (short)1375010817;
				if (num != 0)
				{
				}
				num = (short)440664064;
				short num3 = num;
				num = (short)1281556480;
				if (num != 0)
				{
				}
				return this.dVRSWideLabtoolVrId_A43727.HiddenStatic;
			}
			set
			{
				short num = (short)702339933;
				short num2 = num;
				num = (short)214293341;
				switch (num2 == num)
				{
				}
				num = (short)386334720;
				if (num != 0)
				{
				}
				num = (short)1830420480;
				short num3 = num;
				num = (short)1803288577;
				if (num != 0)
				{
				}
				this.dVRSWideLabtoolVrId_A43727.HiddenStatic = value;
			}
		}

		// Token: 0x17004F73 RID: 20339
		// (get) Token: 0x06009E31 RID: 40497 RVA: 0x0093B3B8 File Offset: 0x009395B8
		// (set) Token: 0x06009E32 RID: 40498 RVA: 0x0093B46C File Offset: 0x0093966C
		internal bool DVRSWideLabtoolVrId_A43727_HiddenDynamic
		{
			get
			{
				short num = (short)328023758;
				short num2 = num;
				num = (short)1453080270;
				switch (num2 == num)
				{
				}
				num = (short)1102774273;
				if (num != 0)
				{
				}
				num = (short)1605763072;
				short num3 = num;
				num = (short)1038221312;
				if (num != 0)
				{
				}
				return this.dVRSWideLabtoolVrId_A43727.HiddenDynamic;
			}
			set
			{
				short num = (short)1567798136;
				short num2 = num;
				num = (short)1079292792;
				switch (num2 == num)
				{
				}
				num = (short)1426784257;
				if (num != 0)
				{
				}
				num = (short)1223622656;
				short num3 = num;
				num = (short)1138753536;
				if (num != 0)
				{
				}
				this.dVRSWideLabtoolVrId_A43727.HiddenDynamic = value;
			}
		}

		// Token: 0x17004F74 RID: 20340
		// (get) Token: 0x06009E33 RID: 40499 RVA: 0x0093B524 File Offset: 0x00939724
		public bool DVRSWideLabtoolVrId_A43727_HasDiffs
		{
			get
			{
				short num = (short)1286102080;
				short num2 = num;
				num = (short)641948736;
				switch (num2 == num)
				{
				}
				num = (short)1307574272;
				if (num != 0)
				{
				}
				num = (short)140705792;
				short num3 = num;
				num = (short)1515978753;
				if (num != 0)
				{
				}
				return this.dVRSWideLabtoolVrId_A43727._HasDiffs;
			}
		}

		// Token: 0x17004F75 RID: 20341
		// (get) Token: 0x06009E34 RID: 40500 RVA: 0x0093B5D8 File Offset: 0x009397D8
		// (set) Token: 0x06009E35 RID: 40501 RVA: 0x0093B68C File Offset: 0x0093988C
		public bool DVRSWideGeneralChannelOnlyDisplay_A41811Value
		{
			get
			{
				short num = (short)828935248;
				short num2 = num;
				num = (short)1954647120;
				switch (num2 == num)
				{
				}
				num = (short)366346241;
				if (num != 0)
				{
				}
				num = (short)1633157120;
				short num3 = num;
				num = (short)310247424;
				if (num != 0)
				{
				}
				return this.dVRSWideGeneralChannelOnlyDisplay_A41811.Value;
			}
			set
			{
				short num = (short)1367158505;
				short num2 = num;
				num = (short)440479465;
				switch (num2 == num)
				{
				}
				num = (short)519307265;
				if (num != 0)
				{
				}
				num = (short)1223688192;
				short num3 = num;
				num = (short)1779957760;
				if (num != 0)
				{
				}
				this.dVRSWideGeneralChannelOnlyDisplay_A41811.Value = value;
			}
		}

		// Token: 0x17004F76 RID: 20342
		// (get) Token: 0x06009E36 RID: 40502 RVA: 0x0093B740 File Offset: 0x00939940
		public global::AcpBusinessLayer.AcpField<bool> DVRSWideGeneralChannelOnlyDisplay_A41811
		{
			get
			{
				short num = (short)29935765;
				short num2 = num;
				num = (short)43174037;
				switch (num2 == num)
				{
				}
				num = (short)248578049;
				if (num != 0)
				{
				}
				num = (short)165216256;
				short num3 = num;
				num = (short)1373044736;
				if (num != 0)
				{
				}
				return this.dVRSWideGeneralChannelOnlyDisplay_A41811;
			}
		}

		// Token: 0x17004F77 RID: 20343
		// (get) Token: 0x06009E37 RID: 40503 RVA: 0x0093B7F0 File Offset: 0x009399F0
		// (set) Token: 0x06009E38 RID: 40504 RVA: 0x0093B8A4 File Offset: 0x00939AA4
		public bool DVRSWideGeneralChannelOnlyDisplay_A41811_UIValue
		{
			get
			{
				short num = (short)917044369;
				short num2 = num;
				num = (short)618069137;
				switch (num2 == num)
				{
				}
				num = (short)1044578304;
				if (num != 0)
				{
				}
				num = (short)805175296;
				short num3 = num;
				num = (short)1047724033;
				if (num != 0)
				{
				}
				return this.dVRSWideGeneralChannelOnlyDisplay_A41811.Value;
			}
			set
			{
				short num = (short)1905266719;
				short num2 = num;
				num = (short)450760735;
				switch (num2 == num)
				{
				}
				num = (short)586547201;
				if (num != 0)
				{
				}
				num = (short)1212350464;
				short num3 = num;
				num = (short)166920192;
				if (num != 0)
				{
				}
				this.dVRSWideGeneralChannelOnlyDisplay_A41811.Value = value;
			}
		}

		// Token: 0x17004F78 RID: 20344
		// (get) Token: 0x06009E39 RID: 40505 RVA: 0x0093B958 File Offset: 0x00939B58
		// (set) Token: 0x06009E3A RID: 40506 RVA: 0x0093BA0C File Offset: 0x00939C0C
		public bool DVRSWideGeneralChannelOnlyDisplay_A41811_Applicable
		{
			get
			{
				short num = (short)2099339692;
				short num2 = num;
				num = (short)445014444;
				switch (num2 == num)
				{
				}
				num = (short)1837694976;
				if (num != 0)
				{
				}
				num = (short)1686896640;
				short num3 = num;
				num = (short)1767178241;
				if (num != 0)
				{
				}
				return this.dVRSWideGeneralChannelOnlyDisplay_A41811.Applicable;
			}
			set
			{
				short num = (short)1056566884;
				short num2 = num;
				num = (short)1263201892;
				switch (num2 == num)
				{
				}
				num = (short)755957760;
				if (num != 0)
				{
				}
				num = (short)133300224;
				short num3 = num;
				num = (short)633733121;
				if (num != 0)
				{
				}
				this.dVRSWideGeneralChannelOnlyDisplay_A41811.Applicable = value;
			}
		}

		// Token: 0x17004F79 RID: 20345
		// (get) Token: 0x06009E3B RID: 40507 RVA: 0x0093BAC0 File Offset: 0x00939CC0
		// (set) Token: 0x06009E3C RID: 40508 RVA: 0x0093BB74 File Offset: 0x00939D74
		public bool DVRSWideGeneralChannelOnlyDisplay_A41811_Valid
		{
			get
			{
				short num = (short)76370847;
				short num2 = num;
				num = (short)1101353887;
				switch (num2 == num)
				{
				}
				num = (short)1025310721;
				if (num != 0)
				{
				}
				num = (short)1674838016;
				short num3 = num;
				num = (short)1371799552;
				if (num != 0)
				{
				}
				return this.dVRSWideGeneralChannelOnlyDisplay_A41811.Valid;
			}
			set
			{
				short num = (short)629791903;
				short num2 = num;
				num = (short)1422253215;
				switch (num2 == num)
				{
				}
				num = (short)1225785345;
				if (num != 0)
				{
				}
				num = (short)1014890496;
				short num3 = num;
				num = (short)220135424;
				if (num != 0)
				{
				}
				this.dVRSWideGeneralChannelOnlyDisplay_A41811.Valid = value;
			}
		}

		// Token: 0x17004F7A RID: 20346
		// (get) Token: 0x06009E3D RID: 40509 RVA: 0x0093BC28 File Offset: 0x00939E28
		// (set) Token: 0x06009E3E RID: 40510 RVA: 0x0093BCE0 File Offset: 0x00939EE0
		public bool DVRSWideGeneralChannelOnlyDisplay_A41811_Visible
		{
			get
			{
				short num = (short)609807786;
				short num2 = num;
				num = (short)108653994;
				switch (num2 == num)
				{
				}
				num = (short)543555584;
				if (num != 0)
				{
				}
				num = (short)1702821888;
				short num3 = num;
				num = (short)1986199553;
				if (num != 0)
				{
				}
				return this.dVRSWideGeneralChannelOnlyDisplay_A41811.Visible;
			}
			set
			{
				short num = (short)1635845930;
				short num2 = num;
				num = (short)815728426;
				switch (num2 == num)
				{
				}
				num = (short)1399062528;
				short num3 = num;
				num = (short)882114561;
				if (num != 0)
				{
				}
				num = (short)50987008;
				if (num != 0)
				{
				}
				this.dVRSWideGeneralChannelOnlyDisplay_A41811.Visible = value;
			}
		}

		// Token: 0x17004F7B RID: 20347
		// (get) Token: 0x06009E3F RID: 40511 RVA: 0x0093BD94 File Offset: 0x00939F94
		// (set) Token: 0x06009E40 RID: 40512 RVA: 0x0093BE48 File Offset: 0x0093A048
		public bool DVRSWideGeneralChannelOnlyDisplay_A41811_Editable
		{
			get
			{
				short num = (short)1536230229;
				short num2 = num;
				num = (short)856359765;
				switch (num2 == num)
				{
				}
				num = (short)10158080;
				short num3 = num;
				num = (short)824115201;
				if (num != 0)
				{
				}
				num = (short)1685520384;
				if (num != 0)
				{
				}
				return this.dVRSWideGeneralChannelOnlyDisplay_A41811.Editable;
			}
			set
			{
				short num = (short)1611183368;
				short num2 = num;
				num = (short)1541453064;
				switch (num2 == num)
				{
				}
				num = (short)1057226752;
				short num3 = num;
				num = (short)1895563265;
				if (num != 0)
				{
				}
				num = (short)708837376;
				if (num != 0)
				{
				}
				this.dVRSWideGeneralChannelOnlyDisplay_A41811.Editable = value;
			}
		}

		// Token: 0x17004F7C RID: 20348
		// (get) Token: 0x06009E41 RID: 40513 RVA: 0x0093BF00 File Offset: 0x0093A100
		internal string DVRSWideGeneralChannelOnlyDisplay_A41811_UILabel
		{
			get
			{
				short num = (short)409505581;
				short num2 = num;
				num = (short)1413189421;
				switch (num2 == num)
				{
				}
				num = (short)1096417280;
				short num3 = num;
				num = (short)1999306753;
				if (num != 0)
				{
				}
				num = (short)1945108480;
				if (num != 0)
				{
				}
				return this.dVRSWideGeneralChannelOnlyDisplay_A41811.UIName;
			}
		}

		// Token: 0x17004F7D RID: 20349
		// (get) Token: 0x06009E42 RID: 40514 RVA: 0x0093BFB8 File Offset: 0x0093A1B8
		// (set) Token: 0x06009E43 RID: 40515 RVA: 0x0093C06C File Offset: 0x0093A26C
		internal bool DVRSWideGeneralChannelOnlyDisplay_A41811_HiddenStatic
		{
			get
			{
				short num = (short)158278984;
				short num2 = num;
				num = (short)958604616;
				switch (num2 == num)
				{
				}
				num = (short)422772736;
				short num3 = num;
				num = (short)1571225601;
				if (num != 0)
				{
				}
				num = (short)380633088;
				if (num != 0)
				{
				}
				return this.dVRSWideGeneralChannelOnlyDisplay_A41811.HiddenStatic;
			}
			set
			{
				short num = (short)1617146931;
				short num2 = num;
				num = (short)866300979;
				switch (num2 == num)
				{
				}
				num = (short)609550336;
				short num3 = num;
				num = (short)15400961;
				if (num != 0)
				{
				}
				num = (short)1142161408;
				if (num != 0)
				{
				}
				this.dVRSWideGeneralChannelOnlyDisplay_A41811.HiddenStatic = value;
			}
		}

		// Token: 0x17004F7E RID: 20350
		// (get) Token: 0x06009E44 RID: 40516 RVA: 0x0093C120 File Offset: 0x0093A320
		// (set) Token: 0x06009E45 RID: 40517 RVA: 0x0093C1D4 File Offset: 0x0093A3D4
		internal bool DVRSWideGeneralChannelOnlyDisplay_A41811_HiddenDynamic
		{
			get
			{
				short num = (short)356733248;
				short num2 = num;
				num = (short)1265127744;
				switch (num2 == num)
				{
				}
				num = (short)64815104;
				short num3 = num;
				num = (short)802095105;
				if (num != 0)
				{
				}
				num = (short)1316225024;
				if (num != 0)
				{
				}
				return this.dVRSWideGeneralChannelOnlyDisplay_A41811.HiddenDynamic;
			}
			set
			{
				short num = (short)2019885057;
				if (num != 0)
				{
				}
				num = (short)457054188;
				short num2 = num;
				num = (short)1232607212;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1963655168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1212481536;
				if (num != 0)
				{
				}
				this.dVRSWideGeneralChannelOnlyDisplay_A41811.HiddenDynamic = value;
			}
		}

		// Token: 0x17004F7F RID: 20351
		// (get) Token: 0x06009E46 RID: 40518 RVA: 0x0093C28C File Offset: 0x0093A48C
		public bool DVRSWideGeneralChannelOnlyDisplay_A41811_HasDiffs
		{
			get
			{
				short num = (short)1132367920;
				short num2 = num;
				num = (short)370839600;
				switch (num2 == num)
				{
				}
				num = (short)262733824;
				short num3 = num;
				num = (short)724631553;
				if (num != 0)
				{
				}
				num = (short)891027456;
				if (num != 0)
				{
				}
				return this.dVRSWideGeneralChannelOnlyDisplay_A41811._HasDiffs;
			}
		}

		// Token: 0x17004F80 RID: 20352
		// (get) Token: 0x06009E47 RID: 40519 RVA: 0x0093C344 File Offset: 0x0093A544
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)804033400;
				short num2 = num;
				num = (short)539988856;
				switch (num2 == num)
				{
				}
				num = (short)1232470016;
				short num3 = num;
				num = (short)1990328320;
				if (num != 0)
				{
				}
				num = (short)1031340033;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x06009E48 RID: 40520 RVA: 0x0093C408 File Offset: 0x0093A608
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_98;
			}
			short num;
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				num = (short)702808065;
				if (num != 0)
				{
				}
				num = (short)1048807789;
				short num2 = num;
				num = (short)137922925;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1689387008;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						return result;
					case 1:
						if (base.ParentRecset != null)
						{
							num = (short)2009071619;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
					{
						num = (short)1301413888;
						short num4 = num;
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						goto IL_111;
					}
					case 3:
						num = (short)699269124;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)194772994;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					goto IL_98;
				}
				IL_111:
				num = (short)1426587648;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_98:
			result = null;
			num = (short)744685569;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x04004D4C RID: 19788
		private global::AcpBusinessLayer.AcpField<bool> radWideLabtoolDVRSFatalError_A7910;

		// Token: 0x04004D4D RID: 19789
		private global::AcpBusinessLayer.AcpField<bool> radErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911;

		// Token: 0x04004D4E RID: 19790
		private global::AcpBusinessLayer.AcpListField dVRSWideGeneralVIPCtrlofDVRS_A41798;

		// Token: 0x04004D4F RID: 19791
		private global::AcpBusinessLayer.AcpListField dVRSWideGeneralInCarMonitor_A41799;

		// Token: 0x04004D50 RID: 19792
		private global::AcpBusinessLayer.AcpField<long> dVRSWideLabtoolDVRSSyncFieldsHash_A41811;

		// Token: 0x04004D51 RID: 19793
		private global::AcpBusinessLayer.AcpSimpleRangeField dVRSWideLabtoolVrId_A43727;

		// Token: 0x04004D52 RID: 19794
		private global::AcpBusinessLayer.AcpField<bool> dVRSWideGeneralChannelOnlyDisplay_A41811;
	}
}
