using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;

namespace Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment
{
	// Token: 0x0200004A RID: 74
	[global::System.Serializable]
	public class RSI : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600023D RID: 573 RVA: 0x0002F9A8 File Offset: 0x0002DBA8
		public RSI(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600023E RID: 574 RVA: 0x0002F9C4 File Offset: 0x0002DBC4
		protected RSI(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600023F RID: 575 RVA: 0x0002F9DC File Offset: 0x0002DBDC
		public override void Init()
		{
			int a_ = 11;
			short num = (short)789856295;
			short num2 = num;
			num = (short)772423719;
			switch (num2 == num)
			{
			}
			num = (short)130678784;
			short num3 = num;
			num = (short)1475739649;
			if (num != 0)
			{
			}
			num = (short)605421568;
			if (num != 0)
			{
			}
			this.zoneChannelAssignmentRSIMode_A41831 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("雋ꇍ뻏럑韓뻕맗듙닛믝賟ꏡ韣闥臧跩苫菭闯鳱胳ꓵ꯷돹뇻釽擿朁嬃䜅㰇㬉㐋㴍ℏ", a_), global::CommonResources.AcgResources.ID_RSIMODE, global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.LOVs.ZoneChannelAssignmentRSIMode_A41831LovStrs);
			this.zoneChannelAssignmentRSIMode_A41831.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.zoneChannelAssignmentRSIMode_A41831.DataTransferOrder = 30;
			this.zoneChannelAssignmentRSIMode_A41831.EvaluateRecRefs = true;
			this.zoneChannelAssignmentRSIAutoDial_A41832 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("雋ꇍ뻏럑韓뻕맗듙닛믝賟ꏡ韣闥臧跩苫菭闯鳱胳ꓵ꯷돹뷻诽瓿洁䀃漅椇昉匋伍␏⌑Ⱃ┕⨗", a_), global::CommonResources.AcgResources.ID_AUTODIALENABLE);
			this.zoneChannelAssignmentRSIAutoDial_A41832.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.zoneChannelAssignmentRSIAutoDial_A41832.DataTransferOrder = 45;
			this.zoneChannelAssignmentRSISiteNumber_A41833 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("雋ꇍ뻏럑韓뻕맗듙닛믝賟ꏡ韣闥臧跩苫菭闯鳱胳ꓵ꯷돹꿻韽瓿朁䨃猅攇栉椋簍伏匑–✕‗⤙⼛", a_), global::CommonResources.AcgResources.ID_SITENUMBER, 1, 62, null, null, 0, 1);
			this.zoneChannelAssignmentRSISiteNumber_A41833.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.zoneChannelAssignmentRSISiteNumber_A41833.DataTransferOrder = 40;
			this.zoneChannelAssignmentRSISiteNumber_A41833.ShowHexValue = false;
			this.mainComparatorHostname_43796 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_EMPTY, this, global::AllFeatures.CodeplugGuid.b("臋꿍맏병韓맕뗗꫙뷛곝臟雡诣铥ꃧ藩鿫髭黯鏱駳鏵ꟷ컹쿻짽㧿㐁", a_), global::CommonResources.AcgResources.ID_MAINCOMPARATORHOSTNAME, 63);
			this.mainComparatorHostname_43796.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.mainComparatorHostname_43796.DataTransferOrder = 60;
			this.alternateComparatorHostname_43797 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_EMPTY, this, global::AllFeatures.CodeplugGuid.b("跋ꋍ꓏럑ꛓ룕맗껙맛鷝迟迡铣蟥髧诩飫臭苯뫱鯳藵賷铹鷻鏽旿崁〃㔅㼇㌉㬋", a_), global::CommonResources.AcgResources.ID_ALTERNATECOMPARATORHOSTNAME, 63);
			this.alternateComparatorHostname_43797.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.alternateComparatorHostname_43797.DataTransferOrder = 65;
			this.mainComparatorDTLSPortNumber_43798 = new global::AcpBusinessLayer.AcpSimpleRangeField(49688, this, global::AllFeatures.CodeplugGuid.b("臋꿍맏병韓맕뗗꫙뷛곝臟雡诣铥곧뻩ꃫ뷭ꃯ鷱蛳苵뛷迹釻鳽旿瀁嬃㈅㬇㴉㔋㘍", a_), global::CommonResources.AcgResources.ID_MAINCOMPARATORDTLSPORTNUMBER, 1, 65535, null, null, 0, 1);
			this.mainComparatorDTLSPortNumber_43798.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.mainComparatorDTLSPortNumber_43798.DataTransferOrder = 70;
			this.mainComparatorDTLSPortNumber_43798.ShowHexValue = true;
			this.alternateComparatorDTLSPortNumber_43801 = new global::AcpBusinessLayer.AcpSimpleRangeField(49688, this, global::AllFeatures.CodeplugGuid.b("跋ꋍ꓏럑ꛓ룕맗껙맛鷝迟迡铣蟥髧诩飫臭苯뛱ꃳ뫵꯷꫹鏻賽瓿䰁焃欅樇漉縋儍␏ℑⰓ☕⤗", a_), global::CommonResources.AcgResources.ID_ALTERNATECOMPARATORDTLSPORTNUMBER, 1, 65535, null, null, 0, 1);
			this.alternateComparatorDTLSPortNumber_43801.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.alternateComparatorDTLSPortNumber_43801.DataTransferOrder = 75;
			this.alternateComparatorDTLSPortNumber_43801.ShowHexValue = true;
			this.comparatorChannelNumber_43800 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("迋ꇍ뷏ꋑ뗓ꓕ맗껙돛곝ꏟ諡藣裥蛧迩胫ꃭ藯鿱雳鏵諷ꗹ죻췽㣿㈁㐃", a_), global::CommonResources.AcgResources.ID_COMPARATORCHANNELNUMBER, 1, 200, null, null, 0, 1);
			this.comparatorChannelNumber_43800.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.comparatorChannelNumber_43800.DataTransferOrder = 80;
			this.comparatorChannelNumber_43800.ShowHexValue = true;
			this.zoneChannelAssignmentRSITransmitIndication_A41834 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("雋ꇍ뻏럑韓뻕맗듙닛믝賟ꏡ韣闥臧跩苫菭闯鳱胳ꓵ꯷돹ꣻ賽懿氁眃欅愇縉䔋怍琏笑眓眕気猙猛瀝缟挡ဣᜥဧᤩᠫ", a_), global::CommonResources.AcgResources.ID_TRANSMITINDICATION);
			this.zoneChannelAssignmentRSITransmitIndication_A41834.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.zoneChannelAssignmentRSITransmitIndication_A41834.DataTransferOrder = 35;
			this.zoneChannelAssignmentRSITimeDialAtt_A41835 = new global::AcpBusinessLayer.AcpSimpleRangeField(12, this, global::AllFeatures.CodeplugGuid.b("雋ꇍ뻏럑韓뻕맗듙닛믝賟ꏡ韣闥臧跩苫菭闯鳱胳ꓵ꯷돹ꣻ韽淿朁䀃漅椇昉䴋稍搏䴑唓∕⤗∙⼛⬝", a_), global::CommonResources.AcgResources.ID_AUTODIALTIMEBETWEENDIALATTEMPTSSEC, 6, 720, null, null, 0, 5);
			this.zoneChannelAssignmentRSITimeDialAtt_A41835.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.zoneChannelAssignmentRSITimeDialAtt_A41835.DataTransferOrder = 50;
			this.zoneChannelAssignmentRSITimeDialAtt_A41835.ShowHexValue = false;
			this.zoneChannelAssignmentRSIDTRTogTime_A41836 = new global::AcpBusinessLayer.AcpSimpleRangeField(3, this, global::AllFeatures.CodeplugGuid.b("雋ꇍ뻏럑韓뻕맗듙닛믝賟ꏡ韣闥臧跩苫菭闯鳱胳ꓵ꯷돹룻꫽勿嘁欃愅將按愋欍伏匑–✕‗⤙⨛", a_), global::CommonResources.AcgResources.ID_AUTODIALDTRTOGGLETIMESEC, 1, 30, null, null, 0, 1);
			this.zoneChannelAssignmentRSIDTRTogTime_A41836.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.zoneChannelAssignmentRSIDTRTogTime_A41836.DataTransferOrder = 55;
			this.zoneChannelAssignmentRSIDTRTogTime_A41836.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("黋ꯍ뷏뷑ꃓ돕觙뗛ꫝ藟싡귣裥鳧迩黫裭釯釱釳", a_);
			base.Id = 10760;
			base.UIName = global::CommonResources.AcgResources.ID_REMOTESITEINTERFACE;
			base.DataTransferOrder = 5;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0002FDD8 File Offset: 0x0002DFD8
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 8;
			short num = (short)1450115104;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏈꓊ꏌ꫎鋐믒듔맖럘뻚뇜點鋠郢賤胦蟨蛪裬臮藰ꇲ꛴뻶룸軺觼郾䔀樂搄欆嘈䨊㤌㸎⤐‒✔", a_)))
					{
						num = (short)1679097882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3F1;
				case 1:
					num = (short)1059979284;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					this.mainComparatorDTLSPortNumber_43798 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("蓈꫊꓌ꇎ鋐볒룔Ꟗ룘꧚볜ꯞ軠釢ꇤ돦ꗨ룪뷬胮菰蟲믴苶铸駺飼跾帀㜂㘄〆〈㌊", a_), global::CommonResources.AcgResources.ID_MAINCOMPARATORDTLSPORTNUMBER, null, null, 0, 1);
					this.mainComparatorDTLSPortNumber_43798.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.mainComparatorDTLSPortNumber_43798.DataTransferOrder = 70;
					this.mainComparatorDTLSPortNumber_43798.ShowHexValue = true;
					num = (short)809697302;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					this.zoneChannelAssignmentRSITimeDialAtt_A41835 = new global::AcpBusinessLayer.AcpSimpleRangeField(12, this, global::AllFeatures.CodeplugGuid.b("鏈꓊ꏌ꫎鋐믒듔맖럘뻚뇜點鋠郢賤胦蟨蛪裬臮藰ꇲ꛴뻶그鋺郼髾䔀樂搄欆䠈缊礌倎倐✒␔⼖⨘⸚", a_), global::CommonResources.AcgResources.ID_AUTODIALTIMEBETWEENDIALATTEMPTSSEC, null, null, 0, 5);
					this.zoneChannelAssignmentRSITimeDialAtt_A41835.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.zoneChannelAssignmentRSITimeDialAtt_A41835.DataTransferOrder = 50;
					this.zoneChannelAssignmentRSITimeDialAtt_A41835.ShowHexValue = false;
					num = (short)375980061;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_781;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏈꓊ꏌ꫎鋐믒듔맖럘뻚뇜點鋠郢賤胦蟨蛪裬臮藰ꇲ꛴뻶뷸꿺꿼꯾渀搂億渆搈渊刌与┐−ⴔ␖⼘", a_)))
					{
						num = (short)2021457956;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_93A;
				case 6:
					this.mainComparatorHostname_43796 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_NA, this, global::AllFeatures.CodeplugGuid.b("蓈꫊꓌ꇎ鋐볒룔Ꟗ룘꧚볜ꯞ軠釢귤裦髨鿪菬軮鳰雲ꫴ쏶쫸쳺쓼짾", a_), global::CommonResources.AcgResources.ID_MAINCOMPARATORHOSTNAME, 128);
					this.mainComparatorHostname_43796.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.mainComparatorHostname_43796.DataTransferOrder = 60;
					num = (short)365363204;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_3A4;
				case 8:
					goto IL_3F1;
				case 9:
				{
					num = (short)996540416;
					short num3 = num;
					this.zoneChannelAssignmentRSIMode_A41831 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鏈꓊ꏌ꫎鋐믒듔맖럘뻚뇜點鋠郢賤胦蟨蛪裬臮藰ꇲ꛴뻶듸铺駼髾帀䈂㄄㘆ㄈ㠊㰌", a_), global::CommonResources.AcgResources.ID_RSIMODE, global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.LOVs.ZoneChannelAssignmentRSIMode_A41831LovStrs);
					this.zoneChannelAssignmentRSIMode_A41831.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.zoneChannelAssignmentRSIMode_A41831.DataTransferOrder = 30;
					this.zoneChannelAssignmentRSIMode_A41831.EvaluateRecRefs = true;
					num = (short)3932183;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 10:
					this.alternateComparatorDTLSPortNumber_43801 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("裈ꟊ만꫎ꏐ뷒듔ꏖ볘飚닜닞釠苢韤蛦鷨蓪鿬꯮ꗰ뿲꛴ꟶ雸觺觼뇾琀渂朄戆笈吊㤌㰎⤐⌒␔", a_), global::CommonResources.AcgResources.ID_ALTERNATECOMPARATORDTLSPORTNUMBER, null, null, 0, 1);
					this.alternateComparatorDTLSPortNumber_43801.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.alternateComparatorDTLSPortNumber_43801.DataTransferOrder = 75;
					this.alternateComparatorDTLSPortNumber_43801.ShowHexValue = true;
					num = (short)1020461057;
					if (num != 0)
					{
					}
					num = (short)262171;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					goto IL_652;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏈꓊ꏌ꫎鋐믒듔맖럘뻚뇜點鋠郢賤胦蟨蛪裬臮藰ꇲ꛴뻶꫸鋺觼髾伀瘂栄攆氈礊刌与┐−ⴔ␖⨘", a_)))
					{
						num = (short)1980563486;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_652;
				case 13:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("諈꓊ꃌ뿎냐ꇒ듔ꏖ뛘꧚黜럞胠跢诤苦藨ꗪ飬苮鏰雲蟴ꣶ췸죺염쿾㄀", a_)))
					{
						num = (short)901513249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8EB;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏈꓊ꏌ꫎鋐믒듔맖럘뻚뇜點鋠郢賤胦蟨蛪裬臮藰ꇲ꛴뻶그觺鳼釾爀渂氄猆䀈攊椌明爐爒愔縖瘘甚䈜帞ᔠሢᴤᐦᴨ", a_)))
					{
						num = (short)564199448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_255;
				case 15:
					goto IL_255;
				case 16:
					num = (short)190578722;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_504;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓈꫊꓌ꇎ鋐볒룔Ꟗ룘꧚볜ꯞ軠釢ꇤ돦ꗨ룪뷬胮菰蟲믴苶铸駺飼跾帀㜂㘄〆〈㌊", a_)))
					{
						num = (short)264830978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_829;
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蓈꫊꓌ꇎ鋐볒룔Ꟗ룘꧚볜ꯞ軠釢귤裦髨鿪菬軮鳰雲ꫴ쏶쫸쳺쓼짾", a_)))
					{
						num = (short)852688902;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_781;
				case 20:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏈꓊ꏌ꫎鋐믒듔맖럘뻚뇜點鋠郢賤胦蟨蛪裬臮藰ꇲ꛴뻶듸铺駼髾帀䈂㄄㘆ㄈ㠊㰌", a_)))
					{
						num = (short)459472905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5A2;
				case 21:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏈꓊ꏌ꫎鋐믒듔맖럘뻚뇜點鋠郢賤胦蟨蛪裬臮藰ꇲ꛴뻶그鋺郼髾䔀樂搄欆䠈缊礌倎倐✒␔⼖⨘⸚", a_)))
					{
						num = (short)1736966147;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_356;
				case 22:
					goto IL_829;
				case 23:
					goto IL_5A2;
				case 24:
					this.zoneChannelAssignmentRSITransmitIndication_A41834 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏈꓊ꏌ꫎鋐믒듔맖럘뻚뇜點鋠郢賤胦蟨蛪裬臮藰ꇲ꛴뻶그觺鳼釾爀渂氄猆䀈攊椌明爐爒愔縖瘘甚䈜帞ᔠሢᴤᐦᴨ", a_), global::CommonResources.AcgResources.ID_TRANSMITINDICATION);
					this.zoneChannelAssignmentRSITransmitIndication_A41834.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.zoneChannelAssignmentRSITransmitIndication_A41834.DataTransferOrder = 35;
					num = (short)747044879;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					goto IL_8EB;
				case 26:
				{
					num = (short)1928891408;
					short num4 = num;
					num = (short)601590800;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_8EB;
					default:
						num = (short)1120993280;
						if (num != 0)
						{
						}
						this.zoneChannelAssignmentRSIAutoDial_A41832 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鏈꓊ꏌ꫎鋐믒듔맖럘뻚뇜點鋠郢賤胦蟨蛪裬臮藰ꇲ꛴뻶룸軺觼郾䔀樂搄欆嘈䨊㤌㸎⤐‒✔", a_), global::CommonResources.AcgResources.ID_AUTODIALENABLE);
						this.zoneChannelAssignmentRSIAutoDial_A41832.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
						this.zoneChannelAssignmentRSIAutoDial_A41832.DataTransferOrder = 45;
						num = (short)1362296840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 27:
					goto IL_308;
				case 28:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裈ꟊ만꫎ꏐ뷒듔ꏖ볘飚닜닞釠苢韤蛦鷨蓪鿬꟮黰胲致駶飸雺飼ꃾ㔀。㈄㸆㸈", a_)))
					{
						num = (short)1337262111;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3A4;
				case 29:
					goto IL_356;
				case 30:
					this.zoneChannelAssignmentRSISiteNumber_A41833 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("鏈꓊ꏌ꫎鋐믒듔맖럘뻚뇜點鋠郢賤胦蟨蛪裬臮藰ꇲ꛴뻶꫸鋺觼髾伀瘂栄攆氈礊刌与┐−ⴔ␖⨘", a_), global::CommonResources.AcgResources.ID_SITENUMBER, null, null, 0, 1);
					this.zoneChannelAssignmentRSISiteNumber_A41833.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.zoneChannelAssignmentRSISiteNumber_A41833.DataTransferOrder = 40;
					this.zoneChannelAssignmentRSISiteNumber_A41833.ShowHexValue = false;
					num = (short)1243152395;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					this.alternateComparatorHostname_43797 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_NA, this, global::AllFeatures.CodeplugGuid.b("裈ꟊ만꫎ꏐ뷒듔ꏖ볘飚닜닞釠苢韤蛦鷨蓪鿬꟮黰胲致駶飸雺飼ꃾ㔀。㈄㸆㸈", a_), global::CommonResources.AcgResources.ID_ALTERNATECOMPARATORHOSTNAME, 128);
					this.alternateComparatorHostname_43797.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.alternateComparatorHostname_43797.DataTransferOrder = 65;
					num = (short)671285255;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 32:
					switch (0)
					{
					case 0:
						goto IL_C1;
					}
					continue;
				case 33:
					this.comparatorChannelNumber_43800 = new global::AcpBusinessLayer.AcpSimpleRangeField(1, this, global::AllFeatures.CodeplugGuid.b("諈꓊ꃌ뿎냐ꇒ듔ꏖ뛘꧚黜럞胠跢诤苦藨ꗪ飬苮鏰雲蟴ꣶ췸죺염쿾㄀", a_), global::CommonResources.AcgResources.ID_COMPARATORCHANNELNUMBER, null, null, 0, 1);
					this.comparatorChannelNumber_43800.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.comparatorChannelNumber_43800.DataTransferOrder = 80;
					this.comparatorChannelNumber_43800.ShowHexValue = true;
					num = (short)368836633;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 34:
					if (producerFields != null)
					{
						num = (short)656998401;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_93A;
				case 35:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("裈ꟊ만꫎ꏐ뷒듔ꏖ볘飚닜닞釠苢韤蛦鷨蓪鿬꯮ꗰ뿲꛴ꟶ雸觺觼뇾琀渂朄戆笈吊㤌㰎⤐⌒␔", a_)))
					{
						num = (short)635633674;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_308;
				case 36:
					this.zoneChannelAssignmentRSIDTRTogTime_A41836 = new global::AcpBusinessLayer.AcpSimpleRangeField(3, this, global::AllFeatures.CodeplugGuid.b("鏈꓊ꏌ꫎鋐믒듔맖럘뻚뇜點鋠郢賤胦蟨蛪裬臮藰ꇲ꛴뻶뷸꿺꿼꯾渀搂億渆搈渊刌与┐−ⴔ␖⼘", a_), global::CommonResources.AcgResources.ID_AUTODIALDTRTOGGLETIMESEC, null, null, 0, 1);
					this.zoneChannelAssignmentRSIDTRTogTime_A41836.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.zoneChannelAssignmentRSIDTRTogTime_A41836.DataTransferOrder = 55;
					this.zoneChannelAssignmentRSIDTRTogTime_A41836.ShowHexValue = false;
					num = (short)2052784145;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_C1:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)541655056;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_255:
				num = (short)1741815829;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_308:
				num = (short)1528299533;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_356:
				num = (short)726335493;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3A4:
				num = (short)1032060946;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3F1:
				num = (short)863502348;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5A2:
				num = (short)1779302400;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_652:
				num = (short)776536083;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_781:
				num = (short)1894645788;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_829:
				num = (short)962789411;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8EB:
				num = (short)1167851534;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_504:
			IL_93A:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鯈껊ꃌꃎꗐ뛒蓖냘꿚룜￞꣠跢釤苦鯨跪賬賮铰", a_);
			base.Id = 10760;
			base.UIName = global::CommonResources.AcgResources.ID_REMOTESITEINTERFACE;
			base.DataTransferOrder = 5;
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00030750 File Offset: 0x0002E950
		public override void PopulateReferences()
		{
			short num = (short)1060067675;
			short num2 = num;
			num = (short)1725716827;
			switch (num2 == num)
			{
			}
			num = (short)1490092032;
			short num3 = num;
			num = (short)1964507137;
			if (num != 0)
			{
			}
			num = (short)2126446592;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000242 RID: 578 RVA: 0x000307FC File Offset: 0x0002E9FC
		public override void DropReferences()
		{
			short num = (short)1110563175;
			short num2 = num;
			num = (short)630839655;
			switch (num2 == num)
			{
			}
			num = (short)1776812032;
			short num3 = num;
			num = (short)381288448;
			if (num != 0)
			{
			}
			num = (short)947519489;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x000308A4 File Offset: 0x0002EAA4
		public override void SetConstraints()
		{
			short num = (short)1589958457;
			short num2 = num;
			num = (short)920835897;
			switch (num2 == num)
			{
			}
			num = (short)1271463936;
			short num3 = num;
			num = (short)1497104385;
			if (num != 0)
			{
			}
			num = (short)930742272;
			if (num != 0)
			{
			}
			this.zoneChannelAssignmentRSIMode_A41831.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConTriggerScanListZoneValidity);
			this.zoneChannelAssignmentRSIMode_A41831.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConRSIModeIsValid);
			this.zoneChannelAssignmentRSIMode_A41831.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsNotDZPAndFPPAndIRSI);
			this.zoneChannelAssignmentRSIMode_A41831.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.RSIModeValueSetter);
			this.zoneChannelAssignmentRSIAutoDial_A41832.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConRemoteSiteInterfaceModeIsNotDisabledAndNotIPMode);
			this.zoneChannelAssignmentRSIAutoDial_A41832.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsNotDZPAndFPPEnabled);
			this.zoneChannelAssignmentRSISiteNumber_A41833.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConRemoteSiteInterfaceModeIsNotDisabled);
			this.zoneChannelAssignmentRSISiteNumber_A41833.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsNotDZPAndFPPEnabled);
			this.zoneChannelAssignmentRSISiteNumber_A41833.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.RSISiteNumberValueSetter);
			this.mainComparatorHostname_43796.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConRemoteSiteInterfaceModeIsIPMode);
			this.mainComparatorHostname_43796.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsNotDZPAndFPPEnabled);
			this.mainComparatorHostname_43796.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsMainComparatorHostnameValid);
			this.alternateComparatorHostname_43797.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConRemoteSiteInterfaceModeIsIPMode);
			this.alternateComparatorHostname_43797.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsNotDZPAndFPPEnabled);
			this.mainComparatorDTLSPortNumber_43798.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConRemoteSiteInterfaceModeIsIPMode);
			this.mainComparatorDTLSPortNumber_43798.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsNotDZPAndFPPEnabled);
			this.alternateComparatorDTLSPortNumber_43801.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConRemoteSiteInterfaceModeIsIPMode);
			this.alternateComparatorDTLSPortNumber_43801.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsNotDZPAndFPPEnabled);
			this.comparatorChannelNumber_43800.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConRemoteSiteInterfaceModeIsIPMode);
			this.comparatorChannelNumber_43800.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsNotDZPAndFPPEnabled);
			this.zoneChannelAssignmentRSITransmitIndication_A41834.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConRemoteSiteInterfaceModeIsNotDisabled);
			this.zoneChannelAssignmentRSITransmitIndication_A41834.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsNotDZPAndFPPEnabled);
			this.zoneChannelAssignmentRSITimeDialAtt_A41835.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConRSIModeIsNotDisabledOrIPAndAutoDialIsEn);
			this.zoneChannelAssignmentRSITimeDialAtt_A41835.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsNotDZPAndFPPEnabled);
			this.zoneChannelAssignmentRSIDTRTogTime_A41836.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConRSIModeIsNotDisabledOrIPAndAutoDialIsEn);
			this.zoneChannelAssignmentRSIDTRTogTime_A41836.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignmentConstraints.ConIsNotDZPAndFPPEnabled);
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00030BA0 File Offset: 0x0002EDA0
		public override void SetupDependencies()
		{
			short num = (short)1921686518;
			short num2 = num;
			num = (short)527211510;
			switch (num2 == num)
			{
			}
			num = (short)951320576;
			short num3 = num;
			num = (short)2053177345;
			if (num != 0)
			{
			}
			num = (short)1887830016;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = base.Parent as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
			zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.AddDependentObject(this.zoneChannelAssignmentRSIMode_A41831);
			zoneChannelAssignment.FPPProtection.ZnChanCfgFPPProtectionFPPEnable_A19562.AddDependentObject(this.zoneChannelAssignmentRSIMode_A41831);
			this.zoneChannelAssignmentRSIMode_A41831.AddDependentObject(this.zoneChannelAssignmentRSIAutoDial_A41832);
			zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.AddDependentObject(this.zoneChannelAssignmentRSIAutoDial_A41832);
			zoneChannelAssignment.FPPProtection.ZnChanCfgFPPProtectionFPPEnable_A19562.AddDependentObject(this.zoneChannelAssignmentRSIAutoDial_A41832);
			this.zoneChannelAssignmentRSIMode_A41831.AddDependentObject(this.zoneChannelAssignmentRSISiteNumber_A41833);
			this.zoneChannelAssignmentRSIMode_A41831.AddDependentObject(this.MainComparatorHostname_43796);
			this.zoneChannelAssignmentRSIMode_A41831.AddDependentObject(this.AlternateComparatorHostname_43797);
			this.zoneChannelAssignmentRSIMode_A41831.AddDependentObject(this.MainComparatorDTLSPortNumber_43798);
			this.zoneChannelAssignmentRSIMode_A41831.AddDependentObject(this.AlternateComparatorDTLSPortNumber_43801);
			this.zoneChannelAssignmentRSIMode_A41831.AddDependentObject(this.ComparatorChannelNumber_43800);
			zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.AddDependentObject(this.zoneChannelAssignmentRSISiteNumber_A41833);
			zoneChannelAssignment.FPPProtection.ZnChanCfgFPPProtectionFPPEnable_A19562.AddDependentObject(this.zoneChannelAssignmentRSISiteNumber_A41833);
			this.zoneChannelAssignmentRSIMode_A41831.AddDependentObject(this.zoneChannelAssignmentRSITransmitIndication_A41834);
			zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.AddDependentObject(this.zoneChannelAssignmentRSITransmitIndication_A41834);
			zoneChannelAssignment.FPPProtection.ZnChanCfgFPPProtectionFPPEnable_A19562.AddDependentObject(this.zoneChannelAssignmentRSITransmitIndication_A41834);
			zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.AddDependentObject(this.zoneChannelAssignmentRSITimeDialAtt_A41835);
			zoneChannelAssignment.FPPProtection.ZnChanCfgFPPProtectionFPPEnable_A19562.AddDependentObject(this.zoneChannelAssignmentRSITimeDialAtt_A41835);
			this.zoneChannelAssignmentRSIMode_A41831.AddDependentObject(this.zoneChannelAssignmentRSITimeDialAtt_A41835);
			this.zoneChannelAssignmentRSIAutoDial_A41832.AddDependentObject(this.zoneChannelAssignmentRSITimeDialAtt_A41835);
			zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.AddDependentObject(this.zoneChannelAssignmentRSIDTRTogTime_A41836);
			zoneChannelAssignment.FPPProtection.ZnChanCfgFPPProtectionFPPEnable_A19562.AddDependentObject(this.zoneChannelAssignmentRSIDTRTogTime_A41836);
			this.zoneChannelAssignmentRSIMode_A41831.AddDependentObject(this.zoneChannelAssignmentRSIDTRTogTime_A41836);
			this.zoneChannelAssignmentRSIAutoDial_A41832.AddDependentObject(this.zoneChannelAssignmentRSIDTRTogTime_A41836);
			this.zoneChannelAssignmentRSIMode_A41831.AddDependentObject((global::AcpCommonLib.FeatureManager.GetFeature(2033)[0][10076] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.HomeMode).RadErgoWideHomeModeZone_A9691);
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00030E70 File Offset: 0x0002F070
		public bool HasDiffs
		{
			get
			{
				short num = (short)370970930;
				short num2 = num;
				num = (short)778211634;
				switch (num2 == num)
				{
				}
				num = (short)57933824;
				short num3 = num;
				num = (short)903217152;
				if (num != 0)
				{
				}
				num = (short)1148846081;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000246 RID: 582 RVA: 0x00030F20 File Offset: 0x0002F120
		// (set) Token: 0x06000247 RID: 583 RVA: 0x00030FD4 File Offset: 0x0002F1D4
		public int ZoneChannelAssignmentRSIMode_A41831Value
		{
			get
			{
				short num = (short)907420139;
				short num2 = num;
				num = (short)183575019;
				switch (num2 == num)
				{
				}
				num = (short)547684352;
				short num3 = num;
				num = (short)1796931584;
				if (num != 0)
				{
				}
				num = (short)790036481;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIMode_A41831.Value;
			}
			set
			{
				short num = (short)1204125732;
				short num2 = num;
				num = (short)520060964;
				switch (num2 == num)
				{
				}
				num = (short)502530048;
				short num3 = num;
				num = (short)1480654848;
				if (num != 0)
				{
				}
				num = (short)1272971265;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSIMode_A41831.Value = value;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000248 RID: 584 RVA: 0x00031088 File Offset: 0x0002F288
		// (set) Token: 0x06000249 RID: 585 RVA: 0x0003113C File Offset: 0x0002F33C
		public string ZoneChannelAssignmentRSIMode_A41831_UIValue
		{
			get
			{
				short num = (short)1373544883;
				short num2 = num;
				num = (short)1881645491;
				switch (num2 == num)
				{
				}
				num = (short)1240137728;
				short num3 = num;
				num = (short)1187119105;
				if (num != 0)
				{
				}
				num = (short)250478592;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIMode_A41831.UIValue;
			}
			set
			{
				short num = (short)1940389888;
				short num2 = num;
				num = (short)1259592219;
				short num3 = num;
				num = (short)692181531;
				switch (num3 == num)
				{
				}
				num = (short)133693441;
				if (num != 0)
				{
				}
				num = (short)1045037056;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSIMode_A41831.UIValue = value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600024A RID: 586 RVA: 0x000311F4 File Offset: 0x0002F3F4
		public global::AcpBusinessLayer.AcpListField ZoneChannelAssignmentRSIMode_A41831
		{
			get
			{
				short num = (short)1985871872;
				short num2 = num;
				num = (short)2101382059;
				short num3 = num;
				num = (short)1989118891;
				switch (num3 == num)
				{
				}
				num = (short)1985544192;
				if (num != 0)
				{
				}
				num = (short)384499713;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIMode_A41831;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600024B RID: 587 RVA: 0x000312A4 File Offset: 0x0002F4A4
		// (set) Token: 0x0600024C RID: 588 RVA: 0x00031358 File Offset: 0x0002F558
		public bool ZoneChannelAssignmentRSIMode_A41831_Applicable
		{
			get
			{
				short num = (short)1883373568;
				short num2 = num;
				num = (short)1200607935;
				short num3 = num;
				num = (short)1542771391;
				switch (num3 == num)
				{
				}
				num = (short)1153892353;
				if (num != 0)
				{
				}
				num = (short)305594368;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIMode_A41831.Applicable;
			}
			set
			{
				short num = (short)365756416;
				short num2 = num;
				num = (short)1118498092;
				short num3 = num;
				num = (short)378858796;
				switch (num3 == num)
				{
				}
				num = (short)1703084033;
				if (num != 0)
				{
				}
				num = (short)433127424;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSIMode_A41831.Applicable = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x0600024D RID: 589 RVA: 0x0003140C File Offset: 0x0002F60C
		// (set) Token: 0x0600024E RID: 590 RVA: 0x000314C0 File Offset: 0x0002F6C0
		public bool ZoneChannelAssignmentRSIMode_A41831_Valid
		{
			get
			{
				short num = (short)615055360;
				short num2 = num;
				num = (short)48473717;
				short num3 = num;
				num = (short)903325301;
				switch (num3 == num)
				{
				}
				num = (short)83165185;
				if (num != 0)
				{
				}
				num = (short)701562880;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIMode_A41831.Valid;
			}
			set
			{
				short num = (short)1521483776;
				short num2 = num;
				num = (short)1904547985;
				short num3 = num;
				num = (short)79173777;
				switch (num3 == num)
				{
				}
				num = (short)1126760449;
				if (num != 0)
				{
				}
				num = (short)1654259712;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSIMode_A41831.Valid = value;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600024F RID: 591 RVA: 0x00031574 File Offset: 0x0002F774
		// (set) Token: 0x06000250 RID: 592 RVA: 0x00031628 File Offset: 0x0002F828
		public bool ZoneChannelAssignmentRSIMode_A41831_Visible
		{
			get
			{
				short num = (short)1733427200;
				short num2 = num;
				num = (short)1324714229;
				short num3 = num;
				num = (short)1480952053;
				switch (num3 == num)
				{
				}
				num = (short)105644032;
				if (num != 0)
				{
				}
				num = (short)1116733441;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIMode_A41831.Visible;
			}
			set
			{
				short num = (short)105316352;
				short num2 = num;
				num = (short)1819313107;
				short num3 = num;
				num = (short)1956676563;
				switch (num3 == num)
				{
				}
				num = (short)1534328832;
				if (num != 0)
				{
				}
				num = (short)321060865;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSIMode_A41831.Visible = value;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000251 RID: 593 RVA: 0x000316DC File Offset: 0x0002F8DC
		// (set) Token: 0x06000252 RID: 594 RVA: 0x00031794 File Offset: 0x0002F994
		public bool ZoneChannelAssignmentRSIMode_A41831_Editable
		{
			get
			{
				short num = (short)682622976;
				short num2 = num;
				num = (short)871961299;
				short num3 = num;
				num = (short)1203049171;
				switch (num3 == num)
				{
				}
				num = (short)2105540608;
				if (num != 0)
				{
				}
				num = (short)1584922625;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIMode_A41831.Editable;
			}
			set
			{
				short num = (short)1341259776;
				short num2 = num;
				num = (short)1996226561;
				if (num != 0)
				{
				}
				num = (short)557283666;
				short num3 = num;
				num = (short)1165523282;
				switch (num3 == num)
				{
				}
				num = (short)154664960;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSIMode_A41831.Editable = value;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000253 RID: 595 RVA: 0x00031848 File Offset: 0x0002FA48
		internal string ZoneChannelAssignmentRSIMode_A41831_UILabel
		{
			get
			{
				short num = (short)1422589952;
				short num2 = num;
				num = (short)351385291;
				short num3 = num;
				num = (short)1227339467;
				switch (num3 == num)
				{
				}
				num = (short)136052737;
				if (num != 0)
				{
				}
				num = (short)2068578304;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIMode_A41831.UIName;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000254 RID: 596 RVA: 0x000318FC File Offset: 0x0002FAFC
		// (set) Token: 0x06000255 RID: 597 RVA: 0x000319B0 File Offset: 0x0002FBB0
		internal bool ZoneChannelAssignmentRSIMode_A41831_HiddenStatic
		{
			get
			{
				short num = (short)2070347776;
				short num2 = num;
				num = (short)982132648;
				short num3 = num;
				num = (short)1474045864;
				switch (num3 == num)
				{
				}
				num = (short)133693441;
				if (num != 0)
				{
				}
				num = (short)322437120;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIMode_A41831.HiddenStatic;
			}
			set
			{
				short num = (short)242941952;
				short num2 = num;
				num = (short)252532995;
				short num3 = num;
				num = (short)1726109955;
				switch (num3 == num)
				{
				}
				num = (short)1059913728;
				if (num != 0)
				{
				}
				num = (short)1824522241;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSIMode_A41831.HiddenStatic = value;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000256 RID: 598 RVA: 0x00031A64 File Offset: 0x0002FC64
		// (set) Token: 0x06000257 RID: 599 RVA: 0x00031B18 File Offset: 0x0002FD18
		internal bool ZoneChannelAssignmentRSIMode_A41831_HiddenDynamic
		{
			get
			{
				short num = (short)1028128768;
				short num2 = num;
				num = (short)2142742223;
				short num3 = num;
				num = (short)754230991;
				switch (num3 == num)
				{
				}
				num = (short)1018822657;
				if (num != 0)
				{
				}
				num = (short)1869676544;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIMode_A41831.HiddenDynamic;
			}
			set
			{
				short num = (short)476446720;
				short num2 = num;
				num = (short)1481267248;
				short num3 = num;
				num = (short)456218672;
				switch (num3 == num)
				{
				}
				num = (short)528613377;
				if (num != 0)
				{
				}
				num = (short)746586112;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSIMode_A41831.HiddenDynamic = value;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000258 RID: 600 RVA: 0x00031BCC File Offset: 0x0002FDCC
		public bool ZoneChannelAssignmentRSIMode_A41831_HasDiffs
		{
			get
			{
				short num = (short)1130299392;
				short num2 = num;
				num = (short)1283391489;
				if (num != 0)
				{
				}
				num = (short)767433107;
				short num3 = num;
				num = (short)1961040275;
				switch (num3 == num)
				{
				}
				num = (short)56033280;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIMode_A41831._HasDiffs;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000259 RID: 601 RVA: 0x00031C80 File Offset: 0x0002FE80
		// (set) Token: 0x0600025A RID: 602 RVA: 0x00031D34 File Offset: 0x0002FF34
		public bool ZoneChannelAssignmentRSIAutoDial_A41832Value
		{
			get
			{
				short num = (short)188022784;
				short num2 = num;
				num = (short)906638942;
				short num3 = num;
				num = (short)352204382;
				switch (num3 == num)
				{
				}
				num = (short)1906114560;
				if (num != 0)
				{
				}
				num = (short)1662189569;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIAutoDial_A41832.Value;
			}
			set
			{
				short num = (short)1563033600;
				short num2 = num;
				num = (short)1934426113;
				if (num != 0)
				{
				}
				num = (short)248203649;
				short num3 = num;
				num = (short)213797249;
				switch (num3 == num)
				{
				}
				num = (short)662503424;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSIAutoDial_A41832.Value = value;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x0600025B RID: 603 RVA: 0x00031DF0 File Offset: 0x0002FFF0
		public global::AcpBusinessLayer.AcpField<bool> ZoneChannelAssignmentRSIAutoDial_A41832
		{
			get
			{
				short num = (short)2124873728;
				short num2 = num;
				num = (short)487981190;
				short num3 = num;
				num = (short)1046085766;
				switch (num3 == num)
				{
				}
				num = (short)260505601;
				if (num != 0)
				{
				}
				num = (short)508166144;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIAutoDial_A41832;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600025C RID: 604 RVA: 0x00031EA0 File Offset: 0x000300A0
		// (set) Token: 0x0600025D RID: 605 RVA: 0x00031F54 File Offset: 0x00030154
		public bool ZoneChannelAssignmentRSIAutoDial_A41832_UIValue
		{
			get
			{
				short num = (short)1242824704;
				short num2 = num;
				num = (short)1355350017;
				if (num != 0)
				{
				}
				num = (short)1371608858;
				short num3 = num;
				num = (short)1897666330;
				switch (num3 == num)
				{
				}
				num = (short)303562752;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIAutoDial_A41832.Value;
			}
			set
			{
				short num = (short)99745792;
				short num2 = num;
				num = (short)1336878102;
				short num3 = num;
				num = (short)216081430;
				switch (num3 == num)
				{
				}
				num = (short)812515329;
				if (num != 0)
				{
				}
				num = (short)117768192;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSIAutoDial_A41832.Value = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600025E RID: 606 RVA: 0x0003200C File Offset: 0x0003020C
		// (set) Token: 0x0600025F RID: 607 RVA: 0x000320C0 File Offset: 0x000302C0
		public bool ZoneChannelAssignmentRSIAutoDial_A41832_Applicable
		{
			get
			{
				short num = (short)334299136;
				short num2 = num;
				num = (short)2071500818;
				short num3 = num;
				num = (short)899192850;
				switch (num3 == num)
				{
				}
				num = (short)614334465;
				if (num != 0)
				{
				}
				num = (short)50200576;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIAutoDial_A41832.Applicable;
			}
			set
			{
				short num = (short)1635319808;
				short num2 = num;
				num = (short)1016283341;
				short num3 = num;
				num = (short)778977485;
				switch (num3 == num)
				{
				}
				num = (short)1756168193;
				if (num != 0)
				{
				}
				num = (short)224526336;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSIAutoDial_A41832.Applicable = value;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000260 RID: 608 RVA: 0x00032174 File Offset: 0x00030374
		// (set) Token: 0x06000261 RID: 609 RVA: 0x00032228 File Offset: 0x00030428
		public bool ZoneChannelAssignmentRSIAutoDial_A41832_Valid
		{
			get
			{
				short num = (short)228720640;
				short num2 = num;
				num = (short)581959681;
				if (num != 0)
				{
				}
				num = (short)241612370;
				short num3 = num;
				num = (short)349222482;
				switch (num3 == num)
				{
				}
				num = (short)1332740096;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIAutoDial_A41832.Valid;
			}
			set
			{
				short num = (short)1195376640;
				short num2 = num;
				num = (short)1214775297;
				if (num != 0)
				{
				}
				num = (short)2119807055;
				short num3 = num;
				num = (short)471707727;
				switch (num3 == num)
				{
				}
				num = (short)1974272000;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSIAutoDial_A41832.Valid = value;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000262 RID: 610 RVA: 0x000322DC File Offset: 0x000304DC
		// (set) Token: 0x06000263 RID: 611 RVA: 0x00032390 File Offset: 0x00030590
		public bool ZoneChannelAssignmentRSIAutoDial_A41832_Visible
		{
			get
			{
				short num = (short)515768320;
				short num2 = num;
				num = (short)1736555167;
				short num3 = num;
				num = (short)1057929887;
				switch (num3 == num)
				{
				}
				num = (short)35127297;
				if (num != 0)
				{
				}
				num = (short)1380843520;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIAutoDial_A41832.Visible;
			}
			set
			{
				short num = (short)515768320;
				short num2 = num;
				num = (short)1821719324;
				short num3 = num;
				num = (short)2126789404;
				switch (num3 == num)
				{
				}
				num = (short)801374208;
				if (num != 0)
				{
				}
				num = (short)1051459585;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSIAutoDial_A41832.Visible = value;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000264 RID: 612 RVA: 0x00032444 File Offset: 0x00030644
		// (set) Token: 0x06000265 RID: 613 RVA: 0x000324F8 File Offset: 0x000306F8
		public bool ZoneChannelAssignmentRSIAutoDial_A41832_Editable
		{
			get
			{
				short num = (short)181141504;
				short num2 = num;
				num = (short)761153676;
				short num3 = num;
				num = (short)1582778508;
				switch (num3 == num)
				{
				}
				num = (short)1021313024;
				if (num != 0)
				{
				}
				num = (short)2130182145;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIAutoDial_A41832.Editable;
			}
			set
			{
				short num = (short)1471479808;
				short num2 = num;
				num = (short)635128079;
				short num3 = num;
				num = (short)939280655;
				switch (num3 == num)
				{
				}
				num = (short)1138556929;
				if (num != 0)
				{
				}
				num = (short)2012413952;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSIAutoDial_A41832.Editable = value;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000266 RID: 614 RVA: 0x000325B0 File Offset: 0x000307B0
		internal string ZoneChannelAssignmentRSIAutoDial_A41832_UILabel
		{
			get
			{
				short num = (short)991690752;
				short num2 = num;
				num = (short)1365377025;
				if (num != 0)
				{
				}
				num = (short)986022180;
				short num3 = num;
				num = (short)1804894500;
				switch (num3 == num)
				{
				}
				num = (short)691404800;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIAutoDial_A41832.UIName;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00032664 File Offset: 0x00030864
		// (set) Token: 0x06000268 RID: 616 RVA: 0x00032718 File Offset: 0x00030918
		internal bool ZoneChannelAssignmentRSIAutoDial_A41832_HiddenStatic
		{
			get
			{
				short num = (short)897581056;
				short num2 = num;
				num = (short)275770701;
				short num3 = num;
				num = (short)2006183245;
				switch (num3 == num)
				{
				}
				num = (short)815398913;
				if (num != 0)
				{
				}
				num = (short)2146238464;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIAutoDial_A41832.HiddenStatic;
			}
			set
			{
				short num = (short)1146683392;
				short num2 = num;
				num = (short)1398451866;
				short num3 = num;
				num = (short)780709530;
				switch (num3 == num)
				{
				}
				num = (short)1214251009;
				if (num != 0)
				{
				}
				num = (short)408551424;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSIAutoDial_A41832.HiddenStatic = value;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000269 RID: 617 RVA: 0x000327CC File Offset: 0x000309CC
		// (set) Token: 0x0600026A RID: 618 RVA: 0x0003287C File Offset: 0x00030A7C
		internal bool ZoneChannelAssignmentRSIAutoDial_A41832_HiddenDynamic
		{
			get
			{
				short num = (short)1841233920;
				short num2 = num;
				num = (short)815034234;
				short num3 = num;
				num = (short)647393146;
				switch (num3 == num)
				{
				}
				num = (short)1803943937;
				if (num != 0)
				{
				}
				num = (short)1178992640;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIAutoDial_A41832.HiddenDynamic;
			}
			set
			{
				short num = (short)1076101120;
				short num2 = num;
				num = (short)1314711005;
				short num3 = num;
				num = (short)1498932701;
				switch (num3 == num)
				{
				}
				num = (short)1150943233;
				if (num != 0)
				{
				}
				num = (short)1229520896;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSIAutoDial_A41832.HiddenDynamic = value;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x0600026B RID: 619 RVA: 0x00032930 File Offset: 0x00030B30
		public bool ZoneChannelAssignmentRSIAutoDial_A41832_HasDiffs
		{
			get
			{
				short num = (short)762314752;
				short num2 = num;
				num = (short)1727158085;
				short num3 = num;
				num = (short)1052923717;
				switch (num3 == num)
				{
				}
				num = (short)1202126848;
				if (num != 0)
				{
				}
				num = (short)827392001;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIAutoDial_A41832._HasDiffs;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x0600026C RID: 620 RVA: 0x000329E8 File Offset: 0x00030BE8
		// (set) Token: 0x0600026D RID: 621 RVA: 0x00032AA0 File Offset: 0x00030CA0
		public int ZoneChannelAssignmentRSISiteNumber_A41833Value
		{
			get
			{
				short num = (short)785907712;
				short num2 = num;
				num = (short)1379731341;
				short num3 = num;
				num = (short)2072250253;
				switch (num3 == num)
				{
				}
				num = (short)46923777;
				if (num != 0)
				{
				}
				num = (short)1267269632;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSISiteNumber_A41833.Value;
			}
			set
			{
				short num = (short)640876544;
				short num2 = num;
				num = (short)1199054317;
				short num3 = num;
				num = (short)544480749;
				switch (num3 == num)
				{
				}
				num = (short)1100873728;
				if (num != 0)
				{
				}
				num = (short)1867710465;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSISiteNumber_A41833.Value = value;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x0600026E RID: 622 RVA: 0x00032B58 File Offset: 0x00030D58
		public global::AcpBusinessLayer.AcpSimpleRangeField ZoneChannelAssignmentRSISiteNumber_A41833
		{
			get
			{
				short num = (short)1191116800;
				short num2 = num;
				num = (short)2001054291;
				short num3 = num;
				num = (short)1239263827;
				switch (num3 == num)
				{
				}
				num = (short)643891200;
				if (num != 0)
				{
				}
				num = (short)373948417;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSISiteNumber_A41833;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x0600026F RID: 623 RVA: 0x00032C08 File Offset: 0x00030E08
		// (set) Token: 0x06000270 RID: 624 RVA: 0x00032CBC File Offset: 0x00030EBC
		public string ZoneChannelAssignmentRSISiteNumber_A41833_UIValue
		{
			get
			{
				short num = (short)779681792;
				short num2 = num;
				num = (short)199737850;
				short num3 = num;
				num = (short)49922554;
				switch (num3 == num)
				{
				}
				num = (short)1493303297;
				if (num != 0)
				{
				}
				num = (short)1682702336;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSISiteNumber_A41833.UIValue;
			}
			set
			{
				short num = (short)946405376;
				short num2 = num;
				num = (short)1159325621;
				short num3 = num;
				num = (short)802088885;
				switch (num3 == num)
				{
				}
				num = (short)123994113;
				if (num != 0)
				{
				}
				num = (short)1751777280;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSISiteNumber_A41833.UIValue = value;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000271 RID: 625 RVA: 0x00032D74 File Offset: 0x00030F74
		// (set) Token: 0x06000272 RID: 626 RVA: 0x00032E28 File Offset: 0x00031028
		internal int ZoneChannelAssignmentRSISiteNumber_A41833Min
		{
			get
			{
				short num = (short)760152064;
				short num2 = num;
				num = (short)706326674;
				short num3 = num;
				num = (short)451588242;
				switch (num3 == num)
				{
				}
				num = (short)55181313;
				if (num != 0)
				{
				}
				num = (short)144900096;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSISiteNumber_A41833.Min;
			}
			set
			{
				short num = (short)144703488;
				short num2 = num;
				num = (short)583663617;
				if (num != 0)
				{
				}
				num = (short)1654088829;
				short num3 = num;
				num = (short)181757053;
				switch (num3 == num)
				{
				}
				num = (short)812056576;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSISiteNumber_A41833.Min = value;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000273 RID: 627 RVA: 0x00032EE0 File Offset: 0x000310E0
		// (set) Token: 0x06000274 RID: 628 RVA: 0x00032F94 File Offset: 0x00031194
		public int ZoneChannelAssignmentRSISiteNumber_A41833Max
		{
			get
			{
				short num = (short)2057175040;
				short num2 = num;
				num = (short)1930181978;
				short num3 = num;
				num = (short)2092449114;
				switch (num3 == num)
				{
				}
				num = (short)1109458945;
				if (num != 0)
				{
				}
				num = (short)1683816448;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSISiteNumber_A41833.Max;
			}
			set
			{
				short num = (short)97910784;
				short num2 = num;
				num = (short)1285113316;
				short num3 = num;
				num = (short)871253476;
				switch (num3 == num)
				{
				}
				num = (short)2021523456;
				if (num != 0)
				{
				}
				num = (short)1405288449;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSISiteNumber_A41833.Max = value;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000275 RID: 629 RVA: 0x00033048 File Offset: 0x00031248
		// (set) Token: 0x06000276 RID: 630 RVA: 0x00033100 File Offset: 0x00031300
		internal int ZoneChannelAssignmentRSISiteNumber_A41833Step
		{
			get
			{
				short num = (short)1615855616;
				short num2 = num;
				num = (short)247194219;
				short num3 = num;
				num = (short)1119019627;
				switch (num3 == num)
				{
				}
				num = (short)602013697;
				if (num != 0)
				{
				}
				num = (short)972029952;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSISiteNumber_A41833.StepSize;
			}
			set
			{
				short num = (short)1479475200;
				short num2 = num;
				num = (short)1186928767;
				short num3 = num;
				num = (short)294918271;
				switch (num3 == num)
				{
				}
				num = (short)479330304;
				if (num != 0)
				{
				}
				num = (short)419692545;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSISiteNumber_A41833.StepSize = value;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000277 RID: 631 RVA: 0x000331B8 File Offset: 0x000313B8
		// (set) Token: 0x06000278 RID: 632 RVA: 0x0003326C File Offset: 0x0003146C
		public bool ZoneChannelAssignmentRSISiteNumber_A41833_Applicable
		{
			get
			{
				short num = (short)502792192;
				short num2 = num;
				num = (short)182596365;
				short num3 = num;
				num = (short)1467888397;
				switch (num3 == num)
				{
				}
				num = (short)378273792;
				if (num != 0)
				{
				}
				num = (short)1650720769;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSISiteNumber_A41833.Applicable;
			}
			set
			{
				short num = (short)1460076544;
				short num2 = num;
				num = (short)178958987;
				short num3 = num;
				num = (short)1224454795;
				switch (num3 == num)
				{
				}
				num = (short)181075969;
				if (num != 0)
				{
				}
				num = (short)318767104;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSISiteNumber_A41833.Applicable = value;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000279 RID: 633 RVA: 0x00033320 File Offset: 0x00031520
		// (set) Token: 0x0600027A RID: 634 RVA: 0x000333D8 File Offset: 0x000315D8
		public bool ZoneChannelAssignmentRSISiteNumber_A41833_Valid
		{
			get
			{
				short num = (short)1017905152;
				short num2 = num;
				num = (short)515146038;
				short num3 = num;
				num = (short)853311798;
				switch (num3 == num)
				{
				}
				num = (short)131072001;
				if (num != 0)
				{
				}
				num = (short)271187968;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSISiteNumber_A41833.Valid;
			}
			set
			{
				short num = (short)530186240;
				short num2 = num;
				num = (short)1214365093;
				short num3 = num;
				num = (short)251641253;
				switch (num3 == num)
				{
				}
				num = (short)1552220161;
				if (num != 0)
				{
				}
				num = (short)805765120;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSISiteNumber_A41833.Valid = value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x0600027B RID: 635 RVA: 0x00033490 File Offset: 0x00031690
		// (set) Token: 0x0600027C RID: 636 RVA: 0x00033540 File Offset: 0x00031740
		public bool ZoneChannelAssignmentRSISiteNumber_A41833_Visible
		{
			get
			{
				short num = (short)655491072;
				short num2 = num;
				num = (short)997090711;
				short num3 = num;
				num = (short)886859159;
				switch (num3 == num)
				{
				}
				num = (short)918421505;
				if (num != 0)
				{
				}
				num = (short)282656768;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSISiteNumber_A41833.Visible;
			}
			set
			{
				short num = (short)371589120;
				short num2 = num;
				num = (short)165889968;
				short num3 = num;
				num = (short)1066944432;
				switch (num3 == num)
				{
				}
				num = (short)247726081;
				if (num != 0)
				{
				}
				num = (short)213647360;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSISiteNumber_A41833.Visible = value;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600027D RID: 637 RVA: 0x000335F4 File Offset: 0x000317F4
		// (set) Token: 0x0600027E RID: 638 RVA: 0x000336A8 File Offset: 0x000318A8
		public bool ZoneChannelAssignmentRSISiteNumber_A41833_Editable
		{
			get
			{
				short num = (short)90243072;
				short num2 = num;
				num = (short)1937318245;
				short num3 = num;
				num = (short)813637989;
				switch (num3 == num)
				{
				}
				num = (short)2132738049;
				if (num != 0)
				{
				}
				num = (short)878116864;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSISiteNumber_A41833.Editable;
			}
			set
			{
				short num = (short)1292265737;
				short num2 = num;
				num = (short)238577929;
				switch (num2 == num)
				{
				}
				num = (short)333578240;
				if (num != 0)
				{
				}
				num = (short)1302790144;
				short num3 = num;
				num = (short)488570881;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSISiteNumber_A41833.Editable = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600027F RID: 639 RVA: 0x0003375C File Offset: 0x0003195C
		internal string ZoneChannelAssignmentRSISiteNumber_A41833_UILabel
		{
			get
			{
				short num = (short)1495694749;
				short num2 = num;
				num = (short)1986755997;
				switch (num2 == num)
				{
				}
				num = (short)1982332928;
				if (num != 0)
				{
				}
				num = (short)1694433280;
				short num3 = num;
				num = (short)2043412481;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSISiteNumber_A41833.UIName;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000280 RID: 640 RVA: 0x00033810 File Offset: 0x00031A10
		// (set) Token: 0x06000281 RID: 641 RVA: 0x000338C4 File Offset: 0x00031AC4
		internal bool ZoneChannelAssignmentRSISiteNumber_A41833_HiddenStatic
		{
			get
			{
				short num = (short)467223048;
				short num2 = num;
				num = (short)606618120;
				switch (num2 == num)
				{
				}
				num = (short)190644224;
				if (num != 0)
				{
				}
				num = (short)1438646272;
				short num3 = num;
				num = (short)1513553921;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSISiteNumber_A41833.HiddenStatic;
			}
			set
			{
				short num = (short)1657490142;
				short num2 = num;
				num = (short)218712798;
				switch (num2 == num)
				{
				}
				num = (short)1153826817;
				if (num != 0)
				{
				}
				num = (short)1704656896;
				short num3 = num;
				num = (short)368705536;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSISiteNumber_A41833.HiddenStatic = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000282 RID: 642 RVA: 0x0003397C File Offset: 0x00031B7C
		// (set) Token: 0x06000283 RID: 643 RVA: 0x00033A30 File Offset: 0x00031C30
		internal bool ZoneChannelAssignmentRSISiteNumber_A41833_HiddenDynamic
		{
			get
			{
				short num = (short)49552492;
				short num2 = num;
				num = (short)894180460;
				switch (num2 == num)
				{
				}
				num = (short)1544617985;
				if (num != 0)
				{
				}
				num = (short)56754176;
				short num3 = num;
				num = (short)1701249024;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSISiteNumber_A41833.HiddenDynamic;
			}
			set
			{
				short num = (short)358416385;
				if (num != 0)
				{
				}
				num = (short)527842525;
				short num2 = num;
				num = (short)1318337757;
				switch (num2 == num)
				{
				}
				num = (short)1475608576;
				short num3 = num;
				num = (short)205520896;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSISiteNumber_A41833.HiddenDynamic = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000284 RID: 644 RVA: 0x00033AE8 File Offset: 0x00031CE8
		public bool ZoneChannelAssignmentRSISiteNumber_A41833_HasDiffs
		{
			get
			{
				short num = (short)1886060545;
				if (num != 0)
				{
				}
				num = (short)1305406421;
				short num2 = num;
				num = (short)1244851157;
				switch (num2 == num)
				{
				}
				num = (short)12255232;
				short num3 = num;
				num = (short)108986368;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSISiteNumber_A41833._HasDiffs;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000285 RID: 645 RVA: 0x00033B9C File Offset: 0x00031D9C
		// (set) Token: 0x06000286 RID: 646 RVA: 0x00033C50 File Offset: 0x00031E50
		public string MainComparatorHostname_43796Value
		{
			get
			{
				short num = (short)880205173;
				short num2 = num;
				num = (short)48749941;
				switch (num2 == num)
				{
				}
				num = (short)453640192;
				if (num != 0)
				{
				}
				num = (short)159580160;
				short num3 = num;
				num = (short)224264193;
				if (num != 0)
				{
				}
				return this.mainComparatorHostname_43796.Value;
			}
			set
			{
				short num = (short)737804289;
				if (num != 0)
				{
				}
				num = (short)1087389800;
				short num2 = num;
				num = (short)1311719528;
				switch (num2 == num)
				{
				}
				num = (short)110034944;
				short num3 = num;
				num = (short)1411186688;
				if (num != 0)
				{
				}
				this.mainComparatorHostname_43796.Value = value;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000287 RID: 647 RVA: 0x00033D08 File Offset: 0x00031F08
		public global::AcpBusinessLayer.AcpField<string> MainComparatorHostname_43796
		{
			get
			{
				short num = (short)1533229763;
				short num2 = num;
				num = (short)145504963;
				switch (num2 == num)
				{
				}
				num = (short)868286465;
				if (num != 0)
				{
				}
				num = (short)74973184;
				short num3 = num;
				num = (short)1241382912;
				if (num != 0)
				{
				}
				return this.mainComparatorHostname_43796;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000288 RID: 648 RVA: 0x00033DB4 File Offset: 0x00031FB4
		// (set) Token: 0x06000289 RID: 649 RVA: 0x00033E68 File Offset: 0x00032068
		public string MainComparatorHostname_43796_UIValue
		{
			get
			{
				short num = (short)983208366;
				short num2 = num;
				num = (short)1478332846;
				switch (num2 == num)
				{
				}
				num = (short)495779840;
				if (num != 0)
				{
				}
				num = (short)905904128;
				short num3 = num;
				num = (short)209321985;
				if (num != 0)
				{
				}
				return this.mainComparatorHostname_43796.Value;
			}
			set
			{
				short num = (short)2122615812;
				short num2 = num;
				num = (short)1429703684;
				switch (num2 == num)
				{
				}
				num = (short)1645412353;
				if (num != 0)
				{
				}
				num = (short)780468224;
				short num3 = num;
				num = (short)950665216;
				if (num != 0)
				{
				}
				this.mainComparatorHostname_43796.Value = value;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600028A RID: 650 RVA: 0x00033F20 File Offset: 0x00032120
		// (set) Token: 0x0600028B RID: 651 RVA: 0x00033FD4 File Offset: 0x000321D4
		public bool MainComparatorHostname_43796_Applicable
		{
			get
			{
				short num = (short)768999425;
				if (num != 0)
				{
				}
				num = (short)414451761;
				short num2 = num;
				num = (short)928385073;
				switch (num2 == num)
				{
				}
				num = (short)1239285760;
				short num3 = num;
				num = (short)1275265024;
				if (num != 0)
				{
				}
				return this.mainComparatorHostname_43796.Applicable;
			}
			set
			{
				short num = (short)707133441;
				if (num != 0)
				{
				}
				num = (short)308525102;
				short num2 = num;
				num = (short)642693166;
				switch (num2 == num)
				{
				}
				num = (short)1016463360;
				short num3 = num;
				num = (short)480378880;
				if (num != 0)
				{
				}
				this.mainComparatorHostname_43796.Applicable = value;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600028C RID: 652 RVA: 0x00034088 File Offset: 0x00032288
		// (set) Token: 0x0600028D RID: 653 RVA: 0x0003413C File Offset: 0x0003233C
		public bool MainComparatorHostname_43796_Valid
		{
			get
			{
				short num = (short)1528460069;
				short num2 = num;
				num = (short)2111140645;
				switch (num2 == num)
				{
				}
				num = (short)757465089;
				if (num != 0)
				{
				}
				num = (short)1473642496;
				short num3 = num;
				num = (short)1996554240;
				if (num != 0)
				{
				}
				return this.mainComparatorHostname_43796.Valid;
			}
			set
			{
				short num = (short)15093642;
				short num2 = num;
				num = (short)850939786;
				switch (num2 == num)
				{
				}
				num = (short)198311937;
				if (num != 0)
				{
				}
				num = (short)867368960;
				short num3 = num;
				num = (short)874774528;
				if (num != 0)
				{
				}
				this.mainComparatorHostname_43796.Valid = value;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600028E RID: 654 RVA: 0x000341F0 File Offset: 0x000323F0
		// (set) Token: 0x0600028F RID: 655 RVA: 0x000342A4 File Offset: 0x000324A4
		public bool MainComparatorHostname_43796_Visible
		{
			get
			{
				short num = (short)123731969;
				if (num != 0)
				{
				}
				num = (short)1954369699;
				short num2 = num;
				num = (short)952062115;
				switch (num2 == num)
				{
				}
				num = (short)1059913728;
				short num3 = num;
				num = (short)1848508416;
				if (num != 0)
				{
				}
				return this.mainComparatorHostname_43796.Visible;
			}
			set
			{
				short num = (short)460323750;
				short num2 = num;
				num = (short)515898278;
				switch (num2 == num)
				{
				}
				num = (short)1381761025;
				if (num != 0)
				{
				}
				num = (short)8519680;
				short num3 = num;
				num = (short)1480196096;
				if (num != 0)
				{
				}
				this.mainComparatorHostname_43796.Visible = value;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000290 RID: 656 RVA: 0x0003435C File Offset: 0x0003255C
		// (set) Token: 0x06000291 RID: 657 RVA: 0x00034410 File Offset: 0x00032610
		public bool MainComparatorHostname_43796_Editable
		{
			get
			{
				short num = (short)623479819;
				short num2 = num;
				num = (short)1890356235;
				switch (num2 == num)
				{
				}
				num = (short)683081729;
				if (num != 0)
				{
				}
				num = (short)56557568;
				short num3 = num;
				num = (short)813498368;
				if (num != 0)
				{
				}
				return this.mainComparatorHostname_43796.Editable;
			}
			set
			{
				short num = (short)433424263;
				short num2 = num;
				num = (short)302876551;
				switch (num2 == num)
				{
				}
				num = (short)849739777;
				if (num != 0)
				{
				}
				num = (short)894894080;
				short num3 = num;
				num = (short)1005322240;
				if (num != 0)
				{
				}
				this.mainComparatorHostname_43796.Editable = value;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000292 RID: 658 RVA: 0x000344C8 File Offset: 0x000326C8
		internal string MainComparatorHostname_43796_UILabel
		{
			get
			{
				short num = (short)547231952;
				short num2 = num;
				num = (short)973740240;
				switch (num2 == num)
				{
				}
				num = (short)1478623232;
				if (num != 0)
				{
				}
				num = (short)2091515904;
				short num3 = num;
				num = (short)542638081;
				if (num != 0)
				{
				}
				return this.mainComparatorHostname_43796.UIName;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000293 RID: 659 RVA: 0x0003457C File Offset: 0x0003277C
		// (set) Token: 0x06000294 RID: 660 RVA: 0x00034630 File Offset: 0x00032830
		internal bool MainComparatorHostname_43796_HiddenStatic
		{
			get
			{
				short num = (short)177104520;
				short num2 = num;
				num = (short)971531912;
				switch (num2 == num)
				{
				}
				num = (short)1183186944;
				if (num != 0)
				{
				}
				num = (short)726990848;
				short num3 = num;
				num = (short)172621825;
				if (num != 0)
				{
				}
				return this.mainComparatorHostname_43796.HiddenStatic;
			}
			set
			{
				short num = (short)527810456;
				short num2 = num;
				num = (short)780517272;
				switch (num2 == num)
				{
				}
				num = (short)1689976833;
				if (num != 0)
				{
				}
				num = (short)1356791808;
				short num3 = num;
				num = (short)1249247232;
				if (num != 0)
				{
				}
				this.mainComparatorHostname_43796.HiddenStatic = value;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000295 RID: 661 RVA: 0x000346E4 File Offset: 0x000328E4
		// (set) Token: 0x06000296 RID: 662 RVA: 0x0003479C File Offset: 0x0003299C
		internal bool MainComparatorHostname_43796_HiddenDynamic
		{
			get
			{
				short num = (short)176183991;
				short num2 = num;
				num = (short)1911839415;
				switch (num2 == num)
				{
				}
				num = (short)1789263873;
				if (num != 0)
				{
				}
				num = (short)878247936;
				short num3 = num;
				num = (short)431423488;
				if (num != 0)
				{
				}
				return this.mainComparatorHostname_43796.HiddenDynamic;
			}
			set
			{
				short num = (short)16251624;
				short num2 = num;
				num = (short)1646525160;
				switch (num2 == num)
				{
				}
				num = (short)1259536385;
				if (num != 0)
				{
				}
				num = (short)1229258752;
				short num3 = num;
				num = (short)1663762432;
				if (num != 0)
				{
				}
				this.mainComparatorHostname_43796.HiddenDynamic = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000297 RID: 663 RVA: 0x00034850 File Offset: 0x00032A50
		public bool MainComparatorHostname_43796_HasDiffs
		{
			get
			{
				short num = (short)1114297319;
				short num2 = num;
				num = (short)526308327;
				switch (num2 == num)
				{
				}
				num = (short)1289945089;
				if (num != 0)
				{
				}
				num = (short)1777795072;
				short num3 = num;
				num = (short)1805123584;
				if (num != 0)
				{
				}
				return this.mainComparatorHostname_43796._HasDiffs;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000298 RID: 664 RVA: 0x00034904 File Offset: 0x00032B04
		// (set) Token: 0x06000299 RID: 665 RVA: 0x000349BC File Offset: 0x00032BBC
		public string AlternateComparatorHostname_43797Value
		{
			get
			{
				short num = (short)1105237968;
				short num2 = num;
				num = (short)188585936;
				switch (num2 == num)
				{
				}
				num = (short)1775763457;
				if (num != 0)
				{
				}
				num = (short)1644822528;
				short num3 = num;
				num = (short)528351232;
				if (num != 0)
				{
				}
				return this.alternateComparatorHostname_43797.Value;
			}
			set
			{
				short num = (short)442664850;
				short num2 = num;
				num = (short)1019119506;
				switch (num2 == num)
				{
				}
				num = (short)536674305;
				if (num != 0)
				{
				}
				num = (short)1818099712;
				short num3 = num;
				num = (short)643497984;
				if (num != 0)
				{
				}
				this.alternateComparatorHostname_43797.Value = value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600029A RID: 666 RVA: 0x00034A70 File Offset: 0x00032C70
		public global::AcpBusinessLayer.AcpField<string> AlternateComparatorHostname_43797
		{
			get
			{
				short num = (short)1819379856;
				short num2 = num;
				num = (short)1492945040;
				switch (num2 == num)
				{
				}
				num = (short)1128005633;
				if (num != 0)
				{
				}
				num = (short)1178730496;
				short num3 = num;
				num = (short)1103953920;
				if (num != 0)
				{
				}
				return this.alternateComparatorHostname_43797;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600029B RID: 667 RVA: 0x00034B1C File Offset: 0x00032D1C
		// (set) Token: 0x0600029C RID: 668 RVA: 0x00034BD4 File Offset: 0x00032DD4
		public string AlternateComparatorHostname_43797_UIValue
		{
			get
			{
				short num = (short)47171414;
				short num2 = num;
				num = (short)2099234646;
				switch (num2 == num)
				{
				}
				num = (short)1776222209;
				if (num != 0)
				{
				}
				num = (short)180158464;
				short num3 = num;
				num = (short)2058747904;
				if (num != 0)
				{
				}
				return this.alternateComparatorHostname_43797.Value;
			}
			set
			{
				short num = (short)1343881217;
				if (num != 0)
				{
				}
				num = (short)493587306;
				short num2 = num;
				num = (short)2853738;
				switch (num2 == num)
				{
				}
				num = (short)1173225472;
				short num3 = num;
				num = (short)1930821632;
				if (num != 0)
				{
				}
				this.alternateComparatorHostname_43797.Value = value;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600029D RID: 669 RVA: 0x00034C88 File Offset: 0x00032E88
		// (set) Token: 0x0600029E RID: 670 RVA: 0x00034D40 File Offset: 0x00032F40
		public bool AlternateComparatorHostname_43797_Applicable
		{
			get
			{
				short num = (short)1309416332;
				short num2 = num;
				num = (short)170335116;
				switch (num2 == num)
				{
				}
				num = (short)139526145;
				if (num != 0)
				{
				}
				num = (short)2130968576;
				short num3 = num;
				num = (short)1616314368;
				if (num != 0)
				{
				}
				return this.alternateComparatorHostname_43797.Applicable;
			}
			set
			{
				short num = (short)95331741;
				short num2 = num;
				num = (short)537044381;
				switch (num2 == num)
				{
				}
				num = (short)1301413888;
				if (num != 0)
				{
				}
				num = (short)540016640;
				short num3 = num;
				num = (short)2043936769;
				if (num != 0)
				{
				}
				this.alternateComparatorHostname_43797.Applicable = value;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600029F RID: 671 RVA: 0x00034DF8 File Offset: 0x00032FF8
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x00034EB0 File Offset: 0x000330B0
		public bool AlternateComparatorHostname_43797_Valid
		{
			get
			{
				short num = (short)1094123521;
				if (num != 0)
				{
				}
				num = (short)1861061940;
				short num2 = num;
				num = (short)763465012;
				switch (num2 == num)
				{
				}
				num = (short)550109184;
				short num3 = num;
				num = (short)831127552;
				if (num != 0)
				{
				}
				return this.alternateComparatorHostname_43797.Valid;
			}
			set
			{
				short num = (short)1218709104;
				short num2 = num;
				num = (short)925501040;
				switch (num2 == num)
				{
				}
				num = (short)713097217;
				if (num != 0)
				{
				}
				num = (short)1461714944;
				short num3 = num;
				num = (short)159121408;
				if (num != 0)
				{
				}
				this.alternateComparatorHostname_43797.Valid = value;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x00034F64 File Offset: 0x00033164
		// (set) Token: 0x060002A2 RID: 674 RVA: 0x00035018 File Offset: 0x00033218
		public bool AlternateComparatorHostname_43797_Visible
		{
			get
			{
				short num = (short)813918272;
				short num2 = num;
				num = (short)1984522304;
				switch (num2 == num)
				{
				}
				num = (short)1042874369;
				if (num != 0)
				{
				}
				num = (short)902365184;
				short num3 = num;
				num = (short)261226496;
				if (num != 0)
				{
				}
				return this.alternateComparatorHostname_43797.Visible;
			}
			set
			{
				short num = (short)1928271165;
				short num2 = num;
				num = (short)891753789;
				switch (num2 == num)
				{
				}
				num = (short)1407188992;
				if (num != 0)
				{
				}
				num = (short)383320064;
				short num3 = num;
				num = (short)1840775169;
				if (num != 0)
				{
				}
				this.alternateComparatorHostname_43797.Visible = value;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x000350D0 File Offset: 0x000332D0
		// (set) Token: 0x060002A4 RID: 676 RVA: 0x00035188 File Offset: 0x00033388
		public bool AlternateComparatorHostname_43797_Editable
		{
			get
			{
				short num = (short)1660402862;
				short num2 = num;
				num = (short)1500560558;
				switch (num2 == num)
				{
				}
				num = (short)260243457;
				if (num != 0)
				{
				}
				num = (short)962592768;
				short num3 = num;
				num = (short)507379712;
				if (num != 0)
				{
				}
				return this.alternateComparatorHostname_43797.Editable;
			}
			set
			{
				short num = (short)2089877889;
				short num2 = num;
				num = (short)817103233;
				switch (num2 == num)
				{
				}
				num = (short)1858863105;
				if (num != 0)
				{
				}
				num = (short)1225392128;
				short num3 = num;
				num = (short)1147731968;
				if (num != 0)
				{
				}
				this.alternateComparatorHostname_43797.Editable = value;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x00035240 File Offset: 0x00033440
		internal string AlternateComparatorHostname_43797_UILabel
		{
			get
			{
				short num = (short)1673096565;
				short num2 = num;
				num = (short)442527093;
				switch (num2 == num)
				{
				}
				num = (short)147914753;
				if (num != 0)
				{
				}
				num = (short)1847132160;
				short num3 = num;
				num = (short)785973248;
				if (num != 0)
				{
				}
				return this.alternateComparatorHostname_43797.UIName;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x000352F4 File Offset: 0x000334F4
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x000353A8 File Offset: 0x000335A8
		internal bool AlternateComparatorHostname_43797_HiddenStatic
		{
			get
			{
				short num = (short)1807341092;
				short num2 = num;
				num = (short)330946084;
				switch (num2 == num)
				{
				}
				num = (short)888602625;
				if (num != 0)
				{
				}
				num = (short)63700992;
				short num3 = num;
				num = (short)1430388736;
				if (num != 0)
				{
				}
				return this.alternateComparatorHostname_43797.HiddenStatic;
			}
			set
			{
				short num = (short)363858496;
				short num2 = num;
				num = (short)1012795968;
				switch (num2 == num)
				{
				}
				num = (short)284491776;
				if (num != 0)
				{
				}
				num = (short)722993152;
				short num3 = num;
				num = (short)199491585;
				if (num != 0)
				{
				}
				this.alternateComparatorHostname_43797.HiddenStatic = value;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x00035458 File Offset: 0x00033658
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x0003550C File Offset: 0x0003370C
		internal bool AlternateComparatorHostname_43797_HiddenDynamic
		{
			get
			{
				short num = (short)1856008233;
				short num2 = num;
				num = (short)542863401;
				switch (num2 == num)
				{
				}
				num = (short)1345257473;
				if (num != 0)
				{
				}
				num = (short)1850605568;
				short num3 = num;
				num = (short)292093952;
				if (num != 0)
				{
				}
				return this.alternateComparatorHostname_43797.HiddenDynamic;
			}
			set
			{
				short num = (short)1063659962;
				short num2 = num;
				num = (short)346368442;
				switch (num2 == num)
				{
				}
				num = (short)337707008;
				if (num != 0)
				{
				}
				num = (short)1376845824;
				short num3 = num;
				num = (short)885850113;
				if (num != 0)
				{
				}
				this.alternateComparatorHostname_43797.HiddenDynamic = value;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060002AA RID: 682 RVA: 0x000355C0 File Offset: 0x000337C0
		public bool AlternateComparatorHostname_43797_HasDiffs
		{
			get
			{
				short num = (short)404597676;
				short num2 = num;
				num = (short)365079468;
				switch (num2 == num)
				{
				}
				num = (short)1973813249;
				if (num != 0)
				{
				}
				num = (short)362283008;
				short num3 = num;
				num = (short)1368653824;
				if (num != 0)
				{
				}
				return this.alternateComparatorHostname_43797._HasDiffs;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060002AB RID: 683 RVA: 0x00035674 File Offset: 0x00033874
		// (set) Token: 0x060002AC RID: 684 RVA: 0x00035728 File Offset: 0x00033928
		public int MainComparatorDTLSPortNumber_43798Value
		{
			get
			{
				short num = (short)190757343;
				short num2 = num;
				num = (short)813873631;
				switch (num2 == num)
				{
				}
				num = (short)1230438401;
				if (num != 0)
				{
				}
				num = (short)1492058112;
				short num3 = num;
				num = (short)1748959232;
				if (num != 0)
				{
				}
				return this.mainComparatorDTLSPortNumber_43798.Value;
			}
			set
			{
				short num = (short)1621547578;
				short num2 = num;
				num = (short)672258618;
				switch (num2 == num)
				{
				}
				num = (short)367263745;
				if (num != 0)
				{
				}
				num = (short)1629487104;
				short num3 = num;
				num = (short)361758720;
				if (num != 0)
				{
				}
				this.mainComparatorDTLSPortNumber_43798.Value = value;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060002AD RID: 685 RVA: 0x000357E0 File Offset: 0x000339E0
		public global::AcpBusinessLayer.AcpSimpleRangeField MainComparatorDTLSPortNumber_43798
		{
			get
			{
				short num = (short)765485136;
				short num2 = num;
				num = (short)1221288016;
				switch (num2 == num)
				{
				}
				num = (short)1650524160;
				if (num != 0)
				{
				}
				num = (short)303562752;
				short num3 = num;
				num = (short)1211629569;
				if (num != 0)
				{
				}
				return this.mainComparatorDTLSPortNumber_43798;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060002AE RID: 686 RVA: 0x00035890 File Offset: 0x00033A90
		// (set) Token: 0x060002AF RID: 687 RVA: 0x00035944 File Offset: 0x00033B44
		public string MainComparatorDTLSPortNumber_43798_UIValue
		{
			get
			{
				short num = (short)1286455271;
				short num2 = num;
				num = (short)31244263;
				switch (num2 == num)
				{
				}
				num = (short)582156289;
				if (num != 0)
				{
				}
				num = (short)312213504;
				short num3 = num;
				num = (short)1601241088;
				if (num != 0)
				{
				}
				return this.mainComparatorDTLSPortNumber_43798.UIValue;
			}
			set
			{
				short num = (short)17720065;
				short num2 = num;
				num = (short)1527538433;
				switch (num2 == num)
				{
				}
				num = (short)24182784;
				if (num != 0)
				{
				}
				num = (short)670171136;
				short num3 = num;
				num = (short)900530177;
				if (num != 0)
				{
				}
				this.mainComparatorDTLSPortNumber_43798.UIValue = value;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x000359FC File Offset: 0x00033BFC
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x00035AB0 File Offset: 0x00033CB0
		internal int MainComparatorDTLSPortNumber_43798Min
		{
			get
			{
				short num = (short)76624019;
				short num2 = num;
				num = (short)603533459;
				switch (num2 == num)
				{
				}
				num = (short)871825409;
				if (num != 0)
				{
				}
				num = (short)662241280;
				short num3 = num;
				num = (short)1761017856;
				if (num != 0)
				{
				}
				return this.mainComparatorDTLSPortNumber_43798.Min;
			}
			set
			{
				short num = (short)1930478079;
				short num2 = num;
				num = (short)1200669183;
				switch (num2 == num)
				{
				}
				num = (short)1480392705;
				if (num != 0)
				{
				}
				num = (short)1569062912;
				short num3 = num;
				num = (short)601292800;
				if (num != 0)
				{
				}
				this.mainComparatorDTLSPortNumber_43798.Min = value;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x00035B60 File Offset: 0x00033D60
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x00035C14 File Offset: 0x00033E14
		internal int MainComparatorDTLSPortNumber_43798Max
		{
			get
			{
				short num = (short)2047344641;
				if (num != 0)
				{
				}
				num = (short)1479072140;
				short num2 = num;
				num = (short)1832901004;
				switch (num2 == num)
				{
				}
				num = (short)1442775040;
				short num3 = num;
				num = (short)1512243200;
				if (num != 0)
				{
				}
				return this.mainComparatorDTLSPortNumber_43798.Max;
			}
			set
			{
				short num = (short)1990590465;
				if (num != 0)
				{
				}
				num = (short)2065219624;
				short num2 = num;
				num = (short)1664335912;
				switch (num2 == num)
				{
				}
				num = (short)2026897408;
				short num3 = num;
				num = (short)1847721984;
				if (num != 0)
				{
				}
				this.mainComparatorDTLSPortNumber_43798.Max = value;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x00035CC8 File Offset: 0x00033EC8
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x00035D7C File Offset: 0x00033F7C
		internal int MainComparatorDTLSPortNumber_43798Step
		{
			get
			{
				short num = (short)248907925;
				short num2 = num;
				num = (short)1821771925;
				switch (num2 == num)
				{
				}
				num = (short)873529345;
				if (num != 0)
				{
				}
				num = (short)872546304;
				short num3 = num;
				num = (short)789577728;
				if (num != 0)
				{
				}
				return this.mainComparatorDTLSPortNumber_43798.StepSize;
			}
			set
			{
				short num = (short)280363648;
				short num2 = num;
				num = (short)1704395392;
				switch (num2 == num)
				{
				}
				num = (short)811270144;
				if (num != 0)
				{
				}
				num = (short)748945408;
				short num3 = num;
				num = (short)2104885249;
				if (num != 0)
				{
				}
				this.mainComparatorDTLSPortNumber_43798.StepSize = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x00035E30 File Offset: 0x00034030
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x00035EE4 File Offset: 0x000340E4
		public bool MainComparatorDTLSPortNumber_43798_Applicable
		{
			get
			{
				short num = (short)398573060;
				short num2 = num;
				num = (short)1650048516;
				switch (num2 == num)
				{
				}
				num = (short)2102001665;
				if (num != 0)
				{
				}
				num = (short)1470103552;
				short num3 = num;
				num = (short)500170752;
				if (num != 0)
				{
				}
				return this.mainComparatorDTLSPortNumber_43798.Applicable;
			}
			set
			{
				short num = (short)1189078864;
				short num2 = num;
				num = (short)1655826256;
				switch (num2 == num)
				{
				}
				num = (short)2061434881;
				if (num != 0)
				{
				}
				num = (short)125894656;
				short num3 = num;
				num = (short)1856110592;
				if (num != 0)
				{
				}
				this.mainComparatorDTLSPortNumber_43798.Applicable = value;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x00035F9C File Offset: 0x0003419C
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x00036050 File Offset: 0x00034250
		public bool MainComparatorDTLSPortNumber_43798_Valid
		{
			get
			{
				short num = (short)1895976950;
				short num2 = num;
				num = (short)1222529014;
				switch (num2 == num)
				{
				}
				num = (short)61997057;
				if (num != 0)
				{
				}
				num = (short)2025783296;
				short num3 = num;
				num = (short)163971072;
				if (num != 0)
				{
				}
				return this.mainComparatorDTLSPortNumber_43798.Valid;
			}
			set
			{
				short num = (short)1460226180;
				short num2 = num;
				num = (short)785205380;
				switch (num2 == num)
				{
				}
				num = (short)554696704;
				if (num != 0)
				{
				}
				num = (short)85262336;
				short num3 = num;
				num = (short)1879572481;
				if (num != 0)
				{
				}
				this.mainComparatorDTLSPortNumber_43798.Valid = value;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060002BA RID: 698 RVA: 0x00036108 File Offset: 0x00034308
		// (set) Token: 0x060002BB RID: 699 RVA: 0x000361BC File Offset: 0x000343BC
		public bool MainComparatorDTLSPortNumber_43798_Visible
		{
			get
			{
				short num = (short)869180684;
				short num2 = num;
				num = (short)494904588;
				switch (num2 == num)
				{
				}
				num = (short)1966342144;
				if (num != 0)
				{
				}
				num = (short)1976434688;
				short num3 = num;
				num = (short)1649344513;
				if (num != 0)
				{
				}
				return this.mainComparatorDTLSPortNumber_43798.Visible;
			}
			set
			{
				short num = (short)1016226883;
				short num2 = num;
				num = (short)1482384451;
				switch (num2 == num)
				{
				}
				num = (short)1154744321;
				if (num != 0)
				{
				}
				num = (short)1028063232;
				short num3 = num;
				num = (short)1634795520;
				if (num != 0)
				{
				}
				this.mainComparatorDTLSPortNumber_43798.Visible = value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060002BC RID: 700 RVA: 0x00036274 File Offset: 0x00034474
		// (set) Token: 0x060002BD RID: 701 RVA: 0x0003632C File Offset: 0x0003452C
		public bool MainComparatorDTLSPortNumber_43798_Editable
		{
			get
			{
				short num = (short)1446728932;
				short num2 = num;
				num = (short)1975276772;
				switch (num2 == num)
				{
				}
				num = (short)378535937;
				if (num != 0)
				{
				}
				num = (short)1999241216;
				short num3 = num;
				num = (short)948895744;
				if (num != 0)
				{
				}
				return this.mainComparatorDTLSPortNumber_43798.Editable;
			}
			set
			{
				short num = (short)2053929234;
				short num2 = num;
				num = (short)995457298;
				switch (num2 == num)
				{
				}
				num = (short)1594228737;
				if (num != 0)
				{
				}
				num = (short)2083979264;
				short num3 = num;
				num = (short)1105526784;
				if (num != 0)
				{
				}
				this.mainComparatorDTLSPortNumber_43798.Editable = value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060002BE RID: 702 RVA: 0x000363E4 File Offset: 0x000345E4
		internal string MainComparatorDTLSPortNumber_43798_UILabel
		{
			get
			{
				short num = (short)520859481;
				short num2 = num;
				num = (short)1775939417;
				switch (num2 == num)
				{
				}
				num = (short)40894465;
				if (num != 0)
				{
				}
				num = (short)512294912;
				short num3 = num;
				num = (short)1285160960;
				if (num != 0)
				{
				}
				return this.mainComparatorDTLSPortNumber_43798.UIName;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060002BF RID: 703 RVA: 0x00036498 File Offset: 0x00034698
		// (set) Token: 0x060002C0 RID: 704 RVA: 0x0003654C File Offset: 0x0003474C
		internal bool MainComparatorDTLSPortNumber_43798_HiddenStatic
		{
			get
			{
				short num = (short)894793249;
				short num2 = num;
				num = (short)1732539937;
				switch (num2 == num)
				{
				}
				num = (short)540999681;
				if (num != 0)
				{
				}
				num = (short)1088552960;
				short num3 = num;
				num = (short)283508736;
				if (num != 0)
				{
				}
				return this.mainComparatorDTLSPortNumber_43798.HiddenStatic;
			}
			set
			{
				short num = (short)814081638;
				short num2 = num;
				num = (short)1785194086;
				switch (num2 == num)
				{
				}
				num = (short)137691137;
				if (num != 0)
				{
				}
				num = (short)1931476992;
				short num3 = num;
				num = (short)1440481280;
				if (num != 0)
				{
				}
				this.mainComparatorDTLSPortNumber_43798.HiddenStatic = value;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060002C1 RID: 705 RVA: 0x00036604 File Offset: 0x00034804
		// (set) Token: 0x060002C2 RID: 706 RVA: 0x000366B8 File Offset: 0x000348B8
		internal bool MainComparatorDTLSPortNumber_43798_HiddenDynamic
		{
			get
			{
				short num = (short)1059551996;
				short num2 = num;
				num = (short)1802795772;
				switch (num2 == num)
				{
				}
				num = (short)1066729472;
				if (num != 0)
				{
				}
				num = (short)2142633984;
				short num3 = num;
				num = (short)1537015809;
				if (num != 0)
				{
				}
				return this.mainComparatorDTLSPortNumber_43798.HiddenDynamic;
			}
			set
			{
				short num = (short)1041740221;
				short num2 = num;
				num = (short)95138237;
				switch (num2 == num)
				{
				}
				num = (short)196149249;
				if (num != 0)
				{
				}
				num = (short)1160642560;
				short num3 = num;
				num = (short)397737984;
				if (num != 0)
				{
				}
				this.mainComparatorDTLSPortNumber_43798.HiddenDynamic = value;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060002C3 RID: 707 RVA: 0x00036770 File Offset: 0x00034970
		public bool MainComparatorDTLSPortNumber_43798_HasDiffs
		{
			get
			{
				short num = (short)473172709;
				short num2 = num;
				num = (short)133630693;
				switch (num2 == num)
				{
				}
				num = (short)20250624;
				if (num != 0)
				{
				}
				num = (short)542638080;
				short num3 = num;
				num = (short)898367489;
				if (num != 0)
				{
				}
				return this.mainComparatorDTLSPortNumber_43798._HasDiffs;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x00036828 File Offset: 0x00034A28
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x000368DC File Offset: 0x00034ADC
		public int AlternateComparatorDTLSPortNumber_43801Value
		{
			get
			{
				short num = (short)278870604;
				short num2 = num;
				num = (short)534526540;
				switch (num2 == num)
				{
				}
				num = (short)1585577985;
				if (num != 0)
				{
				}
				num = (short)1764032512;
				short num3 = num;
				num = (short)1487405056;
				if (num != 0)
				{
				}
				return this.alternateComparatorDTLSPortNumber_43801.Value;
			}
			set
			{
				short num = (short)590779380;
				short num2 = num;
				num = (short)395416564;
				switch (num2 == num)
				{
				}
				num = (short)931790848;
				if (num != 0)
				{
				}
				num = (short)1817640960;
				short num3 = num;
				num = (short)491323393;
				if (num != 0)
				{
				}
				this.alternateComparatorDTLSPortNumber_43801.Value = value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x00036990 File Offset: 0x00034B90
		public global::AcpBusinessLayer.AcpSimpleRangeField AlternateComparatorDTLSPortNumber_43801
		{
			get
			{
				short num = (short)966261284;
				short num2 = num;
				num = (short)1599863332;
				switch (num2 == num)
				{
				}
				num = (short)967639040;
				if (num != 0)
				{
				}
				num = (short)422248448;
				short num3 = num;
				num = (short)576389121;
				if (num != 0)
				{
				}
				return this.alternateComparatorDTLSPortNumber_43801;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060002C7 RID: 711 RVA: 0x00036A40 File Offset: 0x00034C40
		// (set) Token: 0x060002C8 RID: 712 RVA: 0x00036AF0 File Offset: 0x00034CF0
		public string AlternateComparatorDTLSPortNumber_43801_UIValue
		{
			get
			{
				short num = (short)2020613781;
				short num2 = num;
				num = (short)1774198421;
				switch (num2 == num)
				{
				}
				num = (short)1492779009;
				if (num != 0)
				{
				}
				num = (short)1939537920;
				short num3 = num;
				num = (short)1344798720;
				if (num != 0)
				{
				}
				return this.alternateComparatorDTLSPortNumber_43801.UIValue;
			}
			set
			{
				short num = (short)1894691170;
				short num2 = num;
				num = (short)8368482;
				switch (num2 == num)
				{
				}
				num = (short)2043281409;
				if (num != 0)
				{
				}
				num = (short)1430913024;
				short num3 = num;
				num = (short)192806912;
				if (num != 0)
				{
				}
				this.alternateComparatorDTLSPortNumber_43801.UIValue = value;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060002C9 RID: 713 RVA: 0x00036BA8 File Offset: 0x00034DA8
		// (set) Token: 0x060002CA RID: 714 RVA: 0x00036C5C File Offset: 0x00034E5C
		internal int AlternateComparatorDTLSPortNumber_43801Min
		{
			get
			{
				short num = (short)1099497473;
				if (num != 0)
				{
				}
				num = (short)2064649872;
				short num2 = num;
				num = (short)1400704656;
				switch (num2 == num)
				{
				}
				num = (short)2062483456;
				short num3 = num;
				num = (short)805240832;
				if (num != 0)
				{
				}
				return this.alternateComparatorDTLSPortNumber_43801.Min;
			}
			set
			{
				short num = (short)413922911;
				short num2 = num;
				num = (short)1368061535;
				switch (num2 == num)
				{
				}
				num = (short)2001993728;
				if (num != 0)
				{
				}
				num = (short)484114432;
				short num3 = num;
				num = (short)486604801;
				if (num != 0)
				{
				}
				this.alternateComparatorDTLSPortNumber_43801.Min = value;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060002CB RID: 715 RVA: 0x00036D10 File Offset: 0x00034F10
		// (set) Token: 0x060002CC RID: 716 RVA: 0x00036DC8 File Offset: 0x00034FC8
		internal int AlternateComparatorDTLSPortNumber_43801Max
		{
			get
			{
				short num = (short)1755289054;
				short num2 = num;
				num = (short)1318032862;
				switch (num2 == num)
				{
				}
				num = (short)1079115776;
				if (num != 0)
				{
				}
				num = (short)1025572864;
				short num3 = num;
				num = (short)2060845057;
				if (num != 0)
				{
				}
				return this.alternateComparatorDTLSPortNumber_43801.Max;
			}
			set
			{
				short num = (short)1760210699;
				short num2 = num;
				num = (short)1035054859;
				switch (num2 == num)
				{
				}
				num = (short)1408761857;
				if (num != 0)
				{
				}
				num = (short)1875574784;
				short num3 = num;
				num = (short)1415577600;
				if (num != 0)
				{
				}
				this.alternateComparatorDTLSPortNumber_43801.Max = value;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060002CD RID: 717 RVA: 0x00036E7C File Offset: 0x0003507C
		// (set) Token: 0x060002CE RID: 718 RVA: 0x00036F34 File Offset: 0x00035134
		internal int AlternateComparatorDTLSPortNumber_43801Step
		{
			get
			{
				short num = (short)2083586049;
				if (num != 0)
				{
				}
				num = (short)827539720;
				short num2 = num;
				num = (short)990069000;
				switch (num2 == num)
				{
				}
				num = (short)1499201536;
				short num3 = num;
				num = (short)1529872384;
				if (num != 0)
				{
				}
				return this.alternateComparatorDTLSPortNumber_43801.StepSize;
			}
			set
			{
				short num = (short)512098305;
				if (num != 0)
				{
				}
				num = (short)296810925;
				short num2 = num;
				num = (short)676723117;
				switch (num2 == num)
				{
				}
				num = (short)1506213888;
				short num3 = num;
				num = (short)220004352;
				if (num != 0)
				{
				}
				this.alternateComparatorDTLSPortNumber_43801.StepSize = value;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060002CF RID: 719 RVA: 0x00036FE8 File Offset: 0x000351E8
		// (set) Token: 0x060002D0 RID: 720 RVA: 0x0003709C File Offset: 0x0003529C
		public bool AlternateComparatorDTLSPortNumber_43801_Applicable
		{
			get
			{
				short num = (short)360462207;
				short num2 = num;
				num = (short)31471487;
				switch (num2 == num)
				{
				}
				num = (short)2022506497;
				if (num != 0)
				{
				}
				num = (short)1530986496;
				short num3 = num;
				num = (short)1432616960;
				if (num != 0)
				{
				}
				return this.alternateComparatorDTLSPortNumber_43801.Applicable;
			}
			set
			{
				short num = (short)1503905706;
				short num2 = num;
				num = (short)308987818;
				switch (num2 == num)
				{
				}
				num = (short)2003304448;
				if (num != 0)
				{
				}
				num = (short)961937408;
				short num3 = num;
				num = (short)759758849;
				if (num != 0)
				{
				}
				this.alternateComparatorDTLSPortNumber_43801.Applicable = value;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x00037150 File Offset: 0x00035350
		// (set) Token: 0x060002D2 RID: 722 RVA: 0x00037204 File Offset: 0x00035404
		public bool AlternateComparatorDTLSPortNumber_43801_Valid
		{
			get
			{
				short num = (short)601171342;
				short num2 = num;
				num = (short)1742677390;
				switch (num2 == num)
				{
				}
				num = (short)1890648065;
				if (num != 0)
				{
				}
				num = (short)1089929216;
				short num3 = num;
				num = (short)710279168;
				if (num != 0)
				{
				}
				return this.alternateComparatorDTLSPortNumber_43801.Valid;
			}
			set
			{
				short num = (short)759955457;
				if (num != 0)
				{
				}
				num = (short)115119811;
				short num2 = num;
				num = (short)1313904323;
				switch (num2 == num)
				{
				}
				num = (short)1576665088;
				short num3 = num;
				num = (short)1799553024;
				if (num != 0)
				{
				}
				this.alternateComparatorDTLSPortNumber_43801.Valid = value;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060002D3 RID: 723 RVA: 0x000372BC File Offset: 0x000354BC
		// (set) Token: 0x060002D4 RID: 724 RVA: 0x00037374 File Offset: 0x00035574
		public bool AlternateComparatorDTLSPortNumber_43801_Visible
		{
			get
			{
				short num = (short)1843579242;
				short num2 = num;
				num = (short)1697958250;
				switch (num2 == num)
				{
				}
				num = (short)765591552;
				if (num != 0)
				{
				}
				num = (short)1424556032;
				short num3 = num;
				num = (short)1064042497;
				if (num != 0)
				{
				}
				return this.alternateComparatorDTLSPortNumber_43801.Visible;
			}
			set
			{
				short num = (short)1202078208;
				short num2 = num;
				num = (short)1891779072;
				switch (num2 == num)
				{
				}
				num = (short)350617601;
				if (num != 0)
				{
				}
				num = (short)1129185280;
				short num3 = num;
				num = (short)1440219136;
				if (num != 0)
				{
				}
				this.alternateComparatorDTLSPortNumber_43801.Visible = value;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060002D5 RID: 725 RVA: 0x00037428 File Offset: 0x00035628
		// (set) Token: 0x060002D6 RID: 726 RVA: 0x000374DC File Offset: 0x000356DC
		public bool AlternateComparatorDTLSPortNumber_43801_Editable
		{
			get
			{
				short num = (short)211936628;
				short num2 = num;
				num = (short)1967252852;
				switch (num2 == num)
				{
				}
				num = (short)1093730304;
				if (num != 0)
				{
				}
				num = (short)2066153472;
				short num3 = num;
				num = (short)891617281;
				if (num != 0)
				{
				}
				return this.alternateComparatorDTLSPortNumber_43801.Editable;
			}
			set
			{
				short num = (short)1633715359;
				short num2 = num;
				num = (short)960005279;
				switch (num2 == num)
				{
				}
				num = (short)767623169;
				if (num != 0)
				{
				}
				num = (short)687144960;
				short num3 = num;
				num = (short)942080000;
				if (num != 0)
				{
				}
				this.alternateComparatorDTLSPortNumber_43801.Editable = value;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060002D7 RID: 727 RVA: 0x00037590 File Offset: 0x00035790
		internal string AlternateComparatorDTLSPortNumber_43801_UILabel
		{
			get
			{
				short num = (short)952239087;
				short num2 = num;
				num = (short)1722418159;
				switch (num2 == num)
				{
				}
				num = (short)1534001153;
				if (num != 0)
				{
				}
				num = (short)1709703168;
				short num3 = num;
				num = (short)412680192;
				if (num != 0)
				{
				}
				return this.alternateComparatorDTLSPortNumber_43801.UIName;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x00037644 File Offset: 0x00035844
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x000376FC File Offset: 0x000358FC
		internal bool AlternateComparatorDTLSPortNumber_43801_HiddenStatic
		{
			get
			{
				short num = (short)1355721275;
				short num2 = num;
				num = (short)1414834747;
				switch (num2 == num)
				{
				}
				num = (short)1604583425;
				if (num != 0)
				{
				}
				num = (short)1813839872;
				short num3 = num;
				num = (short)1330970624;
				if (num != 0)
				{
				}
				return this.alternateComparatorDTLSPortNumber_43801.HiddenStatic;
			}
			set
			{
				short num = (short)1227369964;
				short num2 = num;
				num = (short)1930767852;
				switch (num2 == num)
				{
				}
				num = (short)1326317569;
				if (num != 0)
				{
				}
				num = (short)18481152;
				short num3 = num;
				num = (short)1789329408;
				if (num != 0)
				{
				}
				this.alternateComparatorDTLSPortNumber_43801.HiddenStatic = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060002DA RID: 730 RVA: 0x000377B0 File Offset: 0x000359B0
		// (set) Token: 0x060002DB RID: 731 RVA: 0x00037864 File Offset: 0x00035A64
		internal bool AlternateComparatorDTLSPortNumber_43801_HiddenDynamic
		{
			get
			{
				short num = (short)903965880;
				short num2 = num;
				num = (short)848653496;
				switch (num2 == num)
				{
				}
				num = (short)2006843393;
				if (num != 0)
				{
				}
				num = (short)1200357376;
				short num3 = num;
				num = (short)1860829184;
				if (num != 0)
				{
				}
				return this.alternateComparatorDTLSPortNumber_43801.HiddenDynamic;
			}
			set
			{
				short num = (short)1003731196;
				short num2 = num;
				num = (short)5028092;
				switch (num2 == num)
				{
				}
				num = (short)569966593;
				if (num != 0)
				{
				}
				num = (short)848822272;
				short num3 = num;
				num = (short)83755008;
				if (num != 0)
				{
				}
				this.alternateComparatorDTLSPortNumber_43801.HiddenDynamic = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060002DC RID: 732 RVA: 0x00037918 File Offset: 0x00035B18
		public bool AlternateComparatorDTLSPortNumber_43801_HasDiffs
		{
			get
			{
				short num = (short)158582889;
				short num2 = num;
				num = (short)328714345;
				switch (num2 == num)
				{
				}
				num = (short)1491009537;
				if (num != 0)
				{
				}
				num = (short)888537088;
				short num3 = num;
				num = (short)553385984;
				if (num != 0)
				{
				}
				return this.alternateComparatorDTLSPortNumber_43801._HasDiffs;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060002DD RID: 733 RVA: 0x000379D0 File Offset: 0x00035BD0
		// (set) Token: 0x060002DE RID: 734 RVA: 0x00037A84 File Offset: 0x00035C84
		public int ComparatorChannelNumber_43800Value
		{
			get
			{
				short num = (short)1734242785;
				short num2 = num;
				num = (short)1131966945;
				switch (num2 == num)
				{
				}
				num = (short)323158016;
				if (num != 0)
				{
				}
				num = (short)997392384;
				short num3 = num;
				num = (short)1238761473;
				if (num != 0)
				{
				}
				return this.comparatorChannelNumber_43800.Value;
			}
			set
			{
				short num = (short)478655835;
				short num2 = num;
				num = (short)344831323;
				switch (num2 == num)
				{
				}
				num = (short)1770520577;
				if (num != 0)
				{
				}
				num = (short)1104871424;
				short num3 = num;
				num = (short)2005663744;
				if (num != 0)
				{
				}
				this.comparatorChannelNumber_43800.Value = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060002DF RID: 735 RVA: 0x00037B3C File Offset: 0x00035D3C
		public global::AcpBusinessLayer.AcpSimpleRangeField ComparatorChannelNumber_43800
		{
			get
			{
				short num = (short)2070935319;
				short num2 = num;
				num = (short)542439191;
				switch (num2 == num)
				{
				}
				num = (short)1494155265;
				if (num != 0)
				{
				}
				num = (short)2129395712;
				short num3 = num;
				num = (short)57212928;
				if (num != 0)
				{
				}
				return this.comparatorChannelNumber_43800;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x00037BEC File Offset: 0x00035DEC
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x00037CA4 File Offset: 0x00035EA4
		public string ComparatorChannelNumber_43800_UIValue
		{
			get
			{
				short num = (short)1805417056;
				short num2 = num;
				num = (short)454785632;
				switch (num2 == num)
				{
				}
				num = (short)1608974337;
				if (num != 0)
				{
				}
				num = (short)996016128;
				short num3 = num;
				num = (short)861798400;
				if (num != 0)
				{
				}
				return this.comparatorChannelNumber_43800.UIValue;
			}
			set
			{
				short num = (short)1859663243;
				short num2 = num;
				num = (short)1790326155;
				switch (num2 == num)
				{
				}
				num = (short)729874432;
				if (num != 0)
				{
				}
				num = (short)1681915904;
				short num3 = num;
				num = (short)514129921;
				if (num != 0)
				{
				}
				this.comparatorChannelNumber_43800.UIValue = value;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x00037D58 File Offset: 0x00035F58
		// (set) Token: 0x060002E3 RID: 739 RVA: 0x00037E0C File Offset: 0x0003600C
		internal int ComparatorChannelNumber_43800Min
		{
			get
			{
				short num = (short)307549049;
				short num2 = num;
				num = (short)1334629241;
				switch (num2 == num)
				{
				}
				num = (short)499187712;
				if (num != 0)
				{
				}
				num = (short)1592459264;
				short num3 = num;
				num = (short)1582432257;
				if (num != 0)
				{
				}
				return this.comparatorChannelNumber_43800.Min;
			}
			set
			{
				short num = (short)1694523197;
				short num2 = num;
				num = (short)1360158525;
				switch (num2 == num)
				{
				}
				num = (short)1443627009;
				if (num != 0)
				{
				}
				num = (short)1032847360;
				short num3 = num;
				num = (short)1559363584;
				if (num != 0)
				{
				}
				this.comparatorChannelNumber_43800.Min = value;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x00037EC0 File Offset: 0x000360C0
		// (set) Token: 0x060002E5 RID: 741 RVA: 0x00037F70 File Offset: 0x00036170
		internal int ComparatorChannelNumber_43800Max
		{
			get
			{
				short num = (short)290827923;
				short num2 = num;
				num = (short)648326803;
				switch (num2 == num)
				{
				}
				num = (short)22806529;
				if (num != 0)
				{
				}
				num = (short)362545152;
				short num3 = num;
				num = (short)1190985728;
				if (num != 0)
				{
				}
				return this.comparatorChannelNumber_43800.Max;
			}
			set
			{
				short num = (short)521909506;
				short num2 = num;
				num = (short)1072936194;
				switch (num2 == num)
				{
				}
				num = (short)995622912;
				if (num != 0)
				{
				}
				num = (short)1849425920;
				short num3 = num;
				num = (short)602013697;
				if (num != 0)
				{
				}
				this.comparatorChannelNumber_43800.Max = value;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x00038024 File Offset: 0x00036224
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x000380D8 File Offset: 0x000362D8
		internal int ComparatorChannelNumber_43800Step
		{
			get
			{
				short num = (short)1069820084;
				short num2 = num;
				num = (short)958802100;
				switch (num2 == num)
				{
				}
				num = (short)247726081;
				if (num != 0)
				{
				}
				num = (short)2116091904;
				short num3 = num;
				num = (short)455606272;
				if (num != 0)
				{
				}
				return this.comparatorChannelNumber_43800.StepSize;
			}
			set
			{
				short num = (short)1917164702;
				short num2 = num;
				num = (short)588094622;
				switch (num2 == num)
				{
				}
				num = (short)1233190913;
				if (num != 0)
				{
				}
				num = (short)827654144;
				short num3 = num;
				num = (short)1740242944;
				if (num != 0)
				{
				}
				this.comparatorChannelNumber_43800.StepSize = value;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x0003818C File Offset: 0x0003638C
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x00038244 File Offset: 0x00036444
		public bool ComparatorChannelNumber_43800_Applicable
		{
			get
			{
				short num = (short)498190298;
				short num2 = num;
				num = (short)437110746;
				switch (num2 == num)
				{
				}
				num = (short)2106654721;
				if (num != 0)
				{
				}
				num = (short)705101824;
				short num3 = num;
				num = (short)571015168;
				if (num != 0)
				{
				}
				return this.comparatorChannelNumber_43800.Applicable;
			}
			set
			{
				short num = (short)2025783296;
				short num2 = num;
				num = (short)1128315638;
				short num3 = num;
				num = (short)1615248118;
				switch (num3 == num)
				{
				}
				num = (short)1108672513;
				if (num != 0)
				{
				}
				num = (short)2129985536;
				if (num != 0)
				{
				}
				this.comparatorChannelNumber_43800.Applicable = value;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x060002EA RID: 746 RVA: 0x000382FC File Offset: 0x000364FC
		// (set) Token: 0x060002EB RID: 747 RVA: 0x000383B0 File Offset: 0x000365B0
		public bool ComparatorChannelNumber_43800_Valid
		{
			get
			{
				short num = (short)1896677376;
				short num2 = num;
				num = (short)1228672710;
				short num3 = num;
				num = (short)1233260230;
				switch (num3 == num)
				{
				}
				num = (short)491323392;
				if (num != 0)
				{
				}
				num = (short)1603207169;
				if (num != 0)
				{
				}
				return this.comparatorChannelNumber_43800.Valid;
			}
			set
			{
				short num = (short)553320448;
				short num2 = num;
				num = (short)543947268;
				short num3 = num;
				num = (short)491649540;
				switch (num3 == num)
				{
				}
				num = (short)551092225;
				if (num != 0)
				{
				}
				num = (short)918224896;
				if (num != 0)
				{
				}
				this.comparatorChannelNumber_43800.Valid = value;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x060002EC RID: 748 RVA: 0x00038468 File Offset: 0x00036668
		// (set) Token: 0x060002ED RID: 749 RVA: 0x0003851C File Offset: 0x0003671C
		public bool ComparatorChannelNumber_43800_Visible
		{
			get
			{
				short num = (short)2037514240;
				short num2 = num;
				num = (short)2088700961;
				short num3 = num;
				num = (short)138546209;
				switch (num3 == num)
				{
				}
				num = (short)79822849;
				if (num != 0)
				{
				}
				num = (short)488505344;
				if (num != 0)
				{
				}
				return this.comparatorChannelNumber_43800.Visible;
			}
			set
			{
				short num = (short)151191552;
				short num2 = num;
				num = (short)1619798053;
				short num3 = num;
				num = (short)1319512101;
				switch (num3 == num)
				{
				}
				num = (short)1067515905;
				if (num != 0)
				{
				}
				num = (short)540278784;
				if (num != 0)
				{
				}
				this.comparatorChannelNumber_43800.Visible = value;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060002EE RID: 750 RVA: 0x000385D4 File Offset: 0x000367D4
		// (set) Token: 0x060002EF RID: 751 RVA: 0x00038688 File Offset: 0x00036888
		public bool ComparatorChannelNumber_43800_Editable
		{
			get
			{
				short num = (short)1314062336;
				short num2 = num;
				num = (short)589248581;
				short num3 = num;
				num = (short)873609285;
				switch (num3 == num)
				{
				}
				num = (short)1059389441;
				if (num != 0)
				{
				}
				num = (short)226754560;
				if (num != 0)
				{
				}
				return this.comparatorChannelNumber_43800.Editable;
			}
			set
			{
				short num = (short)608567296;
				short num2 = num;
				num = (short)1941311213;
				short num3 = num;
				num = (short)584584941;
				switch (num3 == num)
				{
				}
				num = (short)335544321;
				if (num != 0)
				{
				}
				num = (short)919207936;
				if (num != 0)
				{
				}
				this.comparatorChannelNumber_43800.Editable = value;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x00038740 File Offset: 0x00036940
		internal string ComparatorChannelNumber_43800_UILabel
		{
			get
			{
				short num = (short)2067595264;
				short num2 = num;
				num = (short)1044008663;
				short num3 = num;
				num = (short)1193037527;
				switch (num3 == num)
				{
				}
				num = (short)2038628352;
				if (num != 0)
				{
				}
				num = (short)316342273;
				if (num != 0)
				{
				}
				return this.comparatorChannelNumber_43800.UIName;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x000387F0 File Offset: 0x000369F0
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x000388A4 File Offset: 0x00036AA4
		internal bool ComparatorChannelNumber_43800_HiddenStatic
		{
			get
			{
				short num = (short)368640000;
				short num2 = num;
				num = (short)863268237;
				short num3 = num;
				num = (short)692350349;
				switch (num3 == num)
				{
				}
				num = (short)756350977;
				if (num != 0)
				{
				}
				num = (short)955252736;
				if (num != 0)
				{
				}
				return this.comparatorChannelNumber_43800.HiddenStatic;
			}
			set
			{
				short num = (short)1744896000;
				short num2 = num;
				num = (short)177118360;
				short num3 = num;
				num = (short)2085002392;
				switch (num3 == num)
				{
				}
				num = (short)952434689;
				if (num != 0)
				{
				}
				num = (short)769654784;
				if (num != 0)
				{
				}
				this.comparatorChannelNumber_43800.HiddenStatic = value;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x00038958 File Offset: 0x00036B58
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x00038A0C File Offset: 0x00036C0C
		internal bool ComparatorChannelNumber_43800_HiddenDynamic
		{
			get
			{
				short num = (short)1880489984;
				short num2 = num;
				num = (short)1146695509;
				short num3 = num;
				num = (short)459550549;
				switch (num3 == num)
				{
				}
				num = (short)132317184;
				if (num != 0)
				{
				}
				num = (short)978780161;
				if (num != 0)
				{
				}
				return this.comparatorChannelNumber_43800.HiddenDynamic;
			}
			set
			{
				short num = (short)285999104;
				short num2 = num;
				num = (short)103342671;
				short num3 = num;
				num = (short)2089017935;
				switch (num3 == num)
				{
				}
				num = (short)1036451841;
				if (num != 0)
				{
				}
				num = (short)290521088;
				if (num != 0)
				{
				}
				this.comparatorChannelNumber_43800.HiddenDynamic = value;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x00038AC0 File Offset: 0x00036CC0
		public bool ComparatorChannelNumber_43800_HasDiffs
		{
			get
			{
				short num = (short)1727987712;
				short num2 = num;
				num = (short)1685382638;
				short num3 = num;
				num = (short)1293084142;
				switch (num3 == num)
				{
				}
				num = (short)1709375489;
				if (num != 0)
				{
				}
				num = (short)1616183296;
				if (num != 0)
				{
				}
				return this.comparatorChannelNumber_43800._HasDiffs;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x00038B74 File Offset: 0x00036D74
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x00038C28 File Offset: 0x00036E28
		public bool ZoneChannelAssignmentRSITransmitIndication_A41834Value
		{
			get
			{
				short num = (short)446169088;
				short num2 = num;
				num = (short)892351521;
				short num3 = num;
				num = (short)308360225;
				switch (num3 == num)
				{
				}
				num = (short)724762625;
				if (num != 0)
				{
				}
				num = (short)1294598144;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSITransmitIndication_A41834.Value;
			}
			set
			{
				short num = (short)118030336;
				short num2 = num;
				num = (short)465240305;
				short num3 = num;
				num = (short)1787494641;
				switch (num3 == num)
				{
				}
				num = (short)204472320;
				if (num != 0)
				{
				}
				num = (short)1428357121;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSITransmitIndication_A41834.Value = value;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x00038CDC File Offset: 0x00036EDC
		public global::AcpBusinessLayer.AcpField<bool> ZoneChannelAssignmentRSITransmitIndication_A41834
		{
			get
			{
				short num = (short)1819344896;
				short num2 = num;
				num = (short)1093989981;
				short num3 = num;
				num = (short)513472093;
				switch (num3 == num)
				{
				}
				num = (short)1052639233;
				if (num != 0)
				{
				}
				num = (short)955318272;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSITransmitIndication_A41834;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x00038D8C File Offset: 0x00036F8C
		// (set) Token: 0x060002FA RID: 762 RVA: 0x00038E44 File Offset: 0x00037044
		public bool ZoneChannelAssignmentRSITransmitIndication_A41834_UIValue
		{
			get
			{
				short num = (short)950206464;
				short num2 = num;
				num = (short)1243786701;
				short num3 = num;
				num = (short)1555279309;
				switch (num3 == num)
				{
				}
				num = (short)950992897;
				if (num != 0)
				{
				}
				num = (short)845676544;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSITransmitIndication_A41834.Value;
			}
			set
			{
				short num = (short)266665984;
				short num2 = num;
				num = (short)993484969;
				short num3 = num;
				num = (short)2105041065;
				switch (num3 == num)
				{
				}
				num = (short)491847681;
				if (num != 0)
				{
				}
				num = (short)749010944;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSITransmitIndication_A41834.Value = value;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060002FB RID: 763 RVA: 0x00038EF8 File Offset: 0x000370F8
		// (set) Token: 0x060002FC RID: 764 RVA: 0x00038FA8 File Offset: 0x000371A8
		public bool ZoneChannelAssignmentRSITransmitIndication_A41834_Applicable
		{
			get
			{
				short num = (short)1079508992;
				short num2 = num;
				num = (short)1456933984;
				short num3 = num;
				num = (short)1400900704;
				switch (num3 == num)
				{
				}
				num = (short)2086993921;
				if (num != 0)
				{
				}
				num = (short)511574016;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSITransmitIndication_A41834.Applicable;
			}
			set
			{
				short num = (short)1515454464;
				short num2 = num;
				num = (short)1018570555;
				short num3 = num;
				num = (short)478422843;
				switch (num3 == num)
				{
				}
				num = (short)68747265;
				if (num != 0)
				{
				}
				num = (short)800784384;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSITransmitIndication_A41834.Applicable = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060002FD RID: 765 RVA: 0x0003905C File Offset: 0x0003725C
		// (set) Token: 0x060002FE RID: 766 RVA: 0x00039110 File Offset: 0x00037310
		public bool ZoneChannelAssignmentRSITransmitIndication_A41834_Valid
		{
			get
			{
				short num = (short)146669568;
				short num2 = num;
				num = (short)1049444648;
				short num3 = num;
				num = (short)842285352;
				switch (num3 == num)
				{
				}
				num = (short)801243137;
				if (num != 0)
				{
				}
				num = (short)1283522560;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSITransmitIndication_A41834.Valid;
			}
			set
			{
				short num = (short)1544617984;
				short num2 = num;
				num = (short)1526552108;
				short num3 = num;
				num = (short)1875334700;
				switch (num3 == num)
				{
				}
				num = (short)6488064;
				if (num != 0)
				{
				}
				num = (short)1410924545;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSITransmitIndication_A41834.Valid = value;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060002FF RID: 767 RVA: 0x000391C4 File Offset: 0x000373C4
		// (set) Token: 0x06000300 RID: 768 RVA: 0x00039278 File Offset: 0x00037478
		public bool ZoneChannelAssignmentRSITransmitIndication_A41834_Visible
		{
			get
			{
				short num = (short)714080256;
				short num2 = num;
				num = (short)559759233;
				short num3 = num;
				num = (short)2020360065;
				switch (num3 == num)
				{
				}
				num = (short)1551892481;
				if (num != 0)
				{
				}
				num = (short)1989607424;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSITransmitIndication_A41834.Visible;
			}
			set
			{
				short num = (short)980680704;
				short num2 = num;
				num = (short)879253812;
				short num3 = num;
				num = (short)114383156;
				switch (num3 == num)
				{
				}
				num = (short)1163722753;
				if (num != 0)
				{
				}
				num = (short)97386496;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSITransmitIndication_A41834.Visible = value;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000301 RID: 769 RVA: 0x00039330 File Offset: 0x00037530
		// (set) Token: 0x06000302 RID: 770 RVA: 0x000393E4 File Offset: 0x000375E4
		public bool ZoneChannelAssignmentRSITransmitIndication_A41834_Editable
		{
			get
			{
				short num = (short)707198976;
				short num2 = num;
				num = (short)851705671;
				short num3 = num;
				num = (short)1043070791;
				switch (num3 == num)
				{
				}
				num = (short)1122762753;
				if (num != 0)
				{
				}
				num = (short)2057633792;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSITransmitIndication_A41834.Editable;
			}
			set
			{
				short num = (short)1998061568;
				short num2 = num;
				num = (short)1917983614;
				short num3 = num;
				num = (short)1430723454;
				switch (num3 == num)
				{
				}
				num = (short)947060737;
				if (num != 0)
				{
				}
				num = (short)2044395520;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSITransmitIndication_A41834.Editable = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x06000303 RID: 771 RVA: 0x00039498 File Offset: 0x00037698
		internal string ZoneChannelAssignmentRSITransmitIndication_A41834_UILabel
		{
			get
			{
				short num = (short)1149042688;
				short num2 = num;
				num = (short)212105600;
				short num3 = num;
				num = (short)797079936;
				switch (num3 == num)
				{
				}
				num = (short)1435172865;
				if (num != 0)
				{
				}
				num = (short)1578172416;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSITransmitIndication_A41834.UIName;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000304 RID: 772 RVA: 0x0003954C File Offset: 0x0003774C
		// (set) Token: 0x06000305 RID: 773 RVA: 0x00039600 File Offset: 0x00037800
		internal bool ZoneChannelAssignmentRSITransmitIndication_A41834_HiddenStatic
		{
			get
			{
				short num = (short)475136000;
				short num2 = num;
				num = (short)1300234241;
				if (num != 0)
				{
				}
				num = (short)1967680911;
				short num3 = num;
				num = (short)1866296719;
				switch (num3 == num)
				{
				}
				num = (short)439353344;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSITransmitIndication_A41834.HiddenStatic;
			}
			set
			{
				short num = (short)1485963264;
				short num2 = num;
				num = (short)1715051120;
				short num3 = num;
				num = (short)1996790384;
				switch (num3 == num)
				{
				}
				num = (short)1888092161;
				if (num != 0)
				{
				}
				num = (short)1028653056;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSITransmitIndication_A41834.HiddenStatic = value;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000306 RID: 774 RVA: 0x000396B4 File Offset: 0x000378B4
		// (set) Token: 0x06000307 RID: 775 RVA: 0x00039768 File Offset: 0x00037968
		internal bool ZoneChannelAssignmentRSITransmitIndication_A41834_HiddenDynamic
		{
			get
			{
				short num = (short)1390936064;
				short num2 = num;
				num = (short)1496842241;
				if (num != 0)
				{
				}
				num = (short)1860667627;
				short num3 = num;
				num = (short)501582059;
				switch (num3 == num)
				{
				}
				num = (short)561250304;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSITransmitIndication_A41834.HiddenDynamic;
			}
			set
			{
				short num = (short)82640896;
				short num2 = num;
				num = (short)2057895937;
				if (num != 0)
				{
				}
				num = (short)33690280;
				short num3 = num;
				num = (short)953291432;
				switch (num3 == num)
				{
				}
				num = (short)126943232;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSITransmitIndication_A41834.HiddenDynamic = value;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000308 RID: 776 RVA: 0x0003981C File Offset: 0x00037A1C
		public bool ZoneChannelAssignmentRSITransmitIndication_A41834_HasDiffs
		{
			get
			{
				short num = (short)695074816;
				short num2 = num;
				num = (short)1482947802;
				short num3 = num;
				num = (short)1517223130;
				switch (num3 == num)
				{
				}
				num = (short)938213377;
				if (num != 0)
				{
				}
				num = (short)1659502592;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSITransmitIndication_A41834._HasDiffs;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000309 RID: 777 RVA: 0x000398D0 File Offset: 0x00037AD0
		// (set) Token: 0x0600030A RID: 778 RVA: 0x00039984 File Offset: 0x00037B84
		public int ZoneChannelAssignmentRSITimeDialAtt_A41835Value
		{
			get
			{
				short num = (short)1990197248;
				short num2 = num;
				num = (short)1431108132;
				short num3 = num;
				num = (short)1375533604;
				switch (num3 == num)
				{
				}
				num = (short)2017591297;
				if (num != 0)
				{
				}
				num = (short)1581580288;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSITimeDialAtt_A41835.Value;
			}
			set
			{
				short num = (short)1124925440;
				short num2 = num;
				num = (short)1926693264;
				short num3 = num;
				num = (short)1801781648;
				switch (num3 == num)
				{
				}
				num = (short)2136145921;
				if (num != 0)
				{
				}
				num = (short)1973944320;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSITimeDialAtt_A41835.Value = value;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x0600030B RID: 779 RVA: 0x00039A3C File Offset: 0x00037C3C
		public global::AcpBusinessLayer.AcpSimpleRangeField ZoneChannelAssignmentRSITimeDialAtt_A41835
		{
			get
			{
				short num = (short)1450180608;
				short num2 = num;
				num = (short)1815019521;
				if (num != 0)
				{
				}
				num = (short)346851081;
				short num3 = num;
				num = (short)1446479625;
				switch (num3 == num)
				{
				}
				num = (short)1469251584;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSITimeDialAtt_A41835;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x0600030C RID: 780 RVA: 0x00039AEC File Offset: 0x00037CEC
		// (set) Token: 0x0600030D RID: 781 RVA: 0x00039BA0 File Offset: 0x00037DA0
		public string ZoneChannelAssignmentRSITimeDialAtt_A41835_UIValue
		{
			get
			{
				short num = (short)2095906816;
				short num2 = num;
				num = (short)406181550;
				short num3 = num;
				num = (short)647222958;
				switch (num3 == num)
				{
				}
				num = (short)1556938752;
				if (num != 0)
				{
				}
				num = (short)137953281;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSITimeDialAtt_A41835.UIValue;
			}
			set
			{
				short num = (short)1199243264;
				short num2 = num;
				num = (short)1505689601;
				if (num != 0)
				{
				}
				num = (short)183798426;
				short num3 = num;
				num = (short)1268157082;
				switch (num3 == num)
				{
				}
				num = (short)1425670144;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSITimeDialAtt_A41835.UIValue = value;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x0600030E RID: 782 RVA: 0x00039C58 File Offset: 0x00037E58
		// (set) Token: 0x0600030F RID: 783 RVA: 0x00039D0C File Offset: 0x00037F0C
		internal int ZoneChannelAssignmentRSITimeDialAtt_A41835Min
		{
			get
			{
				short num = (short)1738145792;
				short num2 = num;
				num = (short)1089468365;
				short num3 = num;
				num = (short)1759049677;
				switch (num3 == num)
				{
				}
				num = (short)751239169;
				if (num != 0)
				{
				}
				num = (short)1172373504;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSITimeDialAtt_A41835.Min;
			}
			set
			{
				short num = (short)1370030080;
				short num2 = num;
				num = (short)147620373;
				short num3 = num;
				num = (short)879657493;
				switch (num3 == num)
				{
				}
				num = (short)1201078272;
				if (num != 0)
				{
				}
				num = (short)19595265;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSITimeDialAtt_A41835.Min = value;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x06000310 RID: 784 RVA: 0x00039DC0 File Offset: 0x00037FC0
		// (set) Token: 0x06000311 RID: 785 RVA: 0x00039E74 File Offset: 0x00038074
		internal int ZoneChannelAssignmentRSITimeDialAtt_A41835Max
		{
			get
			{
				short num = (short)551157760;
				short num2 = num;
				num = (short)561837478;
				short num3 = num;
				num = (short)1606808998;
				switch (num3 == num)
				{
				}
				num = (short)30408704;
				if (num != 0)
				{
				}
				num = (short)1222574081;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSITimeDialAtt_A41835.Max;
			}
			set
			{
				short num = (short)241238016;
				short num2 = num;
				num = (short)1418288587;
				short num3 = num;
				num = (short)379870667;
				switch (num3 == num)
				{
				}
				num = (short)619446272;
				if (num != 0)
				{
				}
				num = (short)1780744193;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSITimeDialAtt_A41835.Max = value;
			}
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x06000312 RID: 786 RVA: 0x00039F28 File Offset: 0x00038128
		// (set) Token: 0x06000313 RID: 787 RVA: 0x00039FDC File Offset: 0x000381DC
		internal int ZoneChannelAssignmentRSITimeDialAtt_A41835Step
		{
			get
			{
				short num = (short)1422813733;
				short num2 = num;
				num = (short)1143433765;
				switch (num2 == num)
				{
				default:
				{
					num = (short)389021696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1532755969;
				if (num != 0)
				{
				}
				num = (short)445186048;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSITimeDialAtt_A41835.StepSize;
			}
			set
			{
				short num = (short)494338049;
				if (num != 0)
				{
				}
				num = (short)2007171072;
				short num2 = num;
				num = (short)1806457563;
				short num3 = num;
				num = (short)1617779419;
				switch (num3 == num)
				{
				}
				num = (short)1572143104;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSITimeDialAtt_A41835.StepSize = value;
			}
		}

		// Token: 0x17000166 RID: 358
		// (get) Token: 0x06000314 RID: 788 RVA: 0x0003A094 File Offset: 0x00038294
		// (set) Token: 0x06000315 RID: 789 RVA: 0x0003A14C File Offset: 0x0003834C
		public bool ZoneChannelAssignmentRSITimeDialAtt_A41835_Applicable
		{
			get
			{
				short num = (short)297719112;
				short num2 = num;
				num = (short)740676936;
				switch (num2 == num)
				{
				default:
				{
					num = (short)26083328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1104281601;
				if (num != 0)
				{
				}
				num = (short)1376714752;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSITimeDialAtt_A41835.Applicable;
			}
			set
			{
				short num = (short)31819269;
				short num2 = num;
				num = (short)631014917;
				switch (num2 == num)
				{
				default:
				{
					num = (short)39387136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)381091841;
				if (num != 0)
				{
				}
				num = (short)1076101120;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSITimeDialAtt_A41835.Applicable = value;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x06000316 RID: 790 RVA: 0x0003A204 File Offset: 0x00038404
		// (set) Token: 0x06000317 RID: 791 RVA: 0x0003A2B8 File Offset: 0x000384B8
		public bool ZoneChannelAssignmentRSITimeDialAtt_A41835_Valid
		{
			get
			{
				short num = (short)1916403713;
				if (num != 0)
				{
				}
				num = (short)1129840640;
				short num2 = num;
				num = (short)1207440583;
				short num3 = num;
				num = (short)881595591;
				switch (num3 == num)
				{
				}
				num = (short)1465319424;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSITimeDialAtt_A41835.Valid;
			}
			set
			{
				short num = (short)1554027633;
				short num2 = num;
				num = (short)2006094961;
				switch (num2 == num)
				{
				default:
				{
					num = (short)845611008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2141257729;
				if (num != 0)
				{
				}
				num = (short)407568384;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSITimeDialAtt_A41835.Valid = value;
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x06000318 RID: 792 RVA: 0x0003A370 File Offset: 0x00038570
		// (set) Token: 0x06000319 RID: 793 RVA: 0x0003A424 File Offset: 0x00038624
		public bool ZoneChannelAssignmentRSITimeDialAtt_A41835_Visible
		{
			get
			{
				short num = (short)838205801;
				short num2 = num;
				num = (short)1216545129;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1539178496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1788870657;
				if (num != 0)
				{
				}
				num = (short)778174464;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSITimeDialAtt_A41835.Visible;
			}
			set
			{
				short num = (short)658559623;
				short num2 = num;
				num = (short)241947271;
				switch (num2 == num)
				{
				default:
				{
					num = (short)380108800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1024917505;
				if (num != 0)
				{
				}
				num = (short)2120744960;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSITimeDialAtt_A41835.Visible = value;
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x0600031A RID: 794 RVA: 0x0003A4D8 File Offset: 0x000386D8
		// (set) Token: 0x0600031B RID: 795 RVA: 0x0003A590 File Offset: 0x00038790
		public bool ZoneChannelAssignmentRSITimeDialAtt_A41835_Editable
		{
			get
			{
				short num = (short)1241907201;
				if (num != 0)
				{
				}
				num = (short)1387593728;
				short num2 = num;
				num = (short)1254582495;
				short num3 = num;
				num = (short)1431988447;
				switch (num3 == num)
				{
				}
				num = (short)318439424;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSITimeDialAtt_A41835.Editable;
			}
			set
			{
				short num = (short)1974141126;
				short num2 = num;
				num = (short)830800070;
				switch (num2 == num)
				{
				default:
				{
					num = (short)707723264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)277348352;
				if (num != 0)
				{
				}
				num = (short)537919489;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSITimeDialAtt_A41835.Editable = value;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x0600031C RID: 796 RVA: 0x0003A648 File Offset: 0x00038848
		internal string ZoneChannelAssignmentRSITimeDialAtt_A41835_UILabel
		{
			get
			{
				short num = (short)323769432;
				short num2 = num;
				num = (short)714036312;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1591541760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)773062657;
				if (num != 0)
				{
				}
				num = (short)288161792;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSITimeDialAtt_A41835.UIName;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600031D RID: 797 RVA: 0x0003A6FC File Offset: 0x000388FC
		// (set) Token: 0x0600031E RID: 798 RVA: 0x0003A7B4 File Offset: 0x000389B4
		internal bool ZoneChannelAssignmentRSITimeDialAtt_A41835_HiddenStatic
		{
			get
			{
				short num = (short)85400660;
				short num2 = num;
				num = (short)1872829524;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1253834752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)795869184;
				if (num != 0)
				{
				}
				num = (short)1340407809;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSITimeDialAtt_A41835.HiddenStatic;
			}
			set
			{
				short num = (short)1110472034;
				short num2 = num;
				num = (short)818967906;
				switch (num2 == num)
				{
				default:
				{
					num = (short)660209664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)76349441;
				if (num != 0)
				{
				}
				num = (short)1338769408;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSITimeDialAtt_A41835.HiddenStatic = value;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600031F RID: 799 RVA: 0x0003A868 File Offset: 0x00038A68
		// (set) Token: 0x06000320 RID: 800 RVA: 0x0003A91C File Offset: 0x00038B1C
		internal bool ZoneChannelAssignmentRSITimeDialAtt_A41835_HiddenDynamic
		{
			get
			{
				short num = (short)991790769;
				short num2 = num;
				num = (short)2056029873;
				switch (num2 == num)
				{
				default:
				{
					num = (short)279052288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)514719745;
				if (num != 0)
				{
				}
				num = (short)501940224;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSITimeDialAtt_A41835.HiddenDynamic;
			}
			set
			{
				short num = (short)1162372297;
				short num2 = num;
				num = (short)163669193;
				switch (num2 == num)
				{
				default:
				{
					num = (short)859504640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)642908161;
				if (num != 0)
				{
				}
				num = (short)435421184;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSITimeDialAtt_A41835.HiddenDynamic = value;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06000321 RID: 801 RVA: 0x0003A9D0 File Offset: 0x00038BD0
		public bool ZoneChannelAssignmentRSITimeDialAtt_A41835_HasDiffs
		{
			get
			{
				short num = (short)466997061;
				short num2 = num;
				num = (short)229166917;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1112604672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)768671745;
				if (num != 0)
				{
				}
				num = (short)863436800;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSITimeDialAtt_A41835._HasDiffs;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000322 RID: 802 RVA: 0x0003AA88 File Offset: 0x00038C88
		// (set) Token: 0x06000323 RID: 803 RVA: 0x0003AB3C File Offset: 0x00038D3C
		public int ZoneChannelAssignmentRSIDTRTogTime_A41836Value
		{
			get
			{
				short num = (short)895983823;
				short num2 = num;
				num = (short)98738383;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2062614528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1557790720;
				if (num != 0)
				{
				}
				num = (short)151584769;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIDTRTogTime_A41836.Value;
			}
			set
			{
				short num = (short)228655105;
				if (num != 0)
				{
				}
				num = (short)1485963264;
				short num2 = num;
				num = (short)1855851738;
				short num3 = num;
				num = (short)773000410;
				switch (num3 == num)
				{
				}
				num = (short)1052311552;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSIDTRTogTime_A41836.Value = value;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000324 RID: 804 RVA: 0x0003ABF4 File Offset: 0x00038DF4
		public global::AcpBusinessLayer.AcpSimpleRangeField ZoneChannelAssignmentRSIDTRTogTime_A41836
		{
			get
			{
				short num = (short)1196490753;
				if (num != 0)
				{
				}
				num = (short)1685323776;
				short num2 = num;
				num = (short)1327434919;
				short num3 = num;
				num = (short)535432359;
				switch (num3 == num)
				{
				}
				num = (short)701431808;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIDTRTogTime_A41836;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000325 RID: 805 RVA: 0x0003ACA4 File Offset: 0x00038EA4
		// (set) Token: 0x06000326 RID: 806 RVA: 0x0003AD58 File Offset: 0x00038F58
		public string ZoneChannelAssignmentRSIDTRTogTime_A41836_UIValue
		{
			get
			{
				short num = (short)629735425;
				if (num != 0)
				{
				}
				num = (short)1432354816;
				short num2 = num;
				num = (short)776584901;
				short num3 = num;
				num = (short)328711877;
				switch (num3 == num)
				{
				}
				num = (short)2020737024;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIDTRTogTime_A41836.UIValue;
			}
			set
			{
				short num = (short)1874305374;
				short num2 = num;
				num = (short)2107810142;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1645084672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)578224129;
				if (num != 0)
				{
				}
				num = (short)1362886656;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSIDTRTogTime_A41836.UIValue = value;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000327 RID: 807 RVA: 0x0003AE0C File Offset: 0x0003900C
		// (set) Token: 0x06000328 RID: 808 RVA: 0x0003AEC4 File Offset: 0x000390C4
		internal int ZoneChannelAssignmentRSIDTRTogTime_A41836Min
		{
			get
			{
				short num = (short)1998763110;
				short num2 = num;
				num = (short)1319482470;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2067595264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1229193217;
				if (num != 0)
				{
				}
				num = (short)1191247872;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIDTRTogTime_A41836.Min;
			}
			set
			{
				short num = (short)1108731041;
				short num2 = num;
				num = (short)1730733217;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1884618752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)607649793;
				if (num != 0)
				{
				}
				num = (short)186777600;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSIDTRTogTime_A41836.Min = value;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000329 RID: 809 RVA: 0x0003AF7C File Offset: 0x0003917C
		// (set) Token: 0x0600032A RID: 810 RVA: 0x0003B030 File Offset: 0x00039230
		internal int ZoneChannelAssignmentRSIDTRTogTime_A41836Max
		{
			get
			{
				short num = (short)1896122864;
				short num2 = num;
				num = (short)1280346608;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1395720192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)527302657;
				if (num != 0)
				{
				}
				num = (short)720568320;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIDTRTogTime_A41836.Max;
			}
			set
			{
				short num = (short)167719547;
				short num2 = num;
				num = (short)211038843;
				switch (num2 == num)
				{
				default:
				{
					num = (short)981532672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2126708737;
				if (num != 0)
				{
				}
				num = (short)194641920;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSIDTRTogTime_A41836.Max = value;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600032B RID: 811 RVA: 0x0003B0E8 File Offset: 0x000392E8
		// (set) Token: 0x0600032C RID: 812 RVA: 0x0003B19C File Offset: 0x0003939C
		internal int ZoneChannelAssignmentRSIDTRTogTime_A41836Step
		{
			get
			{
				short num = (short)923729921;
				if (num != 0)
				{
				}
				num = (short)411369472;
				short num2 = num;
				num = (short)166127658;
				short num3 = num;
				num = (short)1121118250;
				switch (num3 == num)
				{
				}
				num = (short)1430454272;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIDTRTogTime_A41836.StepSize;
			}
			set
			{
				short num = (short)689045505;
				if (num != 0)
				{
				}
				num = (short)654770176;
				short num2 = num;
				num = (short)2130568286;
				short num3 = num;
				num = (short)788325470;
				switch (num3 == num)
				{
				}
				num = (short)1775370240;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSIDTRTogTime_A41836.StepSize = value;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600032D RID: 813 RVA: 0x0003B250 File Offset: 0x00039450
		// (set) Token: 0x0600032E RID: 814 RVA: 0x0003B300 File Offset: 0x00039500
		public bool ZoneChannelAssignmentRSIDTRTogTime_A41836_Applicable
		{
			get
			{
				short num = (short)2090839319;
				short num2 = num;
				num = (short)332639511;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1146814464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)954204161;
				if (num != 0)
				{
				}
				num = (short)1504313344;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIDTRTogTime_A41836.Applicable;
			}
			set
			{
				short num = (short)1593649731;
				short num2 = num;
				num = (short)1689594435;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1841627136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)46792704;
				if (num != 0)
				{
				}
				num = (short)704315393;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSIDTRTogTime_A41836.Applicable = value;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600032F RID: 815 RVA: 0x0003B3B4 File Offset: 0x000395B4
		// (set) Token: 0x06000330 RID: 816 RVA: 0x0003B468 File Offset: 0x00039668
		public bool ZoneChannelAssignmentRSIDTRTogTime_A41836_Valid
		{
			get
			{
				short num = (short)1599433667;
				short num2 = num;
				num = (short)1847094211;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1277886464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1090846721;
				if (num != 0)
				{
				}
				num = (short)1715142656;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIDTRTogTime_A41836.Valid;
			}
			set
			{
				short num = (short)1223032833;
				if (num != 0)
				{
				}
				num = (short)1089273856;
				short num2 = num;
				num = (short)1442952703;
				short num3 = num;
				num = (short)1903277567;
				switch (num3 == num)
				{
				}
				num = (short)1787887616;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSIDTRTogTime_A41836.Valid = value;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000331 RID: 817 RVA: 0x0003B520 File Offset: 0x00039720
		// (set) Token: 0x06000332 RID: 818 RVA: 0x0003B5D8 File Offset: 0x000397D8
		public bool ZoneChannelAssignmentRSIDTRTogTime_A41836_Visible
		{
			get
			{
				short num = (short)1378082451;
				short num2 = num;
				num = (short)843636371;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1510211584;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1028915201;
				if (num != 0)
				{
				}
				num = (short)367984640;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIDTRTogTime_A41836.Visible;
			}
			set
			{
				short num = (short)1749685945;
				short num2 = num;
				num = (short)852760249;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1984692224;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1444085761;
				if (num != 0)
				{
				}
				num = (short)250085376;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSIDTRTogTime_A41836.Visible = value;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000333 RID: 819 RVA: 0x0003B690 File Offset: 0x00039890
		// (set) Token: 0x06000334 RID: 820 RVA: 0x0003B748 File Offset: 0x00039948
		public bool ZoneChannelAssignmentRSIDTRTogTime_A41836_Editable
		{
			get
			{
				short num = (short)951306608;
				short num2 = num;
				num = (short)1429719408;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1073872896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1160642561;
				if (num != 0)
				{
				}
				num = (short)2081816576;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIDTRTogTime_A41836.Editable;
			}
			set
			{
				short num = (short)1201985283;
				short num2 = num;
				num = (short)1330829059;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1810563072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1672544256;
				if (num != 0)
				{
				}
				num = (short)651427841;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSIDTRTogTime_A41836.Editable = value;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000335 RID: 821 RVA: 0x0003B7FC File Offset: 0x000399FC
		internal string ZoneChannelAssignmentRSIDTRTogTime_A41836_UILabel
		{
			get
			{
				short num = (short)1008991056;
				short num2 = num;
				num = (short)1053490000;
				switch (num2 == num)
				{
				default:
				{
					num = (short)432472064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)382009344;
				if (num != 0)
				{
				}
				num = (short)519372801;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIDTRTogTime_A41836.UIName;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000336 RID: 822 RVA: 0x0003B8B0 File Offset: 0x00039AB0
		// (set) Token: 0x06000337 RID: 823 RVA: 0x0003B964 File Offset: 0x00039B64
		internal bool ZoneChannelAssignmentRSIDTRTogTime_A41836_HiddenStatic
		{
			get
			{
				short num = (short)605159425;
				if (num != 0)
				{
				}
				num = (short)847577088;
				short num2 = num;
				num = (short)1029204536;
				short num3 = num;
				num = (short)1977772600;
				switch (num3 == num)
				{
				}
				num = (short)595853312;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIDTRTogTime_A41836.HiddenStatic;
			}
			set
			{
				short num = (short)1564606465;
				if (num != 0)
				{
				}
				num = (short)196804608;
				short num2 = num;
				num = (short)2107036463;
				short num3 = num;
				num = (short)2027148079;
				switch (num3 == num)
				{
				}
				num = (short)2004221952;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSIDTRTogTime_A41836.HiddenStatic = value;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000338 RID: 824 RVA: 0x0003BA18 File Offset: 0x00039C18
		// (set) Token: 0x06000339 RID: 825 RVA: 0x0003BAD0 File Offset: 0x00039CD0
		internal bool ZoneChannelAssignmentRSIDTRTogTime_A41836_HiddenDynamic
		{
			get
			{
				short num = (short)2030370817;
				if (num != 0)
				{
				}
				num = (short)795213824;
				short num2 = num;
				num = (short)892004992;
				short num3 = num;
				num = (short)1388178048;
				switch (num3 == num)
				{
				}
				num = (short)1650655232;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIDTRTogTime_A41836.HiddenDynamic;
			}
			set
			{
				short num = (short)907935745;
				if (num != 0)
				{
				}
				num = (short)1632698368;
				short num2 = num;
				num = (short)1503823628;
				short num3 = num;
				num = (short)1384023820;
				switch (num3 == num)
				{
				}
				num = (short)1043922944;
				if (num != 0)
				{
				}
				this.zoneChannelAssignmentRSIDTRTogTime_A41836.HiddenDynamic = value;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600033A RID: 826 RVA: 0x0003BB88 File Offset: 0x00039D88
		public bool ZoneChannelAssignmentRSIDTRTogTime_A41836_HasDiffs
		{
			get
			{
				short num = (short)996737025;
				if (num != 0)
				{
				}
				num = (short)1597767680;
				short num2 = num;
				num = (short)1519876118;
				short num3 = num;
				num = (short)1686927382;
				switch (num3 == num)
				{
				}
				num = (short)1399062528;
				if (num != 0)
				{
				}
				return this.zoneChannelAssignmentRSIDTRTogTime_A41836._HasDiffs;
			}
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0003BC3C File Offset: 0x00039E3C
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
					num2 = (short)948174849;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					if (base.ParentRecset.ContainerDoc == null)
					{
						return result;
					}
					num2 = (short)477993736;
					short num3 = num2;
					num2 = (short)949132040;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3B;
					default:
					{
						num2 = (short)1189281792;
						short num4 = num2;
						num2 = (short)1065484288;
						if (num2 != 0)
						{
						}
						num2 = (short)677052418;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					num2 = (short)104857601;
					if (num2 != 0)
					{
					}
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1578303492;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_3B;
				case 4:
					return result;
				}
				goto IL_24;
				IL_3B:
				if (base.ParentRecset == null)
				{
					break;
				}
				num2 = (short)1398931456;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1898577923;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040000B7 RID: 183
		private global::AcpBusinessLayer.AcpListField zoneChannelAssignmentRSIMode_A41831;

		// Token: 0x040000B8 RID: 184
		private global::AcpBusinessLayer.AcpField<bool> zoneChannelAssignmentRSIAutoDial_A41832;

		// Token: 0x040000B9 RID: 185
		private global::AcpBusinessLayer.AcpSimpleRangeField zoneChannelAssignmentRSISiteNumber_A41833;

		// Token: 0x040000BA RID: 186
		private global::AcpBusinessLayer.AcpField<string> mainComparatorHostname_43796;

		// Token: 0x040000BB RID: 187
		private global::AcpBusinessLayer.AcpField<string> alternateComparatorHostname_43797;

		// Token: 0x040000BC RID: 188
		private global::AcpBusinessLayer.AcpSimpleRangeField mainComparatorDTLSPortNumber_43798;

		// Token: 0x040000BD RID: 189
		private global::AcpBusinessLayer.AcpSimpleRangeField alternateComparatorDTLSPortNumber_43801;

		// Token: 0x040000BE RID: 190
		private global::AcpBusinessLayer.AcpSimpleRangeField comparatorChannelNumber_43800;

		// Token: 0x040000BF RID: 191
		private global::AcpBusinessLayer.AcpField<bool> zoneChannelAssignmentRSITransmitIndication_A41834;

		// Token: 0x040000C0 RID: 192
		private global::AcpBusinessLayer.AcpSimpleRangeField zoneChannelAssignmentRSITimeDialAtt_A41835;

		// Token: 0x040000C1 RID: 193
		private global::AcpBusinessLayer.AcpSimpleRangeField zoneChannelAssignmentRSIDTRTogTime_A41836;
	}
}
