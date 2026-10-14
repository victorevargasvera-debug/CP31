using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioInformation
{
	// Token: 0x020001A7 RID: 423
	[global::System.Serializable]
	public class DepotKeyInfo : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06004521 RID: 17697 RVA: 0x00404A40 File Offset: 0x00402C40
		public DepotKeyInfo(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06004522 RID: 17698 RVA: 0x00404A5C File Offset: 0x00402C5C
		protected DepotKeyInfo(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06004523 RID: 17699 RVA: 0x00404A74 File Offset: 0x00402C74
		public override void Init()
		{
			int a_ = 14;
			short num = (short)510388382;
			short num2 = num;
			num = (short)1058990238;
			switch (num2 == num)
			{
			}
			num = (short)538050561;
			if (num != 0)
			{
			}
			num = (short)1037303808;
			if (num != 0)
			{
			}
			num = (short)377421824;
			short num3 = num;
			this.radInfoDepotKeySerialNumber_42793 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("ￎ퇠폢헤ퟦ\ud9e8\udbea\uddec", a_), this, global::AllFeatures.CodeplugGuid.b("鷎냐럒鳔맖뿘듚駜뫞釠賢釤곦賨鋪뻬諮菰髲铴鯶럸軺郼鷾搀焂娄㌆㬈㰊㐌㰎", a_), global::CommonResources.AcgResources.ID_DEPOTKEYSERIALNUMBER, 16);
			this.radInfoDepotKeySerialNumber_42793.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Depot;
			this.radInfoDepotKeySerialNumber_42793.DataTransferOrder = -1;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("诎듐ꏒ뫔ꏖ律郚룜ꛞ쇠ꫢ诤臦蛨", a_);
			base.Id = 10803;
			base.UIName = global::CommonResources.AcgResources.ID_DEPOTKEYINFO;
			base.DataTransferOrder = 8;
		}

		// Token: 0x06004524 RID: 17700 RVA: 0x00404B9C File Offset: 0x00402D9C
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 0;
			short num = (short)1382809603;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1310654465;
					if (num != 0)
					{
					}
					if (producerFields != null)
					{
						num = (short)1909522437;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1ED;
				case 1:
					goto IL_13F;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ軆ꟈ귊ꋌ诎듐ꏒ뫔ꏖ鋘뻚ꓜ賞蓠釢賤蛦藨ꗪ飬苮鏰雲蟴ꣶ췸짺쫼웾㈀", a_)))
					{
						num = (short)1722613766;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1ED;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_4B;
					}
					continue;
				case 4:
					num = (short)125173760;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)1369178114;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					num = (short)934880207;
					short num3 = num;
					num = (short)1071588303;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)390201344;
						if (num != 0)
						{
						}
						this.radInfoDepotKeySerialNumber_42793 = new global::AcpBusinessLayer.AcpStringField(global::AllFeatures.CodeplugGuid.b("杻﯊﷌ￎ", a_), this, global::AllFeatures.CodeplugGuid.b("鏀ꋂꇄ軆ꟈ귊ꋌ诎듐ꏒ뫔ꏖ鋘뻚ꓜ賞蓠釢賤蛦藨ꗪ飬苮鏰雲蟴ꣶ췸짺쫼웾㈀", a_), global::CommonResources.AcgResources.ID_DEPOTKEYSERIALNUMBER, 16);
						this.radInfoDepotKeySerialNumber_42793.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Depot;
						this.radInfoDepotKeySerialNumber_42793.DataTransferOrder = -1;
						break;
					}
					num = (short)662503425;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_4B:
				if (!global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					break;
				}
				num = (short)1944715264;
				short num4 = num;
				num = (short)225640452;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_13F:
			IL_1ED:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("藀ꛂ뗄꣆뷈蛌꫎꣐鳔맖뿘듚", a_);
			base.Id = 10803;
			base.UIName = global::CommonResources.AcgResources.ID_DEPOTKEYINFO;
			base.DataTransferOrder = 8;
		}

		// Token: 0x06004525 RID: 17701 RVA: 0x00404DC8 File Offset: 0x00402FC8
		public override void PopulateReferences()
		{
			short num = (short)1306761603;
			short num2 = num;
			num = (short)530225539;
			switch (num2 == num)
			{
			}
			num = (short)1991114753;
			if (num != 0)
			{
			}
			num = (short)567869440;
			if (num != 0)
			{
			}
			num = (short)821821440;
			short num3 = num;
		}

		// Token: 0x06004526 RID: 17702 RVA: 0x00404E74 File Offset: 0x00403074
		public override void DropReferences()
		{
			short num = (short)498216365;
			short num2 = num;
			num = (short)1086139821;
			switch (num2 == num)
			{
			}
			num = (short)1877737473;
			if (num != 0)
			{
			}
			num = (short)891879424;
			if (num != 0)
			{
			}
			num = (short)758906880;
			short num3 = num;
		}

		// Token: 0x06004527 RID: 17703 RVA: 0x00404F20 File Offset: 0x00403120
		public override void SetConstraints()
		{
			short num = (short)503352907;
			short num2 = num;
			num = (short)1740934731;
			switch (num2 == num)
			{
			}
			num = (short)1606483969;
			if (num != 0)
			{
			}
			num = (short)1754333184;
			if (num != 0)
			{
			}
			num = (short)308019200;
			short num3 = num;
			this.radInfoDepotKeySerialNumber_42793.IsEditable = new global::AcpCommonLib.StateConstraint(global::AcpBusinessLayer.AcpConstraints.AcpAlwaysNonEditable);
		}

		// Token: 0x06004528 RID: 17704 RVA: 0x00404FE0 File Offset: 0x004031E0
		public override void SetupDependencies()
		{
			short num = (short)1970837588;
			short num2 = num;
			num = (short)200710228;
			switch (num2 == num)
			{
			}
			num = (short)887685121;
			if (num != 0)
			{
			}
			num = (short)649330688;
			if (num != 0)
			{
			}
			num = (short)330366976;
			short num3 = num;
		}

		// Token: 0x17002376 RID: 9078
		// (get) Token: 0x06004529 RID: 17705 RVA: 0x00405088 File Offset: 0x00403288
		public bool HasDiffs
		{
			get
			{
				short num = (short)182954761;
				short num2 = num;
				num = (short)657369865;
				switch (num2 == num)
				{
				}
				num = (short)723714049;
				if (num != 0)
				{
				}
				num = (short)1823277056;
				if (num != 0)
				{
				}
				num = (short)50790400;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17002377 RID: 9079
		// (get) Token: 0x0600452A RID: 17706 RVA: 0x00405138 File Offset: 0x00403338
		// (set) Token: 0x0600452B RID: 17707 RVA: 0x004051F0 File Offset: 0x004033F0
		public string RadInfoDepotKeySerialNumber_42793Value
		{
			get
			{
				short num = (short)714014721;
				if (num != 0)
				{
				}
				num = (short)1764800624;
				short num2 = num;
				num = (short)1846655088;
				switch (num2 == num)
				{
				}
				num = (short)1336803328;
				if (num != 0)
				{
				}
				num = (short)1519124480;
				short num3 = num;
				return this.radInfoDepotKeySerialNumber_42793.Value;
			}
			set
			{
				short num = (short)1539571713;
				if (num != 0)
				{
				}
				num = (short)1275335442;
				short num2 = num;
				num = (short)288559890;
				switch (num2 == num)
				{
				}
				num = (short)116064256;
				if (num != 0)
				{
				}
				num = (short)671416320;
				short num3 = num;
				this.radInfoDepotKeySerialNumber_42793.Value = value;
			}
		}

		// Token: 0x17002378 RID: 9080
		// (get) Token: 0x0600452C RID: 17708 RVA: 0x004052A4 File Offset: 0x004034A4
		public global::AcpBusinessLayer.AcpField<string> RadInfoDepotKeySerialNumber_42793
		{
			get
			{
				short num = (short)1285616952;
				short num2 = num;
				num = (short)318567736;
				switch (num2 == num)
				{
				}
				num = (short)1431437312;
				if (num != 0)
				{
				}
				num = (short)2017460225;
				if (num != 0)
				{
				}
				num = (short)439549952;
				short num3 = num;
				return this.radInfoDepotKeySerialNumber_42793;
			}
		}

		// Token: 0x17002379 RID: 9081
		// (get) Token: 0x0600452D RID: 17709 RVA: 0x00405354 File Offset: 0x00403554
		// (set) Token: 0x0600452E RID: 17710 RVA: 0x0040540C File Offset: 0x0040360C
		public string RadInfoDepotKeySerialNumber_42793_UIValue
		{
			get
			{
				short num = (short)1889796097;
				if (num != 0)
				{
				}
				num = (short)878908077;
				short num2 = num;
				num = (short)1254036141;
				switch (num2 == num)
				{
				}
				num = (short)1191378944;
				if (num != 0)
				{
				}
				num = (short)1933115392;
				short num3 = num;
				return this.radInfoDepotKeySerialNumber_42793.Value;
			}
			set
			{
				short num = (short)667422782;
				short num2 = num;
				num = (short)732762174;
				switch (num2 == num)
				{
				}
				num = (short)77791233;
				if (num != 0)
				{
				}
				num = (short)2014576640;
				if (num != 0)
				{
				}
				num = (short)1822949376;
				short num3 = num;
				this.radInfoDepotKeySerialNumber_42793.Value = value;
			}
		}

		// Token: 0x1700237A RID: 9082
		// (get) Token: 0x0600452F RID: 17711 RVA: 0x004054C0 File Offset: 0x004036C0
		// (set) Token: 0x06004530 RID: 17712 RVA: 0x00405578 File Offset: 0x00403778
		public bool RadInfoDepotKeySerialNumber_42793_Applicable
		{
			get
			{
				short num = (short)1688522850;
				short num2 = num;
				num = (short)277139554;
				switch (num2 == num)
				{
				}
				num = (short)826933248;
				if (num != 0)
				{
				}
				num = (short)27131905;
				if (num != 0)
				{
				}
				num = (short)1068761088;
				short num3 = num;
				return this.radInfoDepotKeySerialNumber_42793.Applicable;
			}
			set
			{
				short num = (short)2130918285;
				short num2 = num;
				num = (short)555039629;
				switch (num2 == num)
				{
				}
				num = (short)1509883905;
				if (num != 0)
				{
				}
				num = (short)2059993088;
				if (num != 0)
				{
				}
				num = (short)702808064;
				short num3 = num;
				this.radInfoDepotKeySerialNumber_42793.Applicable = value;
			}
		}

		// Token: 0x1700237B RID: 9083
		// (get) Token: 0x06004531 RID: 17713 RVA: 0x00405630 File Offset: 0x00403830
		// (set) Token: 0x06004532 RID: 17714 RVA: 0x004056E4 File Offset: 0x004038E4
		public bool RadInfoDepotKeySerialNumber_42793_Valid
		{
			get
			{
				short num = (short)782050172;
				short num2 = num;
				num = (short)1754669948;
				switch (num2 == num)
				{
				}
				num = (short)1077608448;
				if (num != 0)
				{
				}
				num = (short)221446145;
				if (num != 0)
				{
				}
				num = (short)2133852160;
				short num3 = num;
				return this.radInfoDepotKeySerialNumber_42793.Valid;
			}
			set
			{
				short num = (short)1965568695;
				short num2 = num;
				num = (short)435958455;
				switch (num2 == num)
				{
				}
				num = (short)1607860225;
				if (num != 0)
				{
				}
				num = (short)240254976;
				if (num != 0)
				{
				}
				num = (short)1970733056;
				short num3 = num;
				this.radInfoDepotKeySerialNumber_42793.Valid = value;
			}
		}

		// Token: 0x1700237C RID: 9084
		// (get) Token: 0x06004533 RID: 17715 RVA: 0x0040579C File Offset: 0x0040399C
		// (set) Token: 0x06004534 RID: 17716 RVA: 0x00405854 File Offset: 0x00403A54
		public bool RadInfoDepotKeySerialNumber_42793_Visible
		{
			get
			{
				short num = (short)1172507925;
				short num2 = num;
				num = (short)861801749;
				switch (num2 == num)
				{
				}
				num = (short)1310851073;
				if (num != 0)
				{
				}
				num = (short)2083586048;
				if (num != 0)
				{
				}
				num = (short)2061041664;
				short num3 = num;
				return this.radInfoDepotKeySerialNumber_42793.Visible;
			}
			set
			{
				short num = (short)264780652;
				short num2 = num;
				num = (short)1274690412;
				switch (num2 == num)
				{
				}
				num = (short)1130037249;
				if (num != 0)
				{
				}
				num = (short)854589440;
				if (num != 0)
				{
				}
				num = (short)793444352;
				short num3 = num;
				this.radInfoDepotKeySerialNumber_42793.Visible = value;
			}
		}

		// Token: 0x1700237D RID: 9085
		// (get) Token: 0x06004535 RID: 17717 RVA: 0x00405908 File Offset: 0x00403B08
		// (set) Token: 0x06004536 RID: 17718 RVA: 0x004059BC File Offset: 0x00403BBC
		public bool RadInfoDepotKeySerialNumber_42793_Editable
		{
			get
			{
				short num = (short)1093861377;
				if (num != 0)
				{
				}
				num = (short)505870979;
				short num2 = num;
				num = (short)1343683203;
				switch (num2 == num)
				{
				}
				num = (short)2101084160;
				if (num != 0)
				{
				}
				num = (short)236388352;
				short num3 = num;
				return this.radInfoDepotKeySerialNumber_42793.Editable;
			}
			set
			{
				short num = (short)601191779;
				short num2 = num;
				num = (short)184055139;
				switch (num2 == num)
				{
				}
				num = (short)468254721;
				if (num != 0)
				{
				}
				num = (short)1254555648;
				if (num != 0)
				{
				}
				num = (short)18743296;
				short num3 = num;
				this.radInfoDepotKeySerialNumber_42793.Editable = value;
			}
		}

		// Token: 0x1700237E RID: 9086
		// (get) Token: 0x06004537 RID: 17719 RVA: 0x00405A70 File Offset: 0x00403C70
		internal string RadInfoDepotKeySerialNumber_42793_UILabel
		{
			get
			{
				short num = (short)1722875905;
				if (num != 0)
				{
				}
				num = (short)239740836;
				short num2 = num;
				num = (short)1375741860;
				switch (num2 == num)
				{
				}
				num = (short)409600000;
				if (num != 0)
				{
				}
				num = (short)1000603648;
				short num3 = num;
				return this.radInfoDepotKeySerialNumber_42793.UIName;
			}
		}

		// Token: 0x1700237F RID: 9087
		// (get) Token: 0x06004538 RID: 17720 RVA: 0x00405B28 File Offset: 0x00403D28
		// (set) Token: 0x06004539 RID: 17721 RVA: 0x00405BDC File Offset: 0x00403DDC
		internal bool RadInfoDepotKeySerialNumber_42793_HiddenStatic
		{
			get
			{
				short num = (short)1767571457;
				if (num != 0)
				{
				}
				num = (short)50950658;
				short num2 = num;
				num = (short)895447554;
				switch (num2 == num)
				{
				default:
				{
					num = (short)997785600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1519386624;
				if (num != 0)
				{
				}
				return this.radInfoDepotKeySerialNumber_42793.HiddenStatic;
			}
			set
			{
				short num = (short)1085912553;
				short num2 = num;
				num = (short)1963701737;
				switch (num2 == num)
				{
				}
				num = (short)487194624;
				short num3 = num;
				num = (short)646316033;
				if (num != 0)
				{
				}
				num = (short)472383488;
				if (num != 0)
				{
				}
				this.radInfoDepotKeySerialNumber_42793.HiddenStatic = value;
			}
		}

		// Token: 0x17002380 RID: 9088
		// (get) Token: 0x0600453A RID: 17722 RVA: 0x00405C98 File Offset: 0x00403E98
		// (set) Token: 0x0600453B RID: 17723 RVA: 0x00405D50 File Offset: 0x00403F50
		internal bool RadInfoDepotKeySerialNumber_42793_HiddenDynamic
		{
			get
			{
				short num = (short)827013263;
				short num2 = num;
				num = (short)1419982991;
				switch (num2 == num)
				{
				}
				num = (short)1478098944;
				short num3 = num;
				num = (short)355139585;
				if (num != 0)
				{
				}
				num = (short)1435041792;
				if (num != 0)
				{
				}
				return this.radInfoDepotKeySerialNumber_42793.HiddenDynamic;
			}
			set
			{
				short num = (short)1625759121;
				short num2 = num;
				num = (short)168107409;
				switch (num2 == num)
				{
				}
				num = (short)12713984;
				short num3 = num;
				num = (short)2102067200;
				if (num != 0)
				{
				}
				num = (short)1387659265;
				if (num != 0)
				{
				}
				this.radInfoDepotKeySerialNumber_42793.HiddenDynamic = value;
			}
		}

		// Token: 0x17002381 RID: 9089
		// (get) Token: 0x0600453C RID: 17724 RVA: 0x00405E08 File Offset: 0x00404008
		public bool RadInfoDepotKeySerialNumber_42793_HasDiffs
		{
			get
			{
				short num = (short)1501465440;
				short num2 = num;
				num = (short)279481184;
				switch (num2 == num)
				{
				}
				num = (short)1293484032;
				short num3 = num;
				num = (short)2028404737;
				if (num != 0)
				{
				}
				num = (short)1320943616;
				if (num != 0)
				{
				}
				return this.radInfoDepotKeySerialNumber_42793._HasDiffs;
			}
		}

		// Token: 0x0600453D RID: 17725 RVA: 0x00405EBC File Offset: 0x004040BC
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
					return result;
				case 1:
					if (base.ParentRecset != null)
					{
						num2 = (short)1421017091;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					if (base.ParentRecset.ContainerDoc != null)
					{
						goto IL_DE;
					}
					return result;
				case 3:
					num2 = (short)848035842;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					num2 = (short)1802668530;
					short num3 = num2;
					num2 = (short)950241778;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DE;
					default:
					{
						num2 = (short)1370095617;
						if (num2 != 0)
						{
						}
						num2 = (short)60620800;
						if (num2 != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)50528256;
						short num4 = num2;
						num2 = (short)698482688;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_24;
				IL_DE:
				num2 = (short)566820868;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)583073793;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04001A79 RID: 6777
		private global::AcpBusinessLayer.AcpField<string> radInfoDepotKeySerialNumber_42793;
	}
}
