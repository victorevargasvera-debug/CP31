using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel.CallBacks
{
	// Token: 0x02000201 RID: 513
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class DBMigrationProgress
	{
		// Token: 0x06001922 RID: 6434 RVA: 0x0010F51C File Offset: 0x0010D71C
		public DBMigrationProgress()
		{
			this.TotalCount = 0;
			this.FinishedCount = 0;
		}

		// Token: 0x17000B1A RID: 2842
		// (get) Token: 0x06001923 RID: 6435 RVA: 0x0010F540 File Offset: 0x0010D740
		// (set) Token: 0x06001924 RID: 6436 RVA: 0x0010F5F4 File Offset: 0x0010D7F4
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.JobType MigrationType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)600398264;
				short num2 = num;
				num = (short)933255608;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1716518912;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)812580865;
				if (num != 0)
				{
				}
				num = (short)880017408;
				if (num != 0)
				{
				}
				return this.<MigrationType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1701243738;
				short num2 = num;
				num = (short)475655002;
				switch (num2 == num)
				{
				default:
				{
					num = (short)786432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2064252929;
				if (num != 0)
				{
				}
				num = (short)1414004736;
				if (num != 0)
				{
				}
				this.<MigrationType>k__BackingField = value;
			}
		}

		// Token: 0x17000B1B RID: 2843
		// (get) Token: 0x06001925 RID: 6437 RVA: 0x0010F6A8 File Offset: 0x0010D8A8
		// (set) Token: 0x06001926 RID: 6438 RVA: 0x0010F758 File Offset: 0x0010D958
		[global::System.Runtime.Serialization.DataMember]
		public int TotalCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2016836628;
				short num2 = num;
				num = (short)1985772564;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1795817472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)366673920;
				if (num != 0)
				{
				}
				num = (short)172425217;
				if (num != 0)
				{
				}
				return this.<TotalCount>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1274319661;
				short num2 = num;
				num = (short)1599902509;
				switch (num2 == num)
				{
				default:
				{
					num = (short)137953280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)82247681;
				if (num != 0)
				{
				}
				num = (short)1679294464;
				if (num != 0)
				{
				}
				this.<TotalCount>k__BackingField = value;
			}
		}

		// Token: 0x17000B1C RID: 2844
		// (get) Token: 0x06001927 RID: 6439 RVA: 0x0010F80C File Offset: 0x0010DA0C
		// (set) Token: 0x06001928 RID: 6440 RVA: 0x0010F8BC File Offset: 0x0010DABC
		[global::System.Runtime.Serialization.DataMember]
		public int FinishedCount
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2102004638;
				short num2 = num;
				num = (short)2011827102;
				switch (num2 == num)
				{
				default:
				{
					num = (short)611909632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2038890497;
				if (num != 0)
				{
				}
				num = (short)1603600384;
				if (num != 0)
				{
				}
				return this.<FinishedCount>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)259784705;
				if (num != 0)
				{
				}
				num = (short)1352663040;
				short num2 = num;
				num = (short)1123748924;
				short num3 = num;
				num = (short)1967328316;
				switch (num3 == num)
				{
				}
				num = (short)422510592;
				if (num != 0)
				{
				}
				this.<FinishedCount>k__BackingField = value;
			}
		}

		// Token: 0x17000B1D RID: 2845
		// (get) Token: 0x06001929 RID: 6441 RVA: 0x0010F96C File Offset: 0x0010DB6C
		// (set) Token: 0x0600192A RID: 6442 RVA: 0x0010FA1C File Offset: 0x0010DC1C
		[global::System.Runtime.Serialization.DataMember]
		public string CurrentItemDescription
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2091759724;
				short num2 = num;
				num = (short)804960364;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1735131136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)126812160;
				if (num != 0)
				{
				}
				num = (short)1980891137;
				if (num != 0)
				{
				}
				return this.<CurrentItemDescription>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)323485697;
				if (num != 0)
				{
				}
				num = (short)1784479744;
				short num2 = num;
				num = (short)618837364;
				short num3 = num;
				num = (short)8238452;
				switch (num3 == num)
				{
				}
				num = (short)887881728;
				if (num != 0)
				{
				}
				this.<CurrentItemDescription>k__BackingField = value;
			}
		}

		// Token: 0x17000B1E RID: 2846
		// (get) Token: 0x0600192B RID: 6443 RVA: 0x0010FACC File Offset: 0x0010DCCC
		// (set) Token: 0x0600192C RID: 6444 RVA: 0x0010FB7C File Offset: 0x0010DD7C
		[global::System.Runtime.Serialization.DataMember]
		public bool IsCurrentItemSuccess
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)637009921;
				if (num != 0)
				{
				}
				num = (short)1507983360;
				short num2 = num;
				num = (short)1231317187;
				short num3 = num;
				num = (short)964913347;
				switch (num3 == num)
				{
				}
				num = (short)1330642944;
				if (num != 0)
				{
				}
				return this.<IsCurrentItemSuccess>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1136066561;
				if (num != 0)
				{
				}
				num = (short)645005312;
				short num2 = num;
				num = (short)1396976207;
				short num3 = num;
				num = (short)1582574159;
				switch (num3 == num)
				{
				}
				num = (short)1890516992;
				if (num != 0)
				{
				}
				this.<IsCurrentItemSuccess>k__BackingField = value;
			}
		}

		// Token: 0x0600192D RID: 6445 RVA: 0x0010FC2C File Offset: 0x0010DE2C
		public global::Motorola.CommonCPS.Server.EntityModel.CallBacks.DBMigrationProgress Clone()
		{
			short num = (short)1844267272;
			short num2 = num;
			num = (short)669731080;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1764884480;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)873463809;
			if (num != 0)
			{
			}
			num = (short)2054488064;
			if (num != 0)
			{
			}
			return base.MemberwiseClone() as global::Motorola.CommonCPS.Server.EntityModel.CallBacks.DBMigrationProgress;
		}
	}
}
