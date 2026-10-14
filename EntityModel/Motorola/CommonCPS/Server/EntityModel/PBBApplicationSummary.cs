using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000158 RID: 344
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class PBBApplicationSummary : global::Motorola.CommonCPS.Server.EntityModel.PBBPackageSummary
	{
		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06001307 RID: 4871 RVA: 0x000CA7E4 File Offset: 0x000C89E4
		// (set) Token: 0x06001308 RID: 4872 RVA: 0x000CA894 File Offset: 0x000C8A94
		[global::System.Runtime.Serialization.DataMember]
		public int? PackageVersionCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1016947554;
				short num2 = num;
				num = (short)12215138;
				switch (num2 == num)
				{
				}
				num = (short)1572865;
				if (num != 0)
				{
				}
				num = (short)1861419008;
				if (num != 0)
				{
				}
				num = (short)1487732736;
				short num3 = num;
				return this.<PackageVersionCode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)220698355;
				short num2 = num;
				num = (short)1793955571;
				switch (num2 == num)
				{
				}
				num = (short)136839169;
				if (num != 0)
				{
				}
				num = (short)1218641920;
				if (num != 0)
				{
				}
				num = (short)1024065536;
				short num3 = num;
				this.<PackageVersionCode>k__BackingField = value;
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06001309 RID: 4873 RVA: 0x000CA944 File Offset: 0x000C8B44
		// (set) Token: 0x0600130A RID: 4874 RVA: 0x000CA9F0 File Offset: 0x000C8BF0
		[global::System.Runtime.Serialization.DataMember]
		public string PackageLabel
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)925094111;
				short num2 = num;
				num = (short)1613549791;
				switch (num2 == num)
				{
				}
				num = (short)18546688;
				if (num != 0)
				{
				}
				num = (short)114884609;
				if (num != 0)
				{
				}
				num = (short)1551433728;
				short num3 = num;
				return this.<PackageLabel>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2131584651;
				short num2 = num;
				num = (short)405563019;
				switch (num2 == num)
				{
				}
				num = (short)2025127937;
				if (num != 0)
				{
				}
				num = (short)1373962240;
				if (num != 0)
				{
				}
				num = (short)2129461248;
				short num3 = num;
				this.<PackageLabel>k__BackingField = value;
			}
		}
	}
}
