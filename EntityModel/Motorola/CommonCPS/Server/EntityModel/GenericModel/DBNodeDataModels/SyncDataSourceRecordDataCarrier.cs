using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels
{
	// Token: 0x020001EC RID: 492
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class SyncDataSourceRecordDataCarrier : global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SyncDataSourceOfRecord
	{
		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x0600184A RID: 6218 RVA: 0x001069D0 File Offset: 0x00104BD0
		// (set) Token: 0x0600184B RID: 6219 RVA: 0x00106A80 File Offset: 0x00104C80
		[global::System.Runtime.Serialization.DataMember]
		public bool IsNeedSyncBLLData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)458498256;
				short num2 = num;
				num = (short)1139286224;
				switch (num2 == num)
				{
				}
				num = (short)261357568;
				short num3 = num;
				num = (short)1665269760;
				if (num != 0)
				{
				}
				num = (short)1694302209;
				if (num != 0)
				{
				}
				return this.<IsNeedSyncBLLData>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1559226998;
				short num2 = num;
				num = (short)842001014;
				switch (num2 == num)
				{
				}
				num = (short)164036608;
				short num3 = num;
				num = (short)1291059201;
				if (num != 0)
				{
				}
				num = (short)18808832;
				if (num != 0)
				{
				}
				this.<IsNeedSyncBLLData>k__BackingField = value;
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x0600184C RID: 6220 RVA: 0x00106B30 File Offset: 0x00104D30
		// (set) Token: 0x0600184D RID: 6221 RVA: 0x00106BDC File Offset: 0x00104DDC
		[global::System.Runtime.Serialization.DataMember]
		public bool IsNeedSyncHOptionData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2019020226;
				short num2 = num;
				num = (short)1250741698;
				switch (num2 == num)
				{
				}
				num = (short)1521221632;
				short num3 = num;
				num = (short)839843841;
				if (num != 0)
				{
				}
				num = (short)1474101248;
				if (num != 0)
				{
				}
				return this.<IsNeedSyncHOptionData>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)567877963;
				short num2 = num;
				num = (short)1584734539;
				switch (num2 == num)
				{
				}
				num = (short)501940224;
				short num3 = num;
				num = (short)742981632;
				if (num != 0)
				{
				}
				num = (short)1968177153;
				if (num != 0)
				{
				}
				this.<IsNeedSyncHOptionData>k__BackingField = value;
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x0600184E RID: 6222 RVA: 0x00106C90 File Offset: 0x00104E90
		// (set) Token: 0x0600184F RID: 6223 RVA: 0x00106D3C File Offset: 0x00104F3C
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.RecordModifier recordModifier
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1919287296;
				short num2 = num;
				num = (short)1636942012;
				short num3 = num;
				num = (short)1315225788;
				switch (num3 == num)
				{
				}
				num = (short)588840960;
				if (num != 0)
				{
				}
				num = (short)970129409;
				if (num != 0)
				{
				}
				return this.<recordModifier>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1953890304;
				short num2 = num;
				num = (short)1283391489;
				if (num != 0)
				{
				}
				num = (short)35415635;
				short num3 = num;
				num = (short)1990420051;
				switch (num3 == num)
				{
				}
				num = (short)1247215616;
				if (num != 0)
				{
				}
				this.<recordModifier>k__BackingField = value;
			}
		}

		// Token: 0x06001850 RID: 6224 RVA: 0x00106DEC File Offset: 0x00104FEC
		public global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SyncDataSourceOfRecord GetCarriedData()
		{
			short num = (short)1487273984;
			short num2 = num;
			num = (short)403797252;
			short num3 = num;
			num = (short)1977578756;
			switch (num3 == num)
			{
			}
			num = (short)1756495872;
			if (num != 0)
			{
			}
			num = (short)1588461569;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SyncDataSourceOfRecord
			{
				Uuid = base.Uuid,
				BLLSyncData = base.BLLSyncData,
				HOptionData = base.HOptionData,
				SyncDataReferChildUuids = base.SyncDataReferChildUuids,
				HoptionReferChildUuids = base.HoptionReferChildUuids,
				IsSkipForBLLSyncData = base.IsSkipForBLLSyncData,
				IsSkipForHOption = base.IsSkipForHOption
			};
		}
	}
}
