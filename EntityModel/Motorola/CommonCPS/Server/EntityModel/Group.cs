using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200004E RID: 78
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class Group : global::Motorola.CommonCPS.Server.EntityModel.IEntity
	{
		// Token: 0x0600063D RID: 1597 RVA: 0x000461E0 File Offset: 0x000443E0
		public Group()
		{
			this.Radios = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Radio>();
			this.Children = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Group>();
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x0600063E RID: 1598 RVA: 0x0004620C File Offset: 0x0004440C
		// (set) Token: 0x0600063F RID: 1599 RVA: 0x000462BC File Offset: 0x000444BC
		[global::System.Runtime.Serialization.DataMember]
		public string Name
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)682038324;
				short num2 = num;
				num = (short)106370100;
				switch (num2 == num)
				{
				}
				num = (short)268107776;
				short num3 = num;
				num = (short)907083777;
				if (num != 0)
				{
				}
				num = (short)2138701824;
				if (num != 0)
				{
				}
				return this.<Name>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)949157889;
				if (num != 0)
				{
				}
				num = (short)1219346476;
				short num2 = num;
				num = (short)1589559340;
				switch (num2 == num)
				{
				default:
				{
					num = (short)206372864;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1286668288;
				if (num != 0)
				{
				}
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000640 RID: 1600 RVA: 0x00046370 File Offset: 0x00044570
		// (set) Token: 0x06000641 RID: 1601 RVA: 0x00046424 File Offset: 0x00044624
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Radio> Radios
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1353039950;
				short num2 = num;
				num = (short)2074984526;
				switch (num2 == num)
				{
				}
				num = (short)1355743232;
				short num3 = num;
				num = (short)535298048;
				if (num != 0)
				{
				}
				num = (short)783351809;
				if (num != 0)
				{
				}
				return this.<Radios>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1843743514;
				short num2 = num;
				num = (short)1610042138;
				switch (num2 == num)
				{
				}
				num = (short)1716912128;
				short num3 = num;
				num = (short)1689387008;
				if (num != 0)
				{
				}
				num = (short)615514113;
				if (num != 0)
				{
				}
				this.<Radios>k__BackingField = value;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000642 RID: 1602 RVA: 0x000464D8 File Offset: 0x000446D8
		// (set) Token: 0x06000643 RID: 1603 RVA: 0x00046588 File Offset: 0x00044788
		[global::System.Runtime.Serialization.DataMember]
		public global::System.Guid? ParentUuid
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)566296577;
				if (num != 0)
				{
				}
				num = (short)666956958;
				short num2 = num;
				num = (short)1779627166;
				switch (num2 == num)
				{
				default:
				{
					num = (short)691601408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)770703360;
				if (num != 0)
				{
				}
				return this.<ParentUuid>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)820375331;
				short num2 = num;
				num = (short)2081550115;
				switch (num2 == num)
				{
				}
				num = (short)1124335616;
				short num3 = num;
				num = (short)786825216;
				if (num != 0)
				{
				}
				num = (short)1483800577;
				if (num != 0)
				{
				}
				this.<ParentUuid>k__BackingField = value;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x00046638 File Offset: 0x00044838
		// (set) Token: 0x06000645 RID: 1605 RVA: 0x000466F0 File Offset: 0x000448F0
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::Motorola.CommonCPS.Server.EntityModel.Group Parent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1242955777;
				if (num != 0)
				{
				}
				num = (short)1522052658;
				short num2 = num;
				num = (short)906210866;
				switch (num2 == num)
				{
				default:
				{
					num = (short)513212416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1082720256;
				if (num != 0)
				{
				}
				return this.<Parent>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2009702810;
				short num2 = num;
				num = (short)980984218;
				switch (num2 == num)
				{
				}
				num = (short)1488191488;
				short num3 = num;
				num = (short)1515520000;
				if (num != 0)
				{
				}
				num = (short)1171193857;
				if (num != 0)
				{
				}
				this.<Parent>k__BackingField = value;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000646 RID: 1606 RVA: 0x000467A0 File Offset: 0x000449A0
		// (set) Token: 0x06000647 RID: 1607 RVA: 0x00046850 File Offset: 0x00044A50
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.Group> Children
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)405842767;
				short num2 = num;
				num = (short)1694214991;
				switch (num2 == num)
				{
				}
				num = (short)1732050944;
				short num3 = num;
				num = (short)257490945;
				if (num != 0)
				{
				}
				num = (short)394919936;
				if (num != 0)
				{
				}
				return this.<Children>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)238565309;
				short num2 = num;
				num = (short)2087532477;
				switch (num2 == num)
				{
				}
				num = (short)732758016;
				if (num != 0)
				{
				}
				num = (short)1802895360;
				short num3 = num;
				num = (short)1239547905;
				if (num != 0)
				{
				}
				this.<Children>k__BackingField = value;
			}
		}
	}
}
