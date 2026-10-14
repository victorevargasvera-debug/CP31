using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x02000172 RID: 370
	[global::System.Serializable]
	public class Fireground : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06003380 RID: 13184 RVA: 0x0031A220 File Offset: 0x00318420
		public Fireground(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06003381 RID: 13185 RVA: 0x0031A23C File Offset: 0x0031843C
		protected Fireground(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06003382 RID: 13186 RVA: 0x0031A254 File Offset: 0x00318454
		public override void Init()
		{
			int a_ = 13;
			short num = (short)923046395;
			short num2 = num;
			num = (short)1630769659;
			switch (num2 == num)
			{
			}
			num = (short)1355218945;
			if (num != 0)
			{
			}
			num = (short)1794244608;
			short num3 = num;
			num = (short)1043857408;
			if (num != 0)
			{
			}
			this.radWideTPSFiregroundEmergencyPTTTransmission_A33203 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.indexRadWideTPSFiregroundEmergencyPTTTransmission_A33203LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.idRadWideTPSFiregroundEmergencyPTTTransmission_A33203LovStrs), this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙裛軝돟ꓡ跣铥跧跩黫臭藯鳱郳돵闷鿹軻駽旿氁會缅堇帉堋娍戏猑稓攕甗猙漛洝䤟䴡䨣礥椧ᤩἫᰭ/ı", a_), global::CommonResources.AcgResources.ID_CONVENTIONALCONFIGURATIONPERSONNELACCOUNTABILITYEMERGENCYPTTTRANSMISSION, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideTPSFiregroundEmergencyPTTTransmission_A33203LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LegacyTitles.RadWideTPSFiregroundEmergencyPTTTransmission_A33203LegacyTitles);
			this.radWideTPSFiregroundEmergencyPTTTransmission_A33203.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideTPSFiregroundEmergencyPTTTransmission_A33203.DataTransferOrder = 24;
			this.radWideTPSFiregroundEvacuationAcknowledgement_A33216 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙裛軝돟ꓡ跣铥跧跩黫臭藯鳱郳돵軷鯹鿻诽懿瘁洃椅昇䬉漋攍縏紑挓稕紗縙笛笝䴟䜡䨣別眧欩Ἣᴭȯ̱ȳ", a_), global::CommonResources.AcgResources.ID_CONVENTIONALCONFIGURATIONEVACUATIONACKNOWLEDGEMENT, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideTPSFiregroundEvacuationAcknowledgement_A33216LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LegacyTitles.RadWideTPSFiregroundEvacuationAcknowledgement_A33216LegacyTitles);
			this.radWideTPSFiregroundEvacuationAcknowledgement_A33216.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideTPSFiregroundEvacuationAcknowledgement_A33216.DataTransferOrder = 25;
			this.radWideTPSFiregroundPeriodicUpdateTimer_A33467 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙裛軝돟ꓡ跣铥跧跩黫臭藯鳱郳꛵鷷裹闻釽擿欁會包砇渉洋稍甏䘑紓笕紗栙䌛弝ጟᄡဣဥἧ", a_), global::CommonResources.AcgResources.ID_CONVENTIONALCONFIGURATIONPERIODICUPDATETIMERMIN, 0, 20, global::CommonResources.AcgResources.ID_DISABLED, null, 0, 1, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LegacyTitles.RadWideTPSFiregroundPeriodicUpdateTimer_A33467LegacyTitles);
			this.radWideTPSFiregroundPeriodicUpdateTimer_A33467.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideTPSFiregroundPeriodicUpdateTimer_A33467.DataTransferOrder = 88;
			this.radWideTPSFiregroundPeriodicUpdateTimer_A33467.ShowHexValue = false;
			this.radWideFiregroundPTTTransmission_A33515 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.indexRadWideFiregroundPTTTransmission_A33515LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.idRadWideFiregroundPTTTransmission_A33515LovStrs), this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙髛럝鋟蟡菣铥蟧鿩苫諭ꃯ꛱ꃳꋵ諷鯹鋻跽淿欁眃甅愇攉戋儍儏ℑ✓⌕⤗⼙", a_), global::CommonResources.AcgResources.ID_CONVENTIONALCONFIGURATIONPERSONNELACCOUNTABILITYPTTTRANSMISSION, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideFiregroundPTTTransmission_A33515LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LegacyTitles.RadWideFiregroundPTTTransmission_A33515LegacyTitles);
			this.radWideFiregroundPTTTransmission_A33515.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideFiregroundPTTTransmission_A33515.DataTransferOrder = 32;
			this.radWideTPSFiregroundRespondToPolls_A33573 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙裛軝돟ꓡ跣铥跧跩黫臭藯鳱郳ꓵ鷷觹賻釽滿昁倃椅堇攉怋戍挏䴑唓┕⬗⼙⬛ⴝ", a_), global::CommonResources.AcgResources.ID_CONVENTIONALCONFIGURATIONRESPONDTOPOLLS, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LegacyTitles.RadWideTPSFiregroundRespondToPolls_A33573LegacyTitles);
			this.radWideTPSFiregroundRespondToPolls_A33573.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.radWideTPSFiregroundRespondToPolls_A33573.DataTransferOrder = 34;
			this.radWidePAACKAlertsonPTT_A43099 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("鳍뇏뛑菓뿕볗뿙賛鿝ꇟꇡ꿣꟥蓧迩黫髭華鷱髳꛵곷껹ꏻ뿽㓿㄁㐃㼅ㄇ", a_), global::CommonResources.AcgResources.ID_ACKNOWLEDGEALERTSONPTT);
			this.radWidePAACKAlertsonPTT_A43099.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radWidePAACKAlertsonPTT_A43099.DataTransferOrder = 60;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("黍뗏ꃑꟓ맕뛗듙맛닝샟ꏡ蟣藥蟧鿩苫髭釯郱鷳髵釷軹藻", a_);
			base.Id = 10750;
			base.UIName = global::CommonResources.AcgResources.ID_PERSONNELACCOUNTABILITY;
			base.DataTransferOrder = 18;
		}

		// Token: 0x06003383 RID: 13187 RVA: 0x0031A4EC File Offset: 0x003186EC
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 9;
			short num = (short)1492254735;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕黗동껛믝蟟郡诣鏥蛧軩볫뫭ꓯ꛱蛳韵雷觹釻韽珿焁洃椅昇唉䴋㴍⌏✑┓⌕", a_)))
					{
						num = (short)704380945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F8;
				case 1:
					goto IL_32A;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕裗鯙鷛鷝ꯟꏡ裣菥髧黩鿫臭黯ꋱꃳꋵꟷ믹죻췽ヿ㬁㴃", a_)))
					{
						num = (short)1505492993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5AD;
				case 3:
					goto IL_F8;
				case 4:
					this.radWideTPSFiregroundEmergencyPTTTransmission_A33203 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.indexRadWideTPSFiregroundEmergencyPTTTransmission_A33203LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.idRadWideTPSFiregroundEmergencyPTTTransmission_A33203LovStrs), this, global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕賗諙进飝觟郡臣臥髧藩駫胭铯럱駳鏵諷鷹駻都揿笁吃刅將帉縋漍縏愑礓缕欗椙甛焝丟紡攣ᔥᬧᠩᰫᴭ", a_), global::CommonResources.AcgResources.ID_CONVENTIONALCONFIGURATIONPERSONNELACCOUNTABILITYEMERGENCYPTTTRANSMISSION, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideTPSFiregroundEmergencyPTTTransmission_A33203LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LegacyTitles.RadWideTPSFiregroundEmergencyPTTTransmission_A33203LegacyTitles);
					this.radWideTPSFiregroundEmergencyPTTTransmission_A33203.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideTPSFiregroundEmergencyPTTTransmission_A33203.DataTransferOrder = 24;
					num = (short)1902116880;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕賗諙进飝觟郡臣臥髧藩駫胭铯럱駳鏵諷鷹駻都揿笁吃刅將帉縋漍縏愑礓缕欗椙甛焝丟紡攣ᔥᬧᠩᰫᴭ", a_)))
					{
						num = (short)1234960388;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3F7;
				case 6:
					if (producerFields != null)
					{
						num = (short)143982613;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5AD;
				case 7:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕賗諙进飝觟郡臣臥髧藩駫胭铯ꃱ釳藵裷闹鋻髽哿洁吃椅搇昉缋儍儏ℑ✓⌕⼗⤙", a_)))
					{
						num = (short)154992648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_220;
				case 8:
					this.radWideTPSFiregroundRespondToPolls_A33573 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕賗諙进飝觟郡臣臥髧藩駫胭铯ꃱ釳藵裷闹鋻髽哿洁吃椅搇昉缋儍儏ℑ✓⌕⼗⤙", a_), global::CommonResources.AcgResources.ID_CONVENTIONALCONFIGURATIONRESPONDTOPOLLS, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LegacyTitles.RadWideTPSFiregroundRespondToPolls_A33573LegacyTitles);
					this.radWideTPSFiregroundRespondToPolls_A33573.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideTPSFiregroundRespondToPolls_A33573.DataTransferOrder = 34;
					num = (short)317980685;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕賗諙进飝觟郡臣臥髧藩駫胭铯ꋱ釳蓵釷闹飻韽揿圁球戅椇縉椋娍礏缑焓搕䜗嬙⼛ⴝᐟᐡጣ", a_)))
					{
						num = (short)1074593806;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4C6;
				case 10:
					goto IL_4C6;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕賗諙进飝觟郡臣臥髧藩駫胭铯럱苳韵鯷迹鷻諽槿洁樃䜅欇愉戋愍朏縑焓爕缗缙焛笝丟嘡笣朥ᬧᤩḫἭد", a_)))
					{
						num = (short)1160511506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3AA;
				case 12:
					goto IL_3AA;
				case 13:
				{
					num = (short)622788608;
					short num3 = num;
					goto IL_220;
				}
				case 14:
					this.radWideTPSFiregroundPeriodicUpdateTimer_A33467 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕賗諙进飝觟郡臣臥髧藩駫胭铯ꋱ釳蓵釷闹飻韽揿圁球戅椇縉椋娍礏缑焓搕䜗嬙⼛ⴝᐟᐡጣ", a_), global::CommonResources.AcgResources.ID_CONVENTIONALCONFIGURATIONPERIODICUPDATETIMERMIN, global::CommonResources.AcgResources.ID_DISABLED, null, 0, 1, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LegacyTitles.RadWideTPSFiregroundPeriodicUpdateTimer_A33467LegacyTitles);
					this.radWideTPSFiregroundPeriodicUpdateTimer_A33467.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideTPSFiregroundPeriodicUpdateTimer_A33467.DataTransferOrder = 88;
					this.radWideTPSFiregroundPeriodicUpdateTimer_A33467.ShowHexValue = false;
					num = (short)1443692554;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					switch (0)
					{
					case 0:
						goto IL_85;
					}
					continue;
				case 16:
					goto IL_3F7;
				case 17:
					this.radWideFiregroundPTTTransmission_A33515 = new global::AcpBusinessLayer.AcpSparseLOVField(0, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.indexRadWideFiregroundPTTTransmission_A33515LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.idRadWideFiregroundPTTTransmission_A33515LovStrs), this, global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕黗동껛믝蟟郡诣鏥蛧軩볫뫭ꓯ꛱蛳韵雷觹釻韽珿焁洃椅昇唉䴋㴍⌏✑┓⌕", a_), global::CommonResources.AcgResources.ID_CONVENTIONALCONFIGURATIONPERSONNELACCOUNTABILITYPTTTRANSMISSION, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideFiregroundPTTTransmission_A33515LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LegacyTitles.RadWideFiregroundPTTTransmission_A33515LegacyTitles);
					this.radWideFiregroundPTTTransmission_A33515.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideFiregroundPTTTransmission_A33515.DataTransferOrder = 32;
					num = (short)1576468483;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					this.radWideTPSFiregroundEvacuationAcknowledgement_A33216 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕賗諙进飝觟郡臣臥髧藩駫胭铯럱苳韵鯷迹鷻諽槿洁樃䜅欇愉戋愍朏縑焓爕缗缙焛笝丟嘡笣朥ᬧᤩḫἭد", a_), global::CommonResources.AcgResources.ID_CONVENTIONALCONFIGURATIONEVACUATIONACKNOWLEDGEMENT, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideTPSFiregroundEvacuationAcknowledgement_A33216LovStrs, global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LegacyTitles.RadWideTPSFiregroundEvacuationAcknowledgement_A33216LegacyTitles);
					this.radWideTPSFiregroundEvacuationAcknowledgement_A33216.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.radWideTPSFiregroundEvacuationAcknowledgement_A33216.DataTransferOrder = 25;
					num = (short)723058700;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					num = (short)1720909830;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					goto IL_3A5;
				case 21:
					num = (short)473235461;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_85:
				num = (short)1803680554;
				short num4 = num;
				num = (short)2142501674;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_32A:
					num = (short)1069416449;
					if (num != 0)
					{
					}
					this.radWidePAACKAlertsonPTT_A43099 = new global::AcpBusinessLayer.AcpField<bool>(true, this, global::AllFeatures.CodeplugGuid.b("飉귋꫍蟏믑냓돕裗鯙鷛鷝ꯟꏡ裣菥髧黩鿫臭黯ꋱꃳꋵꟷ믹죻췽ヿ㬁㴃", a_), global::CommonResources.AcgResources.ID_ACKNOWLEDGEALERTSONPTT);
					this.radWidePAACKAlertsonPTT_A43099.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radWidePAACKAlertsonPTT_A43099.DataTransferOrder = 60;
					num = (short)528941076;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				default:
					num = (short)139132928;
					if (num != 0)
					{
					}
					if (global::AcpCommonLib.AppInfoManager.DropOperation)
					{
						num = (short)1023868947;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5AD;
				}
				IL_F8:
				num = (short)973406215;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_220:
				num = (short)511180802;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3AA:
				num = (short)1563230217;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3F7:
				num = (short)734461963;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_4C6:
				num = (short)397934592;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_3A5:
			IL_5AD:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("髉꧋볍ꏏ뷑뫓룕뷗뛙ﳛ鿝菟臡诣鏥蛧黩跫賭駯黱鷳苵臷", a_);
			base.Id = 10750;
			base.UIName = global::CommonResources.AcgResources.ID_PERSONNELACCOUNTABILITY;
			base.DataTransferOrder = 18;
		}

		// Token: 0x06003384 RID: 13188 RVA: 0x0031AAD8 File Offset: 0x00318CD8
		public override void PopulateReferences()
		{
			short num = (short)801682511;
			short num2 = num;
			num = (short)373863503;
			switch (num2 == num)
			{
			}
			num = (short)327614465;
			if (num != 0)
			{
			}
			num = (short)1128005632;
			short num3 = num;
			num = (short)57540608;
			if (num != 0)
			{
			}
		}

		// Token: 0x06003385 RID: 13189 RVA: 0x0031AB84 File Offset: 0x00318D84
		public override void DropReferences()
		{
			short num = (short)549912577;
			if (num != 0)
			{
			}
			num = (short)1569968246;
			short num2 = num;
			num = (short)892588150;
			switch (num2 == num)
			{
			}
			num = (short)1876819968;
			short num3 = num;
			num = (short)2114912256;
			if (num != 0)
			{
			}
		}

		// Token: 0x06003386 RID: 13190 RVA: 0x0031AC30 File Offset: 0x00318E30
		public override void SetConstraints()
		{
			short num = (short)1127688692;
			short num2 = num;
			num = (short)249047540;
			switch (num2 == num)
			{
			}
			num = (short)94633985;
			if (num != 0)
			{
			}
			num = (short)1669136384;
			short num3 = num;
			num = (short)1374027776;
			if (num != 0)
			{
			}
		}

		// Token: 0x06003387 RID: 13191 RVA: 0x0031ACD8 File Offset: 0x00318ED8
		public override void SetupDependencies()
		{
			short num = (short)1989726782;
			short num2 = num;
			num = (short)1375392318;
			switch (num2 == num)
			{
			}
			num = (short)233111552;
			if (num != 0)
			{
			}
			num = (short)833159168;
			short num3 = num;
			num = (short)100663297;
			if (num != 0)
			{
			}
		}

		// Token: 0x170019FD RID: 6653
		// (get) Token: 0x06003388 RID: 13192 RVA: 0x0031AD84 File Offset: 0x00318F84
		public bool HasDiffs
		{
			get
			{
				short num = (short)1306984473;
				short num2 = num;
				num = (short)508624921;
				switch (num2 == num)
				{
				}
				num = (short)1791295488;
				if (num != 0)
				{
				}
				num = (short)1476788224;
				short num3 = num;
				num = (short)1125253121;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170019FE RID: 6654
		// (get) Token: 0x06003389 RID: 13193 RVA: 0x0031AE34 File Offset: 0x00319034
		// (set) Token: 0x0600338A RID: 13194 RVA: 0x0031AEEC File Offset: 0x003190EC
		public int RadWideTPSFiregroundEmergencyPTTTransmission_A33203Value
		{
			get
			{
				short num = (short)1446948684;
				short num2 = num;
				num = (short)911257420;
				switch (num2 == num)
				{
				}
				num = (short)1972830209;
				if (num != 0)
				{
				}
				num = (short)1768161280;
				short num3 = num;
				num = (short)102105088;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEmergencyPTTTransmission_A33203.Value;
			}
			set
			{
				short num = (short)936706049;
				if (num != 0)
				{
				}
				num = (short)1903658376;
				short num2 = num;
				num = (short)1675855240;
				switch (num2 == num)
				{
				}
				num = (short)1091502080;
				short num3 = num;
				num = (short)853803008;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundEmergencyPTTTransmission_A33203.Value = value;
			}
		}

		// Token: 0x170019FF RID: 6655
		// (get) Token: 0x0600338B RID: 13195 RVA: 0x0031AFA0 File Offset: 0x003191A0
		// (set) Token: 0x0600338C RID: 13196 RVA: 0x0031B054 File Offset: 0x00319254
		public string RadWideTPSFiregroundEmergencyPTTTransmission_A33203_UIValue
		{
			get
			{
				short num = (short)290914305;
				if (num != 0)
				{
				}
				num = (short)899088036;
				short num2 = num;
				num = (short)669056676;
				switch (num2 == num)
				{
				}
				num = (short)1588330496;
				short num3 = num;
				num = (short)784728064;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEmergencyPTTTransmission_A33203.UIValue;
			}
			set
			{
				short num = (short)2029139906;
				short num2 = num;
				num = (short)611596226;
				switch (num2 == num)
				{
				}
				num = (short)523763713;
				if (num != 0)
				{
				}
				num = (short)582811648;
				short num3 = num;
				num = (short)409010176;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundEmergencyPTTTransmission_A33203.UIValue = value;
			}
		}

		// Token: 0x17001A00 RID: 6656
		// (get) Token: 0x0600338D RID: 13197 RVA: 0x0031B108 File Offset: 0x00319308
		public global::AcpBusinessLayer.AcpListField RadWideTPSFiregroundEmergencyPTTTransmission_A33203
		{
			get
			{
				short num = (short)195163289;
				short num2 = num;
				num = (short)1916728473;
				switch (num2 == num)
				{
				}
				num = (short)649527297;
				if (num != 0)
				{
				}
				num = (short)317652992;
				short num3 = num;
				num = (short)1720647680;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEmergencyPTTTransmission_A33203;
			}
		}

		// Token: 0x17001A01 RID: 6657
		// (get) Token: 0x0600338E RID: 13198 RVA: 0x0031B1B8 File Offset: 0x003193B8
		// (set) Token: 0x0600338F RID: 13199 RVA: 0x0031B274 File Offset: 0x00319474
		public bool RadWideTPSFiregroundEmergencyPTTTransmission_A33203_Applicable
		{
			get
			{
				short num = (short)135227678;
				short num2 = num;
				num = (short)2130864414;
				switch (num2 == num)
				{
				}
				num = (short)170393601;
				if (num != 0)
				{
				}
				num = (short)820576256;
				short num3 = num;
				num = (short)1948057600;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEmergencyPTTTransmission_A33203.Applicable;
			}
			set
			{
				short num = (short)146726809;
				short num2 = num;
				num = (short)2060574617;
				switch (num2 == num)
				{
				}
				num = (short)253624321;
				if (num != 0)
				{
				}
				num = (short)949420032;
				short num3 = num;
				num = (short)68091904;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundEmergencyPTTTransmission_A33203.Applicable = value;
			}
		}

		// Token: 0x17001A02 RID: 6658
		// (get) Token: 0x06003390 RID: 13200 RVA: 0x0031B32C File Offset: 0x0031952C
		// (set) Token: 0x06003391 RID: 13201 RVA: 0x0031B3E0 File Offset: 0x003195E0
		public bool RadWideTPSFiregroundEmergencyPTTTransmission_A33203_Valid
		{
			get
			{
				short num = (short)1903301404;
				short num2 = num;
				num = (short)1065751324;
				switch (num2 == num)
				{
				}
				num = (short)940769280;
				if (num != 0)
				{
				}
				num = (short)1496842240;
				short num3 = num;
				num = (short)1330249729;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEmergencyPTTTransmission_A33203.Valid;
			}
			set
			{
				short num = (short)364526241;
				short num2 = num;
				num = (short)1428372129;
				switch (num2 == num)
				{
				}
				num = (short)1898512385;
				if (num != 0)
				{
				}
				num = (short)950075392;
				short num3 = num;
				num = (short)643956736;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundEmergencyPTTTransmission_A33203.Valid = value;
			}
		}

		// Token: 0x17001A03 RID: 6659
		// (get) Token: 0x06003392 RID: 13202 RVA: 0x0031B494 File Offset: 0x00319694
		// (set) Token: 0x06003393 RID: 13203 RVA: 0x0031B54C File Offset: 0x0031974C
		public bool RadWideTPSFiregroundEmergencyPTTTransmission_A33203_Visible
		{
			get
			{
				short num = (short)146284094;
				short num2 = num;
				num = (short)732372542;
				switch (num2 == num)
				{
				}
				num = (short)649527297;
				if (num != 0)
				{
				}
				num = (short)407961600;
				short num3 = num;
				num = (short)961282048;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEmergencyPTTTransmission_A33203.Visible;
			}
			set
			{
				short num = (short)1083696721;
				short num2 = num;
				num = (short)520087121;
				switch (num2 == num)
				{
				}
				num = (short)595984385;
				if (num != 0)
				{
				}
				num = (short)1007616000;
				short num3 = num;
				num = (short)1033043968;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundEmergencyPTTTransmission_A33203.Visible = value;
			}
		}

		// Token: 0x17001A04 RID: 6660
		// (get) Token: 0x06003394 RID: 13204 RVA: 0x0031B600 File Offset: 0x00319800
		// (set) Token: 0x06003395 RID: 13205 RVA: 0x0031B6B4 File Offset: 0x003198B4
		public bool RadWideTPSFiregroundEmergencyPTTTransmission_A33203_Editable
		{
			get
			{
				short num = (short)2065176974;
				short num2 = num;
				num = (short)232724878;
				switch (num2 == num)
				{
				}
				num = (short)1347158017;
				if (num != 0)
				{
				}
				num = (short)1273036800;
				short num3 = num;
				num = (short)370081792;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEmergencyPTTTransmission_A33203.Editable;
			}
			set
			{
				short num = (short)1432270113;
				short num2 = num;
				num = (short)673887521;
				switch (num2 == num)
				{
				}
				num = (short)784859137;
				if (num != 0)
				{
				}
				num = (short)808845312;
				short num3 = num;
				num = (short)167051264;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundEmergencyPTTTransmission_A33203.Editable = value;
			}
		}

		// Token: 0x17001A05 RID: 6661
		// (get) Token: 0x06003396 RID: 13206 RVA: 0x0031B76C File Offset: 0x0031996C
		internal string RadWideTPSFiregroundEmergencyPTTTransmission_A33203_UILabel
		{
			get
			{
				short num = (short)154713787;
				short num2 = num;
				num = (short)1906032315;
				switch (num2 == num)
				{
				}
				num = (short)1016004608;
				if (num != 0)
				{
				}
				num = (short)1736835072;
				short num3 = num;
				num = (short)291438593;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEmergencyPTTTransmission_A33203.UIName;
			}
		}

		// Token: 0x17001A06 RID: 6662
		// (get) Token: 0x06003397 RID: 13207 RVA: 0x0031B824 File Offset: 0x00319A24
		// (set) Token: 0x06003398 RID: 13208 RVA: 0x0031B8DC File Offset: 0x00319ADC
		internal bool RadWideTPSFiregroundEmergencyPTTTransmission_A33203_HiddenStatic
		{
			get
			{
				short num = (short)1410072577;
				if (num != 0)
				{
				}
				num = (short)2049494600;
				short num2 = num;
				num = (short)1496698440;
				switch (num2 == num)
				{
				}
				num = (short)259063808;
				short num3 = num;
				num = (short)1368129536;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEmergencyPTTTransmission_A33203.HiddenStatic;
			}
			set
			{
				short num = (short)372835748;
				short num2 = num;
				num = (short)1408304548;
				switch (num2 == num)
				{
				}
				num = (short)733872129;
				if (num != 0)
				{
				}
				num = (short)1204289536;
				short num3 = num;
				num = (short)271646720;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundEmergencyPTTTransmission_A33203.HiddenStatic = value;
			}
		}

		// Token: 0x17001A07 RID: 6663
		// (get) Token: 0x06003399 RID: 13209 RVA: 0x0031B990 File Offset: 0x00319B90
		// (set) Token: 0x0600339A RID: 13210 RVA: 0x0031BA44 File Offset: 0x00319C44
		internal bool RadWideTPSFiregroundEmergencyPTTTransmission_A33203_HiddenDynamic
		{
			get
			{
				short num = (short)870247044;
				short num2 = num;
				num = (short)406448772;
				switch (num2 == num)
				{
				}
				num = (short)946733056;
				if (num != 0)
				{
				}
				num = (short)2026110976;
				short num3 = num;
				num = (short)534970369;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEmergencyPTTTransmission_A33203.HiddenDynamic;
			}
			set
			{
				short num = (short)222561374;
				short num2 = num;
				num = (short)774112350;
				switch (num2 == num)
				{
				}
				num = (short)1981939712;
				if (num != 0)
				{
				}
				num = (short)1462697984;
				short num3 = num;
				num = (short)463732737;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundEmergencyPTTTransmission_A33203.HiddenDynamic = value;
			}
		}

		// Token: 0x17001A08 RID: 6664
		// (get) Token: 0x0600339B RID: 13211 RVA: 0x0031BAFC File Offset: 0x00319CFC
		public bool RadWideTPSFiregroundEmergencyPTTTransmission_A33203_HasDiffs
		{
			get
			{
				short num = (short)546406138;
				short num2 = num;
				num = (short)2008383226;
				switch (num2 == num)
				{
				}
				num = (short)691142657;
				if (num != 0)
				{
				}
				num = (short)1478295552;
				short num3 = num;
				num = (short)1530920960;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEmergencyPTTTransmission_A33203._HasDiffs;
			}
		}

		// Token: 0x17001A09 RID: 6665
		// (get) Token: 0x0600339C RID: 13212 RVA: 0x0031BBB0 File Offset: 0x00319DB0
		// (set) Token: 0x0600339D RID: 13213 RVA: 0x0031BC60 File Offset: 0x00319E60
		public int RadWideTPSFiregroundEvacuationAcknowledgement_A33216Value
		{
			get
			{
				short num = (short)1680847545;
				short num2 = num;
				num = (short)1165210297;
				switch (num2 == num)
				{
				}
				num = (short)149749760;
				if (num != 0)
				{
				}
				num = (short)1305804800;
				short num3 = num;
				num = (short)1047396353;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEvacuationAcknowledgement_A33216.Value;
			}
			set
			{
				short num = (short)1402946661;
				short num2 = num;
				num = (short)1441940581;
				switch (num2 == num)
				{
				}
				num = (short)299106305;
				if (num != 0)
				{
				}
				num = (short)1888419840;
				short num3 = num;
				num = (short)1637744640;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundEvacuationAcknowledgement_A33216.Value = value;
			}
		}

		// Token: 0x17001A0A RID: 6666
		// (get) Token: 0x0600339E RID: 13214 RVA: 0x0031BD18 File Offset: 0x00319F18
		// (set) Token: 0x0600339F RID: 13215 RVA: 0x0031BDD0 File Offset: 0x00319FD0
		public string RadWideTPSFiregroundEvacuationAcknowledgement_A33216_UIValue
		{
			get
			{
				short num = (short)1849688065;
				if (num != 0)
				{
				}
				num = (short)380156931;
				short num2 = num;
				num = (short)1274985475;
				switch (num2 == num)
				{
				}
				num = (short)378208256;
				short num3 = num;
				num = (short)1087111168;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEvacuationAcknowledgement_A33216.UIValue;
			}
			set
			{
				short num = (short)1026348788;
				short num2 = num;
				num = (short)309974772;
				switch (num2 == num)
				{
				}
				num = (short)461373440;
				if (num != 0)
				{
				}
				num = (short)790888448;
				short num3 = num;
				num = (short)214302721;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundEvacuationAcknowledgement_A33216.UIValue = value;
			}
		}

		// Token: 0x17001A0B RID: 6667
		// (get) Token: 0x060033A0 RID: 13216 RVA: 0x0031BE88 File Offset: 0x0031A088
		public global::AcpBusinessLayer.AcpListField RadWideTPSFiregroundEvacuationAcknowledgement_A33216
		{
			get
			{
				short num = (short)1813839873;
				if (num != 0)
				{
				}
				num = (short)1084042545;
				short num2 = num;
				num = (short)542649649;
				switch (num2 == num)
				{
				}
				num = (short)2104557568;
				short num3 = num;
				num = (short)80805888;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEvacuationAcknowledgement_A33216;
			}
		}

		// Token: 0x17001A0C RID: 6668
		// (get) Token: 0x060033A1 RID: 13217 RVA: 0x0031BF38 File Offset: 0x0031A138
		// (set) Token: 0x060033A2 RID: 13218 RVA: 0x0031BFEC File Offset: 0x0031A1EC
		public bool RadWideTPSFiregroundEvacuationAcknowledgement_A33216_Applicable
		{
			get
			{
				short num = (short)48365569;
				if (num != 0)
				{
				}
				num = (short)330443201;
				short num2 = num;
				num = (short)1767123393;
				switch (num2 == num)
				{
				}
				num = (short)2061893632;
				short num3 = num;
				num = (short)2025127936;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEvacuationAcknowledgement_A33216.Applicable;
			}
			set
			{
				short num = (short)2025914369;
				if (num != 0)
				{
				}
				num = (short)985202161;
				short num2 = num;
				num = (short)1213267441;
				switch (num2 == num)
				{
				}
				num = (short)113508352;
				short num3 = num;
				num = (short)273547264;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundEvacuationAcknowledgement_A33216.Applicable = value;
			}
		}

		// Token: 0x17001A0D RID: 6669
		// (get) Token: 0x060033A3 RID: 13219 RVA: 0x0031C0A4 File Offset: 0x0031A2A4
		// (set) Token: 0x060033A4 RID: 13220 RVA: 0x0031C158 File Offset: 0x0031A358
		public bool RadWideTPSFiregroundEvacuationAcknowledgement_A33216_Valid
		{
			get
			{
				short num = (short)28442625;
				if (num != 0)
				{
				}
				num = (short)1410952886;
				short num2 = num;
				num = (short)816737974;
				switch (num2 == num)
				{
				}
				num = (short)395575296;
				short num3 = num;
				num = (short)97845248;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundEvacuationAcknowledgement_A33216.Valid;
			}
			set
			{
				short num = (short)749857548;
				short num2 = num;
				num = (short)1741613836;
				switch (num2 == num)
				{
				}
				num = (short)1964507137;
				if (num != 0)
				{
				}
				num = (short)2145714176;
				short num3 = num;
				num = (short)1569521664;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundEvacuationAcknowledgement_A33216.Valid = value;
			}
		}

		// Token: 0x17001A0E RID: 6670
		// (get) Token: 0x060033A5 RID: 13221 RVA: 0x0031C20C File Offset: 0x0031A40C
		// (set) Token: 0x060033A6 RID: 13222 RVA: 0x0031C2C0 File Offset: 0x0031A4C0
		public bool RadWideTPSFiregroundEvacuationAcknowledgement_A33216_Visible
		{
			get
			{
				short num = (short)858510626;
				short num2 = num;
				num = (short)911136034;
				switch (num2 == num)
				{
				}
				num = (short)1076690945;
				if (num != 0)
				{
				}
				num = (short)836501504;
				if (num != 0)
				{
				}
				num = (short)614203392;
				short num3 = num;
				return this.radWideTPSFiregroundEvacuationAcknowledgement_A33216.Visible;
			}
			set
			{
				short num = (short)1827996682;
				short num2 = num;
				num = (short)1504773130;
				switch (num2 == num)
				{
				}
				num = (short)1966014464;
				if (num != 0)
				{
				}
				num = (short)491388929;
				if (num != 0)
				{
				}
				num = (short)241958912;
				short num3 = num;
				this.radWideTPSFiregroundEvacuationAcknowledgement_A33216.Visible = value;
			}
		}

		// Token: 0x17001A0F RID: 6671
		// (get) Token: 0x060033A7 RID: 13223 RVA: 0x0031C374 File Offset: 0x0031A574
		// (set) Token: 0x060033A8 RID: 13224 RVA: 0x0031C42C File Offset: 0x0031A62C
		public bool RadWideTPSFiregroundEvacuationAcknowledgement_A33216_Editable
		{
			get
			{
				short num = (short)351993857;
				if (num != 0)
				{
				}
				num = (short)57929383;
				short num2 = num;
				num = (short)929361575;
				switch (num2 == num)
				{
				}
				num = (short)1921384448;
				if (num != 0)
				{
				}
				num = (short)887750656;
				short num3 = num;
				return this.radWideTPSFiregroundEvacuationAcknowledgement_A33216.Editable;
			}
			set
			{
				short num = (short)858871084;
				short num2 = num;
				num = (short)26432812;
				switch (num2 == num)
				{
				}
				num = (short)1894383616;
				if (num != 0)
				{
				}
				num = (short)2010972161;
				if (num != 0)
				{
				}
				num = (short)1623719936;
				short num3 = num;
				this.radWideTPSFiregroundEvacuationAcknowledgement_A33216.Editable = value;
			}
		}

		// Token: 0x17001A10 RID: 6672
		// (get) Token: 0x060033A9 RID: 13225 RVA: 0x0031C4E0 File Offset: 0x0031A6E0
		internal string RadWideTPSFiregroundEvacuationAcknowledgement_A33216_UILabel
		{
			get
			{
				short num = (short)115338826;
				short num2 = num;
				num = (short)1178988106;
				switch (num2 == num)
				{
				}
				num = (short)190709760;
				if (num != 0)
				{
				}
				num = (short)1747714049;
				if (num != 0)
				{
				}
				num = (short)55181312;
				short num3 = num;
				return this.radWideTPSFiregroundEvacuationAcknowledgement_A33216.UIName;
			}
		}

		// Token: 0x17001A11 RID: 6673
		// (get) Token: 0x060033AA RID: 13226 RVA: 0x0031C594 File Offset: 0x0031A794
		// (set) Token: 0x060033AB RID: 13227 RVA: 0x0031C648 File Offset: 0x0031A848
		internal bool RadWideTPSFiregroundEvacuationAcknowledgement_A33216_HiddenStatic
		{
			get
			{
				short num = (short)1273602309;
				short num2 = num;
				num = (short)1096196357;
				switch (num2 == num)
				{
				}
				num = (short)213123073;
				if (num != 0)
				{
				}
				num = (short)1227423744;
				if (num != 0)
				{
				}
				num = (short)819855360;
				short num3 = num;
				return this.radWideTPSFiregroundEvacuationAcknowledgement_A33216.HiddenStatic;
			}
			set
			{
				short num = (short)775285716;
				short num2 = num;
				num = (short)2096163796;
				switch (num2 == num)
				{
				}
				num = (short)1194655745;
				if (num != 0)
				{
				}
				num = (short)1060044800;
				if (num != 0)
				{
				}
				num = (short)1036386304;
				short num3 = num;
				this.radWideTPSFiregroundEvacuationAcknowledgement_A33216.HiddenStatic = value;
			}
		}

		// Token: 0x17001A12 RID: 6674
		// (get) Token: 0x060033AC RID: 13228 RVA: 0x0031C700 File Offset: 0x0031A900
		// (set) Token: 0x060033AD RID: 13229 RVA: 0x0031C7B8 File Offset: 0x0031A9B8
		internal bool RadWideTPSFiregroundEvacuationAcknowledgement_A33216_HiddenDynamic
		{
			get
			{
				short num = (short)1131151361;
				if (num != 0)
				{
				}
				num = (short)59009355;
				short num2 = num;
				num = (short)161835339;
				switch (num2 == num)
				{
				}
				num = (short)152567808;
				if (num != 0)
				{
				}
				num = (short)976289792;
				short num3 = num;
				return this.radWideTPSFiregroundEvacuationAcknowledgement_A33216.HiddenDynamic;
			}
			set
			{
				short num = (short)1860820223;
				short num2 = num;
				num = (short)29089023;
				switch (num2 == num)
				{
				}
				num = (short)1396047873;
				if (num != 0)
				{
				}
				num = (short)599654400;
				if (num != 0)
				{
				}
				num = (short)875626496;
				short num3 = num;
				this.radWideTPSFiregroundEvacuationAcknowledgement_A33216.HiddenDynamic = value;
			}
		}

		// Token: 0x17001A13 RID: 6675
		// (get) Token: 0x060033AE RID: 13230 RVA: 0x0031C870 File Offset: 0x0031AA70
		public bool RadWideTPSFiregroundEvacuationAcknowledgement_A33216_HasDiffs
		{
			get
			{
				short num = (short)1099480760;
				short num2 = num;
				num = (short)2137308856;
				switch (num2 == num)
				{
				}
				num = (short)395182080;
				if (num != 0)
				{
				}
				num = (short)83755009;
				if (num != 0)
				{
				}
				num = (short)1702756352;
				short num3 = num;
				return this.radWideTPSFiregroundEvacuationAcknowledgement_A33216._HasDiffs;
			}
		}

		// Token: 0x17001A14 RID: 6676
		// (get) Token: 0x060033AF RID: 13231 RVA: 0x0031C924 File Offset: 0x0031AB24
		// (set) Token: 0x060033B0 RID: 13232 RVA: 0x0031C9D8 File Offset: 0x0031ABD8
		public int RadWideTPSFiregroundPeriodicUpdateTimer_A33467Value
		{
			get
			{
				short num = (short)770419774;
				short num2 = num;
				num = (short)1312992318;
				switch (num2 == num)
				{
				}
				num = (short)251920385;
				if (num != 0)
				{
				}
				num = (short)2001403904;
				if (num != 0)
				{
				}
				num = (short)273022976;
				short num3 = num;
				return this.radWideTPSFiregroundPeriodicUpdateTimer_A33467.Value;
			}
			set
			{
				short num = (short)685078921;
				short num2 = num;
				num = (short)1451850121;
				switch (num2 == num)
				{
				}
				num = (short)579403777;
				if (num != 0)
				{
				}
				num = (short)624951296;
				if (num != 0)
				{
				}
				num = (short)724041728;
				short num3 = num;
				this.radWideTPSFiregroundPeriodicUpdateTimer_A33467.Value = value;
			}
		}

		// Token: 0x17001A15 RID: 6677
		// (get) Token: 0x060033B1 RID: 13233 RVA: 0x0031CA90 File Offset: 0x0031AC90
		public global::AcpBusinessLayer.AcpSimpleRangeField RadWideTPSFiregroundPeriodicUpdateTimer_A33467
		{
			get
			{
				short num = (short)1546029334;
				short num2 = num;
				num = (short)2074577174;
				switch (num2 == num)
				{
				}
				num = (short)1227489280;
				if (num != 0)
				{
				}
				num = (short)458752001;
				if (num != 0)
				{
				}
				num = (short)1373569024;
				short num3 = num;
				return this.radWideTPSFiregroundPeriodicUpdateTimer_A33467;
			}
		}

		// Token: 0x17001A16 RID: 6678
		// (get) Token: 0x060033B2 RID: 13234 RVA: 0x0031CB40 File Offset: 0x0031AD40
		// (set) Token: 0x060033B3 RID: 13235 RVA: 0x0031CBF4 File Offset: 0x0031ADF4
		public string RadWideTPSFiregroundPeriodicUpdateTimer_A33467_UIValue
		{
			get
			{
				short num = (short)438807436;
				short num2 = num;
				num = (short)1231661964;
				switch (num2 == num)
				{
				}
				num = (short)365297665;
				if (num != 0)
				{
				}
				num = (short)1393950720;
				if (num != 0)
				{
				}
				num = (short)1986527232;
				short num3 = num;
				return this.radWideTPSFiregroundPeriodicUpdateTimer_A33467.UIValue;
			}
			set
			{
				short num = (short)1606439283;
				short num2 = num;
				num = (short)11161971;
				switch (num2 == num)
				{
				}
				num = (short)451870720;
				if (num != 0)
				{
				}
				num = (short)661061633;
				if (num != 0)
				{
				}
				num = (short)2103115776;
				short num3 = num;
				this.radWideTPSFiregroundPeriodicUpdateTimer_A33467.UIValue = value;
			}
		}

		// Token: 0x17001A17 RID: 6679
		// (get) Token: 0x060033B4 RID: 13236 RVA: 0x0031CCA8 File Offset: 0x0031AEA8
		// (set) Token: 0x060033B5 RID: 13237 RVA: 0x0031CD5C File Offset: 0x0031AF5C
		internal int RadWideTPSFiregroundPeriodicUpdateTimer_A33467Min
		{
			get
			{
				short num = (short)451569145;
				short num2 = num;
				num = (short)895706617;
				switch (num2 == num)
				{
				}
				num = (short)402063361;
				if (num != 0)
				{
				}
				num = (short)521732096;
				if (num != 0)
				{
				}
				num = (short)843448320;
				short num3 = num;
				return this.radWideTPSFiregroundPeriodicUpdateTimer_A33467.Min;
			}
			set
			{
				short num = (short)1516869327;
				short num2 = num;
				num = (short)1254266575;
				switch (num2 == num)
				{
				}
				num = (short)1155006465;
				if (num != 0)
				{
				}
				num = (short)1129644032;
				if (num != 0)
				{
				}
				num = (short)1976369152;
				short num3 = num;
				this.radWideTPSFiregroundPeriodicUpdateTimer_A33467.Min = value;
			}
		}

		// Token: 0x17001A18 RID: 6680
		// (get) Token: 0x060033B6 RID: 13238 RVA: 0x0031CE10 File Offset: 0x0031B010
		// (set) Token: 0x060033B7 RID: 13239 RVA: 0x0031CEC4 File Offset: 0x0031B0C4
		internal int RadWideTPSFiregroundPeriodicUpdateTimer_A33467Max
		{
			get
			{
				short num = (short)1198187889;
				short num2 = num;
				num = (short)1484252529;
				switch (num2 == num)
				{
				}
				num = (short)1639186433;
				if (num != 0)
				{
				}
				num = (short)1974992896;
				if (num != 0)
				{
				}
				num = (short)220004352;
				short num3 = num;
				return this.radWideTPSFiregroundPeriodicUpdateTimer_A33467.Max;
			}
			set
			{
				short num = (short)1606917935;
				short num2 = num;
				num = (short)1315479343;
				switch (num2 == num)
				{
				}
				num = (short)941424640;
				if (num != 0)
				{
				}
				num = (short)1375207425;
				if (num != 0)
				{
				}
				num = (short)1938292736;
				short num3 = num;
				this.radWideTPSFiregroundPeriodicUpdateTimer_A33467.Max = value;
			}
		}

		// Token: 0x17001A19 RID: 6681
		// (get) Token: 0x060033B8 RID: 13240 RVA: 0x0031CF78 File Offset: 0x0031B178
		// (set) Token: 0x060033B9 RID: 13241 RVA: 0x0031D030 File Offset: 0x0031B230
		internal int RadWideTPSFiregroundPeriodicUpdateTimer_A33467Step
		{
			get
			{
				short num = (short)1762681147;
				short num2 = num;
				num = (short)1026711867;
				switch (num2 == num)
				{
				}
				num = (short)1679032320;
				if (num != 0)
				{
				}
				num = (short)1147863041;
				if (num != 0)
				{
				}
				num = (short)255524864;
				short num3 = num;
				return this.radWideTPSFiregroundPeriodicUpdateTimer_A33467.StepSize;
			}
			set
			{
				short num = (short)2009449394;
				short num2 = num;
				num = (short)200000434;
				switch (num2 == num)
				{
				}
				num = (short)1823932417;
				if (num != 0)
				{
				}
				num = (short)1208680448;
				if (num != 0)
				{
				}
				num = (short)1039990784;
				short num3 = num;
				this.radWideTPSFiregroundPeriodicUpdateTimer_A33467.StepSize = value;
			}
		}

		// Token: 0x17001A1A RID: 6682
		// (get) Token: 0x060033BA RID: 13242 RVA: 0x0031D0E4 File Offset: 0x0031B2E4
		// (set) Token: 0x060033BB RID: 13243 RVA: 0x0031D198 File Offset: 0x0031B398
		public bool RadWideTPSFiregroundPeriodicUpdateTimer_A33467_Applicable
		{
			get
			{
				short num = (short)578024837;
				short num2 = num;
				num = (short)634713477;
				switch (num2 == num)
				{
				}
				num = (short)217055232;
				if (num != 0)
				{
				}
				num = (short)1183449089;
				if (num != 0)
				{
				}
				num = (short)1029701632;
				short num3 = num;
				return this.radWideTPSFiregroundPeriodicUpdateTimer_A33467.Applicable;
			}
			set
			{
				short num = (short)1545390538;
				short num2 = num;
				num = (short)2025376202;
				switch (num2 == num)
				{
				}
				num = (short)2102722561;
				if (num != 0)
				{
				}
				num = (short)37945344;
				if (num != 0)
				{
				}
				num = (short)2038824960;
				short num3 = num;
				this.radWideTPSFiregroundPeriodicUpdateTimer_A33467.Applicable = value;
			}
		}

		// Token: 0x17001A1B RID: 6683
		// (get) Token: 0x060033BC RID: 13244 RVA: 0x0031D250 File Offset: 0x0031B450
		// (set) Token: 0x060033BD RID: 13245 RVA: 0x0031D308 File Offset: 0x0031B508
		public bool RadWideTPSFiregroundPeriodicUpdateTimer_A33467_Valid
		{
			get
			{
				short num = (short)1960889367;
				short num2 = num;
				num = (short)2109525015;
				switch (num2 == num)
				{
				}
				num = (short)2134179841;
				if (num != 0)
				{
				}
				num = (short)139657216;
				if (num != 0)
				{
				}
				num = (short)2129657856;
				short num3 = num;
				return this.radWideTPSFiregroundPeriodicUpdateTimer_A33467.Valid;
			}
			set
			{
				short num = (short)1260694266;
				short num2 = num;
				num = (short)422292218;
				switch (num2 == num)
				{
				}
				num = (short)107151360;
				if (num != 0)
				{
				}
				num = (short)1488912385;
				if (num != 0)
				{
				}
				num = (short)1743388672;
				short num3 = num;
				this.radWideTPSFiregroundPeriodicUpdateTimer_A33467.Valid = value;
			}
		}

		// Token: 0x17001A1C RID: 6684
		// (get) Token: 0x060033BE RID: 13246 RVA: 0x0031D3C0 File Offset: 0x0031B5C0
		// (set) Token: 0x060033BF RID: 13247 RVA: 0x0031D474 File Offset: 0x0031B674
		public bool RadWideTPSFiregroundPeriodicUpdateTimer_A33467_Visible
		{
			get
			{
				short num = (short)2078212097;
				if (num != 0)
				{
				}
				num = (short)1590894469;
				short num2 = num;
				num = (short)862723973;
				switch (num2 == num)
				{
				}
				num = (short)945422336;
				if (num != 0)
				{
				}
				num = (short)267583488;
				short num3 = num;
				return this.radWideTPSFiregroundPeriodicUpdateTimer_A33467.Visible;
			}
			set
			{
				short num = (short)1262468020;
				short num2 = num;
				num = (short)519682996;
				switch (num2 == num)
				{
				}
				num = (short)1394540545;
				if (num != 0)
				{
				}
				num = (short)1912078336;
				if (num != 0)
				{
				}
				num = (short)34603008;
				short num3 = num;
				this.radWideTPSFiregroundPeriodicUpdateTimer_A33467.Visible = value;
			}
		}

		// Token: 0x17001A1D RID: 6685
		// (get) Token: 0x060033C0 RID: 13248 RVA: 0x0031D528 File Offset: 0x0031B728
		// (set) Token: 0x060033C1 RID: 13249 RVA: 0x0031D5DC File Offset: 0x0031B7DC
		public bool RadWideTPSFiregroundPeriodicUpdateTimer_A33467_Editable
		{
			get
			{
				short num = (short)1328542537;
				short num2 = num;
				num = (short)452260681;
				switch (num2 == num)
				{
				}
				num = (short)311492609;
				if (num != 0)
				{
				}
				num = (short)872546304;
				if (num != 0)
				{
				}
				num = (short)820838400;
				short num3 = num;
				return this.radWideTPSFiregroundPeriodicUpdateTimer_A33467.Editable;
			}
			set
			{
				short num = (short)1894166163;
				short num2 = num;
				num = (short)574729875;
				switch (num2 == num)
				{
				}
				num = (short)151977985;
				if (num != 0)
				{
				}
				num = (short)376242176;
				if (num != 0)
				{
				}
				num = (short)38797312;
				short num3 = num;
				this.radWideTPSFiregroundPeriodicUpdateTimer_A33467.Editable = value;
			}
		}

		// Token: 0x17001A1E RID: 6686
		// (get) Token: 0x060033C2 RID: 13250 RVA: 0x0031D690 File Offset: 0x0031B890
		internal string RadWideTPSFiregroundPeriodicUpdateTimer_A33467_UILabel
		{
			get
			{
				short num = (short)1657327987;
				short num2 = num;
				num = (short)820892019;
				switch (num2 == num)
				{
				}
				num = (short)221773824;
				if (num != 0)
				{
				}
				num = (short)177340417;
				if (num != 0)
				{
				}
				num = (short)1328873472;
				short num3 = num;
				return this.radWideTPSFiregroundPeriodicUpdateTimer_A33467.UIName;
			}
		}

		// Token: 0x17001A1F RID: 6687
		// (get) Token: 0x060033C3 RID: 13251 RVA: 0x0031D748 File Offset: 0x0031B948
		// (set) Token: 0x060033C4 RID: 13252 RVA: 0x0031D7FC File Offset: 0x0031B9FC
		internal bool RadWideTPSFiregroundPeriodicUpdateTimer_A33467_HiddenStatic
		{
			get
			{
				short num = (short)351604225;
				short num2 = num;
				num = (short)513019393;
				switch (num2 == num)
				{
				}
				num = (short)59834369;
				if (num != 0)
				{
				}
				num = (short)362676224;
				if (num != 0)
				{
				}
				num = (short)1335230464;
				short num3 = num;
				return this.radWideTPSFiregroundPeriodicUpdateTimer_A33467.HiddenStatic;
			}
			set
			{
				short num = (short)964032167;
				short num2 = num;
				num = (short)1153496743;
				switch (num2 == num)
				{
				}
				num = (short)571342849;
				if (num != 0)
				{
				}
				num = (short)885784576;
				if (num != 0)
				{
				}
				num = (short)1663369216;
				short num3 = num;
				this.radWideTPSFiregroundPeriodicUpdateTimer_A33467.HiddenStatic = value;
			}
		}

		// Token: 0x17001A20 RID: 6688
		// (get) Token: 0x060033C5 RID: 13253 RVA: 0x0031D8B4 File Offset: 0x0031BAB4
		// (set) Token: 0x060033C6 RID: 13254 RVA: 0x0031D968 File Offset: 0x0031BB68
		internal bool RadWideTPSFiregroundPeriodicUpdateTimer_A33467_HiddenDynamic
		{
			get
			{
				short num = (short)1348336231;
				short num2 = num;
				num = (short)262797927;
				switch (num2 == num)
				{
				}
				num = (short)1649541121;
				if (num != 0)
				{
				}
				num = (short)2026176512;
				if (num != 0)
				{
				}
				num = (short)1427505152;
				short num3 = num;
				return this.radWideTPSFiregroundPeriodicUpdateTimer_A33467.HiddenDynamic;
			}
			set
			{
				short num = (short)641856653;
				short num2 = num;
				num = (short)1741157517;
				switch (num2 == num)
				{
				}
				num = (short)150208512;
				if (num != 0)
				{
				}
				num = (short)1885536257;
				if (num != 0)
				{
				}
				num = (short)1975255040;
				short num3 = num;
				this.radWideTPSFiregroundPeriodicUpdateTimer_A33467.HiddenDynamic = value;
			}
		}

		// Token: 0x17001A21 RID: 6689
		// (get) Token: 0x060033C7 RID: 13255 RVA: 0x0031DA1C File Offset: 0x0031BC1C
		public bool RadWideTPSFiregroundPeriodicUpdateTimer_A33467_HasDiffs
		{
			get
			{
				short num = (short)908475898;
				short num2 = num;
				num = (short)1084177914;
				switch (num2 == num)
				{
				}
				num = (short)1738080257;
				if (num != 0)
				{
				}
				num = (short)1260257280;
				if (num != 0)
				{
				}
				num = (short)181010432;
				short num3 = num;
				return this.radWideTPSFiregroundPeriodicUpdateTimer_A33467._HasDiffs;
			}
		}

		// Token: 0x17001A22 RID: 6690
		// (get) Token: 0x060033C8 RID: 13256 RVA: 0x0031DAD4 File Offset: 0x0031BCD4
		// (set) Token: 0x060033C9 RID: 13257 RVA: 0x0031DB88 File Offset: 0x0031BD88
		public int RadWideFiregroundPTTTransmission_A33515Value
		{
			get
			{
				short num = (short)2129475223;
				short num2 = num;
				num = (short)1370568343;
				switch (num2 == num)
				{
				}
				num = (short)1095630849;
				if (num != 0)
				{
				}
				num = (short)1054474240;
				if (num != 0)
				{
				}
				num = (short)88276992;
				short num3 = num;
				return this.radWideFiregroundPTTTransmission_A33515.Value;
			}
			set
			{
				short num = (short)1146695575;
				short num2 = num;
				num = (short)3944343;
				switch (num2 == num)
				{
				}
				num = (short)1034682369;
				if (num != 0)
				{
				}
				num = (short)1064501248;
				if (num != 0)
				{
				}
				num = (short)327942144;
				short num3 = num;
				this.radWideFiregroundPTTTransmission_A33515.Value = value;
			}
		}

		// Token: 0x17001A23 RID: 6691
		// (get) Token: 0x060033CA RID: 13258 RVA: 0x0031DC3C File Offset: 0x0031BE3C
		// (set) Token: 0x060033CB RID: 13259 RVA: 0x0031DCF0 File Offset: 0x0031BEF0
		public string RadWideFiregroundPTTTransmission_A33515_UIValue
		{
			get
			{
				short num = (short)1538036005;
				short num2 = num;
				num = (short)840798501;
				switch (num2 == num)
				{
				}
				num = (short)675610625;
				if (num != 0)
				{
				}
				num = (short)2133393408;
				if (num != 0)
				{
				}
				num = (short)1661403136;
				short num3 = num;
				return this.radWideFiregroundPTTTransmission_A33515.UIValue;
			}
			set
			{
				short num = (short)729951043;
				short num2 = num;
				num = (short)1994402627;
				switch (num2 == num)
				{
				}
				num = (short)1051590657;
				if (num != 0)
				{
				}
				num = (short)2123300864;
				if (num != 0)
				{
				}
				num = (short)1975058432;
				short num3 = num;
				this.radWideFiregroundPTTTransmission_A33515.UIValue = value;
			}
		}

		// Token: 0x17001A24 RID: 6692
		// (get) Token: 0x060033CC RID: 13260 RVA: 0x0031DDA8 File Offset: 0x0031BFA8
		public global::AcpBusinessLayer.AcpListField RadWideFiregroundPTTTransmission_A33515
		{
			get
			{
				short num = (short)328733723;
				short num2 = num;
				num = (short)912987163;
				switch (num2 == num)
				{
				}
				num = (short)1594621952;
				if (num != 0)
				{
				}
				num = (short)269287425;
				if (num != 0)
				{
				}
				num = (short)1672347648;
				short num3 = num;
				return this.radWideFiregroundPTTTransmission_A33515;
			}
		}

		// Token: 0x17001A25 RID: 6693
		// (get) Token: 0x060033CD RID: 13261 RVA: 0x0031DE54 File Offset: 0x0031C054
		// (set) Token: 0x060033CE RID: 13262 RVA: 0x0031DF08 File Offset: 0x0031C108
		public bool RadWideFiregroundPTTTransmission_A33515_Applicable
		{
			get
			{
				short num = (short)970969830;
				short num2 = num;
				num = (short)809554662;
				switch (num2 == num)
				{
				}
				num = (short)381681665;
				if (num != 0)
				{
				}
				num = (short)541917184;
				if (num != 0)
				{
				}
				num = (short)1488977920;
				short num3 = num;
				return this.radWideFiregroundPTTTransmission_A33515.Applicable;
			}
			set
			{
				short num = (short)147259393;
				if (num != 0)
				{
				}
				num = (short)1431332093;
				short num2 = num;
				num = (short)1421894909;
				switch (num2 == num)
				{
				}
				num = (short)490471424;
				if (num != 0)
				{
				}
				num = (short)803209216;
				short num3 = num;
				this.radWideFiregroundPTTTransmission_A33515.Applicable = value;
			}
		}

		// Token: 0x17001A26 RID: 6694
		// (get) Token: 0x060033CF RID: 13263 RVA: 0x0031DFBC File Offset: 0x0031C1BC
		// (set) Token: 0x060033D0 RID: 13264 RVA: 0x0031E070 File Offset: 0x0031C270
		public bool RadWideFiregroundPTTTransmission_A33515_Valid
		{
			get
			{
				short num = (short)118423553;
				if (num != 0)
				{
				}
				num = (short)1406937253;
				short num2 = num;
				num = (short)1854744741;
				switch (num2 == num)
				{
				}
				num = (short)1043726336;
				if (num != 0)
				{
				}
				num = (short)483000320;
				short num3 = num;
				return this.radWideFiregroundPTTTransmission_A33515.Valid;
			}
			set
			{
				short num = (short)597896139;
				short num2 = num;
				num = (short)131607499;
				switch (num2 == num)
				{
				}
				num = (short)1486553088;
				if (num != 0)
				{
				}
				num = (short)1400766465;
				if (num != 0)
				{
				}
				num = (short)151060480;
				short num3 = num;
				this.radWideFiregroundPTTTransmission_A33515.Valid = value;
			}
		}

		// Token: 0x17001A27 RID: 6695
		// (get) Token: 0x060033D1 RID: 13265 RVA: 0x0031E124 File Offset: 0x0031C324
		// (set) Token: 0x060033D2 RID: 13266 RVA: 0x0031E1D8 File Offset: 0x0031C3D8
		public bool RadWideFiregroundPTTTransmission_A33515_Visible
		{
			get
			{
				short num = (short)1045256224;
				short num2 = num;
				num = (short)954095648;
				switch (num2 == num)
				{
				}
				num = (short)867172352;
				if (num != 0)
				{
				}
				num = (short)1425342465;
				if (num != 0)
				{
				}
				num = (short)222691328;
				short num3 = num;
				return this.radWideFiregroundPTTTransmission_A33515.Visible;
			}
			set
			{
				short num = (short)1594688880;
				short num2 = num;
				num = (short)734659952;
				switch (num2 == num)
				{
				}
				num = (short)168951808;
				if (num != 0)
				{
				}
				num = (short)1864433665;
				if (num != 0)
				{
				}
				num = (short)301924352;
				short num3 = num;
				this.radWideFiregroundPTTTransmission_A33515.Visible = value;
			}
		}

		// Token: 0x17001A28 RID: 6696
		// (get) Token: 0x060033D3 RID: 13267 RVA: 0x0031E28C File Offset: 0x0031C48C
		// (set) Token: 0x060033D4 RID: 13268 RVA: 0x0031E340 File Offset: 0x0031C540
		public bool RadWideFiregroundPTTTransmission_A33515_Editable
		{
			get
			{
				short num = (short)1667104769;
				if (num != 0)
				{
				}
				num = (short)54864290;
				short num2 = num;
				num = (short)348727714;
				switch (num2 == num)
				{
				}
				num = (short)1961230336;
				if (num != 0)
				{
				}
				num = (short)468516864;
				short num3 = num;
				return this.radWideFiregroundPTTTransmission_A33515.Editable;
			}
			set
			{
				short num = (short)1494286337;
				if (num != 0)
				{
				}
				num = (short)1445828825;
				short num2 = num;
				num = (short)1539217625;
				switch (num2 == num)
				{
				}
				num = (short)1766785024;
				if (num != 0)
				{
				}
				num = (short)195035136;
				short num3 = num;
				this.radWideFiregroundPTTTransmission_A33515.Editable = value;
			}
		}

		// Token: 0x17001A29 RID: 6697
		// (get) Token: 0x060033D5 RID: 13269 RVA: 0x0031E3F8 File Offset: 0x0031C5F8
		internal string RadWideFiregroundPTTTransmission_A33515_UILabel
		{
			get
			{
				short num = (short)454388368;
				short num2 = num;
				num = (short)1548774032;
				switch (num2 == num)
				{
				}
				num = (short)1820196865;
				if (num != 0)
				{
				}
				num = (short)1205796864;
				if (num != 0)
				{
				}
				num = (short)1280245760;
				short num3 = num;
				return this.radWideFiregroundPTTTransmission_A33515.UIName;
			}
		}

		// Token: 0x17001A2A RID: 6698
		// (get) Token: 0x060033D6 RID: 13270 RVA: 0x0031E4AC File Offset: 0x0031C6AC
		// (set) Token: 0x060033D7 RID: 13271 RVA: 0x0031E560 File Offset: 0x0031C760
		internal bool RadWideFiregroundPTTTransmission_A33515_HiddenStatic
		{
			get
			{
				short num = (short)476381185;
				if (num != 0)
				{
				}
				num = (short)182415610;
				short num2 = num;
				num = (short)489058554;
				switch (num2 == num)
				{
				}
				num = (short)137560064;
				if (num != 0)
				{
				}
				num = (short)305528832;
				short num3 = num;
				return this.radWideFiregroundPTTTransmission_A33515.HiddenStatic;
			}
			set
			{
				short num = (short)1631032929;
				short num2 = num;
				num = (short)1044682337;
				switch (num2 == num)
				{
				}
				num = (short)1357643777;
				if (num != 0)
				{
				}
				num = (short)262144;
				if (num != 0)
				{
				}
				num = (short)855441408;
				short num3 = num;
				this.radWideFiregroundPTTTransmission_A33515.HiddenStatic = value;
			}
		}

		// Token: 0x17001A2B RID: 6699
		// (get) Token: 0x060033D8 RID: 13272 RVA: 0x0031E614 File Offset: 0x0031C814
		// (set) Token: 0x060033D9 RID: 13273 RVA: 0x0031E6C8 File Offset: 0x0031C8C8
		internal bool RadWideFiregroundPTTTransmission_A33515_HiddenDynamic
		{
			get
			{
				short num = (short)1327121487;
				short num2 = num;
				num = (short)957695055;
				switch (num2 == num)
				{
				}
				num = (short)447938561;
				if (num != 0)
				{
				}
				num = (short)899153920;
				if (num != 0)
				{
				}
				num = (short)1195507712;
				short num3 = num;
				return this.radWideFiregroundPTTTransmission_A33515.HiddenDynamic;
			}
			set
			{
				short num = (short)1362583233;
				short num2 = num;
				num = (short)616980161;
				switch (num2 == num)
				{
				}
				num = (short)441647105;
				if (num != 0)
				{
				}
				num = (short)827392000;
				if (num != 0)
				{
				}
				num = (short)1494876160;
				short num3 = num;
				this.radWideFiregroundPTTTransmission_A33515.HiddenDynamic = value;
			}
		}

		// Token: 0x17001A2C RID: 6700
		// (get) Token: 0x060033DA RID: 13274 RVA: 0x0031E77C File Offset: 0x0031C97C
		public bool RadWideFiregroundPTTTransmission_A33515_HasDiffs
		{
			get
			{
				short num = (short)711789947;
				short num2 = num;
				num = (short)1939082619;
				switch (num2 == num)
				{
				}
				num = (short)530251777;
				if (num != 0)
				{
				}
				num = (short)2002321408;
				if (num != 0)
				{
				}
				num = (short)1759444992;
				short num3 = num;
				return this.radWideFiregroundPTTTransmission_A33515._HasDiffs;
			}
		}

		// Token: 0x17001A2D RID: 6701
		// (get) Token: 0x060033DB RID: 13275 RVA: 0x0031E834 File Offset: 0x0031CA34
		// (set) Token: 0x060033DC RID: 13276 RVA: 0x0031E8E8 File Offset: 0x0031CAE8
		public bool RadWideTPSFiregroundRespondToPolls_A33573Value
		{
			get
			{
				short num = (short)2078418777;
				short num2 = num;
				num = (short)1880237913;
				switch (num2 == num)
				{
				}
				num = (short)1497104385;
				if (num != 0)
				{
				}
				num = (short)1625554944;
				if (num != 0)
				{
				}
				num = (short)1129578496;
				short num3 = num;
				return this.radWideTPSFiregroundRespondToPolls_A33573.Value;
			}
			set
			{
				short num = (short)153739164;
				short num2 = num;
				num = (short)428400540;
				switch (num2 == num)
				{
				}
				num = (short)970260481;
				if (num != 0)
				{
				}
				num = (short)1094778880;
				if (num != 0)
				{
				}
				num = (short)1337720832;
				short num3 = num;
				this.radWideTPSFiregroundRespondToPolls_A33573.Value = value;
			}
		}

		// Token: 0x17001A2E RID: 6702
		// (get) Token: 0x060033DD RID: 13277 RVA: 0x0031E99C File Offset: 0x0031CB9C
		public global::AcpBusinessLayer.AcpField<bool> RadWideTPSFiregroundRespondToPolls_A33573
		{
			get
			{
				short num = (short)241500160;
				short num2 = num;
				num = (short)408762944;
				short num3 = num;
				num = (short)661142080;
				switch (num3 == num)
				{
				}
				num = (short)413663233;
				if (num != 0)
				{
				}
				num = (short)1060306944;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundRespondToPolls_A33573;
			}
		}

		// Token: 0x17001A2F RID: 6703
		// (get) Token: 0x060033DE RID: 13278 RVA: 0x0031EA4C File Offset: 0x0031CC4C
		// (set) Token: 0x060033DF RID: 13279 RVA: 0x0031EB00 File Offset: 0x0031CD00
		public bool RadWideTPSFiregroundRespondToPolls_A33573_UIValue
		{
			get
			{
				short num = (short)1076887552;
				short num2 = num;
				num = (short)82780815;
				short num3 = num;
				num = (short)1533878927;
				switch (num3 == num)
				{
				}
				num = (short)1973354496;
				if (num != 0)
				{
				}
				num = (short)1689190401;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundRespondToPolls_A33573.Value;
			}
			set
			{
				short num = (short)1634336768;
				short num2 = num;
				num = (short)365931057;
				short num3 = num;
				num = (short)1204333105;
				switch (num3 == num)
				{
				}
				num = (short)931135489;
				if (num != 0)
				{
				}
				num = (short)41222144;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundRespondToPolls_A33573.Value = value;
			}
		}

		// Token: 0x17001A30 RID: 6704
		// (get) Token: 0x060033E0 RID: 13280 RVA: 0x0031EBB8 File Offset: 0x0031CDB8
		// (set) Token: 0x060033E1 RID: 13281 RVA: 0x0031EC6C File Offset: 0x0031CE6C
		public bool RadWideTPSFiregroundRespondToPolls_A33573_Applicable
		{
			get
			{
				short num = (short)2123300864;
				short num2 = num;
				num = (short)1137168069;
				short num3 = num;
				num = (short)483315397;
				switch (num3 == num)
				{
				}
				num = (short)502333440;
				if (num != 0)
				{
				}
				num = (short)1279000577;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundRespondToPolls_A33573.Applicable;
			}
			set
			{
				short num = (short)795148288;
				short num2 = num;
				num = (short)259188049;
				short num3 = num;
				num = (short)1886315857;
				switch (num3 == num)
				{
				}
				num = (short)2058813440;
				if (num != 0)
				{
				}
				num = (short)1762983937;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundRespondToPolls_A33573.Applicable = value;
			}
		}

		// Token: 0x17001A31 RID: 6705
		// (get) Token: 0x060033E2 RID: 13282 RVA: 0x0031ED24 File Offset: 0x0031CF24
		// (set) Token: 0x060033E3 RID: 13283 RVA: 0x0031EDD8 File Offset: 0x0031CFD8
		public bool RadWideTPSFiregroundRespondToPolls_A33573_Valid
		{
			get
			{
				short num = (short)538705920;
				short num2 = num;
				num = (short)1546190849;
				if (num != 0)
				{
				}
				num = (short)2049177739;
				short num3 = num;
				num = (short)1666513035;
				switch (num3 == num)
				{
				}
				num = (short)740622336;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundRespondToPolls_A33573.Valid;
			}
			set
			{
				short num = (short)2070806528;
				short num2 = num;
				num = (short)1682750135;
				short num3 = num;
				num = (short)259635895;
				switch (num3 == num)
				{
				}
				num = (short)66387968;
				if (num != 0)
				{
				}
				num = (short)342556673;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundRespondToPolls_A33573.Valid = value;
			}
		}

		// Token: 0x17001A32 RID: 6706
		// (get) Token: 0x060033E4 RID: 13284 RVA: 0x0031EE8C File Offset: 0x0031D08C
		// (set) Token: 0x060033E5 RID: 13285 RVA: 0x0031EF40 File Offset: 0x0031D140
		public bool RadWideTPSFiregroundRespondToPolls_A33573_Visible
		{
			get
			{
				short num = (short)1939603456;
				short num2 = num;
				num = (short)1841695628;
				short num3 = num;
				num = (short)1172441996;
				switch (num3 == num)
				{
				}
				num = (short)197394433;
				if (num != 0)
				{
				}
				num = (short)1106640896;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundRespondToPolls_A33573.Visible;
			}
			set
			{
				short num = (short)778895360;
				short num2 = num;
				num = (short)1288745143;
				short num3 = num;
				num = (short)1169600695;
				switch (num3 == num)
				{
				}
				num = (short)458752001;
				if (num != 0)
				{
				}
				num = (short)426049536;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundRespondToPolls_A33573.Visible = value;
			}
		}

		// Token: 0x17001A33 RID: 6707
		// (get) Token: 0x060033E6 RID: 13286 RVA: 0x0031EFF8 File Offset: 0x0031D1F8
		// (set) Token: 0x060033E7 RID: 13287 RVA: 0x0031F0AC File Offset: 0x0031D2AC
		public bool RadWideTPSFiregroundRespondToPolls_A33573_Editable
		{
			get
			{
				short num = (short)1988231168;
				short num2 = num;
				num = (short)828355991;
				short num3 = num;
				num = (short)1746384279;
				switch (num3 == num)
				{
				}
				num = (short)817168384;
				if (num != 0)
				{
				}
				num = (short)1796014081;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundRespondToPolls_A33573.Editable;
			}
			set
			{
				short num = (short)787939328;
				short num2 = num;
				num = (short)1415413538;
				short num3 = num;
				num = (short)1195343650;
				switch (num3 == num)
				{
				}
				num = (short)999227393;
				if (num != 0)
				{
				}
				num = (short)892928000;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundRespondToPolls_A33573.Editable = value;
			}
		}

		// Token: 0x17001A34 RID: 6708
		// (get) Token: 0x060033E8 RID: 13288 RVA: 0x0031F164 File Offset: 0x0031D364
		internal string RadWideTPSFiregroundRespondToPolls_A33573_UILabel
		{
			get
			{
				short num = (short)566886400;
				short num2 = num;
				num = (short)926416897;
				if (num != 0)
				{
				}
				num = (short)1754895497;
				short num3 = num;
				num = (short)323261577;
				switch (num3 == num)
				{
				}
				num = (short)1455292416;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundRespondToPolls_A33573.UIName;
			}
		}

		// Token: 0x17001A35 RID: 6709
		// (get) Token: 0x060033E9 RID: 13289 RVA: 0x0031F218 File Offset: 0x0031D418
		// (set) Token: 0x060033EA RID: 13290 RVA: 0x0031F2CC File Offset: 0x0031D4CC
		internal bool RadWideTPSFiregroundRespondToPolls_A33573_HiddenStatic
		{
			get
			{
				short num = (short)1902575616;
				short num2 = num;
				num = (short)1381395857;
				short num3 = num;
				num = (short)938241425;
				switch (num3 == num)
				{
				}
				num = (short)852230144;
				if (num != 0)
				{
				}
				num = (short)411238401;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundRespondToPolls_A33573.HiddenStatic;
			}
			set
			{
				short num = (short)207224832;
				short num2 = num;
				num = (short)1573067483;
				short num3 = num;
				num = (short)672864987;
				switch (num3 == num)
				{
				}
				num = (short)565575681;
				if (num != 0)
				{
				}
				num = (short)132055040;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundRespondToPolls_A33573.HiddenStatic = value;
			}
		}

		// Token: 0x17001A36 RID: 6710
		// (get) Token: 0x060033EB RID: 13291 RVA: 0x0031F384 File Offset: 0x0031D584
		// (set) Token: 0x060033EC RID: 13292 RVA: 0x0031F43C File Offset: 0x0031D63C
		internal bool RadWideTPSFiregroundRespondToPolls_A33573_HiddenDynamic
		{
			get
			{
				short num = (short)1574895616;
				short num2 = num;
				num = (short)2007250530;
				short num3 = num;
				num = (short)1412970082;
				switch (num3 == num)
				{
				}
				num = (short)2003173377;
				if (num != 0)
				{
				}
				num = (short)1284177920;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundRespondToPolls_A33573.HiddenDynamic;
			}
			set
			{
				short num = (short)375390208;
				short num2 = num;
				num = (short)907214849;
				if (num != 0)
				{
				}
				num = (short)1749484969;
				short num3 = num;
				num = (short)1371080105;
				switch (num3 == num)
				{
				}
				num = (short)369360896;
				if (num != 0)
				{
				}
				this.radWideTPSFiregroundRespondToPolls_A33573.HiddenDynamic = value;
			}
		}

		// Token: 0x17001A37 RID: 6711
		// (get) Token: 0x060033ED RID: 13293 RVA: 0x0031F4F4 File Offset: 0x0031D6F4
		public bool RadWideTPSFiregroundRespondToPolls_A33573_HasDiffs
		{
			get
			{
				short num = (short)1088225280;
				short num2 = num;
				num = (short)301447725;
				short num3 = num;
				num = (short)1873328685;
				switch (num3 == num)
				{
				}
				num = (short)2099970049;
				if (num != 0)
				{
				}
				num = (short)800915456;
				if (num != 0)
				{
				}
				return this.radWideTPSFiregroundRespondToPolls_A33573._HasDiffs;
			}
		}

		// Token: 0x17001A38 RID: 6712
		// (get) Token: 0x060033EE RID: 13294 RVA: 0x0031F5AC File Offset: 0x0031D7AC
		// (set) Token: 0x060033EF RID: 13295 RVA: 0x0031F664 File Offset: 0x0031D864
		public bool RadWidePAACKAlertsonPTT_A43099Value
		{
			get
			{
				short num = (short)903479296;
				short num2 = num;
				num = (short)619940628;
				short num3 = num;
				num = (short)863210260;
				switch (num3 == num)
				{
				}
				num = (short)781647872;
				if (num != 0)
				{
				}
				num = (short)1850212353;
				if (num != 0)
				{
				}
				return this.radWidePAACKAlertsonPTT_A43099.Value;
			}
			set
			{
				short num = (short)1281818624;
				short num2 = num;
				num = (short)777490004;
				short num3 = num;
				num = (short)614698580;
				switch (num3 == num)
				{
				}
				num = (short)2114715649;
				if (num != 0)
				{
				}
				num = (short)640483328;
				if (num != 0)
				{
				}
				this.radWidePAACKAlertsonPTT_A43099.Value = value;
			}
		}

		// Token: 0x17001A39 RID: 6713
		// (get) Token: 0x060033F0 RID: 13296 RVA: 0x0031F71C File Offset: 0x0031D91C
		public global::AcpBusinessLayer.AcpField<bool> RadWidePAACKAlertsonPTT_A43099
		{
			get
			{
				short num = (short)1221263360;
				short num2 = num;
				num = (short)515637249;
				if (num != 0)
				{
				}
				num = (short)1757306549;
				short num3 = num;
				num = (short)1328307893;
				switch (num3 == num)
				{
				}
				num = (short)1889992704;
				if (num != 0)
				{
				}
				return this.radWidePAACKAlertsonPTT_A43099;
			}
		}

		// Token: 0x17001A3A RID: 6714
		// (get) Token: 0x060033F1 RID: 13297 RVA: 0x0031F7D0 File Offset: 0x0031D9D0
		// (set) Token: 0x060033F2 RID: 13298 RVA: 0x0031F884 File Offset: 0x0031DA84
		public bool RadWidePAACKAlertsonPTT_A43099_UIValue
		{
			get
			{
				short num = (short)1798111232;
				short num2 = num;
				num = (short)290245856;
				short num3 = num;
				num = (short)1328008416;
				switch (num3 == num)
				{
				}
				num = (short)121569280;
				if (num != 0)
				{
				}
				num = (short)1007288321;
				if (num != 0)
				{
				}
				return this.radWidePAACKAlertsonPTT_A43099.Value;
			}
			set
			{
				short num = (short)1225457664;
				short num2 = num;
				num = (short)151821822;
				short num3 = num;
				num = (short)651402750;
				switch (num3 == num)
				{
				}
				num = (short)2125529088;
				if (num != 0)
				{
				}
				num = (short)850067457;
				if (num != 0)
				{
				}
				this.radWidePAACKAlertsonPTT_A43099.Value = value;
			}
		}

		// Token: 0x17001A3B RID: 6715
		// (get) Token: 0x060033F3 RID: 13299 RVA: 0x0031F938 File Offset: 0x0031DB38
		// (set) Token: 0x060033F4 RID: 13300 RVA: 0x0031F9EC File Offset: 0x0031DBEC
		public bool RadWidePAACKAlertsonPTT_A43099_Applicable
		{
			get
			{
				short num = (short)184483840;
				short num2 = num;
				num = (short)2004186103;
				short num3 = num;
				num = (short)1552380919;
				switch (num3 == num)
				{
				}
				num = (short)1424424961;
				if (num != 0)
				{
				}
				num = (short)1289879552;
				if (num != 0)
				{
				}
				return this.radWidePAACKAlertsonPTT_A43099.Applicable;
			}
			set
			{
				short num = (short)1633812480;
				short num2 = num;
				num = (short)1605346698;
				short num3 = num;
				num = (short)837002634;
				switch (num3 == num)
				{
				}
				num = (short)2077163520;
				if (num != 0)
				{
				}
				num = (short)247267329;
				if (num != 0)
				{
				}
				this.radWidePAACKAlertsonPTT_A43099.Applicable = value;
			}
		}

		// Token: 0x17001A3C RID: 6716
		// (get) Token: 0x060033F5 RID: 13301 RVA: 0x0031FAA0 File Offset: 0x0031DCA0
		// (set) Token: 0x060033F6 RID: 13302 RVA: 0x0031FB58 File Offset: 0x0031DD58
		public bool RadWidePAACKAlertsonPTT_A43099_Valid
		{
			get
			{
				short num = (short)413466624;
				short num2 = num;
				num = (short)1846801890;
				short num3 = num;
				num = (short)154531298;
				switch (num3 == num)
				{
				}
				num = (short)869269504;
				if (num != 0)
				{
				}
				num = (short)1824915457;
				if (num != 0)
				{
				}
				return this.radWidePAACKAlertsonPTT_A43099.Valid;
			}
			set
			{
				short num = (short)1273233408;
				short num2 = num;
				num = (short)920462042;
				short num3 = num;
				num = (short)1153180378;
				switch (num3 == num)
				{
				}
				num = (short)1856765953;
				if (num != 0)
				{
				}
				num = (short)194510848;
				if (num != 0)
				{
				}
				this.radWidePAACKAlertsonPTT_A43099.Valid = value;
			}
		}

		// Token: 0x17001A3D RID: 6717
		// (get) Token: 0x060033F7 RID: 13303 RVA: 0x0031FC10 File Offset: 0x0031DE10
		// (set) Token: 0x060033F8 RID: 13304 RVA: 0x0031FCC4 File Offset: 0x0031DEC4
		public bool RadWidePAACKAlertsonPTT_A43099_Visible
		{
			get
			{
				short num = (short)1888878592;
				short num2 = num;
				num = (short)1405126840;
				short num3 = num;
				num = (short)1769834680;
				switch (num3 == num)
				{
				}
				num = (short)919863297;
				if (num != 0)
				{
				}
				num = (short)1926496256;
				if (num != 0)
				{
				}
				return this.radWidePAACKAlertsonPTT_A43099.Visible;
			}
			set
			{
				short num = (short)1237123072;
				short num2 = num;
				num = (short)1818361857;
				if (num != 0)
				{
				}
				num = (short)467156377;
				short num3 = num;
				num = (short)16006553;
				switch (num3 == num)
				{
				}
				num = (short)150929408;
				if (num != 0)
				{
				}
				this.radWidePAACKAlertsonPTT_A43099.Visible = value;
			}
		}

		// Token: 0x17001A3E RID: 6718
		// (get) Token: 0x060033F9 RID: 13305 RVA: 0x0031FD7C File Offset: 0x0031DF7C
		// (set) Token: 0x060033FA RID: 13306 RVA: 0x0031FE34 File Offset: 0x0031E034
		public bool RadWidePAACKAlertsonPTT_A43099_Editable
		{
			get
			{
				short num = (short)1009582080;
				short num2 = num;
				num = (short)814889745;
				short num3 = num;
				num = (short)1763261201;
				switch (num3 == num)
				{
				}
				num = (short)2079391745;
				if (num != 0)
				{
				}
				num = (short)2105802752;
				if (num != 0)
				{
				}
				return this.radWidePAACKAlertsonPTT_A43099.Editable;
			}
			set
			{
				short num = (short)592183296;
				short num2 = num;
				num = (short)1359071665;
				short num3 = num;
				num = (short)1805633969;
				switch (num3 == num)
				{
				}
				num = (short)1096220673;
				if (num != 0)
				{
				}
				num = (short)37158912;
				if (num != 0)
				{
				}
				this.radWidePAACKAlertsonPTT_A43099.Editable = value;
			}
		}

		// Token: 0x17001A3F RID: 6719
		// (get) Token: 0x060033FB RID: 13307 RVA: 0x0031FEE8 File Offset: 0x0031E0E8
		internal string RadWidePAACKAlertsonPTT_A43099_UILabel
		{
			get
			{
				short num = (short)1257308160;
				short num2 = num;
				num = (short)280205285;
				short num3 = num;
				num = (short)952145893;
				switch (num3 == num)
				{
				}
				num = (short)1723990016;
				if (num != 0)
				{
				}
				num = (short)234815489;
				if (num != 0)
				{
				}
				return this.radWidePAACKAlertsonPTT_A43099.UIName;
			}
		}

		// Token: 0x17001A40 RID: 6720
		// (get) Token: 0x060033FC RID: 13308 RVA: 0x0031FF98 File Offset: 0x0031E198
		// (set) Token: 0x060033FD RID: 13309 RVA: 0x0032004C File Offset: 0x0031E24C
		internal bool RadWidePAACKAlertsonPTT_A43099_HiddenStatic
		{
			get
			{
				short num = (short)582877184;
				short num2 = num;
				num = (short)2072641537;
				if (num != 0)
				{
				}
				num = (short)1578429676;
				short num3 = num;
				num = (short)237694188;
				switch (num3 == num)
				{
				}
				num = (short)709230592;
				if (num != 0)
				{
				}
				return this.radWidePAACKAlertsonPTT_A43099.HiddenStatic;
			}
			set
			{
				short num = (short)2087256064;
				short num2 = num;
				num = (short)362073395;
				short num3 = num;
				num = (short)179227955;
				switch (num3 == num)
				{
				}
				num = (short)911933441;
				if (num != 0)
				{
				}
				num = (short)1126825984;
				if (num != 0)
				{
				}
				this.radWidePAACKAlertsonPTT_A43099.HiddenStatic = value;
			}
		}

		// Token: 0x17001A41 RID: 6721
		// (get) Token: 0x060033FE RID: 13310 RVA: 0x00320100 File Offset: 0x0031E300
		// (set) Token: 0x060033FF RID: 13311 RVA: 0x003201B4 File Offset: 0x0031E3B4
		internal bool RadWidePAACKAlertsonPTT_A43099_HiddenDynamic
		{
			get
			{
				short num = (short)1365245952;
				short num2 = num;
				num = (short)1775656541;
				short num3 = num;
				num = (short)1121738333;
				switch (num3 == num)
				{
				}
				num = (short)1125711873;
				if (num != 0)
				{
				}
				num = (short)1681129472;
				if (num != 0)
				{
				}
				return this.radWidePAACKAlertsonPTT_A43099.HiddenDynamic;
			}
			set
			{
				short num = (short)1499004928;
				short num2 = num;
				num = (short)304610390;
				short num3 = num;
				num = (short)859438166;
				switch (num3 == num)
				{
				}
				num = (short)1458503681;
				if (num != 0)
				{
				}
				num = (short)209059840;
				if (num != 0)
				{
				}
				this.radWidePAACKAlertsonPTT_A43099.HiddenDynamic = value;
			}
		}

		// Token: 0x17001A42 RID: 6722
		// (get) Token: 0x06003400 RID: 13312 RVA: 0x0032026C File Offset: 0x0031E46C
		public bool RadWidePAACKAlertsonPTT_A43099_HasDiffs
		{
			get
			{
				short num = (short)1786970112;
				short num2 = num;
				num = (short)587402503;
				short num3 = num;
				num = (short)709037319;
				switch (num3 == num)
				{
				}
				num = (short)1271463937;
				if (num != 0)
				{
				}
				num = (short)1949302784;
				if (num != 0)
				{
				}
				return this.radWidePAACKAlertsonPTT_A43099._HasDiffs;
			}
		}

		// Token: 0x06003401 RID: 13313 RVA: 0x00320320 File Offset: 0x0031E520
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::AcpCommonLib.IAcpRecordset result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_3A;
				case 1:
					return result;
				case 2:
				{
					num2 = (short)676914931;
					short num3 = num2;
					num2 = (short)1543104243;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3A;
					default:
						num2 = (short)2143879168;
						if (num2 != 0)
						{
						}
						num2 = (short)1362624513;
						if (num2 != 0)
						{
						}
						num2 = (short)1594818564;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
				{
					num2 = (short)1028194304;
					short num4 = num2;
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)240451585;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)458686467;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				goto IL_24;
				IL_3A:
				if (base.ParentRecset == null)
				{
					break;
				}
				num2 = (short)1786511362;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)276037632;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04001195 RID: 4501
		private global::AcpBusinessLayer.AcpListField radWideTPSFiregroundEmergencyPTTTransmission_A33203;

		// Token: 0x04001196 RID: 4502
		private global::AcpBusinessLayer.AcpListField radWideTPSFiregroundEvacuationAcknowledgement_A33216;

		// Token: 0x04001197 RID: 4503
		private global::AcpBusinessLayer.AcpSimpleRangeField radWideTPSFiregroundPeriodicUpdateTimer_A33467;

		// Token: 0x04001198 RID: 4504
		private global::AcpBusinessLayer.AcpListField radWideFiregroundPTTTransmission_A33515;

		// Token: 0x04001199 RID: 4505
		private global::AcpBusinessLayer.AcpField<bool> radWideTPSFiregroundRespondToPolls_A33573;

		// Token: 0x0400119A RID: 4506
		private global::AcpBusinessLayer.AcpField<bool> radWidePAACKAlertsonPTT_A43099;
	}
}
