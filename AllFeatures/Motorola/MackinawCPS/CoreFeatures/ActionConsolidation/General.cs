using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.ActionConsolidation
{
	// Token: 0x02000430 RID: 1072
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06009119 RID: 37145 RVA: 0x0088EBB0 File Offset: 0x0088CDB0
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x0600911A RID: 37146 RVA: 0x0088EBF0 File Offset: 0x0088CDF0
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600911B RID: 37147 RVA: 0x0088EC08 File Offset: 0x0088CE08
		public override void Init()
		{
			int a_ = 15;
			short num = (short)202841964;
			short num2 = num;
			num = (short)481238892;
			switch (num2 == num)
			{
			}
			num = (short)564133888;
			if (num != 0)
			{
			}
			num = (short)1928331265;
			if (num != 0)
			{
			}
			num = (short)1817903104;
			short num3 = num;
			this.radioErgoConfigACGeneralActionAllowed_A36579 = new global::AcpBusinessLayer.AcpFieldX<bool, string>(true, new global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.PackUnpackYesNoToTrueFalse(), this, global::AllFeatures.CodeplugGuid.b("苏돑냓뿕럗鿙껛망迟ꇡ诣裥軧菩诫꿭돯뗱釳飵鷷裹鷻鋽䇿愁瀃漅朇搉䴋戍簏紑挓猕簗䔙崛ⴝᘟᜡጣἥ", a_), global::CommonResources.AcgResources.ID_ACTIONALLOWEDONRESPONSESELECTOR);
			this.radioErgoConfigACGeneralActionAllowed_A36579.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radioErgoConfigACGeneralActionAllowed_A36579.DataTransferOrder = -1;
			this.radioErgoConfigACGeneralActionAllowed_A36579.EvaluateRecRefs = true;
			this.radioErgoConfigACName_A36581 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("苏돑냓뿕럗鿙껛망迟ꇡ诣裥軧菩诫꿭돯볱闳鯵鷷ꗹ뷻췽㛿㜁㰃㜅", a_), global::CommonResources.AcgResources.ID_CONSOLIDATEDACTIONNAME, 14);
			this.radioErgoConfigACName_A36581.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radioErgoConfigACName_A36581.DataTransferOrder = 2;
			this.radioErgoConfigACName_A36581.EvaluateRecRefs = true;
			this.radioErgoConfigACRelayPattern_A36582 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("苏돑냓뿕럗鿙껛망迟ꇡ诣裥軧菩诫꿭돯ꃱ釳髵駷菹곻鿽瓿瘁愃琅昇唉䴋㴍☏✑Ⱃ␕", a_), global::CommonResources.AcgResources.ID_RELAYPATTERN, new string[]
			{
				global::CommonResources.AcgResources.ID_UNASSIGNED
			}, new int[1], true, false);
			this.radioErgoConfigACRelayPattern_A36582.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radioErgoConfigACRelayPattern_A36582.DataTransferOrder = 3;
			this.radioErgoConfigACRelayPattern_A36582.EvaluateRecRefs = true;
			this.radioErgoConfigACRelayPatternErrStrategy_A36583 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("苏돑냓뿕럗鿙껛망迟ꇡ诣裥軧菩诫꿭돯ꃱ釳髵駷菹곻鿽瓿瘁愃琅昇伉縋簍䌏昑易眕気缙笛朝缟挡ᜣဥᴧሩἫ", a_), global::CommonResources.AcgResources.ID_RELAYPATTERNERRORSTRATEGY, global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.LOVs.RadioErgoConfigACRelayPatternErrStrategy_A36583LovStrs);
			this.radioErgoConfigACRelayPatternErrStrategy_A36583.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radioErgoConfigACRelayPatternErrStrategy_A36583.DataTransferOrder = 4;
			this.radioErgoConfigACSirenType_A36584 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.SirenTypeSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.LOVs.indexRadioErgoConfigACSirenType_A36584LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.LOVs.idRadioErgoConfigACSirenType_A36584LovStrs), this, global::AllFeatures.CodeplugGuid.b("苏돑냓뿕럗鿙껛망迟ꇡ诣裥軧菩诫꿭돯ꇱ鷳蓵鷷铹ꣻ蟽烿朁嬃䜅㬇㰉㤋㘍␏", a_), global::CommonResources.AcgResources.ID_SIRENTYPE, global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.LOVs.RadioErgoConfigACSirenType_A36584LovStrs);
			this.radioErgoConfigACSirenType_A36584.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radioErgoConfigACSirenType_A36584.DataTransferOrder = 5;
			this.radioErgoConfigACSirenType_A36584.EvaluateRecRefs = true;
			this.radioErgoConfigACSirenTypeErrStrategy_A36585 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("苏돑냓뿕럗鿙껛망迟ꇡ诣裥軧菩诫꿭돯ꇱ鷳蓵鷷铹ꣻ蟽烿朁䄃琅稇変砋簍焏昑焓焕愗䔙崛ⴝᘟᜡᰣጥ", a_), global::CommonResources.AcgResources.ID_SIRENTYPEERRORSTRATEGY, global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.LOVs.RadioErgoConfigACSirenTypeErrStrategy_A36585LovStrs);
			this.radioErgoConfigACSirenTypeErrStrategy_A36585.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radioErgoConfigACSirenTypeErrStrategy_A36585.DataTransferOrder = 6;
			this.radioErgoConfigACGpsReport_A36587 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("苏돑냓뿕럗鿙껛망迟ꇡ诣裥軧菩诫꿭돯뗱蓳藵꫷鿹賻釽狿瘁嬃䜅㬇㰉㤋㘍✏", a_), global::CommonResources.AcgResources.ID_GPSREPORT);
			this.radioErgoConfigACGpsReport_A36587.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radioErgoConfigACGpsReport_A36587.DataTransferOrder = 20;
			this.radioErgoConfigACGpsReportErrStrategy_A36588 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("苏돑냓뿕럗鿙껛망迟ꇡ诣裥軧菩诫꿭돯뗱蓳藵꫷鿹賻釽狿瘁䄃琅稇変砋簍焏昑焓焕愗䔙崛ⴝᘟᜡᰣḥ", a_), global::CommonResources.AcgResources.ID_GPSREPORTERRORSTRATEGY, global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.LOVs.RadioErgoConfigACGpsReportErrStrategy_A36588LovStrs);
			this.radioErgoConfigACGpsReportErrStrategy_A36588.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radioErgoConfigACGpsReportErrStrategy_A36588.DataTransferOrder = 8;
			this.radioErgoConfigAC3rdPartyNotification_A41510 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("苏돑냓뿕럗鿙껛망迟ꇡ诣裥軧菩诫꿭돯쇱蛳鋵ꣷ鯹軻諽秿䰁欃爅愇氉攋洍焏昑紓礕瘗䔙崛⨝ᄟᜡᔣᘥ", a_), global::CommonResources.AcgResources.ID_THIRDPARTYNOTIFICATION, global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.LOVs.RadioErgoConfigAC3rdPartyNotification_A41510LovStrs);
			this.radioErgoConfigAC3rdPartyNotification_A41510.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radioErgoConfigAC3rdPartyNotification_A41510.DataTransferOrder = 7;
			this.radioErgoConfigAC3rdPartyNotificationErrorStategy_A41516 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("苏돑냓뿕럗鿙껛망迟ꇡ诣裥軧菩诫꿭돯쇱蛳鋵ꣷ鯹軻諽秿䰁欃爅愇氉攋洍焏昑紓礕瘗弙減氝伟倡眣別䤧帩䤫䤭䤯洱申ȵष഻༹࠽", a_), global::CommonResources.AcgResources.ID_THIRDPARTYNOTIFICATIONERRORSTRATEGY, global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.LOVs.RadioErgoConfigAC3rdPartyNotificationErrorStategy_A41516LovStrs);
			this.radioErgoConfigAC3rdPartyNotificationErrorStategy_A41516.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radioErgoConfigAC3rdPartyNotificationErrorStategy_A41516.DataTransferOrder = 9;
			this.radioErgoConfigACActionType_A42871 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.LOVs.indexRadioErgoConfigACActionType_A42871LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.LOVs.idRadioErgoConfigACActionType_A42871LovStrs), this, global::AllFeatures.CodeplugGuid.b("苏돑냓뿕럗鿙껛망迟ꇡ诣裥軧菩诫꿭돯돱音苵釷闹鋻꫽秿爁愃夅䤇㸉㸋㘍✏⌑", a_), global::CommonResources.AcgResources.ID_ACTIONTYPE, global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.LOVs.RadioErgoConfigACActionType_A42871LovStrs);
			this.radioErgoConfigACActionType_A42871.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radioErgoConfigACActionType_A42871.DataTransferOrder = 1;
			this.radioErgoConfigACActionType_A42871.EvaluateRecRefs = true;
			this.radioErgoConfigACAlertVisualResponse_A42878 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("苏돑냓뿕럗鿙껛망迟ꇡ诣裥軧菩诫꿭돯돱飳鏵諷軹꫻韽珿省攃樅娇漉缋縍缏簑朓猕䜗嬙⠛Ⱍ᠟ᔡᰣ", a_), global::CommonResources.AcgResources.ID_BACKLIGHTCOLOR, global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.LOVs.RadioErgoConfigACAlertVisualResponse_A42878LovStrs);
			this.radioErgoConfigACAlertVisualResponse_A42878.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radioErgoConfigACAlertVisualResponse_A42878.DataTransferOrder = 22;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("韏럑뫓돕꫗믙냛", a_);
			base.Id = 10615;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600911C RID: 37148 RVA: 0x0088F028 File Offset: 0x0088D228
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 14;
			short num = (short)577241092;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒볔룖鳘꧚뫜냞ꋠ賢诤臦胨質곬곮ꏰ雲駴零胸꯺鳼课甀昂眄椆嘈䨊㸌㤎␐⬒✔", a_)))
					{
						num = (short)2136145948;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8B7;
				case 1:
					this.radioErgoConfigACSirenType_A36584 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.SirenTypeSparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.LOVs.indexRadioErgoConfigACSirenType_A36584LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.LOVs.idRadioErgoConfigACSirenType_A36584LovStrs), this, global::AllFeatures.CodeplugGuid.b("鷎냐럒볔룖鳘꧚뫜냞ꋠ賢诤臦胨質곬곮ꋰ髲蟴鋶韸꿺蓼迾搀専䐄㐆㼈㸊㔌㬎", a_), global::CommonResources.AcgResources.ID_SIRENTYPE, global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.LOVs.RadioErgoConfigACSirenType_A36584LovStrs);
					this.radioErgoConfigACSirenType_A36584.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radioErgoConfigACSirenType_A36584.DataTransferOrder = 5;
					this.radioErgoConfigACSirenType_A36584.EvaluateRecRefs = true;
					num = (short)1375010845;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					this.radioErgoConfigACRelayPatternErrStrategy_A36583 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒볔룖鳘꧚뫜냞ꋠ賢诤臦胨質곬곮ꏰ雲駴零胸꯺鳼课甀昂眄椆䰈礊缌導攐愒琔挖簘簚搜䀞怠ဢጤሦᄨᠪ", a_), global::CommonResources.AcgResources.ID_RELAYPATTERNERRORSTRATEGY, global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.LOVs.RadioErgoConfigACRelayPatternErrStrategy_A36583LovStrs);
					this.radioErgoConfigACRelayPatternErrStrategy_A36583.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radioErgoConfigACRelayPatternErrStrategy_A36583.DataTransferOrder = 4;
					num = (short)987758619;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					this.radioErgoConfigACGpsReportErrStrategy_A36588 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒볔룖鳘꧚뫜냞ꋠ賢诤臦胨質곬곮뛰菲蛴ꗶ鳸诺鋼跾甀䘂眄甆娈缊缌渎攐瘒爔渖䘘娚⸜⤞ᐠᬢᴤ", a_), global::CommonResources.AcgResources.ID_GPSREPORTERRORSTRATEGY, global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.LOVs.RadioErgoConfigACGpsReportErrStrategy_A36588LovStrs);
					this.radioErgoConfigACGpsReportErrStrategy_A36588.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radioErgoConfigACGpsReportErrStrategy_A36588.DataTransferOrder = 8;
					num = (short)968097802;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_CD;
					}
					continue;
				case 5:
					this.radioErgoConfigACGeneralActionAllowed_A36579 = new global::AcpBusinessLayer.AcpFieldX<bool, string>(true, new global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.PackUnpackYesNoToTrueFalse(), this, global::AllFeatures.CodeplugGuid.b("鷎냐럒볔룖鳘꧚뫜냞ꋠ賢诤臦胨質곬곮뛰雲鯴鋶诸髺釼뻾戀眂氄栆月䨊愌挎縐搒瀔猖䘘娚⸜⤞ᐠᐢᰤ", a_), global::CommonResources.AcgResources.ID_ACTIONALLOWEDONRESPONSESELECTOR);
					this.radioErgoConfigACGeneralActionAllowed_A36579.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radioErgoConfigACGeneralActionAllowed_A36579.DataTransferOrder = -1;
					this.radioErgoConfigACGeneralActionAllowed_A36579.EvaluateRecRefs = true;
					num = (short)2127298595;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒볔룖鳘꧚뫜냞ꋠ賢诤臦胨質곬곮뛰菲蛴ꗶ鳸诺鋼跾甀䘂眄甆娈缊缌渎攐瘒爔渖䘘娚⸜⤞ᐠᬢᴤ", a_)))
					{
						num = (short)910032899;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F4;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒볔룖鳘꧚뫜냞ꋠ賢诤臦胨質곬곮뛰雲鯴鋶诸髺釼뻾戀眂氄栆月䨊愌挎縐搒瀔猖䘘娚⸜⤞ᐠᐢᰤ", a_)))
					{
						num = (short)65994757;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_63B;
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒볔룖鳘꧚뫜냞ꋠ賢诤臦胨質곬곮뛰菲蛴ꗶ鳸诺鋼跾甀専䐄㐆㼈㸊㔌㠎", a_)))
					{
						num = (short)407240705;
						if (num != 0)
						{
						}
						num = (short)1439629351;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_86B;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒볔룖鳘꧚뫜냞ꋠ賢诤臦胨質곬곮ꋰ髲蟴鋶韸꿺蓼迾搀䘂眄甆娈缊缌渎攐瘒爔渖䘘娚⸜⤞ᐠᬢဤ", a_)))
					{
						num = (short)275709972;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_140;
				case 10:
					goto IL_F4;
				case 11:
					num = (short)618659872;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_330;
				case 13:
					this.radioErgoConfigAC3rdPartyNotificationErrorStategy_A41516 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒볔룖鳘꧚뫜냞ꋠ賢诤臦胨質곬곮싰臲釴ꟶ飸觺觼蛾伀氂焄渆漈戊渌渎攐稒稔礖尘椚漜瀞匠瀢儤䘦崨个䨬嘮渰爲Ĵضస਺଼", a_), global::CommonResources.AcgResources.ID_THIRDPARTYNOTIFICATIONERRORSTRATEGY, global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.LOVs.RadioErgoConfigAC3rdPartyNotificationErrorStategy_A41516LovStrs);
					this.radioErgoConfigAC3rdPartyNotificationErrorStategy_A41516.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radioErgoConfigAC3rdPartyNotificationErrorStategy_A41516.DataTransferOrder = 9;
					num = (short)236453912;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					goto IL_140;
				case 15:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒볔룖鳘꧚뫜냞ꋠ賢诤臦胨質곬곮싰臲釴ꟶ飸觺觼蛾伀氂焄渆漈戊渌渎攐稒稔礖尘椚漜瀞匠瀢儤䘦崨个䨬嘮渰爲Ĵضస਺଼", a_)))
					{
						num = (short)1916928013;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_475;
				case 16:
					this.radioErgoConfigAC3rdPartyNotification_A41510 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒볔룖鳘꧚뫜냞ꋠ賢诤臦胨質곬곮싰臲釴ꟶ飸觺觼蛾伀氂焄渆漈戊渌渎攐稒稔礖䘘娚⤜⸞ᐠሢᔤ", a_), global::CommonResources.AcgResources.ID_THIRDPARTYNOTIFICATION, global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.LOVs.RadioErgoConfigAC3rdPartyNotification_A41510LovStrs);
					this.radioErgoConfigAC3rdPartyNotification_A41510.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radioErgoConfigAC3rdPartyNotification_A41510.DataTransferOrder = 7;
					goto IL_792;
				case 17:
					goto IL_5ED;
				case 18:
					this.radioErgoConfigACAlertVisualResponse_A42878 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒볔룖鳘꧚뫜냞ꋠ賢诤臦胨質곬곮냰鿲郴藶跸귺铼賾琀戂椄唆氈砊紌怎缐怒瀔䠖堘⼚⼜✞ᘠᬢ", a_), global::CommonResources.AcgResources.ID_BACKLIGHTCOLOR, global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.LOVs.RadioErgoConfigACAlertVisualResponse_A42878LovStrs);
					this.radioErgoConfigACAlertVisualResponse_A42878.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radioErgoConfigACAlertVisualResponse_A42878.DataTransferOrder = 22;
					num = (short)1627783205;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒볔룖鳘꧚뫜냞ꋠ賢诤臦胨質곬곮ꋰ髲蟴鋶韸꿺蓼迾搀専䐄㐆㼈㸊㔌㬎", a_)))
					{
						num = (short)1784807425;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_81F;
				case 20:
					this.radioErgoConfigACSirenTypeErrStrategy_A36585 = new global::AcpBusinessLayer.AcpListField(1, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒볔룖鳘꧚뫜냞ꋠ賢诤臦胨質곬곮ꋰ髲蟴鋶韸꿺蓼迾搀䘂眄甆娈缊缌渎攐瘒爔渖䘘娚⸜⤞ᐠᬢဤ", a_), global::CommonResources.AcgResources.ID_SIRENTYPEERRORSTRATEGY, global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.LOVs.RadioErgoConfigACSirenTypeErrStrategy_A36585LovStrs);
					this.radioErgoConfigACSirenTypeErrStrategy_A36585.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radioErgoConfigACSirenTypeErrStrategy_A36585.DataTransferOrder = 6;
					num = (short)1741094926;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒볔룖鳘꧚뫜냞ꋠ賢诤臦胨質곬곮냰鿲郴藶跸귺铼賾琀戂椄唆氈砊紌怎缐怒瀔䠖堘⼚⼜✞ᘠᬢ", a_)))
					{
						num = (short)60489746;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9F3;
				case 22:
				{
					num = (short)1540685824;
					short num3 = num;
					goto IL_8B7;
				}
				case 23:
					this.radioErgoConfigACName_A36581 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("鷎냐럒볔룖鳘꧚뫜냞ꋠ賢诤臦胨質곬곮뿰鋲飴鋶꛸뫺컼짾㐀㬂㐄", a_), global::CommonResources.AcgResources.ID_CONSOLIDATEDACTIONNAME, 14);
					this.radioErgoConfigACName_A36581.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radioErgoConfigACName_A36581.DataTransferOrder = 2;
					this.radioErgoConfigACName_A36581.EvaluateRecRefs = true;
					num = (short)2125135889;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					goto IL_475;
				case 25:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒볔룖鳘꧚뫜냞ꋠ賢诤臦胨質곬곮ꏰ雲駴零胸꯺鳼课甀昂眄椆䰈礊缌導攐愒琔挖簘簚搜䀞怠ဢጤሦᄨᠪ", a_)))
					{
						num = (short)415825922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_51D;
				case 26:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒볔룖鳘꧚뫜냞ꋠ賢诤臦胨質곬곮냰郲致黶雸闺ꧼ蛾焀昂娄䘆㴈㤊㔌㠎‐", a_)))
					{
						num = (short)1280573470;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_330;
				case 27:
					goto IL_51D;
				case 28:
					this.radioErgoConfigACRelayPattern_A36582 = new global::AcpBusinessLayer.AcpRecRefField(this, global::AllFeatures.CodeplugGuid.b("鷎냐럒볔룖鳘꧚뫜냞ꋠ賢诤臦胨質곬곮ꏰ雲駴零胸꯺鳼课甀昂眄椆嘈䨊㸌㤎␐⬒✔", a_), global::CommonResources.AcgResources.ID_RELAYPATTERN, new string[]
					{
						global::CommonResources.AcgResources.ID_UNASSIGNED
					}, new int[1], true, false);
					this.radioErgoConfigACRelayPattern_A36582.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radioErgoConfigACRelayPattern_A36582.DataTransferOrder = 3;
					this.radioErgoConfigACRelayPattern_A36582.EvaluateRecRefs = true;
					num = (short)122224662;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					goto IL_81F;
				case 30:
					this.radioErgoConfigACActionType_A42871 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.LOVs.indexRadioErgoConfigACActionType_A42871LovStrs, global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.LOVs.idRadioErgoConfigACActionType_A42871LovStrs), this, global::AllFeatures.CodeplugGuid.b("鷎냐럒볔룖鳘꧚뫜냞ꋠ賢诤臦胨質곬곮냰郲致黶雸闺ꧼ蛾焀昂娄䘆㴈㤊㔌㠎‐", a_), global::CommonResources.AcgResources.ID_ACTIONTYPE, global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.LOVs.RadioErgoConfigACActionType_A42871LovStrs);
					this.radioErgoConfigACActionType_A42871.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radioErgoConfigACActionType_A42871.DataTransferOrder = 1;
					this.radioErgoConfigACActionType_A42871.EvaluateRecRefs = true;
					num = (short)2121465868;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					goto IL_86B;
				case 32:
					if (producerFields != null)
					{
						num = (short)1403846694;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9F3;
				case 33:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒볔룖鳘꧚뫜냞ꋠ賢诤臦胨質곬곮싰臲釴ꟶ飸觺觼蛾伀氂焄渆漈戊渌渎攐稒稔礖䘘娚⤜⸞ᐠሢᔤ", a_)))
					{
						num = (short)1724645392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_951;
				case 34:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鷎냐럒볔룖鳘꧚뫜냞ꋠ賢诤臦胨質곬곮뿰鋲飴鋶꛸뫺컼짾㐀㬂㐄", a_)))
					{
						num = (short)625475607;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5ED;
				case 35:
					goto IL_63B;
				case 36:
					goto IL_951;
				case 37:
					goto IL_518;
				case 38:
				{
					num = (short)1656489815;
					short num4 = num;
					num = (short)1491994455;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_792;
					default:
						num = (short)2016280576;
						if (num != 0)
						{
						}
						num = (short)1231421447;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 39:
					this.radioErgoConfigACGpsReport_A36587 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鷎냐럒볔룖鳘꧚뫜냞ꋠ賢诤臦胨質곬곮뛰菲蛴ꗶ鳸诺鋼跾甀専䐄㐆㼈㸊㔌㠎", a_), global::CommonResources.AcgResources.ID_GPSREPORT);
					this.radioErgoConfigACGpsReport_A36587.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radioErgoConfigACGpsReport_A36587.DataTransferOrder = 20;
					num = (short)610730015;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_CD:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)341049355;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_F4:
				num = (short)224985121;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_140:
				num = (short)1119223816;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_330:
				num = (short)249626645;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_475:
				num = (short)1793785882;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_51D:
				num = (short)968032275;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5ED:
				num = (short)1970536448;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_63B:
				num = (short)1645805602;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_792:
				num = (short)272695332;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_81F:
				num = (short)651231241;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_86B:
				num = (short)1001652230;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8B7:
				num = (short)2131492889;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_951:
				num = (short)1098055695;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_518:
			IL_9F3:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("裎듐뷒냔ꗖ룘럚", a_);
			base.Id = 10615;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600911D RID: 37149 RVA: 0x0088FA5C File Offset: 0x0088DC5C
		public override void PopulateReferences()
		{
			short num = (short)255482113;
			short num2 = num;
			num = (short)1934317825;
			switch (num2 == num)
			{
			}
			num = (short)1542258688;
			if (num != 0)
			{
			}
			num = (short)914751489;
			if (num != 0)
			{
			}
			num = (short)50135040;
			short num3 = num;
			this.radioErgoConfigACRelayPattern_A36582.SetRecset(this.a(2045)[0][10604].EmbeddedRecset);
		}

		// Token: 0x0600911E RID: 37150 RVA: 0x0088FB30 File Offset: 0x0088DD30
		public override void DropReferences()
		{
			short num = (short)260873744;
			short num2 = num;
			num = (short)656252432;
			switch (num2 == num)
			{
			}
			num = (short)2104819713;
			if (num != 0)
			{
			}
			num = (short)1291321344;
			if (num != 0)
			{
			}
			num = (short)288161792;
			short num3 = num;
		}

		// Token: 0x0600911F RID: 37151 RVA: 0x0088FBD8 File Offset: 0x0088DDD8
		public override void SetConstraints()
		{
			short num = (short)1885475815;
			short num2 = num;
			num = (short)61281255;
			switch (num2 == num)
			{
			}
			num = (short)2073952257;
			if (num != 0)
			{
			}
			num = (short)1021902848;
			if (num != 0)
			{
			}
			num = (short)1282998272;
			short num3 = num;
			this.radioErgoConfigACGeneralActionAllowed_A36579.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConActionTypeIsControl);
			this.radioErgoConfigACGeneralActionAllowed_A36579.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radioErgoConfigACRelayPattern_A36582.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConRelayPatternIsValidWhenURCEquipped);
			this.radioErgoConfigACRelayPattern_A36582.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConActionTypeIsControl);
			this.radioErgoConfigACRelayPatternErrStrategy_A36583.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConRelayPatternErrStrategyApplicable);
			this.radioErgoConfigACRelayPatternErrStrategy_A36583.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConActionTypeIsControl);
			this.radioErgoConfigACSirenType_A36584.IsIndexValid = new global::AcpCommonLib.ListItemStateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConACSirenTypeIndexValid);
			this.radioErgoConfigACSirenType_A36584.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConActionTypeIsControl);
			this.radioErgoConfigACSirenTypeErrStrategy_A36585.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConWhenSirenTypeIsNoChange);
			this.radioErgoConfigACSirenTypeErrStrategy_A36585.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConActionTypeIsControl);
			this.radioErgoConfigACGpsReport_A36587.IsValid = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConGPSAndModeCannotBothBeConfigured);
			this.radioErgoConfigACGpsReport_A36587.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConActionTypeIsControl);
			this.radioErgoConfigACGpsReportErrStrategy_A36588.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConGPSReportErrStrategyApplicable);
			this.radioErgoConfigACGpsReportErrStrategy_A36588.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConActionTypeIsControl);
			this.radioErgoConfigAC3rdPartyNotification_A41510.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConActionTypeIsControl);
			this.radioErgoConfigAC3rdPartyNotificationErrorStategy_A41516.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConThirdPartyNotiErrStategyApp);
			this.radioErgoConfigAC3rdPartyNotificationErrorStategy_A41516.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConActionTypeIsControl);
			this.radioErgoConfigACActionType_A42871.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConACActionTypeIsApplicable);
			this.radioErgoConfigACActionType_A42871.ValueSetter = new global::AcpCommonLib.ValueSetterConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConSetAlertIntervalValue);
			this.radioErgoConfigACAlertVisualResponse_A42878.IsVisible = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationConstraints.ConActionTypeIsGeneralOrPAOrVPOrInvalidSim);
		}

		// Token: 0x06009120 RID: 37152 RVA: 0x0088FE50 File Offset: 0x0088E050
		public override void SetupDependencies()
		{
			short num = (short)1643776468;
			short num2 = num;
			num = (short)1974077908;
			switch (num2 == num)
			{
			}
			num = (short)699138049;
			if (num != 0)
			{
			}
			num = (short)784465920;
			if (num != 0)
			{
			}
			num = (short)53215232;
			short num3 = num;
			this.radioErgoConfigACActionType_A42871.AddDependentObject(this.radioErgoConfigACGeneralActionAllowed_A36579);
			this.radioErgoConfigACActionType_A42871.AddDependentObject(this.radioErgoConfigACRelayPattern_A36582);
			this.RefRadioWide.LightbarPattern.RadWideUniversalRelayControllerEquipped_A37191.AddDependentObject(this.radioErgoConfigACRelayPattern_A36582);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radioErgoConfigACRelayPattern_A36582);
			this.radioErgoConfigACActionType_A42871.AddDependentObject(this.radioErgoConfigACRelayPatternErrStrategy_A36583);
			this.radioErgoConfigACRelayPattern_A36582.AddDependentObject(this.radioErgoConfigACRelayPatternErrStrategy_A36583);
			this.radioErgoConfigACActionType_A42871.AddDependentObject(this.radioErgoConfigACSirenType_A36584);
			this.RefRadioErgonomicsWide.PASiren.RadErgoWidePASirenSirenOperation_A9139.AddDependentObject(this.radioErgoConfigACSirenType_A36584);
			this.RefRadioErgonomicsWide.PASiren.RadErgoWidePASirenHiLoAirhornTones_A8200.AddDependentObject(this.radioErgoConfigACSirenType_A36584);
			this.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.AddDependentObject(this.radioErgoConfigACSirenType_A36584);
			this.radioErgoConfigACActionType_A42871.AddDependentObject(this.radioErgoConfigACSirenTypeErrStrategy_A36585);
			this.radioErgoConfigACSirenType_A36584.AddDependentObject(this.radioErgoConfigACSirenTypeErrStrategy_A36585);
			this.radioErgoConfigACActionType_A42871.AddDependentObject(this.radioErgoConfigACGpsReport_A36587);
			this.radioErgoConfigACActionType_A42871.AddDependentObject(this.radioErgoConfigACGpsReportErrStrategy_A36588);
			this.radioErgoConfigACGpsReport_A36587.AddDependentObject(this.radioErgoConfigACGpsReportErrStrategy_A36588);
			this.radioErgoConfigACActionType_A42871.AddDependentObject(this.radioErgoConfigAC3rdPartyNotification_A41510);
			this.radioErgoConfigACActionType_A42871.AddDependentObject(this.radioErgoConfigAC3rdPartyNotificationErrorStategy_A41516);
			this.radioErgoConfigAC3rdPartyNotification_A41510.AddDependentObject(this.radioErgoConfigAC3rdPartyNotificationErrorStategy_A41516);
		}

		// Token: 0x1700492B RID: 18731
		// (get) Token: 0x06009121 RID: 37153 RVA: 0x00890070 File Offset: 0x0088E270
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner GeneralLightbarPatternInnerSectionForRadioErgoConfigACRelayPattern_A36582
		{
			get
			{
				short num = (short)1509978312;
				short num2 = num;
				num = (short)149516488;
				switch (num2 == num)
				{
				}
				num = (short)795672577;
				if (num != 0)
				{
				}
				num = (short)765394944;
				if (num != 0)
				{
				}
				num = (short)140640256;
				short num3 = num;
				return this.radioErgoConfigACRelayPattern_A36582.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner;
			}
		}

		// Token: 0x1700492C RID: 18732
		// (get) Token: 0x06009122 RID: 37154 RVA: 0x0089012C File Offset: 0x0088E32C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1079330837;
				short num2 = num;
				num = (short)1383614485;
				switch (num2 == num)
				{
				}
				num = (short)1843855361;
				if (num != 0)
				{
				}
				num = (short)1731067904;
				if (num != 0)
				{
				}
				num = (short)1283784704;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x1700492D RID: 18733
		// (get) Token: 0x06009123 RID: 37155 RVA: 0x008901DC File Offset: 0x0088E3DC
		// (set) Token: 0x06009124 RID: 37156 RVA: 0x0089028C File Offset: 0x0088E48C
		public bool RadioErgoConfigACGeneralActionAllowed_A36579Value
		{
			get
			{
				short num = (short)527484649;
				short num2 = num;
				num = (short)2061485801;
				switch (num2 == num)
				{
				}
				num = (short)608305153;
				if (num != 0)
				{
				}
				num = (short)2091253760;
				if (num != 0)
				{
				}
				num = (short)1457127424;
				short num3 = num;
				return this.radioErgoConfigACGeneralActionAllowed_A36579.Value;
			}
			set
			{
				short num = (short)333669629;
				short num2 = num;
				num = (short)79127805;
				switch (num2 == num)
				{
				}
				num = (short)1322844161;
				if (num != 0)
				{
				}
				num = (short)516882432;
				if (num != 0)
				{
				}
				num = (short)823394304;
				short num3 = num;
				this.radioErgoConfigACGeneralActionAllowed_A36579.Value = value;
			}
		}

		// Token: 0x1700492E RID: 18734
		// (get) Token: 0x06009125 RID: 37157 RVA: 0x00890340 File Offset: 0x0088E540
		public global::AcpBusinessLayer.AcpFieldX<bool, string> RadioErgoConfigACGeneralActionAllowed_A36579
		{
			get
			{
				short num = (short)1956967070;
				short num2 = num;
				num = (short)247394974;
				switch (num2 == num)
				{
				}
				num = (short)2118844417;
				if (num != 0)
				{
				}
				num = (short)1329070080;
				if (num != 0)
				{
				}
				num = (short)1871052800;
				short num3 = num;
				return this.radioErgoConfigACGeneralActionAllowed_A36579;
			}
		}

		// Token: 0x1700492F RID: 18735
		// (get) Token: 0x06009126 RID: 37158 RVA: 0x008903F0 File Offset: 0x0088E5F0
		// (set) Token: 0x06009127 RID: 37159 RVA: 0x008904A8 File Offset: 0x0088E6A8
		public string RadioErgoConfigACGeneralActionAllowed_A36579_UIValue
		{
			get
			{
				short num = (short)1940016534;
				short num2 = num;
				num = (short)269700502;
				switch (num2 == num)
				{
				}
				num = (short)746586113;
				if (num != 0)
				{
				}
				num = (short)1478033408;
				if (num != 0)
				{
				}
				num = (short)935460864;
				short num3 = num;
				return this.radioErgoConfigACGeneralActionAllowed_A36579.UIValue;
			}
			set
			{
				short num = (short)740556801;
				if (num != 0)
				{
				}
				num = (short)1976959358;
				short num2 = num;
				num = (short)1868890494;
				switch (num2 == num)
				{
				}
				num = (short)637140992;
				if (num != 0)
				{
				}
				num = (short)1813905408;
				short num3 = num;
				this.radioErgoConfigACGeneralActionAllowed_A36579.UIValue = value;
			}
		}

		// Token: 0x17004930 RID: 18736
		// (get) Token: 0x06009128 RID: 37160 RVA: 0x00890560 File Offset: 0x0088E760
		// (set) Token: 0x06009129 RID: 37161 RVA: 0x00890614 File Offset: 0x0088E814
		public bool RadioErgoConfigACGeneralActionAllowed_A36579_Applicable
		{
			get
			{
				short num = (short)1003487233;
				if (num != 0)
				{
				}
				num = (short)568436491;
				short num2 = num;
				num = (short)1692903179;
				switch (num2 == num)
				{
				}
				num = (short)2028994560;
				if (num != 0)
				{
				}
				num = (short)1839267840;
				short num3 = num;
				return this.radioErgoConfigACGeneralActionAllowed_A36579.Applicable;
			}
			set
			{
				short num = (short)845356144;
				short num2 = num;
				num = (short)1053629552;
				switch (num2 == num)
				{
				}
				num = (short)1027145728;
				if (num != 0)
				{
				}
				num = (short)2130509825;
				if (num != 0)
				{
				}
				num = (short)1844248576;
				short num3 = num;
				this.radioErgoConfigACGeneralActionAllowed_A36579.Applicable = value;
			}
		}

		// Token: 0x17004931 RID: 18737
		// (get) Token: 0x0600912A RID: 37162 RVA: 0x008906C8 File Offset: 0x0088E8C8
		// (set) Token: 0x0600912B RID: 37163 RVA: 0x0089077C File Offset: 0x0088E97C
		public bool RadioErgoConfigACGeneralActionAllowed_A36579_Valid
		{
			get
			{
				short num = (short)1302499823;
				short num2 = num;
				num = (short)1584959983;
				switch (num2 == num)
				{
				}
				num = (short)1857748993;
				if (num != 0)
				{
				}
				num = (short)215547904;
				if (num != 0)
				{
				}
				num = (short)1112080384;
				short num3 = num;
				return this.radioErgoConfigACGeneralActionAllowed_A36579.Valid;
			}
			set
			{
				short num = (short)2037057994;
				short num2 = num;
				num = (short)110037450;
				switch (num2 == num)
				{
				}
				num = (short)1889533953;
				if (num != 0)
				{
				}
				num = (short)314048512;
				if (num != 0)
				{
				}
				num = (short)485294080;
				short num3 = num;
				this.radioErgoConfigACGeneralActionAllowed_A36579.Valid = value;
			}
		}

		// Token: 0x17004932 RID: 18738
		// (get) Token: 0x0600912C RID: 37164 RVA: 0x00890830 File Offset: 0x0088EA30
		// (set) Token: 0x0600912D RID: 37165 RVA: 0x008908E8 File Offset: 0x0088EAE8
		public bool RadioErgoConfigACGeneralActionAllowed_A36579_Visible
		{
			get
			{
				short num = (short)1829031276;
				short num2 = num;
				num = (short)1328336236;
				switch (num2 == num)
				{
				}
				num = (short)1331101697;
				if (num != 0)
				{
				}
				num = (short)1089863680;
				if (num != 0)
				{
				}
				num = (short)2114060288;
				short num3 = num;
				return this.radioErgoConfigACGeneralActionAllowed_A36579.Visible;
			}
			set
			{
				short num = (short)1401620098;
				short num2 = num;
				num = (short)129304194;
				switch (num2 == num)
				{
				}
				num = (short)1431044097;
				if (num != 0)
				{
				}
				num = (short)862650368;
				if (num != 0)
				{
				}
				num = (short)1096876032;
				short num3 = num;
				this.radioErgoConfigACGeneralActionAllowed_A36579.Visible = value;
			}
		}

		// Token: 0x17004933 RID: 18739
		// (get) Token: 0x0600912E RID: 37166 RVA: 0x0089099C File Offset: 0x0088EB9C
		// (set) Token: 0x0600912F RID: 37167 RVA: 0x00890A50 File Offset: 0x0088EC50
		public bool RadioErgoConfigACGeneralActionAllowed_A36579_Editable
		{
			get
			{
				short num = (short)1802698752;
				short num2 = num;
				num = (short)186412713;
				short num3 = num;
				num = (short)1575710377;
				switch (num3 == num)
				{
				}
				num = (short)244449281;
				if (num != 0)
				{
				}
				num = (short)1814429696;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralActionAllowed_A36579.Editable;
			}
			set
			{
				short num = (short)1629159424;
				short num2 = num;
				num = (short)767033345;
				if (num != 0)
				{
				}
				num = (short)1943987946;
				short num3 = num;
				num = (short)1726736106;
				switch (num3 == num)
				{
				}
				num = (short)1065680896;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralActionAllowed_A36579.Editable = value;
			}
		}

		// Token: 0x17004934 RID: 18740
		// (get) Token: 0x06009130 RID: 37168 RVA: 0x00890B04 File Offset: 0x0088ED04
		internal string RadioErgoConfigACGeneralActionAllowed_A36579_UILabel
		{
			get
			{
				short num = (short)1229324288;
				short num2 = num;
				num = (short)283933984;
				short num3 = num;
				num = (short)474250528;
				switch (num3 == num)
				{
				}
				num = (short)867565568;
				if (num != 0)
				{
				}
				num = (short)965017601;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralActionAllowed_A36579.UIName;
			}
		}

		// Token: 0x17004935 RID: 18741
		// (get) Token: 0x06009131 RID: 37169 RVA: 0x00890BB8 File Offset: 0x0088EDB8
		// (set) Token: 0x06009132 RID: 37170 RVA: 0x00890C70 File Offset: 0x0088EE70
		internal bool RadioErgoConfigACGeneralActionAllowed_A36579_HiddenStatic
		{
			get
			{
				short num = (short)1288634368;
				short num2 = num;
				num = (short)310166473;
				short num3 = num;
				num = (short)78037961;
				switch (num3 == num)
				{
				}
				num = (short)1911554049;
				if (num != 0)
				{
				}
				num = (short)1238827008;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralActionAllowed_A36579.HiddenStatic;
			}
			set
			{
				short num = (short)702611456;
				short num2 = num;
				num = (short)1741088557;
				short num3 = num;
				num = (short)1137764141;
				switch (num3 == num)
				{
				}
				num = (short)1020329984;
				if (num != 0)
				{
				}
				num = (short)593821697;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralActionAllowed_A36579.HiddenStatic = value;
			}
		}

		// Token: 0x17004936 RID: 18742
		// (get) Token: 0x06009133 RID: 37171 RVA: 0x00890D2C File Offset: 0x0088EF2C
		// (set) Token: 0x06009134 RID: 37172 RVA: 0x00890DE4 File Offset: 0x0088EFE4
		internal bool RadioErgoConfigACGeneralActionAllowed_A36579_HiddenDynamic
		{
			get
			{
				short num = (short)1678573568;
				short num2 = num;
				num = (short)557842433;
				if (num != 0)
				{
				}
				num = (short)967956591;
				short num3 = num;
				num = (short)178706543;
				switch (num3 == num)
				{
				}
				num = (short)2095841280;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralActionAllowed_A36579.HiddenDynamic;
			}
			set
			{
				short num = (short)79448777;
				short num2 = num;
				num = (short)623659721;
				switch (num2 == num)
				{
				}
				num = (short)406847488;
				short num3 = num;
				num = (short)529137664;
				if (num != 0)
				{
				}
				num = (short)440664065;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGeneralActionAllowed_A36579.HiddenDynamic = value;
			}
		}

		// Token: 0x17004937 RID: 18743
		// (get) Token: 0x06009135 RID: 37173 RVA: 0x00890E9C File Offset: 0x0088F09C
		public bool RadioErgoConfigACGeneralActionAllowed_A36579_HasDiffs
		{
			get
			{
				short num = (short)1256749112;
				short num2 = num;
				num = (short)498890808;
				switch (num2 == num)
				{
				}
				num = (short)436994048;
				short num3 = num;
				num = (short)924581889;
				if (num != 0)
				{
				}
				num = (short)2121728000;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGeneralActionAllowed_A36579._HasDiffs;
			}
		}

		// Token: 0x17004938 RID: 18744
		// (get) Token: 0x06009136 RID: 37174 RVA: 0x00890F50 File Offset: 0x0088F150
		// (set) Token: 0x06009137 RID: 37175 RVA: 0x00891000 File Offset: 0x0088F200
		public string RadioErgoConfigACName_A36581Value
		{
			get
			{
				short num = (short)575693661;
				short num2 = num;
				num = (short)139617117;
				switch (num2 == num)
				{
				}
				num = (short)1512374272;
				short num3 = num;
				num = (short)1377763328;
				if (num != 0)
				{
				}
				num = (short)1211957249;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACName_A36581.Value;
			}
			set
			{
				short num = (short)730660866;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)891019884;
					short num3 = num;
					num = (short)424534636;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1817509888;
						if (num != 0)
						{
						}
						num = (short)566231040;
						short num4 = num;
						switch (num2)
						{
						case 0:
							goto IL_CE;
						case 1:
							return;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_A7;
							}
							continue;
						}
						IL_A7:
						if (!string.IsNullOrEmpty(value.Trim()))
						{
							num = (short)1562378240;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					}
					IL_CE:
					num = (short)33292289;
					if (num != 0)
					{
					}
					this.radioErgoConfigACName_A36581.Value = value;
					num = (short)1817968641;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17004939 RID: 18745
		// (get) Token: 0x06009138 RID: 37176 RVA: 0x00891128 File Offset: 0x0088F328
		// (set) Token: 0x06009139 RID: 37177 RVA: 0x008911E0 File Offset: 0x0088F3E0
		public string RadioErgoConfigACName_A36581_UIValue
		{
			get
			{
				short num = (short)1696814620;
				short num2 = num;
				num = (short)1005147676;
				switch (num2 == num)
				{
				}
				num = (short)2000945152;
				short num3 = num;
				num = (short)1045168129;
				if (num != 0)
				{
				}
				num = (short)757399552;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACName_A36581.Value;
			}
			set
			{
				short num = (short)714615406;
				short num2 = num;
				num = (short)618736238;
				switch (num2 == num)
				{
				}
				num = (short)2034958336;
				short num3 = num;
				num = (short)1971453953;
				if (num != 0)
				{
				}
				num = (short)823918592;
				if (num != 0)
				{
				}
				this.radioErgoConfigACName_A36581.Value = value;
			}
		}

		// Token: 0x1700493A RID: 18746
		// (get) Token: 0x0600913A RID: 37178 RVA: 0x00891294 File Offset: 0x0088F494
		public global::AcpBusinessLayer.AcpKeyField RadioErgoConfigACName_A36581
		{
			get
			{
				short num = (short)715921206;
				short num2 = num;
				num = (short)44963638;
				switch (num2 == num)
				{
				}
				num = (short)877789184;
				short num3 = num;
				num = (short)1507328;
				if (num != 0)
				{
				}
				num = (short)1318846465;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACName_A36581;
			}
		}

		// Token: 0x1700493B RID: 18747
		// (get) Token: 0x0600913B RID: 37179 RVA: 0x00891344 File Offset: 0x0088F544
		// (set) Token: 0x0600913C RID: 37180 RVA: 0x008913F8 File Offset: 0x0088F5F8
		public bool RadioErgoConfigACName_A36581_Applicable
		{
			get
			{
				short num = (short)1481310209;
				if (num != 0)
				{
				}
				num = (short)1119087165;
				short num2 = num;
				num = (short)18344509;
				switch (num2 == num)
				{
				default:
				{
					num = (short)515440640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1537343488;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACName_A36581.Applicable;
			}
			set
			{
				short num = (short)1584865925;
				short num2 = num;
				num = (short)442442373;
				switch (num2 == num)
				{
				}
				num = (short)153157632;
				short num3 = num;
				num = (short)456589313;
				if (num != 0)
				{
				}
				num = (short)597884928;
				if (num != 0)
				{
				}
				this.radioErgoConfigACName_A36581.Applicable = value;
			}
		}

		// Token: 0x1700493C RID: 18748
		// (get) Token: 0x0600913D RID: 37181 RVA: 0x008914B0 File Offset: 0x0088F6B0
		// (set) Token: 0x0600913E RID: 37182 RVA: 0x00891564 File Offset: 0x0088F764
		public bool RadioErgoConfigACName_A36581_Valid
		{
			get
			{
				short num = (short)1439864881;
				short num2 = num;
				num = (short)2058393649;
				switch (num2 == num)
				{
				}
				num = (short)668073984;
				short num3 = num;
				num = (short)1421606912;
				if (num != 0)
				{
				}
				num = (short)1433993217;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACName_A36581.Valid;
			}
			set
			{
				short num = (short)1496111107;
				short num2 = num;
				num = (short)822335491;
				switch (num2 == num)
				{
				}
				num = (short)324468736;
				short num3 = num;
				num = (short)244252672;
				if (num != 0)
				{
				}
				num = (short)1575944193;
				if (num != 0)
				{
				}
				this.radioErgoConfigACName_A36581.Valid = value;
			}
		}

		// Token: 0x1700493D RID: 18749
		// (get) Token: 0x0600913F RID: 37183 RVA: 0x00891618 File Offset: 0x0088F818
		// (set) Token: 0x06009140 RID: 37184 RVA: 0x008916CC File Offset: 0x0088F8CC
		public bool RadioErgoConfigACName_A36581_Visible
		{
			get
			{
				short num = (short)884278415;
				short num2 = num;
				num = (short)1572275343;
				switch (num2 == num)
				{
				}
				num = (short)1578434560;
				short num3 = num;
				num = (short)1829044225;
				if (num != 0)
				{
				}
				num = (short)988217344;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACName_A36581.Visible;
			}
			set
			{
				short num = (short)955411422;
				short num2 = num;
				num = (short)2107337694;
				switch (num2 == num)
				{
				}
				num = (short)20316160;
				short num3 = num;
				num = (short)1199570945;
				if (num != 0)
				{
				}
				num = (short)826605568;
				if (num != 0)
				{
				}
				this.radioErgoConfigACName_A36581.Visible = value;
			}
		}

		// Token: 0x1700493E RID: 18750
		// (get) Token: 0x06009141 RID: 37185 RVA: 0x00891784 File Offset: 0x0088F984
		// (set) Token: 0x06009142 RID: 37186 RVA: 0x00891838 File Offset: 0x0088FA38
		public bool RadioErgoConfigACName_A36581_Editable
		{
			get
			{
				short num = (short)1324657859;
				short num2 = num;
				num = (short)1228516547;
				switch (num2 == num)
				{
				}
				num = (short)1988689920;
				short num3 = num;
				num = (short)283574273;
				if (num != 0)
				{
				}
				num = (short)394002432;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACName_A36581.Editable;
			}
			set
			{
				short num = (short)1228144641;
				if (num != 0)
				{
				}
				num = (short)347716997;
				short num2 = num;
				num = (short)1914158469;
				switch (num2 == num)
				{
				default:
				{
					num = (short)179109888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1250164736;
				if (num != 0)
				{
				}
				this.radioErgoConfigACName_A36581.Editable = value;
			}
		}

		// Token: 0x1700493F RID: 18751
		// (get) Token: 0x06009143 RID: 37187 RVA: 0x008918EC File Offset: 0x0088FAEC
		internal string RadioErgoConfigACName_A36581_UILabel
		{
			get
			{
				short num = (short)502792193;
				if (num != 0)
				{
				}
				num = (short)1111820309;
				short num2 = num;
				num = (short)65538069;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1615527936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)951320576;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACName_A36581.UIName;
			}
		}

		// Token: 0x17004940 RID: 18752
		// (get) Token: 0x06009144 RID: 37188 RVA: 0x008919A0 File Offset: 0x0088FBA0
		// (set) Token: 0x06009145 RID: 37189 RVA: 0x00891A54 File Offset: 0x0088FC54
		internal bool RadioErgoConfigACName_A36581_HiddenStatic
		{
			get
			{
				short num = (short)1191407988;
				short num2 = num;
				num = (short)1421439348;
				switch (num2 == num)
				{
				}
				num = (short)1932263424;
				short num3 = num;
				num = (short)610664448;
				if (num != 0)
				{
				}
				num = (short)1725235201;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACName_A36581.HiddenStatic;
			}
			set
			{
				short num = (short)269877315;
				short num2 = num;
				num = (short)1612120131;
				switch (num2 == num)
				{
				}
				num = (short)252510208;
				short num3 = num;
				num = (short)1583808513;
				if (num != 0)
				{
				}
				num = (short)752877568;
				if (num != 0)
				{
				}
				this.radioErgoConfigACName_A36581.HiddenStatic = value;
			}
		}

		// Token: 0x17004941 RID: 18753
		// (get) Token: 0x06009146 RID: 37190 RVA: 0x00891B0C File Offset: 0x0088FD0C
		// (set) Token: 0x06009147 RID: 37191 RVA: 0x00891BC0 File Offset: 0x0088FDC0
		internal bool RadioErgoConfigACName_A36581_HiddenDynamic
		{
			get
			{
				short num = (short)639073344;
				short num2 = num;
				num = (short)848264256;
				switch (num2 == num)
				{
				}
				num = (short)1878523904;
				short num3 = num;
				num = (short)1756692480;
				if (num != 0)
				{
				}
				num = (short)1675821057;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACName_A36581.HiddenDynamic;
			}
			set
			{
				short num = (short)1875134505;
				short num2 = num;
				num = (short)1486440489;
				switch (num2 == num)
				{
				}
				num = (short)1923284992;
				short num3 = num;
				num = (short)151781377;
				if (num != 0)
				{
				}
				num = (short)1103429632;
				if (num != 0)
				{
				}
				this.radioErgoConfigACName_A36581.HiddenDynamic = value;
			}
		}

		// Token: 0x17004942 RID: 18754
		// (get) Token: 0x06009148 RID: 37192 RVA: 0x00891C78 File Offset: 0x0088FE78
		public bool RadioErgoConfigACName_A36581_HasDiffs
		{
			get
			{
				short num = (short)1039329558;
				short num2 = num;
				num = (short)1502013718;
				switch (num2 == num)
				{
				}
				num = (short)1628700672;
				short num3 = num;
				num = (short)1351024641;
				if (num != 0)
				{
				}
				num = (short)939655168;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACName_A36581._HasDiffs;
			}
		}

		// Token: 0x17004943 RID: 18755
		// (get) Token: 0x06009149 RID: 37193 RVA: 0x00891D2C File Offset: 0x0088FF2C
		// (set) Token: 0x0600914A RID: 37194 RVA: 0x00891DE0 File Offset: 0x0088FFE0
		public int RadioErgoConfigACRelayPattern_A36582Value
		{
			get
			{
				short num = (short)902199947;
				short num2 = num;
				num = (short)1129806475;
				switch (num2 == num)
				{
				}
				num = (short)545062912;
				short num3 = num;
				num = (short)178323457;
				if (num != 0)
				{
				}
				num = (short)924319744;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACRelayPattern_A36582.Value;
			}
			set
			{
				short num = (short)2040948369;
				short num2 = num;
				num = (short)171206289;
				switch (num2 == num)
				{
				}
				num = (short)1763770368;
				short num3 = num;
				num = (short)1337065472;
				if (num != 0)
				{
				}
				num = (short)1452736513;
				if (num != 0)
				{
				}
				this.radioErgoConfigACRelayPattern_A36582.Value = value;
			}
		}

		// Token: 0x17004944 RID: 18756
		// (get) Token: 0x0600914B RID: 37195 RVA: 0x00891E94 File Offset: 0x00890094
		// (set) Token: 0x0600914C RID: 37196 RVA: 0x00891F48 File Offset: 0x00890148
		public string RadioErgoConfigACRelayPattern_A36582_UIValue
		{
			get
			{
				short num = (short)333040863;
				short num2 = num;
				num = (short)262917343;
				switch (num2 == num)
				{
				}
				num = (short)333381632;
				short num3 = num;
				num = (short)838860800;
				if (num != 0)
				{
				}
				num = (short)151977985;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACRelayPattern_A36582.UIValue;
			}
			set
			{
				short num = (short)1806421618;
				short num2 = num;
				num = (short)941018738;
				switch (num2 == num)
				{
				}
				num = (short)628883456;
				short num3 = num;
				num = (short)1093795841;
				if (num != 0)
				{
				}
				num = (short)1012596736;
				if (num != 0)
				{
				}
				this.radioErgoConfigACRelayPattern_A36582.UIValue = value;
			}
		}

		// Token: 0x17004945 RID: 18757
		// (get) Token: 0x0600914D RID: 37197 RVA: 0x00891FFC File Offset: 0x008901FC
		public global::AcpBusinessLayer.AcpRecRefField RadioErgoConfigACRelayPattern_A36582
		{
			get
			{
				short num = (short)1698470886;
				short num2 = num;
				num = (short)411212774;
				switch (num2 == num)
				{
				}
				num = (short)1381236736;
				short num3 = num;
				num = (short)2143879169;
				if (num != 0)
				{
				}
				num = (short)2047016960;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACRelayPattern_A36582;
			}
		}

		// Token: 0x17004946 RID: 18758
		// (get) Token: 0x0600914E RID: 37198 RVA: 0x008920AC File Offset: 0x008902AC
		// (set) Token: 0x0600914F RID: 37199 RVA: 0x00892160 File Offset: 0x00890360
		public bool RadioErgoConfigACRelayPattern_A36582_Applicable
		{
			get
			{
				short num = (short)1679660624;
				short num2 = num;
				num = (short)229480016;
				switch (num2 == num)
				{
				}
				num = (short)1332477952;
				short num3 = num;
				num = (short)1939865600;
				if (num != 0)
				{
				}
				num = (short)74973185;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACRelayPattern_A36582.Applicable;
			}
			set
			{
				short num = (short)990881935;
				short num2 = num;
				num = (short)2044962959;
				switch (num2 == num)
				{
				}
				num = (short)1925316608;
				short num3 = num;
				num = (short)289210369;
				if (num != 0)
				{
				}
				num = (short)1419378688;
				if (num != 0)
				{
				}
				this.radioErgoConfigACRelayPattern_A36582.Applicable = value;
			}
		}

		// Token: 0x17004947 RID: 18759
		// (get) Token: 0x06009150 RID: 37200 RVA: 0x00892218 File Offset: 0x00890418
		// (set) Token: 0x06009151 RID: 37201 RVA: 0x008922CC File Offset: 0x008904CC
		public bool RadioErgoConfigACRelayPattern_A36582_Valid
		{
			get
			{
				short num = (short)1908815887;
				short num2 = num;
				num = (short)1605122063;
				switch (num2 == num)
				{
				}
				num = (short)1823145984;
				short num3 = num;
				num = (short)1123549185;
				if (num != 0)
				{
				}
				num = (short)762445824;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACRelayPattern_A36582.Valid;
			}
			set
			{
				short num = (short)517549223;
				short num2 = num;
				num = (short)514731175;
				switch (num2 == num)
				{
				}
				num = (short)1509949440;
				short num3 = num;
				num = (short)1696137217;
				if (num != 0)
				{
				}
				num = (short)132775936;
				if (num != 0)
				{
				}
				this.radioErgoConfigACRelayPattern_A36582.Valid = value;
			}
		}

		// Token: 0x17004948 RID: 18760
		// (get) Token: 0x06009152 RID: 37202 RVA: 0x00892384 File Offset: 0x00890584
		// (set) Token: 0x06009153 RID: 37203 RVA: 0x0089243C File Offset: 0x0089063C
		public bool RadioErgoConfigACRelayPattern_A36582_Visible
		{
			get
			{
				short num = (short)444768843;
				short num2 = num;
				num = (short)382902859;
				switch (num2 == num)
				{
				}
				num = (short)1669267456;
				short num3 = num;
				num = (short)702676993;
				if (num != 0)
				{
				}
				num = (short)1514405888;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACRelayPattern_A36582.Visible;
			}
			set
			{
				short num = (short)1271219085;
				short num2 = num;
				num = (short)836453261;
				switch (num2 == num)
				{
				}
				num = (short)1434845184;
				short num3 = num;
				num = (short)657719296;
				if (num != 0)
				{
				}
				num = (short)977403905;
				if (num != 0)
				{
				}
				this.radioErgoConfigACRelayPattern_A36582.Visible = value;
			}
		}

		// Token: 0x17004949 RID: 18761
		// (get) Token: 0x06009154 RID: 37204 RVA: 0x008924F4 File Offset: 0x008906F4
		// (set) Token: 0x06009155 RID: 37205 RVA: 0x008925AC File Offset: 0x008907AC
		public bool RadioErgoConfigACRelayPattern_A36582_Editable
		{
			get
			{
				short num = (short)76575188;
				short num2 = num;
				num = (short)157643220;
				switch (num2 == num)
				{
				}
				num = (short)453115904;
				short num3 = num;
				num = (short)982056961;
				if (num != 0)
				{
				}
				num = (short)2086862848;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACRelayPattern_A36582.Editable;
			}
			set
			{
				short num = (short)1619576225;
				short num2 = num;
				num = (short)923518369;
				switch (num2 == num)
				{
				}
				num = (short)836304896;
				short num3 = num;
				num = (short)1047068673;
				if (num != 0)
				{
				}
				num = (short)85655552;
				if (num != 0)
				{
				}
				this.radioErgoConfigACRelayPattern_A36582.Editable = value;
			}
		}

		// Token: 0x1700494A RID: 18762
		// (get) Token: 0x06009156 RID: 37206 RVA: 0x00892664 File Offset: 0x00890864
		internal string RadioErgoConfigACRelayPattern_A36582_UILabel
		{
			get
			{
				short num = (short)1942931741;
				short num2 = num;
				num = (short)209963293;
				switch (num2 == num)
				{
				}
				num = (short)2043609088;
				short num3 = num;
				num = (short)418775041;
				if (num != 0)
				{
				}
				num = (short)1336999936;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACRelayPattern_A36582.UIName;
			}
		}

		// Token: 0x1700494B RID: 18763
		// (get) Token: 0x06009157 RID: 37207 RVA: 0x00892718 File Offset: 0x00890918
		// (set) Token: 0x06009158 RID: 37208 RVA: 0x008927D0 File Offset: 0x008909D0
		internal bool RadioErgoConfigACRelayPattern_A36582_HiddenStatic
		{
			get
			{
				short num = (short)1690603932;
				short num2 = num;
				num = (short)1673040284;
				switch (num2 == num)
				{
				}
				num = (short)1067646976;
				short num3 = num;
				num = (short)1108213760;
				if (num != 0)
				{
				}
				num = (short)2113929217;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACRelayPattern_A36582.HiddenStatic;
			}
			set
			{
				short num = (short)1956056427;
				short num2 = num;
				num = (short)1925844331;
				switch (num2 == num)
				{
				}
				num = (short)332201984;
				short num3 = num;
				num = (short)949682177;
				if (num != 0)
				{
				}
				num = (short)620298240;
				if (num != 0)
				{
				}
				this.radioErgoConfigACRelayPattern_A36582.HiddenStatic = value;
			}
		}

		// Token: 0x1700494C RID: 18764
		// (get) Token: 0x06009159 RID: 37209 RVA: 0x00892884 File Offset: 0x00890A84
		// (set) Token: 0x0600915A RID: 37210 RVA: 0x00892938 File Offset: 0x00890B38
		internal bool RadioErgoConfigACRelayPattern_A36582_HiddenDynamic
		{
			get
			{
				short num = (short)11232680;
				short num2 = num;
				num = (short)1164076456;
				switch (num2 == num)
				{
				}
				num = (short)252968960;
				short num3 = num;
				num = (short)2023227392;
				if (num != 0)
				{
				}
				num = (short)1696858113;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACRelayPattern_A36582.HiddenDynamic;
			}
			set
			{
				short num = (short)627011789;
				short num2 = num;
				num = (short)988246221;
				switch (num2 == num)
				{
				}
				num = (short)299761664;
				short num3 = num;
				num = (short)244121600;
				if (num != 0)
				{
				}
				num = (short)1673592833;
				if (num != 0)
				{
				}
				this.radioErgoConfigACRelayPattern_A36582.HiddenDynamic = value;
			}
		}

		// Token: 0x1700494D RID: 18765
		// (get) Token: 0x0600915B RID: 37211 RVA: 0x008929EC File Offset: 0x00890BEC
		public bool RadioErgoConfigACRelayPattern_A36582_HasDiffs
		{
			get
			{
				short num = (short)632306318;
				short num2 = num;
				num = (short)390740622;
				switch (num2 == num)
				{
				}
				num = (short)1373110272;
				short num3 = num;
				num = (short)1032847361;
				if (num != 0)
				{
				}
				num = (short)383057920;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACRelayPattern_A36582._HasDiffs;
			}
		}

		// Token: 0x1700494E RID: 18766
		// (get) Token: 0x0600915C RID: 37212 RVA: 0x00892AA4 File Offset: 0x00890CA4
		// (set) Token: 0x0600915D RID: 37213 RVA: 0x00892B58 File Offset: 0x00890D58
		public int RadioErgoConfigACRelayPatternErrStrategy_A36583Value
		{
			get
			{
				short num = (short)863492968;
				short num2 = num;
				num = (short)110156648;
				switch (num2 == num)
				{
				}
				num = (short)1671626752;
				short num3 = num;
				num = (short)512491521;
				if (num != 0)
				{
				}
				num = (short)1271398400;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACRelayPatternErrStrategy_A36583.Value;
			}
			set
			{
				short num = (short)863789912;
				short num2 = num;
				num = (short)835871576;
				switch (num2 == num)
				{
				}
				num = (short)1345519616;
				short num3 = num;
				num = (short)2113667073;
				if (num != 0)
				{
				}
				num = (short)1583087616;
				if (num != 0)
				{
				}
				this.radioErgoConfigACRelayPatternErrStrategy_A36583.Value = value;
			}
		}

		// Token: 0x1700494F RID: 18767
		// (get) Token: 0x0600915E RID: 37214 RVA: 0x00892C0C File Offset: 0x00890E0C
		// (set) Token: 0x0600915F RID: 37215 RVA: 0x00892CC4 File Offset: 0x00890EC4
		public string RadioErgoConfigACRelayPatternErrStrategy_A36583_UIValue
		{
			get
			{
				short num = (short)366403321;
				short num2 = num;
				num = (short)1748819705;
				switch (num2 == num)
				{
				}
				num = (short)1037565952;
				short num3 = num;
				num = (short)1791229953;
				if (num != 0)
				{
				}
				num = (short)1106771968;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACRelayPatternErrStrategy_A36583.UIValue;
			}
			set
			{
				short num = (short)1403064026;
				short num2 = num;
				num = (short)1215303386;
				switch (num2 == num)
				{
				}
				num = (short)45744128;
				short num3 = num;
				num = (short)246153217;
				if (num != 0)
				{
				}
				num = (short)1978007552;
				if (num != 0)
				{
				}
				this.radioErgoConfigACRelayPatternErrStrategy_A36583.UIValue = value;
			}
		}

		// Token: 0x17004950 RID: 18768
		// (get) Token: 0x06009160 RID: 37216 RVA: 0x00892D78 File Offset: 0x00890F78
		public global::AcpBusinessLayer.AcpListField RadioErgoConfigACRelayPatternErrStrategy_A36583
		{
			get
			{
				short num = (short)954942572;
				short num2 = num;
				num = (short)1875657836;
				switch (num2 == num)
				{
				}
				num = (short)2064908288;
				short num3 = num;
				num = (short)1044971520;
				if (num != 0)
				{
				}
				num = (short)1698824193;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACRelayPatternErrStrategy_A36583;
			}
		}

		// Token: 0x17004951 RID: 18769
		// (get) Token: 0x06009161 RID: 37217 RVA: 0x00892E24 File Offset: 0x00891024
		// (set) Token: 0x06009162 RID: 37218 RVA: 0x00892EDC File Offset: 0x008910DC
		public bool RadioErgoConfigACRelayPatternErrStrategy_A36583_Applicable
		{
			get
			{
				short num = (short)1431342431;
				short num2 = num;
				num = (short)256871775;
				switch (num2 == num)
				{
				}
				num = (short)979369984;
				short num3 = num;
				num = (short)671285248;
				if (num != 0)
				{
				}
				num = (short)2131951617;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACRelayPatternErrStrategy_A36583.Applicable;
			}
			set
			{
				short num = (short)1737596396;
				short num2 = num;
				num = (short)761324;
				switch (num2 == num)
				{
				}
				num = (short)1770389504;
				short num3 = num;
				num = (short)602800128;
				if (num != 0)
				{
				}
				num = (short)483721217;
				if (num != 0)
				{
				}
				this.radioErgoConfigACRelayPatternErrStrategy_A36583.Applicable = value;
			}
		}

		// Token: 0x17004952 RID: 18770
		// (get) Token: 0x06009163 RID: 37219 RVA: 0x00892F94 File Offset: 0x00891194
		// (set) Token: 0x06009164 RID: 37220 RVA: 0x00893048 File Offset: 0x00891248
		public bool RadioErgoConfigACRelayPatternErrStrategy_A36583_Valid
		{
			get
			{
				short num = (short)46268417;
				if (num != 0)
				{
				}
				num = (short)501620905;
				short num2 = num;
				num = (short)294789289;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2100887552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)670760960;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACRelayPatternErrStrategy_A36583.Valid;
			}
			set
			{
				short num = (short)687884541;
				short num2 = num;
				num = (short)424757501;
				switch (num2 == num)
				{
				}
				num = (short)2023686144;
				short num3 = num;
				num = (short)1955594241;
				if (num != 0)
				{
				}
				num = (short)1658650624;
				if (num != 0)
				{
				}
				this.radioErgoConfigACRelayPatternErrStrategy_A36583.Valid = value;
			}
		}

		// Token: 0x17004953 RID: 18771
		// (get) Token: 0x06009165 RID: 37221 RVA: 0x008930FC File Offset: 0x008912FC
		// (set) Token: 0x06009166 RID: 37222 RVA: 0x008931B4 File Offset: 0x008913B4
		public bool RadioErgoConfigACRelayPatternErrStrategy_A36583_Visible
		{
			get
			{
				short num = (short)2101346305;
				if (num != 0)
				{
				}
				num = (short)839607955;
				short num2 = num;
				num = (short)625370771;
				switch (num2 == num)
				{
				default:
				{
					num = (short)500891648;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)747765760;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACRelayPatternErrStrategy_A36583.Visible;
			}
			set
			{
				short num = (short)925136245;
				short num2 = num;
				num = (short)354186613;
				switch (num2 == num)
				{
				}
				num = (short)826408960;
				short num3 = num;
				num = (short)801374209;
				if (num != 0)
				{
				}
				num = (short)685703168;
				if (num != 0)
				{
				}
				this.radioErgoConfigACRelayPatternErrStrategy_A36583.Visible = value;
			}
		}

		// Token: 0x17004954 RID: 18772
		// (get) Token: 0x06009167 RID: 37223 RVA: 0x00893268 File Offset: 0x00891468
		// (set) Token: 0x06009168 RID: 37224 RVA: 0x0089331C File Offset: 0x0089151C
		public bool RadioErgoConfigACRelayPatternErrStrategy_A36583_Editable
		{
			get
			{
				short num = (short)1984789724;
				short num2 = num;
				num = (short)1358724316;
				switch (num2 == num)
				{
				}
				num = (short)1136459776;
				short num3 = num;
				num = (short)225050625;
				if (num != 0)
				{
				}
				num = (short)1659174912;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACRelayPatternErrStrategy_A36583.Editable;
			}
			set
			{
				short num = (short)949962633;
				short num2 = num;
				num = (short)707807113;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1794637824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)15335425;
				if (num != 0)
				{
				}
				num = (short)1475018752;
				if (num != 0)
				{
				}
				this.radioErgoConfigACRelayPatternErrStrategy_A36583.Editable = value;
			}
		}

		// Token: 0x17004955 RID: 18773
		// (get) Token: 0x06009169 RID: 37225 RVA: 0x008933D0 File Offset: 0x008915D0
		internal string RadioErgoConfigACRelayPatternErrStrategy_A36583_UILabel
		{
			get
			{
				short num = (short)203661059;
				short num2 = num;
				num = (short)712417027;
				switch (num2 == num)
				{
				default:
				{
					num = (short)364314624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)109903873;
				if (num != 0)
				{
				}
				num = (short)129957888;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACRelayPatternErrStrategy_A36583.UIName;
			}
		}

		// Token: 0x17004956 RID: 18774
		// (get) Token: 0x0600916A RID: 37226 RVA: 0x00893488 File Offset: 0x00891688
		// (set) Token: 0x0600916B RID: 37227 RVA: 0x0089353C File Offset: 0x0089173C
		internal bool RadioErgoConfigACRelayPatternErrStrategy_A36583_HiddenStatic
		{
			get
			{
				short num = (short)1536880472;
				short num2 = num;
				num = (short)672722776;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1369178112;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)301137920;
				if (num != 0)
				{
				}
				num = (short)2083192833;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACRelayPatternErrStrategy_A36583.HiddenStatic;
			}
			set
			{
				short num = (short)118345789;
				short num2 = num;
				num = (short)394842173;
				switch (num2 == num)
				{
				default:
				{
					num = (short)757268480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)344326145;
				if (num != 0)
				{
				}
				num = (short)1417347072;
				if (num != 0)
				{
				}
				this.radioErgoConfigACRelayPatternErrStrategy_A36583.HiddenStatic = value;
			}
		}

		// Token: 0x17004957 RID: 18775
		// (get) Token: 0x0600916C RID: 37228 RVA: 0x008935F0 File Offset: 0x008917F0
		// (set) Token: 0x0600916D RID: 37229 RVA: 0x008936A8 File Offset: 0x008918A8
		internal bool RadioErgoConfigACRelayPatternErrStrategy_A36583_HiddenDynamic
		{
			get
			{
				short num = (short)391582118;
				short num2 = num;
				num = (short)1478562214;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2146041856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1319174144;
				if (num != 0)
				{
				}
				num = (short)94961665;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACRelayPatternErrStrategy_A36583.HiddenDynamic;
			}
			set
			{
				short num = (short)138122877;
				short num2 = num;
				num = (short)1730123389;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1778974720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1993146368;
				if (num != 0)
				{
				}
				num = (short)1839726593;
				if (num != 0)
				{
				}
				this.radioErgoConfigACRelayPatternErrStrategy_A36583.HiddenDynamic = value;
			}
		}

		// Token: 0x17004958 RID: 18776
		// (get) Token: 0x0600916E RID: 37230 RVA: 0x00893760 File Offset: 0x00891960
		public bool RadioErgoConfigACRelayPatternErrStrategy_A36583_HasDiffs
		{
			get
			{
				short num = (short)831656954;
				short num2 = num;
				num = (short)2068059130;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1128333312;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1261502465;
				if (num != 0)
				{
				}
				num = (short)1503592448;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACRelayPatternErrStrategy_A36583._HasDiffs;
			}
		}

		// Token: 0x17004959 RID: 18777
		// (get) Token: 0x0600916F RID: 37231 RVA: 0x00893810 File Offset: 0x00891A10
		// (set) Token: 0x06009170 RID: 37232 RVA: 0x008938C4 File Offset: 0x00891AC4
		public int RadioErgoConfigACSirenType_A36584Value
		{
			get
			{
				short num = (short)742850561;
				if (num != 0)
				{
				}
				num = (short)585891840;
				short num2 = num;
				num = (short)729266741;
				short num3 = num;
				num = (short)112245301;
				switch (num3 == num)
				{
				}
				num = (short)1890451456;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACSirenType_A36584.Value;
			}
			set
			{
				short num = (short)964465694;
				short num2 = num;
				num = (short)382309406;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1975779328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1489895425;
				if (num != 0)
				{
				}
				num = (short)1649541120;
				if (num != 0)
				{
				}
				this.radioErgoConfigACSirenType_A36584.Value = value;
			}
		}

		// Token: 0x1700495A RID: 18778
		// (get) Token: 0x06009171 RID: 37233 RVA: 0x0089397C File Offset: 0x00891B7C
		// (set) Token: 0x06009172 RID: 37234 RVA: 0x00893A30 File Offset: 0x00891C30
		public string RadioErgoConfigACSirenType_A36584_UIValue
		{
			get
			{
				short num = (short)567373478;
				short num2 = num;
				num = (short)2099867302;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1670184960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)652148736;
				if (num != 0)
				{
				}
				num = (short)2041905153;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACSirenType_A36584.UIValue;
			}
			set
			{
				short num = (short)5943853;
				short num2 = num;
				num = (short)1227862573;
				switch (num2 == num)
				{
				default:
				{
					num = (short)669908992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1865220097;
				if (num != 0)
				{
				}
				num = (short)936771584;
				if (num != 0)
				{
				}
				this.radioErgoConfigACSirenType_A36584.UIValue = value;
			}
		}

		// Token: 0x1700495B RID: 18779
		// (get) Token: 0x06009173 RID: 37235 RVA: 0x00893AE8 File Offset: 0x00891CE8
		public global::AcpBusinessLayer.AcpListField RadioErgoConfigACSirenType_A36584
		{
			get
			{
				short num = (short)1417871361;
				if (num != 0)
				{
				}
				num = (short)477560832;
				short num2 = num;
				num = (short)658568669;
				short num3 = num;
				num = (short)1265366493;
				switch (num3 == num)
				{
				}
				num = (short)1204486144;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACSirenType_A36584;
			}
		}

		// Token: 0x1700495C RID: 18780
		// (get) Token: 0x06009174 RID: 37236 RVA: 0x00893B98 File Offset: 0x00891D98
		// (set) Token: 0x06009175 RID: 37237 RVA: 0x00893C4C File Offset: 0x00891E4C
		public bool RadioErgoConfigACSirenType_A36584_Applicable
		{
			get
			{
				short num = (short)1058207205;
				short num2 = num;
				num = (short)948893157;
				switch (num2 == num)
				{
				default:
				{
					num = (short)253493248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1261043713;
				if (num != 0)
				{
				}
				num = (short)95813632;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACSirenType_A36584.Applicable;
			}
			set
			{
				short num = (short)2011534454;
				short num2 = num;
				num = (short)1372296310;
				switch (num2 == num)
				{
				default:
				{
					num = (short)185401344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)160235520;
				if (num != 0)
				{
				}
				num = (short)1648689153;
				if (num != 0)
				{
				}
				this.radioErgoConfigACSirenType_A36584.Applicable = value;
			}
		}

		// Token: 0x1700495D RID: 18781
		// (get) Token: 0x06009176 RID: 37238 RVA: 0x00893D00 File Offset: 0x00891F00
		// (set) Token: 0x06009177 RID: 37239 RVA: 0x00893DB4 File Offset: 0x00891FB4
		public bool RadioErgoConfigACSirenType_A36584_Valid
		{
			get
			{
				short num = (short)728339131;
				short num2 = num;
				num = (short)177115835;
				switch (num2 == num)
				{
				default:
				{
					num = (short)812580864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1733820417;
				if (num != 0)
				{
				}
				num = (short)365035520;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACSirenType_A36584.Valid;
			}
			set
			{
				short num = (short)1191028284;
				short num2 = num;
				num = (short)1417061948;
				switch (num2 == num)
				{
				default:
				{
					num = (short)271712256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1448542209;
				if (num != 0)
				{
				}
				num = (short)915144704;
				if (num != 0)
				{
				}
				this.radioErgoConfigACSirenType_A36584.Valid = value;
			}
		}

		// Token: 0x1700495E RID: 18782
		// (get) Token: 0x06009178 RID: 37240 RVA: 0x00893E6C File Offset: 0x0089206C
		// (set) Token: 0x06009179 RID: 37241 RVA: 0x00893F20 File Offset: 0x00892120
		public bool RadioErgoConfigACSirenType_A36584_Visible
		{
			get
			{
				short num = (short)730981285;
				short num2 = num;
				num = (short)949412773;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1934032896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1823604736;
				if (num != 0)
				{
				}
				num = (short)1325662209;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACSirenType_A36584.Visible;
			}
			set
			{
				short num = (short)2894825;
				short num2 = num;
				num = (short)275917801;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2063990784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1754988545;
				if (num != 0)
				{
				}
				num = (short)757858304;
				if (num != 0)
				{
				}
				this.radioErgoConfigACSirenType_A36584.Visible = value;
			}
		}

		// Token: 0x1700495F RID: 18783
		// (get) Token: 0x0600917A RID: 37242 RVA: 0x00893FD4 File Offset: 0x008921D4
		// (set) Token: 0x0600917B RID: 37243 RVA: 0x00894088 File Offset: 0x00892288
		public bool RadioErgoConfigACSirenType_A36584_Editable
		{
			get
			{
				short num = (short)879426218;
				short num2 = num;
				num = (short)500038314;
				switch (num2 == num)
				{
				default:
				{
					num = (short)598802432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1251540993;
				if (num != 0)
				{
				}
				num = (short)1712783360;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACSirenType_A36584.Editable;
			}
			set
			{
				short num = (short)1385302988;
				short num2 = num;
				num = (short)2087193548;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1914503168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1422393345;
				if (num != 0)
				{
				}
				num = (short)695992320;
				if (num != 0)
				{
				}
				this.radioErgoConfigACSirenType_A36584.Editable = value;
			}
		}

		// Token: 0x17004960 RID: 18784
		// (get) Token: 0x0600917C RID: 37244 RVA: 0x00894140 File Offset: 0x00892340
		internal string RadioErgoConfigACSirenType_A36584_UILabel
		{
			get
			{
				short num = (short)105942902;
				short num2 = num;
				num = (short)1466273654;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1128595456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)499253249;
				if (num != 0)
				{
				}
				num = (short)419561472;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACSirenType_A36584.UIName;
			}
		}

		// Token: 0x17004961 RID: 18785
		// (get) Token: 0x0600917D RID: 37245 RVA: 0x008941F4 File Offset: 0x008923F4
		// (set) Token: 0x0600917E RID: 37246 RVA: 0x008942AC File Offset: 0x008924AC
		internal bool RadioErgoConfigACSirenType_A36584_HiddenStatic
		{
			get
			{
				short num = (short)281690545;
				short num2 = num;
				num = (short)1533034929;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1689976832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1398472705;
				if (num != 0)
				{
				}
				num = (short)2017722368;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACSirenType_A36584.HiddenStatic;
			}
			set
			{
				short num = (short)1017839617;
				if (num != 0)
				{
				}
				num = (short)94896128;
				short num2 = num;
				num = (short)661875905;
				short num3 = num;
				num = (short)1054764225;
				switch (num3 == num)
				{
				}
				num = (short)556728320;
				if (num != 0)
				{
				}
				this.radioErgoConfigACSirenType_A36584.HiddenStatic = value;
			}
		}

		// Token: 0x17004962 RID: 18786
		// (get) Token: 0x0600917F RID: 37247 RVA: 0x00894364 File Offset: 0x00892564
		// (set) Token: 0x06009180 RID: 37248 RVA: 0x00894414 File Offset: 0x00892614
		internal bool RadioErgoConfigACSirenType_A36584_HiddenDynamic
		{
			get
			{
				short num = (short)1559070141;
				short num2 = num;
				num = (short)789939645;
				switch (num2 == num)
				{
				default:
				{
					num = (short)638910464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)700317697;
				if (num != 0)
				{
				}
				num = (short)453902336;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACSirenType_A36584.HiddenDynamic;
			}
			set
			{
				short num = (short)178978817;
				if (num != 0)
				{
				}
				num = (short)1161560064;
				short num2 = num;
				num = (short)1777179537;
				short num3 = num;
				num = (short)1455004561;
				switch (num3 == num)
				{
				}
				num = (short)1376583680;
				if (num != 0)
				{
				}
				this.radioErgoConfigACSirenType_A36584.HiddenDynamic = value;
			}
		}

		// Token: 0x17004963 RID: 18787
		// (get) Token: 0x06009181 RID: 37249 RVA: 0x008944C8 File Offset: 0x008926C8
		public bool RadioErgoConfigACSirenType_A36584_HasDiffs
		{
			get
			{
				short num = (short)1353406390;
				short num2 = num;
				num = (short)970479542;
				switch (num2 == num)
				{
				default:
				{
					num = (short)377159680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1050607617;
				if (num != 0)
				{
				}
				num = (short)2022375424;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACSirenType_A36584._HasDiffs;
			}
		}

		// Token: 0x17004964 RID: 18788
		// (get) Token: 0x06009182 RID: 37250 RVA: 0x00894580 File Offset: 0x00892780
		// (set) Token: 0x06009183 RID: 37251 RVA: 0x00894634 File Offset: 0x00892834
		public int RadioErgoConfigACSirenTypeErrStrategy_A36585Value
		{
			get
			{
				short num = (short)810977394;
				short num2 = num;
				num = (short)54626418;
				switch (num2 == num)
				{
				default:
				{
					num = (short)80871424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1441071104;
				if (num != 0)
				{
				}
				num = (short)817037313;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACSirenTypeErrStrategy_A36585.Value;
			}
			set
			{
				short num = (short)551239954;
				short num2 = num;
				num = (short)128401682;
				switch (num2 == num)
				{
				default:
				{
					num = (short)683278336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1774845953;
				if (num != 0)
				{
				}
				num = (short)656080896;
				if (num != 0)
				{
				}
				this.radioErgoConfigACSirenTypeErrStrategy_A36585.Value = value;
			}
		}

		// Token: 0x17004965 RID: 18789
		// (get) Token: 0x06009184 RID: 37252 RVA: 0x008946EC File Offset: 0x008928EC
		// (set) Token: 0x06009185 RID: 37253 RVA: 0x0089479C File Offset: 0x0089299C
		public string RadioErgoConfigACSirenTypeErrStrategy_A36585_UIValue
		{
			get
			{
				short num = (short)1406598649;
				short num2 = num;
				num = (short)475987449;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1460535296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1076166657;
				if (num != 0)
				{
				}
				num = (short)1688207360;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACSirenTypeErrStrategy_A36585.UIValue;
			}
			set
			{
				short num = (short)995521959;
				short num2 = num;
				num = (short)1384281511;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1879638016;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)480247809;
				if (num != 0)
				{
				}
				num = (short)2003238912;
				if (num != 0)
				{
				}
				this.radioErgoConfigACSirenTypeErrStrategy_A36585.UIValue = value;
			}
		}

		// Token: 0x17004966 RID: 18790
		// (get) Token: 0x06009186 RID: 37254 RVA: 0x00894854 File Offset: 0x00892A54
		public global::AcpBusinessLayer.AcpListField RadioErgoConfigACSirenTypeErrStrategy_A36585
		{
			get
			{
				short num = (short)169762706;
				short num2 = num;
				num = (short)548102034;
				switch (num2 == num)
				{
				default:
				{
					num = (short)143589376;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1746599936;
				if (num != 0)
				{
				}
				num = (short)343277569;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACSirenTypeErrStrategy_A36585;
			}
		}

		// Token: 0x17004967 RID: 18791
		// (get) Token: 0x06009187 RID: 37255 RVA: 0x00894904 File Offset: 0x00892B04
		// (set) Token: 0x06009188 RID: 37256 RVA: 0x008949B8 File Offset: 0x00892BB8
		public bool RadioErgoConfigACSirenTypeErrStrategy_A36585_Applicable
		{
			get
			{
				short num = (short)1756746107;
				short num2 = num;
				num = (short)700109179;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1514536960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1964113921;
				if (num != 0)
				{
				}
				num = (short)438173696;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACSirenTypeErrStrategy_A36585.Applicable;
			}
			set
			{
				short num = (short)1168946994;
				short num2 = num;
				num = (short)702789426;
				switch (num2 == num)
				{
				default:
				{
					num = (short)810352640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1709572097;
				if (num != 0)
				{
				}
				num = (short)1649868800;
				if (num != 0)
				{
				}
				this.radioErgoConfigACSirenTypeErrStrategy_A36585.Applicable = value;
			}
		}

		// Token: 0x17004968 RID: 18792
		// (get) Token: 0x06009189 RID: 37257 RVA: 0x00894A6C File Offset: 0x00892C6C
		// (set) Token: 0x0600918A RID: 37258 RVA: 0x00894B24 File Offset: 0x00892D24
		public bool RadioErgoConfigACSirenTypeErrStrategy_A36585_Valid
		{
			get
			{
				short num = (short)601302382;
				short num2 = num;
				num = (short)751379822;
				switch (num2 == num)
				{
				default:
				{
					num = (short)323289088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)345178113;
				if (num != 0)
				{
				}
				num = (short)505020416;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACSirenTypeErrStrategy_A36585.Valid;
			}
			set
			{
				short num = (short)495123459;
				short num2 = num;
				num = (short)1428290563;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1573322752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)273350657;
				if (num != 0)
				{
				}
				num = (short)2123628544;
				if (num != 0)
				{
				}
				this.radioErgoConfigACSirenTypeErrStrategy_A36585.Valid = value;
			}
		}

		// Token: 0x17004969 RID: 18793
		// (get) Token: 0x0600918B RID: 37259 RVA: 0x00894BDC File Offset: 0x00892DDC
		// (set) Token: 0x0600918C RID: 37260 RVA: 0x00894C94 File Offset: 0x00892E94
		public bool RadioErgoConfigACSirenTypeErrStrategy_A36585_Visible
		{
			get
			{
				short num = (short)1033097936;
				short num2 = num;
				num = (short)130470608;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1137246208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)859897856;
				if (num != 0)
				{
				}
				num = (short)1604124673;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACSirenTypeErrStrategy_A36585.Visible;
			}
			set
			{
				short num = (short)1650185800;
				short num2 = num;
				num = (short)867554888;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1312358400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)963903489;
				if (num != 0)
				{
				}
				num = (short)1253048320;
				if (num != 0)
				{
				}
				this.radioErgoConfigACSirenTypeErrStrategy_A36585.Visible = value;
			}
		}

		// Token: 0x1700496A RID: 18794
		// (get) Token: 0x0600918D RID: 37261 RVA: 0x00894D48 File Offset: 0x00892F48
		// (set) Token: 0x0600918E RID: 37262 RVA: 0x00894DFC File Offset: 0x00892FFC
		public bool RadioErgoConfigACSirenTypeErrStrategy_A36585_Editable
		{
			get
			{
				short num = (short)1404041439;
				short num2 = num;
				num = (short)162527455;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1124139008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)727384065;
				if (num != 0)
				{
				}
				num = (short)1253310464;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACSirenTypeErrStrategy_A36585.Editable;
			}
			set
			{
				short num = (short)402128897;
				if (num != 0)
				{
				}
				num = (short)637337600;
				short num2 = num;
				num = (short)345735157;
				short num3 = num;
				num = (short)1312980981;
				switch (num3 == num)
				{
				}
				num = (short)1414266880;
				if (num != 0)
				{
				}
				this.radioErgoConfigACSirenTypeErrStrategy_A36585.Editable = value;
			}
		}

		// Token: 0x1700496B RID: 18795
		// (get) Token: 0x0600918F RID: 37263 RVA: 0x00894EB4 File Offset: 0x008930B4
		internal string RadioErgoConfigACSirenTypeErrStrategy_A36585_UILabel
		{
			get
			{
				short num = (short)1969125101;
				short num2 = num;
				num = (short)1968731885;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1209794560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1198850049;
				if (num != 0)
				{
				}
				num = (short)749600768;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACSirenTypeErrStrategy_A36585.UIName;
			}
		}

		// Token: 0x1700496C RID: 18796
		// (get) Token: 0x06009190 RID: 37264 RVA: 0x00894F6C File Offset: 0x0089316C
		// (set) Token: 0x06009191 RID: 37265 RVA: 0x00895024 File Offset: 0x00893224
		internal bool RadioErgoConfigACSirenTypeErrStrategy_A36585_HiddenStatic
		{
			get
			{
				short num = (short)738283950;
				short num2 = num;
				num = (short)708399534;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1244463104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)915865601;
				if (num != 0)
				{
				}
				num = (short)1831665664;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACSirenTypeErrStrategy_A36585.HiddenStatic;
			}
			set
			{
				short num = (short)1884665495;
				short num2 = num;
				num = (short)392672919;
				switch (num2 == num)
				{
				default:
				{
					num = (short)956235776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1480523776;
				if (num != 0)
				{
				}
				num = (short)1376190465;
				if (num != 0)
				{
				}
				this.radioErgoConfigACSirenTypeErrStrategy_A36585.HiddenStatic = value;
			}
		}

		// Token: 0x1700496D RID: 18797
		// (get) Token: 0x06009192 RID: 37266 RVA: 0x008950D4 File Offset: 0x008932D4
		// (set) Token: 0x06009193 RID: 37267 RVA: 0x0089518C File Offset: 0x0089338C
		internal bool RadioErgoConfigACSirenTypeErrStrategy_A36585_HiddenDynamic
		{
			get
			{
				short num = (short)918749185;
				if (num != 0)
				{
				}
				num = (short)859242496;
				short num2 = num;
				num = (short)261596784;
				short num3 = num;
				num = (short)942712432;
				switch (num3 == num)
				{
				}
				num = (short)1315373056;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACSirenTypeErrStrategy_A36585.HiddenDynamic;
			}
			set
			{
				short num = (short)1194880194;
				short num2 = num;
				num = (short)788491458;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1982070784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2100953089;
				if (num != 0)
				{
				}
				num = (short)586416128;
				if (num != 0)
				{
				}
				this.radioErgoConfigACSirenTypeErrStrategy_A36585.HiddenDynamic = value;
			}
		}

		// Token: 0x1700496E RID: 18798
		// (get) Token: 0x06009194 RID: 37268 RVA: 0x00895244 File Offset: 0x00893444
		public bool RadioErgoConfigACSirenTypeErrStrategy_A36585_HasDiffs
		{
			get
			{
				short num = (short)1817424171;
				short num2 = num;
				num = (short)1306505515;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1862795264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)618528769;
				if (num != 0)
				{
				}
				num = (short)244973568;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACSirenTypeErrStrategy_A36585._HasDiffs;
			}
		}

		// Token: 0x1700496F RID: 18799
		// (get) Token: 0x06009195 RID: 37269 RVA: 0x008952F8 File Offset: 0x008934F8
		// (set) Token: 0x06009196 RID: 37270 RVA: 0x008953AC File Offset: 0x008935AC
		public bool RadioErgoConfigACGpsReport_A36587Value
		{
			get
			{
				short num = (short)653125916;
				short num2 = num;
				num = (short)330688796;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1506082816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1297940481;
				if (num != 0)
				{
				}
				num = (short)843776000;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGpsReport_A36587.Value;
			}
			set
			{
				short num = (short)1915295989;
				short num2 = num;
				num = (short)1033574645;
				switch (num2 == num)
				{
				default:
				{
					num = (short)617414656;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)401080321;
				if (num != 0)
				{
				}
				num = (short)1419116544;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGpsReport_A36587.Value = value;
			}
		}

		// Token: 0x17004970 RID: 18800
		// (get) Token: 0x06009197 RID: 37271 RVA: 0x00895460 File Offset: 0x00893660
		public global::AcpBusinessLayer.AcpField<bool> RadioErgoConfigACGpsReport_A36587
		{
			get
			{
				short num = (short)516620289;
				if (num != 0)
				{
				}
				num = (short)857145344;
				short num2 = num;
				num = (short)2064232438;
				short num3 = num;
				num = (short)1904521206;
				switch (num3 == num)
				{
				}
				num = (short)234553344;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGpsReport_A36587;
			}
		}

		// Token: 0x17004971 RID: 18801
		// (get) Token: 0x06009198 RID: 37272 RVA: 0x00895514 File Offset: 0x00893714
		// (set) Token: 0x06009199 RID: 37273 RVA: 0x008955C4 File Offset: 0x008937C4
		public bool RadioErgoConfigACGpsReport_A36587_UIValue
		{
			get
			{
				short num = (short)77331108;
				short num2 = num;
				num = (short)1138883236;
				switch (num2 == num)
				{
				default:
				{
					num = (short)771358720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)861667329;
				if (num != 0)
				{
				}
				num = (short)820707328;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGpsReport_A36587.Value;
			}
			set
			{
				short num = (short)1615656879;
				short num2 = num;
				num = (short)351860655;
				switch (num2 == num)
				{
				default:
				{
					num = (short)49872896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1061093376;
				if (num != 0)
				{
				}
				num = (short)1303379969;
				if (num != 0)
				{
				}
				this.radioErgoConfigACGpsReport_A36587.Value = value;
			}
		}

		// Token: 0x17004972 RID: 18802
		// (get) Token: 0x0600919A RID: 37274 RVA: 0x00895678 File Offset: 0x00893878
		// (set) Token: 0x0600919B RID: 37275 RVA: 0x0089572C File Offset: 0x0089392C
		public bool RadioErgoConfigACGpsReport_A36587_Applicable
		{
			get
			{
				short num = (short)1844329731;
				short num2 = num;
				num = (short)1403731203;
				switch (num2 == num)
				{
				default:
				{
					num = (short)246218752;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)148897793;
				if (num != 0)
				{
				}
				num = (short)12386304;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACGpsReport_A36587.Applicable;
			}
			set
			{
				short num = (short)913251603;
				short num2 = num;
				num = (short)1879514387;
				switch (num2 == num)
				{
				}
				num = (short)1754464257;
				if (num != 0)
				{
				}
				num = (short)1255538688;
				if (num != 0)
				{
				}
				num = (short)324206592;
				short num3 = num;
				this.radioErgoConfigACGpsReport_A36587.Applicable = value;
			}
		}

		// Token: 0x17004973 RID: 18803
		// (get) Token: 0x0600919C RID: 37276 RVA: 0x008957E0 File Offset: 0x008939E0
		// (set) Token: 0x0600919D RID: 37277 RVA: 0x00895894 File Offset: 0x00893A94
		public bool RadioErgoConfigACGpsReport_A36587_Valid
		{
			get
			{
				short num = (short)469396457;
				short num2 = num;
				num = (short)1488415721;
				switch (num2 == num)
				{
				}
				num = (short)1173094400;
				if (num != 0)
				{
				}
				num = (short)840302593;
				if (num != 0)
				{
				}
				num = (short)226492416;
				short num3 = num;
				return this.radioErgoConfigACGpsReport_A36587.Valid;
			}
			set
			{
				short num = (short)2008639913;
				short num2 = num;
				num = (short)209480105;
				switch (num2 == num)
				{
				}
				num = (short)667811840;
				if (num != 0)
				{
				}
				num = (short)1044185089;
				if (num != 0)
				{
				}
				num = (short)240779264;
				short num3 = num;
				this.radioErgoConfigACGpsReport_A36587.Valid = value;
			}
		}

		// Token: 0x17004974 RID: 18804
		// (get) Token: 0x0600919E RID: 37278 RVA: 0x00895948 File Offset: 0x00893B48
		// (set) Token: 0x0600919F RID: 37279 RVA: 0x00895A00 File Offset: 0x00893C00
		public bool RadioErgoConfigACGpsReport_A36587_Visible
		{
			get
			{
				short num = (short)1228144641;
				if (num != 0)
				{
				}
				num = (short)194309478;
				short num2 = num;
				num = (short)1986129254;
				switch (num2 == num)
				{
				}
				num = (short)485883904;
				if (num != 0)
				{
				}
				num = (short)1756889088;
				short num3 = num;
				return this.radioErgoConfigACGpsReport_A36587.Visible;
			}
			set
			{
				short num = (short)1755186647;
				short num2 = num;
				num = (short)971834839;
				switch (num2 == num)
				{
				}
				num = (short)1648099328;
				if (num != 0)
				{
				}
				num = (short)1965555713;
				if (num != 0)
				{
				}
				num = (short)260702208;
				short num3 = num;
				this.radioErgoConfigACGpsReport_A36587.Visible = value;
			}
		}

		// Token: 0x17004975 RID: 18805
		// (get) Token: 0x060091A0 RID: 37280 RVA: 0x00895AB8 File Offset: 0x00893CB8
		// (set) Token: 0x060091A1 RID: 37281 RVA: 0x00895B70 File Offset: 0x00893D70
		public bool RadioErgoConfigACGpsReport_A36587_Editable
		{
			get
			{
				short num = (short)1788228162;
				short num2 = num;
				num = (short)1588474434;
				switch (num2 == num)
				{
				}
				num = (short)1953628161;
				if (num != 0)
				{
				}
				num = (short)660406272;
				if (num != 0)
				{
				}
				num = (short)305332224;
				short num3 = num;
				return this.radioErgoConfigACGpsReport_A36587.Editable;
			}
			set
			{
				short num = (short)481454490;
				short num2 = num;
				num = (short)425879962;
				switch (num2 == num)
				{
				}
				num = (short)2006908929;
				if (num != 0)
				{
				}
				num = (short)170459136;
				if (num != 0)
				{
				}
				num = (short)397082624;
				short num3 = num;
				this.radioErgoConfigACGpsReport_A36587.Editable = value;
			}
		}

		// Token: 0x17004976 RID: 18806
		// (get) Token: 0x060091A2 RID: 37282 RVA: 0x00895C28 File Offset: 0x00893E28
		internal string RadioErgoConfigACGpsReport_A36587_UILabel
		{
			get
			{
				short num = (short)123469825;
				if (num != 0)
				{
				}
				num = (short)835859628;
				short num2 = num;
				num = (short)284636332;
				switch (num2 == num)
				{
				}
				num = (short)935591936;
				if (num != 0)
				{
				}
				num = (short)1863188480;
				short num3 = num;
				return this.radioErgoConfigACGpsReport_A36587.UIName;
			}
		}

		// Token: 0x17004977 RID: 18807
		// (get) Token: 0x060091A3 RID: 37283 RVA: 0x00895CDC File Offset: 0x00893EDC
		// (set) Token: 0x060091A4 RID: 37284 RVA: 0x00895D90 File Offset: 0x00893F90
		internal bool RadioErgoConfigACGpsReport_A36587_HiddenStatic
		{
			get
			{
				short num = (short)1563867632;
				short num2 = num;
				num = (short)1026537968;
				switch (num2 == num)
				{
				}
				num = (short)2082209793;
				if (num != 0)
				{
				}
				num = (short)1781858304;
				if (num != 0)
				{
				}
				num = (short)44498944;
				short num3 = num;
				return this.radioErgoConfigACGpsReport_A36587.HiddenStatic;
			}
			set
			{
				short num = (short)1974665217;
				if (num != 0)
				{
				}
				num = (short)851643914;
				short num2 = num;
				num = (short)1516703242;
				switch (num2 == num)
				{
				}
				num = (short)76349440;
				if (num != 0)
				{
				}
				num = (short)1844641792;
				short num3 = num;
				this.radioErgoConfigACGpsReport_A36587.HiddenStatic = value;
			}
		}

		// Token: 0x17004978 RID: 18808
		// (get) Token: 0x060091A5 RID: 37285 RVA: 0x00895E4C File Offset: 0x0089404C
		// (set) Token: 0x060091A6 RID: 37286 RVA: 0x00895F04 File Offset: 0x00894104
		internal bool RadioErgoConfigACGpsReport_A36587_HiddenDynamic
		{
			get
			{
				short num = (short)1134809832;
				short num2 = num;
				num = (short)778293992;
				switch (num2 == num)
				{
				}
				num = (short)757792768;
				if (num != 0)
				{
				}
				num = (short)1999765505;
				if (num != 0)
				{
				}
				num = (short)1808531456;
				short num3 = num;
				return this.radioErgoConfigACGpsReport_A36587.HiddenDynamic;
			}
			set
			{
				short num = (short)39894075;
				short num2 = num;
				num = (short)1725807675;
				switch (num2 == num)
				{
				}
				num = (short)2018443265;
				if (num != 0)
				{
				}
				num = (short)1901395968;
				if (num != 0)
				{
				}
				num = (short)1875574784;
				short num3 = num;
				this.radioErgoConfigACGpsReport_A36587.HiddenDynamic = value;
			}
		}

		// Token: 0x17004979 RID: 18809
		// (get) Token: 0x060091A7 RID: 37287 RVA: 0x00895FBC File Offset: 0x008941BC
		public bool RadioErgoConfigACGpsReport_A36587_HasDiffs
		{
			get
			{
				short num = (short)844111478;
				short num2 = num;
				num = (short)998841974;
				switch (num2 == num)
				{
				}
				num = (short)98041856;
				if (num != 0)
				{
				}
				num = (short)1317666817;
				if (num != 0)
				{
				}
				num = (short)1260650496;
				short num3 = num;
				return this.radioErgoConfigACGpsReport_A36587._HasDiffs;
			}
		}

		// Token: 0x1700497A RID: 18810
		// (get) Token: 0x060091A8 RID: 37288 RVA: 0x00896070 File Offset: 0x00894270
		// (set) Token: 0x060091A9 RID: 37289 RVA: 0x00896124 File Offset: 0x00894324
		public int RadioErgoConfigACGpsReportErrStrategy_A36588Value
		{
			get
			{
				short num = (short)1260195603;
				short num2 = num;
				num = (short)1970343699;
				switch (num2 == num)
				{
				}
				num = (short)1529544704;
				if (num != 0)
				{
				}
				num = (short)1934622721;
				if (num != 0)
				{
				}
				num = (short)1288830976;
				short num3 = num;
				return this.radioErgoConfigACGpsReportErrStrategy_A36588.Value;
			}
			set
			{
				short num = (short)1472258226;
				short num2 = num;
				num = (short)325771442;
				switch (num2 == num)
				{
				}
				num = (short)2011430912;
				if (num != 0)
				{
				}
				num = (short)2043936769;
				if (num != 0)
				{
				}
				num = (short)1518731264;
				short num3 = num;
				this.radioErgoConfigACGpsReportErrStrategy_A36588.Value = value;
			}
		}

		// Token: 0x1700497B RID: 18811
		// (get) Token: 0x060091AA RID: 37290 RVA: 0x008961D8 File Offset: 0x008943D8
		// (set) Token: 0x060091AB RID: 37291 RVA: 0x0089628C File Offset: 0x0089448C
		public string RadioErgoConfigACGpsReportErrStrategy_A36588_UIValue
		{
			get
			{
				short num = (short)1746222763;
				short num2 = num;
				num = (short)564018859;
				switch (num2 == num)
				{
				}
				num = (short)1486749697;
				if (num != 0)
				{
				}
				num = (short)1826488320;
				if (num != 0)
				{
				}
				num = (short)1730084864;
				short num3 = num;
				return this.radioErgoConfigACGpsReportErrStrategy_A36588.UIValue;
			}
			set
			{
				short num = (short)1484247158;
				short num2 = num;
				num = (short)454152310;
				switch (num2 == num)
				{
				}
				num = (short)32899072;
				if (num != 0)
				{
				}
				num = (short)261029889;
				if (num != 0)
				{
				}
				num = (short)1113718784;
				short num3 = num;
				this.radioErgoConfigACGpsReportErrStrategy_A36588.UIValue = value;
			}
		}

		// Token: 0x1700497C RID: 18812
		// (get) Token: 0x060091AC RID: 37292 RVA: 0x00896340 File Offset: 0x00894540
		public global::AcpBusinessLayer.AcpListField RadioErgoConfigACGpsReportErrStrategy_A36588
		{
			get
			{
				short num = (short)1627625586;
				short num2 = num;
				num = (short)1611890;
				switch (num2 == num)
				{
				}
				num = (short)237436929;
				if (num != 0)
				{
				}
				num = (short)1846411264;
				if (num != 0)
				{
				}
				num = (short)1586364416;
				short num3 = num;
				return this.radioErgoConfigACGpsReportErrStrategy_A36588;
			}
		}

		// Token: 0x1700497D RID: 18813
		// (get) Token: 0x060091AD RID: 37293 RVA: 0x008963F0 File Offset: 0x008945F0
		// (set) Token: 0x060091AE RID: 37294 RVA: 0x008964A8 File Offset: 0x008946A8
		public bool RadioErgoConfigACGpsReportErrStrategy_A36588_Applicable
		{
			get
			{
				short num = (short)1403961322;
				short num2 = num;
				num = (short)22069226;
				switch (num2 == num)
				{
				}
				num = (short)511574017;
				if (num != 0)
				{
				}
				num = (short)2086273024;
				if (num != 0)
				{
				}
				num = (short)1917517824;
				short num3 = num;
				return this.radioErgoConfigACGpsReportErrStrategy_A36588.Applicable;
			}
			set
			{
				short num = (short)424923124;
				short num2 = num;
				num = (short)304140276;
				switch (num2 == num)
				{
				}
				num = (short)863567873;
				if (num != 0)
				{
				}
				num = (short)898695168;
				if (num != 0)
				{
				}
				num = (short)1362755584;
				short num3 = num;
				this.radioErgoConfigACGpsReportErrStrategy_A36588.Applicable = value;
			}
		}

		// Token: 0x1700497E RID: 18814
		// (get) Token: 0x060091AF RID: 37295 RVA: 0x00896564 File Offset: 0x00894764
		// (set) Token: 0x060091B0 RID: 37296 RVA: 0x00896618 File Offset: 0x00894818
		public bool RadioErgoConfigACGpsReportErrStrategy_A36588_Valid
		{
			get
			{
				short num = (short)1957882566;
				short num2 = num;
				num = (short)2086922950;
				switch (num2 == num)
				{
				}
				num = (short)1860501505;
				if (num != 0)
				{
				}
				num = (short)747503616;
				if (num != 0)
				{
				}
				num = (short)2014248960;
				short num3 = num;
				return this.radioErgoConfigACGpsReportErrStrategy_A36588.Valid;
			}
			set
			{
				short num = (short)115867649;
				if (num != 0)
				{
				}
				num = (short)286239732;
				short num2 = num;
				num = (short)2008001524;
				switch (num2 == num)
				{
				}
				num = (short)1544552448;
				if (num != 0)
				{
				}
				num = (short)1849163776;
				short num3 = num;
				this.radioErgoConfigACGpsReportErrStrategy_A36588.Valid = value;
			}
		}

		// Token: 0x1700497F RID: 18815
		// (get) Token: 0x060091B1 RID: 37297 RVA: 0x008966CC File Offset: 0x008948CC
		// (set) Token: 0x060091B2 RID: 37298 RVA: 0x00896780 File Offset: 0x00894980
		public bool RadioErgoConfigACGpsReportErrStrategy_A36588_Visible
		{
			get
			{
				short num = (short)1236698044;
				short num2 = num;
				num = (short)1662944188;
				switch (num2 == num)
				{
				}
				num = (short)1331888129;
				if (num != 0)
				{
				}
				num = (short)230621184;
				if (num != 0)
				{
				}
				num = (short)1789067264;
				short num3 = num;
				return this.radioErgoConfigACGpsReportErrStrategy_A36588.Visible;
			}
			set
			{
				short num = (short)808172061;
				short num2 = num;
				num = (short)1039514141;
				switch (num2 == num)
				{
				}
				num = (short)620363776;
				if (num != 0)
				{
				}
				num = (short)1790967809;
				if (num != 0)
				{
				}
				num = (short)1278541824;
				short num3 = num;
				this.radioErgoConfigACGpsReportErrStrategy_A36588.Visible = value;
			}
		}

		// Token: 0x17004980 RID: 18816
		// (get) Token: 0x060091B3 RID: 37299 RVA: 0x00896838 File Offset: 0x00894A38
		// (set) Token: 0x060091B4 RID: 37300 RVA: 0x008968EC File Offset: 0x00894AEC
		public bool RadioErgoConfigACGpsReportErrStrategy_A36588_Editable
		{
			get
			{
				short num = (short)1069668574;
				short num2 = num;
				num = (short)1837291742;
				switch (num2 == num)
				{
				}
				num = (short)1505951745;
				if (num != 0)
				{
				}
				num = (short)1879113728;
				if (num != 0)
				{
				}
				num = (short)1347878912;
				short num3 = num;
				return this.radioErgoConfigACGpsReportErrStrategy_A36588.Editable;
			}
			set
			{
				short num = (short)100506432;
				short num2 = num;
				num = (short)88185664;
				switch (num2 == num)
				{
				}
				num = (short)193134593;
				if (num != 0)
				{
				}
				num = (short)49545216;
				if (num != 0)
				{
				}
				num = (short)1605894144;
				short num3 = num;
				this.radioErgoConfigACGpsReportErrStrategy_A36588.Editable = value;
			}
		}

		// Token: 0x17004981 RID: 18817
		// (get) Token: 0x060091B5 RID: 37301 RVA: 0x008969A0 File Offset: 0x00894BA0
		internal string RadioErgoConfigACGpsReportErrStrategy_A36588_UILabel
		{
			get
			{
				short num = (short)1872101374;
				short num2 = num;
				num = (short)1763966974;
				switch (num2 == num)
				{
				}
				num = (short)953745409;
				if (num != 0)
				{
				}
				num = (short)1362755584;
				if (num != 0)
				{
				}
				num = (short)1983578112;
				short num3 = num;
				return this.radioErgoConfigACGpsReportErrStrategy_A36588.UIName;
			}
		}

		// Token: 0x17004982 RID: 18818
		// (get) Token: 0x060091B6 RID: 37302 RVA: 0x00896A58 File Offset: 0x00894C58
		// (set) Token: 0x060091B7 RID: 37303 RVA: 0x00896B0C File Offset: 0x00894D0C
		internal bool RadioErgoConfigACGpsReportErrStrategy_A36588_HiddenStatic
		{
			get
			{
				short num = (short)19453074;
				short num2 = num;
				num = (short)443995282;
				switch (num2 == num)
				{
				}
				num = (short)1364918273;
				if (num != 0)
				{
				}
				num = (short)2017591296;
				if (num != 0)
				{
				}
				num = (short)778633216;
				short num3 = num;
				return this.radioErgoConfigACGpsReportErrStrategy_A36588.HiddenStatic;
			}
			set
			{
				short num = (short)2081993333;
				short num2 = num;
				num = (short)2136650357;
				switch (num2 == num)
				{
				}
				num = (short)1270480896;
				if (num != 0)
				{
				}
				num = (short)758382593;
				if (num != 0)
				{
				}
				num = (short)684195840;
				short num3 = num;
				this.radioErgoConfigACGpsReportErrStrategy_A36588.HiddenStatic = value;
			}
		}

		// Token: 0x17004983 RID: 18819
		// (get) Token: 0x060091B8 RID: 37304 RVA: 0x00896BC4 File Offset: 0x00894DC4
		// (set) Token: 0x060091B9 RID: 37305 RVA: 0x00896C78 File Offset: 0x00894E78
		internal bool RadioErgoConfigACGpsReportErrStrategy_A36588_HiddenDynamic
		{
			get
			{
				short num = (short)1019609089;
				if (num != 0)
				{
				}
				num = (short)1376599745;
				short num2 = num;
				num = (short)890781377;
				switch (num2 == num)
				{
				}
				num = (short)1670119424;
				if (num != 0)
				{
				}
				num = (short)862453760;
				short num3 = num;
				return this.radioErgoConfigACGpsReportErrStrategy_A36588.HiddenDynamic;
			}
			set
			{
				short num = (short)2100549756;
				short num2 = num;
				num = (short)787339388;
				switch (num2 == num)
				{
				}
				num = (short)195690496;
				if (num != 0)
				{
				}
				num = (short)467533825;
				if (num != 0)
				{
				}
				num = (short)705232896;
				short num3 = num;
				this.radioErgoConfigACGpsReportErrStrategy_A36588.HiddenDynamic = value;
			}
		}

		// Token: 0x17004984 RID: 18820
		// (get) Token: 0x060091BA RID: 37306 RVA: 0x00896D2C File Offset: 0x00894F2C
		public bool RadioErgoConfigACGpsReportErrStrategy_A36588_HasDiffs
		{
			get
			{
				short num = (short)865158765;
				short num2 = num;
				num = (short)421348973;
				switch (num2 == num)
				{
				}
				num = (short)99680257;
				if (num != 0)
				{
				}
				num = (short)1591934976;
				if (num != 0)
				{
				}
				num = (short)670564352;
				short num3 = num;
				return this.radioErgoConfigACGpsReportErrStrategy_A36588._HasDiffs;
			}
		}

		// Token: 0x17004985 RID: 18821
		// (get) Token: 0x060091BB RID: 37307 RVA: 0x00896DE4 File Offset: 0x00894FE4
		// (set) Token: 0x060091BC RID: 37308 RVA: 0x00896E98 File Offset: 0x00895098
		public int RadioErgoConfigAC3rdPartyNotification_A41510Value
		{
			get
			{
				short num = (short)46597706;
				short num2 = num;
				num = (short)1672545866;
				switch (num2 == num)
				{
				}
				num = (short)1854406657;
				if (num != 0)
				{
				}
				num = (short)89915392;
				if (num != 0)
				{
				}
				num = (short)1231290368;
				short num3 = num;
				return this.radioErgoConfigAC3rdPartyNotification_A41510.Value;
			}
			set
			{
				short num = (short)1269512356;
				short num2 = num;
				num = (short)1788426404;
				switch (num2 == num)
				{
				}
				num = (short)1032060929;
				if (num != 0)
				{
				}
				num = (short)888209408;
				if (num != 0)
				{
				}
				num = (short)569442304;
				short num3 = num;
				this.radioErgoConfigAC3rdPartyNotification_A41510.Value = value;
			}
		}

		// Token: 0x17004986 RID: 18822
		// (get) Token: 0x060091BD RID: 37309 RVA: 0x00896F50 File Offset: 0x00895150
		// (set) Token: 0x060091BE RID: 37310 RVA: 0x00897008 File Offset: 0x00895208
		public string RadioErgoConfigAC3rdPartyNotification_A41510_UIValue
		{
			get
			{
				short num = (short)1669350015;
				short num2 = num;
				num = (short)2092581503;
				switch (num2 == num)
				{
				}
				num = (short)794755073;
				if (num != 0)
				{
				}
				num = (short)2007171072;
				if (num != 0)
				{
				}
				num = (short)2144337920;
				short num3 = num;
				return this.radioErgoConfigAC3rdPartyNotification_A41510.UIValue;
			}
			set
			{
				short num = (short)740320657;
				short num2 = num;
				num = (short)1735222673;
				switch (num2 == num)
				{
				}
				num = (short)210632704;
				if (num != 0)
				{
				}
				num = (short)1498480641;
				if (num != 0)
				{
				}
				num = (short)2080178176;
				short num3 = num;
				this.radioErgoConfigAC3rdPartyNotification_A41510.UIValue = value;
			}
		}

		// Token: 0x17004987 RID: 18823
		// (get) Token: 0x060091BF RID: 37311 RVA: 0x008970C0 File Offset: 0x008952C0
		public global::AcpBusinessLayer.AcpListField RadioErgoConfigAC3rdPartyNotification_A41510
		{
			get
			{
				short num = (short)1839287688;
				short num2 = num;
				num = (short)292441480;
				switch (num2 == num)
				{
				}
				num = (short)284819457;
				if (num != 0)
				{
				}
				num = (short)112132096;
				if (num != 0)
				{
				}
				num = (short)2138505216;
				short num3 = num;
				return this.radioErgoConfigAC3rdPartyNotification_A41510;
			}
		}

		// Token: 0x17004988 RID: 18824
		// (get) Token: 0x060091C0 RID: 37312 RVA: 0x0089716C File Offset: 0x0089536C
		// (set) Token: 0x060091C1 RID: 37313 RVA: 0x00897224 File Offset: 0x00895424
		public bool RadioErgoConfigAC3rdPartyNotification_A41510_Applicable
		{
			get
			{
				short num = (short)831797256;
				short num2 = num;
				num = (short)1266038792;
				switch (num2 == num)
				{
				}
				num = (short)1074200577;
				if (num != 0)
				{
				}
				num = (short)81002496;
				short num3 = num;
				num = (short)1058406400;
				if (num != 0)
				{
				}
				return this.radioErgoConfigAC3rdPartyNotification_A41510.Applicable;
			}
			set
			{
				short num = (short)42333739;
				short num2 = num;
				num = (short)114882091;
				switch (num2 == num)
				{
				}
				num = (short)736886784;
				if (num != 0)
				{
				}
				num = (short)206045184;
				short num3 = num;
				num = (short)795803649;
				if (num != 0)
				{
				}
				this.radioErgoConfigAC3rdPartyNotification_A41510.Applicable = value;
			}
		}

		// Token: 0x17004989 RID: 18825
		// (get) Token: 0x060091C2 RID: 37314 RVA: 0x008972D8 File Offset: 0x008954D8
		// (set) Token: 0x060091C3 RID: 37315 RVA: 0x0089738C File Offset: 0x0089558C
		public bool RadioErgoConfigAC3rdPartyNotification_A41510_Valid
		{
			get
			{
				short num = (short)74621070;
				short num2 = num;
				num = (short)1863032974;
				switch (num2 == num)
				{
				}
				num = (short)1842937857;
				if (num != 0)
				{
				}
				num = (short)1709965312;
				short num3 = num;
				num = (short)1653735424;
				if (num != 0)
				{
				}
				return this.radioErgoConfigAC3rdPartyNotification_A41510.Valid;
			}
			set
			{
				short num = (short)672071681;
				if (num != 0)
				{
				}
				num = (short)660237485;
				short num2 = num;
				num = (short)362245293;
				switch (num2 == num)
				{
				}
				num = (short)2135162880;
				short num3 = num;
				num = (short)19333120;
				if (num != 0)
				{
				}
				this.radioErgoConfigAC3rdPartyNotification_A41510.Valid = value;
			}
		}

		// Token: 0x1700498A RID: 18826
		// (get) Token: 0x060091C4 RID: 37316 RVA: 0x00897444 File Offset: 0x00895644
		// (set) Token: 0x060091C5 RID: 37317 RVA: 0x008974F8 File Offset: 0x008956F8
		public bool RadioErgoConfigAC3rdPartyNotification_A41510_Visible
		{
			get
			{
				short num = (short)1940833331;
				short num2 = num;
				num = (short)1685111859;
				switch (num2 == num)
				{
				}
				num = (short)1308622849;
				if (num != 0)
				{
				}
				num = (short)1643708416;
				short num3 = num;
				num = (short)2136997888;
				if (num != 0)
				{
				}
				return this.radioErgoConfigAC3rdPartyNotification_A41510.Visible;
			}
			set
			{
				short num = (short)1159972357;
				short num2 = num;
				num = (short)1050068485;
				switch (num2 == num)
				{
				}
				num = (short)223608832;
				if (num != 0)
				{
				}
				num = (short)1595867136;
				short num3 = num;
				num = (short)2100625409;
				if (num != 0)
				{
				}
				this.radioErgoConfigAC3rdPartyNotification_A41510.Visible = value;
			}
		}

		// Token: 0x1700498B RID: 18827
		// (get) Token: 0x060091C6 RID: 37318 RVA: 0x008975B0 File Offset: 0x008957B0
		// (set) Token: 0x060091C7 RID: 37319 RVA: 0x00897664 File Offset: 0x00895864
		public bool RadioErgoConfigAC3rdPartyNotification_A41510_Editable
		{
			get
			{
				short num = (short)787310818;
				short num2 = num;
				num = (short)300312802;
				switch (num2 == num)
				{
				}
				num = (short)1683161089;
				if (num != 0)
				{
				}
				num = (short)733544448;
				short num3 = num;
				num = (short)218693632;
				if (num != 0)
				{
				}
				return this.radioErgoConfigAC3rdPartyNotification_A41510.Editable;
			}
			set
			{
				short num = (short)44859078;
				short num2 = num;
				num = (short)573275846;
				switch (num2 == num)
				{
				}
				num = (short)788922369;
				if (num != 0)
				{
				}
				num = (short)1810694144;
				short num3 = num;
				num = (short)719192064;
				if (num != 0)
				{
				}
				this.radioErgoConfigAC3rdPartyNotification_A41510.Editable = value;
			}
		}

		// Token: 0x1700498C RID: 18828
		// (get) Token: 0x060091C8 RID: 37320 RVA: 0x0089771C File Offset: 0x0089591C
		internal string RadioErgoConfigAC3rdPartyNotification_A41510_UILabel
		{
			get
			{
				short num = (short)526318171;
				short num2 = num;
				num = (short)1906571867;
				switch (num2 == num)
				{
				}
				num = (short)1033043969;
				if (num != 0)
				{
				}
				num = (short)1622933504;
				short num3 = num;
				num = (short)2144993280;
				if (num != 0)
				{
				}
				return this.radioErgoConfigAC3rdPartyNotification_A41510.UIName;
			}
		}

		// Token: 0x1700498D RID: 18829
		// (get) Token: 0x060091C9 RID: 37321 RVA: 0x008977D0 File Offset: 0x008959D0
		// (set) Token: 0x060091CA RID: 37322 RVA: 0x00897884 File Offset: 0x00895A84
		internal bool RadioErgoConfigAC3rdPartyNotification_A41510_HiddenStatic
		{
			get
			{
				short num = (short)766543866;
				short num2 = num;
				num = (short)281184250;
				switch (num2 == num)
				{
				}
				num = (short)1146880001;
				if (num != 0)
				{
				}
				num = (short)2107965440;
				short num3 = num;
				num = (short)655884288;
				if (num != 0)
				{
				}
				return this.radioErgoConfigAC3rdPartyNotification_A41510.HiddenStatic;
			}
			set
			{
				short num = (short)2106744238;
				short num2 = num;
				num = (short)1644912046;
				switch (num2 == num)
				{
				}
				num = (short)1310785536;
				if (num != 0)
				{
				}
				num = (short)1364131840;
				short num3 = num;
				num = (short)1370750977;
				if (num != 0)
				{
				}
				this.radioErgoConfigAC3rdPartyNotification_A41510.HiddenStatic = value;
			}
		}

		// Token: 0x1700498E RID: 18830
		// (get) Token: 0x060091CB RID: 37323 RVA: 0x00897938 File Offset: 0x00895B38
		// (set) Token: 0x060091CC RID: 37324 RVA: 0x008979EC File Offset: 0x00895BEC
		internal bool RadioErgoConfigAC3rdPartyNotification_A41510_HiddenDynamic
		{
			get
			{
				short num = (short)540594297;
				short num2 = num;
				num = (short)1895354489;
				switch (num2 == num)
				{
				}
				num = (short)1033502720;
				if (num != 0)
				{
				}
				num = (short)331939840;
				short num3 = num;
				num = (short)333512705;
				if (num != 0)
				{
				}
				return this.radioErgoConfigAC3rdPartyNotification_A41510.HiddenDynamic;
			}
			set
			{
				short num = (short)149400177;
				short num2 = num;
				num = (short)70953585;
				switch (num2 == num)
				{
				}
				num = (short)1843200001;
				if (num != 0)
				{
				}
				num = (short)107937792;
				short num3 = num;
				num = (short)295174144;
				if (num != 0)
				{
				}
				this.radioErgoConfigAC3rdPartyNotification_A41510.HiddenDynamic = value;
			}
		}

		// Token: 0x1700498F RID: 18831
		// (get) Token: 0x060091CD RID: 37325 RVA: 0x00897AA4 File Offset: 0x00895CA4
		public bool RadioErgoConfigAC3rdPartyNotification_A41510_HasDiffs
		{
			get
			{
				short num = (short)1968457854;
				short num2 = num;
				num = (short)405751934;
				switch (num2 == num)
				{
				}
				num = (short)890896385;
				if (num != 0)
				{
				}
				num = (short)936902656;
				short num3 = num;
				num = (short)464125952;
				if (num != 0)
				{
				}
				return this.radioErgoConfigAC3rdPartyNotification_A41510._HasDiffs;
			}
		}

		// Token: 0x17004990 RID: 18832
		// (get) Token: 0x060091CE RID: 37326 RVA: 0x00897B58 File Offset: 0x00895D58
		// (set) Token: 0x060091CF RID: 37327 RVA: 0x00897C0C File Offset: 0x00895E0C
		public int RadioErgoConfigAC3rdPartyNotificationErrorStategy_A41516Value
		{
			get
			{
				short num = (short)654514052;
				short num2 = num;
				num = (short)1360533380;
				switch (num2 == num)
				{
				}
				num = (short)75104256;
				if (num != 0)
				{
				}
				num = (short)1811939328;
				short num3 = num;
				num = (short)2128150529;
				if (num != 0)
				{
				}
				return this.radioErgoConfigAC3rdPartyNotificationErrorStategy_A41516.Value;
			}
			set
			{
				short num = (short)1207450297;
				short num2 = num;
				num = (short)922106553;
				switch (num2 == num)
				{
				}
				num = (short)1644101632;
				if (num != 0)
				{
				}
				num = (short)1492189184;
				short num3 = num;
				num = (short)815136769;
				if (num != 0)
				{
				}
				this.radioErgoConfigAC3rdPartyNotificationErrorStategy_A41516.Value = value;
			}
		}

		// Token: 0x17004991 RID: 18833
		// (get) Token: 0x060091D0 RID: 37328 RVA: 0x00897CC0 File Offset: 0x00895EC0
		// (set) Token: 0x060091D1 RID: 37329 RVA: 0x00897D74 File Offset: 0x00895F74
		public string RadioErgoConfigAC3rdPartyNotificationErrorStategy_A41516_UIValue
		{
			get
			{
				short num = (short)725755835;
				short num2 = num;
				num = (short)1348937659;
				switch (num2 == num)
				{
				}
				num = (short)1337262081;
				if (num != 0)
				{
				}
				num = (short)1587281920;
				short num3 = num;
				num = (short)1433927680;
				if (num != 0)
				{
				}
				return this.radioErgoConfigAC3rdPartyNotificationErrorStategy_A41516.UIValue;
			}
			set
			{
				short num = (short)603673148;
				short num2 = num;
				num = (short)1044992572;
				switch (num2 == num)
				{
				}
				num = (short)496173056;
				if (num != 0)
				{
				}
				num = (short)1213923328;
				short num3 = num;
				num = (short)85458945;
				if (num != 0)
				{
				}
				this.radioErgoConfigAC3rdPartyNotificationErrorStategy_A41516.UIValue = value;
			}
		}

		// Token: 0x17004992 RID: 18834
		// (get) Token: 0x060091D2 RID: 37330 RVA: 0x00897E2C File Offset: 0x0089602C
		public global::AcpBusinessLayer.AcpListField RadioErgoConfigAC3rdPartyNotificationErrorStategy_A41516
		{
			get
			{
				short num = (short)476147998;
				short num2 = num;
				num = (short)546795806;
				switch (num2 == num)
				{
				}
				num = (short)469499905;
				if (num != 0)
				{
				}
				num = (short)2055536640;
				short num3 = num;
				num = (short)1841168384;
				if (num != 0)
				{
				}
				return this.radioErgoConfigAC3rdPartyNotificationErrorStategy_A41516;
			}
		}

		// Token: 0x17004993 RID: 18835
		// (get) Token: 0x060091D3 RID: 37331 RVA: 0x00897EDC File Offset: 0x008960DC
		// (set) Token: 0x060091D4 RID: 37332 RVA: 0x00897F90 File Offset: 0x00896190
		public bool RadioErgoConfigAC3rdPartyNotificationErrorStategy_A41516_Applicable
		{
			get
			{
				short num = (short)1462501377;
				if (num != 0)
				{
				}
				num = (short)2088036397;
				short num2 = num;
				num = (short)629794861;
				switch (num2 == num)
				{
				}
				num = (short)843644928;
				short num3 = num;
				num = (short)232652800;
				if (num != 0)
				{
				}
				return this.radioErgoConfigAC3rdPartyNotificationErrorStategy_A41516.Applicable;
			}
			set
			{
				short num = (short)1946791819;
				short num2 = num;
				num = (short)206876555;
				switch (num2 == num)
				{
				}
				num = (short)970653697;
				if (num != 0)
				{
				}
				num = (short)2065563648;
				short num3 = num;
				num = (short)1914961920;
				if (num != 0)
				{
				}
				this.radioErgoConfigAC3rdPartyNotificationErrorStategy_A41516.Applicable = value;
			}
		}

		// Token: 0x17004994 RID: 18836
		// (get) Token: 0x060091D5 RID: 37333 RVA: 0x00898044 File Offset: 0x00896244
		// (set) Token: 0x060091D6 RID: 37334 RVA: 0x008980FC File Offset: 0x008962FC
		public bool RadioErgoConfigAC3rdPartyNotificationErrorStategy_A41516_Valid
		{
			get
			{
				short num = (short)1978406024;
				short num2 = num;
				num = (short)1654461576;
				switch (num2 == num)
				{
				}
				num = (short)1022885889;
				if (num != 0)
				{
				}
				num = (short)544014336;
				short num3 = num;
				num = (short)416219136;
				if (num != 0)
				{
				}
				return this.radioErgoConfigAC3rdPartyNotificationErrorStategy_A41516.Valid;
			}
			set
			{
				short num = (short)1882352279;
				short num2 = num;
				num = (short)41249431;
				switch (num2 == num)
				{
				}
				num = (short)967704577;
				if (num != 0)
				{
				}
				num = (short)638451712;
				short num3 = num;
				num = (short)1697316864;
				if (num != 0)
				{
				}
				this.radioErgoConfigAC3rdPartyNotificationErrorStategy_A41516.Valid = value;
			}
		}

		// Token: 0x17004995 RID: 18837
		// (get) Token: 0x060091D7 RID: 37335 RVA: 0x008981B0 File Offset: 0x008963B0
		// (set) Token: 0x060091D8 RID: 37336 RVA: 0x00898268 File Offset: 0x00896468
		public bool RadioErgoConfigAC3rdPartyNotificationErrorStategy_A41516_Visible
		{
			get
			{
				short num = (short)2141336131;
				short num2 = num;
				num = (short)1671967299;
				switch (num2 == num)
				{
				}
				num = (short)142278656;
				if (num != 0)
				{
				}
				num = (short)366018560;
				short num3 = num;
				num = (short)570818561;
				if (num != 0)
				{
				}
				return this.radioErgoConfigAC3rdPartyNotificationErrorStategy_A41516.Visible;
			}
			set
			{
				short num = (short)1607439624;
				short num2 = num;
				num = (short)1339528456;
				switch (num2 == num)
				{
				}
				num = (short)590938112;
				if (num != 0)
				{
				}
				num = (short)1280376832;
				short num3 = num;
				num = (short)452460545;
				if (num != 0)
				{
				}
				this.radioErgoConfigAC3rdPartyNotificationErrorStategy_A41516.Visible = value;
			}
		}

		// Token: 0x17004996 RID: 18838
		// (get) Token: 0x060091D9 RID: 37337 RVA: 0x0089831C File Offset: 0x0089651C
		// (set) Token: 0x060091DA RID: 37338 RVA: 0x008983D4 File Offset: 0x008965D4
		public bool RadioErgoConfigAC3rdPartyNotificationErrorStategy_A41516_Editable
		{
			get
			{
				short num = (short)1093435958;
				short num2 = num;
				num = (short)267289142;
				switch (num2 == num)
				{
				}
				num = (short)482017281;
				if (num != 0)
				{
				}
				num = (short)681639936;
				short num3 = num;
				num = (short)1711341568;
				if (num != 0)
				{
				}
				return this.radioErgoConfigAC3rdPartyNotificationErrorStategy_A41516.Editable;
			}
			set
			{
				short num = (short)1980726062;
				short num2 = num;
				num = (short)1435663150;
				switch (num2 == num)
				{
				}
				num = (short)366346241;
				if (num != 0)
				{
				}
				num = (short)1308950528;
				short num3 = num;
				num = (short)2883584;
				if (num != 0)
				{
				}
				this.radioErgoConfigAC3rdPartyNotificationErrorStategy_A41516.Editable = value;
			}
		}

		// Token: 0x17004997 RID: 18839
		// (get) Token: 0x060091DB RID: 37339 RVA: 0x0089848C File Offset: 0x0089668C
		internal string RadioErgoConfigAC3rdPartyNotificationErrorStategy_A41516_UILabel
		{
			get
			{
				short num = (short)1321416078;
				short num2 = num;
				num = (short)1976710542;
				switch (num2 == num)
				{
				}
				num = (short)1835597825;
				if (num != 0)
				{
				}
				num = (short)1149173760;
				short num3 = num;
				num = (short)742981632;
				if (num != 0)
				{
				}
				return this.radioErgoConfigAC3rdPartyNotificationErrorStategy_A41516.UIName;
			}
		}

		// Token: 0x17004998 RID: 18840
		// (get) Token: 0x060091DC RID: 37340 RVA: 0x00898544 File Offset: 0x00896744
		// (set) Token: 0x060091DD RID: 37341 RVA: 0x008985F8 File Offset: 0x008967F8
		internal bool RadioErgoConfigAC3rdPartyNotificationErrorStategy_A41516_HiddenStatic
		{
			get
			{
				short num = (short)1810009210;
				short num2 = num;
				num = (short)2091420794;
				switch (num2 == num)
				{
				}
				num = (short)2101280769;
				if (num != 0)
				{
				}
				num = (short)286392320;
				short num3 = num;
				num = (short)1517289472;
				if (num != 0)
				{
				}
				return this.radioErgoConfigAC3rdPartyNotificationErrorStategy_A41516.HiddenStatic;
			}
			set
			{
				short num = (short)1652012529;
				short num2 = num;
				num = (short)993441265;
				switch (num2 == num)
				{
				}
				num = (short)2124873728;
				if (num != 0)
				{
				}
				num = (short)1845428224;
				short num3 = num;
				num = (short)1232076801;
				if (num != 0)
				{
				}
				this.radioErgoConfigAC3rdPartyNotificationErrorStategy_A41516.HiddenStatic = value;
			}
		}

		// Token: 0x17004999 RID: 18841
		// (get) Token: 0x060091DE RID: 37342 RVA: 0x008986B0 File Offset: 0x008968B0
		// (set) Token: 0x060091DF RID: 37343 RVA: 0x00898764 File Offset: 0x00896964
		internal bool RadioErgoConfigAC3rdPartyNotificationErrorStategy_A41516_HiddenDynamic
		{
			get
			{
				short num = (short)710141394;
				short num2 = num;
				num = (short)1232004562;
				switch (num2 == num)
				{
				}
				num = (short)2117206017;
				if (num != 0)
				{
				}
				num = (short)1626734592;
				short num3 = num;
				num = (short)1714552832;
				if (num != 0)
				{
				}
				return this.radioErgoConfigAC3rdPartyNotificationErrorStategy_A41516.HiddenDynamic;
			}
			set
			{
				short num = (short)976931988;
				short num2 = num;
				num = (short)1761791124;
				switch (num2 == num)
				{
				}
				num = (short)1124990977;
				if (num != 0)
				{
				}
				num = (short)1476853760;
				if (num != 0)
				{
				}
				num = (short)438239232;
				short num3 = num;
				this.radioErgoConfigAC3rdPartyNotificationErrorStategy_A41516.HiddenDynamic = value;
			}
		}

		// Token: 0x1700499A RID: 18842
		// (get) Token: 0x060091E0 RID: 37344 RVA: 0x0089881C File Offset: 0x00896A1C
		public bool RadioErgoConfigAC3rdPartyNotificationErrorStategy_A41516_HasDiffs
		{
			get
			{
				short num = (short)228293408;
				short num2 = num;
				num = (short)1604549408;
				switch (num2 == num)
				{
				}
				num = (short)1168769025;
				if (num != 0)
				{
				}
				num = (short)843186176;
				if (num != 0)
				{
				}
				num = (short)867106816;
				short num3 = num;
				return this.radioErgoConfigAC3rdPartyNotificationErrorStategy_A41516._HasDiffs;
			}
		}

		// Token: 0x1700499B RID: 18843
		// (get) Token: 0x060091E1 RID: 37345 RVA: 0x008988D0 File Offset: 0x00896AD0
		// (set) Token: 0x060091E2 RID: 37346 RVA: 0x00898984 File Offset: 0x00896B84
		public int RadioErgoConfigACActionType_A42871Value
		{
			get
			{
				short num = (short)825028898;
				short num2 = num;
				num = (short)1389228322;
				switch (num2 == num)
				{
				}
				num = (short)286654465;
				if (num != 0)
				{
				}
				num = (short)1858011136;
				if (num != 0)
				{
				}
				num = (short)667353088;
				short num3 = num;
				return this.radioErgoConfigACActionType_A42871.Value;
			}
			set
			{
				short num = (short)665753710;
				short num2 = num;
				num = (short)1709807726;
				switch (num2 == num)
				{
				}
				num = (short)2117664769;
				if (num != 0)
				{
				}
				num = (short)331481088;
				if (num != 0)
				{
				}
				num = (short)1748893696;
				short num3 = num;
				this.radioErgoConfigACActionType_A42871.Value = value;
			}
		}

		// Token: 0x1700499C RID: 18844
		// (get) Token: 0x060091E3 RID: 37347 RVA: 0x00898A38 File Offset: 0x00896C38
		// (set) Token: 0x060091E4 RID: 37348 RVA: 0x00898AEC File Offset: 0x00896CEC
		public string RadioErgoConfigACActionType_A42871_UIValue
		{
			get
			{
				short num = (short)1840554566;
				short num2 = num;
				num = (short)551199302;
				switch (num2 == num)
				{
				}
				num = (short)640090113;
				if (num != 0)
				{
				}
				num = (short)819396608;
				if (num != 0)
				{
				}
				num = (short)1714749440;
				short num3 = num;
				return this.radioErgoConfigACActionType_A42871.UIValue;
			}
			set
			{
				short num = (short)767688705;
				if (num != 0)
				{
				}
				num = (short)577707868;
				short num2 = num;
				num = (short)1846026076;
				switch (num2 == num)
				{
				}
				num = (short)1706033152;
				if (num != 0)
				{
				}
				num = (short)1958150144;
				short num3 = num;
				this.radioErgoConfigACActionType_A42871.UIValue = value;
			}
		}

		// Token: 0x1700499D RID: 18845
		// (get) Token: 0x060091E5 RID: 37349 RVA: 0x00898BA0 File Offset: 0x00896DA0
		public global::AcpBusinessLayer.AcpListField RadioErgoConfigACActionType_A42871
		{
			get
			{
				short num = (short)1195467590;
				short num2 = num;
				num = (short)1884119878;
				switch (num2 == num)
				{
				}
				num = (short)1267662849;
				if (num != 0)
				{
				}
				num = (short)1437925376;
				if (num != 0)
				{
				}
				num = (short)1027932160;
				short num3 = num;
				return this.radioErgoConfigACActionType_A42871;
			}
		}

		// Token: 0x1700499E RID: 18846
		// (get) Token: 0x060091E6 RID: 37350 RVA: 0x00898C50 File Offset: 0x00896E50
		// (set) Token: 0x060091E7 RID: 37351 RVA: 0x00898D04 File Offset: 0x00896F04
		public bool RadioErgoConfigACActionType_A42871_Applicable
		{
			get
			{
				short num = (short)1504847506;
				short num2 = num;
				num = (short)1965631122;
				switch (num2 == num)
				{
				}
				num = (short)410976257;
				if (num != 0)
				{
				}
				num = (short)1850474496;
				if (num != 0)
				{
				}
				num = (short)1156644864;
				short num3 = num;
				return this.radioErgoConfigACActionType_A42871.Applicable;
			}
			set
			{
				short num = (short)1043660801;
				if (num != 0)
				{
				}
				num = (short)769058287;
				short num2 = num;
				num = (short)468772335;
				switch (num2 == num)
				{
				}
				num = (short)379060224;
				if (num != 0)
				{
				}
				num = (short)39190528;
				short num3 = num;
				this.radioErgoConfigACActionType_A42871.Applicable = value;
			}
		}

		// Token: 0x1700499F RID: 18847
		// (get) Token: 0x060091E8 RID: 37352 RVA: 0x00898DB8 File Offset: 0x00896FB8
		// (set) Token: 0x060091E9 RID: 37353 RVA: 0x00898E6C File Offset: 0x0089706C
		public bool RadioErgoConfigACActionType_A42871_Valid
		{
			get
			{
				short num = (short)331808769;
				if (num != 0)
				{
				}
				num = (short)328276697;
				short num2 = num;
				num = (short)490412761;
				switch (num2 == num)
				{
				}
				num = (short)379453440;
				if (num != 0)
				{
				}
				num = (short)987430912;
				short num3 = num;
				return this.radioErgoConfigACActionType_A42871.Valid;
			}
			set
			{
				short num = (short)496974679;
				short num2 = num;
				num = (short)1037777751;
				switch (num2 == num)
				{
				}
				num = (short)1766719489;
				if (num != 0)
				{
				}
				num = (short)890241024;
				if (num != 0)
				{
				}
				num = (short)1879048192;
				short num3 = num;
				this.radioErgoConfigACActionType_A42871.Valid = value;
			}
		}

		// Token: 0x170049A0 RID: 18848
		// (get) Token: 0x060091EA RID: 37354 RVA: 0x00898F20 File Offset: 0x00897120
		// (set) Token: 0x060091EB RID: 37355 RVA: 0x00898FD8 File Offset: 0x008971D8
		public bool RadioErgoConfigACActionType_A42871_Visible
		{
			get
			{
				short num = (short)101965442;
				short num2 = num;
				num = (short)183295618;
				switch (num2 == num)
				{
				}
				num = (short)2138963969;
				if (num != 0)
				{
				}
				num = (short)1981677568;
				if (num != 0)
				{
				}
				num = (short)372965376;
				short num3 = num;
				return this.radioErgoConfigACActionType_A42871.Visible;
			}
			set
			{
				short num = (short)1914241025;
				if (num != 0)
				{
				}
				num = (short)464327494;
				short num2 = num;
				num = (short)1755190086;
				switch (num2 == num)
				{
				}
				num = (short)783745024;
				if (num != 0)
				{
				}
				num = (short)1243545600;
				short num3 = num;
				this.radioErgoConfigACActionType_A42871.Visible = value;
			}
		}

		// Token: 0x170049A1 RID: 18849
		// (get) Token: 0x060091EC RID: 37356 RVA: 0x00899090 File Offset: 0x00897290
		// (set) Token: 0x060091ED RID: 37357 RVA: 0x00899144 File Offset: 0x00897344
		public bool RadioErgoConfigACActionType_A42871_Editable
		{
			get
			{
				short num = (short)505389648;
				short num2 = num;
				num = (short)817406544;
				switch (num2 == num)
				{
				}
				num = (short)1606877184;
				if (num != 0)
				{
				}
				num = (short)621346817;
				if (num != 0)
				{
				}
				num = (short)1591148544;
				short num3 = num;
				return this.radioErgoConfigACActionType_A42871.Editable;
			}
			set
			{
				short num = (short)1775502361;
				short num2 = num;
				num = (short)1243874329;
				switch (num2 == num)
				{
				}
				num = (short)1867448320;
				if (num != 0)
				{
				}
				num = (short)1698103297;
				if (num != 0)
				{
				}
				num = (short)109641728;
				short num3 = num;
				this.radioErgoConfigACActionType_A42871.Editable = value;
			}
		}

		// Token: 0x170049A2 RID: 18850
		// (get) Token: 0x060091EE RID: 37358 RVA: 0x008991F8 File Offset: 0x008973F8
		internal string RadioErgoConfigACActionType_A42871_UILabel
		{
			get
			{
				short num = (short)552534017;
				if (num != 0)
				{
				}
				num = (short)54003715;
				short num2 = num;
				num = (short)314509315;
				switch (num2 == num)
				{
				}
				num = (short)1274871808;
				if (num != 0)
				{
				}
				num = (short)1070661632;
				short num3 = num;
				return this.radioErgoConfigACActionType_A42871.UIName;
			}
		}

		// Token: 0x170049A3 RID: 18851
		// (get) Token: 0x060091EF RID: 37359 RVA: 0x008992AC File Offset: 0x008974AC
		// (set) Token: 0x060091F0 RID: 37360 RVA: 0x00899360 File Offset: 0x00897560
		internal bool RadioErgoConfigACActionType_A42871_HiddenStatic
		{
			get
			{
				short num = (short)394655299;
				short num2 = num;
				num = (short)939456067;
				switch (num2 == num)
				{
				}
				num = (short)482869249;
				if (num != 0)
				{
				}
				num = (short)1353646080;
				if (num != 0)
				{
				}
				num = (short)262733824;
				short num3 = num;
				return this.radioErgoConfigACActionType_A42871.HiddenStatic;
			}
			set
			{
				short num = (short)632865015;
				short num2 = num;
				num = (short)613531895;
				switch (num2 == num)
				{
				}
				num = (short)205651968;
				if (num != 0)
				{
				}
				num = (short)577634305;
				if (num != 0)
				{
				}
				num = (short)559546368;
				short num3 = num;
				this.radioErgoConfigACActionType_A42871.HiddenStatic = value;
			}
		}

		// Token: 0x170049A4 RID: 18852
		// (get) Token: 0x060091F1 RID: 37361 RVA: 0x00899414 File Offset: 0x00897614
		// (set) Token: 0x060091F2 RID: 37362 RVA: 0x008994C8 File Offset: 0x008976C8
		internal bool RadioErgoConfigACActionType_A42871_HiddenDynamic
		{
			get
			{
				short num = (short)43518900;
				short num2 = num;
				num = (short)109448116;
				switch (num2 == num)
				{
				}
				num = (short)2089680897;
				if (num != 0)
				{
				}
				num = (short)16842752;
				if (num != 0)
				{
				}
				num = (short)1981415424;
				short num3 = num;
				return this.radioErgoConfigACActionType_A42871.HiddenDynamic;
			}
			set
			{
				short num = (short)43507342;
				short num2 = num;
				num = (short)1954012814;
				switch (num2 == num)
				{
				}
				num = (short)110034944;
				short num3 = num;
				num = (short)2033778689;
				if (num != 0)
				{
				}
				num = (short)285409280;
				if (num != 0)
				{
				}
				this.radioErgoConfigACActionType_A42871.HiddenDynamic = value;
			}
		}

		// Token: 0x170049A5 RID: 18853
		// (get) Token: 0x060091F3 RID: 37363 RVA: 0x00899580 File Offset: 0x00897780
		public bool RadioErgoConfigACActionType_A42871_HasDiffs
		{
			get
			{
				short num = (short)851306087;
				short num2 = num;
				num = (short)165406311;
				switch (num2 == num)
				{
				}
				num = (short)741670912;
				short num3 = num;
				num = (short)569114625;
				if (num != 0)
				{
				}
				num = (short)1222836224;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACActionType_A42871._HasDiffs;
			}
		}

		// Token: 0x170049A6 RID: 18854
		// (get) Token: 0x060091F4 RID: 37364 RVA: 0x00899638 File Offset: 0x00897838
		// (set) Token: 0x060091F5 RID: 37365 RVA: 0x008996EC File Offset: 0x008978EC
		public int RadioErgoConfigACAlertVisualResponse_A42878Value
		{
			get
			{
				short num = (short)440914272;
				short num2 = num;
				num = (short)2079314272;
				switch (num2 == num)
				{
				}
				num = (short)210960384;
				short num3 = num;
				num = (short)1193017345;
				if (num != 0)
				{
				}
				num = (short)343277568;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACAlertVisualResponse_A42878.Value;
			}
			set
			{
				short num = (short)2104065380;
				short num2 = num;
				num = (short)1952611684;
				switch (num2 == num)
				{
				}
				num = (short)1550974976;
				short num3 = num;
				num = (short)1033633792;
				if (num != 0)
				{
				}
				num = (short)1576468481;
				if (num != 0)
				{
				}
				this.radioErgoConfigACAlertVisualResponse_A42878.Value = value;
			}
		}

		// Token: 0x170049A7 RID: 18855
		// (get) Token: 0x060091F6 RID: 37366 RVA: 0x008997A4 File Offset: 0x008979A4
		// (set) Token: 0x060091F7 RID: 37367 RVA: 0x0089985C File Offset: 0x00897A5C
		public string RadioErgoConfigACAlertVisualResponse_A42878_UIValue
		{
			get
			{
				short num = (short)1068342781;
				short num2 = num;
				num = (short)1634049533;
				switch (num2 == num)
				{
				}
				num = (short)222429184;
				short num3 = num;
				num = (short)1863909377;
				if (num != 0)
				{
				}
				num = (short)1655635968;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACAlertVisualResponse_A42878.UIValue;
			}
			set
			{
				short num = (short)1905402751;
				short num2 = num;
				num = (short)586294143;
				switch (num2 == num)
				{
				}
				num = (short)1584529408;
				short num3 = num;
				num = (short)169803777;
				if (num != 0)
				{
				}
				num = (short)1791950848;
				if (num != 0)
				{
				}
				this.radioErgoConfigACAlertVisualResponse_A42878.UIValue = value;
			}
		}

		// Token: 0x170049A8 RID: 18856
		// (get) Token: 0x060091F8 RID: 37368 RVA: 0x00899914 File Offset: 0x00897B14
		public global::AcpBusinessLayer.AcpListField RadioErgoConfigACAlertVisualResponse_A42878
		{
			get
			{
				short num = (short)198216596;
				short num2 = num;
				num = (short)171608980;
				switch (num2 == num)
				{
				}
				num = (short)82444288;
				short num3 = num;
				num = (short)2061500417;
				if (num != 0)
				{
				}
				num = (short)301268992;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACAlertVisualResponse_A42878;
			}
		}

		// Token: 0x170049A9 RID: 18857
		// (get) Token: 0x060091F9 RID: 37369 RVA: 0x008999C4 File Offset: 0x00897BC4
		// (set) Token: 0x060091FA RID: 37370 RVA: 0x00899A7C File Offset: 0x00897C7C
		public bool RadioErgoConfigACAlertVisualResponse_A42878_Applicable
		{
			get
			{
				short num = (short)1138388554;
				short num2 = num;
				num = (short)1699901002;
				switch (num2 == num)
				{
				}
				num = (short)1041891328;
				short num3 = num;
				num = (short)1613692928;
				if (num != 0)
				{
				}
				num = (short)511442945;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACAlertVisualResponse_A42878.Applicable;
			}
			set
			{
				short num = (short)650051585;
				if (num != 0)
				{
				}
				num = (short)1111414693;
				short num2 = num;
				num = (short)208656293;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1159593984;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)110952448;
				if (num != 0)
				{
				}
				this.radioErgoConfigACAlertVisualResponse_A42878.Applicable = value;
			}
		}

		// Token: 0x170049AA RID: 18858
		// (get) Token: 0x060091FB RID: 37371 RVA: 0x00899B30 File Offset: 0x00897D30
		// (set) Token: 0x060091FC RID: 37372 RVA: 0x00899BE4 File Offset: 0x00897DE4
		public bool RadioErgoConfigACAlertVisualResponse_A42878_Valid
		{
			get
			{
				short num = (short)1074938364;
				short num2 = num;
				num = (short)2029928956;
				switch (num2 == num)
				{
				}
				num = (short)567934976;
				short num3 = num;
				num = (short)923467776;
				if (num != 0)
				{
				}
				num = (short)1683357697;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACAlertVisualResponse_A42878.Valid;
			}
			set
			{
				short num = (short)1411533526;
				short num2 = num;
				num = (short)1204308694;
				switch (num2 == num)
				{
				}
				num = (short)1638727680;
				short num3 = num;
				num = (short)761593856;
				if (num != 0)
				{
				}
				num = (short)1648230401;
				if (num != 0)
				{
				}
				this.radioErgoConfigACAlertVisualResponse_A42878.Valid = value;
			}
		}

		// Token: 0x170049AB RID: 18859
		// (get) Token: 0x060091FD RID: 37373 RVA: 0x00899C98 File Offset: 0x00897E98
		// (set) Token: 0x060091FE RID: 37374 RVA: 0x00899D4C File Offset: 0x00897F4C
		public bool RadioErgoConfigACAlertVisualResponse_A42878_Visible
		{
			get
			{
				short num = (short)1072182100;
				short num2 = num;
				num = (short)1795568468;
				switch (num2 == num)
				{
				}
				num = (short)561184768;
				short num3 = num;
				num = (short)960823297;
				if (num != 0)
				{
				}
				num = (short)1147404288;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACAlertVisualResponse_A42878.Visible;
			}
			set
			{
				short num = (short)75300865;
				if (num != 0)
				{
				}
				num = (short)1137177164;
				short num2 = num;
				num = (short)155710028;
				switch (num2 == num)
				{
				default:
				{
					num = (short)720437248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2131034112;
				if (num != 0)
				{
				}
				this.radioErgoConfigACAlertVisualResponse_A42878.Visible = value;
			}
		}

		// Token: 0x170049AC RID: 18860
		// (get) Token: 0x060091FF RID: 37375 RVA: 0x00899E04 File Offset: 0x00898004
		// (set) Token: 0x06009200 RID: 37376 RVA: 0x00899EB4 File Offset: 0x008980B4
		public bool RadioErgoConfigACAlertVisualResponse_A42878_Editable
		{
			get
			{
				short num = (short)1037059177;
				short num2 = num;
				num = (short)541801;
				switch (num2 == num)
				{
				}
				num = (short)1626931200;
				short num3 = num;
				num = (short)936509441;
				if (num != 0)
				{
				}
				num = (short)1962344448;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACAlertVisualResponse_A42878.Editable;
			}
			set
			{
				short num = (short)168206888;
				short num2 = num;
				num = (short)1077453352;
				switch (num2 == num)
				{
				}
				num = (short)1279918080;
				short num3 = num;
				num = (short)1970470912;
				if (num != 0)
				{
				}
				num = (short)40435713;
				if (num != 0)
				{
				}
				this.radioErgoConfigACAlertVisualResponse_A42878.Editable = value;
			}
		}

		// Token: 0x170049AD RID: 18861
		// (get) Token: 0x06009201 RID: 37377 RVA: 0x00899F68 File Offset: 0x00898168
		internal string RadioErgoConfigACAlertVisualResponse_A42878_UILabel
		{
			get
			{
				short num = (short)1054380314;
				short num2 = num;
				num = (short)1969590554;
				switch (num2 == num)
				{
				}
				num = (short)676331520;
				short num3 = num;
				num = (short)239337473;
				if (num != 0)
				{
				}
				num = (short)1929248768;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACAlertVisualResponse_A42878.UIName;
			}
		}

		// Token: 0x170049AE RID: 18862
		// (get) Token: 0x06009202 RID: 37378 RVA: 0x0089A01C File Offset: 0x0089821C
		// (set) Token: 0x06009203 RID: 37379 RVA: 0x0089A0D0 File Offset: 0x008982D0
		internal bool RadioErgoConfigACAlertVisualResponse_A42878_HiddenStatic
		{
			get
			{
				short num = (short)1356551512;
				short num2 = num;
				num = (short)1217353048;
				switch (num2 == num)
				{
				}
				num = (short)904265728;
				short num3 = num;
				num = (short)1671364609;
				if (num != 0)
				{
				}
				num = (short)55574528;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACAlertVisualResponse_A42878.HiddenStatic;
			}
			set
			{
				short num = (short)1738586447;
				short num2 = num;
				num = (short)2107488591;
				switch (num2 == num)
				{
				}
				num = (short)209911808;
				short num3 = num;
				num = (short)451674113;
				if (num != 0)
				{
				}
				num = (short)1397555200;
				if (num != 0)
				{
				}
				this.radioErgoConfigACAlertVisualResponse_A42878.HiddenStatic = value;
			}
		}

		// Token: 0x170049AF RID: 18863
		// (get) Token: 0x06009204 RID: 37380 RVA: 0x0089A188 File Offset: 0x00898388
		// (set) Token: 0x06009205 RID: 37381 RVA: 0x0089A23C File Offset: 0x0089843C
		internal bool RadioErgoConfigACAlertVisualResponse_A42878_HiddenDynamic
		{
			get
			{
				short num = (short)1237037072;
				short num2 = num;
				num = (short)1324920848;
				switch (num2 == num)
				{
				}
				num = (short)1898184704;
				short num3 = num;
				num = (short)43778049;
				if (num != 0)
				{
				}
				num = (short)2062286848;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACAlertVisualResponse_A42878.HiddenDynamic;
			}
			set
			{
				short num = (short)1722250558;
				short num2 = num;
				num = (short)249460030;
				switch (num2 == num)
				{
				}
				num = (short)289996800;
				short num3 = num;
				num = (short)20512769;
				if (num != 0)
				{
				}
				num = (short)566427648;
				if (num != 0)
				{
				}
				this.radioErgoConfigACAlertVisualResponse_A42878.HiddenDynamic = value;
			}
		}

		// Token: 0x170049B0 RID: 18864
		// (get) Token: 0x06009206 RID: 37382 RVA: 0x0089A2F0 File Offset: 0x008984F0
		public bool RadioErgoConfigACAlertVisualResponse_A42878_HasDiffs
		{
			get
			{
				short num = (short)393223004;
				short num2 = num;
				num = (short)663427932;
				switch (num2 == num)
				{
				}
				num = (short)1451753472;
				short num3 = num;
				num = (short)966852608;
				if (num != 0)
				{
				}
				num = (short)83296257;
				if (num != 0)
				{
				}
				return this.radioErgoConfigACAlertVisualResponse_A42878._HasDiffs;
			}
		}

		// Token: 0x170049B1 RID: 18865
		// (get) Token: 0x06009207 RID: 37383 RVA: 0x0089A3A4 File Offset: 0x008985A4
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)414696564;
				short num2 = num;
				num = (short)1680721012;
				switch (num2 == num)
				{
				}
				num = (short)1421606912;
				short num3 = num;
				num = (short)339345408;
				if (num != 0)
				{
				}
				num = (short)2067791873;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x170049B2 RID: 18866
		// (get) Token: 0x06009208 RID: 37384 RVA: 0x0089A464 File Offset: 0x00898664
		public global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide RefRadioErgonomicsWide
		{
			get
			{
				short num = (short)1594567594;
				short num2 = num;
				num = (short)71379882;
				switch (num2 == num)
				{
				}
				num = (short)1362427904;
				short num3 = num;
				num = (short)103219201;
				if (num != 0)
				{
				}
				num = (short)328335360;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide;
			}
		}

		// Token: 0x06009209 RID: 37385 RVA: 0x0089A524 File Offset: 0x00898724
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)621805569;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_4B;
			}
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_31:
				int num2;
				switch (num2)
				{
				case 0:
					return result;
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)458883075;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 2:
					goto IL_D2;
				case 3:
				{
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)2001862656;
					short num3 = num;
					num = (short)1132199936;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					if (base.ParentRecset != null)
					{
						num = (short)2094071810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				}
				goto IL_4B;
			}
			return result;
			IL_4B:
			num = (short)1519815471;
			short num4 = num;
			num = (short)1958906671;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_D2:
				num = (short)184745985;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			default:
			{
				num = (short)831062016;
				if (num != 0)
				{
				}
				result = null;
				num = (short)702087172;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x04004880 RID: 18560
		private global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ConsolidatedActionsInnerRecset innerRecset;

		// Token: 0x04004881 RID: 18561
		private global::AcpBusinessLayer.AcpFieldX<bool, string> radioErgoConfigACGeneralActionAllowed_A36579;

		// Token: 0x04004882 RID: 18562
		private global::AcpBusinessLayer.AcpKeyField radioErgoConfigACName_A36581;

		// Token: 0x04004883 RID: 18563
		private global::AcpBusinessLayer.AcpRecRefField radioErgoConfigACRelayPattern_A36582;

		// Token: 0x04004884 RID: 18564
		private global::AcpBusinessLayer.AcpListField radioErgoConfigACRelayPatternErrStrategy_A36583;

		// Token: 0x04004885 RID: 18565
		private global::AcpBusinessLayer.AcpListField radioErgoConfigACSirenType_A36584;

		// Token: 0x04004886 RID: 18566
		private global::AcpBusinessLayer.AcpListField radioErgoConfigACSirenTypeErrStrategy_A36585;

		// Token: 0x04004887 RID: 18567
		private global::AcpBusinessLayer.AcpField<bool> radioErgoConfigACGpsReport_A36587;

		// Token: 0x04004888 RID: 18568
		private global::AcpBusinessLayer.AcpListField radioErgoConfigACGpsReportErrStrategy_A36588;

		// Token: 0x04004889 RID: 18569
		private global::AcpBusinessLayer.AcpListField radioErgoConfigAC3rdPartyNotification_A41510;

		// Token: 0x0400488A RID: 18570
		private global::AcpBusinessLayer.AcpListField radioErgoConfigAC3rdPartyNotificationErrorStategy_A41516;

		// Token: 0x0400488B RID: 18571
		private global::AcpBusinessLayer.AcpListField radioErgoConfigACActionType_A42871;

		// Token: 0x0400488C RID: 18572
		private global::AcpBusinessLayer.AcpListField radioErgoConfigACAlertVisualResponse_A42878;
	}
}
