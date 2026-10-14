using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication
{
	// Token: 0x02000032 RID: 50
	[global::System.Runtime.Serialization.DataContract]
	public class UELog
	{
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x0000BC3C File Offset: 0x00009E3C
		// (set) Token: 0x060000D9 RID: 217 RVA: 0x0000BCE8 File Offset: 0x00009EE8
		[global::System.Runtime.Serialization.DataMember]
		public string fileName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1173572011;
				short num2 = num;
				num = (short)1917536683;
				switch (num2 == num)
				{
				}
				num = (short)2012741633;
				if (num != 0)
				{
				}
				num = (short)1114701824;
				if (num != 0)
				{
				}
				num = (short)261357568;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)503330688;
				short num2 = num;
				num = (short)1576548224;
				switch (num2 == num)
				{
				}
				num = (short)352583680;
				if (num != 0)
				{
				}
				num = (short)1445462017;
				if (num != 0)
				{
				}
				num = (short)406585344;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000BD98 File Offset: 0x00009F98
		public UELog(string name)
		{
			this.fileName = name;
		}

		// Token: 0x04000079 RID: 121
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;
	}
}
