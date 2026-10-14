using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;

namespace Motorola.Data.SQLite
{
	// Token: 0x02000030 RID: 48
	public sealed class SQLiteParameterCollection : global::System.Data.IDataParameterCollection, global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable
	{
		// Token: 0x06000120 RID: 288 RVA: 0x0000CF70 File Offset: 0x0000B170
		public static implicit operator global::System.Data.SQLite.SQLiteParameterCollection(global::Motorola.Data.SQLite.SQLiteParameterCollection collection)
		{
			short num = (short)535497236;
			short num2 = num;
			num = (short)532154900;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_7C;
			case 1:
				break;
			default:
			{
				num = (short)623443968;
				short num3 = num;
				break;
			}
			}
			num = (short)1351548928;
			if (num != 0)
			{
			}
			global::System.Data.SQLite.SQLiteParameterCollection result = collection.a;
			IL_7C:
			num = (short)1873477633;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000D024 File Offset: 0x0000B224
		public static implicit operator global::Motorola.Data.SQLite.SQLiteParameterCollection(global::System.Data.SQLite.SQLiteParameterCollection collection)
		{
			short num = (short)232302058;
			short num2 = num;
			num = (short)404596202;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_82;
			case 1:
				break;
			default:
			{
				num = (short)248840192;
				short num3 = num;
				break;
			}
			}
			num = (short)426639360;
			if (num != 0)
			{
			}
			global::Motorola.Data.SQLite.SQLiteParameterCollection result = new global::Motorola.Data.SQLite.SQLiteParameterCollection
			{
				a = collection
			};
			IL_82:
			num = (short)654114817;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x17000034 RID: 52
		public global::Motorola.Data.SQLite.SQLiteParameter this[int index]
		{
			get
			{
				short num = (short)2079553112;
				short num2 = num;
				num = (short)1752856152;
				switch (num2 == num)
				{
				default:
				{
					num = (short)331677696;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)229310464;
				if (num != 0)
				{
				}
				num = (short)1337917441;
				if (num != 0)
				{
				}
				return this.a[index];
			}
			set
			{
				short num = (short)1792562465;
				short num2 = num;
				num = (short)942167329;
				switch (num2 == num)
				{
				default:
				{
					num = (short)255000576;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1319043072;
				if (num != 0)
				{
				}
				num = (short)62586881;
				if (num != 0)
				{
				}
				this.a[index] = value;
			}
		}

		// Token: 0x17000035 RID: 53
		public global::Motorola.Data.SQLite.SQLiteParameter this[string parameterName]
		{
			get
			{
				short num = (short)638648321;
				if (num != 0)
				{
				}
				num = (short)1402798080;
				short num2 = num;
				num = (short)385772254;
				short num3 = num;
				num = (short)1758096094;
				switch (num3 == num)
				{
				}
				num = (short)1235550208;
				if (num != 0)
				{
				}
				return this.a[parameterName];
			}
			set
			{
				short num = (short)1238244307;
				short num2 = num;
				num = (short)716774355;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1037500416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1974927361;
				if (num != 0)
				{
				}
				num = (short)1666383872;
				if (num != 0)
				{
				}
				this.a[parameterName] = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000126 RID: 294 RVA: 0x0000D3D0 File Offset: 0x0000B5D0
		public int Count
		{
			get
			{
				short num = (short)612080659;
				short num2 = num;
				num = (short)547396627;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1703346176;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)190119937;
				if (num != 0)
				{
				}
				num = (short)1584660480;
				if (num != 0)
				{
				}
				return this.a.Count;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000127 RID: 295 RVA: 0x0000D484 File Offset: 0x0000B684
		public object SyncRoot
		{
			get
			{
				short num = (short)1471938561;
				if (num != 0)
				{
				}
				num = (short)436469760;
				short num2 = num;
				num = (short)1973669153;
				short num3 = num;
				num = (short)1069731105;
				switch (num3 == num)
				{
				}
				num = (short)352976896;
				if (num != 0)
				{
				}
				return this.a.SyncRoot;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000128 RID: 296 RVA: 0x0000D53C File Offset: 0x0000B73C
		public bool IsReadOnly
		{
			get
			{
				short num = (short)2022637569;
				if (num != 0)
				{
				}
				num = (short)1202651136;
				short num2 = num;
				num = (short)1360912112;
				short num3 = num;
				num = (short)554688240;
				switch (num3 == num)
				{
				}
				num = (short)117178368;
				if (num != 0)
				{
				}
				return this.a.IsReadOnly;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000129 RID: 297 RVA: 0x0000D5F4 File Offset: 0x0000B7F4
		public bool IsFixedSize
		{
			get
			{
				short num = (short)408813569;
				if (num != 0)
				{
				}
				num = (short)1955201024;
				short num2 = num;
				num = (short)1967824872;
				short num3 = num;
				num = (short)1177919464;
				switch (num3 == num)
				{
				}
				num = (short)684589056;
				if (num != 0)
				{
				}
				return this.a.IsFixedSize;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600012A RID: 298 RVA: 0x0000D6A8 File Offset: 0x0000B8A8
		public bool IsSynchronized
		{
			get
			{
				short num = (short)1058638806;
				short num2 = num;
				num = (short)1311411158;
				switch (num2 == num)
				{
				default:
				{
					num = (short)577699840;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1749680129;
				if (num != 0)
				{
				}
				num = (short)1663631360;
				if (num != 0)
				{
				}
				return this.a.IsSynchronized;
			}
		}

		// Token: 0x1700003B RID: 59
		object global::System.Collections.IList.this[int index]
		{
			get
			{
				short num = (short)1003091512;
				short num2 = num;
				num = (short)27391544;
				switch (num2 == num)
				{
				default:
				{
					num = (short)759496704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1873412097;
				if (num != 0)
				{
				}
				num = (short)88014848;
				if (num != 0)
				{
				}
				return this.a[index];
			}
			set
			{
				short num = (short)51300409;
				short num2 = num;
				num = (short)1812908089;
				switch (num2 == num)
				{
				default:
				{
					num = (short)857866240;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)699727873;
				if (num != 0)
				{
				}
				num = (short)945356800;
				if (num != 0)
				{
				}
				this.a[index] = value;
			}
		}

		// Token: 0x1700003C RID: 60
		object global::System.Data.IDataParameterCollection.this[string parameterName]
		{
			get
			{
				short num = (short)1780809729;
				if (num != 0)
				{
				}
				num = (short)1202454528;
				short num2 = num;
				num = (short)1892548253;
				short num3 = num;
				num = (short)2098003613;
				switch (num3 == num)
				{
				}
				num = (short)1036058624;
				if (num != 0)
				{
				}
				return this.a[parameterName];
			}
			set
			{
				short num = (short)1247057774;
				short num2 = num;
				num = (short)1272878958;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1843527680;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)883359744;
				if (num != 0)
				{
				}
				num = (short)1815216129;
				if (num != 0)
				{
				}
				this.a[parameterName] = value;
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000DA38 File Offset: 0x0000BC38
		public int Add(object value)
		{
			int num;
			short num2;
			bool flag;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				int result;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						return result;
					case 1:
					{
						num2 = (short)1272970237;
						short num3 = num2;
						num2 = (short)1420098557;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2B;
						default:
							num2 = (short)2127495169;
							if (num2 != 0)
							{
							}
							num2 = (short)524025856;
							if (num2 != 0)
							{
							}
							result = this.a.Add(((global::Motorola.Data.SQLite.SQLiteParameter)value).a);
							num2 = (short)95289344;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						if (flag)
						{
							num2 = (short)1980366849;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = this.a.Add(value);
						num2 = (short)1430323203;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						return result;
					}
					goto IL_20;
				}
				return result;
			}
			}
			IL_20:
			flag = (value is global::Motorola.Data.SQLite.SQLiteParameter);
			IL_2B:
			num2 = (short)103284736;
			short num4 = num2;
			num2 = (short)487063554;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000DB94 File Offset: 0x0000BD94
		public global::Motorola.Data.SQLite.SQLiteParameter Add(string parameterName, global::System.Data.DbType parameterType)
		{
			short num = (short)890469368;
			short num2 = num;
			num = (short)1717664760;
			global::Motorola.Data.SQLite.SQLiteParameter result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1454899201;
				if (num != 0)
				{
				}
				num = (short)1942487040;
				if (num != 0)
				{
				}
				num = (short)787087360;
				short num3 = num;
				result = this.a.Add(parameterName, parameterType);
				break;
			}
			}
			return result;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000DC54 File Offset: 0x0000BE54
		public void AddRange(global::System.Array values)
		{
			short num = (short)1946222593;
			if (num != 0)
			{
			}
			num = (short)736708371;
			short num2 = num;
			num = (short)1481000723;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)20185088;
				if (num != 0)
				{
				}
				num = (short)292487168;
				short num3 = num;
				global::System.Collections.IEnumerator enumerator = values.GetEnumerator();
				try
				{
					num = (short)2007040002;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)475070467;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							object obj = enumerator.Current;
							this.a.Add(((global::Motorola.Data.SQLite.SQLiteParameter)obj).a);
							num = (short)787742721;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_DF;
							}
							continue;
						case 3:
							num = (short)192348164;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_15E;
						}
						IL_115:
						num = (short)737804288;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_DF:
						goto IL_115;
					}
					IL_15E:;
				}
				finally
				{
					switch (0)
					{
					case 0:
						goto IL_17C;
					}
					int num4;
					global::System.IDisposable disposable;
					for (;;)
					{
						IL_16A:
						switch (num4)
						{
						case 0:
							if (disposable != null)
							{
								num = (short)966983681;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1D0;
						case 1:
							disposable.Dispose();
							num = (short)1262354434;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_1CE;
						}
						goto IL_17C;
					}
					IL_1CE:
					IL_1D0:
					break;
					IL_17C:
					disposable = (enumerator as global::System.IDisposable);
					num = (short)1214382080;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_16A;
				}
				break;
			}
			}
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0000DE44 File Offset: 0x0000C044
		public void Clear()
		{
			short num = (short)275571033;
			short num2 = num;
			num = (short)1438638425;
			switch (num2 == num)
			{
			}
			num = (short)1300955136;
			short num3 = num;
			num = (short)1652490241;
			if (num != 0)
			{
			}
			num = (short)376307712;
			if (num != 0)
			{
			}
			this.a.Clear();
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000DEF8 File Offset: 0x0000C0F8
		public bool Contains(object value)
		{
			int num;
			short num2;
			bool flag;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				bool result;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)2135845279;
						short num3 = num2;
						num2 = (short)991127967;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2B;
						default:
							num2 = (short)845283328;
							if (num2 != 0)
							{
							}
							result = this.a.Contains(((global::Motorola.Data.SQLite.SQLiteParameter)value).a);
							num2 = (short)144703491;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						if (flag)
						{
							num2 = (short)1965555712;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = this.a.Contains(value);
						num2 = (short)1900675074;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						goto IL_A8;
					case 3:
						return result;
					}
					goto IL_20;
				}
				IL_A8:
				num2 = (short)1990721537;
				if (num2 != 0)
				{
				}
				return result;
			}
			}
			IL_20:
			flag = (value is global::Motorola.Data.SQLite.SQLiteParameter);
			IL_2B:
			num2 = (short)1617952768;
			short num4 = num2;
			num2 = (short)313327617;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000E054 File Offset: 0x0000C254
		public bool Contains(string parameterName)
		{
			short num = (short)1292102213;
			short num2 = num;
			num = (short)821815877;
			bool result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)493486081;
				if (num != 0)
				{
				}
				num = (short)1539178496;
				if (num != 0)
				{
				}
				num = (short)1303511040;
				short num3 = num;
				result = this.a.Contains(parameterName);
				break;
			}
			}
			return result;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000E10C File Offset: 0x0000C30C
		public int IndexOf(string parameterName)
		{
			short num = (short)412549121;
			if (num != 0)
			{
			}
			num = (short)320319204;
			short num2 = num;
			num = (short)1101901540;
			int result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1399652352;
				if (num != 0)
				{
				}
				num = (short)1051394048;
				short num3 = num;
				result = this.a.IndexOf(parameterName);
				break;
			}
			}
			return result;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x0000E1C8 File Offset: 0x0000C3C8
		public void RemoveAt(string parameterName)
		{
			short num = (short)1917976577;
			if (num != 0)
			{
			}
			num = (short)1178561200;
			short num2 = num;
			num = (short)651258544;
			switch (num2 == num)
			{
			default:
			{
				num = (short)264241152;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1905000448;
			if (num != 0)
			{
			}
			this.a.RemoveAt(parameterName);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0000E27C File Offset: 0x0000C47C
		public int IndexOf(object value)
		{
			int num;
			short num2;
			bool flag;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				int result;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1505538974;
						short num3 = num2;
						num2 = (short)1593619358;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2B;
						default:
							num2 = (short)890437632;
							if (num2 != 0)
							{
							}
							result = this.a.IndexOf(((global::Motorola.Data.SQLite.SQLiteParameter)value).a);
							num2 = (short)1682112513;
							if (num2 != 0)
							{
							}
							num2 = (short)1425408003;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						if (flag)
						{
							num2 = (short)1127677952;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = this.a.IndexOf(value);
						num2 = (short)640876546;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						return result;
					case 3:
						return result;
					}
					goto IL_20;
				}
				return result;
			}
			}
			IL_20:
			flag = (value is global::Motorola.Data.SQLite.SQLiteParameter);
			IL_2B:
			num2 = (short)780140544;
			short num4 = num2;
			num2 = (short)2122579969;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000E3DC File Offset: 0x0000C5DC
		public void Insert(int index, object value)
		{
			short num = (short)1990918145;
			if (num != 0)
			{
			}
			int num2;
			bool flag;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_32:
					switch (num2)
					{
					case 0:
					{
						num = (short)1265495874;
						short num3 = num;
						num = (short)1317924674;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7B;
						default:
							num = (short)1747779584;
							if (num != 0)
							{
							}
							this.a.Insert(index, ((global::Motorola.Data.SQLite.SQLiteParameter)value).a);
							num = (short)1471021059;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						if (flag)
						{
							num = (short)998834176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.a.Insert(index, value);
						num = (short)1887567874;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return;
					case 3:
						return;
					}
					goto IL_48;
				}
				return;
			}
			IL_48:
			num = (short)650051584;
			short num4 = num;
			flag = (value is global::Motorola.Data.SQLite.SQLiteParameter);
			IL_7B:
			num = (short)1136590849;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0000E53C File Offset: 0x0000C73C
		public void Remove(object value)
		{
			int num;
			short num2;
			bool flag;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1176222183;
						short num3 = num2;
						num2 = (short)1110882791;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2B;
						default:
							num2 = (short)279183360;
							if (num2 != 0)
							{
							}
							this.a.Remove(((global::Motorola.Data.SQLite.SQLiteParameter)value).a);
							num2 = (short)1695285251;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 1:
						if (flag)
						{
							num2 = (short)1807155200;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						this.a.Remove(value);
						num2 = (short)1231093762;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						goto IL_A9;
					case 3:
						return;
					}
					goto IL_20;
				}
				IL_A9:
				num2 = (short)794099713;
				if (num2 != 0)
				{
				}
				return;
			}
			IL_20:
			flag = (value is global::Motorola.Data.SQLite.SQLiteParameter);
			IL_2B:
			num2 = (short)558891008;
			short num4 = num2;
			num2 = (short)1073545217;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000E69C File Offset: 0x0000C89C
		public void RemoveAt(int index)
		{
			short num = (short)1804597667;
			short num2 = num;
			num = (short)1183054243;
			switch (num2 == num)
			{
			}
			num = (short)1270284288;
			short num3 = num;
			num = (short)1624113152;
			if (num != 0)
			{
			}
			num = (short)1121189889;
			if (num != 0)
			{
			}
			this.a.RemoveAt(index);
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000E758 File Offset: 0x0000C958
		public void CopyTo(global::System.Array array, int index)
		{
			short num = (short)1900365764;
			short num2 = num;
			num = (short)2093107140;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)672464897;
				if (num != 0)
				{
				}
				num = (short)56360960;
				if (num != 0)
				{
				}
				num = (short)1768882176;
				int num3 = (int)num;
				switch (num3)
				{
				}
				break;
			}
			}
			num = (short)1743650816;
			short num4 = num;
			global::System.Collections.Generic.List<global::System.Data.SQLite.SQLiteParameter> list = new global::System.Collections.Generic.List<global::System.Data.SQLite.SQLiteParameter>();
			global::System.Collections.IEnumerator enumerator = array.GetEnumerator();
			try
			{
				num = (short)279969797;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 1:
					{
						bool flag;
						if (flag)
						{
							num = (short)139264003;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B6;
					}
					case 2:
						num = (short)1948909575;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						object obj;
						list.Add(((global::Motorola.Data.SQLite.SQLiteParameter)obj).a);
						num = (short)366936070;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)837484546;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						object obj = enumerator.Current;
						bool flag = obj is global::Motorola.Data.SQLite.SQLiteParameter;
						num = (short)1167917057;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_10F;
						}
						continue;
					case 6:
						goto IL_1B6;
					case 7:
						goto IL_1EE;
					}
					IL_152:
					num = (short)1481965572;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_10F:
					goto IL_152;
					IL_1B6:
					num = (short)832765952;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_1EE:;
			}
			finally
			{
				switch (0)
				{
				case 0:
					goto IL_20D;
				}
				int num3;
				global::System.IDisposable disposable;
				for (;;)
				{
					IL_1FA:
					switch (num3)
					{
					case 0:
						if (disposable != null)
						{
							num = (short)1542848513;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_267;
					case 1:
						disposable.Dispose();
						num = (short)459538434;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_265;
					}
					goto IL_20D;
				}
				IL_265:
				IL_267:
				goto EndFinally_6;
				IL_20D:
				disposable = (enumerator as global::System.IDisposable);
				num = (short)1245315072;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_1FA;
				EndFinally_6:;
			}
			this.a.CopyTo(list.ToArray(), index);
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0000E9FC File Offset: 0x0000CBFC
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			short num = (short)1485733054;
			short num2 = num;
			num = (short)66223294;
			global::System.Collections.IEnumerator enumerator;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1552482305;
				if (num != 0)
				{
				}
				num = (short)257032192;
				if (num != 0)
				{
				}
				num = (short)273285120;
				short num3 = num;
				enumerator = this.a.GetEnumerator();
				break;
			}
			}
			return enumerator;
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000EAC8 File Offset: 0x0000CCC8
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(612896987 + A_1) + (global::System.IntPtr)95 + (global::System.IntPtr)24);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_55;
			}
			IL_22:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_55:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_22;
		}

		// Token: 0x0400005C RID: 92
		internal global::System.Data.SQLite.SQLiteParameterCollection a;
	}
}
