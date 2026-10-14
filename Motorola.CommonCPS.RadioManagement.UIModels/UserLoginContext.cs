using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Security;
using Motorola.CommonCPS.RadioManagement.Global;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000071 RID: 113
	public class UserLoginContext : global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase
	{
		// Token: 0x06000329 RID: 809 RVA: 0x0002F5D0 File Offset: 0x0002D7D0
		public UserLoginContext()
		{
			this.a = string.Empty;
			this.b = null;
			this.c = false;
			this.d = string.Empty;
			this.e = string.Empty;
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x0600032A RID: 810 RVA: 0x0002F614 File Offset: 0x0002D814
		// (set) Token: 0x0600032B RID: 811 RVA: 0x0002F6C4 File Offset: 0x0002D8C4
		public string UserName
		{
			get
			{
				short num = (short)814735617;
				short num2 = num;
				num = (short)663806209;
				switch (num2 == num)
				{
				}
				num = (short)1650065409;
				if (num != 0)
				{
				}
				num = (short)981204992;
				short num3 = num;
				num = (short)638910464;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)524156929;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)18679393;
						short num3 = num;
						num = (short)1186072161;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						case 1:
							break;
						default:
						{
							num = (short)605290496;
							short num4 = num;
							break;
						}
						}
						num = (short)205586432;
						if (num != 0)
						{
						}
						this.a = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.UserLoginContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.UserLoginContext.get_UserName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1834221570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)700841985;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_57;
						}
						continue;
					case 2:
						return;
					}
					IL_57:
					if (!(value != this.a))
					{
						break;
					}
					num = (short)752615424;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x0600032C RID: 812 RVA: 0x0002F81C File Offset: 0x0002DA1C
		// (set) Token: 0x0600032D RID: 813 RVA: 0x0002F8CC File Offset: 0x0002DACC
		public global::System.Security.SecureString Password
		{
			get
			{
				short num = (short)940044273;
				short num2 = num;
				num = (short)1601105905;
				switch (num2 == num)
				{
				}
				num = (short)683016193;
				if (num != 0)
				{
				}
				num = (short)1863319552;
				short num3 = num;
				num = (short)1275265024;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)1724841985;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1757149451;
						short num3 = num;
						num = (short)899414283;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
						{
							num = (short)289275904;
							short num4 = num;
							num = (short)1028521984;
							if (num != 0)
							{
							}
							num = (short)200343553;
							if (num != 0)
							{
							}
							this.b = value;
							base.RaisePropertyChanged<global::System.Security.SecureString>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Security.SecureString>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.UserLoginContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.UserLoginContext.get_Password())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)313589762;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 2:
						return;
					}
					IL_31:
					if (value == this.b)
					{
						break;
					}
					num = (short)40304640;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x0600032E RID: 814 RVA: 0x0002FA20 File Offset: 0x0002DC20
		// (set) Token: 0x0600032F RID: 815 RVA: 0x0002FAD0 File Offset: 0x0002DCD0
		public bool SubmitSuccess
		{
			get
			{
				short num = (short)2040274584;
				short num2 = num;
				num = (short)554049176;
				switch (num2 == num)
				{
				}
				num = (short)1942814721;
				if (num != 0)
				{
				}
				num = (short)2076835840;
				short num3 = num;
				num = (short)1102381056;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)1704919041;
				if (num != 0)
				{
				}
				num = (short)1212153857;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)957162637;
						short num3 = num;
						num = (short)427041933;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						case 1:
							break;
						default:
						{
							num = (short)210501632;
							short num4 = num;
							break;
						}
						}
						num = (short)1561264128;
						if (num != 0)
						{
						}
						this.c = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.UserLoginContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.UserLoginContext.get_SubmitSuccess())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)2126053378;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_58;
						}
						continue;
					case 2:
						return;
					}
					IL_58:
					if (value == this.c)
					{
						break;
					}
					num = (short)1776025600;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000330 RID: 816 RVA: 0x0002FC20 File Offset: 0x0002DE20
		// (set) Token: 0x06000331 RID: 817 RVA: 0x0002FCCC File Offset: 0x0002DECC
		public string ServerAddress
		{
			get
			{
				short num = (short)71565313;
				if (num != 0)
				{
				}
				num = (short)130252625;
				short num2 = num;
				num = (short)448298833;
				switch (num2 == num)
				{
				}
				num = (short)1172439040;
				short num3 = num;
				num = (short)368574464;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerAddress;
			}
			set
			{
				short num = (short)728104961;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)681126401;
						short num3 = num;
						num = (short)1600268801;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
						{
							num = (short)1739980800;
							short num4 = num;
							num = (short)2031812608;
							if (num != 0)
							{
							}
							num = (short)1445986305;
							if (num != 0)
							{
							}
							this.d = value;
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.UserLoginContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.UserLoginContext.get_ServerAddress())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)601423874;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 2:
						return;
					}
					IL_31:
					if (!(value != this.d))
					{
						break;
					}
					num = (short)4325376;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000332 RID: 818 RVA: 0x0002FE24 File Offset: 0x0002E024
		// (set) Token: 0x06000333 RID: 819 RVA: 0x0002FEE0 File Offset: 0x0002E0E0
		public string ServerPort
		{
			get
			{
				short num = (short)408374394;
				short num2 = num;
				num = (short)832457850;
				switch (num2 == num)
				{
				}
				num = (short)884015105;
				if (num != 0)
				{
				}
				num = (short)1822883840;
				short num3 = num;
				num = (short)2129788928;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerPort.ToString(global::System.Globalization.CultureInfo.CurrentCulture);
			}
			set
			{
				short num = (short)1502347265;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1714623287;
						short num3 = num;
						num = (short)751571767;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
						{
							num = (short)1195507712;
							short num4 = num;
							num = (short)398589952;
							if (num != 0)
							{
							}
							num = (short)1939800065;
							if (num != 0)
							{
							}
							this.e = value;
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.UserLoginContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.UserLoginContext.get_ServerPort())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)777715714;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 1:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 2:
						return;
					}
					IL_31:
					if (!(value != this.e))
					{
						break;
					}
					num = (short)471597056;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x04000177 RID: 375
		private string a;

		// Token: 0x04000178 RID: 376
		private global::System.Security.SecureString b;

		// Token: 0x04000179 RID: 377
		private bool c;

		// Token: 0x0400017A RID: 378
		private string d;

		// Token: 0x0400017B RID: 379
		private string e;
	}
}
