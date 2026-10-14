using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000183 RID: 387
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class SendDeviceRequest
	{
		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06001501 RID: 5377 RVA: 0x000DF664 File Offset: 0x000DD864
		// (set) Token: 0x06001502 RID: 5378 RVA: 0x000DF714 File Offset: 0x000DD914
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest.ActivationInformation> ActivationInfo
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1663618561;
				short num2 = num;
				num = (short)273534465;
				switch (num2 == num)
				{
				}
				num = (short)1442447361;
				if (num != 0)
				{
				}
				num = (short)114360320;
				if (num != 0)
				{
				}
				num = (short)1255407616;
				short num3 = num;
				return this.<ActivationInfo>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)30964656;
				short num2 = num;
				num = (short)381909936;
				switch (num2 == num)
				{
				}
				num = (short)438894592;
				if (num != 0)
				{
				}
				num = (short)145162241;
				if (num != 0)
				{
				}
				num = (short)1167523840;
				short num3 = num;
				this.<ActivationInfo>k__BackingField = value;
			}
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06001503 RID: 5379 RVA: 0x000DF7C8 File Offset: 0x000DD9C8
		// (set) Token: 0x06001504 RID: 5380 RVA: 0x000DF87C File Offset: 0x000DDA7C
		[global::System.Runtime.Serialization.DataMember]
		public string DeviceID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)21164768;
				short num2 = num;
				num = (short)849343200;
				switch (num2 == num)
				{
				}
				num = (short)221118465;
				if (num != 0)
				{
				}
				num = (short)1503264768;
				if (num != 0)
				{
				}
				num = (short)2044198912;
				short num3 = num;
				return this.<DeviceID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)392568571;
				short num2 = num;
				num = (short)403709691;
				switch (num2 == num)
				{
				}
				num = (short)523632641;
				if (num != 0)
				{
				}
				num = (short)747241472;
				if (num != 0)
				{
				}
				num = (short)1602682880;
				short num3 = num;
				this.<DeviceID>k__BackingField = value;
			}
		}

		// Token: 0x06001505 RID: 5381 RVA: 0x000DF930 File Offset: 0x000DDB30
		public SendDeviceRequest(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.SendDeviceRequest.ActivationInformation> activationInfo, string deviceID)
		{
			this.ActivationInfo = activationInfo;
			this.DeviceID = deviceID;
		}

		// Token: 0x02000184 RID: 388
		public struct ActivationInformation
		{
			// Token: 0x17000986 RID: 2438
			// (get) Token: 0x06001506 RID: 5382 RVA: 0x000DF954 File Offset: 0x000DDB54
			// (set) Token: 0x06001507 RID: 5383 RVA: 0x000DFA00 File Offset: 0x000DDC00
			public string ID
			{
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				get
				{
					short num = (short)1714997614;
					short num2 = num;
					num = (short)937740654;
					switch (num2 == num)
					{
					}
					num = (short)1584398337;
					if (num != 0)
					{
					}
					num = (short)1357447168;
					if (num != 0)
					{
					}
					num = (short)752812032;
					short num3 = num;
					return this.a;
				}
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				set
				{
					short num = (short)338421962;
					short num2 = num;
					num = (short)378923210;
					switch (num2 == num)
					{
					}
					num = (short)1108279296;
					if (num != 0)
					{
					}
					num = (short)1391067137;
					if (num != 0)
					{
					}
					num = (short)828571648;
					short num3 = num;
					this.a = value;
				}
			}

			// Token: 0x17000987 RID: 2439
			// (get) Token: 0x06001508 RID: 5384 RVA: 0x000DFAB0 File Offset: 0x000DDCB0
			// (set) Token: 0x06001509 RID: 5385 RVA: 0x000DFB60 File Offset: 0x000DDD60
			public int Count
			{
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				get
				{
					short num = (short)1176098654;
					short num2 = num;
					num = (short)2018105182;
					switch (num2 == num)
					{
					}
					num = (short)802226177;
					if (num != 0)
					{
					}
					num = (short)1200816128;
					if (num != 0)
					{
					}
					num = (short)1998454784;
					short num3 = num;
					return this.b;
				}
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				set
				{
					short num = (short)1025238727;
					short num2 = num;
					num = (short)1038018247;
					switch (num2 == num)
					{
					}
					num = (short)735051777;
					if (num != 0)
					{
					}
					num = (short)1293746176;
					if (num != 0)
					{
					}
					num = (short)738459648;
					short num3 = num;
					this.b = value;
				}
			}

			// Token: 0x040009DF RID: 2527
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private string a;

			// Token: 0x040009E0 RID: 2528
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private int b;
		}
	}
}
