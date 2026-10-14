using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000061 RID: 97
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class MatrixOTAPKey : global::Motorola.CommonCPS.Server.EntityModel.MatrixKey
	{
		// Token: 0x0600078D RID: 1933 RVA: 0x00053FF0 File Offset: 0x000521F0
		public MatrixOTAPKey()
		{
			this.MatrixTemplates = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplate>();
		}

		// Token: 0x1700038C RID: 908
		// (get) Token: 0x0600078E RID: 1934 RVA: 0x00054010 File Offset: 0x00052210
		// (set) Token: 0x0600078F RID: 1935 RVA: 0x000540C0 File Offset: 0x000522C0
		[global::System.Runtime.Serialization.DataMember]
		public int Id
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1829969900;
				short num2 = num;
				num = (short)772939756;
				switch (num2 == num)
				{
				}
				num = (short)186580993;
				if (num != 0)
				{
				}
				num = (short)574291968;
				short num3 = num;
				num = (short)625868800;
				if (num != 0)
				{
				}
				return this.<Id>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1063023375;
				short num2 = num;
				num = (short)1938322191;
				switch (num2 == num)
				{
				}
				num = (short)620822529;
				if (num != 0)
				{
				}
				num = (short)1506869248;
				short num3 = num;
				num = (short)266797056;
				if (num != 0)
				{
				}
				this.<Id>k__BackingField = value;
			}
		}

		// Token: 0x1700038D RID: 909
		// (get) Token: 0x06000790 RID: 1936 RVA: 0x00054170 File Offset: 0x00052370
		// (set) Token: 0x06000791 RID: 1937 RVA: 0x0005421C File Offset: 0x0005241C
		[global::System.ComponentModel.DataAnnotations.Schema.NotMapped]
		[global::System.Runtime.Serialization.DataMember]
		public long? Value
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)363659265;
				if (num != 0)
				{
				}
				num = (short)776362930;
				short num2 = num;
				num = (short)168778674;
				switch (num2 == num)
				{
				}
				num = (short)1298333696;
				short num3 = num;
				num = (short)950730752;
				if (num != 0)
				{
				}
				return this.<Value>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)352175112;
				short num2 = num;
				num = (short)538690568;
				switch (num2 == num)
				{
				}
				num = (short)1723596801;
				if (num != 0)
				{
				}
				num = (short)2121072640;
				short num3 = num;
				num = (short)241893376;
				if (num != 0)
				{
				}
				this.<Value>k__BackingField = value;
			}
		}

		// Token: 0x1700038E RID: 910
		// (get) Token: 0x06000792 RID: 1938 RVA: 0x000542CC File Offset: 0x000524CC
		// (set) Token: 0x06000793 RID: 1939 RVA: 0x0005437C File Offset: 0x0005257C
		[global::System.Runtime.Serialization.DataMember]
		public string ValueEncrypt
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)502148752;
				short num2 = num;
				num = (short)1992699536;
				switch (num2 == num)
				{
				}
				num = (short)1310523393;
				if (num != 0)
				{
				}
				num = (short)304152576;
				short num3 = num;
				num = (short)643235840;
				if (num != 0)
				{
				}
				return this.<ValueEncrypt>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1492586339;
				short num2 = num;
				num = (short)572591971;
				switch (num2 == num)
				{
				}
				num = (short)1234960385;
				if (num != 0)
				{
				}
				num = (short)1451753472;
				short num3 = num;
				num = (short)1660420096;
				if (num != 0)
				{
				}
				this.<ValueEncrypt>k__BackingField = value;
			}
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x0005442C File Offset: 0x0005262C
		// (set) Token: 0x06000795 RID: 1941 RVA: 0x000544DC File Offset: 0x000526DC
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplate> MatrixTemplates
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)641152090;
				short num2 = num;
				num = (short)680735834;
				switch (num2 == num)
				{
				}
				num = (short)1408106496;
				if (num != 0)
				{
				}
				num = (short)64159744;
				short num3 = num;
				num = (short)314376193;
				if (num != 0)
				{
				}
				return this.<MatrixTemplates>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)83552383;
				short num2 = num;
				num = (short)1742071935;
				switch (num2 == num)
				{
				}
				num = (short)742850561;
				if (num != 0)
				{
				}
				num = (short)2030108672;
				short num3 = num;
				num = (short)1275920384;
				if (num != 0)
				{
				}
				this.<MatrixTemplates>k__BackingField = value;
			}
		}
	}
}
