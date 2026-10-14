using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000C7 RID: 199
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class MigrateRadioParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06000D5C RID: 3420 RVA: 0x0008F140 File Offset: 0x0008D340
		// (set) Token: 0x06000D5D RID: 3421 RVA: 0x0008F1EC File Offset: 0x0008D3EC
		public global::Motorola.CommonCPS.Server.EntityModel.Radio Radio
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1322911141;
				short num2 = num;
				num = (short)1002571173;
				switch (num2 == num)
				{
				default:
				{
					num = (short)296288256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1426849793;
				if (num != 0)
				{
				}
				num = (short)1984102400;
				if (num != 0)
				{
				}
				return this.<Radio>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1306545955;
				short num2 = num;
				num = (short)1080053539;
				switch (num2 == num)
				{
				default:
				{
					num = (short)743833600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2084700160;
				if (num != 0)
				{
				}
				num = (short)602406913;
				if (num != 0)
				{
				}
				this.<Radio>k__BackingField = value;
			}
		}

		// Token: 0x17000635 RID: 1589
		// (get) Token: 0x06000D5E RID: 3422 RVA: 0x0008F29C File Offset: 0x0008D49C
		// (set) Token: 0x06000D5F RID: 3423 RVA: 0x0008F34C File Offset: 0x0008D54C
		public global::Motorola.CommonCPS.Server.EntityModel.MigrationRadioTemplateInfo MigrationInfo
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1559193543;
				short num2 = num;
				num = (short)2047043527;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1351745536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)649986049;
				if (num != 0)
				{
				}
				num = (short)247398400;
				if (num != 0)
				{
				}
				return this.<MigrationInfo>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1705705473;
				if (num != 0)
				{
				}
				num = (short)1391329280;
				short num2 = num;
				num = (short)1292112099;
				short num3 = num;
				num = (short)2122191075;
				switch (num3 == num)
				{
				}
				num = (short)777256960;
				if (num != 0)
				{
				}
				this.<MigrationInfo>k__BackingField = value;
			}
		}

		// Token: 0x17000636 RID: 1590
		// (get) Token: 0x06000D60 RID: 3424 RVA: 0x0008F3FC File Offset: 0x0008D5FC
		// (set) Token: 0x06000D61 RID: 3425 RVA: 0x0008F4B0 File Offset: 0x0008D6B0
		public string Password
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1217180881;
				short num2 = num;
				num = (short)889238737;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1726218240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)922746881;
				if (num != 0)
				{
				}
				num = (short)1144913920;
				if (num != 0)
				{
				}
				return this.<Password>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1888092161;
				if (num != 0)
				{
				}
				num = (short)1893728256;
				short num2 = num;
				num = (short)1320553880;
				short num3 = num;
				num = (short)1265438104;
				switch (num3 == num)
				{
				}
				num = (short)1739849728;
				if (num != 0)
				{
				}
				this.<Password>k__BackingField = value;
			}
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x0008F560 File Offset: 0x0008D760
		public MigrateRadioParameter() : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
		}
	}
}
