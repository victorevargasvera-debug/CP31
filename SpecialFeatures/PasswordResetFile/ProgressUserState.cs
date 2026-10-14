using System;
using System.Runtime.CompilerServices;

namespace SpecialFeatures.PasswordResetFile
{
	// Token: 0x020000A9 RID: 169
	public class ProgressUserState
	{
		// Token: 0x06000B87 RID: 2951 RVA: 0x00002D9A File Offset: 0x00000F9A
		public ProgressUserState(global::SpecialFeatures.PasswordResetFile.UserState currUS, global::SpecialFeatures.PasswordResetFile.UserState newUS, string msg)
		{
			this.b = currUS;
			this.c = newUS;
			this.a = msg;
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06000B88 RID: 2952 RVA: 0x000DEBA4 File Offset: 0x000DCDA4
		internal string UserText
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)377310047;
				short num2 = num;
				num = (short)61295455;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1237712896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1871904769;
				if (num != 0)
				{
				}
				num = (short)1530789888;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000447 RID: 1095
		// (get) Token: 0x06000B89 RID: 2953 RVA: 0x000DEC50 File Offset: 0x000DCE50
		internal global::SpecialFeatures.PasswordResetFile.UserState CurrentUserState
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)105906177;
				if (num != 0)
				{
				}
				num = (short)1801584640;
				short num2 = num;
				num = (short)470304330;
				short num3 = num;
				num = (short)300500554;
				switch (num3 == num)
				{
				}
				num = (short)944504832;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x17000448 RID: 1096
		// (get) Token: 0x06000B8A RID: 2954 RVA: 0x000DED00 File Offset: 0x000DCF00
		internal global::SpecialFeatures.PasswordResetFile.UserState NewUserState
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)420936511;
				short num2 = num;
				num = (short)72678207;
				switch (num2 == num)
				{
				default:
				{
					num = (short)809566208;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2089287681;
				if (num != 0)
				{
				}
				num = (short)1495138304;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x04000514 RID: 1300
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly string a;

		// Token: 0x04000515 RID: 1301
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::SpecialFeatures.PasswordResetFile.UserState b;

		// Token: 0x04000516 RID: 1302
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::SpecialFeatures.PasswordResetFile.UserState c;
	}
}
