using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000113 RID: 275
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class FeatureRequestObject
	{
		// Token: 0x1700072F RID: 1839
		// (get) Token: 0x06000FE1 RID: 4065 RVA: 0x000AA160 File Offset: 0x000A8360
		// (set) Token: 0x06000FE2 RID: 4066 RVA: 0x000AA214 File Offset: 0x000A8414
		[global::System.Runtime.Serialization.DataMember]
		public byte[] capabilityRequest
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)261495838;
				short num2 = num;
				num = (short)1790975006;
				switch (num2 == num)
				{
				}
				num = (short)1516699649;
				if (num != 0)
				{
				}
				num = (short)161546240;
				short num3 = num;
				num = (short)205127680;
				if (num != 0)
				{
				}
				return this.<capabilityRequest>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1937899521;
				if (num != 0)
				{
				}
				num = (short)1178848793;
				short num2 = num;
				num = (short)1175899673;
				switch (num2 == num)
				{
				}
				num = (short)1190330368;
				short num3 = num;
				num = (short)1246887936;
				if (num != 0)
				{
				}
				this.<capabilityRequest>k__BackingField = value;
			}
		}

		// Token: 0x17000730 RID: 1840
		// (get) Token: 0x06000FE3 RID: 4067 RVA: 0x000AA2C4 File Offset: 0x000A84C4
		// (set) Token: 0x06000FE4 RID: 4068 RVA: 0x000AA374 File Offset: 0x000A8574
		[global::System.Runtime.Serialization.DataMember]
		public string uniqueID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)176819160;
				short num2 = num;
				num = (short)71175128;
				switch (num2 == num)
				{
				}
				num = (short)1220673537;
				if (num != 0)
				{
				}
				num = (short)748683264;
				short num3 = num;
				num = (short)1371209728;
				if (num != 0)
				{
				}
				return this.<uniqueID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)654581797;
				short num2 = num;
				num = (short)797450277;
				switch (num2 == num)
				{
				}
				num = (short)1091436544;
				if (num != 0)
				{
				}
				num = (short)496762880;
				short num3 = num;
				num = (short)1781268481;
				if (num != 0)
				{
				}
				this.<uniqueID>k__BackingField = value;
			}
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x000AA424 File Offset: 0x000A8624
		public FeatureRequestObject(byte[] capRequest)
		{
			int a_ = 11;
			base..ctor();
			this.capabilityRequest = capRequest;
			this.uniqueID = global::System.DateTime.Now.Ticks.ToString(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("焈", a_), global::System.Globalization.CultureInfo.InvariantCulture);
		}
	}
}
