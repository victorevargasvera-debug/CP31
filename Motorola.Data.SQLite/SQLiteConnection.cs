using System;
using System.Data;
using System.Data.SQLite;
using System.Runtime.CompilerServices;

namespace Motorola.Data.SQLite
{
	// Token: 0x02000011 RID: 17
	public class SQLiteConnection : global::System.IDisposable, global::System.Data.IDbConnection
	{
		// Token: 0x0600004A RID: 74 RVA: 0x00004C18 File Offset: 0x00002E18
		public static implicit operator global::System.Data.SQLite.SQLiteConnection(global::Motorola.Data.SQLite.SQLiteConnection parameter)
		{
			short num = (short)1331274788;
			short num2 = num;
			num = (short)2039784484;
			global::System.Data.SQLite.SQLiteConnection result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)26148865;
				if (num != 0)
				{
				}
				num = (short)1794965504;
				if (num != 0)
				{
				}
				result = parameter.a;
				break;
			}
			num = (short)20643840;
			short num3 = num;
			return result;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00004CD0 File Offset: 0x00002ED0
		public static implicit operator global::Motorola.Data.SQLite.SQLiteConnection(global::System.Data.SQLite.SQLiteConnection parameter)
		{
			short num = (short)1529937921;
			if (num != 0)
			{
			}
			num = (short)1153152368;
			short num2 = num;
			num = (short)656323952;
			global::Motorola.Data.SQLite.SQLiteConnection result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)433324032;
				if (num != 0)
				{
				}
				result = new global::Motorola.Data.SQLite.SQLiteConnection
				{
					a = parameter
				};
				break;
			}
			num = (short)644677632;
			short num3 = num;
			return result;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00004D88 File Offset: 0x00002F88
		static SQLiteConnection()
		{
			short num = (short)1570897921;
			if (num != 0)
			{
			}
			num = (short)561128098;
			short num2 = num;
			num = (short)1933779618;
			switch (num2 == num)
			{
			}
			num = (short)1148256256;
			short num3 = num;
			num = (short)983695360;
			if (num != 0)
			{
			}
			global::Motorola.Data.SQLite.SQLiteDllLoader.c();
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00004E3C File Offset: 0x0000303C
		public SQLiteConnection()
		{
			global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.SQLite.SQLiteConnection>(new global::System.Func<global::System.Data.SQLite.SQLiteConnection>(this.k));
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00004E64 File Offset: 0x00003064
		public SQLiteConnection(string connectionString)
		{
			global::Motorola.Data.SQLite.SQLiteConnection.a a = new global::Motorola.Data.SQLite.SQLiteConnection.a();
			a.b = connectionString;
			base..ctor();
			a.a = this;
			global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.SQLite.SQLiteConnection>(new global::System.Func<global::System.Data.SQLite.SQLiteConnection>(a.c));
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00004EA0 File Offset: 0x000030A0
		public SQLiteConnection(global::Motorola.Data.SQLite.SQLiteConnection connection)
		{
			global::Motorola.Data.SQLite.SQLiteConnection.b b = new global::Motorola.Data.SQLite.SQLiteConnection.b();
			b.b = connection;
			base..ctor();
			b.a = this;
			global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.SQLite.SQLiteConnection>(new global::System.Func<global::System.Data.SQLite.SQLiteConnection>(b.c));
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00004EDC File Offset: 0x000030DC
		public SQLiteConnection(string connectionString, bool parseViaFramework)
		{
			global::Motorola.Data.SQLite.SQLiteConnection.c c = new global::Motorola.Data.SQLite.SQLiteConnection.c();
			c.b = connectionString;
			c.c = parseViaFramework;
			base..ctor();
			c.a = this;
			global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.SQLite.SQLiteConnection>(new global::System.Func<global::System.Data.SQLite.SQLiteConnection>(c.d));
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00004F20 File Offset: 0x00003120
		public global::Motorola.Data.SQLite.SQLiteCommand CreateCommand()
		{
			short num = (short)1337720981;
			short num2 = num;
			num = (short)1210515605;
			global::Motorola.Data.SQLite.SQLiteCommand result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)647364608;
				if (num != 0)
				{
				}
				num = (short)205586433;
				if (num != 0)
				{
				}
				result = global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.SQLite.SQLiteCommand>(new global::System.Func<global::System.Data.SQLite.SQLiteCommand>(this.j));
				break;
			}
			num = (short)596574208;
			short num3 = num;
			return result;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00004FE0 File Offset: 0x000031E0
		public global::System.Data.IDbTransaction BeginTransaction()
		{
			short num = (short)24309790;
			short num2 = num;
			num = (short)1627058206;
			global::System.Data.IDbTransaction result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1280573440;
				if (num != 0)
				{
				}
				num = (short)378601473;
				if (num != 0)
				{
				}
				result = global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.SQLite.SQLiteTransaction>(new global::System.Func<global::System.Data.SQLite.SQLiteTransaction>(this.i));
				break;
			}
			num = (short)867237888;
			short num3 = num;
			return result;
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000053 RID: 83 RVA: 0x000050A0 File Offset: 0x000032A0
		// (set) Token: 0x06000054 RID: 84 RVA: 0x0000515C File Offset: 0x0000335C
		public string ConnectionString
		{
			get
			{
				short num = (short)856948737;
				if (num != 0)
				{
				}
				num = (short)783355848;
				short num2 = num;
				num = (short)1511002056;
				switch (num2 == num)
				{
				}
				num = (short)45809664;
				short num3 = num;
				num = (short)1550123008;
				if (num != 0)
				{
				}
				return global::Motorola.Data.SQLite.SQLiteDllLoader.a<string>(new global::System.Func<string>(this.h));
			}
			set
			{
				short num = (short)2018390876;
				short num2 = num;
				num = (short)2007577436;
				switch (num2 == num)
				{
				}
				num = (short)1692663809;
				if (num != 0)
				{
				}
				num = (short)1505296384;
				short num3 = num;
				num = (short)1575223296;
				if (num != 0)
				{
				}
				global::Motorola.Data.SQLite.SQLiteConnection.d d = new global::Motorola.Data.SQLite.SQLiteConnection.d();
				d.a = this;
				d.b = value;
				global::Motorola.Data.SQLite.SQLiteDllLoader.a<string>(new global::System.Func<string>(d.c));
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000055 RID: 85 RVA: 0x0000522C File Offset: 0x0000342C
		public int ConnectionTimeout
		{
			get
			{
				short num = (short)1257054883;
				short num2 = num;
				num = (short)257172131;
				switch (num2 == num)
				{
				}
				num = (short)1395064832;
				if (num != 0)
				{
				}
				num = (short)1200553984;
				short num3 = num;
				num = (short)217055233;
				if (num != 0)
				{
				}
				return global::Motorola.Data.SQLite.SQLiteDllLoader.a<int>(new global::System.Func<int>(this.g));
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000056 RID: 86 RVA: 0x000052E4 File Offset: 0x000034E4
		public string Database
		{
			get
			{
				short num = (short)393363257;
				short num2 = num;
				num = (short)492060473;
				switch (num2 == num)
				{
				}
				num = (short)1512308736;
				if (num != 0)
				{
				}
				num = (short)1683095552;
				short num3 = num;
				num = (short)87818241;
				if (num != 0)
				{
				}
				return global::Motorola.Data.SQLite.SQLiteDllLoader.a<string>(new global::System.Func<string>(this.f));
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000057 RID: 87 RVA: 0x0000539C File Offset: 0x0000359C
		public global::System.Data.ConnectionState State
		{
			get
			{
				short num = (short)900642101;
				short num2 = num;
				num = (short)1960949045;
				switch (num2 == num)
				{
				}
				num = (short)1948385280;
				if (num != 0)
				{
				}
				num = (short)693501952;
				short num3 = num;
				num = (short)2098987009;
				if (num != 0)
				{
				}
				return global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.ConnectionState>(new global::System.Func<global::System.Data.ConnectionState>(this.e));
			}
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000545C File Offset: 0x0000365C
		public static void CreateFile(string databaseFileName)
		{
			short num = (short)1596249928;
			short num2 = num;
			num = (short)776787784;
			switch (num2 == num)
			{
			}
			num = (short)800456705;
			if (num != 0)
			{
			}
			num = (short)841416704;
			short num3 = num;
			num = (short)1365835776;
			if (num != 0)
			{
			}
			global::System.Data.SQLite.SQLiteConnection.CreateFile(databaseFileName);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000550C File Offset: 0x0000370C
		public void Open()
		{
			short num = (short)1412261785;
			short num2 = num;
			num = (short)1857775513;
			switch (num2 == num)
			{
			}
			num = (short)2052718593;
			if (num != 0)
			{
			}
			num = (short)1448607744;
			short num3 = num;
			num = (short)290848768;
			if (num != 0)
			{
			}
			global::Motorola.Data.SQLite.SQLiteDllLoader.a(new global::System.Action(this.d));
		}

		// Token: 0x0600005A RID: 90 RVA: 0x000055CC File Offset: 0x000037CC
		public void Close()
		{
			short num = (short)1798583584;
			short num2 = num;
			num = (short)898774304;
			switch (num2 == num)
			{
			}
			num = (short)519962624;
			if (num != 0)
			{
			}
			num = (short)1626931200;
			short num3 = num;
			num = (short)1619656705;
			if (num != 0)
			{
			}
			global::Motorola.Data.SQLite.SQLiteDllLoader.a(new global::System.Action(this.c));
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000568C File Offset: 0x0000388C
		public void Dispose()
		{
			short num = (short)845354064;
			short num2 = num;
			num = (short)826938448;
			switch (num2 == num)
			{
			}
			num = (short)1952055297;
			if (num != 0)
			{
			}
			num = (short)683933696;
			short num3 = num;
			num = (short)483786752;
			if (num != 0)
			{
			}
			global::Motorola.Data.SQLite.SQLiteDllLoader.a(new global::System.Action(this.b));
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000574C File Offset: 0x0000394C
		public global::System.Data.IDbTransaction BeginTransaction(global::System.Data.IsolationLevel il)
		{
			short num = (short)1158435936;
			short num2 = num;
			num = (short)1004640;
			global::System.Data.IDbTransaction result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1089208320;
				if (num != 0)
				{
				}
				num = (short)1149632513;
				if (num != 0)
				{
				}
				global::Motorola.Data.SQLite.SQLiteConnection.e e = new global::Motorola.Data.SQLite.SQLiteConnection.e();
				e.a = this;
				e.b = il;
				result = global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.IDbTransaction>(new global::System.Func<global::System.Data.IDbTransaction>(e.c));
				break;
			}
			}
			num = (short)1553858560;
			short num3 = num;
			return result;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00005824 File Offset: 0x00003A24
		public void ChangeDatabase(string databaseName)
		{
			short num = (short)1948738134;
			short num2 = num;
			num = (short)1344430678;
			switch (num2 == num)
			{
			}
			num = (short)529137665;
			if (num != 0)
			{
			}
			num = (short)307363840;
			short num3 = num;
			num = (short)1710555136;
			if (num != 0)
			{
			}
			global::Motorola.Data.SQLite.SQLiteConnection.f f = new global::Motorola.Data.SQLite.SQLiteConnection.f();
			f.a = this;
			f.b = databaseName;
			global::Motorola.Data.SQLite.SQLiteDllLoader.a(new global::System.Action(f.c));
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000058F8 File Offset: 0x00003AF8
		global::System.Data.IDbCommand global::System.Data.IDbConnection.CreateCommand()
		{
			short num = (short)127426730;
			short num2 = num;
			num = (short)1069703338;
			global::System.Data.IDbCommand result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)561446912;
				if (num != 0)
				{
				}
				num = (short)1648689153;
				if (num != 0)
				{
				}
				result = global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.IDbCommand>(new global::System.Func<global::System.Data.IDbCommand>(this.a));
				break;
			}
			num = (short)2036858880;
			short num3 = num;
			return result;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000059B8 File Offset: 0x00003BB8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Data.SQLite.SQLiteConnection k()
		{
			short num = (short)408586900;
			short num2 = num;
			num = (short)54233748;
			switch (num2 == num)
			{
			}
			num = (short)1347420161;
			if (num != 0)
			{
			}
			num = (short)1440481280;
			short num3 = num;
			num = (short)2139422720;
			if (num != 0)
			{
			}
			return this.a = new global::System.Data.SQLite.SQLiteConnection();
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00005A6C File Offset: 0x00003C6C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Data.SQLite.SQLiteCommand j()
		{
			short num = (short)1050021148;
			short num2 = num;
			num = (short)965807388;
			switch (num2 == num)
			{
			}
			num = (short)450101248;
			if (num != 0)
			{
			}
			num = (short)1146290176;
			short num3 = num;
			num = (short)351862785;
			if (num != 0)
			{
			}
			return this.a.CreateCommand();
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00005B24 File Offset: 0x00003D24
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Data.SQLite.SQLiteTransaction i()
		{
			short num = (short)322074227;
			short num2 = num;
			num = (short)228161139;
			switch (num2 == num)
			{
			}
			num = (short)678166528;
			if (num != 0)
			{
			}
			num = (short)1641283584;
			short num3 = num;
			num = (short)2106654721;
			if (num != 0)
			{
			}
			return this.a.BeginTransaction();
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00005BDC File Offset: 0x00003DDC
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string h()
		{
			short num = (short)1279564801;
			short num2 = num;
			num = (short)788634625;
			switch (num2 == num)
			{
			}
			num = (short)741212160;
			if (num != 0)
			{
			}
			num = (short)933298176;
			short num3 = num;
			num = (short)517144577;
			if (num != 0)
			{
			}
			return this.a.ConnectionString;
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00005C90 File Offset: 0x00003E90
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int g()
		{
			short num = (short)1234406091;
			short num2 = num;
			num = (short)1864207051;
			switch (num2 == num)
			{
			}
			num = (short)227278849;
			if (num != 0)
			{
			}
			num = (short)84934656;
			short num3 = num;
			num = (short)464519168;
			if (num != 0)
			{
			}
			return this.a.ConnectionTimeout;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00005D48 File Offset: 0x00003F48
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string f()
		{
			short num = (short)302583711;
			short num2 = num;
			num = (short)130420639;
			switch (num2 == num)
			{
			}
			num = (short)720175104;
			if (num != 0)
			{
			}
			num = (short)1711276032;
			short num3 = num;
			num = (short)1190985729;
			if (num != 0)
			{
			}
			return this.a.Database;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00005DFC File Offset: 0x00003FFC
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Data.ConnectionState e()
		{
			short num = (short)2045050881;
			if (num != 0)
			{
			}
			num = (short)628657626;
			short num2 = num;
			num = (short)1131974106;
			switch (num2 == num)
			{
			}
			num = (short)1799094272;
			short num3 = num;
			num = (short)328073216;
			if (num != 0)
			{
			}
			return this.a.State;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00005EB0 File Offset: 0x000040B0
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void d()
		{
			short num = (short)995773542;
			short num2 = num;
			num = (short)239684710;
			switch (num2 == num)
			{
			}
			num = (short)946601984;
			if (num != 0)
			{
			}
			num = (short)175439872;
			short num3 = num;
			num = (short)683409409;
			if (num != 0)
			{
			}
			this.a.Open();
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00005F68 File Offset: 0x00004168
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void c()
		{
			short num = (short)448484907;
			short num2 = num;
			num = (short)2066568747;
			switch (num2 == num)
			{
			}
			num = (short)1404239873;
			if (num != 0)
			{
			}
			num = (short)57016320;
			short num3 = num;
			num = (short)1097990144;
			if (num != 0)
			{
			}
			this.a.Close();
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000601C File Offset: 0x0000421C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void b()
		{
			short num = (short)1023776672;
			short num2 = num;
			num = (short)1580046240;
			switch (num2 == num)
			{
			}
			num = (short)560660480;
			if (num != 0)
			{
			}
			num = (short)244318208;
			short num3 = num;
			num = (short)1264386049;
			if (num != 0)
			{
			}
			this.a.Dispose();
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000060D0 File Offset: 0x000042D0
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Data.IDbCommand a()
		{
			short num = (short)1302900377;
			short num2 = num;
			num = (short)616541849;
			switch (num2 == num)
			{
			}
			num = (short)1615003649;
			if (num != 0)
			{
			}
			num = (short)475594752;
			short num3 = num;
			num = (short)744947712;
			if (num != 0)
			{
			}
			return this.a.CreateCommand();
		}

		// Token: 0x0400001D RID: 29
		internal global::System.Data.SQLite.SQLiteConnection a;

		// Token: 0x02000012 RID: 18
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x0600006B RID: 107 RVA: 0x00006198 File Offset: 0x00004398
			internal global::System.Data.SQLite.SQLiteConnection c()
			{
				short num = (short)1051993163;
				short num2 = num;
				num = (short)1944921163;
				switch (num2 == num)
				{
				}
				num = (short)913506305;
				if (num != 0)
				{
				}
				num = (short)439943168;
				short num3 = num;
				num = (short)500170752;
				if (num != 0)
				{
				}
				return this.a.a = new global::System.Data.SQLite.SQLiteConnection(this.b);
			}

			// Token: 0x0400001E RID: 30
			public global::Motorola.Data.SQLite.SQLiteConnection a;

			// Token: 0x0400001F RID: 31
			public string b;
		}

		// Token: 0x02000013 RID: 19
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class b
		{
			// Token: 0x0600006D RID: 109 RVA: 0x0000626C File Offset: 0x0000446C
			internal global::System.Data.SQLite.SQLiteConnection c()
			{
				short num = (short)817327518;
				short num2 = num;
				num = (short)1813081502;
				switch (num2 == num)
				{
				}
				num = (short)416677889;
				if (num != 0)
				{
				}
				num = (short)1493630976;
				short num3 = num;
				num = (short)1221132288;
				if (num != 0)
				{
				}
				return this.a.a = new global::System.Data.SQLite.SQLiteConnection(this.b);
			}

			// Token: 0x04000020 RID: 32
			public global::Motorola.Data.SQLite.SQLiteConnection a;

			// Token: 0x04000021 RID: 33
			public global::Motorola.Data.SQLite.SQLiteConnection b;
		}

		// Token: 0x02000014 RID: 20
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class c
		{
			// Token: 0x0600006F RID: 111 RVA: 0x00006348 File Offset: 0x00004548
			internal global::System.Data.SQLite.SQLiteConnection d()
			{
				short num = (short)1718315949;
				short num2 = num;
				num = (short)1151953837;
				switch (num2 == num)
				{
				}
				num = (short)686686209;
				if (num != 0)
				{
				}
				num = (short)1928069120;
				short num3 = num;
				num = (short)1061289984;
				if (num != 0)
				{
				}
				return this.a.a = new global::System.Data.SQLite.SQLiteConnection(this.b, this.c);
			}

			// Token: 0x04000022 RID: 34
			public global::Motorola.Data.SQLite.SQLiteConnection a;

			// Token: 0x04000023 RID: 35
			public string b;

			// Token: 0x04000024 RID: 36
			public bool c;
		}

		// Token: 0x02000015 RID: 21
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class d
		{
			// Token: 0x06000071 RID: 113 RVA: 0x00006424 File Offset: 0x00004624
			internal string c()
			{
				short num = (short)1855084947;
				short num2 = num;
				num = (short)1477073299;
				switch (num2 == num)
				{
				}
				num = (short)98828289;
				if (num != 0)
				{
				}
				num = (short)854392832;
				short num3 = num;
				num = (short)1782448128;
				if (num != 0)
				{
				}
				return this.a.a.ConnectionString = this.b;
			}

			// Token: 0x04000025 RID: 37
			public global::Motorola.Data.SQLite.SQLiteConnection a;

			// Token: 0x04000026 RID: 38
			public string b;
		}

		// Token: 0x02000016 RID: 22
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class e
		{
			// Token: 0x06000073 RID: 115 RVA: 0x000064FC File Offset: 0x000046FC
			internal global::System.Data.IDbTransaction c()
			{
				short num = (short)1198456833;
				if (num != 0)
				{
				}
				num = (short)1862568015;
				short num2 = num;
				num = (short)198150223;
				switch (num2 == num)
				{
				}
				num = (short)564658176;
				short num3 = num;
				num = (short)1736638464;
				if (num != 0)
				{
				}
				return this.a.a.BeginTransaction(this.b);
			}

			// Token: 0x04000027 RID: 39
			public global::Motorola.Data.SQLite.SQLiteConnection a;

			// Token: 0x04000028 RID: 40
			public global::System.Data.IsolationLevel b;
		}

		// Token: 0x02000017 RID: 23
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class f
		{
			// Token: 0x06000075 RID: 117 RVA: 0x000065CC File Offset: 0x000047CC
			internal void c()
			{
				short num = (short)799565516;
				short num2 = num;
				num = (short)947676876;
				switch (num2 == num)
				{
				}
				num = (short)861863936;
				if (num != 0)
				{
				}
				num = (short)1678770176;
				short num3 = num;
				num = (short)269287425;
				if (num != 0)
				{
				}
				this.a.a.ChangeDatabase(this.b);
			}

			// Token: 0x04000029 RID: 41
			public global::Motorola.Data.SQLite.SQLiteConnection a;

			// Token: 0x0400002A RID: 42
			public string b;
		}
	}
}
