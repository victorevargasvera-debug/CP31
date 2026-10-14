using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Motorola.Common.LogUtility.PerformanceMeasurement;

namespace Motorola.Common.LogUtility
{
	// Token: 0x02000007 RID: 7
	public class ADONetAppender : global::Motorola.Common.LogUtility.IAppender
	{
		// Token: 0x0600001F RID: 31 RVA: 0x00003B98 File Offset: 0x00001D98
		public ADONetAppender()
		{
			this.LoggingEvent += this.a;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003BC0 File Offset: 0x00001DC0
		private void a(object A_0, global::Motorola.Common.LogUtility.LoggingEventArgs A_1)
		{
			int a_ = 13;
			short num = (short)1800929280;
			short num2 = num;
			num = (short)656501057;
			short num3 = num;
			num = (short)1029007681;
			switch (num3 == num)
			{
			}
			num = (short)2054946817;
			if (num != 0)
			{
			}
			num = (short)1021378560;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException(global::Motorola.Common.LogUtility.PerformanceMeasurement.PerformanceExtensions.b("㕠ୢd䝦Ѩ๪ᥬݮṰᝲ啴ᡶ୸孺ቼཾ꾎떔練붜철펢즤슦쒨캪쎬\udbae풰ힲ鮴", a_));
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003C88 File Offset: 0x00001E88
		public void Close()
		{
			short num = (short)620298240;
			short num2 = num;
			num = (short)1984994650;
			short num3 = num;
			num = (short)1192992090;
			switch (num3 == num)
			{
			}
			num = (short)1823932417;
			if (num != 0)
			{
			}
			num = (short)929234944;
			if (num != 0)
			{
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000022 RID: 34 RVA: 0x00003D38 File Offset: 0x00001F38
		// (remove) Token: 0x06000023 RID: 35 RVA: 0x00003E6C File Offset: 0x0000206C
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
								goto IL_61;
							}
							num2 = (short)1903132645;
							short num3 = num2;
							num2 = (short)2064220133;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num2 = (short)1081212928;
								if (num2 != 0)
								{
								}
								num2 = (short)1816723458;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						case 1:
							goto IL_61;
						case 2:
							goto IL_FB;
						}
						break;
						IL_61:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs> value2 = (global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs>)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs>>(ref this.b, value2, eventHandler2);
						num2 = (short)1213988864;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					num2 = (short)467664897;
					if (num2 != 0)
					{
					}
					eventHandler = this.b;
					num2 = (short)1564803073;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_FB:
				num2 = (short)1268514816;
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
								goto IL_3A;
							}
							num2 = (short)1167261662;
							short num3 = num2;
							num2 = (short)953483230;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num2 = (short)288423936;
								if (num2 != 0)
								{
								}
								num2 = (short)2084175873;
								if (num2 != 0)
								{
								}
								num2 = (short)1848180738;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							break;
						}
						case 1:
							goto IL_3A;
						case 2:
							goto IL_FA;
						}
						break;
						IL_3A:
						eventHandler2 = eventHandler;
						global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs> value2 = (global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs>)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs>>(ref this.b, value2, eventHandler2);
						num2 = (short)1622802432;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1C:
					eventHandler = this.b;
					num2 = (short)768540673;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_FA:
				num2 = (short)1044840448;
				short num4 = num2;
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003FA0 File Offset: 0x000021A0
		public void DoAppend(object sender, global::Motorola.Common.LogUtility.LoggingEventArgs e)
		{
			short num = (short)1539915035;
			short num2 = num;
			num = (short)739786011;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2066743296;
				if (num != 0)
				{
				}
				num = (short)439681025;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
					{
						num = (short)1941635072;
						short num4 = num;
						this.b(sender, e);
						num = (short)974323714;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)706084865;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_A1;
						}
						continue;
					case 2:
						return;
					}
					IL_A1:
					if (this.b == null)
					{
						break;
					}
					num = (short)1358036992;
					num3 = (int)((global::System.IntPtr)num);
				}
				break;
			}
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000040BC File Offset: 0x000022BC
		// (set) Token: 0x06000026 RID: 38 RVA: 0x0000416C File Offset: 0x0000236C
		public string Name
		{
			get
			{
				short num = (short)636944384;
				short num2 = num;
				num = (short)715279832;
				short num3 = num;
				num = (short)179719640;
				switch (num3 == num)
				{
				}
				num = (short)530513920;
				if (num != 0)
				{
				}
				num = (short)1385234433;
				if (num != 0)
				{
				}
				return string.Empty;
			}
			set
			{
				short num = (short)862781440;
				short num2 = num;
				num = (short)936894826;
				short num3 = num;
				num = (short)314302826;
				switch (num3 == num)
				{
				}
				num = (short)1199767553;
				if (num != 0)
				{
				}
				num = (short)2087387136;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00004218 File Offset: 0x00002418
		public bool IsEnabled
		{
			get
			{
				short num = (short)2096300032;
				short num2 = num;
				num = (short)293905922;
				short num3 = num;
				num = (short)62957058;
				switch (num3 == num)
				{
				}
				num = (short)1137311745;
				if (num != 0)
				{
				}
				num = (short)830865408;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000042C0 File Offset: 0x000024C0
		// Note: this type is marked as 'beforefieldinit'.
		static ADONetAppender()
		{
			short num = (short)917635072;
			short num2 = num;
			num = (short)1368572566;
			short num3 = num;
			num = (short)198886038;
			switch (num3 == num)
			{
			}
			num = (short)862126081;
			if (num != 0)
			{
			}
			num = (short)295239680;
			if (num != 0)
			{
			}
			global::Motorola.Common.LogUtility.ADONetAppender.a = new object();
		}

		// Token: 0x04000019 RID: 25
		private static object a;

		// Token: 0x0400001A RID: 26
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler<global::Motorola.Common.LogUtility.LoggingEventArgs> b;
	}
}
