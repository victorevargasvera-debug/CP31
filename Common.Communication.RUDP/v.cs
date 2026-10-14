using System;
using System.Collections.Generic;
using System.Threading;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x02000023 RID: 35
	internal class v : global::System.IDisposable
	{
		// Token: 0x0600017A RID: 378 RVA: 0x00018DB4 File Offset: 0x00016FB4
		public v()
		{
			int a_ = 16;
			this.b = true;
			this.e = new global::System.Threading.ReaderWriterLockSlim();
			this.f = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.t>();
			base..ctor();
			if (global::Motorola.Common.Communication.RUDP.u.QueryPerformanceFrequency(out this.a))
			{
				this.c = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.a));
				this.c.Name = global::Motorola.Common.Communication.RUDP.RUDPSocket.i("昳挵簷樹琻圽✿⩁Ճ╅⭇㽉㹋⽍⑏㝑S㽕㕗㽙⹛", a_);
				this.c.Priority = global::System.Threading.ThreadPriority.Highest;
				return;
			}
			this.d = new global::System.Threading.Timer(new global::System.Threading.TimerCallback(this.a), this, 0, 100);
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00018E54 File Offset: 0x00017054
		public void b(global::Motorola.Common.Communication.RUDP.t A_0)
		{
			short num;
			for (;;)
			{
				num = (short)1381695489;
				if (num != 0)
				{
				}
				this.e.EnterWriteLock();
				try
				{
					this.f.Add(A_0);
				}
				finally
				{
					this.e.ExitWriteLock();
				}
				num = (short)216298327;
				short num2 = num;
				num = (short)869036887;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_82;
				}
			}
			IL_82:
			num = (short)1093795840;
			if (num != 0)
			{
			}
			num = (short)312147968;
			short num3 = num;
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00018F34 File Offset: 0x00017134
		private void a(global::Motorola.Common.Communication.RUDP.t A_0)
		{
			short num;
			for (;;)
			{
				this.e.EnterWriteLock();
				try
				{
					num = (short)1519845377;
					if (num != 0)
					{
					}
					this.f.Remove(A_0);
				}
				finally
				{
					this.e.ExitWriteLock();
				}
				num = (short)2033060843;
				short num2 = num;
				num = (short)1984629739;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_84;
				}
			}
			IL_84:
			num = (short)1548288000;
			if (num != 0)
			{
			}
			num = (short)1688338432;
			short num3 = num;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00019014 File Offset: 0x00017214
		public void c()
		{
			this.b = true;
			short num;
			if (this.d != null)
			{
				num = (short)1633761713;
				short num2 = num;
				num = (short)1454193073;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)216858624;
					if (num != 0)
					{
					}
					num = (short)916389888;
					short num3 = num;
					this.d.Change(0, 100);
					return;
				}
				}
			}
			num = (short)2118582273;
			if (num != 0)
			{
			}
			this.c.Start();
		}

		// Token: 0x0600017E RID: 382 RVA: 0x000190EC File Offset: 0x000172EC
		private void b()
		{
			switch (0)
			{
			case 0:
				goto IL_65;
			}
			short num;
			int num3;
			for (;;)
			{
				IL_0A:
				num = (short)1987705474;
				short num2 = num;
				num = (short)1173486210;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)79888384;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						try
						{
							bool isAlive = this.c.IsAlive;
							return;
						}
						catch (global::System.Exception)
						{
							return;
						}
						goto IL_104;
					case 1:
						goto IL_A1;
					case 2:
						if (this.d != null)
						{
							num = (short)227803137;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_104;
					}
					goto IL_65;
					IL_104:
					break;
				}
				num = (short)1436614656;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_A1:
			num = (short)1961558016;
			short num4 = num;
			num = (short)870645761;
			if (num != 0)
			{
			}
			this.d.Change(-1, 100);
			this.d.Dispose();
			this.d = null;
			return;
			IL_65:
			this.b = false;
			num = (short)1569914882;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0001924C File Offset: 0x0001744C
		public void d()
		{
			short num = (short)2009672574;
			short num2 = num;
			num = (short)329263998;
			switch (num2 == num)
			{
			}
			num = (short)193658880;
			if (num != 0)
			{
			}
			num = (short)876019713;
			if (num != 0)
			{
			}
			num = (short)1842806784;
			short num3 = num;
			this.b();
			this.f.ForEach(new global::System.Action<global::Motorola.Common.Communication.RUDP.t>(global::Motorola.Common.Communication.RUDP.v.<>c.<>9.a));
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00019328 File Offset: 0x00017528
		private void a()
		{
			short num = (short)595329026;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				long num4;
				switch (num2)
				{
				case 1:
				{
					if (!this.b)
					{
						num = (short)1465581573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					long num3 = global::Motorola.Common.Communication.RUDP.t.d();
					this.a(this);
					num4 = global::Motorola.Common.Communication.RUDP.t.d() - num3;
					num = (short)1093402627;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 3:
				{
					num = (short)203308047;
					short num5 = num;
					num = (short)1394293775;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_156;
					default:
						num = (short)19136512;
						if (num != 0)
						{
						}
						if (100L > num4)
						{
							num = (short)1930362880;
							short num6 = num;
							num = (short)1024065540;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					break;
				}
				case 4:
					goto IL_156;
				case 5:
					return;
				}
				IL_3E:
				num = (short)1836711937;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3C:
				goto IL_3E;
				IL_156:
				num = (short)544604161;
				if (num != 0)
				{
				}
				global::System.Threading.Thread.Sleep((int)(100L - num4));
				num = (short)779616256;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x000194B8 File Offset: 0x000176B8
		private void a(object A_0)
		{
			short num = (short)971440128;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				case 1:
					try
					{
						using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.t>.Enumerator enumerator = this.f.GetEnumerator())
						{
							num = (short)1624637441;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									switch (0)
									{
									case 0:
										goto IL_C5;
									}
									continue;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)669384708;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									long a_;
									enumerator.Current.d(a_);
									num = (short)1316093952;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_138;
								case 4:
									num = (short)1410269187;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_C7:
								num = (short)649003010;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_C5:
								goto IL_C7;
							}
							IL_138:;
						}
						return;
					}
					catch (global::System.Exception)
					{
						return;
					}
					finally
					{
						this.e.ExitReadLock();
					}
					goto IL_15F;
				case 2:
					goto IL_15F;
				}
				IL_32:
				num = (short)1744633857;
				if (num != 0)
				{
				}
				if (this.b)
				{
					num = (short)770244610;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_15F:
				num = (short)1417927925;
				short num3 = num;
				num = (short)333831413;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1596194816;
					if (num != 0)
					{
					}
					num = (short)1652424704;
					short num4 = num;
					long a_ = global::Motorola.Common.Communication.RUDP.t.d();
					this.e.EnterReadLock();
					break;
				}
				}
				num = (short)484376577;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x000196F0 File Offset: 0x000178F0
		private static bool a(out long A_0)
		{
			short num = (short)1436418049;
			if (num != 0)
			{
			}
			num = (short)1994743576;
			short num2 = num;
			num = (short)2109497112;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_A6;
			case 1:
				break;
			default:
			{
				num = (short)739704832;
				short num3 = num;
				break;
			}
			}
			num = (short)1438056448;
			if (num != 0)
			{
			}
			if (global::Motorola.Common.Communication.RUDP.u.QueryPerformanceCounter(out A_0))
			{
				return true;
			}
			IL_A6:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RUDP_HighAccurateTimer_QueryPerformanceCounterFailed);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x000197B0 File Offset: 0x000179B0
		protected virtual void a(bool A_0)
		{
			short num = (short)256966658;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_5E;
				case 1:
					num = (short)867172355;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 3:
				{
					num = (short)367640687;
					short num3 = num;
					num = (short)1308147823;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_17F;
					default:
					{
						num = (short)1545928705;
						if (num != 0)
						{
						}
						num = (short)1166802944;
						if (num != 0)
						{
						}
						num = (short)1326907392;
						short num4 = num;
						if (A_0)
						{
							num = (short)1498480644;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5E;
					}
					}
					break;
				}
				case 4:
					goto IL_17F;
				case 5:
					return;
				}
				IL_3C:
				if (!this.h)
				{
					num = (short)1469579265;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_5E:
				this.h = true;
				num = (short)462749701;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_17F:
				this.d.Dispose();
				this.e.Dispose();
				num = (short)1090846720;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00019944 File Offset: 0x00017B44
		public void Dispose()
		{
			short num = (short)971484956;
			short num2 = num;
			num = (short)245477148;
			switch (num2 == num)
			{
			}
			num = (short)1944649729;
			if (num != 0)
			{
			}
			num = (short)1238564864;
			short num3 = num;
			num = (short)115605504;
			if (num != 0)
			{
			}
			this.a(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x040000C7 RID: 199
		private long a;

		// Token: 0x040000C8 RID: 200
		private bool b;

		// Token: 0x040000C9 RID: 201
		private global::System.Threading.Thread c;

		// Token: 0x040000CA RID: 202
		private global::System.Threading.Timer d;

		// Token: 0x040000CB RID: 203
		private global::System.Threading.ReaderWriterLockSlim e;

		// Token: 0x040000CC RID: 204
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.t> f;

		// Token: 0x040000CD RID: 205
		private const int g = 100;

		// Token: 0x040000CE RID: 206
		private bool h;
	}
}
