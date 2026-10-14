using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels
{
	// Token: 0x020001E2 RID: 482
	[global::System.Serializable]
	public class DBUpgradeSet
	{
		// Token: 0x06001807 RID: 6151 RVA: 0x0010352C File Offset: 0x0010172C
		public DBUpgradeSet()
		{
			this.RelatedSets = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.DBUpgradeRelatedSets>();
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06001808 RID: 6152 RVA: 0x0010354C File Offset: 0x0010174C
		// (set) Token: 0x06001809 RID: 6153 RVA: 0x001035FC File Offset: 0x001017FC
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.DBNode MasterSet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)487294916;
				short num2 = num;
				num = (short)424445892;
				switch (num2 == num)
				{
				}
				num = (short)1437335552;
				if (num != 0)
				{
				}
				num = (short)22937601;
				if (num != 0)
				{
				}
				num = (short)591331328;
				short num3 = num;
				return this.<MasterSet>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)119660212;
				short num2 = num;
				num = (short)237100724;
				switch (num2 == num)
				{
				}
				num = (short)1319960577;
				if (num != 0)
				{
				}
				num = (short)1723793408;
				if (num != 0)
				{
				}
				num = (short)969932800;
				short num3 = num;
				this.<MasterSet>k__BackingField = value;
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x0600180A RID: 6154 RVA: 0x001036AC File Offset: 0x001018AC
		// (set) Token: 0x0600180B RID: 6155 RVA: 0x00103760 File Offset: 0x00101960
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.DBUpgradeRelatedSets> RelatedSets
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1310588929;
				if (num != 0)
				{
				}
				num = (short)382035780;
				short num2 = num;
				num = (short)1551787844;
				switch (num2 == num)
				{
				}
				num = (short)394592256;
				if (num != 0)
				{
				}
				num = (short)1662189568;
				short num3 = num;
				return this.<RelatedSets>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)43659742;
				short num2 = num;
				num = (short)1629303262;
				switch (num2 == num)
				{
				}
				num = (short)883228672;
				if (num != 0)
				{
				}
				num = (short)1687879681;
				if (num != 0)
				{
				}
				num = (short)191299584;
				short num3 = num;
				this.<RelatedSets>k__BackingField = value;
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x0600180C RID: 6156 RVA: 0x00103810 File Offset: 0x00101A10
		// (set) Token: 0x0600180D RID: 6157 RVA: 0x001038C0 File Offset: 0x00101AC0
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.BLVersion ToVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)758247350;
				short num2 = num;
				num = (short)1327886262;
				switch (num2 == num)
				{
				}
				num = (short)1278279681;
				if (num != 0)
				{
				}
				num = (short)1301807104;
				if (num != 0)
				{
				}
				num = (short)904658944;
				short num3 = num;
				return this.<ToVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)922903293;
				short num2 = num;
				num = (short)1072325373;
				switch (num2 == num)
				{
				}
				num = (short)2086338561;
				if (num != 0)
				{
				}
				num = (short)16580608;
				if (num != 0)
				{
				}
				num = (short)698875904;
				short num3 = num;
				this.<ToVersion>k__BackingField = value;
			}
		}
	}
}
