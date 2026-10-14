using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000C2 RID: 194
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class MigrateFirmwareParameter : global::Motorola.CommonCPS.Server.EntityModel.BatchJobParameterBase
	{
		// Token: 0x1700062F RID: 1583
		// (get) Token: 0x06000D4D RID: 3405 RVA: 0x0008E9AC File Offset: 0x0008CBAC
		// (set) Token: 0x06000D4E RID: 3406 RVA: 0x0008EA5C File Offset: 0x0008CC5C
		public global::Motorola.CommonCPS.Server.EntityModel.Package Firmware
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)806748725;
				short num2 = num;
				num = (short)426181173;
				switch (num2 == num)
				{
				default:
				{
					num = (short)455213056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)7667713;
				if (num != 0)
				{
				}
				num = (short)1430585344;
				if (num != 0)
				{
				}
				return this.<Firmware>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)288751617;
				if (num != 0)
				{
				}
				num = (short)51970048;
				short num2 = num;
				num = (short)706365236;
				short num3 = num;
				num = (short)61032244;
				switch (num3 == num)
				{
				}
				num = (short)372572160;
				if (num != 0)
				{
				}
				this.<Firmware>k__BackingField = value;
			}
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x0008EB0C File Offset: 0x0008CD0C
		public MigrateFirmwareParameter(global::Motorola.CommonCPS.Server.EntityModel.Package Firmware, string jobDescription) : base(global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.Any)
		{
			this.Firmware = Firmware;
			base.JobDescription = jobDescription;
		}
	}
}
