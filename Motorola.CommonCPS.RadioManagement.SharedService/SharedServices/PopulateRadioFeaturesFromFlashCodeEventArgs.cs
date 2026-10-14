using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.SharedServices
{
	// Token: 0x020000A8 RID: 168
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class PopulateRadioFeaturesFromFlashCodeEventArgs : global::System.EventArgs
	{
		// Token: 0x06000A1F RID: 2591 RVA: 0x00077108 File Offset: 0x00075308
		public PopulateRadioFeaturesFromFlashCodeEventArgs(byte[] flashCode, string modelNumber)
		{
			this.flashCode = flashCode;
			this.ModelNumber = modelNumber;
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x0007712C File Offset: 0x0007532C
		// (set) Token: 0x06000A21 RID: 2593 RVA: 0x000771DC File Offset: 0x000753DC
		public byte[] FlashCode
		{
			get
			{
				short num = (short)438263725;
				short num2 = num;
				num = (short)371744685;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1781661696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)333971457;
				if (num != 0)
				{
				}
				num = (short)1081147392;
				if (num != 0)
				{
				}
				return this.flashCode;
			}
			set
			{
				short num = (short)1440857812;
				short num2 = num;
				num = (short)1889058516;
				switch (num2 == num)
				{
				default:
				{
					num = (short)277348352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)320864257;
				if (num != 0)
				{
				}
				num = (short)1326972928;
				if (num != 0)
				{
				}
				this.flashCode = value;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x0007728C File Offset: 0x0007548C
		// (set) Token: 0x06000A23 RID: 2595 RVA: 0x00077338 File Offset: 0x00075538
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> RadioFeaturesRequest
		{
			get
			{
				short num = (short)1550111617;
				short num2 = num;
				num = (short)974902145;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1275592704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)404946945;
				if (num != 0)
				{
				}
				num = (short)1638268928;
				if (num != 0)
				{
				}
				return this.radioFeaturesRequest;
			}
			set
			{
				short num = (short)245822881;
				short num2 = num;
				num = (short)570946977;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1230045184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)979042304;
				if (num != 0)
				{
				}
				num = (short)1211564033;
				if (num != 0)
				{
				}
				this.radioFeaturesRequest = value;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x000773E8 File Offset: 0x000755E8
		// (set) Token: 0x06000A25 RID: 2597 RVA: 0x00077498 File Offset: 0x00075698
		[global::System.Runtime.Serialization.DataMember]
		public string ModelNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1869826637;
				short num2 = num;
				num = (short)1081559629;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1335492608;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1240399872;
				if (num != 0)
				{
				}
				num = (short)404553729;
				if (num != 0)
				{
				}
				return this.<ModelNumber>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1843940081;
				short num2 = num;
				num = (short)806308593;
				switch (num2 == num)
				{
				default:
				{
					num = (short)709820416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)621543425;
				if (num != 0)
				{
				}
				num = (short)643956736;
				if (num != 0)
				{
				}
				this.<ModelNumber>k__BackingField = value;
			}
		}

		// Token: 0x0400016B RID: 363
		[global::System.Runtime.Serialization.DataMember]
		private byte[] flashCode;

		// Token: 0x0400016C RID: 364
		[global::System.Runtime.Serialization.DataMember]
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> radioFeaturesRequest;
	}
}
