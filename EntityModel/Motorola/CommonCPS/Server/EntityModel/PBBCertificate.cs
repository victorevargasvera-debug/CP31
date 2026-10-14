using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200006B RID: 107
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class PBBCertificate : global::Motorola.CommonCPS.Server.EntityModel.PBBPackage
	{
		// Token: 0x06000835 RID: 2101 RVA: 0x0005AE14 File Offset: 0x00059014
		public PBBCertificate()
		{
			this.PBBCodeplugs = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PBBCodeplug>();
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06000836 RID: 2102 RVA: 0x0005AE34 File Offset: 0x00059034
		// (set) Token: 0x06000837 RID: 2103 RVA: 0x0005AEE0 File Offset: 0x000590E0
		[global::System.Runtime.Serialization.DataMember]
		public string PackageName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)817299456;
				short num2 = num;
				num = (short)512099296;
				short num3 = num;
				num = (short)1200817120;
				switch (num3 == num)
				{
				}
				num = (short)2037055489;
				if (num != 0)
				{
				}
				num = (short)828178432;
				if (num != 0)
				{
				}
				return this.<PackageName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1584115153;
				short num2 = num;
				num = (short)774942161;
				switch (num2 == num)
				{
				}
				num = (short)641990656;
				if (num != 0)
				{
				}
				num = (short)36241409;
				if (num != 0)
				{
				}
				num = (short)980156416;
				short num3 = num;
				this.<PackageName>k__BackingField = value;
			}
		}

		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06000838 RID: 2104 RVA: 0x0005AF90 File Offset: 0x00059190
		// (set) Token: 0x06000839 RID: 2105 RVA: 0x0005B040 File Offset: 0x00059240
		[global::System.Runtime.Serialization.DataMember]
		public int? ReferenceCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1548416059;
				short num2 = num;
				num = (short)1772024891;
				switch (num2 == num)
				{
				}
				num = (short)1243807745;
				if (num != 0)
				{
				}
				num = (short)700055552;
				if (num != 0)
				{
				}
				num = (short)2090598400;
				short num3 = num;
				return this.<ReferenceCount>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)647103456;
				short num2 = num;
				num = (short)1059062752;
				switch (num2 == num)
				{
				}
				num = (short)1299709953;
				if (num != 0)
				{
				}
				num = (short)340852736;
				if (num != 0)
				{
				}
				num = (short)8323072;
				short num3 = num;
				this.<ReferenceCount>k__BackingField = value;
			}
		}

		// Token: 0x170003DD RID: 989
		// (get) Token: 0x0600083A RID: 2106 RVA: 0x0005B0F0 File Offset: 0x000592F0
		// (set) Token: 0x0600083B RID: 2107 RVA: 0x0005B1A4 File Offset: 0x000593A4
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PBBCodeplug> PBBCodeplugs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1282801665;
				if (num != 0)
				{
				}
				num = (short)1921232078;
				short num2 = num;
				num = (short)1816440014;
				switch (num2 == num)
				{
				}
				num = (short)968294400;
				if (num != 0)
				{
				}
				num = (short)758382592;
				short num3 = num;
				return this.<PBBCodeplugs>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1625365641;
				short num2 = num;
				num = (short)1102650505;
				switch (num2 == num)
				{
				}
				num = (short)1191641088;
				if (num != 0)
				{
				}
				num = (short)330432513;
				if (num != 0)
				{
				}
				num = (short)193921024;
				short num3 = num;
				this.<PBBCodeplugs>k__BackingField = value;
			}
		}
	}
}
