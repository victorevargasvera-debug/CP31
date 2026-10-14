using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000112 RID: 274
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class FeatureResponseObject
	{
		// Token: 0x1700072D RID: 1837
		// (get) Token: 0x06000FDC RID: 4060 RVA: 0x000A9E44 File Offset: 0x000A8044
		// (set) Token: 0x06000FDD RID: 4061 RVA: 0x000A9EF4 File Offset: 0x000A80F4
		[global::System.Runtime.Serialization.DataMember]
		public byte[] capabilityResponse
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)312588326;
				short num2 = num;
				num = (short)1105180710;
				switch (num2 == num)
				{
				}
				num = (short)1329332225;
				if (num != 0)
				{
				}
				num = (short)515702784;
				short num3 = num;
				num = (short)646709248;
				if (num != 0)
				{
				}
				return this.<capabilityResponse>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1081130268;
				short num2 = num;
				num = (short)245546268;
				switch (num2 == num)
				{
				}
				num = (short)307232768;
				if (num != 0)
				{
				}
				num = (short)1178140672;
				short num3 = num;
				num = (short)1903099905;
				if (num != 0)
				{
				}
				this.<capabilityResponse>k__BackingField = value;
			}
		}

		// Token: 0x1700072E RID: 1838
		// (get) Token: 0x06000FDE RID: 4062 RVA: 0x000A9FA8 File Offset: 0x000A81A8
		// (set) Token: 0x06000FDF RID: 4063 RVA: 0x000AA058 File Offset: 0x000A8258
		[global::System.Runtime.Serialization.DataMember]
		public string uniqueID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)477382160;
				short num2 = num;
				num = (short)1902265872;
				switch (num2 == num)
				{
				}
				num = (short)869269505;
				if (num != 0)
				{
				}
				num = (short)1192361984;
				short num3 = num;
				num = (short)1331036160;
				if (num != 0)
				{
				}
				return this.<uniqueID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)624033793;
				if (num != 0)
				{
				}
				num = (short)1991266046;
				short num2 = num;
				num = (short)1948667646;
				switch (num2 == num)
				{
				}
				num = (short)1383399424;
				short num3 = num;
				num = (short)1016594432;
				if (num != 0)
				{
				}
				this.<uniqueID>k__BackingField = value;
			}
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x000AA10C File Offset: 0x000A830C
		public FeatureResponseObject(byte[] capResponse)
		{
			int a_ = 3;
			base..ctor();
			this.capabilityResponse = capResponse;
			this.uniqueID = global::System.DateTime.Now.Ticks.ToString(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.GroupRadioAssociationObjs.b("礀", a_), global::System.Globalization.CultureInfo.InvariantCulture);
		}
	}
}
