using System;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000055 RID: 85
	public class MigrationJob : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
	{
		// Token: 0x0600025B RID: 603 RVA: 0x000248D8 File Offset: 0x00022AD8
		public MigrationJob(global::Motorola.CommonCPS.RadioManagement.UIModels.OpJob job)
		{
			this.a = job;
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x0600025C RID: 604 RVA: 0x000248F4 File Offset: 0x00022AF4
		public override global::System.Guid? ID
		{
			get
			{
				short num = (short)1332894337;
				short num2 = num;
				num = (short)1680824961;
				switch (num2 == num)
				{
				}
				num = (short)1633091584;
				if (num != 0)
				{
				}
				num = (short)1834942465;
				if (num != 0)
				{
				}
				num = (short)623771648;
				short num3 = num;
				return this.a.ID;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x0600025D RID: 605 RVA: 0x000249AC File Offset: 0x00022BAC
		public string Name
		{
			get
			{
				short num = (short)794879279;
				short num2 = num;
				num = (short)186180911;
				switch (num2 == num)
				{
				}
				num = (short)1040384001;
				if (num != 0)
				{
				}
				num = (short)1332674560;
				if (num != 0)
				{
				}
				num = (short)1569914880;
				short num3 = num;
				return this.a.Name;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x0600025E RID: 606 RVA: 0x00024A60 File Offset: 0x00022C60
		public global::Motorola.CommonCPS.Server.CommonDBConstants.JobType JobType
		{
			get
			{
				short num = (short)990838243;
				short num2 = num;
				num = (short)1619262947;
				switch (num2 == num)
				{
				}
				num = (short)316014592;
				if (num != 0)
				{
				}
				num = (short)893648897;
				if (num != 0)
				{
				}
				num = (short)291504128;
				short num3 = num;
				return this.a.JobType.Value;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x0600025F RID: 607 RVA: 0x00024B1C File Offset: 0x00022D1C
		public global::System.Guid? JobContainerUuid
		{
			get
			{
				short num = (short)1293811713;
				if (num != 0)
				{
				}
				num = (short)1017501897;
				short num2 = num;
				num = (short)1662769353;
				switch (num2 == num)
				{
				}
				num = (short)2103246848;
				if (num != 0)
				{
				}
				num = (short)957415424;
				short num3 = num;
				return this.a.JobContainerSummaryUUID;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000260 RID: 608 RVA: 0x00024BD0 File Offset: 0x00022DD0
		public bool IsJobPerformed
		{
			get
			{
				short num = (short)1475180251;
				short num2 = num;
				num = (short)1012102875;
				switch (num2 == num)
				{
				}
				num = (short)1629028353;
				if (num != 0)
				{
				}
				num = (short)91095040;
				if (num != 0)
				{
				}
				num = (short)1927282688;
				short num3 = num;
				global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus? uijobStatus = this.a.UIJobStatus;
				global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus uijobStatus2 = global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus.Performed;
				return uijobStatus.GetValueOrDefault() == uijobStatus2 & uijobStatus != null;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000261 RID: 609 RVA: 0x00024C9C File Offset: 0x00022E9C
		public string UIStatusDisplay
		{
			get
			{
				short num = (short)1534851570;
				short num2 = num;
				num = (short)1223752178;
				switch (num2 == num)
				{
				}
				num = (short)985202689;
				if (num != 0)
				{
				}
				num = (short)968753152;
				if (num != 0)
				{
				}
				num = (short)1868431360;
				short num3 = num;
				return this.a.UIJobStatus.ToString();
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x06000262 RID: 610 RVA: 0x00024D60 File Offset: 0x00022F60
		public string ErrorCode
		{
			get
			{
				short num = (short)488506992;
				short num2 = num;
				num = (short)546309744;
				switch (num2 == num)
				{
				}
				num = (short)1513553920;
				if (num != 0)
				{
				}
				num = (short)153288705;
				if (num != 0)
				{
				}
				num = (short)387973120;
				short num3 = num;
				return this.a.ErrorCode;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x06000263 RID: 611 RVA: 0x00024E18 File Offset: 0x00023018
		public string Reason
		{
			get
			{
				short num = (short)877853190;
				short num2 = num;
				num = (short)1866660358;
				switch (num2 == num)
				{
				}
				num = (short)1417281537;
				if (num != 0)
				{
				}
				num = (short)1819541504;
				if (num != 0)
				{
				}
				num = (short)1348206592;
				short num3 = num;
				return this.a.Reason;
			}
		}

		// Token: 0x040000FF RID: 255
		private global::Motorola.CommonCPS.RadioManagement.UIModels.OpJob a;
	}
}
