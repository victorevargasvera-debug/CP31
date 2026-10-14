using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Shepherds
{
	// Token: 0x020001CB RID: 459
	[global::System.Serializable]
	public class ConventionalProductIndependentButtonListInnerSection : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06005322 RID: 21282 RVA: 0x004B7930 File Offset: 0x004B5B30
		public ConventionalProductIndependentButtonListInnerSection(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06005323 RID: 21283 RVA: 0x004B794C File Offset: 0x004B5B4C
		protected ConventionalProductIndependentButtonListInnerSection(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06005324 RID: 21284 RVA: 0x004B7964 File Offset: 0x004B5B64
		public override void Init()
		{
			int a_ = 6;
			short num = (short)1585512448;
			short num2 = num;
			num = (short)1017974047;
			short num3 = num;
			num = (short)636685599;
			switch (num3 == num)
			{
			}
			num = (short)146669569;
			if (num != 0)
			{
			}
			num = (short)1217593344;
			if (num != 0)
			{
			}
			this.conventionalProductIndependentButtonKey = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("蓆ꛈꗊ믌꫎뿐꟒볔룖럘뫚뇜连鏠賢臤鋦諨鿪ꓬ臮闰雲藴鋶韸鿺飼釾甀䄂瀄猆紈搊挌䐎琐樒", a_), global::CommonResources.AcgResources.ID_CONVENTIONALPRODUCTINDEPENDENTBUTTONKEY, 14);
			this.conventionalProductIndependentButtonKey.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
			this.conventionalProductIndependentButtonKey.DataTransferOrder = 12;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蓆ꛈꗊ믌꫎뿐꟒볔룖럘뫚뇜￞뇠釢諤菦鳨裪駬쿮룰鷲釴鋶觸黺鏼鯾搀洂焄✆䬈縊礌笎縐紒㔔嬖瀘栚検", a_);
			base.Id = 10026;
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALPRODUCTINDEPENDENTBUTTONLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06005325 RID: 21285 RVA: 0x004B7A80 File Offset: 0x004B5C80
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 3;
			short num = (short)834273280;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)192570219;
					short num3 = num;
					num = (short)2005427051;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C3;
					default:
						num = (short)826736640;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_93;
						}
						continue;
					}
					break;
				}
				case 1:
					goto IL_12D;
				case 2:
					num = (short)1452736517;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟃꧅ꛇ볉꧋ꃍ꓏믑믓룕맗뛙賛곝迟蛡釣藥鳧ꏩ苫諭闯英釳飵鳷鿹鋻諽䋿省瀃爅朇搉䜋欍椏", a_)))
					{
						num = (short)208535556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E0;
				case 4:
					this.conventionalProductIndependentButtonKey = new global::AcpBusinessLayer.AcpKeyField(this, global::AllFeatures.CodeplugGuid.b("蟃꧅ꛇ볉꧋ꃍ꓏믑믓룕맗뛙賛곝迟蛡釣藥鳧ꏩ苫諭闯英釳飵鳷鿹鋻諽䋿省瀃爅朇搉䜋欍椏", a_), global::CommonResources.AcgResources.ID_CONVENTIONALPRODUCTINDEPENDENTBUTTONKEY, 14);
					this.conventionalProductIndependentButtonKey.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Labtool;
					this.conventionalProductIndependentButtonKey.DataTransferOrder = 12;
					num = (short)1074003969;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)274857984;
					short num4 = num;
					if (producerFields != null)
					{
						num = (short)1962016774;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E0;
				}
				case 6:
					num = (short)336789507;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_93;
				IL_C3:
				num = (short)2014248962;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_93:
				num = (short)1211498497;
				if (num != 0)
				{
				}
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					goto IL_C3;
				}
				break;
			}
			IL_12D:
			IL_1E0:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("蟃꧅ꛇ볉꧋ꃍ꓏믑믓룕맗뛙ﳛ軝鋟跡胣鏥诧黩쳫꟭黯雱釳蛵鷷铹飻鯽滿瘁␃䐅紇縉砋愍縏㈑堓缕欗渙", a_);
			base.Id = 10026;
			base.UIName = global::CommonResources.AcgResources.ID_CONVENTIONALPRODUCTINDEPENDENTBUTTONLIST;
			base.DataTransferOrder = 1;
		}

		// Token: 0x06005326 RID: 21286 RVA: 0x004B7CA0 File Offset: 0x004B5EA0
		public override void PopulateReferences()
		{
			short num = (short)814350336;
			short num2 = num;
			num = (short)704078620;
			short num3 = num;
			num = (short)797664028;
			switch (num3 == num)
			{
			}
			num = (short)2123890689;
			if (num != 0)
			{
			}
			num = (short)1830682624;
			if (num != 0)
			{
			}
		}

		// Token: 0x06005327 RID: 21287 RVA: 0x004B7D4C File Offset: 0x004B5F4C
		public override void DropReferences()
		{
			short num = (short)576126976;
			short num2 = num;
			num = (short)931522540;
			short num3 = num;
			num = (short)880666604;
			switch (num3 == num)
			{
			}
			num = (short)113180672;
			if (num != 0)
			{
			}
			num = (short)1299906561;
			if (num != 0)
			{
			}
		}

		// Token: 0x06005328 RID: 21288 RVA: 0x004B7DF8 File Offset: 0x004B5FF8
		public override void SetConstraints()
		{
			short num = (short)970784768;
			short num2 = num;
			num = (short)1380056740;
			short num3 = num;
			num = (short)996736676;
			switch (num3 == num)
			{
			}
			num = (short)359792640;
			if (num != 0)
			{
			}
			num = (short)1383923713;
			if (num != 0)
			{
			}
		}

		// Token: 0x06005329 RID: 21289 RVA: 0x004B7EA4 File Offset: 0x004B60A4
		public override void SetupDependencies()
		{
			short num = (short)812974080;
			short num2 = num;
			num = (short)1916300699;
			short num3 = num;
			num = (short)1842179483;
			switch (num3 == num)
			{
			}
			num = (short)48627713;
			if (num != 0)
			{
			}
			num = (short)1987313664;
			if (num != 0)
			{
			}
		}

		// Token: 0x17002B13 RID: 11027
		// (get) Token: 0x0600532A RID: 21290 RVA: 0x004B7F50 File Offset: 0x004B6150
		public bool HasDiffs
		{
			get
			{
				short num = (short)802160640;
				short num2 = num;
				num = (short)187891713;
				if (num != 0)
				{
				}
				num = (short)300117272;
				short num3 = num;
				num = (short)200305944;
				switch (num3 == num)
				{
				}
				num = (short)244187136;
				if (num != 0)
				{
				}
				return base._HasDiffs;
			}
		}

		// Token: 0x17002B14 RID: 11028
		// (get) Token: 0x0600532B RID: 21291 RVA: 0x004B8004 File Offset: 0x004B6204
		// (set) Token: 0x0600532C RID: 21292 RVA: 0x004B80B8 File Offset: 0x004B62B8
		public string ConventionalProductIndependentButtonKeyValue
		{
			get
			{
				short num = (short)1223688192;
				short num2 = num;
				num = (short)1981114586;
				short num3 = num;
				num = (short)1915185370;
				switch (num3 == num)
				{
				}
				num = (short)1580204033;
				if (num != 0)
				{
				}
				num = (short)1068433408;
				if (num != 0)
				{
				}
				return this.conventionalProductIndependentButtonKey.Value;
			}
			set
			{
				short num = (short)1426128896;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_14;
					case 1:
					{
						num = (short)2088669249;
						short num3 = num;
						num = (short)1138200641;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14;
						case 1:
							break;
						default:
						{
							num = (short)1739587584;
							short num4 = num;
							break;
						}
						}
						num = (short)2094727169;
						if (num != 0)
						{
						}
						num = (short)216006656;
						if (num != 0)
						{
						}
						this.conventionalProductIndependentButtonKey.Value = value;
						num = (short)1434976258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						return;
					}
					goto IL_30;
					IL_14:
					switch (0)
					{
					case 0:
						IL_30:
						if (string.IsNullOrEmpty(value.Trim()))
						{
							return;
						}
						num = (short)2110259201;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
		}

		// Token: 0x17002B15 RID: 11029
		// (get) Token: 0x0600532D RID: 21293 RVA: 0x004B81DC File Offset: 0x004B63DC
		// (set) Token: 0x0600532E RID: 21294 RVA: 0x004B828C File Offset: 0x004B648C
		public string ConventionalProductIndependentButtonKey_UIValue
		{
			get
			{
				short num = (short)1448869888;
				short num2 = num;
				num = (short)1995898881;
				if (num != 0)
				{
				}
				num = (short)2125849714;
				short num3 = num;
				num = (short)1560601714;
				switch (num3 == num)
				{
				}
				num = (short)1399848960;
				if (num != 0)
				{
				}
				return this.conventionalProductIndependentButtonKey.Value;
			}
			set
			{
				short num = (short)205455360;
				short num2 = num;
				num = (short)1969270399;
				short num3 = num;
				num = (short)141733503;
				switch (num3 == num)
				{
				}
				num = (short)1232863233;
				if (num != 0)
				{
				}
				num = (short)332660736;
				if (num != 0)
				{
				}
				this.conventionalProductIndependentButtonKey.Value = value;
			}
		}

		// Token: 0x17002B16 RID: 11030
		// (get) Token: 0x0600532F RID: 21295 RVA: 0x004B8344 File Offset: 0x004B6544
		public global::AcpBusinessLayer.AcpKeyField ConventionalProductIndependentButtonKey
		{
			get
			{
				short num = (short)429719552;
				short num2 = num;
				num = (short)1948057601;
				if (num != 0)
				{
				}
				num = (short)181501101;
				short num3 = num;
				num = (short)966032557;
				switch (num3 == num)
				{
				}
				num = (short)952565760;
				if (num != 0)
				{
				}
				return this.conventionalProductIndependentButtonKey;
			}
		}

		// Token: 0x17002B17 RID: 11031
		// (get) Token: 0x06005330 RID: 21296 RVA: 0x004B83F8 File Offset: 0x004B65F8
		// (set) Token: 0x06005331 RID: 21297 RVA: 0x004B84AC File Offset: 0x004B66AC
		public bool ConventionalProductIndependentButtonKey_Applicable
		{
			get
			{
				short num = (short)574357504;
				short num2 = num;
				num = (short)1264672084;
				short num3 = num;
				num = (short)239754580;
				switch (num3 == num)
				{
				}
				num = (short)1291583489;
				if (num != 0)
				{
				}
				num = (short)28573696;
				if (num != 0)
				{
				}
				return this.conventionalProductIndependentButtonKey.Applicable;
			}
			set
			{
				short num = (short)1586692096;
				short num2 = num;
				num = (short)145206498;
				short num3 = num;
				num = (short)187804898;
				switch (num3 == num)
				{
				}
				num = (short)1018363904;
				if (num != 0)
				{
				}
				num = (short)1018363905;
				if (num != 0)
				{
				}
				this.conventionalProductIndependentButtonKey.Applicable = value;
			}
		}

		// Token: 0x17002B18 RID: 11032
		// (get) Token: 0x06005332 RID: 21298 RVA: 0x004B8564 File Offset: 0x004B6764
		// (set) Token: 0x06005333 RID: 21299 RVA: 0x004B8618 File Offset: 0x004B6818
		public bool ConventionalProductIndependentButtonKey_Valid
		{
			get
			{
				short num = (short)1438580736;
				short num2 = num;
				num = (short)1318125314;
				short num3 = num;
				num = (short)329383682;
				switch (num3 == num)
				{
				}
				num = (short)382992385;
				if (num != 0)
				{
				}
				num = (short)2012807168;
				if (num != 0)
				{
				}
				return this.conventionalProductIndependentButtonKey.Valid;
			}
			set
			{
				short num = (short)1098973184;
				short num2 = num;
				num = (short)2137186478;
				short num3 = num;
				num = (short)1853415598;
				switch (num3 == num)
				{
				}
				num = (short)572391424;
				if (num != 0)
				{
				}
				num = (short)680984577;
				if (num != 0)
				{
				}
				this.conventionalProductIndependentButtonKey.Valid = value;
			}
		}

		// Token: 0x17002B19 RID: 11033
		// (get) Token: 0x06005334 RID: 21300 RVA: 0x004B86D0 File Offset: 0x004B68D0
		// (set) Token: 0x06005335 RID: 21301 RVA: 0x004B8784 File Offset: 0x004B6984
		public bool ConventionalProductIndependentButtonKey_Visible
		{
			get
			{
				short num = (short)1339621376;
				short num2 = num;
				num = (short)1703001164;
				short num3 = num;
				num = (short)523549772;
				switch (num3 == num)
				{
				}
				num = (short)1603272704;
				if (num != 0)
				{
				}
				num = (short)759627777;
				if (num != 0)
				{
				}
				return this.conventionalProductIndependentButtonKey.Visible;
			}
			set
			{
				short num = (short)1806893056;
				short num2 = num;
				num = (short)1125122049;
				if (num != 0)
				{
				}
				num = (short)930269651;
				short num3 = num;
				num = (short)1000655315;
				switch (num3 == num)
				{
				}
				num = (short)475004928;
				if (num != 0)
				{
				}
				this.conventionalProductIndependentButtonKey.Visible = value;
			}
		}

		// Token: 0x17002B1A RID: 11034
		// (get) Token: 0x06005336 RID: 21302 RVA: 0x004B8838 File Offset: 0x004B6A38
		// (set) Token: 0x06005337 RID: 21303 RVA: 0x004B88F0 File Offset: 0x004B6AF0
		public bool ConventionalProductIndependentButtonKey_Editable
		{
			get
			{
				short num = (short)705298432;
				short num2 = num;
				num = (short)1005918700;
				short num3 = num;
				num = (short)1184504300;
				switch (num3 == num)
				{
				}
				num = (short)1661206528;
				if (num != 0)
				{
				}
				num = (short)1082195969;
				if (num != 0)
				{
				}
				return this.conventionalProductIndependentButtonKey.Editable;
			}
			set
			{
				short num = (short)591265792;
				short num2 = num;
				num = (short)465060962;
				short num3 = num;
				num = (short)1648444514;
				switch (num3 == num)
				{
				}
				num = (short)728694785;
				if (num != 0)
				{
				}
				num = (short)779157504;
				if (num != 0)
				{
				}
				this.conventionalProductIndependentButtonKey.Editable = value;
			}
		}

		// Token: 0x17002B1B RID: 11035
		// (get) Token: 0x06005338 RID: 21304 RVA: 0x004B89A4 File Offset: 0x004B6BA4
		internal string ConventionalProductIndependentButtonKey_UILabel
		{
			get
			{
				short num = (short)2146304000;
				short num2 = num;
				num = (short)1211654007;
				short num3 = num;
				num = (short)1769758583;
				switch (num3 == num)
				{
				}
				num = (short)683933697;
				if (num != 0)
				{
				}
				num = (short)1105395712;
				if (num != 0)
				{
				}
				return this.conventionalProductIndependentButtonKey.UIName;
			}
		}

		// Token: 0x17002B1C RID: 11036
		// (get) Token: 0x06005339 RID: 21305 RVA: 0x004B8A58 File Offset: 0x004B6C58
		// (set) Token: 0x0600533A RID: 21306 RVA: 0x004B8B0C File Offset: 0x004B6D0C
		internal bool ConventionalProductIndependentButtonKey_HiddenStatic
		{
			get
			{
				short num = (short)914554880;
				short num2 = num;
				num = (short)462652909;
				short num3 = num;
				num = (short)1873839597;
				switch (num3 == num)
				{
				}
				num = (short)121634817;
				if (num != 0)
				{
				}
				num = (short)1722417152;
				if (num != 0)
				{
				}
				return this.conventionalProductIndependentButtonKey.HiddenStatic;
			}
			set
			{
				short num = (short)100794368;
				short num2 = num;
				num = (short)118620161;
				if (num != 0)
				{
				}
				num = (short)27742803;
				short num3 = num;
				num = (short)974672467;
				switch (num3 == num)
				{
				}
				num = (short)732430336;
				if (num != 0)
				{
				}
				this.conventionalProductIndependentButtonKey.HiddenStatic = value;
			}
		}

		// Token: 0x17002B1D RID: 11037
		// (get) Token: 0x0600533B RID: 21307 RVA: 0x004B8BC0 File Offset: 0x004B6DC0
		// (set) Token: 0x0600533C RID: 21308 RVA: 0x004B8C74 File Offset: 0x004B6E74
		internal bool ConventionalProductIndependentButtonKey_HiddenDynamic
		{
			get
			{
				short num = (short)118358016;
				short num2 = num;
				num = (short)633037037;
				short num3 = num;
				num = (short)2117099757;
				switch (num3 == num)
				{
				}
				num = (short)1300758528;
				if (num != 0)
				{
				}
				num = (short)1947598849;
				if (num != 0)
				{
				}
				return this.conventionalProductIndependentButtonKey.HiddenDynamic;
			}
			set
			{
				short num = (short)81723392;
				short num2 = num;
				num = (short)1312028503;
				short num3 = num;
				num = (short)1494742871;
				switch (num3 == num)
				{
				}
				num = (short)218693633;
				if (num != 0)
				{
				}
				num = (short)1708589056;
				if (num != 0)
				{
				}
				this.conventionalProductIndependentButtonKey.HiddenDynamic = value;
			}
		}

		// Token: 0x17002B1E RID: 11038
		// (get) Token: 0x0600533D RID: 21309 RVA: 0x004B8D28 File Offset: 0x004B6F28
		public bool ConventionalProductIndependentButtonKey_HasDiffs
		{
			get
			{
				short num = (short)716111872;
				short num2 = num;
				num = (short)1653909193;
				short num3 = num;
				num = (short)394831561;
				switch (num3 == num)
				{
				}
				num = (short)5832704;
				if (num != 0)
				{
				}
				num = (short)759496705;
				if (num != 0)
				{
				}
				return this.conventionalProductIndependentButtonKey._HasDiffs;
			}
		}

		// Token: 0x0600533E RID: 21310 RVA: 0x004B8DDC File Offset: 0x004B6FDC
		private global::AcpCommonLib.IAcpRecordset a(int A_0)
		{
			short num = (short)31916032;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			int num3;
			global::AcpCommonLib.IAcpRecordset result;
			for (;;)
			{
				IL_33:
				switch (num3)
				{
				case 0:
					if (base.ParentRecset != null)
					{
						num = (short)18415617;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 1:
					num = (short)1070858243;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return result;
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num = (short)1577975812;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 4:
				{
					num = (short)1281034624;
					short num4 = num;
					num = (short)107481472;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)2054356992;
						if (num != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num = (short)143851522;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				goto IL_4D;
			}
			return result;
			IL_4D:
			num = (short)1605697537;
			if (num != 0)
			{
			}
			result = null;
			num = (short)2069823488;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_33;
		}

		// Token: 0x04001FAD RID: 8109
		private global::AcpBusinessLayer.AcpKeyField conventionalProductIndependentButtonKey;
	}
}
