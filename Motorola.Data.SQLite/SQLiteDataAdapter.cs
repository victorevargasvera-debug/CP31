using System;
using System.Data;
using System.Data.SQLite;
using System.Runtime.CompilerServices;

namespace Motorola.Data.SQLite
{
	// Token: 0x0200001B RID: 27
	public sealed class SQLiteDataAdapter : global::System.IDisposable, global::System.Data.IDbDataAdapter, global::System.Data.IDataAdapter
	{
		// Token: 0x060000A2 RID: 162 RVA: 0x000084A8 File Offset: 0x000066A8
		public static implicit operator global::System.Data.SQLite.SQLiteDataAdapter(global::Motorola.Data.SQLite.SQLiteDataAdapter parameter)
		{
			global::System.Data.SQLite.SQLiteDataAdapter result;
			short num;
			for (;;)
			{
				result = parameter.a;
				num = (short)836940627;
				short num2 = num;
				num = (short)691712851;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_3F;
				}
			}
			IL_3F:
			num = (short)651034625;
			if (num != 0)
			{
			}
			num = (short)1379598336;
			short num3 = num;
			num = (short)1052377088;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000855C File Offset: 0x0000675C
		public static implicit operator global::Motorola.Data.SQLite.SQLiteDataAdapter(global::System.Data.SQLite.SQLiteDataAdapter parameter)
		{
			global::Motorola.Data.SQLite.SQLiteDataAdapter result;
			short num;
			for (;;)
			{
				result = new global::Motorola.Data.SQLite.SQLiteDataAdapter
				{
					a = parameter
				};
				num = (short)129951620;
				short num2 = num;
				num = (short)1716971396;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_44;
				}
			}
			IL_44:
			num = (short)1251278849;
			if (num != 0)
			{
			}
			num = (short)1544159232;
			short num3 = num;
			num = (short)1515061248;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00008614 File Offset: 0x00006814
		static SQLiteDataAdapter()
		{
			short num = (short)50133794;
			short num2 = num;
			num = (short)1986394914;
			switch (num2 == num)
			{
			}
			num = (short)1806893056;
			if (num != 0)
			{
			}
			num = (short)880082944;
			short num3 = num;
			num = (short)1149304833;
			if (num != 0)
			{
			}
			global::Motorola.Data.SQLite.SQLiteDllLoader.c();
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000086C4 File Offset: 0x000068C4
		public SQLiteDataAdapter()
		{
			global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.SQLite.SQLiteDataAdapter>(new global::System.Func<global::System.Data.SQLite.SQLiteDataAdapter>(this.n));
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000086EC File Offset: 0x000068EC
		public SQLiteDataAdapter(global::Motorola.Data.SQLite.SQLiteCommand cmd)
		{
			global::Motorola.Data.SQLite.SQLiteDataAdapter.a a = new global::Motorola.Data.SQLite.SQLiteDataAdapter.a();
			a.b = cmd;
			base..ctor();
			a.a = this;
			global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.SQLite.SQLiteDataAdapter>(new global::System.Func<global::System.Data.SQLite.SQLiteDataAdapter>(a.c));
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00008728 File Offset: 0x00006928
		public SQLiteDataAdapter(string commandText, global::Motorola.Data.SQLite.SQLiteConnection connection)
		{
			global::Motorola.Data.SQLite.SQLiteDataAdapter.b b = new global::Motorola.Data.SQLite.SQLiteDataAdapter.b();
			b.b = commandText;
			b.c = connection;
			base..ctor();
			b.a = this;
			global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.SQLite.SQLiteDataAdapter>(new global::System.Func<global::System.Data.SQLite.SQLiteDataAdapter>(b.d));
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000876C File Offset: 0x0000696C
		public SQLiteDataAdapter(string commandText, string connectionString)
		{
			global::Motorola.Data.SQLite.SQLiteDataAdapter.c c = new global::Motorola.Data.SQLite.SQLiteDataAdapter.c();
			c.b = commandText;
			c.c = connectionString;
			base..ctor();
			c.a = this;
			global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.SQLite.SQLiteDataAdapter>(new global::System.Func<global::System.Data.SQLite.SQLiteDataAdapter>(c.d));
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000087B0 File Offset: 0x000069B0
		public SQLiteDataAdapter(string commandText, string connectionString, bool parseViaFramework)
		{
			global::Motorola.Data.SQLite.SQLiteDataAdapter.d d = new global::Motorola.Data.SQLite.SQLiteDataAdapter.d();
			d.b = commandText;
			d.c = connectionString;
			d.d = parseViaFramework;
			base..ctor();
			d.a = this;
			global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.SQLite.SQLiteDataAdapter>(new global::System.Func<global::System.Data.SQLite.SQLiteDataAdapter>(d.e));
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000087FC File Offset: 0x000069FC
		public int Fill(global::System.Data.DataTable dataTable)
		{
			int result;
			short num;
			for (;;)
			{
				global::Motorola.Data.SQLite.SQLiteDataAdapter.e e = new global::Motorola.Data.SQLite.SQLiteDataAdapter.e();
				e.a = this;
				e.b = dataTable;
				result = global::Motorola.Data.SQLite.SQLiteDllLoader.a<int>(new global::System.Func<int>(e.c));
				num = (short)798055903;
				short num2 = num;
				num = (short)980770271;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_5E;
				}
			}
			IL_5E:
			num = (short)1286012929;
			if (num != 0)
			{
			}
			num = (short)1560477696;
			short num3 = num;
			num = (short)1071972352;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000088D4 File Offset: 0x00006AD4
		public void Dispose()
		{
			short num = (short)932528599;
			short num2 = num;
			num = (short)604586455;
			switch (num2 == num)
			{
			}
			num = (short)1264320512;
			if (num != 0)
			{
			}
			num = (short)1636564992;
			short num3 = num;
			num = (short)125829121;
			if (num != 0)
			{
			}
			global::Motorola.Data.SQLite.SQLiteDllLoader.a(new global::System.Action(this.m));
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00008998 File Offset: 0x00006B98
		public global::System.Data.DataTable[] FillSchema(global::System.Data.DataSet dataSet, global::System.Data.SchemaType schemaType)
		{
			global::System.Data.DataTable[] result;
			short num;
			for (;;)
			{
				global::Motorola.Data.SQLite.SQLiteDataAdapter.f f = new global::Motorola.Data.SQLite.SQLiteDataAdapter.f();
				f.a = this;
				f.b = dataSet;
				f.c = schemaType;
				result = global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.DataTable[]>(new global::System.Func<global::System.Data.DataTable[]>(f.d));
				num = (short)542251424;
				short num2 = num;
				num = (short)1010047392;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_66;
				}
			}
			IL_66:
			num = (short)1765867521;
			if (num != 0)
			{
			}
			num = (short)1792278528;
			short num3 = num;
			num = (short)484835328;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00008A78 File Offset: 0x00006C78
		public int Fill(global::System.Data.DataSet dataSet)
		{
			short num;
			int result;
			for (;;)
			{
				num = (short)744488961;
				if (num != 0)
				{
				}
				global::Motorola.Data.SQLite.SQLiteDataAdapter.g g = new global::Motorola.Data.SQLite.SQLiteDataAdapter.g();
				g.a = this;
				g.b = dataSet;
				result = global::Motorola.Data.SQLite.SQLiteDllLoader.a<int>(new global::System.Func<int>(g.c));
				num = (short)1831082909;
				short num2 = num;
				num = (short)1502026653;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					goto IL_AF;
				}
				break;
			}
			num = (short)640942080;
			short num3 = num;
			IL_AF:
			num = (short)2027880448;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00008B4C File Offset: 0x00006D4C
		public global::System.Data.IDataParameter[] GetFillParameters()
		{
			global::System.Data.IDataParameter[] result;
			short num;
			for (;;)
			{
				result = global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.IDataParameter[]>(new global::System.Func<global::System.Data.IDataParameter[]>(this.l));
				num = (short)339738625;
				if (num != 0)
				{
				}
				num = (short)495604464;
				short num2 = num;
				num = (short)1849971440;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					goto IL_9D;
				}
				break;
			}
			num = (short)2129854464;
			short num3 = num;
			IL_9D:
			num = (short)363986944;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00008C10 File Offset: 0x00006E10
		public int Update(global::System.Data.DataSet dataSet)
		{
			int result;
			short num;
			for (;;)
			{
				global::Motorola.Data.SQLite.SQLiteDataAdapter.h h = new global::Motorola.Data.SQLite.SQLiteDataAdapter.h();
				h.a = this;
				h.b = dataSet;
				result = global::Motorola.Data.SQLite.SQLiteDllLoader.a<int>(new global::System.Func<int>(h.c));
				num = (short)1512261007;
				short num2 = num;
				num = (short)1207518607;
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
			num = (short)1633353728;
			short num3 = num;
			num = (short)1174011904;
			if (num != 0)
			{
			}
			num = (short)152764417;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00008CE4 File Offset: 0x00006EE4
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x00008DA4 File Offset: 0x00006FA4
		public global::Motorola.Data.SQLite.SQLiteCommand SelectCommand
		{
			get
			{
				short num = (short)273881548;
				short num2 = num;
				num = (short)350558668;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1715601408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)33030145;
				if (num != 0)
				{
				}
				num = (short)2136408064;
				if (num != 0)
				{
				}
				return global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.SQLite.SQLiteCommand>(new global::System.Func<global::System.Data.SQLite.SQLiteCommand>(this.k));
			}
			set
			{
				short num = (short)225260233;
				short num2 = num;
				num = (short)1128936137;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1170604032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1380909057;
				if (num != 0)
				{
				}
				num = (short)1750335488;
				if (num != 0)
				{
				}
				global::Motorola.Data.SQLite.SQLiteDataAdapter.i i = new global::Motorola.Data.SQLite.SQLiteDataAdapter.i();
				i.a = this;
				i.b = value;
				global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.SQLite.SQLiteCommand>(new global::System.Func<global::System.Data.SQLite.SQLiteCommand>(i.c));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00008E74 File Offset: 0x00007074
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x00008F34 File Offset: 0x00007134
		public global::Motorola.Data.SQLite.SQLiteCommand InsertCommand
		{
			get
			{
				short num = (short)71446518;
				short num2 = num;
				num = (short)862990326;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1432813568;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1371078657;
				if (num != 0)
				{
				}
				num = (short)2095054848;
				if (num != 0)
				{
				}
				return global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.SQLite.SQLiteCommand>(new global::System.Func<global::System.Data.SQLite.SQLiteCommand>(this.j));
			}
			set
			{
				short num = (short)1183508796;
				short num2 = num;
				num = (short)973728060;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2134507520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)112328704;
				if (num != 0)
				{
				}
				num = (short)1367277569;
				if (num != 0)
				{
				}
				global::Motorola.Data.SQLite.SQLiteDataAdapter.j j = new global::Motorola.Data.SQLite.SQLiteDataAdapter.j();
				j.a = this;
				j.b = value;
				global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.SQLite.SQLiteCommand>(new global::System.Func<global::System.Data.SQLite.SQLiteCommand>(j.c));
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00009004 File Offset: 0x00007204
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x000090C4 File Offset: 0x000072C4
		public global::Motorola.Data.SQLite.SQLiteCommand UpdateCommand
		{
			get
			{
				short num = (short)668860417;
				if (num != 0)
				{
				}
				num = (short)1044578304;
				short num2 = num;
				num = (short)834576872;
				short num3 = num;
				num = (short)615621096;
				switch (num3 == num)
				{
				}
				num = (short)1271595008;
				if (num != 0)
				{
				}
				return global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.SQLite.SQLiteCommand>(new global::System.Func<global::System.Data.SQLite.SQLiteCommand>(this.i));
			}
			set
			{
				short num = (short)792840846;
				short num2 = num;
				num = (short)451660430;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1040580608;
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
				num = (short)27328512;
				if (num != 0)
				{
				}
				global::Motorola.Data.SQLite.SQLiteDataAdapter.k k = new global::Motorola.Data.SQLite.SQLiteDataAdapter.k();
				k.a = this;
				k.b = value;
				global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.SQLite.SQLiteCommand>(new global::System.Func<global::System.Data.SQLite.SQLiteCommand>(k.c));
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x00009194 File Offset: 0x00007394
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x00009258 File Offset: 0x00007458
		public global::Motorola.Data.SQLite.SQLiteCommand DeleteCommand
		{
			get
			{
				short num = (short)1505656345;
				short num2 = num;
				num = (short)2020638233;
				switch (num2 == num)
				{
				default:
				{
					num = (short)955514880;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1379074049;
				if (num != 0)
				{
				}
				num = (short)859570176;
				if (num != 0)
				{
				}
				return global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.SQLite.SQLiteCommand>(new global::System.Func<global::System.Data.SQLite.SQLiteCommand>(this.h));
			}
			set
			{
				short num = (short)1757553028;
				short num2 = num;
				num = (short)64889220;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1010892800;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1713635328;
				if (num != 0)
				{
				}
				num = (short)441188353;
				if (num != 0)
				{
				}
				global::Motorola.Data.SQLite.SQLiteDataAdapter.l l = new global::Motorola.Data.SQLite.SQLiteDataAdapter.l();
				l.a = this;
				l.b = value;
				global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.SQLite.SQLiteCommand>(new global::System.Func<global::System.Data.SQLite.SQLiteCommand>(l.c));
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00009328 File Offset: 0x00007528
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x000093E4 File Offset: 0x000075E4
		global::System.Data.IDbCommand global::System.Data.IDbDataAdapter.SelectCommand
		{
			get
			{
				short num = (short)1197289726;
				short num2 = num;
				num = (short)1387737342;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2122055680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)160956417;
				if (num != 0)
				{
				}
				num = (short)1146683392;
				if (num != 0)
				{
				}
				return global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.IDbCommand>(new global::System.Func<global::System.Data.IDbCommand>(this.g));
			}
			set
			{
				short num = (short)1633954025;
				short num2 = num;
				num = (short)297150697;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1912340480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)160235520;
				if (num != 0)
				{
				}
				num = (short)156631041;
				if (num != 0)
				{
				}
				global::Motorola.Data.SQLite.SQLiteDataAdapter.m m = new global::Motorola.Data.SQLite.SQLiteDataAdapter.m();
				m.a = this;
				m.b = value;
				global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.IDbCommand>(new global::System.Func<global::System.Data.IDbCommand>(m.c));
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000BA RID: 186 RVA: 0x000094B4 File Offset: 0x000076B4
		// (set) Token: 0x060000BB RID: 187 RVA: 0x00009570 File Offset: 0x00007770
		global::System.Data.IDbCommand global::System.Data.IDbDataAdapter.InsertCommand
		{
			get
			{
				short num = (short)1000388716;
				short num2 = num;
				num = (short)475969644;
				switch (num2 == num)
				{
				default:
				{
					num = (short)393936896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)523108353;
				if (num != 0)
				{
				}
				num = (short)43646976;
				if (num != 0)
				{
				}
				return global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.IDbCommand>(new global::System.Func<global::System.Data.IDbCommand>(this.f));
			}
			set
			{
				short num = (short)419389857;
				short num2 = num;
				num = (short)1748197793;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1666187264;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2044723201;
				if (num != 0)
				{
				}
				num = (short)444530688;
				if (num != 0)
				{
				}
				global::Motorola.Data.SQLite.SQLiteDataAdapter.n n = new global::Motorola.Data.SQLite.SQLiteDataAdapter.n();
				n.a = this;
				n.b = value;
				global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.IDbCommand>(new global::System.Func<global::System.Data.IDbCommand>(n.c));
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00009640 File Offset: 0x00007840
		// (set) Token: 0x060000BD RID: 189 RVA: 0x000096FC File Offset: 0x000078FC
		global::System.Data.IDbCommand global::System.Data.IDbDataAdapter.UpdateCommand
		{
			get
			{
				short num = (short)2013915734;
				short num2 = num;
				num = (short)1020717654;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1777205248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)104988673;
				if (num != 0)
				{
				}
				num = (short)1645346816;
				if (num != 0)
				{
				}
				return global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.IDbCommand>(new global::System.Func<global::System.Data.IDbCommand>(this.e));
			}
			set
			{
				short num = (short)821219754;
				short num2 = num;
				num = (short)1466356138;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1957036032;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1508311041;
				if (num != 0)
				{
				}
				num = (short)913309696;
				if (num != 0)
				{
				}
				global::Motorola.Data.SQLite.SQLiteDataAdapter.o o = new global::Motorola.Data.SQLite.SQLiteDataAdapter.o();
				o.a = this;
				o.b = value;
				global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.IDbCommand>(new global::System.Func<global::System.Data.IDbCommand>(o.c));
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000BE RID: 190 RVA: 0x000097CC File Offset: 0x000079CC
		// (set) Token: 0x060000BF RID: 191 RVA: 0x00009884 File Offset: 0x00007A84
		global::System.Data.IDbCommand global::System.Data.IDbDataAdapter.DeleteCommand
		{
			get
			{
				short num = (short)1721682676;
				short num2 = num;
				num = (short)1474874100;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1160118272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1278738433;
				if (num != 0)
				{
				}
				num = (short)1218707456;
				if (num != 0)
				{
				}
				return global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.IDbCommand>(new global::System.Func<global::System.Data.IDbCommand>(this.d));
			}
			set
			{
				short num = (short)742568517;
				short num2 = num;
				num = (short)313307717;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1928986624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)951189505;
				if (num != 0)
				{
				}
				num = (short)1568473088;
				if (num != 0)
				{
				}
				global::Motorola.Data.SQLite.SQLiteDataAdapter.p p = new global::Motorola.Data.SQLite.SQLiteDataAdapter.p();
				p.a = this;
				p.b = value;
				global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.IDbCommand>(new global::System.Func<global::System.Data.IDbCommand>(p.c));
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x00009954 File Offset: 0x00007B54
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x00009A10 File Offset: 0x00007C10
		public global::System.Data.MissingMappingAction MissingMappingAction
		{
			get
			{
				short num = (short)1495804741;
				short num2 = num;
				num = (short)1893935941;
				switch (num2 == num)
				{
				default:
				{
					num = (short)439025664;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1479737344;
				if (num != 0)
				{
				}
				num = (short)1309868033;
				if (num != 0)
				{
				}
				return global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.MissingMappingAction>(new global::System.Func<global::System.Data.MissingMappingAction>(this.c));
			}
			set
			{
				short num = (short)841969206;
				short num2 = num;
				num = (short)1902210614;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1085931520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)660602881;
				if (num != 0)
				{
				}
				num = (short)436273152;
				if (num != 0)
				{
				}
				global::Motorola.Data.SQLite.SQLiteDataAdapter.q q = new global::Motorola.Data.SQLite.SQLiteDataAdapter.q();
				q.a = this;
				q.b = value;
				global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.MissingMappingAction>(new global::System.Func<global::System.Data.MissingMappingAction>(q.c));
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x00009AE4 File Offset: 0x00007CE4
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x00009BA0 File Offset: 0x00007DA0
		public global::System.Data.MissingSchemaAction MissingSchemaAction
		{
			get
			{
				short num = (short)670583705;
				short num2 = num;
				num = (short)1149717401;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2020737024;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1596325889;
				if (num != 0)
				{
				}
				num = (short)1301938176;
				if (num != 0)
				{
				}
				return global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.MissingSchemaAction>(new global::System.Func<global::System.Data.MissingSchemaAction>(this.b));
			}
			set
			{
				short num = (short)372255539;
				short num2 = num;
				num = (short)685452083;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1180368896;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)158203905;
				if (num != 0)
				{
				}
				num = (short)39256064;
				if (num != 0)
				{
				}
				global::Motorola.Data.SQLite.SQLiteDataAdapter.r r = new global::Motorola.Data.SQLite.SQLiteDataAdapter.r();
				r.a = this;
				r.b = value;
				global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.MissingSchemaAction>(new global::System.Func<global::System.Data.MissingSchemaAction>(r.c));
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x00009C74 File Offset: 0x00007E74
		public global::System.Data.ITableMappingCollection TableMappings
		{
			get
			{
				short num = (short)180630194;
				short num2 = num;
				num = (short)648819378;
				switch (num2 == num)
				{
				default:
				{
					num = (short)498794496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)452329473;
				if (num != 0)
				{
				}
				num = (short)72155136;
				if (num != 0)
				{
				}
				return global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.ITableMappingCollection>(new global::System.Func<global::System.Data.ITableMappingCollection>(this.a));
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00009D2C File Offset: 0x00007F2C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Data.SQLite.SQLiteDataAdapter n()
		{
			short num = (short)460642389;
			short num2 = num;
			num = (short)1840961621;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1682702336;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)94044161;
			if (num != 0)
			{
			}
			num = (short)958857216;
			if (num != 0)
			{
			}
			return this.a = new global::System.Data.SQLite.SQLiteDataAdapter();
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00009DE4 File Offset: 0x00007FE4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void m()
		{
			short num = (short)1800433963;
			short num2 = num;
			num = (short)1608610091;
			switch (num2 == num)
			{
			default:
			{
				num = (short)333971456;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1812332544;
			if (num != 0)
			{
			}
			num = (short)674234369;
			if (num != 0)
			{
			}
			this.a.Dispose();
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00009E9C File Offset: 0x0000809C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Data.IDataParameter[] l()
		{
			short num = (short)2033995029;
			short num2 = num;
			num = (short)1768049941;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1709703168;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)91029505;
			if (num != 0)
			{
			}
			num = (short)48431104;
			if (num != 0)
			{
			}
			return this.a.GetFillParameters();
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00009F50 File Offset: 0x00008150
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Data.SQLite.SQLiteCommand k()
		{
			short num = (short)1385631491;
			short num2 = num;
			num = (short)1498943235;
			switch (num2 == num)
			{
			default:
			{
				num = (short)63766528;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1775304704;
			if (num != 0)
			{
			}
			num = (short)46989313;
			if (num != 0)
			{
			}
			return this.a.SelectCommand;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000A004 File Offset: 0x00008204
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Data.SQLite.SQLiteCommand j()
		{
			short num = (short)1742999952;
			short num2 = num;
			num = (short)802099600;
			switch (num2 == num)
			{
			default:
			{
				num = (short)614006784;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)81657857;
			if (num != 0)
			{
			}
			num = (short)428212224;
			if (num != 0)
			{
			}
			return this.a.InsertCommand;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000A0B8 File Offset: 0x000082B8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Data.SQLite.SQLiteCommand i()
		{
			short num = (short)1255276545;
			if (num != 0)
			{
			}
			num = (short)2012610560;
			short num2 = num;
			num = (short)1704997332;
			short num3 = num;
			num = (short)2093756884;
			switch (num3 == num)
			{
			}
			num = (short)1852440576;
			if (num != 0)
			{
			}
			return this.a.UpdateCommand;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000A170 File Offset: 0x00008370
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Data.SQLite.SQLiteCommand h()
		{
			short num = (short)1666362031;
			short num2 = num;
			num = (short)183085743;
			switch (num2 == num)
			{
			default:
			{
				num = (short)283508736;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2065039361;
			if (num != 0)
			{
			}
			num = (short)1766850560;
			if (num != 0)
			{
			}
			return this.a.DeleteCommand;
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000A224 File Offset: 0x00008424
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Data.IDbCommand g()
		{
			short num = (short)356923111;
			short num2 = num;
			num = (short)904869607;
			switch (num2 == num)
			{
			default:
			{
				num = (short)840957952;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)959184896;
			if (num != 0)
			{
			}
			num = (short)1406205953;
			if (num != 0)
			{
			}
			return this.a.SelectCommand;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000A2D8 File Offset: 0x000084D8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Data.IDbCommand f()
		{
			short num = (short)1294692951;
			short num2 = num;
			num = (short)589066839;
			switch (num2 == num)
			{
			default:
			{
				num = (short)903282688;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)223870976;
			if (num != 0)
			{
			}
			num = (short)2143617025;
			if (num != 0)
			{
			}
			return this.a.InsertCommand;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000A38C File Offset: 0x0000858C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Data.IDbCommand e()
		{
			short num = (short)1399226449;
			short num2 = num;
			num = (short)594313297;
			switch (num2 == num)
			{
			default:
			{
				num = (short)138936320;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)98500608;
			if (num != 0)
			{
			}
			num = (short)1274216449;
			if (num != 0)
			{
			}
			return this.a.UpdateCommand;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000A440 File Offset: 0x00008640
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Data.IDbCommand d()
		{
			short num = (short)1160404106;
			short num2 = num;
			num = (short)271867018;
			switch (num2 == num)
			{
			default:
			{
				num = (short)847249408;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)995491841;
			if (num != 0)
			{
			}
			num = (short)732233728;
			if (num != 0)
			{
			}
			return this.a.DeleteCommand;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000A4F8 File Offset: 0x000086F8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Data.MissingMappingAction c()
		{
			short num = (short)1043280337;
			short num2 = num;
			num = (short)724120017;
			switch (num2 == num)
			{
			default:
			{
				num = (short)159449088;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1040973825;
			if (num != 0)
			{
			}
			num = (short)1203568640;
			if (num != 0)
			{
			}
			return this.a.MissingMappingAction;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000A5AC File Offset: 0x000087AC
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Data.MissingSchemaAction b()
		{
			short num = (short)314882247;
			short num2 = num;
			num = (short)806271175;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1789001728;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1139998721;
			if (num != 0)
			{
			}
			num = (short)1775960064;
			if (num != 0)
			{
			}
			return this.a.MissingSchemaAction;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000A660 File Offset: 0x00008860
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Data.ITableMappingCollection a()
		{
			short num = (short)2131670991;
			short num2 = num;
			num = (short)2079897551;
			switch (num2 == num)
			{
			default:
			{
				num = (short)470614016;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)123863041;
			if (num != 0)
			{
			}
			num = (short)597229568;
			if (num != 0)
			{
			}
			return this.a.TableMappings;
		}

		// Token: 0x04000030 RID: 48
		internal global::System.Data.SQLite.SQLiteDataAdapter a;

		// Token: 0x0200001C RID: 28
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x060000D4 RID: 212 RVA: 0x0000A72C File Offset: 0x0000892C
			internal global::System.Data.SQLite.SQLiteDataAdapter c()
			{
				short num = (short)1987516095;
				short num2 = num;
				num = (short)1222973119;
				switch (num2 == num)
				{
				default:
				{
					num = (short)241172480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2031288321;
				if (num != 0)
				{
				}
				num = (short)879493120;
				if (num != 0)
				{
				}
				return this.a.a = new global::System.Data.SQLite.SQLiteDataAdapter(this.b);
			}

			// Token: 0x04000031 RID: 49
			public global::Motorola.Data.SQLite.SQLiteDataAdapter a;

			// Token: 0x04000032 RID: 50
			public global::Motorola.Data.SQLite.SQLiteCommand b;
		}

		// Token: 0x0200001D RID: 29
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class b
		{
			// Token: 0x060000D6 RID: 214 RVA: 0x0000A808 File Offset: 0x00008A08
			internal global::System.Data.SQLite.SQLiteDataAdapter d()
			{
				short num = (short)773082559;
				short num2 = num;
				num = (short)1618759103;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2123497472;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)753926144;
				if (num != 0)
				{
				}
				num = (short)1309999105;
				if (num != 0)
				{
				}
				return this.a.a = new global::System.Data.SQLite.SQLiteDataAdapter(this.b, this.c);
			}

			// Token: 0x04000033 RID: 51
			public global::Motorola.Data.SQLite.SQLiteDataAdapter a;

			// Token: 0x04000034 RID: 52
			public string b;

			// Token: 0x04000035 RID: 53
			public global::Motorola.Data.SQLite.SQLiteConnection c;
		}

		// Token: 0x0200001E RID: 30
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class c
		{
			// Token: 0x060000D8 RID: 216 RVA: 0x0000A8E8 File Offset: 0x00008AE8
			internal global::System.Data.SQLite.SQLiteDataAdapter d()
			{
				short num = (short)1116730893;
				short num2 = num;
				num = (short)831845901;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1285685248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)43646977;
				if (num != 0)
				{
				}
				num = (short)1294729216;
				if (num != 0)
				{
				}
				return this.a.a = new global::System.Data.SQLite.SQLiteDataAdapter(this.b, this.c);
			}

			// Token: 0x04000036 RID: 54
			public global::Motorola.Data.SQLite.SQLiteDataAdapter a;

			// Token: 0x04000037 RID: 55
			public string b;

			// Token: 0x04000038 RID: 56
			public string c;
		}

		// Token: 0x0200001F RID: 31
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class d
		{
			// Token: 0x060000DA RID: 218 RVA: 0x0000A9C8 File Offset: 0x00008BC8
			internal global::System.Data.SQLite.SQLiteDataAdapter e()
			{
				short num = (short)2041261163;
				short num2 = num;
				num = (short)395652203;
				switch (num2 == num)
				{
				default:
				{
					num = (short)318963712;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1686044672;
				if (num != 0)
				{
				}
				num = (short)1312358401;
				if (num != 0)
				{
				}
				return this.a.a = new global::System.Data.SQLite.SQLiteDataAdapter(this.b, this.c, this.d);
			}

			// Token: 0x04000039 RID: 57
			public global::Motorola.Data.SQLite.SQLiteDataAdapter a;

			// Token: 0x0400003A RID: 58
			public string b;

			// Token: 0x0400003B RID: 59
			public string c;

			// Token: 0x0400003C RID: 60
			public bool d;
		}

		// Token: 0x02000020 RID: 32
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class e
		{
			// Token: 0x060000DC RID: 220 RVA: 0x0000AAA8 File Offset: 0x00008CA8
			internal int c()
			{
				short num = (short)1099261402;
				short num2 = num;
				num = (short)1642096090;
				switch (num2 == num)
				{
				default:
				{
					num = (short)58130432;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1666842625;
				if (num != 0)
				{
				}
				num = (short)1093599232;
				if (num != 0)
				{
				}
				return this.a.a.Fill(this.b);
			}

			// Token: 0x0400003D RID: 61
			public global::Motorola.Data.SQLite.SQLiteDataAdapter a;

			// Token: 0x0400003E RID: 62
			public global::System.Data.DataTable b;
		}

		// Token: 0x02000021 RID: 33
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class f
		{
			// Token: 0x060000DE RID: 222 RVA: 0x0000AB7C File Offset: 0x00008D7C
			internal global::System.Data.DataTable[] d()
			{
				short num = (short)706916955;
				short num2 = num;
				num = (short)1247326811;
				switch (num2 == num)
				{
				}
				num = (short)1943142400;
				short num3 = num;
				num = (short)1051131905;
				if (num != 0)
				{
				}
				num = (short)983826432;
				if (num != 0)
				{
				}
				return this.a.a.FillSchema(this.b, this.c);
			}

			// Token: 0x0400003F RID: 63
			public global::Motorola.Data.SQLite.SQLiteDataAdapter a;

			// Token: 0x04000040 RID: 64
			public global::System.Data.DataSet b;

			// Token: 0x04000041 RID: 65
			public global::System.Data.SchemaType c;
		}

		// Token: 0x02000022 RID: 34
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class g
		{
			// Token: 0x060000E0 RID: 224 RVA: 0x0000AC54 File Offset: 0x00008E54
			internal int c()
			{
				short num = (short)898796165;
				short num2 = num;
				num = (short)1303939717;
				switch (num2 == num)
				{
				}
				num = (short)1459814400;
				short num3 = num;
				num = (short)941096961;
				if (num != 0)
				{
				}
				num = (short)435159040;
				if (num != 0)
				{
				}
				return this.a.a.Fill(this.b);
			}

			// Token: 0x04000042 RID: 66
			public global::Motorola.Data.SQLite.SQLiteDataAdapter a;

			// Token: 0x04000043 RID: 67
			public global::System.Data.DataSet b;
		}

		// Token: 0x02000023 RID: 35
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class h
		{
			// Token: 0x060000E2 RID: 226 RVA: 0x0000AD24 File Offset: 0x00008F24
			internal int c()
			{
				short num = (short)1177700989;
				short num2 = num;
				num = (short)1530481277;
				switch (num2 == num)
				{
				}
				num = (short)1480851456;
				short num3 = num;
				num = (short)1163919360;
				if (num != 0)
				{
				}
				num = (short)1305935873;
				if (num != 0)
				{
				}
				return this.a.a.Update(this.b);
			}

			// Token: 0x04000044 RID: 68
			public global::Motorola.Data.SQLite.SQLiteDataAdapter a;

			// Token: 0x04000045 RID: 69
			public global::System.Data.DataSet b;
		}

		// Token: 0x02000024 RID: 36
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class i
		{
			// Token: 0x060000E4 RID: 228 RVA: 0x0000ADF8 File Offset: 0x00008FF8
			internal global::System.Data.SQLite.SQLiteCommand c()
			{
				short num = (short)529465345;
				if (num != 0)
				{
				}
				num = (short)14655183;
				short num2 = num;
				num = (short)1077124815;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1249771520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)875102208;
				if (num != 0)
				{
				}
				return this.a.a.SelectCommand = this.b;
			}

			// Token: 0x04000046 RID: 70
			public global::Motorola.Data.SQLite.SQLiteDataAdapter a;

			// Token: 0x04000047 RID: 71
			public global::Motorola.Data.SQLite.SQLiteCommand b;
		}

		// Token: 0x02000025 RID: 37
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class j
		{
			// Token: 0x060000E6 RID: 230 RVA: 0x0000AED4 File Offset: 0x000090D4
			internal global::System.Data.SQLite.SQLiteCommand c()
			{
				short num = (short)1525490715;
				short num2 = num;
				num = (short)1662854171;
				switch (num2 == num)
				{
				}
				num = (short)368443392;
				short num3 = num;
				num = (short)948240385;
				if (num != 0)
				{
				}
				num = (short)289144832;
				if (num != 0)
				{
				}
				return this.a.a.InsertCommand = this.b;
			}

			// Token: 0x04000048 RID: 72
			public global::Motorola.Data.SQLite.SQLiteDataAdapter a;

			// Token: 0x04000049 RID: 73
			public global::Motorola.Data.SQLite.SQLiteCommand b;
		}

		// Token: 0x02000026 RID: 38
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class k
		{
			// Token: 0x060000E8 RID: 232 RVA: 0x0000AFB0 File Offset: 0x000091B0
			internal global::System.Data.SQLite.SQLiteCommand c()
			{
				short num = (short)1102720621;
				short num2 = num;
				num = (short)319172205;
				switch (num2 == num)
				{
				}
				num = (short)1430781952;
				short num3 = num;
				num = (short)1259667456;
				if (num != 0)
				{
				}
				num = (short)841678849;
				if (num != 0)
				{
				}
				return this.a.a.UpdateCommand = this.b;
			}

			// Token: 0x0400004A RID: 74
			public global::Motorola.Data.SQLite.SQLiteDataAdapter a;

			// Token: 0x0400004B RID: 75
			public global::Motorola.Data.SQLite.SQLiteCommand b;
		}

		// Token: 0x02000027 RID: 39
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class l
		{
			// Token: 0x060000EA RID: 234 RVA: 0x0000B08C File Offset: 0x0000928C
			internal global::System.Data.SQLite.SQLiteCommand c()
			{
				short num = (short)1026148604;
				short num2 = num;
				num = (short)1421003004;
				switch (num2 == num)
				{
				}
				num = (short)1903296512;
				short num3 = num;
				num = (short)1949630464;
				if (num != 0)
				{
				}
				num = (short)162070529;
				if (num != 0)
				{
				}
				return this.a.a.DeleteCommand = this.b;
			}

			// Token: 0x0400004C RID: 76
			public global::Motorola.Data.SQLite.SQLiteDataAdapter a;

			// Token: 0x0400004D RID: 77
			public global::Motorola.Data.SQLite.SQLiteCommand b;
		}

		// Token: 0x02000028 RID: 40
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class m
		{
			// Token: 0x060000EC RID: 236 RVA: 0x0000B168 File Offset: 0x00009368
			internal global::System.Data.IDbCommand c()
			{
				short num = (short)1135089113;
				short num2 = num;
				num = (short)374150617;
				switch (num2 == num)
				{
				}
				num = (short)998309888;
				short num3 = num;
				num = (short)1959788545;
				if (num != 0)
				{
				}
				num = (short)1418002432;
				if (num != 0)
				{
				}
				return this.a.a.SelectCommand = this.b;
			}

			// Token: 0x0400004E RID: 78
			public global::Motorola.Data.SQLite.SQLiteDataAdapter a;

			// Token: 0x0400004F RID: 79
			public global::System.Data.IDbCommand b;
		}

		// Token: 0x02000029 RID: 41
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class n
		{
			// Token: 0x060000EE RID: 238 RVA: 0x0000B240 File Offset: 0x00009440
			internal global::System.Data.IDbCommand c()
			{
				short num = (short)1855139885;
				short num2 = num;
				num = (short)2093887533;
				switch (num2 == num)
				{
				}
				num = (short)755826688;
				short num3 = num;
				num = (short)158007297;
				if (num != 0)
				{
				}
				num = (short)1222049792;
				if (num != 0)
				{
				}
				return this.a.a.InsertCommand = this.b;
			}

			// Token: 0x04000050 RID: 80
			public global::Motorola.Data.SQLite.SQLiteDataAdapter a;

			// Token: 0x04000051 RID: 81
			public global::System.Data.IDbCommand b;
		}

		// Token: 0x0200002A RID: 42
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class o
		{
			// Token: 0x060000F0 RID: 240 RVA: 0x0000B318 File Offset: 0x00009518
			internal global::System.Data.IDbCommand c()
			{
				short num = (short)1475718042;
				short num2 = num;
				num = (short)946187162;
				switch (num2 == num)
				{
				}
				num = (short)125960192;
				short num3 = num;
				num = (short)1241907201;
				if (num != 0)
				{
				}
				num = (short)1442906112;
				if (num != 0)
				{
				}
				return this.a.a.UpdateCommand = this.b;
			}

			// Token: 0x04000052 RID: 82
			public global::Motorola.Data.SQLite.SQLiteDataAdapter a;

			// Token: 0x04000053 RID: 83
			public global::System.Data.IDbCommand b;
		}

		// Token: 0x0200002B RID: 43
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class p
		{
			// Token: 0x060000F2 RID: 242 RVA: 0x0000B3F0 File Offset: 0x000095F0
			internal global::System.Data.IDbCommand c()
			{
				short num = (short)1111097345;
				if (num != 0)
				{
				}
				num = (short)868095633;
				short num2 = num;
				num = (short)1419974289;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1658585088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1184169984;
				if (num != 0)
				{
				}
				return this.a.a.DeleteCommand = this.b;
			}

			// Token: 0x04000054 RID: 84
			public global::Motorola.Data.SQLite.SQLiteDataAdapter a;

			// Token: 0x04000055 RID: 85
			public global::System.Data.IDbCommand b;
		}

		// Token: 0x0200002C RID: 44
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class q
		{
			// Token: 0x060000F4 RID: 244 RVA: 0x0000B4C4 File Offset: 0x000096C4
			internal global::System.Data.MissingMappingAction c()
			{
				short num = (short)1663937386;
				short num2 = num;
				num = (short)1683073898;
				switch (num2 == num)
				{
				}
				num = (short)1954086912;
				short num3 = num;
				num = (short)1958019073;
				if (num != 0)
				{
				}
				num = (short)489816064;
				if (num != 0)
				{
				}
				return this.a.a.MissingMappingAction = this.b;
			}

			// Token: 0x04000056 RID: 86
			public global::Motorola.Data.SQLite.SQLiteDataAdapter a;

			// Token: 0x04000057 RID: 87
			public global::System.Data.MissingMappingAction b;
		}

		// Token: 0x0200002D RID: 45
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class r
		{
			// Token: 0x060000F6 RID: 246 RVA: 0x0000B598 File Offset: 0x00009798
			internal global::System.Data.MissingSchemaAction c()
			{
				short num = (short)1714278403;
				short num2 = num;
				num = (short)503042051;
				switch (num2 == num)
				{
				}
				num = (short)353370112;
				short num3 = num;
				num = (short)3866625;
				if (num != 0)
				{
				}
				num = (short)2038562816;
				if (num != 0)
				{
				}
				return this.a.a.MissingSchemaAction = this.b;
			}

			// Token: 0x04000058 RID: 88
			public global::Motorola.Data.SQLite.SQLiteDataAdapter a;

			// Token: 0x04000059 RID: 89
			public global::System.Data.MissingSchemaAction b;
		}
	}
}
