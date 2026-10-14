using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioInformation
{
	// Token: 0x020001B0 RID: 432
	[global::System.Serializable]
	public class Tracking : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060050C7 RID: 20679 RVA: 0x00498BE8 File Offset: 0x00496DE8
		public Tracking(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060050C8 RID: 20680 RVA: 0x00498C04 File Offset: 0x00496E04
		protected Tracking(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060050C9 RID: 20681 RVA: 0x00498C1C File Offset: 0x00496E1C
		public override void Init()
		{
			int a_ = 2;
			short num = (short)200758992;
			short num2 = num;
			num = (short)1270175440;
			switch (num2 == num)
			{
			}
			num = (short)190513152;
			short num3 = num;
			num = (short)173932544;
			if (num != 0)
			{
			}
			num = (short)555483137;
			if (num != 0)
			{
			}
			this.radInfoLabtoolBornOnDateDBValue_A7568 = new global::AcpBusinessLayer.AcpFieldX<long, string>(0L, new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.DateTimeFormatConverter(), this, global::AllFeatures.CodeplugGuid.b("釂꓄ꏆ胈ꗊꯌꃎ鷐닒럔ꏖ뛘듚뇜鷞軠釢诤꣦蟨꿪賬鯮铰럲럴ꇶ飸韺裼髾帀䈂㈄㈆㼈㌊", a_), global::CommonResources.AcgResources.ID_ORIGINALPROGRAMMEDINFORMATIONBORNONTIMEANDDATE);
			this.radInfoLabtoolBornOnDateDBValue_A7568.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoLabtoolBornOnDateDBValue_A7568.DataTransferOrder = -1;
			this.radInfoTrackingCodeplugVersion_A7688 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_XPPPPPPPP, this, global::AllFeatures.CodeplugGuid.b("釂꓄ꏆ胈ꗊꯌꃎ藐ꇒ듔듖님닚돜룞ꋠ賢臤苦駨蟪飬裮꟰雲蟴蓶郸铺鏼ꃾ䀀㐂㌄㼆ㄈ", a_), global::CommonResources.AcgResources.ID_ORIGINALPROGRAMMEDINFORMATIONCODEPLUGVERSION, 12);
			this.radInfoTrackingCodeplugVersion_A7688.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoTrackingCodeplugVersion_A7688.DataTransferOrder = -1;
			this.radInfoLabtoolLastProgrammedDateDBValue_A8411 = new global::AcpBusinessLayer.AcpFieldX<long, string>(0L, new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.DateTimeFormatConverter(), this, global::AllFeatures.CodeplugGuid.b("釂꓄ꏆ胈ꗊꯌꃎ鷐닒럔ꏖ뛘듚뇜鏞胠郢釤럦鯨蓪諬鷮郰黲飴鋶鷸뿺鳼课搀䜂䜄儆栈朊砌樎丐划ⴔ⌖⠘⨚", a_), global::CommonResources.AcgResources.ID_LASTPROGRAMMEDINFORMATIONLASTPROGRAMMEDTIMEANDDATE);
			this.radInfoLabtoolLastProgrammedDateDBValue_A8411.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoLabtoolLastProgrammedDateDBValue_A8411.DataTransferOrder = -1;
			this.radInfoTrackingSource2_A8625 = new global::AcpBusinessLayer.AcpFieldX<int, string>(3, new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.UnpackAndpackExtProgmgSrc(), this, global::AllFeatures.CodeplugGuid.b("釂꓄ꏆ胈ꗊꯌꃎ藐ꇒ듔듖님닚돜룞닠賢郤闦諨軪\udfec냮냰쯲쏴엶쳸", a_), global::CommonResources.AcgResources.ID_ORIGINALPROGRAMMEDINFORMATIONSOURCE);
			this.radInfoTrackingSource2_A8625.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoTrackingSource2_A8625.DataTransferOrder = -1;
			this.radInfoTrackingSource1_A9171 = new global::AcpBusinessLayer.AcpFieldX<int, string>(3, new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.UnpackAndpackExtProgmgSrc(), this, global::AllFeatures.CodeplugGuid.b("釂꓄ꏆ胈ꗊꯌꃎ藐ꇒ듔듖님닚돜룞닠賢郤闦諨軪\udcec냮냰쫲쓴샶죸", a_), global::CommonResources.AcgResources.ID_LASTPROGRAMMEDINFORMATIONSOURCE);
			this.radInfoTrackingSource1_A9171.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
			this.radInfoTrackingSource1_A9171.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("韂럄ꛆ꫈ꃊ꓌ꇎ뛐", a_);
			base.Id = 10109;
			base.UIName = global::CommonResources.AcgResources.ID_TRACKING;
			base.DataTransferOrder = 6;
		}

		// Token: 0x060050CA RID: 20682 RVA: 0x00498E34 File Offset: 0x00497034
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 1;
			short num = (short)829489170;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ臇꓉꫋ꇍ鳏돑뛓ꋕ럗뗙냛鳝迟郡諣ꧥ蛧껩跫髭闯뛱뛳ꃵ駷雹觻鯽忿䌁㌃㌅㸇㈉", a_)))
					{
						num = (short)1006043147;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_442;
				case 1:
					num = (short)373424130;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (producerFields != null)
					{
						num = (short)709558276;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4B7;
				case 3:
					this.radInfoTrackingSource1_A9171 = new global::AcpBusinessLayer.AcpFieldX<int, string>(3, new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.UnpackAndpackExtProgmgSrc(), this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ臇꓉꫋ꇍ蓏ꃑ뗓뗕돗동닛망돟跡釣铥诧迩\uddeb뇭뇯쯱엳쇵짷", a_), global::CommonResources.AcgResources.ID_LASTPROGRAMMEDINFORMATIONSOURCE);
					this.radInfoTrackingSource1_A9171.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoTrackingSource1_A9171.DataTransferOrder = -1;
					num = (short)1122631690;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)2040856576;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					this.radInfoTrackingSource2_A8625 = new global::AcpBusinessLayer.AcpFieldX<int, string>(3, new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.UnpackAndpackExtProgmgSrc(), this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ臇꓉꫋ꇍ蓏ꃑ뗓뗕돗동닛망돟跡釣铥诧迩\udeeb뇭뇯쫱싳쓵췷", a_), global::CommonResources.AcgResources.ID_ORIGINALPROGRAMMEDINFORMATIONSOURCE);
					this.radInfoTrackingSource2_A8625.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoTrackingSource2_A8625.DataTransferOrder = -1;
					num = (short)485949455;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ臇꓉꫋ꇍ蓏ꃑ뗓뗕돗동닛망돟跡釣铥诧迩\udeeb뇭뇯쫱싳쓵췷", a_)))
					{
						num = (short)1623785477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F8;
				case 7:
				{
					num = (short)1474348340;
					short num3 = num;
					num = (short)2066203956;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_84;
					default:
						num = (short)85786624;
						if (num != 0)
						{
						}
						if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ臇꓉꫋ꇍ鳏돑뛓ꋕ럗뗙냛鋝臟釡郣뛥髧藩诫鳭釯鿱駳鏵鳷뻹鷻諽旿䘁䘃倅椇昉礋欍伏匑Ⱃ∕⤗⬙", a_)))
						{
							num = (short)770965504;
							short num4 = num;
							num = (short)938672145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9D;
					}
					break;
				}
				case 8:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ臇꓉꫋ꇍ蓏ꃑ뗓뗕돗동닛망돟跡釣铥诧迩\uddeb뇭뇯쯱엳쇵짷", a_)))
					{
						num = (short)1998389251;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4B7;
				case 9:
					goto IL_442;
				case 10:
					goto IL_32E;
				case 11:
					this.radInfoLabtoolBornOnDateDBValue_A7568 = new global::AcpBusinessLayer.AcpFieldX<long, string>(0L, new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.DateTimeFormatConverter(), this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ臇꓉꫋ꇍ鳏돑뛓ꋕ럗뗙냛鳝迟郡諣ꧥ蛧껩跫髭闯뛱뛳ꃵ駷雹觻鯽忿䌁㌃㌅㸇㈉", a_), global::CommonResources.AcgResources.ID_ORIGINALPROGRAMMEDINFORMATIONBORNONTIMEANDDATE);
					this.radInfoLabtoolBornOnDateDBValue_A7568.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoLabtoolBornOnDateDBValue_A7568.DataTransferOrder = -1;
					num = (short)891682825;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					goto IL_9D;
				case 13:
					goto IL_EA;
				case 14:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ臇꓉꫋ꇍ蓏ꃑ뗓뗕돗동닛망ꏟ跡胣菥飧蛩駫觭ꛯ韱蛳藵釷闹鋻ꇽ䇿㔁㈃㸅〇", a_)))
					{
						num = (short)1826357264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EA;
				case 15:
					goto IL_1F8;
				case 16:
					num = (short)1580990465;
					if (num != 0)
					{
					}
					this.radInfoTrackingCodeplugVersion_A7688 = new global::AcpBusinessLayer.AcpStringField(global::CommonResources.AcgResources.ID_XPPPPPPPP, this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ臇꓉꫋ꇍ蓏ꃑ뗓뗕돗동닛망ꏟ跡胣菥飧蛩駫觭ꛯ韱蛳藵釷闹鋻ꇽ䇿㔁㈃㸅〇", a_), global::CommonResources.AcgResources.ID_ORIGINALPROGRAMMEDINFORMATIONCODEPLUGVERSION, 12);
					this.radInfoTrackingCodeplugVersion_A7688.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoTrackingCodeplugVersion_A7688.DataTransferOrder = -1;
					num = (short)689831949;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					this.radInfoLabtoolLastProgrammedDateDBValue_A8411 = new global::AcpBusinessLayer.AcpFieldX<long, string>(0L, new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.DateTimeFormatConverter(), this, global::AllFeatures.CodeplugGuid.b("郁ꗃꋅ臇꓉꫋ꇍ鳏돑뛓ꋕ럗뗙냛鋝臟釡郣뛥髧藩诫鳭釯鿱駳鏵鳷뻹鷻諽旿䘁䘃倅椇昉礋欍伏匑Ⱃ∕⤗⬙", a_), global::CommonResources.AcgResources.ID_LASTPROGRAMMEDINFORMATIONLASTPROGRAMMEDTIMEANDDATE);
					this.radInfoLabtoolLastProgrammedDateDBValue_A8411.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Basic;
					this.radInfoLabtoolLastProgrammedDateDBValue_A8411.DataTransferOrder = -1;
					num = (short)1752694796;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					switch (0)
					{
					case 0:
						goto IL_7A;
					}
					continue;
				}
				goto IL_7A;
				IL_84:
				num = (short)914882561;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7A:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					goto IL_84;
				}
				break;
				IL_9D:
				num = (short)1588133894;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_EA:
				num = (short)300875783;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1F8:
				num = (short)14286856;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_442:
				num = (short)2078015502;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_32E:
			IL_4B7:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("雁뛃Ʂꯇꇉꗋꃍ럏", a_);
			base.Id = 10109;
			base.UIName = global::CommonResources.AcgResources.ID_TRACKING;
			base.DataTransferOrder = 6;
		}

		// Token: 0x060050CB RID: 20683 RVA: 0x0049932C File Offset: 0x0049752C
		public override void PopulateReferences()
		{
			short num = (short)170224590;
			short num2 = num;
			num = (short)1430940622;
			switch (num2 == num)
			{
			}
			num = (short)1154351105;
			if (num != 0)
			{
			}
			num = (short)1770848256;
			if (num != 0)
			{
			}
			num = (short)639172608;
			short num3 = num;
		}

		// Token: 0x060050CC RID: 20684 RVA: 0x004993D8 File Offset: 0x004975D8
		public override void DropReferences()
		{
			short num = (short)1296087454;
			short num2 = num;
			num = (short)1810872734;
			switch (num2 == num)
			{
			}
			num = (short)1027473409;
			if (num != 0)
			{
			}
			num = (short)1701052416;
			if (num != 0)
			{
			}
			num = (short)1567686656;
			short num3 = num;
		}

		// Token: 0x060050CD RID: 20685 RVA: 0x00499484 File Offset: 0x00497684
		public override void SetConstraints()
		{
			short num = (short)2136657160;
			short num2 = num;
			num = (short)137809160;
			switch (num2 == num)
			{
			}
			num = (short)505413633;
			if (num != 0)
			{
			}
			num = (short)41680896;
			if (num != 0)
			{
			}
			num = (short)1693188096;
			short num3 = num;
			this.radInfoLabtoolBornOnDateDBValue_A7568.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoTrackingCodeplugVersion_A7688.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoLabtoolLastProgrammedDateDBValue_A8411.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoTrackingSource2_A8625.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoTrackingSource1_A9171.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x060050CE RID: 20686 RVA: 0x004995A0 File Offset: 0x004977A0
		public override void SetupDependencies()
		{
			short num = (short)1217462273;
			if (num != 0)
			{
			}
			num = (short)328017888;
			short num2 = num;
			num = (short)1228875744;
			switch (num2 == num)
			{
			}
			num = (short)1450508288;
			if (num != 0)
			{
			}
			num = (short)426901504;
			short num3 = num;
		}

		// Token: 0x17002A05 RID: 10757
		// (get) Token: 0x060050CF RID: 20687 RVA: 0x0049964C File Offset: 0x0049784C
		public bool HasDiffs
		{
			get
			{
				short num = (short)1868617984;
				short num2 = num;
				num = (short)1277614336;
				switch (num2 == num)
				{
				}
				num = (short)646381568;
				if (num != 0)
				{
				}
				num = (short)388825089;
				if (num != 0)
				{
				}
				num = (short)1311899648;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17002A06 RID: 10758
		// (get) Token: 0x060050D0 RID: 20688 RVA: 0x004996F8 File Offset: 0x004978F8
		// (set) Token: 0x060050D1 RID: 20689 RVA: 0x004997AC File Offset: 0x004979AC
		public long RadInfoLabtoolBornOnDateDBValue_A7568Value
		{
			get
			{
				short num = (short)586066356;
				short num2 = num;
				num = (short)735619508;
				switch (num2 == num)
				{
				}
				num = (short)1130692609;
				if (num != 0)
				{
				}
				num = (short)817430528;
				if (num != 0)
				{
				}
				num = (short)1984036864;
				short num3 = num;
				return this.radInfoLabtoolBornOnDateDBValue_A7568.Value;
			}
			set
			{
				short num = (short)1058872226;
				short num2 = num;
				num = (short)194386850;
				switch (num2 == num)
				{
				}
				num = (short)596574209;
				if (num != 0)
				{
				}
				num = (short)1658191872;
				if (num != 0)
				{
				}
				num = (short)412090368;
				short num3 = num;
				this.radInfoLabtoolBornOnDateDBValue_A7568.Value = value;
			}
		}

		// Token: 0x17002A07 RID: 10759
		// (get) Token: 0x060050D2 RID: 20690 RVA: 0x00499864 File Offset: 0x00497A64
		public global::AcpBusinessLayer.AcpFieldX<long, string> RadInfoLabtoolBornOnDateDBValue_A7568
		{
			get
			{
				short num = (short)939488848;
				short num2 = num;
				num = (short)1025668688;
				switch (num2 == num)
				{
				}
				num = (short)1016004609;
				if (num != 0)
				{
				}
				num = (short)1000603648;
				if (num != 0)
				{
				}
				num = (short)625213440;
				short num3 = num;
				return this.radInfoLabtoolBornOnDateDBValue_A7568;
			}
		}

		// Token: 0x17002A08 RID: 10760
		// (get) Token: 0x060050D3 RID: 20691 RVA: 0x00499914 File Offset: 0x00497B14
		// (set) Token: 0x060050D4 RID: 20692 RVA: 0x004999C8 File Offset: 0x00497BC8
		public string RadInfoLabtoolBornOnDateDBValue_A7568_UIValue
		{
			get
			{
				short num = (short)1239154689;
				if (num != 0)
				{
				}
				num = (short)564434091;
				short num2 = num;
				num = (short)894342315;
				switch (num2 == num)
				{
				}
				num = (short)1136787456;
				if (num != 0)
				{
				}
				num = (short)1353515008;
				short num3 = num;
				return this.radInfoLabtoolBornOnDateDBValue_A7568.UIValue;
			}
			set
			{
				short num = (short)962980308;
				short num2 = num;
				num = (short)797829588;
				switch (num2 == num)
				{
				}
				num = (short)647102464;
				if (num != 0)
				{
				}
				num = (short)183566337;
				if (num != 0)
				{
				}
				num = (short)1705377792;
				short num3 = num;
				this.radInfoLabtoolBornOnDateDBValue_A7568.UIValue = value;
			}
		}

		// Token: 0x17002A09 RID: 10761
		// (get) Token: 0x060050D5 RID: 20693 RVA: 0x00499A7C File Offset: 0x00497C7C
		// (set) Token: 0x060050D6 RID: 20694 RVA: 0x00499B30 File Offset: 0x00497D30
		public bool RadInfoLabtoolBornOnDateDBValue_A7568_Applicable
		{
			get
			{
				short num = (short)406495562;
				short num2 = num;
				num = (short)1432396106;
				switch (num2 == num)
				{
				}
				num = (short)1977352192;
				if (num != 0)
				{
				}
				num = (short)1416429569;
				if (num != 0)
				{
				}
				num = (short)122486784;
				short num3 = num;
				return this.radInfoLabtoolBornOnDateDBValue_A7568.Applicable;
			}
			set
			{
				short num = (short)2135692940;
				short num2 = num;
				num = (short)846927500;
				switch (num2 == num)
				{
				}
				num = (short)887619585;
				if (num != 0)
				{
				}
				num = (short)402915328;
				if (num != 0)
				{
				}
				num = (short)1892352000;
				short num3 = num;
				this.radInfoLabtoolBornOnDateDBValue_A7568.Applicable = value;
			}
		}

		// Token: 0x17002A0A RID: 10762
		// (get) Token: 0x060050D7 RID: 20695 RVA: 0x00499BE4 File Offset: 0x00497DE4
		// (set) Token: 0x060050D8 RID: 20696 RVA: 0x00499C98 File Offset: 0x00497E98
		public bool RadInfoLabtoolBornOnDateDBValue_A7568_Valid
		{
			get
			{
				short num = (short)1729774628;
				short num2 = num;
				num = (short)748241956;
				switch (num2 == num)
				{
				}
				num = (short)828243968;
				if (num != 0)
				{
				}
				num = (short)1694105601;
				if (num != 0)
				{
				}
				num = (short)191430656;
				short num3 = num;
				return this.radInfoLabtoolBornOnDateDBValue_A7568.Valid;
			}
			set
			{
				short num = (short)1462244445;
				short num2 = num;
				num = (short)763106397;
				switch (num2 == num)
				{
				}
				num = (short)853671936;
				if (num != 0)
				{
				}
				num = (short)1994260481;
				if (num != 0)
				{
				}
				num = (short)2027880448;
				short num3 = num;
				this.radInfoLabtoolBornOnDateDBValue_A7568.Valid = value;
			}
		}

		// Token: 0x17002A0B RID: 10763
		// (get) Token: 0x060050D9 RID: 20697 RVA: 0x00499D4C File Offset: 0x00497F4C
		// (set) Token: 0x060050DA RID: 20698 RVA: 0x00499E00 File Offset: 0x00498000
		public bool RadInfoLabtoolBornOnDateDBValue_A7568_Visible
		{
			get
			{
				short num = (short)376569857;
				if (num != 0)
				{
				}
				num = (short)922362311;
				short num2 = num;
				num = (short)1964581319;
				switch (num2 == num)
				{
				}
				num = (short)1006305280;
				if (num != 0)
				{
				}
				num = (short)642580480;
				short num3 = num;
				return this.radInfoLabtoolBornOnDateDBValue_A7568.Visible;
			}
			set
			{
				short num = (short)1791035646;
				short num2 = num;
				num = (short)998181118;
				switch (num2 == num)
				{
				}
				num = (short)694812672;
				if (num != 0)
				{
				}
				num = (short)1448476673;
				if (num != 0)
				{
				}
				num = (short)31391744;
				short num3 = num;
				this.radInfoLabtoolBornOnDateDBValue_A7568.Visible = value;
			}
		}

		// Token: 0x17002A0C RID: 10764
		// (get) Token: 0x060050DB RID: 20699 RVA: 0x00499EB4 File Offset: 0x004980B4
		// (set) Token: 0x060050DC RID: 20700 RVA: 0x00499F68 File Offset: 0x00498168
		public bool RadInfoLabtoolBornOnDateDBValue_A7568_Editable
		{
			get
			{
				short num = (short)207945729;
				if (num != 0)
				{
				}
				num = (short)364697231;
				short num2 = num;
				num = (short)1862719119;
				switch (num2 == num)
				{
				}
				num = (short)1019543552;
				if (num != 0)
				{
				}
				num = (short)1112211456;
				short num3 = num;
				return this.radInfoLabtoolBornOnDateDBValue_A7568.Editable;
			}
			set
			{
				short num = (short)656733557;
				short num2 = num;
				num = (short)447804789;
				switch (num2 == num)
				{
				}
				num = (short)543555585;
				if (num != 0)
				{
				}
				num = (short)1076428800;
				if (num != 0)
				{
				}
				num = (short)1080950784;
				short num3 = num;
				this.radInfoLabtoolBornOnDateDBValue_A7568.Editable = value;
			}
		}

		// Token: 0x17002A0D RID: 10765
		// (get) Token: 0x060050DD RID: 20701 RVA: 0x0049A01C File Offset: 0x0049821C
		internal string RadInfoLabtoolBornOnDateDBValue_A7568_UILabel
		{
			get
			{
				short num = (short)1426538625;
				short num2 = num;
				num = (short)386285697;
				switch (num2 == num)
				{
				}
				num = (short)727384064;
				if (num != 0)
				{
				}
				num = (short)45613057;
				if (num != 0)
				{
				}
				num = (short)1612644352;
				short num3 = num;
				return this.radInfoLabtoolBornOnDateDBValue_A7568.UIName;
			}
		}

		// Token: 0x17002A0E RID: 10766
		// (get) Token: 0x060050DE RID: 20702 RVA: 0x0049A0D0 File Offset: 0x004982D0
		// (set) Token: 0x060050DF RID: 20703 RVA: 0x0049A184 File Offset: 0x00498384
		internal bool RadInfoLabtoolBornOnDateDBValue_A7568_HiddenStatic
		{
			get
			{
				short num = (short)601923697;
				short num2 = num;
				num = (short)958570609;
				switch (num2 == num)
				{
				}
				num = (short)2038235137;
				if (num != 0)
				{
				}
				num = (short)1319305216;
				if (num != 0)
				{
				}
				num = (short)961806336;
				short num3 = num;
				return this.radInfoLabtoolBornOnDateDBValue_A7568.HiddenStatic;
			}
			set
			{
				short num = (short)1762748477;
				short num2 = num;
				num = (short)1352099901;
				switch (num2 == num)
				{
				}
				num = (short)562167808;
				if (num != 0)
				{
				}
				num = (short)600899585;
				if (num != 0)
				{
				}
				num = (short)1702428672;
				short num3 = num;
				this.radInfoLabtoolBornOnDateDBValue_A7568.HiddenStatic = value;
			}
		}

		// Token: 0x17002A0F RID: 10767
		// (get) Token: 0x060050E0 RID: 20704 RVA: 0x0049A238 File Offset: 0x00498438
		// (set) Token: 0x060050E1 RID: 20705 RVA: 0x0049A2EC File Offset: 0x004984EC
		internal bool RadInfoLabtoolBornOnDateDBValue_A7568_HiddenDynamic
		{
			get
			{
				short num = (short)1119288350;
				short num2 = num;
				num = (short)1855257630;
				switch (num2 == num)
				{
				}
				num = (short)129695745;
				if (num != 0)
				{
				}
				num = (short)1855324160;
				if (num != 0)
				{
				}
				num = (short)281214976;
				short num3 = num;
				return this.radInfoLabtoolBornOnDateDBValue_A7568.HiddenDynamic;
			}
			set
			{
				short num = (short)1693846208;
				short num2 = num;
				num = (short)1464928960;
				switch (num2 == num)
				{
				}
				num = (short)2090205185;
				if (num != 0)
				{
				}
				num = (short)2112684032;
				if (num != 0)
				{
				}
				num = (short)1979973632;
				short num3 = num;
				this.radInfoLabtoolBornOnDateDBValue_A7568.HiddenDynamic = value;
			}
		}

		// Token: 0x17002A10 RID: 10768
		// (get) Token: 0x060050E2 RID: 20706 RVA: 0x0049A3A0 File Offset: 0x004985A0
		public bool RadInfoLabtoolBornOnDateDBValue_A7568_HasDiffs
		{
			get
			{
				short num = (short)1913831465;
				short num2 = num;
				num = (short)2136195113;
				switch (num2 == num)
				{
				}
				num = (short)1065484289;
				if (num != 0)
				{
				}
				num = (short)1115029504;
				if (num != 0)
				{
				}
				num = (short)1651638272;
				short num3 = num;
				return this.radInfoLabtoolBornOnDateDBValue_A7568._HasDiffs;
			}
		}

		// Token: 0x17002A11 RID: 10769
		// (get) Token: 0x060050E3 RID: 20707 RVA: 0x0049A458 File Offset: 0x00498658
		// (set) Token: 0x060050E4 RID: 20708 RVA: 0x0049A50C File Offset: 0x0049870C
		public string RadInfoTrackingCodeplugVersion_A7688Value
		{
			get
			{
				short num = (short)1786839041;
				if (num != 0)
				{
				}
				num = (short)1044225436;
				short num2 = num;
				num = (short)1581686172;
				switch (num2 == num)
				{
				}
				num = (short)1339949056;
				if (num != 0)
				{
				}
				num = (short)1192361984;
				short num3 = num;
				return this.radInfoTrackingCodeplugVersion_A7688.Value;
			}
			set
			{
				short num = (short)1915438933;
				short num2 = num;
				num = (short)124274517;
				switch (num2 == num)
				{
				}
				num = (short)1057488897;
				if (num != 0)
				{
				}
				num = (short)641597440;
				if (num != 0)
				{
				}
				num = (short)1720254464;
				short num3 = num;
				this.radInfoTrackingCodeplugVersion_A7688.Value = value;
			}
		}

		// Token: 0x17002A12 RID: 10770
		// (get) Token: 0x060050E5 RID: 20709 RVA: 0x0049A5C4 File Offset: 0x004987C4
		public global::AcpBusinessLayer.AcpField<string> RadInfoTrackingCodeplugVersion_A7688
		{
			get
			{
				short num = (short)408813530;
				short num2 = num;
				num = (short)11730906;
				switch (num2 == num)
				{
				}
				num = (short)59899905;
				if (num != 0)
				{
				}
				num = (short)92930048;
				if (num != 0)
				{
				}
				num = (short)345243648;
				short num3 = num;
				return this.radInfoTrackingCodeplugVersion_A7688;
			}
		}

		// Token: 0x17002A13 RID: 10771
		// (get) Token: 0x060050E6 RID: 20710 RVA: 0x0049A674 File Offset: 0x00498874
		// (set) Token: 0x060050E7 RID: 20711 RVA: 0x0049A728 File Offset: 0x00498928
		public string RadInfoTrackingCodeplugVersion_A7688_UIValue
		{
			get
			{
				short num = (short)1896095028;
				short num2 = num;
				num = (short)2005409076;
				switch (num2 == num)
				{
				}
				num = (short)801832961;
				if (num != 0)
				{
				}
				num = (short)767754240;
				if (num != 0)
				{
				}
				num = (short)1526333440;
				short num3 = num;
				return this.radInfoTrackingCodeplugVersion_A7688.Value;
			}
			set
			{
				short num = (short)1983394559;
				short num2 = num;
				num = (short)421343999;
				switch (num2 == num)
				{
				}
				num = (short)1268973569;
				if (num != 0)
				{
				}
				num = (short)873201664;
				if (num != 0)
				{
				}
				num = (short)1845362688;
				short num3 = num;
				this.radInfoTrackingCodeplugVersion_A7688.Value = value;
			}
		}

		// Token: 0x17002A14 RID: 10772
		// (get) Token: 0x060050E8 RID: 20712 RVA: 0x0049A7E0 File Offset: 0x004989E0
		// (set) Token: 0x060050E9 RID: 20713 RVA: 0x0049A894 File Offset: 0x00498A94
		public bool RadInfoTrackingCodeplugVersion_A7688_Applicable
		{
			get
			{
				short num = (short)2111373313;
				if (num != 0)
				{
				}
				num = (short)294213321;
				short num2 = num;
				num = (short)1619416777;
				switch (num2 == num)
				{
				}
				num = (short)1296171008;
				if (num != 0)
				{
				}
				num = (short)1560018944;
				short num3 = num;
				return this.radInfoTrackingCodeplugVersion_A7688.Applicable;
			}
			set
			{
				short num = (short)1537343489;
				if (num != 0)
				{
				}
				num = (short)1468955893;
				short num2 = num;
				num = (short)2029878517;
				switch (num2 == num)
				{
				}
				num = (short)1440940032;
				if (num != 0)
				{
				}
				num = (short)1815281664;
				short num3 = num;
				this.radInfoTrackingCodeplugVersion_A7688.Applicable = value;
			}
		}

		// Token: 0x17002A15 RID: 10773
		// (get) Token: 0x060050EA RID: 20714 RVA: 0x0049A948 File Offset: 0x00498B48
		// (set) Token: 0x060050EB RID: 20715 RVA: 0x0049A9FC File Offset: 0x00498BFC
		public bool RadInfoTrackingCodeplugVersion_A7688_Valid
		{
			get
			{
				short num = (short)1908739558;
				short num2 = num;
				num = (short)1615793638;
				switch (num2 == num)
				{
				}
				num = (short)1246822401;
				if (num != 0)
				{
				}
				num = (short)354549760;
				if (num != 0)
				{
				}
				num = (short)1398407168;
				short num3 = num;
				return this.radInfoTrackingCodeplugVersion_A7688.Valid;
			}
			set
			{
				short num = (short)1668645749;
				short num2 = num;
				num = (short)1600684917;
				switch (num2 == num)
				{
				}
				num = (short)1328873473;
				if (num != 0)
				{
				}
				num = (short)378142720;
				if (num != 0)
				{
				}
				num = (short)1597308928;
				short num3 = num;
				this.radInfoTrackingCodeplugVersion_A7688.Valid = value;
			}
		}

		// Token: 0x17002A16 RID: 10774
		// (get) Token: 0x060050EC RID: 20716 RVA: 0x0049AAB4 File Offset: 0x00498CB4
		// (set) Token: 0x060050ED RID: 20717 RVA: 0x0049AB68 File Offset: 0x00498D68
		public bool RadInfoTrackingCodeplugVersion_A7688_Visible
		{
			get
			{
				short num = (short)2032979552;
				short num2 = num;
				num = (short)339856992;
				switch (num2 == num)
				{
				}
				num = (short)188350465;
				if (num != 0)
				{
				}
				num = (short)1733689344;
				if (num != 0)
				{
				}
				num = (short)297467904;
				short num3 = num;
				return this.radInfoTrackingCodeplugVersion_A7688.Visible;
			}
			set
			{
				short num = (short)1639577508;
				short num2 = num;
				num = (short)382531492;
				switch (num2 == num)
				{
				}
				num = (short)710017024;
				if (num != 0)
				{
				}
				num = (short)1876885505;
				if (num != 0)
				{
				}
				num = (short)890830848;
				short num3 = num;
				this.radInfoTrackingCodeplugVersion_A7688.Visible = value;
			}
		}

		// Token: 0x17002A17 RID: 10775
		// (get) Token: 0x060050EE RID: 20718 RVA: 0x0049AC20 File Offset: 0x00498E20
		// (set) Token: 0x060050EF RID: 20719 RVA: 0x0049ACD4 File Offset: 0x00498ED4
		public bool RadInfoTrackingCodeplugVersion_A7688_Editable
		{
			get
			{
				short num = (short)1088632199;
				short num2 = num;
				num = (short)429798791;
				switch (num2 == num)
				{
				}
				num = (short)781778944;
				if (num != 0)
				{
				}
				num = (short)827916289;
				if (num != 0)
				{
				}
				num = (short)620560384;
				short num3 = num;
				return this.radInfoTrackingCodeplugVersion_A7688.Editable;
			}
			set
			{
				short num = (short)698482174;
				short num2 = num;
				num = (short)1749089790;
				switch (num2 == num)
				{
				}
				num = (short)2026569729;
				if (num != 0)
				{
				}
				num = (short)596115456;
				if (num != 0)
				{
				}
				num = (short)1148780544;
				short num3 = num;
				this.radInfoTrackingCodeplugVersion_A7688.Editable = value;
			}
		}

		// Token: 0x17002A18 RID: 10776
		// (get) Token: 0x060050F0 RID: 20720 RVA: 0x0049AD8C File Offset: 0x00498F8C
		internal string RadInfoTrackingCodeplugVersion_A7688_UILabel
		{
			get
			{
				short num = (short)2079142743;
				short num2 = num;
				num = (short)906113879;
				switch (num2 == num)
				{
				}
				num = (short)455933952;
				if (num != 0)
				{
				}
				num = (short)872022017;
				if (num != 0)
				{
				}
				num = (short)18808832;
				short num3 = num;
				return this.radInfoTrackingCodeplugVersion_A7688.UIName;
			}
		}

		// Token: 0x17002A19 RID: 10777
		// (get) Token: 0x060050F1 RID: 20721 RVA: 0x0049AE40 File Offset: 0x00499040
		// (set) Token: 0x060050F2 RID: 20722 RVA: 0x0049AEF4 File Offset: 0x004990F4
		internal bool RadInfoTrackingCodeplugVersion_A7688_HiddenStatic
		{
			get
			{
				short num = (short)1255728863;
				short num2 = num;
				num = (short)695592671;
				switch (num2 == num)
				{
				}
				num = (short)1618608129;
				if (num != 0)
				{
				}
				num = (short)1230569472;
				if (num != 0)
				{
				}
				num = (short)1623261184;
				short num3 = num;
				return this.radInfoTrackingCodeplugVersion_A7688.HiddenStatic;
			}
			set
			{
				short num = (short)1731657729;
				if (num != 0)
				{
				}
				num = (short)1802242502;
				short num2 = num;
				num = (short)1547700678;
				switch (num2 == num)
				{
				}
				num = (short)137232384;
				if (num != 0)
				{
				}
				num = (short)1882587136;
				short num3 = num;
				this.radInfoTrackingCodeplugVersion_A7688.HiddenStatic = value;
			}
		}

		// Token: 0x17002A1A RID: 10778
		// (get) Token: 0x060050F3 RID: 20723 RVA: 0x0049AFAC File Offset: 0x004991AC
		// (set) Token: 0x060050F4 RID: 20724 RVA: 0x0049B060 File Offset: 0x00499260
		internal bool RadInfoTrackingCodeplugVersion_A7688_HiddenDynamic
		{
			get
			{
				short num = (short)1067165921;
				short num2 = num;
				num = (short)1092462817;
				switch (num2 == num)
				{
				}
				num = (short)966524928;
				if (num != 0)
				{
				}
				num = (short)1157103617;
				if (num != 0)
				{
				}
				num = (short)1362886656;
				short num3 = num;
				return this.radInfoTrackingCodeplugVersion_A7688.HiddenDynamic;
			}
			set
			{
				short num = (short)1237473240;
				short num2 = num;
				num = (short)1505318872;
				switch (num2 == num)
				{
				}
				num = (short)1696333825;
				if (num != 0)
				{
				}
				num = (short)854130688;
				if (num != 0)
				{
				}
				num = (short)1132462080;
				short num3 = num;
				this.radInfoTrackingCodeplugVersion_A7688.HiddenDynamic = value;
			}
		}

		// Token: 0x17002A1B RID: 10779
		// (get) Token: 0x060050F5 RID: 20725 RVA: 0x0049B118 File Offset: 0x00499318
		public bool RadInfoTrackingCodeplugVersion_A7688_HasDiffs
		{
			get
			{
				short num = (short)260374529;
				if (num != 0)
				{
				}
				num = (short)1064141682;
				short num2 = num;
				num = (short)665355122;
				switch (num2 == num)
				{
				}
				num = (short)1145569280;
				if (num != 0)
				{
				}
				num = (short)1182662656;
				short num3 = num;
				return this.radInfoTrackingCodeplugVersion_A7688._HasDiffs;
			}
		}

		// Token: 0x17002A1C RID: 10780
		// (get) Token: 0x060050F6 RID: 20726 RVA: 0x0049B1CC File Offset: 0x004993CC
		// (set) Token: 0x060050F7 RID: 20727 RVA: 0x0049B280 File Offset: 0x00499480
		public long RadInfoLabtoolLastProgrammedDateDBValue_A8411Value
		{
			get
			{
				short num = (short)118231874;
				short num2 = num;
				num = (short)1204884290;
				switch (num2 == num)
				{
				}
				num = (short)1300103168;
				if (num != 0)
				{
				}
				num = (short)112852993;
				if (num != 0)
				{
				}
				num = (short)260374528;
				short num3 = num;
				return this.radInfoLabtoolLastProgrammedDateDBValue_A8411.Value;
			}
			set
			{
				short num = (short)1269386197;
				short num2 = num;
				num = (short)92097493;
				switch (num2 == num)
				{
				}
				num = (short)1514733569;
				if (num != 0)
				{
				}
				num = (short)663814144;
				if (num != 0)
				{
				}
				num = (short)1256259584;
				short num3 = num;
				this.radInfoLabtoolLastProgrammedDateDBValue_A8411.Value = value;
			}
		}

		// Token: 0x17002A1D RID: 10781
		// (get) Token: 0x060050F8 RID: 20728 RVA: 0x0049B338 File Offset: 0x00499538
		public global::AcpBusinessLayer.AcpFieldX<long, string> RadInfoLabtoolLastProgrammedDateDBValue_A8411
		{
			get
			{
				short num = (short)1226233225;
				short num2 = num;
				num = (short)2024199561;
				switch (num2 == num)
				{
				}
				num = (short)2005008384;
				if (num != 0)
				{
				}
				num = (short)1091436545;
				if (num != 0)
				{
				}
				num = (short)1922236416;
				short num3 = num;
				return this.radInfoLabtoolLastProgrammedDateDBValue_A8411;
			}
		}

		// Token: 0x17002A1E RID: 10782
		// (get) Token: 0x060050F9 RID: 20729 RVA: 0x0049B3E8 File Offset: 0x004995E8
		// (set) Token: 0x060050FA RID: 20730 RVA: 0x0049B49C File Offset: 0x0049969C
		public string RadInfoLabtoolLastProgrammedDateDBValue_A8411_UIValue
		{
			get
			{
				short num = (short)1358987651;
				short num2 = num;
				num = (short)2090762627;
				switch (num2 == num)
				{
				}
				num = (short)864026624;
				if (num != 0)
				{
				}
				num = (short)53477377;
				if (num != 0)
				{
				}
				num = (short)820183040;
				short num3 = num;
				return this.radInfoLabtoolLastProgrammedDateDBValue_A8411.UIValue;
			}
			set
			{
				short num = (short)2073464620;
				short num2 = num;
				num = (short)1034129196;
				switch (num2 == num)
				{
				}
				num = (short)784924673;
				if (num != 0)
				{
				}
				num = (short)1322188800;
				if (num != 0)
				{
				}
				num = (short)261816320;
				short num3 = num;
				this.radInfoLabtoolLastProgrammedDateDBValue_A8411.UIValue = value;
			}
		}

		// Token: 0x17002A1F RID: 10783
		// (get) Token: 0x060050FB RID: 20731 RVA: 0x0049B550 File Offset: 0x00499750
		// (set) Token: 0x060050FC RID: 20732 RVA: 0x0049B604 File Offset: 0x00499804
		public bool RadInfoLabtoolLastProgrammedDateDBValue_A8411_Applicable
		{
			get
			{
				short num = (short)630418001;
				short num2 = num;
				num = (short)2016111185;
				switch (num2 == num)
				{
				}
				num = (short)1453064193;
				if (num != 0)
				{
				}
				num = (short)69009408;
				if (num != 0)
				{
				}
				num = (short)1778581504;
				short num3 = num;
				return this.radInfoLabtoolLastProgrammedDateDBValue_A8411.Applicable;
			}
			set
			{
				short num = (short)667957895;
				short num2 = num;
				num = (short)715799175;
				switch (num2 == num)
				{
				}
				num = (short)1453719552;
				if (num != 0)
				{
				}
				num = (short)1337917441;
				if (num != 0)
				{
				}
				num = (short)1693777920;
				short num3 = num;
				this.radInfoLabtoolLastProgrammedDateDBValue_A8411.Applicable = value;
			}
		}

		// Token: 0x17002A20 RID: 10784
		// (get) Token: 0x060050FD RID: 20733 RVA: 0x0049B6BC File Offset: 0x004998BC
		// (set) Token: 0x060050FE RID: 20734 RVA: 0x0049B76C File Offset: 0x0049996C
		public bool RadInfoLabtoolLastProgrammedDateDBValue_A8411_Valid
		{
			get
			{
				short num = (short)1553953779;
				short num2 = num;
				num = (short)93877235;
				switch (num2 == num)
				{
				}
				num = (short)343932929;
				if (num != 0)
				{
				}
				num = (short)185401344;
				if (num != 0)
				{
				}
				num = (short)314966016;
				short num3 = num;
				return this.radInfoLabtoolLastProgrammedDateDBValue_A8411.Valid;
			}
			set
			{
				short num = (short)1541799937;
				if (num != 0)
				{
				}
				num = (short)1045244143;
				short num2 = num;
				num = (short)243280111;
				switch (num2 == num)
				{
				}
				num = (short)1695547392;
				if (num != 0)
				{
				}
				num = (short)1402404864;
				short num3 = num;
				this.radInfoLabtoolLastProgrammedDateDBValue_A8411.Valid = value;
			}
		}

		// Token: 0x17002A21 RID: 10785
		// (get) Token: 0x060050FF RID: 20735 RVA: 0x0049B820 File Offset: 0x00499A20
		// (set) Token: 0x06005100 RID: 20736 RVA: 0x0049B8D4 File Offset: 0x00499AD4
		public bool RadInfoLabtoolLastProgrammedDateDBValue_A8411_Visible
		{
			get
			{
				short num = (short)1223154403;
				short num2 = num;
				num = (short)1120262883;
				switch (num2 == num)
				{
				}
				num = (short)2127888384;
				if (num != 0)
				{
				}
				num = (short)2079195137;
				if (num != 0)
				{
				}
				num = (short)303759360;
				short num3 = num;
				return this.radInfoLabtoolLastProgrammedDateDBValue_A8411.Visible;
			}
			set
			{
				short num = (short)126727775;
				short num2 = num;
				num = (short)2085598815;
				switch (num2 == num)
				{
				}
				num = (short)814809089;
				if (num != 0)
				{
				}
				num = (short)793706496;
				if (num != 0)
				{
				}
				num = (short)1877475328;
				short num3 = num;
				this.radInfoLabtoolLastProgrammedDateDBValue_A8411.Visible = value;
			}
		}

		// Token: 0x17002A22 RID: 10786
		// (get) Token: 0x06005101 RID: 20737 RVA: 0x0049B98C File Offset: 0x00499B8C
		// (set) Token: 0x06005102 RID: 20738 RVA: 0x0049BA44 File Offset: 0x00499C44
		public bool RadInfoLabtoolLastProgrammedDateDBValue_A8411_Editable
		{
			get
			{
				short num = (short)2051693815;
				short num2 = num;
				num = (short)248536311;
				switch (num2 == num)
				{
				}
				num = (short)1572470785;
				if (num != 0)
				{
				}
				num = (short)804454400;
				if (num != 0)
				{
				}
				num = (short)1711603712;
				short num3 = num;
				return this.radInfoLabtoolLastProgrammedDateDBValue_A8411.Editable;
			}
			set
			{
				short num = (short)1586196400;
				short num2 = num;
				num = (short)258371504;
				switch (num2 == num)
				{
				}
				num = (short)1824063489;
				if (num != 0)
				{
				}
				num = (short)673054720;
				if (num != 0)
				{
				}
				num = (short)166920192;
				short num3 = num;
				this.radInfoLabtoolLastProgrammedDateDBValue_A8411.Editable = value;
			}
		}

		// Token: 0x17002A23 RID: 10787
		// (get) Token: 0x06005103 RID: 20739 RVA: 0x0049BAF8 File Offset: 0x00499CF8
		internal string RadInfoLabtoolLastProgrammedDateDBValue_A8411_UILabel
		{
			get
			{
				short num = (short)324841182;
				short num2 = num;
				num = (short)1435021022;
				switch (num2 == num)
				{
				}
				num = (short)545587200;
				if (num != 0)
				{
				}
				num = (short)1456603137;
				if (num != 0)
				{
				}
				num = (short)2011955200;
				short num3 = num;
				return this.radInfoLabtoolLastProgrammedDateDBValue_A8411.UIName;
			}
		}

		// Token: 0x17002A24 RID: 10788
		// (get) Token: 0x06005104 RID: 20740 RVA: 0x0049BBAC File Offset: 0x00499DAC
		// (set) Token: 0x06005105 RID: 20741 RVA: 0x0049BC60 File Offset: 0x00499E60
		internal bool RadInfoLabtoolLastProgrammedDateDBValue_A8411_HiddenStatic
		{
			get
			{
				short num = (short)842792960;
				short num2 = num;
				num = (short)473107679;
				short num3 = num;
				num = (short)886443231;
				switch (num3 == num)
				{
				}
				num = (short)348061696;
				if (num != 0)
				{
				}
				num = (short)115671041;
				if (num != 0)
				{
				}
				return this.radInfoLabtoolLastProgrammedDateDBValue_A8411.HiddenStatic;
			}
			set
			{
				short num = (short)306184192;
				short num2 = num;
				num = (short)299237377;
				if (num != 0)
				{
				}
				num = (short)1276217924;
				short num3 = num;
				num = (short)1583778372;
				switch (num3 == num)
				{
				}
				num = (short)109969408;
				if (num != 0)
				{
				}
				this.radInfoLabtoolLastProgrammedDateDBValue_A8411.HiddenStatic = value;
			}
		}

		// Token: 0x17002A25 RID: 10789
		// (get) Token: 0x06005106 RID: 20742 RVA: 0x0049BD14 File Offset: 0x00499F14
		// (set) Token: 0x06005107 RID: 20743 RVA: 0x0049BDC8 File Offset: 0x00499FC8
		internal bool RadInfoLabtoolLastProgrammedDateDBValue_A8411_HiddenDynamic
		{
			get
			{
				short num = (short)1993211904;
				short num2 = num;
				num = (short)57119146;
				short num3 = num;
				num = (short)1996001706;
				switch (num3 == num)
				{
				}
				num = (short)1601437697;
				if (num != 0)
				{
				}
				num = (short)851771392;
				if (num != 0)
				{
				}
				return this.radInfoLabtoolLastProgrammedDateDBValue_A8411.HiddenDynamic;
			}
			set
			{
				short num = (short)1444020224;
				short num2 = num;
				num = (short)329820634;
				short num3 = num;
				num = (short)961915354;
				switch (num3 == num)
				{
				}
				num = (short)255393793;
				if (num != 0)
				{
				}
				num = (short)907280384;
				if (num != 0)
				{
				}
				this.radInfoLabtoolLastProgrammedDateDBValue_A8411.HiddenDynamic = value;
			}
		}

		// Token: 0x17002A26 RID: 10790
		// (get) Token: 0x06005108 RID: 20744 RVA: 0x0049BE7C File Offset: 0x0049A07C
		public bool RadInfoLabtoolLastProgrammedDateDBValue_A8411_HasDiffs
		{
			get
			{
				short num = (short)1190068224;
				short num2 = num;
				num = (short)1567621121;
				if (num != 0)
				{
				}
				num = (short)1075576430;
				short num3 = num;
				num = (short)904658542;
				switch (num3 == num)
				{
				}
				num = (short)672530432;
				if (num != 0)
				{
				}
				return this.radInfoLabtoolLastProgrammedDateDBValue_A8411._HasDiffs;
			}
		}

		// Token: 0x17002A27 RID: 10791
		// (get) Token: 0x06005109 RID: 20745 RVA: 0x0049BF30 File Offset: 0x0049A130
		// (set) Token: 0x0600510A RID: 20746 RVA: 0x0049BFE4 File Offset: 0x0049A1E4
		public int RadInfoTrackingSource2_A8625Value
		{
			get
			{
				short num = (short)2001076224;
				short num2 = num;
				num = (short)810435408;
				short num3 = num;
				num = (short)1304904528;
				switch (num3 == num)
				{
				}
				num = (short)1897332736;
				if (num != 0)
				{
				}
				num = (short)427360257;
				if (num != 0)
				{
				}
				return this.radInfoTrackingSource2_A8625.Value;
			}
			set
			{
				short num = (short)1637941248;
				short num2 = num;
				num = (short)1259012097;
				if (num != 0)
				{
				}
				num = (short)420953569;
				short num3 = num;
				num = (short)1859796449;
				switch (num3 == num)
				{
				}
				num = (short)224854016;
				if (num != 0)
				{
				}
				this.radInfoTrackingSource2_A8625.Value = value;
			}
		}

		// Token: 0x17002A28 RID: 10792
		// (get) Token: 0x0600510B RID: 20747 RVA: 0x0049C098 File Offset: 0x0049A298
		public global::AcpBusinessLayer.AcpFieldX<int, string> RadInfoTrackingSource2_A8625
		{
			get
			{
				short num = (short)1958019072;
				short num2 = num;
				num = (short)1065643230;
				short num3 = num;
				num = (short)230124766;
				switch (num3 == num)
				{
				}
				num = (short)1546452993;
				if (num != 0)
				{
				}
				num = (short)693370880;
				if (num != 0)
				{
				}
				return this.radInfoTrackingSource2_A8625;
			}
		}

		// Token: 0x17002A29 RID: 10793
		// (get) Token: 0x0600510C RID: 20748 RVA: 0x0049C144 File Offset: 0x0049A344
		// (set) Token: 0x0600510D RID: 20749 RVA: 0x0049C1FC File Offset: 0x0049A3FC
		public string RadInfoTrackingSource2_A8625_UIValue
		{
			get
			{
				short num = (short)651821056;
				short num2 = num;
				num = (short)1917621091;
				short num3 = num;
				num = (short)1852347235;
				switch (num3 == num)
				{
				}
				num = (short)2105802753;
				if (num != 0)
				{
				}
				num = (short)14483456;
				if (num != 0)
				{
				}
				return this.radInfoTrackingSource2_A8625.UIValue;
			}
			set
			{
				short num = (short)809631744;
				short num2 = num;
				num = (short)709033985;
				if (num != 0)
				{
				}
				num = (short)1165464343;
				short num3 = num;
				num = (short)1765315351;
				switch (num3 == num)
				{
				}
				num = (short)536150016;
				if (num != 0)
				{
				}
				this.radInfoTrackingSource2_A8625.UIValue = value;
			}
		}

		// Token: 0x17002A2A RID: 10794
		// (get) Token: 0x0600510E RID: 20750 RVA: 0x0049C2B4 File Offset: 0x0049A4B4
		// (set) Token: 0x0600510F RID: 20751 RVA: 0x0049C368 File Offset: 0x0049A568
		public bool RadInfoTrackingSource2_A8625_Applicable
		{
			get
			{
				short num = (short)953352192;
				short num2 = num;
				num = (short)1351382467;
				short num3 = num;
				num = (short)1859941827;
				switch (num3 == num)
				{
				}
				num = (short)2017722368;
				if (num != 0)
				{
				}
				num = (short)1379532801;
				if (num != 0)
				{
				}
				return this.radInfoTrackingSource2_A8625.Applicable;
			}
			set
			{
				short num = (short)1051852800;
				short num2 = num;
				num = (short)238755001;
				short num3 = num;
				num = (short)1846222009;
				switch (num3 == num)
				{
				}
				num = (short)1450377216;
				if (num != 0)
				{
				}
				num = (short)859045889;
				if (num != 0)
				{
				}
				this.radInfoTrackingSource2_A8625.Applicable = value;
			}
		}

		// Token: 0x17002A2B RID: 10795
		// (get) Token: 0x06005110 RID: 20752 RVA: 0x0049C420 File Offset: 0x0049A620
		// (set) Token: 0x06005111 RID: 20753 RVA: 0x0049C4D4 File Offset: 0x0049A6D4
		public bool RadInfoTrackingSource2_A8625_Valid
		{
			get
			{
				short num = (short)94306304;
				short num2 = num;
				num = (short)872279104;
				short num3 = num;
				num = (short)348515392;
				switch (num3 == num)
				{
				}
				num = (short)791871489;
				if (num != 0)
				{
				}
				num = (short)719912960;
				if (num != 0)
				{
				}
				return this.radInfoTrackingSource2_A8625.Valid;
			}
			set
			{
				short num = (short)1720188928;
				short num2 = num;
				num = (short)1063062272;
				short num3 = num;
				num = (short)1633159936;
				switch (num3 == num)
				{
				}
				num = (short)831913985;
				if (num != 0)
				{
				}
				num = (short)1408434176;
				if (num != 0)
				{
				}
				this.radInfoTrackingSource2_A8625.Valid = value;
			}
		}

		// Token: 0x17002A2C RID: 10796
		// (get) Token: 0x06005112 RID: 20754 RVA: 0x0049C588 File Offset: 0x0049A788
		// (set) Token: 0x06005113 RID: 20755 RVA: 0x0049C63C File Offset: 0x0049A83C
		public bool RadInfoTrackingSource2_A8625_Visible
		{
			get
			{
				short num = (short)623640576;
				short num2 = num;
				num = (short)690135864;
				short num3 = num;
				num = (short)1796776760;
				switch (num3 == num)
				{
				}
				num = (short)430112769;
				if (num != 0)
				{
				}
				num = (short)2034499584;
				if (num != 0)
				{
				}
				return this.radInfoTrackingSource2_A8625.Visible;
			}
			set
			{
				short num = (short)1385234432;
				short num2 = num;
				num = (short)633798657;
				if (num != 0)
				{
				}
				num = (short)1996426902;
				short num3 = num;
				num = (short)1744375446;
				switch (num3 == num)
				{
				}
				num = (short)1505361920;
				if (num != 0)
				{
				}
				this.radInfoTrackingSource2_A8625.Visible = value;
			}
		}

		// Token: 0x17002A2D RID: 10797
		// (get) Token: 0x06005114 RID: 20756 RVA: 0x0049C6F0 File Offset: 0x0049A8F0
		// (set) Token: 0x06005115 RID: 20757 RVA: 0x0049C7A4 File Offset: 0x0049A9A4
		public bool RadInfoTrackingSource2_A8625_Editable
		{
			get
			{
				short num = (short)497287168;
				short num2 = num;
				num = (short)498284218;
				short num3 = num;
				num = (short)1756313274;
				switch (num3 == num)
				{
				}
				num = (short)1768816641;
				if (num != 0)
				{
				}
				num = (short)1597046784;
				if (num != 0)
				{
				}
				return this.radInfoTrackingSource2_A8625.Editable;
			}
			set
			{
				short num = (short)1786773504;
				short num2 = num;
				num = (short)1371338639;
				short num3 = num;
				num = (short)1781004175;
				switch (num3 == num)
				{
				}
				num = (short)1055522817;
				if (num != 0)
				{
				}
				num = (short)1917517824;
				if (num != 0)
				{
				}
				this.radInfoTrackingSource2_A8625.Editable = value;
			}
		}

		// Token: 0x17002A2E RID: 10798
		// (get) Token: 0x06005116 RID: 20758 RVA: 0x0049C85C File Offset: 0x0049AA5C
		internal string RadInfoTrackingSource2_A8625_UILabel
		{
			get
			{
				short num = (short)1233977344;
				short num2 = num;
				num = (short)514330725;
				short num3 = num;
				num = (short)588320869;
				switch (num3 == num)
				{
				}
				num = (short)1152253953;
				if (num != 0)
				{
				}
				num = (short)1080164352;
				if (num != 0)
				{
				}
				return this.radInfoTrackingSource2_A8625.UIName;
			}
		}

		// Token: 0x17002A2F RID: 10799
		// (get) Token: 0x06005117 RID: 20759 RVA: 0x0049C914 File Offset: 0x0049AB14
		// (set) Token: 0x06005118 RID: 20760 RVA: 0x0049C9C8 File Offset: 0x0049ABC8
		internal bool RadInfoTrackingSource2_A8625_HiddenStatic
		{
			get
			{
				short num = (short)815923200;
				short num2 = num;
				num = (short)298088619;
				short num3 = num;
				num = (short)1917417643;
				switch (num3 == num)
				{
				}
				num = (short)567476225;
				if (num != 0)
				{
				}
				num = (short)678428672;
				if (num != 0)
				{
				}
				return this.radInfoTrackingSource2_A8625.HiddenStatic;
			}
			set
			{
				short num = (short)848822272;
				short num2 = num;
				num = (short)1499527037;
				short num3 = num;
				num = (short)1285420925;
				switch (num3 == num)
				{
				}
				num = (short)1049034752;
				if (num != 0)
				{
				}
				num = (short)254541825;
				if (num != 0)
				{
				}
				this.radInfoTrackingSource2_A8625.HiddenStatic = value;
			}
		}

		// Token: 0x17002A30 RID: 10800
		// (get) Token: 0x06005119 RID: 20761 RVA: 0x0049CA80 File Offset: 0x0049AC80
		// (set) Token: 0x0600511A RID: 20762 RVA: 0x0049CB30 File Offset: 0x0049AD30
		internal bool RadInfoTrackingSource2_A8625_HiddenDynamic
		{
			get
			{
				short num = (short)666107904;
				short num2 = num;
				num = (short)126383188;
				short num3 = num;
				num = (short)481850452;
				switch (num3 == num)
				{
				}
				num = (short)1385693185;
				if (num != 0)
				{
				}
				num = (short)948174848;
				if (num != 0)
				{
				}
				return this.radInfoTrackingSource2_A8625.HiddenDynamic;
			}
			set
			{
				short num = (short)1204682752;
				short num2 = num;
				num = (short)1157169153;
				if (num != 0)
				{
				}
				num = (short)878299154;
				short num3 = num;
				num = (short)1541064722;
				switch (num3 == num)
				{
				}
				num = (short)324534272;
				if (num != 0)
				{
				}
				this.radInfoTrackingSource2_A8625.HiddenDynamic = value;
			}
		}

		// Token: 0x17002A31 RID: 10801
		// (get) Token: 0x0600511B RID: 20763 RVA: 0x0049CBE8 File Offset: 0x0049ADE8
		public bool RadInfoTrackingSource2_A8625_HasDiffs
		{
			get
			{
				short num = (short)1939144704;
				short num2 = num;
				num = (short)1976747473;
				short num3 = num;
				num = (short)1742063057;
				switch (num3 == num)
				{
				}
				num = (short)1958739969;
				if (num != 0)
				{
				}
				num = (short)973209600;
				if (num != 0)
				{
				}
				return this.radInfoTrackingSource2_A8625._HasDiffs;
			}
		}

		// Token: 0x17002A32 RID: 10802
		// (get) Token: 0x0600511C RID: 20764 RVA: 0x0049CC9C File Offset: 0x0049AE9C
		// (set) Token: 0x0600511D RID: 20765 RVA: 0x0049CD50 File Offset: 0x0049AF50
		public int RadInfoTrackingSource1_A9171Value
		{
			get
			{
				short num = (short)1251213312;
				short num2 = num;
				num = (short)191066285;
				short num3 = num;
				num = (short)2136830125;
				switch (num3 == num)
				{
				}
				num = (short)1181745153;
				if (num != 0)
				{
				}
				num = (short)1306263552;
				if (num != 0)
				{
				}
				return this.radInfoTrackingSource1_A9171.Value;
			}
			set
			{
				short num = (short)1851719680;
				short num2 = num;
				num = (short)63746786;
				short num3 = num;
				num = (short)949465826;
				switch (num3 == num)
				{
				}
				num = (short)615776257;
				if (num != 0)
				{
				}
				num = (short)215941120;
				if (num != 0)
				{
				}
				this.radInfoTrackingSource1_A9171.Value = value;
			}
		}

		// Token: 0x17002A33 RID: 10803
		// (get) Token: 0x0600511E RID: 20766 RVA: 0x0049CE04 File Offset: 0x0049B004
		public global::AcpBusinessLayer.AcpFieldX<int, string> RadInfoTrackingSource1_A9171
		{
			get
			{
				short num = (short)1256980480;
				short num2 = num;
				num = (short)1725036663;
				short num3 = num;
				num = (short)2033514615;
				switch (num3 == num)
				{
				}
				num = (short)1717370880;
				if (num != 0)
				{
				}
				num = (short)1135280129;
				if (num != 0)
				{
				}
				return this.radInfoTrackingSource1_A9171;
			}
		}

		// Token: 0x17002A34 RID: 10804
		// (get) Token: 0x0600511F RID: 20767 RVA: 0x0049CEB4 File Offset: 0x0049B0B4
		// (set) Token: 0x06005120 RID: 20768 RVA: 0x0049CF68 File Offset: 0x0049B168
		public string RadInfoTrackingSource1_A9171_UIValue
		{
			get
			{
				short num = (short)1480458240;
				short num2 = num;
				num = (short)1983636181;
				short num3 = num;
				num = (short)1126097621;
				switch (num3 == num)
				{
				}
				num = (short)43122688;
				if (num != 0)
				{
				}
				num = (short)986578945;
				if (num != 0)
				{
				}
				return this.radInfoTrackingSource1_A9171.UIValue;
			}
			set
			{
				short num = (short)1686634496;
				short num2 = num;
				num = (short)1034027009;
				if (num != 0)
				{
				}
				num = (short)2044023814;
				short num3 = num;
				num = (short)423711750;
				switch (num3 == num)
				{
				}
				num = (short)1473052672;
				if (num != 0)
				{
				}
				this.radInfoTrackingSource1_A9171.UIValue = value;
			}
		}

		// Token: 0x17002A35 RID: 10805
		// (get) Token: 0x06005121 RID: 20769 RVA: 0x0049D01C File Offset: 0x0049B21C
		// (set) Token: 0x06005122 RID: 20770 RVA: 0x0049D0D0 File Offset: 0x0049B2D0
		public bool RadInfoTrackingSource1_A9171_Applicable
		{
			get
			{
				short num = (short)658571264;
				short num2 = num;
				num = (short)1187656451;
				short num3 = num;
				num = (short)1264792323;
				switch (num3 == num)
				{
				}
				num = (short)1397686273;
				if (num != 0)
				{
				}
				num = (short)612958208;
				if (num != 0)
				{
				}
				return this.radInfoTrackingSource1_A9171.Applicable;
			}
			set
			{
				short num = (short)841351168;
				short num2 = num;
				num = (short)1694420246;
				short num3 = num;
				num = (short)1496435990;
				switch (num3 == num)
				{
				}
				num = (short)1851654144;
				if (num != 0)
				{
				}
				num = (short)980287489;
				if (num != 0)
				{
				}
				this.radInfoTrackingSource1_A9171.Applicable = value;
			}
		}

		// Token: 0x17002A36 RID: 10806
		// (get) Token: 0x06005123 RID: 20771 RVA: 0x0049D188 File Offset: 0x0049B388
		// (set) Token: 0x06005124 RID: 20772 RVA: 0x0049D23C File Offset: 0x0049B43C
		public bool RadInfoTrackingSource1_A9171_Valid
		{
			get
			{
				short num = (short)523304960;
				short num2 = num;
				num = (short)228917249;
				if (num != 0)
				{
				}
				num = (short)764965225;
				short num3 = num;
				num = (short)610300265;
				switch (num3 == num)
				{
				}
				num = (short)357302272;
				if (num != 0)
				{
				}
				return this.radInfoTrackingSource1_A9171.Valid;
			}
			set
			{
				short num = (short)989069312;
				short num2 = num;
				num = (short)2041939956;
				short num3 = num;
				num = (short)1011910644;
				switch (num3 == num)
				{
				}
				num = (short)150863873;
				if (num != 0)
				{
				}
				num = (short)1302790144;
				if (num != 0)
				{
				}
				this.radInfoTrackingSource1_A9171.Valid = value;
			}
		}

		// Token: 0x17002A37 RID: 10807
		// (get) Token: 0x06005125 RID: 20773 RVA: 0x0049D2F4 File Offset: 0x0049B4F4
		// (set) Token: 0x06005126 RID: 20774 RVA: 0x0049D3A8 File Offset: 0x0049B5A8
		public bool RadInfoTrackingSource1_A9171_Visible
		{
			get
			{
				short num = (short)1665335296;
				short num2 = num;
				num = (short)2080605864;
				short num3 = num;
				num = (short)245139112;
				switch (num3 == num)
				{
				}
				num = (short)1716912128;
				if (num != 0)
				{
				}
				num = (short)434241537;
				if (num != 0)
				{
				}
				return this.radInfoTrackingSource1_A9171.Visible;
			}
			set
			{
				short num = (short)255852544;
				short num2 = num;
				num = (short)755495198;
				short num3 = num;
				num = (short)721285406;
				switch (num3 == num)
				{
				}
				num = (short)1754529793;
				if (num != 0)
				{
				}
				num = (short)19857408;
				if (num != 0)
				{
				}
				this.radInfoTrackingSource1_A9171.Visible = value;
			}
		}

		// Token: 0x17002A38 RID: 10808
		// (get) Token: 0x06005127 RID: 20775 RVA: 0x0049D460 File Offset: 0x0049B660
		// (set) Token: 0x06005128 RID: 20776 RVA: 0x0049D514 File Offset: 0x0049B714
		public bool RadInfoTrackingSource1_A9171_Editable
		{
			get
			{
				short num = (short)2117402624;
				short num2 = num;
				num = (short)2025695506;
				short num3 = num;
				num = (short)1846192402;
				switch (num3 == num)
				{
				}
				num = (short)293404672;
				if (num != 0)
				{
				}
				num = (short)364969985;
				if (num != 0)
				{
				}
				return this.radInfoTrackingSource1_A9171.Editable;
			}
			set
			{
				short num = (short)362086400;
				short num2 = num;
				num = (short)1354126644;
				short num3 = num;
				num = (short)320296244;
				switch (num3 == num)
				{
				}
				num = (short)1694695424;
				if (num != 0)
				{
				}
				num = (short)946667521;
				if (num != 0)
				{
				}
				this.radInfoTrackingSource1_A9171.Editable = value;
			}
		}

		// Token: 0x17002A39 RID: 10809
		// (get) Token: 0x06005129 RID: 20777 RVA: 0x0049D5C8 File Offset: 0x0049B7C8
		internal string RadInfoTrackingSource1_A9171_UILabel
		{
			get
			{
				short num = (short)952696832;
				short num2 = num;
				num = (short)761159659;
				short num3 = num;
				num = (short)1229021163;
				switch (num3 == num)
				{
				}
				num = (short)2005532672;
				if (num != 0)
				{
				}
				num = (short)1502019585;
				if (num != 0)
				{
				}
				return this.radInfoTrackingSource1_A9171.UIName;
			}
		}

		// Token: 0x17002A3A RID: 10810
		// (get) Token: 0x0600512A RID: 20778 RVA: 0x0049D67C File Offset: 0x0049B87C
		// (set) Token: 0x0600512B RID: 20779 RVA: 0x0049D730 File Offset: 0x0049B930
		internal bool RadInfoTrackingSource1_A9171_HiddenStatic
		{
			get
			{
				short num = (short)1668874240;
				short num2 = num;
				num = (short)1724557939;
				short num3 = num;
				num = (short)114666099;
				switch (num3 == num)
				{
				}
				num = (short)1652621312;
				if (num != 0)
				{
				}
				num = (short)1420558337;
				if (num != 0)
				{
				}
				return this.radInfoTrackingSource1_A9171.HiddenStatic;
			}
			set
			{
				short num = (short)25886720;
				short num2 = num;
				num = (short)315954311;
				short num3 = num;
				num = (short)703599751;
				switch (num3 == num)
				{
				}
				num = (short)1361248257;
				if (num != 0)
				{
				}
				num = (short)608174080;
				if (num != 0)
				{
				}
				this.radInfoTrackingSource1_A9171.HiddenStatic = value;
			}
		}

		// Token: 0x17002A3B RID: 10811
		// (get) Token: 0x0600512C RID: 20780 RVA: 0x0049D7E8 File Offset: 0x0049B9E8
		// (set) Token: 0x0600512D RID: 20781 RVA: 0x0049D8A0 File Offset: 0x0049BAA0
		internal bool RadInfoTrackingSource1_A9171_HiddenDynamic
		{
			get
			{
				short num = (short)1994326016;
				short num2 = num;
				num = (short)428343297;
				if (num != 0)
				{
				}
				num = (short)1570915729;
				short num3 = num;
				num = (short)1213482385;
				switch (num3 == num)
				{
				}
				num = (short)748421120;
				if (num != 0)
				{
				}
				return this.radInfoTrackingSource1_A9171.HiddenDynamic;
			}
			set
			{
				short num = (short)234881024;
				short num2 = num;
				num = (short)1351680001;
				if (num != 0)
				{
				}
				num = (short)971023971;
				short num3 = num;
				num = (short)1586013795;
				switch (num3 == num)
				{
				}
				num = (short)1544224768;
				if (num != 0)
				{
				}
				this.radInfoTrackingSource1_A9171.HiddenDynamic = value;
			}
		}

		// Token: 0x17002A3C RID: 10812
		// (get) Token: 0x0600512E RID: 20782 RVA: 0x0049D958 File Offset: 0x0049BB58
		public bool RadInfoTrackingSource1_A9171_HasDiffs
		{
			get
			{
				short num = (short)1723006976;
				short num2 = num;
				num = (short)1148256257;
				if (num != 0)
				{
				}
				num = (short)383105137;
				short num3 = num;
				num = (short)1709095025;
				switch (num3 == num)
				{
				}
				num = (short)1830486016;
				if (num != 0)
				{
				}
				return this.radInfoTrackingSource1_A9171._HasDiffs;
			}
		}

		// Token: 0x0600512F RID: 20783 RVA: 0x0049DA0C File Offset: 0x0049BC0C
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_70;
			}
			short num;
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				num = (short)1684488817;
				short num2 = num;
				num = (short)517882481;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2089811968;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
					{
						num = (short)1666187264;
						short num4 = num;
						if (base.ParentRecset != null)
						{
							num = (short)326696962;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 1:
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)304283651;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_D2;
					case 3:
						return result;
					case 4:
						num = (short)129695745;
						if (num != 0)
						{
						}
						if (base.ParentRecset.ContainerDoc != null)
						{
							num = (short)1998848001;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					goto IL_70;
				}
				IL_D2:
				num = (short)298450948;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_70:
			result = null;
			num = (short)1884356608;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x04001EDE RID: 7902
		private global::AcpBusinessLayer.AcpFieldX<long, string> radInfoLabtoolBornOnDateDBValue_A7568;

		// Token: 0x04001EDF RID: 7903
		private global::AcpBusinessLayer.AcpField<string> radInfoTrackingCodeplugVersion_A7688;

		// Token: 0x04001EE0 RID: 7904
		private global::AcpBusinessLayer.AcpFieldX<long, string> radInfoLabtoolLastProgrammedDateDBValue_A8411;

		// Token: 0x04001EE1 RID: 7905
		private global::AcpBusinessLayer.AcpFieldX<int, string> radInfoTrackingSource2_A8625;

		// Token: 0x04001EE2 RID: 7906
		private global::AcpBusinessLayer.AcpFieldX<int, string> radInfoTrackingSource1_A9171;
	}
}
