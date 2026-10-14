using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000055 RID: 85
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class RWJobContainerChangeHistory : global::Motorola.CommonCPS.Server.EntityModel.IEntity
	{
		// Token: 0x0600065D RID: 1629 RVA: 0x000473C0 File Offset: 0x000455C0
		public RWJobContainerChangeHistory()
		{
			this.JobsCountIncreasement = 0;
			this.FinishedJobsCountIncreasement = 0;
			this.FailedJobsCountIncreasement = 0;
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x0600065E RID: 1630 RVA: 0x000473E8 File Offset: 0x000455E8
		// (set) Token: 0x0600065F RID: 1631 RVA: 0x00047498 File Offset: 0x00045698
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid JobContainerUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)264550413;
				short num2 = num;
				num = (short)458799117;
				switch (num2 == num)
				{
				}
				num = (short)583729153;
				if (num != 0)
				{
				}
				num = (short)748290048;
				short num3 = num;
				num = (short)990576640;
				if (num != 0)
				{
				}
				return this.<JobContainerUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1397941288;
				short num2 = num;
				num = (short)1986847784;
				switch (num2 == num)
				{
				}
				num = (short)348454912;
				short num3 = num;
				num = (short)1751252993;
				if (num != 0)
				{
				}
				num = (short)1389756416;
				if (num != 0)
				{
				}
				this.<JobContainerUuid>k__BackingField = value;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000660 RID: 1632 RVA: 0x00047548 File Offset: 0x00045748
		// (set) Token: 0x06000661 RID: 1633 RVA: 0x000475F8 File Offset: 0x000457F8
		[global::System.Runtime.Serialization.DataMember]
		public int JobsCountIncreasement
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1144979457;
				if (num != 0)
				{
				}
				num = (short)1414485302;
				short num2 = num;
				num = (short)689263926;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1297809408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1877671936;
				if (num != 0)
				{
				}
				return this.<JobsCountIncreasement>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)256711778;
				short num2 = num;
				num = (short)2048203874;
				switch (num2 == num)
				{
				}
				num = (short)692125696;
				short num3 = num;
				num = (short)503316481;
				if (num != 0)
				{
				}
				num = (short)640745472;
				if (num != 0)
				{
				}
				this.<JobsCountIncreasement>k__BackingField = value;
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000662 RID: 1634 RVA: 0x000476AC File Offset: 0x000458AC
		// (set) Token: 0x06000663 RID: 1635 RVA: 0x00047758 File Offset: 0x00045958
		[global::System.Runtime.Serialization.DataMember]
		public int FinishedJobsCountIncreasement
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1711169957;
				short num2 = num;
				num = (short)1902404005;
				switch (num2 == num)
				{
				}
				num = (short)1468137472;
				short num3 = num;
				num = (short)55771136;
				if (num != 0)
				{
				}
				num = (short)945029121;
				if (num != 0)
				{
				}
				return this.<FinishedJobsCountIncreasement>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1106084330;
				short num2 = num;
				num = (short)424116714;
				switch (num2 == num)
				{
				}
				num = (short)1031471104;
				short num3 = num;
				num = (short)1839464449;
				if (num != 0)
				{
				}
				num = (short)749993984;
				if (num != 0)
				{
				}
				this.<FinishedJobsCountIncreasement>k__BackingField = value;
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000664 RID: 1636 RVA: 0x00047804 File Offset: 0x00045A04
		// (set) Token: 0x06000665 RID: 1637 RVA: 0x000478B4 File Offset: 0x00045AB4
		[global::System.Runtime.Serialization.DataMember]
		public int FailedJobsCountIncreasement
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)445186049;
				if (num != 0)
				{
				}
				num = (short)1943942833;
				short num2 = num;
				num = (short)377632433;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1244528640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)763559936;
				if (num != 0)
				{
				}
				return this.<FailedJobsCountIncreasement>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)273154049;
				if (num != 0)
				{
				}
				num = (short)1382891663;
				short num2 = num;
				num = (short)1900298383;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1640103936;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)158597120;
				if (num != 0)
				{
				}
				this.<FailedJobsCountIncreasement>k__BackingField = value;
			}
		}
	}
}
