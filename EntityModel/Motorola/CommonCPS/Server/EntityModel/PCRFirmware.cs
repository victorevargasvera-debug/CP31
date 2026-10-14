using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.EntityModel.DefineAttributes;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200007E RID: 126
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class PCRFirmware : global::Motorola.CommonCPS.Server.EntityModel.PCRPackage
	{
		// Token: 0x06000986 RID: 2438 RVA: 0x00066ED8 File Offset: 0x000650D8
		public PCRFirmware()
		{
			this.PCRFirmwareCodeplugPairs = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPair>();
			this.PCRFirmwareSubs = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareSub>();
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x00066F04 File Offset: 0x00065104
		// (set) Token: 0x06000988 RID: 2440 RVA: 0x00066FB4 File Offset: 0x000651B4
		[global::System.Runtime.Serialization.DataMember]
		public string PackageName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2129592321;
				if (num != 0)
				{
				}
				num = (short)484210574;
				short num2 = num;
				num = (short)214464398;
				switch (num2 == num)
				{
				}
				num = (short)1385168896;
				short num3 = num;
				num = (short)1113653248;
				if (num != 0)
				{
				}
				return this.<PackageName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)757497832;
				short num2 = num;
				num = (short)1916829672;
				switch (num2 == num)
				{
				}
				num = (short)1105330177;
				if (num != 0)
				{
				}
				num = (short)1286144000;
				short num3 = num;
				num = (short)370147328;
				if (num != 0)
				{
				}
				this.<PackageName>k__BackingField = value;
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x06000989 RID: 2441 RVA: 0x00067068 File Offset: 0x00065268
		// (set) Token: 0x0600098A RID: 2442 RVA: 0x00067118 File Offset: 0x00065318
		[global::System.Runtime.Serialization.DataMember]
		public string PackageVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)101735890;
				short num2 = num;
				num = (short)1906859474;
				switch (num2 == num)
				{
				}
				num = (short)557121537;
				if (num != 0)
				{
				}
				num = (short)566624256;
				short num3 = num;
				num = (short)1096810496;
				if (num != 0)
				{
				}
				return this.<PackageVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2036676540;
				short num2 = num;
				num = (short)334378940;
				switch (num2 == num)
				{
				}
				num = (short)212271105;
				if (num != 0)
				{
				}
				num = (short)1853685760;
				short num3 = num;
				num = (short)1349451776;
				if (num != 0)
				{
				}
				this.<PackageVersion>k__BackingField = value;
			}
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x0600098B RID: 2443 RVA: 0x000671C8 File Offset: 0x000653C8
		// (set) Token: 0x0600098C RID: 2444 RVA: 0x00067278 File Offset: 0x00065478
		[global::System.Runtime.Serialization.DataMember]
		public string PackageDescription
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)854682003;
				short num2 = num;
				num = (short)1288006035;
				switch (num2 == num)
				{
				}
				num = (short)2105999361;
				if (num != 0)
				{
				}
				num = (short)2120548352;
				short num3 = num;
				num = (short)1799290880;
				if (num != 0)
				{
				}
				return this.<PackageDescription>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1541376919;
				short num2 = num;
				num = (short)845581207;
				switch (num2 == num)
				{
				}
				num = (short)152174593;
				if (num != 0)
				{
				}
				num = (short)1495203840;
				short num3 = num;
				num = (short)27131904;
				if (num != 0)
				{
				}
				this.<PackageDescription>k__BackingField = value;
			}
		}

		// Token: 0x1700047C RID: 1148
		// (get) Token: 0x0600098D RID: 2445 RVA: 0x00067328 File Offset: 0x00065528
		// (set) Token: 0x0600098E RID: 2446 RVA: 0x000673D8 File Offset: 0x000655D8
		[global::System.Runtime.Serialization.DataMember]
		public bool? IsUpdating
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)772351613;
				short num2 = num;
				num = (short)616244861;
				switch (num2 == num)
				{
				}
				num = (short)606666752;
				if (num != 0)
				{
				}
				num = (short)841089024;
				short num3 = num;
				num = (short)894959617;
				if (num != 0)
				{
				}
				return this.<IsUpdating>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1518459910;
				short num2 = num;
				num = (short)1917836294;
				switch (num2 == num)
				{
				}
				num = (short)138084353;
				if (num != 0)
				{
				}
				num = (short)1490747392;
				short num3 = num;
				num = (short)762707968;
				if (num != 0)
				{
				}
				this.<IsUpdating>k__BackingField = value;
			}
		}

		// Token: 0x1700047D RID: 1149
		// (get) Token: 0x0600098F RID: 2447 RVA: 0x00067488 File Offset: 0x00065688
		// (set) Token: 0x06000990 RID: 2448 RVA: 0x00067538 File Offset: 0x00065738
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPair> PCRFirmwareCodeplugPairs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1319841543;
				short num2 = num;
				num = (short)773730055;
				switch (num2 == num)
				{
				}
				num = (short)1422655488;
				if (num != 0)
				{
				}
				num = (short)1677524992;
				short num3 = num;
				num = (short)281870337;
				if (num != 0)
				{
				}
				return this.<PCRFirmwareCodeplugPairs>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)897318913;
				if (num != 0)
				{
				}
				num = (short)1752879913;
				short num2 = num;
				num = (short)617206569;
				switch (num2 == num)
				{
				}
				num = (short)466812928;
				short num3 = num;
				num = (short)1971847168;
				if (num != 0)
				{
				}
				this.<PCRFirmwareCodeplugPairs>k__BackingField = value;
			}
		}

		// Token: 0x1700047E RID: 1150
		// (get) Token: 0x06000991 RID: 2449 RVA: 0x000675E8 File Offset: 0x000657E8
		// (set) Token: 0x06000992 RID: 2450 RVA: 0x00067698 File Offset: 0x00065898
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareSub> PCRFirmwareSubs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1555188260;
				short num2 = num;
				num = (short)493308452;
				switch (num2 == num)
				{
				}
				num = (short)3866624;
				if (num != 0)
				{
				}
				num = (short)694550528;
				short num3 = num;
				num = (short)1000865793;
				if (num != 0)
				{
				}
				return this.<PCRFirmwareSubs>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)431978708;
				short num2 = num;
				num = (short)333478100;
				switch (num2 == num)
				{
				}
				num = (short)207224832;
				if (num != 0)
				{
				}
				num = (short)937426944;
				short num3 = num;
				num = (short)150274049;
				if (num != 0)
				{
				}
				this.<PCRFirmwareSubs>k__BackingField = value;
			}
		}

		// Token: 0x1700047F RID: 1151
		// (get) Token: 0x06000993 RID: 2451 RVA: 0x00067748 File Offset: 0x00065948
		// (set) Token: 0x06000994 RID: 2452 RVA: 0x000677F8 File Offset: 0x000659F8
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.EntityModel.DefineAttributes.a]
		public byte? RDate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)177405953;
				if (num != 0)
				{
				}
				num = (short)730326299;
				short num2 = num;
				num = (short)295429403;
				switch (num2 == num)
				{
				}
				num = (short)1781596160;
				short num3 = num;
				num = (short)1672216576;
				if (num != 0)
				{
				}
				return this.<RDate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1195114497;
				if (num != 0)
				{
				}
				num = (short)1565727758;
				short num2 = num;
				num = (short)1659051022;
				switch (num2 == num)
				{
				}
				num = (short)311951360;
				if (num != 0)
				{
				}
				num = (short)401801216;
				short num3 = num;
				this.<RDate>k__BackingField = value;
			}
		}
	}
}
