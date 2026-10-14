using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000137 RID: 311
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class ClearDataProgressReport
	{
		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x060011EE RID: 4590 RVA: 0x000BF928 File Offset: 0x000BDB28
		// (set) Token: 0x060011EF RID: 4591 RVA: 0x000BF9D8 File Offset: 0x000BDBD8
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ClearDataStatus CurrentStatus
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)80150528;
				short num2 = num;
				num = (short)144441345;
				if (num != 0)
				{
				}
				num = (short)1930865752;
				short num3 = num;
				num = (short)1323936856;
				switch (num3 == num)
				{
				}
				num = (short)714997760;
				if (num != 0)
				{
				}
				return this.<CurrentStatus>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1117126656;
				short num2 = num;
				num = (short)1429676610;
				short num3 = num;
				num = (short)709632578;
				switch (num3 == num)
				{
				}
				num = (short)1973026816;
				if (num != 0)
				{
				}
				num = (short)803799041;
				if (num != 0)
				{
				}
				this.<CurrentStatus>k__BackingField = value;
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x060011F0 RID: 4592 RVA: 0x000BFA88 File Offset: 0x000BDC88
		// (set) Token: 0x060011F1 RID: 4593 RVA: 0x000BFB34 File Offset: 0x000BDD34
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ClearDataInfo> ProgressList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)946929664;
				short num2 = num;
				num = (short)2020979281;
				short num3 = num;
				num = (short)613724753;
				switch (num3 == num)
				{
				}
				num = (short)1040056321;
				if (num != 0)
				{
				}
				num = (short)41287680;
				if (num != 0)
				{
				}
				return this.<ProgressList>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)417923072;
				short num2 = num;
				num = (short)1288669605;
				short num3 = num;
				num = (short)1434290597;
				switch (num3 == num)
				{
				}
				num = (short)1366032384;
				if (num != 0)
				{
				}
				num = (short)702152705;
				if (num != 0)
				{
				}
				this.<ProgressList>k__BackingField = value;
			}
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x000BFBE4 File Offset: 0x000BDDE4
		public ClearDataProgressReport()
		{
			this.CurrentStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.ClearDataStatus.NOT_START;
			this.ProgressList = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ClearDataInfo>();
		}
	}
}
