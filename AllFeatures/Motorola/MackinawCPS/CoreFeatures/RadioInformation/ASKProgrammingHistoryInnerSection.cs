using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioInformation
{
	// Token: 0x02000198 RID: 408
	[global::System.Serializable]
	public class ASKProgrammingHistoryInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060044D0 RID: 17616 RVA: 0x003FC4A0 File Offset: 0x003FA6A0
		public ASKProgrammingHistoryInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060044D1 RID: 17617 RVA: 0x003FC4BC File Offset: 0x003FA6BC
		protected ASKProgrammingHistoryInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060044D2 RID: 17618 RVA: 0x003FC4D4 File Offset: 0x003FA6D4
		public override void Init()
		{
			int a_ = 3;
			short num = (short)570636511;
			short num2 = num;
			num = (short)1391212767;
			switch (num2 == num)
			{
			}
			num = (short)983433217;
			if (num != 0)
			{
			}
			num = (short)215154688;
			if (num != 0)
			{
			}
			num = (short)1989541888;
			short num3 = num;
			this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410 = new global::AcpBusinessLayer.AcpFieldX<long, string>(0L, new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.DateTimeFormatConverter(), this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇菉ꋋ꣍뿏鏑냓ꃕ맗듙뿛믝蓟뇡鷣闥鳧迩臫ꗭ闯诱뷳飵黷闹뷻髽盿持樃攅洇渉弋眍挏昑焓笕北缙攛初䄟儡倣瘥娧䔩䬫尭儯弱瀳圵䰷弹缻渽Ἷ́獃牅祇穉", a_), global::CommonResources.AcgResources.ID_LASTPROGRAMMEDTIMEANDDATE);
			this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410.DataTransferOrder = -1;
			this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("雃Ʂ곇菉ꋋ꣍뿏鏑냓ꃕ맗듙뿛믝蓟뇡鷣闥鳧迩臫ꗭ闯诱뷳飵黷闹뷻髽盿持樃攅洇渉弋眍挏昑焓笕北缙攛䴝䔟倡䴣䜥䐧搩夫䌭刯圱䘳椵礷ഹ࠻༽焿", a_), global::CommonResources.AcgResources.ID_SERIALNUMBER, 16);
			this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("铃듅Ꟈ귉뻋꿍뷏뿑뷓룕뿗龎铛럝鏟雡诣铥釧", a_);
			base.Id = 10113;
			base.UIName = global::CommonResources.AcgResources.ID_PROGRAMMINGHISTORY;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060044D3 RID: 17619 RVA: 0x003FC634 File Offset: 0x003FA834
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 15;
			short num = (short)1365245955;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苏돑냓鿕뛗볙돛鿝蓟铡藣裥诧迩裫뷭觯臱胳鏵闷뇹駻蟽䧿氁戃椅䤇渉程漍縏焑焓爕䬗挙漛樝䔟伡漣䌥儧昩䴫崭䐯戱䘳夵強䠹崻匽п⍁ぃ⍅େᩉፋཌྷ杏晑敓晕", a_)))
					{
						num = (short)530251781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7A;
				case 1:
					num = (short)1991049224;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_24B;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 4:
					goto IL_7A;
				case 5:
				{
					this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410 = new global::AcpBusinessLayer.AcpFieldX<long, string>(0L, new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.DateTimeFormatConverter(), this, global::AllFeatures.CodeplugGuid.b("苏돑냓鿕뛗볙돛鿝蓟铡藣裥诧迩裫뷭觯臱胳鏵闷뇹駻蟽䧿氁戃椅䤇渉程漍縏焑焓爕䬗挙漛樝䔟伡漣䌥儧昩䴫崭䐯戱䘳夵強䠹崻匽п⍁ぃ⍅େᩉፋཌྷ杏晑敓晕", a_), global::CommonResources.AcgResources.ID_LASTPROGRAMMEDTIMEANDDATE);
					this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410.DataTransferOrder = -1;
					num = (short)2082940705;
					short num3 = num;
					num = (short)975513377;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_90;
					default:
					{
						num = (short)714735616;
						if (num != 0)
						{
						}
						num = (short)1589444608;
						short num4 = num;
						num = (short)693108740;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 6:
					goto IL_90;
				case 7:
					this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411 = new global::AcpBusinessLayer.AcpStringField(string.Empty, this, global::AllFeatures.CodeplugGuid.b("苏돑냓鿕뛗볙돛鿝蓟铡藣裥诧迩裫뷭觯臱胳鏵闷뇹駻蟽䧿氁戃椅䤇渉程漍縏焑焓爕䬗挙漛樝䔟伡漣䌥儧礩䤫尭夯匱堳砵䴷圹帻嬽㈿ᵁՃ煅籇等絋", a_), global::CommonResources.AcgResources.ID_SERIALNUMBER, 16);
					this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411.DataTransferOrder = -1;
					num = (short)552534018;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (producerFields != null)
					{
						num = (short)1863319561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_299;
				case 9:
					num = (short)1478098944;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_56:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)2111700993;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_7A:
				num = (short)382140422;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_90:
				if (!producerFields.Contains(global::AllFeatures.CodeplugGuid.b("苏돑냓鿕뛗볙돛鿝蓟铡藣裥诧迩裫뷭觯臱胳鏵闷뇹駻蟽䧿氁戃椅䤇渉程漍縏焑焓爕䬗挙漛樝䔟伡漣䌥儧礩䤫尭夯匱堳砵䴷圹帻嬽㈿ᵁՃ煅籇等絋", a_)))
				{
					break;
				}
				num = (short)27000833;
				if (num != 0)
				{
				}
				num = (short)1068105735;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_24B:
			IL_299:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胏ꃑ믓뇕꫗믙뇛돝觟賡菣웥ꃧ菩鿫髭鿯胱跳", a_);
			base.Id = 10113;
			base.UIName = global::CommonResources.AcgResources.ID_PROGRAMMINGHISTORY;
			base.DataTransferOrder = 1;
		}

		// Token: 0x060044D4 RID: 17620 RVA: 0x003FC90C File Offset: 0x003FAB0C
		public override void PopulateReferences()
		{
			short num = (short)1269129994;
			short num2 = num;
			num = (short)2066899722;
			switch (num2 == num)
			{
			}
			num = (short)2044461057;
			if (num != 0)
			{
			}
			num = (short)1235091456;
			if (num != 0)
			{
			}
			num = (short)119668736;
			short num3 = num;
		}

		// Token: 0x060044D5 RID: 17621 RVA: 0x003FC9B4 File Offset: 0x003FABB4
		public override void DropReferences()
		{
			short num = (short)936775609;
			short num2 = num;
			num = (short)1074204601;
			switch (num2 == num)
			{
			}
			num = (short)64487424;
			if (num != 0)
			{
			}
			num = (short)1554120705;
			if (num != 0)
			{
			}
			num = (short)993329152;
			short num3 = num;
		}

		// Token: 0x060044D6 RID: 17622 RVA: 0x003FCA5C File Offset: 0x003FAC5C
		public override void SetConstraints()
		{
			short num = (short)510957200;
			short num2 = num;
			num = (short)13538960;
			switch (num2 == num)
			{
			}
			num = (short)1061617665;
			if (num != 0)
			{
			}
			num = (short)1024065536;
			if (num != 0)
			{
			}
			num = (short)1156120576;
			short num3 = num;
			this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
			this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x060044D7 RID: 17623 RVA: 0x003FCB34 File Offset: 0x003FAD34
		public override void SetupDependencies()
		{
			short num = (short)1614768034;
			short num2 = num;
			num = (short)516384674;
			switch (num2 == num)
			{
			}
			num = (short)1436221441;
			if (num != 0)
			{
			}
			num = (short)1828978688;
			if (num != 0)
			{
			}
			num = (short)816054272;
			short num3 = num;
		}

		// Token: 0x1700235F RID: 9055
		// (get) Token: 0x060044D8 RID: 17624 RVA: 0x003FCBE0 File Offset: 0x003FADE0
		public bool HasDiffs
		{
			get
			{
				short num = (short)1082851329;
				if (num != 0)
				{
				}
				num = (short)1014477966;
				short num2 = num;
				num = (short)1151710350;
				switch (num2 == num)
				{
				}
				num = (short)1262878720;
				if (num != 0)
				{
				}
				num = (short)813563904;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17002360 RID: 9056
		// (get) Token: 0x060044D9 RID: 17625 RVA: 0x003FCC94 File Offset: 0x003FAE94
		// (set) Token: 0x060044DA RID: 17626 RVA: 0x003FCD4C File Offset: 0x003FAF4C
		public long RadInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410Value
		{
			get
			{
				short num = (short)1492359129;
				short num2 = num;
				num = (short)999790553;
				switch (num2 == num)
				{
				}
				num = (short)1796079617;
				if (num != 0)
				{
				}
				num = (short)431882240;
				if (num != 0)
				{
				}
				num = (short)617414656;
				short num3 = num;
				return this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410.Value;
			}
			set
			{
				short num = (short)817501539;
				short num2 = num;
				num = (short)874124643;
				switch (num2 == num)
				{
				}
				num = (short)458096640;
				if (num != 0)
				{
				}
				num = (short)330235905;
				if (num != 0)
				{
				}
				num = (short)979107840;
				short num3 = num;
				this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410.Value = value;
			}
		}

		// Token: 0x17002361 RID: 9057
		// (get) Token: 0x060044DB RID: 17627 RVA: 0x003FCE04 File Offset: 0x003FB004
		public global::AcpBusinessLayer.AcpFieldX<long, string> RadInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410
		{
			get
			{
				short num = (short)1244187022;
				short num2 = num;
				num = (short)609536398;
				switch (num2 == num)
				{
				}
				num = (short)2115108865;
				if (num != 0)
				{
				}
				num = (short)538181632;
				if (num != 0)
				{
				}
				num = (short)1310064640;
				short num3 = num;
				return this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410;
			}
		}

		// Token: 0x17002362 RID: 9058
		// (get) Token: 0x060044DC RID: 17628 RVA: 0x003FCEB4 File Offset: 0x003FB0B4
		// (set) Token: 0x060044DD RID: 17629 RVA: 0x003FCF6C File Offset: 0x003FB16C
		public string RadInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410_UIValue
		{
			get
			{
				short num = (short)1622989610;
				short num2 = num;
				num = (short)180738858;
				switch (num2 == num)
				{
				}
				num = (short)41091073;
				if (num != 0)
				{
				}
				num = (short)1924988928;
				if (num != 0)
				{
				}
				num = (short)861077504;
				short num3 = num;
				return this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410.UIValue;
			}
			set
			{
				short num = (short)1098136829;
				short num2 = num;
				num = (short)792411389;
				switch (num2 == num)
				{
				}
				num = (short)2112552961;
				if (num != 0)
				{
				}
				num = (short)2117206016;
				if (num != 0)
				{
				}
				num = (short)1617756160;
				short num3 = num;
				this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410.UIValue = value;
			}
		}

		// Token: 0x17002363 RID: 9059
		// (get) Token: 0x060044DE RID: 17630 RVA: 0x003FD020 File Offset: 0x003FB220
		// (set) Token: 0x060044DF RID: 17631 RVA: 0x003FD0D4 File Offset: 0x003FB2D4
		public bool RadInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410_Applicable
		{
			get
			{
				short num = (short)472632027;
				short num2 = num;
				num = (short)1024051931;
				switch (num2 == num)
				{
				}
				num = (short)36044801;
				if (num != 0)
				{
				}
				num = (short)33685504;
				if (num != 0)
				{
				}
				num = (short)1443954688;
				short num3 = num;
				return this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410.Applicable;
			}
			set
			{
				short num = (short)323288575;
				short num2 = num;
				num = (short)420806143;
				switch (num2 == num)
				{
				}
				num = (short)1129906177;
				if (num != 0)
				{
				}
				num = (short)1479016448;
				if (num != 0)
				{
				}
				num = (short)487456768;
				short num3 = num;
				this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410.Applicable = value;
			}
		}

		// Token: 0x17002364 RID: 9060
		// (get) Token: 0x060044E0 RID: 17632 RVA: 0x003FD18C File Offset: 0x003FB38C
		// (set) Token: 0x060044E1 RID: 17633 RVA: 0x003FD240 File Offset: 0x003FB440
		public bool RadInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410_Valid
		{
			get
			{
				short num = (short)628212668;
				short num2 = num;
				num = (short)563659708;
				switch (num2 == num)
				{
				}
				num = (short)1912209408;
				if (num != 0)
				{
				}
				num = (short)1784741889;
				if (num != 0)
				{
				}
				num = (short)22872064;
				short num3 = num;
				return this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410.Valid;
			}
			set
			{
				short num = (short)162004993;
				if (num != 0)
				{
				}
				num = (short)362920112;
				short num2 = num;
				num = (short)1330559152;
				switch (num2 == num)
				{
				}
				num = (short)1772355584;
				if (num != 0)
				{
				}
				num = (short)1634140160;
				short num3 = num;
				this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410.Valid = value;
			}
		}

		// Token: 0x17002365 RID: 9061
		// (get) Token: 0x060044E2 RID: 17634 RVA: 0x003FD2F4 File Offset: 0x003FB4F4
		// (set) Token: 0x060044E3 RID: 17635 RVA: 0x003FD3AC File Offset: 0x003FB5AC
		public bool RadInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410_Visible
		{
			get
			{
				short num = (short)1713959834;
				short num2 = num;
				num = (short)1510667162;
				switch (num2 == num)
				{
				}
				num = (short)317784064;
				if (num != 0)
				{
				}
				num = (short)1595932673;
				if (num != 0)
				{
				}
				num = (short)1151139840;
				short num3 = num;
				return this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410.Visible;
			}
			set
			{
				short num = (short)472456918;
				short num2 = num;
				num = (short)376512214;
				switch (num2 == num)
				{
				}
				num = (short)1629224961;
				if (num != 0)
				{
				}
				num = (short)175702016;
				if (num != 0)
				{
				}
				num = (short)171376640;
				short num3 = num;
				this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410.Visible = value;
			}
		}

		// Token: 0x17002366 RID: 9062
		// (get) Token: 0x060044E4 RID: 17636 RVA: 0x003FD460 File Offset: 0x003FB660
		// (set) Token: 0x060044E5 RID: 17637 RVA: 0x003FD518 File Offset: 0x003FB718
		public bool RadInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410_Editable
		{
			get
			{
				short num = (short)252018927;
				short num2 = num;
				num = (short)567443695;
				switch (num2 == num)
				{
				}
				num = (short)496173056;
				if (num != 0)
				{
				}
				num = (short)843644929;
				if (num != 0)
				{
				}
				num = (short)1421606912;
				short num3 = num;
				return this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410.Editable;
			}
			set
			{
				short num = (short)2045087175;
				short num2 = num;
				num = (short)937790919;
				switch (num2 == num)
				{
				}
				num = (short)207749121;
				if (num != 0)
				{
				}
				num = (short)375259136;
				if (num != 0)
				{
				}
				num = (short)1990000640;
				short num3 = num;
				this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410.Editable = value;
			}
		}

		// Token: 0x17002367 RID: 9063
		// (get) Token: 0x060044E6 RID: 17638 RVA: 0x003FD5D0 File Offset: 0x003FB7D0
		internal string RadInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410_UILabel
		{
			get
			{
				short num = (short)1721433944;
				short num2 = num;
				num = (short)1673854808;
				switch (num2 == num)
				{
				}
				num = (short)1262223361;
				if (num != 0)
				{
				}
				num = (short)1336803328;
				if (num != 0)
				{
				}
				num = (short)1761738752;
				short num3 = num;
				return this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410.UIName;
			}
		}

		// Token: 0x17002368 RID: 9064
		// (get) Token: 0x060044E7 RID: 17639 RVA: 0x003FD684 File Offset: 0x003FB884
		// (set) Token: 0x060044E8 RID: 17640 RVA: 0x003FD738 File Offset: 0x003FB938
		internal bool RadInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410_HiddenStatic
		{
			get
			{
				short num = (short)1313675166;
				short num2 = num;
				num = (short)1785730974;
				switch (num2 == num)
				{
				}
				num = (short)629145600;
				if (num != 0)
				{
				}
				num = (short)1326776321;
				if (num != 0)
				{
				}
				num = (short)521535488;
				short num3 = num;
				return this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410.HiddenStatic;
			}
			set
			{
				short num = (short)895536670;
				short num2 = num;
				num = (short)75484702;
				switch (num2 == num)
				{
				}
				num = (short)482148352;
				if (num != 0)
				{
				}
				num = (short)1064370177;
				if (num != 0)
				{
				}
				num = (short)1496252416;
				short num3 = num;
				this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410.HiddenStatic = value;
			}
		}

		// Token: 0x17002369 RID: 9065
		// (get) Token: 0x060044E9 RID: 17641 RVA: 0x003FD7F0 File Offset: 0x003FB9F0
		// (set) Token: 0x060044EA RID: 17642 RVA: 0x003FD8A4 File Offset: 0x003FBAA4
		internal bool RadInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410_HiddenDynamic
		{
			get
			{
				short num = (short)362531928;
				short num2 = num;
				num = (short)421776472;
				switch (num2 == num)
				{
				}
				num = (short)1453785089;
				if (num != 0)
				{
				}
				num = (short)571670528;
				if (num != 0)
				{
				}
				num = (short)245956608;
				short num3 = num;
				return this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410.HiddenDynamic;
			}
			set
			{
				short num = (short)923293159;
				short num2 = num;
				num = (short)491541991;
				switch (num2 == num)
				{
				}
				num = (short)1664090113;
				if (num != 0)
				{
				}
				num = (short)827326464;
				if (num != 0)
				{
				}
				num = (short)421724160;
				short num3 = num;
				this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410.HiddenDynamic = value;
			}
		}

		// Token: 0x1700236A RID: 9066
		// (get) Token: 0x060044EB RID: 17643 RVA: 0x003FD958 File Offset: 0x003FBB58
		public bool RadInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410_HasDiffs
		{
			get
			{
				short num = (short)629334058;
				short num2 = num;
				num = (short)1410195498;
				switch (num2 == num)
				{
				}
				num = (short)1663369217;
				if (num != 0)
				{
				}
				num = (short)958791680;
				if (num != 0)
				{
				}
				num = (short)1538195456;
				short num3 = num;
				return this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410._HasDiffs;
			}
		}

		// Token: 0x1700236B RID: 9067
		// (get) Token: 0x060044EC RID: 17644 RVA: 0x003FDA0C File Offset: 0x003FBC0C
		// (set) Token: 0x060044ED RID: 17645 RVA: 0x003FDAC4 File Offset: 0x003FBCC4
		public string RadInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411Value
		{
			get
			{
				short num = (short)1094566343;
				short num2 = num;
				num = (short)446611911;
				switch (num2 == num)
				{
				}
				num = (short)1455423488;
				if (num != 0)
				{
				}
				num = (short)1855258625;
				if (num != 0)
				{
				}
				num = (short)2050293760;
				short num3 = num;
				return this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411.Value;
			}
			set
			{
				short num = (short)432701799;
				short num2 = num;
				num = (short)1078100327;
				switch (num2 == num)
				{
				}
				num = (short)264372225;
				if (num != 0)
				{
				}
				num = (short)1832189952;
				if (num != 0)
				{
				}
				num = (short)803536896;
				short num3 = num;
				this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411.Value = value;
			}
		}

		// Token: 0x1700236C RID: 9068
		// (get) Token: 0x060044EE RID: 17646 RVA: 0x003FDB7C File Offset: 0x003FBD7C
		public global::AcpBusinessLayer.AcpField<string> RadInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411
		{
			get
			{
				short num = (short)1807220737;
				if (num != 0)
				{
				}
				num = (short)156332601;
				short num2 = num;
				num = (short)1575055929;
				switch (num2 == num)
				{
				}
				num = (short)1197670400;
				if (num != 0)
				{
				}
				num = (short)1021837312;
				short num3 = num;
				return this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411;
			}
		}

		// Token: 0x1700236D RID: 9069
		// (get) Token: 0x060044EF RID: 17647 RVA: 0x003FDC2C File Offset: 0x003FBE2C
		// (set) Token: 0x060044F0 RID: 17648 RVA: 0x003FDCE0 File Offset: 0x003FBEE0
		public string RadInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411_UIValue
		{
			get
			{
				short num = (short)1149489111;
				short num2 = num;
				num = (short)692113367;
				switch (num2 == num)
				{
				}
				num = (short)1797128192;
				if (num != 0)
				{
				}
				num = (short)819855361;
				if (num != 0)
				{
				}
				num = (short)1997209600;
				short num3 = num;
				return this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411.Value;
			}
			set
			{
				short num = (short)2055358126;
				short num2 = num;
				num = (short)934364846;
				switch (num2 == num)
				{
				}
				num = (short)1809317888;
				if (num != 0)
				{
				}
				num = (short)1123549185;
				if (num != 0)
				{
				}
				num = (short)509542400;
				short num3 = num;
				this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411.Value = value;
			}
		}

		// Token: 0x1700236E RID: 9070
		// (get) Token: 0x060044F1 RID: 17649 RVA: 0x003FDD98 File Offset: 0x003FBF98
		// (set) Token: 0x060044F2 RID: 17650 RVA: 0x003FDE48 File Offset: 0x003FC048
		public bool RadInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411_Applicable
		{
			get
			{
				short num = (short)1919297660;
				short num2 = num;
				num = (short)510208124;
				switch (num2 == num)
				{
				}
				num = (short)1811218433;
				if (num != 0)
				{
				}
				num = (short)2003173376;
				if (num != 0)
				{
				}
				num = (short)1552941056;
				short num3 = num;
				return this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411.Applicable;
			}
			set
			{
				short num = (short)1206323549;
				short num2 = num;
				num = (short)313198941;
				switch (num2 == num)
				{
				}
				num = (short)1513750529;
				if (num != 0)
				{
				}
				num = (short)1081409536;
				if (num != 0)
				{
				}
				num = (short)1305346048;
				short num3 = num;
				this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411.Applicable = value;
			}
		}

		// Token: 0x1700236F RID: 9071
		// (get) Token: 0x060044F3 RID: 17651 RVA: 0x003FDF00 File Offset: 0x003FC100
		// (set) Token: 0x060044F4 RID: 17652 RVA: 0x003FDFB4 File Offset: 0x003FC1B4
		public bool RadInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411_Valid
		{
			get
			{
				short num = (short)1105454682;
				short num2 = num;
				num = (short)1464526426;
				switch (num2 == num)
				{
				}
				num = (short)665059329;
				if (num != 0)
				{
				}
				num = (short)1017446400;
				if (num != 0)
				{
				}
				num = (short)612564992;
				short num3 = num;
				return this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411.Valid;
			}
			set
			{
				short num = (short)2023511031;
				short num2 = num;
				num = (short)1724666871;
				switch (num2 == num)
				{
				}
				num = (short)1372782592;
				if (num != 0)
				{
				}
				num = (short)1383858177;
				if (num != 0)
				{
				}
				num = (short)1748893696;
				short num3 = num;
				this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411.Valid = value;
			}
		}

		// Token: 0x17002370 RID: 9072
		// (get) Token: 0x060044F5 RID: 17653 RVA: 0x003FE06C File Offset: 0x003FC26C
		// (set) Token: 0x060044F6 RID: 17654 RVA: 0x003FE120 File Offset: 0x003FC320
		public bool RadInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411_Visible
		{
			get
			{
				short num = (short)1058366999;
				short num2 = num;
				num = (short)1588356631;
				switch (num2 == num)
				{
				}
				num = (short)161546240;
				if (num != 0)
				{
				}
				num = (short)1712193537;
				if (num != 0)
				{
				}
				num = (short)1352007680;
				short num3 = num;
				return this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411.Visible;
			}
			set
			{
				short num = (short)125566977;
				if (num != 0)
				{
				}
				num = (short)276550174;
				short num2 = num;
				num = (short)385602078;
				switch (num2 == num)
				{
				}
				num = (short)1327693824;
				if (num != 0)
				{
				}
				num = (short)118882304;
				short num3 = num;
				this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411.Visible = value;
			}
		}

		// Token: 0x17002371 RID: 9073
		// (get) Token: 0x060044F7 RID: 17655 RVA: 0x003FE1D8 File Offset: 0x003FC3D8
		// (set) Token: 0x060044F8 RID: 17656 RVA: 0x003FE290 File Offset: 0x003FC490
		public bool RadInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411_Editable
		{
			get
			{
				short num = (short)1132180565;
				short num2 = num;
				num = (short)1146205269;
				switch (num2 == num)
				{
				}
				num = (short)1557397505;
				if (num != 0)
				{
				}
				num = (short)1550974976;
				if (num != 0)
				{
				}
				num = (short)1979842560;
				short num3 = num;
				return this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411.Editable;
			}
			set
			{
				short num = (short)1307651017;
				short num2 = num;
				num = (short)268905417;
				switch (num2 == num)
				{
				}
				num = (short)247660545;
				if (num != 0)
				{
				}
				num = (short)1599209472;
				if (num != 0)
				{
				}
				num = (short)1736900608;
				short num3 = num;
				this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411.Editable = value;
			}
		}

		// Token: 0x17002372 RID: 9074
		// (get) Token: 0x060044F9 RID: 17657 RVA: 0x003FE344 File Offset: 0x003FC544
		internal string RadInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411_UILabel
		{
			get
			{
				short num = (short)735694206;
				short num2 = num;
				num = (short)1602538878;
				switch (num2 == num)
				{
				}
				num = (short)763625473;
				if (num != 0)
				{
				}
				num = (short)208863232;
				if (num != 0)
				{
				}
				num = (short)1340473344;
				short num3 = num;
				return this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411.UIName;
			}
		}

		// Token: 0x17002373 RID: 9075
		// (get) Token: 0x060044FA RID: 17658 RVA: 0x003FE3FC File Offset: 0x003FC5FC
		// (set) Token: 0x060044FB RID: 17659 RVA: 0x003FE4B0 File Offset: 0x003FC6B0
		internal bool RadInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411_HiddenStatic
		{
			get
			{
				short num = (short)708748584;
				short num2 = num;
				num = (short)1756079400;
				switch (num2 == num)
				{
				}
				num = (short)1702559744;
				if (num != 0)
				{
				}
				num = (short)1817444353;
				if (num != 0)
				{
				}
				num = (short)2115633152;
				short num3 = num;
				return this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411.HiddenStatic;
			}
			set
			{
				short num = (short)384818057;
				short num2 = num;
				num = (short)835050377;
				switch (num2 == num)
				{
				}
				num = (short)2101149697;
				if (num != 0)
				{
				}
				num = (short)323420160;
				if (num != 0)
				{
				}
				num = (short)1465188352;
				short num3 = num;
				this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411.HiddenStatic = value;
			}
		}

		// Token: 0x17002374 RID: 9076
		// (get) Token: 0x060044FC RID: 17660 RVA: 0x003FE568 File Offset: 0x003FC768
		// (set) Token: 0x060044FD RID: 17661 RVA: 0x003FE61C File Offset: 0x003FC81C
		internal bool RadInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411_HiddenDynamic
		{
			get
			{
				short num = (short)1467514395;
				short num2 = num;
				num = (short)1160412699;
				switch (num2 == num)
				{
				}
				num = (short)1722351617;
				if (num != 0)
				{
				}
				num = (short)69730304;
				if (num != 0)
				{
				}
				num = (short)1836122112;
				short num3 = num;
				return this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411.HiddenDynamic;
			}
			set
			{
				short num = (short)1697554545;
				short num2 = num;
				num = (short)1461887089;
				switch (num2 == num)
				{
				}
				num = (short)1987575809;
				if (num != 0)
				{
				}
				num = (short)325320704;
				if (num != 0)
				{
				}
				num = (short)1387266048;
				short num3 = num;
				this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411.HiddenDynamic = value;
			}
		}

		// Token: 0x17002375 RID: 9077
		// (get) Token: 0x060044FE RID: 17662 RVA: 0x003FE6D0 File Offset: 0x003FC8D0
		public bool RadInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411_HasDiffs
		{
			get
			{
				short num = (short)1337867789;
				short num2 = num;
				num = (short)1723088397;
				switch (num2 == num)
				{
				}
				num = (short)1470038017;
				if (num != 0)
				{
				}
				num = (short)176881664;
				if (num != 0)
				{
				}
				num = (short)722796544;
				short num3 = num;
				return this.radInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411._HasDiffs;
			}
		}

		// Token: 0x060044FF RID: 17663 RVA: 0x003FE784 File Offset: 0x003FC984
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
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)565837828;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1664155648;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
				{
					num2 = (short)836108288;
					short num3 = num2;
					num2 = (short)1801715713;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					while (base.ParentRecset != null)
					{
						num2 = (short)1099087250;
						short num4 = num2;
						num2 = (short)1522122130;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num2 = (short)730857473;
							if (num2 != 0)
							{
							}
							num2 = (short)419495936;
							if (num2 != 0)
							{
							}
							num2 = (short)682557442;
							num = (int)((global::System.IntPtr)num2);
							goto IL_0A;
						}
					}
					return result;
				case 4:
					return result;
				}
				goto IL_24;
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1220542467;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04001A44 RID: 6724
		private global::AcpBusinessLayer.AcpFieldX<long, string> radInfoAdvancedSystemKeyInfoAdvancedSystemKeyLastProgramDateCP_A7410;

		// Token: 0x04001A45 RID: 6725
		private global::AcpBusinessLayer.AcpField<string> radInfoAdvancedSystemKeyInfoAdvancedSystemKeySerialNumber_A7411;
	}
}
