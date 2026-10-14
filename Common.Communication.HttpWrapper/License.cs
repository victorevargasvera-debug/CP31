using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication
{
	// Token: 0x02000033 RID: 51
	[global::System.Runtime.Serialization.DataContract]
	public class License
	{
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000DB RID: 219 RVA: 0x0000BDB4 File Offset: 0x00009FB4
		// (set) Token: 0x060000DC RID: 220 RVA: 0x0000BE60 File Offset: 0x0000A060
		[global::System.Runtime.Serialization.DataMember]
		public string featureName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)604229883;
				short num2 = num;
				num = (short)1861079291;
				switch (num2 == num)
				{
				}
				num = (short)807141377;
				if (num != 0)
				{
				}
				num = (short)1319895040;
				if (num != 0)
				{
				}
				num = (short)255197184;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)349281998;
				short num2 = num;
				num = (short)1211473614;
				switch (num2 == num)
				{
				}
				num = (short)717225984;
				if (num != 0)
				{
				}
				num = (short)767950849;
				if (num != 0)
				{
				}
				num = (short)2083127296;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000BF14 File Offset: 0x0000A114
		public License(string name)
		{
			this.featureName = name;
		}

		// Token: 0x0400007A RID: 122
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;
	}
}
