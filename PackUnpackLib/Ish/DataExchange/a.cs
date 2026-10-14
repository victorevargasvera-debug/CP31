using System;
using System.Collections;
using System.Collections.Generic;
using Motorola.Acp.PackUnpack.Ish.Collections;
using Motorola.Acp.PackUnpack.Ish.Layouts;

namespace Motorola.Acp.PackUnpack.Ish.DataExchange
{
	// Token: 0x02000083 RID: 131
	internal class a : global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange>, global::System.Collections.IEnumerable
	{
		// Token: 0x060003AF RID: 943 RVA: 0x0004698C File Offset: 0x00044B8C
		internal a(global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType A_0)
		{
			this.a = A_0;
			this.b = new global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange>();
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x000469B4 File Offset: 0x00044BB4
		internal global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType a()
		{
			short num = (short)2066615862;
			short num2 = num;
			num = (short)163712566;
			switch (num2 == num)
			{
			}
			num = (short)698286081;
			if (num != 0)
			{
			}
			num = (short)365101056;
			short num3 = num;
			num = (short)590217216;
			if (num != 0)
			{
			}
			return this.a;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00046A64 File Offset: 0x00044C64
		internal void Add(global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange A_0)
		{
			int a_ = 4;
			if (A_0 == null)
			{
				short num = (short)253228988;
				short num2 = num;
				num = (short)86439868;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1094451201;
					if (num != 0)
					{
					}
					num = (short)74579968;
					if (num != 0)
					{
					}
					num = (short)1013252096;
					short num3 = num;
					throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("爵철", a_));
				}
				}
			}
			this.b.Add(A_0.Key, A_0);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00046B48 File Offset: 0x00044D48
		internal void b()
		{
			short num = (short)1707252148;
			short num2 = num;
			num = (short)105486772;
			switch (num2 == num)
			{
			}
			num = (short)653787137;
			if (num != 0)
			{
			}
			num = (short)328073216;
			short num3 = num;
			num = (short)938016768;
			if (num != 0)
			{
			}
			this.b.Clear();
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00046BFC File Offset: 0x00044DFC
		internal bool a(global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange A_0)
		{
			if (A_0 == null)
			{
				short num = (short)1639528568;
				short num2 = num;
				num = (short)579352696;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1478230017;
					if (num != 0)
					{
					}
					num = (short)450494464;
					if (num != 0)
					{
					}
					num = (short)2142699520;
					short num3 = num;
					return false;
				}
				}
			}
			return this.b.ContainsKey(A_0.Key);
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00046CC0 File Offset: 0x00044EC0
		internal bool a(int A_0)
		{
			short num = (short)1568295883;
			short num2 = num;
			num = (short)702434251;
			switch (num2 == num)
			{
			}
			num = (short)1451884545;
			if (num != 0)
			{
			}
			num = (short)493092864;
			short num3 = num;
			num = (short)798818304;
			if (num != 0)
			{
			}
			return this.b.ContainsKey(A_0);
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00046D74 File Offset: 0x00044F74
		internal int c()
		{
			short num = (short)195604459;
			short num2 = num;
			num = (short)914272235;
			switch (num2 == num)
			{
			}
			num = (short)359989249;
			if (num != 0)
			{
			}
			num = (short)444530688;
			short num3 = num;
			num = (short)746061824;
			if (num != 0)
			{
			}
			return this.b.Count;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00046E28 File Offset: 0x00045028
		internal bool b(global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange A_0)
		{
			int a_ = 13;
			if (A_0 == null)
			{
				short num = (short)1561180199;
				short num2 = num;
				num = (short)422295591;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)304414721;
					if (num != 0)
					{
					}
					num = (short)1010237440;
					if (num != 0)
					{
					}
					num = (short)469762048;
					short num3 = num;
					throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("춣튥춧잩", a_));
				}
				}
			}
			return this.b.Remove(A_0.Key);
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00046F08 File Offset: 0x00045108
		internal bool b(int A_0)
		{
			short num = (short)1667456198;
			short num2 = num;
			num = (short)1056988358;
			switch (num2 == num)
			{
			}
			num = (short)784072704;
			if (num != 0)
			{
			}
			num = (short)75694080;
			short num3 = num;
			num = (short)1974075393;
			if (num != 0)
			{
			}
			return this.b.Remove(A_0);
		}

		// Token: 0x170000E8 RID: 232
		internal global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange this[int A_0]
		{
			get
			{
				short num = (short)1031348375;
				short num2 = num;
				num = (short)2236567;
				switch (num2 == num)
				{
				}
				num = (short)2086535168;
				if (num != 0)
				{
				}
				num = (short)1492516864;
				short num3 = num;
				num = (short)1933836289;
				if (num != 0)
				{
				}
				return this.b[A_0];
			}
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00047074 File Offset: 0x00045274
		public global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange> GetEnumerator()
		{
			short num = (short)137101313;
			if (num != 0)
			{
			}
			num = (short)1308326976;
			short num2 = num;
			num = (short)1233550400;
			switch (num2 == num)
			{
			}
			num = (short)252772352;
			short num3 = num;
			num = (short)2067136512;
			if (num != 0)
			{
			}
			global::Motorola.Acp.PackUnpack.Ish.DataExchange.a.a a = new global::Motorola.Acp.PackUnpack.Ish.DataExchange.a.a(0);
			a.c = this;
			return a;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00047128 File Offset: 0x00045328
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.d()
		{
			short num = (short)1638433533;
			short num2 = num;
			num = (short)345146109;
			switch (num2 == num)
			{
			}
			num = (short)781385729;
			if (num != 0)
			{
			}
			num = (short)1841692672;
			short num3 = num;
			num = (short)1082785792;
			if (num != 0)
			{
			}
			return this.GetEnumerator();
		}

		// Token: 0x0400015F RID: 351
		private global::Motorola.Acp.PackUnpack.Ish.Layouts.DataAreaType a;

		// Token: 0x04000160 RID: 352
		private global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange> b;
	}
}
