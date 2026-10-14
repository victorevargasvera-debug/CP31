using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel.GenericModel;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020000A3 RID: 163
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class OptionDesItem
	{
		// Token: 0x06000C60 RID: 3168 RVA: 0x000850E4 File Offset: 0x000832E4
		private OptionDesItem()
		{
			this.Visible = true;
			this.OptionStatus = global::Motorola.CommonCPS.Server.CommonDBConstants.OptionStatusEnum.CFS_ENABLED;
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x00085108 File Offset: 0x00083308
		public OptionDesItem(string OptionTag, global::Motorola.CommonCPS.Server.EntityModel.GenericModel.OptionIDDefinition OptionID, global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily) : this()
		{
			this.OptionTag = OptionTag;
			this.OptionID = OptionID;
			this.OptionProductFamily = productFamily;
		}

		// Token: 0x170005D3 RID: 1491
		// (get) Token: 0x06000C62 RID: 3170 RVA: 0x00085130 File Offset: 0x00083330
		// (set) Token: 0x06000C63 RID: 3171 RVA: 0x000851E4 File Offset: 0x000833E4
		[global::System.Xml.Serialization.XmlAttribute("t")]
		[global::System.Runtime.Serialization.DataMember]
		public string OptionTag
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1901920256;
				short num2 = num;
				num = (short)231045313;
				short num3 = num;
				num = (short)2006612161;
				switch (num3 == num)
				{
				}
				num = (short)890830849;
				if (num != 0)
				{
				}
				num = (short)1735262208;
				if (num != 0)
				{
				}
				return this.<OptionTag>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1931476992;
				short num2 = num;
				num = (short)1847258948;
				short num3 = num;
				num = (short)2064052036;
				switch (num3 == num)
				{
				}
				num = (short)421134337;
				if (num != 0)
				{
				}
				num = (short)1623523328;
				if (num != 0)
				{
				}
				this.<OptionTag>k__BackingField = value;
			}
		}

		// Token: 0x170005D4 RID: 1492
		// (get) Token: 0x06000C64 RID: 3172 RVA: 0x00085294 File Offset: 0x00083494
		// (set) Token: 0x06000C65 RID: 3173 RVA: 0x00085340 File Offset: 0x00083540
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Xml.Serialization.XmlElement("ID")]
		public global::Motorola.CommonCPS.Server.EntityModel.GenericModel.OptionIDDefinition OptionID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)852164608;
				short num2 = num;
				num = (short)1859137404;
				short num3 = num;
				num = (short)8990588;
				switch (num3 == num)
				{
				}
				num = (short)847708161;
				if (num != 0)
				{
				}
				num = (short)409534464;
				if (num != 0)
				{
				}
				return this.<OptionID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)136314880;
				short num2 = num;
				num = (short)873632813;
				short num3 = num;
				num = (short)1095406637;
				switch (num3 == num)
				{
				}
				num = (short)497745920;
				if (num != 0)
				{
				}
				num = (short)1442316289;
				if (num != 0)
				{
				}
				this.<OptionID>k__BackingField = value;
			}
		}

		// Token: 0x170005D5 RID: 1493
		// (get) Token: 0x06000C66 RID: 3174 RVA: 0x000853F4 File Offset: 0x000835F4
		// (set) Token: 0x06000C67 RID: 3175 RVA: 0x000854A4 File Offset: 0x000836A4
		[global::System.Xml.Serialization.XmlIgnore]
		public global::Motorola.CommonCPS.Server.EntityModel.GenericModel.OptionIDDefinition ParentOptionID
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1321664512;
				short num2 = num;
				num = (short)1916365772;
				short num3 = num;
				num = (short)1691380684;
				switch (num3 == num)
				{
				}
				num = (short)1759903745;
				if (num != 0)
				{
				}
				num = (short)1294204928;
				if (num != 0)
				{
				}
				return this.<ParentOptionID>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1673461760;
				short num2 = num;
				num = (short)1196687361;
				if (num != 0)
				{
				}
				num = (short)380961694;
				short num3 = num;
				num = (short)686097310;
				switch (num3 == num)
				{
				}
				num = (short)501612544;
				if (num != 0)
				{
				}
				this.<ParentOptionID>k__BackingField = value;
			}
		}

		// Token: 0x170005D6 RID: 1494
		// (get) Token: 0x06000C68 RID: 3176 RVA: 0x00085554 File Offset: 0x00083754
		// (set) Token: 0x06000C69 RID: 3177 RVA: 0x00085600 File Offset: 0x00083800
		[global::System.Xml.Serialization.XmlAttribute("s")]
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.OptionStatusEnum OptionStatus
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)455933952;
				short num2 = num;
				num = (short)138171529;
				short num3 = num;
				num = (short)1841321097;
				switch (num3 == num)
				{
				}
				num = (short)1996226561;
				if (num != 0)
				{
				}
				num = (short)1899560960;
				if (num != 0)
				{
				}
				return this.<OptionStatus>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1525743616;
				short num2 = num;
				num = (short)1030692871;
				short num3 = num;
				num = (short)55123975;
				switch (num3 == num)
				{
				}
				num = (short)1959985153;
				if (num != 0)
				{
				}
				num = (short)34603008;
				if (num != 0)
				{
				}
				this.<OptionStatus>k__BackingField = value;
			}
		}

		// Token: 0x06000C6A RID: 3178 RVA: 0x000856B0 File Offset: 0x000838B0
		public bool ShouldSerializeOptionStatus()
		{
			short num = (short)1491140608;
			short num2 = num;
			num = (short)1797811668;
			short num3 = num;
			num = (short)1688235476;
			switch (num3 == num)
			{
			}
			num = (short)1905197057;
			if (num != 0)
			{
			}
			num = (short)561119232;
			if (num != 0)
			{
			}
			return this.OptionStatus != global::Motorola.CommonCPS.Server.CommonDBConstants.OptionStatusEnum.CFS_ENABLED;
		}

		// Token: 0x170005D7 RID: 1495
		// (get) Token: 0x06000C6B RID: 3179 RVA: 0x00085764 File Offset: 0x00083964
		// (set) Token: 0x06000C6C RID: 3180 RVA: 0x00085810 File Offset: 0x00083A10
		[global::System.Runtime.Serialization.DataMember]
		[global::System.Xml.Serialization.XmlAttribute("v")]
		public bool Visible
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2062090240;
				short num2 = num;
				num = (short)882688018;
				short num3 = num;
				num = (short)1110687762;
				switch (num3 == num)
				{
				}
				num = (short)693043201;
				if (num != 0)
				{
				}
				num = (short)1397161984;
				if (num != 0)
				{
				}
				return this.<Visible>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)949616640;
				short num2 = num;
				num = (short)680453238;
				short num3 = num;
				num = (short)240116854;
				switch (num3 == num)
				{
				}
				num = (short)149225473;
				if (num != 0)
				{
				}
				num = (short)2105475072;
				if (num != 0)
				{
				}
				this.<Visible>k__BackingField = value;
			}
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x000858C0 File Offset: 0x00083AC0
		public bool ShouldSerializeVisible()
		{
			short num = (short)409731072;
			short num2 = num;
			num = (short)1112539137;
			if (num != 0)
			{
			}
			num = (short)1388498188;
			short num3 = num;
			num = (short)926665996;
			switch (num3 == num)
			{
			}
			num = (short)1505296384;
			if (num != 0)
			{
			}
			return !this.Visible;
		}

		// Token: 0x170005D8 RID: 1496
		// (get) Token: 0x06000C6E RID: 3182 RVA: 0x00085974 File Offset: 0x00083B74
		// (set) Token: 0x06000C6F RID: 3183 RVA: 0x00085A24 File Offset: 0x00083C24
		[global::System.Xml.Serialization.XmlAttribute("f")]
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily OptionProductFamily
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1611399168;
				short num2 = num;
				num = (short)1040252929;
				if (num != 0)
				{
				}
				num = (short)654286914;
				short num3 = num;
				num = (short)1290772546;
				switch (num3 == num)
				{
				}
				num = (short)1556086784;
				if (num != 0)
				{
				}
				return this.<OptionProductFamily>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)12582912;
				short num2 = num;
				num = (short)413335553;
				if (num != 0)
				{
				}
				num = (short)1273033637;
				short num3 = num;
				num = (short)1938813861;
				switch (num3 == num)
				{
				}
				num = (short)880082944;
				if (num != 0)
				{
				}
				this.<OptionProductFamily>k__BackingField = value;
			}
		}

		// Token: 0x170005D9 RID: 1497
		// (get) Token: 0x06000C70 RID: 3184 RVA: 0x00085AD4 File Offset: 0x00083CD4
		[global::System.Xml.Serialization.XmlIgnore]
		public bool Editable
		{
			get
			{
				short num = (short)564920320;
				short num2 = num;
				num = (short)1776871485;
				short num3 = num;
				num = (short)1993664573;
				switch (num3 == num)
				{
				}
				num = (short)1974599680;
				if (num != 0)
				{
				}
				num = (short)121503745;
				if (num != 0)
				{
				}
				return this.OptionStatus != global::Motorola.CommonCPS.Server.CommonDBConstants.OptionStatusEnum.FREE;
			}
		}

		// Token: 0x170005DA RID: 1498
		// (get) Token: 0x06000C71 RID: 3185 RVA: 0x00085B8C File Offset: 0x00083D8C
		[global::System.Xml.Serialization.XmlIgnore]
		public bool IsActive
		{
			get
			{
				while (this.OptionStatus != global::Motorola.CommonCPS.Server.CommonDBConstants.OptionStatusEnum.FREE)
				{
					short num = (short)280138353;
					short num2 = num;
					num = (short)264213105;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						break;
					default:
					{
						num = (short)36372480;
						short num3 = num;
						break;
					}
					}
					num = (short)1925382144;
					if (num != 0)
					{
					}
					num = (short)1846935553;
					if (num != 0)
					{
					}
					return this.OptionStatus == global::Motorola.CommonCPS.Server.CommonDBConstants.OptionStatusEnum.CFS_ENABLED;
				}
				return true;
			}
		}
	}
}
