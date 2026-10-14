using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000144 RID: 324
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class PCRTextToSpeechRequest : global::Motorola.CommonCPS.Server.EntityModel.PCRPackageRequest
	{
		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x06001235 RID: 4661 RVA: 0x000C23AC File Offset: 0x000C05AC
		// (set) Token: 0x06001236 RID: 4662 RVA: 0x000C245C File Offset: 0x000C065C
		[global::System.Runtime.Serialization.DataMember]
		public string PackageName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)261226496;
				short num2 = num;
				num = (short)1032421126;
				short num3 = num;
				num = (short)1759936262;
				switch (num3 == num)
				{
				}
				num = (short)510066688;
				if (num != 0)
				{
				}
				num = (short)521469953;
				if (num != 0)
				{
				}
				return this.<PackageName>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1034092544;
				short num2 = num;
				num = (short)803217572;
				short num3 = num;
				num = (short)541073572;
				switch (num3 == num)
				{
				}
				num = (short)378470401;
				if (num != 0)
				{
				}
				num = (short)260898816;
				if (num != 0)
				{
				}
				this.<PackageName>k__BackingField = value;
			}
		}
	}
}
