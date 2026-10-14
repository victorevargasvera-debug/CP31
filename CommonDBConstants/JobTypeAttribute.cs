using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.CommonDBConstants
{
	// Token: 0x02000003 RID: 3
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class JobTypeAttribute : global::System.Attribute
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		// (set) Token: 0x06000005 RID: 5 RVA: 0x000021CC File Offset: 0x000003CC
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory Category
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1407293387;
				short num2 = num;
				num = (short)1101174731;
				switch (num2 == num)
				{
				}
				num = (short)164888576;
				if (num != 0)
				{
				}
				num = (short)1181417472;
				short num3 = num;
				num = (short)1031340033;
				if (num != 0)
				{
				}
				return this.<Category>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)789150358;
				short num2 = num;
				num = (short)1053260438;
				switch (num2 == num)
				{
				}
				num = (short)1022361600;
				if (num != 0)
				{
				}
				num = (short)1613889536;
				short num3 = num;
				num = (short)1397293057;
				if (num != 0)
				{
				}
				this.<Category>k__BackingField = value;
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000227C File Offset: 0x0000047C
		public JobTypeAttribute()
		{
			this.Category = global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory.BatchOperation;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002298 File Offset: 0x00000498
		public JobTypeAttribute(global::Motorola.CommonCPS.Server.CommonDBConstants.JobTypCategory category)
		{
			this.Category = category;
		}
	}
}
