using System;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000C8 RID: 200
	public class ResetIdentifiersContext : global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase
	{
		// Token: 0x060008EE RID: 2286 RVA: 0x0008680C File Offset: 0x00084A0C
		public ResetIdentifiersContext(global::System.Guid radioID, byte[] timestamp)
		{
			this.a = radioID;
			this.b = timestamp;
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x00086830 File Offset: 0x00084A30
		// (set) Token: 0x060008F0 RID: 2288 RVA: 0x000868E0 File Offset: 0x00084AE0
		public bool? RadioIdCAIEnable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1253529339;
				short num2 = num;
				num = (short)688281339;
				switch (num2 == num)
				{
				}
				num = (short)1451163649;
				if (num != 0)
				{
				}
				num = (short)869269504;
				short num3 = num;
				num = (short)852754432;
				if (num != 0)
				{
				}
				return this.l;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1884013497;
				short num2 = num;
				num = (short)1556857785;
				switch (num2 == num)
				{
				}
				num = (short)708050945;
				if (num != 0)
				{
				}
				num = (short)1643905024;
				short num3 = num;
				num = (short)2071986176;
				if (num != 0)
				{
				}
				this.l = value;
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x00086990 File Offset: 0x00084B90
		// (set) Token: 0x060008F2 RID: 2290 RVA: 0x00086A40 File Offset: 0x00084C40
		public string SerialNumber
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1645292364;
				short num2 = num;
				num = (short)2129079116;
				switch (num2 == num)
				{
				}
				num = (short)1458831361;
				if (num != 0)
				{
				}
				num = (short)489291776;
				short num3 = num;
				num = (short)415039488;
				if (num != 0)
				{
				}
				return this.m;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1990691396;
				short num2 = num;
				num = (short)2112522820;
				switch (num2 == num)
				{
				}
				num = (short)1513095169;
				if (num != 0)
				{
				}
				num = (short)565248000;
				short num3 = num;
				num = (short)161611776;
				if (num != 0)
				{
				}
				this.m = value;
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x060008F3 RID: 2291 RVA: 0x00086AF0 File Offset: 0x00084CF0
		public global::System.Guid RadioUuid
		{
			get
			{
				short num = (short)1696537425;
				short num2 = num;
				num = (short)426122065;
				switch (num2 == num)
				{
				}
				num = (short)1223229441;
				if (num != 0)
				{
				}
				num = (short)974520320;
				short num3 = num;
				num = (short)8519680;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000439 RID: 1081
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x00086BA0 File Offset: 0x00084DA0
		public byte[] RadioTimestamp
		{
			get
			{
				short num = (short)1698743988;
				short num2 = num;
				num = (short)1889846964;
				switch (num2 == num)
				{
				}
				num = (short)1193607169;
				if (num != 0)
				{
				}
				num = (short)1470431232;
				short num3 = num;
				num = (short)658243584;
				if (num != 0)
				{
				}
				return this.b;
			}
		}

		// Token: 0x1700043A RID: 1082
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x00086C50 File Offset: 0x00084E50
		// (set) Token: 0x060008F6 RID: 2294 RVA: 0x00086D00 File Offset: 0x00084F00
		public int? RadioID
		{
			get
			{
				short num = (short)654357419;
				short num2 = num;
				num = (short)503952299;
				switch (num2 == num)
				{
				}
				num = (short)1255931905;
				if (num != 0)
				{
				}
				num = (short)1826619392;
				short num3 = num;
				num = (short)911540224;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				int num;
				short num2;
				int? num4;
				int? num5;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (!base.IsLoading)
						{
							num2 = (short)996474882;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_189;
					case 1:
					{
						num2 = (short)1730871296;
						short num3 = num2;
						if (!(num4.GetValueOrDefault() == num5.GetValueOrDefault() & num4 != null == (num5 != null)))
						{
							num2 = (short)982712324;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_189;
					}
					case 2:
					{
						num2 = (short)958213019;
						short num6 = num2;
						num2 = (short)1628384155;
						switch ((num6 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_FC;
						default:
							num2 = (short)2019622912;
							if (num2 != 0)
							{
							}
							base.RaisePropertyChanged<int?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ResetIdentifiersContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ResetIdentifiersContext.get_RadioID())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num2 = (short)1720778755;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 3:
						goto IL_F7;
					case 4:
						goto IL_FC;
					}
					goto IL_24;
					IL_FC:
					this.c = value;
					num2 = (short)393936896;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_F7:
				IL_189:
				num2 = (short)291241985;
				if (num2 != 0)
				{
				}
				return;
				IL_24:
				num4 = value;
				num5 = this.c;
				num2 = (short)924450817;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x1700043B RID: 1083
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x00086EC0 File Offset: 0x000850C0
		// (set) Token: 0x060008F8 RID: 2296 RVA: 0x00086F70 File Offset: 0x00085170
		public string RadioIDError
		{
			get
			{
				short num = (short)32948843;
				short num2 = num;
				num = (short)1634124395;
				switch (num2 == num)
				{
				}
				num = (short)2089156609;
				if (num != 0)
				{
				}
				num = (short)1329201152;
				short num3 = num;
				num = (short)482082816;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)1395785729;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1509556224;
					short num3 = num;
					switch (num2)
					{
					case 0:
						if (!base.IsLoading)
						{
							num = (short)453771266;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_63;
						}
						continue;
					case 2:
						goto IL_18D;
					case 3:
						return;
					case 4:
						this.d = value;
						num = (short)132251648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_63:
					num = (short)830234219;
					short num4 = num;
					num = (short)621502059;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_18D:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ResetIdentifiersContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ResetIdentifiersContext.get_RadioIDError())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1387986945;
						if (num != 0)
						{
						}
						num = (short)1320419331;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)695009280;
						if (num != 0)
						{
						}
						if (!(value != this.d))
						{
							return;
						}
						num = (short)257163268;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
		}

		// Token: 0x1700043C RID: 1084
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x00087110 File Offset: 0x00085310
		// (set) Token: 0x060008FA RID: 2298 RVA: 0x000871C0 File Offset: 0x000853C0
		public int? CAI
		{
			get
			{
				short num = (short)793258894;
				short num2 = num;
				num = (short)309668750;
				switch (num2 == num)
				{
				}
				num = (short)528023552;
				if (num != 0)
				{
				}
				num = (short)743505920;
				short num3 = num;
				num = (short)1478885377;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				int num;
				short num2;
				int? num3;
				int? num4;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (!base.IsLoading)
						{
							num2 = (short)224329730;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 1:
						if (!(num3.GetValueOrDefault() == num4.GetValueOrDefault() & num3 != null == (num4 != null)))
						{
							num2 = (short)622854148;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 2:
					{
						num2 = (short)1688676131;
						short num5 = num2;
						num2 = (short)1657743139;
						switch ((num5 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_127;
						default:
							num2 = (short)1232273408;
							if (num2 != 0)
							{
							}
							base.RaisePropertyChanged<int?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ResetIdentifiersContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ResetIdentifiersContext.get_CAI())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num2 = (short)1801453571;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 3:
						return;
					case 4:
						goto IL_127;
					}
					goto IL_24;
					IL_127:
					this.e = value;
					num2 = (short)1402994688;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_24:
				num2 = (short)74514433;
				if (num2 != 0)
				{
				}
				num3 = value;
				num4 = this.e;
				num2 = (short)1087242240;
				short num6 = num2;
				num2 = (short)1202847745;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x1700043D RID: 1085
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x00087384 File Offset: 0x00085584
		// (set) Token: 0x060008FC RID: 2300 RVA: 0x00087438 File Offset: 0x00085638
		public string CAIError
		{
			get
			{
				short num = (short)64552961;
				if (num != 0)
				{
				}
				num = (short)753005256;
				short num2 = num;
				num = (short)767685320;
				switch (num2 == num)
				{
				}
				num = (short)721354752;
				short num3 = num;
				num = (short)629014528;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				short num = (short)1359216641;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)451805184;
					short num3 = num;
					switch (num2)
					{
					case 0:
						if (!base.IsLoading)
						{
							num = (short)578289666;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_61;
						}
						continue;
					case 2:
						goto IL_18A;
					case 3:
						return;
					case 4:
						this.f = value;
						num = (short)1520173056;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_61:
					num = (short)368170439;
					short num4 = num;
					num = (short)337040839;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_18A:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ResetIdentifiersContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ResetIdentifiersContext.get_CAIError())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)319619075;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)1780809729;
						if (num != 0)
						{
						}
						num = (short)912785408;
						if (num != 0)
						{
						}
						if (!(value != this.f))
						{
							return;
						}
						num = (short)1069875204;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
		}

		// Token: 0x1700043E RID: 1086
		// (get) Token: 0x060008FD RID: 2301 RVA: 0x000875D4 File Offset: 0x000857D4
		// (set) Token: 0x060008FE RID: 2302 RVA: 0x00087684 File Offset: 0x00085884
		public string Password
		{
			get
			{
				short num = (short)479877838;
				short num2 = num;
				num = (short)749361870;
				switch (num2 == num)
				{
				}
				num = (short)875364353;
				if (num != 0)
				{
				}
				num = (short)1796079616;
				short num3 = num;
				num = (short)1594097664;
				if (num != 0)
				{
				}
				return this.i;
			}
			set
			{
				short num = (short)1654849537;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)820445184;
					short num3 = num;
					switch (num2)
					{
					case 0:
						if (!base.IsLoading)
						{
							num = (short)394985474;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_61;
						}
						continue;
					case 2:
						goto IL_189;
					case 3:
						return;
					case 4:
						this.i = value;
						num = (short)89980928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_61:
					num = (short)146145281;
					if (num != 0)
					{
					}
					num = (short)1659449045;
					short num4 = num;
					num = (short)877407957;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_189:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ResetIdentifiersContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ResetIdentifiersContext.get_Password())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)21757955;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)899022848;
						if (num != 0)
						{
						}
						if (!(value != this.i))
						{
							return;
						}
						num = (short)1032257540;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
		}

		// Token: 0x1700043F RID: 1087
		// (get) Token: 0x060008FF RID: 2303 RVA: 0x00087820 File Offset: 0x00085A20
		// (set) Token: 0x06000900 RID: 2304 RVA: 0x000878CC File Offset: 0x00085ACC
		public string PasswordError
		{
			get
			{
				short num = (short)304162336;
				short num2 = num;
				num = (short)754198048;
				switch (num2 == num)
				{
				}
				num = (short)1311113217;
				if (num != 0)
				{
				}
				num = (short)903348224;
				short num3 = num;
				num = (short)622723072;
				if (num != 0)
				{
				}
				return this.j;
			}
			set
			{
				short num = (short)198049793;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)550633472;
					short num3 = num;
					switch (num2)
					{
					case 0:
						if (!base.IsLoading)
						{
							num = (short)218234882;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_60;
						}
						continue;
					case 2:
						goto IL_188;
					case 3:
						return;
					case 4:
						this.j = value;
						num = (short)1926103040;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_60:
					num = (short)1821868428;
					short num4 = num;
					num = (short)1847689612;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_188:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ResetIdentifiersContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ResetIdentifiersContext.get_PasswordError())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)474611715;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)1990656000;
						if (num != 0)
						{
						}
						num = (short)1724121089;
						if (num != 0)
						{
						}
						if (!(value != this.j))
						{
							return;
						}
						num = (short)283312132;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
		}

		// Token: 0x17000440 RID: 1088
		// (get) Token: 0x06000901 RID: 2305 RVA: 0x00087A68 File Offset: 0x00085C68
		// (set) Token: 0x06000902 RID: 2306 RVA: 0x00087B14 File Offset: 0x00085D14
		public global::Motorola.CommonCPS.Server.EntityModel.LinkType? LinkTypes
		{
			get
			{
				short num = (short)1197763627;
				short num2 = num;
				num = (short)1849060395;
				switch (num2 == num)
				{
				}
				num = (short)482869249;
				if (num != 0)
				{
				}
				num = (short)1556480000;
				short num3 = num;
				num = (short)606863360;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_24;
				}
				int num;
				short num2;
				global::Motorola.CommonCPS.Server.EntityModel.LinkType? linkType;
				global::Motorola.CommonCPS.Server.EntityModel.LinkType? linkType2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (!base.IsLoading)
						{
							num2 = (short)924778498;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					case 1:
					{
						num2 = (short)119406592;
						short num3 = num2;
						if (!(linkType.GetValueOrDefault() == linkType2.GetValueOrDefault() & linkType != null == (linkType2 != null)))
						{
							num2 = (short)376832004;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					case 2:
					{
						num2 = (short)1854028889;
						short num4 = num2;
						num2 = (short)90389593;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_124;
						default:
							num2 = (short)1452015616;
							if (num2 != 0)
							{
							}
							base.RaisePropertyChanged<global::Motorola.CommonCPS.Server.EntityModel.LinkType?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.Server.EntityModel.LinkType?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ResetIdentifiersContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ResetIdentifiersContext.get_LinkTypes())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num2 = (short)769851395;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 3:
						return;
					case 4:
						num2 = (short)781647873;
						if (num2 != 0)
						{
						}
						goto IL_124;
					}
					goto IL_24;
					IL_124:
					this.g = value;
					num2 = (short)549847040;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_24:
				linkType = value;
				linkType2 = this.g;
				num2 = (short)1669726209;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x17000441 RID: 1089
		// (get) Token: 0x06000903 RID: 2307 RVA: 0x00087CD4 File Offset: 0x00085ED4
		// (set) Token: 0x06000904 RID: 2308 RVA: 0x00087D84 File Offset: 0x00085F84
		public string LinkTypesError
		{
			get
			{
				short num = (short)225952328;
				short num2 = num;
				num = (short)1672725064;
				switch (num2 == num)
				{
				}
				num = (short)1327497217;
				if (num != 0)
				{
				}
				num = (short)1579876352;
				short num3 = num;
				num = (short)1884815360;
				if (num != 0)
				{
				}
				return this.h;
			}
			set
			{
				short num = (short)2135949313;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)515506176;
					short num3 = num;
					switch (num2)
					{
					case 0:
						if (!base.IsLoading)
						{
							num = (short)952303618;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_62;
						}
						continue;
					case 2:
						goto IL_188;
					case 3:
						goto IL_122;
					case 4:
						this.h = value;
						num = (short)1088094208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_62:
					num = (short)2110979508;
					short num4 = num;
					num = (short)1260125620;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_188:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ResetIdentifiersContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ResetIdentifiersContext.get_LinkTypesError())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)383975427;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)1831075840;
						if (num != 0)
						{
						}
						if (!(value != this.h))
						{
							return;
						}
						num = (short)532676612;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_122:
				num = (short)1153171457;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000442 RID: 1090
		// (get) Token: 0x06000905 RID: 2309 RVA: 0x00087F20 File Offset: 0x00086120
		// (set) Token: 0x06000906 RID: 2310 RVA: 0x00087FD0 File Offset: 0x000861D0
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? ProductFamilyInfo
		{
			get
			{
				short num = (short)1833674836;
				short num2 = num;
				num = (short)1711974484;
				switch (num2 == num)
				{
				}
				num = (short)204800000;
				if (num != 0)
				{
				}
				num = (short)1315897344;
				short num3 = num;
				num = (short)1091502081;
				if (num != 0)
				{
				}
				return this.k;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				short num2;
				global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily;
				global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily2;
				for (;;)
				{
					IL_0A:
					int num;
					switch (num)
					{
					case 0:
					{
						this.k = value;
						num2 = (short)1578500096;
						short num3 = num2;
						num2 = (short)603783169;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 1:
						goto IL_134;
					case 2:
						if (!(productFamily.GetValueOrDefault() == productFamily2.GetValueOrDefault() & productFamily != null == (productFamily2 != null)))
						{
							num2 = (short)194248704;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					break;
				}
				IL_1C:
				productFamily = value;
				productFamily2 = this.k;
				num2 = (short)1470633380;
				short num4 = num2;
				num2 = (short)1077286308;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_134:
					break;
				default:
				{
					num2 = (short)2015297537;
					if (num2 != 0)
					{
					}
					num2 = (short)180158464;
					if (num2 != 0)
					{
					}
					num2 = (short)1898315778;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
		}

		// Token: 0x17000443 RID: 1091
		public override string this[string propertyName]
		{
			get
			{
				int a_ = 0;
				short num = (short)1410203663;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1391394832;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("欺尼䰾㉀㑂⩄㕆ⵈ", a_)))
						{
							num = (short)391839752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)969474050;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (!base.Validate(this.PasswordError))
						{
							num = (short)27590662;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_297;
					case 3:
					{
						num = (short)135266304;
						short num3 = num;
						if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("眺吼儾⩀ᝂ㱄㝆ⱈ", a_)))
						{
							num = (short)2076442624;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)379584521;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (!base.Validate(this.RadioIDError))
						{
							num = (short)1287847947;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_380;
					case 5:
						goto IL_213;
					case 6:
						goto IL_19F;
					case 7:
						num = (short)821886990;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)1941438467;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (!base.Validate(this.LinkTypesError))
						{
							num = (short)64159754;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A4;
					case 10:
						goto IL_10F;
					case 11:
						goto IL_37B;
					case 12:
						num = (short)1549205505;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (!base.Validate(this.CAIError))
						{
							num = (short)206503941;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_386;
					case 14:
						if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("砺簼瘾", a_)))
						{
							num = (short)528809996;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1910767617;
						if (num != 0)
						{
						}
						num = (short)74645517;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						switch (0)
						{
						case 0:
							goto IL_71;
						}
						continue;
					case 16:
						goto IL_C9;
					}
					IL_71:
					if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("椺尼嬾⡀ⱂౄ͆", a_)))
					{
						num = (short)2075852807;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1528168452;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_C9:
				return string.Empty;
				IL_10F:
				return base.Error;
				IL_19F:
				return base.Error;
				IL_1A4:
				return string.Empty;
				IL_213:
				return base.Error;
				IL_297:
				return string.Empty;
				IL_37B:
				num = (short)447782045;
				short num4 = num;
				num = (short)1591188637;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_386:
					return string.Empty;
				default:
					num = (short)1067450368;
					if (num != 0)
					{
					}
					return base.Error;
				}
				IL_380:
				return string.Empty;
			}
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x000884B4 File Offset: 0x000866B4
		public override void CleanErrors()
		{
			short num = (short)1901822766;
			short num2 = num;
			num = (short)790987566;
			switch (num2 == num)
			{
			}
			num = (short)1319174144;
			if (num != 0)
			{
			}
			num = (short)799735808;
			short num3 = num;
			num = (short)525729793;
			if (num != 0)
			{
			}
			base.CleanErrors();
			this.d = string.Empty;
			this.f = string.Empty;
			this.j = string.Empty;
			this.h = string.Empty;
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x0008858C File Offset: 0x0008678C
		public bool HasError()
		{
			string passwordError = this.PasswordError;
			short num;
			if (string.IsNullOrEmpty(passwordError))
			{
				for (;;)
				{
					num = (short)493355008;
					short num2 = num;
					num = (short)1183092123;
					short num3 = num;
					num = (short)1088064923;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_6F;
					}
				}
				IL_6F:
				num = (short)2073821184;
				if (num != 0)
				{
				}
				return false;
			}
			num = (short)920256513;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x0400036E RID: 878
		private global::System.Guid a;

		// Token: 0x0400036F RID: 879
		private byte[] b;

		// Token: 0x04000370 RID: 880
		private int? c;

		// Token: 0x04000371 RID: 881
		private string d;

		// Token: 0x04000372 RID: 882
		private int? e;

		// Token: 0x04000373 RID: 883
		private string f;

		// Token: 0x04000374 RID: 884
		private global::Motorola.CommonCPS.Server.EntityModel.LinkType? g;

		// Token: 0x04000375 RID: 885
		private string h;

		// Token: 0x04000376 RID: 886
		private string i;

		// Token: 0x04000377 RID: 887
		private string j;

		// Token: 0x04000378 RID: 888
		private global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? k;

		// Token: 0x04000379 RID: 889
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool? l;

		// Token: 0x0400037A RID: 890
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string m;
	}
}
