using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.PhoneWide
{
	// Token: 0x0200043E RID: 1086
	[global::System.Serializable]
	public class DTMFTimingInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060092B6 RID: 37558 RVA: 0x008A2E94 File Offset: 0x008A1094
		public DTMFTimingInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060092B7 RID: 37559 RVA: 0x008A2EB0 File Offset: 0x008A10B0
		protected DTMFTimingInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060092B8 RID: 37560 RVA: 0x008A2EC8 File Offset: 0x008A10C8
		public override void Init()
		{
			int a_ = 16;
			short num = (short)473628672;
			short num2 = num;
			num = (short)1981580939;
			short num3 = num;
			num = (short)1702332043;
			switch (num3 == num)
			{
			}
			num = (short)1088684033;
			if (num != 0)
			{
			}
			num = (short)2079064064;
			if (num != 0)
			{
			}
			this.phnWideDialingkeyofDialing_A21285 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("臐믒믔胖냘뿚룜鯞裠苢觤軦蟨質蛬諮裰鳲鏴돶郸髺釼雾漀搂娄䘆㬈㨊㼌㜎␐", a_), global::CommonResources.AcgResources.ID_DTMFTIMING, 14);
			this.phnWideDialingkeyofDialing_A21285.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.phnWideDialingkeyofDialing_A21285.DataTransferOrder = 13;
			this.phnWideDialingDigitDurationms_A7834 = new global::AcpBusinessLayer.AcpSimpleRangeField(5, this, global::AllFeatures.CodeplugGuid.b("臐믒믔胖냘뿚룜鯞裠苢觤軦蟨質ꧬ蛮雰髲致돶賸觺鳼课栀氂欄樆稈吊䰌㠎⤐‒℔", a_), global::CommonResources.AcgResources.ID_DIGITDURATIONMS, 1, 255, null, null, 0, 25);
			this.phnWideDialingDigitDurationms_A7834.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.phnWideDialingDigitDurationms_A7834.DataTransferOrder = 4;
			this.phnWideDialingDigitDurationms_A7834.ShowHexValue = false;
			this.phnWideDialingInitialDelayms_A7835 = new global::AcpBusinessLayer.AcpSimpleRangeField(60, this, global::AllFeatures.CodeplugGuid.b("臐믒믔胖냘뿚룜鯞裠苢觤軦蟨質ꓬ臮飰蟲鳴零闸뿺飼鏾怀稂栄理嘈䨊㨌㜎∐☒", a_), global::CommonResources.AcgResources.ID_INITIALDELAYMS, 1, 255, null, null, 0, 25);
			this.phnWideDialingInitialDelayms_A7835.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.phnWideDialingInitialDelayms_A7835.DataTransferOrder = 5;
			this.phnWideDialingInitialDelayms_A7835.ShowHexValue = false;
			this.phnWideDialingInterdigitDelayms_A7836 = new global::AcpBusinessLayer.AcpSimpleRangeField(3, this, global::AllFeatures.CodeplugGuid.b("臐믒믔胖냘뿚룜鯞裠苢觤軦蟨質ꓬ臮藰雲蟴鏶郸鳺铼课䔀昂椄昆瀈昊縌倎倐␒ⴔ␖⼘", a_), global::CommonResources.AcgResources.ID_INTERDIGITDELAYMS, 1, 255, null, null, 0, 25);
			this.phnWideDialingInterdigitDelayms_A7836.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.phnWideDialingInterdigitDelayms_A7836.DataTransferOrder = 6;
			this.phnWideDialingInterdigitDelayms_A7836.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("闐蟒飔釖律迚드닞裠跢苤", a_);
			base.Id = 10003;
			base.UIName = global::CommonResources.AcgResources.ID_DTMFTIMING;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060092B9 RID: 37561 RVA: 0x008A30D4 File Offset: 0x008A12D4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 8;
			short num = (short)494141446;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駈ꏊꏌ风룐럒냔鏖냘뫚뇜뛞迠蓢軤苦部蓪诬꯮飰鋲駴黶韸鳺ꋼ뻾㌀㈂㜄㼆㰈", a_)))
					{
						num = (short)1167327235;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_38A;
				case 1:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駈ꏊꏌ风룐럒냔鏖냘뫚뇜뛞迠蓢곤触鷨軪鿬诮飰铲鳴菶뷸黺釼黾砀渂瘄堆䠈㰊㔌㰎✐", a_)))
					{
						num = (short)2162696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_42F;
				case 2:
					num = (short)1907884033;
					if (num != 0)
					{
					}
					goto IL_2D5;
				case 3:
					this.phnWideDialingkeyofDialing_A21285 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("駈ꏊꏌ风룐럒냔鏖냘뫚뇜뛞迠蓢軤苦部蓪诬꯮飰鋲駴黶韸鳺ꋼ뻾㌀㈂㜄㼆㰈", a_), global::CommonResources.AcgResources.ID_DTMFTIMING, 14);
					this.phnWideDialingkeyofDialing_A21285.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.phnWideDialingkeyofDialing_A21285.DataTransferOrder = 13;
					num = (short)534118415;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駈ꏊꏌ风룐럒냔鏖냘뫚뇜뛞迠蓢ꇤ軦軨苪駬꯮蓰臲铴菶郸铺鏼鋾爀専䐄〆ㄈ㠊㤌", a_)))
					{
						num = (short)1255276551;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2D5;
				case 5:
					goto IL_249;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_6E;
					}
					continue;
				case 7:
					this.phnWideDialingDigitDurationms_A7834 = new global::AcpBusinessLayer.AcpSimpleRangeField(5, this, global::AllFeatures.CodeplugGuid.b("駈ꏊꏌ风룐럒냔鏖냘뫚뇜뛞迠蓢ꇤ軦軨苪駬꯮蓰臲铴菶郸铺鏼鋾爀専䐄〆ㄈ㠊㤌", a_), global::CommonResources.AcgResources.ID_DIGITDURATIONMS, null, null, 0, 25);
					this.phnWideDialingDigitDurationms_A7834.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.phnWideDialingDigitDurationms_A7834.DataTransferOrder = 4;
					this.phnWideDialingDigitDurationms_A7834.ShowHexValue = false;
					num = (short)1889927170;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					this.phnWideDialingInterdigitDelayms_A7836 = new global::AcpBusinessLayer.AcpSimpleRangeField(3, this, global::AllFeatures.CodeplugGuid.b("駈ꏊꏌ风룐럒냔鏖냘뫚뇜뛞迠蓢곤触鷨軪鿬诮飰铲鳴菶뷸黺釼黾砀渂瘄堆䠈㰊㔌㰎✐", a_), global::CommonResources.AcgResources.ID_INTERDIGITDELAYMS, null, null, 0, 25);
					this.phnWideDialingInterdigitDelayms_A7836.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.phnWideDialingInterdigitDelayms_A7836.DataTransferOrder = 6;
					this.phnWideDialingInterdigitDelayms_A7836.ShowHexValue = false;
					num = (short)780337163;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_109;
				case 10:
				{
					num = (short)1286078464;
					short num3 = num;
					num = (short)1667170318;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 11:
					goto IL_385;
				case 12:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("駈ꏊꏌ风룐럒냔鏖냘뫚뇜뛞迠蓢곤触胨鿪蓬軮鷰럲郴鯶飸苺郼賾帀䈂㈄㼆㨈㸊", a_)))
					{
						num = (short)108593161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_249;
				case 13:
					num = (short)251592704;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (producerFields != null)
					{
						num = (short)672006157;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_42F;
				case 15:
					goto IL_38A;
				}
				IL_6E:
				if (!global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					break;
				}
				num = (short)599003667;
				short num4 = num;
				num = (short)2025525779;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1211105280;
					if (num != 0)
					{
					}
					num = (short)1329004554;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_109:
				this.phnWideDialingInitialDelayms_A7835 = new global::AcpBusinessLayer.AcpSimpleRangeField(60, this, global::AllFeatures.CodeplugGuid.b("駈ꏊꏌ风룐럒냔鏖냘뫚뇜뛞迠蓢곤触胨鿪蓬軮鷰럲郴鯶飸苺郼賾帀䈂㈄㼆㨈㸊", a_), global::CommonResources.AcgResources.ID_INITIALDELAYMS, null, null, 0, 25);
				this.phnWideDialingInitialDelayms_A7835.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
				this.phnWideDialingInitialDelayms_A7835.DataTransferOrder = 5;
				this.phnWideDialingInitialDelayms_A7835.ShowHexValue = false;
				num = (short)1262354437;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_249:
				num = (short)451280897;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2D5:
				num = (short)127598604;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_38A:
				num = (short)1266548740;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_385:
			IL_42F:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("跈鿊背觎蟒볔뫖냘뗚뫜", a_);
			base.Id = 10003;
			base.UIName = global::CommonResources.AcgResources.ID_DTMFTIMING;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060092BA RID: 37562 RVA: 0x008A3544 File Offset: 0x008A1744
		public override void PopulateReferences()
		{
			short num = (short)611385344;
			short num2 = num;
			num = (short)480607687;
			short num3 = num;
			num = (short)1716157895;
			switch (num3 == num)
			{
			}
			num = (short)762642433;
			if (num != 0)
			{
			}
			num = (short)1760493568;
			if (num != 0)
			{
			}
		}

		// Token: 0x060092BB RID: 37563 RVA: 0x008A35F0 File Offset: 0x008A17F0
		public override void DropReferences()
		{
			short num = (short)1685454848;
			short num2 = num;
			num = (short)2051925952;
			short num3 = num;
			num = (short)2097342400;
			switch (num3 == num)
			{
			}
			num = (short)439484417;
			if (num != 0)
			{
			}
			num = (short)1406271488;
			if (num != 0)
			{
			}
		}

		// Token: 0x060092BC RID: 37564 RVA: 0x008A3698 File Offset: 0x008A1898
		public override void SetConstraints()
		{
			short num = (short)299761664;
			short num2 = num;
			num = (short)868033646;
			short num3 = num;
			num = (short)749544558;
			switch (num3 == num)
			{
			}
			num = (short)1494482945;
			if (num != 0)
			{
			}
			num = (short)1687289856;
			if (num != 0)
			{
			}
		}

		// Token: 0x060092BD RID: 37565 RVA: 0x008A3740 File Offset: 0x008A1940
		public override void SetupDependencies()
		{
			short num = (short)2132541440;
			short num2 = num;
			num = (short)1785533317;
			short num3 = num;
			num = (short)460395397;
			switch (num3 == num)
			{
			}
			num = (short)764674048;
			if (num != 0)
			{
			}
			num = (short)2022113281;
			if (num != 0)
			{
			}
		}

		// Token: 0x170049FF RID: 18943
		// (get) Token: 0x060092BE RID: 37566 RVA: 0x008A37E8 File Offset: 0x008A19E8
		public bool HasDiffs
		{
			get
			{
				short num = (short)1221722112;
				short num2 = num;
				num = (short)473409990;
				short num3 = num;
				num = (short)268413382;
				switch (num3 == num)
				{
				}
				num = (short)1565523969;
				if (num != 0)
				{
				}
				num = (short)497221632;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17004A00 RID: 18944
		// (get) Token: 0x060092BF RID: 37567 RVA: 0x008A3898 File Offset: 0x008A1A98
		// (set) Token: 0x060092C0 RID: 37568 RVA: 0x008A3950 File Offset: 0x008A1B50
		public string PhnWideDialingkeyofDialing_A21285Value
		{
			get
			{
				short num = (short)1939275776;
				short num2 = num;
				num = (short)161349633;
				if (num != 0)
				{
				}
				num = (short)524668145;
				short num3 = num;
				num = (short)683658481;
				switch (num3 == num)
				{
				}
				num = (short)676855808;
				if (num != 0)
				{
				}
				return this.phnWideDialingkeyofDialing_A21285.Value;
			}
			set
			{
				short num = (short)488570880;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)2005991424;
					short num3 = num;
					switch (num2)
					{
					case 0:
						goto IL_14;
					case 1:
						this.phnWideDialingkeyofDialing_A21285.Value = value;
						num = (short)2005991426;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return;
					}
					goto IL_59;
					IL_14:
					switch (0)
					{
					case 0:
					{
						IL_59:
						num = (short)662645280;
						short num4 = num;
						num = (short)1184901664;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14;
						default:
							num = (short)1522728961;
							if (num != 0)
							{
							}
							num = (short)1339359232;
							if (num != 0)
							{
							}
							if (string.IsNullOrEmpty(value.Trim()))
							{
								return;
							}
							num = (short)193855489;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						break;
					}
					}
				}
			}
		}

		// Token: 0x17004A01 RID: 18945
		// (get) Token: 0x060092C1 RID: 37569 RVA: 0x008A3A74 File Offset: 0x008A1C74
		// (set) Token: 0x060092C2 RID: 37570 RVA: 0x008A3B28 File Offset: 0x008A1D28
		public string PhnWideDialingkeyofDialing_A21285_UIValue
		{
			get
			{
				short num = (short)777519104;
				short num2 = num;
				num = (short)1407385601;
				if (num != 0)
				{
				}
				num = (short)948919605;
				short num3 = num;
				num = (short)1612537141;
				switch (num3 == num)
				{
				}
				num = (short)641073152;
				if (num != 0)
				{
				}
				return this.phnWideDialingkeyofDialing_A21285.Value;
			}
			set
			{
				short num = (short)845479936;
				short num2 = num;
				num = (short)1518530948;
				short num3 = num;
				num = (short)710144388;
				switch (num3 == num)
				{
				}
				num = (short)2027945985;
				if (num != 0)
				{
				}
				num = (short)1528102912;
				if (num != 0)
				{
				}
				this.phnWideDialingkeyofDialing_A21285.Value = value;
			}
		}

		// Token: 0x17004A02 RID: 18946
		// (get) Token: 0x060092C3 RID: 37571 RVA: 0x008A3BDC File Offset: 0x008A1DDC
		public global::AcpBusinessLayer.AcpKeyField PhnWideDialingkeyofDialing_A21285
		{
			get
			{
				short num = (short)1413021696;
				short num2 = num;
				num = (short)1574938499;
				short num3 = num;
				num = (short)176465795;
				switch (num3 == num)
				{
				}
				num = (short)1112539136;
				if (num != 0)
				{
				}
				num = (short)37158913;
				if (num != 0)
				{
				}
				return this.phnWideDialingkeyofDialing_A21285;
			}
		}

		// Token: 0x17004A03 RID: 18947
		// (get) Token: 0x060092C4 RID: 37572 RVA: 0x008A3C88 File Offset: 0x008A1E88
		// (set) Token: 0x060092C5 RID: 37573 RVA: 0x008A3D40 File Offset: 0x008A1F40
		public bool PhnWideDialingkeyofDialing_A21285_Applicable
		{
			get
			{
				short num = (short)345112576;
				short num2 = num;
				num = (short)2064214274;
				short num3 = num;
				num = (short)1114532098;
				switch (num3 == num)
				{
				}
				num = (short)1979711489;
				if (num != 0)
				{
				}
				num = (short)1428553728;
				if (num != 0)
				{
				}
				return this.phnWideDialingkeyofDialing_A21285.Applicable;
			}
			set
			{
				short num = (short)1339293696;
				short num2 = num;
				num = (short)1158495708;
				short num3 = num;
				num = (short)690765276;
				switch (num3 == num)
				{
				}
				num = (short)1855848448;
				if (num != 0)
				{
				}
				num = (short)976420865;
				if (num != 0)
				{
				}
				this.phnWideDialingkeyofDialing_A21285.Applicable = value;
			}
		}

		// Token: 0x17004A04 RID: 18948
		// (get) Token: 0x060092C6 RID: 37574 RVA: 0x008A3DF4 File Offset: 0x008A1FF4
		// (set) Token: 0x060092C7 RID: 37575 RVA: 0x008A3EA8 File Offset: 0x008A20A8
		public bool PhnWideDialingkeyofDialing_A21285_Valid
		{
			get
			{
				short num = (short)1004863488;
				short num2 = num;
				num = (short)1433442104;
				short num3 = num;
				num = (short)259626808;
				switch (num3 == num)
				{
				}
				num = (short)1714880513;
				if (num != 0)
				{
				}
				num = (short)485097472;
				if (num != 0)
				{
				}
				return this.phnWideDialingkeyofDialing_A21285.Valid;
			}
			set
			{
				short num = (short)706347008;
				short num2 = num;
				num = (short)1376836674;
				short num3 = num;
				num = (short)1297013826;
				switch (num3 == num)
				{
				}
				num = (short)1024655361;
				if (num != 0)
				{
				}
				num = (short)2055602176;
				if (num != 0)
				{
				}
				this.phnWideDialingkeyofDialing_A21285.Valid = value;
			}
		}

		// Token: 0x17004A05 RID: 18949
		// (get) Token: 0x060092C8 RID: 37576 RVA: 0x008A3F5C File Offset: 0x008A215C
		// (set) Token: 0x060092C9 RID: 37577 RVA: 0x008A400C File Offset: 0x008A220C
		public bool PhnWideDialingkeyofDialing_A21285_Visible
		{
			get
			{
				short num = (short)1539440640;
				short num2 = num;
				num = (short)969525921;
				short num3 = num;
				num = (short)2012924577;
				switch (num3 == num)
				{
				}
				num = (short)1596915713;
				if (num != 0)
				{
				}
				num = (short)1310720000;
				if (num != 0)
				{
				}
				return this.phnWideDialingkeyofDialing_A21285.Visible;
			}
			set
			{
				short num = (short)819724288;
				short num2 = num;
				num = (short)1498029029;
				short num3 = num;
				num = (short)2067930085;
				switch (num3 == num)
				{
				}
				num = (short)1273954304;
				if (num != 0)
				{
				}
				num = (short)1336082433;
				if (num != 0)
				{
				}
				this.phnWideDialingkeyofDialing_A21285.Visible = value;
			}
		}

		// Token: 0x17004A06 RID: 18950
		// (get) Token: 0x060092CA RID: 37578 RVA: 0x008A40C0 File Offset: 0x008A22C0
		// (set) Token: 0x060092CB RID: 37579 RVA: 0x008A4178 File Offset: 0x008A2378
		public bool PhnWideDialingkeyofDialing_A21285_Editable
		{
			get
			{
				short num = (short)47644672;
				short num2 = num;
				num = (short)1504571045;
				short num3 = num;
				num = (short)781774501;
				switch (num3 == num)
				{
				}
				num = (short)323092481;
				if (num != 0)
				{
				}
				num = (short)1848508416;
				if (num != 0)
				{
				}
				return this.phnWideDialingkeyofDialing_A21285.Editable;
			}
			set
			{
				short num = (short)2105182115;
				short num2 = num;
				num = (short)50890659;
				switch (num2 == num)
				{
				}
				num = (short)362348544;
				if (num != 0)
				{
				}
				num = (short)461832192;
				short num3 = num;
				num = (short)1502085121;
				if (num != 0)
				{
				}
				this.phnWideDialingkeyofDialing_A21285.Editable = value;
			}
		}

		// Token: 0x17004A07 RID: 18951
		// (get) Token: 0x060092CC RID: 37580 RVA: 0x008A422C File Offset: 0x008A242C
		internal string PhnWideDialingkeyofDialing_A21285_UILabel
		{
			get
			{
				short num = (short)1241776129;
				if (num != 0)
				{
				}
				num = (short)1257513910;
				short num2 = num;
				num = (short)2124620726;
				switch (num2 == num)
				{
				}
				num = (short)85196800;
				short num3 = num;
				num = (short)1701117952;
				if (num != 0)
				{
				}
				return this.phnWideDialingkeyofDialing_A21285.UIName;
			}
		}

		// Token: 0x17004A08 RID: 18952
		// (get) Token: 0x060092CD RID: 37581 RVA: 0x008A42E0 File Offset: 0x008A24E0
		// (set) Token: 0x060092CE RID: 37582 RVA: 0x008A4398 File Offset: 0x008A2598
		internal bool PhnWideDialingkeyofDialing_A21285_HiddenStatic
		{
			get
			{
				short num = (short)2131916332;
				short num2 = num;
				num = (short)433616428;
				switch (num2 == num)
				{
				}
				num = (short)1161101313;
				if (num != 0)
				{
				}
				num = (short)1214119936;
				short num3 = num;
				num = (short)12386304;
				if (num != 0)
				{
				}
				return this.phnWideDialingkeyofDialing_A21285.HiddenStatic;
			}
			set
			{
				short num = (short)1630371773;
				short num2 = num;
				num = (short)438534077;
				switch (num2 == num)
				{
				}
				num = (short)1620377600;
				if (num != 0)
				{
				}
				num = (short)869269504;
				short num3 = num;
				num = (short)1236402177;
				if (num != 0)
				{
				}
				this.phnWideDialingkeyofDialing_A21285.HiddenStatic = value;
			}
		}

		// Token: 0x17004A09 RID: 18953
		// (get) Token: 0x060092CF RID: 37583 RVA: 0x008A4450 File Offset: 0x008A2650
		// (set) Token: 0x060092D0 RID: 37584 RVA: 0x008A4504 File Offset: 0x008A2704
		internal bool PhnWideDialingkeyofDialing_A21285_HiddenDynamic
		{
			get
			{
				short num = (short)531038209;
				if (num != 0)
				{
				}
				num = (short)1175409457;
				short num2 = num;
				num = (short)134435633;
				switch (num2 == num)
				{
				}
				num = (short)95158272;
				short num3 = num;
				num = (short)2039611392;
				if (num != 0)
				{
				}
				return this.phnWideDialingkeyofDialing_A21285.HiddenDynamic;
			}
			set
			{
				short num = (short)717643295;
				short num2 = num;
				num = (short)2047368735;
				switch (num2 == num)
				{
				}
				num = (short)171966464;
				if (num != 0)
				{
				}
				num = (short)1158348800;
				short num3 = num;
				num = (short)1859452929;
				if (num != 0)
				{
				}
				this.phnWideDialingkeyofDialing_A21285.HiddenDynamic = value;
			}
		}

		// Token: 0x17004A0A RID: 18954
		// (get) Token: 0x060092D1 RID: 37585 RVA: 0x008A45B8 File Offset: 0x008A27B8
		public bool PhnWideDialingkeyofDialing_A21285_HasDiffs
		{
			get
			{
				short num = (short)905778933;
				short num2 = num;
				num = (short)1353193205;
				switch (num2 == num)
				{
				}
				num = (short)1924005888;
				if (num != 0)
				{
				}
				num = (short)1427636224;
				short num3 = num;
				num = (short)1674903553;
				if (num != 0)
				{
				}
				return this.phnWideDialingkeyofDialing_A21285._HasDiffs;
			}
		}

		// Token: 0x17004A0B RID: 18955
		// (get) Token: 0x060092D2 RID: 37586 RVA: 0x008A466C File Offset: 0x008A286C
		// (set) Token: 0x060092D3 RID: 37587 RVA: 0x008A4724 File Offset: 0x008A2924
		public int PhnWideDialingDigitDurationms_A7834Value
		{
			get
			{
				short num = (short)1133315815;
				short num2 = num;
				num = (short)1768097511;
				switch (num2 == num)
				{
				}
				num = (short)1912799232;
				if (num != 0)
				{
				}
				num = (short)185597952;
				short num3 = num;
				num = (short)757399553;
				if (num != 0)
				{
				}
				return this.phnWideDialingDigitDurationms_A7834.Value;
			}
			set
			{
				short num = (short)1757816618;
				short num2 = num;
				num = (short)1124345642;
				switch (num2 == num)
				{
				}
				num = (short)828178432;
				if (num != 0)
				{
				}
				num = (short)548012032;
				short num3 = num;
				num = (short)870645761;
				if (num != 0)
				{
				}
				this.phnWideDialingDigitDurationms_A7834.Value = value;
			}
		}

		// Token: 0x17004A0C RID: 18956
		// (get) Token: 0x060092D4 RID: 37588 RVA: 0x008A47D8 File Offset: 0x008A29D8
		public global::AcpBusinessLayer.AcpSimpleRangeField PhnWideDialingDigitDurationms_A7834
		{
			get
			{
				short num = (short)19331689;
				short num2 = num;
				num = (short)1715403369;
				switch (num2 == num)
				{
				}
				num = (short)880934912;
				if (num != 0)
				{
				}
				num = (short)1041891328;
				short num3 = num;
				num = (short)883294209;
				if (num != 0)
				{
				}
				return this.phnWideDialingDigitDurationms_A7834;
			}
		}

		// Token: 0x17004A0D RID: 18957
		// (get) Token: 0x060092D5 RID: 37589 RVA: 0x008A4888 File Offset: 0x008A2A88
		// (set) Token: 0x060092D6 RID: 37590 RVA: 0x008A493C File Offset: 0x008A2B3C
		public string PhnWideDialingDigitDurationms_A7834_UIValue
		{
			get
			{
				short num = (short)1890138294;
				short num2 = num;
				num = (short)1687566518;
				switch (num2 == num)
				{
				}
				num = (short)2020868097;
				if (num != 0)
				{
				}
				num = (short)1837367296;
				short num3 = num;
				num = (short)73007104;
				if (num != 0)
				{
				}
				return this.phnWideDialingDigitDurationms_A7834.UIValue;
			}
			set
			{
				short num = (short)1119559607;
				short num2 = num;
				num = (short)304422839;
				switch (num2 == num)
				{
				}
				num = (short)1686896640;
				if (num != 0)
				{
				}
				num = (short)1182203904;
				short num3 = num;
				num = (short)1583939585;
				if (num != 0)
				{
				}
				this.phnWideDialingDigitDurationms_A7834.UIValue = value;
			}
		}

		// Token: 0x17004A0E RID: 18958
		// (get) Token: 0x060092D7 RID: 37591 RVA: 0x008A49F0 File Offset: 0x008A2BF0
		// (set) Token: 0x060092D8 RID: 37592 RVA: 0x008A4AA4 File Offset: 0x008A2CA4
		internal int PhnWideDialingDigitDurationms_A7834Min
		{
			get
			{
				short num = (short)1555081626;
				short num2 = num;
				num = (short)868592026;
				switch (num2 == num)
				{
				}
				num = (short)118030337;
				if (num != 0)
				{
				}
				num = (short)8519680;
				short num3 = num;
				num = (short)1227292672;
				if (num != 0)
				{
				}
				return this.phnWideDialingDigitDurationms_A7834.Min;
			}
			set
			{
				short num = (short)167051265;
				if (num != 0)
				{
				}
				num = (short)1155326787;
				short num2 = num;
				num = (short)2086986563;
				switch (num2 == num)
				{
				}
				num = (short)2033975296;
				short num3 = num;
				num = (short)166068224;
				if (num != 0)
				{
				}
				this.phnWideDialingDigitDurationms_A7834.Min = value;
			}
		}

		// Token: 0x17004A0F RID: 18959
		// (get) Token: 0x060092D9 RID: 37593 RVA: 0x008A4B58 File Offset: 0x008A2D58
		// (set) Token: 0x060092DA RID: 37594 RVA: 0x008A4C0C File Offset: 0x008A2E0C
		internal int PhnWideDialingDigitDurationms_A7834Max
		{
			get
			{
				short num = (short)1700075630;
				short num2 = num;
				num = (short)1641748590;
				switch (num2 == num)
				{
				}
				num = (short)589037568;
				if (num != 0)
				{
				}
				num = (short)1813446656;
				short num3 = num;
				num = (short)184680449;
				if (num != 0)
				{
				}
				return this.phnWideDialingDigitDurationms_A7834.Max;
			}
			set
			{
				short num = (short)345360036;
				short num2 = num;
				num = (short)325895844;
				switch (num2 == num)
				{
				}
				num = (short)1325989889;
				if (num != 0)
				{
				}
				num = (short)749731840;
				short num3 = num;
				num = (short)592969728;
				if (num != 0)
				{
				}
				this.phnWideDialingDigitDurationms_A7834.Max = value;
			}
		}

		// Token: 0x17004A10 RID: 18960
		// (get) Token: 0x060092DB RID: 37595 RVA: 0x008A4CC0 File Offset: 0x008A2EC0
		// (set) Token: 0x060092DC RID: 37596 RVA: 0x008A4D78 File Offset: 0x008A2F78
		internal int PhnWideDialingDigitDurationms_A7834Step
		{
			get
			{
				short num = (short)984914344;
				short num2 = num;
				num = (short)1728944552;
				switch (num2 == num)
				{
				}
				num = (short)1080229889;
				if (num != 0)
				{
				}
				num = (short)1775960064;
				short num3 = num;
				num = (short)2136866816;
				if (num != 0)
				{
				}
				return this.phnWideDialingDigitDurationms_A7834.StepSize;
			}
			set
			{
				short num = (short)162332673;
				if (num != 0)
				{
				}
				num = (short)448518557;
				short num2 = num;
				num = (short)21682589;
				switch (num2 == num)
				{
				}
				num = (short)2030501888;
				short num3 = num;
				num = (short)917700608;
				if (num != 0)
				{
				}
				this.phnWideDialingDigitDurationms_A7834.StepSize = value;
			}
		}

		// Token: 0x17004A11 RID: 18961
		// (get) Token: 0x060092DD RID: 37597 RVA: 0x008A4E2C File Offset: 0x008A302C
		// (set) Token: 0x060092DE RID: 37598 RVA: 0x008A4EE4 File Offset: 0x008A30E4
		public bool PhnWideDialingDigitDurationms_A7834_Applicable
		{
			get
			{
				short num = (short)1722059086;
				short num2 = num;
				num = (short)1631226190;
				switch (num2 == num)
				{
				}
				num = (short)1447362560;
				if (num != 0)
				{
				}
				num = (short)332595200;
				short num3 = num;
				num = (short)1256783873;
				if (num != 0)
				{
				}
				return this.phnWideDialingDigitDurationms_A7834.Applicable;
			}
			set
			{
				short num = (short)861587981;
				short num2 = num;
				num = (short)1988872717;
				switch (num2 == num)
				{
				}
				num = (short)1723990017;
				if (num != 0)
				{
				}
				num = (short)1241645056;
				short num3 = num;
				num = (short)531496960;
				if (num != 0)
				{
				}
				this.phnWideDialingDigitDurationms_A7834.Applicable = value;
			}
		}

		// Token: 0x17004A12 RID: 18962
		// (get) Token: 0x060092DF RID: 37599 RVA: 0x008A4F9C File Offset: 0x008A319C
		// (set) Token: 0x060092E0 RID: 37600 RVA: 0x008A5054 File Offset: 0x008A3254
		public bool PhnWideDialingDigitDurationms_A7834_Valid
		{
			get
			{
				short num = (short)1466292696;
				short num2 = num;
				num = (short)993253848;
				switch (num2 == num)
				{
				}
				num = (short)63242241;
				if (num != 0)
				{
				}
				num = (short)729612288;
				short num3 = num;
				num = (short)1549205504;
				if (num != 0)
				{
				}
				return this.phnWideDialingDigitDurationms_A7834.Valid;
			}
			set
			{
				short num = (short)1352376218;
				short num2 = num;
				num = (short)101818266;
				switch (num2 == num)
				{
				}
				num = (short)355074049;
				if (num != 0)
				{
				}
				num = (short)53936128;
				short num3 = num;
				num = (short)1425670144;
				if (num != 0)
				{
				}
				this.phnWideDialingDigitDurationms_A7834.Valid = value;
			}
		}

		// Token: 0x17004A13 RID: 18963
		// (get) Token: 0x060092E1 RID: 37601 RVA: 0x008A510C File Offset: 0x008A330C
		// (set) Token: 0x060092E2 RID: 37602 RVA: 0x008A51C4 File Offset: 0x008A33C4
		public bool PhnWideDialingDigitDurationms_A7834_Visible
		{
			get
			{
				short num = (short)97676863;
				short num2 = num;
				num = (short)142503487;
				switch (num2 == num)
				{
				}
				num = (short)559284225;
				if (num != 0)
				{
				}
				num = (short)1710948352;
				short num3 = num;
				num = (short)271187968;
				if (num != 0)
				{
				}
				return this.phnWideDialingDigitDurationms_A7834.Visible;
			}
			set
			{
				short num = (short)1222435610;
				short num2 = num;
				num = (short)825680666;
				switch (num2 == num)
				{
				}
				num = (short)291176449;
				if (num != 0)
				{
				}
				num = (short)1692991488;
				short num3 = num;
				num = (short)1445593088;
				if (num != 0)
				{
				}
				this.phnWideDialingDigitDurationms_A7834.Visible = value;
			}
		}

		// Token: 0x17004A14 RID: 18964
		// (get) Token: 0x060092E3 RID: 37603 RVA: 0x008A527C File Offset: 0x008A347C
		// (set) Token: 0x060092E4 RID: 37604 RVA: 0x008A5330 File Offset: 0x008A3530
		public bool PhnWideDialingDigitDurationms_A7834_Editable
		{
			get
			{
				short num = (short)1392397767;
				short num2 = num;
				num = (short)261836231;
				switch (num2 == num)
				{
				}
				num = (short)98238464;
				if (num != 0)
				{
				}
				num = (short)2012151808;
				short num3 = num;
				num = (short)1519714305;
				if (num != 0)
				{
				}
				return this.phnWideDialingDigitDurationms_A7834.Editable;
			}
			set
			{
				short num = (short)1583935791;
				short num2 = num;
				num = (short)914223407;
				switch (num2 == num)
				{
				}
				num = (short)1454047233;
				if (num != 0)
				{
				}
				num = (short)993918976;
				short num3 = num;
				num = (short)1695154176;
				if (num != 0)
				{
				}
				this.phnWideDialingDigitDurationms_A7834.Editable = value;
			}
		}

		// Token: 0x17004A15 RID: 18965
		// (get) Token: 0x060092E5 RID: 37605 RVA: 0x008A53E4 File Offset: 0x008A35E4
		internal string PhnWideDialingDigitDurationms_A7834_UILabel
		{
			get
			{
				short num = (short)34311866;
				short num2 = num;
				num = (short)207720122;
				switch (num2 == num)
				{
				}
				num = (short)1732771840;
				if (num != 0)
				{
				}
				num = (short)1744699392;
				short num3 = num;
				num = (short)808255489;
				if (num != 0)
				{
				}
				return this.phnWideDialingDigitDurationms_A7834.UIName;
			}
		}

		// Token: 0x17004A16 RID: 18966
		// (get) Token: 0x060092E6 RID: 37606 RVA: 0x008A5498 File Offset: 0x008A3698
		// (set) Token: 0x060092E7 RID: 37607 RVA: 0x008A554C File Offset: 0x008A374C
		internal bool PhnWideDialingDigitDurationms_A7834_HiddenStatic
		{
			get
			{
				short num = (short)276362025;
				short num2 = num;
				num = (short)1171190569;
				switch (num2 == num)
				{
				}
				num = (short)38797313;
				if (num != 0)
				{
				}
				num = (short)1214251008;
				short num3 = num;
				num = (short)324075520;
				if (num != 0)
				{
				}
				return this.phnWideDialingDigitDurationms_A7834.HiddenStatic;
			}
			set
			{
				short num = (short)29203359;
				short num2 = num;
				num = (short)1799068575;
				switch (num2 == num)
				{
				}
				num = (short)2120613889;
				if (num != 0)
				{
				}
				num = (short)1122107392;
				short num3 = num;
				num = (short)604438528;
				if (num != 0)
				{
				}
				this.phnWideDialingDigitDurationms_A7834.HiddenStatic = value;
			}
		}

		// Token: 0x17004A17 RID: 18967
		// (get) Token: 0x060092E8 RID: 37608 RVA: 0x008A5600 File Offset: 0x008A3800
		// (set) Token: 0x060092E9 RID: 37609 RVA: 0x008A56B4 File Offset: 0x008A38B4
		internal bool PhnWideDialingDigitDurationms_A7834_HiddenDynamic
		{
			get
			{
				short num = (short)1626063390;
				short num2 = num;
				num = (short)1956430366;
				switch (num2 == num)
				{
				}
				num = (short)1254293505;
				if (num != 0)
				{
				}
				num = (short)283049984;
				short num3 = num;
				num = (short)1277362176;
				if (num != 0)
				{
				}
				return this.phnWideDialingDigitDurationms_A7834.HiddenDynamic;
			}
			set
			{
				short num = (short)128450561;
				if (num != 0)
				{
				}
				num = (short)248411980;
				short num2 = num;
				num = (short)204371788;
				switch (num2 == num)
				{
				}
				num = (short)848232448;
				short num3 = num;
				num = (short)24182784;
				if (num != 0)
				{
				}
				this.phnWideDialingDigitDurationms_A7834.HiddenDynamic = value;
			}
		}

		// Token: 0x17004A18 RID: 18968
		// (get) Token: 0x060092EA RID: 37610 RVA: 0x008A576C File Offset: 0x008A396C
		public bool PhnWideDialingDigitDurationms_A7834_HasDiffs
		{
			get
			{
				short num = (short)263819150;
				short num2 = num;
				num = (short)1032753038;
				switch (num2 == num)
				{
				}
				num = (short)269680641;
				if (num != 0)
				{
				}
				num = (short)1964376064;
				short num3 = num;
				num = (short)896139264;
				if (num != 0)
				{
				}
				return this.phnWideDialingDigitDurationms_A7834._HasDiffs;
			}
		}

		// Token: 0x17004A19 RID: 18969
		// (get) Token: 0x060092EB RID: 37611 RVA: 0x008A5820 File Offset: 0x008A3A20
		// (set) Token: 0x060092EC RID: 37612 RVA: 0x008A58D8 File Offset: 0x008A3AD8
		public int PhnWideDialingInitialDelayms_A7835Value
		{
			get
			{
				short num = (short)472169167;
				short num2 = num;
				num = (short)1464974031;
				switch (num2 == num)
				{
				}
				num = (short)1504903169;
				if (num != 0)
				{
				}
				num = (short)915144704;
				short num3 = num;
				num = (short)1656881152;
				if (num != 0)
				{
				}
				return this.phnWideDialingInitialDelayms_A7835.Value;
			}
			set
			{
				short num = (short)1799159809;
				if (num != 0)
				{
				}
				num = (short)1384768789;
				short num2 = num;
				num = (short)1624499477;
				switch (num2 == num)
				{
				}
				num = (short)327417856;
				short num3 = num;
				num = (short)275513344;
				if (num != 0)
				{
				}
				this.phnWideDialingInitialDelayms_A7835.Value = value;
			}
		}

		// Token: 0x17004A1A RID: 18970
		// (get) Token: 0x060092ED RID: 37613 RVA: 0x008A598C File Offset: 0x008A3B8C
		public global::AcpBusinessLayer.AcpSimpleRangeField PhnWideDialingInitialDelayms_A7835
		{
			get
			{
				short num = (short)961807721;
				short num2 = num;
				num = (short)1229981033;
				switch (num2 == num)
				{
				}
				num = (short)2098987008;
				if (num != 0)
				{
				}
				num = (short)1739915264;
				short num3 = num;
				num = (short)1302331393;
				if (num != 0)
				{
				}
				return this.phnWideDialingInitialDelayms_A7835;
			}
		}

		// Token: 0x17004A1B RID: 18971
		// (get) Token: 0x060092EE RID: 37614 RVA: 0x008A5A3C File Offset: 0x008A3C3C
		// (set) Token: 0x060092EF RID: 37615 RVA: 0x008A5AF0 File Offset: 0x008A3CF0
		public string PhnWideDialingInitialDelayms_A7835_UIValue
		{
			get
			{
				short num = (short)120872518;
				short num2 = num;
				num = (short)1229610566;
				switch (num2 == num)
				{
				}
				num = (short)422641665;
				if (num != 0)
				{
				}
				num = (short)2061828096;
				short num3 = num;
				num = (short)923336704;
				if (num != 0)
				{
				}
				return this.phnWideDialingInitialDelayms_A7835.UIValue;
			}
			set
			{
				short num = (short)404099166;
				short num2 = num;
				num = (short)378343518;
				switch (num2 == num)
				{
				}
				num = (short)845217793;
				if (num != 0)
				{
				}
				num = (short)2084896768;
				short num3 = num;
				num = (short)522059776;
				if (num != 0)
				{
				}
				this.phnWideDialingInitialDelayms_A7835.UIValue = value;
			}
		}

		// Token: 0x17004A1C RID: 18972
		// (get) Token: 0x060092F0 RID: 37616 RVA: 0x008A5BA8 File Offset: 0x008A3DA8
		// (set) Token: 0x060092F1 RID: 37617 RVA: 0x008A5C5C File Offset: 0x008A3E5C
		internal int PhnWideDialingInitialDelayms_A7835Min
		{
			get
			{
				short num = (short)451187286;
				short num2 = num;
				num = (short)1757123158;
				switch (num2 == num)
				{
				}
				num = (short)1946025985;
				if (num != 0)
				{
				}
				num = (short)156762112;
				short num3 = num;
				num = (short)1663827968;
				if (num != 0)
				{
				}
				return this.phnWideDialingInitialDelayms_A7835.Min;
			}
			set
			{
				short num = (short)1260333717;
				short num2 = num;
				num = (short)1894918805;
				switch (num2 == num)
				{
				}
				num = (short)680460289;
				if (num != 0)
				{
				}
				num = (short)1836318720;
				short num3 = num;
				num = (short)249561088;
				if (num != 0)
				{
				}
				this.phnWideDialingInitialDelayms_A7835.Min = value;
			}
		}

		// Token: 0x17004A1D RID: 18973
		// (get) Token: 0x060092F2 RID: 37618 RVA: 0x008A5D10 File Offset: 0x008A3F10
		// (set) Token: 0x060092F3 RID: 37619 RVA: 0x008A5DC4 File Offset: 0x008A3FC4
		internal int PhnWideDialingInitialDelayms_A7835Max
		{
			get
			{
				short num = (short)1876003232;
				short num2 = num;
				num = (short)780765600;
				switch (num2 == num)
				{
				}
				num = (short)786956289;
				if (num != 0)
				{
				}
				num = (short)487194624;
				short num3 = num;
				num = (short)364576768;
				if (num != 0)
				{
				}
				return this.phnWideDialingInitialDelayms_A7835.Max;
			}
			set
			{
				short num = (short)2059341177;
				short num2 = num;
				num = (short)1534201209;
				switch (num2 == num)
				{
				}
				num = (short)772210688;
				if (num != 0)
				{
				}
				num = (short)2002518016;
				short num3 = num;
				num = (short)1168244737;
				if (num != 0)
				{
				}
				this.phnWideDialingInitialDelayms_A7835.Max = value;
			}
		}

		// Token: 0x17004A1E RID: 18974
		// (get) Token: 0x060092F4 RID: 37620 RVA: 0x008A5E78 File Offset: 0x008A4078
		// (set) Token: 0x060092F5 RID: 37621 RVA: 0x008A5F2C File Offset: 0x008A412C
		internal int PhnWideDialingInitialDelayms_A7835Step
		{
			get
			{
				short num = (short)518261917;
				short num2 = num;
				num = (short)2028211357;
				switch (num2 == num)
				{
				}
				num = (short)965541888;
				if (num != 0)
				{
				}
				num = (short)1159200768;
				short num3 = num;
				num = (short)1487667201;
				if (num != 0)
				{
				}
				return this.phnWideDialingInitialDelayms_A7835.StepSize;
			}
			set
			{
				short num = (short)1733722779;
				short num2 = num;
				num = (short)233407131;
				switch (num2 == num)
				{
				}
				num = (short)1275068417;
				if (num != 0)
				{
				}
				num = (short)775946240;
				short num3 = num;
				num = (short)1891696640;
				if (num != 0)
				{
				}
				this.phnWideDialingInitialDelayms_A7835.StepSize = value;
			}
		}

		// Token: 0x17004A1F RID: 18975
		// (get) Token: 0x060092F6 RID: 37622 RVA: 0x008A5FE0 File Offset: 0x008A41E0
		// (set) Token: 0x060092F7 RID: 37623 RVA: 0x008A6098 File Offset: 0x008A4298
		public bool PhnWideDialingInitialDelayms_A7835_Applicable
		{
			get
			{
				short num = (short)1438634632;
				short num2 = num;
				num = (short)1182978696;
				switch (num2 == num)
				{
				}
				num = (short)1596325889;
				if (num != 0)
				{
				}
				num = (short)162922496;
				short num3 = num;
				num = (short)462094336;
				if (num != 0)
				{
				}
				return this.phnWideDialingInitialDelayms_A7835.Applicable;
			}
			set
			{
				short num = (short)547618817;
				if (num != 0)
				{
				}
				num = (short)1687089513;
				short num2 = num;
				num = (short)685896041;
				switch (num2 == num)
				{
				}
				num = (short)2030174208;
				short num3 = num;
				num = (short)1400832000;
				if (num != 0)
				{
				}
				this.phnWideDialingInitialDelayms_A7835.Applicable = value;
			}
		}

		// Token: 0x17004A20 RID: 18976
		// (get) Token: 0x060092F8 RID: 37624 RVA: 0x008A6150 File Offset: 0x008A4350
		// (set) Token: 0x060092F9 RID: 37625 RVA: 0x008A6204 File Offset: 0x008A4404
		public bool PhnWideDialingInitialDelayms_A7835_Valid
		{
			get
			{
				short num = (short)1740701697;
				if (num != 0)
				{
				}
				num = (short)173620606;
				short num2 = num;
				num = (short)281099646;
				switch (num2 == num)
				{
				}
				num = (short)1422786560;
				short num3 = num;
				num = (short)487587840;
				if (num != 0)
				{
				}
				return this.phnWideDialingInitialDelayms_A7835.Valid;
			}
			set
			{
				short num = (short)467027946;
				short num2 = num;
				num = (short)1509640170;
				switch (num2 == num)
				{
				}
				num = (short)701562881;
				if (num != 0)
				{
				}
				num = (short)203882496;
				short num3 = num;
				num = (short)2142633984;
				if (num != 0)
				{
				}
				this.phnWideDialingInitialDelayms_A7835.Valid = value;
			}
		}

		// Token: 0x17004A21 RID: 18977
		// (get) Token: 0x060092FA RID: 37626 RVA: 0x008A62B8 File Offset: 0x008A44B8
		// (set) Token: 0x060092FB RID: 37627 RVA: 0x008A6368 File Offset: 0x008A4568
		public bool PhnWideDialingInitialDelayms_A7835_Visible
		{
			get
			{
				short num = (short)1218561087;
				short num2 = num;
				num = (short)698401855;
				switch (num2 == num)
				{
				}
				num = (short)491061248;
				if (num != 0)
				{
				}
				num = (short)1732771840;
				short num3 = num;
				num = (short)1425604609;
				if (num != 0)
				{
				}
				return this.phnWideDialingInitialDelayms_A7835.Visible;
			}
			set
			{
				short num = (short)1251233939;
				short num2 = num;
				num = (short)1114263699;
				switch (num2 == num)
				{
				}
				num = (short)1980170240;
				if (num != 0)
				{
				}
				num = (short)226492416;
				short num3 = num;
				num = (short)440729601;
				if (num != 0)
				{
				}
				this.phnWideDialingInitialDelayms_A7835.Visible = value;
			}
		}

		// Token: 0x17004A22 RID: 18978
		// (get) Token: 0x060092FC RID: 37628 RVA: 0x008A641C File Offset: 0x008A461C
		// (set) Token: 0x060092FD RID: 37629 RVA: 0x008A64D4 File Offset: 0x008A46D4
		public bool PhnWideDialingInitialDelayms_A7835_Editable
		{
			get
			{
				short num = (short)275740471;
				short num2 = num;
				num = (short)687699767;
				switch (num2 == num)
				{
				}
				num = (short)2118189057;
				if (num != 0)
				{
				}
				num = (short)1121976320;
				short num3 = num;
				num = (short)751697920;
				if (num != 0)
				{
				}
				return this.phnWideDialingInitialDelayms_A7835.Editable;
			}
			set
			{
				short num = (short)1647116289;
				if (num != 0)
				{
				}
				num = (short)1620049920;
				short num2 = num;
				num = (short)353303952;
				short num3 = num;
				num = (short)926547344;
				switch (num3 == num)
				{
				}
				num = (short)1875378176;
				if (num != 0)
				{
				}
				this.phnWideDialingInitialDelayms_A7835.Editable = value;
			}
		}

		// Token: 0x17004A23 RID: 18979
		// (get) Token: 0x060092FE RID: 37630 RVA: 0x008A658C File Offset: 0x008A478C
		internal string PhnWideDialingInitialDelayms_A7835_UILabel
		{
			get
			{
				short num = (short)788201473;
				if (num != 0)
				{
				}
				num = (short)1846673408;
				short num2 = num;
				num = (short)1386152612;
				short num3 = num;
				num = (short)28377764;
				switch (num3 == num)
				{
				}
				num = (short)1751318528;
				if (num != 0)
				{
				}
				return this.phnWideDialingInitialDelayms_A7835.UIName;
			}
		}

		// Token: 0x17004A24 RID: 18980
		// (get) Token: 0x060092FF RID: 37631 RVA: 0x008A6644 File Offset: 0x008A4844
		// (set) Token: 0x06009300 RID: 37632 RVA: 0x008A66F8 File Offset: 0x008A48F8
		internal bool PhnWideDialingInitialDelayms_A7835_HiddenStatic
		{
			get
			{
				short num = (short)751255890;
				short num2 = num;
				num = (short)793723218;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1782775808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1430454273;
				if (num != 0)
				{
				}
				num = (short)719585280;
				if (num != 0)
				{
				}
				return this.phnWideDialingInitialDelayms_A7835.HiddenStatic;
			}
			set
			{
				short num = (short)1014387159;
				short num2 = num;
				num = (short)1292653015;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1055588352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1741160449;
				if (num != 0)
				{
				}
				num = (short)82968576;
				if (num != 0)
				{
				}
				this.phnWideDialingInitialDelayms_A7835.HiddenStatic = value;
			}
		}

		// Token: 0x17004A25 RID: 18981
		// (get) Token: 0x06009301 RID: 37633 RVA: 0x008A67AC File Offset: 0x008A49AC
		// (set) Token: 0x06009302 RID: 37634 RVA: 0x008A6860 File Offset: 0x008A4A60
		internal bool PhnWideDialingInitialDelayms_A7835_HiddenDynamic
		{
			get
			{
				short num = (short)2070811852;
				short num2 = num;
				num = (short)577705164;
				switch (num2 == num)
				{
				default:
				{
					num = (short)651755520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1673396224;
				if (num != 0)
				{
				}
				num = (short)719388673;
				if (num != 0)
				{
				}
				return this.phnWideDialingInitialDelayms_A7835.HiddenDynamic;
			}
			set
			{
				short num = (short)823650312;
				short num2 = num;
				num = (short)1274996744;
				switch (num2 == num)
				{
				default:
				{
					num = (short)651362304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)840892417;
				if (num != 0)
				{
				}
				num = (short)1785135104;
				if (num != 0)
				{
				}
				this.phnWideDialingInitialDelayms_A7835.HiddenDynamic = value;
			}
		}

		// Token: 0x17004A26 RID: 18982
		// (get) Token: 0x06009303 RID: 37635 RVA: 0x008A6918 File Offset: 0x008A4B18
		public bool PhnWideDialingInitialDelayms_A7835_HasDiffs
		{
			get
			{
				short num = (short)616871287;
				short num2 = num;
				num = (short)234403191;
				switch (num2 == num)
				{
				default:
				{
					num = (short)383713280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)834666497;
				if (num != 0)
				{
				}
				num = (short)1649999872;
				if (num != 0)
				{
				}
				return this.phnWideDialingInitialDelayms_A7835._HasDiffs;
			}
		}

		// Token: 0x17004A27 RID: 18983
		// (get) Token: 0x06009304 RID: 37636 RVA: 0x008A69CC File Offset: 0x008A4BCC
		// (set) Token: 0x06009305 RID: 37637 RVA: 0x008A6A80 File Offset: 0x008A4C80
		public int PhnWideDialingInterdigitDelayms_A7836Value
		{
			get
			{
				short num = (short)1176015633;
				short num2 = num;
				num = (short)340759313;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1464729600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1083637761;
				if (num != 0)
				{
				}
				num = (short)963903488;
				if (num != 0)
				{
				}
				return this.phnWideDialingInterdigitDelayms_A7836.Value;
			}
			set
			{
				short num = (short)544289270;
				short num2 = num;
				num = (short)1830957558;
				switch (num2 == num)
				{
				default:
				{
					num = (short)621346816;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)332922880;
				if (num != 0)
				{
				}
				num = (short)138149889;
				if (num != 0)
				{
				}
				this.phnWideDialingInterdigitDelayms_A7836.Value = value;
			}
		}

		// Token: 0x17004A28 RID: 18984
		// (get) Token: 0x06009306 RID: 37638 RVA: 0x008A6B34 File Offset: 0x008A4D34
		public global::AcpBusinessLayer.AcpSimpleRangeField PhnWideDialingInterdigitDelayms_A7836
		{
			get
			{
				short num = (short)963273217;
				short num2 = num;
				num = (short)1660510721;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1909784576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)672595968;
				if (num != 0)
				{
				}
				num = (short)2064842753;
				if (num != 0)
				{
				}
				return this.phnWideDialingInterdigitDelayms_A7836;
			}
		}

		// Token: 0x17004A29 RID: 18985
		// (get) Token: 0x06009307 RID: 37639 RVA: 0x008A6BE4 File Offset: 0x008A4DE4
		// (set) Token: 0x06009308 RID: 37640 RVA: 0x008A6C98 File Offset: 0x008A4E98
		public string PhnWideDialingInterdigitDelayms_A7836_UIValue
		{
			get
			{
				short num = (short)1990446948;
				short num2 = num;
				num = (short)773705572;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1071120384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)566296576;
				if (num != 0)
				{
				}
				num = (short)1286864897;
				if (num != 0)
				{
				}
				return this.phnWideDialingInterdigitDelayms_A7836.UIValue;
			}
			set
			{
				short num = (short)585573323;
				short num2 = num;
				num = (short)1122968523;
				switch (num2 == num)
				{
				default:
				{
					num = (short)324599808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)833159169;
				if (num != 0)
				{
				}
				num = (short)1211432960;
				if (num != 0)
				{
				}
				this.phnWideDialingInterdigitDelayms_A7836.UIValue = value;
			}
		}

		// Token: 0x17004A2A RID: 18986
		// (get) Token: 0x06009309 RID: 37641 RVA: 0x008A6D50 File Offset: 0x008A4F50
		// (set) Token: 0x0600930A RID: 37642 RVA: 0x008A6E04 File Offset: 0x008A5004
		internal int PhnWideDialingInterdigitDelayms_A7836Min
		{
			get
			{
				short num = (short)2023058247;
				short num2 = num;
				num = (short)1934060359;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1174732800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1920139265;
				if (num != 0)
				{
				}
				num = (short)2092105728;
				if (num != 0)
				{
				}
				return this.phnWideDialingInterdigitDelayms_A7836.Min;
			}
			set
			{
				short num = (short)600401164;
				short num2 = num;
				num = (short)767452428;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1741488128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1963393024;
				if (num != 0)
				{
				}
				num = (short)646184961;
				if (num != 0)
				{
				}
				this.phnWideDialingInterdigitDelayms_A7836.Min = value;
			}
		}

		// Token: 0x17004A2B RID: 18987
		// (get) Token: 0x0600930B RID: 37643 RVA: 0x008A6EB8 File Offset: 0x008A50B8
		// (set) Token: 0x0600930C RID: 37644 RVA: 0x008A6F6C File Offset: 0x008A516C
		internal int PhnWideDialingInterdigitDelayms_A7836Max
		{
			get
			{
				short num = (short)326664989;
				short num2 = num;
				num = (short)1840349981;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1905197056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)414973953;
				if (num != 0)
				{
				}
				num = (short)1366753280;
				if (num != 0)
				{
				}
				return this.phnWideDialingInterdigitDelayms_A7836.Max;
			}
			set
			{
				short num = (short)1712498983;
				short num2 = num;
				num = (short)674998567;
				switch (num2 == num)
				{
				default:
				{
					num = (short)413532160;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1198850048;
				if (num != 0)
				{
				}
				num = (short)114622465;
				if (num != 0)
				{
				}
				this.phnWideDialingInterdigitDelayms_A7836.Max = value;
			}
		}

		// Token: 0x17004A2C RID: 18988
		// (get) Token: 0x0600930D RID: 37645 RVA: 0x008A7024 File Offset: 0x008A5224
		// (set) Token: 0x0600930E RID: 37646 RVA: 0x008A70D8 File Offset: 0x008A52D8
		internal int PhnWideDialingInterdigitDelayms_A7836Step
		{
			get
			{
				short num = (short)895902952;
				short num2 = num;
				num = (short)1743348968;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1075118080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)123404289;
				if (num != 0)
				{
				}
				num = (short)443416576;
				if (num != 0)
				{
				}
				return this.phnWideDialingInterdigitDelayms_A7836.StepSize;
			}
			set
			{
				short num = (short)24298628;
				short num2 = num;
				num = (short)1847116932;
				switch (num2 == num)
				{
				default:
				{
					num = (short)172228608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1488125953;
				if (num != 0)
				{
				}
				num = (short)513736704;
				if (num != 0)
				{
				}
				this.phnWideDialingInterdigitDelayms_A7836.StepSize = value;
			}
		}

		// Token: 0x17004A2D RID: 18989
		// (get) Token: 0x0600930F RID: 37647 RVA: 0x008A7190 File Offset: 0x008A5390
		// (set) Token: 0x06009310 RID: 37648 RVA: 0x008A7244 File Offset: 0x008A5444
		public bool PhnWideDialingInterdigitDelayms_A7836_Applicable
		{
			get
			{
				short num = (short)312925658;
				short num2 = num;
				num = (short)402054618;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1314324480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1651703809;
				if (num != 0)
				{
				}
				num = (short)545390592;
				if (num != 0)
				{
				}
				return this.phnWideDialingInterdigitDelayms_A7836.Applicable;
			}
			set
			{
				short num = (short)2044115496;
				short num2 = num;
				num = (short)529578536;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2043150336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1271005185;
				if (num != 0)
				{
				}
				num = (short)1648885760;
				if (num != 0)
				{
				}
				this.phnWideDialingInterdigitDelayms_A7836.Applicable = value;
			}
		}

		// Token: 0x17004A2E RID: 18990
		// (get) Token: 0x06009311 RID: 37649 RVA: 0x008A72F8 File Offset: 0x008A54F8
		// (set) Token: 0x06009312 RID: 37650 RVA: 0x008A73AC File Offset: 0x008A55AC
		public bool PhnWideDialingInterdigitDelayms_A7836_Valid
		{
			get
			{
				short num = (short)367329281;
				if (num != 0)
				{
				}
				num = (short)1048576000;
				short num2 = num;
				num = (short)140490309;
				short num3 = num;
				num = (short)1970583109;
				switch (num3 == num)
				{
				}
				num = (short)1597177856;
				if (num != 0)
				{
				}
				return this.phnWideDialingInterdigitDelayms_A7836.Valid;
			}
			set
			{
				short num = (short)2143946577;
				short num2 = num;
				num = (short)1953498961;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1008009216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1834287105;
				if (num != 0)
				{
				}
				num = (short)472973312;
				if (num != 0)
				{
				}
				this.phnWideDialingInterdigitDelayms_A7836.Valid = value;
			}
		}

		// Token: 0x17004A2F RID: 18991
		// (get) Token: 0x06009313 RID: 37651 RVA: 0x008A7460 File Offset: 0x008A5660
		// (set) Token: 0x06009314 RID: 37652 RVA: 0x008A7510 File Offset: 0x008A5710
		public bool PhnWideDialingInterdigitDelayms_A7836_Visible
		{
			get
			{
				short num = (short)1707912967;
				short num2 = num;
				num = (short)1853206279;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1310851072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1141506049;
				if (num != 0)
				{
				}
				num = (short)2066743296;
				if (num != 0)
				{
				}
				return this.phnWideDialingInterdigitDelayms_A7836.Visible;
			}
			set
			{
				short num = (short)18546605;
				short num2 = num;
				num = (short)261685165;
				switch (num2 == num)
				{
				default:
				{
					num = (short)928251904;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1148387329;
				if (num != 0)
				{
				}
				num = (short)1099169792;
				if (num != 0)
				{
				}
				this.phnWideDialingInterdigitDelayms_A7836.Visible = value;
			}
		}

		// Token: 0x17004A30 RID: 18992
		// (get) Token: 0x06009315 RID: 37653 RVA: 0x008A75C8 File Offset: 0x008A57C8
		// (set) Token: 0x06009316 RID: 37654 RVA: 0x008A767C File Offset: 0x008A587C
		public bool PhnWideDialingInterdigitDelayms_A7836_Editable
		{
			get
			{
				short num = (short)59489428;
				short num2 = num;
				num = (short)436583572;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2118778880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1897463809;
				if (num != 0)
				{
				}
				num = (short)897318912;
				if (num != 0)
				{
				}
				return this.phnWideDialingInterdigitDelayms_A7836.Editable;
			}
			set
			{
				short num = (short)1849281850;
				short num2 = num;
				num = (short)1526058298;
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
				num = (short)2050752513;
				if (num != 0)
				{
				}
				num = (short)154730496;
				if (num != 0)
				{
				}
				this.phnWideDialingInterdigitDelayms_A7836.Editable = value;
			}
		}

		// Token: 0x17004A31 RID: 18993
		// (get) Token: 0x06009317 RID: 37655 RVA: 0x008A7730 File Offset: 0x008A5930
		internal string PhnWideDialingInterdigitDelayms_A7836_UILabel
		{
			get
			{
				short num = (short)1922571518;
				short num2 = num;
				num = (short)407051518;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1673134080;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1783562241;
				if (num != 0)
				{
				}
				num = (short)302055424;
				if (num != 0)
				{
				}
				return this.phnWideDialingInterdigitDelayms_A7836.UIName;
			}
		}

		// Token: 0x17004A32 RID: 18994
		// (get) Token: 0x06009318 RID: 37656 RVA: 0x008A77E8 File Offset: 0x008A59E8
		// (set) Token: 0x06009319 RID: 37657 RVA: 0x008A789C File Offset: 0x008A5A9C
		internal bool PhnWideDialingInterdigitDelayms_A7836_HiddenStatic
		{
			get
			{
				short num = (short)1372560310;
				short num2 = num;
				num = (short)789093302;
				switch (num2 == num)
				{
				default:
				{
					num = (short)27656192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)882376705;
				if (num != 0)
				{
				}
				num = (short)1248985088;
				if (num != 0)
				{
				}
				return this.phnWideDialingInterdigitDelayms_A7836.HiddenStatic;
			}
			set
			{
				short num = (short)1640755633;
				short num2 = num;
				num = (short)1328869809;
				switch (num2 == num)
				{
				default:
				{
					num = (short)714997760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1199898625;
				if (num != 0)
				{
				}
				num = (short)2105212928;
				if (num != 0)
				{
				}
				this.phnWideDialingInterdigitDelayms_A7836.HiddenStatic = value;
			}
		}

		// Token: 0x17004A33 RID: 18995
		// (get) Token: 0x0600931A RID: 37658 RVA: 0x008A7950 File Offset: 0x008A5B50
		// (set) Token: 0x0600931B RID: 37659 RVA: 0x008A7A08 File Offset: 0x008A5C08
		internal bool PhnWideDialingInterdigitDelayms_A7836_HiddenDynamic
		{
			get
			{
				short num = (short)548671561;
				short num2 = num;
				num = (short)10817609;
				switch (num2 == num)
				{
				default:
				{
					num = (short)577634304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1536557056;
				if (num != 0)
				{
				}
				num = (short)2138112001;
				if (num != 0)
				{
				}
				return this.phnWideDialingInterdigitDelayms_A7836.HiddenDynamic;
			}
			set
			{
				short num = (short)1781967173;
				short num2 = num;
				num = (short)1112254789;
				switch (num2 == num)
				{
				default:
				{
					num = (short)832765952;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)852754433;
				if (num != 0)
				{
				}
				num = (short)1631387648;
				if (num != 0)
				{
				}
				this.phnWideDialingInterdigitDelayms_A7836.HiddenDynamic = value;
			}
		}

		// Token: 0x17004A34 RID: 18996
		// (get) Token: 0x0600931C RID: 37660 RVA: 0x008A7AC0 File Offset: 0x008A5CC0
		public bool PhnWideDialingInterdigitDelayms_A7836_HasDiffs
		{
			get
			{
				short num = (short)445051;
				short num2 = num;
				num = (short)388483707;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1616576512;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1314127872;
				if (num != 0)
				{
				}
				num = (short)203423745;
				if (num != 0)
				{
				}
				return this.phnWideDialingInterdigitDelayms_A7836._HasDiffs;
			}
		}

		// Token: 0x0600931D RID: 37661 RVA: 0x008A7B78 File Offset: 0x008A5D78
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)525509269;
			short num2 = num;
			num = (short)1603510933;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_14C:
				num = (short)1161101314;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1998913536;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_70;
				}
				break;
			}
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_56:
				switch (num3)
				{
				case 0:
					num = (short)82903041;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_13F;
				case 2:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num = (short)1261699075;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_125;
				case 4:
					if (base.ParentRecset != null)
					{
						num = (short)2038038528;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				}
				goto IL_70;
			}
			IL_125:
			return result;
			IL_13F:
			if (base.ParentRecset.ContainerDoc != null)
			{
				goto IL_14C;
			}
			return result;
			IL_70:
			result = null;
			num = (short)1515782145;
			if (num != 0)
			{
			}
			num = (short)305004544;
			short num4 = num;
			num = (short)489291780;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_56;
		}

		// Token: 0x040048AA RID: 18602
		private global::AcpBusinessLayer.AcpKeyField phnWideDialingkeyofDialing_A21285;

		// Token: 0x040048AB RID: 18603
		private global::AcpBusinessLayer.AcpSimpleRangeField phnWideDialingDigitDurationms_A7834;

		// Token: 0x040048AC RID: 18604
		private global::AcpBusinessLayer.AcpSimpleRangeField phnWideDialingInitialDelayms_A7835;

		// Token: 0x040048AD RID: 18605
		private global::AcpBusinessLayer.AcpSimpleRangeField phnWideDialingInterdigitDelayms_A7836;
	}
}
