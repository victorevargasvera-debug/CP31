using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Motorola.Common.BinarySerializer
{
	// Token: 0x02000008 RID: 8
	[global::System.Runtime.CompilerServices.b(1)]
	[global::System.Runtime.CompilerServices.a(0)]
	internal class b : global::Motorola.Common.BinarySerializer.IBinarySerializerRecord
	{
		// Token: 0x0600002C RID: 44 RVA: 0x0000703C File Offset: 0x0000523C
		[return: global::System.Runtime.CompilerServices.a(new byte[]
		{
			2,
			1
		})]
		public global::System.Collections.Generic.IList<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo> GetTypes()
		{
			short num = (short)1012531200;
			short num2 = num;
			if (this.a != null)
			{
				num = (short)310562072;
				short num3 = num;
				num = (short)239455512;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1805189120;
					if (num != 0)
					{
					}
					global::System.Collections.Generic.HashSet<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo> source = new global::System.Collections.Generic.HashSet<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo>();
					object a_;
					this.c.TryGetValue(this.a.RootId, out a_);
					this.a(a_, ref source);
					return source.ToList<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo>();
				}
				}
			}
			num = (short)1451491329;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00007120 File Offset: 0x00005320
		public global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult Verify(global::System.Collections.Generic.IEnumerable<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo> userAllowedTypes)
		{
			int a_ = 1;
			short num = (short)2027749376;
			switch (num)
			{
			default:
			{
				num = (short)1193476099;
				int num2 = (int)((global::System.IntPtr)num);
				global::System.Collections.Generic.List<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo> list;
				global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult binarySerializerVerificationResult;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_2EA;
					case 1:
						goto IL_7C;
					case 2:
						goto IL_312;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_60;
						}
						continue;
					case 4:
					{
						global::System.Collections.Generic.IList<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo> types;
						if (types == null)
						{
							num = (short)1406926848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						list = new global::System.Collections.Generic.List<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo>();
						global::System.Collections.Generic.IEnumerator<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo> enumerator = types.GetEnumerator();
						num = (short)125829122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_60:
					if (userAllowedTypes == null)
					{
						num = (short)225968129;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						global::System.Collections.Generic.IList<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo> types = this.GetTypes();
						binarySerializerVerificationResult = new global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult();
						num = (short)1911226372;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_7C:
				num = (short)598409217;
				if (num != 0)
				{
				}
				throw new global::System.ArgumentNullException(global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("햟톡솣풥용삫솭잯ힱ킳솷쪹\ud9bb춽", a_));
				IL_2EA:
				return binarySerializerVerificationResult;
				IL_312:
				try
				{
					num = (short)896663553;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							list.Add(a2.a);
							num = (short)822149126;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_C3;
							}
							continue;
						case 2:
							num = (short)1944322052;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							if (!userAllowedTypes.Any(new global::System.Func<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo, bool>(a2.c)))
							{
								num = (short)844759040;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 4:
							goto IL_1AB;
						case 5:
						{
							global::System.Collections.Generic.IEnumerator<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo> enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)371785730;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo a = enumerator.Current;
							num = (short)496500739;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_C5:
						num = (short)2074148869;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_C3:
						goto IL_C5;
					}
					IL_1AB:
					goto IL_317;
				}
				finally
				{
					num = (short)192413697;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo> enumerator;
						switch (num2)
						{
						case 0:
							goto IL_26A;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_1E2;
							}
							continue;
						case 2:
							enumerator.Dispose();
							num = (short)1570832384;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1E2:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1799842046;
						short num3 = num;
						num = (short)660826366;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1773469696;
							if (num != 0)
							{
							}
							num = (short)635764738;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_26A:;
				}
				return binarySerializerVerificationResult;
				IL_317:
				num = (short)1393491968;
				short num4 = num;
				binarySerializerVerificationResult.NotExpectedTypes = list;
				return binarySerializerVerificationResult;
			}
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00007490 File Offset: 0x00005690
		private bool a(global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo A_0, global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo A_1)
		{
			int a_ = 18;
			short num = (short)1839792495;
			short num2 = num;
			num = (short)160235887;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_158:
				num = (short)651821061;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)978386944;
				if (num != 0)
				{
				}
				num = (short)157876228;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					if (A_1.Type.EndsWith(global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("鮰", a_)))
					{
						num = (short)217841666;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 1:
					return true;
				case 2:
					num = (short)389152771;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_CE;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_94;
					}
					continue;
				case 5:
					return true;
				}
				IL_94:
				if (A_1.Equals(A_0))
				{
					num = (short)608501761;
					num3 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)332529664;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
			return true;
			IL_CE:
			num = (short)312868864;
			short num4 = num;
			num = (short)1314586625;
			if (num != 0)
			{
			}
			bool flag = A_0.Type.StartsWith(A_1.Type.Remove(A_1.Type.Length - 1));
			bool flag2 = A_0.AssemblyName.Equals(A_1.AssemblyName);
			if (flag && flag2)
			{
				goto IL_158;
			}
			return false;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00007664 File Offset: 0x00005864
		[global::System.Runtime.CompilerServices.b(2)]
		private void a(string A_0, string A_1, [global::System.Runtime.CompilerServices.a(1)] ref global::System.Collections.Generic.HashSet<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo> A_2)
		{
			short num = (short)1708589056;
			short num2 = num;
			num = (short)716109465;
			short num3 = num;
			num = (short)1917318809;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1790443520;
				if (num != 0)
				{
				}
				num = (short)1111031810;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						if (this.d.Contains(A_0))
						{
							num = (short)71041025;
							if (num != 0)
							{
							}
							num = (short)1794506761;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_235;
					case 1:
						if (this.g.Any(new global::System.Func<string, bool>(A_0.EndsWith)))
						{
							num = (short)322371587;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)490864644;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_C0;
						}
						continue;
					case 3:
						return;
					case 4:
						if (this.f.Any(new global::System.Func<string, bool>(A_0.StartsWith)))
						{
							num = (short)531431431;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1719664646;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						return;
					case 6:
						if (this.e.Any(new global::System.Func<string, bool>(A_0.StartsWith)))
						{
							num = (short)831913989;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1763704832;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						return;
					case 8:
						goto IL_D7;
					case 9:
						return;
					}
					IL_C0:
					if (A_0 == null)
					{
						num = (short)1238892552;
						num4 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1592983553;
						num4 = (int)((global::System.IntPtr)num);
					}
				}
				IL_D7:
				break;
				IL_235:
				A_2.Add(new global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo(A_0, A_1));
				return;
			}
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000078B8 File Offset: 0x00005AB8
		private void b([global::System.Runtime.CompilerServices.a(2)] object A_0, ref global::System.Collections.Generic.HashSet<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo> A_1)
		{
			short num = (short)635305984;
			short num2 = num;
			num = (short)2072444928;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				string text;
				global::Motorola.Common.BinarySerializer.ClassTypeInfo classTypeInfo;
				switch (num3)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_6E;
					}
					continue;
				case 1:
					if (text != null)
					{
						goto IL_AF;
					}
					return;
				case 2:
				{
					if (classTypeInfo == null)
					{
						goto IL_8D;
					}
					num = (short)197726662;
					short num4 = num;
					num = (short)1752306118;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_AF;
					default:
						num = (short)1604780032;
						if (num != 0)
						{
						}
						num = (short)969670661;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					this.a(text, null, ref A_1);
					num = (short)898367492;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					return;
				case 5:
					this.a(classTypeInfo.TypeName, this.b[classTypeInfo.LibraryId].LibraryName, ref A_1);
					num = (short)1231814663;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					return;
				case 7:
					num = (short)864092161;
					if (num != 0)
					{
					}
					goto IL_8D;
				}
				IL_6E:
				if (A_0 == null)
				{
					num = (short)1655111686;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				classTypeInfo = (A_0 as global::Motorola.Common.BinarySerializer.ClassTypeInfo);
				num = (short)1266089986;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_8D:
				text = (A_0 as string);
				num = (short)2063466497;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_AF:
				num = (short)2133131267;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00007AA4 File Offset: 0x00005CA4
		private void a([global::System.Runtime.CompilerServices.a(2)] object A_0, ref global::System.Collections.Generic.HashSet<global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo> A_1)
		{
			short num = (short)1856372736;
			switch (num)
			{
			default:
			{
				num = (short)1754791942;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.Common.BinarySerializer.BinaryArray<object[]> binaryArray;
					int num3;
					global::Motorola.Common.BinarySerializer.ArraySingleObject arraySingleObject;
					global::Motorola.Common.BinarySerializer.BinaryArray<object[,]> binaryArray2;
					int num4;
					global::Motorola.Common.BinarySerializer.ClassWithId classWithId;
					global::Motorola.Common.BinarySerializer.ClassWithMembersAndTypes classWithMembersAndTypes;
					object a_3;
					int num6;
					global::Motorola.Common.BinarySerializer.MemberReference memberReference;
					global::Motorola.Common.BinarySerializer.SystemClassWithMembersAndTypes systemClassWithMembersAndTypes;
					switch (num2)
					{
					case 0:
						goto IL_2BA;
					case 1:
						return;
					case 2:
						if (binaryArray != null)
						{
							num = (short)425590805;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_489;
					case 3:
						try
						{
							num = (short)1642987521;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.List<object>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1360461826;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									object a_ = enumerator.Current;
									this.a(a_, ref A_1);
									num = (short)156631043;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_A94;
									}
									continue;
								case 2:
									num = (short)746258436;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_B0C;
								}
								IL_A96:
								num = (short)58261504;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_A94:
								goto IL_A96;
							}
							IL_B0C:
							goto IL_519;
						}
						finally
						{
							global::System.Collections.Generic.List<object>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_B1F;
					case 4:
						if (num3 >= binaryArray.Lengths[0])
						{
							num = (short)192675851;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1148321810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_8DC;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_E5;
						}
						continue;
					case 7:
						goto IL_4CF;
					case 8:
						return;
					case 9:
						if (arraySingleObject != null)
						{
							num = (short)1500971030;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_275;
					case 10:
						goto IL_1E0;
					case 11:
						goto IL_489;
					case 12:
					{
						object[,] values = binaryArray2.Values;
						int num5;
						this.a((values != null) ? values[num4, num5] : null, ref A_1);
						num5++;
						num = (short)1422721024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						try
						{
							num = (short)1726087169;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									switch (0)
									{
									case 0:
										goto IL_75F;
									}
									continue;
								case 2:
								{
									global::System.Collections.Generic.List<object>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1513291779;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									object a_2 = enumerator.Current;
									this.a(a_2, ref A_1);
									num = (short)1224212480;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)1988820996;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_7D9;
								}
								IL_78B:
								num = (short)704446466;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_75F:
								goto IL_78B;
							}
							IL_7D9:
							goto IL_A16;
						}
						finally
						{
							global::System.Collections.Generic.List<object>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_7EC;
					case 14:
						if (classWithId != null)
						{
							num = (short)1135083544;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_304;
					case 15:
					{
						string name = classWithMembersAndTypes.ClassInfo.Name;
						this.a(classWithMembersAndTypes.ClassInfo.Name, this.b[classWithMembersAndTypes.LibraryId].LibraryName, ref A_1);
						global::System.Collections.Generic.List<object>.Enumerator enumerator = classWithMembersAndTypes.MemberTypeInfo.AdditionalInfos.GetEnumerator();
						num = (short)584646692;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						if (num4 >= binaryArray2.Lengths[0])
						{
							num = (short)1743650824;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num5 = 0;
						num = (short)666632212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_4CF;
					case 18:
					{
						object[] values2 = binaryArray.Values;
						a_3 = ((values2 != null) ? values2[num3] : null);
						goto IL_7EC;
					}
					case 19:
						goto IL_10A;
					case 20:
						goto IL_2BA;
					case 21:
						this.b(binaryArray.AdditionalInfo, ref A_1);
						num3 = 0;
						num = (short)1957429267;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						num6 = 0;
						num = (short)513343520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_919;
					case 24:
					{
						this.a(this.c[classWithId.MetadataId], ref A_1);
						global::System.Collections.Generic.List<object>.Enumerator enumerator = classWithId.Values.GetEnumerator();
						num = (short)274989094;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						if (memberReference != null)
						{
							num = (short)1492779013;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E0;
					case 26:
						this.b(binaryArray2.AdditionalInfo, ref A_1);
						num4 = 0;
						num = (short)250478609;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (binaryArray2 != null)
						{
							num = (short)1649803290;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 28:
					{
						global::System.Collections.Generic.List<object>.Enumerator enumerator;
						try
						{
							num = (short)2107965441;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)65538;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									object a_4 = enumerator.Current;
									this.b(a_4, ref A_1);
									num = (short)802750467;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_851;
									}
									continue;
								case 2:
									num = (short)167051268;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_8C9;
								}
								IL_853:
								num = (short)159645696;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_851:
								goto IL_853;
							}
							IL_8C9:
							goto IL_559;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_8DC;
						IL_559:
						enumerator = systemClassWithMembersAndTypes.Values.GetEnumerator();
						num = (short)1611399181;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
						if (classWithMembersAndTypes != null)
						{
							num = (short)1665597455;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_519;
					case 30:
					{
						this.a(systemClassWithMembersAndTypes.ClassInfo.Name, null, ref A_1);
						global::System.Collections.Generic.List<object>.Enumerator enumerator = systemClassWithMembersAndTypes.MemberTypeInfo.AdditionalInfos.GetEnumerator();
						num = (short)980025372;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
						goto IL_692;
					case 32:
						goto IL_919;
					case 33:
						if (num6 >= arraySingleObject.ArrayInfo.Length)
						{
							num = (short)670302243;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B1F;
					case 34:
					{
						int num5;
						if (num5 >= binaryArray2.Lengths[1])
						{
							num = (short)1399390239;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2050490380;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
						goto IL_275;
					case 36:
					{
						global::System.Collections.Generic.List<object>.Enumerator enumerator;
						try
						{
							num = (short)1356136449;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									num = (short)1195949477;
									short num7 = num;
									num = (short)425049509;
									switch ((num7 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
									{
										num = (short)196280320;
										if (num != 0)
										{
										}
										if (!enumerator.MoveNext())
										{
											num = (short)1939603458;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										object a_5 = enumerator.Current;
										this.b(a_5, ref A_1);
										num = (short)230359043;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_380;
									}
									continue;
								case 2:
									num = (short)2048458756;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_44F;
								}
								IL_382:
								num = (short)1651376128;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_380:
								goto IL_382;
							}
							IL_44F:
							goto IL_9C5;
						}
						finally
						{
							num = (short)1266614273;
							if (num != 0)
							{
							}
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_489;
						IL_9C5:
						enumerator = classWithMembersAndTypes.Values.GetEnumerator();
						num = (short)103612416;
						short num8 = num;
						num = (short)934674435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 37:
						goto IL_10A;
					case 38:
						try
						{
							num = (short)1654128641;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									switch (0)
									{
									case 0:
										goto IL_602;
									}
									continue;
								case 2:
								{
									global::System.Collections.Generic.List<object>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)361758723;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									object a_6 = enumerator.Current;
									this.a(a_6, ref A_1);
									num = (short)598147072;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)1109917700;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_67F;
								}
								IL_62F:
								num = (short)1348468738;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_602:
								goto IL_62F;
							}
							IL_67F:
							goto IL_304;
						}
						finally
						{
							global::System.Collections.Generic.List<object>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_692;
					case 39:
						if (systemClassWithMembersAndTypes != null)
						{
							num = (short)175767582;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A16;
					}
					IL_E5:
					if (A_0 == null)
					{
						num = (short)875560961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					classWithMembersAndTypes = (A_0 as global::Motorola.Common.BinarySerializer.ClassWithMembersAndTypes);
					num = (short)1277493277;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10A:
					num = (short)1469186052;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E0:
					arraySingleObject = (A_0 as global::Motorola.Common.BinarySerializer.ArraySingleObject);
					num = (short)2145255433;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_275:
					binaryArray = (A_0 as global::Motorola.Common.BinarySerializer.BinaryArray<object[]>);
					num = (short)2005073922;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2BA:
					num = (short)666304546;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_304:
					memberReference = (A_0 as global::Motorola.Common.BinarySerializer.MemberReference);
					num = (short)1497104409;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_489:
					binaryArray2 = (A_0 as global::Motorola.Common.BinarySerializer.BinaryArray<object[,]>);
					num = (short)367525915;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4CF:
					num = (short)275054608;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_519:
					systemClassWithMembersAndTypes = (A_0 as global::Motorola.Common.BinarySerializer.SystemClassWithMembersAndTypes);
					num = (short)1626341415;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_692:
					num4++;
					num = (short)1301086215;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7EC:
					this.a(a_3, ref A_1);
					num3++;
					num = (short)1159331877;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8DC:
					this.a(this.c[memberReference.IdRef], ref A_1);
					num = (short)1200029706;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_919:
					num = (short)623575073;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A16:
					classWithId = (A_0 as global::Motorola.Common.BinarySerializer.ClassWithId);
					num = (short)874971150;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B1F:
					this.a(arraySingleObject.Values[num6], ref A_1);
					num6++;
					num = (short)1457913879;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000086F0 File Offset: 0x000068F0
		public b()
		{
			int a_ = 4;
			this.b = new global::System.Collections.Generic.Dictionary<int, global::Motorola.Common.BinarySerializer.BinaryLibrary>();
			this.c = new global::System.Collections.Generic.Dictionary<int, object>();
			this.d = new global::System.Collections.Generic.HashSet<string>
			{
				typeof(bool).FullName,
				typeof(byte).FullName,
				typeof(char).FullName,
				typeof(double).FullName,
				typeof(decimal).FullName,
				typeof(short).FullName,
				typeof(int).FullName,
				typeof(long).FullName,
				typeof(sbyte).FullName,
				typeof(float).FullName,
				typeof(global::System.TimeSpan).FullName,
				typeof(global::System.DateTime).FullName,
				typeof(ushort).FullName,
				typeof(uint).FullName,
				typeof(ulong).FullName,
				typeof(string).FullName
			};
			this.e = new global::System.Collections.Generic.List<string>
			{
				global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("\udca4풦\udda8캪사膮ﾰ욲\ud9b4\udbb6\ud8b8\ud9ba톼\udabeꇀ黄", a_)
			};
			this.f = new global::System.Collections.Generic.List<string>
			{
				global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("\udca4풦\udda8캪사膮\udcb2\ud9b4\udbb6\udcb8\ud8ba즼횾껀귂뛄軈껊ꏌ꫎ꏐ뫒뛔淪鷘닚뻜ꯞ裠賢诤蛦鯨鋪跬\uddee꫰", a_),
				global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("\udca4풦\udda8캪사膮\udcb2\ud9b4\udbb6\udcb8\ud8ba즼횾껀귂뛄軈껊ꏌ꫎ꏐ뫒뛔淪鋘뻚ꓜ觞胠迢郤苦맨諪蓬鷮釰쇲껴", a_),
				global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("\udca4풦\udda8캪사膮\udcb2\ud9b4\udbb6\udcb8\ud8ba즼횾껀귂뛄軈껊ꏌ꫎ꏐ뫒뛔淪雘맚럜뫞苠韢ꃤ雦鳨諪臬蛮藰諲뛴飶铸诺鳼跾搀焂攄㘆刈", a_),
				global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("\udca4풦\udda8캪사膮\udcb2\ud9b4\udbb6\udcb8\ud8ba즼횾껀귂뛄軈껊ꏌ꫎ꏐ뫒뛔淪鯘ꋚ꧜뫞ꓠ鋢郤蛦藨苪駬雮닰鳲飴蟶飸觺飼跾", a_),
				global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("\udca4풦\udda8캪사膮\udcb2\ud9b4\udbb6\udcb8\ud8ba즼횾껀귂뛄軈껊ꏌ꫎ꏐ뫒뛔淪默뻚돜뫞鏠諢蛤ꋦ飨黪賬菮飰蟲賴듶雸雺跼黾猀昂眄朆㠈倊", a_),
				global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("\udca4풦\udda8캪사膮\udcb2\ud9b4\udbb6\udcb8\ud8ba즼횾껀귂뛄軈껊ꏌ꫎ꏐ뫒뛔淪闘닚껜ꯞ臠틢뻤", a_),
				global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("\udca4풦\udda8캪사膮\udcb2\ud9b4\udbb6\udcb8\ud8ba즼횾껀귂뛄軈껊ꏌ꫎ꏐ뫒뛔淪釘뫚껜럞닠蛢釤蟦\ud8e8냪", a_),
				global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("\udca4풦\udda8캪사膮\udcb2\ud9b4\udbb6\udcb8\ud8ba즼횾껀귂뛄軈껊ꏌ꫎ꏐ뫒뛔淪裘껚룜꫞蓠菢퓤볦", a_),
				global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("\udca4풦\udda8캪사膮\udcb2\ud9b4\udbb6\udcb8\ud8ba즼횾껀귂뛄裈맊뿌껎꣐鿒볔ꓖ귘", a_)
			};
			this.g = new global::System.Collections.Generic.List<string>
			{
				global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("ﲦ", a_),
				global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("覤益", a_),
				global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("", a_)
			};
			base..ctor();
		}

		// Token: 0x04000008 RID: 8
		[global::System.Runtime.CompilerServices.a(2)]
		internal global::Motorola.Common.BinarySerializer.SerializationHeaderRecord a;

		// Token: 0x04000009 RID: 9
		internal global::System.Collections.Generic.Dictionary<int, global::Motorola.Common.BinarySerializer.BinaryLibrary> b;

		// Token: 0x0400000A RID: 10
		[global::System.Runtime.CompilerServices.a(new byte[]
		{
			1,
			2
		})]
		internal global::System.Collections.Generic.Dictionary<int, object> c;

		// Token: 0x0400000B RID: 11
		private readonly global::System.Collections.Generic.HashSet<string> d;

		// Token: 0x0400000C RID: 12
		private readonly global::System.Collections.Generic.List<string> e;

		// Token: 0x0400000D RID: 13
		private readonly global::System.Collections.Generic.List<string> f;

		// Token: 0x0400000E RID: 14
		private readonly global::System.Collections.Generic.List<string> g;

		// Token: 0x0200000A RID: 10
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06000036 RID: 54 RVA: 0x000089C8 File Offset: 0x00006BC8
			[global::System.Runtime.CompilerServices.b(0)]
			internal bool c(global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo A_0)
			{
				short num = (short)1247899759;
				short num2 = num;
				num = (short)1353412719;
				switch (num2 == num)
				{
				default:
				{
					num = (short)188809216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)804126721;
				if (num != 0)
				{
				}
				num = (short)852623360;
				if (num != 0)
				{
				}
				return this.b.a(this.a, A_0);
			}

			// Token: 0x0400000F RID: 15
			[global::System.Runtime.CompilerServices.a(0)]
			public global::Motorola.Common.BinarySerializer.BinarySerializerTypeInfo a;

			// Token: 0x04000010 RID: 16
			[global::System.Runtime.CompilerServices.a(0)]
			public global::Motorola.Common.BinarySerializer.b b;
		}
	}
}
