using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x02000083 RID: 131
	public class SettingsContext : global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase
	{
		// Token: 0x06000420 RID: 1056 RVA: 0x0003DA70 File Offset: 0x0003BC70
		public SettingsContext()
		{
			int a_ = 1;
			base..ctor();
			this.a = new global::Motorola.CommonCPS.RadioManagement.UIModels.Connection();
			this.b = new global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword();
			this.c = new global::Motorola.CommonCPS.RadioManagement.UIModels.Langauge();
			this.d = new global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarMode();
			this.e = new global::Motorola.CommonCPS.RadioManagement.UIModels.DealerInfo();
			this.DBSizeInfo = new global::Motorola.CommonCPS.RadioManagement.UIModels.DBSizeInfo();
			this.g = new global::Motorola.CommonCPS.RadioManagement.UIModels.HiddenMessage();
			this.h = new global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting();
			if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.WorkingAuthenticationMethodType == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("椻䴽┿ぁ੃❅╇⽉", a_) && global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsConnected)
			{
				this.ServerConnectedWithUserName = true;
			}
			else
			{
				this.ServerConnectedWithUserName = false;
			}
			this.IsConnected = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsConnected;
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.RaiseConnectionChangeEvent = (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionChangeEventHandler)global::System.Delegate.Combine(global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.RaiseConnectionChangeEvent, new global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionChangeEventHandler(this.ConnectionChangeEventHandler));
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x0003DB48 File Offset: 0x0003BD48
		// (set) Token: 0x06000422 RID: 1058 RVA: 0x0003DBF8 File Offset: 0x0003BDF8
		public global::Motorola.CommonCPS.RadioManagement.UIModels.Connection Connection
		{
			get
			{
				short num = (short)2014667238;
				short num2 = num;
				num = (short)746676710;
				switch (num2 == num)
				{
				}
				num = (short)2084831233;
				if (num != 0)
				{
				}
				num = (short)396230656;
				short num3 = num;
				num = (short)1954742272;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1568800769;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.a = value;
						base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.Connection>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.Connection>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext.get_Connection())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)309395458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
						return;
					}
					IL_30:
					num = (short)1788666923;
					short num3 = num;
					num = (short)1195369515;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1638989825;
						if (num != 0)
						{
						}
						num = (short)22806528;
						short num4 = num;
						num = (short)1292042240;
						if (num != 0)
						{
						}
						if (value == this.a)
						{
							return;
						}
						break;
					}
					}
					num = (short)342163456;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x0003DD48 File Offset: 0x0003BF48
		// (set) Token: 0x06000424 RID: 1060 RVA: 0x0003DDF8 File Offset: 0x0003BFF8
		public global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword RMUserPassword
		{
			get
			{
				short num = (short)1811877545;
				short num2 = num;
				num = (short)1990069929;
				switch (num2 == num)
				{
				}
				num = (short)347471872;
				if (num != 0)
				{
				}
				num = (short)1287913472;
				short num3 = num;
				num = (short)1973551105;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)2113732609;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.b = value;
						base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext.get_RMUserPassword())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)896270338;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
						return;
					}
					IL_30:
					num = (short)1820191920;
					short num3 = num;
					num = (short)1377234096;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1325531136;
						if (num != 0)
						{
						}
						num = (short)1477574656;
						short num4 = num;
						if (value == this.b)
						{
							return;
						}
						break;
					}
					}
					num = (short)283115521;
					if (num != 0)
					{
					}
					num = (short)1614807040;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x0003DF4C File Offset: 0x0003C14C
		// (set) Token: 0x06000426 RID: 1062 RVA: 0x0003DFFC File Offset: 0x0003C1FC
		public global::Motorola.CommonCPS.RadioManagement.UIModels.Langauge Language
		{
			get
			{
				short num = (short)1895059821;
				short num2 = num;
				num = (short)814961005;
				switch (num2 == num)
				{
				}
				num = (short)60882944;
				if (num != 0)
				{
				}
				num = (short)658767872;
				short num3 = num;
				num = (short)1776091137;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)2054225921;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.c = value;
						base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.Langauge>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.Langauge>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext.get_Language())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)607453186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
						return;
					}
					IL_30:
					num = (short)2039704488;
					short num3 = num;
					num = (short)1079667624;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)833421312;
						if (num != 0)
						{
						}
						num = (short)1348796416;
						short num4 = num;
						if (value == this.c)
						{
							return;
						}
						break;
					}
					}
					num = (short)1483735041;
					if (num != 0)
					{
					}
					num = (short)1739587584;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x0003E154 File Offset: 0x0003C354
		// (set) Token: 0x06000428 RID: 1064 RVA: 0x0003E204 File Offset: 0x0003C404
		public global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarMode ButtonBarMode
		{
			get
			{
				short num = (short)1296005641;
				short num2 = num;
				num = (short)710834697;
				switch (num2 == num)
				{
				}
				num = (short)264110081;
				if (num != 0)
				{
				}
				num = (short)1870135296;
				short num3 = num;
				num = (short)1658781696;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)1461977089;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.d = value;
						base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarMode>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarMode>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext.get_ButtonBarMode())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1927413762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
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
					num = (short)642560765;
					short num3 = num;
					num = (short)1833939709;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1071316992;
						if (num != 0)
						{
						}
						num = (short)1839267840;
						short num4 = num;
						num = (short)1779564545;
						if (num != 0)
						{
						}
						if (value == this.d)
						{
							return;
						}
						break;
					}
					}
					num = (short)403832832;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x0003E358 File Offset: 0x0003C558
		// (set) Token: 0x0600042A RID: 1066 RVA: 0x0003E408 File Offset: 0x0003C608
		public global::Motorola.CommonCPS.RadioManagement.UIModels.DealerInfo DealerInfo
		{
			get
			{
				short num = (short)740203431;
				short num2 = num;
				num = (short)1526307751;
				switch (num2 == num)
				{
				}
				num = (short)1067515904;
				if (num != 0)
				{
				}
				num = (short)1692598272;
				short num3 = num;
				num = (short)1957429249;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)2021130241;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.e = value;
						base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.DealerInfo>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.DealerInfo>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext.get_DealerInfo())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)396492802;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
						return;
					}
					IL_30:
					num = (short)800391169;
					if (num != 0)
					{
					}
					num = (short)905942280;
					short num3 = num;
					num = (short)1773245704;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)577241088;
						short num4 = num;
						num = (short)1706360832;
						if (num != 0)
						{
						}
						if (value == this.e)
						{
							return;
						}
						break;
					}
					}
					num = (short)324927488;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x0003E558 File Offset: 0x0003C758
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x0003E60C File Offset: 0x0003C80C
		public global::Motorola.CommonCPS.RadioManagement.UIModels.DBSizeInfo DBSizeInfo
		{
			get
			{
				short num = (short)1510418466;
				short num2 = num;
				num = (short)872753186;
				switch (num2 == num)
				{
				}
				num = (short)137560065;
				if (num != 0)
				{
				}
				num = (short)13369344;
				short num3 = num;
				num = (short)522846208;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				short num = (short)902168577;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1682505729;
						if (num != 0)
						{
						}
						this.f = value;
						base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.DBSizeInfo>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.DBSizeInfo>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext.get_DBSizeInfo())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)650444802;
						num2 = (int)((global::System.IntPtr)num);
						continue;
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
					num = (short)275003508;
					short num3 = num;
					num = (short)37173364;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1825243136;
						if (num != 0)
						{
						}
						num = (short)130154496;
						short num4 = num;
						if (value == this.f)
						{
							return;
						}
						break;
					}
					}
					num = (short)513212416;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x0003E764 File Offset: 0x0003C964
		// (set) Token: 0x0600042E RID: 1070 RVA: 0x0003E818 File Offset: 0x0003CA18
		public global::Motorola.CommonCPS.RadioManagement.UIModels.HiddenMessage HiddenMessage
		{
			get
			{
				short num = (short)3342337;
				if (num != 0)
				{
				}
				num = (short)751574688;
				short num2 = num;
				num = (short)610475680;
				switch (num2 == num)
				{
				}
				num = (short)921305088;
				short num3 = num;
				num = (short)1588002816;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				short num = (short)1456275457;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1693777921;
						if (num != 0)
						{
						}
						this.g = value;
						base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.HiddenMessage>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.HiddenMessage>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext.get_HiddenMessage())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1592459266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
						return;
					}
					IL_30:
					num = (short)2019294047;
					short num3 = num;
					num = (short)1413610335;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1929510912;
						if (num != 0)
						{
						}
						num = (short)1260126208;
						short num4 = num;
						if (value == this.g)
						{
							return;
						}
						break;
					}
					}
					num = (short)1942618112;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x0003E968 File Offset: 0x0003CB68
		// (set) Token: 0x06000430 RID: 1072 RVA: 0x0003EA18 File Offset: 0x0003CC18
		public bool IsConnected
		{
			get
			{
				short num = (short)50946051;
				short num2 = num;
				num = (short)1801674755;
				switch (num2 == num)
				{
				}
				num = (short)585826304;
				if (num != 0)
				{
				}
				num = (short)1655308288;
				short num3 = num;
				num = (short)364773377;
				if (num != 0)
				{
				}
				return this.j;
			}
			set
			{
				short num = (short)1724710913;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1952776193;
						if (num != 0)
						{
						}
						this.j = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext.get_IsConnected())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)237174786;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
						return;
					}
					IL_30:
					num = (short)1847410776;
					short num3 = num;
					num = (short)513097816;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)807469056;
						if (num != 0)
						{
						}
						num = (short)1224867840;
						short num4 = num;
						if (value == this.j)
						{
							return;
						}
						break;
					}
					}
					num = (short)1169162240;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x0003EB68 File Offset: 0x0003CD68
		// (set) Token: 0x06000432 RID: 1074 RVA: 0x0003EC18 File Offset: 0x0003CE18
		public bool ServerConnectedWithUserName
		{
			get
			{
				short num = (short)253833170;
				short num2 = num;
				num = (short)734998482;
				switch (num2 == num)
				{
				}
				num = (short)1008795649;
				if (num != 0)
				{
				}
				num = (short)660078592;
				short num3 = num;
				num = (short)1839333376;
				if (num != 0)
				{
				}
				return this.i;
			}
			set
			{
				short num = (short)1839267841;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						this.i = value;
						base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext.get_ServerConnectedWithUserName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1278017538;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
						return;
					}
					IL_30:
					num = (short)158605879;
					short num3 = num;
					num = (short)198058551;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1099890688;
						if (num != 0)
						{
						}
						num = (short)23920640;
						short num4 = num;
						num = (short)1502412801;
						if (num != 0)
						{
						}
						if (value == this.i)
						{
							return;
						}
						break;
					}
					}
					num = (short)385679360;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x0003ED6C File Offset: 0x0003CF6C
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x0003EE1C File Offset: 0x0003D01C
		public global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting LogSetting
		{
			get
			{
				short num = (short)947752785;
				short num2 = num;
				num = (short)177311569;
				switch (num2 == num)
				{
				}
				num = (short)1252655104;
				if (num != 0)
				{
				}
				num = (short)1247477760;
				short num3 = num;
				num = (short)1018560513;
				if (num != 0)
				{
				}
				return this.h;
			}
			set
			{
				short num = (short)1800798209;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)592117761;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						this.h = value;
						base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext.get_LogSetting())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)363200514;
						num2 = (int)((global::System.IntPtr)num);
						continue;
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
					num = (short)1081715505;
					short num3 = num;
					num = (short)876718897;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1748303872;
						short num4 = num;
						num = (short)1901133824;
						if (num != 0)
						{
						}
						if (value == this.h)
						{
							return;
						}
						break;
					}
					}
					num = (short)1713897472;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x0003EF70 File Offset: 0x0003D170
		// (set) Token: 0x06000436 RID: 1078 RVA: 0x0003F020 File Offset: 0x0003D220
		public bool IsSaved
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1350044841;
				short num2 = num;
				num = (short)1373375657;
				switch (num2 == num)
				{
				}
				num = (short)1495859201;
				if (num != 0)
				{
				}
				num = (short)485294080;
				if (num != 0)
				{
				}
				num = (short)406913024;
				short num3 = num;
				return this.k;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)39282049;
				short num2 = num;
				num = (short)733701505;
				switch (num2 == num)
				{
				}
				num = (short)597884929;
				if (num != 0)
				{
				}
				num = (short)599588864;
				if (num != 0)
				{
				}
				num = (short)1274216448;
				short num3 = num;
				this.k = value;
			}
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0003F0D4 File Offset: 0x0003D2D4
		public void ConnectionChangeEventHandler(global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ConnectionChangeEvent e)
		{
			int a_ = 10;
			short num = (short)2108489731;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)341035959;
				short num3 = num;
				num = (short)949013431;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2112684032;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_107;
					case 1:
						goto IL_E4;
					case 2:
						goto IL_E9;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_8F;
						}
						continue;
					case 4:
						if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsConnected)
						{
							num = (short)381943810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C5;
					case 5:
						num = (short)1687814148;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_8F:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.WorkingAuthenticationMethodType == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("၄㑆ⱈ㥊͌⹎㱐㙒", a_))
					{
						num = (short)718012421;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_C5:
					this.ServerConnectedWithUserName = false;
					num = (short)1776812033;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_E9:
				this.ServerConnectedWithUserName = true;
				num = (short)1132396544;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E4:
			goto IL_198;
			IL_107:
			num = (short)1801453568;
			short num4 = num;
			num = (short)1603403777;
			if (num != 0)
			{
			}
			IL_198:
			this.IsConnected = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsConnected;
		}

		// Token: 0x040001EC RID: 492
		private global::Motorola.CommonCPS.RadioManagement.UIModels.Connection a;

		// Token: 0x040001ED RID: 493
		private global::Motorola.CommonCPS.RadioManagement.UIModels.RMUserPassword b;

		// Token: 0x040001EE RID: 494
		private global::Motorola.CommonCPS.RadioManagement.UIModels.Langauge c;

		// Token: 0x040001EF RID: 495
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarMode d;

		// Token: 0x040001F0 RID: 496
		private global::Motorola.CommonCPS.RadioManagement.UIModels.DealerInfo e;

		// Token: 0x040001F1 RID: 497
		private global::Motorola.CommonCPS.RadioManagement.UIModels.DBSizeInfo f;

		// Token: 0x040001F2 RID: 498
		private global::Motorola.CommonCPS.RadioManagement.UIModels.HiddenMessage g;

		// Token: 0x040001F3 RID: 499
		private global::Motorola.CommonCPS.RadioManagement.UIModels.LogSetting h;

		// Token: 0x040001F4 RID: 500
		private bool i;

		// Token: 0x040001F5 RID: 501
		private bool j;

		// Token: 0x040001F6 RID: 502
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool k;
	}
}
