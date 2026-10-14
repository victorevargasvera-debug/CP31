using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingWide
{
	// Token: 0x0200005E RID: 94
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600065A RID: 1626 RVA: 0x000677C4 File Offset: 0x000659C4
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x000677E0 File Offset: 0x000659E0
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x000677F8 File Offset: 0x000659F8
		public override void Init()
		{
			int a_ = 7;
			short num = (short)657619573;
			short num2 = num;
			num = (short)1591048821;
			switch (num2 == num)
			{
			}
			num = (short)973930497;
			if (num != 0)
			{
			}
			num = (short)601620480;
			if (num != 0)
			{
			}
			num = (short)671612928;
			short num3 = num;
			this.trkWideGeneralPhoneAutoDialHoldoffms_A7506 = new global::AcpBusinessLayer.AcpSimpleRangeField(80, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ駍맏뛑뇓釕뷗듙맛곝臟軡듣軥蟧蓩觫꿭藯蛱鯳답釷鯹郻뛽濿渁怃椅渇氉愋納伏匑⌓⌕⠗Ⱉ", a_), global::CommonResources.AcgResources.ID_PHONEAUTODIALHOLDOFFMS, 0, 255, null, null, 0, 25);
			this.trkWideGeneralPhoneAutoDialHoldoffms_A7506.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkWideGeneralPhoneAutoDialHoldoffms_A7506.DataTransferOrder = 1;
			this.trkWideGeneralPhoneAutoDialHoldoffms_A7506.ShowHexValue = false;
			this.trkWideGeneralEmergencyBlockedInFailsoft_A7934 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ駍맏뛑뇓釕뷗듙맛곝臟軡ꇣ该跧飩诫语黯釱跳듵铷闹鿻闽旿昁䴃栅万欉攋戍挏紑爓戕䜗嬙⬛✝ጟᘡ", a_), global::CommonResources.AcgResources.ID_EMERGENCYBLOCKEDINFAILSOFT);
			this.trkWideGeneralEmergencyBlockedInFailsoft_A7934.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkWideGeneralEmergencyBlockedInFailsoft_A7934.DataTransferOrder = 2;
			this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290 = new global::AcpBusinessLayer.AcpSimpleRangeField(61, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ駍맏뛑뇓釕뷗듙맛곝臟軡귣裥賧菩髫蟭铯蟱闳髵믷鯹郻鋽䷿持簃刅椇砉欋欍搏䀑紓砕缗丙甛猝䔟儡䄣䔥眧欩ᐫᰭयȱ", a_), global::CommonResources.AcgResources.ID_INDIVIDUALCALLMAXTARGETRINGTIMESEC, 61, 120, null, null, 0, 1);
			this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290.DataTransferOrder = 3;
			this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290.AddCustomValue(0, global::CommonResources.AcgResources.ID_INFINITE);
			this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290.ShowHexValue = false;
			this.trkWideGeneralPrivateCallMaxInitialRingsec_A8758 = new global::AcpBusinessLayer.AcpSimpleRangeField(30, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ駍맏뛑뇓釕뷗듙맛곝臟軡듣铥臧鳩跫髭闯뇱闳髵铷럹鷻蛽䧿氁洃爅愇欉怋對礏簑猓攕紗礙䌛弝᠟ᔡᄣḥ", a_), global::CommonResources.AcgResources.ID_PRIVATECALLMAXINITIALRINGSEC, 0, 255, global::CommonResources.AcgResources.ID_INFINITE, null, 0, 1);
			this.trkWideGeneralPrivateCallMaxInitialRingsec_A8758.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkWideGeneralPrivateCallMaxInitialRingsec_A8758.DataTransferOrder = 4;
			this.trkWideGeneralPrivateCallMaxInitialRingsec_A8758.ShowHexValue = false;
			this.trkWideGeneralAFCDisable_A41850 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ駍맏뛑뇓釕뷗듙맛곝臟軡ꗣꃥꯧ껩藫鷭釯郱飳鏵ꟷ믹죻쿽㣿㜁㐃", a_), global::CommonResources.AcgResources.ID_AFCDISABLE);
			this.trkWideGeneralAFCDisable_A41850.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.trkWideGeneralAFCDisable_A41850.DataTransferOrder = 34;
			this.trkWideGeneralBypassQuickKeyVoiceChannelAccess_42447 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鳇룉Ɤ駍맏뛑뇓釕뷗듙맛곝臟軡ꛣ鿥飧诩鿫鷭ꇯ蟱鷳闵鏷뇹駻蟽囿洁洃攅洇䤉搋漍縏簑焓稕夗礙缛笝匟儡笣ሥᨧḩᠫ᤭", a_), global::CommonResources.AcgResources.ID_BYPASSQUICKKEYVOICECHANNELACCESS);
			this.trkWideGeneralBypassQuickKeyVoiceChannelAccess_42447.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
			this.trkWideGeneralBypassQuickKeyVoiceChannelAccess_42447.DataTransferOrder = 35;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("过꿉ꋋꯍꋏ돑룓", a_);
			base.Id = 10062;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00067A88 File Offset: 0x00065C88
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 18;
			short num = (short)670040073;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟒꟔볖軘닚맜뫞ꛠ蛢诤苦鯨諪臬귮裰菲铴蓶諸꫺裼雾戀栂丄戆瀈崊戌明爐瘒嘔编砘甚猜稞䴠戢䘤䐦䰨堪帬瀮԰ĲĴ̶ุ", a_)))
					{
						num = (short)171507731;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_594;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟒꟔볖軘닚맜뫞ꛠ蛢诤苦鯨諪臬ꫮ鳰雲蟴郶鳸闺黼蛾䌀漂樄搆戈渊椌䘎缐唒琔縖甘栚爜礞唠簢搤ဦဨᠪ᤬", a_)))
					{
						num = (short)1303183360;
						short num3 = num;
						num = (short)968425487;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_32E;
				case 2:
					goto IL_32E;
				case 3:
					num = (short)673644556;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_329;
				case 5:
					goto IL_492;
				case 6:
					if (producerFields != null)
					{
						num = (short)768802819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_594;
				case 7:
					this.trkWideGeneralPrivateCallMaxInitialRingsec_A8758 = new global::AcpBusinessLayer.AcpSimpleRangeField(30, this, global::AllFeatures.CodeplugGuid.b("蟒꟔볖軘닚맜뫞ꛠ蛢诤苦鯨諪臬뿮菰髲菴零跸黺뻼黾洀漂䠄昆焈䈊挌明攐稒琔笖䬘爚猜砞删䘢䘤砦栨ጪᨬᨮर", a_), global::CommonResources.AcgResources.ID_PRIVATECALLMAXINITIALRINGSEC, global::CommonResources.AcgResources.ID_INFINITE, null, 0, 1);
					this.trkWideGeneralPrivateCallMaxInitialRingsec_A8758.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkWideGeneralPrivateCallMaxInitialRingsec_A8758.DataTransferOrder = 4;
					this.trkWideGeneralPrivateCallMaxInitialRingsec_A8758.ShowHexValue = false;
					num = (short)949485584;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_3C8;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_86;
					}
					continue;
				case 10:
					this.trkWideGeneralPhoneAutoDialHoldoffms_A7506 = new global::AcpBusinessLayer.AcpSimpleRangeField(80, this, global::AllFeatures.CodeplugGuid.b("蟒꟔볖軘닚맜뫞ꛠ蛢诤苦鯨諪臬뿮駰鳲鯴鋶룸軺觼郾䔀樂搄欆䄈搊愌欎縐甒猔稖樘䐚尜⠞ᐠጢጤ", a_), global::CommonResources.AcgResources.ID_PHONEAUTODIALHOLDOFFMS, null, null, 0, 25);
					this.trkWideGeneralPhoneAutoDialHoldoffms_A7506.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkWideGeneralPhoneAutoDialHoldoffms_A7506.DataTransferOrder = 1;
					this.trkWideGeneralPhoneAutoDialHoldoffms_A7506.ShowHexValue = false;
					num = (short)394133512;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟒꟔볖軘닚맜뫞ꛠ蛢诤苦鯨諪臬뿮菰髲菴零跸黺뻼黾洀漂䠄昆焈䈊挌明攐稒琔笖䬘爚猜砞删䘢䘤砦栨ጪᨬᨮर", a_)))
					{
						num = (short)1913847815;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A9;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟒꟔볖軘닚맜뫞ꛠ蛢诤苦鯨諪臬뿮駰鳲鯴鋶룸軺觼郾䔀樂搄欆䄈搊愌欎縐甒猔稖樘䐚尜⠞ᐠጢጤ", a_)))
					{
						num = (short)588972042;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_3C8;
				case 13:
					goto IL_43D;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟒꟔볖軘닚맜뫞ꛠ蛢诤苦鯨諪臬ꛮ鿰韲鳴臶郸鿺裼黾洀䀂搄欆攈䘊氌眎䔐爒朔瀖簘漚伜瘞传䐢焤並䐨个帬䨮到氲琴༶ସȺ഼", a_)))
					{
						num = (short)1860960274;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_492;
				case 15:
					this.trkWideGeneralEmergencyBlockedInFailsoft_A7934 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蟒꟔볖軘닚맜뫞ꛠ蛢诤苦鯨諪臬ꫮ鳰雲蟴郶鳸闺黼蛾䌀漂樄搆戈渊椌䘎缐唒琔縖甘栚爜礞唠簢搤ဦဨᠪ᤬", a_), global::CommonResources.AcgResources.ID_EMERGENCYBLOCKEDINFAILSOFT);
					this.trkWideGeneralEmergencyBlockedInFailsoft_A7934.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkWideGeneralEmergencyBlockedInFailsoft_A7934.DataTransferOrder = 2;
					num = (short)1187119106;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					goto IL_A9;
				case 17:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟒꟔볖軘닚맜뫞ꛠ蛢诤苦鯨諪臬껮런냲뇴黶諸髺鿼鏾搀専䐄㌆㠈㌊㠌㼎", a_)))
					{
						num = (short)1120665613;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D4;
				case 18:
				{
					num = (short)717528313;
					short num4 = num;
					num = (short)2144509177;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_43D;
					default:
						num = (short)1218379776;
						if (num != 0)
						{
						}
						this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290 = new global::AcpBusinessLayer.AcpSimpleRangeField(61, this, global::AllFeatures.CodeplugGuid.b("蟒꟔볖軘닚맜뫞ꛠ蛢诤苦鯨諪臬ꛮ鿰韲鳴臶郸鿺裼黾洀䀂搄欆攈䘊氌眎䔐爒朔瀖簘漚伜瘞传䐢焤並䐨个帬䨮到氲琴༶ସȺ഼", a_), global::CommonResources.AcgResources.ID_INDIVIDUALCALLMAXTARGETRINGTIMESEC, null, null, 0, 1);
						this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
						this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290.DataTransferOrder = 3;
						this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290.AddCustomValue(0, global::CommonResources.AcgResources.ID_INFINITE);
						this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290.ShowHexValue = false;
						num = (short)1780613125;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 19:
					this.trkWideGeneralBypassQuickKeyVoiceChannelAccess_42447 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蟒꟔볖軘닚맜뫞ꛠ蛢诤苦鯨諪臬귮裰菲铴蓶諸꫺裼雾戀栂丄戆瀈崊戌明爐瘒嘔编砘甚猜稞䴠戢䘤䐦䰨堪帬瀮԰ĲĴ̶ุ", a_), global::CommonResources.AcgResources.ID_BYPASSQUICKKEYVOICECHANNELACCESS);
					this.trkWideGeneralBypassQuickKeyVoiceChannelAccess_42447.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
					this.trkWideGeneralBypassQuickKeyVoiceChannelAccess_42447.DataTransferOrder = 35;
					num = (short)74055684;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					goto IL_1D4;
				case 21:
					num = (short)1091174401;
					if (num != 0)
					{
					}
					num = (short)464650246;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_86:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1816854549;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_A9:
				num = (short)446824465;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1D4:
				num = (short)1316093952;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_32E:
				num = (short)1479802894;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3C8:
				num = (short)1998389249;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_43D:
				this.trkWideGeneralAFCDisable_A41850 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蟒꟔볖軘닚맜뫞ꛠ蛢诤苦鯨諪臬껮런냲뇴黶諸髺鿼鏾搀専䐄㌆㠈㌊㠌㼎", a_), global::CommonResources.AcgResources.ID_AFCDISABLE);
				this.trkWideGeneralAFCDisable_A41850.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Secret;
				this.trkWideGeneralAFCDisable_A41850.DataTransferOrder = 34;
				num = (short)1367015444;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_492:
				num = (short)889520139;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_329:
			IL_594:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("铒냔맖볘꧚볜돞", a_);
			base.Id = 10062;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x0006805C File Offset: 0x0006625C
		public override void PopulateReferences()
		{
			short num = (short)959101101;
			short num2 = num;
			num = (short)1807464621;
			switch (num2 == num)
			{
			}
			num = (short)146145280;
			if (num != 0)
			{
			}
			num = (short)1842741249;
			if (num != 0)
			{
			}
			num = (short)831979520;
			short num3 = num;
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00068108 File Offset: 0x00066308
		public override void DropReferences()
		{
			short num = (short)1283352788;
			short num2 = num;
			num = (short)1683450068;
			switch (num2 == num)
			{
			}
			num = (short)131006465;
			if (num != 0)
			{
			}
			num = (short)2066743296;
			if (num != 0)
			{
			}
			num = (short)2113929216;
			short num3 = num;
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x000681B4 File Offset: 0x000663B4
		public override void SetConstraints()
		{
			short num = (short)1669101448;
			short num2 = num;
			num = (short)284587912;
			switch (num2 == num)
			{
			}
			num = (short)952893441;
			if (num != 0)
			{
			}
			num = (short)1929052160;
			if (num != 0)
			{
			}
			num = (short)1972895744;
			short num3 = num;
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00068260 File Offset: 0x00066460
		public override void SetupDependencies()
		{
			short num = (short)195764869;
			short num2 = num;
			num = (short)74392197;
			switch (num2 == num)
			{
			}
			num = (short)1538523137;
			if (num != 0)
			{
			}
			num = (short)1948581888;
			if (num != 0)
			{
			}
			num = (short)369557504;
			short num3 = num;
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x00068308 File Offset: 0x00066508
		public bool HasDiffs
		{
			get
			{
				short num = (short)2115387653;
				short num2 = num;
				num = (short)1234518277;
				switch (num2 == num)
				{
				}
				num = (short)847577089;
				if (num != 0)
				{
				}
				num = (short)1074790400;
				if (num != 0)
				{
				}
				num = (short)708444160;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x06000663 RID: 1635 RVA: 0x000683B8 File Offset: 0x000665B8
		// (set) Token: 0x06000664 RID: 1636 RVA: 0x0006846C File Offset: 0x0006666C
		public int TrkWideGeneralPhoneAutoDialHoldoffms_A7506Value
		{
			get
			{
				short num = (short)890469532;
				short num2 = num;
				num = (short)894205084;
				switch (num2 == num)
				{
				}
				num = (short)470024193;
				if (num != 0)
				{
				}
				num = (short)57475072;
				if (num != 0)
				{
				}
				num = (short)214958080;
				short num3 = num;
				return this.trkWideGeneralPhoneAutoDialHoldoffms_A7506.Value;
			}
			set
			{
				short num = (short)1424701458;
				short num2 = num;
				num = (short)1287141394;
				switch (num2 == num)
				{
				}
				num = (short)628359169;
				if (num != 0)
				{
				}
				num = (short)30146560;
				if (num != 0)
				{
				}
				num = (short)224657408;
				short num3 = num;
				this.trkWideGeneralPhoneAutoDialHoldoffms_A7506.Value = value;
			}
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000665 RID: 1637 RVA: 0x00068520 File Offset: 0x00066720
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkWideGeneralPhoneAutoDialHoldoffms_A7506
		{
			get
			{
				short num = (short)383892663;
				short num2 = num;
				num = (short)2075114679;
				switch (num2 == num)
				{
				}
				num = (short)1652424705;
				if (num != 0)
				{
				}
				num = (short)417005568;
				if (num != 0)
				{
				}
				num = (short)1717239808;
				short num3 = num;
				return this.trkWideGeneralPhoneAutoDialHoldoffms_A7506;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x000685D0 File Offset: 0x000667D0
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x00068680 File Offset: 0x00066880
		public string TrkWideGeneralPhoneAutoDialHoldoffms_A7506_UIValue
		{
			get
			{
				short num = (short)1838611248;
				short num2 = num;
				num = (short)2126576432;
				switch (num2 == num)
				{
				}
				num = (short)436469760;
				if (num != 0)
				{
				}
				num = (short)1985347585;
				if (num != 0)
				{
				}
				num = (short)1522860032;
				short num3 = num;
				return this.trkWideGeneralPhoneAutoDialHoldoffms_A7506.UIValue;
			}
			set
			{
				short num = (short)1040167166;
				short num2 = num;
				num = (short)2117775614;
				switch (num2 == num)
				{
				}
				num = (short)296091649;
				if (num != 0)
				{
				}
				num = (short)1236926464;
				if (num != 0)
				{
				}
				num = (short)191037440;
				short num3 = num;
				this.trkWideGeneralPhoneAutoDialHoldoffms_A7506.UIValue = value;
			}
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000668 RID: 1640 RVA: 0x00068734 File Offset: 0x00066934
		// (set) Token: 0x06000669 RID: 1641 RVA: 0x000687EC File Offset: 0x000669EC
		internal int TrkWideGeneralPhoneAutoDialHoldoffms_A7506Min
		{
			get
			{
				short num = (short)348601111;
				short num2 = num;
				num = (short)448281367;
				switch (num2 == num)
				{
				}
				num = (short)921567233;
				if (num != 0)
				{
				}
				num = (short)340393984;
				if (num != 0)
				{
				}
				num = (short)1907163136;
				short num3 = num;
				return this.trkWideGeneralPhoneAutoDialHoldoffms_A7506.Min;
			}
			set
			{
				short num = (short)1179772612;
				short num2 = num;
				num = (short)1087170244;
				switch (num2 == num)
				{
				}
				num = (short)1520828417;
				if (num != 0)
				{
				}
				num = (short)954728448;
				if (num != 0)
				{
				}
				num = (short)328204288;
				short num3 = num;
				this.trkWideGeneralPhoneAutoDialHoldoffms_A7506.Min = value;
			}
		}

		// Token: 0x1700030B RID: 779
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x000688A4 File Offset: 0x00066AA4
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x00068958 File Offset: 0x00066B58
		internal int TrkWideGeneralPhoneAutoDialHoldoffms_A7506Max
		{
			get
			{
				short num = (short)1314567983;
				short num2 = num;
				num = (short)1451210543;
				switch (num2 == num)
				{
				}
				num = (short)2013790208;
				if (num != 0)
				{
				}
				num = (short)1696530433;
				if (num != 0)
				{
				}
				num = (short)912785408;
				short num3 = num;
				return this.trkWideGeneralPhoneAutoDialHoldoffms_A7506.Max;
			}
			set
			{
				short num = (short)514936229;
				short num2 = num;
				num = (short)2045529509;
				switch (num2 == num)
				{
				}
				num = (short)1912406017;
				if (num != 0)
				{
				}
				num = (short)234946560;
				if (num != 0)
				{
				}
				num = (short)133038080;
				short num3 = num;
				this.trkWideGeneralPhoneAutoDialHoldoffms_A7506.Max = value;
			}
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x00068A10 File Offset: 0x00066C10
		// (set) Token: 0x0600066D RID: 1645 RVA: 0x00068AC8 File Offset: 0x00066CC8
		internal int TrkWideGeneralPhoneAutoDialHoldoffms_A7506Step
		{
			get
			{
				short num = (short)1417386908;
				short num2 = num;
				num = (short)181574556;
				switch (num2 == num)
				{
				}
				num = (short)410255361;
				if (num != 0)
				{
				}
				num = (short)1107034112;
				if (num != 0)
				{
				}
				num = (short)917569536;
				short num3 = num;
				return this.trkWideGeneralPhoneAutoDialHoldoffms_A7506.StepSize;
			}
			set
			{
				short num = (short)1054531637;
				short num2 = num;
				num = (short)36298805;
				switch (num2 == num)
				{
				}
				num = (short)477167617;
				if (num != 0)
				{
				}
				num = (short)763363328;
				if (num != 0)
				{
				}
				num = (short)2105081856;
				short num3 = num;
				this.trkWideGeneralPhoneAutoDialHoldoffms_A7506.StepSize = value;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x0600066E RID: 1646 RVA: 0x00068B80 File Offset: 0x00066D80
		// (set) Token: 0x0600066F RID: 1647 RVA: 0x00068C34 File Offset: 0x00066E34
		public bool TrkWideGeneralPhoneAutoDialHoldoffms_A7506_Applicable
		{
			get
			{
				short num = (short)1047500781;
				short num2 = num;
				num = (short)135632877;
				switch (num2 == num)
				{
				}
				num = (short)766836737;
				if (num != 0)
				{
				}
				num = (short)676462592;
				if (num != 0)
				{
				}
				num = (short)184877056;
				short num3 = num;
				return this.trkWideGeneralPhoneAutoDialHoldoffms_A7506.Applicable;
			}
			set
			{
				short num = (short)1458170617;
				short num2 = num;
				num = (short)608168697;
				switch (num2 == num)
				{
				}
				num = (short)1071972352;
				if (num != 0)
				{
				}
				num = (short)853475329;
				if (num != 0)
				{
				}
				num = (short)226820096;
				short num3 = num;
				this.trkWideGeneralPhoneAutoDialHoldoffms_A7506.Applicable = value;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000670 RID: 1648 RVA: 0x00068CEC File Offset: 0x00066EEC
		// (set) Token: 0x06000671 RID: 1649 RVA: 0x00068DA4 File Offset: 0x00066FA4
		public bool TrkWideGeneralPhoneAutoDialHoldoffms_A7506_Valid
		{
			get
			{
				short num = (short)804874192;
				short num2 = num;
				num = (short)646277072;
				switch (num2 == num)
				{
				}
				num = (short)1644953601;
				if (num != 0)
				{
				}
				num = (short)1479409664;
				if (num != 0)
				{
				}
				num = (short)1286733824;
				short num3 = num;
				return this.trkWideGeneralPhoneAutoDialHoldoffms_A7506.Valid;
			}
			set
			{
				short num = (short)1136350302;
				short num2 = num;
				num = (short)1996117086;
				switch (num2 == num)
				{
				}
				num = (short)753729536;
				if (num != 0)
				{
				}
				num = (short)1605500929;
				if (num != 0)
				{
				}
				num = (short)1564409856;
				short num3 = num;
				this.trkWideGeneralPhoneAutoDialHoldoffms_A7506.Valid = value;
			}
		}

		// Token: 0x1700030F RID: 783
		// (get) Token: 0x06000672 RID: 1650 RVA: 0x00068E58 File Offset: 0x00067058
		// (set) Token: 0x06000673 RID: 1651 RVA: 0x00068F10 File Offset: 0x00067110
		public bool TrkWideGeneralPhoneAutoDialHoldoffms_A7506_Visible
		{
			get
			{
				short num = (short)993918977;
				if (num != 0)
				{
				}
				num = (short)324030734;
				short num2 = num;
				num = (short)21582094;
				switch (num2 == num)
				{
				}
				num = (short)1527775232;
				if (num != 0)
				{
				}
				num = (short)1850867712;
				short num3 = num;
				return this.trkWideGeneralPhoneAutoDialHoldoffms_A7506.Visible;
			}
			set
			{
				short num = (short)317546914;
				short num2 = num;
				num = (short)1138254242;
				switch (num2 == num)
				{
				}
				num = (short)1929969665;
				if (num != 0)
				{
				}
				num = (short)1028718592;
				if (num != 0)
				{
				}
				num = (short)418643968;
				short num3 = num;
				this.trkWideGeneralPhoneAutoDialHoldoffms_A7506.Visible = value;
			}
		}

		// Token: 0x17000310 RID: 784
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x00068FC8 File Offset: 0x000671C8
		// (set) Token: 0x06000675 RID: 1653 RVA: 0x00069080 File Offset: 0x00067280
		public bool TrkWideGeneralPhoneAutoDialHoldoffms_A7506_Editable
		{
			get
			{
				short num = (short)1184815859;
				short num2 = num;
				num = (short)1778047731;
				switch (num2 == num)
				{
				}
				num = (short)1491140609;
				if (num != 0)
				{
				}
				num = (short)252903424;
				if (num != 0)
				{
				}
				num = (short)553385984;
				short num3 = num;
				return this.trkWideGeneralPhoneAutoDialHoldoffms_A7506.Editable;
			}
			set
			{
				short num = (short)298302411;
				short num2 = num;
				num = (short)1152826315;
				switch (num2 == num)
				{
				}
				num = (short)1845821441;
				if (num != 0)
				{
				}
				num = (short)2096234496;
				if (num != 0)
				{
				}
				num = (short)820576256;
				short num3 = num;
				this.trkWideGeneralPhoneAutoDialHoldoffms_A7506.Editable = value;
			}
		}

		// Token: 0x17000311 RID: 785
		// (get) Token: 0x06000676 RID: 1654 RVA: 0x00069134 File Offset: 0x00067334
		internal string TrkWideGeneralPhoneAutoDialHoldoffms_A7506_UILabel
		{
			get
			{
				short num = (short)986713296;
				short num2 = num;
				num = (short)1679101136;
				switch (num2 == num)
				{
				}
				num = (short)1781792769;
				if (num != 0)
				{
				}
				num = (short)603848704;
				if (num != 0)
				{
				}
				num = (short)1849360384;
				short num3 = num;
				return this.trkWideGeneralPhoneAutoDialHoldoffms_A7506.UIName;
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000677 RID: 1655 RVA: 0x000691EC File Offset: 0x000673EC
		// (set) Token: 0x06000678 RID: 1656 RVA: 0x000692A0 File Offset: 0x000674A0
		internal bool TrkWideGeneralPhoneAutoDialHoldoffms_A7506_HiddenStatic
		{
			get
			{
				short num = (short)1309605889;
				if (num != 0)
				{
				}
				num = (short)1978445026;
				short num2 = num;
				num = (short)1864936674;
				switch (num2 == num)
				{
				}
				num = (short)879820800;
				if (num != 0)
				{
				}
				num = (short)444399616;
				short num3 = num;
				return this.trkWideGeneralPhoneAutoDialHoldoffms_A7506.HiddenStatic;
			}
			set
			{
				short num = (short)496566273;
				if (num != 0)
				{
				}
				num = (short)1802193121;
				short num2 = num;
				num = (short)1241204961;
				switch (num2 == num)
				{
				}
				num = (short)1097793536;
				if (num != 0)
				{
				}
				num = (short)1648492544;
				short num3 = num;
				this.trkWideGeneralPhoneAutoDialHoldoffms_A7506.HiddenStatic = value;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000679 RID: 1657 RVA: 0x00069354 File Offset: 0x00067554
		// (set) Token: 0x0600067A RID: 1658 RVA: 0x00069408 File Offset: 0x00067608
		internal bool TrkWideGeneralPhoneAutoDialHoldoffms_A7506_HiddenDynamic
		{
			get
			{
				short num = (short)295829505;
				if (num != 0)
				{
				}
				num = (short)1643192290;
				short num2 = num;
				num = (short)1789992930;
				switch (num2 == num)
				{
				}
				num = (short)1853292544;
				short num3 = num;
				num = (short)995622912;
				if (num != 0)
				{
				}
				return this.trkWideGeneralPhoneAutoDialHoldoffms_A7506.HiddenDynamic;
			}
			set
			{
				short num = (short)1952905941;
				short num2 = num;
				num = (short)406321877;
				switch (num2 == num)
				{
				}
				num = (short)2015297537;
				if (num != 0)
				{
				}
				num = (short)497418240;
				short num3 = num;
				num = (short)1867776000;
				if (num != 0)
				{
				}
				this.trkWideGeneralPhoneAutoDialHoldoffms_A7506.HiddenDynamic = value;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x0600067B RID: 1659 RVA: 0x000694C0 File Offset: 0x000676C0
		public bool TrkWideGeneralPhoneAutoDialHoldoffms_A7506_HasDiffs
		{
			get
			{
				short num = (short)1953536104;
				short num2 = num;
				num = (short)864196712;
				switch (num2 == num)
				{
				}
				num = (short)1023410176;
				if (num != 0)
				{
				}
				num = (short)625410048;
				short num3 = num;
				num = (short)1170472961;
				if (num != 0)
				{
				}
				return this.trkWideGeneralPhoneAutoDialHoldoffms_A7506._HasDiffs;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x00069570 File Offset: 0x00067770
		// (set) Token: 0x0600067D RID: 1661 RVA: 0x00069624 File Offset: 0x00067824
		public bool TrkWideGeneralEmergencyBlockedInFailsoft_A7934Value
		{
			get
			{
				short num = (short)488636417;
				if (num != 0)
				{
				}
				num = (short)594755483;
				short num2 = num;
				num = (short)760627099;
				switch (num2 == num)
				{
				}
				num = (short)337575936;
				short num3 = num;
				num = (short)722927616;
				if (num != 0)
				{
				}
				return this.trkWideGeneralEmergencyBlockedInFailsoft_A7934.Value;
			}
			set
			{
				short num = (short)2096918541;
				short num2 = num;
				num = (short)103706637;
				switch (num2 == num)
				{
				}
				num = (short)1674051584;
				if (num != 0)
				{
				}
				num = (short)1501429760;
				short num3 = num;
				num = (short)402784257;
				if (num != 0)
				{
				}
				this.trkWideGeneralEmergencyBlockedInFailsoft_A7934.Value = value;
			}
		}

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x0600067E RID: 1662 RVA: 0x000696DC File Offset: 0x000678DC
		public global::AcpBusinessLayer.AcpField<bool> TrkWideGeneralEmergencyBlockedInFailsoft_A7934
		{
			get
			{
				short num = (short)1505916536;
				short num2 = num;
				num = (short)1083930232;
				switch (num2 == num)
				{
				}
				num = (short)85655553;
				if (num != 0)
				{
				}
				num = (short)1726480384;
				short num3 = num;
				num = (short)2019033088;
				if (num != 0)
				{
				}
				return this.trkWideGeneralEmergencyBlockedInFailsoft_A7934;
			}
		}

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x0600067F RID: 1663 RVA: 0x0006978C File Offset: 0x0006798C
		// (set) Token: 0x06000680 RID: 1664 RVA: 0x00069844 File Offset: 0x00067A44
		public bool TrkWideGeneralEmergencyBlockedInFailsoft_A7934_UIValue
		{
			get
			{
				short num = (short)1673825215;
				short num2 = num;
				num = (short)1319799743;
				switch (num2 == num)
				{
				}
				num = (short)1684668417;
				if (num != 0)
				{
				}
				num = (short)910753792;
				short num3 = num;
				num = (short)491651072;
				if (num != 0)
				{
				}
				return this.trkWideGeneralEmergencyBlockedInFailsoft_A7934.Value;
			}
			set
			{
				short num = (short)1988040266;
				short num2 = num;
				num = (short)1654527562;
				switch (num2 == num)
				{
				}
				num = (short)1995898881;
				if (num != 0)
				{
				}
				num = (short)154730496;
				short num3 = num;
				num = (short)1019412480;
				if (num != 0)
				{
				}
				this.trkWideGeneralEmergencyBlockedInFailsoft_A7934.Value = value;
			}
		}

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06000681 RID: 1665 RVA: 0x000698F8 File Offset: 0x00067AF8
		// (set) Token: 0x06000682 RID: 1666 RVA: 0x000699AC File Offset: 0x00067BAC
		public bool TrkWideGeneralEmergencyBlockedInFailsoft_A7934_Applicable
		{
			get
			{
				short num = (short)225084446;
				short num2 = num;
				num = (short)671843358;
				switch (num2 == num)
				{
				}
				num = (short)217645056;
				if (num != 0)
				{
				}
				num = (short)165543936;
				short num3 = num;
				num = (short)1755054081;
				if (num != 0)
				{
				}
				return this.trkWideGeneralEmergencyBlockedInFailsoft_A7934.Applicable;
			}
			set
			{
				short num = (short)572747711;
				short num2 = num;
				num = (short)1870950335;
				switch (num2 == num)
				{
				}
				num = (short)871759872;
				if (num != 0)
				{
				}
				num = (short)682229760;
				short num3 = num;
				num = (short)681967617;
				if (num != 0)
				{
				}
				this.trkWideGeneralEmergencyBlockedInFailsoft_A7934.Applicable = value;
			}
		}

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06000683 RID: 1667 RVA: 0x00069A64 File Offset: 0x00067C64
		// (set) Token: 0x06000684 RID: 1668 RVA: 0x00069B18 File Offset: 0x00067D18
		public bool TrkWideGeneralEmergencyBlockedInFailsoft_A7934_Valid
		{
			get
			{
				short num = (short)115758270;
				short num2 = num;
				num = (short)323310782;
				switch (num2 == num)
				{
				}
				num = (short)1353515008;
				if (num != 0)
				{
				}
				num = (short)1169555456;
				short num3 = num;
				num = (short)2072969217;
				if (num != 0)
				{
				}
				return this.trkWideGeneralEmergencyBlockedInFailsoft_A7934.Valid;
			}
			set
			{
				short num = (short)1676686407;
				short num2 = num;
				num = (short)230896711;
				switch (num2 == num)
				{
				}
				num = (short)297861120;
				if (num != 0)
				{
				}
				num = (short)669712384;
				short num3 = num;
				num = (short)35389441;
				if (num != 0)
				{
				}
				this.trkWideGeneralEmergencyBlockedInFailsoft_A7934.Valid = value;
			}
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000685 RID: 1669 RVA: 0x00069BD0 File Offset: 0x00067DD0
		// (set) Token: 0x06000686 RID: 1670 RVA: 0x00069C84 File Offset: 0x00067E84
		public bool TrkWideGeneralEmergencyBlockedInFailsoft_A7934_Visible
		{
			get
			{
				short num = (short)1563370145;
				short num2 = num;
				num = (short)1842750113;
				switch (num2 == num)
				{
				}
				num = (short)1225719809;
				if (num != 0)
				{
				}
				num = (short)1478557696;
				short num3 = num;
				num = (short)1742864384;
				if (num != 0)
				{
				}
				return this.trkWideGeneralEmergencyBlockedInFailsoft_A7934.Visible;
			}
			set
			{
				short num = (short)623166384;
				short num2 = num;
				num = (short)1368900528;
				switch (num2 == num)
				{
				}
				num = (short)1981546497;
				if (num != 0)
				{
				}
				num = (short)665976832;
				short num3 = num;
				num = (short)129499136;
				if (num != 0)
				{
				}
				this.trkWideGeneralEmergencyBlockedInFailsoft_A7934.Visible = value;
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x00069D3C File Offset: 0x00067F3C
		// (set) Token: 0x06000688 RID: 1672 RVA: 0x00069DEC File Offset: 0x00067FEC
		public bool TrkWideGeneralEmergencyBlockedInFailsoft_A7934_Editable
		{
			get
			{
				short num = (short)1436909961;
				short num2 = num;
				num = (short)1776976265;
				switch (num2 == num)
				{
				}
				num = (short)1300561920;
				if (num != 0)
				{
				}
				num = (short)1074790400;
				short num3 = num;
				num = (short)292159489;
				if (num != 0)
				{
				}
				return this.trkWideGeneralEmergencyBlockedInFailsoft_A7934.Editable;
			}
			set
			{
				short num = (short)1011815646;
				short num2 = num;
				num = (short)1272255710;
				switch (num2 == num)
				{
				}
				num = (short)735117313;
				if (num != 0)
				{
				}
				num = (short)1575288832;
				short num3 = num;
				num = (short)1586626560;
				if (num != 0)
				{
				}
				this.trkWideGeneralEmergencyBlockedInFailsoft_A7934.Editable = value;
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000689 RID: 1673 RVA: 0x00069EA0 File Offset: 0x000680A0
		internal string TrkWideGeneralEmergencyBlockedInFailsoft_A7934_UILabel
		{
			get
			{
				short num = (short)202453271;
				short num2 = num;
				num = (short)1759654167;
				switch (num2 == num)
				{
				}
				num = (short)1707016193;
				if (num != 0)
				{
				}
				num = (short)1434517504;
				short num3 = num;
				num = (short)2128150528;
				if (num != 0)
				{
				}
				return this.trkWideGeneralEmergencyBlockedInFailsoft_A7934.UIName;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x0600068A RID: 1674 RVA: 0x00069F54 File Offset: 0x00068154
		// (set) Token: 0x0600068B RID: 1675 RVA: 0x0006A00C File Offset: 0x0006820C
		internal bool TrkWideGeneralEmergencyBlockedInFailsoft_A7934_HiddenStatic
		{
			get
			{
				short num = (short)188763801;
				short num2 = num;
				num = (short)1190874777;
				switch (num2 == num)
				{
				}
				num = (short)1520697345;
				if (num != 0)
				{
				}
				num = (short)1118896128;
				short num3 = num;
				num = (short)677117952;
				if (num != 0)
				{
				}
				return this.trkWideGeneralEmergencyBlockedInFailsoft_A7934.HiddenStatic;
			}
			set
			{
				short num = (short)1690559770;
				short num2 = num;
				num = (short)340911386;
				switch (num2 == num)
				{
				}
				num = (short)1303117825;
				if (num != 0)
				{
				}
				num = (short)1592393728;
				short num3 = num;
				num = (short)2061172736;
				if (num != 0)
				{
				}
				this.trkWideGeneralEmergencyBlockedInFailsoft_A7934.HiddenStatic = value;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x0600068C RID: 1676 RVA: 0x0006A0C0 File Offset: 0x000682C0
		// (set) Token: 0x0600068D RID: 1677 RVA: 0x0006A178 File Offset: 0x00068378
		internal bool TrkWideGeneralEmergencyBlockedInFailsoft_A7934_HiddenDynamic
		{
			get
			{
				short num = (short)566698913;
				short num2 = num;
				num = (short)1873879969;
				switch (num2 == num)
				{
				}
				num = (short)1946484736;
				if (num != 0)
				{
				}
				num = (short)1993998336;
				short num3 = num;
				num = (short)449183745;
				if (num != 0)
				{
				}
				return this.trkWideGeneralEmergencyBlockedInFailsoft_A7934.HiddenDynamic;
			}
			set
			{
				short num = (short)1430061057;
				if (num != 0)
				{
				}
				num = (short)773021081;
				short num2 = num;
				num = (short)1960992153;
				switch (num2 == num)
				{
				}
				num = (short)1954873344;
				short num3 = num;
				num = (short)1934163968;
				if (num != 0)
				{
				}
				this.trkWideGeneralEmergencyBlockedInFailsoft_A7934.HiddenDynamic = value;
			}
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x0600068E RID: 1678 RVA: 0x0006A22C File Offset: 0x0006842C
		public bool TrkWideGeneralEmergencyBlockedInFailsoft_A7934_HasDiffs
		{
			get
			{
				short num = (short)37352031;
				short num2 = num;
				num = (short)1836577375;
				switch (num2 == num)
				{
				}
				num = (short)2115371009;
				if (num != 0)
				{
				}
				num = (short)2076966912;
				short num3 = num;
				num = (short)715456512;
				if (num != 0)
				{
				}
				return this.trkWideGeneralEmergencyBlockedInFailsoft_A7934._HasDiffs;
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x0600068F RID: 1679 RVA: 0x0006A2E4 File Offset: 0x000684E4
		// (set) Token: 0x06000690 RID: 1680 RVA: 0x0006A394 File Offset: 0x00068594
		public int TrkWideGeneralIndividualCallMaxTargetRingTimesec_A8290Value
		{
			get
			{
				short num = (short)1995999891;
				short num2 = num;
				num = (short)1145801363;
				switch (num2 == num)
				{
				}
				num = (short)143392768;
				if (num != 0)
				{
				}
				num = (short)1214316544;
				short num3 = num;
				num = (short)1227292673;
				if (num != 0)
				{
				}
				return this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290.Value;
			}
			set
			{
				short num = (short)1380057089;
				if (num != 0)
				{
				}
				num = (short)987363520;
				short num2 = num;
				num = (short)571209920;
				switch (num2 == num)
				{
				}
				num = (short)1018429440;
				short num3 = num;
				num = (short)1978073088;
				if (num != 0)
				{
				}
				this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290.Value = value;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000691 RID: 1681 RVA: 0x0006A448 File Offset: 0x00068648
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkWideGeneralIndividualCallMaxTargetRingTimesec_A8290
		{
			get
			{
				short num = (short)161780115;
				short num2 = num;
				num = (short)87986579;
				switch (num2 == num)
				{
				}
				num = (short)1462566913;
				if (num != 0)
				{
				}
				num = (short)1462501376;
				short num3 = num;
				num = (short)63700992;
				if (num != 0)
				{
				}
				return this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000692 RID: 1682 RVA: 0x0006A4F8 File Offset: 0x000686F8
		// (set) Token: 0x06000693 RID: 1683 RVA: 0x0006A5AC File Offset: 0x000687AC
		public string TrkWideGeneralIndividualCallMaxTargetRingTimesec_A8290_UIValue
		{
			get
			{
				short num = (short)132026613;
				short num2 = num;
				num = (short)324309237;
				switch (num2 == num)
				{
				}
				num = (short)1117519872;
				if (num != 0)
				{
				}
				num = (short)1681522688;
				short num3 = num;
				num = (short)665059329;
				if (num != 0)
				{
				}
				return this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290.UIValue;
			}
			set
			{
				short num = (short)1749493271;
				short num2 = num;
				num = (short)727524887;
				switch (num2 == num)
				{
				}
				num = (short)1798504449;
				if (num != 0)
				{
				}
				num = (short)1444413440;
				short num3 = num;
				num = (short)320602112;
				if (num != 0)
				{
				}
				this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290.UIValue = value;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000694 RID: 1684 RVA: 0x0006A664 File Offset: 0x00068864
		// (set) Token: 0x06000695 RID: 1685 RVA: 0x0006A718 File Offset: 0x00068918
		internal int TrkWideGeneralIndividualCallMaxTargetRingTimesec_A8290Min
		{
			get
			{
				short num = (short)756632554;
				short num2 = num;
				num = (short)1186941930;
				switch (num2 == num)
				{
				}
				num = (short)1858207744;
				if (num != 0)
				{
				}
				num = (short)358481920;
				short num3 = num;
				num = (short)972816385;
				if (num != 0)
				{
				}
				return this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290.Min;
			}
			set
			{
				short num = (short)452613899;
				short num2 = num;
				num = (short)1299011339;
				switch (num2 == num)
				{
				}
				num = (short)1983447041;
				if (num != 0)
				{
				}
				num = (short)114753536;
				short num3 = num;
				num = (short)1127940096;
				if (num != 0)
				{
				}
				this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290.Min = value;
			}
		}

		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000696 RID: 1686 RVA: 0x0006A7CC File Offset: 0x000689CC
		// (set) Token: 0x06000697 RID: 1687 RVA: 0x0006A880 File Offset: 0x00068A80
		internal int TrkWideGeneralIndividualCallMaxTargetRingTimesec_A8290Max
		{
			get
			{
				short num = (short)755011040;
				short num2 = num;
				num = (short)623021536;
				switch (num2 == num)
				{
				}
				num = (short)1042153472;
				if (num != 0)
				{
				}
				num = (short)1958019072;
				short num3 = num;
				num = (short)413007873;
				if (num != 0)
				{
				}
				return this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290.Max;
			}
			set
			{
				short num = (short)2135228417;
				if (num != 0)
				{
				}
				num = (short)233552829;
				short num2 = num;
				num = (short)1224653757;
				switch (num2 == num)
				{
				}
				num = (short)1209532416;
				short num3 = num;
				num = (short)2129133568;
				if (num != 0)
				{
				}
				this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290.Max = value;
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000698 RID: 1688 RVA: 0x0006A938 File Offset: 0x00068B38
		// (set) Token: 0x06000699 RID: 1689 RVA: 0x0006A9E8 File Offset: 0x00068BE8
		internal int TrkWideGeneralIndividualCallMaxTargetRingTimesec_A8290Step
		{
			get
			{
				short num = (short)1853363636;
				short num2 = num;
				num = (short)798758324;
				switch (num2 == num)
				{
				}
				num = (short)1195704320;
				if (num != 0)
				{
				}
				num = (short)1141112832;
				short num3 = num;
				num = (short)2072379393;
				if (num != 0)
				{
				}
				return this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290.StepSize;
			}
			set
			{
				short num = (short)301962274;
				short num2 = num;
				num = (short)558011426;
				switch (num2 == num)
				{
				}
				num = (short)1013710849;
				if (num != 0)
				{
				}
				num = (short)642973696;
				short num3 = num;
				num = (short)1805582336;
				if (num != 0)
				{
				}
				this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290.StepSize = value;
			}
		}

		// Token: 0x17000326 RID: 806
		// (get) Token: 0x0600069A RID: 1690 RVA: 0x0006AA9C File Offset: 0x00068C9C
		// (set) Token: 0x0600069B RID: 1691 RVA: 0x0006AB50 File Offset: 0x00068D50
		public bool TrkWideGeneralIndividualCallMaxTargetRingTimesec_A8290_Applicable
		{
			get
			{
				short num = (short)1142305723;
				short num2 = num;
				num = (short)1107964859;
				switch (num2 == num)
				{
				}
				num = (short)7995393;
				if (num != 0)
				{
				}
				num = (short)1450246144;
				short num3 = num;
				num = (short)199426048;
				if (num != 0)
				{
				}
				return this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290.Applicable;
			}
			set
			{
				short num = (short)828243969;
				if (num != 0)
				{
				}
				num = (short)1694177328;
				short num2 = num;
				num = (short)138025008;
				switch (num2 == num)
				{
				}
				num = (short)382009344;
				short num3 = num;
				num = (short)1175453696;
				if (num != 0)
				{
				}
				this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290.Applicable = value;
			}
		}

		// Token: 0x17000327 RID: 807
		// (get) Token: 0x0600069C RID: 1692 RVA: 0x0006AC08 File Offset: 0x00068E08
		// (set) Token: 0x0600069D RID: 1693 RVA: 0x0006ACBC File Offset: 0x00068EBC
		public bool TrkWideGeneralIndividualCallMaxTargetRingTimesec_A8290_Valid
		{
			get
			{
				short num = (short)329171425;
				short num2 = num;
				num = (short)1354613217;
				switch (num2 == num)
				{
				}
				num = (short)1667039232;
				if (num != 0)
				{
				}
				num = (short)1347158016;
				short num3 = num;
				num = (short)2139488257;
				if (num != 0)
				{
				}
				return this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290.Valid;
			}
			set
			{
				short num = (short)1948778497;
				if (num != 0)
				{
				}
				num = (short)1469080263;
				short num2 = num;
				num = (short)1998152391;
				switch (num2 == num)
				{
				}
				num = (short)792133632;
				short num3 = num;
				num = (short)1763770368;
				if (num != 0)
				{
				}
				this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290.Valid = value;
			}
		}

		// Token: 0x17000328 RID: 808
		// (get) Token: 0x0600069E RID: 1694 RVA: 0x0006AD74 File Offset: 0x00068F74
		// (set) Token: 0x0600069F RID: 1695 RVA: 0x0006AE28 File Offset: 0x00069028
		public bool TrkWideGeneralIndividualCallMaxTargetRingTimesec_A8290_Visible
		{
			get
			{
				short num = (short)405369187;
				short num2 = num;
				num = (short)1277981027;
				switch (num2 == num)
				{
				}
				num = (short)1515323393;
				if (num != 0)
				{
				}
				num = (short)397672448;
				short num3 = num;
				num = (short)78381056;
				if (num != 0)
				{
				}
				return this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290.Visible;
			}
			set
			{
				short num = (short)1872153353;
				short num2 = num;
				num = (short)1578683145;
				switch (num2 == num)
				{
				}
				num = (short)1012072449;
				if (num != 0)
				{
				}
				num = (short)129826816;
				short num3 = num;
				num = (short)389545984;
				if (num != 0)
				{
				}
				this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290.Visible = value;
			}
		}

		// Token: 0x17000329 RID: 809
		// (get) Token: 0x060006A0 RID: 1696 RVA: 0x0006AEDC File Offset: 0x000690DC
		// (set) Token: 0x060006A1 RID: 1697 RVA: 0x0006AF90 File Offset: 0x00069190
		public bool TrkWideGeneralIndividualCallMaxTargetRingTimesec_A8290_Editable
		{
			get
			{
				short num = (short)49348609;
				if (num != 0)
				{
				}
				num = (short)419065931;
				short num2 = num;
				num = (short)581726283;
				switch (num2 == num)
				{
				}
				num = (short)799473664;
				short num3 = num;
				num = (short)128712704;
				if (num != 0)
				{
				}
				return this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290.Editable;
			}
			set
			{
				short num = (short)2097949551;
				short num2 = num;
				num = (short)1091906415;
				switch (num2 == num)
				{
				}
				num = (short)85721089;
				if (num != 0)
				{
				}
				num = (short)1850671104;
				short num3 = num;
				num = (short)693043200;
				if (num != 0)
				{
				}
				this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290.Editable = value;
			}
		}

		// Token: 0x1700032A RID: 810
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x0006B048 File Offset: 0x00069248
		internal string TrkWideGeneralIndividualCallMaxTargetRingTimesec_A8290_UILabel
		{
			get
			{
				short num = (short)1541355355;
				short num2 = num;
				num = (short)1673475931;
				switch (num2 == num)
				{
				}
				num = (short)1063256064;
				if (num != 0)
				{
				}
				num = (short)1743126528;
				short num3 = num;
				num = (short)349044737;
				if (num != 0)
				{
				}
				return this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290.UIName;
			}
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x060006A3 RID: 1699 RVA: 0x0006B0FC File Offset: 0x000692FC
		// (set) Token: 0x060006A4 RID: 1700 RVA: 0x0006B1B0 File Offset: 0x000693B0
		internal bool TrkWideGeneralIndividualCallMaxTargetRingTimesec_A8290_HiddenStatic
		{
			get
			{
				short num = (short)1249515389;
				short num2 = num;
				num = (short)1014568829;
				switch (num2 == num)
				{
				}
				num = (short)95027200;
				if (num != 0)
				{
				}
				num = (short)530251776;
				short num3 = num;
				num = (short)1976041473;
				if (num != 0)
				{
				}
				return this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290.HiddenStatic;
			}
			set
			{
				short num = (short)757821557;
				short num2 = num;
				num = (short)250048629;
				switch (num2 == num)
				{
				}
				num = (short)851836929;
				if (num != 0)
				{
				}
				num = (short)699400192;
				short num3 = num;
				num = (short)661258240;
				if (num != 0)
				{
				}
				this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290.HiddenStatic = value;
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x060006A5 RID: 1701 RVA: 0x0006B268 File Offset: 0x00069468
		// (set) Token: 0x060006A6 RID: 1702 RVA: 0x0006B31C File Offset: 0x0006951C
		internal bool TrkWideGeneralIndividualCallMaxTargetRingTimesec_A8290_HiddenDynamic
		{
			get
			{
				short num = (short)512049967;
				short num2 = num;
				num = (short)1026769711;
				switch (num2 == num)
				{
				}
				num = (short)911409152;
				if (num != 0)
				{
				}
				num = (short)1328939008;
				short num3 = num;
				num = (short)1984626689;
				if (num != 0)
				{
				}
				return this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290.HiddenDynamic;
			}
			set
			{
				short num = (short)1815674881;
				if (num != 0)
				{
				}
				num = (short)949139122;
				short num2 = num;
				num = (short)1812641458;
				switch (num2 == num)
				{
				}
				num = (short)1996357632;
				short num3 = num;
				num = (short)269811712;
				if (num != 0)
				{
				}
				this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290.HiddenDynamic = value;
			}
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x060006A7 RID: 1703 RVA: 0x0006B3D8 File Offset: 0x000695D8
		public bool TrkWideGeneralIndividualCallMaxTargetRingTimesec_A8290_HasDiffs
		{
			get
			{
				short num = (short)1235502382;
				short num2 = num;
				num = (short)778913070;
				switch (num2 == num)
				{
				}
				num = (short)1810038784;
				if (num != 0)
				{
				}
				num = (short)1002897408;
				short num3 = num;
				num = (short)1947205633;
				if (num != 0)
				{
				}
				return this.trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290._HasDiffs;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x060006A8 RID: 1704 RVA: 0x0006B48C File Offset: 0x0006968C
		// (set) Token: 0x060006A9 RID: 1705 RVA: 0x0006B544 File Offset: 0x00069744
		public int TrkWideGeneralPrivateCallMaxInitialRingsec_A8758Value
		{
			get
			{
				short num = (short)2057212077;
				short num2 = num;
				num = (short)1084854445;
				switch (num2 == num)
				{
				}
				num = (short)967507968;
				if (num != 0)
				{
				}
				num = (short)512163840;
				short num3 = num;
				num = (short)169279489;
				if (num != 0)
				{
				}
				return this.trkWideGeneralPrivateCallMaxInitialRingsec_A8758.Value;
			}
			set
			{
				short num = (short)1040318465;
				if (num != 0)
				{
				}
				num = (short)1286197125;
				short num2 = num;
				num = (short)1481428869;
				switch (num2 == num)
				{
				}
				num = (short)424607744;
				short num3 = num;
				num = (short)78970880;
				if (num != 0)
				{
				}
				this.trkWideGeneralPrivateCallMaxInitialRingsec_A8758.Value = value;
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x0006B5F8 File Offset: 0x000697F8
		public global::AcpBusinessLayer.AcpSimpleRangeField TrkWideGeneralPrivateCallMaxInitialRingsec_A8758
		{
			get
			{
				short num = (short)767446211;
				short num2 = num;
				num = (short)62934211;
				switch (num2 == num)
				{
				}
				num = (short)913309697;
				if (num != 0)
				{
				}
				num = (short)1424883712;
				short num3 = num;
				num = (short)557907968;
				if (num != 0)
				{
				}
				return this.trkWideGeneralPrivateCallMaxInitialRingsec_A8758;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x0006B6A8 File Offset: 0x000698A8
		// (set) Token: 0x060006AC RID: 1708 RVA: 0x0006B75C File Offset: 0x0006995C
		public string TrkWideGeneralPrivateCallMaxInitialRingsec_A8758_UIValue
		{
			get
			{
				short num = (short)1817029084;
				short num2 = num;
				num = (short)1127590364;
				switch (num2 == num)
				{
				}
				num = (short)1117257729;
				if (num != 0)
				{
				}
				num = (short)376176640;
				if (num != 0)
				{
				}
				num = (short)1230766080;
				short num3 = num;
				return this.trkWideGeneralPrivateCallMaxInitialRingsec_A8758.UIValue;
			}
			set
			{
				short num = (short)1661300017;
				short num2 = num;
				num = (short)730623281;
				switch (num2 == num)
				{
				}
				num = (short)423165953;
				if (num != 0)
				{
				}
				num = (short)933036032;
				if (num != 0)
				{
				}
				num = (short)657653760;
				short num3 = num;
				this.trkWideGeneralPrivateCallMaxInitialRingsec_A8758.UIValue = value;
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x0006B810 File Offset: 0x00069A10
		// (set) Token: 0x060006AE RID: 1710 RVA: 0x0006B8C8 File Offset: 0x00069AC8
		internal int TrkWideGeneralPrivateCallMaxInitialRingsec_A8758Min
		{
			get
			{
				short num = (short)885467061;
				short num2 = num;
				num = (short)1510287285;
				switch (num2 == num)
				{
				}
				num = (short)325517312;
				if (num != 0)
				{
				}
				num = (short)529924097;
				if (num != 0)
				{
				}
				num = (short)288555008;
				short num3 = num;
				return this.trkWideGeneralPrivateCallMaxInitialRingsec_A8758.Min;
			}
			set
			{
				short num = (short)275054593;
				if (num != 0)
				{
				}
				num = (short)316115265;
				short num2 = num;
				num = (short)1494583617;
				switch (num2 == num)
				{
				}
				num = (short)1605697536;
				if (num != 0)
				{
				}
				num = (short)555810816;
				short num3 = num;
				this.trkWideGeneralPrivateCallMaxInitialRingsec_A8758.Min = value;
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x0006B97C File Offset: 0x00069B7C
		// (set) Token: 0x060006B0 RID: 1712 RVA: 0x0006BA34 File Offset: 0x00069C34
		internal int TrkWideGeneralPrivateCallMaxInitialRingsec_A8758Max
		{
			get
			{
				short num = (short)668008449;
				if (num != 0)
				{
				}
				num = (short)87288647;
				short num2 = num;
				num = (short)1017703239;
				switch (num2 == num)
				{
				}
				num = (short)2097545216;
				if (num != 0)
				{
				}
				num = (short)1035862016;
				short num3 = num;
				return this.trkWideGeneralPrivateCallMaxInitialRingsec_A8758.Max;
			}
			set
			{
				short num = (short)511257986;
				short num2 = num;
				num = (short)1243753858;
				switch (num2 == num)
				{
				}
				num = (short)2076114945;
				if (num != 0)
				{
				}
				num = (short)1560674304;
				if (num != 0)
				{
				}
				num = (short)162267136;
				short num3 = num;
				this.trkWideGeneralPrivateCallMaxInitialRingsec_A8758.Max = value;
			}
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x0006BAEC File Offset: 0x00069CEC
		// (set) Token: 0x060006B2 RID: 1714 RVA: 0x0006BBA0 File Offset: 0x00069DA0
		internal int TrkWideGeneralPrivateCallMaxInitialRingsec_A8758Step
		{
			get
			{
				short num = (short)971272257;
				short num2 = num;
				num = (short)1621979201;
				switch (num2 == num)
				{
				}
				num = (short)2068971521;
				if (num != 0)
				{
				}
				num = (short)953810944;
				if (num != 0)
				{
				}
				num = (short)1989345280;
				short num3 = num;
				return this.trkWideGeneralPrivateCallMaxInitialRingsec_A8758.StepSize;
			}
			set
			{
				short num = (short)1852219304;
				short num2 = num;
				num = (short)948740008;
				switch (num2 == num)
				{
				}
				num = (short)1218772993;
				if (num != 0)
				{
				}
				num = (short)708771840;
				if (num != 0)
				{
				}
				num = (short)548995072;
				short num3 = num;
				this.trkWideGeneralPrivateCallMaxInitialRingsec_A8758.StepSize = value;
			}
		}

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x060006B3 RID: 1715 RVA: 0x0006BC5C File Offset: 0x00069E5C
		// (set) Token: 0x060006B4 RID: 1716 RVA: 0x0006BD14 File Offset: 0x00069F14
		public bool TrkWideGeneralPrivateCallMaxInitialRingsec_A8758_Applicable
		{
			get
			{
				short num = (short)612019719;
				short num2 = num;
				num = (short)798862855;
				switch (num2 == num)
				{
				}
				num = (short)1480654849;
				if (num != 0)
				{
				}
				num = (short)1630535680;
				if (num != 0)
				{
				}
				num = (short)354156544;
				short num3 = num;
				return this.trkWideGeneralPrivateCallMaxInitialRingsec_A8758.Applicable;
			}
			set
			{
				short num = (short)399835137;
				if (num != 0)
				{
				}
				num = (short)13688600;
				short num2 = num;
				num = (short)2131222296;
				switch (num2 == num)
				{
				}
				num = (short)1810235392;
				if (num != 0)
				{
				}
				num = (short)737542144;
				short num3 = num;
				this.trkWideGeneralPrivateCallMaxInitialRingsec_A8758.Applicable = value;
			}
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x060006B5 RID: 1717 RVA: 0x0006BDD0 File Offset: 0x00069FD0
		// (set) Token: 0x060006B6 RID: 1718 RVA: 0x0006BE84 File Offset: 0x0006A084
		public bool TrkWideGeneralPrivateCallMaxInitialRingsec_A8758_Valid
		{
			get
			{
				short num = (short)880627808;
				short num2 = num;
				num = (short)1694453856;
				switch (num2 == num)
				{
				}
				num = (short)1336410113;
				if (num != 0)
				{
				}
				num = (short)1018822656;
				if (num != 0)
				{
				}
				num = (short)14811136;
				short num3 = num;
				return this.trkWideGeneralPrivateCallMaxInitialRingsec_A8758.Valid;
			}
			set
			{
				short num = (short)838287316;
				short num2 = num;
				num = (short)684474324;
				switch (num2 == num)
				{
				}
				num = (short)1816461313;
				if (num != 0)
				{
				}
				num = (short)1016070144;
				if (num != 0)
				{
				}
				num = (short)334430208;
				short num3 = num;
				this.trkWideGeneralPrivateCallMaxInitialRingsec_A8758.Valid = value;
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x060006B7 RID: 1719 RVA: 0x0006BF3C File Offset: 0x0006A13C
		// (set) Token: 0x060006B8 RID: 1720 RVA: 0x0006BFF0 File Offset: 0x0006A1F0
		public bool TrkWideGeneralPrivateCallMaxInitialRingsec_A8758_Visible
		{
			get
			{
				short num = (short)586153985;
				if (num != 0)
				{
				}
				num = (short)2023997246;
				short num2 = num;
				num = (short)252821310;
				switch (num2 == num)
				{
				}
				num = (short)1423966208;
				if (num != 0)
				{
				}
				num = (short)1211957248;
				short num3 = num;
				return this.trkWideGeneralPrivateCallMaxInitialRingsec_A8758.Visible;
			}
			set
			{
				short num = (short)199751230;
				short num2 = num;
				num = (short)18085438;
				switch (num2 == num)
				{
				}
				num = (short)1724317696;
				if (num != 0)
				{
				}
				num = (short)1855782913;
				if (num != 0)
				{
				}
				num = (short)1049755648;
				short num3 = num;
				this.trkWideGeneralPrivateCallMaxInitialRingsec_A8758.Visible = value;
			}
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x060006B9 RID: 1721 RVA: 0x0006C0A4 File Offset: 0x0006A2A4
		// (set) Token: 0x060006BA RID: 1722 RVA: 0x0006C15C File Offset: 0x0006A35C
		public bool TrkWideGeneralPrivateCallMaxInitialRingsec_A8758_Editable
		{
			get
			{
				short num = (short)1965143042;
				short num2 = num;
				num = (short)1955443714;
				switch (num2 == num)
				{
				}
				num = (short)255197184;
				if (num != 0)
				{
				}
				num = (short)628948993;
				if (num != 0)
				{
				}
				num = (short)334626816;
				short num3 = num;
				return this.trkWideGeneralPrivateCallMaxInitialRingsec_A8758.Editable;
			}
			set
			{
				short num = (short)1204567817;
				short num2 = num;
				num = (short)1512128265;
				switch (num2 == num)
				{
				}
				num = (short)1970733056;
				if (num != 0)
				{
				}
				num = (short)948633601;
				if (num != 0)
				{
				}
				num = (short)560070656;
				short num3 = num;
				this.trkWideGeneralPrivateCallMaxInitialRingsec_A8758.Editable = value;
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x060006BB RID: 1723 RVA: 0x0006C210 File Offset: 0x0006A410
		internal string TrkWideGeneralPrivateCallMaxInitialRingsec_A8758_UILabel
		{
			get
			{
				short num = (short)1060020260;
				short num2 = num;
				num = (short)924885028;
				switch (num2 == num)
				{
				}
				num = (short)875102209;
				if (num != 0)
				{
				}
				num = (short)1173094400;
				if (num != 0)
				{
				}
				num = (short)2103771136;
				short num3 = num;
				return this.trkWideGeneralPrivateCallMaxInitialRingsec_A8758.UIName;
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x060006BC RID: 1724 RVA: 0x0006C2C4 File Offset: 0x0006A4C4
		// (set) Token: 0x060006BD RID: 1725 RVA: 0x0006C378 File Offset: 0x0006A578
		internal bool TrkWideGeneralPrivateCallMaxInitialRingsec_A8758_HiddenStatic
		{
			get
			{
				short num = (short)19787493;
				short num2 = num;
				num = (short)1640558309;
				switch (num2 == num)
				{
				}
				num = (short)1618935808;
				if (num != 0)
				{
				}
				num = (short)1366687745;
				if (num != 0)
				{
				}
				num = (short)478216192;
				short num3 = num;
				return this.trkWideGeneralPrivateCallMaxInitialRingsec_A8758.HiddenStatic;
			}
			set
			{
				short num = (short)2138112001;
				if (num != 0)
				{
				}
				num = (short)1532472191;
				short num2 = num;
				num = (short)804760447;
				switch (num2 == num)
				{
				}
				num = (short)528154624;
				if (num != 0)
				{
				}
				num = (short)1885732864;
				short num3 = num;
				this.trkWideGeneralPrivateCallMaxInitialRingsec_A8758.HiddenStatic = value;
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x0006C430 File Offset: 0x0006A630
		// (set) Token: 0x060006BF RID: 1727 RVA: 0x0006C4E4 File Offset: 0x0006A6E4
		internal bool TrkWideGeneralPrivateCallMaxInitialRingsec_A8758_HiddenDynamic
		{
			get
			{
				short num = (short)1755103143;
				short num2 = num;
				num = (short)2016984999;
				switch (num2 == num)
				{
				}
				num = (short)1868038144;
				if (num != 0)
				{
				}
				num = (short)1224671233;
				if (num != 0)
				{
				}
				num = (short)2031222784;
				short num3 = num;
				return this.trkWideGeneralPrivateCallMaxInitialRingsec_A8758.HiddenDynamic;
			}
			set
			{
				short num = (short)1837085207;
				short num2 = num;
				num = (short)1293922839;
				switch (num2 == num)
				{
				}
				num = (short)648544257;
				if (num != 0)
				{
				}
				num = (short)987758592;
				if (num != 0)
				{
				}
				num = (short)944373760;
				short num3 = num;
				this.trkWideGeneralPrivateCallMaxInitialRingsec_A8758.HiddenDynamic = value;
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x060006C0 RID: 1728 RVA: 0x0006C59C File Offset: 0x0006A79C
		public bool TrkWideGeneralPrivateCallMaxInitialRingsec_A8758_HasDiffs
		{
			get
			{
				short num = (short)1758052276;
				short num2 = num;
				num = (short)1355595700;
				switch (num2 == num)
				{
				}
				num = (short)1052442624;
				if (num != 0)
				{
				}
				num = (short)2359297;
				if (num != 0)
				{
				}
				num = (short)1192689664;
				short num3 = num;
				return this.trkWideGeneralPrivateCallMaxInitialRingsec_A8758._HasDiffs;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x0006C650 File Offset: 0x0006A850
		// (set) Token: 0x060006C2 RID: 1730 RVA: 0x0006C700 File Offset: 0x0006A900
		public bool TrkWideGeneralAFCDisable_A41850Value
		{
			get
			{
				short num = (short)1978368911;
				short num2 = num;
				num = (short)673612687;
				switch (num2 == num)
				{
				}
				num = (short)1057226752;
				if (num != 0)
				{
				}
				num = (short)1162805249;
				if (num != 0)
				{
				}
				num = (short)535363584;
				short num3 = num;
				return this.trkWideGeneralAFCDisable_A41850.Value;
			}
			set
			{
				short num = (short)1754100942;
				short num2 = num;
				num = (short)1386706126;
				switch (num2 == num)
				{
				}
				num = (short)229244929;
				if (num != 0)
				{
				}
				num = (short)1774977024;
				if (num != 0)
				{
				}
				num = (short)2104492032;
				short num3 = num;
				this.trkWideGeneralAFCDisable_A41850.Value = value;
			}
		}

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x060006C3 RID: 1731 RVA: 0x0006C7B8 File Offset: 0x0006A9B8
		public global::AcpBusinessLayer.AcpField<bool> TrkWideGeneralAFCDisable_A41850
		{
			get
			{
				short num = (short)2010445873;
				short num2 = num;
				num = (short)958396465;
				switch (num2 == num)
				{
				}
				num = (short)426311681;
				if (num != 0)
				{
				}
				num = (short)410058752;
				if (num != 0)
				{
				}
				num = (short)569901056;
				short num3 = num;
				return this.trkWideGeneralAFCDisable_A41850;
			}
		}

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x060006C4 RID: 1732 RVA: 0x0006C868 File Offset: 0x0006AA68
		// (set) Token: 0x060006C5 RID: 1733 RVA: 0x0006C91C File Offset: 0x0006AB1C
		public bool TrkWideGeneralAFCDisable_A41850_UIValue
		{
			get
			{
				short num = (short)1368326145;
				if (num != 0)
				{
				}
				num = (short)2039490109;
				short num2 = num;
				num = (short)680666685;
				switch (num2 == num)
				{
				}
				num = (short)907935744;
				if (num != 0)
				{
				}
				num = (short)969277440;
				short num3 = num;
				return this.trkWideGeneralAFCDisable_A41850.Value;
			}
			set
			{
				short num = (short)580246241;
				short num2 = num;
				num = (short)150002401;
				switch (num2 == num)
				{
				}
				num = (short)922288128;
				if (num != 0)
				{
				}
				num = (short)1235812353;
				if (num != 0)
				{
				}
				num = (short)460783616;
				short num3 = num;
				this.trkWideGeneralAFCDisable_A41850.Value = value;
			}
		}

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x060006C6 RID: 1734 RVA: 0x0006C9D4 File Offset: 0x0006ABD4
		// (set) Token: 0x060006C7 RID: 1735 RVA: 0x0006CA88 File Offset: 0x0006AC88
		public bool TrkWideGeneralAFCDisable_A41850_Applicable
		{
			get
			{
				short num = (short)764746269;
				short num2 = num;
				num = (short)2051676701;
				switch (num2 == num)
				{
				}
				num = (short)2127888385;
				if (num != 0)
				{
				}
				num = (short)654311424;
				if (num != 0)
				{
				}
				num = (short)908001280;
				short num3 = num;
				return this.trkWideGeneralAFCDisable_A41850.Applicable;
			}
			set
			{
				short num = (short)601882625;
				if (num != 0)
				{
				}
				num = (short)856274320;
				short num2 = num;
				num = (short)1556592016;
				switch (num2 == num)
				{
				}
				num = (short)1105854464;
				if (num != 0)
				{
				}
				num = (short)1837826048;
				short num3 = num;
				this.trkWideGeneralAFCDisable_A41850.Applicable = value;
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x0006CB3C File Offset: 0x0006AD3C
		// (set) Token: 0x060006C9 RID: 1737 RVA: 0x0006CBF0 File Offset: 0x0006ADF0
		public bool TrkWideGeneralAFCDisable_A41850_Valid
		{
			get
			{
				short num = (short)754375393;
				short num2 = num;
				num = (short)288217825;
				switch (num2 == num)
				{
				}
				num = (short)2041839617;
				if (num != 0)
				{
				}
				num = (short)958660608;
				if (num != 0)
				{
				}
				num = (short)917635072;
				short num3 = num;
				return this.trkWideGeneralAFCDisable_A41850.Valid;
			}
			set
			{
				short num = (short)1444347905;
				if (num != 0)
				{
				}
				num = (short)883837894;
				short num2 = num;
				num = (short)144198598;
				switch (num2 == num)
				{
				}
				num = (short)1035141120;
				if (num != 0)
				{
				}
				num = (short)836370432;
				short num3 = num;
				this.trkWideGeneralAFCDisable_A41850.Valid = value;
			}
		}

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x060006CA RID: 1738 RVA: 0x0006CCA4 File Offset: 0x0006AEA4
		// (set) Token: 0x060006CB RID: 1739 RVA: 0x0006CD5C File Offset: 0x0006AF5C
		public bool TrkWideGeneralAFCDisable_A41850_Visible
		{
			get
			{
				short num = (short)934778218;
				short num2 = num;
				num = (short)1739560298;
				switch (num2 == num)
				{
				}
				num = (short)1254686721;
				if (num != 0)
				{
				}
				num = (short)2069102592;
				if (num != 0)
				{
				}
				num = (short)691077120;
				short num3 = num;
				return this.trkWideGeneralAFCDisable_A41850.Visible;
			}
			set
			{
				short num = (short)1378778213;
				short num2 = num;
				num = (short)969768037;
				switch (num2 == num)
				{
				}
				num = (short)516685824;
				if (num != 0)
				{
				}
				num = (short)1808531457;
				if (num != 0)
				{
				}
				num = (short)650641408;
				short num3 = num;
				this.trkWideGeneralAFCDisable_A41850.Visible = value;
			}
		}

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x0006CE14 File Offset: 0x0006B014
		// (set) Token: 0x060006CD RID: 1741 RVA: 0x0006CECC File Offset: 0x0006B0CC
		public bool TrkWideGeneralAFCDisable_A41850_Editable
		{
			get
			{
				short num = (short)1694173768;
				short num2 = num;
				num = (short)453839432;
				switch (num2 == num)
				{
				}
				num = (short)507510784;
				if (num != 0)
				{
				}
				num = (short)425066497;
				if (num != 0)
				{
				}
				num = (short)214040576;
				short num3 = num;
				return this.trkWideGeneralAFCDisable_A41850.Editable;
			}
			set
			{
				short num = (short)974578692;
				short num2 = num;
				num = (short)1178002436;
				switch (num2 == num)
				{
				}
				num = (short)1152909313;
				if (num != 0)
				{
				}
				num = (short)1570635776;
				if (num != 0)
				{
				}
				num = (short)1394278400;
				short num3 = num;
				this.trkWideGeneralAFCDisable_A41850.Editable = value;
			}
		}

		// Token: 0x17000343 RID: 835
		// (get) Token: 0x060006CE RID: 1742 RVA: 0x0006CF84 File Offset: 0x0006B184
		internal string TrkWideGeneralAFCDisable_A41850_UILabel
		{
			get
			{
				short num = (short)2118274699;
				short num2 = num;
				num = (short)1897614987;
				switch (num2 == num)
				{
				}
				num = (short)1408040960;
				if (num != 0)
				{
				}
				num = (short)953024513;
				if (num != 0)
				{
				}
				num = (short)1206910976;
				short num3 = num;
				return this.trkWideGeneralAFCDisable_A41850.UIName;
			}
		}

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x060006CF RID: 1743 RVA: 0x0006D03C File Offset: 0x0006B23C
		// (set) Token: 0x060006D0 RID: 1744 RVA: 0x0006D0F0 File Offset: 0x0006B2F0
		internal bool TrkWideGeneralAFCDisable_A41850_HiddenStatic
		{
			get
			{
				short num = (short)891486209;
				if (num != 0)
				{
				}
				num = (short)471920127;
				short num2 = num;
				num = (short)419622399;
				switch (num2 == num)
				{
				}
				num = (short)1406664704;
				if (num != 0)
				{
				}
				num = (short)1807220736;
				short num3 = num;
				return this.trkWideGeneralAFCDisable_A41850.HiddenStatic;
			}
			set
			{
				short num = (short)397150945;
				short num2 = num;
				num = (short)292686561;
				switch (num2 == num)
				{
				}
				num = (short)1312817153;
				if (num != 0)
				{
				}
				num = (short)1290076160;
				if (num != 0)
				{
				}
				num = (short)205062144;
				short num3 = num;
				this.trkWideGeneralAFCDisable_A41850.HiddenStatic = value;
			}
		}

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x060006D1 RID: 1745 RVA: 0x0006D1A4 File Offset: 0x0006B3A4
		// (set) Token: 0x060006D2 RID: 1746 RVA: 0x0006D258 File Offset: 0x0006B458
		internal bool TrkWideGeneralAFCDisable_A41850_HiddenDynamic
		{
			get
			{
				short num = (short)13256819;
				short num2 = num;
				num = (short)1179011187;
				switch (num2 == num)
				{
				}
				num = (short)14483457;
				if (num != 0)
				{
				}
				num = (short)1617625088;
				if (num != 0)
				{
				}
				num = (short)88014848;
				short num3 = num;
				return this.trkWideGeneralAFCDisable_A41850.HiddenDynamic;
			}
			set
			{
				short num = (short)1945561774;
				short num2 = num;
				num = (short)1382410926;
				switch (num2 == num)
				{
				}
				num = (short)1116995585;
				if (num != 0)
				{
				}
				num = (short)1151401984;
				if (num != 0)
				{
				}
				num = (short)1891303424;
				short num3 = num;
				this.trkWideGeneralAFCDisable_A41850.HiddenDynamic = value;
			}
		}

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x060006D3 RID: 1747 RVA: 0x0006D310 File Offset: 0x0006B510
		public bool TrkWideGeneralAFCDisable_A41850_HasDiffs
		{
			get
			{
				short num = (short)107893151;
				short num2 = num;
				num = (short)602558879;
				switch (num2 == num)
				{
				}
				num = (short)1314324481;
				if (num != 0)
				{
				}
				num = (short)117309440;
				if (num != 0)
				{
				}
				num = (short)1426718720;
				short num3 = num;
				return this.trkWideGeneralAFCDisable_A41850._HasDiffs;
			}
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x060006D4 RID: 1748 RVA: 0x0006D3C4 File Offset: 0x0006B5C4
		// (set) Token: 0x060006D5 RID: 1749 RVA: 0x0006D478 File Offset: 0x0006B678
		public bool TrkWideGeneralBypassQuickKeyVoiceChannelAccess_42447Value
		{
			get
			{
				short num = (short)1028899615;
				short num2 = num;
				num = (short)966247199;
				switch (num2 == num)
				{
				}
				num = (short)1292042241;
				if (num != 0)
				{
				}
				num = (short)178388992;
				if (num != 0)
				{
				}
				num = (short)1836187648;
				short num3 = num;
				return this.trkWideGeneralBypassQuickKeyVoiceChannelAccess_42447.Value;
			}
			set
			{
				short num = (short)112656385;
				if (num != 0)
				{
				}
				num = (short)1648935771;
				short num2 = num;
				num = (short)2105066331;
				switch (num2 == num)
				{
				}
				num = (short)304349184;
				if (num != 0)
				{
				}
				num = (short)1978859520;
				short num3 = num;
				this.trkWideGeneralBypassQuickKeyVoiceChannelAccess_42447.Value = value;
			}
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x060006D6 RID: 1750 RVA: 0x0006D528 File Offset: 0x0006B728
		public global::AcpBusinessLayer.AcpField<bool> TrkWideGeneralBypassQuickKeyVoiceChannelAccess_42447
		{
			get
			{
				short num = (short)1817832433;
				short num2 = num;
				num = (short)1982393329;
				switch (num2 == num)
				{
				}
				num = (short)1654915073;
				if (num != 0)
				{
				}
				num = (short)1223229440;
				if (num != 0)
				{
				}
				num = (short)46137344;
				short num3 = num;
				return this.trkWideGeneralBypassQuickKeyVoiceChannelAccess_42447;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x060006D7 RID: 1751 RVA: 0x0006D5D8 File Offset: 0x0006B7D8
		// (set) Token: 0x060006D8 RID: 1752 RVA: 0x0006D68C File Offset: 0x0006B88C
		public bool TrkWideGeneralBypassQuickKeyVoiceChannelAccess_42447_UIValue
		{
			get
			{
				short num = (short)1717575658;
				short num2 = num;
				num = (short)2109743082;
				switch (num2 == num)
				{
				}
				num = (short)111017985;
				if (num != 0)
				{
				}
				num = (short)64421888;
				if (num != 0)
				{
				}
				num = (short)130351104;
				short num3 = num;
				return this.trkWideGeneralBypassQuickKeyVoiceChannelAccess_42447.Value;
			}
			set
			{
				short num = (short)905243546;
				short num2 = num;
				num = (short)759294874;
				switch (num2 == num)
				{
				}
				num = (short)1217986561;
				if (num != 0)
				{
				}
				num = (short)1545797632;
				if (num != 0)
				{
				}
				num = (short)2098659328;
				short num3 = num;
				this.trkWideGeneralBypassQuickKeyVoiceChannelAccess_42447.Value = value;
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x060006D9 RID: 1753 RVA: 0x0006D740 File Offset: 0x0006B940
		// (set) Token: 0x060006DA RID: 1754 RVA: 0x0006D7F4 File Offset: 0x0006B9F4
		public bool TrkWideGeneralBypassQuickKeyVoiceChannelAccess_42447_Applicable
		{
			get
			{
				short num = (short)1929738268;
				short num2 = num;
				num = (short)606631964;
				switch (num2 == num)
				{
				}
				num = (short)1391919104;
				if (num != 0)
				{
				}
				num = (short)1968832513;
				if (num != 0)
				{
				}
				num = (short)571539456;
				short num3 = num;
				return this.trkWideGeneralBypassQuickKeyVoiceChannelAccess_42447.Applicable;
			}
			set
			{
				short num = (short)1375347007;
				short num2 = num;
				num = (short)1983193407;
				switch (num2 == num)
				{
				}
				num = (short)1434320896;
				if (num != 0)
				{
				}
				num = (short)199032833;
				if (num != 0)
				{
				}
				num = (short)689897472;
				short num3 = num;
				this.trkWideGeneralBypassQuickKeyVoiceChannelAccess_42447.Applicable = value;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x060006DB RID: 1755 RVA: 0x0006D8AC File Offset: 0x0006BAAC
		// (set) Token: 0x060006DC RID: 1756 RVA: 0x0006D95C File Offset: 0x0006BB5C
		public bool TrkWideGeneralBypassQuickKeyVoiceChannelAccess_42447_Valid
		{
			get
			{
				short num = (short)136363123;
				short num2 = num;
				num = (short)1425914995;
				switch (num2 == num)
				{
				}
				num = (short)509214721;
				if (num != 0)
				{
				}
				num = (short)221839360;
				if (num != 0)
				{
				}
				num = (short)977403904;
				short num3 = num;
				return this.trkWideGeneralBypassQuickKeyVoiceChannelAccess_42447.Valid;
			}
			set
			{
				short num = (short)361365505;
				if (num != 0)
				{
				}
				num = (short)1627718694;
				short num2 = num;
				num = (short)1496450086;
				switch (num2 == num)
				{
				}
				num = (short)327286784;
				if (num != 0)
				{
				}
				num = (short)709361664;
				short num3 = num;
				this.trkWideGeneralBypassQuickKeyVoiceChannelAccess_42447.Valid = value;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x060006DD RID: 1757 RVA: 0x0006DA14 File Offset: 0x0006BC14
		// (set) Token: 0x060006DE RID: 1758 RVA: 0x0006DAC8 File Offset: 0x0006BCC8
		public bool TrkWideGeneralBypassQuickKeyVoiceChannelAccess_42447_Visible
		{
			get
			{
				short num = (short)2060523149;
				short num2 = num;
				num = (short)382408333;
				switch (num2 == num)
				{
				}
				num = (short)205979649;
				if (num != 0)
				{
				}
				num = (short)1531969536;
				if (num != 0)
				{
				}
				num = (short)626786304;
				short num3 = num;
				return this.trkWideGeneralBypassQuickKeyVoiceChannelAccess_42447.Visible;
			}
			set
			{
				short num = (short)995360769;
				if (num != 0)
				{
				}
				num = (short)456676936;
				short num2 = num;
				num = (short)809260616;
				switch (num2 == num)
				{
				}
				num = (short)1361707008;
				if (num != 0)
				{
				}
				num = (short)1738670080;
				short num3 = num;
				this.trkWideGeneralBypassQuickKeyVoiceChannelAccess_42447.Visible = value;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x060006DF RID: 1759 RVA: 0x0006DB7C File Offset: 0x0006BD7C
		// (set) Token: 0x060006E0 RID: 1760 RVA: 0x0006DC34 File Offset: 0x0006BE34
		public bool TrkWideGeneralBypassQuickKeyVoiceChannelAccess_42447_Editable
		{
			get
			{
				short num = (short)347268397;
				short num2 = num;
				num = (short)1011803437;
				switch (num2 == num)
				{
				}
				num = (short)1413349377;
				if (num != 0)
				{
				}
				num = (short)1987444736;
				if (num != 0)
				{
				}
				num = (short)1428029440;
				short num3 = num;
				return this.trkWideGeneralBypassQuickKeyVoiceChannelAccess_42447.Editable;
			}
			set
			{
				short num = (short)2077622273;
				if (num != 0)
				{
				}
				num = (short)2074873821;
				short num2 = num;
				num = (short)205197277;
				switch (num2 == num)
				{
				}
				num = (short)553254912;
				if (num != 0)
				{
				}
				num = (short)2077949952;
				short num3 = num;
				this.trkWideGeneralBypassQuickKeyVoiceChannelAccess_42447.Editable = value;
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x060006E1 RID: 1761 RVA: 0x0006DCE8 File Offset: 0x0006BEE8
		internal string TrkWideGeneralBypassQuickKeyVoiceChannelAccess_42447_UILabel
		{
			get
			{
				short num = (short)1757347841;
				if (num != 0)
				{
				}
				num = (short)1939839660;
				short num2 = num;
				num = (short)167287468;
				switch (num2 == num)
				{
				}
				num = (short)1246363648;
				if (num != 0)
				{
				}
				num = (short)1406926848;
				short num3 = num;
				return this.trkWideGeneralBypassQuickKeyVoiceChannelAccess_42447.UIName;
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x060006E2 RID: 1762 RVA: 0x0006DDA0 File Offset: 0x0006BFA0
		// (set) Token: 0x060006E3 RID: 1763 RVA: 0x0006DE54 File Offset: 0x0006C054
		internal bool TrkWideGeneralBypassQuickKeyVoiceChannelAccess_42447_HiddenStatic
		{
			get
			{
				short num = (short)1187768871;
				short num2 = num;
				num = (short)313715239;
				switch (num2 == num)
				{
				}
				num = (short)1257766913;
				if (num != 0)
				{
				}
				num = (short)1319305216;
				if (num != 0)
				{
				}
				num = (short)686358528;
				short num3 = num;
				return this.trkWideGeneralBypassQuickKeyVoiceChannelAccess_42447.HiddenStatic;
			}
			set
			{
				short num = (short)526379426;
				short num2 = num;
				num = (short)588900770;
				switch (num2 == num)
				{
				}
				num = (short)948371457;
				if (num != 0)
				{
				}
				num = (short)432603136;
				if (num != 0)
				{
				}
				num = (short)9830400;
				short num3 = num;
				this.trkWideGeneralBypassQuickKeyVoiceChannelAccess_42447.HiddenStatic = value;
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x060006E4 RID: 1764 RVA: 0x0006DF08 File Offset: 0x0006C108
		// (set) Token: 0x060006E5 RID: 1765 RVA: 0x0006DFBC File Offset: 0x0006C1BC
		internal bool TrkWideGeneralBypassQuickKeyVoiceChannelAccess_42447_HiddenDynamic
		{
			get
			{
				short num = (short)1497871078;
				short num2 = num;
				num = (short)1038791398;
				switch (num2 == num)
				{
				}
				num = (short)1982791681;
				if (num != 0)
				{
				}
				num = (short)2009399296;
				if (num != 0)
				{
				}
				num = (short)225902592;
				short num3 = num;
				return this.trkWideGeneralBypassQuickKeyVoiceChannelAccess_42447.HiddenDynamic;
			}
			set
			{
				short num = (short)1603047695;
				short num2 = num;
				num = (short)929730831;
				switch (num2 == num)
				{
				}
				num = (short)1455489025;
				if (num != 0)
				{
				}
				num = (short)827654144;
				if (num != 0)
				{
				}
				num = (short)1891958784;
				short num3 = num;
				this.trkWideGeneralBypassQuickKeyVoiceChannelAccess_42447.HiddenDynamic = value;
			}
		}

		// Token: 0x17000351 RID: 849
		// (get) Token: 0x060006E6 RID: 1766 RVA: 0x0006E074 File Offset: 0x0006C274
		public bool TrkWideGeneralBypassQuickKeyVoiceChannelAccess_42447_HasDiffs
		{
			get
			{
				short num = (short)1003734282;
				short num2 = num;
				num = (short)1072350474;
				switch (num2 == num)
				{
				}
				num = (short)735903744;
				if (num != 0)
				{
				}
				num = (short)617021441;
				if (num != 0)
				{
				}
				num = (short)1390608384;
				short num3 = num;
				return this.trkWideGeneralBypassQuickKeyVoiceChannelAccess_42447._HasDiffs;
			}
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x0006E128 File Offset: 0x0006C328
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
					num2 = (short)1005474464;
					short num3 = num2;
					num2 = (short)842551968;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num2 = (short)2098135040;
						if (num2 != 0)
						{
						}
						num2 = (short)60162049;
						if (num2 != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)2014380035;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
				{
					num2 = (short)1139015680;
					short num4 = num2;
					num2 = (short)250937348;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (base.ParentRecset != null)
					{
						num2 = (short)796131329;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					return result;
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1427177472;
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
			num2 = (short)1499660290;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000207 RID: 519
		private global::AcpBusinessLayer.AcpSimpleRangeField trkWideGeneralPhoneAutoDialHoldoffms_A7506;

		// Token: 0x04000208 RID: 520
		private global::AcpBusinessLayer.AcpField<bool> trkWideGeneralEmergencyBlockedInFailsoft_A7934;

		// Token: 0x04000209 RID: 521
		private global::AcpBusinessLayer.AcpSimpleRangeField trkWideGeneralIndividualCallMaxTargetRingTimesec_A8290;

		// Token: 0x0400020A RID: 522
		private global::AcpBusinessLayer.AcpSimpleRangeField trkWideGeneralPrivateCallMaxInitialRingsec_A8758;

		// Token: 0x0400020B RID: 523
		private global::AcpBusinessLayer.AcpField<bool> trkWideGeneralAFCDisable_A41850;

		// Token: 0x0400020C RID: 524
		private global::AcpBusinessLayer.AcpField<bool> trkWideGeneralBypassQuickKeyVoiceChannelAccess_42447;
	}
}
