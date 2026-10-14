using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200018A RID: 394
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class SubmitLicenseRequest
	{
		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06001537 RID: 5431 RVA: 0x000E1CD8 File Offset: 0x000DFED8
		// (set) Token: 0x06001538 RID: 5432 RVA: 0x000E1D88 File Offset: 0x000DFF88
		public global::Motorola.CommonCPS.Server.EntityModel.Radio Radio
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1815740416;
				short num2 = num;
				num = (short)2064199182;
				short num3 = num;
				num = (short)1348742670;
				switch (num3 == num)
				{
				}
				num = (short)208797696;
				if (num != 0)
				{
				}
				num = (short)1994457089;
				if (num != 0)
				{
				}
				return this.<Radio>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)709361664;
				short num2 = num;
				num = (short)123927107;
				short num3 = num;
				num = (short)1505294915;
				switch (num3 == num)
				{
				}
				num = (short)1754923009;
				if (num != 0)
				{
				}
				num = (short)2042363904;
				if (num != 0)
				{
				}
				this.<Radio>k__BackingField = value;
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06001539 RID: 5433 RVA: 0x000E1E38 File Offset: 0x000E0038
		// (set) Token: 0x0600153A RID: 5434 RVA: 0x000E1EE8 File Offset: 0x000E00E8
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureRequest> Requests
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)870318080;
				short num2 = num;
				num = (short)1789333335;
				short num3 = num;
				num = (short)1104482135;
				switch (num3 == num)
				{
				}
				num = (short)1288503297;
				if (num != 0)
				{
				}
				num = (short)1648295936;
				if (num != 0)
				{
				}
				return this.<Requests>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1804861440;
				short num2 = num;
				num = (short)1538220521;
				short num3 = num;
				num = (short)2033607145;
				switch (num3 == num)
				{
				}
				num = (short)306839552;
				if (num != 0)
				{
				}
				num = (short)489160705;
				if (num != 0)
				{
				}
				this.<Requests>k__BackingField = value;
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x0600153B RID: 5435 RVA: 0x000E1F98 File Offset: 0x000E0198
		// (set) Token: 0x0600153C RID: 5436 RVA: 0x000E2048 File Offset: 0x000E0248
		public byte[] TargetFlashCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)318504960;
				short num2 = num;
				num = (short)299422540;
				short num3 = num;
				num = (short)2101793612;
				switch (num3 == num)
				{
				}
				num = (short)497680385;
				if (num != 0)
				{
				}
				num = (short)813629440;
				if (num != 0)
				{
				}
				return this.<TargetFlashCode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1523908608;
				short num2 = num;
				num = (short)194276250;
				short num3 = num;
				num = (short)1930718106;
				switch (num3 == num)
				{
				}
				num = (short)1360330753;
				if (num != 0)
				{
				}
				num = (short)1817640960;
				if (num != 0)
				{
				}
				this.<TargetFlashCode>k__BackingField = value;
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x0600153D RID: 5437 RVA: 0x000E20FC File Offset: 0x000E02FC
		// (set) Token: 0x0600153E RID: 5438 RVA: 0x000E21AC File Offset: 0x000E03AC
		public byte[] CapacityResponse
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)127336448;
				short num2 = num;
				num = (short)2118906642;
				short num3 = num;
				num = (short)1702949650;
				switch (num3 == num)
				{
				}
				num = (short)1733754880;
				if (num != 0)
				{
				}
				num = (short)1860304897;
				if (num != 0)
				{
				}
				return this.<CapacityResponse>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1205534720;
				short num2 = num;
				num = (short)1803733810;
				short num3 = num;
				num = (short)978504498;
				switch (num3 == num)
				{
				}
				num = (short)1939865601;
				if (num != 0)
				{
				}
				num = (short)90374144;
				if (num != 0)
				{
				}
				this.<CapacityResponse>k__BackingField = value;
			}
		}
	}
}
