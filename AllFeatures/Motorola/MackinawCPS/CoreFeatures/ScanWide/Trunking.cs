using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ScanWide
{
	// Token: 0x0200010E RID: 270
	[global::System.Serializable]
	public class Trunking : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x060027A8 RID: 10152 RVA: 0x002686A8 File Offset: 0x002668A8
		public Trunking(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x060027A9 RID: 10153 RVA: 0x002686C4 File Offset: 0x002668C4
		protected Trunking(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x060027AA RID: 10154 RVA: 0x002686DC File Offset: 0x002668DC
		public override void Init()
		{
			int a_ = 4;
			short num = (short)1022259939;
			short num2 = num;
			num = (short)850621155;
			switch (num2 == num)
			{
			}
			num = (short)1440874496;
			if (num != 0)
			{
			}
			num = (short)1330118657;
			if (num != 0)
			{
			}
			num = (short)1438056448;
			short num3 = num;
			this.scanWideTrunkingFailsoftHoldTimesec_A8009 = new global::AcpBusinessLayer.AcpSimpleRangeField(6, this, global::AllFeatures.CodeplugGuid.b("雄꓆꣈ꗊ髌ꛎ뗐뛒臔ꗖ곘뗚뛜뛞迠蓢ꏤ蛦胨蟪黬胮韰蟲뷴飶闸鿺ꧼ雾氀昂瘄戆樈吊䰌㜎ℐ⌒Ⱄ", a_), global::CommonResources.AcgResources.ID_FAILSOFTHOLDTIMESEC, 0, 255, global::CommonResources.AcgResources.ID_DISABLED, null, 0, 1);
			this.scanWideTrunkingFailsoftHoldTimesec_A8009.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.scanWideTrunkingFailsoftHoldTimesec_A8009.DataTransferOrder = 6;
			this.scanWideTrunkingFailsoftHoldTimesec_A8009.ShowHexValue = false;
			this.scanWideTrunkingSystemSearchTimesec_A9250 = new global::AcpBusinessLayer.AcpSimpleRangeField(2, this, global::AllFeatures.CodeplugGuid.b("雄꓆꣈ꗊ髌ꛎ뗐뛒臔ꗖ곘뗚뛜뛞迠蓢뛤黦髨鿪裬苮ꋰ雲铴藶髸鏺ꧼ雾氀昂瘄戆樈吊䰌㘎⌐☒└", a_), global::CommonResources.AcgResources.ID_SYSTEMSEARCHTIMESEC, 1, 255, null, null, 0, 1);
			this.scanWideTrunkingSystemSearchTimesec_A9250.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.scanWideTrunkingSystemSearchTimesec_A9250.DataTransferOrder = 7;
			this.scanWideTrunkingSystemSearchTimesec_A9250.ShowHexValue = false;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("釄뗆볈ꗊꛌꛎ뿐듒", a_);
			base.Id = 10050;
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKING;
			base.DataTransferOrder = 3;
		}

		// Token: 0x060027AB RID: 10155 RVA: 0x00268860 File Offset: 0x00266A60
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 19;
			short num = (short)1078263817;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_25E;
				case 1:
				{
					num = (short)1730512804;
					short num3 = num;
					num = (short)2073397156;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_25E;
					default:
						num = (short)1358364672;
						if (num != 0)
						{
						}
						num = (short)1618411528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					num = (short)1344536581;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_210;
				case 4:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟓뗕맗듙诛럝蓟蟡냣铥鷧蓩蟫蟭黯闱ꟳ迵请軹駻鏽叿朁攃琅欇戉堋服紏眑朓猕笗䔙崛✝ሟᜡᐣ", a_)))
					{
						num = (short)1501429767;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B5;
				case 5:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("蟓뗕맗듙诛럝蓟蟡냣铥鷧蓩蟫蟭黯闱닳韵釷雹迻釽替瘁䰃椅搇渉堋服紏眑朓猕笗䔙崛☝ဟሡᴣ", a_)))
					{
						num = (short)489160704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C3;
				case 6:
					goto IL_C3;
				case 7:
					this.scanWideTrunkingSystemSearchTimesec_A9250 = new global::AcpBusinessLayer.AcpSimpleRangeField(2, this, global::AllFeatures.CodeplugGuid.b("蟓뗕맗듙诛럝蓟蟡냣铥鷧蓩蟫蟭黯闱ꟳ迵请軹駻鏽叿朁攃琅欇戉堋服紏眑朓猕笗䔙崛✝ሟᜡᐣ", a_), global::CommonResources.AcgResources.ID_SYSTEMSEARCHTIMESEC, null, null, 0, 1);
					this.scanWideTrunkingSystemSearchTimesec_A9250.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.scanWideTrunkingSystemSearchTimesec_A9250.DataTransferOrder = 7;
					this.scanWideTrunkingSystemSearchTimesec_A9250.ShowHexValue = false;
					num = (short)911540227;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (producerFields != null)
					{
						num = (short)1545863170;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2B5;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				}
				IL_56:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1804402689;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_C3:
				num = (short)1032585220;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_25E:
				num = (short)1160708097;
				if (num != 0)
				{
				}
				num = (short)711720960;
				short num4 = num;
				this.scanWideTrunkingFailsoftHoldTimesec_A8009 = new global::AcpBusinessLayer.AcpSimpleRangeField(6, this, global::AllFeatures.CodeplugGuid.b("蟓뗕맗듙诛럝蓟蟡냣铥鷧蓩蟫蟭黯闱닳韵釷雹迻釽替瘁䰃椅搇渉堋服紏眑朓猕笗䔙崛☝ဟሡᴣ", a_), global::CommonResources.AcgResources.ID_FAILSOFTHOLDTIMESEC, global::CommonResources.AcgResources.ID_DISABLED, null, 0, 1);
				this.scanWideTrunkingFailsoftHoldTimesec_A8009.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
				this.scanWideTrunkingFailsoftHoldTimesec_A8009.DataTransferOrder = 6;
				this.scanWideTrunkingFailsoftHoldTimesec_A8009.ShowHexValue = false;
				num = (short)329318406;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_210:
			IL_2B5:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("胓ꓕ귗듙럛럝軟藡", a_);
			base.Id = 10050;
			base.UIName = global::CommonResources.AcgResources.ID_TRUNKING;
			base.DataTransferOrder = 3;
		}

		// Token: 0x060027AC RID: 10156 RVA: 0x00268B54 File Offset: 0x00266D54
		public override void PopulateReferences()
		{
			short num = (short)373998570;
			short num2 = num;
			num = (short)2014495722;
			switch (num2 == num)
			{
			}
			num = (short)1717370880;
			if (num != 0)
			{
			}
			num = (short)862060545;
			if (num != 0)
			{
			}
			num = (short)1380581376;
			short num3 = num;
		}

		// Token: 0x060027AD RID: 10157 RVA: 0x00268C00 File Offset: 0x00266E00
		public override void DropReferences()
		{
			short num = (short)10307881;
			short num2 = num;
			num = (short)1692223785;
			switch (num2 == num)
			{
			}
			num = (short)1861419009;
			if (num != 0)
			{
			}
			num = (short)1779826688;
			if (num != 0)
			{
			}
			num = (short)1653473280;
			short num3 = num;
		}

		// Token: 0x060027AE RID: 10158 RVA: 0x00268CA8 File Offset: 0x00266EA8
		public override void SetConstraints()
		{
			short num = (short)1509836309;
			short num2 = num;
			num = (short)817645077;
			switch (num2 == num)
			{
			}
			num = (short)1169424385;
			if (num != 0)
			{
			}
			num = (short)1171456000;
			if (num != 0)
			{
			}
			num = (short)495452160;
			short num3 = num;
		}

		// Token: 0x060027AF RID: 10159 RVA: 0x00268D50 File Offset: 0x00266F50
		public override void SetupDependencies()
		{
			short num = (short)818484096;
			short num2 = num;
			num = (short)263721856;
			switch (num2 == num)
			{
			}
			num = (short)502923265;
			if (num != 0)
			{
			}
			num = (short)78053376;
			if (num != 0)
			{
			}
			num = (short)2042626048;
			short num3 = num;
		}

		// Token: 0x170013DD RID: 5085
		// (get) Token: 0x060027B0 RID: 10160 RVA: 0x00268DF8 File Offset: 0x00266FF8
		public bool HasDiffs
		{
			get
			{
				short num = (short)1349609616;
				short num2 = num;
				num = (short)1699244176;
				switch (num2 == num)
				{
				}
				num = (short)1995505665;
				if (num != 0)
				{
				}
				num = (short)1473314816;
				if (num != 0)
				{
				}
				num = (short)146014208;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x170013DE RID: 5086
		// (get) Token: 0x060027B1 RID: 10161 RVA: 0x00268EA4 File Offset: 0x002670A4
		// (set) Token: 0x060027B2 RID: 10162 RVA: 0x00268F58 File Offset: 0x00267158
		public int ScanWideTrunkingFailsoftHoldTimesec_A8009Value
		{
			get
			{
				short num = (short)877205923;
				short num2 = num;
				num = (short)2029132195;
				switch (num2 == num)
				{
				}
				num = (short)170000385;
				if (num != 0)
				{
				}
				num = (short)2098462720;
				if (num != 0)
				{
				}
				num = (short)500367360;
				short num3 = num;
				return this.scanWideTrunkingFailsoftHoldTimesec_A8009.Value;
			}
			set
			{
				short num = (short)509197341;
				short num2 = num;
				num = (short)1502329885;
				switch (num2 == num)
				{
				}
				num = (short)232521729;
				if (num != 0)
				{
				}
				num = (short)79167488;
				if (num != 0)
				{
				}
				num = (short)1668218880;
				short num3 = num;
				this.scanWideTrunkingFailsoftHoldTimesec_A8009.Value = value;
			}
		}

		// Token: 0x170013DF RID: 5087
		// (get) Token: 0x060027B3 RID: 10163 RVA: 0x00269010 File Offset: 0x00267210
		public global::AcpBusinessLayer.AcpSimpleRangeField ScanWideTrunkingFailsoftHoldTimesec_A8009
		{
			get
			{
				short num = (short)1852964865;
				if (num != 0)
				{
				}
				num = (short)1637864820;
				short num2 = num;
				num = (short)1620890996;
				switch (num2 == num)
				{
				}
				num = (short)1307443200;
				if (num != 0)
				{
				}
				num = (short)1144389632;
				short num3 = num;
				return this.scanWideTrunkingFailsoftHoldTimesec_A8009;
			}
		}

		// Token: 0x170013E0 RID: 5088
		// (get) Token: 0x060027B4 RID: 10164 RVA: 0x002690C0 File Offset: 0x002672C0
		// (set) Token: 0x060027B5 RID: 10165 RVA: 0x00269174 File Offset: 0x00267374
		public string ScanWideTrunkingFailsoftHoldTimesec_A8009_UIValue
		{
			get
			{
				short num = (short)1126935293;
				short num2 = num;
				num = (short)1809558269;
				switch (num2 == num)
				{
				}
				num = (short)2110455809;
				if (num != 0)
				{
				}
				num = (short)304939008;
				if (num != 0)
				{
				}
				num = (short)1610088448;
				short num3 = num;
				return this.scanWideTrunkingFailsoftHoldTimesec_A8009.UIValue;
			}
			set
			{
				short num = (short)1798813714;
				short num2 = num;
				num = (short)1241298962;
				switch (num2 == num)
				{
				}
				num = (short)700055552;
				if (num != 0)
				{
				}
				num = (short)396099585;
				if (num != 0)
				{
				}
				num = (short)129040384;
				short num3 = num;
				this.scanWideTrunkingFailsoftHoldTimesec_A8009.UIValue = value;
			}
		}

		// Token: 0x170013E1 RID: 5089
		// (get) Token: 0x060027B6 RID: 10166 RVA: 0x0026922C File Offset: 0x0026742C
		// (set) Token: 0x060027B7 RID: 10167 RVA: 0x002692E0 File Offset: 0x002674E0
		internal int ScanWideTrunkingFailsoftHoldTimesec_A8009Min
		{
			get
			{
				short num = (short)1311396980;
				short num2 = num;
				num = (short)1046566004;
				switch (num2 == num)
				{
				}
				num = (short)1114701825;
				if (num != 0)
				{
				}
				num = (short)1613889536;
				if (num != 0)
				{
				}
				num = (short)1936261120;
				short num3 = num;
				return this.scanWideTrunkingFailsoftHoldTimesec_A8009.Min;
			}
			set
			{
				short num = (short)1764596946;
				short num2 = num;
				num = (short)252484818;
				switch (num2 == num)
				{
				}
				num = (short)564527105;
				if (num != 0)
				{
				}
				num = (short)1775894528;
				if (num != 0)
				{
				}
				num = (short)722075648;
				short num3 = num;
				this.scanWideTrunkingFailsoftHoldTimesec_A8009.Min = value;
			}
		}

		// Token: 0x170013E2 RID: 5090
		// (get) Token: 0x060027B8 RID: 10168 RVA: 0x00269394 File Offset: 0x00267594
		// (set) Token: 0x060027B9 RID: 10169 RVA: 0x00269448 File Offset: 0x00267648
		internal int ScanWideTrunkingFailsoftHoldTimesec_A8009Max
		{
			get
			{
				short num = (short)271236756;
				short num2 = num;
				num = (short)1790623380;
				switch (num2 == num)
				{
				}
				num = (short)1484783617;
				if (num != 0)
				{
				}
				num = (short)359071744;
				if (num != 0)
				{
				}
				num = (short)1751777280;
				short num3 = num;
				return this.scanWideTrunkingFailsoftHoldTimesec_A8009.Max;
			}
			set
			{
				short num = (short)1746104478;
				short num2 = num;
				num = (short)1652519070;
				switch (num2 == num)
				{
				}
				num = (short)1135869952;
				if (num != 0)
				{
				}
				num = (short)486080513;
				if (num != 0)
				{
				}
				num = (short)1700200448;
				short num3 = num;
				this.scanWideTrunkingFailsoftHoldTimesec_A8009.Max = value;
			}
		}

		// Token: 0x170013E3 RID: 5091
		// (get) Token: 0x060027BA RID: 10170 RVA: 0x00269500 File Offset: 0x00267700
		// (set) Token: 0x060027BB RID: 10171 RVA: 0x002695B4 File Offset: 0x002677B4
		internal int ScanWideTrunkingFailsoftHoldTimesec_A8009Step
		{
			get
			{
				short num = (short)1160968930;
				short num2 = num;
				num = (short)922942178;
				switch (num2 == num)
				{
				}
				num = (short)1444872193;
				if (num != 0)
				{
				}
				num = (short)610009088;
				if (num != 0)
				{
				}
				num = (short)1975123968;
				short num3 = num;
				return this.scanWideTrunkingFailsoftHoldTimesec_A8009.StepSize;
			}
			set
			{
				short num = (short)682301;
				short num2 = num;
				num = (short)1510435133;
				switch (num2 == num)
				{
				}
				num = (short)55640064;
				if (num != 0)
				{
				}
				num = (short)906297345;
				if (num != 0)
				{
				}
				num = (short)190382080;
				short num3 = num;
				this.scanWideTrunkingFailsoftHoldTimesec_A8009.StepSize = value;
			}
		}

		// Token: 0x170013E4 RID: 5092
		// (get) Token: 0x060027BC RID: 10172 RVA: 0x00269668 File Offset: 0x00267868
		// (set) Token: 0x060027BD RID: 10173 RVA: 0x0026971C File Offset: 0x0026791C
		public bool ScanWideTrunkingFailsoftHoldTimesec_A8009_Applicable
		{
			get
			{
				short num = (short)565744046;
				short num2 = num;
				num = (short)2104136110;
				switch (num2 == num)
				{
				}
				num = (short)492634113;
				if (num != 0)
				{
				}
				num = (short)1788674048;
				if (num != 0)
				{
				}
				num = (short)1970733056;
				short num3 = num;
				return this.scanWideTrunkingFailsoftHoldTimesec_A8009.Applicable;
			}
			set
			{
				short num = (short)137297920;
				short num2 = num;
				num = (short)859979131;
				short num3 = num;
				num = (short)2075868539;
				switch (num3 == num)
				{
				}
				num = (short)2141192192;
				if (num != 0)
				{
				}
				num = (short)2026635265;
				if (num != 0)
				{
				}
				this.scanWideTrunkingFailsoftHoldTimesec_A8009.Applicable = value;
			}
		}

		// Token: 0x170013E5 RID: 5093
		// (get) Token: 0x060027BE RID: 10174 RVA: 0x002697D4 File Offset: 0x002679D4
		// (set) Token: 0x060027BF RID: 10175 RVA: 0x00269888 File Offset: 0x00267A88
		public bool ScanWideTrunkingFailsoftHoldTimesec_A8009_Valid
		{
			get
			{
				short num = (short)1795489792;
				short num2 = num;
				num = (short)1631584257;
				if (num != 0)
				{
				}
				num = (short)1931505633;
				short num3 = num;
				num = (short)2100391905;
				switch (num3 == num)
				{
				}
				num = (short)841744384;
				if (num != 0)
				{
				}
				return this.scanWideTrunkingFailsoftHoldTimesec_A8009.Valid;
			}
			set
			{
				short num = (short)831193088;
				short num2 = num;
				num = (short)287530180;
				short num3 = num;
				num = (short)1440373956;
				switch (num3 == num)
				{
				}
				num = (short)800980993;
				if (num != 0)
				{
				}
				num = (short)1516699648;
				if (num != 0)
				{
				}
				this.scanWideTrunkingFailsoftHoldTimesec_A8009.Valid = value;
			}
		}

		// Token: 0x170013E6 RID: 5094
		// (get) Token: 0x060027C0 RID: 10176 RVA: 0x0026993C File Offset: 0x00267B3C
		// (set) Token: 0x060027C1 RID: 10177 RVA: 0x002699F0 File Offset: 0x00267BF0
		public bool ScanWideTrunkingFailsoftHoldTimesec_A8009_Visible
		{
			get
			{
				short num = (short)114622464;
				short num2 = num;
				num = (short)2060320769;
				if (num != 0)
				{
				}
				num = (short)541314111;
				short num3 = num;
				num = (short)1802554431;
				switch (num3 == num)
				{
				}
				num = (short)1253441536;
				if (num != 0)
				{
				}
				return this.scanWideTrunkingFailsoftHoldTimesec_A8009.Visible;
			}
			set
			{
				short num = (short)655753216;
				short num2 = num;
				num = (short)1342069096;
				short num3 = num;
				num = (short)1317034344;
				switch (num3 == num)
				{
				}
				num = (short)1610153984;
				if (num != 0)
				{
				}
				num = (short)433717249;
				if (num != 0)
				{
				}
				this.scanWideTrunkingFailsoftHoldTimesec_A8009.Visible = value;
			}
		}

		// Token: 0x170013E7 RID: 5095
		// (get) Token: 0x060027C2 RID: 10178 RVA: 0x00269AA8 File Offset: 0x00267CA8
		// (set) Token: 0x060027C3 RID: 10179 RVA: 0x00269B5C File Offset: 0x00267D5C
		public bool ScanWideTrunkingFailsoftHoldTimesec_A8009_Editable
		{
			get
			{
				short num = (short)1333657600;
				short num2 = num;
				num = (short)69897154;
				short num3 = num;
				num = (short)1076202434;
				switch (num3 == num)
				{
				}
				num = (short)249298945;
				if (num != 0)
				{
				}
				num = (short)1366753280;
				if (num != 0)
				{
				}
				return this.scanWideTrunkingFailsoftHoldTimesec_A8009.Editable;
			}
			set
			{
				short num = (short)1269497856;
				short num2 = num;
				num = (short)614979654;
				short num3 = num;
				num = (short)599971910;
				switch (num3 == num)
				{
				}
				num = (short)1738014721;
				if (num != 0)
				{
				}
				num = (short)1839464448;
				if (num != 0)
				{
				}
				this.scanWideTrunkingFailsoftHoldTimesec_A8009.Editable = value;
			}
		}

		// Token: 0x170013E8 RID: 5096
		// (get) Token: 0x060027C4 RID: 10180 RVA: 0x00269C14 File Offset: 0x00267E14
		internal string ScanWideTrunkingFailsoftHoldTimesec_A8009_UILabel
		{
			get
			{
				short num = (short)1607139328;
				short num2 = num;
				num = (short)1017096748;
				short num3 = num;
				num = (short)1528736300;
				switch (num3 == num)
				{
				}
				num = (short)1683816448;
				if (num != 0)
				{
				}
				num = (short)1988952065;
				if (num != 0)
				{
				}
				return this.scanWideTrunkingFailsoftHoldTimesec_A8009.UIName;
			}
		}

		// Token: 0x170013E9 RID: 5097
		// (get) Token: 0x060027C5 RID: 10181 RVA: 0x00269CC8 File Offset: 0x00267EC8
		// (set) Token: 0x060027C6 RID: 10182 RVA: 0x00269D80 File Offset: 0x00267F80
		internal bool ScanWideTrunkingFailsoftHoldTimesec_A8009_HiddenStatic
		{
			get
			{
				short num = (short)873267200;
				short num2 = num;
				num = (short)454029;
				short num3 = num;
				num = (short)534048141;
				switch (num3 == num)
				{
				}
				num = (short)1567293441;
				if (num != 0)
				{
				}
				num = (short)1865547776;
				if (num != 0)
				{
				}
				return this.scanWideTrunkingFailsoftHoldTimesec_A8009.HiddenStatic;
			}
			set
			{
				short num = (short)1528758272;
				short num2 = num;
				num = (short)1693253633;
				if (num != 0)
				{
				}
				num = (short)1208440102;
				short num3 = num;
				num = (short)1903318310;
				switch (num3 == num)
				{
				}
				num = (short)616103936;
				if (num != 0)
				{
				}
				this.scanWideTrunkingFailsoftHoldTimesec_A8009.HiddenStatic = value;
			}
		}

		// Token: 0x170013EA RID: 5098
		// (get) Token: 0x060027C7 RID: 10183 RVA: 0x00269E38 File Offset: 0x00268038
		// (set) Token: 0x060027C8 RID: 10184 RVA: 0x00269EF0 File Offset: 0x002680F0
		internal bool ScanWideTrunkingFailsoftHoldTimesec_A8009_HiddenDynamic
		{
			get
			{
				short num = (short)1584791552;
				short num2 = num;
				num = (short)781778945;
				if (num != 0)
				{
				}
				num = (short)951186670;
				short num3 = num;
				num = (short)1256387822;
				switch (num3 == num)
				{
				}
				num = (short)1608253440;
				if (num != 0)
				{
				}
				return this.scanWideTrunkingFailsoftHoldTimesec_A8009.HiddenDynamic;
			}
			set
			{
				short num = (short)515637248;
				short num2 = num;
				num = (short)2091104884;
				short num3 = num;
				num = (short)1634908788;
				switch (num3 == num)
				{
				}
				num = (short)862715905;
				if (num != 0)
				{
				}
				num = (short)1816264704;
				if (num != 0)
				{
				}
				this.scanWideTrunkingFailsoftHoldTimesec_A8009.HiddenDynamic = value;
			}
		}

		// Token: 0x170013EB RID: 5099
		// (get) Token: 0x060027C9 RID: 10185 RVA: 0x00269FAC File Offset: 0x002681AC
		public bool ScanWideTrunkingFailsoftHoldTimesec_A8009_HasDiffs
		{
			get
			{
				short num = (short)1008009216;
				short num2 = num;
				num = (short)1328586572;
				short num3 = num;
				num = (short)498966348;
				switch (num3 == num)
				{
				}
				num = (short)550895617;
				if (num != 0)
				{
				}
				num = (short)1829306368;
				if (num != 0)
				{
				}
				return this.scanWideTrunkingFailsoftHoldTimesec_A8009._HasDiffs;
			}
		}

		// Token: 0x170013EC RID: 5100
		// (get) Token: 0x060027CA RID: 10186 RVA: 0x0026A060 File Offset: 0x00268260
		// (set) Token: 0x060027CB RID: 10187 RVA: 0x0026A114 File Offset: 0x00268314
		public int ScanWideTrunkingSystemSearchTimesec_A9250Value
		{
			get
			{
				short num = (short)359464960;
				short num2 = num;
				num = (short)638335270;
				short num3 = num;
				num = (short)190134566;
				switch (num3 == num)
				{
				}
				num = (short)502923265;
				if (num != 0)
				{
				}
				num = (short)1862795264;
				if (num != 0)
				{
				}
				return this.scanWideTrunkingSystemSearchTimesec_A9250.Value;
			}
			set
			{
				short num = (short)474677248;
				short num2 = num;
				num = (short)1620180993;
				if (num != 0)
				{
				}
				num = (short)721227779;
				short num3 = num;
				num = (short)1599082499;
				switch (num3 == num)
				{
				}
				num = (short)2052259840;
				if (num != 0)
				{
				}
				this.scanWideTrunkingSystemSearchTimesec_A9250.Value = value;
			}
		}

		// Token: 0x170013ED RID: 5101
		// (get) Token: 0x060027CC RID: 10188 RVA: 0x0026A1C8 File Offset: 0x002683C8
		public global::AcpBusinessLayer.AcpSimpleRangeField ScanWideTrunkingSystemSearchTimesec_A9250
		{
			get
			{
				short num = (short)1827995648;
				short num2 = num;
				num = (short)1471454956;
				short num3 = num;
				num = (short)844013292;
				switch (num3 == num)
				{
				}
				num = (short)1776091137;
				if (num != 0)
				{
				}
				num = (short)344784896;
				if (num != 0)
				{
				}
				return this.scanWideTrunkingSystemSearchTimesec_A9250;
			}
		}

		// Token: 0x170013EE RID: 5102
		// (get) Token: 0x060027CD RID: 10189 RVA: 0x0026A278 File Offset: 0x00268478
		// (set) Token: 0x060027CE RID: 10190 RVA: 0x0026A32C File Offset: 0x0026852C
		public string ScanWideTrunkingSystemSearchTimesec_A9250_UIValue
		{
			get
			{
				short num = (short)1290731520;
				short num2 = num;
				num = (short)2045902849;
				if (num != 0)
				{
				}
				num = (short)871108238;
				short num3 = num;
				num = (short)746327694;
				switch (num3 == num)
				{
				}
				num = (short)1325858816;
				if (num != 0)
				{
				}
				return this.scanWideTrunkingSystemSearchTimesec_A9250.UIValue;
			}
			set
			{
				short num = (short)1160380416;
				short num2 = num;
				num = (short)1719795713;
				if (num != 0)
				{
				}
				num = (short)1927182113;
				short num3 = num;
				num = (short)1713862433;
				switch (num3 == num)
				{
				}
				num = (short)95748096;
				if (num != 0)
				{
				}
				this.scanWideTrunkingSystemSearchTimesec_A9250.UIValue = value;
			}
		}

		// Token: 0x170013EF RID: 5103
		// (get) Token: 0x060027CF RID: 10191 RVA: 0x0026A3E4 File Offset: 0x002685E4
		// (set) Token: 0x060027D0 RID: 10192 RVA: 0x0026A498 File Offset: 0x00268698
		internal int ScanWideTrunkingSystemSearchTimesec_A9250Min
		{
			get
			{
				short num = (short)222887936;
				short num2 = num;
				num = (short)825113913;
				short num3 = num;
				num = (short)63192377;
				switch (num3 == num)
				{
				}
				num = (short)1026818048;
				if (num != 0)
				{
				}
				num = (short)913440769;
				if (num != 0)
				{
				}
				return this.scanWideTrunkingSystemSearchTimesec_A9250.Min;
			}
			set
			{
				short num = (short)1845493760;
				short num2 = num;
				num = (short)1858542253;
				short num3 = num;
				num = (short)911219373;
				switch (num3 == num)
				{
				}
				num = (short)1869873152;
				if (num != 0)
				{
				}
				num = (short)332398593;
				if (num != 0)
				{
				}
				this.scanWideTrunkingSystemSearchTimesec_A9250.Min = value;
			}
		}

		// Token: 0x170013F0 RID: 5104
		// (get) Token: 0x060027D1 RID: 10193 RVA: 0x0026A54C File Offset: 0x0026874C
		// (set) Token: 0x060027D2 RID: 10194 RVA: 0x0026A604 File Offset: 0x00268804
		internal int ScanWideTrunkingSystemSearchTimesec_A9250Max
		{
			get
			{
				short num = (short)146407424;
				short num2 = num;
				num = (short)1087806121;
				short num3 = num;
				num = (short)973642409;
				switch (num3 == num)
				{
				}
				num = (short)2014117888;
				if (num != 0)
				{
				}
				num = (short)2032533505;
				if (num != 0)
				{
				}
				return this.scanWideTrunkingSystemSearchTimesec_A9250.Max;
			}
			set
			{
				short num = (short)2131427328;
				short num2 = num;
				num = (short)939065345;
				if (num != 0)
				{
				}
				num = (short)2049583229;
				short num3 = num;
				num = (short)1624909949;
				switch (num3 == num)
				{
				}
				num = (short)212271104;
				if (num != 0)
				{
				}
				this.scanWideTrunkingSystemSearchTimesec_A9250.Max = value;
			}
		}

		// Token: 0x170013F1 RID: 5105
		// (get) Token: 0x060027D3 RID: 10195 RVA: 0x0026A6BC File Offset: 0x002688BC
		// (set) Token: 0x060027D4 RID: 10196 RVA: 0x0026A770 File Offset: 0x00268970
		internal int ScanWideTrunkingSystemSearchTimesec_A9250Step
		{
			get
			{
				short num = (short)403439616;
				short num2 = num;
				num = (short)615784091;
				short num3 = num;
				num = (short)1550524059;
				switch (num3 == num)
				{
				}
				num = (short)1419444225;
				if (num != 0)
				{
				}
				num = (short)1030684672;
				if (num != 0)
				{
				}
				return this.scanWideTrunkingSystemSearchTimesec_A9250.StepSize;
			}
			set
			{
				short num = (short)335413248;
				short num2 = num;
				num = (short)1064532994;
				short num3 = num;
				num = (short)500202498;
				switch (num3 == num)
				{
				}
				num = (short)149487617;
				if (num != 0)
				{
				}
				num = (short)902627328;
				if (num != 0)
				{
				}
				this.scanWideTrunkingSystemSearchTimesec_A9250.StepSize = value;
			}
		}

		// Token: 0x170013F2 RID: 5106
		// (get) Token: 0x060027D5 RID: 10197 RVA: 0x0026A828 File Offset: 0x00268A28
		// (set) Token: 0x060027D6 RID: 10198 RVA: 0x0026A8E0 File Offset: 0x00268AE0
		public bool ScanWideTrunkingSystemSearchTimesec_A9250_Applicable
		{
			get
			{
				short num = (short)1957429248;
				short num2 = num;
				num = (short)1987578024;
				short num3 = num;
				num = (short)1774913704;
				switch (num3 == num)
				{
				}
				num = (short)1025179649;
				if (num != 0)
				{
				}
				num = (short)183894016;
				if (num != 0)
				{
				}
				return this.scanWideTrunkingSystemSearchTimesec_A9250.Applicable;
			}
			set
			{
				short num = (short)846135296;
				short num2 = num;
				num = (short)1865220097;
				if (num != 0)
				{
				}
				num = (short)1392420127;
				short num3 = num;
				num = (short)2120262943;
				switch (num3 == num)
				{
				}
				num = (short)894238720;
				if (num != 0)
				{
				}
				this.scanWideTrunkingSystemSearchTimesec_A9250.Applicable = value;
			}
		}

		// Token: 0x170013F3 RID: 5107
		// (get) Token: 0x060027D7 RID: 10199 RVA: 0x0026A994 File Offset: 0x00268B94
		// (set) Token: 0x060027D8 RID: 10200 RVA: 0x0026AA48 File Offset: 0x00268C48
		public bool ScanWideTrunkingSystemSearchTimesec_A9250_Valid
		{
			get
			{
				short num = (short)965738496;
				short num2 = num;
				num = (short)1785742096;
				short num3 = num;
				num = (short)2099594000;
				switch (num3 == num)
				{
				}
				num = (short)587857920;
				if (num != 0)
				{
				}
				num = (short)1194328065;
				if (num != 0)
				{
				}
				return this.scanWideTrunkingSystemSearchTimesec_A9250.Valid;
			}
			set
			{
				short num = (short)2005204992;
				short num2 = num;
				num = (short)1844563560;
				short num3 = num;
				num = (short)1435815528;
				switch (num3 == num)
				{
				}
				num = (short)812777473;
				if (num != 0)
				{
				}
				num = (short)920518656;
				if (num != 0)
				{
				}
				this.scanWideTrunkingSystemSearchTimesec_A9250.Valid = value;
			}
		}

		// Token: 0x170013F4 RID: 5108
		// (get) Token: 0x060027D9 RID: 10201 RVA: 0x0026AB00 File Offset: 0x00268D00
		// (set) Token: 0x060027DA RID: 10202 RVA: 0x0026ABB4 File Offset: 0x00268DB4
		public bool ScanWideTrunkingSystemSearchTimesec_A9250_Visible
		{
			get
			{
				short num = (short)662962176;
				short num2 = num;
				num = (short)524095724;
				short num3 = num;
				num = (short)2117144812;
				switch (num3 == num)
				{
				}
				num = (short)1574567936;
				if (num != 0)
				{
				}
				num = (short)1530855425;
				if (num != 0)
				{
				}
				return this.scanWideTrunkingSystemSearchTimesec_A9250.Visible;
			}
			set
			{
				short num = (short)1171128320;
				short num2 = num;
				num = (short)1504056435;
				short num3 = num;
				num = (short)441717875;
				switch (num3 == num)
				{
				}
				num = (short)1118175233;
				if (num != 0)
				{
				}
				num = (short)1187774464;
				if (num != 0)
				{
				}
				this.scanWideTrunkingSystemSearchTimesec_A9250.Visible = value;
			}
		}

		// Token: 0x170013F5 RID: 5109
		// (get) Token: 0x060027DB RID: 10203 RVA: 0x0026AC6C File Offset: 0x00268E6C
		// (set) Token: 0x060027DC RID: 10204 RVA: 0x0026AD20 File Offset: 0x00268F20
		public bool ScanWideTrunkingSystemSearchTimesec_A9250_Editable
		{
			get
			{
				short num = (short)402522112;
				short num2 = num;
				num = (short)522772619;
				short num3 = num;
				num = (short)1100800139;
				switch (num3 == num)
				{
				}
				num = (short)1525678080;
				if (num != 0)
				{
				}
				num = (short)1729757185;
				if (num != 0)
				{
				}
				return this.scanWideTrunkingSystemSearchTimesec_A9250.Editable;
			}
			set
			{
				short num = (short)683802624;
				short num2 = num;
				num = (short)1511986895;
				short num3 = num;
				num = (short)886380239;
				switch (num3 == num)
				{
				}
				num = (short)472383488;
				if (num != 0)
				{
				}
				num = (short)51511297;
				if (num != 0)
				{
				}
				this.scanWideTrunkingSystemSearchTimesec_A9250.Editable = value;
			}
		}

		// Token: 0x170013F6 RID: 5110
		// (get) Token: 0x060027DD RID: 10205 RVA: 0x0026ADD4 File Offset: 0x00268FD4
		internal string ScanWideTrunkingSystemSearchTimesec_A9250_UILabel
		{
			get
			{
				short num = (short)1996292096;
				short num2 = num;
				num = (short)710990459;
				short num3 = num;
				num = (short)1267456635;
				switch (num3 == num)
				{
				}
				num = (short)554369025;
				if (num != 0)
				{
				}
				num = (short)1106116608;
				if (num != 0)
				{
				}
				return this.scanWideTrunkingSystemSearchTimesec_A9250.UIName;
			}
		}

		// Token: 0x170013F7 RID: 5111
		// (get) Token: 0x060027DE RID: 10206 RVA: 0x0026AE88 File Offset: 0x00269088
		// (set) Token: 0x060027DF RID: 10207 RVA: 0x0026AF38 File Offset: 0x00269138
		internal bool ScanWideTrunkingSystemSearchTimesec_A9250_HiddenStatic
		{
			get
			{
				short num = (short)2134507520;
				short num2 = num;
				num = (short)1540148576;
				short num3 = num;
				num = (short)273010016;
				switch (num3 == num)
				{
				}
				num = (short)1825898497;
				if (num != 0)
				{
				}
				num = (short)1260388352;
				if (num != 0)
				{
				}
				return this.scanWideTrunkingSystemSearchTimesec_A9250.HiddenStatic;
			}
			set
			{
				short num = (short)844890112;
				short num2 = num;
				num = (short)927319148;
				short num3 = num;
				num = (short)2069611628;
				switch (num3 == num)
				{
				}
				num = (short)1419771905;
				if (num != 0)
				{
				}
				num = (short)1824260096;
				if (num != 0)
				{
				}
				this.scanWideTrunkingSystemSearchTimesec_A9250.HiddenStatic = value;
			}
		}

		// Token: 0x170013F8 RID: 5112
		// (get) Token: 0x060027E0 RID: 10208 RVA: 0x0026AFEC File Offset: 0x002691EC
		// (set) Token: 0x060027E1 RID: 10209 RVA: 0x0026B0A0 File Offset: 0x002692A0
		internal bool ScanWideTrunkingSystemSearchTimesec_A9250_HiddenDynamic
		{
			get
			{
				short num = (short)859111424;
				short num2 = num;
				num = (short)814134943;
				short num3 = num;
				num = (short)1979823775;
				switch (num3 == num)
				{
				}
				num = (short)2028339201;
				if (num != 0)
				{
				}
				num = (short)819462144;
				if (num != 0)
				{
				}
				return this.scanWideTrunkingSystemSearchTimesec_A9250.HiddenDynamic;
			}
			set
			{
				short num = (short)1292763136;
				short num2 = num;
				num = (short)1352734238;
				short num3 = num;
				num = (short)1389565470;
				switch (num3 == num)
				{
				}
				num = (short)1178664961;
				if (num != 0)
				{
				}
				num = (short)55312384;
				if (num != 0)
				{
				}
				this.scanWideTrunkingSystemSearchTimesec_A9250.HiddenDynamic = value;
			}
		}

		// Token: 0x170013F9 RID: 5113
		// (get) Token: 0x060027E2 RID: 10210 RVA: 0x0026B154 File Offset: 0x00269354
		public bool ScanWideTrunkingSystemSearchTimesec_A9250_HasDiffs
		{
			get
			{
				short num = (short)129040384;
				short num2 = num;
				num = (short)134265700;
				short num3 = num;
				num = (short)1490205540;
				switch (num3 == num)
				{
				}
				num = (short)1478361088;
				if (num != 0)
				{
				}
				num = (short)1034223617;
				if (num != 0)
				{
				}
				return this.scanWideTrunkingSystemSearchTimesec_A9250._HasDiffs;
			}
		}

		// Token: 0x060027E3 RID: 10211 RVA: 0x0026B20C File Offset: 0x0026940C
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
					if (base.ParentRecset != null)
					{
						num2 = (short)625737729;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13A;
				case 1:
					num2 = (short)502988803;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_82;
				case 3:
				{
					num2 = (short)1356556930;
					short num3 = num2;
					num2 = (short)1008036482;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5C;
					default:
						num2 = (short)1468727296;
						if (num2 != 0)
						{
						}
						if (base.ParentRecset.ContainerDoc != null)
						{
							num2 = (short)274857988;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_13A;
					}
					break;
				}
				case 4:
				{
					num2 = (short)1665073152;
					short num4 = num2;
					goto IL_5C;
				}
				}
				goto IL_24;
				IL_5C:
				result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
				num2 = (short)529793026;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_82:
			IL_13A:
			num2 = (short)950534145;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)760217600;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000ECF RID: 3791
		private global::AcpBusinessLayer.AcpSimpleRangeField scanWideTrunkingFailsoftHoldTimesec_A8009;

		// Token: 0x04000ED0 RID: 3792
		private global::AcpBusinessLayer.AcpSimpleRangeField scanWideTrunkingSystemSearchTimesec_A9250;
	}
}
