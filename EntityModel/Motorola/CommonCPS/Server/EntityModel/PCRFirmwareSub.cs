using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000081 RID: 129
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class PCRFirmwareSub : global::Motorola.CommonCPS.Server.EntityModel.PCRPackage
	{
		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x00068EE8 File Offset: 0x000670E8
		// (set) Token: 0x060009B8 RID: 2488 RVA: 0x00068F98 File Offset: 0x00067198
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? FirmwareUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1924736433;
				short num2 = num;
				num = (short)302458289;
				switch (num2 == num)
				{
				}
				num = (short)1312751616;
				if (num != 0)
				{
				}
				num = (short)743833601;
				if (num != 0)
				{
				}
				num = (short)1330708480;
				short num3 = num;
				return this.<FirmwareUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)991015379;
				short num2 = num;
				num = (short)485405139;
				switch (num2 == num)
				{
				}
				num = (short)1573060609;
				if (num != 0)
				{
				}
				num = (short)1178796032;
				if (num != 0)
				{
				}
				num = (short)1187184640;
				short num3 = num;
				this.<FirmwareUuid>k__BackingField = value;
			}
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x0006904C File Offset: 0x0006724C
		// (set) Token: 0x060009BA RID: 2490 RVA: 0x000690FC File Offset: 0x000672FC
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::Motorola.CommonCPS.Server.EntityModel.PCRFirmware PCRFirmware
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)749535233;
				if (num != 0)
				{
				}
				num = (short)150411964;
				short num2 = num;
				num = (short)1984043708;
				switch (num2 == num)
				{
				}
				num = (short)473694208;
				if (num != 0)
				{
				}
				num = (short)704905216;
				short num3 = num;
				return this.<PCRFirmware>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1079836673;
				if (num != 0)
				{
				}
				num = (short)900790049;
				short num2 = num;
				num = (short)2007627553;
				switch (num2 == num)
				{
				}
				num = (short)349110272;
				if (num != 0)
				{
				}
				num = (short)595197952;
				short num3 = num;
				this.<PCRFirmware>k__BackingField = value;
			}
		}
	}
}
