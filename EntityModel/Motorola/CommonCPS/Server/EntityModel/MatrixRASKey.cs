using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000066 RID: 102
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class MatrixRASKey : global::Motorola.CommonCPS.Server.EntityModel.MatrixKey
	{
		// Token: 0x060007F2 RID: 2034 RVA: 0x0005828C File Offset: 0x0005648C
		public MatrixRASKey()
		{
			this.MatrixTemplates = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplate>();
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x060007F3 RID: 2035 RVA: 0x000582AC File Offset: 0x000564AC
		// (set) Token: 0x060007F4 RID: 2036 RVA: 0x0005835C File Offset: 0x0005655C
		[global::System.Runtime.Serialization.DataMember]
		[global::System.ComponentModel.DataAnnotations.Schema.NotMapped]
		public string Value
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1461700358;
				short num2 = num;
				num = (short)1278068486;
				switch (num2 == num)
				{
				}
				num = (short)922157056;
				if (num != 0)
				{
				}
				num = (short)477888513;
				if (num != 0)
				{
				}
				num = (short)460062720;
				short num3 = num;
				return this.<Value>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)237305857;
				if (num != 0)
				{
				}
				num = (short)335695314;
				short num2 = num;
				num = (short)587091410;
				switch (num2 == num)
				{
				}
				num = (short)141623296;
				if (num != 0)
				{
				}
				num = (short)1609826304;
				short num3 = num;
				this.<Value>k__BackingField = value;
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x0005840C File Offset: 0x0005660C
		// (set) Token: 0x060007F6 RID: 2038 RVA: 0x000584BC File Offset: 0x000566BC
		[global::System.Runtime.Serialization.DataMember]
		public string ValueEncrypt
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1161720416;
				short num2 = num;
				num = (short)2027385440;
				switch (num2 == num)
				{
				}
				num = (short)996933633;
				if (num != 0)
				{
				}
				num = (short)1847328768;
				if (num != 0)
				{
				}
				num = (short)546701312;
				short num3 = num;
				return this.<ValueEncrypt>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)125925621;
				short num2 = num;
				num = (short)991787253;
				switch (num2 == num)
				{
				}
				num = (short)22937601;
				if (num != 0)
				{
				}
				num = (short)1157693440;
				if (num != 0)
				{
				}
				num = (short)144900096;
				short num3 = num;
				this.<ValueEncrypt>k__BackingField = value;
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x00058570 File Offset: 0x00056770
		// (set) Token: 0x060007F8 RID: 2040 RVA: 0x00058620 File Offset: 0x00056820
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplate> MatrixTemplates
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1775746378;
				short num2 = num;
				num = (short)1490926922;
				switch (num2 == num)
				{
				}
				num = (short)578158593;
				if (num != 0)
				{
				}
				num = (short)573505536;
				if (num != 0)
				{
				}
				num = (short)633798656;
				short num3 = num;
				return this.<MatrixTemplates>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1887682498;
				short num2 = num;
				num = (short)816431042;
				switch (num2 == num)
				{
				}
				num = (short)2047148032;
				if (num != 0)
				{
				}
				num = (short)1029963777;
				if (num != 0)
				{
				}
				num = (short)486801408;
				short num3 = num;
				this.<MatrixTemplates>k__BackingField = value;
			}
		}
	}
}
