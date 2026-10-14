using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels
{
	// Token: 0x020001E0 RID: 480
	[global::System.Serializable]
	public class DBUpgradeResolverSetRequest
	{
		// Token: 0x060017FB RID: 6139 RVA: 0x00102E08 File Offset: 0x00101008
		public DBUpgradeResolverSetRequest()
		{
			this.Relationship = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.DBResolverRelationship>();
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x060017FC RID: 6140 RVA: 0x00102E28 File Offset: 0x00101028
		// (set) Token: 0x060017FD RID: 6141 RVA: 0x00102ED4 File Offset: 0x001010D4
		[global::System.Runtime.Serialization.DataMember]
		public string MasterSetType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1774696724;
				short num2 = num;
				num = (short)1082767636;
				switch (num2 == num)
				{
				}
				num = (short)263323648;
				if (num != 0)
				{
				}
				num = (short)1482358785;
				if (num != 0)
				{
				}
				num = (short)630259712;
				short num3 = num;
				return this.<MasterSetType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)572140427;
				short num2 = num;
				num = (short)1565928331;
				switch (num2 == num)
				{
				}
				num = (short)1569718273;
				if (num != 0)
				{
				}
				num = (short)662896640;
				if (num != 0)
				{
				}
				num = (short)1185546240;
				short num3 = num;
				this.<MasterSetType>k__BackingField = value;
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x060017FE RID: 6142 RVA: 0x00102F88 File Offset: 0x00101188
		// (set) Token: 0x060017FF RID: 6143 RVA: 0x00103038 File Offset: 0x00101238
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.BLVersion ToVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)958843533;
				short num2 = num;
				num = (short)1743309453;
				switch (num2 == num)
				{
				}
				num = (short)353828864;
				if (num != 0)
				{
				}
				num = (short)1016004609;
				if (num != 0)
				{
				}
				num = (short)693960704;
				short num3 = num;
				return this.<ToVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1337768110;
				short num2 = num;
				num = (short)1307949230;
				switch (num2 == num)
				{
				}
				num = (short)1132920833;
				if (num != 0)
				{
				}
				num = (short)59768832;
				if (num != 0)
				{
				}
				num = (short)726859776;
				short num3 = num;
				this.<ToVersion>k__BackingField = value;
			}
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06001800 RID: 6144 RVA: 0x001030EC File Offset: 0x001012EC
		// (set) Token: 0x06001801 RID: 6145 RVA: 0x0010319C File Offset: 0x0010139C
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.GenericModel.DBNodeDataModels.DBResolverRelationship> Relationship
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)880567478;
				short num2 = num;
				num = (short)525558966;
				switch (num2 == num)
				{
				}
				num = (short)577044481;
				if (num != 0)
				{
				}
				num = (short)1536950272;
				if (num != 0)
				{
				}
				num = (short)1894645760;
				short num3 = num;
				return this.<Relationship>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1801311825;
				short num2 = num;
				num = (short)2112018001;
				switch (num2 == num)
				{
				}
				num = (short)599916545;
				if (num != 0)
				{
				}
				num = (short)386924544;
				if (num != 0)
				{
				}
				num = (short)502988800;
				short num3 = num;
				this.<Relationship>k__BackingField = value;
			}
		}
	}
}
