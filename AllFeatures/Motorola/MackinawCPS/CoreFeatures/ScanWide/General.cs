using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.ScanWide
{
	// Token: 0x0200010A RID: 266
	[global::System.Serializable]
	public class General : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060026D1 RID: 9937 RVA: 0x0025D8B8 File Offset: 0x0025BAB8
		public General(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x0025D8D4 File Offset: 0x0025BAD4
		protected General(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060026D3 RID: 9939 RVA: 0x0025D8EC File Offset: 0x0025BAEC
		public override void Init()
		{
			int a_ = 5;
			short num = (short)800580330;
			short num2 = num;
			num = (short)1753670378;
			switch (num2 == num)
			{
			}
			num = (short)411959297;
			if (num != 0)
			{
			}
			num = (short)1039269888;
			if (num != 0)
			{
			}
			num = (short)803209216;
			short num3 = num;
			this.scanWideRadioWideDataRxTxHoldTimesec_A7797 = new global::AcpBusinessLayer.AcpSimpleRangeField(3, this, global::AllFeatures.CodeplugGuid.b("闅ꯇꯉꋋ駍맏뛑뇓蓕맗뻙뗛뇝럟诡胣菥곧诩飫迭ꋯ諱ꃳ軵냷闹郻髽哿欁椃挅笇漉漋儍儏┑⌓⼕⼗", a_), global::CommonResources.AcgResources.ID_DATARXTXHOLDTIMESEC, 0, 255, null, null, 0, 1);
			this.scanWideRadioWideDataRxTxHoldTimesec_A7797.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.scanWideRadioWideDataRxTxHoldTimesec_A7797.DataTransferOrder = 5;
			this.scanWideRadioWideDataRxTxHoldTimesec_A7797.ShowHexValue = false;
			this.scanWideRadioWideHUBSuspendsScan_A8216 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闅ꯇꯉꋋ駍맏뛑뇓蓕맗뻙뗛뇝럟诡胣菥ꃧ뿩껫뷭藯臱蓳鏵雷黹迻귽揿持樃夅䤇㈉㸋㼍☏", a_), global::CommonResources.AcgResources.ID_HUBSUSPENDSSCAN);
			this.scanWideRadioWideHUBSuspendsScan_A8216.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.scanWideRadioWideHUBSuspendsScan_A8216.DataTransferOrder = 1;
			this.scanWideRadioWidePriorityScanAlert_A8752 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闅ꯇꯉꋋ駍맏뛑뇓蓕맗뻙뗛뇝럟诡胣菥룧飩藫臭苯鯱胳迵꯷駹鷻都䇿渁愃琅簇唉䴋㘍✏✑☓", a_), global::CommonResources.AcgResources.ID_PRIORITYSCANALERT);
			this.scanWideRadioWidePriorityScanAlert_A8752.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.scanWideRadioWidePriorityScanAlert_A8752.DataTransferOrder = 11;
			this.scanWideRadioWideSuspendAllScan_A9232 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("闅ꯇꯉꋋ駍맏뛑뇓蓕맗뻙뗛뇝럟诡胣菥믧鿩鿫黭闯鳱郳럵铷雹꿻鷽懿氁嬃䜅ㄇ㠉㼋㰍", a_), global::CommonResources.AcgResources.ID_SUSPENDALLSCAN);
			this.scanWideRadioWideSuspendAllScan_A9232.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.scanWideRadioWideSuspendAllScan_A9232.DataTransferOrder = 13;
			this.scanWideRadioWideVoiceRxTxHoldTimeSec_A9653 = new global::AcpBusinessLayer.AcpSimpleRangeField(3, this, global::AllFeatures.CodeplugGuid.b("闅ꯇꯉꋋ駍맏뛑뇓蓕맗뻙뗛뇝럟诡胣菥뻧藩藫跭闯ꃱ賳ꋵ胷당鏻鋽擿嘁洃欅洇変椋洍伏匑ⴓ―ⴗ⤙", a_), global::CommonResources.AcgResources.ID_VOICERXTXHOLDTIMESEC, 0, 255, null, null, 0, 1);
			this.scanWideRadioWideVoiceRxTxHoldTimeSec_A9653.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.scanWideRadioWideVoiceRxTxHoldTimeSec_A9653.DataTransferOrder = 9;
			this.scanWideRadioWideVoiceRxTxHoldTimeSec_A9653.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("臅귇꓉꧋볍뇏뻑", a_);
			base.Id = 10049;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060026D4 RID: 9940 RVA: 0x0025DB18 File Offset: 0x0025BD18
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 19;
			short num = (short)1743650831;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟓뗕맗듙诛럝蓟蟡뛣蟥賧菩菫맭駯雱釳ꗵ跷觹賻鯽滿昁䔃樅搇変漋漍縏䴑唓⼕⨗⤙⸛", a_)))
					{
						num = (short)2030829581;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_183;
				case 1:
					this.scanWideRadioWideVoiceRxTxHoldTimeSec_A9653 = new global::AcpBusinessLayer.AcpSimpleRangeField(3, this, global::AllFeatures.CodeplugGuid.b("蟓뗕맗듙诛럝蓟蟡뛣蟥賧菩菫맭駯雱釳ꃵ韷鏹鿻鯽勿稁倃縅䀇攉怋樍䐏笑礓猕䬗缙缛䄝感ᬡሣጥᬧ", a_), global::CommonResources.AcgResources.ID_VOICERXTXHOLDTIMESEC, null, null, 0, 1);
					this.scanWideRadioWideVoiceRxTxHoldTimeSec_A9653.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.scanWideRadioWideVoiceRxTxHoldTimeSec_A9653.DataTransferOrder = 9;
					this.scanWideRadioWideVoiceRxTxHoldTimeSec_A9653.ShowHexValue = false;
					num = (short)699072521;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟓뗕맗듙诛럝蓟蟡뛣蟥賧菩菫맭駯雱釳ꃵ韷鏹鿻鯽勿稁倃縅䀇攉怋樍䐏笑礓猕䬗缙缛䄝感ᬡሣጥᬧ", a_)))
					{
						num = (short)1262616577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4B5;
				case 3:
				{
					num = (short)1253244928;
					short num3 = num;
					goto IL_EB;
				}
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟓뗕맗듙诛럝蓟蟡뛣蟥賧菩菫맭駯雱釳꛵諷鏹鏻賽槿瘁紃唅欇欉戋伍簏眑易戕䜗嬙␛⤝ᔟအ", a_)))
					{
						num = (short)890896392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9D;
				case 5:
					num = (short)1875771398;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					num = (short)1164617981;
					short num4 = num;
					num = (short)2108205309;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_4B5;
					default:
						num = (short)669122561;
						if (num != 0)
						{
						}
						num = (short)1938685952;
						if (num != 0)
						{
						}
						if (producerFields != null)
						{
							num = (short)1494351886;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B5;
					}
					break;
				}
				case 7:
					this.scanWideRadioWideDataRxTxHoldTimesec_A7797 = new global::AcpBusinessLayer.AcpSimpleRangeField(3, this, global::AllFeatures.CodeplugGuid.b("蟓뗕맗듙诛럝蓟蟡뛣蟥賧菩菫맭駯雱釳답駷軹鷻곽磿嘁簃丅朇昉栋娍礏缑焓攕紗礙䌛弝ᜟᔡᴣᄥ", a_), global::CommonResources.AcgResources.ID_DATARXTXHOLDTIMESEC, null, null, 0, 1);
					this.scanWideRadioWideDataRxTxHoldTimesec_A7797.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.scanWideRadioWideDataRxTxHoldTimesec_A7797.DataTransferOrder = 5;
					this.scanWideRadioWideDataRxTxHoldTimesec_A7797.ShowHexValue = false;
					num = (short)536936464;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					this.scanWideRadioWidePriorityScanAlert_A8752 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蟓뗕맗듙诛럝蓟蟡뛣蟥賧菩菫맭駯雱釳꛵諷鏹鏻賽槿瘁紃唅欇欉戋伍簏眑易戕䜗嬙␛⤝ᔟအ", a_), global::CommonResources.AcgResources.ID_PRIORITYSCANALERT);
					this.scanWideRadioWidePriorityScanAlert_A8752.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.scanWideRadioWidePriorityScanAlert_A8752.DataTransferOrder = 11;
					num = (short)1698037772;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_32E;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟓뗕맗듙诛럝蓟蟡뛣蟥賧菩菫맭駯雱釳뻵귷룹꿻诽珿爁愃栅氇礉弋洍焏簑䬓圕‗⠙ⴛ⠝", a_)))
					{
						num = (short)1370947595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EB;
				case 11:
					this.scanWideRadioWideHUBSuspendsScan_A8216 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蟓뗕맗듙诛럝蓟蟡뛣蟥賧菩菫맭駯雱釳뻵귷룹꿻诽珿爁愃栅氇礉弋洍焏簑䬓圕‗⠙ⴛ⠝", a_), global::CommonResources.AcgResources.ID_HUBSUSPENDSSCAN);
					this.scanWideRadioWideHUBSuspendsScan_A8216.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.scanWideRadioWideHUBSuspendsScan_A8216.DataTransferOrder = 1;
					num = (short)2039349251;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_9D;
				case 13:
					this.scanWideRadioWideSuspendAllScan_A9232 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("蟓뗕맗듙诛럝蓟蟡뛣蟥賧菩菫맭駯雱釳ꗵ跷觹賻鯽滿昁䔃樅搇変漋漍縏䴑唓⼕⨗⤙⸛", a_), global::CommonResources.AcgResources.ID_SUSPENDALLSCAN);
					this.scanWideRadioWideSuspendAllScan_A9232.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.scanWideRadioWideSuspendAllScan_A9232.DataTransferOrder = 13;
					num = (short)1924333585;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					num = (short)372703250;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					switch (0)
					{
					case 0:
						goto IL_7A;
					}
					continue;
				case 16:
					goto IL_467;
				case 17:
					goto IL_183;
				case 18:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟓뗕맗듙诛럝蓟蟡뛣蟥賧菩菫맭駯雱釳답駷軹鷻곽磿嘁簃丅朇昉栋娍礏缑焓攕紗礙䌛弝ᜟᔡᴣᄥ", a_)))
					{
						num = (short)888799239;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_467;
				}
				IL_7A:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)397672453;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_9D:
				num = (short)1747779584;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EB:
				num = (short)635437060;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_183:
				num = (short)796000258;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_467:
				num = (short)1675886602;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_32E:
			IL_4B5:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鏓돕뛗뿙껛뿝賟", a_);
			base.Id = 10049;
			base.UIName = global::CommonResources.AcgResources.ID_GENERAL;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060026D5 RID: 9941 RVA: 0x0025E00C File Offset: 0x0025C20C
		public override void PopulateReferences()
		{
			short num = (short)445990157;
			short num2 = num;
			num = (short)974406925;
			switch (num2 == num)
			{
			}
			num = (short)2086076417;
			if (num != 0)
			{
			}
			num = (short)1038090240;
			if (num != 0)
			{
			}
			num = (short)1449197568;
			short num3 = num;
		}

		// Token: 0x060026D6 RID: 9942 RVA: 0x0025E0B8 File Offset: 0x0025C2B8
		public override void DropReferences()
		{
			short num = (short)210155879;
			short num2 = num;
			num = (short)879409511;
			switch (num2 == num)
			{
			}
			num = (short)2114322433;
			if (num != 0)
			{
			}
			num = (short)1268908032;
			if (num != 0)
			{
			}
			num = (short)1837629440;
			short num3 = num;
		}

		// Token: 0x060026D7 RID: 9943 RVA: 0x0025E160 File Offset: 0x0025C360
		public override void SetConstraints()
		{
			short num = (short)970831461;
			short num2 = num;
			num = (short)583317093;
			switch (num2 == num)
			{
			}
			num = (short)120782848;
			if (num != 0)
			{
			}
			num = (short)439615489;
			if (num != 0)
			{
			}
			num = (short)300548096;
			short num3 = num;
			this.scanWideRadioWidePriorityScanAlert_A8752.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ScanWide.ScanWideConstraints.ConAlertToneInhIsEnabled);
			this.scanWideRadioWideSuspendAllScan_A9232.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.ScanWide.ScanWideConstraints.ConOffHookSuspScanEnIsEnabled);
		}

		// Token: 0x060026D8 RID: 9944 RVA: 0x0025E238 File Offset: 0x0025C438
		public override void SetupDependencies()
		{
			short num = (short)1444500861;
			short num2 = num;
			num = (short)1799705981;
			switch (num2 == num)
			{
			}
			num = (short)1387528193;
			if (num != 0)
			{
			}
			num = (short)1227227136;
			if (num != 0)
			{
			}
			num = (short)154992640;
			short num3 = num;
			this.RefRadioWide.AlertTones.RadProfAlertTonesAlertTones_A7428.AddDependentObject(this.scanWideRadioWidePriorityScanAlert_A8752);
			this.scanWideRadioWideHUBSuspendsScan_A8216.AddDependentObject(this.scanWideRadioWideSuspendAllScan_A9232);
		}

		// Token: 0x17001373 RID: 4979
		// (get) Token: 0x060026D9 RID: 9945 RVA: 0x0025E314 File Offset: 0x0025C514
		public bool HasDiffs
		{
			get
			{
				short num = (short)1493746855;
				short num2 = num;
				num = (short)1107608743;
				switch (num2 == num)
				{
				}
				num = (short)130547712;
				if (num != 0)
				{
				}
				num = (short)267976705;
				if (num != 0)
				{
				}
				num = (short)1430454272;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17001374 RID: 4980
		// (get) Token: 0x060026DA RID: 9946 RVA: 0x0025E3C4 File Offset: 0x0025C5C4
		// (set) Token: 0x060026DB RID: 9947 RVA: 0x0025E478 File Offset: 0x0025C678
		public int ScanWideRadioWideDataRxTxHoldTimesec_A7797Value
		{
			get
			{
				short num = (short)2136956656;
				short num2 = num;
				num = (short)1336434416;
				switch (num2 == num)
				{
				}
				num = (short)1412759553;
				if (num != 0)
				{
				}
				num = (short)1950679040;
				if (num != 0)
				{
				}
				num = (short)723189760;
				short num3 = num;
				return this.scanWideRadioWideDataRxTxHoldTimesec_A7797.Value;
			}
			set
			{
				short num = (short)1672413185;
				if (num != 0)
				{
				}
				num = (short)1225109016;
				short num2 = num;
				num = (short)59354648;
				switch (num2 == num)
				{
				}
				num = (short)716374016;
				if (num != 0)
				{
				}
				num = (short)1699676160;
				short num3 = num;
				this.scanWideRadioWideDataRxTxHoldTimesec_A7797.Value = value;
			}
		}

		// Token: 0x17001375 RID: 4981
		// (get) Token: 0x060026DC RID: 9948 RVA: 0x0025E52C File Offset: 0x0025C72C
		public global::AcpBusinessLayer.AcpSimpleRangeField ScanWideRadioWideDataRxTxHoldTimesec_A7797
		{
			get
			{
				short num = (short)901357260;
				short num2 = num;
				num = (short)810000076;
				switch (num2 == num)
				{
				}
				num = (short)756809728;
				if (num != 0)
				{
				}
				num = (short)749600769;
				if (num != 0)
				{
				}
				num = (short)1729757184;
				short num3 = num;
				return this.scanWideRadioWideDataRxTxHoldTimesec_A7797;
			}
		}

		// Token: 0x17001376 RID: 4982
		// (get) Token: 0x060026DD RID: 9949 RVA: 0x0025E5DC File Offset: 0x0025C7DC
		// (set) Token: 0x060026DE RID: 9950 RVA: 0x0025E690 File Offset: 0x0025C890
		public string ScanWideRadioWideDataRxTxHoldTimesec_A7797_UIValue
		{
			get
			{
				short num = (short)144637953;
				if (num != 0)
				{
				}
				num = (short)1874977732;
				short num2 = num;
				num = (short)1718870980;
				switch (num2 == num)
				{
				}
				num = (short)1388314624;
				if (num != 0)
				{
				}
				num = (short)711720960;
				short num3 = num;
				return this.scanWideRadioWideDataRxTxHoldTimesec_A7797.UIValue;
			}
			set
			{
				short num = (short)61669377;
				if (num != 0)
				{
				}
				num = (short)1738276695;
				short num2 = num;
				num = (short)1365835607;
				switch (num2 == num)
				{
				}
				num = (short)815202304;
				if (num != 0)
				{
				}
				num = (short)1024131072;
				short num3 = num;
				this.scanWideRadioWideDataRxTxHoldTimesec_A7797.UIValue = value;
			}
		}

		// Token: 0x17001377 RID: 4983
		// (get) Token: 0x060026DF RID: 9951 RVA: 0x0025E744 File Offset: 0x0025C944
		// (set) Token: 0x060026E0 RID: 9952 RVA: 0x0025E7F4 File Offset: 0x0025C9F4
		internal int ScanWideRadioWideDataRxTxHoldTimesec_A7797Min
		{
			get
			{
				short num = (short)1447211607;
				short num2 = num;
				num = (short)105034327;
				switch (num2 == num)
				{
				}
				num = (short)1435369472;
				if (num != 0)
				{
				}
				num = (short)341311489;
				if (num != 0)
				{
				}
				num = (short)168558592;
				short num3 = num;
				return this.scanWideRadioWideDataRxTxHoldTimesec_A7797.Min;
			}
			set
			{
				short num = (short)890579235;
				short num2 = num;
				num = (short)1203579171;
				switch (num2 == num)
				{
				}
				num = (short)105447425;
				if (num != 0)
				{
				}
				num = (short)900988928;
				if (num != 0)
				{
				}
				num = (short)1195114496;
				short num3 = num;
				this.scanWideRadioWideDataRxTxHoldTimesec_A7797.Min = value;
			}
		}

		// Token: 0x17001378 RID: 4984
		// (get) Token: 0x060026E1 RID: 9953 RVA: 0x0025E8A8 File Offset: 0x0025CAA8
		// (set) Token: 0x060026E2 RID: 9954 RVA: 0x0025E95C File Offset: 0x0025CB5C
		internal int ScanWideRadioWideDataRxTxHoldTimesec_A7797Max
		{
			get
			{
				short num = (short)1971549913;
				short num2 = num;
				num = (short)617182937;
				switch (num2 == num)
				{
				}
				num = (short)343277569;
				if (num != 0)
				{
				}
				num = (short)473825280;
				if (num != 0)
				{
				}
				num = (short)1453195264;
				short num3 = num;
				return this.scanWideRadioWideDataRxTxHoldTimesec_A7797.Max;
			}
			set
			{
				short num = (short)1452343297;
				if (num != 0)
				{
				}
				num = (short)1035003200;
				short num2 = num;
				num = (short)1486153024;
				switch (num2 == num)
				{
				}
				num = (short)1171783680;
				if (num != 0)
				{
				}
				num = (short)1395523584;
				short num3 = num;
				this.scanWideRadioWideDataRxTxHoldTimesec_A7797.Max = value;
			}
		}

		// Token: 0x17001379 RID: 4985
		// (get) Token: 0x060026E3 RID: 9955 RVA: 0x0025EA10 File Offset: 0x0025CC10
		// (set) Token: 0x060026E4 RID: 9956 RVA: 0x0025EAC4 File Offset: 0x0025CCC4
		internal int ScanWideRadioWideDataRxTxHoldTimesec_A7797Step
		{
			get
			{
				short num = (short)2033909761;
				if (num != 0)
				{
				}
				num = (short)1729319457;
				short num2 = num;
				num = (short)2099597857;
				switch (num2 == num)
				{
				}
				num = (short)684982272;
				if (num != 0)
				{
				}
				num = (short)1179451392;
				short num3 = num;
				return this.scanWideRadioWideDataRxTxHoldTimesec_A7797.StepSize;
			}
			set
			{
				short num = (short)416022529;
				if (num != 0)
				{
				}
				num = (short)603578976;
				short num2 = num;
				num = (short)1344922208;
				switch (num2 == num)
				{
				}
				num = (short)747175936;
				if (num != 0)
				{
				}
				num = (short)2073362432;
				short num3 = num;
				this.scanWideRadioWideDataRxTxHoldTimesec_A7797.StepSize = value;
			}
		}

		// Token: 0x1700137A RID: 4986
		// (get) Token: 0x060026E5 RID: 9957 RVA: 0x0025EB78 File Offset: 0x0025CD78
		// (set) Token: 0x060026E6 RID: 9958 RVA: 0x0025EC2C File Offset: 0x0025CE2C
		public bool ScanWideRadioWideDataRxTxHoldTimesec_A7797_Applicable
		{
			get
			{
				short num = (short)82116609;
				if (num != 0)
				{
				}
				num = (short)1295579003;
				short num2 = num;
				num = (short)968816507;
				switch (num2 == num)
				{
				}
				num = (short)163184640;
				if (num != 0)
				{
				}
				num = (short)563085312;
				short num3 = num;
				return this.scanWideRadioWideDataRxTxHoldTimesec_A7797.Applicable;
			}
			set
			{
				short num = (short)1443700910;
				short num2 = num;
				num = (short)463937710;
				switch (num2 == num)
				{
				}
				num = (short)476774401;
				if (num != 0)
				{
				}
				num = (short)1756037120;
				if (num != 0)
				{
				}
				num = (short)651034624;
				short num3 = num;
				this.scanWideRadioWideDataRxTxHoldTimesec_A7797.Applicable = value;
			}
		}

		// Token: 0x1700137B RID: 4987
		// (get) Token: 0x060026E7 RID: 9959 RVA: 0x0025ECE4 File Offset: 0x0025CEE4
		// (set) Token: 0x060026E8 RID: 9960 RVA: 0x0025ED94 File Offset: 0x0025CF94
		public bool ScanWideRadioWideDataRxTxHoldTimesec_A7797_Valid
		{
			get
			{
				short num = (short)226366049;
				short num2 = num;
				num = (short)650580577;
				switch (num2 == num)
				{
				}
				num = (short)271187969;
				if (num != 0)
				{
				}
				num = (short)1385758720;
				if (num != 0)
				{
				}
				num = (short)1974796288;
				short num3 = num;
				return this.scanWideRadioWideDataRxTxHoldTimesec_A7797.Valid;
			}
			set
			{
				short num = (short)1812913838;
				short num2 = num;
				num = (short)1604116142;
				switch (num2 == num)
				{
				}
				num = (short)1536294912;
				if (num != 0)
				{
				}
				num = (short)350814209;
				if (num != 0)
				{
				}
				num = (short)1335885824;
				short num3 = num;
				this.scanWideRadioWideDataRxTxHoldTimesec_A7797.Valid = value;
			}
		}

		// Token: 0x1700137C RID: 4988
		// (get) Token: 0x060026E9 RID: 9961 RVA: 0x0025EE48 File Offset: 0x0025D048
		// (set) Token: 0x060026EA RID: 9962 RVA: 0x0025EEFC File Offset: 0x0025D0FC
		public bool ScanWideRadioWideDataRxTxHoldTimesec_A7797_Visible
		{
			get
			{
				short num = (short)666578850;
				short num2 = num;
				num = (short)641085346;
				switch (num2 == num)
				{
				}
				num = (short)46071809;
				if (num != 0)
				{
				}
				num = (short)144310272;
				if (num != 0)
				{
				}
				num = (short)1964703744;
				short num3 = num;
				return this.scanWideRadioWideDataRxTxHoldTimesec_A7797.Visible;
			}
			set
			{
				short num = (short)1744490949;
				short num2 = num;
				num = (short)1090310597;
				switch (num2 == num)
				{
				}
				num = (short)1555431424;
				short num3 = num;
				num = (short)628555777;
				if (num != 0)
				{
				}
				num = (short)1444544512;
				if (num != 0)
				{
				}
				this.scanWideRadioWideDataRxTxHoldTimesec_A7797.Visible = value;
			}
		}

		// Token: 0x1700137D RID: 4989
		// (get) Token: 0x060026EB RID: 9963 RVA: 0x0025EFB0 File Offset: 0x0025D1B0
		// (set) Token: 0x060026EC RID: 9964 RVA: 0x0025F064 File Offset: 0x0025D264
		public bool ScanWideRadioWideDataRxTxHoldTimesec_A7797_Editable
		{
			get
			{
				short num = (short)1142402140;
				short num2 = num;
				num = (short)1928637532;
				switch (num2 == num)
				{
				}
				num = (short)253952000;
				short num3 = num;
				num = (short)432865281;
				if (num != 0)
				{
				}
				num = (short)225509376;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideDataRxTxHoldTimesec_A7797.Editable;
			}
			set
			{
				short num = (short)649872126;
				short num2 = num;
				num = (short)993084158;
				switch (num2 == num)
				{
				}
				num = (short)948240384;
				short num3 = num;
				num = (short)116916225;
				if (num != 0)
				{
				}
				num = (short)1471676416;
				if (num != 0)
				{
				}
				this.scanWideRadioWideDataRxTxHoldTimesec_A7797.Editable = value;
			}
		}

		// Token: 0x1700137E RID: 4990
		// (get) Token: 0x060026ED RID: 9965 RVA: 0x0025F11C File Offset: 0x0025D31C
		internal string ScanWideRadioWideDataRxTxHoldTimesec_A7797_UILabel
		{
			get
			{
				short num = (short)1552833873;
				short num2 = num;
				num = (short)379149649;
				switch (num2 == num)
				{
				}
				num = (short)1273102336;
				short num3 = num;
				num = (short)720306176;
				if (num != 0)
				{
				}
				num = (short)1552809985;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideDataRxTxHoldTimesec_A7797.UIName;
			}
		}

		// Token: 0x1700137F RID: 4991
		// (get) Token: 0x060026EE RID: 9966 RVA: 0x0025F1D0 File Offset: 0x0025D3D0
		// (set) Token: 0x060026EF RID: 9967 RVA: 0x0025F284 File Offset: 0x0025D484
		internal bool ScanWideRadioWideDataRxTxHoldTimesec_A7797_HiddenStatic
		{
			get
			{
				short num = (short)56504810;
				short num2 = num;
				num = (short)1899311594;
				switch (num2 == num)
				{
				}
				num = (short)83689472;
				short num3 = num;
				num = (short)351207425;
				if (num != 0)
				{
				}
				num = (short)521732096;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideDataRxTxHoldTimesec_A7797.HiddenStatic;
			}
			set
			{
				short num = (short)1745554036;
				short num2 = num;
				num = (short)1656556148;
				switch (num2 == num)
				{
				}
				num = (short)799735808;
				short num3 = num;
				num = (short)265027585;
				if (num != 0)
				{
				}
				num = (short)1472462848;
				if (num != 0)
				{
				}
				this.scanWideRadioWideDataRxTxHoldTimesec_A7797.HiddenStatic = value;
			}
		}

		// Token: 0x17001380 RID: 4992
		// (get) Token: 0x060026F0 RID: 9968 RVA: 0x0025F33C File Offset: 0x0025D53C
		// (set) Token: 0x060026F1 RID: 9969 RVA: 0x0025F3F4 File Offset: 0x0025D5F4
		internal bool ScanWideRadioWideDataRxTxHoldTimesec_A7797_HiddenDynamic
		{
			get
			{
				short num = (short)40219259;
				short num2 = num;
				num = (short)1945088635;
				switch (num2 == num)
				{
				}
				num = (short)1253244928;
				short num3 = num;
				num = (short)522911745;
				if (num != 0)
				{
				}
				num = (short)1191772160;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideDataRxTxHoldTimesec_A7797.HiddenDynamic;
			}
			set
			{
				short num = (short)879605716;
				short num2 = num;
				num = (short)1978316756;
				switch (num2 == num)
				{
				}
				num = (short)514326528;
				short num3 = num;
				num = (short)304414721;
				if (num != 0)
				{
				}
				num = (short)419037184;
				if (num != 0)
				{
				}
				this.scanWideRadioWideDataRxTxHoldTimesec_A7797.HiddenDynamic = value;
			}
		}

		// Token: 0x17001381 RID: 4993
		// (get) Token: 0x060026F2 RID: 9970 RVA: 0x0025F4A8 File Offset: 0x0025D6A8
		public bool ScanWideRadioWideDataRxTxHoldTimesec_A7797_HasDiffs
		{
			get
			{
				short num = (short)403109478;
				short num2 = num;
				num = (short)831125094;
				switch (num2 == num)
				{
				}
				num = (short)313196544;
				short num3 = num;
				num = (short)1096941569;
				if (num != 0)
				{
				}
				num = (short)1305935872;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideDataRxTxHoldTimesec_A7797._HasDiffs;
			}
		}

		// Token: 0x17001382 RID: 4994
		// (get) Token: 0x060026F3 RID: 9971 RVA: 0x0025F560 File Offset: 0x0025D760
		// (set) Token: 0x060026F4 RID: 9972 RVA: 0x0025F614 File Offset: 0x0025D814
		public bool ScanWideRadioWideHUBSuspendsScan_A8216Value
		{
			get
			{
				short num = (short)596712522;
				short num2 = num;
				num = (short)746462282;
				switch (num2 == num)
				{
				}
				num = (short)587333632;
				short num3 = num;
				num = (short)263258113;
				if (num != 0)
				{
				}
				num = (short)1433075712;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideHUBSuspendsScan_A8216.Value;
			}
			set
			{
				short num = (short)683429954;
				short num2 = num;
				num = (short)1563643970;
				switch (num2 == num)
				{
				}
				num = (short)1807024128;
				short num3 = num;
				num = (short)1416888321;
				if (num != 0)
				{
				}
				num = (short)696516608;
				if (num != 0)
				{
				}
				this.scanWideRadioWideHUBSuspendsScan_A8216.Value = value;
			}
		}

		// Token: 0x17001383 RID: 4995
		// (get) Token: 0x060026F5 RID: 9973 RVA: 0x0025F6C8 File Offset: 0x0025D8C8
		public global::AcpBusinessLayer.AcpField<bool> ScanWideRadioWideHUBSuspendsScan_A8216
		{
			get
			{
				short num = (short)834880051;
				short num2 = num;
				num = (short)1974747699;
				switch (num2 == num)
				{
				}
				num = (short)1460731904;
				short num3 = num;
				num = (short)318177280;
				if (num != 0)
				{
				}
				num = (short)110493697;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideHUBSuspendsScan_A8216;
			}
		}

		// Token: 0x17001384 RID: 4996
		// (get) Token: 0x060026F6 RID: 9974 RVA: 0x0025F778 File Offset: 0x0025D978
		// (set) Token: 0x060026F7 RID: 9975 RVA: 0x0025F82C File Offset: 0x0025DA2C
		public bool ScanWideRadioWideHUBSuspendsScan_A8216_UIValue
		{
			get
			{
				short num = (short)1355390452;
				short num2 = num;
				num = (short)347381236;
				switch (num2 == num)
				{
				}
				num = (short)2114453504;
				short num3 = num;
				num = (short)1047134209;
				if (num != 0)
				{
				}
				num = (short)1897660416;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideHUBSuspendsScan_A8216.Value;
			}
			set
			{
				short num = (short)199538706;
				short num2 = num;
				num = (short)871348242;
				switch (num2 == num)
				{
				}
				num = (short)892338176;
				short num3 = num;
				num = (short)1830813697;
				if (num != 0)
				{
				}
				num = (short)1604911104;
				if (num != 0)
				{
				}
				this.scanWideRadioWideHUBSuspendsScan_A8216.Value = value;
			}
		}

		// Token: 0x17001385 RID: 4997
		// (get) Token: 0x060026F8 RID: 9976 RVA: 0x0025F8E0 File Offset: 0x0025DAE0
		// (set) Token: 0x060026F9 RID: 9977 RVA: 0x0025F990 File Offset: 0x0025DB90
		public bool ScanWideRadioWideHUBSuspendsScan_A8216_Applicable
		{
			get
			{
				short num = (short)1953103873;
				if (num != 0)
				{
				}
				num = (short)536043012;
				short num2 = num;
				num = (short)1978621444;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1206059008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)195166208;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideHUBSuspendsScan_A8216.Applicable;
			}
			set
			{
				short num = (short)1390009878;
				short num2 = num;
				num = (short)776068630;
				switch (num2 == num)
				{
				}
				num = (short)742391808;
				short num3 = num;
				num = (short)959119361;
				if (num != 0)
				{
				}
				num = (short)1156644864;
				if (num != 0)
				{
				}
				this.scanWideRadioWideHUBSuspendsScan_A8216.Applicable = value;
			}
		}

		// Token: 0x17001386 RID: 4998
		// (get) Token: 0x060026FA RID: 9978 RVA: 0x0025FA48 File Offset: 0x0025DC48
		// (set) Token: 0x060026FB RID: 9979 RVA: 0x0025FAFC File Offset: 0x0025DCFC
		public bool ScanWideRadioWideHUBSuspendsScan_A8216_Valid
		{
			get
			{
				short num = (short)904753632;
				short num2 = num;
				num = (short)1115648480;
				switch (num2 == num)
				{
				}
				num = (short)376242176;
				short num3 = num;
				num = (short)1230438401;
				if (num != 0)
				{
				}
				num = (short)1314258944;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideHUBSuspendsScan_A8216.Valid;
			}
			set
			{
				short num = (short)2081786643;
				short num2 = num;
				num = (short)867863315;
				switch (num2 == num)
				{
				}
				num = (short)1269563392;
				short num3 = num;
				num = (short)1045561345;
				if (num != 0)
				{
				}
				num = (short)238419968;
				if (num != 0)
				{
				}
				this.scanWideRadioWideHUBSuspendsScan_A8216.Valid = value;
			}
		}

		// Token: 0x17001387 RID: 4999
		// (get) Token: 0x060026FC RID: 9980 RVA: 0x0025FBB4 File Offset: 0x0025DDB4
		// (set) Token: 0x060026FD RID: 9981 RVA: 0x0025FC6C File Offset: 0x0025DE6C
		public bool ScanWideRadioWideHUBSuspendsScan_A8216_Visible
		{
			get
			{
				short num = (short)1350872493;
				short num2 = num;
				num = (short)696036781;
				switch (num2 == num)
				{
				}
				num = (short)119472128;
				short num3 = num;
				num = (short)57016321;
				if (num != 0)
				{
				}
				num = (short)1880096768;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideHUBSuspendsScan_A8216.Visible;
			}
			set
			{
				short num = (short)1457351314;
				short num2 = num;
				num = (short)545221266;
				switch (num2 == num)
				{
				}
				num = (short)1432682496;
				short num3 = num;
				num = (short)988741633;
				if (num != 0)
				{
				}
				num = (short)1732706304;
				if (num != 0)
				{
				}
				this.scanWideRadioWideHUBSuspendsScan_A8216.Visible = value;
			}
		}

		// Token: 0x17001388 RID: 5000
		// (get) Token: 0x060026FE RID: 9982 RVA: 0x0025FD20 File Offset: 0x0025DF20
		// (set) Token: 0x060026FF RID: 9983 RVA: 0x0025FDD4 File Offset: 0x0025DFD4
		public bool ScanWideRadioWideHUBSuspendsScan_A8216_Editable
		{
			get
			{
				short num = (short)547618817;
				if (num != 0)
				{
				}
				num = (short)186941057;
				short num2 = num;
				num = (short)634093185;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1045561344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1670119424;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideHUBSuspendsScan_A8216.Editable;
			}
			set
			{
				short num = (short)483883896;
				short num2 = num;
				num = (short)1011055480;
				switch (num2 == num)
				{
				}
				num = (short)1741094912;
				short num3 = num;
				num = (short)854130689;
				if (num != 0)
				{
				}
				num = (short)671612928;
				if (num != 0)
				{
				}
				this.scanWideRadioWideHUBSuspendsScan_A8216.Editable = value;
			}
		}

		// Token: 0x17001389 RID: 5001
		// (get) Token: 0x06002700 RID: 9984 RVA: 0x0025FE88 File Offset: 0x0025E088
		internal string ScanWideRadioWideHUBSuspendsScan_A8216_UILabel
		{
			get
			{
				short num = (short)1536688129;
				if (num != 0)
				{
				}
				num = (short)336786294;
				short num2 = num;
				num = (short)1642656630;
				switch (num2 == num)
				{
				default:
				{
					num = (short)965083136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)301268992;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideHUBSuspendsScan_A8216.UIName;
			}
		}

		// Token: 0x1700138A RID: 5002
		// (get) Token: 0x06002701 RID: 9985 RVA: 0x0025FF40 File Offset: 0x0025E140
		// (set) Token: 0x06002702 RID: 9986 RVA: 0x0025FFF4 File Offset: 0x0025E1F4
		internal bool ScanWideRadioWideHUBSuspendsScan_A8216_HiddenStatic
		{
			get
			{
				short num = (short)87205712;
				short num2 = num;
				num = (short)2030020432;
				switch (num2 == num)
				{
				}
				num = (short)1066467328;
				short num3 = num;
				num = (short)451477505;
				if (num != 0)
				{
				}
				num = (short)208863232;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideHUBSuspendsScan_A8216.HiddenStatic;
			}
			set
			{
				short num = (short)1260912641;
				if (num != 0)
				{
				}
				num = (short)1920520483;
				short num2 = num;
				num = (short)919523619;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2121072640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1542848512;
				if (num != 0)
				{
				}
				this.scanWideRadioWideHUBSuspendsScan_A8216.HiddenStatic = value;
			}
		}

		// Token: 0x1700138B RID: 5003
		// (get) Token: 0x06002703 RID: 9987 RVA: 0x002600AC File Offset: 0x0025E2AC
		// (set) Token: 0x06002704 RID: 9988 RVA: 0x00260164 File Offset: 0x0025E364
		internal bool ScanWideRadioWideHUBSuspendsScan_A8216_HiddenDynamic
		{
			get
			{
				short num = (short)712571037;
				short num2 = num;
				num = (short)1940781213;
				switch (num2 == num)
				{
				}
				num = (short)487587840;
				short num3 = num;
				num = (short)113311745;
				if (num != 0)
				{
				}
				num = (short)2039218176;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideHUBSuspendsScan_A8216.HiddenDynamic;
			}
			set
			{
				short num = (short)1449017015;
				short num2 = num;
				num = (short)1298939575;
				switch (num2 == num)
				{
				}
				num = (short)44564480;
				short num3 = num;
				num = (short)1015611393;
				if (num != 0)
				{
				}
				num = (short)1586429952;
				if (num != 0)
				{
				}
				this.scanWideRadioWideHUBSuspendsScan_A8216.HiddenDynamic = value;
			}
		}

		// Token: 0x1700138C RID: 5004
		// (get) Token: 0x06002705 RID: 9989 RVA: 0x00260218 File Offset: 0x0025E418
		public bool ScanWideRadioWideHUBSuspendsScan_A8216_HasDiffs
		{
			get
			{
				short num = (short)331110195;
				short num2 = num;
				num = (short)545740595;
				switch (num2 == num)
				{
				}
				num = (short)675217408;
				short num3 = num;
				num = (short)1775763457;
				if (num != 0)
				{
				}
				num = (short)1418330112;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideHUBSuspendsScan_A8216._HasDiffs;
			}
		}

		// Token: 0x1700138D RID: 5005
		// (get) Token: 0x06002706 RID: 9990 RVA: 0x002602D0 File Offset: 0x0025E4D0
		// (set) Token: 0x06002707 RID: 9991 RVA: 0x00260388 File Offset: 0x0025E588
		public bool ScanWideRadioWidePriorityScanAlert_A8752Value
		{
			get
			{
				short num = (short)73752736;
				short num2 = num;
				num = (short)1380409504;
				switch (num2 == num)
				{
				}
				num = (short)837419008;
				short num3 = num;
				num = (short)1632043009;
				if (num != 0)
				{
				}
				num = (short)1540620288;
				if (num != 0)
				{
				}
				return this.scanWideRadioWidePriorityScanAlert_A8752.Value;
			}
			set
			{
				short num = (short)579364129;
				short num2 = num;
				num = (short)2094228769;
				switch (num2 == num)
				{
				}
				num = (short)104988672;
				short num3 = num;
				num = (short)871563265;
				if (num != 0)
				{
				}
				num = (short)299106304;
				if (num != 0)
				{
				}
				this.scanWideRadioWidePriorityScanAlert_A8752.Value = value;
			}
		}

		// Token: 0x1700138E RID: 5006
		// (get) Token: 0x06002708 RID: 9992 RVA: 0x0026043C File Offset: 0x0025E63C
		public global::AcpBusinessLayer.AcpField<bool> ScanWideRadioWidePriorityScanAlert_A8752
		{
			get
			{
				short num = (short)1169480759;
				short num2 = num;
				num = (short)1139203127;
				switch (num2 == num)
				{
				}
				num = (short)1365901312;
				short num3 = num;
				num = (short)1452802048;
				if (num != 0)
				{
				}
				num = (short)1020002305;
				if (num != 0)
				{
				}
				return this.scanWideRadioWidePriorityScanAlert_A8752;
			}
		}

		// Token: 0x1700138F RID: 5007
		// (get) Token: 0x06002709 RID: 9993 RVA: 0x002604F0 File Offset: 0x0025E6F0
		// (set) Token: 0x0600270A RID: 9994 RVA: 0x002605A4 File Offset: 0x0025E7A4
		public bool ScanWideRadioWidePriorityScanAlert_A8752_UIValue
		{
			get
			{
				short num = (short)53240664;
				short num2 = num;
				num = (short)1113875288;
				switch (num2 == num)
				{
				}
				num = (short)1364000768;
				short num3 = num;
				num = (short)1851260929;
				if (num != 0)
				{
				}
				num = (short)209780736;
				if (num != 0)
				{
				}
				return this.scanWideRadioWidePriorityScanAlert_A8752.Value;
			}
			set
			{
				short num = (short)1144128572;
				short num2 = num;
				num = (short)205259836;
				switch (num2 == num)
				{
				}
				num = (short)1960771584;
				short num3 = num;
				num = (short)180748289;
				if (num != 0)
				{
				}
				num = (short)1806958592;
				if (num != 0)
				{
				}
				this.scanWideRadioWidePriorityScanAlert_A8752.Value = value;
			}
		}

		// Token: 0x17001390 RID: 5008
		// (get) Token: 0x0600270B RID: 9995 RVA: 0x00260658 File Offset: 0x0025E858
		// (set) Token: 0x0600270C RID: 9996 RVA: 0x0026070C File Offset: 0x0025E90C
		public bool ScanWideRadioWidePriorityScanAlert_A8752_Applicable
		{
			get
			{
				short num = (short)2031974746;
				short num2 = num;
				num = (short)1032878426;
				switch (num2 == num)
				{
				}
				num = (short)881393664;
				short num3 = num;
				num = (short)2133590016;
				if (num != 0)
				{
				}
				num = (short)1341063169;
				if (num != 0)
				{
				}
				return this.scanWideRadioWidePriorityScanAlert_A8752.Applicable;
			}
			set
			{
				short num = (short)846790657;
				if (num != 0)
				{
				}
				num = (short)369587016;
				short num2 = num;
				num = (short)373912392;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1007419392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)937361408;
				if (num != 0)
				{
				}
				this.scanWideRadioWidePriorityScanAlert_A8752.Applicable = value;
			}
		}

		// Token: 0x17001391 RID: 5009
		// (get) Token: 0x0600270D RID: 9997 RVA: 0x002607C0 File Offset: 0x0025E9C0
		// (set) Token: 0x0600270E RID: 9998 RVA: 0x00260874 File Offset: 0x0025EA74
		public bool ScanWideRadioWidePriorityScanAlert_A8752_Valid
		{
			get
			{
				short num = (short)1250299147;
				short num2 = num;
				num = (short)688065803;
				switch (num2 == num)
				{
				}
				num = (short)1044054016;
				short num3 = num;
				num = (short)68681729;
				if (num != 0)
				{
				}
				num = (short)120455168;
				if (num != 0)
				{
				}
				return this.scanWideRadioWidePriorityScanAlert_A8752.Valid;
			}
			set
			{
				short num = (short)1803842406;
				short num2 = num;
				num = (short)462123878;
				switch (num2 == num)
				{
				}
				num = (short)468058112;
				short num3 = num;
				num = (short)1382875136;
				if (num != 0)
				{
				}
				num = (short)426246145;
				if (num != 0)
				{
				}
				this.scanWideRadioWidePriorityScanAlert_A8752.Valid = value;
			}
		}

		// Token: 0x17001392 RID: 5010
		// (get) Token: 0x0600270F RID: 9999 RVA: 0x00260928 File Offset: 0x0025EB28
		// (set) Token: 0x06002710 RID: 10000 RVA: 0x002609DC File Offset: 0x0025EBDC
		public bool ScanWideRadioWidePriorityScanAlert_A8752_Visible
		{
			get
			{
				short num = (short)1670838315;
				short num2 = num;
				num = (short)1521940523;
				switch (num2 == num)
				{
				}
				num = (short)1358233600;
				short num3 = num;
				num = (short)1057292289;
				if (num != 0)
				{
				}
				num = (short)1884618752;
				if (num != 0)
				{
				}
				return this.scanWideRadioWidePriorityScanAlert_A8752.Visible;
			}
			set
			{
				short num = (short)1722323644;
				short num2 = num;
				num = (short)981177020;
				switch (num2 == num)
				{
				}
				num = (short)1847656448;
				short num3 = num;
				num = (short)1930493952;
				if (num != 0)
				{
				}
				num = (short)100990977;
				if (num != 0)
				{
				}
				this.scanWideRadioWidePriorityScanAlert_A8752.Visible = value;
			}
		}

		// Token: 0x17001393 RID: 5011
		// (get) Token: 0x06002711 RID: 10001 RVA: 0x00260A98 File Offset: 0x0025EC98
		// (set) Token: 0x06002712 RID: 10002 RVA: 0x00260B4C File Offset: 0x0025ED4C
		public bool ScanWideRadioWidePriorityScanAlert_A8752_Editable
		{
			get
			{
				short num = (short)304152577;
				if (num != 0)
				{
				}
				num = (short)1520456828;
				short num2 = num;
				num = (short)1758680188;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1827471360;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)444989440;
				if (num != 0)
				{
				}
				return this.scanWideRadioWidePriorityScanAlert_A8752.Editable;
			}
			set
			{
				short num = (short)1387527068;
				short num2 = num;
				num = (short)1579023260;
				switch (num2 == num)
				{
				}
				num = (short)177209344;
				short num3 = num;
				num = (short)438829057;
				if (num != 0)
				{
				}
				num = (short)76218368;
				if (num != 0)
				{
				}
				this.scanWideRadioWidePriorityScanAlert_A8752.Editable = value;
			}
		}

		// Token: 0x17001394 RID: 5012
		// (get) Token: 0x06002713 RID: 10003 RVA: 0x00260C04 File Offset: 0x0025EE04
		internal string ScanWideRadioWidePriorityScanAlert_A8752_UILabel
		{
			get
			{
				short num = (short)1883563767;
				short num2 = num;
				num = (short)2095638263;
				switch (num2 == num)
				{
				}
				num = (short)2114715648;
				short num3 = num;
				num = (short)2077753345;
				if (num != 0)
				{
				}
				num = (short)614268928;
				if (num != 0)
				{
				}
				return this.scanWideRadioWidePriorityScanAlert_A8752.UIName;
			}
		}

		// Token: 0x17001395 RID: 5013
		// (get) Token: 0x06002714 RID: 10004 RVA: 0x00260CB8 File Offset: 0x0025EEB8
		// (set) Token: 0x06002715 RID: 10005 RVA: 0x00260D70 File Offset: 0x0025EF70
		internal bool ScanWideRadioWidePriorityScanAlert_A8752_HiddenStatic
		{
			get
			{
				short num = (short)1355153408;
				short num2 = num;
				num = (short)827649374;
				short num3 = num;
				num = (short)1143008606;
				switch (num3 == num)
				{
				}
				num = (short)273940481;
				if (num != 0)
				{
				}
				num = (short)1651245056;
				if (num != 0)
				{
				}
				return this.scanWideRadioWidePriorityScanAlert_A8752.HiddenStatic;
			}
			set
			{
				short num = (short)202899456;
				short num2 = num;
				num = (short)1849221901;
				short num3 = num;
				num = (short)1672536845;
				switch (num3 == num)
				{
				}
				num = (short)692191232;
				if (num != 0)
				{
				}
				num = (short)177471489;
				if (num != 0)
				{
				}
				this.scanWideRadioWidePriorityScanAlert_A8752.HiddenStatic = value;
			}
		}

		// Token: 0x17001396 RID: 5014
		// (get) Token: 0x06002716 RID: 10006 RVA: 0x00260E28 File Offset: 0x0025F028
		// (set) Token: 0x06002717 RID: 10007 RVA: 0x00260EDC File Offset: 0x0025F0DC
		internal bool ScanWideRadioWidePriorityScanAlert_A8752_HiddenDynamic
		{
			get
			{
				short num = (short)463011840;
				short num2 = num;
				num = (short)1053647381;
				short num3 = num;
				num = (short)1712415253;
				switch (num3 == num)
				{
				}
				num = (short)104202241;
				if (num != 0)
				{
				}
				num = (short)1611595776;
				if (num != 0)
				{
				}
				return this.scanWideRadioWidePriorityScanAlert_A8752.HiddenDynamic;
			}
			set
			{
				short num = (short)923664384;
				short num2 = num;
				num = (short)1792861936;
				short num3 = num;
				num = (short)177137392;
				switch (num3 == num)
				{
				}
				num = (short)1482227713;
				if (num != 0)
				{
				}
				num = (short)1307246592;
				if (num != 0)
				{
				}
				this.scanWideRadioWidePriorityScanAlert_A8752.HiddenDynamic = value;
			}
		}

		// Token: 0x17001397 RID: 5015
		// (get) Token: 0x06002718 RID: 10008 RVA: 0x00260F94 File Offset: 0x0025F194
		public bool ScanWideRadioWidePriorityScanAlert_A8752_HasDiffs
		{
			get
			{
				short num = (short)73072640;
				short num2 = num;
				num = (short)538106085;
				short num3 = num;
				num = (short)590993637;
				switch (num3 == num)
				{
				}
				num = (short)745209857;
				if (num != 0)
				{
				}
				num = (short)783482880;
				if (num != 0)
				{
				}
				return this.scanWideRadioWidePriorityScanAlert_A8752._HasDiffs;
			}
		}

		// Token: 0x17001398 RID: 5016
		// (get) Token: 0x06002719 RID: 10009 RVA: 0x0026104C File Offset: 0x0025F24C
		// (set) Token: 0x0600271A RID: 10010 RVA: 0x002610FC File Offset: 0x0025F2FC
		public bool ScanWideRadioWideSuspendAllScan_A9232Value
		{
			get
			{
				short num = (short)1107099648;
				short num2 = num;
				num = (short)223423789;
				short num3 = num;
				num = (short)1156066605;
				switch (num3 == num)
				{
				}
				num = (short)1840709633;
				if (num != 0)
				{
				}
				num = (short)678887424;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideSuspendAllScan_A9232.Value;
			}
			set
			{
				short num = (short)1586364416;
				short num2 = num;
				num = (short)776467484;
				short num3 = num;
				num = (short)1174729756;
				switch (num3 == num)
				{
				}
				num = (short)1860698112;
				if (num != 0)
				{
				}
				num = (short)914292737;
				if (num != 0)
				{
				}
				this.scanWideRadioWideSuspendAllScan_A9232.Value = value;
			}
		}

		// Token: 0x17001399 RID: 5017
		// (get) Token: 0x0600271B RID: 10011 RVA: 0x002611B0 File Offset: 0x0025F3B0
		public global::AcpBusinessLayer.AcpField<bool> ScanWideRadioWideSuspendAllScan_A9232
		{
			get
			{
				short num = (short)2107179008;
				short num2 = num;
				num = (short)92341321;
				short num3 = num;
				num = (short)389547081;
				switch (num3 == num)
				{
				}
				num = (short)1279787009;
				if (num != 0)
				{
				}
				num = (short)1712259072;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideSuspendAllScan_A9232;
			}
		}

		// Token: 0x1700139A RID: 5018
		// (get) Token: 0x0600271C RID: 10012 RVA: 0x00261260 File Offset: 0x0025F460
		// (set) Token: 0x0600271D RID: 10013 RVA: 0x00261310 File Offset: 0x0025F510
		public bool ScanWideRadioWideSuspendAllScan_A9232_UIValue
		{
			get
			{
				short num = (short)1943470080;
				short num2 = num;
				num = (short)337872282;
				short num3 = num;
				num = (short)1359775130;
				switch (num3 == num)
				{
				}
				num = (short)2053308417;
				if (num != 0)
				{
				}
				num = (short)297205760;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideSuspendAllScan_A9232.Value;
			}
			set
			{
				short num = (short)776536064;
				short num2 = num;
				num = (short)1893635482;
				short num3 = num;
				num = (short)2129302938;
				switch (num3 == num)
				{
				}
				num = (short)118292481;
				if (num != 0)
				{
				}
				num = (short)240975872;
				if (num != 0)
				{
				}
				this.scanWideRadioWideSuspendAllScan_A9232.Value = value;
			}
		}

		// Token: 0x1700139B RID: 5019
		// (get) Token: 0x0600271E RID: 10014 RVA: 0x002613C8 File Offset: 0x0025F5C8
		// (set) Token: 0x0600271F RID: 10015 RVA: 0x0026147C File Offset: 0x0025F67C
		public bool ScanWideRadioWideSuspendAllScan_A9232_Applicable
		{
			get
			{
				short num = (short)1632501760;
				short num2 = num;
				num = (short)942892211;
				short num3 = num;
				num = (short)1707369651;
				switch (num3 == num)
				{
				}
				num = (short)851968;
				if (num != 0)
				{
				}
				num = (short)1381564417;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideSuspendAllScan_A9232.Applicable;
			}
			set
			{
				short num = (short)525598720;
				short num2 = num;
				num = (short)1473016860;
				short num3 = num;
				num = (short)957903900;
				switch (num3 == num)
				{
				}
				num = (short)457310209;
				if (num != 0)
				{
				}
				num = (short)1903165440;
				if (num != 0)
				{
				}
				this.scanWideRadioWideSuspendAllScan_A9232.Applicable = value;
			}
		}

		// Token: 0x1700139C RID: 5020
		// (get) Token: 0x06002720 RID: 10016 RVA: 0x00261530 File Offset: 0x0025F730
		// (set) Token: 0x06002721 RID: 10017 RVA: 0x002615E0 File Offset: 0x0025F7E0
		public bool ScanWideRadioWideSuspendAllScan_A9232_Valid
		{
			get
			{
				short num = (short)1459224576;
				short num2 = num;
				num = (short)1396683041;
				short num3 = num;
				num = (short)1579200801;
				switch (num3 == num)
				{
				}
				num = (short)1399783425;
				if (num != 0)
				{
				}
				num = (short)1607729152;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideSuspendAllScan_A9232.Valid;
			}
			set
			{
				short num = (short)1299644416;
				short num2 = num;
				num = (short)1040733773;
				short num3 = num;
				num = (short)475747917;
				switch (num3 == num)
				{
				}
				num = (short)1067122689;
				if (num != 0)
				{
				}
				num = (short)1907818496;
				if (num != 0)
				{
				}
				this.scanWideRadioWideSuspendAllScan_A9232.Valid = value;
			}
		}

		// Token: 0x1700139D RID: 5021
		// (get) Token: 0x06002722 RID: 10018 RVA: 0x00261698 File Offset: 0x0025F898
		// (set) Token: 0x06002723 RID: 10019 RVA: 0x0026174C File Offset: 0x0025F94C
		public bool ScanWideRadioWideSuspendAllScan_A9232_Visible
		{
			get
			{
				short num = (short)488898560;
				short num2 = num;
				num = (short)1583724773;
				short num3 = num;
				num = (short)1424472293;
				switch (num3 == num)
				{
				}
				num = (short)1386086401;
				if (num != 0)
				{
				}
				num = (short)1919287296;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideSuspendAllScan_A9232.Visible;
			}
			set
			{
				short num = (short)254738432;
				short num2 = num;
				num = (short)394632109;
				short num3 = num;
				num = (short)1896324013;
				switch (num3 == num)
				{
				}
				num = (short)1875574785;
				if (num != 0)
				{
				}
				num = (short)281935872;
				if (num != 0)
				{
				}
				this.scanWideRadioWideSuspendAllScan_A9232.Visible = value;
			}
		}

		// Token: 0x1700139E RID: 5022
		// (get) Token: 0x06002724 RID: 10020 RVA: 0x00261804 File Offset: 0x0025FA04
		// (set) Token: 0x06002725 RID: 10021 RVA: 0x002618BC File Offset: 0x0025FABC
		public bool ScanWideRadioWideSuspendAllScan_A9232_Editable
		{
			get
			{
				short num = (short)1394409472;
				short num2 = num;
				num = (short)2026015790;
				short num3 = num;
				num = (short)909610030;
				switch (num3 == num)
				{
				}
				num = (short)1364131841;
				if (num != 0)
				{
				}
				num = (short)363659264;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideSuspendAllScan_A9232.Editable;
			}
			set
			{
				short num = (short)34996224;
				short num2 = num;
				num = (short)1018771789;
				short num3 = num;
				num = (short)996686157;
				switch (num3 == num)
				{
				}
				num = (short)1969029120;
				if (num != 0)
				{
				}
				num = (short)1088028673;
				if (num != 0)
				{
				}
				this.scanWideRadioWideSuspendAllScan_A9232.Editable = value;
			}
		}

		// Token: 0x1700139F RID: 5023
		// (get) Token: 0x06002726 RID: 10022 RVA: 0x00261970 File Offset: 0x0025FB70
		internal string ScanWideRadioWideSuspendAllScan_A9232_UILabel
		{
			get
			{
				short num = (short)834273280;
				short num2 = num;
				num = (short)1499515837;
				short num3 = num;
				num = (short)323668925;
				switch (num3 == num)
				{
				}
				num = (short)1068302336;
				if (num != 0)
				{
				}
				num = (short)1475084289;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideSuspendAllScan_A9232.UIName;
			}
		}

		// Token: 0x170013A0 RID: 5024
		// (get) Token: 0x06002727 RID: 10023 RVA: 0x00261A24 File Offset: 0x0025FC24
		// (set) Token: 0x06002728 RID: 10024 RVA: 0x00261AD8 File Offset: 0x0025FCD8
		internal bool ScanWideRadioWideSuspendAllScan_A9232_HiddenStatic
		{
			get
			{
				short num = (short)161742848;
				short num2 = num;
				num = (short)1452081153;
				if (num != 0)
				{
				}
				num = (short)53959496;
				short num3 = num;
				num = (short)1566071624;
				switch (num3 == num)
				{
				}
				num = (short)456720384;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideSuspendAllScan_A9232.HiddenStatic;
			}
			set
			{
				short num = (short)2061959168;
				short num2 = num;
				num = (short)1228341249;
				if (num != 0)
				{
				}
				num = (short)1624921908;
				short num3 = num;
				num = (short)1707956020;
				switch (num3 == num)
				{
				}
				num = (short)598278144;
				if (num != 0)
				{
				}
				this.scanWideRadioWideSuspendAllScan_A9232.HiddenStatic = value;
			}
		}

		// Token: 0x170013A1 RID: 5025
		// (get) Token: 0x06002729 RID: 10025 RVA: 0x00261B8C File Offset: 0x0025FD8C
		// (set) Token: 0x0600272A RID: 10026 RVA: 0x00261C40 File Offset: 0x0025FE40
		internal bool ScanWideRadioWideSuspendAllScan_A9232_HiddenDynamic
		{
			get
			{
				short num = (short)519045120;
				short num2 = num;
				num = (short)1718915396;
				short num3 = num;
				num = (short)1596494148;
				switch (num3 == num)
				{
				}
				num = (short)944373761;
				if (num != 0)
				{
				}
				num = (short)2027683840;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideSuspendAllScan_A9232.HiddenDynamic;
			}
			set
			{
				short num = (short)1724579840;
				short num2 = num;
				num = (short)61554706;
				short num3 = num;
				num = (short)2130001938;
				switch (num3 == num)
				{
				}
				num = (short)1152516097;
				if (num != 0)
				{
				}
				num = (short)929431552;
				if (num != 0)
				{
				}
				this.scanWideRadioWideSuspendAllScan_A9232.HiddenDynamic = value;
			}
		}

		// Token: 0x170013A2 RID: 5026
		// (get) Token: 0x0600272B RID: 10027 RVA: 0x00261CF4 File Offset: 0x0025FEF4
		public bool ScanWideRadioWideSuspendAllScan_A9232_HasDiffs
		{
			get
			{
				short num = (short)432013312;
				short num2 = num;
				num = (short)1704656897;
				if (num != 0)
				{
				}
				num = (short)317254890;
				short num3 = num;
				num = (short)1247276266;
				switch (num3 == num)
				{
				}
				num = (short)1082064896;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideSuspendAllScan_A9232._HasDiffs;
			}
		}

		// Token: 0x170013A3 RID: 5027
		// (get) Token: 0x0600272C RID: 10028 RVA: 0x00261DA4 File Offset: 0x0025FFA4
		// (set) Token: 0x0600272D RID: 10029 RVA: 0x00261E5C File Offset: 0x0026005C
		public int ScanWideRadioWideVoiceRxTxHoldTimeSec_A9653Value
		{
			get
			{
				short num = (short)2073362432;
				short num2 = num;
				num = (short)437337590;
				short num3 = num;
				num = (short)2072854006;
				switch (num3 == num)
				{
				}
				num = (short)1771044865;
				if (num != 0)
				{
				}
				num = (short)1128005632;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideVoiceRxTxHoldTimeSec_A9653.Value;
			}
			set
			{
				short num = (short)10485760;
				short num2 = num;
				num = (short)611001497;
				short num3 = num;
				num = (short)1907565721;
				switch (num3 == num)
				{
				}
				num = (short)1821376513;
				if (num != 0)
				{
				}
				num = (short)771751936;
				if (num != 0)
				{
				}
				this.scanWideRadioWideVoiceRxTxHoldTimeSec_A9653.Value = value;
			}
		}

		// Token: 0x170013A4 RID: 5028
		// (get) Token: 0x0600272E RID: 10030 RVA: 0x00261F10 File Offset: 0x00260110
		public global::AcpBusinessLayer.AcpSimpleRangeField ScanWideRadioWideVoiceRxTxHoldTimeSec_A9653
		{
			get
			{
				short num = (short)918421504;
				short num2 = num;
				num = (short)480920778;
				short num3 = num;
				num = (short)1461011658;
				switch (num3 == num)
				{
				}
				num = (short)723910657;
				if (num != 0)
				{
				}
				num = (short)1450835968;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideVoiceRxTxHoldTimeSec_A9653;
			}
		}

		// Token: 0x170013A5 RID: 5029
		// (get) Token: 0x0600272F RID: 10031 RVA: 0x00261FC0 File Offset: 0x002601C0
		// (set) Token: 0x06002730 RID: 10032 RVA: 0x00262074 File Offset: 0x00260274
		public string ScanWideRadioWideVoiceRxTxHoldTimeSec_A9653_UIValue
		{
			get
			{
				short num = (short)1614151680;
				short num2 = num;
				num = (short)220287225;
				short num3 = num;
				num = (short)1797673209;
				switch (num3 == num)
				{
				}
				num = (short)198770689;
				if (num != 0)
				{
				}
				num = (short)221052928;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideVoiceRxTxHoldTimeSec_A9653.UIValue;
			}
			set
			{
				short num = (short)1316356096;
				short num2 = num;
				num = (short)1980132016;
				short num3 = num;
				num = (short)835087024;
				switch (num3 == num)
				{
				}
				num = (short)1812070401;
				if (num != 0)
				{
				}
				num = (short)997851136;
				if (num != 0)
				{
				}
				this.scanWideRadioWideVoiceRxTxHoldTimeSec_A9653.UIValue = value;
			}
		}

		// Token: 0x170013A6 RID: 5030
		// (get) Token: 0x06002731 RID: 10033 RVA: 0x00262128 File Offset: 0x00260328
		// (set) Token: 0x06002732 RID: 10034 RVA: 0x002621DC File Offset: 0x002603DC
		internal int ScanWideRadioWideVoiceRxTxHoldTimeSec_A9653Min
		{
			get
			{
				short num = (short)1257111552;
				short num2 = num;
				num = (short)11631029;
				short num3 = num;
				num = (short)1600747957;
				switch (num3 == num)
				{
				}
				num = (short)1308360704;
				if (num != 0)
				{
				}
				num = (short)1008467969;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideVoiceRxTxHoldTimeSec_A9653.Min;
			}
			set
			{
				short num = (short)432144384;
				short num2 = num;
				num = (short)294516822;
				short num3 = num;
				num = (short)534902870;
				switch (num3 == num)
				{
				}
				num = (short)1943601153;
				if (num != 0)
				{
				}
				num = (short)1371471872;
				if (num != 0)
				{
				}
				this.scanWideRadioWideVoiceRxTxHoldTimeSec_A9653.Min = value;
			}
		}

		// Token: 0x170013A7 RID: 5031
		// (get) Token: 0x06002733 RID: 10035 RVA: 0x00262290 File Offset: 0x00260490
		// (set) Token: 0x06002734 RID: 10036 RVA: 0x00262348 File Offset: 0x00260548
		internal int ScanWideRadioWideVoiceRxTxHoldTimeSec_A9653Max
		{
			get
			{
				short num = (short)1627586560;
				short num2 = num;
				num = (short)1423857969;
				short num3 = num;
				num = (short)1122982193;
				switch (num3 == num)
				{
				}
				num = (short)259981313;
				if (num != 0)
				{
				}
				num = (short)2064252928;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideVoiceRxTxHoldTimeSec_A9653.Max;
			}
			set
			{
				short num = (short)1170604032;
				short num2 = num;
				num = (short)1247019009;
				if (num != 0)
				{
				}
				num = (short)225668853;
				short num3 = num;
				num = (short)1391423221;
				switch (num3 == num)
				{
				}
				num = (short)1190526976;
				if (num != 0)
				{
				}
				this.scanWideRadioWideVoiceRxTxHoldTimeSec_A9653.Max = value;
			}
		}

		// Token: 0x170013A8 RID: 5032
		// (get) Token: 0x06002735 RID: 10037 RVA: 0x002623FC File Offset: 0x002605FC
		// (set) Token: 0x06002736 RID: 10038 RVA: 0x002624B0 File Offset: 0x002606B0
		internal int ScanWideRadioWideVoiceRxTxHoldTimeSec_A9653Step
		{
			get
			{
				short num = (short)600768512;
				short num2 = num;
				num = (short)718313354;
				short num3 = num;
				num = (short)2107479946;
				switch (num3 == num)
				{
				}
				num = (short)1151598593;
				if (num != 0)
				{
				}
				num = (short)1827930112;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideVoiceRxTxHoldTimeSec_A9653.StepSize;
			}
			set
			{
				short num = (short)1835859968;
				short num2 = num;
				num = (short)2051575321;
				short num3 = num;
				num = (short)1933807129;
				switch (num3 == num)
				{
				}
				num = (short)2029715457;
				if (num != 0)
				{
				}
				num = (short)862519296;
				if (num != 0)
				{
				}
				this.scanWideRadioWideVoiceRxTxHoldTimeSec_A9653.StepSize = value;
			}
		}

		// Token: 0x170013A9 RID: 5033
		// (get) Token: 0x06002737 RID: 10039 RVA: 0x00262568 File Offset: 0x00260768
		// (set) Token: 0x06002738 RID: 10040 RVA: 0x00262620 File Offset: 0x00260820
		public bool ScanWideRadioWideVoiceRxTxHoldTimeSec_A9653_Applicable
		{
			get
			{
				short num = (short)1677983744;
				short num2 = num;
				num = (short)773787753;
				short num3 = num;
				num = (short)677515369;
				switch (num3 == num)
				{
				}
				num = (short)1376911361;
				if (num != 0)
				{
				}
				num = (short)604110848;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideVoiceRxTxHoldTimeSec_A9653.Applicable;
			}
			set
			{
				short num = (short)169607168;
				short num2 = num;
				num = (short)35538235;
				short num3 = num;
				num = (short)754271547;
				switch (num3 == num)
				{
				}
				num = (short)1547304961;
				if (num != 0)
				{
				}
				num = (short)409075712;
				if (num != 0)
				{
				}
				this.scanWideRadioWideVoiceRxTxHoldTimeSec_A9653.Applicable = value;
			}
		}

		// Token: 0x170013AA RID: 5034
		// (get) Token: 0x06002739 RID: 10041 RVA: 0x002626D4 File Offset: 0x002608D4
		// (set) Token: 0x0600273A RID: 10042 RVA: 0x00262788 File Offset: 0x00260988
		public bool ScanWideRadioWideVoiceRxTxHoldTimeSec_A9653_Valid
		{
			get
			{
				short num = (short)612630528;
				short num2 = num;
				num = (short)871164466;
				short num3 = num;
				num = (short)1687087666;
				switch (num3 == num)
				{
				}
				num = (short)14811136;
				if (num != 0)
				{
				}
				num = (short)1696464897;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideVoiceRxTxHoldTimeSec_A9653.Valid;
			}
			set
			{
				short num = (short)319094784;
				short num2 = num;
				num = (short)667099063;
				short num3 = num;
				num = (short)1262034871;
				switch (num3 == num)
				{
				}
				num = (short)153026561;
				if (num != 0)
				{
				}
				num = (short)12648448;
				if (num != 0)
				{
				}
				this.scanWideRadioWideVoiceRxTxHoldTimeSec_A9653.Valid = value;
			}
		}

		// Token: 0x170013AB RID: 5035
		// (get) Token: 0x0600273B RID: 10043 RVA: 0x00262840 File Offset: 0x00260A40
		// (set) Token: 0x0600273C RID: 10044 RVA: 0x002628F8 File Offset: 0x00260AF8
		public bool ScanWideRadioWideVoiceRxTxHoldTimeSec_A9653_Visible
		{
			get
			{
				short num = (short)48300032;
				short num2 = num;
				num = (short)1871319433;
				short num3 = num;
				num = (short)353440137;
				switch (num3 == num)
				{
				}
				num = (short)1571160064;
				if (num != 0)
				{
				}
				num = (short)581763073;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideVoiceRxTxHoldTimeSec_A9653.Visible;
			}
			set
			{
				short num = (short)394592256;
				short num2 = num;
				num = (short)1643143958;
				short num3 = num;
				num = (short)1249141526;
				switch (num3 == num)
				{
				}
				num = (short)947453953;
				if (num != 0)
				{
				}
				num = (short)532545536;
				if (num != 0)
				{
				}
				this.scanWideRadioWideVoiceRxTxHoldTimeSec_A9653.Visible = value;
			}
		}

		// Token: 0x170013AC RID: 5036
		// (get) Token: 0x0600273D RID: 10045 RVA: 0x002629AC File Offset: 0x00260BAC
		// (set) Token: 0x0600273E RID: 10046 RVA: 0x00262A60 File Offset: 0x00260C60
		public bool ScanWideRadioWideVoiceRxTxHoldTimeSec_A9653_Editable
		{
			get
			{
				short num = (short)511639552;
				short num2 = num;
				num = (short)1920621654;
				short num3 = num;
				num = (short)809720918;
				switch (num3 == num)
				{
				}
				num = (short)1663238145;
				if (num != 0)
				{
				}
				num = (short)1520107520;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideVoiceRxTxHoldTimeSec_A9653.Editable;
			}
			set
			{
				short num = (short)927858688;
				short num2 = num;
				num = (short)181591942;
				short num3 = num;
				num = (short)527294342;
				switch (num3 == num)
				{
				}
				num = (short)123666432;
				if (num != 0)
				{
				}
				num = (short)1602945025;
				if (num != 0)
				{
				}
				this.scanWideRadioWideVoiceRxTxHoldTimeSec_A9653.Editable = value;
			}
		}

		// Token: 0x170013AD RID: 5037
		// (get) Token: 0x0600273F RID: 10047 RVA: 0x00262B14 File Offset: 0x00260D14
		internal string ScanWideRadioWideVoiceRxTxHoldTimeSec_A9653_UILabel
		{
			get
			{
				short num = (short)277020672;
				short num2 = num;
				num = (short)148850333;
				short num3 = num;
				num = (short)1481197213;
				switch (num3 == num)
				{
				}
				num = (short)1464532993;
				if (num != 0)
				{
				}
				num = (short)1259667456;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideVoiceRxTxHoldTimeSec_A9653.UIName;
			}
		}

		// Token: 0x170013AE RID: 5038
		// (get) Token: 0x06002740 RID: 10048 RVA: 0x00262BC8 File Offset: 0x00260DC8
		// (set) Token: 0x06002741 RID: 10049 RVA: 0x00262C80 File Offset: 0x00260E80
		internal bool ScanWideRadioWideVoiceRxTxHoldTimeSec_A9653_HiddenStatic
		{
			get
			{
				short num = (short)399966208;
				short num2 = num;
				num = (short)1201929892;
				short num3 = num;
				num = (short)1779826340;
				switch (num3 == num)
				{
				}
				num = (short)574947328;
				if (num != 0)
				{
				}
				num = (short)609091585;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideVoiceRxTxHoldTimeSec_A9653.HiddenStatic;
			}
			set
			{
				short num = (short)1001521152;
				short num2 = num;
				num = (short)1120440352;
				short num3 = num;
				num = (short)901419040;
				switch (num3 == num)
				{
				}
				num = (short)1785528321;
				if (num != 0)
				{
				}
				num = (short)1903099904;
				if (num != 0)
				{
				}
				this.scanWideRadioWideVoiceRxTxHoldTimeSec_A9653.HiddenStatic = value;
			}
		}

		// Token: 0x170013AF RID: 5039
		// (get) Token: 0x06002742 RID: 10050 RVA: 0x00262D34 File Offset: 0x00260F34
		// (set) Token: 0x06002743 RID: 10051 RVA: 0x00262DEC File Offset: 0x00260FEC
		internal bool ScanWideRadioWideVoiceRxTxHoldTimeSec_A9653_HiddenDynamic
		{
			get
			{
				short num = (short)1379926016;
				short num2 = num;
				num = (short)1652344889;
				short num3 = num;
				num = (short)554158137;
				switch (num3 == num)
				{
				}
				num = (short)1071841281;
				if (num != 0)
				{
				}
				num = (short)99811328;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideVoiceRxTxHoldTimeSec_A9653.HiddenDynamic;
			}
			set
			{
				short num = (short)1966276608;
				short num2 = num;
				num = (short)1575623930;
				short num3 = num;
				num = (short)1152195834;
				switch (num3 == num)
				{
				}
				num = (short)1615003649;
				if (num != 0)
				{
				}
				num = (short)1964376064;
				if (num != 0)
				{
				}
				this.scanWideRadioWideVoiceRxTxHoldTimeSec_A9653.HiddenDynamic = value;
			}
		}

		// Token: 0x170013B0 RID: 5040
		// (get) Token: 0x06002744 RID: 10052 RVA: 0x00262EA4 File Offset: 0x002610A4
		public bool ScanWideRadioWideVoiceRxTxHoldTimeSec_A9653_HasDiffs
		{
			get
			{
				short num = (short)553123840;
				short num2 = num;
				num = (short)616169473;
				if (num != 0)
				{
				}
				num = (short)1043616805;
				short num3 = num;
				num = (short)6116389;
				switch (num3 == num)
				{
				}
				num = (short)2003369984;
				if (num != 0)
				{
				}
				return this.scanWideRadioWideVoiceRxTxHoldTimeSec_A9653._HasDiffs;
			}
		}

		// Token: 0x170013B1 RID: 5041
		// (get) Token: 0x06002745 RID: 10053 RVA: 0x00262F58 File Offset: 0x00261158
		public global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide RefRadioWide
		{
			get
			{
				short num = (short)1428815872;
				short num2 = num;
				num = (short)167499704;
				short num3 = num;
				num = (short)478730168;
				switch (num3 == num)
				{
				}
				num = (short)2139422721;
				if (num != 0)
				{
				}
				num = (short)989331456;
				if (num != 0)
				{
				}
				return global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
			}
		}

		// Token: 0x06002746 RID: 10054 RVA: 0x00263018 File Offset: 0x00261218
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			short num2;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
				{
					num2 = (short)445186048;
					short num3 = num2;
					if (base.ParentRecset != null)
					{
						num2 = (short)144048130;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13F;
				}
				case 1:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)1570242564;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)2082406403;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)383844353;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13F;
				case 4:
					goto IL_FE;
				}
				break;
			}
			IL_24:
			num2 = (short)400911356;
			short num4 = num2;
			num2 = (short)1366322172;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_FE:
				break;
			default:
			{
				num2 = (short)561577984;
				if (num2 != 0)
				{
				}
				result = null;
				num2 = (short)1160052736;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
			IL_13F:
			num2 = (short)1250426881;
			if (num2 != 0)
			{
			}
			return result;
		}

		// Token: 0x04000E5D RID: 3677
		private global::AcpBusinessLayer.AcpSimpleRangeField scanWideRadioWideDataRxTxHoldTimesec_A7797;

		// Token: 0x04000E5E RID: 3678
		private global::AcpBusinessLayer.AcpField<bool> scanWideRadioWideHUBSuspendsScan_A8216;

		// Token: 0x04000E5F RID: 3679
		private global::AcpBusinessLayer.AcpField<bool> scanWideRadioWidePriorityScanAlert_A8752;

		// Token: 0x04000E60 RID: 3680
		private global::AcpBusinessLayer.AcpField<bool> scanWideRadioWideSuspendAllScan_A9232;

		// Token: 0x04000E61 RID: 3681
		private global::AcpBusinessLayer.AcpSimpleRangeField scanWideRadioWideVoiceRxTxHoldTimeSec_A9653;
	}
}
