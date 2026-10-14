using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace AcpCommonLib.FindResult
{
	// Token: 0x0200003F RID: 63
	public class FindResultsManager
	{
		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600025D RID: 605 RVA: 0x000172D0 File Offset: 0x000154D0
		// (remove) Token: 0x0600025E RID: 606 RVA: 0x00017408 File Offset: 0x00015608
		public static event global::AcpCommonLib.FindResult.NotifyFindResultChangedEventHandler NotifyFindResultChangedEvent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
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
					global::AcpCommonLib.FindResult.NotifyFindResultChangedEventHandler notifyFindResultChangedEventHandler;
					short num2;
					for (;;)
					{
						IL_0A:
						switch (num)
						{
						case 0:
							goto IL_38;
						case 1:
						{
							global::AcpCommonLib.FindResult.NotifyFindResultChangedEventHandler notifyFindResultChangedEventHandler2;
							if (notifyFindResultChangedEventHandler == notifyFindResultChangedEventHandler2)
							{
								num2 = (short)1342570498;
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
						num2 = (short)1491052486;
						short num3 = num2;
						num2 = (short)726837190;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num2 = (short)356450304;
							short num4 = num2;
							num2 = (short)1561526272;
							if (num2 != 0)
							{
							}
							global::AcpCommonLib.FindResult.NotifyFindResultChangedEventHandler notifyFindResultChangedEventHandler2 = notifyFindResultChangedEventHandler;
							global::AcpCommonLib.FindResult.NotifyFindResultChangedEventHandler value2 = (global::AcpCommonLib.FindResult.NotifyFindResultChangedEventHandler)global::System.Delegate.Combine(notifyFindResultChangedEventHandler2, value);
							notifyFindResultChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpCommonLib.FindResult.NotifyFindResultChangedEventHandler>(ref global::AcpCommonLib.FindResult.FindResultsManager.c, value2, notifyFindResultChangedEventHandler2);
							num2 = (short)28966913;
							if (num2 != 0)
							{
							}
							num2 = (short)1713242113;
							num = (int)((global::System.IntPtr)num2);
							break;
						}
						}
					}
					IL_1C:
					notifyFindResultChangedEventHandler = global::AcpCommonLib.FindResult.FindResultsManager.c;
					num2 = (short)1193345024;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
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
					global::AcpCommonLib.FindResult.NotifyFindResultChangedEventHandler notifyFindResultChangedEventHandler;
					for (;;)
					{
						IL_0A:
						switch (num)
						{
						case 0:
							goto IL_38;
						case 1:
						{
							global::AcpCommonLib.FindResult.NotifyFindResultChangedEventHandler notifyFindResultChangedEventHandler2;
							if (notifyFindResultChangedEventHandler == notifyFindResultChangedEventHandler2)
							{
								num2 = (short)323223554;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_38;
						}
						case 2:
							goto IL_FD;
						}
						break;
						IL_38:
						num2 = (short)1038950684;
						short num3 = num2;
						num2 = (short)1320886556;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num2 = (short)1383071744;
							short num4 = num2;
							num2 = (short)1893728256;
							if (num2 != 0)
							{
							}
							global::AcpCommonLib.FindResult.NotifyFindResultChangedEventHandler notifyFindResultChangedEventHandler2 = notifyFindResultChangedEventHandler;
							global::AcpCommonLib.FindResult.NotifyFindResultChangedEventHandler value2 = (global::AcpCommonLib.FindResult.NotifyFindResultChangedEventHandler)global::System.Delegate.Remove(notifyFindResultChangedEventHandler2, value);
							notifyFindResultChangedEventHandler = global::System.Threading.Interlocked.CompareExchange<global::AcpCommonLib.FindResult.NotifyFindResultChangedEventHandler>(ref global::AcpCommonLib.FindResult.FindResultsManager.c, value2, notifyFindResultChangedEventHandler2);
							num2 = (short)327942145;
							num = (int)((global::System.IntPtr)num2);
							break;
						}
						}
					}
					IL_1C:
					notifyFindResultChangedEventHandler = global::AcpCommonLib.FindResult.FindResultsManager.c;
					num2 = (short)1369636864;
					num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				IL_FD:
				num2 = (short)1214906369;
				if (num2 != 0)
				{
				}
			}
		}

		// Token: 0x0600025F RID: 607 RVA: 0x0001753C File Offset: 0x0001573C
		public void Clear()
		{
			short num = (short)1183383552;
			short num2 = num;
			num = (short)851586295;
			short num3 = num;
			num = (short)1682910455;
			switch (num3 == num)
			{
			}
			num = (short)2061565953;
			if (num != 0)
			{
			}
			num = (short)2058485760;
			if (num != 0)
			{
			}
			this.a.Clear();
			this.ResultChanged = true;
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000260 RID: 608 RVA: 0x000175F8 File Offset: 0x000157F8
		public bool HasResults
		{
			get
			{
				short num = (short)1015939072;
				short num2 = num;
				num = (short)2042849553;
				short num3 = num;
				num = (short)798976273;
				switch (num3 == num)
				{
				}
				num = (short)1938882561;
				if (num != 0)
				{
				}
				num = (short)1065943040;
				if (num != 0)
				{
				}
				return this.a.Count > 0;
			}
		}

		// Token: 0x06000261 RID: 609 RVA: 0x000176AC File Offset: 0x000158AC
		internal bool a(string A_0)
		{
			short num;
			for (;;)
			{
				num = (short)54591488;
				short num2 = num;
				if (A_0 == null)
				{
					goto IL_A3;
				}
				num = (short)397423720;
				short num3 = num;
				num = (short)1579955304;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_74;
				}
			}
			IL_74:
			num = (short)726073344;
			if (num != 0)
			{
			}
			return this.a.Exists(new global::System.Predicate<global::AcpCommonLib.FindResult.FindResultInfo>(a.b));
			IL_A3:
			num = (short)767033345;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000262 RID: 610 RVA: 0x00017784 File Offset: 0x00015984
		public global::System.Collections.Generic.IEnumerable<global::AcpCommonLib.FindResult.FindResultInfo> Results
		{
			get
			{
				short num = (short)1913389056;
				short num2 = num;
				num = (short)712160055;
				short num3 = num;
				num = (short)89699127;
				switch (num3 == num)
				{
				}
				num = (short)766574593;
				if (num != 0)
				{
				}
				num = (short)789250048;
				if (num != 0)
				{
				}
				global::AcpCommonLib.FindResult.FindResultsManager.b b = new global::AcpCommonLib.FindResult.FindResultsManager.b(-2);
				b.d = this;
				return b;
			}
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00017840 File Offset: 0x00015A40
		public void RegisterResult(global::AcpCommonLib.IAcpField field)
		{
			short num = (short)564920321;
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
						goto IL_34;
					}
					continue;
				case 2:
				{
					num = (short)1959284940;
					short num3 = num;
					num = (short)1755533516;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_55;
					default:
						num = (short)1698299904;
						if (num != 0)
						{
						}
						if (field.IgnoreOnPrint)
						{
							num = (short)156565507;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12F;
					}
					break;
				}
				case 3:
					goto IL_129;
				}
				IL_34:
				if (field.IsMasked)
				{
					num = (short)1829306368;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1882324994;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return;
			IL_55:
			num = (short)743178240;
			short num4 = num;
			num = (short)391905281;
			if (num != 0)
			{
			}
			return;
			IL_129:
			goto IL_55;
			IL_12F:
			this.a.Add(new global::AcpCommonLib.FindResult.FindResultInfo(field));
			this.ResultChanged = true;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00017994 File Offset: 0x00015B94
		internal void b(string A_0)
		{
			short num = (short)510459904;
			short num2 = num;
			num = (short)582156289;
			if (num != 0)
			{
			}
			num = (short)1920990963;
			short num3 = num;
			num = (short)434831091;
			switch (num3 == num)
			{
			}
			num = (short)56885248;
			if (num != 0)
			{
			}
			global::AcpCommonLib.FindResult.FindResultsManager.c c = new global::AcpCommonLib.FindResult.FindResultsManager.c();
			c.a = A_0;
			int index = this.a.FindIndex(new global::System.Predicate<global::AcpCommonLib.FindResult.FindResultInfo>(c.b));
			this.a.RemoveAt(index);
			this.ResultChanged = true;
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000265 RID: 613 RVA: 0x00017A78 File Offset: 0x00015C78
		// (set) Token: 0x06000266 RID: 614 RVA: 0x00017B28 File Offset: 0x00015D28
		public bool ResultChanged
		{
			get
			{
				short num = (short)1743126529;
				if (num != 0)
				{
				}
				num = (short)839188480;
				short num2 = num;
				num = (short)1081455970;
				short num3 = num;
				num = (short)2056566114;
				switch (num3 == num)
				{
				}
				num = (short)408027136;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
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
						goto IL_F4;
					case 1:
						goto IL_38;
					case 2:
					{
						num2 = (short)921719854;
						short num3 = num2;
						num2 = (short)1437488174;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_38;
						default:
						{
							num2 = (short)1049624576;
							if (num2 != 0)
							{
							}
							num2 = (short)38666240;
							short num4 = num2;
							global::AcpCommonLib.FindResult.FindResultsManager.c(null, new global::AcpCommonLib.FindResult.NotifyFindResultChangedEventArgs());
							num2 = (short)1707147264;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					}
					goto IL_1C;
					IL_38:
					if (global::AcpCommonLib.FindResult.FindResultsManager.c == null)
					{
						break;
					}
					num2 = (short)302120962;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_F4:
				num2 = (short)178520065;
				if (num2 != 0)
				{
				}
				return;
				IL_1C:
				this.b = value;
				num2 = (short)1734410241;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x040000C3 RID: 195
		private global::System.Collections.Generic.List<global::AcpCommonLib.FindResult.FindResultInfo> a = new global::System.Collections.Generic.List<global::AcpCommonLib.FindResult.FindResultInfo>();

		// Token: 0x040000C4 RID: 196
		private bool b;

		// Token: 0x040000C5 RID: 197
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private static global::AcpCommonLib.FindResult.NotifyFindResultChangedEventHandler c;

		// Token: 0x02000040 RID: 64
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06000269 RID: 617 RVA: 0x00017C88 File Offset: 0x00015E88
			internal bool b(global::AcpCommonLib.FindResult.FindResultInfo A_0)
			{
				short num = (short)693764097;
				if (num != 0)
				{
				}
				num = (short)1103953920;
				short num2 = num;
				num = (short)1185526845;
				short num3 = num;
				num = (short)274248765;
				switch (num3 == num)
				{
				}
				num = (short)338558976;
				if (num != 0)
				{
				}
				return A_0.Name == this.a;
			}

			// Token: 0x040000C6 RID: 198
			public string a;
		}

		// Token: 0x02000042 RID: 66
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class c
		{
			// Token: 0x06000274 RID: 628 RVA: 0x000186EC File Offset: 0x000168EC
			internal bool b(global::AcpCommonLib.FindResult.FindResultInfo A_0)
			{
				short num = (short)2138815006;
				short num2 = num;
				num = (short)848149022;
				switch (num2 == num)
				{
				default:
				{
					num = (short)776142848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2049966081;
				if (num != 0)
				{
				}
				num = (short)30343168;
				if (num != 0)
				{
				}
				return A_0.Name == this.a;
			}

			// Token: 0x040000CD RID: 205
			public string a;
		}
	}
}
