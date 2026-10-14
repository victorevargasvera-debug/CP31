using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000063 RID: 99
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class MatrixPrivacyKey : global::Motorola.CommonCPS.Server.EntityModel.MatrixKey
	{
		// Token: 0x0600079B RID: 1947 RVA: 0x00054864 File Offset: 0x00052A64
		public MatrixPrivacyKey()
		{
			this.MatrixTemplates = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplate>();
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x00054884 File Offset: 0x00052A84
		// (set) Token: 0x0600079D RID: 1949 RVA: 0x00054934 File Offset: 0x00052B34
		[global::System.Runtime.Serialization.DataMember]
		public int Id
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)427184533;
				short num2 = num;
				num = (short)184963477;
				switch (num2 == num)
				{
				}
				num = (short)1235943424;
				if (num != 0)
				{
				}
				num = (short)2058092544;
				short num3 = num;
				num = (short)374210561;
				if (num != 0)
				{
				}
				return this.<Id>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1531388722;
				short num2 = num;
				num = (short)1092166450;
				switch (num2 == num)
				{
				}
				num = (short)540934144;
				if (num != 0)
				{
				}
				num = (short)410845184;
				short num3 = num;
				num = (short)1367408641;
				if (num != 0)
				{
				}
				this.<Id>k__BackingField = value;
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x000549E4 File Offset: 0x00052BE4
		// (set) Token: 0x0600079F RID: 1951 RVA: 0x00054A94 File Offset: 0x00052C94
		[global::System.Runtime.Serialization.DataMember]
		[global::System.ComponentModel.DataAnnotations.Schema.NotMapped]
		public long? Value
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1515559622;
				short num2 = num;
				num = (short)1923324614;
				switch (num2 == num)
				{
				}
				num = (short)1167130625;
				if (num != 0)
				{
				}
				num = (short)413204480;
				short num3 = num;
				num = (short)717160448;
				if (num != 0)
				{
				}
				return this.<Value>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)56059428;
				short num2 = num;
				num = (short)527590948;
				switch (num2 == num)
				{
				}
				num = (short)240451585;
				if (num != 0)
				{
				}
				num = (short)255655936;
				short num3 = num;
				num = (short)1062600704;
				if (num != 0)
				{
				}
				this.<Value>k__BackingField = value;
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x060007A0 RID: 1952 RVA: 0x00054B48 File Offset: 0x00052D48
		// (set) Token: 0x060007A1 RID: 1953 RVA: 0x00054BF4 File Offset: 0x00052DF4
		[global::System.Runtime.Serialization.DataMember]
		public string ValueEncrypt
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)504954880;
				short num2 = num;
				num = (short)622526465;
				if (num != 0)
				{
				}
				num = (short)75645505;
				short num3 = num;
				num = (short)648626753;
				switch (num3 == num)
				{
				}
				num = (short)882442240;
				if (num != 0)
				{
				}
				return this.<ValueEncrypt>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1107165184;
				short num2 = num;
				num = (short)313196545;
				if (num != 0)
				{
				}
				num = (short)2077637038;
				short num3 = num;
				num = (short)1404123566;
				switch (num3 == num)
				{
				}
				num = (short)618725376;
				if (num != 0)
				{
				}
				this.<ValueEncrypt>k__BackingField = value;
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x060007A2 RID: 1954 RVA: 0x00054CA8 File Offset: 0x00052EA8
		// (set) Token: 0x060007A3 RID: 1955 RVA: 0x00054D58 File Offset: 0x00052F58
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplate> MatrixTemplates
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1399848960;
				short num2 = num;
				num = (short)463150691;
				short num3 = num;
				num = (short)901127779;
				switch (num3 == num)
				{
				}
				num = (short)1523712001;
				if (num != 0)
				{
				}
				num = (short)7667712;
				if (num != 0)
				{
				}
				return this.<MatrixTemplates>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1004535808;
				short num2 = num;
				num = (short)959701295;
				short num3 = num;
				num = (short)164487471;
				switch (num3 == num)
				{
				}
				num = (short)155320321;
				if (num != 0)
				{
				}
				num = (short)710737920;
				if (num != 0)
				{
				}
				this.<MatrixTemplates>k__BackingField = value;
			}
		}
	}
}
