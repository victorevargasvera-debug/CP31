using System;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Motorola.Data.SQLite
{
	// Token: 0x02000031 RID: 49
	public static class SQLiteDllLoader
	{
		// Token: 0x0600013F RID: 319 RVA: 0x0000EB3C File Offset: 0x0000CD3C
		internal static void c()
		{
			int a_ = 11;
			short num = (short)1748719849;
			short num2 = num;
			num = (short)2022267113;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1351680000;
				short num3 = num;
				num = (short)1094320128;
				if (num != 0)
				{
				}
				string obj = global::Motorola.Data.SQLite.SQLiteParameterCollection.b("๝⅟㙡Ᵽ", a_);
				bool flag = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_AF;
					}
					int num4;
					bool flag2;
					for (;;)
					{
						IL_99:
						switch (num4)
						{
						case 0:
							global::System.AppDomain.CurrentDomain.AssemblyResolve += global::Motorola.Data.SQLite.SQLiteDllLoader.a;
							global::Motorola.Data.SQLite.SQLiteDllLoader.a(new string[]
							{
								global::Motorola.Data.SQLite.SQLiteDllLoader.b()
							});
							global::Motorola.Data.SQLite.SQLiteDllLoader.b = true;
							num = (short)2006581250;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (flag2)
							{
								num = (short)701825024;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_13F;
						case 2:
							goto IL_13F;
						case 3:
							goto IL_157;
						}
						goto IL_AF;
						IL_13F:
						num = (short)724041731;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_157:
					break;
					IL_AF:
					global::System.Threading.Monitor.Enter(obj, ref flag);
					flag2 = !global::Motorola.Data.SQLite.SQLiteDllLoader.b;
					num = (short)967049217;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_99;
				}
				finally
				{
					num = (short)1745616896;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_18C;
							}
							continue;
						case 1:
							num = (short)1600126977;
							if (num != 0)
							{
							}
							global::System.Threading.Monitor.Exit(obj);
							num = (short)1292632066;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_1E7;
						}
						IL_18C:
						if (!flag)
						{
							break;
						}
						num = (short)938803201;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_1E7:;
				}
				break;
			}
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0000ED44 File Offset: 0x0000CF44
		private static string b()
		{
			int a_ = 3;
			short num = (short)1610285056;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4B;
				}
				string result;
				for (;;)
				{
					IL_30:
					string text;
					switch (num2)
					{
					case 0:
						goto IL_96;
					case 1:
						num = (short)1610678272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						if (!global::System.Environment.Is64BitProcess)
						{
							num = (short)1394999297;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1767833600;
						short num3 = num;
						num = (short)933822467;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						text = global::Motorola.Data.SQLite.SQLiteParameterCollection.b("恕汗", a_);
						goto IL_FA;
					case 4:
					{
						num = (short)1165688833;
						if (num != 0)
						{
						}
						num = (short)1825201999;
						short num4 = num;
						num = (short)1323589455;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_96;
						default:
							goto IL_1A1;
						}
						break;
					}
					}
					goto IL_4B;
					IL_FA:
					string str = text;
					string location = global::System.Reflection.Assembly.GetExecutingAssembly().Location;
					string directoryName = global::System.IO.Path.GetDirectoryName(location);
					string text2 = global::System.IO.Path.Combine(directoryName, str + global::Motorola.Data.SQLite.SQLiteParameterCollection.b("ᑕㅗ⹙[", a_));
					result = text2;
					num = (short)1582039044;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_96:
					text = global::Motorola.Data.SQLite.SQLiteParameterCollection.b("敕橗", a_);
					goto IL_FA;
				}
				IL_1A1:
				num = (short)319160320;
				if (num != 0)
				{
				}
				return result;
				IL_4B:
				num = (short)1091698690;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0000EF0C File Offset: 0x0000D10C
		private static byte[] a()
		{
			int num;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				byte[] result;
				for (;;)
				{
					IL_0A:
					byte[] array;
					switch (num)
					{
					case 0:
						global::System.Runtime.CompilerServices.RuntimeHelpers.InitializeArray(array = new byte[16], fieldof(global::a.a).FieldHandle);
						goto IL_14B;
					case 1:
						global::System.Runtime.CompilerServices.RuntimeHelpers.InitializeArray(array = new byte[16], fieldof(global::a.b).FieldHandle);
						goto IL_14B;
					case 2:
						num2 = (short)1470758913;
						if (num2 != 0)
						{
						}
						if (!global::System.Environment.Is64BitProcess)
						{
							num2 = (short)999358468;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)204341248;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						return result;
					case 4:
					{
						num2 = (short)443900641;
						short num3 = num2;
						num2 = (short)1708614369;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num2 = (short)860291072;
							short num4 = num2;
							num2 = (short)1312948224;
							if (num2 != 0)
							{
							}
							num2 = (short)1370947585;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					}
					goto IL_24;
					IL_14B:
					result = array;
					num2 = (short)2053832707;
					num = (int)((global::System.IntPtr)num2);
				}
				return result;
			}
			}
			IL_24:
			num2 = (short)1028587522;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000F080 File Offset: 0x0000D280
		private static global::System.Reflection.Assembly a(object A_0, global::System.ResolveEventArgs A_1)
		{
			int a_ = 9;
			int num;
			bool flag;
			short num2;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				global::System.Reflection.Assembly result;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						return result;
					case 1:
						if (flag)
						{
							num2 = (short)438960131;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						result = null;
						num2 = (short)1557659648;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						return result;
					case 3:
					{
						num2 = (short)1828454401;
						if (num2 != 0)
						{
						}
						num2 = (short)1945031599;
						short num3 = num2;
						num2 = (short)2128991151;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_44;
						default:
						{
							num2 = (short)594345984;
							short num4 = num2;
							num2 = (short)1551630336;
							if (num2 != 0)
							{
							}
							string assemblyFile = global::System.IO.Path.Combine(global::Motorola.Data.SQLite.SQLiteDllLoader.b(), global::Motorola.Data.SQLite.SQLiteParameterCollection.b("ཛ❝፟ᙡţ୥䙧⹩൫ᩭᅯ山❳❵㑷፹ࡻ᭽깿", a_));
							result = global::System.Reflection.Assembly.LoadFrom(assemblyFile);
							num2 = (short)1262354434;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					}
					goto IL_29;
				}
				return result;
			}
			}
			IL_29:
			flag = A_1.Name.Contains(global::Motorola.Data.SQLite.SQLiteParameterCollection.b("ཛ❝፟ᙡţ୥䙧⹩൫ᩭᅯ山❳❵㑷፹ࡻ᭽", a_));
			IL_44:
			num2 = (short)119996417;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000F1F4 File Offset: 0x0000D3F4
		private static void a(params string[] A_0)
		{
			int a_ = 10;
			short num = (short)230490113;
			if (num != 0)
			{
			}
			num = (short)434425691;
			short num2 = num;
			num = (short)1959382875;
			switch (num2 == num)
			{
			}
			num = (short)757202944;
			short num3 = num;
			num = (short)1171587072;
			if (num != 0)
			{
			}
			string[] second = new string[]
			{
				global::System.Environment.GetEnvironmentVariable(global::Motorola.Data.SQLite.SQLiteParameterCollection.b("൜Ṟ㕠⭢", a_)) ?? string.Empty
			};
			string value = string.Join(global::System.IO.Path.PathSeparator.ToString(), A_0.Concat(second).Distinct<string>());
			global::System.Environment.SetEnvironmentVariable(global::Motorola.Data.SQLite.SQLiteParameterCollection.b("൜Ṟ㕠⭢", a_), value);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000F308 File Offset: 0x0000D508
		internal static a a<a>(global::System.Func<a> A_0)
		{
			short num;
			a result;
			for (;;)
			{
				num = (short)1918435329;
				if (num != 0)
				{
				}
				try
				{
					result = A_0();
				}
				catch (global::System.Data.SQLite.SQLiteException parameter)
				{
					throw parameter;
				}
				num = (short)81208763;
				short num2 = num;
				num = (short)1686316475;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_72;
				}
			}
			IL_72:
			num = (short)1685651456;
			short num3 = num;
			num = (short)559742976;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0000F3D8 File Offset: 0x0000D5D8
		internal static void a(global::System.Action A_0)
		{
			short num;
			for (;;)
			{
				try
				{
					A_0();
				}
				catch (global::System.Data.SQLite.SQLiteException parameter)
				{
					throw parameter;
				}
				num = (short)1905888164;
				short num2 = num;
				num = (short)420055972;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_4C;
				}
			}
			IL_4C:
			num = (short)394919936;
			if (num != 0)
			{
			}
			num = (short)543227904;
			short num3 = num;
			num = (short)508035073;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000F4A8 File Offset: 0x0000D6A8
		// Note: this type is marked as 'beforefieldinit'.
		static SQLiteDllLoader()
		{
			short num = (short)1832035203;
			short num2 = num;
			num = (short)850568067;
			switch (num2 == num)
			{
			}
			num = (short)325517312;
			if (num != 0)
			{
			}
			num = (short)1456275456;
			short num3 = num;
			num = (short)358809601;
			if (num != 0)
			{
			}
			global::Motorola.Data.SQLite.SQLiteDllLoader.b = false;
		}

		// Token: 0x0400005D RID: 93
		private const string a = "PATH";

		// Token: 0x0400005E RID: 94
		private static bool b;
	}
}
