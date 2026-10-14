using System;
using System.Collections;
using System.Collections.Generic;
using Motorola.Acp.PackUnpack.Ish.Collections;

namespace Motorola.Acp.PackUnpack.Ish.DataExchange
{
	// Token: 0x02000084 RID: 132
	public class RecsetExchange : global::System.Collections.Generic.IEnumerable<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange>, global::System.Collections.IEnumerable
	{
		// Token: 0x060003BB RID: 955 RVA: 0x000471D8 File Offset: 0x000453D8
		internal RecsetExchange(int A_0)
		{
			this.a = A_0;
			this.b = new global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange>();
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060003BC RID: 956 RVA: 0x00047200 File Offset: 0x00045400
		internal int Key
		{
			get
			{
				short num = (short)930487800;
				short num2 = num;
				num = (short)2103844344;
				switch (num2 == num)
				{
				default:
				{
					num = (short)408944640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1708523521;
				if (num != 0)
				{
				}
				num = (short)1105723392;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x060003BD RID: 957 RVA: 0x000472B0 File Offset: 0x000454B0
		internal void Add(global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange A_0)
		{
			int a_ = 9;
			short num;
			if (A_0 == null)
			{
				for (;;)
				{
					num = (short)589168640;
					short num2 = num;
					num = (short)1187166764;
					short num3 = num;
					num = (short)862501420;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_71;
					}
				}
				IL_71:
				num = (short)1443627008;
				if (num != 0)
				{
				}
				throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("즟횡솣쮥", a_));
			}
			num = (short)2069757953;
			if (num != 0)
			{
			}
			A_0.Parent = this;
			this.b.Add(A_0.Key, A_0);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00047398 File Offset: 0x00045598
		internal void b()
		{
			short num = (short)768077587;
			short num2 = num;
			num = (short)1806429971;
			switch (num2 == num)
			{
			default:
			{
				num = (short)849477632;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)701169665;
			if (num != 0)
			{
			}
			num = (short)1623982080;
			if (num != 0)
			{
			}
			this.b.Clear();
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00047450 File Offset: 0x00045650
		internal bool a(global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange A_0)
		{
			if (A_0 == null)
			{
				short num;
				for (;;)
				{
					num = (short)1245970432;
					short num2 = num;
					num = (short)198157127;
					short num3 = num;
					num = (short)713663303;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_67;
					}
				}
				IL_67:
				num = (short)1957167105;
				if (num != 0)
				{
				}
				num = (short)777912320;
				if (num != 0)
				{
				}
				return false;
			}
			return this.b.ContainsKey(A_0.Key);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00047518 File Offset: 0x00045718
		internal bool a(int A_0)
		{
			short num = (short)1346437121;
			if (num != 0)
			{
			}
			num = (short)1316093952;
			short num2 = num;
			num = (short)1787760322;
			short num3 = num;
			num = (short)1758006978;
			switch (num3 == num)
			{
			}
			num = (short)930938880;
			if (num != 0)
			{
			}
			return this.b.ContainsKey(A_0);
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x000475CC File Offset: 0x000457CC
		internal int Count
		{
			get
			{
				short num = (short)25801964;
				short num2 = num;
				num = (short)1402582252;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1726283776;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1653145601;
				if (num != 0)
				{
				}
				num = (short)1432879104;
				if (num != 0)
				{
				}
				return this.b.Count;
			}
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x00047680 File Offset: 0x00045880
		internal bool b(global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange A_0)
		{
			int a_ = 14;
			short num = (short)239206402;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (!this.b.Remove(A_0.Key))
					{
						num = (short)1249902595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14F;
				case 1:
				{
					num = (short)66657981;
					short num3 = num;
					num = (short)1869422269;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1F;
					default:
						goto IL_B6;
					}
					break;
				}
				case 2:
					goto IL_1F;
				case 3:
					return false;
				}
				goto IL_3F;
				IL_1F:
				switch (0)
				{
				case 0:
					IL_3F:
					num = (short)18743297;
					if (num != 0)
					{
					}
					if (A_0 == null)
					{
						num = (short)1960116225;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1891434496;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_B6:
			num = (short)1565655040;
			if (num != 0)
			{
			}
			num = (short)1955332096;
			short num4 = num;
			throw new global::System.ArgumentNullException(global::Motorola.Acp.PackUnpack.Ish.Collections.StructureLayoutCollection.c("첤펦첨욪", a_));
			IL_14F:
			A_0.Parent = this;
			return true;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x000477E4 File Offset: 0x000459E4
		internal bool b(int A_0)
		{
			if (!this.b.ContainsKey(A_0))
			{
				short num;
				for (;;)
				{
					num = (short)1195835392;
					short num2 = num;
					num = (short)1933707095;
					short num3 = num;
					num = (short)353830743;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_72;
					}
				}
				IL_72:
				num = (short)2018574336;
				if (num != 0)
				{
				}
				num = (short)298647553;
				if (num != 0)
				{
				}
				return false;
			}
			this.b[A_0].Parent = null;
			this.b.Remove(A_0);
			return true;
		}

		// Token: 0x170000EB RID: 235
		internal global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange this[int A_0]
		{
			get
			{
				short num = (short)176059346;
				short num2 = num;
				num = (short)976712658;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1819213824;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1501429760;
				if (num != 0)
				{
				}
				num = (short)696057857;
				if (num != 0)
				{
				}
				return this.b[A_0];
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x00047978 File Offset: 0x00045B78
		// (set) Token: 0x060003C6 RID: 966 RVA: 0x00047A28 File Offset: 0x00045C28
		internal global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange Parent
		{
			get
			{
				short num = (short)70175647;
				short num2 = num;
				num = (short)811453343;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1168769024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1154154497;
				if (num != 0)
				{
				}
				num = (short)794951680;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)1814766732;
				short num2 = num;
				num = (short)1650140300;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1108344832;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)348323840;
				if (num != 0)
				{
				}
				num = (short)790102017;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00047ADC File Offset: 0x00045CDC
		public global::System.Collections.Generic.IEnumerator<global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> GetEnumerator()
		{
			short num = (short)1925747789;
			short num2 = num;
			num = (short)1648071757;
			switch (num2 == num)
			{
			default:
			{
				num = (short)591790080;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)323747841;
			if (num != 0)
			{
			}
			num = (short)77201408;
			if (num != 0)
			{
			}
			global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange.a a = new global::Motorola.Acp.PackUnpack.Ish.DataExchange.RecsetExchange.a(0);
			a.c = this;
			return a;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00047B94 File Offset: 0x00045D94
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			short num = (short)821922459;
			short num2 = num;
			num = (short)1543801499;
			switch (num2 == num)
			{
			default:
			{
				num = (short)87752704;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1542455297;
			if (num != 0)
			{
			}
			num = (short)649265152;
			if (num != 0)
			{
			}
			return this.GetEnumerator();
		}

		// Token: 0x04000161 RID: 353
		private int a;

		// Token: 0x04000162 RID: 354
		private global::System.Collections.Generic.Dictionary<int, global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange> b;

		// Token: 0x04000163 RID: 355
		private global::Motorola.Acp.PackUnpack.Ish.DataExchange.SectionExchange c;
	}
}
