using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200007F RID: 127
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class PCRFirmwareCodeplugPair : global::Motorola.CommonCPS.Server.EntityModel.PCRPackage
	{
		// Token: 0x06000995 RID: 2453 RVA: 0x000678A8 File Offset: 0x00065AA8
		public PCRFirmwareCodeplugPair()
		{
			this.MatrixCodeplugs = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixCodeplug>();
		}

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x06000996 RID: 2454 RVA: 0x000678C8 File Offset: 0x00065AC8
		// (set) Token: 0x06000997 RID: 2455 RVA: 0x00067974 File Offset: 0x00065B74
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? FirmwareUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1393227323;
				short num2 = num;
				num = (short)1738339899;
				switch (num2 == num)
				{
				}
				num = (short)848822273;
				if (num != 0)
				{
				}
				num = (short)1551040512;
				if (num != 0)
				{
				}
				num = (short)389414912;
				short num3 = num;
				return this.<FirmwareUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)463534453;
				short num2 = num;
				num = (short)709032309;
				switch (num2 == num)
				{
				}
				num = (short)1728053249;
				if (num != 0)
				{
				}
				num = (short)726990848;
				if (num != 0)
				{
				}
				num = (short)1642004480;
				short num3 = num;
				this.<FirmwareUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x06000998 RID: 2456 RVA: 0x00067A24 File Offset: 0x00065C24
		// (set) Token: 0x06000999 RID: 2457 RVA: 0x00067AD0 File Offset: 0x00065CD0
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? CodeplugUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1069538285;
				short num2 = num;
				num = (short)1089723373;
				switch (num2 == num)
				{
				}
				num = (short)1252655105;
				if (num != 0)
				{
				}
				num = (short)1748631552;
				if (num != 0)
				{
				}
				num = (short)1816461312;
				short num3 = num;
				return this.<CodeplugUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1444629476;
				short num2 = num;
				num = (short)948390884;
				switch (num2 == num)
				{
				}
				num = (short)1515716609;
				if (num != 0)
				{
				}
				num = (short)316866560;
				if (num != 0)
				{
				}
				num = (short)1840709632;
				short num3 = num;
				this.<CodeplugUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x0600099A RID: 2458 RVA: 0x00067B80 File Offset: 0x00065D80
		// (set) Token: 0x0600099B RID: 2459 RVA: 0x00067C30 File Offset: 0x00065E30
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? GroupUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)476712088;
				short num2 = num;
				num = (short)800132248;
				switch (num2 == num)
				{
				}
				num = (short)1842020353;
				if (num != 0)
				{
				}
				num = (short)748355584;
				if (num != 0)
				{
				}
				num = (short)487194624;
				short num3 = num;
				return this.<GroupUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1745970449;
				short num2 = num;
				num = (short)561407249;
				switch (num2 == num)
				{
				}
				num = (short)1522008065;
				if (num != 0)
				{
				}
				num = (short)275775488;
				if (num != 0)
				{
				}
				num = (short)452526080;
				short num3 = num;
				this.<GroupUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x0600099C RID: 2460 RVA: 0x00067CE0 File Offset: 0x00065EE0
		// (set) Token: 0x0600099D RID: 2461 RVA: 0x00067D90 File Offset: 0x00065F90
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixCodeplug> MatrixCodeplugs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)754708627;
				short num2 = num;
				num = (short)39186579;
				switch (num2 == num)
				{
				}
				num = (short)1629945857;
				if (num != 0)
				{
				}
				num = (short)1441857536;
				if (num != 0)
				{
				}
				num = (short)174784512;
				short num3 = num;
				return this.<MatrixCodeplugs>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)116850689;
				if (num != 0)
				{
				}
				num = (short)1972989226;
				short num2 = num;
				num = (short)1119055146;
				switch (num2 == num)
				{
				}
				num = (short)852623360;
				if (num != 0)
				{
				}
				num = (short)920715264;
				short num3 = num;
				this.<MatrixCodeplugs>k__BackingField = value;
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x0600099E RID: 2462 RVA: 0x00067E40 File Offset: 0x00066040
		// (set) Token: 0x0600099F RID: 2463 RVA: 0x00067EF0 File Offset: 0x000660F0
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::Motorola.CommonCPS.Server.EntityModel.PCRCodeplug PCRCodeplug
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1366427910;
				short num2 = num;
				num = (short)1949698310;
				switch (num2 == num)
				{
				}
				num = (short)739311616;
				if (num != 0)
				{
				}
				num = (short)241434625;
				if (num != 0)
				{
				}
				num = (short)1350565888;
				short num3 = num;
				return this.<PCRCodeplug>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1350828033;
				if (num != 0)
				{
				}
				num = (short)48657221;
				short num2 = num;
				num = (short)627536709;
				switch (num2 == num)
				{
				}
				num = (short)1329790976;
				if (num != 0)
				{
				}
				num = (short)921370624;
				short num3 = num;
				this.<PCRCodeplug>k__BackingField = value;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x060009A0 RID: 2464 RVA: 0x00067FA0 File Offset: 0x000661A0
		// (set) Token: 0x060009A1 RID: 2465 RVA: 0x00068050 File Offset: 0x00066250
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::Motorola.CommonCPS.Server.EntityModel.PCRFirmware PCRFirmware
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2107079838;
				short num2 = num;
				num = (short)1646492830;
				switch (num2 == num)
				{
				}
				num = (short)1161166849;
				if (num != 0)
				{
				}
				num = (short)1473839104;
				if (num != 0)
				{
				}
				num = (short)1068957696;
				short num3 = num;
				return this.<PCRFirmware>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)488983657;
				short num2 = num;
				num = (short)700599401;
				switch (num2 == num)
				{
				}
				num = (short)282656768;
				if (num != 0)
				{
				}
				num = (short)1604780033;
				if (num != 0)
				{
				}
				num = (short)388759552;
				short num3 = num;
				this.<PCRFirmware>k__BackingField = value;
			}
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x060009A2 RID: 2466 RVA: 0x00068100 File Offset: 0x00066300
		// (set) Token: 0x060009A3 RID: 2467 RVA: 0x000681B0 File Offset: 0x000663B0
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::Motorola.CommonCPS.Server.EntityModel.PCRFirmwareCodeplugPairGroup PCRFirmwareCodeplugPairGroup
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2143559161;
				short num2 = num;
				num = (short)195436025;
				switch (num2 == num)
				{
				}
				num = (short)1239154688;
				if (num != 0)
				{
				}
				num = (short)1951793153;
				if (num != 0)
				{
				}
				num = (short)1271398400;
				short num3 = num;
				return this.<PCRFirmwareCodeplugPairGroup>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)125040947;
				short num2 = num;
				num = (short)597227827;
				switch (num2 == num)
				{
				}
				num = (short)173080577;
				if (num != 0)
				{
				}
				num = (short)2062024704;
				if (num != 0)
				{
				}
				num = (short)668532736;
				short num3 = num;
				this.<PCRFirmwareCodeplugPairGroup>k__BackingField = value;
			}
		}
	}
}
