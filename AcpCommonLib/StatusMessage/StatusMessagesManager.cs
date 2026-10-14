using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Threading;

namespace AcpCommonLib.StatusMessage
{
	// Token: 0x02000038 RID: 56
	public class StatusMessagesManager
	{
		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600023B RID: 571 RVA: 0x00015B38 File Offset: 0x00013D38
		// (remove) Token: 0x0600023C RID: 572 RVA: 0x00015C70 File Offset: 0x00013E70
		public static event global::AcpCommonLib.StatusMessage.NotifyMsgListChangedEventHandler NotifyMsgListChangedEvent
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
					global::AcpCommonLib.StatusMessage.NotifyMsgListChangedEventHandler notifyMsgListChangedEventHandler;
					for (;;)
					{
						IL_0A:
						switch (num)
						{
						case 0:
							goto IL_3A;
						case 1:
						{
							global::AcpCommonLib.StatusMessage.NotifyMsgListChangedEventHandler notifyMsgListChangedEventHandler2;
							if (notifyMsgListChangedEventHandler == notifyMsgListChangedEventHandler2)
							{
								num2 = (short)554172418;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_3A;
						}
						case 2:
							goto IL_100;
						}
						break;
						IL_3A:
						num2 = (short)1040948062;
						short num3 = num2;
						num2 = (short)189373278;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num2 = (short)1409155072;
							short num4 = num2;
							num2 = (short)1821245440;
							if (num2 != 0)
							{
							}
							global::AcpCommonLib.StatusMessage.NotifyMsgListChangedEventHandler notifyMsgListChangedEventHandler2 = notifyMsgListChangedEventHandler;
							global::AcpCommonLib.StatusMessage.NotifyMsgListChangedEventHandler value2 = (global::AcpCommonLib.StatusMessage.NotifyMsgListChangedEventHandler)global::System.Delegate.Combine(notifyMsgListChangedEventHandler2, value);
							notifyMsgListChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpCommonLib.StatusMessage.NotifyMsgListChangedEventHandler>(ref global::AcpCommonLib.StatusMessage.StatusMessagesManager.d, value2, notifyMsgListChangedEventHandler2);
							num2 = (short)1164705793;
							num = (int)((global::System.IntPtr)num2);
							break;
						}
						}
					}
					IL_1C:
					notifyMsgListChangedEventHandler = global::AcpCommonLib.StatusMessage.StatusMessagesManager.d;
					num2 = (short)1504444416;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_100:
				num2 = (short)819331073;
				if (num2 != 0)
				{
				}
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					short num2;
					global::AcpCommonLib.StatusMessage.NotifyMsgListChangedEventHandler notifyMsgListChangedEventHandler;
					for (;;)
					{
						IL_0A:
						switch (num)
						{
						case 0:
							goto IL_38;
						case 1:
						{
							num2 = (short)2110062593;
							if (num2 != 0)
							{
							}
							global::AcpCommonLib.StatusMessage.NotifyMsgListChangedEventHandler notifyMsgListChangedEventHandler2;
							if (notifyMsgListChangedEventHandler == notifyMsgListChangedEventHandler2)
							{
								num2 = (short)2086207490;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_38;
						}
						case 2:
							return;
						}
						break;
						IL_38:
						num2 = (short)17822627;
						short num3 = num2;
						num2 = (short)1905783715;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num2 = (short)756154368;
							short num4 = num2;
							num2 = (short)1801584640;
							if (num2 != 0)
							{
							}
							global::AcpCommonLib.StatusMessage.NotifyMsgListChangedEventHandler notifyMsgListChangedEventHandler2 = notifyMsgListChangedEventHandler;
							global::AcpCommonLib.StatusMessage.NotifyMsgListChangedEventHandler value2 = (global::AcpCommonLib.StatusMessage.NotifyMsgListChangedEventHandler)global::System.Delegate.Remove(notifyMsgListChangedEventHandler2, value);
							notifyMsgListChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpCommonLib.StatusMessage.NotifyMsgListChangedEventHandler>(ref global::AcpCommonLib.StatusMessage.StatusMessagesManager.d, value2, notifyMsgListChangedEventHandler2);
							num2 = (short)1210056705;
							num = (int)((global::System.IntPtr)num2);
							break;
						}
						}
					}
					IL_1C:
					notifyMsgListChangedEventHandler = global::AcpCommonLib.StatusMessage.StatusMessagesManager.d;
					num2 = (short)1776615424;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
			}
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00015DA8 File Offset: 0x00013FA8
		public void Clear()
		{
			short num = (short)886177792;
			short num2 = num;
			num = (short)2098200577;
			if (num != 0)
			{
			}
			num = (short)657654644;
			short num3 = num;
			num = (short)353698676;
			switch (num3 == num)
			{
			}
			num = (short)1244725248;
			if (num != 0)
			{
			}
			this.a.Clear();
			this.MessageListChanged = true;
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600023E RID: 574 RVA: 0x00015E64 File Offset: 0x00014064
		public bool HasMsgs
		{
			get
			{
				short num = (short)1637285888;
				short num2 = num;
				num = (short)1920633602;
				short num3 = num;
				num = (short)871860994;
				switch (num3 == num)
				{
				}
				num = (short)1350500353;
				if (num != 0)
				{
				}
				num = (short)389218304;
				if (num != 0)
				{
				}
				return this.a.Count > 0;
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00015F1C File Offset: 0x0001411C
		public bool ContainsField(string message)
		{
			short num;
			for (;;)
			{
				num = (short)378601472;
				short num2 = num;
				if (message == null)
				{
					return false;
				}
				num = (short)861281110;
				short num3 = num;
				num = (short)1848908630;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_77;
				}
			}
			IL_77:
			num = (short)1197998081;
			if (num != 0)
			{
			}
			num = (short)856162304;
			if (num != 0)
			{
			}
			return this.a.Exists(new global::System.Predicate<global::AcpCommonLib.StatusMessage.StatusMessageInfo>(a.b));
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000240 RID: 576 RVA: 0x00015FF8 File Offset: 0x000141F8
		public global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.StatusMessage.StatusMessageInfo> Messages
		{
			get
			{
				short num = (short)1150156800;
				short num2 = num;
				num = (short)808631899;
				short num3 = num;
				num = (short)337624667;
				switch (num3 == num)
				{
				}
				num = (short)882376705;
				if (num != 0)
				{
				}
				num = (short)362217472;
				if (num != 0)
				{
				}
				global::AcpCommonLib.StatusMessage.StatusMessagesManager.b b = new global::AcpCommonLib.StatusMessage.StatusMessagesManager.b(-2);
				b.d = this;
				return b;
			}
		}

		// Token: 0x06000241 RID: 577 RVA: 0x000160B0 File Offset: 0x000142B0
		public void PostMessage(global::AcpCommonLib.StatusMsgType type, string message)
		{
			short num = (short)1465188352;
			short num2 = num;
			num = (short)910188907;
			short num3 = num;
			num = (short)1284858219;
			switch (num3 == num)
			{
			}
			num = (short)56754177;
			if (num != 0)
			{
			}
			num = (short)495255552;
			if (num != 0)
			{
			}
			this.a.Add(new global::AcpCommonLib.StatusMessage.StatusMessageInfo(type, message));
			this.a();
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00016174 File Offset: 0x00014374
		public void RegisterMessage(global::AcpCommonLib.StatusMsgType type, string message)
		{
			short num = (short)1953562624;
			short num2 = num;
			num = (short)1420287488;
			short num3 = num;
			num = (short)886562304;
			switch (num3 == num)
			{
			}
			num = (short)741081089;
			if (num != 0)
			{
			}
			num = (short)2093154304;
			if (num != 0)
			{
			}
			this.a.Add(new global::AcpCommonLib.StatusMessage.StatusMessageInfo(type, message));
			this.MessageListChanged = true;
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00016238 File Offset: 0x00014438
		public void UnregisterMessage(string message)
		{
			short num = (short)708968448;
			short num2 = num;
			num = (short)1148780545;
			if (num != 0)
			{
			}
			num = (short)909213489;
			short num3 = num;
			num = (short)1408859953;
			switch (num3 == num)
			{
			}
			num = (short)1018626048;
			if (num != 0)
			{
			}
			global::AcpCommonLib.StatusMessage.StatusMessagesManager.c c = new global::AcpCommonLib.StatusMessage.StatusMessagesManager.c();
			c.a = message;
			int index = this.a.FindIndex(new global::System.Predicate<global::AcpCommonLib.StatusMessage.StatusMessageInfo>(c.b));
			this.a.RemoveAt(index);
			this.MessageListChanged = true;
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000244 RID: 580 RVA: 0x0001631C File Offset: 0x0001451C
		// (set) Token: 0x06000245 RID: 581 RVA: 0x000163CC File Offset: 0x000145CC
		public bool MessageListChanged
		{
			get
			{
				short num = (short)578682880;
				short num2 = num;
				num = (short)955819042;
				short num3 = num;
				num = (short)484025378;
				switch (num3 == num)
				{
				}
				num = (short)741539840;
				if (num != 0)
				{
				}
				num = (short)1674051585;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				for (;;)
				{
					IL_00:
					switch (0)
					{
					case 0:
						goto IL_1C;
					}
					int num;
					short num2;
					for (;;)
					{
						IL_0A:
						switch (num)
						{
						case 0:
						{
							if (global::AcpCommonLib.StatusMessage.StatusMessagesManager.d == null)
							{
								return;
							}
							num2 = (short)1870589301;
							short num3 = num2;
							num2 = (short)1202580853;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num2 = (short)1867186176;
								short num4 = num2;
								num2 = (short)698417152;
								if (num2 != 0)
								{
								}
								num2 = (short)1519124481;
								if (num2 != 0)
								{
								}
								num2 = (short)1839726593;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							}
							break;
						}
						case 1:
							global::AcpCommonLib.StatusMessage.StatusMessagesManager.d(null, new global::AcpCommonLib.StatusMessage.NotifyMsgListChangedEventArgs());
							num2 = (short)1624965122;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 2:
							return;
						}
						break;
					}
					IL_1C:
					this.b = value;
					num2 = (short)1269628928;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x000164FC File Offset: 0x000146FC
		private void a()
		{
			short num = (short)1036713985;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.c = new global::System.Windows.Threading.DispatcherTimer(global::System.Windows.Threading.DispatcherPriority.Normal);
					this.c.Tick += this.a;
					num = (short)1116340227;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 2:
				{
					num = (short)1135267162;
					short num3 = num;
					num = (short)1915997530;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_56;
					default:
						goto IL_D3;
					}
					break;
				}
				case 3:
					goto IL_14D;
				}
				IL_35:
				if (this.c == null)
				{
					num = (short)318898176;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_56:
				num = (short)1699217408;
				short num4 = num;
				this.c.Stop();
				num = (short)1790640130;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_D3:
			num = (short)872087553;
			if (num != 0)
			{
			}
			num = (short)215351296;
			if (num != 0)
			{
			}
			IL_14D:
			this.c.Interval = global::System.TimeSpan.FromMilliseconds(100.0);
			this.c.Start();
		}

		// Token: 0x06000247 RID: 583 RVA: 0x0001667C File Offset: 0x0001487C
		private void a(object A_0, global::System.EventArgs A_1)
		{
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						if (this.c == null)
						{
							return;
						}
						num2 = (short)1168510358;
						short num3 = num2;
						num2 = (short)770051478;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num2 = (short)826540032;
							short num4 = num2;
							num2 = (short)636616704;
							if (num2 != 0)
							{
							}
							num2 = (short)1398341633;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 1:
						num2 = (short)506396673;
						if (num2 != 0)
						{
						}
						this.c.Stop();
						num2 = (short)1431240706;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						return;
					}
					break;
				}
				IL_1C:
				this.MessageListChanged = true;
				num2 = (short)2109210624;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x040000B7 RID: 183
		private global::System.Collections.Generic.List<global::AcpCommonLib.StatusMessage.StatusMessageInfo> a = new global::System.Collections.Generic.List<global::AcpCommonLib.StatusMessage.StatusMessageInfo>();

		// Token: 0x040000B8 RID: 184
		private bool b;

		// Token: 0x040000B9 RID: 185
		private global::System.Windows.Threading.DispatcherTimer c;

		// Token: 0x040000BA RID: 186
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::AcpCommonLib.StatusMessage.NotifyMsgListChangedEventHandler d;

		// Token: 0x02000039 RID: 57
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x0600024A RID: 586 RVA: 0x000167D8 File Offset: 0x000149D8
			internal bool b(global::AcpCommonLib.StatusMessage.StatusMessageInfo A_0)
			{
				short num = (short)1352335360;
				short num2 = num;
				num = (short)11399557;
				short num3 = num;
				num = (short)652603781;
				switch (num3 == num)
				{
				}
				num = (short)1405353985;
				if (num != 0)
				{
				}
				num = (short)2133983232;
				if (num != 0)
				{
				}
				return A_0.Message == this.a;
			}

			// Token: 0x040000BB RID: 187
			public string a;
		}

		// Token: 0x0200003B RID: 59
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class c
		{
			// Token: 0x06000254 RID: 596 RVA: 0x0001708C File Offset: 0x0001528C
			internal bool b(global::AcpCommonLib.StatusMessage.StatusMessageInfo A_0)
			{
				short num = (short)1015545856;
				short num2 = num;
				num = (short)965869569;
				if (num != 0)
				{
				}
				num = (short)183740821;
				short num3 = num;
				num = (short)1080338837;
				switch (num3 == num)
				{
				}
				num = (short)1928593408;
				if (num != 0)
				{
				}
				return A_0.Message == this.a;
			}

			// Token: 0x040000C1 RID: 193
			public string a;
		}
	}
}
