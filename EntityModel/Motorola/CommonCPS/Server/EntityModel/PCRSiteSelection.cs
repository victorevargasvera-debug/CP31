using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.EntityModel.DBNodeDataModels;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000085 RID: 133
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class PCRSiteSelection : global::Motorola.CommonCPS.Server.EntityModel.IEntity
	{
		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x0006DDF8 File Offset: 0x0006BFF8
		// (set) Token: 0x06000A2E RID: 2606 RVA: 0x0006DEA8 File Offset: 0x0006C0A8
		[global::System.Runtime.Serialization.DataMember]
		public string DMR3SystemUUID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1502485749;
				short num2 = num;
				num = (short)984947957;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1189675008;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1933246465;
				if (num != 0)
				{
				}
				num = (short)582549504;
				if (num != 0)
				{
				}
				return this.<DMR3SystemUUID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1734475777;
				if (num != 0)
				{
				}
				num = (short)1082064896;
				short num2 = num;
				num = (short)706838104;
				short num3 = num;
				num = (short)97615448;
				switch (num3 == num)
				{
				}
				num = (short)662568960;
				if (num != 0)
				{
				}
				this.<DMR3SystemUUID>k__BackingField = value;
			}
		}

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x0006DF5C File Offset: 0x0006C15C
		// (set) Token: 0x06000A30 RID: 2608 RVA: 0x0006E018 File Offset: 0x0006C218
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRSiteSelectionItem> PCRSiteSelectionItems
		{
			get
			{
				if (this.PCRDMR3SiteSelectionCmpBytes == null)
				{
					short num = (short)667589964;
					short num2 = num;
					num = (short)330669388;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_08;
					case 1:
						break;
					default:
					{
						num = (short)183894016;
						short num3 = num;
						break;
					}
					}
					num = (short)1999699969;
					if (num != 0)
					{
					}
					num = (short)1018560512;
					if (num != 0)
					{
					}
					return null;
				}
				IL_08:
				return global::Motorola.CommonCPS.Server.EntityModel.DBNodeDataModels.ConfigurationDataModelUtils.DeserializeAndUnzip<global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.PCRSiteSelectionItem>>(this.PCRDMR3SiteSelectionCmpBytes);
			}
			set
			{
				short num = (short)1075380225;
				if (num != 0)
				{
				}
				if (value == null)
				{
					num = (short)177602560;
					short num2 = num;
					num = (short)615780910;
					short num3 = num;
					num = (short)1759842862;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1695875072;
						if (num != 0)
						{
						}
						this.PCRDMR3SiteSelectionCmpBytes = null;
						return;
					}
				}
				this.PCRDMR3SiteSelectionCmpBytes = global::Motorola.CommonCPS.Server.EntityModel.DBNodeDataModels.ConfigurationDataModelUtils.SerializeAndZip(value);
			}
		}

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x0006E0DC File Offset: 0x0006C2DC
		// (set) Token: 0x06000A32 RID: 2610 RVA: 0x0006E18C File Offset: 0x0006C38C
		[global::System.Runtime.Serialization.DataMember]
		public byte[] PCRDMR3SiteSelectionCmpBytes
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1003692205;
				short num2 = num;
				num = (short)367599789;
				switch (num2 == num)
				{
				default:
				{
					num = (short)84213760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)744161281;
				if (num != 0)
				{
				}
				num = (short)1167523840;
				if (num != 0)
				{
				}
				return this.<PCRDMR3SiteSelectionCmpBytes>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)691929089;
				if (num != 0)
				{
				}
				num = (short)323038407;
				short num2 = num;
				num = (short)1756376263;
				switch (num2 == num)
				{
				default:
				{
					num = (short)341704704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)192413696;
				if (num != 0)
				{
				}
				this.<PCRDMR3SiteSelectionCmpBytes>k__BackingField = value;
			}
		}

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x0006E23C File Offset: 0x0006C43C
		// (set) Token: 0x06000A34 RID: 2612 RVA: 0x0006E2E8 File Offset: 0x0006C4E8
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? CodeplugUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1539333512;
				short num2 = num;
				num = (short)1897749896;
				switch (num2 == num)
				{
				}
				num = (short)829423616;
				short num3 = num;
				num = (short)1869414400;
				if (num != 0)
				{
				}
				num = (short)1357578241;
				if (num != 0)
				{
				}
				return this.<CodeplugUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)907087119;
				short num2 = num;
				num = (short)1306594575;
				switch (num2 == num)
				{
				}
				num = (short)1413021696;
				short num3 = num;
				num = (short)463667201;
				if (num != 0)
				{
				}
				num = (short)1497759744;
				if (num != 0)
				{
				}
				this.<CodeplugUuid>k__BackingField = value;
			}
		}

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06000A35 RID: 2613 RVA: 0x0006E39C File Offset: 0x0006C59C
		// (set) Token: 0x06000A36 RID: 2614 RVA: 0x0006E44C File Offset: 0x0006C64C
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::Motorola.CommonCPS.Server.EntityModel.MatrixCodeplug MatrixCodeplug
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1724941581;
				short num2 = num;
				num = (short)1754629389;
				switch (num2 == num)
				{
				}
				num = (short)1641152512;
				short num3 = num;
				num = (short)944046080;
				if (num != 0)
				{
				}
				num = (short)1583742977;
				if (num != 0)
				{
				}
				return this.<MatrixCodeplug>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2011661360;
				short num2 = num;
				num = (short)1606452272;
				switch (num2 == num)
				{
				}
				num = (short)314966016;
				short num3 = num;
				num = (short)1178796032;
				if (num != 0)
				{
				}
				num = (short)2039939073;
				if (num != 0)
				{
				}
				this.<MatrixCodeplug>k__BackingField = value;
			}
		}
	}
}
