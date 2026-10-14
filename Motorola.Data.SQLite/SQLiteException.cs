using System;
using System.Data.Common;
using System.Data.SQLite;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace Motorola.Data.SQLite
{
	// Token: 0x0200002E RID: 46
	public class SQLiteException : global::System.Data.Common.DbException, global::System.Runtime.Serialization.ISerializable, global::System.Runtime.InteropServices._Exception
	{
		// Token: 0x060000F7 RID: 247 RVA: 0x0000B65C File Offset: 0x0000985C
		public static implicit operator global::System.Data.SQLite.SQLiteException(global::Motorola.Data.SQLite.SQLiteException parameter)
		{
			global::System.Data.SQLite.SQLiteException result;
			short num;
			for (;;)
			{
				result = parameter.a;
				num = (short)960767933;
				short num2 = num;
				num = (short)1530144701;
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
			num = (short)478740480;
			short num3 = num;
			num = (short)1599537153;
			if (num != 0)
			{
			}
			num = (short)2067464192;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000B710 File Offset: 0x00009910
		public static implicit operator global::Motorola.Data.SQLite.SQLiteException(global::System.Data.SQLite.SQLiteException parameter)
		{
			global::Motorola.Data.SQLite.SQLiteException result;
			short num;
			for (;;)
			{
				result = new global::Motorola.Data.SQLite.SQLiteException
				{
					a = parameter
				};
				num = (short)1097667293;
				short num2 = num;
				num = (short)1796346589;
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
			num = (short)814481408;
			short num3 = num;
			num = (short)1349124097;
			if (num != 0)
			{
			}
			num = (short)1190658048;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000B7CC File Offset: 0x000099CC
		public override int ErrorCode
		{
			get
			{
				short num = (short)564937079;
				short num2 = num;
				num = (short)10895735;
				switch (num2 == num)
				{
				}
				num = (short)596115456;
				short num3 = num;
				num = (short)827850753;
				if (num != 0)
				{
				}
				num = (short)170131456;
				if (num != 0)
				{
				}
				return this.a.ErrorCode;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000FA RID: 250 RVA: 0x0000B880 File Offset: 0x00009A80
		public override string Message
		{
			get
			{
				short num = (short)868139421;
				short num2 = num;
				num = (short)819511709;
				switch (num2 == num)
				{
				}
				num = (short)958660608;
				short num3 = num;
				num = (short)1014628352;
				if (num != 0)
				{
				}
				num = (short)130875393;
				if (num != 0)
				{
				}
				return this.a.Message;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000FB RID: 251 RVA: 0x0000B934 File Offset: 0x00009B34
		public override string StackTrace
		{
			get
			{
				short num = (short)465494753;
				short num2 = num;
				num = (short)16376545;
				switch (num2 == num)
				{
				}
				num = (short)1506344960;
				short num3 = num;
				num = (short)854654976;
				if (num != 0)
				{
				}
				num = (short)1306132481;
				if (num != 0)
				{
				}
				return this.a.StackTrace;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000FC RID: 252 RVA: 0x0000B9E8 File Offset: 0x00009BE8
		// (set) Token: 0x060000FD RID: 253 RVA: 0x0000BA9C File Offset: 0x00009C9C
		public override string HelpLink
		{
			get
			{
				short num = (short)1874395137;
				if (num != 0)
				{
				}
				num = (short)1311169081;
				short num2 = num;
				num = (short)1076746809;
				switch (num2 == num)
				{
				default:
				{
					num = (short)225837056;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1025507328;
				if (num != 0)
				{
				}
				return this.a.HelpLink;
			}
			set
			{
				short num = (short)2046529624;
				short num2 = num;
				num = (short)2015989848;
				switch (num2 == num)
				{
				}
				num = (short)1707540480;
				short num3 = num;
				num = (short)1588002817;
				if (num != 0)
				{
				}
				num = (short)1783169024;
				if (num != 0)
				{
				}
				this.a.HelpLink = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000FE RID: 254 RVA: 0x0000BB50 File Offset: 0x00009D50
		// (set) Token: 0x060000FF RID: 255 RVA: 0x0000BC08 File Offset: 0x00009E08
		public override string Source
		{
			get
			{
				short num = (short)1581580289;
				if (num != 0)
				{
				}
				num = (short)169187513;
				short num2 = num;
				num = (short)2112198841;
				switch (num2 == num)
				{
				default:
				{
					num = (short)824639488;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2145058816;
				if (num != 0)
				{
				}
				return this.a.Source;
			}
			set
			{
				short num = (short)1713951594;
				short num2 = num;
				num = (short)1399444330;
				switch (num2 == num)
				{
				}
				num = (short)330104832;
				short num3 = num;
				num = (short)469237761;
				if (num != 0)
				{
				}
				num = (short)789643264;
				if (num != 0)
				{
				}
				this.a.Source = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000100 RID: 256 RVA: 0x0000BCC0 File Offset: 0x00009EC0
		public new global::System.Exception InnerException
		{
			get
			{
				short num = (short)1973086876;
				short num2 = num;
				num = (short)732752540;
				switch (num2 == num)
				{
				}
				num = (short)1704329216;
				short num3 = num;
				num = (short)1519058945;
				if (num != 0)
				{
				}
				num = (short)1245052928;
				if (num != 0)
				{
				}
				return this.a.InnerException;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000101 RID: 257 RVA: 0x0000BD70 File Offset: 0x00009F70
		public new global::System.Reflection.MethodBase TargetSite
		{
			get
			{
				short num = (short)923647655;
				short num2 = num;
				num = (short)1208729255;
				switch (num2 == num)
				{
				}
				num = (short)710868992;
				short num3 = num;
				num = (short)1196490753;
				if (num != 0)
				{
				}
				num = (short)590544896;
				if (num != 0)
				{
				}
				return this.a.TargetSite;
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000BE24 File Offset: 0x0000A024
		static SQLiteException()
		{
			short num = (short)257992855;
			short num2 = num;
			num = (short)245082263;
			switch (num2 == num)
			{
			}
			num = (short)964034560;
			short num3 = num;
			num = (short)1876033536;
			if (num != 0)
			{
			}
			num = (short)58130433;
			if (num != 0)
			{
			}
			global::Motorola.Data.SQLite.SQLiteDllLoader.c();
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000BED4 File Offset: 0x0000A0D4
		public SQLiteException()
		{
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000BEEC File Offset: 0x0000A0EC
		public SQLiteException(string message)
		{
			this.a = new global::System.Data.SQLite.SQLiteException(message);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000BF10 File Offset: 0x0000A110
		public SQLiteException(string message, global::System.Exception innerException)
		{
			this.a = new global::System.Data.SQLite.SQLiteException(message, innerException);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000BF34 File Offset: 0x0000A134
		public new global::System.Exception GetBaseException()
		{
			global::System.Exception baseException;
			short num;
			for (;;)
			{
				baseException = this.a.GetBaseException();
				num = (short)481188833;
				short num2 = num;
				num = (short)2078170081;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_46;
				}
			}
			IL_46:
			num = (short)256770048;
			short num3 = num;
			num = (short)1126563840;
			if (num != 0)
			{
			}
			num = (short)1464074241;
			if (num != 0)
			{
			}
			return baseException;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000BFF0 File Offset: 0x0000A1F0
		public new void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			short num = (short)1849176016;
			short num2 = num;
			num = (short)906309584;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1116667904;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1523908608;
			if (num != 0)
			{
			}
			num = (short)19857409;
			if (num != 0)
			{
			}
			this.a.GetObjectData(info, context);
		}

		// Token: 0x0400005A RID: 90
		internal global::System.Data.SQLite.SQLiteException a;
	}
}
