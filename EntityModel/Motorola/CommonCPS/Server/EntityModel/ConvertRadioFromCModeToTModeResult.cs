using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000E3 RID: 227
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class ConvertRadioFromCModeToTModeResult
	{
		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06000DFD RID: 3581 RVA: 0x00095238 File Offset: 0x00093438
		// (set) Token: 0x06000DFE RID: 3582 RVA: 0x000952E8 File Offset: 0x000934E8
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.RadioSummary RadioSummary
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1323757532;
				short num2 = num;
				num = (short)1115942876;
				switch (num2 == num)
				{
				}
				num = (short)503644160;
				short num3 = num;
				num = (short)1409286145;
				if (num != 0)
				{
				}
				num = (short)15925248;
				if (num != 0)
				{
				}
				return this.<RadioSummary>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1193712206;
				short num2 = num;
				num = (short)1702271566;
				switch (num2 == num)
				{
				}
				num = (short)805634048;
				short num3 = num;
				num = (short)322633729;
				if (num != 0)
				{
				}
				num = (short)1890189312;
				if (num != 0)
				{
				}
				this.<RadioSummary>k__BackingField = value;
			}
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x00095398 File Offset: 0x00093598
		public ConvertRadioFromCModeToTModeResult()
		{
			this.RadioSummary = new global::Motorola.CommonCPS.Server.EntityModel.RadioSummary();
		}
	}
}
