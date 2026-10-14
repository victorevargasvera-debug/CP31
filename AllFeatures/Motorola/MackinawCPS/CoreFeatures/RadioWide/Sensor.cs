using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x02000185 RID: 389
	[global::System.Serializable]
	public class Sensor : global::AcpBusinessLayer.FeatureSection
	{
		// Token: 0x06003EB9 RID: 16057 RVA: 0x003B1E3C File Offset: 0x003B003C
		public Sensor(global::AcpBusinessLayer.FeatureNode parent) : base(parent)
		{
			this.Init();
		}

		// Token: 0x06003EBA RID: 16058 RVA: 0x003B1E58 File Offset: 0x003B0058
		protected Sensor(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
		}

		// Token: 0x06003EBB RID: 16059 RVA: 0x003B1E70 File Offset: 0x003B0070
		public override void Init()
		{
			int a_ = 9;
			short num = (short)670957569;
			if (num != 0)
			{
			}
			num = (short)1442838612;
			short num2 = num;
			num = (short)1295120468;
			switch (num2 == num)
			{
			}
			num = (short)81592320;
			if (num != 0)
			{
			}
			num = (short)104202240;
			short num3 = num;
			this.sensorEventDisableTimer_43198 = new global::AcpBusinessLayer.AcpSimpleRangeField(6, this, global::AllFeatures.CodeplugGuid.b("駉꧋ꃍꏏ뷑ꛓ鏕껗뿙닛ꫝꓟ诡韣蟥諧蛩觫뫭駯鿱釳蓵ꟷ컹쿻쿽㧿㨁", a_), global::CommonResources.AcgResources.ID_SENSOREVENTDISABLETIMERSEC, 1, 60, null, null, 0, 5);
			this.sensorEventDisableTimer_43198.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.sensorEventDisableTimer_43198.DataTransferOrder = 300;
			this.sensorEventDisableTimer_43198.ShowHexValue = false;
			this.sensorEventNotificationEnable_43525 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("駉꧋ꃍꏏ뷑ꛓ鏕껗뿙닛ꫝ껟跡郣迥軧菩迫迭蓯鯱鯳飵뷷铹鷻鳽泿朁嬃㈅㬇㼉㸋㬍", a_), global::CommonResources.AcgResources.ID_SENSOREVENTNOTIFICATIONENABLE);
			this.sensorEventNotificationEnable_43525.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
			this.sensorEventNotificationEnable_43525.DataTransferOrder = 301;
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("駉꧋ꃍꏏ뷑ꛓ", a_);
			base.Id = 10819;
			base.UIName = global::CommonResources.AcgResources.ID_SENSOR;
			base.DataTransferOrder = 100;
		}

		// Token: 0x06003EBC RID: 16060 RVA: 0x003B1FE0 File Offset: 0x003B01E0
		public override void Init(global::System.Collections.Generic.List<string> producerFields)
		{
			int a_ = 7;
			short num = (short)683802631;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_254;
				case 1:
					num = (short)1273430018;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯇꿉ꋋ뷍뿏ꃑ釓ꃕ뷗듙꣛髝觟釡藣蓥蓧迩룫蟭鷯韱蛳꧵쳷짹췻쟽㣿", a_)))
					{
						num = (short)563544070;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7A;
				case 3:
					if (producerFields.Contains(global::AllFeatures.CodeplugGuid.b("鯇꿉ꋋ뷍뿏ꃑ釓ꃕ뷗듙꣛郝迟雡跣胥臧觩跫髭駯鷱髳돵雷鯹黻鋽旿崁〃㔅㴇㠉㤋", a_)))
					{
						num = (short)1549598725;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A3;
				case 4:
					goto IL_7A;
				case 5:
					this.sensorEventNotificationEnable_43525 = new global::AcpBusinessLayer.AcpField<bool>(false, this, global::AllFeatures.CodeplugGuid.b("鯇꿉ꋋ뷍뿏ꃑ釓ꃕ뷗듙꣛郝迟雡跣胥臧觩跫髭駯鷱髳돵雷鯹黻鋽旿崁〃㔅㴇㠉㤋", a_), global::CommonResources.AcgResources.ID_SENSOREVENTNOTIFICATIONENABLE);
					this.sensorEventNotificationEnable_43525.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.sensorEventNotificationEnable_43525.DataTransferOrder = 301;
					num = (short)1293746176;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					this.sensorEventDisableTimer_43198 = new global::AcpBusinessLayer.AcpSimpleRangeField(6, this, global::AllFeatures.CodeplugGuid.b("鯇꿉ꋋ뷍뿏ꃑ釓ꃕ뷗듙꣛髝觟釡藣蓥蓧迩룫蟭鷯韱蛳꧵쳷짹췻쟽㣿", a_), global::CommonResources.AcgResources.ID_SENSOREVENTDISABLETIMERSEC, null, null, 0, 5);
					this.sensorEventDisableTimer_43198.DifferentiatedUserView = global::AcpCommonLib.DifferentiatedUserViewType.Full;
					this.sensorEventDisableTimer_43198.DataTransferOrder = 300;
					this.sensorEventDisableTimer_43198.ShowHexValue = false;
					num = (short)490340352;
					short num3 = num;
					num = (short)417988609;
					if (num != 0)
					{
					}
					num = (short)1330249732;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					switch (0)
					{
					case 0:
						goto IL_56;
					}
					continue;
				case 8:
					num = (short)390463497;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
				{
					num = (short)1420696142;
					short num4 = num;
					num = (short)1343167054;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1184432128;
						if (num != 0)
						{
						}
						if (producerFields != null)
						{
							num = (short)31522817;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A3;
					}
					break;
				}
				}
				IL_56:
				if (global::AcpCommonLib.AppInfoManager.DropOperation)
				{
					num = (short)1026752520;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_7A:
				num = (short)1010368515;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_254:
			IL_2A3:
			base.FeatureSectionName = global::AllFeatures.CodeplugGuid.b("鯇꿉ꋋ뷍뿏ꃑ", a_);
			base.Id = 10819;
			base.UIName = global::CommonResources.AcgResources.ID_SENSOR;
			base.DataTransferOrder = 100;
		}

		// Token: 0x06003EBD RID: 16061 RVA: 0x003B22C4 File Offset: 0x003B04C4
		public override void PopulateReferences()
		{
			short num = (short)1251717648;
			short num2 = num;
			num = (short)272019984;
			switch (num2 == num)
			{
			}
			num = (short)676986881;
			if (num != 0)
			{
			}
			num = (short)1211236352;
			if (num != 0)
			{
			}
			num = (short)2105147392;
			short num3 = num;
		}

		// Token: 0x06003EBE RID: 16062 RVA: 0x003B236C File Offset: 0x003B056C
		public override void DropReferences()
		{
			short num = (short)1720280525;
			short num2 = num;
			num = (short)28272077;
			switch (num2 == num)
			{
			}
			num = (short)1961558017;
			if (num != 0)
			{
			}
			num = (short)788987904;
			if (num != 0)
			{
			}
			num = (short)802750464;
			short num3 = num;
		}

		// Token: 0x06003EBF RID: 16063 RVA: 0x003B2414 File Offset: 0x003B0614
		public override void SetConstraints()
		{
			short num = (short)260505601;
			if (num != 0)
			{
			}
			num = (short)1645070004;
			short num2 = num;
			num = (short)1458489012;
			switch (num2 == num)
			{
			}
			num = (short)1715535872;
			if (num != 0)
			{
			}
			num = (short)1499463680;
			short num3 = num;
		}

		// Token: 0x06003EC0 RID: 16064 RVA: 0x003B24C0 File Offset: 0x003B06C0
		public override void SetupDependencies()
		{
			short num = (short)403646683;
			short num2 = num;
			num = (short)2114988251;
			switch (num2 == num)
			{
			}
			num = (short)844759041;
			if (num != 0)
			{
			}
			num = (short)1645674496;
			if (num != 0)
			{
			}
			num = (short)326238208;
			short num3 = num;
		}

		// Token: 0x17002023 RID: 8227
		// (get) Token: 0x06003EC1 RID: 16065 RVA: 0x003B2568 File Offset: 0x003B0768
		public bool HasDiffs
		{
			get
			{
				short num = (short)1556464317;
				short num2 = num;
				num = (short)589742781;
				switch (num2 == num)
				{
				}
				num = (short)1438973952;
				if (num != 0)
				{
				}
				num = (short)409796609;
				if (num != 0)
				{
				}
				num = (short)1643642880;
				short num3 = num;
				return base._HasDiffs;
			}
		}

		// Token: 0x17002024 RID: 8228
		// (get) Token: 0x06003EC2 RID: 16066 RVA: 0x003B2618 File Offset: 0x003B0818
		// (set) Token: 0x06003EC3 RID: 16067 RVA: 0x003B26CC File Offset: 0x003B08CC
		public int SensorEventDisableTimer_43198Value
		{
			get
			{
				short num = (short)958524397;
				short num2 = num;
				num = (short)1674243053;
				switch (num2 == num)
				{
				}
				num = (short)1337851904;
				if (num != 0)
				{
				}
				num = (short)206503937;
				if (num != 0)
				{
				}
				num = (short)263913472;
				short num3 = num;
				return this.sensorEventDisableTimer_43198.Value;
			}
			set
			{
				short num = (short)1997914389;
				short num2 = num;
				num = (short)1507770645;
				switch (num2 == num)
				{
				}
				num = (short)544342017;
				if (num != 0)
				{
				}
				num = (short)1288765440;
				if (num != 0)
				{
				}
				num = (short)1900085248;
				short num3 = num;
				this.sensorEventDisableTimer_43198.Value = value;
			}
		}

		// Token: 0x17002025 RID: 8229
		// (get) Token: 0x06003EC4 RID: 16068 RVA: 0x003B2780 File Offset: 0x003B0980
		public global::AcpBusinessLayer.AcpSimpleRangeField SensorEventDisableTimer_43198
		{
			get
			{
				short num = (short)1531517344;
				short num2 = num;
				num = (short)101915040;
				switch (num2 == num)
				{
				}
				num = (short)1905590272;
				if (num != 0)
				{
				}
				num = (short)701104129;
				if (num != 0)
				{
				}
				num = (short)1603862528;
				short num3 = num;
				return this.sensorEventDisableTimer_43198;
			}
		}

		// Token: 0x17002026 RID: 8230
		// (get) Token: 0x06003EC5 RID: 16069 RVA: 0x003B2830 File Offset: 0x003B0A30
		// (set) Token: 0x06003EC6 RID: 16070 RVA: 0x003B28E4 File Offset: 0x003B0AE4
		public string SensorEventDisableTimer_43198_UIValue
		{
			get
			{
				short num = (short)277035604;
				short num2 = num;
				num = (short)705116756;
				switch (num2 == num)
				{
				}
				num = (short)641466369;
				if (num != 0)
				{
				}
				num = (short)489619456;
				if (num != 0)
				{
				}
				num = (short)1027801088;
				short num3 = num;
				return this.sensorEventDisableTimer_43198.UIValue;
			}
			set
			{
				short num = (short)1463895365;
				short num2 = num;
				num = (short)1580352837;
				switch (num2 == num)
				{
				}
				num = (short)845348864;
				if (num != 0)
				{
				}
				num = (short)342753281;
				if (num != 0)
				{
				}
				num = (short)546439168;
				short num3 = num;
				this.sensorEventDisableTimer_43198.UIValue = value;
			}
		}

		// Token: 0x17002027 RID: 8231
		// (get) Token: 0x06003EC7 RID: 16071 RVA: 0x003B2998 File Offset: 0x003B0B98
		// (set) Token: 0x06003EC8 RID: 16072 RVA: 0x003B2A4C File Offset: 0x003B0C4C
		internal int SensorEventDisableTimer_43198Min
		{
			get
			{
				short num = (short)1436730944;
				short num2 = num;
				num = (short)1119340096;
				switch (num2 == num)
				{
				}
				num = (short)1188560897;
				if (num != 0)
				{
				}
				num = (short)859373568;
				if (num != 0)
				{
				}
				num = (short)622329856;
				short num3 = num;
				return this.sensorEventDisableTimer_43198.Min;
			}
			set
			{
				short num = (short)1217543663;
				short num2 = num;
				num = (short)1117601263;
				switch (num2 == num)
				{
				}
				num = (short)619511808;
				if (num != 0)
				{
				}
				num = (short)1739456513;
				if (num != 0)
				{
				}
				num = (short)977338368;
				short num3 = num;
				this.sensorEventDisableTimer_43198.Min = value;
			}
		}

		// Token: 0x17002028 RID: 8232
		// (get) Token: 0x06003EC9 RID: 16073 RVA: 0x003B2B04 File Offset: 0x003B0D04
		// (set) Token: 0x06003ECA RID: 16074 RVA: 0x003B2BB8 File Offset: 0x003B0DB8
		internal int SensorEventDisableTimer_43198Max
		{
			get
			{
				short num = (short)403643661;
				short num2 = num;
				num = (short)1390615821;
				switch (num2 == num)
				{
				}
				num = (short)394002432;
				if (num != 0)
				{
				}
				num = (short)8585217;
				if (num != 0)
				{
				}
				num = (short)349110272;
				short num3 = num;
				return this.sensorEventDisableTimer_43198.Max;
			}
			set
			{
				short num = (short)481165313;
				if (num != 0)
				{
				}
				num = (short)312172598;
				short num2 = num;
				num = (short)1761894454;
				switch (num2 == num)
				{
				}
				num = (short)136577024;
				if (num != 0)
				{
				}
				num = (short)1539702784;
				short num3 = num;
				this.sensorEventDisableTimer_43198.Max = value;
			}
		}

		// Token: 0x17002029 RID: 8233
		// (get) Token: 0x06003ECB RID: 16075 RVA: 0x003B2C70 File Offset: 0x003B0E70
		// (set) Token: 0x06003ECC RID: 16076 RVA: 0x003B2D24 File Offset: 0x003B0F24
		internal int SensorEventDisableTimer_43198Step
		{
			get
			{
				short num = (short)1249614381;
				short num2 = num;
				num = (short)826120749;
				switch (num2 == num)
				{
				}
				num = (short)1775304705;
				if (num != 0)
				{
				}
				num = (short)129695744;
				if (num != 0)
				{
				}
				num = (short)1324679168;
				short num3 = num;
				return this.sensorEventDisableTimer_43198.StepSize;
			}
			set
			{
				short num = (short)450062414;
				short num2 = num;
				num = (short)265840718;
				switch (num2 == num)
				{
				}
				num = (short)568459265;
				if (num != 0)
				{
				}
				num = (short)28114944;
				if (num != 0)
				{
				}
				num = (short)272760832;
				short num3 = num;
				this.sensorEventDisableTimer_43198.StepSize = value;
			}
		}

		// Token: 0x1700202A RID: 8234
		// (get) Token: 0x06003ECD RID: 16077 RVA: 0x003B2DD8 File Offset: 0x003B0FD8
		// (set) Token: 0x06003ECE RID: 16078 RVA: 0x003B2E8C File Offset: 0x003B108C
		public bool SensorEventDisableTimer_43198_Applicable
		{
			get
			{
				short num = (short)1175425979;
				short num2 = num;
				num = (short)22975419;
				switch (num2 == num)
				{
				}
				num = (short)284753921;
				if (num != 0)
				{
				}
				num = (short)1805713408;
				if (num != 0)
				{
				}
				num = (short)723517440;
				short num3 = num;
				return this.sensorEventDisableTimer_43198.Applicable;
			}
			set
			{
				short num = (short)1720527923;
				short num2 = num;
				num = (short)971320371;
				switch (num2 == num)
				{
				}
				num = (short)1715863552;
				if (num != 0)
				{
				}
				num = (short)181600257;
				if (num != 0)
				{
				}
				num = (short)917766144;
				short num3 = num;
				this.sensorEventDisableTimer_43198.Applicable = value;
			}
		}

		// Token: 0x1700202B RID: 8235
		// (get) Token: 0x06003ECF RID: 16079 RVA: 0x003B2F44 File Offset: 0x003B1144
		// (set) Token: 0x06003ED0 RID: 16080 RVA: 0x003B2FF8 File Offset: 0x003B11F8
		public bool SensorEventDisableTimer_43198_Valid
		{
			get
			{
				short num = (short)201088986;
				short num2 = num;
				num = (short)423518170;
				switch (num2 == num)
				{
				}
				num = (short)647561216;
				if (num != 0)
				{
				}
				num = (short)1571356673;
				if (num != 0)
				{
				}
				num = (short)1228144640;
				short num3 = num;
				return this.sensorEventDisableTimer_43198.Valid;
			}
			set
			{
				short num = (short)1067164302;
				short num2 = num;
				num = (short)146121358;
				switch (num2 == num)
				{
				default:
				{
					num = (short)342163456;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1844969473;
				if (num != 0)
				{
				}
				num = (short)253886464;
				if (num != 0)
				{
				}
				this.sensorEventDisableTimer_43198.Valid = value;
			}
		}

		// Token: 0x1700202C RID: 8236
		// (get) Token: 0x06003ED1 RID: 16081 RVA: 0x003B30AC File Offset: 0x003B12AC
		// (set) Token: 0x06003ED2 RID: 16082 RVA: 0x003B3160 File Offset: 0x003B1360
		public bool SensorEventDisableTimer_43198_Visible
		{
			get
			{
				short num = (short)1984653447;
				short num2 = num;
				num = (short)1638492295;
				switch (num2 == num)
				{
				default:
				{
					num = (short)380698624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2069823489;
				if (num != 0)
				{
				}
				num = (short)212205568;
				if (num != 0)
				{
				}
				return this.sensorEventDisableTimer_43198.Visible;
			}
			set
			{
				short num = (short)331341026;
				short num2 = num;
				num = (short)2034556130;
				switch (num2 == num)
				{
				default:
				{
					num = (short)351338496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)998703105;
				if (num != 0)
				{
				}
				num = (short)413073408;
				if (num != 0)
				{
				}
				this.sensorEventDisableTimer_43198.Visible = value;
			}
		}

		// Token: 0x1700202D RID: 8237
		// (get) Token: 0x06003ED3 RID: 16083 RVA: 0x003B3218 File Offset: 0x003B1418
		// (set) Token: 0x06003ED4 RID: 16084 RVA: 0x003B32D0 File Offset: 0x003B14D0
		public bool SensorEventDisableTimer_43198_Editable
		{
			get
			{
				short num = (short)1484219854;
				short num2 = num;
				num = (short)1707763150;
				switch (num2 == num)
				{
				default:
				{
					num = (short)390594560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)540016640;
				if (num != 0)
				{
				}
				num = (short)1041498113;
				if (num != 0)
				{
				}
				return this.sensorEventDisableTimer_43198.Editable;
			}
			set
			{
				short num = (short)424476673;
				if (num != 0)
				{
				}
				num = (short)326303744;
				short num2 = num;
				num = (short)1629469436;
				short num3 = num;
				num = (short)948026108;
				switch (num3 == num)
				{
				}
				num = (short)211877888;
				if (num != 0)
				{
				}
				this.sensorEventDisableTimer_43198.Editable = value;
			}
		}

		// Token: 0x1700202E RID: 8238
		// (get) Token: 0x06003ED5 RID: 16085 RVA: 0x003B3388 File Offset: 0x003B1588
		internal string SensorEventDisableTimer_43198_UILabel
		{
			get
			{
				short num = (short)81351378;
				short num2 = num;
				num = (short)108352210;
				switch (num2 == num)
				{
				default:
				{
					num = (short)793313280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)705101824;
				if (num != 0)
				{
				}
				num = (short)1010958337;
				if (num != 0)
				{
				}
				return this.sensorEventDisableTimer_43198.UIName;
			}
		}

		// Token: 0x1700202F RID: 8239
		// (get) Token: 0x06003ED6 RID: 16086 RVA: 0x003B343C File Offset: 0x003B163C
		// (set) Token: 0x06003ED7 RID: 16087 RVA: 0x003B34F0 File Offset: 0x003B16F0
		internal bool SensorEventDisableTimer_43198_HiddenStatic
		{
			get
			{
				short num = (short)2126840057;
				short num2 = num;
				num = (short)657326329;
				switch (num2 == num)
				{
				default:
				{
					num = (short)270008320;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1686372353;
				if (num != 0)
				{
				}
				num = (short)928841728;
				if (num != 0)
				{
				}
				return this.sensorEventDisableTimer_43198.HiddenStatic;
			}
			set
			{
				short num = (short)8969078;
				short num2 = num;
				num = (short)2063129462;
				switch (num2 == num)
				{
				default:
				{
					num = (short)248840192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)88473601;
				if (num != 0)
				{
				}
				num = (short)1676541952;
				if (num != 0)
				{
				}
				this.sensorEventDisableTimer_43198.HiddenStatic = value;
			}
		}

		// Token: 0x17002030 RID: 8240
		// (get) Token: 0x06003ED8 RID: 16088 RVA: 0x003B35A4 File Offset: 0x003B17A4
		// (set) Token: 0x06003ED9 RID: 16089 RVA: 0x003B365C File Offset: 0x003B185C
		internal bool SensorEventDisableTimer_43198_HiddenDynamic
		{
			get
			{
				short num = (short)762074729;
				short num2 = num;
				num = (short)79779433;
				switch (num2 == num)
				{
				default:
				{
					num = (short)280297472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2001141760;
				if (num != 0)
				{
				}
				num = (short)126353409;
				if (num != 0)
				{
				}
				return this.sensorEventDisableTimer_43198.HiddenDynamic;
			}
			set
			{
				short num = (short)2093905513;
				short num2 = num;
				num = (short)1487369833;
				switch (num2 == num)
				{
				default:
				{
					num = (short)560791552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)328138753;
				if (num != 0)
				{
				}
				num = (short)540540928;
				if (num != 0)
				{
				}
				this.sensorEventDisableTimer_43198.HiddenDynamic = value;
			}
		}

		// Token: 0x17002031 RID: 8241
		// (get) Token: 0x06003EDA RID: 16090 RVA: 0x003B3710 File Offset: 0x003B1910
		public bool SensorEventDisableTimer_43198_HasDiffs
		{
			get
			{
				short num = (short)792271682;
				short num2 = num;
				num = (short)667294530;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2036334592;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)51970048;
				if (num != 0)
				{
				}
				num = (short)1544945665;
				if (num != 0)
				{
				}
				return this.sensorEventDisableTimer_43198._HasDiffs;
			}
		}

		// Token: 0x17002032 RID: 8242
		// (get) Token: 0x06003EDB RID: 16091 RVA: 0x003B37C4 File Offset: 0x003B19C4
		// (set) Token: 0x06003EDC RID: 16092 RVA: 0x003B387C File Offset: 0x003B1A7C
		public bool SensorEventNotificationEnable_43525Value
		{
			get
			{
				short num = (short)1699983988;
				short num2 = num;
				num = (short)1692971636;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1298595840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1581318144;
				if (num != 0)
				{
				}
				num = (short)1070596097;
				if (num != 0)
				{
				}
				return this.sensorEventNotificationEnable_43525.Value;
			}
			set
			{
				short num = (short)1878592813;
				short num2 = num;
				num = (short)1332088109;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1986920448;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1794768896;
				if (num != 0)
				{
				}
				num = (short)1732509697;
				if (num != 0)
				{
				}
				this.sensorEventNotificationEnable_43525.Value = value;
			}
		}

		// Token: 0x17002033 RID: 8243
		// (get) Token: 0x06003EDD RID: 16093 RVA: 0x003B3934 File Offset: 0x003B1B34
		public global::AcpBusinessLayer.AcpField<bool> SensorEventNotificationEnable_43525
		{
			get
			{
				short num = (short)671220204;
				short num2 = num;
				num = (short)744227308;
				switch (num2 == num)
				{
				default:
				{
					num = (short)322568192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)343146496;
				if (num != 0)
				{
				}
				num = (short)716963841;
				if (num != 0)
				{
				}
				return this.sensorEventNotificationEnable_43525;
			}
		}

		// Token: 0x17002034 RID: 8244
		// (get) Token: 0x06003EDE RID: 16094 RVA: 0x003B39E8 File Offset: 0x003B1BE8
		// (set) Token: 0x06003EDF RID: 16095 RVA: 0x003B3A9C File Offset: 0x003B1C9C
		public bool SensorEventNotificationEnable_43525_UIValue
		{
			get
			{
				short num = (short)1041039361;
				if (num != 0)
				{
				}
				num = (short)1310720000;
				short num2 = num;
				num = (short)330939960;
				short num3 = num;
				num = (short)1878441528;
				switch (num3 == num)
				{
				}
				num = (short)153550848;
				if (num != 0)
				{
				}
				return this.sensorEventNotificationEnable_43525.Value;
			}
			set
			{
				short num = (short)835358699;
				short num2 = num;
				num = (short)279941099;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1055784960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)401080321;
				if (num != 0)
				{
				}
				num = (short)1995571200;
				if (num != 0)
				{
				}
				this.sensorEventNotificationEnable_43525.Value = value;
			}
		}

		// Token: 0x17002035 RID: 8245
		// (get) Token: 0x06003EE0 RID: 16096 RVA: 0x003B3B58 File Offset: 0x003B1D58
		// (set) Token: 0x06003EE1 RID: 16097 RVA: 0x003B3C0C File Offset: 0x003B1E0C
		public bool SensorEventNotificationEnable_43525_Applicable
		{
			get
			{
				short num = (short)305617716;
				short num2 = num;
				num = (short)710957876;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1892548608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)475463681;
				if (num != 0)
				{
				}
				num = (short)1518469120;
				if (num != 0)
				{
				}
				return this.sensorEventNotificationEnable_43525.Applicable;
			}
			set
			{
				short num = (short)688370448;
				short num2 = num;
				num = (short)859878160;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1568931840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)183435264;
				if (num != 0)
				{
				}
				num = (short)1055719425;
				if (num != 0)
				{
				}
				this.sensorEventNotificationEnable_43525.Applicable = value;
			}
		}

		// Token: 0x17002036 RID: 8246
		// (get) Token: 0x06003EE2 RID: 16098 RVA: 0x003B3CC0 File Offset: 0x003B1EC0
		// (set) Token: 0x06003EE3 RID: 16099 RVA: 0x003B3D74 File Offset: 0x003B1F74
		public bool SensorEventNotificationEnable_43525_Valid
		{
			get
			{
				short num = (short)1467809793;
				if (num != 0)
				{
				}
				num = (short)1021837312;
				short num2 = num;
				num = (short)262626796;
				short num3 = num;
				num = (short)1152802284;
				switch (num3 == num)
				{
				}
				num = (short)2110062592;
				if (num != 0)
				{
				}
				return this.sensorEventNotificationEnable_43525.Valid;
			}
			set
			{
				short num = (short)343566247;
				short num2 = num;
				num = (short)289105831;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1076690944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)595722240;
				if (num != 0)
				{
				}
				num = (short)1187184641;
				if (num != 0)
				{
				}
				this.sensorEventNotificationEnable_43525.Valid = value;
			}
		}

		// Token: 0x17002037 RID: 8247
		// (get) Token: 0x06003EE4 RID: 16100 RVA: 0x003B3E28 File Offset: 0x003B2028
		// (set) Token: 0x06003EE5 RID: 16101 RVA: 0x003B3EE0 File Offset: 0x003B20E0
		public bool SensorEventNotificationEnable_43525_Visible
		{
			get
			{
				short num = (short)1256411212;
				short num2 = num;
				num = (short)1298026572;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1485242368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2125070337;
				if (num != 0)
				{
				}
				num = (short)1201930240;
				if (num != 0)
				{
				}
				return this.sensorEventNotificationEnable_43525.Visible;
			}
			set
			{
				short num = (short)1652179419;
				short num2 = num;
				num = (short)1205420507;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1646395392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)883032065;
				if (num != 0)
				{
				}
				num = (short)1588920320;
				if (num != 0)
				{
				}
				this.sensorEventNotificationEnable_43525.Visible = value;
			}
		}

		// Token: 0x17002038 RID: 8248
		// (get) Token: 0x06003EE6 RID: 16102 RVA: 0x003B3F98 File Offset: 0x003B2198
		// (set) Token: 0x06003EE7 RID: 16103 RVA: 0x003B404C File Offset: 0x003B224C
		public bool SensorEventNotificationEnable_43525_Editable
		{
			get
			{
				short num = (short)1680518581;
				short num2 = num;
				num = (short)784051637;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1584267264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)846397440;
				if (num != 0)
				{
				}
				num = (short)845348865;
				if (num != 0)
				{
				}
				return this.sensorEventNotificationEnable_43525.Editable;
			}
			set
			{
				short num = (short)538670053;
				short num2 = num;
				num = (short)1756984293;
				switch (num2 == num)
				{
				default:
				{
					num = (short)963969024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1587281920;
				if (num != 0)
				{
				}
				num = (short)381419521;
				if (num != 0)
				{
				}
				this.sensorEventNotificationEnable_43525.Editable = value;
			}
		}

		// Token: 0x17002039 RID: 8249
		// (get) Token: 0x06003EE8 RID: 16104 RVA: 0x003B4100 File Offset: 0x003B2300
		internal string SensorEventNotificationEnable_43525_UILabel
		{
			get
			{
				short num = (short)592966564;
				short num2 = num;
				num = (short)103543716;
				switch (num2 == num)
				{
				default:
				{
					num = (short)429719552;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)992673793;
				if (num != 0)
				{
				}
				num = (short)1424621568;
				if (num != 0)
				{
				}
				return this.sensorEventNotificationEnable_43525.UIName;
			}
		}

		// Token: 0x1700203A RID: 8250
		// (get) Token: 0x06003EE9 RID: 16105 RVA: 0x003B41B8 File Offset: 0x003B23B8
		// (set) Token: 0x06003EEA RID: 16106 RVA: 0x003B4270 File Offset: 0x003B2470
		internal bool SensorEventNotificationEnable_43525_HiddenStatic
		{
			get
			{
				short num = (short)1084104934;
				short num2 = num;
				num = (short)79306982;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2119106560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1201930240;
				if (num != 0)
				{
				}
				num = (short)1591869441;
				if (num != 0)
				{
				}
				return this.sensorEventNotificationEnable_43525.HiddenStatic;
			}
			set
			{
				short num = (short)2064187393;
				if (num != 0)
				{
				}
				num = (short)1685520384;
				short num2 = num;
				num = (short)495969376;
				short num3 = num;
				num = (short)588571744;
				switch (num3 == num)
				{
				}
				num = (short)1985871872;
				if (num != 0)
				{
				}
				this.sensorEventNotificationEnable_43525.HiddenStatic = value;
			}
		}

		// Token: 0x1700203B RID: 8251
		// (get) Token: 0x06003EEB RID: 16107 RVA: 0x003B4328 File Offset: 0x003B2528
		// (set) Token: 0x06003EEC RID: 16108 RVA: 0x003B43DC File Offset: 0x003B25DC
		internal bool SensorEventNotificationEnable_43525_HiddenDynamic
		{
			get
			{
				short num = (short)355115532;
				short num2 = num;
				num = (short)1620550156;
				switch (num2 == num)
				{
				default:
				{
					num = (short)244121600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2131558401;
				if (num != 0)
				{
				}
				num = (short)212271104;
				if (num != 0)
				{
				}
				return this.sensorEventNotificationEnable_43525.HiddenDynamic;
			}
			set
			{
				short num = (short)181195105;
				short num2 = num;
				num = (short)1143460193;
				switch (num2 == num)
				{
				default:
				{
					num = (short)424673280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)610074625;
				if (num != 0)
				{
				}
				num = (short)1101529088;
				if (num != 0)
				{
				}
				this.sensorEventNotificationEnable_43525.HiddenDynamic = value;
			}
		}

		// Token: 0x1700203C RID: 8252
		// (get) Token: 0x06003EED RID: 16109 RVA: 0x003B4490 File Offset: 0x003B2690
		public bool SensorEventNotificationEnable_43525_HasDiffs
		{
			get
			{
				short num = (short)86344537;
				short num2 = num;
				num = (short)238322521;
				switch (num2 == num)
				{
				default:
				{
					num = (short)556859392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)939196417;
				if (num != 0)
				{
				}
				num = (short)699531264;
				if (num != 0)
				{
				}
				return this.sensorEventNotificationEnable_43525._HasDiffs;
			}
		}

		// Token: 0x06003EEE RID: 16110 RVA: 0x003B4548 File Offset: 0x003B2748
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
					num2 = (short)777256960;
					short num3 = num2;
					num2 = (short)1422786563;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_AD;
				case 2:
					if (base.ParentRecset != null)
					{
						goto IL_45;
					}
					goto IL_13D;
				case 3:
					if (base.ParentRecset.ContainerDoc != null)
					{
						num2 = (short)1434189828;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_13D;
				case 4:
				{
					num2 = (short)598061929;
					short num4 = num2;
					num2 = (short)337687401;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_45;
					default:
						num2 = (short)1124597760;
						if (num2 != 0)
						{
						}
						result = base.ParentRecset.ContainerDoc.GetFeature(A_0);
						num2 = (short)1553727489;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_24;
				IL_45:
				num2 = (short)721551360;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_AD:
			IL_13D:
			num2 = (short)2119237633;
			if (num2 != 0)
			{
			}
			return result;
			IL_24:
			result = null;
			num2 = (short)1571815426;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040019EC RID: 6636
		private global::AcpBusinessLayer.AcpSimpleRangeField sensorEventDisableTimer_43198;

		// Token: 0x040019ED RID: 6637
		private global::AcpBusinessLayer.AcpField<bool> sensorEventNotificationEnable_43525;
	}
}
