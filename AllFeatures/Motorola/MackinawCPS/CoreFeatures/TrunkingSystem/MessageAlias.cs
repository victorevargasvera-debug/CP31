using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x02000097 RID: 151
	[global::System.Serializable]
	public class MessageAlias : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06001163 RID: 4451 RVA: 0x0010C008 File Offset: 0x0010A208
		public MessageAlias(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.innerRecset = new global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.MessageAliasInnerRecset();
			base.EmbeddedRecset = this.innerRecset;
			this.innerRecset.ParentSection = this;
			this.Init();
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x0010C048 File Offset: 0x0010A248
		protected MessageAlias(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x0010C060 File Offset: 0x0010A260
		public override void Init()
		{
			int a_ = 12;
			short num = (short)630063104;
			short num2 = num;
			num = (short)532926046;
			short num3 = num;
			num = (short)272944734;
			switch (num3 == num)
			{
			}
			num = (short)518520832;
			if (num != 0)
			{
			}
			num = (short)2126512129;
			if (num != 0)
			{
			}
			this.trkSysMessageAliasMessageAliasEnable_A8505 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("駌뷎뫐胒곔ꓖ铘뻚껜곞胠蓢胤ꛦ藨苪賬鳮볰雲蛴蓶飸鳺飼뻾洀樂搄理䰈攊氌洎紐瘒䨔嘖℘⸚ⴜ⨞", a_), global::CommonResources.AcgResources.ID_MESSAGEALIASENABLE);
			this.trkSysMessageAliasMessageAliasEnable_A8505.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
			this.trkSysMessageAliasMessageAliasEnable_A8505.DataTransferOrder = 15;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("背꫎ꋐꃒ듔냖볘ﯚ鳜돞裠苢雤", a_);
			base.Id = 10163;
			base.UIName = global::CommonResources.AcgResources.ID_MESSAGEALIAS;
			base.DataTransferOrder = 8;
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x0010C17C File Offset: 0x0010A37C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 4;
			short num = (short)1462960130;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (producerFields != null)
					{
						num = (short)468779013;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1DF;
				case 1:
					num = (short)440532992;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					continue;
				case 3:
					num = (short)813694977;
					if (num != 0)
					{
					}
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("釄뗆ꋈ飊듌볎鳐뛒ꛔꓖ룘볚룜點跠諢蓤铦ꓨ軪黬鳮郰铲郴뛶闸鋺鳼賾䐀洂搄攆攈渊刌与⤐☒└∖", a_)))
					{
						num = (short)878706692;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1DF;
				case 4:
					this.trkSysMessageAliasMessageAliasEnable_A8505 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("釄뗆ꋈ飊듌볎鳐뛒ꛔꓖ룘볚룜點跠諢蓤铦ꓨ軪黬鳮郰铲郴뛶闸鋺鳼賾䐀洂搄攆攈渊刌与⤐☒└∖", a_), global::CommonResources.AcgResources.ID_MESSAGEALIASENABLE);
					this.trkSysMessageAliasMessageAliasEnable_A8505.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Intermediate;
					this.trkSysMessageAliasMessageAliasEnable_A8505.DataTransferOrder = 15;
					num = (short)566558726;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					for (;;)
					{
						num = (short)2061971424;
						short num3 = num;
						num = (short)1373122528;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_11F;
						}
					}
					IL_11F:
					num = (short)1603338240;
					if (num != 0)
					{
					}
					num = (short)753074179;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_E6;
				}
				IL_4A:
				if (!global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					break;
				}
				num = (short)1558183936;
				short num4 = num;
				num = (short)2102460417;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E6:
			IL_1DF:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("裄ꋆ뫈룊곌꣎듐铔믖냘뫚껜", a_);
			base.Id = 10163;
			base.UIName = global::CommonResources.AcgResources.ID_MESSAGEALIAS;
			base.DataTransferOrder = 8;
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x0010C39C File Offset: 0x0010A59C
		public override void PopulateReferences()
		{
			short num = (short)1530471019;
			short num2 = num;
			num = (short)773595755;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1757478912;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1418067969;
			if (num != 0)
			{
			}
			num = (short)1295056896;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x0010C444 File Offset: 0x0010A644
		public override void DropReferences()
		{
			short num = (short)1504676178;
			short num2 = num;
			num = (short)500205906;
			switch (num2 == num)
			{
			default:
			{
				num = (short)670367744;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1650655232;
			if (num != 0)
			{
			}
			num = (short)270073857;
			if (num != 0)
			{
			}
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x0010C4F0 File Offset: 0x0010A6F0
		public override void SetConstraints()
		{
			short num = (short)1456028866;
			short num2 = num;
			num = (short)791362754;
			switch (num2 == num)
			{
			default:
			{
				num = (short)330170368;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)37027841;
			if (num != 0)
			{
			}
			num = (short)1297547264;
			if (num != 0)
			{
			}
			this.trkSysMessageAliasMessageAliasEnable_A8505.IsApplicable = new global::AcpCommonLib.StateConstraint(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConListinfoTrkSysTrkSysTypeIsNotAST25);
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x0010C5B0 File Offset: 0x0010A7B0
		public override void SetupDependencies()
		{
			short num = (short)1588974077;
			short num2 = num;
			num = (short)733729277;
			switch (num2 == num)
			{
			default:
			{
				num = (short)524222464;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1717829633;
			if (num != 0)
			{
			}
			num = (short)1236729856;
			if (num != 0)
			{
			}
			(base.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem).General.TrkSysGeneralSystemType_A9252.AddDependentObject(this.trkSysMessageAliasMessageAliasEnable_A8505);
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x0600116B RID: 4459 RVA: 0x0010C678 File Offset: 0x0010A878
		public bool HasDiffs
		{
			get
			{
				short num = (short)1384513537;
				if (num != 0)
				{
				}
				num = (short)1145044992;
				short num2 = num;
				num = (short)459565618;
				short num3 = num;
				num = (short)1520134706;
				switch (num3 == num)
				{
				}
				num = (short)951844864;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x0600116C RID: 4460 RVA: 0x0010C728 File Offset: 0x0010A928
		// (set) Token: 0x0600116D RID: 4461 RVA: 0x0010C7DC File Offset: 0x0010A9DC
		public bool TrkSysMessageAliasMessageAliasEnable_A8505Value
		{
			get
			{
				short num = (short)1651920130;
				short num2 = num;
				num = (short)260852994;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1039532032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)282394625;
				if (num != 0)
				{
				}
				num = (short)421789696;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasEnable_A8505.Value;
			}
			set
			{
				short num = (short)90745413;
				short num2 = num;
				num = (short)216050245;
				switch (num2 == num)
				{
				default:
				{
					num = (short)605880320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1493958657;
				if (num != 0)
				{
				}
				num = (short)1677787136;
				if (num != 0)
				{
				}
				this.trkSysMessageAliasMessageAliasEnable_A8505.Value = value;
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x0600116E RID: 4462 RVA: 0x0010C894 File Offset: 0x0010AA94
		public global::AcpBusinessLayer.AcpField<bool> TrkSysMessageAliasMessageAliasEnable_A8505
		{
			get
			{
				short num = (short)144217539;
				short num2 = num;
				num = (short)382834115;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1219493888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1053229057;
				if (num != 0)
				{
				}
				num = (short)2048720896;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasEnable_A8505;
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x0600116F RID: 4463 RVA: 0x0010C944 File Offset: 0x0010AB44
		// (set) Token: 0x06001170 RID: 4464 RVA: 0x0010C9F8 File Offset: 0x0010ABF8
		public bool TrkSysMessageAliasMessageAliasEnable_A8505_UIValue
		{
			get
			{
				short num = (short)275613259;
				short num2 = num;
				num = (short)336168523;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1924792320;
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
				num = (short)991756288;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasEnable_A8505.Value;
			}
			set
			{
				short num = (short)1429547472;
				short num2 = num;
				num = (short)1312106960;
				switch (num2 == num)
				{
				default:
				{
					num = (short)845021184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)459079680;
				if (num != 0)
				{
				}
				num = (short)870973441;
				if (num != 0)
				{
				}
				this.trkSysMessageAliasMessageAliasEnable_A8505.Value = value;
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06001171 RID: 4465 RVA: 0x0010CAAC File Offset: 0x0010ACAC
		// (set) Token: 0x06001172 RID: 4466 RVA: 0x0010CB60 File Offset: 0x0010AD60
		public bool TrkSysMessageAliasMessageAliasEnable_A8505_Applicable
		{
			get
			{
				short num = (short)1388161289;
				short num2 = num;
				num = (short)1375316233;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1184759808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)131072001;
				if (num != 0)
				{
				}
				num = (short)1150353408;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasEnable_A8505.Applicable;
			}
			set
			{
				short num = (short)272094608;
				short num2 = num;
				num = (short)1331156368;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1448935424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1061617664;
				if (num != 0)
				{
				}
				num = (short)2002583553;
				if (num != 0)
				{
				}
				this.trkSysMessageAliasMessageAliasEnable_A8505.Applicable = value;
			}
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06001173 RID: 4467 RVA: 0x0010CC14 File Offset: 0x0010AE14
		// (set) Token: 0x06001174 RID: 4468 RVA: 0x0010CCC4 File Offset: 0x0010AEC4
		public bool TrkSysMessageAliasMessageAliasEnable_A8505_Valid
		{
			get
			{
				short num = (short)757777229;
				short num2 = num;
				num = (short)889963341;
				switch (num2 == num)
				{
				default:
				{
					num = (short)308215808;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)500432897;
				if (num != 0)
				{
				}
				num = (short)489684992;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasEnable_A8505.Valid;
			}
			set
			{
				short num = (short)1841168385;
				if (num != 0)
				{
				}
				num = (short)543162368;
				short num2 = num;
				num = (short)1099601057;
				short num3 = num;
				num = (short)1091605665;
				switch (num3 == num)
				{
				}
				num = (short)1271791616;
				if (num != 0)
				{
				}
				this.trkSysMessageAliasMessageAliasEnable_A8505.Valid = value;
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x06001175 RID: 4469 RVA: 0x0010CD7C File Offset: 0x0010AF7C
		// (set) Token: 0x06001176 RID: 4470 RVA: 0x0010CE30 File Offset: 0x0010B030
		public bool TrkSysMessageAliasMessageAliasEnable_A8505_Visible
		{
			get
			{
				short num = (short)1356994208;
				short num2 = num;
				num = (short)462165664;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1071316992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2003959809;
				if (num != 0)
				{
				}
				num = (short)419758080;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasEnable_A8505.Visible;
			}
			set
			{
				short num = (short)86286192;
				short num2 = num;
				num = (short)1668063088;
				switch (num2 == num)
				{
				default:
				{
					num = (short)304611328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1584922625;
				if (num != 0)
				{
				}
				num = (short)331939840;
				if (num != 0)
				{
				}
				this.trkSysMessageAliasMessageAliasEnable_A8505.Visible = value;
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06001177 RID: 4471 RVA: 0x0010CEE4 File Offset: 0x0010B0E4
		// (set) Token: 0x06001178 RID: 4472 RVA: 0x0010CF9C File Offset: 0x0010B19C
		public bool TrkSysMessageAliasMessageAliasEnable_A8505_Editable
		{
			get
			{
				short num = (short)1660613575;
				short num2 = num;
				num = (short)698479559;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1198325760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)716242945;
				if (num != 0)
				{
				}
				num = (short)236388352;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasEnable_A8505.Editable;
			}
			set
			{
				short num = (short)1842850857;
				short num2 = num;
				num = (short)979086377;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1550450688;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1301282817;
				if (num != 0)
				{
				}
				num = (short)1100480512;
				if (num != 0)
				{
				}
				this.trkSysMessageAliasMessageAliasEnable_A8505.Editable = value;
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06001179 RID: 4473 RVA: 0x0010D050 File Offset: 0x0010B250
		internal string TrkSysMessageAliasMessageAliasEnable_A8505_UILabel
		{
			get
			{
				short num = (short)269095969;
				short num2 = num;
				num = (short)45028385;
				switch (num2 == num)
				{
				default:
				{
					num = (short)928776192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1858011137;
				if (num != 0)
				{
				}
				num = (short)974782464;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasEnable_A8505.UIName;
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x0600117A RID: 4474 RVA: 0x0010D104 File Offset: 0x0010B304
		// (set) Token: 0x0600117B RID: 4475 RVA: 0x0010D1B8 File Offset: 0x0010B3B8
		internal bool TrkSysMessageAliasMessageAliasEnable_A8505_HiddenStatic
		{
			get
			{
				short num = (short)1024439567;
				short num2 = num;
				num = (short)183874831;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1634402304;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)546504704;
				if (num != 0)
				{
				}
				num = (short)1326972929;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasEnable_A8505.HiddenStatic;
			}
			set
			{
				short num = (short)288877029;
				short num2 = num;
				num = (short)1557326309;
				switch (num2 == num)
				{
				default:
				{
					num = (short)466878464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1786118144;
				if (num != 0)
				{
				}
				num = (short)1904214017;
				if (num != 0)
				{
				}
				this.trkSysMessageAliasMessageAliasEnable_A8505.HiddenStatic = value;
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x0600117C RID: 4476 RVA: 0x0010D270 File Offset: 0x0010B470
		// (set) Token: 0x0600117D RID: 4477 RVA: 0x0010D324 File Offset: 0x0010B524
		internal bool TrkSysMessageAliasMessageAliasEnable_A8505_HiddenDynamic
		{
			get
			{
				short num = (short)1031038124;
				short num2 = num;
				num = (short)1401054380;
				switch (num2 == num)
				{
				default:
				{
					num = (short)817496064;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1489174529;
				if (num != 0)
				{
				}
				num = (short)188481536;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasEnable_A8505.HiddenDynamic;
			}
			set
			{
				short num = (short)674112498;
				short num2 = num;
				num = (short)449324018;
				switch (num2 == num)
				{
				default:
				{
					num = (short)135856128;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)328925185;
				if (num != 0)
				{
				}
				num = (short)55115776;
				if (num != 0)
				{
				}
				this.trkSysMessageAliasMessageAliasEnable_A8505.HiddenDynamic = value;
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x0600117E RID: 4478 RVA: 0x0010D3DC File Offset: 0x0010B5DC
		public bool TrkSysMessageAliasMessageAliasEnable_A8505_HasDiffs
		{
			get
			{
				short num = (short)1065025537;
				if (num != 0)
				{
				}
				num = (short)335151104;
				short num2 = num;
				num = (short)1858236794;
				short num3 = num;
				num = (short)1608020346;
				switch (num3 == num)
				{
				}
				num = (short)480444416;
				if (num != 0)
				{
				}
				return this.trkSysMessageAliasMessageAliasEnable_A8505._HasDiffs;
			}
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x0010D490 File Offset: 0x0010B690
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
					num2 = (short)1249968128;
					short num3 = num2;
					num2 = (short)1340669956;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_115;
				case 2:
					goto IL_AC;
				case 3:
					if (base.ParentRecset != null)
					{
						num2 = (short)1576075264;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_115;
				case 4:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)288686082;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_115;
				}
				goto IL_24;
				IL_AC:
				result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
				num2 = (short)39059457;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_115:
				num2 = (short)589573351;
				short num4 = num2;
				num2 = (short)240266471;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_AC;
				default:
					goto IL_14B;
				}
			}
			IL_14B:
			num2 = (short)1735786496;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)114556929;
			if (num2 != 0)
			{
			}
			num2 = (short)555024387;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0400043F RID: 1087
		private global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.MessageAliasInnerRecset innerRecset;

		// Token: 0x04000440 RID: 1088
		private global::AcpBusinessLayer.AcpField<bool> trkSysMessageAliasMessageAliasEnable_A8505;
	}
}
