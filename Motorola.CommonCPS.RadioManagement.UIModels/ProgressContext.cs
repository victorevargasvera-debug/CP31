using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x0200008B RID: 139
	public class ProgressContext : global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase
	{
		// Token: 0x14000009 RID: 9
		// (add) Token: 0x060004EF RID: 1263 RVA: 0x00049E2C File Offset: 0x0004802C
		// (remove) Token: 0x060004F0 RID: 1264 RVA: 0x00049F64 File Offset: 0x00048164
		[global::System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1009:DeclareEventHandlersCorrectly")]
		public event global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext.RateValueEventHandler RateValueChanaged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext.RateValueEventHandler rateValueEventHandler2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)456720384;
						short num3 = num2;
						num2 = (short)1557789976;
						short num4 = num2;
						num2 = (short)946470168;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_95;
						default:
							goto IL_114;
						}
						break;
					}
					case 1:
						num2 = (short)1254817793;
						if (num2 != 0)
						{
						}
						goto IL_60;
					case 2:
						goto IL_95;
					}
					goto IL_1C;
					IL_60:
					global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext.RateValueEventHandler rateValueEventHandler = rateValueEventHandler2;
					global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext.RateValueEventHandler value2 = (global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext.RateValueEventHandler)global::System.Delegate.Combine(rateValueEventHandler, value);
					rateValueEventHandler2 = global::System.Threading.Interlocked.CompareExchange<global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext.RateValueEventHandler>(ref this.a, value2, rateValueEventHandler);
					num2 = (short)314900482;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_95:
					if (rateValueEventHandler2 != rateValueEventHandler)
					{
						goto IL_60;
					}
					num2 = (short)216203264;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_114:
				num2 = (short)349831168;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				rateValueEventHandler2 = this.a;
				num2 = (short)1453654017;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext.RateValueEventHandler rateValueEventHandler2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1376124928;
						short num3 = num2;
						num2 = (short)2048037847;
						short num4 = num2;
						num2 = (short)1386451927;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6A;
						default:
							goto IL_E0;
						}
						break;
					}
					case 1:
						goto IL_39;
					case 2:
						goto IL_6A;
					}
					goto IL_1C;
					IL_39:
					global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext.RateValueEventHandler rateValueEventHandler = rateValueEventHandler2;
					global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext.RateValueEventHandler value2 = (global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext.RateValueEventHandler)global::System.Delegate.Remove(rateValueEventHandler, value);
					rateValueEventHandler2 = global::System.Threading.Interlocked.CompareExchange<global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext.RateValueEventHandler>(ref this.a, value2, rateValueEventHandler);
					num2 = (short)1866268674;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_6A:
					if (rateValueEventHandler2 != rateValueEventHandler)
					{
						goto IL_39;
					}
					num2 = (short)1886257152;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_E0:
				num2 = (short)1983184897;
				if (num2 != 0)
				{
				}
				num2 = (short)1011286016;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				rateValueEventHandler2 = this.a;
				num2 = (short)1844248577;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0004A090 File Offset: 0x00048290
		public ProgressContext()
		{
			this.i = 100;
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0004A0BC File Offset: 0x000482BC
		public ProgressContext(int maximuum)
		{
			this.i = maximuum;
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x0004A0E4 File Offset: 0x000482E4
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x0004A194 File Offset: 0x00048394
		public string Description
		{
			get
			{
				short num = (short)902332620;
				short num2 = num;
				num = (short)1239449804;
				switch (num2 == num)
				{
				}
				num = (short)1333198848;
				if (num != 0)
				{
				}
				num = (short)1641283585;
				if (num != 0)
				{
				}
				num = (short)157810688;
				short num3 = num;
				return this.b;
			}
			set
			{
				short num = (short)2130444289;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 2:
					{
						num = (short)1931411457;
						if (num != 0)
						{
						}
						num = (short)1709566301;
						short num3 = num;
						num = (short)1025501533;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num = (short)2049572864;
							if (num != 0)
							{
							}
							num = (short)2001993728;
							short num4 = num;
							this.b = value;
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext.get_Description())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							break;
						}
						}
						num = (short)127008768;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_30:
					if (!(value != this.b))
					{
						break;
					}
					num = (short)118882306;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x0004A2E8 File Offset: 0x000484E8
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x0004A398 File Offset: 0x00048598
		public bool IsCancelled
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)339807558;
				short num2 = num;
				num = (short)32443718;
				switch (num2 == num)
				{
				}
				num = (short)714342401;
				if (num != 0)
				{
				}
				num = (short)518127616;
				if (num != 0)
				{
				}
				num = (short)1073348608;
				short num3 = num;
				return this.h;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1535248711;
				short num2 = num;
				num = (short)163383623;
				switch (num2 == num)
				{
				}
				num = (short)1240072193;
				if (num != 0)
				{
				}
				num = (short)68288512;
				if (num != 0)
				{
				}
				num = (short)1120075776;
				short num3 = num;
				this.h = value;
			}
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x0004A448 File Offset: 0x00048648
		// (set) Token: 0x060004F8 RID: 1272 RVA: 0x0004A4F8 File Offset: 0x000486F8
		public double Rate
		{
			get
			{
				short num = (short)1797519656;
				short num2 = num;
				num = (short)82704680;
				switch (num2 == num)
				{
				}
				num = (short)616103937;
				if (num != 0)
				{
				}
				num = (short)1251475456;
				if (num != 0)
				{
				}
				num = (short)1586626560;
				short num3 = num;
				return this.c;
			}
			set
			{
				short num = (short)1225785345;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_177;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_3E;
						}
						continue;
					case 2:
						if (this.a != null)
						{
							num = (short)765722627;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_63;
					case 3:
					{
						this.a(value);
						num = (short)1201864704;
						short num3 = num;
						num = (short)1381302272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						this.c = value;
						num = (short)1220214786;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						num = (short)220397569;
						if (num != 0)
						{
						}
						num = (short)1295137044;
						short num4 = num;
						num = (short)524761364;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_177;
						default:
							goto IL_10F;
						}
						break;
					}
					}
					IL_3E:
					if (value != this.c)
					{
						num = (short)803864580;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_63:
					base.RaisePropertyChanged<double>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<double>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext.get_Rate())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)251658245;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_177:
					goto IL_63;
				}
				IL_10F:
				num = (short)342228992;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x060004F9 RID: 1273 RVA: 0x0004A6C8 File Offset: 0x000488C8
		public int Maximum
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)417988608;
				short num2 = num;
				num = (short)1483000466;
				short num3 = num;
				num = (short)1500826258;
				switch (num3 == num)
				{
				}
				num = (short)1557790721;
				if (num != 0)
				{
				}
				num = (short)1660878848;
				if (num != 0)
				{
				}
				return this.i;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x060004FA RID: 1274 RVA: 0x0004A778 File Offset: 0x00048978
		// (set) Token: 0x060004FB RID: 1275 RVA: 0x0004A828 File Offset: 0x00048A28
		public string Title
		{
			get
			{
				short num = (short)1307443200;
				short num2 = num;
				num = (short)1264096495;
				short num3 = num;
				num = (short)1725207791;
				switch (num3 == num)
				{
				}
				num = (short)1594359808;
				if (num != 0)
				{
				}
				num = (short)854327297;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)1349058560;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1803046340;
						short num3 = num;
						num = (short)241454532;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)2047606784;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_7D;
							}
							continue;
						}
						break;
					}
					case 1:
						num = (short)1466695681;
						if (num != 0)
						{
						}
						this.d = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext.get_Title())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)306380802;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return;
					}
					IL_7D:
					num = (short)1050935296;
					short num4 = num;
					if (!(value != this.d))
					{
						break;
					}
					num = (short)1671495681;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x060004FC RID: 1276 RVA: 0x0004A980 File Offset: 0x00048B80
		// (set) Token: 0x060004FD RID: 1277 RVA: 0x0004AA34 File Offset: 0x00048C34
		public bool IsSupportCancel
		{
			get
			{
				short num = (short)363659264;
				short num2 = num;
				num = (short)1868487280;
				short num3 = num;
				num = (short)483646064;
				switch (num3 == num)
				{
				}
				num = (short)418709505;
				if (num != 0)
				{
				}
				num = (short)504233984;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)907018240;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1414316133;
						short num3 = num;
						num = (short)266780773;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)879624192;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_7A;
							}
							continue;
						}
						break;
					}
					case 1:
						this.e = value;
						num = (short)749993986;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_DD;
					}
					IL_7A:
					num = (short)1585905664;
					short num4 = num;
					if (value == this.e)
					{
						break;
					}
					num = (short)1000407041;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_DD:
				num = (short)918487041;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x060004FE RID: 1278 RVA: 0x0004AB48 File Offset: 0x00048D48
		// (set) Token: 0x060004FF RID: 1279 RVA: 0x0004ABF4 File Offset: 0x00048DF4
		public bool IsShowProgressBar
		{
			get
			{
				short num = (short)632422400;
				short num2 = num;
				num = (short)1098545720;
				short num3 = num;
				num = (short)1098873400;
				switch (num3 == num)
				{
				}
				num = (short)744488961;
				if (num != 0)
				{
				}
				num = (short)2025455616;
				if (num != 0)
				{
				}
				return this.f;
			}
			set
			{
				short num = (short)1492189184;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1002121309;
						short num3 = num;
						num = (short)728508509;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)472449024;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_7C;
							}
							continue;
						}
						break;
					}
					case 1:
						this.f = value;
						num = (short)434372610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return;
					}
					IL_7C:
					num = (short)1329201152;
					short num4 = num;
					num = (short)606208001;
					if (num != 0)
					{
					}
					if (value == this.f)
					{
						break;
					}
					num = (short)2066415617;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700023E RID: 574
		// (get) Token: 0x06000500 RID: 1280 RVA: 0x0004AD0C File Offset: 0x00048F0C
		// (set) Token: 0x06000501 RID: 1281 RVA: 0x0004ADB8 File Offset: 0x00048FB8
		public global::System.Threading.CancellationTokenSource CancellationToken
		{
			get
			{
				short num = (short)107872256;
				short num2 = num;
				num = (short)1700855809;
				if (num != 0)
				{
				}
				num = (short)355256835;
				short num3 = num;
				num = (short)679397891;
				switch (num3 == num)
				{
				}
				num = (short)570687488;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				short num = (short)212271104;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)43035049;
						short num3 = num;
						num = (short)1686612393;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)374145024;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_7B;
							}
							continue;
						}
						break;
					}
					case 1:
						this.g = value;
						num = (short)1389232130;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return;
					}
					IL_7B:
					num = (short)643563520;
					short num4 = num;
					if (value == this.g)
					{
						break;
					}
					num = (short)1680605185;
					if (num != 0)
					{
					}
					num = (short)363790337;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x04000251 RID: 593
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.RadioManagement.UIModels.ProgressContext.RateValueEventHandler a;

		// Token: 0x04000252 RID: 594
		private string b;

		// Token: 0x04000253 RID: 595
		private double c;

		// Token: 0x04000254 RID: 596
		private string d;

		// Token: 0x04000255 RID: 597
		private bool e = true;

		// Token: 0x04000256 RID: 598
		private bool f = true;

		// Token: 0x04000257 RID: 599
		private global::System.Threading.CancellationTokenSource g;

		// Token: 0x04000258 RID: 600
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool h;

		// Token: 0x04000259 RID: 601
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly int i;

		// Token: 0x0200008C RID: 140
		// (Invoke) Token: 0x06000503 RID: 1283
		public delegate void RateValueEventHandler(double value);
	}
}
