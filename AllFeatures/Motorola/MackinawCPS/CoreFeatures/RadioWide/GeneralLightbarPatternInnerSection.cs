using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.ActionConsolidation;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x02000176 RID: 374
	[global::System.Serializable]
	public class GeneralLightbarPatternInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06003590 RID: 13712 RVA: 0x003341B4 File Offset: 0x003323B4
		public GeneralLightbarPatternInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06003591 RID: 13713 RVA: 0x003341D0 File Offset: 0x003323D0
		protected GeneralLightbarPatternInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06003592 RID: 13714 RVA: 0x003341E8 File Offset: 0x003323E8
		public override void Init()
		{
			int a_ = 19;
			short num = (short)1949515903;
			short num2 = num;
			num = (short)1896431743;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1945763840;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1892286465;
			if (num != 0)
			{
			}
			num = (short)230621184;
			if (num != 0)
			{
			}
			this.b();
			this.radWideGenLgtBarName_A36505 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟ꗡ臣裥ꓧ跩飫곭釯胱뫳韵闷鿹ꏻ뿽㏿㐁㄃㘅㴇", a_), global::CommonResources.AcgResources.ID_NAME, 14);
			this.radWideGenLgtBarName_A36505.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radWideGenLgtBarName_A36505.DataTransferOrder = 131;
			this.radWideGenLightBarPatternRelay1_A36506 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟ꗡ臣裥ꓧ菩诫蛭蓯냱闳蓵ꣷ鯹裻諽旿瀁樃吅洇昉洋眍ℏ䴑唓┕⸗⼙Ⱋ⠝", a_), global::CommonResources.AcgResources.ID_RELAY1, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideGenLightBarPatternRelay1_A36506LovStrs);
			this.radWideGenLightBarPatternRelay1_A36506.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radWideGenLightBarPatternRelay1_A36506.DataTransferOrder = 132;
			this.radWideGenLightBarPatternRelay1_A36506.ValidateAcrossRecset = true;
			this.radWideGenLightBarPatternRelay2_A36507 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟ꗡ臣裥ꓧ菩诫蛭蓯냱闳蓵ꣷ鯹裻諽旿瀁樃吅洇昉洋眍∏䴑唓┕⸗⼙Ⱋ⤝", a_), global::CommonResources.AcgResources.ID_RELAY2, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideGenLightBarPatternRelay2_A36507LovStrs);
			this.radWideGenLightBarPatternRelay2_A36507.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radWideGenLightBarPatternRelay2_A36507.DataTransferOrder = 133;
			this.radWideGenLightBarPatternRelay2_A36507.ValidateAcrossRecset = true;
			this.radWideGenLightBarPatternRelay3_A36508 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟ꗡ臣裥ꓧ菩诫蛭蓯냱闳蓵ꣷ鯹裻諽旿瀁樃吅洇昉洋眍⌏䴑唓┕⸗⼙Ⱋ☝", a_), global::CommonResources.AcgResources.ID_RELAY3, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideGenLightBarPatternRelay3_A36508LovStrs);
			this.radWideGenLightBarPatternRelay3_A36508.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radWideGenLightBarPatternRelay3_A36508.DataTransferOrder = 134;
			this.radWideGenLightBarPatternRelay3_A36508.ValidateAcrossRecset = true;
			this.radWideGenLightBarPatternRelay4_A36509 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟ꗡ臣裥ꓧ菩诫蛭蓯냱闳蓵ꣷ鯹裻諽旿瀁樃吅洇昉洋眍␏䴑唓┕⸗⼙Ⱋ✝", a_), global::CommonResources.AcgResources.ID_RELAY4, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideGenLightBarPatternRelay4_A36509LovStrs);
			this.radWideGenLightBarPatternRelay4_A36509.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radWideGenLightBarPatternRelay4_A36509.DataTransferOrder = 135;
			this.radWideGenLightBarPatternRelay4_A36509.ValidateAcrossRecset = true;
			this.radWideGenLightBarPatternRelay5_A36510 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟ꗡ臣裥ꓧ菩诫蛭蓯냱闳蓵ꣷ鯹裻諽旿瀁樃吅洇昉洋眍┏䴑唓┕⸗⼙ⴛ⸝", a_), global::CommonResources.AcgResources.ID_RELAY5, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideGenLightBarPatternRelay5_A36510LovStrs);
			this.radWideGenLightBarPatternRelay5_A36510.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radWideGenLightBarPatternRelay5_A36510.DataTransferOrder = 136;
			this.radWideGenLightBarPatternRelay5_A36510.ValidateAcrossRecset = true;
			this.radWideGenLightBarPatternRelay6_A36511 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟ꗡ臣裥ꓧ菩诫蛭蓯냱闳蓵ꣷ鯹裻諽旿瀁樃吅洇昉洋眍☏䴑唓┕⸗⼙ⴛ⼝", a_), global::CommonResources.AcgResources.ID_RELAY6, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideGenLightBarPatternRelay6_A36511LovStrs);
			this.radWideGenLightBarPatternRelay6_A36511.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radWideGenLightBarPatternRelay6_A36511.DataTransferOrder = 137;
			this.radWideGenLightBarPatternRelay6_A36511.ValidateAcrossRecset = true;
			this.radWideGenLightBarPatternRelay7_A36512 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟ꗡ臣裥ꓧ菩诫蛭蓯냱闳蓵ꣷ鯹裻諽旿瀁樃吅洇昉洋眍✏䴑唓┕⸗⼙ⴛⰝ", a_), global::CommonResources.AcgResources.ID_RELAY7, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideGenLightBarPatternRelay7_A36512LovStrs);
			this.radWideGenLightBarPatternRelay7_A36512.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radWideGenLightBarPatternRelay7_A36512.DataTransferOrder = 138;
			this.radWideGenLightBarPatternRelay7_A36512.ValidateAcrossRecset = true;
			this.radWideGenLightBarPatternRelay8_A36513 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟ꗡ臣裥ꓧ菩诫蛭蓯냱闳蓵ꣷ鯹裻諽旿瀁樃吅洇昉洋眍⠏䴑唓┕⸗⼙ⴛⴝ", a_), global::CommonResources.AcgResources.ID_RELAY8, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideGenLightBarPatternRelay8_A36513LovStrs);
			this.radWideGenLightBarPatternRelay8_A36513.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radWideGenLightBarPatternRelay8_A36513.DataTransferOrder = 139;
			this.radWideGenLightBarPatternRelay8_A36513.ValidateAcrossRecset = true;
			this.radWideGenLightBarPatternRelay9_A36515 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟ꗡ臣裥ꓧ菩诫蛭蓯냱闳蓵ꣷ鯹裻諽旿瀁樃吅洇昉洋眍⤏䴑唓┕⸗⼙ⴛ⬝", a_), global::CommonResources.AcgResources.ID_RELAY9, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideGenLightBarPatternRelay9_A36515LovStrs);
			this.radWideGenLightBarPatternRelay9_A36515.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radWideGenLightBarPatternRelay9_A36515.DataTransferOrder = 140;
			this.radWideGenLightBarPatternRelay9_A36515.ValidateAcrossRecset = true;
			this.radWideGenLightBarPatternRelay10_A36516 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蛓럕볗跙뗛뫝藟ꗡ臣裥ꓧ菩诫蛭蓯냱闳蓵ꣷ鯹裻諽旿瀁樃吅洇昉洋眍ℏ∑䬓圕⬗Ⱉ⤛⼝ᘟ", a_), global::CommonResources.AcgResources.ID_RELAY10, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideGenLightBarPatternRelay10_A36516LovStrs);
			this.radWideGenLightBarPatternRelay10_A36516.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radWideGenLightBarPatternRelay10_A36516.DataTransferOrder = 141;
			this.radWideGenLightBarPatternRelay10_A36516.ValidateAcrossRecset = true;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蛓돕듗믙ꗛﻝ냟菡郣鋥跧飩苫", a_);
			base.Id = 10605;
			base.UIName = global::CommonResources.AcgResources.ID_RELAYPATTERN;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06003593 RID: 13715 RVA: 0x00334610 File Offset: 0x00332810
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 14;
			short num = (short)1416207386;
			short num2 = num;
			num = (short)1587452954;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_888:
				if (!producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚髜뫞迠꿢賤胦臨鿪꿬軮菰ꏲ铴菶跸黺迼釾匀昂椄昆瀈㴊刌与∐┒—☖⠘", a_)))
				{
					goto IL_318;
				}
				num = (short)312148004;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1580466176;
				if (num != 0)
				{
				}
				num = (short)1335951390;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				IL_73:
				switch (num3)
				{
				case 0:
					this.radWideGenLightBarPatternRelay7_A36512 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚髜뫞迠꿢賤胦臨鿪꿬軮菰ꏲ铴菶跸黺迼釾匀昂椄昆瀈㰊刌与∐┒—☖⬘", a_), global::CommonResources.AcgResources.ID_RELAY7, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideGenLightBarPatternRelay7_A36512LovStrs);
					this.radWideGenLightBarPatternRelay7_A36512.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radWideGenLightBarPatternRelay7_A36512.DataTransferOrder = 138;
					this.radWideGenLightBarPatternRelay7_A36512.ValidateAcrossRecset = true;
					num = (short)188350487;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_519;
				case 2:
					if (producerFields != null)
					{
						num = (short)1473380374;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_981;
				case 3:
					goto IL_7BB;
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚髜뫞迠꿢賤胦臨鿪꿬軮菰ꏲ铴菶跸黺迼釾匀昂椄昆瀈㨊㴌倎倐‒⌔∖⠘ⴚ", a_)))
					{
						num = (short)1408827412;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_981;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚髜뫞迠꿢賤胦臨鿪꿬軮菰ꏲ铴菶跸黺迼釾匀昂椄昆瀈㠊刌与∐┒—✖℘", a_)))
					{
						num = (short)1136918536;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7BB;
				case 6:
					this.radWideGenLightBarPatternRelay1_A36506 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚髜뫞迠꿢賤胦臨鿪꿬軮菰ꏲ铴菶跸黺迼釾匀昂椄昆瀈㨊刌与∐┒—✖⼘", a_), global::CommonResources.AcgResources.ID_RELAY1, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideGenLightBarPatternRelay1_A36506LovStrs);
					this.radWideGenLightBarPatternRelay1_A36506.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radWideGenLightBarPatternRelay1_A36506.DataTransferOrder = 132;
					this.radWideGenLightBarPatternRelay1_A36506.ValidateAcrossRecset = true;
					num = (short)461373455;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_3B2;
				case 8:
					this.radWideGenLightBarPatternRelay3_A36508 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚髜뫞迠꿢賤胦臨鿪꿬軮菰ꏲ铴菶跸黺迼釾匀昂椄昆瀈㠊刌与∐┒—✖℘", a_), global::CommonResources.AcgResources.ID_RELAY3, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideGenLightBarPatternRelay3_A36508LovStrs);
					this.radWideGenLightBarPatternRelay3_A36508.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radWideGenLightBarPatternRelay3_A36508.DataTransferOrder = 134;
					this.radWideGenLightBarPatternRelay3_A36508.ValidateAcrossRecset = true;
					num = (short)228065283;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚髜뫞迠꿢賤胦臨鿪꿬軮菰ꏲ铴菶跸黺迼釾匀昂椄昆瀈㰊刌与∐┒—☖⬘", a_)))
					{
						num = (short)605093888;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_933;
				case 10:
					this.radWideGenLgtBarName_A36505 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚髜뫞迠꿢苤鏦ꯨ諪鿬ꇮ郰黲郴ꣶ룸죺쯼쫾㄀㘂", a_), global::CommonResources.AcgResources.ID_NAME, 14);
					this.radWideGenLgtBarName_A36505.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radWideGenLgtBarName_A36505.DataTransferOrder = 131;
					num = (short)1442447386;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					this.radWideGenLightBarPatternRelay2_A36507 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚髜뫞迠꿢賤胦臨鿪꿬軮菰ꏲ铴菶跸黺迼釾匀昂椄昆瀈㤊刌与∐┒—✖⸘", a_), global::CommonResources.AcgResources.ID_RELAY2, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideGenLightBarPatternRelay2_A36507LovStrs);
					this.radWideGenLightBarPatternRelay2_A36507.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radWideGenLightBarPatternRelay2_A36507.DataTransferOrder = 133;
					this.radWideGenLightBarPatternRelay2_A36507.ValidateAcrossRecset = true;
					num = (short)2030632981;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚髜뫞迠꿢苤鏦ꯨ諪鿬ꇮ郰黲郴ꣶ룸죺쯼쫾㄀㘂", a_)))
					{
						num = (short)255000586;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5C2;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚髜뫞迠꿢賤胦臨鿪꿬軮菰ꏲ铴菶跸黺迼釾匀昂椄昆瀈㤊刌与∐┒—✖⸘", a_)))
					{
						num = (short)1600192523;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_69D;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚髜뫞迠꿢賤胦臨鿪꿬軮菰ꏲ铴菶跸黺迼釾匀昂椄昆瀈㸊刌与∐┒—☖⤘", a_)))
					{
						num = (short)503250975;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_870;
				case 15:
					goto IL_400;
				case 16:
					goto IL_888;
				case 17:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚髜뫞迠꿢賤胦臨鿪꿬軮菰ꏲ铴菶跸黺迼釾匀昂椄昆瀈㌊刌与∐┒—☖⨘", a_)))
					{
						num = (short)645136413;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_272;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚髜뫞迠꿢賤胦臨鿪꿬軮菰ꏲ铴菶跸黺迼釾匀昂椄昆瀈㼊刌与∐┒—✖‘", a_)))
					{
						num = (short)2036334620;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3B2;
				case 19:
					num = (short)930414594;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					this.radWideGenLightBarPatternRelay10_A36516 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚髜뫞迠꿢賤胦臨鿪꿬軮菰ꏲ铴菶跸黺迼釾匀昂椄昆瀈㨊㴌倎倐‒⌔∖⠘ⴚ", a_), global::CommonResources.AcgResources.ID_RELAY10, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideGenLightBarPatternRelay10_A36516LovStrs);
					this.radWideGenLightBarPatternRelay10_A36516.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radWideGenLightBarPatternRelay10_A36516.DataTransferOrder = 141;
					this.radWideGenLightBarPatternRelay10_A36516.ValidateAcrossRecset = true;
					num = (short)1564409857;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					goto IL_69D;
				case 22:
					num = (short)1381761036;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					goto IL_933;
				case 24:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚髜뫞迠꿢賤胦臨鿪꿬軮菰ꏲ铴菶跸黺迼釾匀昂椄昆瀈㨊刌与∐┒—✖⼘", a_)))
					{
						num = (short)241696768;
						short num4 = num;
						num = (short)29229062;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_400;
				case 25:
					goto IL_365;
				case 26:
					goto IL_5C2;
				case 27:
					goto IL_7B6;
				case 28:
					this.radWideGenLightBarPatternRelay4_A36509 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚髜뫞迠꿢賤胦臨鿪꿬軮菰ꏲ铴菶跸黺迼釾匀昂椄昆瀈㼊刌与∐┒—✖‘", a_), global::CommonResources.AcgResources.ID_RELAY4, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideGenLightBarPatternRelay4_A36509LovStrs);
					this.radWideGenLightBarPatternRelay4_A36509.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radWideGenLightBarPatternRelay4_A36509.DataTransferOrder = 135;
					this.radWideGenLightBarPatternRelay4_A36509.ValidateAcrossRecset = true;
					num = (short)678756359;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					this.radWideGenLightBarPatternRelay8_A36513 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚髜뫞迠꿢賤胦臨鿪꿬軮菰ꏲ铴菶跸黺迼釾匀昂椄昆瀈㌊刌与∐┒—☖⨘", a_), global::CommonResources.AcgResources.ID_RELAY8, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideGenLightBarPatternRelay8_A36513LovStrs);
					this.radWideGenLightBarPatternRelay8_A36513.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radWideGenLightBarPatternRelay8_A36513.DataTransferOrder = 139;
					this.radWideGenLightBarPatternRelay8_A36513.ValidateAcrossRecset = true;
					num = (short)2103181344;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 30:
					switch (0)
					{
					case 0:
						goto IL_10D;
					}
					continue;
				case 31:
					this.radWideGenLightBarPatternRelay5_A36510 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚髜뫞迠꿢賤胦臨鿪꿬軮菰ꏲ铴菶跸黺迼釾匀昂椄昆瀈㸊刌与∐┒—☖⤘", a_), global::CommonResources.AcgResources.ID_RELAY5, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideGenLightBarPatternRelay5_A36510LovStrs);
					this.radWideGenLightBarPatternRelay5_A36510.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radWideGenLightBarPatternRelay5_A36510.DataTransferOrder = 136;
					this.radWideGenLightBarPatternRelay5_A36510.ValidateAcrossRecset = true;
					num = (short)2555938;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 32:
					goto IL_272;
				case 33:
					this.radWideGenLightBarPatternRelay9_A36515 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚髜뫞迠꿢賤胦臨鿪꿬軮菰ꏲ铴菶跸黺迼釾匀昂椄昆瀈㈊刌与∐┒—☖Ⱈ", a_), global::CommonResources.AcgResources.ID_RELAY9, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideGenLightBarPatternRelay9_A36515LovStrs);
					this.radWideGenLightBarPatternRelay9_A36515.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radWideGenLightBarPatternRelay9_A36515.DataTransferOrder = 140;
					this.radWideGenLightBarPatternRelay9_A36515.ValidateAcrossRecset = true;
					num = (short)1522401305;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 34:
					goto IL_870;
				case 35:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚髜뫞迠꿢賤胦臨鿪꿬軮菰ꏲ铴菶跸黺迼釾匀昂椄昆瀈㈊刌与∐┒—☖Ⱈ", a_)))
					{
						num = (short)656080929;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_365;
				case 36:
					num = (short)831455233;
					if (num != 0)
					{
					}
					this.radWideGenLightBarPatternRelay6_A36511 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒苔뻖뷘뻚髜뫞迠꿢賤胦臨鿪꿬軮菰ꏲ铴菶跸黺迼釾匀昂椄昆瀈㴊刌与∐┒—☖⠘", a_), global::CommonResources.AcgResources.ID_RELAY6, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideGenLightBarPatternRelay6_A36511LovStrs);
					this.radWideGenLightBarPatternRelay6_A36511.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radWideGenLightBarPatternRelay6_A36511.DataTransferOrder = 137;
					this.radWideGenLightBarPatternRelay6_A36511.ValidateAcrossRecset = true;
					num = (short)1636892699;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_10D:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1502543891;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_272:
				num = (short)1809383459;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_365:
				num = (short)266993668;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_3B2:
				num = (short)1364000782;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_400:
				num = (short)1354104845;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_5C2:
				num = (short)46333976;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_69D:
				num = (short)42991621;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_7BB:
				num = (short)1111621650;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_870:
				num = (short)1644429328;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_933:
				num = (short)645005329;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_519:
			goto IL_981;
			IL_7B6:
			goto IL_318;
			IL_981:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鷎듐뿒듔껖律诚볜ꯞ闠蛢韤触", a_);
			base.Id = 10605;
			base.UIName = global::CommonResources.AcgResources.ID_RELAYPATTERN;
			base.DataTransferOrder = 1;
			return;
			IL_318:
			num = (short)247529481;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_73;
		}

		// Token: 0x06003594 RID: 13716 RVA: 0x00334FD0 File Offset: 0x003331D0
		public override void PopulateReferences()
		{
			short num = (short)306008730;
			short num2 = num;
			num = (short)1280004762;
			switch (num2 == num)
			{
			default:
			{
				num = (short)884604928;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2066677761;
			if (num != 0)
			{
			}
			num = (short)757727232;
			if (num != 0)
			{
			}
		}

		// Token: 0x06003595 RID: 13717 RVA: 0x00335078 File Offset: 0x00333278
		public override void DropReferences()
		{
			short num = (short)1554198965;
			short num2 = num;
			num = (short)737948085;
			switch (num2 == num)
			{
			default:
			{
				num = (short)724566016;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1538326528;
			if (num != 0)
			{
			}
			num = (short)1070333953;
			if (num != 0)
			{
			}
		}

		// Token: 0x06003596 RID: 13718 RVA: 0x00335120 File Offset: 0x00333320
		public override void SetConstraints()
		{
			short num = (short)1575098468;
			short num2 = num;
			num = (short)1764497508;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1341718528;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1504378881;
			if (num != 0)
			{
			}
			num = (short)1045889024;
			if (num != 0)
			{
			}
			this.radWideGenLightBarPatternRelay1_A36506.ValidateAcrossRecset = true;
			this.radWideGenLightBarPatternRelay1_A36506.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConRelayPatternRelay1Valid);
			this.radWideGenLightBarPatternRelay2_A36507.ValidateAcrossRecset = true;
			this.radWideGenLightBarPatternRelay2_A36507.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConRelayPatternRelay2Valid);
			this.radWideGenLightBarPatternRelay3_A36508.ValidateAcrossRecset = true;
			this.radWideGenLightBarPatternRelay3_A36508.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConRelayPatternRelay3Valid);
			this.radWideGenLightBarPatternRelay4_A36509.ValidateAcrossRecset = true;
			this.radWideGenLightBarPatternRelay4_A36509.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConRelayPatternRelay4Valid);
			this.radWideGenLightBarPatternRelay5_A36510.ValidateAcrossRecset = true;
			this.radWideGenLightBarPatternRelay5_A36510.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConRelayPatternRelay5Valid);
			this.radWideGenLightBarPatternRelay6_A36511.ValidateAcrossRecset = true;
			this.radWideGenLightBarPatternRelay6_A36511.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConRelayPatternRelay6Valid);
			this.radWideGenLightBarPatternRelay7_A36512.ValidateAcrossRecset = true;
			this.radWideGenLightBarPatternRelay7_A36512.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConRelayPatternRelay7Valid);
			this.radWideGenLightBarPatternRelay8_A36513.ValidateAcrossRecset = true;
			this.radWideGenLightBarPatternRelay8_A36513.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConRelayPatternRelay8Valid);
			this.radWideGenLightBarPatternRelay9_A36515.ValidateAcrossRecset = true;
			this.radWideGenLightBarPatternRelay9_A36515.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConRelayPatternRelay9Valid);
			this.radWideGenLightBarPatternRelay10_A36516.ValidateAcrossRecset = true;
			this.radWideGenLightBarPatternRelay10_A36516.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideConstraints.ConRelayPatternRelay10Valid);
		}

		// Token: 0x06003597 RID: 13719 RVA: 0x00335328 File Offset: 0x00333528
		public override void SetupDependencies()
		{
			short num = (short)38024531;
			short num2 = num;
			num = (short)1045181779;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1573388288;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)342097921;
			if (num != 0)
			{
			}
			num = (short)481624064;
			if (num != 0)
			{
			}
		}

		// Token: 0x17001B1E RID: 6942
		// (get) Token: 0x06003598 RID: 13720 RVA: 0x003353D4 File Offset: 0x003335D4
		public bool HasDiffs
		{
			get
			{
				short num = (short)24111758;
				short num2 = num;
				num = (short)1983703694;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1786642432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2109669377;
				if (num != 0)
				{
				}
				num = (short)64880640;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17001B1F RID: 6943
		// (get) Token: 0x06003599 RID: 13721 RVA: 0x00335484 File Offset: 0x00333684
		// (set) Token: 0x0600359A RID: 13722 RVA: 0x00335538 File Offset: 0x00333738
		public string RadWideGenLgtBarName_A36505Value
		{
			get
			{
				short num = (short)1549092459;
				short num2 = num;
				num = (short)1196901995;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1713766400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1234042880;
				if (num != 0)
				{
				}
				num = (short)469434369;
				if (num != 0)
				{
				}
				return this.radWideGenLgtBarName_A36505.Value;
			}
			set
			{
				short num = (short)779026433;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_F3;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_32;
						}
						continue;
					case 2:
						return;
					}
					IL_32:
					num = (short)305751188;
					short num3 = num;
					num = (short)1731486868;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_F3:
						this.radWideGenLgtBarName_A36505.Value = value;
						num = (short)1928134658;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
					{
						num = (short)709689345;
						if (num != 0)
						{
						}
						num = (short)1728774144;
						if (num != 0)
						{
						}
						num = (short)137297920;
						short num4 = num;
						if (string.IsNullOrEmpty(value.Trim()))
						{
							return;
						}
						num = (short)1628438528;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
		}

		// Token: 0x17001B20 RID: 6944
		// (get) Token: 0x0600359B RID: 13723 RVA: 0x00335660 File Offset: 0x00333860
		// (set) Token: 0x0600359C RID: 13724 RVA: 0x00335714 File Offset: 0x00333914
		public string RadWideGenLgtBarName_A36505_UIValue
		{
			get
			{
				short num = (short)1756837935;
				short num2 = num;
				num = (short)655898671;
				switch (num2 == num)
				{
				default:
				{
					num = (short)971440128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)41811969;
				if (num != 0)
				{
				}
				num = (short)311033856;
				if (num != 0)
				{
				}
				return this.radWideGenLgtBarName_A36505.Value;
			}
			set
			{
				short num = (short)1136533237;
				short num2 = num;
				num = (short)1493704437;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1034878976;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)16384001;
				if (num != 0)
				{
				}
				num = (short)953876480;
				if (num != 0)
				{
				}
				this.radWideGenLgtBarName_A36505.Value = value;
			}
		}

		// Token: 0x17001B21 RID: 6945
		// (get) Token: 0x0600359D RID: 13725 RVA: 0x003357C8 File Offset: 0x003339C8
		public global::AcpBusinessLayer.AcpKeyField RadWideGenLgtBarName_A36505
		{
			get
			{
				short num = (short)1106723652;
				short num2 = num;
				num = (short)1875395396;
				switch (num2 == num)
				{
				default:
				{
					num = (short)625737728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2119499776;
				if (num != 0)
				{
				}
				num = (short)1297809409;
				if (num != 0)
				{
				}
				return this.radWideGenLgtBarName_A36505;
			}
		}

		// Token: 0x17001B22 RID: 6946
		// (get) Token: 0x0600359E RID: 13726 RVA: 0x00335878 File Offset: 0x00333A78
		// (set) Token: 0x0600359F RID: 13727 RVA: 0x0033592C File Offset: 0x00333B2C
		public bool RadWideGenLgtBarName_A36505_Applicable
		{
			get
			{
				short num = (short)1396768769;
				if (num != 0)
				{
				}
				num = (short)1247805440;
				short num2 = num;
				num = (short)1495889794;
				short num3 = num;
				num = (short)273119106;
				switch (num3 == num)
				{
				}
				num = (short)1851195392;
				if (num != 0)
				{
				}
				return this.radWideGenLgtBarName_A36505.Applicable;
			}
			set
			{
				short num = (short)1998520321;
				if (num != 0)
				{
				}
				num = (short)54067200;
				short num2 = num;
				num = (short)135618143;
				short num3 = num;
				num = (short)1342660191;
				switch (num3 == num)
				{
				}
				num = (short)302317568;
				if (num != 0)
				{
				}
				this.radWideGenLgtBarName_A36505.Applicable = value;
			}
		}

		// Token: 0x17001B23 RID: 6947
		// (get) Token: 0x060035A0 RID: 13728 RVA: 0x003359E4 File Offset: 0x00333BE4
		// (set) Token: 0x060035A1 RID: 13729 RVA: 0x00335A9C File Offset: 0x00333C9C
		public bool RadWideGenLgtBarName_A36505_Valid
		{
			get
			{
				short num = (short)2126577665;
				if (num != 0)
				{
				}
				num = (short)911278080;
				short num2 = num;
				num = (short)1491690319;
				short num3 = num;
				num = (short)2097636175;
				switch (num3 == num)
				{
				}
				num = (short)372637696;
				if (num != 0)
				{
				}
				return this.radWideGenLgtBarName_A36505.Valid;
			}
			set
			{
				short num = (short)13107201;
				if (num != 0)
				{
				}
				num = (short)1038090240;
				short num2 = num;
				num = (short)231854807;
				short num3 = num;
				num = (short)1006228183;
				switch (num3 == num)
				{
				}
				num = (short)365363200;
				if (num != 0)
				{
				}
				this.radWideGenLgtBarName_A36505.Valid = value;
			}
		}

		// Token: 0x17001B24 RID: 6948
		// (get) Token: 0x060035A2 RID: 13730 RVA: 0x00335B50 File Offset: 0x00333D50
		// (set) Token: 0x060035A3 RID: 13731 RVA: 0x00335C04 File Offset: 0x00333E04
		public bool RadWideGenLgtBarName_A36505_Visible
		{
			get
			{
				short num = (short)60704634;
				short num2 = num;
				num = (short)1092962170;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1794834432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1685848065;
				if (num != 0)
				{
				}
				num = (short)607911936;
				if (num != 0)
				{
				}
				return this.radWideGenLgtBarName_A36505.Visible;
			}
			set
			{
				short num = (short)1497279970;
				short num2 = num;
				num = (short)1784065506;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1615396864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2125266945;
				if (num != 0)
				{
				}
				num = (short)1522466816;
				if (num != 0)
				{
				}
				this.radWideGenLgtBarName_A36505.Visible = value;
			}
		}

		// Token: 0x17001B25 RID: 6949
		// (get) Token: 0x060035A4 RID: 13732 RVA: 0x00335CB8 File Offset: 0x00333EB8
		// (set) Token: 0x060035A5 RID: 13733 RVA: 0x00335D6C File Offset: 0x00333F6C
		public bool RadWideGenLgtBarName_A36505_Editable
		{
			get
			{
				short num = (short)878427443;
				short num2 = num;
				num = (short)1358413107;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1902706688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)179306497;
				if (num != 0)
				{
				}
				num = (short)1165623296;
				if (num != 0)
				{
				}
				return this.radWideGenLgtBarName_A36505.Editable;
			}
			set
			{
				short num = (short)1951614381;
				short num2 = num;
				num = (short)1926317485;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1930952704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)812646400;
				if (num != 0)
				{
				}
				num = (short)1943666689;
				if (num != 0)
				{
				}
				this.radWideGenLgtBarName_A36505.Editable = value;
			}
		}

		// Token: 0x17001B26 RID: 6950
		// (get) Token: 0x060035A6 RID: 13734 RVA: 0x00335E24 File Offset: 0x00334024
		internal string RadWideGenLgtBarName_A36505_UILabel
		{
			get
			{
				short num = (short)110904044;
				short num2 = num;
				num = (short)215040748;
				switch (num2 == num)
				{
				default:
				{
					num = (short)82182144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)276758529;
				if (num != 0)
				{
				}
				num = (short)589430784;
				if (num != 0)
				{
				}
				return this.radWideGenLgtBarName_A36505.UIName;
			}
		}

		// Token: 0x17001B27 RID: 6951
		// (get) Token: 0x060035A7 RID: 13735 RVA: 0x00335ED8 File Offset: 0x003340D8
		// (set) Token: 0x060035A8 RID: 13736 RVA: 0x00335F8C File Offset: 0x0033418C
		internal bool RadWideGenLgtBarName_A36505_HiddenStatic
		{
			get
			{
				short num = (short)301137921;
				if (num != 0)
				{
				}
				num = (short)179044352;
				short num2 = num;
				num = (short)1123148565;
				short num3 = num;
				num = (short)1499915029;
				switch (num3 == num)
				{
				}
				num = (short)1893793792;
				if (num != 0)
				{
				}
				return this.radWideGenLgtBarName_A36505.HiddenStatic;
			}
			set
			{
				short num = (short)1078710230;
				short num2 = num;
				num = (short)1088278486;
				switch (num2 == num)
				{
				default:
				{
					num = (short)593231872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)138346497;
				if (num != 0)
				{
				}
				num = (short)1021575168;
				if (num != 0)
				{
				}
				this.radWideGenLgtBarName_A36505.HiddenStatic = value;
			}
		}

		// Token: 0x17001B28 RID: 6952
		// (get) Token: 0x060035A9 RID: 13737 RVA: 0x00336040 File Offset: 0x00334240
		// (set) Token: 0x060035AA RID: 13738 RVA: 0x003360F8 File Offset: 0x003342F8
		internal bool RadWideGenLgtBarName_A36505_HiddenDynamic
		{
			get
			{
				short num = (short)192441096;
				short num2 = num;
				num = (short)1515088648;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1056571392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)77594625;
				if (num != 0)
				{
				}
				num = (short)1006698496;
				if (num != 0)
				{
				}
				return this.radWideGenLgtBarName_A36505.HiddenDynamic;
			}
			set
			{
				short num = (short)570284452;
				short num2 = num;
				num = (short)1523964324;
				switch (num2 == num)
				{
				default:
				{
					num = (short)239927296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)984547328;
				if (num != 0)
				{
				}
				num = (short)424345601;
				if (num != 0)
				{
				}
				this.radWideGenLgtBarName_A36505.HiddenDynamic = value;
			}
		}

		// Token: 0x17001B29 RID: 6953
		// (get) Token: 0x060035AB RID: 13739 RVA: 0x003361AC File Offset: 0x003343AC
		public bool RadWideGenLgtBarName_A36505_HasDiffs
		{
			get
			{
				short num = (short)238440840;
				short num2 = num;
				num = (short)661082504;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1136787456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)27459584;
				if (num != 0)
				{
				}
				num = (short)1063321601;
				if (num != 0)
				{
				}
				return this.radWideGenLgtBarName_A36505._HasDiffs;
			}
		}

		// Token: 0x17001B2A RID: 6954
		// (get) Token: 0x060035AC RID: 13740 RVA: 0x00336260 File Offset: 0x00334460
		// (set) Token: 0x060035AD RID: 13741 RVA: 0x00336314 File Offset: 0x00334514
		public int RadWideGenLightBarPatternRelay1_A36506Value
		{
			get
			{
				short num = (short)1148457501;
				short num2 = num;
				num = (short)1995313693;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1977614336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)286326784;
				if (num != 0)
				{
				}
				num = (short)160628737;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay1_A36506.Value;
			}
			set
			{
				short num = (short)1460797441;
				if (num != 0)
				{
				}
				num = (short)1701511168;
				short num2 = num;
				num = (short)1875690074;
				short num3 = num;
				num = (short)1870250586;
				switch (num3 == num)
				{
				}
				num = (short)79298560;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay1_A36506.Value = value;
			}
		}

		// Token: 0x17001B2B RID: 6955
		// (get) Token: 0x060035AE RID: 13742 RVA: 0x003363C8 File Offset: 0x003345C8
		// (set) Token: 0x060035AF RID: 13743 RVA: 0x0033647C File Offset: 0x0033467C
		public string RadWideGenLightBarPatternRelay1_A36506_UIValue
		{
			get
			{
				short num = (short)2037645313;
				if (num != 0)
				{
				}
				num = (short)1473511424;
				short num2 = num;
				num = (short)442747053;
				short num3 = num;
				num = (short)1502398637;
				switch (num3 == num)
				{
				}
				num = (short)707264512;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay1_A36506.UIValue;
			}
			set
			{
				short num = (short)539087622;
				short num2 = num;
				num = (short)18404102;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1710555136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2031026176;
				if (num != 0)
				{
				}
				num = (short)1295974401;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay1_A36506.UIValue = value;
			}
		}

		// Token: 0x17001B2C RID: 6956
		// (get) Token: 0x060035B0 RID: 13744 RVA: 0x00336530 File Offset: 0x00334730
		public global::AcpBusinessLayer.AcpListField RadWideGenLightBarPatternRelay1_A36506
		{
			get
			{
				short num = (short)470886015;
				short num2 = num;
				num = (short)874129023;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2034958336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)840630273;
				if (num != 0)
				{
				}
				num = (short)1981218816;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay1_A36506;
			}
		}

		// Token: 0x17001B2D RID: 6957
		// (get) Token: 0x060035B1 RID: 13745 RVA: 0x003365E0 File Offset: 0x003347E0
		// (set) Token: 0x060035B2 RID: 13746 RVA: 0x00336698 File Offset: 0x00334898
		public bool RadWideGenLightBarPatternRelay1_A36506_Applicable
		{
			get
			{
				short num = (short)945395059;
				short num2 = num;
				num = (short)1732220275;
				switch (num2 == num)
				{
				default:
				{
					num = (short)653000704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)494796801;
				if (num != 0)
				{
				}
				num = (short)1324941312;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay1_A36506.Applicable;
			}
			set
			{
				short num = (short)1117861418;
				short num2 = num;
				num = (short)1613444650;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1956904960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1345650688;
				if (num != 0)
				{
				}
				num = (short)999751681;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay1_A36506.Applicable = value;
			}
		}

		// Token: 0x17001B2E RID: 6958
		// (get) Token: 0x060035B3 RID: 13747 RVA: 0x00336750 File Offset: 0x00334950
		// (set) Token: 0x060035B4 RID: 13748 RVA: 0x00336804 File Offset: 0x00334A04
		public bool RadWideGenLightBarPatternRelay1_A36506_Valid
		{
			get
			{
				short num = (short)1354366977;
				if (num != 0)
				{
				}
				num = (short)1124335616;
				short num2 = num;
				num = (short)221743635;
				short num3 = num;
				num = (short)6523411;
				switch (num3 == num)
				{
				}
				num = (short)1380843520;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay1_A36506.Valid;
			}
			set
			{
				short num = (short)696627549;
				short num2 = num;
				num = (short)401584477;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2013921280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)96993280;
				if (num != 0)
				{
				}
				num = (short)408616961;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay1_A36506.Valid = value;
			}
		}

		// Token: 0x17001B2F RID: 6959
		// (get) Token: 0x060035B5 RID: 13749 RVA: 0x003368B8 File Offset: 0x00334AB8
		// (set) Token: 0x060035B6 RID: 13750 RVA: 0x0033696C File Offset: 0x00334B6C
		public bool RadWideGenLightBarPatternRelay1_A36506_Visible
		{
			get
			{
				short num = (short)114034636;
				short num2 = num;
				num = (short)1497171916;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1585774592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)896401409;
				if (num != 0)
				{
				}
				num = (short)1037303808;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay1_A36506.Visible;
			}
			set
			{
				short num = (short)2141454337;
				if (num != 0)
				{
				}
				num = (short)815795612;
				short num2 = num;
				num = (short)2104233372;
				switch (num2 == num)
				{
				default:
				{
					num = (short)222429184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1157365760;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay1_A36506.Visible = value;
			}
		}

		// Token: 0x17001B30 RID: 6960
		// (get) Token: 0x060035B7 RID: 13751 RVA: 0x00336A20 File Offset: 0x00334C20
		// (set) Token: 0x060035B8 RID: 13752 RVA: 0x00336AD4 File Offset: 0x00334CD4
		public bool RadWideGenLightBarPatternRelay1_A36506_Editable
		{
			get
			{
				short num = (short)89999872;
				short num2 = num;
				num = (short)1137265152;
				switch (num2 == num)
				{
				}
				num = (short)66060288;
				short num3 = num;
				num = (short)17629184;
				if (num != 0)
				{
				}
				num = (short)1921318913;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay1_A36506.Editable;
			}
			set
			{
				short num = (short)1896160689;
				short num2 = num;
				num = (short)1008344497;
				switch (num2 == num)
				{
				}
				num = (short)114032640;
				short num3 = num;
				num = (short)1892220929;
				if (num != 0)
				{
				}
				num = (short)484179968;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay1_A36506.Editable = value;
			}
		}

		// Token: 0x17001B31 RID: 6961
		// (get) Token: 0x060035B9 RID: 13753 RVA: 0x00336B8C File Offset: 0x00334D8C
		internal string RadWideGenLightBarPatternRelay1_A36506_UILabel
		{
			get
			{
				short num = (short)2097741825;
				if (num != 0)
				{
				}
				num = (short)78816441;
				short num2 = num;
				num = (short)1340974265;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1441923072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1071906816;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay1_A36506.UIName;
			}
		}

		// Token: 0x17001B32 RID: 6962
		// (get) Token: 0x060035BA RID: 13754 RVA: 0x00336C44 File Offset: 0x00334E44
		// (set) Token: 0x060035BB RID: 13755 RVA: 0x00336CF8 File Offset: 0x00334EF8
		internal bool RadWideGenLightBarPatternRelay1_A36506_HiddenStatic
		{
			get
			{
				short num = (short)1569366112;
				short num2 = num;
				num = (short)1142333536;
				switch (num2 == num)
				{
				}
				num = (short)599982080;
				short num3 = num;
				num = (short)342163457;
				if (num != 0)
				{
				}
				num = (short)688848896;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay1_A36506.HiddenStatic;
			}
			set
			{
				short num = (short)1719074817;
				if (num != 0)
				{
				}
				num = (short)126785218;
				short num2 = num;
				num = (short)1027184322;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1149960192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1761083392;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay1_A36506.HiddenStatic = value;
			}
		}

		// Token: 0x17001B33 RID: 6963
		// (get) Token: 0x060035BC RID: 13756 RVA: 0x00336DAC File Offset: 0x00334FAC
		// (set) Token: 0x060035BD RID: 13757 RVA: 0x00336E60 File Offset: 0x00335060
		internal bool RadWideGenLightBarPatternRelay1_A36506_HiddenDynamic
		{
			get
			{
				short num = (short)1181181463;
				short num2 = num;
				num = (short)1353803287;
				switch (num2 == num)
				{
				}
				num = (short)616562688;
				short num3 = num;
				num = (short)1536032769;
				if (num != 0)
				{
				}
				num = (short)1116930048;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay1_A36506.HiddenDynamic;
			}
			set
			{
				short num = (short)1074280579;
				short num2 = num;
				num = (short)1023031427;
				switch (num2 == num)
				{
				}
				num = (short)336003072;
				short num3 = num;
				num = (short)608567297;
				if (num != 0)
				{
				}
				num = (short)465502208;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay1_A36506.HiddenDynamic = value;
			}
		}

		// Token: 0x17001B34 RID: 6964
		// (get) Token: 0x060035BE RID: 13758 RVA: 0x00336F14 File Offset: 0x00335114
		public bool RadWideGenLightBarPatternRelay1_A36506_HasDiffs
		{
			get
			{
				short num = (short)732659056;
				short num2 = num;
				num = (short)1468235120;
				switch (num2 == num)
				{
				}
				num = (short)471269376;
				short num3 = num;
				num = (short)441450497;
				if (num != 0)
				{
				}
				num = (short)1274347520;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay1_A36506._HasDiffs;
			}
		}

		// Token: 0x17001B35 RID: 6965
		// (get) Token: 0x060035BF RID: 13759 RVA: 0x00336FC8 File Offset: 0x003351C8
		// (set) Token: 0x060035C0 RID: 13760 RVA: 0x0033707C File Offset: 0x0033527C
		public int RadWideGenLightBarPatternRelay2_A36507Value
		{
			get
			{
				short num = (short)2091177959;
				short num2 = num;
				num = (short)320264167;
				switch (num2 == num)
				{
				}
				num = (short)1909260288;
				short num3 = num;
				num = (short)1575223297;
				if (num != 0)
				{
				}
				num = (short)390070272;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay2_A36507.Value;
			}
			set
			{
				short num = (short)959391613;
				short num2 = num;
				num = (short)1849239421;
				switch (num2 == num)
				{
				}
				num = (short)679149568;
				short num3 = num;
				num = (short)1031143424;
				if (num != 0)
				{
				}
				num = (short)639238145;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay2_A36507.Value = value;
			}
		}

		// Token: 0x17001B36 RID: 6966
		// (get) Token: 0x060035C1 RID: 13761 RVA: 0x00337130 File Offset: 0x00335330
		// (set) Token: 0x060035C2 RID: 13762 RVA: 0x003371E8 File Offset: 0x003353E8
		public string RadWideGenLightBarPatternRelay2_A36507_UIValue
		{
			get
			{
				short num = (short)317240241;
				short num2 = num;
				num = (short)1064154033;
				switch (num2 == num)
				{
				}
				num = (short)1991770112;
				short num3 = num;
				num = (short)384040960;
				if (num != 0)
				{
				}
				num = (short)1480654849;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay2_A36507.UIValue;
			}
			set
			{
				short num = (short)832620916;
				short num2 = num;
				num = (short)1910950260;
				switch (num2 == num)
				{
				}
				num = (short)1995374592;
				short num3 = num;
				num = (short)1607467008;
				if (num != 0)
				{
				}
				num = (short)939720705;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay2_A36507.UIValue = value;
			}
		}

		// Token: 0x17001B37 RID: 6967
		// (get) Token: 0x060035C3 RID: 13763 RVA: 0x00337298 File Offset: 0x00335498
		public global::AcpBusinessLayer.AcpListField RadWideGenLightBarPatternRelay2_A36507
		{
			get
			{
				short num = (short)1293544295;
				short num2 = num;
				num = (short)1026747239;
				switch (num2 == num)
				{
				}
				num = (short)1120468992;
				short num3 = num;
				num = (short)800653313;
				if (num != 0)
				{
				}
				num = (short)1057816576;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay2_A36507;
			}
		}

		// Token: 0x17001B38 RID: 6968
		// (get) Token: 0x060035C4 RID: 13764 RVA: 0x00337348 File Offset: 0x00335548
		// (set) Token: 0x060035C5 RID: 13765 RVA: 0x00337400 File Offset: 0x00335600
		public bool RadWideGenLightBarPatternRelay2_A36507_Applicable
		{
			get
			{
				short num = (short)1833065197;
				short num2 = num;
				num = (short)623074029;
				switch (num2 == num)
				{
				}
				num = (short)761790464;
				short num3 = num;
				num = (short)1373241345;
				if (num != 0)
				{
				}
				num = (short)515833856;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay2_A36507.Applicable;
			}
			set
			{
				short num = (short)633498335;
				short num2 = num;
				num = (short)1767598815;
				switch (num2 == num)
				{
				}
				num = (short)1517748224;
				short num3 = num;
				num = (short)1833500673;
				if (num != 0)
				{
				}
				num = (short)857866240;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay2_A36507.Applicable = value;
			}
		}

		// Token: 0x17001B39 RID: 6969
		// (get) Token: 0x060035C6 RID: 13766 RVA: 0x003374B4 File Offset: 0x003356B4
		// (set) Token: 0x060035C7 RID: 13767 RVA: 0x00337568 File Offset: 0x00335768
		public bool RadWideGenLightBarPatternRelay2_A36507_Valid
		{
			get
			{
				short num = (short)718622719;
				short num2 = num;
				num = (short)2121289727;
				switch (num2 == num)
				{
				}
				num = (short)367525888;
				short num3 = num;
				num = (short)31457281;
				if (num != 0)
				{
				}
				num = (short)1239875584;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay2_A36507.Valid;
			}
			set
			{
				short num = (short)1800315535;
				short num2 = num;
				num = (short)1609409167;
				switch (num2 == num)
				{
				}
				num = (short)1728118784;
				short num3 = num;
				num = (short)468189185;
				if (num != 0)
				{
				}
				num = (short)957415424;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay2_A36507.Valid = value;
			}
		}

		// Token: 0x17001B3A RID: 6970
		// (get) Token: 0x060035C8 RID: 13768 RVA: 0x00337620 File Offset: 0x00335820
		// (set) Token: 0x060035C9 RID: 13769 RVA: 0x003376D8 File Offset: 0x003358D8
		public bool RadWideGenLightBarPatternRelay2_A36507_Visible
		{
			get
			{
				short num = (short)586542875;
				short num2 = num;
				num = (short)1061482267;
				switch (num2 == num)
				{
				}
				num = (short)2136604672;
				short num3 = num;
				num = (short)914292736;
				if (num != 0)
				{
				}
				num = (short)1524367361;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay2_A36507.Visible;
			}
			set
			{
				short num = (short)1358454121;
				short num2 = num;
				num = (short)146103657;
				switch (num2 == num)
				{
				}
				num = (short)1705050112;
				short num3 = num;
				num = (short)1495269377;
				if (num != 0)
				{
				}
				num = (short)497418240;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay2_A36507.Visible = value;
			}
		}

		// Token: 0x17001B3B RID: 6971
		// (get) Token: 0x060035CA RID: 13770 RVA: 0x0033778C File Offset: 0x0033598C
		// (set) Token: 0x060035CB RID: 13771 RVA: 0x0033783C File Offset: 0x00335A3C
		public bool RadWideGenLightBarPatternRelay2_A36507_Editable
		{
			get
			{
				short num = (short)756993091;
				short num2 = num;
				num = (short)1593756739;
				switch (num2 == num)
				{
				}
				num = (short)1835859968;
				short num3 = num;
				num = (short)1638268929;
				if (num != 0)
				{
				}
				num = (short)1934491648;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay2_A36507.Editable;
			}
			set
			{
				short num = (short)868024321;
				if (num != 0)
				{
				}
				num = (short)179234706;
				short num2 = num;
				num = (short)1780082578;
				switch (num2 == num)
				{
				default:
				{
					num = (short)687276032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)852099072;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay2_A36507.Editable = value;
			}
		}

		// Token: 0x17001B3C RID: 6972
		// (get) Token: 0x060035CC RID: 13772 RVA: 0x003378F4 File Offset: 0x00335AF4
		internal string RadWideGenLightBarPatternRelay2_A36507_UILabel
		{
			get
			{
				short num = (short)1532952577;
				if (num != 0)
				{
				}
				num = (short)1540839441;
				short num2 = num;
				num = (short)456808465;
				switch (num2 == num)
				{
				default:
				{
					num = (short)861995008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)24838144;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay2_A36507.UIName;
			}
		}

		// Token: 0x17001B3D RID: 6973
		// (get) Token: 0x060035CD RID: 13773 RVA: 0x003379A8 File Offset: 0x00335BA8
		// (set) Token: 0x060035CE RID: 13774 RVA: 0x00337A5C File Offset: 0x00335C5C
		internal bool RadWideGenLightBarPatternRelay2_A36507_HiddenStatic
		{
			get
			{
				short num = (short)459130588;
				short num2 = num;
				num = (short)1291175644;
				switch (num2 == num)
				{
				}
				num = (short)12517376;
				short num3 = num;
				num = (short)1196425217;
				if (num != 0)
				{
				}
				num = (short)1882128384;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay2_A36507.HiddenStatic;
			}
			set
			{
				short num = (short)1535386421;
				short num2 = num;
				num = (short)828580661;
				switch (num2 == num)
				{
				}
				num = (short)793968640;
				short num3 = num;
				num = (short)719192065;
				if (num != 0)
				{
				}
				num = (short)1473839104;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay2_A36507.HiddenStatic = value;
			}
		}

		// Token: 0x17001B3E RID: 6974
		// (get) Token: 0x060035CF RID: 13775 RVA: 0x00337B14 File Offset: 0x00335D14
		// (set) Token: 0x060035D0 RID: 13776 RVA: 0x00337BC8 File Offset: 0x00335DC8
		internal bool RadWideGenLightBarPatternRelay2_A36507_HiddenDynamic
		{
			get
			{
				short num = (short)751642675;
				short num2 = num;
				num = (short)41035827;
				switch (num2 == num)
				{
				}
				num = (short)1854668800;
				short num3 = num;
				num = (short)1341128705;
				if (num != 0)
				{
				}
				num = (short)620888064;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay2_A36507.HiddenDynamic;
			}
			set
			{
				short num = (short)1173192126;
				short num2 = num;
				num = (short)53181886;
				switch (num2 == num)
				{
				}
				num = (short)953090048;
				short num3 = num;
				num = (short)1428750337;
				if (num != 0)
				{
				}
				num = (short)3342336;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay2_A36507.HiddenDynamic = value;
			}
		}

		// Token: 0x17001B3F RID: 6975
		// (get) Token: 0x060035D1 RID: 13777 RVA: 0x00337C80 File Offset: 0x00335E80
		public bool RadWideGenLightBarPatternRelay2_A36507_HasDiffs
		{
			get
			{
				short num = (short)1346933133;
				short num2 = num;
				num = (short)1513132429;
				switch (num2 == num)
				{
				}
				num = (short)1329856512;
				short num3 = num;
				num = (short)1771700225;
				if (num != 0)
				{
				}
				num = (short)1870528512;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay2_A36507._HasDiffs;
			}
		}

		// Token: 0x17001B40 RID: 6976
		// (get) Token: 0x060035D2 RID: 13778 RVA: 0x00337D38 File Offset: 0x00335F38
		// (set) Token: 0x060035D3 RID: 13779 RVA: 0x00337DEC File Offset: 0x00335FEC
		public int RadWideGenLightBarPatternRelay3_A36508Value
		{
			get
			{
				short num = (short)1481970095;
				short num2 = num;
				num = (short)339808687;
				switch (num2 == num)
				{
				}
				num = (short)85458944;
				short num3 = num;
				num = (short)1133772800;
				if (num != 0)
				{
				}
				num = (short)1048903681;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay3_A36508.Value;
			}
			set
			{
				short num = (short)882805122;
				short num2 = num;
				num = (short)1815054722;
				switch (num2 == num)
				{
				}
				num = (short)661585920;
				short num3 = num;
				num = (short)888012800;
				if (num != 0)
				{
				}
				num = (short)795672577;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay3_A36508.Value = value;
			}
		}

		// Token: 0x17001B41 RID: 6977
		// (get) Token: 0x060035D4 RID: 13780 RVA: 0x00337EA0 File Offset: 0x003360A0
		// (set) Token: 0x060035D5 RID: 13781 RVA: 0x00337F54 File Offset: 0x00336154
		public string RadWideGenLightBarPatternRelay3_A36508_UIValue
		{
			get
			{
				short num = (short)1944846337;
				if (num != 0)
				{
				}
				num = (short)2078215450;
				short num2 = num;
				num = (short)405146906;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1430257664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)539951104;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay3_A36508.UIValue;
			}
			set
			{
				short num = (short)2084241409;
				if (num != 0)
				{
				}
				num = (short)330558830;
				short num2 = num;
				num = (short)411233646;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1802043392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1873412096;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay3_A36508.UIValue = value;
			}
		}

		// Token: 0x17001B42 RID: 6978
		// (get) Token: 0x060035D6 RID: 13782 RVA: 0x0033800C File Offset: 0x0033620C
		public global::AcpBusinessLayer.AcpListField RadWideGenLightBarPatternRelay3_A36508
		{
			get
			{
				short num = (short)560246018;
				short num2 = num;
				num = (short)1035578626;
				switch (num2 == num)
				{
				}
				num = (short)1585905664;
				short num3 = num;
				num = (short)753205249;
				if (num != 0)
				{
				}
				num = (short)660144128;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay3_A36508;
			}
		}

		// Token: 0x17001B43 RID: 6979
		// (get) Token: 0x060035D7 RID: 13783 RVA: 0x003380B8 File Offset: 0x003362B8
		// (set) Token: 0x060035D8 RID: 13784 RVA: 0x0033816C File Offset: 0x0033636C
		public bool RadWideGenLightBarPatternRelay3_A36508_Applicable
		{
			get
			{
				short num = (short)1965841282;
				short num2 = num;
				num = (short)1220631426;
				switch (num2 == num)
				{
				}
				num = (short)156041216;
				short num3 = num;
				num = (short)1793392640;
				if (num != 0)
				{
				}
				num = (short)1626275841;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay3_A36508.Applicable;
			}
			set
			{
				short num = (short)399114241;
				if (num != 0)
				{
				}
				num = (short)887735611;
				short num2 = num;
				num = (short)1623311675;
				switch (num2 == num)
				{
				default:
				{
					num = (short)19202048;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1271463936;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay3_A36508.Applicable = value;
			}
		}

		// Token: 0x17001B44 RID: 6980
		// (get) Token: 0x060035D9 RID: 13785 RVA: 0x00338220 File Offset: 0x00336420
		// (set) Token: 0x060035DA RID: 13786 RVA: 0x003382D8 File Offset: 0x003364D8
		public bool RadWideGenLightBarPatternRelay3_A36508_Valid
		{
			get
			{
				short num = (short)1989213561;
				short num2 = num;
				num = (short)520420729;
				switch (num2 == num)
				{
				}
				num = (short)1965424640;
				short num3 = num;
				num = (short)1472593921;
				if (num != 0)
				{
				}
				num = (short)1377894400;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay3_A36508.Valid;
			}
			set
			{
				short num = (short)1392021552;
				short num2 = num;
				num = (short)103518256;
				switch (num2 == num)
				{
				}
				num = (short)1926299648;
				short num3 = num;
				num = (short)1926627328;
				if (num != 0)
				{
				}
				num = (short)336461825;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay3_A36508.Valid = value;
			}
		}

		// Token: 0x17001B45 RID: 6981
		// (get) Token: 0x060035DB RID: 13787 RVA: 0x0033838C File Offset: 0x0033658C
		// (set) Token: 0x060035DC RID: 13788 RVA: 0x00338440 File Offset: 0x00336640
		public bool RadWideGenLightBarPatternRelay3_A36508_Visible
		{
			get
			{
				short num = (short)1696143482;
				short num2 = num;
				num = (short)308025466;
				switch (num2 == num)
				{
				}
				num = (short)936443904;
				short num3 = num;
				num = (short)2102657025;
				if (num != 0)
				{
				}
				num = (short)233308160;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay3_A36508.Visible;
			}
			set
			{
				short num = (short)2132321612;
				short num2 = num;
				num = (short)1877648716;
				switch (num2 == num)
				{
				}
				num = (short)79233024;
				short num3 = num;
				num = (short)1514340352;
				if (num != 0)
				{
				}
				num = (short)1178730497;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay3_A36508.Visible = value;
			}
		}

		// Token: 0x17001B46 RID: 6982
		// (get) Token: 0x060035DD RID: 13789 RVA: 0x003384F4 File Offset: 0x003366F4
		// (set) Token: 0x060035DE RID: 13790 RVA: 0x003385A8 File Offset: 0x003367A8
		public bool RadWideGenLightBarPatternRelay3_A36508_Editable
		{
			get
			{
				short num = (short)200191017;
				short num2 = num;
				num = (short)1768401961;
				switch (num2 == num)
				{
				}
				num = (short)34668545;
				if (num != 0)
				{
				}
				num = (short)281214976;
				short num3 = num;
				num = (short)1191706624;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay3_A36508.Editable;
			}
			set
			{
				short num = (short)106527998;
				short num2 = num;
				num = (short)204373246;
				switch (num2 == num)
				{
				}
				num = (short)165871617;
				if (num != 0)
				{
				}
				num = (short)268894208;
				short num3 = num;
				num = (short)1219100672;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay3_A36508.Editable = value;
			}
		}

		// Token: 0x17001B47 RID: 6983
		// (get) Token: 0x060035DF RID: 13791 RVA: 0x0033865C File Offset: 0x0033685C
		internal string RadWideGenLightBarPatternRelay3_A36508_UILabel
		{
			get
			{
				short num = (short)1710161921;
				if (num != 0)
				{
				}
				num = (short)1186961235;
				short num2 = num;
				num = (short)1583650643;
				switch (num2 == num)
				{
				}
				num = (short)562823168;
				short num3 = num;
				num = (short)1033961472;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay3_A36508.UIName;
			}
		}

		// Token: 0x17001B48 RID: 6984
		// (get) Token: 0x060035E0 RID: 13792 RVA: 0x0033870C File Offset: 0x0033690C
		// (set) Token: 0x060035E1 RID: 13793 RVA: 0x003387C0 File Offset: 0x003369C0
		internal bool RadWideGenLightBarPatternRelay3_A36508_HiddenStatic
		{
			get
			{
				short num = (short)286916609;
				if (num != 0)
				{
				}
				num = (short)1809706391;
				short num2 = num;
				num = (short)611380631;
				switch (num2 == num)
				{
				}
				num = (short)1756889088;
				short num3 = num;
				num = (short)1921515520;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay3_A36508.HiddenStatic;
			}
			set
			{
				short num = (short)19333565;
				short num2 = num;
				num = (short)267387325;
				switch (num2 == num)
				{
				}
				num = (short)1291255809;
				if (num != 0)
				{
				}
				num = (short)778829824;
				short num3 = num;
				num = (short)1910636544;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay3_A36508.HiddenStatic = value;
			}
		}

		// Token: 0x17001B49 RID: 6985
		// (get) Token: 0x060035E2 RID: 13794 RVA: 0x00338878 File Offset: 0x00336A78
		// (set) Token: 0x060035E3 RID: 13795 RVA: 0x0033892C File Offset: 0x00336B2C
		internal bool RadWideGenLightBarPatternRelay3_A36508_HiddenDynamic
		{
			get
			{
				short num = (short)1995319819;
				short num2 = num;
				num = (short)1603349003;
				switch (num2 == num)
				{
				}
				num = (short)795869184;
				if (num != 0)
				{
				}
				num = (short)184680448;
				short num3 = num;
				num = (short)65929217;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay3_A36508.HiddenDynamic;
			}
			set
			{
				short num = (short)1024655361;
				if (num != 0)
				{
				}
				num = (short)38297196;
				short num2 = num;
				num = (short)809655916;
				switch (num2 == num)
				{
				}
				num = (short)693043200;
				short num3 = num;
				num = (short)338296832;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay3_A36508.HiddenDynamic = value;
			}
		}

		// Token: 0x17001B4A RID: 6986
		// (get) Token: 0x060035E4 RID: 13796 RVA: 0x003389E0 File Offset: 0x00336BE0
		public bool RadWideGenLightBarPatternRelay3_A36508_HasDiffs
		{
			get
			{
				short num = (short)1979775205;
				short num2 = num;
				num = (short)1977219301;
				switch (num2 == num)
				{
				}
				num = (short)1831993345;
				if (num != 0)
				{
				}
				num = (short)1625817088;
				short num3 = num;
				num = (short)1133576192;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay3_A36508._HasDiffs;
			}
		}

		// Token: 0x17001B4B RID: 6987
		// (get) Token: 0x060035E5 RID: 13797 RVA: 0x00338A94 File Offset: 0x00336C94
		// (set) Token: 0x060035E6 RID: 13798 RVA: 0x00338B48 File Offset: 0x00336D48
		public int RadWideGenLightBarPatternRelay4_A36509Value
		{
			get
			{
				short num = (short)1580784965;
				short num2 = num;
				num = (short)272751941;
				switch (num2 == num)
				{
				}
				num = (short)1966342144;
				if (num != 0)
				{
				}
				num = (short)1988231168;
				short num3 = num;
				num = (short)1328873473;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay4_A36509.Value;
			}
			set
			{
				short num = (short)1186953241;
				short num2 = num;
				num = (short)602961945;
				switch (num2 == num)
				{
				}
				num = (short)718471169;
				if (num != 0)
				{
				}
				num = (short)1102708736;
				short num3 = num;
				num = (short)1338638336;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay4_A36509.Value = value;
			}
		}

		// Token: 0x17001B4C RID: 6988
		// (get) Token: 0x060035E7 RID: 13799 RVA: 0x00338C00 File Offset: 0x00336E00
		// (set) Token: 0x060035E8 RID: 13800 RVA: 0x00338CB8 File Offset: 0x00336EB8
		public string RadWideGenLightBarPatternRelay4_A36509_UIValue
		{
			get
			{
				short num = (short)629145601;
				if (num != 0)
				{
				}
				num = (short)1654832031;
				short num2 = num;
				num = (short)38255519;
				switch (num2 == num)
				{
				}
				num = (short)830341120;
				short num3 = num;
				num = (short)629800960;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay4_A36509.UIValue;
			}
			set
			{
				short num = (short)1994737011;
				short num2 = num;
				num = (short)2035631475;
				switch (num2 == num)
				{
				}
				num = (short)632750081;
				if (num != 0)
				{
				}
				num = (short)1027276800;
				short num3 = num;
				num = (short)196608;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay4_A36509.UIValue = value;
			}
		}

		// Token: 0x17001B4D RID: 6989
		// (get) Token: 0x060035E9 RID: 13801 RVA: 0x00338D70 File Offset: 0x00336F70
		public global::AcpBusinessLayer.AcpListField RadWideGenLightBarPatternRelay4_A36509
		{
			get
			{
				short num = (short)79664026;
				short num2 = num;
				num = (short)357536666;
				switch (num2 == num)
				{
				}
				num = (short)2055929857;
				if (num != 0)
				{
				}
				num = (short)1141702656;
				short num3 = num;
				num = (short)197918720;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay4_A36509;
			}
		}

		// Token: 0x17001B4E RID: 6990
		// (get) Token: 0x060035EA RID: 13802 RVA: 0x00338E20 File Offset: 0x00337020
		// (set) Token: 0x060035EB RID: 13803 RVA: 0x00338ED4 File Offset: 0x003370D4
		public bool RadWideGenLightBarPatternRelay4_A36509_Applicable
		{
			get
			{
				short num = (short)1702927096;
				short num2 = num;
				num = (short)1164679928;
				switch (num2 == num)
				{
				}
				num = (short)290455553;
				if (num != 0)
				{
				}
				num = (short)1052966912;
				short num3 = num;
				num = (short)1453981696;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay4_A36509.Applicable;
			}
			set
			{
				short num = (short)201872371;
				short num2 = num;
				num = (short)834491379;
				switch (num2 == num)
				{
				}
				num = (short)2031091713;
				if (num != 0)
				{
				}
				num = (short)174063616;
				short num3 = num;
				num = (short)2096431104;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay4_A36509.Applicable = value;
			}
		}

		// Token: 0x17001B4F RID: 6991
		// (get) Token: 0x060035EC RID: 13804 RVA: 0x00338F88 File Offset: 0x00337188
		// (set) Token: 0x060035ED RID: 13805 RVA: 0x00339040 File Offset: 0x00337240
		public bool RadWideGenLightBarPatternRelay4_A36509_Valid
		{
			get
			{
				short num = (short)815217545;
				short num2 = num;
				num = (short)1318534025;
				switch (num2 == num)
				{
				}
				num = (short)917504001;
				if (num != 0)
				{
				}
				num = (short)29491200;
				short num3 = num;
				num = (short)1185611776;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay4_A36509.Valid;
			}
			set
			{
				short num = (short)63317513;
				short num2 = num;
				num = (short)127411721;
				switch (num2 == num)
				{
				}
				num = (short)1101594624;
				if (num != 0)
				{
				}
				num = (short)593756160;
				short num3 = num;
				num = (short)1115815937;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay4_A36509.Valid = value;
			}
		}

		// Token: 0x17001B50 RID: 6992
		// (get) Token: 0x060035EE RID: 13806 RVA: 0x003390F8 File Offset: 0x003372F8
		// (set) Token: 0x060035EF RID: 13807 RVA: 0x003391AC File Offset: 0x003373AC
		public bool RadWideGenLightBarPatternRelay4_A36509_Visible
		{
			get
			{
				short num = (short)722530799;
				short num2 = num;
				num = (short)1873015279;
				switch (num2 == num)
				{
				}
				num = (short)1875247104;
				if (num != 0)
				{
				}
				num = (short)1950220288;
				short num3 = num;
				num = (short)1476067329;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay4_A36509.Visible;
			}
			set
			{
				short num = (short)543162369;
				if (num != 0)
				{
				}
				num = (short)1645172437;
				short num2 = num;
				num = (short)184506069;
				switch (num2 == num)
				{
				}
				num = (short)333381632;
				short num3 = num;
				num = (short)33488896;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay4_A36509.Visible = value;
			}
		}

		// Token: 0x17001B51 RID: 6993
		// (get) Token: 0x060035F0 RID: 13808 RVA: 0x00339264 File Offset: 0x00337464
		// (set) Token: 0x060035F1 RID: 13809 RVA: 0x0033931C File Offset: 0x0033751C
		public bool RadWideGenLightBarPatternRelay4_A36509_Editable
		{
			get
			{
				short num = (short)25264515;
				short num2 = num;
				num = (short)1380024707;
				switch (num2 == num)
				{
				}
				num = (short)108855297;
				if (num != 0)
				{
				}
				num = (short)114360320;
				short num3 = num;
				num = (short)746061824;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay4_A36509.Editable;
			}
			set
			{
				short num = (short)119306284;
				short num2 = num;
				num = (short)151418924;
				switch (num2 == num)
				{
				}
				num = (short)816971777;
				if (num != 0)
				{
				}
				num = (short)2116681728;
				short num3 = num;
				num = (short)1912012800;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay4_A36509.Editable = value;
			}
		}

		// Token: 0x17001B52 RID: 6994
		// (get) Token: 0x060035F2 RID: 13810 RVA: 0x003393CC File Offset: 0x003375CC
		internal string RadWideGenLightBarPatternRelay4_A36509_UILabel
		{
			get
			{
				short num = (short)1623005443;
				short num2 = num;
				num = (short)649337091;
				switch (num2 == num)
				{
				}
				num = (short)994639873;
				if (num != 0)
				{
				}
				num = (short)1866465280;
				short num3 = num;
				num = (short)1479213056;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay4_A36509.UIName;
			}
		}

		// Token: 0x17001B53 RID: 6995
		// (get) Token: 0x060035F3 RID: 13811 RVA: 0x00339480 File Offset: 0x00337680
		// (set) Token: 0x060035F4 RID: 13812 RVA: 0x00339534 File Offset: 0x00337734
		internal bool RadWideGenLightBarPatternRelay4_A36509_HiddenStatic
		{
			get
			{
				short num = (short)1950536841;
				short num2 = num;
				num = (short)1077073033;
				switch (num2 == num)
				{
				}
				num = (short)1881210880;
				if (num != 0)
				{
				}
				num = (short)593559552;
				short num3 = num;
				num = (short)1658257409;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay4_A36509.HiddenStatic;
			}
			set
			{
				short num = (short)1376265940;
				short num2 = num;
				num = (short)1934829268;
				switch (num2 == num)
				{
				}
				num = (short)2134376449;
				if (num != 0)
				{
				}
				num = (short)926679040;
				short num3 = num;
				num = (short)1722286080;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay4_A36509.HiddenStatic = value;
			}
		}

		// Token: 0x17001B54 RID: 6996
		// (get) Token: 0x060035F5 RID: 13813 RVA: 0x003395E8 File Offset: 0x003377E8
		// (set) Token: 0x060035F6 RID: 13814 RVA: 0x003396A0 File Offset: 0x003378A0
		internal bool RadWideGenLightBarPatternRelay4_A36509_HiddenDynamic
		{
			get
			{
				short num = (short)158725101;
				short num2 = num;
				num = (short)602469357;
				switch (num2 == num)
				{
				}
				num = (short)826343425;
				if (num != 0)
				{
				}
				num = (short)722075648;
				short num3 = num;
				num = (short)1367080960;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay4_A36509.HiddenDynamic;
			}
			set
			{
				short num = (short)1744161484;
				short num2 = num;
				num = (short)769379020;
				switch (num2 == num)
				{
				}
				num = (short)1634533377;
				if (num != 0)
				{
				}
				num = (short)301137920;
				short num3 = num;
				num = (short)1240399872;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay4_A36509.HiddenDynamic = value;
			}
		}

		// Token: 0x17001B55 RID: 6997
		// (get) Token: 0x060035F7 RID: 13815 RVA: 0x0033975C File Offset: 0x0033795C
		public bool RadWideGenLightBarPatternRelay4_A36509_HasDiffs
		{
			get
			{
				short num = (short)885537295;
				short num2 = num;
				num = (short)998586895;
				switch (num2 == num)
				{
				}
				num = (short)951779328;
				if (num != 0)
				{
				}
				num = (short)1178468352;
				short num3 = num;
				num = (short)895811585;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay4_A36509._HasDiffs;
			}
		}

		// Token: 0x17001B56 RID: 6998
		// (get) Token: 0x060035F8 RID: 13816 RVA: 0x00339810 File Offset: 0x00337A10
		// (set) Token: 0x060035F9 RID: 13817 RVA: 0x003398C8 File Offset: 0x00337AC8
		public int RadWideGenLightBarPatternRelay5_A36510Value
		{
			get
			{
				short num = (short)1106970286;
				short num2 = num;
				num = (short)1710753454;
				switch (num2 == num)
				{
				}
				num = (short)552927233;
				if (num != 0)
				{
				}
				num = (short)1592590336;
				short num3 = num;
				num = (short)2028470272;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay5_A36510.Value;
			}
			set
			{
				short num = (short)524840434;
				short num2 = num;
				num = (short)1279553010;
				switch (num2 == num)
				{
				}
				num = (short)135004160;
				if (num != 0)
				{
				}
				num = (short)414908416;
				short num3 = num;
				num = (short)1510670337;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay5_A36510.Value = value;
			}
		}

		// Token: 0x17001B57 RID: 6999
		// (get) Token: 0x060035FA RID: 13818 RVA: 0x00339980 File Offset: 0x00337B80
		// (set) Token: 0x060035FB RID: 13819 RVA: 0x00339A34 File Offset: 0x00337C34
		public string RadWideGenLightBarPatternRelay5_A36510_UIValue
		{
			get
			{
				short num = (short)1731929644;
				short num2 = num;
				num = (short)1636116012;
				switch (num2 == num)
				{
				}
				num = (short)425328641;
				if (num != 0)
				{
				}
				num = (short)1490092032;
				short num3 = num;
				num = (short)115146752;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay5_A36510.UIValue;
			}
			set
			{
				short num = (short)430202227;
				short num2 = num;
				num = (short)42032499;
				switch (num2 == num)
				{
				}
				num = (short)131268608;
				if (num != 0)
				{
				}
				num = (short)1059258368;
				short num3 = num;
				num = (short)1502609409;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay5_A36510.UIValue = value;
			}
		}

		// Token: 0x17001B58 RID: 7000
		// (get) Token: 0x060035FC RID: 13820 RVA: 0x00339AEC File Offset: 0x00337CEC
		public global::AcpBusinessLayer.AcpListField RadWideGenLightBarPatternRelay5_A36510
		{
			get
			{
				short num = (short)109828783;
				short num2 = num;
				num = (short)652794543;
				switch (num2 == num)
				{
				}
				num = (short)221315072;
				if (num != 0)
				{
				}
				num = (short)2026766336;
				short num3 = num;
				num = (short)1869217793;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay5_A36510;
			}
		}

		// Token: 0x17001B59 RID: 7001
		// (get) Token: 0x060035FD RID: 13821 RVA: 0x00339B9C File Offset: 0x00337D9C
		// (set) Token: 0x060035FE RID: 13822 RVA: 0x00339C50 File Offset: 0x00337E50
		public bool RadWideGenLightBarPatternRelay5_A36510_Applicable
		{
			get
			{
				short num = (short)1288976261;
				short num2 = num;
				num = (short)149698437;
				switch (num2 == num)
				{
				}
				num = (short)705298432;
				if (num != 0)
				{
				}
				num = (short)58195968;
				short num3 = num;
				num = (short)744423425;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay5_A36510.Applicable;
			}
			set
			{
				short num = (short)1323564355;
				short num2 = num;
				num = (short)727579971;
				switch (num2 == num)
				{
				}
				num = (short)1419116544;
				if (num != 0)
				{
				}
				num = (short)337838080;
				short num3 = num;
				num = (short)758054913;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay5_A36510.Applicable = value;
			}
		}

		// Token: 0x17001B5A RID: 7002
		// (get) Token: 0x060035FF RID: 13823 RVA: 0x00339D08 File Offset: 0x00337F08
		// (set) Token: 0x06003600 RID: 13824 RVA: 0x00339DBC File Offset: 0x00337FBC
		public bool RadWideGenLightBarPatternRelay5_A36510_Valid
		{
			get
			{
				short num = (short)1710834417;
				short num2 = num;
				num = (short)214582001;
				switch (num2 == num)
				{
				}
				num = (short)1257570305;
				if (num != 0)
				{
				}
				num = (short)277282816;
				short num3 = num;
				num = (short)126812160;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay5_A36510.Valid;
			}
			set
			{
				short num = (short)17686634;
				short num2 = num;
				num = (short)1948704874;
				switch (num2 == num)
				{
				}
				num = (short)1145896960;
				if (num != 0)
				{
				}
				num = (short)635305984;
				short num3 = num;
				num = (short)1672740865;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay5_A36510.Valid = value;
			}
		}

		// Token: 0x17001B5B RID: 7003
		// (get) Token: 0x06003601 RID: 13825 RVA: 0x00339E74 File Offset: 0x00338074
		// (set) Token: 0x06003602 RID: 13826 RVA: 0x00339F28 File Offset: 0x00338128
		public bool RadWideGenLightBarPatternRelay5_A36510_Visible
		{
			get
			{
				short num = (short)822752495;
				short num2 = num;
				num = (short)766653679;
				switch (num2 == num)
				{
				}
				num = (short)1795031041;
				if (num != 0)
				{
				}
				num = (short)1083703296;
				short num3 = num;
				num = (short)2000748544;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay5_A36510.Visible;
			}
			set
			{
				short num = (short)379517434;
				short num2 = num;
				num = (short)217905658;
				switch (num2 == num)
				{
				}
				num = (short)1784152064;
				if (num != 0)
				{
				}
				num = (short)1054736384;
				short num3 = num;
				num = (short)762511361;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay5_A36510.Visible = value;
			}
		}

		// Token: 0x17001B5C RID: 7004
		// (get) Token: 0x06003603 RID: 13827 RVA: 0x00339FE0 File Offset: 0x003381E0
		// (set) Token: 0x06003604 RID: 13828 RVA: 0x0033A094 File Offset: 0x00338294
		public bool RadWideGenLightBarPatternRelay5_A36510_Editable
		{
			get
			{
				short num = (short)1069504084;
				short num2 = num;
				num = (short)1702581844;
				switch (num2 == num)
				{
				}
				num = (short)1900545;
				if (num != 0)
				{
				}
				num = (short)1551695872;
				short num3 = num;
				num = (short)1252327424;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay5_A36510.Editable;
			}
			set
			{
				short num = (short)1436458193;
				short num2 = num;
				num = (short)271228113;
				switch (num2 == num)
				{
				}
				num = (short)1976696833;
				if (num != 0)
				{
				}
				num = (short)1605238784;
				short num3 = num;
				num = (short)1920925696;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay5_A36510.Editable = value;
			}
		}

		// Token: 0x17001B5D RID: 7005
		// (get) Token: 0x06003605 RID: 13829 RVA: 0x0033A14C File Offset: 0x0033834C
		internal string RadWideGenLightBarPatternRelay5_A36510_UILabel
		{
			get
			{
				short num = (short)249808073;
				short num2 = num;
				num = (short)435143881;
				switch (num2 == num)
				{
				}
				num = (short)1937047553;
				if (num != 0)
				{
				}
				num = (short)1114177536;
				short num3 = num;
				num = (short)1976041472;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay5_A36510.UIName;
			}
		}

		// Token: 0x17001B5E RID: 7006
		// (get) Token: 0x06003606 RID: 13830 RVA: 0x0033A200 File Offset: 0x00338400
		// (set) Token: 0x06003607 RID: 13831 RVA: 0x0033A2B8 File Offset: 0x003384B8
		internal bool RadWideGenLightBarPatternRelay5_A36510_HiddenStatic
		{
			get
			{
				short num = (short)1293037390;
				short num2 = num;
				num = (short)724840270;
				switch (num2 == num)
				{
				}
				num = (short)206503937;
				if (num != 0)
				{
				}
				num = (short)1981415424;
				short num3 = num;
				num = (short)1147076608;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay5_A36510.HiddenStatic;
			}
			set
			{
				short num = (short)1846124665;
				short num2 = num;
				num = (short)932946041;
				switch (num2 == num)
				{
				}
				num = (short)686489600;
				if (num != 0)
				{
				}
				num = (short)928841728;
				short num3 = num;
				num = (short)652673025;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay5_A36510.HiddenStatic = value;
			}
		}

		// Token: 0x17001B5F RID: 7007
		// (get) Token: 0x06003608 RID: 13832 RVA: 0x0033A36C File Offset: 0x0033856C
		// (set) Token: 0x06003609 RID: 13833 RVA: 0x0033A420 File Offset: 0x00338620
		internal bool RadWideGenLightBarPatternRelay5_A36510_HiddenDynamic
		{
			get
			{
				short num = (short)122034548;
				short num2 = num;
				num = (short)108861812;
				switch (num2 == num)
				{
				}
				num = (short)2002255873;
				if (num != 0)
				{
				}
				num = (short)1341194240;
				short num3 = num;
				num = (short)1383530496;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay5_A36510.HiddenDynamic;
			}
			set
			{
				short num = (short)1054234127;
				short num2 = num;
				num = (short)1863341583;
				switch (num2 == num)
				{
				}
				num = (short)533463041;
				if (num != 0)
				{
				}
				num = (short)1807745024;
				short num3 = num;
				num = (short)548732928;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay5_A36510.HiddenDynamic = value;
			}
		}

		// Token: 0x17001B60 RID: 7008
		// (get) Token: 0x0600360A RID: 13834 RVA: 0x0033A4D4 File Offset: 0x003386D4
		public bool RadWideGenLightBarPatternRelay5_A36510_HasDiffs
		{
			get
			{
				short num = (short)461784079;
				short num2 = num;
				num = (short)1114326031;
				switch (num2 == num)
				{
				}
				num = (short)461176833;
				if (num != 0)
				{
				}
				num = (short)1236598784;
				short num3 = num;
				num = (short)1089798144;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay5_A36510._HasDiffs;
			}
		}

		// Token: 0x17001B61 RID: 7009
		// (get) Token: 0x0600360B RID: 13835 RVA: 0x0033A588 File Offset: 0x00338788
		// (set) Token: 0x0600360C RID: 13836 RVA: 0x0033A640 File Offset: 0x00338840
		public int RadWideGenLightBarPatternRelay6_A36511Value
		{
			get
			{
				short num = (short)944798079;
				short num2 = num;
				num = (short)1521056127;
				switch (num2 == num)
				{
				}
				num = (short)1725825024;
				if (num != 0)
				{
				}
				num = (short)629932032;
				short num3 = num;
				num = (short)368771073;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay6_A36511.Value;
			}
			set
			{
				short num = (short)1569346166;
				short num2 = num;
				num = (short)878400118;
				switch (num2 == num)
				{
				}
				num = (short)1207369728;
				if (num != 0)
				{
				}
				num = (short)733478912;
				short num3 = num;
				num = (short)2014380033;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay6_A36511.Value = value;
			}
		}

		// Token: 0x17001B62 RID: 7010
		// (get) Token: 0x0600360D RID: 13837 RVA: 0x0033A6F8 File Offset: 0x003388F8
		// (set) Token: 0x0600360E RID: 13838 RVA: 0x0033A7AC File Offset: 0x003389AC
		public string RadWideGenLightBarPatternRelay6_A36511_UIValue
		{
			get
			{
				short num = (short)1624660238;
				short num2 = num;
				num = (short)2023643406;
				switch (num2 == num)
				{
				default:
				{
					num = (short)684851200;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)485621761;
				if (num != 0)
				{
				}
				num = (short)1972502528;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay6_A36511.UIValue;
			}
			set
			{
				short num = (short)660479993;
				short num2 = num;
				num = (short)718020601;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2092826624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1395589121;
				if (num != 0)
				{
				}
				num = (short)2069364736;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay6_A36511.UIValue = value;
			}
		}

		// Token: 0x17001B63 RID: 7011
		// (get) Token: 0x0600360F RID: 13839 RVA: 0x0033A860 File Offset: 0x00338A60
		public global::AcpBusinessLayer.AcpListField RadWideGenLightBarPatternRelay6_A36511
		{
			get
			{
				short num = (short)1006829569;
				if (num != 0)
				{
				}
				num = (short)604438528;
				short num2 = num;
				num = (short)68460337;
				short num3 = num;
				num = (short)830316337;
				switch (num3 == num)
				{
				}
				num = (short)1495793664;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay6_A36511;
			}
		}

		// Token: 0x17001B64 RID: 7012
		// (get) Token: 0x06003610 RID: 13840 RVA: 0x0033A90C File Offset: 0x00338B0C
		// (set) Token: 0x06003611 RID: 13841 RVA: 0x0033A9C0 File Offset: 0x00338BC0
		public bool RadWideGenLightBarPatternRelay6_A36511_Applicable
		{
			get
			{
				short num = (short)939527050;
				short num2 = num;
				num = (short)1811745674;
				switch (num2 == num)
				{
				default:
				{
					num = (short)45154304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1213661184;
				if (num != 0)
				{
				}
				num = (short)1637154817;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay6_A36511.Applicable;
			}
			set
			{
				short num = (short)358889818;
				short num2 = num;
				num = (short)561854810;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1131610112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1338638336;
				if (num != 0)
				{
				}
				num = (short)940179457;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay6_A36511.Applicable = value;
			}
		}

		// Token: 0x17001B65 RID: 7013
		// (get) Token: 0x06003612 RID: 13842 RVA: 0x0033AA74 File Offset: 0x00338C74
		// (set) Token: 0x06003613 RID: 13843 RVA: 0x0033AB2C File Offset: 0x00338D2C
		public bool RadWideGenLightBarPatternRelay6_A36511_Valid
		{
			get
			{
				short num = (short)948147958;
				short num2 = num;
				num = (short)1311872758;
				switch (num2 == num)
				{
				default:
				{
					num = (short)281870336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1679425536;
				if (num != 0)
				{
				}
				num = (short)1436418049;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay6_A36511.Valid;
			}
			set
			{
				short num = (short)443809793;
				if (num != 0)
				{
				}
				num = (short)1269825536;
				short num2 = num;
				num = (short)236793119;
				short num3 = num;
				num = (short)1680289055;
				switch (num3 == num)
				{
				}
				num = (short)486211584;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay6_A36511.Valid = value;
			}
		}

		// Token: 0x17001B66 RID: 7014
		// (get) Token: 0x06003614 RID: 13844 RVA: 0x0033ABE0 File Offset: 0x00338DE0
		// (set) Token: 0x06003615 RID: 13845 RVA: 0x0033AC94 File Offset: 0x00338E94
		public bool RadWideGenLightBarPatternRelay6_A36511_Visible
		{
			get
			{
				short num = (short)9933606;
				short num2 = num;
				num = (short)1267372838;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1203306496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2096824320;
				if (num != 0)
				{
				}
				num = (short)478871553;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay6_A36511.Visible;
			}
			set
			{
				short num = (short)1436788852;
				short num2 = num;
				num = (short)1682286708;
				switch (num2 == num)
				{
				default:
				{
					num = (short)447217664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1402404865;
				if (num != 0)
				{
				}
				num = (short)754712576;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay6_A36511.Visible = value;
			}
		}

		// Token: 0x17001B67 RID: 7015
		// (get) Token: 0x06003616 RID: 13846 RVA: 0x0033AD48 File Offset: 0x00338F48
		// (set) Token: 0x06003617 RID: 13847 RVA: 0x0033ADFC File Offset: 0x00338FFC
		public bool RadWideGenLightBarPatternRelay6_A36511_Editable
		{
			get
			{
				short num = (short)781217919;
				short num2 = num;
				num = (short)590573695;
				switch (num2 == num)
				{
				default:
				{
					num = (short)712966144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)35127297;
				if (num != 0)
				{
				}
				num = (short)747634688;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay6_A36511.Editable;
			}
			set
			{
				short num = (short)1604123050;
				short num2 = num;
				num = (short)1013184938;
				switch (num2 == num)
				{
				default:
				{
					num = (short)586219520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1024065536;
				if (num != 0)
				{
				}
				num = (short)1024786433;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay6_A36511.Editable = value;
			}
		}

		// Token: 0x17001B68 RID: 7016
		// (get) Token: 0x06003618 RID: 13848 RVA: 0x0033AEB0 File Offset: 0x003390B0
		internal string RadWideGenLightBarPatternRelay6_A36511_UILabel
		{
			get
			{
				short num = (short)1375010817;
				if (num != 0)
				{
				}
				num = (short)2123235328;
				short num2 = num;
				num = (short)337327856;
				short num3 = num;
				num = (short)753940208;
				switch (num3 == num)
				{
				}
				num = (short)1808662528;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay6_A36511.UIName;
			}
		}

		// Token: 0x17001B69 RID: 7017
		// (get) Token: 0x06003619 RID: 13849 RVA: 0x0033AF64 File Offset: 0x00339164
		// (set) Token: 0x0600361A RID: 13850 RVA: 0x0033B01C File Offset: 0x0033921C
		internal bool RadWideGenLightBarPatternRelay6_A36511_HiddenStatic
		{
			get
			{
				short num = (short)1725624315;
				short num2 = num;
				num = (short)1947004923;
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
				num = (short)1112342528;
				if (num != 0)
				{
				}
				num = (short)1050083329;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay6_A36511.HiddenStatic;
			}
			set
			{
				short num = (short)507729854;
				short num2 = num;
				num = (short)1449285566;
				switch (num2 == num)
				{
				default:
				{
					num = (short)258211840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)957743105;
				if (num != 0)
				{
				}
				num = (short)919339008;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay6_A36511.HiddenStatic = value;
			}
		}

		// Token: 0x17001B6A RID: 7018
		// (get) Token: 0x0600361B RID: 13851 RVA: 0x0033B0D4 File Offset: 0x003392D4
		// (set) Token: 0x0600361C RID: 13852 RVA: 0x0033B18C File Offset: 0x0033938C
		internal bool RadWideGenLightBarPatternRelay6_A36511_HiddenDynamic
		{
			get
			{
				short num = (short)1482722035;
				short num2 = num;
				num = (short)374246131;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1457979392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)329252865;
				if (num != 0)
				{
				}
				num = (short)145424384;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay6_A36511.HiddenDynamic;
			}
			set
			{
				short num = (short)906540825;
				short num2 = num;
				num = (short)76396313;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1208352768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)38797312;
				if (num != 0)
				{
				}
				num = (short)600571905;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay6_A36511.HiddenDynamic = value;
			}
		}

		// Token: 0x17001B6B RID: 7019
		// (get) Token: 0x0600361D RID: 13853 RVA: 0x0033B240 File Offset: 0x00339440
		public bool RadWideGenLightBarPatternRelay6_A36511_HasDiffs
		{
			get
			{
				short num = (short)530455205;
				short num2 = num;
				num = (short)1314462373;
				switch (num2 == num)
				{
				default:
				{
					num = (short)782368768;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1748697089;
				if (num != 0)
				{
				}
				num = (short)1822752768;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay6_A36511._HasDiffs;
			}
		}

		// Token: 0x17001B6C RID: 7020
		// (get) Token: 0x0600361E RID: 13854 RVA: 0x0033B2F4 File Offset: 0x003394F4
		// (set) Token: 0x0600361F RID: 13855 RVA: 0x0033B3A8 File Offset: 0x003395A8
		public int RadWideGenLightBarPatternRelay7_A36512Value
		{
			get
			{
				short num = (short)502259952;
				short num2 = num;
				num = (short)464183536;
				switch (num2 == num)
				{
				default:
				{
					num = (short)46530560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)440401921;
				if (num != 0)
				{
				}
				num = (short)555286528;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay7_A36512.Value;
			}
			set
			{
				short num = (short)1636371949;
				short num2 = num;
				num = (short)1693978093;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1358561280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)329449473;
				if (num != 0)
				{
				}
				num = (short)981532672;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay7_A36512.Value = value;
			}
		}

		// Token: 0x17001B6D RID: 7021
		// (get) Token: 0x06003620 RID: 13856 RVA: 0x0033B45C File Offset: 0x0033965C
		// (set) Token: 0x06003621 RID: 13857 RVA: 0x0033B510 File Offset: 0x00339710
		public string RadWideGenLightBarPatternRelay7_A36512_UIValue
		{
			get
			{
				short num = (short)2088867415;
				short num2 = num;
				num = (short)1413453399;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1268514816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1706295297;
				if (num != 0)
				{
				}
				num = (short)1113194496;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay7_A36512.UIValue;
			}
			set
			{
				short num = (short)299980806;
				short num2 = num;
				num = (short)1847351302;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1985609728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)269287425;
				if (num != 0)
				{
				}
				num = (short)236781568;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay7_A36512.UIValue = value;
			}
		}

		// Token: 0x17001B6E RID: 7022
		// (get) Token: 0x06003622 RID: 13858 RVA: 0x0033B5C8 File Offset: 0x003397C8
		public global::AcpBusinessLayer.AcpListField RadWideGenLightBarPatternRelay7_A36512
		{
			get
			{
				short num = (short)1893102472;
				short num2 = num;
				num = (short)1428517768;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1619853312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)784072705;
				if (num != 0)
				{
				}
				num = (short)963117056;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay7_A36512;
			}
		}

		// Token: 0x17001B6F RID: 7023
		// (get) Token: 0x06003623 RID: 13859 RVA: 0x0033B678 File Offset: 0x00339878
		// (set) Token: 0x06003624 RID: 13860 RVA: 0x0033B72C File Offset: 0x0033992C
		public bool RadWideGenLightBarPatternRelay7_A36512_Applicable
		{
			get
			{
				short num = (short)621938329;
				short num2 = num;
				num = (short)526780057;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1745485824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)350093313;
				if (num != 0)
				{
				}
				num = (short)569049088;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay7_A36512.Applicable;
			}
			set
			{
				short num = (short)1967467535;
				short num2 = num;
				num = (short)510143503;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1839071232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1761148928;
				if (num != 0)
				{
				}
				num = (short)1164181505;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay7_A36512.Applicable = value;
			}
		}

		// Token: 0x17001B70 RID: 7024
		// (get) Token: 0x06003625 RID: 13861 RVA: 0x0033B7E4 File Offset: 0x003399E4
		// (set) Token: 0x06003626 RID: 13862 RVA: 0x0033B898 File Offset: 0x00339A98
		public bool RadWideGenLightBarPatternRelay7_A36512_Valid
		{
			get
			{
				short num = (short)1346608026;
				short num2 = num;
				num = (short)1968872346;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1453195264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1609957377;
				if (num != 0)
				{
				}
				num = (short)1922891776;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay7_A36512.Valid;
			}
			set
			{
				short num = (short)740145668;
				short num2 = num;
				num = (short)874560004;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1106706432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)11599873;
				if (num != 0)
				{
				}
				num = (short)567476224;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay7_A36512.Valid = value;
			}
		}

		// Token: 0x17001B71 RID: 7025
		// (get) Token: 0x06003627 RID: 13863 RVA: 0x0033B94C File Offset: 0x00339B4C
		// (set) Token: 0x06003628 RID: 13864 RVA: 0x0033BA04 File Offset: 0x00339C04
		public bool RadWideGenLightBarPatternRelay7_A36512_Visible
		{
			get
			{
				short num = (short)1009499322;
				short num2 = num;
				num = (short)1841872058;
				switch (num2 == num)
				{
				default:
				{
					num = (short)488570880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1804271616;
				if (num != 0)
				{
				}
				num = (short)1917779969;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay7_A36512.Visible;
			}
			set
			{
				short num = (short)631589086;
				short num2 = num;
				num = (short)1173833950;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1285685248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)747044865;
				if (num != 0)
				{
				}
				num = (short)7929856;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay7_A36512.Visible = value;
			}
		}

		// Token: 0x17001B72 RID: 7026
		// (get) Token: 0x06003629 RID: 13865 RVA: 0x0033BAB8 File Offset: 0x00339CB8
		// (set) Token: 0x0600362A RID: 13866 RVA: 0x0033BB6C File Offset: 0x00339D6C
		public bool RadWideGenLightBarPatternRelay7_A36512_Editable
		{
			get
			{
				short num = (short)1380087946;
				short num2 = num;
				num = (short)161446026;
				switch (num2 == num)
				{
				default:
				{
					num = (short)622133248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1106378753;
				if (num != 0)
				{
				}
				num = (short)1425276928;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay7_A36512.Editable;
			}
			set
			{
				short num = (short)1429256981;
				short num2 = num;
				num = (short)1218886421;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1582956544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1415118849;
				if (num != 0)
				{
				}
				num = (short)865337344;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay7_A36512.Editable = value;
			}
		}

		// Token: 0x17001B73 RID: 7027
		// (get) Token: 0x0600362B RID: 13867 RVA: 0x0033BC24 File Offset: 0x00339E24
		internal string RadWideGenLightBarPatternRelay7_A36512_UILabel
		{
			get
			{
				short num = (short)20828356;
				short num2 = num;
				num = (short)1777651908;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1238564864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1558839296;
				if (num != 0)
				{
				}
				num = (short)576323585;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay7_A36512.UIName;
			}
		}

		// Token: 0x17001B74 RID: 7028
		// (get) Token: 0x0600362C RID: 13868 RVA: 0x0033BCD8 File Offset: 0x00339ED8
		// (set) Token: 0x0600362D RID: 13869 RVA: 0x0033BD8C File Offset: 0x00339F8C
		internal bool RadWideGenLightBarPatternRelay7_A36512_HiddenStatic
		{
			get
			{
				short num = (short)1634643934;
				short num2 = num;
				num = (short)893890526;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1299120128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1712783360;
				if (num != 0)
				{
				}
				num = (short)690028545;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay7_A36512.HiddenStatic;
			}
			set
			{
				short num = (short)1448300877;
				short num2 = num;
				num = (short)624972109;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1776025600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)31260673;
				if (num != 0)
				{
				}
				num = (short)1480916992;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay7_A36512.HiddenStatic = value;
			}
		}

		// Token: 0x17001B75 RID: 7029
		// (get) Token: 0x0600362E RID: 13870 RVA: 0x0033BE40 File Offset: 0x0033A040
		// (set) Token: 0x0600362F RID: 13871 RVA: 0x0033BEF8 File Offset: 0x0033A0F8
		internal bool RadWideGenLightBarPatternRelay7_A36512_HiddenDynamic
		{
			get
			{
				short num = (short)1207953305;
				short num2 = num;
				num = (short)416802713;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1746731008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)605159425;
				if (num != 0)
				{
				}
				num = (short)736559104;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay7_A36512.HiddenDynamic;
			}
			set
			{
				short num = (short)235253151;
				short num2 = num;
				num = (short)586001823;
				switch (num2 == num)
				{
				default:
				{
					num = (short)347930624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)372637696;
				if (num != 0)
				{
				}
				num = (short)646905857;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay7_A36512.HiddenDynamic = value;
			}
		}

		// Token: 0x17001B76 RID: 7030
		// (get) Token: 0x06003630 RID: 13872 RVA: 0x0033BFAC File Offset: 0x0033A1AC
		public bool RadWideGenLightBarPatternRelay7_A36512_HasDiffs
		{
			get
			{
				short num = (short)1168526840;
				short num2 = num;
				num = (short)1684033016;
				switch (num2 == num)
				{
				default:
				{
					num = (short)250281984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1820917761;
				if (num != 0)
				{
				}
				num = (short)907018240;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay7_A36512._HasDiffs;
			}
		}

		// Token: 0x17001B77 RID: 7031
		// (get) Token: 0x06003631 RID: 13873 RVA: 0x0033C060 File Offset: 0x0033A260
		// (set) Token: 0x06003632 RID: 13874 RVA: 0x0033C114 File Offset: 0x0033A314
		public int RadWideGenLightBarPatternRelay8_A36513Value
		{
			get
			{
				short num = (short)1634140161;
				if (num != 0)
				{
				}
				num = (short)1283391488;
				short num2 = num;
				num = (short)60262138;
				short num3 = num;
				num = (short)1484162810;
				switch (num3 == num)
				{
				}
				num = (short)334168064;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay8_A36513.Value;
			}
			set
			{
				short num = (short)1494831593;
				short num2 = num;
				num = (short)1927041513;
				switch (num2 == num)
				{
				default:
				{
					num = (short)112787456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1727070208;
				if (num != 0)
				{
				}
				num = (short)1180827649;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay8_A36513.Value = value;
			}
		}

		// Token: 0x17001B78 RID: 7032
		// (get) Token: 0x06003633 RID: 13875 RVA: 0x0033C1C8 File Offset: 0x0033A3C8
		// (set) Token: 0x06003634 RID: 13876 RVA: 0x0033C278 File Offset: 0x0033A478
		public string RadWideGenLightBarPatternRelay8_A36513_UIValue
		{
			get
			{
				short num = (short)2139660628;
				short num2 = num;
				num = (short)102015316;
				switch (num2 == num)
				{
				default:
				{
					num = (short)931069952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)951779328;
				if (num != 0)
				{
				}
				num = (short)340656129;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay8_A36513.UIValue;
			}
			set
			{
				short num = (short)492478606;
				short num2 = num;
				num = (short)721461390;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1001652224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)265748480;
				if (num != 0)
				{
				}
				num = (short)1648164865;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay8_A36513.UIValue = value;
			}
		}

		// Token: 0x17001B79 RID: 7033
		// (get) Token: 0x06003635 RID: 13877 RVA: 0x0033C32C File Offset: 0x0033A52C
		public global::AcpBusinessLayer.AcpListField RadWideGenLightBarPatternRelay8_A36513
		{
			get
			{
				short num = (short)1953026083;
				short num2 = num;
				num = (short)1082904611;
				switch (num2 == num)
				{
				default:
				{
					num = (short)47775744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1835663361;
				if (num != 0)
				{
				}
				num = (short)289603584;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay8_A36513;
			}
		}

		// Token: 0x17001B7A RID: 7034
		// (get) Token: 0x06003636 RID: 13878 RVA: 0x0033C3DC File Offset: 0x0033A5DC
		// (set) Token: 0x06003637 RID: 13879 RVA: 0x0033C494 File Offset: 0x0033A694
		public bool RadWideGenLightBarPatternRelay8_A36513_Applicable
		{
			get
			{
				short num = (short)1805889483;
				short num2 = num;
				num = (short)1114746827;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1391788032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1338638336;
				if (num != 0)
				{
				}
				num = (short)9764865;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay8_A36513.Applicable;
			}
			set
			{
				short num = (short)1675900918;
				short num2 = num;
				num = (short)708851702;
				switch (num2 == num)
				{
				default:
				{
					num = (short)923467776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1065615361;
				if (num != 0)
				{
				}
				num = (short)203554816;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay8_A36513.Applicable = value;
			}
		}

		// Token: 0x17001B7B RID: 7035
		// (get) Token: 0x06003638 RID: 13880 RVA: 0x0033C54C File Offset: 0x0033A74C
		// (set) Token: 0x06003639 RID: 13881 RVA: 0x0033C600 File Offset: 0x0033A800
		public bool RadWideGenLightBarPatternRelay8_A36513_Valid
		{
			get
			{
				short num = (short)1209910384;
				short num2 = num;
				num = (short)1081001072;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1974796288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1167589376;
				if (num != 0)
				{
				}
				num = (short)735313921;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay8_A36513.Valid;
			}
			set
			{
				short num = (short)1281425488;
				short num2 = num;
				num = (short)1464926288;
				switch (num2 == num)
				{
				}
				num = (short)725614593;
				if (num != 0)
				{
				}
				num = (short)2030764032;
				if (num != 0)
				{
				}
				num = (short)619511808;
				short num3 = num;
				this.radWideGenLightBarPatternRelay8_A36513.Valid = value;
			}
		}

		// Token: 0x17001B7C RID: 7036
		// (get) Token: 0x0600363A RID: 13882 RVA: 0x0033C6BC File Offset: 0x0033A8BC
		// (set) Token: 0x0600363B RID: 13883 RVA: 0x0033C774 File Offset: 0x0033A974
		public bool RadWideGenLightBarPatternRelay8_A36513_Visible
		{
			get
			{
				short num = (short)1317216099;
				short num2 = num;
				num = (short)1259937635;
				switch (num2 == num)
				{
				}
				num = (short)1276182529;
				if (num != 0)
				{
				}
				num = (short)1155203072;
				if (num != 0)
				{
				}
				num = (short)1761738752;
				short num3 = num;
				return this.radWideGenLightBarPatternRelay8_A36513.Visible;
			}
			set
			{
				short num = (short)1540598997;
				short num2 = num;
				num = (short)211135701;
				switch (num2 == num)
				{
				}
				num = (short)1318584321;
				if (num != 0)
				{
				}
				num = (short)1968701440;
				if (num != 0)
				{
				}
				num = (short)2123890688;
				short num3 = num;
				this.radWideGenLightBarPatternRelay8_A36513.Visible = value;
			}
		}

		// Token: 0x17001B7D RID: 7037
		// (get) Token: 0x0600363C RID: 13884 RVA: 0x0033C828 File Offset: 0x0033AA28
		// (set) Token: 0x0600363D RID: 13885 RVA: 0x0033C8DC File Offset: 0x0033AADC
		public bool RadWideGenLightBarPatternRelay8_A36513_Editable
		{
			get
			{
				short num = (short)1508179969;
				if (num != 0)
				{
				}
				num = (short)2144038154;
				short num2 = num;
				num = (short)787377418;
				switch (num2 == num)
				{
				}
				num = (short)1133445120;
				if (num != 0)
				{
				}
				num = (short)910426112;
				short num3 = num;
				return this.radWideGenLightBarPatternRelay8_A36513.Editable;
			}
			set
			{
				short num = (short)771859546;
				short num2 = num;
				num = (short)912630874;
				switch (num2 == num)
				{
				}
				num = (short)299499520;
				if (num != 0)
				{
				}
				num = (short)299302913;
				if (num != 0)
				{
				}
				num = (short)402587648;
				short num3 = num;
				this.radWideGenLightBarPatternRelay8_A36513.Editable = value;
			}
		}

		// Token: 0x17001B7E RID: 7038
		// (get) Token: 0x0600363E RID: 13886 RVA: 0x0033C990 File Offset: 0x0033AB90
		internal string RadWideGenLightBarPatternRelay8_A36513_UILabel
		{
			get
			{
				short num = (short)1561127264;
				short num2 = num;
				num = (short)1590356320;
				switch (num2 == num)
				{
				}
				num = (short)1966931968;
				if (num != 0)
				{
				}
				num = (short)879362049;
				if (num != 0)
				{
				}
				num = (short)1401683968;
				short num3 = num;
				return this.radWideGenLightBarPatternRelay8_A36513.UIName;
			}
		}

		// Token: 0x17001B7F RID: 7039
		// (get) Token: 0x0600363F RID: 13887 RVA: 0x0033CA48 File Offset: 0x0033AC48
		// (set) Token: 0x06003640 RID: 13888 RVA: 0x0033CAFC File Offset: 0x0033ACFC
		internal bool RadWideGenLightBarPatternRelay8_A36513_HiddenStatic
		{
			get
			{
				short num = (short)335740622;
				short num2 = num;
				num = (short)2111373006;
				switch (num2 == num)
				{
				}
				num = (short)865271808;
				if (num != 0)
				{
				}
				num = (short)151846913;
				if (num != 0)
				{
				}
				num = (short)2038890496;
				short num3 = num;
				return this.radWideGenLightBarPatternRelay8_A36513.HiddenStatic;
			}
			set
			{
				short num = (short)1385067807;
				short num2 = num;
				num = (short)1110734111;
				switch (num2 == num)
				{
				}
				num = (short)1377632257;
				if (num != 0)
				{
				}
				num = (short)1524432896;
				if (num != 0)
				{
				}
				num = (short)1111490560;
				short num3 = num;
				this.radWideGenLightBarPatternRelay8_A36513.HiddenStatic = value;
			}
		}

		// Token: 0x17001B80 RID: 7040
		// (get) Token: 0x06003641 RID: 13889 RVA: 0x0033CBB4 File Offset: 0x0033ADB4
		// (set) Token: 0x06003642 RID: 13890 RVA: 0x0033CC68 File Offset: 0x0033AE68
		internal bool RadWideGenLightBarPatternRelay8_A36513_HiddenDynamic
		{
			get
			{
				short num = (short)496186913;
				short num2 = num;
				num = (short)1963472417;
				switch (num2 == num)
				{
				}
				num = (short)1018757120;
				if (num != 0)
				{
				}
				num = (short)451936257;
				if (num != 0)
				{
				}
				num = (short)1364262912;
				short num3 = num;
				return this.radWideGenLightBarPatternRelay8_A36513.HiddenDynamic;
			}
			set
			{
				short num = (short)1887822631;
				short num2 = num;
				num = (short)907207463;
				switch (num2 == num)
				{
				}
				num = (short)1096548353;
				if (num != 0)
				{
				}
				num = (short)1403912192;
				if (num != 0)
				{
				}
				num = (short)1617887232;
				short num3 = num;
				this.radWideGenLightBarPatternRelay8_A36513.HiddenDynamic = value;
			}
		}

		// Token: 0x17001B81 RID: 7041
		// (get) Token: 0x06003643 RID: 13891 RVA: 0x0033CD1C File Offset: 0x0033AF1C
		public bool RadWideGenLightBarPatternRelay8_A36513_HasDiffs
		{
			get
			{
				short num = (short)1388576769;
				if (num != 0)
				{
				}
				num = (short)1826093679;
				short num2 = num;
				num = (short)737475183;
				switch (num2 == num)
				{
				}
				num = (short)595525632;
				if (num != 0)
				{
				}
				num = (short)606863360;
				short num3 = num;
				return this.radWideGenLightBarPatternRelay8_A36513._HasDiffs;
			}
		}

		// Token: 0x17001B82 RID: 7042
		// (get) Token: 0x06003644 RID: 13892 RVA: 0x0033CDD4 File Offset: 0x0033AFD4
		// (set) Token: 0x06003645 RID: 13893 RVA: 0x0033CE88 File Offset: 0x0033B088
		public int RadWideGenLightBarPatternRelay9_A36515Value
		{
			get
			{
				short num = (short)1430578566;
				short num2 = num;
				num = (short)1229317510;
				switch (num2 == num)
				{
				}
				num = (short)1553203201;
				if (num != 0)
				{
				}
				num = (short)2081423360;
				if (num != 0)
				{
				}
				num = (short)1743781888;
				short num3 = num;
				return this.radWideGenLightBarPatternRelay9_A36515.Value;
			}
			set
			{
				short num = (short)1441793;
				if (num != 0)
				{
				}
				num = (short)840374623;
				short num2 = num;
				num = (short)1865816415;
				switch (num2 == num)
				{
				}
				num = (short)2009399296;
				if (num != 0)
				{
				}
				num = (short)618659840;
				short num3 = num;
				this.radWideGenLightBarPatternRelay9_A36515.Value = value;
			}
		}

		// Token: 0x17001B83 RID: 7043
		// (get) Token: 0x06003646 RID: 13894 RVA: 0x0033CF3C File Offset: 0x0033B13C
		// (set) Token: 0x06003647 RID: 13895 RVA: 0x0033CFF4 File Offset: 0x0033B1F4
		public string RadWideGenLightBarPatternRelay9_A36515_UIValue
		{
			get
			{
				short num = (short)207778594;
				short num2 = num;
				num = (short)1289712418;
				switch (num2 == num)
				{
				}
				num = (short)1983512577;
				if (num != 0)
				{
				}
				num = (short)229507072;
				if (num != 0)
				{
				}
				num = (short)1240662016;
				short num3 = num;
				return this.radWideGenLightBarPatternRelay9_A36515.UIValue;
			}
			set
			{
				short num = (short)1206218735;
				short num2 = num;
				num = (short)308047855;
				switch (num2 == num)
				{
				}
				num = (short)1575223297;
				if (num != 0)
				{
				}
				num = (short)1061289984;
				if (num != 0)
				{
				}
				num = (short)1626603520;
				short num3 = num;
				this.radWideGenLightBarPatternRelay9_A36515.UIValue = value;
			}
		}

		// Token: 0x17001B84 RID: 7044
		// (get) Token: 0x06003648 RID: 13896 RVA: 0x0033D0AC File Offset: 0x0033B2AC
		public global::AcpBusinessLayer.AcpListField RadWideGenLightBarPatternRelay9_A36515
		{
			get
			{
				short num = (short)1956085590;
				short num2 = num;
				num = (short)1095073622;
				switch (num2 == num)
				{
				}
				num = (short)74973185;
				if (num != 0)
				{
				}
				num = (short)423821312;
				if (num != 0)
				{
				}
				num = (short)527499264;
				short num3 = num;
				return this.radWideGenLightBarPatternRelay9_A36515;
			}
		}

		// Token: 0x17001B85 RID: 7045
		// (get) Token: 0x06003649 RID: 13897 RVA: 0x0033D15C File Offset: 0x0033B35C
		// (set) Token: 0x0600364A RID: 13898 RVA: 0x0033D210 File Offset: 0x0033B410
		public bool RadWideGenLightBarPatternRelay9_A36515_Applicable
		{
			get
			{
				short num = (short)503765564;
				short num2 = num;
				num = (short)380623420;
				switch (num2 == num)
				{
				}
				num = (short)906231809;
				if (num != 0)
				{
				}
				num = (short)757530624;
				if (num != 0)
				{
				}
				num = (short)285999104;
				short num3 = num;
				return this.radWideGenLightBarPatternRelay9_A36515.Applicable;
			}
			set
			{
				short num = (short)297002049;
				short num2 = num;
				num = (short)347268161;
				switch (num2 == num)
				{
				}
				num = (short)739049473;
				if (num != 0)
				{
				}
				num = (short)1179844608;
				if (num != 0)
				{
				}
				num = (short)1858797568;
				short num3 = num;
				this.radWideGenLightBarPatternRelay9_A36515.Applicable = value;
			}
		}

		// Token: 0x17001B86 RID: 7046
		// (get) Token: 0x0600364B RID: 13899 RVA: 0x0033D2C4 File Offset: 0x0033B4C4
		// (set) Token: 0x0600364C RID: 13900 RVA: 0x0033D378 File Offset: 0x0033B578
		public bool RadWideGenLightBarPatternRelay9_A36515_Valid
		{
			get
			{
				short num = (short)2119113372;
				short num2 = num;
				num = (short)681384604;
				switch (num2 == num)
				{
				}
				num = (short)1504313345;
				if (num != 0)
				{
				}
				num = (short)1743585280;
				if (num != 0)
				{
				}
				num = (short)589692928;
				short num3 = num;
				return this.radWideGenLightBarPatternRelay9_A36515.Valid;
			}
			set
			{
				short num = (short)1405091841;
				if (num != 0)
				{
				}
				num = (short)144895326;
				short num2 = num;
				num = (short)1466035550;
				switch (num2 == num)
				{
				default:
				{
					num = (short)323092480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1465188352;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay9_A36515.Valid = value;
			}
		}

		// Token: 0x17001B87 RID: 7047
		// (get) Token: 0x0600364D RID: 13901 RVA: 0x0033D430 File Offset: 0x0033B630
		// (set) Token: 0x0600364E RID: 13902 RVA: 0x0033D4E4 File Offset: 0x0033B6E4
		public bool RadWideGenLightBarPatternRelay9_A36515_Visible
		{
			get
			{
				short num = (short)1940430778;
				short num2 = num;
				num = (short)1742512058;
				switch (num2 == num)
				{
				}
				num = (short)419758080;
				short num3 = num;
				num = (short)1411186688;
				if (num != 0)
				{
				}
				num = (short)776011777;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay9_A36515.Visible;
			}
			set
			{
				short num = (short)1633550337;
				if (num != 0)
				{
				}
				num = (short)1087785419;
				short num2 = num;
				num = (short)1167346123;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1767309312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)734068736;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay9_A36515.Visible = value;
			}
		}

		// Token: 0x17001B88 RID: 7048
		// (get) Token: 0x0600364F RID: 13903 RVA: 0x0033D598 File Offset: 0x0033B798
		// (set) Token: 0x06003650 RID: 13904 RVA: 0x0033D64C File Offset: 0x0033B84C
		public bool RadWideGenLightBarPatternRelay9_A36515_Editable
		{
			get
			{
				short num = (short)276948386;
				short num2 = num;
				num = (short)787408290;
				switch (num2 == num)
				{
				}
				num = (short)458162176;
				short num3 = num;
				num = (short)1586167809;
				if (num != 0)
				{
				}
				num = (short)93257728;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay9_A36515.Editable;
			}
			set
			{
				short num = (short)1428162657;
				short num2 = num;
				num = (short)397805665;
				switch (num2 == num)
				{
				}
				num = (short)499515392;
				short num3 = num;
				num = (short)979501056;
				if (num != 0)
				{
				}
				num = (short)924516353;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay9_A36515.Editable = value;
			}
		}

		// Token: 0x17001B89 RID: 7049
		// (get) Token: 0x06003651 RID: 13905 RVA: 0x0033D704 File Offset: 0x0033B904
		internal string RadWideGenLightBarPatternRelay9_A36515_UILabel
		{
			get
			{
				short num = (short)1359850014;
				short num2 = num;
				num = (short)474393118;
				switch (num2 == num)
				{
				}
				num = (short)1635516416;
				short num3 = num;
				num = (short)1424687105;
				if (num != 0)
				{
				}
				num = (short)1466302464;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay9_A36515.UIName;
			}
		}

		// Token: 0x17001B8A RID: 7050
		// (get) Token: 0x06003652 RID: 13906 RVA: 0x0033D7B8 File Offset: 0x0033B9B8
		// (set) Token: 0x06003653 RID: 13907 RVA: 0x0033D86C File Offset: 0x0033BA6C
		internal bool RadWideGenLightBarPatternRelay9_A36515_HiddenStatic
		{
			get
			{
				short num = (short)1145388282;
				short num2 = num;
				num = (short)840711418;
				switch (num2 == num)
				{
				}
				num = (short)1819082752;
				short num3 = num;
				num = (short)1119617025;
				if (num != 0)
				{
				}
				num = (short)351338496;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay9_A36515.HiddenStatic;
			}
			set
			{
				short num = (short)789524510;
				short num2 = num;
				num = (short)1051734046;
				switch (num2 == num)
				{
				}
				num = (short)1341194240;
				short num3 = num;
				num = (short)495124480;
				if (num != 0)
				{
				}
				num = (short)1746927617;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay9_A36515.HiddenStatic = value;
			}
		}

		// Token: 0x17001B8B RID: 7051
		// (get) Token: 0x06003654 RID: 13908 RVA: 0x0033D924 File Offset: 0x0033BB24
		// (set) Token: 0x06003655 RID: 13909 RVA: 0x0033D9D8 File Offset: 0x0033BBD8
		internal bool RadWideGenLightBarPatternRelay9_A36515_HiddenDynamic
		{
			get
			{
				short num = (short)1579272380;
				short num2 = num;
				num = (short)1163708604;
				switch (num2 == num)
				{
				}
				num = (short)115671040;
				short num3 = num;
				num = (short)2087518208;
				if (num != 0)
				{
				}
				num = (short)731054081;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay9_A36515.HiddenDynamic;
			}
			set
			{
				short num = (short)1272070043;
				short num2 = num;
				num = (short)2074754971;
				switch (num2 == num)
				{
				}
				num = (short)877068288;
				short num3 = num;
				num = (short)1482031105;
				if (num != 0)
				{
				}
				num = (short)1898315776;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay9_A36515.HiddenDynamic = value;
			}
		}

		// Token: 0x17001B8C RID: 7052
		// (get) Token: 0x06003656 RID: 13910 RVA: 0x0033DA8C File Offset: 0x0033BC8C
		public bool RadWideGenLightBarPatternRelay9_A36515_HasDiffs
		{
			get
			{
				short num = (short)209743199;
				short num2 = num;
				num = (short)1743220063;
				switch (num2 == num)
				{
				}
				num = (short)941359104;
				short num3 = num;
				num = (short)1078722561;
				if (num != 0)
				{
				}
				num = (short)993460224;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay9_A36515._HasDiffs;
			}
		}

		// Token: 0x17001B8D RID: 7053
		// (get) Token: 0x06003657 RID: 13911 RVA: 0x0033DB44 File Offset: 0x0033BD44
		// (set) Token: 0x06003658 RID: 13912 RVA: 0x0033DBF8 File Offset: 0x0033BDF8
		public int RadWideGenLightBarPatternRelay10_A36516Value
		{
			get
			{
				short num = (short)959694387;
				short num2 = num;
				num = (short)289982003;
				switch (num2 == num)
				{
				}
				num = (short)1775697920;
				short num3 = num;
				num = (short)1629945856;
				if (num != 0)
				{
				}
				num = (short)1101332481;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay10_A36516.Value;
			}
			set
			{
				short num = (short)1122805818;
				short num2 = num;
				num = (short)213100602;
				switch (num2 == num)
				{
				}
				num = (short)1139933184;
				short num3 = num;
				num = (short)1019543552;
				if (num != 0)
				{
				}
				num = (short)232325121;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay10_A36516.Value = value;
			}
		}

		// Token: 0x17001B8E RID: 7054
		// (get) Token: 0x06003659 RID: 13913 RVA: 0x0033DCAC File Offset: 0x0033BEAC
		// (set) Token: 0x0600365A RID: 13914 RVA: 0x0033DD60 File Offset: 0x0033BF60
		public string RadWideGenLightBarPatternRelay10_A36516_UIValue
		{
			get
			{
				short num = (short)949304210;
				short num2 = num;
				num = (short)2006334354;
				switch (num2 == num)
				{
				}
				num = (short)406388736;
				short num3 = num;
				num = (short)219021313;
				if (num != 0)
				{
				}
				num = (short)68943872;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay10_A36516.UIValue;
			}
			set
			{
				short num = (short)1270497832;
				short num2 = num;
				num = (short)1932739112;
				switch (num2 == num)
				{
				}
				num = (short)1712848896;
				short num3 = num;
				num = (short)669122561;
				if (num != 0)
				{
				}
				num = (short)1332215808;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay10_A36516.UIValue = value;
			}
		}

		// Token: 0x17001B8F RID: 7055
		// (get) Token: 0x0600365B RID: 13915 RVA: 0x0033DE14 File Offset: 0x0033C014
		public global::AcpBusinessLayer.AcpListField RadWideGenLightBarPatternRelay10_A36516
		{
			get
			{
				short num = (short)307768254;
				short num2 = num;
				num = (short)1335700414;
				switch (num2 == num)
				{
				}
				num = (short)347537408;
				short num3 = num;
				num = (short)270073856;
				if (num != 0)
				{
				}
				num = (short)549060609;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay10_A36516;
			}
		}

		// Token: 0x17001B90 RID: 7056
		// (get) Token: 0x0600365C RID: 13916 RVA: 0x0033DEC4 File Offset: 0x0033C0C4
		// (set) Token: 0x0600365D RID: 13917 RVA: 0x0033DF78 File Offset: 0x0033C178
		public bool RadWideGenLightBarPatternRelay10_A36516_Applicable
		{
			get
			{
				short num = (short)1074232374;
				short num2 = num;
				num = (short)1726577718;
				switch (num2 == num)
				{
				}
				num = (short)1530724352;
				short num3 = num;
				num = (short)462356481;
				if (num != 0)
				{
				}
				num = (short)1429798912;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay10_A36516.Applicable;
			}
			set
			{
				short num = (short)1107954990;
				short num2 = num;
				num = (short)494734638;
				switch (num2 == num)
				{
				}
				num = (short)1454768128;
				short num3 = num;
				num = (short)1675362304;
				if (num != 0)
				{
				}
				num = (short)957480961;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay10_A36516.Applicable = value;
			}
		}

		// Token: 0x17001B91 RID: 7057
		// (get) Token: 0x0600365E RID: 13918 RVA: 0x0033E02C File Offset: 0x0033C22C
		// (set) Token: 0x0600365F RID: 13919 RVA: 0x0033E0E0 File Offset: 0x0033C2E0
		public bool RadWideGenLightBarPatternRelay10_A36516_Valid
		{
			get
			{
				short num = (short)2132103087;
				short num2 = num;
				num = (short)252727215;
				switch (num2 == num)
				{
				}
				num = (short)1135017984;
				short num3 = num;
				num = (short)1243873281;
				if (num != 0)
				{
				}
				num = (short)2119106560;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay10_A36516.Valid;
			}
			set
			{
				short num = (short)802923651;
				short num2 = num;
				num = (short)386901123;
				switch (num2 == num)
				{
				}
				num = (short)957218816;
				short num3 = num;
				num = (short)564592641;
				if (num != 0)
				{
				}
				num = (short)57409536;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay10_A36516.Valid = value;
			}
		}

		// Token: 0x17001B92 RID: 7058
		// (get) Token: 0x06003660 RID: 13920 RVA: 0x0033E194 File Offset: 0x0033C394
		// (set) Token: 0x06003661 RID: 13921 RVA: 0x0033E248 File Offset: 0x0033C448
		public bool RadWideGenLightBarPatternRelay10_A36516_Visible
		{
			get
			{
				short num = (short)18714410;
				short num2 = num;
				num = (short)1368887082;
				switch (num2 == num)
				{
				}
				num = (short)406585344;
				short num3 = num;
				num = (short)886374401;
				if (num != 0)
				{
				}
				num = (short)1544749056;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay10_A36516.Visible;
			}
			set
			{
				short num = (short)1437383750;
				short num2 = num;
				num = (short)298761286;
				switch (num2 == num)
				{
				}
				num = (short)1686175744;
				short num3 = num;
				num = (short)1562705920;
				if (num != 0)
				{
				}
				num = (short)128909313;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay10_A36516.Visible = value;
			}
		}

		// Token: 0x17001B93 RID: 7059
		// (get) Token: 0x06003662 RID: 13922 RVA: 0x0033E300 File Offset: 0x0033C500
		// (set) Token: 0x06003663 RID: 13923 RVA: 0x0033E3B4 File Offset: 0x0033C5B4
		public bool RadWideGenLightBarPatternRelay10_A36516_Editable
		{
			get
			{
				short num = (short)696081316;
				short num2 = num;
				num = (short)276716452;
				switch (num2 == num)
				{
				}
				num = (short)542048256;
				short num3 = num;
				num = (short)30146561;
				if (num != 0)
				{
				}
				num = (short)1794506752;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay10_A36516.Editable;
			}
			set
			{
				short num = (short)18971069;
				short num2 = num;
				num = (short)1926855101;
				switch (num2 == num)
				{
				}
				num = (short)1500381184;
				short num3 = num;
				num = (short)1254817792;
				if (num != 0)
				{
				}
				num = (short)896729089;
				if (num != 0)
				{
				}
				this.radWideGenLightBarPatternRelay10_A36516.Editable = value;
			}
		}

		// Token: 0x17001B94 RID: 7060
		// (get) Token: 0x06003664 RID: 13924 RVA: 0x0033E46C File Offset: 0x0033C66C
		internal string RadWideGenLightBarPatternRelay10_A36516_UILabel
		{
			get
			{
				short num = (short)1026977317;
				short num2 = num;
				num = (short)1330277925;
				switch (num2 == num)
				{
				}
				num = (short)1782906880;
				short num3 = num;
				num = (short)1581121537;
				if (num != 0)
				{
				}
				num = (short)1722482688;
				if (num != 0)
				{
				}
				return this.radWideGenLightBarPatternRelay10_A36516.UIName;
			}
		}

		// Token: 0x17001B95 RID: 7061
		// (get) Token: 0x06003665 RID: 13925 RVA: 0x0033E520 File Offset: 0x0033C720
		// (set) Token: 0x06003666 RID: 13926 RVA: 0x0033E5D4 File Offset: 0x0033C7D4
		internal bool RadWideGenLightBarPatternRelay10_A36516_HiddenStatic
		{
			get
			{
				short num = (short)1919942657;
				if (num != 0)
				{
				}
				num = (short)1811541289;
				short num2 = num;
				num = (short)548269353;
				switch (num2 == num)
				{
				}
				num = (short)2121596928;
				if (num != 0)
				{
				}
				num = (short)1500971008;
				short num3 = num;
				return this.radWideGenLightBarPatternRelay10_A36516.HiddenStatic;
			}
			set
			{
				short num = (short)1772406809;
				short num2 = num;
				num = (short)27838489;
				switch (num2 == num)
				{
				}
				num = (short)1405550593;
				if (num != 0)
				{
				}
				num = (short)772931584;
				if (num != 0)
				{
				}
				num = (short)1224212480;
				short num3 = num;
				this.radWideGenLightBarPatternRelay10_A36516.HiddenStatic = value;
			}
		}

		// Token: 0x17001B96 RID: 7062
		// (get) Token: 0x06003667 RID: 13927 RVA: 0x0033E68C File Offset: 0x0033C88C
		// (set) Token: 0x06003668 RID: 13928 RVA: 0x0033E740 File Offset: 0x0033C940
		internal bool RadWideGenLightBarPatternRelay10_A36516_HiddenDynamic
		{
			get
			{
				short num = (short)811545752;
				short num2 = num;
				num = (short)1606038680;
				switch (num2 == num)
				{
				}
				num = (short)1246625793;
				if (num != 0)
				{
				}
				num = (short)846135296;
				if (num != 0)
				{
				}
				num = (short)706543616;
				short num3 = num;
				return this.radWideGenLightBarPatternRelay10_A36516.HiddenDynamic;
			}
			set
			{
				short num = (short)320607192;
				short num2 = num;
				num = (short)1193350104;
				switch (num2 == num)
				{
				}
				num = (short)1726480384;
				if (num != 0)
				{
				}
				num = (short)254279681;
				if (num != 0)
				{
				}
				num = (short)1368981504;
				short num3 = num;
				this.radWideGenLightBarPatternRelay10_A36516.HiddenDynamic = value;
			}
		}

		// Token: 0x17001B97 RID: 7063
		// (get) Token: 0x06003669 RID: 13929 RVA: 0x0033E7F4 File Offset: 0x0033C9F4
		public bool RadWideGenLightBarPatternRelay10_A36516_HasDiffs
		{
			get
			{
				short num = (short)42983929;
				short num2 = num;
				num = (short)1789256185;
				switch (num2 == num)
				{
				}
				num = (short)639565825;
				if (num != 0)
				{
				}
				num = (short)2117402624;
				if (num != 0)
				{
				}
				num = (short)2007367680;
				short num3 = num;
				return this.radWideGenLightBarPatternRelay10_A36516._HasDiffs;
			}
		}

		// Token: 0x0600366A RID: 13930 RVA: 0x0033E8B0 File Offset: 0x0033CAB0
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)695345662;
					short num3 = num2;
					num2 = (short)1091183102;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)210632704;
						if (num2 != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						break;
					}
					num2 = (short)1990393857;
					if (num2 != 0)
					{
					}
					num2 = (short)759300096;
					short num4 = num2;
					num2 = (short)1452998657;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					return result;
				case 2:
					num2 = (short)1404829699;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1254948864;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					if (base.ParentRecset != null)
					{
						num2 = (short)1624768514;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)905904132;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600366B RID: 13931 RVA: 0x0033EA2C File Offset: 0x0033CC2C
		private void b()
		{
			short num = (short)1096074833;
			short num2 = num;
			num = (short)117294673;
			switch (num2 == num)
			{
			}
			num = (short)676397056;
			if (num != 0)
			{
			}
			num = (short)1099759617;
			if (num != 0)
			{
			}
			num = (short)1838350336;
			short num3 = num;
			this.a();
		}

		// Token: 0x0600366C RID: 13932 RVA: 0x0033EADC File Offset: 0x0033CCDC
		private void a()
		{
			short num = (short)503119873;
			if (num != 0)
			{
			}
			num = (short)2041113570;
			short num2 = num;
			num = (short)1279585250;
			switch (num2 == num)
			{
			}
			num = (short)487981056;
			if (num != 0)
			{
			}
			num = (short)1301479424;
			short num3 = num;
			base.PropertyChanged += global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection.OnRadWideGenLightBarPatternRelay_PropertyChangedHandle;
		}

		// Token: 0x0600366D RID: 13933 RVA: 0x0033EB98 File Offset: 0x0033CD98
		public static void OnRadWideGenLightBarPatternRelay_PropertyChangedHandle(object section, global::System.ComponentModel.PropertyChangedEventArgs label)
		{
			int a_ = 15;
			short num;
			try
			{
				num = (short)2004746240;
				switch (num)
				{
				default:
				{
					num = (short)94961673;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset actionConsolidationRecset;
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
						switch (num2)
						{
						case 0:
							num = (short)435814424;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_C6F;
						case 2:
							goto IL_C6F;
						case 3:
						{
							string propertyName;
							if (!(propertyName == global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛駝藟賡꣣迥迧苩飫곭釯胱ꓳ韵賷軹駻賽滿倁愃樅椇猉㠋儍儏ℑ∓⌕⠗⌙䨛缝䰟圡䄣", a_)))
							{
								num = (short)985923610;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2A5;
						}
						case 4:
							num = (short)1651245112;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_C6F;
						case 6:
							num = (short)394461230;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							num = (short)1286733853;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
						{
							uint num3;
							if (num3 != 2878682502U)
							{
								num = (short)679411747;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)425721908;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							switch (0)
							{
							case 0:
								goto IL_14D;
							}
							continue;
						case 10:
						{
							string propertyName;
							if (!(propertyName == global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛駝藟賡꣣迥迧苩飫곭釯胱ꓳ韵賷軹駻賽滿倁愃樅椇猉㴋儍儏ℑ∓⌕⠗Ⱉ䨛缝䰟圡䄣", a_)))
							{
								num = (short)47382540;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2A5;
						}
						case 11:
						{
							uint num3;
							if (num3 != 2995732907U)
							{
								num = (short)1962016827;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)675676163;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 12:
							num = (short)1113063473;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
						{
							string propertyName;
							if (!(propertyName == global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛駝藟賡꣣迥迧苩飫곭釯胱ꓳ韵賷軹駻賽滿倁愃樅椇猉㬋儍儏ℑ∓⌕⤗⠙䨛缝䰟圡䄣", a_)))
							{
								num = (short)464388143;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2A5;
						}
						case 14:
						{
							string propertyName;
							if (propertyName == global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛駝藟賡꣣迥迧苩飫곭釯胱ꓳ韵賷軹駻賽滿倁愃樅椇猉㴋㸍伏匑✓―ⴗ⬙⨛䠝䄟両儣䌥", a_))
							{
								num = (short)502202416;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C6F;
						}
						case 15:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = actionConsolidationRecset.GetEnumerator();
							num = (short)2090074135;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 16:
							goto IL_C88;
						case 17:
						{
							string propertyName;
							if (!(propertyName == global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛駝藟賡꣣迥迧苩飫곭釯胱ꓳ韵賷軹駻賽滿倁愃樅椇猉㸋儍儏ℑ∓⌕⠗ⴙ䨛缝䰟圡䄣", a_)))
							{
								num = (short)1890517011;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2A5;
						}
						case 18:
							goto IL_C6F;
						case 19:
							num = (short)683016222;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
						{
							uint num3;
							if (num3 <= 530378730U)
							{
								num = (short)1764229151;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)917176381;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 21:
						{
							string propertyName;
							if (!(propertyName == global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛駝藟賡꣣迥迧苩飫곭釯胱ꓳ韵賷軹駻賽滿倁愃樅椇猉㼋儍儏ℑ∓⌕⠗∙䨛缝䰟圡䄣", a_)))
							{
								num = (short)934936582;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2A5;
						}
						case 22:
							num = (short)431161354;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 23:
							try
							{
								num = (short)1241448454;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)1871511555;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General general;
										if (general != null)
										{
											num = (short)338296839;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
										num = (short)1557004293;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										goto IL_A9A;
									case 4:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General general;
										general.RadioErgoConfigACRelayPattern_A36582.CalculateValidityWithDep();
										num = (short)411500556;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General general;
										if (general.RadioErgoConfigACRelayPattern_A36582 != null)
										{
											num = (short)469106697;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 6:
										switch (0)
										{
										case 0:
											goto IL_8F9;
										}
										continue;
									case 7:
										num = (short)1798373384;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
										if (generalLightbarPatternInnerSection != null)
										{
											num = (short)1916796930;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									case 9:
										num = (short)1353318410;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 10:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General general;
										if (general.RadioErgoConfigACRelayPattern_A36582.UIValue == generalLightbarPatternInnerSection.RadWideGenLgtBarName_A36505.Value)
										{
											num = (short)1048510468;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 11:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)446103552;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General general = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10615] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General;
										num = (short)966524929;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_A42:
									num = (short)1820721163;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_8F9:
									goto IL_A42;
								}
								IL_A9A:
								goto IL_C6F;
							}
							finally
							{
								num = (short)1410465794;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									switch (num2)
									{
									case 0:
										goto IL_B5A;
									case 1:
									{
										num = (short)2095027503;
										short num4 = num;
										num = (short)2036700463;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_B5A;
										default:
											num = (short)299761664;
											if (num != 0)
											{
											}
											enumerator.Dispose();
											num = (short)882573312;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
										switch (0)
										{
										case 0:
											goto IL_AD1;
										}
										continue;
									}
									IL_AD1:
									if (enumerator == null)
									{
										break;
									}
									num = (short)551944193;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_B5A:;
							}
							goto IL_B5D;
						case 24:
						{
							uint num3;
							if (num3 != 1820386583U)
							{
								num = (short)1896874047;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)975503377;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 25:
							num = (short)1012596741;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 26:
							num = (short)1584201756;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 27:
							num = (short)723320834;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 28:
							goto IL_C6F;
						case 29:
						{
							uint num3;
							if (num3 != 530378730U)
							{
								num = (short)36372507;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)336330785;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 30:
							goto IL_C6F;
						case 31:
							goto IL_B5D;
						case 32:
						{
							string propertyName = label.PropertyName;
							uint num3 = global::<PrivateImplementationDetails>.ComputeStringHash(propertyName);
							num = (short)1583677479;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 33:
						{
							string propertyName;
							if (!(propertyName == global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛駝藟賡꣣迥迧苩飫곭釯胱ꓳ韵賷軹駻賽滿倁愃樅椇猉㨋儍儏ℑ∓⌕⤗⬙䨛缝䰟圡䄣", a_)))
							{
								num = (short)359858219;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2A5;
						}
						case 34:
							num = (short)1977090093;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 35:
							num = (short)658964481;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 36:
						{
							uint num3;
							if (num3 != 1368983938U)
							{
								num = (short)30867456;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1352138765;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 37:
						{
							string propertyName;
							if (!(propertyName == global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛駝藟賡꣣迥迧苩飫곭釯胱ꓳ韵賷軹駻賽滿倁愃樅椇猉㔋儍儏ℑ∓⌕⤗⼙䨛缝䰟圡䄣", a_)))
							{
								num = (short)1727725593;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2A5;
						}
						case 38:
							num = (short)997326884;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 39:
						{
							uint num3;
							if (num3 <= 1820386583U)
							{
								num = (short)505741370;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1663762473;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 40:
							goto IL_C6F;
						case 41:
						{
							uint num3;
							if (num3 <= 2878682502U)
							{
								num = (short)285605892;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1317404716;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 42:
							num = (short)883818507;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 43:
							num = (short)624558137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 44:
						{
							uint num3;
							if (num3 != 2965394499U)
							{
								num = (short)1587478570;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)933101589;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 45:
							goto IL_C6F;
						case 46:
							goto IL_C6F;
						case 47:
							num = (short)505479219;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 48:
							goto IL_2A5;
						case 49:
							goto IL_C6F;
						case 50:
							if (actionConsolidationRecset != null)
							{
								num = (short)269615119;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C6F;
						case 51:
							goto IL_C6F;
						case 52:
						{
							string propertyName;
							if (!(propertyName == global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛駝藟賡꣣迥迧苩飫곭釯胱ꓳ韵賷軹駻賽滿倁愃樅椇猉㐋儍儏ℑ∓⌕⤗⤙䨛缝䰟圡䄣", a_)))
							{
								num = (short)1121910846;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2A5;
						}
						case 53:
						{
							string propertyName;
							if (!(propertyName == global::AllFeatures.CodeplugGuid.b("苏돑냓臕뇗뻙맛駝藟賡꣣迥迧苩飫곭釯胱ꓳ韵賷軹駻賽滿倁愃樅椇猉㤋儍儏ℑ∓⌕⤗⨙䨛缝䰟圡䄣", a_)))
							{
								num = (short)1028194338;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2A5;
						}
						case 54:
						{
							uint num3;
							if (num3 == 4271044911U)
							{
								num = (short)1302265878;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C6F;
						}
						case 55:
							num = (short)392822792;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 56:
						{
							uint num3;
							if (num3 != 2841926103U)
							{
								num = (short)1734737975;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1262485541;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 57:
							goto IL_C6F;
						case 58:
							num = (short)218169364;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 59:
							num = (short)1291255862;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 60:
						{
							uint num3;
							if (num3 != 478751768U)
							{
								num = (short)548339719;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)582942734;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 61:
						{
							uint num3;
							if (num3 != 1300914774U)
							{
								num = (short)804782118;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1967325237;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 62:
							num = (short)1652949010;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 63:
							num = (short)714539048;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_14D:
						if (section != null)
						{
							num = (short)608436256;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C6F;
						IL_2A5:
						generalLightbarPatternInnerSection = (section as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection);
						actionConsolidationRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4008) as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset);
						num = (short)1387593778;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_B5D:
						num = (short)1150287932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_C6F:
						num = (short)1736048656;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_C88:
					break;
				}
				}
			}
			catch (global::System.Exception)
			{
			}
			num = (short)1633222657;
			if (num != 0)
			{
			}
			num = (short)1249443840;
			short num5 = num;
		}

		// Token: 0x040011B2 RID: 4530
		private global::AcpBusinessLayer.AcpKeyField radWideGenLgtBarName_A36505;

		// Token: 0x040011B3 RID: 4531
		private global::AcpBusinessLayer.AcpListField radWideGenLightBarPatternRelay1_A36506;

		// Token: 0x040011B4 RID: 4532
		private global::AcpBusinessLayer.AcpListField radWideGenLightBarPatternRelay2_A36507;

		// Token: 0x040011B5 RID: 4533
		private global::AcpBusinessLayer.AcpListField radWideGenLightBarPatternRelay3_A36508;

		// Token: 0x040011B6 RID: 4534
		private global::AcpBusinessLayer.AcpListField radWideGenLightBarPatternRelay4_A36509;

		// Token: 0x040011B7 RID: 4535
		private global::AcpBusinessLayer.AcpListField radWideGenLightBarPatternRelay5_A36510;

		// Token: 0x040011B8 RID: 4536
		private global::AcpBusinessLayer.AcpListField radWideGenLightBarPatternRelay6_A36511;

		// Token: 0x040011B9 RID: 4537
		private global::AcpBusinessLayer.AcpListField radWideGenLightBarPatternRelay7_A36512;

		// Token: 0x040011BA RID: 4538
		private global::AcpBusinessLayer.AcpListField radWideGenLightBarPatternRelay8_A36513;

		// Token: 0x040011BB RID: 4539
		private global::AcpBusinessLayer.AcpListField radWideGenLightBarPatternRelay9_A36515;

		// Token: 0x040011BC RID: 4540
		private global::AcpBusinessLayer.AcpListField radWideGenLightBarPatternRelay10_A36516;
	}
}
