using System;
using System.Data;
using System.Data.SQLite;
using System.Runtime.CompilerServices;

namespace Motorola.Data.SQLite
{
	// Token: 0x02000003 RID: 3
	public class SQLiteCommand : global::System.IDisposable, global::System.Data.IDbCommand
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000213C File Offset: 0x0000033C
		public static implicit operator global::System.Data.SQLite.SQLiteCommand(global::Motorola.Data.SQLite.SQLiteCommand parameter)
		{
			global::System.Data.SQLite.SQLiteCommand result;
			short num;
			for (;;)
			{
				result = parameter.a;
				num = (short)1768554497;
				if (num != 0)
				{
				}
				num = (short)1774653808;
				short num2 = num;
				num = (short)262869360;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					goto IL_90;
				}
				break;
			}
			num = (short)1737883648;
			short num3 = num;
			IL_90:
			num = (short)631504896;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000021F0 File Offset: 0x000003F0
		public static implicit operator global::Motorola.Data.SQLite.SQLiteCommand(global::System.Data.SQLite.SQLiteCommand parameter)
		{
			global::Motorola.Data.SQLite.SQLiteCommand result;
			short num;
			for (;;)
			{
				result = new global::Motorola.Data.SQLite.SQLiteCommand
				{
					a = parameter
				};
				num = (short)1720880834;
				short num2 = num;
				num = (short)938184386;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_45;
				}
			}
			IL_45:
			num = (short)904593408;
			short num3 = num;
			num = (short)678363137;
			if (num != 0)
			{
			}
			num = (short)960757760;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000022AC File Offset: 0x000004AC
		static SQLiteCommand()
		{
			short num = (short)763344833;
			short num2 = num;
			num = (short)341227457;
			switch (num2 == num)
			{
			}
			num = (short)322895872;
			if (num != 0)
			{
			}
			num = (short)517013505;
			if (num != 0)
			{
			}
			num = (short)723845120;
			short num3 = num;
			global::Motorola.Data.SQLite.SQLiteDllLoader.c();
		}

		// Token: 0x06000007 RID: 7 RVA: 0x0000235C File Offset: 0x0000055C
		public SQLiteCommand()
		{
			global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.SQLite.SQLiteCommand>(new global::System.Func<global::System.Data.SQLite.SQLiteCommand>(this.q));
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002384 File Offset: 0x00000584
		public SQLiteCommand(string commandText)
		{
			global::Motorola.Data.SQLite.SQLiteCommand.a a = new global::Motorola.Data.SQLite.SQLiteCommand.a();
			a.b = commandText;
			base..ctor();
			a.a = this;
			global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.SQLite.SQLiteCommand>(new global::System.Func<global::System.Data.SQLite.SQLiteCommand>(a.c));
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000023C0 File Offset: 0x000005C0
		public SQLiteCommand(global::Motorola.Data.SQLite.SQLiteConnection connection)
		{
			global::Motorola.Data.SQLite.SQLiteCommand.b b = new global::Motorola.Data.SQLite.SQLiteCommand.b();
			b.b = connection;
			base..ctor();
			b.a = this;
			global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.SQLite.SQLiteCommand>(new global::System.Func<global::System.Data.SQLite.SQLiteCommand>(b.c));
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000023FC File Offset: 0x000005FC
		public SQLiteCommand(string commandText, global::Motorola.Data.SQLite.SQLiteConnection connection)
		{
			global::Motorola.Data.SQLite.SQLiteCommand.c c = new global::Motorola.Data.SQLite.SQLiteCommand.c();
			c.b = commandText;
			c.c = connection;
			base..ctor();
			c.a = this;
			global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.SQLite.SQLiteCommand>(new global::System.Func<global::System.Data.SQLite.SQLiteCommand>(c.d));
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00002440 File Offset: 0x00000640
		// (set) Token: 0x0600000C RID: 12 RVA: 0x00002504 File Offset: 0x00000704
		public global::Motorola.Data.SQLite.SQLiteConnection Connection
		{
			get
			{
				short num = (short)406372132;
				short num2 = num;
				num = (short)1362935588;
				switch (num2 == num)
				{
				}
				num = (short)1457782784;
				if (num != 0)
				{
				}
				num = (short)1620246528;
				short num3 = num;
				num = (short)1600716801;
				if (num != 0)
				{
				}
				return global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.SQLite.SQLiteConnection>(new global::System.Func<global::System.Data.SQLite.SQLiteConnection>(this.p));
			}
			set
			{
				short num = (short)1866708980;
				short num2 = num;
				num = (short)1587066868;
				switch (num2 == num)
				{
				}
				num = (short)192151553;
				if (num != 0)
				{
				}
				num = (short)1101398016;
				short num3 = num;
				num = (short)975175680;
				if (num != 0)
				{
				}
				global::Motorola.Data.SQLite.SQLiteCommand.d d = new global::Motorola.Data.SQLite.SQLiteCommand.d();
				d.a = this;
				d.b = value;
				global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.SQLite.SQLiteConnection>(new global::System.Func<global::System.Data.SQLite.SQLiteConnection>(d.c));
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000025D4 File Offset: 0x000007D4
		// (set) Token: 0x0600000E RID: 14 RVA: 0x00002690 File Offset: 0x00000890
		public string CommandText
		{
			get
			{
				short num = (short)606222268;
				short num2 = num;
				num = (short)278935484;
				switch (num2 == num)
				{
				}
				num = (short)652148737;
				if (num != 0)
				{
				}
				num = (short)1007943680;
				short num3 = num;
				num = (short)1067188224;
				if (num != 0)
				{
				}
				return global::Motorola.Data.SQLite.SQLiteDllLoader.a<string>(new global::System.Func<string>(this.o));
			}
			set
			{
				short num = (short)936415743;
				short num2 = num;
				num = (short)1433637375;
				switch (num2 == num)
				{
				}
				num = (short)326893568;
				if (num != 0)
				{
				}
				num = (short)1331167232;
				short num3 = num;
				num = (short)1416626177;
				if (num != 0)
				{
				}
				global::Motorola.Data.SQLite.SQLiteCommand.e e = new global::Motorola.Data.SQLite.SQLiteCommand.e();
				e.a = this;
				e.b = value;
				global::Motorola.Data.SQLite.SQLiteDllLoader.a<string>(new global::System.Func<string>(e.c));
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000F RID: 15 RVA: 0x00002760 File Offset: 0x00000960
		public global::Motorola.Data.SQLite.SQLiteParameterCollection Parameters
		{
			get
			{
				short num = (short)1602717698;
				short num2 = num;
				num = (short)1855227906;
				switch (num2 == num)
				{
				}
				num = (short)1162674177;
				if (num != 0)
				{
				}
				num = (short)1703608320;
				short num3 = num;
				num = (short)584253440;
				if (num != 0)
				{
				}
				return global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.SQLite.SQLiteParameterCollection>(new global::System.Func<global::System.Data.SQLite.SQLiteParameterCollection>(this.n));
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000010 RID: 16 RVA: 0x0000281C File Offset: 0x00000A1C
		// (set) Token: 0x06000011 RID: 17 RVA: 0x000028D8 File Offset: 0x00000AD8
		global::System.Data.IDbConnection global::System.Data.IDbCommand.Connection
		{
			get
			{
				short num = (short)1388576769;
				if (num != 0)
				{
				}
				num = (short)670196051;
				short num2 = num;
				num = (short)1707893075;
				switch (num2 == num)
				{
				}
				num = (short)1069744128;
				short num3 = num;
				num = (short)1026686976;
				if (num != 0)
				{
				}
				return global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.IDbConnection>(new global::System.Func<global::System.Data.IDbConnection>(this.m));
			}
			set
			{
				short num = (short)613868636;
				short num2 = num;
				num = (short)387834972;
				switch (num2 == num)
				{
				}
				num = (short)1632960513;
				if (num != 0)
				{
				}
				num = (short)1619263488;
				short num3 = num;
				num = (short)1094844416;
				if (num != 0)
				{
				}
				global::Motorola.Data.SQLite.SQLiteCommand.f f = new global::Motorola.Data.SQLite.SQLiteCommand.f();
				f.a = this;
				f.b = value;
				global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.IDbConnection>(new global::System.Func<global::System.Data.IDbConnection>(f.c));
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000012 RID: 18 RVA: 0x000029A4 File Offset: 0x00000BA4
		// (set) Token: 0x06000013 RID: 19 RVA: 0x00002A60 File Offset: 0x00000C60
		public global::System.Data.IDbTransaction Transaction
		{
			get
			{
				short num = (short)1704355732;
				short num2 = num;
				num = (short)1035167636;
				switch (num2 == num)
				{
				}
				num = (short)8978432;
				if (num != 0)
				{
				}
				num = (short)369819648;
				short num3 = num;
				num = (short)1974272001;
				if (num != 0)
				{
				}
				return global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.IDbTransaction>(new global::System.Func<global::System.Data.IDbTransaction>(this.l));
			}
			set
			{
				short num = (short)1107821934;
				short num2 = num;
				num = (short)1640629614;
				switch (num2 == num)
				{
				}
				num = (short)1614479361;
				if (num != 0)
				{
				}
				num = (short)675872768;
				short num3 = num;
				num = (short)883490816;
				if (num != 0)
				{
				}
				global::Motorola.Data.SQLite.SQLiteCommand.g g = new global::Motorola.Data.SQLite.SQLiteCommand.g();
				g.a = this;
				g.b = value;
				global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.IDbTransaction>(new global::System.Func<global::System.Data.IDbTransaction>(g.c));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000014 RID: 20 RVA: 0x00002B34 File Offset: 0x00000D34
		// (set) Token: 0x06000015 RID: 21 RVA: 0x00002BEC File Offset: 0x00000DEC
		public int CommandTimeout
		{
			get
			{
				short num = (short)573045971;
				short num2 = num;
				num = (short)128384211;
				switch (num2 == num)
				{
				}
				num = (short)206372865;
				if (num != 0)
				{
				}
				num = (short)1918107648;
				short num3 = num;
				num = (short)1289224192;
				if (num != 0)
				{
				}
				return global::Motorola.Data.SQLite.SQLiteDllLoader.a<int>(new global::System.Func<int>(this.k));
			}
			set
			{
				short num = (short)1506253917;
				short num2 = num;
				num = (short)1561762909;
				switch (num2 == num)
				{
				}
				num = (short)2131361793;
				if (num != 0)
				{
				}
				num = (short)1482555392;
				short num3 = num;
				num = (short)1761411072;
				if (num != 0)
				{
				}
				global::Motorola.Data.SQLite.SQLiteCommand.h h = new global::Motorola.Data.SQLite.SQLiteCommand.h();
				h.a = this;
				h.b = value;
				global::Motorola.Data.SQLite.SQLiteDllLoader.a<int>(new global::System.Func<int>(h.c));
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002CC0 File Offset: 0x00000EC0
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002D7C File Offset: 0x00000F7C
		public global::System.Data.CommandType CommandType
		{
			get
			{
				short num = (short)1398681020;
				short num2 = num;
				num = (short)822816188;
				switch (num2 == num)
				{
				}
				num = (short)1850343425;
				if (num != 0)
				{
				}
				num = (short)898564096;
				short num3 = num;
				num = (short)1731461120;
				if (num != 0)
				{
				}
				return global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.CommandType>(new global::System.Func<global::System.Data.CommandType>(this.j));
			}
			set
			{
				short num = (short)1515076421;
				short num2 = num;
				num = (short)610089797;
				switch (num2 == num)
				{
				}
				num = (short)1125580801;
				if (num != 0)
				{
				}
				num = (short)1863385088;
				short num3 = num;
				num = (short)1031340032;
				if (num != 0)
				{
				}
				global::Motorola.Data.SQLite.SQLiteCommand.i i = new global::Motorola.Data.SQLite.SQLiteCommand.i();
				i.a = this;
				i.b = value;
				global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.CommandType>(new global::System.Func<global::System.Data.CommandType>(i.c));
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00002E4C File Offset: 0x0000104C
		global::System.Data.IDataParameterCollection global::System.Data.IDbCommand.Parameters
		{
			get
			{
				short num = (short)388122221;
				short num2 = num;
				num = (short)1901807213;
				switch (num2 == num)
				{
				}
				num = (short)471531520;
				if (num != 0)
				{
				}
				num = (short)2090926080;
				short num3 = num;
				num = (short)1699938305;
				if (num != 0)
				{
				}
				return global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.IDataParameterCollection>(new global::System.Func<global::System.Data.IDataParameterCollection>(this.i));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00002F08 File Offset: 0x00001108
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00002FC0 File Offset: 0x000011C0
		public global::System.Data.UpdateRowSource UpdatedRowSource
		{
			get
			{
				short num = (short)1758018959;
				short num2 = num;
				num = (short)1051999631;
				switch (num2 == num)
				{
				}
				num = (short)591265793;
				if (num != 0)
				{
				}
				num = (short)1629159424;
				short num3 = num;
				num = (short)562692096;
				if (num != 0)
				{
				}
				return global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.UpdateRowSource>(new global::System.Func<global::System.Data.UpdateRowSource>(this.h));
			}
			set
			{
				short num = (short)1582583160;
				short num2 = num;
				num = (short)1590054264;
				switch (num2 == num)
				{
				}
				num = (short)926351361;
				if (num != 0)
				{
				}
				num = (short)1465909248;
				short num3 = num;
				num = (short)1617231872;
				if (num != 0)
				{
				}
				global::Motorola.Data.SQLite.SQLiteCommand.j j = new global::Motorola.Data.SQLite.SQLiteCommand.j();
				j.a = this;
				j.b = value;
				global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.UpdateRowSource>(new global::System.Func<global::System.Data.UpdateRowSource>(j.c));
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003094 File Offset: 0x00001294
		public int ExecuteNonQuery()
		{
			int result;
			short num;
			for (;;)
			{
				result = global::Motorola.Data.SQLite.SQLiteDllLoader.a<int>(new global::System.Func<int>(this.g));
				num = (short)503812148;
				short num2 = num;
				num = (short)2070384692;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_49;
				}
			}
			IL_49:
			num = (short)654639104;
			if (num != 0)
			{
			}
			num = (short)1752956928;
			short num3 = num;
			num = (short)1099563009;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003154 File Offset: 0x00001354
		public void Dispose()
		{
			short num = (short)304326483;
			short num2 = num;
			num = (short)1248438099;
			switch (num2 == num)
			{
			}
			num = (short)2029518849;
			if (num != 0)
			{
			}
			num = (short)1414529024;
			short num3 = num;
			num = (short)2046099456;
			if (num != 0)
			{
			}
			global::Motorola.Data.SQLite.SQLiteDllLoader.a(new global::System.Action(this.f));
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003210 File Offset: 0x00001410
		public void Prepare()
		{
			short num = (short)101018955;
			short num2 = num;
			num = (short)786722123;
			switch (num2 == num)
			{
			}
			num = (short)50790400;
			if (num != 0)
			{
			}
			num = (short)1993015296;
			short num3 = num;
			num = (short)1508311041;
			if (num != 0)
			{
			}
			global::Motorola.Data.SQLite.SQLiteDllLoader.a(new global::System.Action(this.e));
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000032D0 File Offset: 0x000014D0
		public void Cancel()
		{
			short num = (short)646764882;
			short num2 = num;
			num = (short)607377746;
			switch (num2 == num)
			{
			}
			num = (short)416153601;
			if (num != 0)
			{
			}
			num = (short)626851840;
			short num3 = num;
			num = (short)556924928;
			if (num != 0)
			{
			}
			global::Motorola.Data.SQLite.SQLiteDllLoader.a(new global::System.Action(this.d));
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003390 File Offset: 0x00001590
		public global::System.Data.IDbDataParameter CreateParameter()
		{
			global::System.Data.IDbDataParameter result;
			short num;
			for (;;)
			{
				result = global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.IDbDataParameter>(new global::System.Func<global::System.Data.IDbDataParameter>(this.c));
				num = (short)227644702;
				short num2 = num;
				num = (short)1335661854;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_4A;
				}
			}
			IL_4A:
			num = (short)962854912;
			if (num != 0)
			{
			}
			num = (short)802291712;
			short num3 = num;
			num = (short)45023233;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003454 File Offset: 0x00001654
		public global::System.Data.IDataReader ExecuteReader()
		{
			global::System.Data.IDataReader result;
			short num;
			for (;;)
			{
				result = global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.IDataReader>(new global::System.Func<global::System.Data.IDataReader>(this.b));
				num = (short)84475905;
				if (num != 0)
				{
				}
				num = (short)1358478990;
				short num2 = num;
				num = (short)358989454;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_70;
				}
			}
			IL_70:
			num = (short)81854464;
			short num3 = num;
			num = (short)599392256;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003514 File Offset: 0x00001714
		public global::System.Data.IDataReader ExecuteReader(global::System.Data.CommandBehavior behavior)
		{
			global::System.Data.IDataReader result;
			short num;
			for (;;)
			{
				global::Motorola.Data.SQLite.SQLiteCommand.k k = new global::Motorola.Data.SQLite.SQLiteCommand.k();
				k.a = this;
				k.b = behavior;
				result = global::Motorola.Data.SQLite.SQLiteDllLoader.a<global::System.Data.IDataReader>(new global::System.Func<global::System.Data.IDataReader>(k.c));
				num = (short)280020950;
				short num2 = num;
				num = (short)1532872662;
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
			num = (short)1336016897;
			if (num != 0)
			{
			}
			num = (short)99352576;
			short num3 = num;
			num = (short)1263861760;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000035E8 File Offset: 0x000017E8
		public object ExecuteScalar()
		{
			object result;
			short num;
			for (;;)
			{
				result = global::Motorola.Data.SQLite.SQLiteDllLoader.a<object>(new global::System.Func<object>(this.a));
				num = (short)618004481;
				if (num != 0)
				{
				}
				num = (short)1346840564;
				short num2 = num;
				num = (short)645867508;
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
			num = (short)1352925184;
			short num3 = num;
			num = (short)23068672;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000036A8 File Offset: 0x000018A8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Data.SQLite.SQLiteCommand q()
		{
			short num = (short)2050514595;
			short num2 = num;
			num = (short)2108907171;
			switch (num2 == num)
			{
			}
			num = (short)281542657;
			if (num != 0)
			{
			}
			num = (short)723451904;
			short num3 = num;
			num = (short)565051392;
			if (num != 0)
			{
			}
			return this.a = new global::System.Data.SQLite.SQLiteCommand();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003760 File Offset: 0x00001960
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Data.SQLite.SQLiteConnection p()
		{
			short num = (short)342189406;
			short num2 = num;
			num = (short)1471898974;
			switch (num2 == num)
			{
			}
			num = (short)1135017984;
			if (num != 0)
			{
			}
			num = (short)1011417088;
			short num3 = num;
			num = (short)1750728705;
			if (num != 0)
			{
			}
			return this.a.Connection;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003818 File Offset: 0x00001A18
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string o()
		{
			short num = (short)111157786;
			short num2 = num;
			num = (short)155722266;
			switch (num2 == num)
			{
			}
			num = (short)1118961665;
			if (num != 0)
			{
			}
			num = (short)322633728;
			short num3 = num;
			num = (short)546242560;
			if (num != 0)
			{
			}
			return this.a.CommandText;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000038D4 File Offset: 0x00001AD4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Data.SQLite.SQLiteParameterCollection n()
		{
			short num = (short)1638215462;
			short num2 = num;
			num = (short)1295986470;
			switch (num2 == num)
			{
			}
			num = (short)837615616;
			if (num != 0)
			{
			}
			num = (short)1930428416;
			short num3 = num;
			num = (short)51838977;
			if (num != 0)
			{
			}
			return this.a.Parameters;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x0000398C File Offset: 0x00001B8C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Data.IDbConnection m()
		{
			short num = (short)547065932;
			short num2 = num;
			num = (short)2125566028;
			switch (num2 == num)
			{
			}
			num = (short)1013710848;
			if (num != 0)
			{
			}
			num = (short)6291456;
			short num3 = num;
			num = (short)710868993;
			if (num != 0)
			{
			}
			return this.a.Connection;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00003A40 File Offset: 0x00001C40
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Data.IDbTransaction l()
		{
			short num = (short)629014529;
			if (num != 0)
			{
			}
			num = (short)704683477;
			short num2 = num;
			num = (short)182754773;
			switch (num2 == num)
			{
			}
			num = (short)237633536;
			short num3 = num;
			num = (short)602341376;
			if (num != 0)
			{
			}
			return this.a.Transaction;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003AF4 File Offset: 0x00001CF4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int k()
		{
			short num = (short)1742849970;
			short num2 = num;
			num = (short)1196804018;
			switch (num2 == num)
			{
			}
			num = (short)1116274689;
			if (num != 0)
			{
			}
			num = (short)247988224;
			short num3 = num;
			num = (short)1853358080;
			if (num != 0)
			{
			}
			return this.a.CommandTimeout;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003BAC File Offset: 0x00001DAC
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Data.CommandType j()
		{
			short num = (short)500008972;
			short num2 = num;
			num = (short)1429374988;
			switch (num2 == num)
			{
			}
			num = (short)1032454145;
			if (num != 0)
			{
			}
			num = (short)1245184;
			short num3 = num;
			num = (short)1036124160;
			if (num != 0)
			{
			}
			return this.a.CommandType;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00003C60 File Offset: 0x00001E60
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Data.IDataParameterCollection i()
		{
			short num = (short)1781717339;
			short num2 = num;
			num = (short)855431515;
			switch (num2 == num)
			{
			}
			num = (short)1963065344;
			if (num != 0)
			{
			}
			num = (short)1449000960;
			short num3 = num;
			num = (short)366739457;
			if (num != 0)
			{
			}
			return this.a.Parameters;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003D14 File Offset: 0x00001F14
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Data.UpdateRowSource h()
		{
			short num = (short)174053615;
			short num2 = num;
			num = (short)1291901167;
			switch (num2 == num)
			{
			}
			num = (short)413204481;
			if (num != 0)
			{
			}
			num = (short)971440128;
			short num3 = num;
			num = (short)1623130112;
			if (num != 0)
			{
			}
			return this.a.UpdatedRowSource;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003DC8 File Offset: 0x00001FC8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int g()
		{
			short num = (short)736296961;
			if (num != 0)
			{
			}
			num = (short)251979203;
			short num2 = num;
			num = (short)193062339;
			switch (num2 == num)
			{
			}
			num = (short)298713088;
			short num3 = num;
			num = (short)1908539392;
			if (num != 0)
			{
			}
			return this.a.ExecuteNonQuery();
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003E80 File Offset: 0x00002080
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void f()
		{
			short num = (short)2059842298;
			short num2 = num;
			num = (short)183677690;
			switch (num2 == num)
			{
			}
			num = (short)610926593;
			if (num != 0)
			{
			}
			num = (short)597557248;
			short num3 = num;
			num = (short)1340997632;
			if (num != 0)
			{
			}
			this.a.Dispose();
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003F38 File Offset: 0x00002138
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void e()
		{
			short num = (short)1763065948;
			short num2 = num;
			num = (short)793657436;
			switch (num2 == num)
			{
			}
			num = (short)1456275457;
			if (num != 0)
			{
			}
			num = (short)701693952;
			short num3 = num;
			num = (short)198311936;
			if (num != 0)
			{
			}
			this.a.Prepare();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003FF0 File Offset: 0x000021F0
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void d()
		{
			short num = (short)236453889;
			if (num != 0)
			{
			}
			num = (short)528554432;
			short num2 = num;
			num = (short)1233394112;
			switch (num2 == num)
			{
			}
			num = (short)1480654848;
			short num3 = num;
			num = (short)1732771840;
			if (num != 0)
			{
			}
			this.a.Cancel();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000040A4 File Offset: 0x000022A4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Data.IDbDataParameter c()
		{
			short num = (short)160697170;
			short num2 = num;
			num = (short)961612626;
			switch (num2 == num)
			{
			}
			num = (short)1352400897;
			if (num != 0)
			{
			}
			num = (short)1823014912;
			short num3 = num;
			num = (short)1025310720;
			if (num != 0)
			{
			}
			return this.a.CreateParameter();
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00004158 File Offset: 0x00002358
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Data.IDataReader b()
		{
			short num = (short)2076566144;
			short num2 = num;
			num = (short)251650688;
			switch (num2 == num)
			{
			}
			num = (short)1561395201;
			if (num != 0)
			{
			}
			num = (short)79364096;
			short num3 = num;
			num = (short)927268864;
			if (num != 0)
			{
			}
			return this.a.ExecuteReader();
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000420C File Offset: 0x0000240C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private object a()
		{
			short num = (short)1082575282;
			short num2 = num;
			num = (short)857917874;
			switch (num2 == num)
			{
			}
			num = (short)1982267392;
			if (num != 0)
			{
			}
			num = (short)407568384;
			short num3 = num;
			num = (short)903020545;
			if (num != 0)
			{
			}
			return this.a.ExecuteScalar();
		}

		// Token: 0x04000003 RID: 3
		internal global::System.Data.SQLite.SQLiteCommand a;

		// Token: 0x02000006 RID: 6
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06000035 RID: 53 RVA: 0x000042D4 File Offset: 0x000024D4
			internal global::System.Data.SQLite.SQLiteCommand c()
			{
				short num = (short)666896195;
				short num2 = num;
				num = (short)514590531;
				switch (num2 == num)
				{
				}
				num = (short)1575747584;
				if (num != 0)
				{
				}
				num = (short)729350144;
				short num3 = num;
				num = (short)952434689;
				if (num != 0)
				{
				}
				return this.a.a = new global::System.Data.SQLite.SQLiteCommand(this.b);
			}

			// Token: 0x04000006 RID: 6
			public global::Motorola.Data.SQLite.SQLiteCommand a;

			// Token: 0x04000007 RID: 7
			public string b;
		}

		// Token: 0x02000007 RID: 7
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class b
		{
			// Token: 0x06000037 RID: 55 RVA: 0x000043AC File Offset: 0x000025AC
			internal global::System.Data.SQLite.SQLiteCommand c()
			{
				short num = (short)1427206696;
				short num2 = num;
				num = (short)1719890472;
				switch (num2 == num)
				{
				}
				num = (short)1476526081;
				if (num != 0)
				{
				}
				num = (short)1786118144;
				short num3 = num;
				num = (short)19791872;
				if (num != 0)
				{
				}
				return this.a.a = new global::System.Data.SQLite.SQLiteCommand(this.b);
			}

			// Token: 0x04000008 RID: 8
			public global::Motorola.Data.SQLite.SQLiteCommand a;

			// Token: 0x04000009 RID: 9
			public global::Motorola.Data.SQLite.SQLiteConnection b;
		}

		// Token: 0x02000008 RID: 8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class c
		{
			// Token: 0x06000039 RID: 57 RVA: 0x00004488 File Offset: 0x00002688
			internal global::System.Data.SQLite.SQLiteCommand d()
			{
				short num = (short)1148678570;
				short num2 = num;
				num = (short)596079018;
				switch (num2 == num)
				{
				}
				num = (short)1126498305;
				if (num != 0)
				{
				}
				num = (short)44367872;
				short num3 = num;
				num = (short)521928704;
				if (num != 0)
				{
				}
				return this.a.a = new global::System.Data.SQLite.SQLiteCommand(this.b, this.c);
			}

			// Token: 0x0400000A RID: 10
			public global::Motorola.Data.SQLite.SQLiteCommand a;

			// Token: 0x0400000B RID: 11
			public string b;

			// Token: 0x0400000C RID: 12
			public global::Motorola.Data.SQLite.SQLiteConnection c;
		}

		// Token: 0x02000009 RID: 9
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class d
		{
			// Token: 0x0600003B RID: 59 RVA: 0x0000456C File Offset: 0x0000276C
			internal global::System.Data.SQLite.SQLiteConnection c()
			{
				short num = (short)469536851;
				short num2 = num;
				num = (short)2077528147;
				switch (num2 == num)
				{
				}
				num = (short)2092236801;
				if (num != 0)
				{
				}
				num = (short)1524367360;
				short num3 = num;
				num = (short)346750976;
				if (num != 0)
				{
				}
				return this.a.a.Connection = this.b;
			}

			// Token: 0x0400000D RID: 13
			public global::Motorola.Data.SQLite.SQLiteCommand a;

			// Token: 0x0400000E RID: 14
			public global::Motorola.Data.SQLite.SQLiteConnection b;
		}

		// Token: 0x0200000A RID: 10
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class e
		{
			// Token: 0x0600003D RID: 61 RVA: 0x00004648 File Offset: 0x00002848
			internal string c()
			{
				short num = (short)909836289;
				if (num != 0)
				{
				}
				num = (short)696102921;
				short num2 = num;
				num = (short)1003925513;
				switch (num2 == num)
				{
				}
				num = (short)2047475712;
				short num3 = num;
				num = (short)1621164032;
				if (num != 0)
				{
				}
				return this.a.a.CommandText = this.b;
			}

			// Token: 0x0400000F RID: 15
			public global::Motorola.Data.SQLite.SQLiteCommand a;

			// Token: 0x04000010 RID: 16
			public string b;
		}

		// Token: 0x0200000B RID: 11
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class f
		{
			// Token: 0x0600003F RID: 63 RVA: 0x00004720 File Offset: 0x00002920
			internal global::System.Data.IDbConnection c()
			{
				short num = (short)895352833;
				if (num != 0)
				{
				}
				num = (short)373637394;
				short num2 = num;
				num = (short)1135296786;
				switch (num2 == num)
				{
				}
				num = (short)1934884864;
				short num3 = num;
				num = (short)577634304;
				if (num != 0)
				{
				}
				return this.a.a.Connection = this.b;
			}

			// Token: 0x04000011 RID: 17
			public global::Motorola.Data.SQLite.SQLiteCommand a;

			// Token: 0x04000012 RID: 18
			public global::System.Data.IDbConnection b;
		}

		// Token: 0x0200000C RID: 12
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class g
		{
			// Token: 0x06000041 RID: 65 RVA: 0x000047F8 File Offset: 0x000029F8
			internal global::System.Data.IDbTransaction c()
			{
				short num = (short)1360508027;
				short num2 = num;
				num = (short)1194046587;
				switch (num2 == num)
				{
				}
				num = (short)548864000;
				if (num != 0)
				{
				}
				num = (short)1322647552;
				short num3 = num;
				num = (short)409862145;
				if (num != 0)
				{
				}
				return this.a.a.Transaction = this.b;
			}

			// Token: 0x04000013 RID: 19
			public global::Motorola.Data.SQLite.SQLiteCommand a;

			// Token: 0x04000014 RID: 20
			public global::System.Data.IDbTransaction b;
		}

		// Token: 0x0200000D RID: 13
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class h
		{
			// Token: 0x06000043 RID: 67 RVA: 0x000048D0 File Offset: 0x00002AD0
			internal int c()
			{
				short num = (short)124240761;
				short num2 = num;
				num = (short)1913308025;
				switch (num2 == num)
				{
				}
				num = (short)731971585;
				if (num != 0)
				{
				}
				num = (short)1870725120;
				short num3 = num;
				num = (short)1487077376;
				if (num != 0)
				{
				}
				return this.a.a.CommandTimeout = this.b;
			}

			// Token: 0x04000015 RID: 21
			public global::Motorola.Data.SQLite.SQLiteCommand a;

			// Token: 0x04000016 RID: 22
			public int b;
		}

		// Token: 0x0200000E RID: 14
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class i
		{
			// Token: 0x06000045 RID: 69 RVA: 0x000049A8 File Offset: 0x00002BA8
			internal global::System.Data.CommandType c()
			{
				short num = (short)996933633;
				if (num != 0)
				{
				}
				num = (short)421344953;
				short num2 = num;
				num = (short)1962817209;
				switch (num2 == num)
				{
				}
				num = (short)297074688;
				short num3 = num;
				num = (short)861863936;
				if (num != 0)
				{
				}
				return this.a.a.CommandType = this.b;
			}

			// Token: 0x04000017 RID: 23
			public global::Motorola.Data.SQLite.SQLiteCommand a;

			// Token: 0x04000018 RID: 24
			public global::System.Data.CommandType b;
		}

		// Token: 0x0200000F RID: 15
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class j
		{
			// Token: 0x06000047 RID: 71 RVA: 0x00004A80 File Offset: 0x00002C80
			internal global::System.Data.UpdateRowSource c()
			{
				short num = (short)2075465094;
				short num2 = num;
				num = (short)427103622;
				switch (num2 == num)
				{
				}
				num = (short)1343488000;
				if (num != 0)
				{
				}
				num = (short)733282304;
				short num3 = num;
				num = (short)242679809;
				if (num != 0)
				{
				}
				return this.a.a.UpdatedRowSource = this.b;
			}

			// Token: 0x04000019 RID: 25
			public global::Motorola.Data.SQLite.SQLiteCommand a;

			// Token: 0x0400001A RID: 26
			public global::System.Data.UpdateRowSource b;
		}

		// Token: 0x02000010 RID: 16
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class k
		{
			// Token: 0x06000049 RID: 73 RVA: 0x00004B58 File Offset: 0x00002D58
			internal global::System.Data.IDataReader c()
			{
				short num = (short)548954341;
				short num2 = num;
				num = (short)1701535973;
				switch (num2 == num)
				{
				}
				num = (short)376897537;
				if (num != 0)
				{
				}
				num = (short)173342720;
				short num3 = num;
				num = (short)1578827776;
				if (num != 0)
				{
				}
				return this.a.a.ExecuteReader(this.b);
			}

			// Token: 0x0400001B RID: 27
			public global::Motorola.Data.SQLite.SQLiteCommand a;

			// Token: 0x0400001C RID: 28
			public global::System.Data.CommandBehavior b;
		}
	}
}
