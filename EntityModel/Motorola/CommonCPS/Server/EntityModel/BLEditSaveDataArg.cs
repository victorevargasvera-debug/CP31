using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000ED RID: 237
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class BLEditSaveDataArg
	{
		// Token: 0x1700069C RID: 1692
		// (get) Token: 0x06000E54 RID: 3668 RVA: 0x000988F4 File Offset: 0x00096AF4
		// (set) Token: 0x06000E55 RID: 3669 RVA: 0x000989A4 File Offset: 0x00096BA4
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ChangeType ChangeType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1947598849;
				if (num != 0)
				{
				}
				num = (short)996779085;
				short num2 = num;
				num = (short)1921688653;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1985806336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1920270336;
				if (num != 0)
				{
				}
				return this.<ChangeType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2119757968;
				short num2 = num;
				num = (short)327413904;
				switch (num2 == num)
				{
				}
				num = (short)1654325248;
				short num3 = num;
				num = (short)687669249;
				if (num != 0)
				{
				}
				num = (short)1153564672;
				if (num != 0)
				{
				}
				this.<ChangeType>k__BackingField = value;
			}
		}

		// Token: 0x1700069D RID: 1693
		// (get) Token: 0x06000E56 RID: 3670 RVA: 0x00098A54 File Offset: 0x00096C54
		// (set) Token: 0x06000E57 RID: 3671 RVA: 0x00098B04 File Offset: 0x00096D04
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBUpdate> UpdatedRecords
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2096234713;
				short num2 = num;
				num = (short)330891481;
				switch (num2 == num)
				{
				}
				num = (short)439418880;
				short num3 = num;
				num = (short)427425793;
				if (num != 0)
				{
				}
				num = (short)1046937600;
				if (num != 0)
				{
				}
				return this.<UpdatedRecords>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2036497204;
				short num2 = num;
				num = (short)1924627252;
				switch (num2 == num)
				{
				}
				num = (short)1230569472;
				short num3 = num;
				num = (short)1949761537;
				if (num != 0)
				{
				}
				num = (short)708050944;
				if (num != 0)
				{
				}
				this.<UpdatedRecords>k__BackingField = value;
			}
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x06000E58 RID: 3672 RVA: 0x00098BB4 File Offset: 0x00096DB4
		// (set) Token: 0x06000E59 RID: 3673 RVA: 0x00098C68 File Offset: 0x00096E68
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RelationshipMap> RelationshipChanges
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)600073297;
				short num2 = num;
				num = (short)961242193;
				switch (num2 == num)
				{
				}
				num = (short)1684930560;
				short num3 = num;
				num = (short)60227585;
				if (num != 0)
				{
				}
				num = (short)202899456;
				if (num != 0)
				{
				}
				return this.<RelationshipChanges>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)475091111;
				short num2 = num;
				num = (short)1475891367;
				switch (num2 == num)
				{
				}
				num = (short)1567293440;
				short num3 = num;
				num = (short)956956673;
				if (num != 0)
				{
				}
				num = (short)1079443456;
				if (num != 0)
				{
				}
				this.<RelationshipChanges>k__BackingField = value;
			}
		}

		// Token: 0x1700069F RID: 1695
		// (get) Token: 0x06000E5A RID: 3674 RVA: 0x00098D18 File Offset: 0x00096F18
		// (set) Token: 0x06000E5B RID: 3675 RVA: 0x00098DC4 File Offset: 0x00096FC4
		[global::System.Xml.Serialization.XmlIgnore]
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SyncDataSourceRecordDataCarrier> SyncRecords
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)912638708;
				short num2 = num;
				num = (short)1904984820;
				switch (num2 == num)
				{
				}
				num = (short)457768960;
				short num3 = num;
				num = (short)1072562177;
				if (num != 0)
				{
				}
				num = (short)837746688;
				if (num != 0)
				{
				}
				return this.<SyncRecords>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1332126422;
				short num2 = num;
				num = (short)1409983190;
				switch (num2 == num)
				{
				}
				num = (short)2116747264;
				short num3 = num;
				num = (short)183304193;
				if (num != 0)
				{
				}
				num = (short)693108736;
				if (num != 0)
				{
				}
				this.<SyncRecords>k__BackingField = value;
			}
		}

		// Token: 0x170006A0 RID: 1696
		// (get) Token: 0x06000E5C RID: 3676 RVA: 0x00098E74 File Offset: 0x00097074
		// (set) Token: 0x06000E5D RID: 3677 RVA: 0x00098F24 File Offset: 0x00097124
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.DBNode ConfigurationRootNodeChanges
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)478811923;
				short num2 = num;
				num = (short)373364499;
				switch (num2 == num)
				{
				}
				num = (short)1194655744;
				short num3 = num;
				num = (short)1063256065;
				if (num != 0)
				{
				}
				num = (short)1875968000;
				if (num != 0)
				{
				}
				return this.<ConfigurationRootNodeChanges>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1663254202;
				short num2 = num;
				num = (short)1225539258;
				switch (num2 == num)
				{
				}
				num = (short)1369833472;
				short num3 = num;
				num = (short)513081345;
				if (num != 0)
				{
				}
				num = (short)1992884224;
				if (num != 0)
				{
				}
				this.<ConfigurationRootNodeChanges>k__BackingField = value;
			}
		}

		// Token: 0x170006A1 RID: 1697
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x00098FD8 File Offset: 0x000971D8
		// (set) Token: 0x06000E5F RID: 3679 RVA: 0x00099088 File Offset: 0x00097288
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.SyncData SyncData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1498064217;
				short num2 = num;
				num = (short)1297196377;
				switch (num2 == num)
				{
				}
				num = (short)1520500736;
				short num3 = num;
				num = (short)1627652097;
				if (num != 0)
				{
				}
				num = (short)2095120384;
				if (num != 0)
				{
				}
				return this.<SyncData>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1407557893;
				short num2 = num;
				num = (short)607428869;
				switch (num2 == num)
				{
				}
				num = (short)1386086400;
				short num3 = num;
				num = (short)1256521729;
				if (num != 0)
				{
				}
				num = (short)2088763392;
				if (num != 0)
				{
				}
				this.<SyncData>k__BackingField = value;
			}
		}

		// Token: 0x170006A2 RID: 1698
		// (get) Token: 0x06000E60 RID: 3680 RVA: 0x0009913C File Offset: 0x0009733C
		// (set) Token: 0x06000E61 RID: 3681 RVA: 0x000991F0 File Offset: 0x000973F0
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<string> AllChangesImpactedTopSetUuids
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)230913623;
				short num2 = num;
				num = (short)1556379223;
				switch (num2 == num)
				{
				}
				num = (short)1085865984;
				short num3 = num;
				num = (short)1271267328;
				if (num != 0)
				{
				}
				num = (short)585957377;
				if (num != 0)
				{
				}
				return this.<AllChangesImpactedTopSetUuids>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1092882033;
				short num2 = num;
				num = (short)20450929;
				switch (num2 == num)
				{
				}
				num = (short)1576468480;
				short num3 = num;
				num = (short)1441005568;
				if (num != 0)
				{
				}
				num = (short)118226945;
				if (num != 0)
				{
				}
				this.<AllChangesImpactedTopSetUuids>k__BackingField = value;
			}
		}

		// Token: 0x170006A3 RID: 1699
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x000992A4 File Offset: 0x000974A4
		// (set) Token: 0x06000E63 RID: 3683 RVA: 0x00099354 File Offset: 0x00097554
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary> ChangedAncestorRecordSumaries
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)445575306;
				short num2 = num;
				num = (short)747696266;
				switch (num2 == num)
				{
				}
				num = (short)1287192576;
				short num3 = num;
				num = (short)212926465;
				if (num != 0)
				{
				}
				num = (short)576847872;
				if (num != 0)
				{
				}
				return this.<ChangedAncestorRecordSumaries>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)802940889;
				short num2 = num;
				num = (short)1244522457;
				switch (num2 == num)
				{
				}
				num = (short)285081600;
				short num3 = num;
				num = (short)1783693313;
				if (num != 0)
				{
				}
				num = (short)1980760064;
				if (num != 0)
				{
				}
				this.<ChangedAncestorRecordSumaries>k__BackingField = value;
			}
		}

		// Token: 0x170006A4 RID: 1700
		// (get) Token: 0x06000E64 RID: 3684 RVA: 0x00099404 File Offset: 0x00097604
		// (set) Token: 0x06000E65 RID: 3685 RVA: 0x000994B4 File Offset: 0x000976B4
		[global::System.Runtime.Serialization.DataMember]
		public string CurrentConfigurationUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1263925549;
				short num2 = num;
				num = (short)545257773;
				switch (num2 == num)
				{
				}
				num = (short)1925840896;
				short num3 = num;
				num = (short)534183937;
				if (num != 0)
				{
				}
				num = (short)529858560;
				if (num != 0)
				{
				}
				return this.<CurrentConfigurationUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)134518938;
				short num2 = num;
				num = (short)1605343386;
				switch (num2 == num)
				{
				}
				num = (short)1726742528;
				short num3 = num;
				num = (short)1133641729;
				if (num != 0)
				{
				}
				num = (short)570884096;
				if (num != 0)
				{
				}
				this.<CurrentConfigurationUuid>k__BackingField = value;
			}
		}

		// Token: 0x170006A5 RID: 1701
		// (get) Token: 0x06000E66 RID: 3686 RVA: 0x00099564 File Offset: 0x00097764
		// (set) Token: 0x06000E67 RID: 3687 RVA: 0x00099618 File Offset: 0x00097818
		[global::System.Runtime.Serialization.DataMember]
		public byte[] RadioFlashcode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1671070798;
				short num2 = num;
				num = (short)1621001294;
				switch (num2 == num)
				{
				}
				num = (short)2138112000;
				short num3 = num;
				num = (short)1497104385;
				if (num != 0)
				{
				}
				num = (short)1997668352;
				if (num != 0)
				{
				}
				return this.<RadioFlashcode>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)450297857;
				if (num != 0)
				{
				}
				num = (short)1650819212;
				short num2 = num;
				num = (short)653820044;
				switch (num2 == num)
				{
				default:
				{
					num = (short)227803136;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1904345088;
				if (num != 0)
				{
				}
				this.<RadioFlashcode>k__BackingField = value;
			}
		}

		// Token: 0x170006A6 RID: 1702
		// (get) Token: 0x06000E68 RID: 3688 RVA: 0x000996CC File Offset: 0x000978CC
		// (set) Token: 0x06000E69 RID: 3689 RVA: 0x0009977C File Offset: 0x0009797C
		[global::System.Runtime.Serialization.DataMember]
		public string UsedPCIs
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1503395841;
				if (num != 0)
				{
				}
				num = (short)631783675;
				short num2 = num;
				num = (short)1365524731;
				switch (num2 == num)
				{
				default:
				{
					num = (short)735969280;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1572470784;
				if (num != 0)
				{
				}
				return this.<UsedPCIs>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1997340673;
				if (num != 0)
				{
				}
				num = (short)208793274;
				short num2 = num;
				num = (short)1901129402;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1510473728;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1679032320;
				if (num != 0)
				{
				}
				this.<UsedPCIs>k__BackingField = value;
			}
		}

		// Token: 0x170006A7 RID: 1703
		// (get) Token: 0x06000E6A RID: 3690 RVA: 0x0009982C File Offset: 0x00097A2C
		// (set) Token: 0x06000E6B RID: 3691 RVA: 0x000998DC File Offset: 0x00097ADC
		[global::System.Runtime.Serialization.DataMember]
		public bool UsedPCIsChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)757610934;
				short num2 = num;
				num = (short)1530935734;
				switch (num2 == num)
				{
				}
				num = (short)154337280;
				short num3 = num;
				num = (short)324206593;
				if (num != 0)
				{
				}
				num = (short)1702887424;
				if (num != 0)
				{
				}
				return this.<UsedPCIsChanged>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1115430587;
				short num2 = num;
				num = (short)1118183099;
				switch (num2 == num)
				{
				}
				num = (short)105775104;
				short num3 = num;
				num = (short)300941313;
				if (num != 0)
				{
				}
				num = (short)1716715520;
				if (num != 0)
				{
				}
				this.<UsedPCIsChanged>k__BackingField = value;
			}
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x00099990 File Offset: 0x00097B90
		public BLEditSaveDataArg()
		{
			this.<ChangeType>k__BackingField = global::Motorola.CommonCPS.Server.CommonDBConstants.ChangeType.Modify;
			base..ctor();
			this.AllChangesImpactedTopSetUuids = new global::System.Collections.Generic.List<string>();
			this.RelationshipChanges = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RelationshipMap>();
			this.UpdatedRecords = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBUpdate>();
			this.ChangedAncestorRecordSumaries = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RecordSummary>();
			this.SyncRecords = new global::System.Collections.Generic.Dictionary<global::System.Guid, global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.SyncDataSourceRecordDataCarrier>();
		}

		// Token: 0x170006A8 RID: 1704
		// (get) Token: 0x06000E6D RID: 3693 RVA: 0x000999E4 File Offset: 0x00097BE4
		// (set) Token: 0x06000E6E RID: 3694 RVA: 0x00099A98 File Offset: 0x00097C98
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid EditingRadioUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1586940198;
				short num2 = num;
				num = (short)910280998;
				switch (num2 == num)
				{
				}
				num = (short)489357312;
				if (num != 0)
				{
				}
				num = (short)1876426753;
				if (num != 0)
				{
				}
				num = (short)319160320;
				short num3 = num;
				return this.<EditingRadioUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1991770113;
				if (num != 0)
				{
				}
				num = (short)831100316;
				short num2 = num;
				num = (short)1480889756;
				switch (num2 == num)
				{
				}
				num = (short)919076864;
				if (num != 0)
				{
				}
				num = (short)1456799744;
				short num3 = num;
				this.<EditingRadioUuid>k__BackingField = value;
			}
		}
	}
}
