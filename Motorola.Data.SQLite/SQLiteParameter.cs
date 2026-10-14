using System;
using System.Data;
using System.Data.Common;
using System.Data.SQLite;

namespace Motorola.Data.SQLite
{
	// Token: 0x0200002F RID: 47
	public class SQLiteParameter : global::System.Data.Common.DbParameter, global::System.Data.IDbDataParameter, global::System.Data.IDataParameter
	{
		// Token: 0x06000108 RID: 264 RVA: 0x0000C0A8 File Offset: 0x0000A2A8
		public static implicit operator global::System.Data.SQLite.SQLiteParameter(global::Motorola.Data.SQLite.SQLiteParameter parameter)
		{
			short num = (short)808321025;
			if (num != 0)
			{
			}
			num = (short)524746752;
			short num2 = num;
			num = (short)1480601998;
			short num3 = num;
			num = (short)1490694542;
			global::System.Data.SQLite.SQLiteParameter result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1213333504;
				if (num != 0)
				{
				}
				result = parameter.a;
				break;
			}
			return result;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000C15C File Offset: 0x0000A35C
		public static implicit operator global::Motorola.Data.SQLite.SQLiteParameter(global::System.Data.SQLite.SQLiteParameter parameter)
		{
			short num = (short)789977563;
			short num2 = num;
			num = (short)1736841691;
			global::Motorola.Data.SQLite.SQLiteParameter result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			case 1:
				break;
			default:
			{
				num = (short)1474822144;
				short num3 = num;
				break;
			}
			}
			num = (short)358285312;
			if (num != 0)
			{
			}
			num = (short)460849153;
			if (num != 0)
			{
			}
			result = new global::Motorola.Data.SQLite.SQLiteParameter
			{
				a = parameter
			};
			return result;
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000C21C File Offset: 0x0000A41C
		static SQLiteParameter()
		{
			short num = (short)893891637;
			short num2 = num;
			num = (short)39826485;
			switch (num2 == num)
			{
			default:
			{
				num = (short)450428928;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1663696896;
			if (num != 0)
			{
			}
			num = (short)171966465;
			if (num != 0)
			{
			}
			global::Motorola.Data.SQLite.SQLiteDllLoader.c();
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000C2CC File Offset: 0x0000A4CC
		public SQLiteParameter()
		{
			this.a = new global::System.Data.SQLite.SQLiteParameter();
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000C2EC File Offset: 0x0000A4EC
		public SQLiteParameter(string parameterName)
		{
			this.a = new global::System.Data.SQLite.SQLiteParameter(parameterName);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000C310 File Offset: 0x0000A510
		public SQLiteParameter(string parameterName, object value)
		{
			this.a = new global::System.Data.SQLite.SQLiteParameter(parameterName, value);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000C334 File Offset: 0x0000A534
		public SQLiteParameter(global::Motorola.Data.SQLite.SQLiteParameter parameter)
		{
			this.a = parameter;
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600010F RID: 271 RVA: 0x0000C358 File Offset: 0x0000A558
		// (set) Token: 0x06000110 RID: 272 RVA: 0x0000C410 File Offset: 0x0000A610
		public override global::System.Data.DbType DbType
		{
			get
			{
				short num = (short)2055890054;
				short num2 = num;
				num = (short)1583637638;
				switch (num2 == num)
				{
				default:
				{
					num = (short)831651840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)572719105;
				if (num != 0)
				{
				}
				num = (short)1381498880;
				if (num != 0)
				{
				}
				return this.a.DbType;
			}
			set
			{
				short num = (short)1701066040;
				short num2 = num;
				num = (short)1879258424;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1246494720;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1430781953;
				if (num != 0)
				{
				}
				num = (short)500957184;
				if (num != 0)
				{
				}
				this.a.DbType = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000111 RID: 273 RVA: 0x0000C4C4 File Offset: 0x0000A6C4
		// (set) Token: 0x06000112 RID: 274 RVA: 0x0000C578 File Offset: 0x0000A778
		public override global::System.Data.ParameterDirection Direction
		{
			get
			{
				short num = (short)139870667;
				short num2 = num;
				num = (short)844054987;
				switch (num2 == num)
				{
				default:
				{
					num = (short)499253248;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)683147265;
				if (num != 0)
				{
				}
				num = (short)630128640;
				if (num != 0)
				{
				}
				return this.a.Direction;
			}
			set
			{
				short num = (short)87352766;
				short num2 = num;
				num = (short)890103230;
				switch (num2 == num)
				{
				default:
				{
					num = (short)577241088;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1960443905;
				if (num != 0)
				{
				}
				num = (short)14090240;
				if (num != 0)
				{
				}
				this.a.Direction = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000113 RID: 275 RVA: 0x0000C630 File Offset: 0x0000A830
		// (set) Token: 0x06000114 RID: 276 RVA: 0x0000C6E4 File Offset: 0x0000A8E4
		public override bool IsNullable
		{
			get
			{
				short num = (short)335313112;
				short num2 = num;
				num = (short)384530648;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1467613184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1653735425;
				if (num != 0)
				{
				}
				num = (short)33947648;
				if (num != 0)
				{
				}
				return this.a.IsNullable;
			}
			set
			{
				short num = (short)1280550957;
				short num2 = num;
				num = (short)1193912365;
				switch (num2 == num)
				{
				default:
				{
					num = (short)740753408;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)576061441;
				if (num != 0)
				{
				}
				num = (short)1341849600;
				if (num != 0)
				{
				}
				this.a.IsNullable = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000115 RID: 277 RVA: 0x0000C798 File Offset: 0x0000A998
		// (set) Token: 0x06000116 RID: 278 RVA: 0x0000C84C File Offset: 0x0000AA4C
		public override string ParameterName
		{
			get
			{
				short num = (short)470650328;
				short num2 = num;
				num = (short)97095128;
				switch (num2 == num)
				{
				default:
				{
					num = (short)156041216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)416350209;
				if (num != 0)
				{
				}
				num = (short)1257308160;
				if (num != 0)
				{
				}
				return this.a.ParameterName;
			}
			set
			{
				short num = (short)854184539;
				short num2 = num;
				num = (short)245748315;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1128660992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1195180032;
				if (num != 0)
				{
				}
				num = (short)305070081;
				if (num != 0)
				{
				}
				this.a.ParameterName = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000117 RID: 279 RVA: 0x0000C904 File Offset: 0x0000AB04
		// (set) Token: 0x06000118 RID: 280 RVA: 0x0000C9BC File Offset: 0x0000ABBC
		public override int Size
		{
			get
			{
				short num = (short)2077632761;
				short num2 = num;
				num = (short)1669409017;
				switch (num2 == num)
				{
				default:
				{
					num = (short)994574336;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1985019905;
				if (num != 0)
				{
				}
				num = (short)827981824;
				if (num != 0)
				{
				}
				return this.a.Size;
			}
			set
			{
				short num = (short)934477825;
				if (num != 0)
				{
				}
				num = (short)2073427968;
				short num2 = num;
				num = (short)1828446357;
				short num3 = num;
				num = (short)1866195093;
				switch (num3 == num)
				{
				}
				num = (short)698482688;
				if (num != 0)
				{
				}
				this.a.Size = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x06000119 RID: 281 RVA: 0x0000CA74 File Offset: 0x0000AC74
		// (set) Token: 0x0600011A RID: 282 RVA: 0x0000CB28 File Offset: 0x0000AD28
		public override string SourceColumn
		{
			get
			{
				short num = (short)345262227;
				short num2 = num;
				num = (short)1766672531;
				switch (num2 == num)
				{
				default:
				{
					num = (short)136118272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1905852417;
				if (num != 0)
				{
				}
				num = (short)1883439104;
				if (num != 0)
				{
				}
				return this.a.SourceColumn;
			}
			set
			{
				short num = (short)246750202;
				short num2 = num;
				num = (short)1683823610;
				switch (num2 == num)
				{
				default:
				{
					num = (short)164102144;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)349896705;
				if (num != 0)
				{
				}
				num = (short)997195776;
				if (num != 0)
				{
				}
				this.a.SourceColumn = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x0600011B RID: 283 RVA: 0x0000CBE0 File Offset: 0x0000ADE0
		// (set) Token: 0x0600011C RID: 284 RVA: 0x0000CC98 File Offset: 0x0000AE98
		public override bool SourceColumnNullMapping
		{
			get
			{
				short num = (short)185498241;
				short num2 = num;
				num = (short)1098676865;
				switch (num2 == num)
				{
				default:
				{
					num = (short)697761792;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)243924993;
				if (num != 0)
				{
				}
				num = (short)217579520;
				if (num != 0)
				{
				}
				return this.a.SourceColumnNullMapping;
			}
			set
			{
				short num = (short)1718192973;
				short num2 = num;
				num = (short)834046797;
				switch (num2 == num)
				{
				default:
				{
					num = (short)459079680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)884932609;
				if (num != 0)
				{
				}
				num = (short)775290880;
				if (num != 0)
				{
				}
				this.a.SourceColumnNullMapping = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x0600011D RID: 285 RVA: 0x0000CD4C File Offset: 0x0000AF4C
		// (set) Token: 0x0600011E RID: 286 RVA: 0x0000CE04 File Offset: 0x0000B004
		public override object Value
		{
			get
			{
				short num = (short)542661574;
				short num2 = num;
				num = (short)1341086662;
				switch (num2 == num)
				{
				default:
				{
					num = (short)380436480;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)934871040;
				if (num != 0)
				{
				}
				num = (short)710410241;
				if (num != 0)
				{
				}
				return this.a.Value;
			}
			set
			{
				short num = (short)2013910247;
				short num2 = num;
				num = (short)1353503975;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1371013120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1317732352;
				if (num != 0)
				{
				}
				num = (short)1199898625;
				if (num != 0)
				{
				}
				this.a.Value = value;
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000CEBC File Offset: 0x0000B0BC
		public override void ResetDbType()
		{
			short num = (short)1169656966;
			short num2 = num;
			num = (short)1246792838;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1903296512;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1601896449;
			if (num != 0)
			{
			}
			num = (short)112656384;
			if (num != 0)
			{
			}
			this.a.ResetDbType();
		}

		// Token: 0x0400005B RID: 91
		internal global::System.Data.SQLite.SQLiteParameter a;
	}
}
