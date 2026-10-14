using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication
{
	// Token: 0x02000038 RID: 56
	[global::System.Runtime.Serialization.DataContract]
	public class ReasonClass
	{
		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x0000CD8C File Offset: 0x0000AF8C
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x0000CE38 File Offset: 0x0000B038
		[global::System.Runtime.Serialization.DataMember]
		public int code
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)667615233;
				if (num != 0)
				{
				}
				num = (short)299391130;
				short num2 = num;
				num = (short)623532186;
				switch (num2 == num)
				{
				}
				num = (short)1888616448;
				if (num != 0)
				{
				}
				num = (short)870842368;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1454637057;
				if (num != 0)
				{
				}
				num = (short)50106118;
				short num2 = num;
				num = (short)897748742;
				switch (num2 == num)
				{
				}
				num = (short)2084241408;
				if (num != 0)
				{
				}
				num = (short)988348416;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x0000CEE4 File Offset: 0x0000B0E4
		// (set) Token: 0x060000F9 RID: 249 RVA: 0x0000CF90 File Offset: 0x0000B190
		[global::System.Runtime.Serialization.DataMember]
		public string message
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)157286401;
				if (num != 0)
				{
				}
				num = (short)1737214425;
				short num2 = num;
				num = (short)320457177;
				switch (num2 == num)
				{
				}
				num = (short)1871904768;
				if (num != 0)
				{
				}
				num = (short)1628962816;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1890279792;
				short num2 = num;
				num = (short)1756062064;
				switch (num2 == num)
				{
				}
				num = (short)461438977;
				if (num != 0)
				{
				}
				num = (short)628293632;
				if (num != 0)
				{
				}
				num = (short)1757282304;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000D040 File Offset: 0x0000B240
		public ReasonClass(int c, string msg)
		{
			this.code = c;
			this.message = msg;
		}

		// Token: 0x04000085 RID: 133
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int a;

		// Token: 0x04000086 RID: 134
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string b;
	}
}
