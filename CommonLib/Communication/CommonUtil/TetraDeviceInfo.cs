using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000072 RID: 114
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class TetraDeviceInfo : global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo, global::System.ICloneable
	{
		// Token: 0x060002FD RID: 765 RVA: 0x00036458 File Offset: 0x00034658
		public TetraDeviceInfo()
		{
			base.ConnectionInfo = new global::Motorola.Common.Communication.CommonUtil.ConnectionInfo();
			base.ConnectionInfo.AuthInfo = new global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo();
			this.HwConfigList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.HwConfigSection>();
			this.HwID = 0U;
			this.CpuID = string.Empty;
			this.TEI = string.Empty;
			base.ModelNumber = string.Empty;
			this.Issi = -1;
			this.HomeMCC = -1;
			this.HomeMCC = -1;
			base.CodeplugVersion = string.Empty;
			base.SoftwareVersion = string.Empty;
			this.PartionHealthState = -1;
			this.RpVerInfo = null;
			base.UseCompress = true;
			base.Family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.TetraRadio;
			this.UsbHubPortNumber = 0U;
			this.UsbHubInstance = string.Empty;
			this.BMPRadioFPSlots = new uint[this.FLASHPACK_SLOTS_NUMBER];
			this.BMPRadioFPInfo = null;
			this.PreAttached = false;
			this.ARP = null;
			this.ForceErase = false;
			this.IsCodeplugAuthenticationEnabled = false;
			this.BatteryLevel = 0;
			this.PowerStatus = global::Motorola.Common.Communication.CommonUtil.PowerSupplyStatus.UN_DEFINED;
			this.HardwareIdIsValid = false;
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060002FE RID: 766 RVA: 0x00036578 File Offset: 0x00034778
		// (set) Token: 0x060002FF RID: 767 RVA: 0x00036628 File Offset: 0x00034828
		[global::System.Runtime.Serialization.DataMember]
		public string Location
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)754320036;
				short num2 = num;
				num = (short)1387004580;
				switch (num2 == num)
				{
				}
				num = (short)1136132097;
				if (num != 0)
				{
				}
				num = (short)949747712;
				if (num != 0)
				{
				}
				num = (short)308215808;
				short num3 = num;
				return this.<Location>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1796931585;
				if (num != 0)
				{
				}
				num = (short)1295651612;
				short num2 = num;
				num = (short)135729948;
				switch (num2 == num)
				{
				}
				num = (short)859701248;
				if (num != 0)
				{
				}
				num = (short)2104492032;
				short num3 = num;
				this.<Location>k__BackingField = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000300 RID: 768 RVA: 0x000366D8 File Offset: 0x000348D8
		// (set) Token: 0x06000301 RID: 769 RVA: 0x00036788 File Offset: 0x00034988
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.DeviceMode DeviceMode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1232204092;
				short num2 = num;
				num = (short)548401468;
				switch (num2 == num)
				{
				}
				num = (short)806879233;
				if (num != 0)
				{
				}
				num = (short)1689911296;
				if (num != 0)
				{
				}
				num = (short)908525568;
				short num3 = num;
				return this.<DeviceMode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)823019988;
				short num2 = num;
				num = (short)433539540;
				switch (num2 == num)
				{
				}
				num = (short)569573377;
				if (num != 0)
				{
				}
				num = (short)992411648;
				if (num != 0)
				{
				}
				num = (short)1363476480;
				short num3 = num;
				this.<DeviceMode>k__BackingField = value;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000302 RID: 770 RVA: 0x00036838 File Offset: 0x00034A38
		// (set) Token: 0x06000303 RID: 771 RVA: 0x000368E8 File Offset: 0x00034AE8
		[global::System.Runtime.Serialization.DataMember]
		public string CpuID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1427243008;
				short num2 = num;
				num = (short)1612286404;
				short num3 = num;
				num = (short)1108773316;
				switch (num3 == num)
				{
				}
				num = (short)171704320;
				if (num != 0)
				{
				}
				num = (short)1453391873;
				if (num != 0)
				{
				}
				return this.<CpuID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1136918528;
				short num2 = num;
				num = (short)331811060;
				short num3 = num;
				num = (short)1400310004;
				switch (num3 == num)
				{
				}
				num = (short)945750017;
				if (num != 0)
				{
				}
				num = (short)2098266112;
				if (num != 0)
				{
				}
				this.<CpuID>k__BackingField = value;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000304 RID: 772 RVA: 0x00036998 File Offset: 0x00034B98
		// (set) Token: 0x06000305 RID: 773 RVA: 0x00036A48 File Offset: 0x00034C48
		[global::System.Runtime.Serialization.DataMember]
		public string TEI
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1990066176;
				short num2 = num;
				num = (short)530794905;
				short num3 = num;
				num = (short)1197754777;
				switch (num3 == num)
				{
				}
				num = (short)709754880;
				if (num != 0)
				{
				}
				num = (short)1836384257;
				if (num != 0)
				{
				}
				return this.<TEI>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1435566080;
				short num2 = num;
				num = (short)753268835;
				short num3 = num;
				num = (short)1444673635;
				switch (num3 == num)
				{
				}
				num = (short)681377793;
				if (num != 0)
				{
				}
				num = (short)1659633664;
				if (num != 0)
				{
				}
				this.<TEI>k__BackingField = value;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000306 RID: 774 RVA: 0x00036AFC File Offset: 0x00034CFC
		// (set) Token: 0x06000307 RID: 775 RVA: 0x00036BAC File Offset: 0x00034DAC
		[global::System.Runtime.Serialization.DataMember]
		public uint HwID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2055929856;
				short num2 = num;
				num = (short)1901200863;
				short num3 = num;
				num = (short)1666844127;
				switch (num3 == num)
				{
				}
				num = (short)1106182144;
				if (num != 0)
				{
				}
				num = (short)922091521;
				if (num != 0)
				{
				}
				return this.<HwID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1144586240;
				short num2 = num;
				num = (short)1941924606;
				short num3 = num;
				num = (short)470838014;
				switch (num3 == num)
				{
				}
				num = (short)1234763777;
				if (num != 0)
				{
				}
				num = (short)2035679232;
				if (num != 0)
				{
				}
				this.<HwID>k__BackingField = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000308 RID: 776 RVA: 0x00036C5C File Offset: 0x00034E5C
		// (set) Token: 0x06000309 RID: 777 RVA: 0x00036D0C File Offset: 0x00034F0C
		[global::System.Runtime.Serialization.DataMember]
		public int HomeMCC
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)722927616;
				short num2 = num;
				num = (short)599658712;
				short num3 = num;
				num = (short)1469386968;
				switch (num3 == num)
				{
				}
				num = (short)184680449;
				if (num != 0)
				{
				}
				num = (short)1425801216;
				if (num != 0)
				{
				}
				return this.<HomeMCC>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1600978944;
				short num2 = num;
				num = (short)1460332185;
				short num3 = num;
				num = (short)827385497;
				switch (num3 == num)
				{
				}
				num = (short)644218881;
				if (num != 0)
				{
				}
				num = (short)201392128;
				if (num != 0)
				{
				}
				this.<HomeMCC>k__BackingField = value;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x0600030A RID: 778 RVA: 0x00036DC0 File Offset: 0x00034FC0
		// (set) Token: 0x0600030B RID: 779 RVA: 0x00036E74 File Offset: 0x00035074
		[global::System.Runtime.Serialization.DataMember]
		public int HomeMNC
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)979566592;
				short num2 = num;
				num = (short)1625722755;
				short num3 = num;
				num = (short)1597214595;
				switch (num3 == num)
				{
				}
				num = (short)1685979137;
				if (num != 0)
				{
				}
				num = (short)1577320448;
				if (num != 0)
				{
				}
				return this.<HomeMNC>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)983629824;
				short num2 = num;
				num = (short)95116951;
				short num3 = num;
				num = (short)501374615;
				switch (num3 == num)
				{
				}
				num = (short)1244200960;
				if (num != 0)
				{
				}
				num = (short)621805569;
				if (num != 0)
				{
				}
				this.<HomeMNC>k__BackingField = value;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600030C RID: 780 RVA: 0x00036F28 File Offset: 0x00035128
		// (set) Token: 0x0600030D RID: 781 RVA: 0x00036FD8 File Offset: 0x000351D8
		[global::System.Runtime.Serialization.DataMember]
		public string CpuType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2066087936;
				short num2 = num;
				num = (short)2029258315;
				short num3 = num;
				num = (short)825427531;
				switch (num3 == num)
				{
				}
				num = (short)1848180737;
				if (num != 0)
				{
				}
				num = (short)1920204800;
				if (num != 0)
				{
				}
				return this.<CpuType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)340525056;
				short num2 = num;
				num = (short)693149941;
				short num3 = num;
				num = (short)648519925;
				switch (num3 == num)
				{
				}
				num = (short)873005056;
				if (num != 0)
				{
				}
				num = (short)1457258497;
				if (num != 0)
				{
				}
				this.<CpuType>k__BackingField = value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x0600030E RID: 782 RVA: 0x00037088 File Offset: 0x00035288
		// (set) Token: 0x0600030F RID: 783 RVA: 0x00037138 File Offset: 0x00035338
		[global::System.Runtime.Serialization.DataMember]
		public int PartionHealthState
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1353515008;
				short num2 = num;
				num = (short)508532104;
				short num3 = num;
				num = (short)1299944840;
				switch (num3 == num)
				{
				}
				num = (short)802291713;
				if (num != 0)
				{
				}
				num = (short)1082982400;
				if (num != 0)
				{
				}
				return this.<PartionHealthState>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2086993920;
				short num2 = num;
				num = (short)1999021782;
				short num3 = num;
				num = (short)920757974;
				switch (num3 == num)
				{
				}
				num = (short)1586692096;
				if (num != 0)
				{
				}
				num = (short)1684602881;
				if (num != 0)
				{
				}
				this.<PartionHealthState>k__BackingField = value;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000310 RID: 784 RVA: 0x000371E4 File Offset: 0x000353E4
		// (set) Token: 0x06000311 RID: 785 RVA: 0x00037294 File Offset: 0x00035494
		[global::System.Runtime.Serialization.DataMember]
		public string CompositeDeviceLocation
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1446707200;
				short num2 = num;
				num = (short)1032912897;
				if (num != 0)
				{
				}
				num = (short)110664230;
				short num3 = num;
				num = (short)1113823782;
				switch (num3 == num)
				{
				}
				num = (short)385810432;
				if (num != 0)
				{
				}
				return this.<CompositeDeviceLocation>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1107623936;
				short num2 = num;
				num = (short)1995850385;
				short num3 = num;
				num = (short)1451115153;
				switch (num3 == num)
				{
				}
				num = (short)348782592;
				if (num != 0)
				{
				}
				num = (short)1683947521;
				if (num != 0)
				{
				}
				this.<CompositeDeviceLocation>k__BackingField = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000312 RID: 786 RVA: 0x00037348 File Offset: 0x00035548
		// (set) Token: 0x06000313 RID: 787 RVA: 0x000373FC File Offset: 0x000355FC
		[global::System.Runtime.Serialization.DataMember]
		public uint FlashID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1174405120;
				short num2 = num;
				num = (short)107082385;
				short num3 = num;
				num = (short)2041967249;
				switch (num3 == num)
				{
				}
				num = (short)1068105729;
				if (num != 0)
				{
				}
				num = (short)1808465920;
				if (num != 0)
				{
				}
				return this.<FlashID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)150536192;
				short num2 = num;
				num = (short)1089166028;
				short num3 = num;
				num = (short)283138764;
				switch (num3 == num)
				{
				}
				num = (short)1196883969;
				if (num != 0)
				{
				}
				num = (short)1807810560;
				if (num != 0)
				{
				}
				this.<FlashID>k__BackingField = value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000314 RID: 788 RVA: 0x000374AC File Offset: 0x000356AC
		// (set) Token: 0x06000315 RID: 789 RVA: 0x0003755C File Offset: 0x0003575C
		[global::System.Runtime.Serialization.DataMember]
		public uint FlashVID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)939851776;
				short num2 = num;
				num = (short)1373531051;
				short num3 = num;
				num = (short)436693931;
				switch (num3 == num)
				{
				}
				num = (short)842924032;
				if (num != 0)
				{
				}
				num = (short)1362886657;
				if (num != 0)
				{
				}
				return this.<FlashVID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)888733696;
				short num2 = num;
				num = (short)516496042;
				short num3 = num;
				num = (short)1358568106;
				switch (num3 == num)
				{
				}
				num = (short)1614217217;
				if (num != 0)
				{
				}
				num = (short)465174528;
				if (num != 0)
				{
				}
				this.<FlashVID>k__BackingField = value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000316 RID: 790 RVA: 0x00037610 File Offset: 0x00035810
		// (set) Token: 0x06000317 RID: 791 RVA: 0x000376C0 File Offset: 0x000358C0
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.TetraRadioType RadioType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1303576576;
				short num2 = num;
				num = (short)1282079003;
				short num3 = num;
				num = (short)1903098139;
				switch (num3 == num)
				{
				}
				num = (short)57278464;
				if (num != 0)
				{
				}
				num = (short)1948319745;
				if (num != 0)
				{
				}
				return this.<RadioType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1768685568;
				short num2 = num;
				num = (short)1435303937;
				if (num != 0)
				{
				}
				num = (short)583816084;
				short num3 = num;
				num = (short)471880596;
				switch (num3 == num)
				{
				}
				num = (short)770506752;
				if (num != 0)
				{
				}
				this.<RadioType>k__BackingField = value;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000318 RID: 792 RVA: 0x00037770 File Offset: 0x00035970
		// (set) Token: 0x06000319 RID: 793 RVA: 0x00037820 File Offset: 0x00035A20
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.HwConfigSection> HwConfigList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1246298112;
				short num2 = num;
				num = (short)1042765678;
				short num3 = num;
				num = (short)1272076142;
				switch (num3 == num)
				{
				}
				num = (short)480903168;
				if (num != 0)
				{
				}
				num = (short)1937506305;
				if (num != 0)
				{
				}
				return this.<HwConfigList>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)217120768;
				short num2 = num;
				num = (short)464607790;
				short num3 = num;
				num = (short)406608430;
				switch (num3 == num)
				{
				}
				num = (short)316866561;
				if (num != 0)
				{
				}
				num = (short)1181548544;
				if (num != 0)
				{
				}
				this.<HwConfigList>k__BackingField = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600031A RID: 794 RVA: 0x000378D0 File Offset: 0x00035AD0
		// (set) Token: 0x0600031B RID: 795 RVA: 0x0003797C File Offset: 0x00035B7C
		[global::System.Runtime.Serialization.DataMember]
		public uint DevInstanceNum
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)317521920;
				short num2 = num;
				num = (short)1360986113;
				if (num != 0)
				{
				}
				num = (short)904115830;
				short num3 = num;
				num = (short)2012790;
				switch (num3 == num)
				{
				}
				num = (short)1851719680;
				if (num != 0)
				{
				}
				return this.<DevInstanceNum>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1518075904;
				short num2 = num;
				num = (short)898029029;
				short num3 = num;
				num = (short)627037669;
				switch (num3 == num)
				{
				}
				num = (short)570949632;
				if (num != 0)
				{
				}
				num = (short)1062469633;
				if (num != 0)
				{
				}
				this.<DevInstanceNum>k__BackingField = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x0600031C RID: 796 RVA: 0x00037A28 File Offset: 0x00035C28
		// (set) Token: 0x0600031D RID: 797 RVA: 0x00037AD8 File Offset: 0x00035CD8
		[global::System.Runtime.Serialization.DataMember]
		public uint ParentDevInstanceNum
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)745930752;
				short num2 = num;
				num = (short)1301304704;
				short num3 = num;
				num = (short)233854336;
				switch (num3 == num)
				{
				}
				num = (short)877461505;
				if (num != 0)
				{
				}
				num = (short)621674496;
				if (num != 0)
				{
				}
				return this.<ParentDevInstanceNum>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1374617600;
				short num2 = num;
				num = (short)923820691;
				short num3 = num;
				num = (short)143352467;
				switch (num3 == num)
				{
				}
				num = (short)364380161;
				if (num != 0)
				{
				}
				num = (short)1665662976;
				if (num != 0)
				{
				}
				this.<ParentDevInstanceNum>k__BackingField = value;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x0600031E RID: 798 RVA: 0x00037B90 File Offset: 0x00035D90
		// (set) Token: 0x0600031F RID: 799 RVA: 0x00037C40 File Offset: 0x00035E40
		[global::System.Runtime.Serialization.DataMember]
		public string PID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)736165888;
				short num2 = num;
				num = (short)340161594;
				short num3 = num;
				num = (short)1374909498;
				switch (num3 == num)
				{
				}
				num = (short)1069285377;
				if (num != 0)
				{
				}
				num = (short)893845504;
				if (num != 0)
				{
				}
				return this.<PID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)802816000;
				short num2 = num;
				num = (short)1408627410;
				short num3 = num;
				num = (short)162001618;
				switch (num3 == num)
				{
				}
				num = (short)2137980929;
				if (num != 0)
				{
				}
				num = (short)1557987328;
				if (num != 0)
				{
				}
				this.<PID>k__BackingField = value;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000320 RID: 800 RVA: 0x00037CF4 File Offset: 0x00035EF4
		// (set) Token: 0x06000321 RID: 801 RVA: 0x00037DA4 File Offset: 0x00035FA4
		[global::System.Runtime.Serialization.DataMember]
		public string VID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1176502272;
				short num2 = num;
				num = (short)165892560;
				short num3 = num;
				num = (short)1510691280;
				switch (num3 == num)
				{
				}
				num = (short)1665794049;
				if (num != 0)
				{
				}
				num = (short)1115947008;
				if (num != 0)
				{
				}
				return this.<VID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)978976768;
				short num2 = num;
				num = (short)1628569601;
				if (num != 0)
				{
				}
				num = (short)693909189;
				short num3 = num;
				num = (short)1726625477;
				switch (num3 == num)
				{
				}
				num = (short)2123628544;
				if (num != 0)
				{
				}
				this.<VID>k__BackingField = value;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000322 RID: 802 RVA: 0x00037E58 File Offset: 0x00036058
		// (set) Token: 0x06000323 RID: 803 RVA: 0x00037F04 File Offset: 0x00036104
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.ActiveTransRadioType ActiveTransRadioType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2093219840;
				short num2 = num;
				num = (short)134261087;
				short num3 = num;
				num = (short)176204127;
				switch (num3 == num)
				{
				}
				num = (short)1524367361;
				if (num != 0)
				{
				}
				num = (short)2028797952;
				if (num != 0)
				{
				}
				return this.<ActiveTransRadioType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1142816768;
				short num2 = num;
				num = (short)1137764493;
				short num3 = num;
				num = (short)1064626317;
				switch (num3 == num)
				{
				}
				num = (short)1798438913;
				if (num != 0)
				{
				}
				num = (short)1141440512;
				if (num != 0)
				{
				}
				this.<ActiveTransRadioType>k__BackingField = value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000324 RID: 804 RVA: 0x00037FB4 File Offset: 0x000361B4
		// (set) Token: 0x06000325 RID: 805 RVA: 0x00038060 File Offset: 0x00036260
		[global::System.Runtime.Serialization.DataMember]
		public int Issi
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)730660864;
				short num2 = num;
				num = (short)1276423740;
				short num3 = num;
				num = (short)2111286844;
				switch (num3 == num)
				{
				}
				num = (short)49152000;
				if (num != 0)
				{
				}
				num = (short)826474497;
				if (num != 0)
				{
				}
				return this.<Issi>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2041643008;
				short num2 = num;
				num = (short)1980908524;
				short num3 = num;
				num = (short)1219249132;
				switch (num3 == num)
				{
				}
				num = (short)1136918528;
				if (num != 0)
				{
				}
				num = (short)957218817;
				if (num != 0)
				{
				}
				this.<Issi>k__BackingField = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000326 RID: 806 RVA: 0x00038110 File Offset: 0x00036310
		// (set) Token: 0x06000327 RID: 807 RVA: 0x000381C0 File Offset: 0x000363C0
		[global::System.Runtime.Serialization.DataMember]
		public byte[] ARP
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)594804736;
				short num2 = num;
				num = (short)2016747020;
				short num3 = num;
				num = (short)1152261644;
				switch (num3 == num)
				{
				}
				num = (short)649068545;
				if (num != 0)
				{
				}
				num = (short)1262026752;
				if (num != 0)
				{
				}
				return this.<ARP>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)423690240;
				short num2 = num;
				num = (short)171769495;
				short num3 = num;
				num = (short)397344407;
				switch (num3 == num)
				{
				}
				num = (short)1712455681;
				if (num != 0)
				{
				}
				num = (short)1370030080;
				if (num != 0)
				{
				}
				this.<ARP>k__BackingField = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000328 RID: 808 RVA: 0x00038270 File Offset: 0x00036470
		// (set) Token: 0x06000329 RID: 809 RVA: 0x00038320 File Offset: 0x00036520
		[global::System.Runtime.Serialization.DataMember]
		public byte[] DUP
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1137180672;
				short num2 = num;
				num = (short)481773471;
				short num3 = num;
				num = (short)912213919;
				switch (num3 == num)
				{
				}
				num = (short)696188929;
				if (num != 0)
				{
				}
				num = (short)1839333376;
				if (num != 0)
				{
				}
				return this.<DUP>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)914751488;
				short num2 = num;
				num = (short)1034916898;
				short num3 = num;
				num = (short)1555731490;
				switch (num3 == num)
				{
				}
				num = (short)170590209;
				if (num != 0)
				{
				}
				num = (short)2136080384;
				if (num != 0)
				{
				}
				this.<DUP>k__BackingField = value;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x0600032A RID: 810 RVA: 0x000383D0 File Offset: 0x000365D0
		// (set) Token: 0x0600032B RID: 811 RVA: 0x00038480 File Offset: 0x00036680
		[global::System.Runtime.Serialization.DataMember]
		public bool IsCodeplugAuthenticationEnabled
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)272695296;
				short num2 = num;
				num = (short)1805529776;
				short num3 = num;
				num = (short)907358896;
				switch (num3 == num)
				{
				}
				num = (short)1933508609;
				if (num != 0)
				{
				}
				num = (short)832241664;
				if (num != 0)
				{
				}
				return this.<IsCodeplugAuthenticationEnabled>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)860946432;
				short num2 = num;
				num = (short)1031716564;
				short num3 = num;
				num = (short)840744660;
				switch (num3 == num)
				{
				}
				num = (short)784662529;
				if (num != 0)
				{
				}
				num = (short)962002944;
				if (num != 0)
				{
				}
				this.<IsCodeplugAuthenticationEnabled>k__BackingField = value;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x0600032C RID: 812 RVA: 0x00038530 File Offset: 0x00036730
		// (set) Token: 0x0600032D RID: 813 RVA: 0x000385E0 File Offset: 0x000367E0
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.RPVersionInfo RpVerInfo
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)224591872;
				short num2 = num;
				num = (short)1588755721;
				short num3 = num;
				num = (short)445545737;
				switch (num3 == num)
				{
				}
				num = (short)1590951937;
				if (num != 0)
				{
				}
				num = (short)1501495296;
				if (num != 0)
				{
				}
				return this.<RpVerInfo>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1673592832;
				short num2 = num;
				num = (short)1184438906;
				short num3 = num;
				num = (short)1260067450;
				switch (num3 == num)
				{
				}
				num = (short)709558273;
				if (num != 0)
				{
				}
				num = (short)1452343296;
				if (num != 0)
				{
				}
				this.<RpVerInfo>k__BackingField = value;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x0600032E RID: 814 RVA: 0x00038690 File Offset: 0x00036890
		// (set) Token: 0x0600032F RID: 815 RVA: 0x00038740 File Offset: 0x00036940
		[global::System.Runtime.Serialization.DataMember]
		public uint UsbHubPortNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)935723008;
				short num2 = num;
				num = (short)943171958;
				short num3 = num;
				num = (short)2136779126;
				switch (num3 == num)
				{
				}
				num = (short)796262401;
				if (num != 0)
				{
				}
				num = (short)272105472;
				if (num != 0)
				{
				}
				return this.<UsbHubPortNumber>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1679491072;
				short num2 = num;
				num = (short)700932496;
				short num3 = num;
				num = (short)2089574800;
				switch (num3 == num)
				{
				}
				num = (short)639369217;
				if (num != 0)
				{
				}
				num = (short)893386752;
				if (num != 0)
				{
				}
				this.<UsbHubPortNumber>k__BackingField = value;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000330 RID: 816 RVA: 0x000387F0 File Offset: 0x000369F0
		// (set) Token: 0x06000331 RID: 817 RVA: 0x000388A4 File Offset: 0x00036AA4
		[global::System.Runtime.Serialization.DataMember]
		public string UsbHubInstance
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1769144320;
				short num2 = num;
				num = (short)807206913;
				if (num != 0)
				{
				}
				num = (short)1823854687;
				short num3 = num;
				num = (short)1769197663;
				switch (num3 == num)
				{
				}
				num = (short)2042953728;
				if (num != 0)
				{
				}
				return this.<UsbHubInstance>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1531052032;
				short num2 = num;
				num = (short)216941622;
				short num3 = num;
				num = (short)1366311990;
				switch (num3 == num)
				{
				}
				num = (short)816381952;
				if (num != 0)
				{
				}
				num = (short)529924097;
				if (num != 0)
				{
				}
				this.<UsbHubInstance>k__BackingField = value;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x06000332 RID: 818 RVA: 0x00038954 File Offset: 0x00036B54
		// (set) Token: 0x06000333 RID: 819 RVA: 0x00038A04 File Offset: 0x00036C04
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.RadioFPInfo BMPRadioFPInfo
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)254738432;
				short num2 = num;
				num = (short)960494393;
				short num3 = num;
				num = (short)1201797945;
				switch (num3 == num)
				{
				}
				num = (short)1689976832;
				if (num != 0)
				{
				}
				num = (short)923664385;
				if (num != 0)
				{
				}
				return this.<BMPRadioFPInfo>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)658505728;
				short num2 = num;
				num = (short)451959724;
				short num3 = num;
				num = (short)744840108;
				switch (num3 == num)
				{
				}
				num = (short)1017708545;
				if (num != 0)
				{
				}
				num = (short)1421475840;
				if (num != 0)
				{
				}
				this.<BMPRadioFPInfo>k__BackingField = value;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x06000334 RID: 820 RVA: 0x00038AB4 File Offset: 0x00036CB4
		// (set) Token: 0x06000335 RID: 821 RVA: 0x00038B64 File Offset: 0x00036D64
		[global::System.Runtime.Serialization.DataMember]
		public uint[] BMPRadioFPSlots
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)972881920;
				short num2 = num;
				num = (short)1102227491;
				short num3 = num;
				num = (short)457353251;
				switch (num3 == num)
				{
				}
				num = (short)2097741824;
				if (num != 0)
				{
				}
				num = (short)750387201;
				if (num != 0)
				{
				}
				return this.<BMPRadioFPSlots>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1548353536;
				short num2 = num;
				num = (short)1633200087;
				short num3 = num;
				num = (short)1142204375;
				switch (num3 == num)
				{
				}
				num = (short)669581313;
				if (num != 0)
				{
				}
				num = (short)1924595712;
				if (num != 0)
				{
				}
				this.<BMPRadioFPSlots>k__BackingField = value;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x06000336 RID: 822 RVA: 0x00038C14 File Offset: 0x00036E14
		// (set) Token: 0x06000337 RID: 823 RVA: 0x00038CC4 File Offset: 0x00036EC4
		[global::System.Runtime.Serialization.DataMember]
		public bool PreAttached
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)229965824;
				short num2 = num;
				num = (short)190578689;
				if (num != 0)
				{
				}
				num = (short)1442031473;
				short num3 = num;
				num = (short)91400049;
				switch (num3 == num)
				{
				}
				num = (short)412811264;
				if (num != 0)
				{
				}
				return this.<PreAttached>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1833762816;
				short num2 = num;
				num = (short)1771700225;
				if (num != 0)
				{
				}
				num = (short)964679313;
				short num3 = num;
				num = (short)1101715089;
				switch (num3 == num)
				{
				}
				num = (short)1149108224;
				if (num != 0)
				{
				}
				this.<PreAttached>k__BackingField = value;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000338 RID: 824 RVA: 0x00038D74 File Offset: 0x00036F74
		// (set) Token: 0x06000339 RID: 825 RVA: 0x00038E24 File Offset: 0x00037024
		[global::System.Runtime.Serialization.DataMember]
		public bool ForceErase
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)783679488;
				short num2 = num;
				num = (short)2012500152;
				short num3 = num;
				num = (short)602296504;
				switch (num3 == num)
				{
				}
				num = (short)1839988737;
				if (num != 0)
				{
				}
				num = (short)2054225920;
				if (num != 0)
				{
				}
				return this.<ForceErase>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2126708736;
				short num2 = num;
				num = (short)298595887;
				short num3 = num;
				num = (short)1321678383;
				switch (num3 == num)
				{
				}
				num = (short)1198260225;
				if (num != 0)
				{
				}
				num = (short)557252608;
				if (num != 0)
				{
				}
				this.<ForceErase>k__BackingField = value;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x0600033A RID: 826 RVA: 0x00038ED4 File Offset: 0x000370D4
		// (set) Token: 0x0600033B RID: 827 RVA: 0x00038F84 File Offset: 0x00037184
		[global::System.Runtime.Serialization.DataMember]
		public int BatteryLevel
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1259732992;
				short num2 = num;
				num = (short)1615835525;
				short num3 = num;
				num = (short)549237125;
				switch (num3 == num)
				{
				}
				num = (short)1900544001;
				if (num != 0)
				{
				}
				num = (short)1500119040;
				if (num != 0)
				{
				}
				return this.<BatteryLevel>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1394212864;
				short num2 = num;
				num = (short)1892609898;
				short num3 = num;
				num = (short)330821482;
				switch (num3 == num)
				{
				}
				num = (short)1808072705;
				if (num != 0)
				{
				}
				num = (short)2028666880;
				if (num != 0)
				{
				}
				this.<BatteryLevel>k__BackingField = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x0600033C RID: 828 RVA: 0x00039034 File Offset: 0x00037234
		// (set) Token: 0x0600033D RID: 829 RVA: 0x000390E0 File Offset: 0x000372E0
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.Common.Communication.CommonUtil.PowerSupplyStatus PowerStatus
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1672347648;
				short num2 = num;
				num = (short)194396653;
				short num3 = num;
				num = (short)1618690541;
				switch (num3 == num)
				{
				}
				num = (short)85590017;
				if (num != 0)
				{
				}
				num = (short)972357632;
				if (num != 0)
				{
				}
				return this.<PowerStatus>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1020854272;
				short num2 = num;
				num = (short)371392513;
				if (num != 0)
				{
				}
				num = (short)1791373305;
				short num3 = num;
				num = (short)158085113;
				switch (num3 == num)
				{
				}
				num = (short)1087307776;
				if (num != 0)
				{
				}
				this.<PowerStatus>k__BackingField = value;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x0600033E RID: 830 RVA: 0x00039190 File Offset: 0x00037390
		// (set) Token: 0x0600033F RID: 831 RVA: 0x00039240 File Offset: 0x00037440
		[global::System.Runtime.Serialization.DataMember]
		public bool HardwareIdIsValid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1199112192;
				short num2 = num;
				num = (short)329979261;
				short num3 = num;
				num = (short)94705021;
				switch (num3 == num)
				{
				}
				num = (short)788922368;
				if (num != 0)
				{
				}
				num = (short)1513226241;
				if (num != 0)
				{
				}
				return this.<HardwareIdIsValid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1366425600;
				short num2 = num;
				num = (short)2114170437;
				short num3 = num;
				num = (short)1441508933;
				switch (num3 == num)
				{
				}
				num = (short)307625985;
				if (num != 0)
				{
				}
				num = (short)1018626048;
				if (num != 0)
				{
				}
				this.<HardwareIdIsValid>k__BackingField = value;
			}
		}

		// Token: 0x06000340 RID: 832 RVA: 0x000392F0 File Offset: 0x000374F0
		public object Clone()
		{
			short num = (short)263585792;
			short num2 = num;
			num = (short)1429798913;
			if (num != 0)
			{
			}
			num = (short)7893599;
			short num3 = num;
			num = (short)284783199;
			switch (num3 == num)
			{
			}
			num = (short)750321664;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo tetraDeviceInfo = base.MemberwiseClone() as global::Motorola.Common.Communication.CommonUtil.TetraDeviceInfo;
			tetraDeviceInfo.RadioID = this.RadioID;
			tetraDeviceInfo.Location = this.Location;
			tetraDeviceInfo.DeviceMode = this.DeviceMode;
			tetraDeviceInfo.CpuID = this.CpuID;
			tetraDeviceInfo.TEI = this.TEI;
			tetraDeviceInfo.HwID = this.HwID;
			tetraDeviceInfo.HomeMCC = this.HomeMCC;
			tetraDeviceInfo.HomeMNC = this.HomeMNC;
			tetraDeviceInfo.CpuType = this.CpuType;
			tetraDeviceInfo.PartionHealthState = this.PartionHealthState;
			tetraDeviceInfo.CompositeDeviceLocation = this.CompositeDeviceLocation;
			tetraDeviceInfo.FlashID = this.FlashID;
			tetraDeviceInfo.FlashVID = this.FlashVID;
			tetraDeviceInfo.RadioType = this.RadioType;
			tetraDeviceInfo.HwConfigList = this.HwConfigList;
			tetraDeviceInfo.DevInstanceNum = this.DevInstanceNum;
			tetraDeviceInfo.ParentDevInstanceNum = this.ParentDevInstanceNum;
			tetraDeviceInfo.PID = this.PID;
			tetraDeviceInfo.VID = this.VID;
			tetraDeviceInfo.ActiveTransRadioType = this.ActiveTransRadioType;
			tetraDeviceInfo.Issi = this.Issi;
			tetraDeviceInfo.RpVerInfo = this.RpVerInfo;
			tetraDeviceInfo.ConnectionInfo.ConnectionType = base.ConnectionInfo.ConnectionType;
			tetraDeviceInfo.ConnectionInfo.Location = base.ConnectionInfo.Location;
			tetraDeviceInfo.ConnectionInfo.UniqueAddress = base.ConnectionInfo.UniqueAddress;
			tetraDeviceInfo.ConnectionInfo.SessionID = base.ConnectionInfo.SessionID;
			tetraDeviceInfo.ConnectionInfo.InactivityTimeout = base.ConnectionInfo.InactivityTimeout;
			tetraDeviceInfo.ConnectionInfo.AuthInfo.AuthType = base.ConnectionInfo.AuthInfo.AuthType;
			tetraDeviceInfo.ConnectionInfo.AuthInfo.Certificate_File = base.ConnectionInfo.AuthInfo.Certificate_File;
			tetraDeviceInfo.ConnectionInfo.AuthInfo.PreSharedKey_ID = base.ConnectionInfo.AuthInfo.PreSharedKey_ID;
			tetraDeviceInfo.ConnectionInfo.AuthInfo.PreSharedKey_Material = base.ConnectionInfo.AuthInfo.PreSharedKey_Material;
			tetraDeviceInfo.ConnectionInfo.DeviceInstance = base.ConnectionInfo.DeviceInstance;
			tetraDeviceInfo.Family = base.Family;
			tetraDeviceInfo.RadioState = base.RadioState;
			tetraDeviceInfo.RadioStorage = base.RadioStorage;
			tetraDeviceInfo.RadioID = this.RadioID;
			tetraDeviceInfo.ModelNumber = base.ModelNumber;
			tetraDeviceInfo.SerialNumber = base.SerialNumber;
			tetraDeviceInfo.CodeplugVersion = base.CodeplugVersion;
			tetraDeviceInfo.SoftwareVersion = base.SoftwareVersion;
			tetraDeviceInfo.UseCompress = base.UseCompress;
			tetraDeviceInfo.UsbHubInstance = this.UsbHubInstance;
			tetraDeviceInfo.UsbHubPortNumber = this.UsbHubPortNumber;
			tetraDeviceInfo.PreAttached = this.PreAttached;
			tetraDeviceInfo.OperationId = base.OperationId;
			tetraDeviceInfo.ForceErase = this.ForceErase;
			tetraDeviceInfo.ARP = this.ARP;
			tetraDeviceInfo.DUP = this.DUP;
			tetraDeviceInfo.IsCodeplugAuthenticationEnabled = this.IsCodeplugAuthenticationEnabled;
			tetraDeviceInfo.BatteryLevel = this.BatteryLevel;
			tetraDeviceInfo.PowerStatus = this.PowerStatus;
			tetraDeviceInfo.HardwareIdIsValid = this.HardwareIdIsValid;
			return tetraDeviceInfo;
		}

		// Token: 0x04000311 RID: 785
		private string _radioID = string.Empty;

		// Token: 0x04000312 RID: 786
		private int FLASHPACK_SLOTS_NUMBER = 128;
	}
}
