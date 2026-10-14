using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.EntityModel.DBNodeDataModels;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000045 RID: 69
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class DBNodeUpdateDataSource
	{
		// Token: 0x060005ED RID: 1517 RVA: 0x00042AB4 File Offset: 0x00040CB4
		public DBNodeUpdateDataSource()
		{
			this.Uuid = global::System.Guid.NewGuid();
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x060005EE RID: 1518 RVA: 0x00042AD4 File Offset: 0x00040CD4
		// (set) Token: 0x060005EF RID: 1519 RVA: 0x00042B84 File Offset: 0x00040D84
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid Uuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1126008770;
				short num2 = num;
				num = (short)1339590594;
				switch (num2 == num)
				{
				}
				num = (short)451543041;
				if (num != 0)
				{
				}
				num = (short)1719074816;
				short num3 = num;
				num = (short)2136014848;
				if (num != 0)
				{
				}
				return this.<Uuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)923860993;
				if (num != 0)
				{
				}
				num = (short)1809600882;
				short num2 = num;
				num = (short)1076515186;
				switch (num2 == num)
				{
				}
				num = (short)1846738944;
				short num3 = num;
				num = (short)1158283264;
				if (num != 0)
				{
				}
				this.<Uuid>k__BackingField = value;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x060005F0 RID: 1520 RVA: 0x00042C38 File Offset: 0x00040E38
		// (set) Token: 0x060005F1 RID: 1521 RVA: 0x00042CE8 File Offset: 0x00040EE8
		[global::System.Runtime.Serialization.DataMember]
		public byte[] ChangedDataBytes
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1720257853;
				short num2 = num;
				num = (short)1266224445;
				switch (num2 == num)
				{
				}
				num = (short)710279168;
				if (num != 0)
				{
				}
				num = (short)1746599936;
				short num3 = num;
				num = (short)1845559297;
				if (num != 0)
				{
				}
				return this.<ChangedDataBytes>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1038120729;
				short num2 = num;
				num = (short)961509145;
				switch (num2 == num)
				{
				}
				num = (short)1088749568;
				if (num != 0)
				{
				}
				num = (short)1923088384;
				short num3 = num;
				num = (short)640090113;
				if (num != 0)
				{
				}
				this.<ChangedDataBytes>k__BackingField = value;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x060005F2 RID: 1522 RVA: 0x00042D98 File Offset: 0x00040F98
		// (set) Token: 0x060005F3 RID: 1523 RVA: 0x00042E58 File Offset: 0x00041058
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.ChangedData ChangedData
		{
			get
			{
				if (this.ChangedDataBytes == null)
				{
					short num = (short)900661249;
					if (num != 0)
					{
					}
					num = (short)740999970;
					short num2 = num;
					num = (short)1696318242;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_0A;
					case 1:
						break;
					default:
					{
						num = (short)1606549504;
						short num3 = num;
						break;
					}
					}
					num = (short)1109917696;
					if (num != 0)
					{
					}
					return null;
				}
				IL_0A:
				return global::Motorola.CommonCPS.Server.EntityModel.DBNodeDataModels.ConfigurationDataModelUtils.DeserializeAndUnzip<global::Motorola.CommonCPS.Server.EntityModel.ChangedData>(this.ChangedDataBytes);
			}
			set
			{
				if (value == null)
				{
					short num = (short)607432005;
					short num2 = num;
					num = (short)957001029;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)604372992;
						short num3 = num;
						num = (short)2117402624;
						if (num != 0)
						{
						}
						num = (short)1262682113;
						if (num != 0)
						{
						}
						this.ChangedDataBytes = null;
						return;
					}
					}
				}
				this.ChangedDataBytes = global::Motorola.CommonCPS.Server.EntityModel.DBNodeDataModels.ConfigurationDataModelUtils.SerializeAndZip(value);
			}
		}
	}
}
