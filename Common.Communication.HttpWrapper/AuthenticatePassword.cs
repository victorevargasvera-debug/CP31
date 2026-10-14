using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication
{
	// Token: 0x02000035 RID: 53
	[global::System.Runtime.Serialization.DataContract]
	public class AuthenticatePassword
	{
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x0000C0AC File Offset: 0x0000A2AC
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x0000C15C File Offset: 0x0000A35C
		[global::System.Runtime.Serialization.DataMember]
		public string Password
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1237133850;
				short num2 = num;
				num = (short)1059138074;
				switch (num2 == num)
				{
				}
				num = (short)1608384513;
				if (num != 0)
				{
				}
				num = (short)403177472;
				if (num != 0)
				{
				}
				num = (short)408551424;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1541793859;
				short num2 = num;
				num = (short)794355779;
				switch (num2 == num)
				{
				}
				num = (short)1113718785;
				if (num != 0)
				{
				}
				num = (short)840695808;
				if (num != 0)
				{
				}
				num = (short)17825792;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000C20C File Offset: 0x0000A40C
		public AuthenticatePassword(string password)
		{
			this.Password = password;
		}

		// Token: 0x0400007C RID: 124
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;
	}
}
