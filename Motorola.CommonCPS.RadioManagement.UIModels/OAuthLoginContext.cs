using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using Motorola.Security.SamlCommonUtility.DMHttpClients;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x0200002F RID: 47
	public class OAuthLoginContext : global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase
	{
		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00010A88 File Offset: 0x0000EC88
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00010B34 File Offset: 0x0000ED34
		public global::System.Security.Claims.ClaimsPrincipal User
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2086797313;
				if (num != 0)
				{
				}
				num = (short)1924762167;
				short num2 = num;
				num = (short)1797556791;
				switch (num2 == num)
				{
				}
				num = (short)1597046784;
				short num3 = num;
				num = (short)881262592;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1180859097;
				short num2 = num;
				num = (short)1452636889;
				switch (num2 == num)
				{
				}
				num = (short)540278785;
				if (num != 0)
				{
				}
				num = (short)1244725248;
				short num3 = num;
				num = (short)1835663360;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00010BE8 File Offset: 0x0000EDE8
		// (set) Token: 0x0600010E RID: 270 RVA: 0x00010C9C File Offset: 0x0000EE9C
		public string IdentityToken
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1952186369;
				if (num != 0)
				{
				}
				num = (short)632784530;
				short num2 = num;
				num = (short)305366674;
				switch (num2 == num)
				{
				}
				num = (short)170328064;
				short num3 = num;
				num = (short)2100363264;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1052053455;
				short num2 = num;
				num = (short)419696591;
				switch (num2 == num)
				{
				}
				num = (short)33685505;
				if (num != 0)
				{
				}
				num = (short)671154176;
				short num3 = num;
				num = (short)1810038784;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00010D50 File Offset: 0x0000EF50
		// (set) Token: 0x06000110 RID: 272 RVA: 0x00010DFC File Offset: 0x0000EFFC
		public string AccessToken
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)675857656;
				short num2 = num;
				num = (short)2017379576;
				switch (num2 == num)
				{
				}
				num = (short)944308225;
				if (num != 0)
				{
				}
				num = (short)2082668544;
				short num3 = num;
				num = (short)777060352;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1817256667;
				short num2 = num;
				num = (short)1987650267;
				switch (num2 == num)
				{
				}
				num = (short)448331776;
				if (num != 0)
				{
				}
				num = (short)209977344;
				short num3 = num;
				num = (short)395313153;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000111 RID: 273 RVA: 0x00010EAC File Offset: 0x0000F0AC
		// (set) Token: 0x06000112 RID: 274 RVA: 0x00010F60 File Offset: 0x0000F160
		public string RefreshToken
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1173231273;
				short num2 = num;
				num = (short)518002345;
				switch (num2 == num)
				{
				}
				num = (short)1928200192;
				if (num != 0)
				{
				}
				num = (short)2140012544;
				short num3 = num;
				num = (short)824508417;
				if (num != 0)
				{
				}
				return this.f;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1579685918;
				short num2 = num;
				num = (short)277747742;
				switch (num2 == num)
				{
				}
				num = (short)1795686401;
				if (num != 0)
				{
				}
				num = (short)1252589568;
				if (num != 0)
				{
				}
				num = (short)184614912;
				short num3 = num;
				this.f = value;
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00011010 File Offset: 0x0000F210
		public OAuthLoginContext(global::Motorola.Security.SamlCommonUtility.DMHttpClients.OAuthApplicationInfo applicationInfo)
		{
			this.b = applicationInfo;
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000114 RID: 276 RVA: 0x0001102C File Offset: 0x0000F22C
		public global::Motorola.Security.SamlCommonUtility.DMHttpClients.OAuthApplicationInfo AppInfo
		{
			get
			{
				short num = (short)1622000275;
				short num2 = num;
				num = (short)68272787;
				switch (num2 == num)
				{
				}
				num = (short)794296320;
				if (num != 0)
				{
				}
				num = (short)2083848193;
				if (num != 0)
				{
				}
				num = (short)1607663616;
				short num3 = num;
				return this.b;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000115 RID: 277 RVA: 0x000110DC File Offset: 0x0000F2DC
		// (set) Token: 0x06000116 RID: 278 RVA: 0x0001118C File Offset: 0x0000F38C
		public global::Motorola.CommonCPS.RadioManagement.UIModels.OAuthLoginResult LoginResult
		{
			get
			{
				short num = (short)1734331544;
				short num2 = num;
				num = (short)1251855512;
				switch (num2 == num)
				{
				}
				num = (short)101253120;
				if (num != 0)
				{
				}
				num = (short)223674369;
				if (num != 0)
				{
				}
				num = (short)450691072;
				short num3 = num;
				return this.a;
			}
			set
			{
				short num = (short)1798307840;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)516943763;
					short num3 = num;
					num = (short)1690955667;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)352518144;
						short num4 = num;
						num = (short)78118913;
						if (num != 0)
						{
						}
						num = (short)1845231616;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_D0;
							}
							continue;
						case 1:
							return;
						case 2:
							this.a = value;
							base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.OAuthLoginResult>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.OAuthLoginResult>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.OAuthLoginContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.OAuthLoginContext.get_LoginResult())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)196608001;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_D0:
					if (value == this.a)
					{
						break;
					}
					num = (short)417595394;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x0400007D RID: 125
		private global::Motorola.CommonCPS.RadioManagement.UIModels.OAuthLoginResult a;

		// Token: 0x0400007E RID: 126
		private global::Motorola.Security.SamlCommonUtility.DMHttpClients.OAuthApplicationInfo b;

		// Token: 0x0400007F RID: 127
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Security.Claims.ClaimsPrincipal c;

		// Token: 0x04000080 RID: 128
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string d;

		// Token: 0x04000081 RID: 129
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string e;

		// Token: 0x04000082 RID: 130
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string f;
	}
}
