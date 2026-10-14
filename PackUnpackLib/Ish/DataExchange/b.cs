using System;
using System.Collections;
using System.Collections.Generic;
using Motorola.Acp.PackUnpack.Ish.Collections;
using Motorola.Acp.PackUnpack.Ish.Layouts;

namespace Motorola.Acp.PackUnpack.Ish.DataExchange
{
	// Token: 0x02000087 RID: 135
	internal class b : global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.DataExchange.a>, global::System.Collections.IEnumerable
	{
		// Token: 0x060003D5 RID: 981 RVA: 0x0004867C File Offset: 0x0004687C
		internal b(global::Motorola.Acp.PackUnpack.Ish.IshType A_0)
		{
			this.a = A_0;
			this.b = new global::System.Collections.Generic.Dictionary<global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType, global::Motorola.Acp.PackUnpack.Ish.DataExchange.a>();
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x000486A4 File Offset: 0x000468A4
		internal global::Motorola.Acp.PackUnpack.Ish.IshType a()
		{
			short num = (short)1937717187;
			short num2 = num;
			num = (short)862664643;
			switch (num2 == num)
			{
			}
			num = (short)627572737;
			if (num != 0)
			{
			}
			num = (short)1207631872;
			short num3 = num;
			num = (short)330170368;
			if (num != 0)
			{
			}
			return this.a;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00048754 File Offset: 0x00046954
		internal void Add(global::Motorola.Acp.PackUnpack.Ish.DataExchange.a A_0)
		{
			int a_ = 1;
			short num = (short)535494657;
			if (num != 0)
			{
			}
			if (A_0 == null)
			{
				num = (short)1302799855;
				short num2 = num;
				num = (short)309798383;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1494745088;
					if (num != 0)
					{
					}
					num = (short)208470016;
					short num3 = num;
					throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("鍊", a_));
				}
				}
			}
			this.b.Add(A_0.a(), A_0);
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00048834 File Offset: 0x00046A34
		internal void b()
		{
			short num = (short)1438828865;
			short num2 = num;
			num = (short)988465473;
			switch (num2 == num)
			{
			}
			num = (short)839385089;
			if (num != 0)
			{
			}
			num = (short)1554972672;
			short num3 = num;
			num = (short)960233472;
			if (num != 0)
			{
			}
			this.b.Clear();
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x000488E4 File Offset: 0x00046AE4
		internal bool a(global::Motorola.Acp.PackUnpack.Ish.DataExchange.a A_0)
		{
			if (A_0 == null)
			{
				short num = (short)1715839820;
				short num2 = num;
				num = (short)174629708;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1555431425;
					if (num != 0)
					{
					}
					num = (short)881917952;
					if (num != 0)
					{
					}
					num = (short)345571328;
					short num3 = num;
					return false;
				}
				}
			}
			return this.b.ContainsKey(A_0.a());
		}

		// Token: 0x060003DA RID: 986 RVA: 0x000489A8 File Offset: 0x00046BA8
		internal bool a(global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType A_0)
		{
			short num = (short)1754253668;
			short num2 = num;
			num = (short)1410517348;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1475411968;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)178847744;
			if (num != 0)
			{
			}
			num = (short)744423425;
			if (num != 0)
			{
			}
			return this.b.ContainsKey(A_0);
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00048A60 File Offset: 0x00046C60
		internal int c()
		{
			short num = (short)1775458526;
			short num2 = num;
			num = (short)269179102;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1885601792;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)598605825;
			if (num != 0)
			{
			}
			num = (short)197459968;
			if (num != 0)
			{
			}
			return this.b.Count;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00048B10 File Offset: 0x00046D10
		internal bool b(global::Motorola.Acp.PackUnpack.Ish.DataExchange.a A_0)
		{
			int a_ = 3;
			short num = (short)941752321;
			if (num != 0)
			{
			}
			if (A_0 == null)
			{
				for (;;)
				{
					num = (short)2132344832;
					short num2 = num;
					num = (short)626481211;
					short num3 = num;
					num = (short)1218009147;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_98;
					}
				}
				IL_98:
				num = (short)720896;
				if (num != 0)
				{
				}
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("ﮝ춟", a_));
			}
			return this.b.Remove(A_0.a());
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00048BF4 File Offset: 0x00046DF4
		internal bool b(global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType A_0)
		{
			short num = (short)865293122;
			short num2 = num;
			num = (short)377967426;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1673592832;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1701052417;
			if (num != 0)
			{
			}
			num = (short)1357381632;
			if (num != 0)
			{
			}
			return this.b.Remove(A_0);
		}

		// Token: 0x170000F0 RID: 240
		internal global::Motorola.Acp.PackUnpack.Ish.DataExchange.a this[global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType A_0]
		{
			get
			{
				short num = (short)1522056041;
				short num2 = num;
				num = (short)1489550185;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1324154880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)911147009;
				if (num != 0)
				{
				}
				num = (short)2144600064;
				if (num != 0)
				{
				}
				return this.b[A_0];
			}
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00048D60 File Offset: 0x00046F60
		public global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.a> GetEnumerator()
		{
			short num = (short)1293915263;
			short num2 = num;
			num = (short)1791136895;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1715208192;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)561119232;
			if (num != 0)
			{
			}
			num = (short)451280897;
			if (num != 0)
			{
			}
			global::Motorola.Acp.PackUnpack.Ish.DataExchange.b.a a = new global::Motorola.Acp.PackUnpack.Ish.DataExchange.b.a(0);
			a.c = this;
			return a;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00048E18 File Offset: 0x00047018
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.d()
		{
			short num = (short)2059864644;
			short num2 = num;
			num = (short)2052459076;
			switch (num2 == num)
			{
			default:
			{
				num = (short)133693440;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)307036161;
			if (num != 0)
			{
			}
			num = (short)363724800;
			if (num != 0)
			{
			}
			return this.GetEnumerator();
		}

		// Token: 0x0400016B RID: 363
		private global::Motorola.Acp.PackUnpack.Ish.IshType a;

		// Token: 0x0400016C RID: 364
		private global::System.Collections.Generic.Dictionary<global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType, global::Motorola.Acp.PackUnpack.Ish.DataExchange.a> b;
	}
}
