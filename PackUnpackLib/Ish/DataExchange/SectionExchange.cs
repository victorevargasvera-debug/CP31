using System;
using System.Collections;
using System.Collections.Generic;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish.DataExchange
{
	// Token: 0x0200008A RID: 138
	public class SectionExchange : global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange>, global::System.Collections.IEnumerable
	{
		// Token: 0x060003EA RID: 1002 RVA: 0x000496B0 File Offset: 0x000478B0
		internal SectionExchange(int A_0)
		{
			this.a = A_0;
			this.b = new global::System.Collections.Generic.Dictionary<string, global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange>();
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x000496D8 File Offset: 0x000478D8
		internal int Key
		{
			get
			{
				short num = (short)2075000833;
				if (num != 0)
				{
				}
				num = (short)649854976;
				short num2 = num;
				num = (short)129537324;
				short num3 = num;
				num = (short)866686252;
				switch (num3 == num)
				{
				}
				num = (short)1092681728;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00049788 File Offset: 0x00047988
		internal void Add(global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange A_0)
		{
			int a_ = 0;
			if (A_0 == null)
			{
				short num;
				for (;;)
				{
					num = (short)1066598400;
					short num2 = num;
					num = (short)1132429927;
					short num3 = num;
					num = (short)338788967;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_70;
					}
				}
				IL_70:
				num = (short)788332545;
				if (num != 0)
				{
				}
				num = (short)1928921088;
				if (num != 0)
				{
				}
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﺖﺚ", a_));
			}
			A_0.Parent = this;
			this.b.Add(A_0.PropertyName, A_0);
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x00049870 File Offset: 0x00047A70
		internal void b()
		{
			short num = (short)1834440460;
			short num2 = num;
			num = (short)525686540;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1070858240;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)334102528;
			if (num != 0)
			{
			}
			num = (short)2124349441;
			if (num != 0)
			{
			}
			this.b.Clear();
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x00049924 File Offset: 0x00047B24
		internal bool a(global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange A_0)
		{
			if (A_0 == null)
			{
				short num = (short)1881563115;
				short num2 = num;
				num = (short)186474475;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_A6;
				case 1:
					break;
				default:
				{
					num = (short)1350959104;
					short num3 = num;
					break;
				}
				}
				num = (short)837812224;
				if (num != 0)
				{
				}
				num = (short)703201281;
				if (num != 0)
				{
				}
				return false;
			}
			IL_A6:
			return this.b.ContainsKey(A_0.PropertyName);
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x000499E8 File Offset: 0x00047BE8
		internal bool a(string A_0)
		{
			short num = (short)1328023939;
			short num2 = num;
			num = (short)246352259;
			switch (num2 == num)
			{
			}
			num = (short)834404353;
			if (num != 0)
			{
			}
			num = (short)675545088;
			short num3 = num;
			num = (short)1563754496;
			if (num != 0)
			{
			}
			return this.b.ContainsKey(A_0);
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x060003F0 RID: 1008 RVA: 0x00049AA0 File Offset: 0x00047CA0
		internal int Count
		{
			get
			{
				short num = (short)1997366573;
				short num2 = num;
				num = (short)1450796333;
				switch (num2 == num)
				{
				}
				num = (short)1297809409;
				if (num != 0)
				{
				}
				num = (short)464846848;
				short num3 = num;
				num = (short)1286537216;
				if (num != 0)
				{
				}
				return this.b.Count;
			}
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00049B58 File Offset: 0x00047D58
		internal bool b(global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange A_0)
		{
			int a_ = 16;
			short num = (short)1507000323;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_9F;
				case 1:
					return false;
				case 2:
				{
					num = (short)273219585;
					if (num != 0)
					{
					}
					num = (short)545587200;
					short num3 = num;
					if (!this.b.Remove(A_0.PropertyName))
					{
						num = (short)1976238081;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14F;
				}
				case 3:
				{
					num = (short)918087617;
					short num4 = num;
					num = (short)1486153665;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9F;
					default:
						num = (short)1526267904;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_88;
						}
						continue;
					}
					break;
				}
				}
				IL_88:
				if (A_0 == null)
				{
					num = (short)708182016;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1299382274;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_9F:
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("캦\udda8캪사", a_));
			IL_14F:
			A_0.Parent = null;
			return true;
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00049CBC File Offset: 0x00047EBC
		internal bool b(string A_0)
		{
			if (!this.b.ContainsKey(A_0))
			{
				short num = (short)936212665;
				short num2 = num;
				num = (short)1041791161;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_AF;
				case 1:
					break;
				default:
				{
					num = (short)2004811776;
					short num3 = num;
					break;
				}
				}
				num = (short)1425342464;
				if (num != 0)
				{
				}
				num = (short)1509621761;
				if (num != 0)
				{
				}
				return false;
			}
			IL_AF:
			this.b[A_0].Parent = null;
			this.b.Remove(A_0);
			return true;
		}

		// Token: 0x170000F3 RID: 243
		internal global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange this[string A_0]
		{
			get
			{
				short num = (short)723375883;
				short num2 = num;
				num = (short)215144203;
				switch (num2 == num)
				{
				}
				num = (short)1286340608;
				if (num != 0)
				{
				}
				num = (short)1497432064;
				short num3 = num;
				num = (short)819396609;
				if (num != 0)
				{
				}
				return this.b[A_0];
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x060003F4 RID: 1012 RVA: 0x00049E4C File Offset: 0x0004804C
		// (set) Token: 0x060003F5 RID: 1013 RVA: 0x00049EFC File Offset: 0x000480FC
		internal global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange Parent
		{
			get
			{
				short num = (short)2043775951;
				short num2 = num;
				num = (short)941001679;
				switch (num2 == num)
				{
				}
				num = (short)392298497;
				if (num != 0)
				{
				}
				num = (short)1657077760;
				short num3 = num;
				num = (short)710410240;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)372105396;
				short num2 = num;
				num = (short)2080891060;
				switch (num2 == num)
				{
				}
				num = (short)2092236801;
				if (num != 0)
				{
				}
				num = (short)775421952;
				short num3 = num;
				num = (short)370409472;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x060003F6 RID: 1014 RVA: 0x00049FA8 File Offset: 0x000481A8
		// (set) Token: 0x060003F7 RID: 1015 RVA: 0x0004A058 File Offset: 0x00048258
		internal global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange RecsetExchange
		{
			get
			{
				short num = (short)1267147239;
				short num2 = num;
				num = (short)194257383;
				switch (num2 == num)
				{
				}
				num = (short)1242628097;
				if (num != 0)
				{
				}
				num = (short)2035744768;
				short num3 = num;
				num = (short)252379136;
				if (num != 0)
				{
				}
				return this.d;
			}
			set
			{
				short num = (short)1781989378;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (this.d == null)
						{
							return;
						}
						num = (short)168041292;
						short num3 = num;
						num = (short)869145420;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1198915584;
							if (num != 0)
							{
							}
							num = (short)1991049217;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
					{
						this.d.Parent = null;
						this.d = null;
						num = (short)683999232;
						short num4 = num;
						num = (short)1358757891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)1192099841;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_5E;
						}
						continue;
					case 3:
						return;
					case 4:
						goto IL_76;
					}
					IL_5E:
					if (value != null)
					{
						num = (short)1703940;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)292880384;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_76:
				value.Parent = this;
				this.d = value;
			}
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0004A1D0 File Offset: 0x000483D0
		public global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange> GetEnumerator()
		{
			short num = (short)1970516879;
			short num2 = num;
			num = (short)1865397135;
			switch (num2 == num)
			{
			}
			num = (short)842989569;
			if (num != 0)
			{
			}
			num = (short)193003520;
			short num3 = num;
			num = (short)1510080512;
			if (num != 0)
			{
			}
			global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange.a a = new global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange.a(0);
			a.c = this;
			return a;
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0004A284 File Offset: 0x00048484
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			short num = (short)1969336805;
			short num2 = num;
			num = (short)1047376357;
			switch (num2 == num)
			{
			}
			num = (short)2049769473;
			if (num != 0)
			{
			}
			num = (short)1706688512;
			short num3 = num;
			num = (short)925564928;
			if (num != 0)
			{
			}
			return this.GetEnumerator();
		}

		// Token: 0x04000171 RID: 369
		private int a;

		// Token: 0x04000172 RID: 370
		private global::System.Collections.Generic.Dictionary<string, global::Motorola.Acp.PackUnpack.Ish.DataExchange.FieldExchange> b;

		// Token: 0x04000173 RID: 371
		private global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange c;

		// Token: 0x04000174 RID: 372
		private global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange d;
	}
}
