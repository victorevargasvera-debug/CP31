using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000A5 RID: 165
	public class RMUserPassword : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
	{
		// Token: 0x06000615 RID: 1557 RVA: 0x00058058 File Offset: 0x00056258
		public RMUserPassword()
		{
			this.SecureOldPassword = new global::System.Security.SecureString();
			this.SecureNewPassword = new global::System.Security.SecureString();
			this.SecureConfirmedPassword = new global::System.Security.SecureString();
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000616 RID: 1558 RVA: 0x000580D0 File Offset: 0x000562D0
		// (set) Token: 0x06000617 RID: 1559 RVA: 0x00058184 File Offset: 0x00056384
		public global::System.Security.SecureString SecureOldPassword
		{
			get
			{
				short num = (short)854604395;
				short num2 = num;
				num = (short)77675115;
				switch (num2 == num)
				{
				}
				num = (short)578486272;
				if (num != 0)
				{
				}
				num = (short)256835584;
				short num3 = num;
				num = (short)1905721345;
				if (num != 0)
				{
				}
				return this.secureOldPassword;
			}
			set
			{
				short num = (short)1055260675;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!base.IsLoading)
						{
							num = (short)2084634625;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						base.RaisePropertyChanged<global::System.Security.SecureString>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Security.SecureString>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword.get_SecureOldPassword())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword.get_InputValidated())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)160890882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return;
					case 3:
					{
						num = (short)1410215110;
						short num3 = num;
						num = (short)246820038;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)638451712;
							if (num != 0)
							{
							}
							num = (short)1300824065;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_AA;
							}
							continue;
						}
						break;
					}
					case 4:
						this.secureOldPassword = value;
						this.g = this.a();
						num = (short)1738342400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_AA:
					if (value == this.secureOldPassword)
					{
						break;
					}
					num = (short)1735458816;
					short num4 = num;
					num = (short)1924202500;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000618 RID: 1560 RVA: 0x0005835C File Offset: 0x0005655C
		// (set) Token: 0x06000619 RID: 1561 RVA: 0x0005840C File Offset: 0x0005660C
		public global::System.Security.SecureString SecureNewPassword
		{
			get
			{
				short num = (short)1011426096;
				short num2 = num;
				num = (short)1361847088;
				switch (num2 == num)
				{
				}
				num = (short)780861440;
				if (num != 0)
				{
				}
				num = (short)592183296;
				short num3 = num;
				num = (short)1975648257;
				if (num != 0)
				{
				}
				return this.secureNewPassword;
			}
			set
			{
				short num = (short)26476547;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!base.IsLoading)
						{
							num = (short)434765825;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						base.RaisePropertyChanged<global::System.Security.SecureString>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Security.SecureString>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword.get_SecureNewPassword())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword.get_InputValidated())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)132907010;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return;
					case 3:
					{
						num = (short)1682109054;
						short num3 = num;
						num = (short)894300798;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1720647681;
							if (num != 0)
							{
							}
							num = (short)955187200;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_B2;
							}
							continue;
						}
						break;
					}
					case 4:
						this.secureNewPassword = value;
						this.g = this.a();
						num = (short)1079377920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_B2:
					if (value == this.secureNewPassword)
					{
						break;
					}
					num = (short)676397056;
					short num4 = num;
					num = (short)652476420;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x0600061A RID: 1562 RVA: 0x000585EC File Offset: 0x000567EC
		// (set) Token: 0x0600061B RID: 1563 RVA: 0x0005869C File Offset: 0x0005689C
		public global::System.Security.SecureString SecureConfirmedPassword
		{
			get
			{
				short num = (short)40828929;
				if (num != 0)
				{
				}
				num = (short)426881;
				short num2 = num;
				num = (short)363103105;
				switch (num2 == num)
				{
				}
				num = (short)826540032;
				short num3 = num;
				num = (short)1758003200;
				if (num != 0)
				{
				}
				return this.secureConfirmedPassword;
			}
			set
			{
				short num = (short)498532355;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!base.IsLoading)
						{
							num = (short)1792999425;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						base.RaisePropertyChanged<global::System.Security.SecureString>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Security.SecureString>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword.get_SecureConfirmedPassword())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword.get_InputValidated())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1452212226;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_155;
					case 3:
					{
						num = (short)1358582327;
						short num3 = num;
						num = (short)1335644727;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)2116878336;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_85;
							}
							continue;
						}
						break;
					}
					case 4:
					{
						num = (short)1970601984;
						short num4 = num;
						this.secureConfirmedPassword = value;
						this.g = this.a();
						num = (short)95813632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_85:
					if (value == this.secureConfirmedPassword)
					{
						return;
					}
					num = (short)977797124;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_155:
				num = (short)734789633;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x0600061C RID: 1564 RVA: 0x00058878 File Offset: 0x00056A78
		public string ServerAddress
		{
			get
			{
				short num = (short)418512898;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerAddress != null)
						{
							goto IL_C6;
						}
						goto IL_92;
					case 1:
					{
						num = (short)1253786577;
						short num3 = num;
						num = (short)1774535633;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_C6;
						default:
							goto IL_111;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_35;
						}
						continue;
					case 3:
						num = (short)1167982592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_35:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.WorkingAuthenticationMethodType.Equals(global::Motorola.CommonCPS.RadioManagement.UIModels.AuthenticationMethod.UserName.ToString()))
					{
						num = (short)738328576;
						short num4 = num;
						num = (short)124452867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_154;
					IL_C6:
					num = (short)326172673;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_92:
				return string.Empty;
				IL_111:
				num = (short)1881079809;
				if (num != 0)
				{
				}
				num = (short)1757478912;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerAddress;
				IL_154:
				return global::Motorola.CommonCPS.ResourceRepository.Resources.NA;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x0600061D RID: 1565 RVA: 0x000589E0 File Offset: 0x00056BE0
		public string ServerPort
		{
			get
			{
				if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.WorkingAuthenticationMethodType.Equals(global::Motorola.CommonCPS.RadioManagement.UIModels.AuthenticationMethod.UserName.ToString()))
				{
					short num = (short)1914775406;
					short num2 = num;
					num = (short)157820782;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)2045640705;
						if (num != 0)
						{
						}
						num = (short)1587412992;
						short num3 = num;
						num = (short)1286406144;
						if (num != 0)
						{
						}
						return global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerPort.ToString(global::System.Globalization.CultureInfo.CurrentCulture);
					}
					}
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.NA;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x0600061E RID: 1566 RVA: 0x00058AC8 File Offset: 0x00056CC8
		// (set) Token: 0x0600061F RID: 1567 RVA: 0x00058B9C File Offset: 0x00056D9C
		public string UserName
		{
			get
			{
				if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.WorkingAuthenticationMethodType.Equals(global::Motorola.CommonCPS.RadioManagement.UIModels.AuthenticationMethod.UserName.ToString()))
				{
					short num = (short)520642271;
					short num2 = num;
					num = (short)1238785759;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)179240961;
						if (num != 0)
						{
						}
						num = (short)858521600;
						short num3 = num;
						num = (short)1561395200;
						if (num != 0)
						{
						}
						return global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.WorkingUserName;
					}
					}
				}
				return global::Motorola.CommonCPS.ResourceRepository.Resources.NA;
			}
			set
			{
				short num = (short)1382612995;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!base.IsLoading)
						{
							num = (short)539295745;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword.get_UserName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword.get_InputValidated())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)297664514;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return;
					case 3:
					{
						num = (short)1684736899;
						short num3 = num;
						num = (short)1827343235;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)385089536;
							if (num != 0)
							{
							}
							num = (short)1510735873;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_A9;
							}
							continue;
						}
						break;
					}
					case 4:
						this.c = value;
						this.g = this.a();
						num = (short)1882128384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_A9:
					if (!(value != this.c))
					{
						break;
					}
					num = (short)1682374656;
					short num4 = num;
					num = (short)888930308;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000620 RID: 1568 RVA: 0x00058D78 File Offset: 0x00056F78
		// (set) Token: 0x06000621 RID: 1569 RVA: 0x00058E24 File Offset: 0x00057024
		public string OldPassword
		{
			get
			{
				short num = (short)2056820385;
				short num2 = num;
				num = (short)1335924385;
				switch (num2 == num)
				{
				}
				num = (short)1079640064;
				if (num != 0)
				{
				}
				num = (short)1864171520;
				short num3 = num;
				num = (short)1769472001;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)1843855363;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!base.IsLoading)
						{
							num = (short)801046529;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword.get_OldPassword())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword.get_InputValidated())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1312686082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return;
					case 3:
					{
						num = (short)291025730;
						short num3 = num;
						num = (short)790016834;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)951582720;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_83;
							}
							continue;
						}
						break;
					}
					case 4:
					{
						num = (short)852819968;
						short num4 = num;
						num = (short)881262593;
						if (num != 0)
						{
						}
						this.d = value;
						this.g = this.a();
						num = (short)593494016;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_83:
					if (!(value != this.d))
					{
						break;
					}
					num = (short)188678148;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x00059004 File Offset: 0x00057204
		// (set) Token: 0x06000623 RID: 1571 RVA: 0x000590B4 File Offset: 0x000572B4
		public string NewPassword
		{
			get
			{
				short num = (short)1026387801;
				short num2 = num;
				num = (short)2085252953;
				switch (num2 == num)
				{
				}
				num = (short)592707584;
				if (num != 0)
				{
				}
				num = (short)2090795008;
				short num3 = num;
				num = (short)81068033;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)1815019523;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!base.IsLoading)
						{
							num = (short)1142554625;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword.get_NewPassword())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword.get_InputValidated())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)27394050;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return;
					case 3:
					{
						num = (short)2040740499;
						short num3 = num;
						num = (short)2108701331;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1636761600;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_84;
							}
							continue;
						}
						break;
					}
					case 4:
					{
						num = (short)443219968;
						short num4 = num;
						num = (short)1331363841;
						if (num != 0)
						{
						}
						this.e = value;
						this.g = this.a();
						num = (short)809762816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_84:
					if (!(value != this.e))
					{
						break;
					}
					num = (short)1507590148;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000624 RID: 1572 RVA: 0x00059290 File Offset: 0x00057490
		// (set) Token: 0x06000625 RID: 1573 RVA: 0x00059340 File Offset: 0x00057540
		public string ConfirmedPassword
		{
			get
			{
				short num = (short)1611071489;
				if (num != 0)
				{
				}
				num = (short)895882432;
				short num2 = num;
				num = (short)261493952;
				switch (num2 == num)
				{
				}
				num = (short)2071199744;
				short num3 = num;
				num = (short)1983709184;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				short num = (short)1502871555;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!base.IsLoading)
						{
							num = (short)1640955905;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword.get_ConfirmedPassword())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword.get_InputValidated())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)211812354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return;
					case 3:
					{
						num = (short)1604890143;
						short num3 = num;
						num = (short)355511839;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1465778177;
							if (num != 0)
							{
							}
							num = (short)516620288;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_AD;
							}
							continue;
						}
						break;
					}
					case 4:
						this.f = value;
						this.g = this.a();
						num = (short)1355218944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_AD:
					if (!(value != this.f))
					{
						break;
					}
					num = (short)2026504192;
					short num4 = num;
					num = (short)2003107844;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x00059520 File Offset: 0x00057720
		// (set) Token: 0x06000627 RID: 1575 RVA: 0x000595D4 File Offset: 0x000577D4
		public bool InputValidated
		{
			get
			{
				short num = (short)1146716760;
				short num2 = num;
				num = (short)959283800;
				switch (num2 == num)
				{
				}
				num = (short)612171777;
				if (num != 0)
				{
				}
				num = (short)1992491008;
				short num3 = num;
				num = (short)68091904;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				short num = (short)143327235;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!base.IsLoading)
						{
							num = (short)1990983681;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword.get_InputValidated())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)350552066;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return;
					case 3:
					{
						num = (short)210289310;
						short num3 = num;
						num = (short)926204574;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)301072384;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_82;
							}
							continue;
						}
						break;
					}
					case 4:
					{
						num = (short)1346830336;
						short num4 = num;
						num = (short)1010696193;
						if (num != 0)
						{
						}
						this.g = value;
						num = (short)119144448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_82:
					if (value == this.g)
					{
						break;
					}
					num = (short)324665348;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000628 RID: 1576 RVA: 0x0005976C File Offset: 0x0005796C
		// (set) Token: 0x06000629 RID: 1577 RVA: 0x0005981C File Offset: 0x00057A1C
		private global::System.Security.SecureString secureOldPassword
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)306491139;
				short num2 = num;
				num = (short)1488563971;
				switch (num2 == num)
				{
				}
				num = (short)1020526593;
				if (num != 0)
				{
				}
				num = (short)1352400896;
				short num3 = num;
				num = (short)1035337728;
				if (num != 0)
				{
				}
				return this.h;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)25505579;
				short num2 = num;
				num = (short)927412011;
				switch (num2 == num)
				{
				}
				num = (short)1967259649;
				if (num != 0)
				{
				}
				num = (short)486473728;
				short num3 = num;
				num = (short)231211008;
				if (num != 0)
				{
				}
				this.h = value;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x0600062A RID: 1578 RVA: 0x000598CC File Offset: 0x00057ACC
		// (set) Token: 0x0600062B RID: 1579 RVA: 0x0005997C File Offset: 0x00057B7C
		private global::System.Security.SecureString secureNewPassword
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2065191126;
				short num2 = num;
				num = (short)1759924438;
				switch (num2 == num)
				{
				}
				num = (short)513540096;
				if (num != 0)
				{
				}
				num = (short)1165819904;
				short num3 = num;
				num = (short)1148452865;
				if (num != 0)
				{
				}
				return this.i;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1086382916;
				short num2 = num;
				num = (short)1113252676;
				switch (num2 == num)
				{
				}
				num = (short)579076097;
				if (num != 0)
				{
				}
				num = (short)358940672;
				short num3 = num;
				num = (short)1257308160;
				if (num != 0)
				{
				}
				this.i = value;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x0600062C RID: 1580 RVA: 0x00059A30 File Offset: 0x00057C30
		// (set) Token: 0x0600062D RID: 1581 RVA: 0x00059AE4 File Offset: 0x00057CE4
		private global::System.Security.SecureString secureConfirmedPassword
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)571080705;
				if (num != 0)
				{
				}
				num = (short)1923991996;
				short num2 = num;
				num = (short)220121532;
				switch (num2 == num)
				{
				}
				num = (short)1540882432;
				short num3 = num;
				num = (short)907673600;
				if (num != 0)
				{
				}
				return this.j;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1318654627;
				short num2 = num;
				num = (short)563024547;
				switch (num2 == num)
				{
				}
				num = (short)1949433857;
				if (num != 0)
				{
				}
				num = (short)182190080;
				short num3 = num;
				num = (short)610861056;
				if (num != 0)
				{
				}
				this.j = value;
			}
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x00059B94 File Offset: 0x00057D94
		private bool a()
		{
			short num = (short)1974861825;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1453064199;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 2:
					num = (short)1656422405;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)2035548161;
					if (num != 0)
					{
					}
					num = (short)246939648;
					short num3 = num;
					if (this.SecureOldPassword.Length != 0)
					{
						num = (short)1326645250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 4:
					return false;
				case 5:
					if (this.SecureNewPassword.Length != 0)
					{
						num = (short)1464270848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 6:
					num = (short)53215235;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					if (this.SecureConfirmedPassword.Length != 0)
					{
						return true;
					}
					num = (short)713549495;
					short num4 = num;
					num = (short)199288503;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
						num = (short)370343936;
						if (num != 0)
						{
						}
						num = (short)351469572;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_44:
				if (string.IsNullOrEmpty(this.UserName))
				{
					break;
				}
				num = (short)1919287302;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
		}

		// Token: 0x040002B6 RID: 694
		private string a = string.Empty;

		// Token: 0x040002B7 RID: 695
		private string b = string.Empty;

		// Token: 0x040002B8 RID: 696
		private string c = string.Empty;

		// Token: 0x040002B9 RID: 697
		private string d = string.Empty;

		// Token: 0x040002BA RID: 698
		private string e = string.Empty;

		// Token: 0x040002BB RID: 699
		private string f = string.Empty;

		// Token: 0x040002BC RID: 700
		private bool g;

		// Token: 0x040002BD RID: 701
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Security.SecureString h;

		// Token: 0x040002BE RID: 702
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Security.SecureString i;

		// Token: 0x040002BF RID: 703
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Security.SecureString j;
	}
}
