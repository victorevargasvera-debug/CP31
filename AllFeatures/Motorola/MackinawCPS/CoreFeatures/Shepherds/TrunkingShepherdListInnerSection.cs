using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;
using ConstraintHelper;

namespace Motorola.MackinawCPS.CoreFeatures.Shepherds
{
	// Token: 0x020001EF RID: 495
	[global::System.Serializable]
	public class TrunkingShepherdListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x0600557F RID: 21887 RVA: 0x004D8354 File Offset: 0x004D6554
		public TrunkingShepherdListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06005580 RID: 21888 RVA: 0x004D8370 File Offset: 0x004D6570
		protected TrunkingShepherdListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06005581 RID: 21889 RVA: 0x004D8388 File Offset: 0x004D6588
		public override void Init()
		{
			int a_ = 17;
			short num = (short)1497144593;
			short num2 = num;
			num = (short)1294638353;
			switch (num2 == num)
			{
			}
			num = (short)1252196352;
			short num3 = num;
			num = (short)1418919936;
			if (num != 0)
			{
			}
			num = (short)915275777;
			if (num != 0)
			{
			}
			this.radErgoCfgTrkBtnListID_A21166 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝ꏟ蓡菣닥髧臩껫髭黯뻱鷳藵賷돹룻ꇽ䇿、㔃㜅㸇㰉", a_), global::CommonResources.AcgResources.ID_TRUNKINGBUTTONLISTID, 0, 65535, null, null, 0, 1);
			this.radErgoCfgTrkBtnListID_A21166.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgTrkBtnListID_A21166.DataTransferOrder = -1;
			this.radErgoCfgTrkBtnListID_A21166.ShowHexValue = false;
			this.radErgoCfgTrkBtnListKey_A21174 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝ꏟ蓡菣닥髧臩껫髭黯뻱鷳藵賷뇹駻蟽忿䌁㘃㜅㤇㴉㠋", a_), global::CommonResources.AcgResources.ID_TRUNKINGBUTTONLISTKEY, 14);
			this.radErgoCfgTrkBtnListKey_A21174.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgTrkBtnListKey_A21174.DataTransferOrder = -1;
			this.radErgoCfgTrkBtnListType_A21167 = new global::AcpBusinessLayer.AcpSparseLOVField(1016, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.indexRadErgoCfgTrkBtnListType_A21167LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.idRadErgoCfgTrkBtnListType_A21167LovStrs), this, global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝ꏟ蓡菣닥髧臩껫髭黯뻱鷳藵賷껹藻軽旿崁䔃㐅㤇㬉㨋㤍", a_), global::CommonResources.AcgResources.ID_TRUNKINGBUTTONLISTTYPE, global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.RadErgoCfgTrkBtnListType_A21167LovStrs);
			this.radErgoCfgTrkBtnListType_A21167.IgnoreOnCompare = true;
			this.radErgoCfgTrkBtnListType_A21167.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.radErgoCfgTrkBtnListType_A21167.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蛑ꛓꏕ뛗뇙뗛냝蟟䋡럣軥跧髩蓫语苯雱퓳뫵釷觹裻", a_);
			base.Id = 10038;
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGSHEPHERDLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06005582 RID: 21890 RVA: 0x004D854C File Offset: 0x004D674C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 17;
			short num = (short)1395195913;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_2C5;
				case 1:
					this.radErgoCfgTrkBtnListKey_A21174 = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝ꏟ蓡菣닥髧臩껫髭黯뻱鷳藵賷뇹駻蟽忿䌁㘃㜅㤇㴉㠋", a_), global::CommonResources.AcgResources.ID_TRUNKINGBUTTONLISTKEY, 14);
					this.radErgoCfgTrkBtnListKey_A21174.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgoCfgTrkBtnListKey_A21174.DataTransferOrder = -1;
					num = (short)802422784;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_1E6;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝ꏟ蓡菣닥髧臩껫髭黯뻱鷳藵賷돹룻ꇽ䇿、㔃㜅㸇㰉", a_)))
					{
						num = (short)203882498;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_154;
				case 4:
				{
					num = (short)1526987161;
					short num3 = num;
					num = (short)237762969;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E6;
					default:
						num = (short)1586036736;
						if (num != 0)
						{
						}
						num = (short)1909391372;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					goto IL_154;
				case 6:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝ꏟ蓡菣닥髧臩껫髭黯뻱鷳藵賷껹藻軽旿崁䔃㐅㤇㬉㨋㤍", a_)))
					{
						num = (short)85983243;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_378;
				case 7:
					num = (short)180158467;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_286;
				case 9:
					num = (short)1498415105;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_8B;
					}
					continue;
				case 10:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝ꏟ蓡菣닥髧臩껫髭黯뻱鷳藵賷뇹駻蟽忿䌁㘃㜅㤇㴉㠋", a_)))
					{
						num = (short)429719553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2C5;
				case 11:
				{
					num = (short)448593920;
					short num4 = num;
					this.radErgoCfgTrkBtnListType_A21167 = new global::AcpBusinessLayer.AcpSparseLOVField(1016, new global::ConstraintHelper.SparseConverter(global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.indexRadErgoCfgTrkBtnListType_A21167LovStrs, global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.idRadErgoCfgTrkBtnListType_A21167LovStrs), this, global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝ꏟ蓡菣닥髧臩껫髭黯뻱鷳藵賷껹藻軽旿崁䔃㐅㤇㬉㨋㤍", a_), global::CommonResources.AcgResources.ID_TRUNKINGBUTTONLISTTYPE, global::Motorola.MackinawCPS.CoreFeatures.Shepherds.LOVs.RadErgoCfgTrkBtnListType_A21167LovStrs);
					this.radErgoCfgTrkBtnListType_A21167.IgnoreOnCompare = true;
					this.radErgoCfgTrkBtnListType_A21167.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.radErgoCfgTrkBtnListType_A21167.DataTransferOrder = -1;
					num = (short)178257928;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 12:
					if (producerFields != null)
					{
						num = (short)903348231;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_378;
				}
				IL_8B:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1985150980;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_154:
				num = (short)1785659402;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E6:
				this.radErgoCfgTrkBtnListID_A21166 = new global::AcpBusinessLayer.AcpSimpleRangeField(0, this, global::AllFeatures.CodeplugGuid.b("胑뗓닕鷗꣙믛뇝ꏟ蓡菣닥髧臩껫髭黯뻱鷳藵賷돹룻ꇽ䇿、㔃㜅㸇㰉", a_), global::CommonResources.AcgResources.ID_TRUNKINGBUTTONLISTID, null, null, 0, 1);
				this.radErgoCfgTrkBtnListID_A21166.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
				this.radErgoCfgTrkBtnListID_A21166.DataTransferOrder = -1;
				this.radErgoCfgTrkBtnListID_A21166.ShowHexValue = false;
				num = (short)332857349;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2C5:
				num = (short)610271238;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_286:
			IL_378:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蛑ꛓꏕ뛗뇙뗛냝蟟䋡럣軥跧髩蓫语苯雱퓳뫵釷觹裻", a_);
			base.Id = 10038;
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKINGSHEPHERDLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06005583 RID: 21891 RVA: 0x004D8904 File Offset: 0x004D6B04
		public override void PopulateReferences()
		{
			short num = (short)1799421799;
			short num2 = num;
			num = (short)470024039;
			switch (num2 == num)
			{
			}
			num = (short)2140143616;
			short num3 = num;
			num = (short)1769603073;
			if (num != 0)
			{
			}
			num = (short)804913152;
			if (num != 0)
			{
			}
		}

		// Token: 0x06005584 RID: 21892 RVA: 0x004D89AC File Offset: 0x004D6BAC
		public override void DropReferences()
		{
			short num = (short)298773536;
			short num2 = num;
			num = (short)784919584;
			switch (num2 == num)
			{
			}
			num = (short)1299644416;
			short num3 = num;
			num = (short)676790273;
			if (num != 0)
			{
			}
			num = (short)1819934720;
			if (num != 0)
			{
			}
		}

		// Token: 0x06005585 RID: 21893 RVA: 0x004D8A54 File Offset: 0x004D6C54
		public override void SetConstraints()
		{
			short num = (short)648746984;
			short num2 = num;
			num = (short)1778980840;
			switch (num2 == num)
			{
			}
			num = (short)1719730176;
			short num3 = num;
			num = (short)1315700736;
			if (num != 0)
			{
			}
			num = (short)1551171585;
			if (num != 0)
			{
			}
			this.radErgoCfgTrkBtnListID_A21166.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x06005586 RID: 21894 RVA: 0x004D8B18 File Offset: 0x004D6D18
		public override void SetupDependencies()
		{
			short num = (short)935723009;
			if (num != 0)
			{
			}
			num = (short)1183862698;
			short num2 = num;
			num = (short)1831751594;
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
			num = (short)1260060672;
			if (num != 0)
			{
			}
		}

		// Token: 0x17002C16 RID: 11286
		// (get) Token: 0x06005587 RID: 21895 RVA: 0x004D8BC0 File Offset: 0x004D6DC0
		public bool HasDiffs
		{
			get
			{
				short num = (short)1680450626;
				short num2 = num;
				num = (short)940090434;
				switch (num2 == num)
				{
				}
				num = (short)926941184;
				short num3 = num;
				num = (short)1524629505;
				if (num != 0)
				{
				}
				num = (short)1568800768;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17002C17 RID: 11287
		// (get) Token: 0x06005588 RID: 21896 RVA: 0x004D8C70 File Offset: 0x004D6E70
		// (set) Token: 0x06005589 RID: 21897 RVA: 0x004D8D24 File Offset: 0x004D6F24
		public int RadErgoCfgTrkBtnListID_A21166Value
		{
			get
			{
				short num = (short)1385724275;
				short num2 = num;
				num = (short)1680177523;
				switch (num2 == num)
				{
				}
				num = (short)879558656;
				short num3 = num;
				num = (short)2140930048;
				if (num != 0)
				{
				}
				num = (short)575733761;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListID_A21166.Value;
			}
			set
			{
				short num = (short)2003580397;
				short num2 = num;
				num = (short)1909667309;
				switch (num2 == num)
				{
				}
				num = (short)2132934656;
				short num3 = num;
				num = (short)1534001152;
				if (num != 0)
				{
				}
				num = (short)279576577;
				if (num != 0)
				{
				}
				this.radErgoCfgTrkBtnListID_A21166.Value = value;
			}
		}

		// Token: 0x17002C18 RID: 11288
		// (get) Token: 0x0600558A RID: 21898 RVA: 0x004D8DD8 File Offset: 0x004D6FD8
		public global::AcpBusinessLayer.AcpSimpleRangeField RadErgoCfgTrkBtnListID_A21166
		{
			get
			{
				short num = (short)154827810;
				short num2 = num;
				num = (short)1125022754;
				switch (num2 == num)
				{
				}
				num = (short)439877632;
				short num3 = num;
				num = (short)1165492225;
				if (num != 0)
				{
				}
				num = (short)1127350272;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListID_A21166;
			}
		}

		// Token: 0x17002C19 RID: 11289
		// (get) Token: 0x0600558B RID: 21899 RVA: 0x004D8E88 File Offset: 0x004D7088
		// (set) Token: 0x0600558C RID: 21900 RVA: 0x004D8F40 File Offset: 0x004D7140
		public string RadErgoCfgTrkBtnListID_A21166_UIValue
		{
			get
			{
				short num = (short)58747144;
				short num2 = num;
				num = (short)1920428296;
				switch (num2 == num)
				{
				}
				num = (short)421527552;
				short num3 = num;
				num = (short)1708195840;
				if (num != 0)
				{
				}
				num = (short)12386305;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListID_A21166.UIValue;
			}
			set
			{
				short num = (short)291698449;
				short num2 = num;
				num = (short)1000470289;
				switch (num2 == num)
				{
				}
				num = (short)1136918528;
				short num3 = num;
				num = (short)1058340865;
				if (num != 0)
				{
				}
				num = (short)1804992512;
				if (num != 0)
				{
				}
				this.radErgoCfgTrkBtnListID_A21166.UIValue = value;
			}
		}

		// Token: 0x17002C1A RID: 11290
		// (get) Token: 0x0600558D RID: 21901 RVA: 0x004D8FF8 File Offset: 0x004D71F8
		// (set) Token: 0x0600558E RID: 21902 RVA: 0x004D90B0 File Offset: 0x004D72B0
		internal int RadErgoCfgTrkBtnListID_A21166Min
		{
			get
			{
				short num = (short)1589337146;
				short num2 = num;
				num = (short)1147100218;
				switch (num2 == num)
				{
				}
				num = (short)15007744;
				short num3 = num;
				num = (short)638517249;
				if (num != 0)
				{
				}
				num = (short)1576796160;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListID_A21166.Min;
			}
			set
			{
				short num = (short)2125186715;
				short num2 = num;
				num = (short)1485555355;
				switch (num2 == num)
				{
				}
				num = (short)1584201728;
				short num3 = num;
				num = (short)1933508609;
				if (num != 0)
				{
				}
				num = (short)302645248;
				if (num != 0)
				{
				}
				this.radErgoCfgTrkBtnListID_A21166.Min = value;
			}
		}

		// Token: 0x17002C1B RID: 11291
		// (get) Token: 0x0600558F RID: 21903 RVA: 0x004D9164 File Offset: 0x004D7364
		// (set) Token: 0x06005590 RID: 21904 RVA: 0x004D9218 File Offset: 0x004D7418
		internal int RadErgoCfgTrkBtnListID_A21166Max
		{
			get
			{
				short num = (short)360347079;
				short num2 = num;
				num = (short)1119122887;
				switch (num2 == num)
				{
				}
				num = (short)457965568;
				short num3 = num;
				num = (short)1664745473;
				if (num != 0)
				{
				}
				num = (short)280363008;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListID_A21166.Max;
			}
			set
			{
				short num = (short)1070655666;
				short num2 = num;
				num = (short)1282271410;
				switch (num2 == num)
				{
				}
				num = (short)1063124992;
				short num3 = num;
				num = (short)853803009;
				if (num != 0)
				{
				}
				num = (short)1501298688;
				if (num != 0)
				{
				}
				this.radErgoCfgTrkBtnListID_A21166.Max = value;
			}
		}

		// Token: 0x17002C1C RID: 11292
		// (get) Token: 0x06005591 RID: 21905 RVA: 0x004D92CC File Offset: 0x004D74CC
		// (set) Token: 0x06005592 RID: 21906 RVA: 0x004D9384 File Offset: 0x004D7584
		internal int RadErgoCfgTrkBtnListID_A21166Step
		{
			get
			{
				short num = (short)410346694;
				short num2 = num;
				num = (short)2105042118;
				switch (num2 == num)
				{
				}
				num = (short)1448542208;
				short num3 = num;
				num = (short)535101440;
				if (num != 0)
				{
				}
				num = (short)1730543617;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListID_A21166.StepSize;
			}
			set
			{
				short num = (short)1660816728;
				short num2 = num;
				num = (short)1154747736;
				switch (num2 == num)
				{
				}
				num = (short)1766719488;
				short num3 = num;
				num = (short)1192689665;
				if (num != 0)
				{
				}
				num = (short)1149370368;
				if (num != 0)
				{
				}
				this.radErgoCfgTrkBtnListID_A21166.StepSize = value;
			}
		}

		// Token: 0x17002C1D RID: 11293
		// (get) Token: 0x06005593 RID: 21907 RVA: 0x004D943C File Offset: 0x004D763C
		// (set) Token: 0x06005594 RID: 21908 RVA: 0x004D94F0 File Offset: 0x004D76F0
		public bool RadErgoCfgTrkBtnListID_A21166_Applicable
		{
			get
			{
				short num = (short)803274753;
				if (num != 0)
				{
				}
				num = (short)1407587100;
				short num2 = num;
				num = (short)61870876;
				switch (num2 == num)
				{
				default:
				{
					num = (short)601620480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)704774144;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListID_A21166.Applicable;
			}
			set
			{
				short num = (short)1476001793;
				if (num != 0)
				{
				}
				num = (short)23222145;
				short num2 = num;
				num = (short)1246779265;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2012741632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2109145088;
				if (num != 0)
				{
				}
				this.radErgoCfgTrkBtnListID_A21166.Applicable = value;
			}
		}

		// Token: 0x17002C1E RID: 11294
		// (get) Token: 0x06005595 RID: 21909 RVA: 0x004D95A8 File Offset: 0x004D77A8
		// (set) Token: 0x06005596 RID: 21910 RVA: 0x004D965C File Offset: 0x004D785C
		public bool RadErgoCfgTrkBtnListID_A21166_Valid
		{
			get
			{
				short num = (short)189502033;
				short num2 = num;
				num = (short)1102352977;
				switch (num2 == num)
				{
				}
				num = (short)1891500032;
				short num3 = num;
				num = (short)2123563009;
				if (num != 0)
				{
				}
				num = (short)336330752;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListID_A21166.Valid;
			}
			set
			{
				short num = (short)753150541;
				short num2 = num;
				num = (short)1781082701;
				switch (num2 == num)
				{
				}
				num = (short)1471676416;
				short num3 = num;
				num = (short)1702494209;
				if (num != 0)
				{
				}
				num = (short)1575616512;
				if (num != 0)
				{
				}
				this.radErgoCfgTrkBtnListID_A21166.Valid = value;
			}
		}

		// Token: 0x17002C1F RID: 11295
		// (get) Token: 0x06005597 RID: 21911 RVA: 0x004D9714 File Offset: 0x004D7914
		// (set) Token: 0x06005598 RID: 21912 RVA: 0x004D97C8 File Offset: 0x004D79C8
		public bool RadErgoCfgTrkBtnListID_A21166_Visible
		{
			get
			{
				short num = (short)1039728641;
				if (num != 0)
				{
				}
				num = (short)280651335;
				short num2 = num;
				num = (short)1436837447;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1880817664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2025783296;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListID_A21166.Visible;
			}
			set
			{
				short num = (short)685703169;
				if (num != 0)
				{
				}
				num = (short)824392062;
				short num2 = num;
				num = (short)347158910;
				switch (num2 == num)
				{
				default:
				{
					num = (short)776929280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1438515200;
				if (num != 0)
				{
				}
				this.radErgoCfgTrkBtnListID_A21166.Visible = value;
			}
		}

		// Token: 0x17002C20 RID: 11296
		// (get) Token: 0x06005599 RID: 21913 RVA: 0x004D987C File Offset: 0x004D7A7C
		// (set) Token: 0x0600559A RID: 21914 RVA: 0x004D9934 File Offset: 0x004D7B34
		public bool RadErgoCfgTrkBtnListID_A21166_Editable
		{
			get
			{
				short num = (short)562900374;
				short num2 = num;
				num = (short)452603286;
				switch (num2 == num)
				{
				}
				num = (short)684326912;
				short num3 = num;
				num = (short)358219776;
				if (num != 0)
				{
				}
				num = (short)1972109313;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListID_A21166.Editable;
			}
			set
			{
				short num = (short)258276412;
				short num2 = num;
				num = (short)892992572;
				switch (num2 == num)
				{
				}
				num = (short)253493248;
				short num3 = num;
				num = (short)193527809;
				if (num != 0)
				{
				}
				num = (short)568459264;
				if (num != 0)
				{
				}
				this.radErgoCfgTrkBtnListID_A21166.Editable = value;
			}
		}

		// Token: 0x17002C21 RID: 11297
		// (get) Token: 0x0600559B RID: 21915 RVA: 0x004D99EC File Offset: 0x004D7BEC
		internal string RadErgoCfgTrkBtnListID_A21166_UILabel
		{
			get
			{
				short num = (short)1357204025;
				short num2 = num;
				num = (short)168512057;
				switch (num2 == num)
				{
				}
				num = (short)1594949632;
				short num3 = num;
				num = (short)2119827456;
				if (num != 0)
				{
				}
				num = (short)875036673;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListID_A21166.UIName;
			}
		}

		// Token: 0x17002C22 RID: 11298
		// (get) Token: 0x0600559C RID: 21916 RVA: 0x004D9AA4 File Offset: 0x004D7CA4
		// (set) Token: 0x0600559D RID: 21917 RVA: 0x004D9B58 File Offset: 0x004D7D58
		internal bool RadErgoCfgTrkBtnListID_A21166_HiddenStatic
		{
			get
			{
				short num = (short)1550858503;
				short num2 = num;
				num = (short)819869959;
				switch (num2 == num)
				{
				}
				num = (short)223019008;
				short num3 = num;
				num = (short)352321536;
				if (num != 0)
				{
				}
				num = (short)1003356161;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListID_A21166.HiddenStatic;
			}
			set
			{
				short num = (short)1381788849;
				short num2 = num;
				num = (short)190278833;
				switch (num2 == num)
				{
				}
				num = (short)556072960;
				if (num != 0)
				{
				}
				num = (short)278724608;
				short num3 = num;
				num = (short)1416626177;
				if (num != 0)
				{
				}
				this.radErgoCfgTrkBtnListID_A21166.HiddenStatic = value;
			}
		}

		// Token: 0x17002C23 RID: 11299
		// (get) Token: 0x0600559E RID: 21918 RVA: 0x004D9C10 File Offset: 0x004D7E10
		// (set) Token: 0x0600559F RID: 21919 RVA: 0x004D9CC4 File Offset: 0x004D7EC4
		internal bool RadErgoCfgTrkBtnListID_A21166_HiddenDynamic
		{
			get
			{
				short num = (short)830953842;
				short num2 = num;
				num = (short)950688114;
				switch (num2 == num)
				{
				}
				num = (short)2131361793;
				if (num != 0)
				{
				}
				num = (short)458096640;
				short num3 = num;
				num = (short)1109721088;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListID_A21166.HiddenDynamic;
			}
			set
			{
				short num = (short)543293441;
				if (num != 0)
				{
				}
				num = (short)1171399544;
				short num2 = num;
				num = (short)2144609144;
				switch (num2 == num)
				{
				}
				num = (short)1709965312;
				short num3 = num;
				num = (short)2015035392;
				if (num != 0)
				{
				}
				this.radErgoCfgTrkBtnListID_A21166.HiddenDynamic = value;
			}
		}

		// Token: 0x17002C24 RID: 11300
		// (get) Token: 0x060055A0 RID: 21920 RVA: 0x004D9D78 File Offset: 0x004D7F78
		public bool RadErgoCfgTrkBtnListID_A21166_HasDiffs
		{
			get
			{
				short num = (short)1923999332;
				short num2 = num;
				num = (short)681961060;
				switch (num2 == num)
				{
				}
				num = (short)419758081;
				if (num != 0)
				{
				}
				num = (short)1452081152;
				short num3 = num;
				num = (short)1841561600;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListID_A21166._HasDiffs;
			}
		}

		// Token: 0x17002C25 RID: 11301
		// (get) Token: 0x060055A1 RID: 21921 RVA: 0x004D9E30 File Offset: 0x004D8030
		// (set) Token: 0x060055A2 RID: 21922 RVA: 0x004D9EE4 File Offset: 0x004D80E4
		public string RadErgoCfgTrkBtnListKey_A21174Value
		{
			get
			{
				short num = (short)1991180289;
				if (num != 0)
				{
				}
				num = (short)342291364;
				short num2 = num;
				num = (short)633795492;
				switch (num2 == num)
				{
				}
				num = (short)816971776;
				short num3 = num;
				num = (short)752943104;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListKey_A21174.Value;
			}
			set
			{
				short num = (short)1723072513;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)2139815936;
					short num3 = num;
					num = (short)666042369;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_82;
						}
						continue;
					case 2:
						for (;;)
						{
							this.radErgoCfgTrkBtnListKey_A21174.Value = value;
							num = (short)24212242;
							short num4 = num;
							num = (short)1038643986;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_EE;
							}
						}
						IL_EE:
						num = (short)286654464;
						if (num != 0)
						{
						}
						num = (short)1713766400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_82:
					if (string.IsNullOrEmpty(value.Trim()))
					{
						break;
					}
					num = (short)1435697154;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17002C26 RID: 11302
		// (get) Token: 0x060055A3 RID: 21923 RVA: 0x004DA010 File Offset: 0x004D8210
		// (set) Token: 0x060055A4 RID: 21924 RVA: 0x004DA0C8 File Offset: 0x004D82C8
		public string RadErgoCfgTrkBtnListKey_A21174_UIValue
		{
			get
			{
				short num = (short)448103950;
				short num2 = num;
				num = (short)2129692174;
				switch (num2 == num)
				{
				}
				num = (short)1436286977;
				if (num != 0)
				{
				}
				num = (short)2105212928;
				short num3 = num;
				num = (short)1348337664;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListKey_A21174.Value;
			}
			set
			{
				short num = (short)392802873;
				short num2 = num;
				num = (short)1735111225;
				switch (num2 == num)
				{
				}
				num = (short)1872494592;
				if (num != 0)
				{
				}
				num = (short)1748303872;
				short num3 = num;
				num = (short)62128129;
				if (num != 0)
				{
				}
				this.radErgoCfgTrkBtnListKey_A21174.Value = value;
			}
		}

		// Token: 0x17002C27 RID: 11303
		// (get) Token: 0x060055A5 RID: 21925 RVA: 0x004DA178 File Offset: 0x004D8378
		public global::AcpBusinessLayer.AcpKeyField RadErgoCfgTrkBtnListKey_A21174
		{
			get
			{
				short num = (short)1407089802;
				short num2 = num;
				num = (short)664108170;
				switch (num2 == num)
				{
				}
				num = (short)1629159425;
				if (num != 0)
				{
				}
				num = (short)477298688;
				short num3 = num;
				num = (short)1073086464;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListKey_A21174;
			}
		}

		// Token: 0x17002C28 RID: 11304
		// (get) Token: 0x060055A6 RID: 21926 RVA: 0x004DA228 File Offset: 0x004D8428
		// (set) Token: 0x060055A7 RID: 21927 RVA: 0x004DA2E0 File Offset: 0x004D84E0
		public bool RadErgoCfgTrkBtnListKey_A21174_Applicable
		{
			get
			{
				short num = (short)622462658;
				short num2 = num;
				num = (short)1807353538;
				switch (num2 == num)
				{
				}
				num = (short)607518721;
				if (num != 0)
				{
				}
				num = (short)193331200;
				short num3 = num;
				num = (short)323616768;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListKey_A21174.Applicable;
			}
			set
			{
				short num = (short)840499304;
				short num2 = num;
				num = (short)1450705000;
				switch (num2 == num)
				{
				}
				num = (short)177340417;
				if (num != 0)
				{
				}
				num = (short)88997888;
				short num3 = num;
				num = (short)386007040;
				if (num != 0)
				{
				}
				this.radErgoCfgTrkBtnListKey_A21174.Applicable = value;
			}
		}

		// Token: 0x17002C29 RID: 11305
		// (get) Token: 0x060055A8 RID: 21928 RVA: 0x004DA398 File Offset: 0x004D8598
		// (set) Token: 0x060055A9 RID: 21929 RVA: 0x004DA44C File Offset: 0x004D864C
		public bool RadErgoCfgTrkBtnListKey_A21174_Valid
		{
			get
			{
				short num = (short)1312942291;
				short num2 = num;
				num = (short)703391955;
				switch (num2 == num)
				{
				}
				num = (short)808058881;
				if (num != 0)
				{
				}
				num = (short)1019281408;
				short num3 = num;
				num = (short)1040973824;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListKey_A21174.Valid;
			}
			set
			{
				short num = (short)26096441;
				short num2 = num;
				num = (short)2140222265;
				switch (num2 == num)
				{
				}
				num = (short)1159135233;
				if (num != 0)
				{
				}
				num = (short)393936896;
				short num3 = num;
				num = (short)642973696;
				if (num != 0)
				{
				}
				this.radErgoCfgTrkBtnListKey_A21174.Valid = value;
			}
		}

		// Token: 0x17002C2A RID: 11306
		// (get) Token: 0x060055AA RID: 21930 RVA: 0x004DA500 File Offset: 0x004D8700
		// (set) Token: 0x060055AB RID: 21931 RVA: 0x004DA5B4 File Offset: 0x004D87B4
		public bool RadErgoCfgTrkBtnListKey_A21174_Visible
		{
			get
			{
				short num = (short)1239823555;
				short num2 = num;
				num = (short)31339715;
				switch (num2 == num)
				{
				}
				num = (short)832307201;
				if (num != 0)
				{
				}
				num = (short)1146552320;
				short num3 = num;
				num = (short)853082112;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListKey_A21174.Visible;
			}
			set
			{
				short num = (short)2109276161;
				if (num != 0)
				{
				}
				num = (short)2038952521;
				short num2 = num;
				num = (short)1828123209;
				switch (num2 == num)
				{
				}
				num = (short)1257111552;
				short num3 = num;
				num = (short)2080047104;
				if (num != 0)
				{
				}
				this.radErgoCfgTrkBtnListKey_A21174.Visible = value;
			}
		}

		// Token: 0x17002C2B RID: 11307
		// (get) Token: 0x060055AC RID: 21932 RVA: 0x004DA66C File Offset: 0x004D886C
		// (set) Token: 0x060055AD RID: 21933 RVA: 0x004DA720 File Offset: 0x004D8920
		public bool RadErgoCfgTrkBtnListKey_A21174_Editable
		{
			get
			{
				short num = (short)1415118849;
				if (num != 0)
				{
				}
				num = (short)1457694679;
				short num2 = num;
				num = (short)277981143;
				switch (num2 == num)
				{
				}
				num = (short)1750859776;
				short num3 = num;
				num = (short)1312030720;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListKey_A21174.Editable;
			}
			set
			{
				short num = (short)470861279;
				short num2 = num;
				num = (short)1389086175;
				switch (num2 == num)
				{
				}
				num = (short)89980929;
				if (num != 0)
				{
				}
				num = (short)375652352;
				short num3 = num;
				num = (short)300613632;
				if (num != 0)
				{
				}
				this.radErgoCfgTrkBtnListKey_A21174.Editable = value;
			}
		}

		// Token: 0x17002C2C RID: 11308
		// (get) Token: 0x060055AE RID: 21934 RVA: 0x004DA7D8 File Offset: 0x004D89D8
		internal string RadErgoCfgTrkBtnListKey_A21174_UILabel
		{
			get
			{
				short num = (short)2027917902;
				short num2 = num;
				num = (short)981897806;
				switch (num2 == num)
				{
				}
				num = (short)1067712513;
				if (num != 0)
				{
				}
				num = (short)271187968;
				short num3 = num;
				num = (short)1991245824;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListKey_A21174.UIName;
			}
		}

		// Token: 0x17002C2D RID: 11309
		// (get) Token: 0x060055AF RID: 21935 RVA: 0x004DA88C File Offset: 0x004D8A8C
		// (set) Token: 0x060055B0 RID: 21936 RVA: 0x004DA940 File Offset: 0x004D8B40
		internal bool RadErgoCfgTrkBtnListKey_A21174_HiddenStatic
		{
			get
			{
				short num = (short)1055990867;
				short num2 = num;
				num = (short)2081236051;
				switch (num2 == num)
				{
				}
				num = (short)2099183617;
				if (num != 0)
				{
				}
				num = (short)1267793920;
				short num3 = num;
				num = (short)573833216;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListKey_A21174.HiddenStatic;
			}
			set
			{
				short num = (short)1654631191;
				short num2 = num;
				num = (short)717204247;
				switch (num2 == num)
				{
				}
				num = (short)771555329;
				if (num != 0)
				{
				}
				num = (short)39649280;
				short num3 = num;
				num = (short)727252992;
				if (num != 0)
				{
				}
				this.radErgoCfgTrkBtnListKey_A21174.HiddenStatic = value;
			}
		}

		// Token: 0x17002C2E RID: 11310
		// (get) Token: 0x060055B1 RID: 21937 RVA: 0x004DA9F4 File Offset: 0x004D8BF4
		// (set) Token: 0x060055B2 RID: 21938 RVA: 0x004DAAA8 File Offset: 0x004D8CA8
		internal bool RadErgoCfgTrkBtnListKey_A21174_HiddenDynamic
		{
			get
			{
				short num = (short)452001793;
				if (num != 0)
				{
				}
				num = (short)783835363;
				short num2 = num;
				num = (short)1297309923;
				switch (num2 == num)
				{
				}
				num = (short)688979968;
				short num3 = num;
				num = (short)1321664512;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListKey_A21174.HiddenDynamic;
			}
			set
			{
				short num = (short)1110628472;
				short num2 = num;
				num = (short)733730936;
				switch (num2 == num)
				{
				}
				num = (short)1004339201;
				if (num != 0)
				{
				}
				num = (short)1056243712;
				short num3 = num;
				num = (short)2016149504;
				if (num != 0)
				{
				}
				this.radErgoCfgTrkBtnListKey_A21174.HiddenDynamic = value;
			}
		}

		// Token: 0x17002C2F RID: 11311
		// (get) Token: 0x060055B3 RID: 21939 RVA: 0x004DAB5C File Offset: 0x004D8D5C
		public bool RadErgoCfgTrkBtnListKey_A21174_HasDiffs
		{
			get
			{
				short num = (short)215220225;
				if (num != 0)
				{
				}
				num = (short)1168983331;
				short num2 = num;
				num = (short)1630160163;
				switch (num2 == num)
				{
				}
				num = (short)742785024;
				short num3 = num;
				num = (short)1487929344;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListKey_A21174._HasDiffs;
			}
		}

		// Token: 0x17002C30 RID: 11312
		// (get) Token: 0x060055B4 RID: 21940 RVA: 0x004DAC10 File Offset: 0x004D8E10
		// (set) Token: 0x060055B5 RID: 21941 RVA: 0x004DACC4 File Offset: 0x004D8EC4
		public int RadErgoCfgTrkBtnListType_A21167Value
		{
			get
			{
				short num = (short)1646304125;
				short num2 = num;
				num = (short)1982897021;
				switch (num2 == num)
				{
				}
				num = (short)91095041;
				if (num != 0)
				{
				}
				num = (short)989855744;
				short num3 = num;
				num = (short)958464000;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListType_A21167.Value;
			}
			set
			{
				short num = (short)888179999;
				short num2 = num;
				num = (short)153455903;
				switch (num2 == num)
				{
				}
				num = (short)709296128;
				if (num != 0)
				{
				}
				num = (short)1694957568;
				short num3 = num;
				num = (short)1125253121;
				if (num != 0)
				{
				}
				this.radErgoCfgTrkBtnListType_A21167.Value = value;
			}
		}

		// Token: 0x17002C31 RID: 11313
		// (get) Token: 0x060055B6 RID: 21942 RVA: 0x004DAD7C File Offset: 0x004D8F7C
		// (set) Token: 0x060055B7 RID: 21943 RVA: 0x004DAE30 File Offset: 0x004D9030
		public string RadErgoCfgTrkBtnListType_A21167_UIValue
		{
			get
			{
				short num = (short)518841738;
				short num2 = num;
				num = (short)1876878730;
				switch (num2 == num)
				{
				}
				num = (short)2008547329;
				if (num != 0)
				{
				}
				num = (short)2074476544;
				short num3 = num;
				num = (short)1206976512;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListType_A21167.UIValue;
			}
			set
			{
				short num = (short)912820364;
				short num2 = num;
				num = (short)1764001932;
				switch (num2 == num)
				{
				}
				num = (short)139395072;
				if (num != 0)
				{
				}
				num = (short)1222901760;
				short num3 = num;
				num = (short)98697217;
				if (num != 0)
				{
				}
				this.radErgoCfgTrkBtnListType_A21167.UIValue = value;
			}
		}

		// Token: 0x17002C32 RID: 11314
		// (get) Token: 0x060055B8 RID: 21944 RVA: 0x004DAEE4 File Offset: 0x004D90E4
		public global::AcpBusinessLayer.AcpListField RadErgoCfgTrkBtnListType_A21167
		{
			get
			{
				short num = (short)1911255748;
				short num2 = num;
				num = (short)327316164;
				switch (num2 == num)
				{
				}
				num = (short)870907905;
				if (num != 0)
				{
				}
				num = (short)911474688;
				short num3 = num;
				num = (short)1720451072;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListType_A21167;
			}
		}

		// Token: 0x17002C33 RID: 11315
		// (get) Token: 0x060055B9 RID: 21945 RVA: 0x004DAF90 File Offset: 0x004D9190
		// (set) Token: 0x060055BA RID: 21946 RVA: 0x004DB044 File Offset: 0x004D9244
		public bool RadErgoCfgTrkBtnListType_A21167_Applicable
		{
			get
			{
				short num = (short)171966465;
				if (num != 0)
				{
				}
				num = (short)839750481;
				short num2 = num;
				num = (short)112563025;
				switch (num2 == num)
				{
				}
				num = (short)153550848;
				short num3 = num;
				num = (short)872939520;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListType_A21167.Applicable;
			}
			set
			{
				short num = (short)1244906985;
				short num2 = num;
				num = (short)1337902569;
				switch (num2 == num)
				{
				}
				num = (short)104333313;
				if (num != 0)
				{
				}
				num = (short)1601372160;
				short num3 = num;
				num = (short)1710686208;
				if (num != 0)
				{
				}
				this.radErgoCfgTrkBtnListType_A21167.Applicable = value;
			}
		}

		// Token: 0x17002C34 RID: 11316
		// (get) Token: 0x060055BB RID: 21947 RVA: 0x004DB0FC File Offset: 0x004D92FC
		// (set) Token: 0x060055BC RID: 21948 RVA: 0x004DB1B0 File Offset: 0x004D93B0
		public bool RadErgoCfgTrkBtnListType_A21167_Valid
		{
			get
			{
				short num = (short)1922088585;
				short num2 = num;
				num = (short)1950531209;
				switch (num2 == num)
				{
				}
				num = (short)468189185;
				if (num != 0)
				{
				}
				num = (short)1292304384;
				short num3 = num;
				num = (short)1111752704;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListType_A21167.Valid;
			}
			set
			{
				short num = (short)362421163;
				short num2 = num;
				num = (short)722541483;
				switch (num2 == num)
				{
				}
				num = (short)1854341121;
				if (num != 0)
				{
				}
				num = (short)607191040;
				short num3 = num;
				num = (short)1833041920;
				if (num != 0)
				{
				}
				this.radErgoCfgTrkBtnListType_A21167.Valid = value;
			}
		}

		// Token: 0x17002C35 RID: 11317
		// (get) Token: 0x060055BD RID: 21949 RVA: 0x004DB264 File Offset: 0x004D9464
		// (set) Token: 0x060055BE RID: 21950 RVA: 0x004DB31C File Offset: 0x004D951C
		public bool RadErgoCfgTrkBtnListType_A21167_Visible
		{
			get
			{
				short num = (short)1560937840;
				short num2 = num;
				num = (short)962332016;
				switch (num2 == num)
				{
				}
				num = (short)307363841;
				if (num != 0)
				{
				}
				num = (short)1714880512;
				short num3 = num;
				num = (short)524288;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListType_A21167.Visible;
			}
			set
			{
				short num = (short)1981901627;
				short num2 = num;
				num = (short)1290234683;
				switch (num2 == num)
				{
				}
				num = (short)629080065;
				if (num != 0)
				{
				}
				num = (short)561577984;
				short num3 = num;
				num = (short)1823211520;
				if (num != 0)
				{
				}
				this.radErgoCfgTrkBtnListType_A21167.Visible = value;
			}
		}

		// Token: 0x17002C36 RID: 11318
		// (get) Token: 0x060055BF RID: 21951 RVA: 0x004DB3D4 File Offset: 0x004D95D4
		// (set) Token: 0x060055C0 RID: 21952 RVA: 0x004DB48C File Offset: 0x004D968C
		public bool RadErgoCfgTrkBtnListType_A21167_Editable
		{
			get
			{
				short num = (short)1996426434;
				short num2 = num;
				num = (short)655363266;
				switch (num2 == num)
				{
				}
				num = (short)151715840;
				if (num != 0)
				{
				}
				num = (short)693567488;
				short num3 = num;
				num = (short)1720254465;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListType_A21167.Editable;
			}
			set
			{
				short num = (short)1266998395;
				short num2 = num;
				num = (short)1792531579;
				switch (num2 == num)
				{
				}
				num = (short)2059337729;
				if (num != 0)
				{
				}
				num = (short)1694367744;
				short num3 = num;
				num = (short)325189632;
				if (num != 0)
				{
				}
				this.radErgoCfgTrkBtnListType_A21167.Editable = value;
			}
		}

		// Token: 0x17002C37 RID: 11319
		// (get) Token: 0x060055C1 RID: 21953 RVA: 0x004DB544 File Offset: 0x004D9744
		internal string RadErgoCfgTrkBtnListType_A21167_UILabel
		{
			get
			{
				short num = (short)662198441;
				short num2 = num;
				num = (short)766990505;
				switch (num2 == num)
				{
				}
				num = (short)1936392193;
				if (num != 0)
				{
				}
				num = (short)1595998208;
				short num3 = num;
				num = (short)845414400;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListType_A21167.UIName;
			}
		}

		// Token: 0x17002C38 RID: 11320
		// (get) Token: 0x060055C2 RID: 21954 RVA: 0x004DB5FC File Offset: 0x004D97FC
		// (set) Token: 0x060055C3 RID: 21955 RVA: 0x004DB6B0 File Offset: 0x004D98B0
		internal bool RadErgoCfgTrkBtnListType_A21167_HiddenStatic
		{
			get
			{
				short num = (short)1197015041;
				if (num != 0)
				{
				}
				num = (short)1369080484;
				short num2 = num;
				num = (short)417301156;
				switch (num2 == num)
				{
				}
				num = (short)1346174976;
				short num3 = num;
				num = (short)1629421568;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListType_A21167.HiddenStatic;
			}
			set
			{
				short num = (short)258605057;
				if (num != 0)
				{
				}
				num = (short)1087767405;
				short num2 = num;
				num = (short)1763640173;
				switch (num2 == num)
				{
				}
				num = (short)180027392;
				short num3 = num;
				num = (short)214237184;
				if (num != 0)
				{
				}
				this.radErgoCfgTrkBtnListType_A21167.HiddenStatic = value;
			}
		}

		// Token: 0x17002C39 RID: 11321
		// (get) Token: 0x060055C4 RID: 21956 RVA: 0x004DB764 File Offset: 0x004D9964
		// (set) Token: 0x060055C5 RID: 21957 RVA: 0x004DB818 File Offset: 0x004D9A18
		internal bool RadErgoCfgTrkBtnListType_A21167_HiddenDynamic
		{
			get
			{
				short num = (short)1282205992;
				short num2 = num;
				num = (short)1835395368;
				switch (num2 == num)
				{
				}
				num = (short)1512505345;
				if (num != 0)
				{
				}
				num = (short)1375404032;
				short num3 = num;
				num = (short)704577536;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListType_A21167.HiddenDynamic;
			}
			set
			{
				short num = (short)1852653708;
				short num2 = num;
				num = (short)1446133900;
				switch (num2 == num)
				{
				}
				num = (short)805306369;
				if (num != 0)
				{
				}
				num = (short)357957632;
				short num3 = num;
				num = (short)212336640;
				if (num != 0)
				{
				}
				this.radErgoCfgTrkBtnListType_A21167.HiddenDynamic = value;
			}
		}

		// Token: 0x17002C3A RID: 11322
		// (get) Token: 0x060055C6 RID: 21958 RVA: 0x004DB8CC File Offset: 0x004D9ACC
		public bool RadErgoCfgTrkBtnListType_A21167_HasDiffs
		{
			get
			{
				short num = (short)1509016461;
				short num2 = num;
				num = (short)1027851149;
				switch (num2 == num)
				{
				}
				num = (short)1746272257;
				if (num != 0)
				{
				}
				num = (short)256901120;
				short num3 = num;
				num = (short)279707648;
				if (num != 0)
				{
				}
				return this.radErgoCfgTrkBtnListType_A21167._HasDiffs;
			}
		}

		// Token: 0x060055C7 RID: 21959 RVA: 0x004DB980 File Offset: 0x004D9B80
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
					goto IL_142;
				case 1:
					if (base.ParentRecset != null)
					{
						num2 = (short)1538588675;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
					num2 = (short)381222916;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)1195966464;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_128;
				}
				goto IL_24;
			}
			IL_128:
			return result;
			IL_24:
			num2 = (short)1742236711;
			short num3 = num2;
			num2 = (short)996699175;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_142:
				if (base.ParentRecset.ContainerDoc != null)
				{
					num2 = (short)1604517890;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				break;
			default:
			{
				num2 = (short)1867644929;
				if (num2 != 0)
				{
				}
				num2 = (short)872873984;
				if (num2 != 0)
				{
				}
				num2 = (short)578224128;
				short num4 = num2;
				result = null;
				num2 = (short)733347841;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
			return result;
		}

		// Token: 0x04002180 RID: 8576
		private global::AcpBusinessLayer.AcpSimpleRangeField radErgoCfgTrkBtnListID_A21166;

		// Token: 0x04002181 RID: 8577
		private global::AcpBusinessLayer.AcpKeyField radErgoCfgTrkBtnListKey_A21174;

		// Token: 0x04002182 RID: 8578
		private global::AcpBusinessLayer.AcpListField radErgoCfgTrkBtnListType_A21167;
	}
}
