using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000179 RID: 377
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	public class DBUpdate
	{
		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x06001475 RID: 5237 RVA: 0x000D94E0 File Offset: 0x000D76E0
		// (set) Token: 0x06001476 RID: 5238 RVA: 0x000D958C File Offset: 0x000D778C
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.DBNode node
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)508900372;
				short num2 = num;
				num = (short)477770772;
				switch (num2 == num)
				{
				}
				num = (short)1124859905;
				if (num != 0)
				{
				}
				num = (short)683474944;
				if (num != 0)
				{
				}
				num = (short)2065629184;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2134580958;
				short num2 = num;
				num = (short)1224810206;
				switch (num2 == num)
				{
				}
				num = (short)2102657025;
				if (num != 0)
				{
				}
				num = (short)1060110336;
				if (num != 0)
				{
				}
				num = (short)628228096;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x06001477 RID: 5239 RVA: 0x000D963C File Offset: 0x000D783C
		// (set) Token: 0x06001478 RID: 5240 RVA: 0x000D96EC File Offset: 0x000D78EC
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.RecordModifier recordModifier
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1757678496;
				short num2 = num;
				num = (short)886770592;
				switch (num2 == num)
				{
				}
				num = (short)1583546368;
				if (num != 0)
				{
				}
				num = (short)1069940737;
				if (num != 0)
				{
				}
				num = (short)1955921920;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1330678455;
				short num2 = num;
				num = (short)1156876983;
				switch (num2 == num)
				{
				}
				num = (short)1766653953;
				if (num != 0)
				{
				}
				num = (short)1154220032;
				if (num != 0)
				{
				}
				num = (short)1462632448;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x06001479 RID: 5241 RVA: 0x000D979C File Offset: 0x000D799C
		// (set) Token: 0x0600147A RID: 5242 RVA: 0x000D984C File Offset: 0x000D7A4C
		[global::System.Runtime.Serialization.DataMember]
		public bool IsSetNameModified
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1986723841;
				if (num != 0)
				{
				}
				num = (short)197992520;
				short num2 = num;
				num = (short)609624136;
				switch (num2 == num)
				{
				}
				num = (short)566493184;
				if (num != 0)
				{
				}
				num = (short)1842741248;
				short num3 = num;
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)857210881;
				if (num != 0)
				{
				}
				num = (short)1203168091;
				short num2 = num;
				num = (short)1100997467;
				switch (num2 == num)
				{
				}
				num = (short)169082880;
				if (num != 0)
				{
				}
				num = (short)523239424;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x0600147B RID: 5243 RVA: 0x000D9900 File Offset: 0x000D7B00
		// (set) Token: 0x0600147C RID: 5244 RVA: 0x000D99AC File Offset: 0x000D7BAC
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily, string> ImpactedProductFamilyAndVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1972437103;
				short num2 = num;
				num = (short)877854831;
				switch (num2 == num)
				{
				}
				num = (short)1541603329;
				if (num != 0)
				{
				}
				num = (short)444465152;
				if (num != 0)
				{
				}
				num = (short)1791295488;
				short num3 = num;
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)48481736;
				short num2 = num;
				num = (short)254592456;
				switch (num2 == num)
				{
				}
				num = (short)1557069824;
				if (num != 0)
				{
				}
				num = (short)1926561793;
				if (num != 0)
				{
				}
				num = (short)84279296;
				short num3 = num;
				this.d = value;
			}
		}

		// Token: 0x04000993 RID: 2451
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.Server.EntityModel.DBNode a;

		// Token: 0x04000994 RID: 2452
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.Server.CommonDBConstants.RecordModifier b;

		// Token: 0x04000995 RID: 2453
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool c;

		// Token: 0x04000996 RID: 2454
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily, string> d;
	}
}
