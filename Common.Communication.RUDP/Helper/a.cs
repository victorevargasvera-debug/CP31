using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.RUDP.Helper
{
	// Token: 0x0200002E RID: 46
	internal class a<a, b> : global::System.IAsyncResult, global::System.IDisposable
	{
		// Token: 0x060001C1 RID: 449 RVA: 0x0001CF64 File Offset: 0x0001B164
		public a(global::Motorola.Common.Communication.RUDP.Helper.a<a, b, a, b>.a A_0, a A_1, global::System.AsyncCallback A_2, object A_3)
		{
			this.i = new global::System.Threading.ManualResetEvent(false);
			this.c = A_2;
			this.d = A_3;
			this.g = A_1;
			this.h = A_0;
			this.e(A_0);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0001CFBC File Offset: 0x0001B1BC
		private void e(global::Motorola.Common.Communication.RUDP.Helper.a<a, b, a, b>.a A_0)
		{
			short num = (short)939970921;
			short num2 = num;
			num = (short)124703081;
			switch (num2 == num)
			{
			}
			num = (short)712966145;
			if (num != 0)
			{
			}
			num = (short)1513488384;
			if (num != 0)
			{
			}
			num = (short)336134144;
			short num3 = num;
			global::Motorola.Common.Communication.RUDP.Helper.a<a, b>.b b = new global::Motorola.Common.Communication.RUDP.Helper.a<a, b>.b();
			b.a = this;
			b.b = A_0;
			global::System.Threading.ThreadPool.QueueUserWorkItem(new global::System.Threading.WaitCallback(b.c));
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0001D088 File Offset: 0x0001B288
		public void i()
		{
			short num = (short)1262175894;
			short num2 = num;
			num = (short)138233494;
			switch (num2 == num)
			{
			}
			num = (short)665649152;
			if (num != 0)
			{
			}
			num = (short)264830977;
			if (num != 0)
			{
			}
			num = (short)498270208;
			short num3 = num;
			this.e(this.h);
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0001D140 File Offset: 0x0001B340
		public void j()
		{
			short num = (short)1534754304;
			short num2 = num;
			num = (short)402226688;
			switch (num2 == num)
			{
			}
			num = (short)1250361344;
			if (num != 0)
			{
			}
			num = (short)283443201;
			if (num != 0)
			{
			}
			num = (short)2062483456;
			short num3 = num;
			this.i.Set();
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0001D1F8 File Offset: 0x0001B3F8
		public b e(int timeout = 0)
		{
			int a_ = 12;
			short num = (short)106430467;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_F7;
				case 1:
					num = (short)1690304513;
					if (num != 0)
					{
					}
					num = (short)1791033348;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_1DC;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_61;
					}
					continue;
				case 4:
					if (this.get_AsyncWaitHandle().WaitOne(timeout))
					{
						num = (short)360710144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteWarning(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("戯朱瀳昵ᠷ笹伻䜽⸿⅁摃Յ⥇♉⁋湍я㭑㥓㍕㝗⽙⡛摝䁟ᥡ呣᭥էᥩ䱫", a_), new object[]
					{
						timeout
					});
					num = (short)761659394;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (timeout == 0)
					{
						num = (short)1019412489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)93847560;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)1175060485;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					num = (short)1905513736;
					short num3 = num;
					num = (short)1185993992;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)1797193728;
						if (num != 0)
						{
						}
						goto IL_1DC;
					}
					break;
				}
				case 8:
					if (!this.get_IsCompleted())
					{
						num = (short)1550254081;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_F7;
				case 9:
					this.get_AsyncWaitHandle().WaitOne();
					this.get_AsyncWaitHandle().Close();
					num = (short)1035796487;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					goto IL_1DC;
				case 11:
					if (this.f != null)
					{
						num = (short)2116091916;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2C5;
				case 12:
					goto IL_217;
				}
				IL_61:
				num = (short)1931935744;
				short num4 = num;
				if (!this.a)
				{
					num = (short)83492870;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1DC;
				IL_F7:
				this.get_AsyncWaitHandle().Close();
				num = (short)1710686218;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1DC:
				num = (short)760479755;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_217:
			throw this.f;
			IL_2C5:
			return this.e;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0001D4D0 File Offset: 0x0001B6D0
		public void e(b A_0)
		{
			short num = (short)429946122;
			short num2 = num;
			num = (short)101741834;
			switch (num2 == num)
			{
			}
			num = (short)599654401;
			if (num != 0)
			{
			}
			num = (short)1901789184;
			if (num != 0)
			{
			}
			num = (short)1440808960;
			short num3 = num;
			this.e = A_0;
			this.f();
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0001D588 File Offset: 0x0001B788
		public void f(b A_0)
		{
			short num = (short)613311753;
			short num2 = num;
			num = (short)473457929;
			switch (num2 == num)
			{
			}
			num = (short)308215808;
			if (num != 0)
			{
			}
			num = (short)1673592833;
			if (num != 0)
			{
			}
			num = (short)1901592576;
			short num3 = num;
			this.e = A_0;
			this.f();
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0001D640 File Offset: 0x0001B840
		public object get_AsyncState()
		{
			short num = (short)496469949;
			short num2 = num;
			num = (short)2089912253;
			switch (num2 == num)
			{
			}
			num = (short)1025310720;
			if (num != 0)
			{
			}
			num = (short)1707540481;
			if (num != 0)
			{
			}
			num = (short)729808896;
			short num3 = num;
			return this.d;
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0001D6F4 File Offset: 0x0001B8F4
		public global::System.Threading.WaitHandle get_AsyncWaitHandle()
		{
			short num = (short)658293756;
			short num2 = num;
			num = (short)207209468;
			switch (num2 == num)
			{
			}
			num = (short)1552678913;
			if (num != 0)
			{
			}
			num = (short)532152320;
			if (num != 0)
			{
			}
			num = (short)1045233664;
			short num3 = num;
			return this.g();
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0001D7A4 File Offset: 0x0001B9A4
		public bool get_CompletedSynchronously()
		{
			short num = (short)1756102899;
			short num2 = num;
			num = (short)1270939891;
			switch (num2 == num)
			{
			}
			num = (short)1089404929;
			if (num != 0)
			{
			}
			num = (short)766509056;
			if (num != 0)
			{
			}
			num = (short)843317248;
			short num3 = num;
			return this.k;
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0001D854 File Offset: 0x0001BA54
		public bool get_IsCompleted()
		{
			short num = (short)704336700;
			short num2 = num;
			num = (short)1835881276;
			switch (num2 == num)
			{
			}
			num = (short)1214578688;
			if (num != 0)
			{
			}
			num = (short)1986658305;
			if (num != 0)
			{
			}
			num = (short)1581449216;
			short num3 = num;
			return this.a;
		}

		// Token: 0x060001CC RID: 460 RVA: 0x0001D904 File Offset: 0x0001BB04
		private a h()
		{
			short num = (short)1201471489;
			if (num != 0)
			{
			}
			num = (short)896717357;
			short num2 = num;
			num = (short)925094445;
			switch (num2 == num)
			{
			}
			num = (short)1689845760;
			if (num != 0)
			{
			}
			num = (short)190644224;
			short num3 = num;
			return this.g;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x0001D9B4 File Offset: 0x0001BBB4
		private global::System.Threading.ManualResetEvent g()
		{
			short num = (short)176291840;
			short num2 = num;
			num = (short)255826316;
			short num3 = num;
			num = (short)1607309708;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)169279488;
				if (num != 0)
				{
				}
				num = (short)516685825;
				if (num != 0)
				{
				}
				object obj = this.l;
				bool flag = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_D3;
					}
					int num4;
					for (;;)
					{
						IL_B1:
						switch (num4)
						{
						case 0:
							if (this.b == null)
							{
								num = (short)1844379652;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_156;
						case 1:
							goto IL_1A8;
						case 2:
							this.b.Set();
							num = (short)169345029;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_156;
						case 4:
							this.b = new global::System.Threading.ManualResetEvent(false);
							num = (short)176947203;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_190;
						case 6:
							if (this.a)
							{
								num = (short)1899364354;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_190;
						}
						goto IL_D3;
						IL_156:
						num = (short)225181702;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_190:
						num = (short)834863105;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_1A8:
					break;
					IL_D3:
					global::System.Threading.Monitor.Enter(obj, ref flag);
					num = (short)892534784;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_B1;
				}
				finally
				{
					num = (short)386793472;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_1DB;
							}
							continue;
						case 1:
							goto IL_210;
						case 2:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)1277952001;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1DB:
						if (!flag)
						{
							break;
						}
						num = (short)1380777986;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_210:;
				}
				break;
			}
			}
			return this.b;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0001DBF8 File Offset: 0x0001BDF8
		private void f()
		{
			int a_ = 13;
			short num = (short)1978925056;
			short num2 = num;
			num = (short)443190828;
			short num3 = num;
			num = (short)1734250028;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1528758272;
				if (num != 0)
				{
				}
				num = (short)1632043009;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("挰昲焴朶ᤸ渺䴼嬾⁀㝂⁄ᑆ㵈⩊㥌㩎≐ݒ㩔ᑖ㙘㙚ⵜ㍞Ѡᝢd䝦㩨Ὢ౬ᵮհ", a_), global::System.Array.Empty<object>());
				this.a = true;
				object obj = this.l;
				bool flag = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_F7;
					}
					int num4;
					for (;;)
					{
						IL_E1:
						switch (num4)
						{
						case 0:
							goto IL_16B;
						case 1:
							if (this.b != null)
							{
								num = (short)1083113474;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_154;
						case 2:
							this.b.Set();
							num = (short)342753283;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_154;
						}
						goto IL_F7;
						IL_154:
						num = (short)1100742656;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_16B:
					break;
					IL_F7:
					global::System.Threading.Monitor.Enter(obj, ref flag);
					num = (short)1431568385;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_E1;
				}
				finally
				{
					num = (short)569311232;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_19D;
							}
							continue;
						case 1:
							goto IL_1D2;
						case 2:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)1626734593;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_19D:
						if (!flag)
						{
							break;
						}
						num = (short)1417412610;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_1D2:;
				}
				break;
			}
			}
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("挰昲焴朶ᤸ渺䴼嬾⁀㝂⁄ᑆ㵈⩊㥌㩎≐ݒ㩔ᑖ㙘㙚ⵜ㍞Ѡᝢd䝦ⱨժ६", a_), global::System.Array.Empty<object>());
			this.e();
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("挰昲焴朶ᤸ町刼䬾⡀╂㱄ц⡈❊⅌ⵎぐげ㹔Vㅘ㹚㍜Ṟᝠɢ౤୦ࡨ४Ŭ੮兰㙲᭴፶", a_), global::System.Array.Empty<object>());
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0001DE2C File Offset: 0x0001C02C
		private void e()
		{
			short num = (short)370212864;
			short num2 = num;
			num = (short)451018752;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
				{
					num = (short)2037242497;
					short num4 = num;
					num = (short)389143169;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1758068736;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A5;
						}
						continue;
					}
					break;
				}
				case 1:
					return;
				case 2:
					this.c(this);
					num = (short)405733377;
					if (num != 0)
					{
					}
					num = (short)1048772609;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A5:
				if (this.c == null)
				{
					break;
				}
				num = (short)992935938;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0001DF48 File Offset: 0x0001C148
		protected virtual void e(bool A_0)
		{
			short num = (short)526581760;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				case 1:
					return;
				case 2:
					if (A_0)
					{
						num = (short)875298820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_64;
				case 3:
					num = (short)1344143362;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					global::System.Threading.ManualResetEvent manualResetEvent = this.b;
					num = (short)1507852288;
					short num3 = num;
					num = (short)2002976773;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
				{
					num = (short)740515984;
					short num4 = num;
					num = (short)1698259088;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
						num = (short)1482424320;
						if (num != 0)
						{
						}
						num = (short)1511325697;
						if (num != 0)
						{
						}
						goto IL_64;
					}
					break;
				}
				}
				IL_3E:
				if (!this.m)
				{
					num = (short)2030370819;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_64:
				this.m = true;
				num = (short)978059265;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0001E0D4 File Offset: 0x0001C2D4
		public void Dispose()
		{
			short num = (short)1375178458;
			short num2 = num;
			num = (short)1671335642;
			switch (num2 == num)
			{
			}
			num = (short)343474176;
			if (num != 0)
			{
			}
			num = (short)1092485121;
			if (num != 0)
			{
			}
			num = (short)1703280640;
			short num3 = num;
			this.e(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x040000DE RID: 222
		private volatile bool a;

		// Token: 0x040000DF RID: 223
		private global::System.Threading.ManualResetEvent b;

		// Token: 0x040000E0 RID: 224
		private readonly global::System.AsyncCallback c;

		// Token: 0x040000E1 RID: 225
		private readonly object d;

		// Token: 0x040000E2 RID: 226
		private b e;

		// Token: 0x040000E3 RID: 227
		private global::System.Exception f;

		// Token: 0x040000E4 RID: 228
		private readonly a g;

		// Token: 0x040000E5 RID: 229
		private global::Motorola.Common.Communication.RUDP.Helper.a<a, b, a, b>.a h;

		// Token: 0x040000E6 RID: 230
		private global::System.Threading.ManualResetEvent i;

		// Token: 0x040000E7 RID: 231
		private bool j = true;

		// Token: 0x040000E8 RID: 232
		private bool k;

		// Token: 0x040000E9 RID: 233
		private readonly object l = new object();

		// Token: 0x040000EA RID: 234
		private bool m;

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x060001D3 RID: 467
		public delegate d a<in c, out d>(c A_0, global::System.IAsyncResult A_1);

		// Token: 0x02000030 RID: 48
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class b
		{
			// Token: 0x060001D7 RID: 471 RVA: 0x0001E19C File Offset: 0x0001C39C
			internal void c(object A_0)
			{
				int a_ = 16;
				short num = (short)1389625344;
				short num2 = num;
				num = (short)394634288;
				short num3 = num;
				num = (short)405185584;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1171718145;
					if (num != 0)
					{
					}
					num = (short)1041694720;
					if (num != 0)
					{
					}
					this.a.i.WaitOne();
					try
					{
						switch (0)
						{
						case 0:
							goto IL_E1;
						}
						int num4;
						for (;;)
						{
							IL_C3:
							switch (num4)
							{
							case 0:
								if (this.a.a)
								{
									num = (short)1167130627;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1AD;
							case 1:
								if (this.a.j)
								{
									num = (short)2049900549;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1AD;
							case 2:
								goto IL_1AD;
							case 3:
								num = (short)1998651393;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_1C4;
							case 5:
								this.a.k = true;
								this.a.j = false;
								num = (short)1014235138;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_E1;
							IL_1AD:
							num = (short)1498808324;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_1C4:
						break;
						IL_E1:
						this.b(this.a.g, this.a);
						num = (short)11468800;
						num4 = (int)((global::System.IntPtr)num);
						goto IL_C3;
					}
					catch (global::System.Exception ex)
					{
						this.a.f = ex;
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("昳挵簷樹ػḽԿ㩁❃⍅㡇㹉╋⅍㹏牑㵓㡕硗᭙⽛❝๟š䑣ե१٩k呭偯", a_) + ex.Message, global::System.Array.Empty<object>());
					}
					break;
				}
			}

			// Token: 0x040000EB RID: 235
			public global::Motorola.Common.Communication.RUDP.Helper.a<a, b> a;

			// Token: 0x040000EC RID: 236
			public global::Motorola.Common.Communication.RUDP.Helper.a<a, b, a, b>.a b;
		}
	}
}
