using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x0200000E RID: 14
	internal class h
	{
		// Token: 0x06000094 RID: 148 RVA: 0x0000ACEC File Offset: 0x00008EEC
		public h(global::Motorola.Common.Communication.RUDP.b A_0, global::Motorola.Common.Communication.RUDP.RUDPConfigParams A_1, global::Motorola.Common.Communication.RUDP.v A_2)
		{
			this.a = A_0;
			this.b = A_1;
			this.d = A_2;
			this.c = new global::Motorola.Common.Communication.RUDP.w(this.b, this, this.d);
			this.e = A_1.SynNegociateParameters.maximal_number_of_outstanding_unacknowledged_fragment;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000ADA0 File Offset: 0x00008FA0
		public void i()
		{
			short num = (short)674496330;
			short num2 = num;
			num = (short)1542455114;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1788739584;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1304559617;
			if (num != 0)
			{
			}
			num = (short)1053294592;
			if (num != 0)
			{
			}
			this.c.g();
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000AE58 File Offset: 0x00009058
		public void j()
		{
			short num = (short)313003130;
			short num2 = num;
			num = (short)1543375994;
			switch (num2 == num)
			{
			}
			num = (short)1548288001;
			if (num != 0)
			{
			}
			num = (short)944373760;
			short num3 = num;
			num = (short)314245120;
			if (num != 0)
			{
			}
			this.c.f();
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000AF0C File Offset: 0x0000910C
		public void a(global::Motorola.Common.Communication.RUDP.RUDPConfigParams A_0)
		{
			short num = (short)2013462529;
			if (num != 0)
			{
			}
			num = (short)1915075268;
			short num2 = num;
			num = (short)1198504644;
			switch (num2 == num)
			{
			}
			num = (short)1451098112;
			short num3 = num;
			num = (short)621543424;
			if (num != 0)
			{
			}
			this.b = A_0;
			this.c.a(A_0);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000AFC8 File Offset: 0x000091C8
		private int h()
		{
			short num = (short)72270772;
			short num2 = num;
			num = (short)1244316596;
			switch (num2 == num)
			{
			}
			num = (short)1356201985;
			if (num != 0)
			{
			}
			num = (short)358744064;
			short num3 = num;
			num = (short)2135490560;
			if (num != 0)
			{
			}
			return this.i.Count;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000B080 File Offset: 0x00009280
		private int g()
		{
			short num = (short)111375560;
			short num2 = num;
			num = (short)532509896;
			switch (num2 == num)
			{
			}
			num = (short)1966538753;
			if (num != 0)
			{
			}
			num = (short)508887040;
			short num3 = num;
			num = (short)2123235328;
			if (num != 0)
			{
			}
			return this.k.Count;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000B134 File Offset: 0x00009334
		private int f()
		{
			short num = (short)579534849;
			if (num != 0)
			{
			}
			num = (short)1845666139;
			short num2 = num;
			num = (short)1522049371;
			switch (num2 == num)
			{
			}
			num = (short)2100428800;
			short num3 = num;
			num = (short)415039488;
			if (num != 0)
			{
			}
			return this.g.Count;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000B1EC File Offset: 0x000093EC
		public global::Motorola.Common.Communication.RUDP.b k()
		{
			short num = (short)64946177;
			if (num != 0)
			{
			}
			num = (short)688462828;
			short num2 = num;
			num = (short)1781079020;
			switch (num2 == num)
			{
			}
			num = (short)1211432960;
			short num3 = num;
			num = (short)1640431616;
			if (num != 0)
			{
			}
			return this.a;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000B29C File Offset: 0x0000949C
		private void a(global::Motorola.Common.Communication.RUDP.b A_0)
		{
			short num = (short)340107964;
			short num2 = num;
			num = (short)1066377916;
			switch (num2 == num)
			{
			}
			num = (short)2752513;
			if (num != 0)
			{
			}
			num = (short)826212352;
			short num3 = num;
			num = (short)254803968;
			if (num != 0)
			{
			}
			this.a = A_0;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000B34C File Offset: 0x0000954C
		public void o(global::Motorola.Common.Communication.RUDP.i A_0)
		{
			int a_ = 18;
			short num;
			for (;;)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("搵崷夹夻圽㘿❁⁃晅Ň⑉⽋⅍㵏㭑㩓ㅕ硗ṙᵛ੝⅟䉡㑣ݥ୧ũ५ᩭ幯山婳", a_), global::System.Array.Empty<object>());
				this.j.EnterWriteLock();
				this.l.EnterWriteLock();
				try
				{
					this.k.Add(A_0);
					this.m.Add(A_0);
				}
				finally
				{
					this.j.ExitWriteLock();
					this.l.ExitWriteLock();
				}
				num = (short)1836190939;
				short num2 = num;
				num = (short)1637682395;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_A5;
				}
			}
			IL_A5:
			num = (short)519634945;
			if (num != 0)
			{
			}
			num = (short)1978400768;
			short num3 = num;
			num = (short)1319436288;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000B478 File Offset: 0x00009678
		private void n(global::Motorola.Common.Communication.RUDP.i A_0)
		{
			short num;
			for (;;)
			{
				this.j.EnterWriteLock();
				try
				{
					this.k.Remove(A_0);
				}
				finally
				{
					this.j.ExitWriteLock();
				}
				num = (short)791788437;
				short num2 = num;
				num = (short)941931413;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_5C;
				}
			}
			IL_5C:
			num = (short)1201864705;
			if (num != 0)
			{
			}
			num = (short)1444937728;
			short num3 = num;
			num = (short)2022113280;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000B55C File Offset: 0x0000975C
		private void a(int count)
		{
			short num = (short)1435566080;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 1:
					try
					{
						this.k.RemoveRange(0, count);
						return;
					}
					finally
					{
						this.j.ExitWriteLock();
					}
					goto IL_102;
				case 2:
					goto IL_4B;
				}
				IL_30:
				if (count <= 0)
				{
					num = (short)1292697602;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_102:
				this.j.EnterWriteLock();
				num = (short)433913857;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_4B:
			num = (short)566869455;
			short num3 = num;
			num = (short)1833680335;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			default:
			{
				num = (short)847052801;
				if (num != 0)
				{
				}
				num = (short)188874752;
				if (num != 0)
				{
				}
				num = (short)270991360;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000B6A4 File Offset: 0x000098A4
		private global::Motorola.Common.Communication.RUDP.i e()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::Motorola.Common.Communication.RUDP.i result;
			for (;;)
			{
				IL_0A:
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.i>.Enumerator enumerator;
				switch (num)
				{
				case 0:
					if (this.m.Count <= 0)
					{
						num2 = (short)759758850;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_209;
				case 1:
					try
					{
						num2 = (short)887357444;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num2 = (short)467140613;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								global::Motorola.Common.Communication.RUDP.i i = enumerator.Current;
								num2 = (short)954561724;
								short num3 = num2;
								num2 = (short)246903996;
								switch ((num3 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									continue;
								default:
									num2 = (short)718143488;
									if (num2 != 0)
									{
									}
									num2 = (short)1375666178;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 1:
								goto IL_1B7;
							case 2:
							{
								global::Motorola.Common.Communication.RUDP.i i;
								if (!i.h)
								{
									num2 = (short)1120600070;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							case 3:
								goto IL_1D1;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_CA;
								}
								continue;
							case 5:
								num2 = (short)588054531;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 6:
							{
								global::Motorola.Common.Communication.RUDP.i i;
								i.h = true;
								result = i;
								num2 = (short)2049703937;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							}
							IL_15A:
							num2 = (short)76742656;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_CA:
							goto IL_15A;
						}
						IL_1B7:
						IL_1D1:
						return result;
					}
					finally
					{
						num2 = (short)1645477889;
						if (num2 != 0)
						{
						}
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_209;
				case 2:
					goto IL_83;
				}
				goto IL_1C;
				IL_209:
				enumerator = this.m.GetEnumerator();
				num2 = (short)1761411073;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_83:
			return null;
			IL_1C:
			result = null;
			num2 = (short)983957504;
			short num4 = num2;
			num2 = (short)939327488;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000B904 File Offset: 0x00009B04
		private void m(global::Motorola.Common.Communication.RUDP.i A_0)
		{
			short num;
			for (;;)
			{
				this.f.EnterWriteLock();
				try
				{
					this.g.Add(A_0);
				}
				finally
				{
					this.f.ExitWriteLock();
				}
				num = (short)1690959873;
				if (num != 0)
				{
				}
				num = (short)1441708322;
				short num2 = num;
				num = (short)743160098;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_86;
				}
			}
			IL_86:
			num = (short)1115357184;
			short num3 = num;
			num = (short)117964800;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		private void a(global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.i> A_0)
		{
			short num;
			for (;;)
			{
				this.f.EnterWriteLock();
				try
				{
					this.g.AddRange(A_0);
				}
				finally
				{
					this.f.ExitWriteLock();
				}
				num = (short)1090966348;
				short num2 = num;
				num = (short)81580876;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_5D;
				}
			}
			IL_5D:
			num = (short)1756495873;
			if (num != 0)
			{
			}
			num = (short)230031360;
			short num3 = num;
			num = (short)1903165440;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000BAC8 File Offset: 0x00009CC8
		private void l(global::Motorola.Common.Communication.RUDP.i A_0)
		{
			short num;
			for (;;)
			{
				num = (short)94633985;
				if (num != 0)
				{
				}
				this.f.EnterWriteLock();
				try
				{
					this.g.Remove(A_0);
				}
				finally
				{
					this.f.ExitWriteLock();
				}
				num = (short)795329765;
				short num2 = num;
				num = (short)1395573989;
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
			num = (short)385220608;
			short num3 = num;
			num = (short)757399552;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000BBA8 File Offset: 0x00009DA8
		private void k(global::Motorola.Common.Communication.RUDP.i A_0)
		{
			int a_ = 18;
			short num = (short)837668242;
			short num2 = num;
			num = (short)1770311058;
			switch (num2 == num)
			{
			}
			num = (short)1288437761;
			if (num != 0)
			{
			}
			num = (short)2134835200;
			short num3 = num;
			num = (short)1908015104;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteInfo(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("搵洷縹氻н怿́⁃≅桇㽉≋⽍㍏㥑ㅓ㉕硗㕙⥛⩝ݟൡൣࡥཧ䩩ᱫ཭፯ᥱᅳɵ䕷䙹ݻ乽멿\uda81旅뢅ꚇꒉ", a_), new object[]
			{
				A_0.i.az()
			});
			this.i.Add(A_0);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000BC94 File Offset: 0x00009E94
		private void j(global::Motorola.Common.Communication.RUDP.i A_0)
		{
			short num;
			for (;;)
			{
				this.h.EnterWriteLock();
				try
				{
					this.i.Remove(A_0);
					this.a.n(A_0.i.az());
				}
				finally
				{
					this.h.ExitWriteLock();
				}
				num = (short)363810441;
				short num2 = num;
				num = (short)1467829897;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_73;
				}
			}
			IL_73:
			num = (short)218824705;
			if (num != 0)
			{
			}
			num = (short)1781006336;
			short num3 = num;
			num = (short)1267073024;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000BD88 File Offset: 0x00009F88
		private void i(global::Motorola.Common.Communication.RUDP.i A_0)
		{
			short num;
			for (;;)
			{
				this.l.EnterWriteLock();
				try
				{
					this.m.Add(A_0);
				}
				finally
				{
					this.l.ExitWriteLock();
				}
				num = (short)649199617;
				if (num != 0)
				{
				}
				num = (short)523312516;
				short num2 = num;
				num = (short)806559108;
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
			num = (short)835125248;
			short num3 = num;
			num = (short)672530432;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000BE68 File Offset: 0x0000A068
		private void h(global::Motorola.Common.Communication.RUDP.i A_0)
		{
			short num;
			for (;;)
			{
				num = (short)1836843009;
				if (num != 0)
				{
				}
				this.l.EnterWriteLock();
				try
				{
					this.m.Remove(A_0);
				}
				finally
				{
					this.l.ExitWriteLock();
				}
				num = (short)1770821844;
				short num2 = num;
				num = (short)690854100;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_85;
				}
			}
			IL_85:
			num = (short)193527808;
			short num3 = num;
			num = (short)627507200;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000BF4C File Offset: 0x0000A14C
		private void g(global::Motorola.Common.Communication.RUDP.i A_0)
		{
			int a_ = 4;
			short num = (short)132710401;
			if (num != 0)
			{
			}
			num = (short)1552346343;
			short num2 = num;
			num = (short)1395846375;
			switch (num2 == num)
			{
			}
			num = (short)1514864640;
			short num3 = num;
			num = (short)1677852672;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteInfo(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("稧缩栫縭ਯሱ夳夵丷弹᰻丽ℿ⅁⽃⍅㱇睉灋㕍恏桑౓⭕晗穙㩛ⱝཟཡ䑣॥ᵧṩ୫ŭ᥯ᱱ፳噵౷ᕹ屻୽겋憐뢕", a_), new object[]
			{
				A_0.i.az()
			});
			this.l(A_0);
			this.k(A_0);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000C03C File Offset: 0x0000A23C
		private void f(global::Motorola.Common.Communication.RUDP.i A_0)
		{
			short num = (short)586609325;
			short num2 = num;
			num = (short)567866029;
			switch (num2 == num)
			{
			}
			num = (short)1433665536;
			if (num != 0)
			{
			}
			num = (short)1825898496;
			short num3 = num;
			num = (short)1713242113;
			if (num != 0)
			{
			}
			this.n(A_0);
			this.i(A_0);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000C0F0 File Offset: 0x0000A2F0
		public void l()
		{
			short num;
			for (;;)
			{
				this.f.EnterWriteLock();
				this.j.EnterWriteLock();
				this.l.EnterWriteLock();
				this.h.EnterWriteLock();
				try
				{
					this.g.Clear();
					this.k.Clear();
					this.m.Clear();
					this.i.Clear();
				}
				finally
				{
					this.f.ExitWriteLock();
					this.j.ExitWriteLock();
					this.l.ExitWriteLock();
					this.h.ExitWriteLock();
				}
				num = (short)879206574;
				short num2 = num;
				num = (short)2137104558;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_BF;
				}
			}
			IL_BF:
			num = (short)1275658241;
			if (num != 0)
			{
			}
			num = (short)2041511936;
			short num3 = num;
			num = (short)348323840;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000C234 File Offset: 0x0000A434
		private void c()
		{
			short num = (short)298123265;
			if (num != 0)
			{
			}
			num = (short)1089275837;
			short num2 = num;
			num = (short)508233661;
			switch (num2 == num)
			{
			}
			num = (short)1812922368;
			short num3 = num;
			num = (short)1396375552;
			if (num != 0)
			{
			}
			this.j.EnterWriteLock();
			this.k.Sort(new global::System.Comparison<global::Motorola.Common.Communication.RUDP.i>(global::Motorola.Common.Communication.RUDP.h.<>c.<>9.a));
			this.j.ExitWriteLock();
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000C320 File Offset: 0x0000A520
		public int b(global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.i> A_0)
		{
			int a_ = 2;
			short num = (short)250216448;
			switch (num)
			{
			default:
			{
				num = (short)120651777;
				if (num != 0)
				{
				}
				num = (short)1831075848;
				int num2 = (int)((global::System.IntPtr)num);
				int num5;
				for (;;)
				{
					int count;
					int num4;
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.i>.Enumerator enumerator;
					int num6;
					switch (num2)
					{
					case 0:
					{
						IL_163:
						num = (short)555089920;
						short num3 = num;
						if (count < num4)
						{
							num = (short)1346437123;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2055143434;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						try
						{
							num = (short)1941831682;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									try
									{
										switch (0)
										{
										case 0:
											goto IL_26A;
										}
										global::Motorola.Common.Communication.RUDP.i i;
										for (;;)
										{
											IL_253:
											switch (num2)
											{
											case 0:
												goto IL_2FC;
											case 1:
												if (i.b != global::Motorola.Common.Communication.RUDP.f.e)
												{
													num = (short)1592983555;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_2E3;
											case 2:
												goto IL_2E3;
											case 3:
												this.g(i);
												num = (short)1390804994;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_26A;
											IL_2E3:
											num = (short)290324480;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_2FC:
										break;
										IL_26A:
										this.e(i);
										this.a.t(i);
										global::Motorola.Common.Communication.RUDP.h.c(i);
										num = (short)1165950977;
										num2 = (int)((global::System.IntPtr)num);
										goto IL_253;
									}
									catch (global::System.Exception ex)
									{
										global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("甥䴧䐩䠫อ甯䨱圳匵䠷丹唻儽⸿硁摃", a_) + ex.Message, global::System.Array.Empty<object>());
										throw;
									}
									finally
									{
										this.h.ExitWriteLock();
										this.l.ExitReadLock();
									}
									break;
								case 1:
									goto IL_3D5;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_244;
									}
									continue;
								case 3:
									num = (short)694681601;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)773718019;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.RUDP.i i = enumerator.Current;
									this.l.EnterReadLock();
									this.h.EnterWriteLock();
									num = (short)1535311872;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_342:
								num = (short)1992884228;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_244:
								goto IL_342;
							}
							IL_3D5:
							return num5;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_3E8;
					case 2:
						this.a(A_0);
						num = (short)1936588807;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)732889097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (num5 > 0)
						{
							num = (short)1892548614;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.f.ExitReadLock();
						num = (short)354746373;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						return num5;
					case 6:
						goto IL_3E8;
					case 7:
						goto IL_124;
					case 8:
						switch (0)
						{
						case 0:
							goto IL_9F;
						}
						continue;
					case 9:
						num6 = count;
						goto IL_1CB;
					case 10:
						num6 = num4;
						goto IL_1CB;
					}
					IL_9F:
					if (A_0 != null)
					{
						num = (short)339738626;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_124;
					IL_3E8:
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.i> list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.i>(this.g.GetRange(0, num5));
					this.f.ExitReadLock();
					enumerator = list.GetEnumerator();
					num = (short)614227068;
					short num7 = num;
					num = (short)1766677628;
					switch ((num7 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_163;
					default:
						num = (short)92536832;
						if (num != 0)
						{
						}
						num = (short)1232601089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_124:
					num4 = this.e - this.h();
					this.f.EnterReadLock();
					count = this.g.Count;
					num = (short)7798784;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CB:
					num5 = num6;
					num = (short)1460862980;
					num2 = (int)((global::System.IntPtr)num);
				}
				return num5;
			}
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000C7EC File Offset: 0x0000A9EC
		public int p(global::Motorola.Common.Communication.RUDP.i A_0)
		{
			int a_ = 19;
			switch (0)
			{
			case 0:
				goto IL_82;
			}
			short num;
			int num2;
			global::Motorola.Common.Communication.RUDP.i i;
			global::Motorola.Common.Communication.RUDP.e e;
			for (;;)
			{
				IL_13:
				num = (short)1623719937;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_2BA;
				case 1:
					if (A_0.b != global::Motorola.Common.Communication.RUDP.f.d)
					{
						num = (short)2125201413;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_38C;
				case 2:
					if (A_0.b != global::Motorola.Common.Communication.RUDP.f.d)
					{
						num = (short)1501233156;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_38C;
				case 3:
				{
					long num3 = global::Motorola.Common.Communication.RUDP.t.d() - i.o;
					num = (short)1307312135;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("收尸堺堼嘾㝀♂⅄杆وṊ᥌၎ِᩒ᭔ፖᙘౚ絜ཞ`b๤ɦᵨ䕪䍬䅮", a_), global::System.Array.Empty<object>());
					num = (short)2022965263;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("收尸堺堼嘾㝀♂⅄杆وṊ᥌၎ِᩒ᭔ፖᙘౚɜ൞①㍢⁤♦㵨䭪㵬๮ተᡲၴͶ坸啺卼", a_), global::System.Array.Empty<object>());
					num = (short)87162880;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)1685323778;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
				{
					long num3;
					if (this.a.ao().n < num3)
					{
						num = (short)113967104;
						short num4 = num;
						num = (short)236781579;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2F9;
				}
				case 8:
					if (e == global::Motorola.Common.Communication.RUDP.e.a)
					{
						num = (short)771620867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1690304522;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (e == global::Motorola.Common.Communication.RUDP.e.c)
					{
						num = (short)2059599885;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_38C;
				case 10:
					if (e == global::Motorola.Common.Communication.RUDP.e.b)
					{
						num = (short)1299120134;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)231604233;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
				{
					long num3;
					this.a.ao().n = num3;
					num = (short)1538523150;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 12:
					goto IL_38A;
				case 13:
					goto IL_185;
				case 14:
					goto IL_2F9;
				case 15:
					goto IL_280;
				}
				goto IL_82;
				IL_185:
				num = (short)1608581121;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2F9:
				num = (short)1595984369;
				short num5 = num;
				num = (short)247777777;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_185;
				default:
				{
					num = (short)1748697088;
					if (num != 0)
					{
					}
					long num3;
					this.a.ao().o += num3;
					i.aw();
					this.j(i);
					this.b(null);
					num = (short)716963852;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			IL_280:
			IL_2BA:
			IL_38A:
			IL_38C:
			this.a.u(A_0);
			return 1;
			IL_82:
			A_0.f;
			int maximal_fragment_size = this.b.SynNegociateParameters.maximal_fragment_size;
			i = null;
			e = this.a(A_0, out i);
			num = (short)2101149704;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000CB94 File Offset: 0x0000AD94
		private global::Motorola.Common.Communication.RUDP.e a(global::Motorola.Common.Communication.RUDP.i A_0, out global::Motorola.Common.Communication.RUDP.i A_1)
		{
			short num = (short)1980039168;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5B;
				}
				global::Motorola.Common.Communication.RUDP.e e;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						e = global::Motorola.Common.Communication.RUDP.e.c;
						num = (short)1085997061;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)252051457;
						if (num != 0)
						{
						}
						num = (short)1913716744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (e != global::Motorola.Common.Communication.RUDP.e.a)
						{
							num = (short)425721863;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return e;
					case 3:
						if (A_0.n)
						{
							num = (short)696975364;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return e;
					case 4:
					{
						int num3 = (int)A_0.i.a0();
						this.h.EnterReadLock();
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.i>.Enumerator enumerator = this.i.GetEnumerator();
						num = (short)1955594250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_2D9;
					case 6:
						return e;
					case 7:
						num = (short)988282889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						int num3;
						if (num3 > (int)this.a.ad())
						{
							goto IL_2D9;
						}
						num = (short)2128896577;
						short num4 = num;
						num = (short)638804545;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return e;
						default:
							num = (short)1054539776;
							if (num != 0)
							{
							}
							num = (short)201064448;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 9:
					{
						num = (short)35192832;
						short num5 = num;
						int num3;
						if (num3 >= (int)this.a.ac())
						{
							num = (short)1212350465;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D9;
					}
					case 10:
						try
						{
							num = (short)1499463681;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2C6;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_205;
									}
									continue;
								case 3:
								{
									global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.i>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1482031110;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.RUDP.i i = enumerator.Current;
									num = (short)120389636;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									int num3;
									global::Motorola.Common.Communication.RUDP.i i;
									if (num3 == (int)i.i.az())
									{
										num = (short)5767173;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									e = global::Motorola.Common.Communication.RUDP.e.a;
									global::Motorola.Common.Communication.RUDP.i i;
									A_1 = i;
									i.h = true;
									num = (short)1946419202;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)1363607552;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_24B:
								num = (short)1598291971;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_205:
								goto IL_24B;
							}
							IL_2C6:
							goto IL_36F;
						}
						finally
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.i>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_2D9;
						IL_36F:
						this.h.ExitReadLock();
						num = (short)495714306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5B;
					IL_2D9:
					this.a.ao().p++;
					num = (short)1371668486;
					num2 = (int)((global::System.IntPtr)num);
				}
				return e;
				IL_5B:
				A_1 = null;
				e = global::Motorola.Common.Communication.RUDP.e.b;
				num = (short)757334019;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000CF74 File Offset: 0x0000B174
		public global::Motorola.Common.Communication.RUDP.q m()
		{
			short num = (short)792657920;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3E;
				}
				global::Motorola.Common.Communication.RUDP.q result;
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.i> list;
				int num4;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						return result;
					case 1:
						try
						{
							int num3 = (int)global::Motorola.Common.Communication.RUDP.c.a;
							using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.i>.Enumerator enumerator = this.k.GetEnumerator())
							{
								num = (short)164036614;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::Motorola.Common.Communication.RUDP.i i;
										num3 = (int)i.i.az();
										num = (short)2090663943;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										num = (short)802488332;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_39B;
									case 3:
										if (num3 == (int)global::Motorola.Common.Communication.RUDP.c.a)
										{
											num = (short)2059993088;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)728170504;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										num = (short)82378754;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
										goto IL_21E;
									case 6:
										switch (0)
										{
										case 0:
											goto IL_1BD;
										}
										continue;
									case 7:
										goto IL_2FC;
									case 8:
									{
										global::Motorola.Common.Communication.RUDP.i i;
										if ((int)i.i.az() != num3 + 1)
										{
											num = (short)1971716097;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_2FC;
									}
									case 10:
										list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.i>();
										list.AddRange(this.k.Take(num4));
										result = new global::Motorola.Common.Communication.RUDP.q(list, null);
										num = (short)915931141;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 11:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1529675780;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Common.Communication.RUDP.i i = enumerator.Current;
										num4++;
										num = (short)892010499;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 12:
										goto IL_27D;
									case 13:
									{
										global::Motorola.Common.Communication.RUDP.i i;
										if (i.g)
										{
											num = (short)247136266;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num3 = (int)i.i.az();
										num = (short)1990787081;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_223:
									num = (short)241041419;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_1BD:
									goto IL_223;
									IL_2FC:
									num = (short)1688272909;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_21E:
								IL_27D:
								IL_39B:
								goto IL_70;
							}
						}
						finally
						{
							this.j.ExitReadLock();
						}
						goto IL_3BA;
						IL_70:
						num = (short)90701825;
						if (num != 0)
						{
						}
						num = (short)950468610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)791101146;
						short num5 = num;
						num = (short)1488666330;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return result;
						default:
						{
							num = (short)889454592;
							if (num != 0)
							{
							}
							num = (short)571932672;
							short num6 = num;
							if (list != null)
							{
								num = (short)1414922243;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						}
						}
						break;
					}
					case 3:
						goto IL_3BA;
					}
					goto IL_3E;
					IL_3BA:
					this.a(num4);
					num = (short)2071396352;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_3E:
				this.c();
				result = null;
				num4 = 0;
				list = null;
				this.j.EnterReadLock();
				num = (short)548274177;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000D394 File Offset: 0x0000B594
		private void e(global::Motorola.Common.Communication.RUDP.i A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_6B;
			}
			short num;
			global::Motorola.Common.Communication.RUDP.i i;
			for (;;)
			{
				IL_0A:
				num = (short)120324096;
				short num2 = num;
				num = (short)2136408065;
				if (num != 0)
				{
				}
				int num3;
				switch (num3)
				{
				case 0:
					A_0.i.ao(i.i.az());
					num = (short)31129602;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_D2;
				case 2:
					return;
				}
				goto IL_6B;
			}
			IL_D2:
			if (i != null)
			{
				goto IL_D5;
			}
			return;
			IL_6B:
			i = this.e();
			num = (short)676860318;
			short num4 = num;
			num = (short)239276446;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_D5:
				num = (short)1055784960;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			default:
			{
				num = (short)2061172736;
				if (num != 0)
				{
				}
				num = (short)1053491201;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000D4C0 File Offset: 0x0000B6C0
		private static void c(global::Motorola.Common.Communication.RUDP.i A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_45;
			}
			short num;
			long a_;
			for (;;)
			{
				IL_0A:
				num = (short)755957760;
				short num2 = num;
				int num3;
				switch (num3)
				{
				case 0:
					num = (short)1231093761;
					if (num != 0)
					{
					}
					A_0.o = a_;
					num = (short)1200160770;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_C6;
				case 2:
					return;
				}
				goto IL_45;
			}
			IL_C6:
			if (A_0.o == 0L)
			{
				goto IL_CE;
			}
			return;
			IL_45:
			a_ = global::Motorola.Common.Communication.RUDP.t.d();
			A_0.p = a_;
			int num4 = A_0.q;
			A_0.q = num4 + 1;
			num = (short)947807927;
			short num5 = num;
			num = (short)1675519671;
			switch ((num5 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_CE:
				num = (short)1361444864;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			default:
			{
				num = (short)2019688448;
				if (num != 0)
				{
				}
				num = (short)1282867201;
				int num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000D5FC File Offset: 0x0000B7FC
		public static void b(global::Motorola.Common.Communication.RUDP.i A_0)
		{
			short num = (short)1451363870;
			short num2 = num;
			num = (short)694816286;
			switch (num2 == num)
			{
			}
			num = (short)1685520384;
			short num3 = num;
			num = (short)1002176513;
			if (num != 0)
			{
			}
			num = (short)943783936;
			if (num != 0)
			{
			}
			long a_ = global::Motorola.Common.Communication.RUDP.t.d();
			A_0.r = a_;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000D6B0 File Offset: 0x0000B8B0
		public void a(object A_0)
		{
			int a_ = 9;
			short num = (short)1363732975;
			short num2 = num;
			num = (short)172485103;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1567293440;
				short num3 = num;
				num = (short)394395648;
				if (num != 0)
				{
				}
				num = (short)1211498496;
				switch (num)
				{
				default:
				{
					global::Motorola.Common.Communication.RUDP.t t = (global::Motorola.Common.Communication.RUDP.t)A_0;
					long num4 = global::Motorola.Common.Communication.RUDP.t.d();
					this.h.EnterReadLock();
					try
					{
						using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.i>.Enumerator enumerator = this.i.GetEnumerator())
						{
							num = (short)296878089;
							int num5 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num5)
								{
								case 0:
									num = (short)1515520005;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::Motorola.Common.Communication.RUDP.i i;
									if (i.q > this.b.MaxNumberofRetries)
									{
										num = (short)1577713676;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.a(i);
									num = (short)1713438726;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::Motorola.Common.Communication.RUDP.i i;
									long num6;
									global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("缬種田挲༴᜶欸帺䤼䴾⁀ⵂ㙄⩆⁈㡊㹌♎㹐㵒畔͖じ㙚㡜ⵞ䅠㝢ᝤ๦๨౪࡬ᵮ彰嵲孴ݶᡸ᡺ᙼ᩾뺂ﺄ랆뎈펊ꎎ놐璉ꊞ\udaa0銢\ud8a4讦쪨쒪\ud8ac솮얰횲잴誶슸覺삼", a_), new object[]
									{
										i.i.az(),
										num6 / 1000L,
										t.g()
									});
									num = (short)1941569547;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::Motorola.Common.Communication.RUDP.i i;
									this.a.ao().m = i.q;
									num = (short)1500381199;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)1001455629;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::Motorola.Common.Communication.RUDP.i i;
									if (!i.s)
									{
										num = (short)1688993802;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									long num6;
									if (num6 > (long)(this.b.TimeBetweenRetries * 1000))
									{
										num = (short)417726466;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
									switch (0)
									{
									case 0:
										goto IL_12D;
									}
									continue;
								case 10:
								{
									global::Motorola.Common.Communication.RUDP.i i;
									long num6 = num4 - i.p;
									num = (short)95813639;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
								{
									global::Motorola.Common.Communication.RUDP.i i;
									if (i.q > this.a.ao().m)
									{
										num = (short)693174275;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_29C;
								}
								case 12:
								{
									global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("缬䨮䔰䄲吴夶䨸嘺吼䰾㉀⩂⩄⥆獈歊Ὄ⩎ぐげ㵔睖ⵘ㍚㡜罞ౠɢᵤ䝦䩨䭪ɬ८兰ŲၴͶ୸ቺ᡼౾꾀", a_), global::System.Array.Empty<object>());
									global::Motorola.Common.Communication.RUDP.i i;
									i.av();
									num = (short)1514471432;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 13:
									goto IL_3E8;
								case 14:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1794834436;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.RUDP.i i = enumerator.Current;
									num = (short)2138898448;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 15:
									goto IL_29C;
								case 16:
								{
									global::Motorola.Common.Communication.RUDP.i i;
									if (!i.h)
									{
										num = (short)1863057408;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_1AC:
								num = (short)1156055054;
								num5 = (int)((global::System.IntPtr)num);
								continue;
								IL_12D:
								goto IL_1AC;
								IL_29C:
								num = (short)89063425;
								num5 = (int)((global::System.IntPtr)num);
							}
							IL_3E8:;
						}
						num = (short)52035585;
						if (num != 0)
						{
						}
					}
					catch (global::System.Exception ex)
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(ex.Message, global::System.Array.Empty<object>());
					}
					finally
					{
						this.h.ExitReadLock();
					}
					break;
				}
				}
				break;
			}
			}
			this.a();
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000DB58 File Offset: 0x0000BD58
		public void b(object A_0)
		{
			int a_ = 4;
			short num = (short)147045196;
			short num2 = num;
			num = (short)854637388;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)861536256;
				short num3 = num;
				num = (short)105644032;
				if (num != 0)
				{
				}
				num = (short)71827457;
				if (num != 0)
				{
				}
				num = (short)2007040000;
				switch (num)
				{
				default:
				{
					long num4 = global::Motorola.Common.Communication.RUDP.t.d();
					this.b();
					this.l.EnterReadLock();
					try
					{
						using (global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.i>.Enumerator enumerator = this.m.GetEnumerator())
						{
							num = (short)1220214787;
							int num5 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num5)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)934608903;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.Common.Communication.RUDP.i i = enumerator.Current;
									num = (short)586940424;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_32F;
								case 2:
								{
									long num6;
									global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("愧䜩䄫䬭启嬱唳䈵崷嘹䔻ḽĿŁགྷ晅⹇╉㹋湍ᙏ⁑㕓ㅕ㕗㽙㉛⩝也䱡䩣ᵥ塧ᝩ", a_), new object[]
									{
										num6 / 1000L
									});
									global::Motorola.Common.Communication.RUDP.i i;
									this.q(i);
									i.h = true;
									num = (short)339410955;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_141;
									}
									continue;
								case 4:
								{
									global::Motorola.Common.Communication.RUDP.i i;
									long num6 = num4 - i.r;
									num = (short)920387593;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									long num6;
									global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("氧伩䀫伭䤯ሱ申电猷ᨹ栻圽ⴿ❁㙃晅᱇㡉╋⥍㝏㝑♓硕癗瑙❛湝ᵟ", a_), new object[]
									{
										num6 / 1000L
									});
									global::Motorola.Common.Communication.RUDP.i i;
									this.q(i);
									i.h = true;
									num = (short)344457222;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									num = (short)68026369;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::Motorola.Common.Communication.RUDP.i i;
									if (!i.h)
									{
										num = (short)1754333188;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
								{
									global::Motorola.Common.Communication.RUDP.i i;
									if (i.i.ay())
									{
										num = (short)1541275650;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2141257738;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									long num6;
									if (num6 > (long)(this.b.DelayedAckTimeout * 1000))
									{
										num = (short)399966213;
										num5 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_1DF:
								num = (short)1108541440;
								num5 = (int)((global::System.IntPtr)num);
								continue;
								IL_141:
								goto IL_1DF;
							}
							IL_32F:;
						}
					}
					catch (global::System.Exception ex)
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(ex.Message, global::System.Array.Empty<object>());
					}
					finally
					{
						this.l.ExitReadLock();
					}
					break;
				}
				}
				break;
			}
			}
			this.b();
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000DF20 File Offset: 0x0000C120
		public void n()
		{
			short num = (short)684482032;
			short num2 = num;
			num = (short)1856396784;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2071986176;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1115684865;
			if (num != 0)
			{
			}
			num = (short)1377566720;
			if (num != 0)
			{
			}
			this.c.e();
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000DFDC File Offset: 0x0000C1DC
		private int a(global::Motorola.Common.Communication.RUDP.i A_0)
		{
			int a_ = 0;
			short num = (short)1821979278;
			short num2 = num;
			num = (short)398996110;
			switch (num2 == num)
			{
			default:
			{
				num = (short)139067392;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1415184385;
			if (num != 0)
			{
			}
			num = (short)1997537280;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("瘣猥氧稩ᘫอ戯圱䀳䐵夷吹伻匽⤿ㅁ㝃⽅❇⑉態湍O㍑㝓㵕㵗⹙籛ⱝ՟ᅡţࡥ౧ͩɫ७幯山婳", a_), global::System.Array.Empty<object>());
			int num4 = this.a.o(A_0);
			this.a.ao().k++;
			this.a.ao().i += num4;
			this.a.ao().j++;
			global::Motorola.Common.Communication.RUDP.h.c(A_0);
			return num4;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000E104 File Offset: 0x0000C304
		public void q(global::Motorola.Common.Communication.RUDP.i A_0)
		{
			int a_ = 10;
			short num = (short)1906717053;
			short num2 = num;
			num = (short)276640125;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1755774976;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("簭支瘱搳వᠷ渹䐻ጽ怿ᅁ⅃⡅ⱇ⍉≋⥍灏ፑᝓᵕ硗㱙㍛ⱝ䁟ୡ੣եݧݩիmᝯ剱⑳᝵᭷ᅹ᥻੽뵿뺁ﾃ뚅늇낍뺏벑몓", a_), new object[]
				{
					A_0.i.az()
				});
				global::Motorola.Common.Communication.RUDP.i i = global::Motorola.Common.Communication.RUDP.k.a(this.a, A_0);
				ushort num3 = (ushort)this.a.o(i);
				A_0.h = true;
				if (num3 == i.f)
				{
					return;
				}
				break;
			}
			}
			num = (short)2119696385;
			if (num != 0)
			{
			}
			num = (short)853344256;
			short num4 = num;
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RUDP_SendIsNotCompleted);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000E21C File Offset: 0x0000C41C
		private void b()
		{
			int a_ = 19;
			short num = (short)1686877857;
			short num2 = num;
			num = (short)1751561889;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)74711040;
				short num3 = num;
				num = (short)827195393;
				if (num != 0)
				{
				}
				num = (short)835715072;
				if (num != 0)
				{
				}
				num = (short)546045952;
				int num4 = (int)num;
				switch (num4)
				{
				default:
					this.l.EnterWriteLock();
					try
					{
						switch (0)
						{
						case 0:
							goto IL_F4;
						}
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.i> list;
						global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.i>.Enumerator enumerator;
						for (;;)
						{
							IL_D9:
							switch (num4)
							{
							case 0:
								goto IL_294;
							case 1:
								try
								{
									num = (short)1793982470;
									num4 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::Motorola.Common.Communication.RUDP.i i;
										switch (num4)
										{
										case 0:
											num = (short)1111228419;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											goto IL_1DA;
										case 2:
											if (list == null)
											{
												num = (short)1476788228;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_1DA;
										case 3:
											goto IL_281;
										case 4:
											list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.i>();
											num = (short)389611521;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 5:
											if (!enumerator.MoveNext())
											{
												num = (short)2003959808;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											i = enumerator.Current;
											num = (short)1904607239;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										case 6:
											switch (0)
											{
											case 0:
												goto IL_16B;
											}
											continue;
										case 7:
											if (i.h)
											{
												num = (short)1367474184;
												num4 = (int)((global::System.IntPtr)num);
												continue;
											}
											break;
										case 8:
											num = (short)1946550274;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_19F:
										num = (short)1476329477;
										num4 = (int)((global::System.IntPtr)num);
										continue;
										IL_16B:
										goto IL_19F;
										IL_1DA:
										list.Add(i);
										num = (short)1158414345;
										num4 = (int)((global::System.IntPtr)num);
									}
									IL_281:
									goto IL_3BC;
								}
								finally
								{
									((global::System.IDisposable)enumerator).Dispose();
								}
								goto Block_3;
								IL_3BC:
								num = (short)424804356;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_40D;
							case 3:
								goto IL_398;
							case 4:
								if (list != null)
								{
									num = (short)310771715;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)486539266;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_F4;
							IL_398:
							enumerator = list.GetEnumerator();
							num = (short)2112028672;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							Block_3:
							try
							{
								IL_294:
								num = (short)1149042689;
								num4 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num4)
									{
									case 1:
										switch (0)
										{
										case 0:
											goto IL_2D0;
										}
										continue;
									case 2:
										goto IL_385;
									case 3:
										num = (short)728956930;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1907752963;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Common.Communication.RUDP.i i2 = enumerator.Current;
										this.m.Remove(i2);
										global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("收尸嘺刼䤾⑀❂敄㉆❈⩊⹌⑎㑐㝒畔㹖㝘㡚㉜㉞ࡠൢɤ䝦ᥨ੪๬Ѯᑰݲ䥴౶䥸䅺ռɾ뾀궂ꮄ", a_), new object[]
										{
											i2.i.az()
										});
										num = (short)84148224;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_32F:
									num = (short)333381636;
									num4 = (int)((global::System.IntPtr)num);
									continue;
									IL_2D0:
									goto IL_32F;
								}
								IL_385:
								break;
							}
							finally
							{
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_398;
						}
						IL_40D:
						break;
						IL_F4:
						list = null;
						enumerator = this.m.GetEnumerator();
						num = (short)1059127297;
						num4 = (int)((global::System.IntPtr)num);
						goto IL_D9;
					}
					finally
					{
						this.l.ExitWriteLock();
					}
					break;
				}
				break;
			}
			}
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000E690 File Offset: 0x0000C890
		private void a()
		{
			int a_ = 8;
			short num = (short)1228931072;
			short num2 = num;
			num = (short)542244864;
			switch (num)
			{
			default:
			{
				this.h.EnterWriteLock();
				global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.i> list = null;
				try
				{
					global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.i>.Enumerator enumerator = this.i.GetEnumerator();
					try
					{
						num = (short)1654456323;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::Motorola.Common.Communication.RUDP.i i;
							switch (num3)
							{
							case 0:
								goto IL_36A;
							case 1:
								goto IL_439;
							case 2:
								if (!enumerator.MoveNext())
								{
									num = (short)1493434378;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								i = enumerator.Current;
								num = (short)1029505032;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_2E9;
								}
								continue;
							case 4:
								num = (short)1020329990;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								if (i.s)
								{
									num = (short)1955135488;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 7:
								if (list == null)
								{
									num = (short)1624047627;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_3FF;
							case 8:
								if (!i.h)
								{
									num = (short)2103508996;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_36A;
							case 9:
								goto IL_3FF;
							case 10:
								num = (short)207749121;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 11:
								list = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.i>();
								num = (short)323682313;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2E9;
							IL_36A:
							num = (short)2085486599;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_3C0:
							num = (short)2052784130;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_2E9:
							goto IL_3C0;
							IL_3FF:
							list.Add(i);
							num = (short)635633669;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_439:;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_27E;
				}
				catch (global::System.Exception ex)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteInfo(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("縫笭琯戱ำᘵ䨷弹儻儽㘿❁摃㍅♇⭉⽋╍㕏㙑瑓㥕⩗穙㍛㱝፟ൡࡣͥᱧཀྵ࡫乭Ὧݱsᅵ᝷፹ቻ᥽ꁿ꺍ﮑﺕ뢗ﾙﶝ얟튡킣쾥잧쒩貫钭邯즱蒳쮵", a_), new object[]
					{
						ex.Message
					});
					goto IL_27E;
				}
				return;
				for (;;)
				{
					IL_27E:
					try
					{
						num = (short)1462108160;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.i>.Enumerator enumerator;
							switch (num3)
							{
							case 0:
							{
								num = (short)649767192;
								short num4 = num;
								num = (short)1767352600;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1791426560;
									if (num != 0)
									{
									}
									switch (0)
									{
									case 0:
										goto IL_E3;
									}
									continue;
								}
								break;
							}
							case 1:
								goto IL_230;
							case 2:
								goto IL_26D;
							case 3:
								try
								{
									num = (short)190971905;
									num3 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num3)
										{
										case 1:
											switch (0)
											{
											case 0:
												goto IL_165;
											}
											continue;
										case 2:
											goto IL_21D;
										case 3:
											num = (short)356646914;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 4:
										{
											if (!enumerator.MoveNext())
											{
												num = (short)1199046659;
												num3 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::Motorola.Common.Communication.RUDP.i i2 = enumerator.Current;
											this.i.Remove(i2);
											global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteInfo(global::Motorola.Common.Communication.RUDP.RUDPSocket.i("縫笭琯戱ำᘵ䨷弹儻儽㘿❁摃㍅♇⭉⽋╍㕏㙑瑓㥕ⵗ⹙㭛ㅝय़ౡͣ䙥ᡧ୩ཫխᕯٱ䥳䩵ͷ䩹䙻ٽﵿ벁", a_), new object[]
											{
												i2.i.az()
											});
											num = (short)1836122112;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										}
										IL_1C7:
										num = (short)1699217412;
										num3 = (int)((global::System.IntPtr)num);
										continue;
										IL_165:
										goto IL_1C7;
									}
									IL_21D:
									return;
								}
								finally
								{
									((global::System.IDisposable)enumerator).Dispose();
								}
								goto IL_230;
							}
							IL_E3:
							num = (short)67633153;
							if (num != 0)
							{
							}
							if (list != null)
							{
								num = (short)974389249;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1727725570;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_230:
							enumerator = list.GetEnumerator();
							num = (short)2099707907;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_26D:
						break;
					}
					finally
					{
						this.h.ExitWriteLock();
					}
				}
				return;
			}
			}
		}

		// Token: 0x04000075 RID: 117
		private global::Motorola.Common.Communication.RUDP.b a;

		// Token: 0x04000076 RID: 118
		private global::Motorola.Common.Communication.RUDP.RUDPConfigParams b;

		// Token: 0x04000077 RID: 119
		private global::Motorola.Common.Communication.RUDP.w c;

		// Token: 0x04000078 RID: 120
		private global::Motorola.Common.Communication.RUDP.v d;

		// Token: 0x04000079 RID: 121
		private int e = global::Motorola.Common.Communication.RUDP.c.v;

		// Token: 0x0400007A RID: 122
		private global::System.Threading.ReaderWriterLockSlim f = new global::System.Threading.ReaderWriterLockSlim();

		// Token: 0x0400007B RID: 123
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.i> g = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.i>();

		// Token: 0x0400007C RID: 124
		private global::System.Threading.ReaderWriterLockSlim h = new global::System.Threading.ReaderWriterLockSlim();

		// Token: 0x0400007D RID: 125
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.i> i = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.i>();

		// Token: 0x0400007E RID: 126
		private global::System.Threading.ReaderWriterLockSlim j = new global::System.Threading.ReaderWriterLockSlim();

		// Token: 0x0400007F RID: 127
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.i> k = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.i>();

		// Token: 0x04000080 RID: 128
		private global::System.Threading.ReaderWriterLockSlim l = new global::System.Threading.ReaderWriterLockSlim();

		// Token: 0x04000081 RID: 129
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.i> m = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.RUDP.i>();
	}
}
