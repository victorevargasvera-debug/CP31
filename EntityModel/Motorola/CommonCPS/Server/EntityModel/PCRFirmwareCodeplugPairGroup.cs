using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000080 RID: 128
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class PCRFirmwareCodeplugPairGroup : global::Motorola.CommonCPS.Server.EntityModel.PCRPackage
	{
		// Token: 0x060009A4 RID: 2468 RVA: 0x00068260 File Offset: 0x00066460
		public PCRFirmwareCodeplugPairGroup()
		{
			this.PCRFirmwareCodeplugPairs = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPair>();
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x00068280 File Offset: 0x00066480
		// (set) Token: 0x060009A6 RID: 2470 RVA: 0x00068330 File Offset: 0x00066530
		[global::System.Runtime.Serialization.DataMember]
		public string PackageName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1138229249;
				if (num != 0)
				{
				}
				num = (short)1198544074;
				short num2 = num;
				num = (short)32003274;
				switch (num2 == num)
				{
				}
				num = (short)694026240;
				if (num != 0)
				{
				}
				num = (short)270794752;
				short num3 = num;
				return this.<PackageName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1114307233;
				short num2 = num;
				num = (short)1195309729;
				switch (num2 == num)
				{
				}
				num = (short)2109865985;
				if (num != 0)
				{
				}
				num = (short)1354629120;
				if (num != 0)
				{
				}
				num = (short)1055064064;
				short num3 = num;
				this.<PackageName>k__BackingField = value;
			}
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x060009A7 RID: 2471 RVA: 0x000683E4 File Offset: 0x000665E4
		// (set) Token: 0x060009A8 RID: 2472 RVA: 0x00068494 File Offset: 0x00066694
		[global::System.Runtime.Serialization.DataMember]
		public string FirmwareVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1640664155;
				short num2 = num;
				num = (short)865242203;
				switch (num2 == num)
				{
				}
				num = (short)1587740673;
				if (num != 0)
				{
				}
				num = (short)1466171392;
				if (num != 0)
				{
				}
				num = (short)2099838976;
				short num3 = num;
				return this.<FirmwareVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)395040071;
				short num2 = num;
				num = (short)1659163975;
				switch (num2 == num)
				{
				}
				num = (short)1306329088;
				if (num != 0)
				{
				}
				num = (short)1557463041;
				if (num != 0)
				{
				}
				num = (short)744095744;
				short num3 = num;
				this.<FirmwareVersion>k__BackingField = value;
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x060009A9 RID: 2473 RVA: 0x00068540 File Offset: 0x00066740
		// (set) Token: 0x060009AA RID: 2474 RVA: 0x000685F0 File Offset: 0x000667F0
		[global::System.Runtime.Serialization.DataMember]
		public string CodeplugVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)431198314;
				short num2 = num;
				num = (short)1109692522;
				switch (num2 == num)
				{
				}
				num = (short)1739718657;
				if (num != 0)
				{
				}
				num = (short)709099520;
				if (num != 0)
				{
				}
				num = (short)2031616000;
				short num3 = num;
				return this.<CodeplugVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)750976194;
				short num2 = num;
				num = (short)801373378;
				switch (num2 == num)
				{
				}
				num = (short)1923088385;
				if (num != 0)
				{
				}
				num = (short)243466240;
				if (num != 0)
				{
				}
				num = (short)1037500416;
				short num3 = num;
				this.<CodeplugVersion>k__BackingField = value;
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x060009AB RID: 2475 RVA: 0x000686A4 File Offset: 0x000668A4
		// (set) Token: 0x060009AC RID: 2476 RVA: 0x00068754 File Offset: 0x00066954
		[global::System.Runtime.Serialization.DataMember]
		public int? Region
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)61954549;
				short num2 = num;
				num = (short)310073845;
				switch (num2 == num)
				{
				}
				num = (short)168558593;
				if (num != 0)
				{
				}
				num = (short)843579392;
				if (num != 0)
				{
				}
				num = (short)1862270976;
				short num3 = num;
				return this.<Region>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1749675858;
				short num2 = num;
				num = (short)1354559314;
				switch (num2 == num)
				{
				}
				num = (short)1334968320;
				if (num != 0)
				{
				}
				num = (short)1961361409;
				if (num != 0)
				{
				}
				num = (short)1225457664;
				short num3 = num;
				this.<Region>k__BackingField = value;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x060009AD RID: 2477 RVA: 0x00068804 File Offset: 0x00066A04
		// (set) Token: 0x060009AE RID: 2478 RVA: 0x000688B4 File Offset: 0x00066AB4
		[global::System.Runtime.Serialization.DataMember]
		public string Size
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1097289270;
				short num2 = num;
				num = (short)1490701878;
				switch (num2 == num)
				{
				}
				num = (short)1027014657;
				if (num != 0)
				{
				}
				num = (short)1461125120;
				if (num != 0)
				{
				}
				num = (short)1991573504;
				short num3 = num;
				return this.<Size>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1925120001;
				if (num != 0)
				{
				}
				num = (short)1305300830;
				short num2 = num;
				num = (short)1498369886;
				switch (num2 == num)
				{
				}
				num = (short)1803157504;
				if (num != 0)
				{
				}
				num = (short)906428416;
				short num3 = num;
				this.<Size>k__BackingField = value;
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x060009AF RID: 2479 RVA: 0x00068968 File Offset: 0x00066B68
		// (set) Token: 0x060009B0 RID: 2480 RVA: 0x00068A18 File Offset: 0x00066C18
		[global::System.Runtime.Serialization.DataMember]
		public int? ReferenceCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)272287521;
				short num2 = num;
				num = (short)335202081;
				switch (num2 == num)
				{
				}
				num = (short)258146305;
				if (num != 0)
				{
				}
				num = (short)1057423360;
				if (num != 0)
				{
				}
				num = (short)1462566912;
				short num3 = num;
				return this.<ReferenceCount>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1976777065;
				short num2 = num;
				num = (short)504117609;
				switch (num2 == num)
				{
				}
				num = (short)358154241;
				if (num != 0)
				{
				}
				num = (short)1984364544;
				if (num != 0)
				{
				}
				num = (short)1671102464;
				short num3 = num;
				this.<ReferenceCount>k__BackingField = value;
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x060009B1 RID: 2481 RVA: 0x00068AC8 File Offset: 0x00066CC8
		// (set) Token: 0x060009B2 RID: 2482 RVA: 0x00068B78 File Offset: 0x00066D78
		[global::System.Runtime.Serialization.DataMember]
		public bool? IsUpdating
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)157022286;
				short num2 = num;
				num = (short)873789518;
				switch (num2 == num)
				{
				}
				num = (short)1672019969;
				if (num != 0)
				{
				}
				num = (short)467861504;
				if (num != 0)
				{
				}
				num = (short)231800832;
				short num3 = num;
				return this.<IsUpdating>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)194299082;
				short num2 = num;
				num = (short)815187146;
				switch (num2 == num)
				{
				}
				num = (short)1282015233;
				if (num != 0)
				{
				}
				num = (short)5898240;
				if (num != 0)
				{
				}
				num = (short)1042022400;
				short num3 = num;
				this.<IsUpdating>k__BackingField = value;
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x00068C2C File Offset: 0x00066E2C
		// (set) Token: 0x060009B4 RID: 2484 RVA: 0x00068CDC File Offset: 0x00066EDC
		[global::System.Runtime.Serialization.DataMember]
		public string RDate
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2089923117;
				short num2 = num;
				num = (short)1337569837;
				switch (num2 == num)
				{
				}
				num = (short)2010775553;
				if (num != 0)
				{
				}
				num = (short)2034368512;
				if (num != 0)
				{
				}
				num = (short)708968448;
				short num3 = num;
				return this.<RDate>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1132921058;
				short num2 = num;
				num = (short)1753678050;
				switch (num2 == num)
				{
				}
				num = (short)1728446465;
				if (num != 0)
				{
				}
				num = (short)825884672;
				if (num != 0)
				{
				}
				num = (short)1725038592;
				short num3 = num;
				this.<RDate>k__BackingField = value;
			}
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x00068D8C File Offset: 0x00066F8C
		// (set) Token: 0x060009B6 RID: 2486 RVA: 0x00068E38 File Offset: 0x00067038
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPair> PCRFirmwareCodeplugPairs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)920160736;
				short num2 = num;
				num = (short)2109442528;
				switch (num2 == num)
				{
				}
				num = (short)1598488577;
				if (num != 0)
				{
				}
				num = (short)736362496;
				if (num != 0)
				{
				}
				num = (short)869793792;
				short num3 = num;
				return this.<PCRFirmwareCodeplugPairs>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1882227035;
				short num2 = num;
				num = (short)1002078555;
				switch (num2 == num)
				{
				}
				num = (short)302776321;
				if (num != 0)
				{
				}
				num = (short)323158016;
				if (num != 0)
				{
				}
				num = (short)551354368;
				short num3 = num;
				this.<PCRFirmwareCodeplugPairs>k__BackingField = value;
			}
		}
	}
}
