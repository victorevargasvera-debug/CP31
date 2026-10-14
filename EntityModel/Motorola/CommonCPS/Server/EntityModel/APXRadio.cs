using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x0200002B RID: 43
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class APXRadio : global::Motorola.CommonCPS.Server.EntityModel.Radio
	{
		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060002EB RID: 747 RVA: 0x0002277C File Offset: 0x0002097C
		// (set) Token: 0x060002EC RID: 748 RVA: 0x0002282C File Offset: 0x00020A2C
		[global::System.Runtime.Serialization.DataMember]
		[global::System.ComponentModel.DataAnnotations.Schema.NotMapped]
		public string ReadPassword
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1047527424;
				short num2 = num;
				num = (short)906108126;
				short num3 = num;
				num = (short)151657694;
				switch (num3 == num)
				{
				}
				num = (short)1582891009;
				if (num != 0)
				{
				}
				num = (short)1759576064;
				if (num != 0)
				{
				}
				return this.<ReadPassword>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1937375232;
				short num2 = num;
				num = (short)1308614716;
				short num3 = num;
				num = (short)810410044;
				switch (num3 == num)
				{
				}
				num = (short)187891713;
				if (num != 0)
				{
				}
				num = (short)737148928;
				if (num != 0)
				{
				}
				this.<ReadPassword>k__BackingField = value;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060002ED RID: 749 RVA: 0x000228DC File Offset: 0x00020ADC
		// (set) Token: 0x060002EE RID: 750 RVA: 0x00022988 File Offset: 0x00020B88
		[global::System.Runtime.Serialization.DataMember]
		public string ReadPasswordEncrypt
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)922288128;
				short num2 = num;
				num = (short)1406200811;
				short num3 = num;
				num = (short)1448930283;
				switch (num3 == num)
				{
				}
				num = (short)903806976;
				if (num != 0)
				{
				}
				num = (short)247922689;
				if (num != 0)
				{
				}
				return this.<ReadPasswordEncrypt>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)332070912;
				short num2 = num;
				num = (short)565187626;
				short num3 = num;
				num = (short)1603474474;
				switch (num3 == num)
				{
				}
				num = (short)1323171841;
				if (num != 0)
				{
				}
				num = (short)1972043776;
				if (num != 0)
				{
				}
				this.<ReadPasswordEncrypt>k__BackingField = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060002EF RID: 751 RVA: 0x00022A3C File Offset: 0x00020C3C
		// (set) Token: 0x060002F0 RID: 752 RVA: 0x00022AEC File Offset: 0x00020CEC
		[global::System.Runtime.Serialization.DataMember]
		public string ForeignIP
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)767033344;
				short num2 = num;
				num = (short)1340127075;
				short num3 = num;
				num = (short)1609152355;
				switch (num3 == num)
				{
				}
				num = (short)1866399744;
				if (num != 0)
				{
				}
				num = (short)261619713;
				if (num != 0)
				{
				}
				return this.<ForeignIP>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1167851520;
				short num2 = num;
				num = (short)795710281;
				short num3 = num;
				num = (short)220697417;
				switch (num3 == num)
				{
				}
				num = (short)125304832;
				if (num != 0)
				{
				}
				num = (short)409600001;
				if (num != 0)
				{
				}
				this.<ForeignIP>k__BackingField = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x00022BA0 File Offset: 0x00020DA0
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x00022C50 File Offset: 0x00020E50
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.APXRadioType? APXRadioType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)802750464;
				short num2 = num;
				num = (short)856621057;
				if (num != 0)
				{
				}
				num = (short)2142028600;
				short num3 = num;
				num = (short)553894712;
				switch (num3 == num)
				{
				}
				num = (short)1459879936;
				if (num != 0)
				{
				}
				return this.<APXRadioType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1715535872;
				short num2 = num;
				num = (short)50811279;
				short num3 = num;
				num = (short)850022799;
				switch (num3 == num)
				{
				}
				num = (short)2054750209;
				if (num != 0)
				{
				}
				num = (short)740294656;
				if (num != 0)
				{
				}
				this.<APXRadioType>k__BackingField = value;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060002F3 RID: 755 RVA: 0x00022D04 File Offset: 0x00020F04
		// (set) Token: 0x060002F4 RID: 756 RVA: 0x00022DB0 File Offset: 0x00020FB0
		[global::System.Runtime.Serialization.DataMember]
		[global::System.ComponentModel.DataAnnotations.Schema.NotMapped]
		public string MaceSecureHardwareType
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)266403840;
				short num2 = num;
				num = (short)1388306785;
				short num3 = num;
				num = (short)1610015073;
				switch (num3 == num)
				{
				}
				num = (short)504102913;
				if (num != 0)
				{
				}
				num = (short)476250112;
				if (num != 0)
				{
				}
				return this.<MaceSecureHardwareType>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1897988096;
				short num2 = num;
				num = (short)1883592697;
				short num3 = num;
				num = (short)2100123641;
				switch (num3 == num)
				{
				}
				num = (short)1537277952;
				if (num != 0)
				{
				}
				num = (short)1491337217;
				if (num != 0)
				{
				}
				this.<MaceSecureHardwareType>k__BackingField = value;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x00022E60 File Offset: 0x00021060
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x00022F0C File Offset: 0x0002110C
		[global::System.Runtime.Serialization.DataMember]
		public string MaceSecureHardwareTypeEncrypt
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2001600512;
				short num2 = num;
				num = (short)2057270042;
				short num3 = num;
				num = (short)1603433242;
				switch (num3 == num)
				{
				}
				num = (short)345767937;
				if (num != 0)
				{
				}
				num = (short)238944256;
				if (num != 0)
				{
				}
				return this.<MaceSecureHardwareTypeEncrypt>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2123890688;
				short num2 = num;
				num = (short)1532821505;
				if (num != 0)
				{
				}
				num = (short)598916102;
				short num3 = num;
				num = (short)1571929094;
				switch (num3 == num)
				{
				}
				num = (short)931004416;
				if (num != 0)
				{
				}
				this.<MaceSecureHardwareTypeEncrypt>k__BackingField = value;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x00022FBC File Offset: 0x000211BC
		// (set) Token: 0x060002F8 RID: 760 RVA: 0x00023070 File Offset: 0x00021270
		[global::System.Runtime.Serialization.DataMember]
		public string MaceSecureHardwareVersion
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)672530432;
				short num2 = num;
				num = (short)1981980025;
				short num3 = num;
				num = (short)650747257;
				switch (num3 == num)
				{
				}
				num = (short)169607169;
				if (num != 0)
				{
				}
				num = (short)750059520;
				if (num != 0)
				{
				}
				return this.<MaceSecureHardwareVersion>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1247346688;
				short num2 = num;
				num = (short)1287361353;
				short num3 = num;
				num = (short)1603507017;
				switch (num3 == num)
				{
				}
				num = (short)1520631809;
				if (num != 0)
				{
				}
				num = (short)1763442688;
				if (num != 0)
				{
				}
				this.<MaceSecureHardwareVersion>k__BackingField = value;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x00023120 File Offset: 0x00021320
		// (set) Token: 0x060002FA RID: 762 RVA: 0x000231D4 File Offset: 0x000213D4
		[global::System.Runtime.Serialization.DataMember]
		public bool Provisioned
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1024131072;
				short num2 = num;
				num = (short)1897922561;
				if (num != 0)
				{
				}
				num = (short)716305946;
				short num3 = num;
				num = (short)880277018;
				switch (num3 == num)
				{
				}
				num = (short)1654915072;
				if (num != 0)
				{
				}
				return this.<Provisioned>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1699610624;
				short num2 = num;
				num = (short)1581022409;
				short num3 = num;
				num = (short)1511029961;
				switch (num3 == num)
				{
				}
				num = (short)2019164161;
				if (num != 0)
				{
				}
				num = (short)935198720;
				if (num != 0)
				{
				}
				this.<Provisioned>k__BackingField = value;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060002FB RID: 763 RVA: 0x00023284 File Offset: 0x00021484
		// (set) Token: 0x060002FC RID: 764 RVA: 0x00023330 File Offset: 0x00021530
		[global::System.Runtime.Serialization.DataMember]
		public bool UseDefaultPSK
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1745354752;
				short num2 = num;
				num = (short)1626116111;
				short num3 = num;
				num = (short)824283151;
				switch (num3 == num)
				{
				}
				num = (short)1376059393;
				if (num != 0)
				{
				}
				num = (short)1620377600;
				if (num != 0)
				{
				}
				return this.<UseDefaultPSK>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1362690048;
				short num2 = num;
				num = (short)1077767273;
				short num3 = num;
				num = (short)1701604457;
				switch (num3 == num)
				{
				}
				num = (short)766771200;
				if (num != 0)
				{
				}
				num = (short)1710424065;
				if (num != 0)
				{
				}
				this.<UseDefaultPSK>k__BackingField = value;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060002FD RID: 765 RVA: 0x000233E0 File Offset: 0x000215E0
		// (set) Token: 0x060002FE RID: 766 RVA: 0x00023490 File Offset: 0x00021690
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::Motorola.CommonCPS.Server.EntityModel.RadioActivityData ActivityData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1726939136;
				short num2 = num;
				num = (short)1752564969;
				short num3 = num;
				num = (short)304940265;
				switch (num3 == num)
				{
				}
				num = (short)104923136;
				if (num != 0)
				{
				}
				num = (short)1539244033;
				if (num != 0)
				{
				}
				return this.<ActivityData>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1168703488;
				short num2 = num;
				num = (short)981072703;
				short num3 = num;
				num = (short)1034615615;
				switch (num3 == num)
				{
				}
				num = (short)1727528961;
				if (num != 0)
				{
				}
				num = (short)1751646208;
				if (num != 0)
				{
				}
				this.<ActivityData>k__BackingField = value;
			}
		}
	}
}
