using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000E9 RID: 233
	public class Settings : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
	{
		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06000B2B RID: 2859 RVA: 0x000A902C File Offset: 0x000A722C
		// (set) Token: 0x06000B2C RID: 2860 RVA: 0x000A90DC File Offset: 0x000A72DC
		public int JobSwitchoverDelay
		{
			get
			{
				short num = (short)1215888239;
				short num2 = num;
				num = (short)1527118703;
				switch (num2 == num)
				{
				}
				num = (short)1740898305;
				if (num != 0)
				{
				}
				num = (short)832569344;
				short num3 = num;
				num = (short)327811072;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1878065156;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_140;
					case 1:
					{
						num = (short)2135556096;
						short num3 = num;
						base.RaisePropertyChanged<int>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Settings)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.Settings.get_JobSwitchoverDelay())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1297874947;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						num = (short)2054225921;
						if (num != 0)
						{
						}
						num = (short)1940899144;
						short num4 = num;
						num = (short)383305032;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_140;
						default:
							num = (short)1092288512;
							if (num != 0)
							{
							}
							this.a = value;
							num = (short)384892928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						return;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_39;
						}
						continue;
					}
					IL_39:
					if (value != this.JobSwitchoverDelay)
					{
						num = (short)1782710274;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_140:
					if (base.IsLoading)
					{
						break;
					}
					num = (short)1566638081;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06000B2D RID: 2861 RVA: 0x000A9278 File Offset: 0x000A7478
		// (set) Token: 0x06000B2E RID: 2862 RVA: 0x000A9328 File Offset: 0x000A7528
		public global::System.Collections.Generic.IList<string> AuthenticationMethodSource
		{
			get
			{
				short num = (short)1301251398;
				short num2 = num;
				num = (short)55477574;
				switch (num2 == num)
				{
				}
				num = (short)299171841;
				if (num != 0)
				{
				}
				num = (short)890634240;
				short num3 = num;
				num = (short)1798963200;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				short num = (short)177012740;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_13C;
					case 1:
					{
						num = (short)2069233664;
						short num3 = num;
						base.RaisePropertyChanged<global::System.Collections.Generic.IList<string>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.Generic.IList<string>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Settings)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.Settings.get_AuthenticationMethodSource())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1947992067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						num = (short)999950168;
						short num4 = num;
						num = (short)1639319384;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_13C;
						default:
							num = (short)723845121;
							if (num != 0)
							{
							}
							num = (short)661782528;
							if (num != 0)
							{
							}
							this.g = value;
							num = (short)1657864192;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						return;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					}
					IL_38:
					if (value != this.g)
					{
						num = (short)854130690;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_13C:
					if (base.IsLoading)
					{
						break;
					}
					num = (short)42008577;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06000B2F RID: 2863 RVA: 0x000A94C4 File Offset: 0x000A76C4
		// (set) Token: 0x06000B30 RID: 2864 RVA: 0x000A9570 File Offset: 0x000A7770
		public string AuthenticationMethodType
		{
			get
			{
				short num = (short)657656591;
				short num2 = num;
				num = (short)125045519;
				switch (num2 == num)
				{
				}
				num = (short)1688535040;
				if (num != 0)
				{
				}
				num = (short)600834048;
				short num3 = num;
				num = (short)294256641;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)1844510724;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_11D;
					case 1:
					{
						num = (short)1255997440;
						short num3 = num;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Settings)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.Settings.get_AuthenticationMethodType())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)751632387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						num = (short)833916491;
						short num4 = num;
						num = (short)1105366603;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_11D;
						default:
							num = (short)1408434176;
							if (num != 0)
							{
							}
							this.e = value;
							num = (short)303366144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						return;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_39;
						}
						continue;
					}
					IL_39:
					if (value != this.e)
					{
						num = (short)340656130;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_11D:
					num = (short)1430650881;
					if (num != 0)
					{
					}
					if (base.IsLoading)
					{
						break;
					}
					num = (short)257294337;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06000B31 RID: 2865 RVA: 0x000A9710 File Offset: 0x000A7910
		// (set) Token: 0x06000B32 RID: 2866 RVA: 0x000A97C0 File Offset: 0x000A79C0
		public string IdentityServerAddress
		{
			get
			{
				short num = (short)2129262448;
				short num2 = num;
				num = (short)761263984;
				switch (num2 == num)
				{
				}
				num = (short)1706622977;
				if (num != 0)
				{
				}
				num = (short)2112356352;
				short num3 = num;
				num = (short)946012160;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)1755185156;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_118;
					case 1:
					{
						num = (short)1650458625;
						if (num != 0)
						{
						}
						num = (short)783679488;
						short num3 = num;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Settings)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.Settings.get_IdentityServerAddress())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1094582275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						num = (short)420360533;
						short num4 = num;
						num = (short)582496597;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_118;
						default:
							num = (short)1037828096;
							if (num != 0)
							{
							}
							this.d = value;
							num = (short)1017839616;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						return;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					}
					IL_38:
					if (value != this.d)
					{
						num = (short)1072300034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_118:
					if (base.IsLoading)
					{
						break;
					}
					num = (short)451411969;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06000B33 RID: 2867 RVA: 0x000A995C File Offset: 0x000A7B5C
		// (set) Token: 0x06000B34 RID: 2868 RVA: 0x000A9A10 File Offset: 0x000A7C10
		public string ServerAddress
		{
			get
			{
				short num = (short)1000800257;
				if (num != 0)
				{
				}
				num = (short)1825876792;
				short num2 = num;
				num = (short)1183886136;
				switch (num2 == num)
				{
				}
				num = (short)1311440896;
				short num3 = num;
				num = (short)1605042176;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)1246887940;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_11A;
					case 1:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Settings)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.Settings.get_ServerAddress())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1391198211;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)1422814825;
						short num3 = num;
						num = (short)627601001;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_11A;
						default:
							num = (short)764084224;
							if (num != 0)
							{
							}
							this.c = value;
							num = (short)1938882560;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						goto IL_AB;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_39;
						}
						continue;
					}
					IL_39:
					if (value != this.c)
					{
						num = (short)1646133250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_11A:
					if (base.IsLoading)
					{
						break;
					}
					num = (short)296484865;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_AB:
				num = (short)2035810304;
				short num4 = num;
				num = (short)355008513;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06000B35 RID: 2869 RVA: 0x000A9BAC File Offset: 0x000A7DAC
		// (set) Token: 0x06000B36 RID: 2870 RVA: 0x000A9C5C File Offset: 0x000A7E5C
		public int ServerPort
		{
			get
			{
				short num = (short)537669024;
				short num2 = num;
				num = (short)1963339168;
				switch (num2 == num)
				{
				}
				num = (short)2041970688;
				if (num != 0)
				{
				}
				num = (short)97386496;
				short num3 = num;
				num = (short)524681217;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)2053111809;
				if (num != 0)
				{
				}
				num = (short)527433732;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_164;
					case 1:
						base.RaisePropertyChanged<int>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Settings)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.Settings.get_ServerPort())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)960036867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)392236276;
						short num3 = num;
						num = (short)740560116;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_164;
						default:
							num = (short)1322516480;
							if (num != 0)
							{
							}
							this.b = value;
							num = (short)1883373568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						return;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_5E;
						}
						continue;
					}
					IL_5E:
					if (value != this.b)
					{
						num = (short)1098842112;
						short num4 = num;
						num = (short)1029832706;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_164:
					if (base.IsLoading)
					{
						break;
					}
					num = (short)882638849;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06000B37 RID: 2871 RVA: 0x000A9DF4 File Offset: 0x000A7FF4
		// (set) Token: 0x06000B38 RID: 2872 RVA: 0x000A9EA4 File Offset: 0x000A80A4
		public bool ServerSettingsOnStartup
		{
			get
			{
				short num = (short)1786773504;
				short num2 = num;
				num = (short)449903499;
				short num3 = num;
				num = (short)908393355;
				switch (num3 == num)
				{
				}
				num = (short)411762689;
				if (num != 0)
				{
				}
				num = (short)1714159616;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)1742602240;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)1064894464;
						short num3 = num;
						switch (num2)
						{
						case 0:
						{
							num = (short)627696156;
							short num4 = num;
							num = (short)900260380;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)527499264;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_AC;
								}
								continue;
							}
							break;
						}
						case 1:
							this.f = value;
							num = (short)1318846465;
							if (num != 0)
							{
							}
							num = (short)1191837699;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							return;
						case 3:
							if (!base.IsLoading)
							{
								num = (short)1345519620;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 4:
							base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.Settings)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.Settings.get_ServerSettingsOnStartup())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1489633282;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_AC:
						if (value == this.f)
						{
							return;
						}
						num = (short)321912833;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x04000412 RID: 1042
		private int a;

		// Token: 0x04000413 RID: 1043
		private int b;

		// Token: 0x04000414 RID: 1044
		private string c;

		// Token: 0x04000415 RID: 1045
		private string d;

		// Token: 0x04000416 RID: 1046
		private string e;

		// Token: 0x04000417 RID: 1047
		private bool f;

		// Token: 0x04000418 RID: 1048
		private global::System.Collections.Generic.IList<string> g;
	}
}
