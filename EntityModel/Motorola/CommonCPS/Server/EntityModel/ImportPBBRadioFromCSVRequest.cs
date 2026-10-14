using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000118 RID: 280
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class ImportPBBRadioFromCSVRequest : global::Motorola.CommonCPS.Server.EntityModel.ImportRadioFromCSVRequest
	{
		// Token: 0x1700076F RID: 1903
		// (get) Token: 0x06001066 RID: 4198 RVA: 0x000AFA5C File Offset: 0x000ADC5C
		// (set) Token: 0x06001067 RID: 4199 RVA: 0x000AFB14 File Offset: 0x000ADD14
		[global::Motorola.CommonCPS.Server.CommonDBConstants.EntityBelonging(global::Motorola.CommonCPS.Server.CommonDBConstants.EntityType.Radio)]
		[global::System.Runtime.Serialization.DataMember]
		public string ModelNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)799901580;
				short num2 = num;
				num = (short)1915848588;
				switch (num2 == num)
				{
				}
				num = (short)1110245376;
				short num3 = num;
				num = (short)2031419392;
				if (num != 0)
				{
				}
				num = (short)1680605185;
				if (num != 0)
				{
				}
				return this.<ModelNumber>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2030263475;
				short num2 = num;
				num = (short)1772772531;
				switch (num2 == num)
				{
				}
				num = (short)1841299456;
				short num3 = num;
				num = (short)1918042113;
				if (num != 0)
				{
				}
				num = (short)1013317632;
				if (num != 0)
				{
				}
				this.<ModelNumber>k__BackingField = value;
			}
		}

		// Token: 0x17000770 RID: 1904
		// (get) Token: 0x06001068 RID: 4200 RVA: 0x000AFBC4 File Offset: 0x000ADDC4
		// (set) Token: 0x06001069 RID: 4201 RVA: 0x000AFC74 File Offset: 0x000ADE74
		[global::Motorola.CommonCPS.Server.CommonDBConstants.EntityBelonging(global::Motorola.CommonCPS.Server.CommonDBConstants.EntityType.Radio)]
		[global::System.Runtime.Serialization.DataMember]
		public string IMEI
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)807831026;
				short num2 = num;
				num = (short)379160050;
				switch (num2 == num)
				{
				}
				num = (short)1432944640;
				short num3 = num;
				num = (short)1002766336;
				if (num != 0)
				{
				}
				num = (short)1288765441;
				if (num != 0)
				{
				}
				return this.<IMEI>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1123773408;
				short num2 = num;
				num = (short)7760864;
				switch (num2 == num)
				{
				}
				num = (short)1093337088;
				short num3 = num;
				num = (short)1376845825;
				if (num != 0)
				{
				}
				num = (short)396820480;
				if (num != 0)
				{
				}
				this.<IMEI>k__BackingField = value;
			}
		}

		// Token: 0x17000771 RID: 1905
		// (get) Token: 0x0600106A RID: 4202 RVA: 0x000AFD24 File Offset: 0x000ADF24
		// (set) Token: 0x0600106B RID: 4203 RVA: 0x000AFDD4 File Offset: 0x000ADFD4
		[global::System.Runtime.Serialization.DataMember]
		[global::Motorola.CommonCPS.Server.CommonDBConstants.EntityBelonging(global::Motorola.CommonCPS.Server.CommonDBConstants.EntityType.Radio)]
		public string ProductIdentifier
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)597696002;
				short num2 = num;
				num = (short)1186536962;
				switch (num2 == num)
				{
				}
				num = (short)1995571200;
				short num3 = num;
				num = (short)489553920;
				if (num != 0)
				{
				}
				num = (short)1308491777;
				if (num != 0)
				{
				}
				return this.<ProductIdentifier>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1662122213;
				short num2 = num;
				num = (short)1599731941;
				switch (num2 == num)
				{
				}
				num = (short)1266810880;
				short num3 = num;
				num = (short)669646849;
				if (num != 0)
				{
				}
				num = (short)1048969216;
				if (num != 0)
				{
				}
				this.<ProductIdentifier>k__BackingField = value;
			}
		}
	}
}
