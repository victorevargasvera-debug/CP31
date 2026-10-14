using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Security;
using Motorola.CommonCPS.RadioManagement.Global;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x0200006D RID: 109
	public class ChangePasswordContext : global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase
	{
		// Token: 0x06000308 RID: 776 RVA: 0x0002DAD4 File Offset: 0x0002BCD4
		public ChangePasswordContext()
		{
			this.d = null;
			this.e = null;
			this.f = null;
			this.g = false;
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000309 RID: 777 RVA: 0x0002DB24 File Offset: 0x0002BD24
		public string ServerAddress
		{
			get
			{
				short num = (short)1983500029;
				short num2 = num;
				num = (short)648400637;
				switch (num2 == num)
				{
				}
				num = (short)1936195584;
				if (num != 0)
				{
				}
				num = (short)142016512;
				short num3 = num;
				num = (short)252248065;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerAddress;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600030A RID: 778 RVA: 0x0002DBD4 File Offset: 0x0002BDD4
		public string ServerPort
		{
			get
			{
				short num = (short)674858589;
				short num2 = num;
				num = (short)726238813;
				switch (num2 == num)
				{
				}
				num = (short)2111045632;
				if (num != 0)
				{
				}
				num = (short)724500480;
				short num3 = num;
				num = (short)427491329;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerPort.ToString(global::System.Globalization.CultureInfo.CurrentCulture);
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x0600030B RID: 779 RVA: 0x0002DC90 File Offset: 0x0002BE90
		public string UserName
		{
			get
			{
				short num = (short)2139252319;
				short num2 = num;
				num = (short)874014303;
				switch (num2 == num)
				{
				}
				num = (short)1647050752;
				if (num != 0)
				{
				}
				num = (short)290848768;
				short num3 = num;
				num = (short)1882259457;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.UserName;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x0600030C RID: 780 RVA: 0x0002DD3C File Offset: 0x0002BF3C
		// (set) Token: 0x0600030D RID: 781 RVA: 0x0002DDEC File Offset: 0x0002BFEC
		public global::System.Security.SecureString CurrentPassword
		{
			get
			{
				short num = (short)1094798748;
				short num2 = num;
				num = (short)273567132;
				switch (num2 == num)
				{
				}
				num = (short)1914765313;
				if (num != 0)
				{
				}
				num = (short)107872256;
				short num3 = num;
				num = (short)107675648;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)352845826;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						this.d = value;
						base.RaisePropertyChanged<global::System.Security.SecureString>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Security.SecureString>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ChangePasswordContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ChangePasswordContext.get_CurrentPassword())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1978088644;
						short num3 = num;
						num = (short)1710308548;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1042087936;
							if (num != 0)
							{
							}
							num = (short)1095761921;
							if (num != 0)
							{
							}
							num = (short)1234960385;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_118;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_32;
						}
						continue;
					}
					IL_32:
					if (value == this.d)
					{
						return;
					}
					num = (short)1434648576;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_118:
				num = (short)94568448;
				short num4 = num;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x0600030E RID: 782 RVA: 0x0002DF40 File Offset: 0x0002C140
		// (set) Token: 0x0600030F RID: 783 RVA: 0x0002DFF4 File Offset: 0x0002C1F4
		public global::System.Security.SecureString ReenterNewPassword
		{
			get
			{
				short num = (short)359926118;
				short num2 = num;
				num = (short)259721574;
				switch (num2 == num)
				{
				}
				num = (short)1966473217;
				if (num != 0)
				{
				}
				num = (short)1367736320;
				short num3 = num;
				num = (short)149749760;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				short num = (short)467009538;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						this.f = value;
						base.RaisePropertyChanged<global::System.Security.SecureString>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Security.SecureString>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ChangePasswordContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ChangePasswordContext.get_ReenterNewPassword())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1119561663;
						short num3 = num;
						num = (short)1879451583;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1600126976;
							if (num != 0)
							{
							}
							num = (short)1840775169;
							if (num != 0)
							{
							}
							num = (short)1647837185;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_11B;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_32;
						}
						continue;
					}
					IL_32:
					if (value == this.f)
					{
						return;
					}
					num = (short)1001455616;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_11B:
				num = (short)675282944;
				short num4 = num;
			}
		}

		// Token: 0x17000160 RID: 352
		// (get) Token: 0x06000310 RID: 784 RVA: 0x0002E148 File Offset: 0x0002C348
		// (set) Token: 0x06000311 RID: 785 RVA: 0x0002E1F4 File Offset: 0x0002C3F4
		public global::System.Security.SecureString NewPassword
		{
			get
			{
				short num = (short)768803724;
				short num2 = num;
				num = (short)1878131596;
				switch (num2 == num)
				{
				}
				num = (short)2043609088;
				if (num != 0)
				{
				}
				num = (short)1865875456;
				short num3 = num;
				num = (short)1176109057;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)1248395266;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)763887617;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
					{
						this.e = value;
						base.RaisePropertyChanged<global::System.Security.SecureString>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Security.SecureString>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ChangePasswordContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ChangePasswordContext.get_NewPassword())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)43464858;
						short num3 = num;
						num = (short)150747290;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)2138636288;
							if (num != 0)
							{
							}
							num = (short)207880193;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_119;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_59;
						}
						continue;
					}
					IL_59:
					if (value == this.e)
					{
						return;
					}
					num = (short)43515904;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_119:
				num = (short)18874368;
				short num4 = num;
			}
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x06000312 RID: 786 RVA: 0x0002E344 File Offset: 0x0002C544
		// (set) Token: 0x06000313 RID: 787 RVA: 0x0002E3F4 File Offset: 0x0002C5F4
		public bool SubmitSuccess
		{
			get
			{
				short num = (short)21588248;
				short num2 = num;
				num = (short)155937048;
				switch (num2 == num)
				{
				}
				num = (short)560070656;
				if (num != 0)
				{
				}
				num = (short)965410816;
				short num3 = num;
				num = (short)1785135105;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				short num = (short)1544945666;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1111687169;
						if (num != 0)
						{
						}
						this.g = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ChangePasswordContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ChangePasswordContext.get_SubmitSuccess())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1073540215;
						short num3 = num;
						num = (short)135851127;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1581187072;
							if (num != 0)
							{
							}
							num = (short)2112421889;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_117;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					IL_30:
					if (value == this.g)
					{
						return;
					}
					num = (short)1643970560;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_117:
				num = (short)1341915136;
				short num4 = num;
			}
		}

		// Token: 0x04000167 RID: 359
		private string a = string.Empty;

		// Token: 0x04000168 RID: 360
		private string b = string.Empty;

		// Token: 0x04000169 RID: 361
		private string c = string.Empty;

		// Token: 0x0400016A RID: 362
		private global::System.Security.SecureString d;

		// Token: 0x0400016B RID: 363
		private global::System.Security.SecureString e;

		// Token: 0x0400016C RID: 364
		private global::System.Security.SecureString f;

		// Token: 0x0400016D RID: 365
		private bool g;
	}
}
