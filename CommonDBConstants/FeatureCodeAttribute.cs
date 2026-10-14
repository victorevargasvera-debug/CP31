using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.Server.CommonDBConstants
{
	// Token: 0x0200000F RID: 15
	[global::System.AttributeUsage(global::System.AttributeTargets.Field, AllowMultiple = false)]
	public class FeatureCodeAttribute : global::System.Attribute
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000022B4 File Offset: 0x000004B4
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002360 File Offset: 0x00000560
		public global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureCodeType FeatureCodeType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)788542940;
				short num2 = num;
				num = (short)1727280604;
				switch (num2 == num)
				{
				}
				num = (short)526647297;
				if (num != 0)
				{
				}
				num = (short)1410203648;
				short num3 = num;
				num = (short)1609433088;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1633116190;
				short num2 = num;
				num = (short)111173662;
				switch (num2 == num)
				{
				}
				num = (short)1695219712;
				if (num != 0)
				{
				}
				num = (short)1058537472;
				short num3 = num;
				num = (short)1087635457;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002410 File Offset: 0x00000610
		// (set) Token: 0x0600000B RID: 11 RVA: 0x000024BC File Offset: 0x000006BC
		public string cpVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2031397528;
				short num2 = num;
				num = (short)1407298200;
				switch (num2 == num)
				{
				}
				num = (short)807862272;
				if (num != 0)
				{
				}
				num = (short)1392377856;
				short num3 = num;
				num = (short)1609498625;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1658448901;
				short num2 = num;
				num = (short)1844440069;
				switch (num2 == num)
				{
				}
				num = (short)1367605248;
				if (num != 0)
				{
				}
				num = (short)260898816;
				short num3 = num;
				num = (short)2051932161;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000C RID: 12 RVA: 0x0000256C File Offset: 0x0000076C
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode> SubFeatureCodes
		{
			get
			{
				short num = (short)1263099866;
				short num2 = num;
				num = (short)592732122;
				switch (num2 == num)
				{
				}
				num = (short)43450369;
				if (num != 0)
				{
				}
				num = (short)1335492608;
				short num3 = num;
				num = (short)31326208;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000261C File Offset: 0x0000081C
		public FeatureCodeAttribute(global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureCodeType featureCodeType, string cpversion = "")
		{
			this.FeatureCodeType = featureCodeType;
			this.cpVersion = cpversion;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002648 File Offset: 0x00000848
		public FeatureCodeAttribute(params global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode[] featureCodes) : this(global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureCodeType.RadioCombined, "")
		{
			if (featureCodes != null && featureCodes.Length != 0)
			{
				foreach (global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode item in featureCodes)
				{
					this.c.Add(item);
				}
			}
		}

		// Token: 0x04000098 RID: 152
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.Server.CommonDBConstants.FeatureCodeType a;

		// Token: 0x04000099 RID: 153
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string b;

		// Token: 0x0400009A RID: 154
		private readonly global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode> c = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.CommonDBConstants.PCR_CFSFeatureCode>();
	}
}
