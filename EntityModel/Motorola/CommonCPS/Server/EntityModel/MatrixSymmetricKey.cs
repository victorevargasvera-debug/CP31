using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x02000067 RID: 103
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class MatrixSymmetricKey : global::Motorola.CommonCPS.Server.EntityModel.MatrixKey
	{
		// Token: 0x060007F9 RID: 2041 RVA: 0x000586D0 File Offset: 0x000568D0
		public MatrixSymmetricKey()
		{
			this.MatrixTemplates = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplate>();
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x000586F0 File Offset: 0x000568F0
		// (set) Token: 0x060007FB RID: 2043 RVA: 0x000587A0 File Offset: 0x000569A0
		[global::System.Runtime.Serialization.DataMember]
		public int Id
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1788898652;
				short num2 = num;
				num = (short)1519873372;
				switch (num2 == num)
				{
				}
				num = (short)132186112;
				if (num != 0)
				{
				}
				num = (short)300482561;
				if (num != 0)
				{
				}
				num = (short)335740928;
				short num3 = num;
				return this.<Id>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1525822197;
				short num2 = num;
				num = (short)475149045;
				switch (num2 == num)
				{
				}
				num = (short)1937440769;
				if (num != 0)
				{
				}
				num = (short)1978531840;
				if (num != 0)
				{
				}
				num = (short)55377920;
				short num3 = num;
				this.<Id>k__BackingField = value;
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x00058850 File Offset: 0x00056A50
		// (set) Token: 0x060007FD RID: 2045 RVA: 0x00058900 File Offset: 0x00056B00
		[global::System.ComponentModel.DataAnnotations.Schema.NotMapped]
		[global::System.Runtime.Serialization.DataMember]
		public string Value
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1388793577;
				short num2 = num;
				num = (short)1781157609;
				switch (num2 == num)
				{
				}
				num = (short)1597505537;
				if (num != 0)
				{
				}
				num = (short)1756233728;
				if (num != 0)
				{
				}
				num = (short)2090401792;
				short num3 = num;
				return this.<Value>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)537110900;
				short num2 = num;
				num = (short)757180788;
				switch (num2 == num)
				{
				}
				num = (short)920715265;
				if (num != 0)
				{
				}
				num = (short)808910848;
				if (num != 0)
				{
				}
				num = (short)667287552;
				short num3 = num;
				this.<Value>k__BackingField = value;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x000589B8 File Offset: 0x00056BB8
		// (set) Token: 0x060007FF RID: 2047 RVA: 0x00058A64 File Offset: 0x00056C64
		[global::System.Runtime.Serialization.DataMember]
		public string ValueEncrypt
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)435345359;
				short num2 = num;
				num = (short)1055578063;
				switch (num2 == num)
				{
				}
				num = (short)1212481537;
				if (num != 0)
				{
				}
				num = (short)1106640896;
				if (num != 0)
				{
				}
				num = (short)786300928;
				short num3 = num;
				return this.<ValueEncrypt>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1247849044;
				short num2 = num;
				num = (short)2020846164;
				switch (num2 == num)
				{
				}
				num = (short)3276801;
				if (num != 0)
				{
				}
				num = (short)2118647808;
				if (num != 0)
				{
				}
				num = (short)538509312;
				short num3 = num;
				this.<ValueEncrypt>k__BackingField = value;
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x00058B14 File Offset: 0x00056D14
		// (set) Token: 0x06000801 RID: 2049 RVA: 0x00058BC0 File Offset: 0x00056DC0
		[global::System.Runtime.Serialization.DataMember]
		public virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.MatrixTemplate> MatrixTemplates
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)32306890;
				short num2 = num;
				num = (short)2094397130;
				switch (num2 == num)
				{
				}
				num = (short)1236140033;
				if (num != 0)
				{
				}
				num = (short)222035968;
				if (num != 0)
				{
				}
				num = (short)342884352;
				short num3 = num;
				return this.<MatrixTemplates>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)69463758;
				short num2 = num;
				num = (short)1606872782;
				switch (num2 == num)
				{
				}
				num = (short)322633728;
				if (num != 0)
				{
				}
				num = (short)1695940609;
				if (num != 0)
				{
				}
				num = (short)2135621632;
				short num3 = num;
				this.<MatrixTemplates>k__BackingField = value;
			}
		}
	}
}
