using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu
{
	// Token: 0x02000291 RID: 657
	[global::System.Serializable]
	public class Labtool : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06007358 RID: 29528 RVA: 0x0066705C File Offset: 0x0066525C
		public Labtool(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06007359 RID: 29529 RVA: 0x00667078 File Offset: 0x00665278
		protected Labtool(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x0600735A RID: 29530 RVA: 0x00667090 File Offset: 0x00665290
		public override void Init()
		{
			int a_ = 9;
			short num = (short)1645937049;
			short num2 = num;
			num = (short)275710361;
			switch (num2 == num)
			{
			}
			num = (short)1066860544;
			short num3 = num;
			num = (short)1725628417;
			if (num != 0)
			{
			}
			num = (short)2112684032;
			if (num != 0)
			{
			}
			this.dispMenuLabtoolCharacterEncodingType_A21738 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("軉ꗋ뷍ꃏ鿑뇓룕귗雙뷛볝铟跡诣諥ꯧ苩跫鳭釯釱胳鏵諷뿹鋻鷽濿昁洃栅漇帉甋縍甏䴑唓␕⤗ⴙ⼛☝", a_), global::CommonResources.AcgResources.ID_CHARACTERENCODINGTYPE, global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.DispMenuLabtoolCharacterEncodingType_A21738LovStrs);
			this.dispMenuLabtoolCharacterEncodingType_A21738.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.dispMenuLabtoolCharacterEncodingType_A21738.DataTransferOrder = 37;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蛉귋곍꓏뷑믓뫕", a_);
			base.Id = 10017;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 6;
		}

		// Token: 0x0600735B RID: 29531 RVA: 0x006671B4 File Offset: 0x006653B4
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 2;
			short num = (short)706412550;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)454819841;
					if (num != 0)
					{
					}
					if (producerFields != null)
					{
						num = (short)871759873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E6;
				case 1:
					goto IL_13E;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟂계듆마蛊꣌ꇎꓐ鿒듔뗖귘듚닜돞ꋠ询蓤闦裨裪駬諮菰뛲鯴银雸鿺铼釾昀圂簄眆氈吊䰌㴎‐␒☔⼖", a_)))
					{
						num = (short)1219428357;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E6;
				case 3:
					num = (short)1789657088;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_139;
				case 5:
					this.dispMenuLabtoolCharacterEncodingType_A21738 = new global::AcpBusinessLayer.AcpListField(0, this, global::AllFeatures.CodeplugGuid.b("蟂계듆마蛊꣌ꇎꓐ鿒듔뗖귘듚닜돞ꋠ询蓤闦裨裪駬諮菰뛲鯴银雸鿺铼釾昀圂簄眆氈吊䰌㴎‐␒☔⼖", a_), global::CommonResources.AcgResources.ID_CHARACTERENCODINGTYPE, global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.LOVs.DispMenuLabtoolCharacterEncodingType_A21738LovStrs);
					this.dispMenuLabtoolCharacterEncodingType_A21738.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.dispMenuLabtoolCharacterEncodingType_A21738.DataTransferOrder = 37;
					num = (short)1221197828;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_4A;
					}
					continue;
				}
				IL_4A:
				num = (short)119761379;
				short num3 = num;
				num = (short)1419209187;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_13E:
					num = (short)972161026;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
				{
					num = (short)1101463552;
					if (num != 0)
					{
					}
					num = (short)1229062144;
					short num4 = num;
					if (!global::AcpCommonLib.AppInfoManager.DropOperation)
					{
						goto IL_1E6;
					}
					num = (short)1448411139;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			IL_139:
			IL_1E6:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("迂꓄ꗆ뷈꓊ꋌꏎ", a_);
			base.Id = 10017;
			base.UIName = global::CommonResources.AcgResources.ID_LABTOOL;
			base.DataTransferOrder = 6;
		}

		// Token: 0x0600735C RID: 29532 RVA: 0x006673D8 File Offset: 0x006655D8
		public override void PopulateReferences()
		{
			short num = (short)681758960;
			short num2 = num;
			num = (short)1849676016;
			switch (num2 == num)
			{
			}
			num = (short)1764163584;
			short num3 = num;
			num = (short)2136473600;
			if (num != 0)
			{
			}
			num = (short)874053633;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600735D RID: 29533 RVA: 0x00667480 File Offset: 0x00665680
		public override void DropReferences()
		{
			short num = (short)1140029056;
			short num2 = num;
			num = (short)1235187328;
			switch (num2 == num)
			{
			}
			num = (short)1393360896;
			short num3 = num;
			num = (short)1129447424;
			if (num != 0)
			{
			}
			num = (short)1027342337;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600735E RID: 29534 RVA: 0x00667528 File Offset: 0x00665728
		public override void SetConstraints()
		{
			short num = (short)224973348;
			short num2 = num;
			num = (short)431215140;
			switch (num2 == num)
			{
			}
			num = (short)949420032;
			short num3 = num;
			num = (short)2080178177;
			if (num != 0)
			{
			}
			num = (short)2118582272;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600735F RID: 29535 RVA: 0x006675D0 File Offset: 0x006657D0
		public override void SetupDependencies()
		{
			short num = (short)1142161354;
			short num2 = num;
			num = (short)458686410;
			switch (num2 == num)
			{
			}
			num = (short)1730674689;
			if (num != 0)
			{
			}
			num = (short)1700134912;
			if (num != 0)
			{
			}
			num = (short)286457856;
			short num3 = num;
		}

		// Token: 0x17003B8B RID: 15243
		// (get) Token: 0x06007360 RID: 29536 RVA: 0x0066767C File Offset: 0x0066587C
		public bool HasDiffs
		{
			get
			{
				short num = (short)223418638;
				short num2 = num;
				num = (short)1379277070;
				switch (num2 == num)
				{
				}
				num = (short)1065811969;
				if (num != 0)
				{
				}
				num = (short)1569652736;
				if (num != 0)
				{
				}
				num = (short)1797783552;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17003B8C RID: 15244
		// (get) Token: 0x06007361 RID: 29537 RVA: 0x0066772C File Offset: 0x0066592C
		// (set) Token: 0x06007362 RID: 29538 RVA: 0x006677E4 File Offset: 0x006659E4
		public int DispMenuLabtoolCharacterEncodingType_A21738Value
		{
			get
			{
				short num = (short)521196247;
				short num2 = num;
				num = (short)42128087;
				switch (num2 == num)
				{
				}
				num = (short)1793916928;
				if (num != 0)
				{
				}
				num = (short)1742209025;
				if (num != 0)
				{
				}
				num = (short)98435072;
				short num3 = num;
				return this.dispMenuLabtoolCharacterEncodingType_A21738.Value;
			}
			set
			{
				short num = (short)858543699;
				short num2 = num;
				num = (short)227956307;
				switch (num2 == num)
				{
				}
				num = (short)280952833;
				if (num != 0)
				{
				}
				num = (short)348258304;
				if (num != 0)
				{
				}
				num = (short)1112670208;
				short num3 = num;
				this.dispMenuLabtoolCharacterEncodingType_A21738.Value = value;
			}
		}

		// Token: 0x17003B8D RID: 15245
		// (get) Token: 0x06007363 RID: 29539 RVA: 0x0066789C File Offset: 0x00665A9C
		// (set) Token: 0x06007364 RID: 29540 RVA: 0x00667954 File Offset: 0x00665B54
		public string DispMenuLabtoolCharacterEncodingType_A21738_UIValue
		{
			get
			{
				short num = (short)1601154911;
				short num2 = num;
				num = (short)557231967;
				switch (num2 == num)
				{
				}
				num = (short)1701707777;
				if (num != 0)
				{
				}
				num = (short)245104640;
				if (num != 0)
				{
				}
				num = (short)1732771840;
				short num3 = num;
				return this.dispMenuLabtoolCharacterEncodingType_A21738.UIValue;
			}
			set
			{
				short num = (short)1859194865;
				short num2 = num;
				num = (short)1957498865;
				switch (num2 == num)
				{
				}
				num = (short)1800077312;
				if (num != 0)
				{
				}
				num = (short)86507521;
				if (num != 0)
				{
				}
				num = (short)177143808;
				short num3 = num;
				this.dispMenuLabtoolCharacterEncodingType_A21738.UIValue = value;
			}
		}

		// Token: 0x17003B8E RID: 15246
		// (get) Token: 0x06007365 RID: 29541 RVA: 0x00667A0C File Offset: 0x00665C0C
		public global::AcpBusinessLayer.AcpListField DispMenuLabtoolCharacterEncodingType_A21738
		{
			get
			{
				short num = (short)137543073;
				short num2 = num;
				num = (short)700366241;
				switch (num2 == num)
				{
				}
				num = (short)362872833;
				if (num != 0)
				{
				}
				num = (short)964624384;
				if (num != 0)
				{
				}
				num = (short)305659904;
				short num3 = num;
				return this.dispMenuLabtoolCharacterEncodingType_A21738;
			}
		}

		// Token: 0x17003B8F RID: 15247
		// (get) Token: 0x06007366 RID: 29542 RVA: 0x00667AC0 File Offset: 0x00665CC0
		// (set) Token: 0x06007367 RID: 29543 RVA: 0x00667B74 File Offset: 0x00665D74
		public bool DispMenuLabtoolCharacterEncodingType_A21738_Applicable
		{
			get
			{
				short num = (short)290433205;
				short num2 = num;
				num = (short)1549772981;
				switch (num2 == num)
				{
				}
				num = (short)1136459777;
				if (num != 0)
				{
				}
				num = (short)1487273984;
				if (num != 0)
				{
				}
				num = (short)1161166848;
				short num3 = num;
				return this.dispMenuLabtoolCharacterEncodingType_A21738.Applicable;
			}
			set
			{
				short num = (short)69684764;
				short num2 = num;
				num = (short)1362382364;
				switch (num2 == num)
				{
				}
				num = (short)160169985;
				if (num != 0)
				{
				}
				num = (short)892076032;
				if (num != 0)
				{
				}
				num = (short)1721368576;
				short num3 = num;
				this.dispMenuLabtoolCharacterEncodingType_A21738.Applicable = value;
			}
		}

		// Token: 0x17003B90 RID: 15248
		// (get) Token: 0x06007368 RID: 29544 RVA: 0x00667C2C File Offset: 0x00665E2C
		// (set) Token: 0x06007369 RID: 29545 RVA: 0x00667CE0 File Offset: 0x00665EE0
		public bool DispMenuLabtoolCharacterEncodingType_A21738_Valid
		{
			get
			{
				short num = (short)940245095;
				short num2 = num;
				num = (short)407634023;
				switch (num2 == num)
				{
				}
				num = (short)221315073;
				if (num != 0)
				{
				}
				num = (short)2041315328;
				if (num != 0)
				{
				}
				num = (short)756940800;
				short num3 = num;
				return this.dispMenuLabtoolCharacterEncodingType_A21738.Valid;
			}
			set
			{
				short num = (short)1075500111;
				short num2 = num;
				num = (short)1574556751;
				switch (num2 == num)
				{
				}
				num = (short)324141057;
				if (num != 0)
				{
				}
				num = (short)442761216;
				if (num != 0)
				{
				}
				num = (short)594149376;
				short num3 = num;
				this.dispMenuLabtoolCharacterEncodingType_A21738.Valid = value;
			}
		}

		// Token: 0x17003B91 RID: 15249
		// (get) Token: 0x0600736A RID: 29546 RVA: 0x00667D94 File Offset: 0x00665F94
		// (set) Token: 0x0600736B RID: 29547 RVA: 0x00667E4C File Offset: 0x0066604C
		public bool DispMenuLabtoolCharacterEncodingType_A21738_Visible
		{
			get
			{
				short num = (short)136420961;
				short num2 = num;
				num = (short)1770495585;
				switch (num2 == num)
				{
				}
				num = (short)745996289;
				if (num != 0)
				{
				}
				num = (short)559087616;
				if (num != 0)
				{
				}
				num = (short)1514536960;
				short num3 = num;
				return this.dispMenuLabtoolCharacterEncodingType_A21738.Visible;
			}
			set
			{
				short num = (short)271416238;
				short num2 = num;
				num = (short)1073970094;
				switch (num2 == num)
				{
				}
				num = (short)155516929;
				if (num != 0)
				{
				}
				num = (short)174653440;
				if (num != 0)
				{
				}
				num = (short)1581973504;
				short num3 = num;
				this.dispMenuLabtoolCharacterEncodingType_A21738.Visible = value;
			}
		}

		// Token: 0x17003B92 RID: 15250
		// (get) Token: 0x0600736C RID: 29548 RVA: 0x00667F00 File Offset: 0x00666100
		// (set) Token: 0x0600736D RID: 29549 RVA: 0x00667FB8 File Offset: 0x006661B8
		public bool DispMenuLabtoolCharacterEncodingType_A21738_Editable
		{
			get
			{
				short num = (short)1205672536;
				short num2 = num;
				num = (short)961813080;
				switch (num2 == num)
				{
				}
				num = (short)456851457;
				if (num != 0)
				{
				}
				num = (short)2107179008;
				if (num != 0)
				{
				}
				num = (short)1256914944;
				short num3 = num;
				return this.dispMenuLabtoolCharacterEncodingType_A21738.Editable;
			}
			set
			{
				short num = (short)934543361;
				if (num != 0)
				{
				}
				num = (short)1565573791;
				short num2 = num;
				num = (short)1697170079;
				switch (num2 == num)
				{
				}
				num = (short)1539964928;
				if (num != 0)
				{
				}
				num = (short)1159528448;
				short num3 = num;
				this.dispMenuLabtoolCharacterEncodingType_A21738.Editable = value;
			}
		}

		// Token: 0x17003B93 RID: 15251
		// (get) Token: 0x0600736E RID: 29550 RVA: 0x0066806C File Offset: 0x0066626C
		internal string DispMenuLabtoolCharacterEncodingType_A21738_UILabel
		{
			get
			{
				short num = (short)1330701873;
				short num2 = num;
				num = (short)769713713;
				switch (num2 == num)
				{
				}
				num = (short)826081281;
				if (num != 0)
				{
				}
				num = (short)1972699136;
				if (num != 0)
				{
				}
				num = (short)181534720;
				short num3 = num;
				return this.dispMenuLabtoolCharacterEncodingType_A21738.UIName;
			}
		}

		// Token: 0x17003B94 RID: 15252
		// (get) Token: 0x0600736F RID: 29551 RVA: 0x00668120 File Offset: 0x00666320
		// (set) Token: 0x06007370 RID: 29552 RVA: 0x006681D4 File Offset: 0x006663D4
		internal bool DispMenuLabtoolCharacterEncodingType_A21738_HiddenStatic
		{
			get
			{
				short num = (short)1375723419;
				short num2 = num;
				num = (short)106880923;
				switch (num2 == num)
				{
				}
				num = (short)695402497;
				if (num != 0)
				{
				}
				num = (short)1288175616;
				if (num != 0)
				{
				}
				num = (short)205193216;
				short num3 = num;
				return this.dispMenuLabtoolCharacterEncodingType_A21738.HiddenStatic;
			}
			set
			{
				short num = (short)2105227011;
				short num2 = num;
				num = (short)1367291651;
				switch (num2 == num)
				{
				}
				num = (short)236453888;
				if (num != 0)
				{
				}
				num = (short)1014366209;
				if (num != 0)
				{
				}
				num = (short)2057109504;
				short num3 = num;
				this.dispMenuLabtoolCharacterEncodingType_A21738.HiddenStatic = value;
			}
		}

		// Token: 0x17003B95 RID: 15253
		// (get) Token: 0x06007371 RID: 29553 RVA: 0x00668288 File Offset: 0x00666488
		// (set) Token: 0x06007372 RID: 29554 RVA: 0x0066833C File Offset: 0x0066653C
		internal bool DispMenuLabtoolCharacterEncodingType_A21738_HiddenDynamic
		{
			get
			{
				short num = (short)2076241084;
				short num2 = num;
				num = (short)1380773052;
				switch (num2 == num)
				{
				}
				num = (short)677838848;
				if (num != 0)
				{
				}
				num = (short)1312358401;
				if (num != 0)
				{
				}
				num = (short)1469317120;
				short num3 = num;
				return this.dispMenuLabtoolCharacterEncodingType_A21738.HiddenDynamic;
			}
			set
			{
				short num = (short)857842279;
				short num2 = num;
				num = (short)1054909031;
				switch (num2 == num)
				{
				}
				num = (short)2022768640;
				if (num != 0)
				{
				}
				num = (short)935854081;
				if (num != 0)
				{
				}
				num = (short)1944322048;
				short num3 = num;
				this.dispMenuLabtoolCharacterEncodingType_A21738.HiddenDynamic = value;
			}
		}

		// Token: 0x17003B96 RID: 15254
		// (get) Token: 0x06007373 RID: 29555 RVA: 0x006683F0 File Offset: 0x006665F0
		public bool DispMenuLabtoolCharacterEncodingType_A21738_HasDiffs
		{
			get
			{
				short num = (short)1246391464;
				short num2 = num;
				num = (short)913337512;
				switch (num2 == num)
				{
				}
				num = (short)2073493505;
				if (num != 0)
				{
				}
				num = (short)364838912;
				if (num != 0)
				{
				}
				num = (short)1750663168;
				short num3 = num;
				return this.dispMenuLabtoolCharacterEncodingType_A21738._HasDiffs;
			}
		}

		// Token: 0x06007374 RID: 29556 RVA: 0x006684A4 File Offset: 0x006666A4
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			short num;
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_0A:
				num = (short)487325696;
				short num2 = num;
				switch (num3)
				{
				case 0:
				{
					num = (short)2062046392;
					short num4 = num;
					num = (short)1914721464;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C9;
					default:
						num = (short)1302790144;
						if (num != 0)
						{
						}
						num = (short)19988481;
						if (num != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)707395588;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 1:
					goto IL_C9;
				case 2:
					num = (short)1828061185;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (base.ParentRecset != null)
					{
						num = (short)125173762;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 4:
					return result;
				}
				goto IL_4D;
				IL_C9:
				if (base.ParentRecset.ContainerDoc == null)
				{
					break;
				}
				num = (short)1208680448;
				num3 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_4D:
			result = null;
			num = (short)1105461251;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x04002D08 RID: 11528
		private global::AcpBusinessLayer.AcpListField dispMenuLabtoolCharacterEncodingType_A21738;
	}
}
