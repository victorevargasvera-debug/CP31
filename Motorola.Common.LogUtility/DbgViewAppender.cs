using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Motorola.Common.LogUtility
{
	// Token: 0x0200000A RID: 10
	public class DbgViewAppender : global::Motorola.Common.LogUtility.IAppender
	{
		// Token: 0x06000037 RID: 55 RVA: 0x00004B68 File Offset: 0x00002D68
		public DbgViewAppender()
		{
			this.LoggingEvent += this.a;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00004B98 File Offset: 0x00002D98
		private void a(object A_0, global::Motorola.Common.LogUtility.LoggingEventArgs A_1)
		{
			short num = (short)344784896;
			short num2 = num;
			num = (short)1836347576;
			short num3 = num;
			num = (short)460746936;
			switch (num3 == num)
			{
			}
			num = (short)862846977;
			if (num != 0)
			{
			}
			num = (short)783548416;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004C44 File Offset: 0x00002E44
		public void Close()
		{
			short num = (short)1512833024;
			short num2 = num;
			num = (short)1422393345;
			if (num != 0)
			{
			}
			num = (short)1891566863;
			short num3 = num;
			num = (short)1145701647;
			switch (num3 == num)
			{
			}
			num = (short)1291321344;
			if (num != 0)
			{
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600003A RID: 58 RVA: 0x00004CEC File Offset: 0x00002EEC
		// (remove) Token: 0x0600003B RID: 59 RVA: 0x00004E24 File Offset: 0x00003024
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
								goto IL_62;
							}
							num2 = (short)1706457344;
							short num3 = num2;
							num2 = (short)486897920;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num2 = (short)1703280640;
								if (num2 != 0)
								{
								}
								num2 = (short)469958658;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						case 1:
							goto IL_62;
						case 2:
							goto IL_FD;
						}
						break;
						IL_62:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs> value2 = (global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs>>(ref this.b, value2, eventHandler2);
						num2 = (short)759758848;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					num2 = (short)479461377;
					if (num2 != 0)
					{
					}
					eventHandler = this.b;
					num2 = (short)505806849;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_FD:
				num2 = (short)2118254592;
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
								goto IL_3B;
							}
							num2 = (short)306118657;
							if (num2 != 0)
							{
							}
							num2 = (short)1960631496;
							short num3 = num2;
							num2 = (short)723836104;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num2 = (short)827916288;
								if (num2 != 0)
								{
								}
								num2 = (short)56098818;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						case 1:
							goto IL_3B;
						case 2:
							goto IL_FA;
						}
						break;
						IL_3B:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs> value2 = (global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs>>(ref this.b, value2, eventHandler2);
						num2 = (short)835715072;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					eventHandler = this.b;
					num2 = (short)1078657025;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_FA:
				num2 = (short)1324351488;
				short num4 = num2;
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00004F58 File Offset: 0x00003158
		public void DoAppend(object sender, global::Motorola.Common.LogUtility.LoggingEventArgs e)
		{
			short num = (short)481960968;
			short num2 = num;
			num = (short)670376968;
			object obj;
			bool flag;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_18F:
				try
				{
					global::System.Threading.Monitor.Enter(obj, ref flag);
					this.b(sender, e);
					return;
				}
				finally
				{
					num = (short)893059073;
					num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							global::System.Threading.Monitor.Exit(obj);
							num = (short)957284354;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_10F;
							}
							continue;
						case 2:
							goto IL_143;
						}
						IL_10F:
						if (!flag)
						{
							break;
						}
						num = (short)381419520;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_143:;
				}
				goto IL_146;
			default:
				num = (short)17432577;
				if (num != 0)
				{
				}
				num = (short)1645674496;
				if (num != 0)
				{
				}
				num = (short)1147338753;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				IL_8F:
				switch (num3)
				{
				case 0:
					goto IL_C0;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_A1;
					}
					continue;
				case 2:
					goto IL_18F;
				}
				IL_A1:
				if (this.b == null)
				{
					return;
				}
				num = (short)1680211968;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_C0:
			IL_146:
			num = (short)682950656;
			short num4 = num;
			obj = this.a;
			flag = false;
			num = (short)467533826;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_8F;
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600003D RID: 61 RVA: 0x0000510C File Offset: 0x0000330C
		// (set) Token: 0x0600003E RID: 62 RVA: 0x000051BC File Offset: 0x000033BC
		public string Name
		{
			get
			{
				short num = (short)1155268608;
				short num2 = num;
				num = (short)1937510293;
				short num3 = num;
				num = (short)534122389;
				switch (num3 == num)
				{
				}
				num = (short)570425345;
				if (num != 0)
				{
				}
				num = (short)409337856;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)202375168;
				short num2 = num;
				num = (short)1035473456;
				short num3 = num;
				num = (short)1521816112;
				switch (num3 == num)
				{
				}
				num = (short)1299775489;
				if (num != 0)
				{
				}
				num = (short)484442112;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00005268 File Offset: 0x00003468
		public bool IsEnabled
		{
			get
			{
				short num = (short)2006056960;
				short num2 = num;
				num = (short)322298857;
				short num3 = num;
				num = (short)828564457;
				switch (num3 == num)
				{
				}
				num = (short)1964703745;
				if (num != 0)
				{
				}
				num = (short)283312128;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x0400001E RID: 30
		private object a = new object();

		// Token: 0x0400001F RID: 31
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs> b;

		// Token: 0x04000020 RID: 32
		private string c;
	}
}
