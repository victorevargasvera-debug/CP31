using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.Server.EntityModel;
using SharedUtility.Arguments;
using SharedUtility.Attributes;

namespace SharedUtility
{
	// Token: 0x02000007 RID: 7
	public class SC_Manager
	{
		// Token: 0x0600000E RID: 14 RVA: 0x0000269C File Offset: 0x0000089C
		private SC_Manager()
		{
			this.a();
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000F RID: 15 RVA: 0x000026C0 File Offset: 0x000008C0
		public static global::SharedUtility.SC_Manager Instance
		{
			get
			{
				short num = (short)666238977;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						global::SharedUtility.SC_Manager.b = new global::SharedUtility.SC_Manager();
						num = (short)1302593538;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 2:
						goto IL_E5;
					}
					IL_31:
					num = (short)793182208;
					short num3 = num;
					num = (short)783550382;
					short num4 = num;
					num = (short)1502021550;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)140836864;
						if (num != 0)
						{
						}
						if (global::SharedUtility.SC_Manager.b != null)
						{
							goto IL_E7;
						}
						num = (short)156041216;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_E5:
				IL_E7:
				num = (short)1101070337;
				if (num != 0)
				{
				}
				return global::SharedUtility.SC_Manager.b;
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000027E0 File Offset: 0x000009E0
		private void a()
		{
			short num = (short)1310982144;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.IEnumerable<global::System.Type> types = base.GetType().Assembly.GetTypes();
				global::System.Func<global::System.Type, bool> predicate = new global::System.Func<global::System.Type, bool>(global::SharedUtility.SC_Manager.<>c.<>9.a);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::System.Type> enumerator = types.Where(predicate).GetEnumerator();
					try
					{
						num = (short)577961989;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							int num3;
							switch (num2)
							{
							case 0:
								goto IL_F2;
							case 1:
								goto IL_393;
							case 2:
							{
								global::System.Reflection.MethodInfo methodInfo;
								global::System.Collections.Generic.IEnumerable<global::System.Attribute> customAttributes = methodInfo.GetCustomAttributes(typeof(global::Motorola.CommonCPS.Server.EntityModel.ProductCPVersionAttribute));
								global::SharedUtility.a a;
								global::System.Collections.Generic.IEnumerable<global::System.Attribute> customAttributes2;
								a.b = (customAttributes2.First<global::System.Attribute>() as global::SharedUtility.Attributes.ConstraintIDAttribute).Cons_ID;
								global::System.Collections.Generic.IEnumerator<global::System.Attribute> enumerator2 = customAttributes.GetEnumerator();
								num = (short)1353842697;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)2134507526;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Reflection.MethodInfo[] methods = enumerator.Current.GetMethods(global::System.Reflection.BindingFlags.Static | global::System.Reflection.BindingFlags.Public);
								num3 = 0;
								num = (short)566493191;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								goto IL_1A1;
							case 5:
								switch (0)
								{
								case 0:
									goto IL_94;
								}
								continue;
							case 6:
								goto IL_37A;
							case 7:
								goto IL_1A1;
							case 8:
							{
								global::System.Reflection.MethodInfo[] methods;
								if (num3 >= methods.Length)
								{
									num = (short)331546635;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Reflection.MethodInfo methodInfo = methods[num3];
								global::SharedUtility.a a = new global::SharedUtility.a();
								global::System.Collections.Generic.IEnumerable<global::System.Attribute> customAttributes2 = methodInfo.GetCustomAttributes(typeof(global::SharedUtility.Attributes.ConstraintIDAttribute));
								num = (short)652148746;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 9:
							{
								global::SharedUtility.a a;
								try
								{
									num = (short)650706947;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											goto IL_307;
										case 1:
										{
											global::System.Collections.Generic.IEnumerator<global::System.Attribute> enumerator2;
											if (!enumerator2.MoveNext())
											{
												num = (short)505020420;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											global::System.Attribute attribute = enumerator2.Current;
											a.a.Add((attribute as global::Motorola.CommonCPS.Server.EntityModel.ProductCPVersionAttribute).ProductCPVersoin);
											num = (short)1371996162;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										case 3:
											switch (0)
											{
											case 0:
												goto IL_27D;
											}
											continue;
										case 4:
											num = (short)1733165056;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										IL_2B7:
										num = (short)1488191489;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_27D:
										goto IL_2B7;
									}
									IL_307:
									goto IL_1E3;
								}
								finally
								{
									num = (short)1418395649;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										global::System.Collections.Generic.IEnumerator<global::System.Attribute> enumerator2;
										switch (num2)
										{
										case 0:
											enumerator2.Dispose();
											num = (short)1074266114;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_340;
											}
											continue;
										case 2:
											goto IL_377;
										}
										IL_340:
										if (enumerator2 == null)
										{
											break;
										}
										num = (short)962920448;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_377:;
								}
								goto IL_37A;
								IL_1E3:
								global::System.Reflection.MethodInfo methodInfo;
								a.c = methodInfo;
								this.a.Add(a);
								num = (short)1039990784;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 10:
							{
								global::System.Collections.Generic.IEnumerable<global::System.Attribute> customAttributes2;
								if (customAttributes2.Count<global::System.Attribute>() == 1)
								{
									num = (short)993001474;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_F2;
							}
							}
							goto IL_94;
							IL_F2:
							num3++;
							num = (short)1330774020;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_113:
							num = (short)113246211;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_94:
							goto IL_113;
							IL_1A1:
							num = (short)1163132936;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_37A:
							num = (short)1060569089;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_393:
						break;
					}
					finally
					{
						num = (short)864092161;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)2000551938;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_3CA;
								}
								continue;
							case 2:
								goto IL_44D;
							}
							IL_3CA:
							num = (short)940932729;
							short num4 = num;
							num = (short)756317817;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)1355350016;
								if (num != 0)
								{
								}
								if (enumerator == null)
								{
									goto IL_44F;
								}
								num = (short)679018496;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
						}
						IL_44D:
						IL_44F:;
					}
				}
				num = (short)833683457;
				if (num != 0)
				{
				}
				num = (short)430374912;
				short num5 = num;
				return;
			}
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002CEC File Offset: 0x00000EEC
		public global::System.Reflection.MethodInfo GetConstraint(string cons_ID, string productCPVersion)
		{
			short num = (short)2029349835;
			short num2 = num;
			num = (short)523791307;
			switch (num2 == num)
			{
			}
			num = (short)52494337;
			if (num != 0)
			{
			}
			num = (short)1700397056;
			if (num != 0)
			{
			}
			num = (short)1899495424;
			short num3 = num;
			return this.GetConstraint(cons_ID, new global::Motorola.CommonCPS.Server.EntityModel.ProductCPVersionAttribute
			{
				Version = productCPVersion
			});
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002DA8 File Offset: 0x00000FA8
		public global::System.Reflection.MethodInfo GetConstraint(string cons_ID, global::Motorola.CommonCPS.Server.EntityModel.ProductCPVersionAttribute productCPVersion)
		{
			int a_ = 7;
			short num = (short)1156448257;
			if (num != 0)
			{
			}
			num = (short)260654872;
			short num2 = num;
			num = (short)1167410968;
			switch (num2 == num)
			{
			}
			num = (short)1880752128;
			if (num != 0)
			{
			}
			num = (short)430768128;
			short num3 = num;
			global::SharedUtility.SC_Manager.a a = new global::SharedUtility.SC_Manager.a();
			a.a = cons_ID;
			a.b = productCPVersion;
			global::System.Collections.Generic.IEnumerable<global::SharedUtility.a> source = this.a.Where(new global::System.Func<global::SharedUtility.a, bool>(a.c));
			if (source.Count<global::SharedUtility.a>() < 1)
			{
				throw new global::Motorola.Common.CustomException.CommonException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.b("솁꺍﶑ﲗ몙ﾛ캟톡킣풥즧쎩슫\udaad邯즱蒳쮵颷춹햻쪽ꢿ닃ꏅ뫇막ꗋꇍ뻏꿓ꗗ", a_), a.a, a.b.Version));
			}
			if (source.Count<global::SharedUtility.a>() > 1)
			{
				throw new global::Motorola.Common.CustomException.CommonException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.b("쒁겋揄ﾏ﶑뒓ﮕ聯뺝쎟춡쪣향\udca7\ud8a9춫잭\udeaf욱잳隵쎷誹솻麽랿ꯁ냃껅볉꧋볍ꏏ믑믓룕ꇙꏝ컟", a_), a.a, a.b.Version));
			}
			return source.First<global::SharedUtility.a>().c;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002F04 File Offset: 0x00001104
		internal global::System.Reflection.MethodInfo a(string A_0)
		{
			int a_ = 0;
			short num = (short)240779268;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.Generic.IEnumerable<global::SharedUtility.a> source;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (source.Count<global::SharedUtility.a>() == 1)
					{
						num = (short)832176131;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D5;
				case 1:
				{
					num = (short)2134310912;
					short num3 = num;
					num = (short)1935020438;
					short num4 = num;
					num = (short)1192628630;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)117899264;
						if (num != 0)
						{
						}
						break;
					}
					num = (short)1496317954;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_D1;
				case 3:
					goto IL_90;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 5:
					if (source.Count<global::SharedUtility.a>() > 1)
					{
						num = (short)1014824961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1193410560;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_45:
				source = this.a.Where(new global::System.Func<global::SharedUtility.a, bool>(global::SharedUtility.SC_Manager.<>c.<>9.a));
				num = (short)1843200005;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_90:
			num = (short)386793473;
			if (num != 0)
			{
			}
			return source.First<global::SharedUtility.a>().c;
			IL_D1:
			throw new global::Motorola.Common.CustomException.CommonException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::SharedUtility.Arguments.ArgOfConUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType_TypeII.b("㵺ቼ੾ꖄ권ﶒ랖滛햠톢쒤캦잨\udfaa\udeac辮우\udab2솴\udfb6馸햺튼龾釀뇂꫄ꏆ볈꣊만賎臐藒냔ꗖ꫘닚닜뇞쿠", a_), global::System.Array.Empty<object>()));
			IL_1D5:
			return null;
		}

		// Token: 0x04000025 RID: 37
		private global::System.Collections.Generic.List<global::SharedUtility.a> a = new global::System.Collections.Generic.List<global::SharedUtility.a>();

		// Token: 0x04000026 RID: 38
		private static global::SharedUtility.SC_Manager b;

		// Token: 0x02000009 RID: 9
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06000019 RID: 25 RVA: 0x00003354 File Offset: 0x00001554
			internal bool c(global::SharedUtility.a A_0)
			{
				short num = (short)1633288193;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ProductCPVersionSection>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_1A3;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 2:
					{
						num = (short)1409961301;
						short num3 = num;
						num = (short)350375253;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
						{
							bool result;
							return result;
						}
						default:
							num = (short)1474822144;
							if (num != 0)
							{
							}
							try
							{
								num = (short)1656553477;
								num2 = (int)((global::System.IntPtr)num);
								bool result;
								for (;;)
								{
									switch (num2)
									{
									case 0:
										result = true;
										num = (short)187826178;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										if (enumerator.Current.IsMatch(this.b.Product, new global::Motorola.CommonCPS.Server.EntityModel.BLVersion(this.b.Version)))
										{
											num = (short)1376124928;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									case 2:
										goto IL_173;
									case 3:
										goto IL_190;
									case 4:
										if (!enumerator.MoveNext())
										{
											num = (short)499974150;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)743833601;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
										switch (0)
										{
										case 0:
											goto IL_C9;
										}
										continue;
									case 6:
										num = (short)1805975555;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_11E:
									num = (short)2096300036;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_C9:
									goto IL_11E;
								}
								IL_173:
								return result;
								IL_190:
								return false;
							}
							finally
							{
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_1A3;
						}
						break;
					}
					}
					IL_31:
					if (A_0.b == this.a)
					{
						num = (short)1224671232;
						short num4 = num;
						num = (short)664076288;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_1A3:
					num = (short)961019905;
					if (num != 0)
					{
					}
					enumerator = A_0.a.GetEnumerator();
					num = (short)1548681218;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
			}

			// Token: 0x0400002A RID: 42
			public string a;

			// Token: 0x0400002B RID: 43
			public global::Motorola.CommonCPS.Server.EntityModel.ProductCPVersionAttribute b;
		}
	}
}
