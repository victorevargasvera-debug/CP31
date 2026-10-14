using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Motorola.Common.LogUtility.PerformanceMeasurement;

namespace Motorola.Common.LogUtility
{
	// Token: 0x02000009 RID: 9
	public class ConsoleAppender : global::Motorola.Common.LogUtility.IAppender
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00004374 File Offset: 0x00002574
		public ConsoleAppender()
		{
			this.LoggingEvent += this.a;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000043A4 File Offset: 0x000025A4
		private void a(object A_0, global::Motorola.Common.LogUtility.LoggingEventArgs A_1)
		{
			int a_ = 19;
			short num = (short)412549120;
			short num2 = num;
			num = (short)252921731;
			short num3 = num;
			num = (short)1581074307;
			switch (num3 == num)
			{
			}
			num = (short)459800577;
			if (num != 0)
			{
			}
			num = (short)1289027584;
			if (num != 0)
			{
			}
			global::System.Console.WriteLine(global::Motorola.Common.LogUtility.LoggerUtil.LogTitle(((global::Motorola.Common.LogUtility.LogImpl)A_0).Name, A_1));
			global::System.Console.WriteLine(global::Motorola.Common.LogUtility.LoggerUtil.LogBody(A_1));
			global::System.Console.WriteLine(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("䩦䑨䙪䁬䉮屰干塴婶呸噺偼剾검꺂ꢄꪆꒈꚊꂌꊎ벐뺒뢔몖뒘뚚난늞負躢袤誦蒨蚪肬芮鲰麲颴", a_));
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000448C File Offset: 0x0000268C
		public void Close()
		{
			short num = (short)1590820864;
			short num2 = num;
			num = (short)999152410;
			short num3 = num;
			num = (short)559209242;
			switch (num3 == num)
			{
			}
			num = (short)2105999361;
			if (num != 0)
			{
			}
			num = (short)1789263872;
			if (num != 0)
			{
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000031 RID: 49 RVA: 0x00004538 File Offset: 0x00002738
		// (remove) Token: 0x06000032 RID: 50 RVA: 0x00004670 File Offset: 0x00002870
		public event global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs> LoggingEvent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				short num2;
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs> eventHandler;
					for (;;)
					{
						IL_0A:
						global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs> eventHandler2;
						switch (num)
						{
						case 0:
						{
							if (eventHandler != eventHandler2)
							{
								goto IL_3B;
							}
							num2 = (short)610398089;
							short num3 = num2;
							num2 = (short)299560841;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num2 = (short)1010761728;
								if (num2 != 0)
								{
								}
								num2 = (short)422969346;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						case 1:
							goto IL_3B;
						case 2:
							goto IL_FF;
						}
						break;
						IL_3B:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs> value2 = (global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs>>(ref this.b, value2, eventHandler2);
						num2 = (short)1710882817;
						if (num2 != 0)
						{
						}
						num2 = (short)976355328;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					eventHandler = this.b;
					num2 = (short)415170561;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_FF:
				num2 = (short)141754368;
				short num4 = num2;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				short num2;
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs> eventHandler;
					for (;;)
					{
						IL_0A:
						global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs> eventHandler2;
						switch (num)
						{
						case 0:
						{
							if (eventHandler != eventHandler2)
							{
								goto IL_62;
							}
							num2 = (short)1488620195;
							short num3 = num2;
							num2 = (short)1902283427;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num2 = (short)2128412672;
								if (num2 != 0)
								{
								}
								num2 = (short)1662713858;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						case 1:
							num2 = (short)761724929;
							if (num2 != 0)
							{
							}
							goto IL_62;
						case 2:
							goto IL_FD;
						}
						break;
						IL_62:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs> value2 = (global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs>>(ref this.b, value2, eventHandler2);
						num2 = (short)1300430848;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					eventHandler = this.b;
					num2 = (short)950272001;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_FD:
				num2 = (short)933429248;
				short num4 = num2;
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000047A4 File Offset: 0x000029A4
		public void DoAppend(object sender, global::Motorola.Common.LogUtility.LoggingEventArgs e)
		{
			short num = (short)755724714;
			short num2 = num;
			num = (short)703951274;
			object obj;
			bool flag;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_192:
				try
				{
					global::System.Threading.Monitor.Enter(obj, ref flag);
					this.b(sender, e);
					return;
				}
				finally
				{
					num = (short)972226561;
					num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)1435238402;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_110;
							}
							continue;
						case 2:
							goto IL_144;
						}
						IL_110:
						if (!flag)
						{
							break;
						}
						num = (short)2132148224;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_144:;
				}
				goto IL_147;
			default:
				num = (short)1901592576;
				if (num != 0)
				{
				}
				num = (short)2103902209;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				IL_68:
				switch (num3)
				{
				case 0:
					goto IL_C0;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_7A;
					}
					continue;
				case 2:
					goto IL_192;
				}
				IL_7A:
				if (this.b == null)
				{
					return;
				}
				num = (short)517603329;
				if (num != 0)
				{
				}
				num = (short)278069248;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_C0:
			IL_147:
			num = (short)182517760;
			short num4 = num;
			obj = this.a;
			flag = false;
			num = (short)1808269314;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_68;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000034 RID: 52 RVA: 0x00004958 File Offset: 0x00002B58
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00004A0C File Offset: 0x00002C0C
		public string Name
		{
			get
			{
				short num = (short)1644494848;
				short num2 = num;
				num = (short)741946889;
				short num3 = num;
				num = (short)695416329;
				switch (num3 == num)
				{
				}
				num = (short)895221760;
				if (num != 0)
				{
				}
				num = (short)2128478209;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)1447624704;
				short num2 = num;
				num = (short)125317945;
				short num3 = num;
				num = (short)2013410105;
				switch (num3 == num)
				{
				}
				num = (short)173211648;
				if (num != 0)
				{
				}
				num = (short)915603457;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000036 RID: 54 RVA: 0x00004AB8 File Offset: 0x00002CB8
		public bool IsEnabled
		{
			get
			{
				short num = (short)552075264;
				short num2 = num;
				num = (short)1344208897;
				if (num != 0)
				{
				}
				num = (short)1108227993;
				short num3 = num;
				num = (short)2083796889;
				switch (num3 == num)
				{
				}
				num = (short)1430781952;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x0400001B RID: 27
		private object a = new object();

		// Token: 0x0400001C RID: 28
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs> b;

		// Token: 0x0400001D RID: 29
		private string c;
	}
}
