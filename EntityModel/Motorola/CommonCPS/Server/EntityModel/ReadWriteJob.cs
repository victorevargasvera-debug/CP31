using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000091 RID: 145
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class ReadWriteJob : global::Motorola.CommonCPS.Server.EntityModel.Job
	{
		// Token: 0x06000AE6 RID: 2790 RVA: 0x0007574C File Offset: 0x0007394C
		public ReadWriteJob()
		{
			this.Tasks = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Task>();
			this.UserDefersAllowed = new int?(-1);
		}

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06000AE7 RID: 2791 RVA: 0x00075778 File Offset: 0x00073978
		// (set) Token: 0x06000AE8 RID: 2792 RVA: 0x00075828 File Offset: 0x00073A28
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? RadioUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)850595661;
				short num2 = num;
				num = (short)734990157;
				switch (num2 == num)
				{
				}
				num = (short)248905728;
				short num3 = num;
				num = (short)417726465;
				if (num != 0)
				{
				}
				num = (short)424673280;
				if (num != 0)
				{
				}
				return this.<RadioUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2126575673;
				short num2 = num;
				num = (short)1181546553;
				switch (num2 == num)
				{
				}
				num = (short)88342528;
				short num3 = num;
				num = (short)1955397633;
				if (num != 0)
				{
				}
				num = (short)1353646080;
				if (num != 0)
				{
				}
				this.<RadioUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06000AE9 RID: 2793 RVA: 0x000758D8 File Offset: 0x00073AD8
		// (set) Token: 0x06000AEA RID: 2794 RVA: 0x00075988 File Offset: 0x00073B88
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? CodeplugUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1316307000;
				short num2 = num;
				num = (short)1165115448;
				switch (num2 == num)
				{
				}
				num = (short)1004077056;
				short num3 = num;
				num = (short)29949953;
				if (num != 0)
				{
				}
				num = (short)636485632;
				if (num != 0)
				{
				}
				return this.<CodeplugUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)599762263;
				short num2 = num;
				num = (short)1037673815;
				switch (num2 == num)
				{
				}
				num = (short)1616576512;
				short num3 = num;
				num = (short)844169216;
				if (num != 0)
				{
				}
				num = (short)1551302657;
				if (num != 0)
				{
				}
				this.<CodeplugUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06000AEB RID: 2795 RVA: 0x00075A38 File Offset: 0x00073C38
		// (set) Token: 0x06000AEC RID: 2796 RVA: 0x00075AE8 File Offset: 0x00073CE8
		[global::System.Runtime.Serialization.DataMember]
		public string DeviceID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1591869740;
				short num2 = num;
				num = (short)569311532;
				switch (num2 == num)
				{
				}
				num = (short)1877999616;
				short num3 = num;
				num = (short)994967553;
				if (num != 0)
				{
				}
				num = (short)1347420160;
				if (num != 0)
				{
				}
				return this.<DeviceID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1846207126;
				short num2 = num;
				num = (short)1009771158;
				switch (num2 == num)
				{
				}
				num = (short)1061945344;
				short num3 = num;
				num = (short)1552482305;
				if (num != 0)
				{
				}
				num = (short)1618804736;
				if (num != 0)
				{
				}
				this.<DeviceID>k__BackingField = value;
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06000AED RID: 2797 RVA: 0x00075B9C File Offset: 0x00073D9C
		// (set) Token: 0x06000AEE RID: 2798 RVA: 0x00075C48 File Offset: 0x00073E48
		[global::System.Runtime.Serialization.DataMember]
		public string SerialNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)719489653;
				short num2 = num;
				num = (short)1019251317;
				switch (num2 == num)
				{
				}
				num = (short)716963840;
				short num3 = num;
				num = (short)1048444929;
				if (num != 0)
				{
				}
				num = (short)492306432;
				if (num != 0)
				{
				}
				return this.<SerialNumber>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)935872466;
				short num2 = num;
				num = (short)491014098;
				switch (num2 == num)
				{
				}
				num = (short)1699938304;
				short num3 = num;
				num = (short)1208221697;
				if (num != 0)
				{
				}
				num = (short)1371602944;
				if (num != 0)
				{
				}
				this.<SerialNumber>k__BackingField = value;
			}
		}

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06000AEF RID: 2799 RVA: 0x00075CF8 File Offset: 0x00073EF8
		// (set) Token: 0x06000AF0 RID: 2800 RVA: 0x00075DA8 File Offset: 0x00073FA8
		[global::System.Runtime.Serialization.DataMember]
		public int? ConnectionMethod
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)838224806;
				short num2 = num;
				num = (short)1942440870;
				switch (num2 == num)
				{
				}
				num = (short)1124597760;
				short num3 = num;
				num = (short)1134362624;
				if (num != 0)
				{
				}
				num = (short)981139457;
				if (num != 0)
				{
				}
				return this.<ConnectionMethod>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2062577674;
				short num2 = num;
				num = (short)285372426;
				switch (num2 == num)
				{
				}
				num = (short)758120448;
				short num3 = num;
				num = (short)117047296;
				if (num != 0)
				{
				}
				num = (short)850919425;
				if (num != 0)
				{
				}
				this.<ConnectionMethod>k__BackingField = value;
			}
		}

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06000AF1 RID: 2801 RVA: 0x00075E58 File Offset: 0x00074058
		// (set) Token: 0x06000AF2 RID: 2802 RVA: 0x00075F0C File Offset: 0x0007410C
		[global::System.Runtime.Serialization.DataMember]
		public int? SessionId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1287791157;
				short num2 = num;
				num = (short)823337525;
				switch (num2 == num)
				{
				}
				num = (short)910032896;
				short num3 = num;
				num = (short)1209991169;
				if (num != 0)
				{
				}
				num = (short)2133000192;
				if (num != 0)
				{
				}
				return this.<SessionId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1175388161;
				if (num != 0)
				{
				}
				num = (short)1851822625;
				short num2 = num;
				num = (short)799248929;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1948778496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)822280192;
				if (num != 0)
				{
				}
				this.<SessionId>k__BackingField = value;
			}
		}

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06000AF3 RID: 2803 RVA: 0x00075FBC File Offset: 0x000741BC
		// (set) Token: 0x06000AF4 RID: 2804 RVA: 0x0007606C File Offset: 0x0007426C
		[global::System.Runtime.Serialization.DataMember]
		public int AutoID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)209570663;
				short num2 = num;
				num = (short)1923664743;
				switch (num2 == num)
				{
				}
				num = (short)78839808;
				short num3 = num;
				num = (short)883228673;
				if (num != 0)
				{
				}
				num = (short)1486356480;
				if (num != 0)
				{
				}
				return this.<AutoID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)863125247;
				short num2 = num;
				num = (short)250560255;
				switch (num2 == num)
				{
				}
				num = (short)798883840;
				short num3 = num;
				num = (short)851574785;
				if (num != 0)
				{
				}
				num = (short)1063911424;
				if (num != 0)
				{
				}
				this.<AutoID>k__BackingField = value;
			}
		}

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06000AF5 RID: 2805 RVA: 0x0007611C File Offset: 0x0007431C
		// (set) Token: 0x06000AF6 RID: 2806 RVA: 0x000761C8 File Offset: 0x000743C8
		[global::System.Runtime.Serialization.DataMember]
		[global::System.ComponentModel.DataAnnotations.Schema.NotMapped]
		public string FeaturesExchangeData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1348734802;
				short num2 = num;
				num = (short)1378422610;
				switch (num2 == num)
				{
				}
				num = (short)768671744;
				short num3 = num;
				num = (short)1336082433;
				if (num != 0)
				{
				}
				num = (short)806289408;
				if (num != 0)
				{
				}
				return this.<FeaturesExchangeData>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2036541602;
				short num2 = num;
				num = (short)608446626;
				switch (num2 == num)
				{
				}
				num = (short)893452288;
				short num3 = num;
				num = (short)734527489;
				if (num != 0)
				{
				}
				num = (short)1157365760;
				if (num != 0)
				{
				}
				this.<FeaturesExchangeData>k__BackingField = value;
			}
		}

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06000AF7 RID: 2807 RVA: 0x00076278 File Offset: 0x00074478
		// (set) Token: 0x06000AF8 RID: 2808 RVA: 0x00076328 File Offset: 0x00074528
		[global::System.Runtime.Serialization.DataMember]
		public string FeaturesExchangeDataEncrypt
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)728337293;
				short num2 = num;
				num = (short)1806732173;
				switch (num2 == num)
				{
				}
				num = (short)1049952256;
				short num3 = num;
				num = (short)353763328;
				if (num != 0)
				{
				}
				num = (short)2039611393;
				if (num != 0)
				{
				}
				return this.<FeaturesExchangeDataEncrypt>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)998343809;
				short num2 = num;
				num = (short)248546433;
				switch (num2 == num)
				{
				}
				num = (short)1736245248;
				short num3 = num;
				num = (short)252641280;
				if (num != 0)
				{
				}
				num = (short)147456001;
				if (num != 0)
				{
				}
				this.<FeaturesExchangeDataEncrypt>k__BackingField = value;
			}
		}

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06000AF9 RID: 2809 RVA: 0x000763D8 File Offset: 0x000745D8
		// (set) Token: 0x06000AFA RID: 2810 RVA: 0x00076484 File Offset: 0x00074684
		[global::System.Runtime.Serialization.DataMember]
		public int? MaxAttemptsInJob
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1945469573;
				short num2 = num;
				num = (short)1280541317;
				switch (num2 == num)
				{
				}
				num = (short)1809580032;
				short num3 = num;
				num = (short)959905793;
				if (num != 0)
				{
				}
				num = (short)1143144448;
				if (num != 0)
				{
				}
				return this.<MaxAttemptsInJob>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1439555305;
				short num2 = num;
				num = (short)1513348841;
				switch (num2 == num)
				{
				}
				num = (short)2144993280;
				short num3 = num;
				num = (short)720371712;
				if (num != 0)
				{
				}
				num = (short)406978561;
				if (num != 0)
				{
				}
				this.<MaxAttemptsInJob>k__BackingField = value;
			}
		}

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06000AFB RID: 2811 RVA: 0x00076534 File Offset: 0x00074734
		// (set) Token: 0x06000AFC RID: 2812 RVA: 0x000765E0 File Offset: 0x000747E0
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? RelatedWriteNoSwitchOverJobUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1368139304;
				short num2 = num;
				num = (short)186328616;
				switch (num2 == num)
				{
				}
				num = (short)1168834560;
				short num3 = num;
				num = (short)1118175233;
				if (num != 0)
				{
				}
				num = (short)1187446784;
				if (num != 0)
				{
				}
				return this.<RelatedWriteNoSwitchOverJobUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)237738475;
				short num2 = num;
				num = (short)1564121579;
				switch (num2 == num)
				{
				}
				num = (short)263847936;
				short num3 = num;
				num = (short)1543176193;
				if (num != 0)
				{
				}
				num = (short)1646395392;
				if (num != 0)
				{
				}
				this.<RelatedWriteNoSwitchOverJobUuid>k__BackingField = value;
			}
		}

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06000AFD RID: 2813 RVA: 0x00076690 File Offset: 0x00074890
		// (set) Token: 0x06000AFE RID: 2814 RVA: 0x00076740 File Offset: 0x00074940
		[global::System.Runtime.Serialization.DataMember]
		public global::System.DateTime? ScheduleStartDate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)474844301;
				short num2 = num;
				num = (short)1150913677;
				switch (num2 == num)
				{
				}
				num = (short)1352073216;
				short num3 = num;
				num = (short)189399040;
				if (num != 0)
				{
				}
				num = (short)9306113;
				if (num != 0)
				{
				}
				return this.<ScheduleStartDate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)928084307;
				short num2 = num;
				num = (short)1307144531;
				switch (num2 == num)
				{
				}
				num = (short)1282211840;
				short num3 = num;
				num = (short)505020417;
				if (num != 0)
				{
				}
				num = (short)1284767744;
				if (num != 0)
				{
				}
				this.<ScheduleStartDate>k__BackingField = value;
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06000AFF RID: 2815 RVA: 0x000767F4 File Offset: 0x000749F4
		// (set) Token: 0x06000B00 RID: 2816 RVA: 0x000768A4 File Offset: 0x00074AA4
		[global::System.Runtime.Serialization.DataMember]
		public global::System.DateTime? ScheduleEndDate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1980366864;
				short num2 = num;
				num = (short)1166082064;
				switch (num2 == num)
				{
				}
				num = (short)1204092928;
				short num3 = num;
				num = (short)2123956225;
				if (num != 0)
				{
				}
				num = (short)401670144;
				if (num != 0)
				{
				}
				return this.<ScheduleEndDate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)532222233;
				short num2 = num;
				num = (short)1075253529;
				switch (num2 == num)
				{
				}
				num = (short)1746927616;
				short num3 = num;
				num = (short)839843841;
				if (num != 0)
				{
				}
				num = (short)988020736;
				if (num != 0)
				{
				}
				this.<ScheduleEndDate>k__BackingField = value;
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06000B01 RID: 2817 RVA: 0x00076954 File Offset: 0x00074B54
		// (set) Token: 0x06000B02 RID: 2818 RVA: 0x00076A04 File Offset: 0x00074C04
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ImportOption? ReadRadioOption
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2104286709;
				short num2 = num;
				num = (short)1153818101;
				switch (num2 == num)
				{
				}
				num = (short)1367736320;
				short num3 = num;
				num = (short)2038431745;
				if (num != 0)
				{
				}
				num = (short)19333120;
				if (num != 0)
				{
				}
				return this.<ReadRadioOption>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)809034034;
				short num2 = num;
				num = (short)198172978;
				switch (num2 == num)
				{
				}
				num = (short)38731776;
				short num3 = num;
				num = (short)775356417;
				if (num != 0)
				{
				}
				num = (short)349306880;
				if (num != 0)
				{
				}
				this.<ReadRadioOption>k__BackingField = value;
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06000B03 RID: 2819 RVA: 0x00076AB8 File Offset: 0x00074CB8
		// (set) Token: 0x06000B04 RID: 2820 RVA: 0x00076B68 File Offset: 0x00074D68
		[global::System.Runtime.Serialization.DataMember]
		public string JobName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1566690278;
				short num2 = num;
				num = (short)494390246;
				switch (num2 == num)
				{
				}
				num = (short)1412628480;
				short num3 = num;
				num = (short)884080641;
				if (num != 0)
				{
				}
				num = (short)1025966080;
				if (num != 0)
				{
				}
				return this.<JobName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1243829009;
				short num2 = num;
				num = (short)972706577;
				switch (num2 == num)
				{
				}
				num = (short)507183104;
				short num3 = num;
				num = (short)501940225;
				if (num != 0)
				{
				}
				num = (short)1785069568;
				if (num != 0)
				{
				}
				this.<JobName>k__BackingField = value;
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x00076C18 File Offset: 0x00074E18
		// (set) Token: 0x06000B06 RID: 2822 RVA: 0x00076CC4 File Offset: 0x00074EC4
		[global::System.Runtime.Serialization.DataMember]
		public bool IsRestoreJob
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)888833779;
				short num2 = num;
				num = (short)769361651;
				switch (num2 == num)
				{
				}
				num = (short)573308928;
				short num3 = num;
				num = (short)731906049;
				if (num != 0)
				{
				}
				num = (short)1388052480;
				if (num != 0)
				{
				}
				return this.<IsRestoreJob>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)207344120;
				short num2 = num;
				num = (short)951439864;
				switch (num2 == num)
				{
				}
				num = (short)1907884032;
				short num3 = num;
				num = (short)1880817665;
				if (num != 0)
				{
				}
				num = (short)971243520;
				if (num != 0)
				{
				}
				this.<IsRestoreJob>k__BackingField = value;
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x00076D74 File Offset: 0x00074F74
		// (set) Token: 0x06000B08 RID: 2824 RVA: 0x00076E24 File Offset: 0x00075024
		[global::System.Runtime.Serialization.DataMember]
		public string PCRKeysIdAndValue
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)53614232;
				short num2 = num;
				num = (short)1061361304;
				switch (num2 == num)
				{
				}
				num = (short)1625096192;
				short num3 = num;
				num = (short)1537736705;
				if (num != 0)
				{
				}
				num = (short)1570111488;
				if (num != 0)
				{
				}
				return this.<PCRKeysIdAndValue>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1010531877;
				short num2 = num;
				num = (short)1132166693;
				switch (num2 == num)
				{
				}
				num = (short)1300103168;
				short num3 = num;
				num = (short)1132527617;
				if (num != 0)
				{
				}
				num = (short)1272119296;
				if (num != 0)
				{
				}
				this.<PCRKeysIdAndValue>k__BackingField = value;
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06000B09 RID: 2825 RVA: 0x00076ED4 File Offset: 0x000750D4
		// (set) Token: 0x06000B0A RID: 2826 RVA: 0x00076F88 File Offset: 0x00075188
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid OldTemplateUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)693980996;
				short num2 = num;
				num = (short)2098220868;
				switch (num2 == num)
				{
				}
				num = (short)946995200;
				short num3 = num;
				num = (short)1461321728;
				if (num != 0)
				{
				}
				num = (short)118161409;
				if (num != 0)
				{
				}
				return this.<OldTemplateUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)733883970;
				short num2 = num;
				num = (short)96939586;
				switch (num2 == num)
				{
				}
				num = (short)1634926592;
				short num3 = num;
				num = (short)1138491393;
				if (num != 0)
				{
				}
				num = (short)216072192;
				if (num != 0)
				{
				}
				this.<OldTemplateUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x0007703C File Offset: 0x0007523C
		// (set) Token: 0x06000B0C RID: 2828 RVA: 0x000770EC File Offset: 0x000752EC
		[global::System.Runtime.Serialization.DataMember]
		public string OldTemplateName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)920795321;
				short num2 = num;
				num = (short)1379940537;
				switch (num2 == num)
				{
				}
				num = (short)927268864;
				short num3 = num;
				num = (short)1163132929;
				if (num != 0)
				{
				}
				num = (short)2092302336;
				if (num != 0)
				{
				}
				return this.<OldTemplateName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)208699227;
				short num2 = num;
				num = (short)511999835;
				switch (num2 == num)
				{
				}
				num = (short)1362231296;
				short num3 = num;
				num = (short)907411456;
				if (num != 0)
				{
				}
				num = (short)1167065089;
				if (num != 0)
				{
				}
				this.<OldTemplateName>k__BackingField = value;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x0007719C File Offset: 0x0007539C
		// (set) Token: 0x06000B0E RID: 2830 RVA: 0x0007724C File Offset: 0x0007544C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? ConvertionConfigurationUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)578224129;
				if (num != 0)
				{
				}
				num = (short)954214695;
				short num2 = num;
				num = (short)2049386791;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1824718848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)488112128;
				if (num != 0)
				{
				}
				return this.<ConvertionConfigurationUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1205272577;
				if (num != 0)
				{
				}
				num = (short)1294833950;
				short num2 = num;
				num = (short)555915550;
				switch (num2 == num)
				{
				default:
				{
					num = (short)630718464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1666449408;
				if (num != 0)
				{
				}
				this.<ConvertionConfigurationUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x000772FC File Offset: 0x000754FC
		// (set) Token: 0x06000B10 RID: 2832 RVA: 0x000773B0 File Offset: 0x000755B0
		[global::System.Runtime.Serialization.DataMember]
		public global::System.DateTime? JobStatusUpdateTime
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1995503651;
				short num2 = num;
				num = (short)890763299;
				switch (num2 == num)
				{
				}
				num = (short)32178176;
				short num3 = num;
				num = (short)2023424001;
				if (num != 0)
				{
				}
				num = (short)588447744;
				if (num != 0)
				{
				}
				return this.<JobStatusUpdateTime>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1395806742;
				short num2 = num;
				num = (short)612454934;
				switch (num2 == num)
				{
				}
				num = (short)1693908992;
				short num3 = num;
				num = (short)1898250241;
				if (num != 0)
				{
				}
				num = (short)246546432;
				if (num != 0)
				{
				}
				this.<JobStatusUpdateTime>k__BackingField = value;
			}
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x00077464 File Offset: 0x00075664
		// (set) Token: 0x06000B12 RID: 2834 RVA: 0x00077510 File Offset: 0x00075710
		[global::System.Runtime.Serialization.DataMember]
		public bool? AutoRevertRunningToPending
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)864955138;
				short num2 = num;
				num = (short)1470966530;
				switch (num2 == num)
				{
				}
				num = (short)1029439488;
				short num3 = num;
				num = (short)842465281;
				if (num != 0)
				{
				}
				num = (short)312016896;
				if (num != 0)
				{
				}
				return this.<AutoRevertRunningToPending>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1140839707;
				short num2 = num;
				num = (short)932435227;
				switch (num2 == num)
				{
				}
				num = (short)1780482048;
				short num3 = num;
				num = (short)1729757185;
				if (num != 0)
				{
				}
				num = (short)1016659968;
				if (num != 0)
				{
				}
				this.<AutoRevertRunningToPending>k__BackingField = value;
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x000775C0 File Offset: 0x000757C0
		// (set) Token: 0x06000B14 RID: 2836 RVA: 0x00077670 File Offset: 0x00075870
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::Motorola.CommonCPS.Server.EntityModel.Codeplug Codeplug
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1955740983;
				short num2 = num;
				num = (short)5979447;
				switch (num2 == num)
				{
				}
				num = (short)689111040;
				short num3 = num;
				num = (short)1685782529;
				if (num != 0)
				{
				}
				num = (short)1121845248;
				if (num != 0)
				{
				}
				return this.<Codeplug>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)101021749;
				short num2 = num;
				num = (short)352745525;
				switch (num2 == num)
				{
				}
				num = (short)1564606464;
				short num3 = num;
				num = (short)213712897;
				if (num != 0)
				{
				}
				num = (short)1934295040;
				if (num != 0)
				{
				}
				this.<Codeplug>k__BackingField = value;
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x00077720 File Offset: 0x00075920
		// (set) Token: 0x06000B16 RID: 2838 RVA: 0x000777D0 File Offset: 0x000759D0
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::Motorola.CommonCPS.Server.EntityModel.Radio Radio
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2139019543;
				short num2 = num;
				num = (short)1184618775;
				switch (num2 == num)
				{
				}
				num = (short)724434944;
				short num3 = num;
				num = (short)1727856641;
				if (num != 0)
				{
				}
				num = (short)1938685952;
				if (num != 0)
				{
				}
				return this.<Radio>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1357773135;
				short num2 = num;
				num = (short)668793167;
				switch (num2 == num)
				{
				}
				num = (short)282394624;
				short num3 = num;
				num = (short)1093861377;
				if (num != 0)
				{
				}
				num = (short)152043520;
				if (num != 0)
				{
				}
				this.<Radio>k__BackingField = value;
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x00077880 File Offset: 0x00075A80
		// (set) Token: 0x06000B18 RID: 2840 RVA: 0x00077934 File Offset: 0x00075B34
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Task> Tasks
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)160058116;
				short num2 = num;
				num = (short)1924156164;
				switch (num2 == num)
				{
				}
				num = (short)580321280;
				short num3 = num;
				num = (short)846004225;
				if (num != 0)
				{
				}
				num = (short)1840447488;
				if (num != 0)
				{
				}
				return this.<Tasks>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)152452506;
				short num2 = num;
				num = (short)981155226;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1698234368;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1637482496;
				if (num != 0)
				{
				}
				num = (short)66519041;
				if (num != 0)
				{
				}
				this.<Tasks>k__BackingField = value;
			}
		}

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x000779E4 File Offset: 0x00075BE4
		// (set) Token: 0x06000B1A RID: 2842 RVA: 0x00077A98 File Offset: 0x00075C98
		[global::System.Runtime.Serialization.DataMember]
		public bool? IsSROJob
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1800707698;
				short num2 = num;
				num = (short)1491902066;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1893662720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1587806209;
				if (num != 0)
				{
				}
				num = (short)1930035200;
				if (num != 0)
				{
				}
				return this.<IsSROJob>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)64508711;
				short num2 = num;
				num = (short)46289703;
				switch (num2 == num)
				{
				default:
				{
					num = (short)698679296;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)368508929;
				if (num != 0)
				{
				}
				num = (short)718733312;
				if (num != 0)
				{
				}
				this.<IsSROJob>k__BackingField = value;
			}
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x00077B48 File Offset: 0x00075D48
		// (set) Token: 0x06000B1C RID: 2844 RVA: 0x00077BF8 File Offset: 0x00075DF8
		[global::System.Runtime.Serialization.DataMember]
		public string HostName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)498004369;
				short num2 = num;
				num = (short)615313809;
				switch (num2 == num)
				{
				default:
				{
					num = (short)374800384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1313210368;
				if (num != 0)
				{
				}
				num = (short)429522945;
				if (num != 0)
				{
				}
				return this.<HostName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)90545144;
				short num2 = num;
				num = (short)1351064568;
				switch (num2 == num)
				{
				default:
				{
					num = (short)853868544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1900478464;
				if (num != 0)
				{
				}
				num = (short)1302593537;
				if (num != 0)
				{
				}
				this.<HostName>k__BackingField = value;
			}
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x00077CA8 File Offset: 0x00075EA8
		// (set) Token: 0x06000B1E RID: 2846 RVA: 0x00077D58 File Offset: 0x00075F58
		[global::System.Runtime.Serialization.DataMember]
		public int? UserDefersAllowed
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2009770664;
				short num2 = num;
				num = (short)1007921832;
				switch (num2 == num)
				{
				default:
				{
					num = (short)999555072;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)45416449;
				if (num != 0)
				{
				}
				num = (short)1281490944;
				if (num != 0)
				{
				}
				return this.<UserDefersAllowed>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1740797281;
				short num2 = num;
				num = (short)828339553;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1052966912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)730136576;
				if (num != 0)
				{
				}
				num = (short)1374093313;
				if (num != 0)
				{
				}
				this.<UserDefersAllowed>k__BackingField = value;
			}
		}

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x00077E04 File Offset: 0x00076004
		// (set) Token: 0x06000B20 RID: 2848 RVA: 0x00077EB8 File Offset: 0x000760B8
		public bool? IsFwdlTalkgroupXcmpCompleted
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)143748012;
				short num2 = num;
				num = (short)880962476;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1406730240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)220856321;
				if (num != 0)
				{
				}
				num = (short)1999962112;
				if (num != 0)
				{
				}
				return this.<IsFwdlTalkgroupXcmpCompleted>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1955385061;
				short num2 = num;
				num = (short)434097893;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2018770944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1321992192;
				if (num != 0)
				{
				}
				num = (short)948109313;
				if (num != 0)
				{
				}
				this.<IsFwdlTalkgroupXcmpCompleted>k__BackingField = value;
			}
		}

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x00077F68 File Offset: 0x00076168
		// (set) Token: 0x06000B22 RID: 2850 RVA: 0x00078014 File Offset: 0x00076214
		[global::System.Runtime.Serialization.DataMember]
		public bool? IsFwdlCodeplugWriteCompleted
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1553442118;
				short num2 = num;
				num = (short)1469424966;
				switch (num2 == num)
				{
				default:
				{
					num = (short)609550336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)824377345;
				if (num != 0)
				{
				}
				num = (short)1281425408;
				if (num != 0)
				{
				}
				return this.<IsFwdlCodeplugWriteCompleted>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)619376659;
				short num2 = num;
				num = (short)1250816019;
				switch (num2 == num)
				{
				default:
				{
					num = (short)744292352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1877475329;
				if (num != 0)
				{
				}
				num = (short)1252196352;
				if (num != 0)
				{
				}
				this.<IsFwdlCodeplugWriteCompleted>k__BackingField = value;
			}
		}

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06000B23 RID: 2851 RVA: 0x000780C4 File Offset: 0x000762C4
		// (set) Token: 0x06000B24 RID: 2852 RVA: 0x00078174 File Offset: 0x00076374
		[global::System.Runtime.Serialization.DataMember]
		public int? FwdlDownloadProgress
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1670186144;
				short num2 = num;
				num = (short)412615840;
				switch (num2 == num)
				{
				default:
				{
					num = (short)138543104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1261371393;
				if (num != 0)
				{
				}
				num = (short)1926955008;
				if (num != 0)
				{
				}
				return this.<FwdlDownloadProgress>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1978509634;
				short num2 = num;
				num = (short)1074899266;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1283129344;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)924581888;
				if (num != 0)
				{
				}
				num = (short)103153665;
				if (num != 0)
				{
				}
				this.<FwdlDownloadProgress>k__BackingField = value;
			}
		}

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06000B25 RID: 2853 RVA: 0x00078224 File Offset: 0x00076424
		// (set) Token: 0x06000B26 RID: 2854 RVA: 0x000782D0 File Offset: 0x000764D0
		[global::System.Runtime.Serialization.DataMember]
		public int? GroupDataJobId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1976859628;
				short num2 = num;
				num = (short)760708076;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2008743936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)996737024;
				if (num != 0)
				{
				}
				num = (short)524877825;
				if (num != 0)
				{
				}
				return this.<GroupDataJobId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)617740436;
				short num2 = num;
				num = (short)387578004;
				switch (num2 == num)
				{
				default:
				{
					num = (short)526909440;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)648413185;
				if (num != 0)
				{
				}
				num = (short)1391198208;
				if (num != 0)
				{
				}
				this.<GroupDataJobId>k__BackingField = value;
			}
		}

		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06000B27 RID: 2855 RVA: 0x00078380 File Offset: 0x00076580
		// (set) Token: 0x06000B28 RID: 2856 RVA: 0x00078430 File Offset: 0x00076630
		[global::System.Runtime.Serialization.DataMember]
		public int? DataGroupRadioAssignmentID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1329064214;
				short num2 = num;
				num = (short)1513744662;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1268645888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)75563009;
				if (num != 0)
				{
				}
				num = (short)201195520;
				if (num != 0)
				{
				}
				return this.<DataGroupRadioAssignmentID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1450659901;
				short num2 = num;
				num = (short)626937917;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1597964288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2053636096;
				if (num != 0)
				{
				}
				num = (short)390922241;
				if (num != 0)
				{
				}
				this.<DataGroupRadioAssignmentID>k__BackingField = value;
			}
		}

		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x06000B29 RID: 2857 RVA: 0x000784E0 File Offset: 0x000766E0
		// (set) Token: 0x06000B2A RID: 2858 RVA: 0x00078590 File Offset: 0x00076790
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? FwdlRevertCodeplugFileUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1892514696;
				short num2 = num;
				num = (short)2063170440;
				switch (num2 == num)
				{
				default:
				{
					num = (short)896139264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1898577921;
				if (num != 0)
				{
				}
				num = (short)1770127360;
				if (num != 0)
				{
				}
				return this.<FwdlRevertCodeplugFileUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1789283650;
				short num2 = num;
				num = (short)1751141698;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1040646144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)847118336;
				if (num != 0)
				{
				}
				num = (short)1299775489;
				if (num != 0)
				{
				}
				this.<FwdlRevertCodeplugFileUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x0007863C File Offset: 0x0007683C
		// (set) Token: 0x06000B2C RID: 2860 RVA: 0x000786F0 File Offset: 0x000768F0
		[global::System.Runtime.Serialization.DataMember]
		public int? FwdlRevertSessionId
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)268627899;
				short num2 = num;
				num = (short)117632955;
				switch (num2 == num)
				{
				default:
				{
					num = (short)237502464;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)111083520;
				if (num != 0)
				{
				}
				num = (short)787218433;
				if (num != 0)
				{
				}
				return this.<FwdlRevertSessionId>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1188618511;
				short num2 = num;
				num = (short)1936384271;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1498939392;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)552730625;
				if (num != 0)
				{
				}
				num = (short)59703296;
				if (num != 0)
				{
				}
				this.<FwdlRevertSessionId>k__BackingField = value;
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06000B2D RID: 2861 RVA: 0x000787A0 File Offset: 0x000769A0
		// (set) Token: 0x06000B2E RID: 2862 RVA: 0x00078854 File Offset: 0x00076A54
		[global::System.Runtime.Serialization.DataMember]
		public int? FwdlFirmwareFlavorType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)519565289;
				short num2 = num;
				num = (short)527626217;
				switch (num2 == num)
				{
				default:
				{
					num = (short)488570880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1854865408;
				if (num != 0)
				{
				}
				num = (short)49741825;
				if (num != 0)
				{
				}
				return this.<FwdlFirmwareFlavorType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1119751218;
				short num2 = num;
				num = (short)883035186;
				switch (num2 == num)
				{
				default:
				{
					num = (short)470810624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1709244416;
				if (num != 0)
				{
				}
				num = (short)1971191809;
				if (num != 0)
				{
				}
				this.<FwdlFirmwareFlavorType>k__BackingField = value;
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06000B2F RID: 2863 RVA: 0x00078908 File Offset: 0x00076B08
		// (set) Token: 0x06000B30 RID: 2864 RVA: 0x000789B8 File Offset: 0x00076BB8
		[global::System.Runtime.Serialization.DataMember]
		public int? FwdLanguagePack
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)713251674;
				short num2 = num;
				num = (short)2098158426;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1539112960;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1211170816;
				if (num != 0)
				{
				}
				num = (short)1357316097;
				if (num != 0)
				{
				}
				return this.<FwdLanguagePack>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1696983399;
				short num2 = num;
				num = (short)1230891367;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2014117888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)266928129;
				if (num != 0)
				{
				}
				num = (short)110166016;
				if (num != 0)
				{
				}
				this.<FwdLanguagePack>k__BackingField = value;
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x00078A68 File Offset: 0x00076C68
		// (set) Token: 0x06000B32 RID: 2866 RVA: 0x00078B18 File Offset: 0x00076D18
		[global::System.Runtime.Serialization.DataMember]
		public string FwdLanguagePackVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1266542277;
				short num2 = num;
				num = (short)842393285;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1361248256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)787349505;
				if (num != 0)
				{
				}
				num = (short)984219648;
				if (num != 0)
				{
				}
				return this.<FwdLanguagePackVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)324534273;
				if (num != 0)
				{
				}
				num = (short)1104347136;
				short num2 = num;
				num = (short)1840108562;
				short num3 = num;
				num = (short)125948946;
				switch (num3 == num)
				{
				}
				num = (short)70189056;
				if (num != 0)
				{
				}
				this.<FwdLanguagePackVersion>k__BackingField = value;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x00078BC8 File Offset: 0x00076DC8
		// (set) Token: 0x06000B34 RID: 2868 RVA: 0x00078C78 File Offset: 0x00076E78
		[global::System.Runtime.Serialization.DataMember]
		public byte[] PasswordResetFileContent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)318177281;
				if (num != 0)
				{
				}
				num = (short)719126528;
				short num2 = num;
				num = (short)619605736;
				short num3 = num;
				num = (short)1090744040;
				switch (num3 == num)
				{
				}
				num = (short)1459552256;
				if (num != 0)
				{
				}
				return this.<PasswordResetFileContent>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)701216626;
				short num2 = num;
				num = (short)820164466;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1636892672;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2091646977;
				if (num != 0)
				{
				}
				num = (short)2114912256;
				if (num != 0)
				{
				}
				this.<PasswordResetFileContent>k__BackingField = value;
			}
		}

		// Token: 0x04000530 RID: 1328
		public const int DefaultUserDefersValue = -1;
	}
}
