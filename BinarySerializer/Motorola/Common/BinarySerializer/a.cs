using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;

namespace Motorola.Common.BinarySerializer
{
	// Token: 0x02000007 RID: 7
	[global::System.Runtime.CompilerServices.a(0)]
	[global::System.Runtime.CompilerServices.b(1)]
	internal class a
	{
		// Token: 0x0600000C RID: 12 RVA: 0x00002548 File Offset: 0x00000748
		private global::System.IO.BinaryReader v()
		{
			int a_ = 16;
			short num = (short)742916097;
			if (num != 0)
			{
			}
			num = (short)1814560768;
			short num2 = num;
			num = (short)1195366563;
			short num3 = num;
			num = (short)621205667;
			switch (num3 == num)
			{
			}
			num = (short)1166868480;
			if (num != 0)
			{
			}
			global::System.IO.BinaryReader binaryReader = this.a;
			if (binaryReader == null)
			{
				throw new global::System.Runtime.Serialization.SerializationException(global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("\udfb0쎲살쎶馸즼춾꓀ꋂ꣄뻈꫊뻌ꇎ꟒ꓖ볘꿚", a_));
			}
			return binaryReader;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000261C File Offset: 0x0000081C
		private global::Motorola.Common.BinarySerializer.b u()
		{
			int a_ = 5;
			short num = (short)1215365121;
			if (num != 0)
			{
			}
			num = (short)828178432;
			short num2 = num;
			num = (short)433404101;
			short num3 = num;
			num = (short)1419524293;
			switch (num3 == num)
			{
			}
			num = (short)1203437568;
			if (num != 0)
			{
			}
			global::Motorola.Common.BinarySerializer.b b = this.b;
			if (b == null)
			{
				throw new global::System.Runtime.Serialization.SerializationException(global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("펥\udca7\udaa9\ud9ab\udaad邯삳쒵춷\ud9b9좻麽랿ꏁ럃ꣅ뻉뷍뗏ꛑ", a_));
			}
			return b;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000026F0 File Offset: 0x000008F0
		public global::Motorola.Common.BinarySerializer.IBinarySerializerRecord a(global::System.IO.BinaryReader A_0)
		{
			short num = (short)676491488;
			short num2 = num;
			num = (short)544960736;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_E2:
				goto IL_E4;
			default:
				num = (short)2127233024;
				if (num != 0)
				{
				}
				num = (short)2065563649;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8E;
				}
				break;
			}
			int num3;
			for (;;)
			{
				IL_7C:
				switch (num3)
				{
				case 0:
					goto IL_E2;
				case 1:
					goto IL_11D;
				case 2:
					if (this.e() is global::Motorola.Common.BinarySerializer.MessageEnd)
					{
						num = (short)248381441;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E4;
				}
				goto IL_8E;
			}
			IL_11D:
			this.a = null;
			this.b = null;
			global::Motorola.Common.BinarySerializer.b result;
			return result;
			IL_8E:
			this.a = A_0;
			result = new global::Motorola.Common.BinarySerializer.b();
			this.b = result;
			num = (short)289734656;
			short num4 = num;
			num = (short)986185728;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_7C;
			IL_E4:
			num = (short)2012086274;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_7C;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000282C File Offset: 0x00000A2C
		private global::Motorola.Common.BinarySerializer.SerializationHeaderRecord t()
		{
			int a_ = 12;
			short num = (short)1416822784;
			short num2 = num;
			num = (short)1009453543;
			short num3 = num;
			num = (short)1986988519;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2130378753;
				if (num != 0)
				{
				}
				num = (short)2025127936;
				if (num != 0)
				{
				}
				global::Motorola.Common.BinarySerializer.SerializationHeaderRecord result = new global::Motorola.Common.BinarySerializer.SerializationHeaderRecord
				{
					RootId = this.b<int>(),
					HeaderId = this.b<int>(),
					MajorVersion = this.b<int>(),
					MinorVersion = this.b<int>()
				};
				if (this.u().a == null)
				{
					this.u().a = result;
					return result;
				}
				break;
			}
			}
			throw new global::System.Runtime.Serialization.SerializationException(global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("슬\uddae풰鎲솴\udfb6\ud8b8햺鶼킾꿀ꛂ迆곈꫊꧌꫎ꏐ蟔닖뫘듚꿜믞쇠諢诤铦胨迪裬쿮苰蟲蟴鋶飸雺", a_));
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002944 File Offset: 0x00000B44
		private global::Motorola.Common.BinarySerializer.BinaryLibrary s()
		{
			short num = (short)797457747;
			short num2 = num;
			num = (short)2074164563;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1563295744;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1970470913;
			if (num != 0)
			{
			}
			num = (short)1271791616;
			if (num != 0)
			{
			}
			global::Motorola.Common.BinarySerializer.BinaryLibrary binaryLibrary = new global::Motorola.Common.BinarySerializer.BinaryLibrary
			{
				LibraryId = this.b<int>(),
				LibraryName = this.b<string>()
			};
			this.u().b.Add(binaryLibrary.LibraryId, binaryLibrary);
			return binaryLibrary;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002A24 File Offset: 0x00000C24
		private global::Motorola.Common.BinarySerializer.BinaryObjectString r()
		{
			short num = (short)1716922435;
			short num2 = num;
			num = (short)2036869187;
			switch (num2 == num)
			{
			default:
			{
				num = (short)347275264;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1763115009;
			if (num != 0)
			{
			}
			num = (short)623706112;
			if (num != 0)
			{
			}
			global::Motorola.Common.BinarySerializer.BinaryObjectString binaryObjectString = new global::Motorola.Common.BinarySerializer.BinaryObjectString
			{
				ObjectId = this.b<int>(),
				Value = this.b<string>()
			};
			this.u().c.Add(binaryObjectString.ObjectId, binaryObjectString);
			return binaryObjectString;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002B04 File Offset: 0x00000D04
		private global::Motorola.Common.BinarySerializer.MemberReference q()
		{
			short num = (short)2131099649;
			if (num != 0)
			{
			}
			num = (short)1701969920;
			short num2 = num;
			num = (short)279315677;
			short num3 = num;
			num = (short)757466333;
			switch (num3 == num)
			{
			}
			num = (short)552796160;
			if (num != 0)
			{
			}
			return new global::Motorola.Common.BinarySerializer.MemberReference
			{
				IdRef = this.b<int>()
			};
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002BC0 File Offset: 0x00000DC0
		private global::Motorola.Common.BinarySerializer.MemberPrimitiveTyped p()
		{
			short num = (short)450679468;
			short num2 = num;
			num = (short)1768411820;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2027094016;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1339162624;
			if (num != 0)
			{
			}
			num = (short)321191937;
			if (num != 0)
			{
			}
			global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration primitiveTypeEnumeration = (global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration)this.b<byte>();
			return new global::Motorola.Common.BinarySerializer.MemberPrimitiveTyped
			{
				PrimitiveTypeEnum = primitiveTypeEnumeration,
				Value = this.a(primitiveTypeEnumeration)
			};
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002C8C File Offset: 0x00000E8C
		private global::Motorola.Common.BinarySerializer.ObjectNullMultiple o()
		{
			short num = (short)868153612;
			short num2 = num;
			num = (short)1997535500;
			switch (num2 == num)
			{
			default:
			{
				num = (short)787152896;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)122486785;
			if (num != 0)
			{
			}
			num = (short)1020264448;
			if (num != 0)
			{
			}
			return new global::Motorola.Common.BinarySerializer.ObjectNullMultiple
			{
				Count = (int)this.b<byte>()
			};
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002D48 File Offset: 0x00000F48
		private global::Motorola.Common.BinarySerializer.ObjectNullMultiple n()
		{
			short num = (short)122514059;
			short num2 = num;
			num = (short)1618111115;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1777467392;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)407109632;
			if (num != 0)
			{
			}
			num = (short)687734785;
			if (num != 0)
			{
			}
			return new global::Motorola.Common.BinarySerializer.ObjectNullMultiple
			{
				Count = this.b<int>()
			};
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002E08 File Offset: 0x00001008
		private global::Motorola.Common.BinarySerializer.ClassWithMembersAndTypes m()
		{
			short num = (short)1683234451;
			short num2 = num;
			num = (short)281681555;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1689321472;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)659030017;
			if (num != 0)
			{
			}
			num = (short)504037376;
			if (num != 0)
			{
			}
			global::Motorola.Common.BinarySerializer.ClassWithMembersAndTypes classWithMembersAndTypes = new global::Motorola.Common.BinarySerializer.ClassWithMembersAndTypes();
			classWithMembersAndTypes.ClassInfo = this.c();
			classWithMembersAndTypes.MemberTypeInfo = this.b(classWithMembersAndTypes.ClassInfo.MemberCount);
			classWithMembersAndTypes.LibraryId = this.b<int>();
			classWithMembersAndTypes.Values = this.a(classWithMembersAndTypes.MemberTypeInfo);
			this.u().c.Add(classWithMembersAndTypes.ClassInfo.ObjectId, classWithMembersAndTypes);
			return classWithMembersAndTypes;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002F14 File Offset: 0x00001114
		private global::Motorola.Common.BinarySerializer.SystemClassWithMembersAndTypes l()
		{
			short num = (short)677573302;
			short num2 = num;
			num = (short)2006839990;
			switch (num2 == num)
			{
			default:
			{
				num = (short)566558720;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)151191553;
			if (num != 0)
			{
			}
			num = (short)691142656;
			if (num != 0)
			{
			}
			global::Motorola.Common.BinarySerializer.SystemClassWithMembersAndTypes systemClassWithMembersAndTypes = new global::Motorola.Common.BinarySerializer.SystemClassWithMembersAndTypes();
			systemClassWithMembersAndTypes.ClassInfo = this.c();
			systemClassWithMembersAndTypes.MemberTypeInfo = this.b(systemClassWithMembersAndTypes.ClassInfo.MemberCount);
			systemClassWithMembersAndTypes.Values = this.a(systemClassWithMembersAndTypes.MemberTypeInfo);
			this.u().c.Add(systemClassWithMembersAndTypes.ClassInfo.ObjectId, systemClassWithMembersAndTypes);
			return systemClassWithMembersAndTypes;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00003014 File Offset: 0x00001214
		private global::Motorola.Common.BinarySerializer.ClassWithId k()
		{
			short num = (short)206346471;
			short num2 = num;
			num = (short)1014143207;
			global::Motorola.Common.BinarySerializer.ClassWithId classWithId;
			global::Motorola.Common.BinarySerializer.SystemClassWithMembersAndTypes systemClassWithMembersAndTypes;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_ED:
				classWithId.Values = this.a(systemClassWithMembersAndTypes.MemberTypeInfo);
				num = (short)1124859905;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
			{
				num = (short)1973878784;
				short num4 = num;
				num = (short)1612185600;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_94;
				}
				break;
			}
			}
			for (;;)
			{
				IL_7E:
				switch (num3)
				{
				case 0:
				{
					object obj = this.u().c[classWithId.MetadataId];
					global::Motorola.Common.BinarySerializer.ClassWithMembersAndTypes classWithMembersAndTypes = obj as global::Motorola.Common.BinarySerializer.ClassWithMembersAndTypes;
					if (classWithMembersAndTypes != null)
					{
						classWithId.Values = this.a(classWithMembersAndTypes.MemberTypeInfo);
					}
					systemClassWithMembersAndTypes = (obj as global::Motorola.Common.BinarySerializer.SystemClassWithMembersAndTypes);
					num = (short)1218772995;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					goto IL_118;
				case 2:
					goto IL_178;
				case 3:
					if (systemClassWithMembersAndTypes != null)
					{
						num = (short)1821310977;
						if (num != 0)
						{
						}
						num = (short)277676034;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_191;
				}
				goto IL_94;
			}
			IL_118:
			goto IL_191;
			IL_178:
			goto IL_ED;
			IL_191:
			this.u().c.Add(classWithId.ObjectId, classWithId);
			return classWithId;
			IL_94:
			classWithId = new global::Motorola.Common.BinarySerializer.ClassWithId();
			classWithId.ObjectId = this.b<int>();
			classWithId.MetadataId = this.b<int>();
			num = (short)1424228352;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_7E;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000031CC File Offset: 0x000013CC
		private global::Motorola.Common.BinarySerializer.ArrayInfo j()
		{
			short num = (short)1814626305;
			if (num != 0)
			{
			}
			num = (short)792592384;
			short num2 = num;
			num = (short)371871740;
			short num3 = num;
			num = (short)1415270396;
			switch (num3 == num)
			{
			}
			num = (short)1450442752;
			if (num != 0)
			{
			}
			return new global::Motorola.Common.BinarySerializer.ArrayInfo
			{
				ObjectId = this.b<int>(),
				Length = this.b<int>()
			};
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003290 File Offset: 0x00001490
		private global::Motorola.Common.BinarySerializer.ArraySinglePrimitive i()
		{
			int a_ = 10;
			short num = (short)192020480;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)430782480;
				short num3 = num;
				num = (short)814954512;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_1DA:
					num = (short)1286930444;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)753664000;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_CB;
					}
					break;
				}
				global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration primitiveTypeEnumeration;
				global::Motorola.Common.BinarySerializer.ArrayInfo arrayInfo;
				global::Motorola.Common.BinarySerializer.ArraySinglePrimitive arraySinglePrimitive;
				for (;;)
				{
					IL_7C:
					switch (num2)
					{
					case 0:
						goto IL_2CD;
					case 1:
						goto IL_337;
					case 2:
						switch (primitiveTypeEnumeration)
						{
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Boolean:
							arraySinglePrimitive = new global::Motorola.Common.BinarySerializer.ArraySinglePrimitive<bool[]>
							{
								Values = this.a<bool>(arrayInfo.Length)
							};
							num = (short)1057423376;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Byte:
							arraySinglePrimitive = new global::Motorola.Common.BinarySerializer.ArraySinglePrimitive<byte[]>
							{
								Values = this.a<byte>(arrayInfo.Length)
							};
							num = (short)107216911;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Char:
							goto IL_1C2;
						case (global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration)4:
							goto IL_371;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Decimal:
							arraySinglePrimitive = new global::Motorola.Common.BinarySerializer.ArraySinglePrimitive<decimal[]>
							{
								Values = this.a<decimal>(arrayInfo.Length)
							};
							num = (short)562364430;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Double:
							arraySinglePrimitive = new global::Motorola.Common.BinarySerializer.ArraySinglePrimitive<double[]>
							{
								Values = this.a<double>(arrayInfo.Length)
							};
							num = (short)1806106625;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Int16:
							arraySinglePrimitive = new global::Motorola.Common.BinarySerializer.ArraySinglePrimitive<short[]>
							{
								Values = this.a<short>(arrayInfo.Length)
							};
							num = (short)324599815;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Int32:
							arraySinglePrimitive = new global::Motorola.Common.BinarySerializer.ArraySinglePrimitive<int[]>
							{
								Values = this.a<int>(arrayInfo.Length)
							};
							num = (short)518586381;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Int64:
						{
							arraySinglePrimitive = new global::Motorola.Common.BinarySerializer.ArraySinglePrimitive<long[]>
							{
								Values = this.a<long>(arrayInfo.Length)
							};
							num = (short)1251868672;
							short num4 = num;
							num = (short)794034185;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.SByte:
							arraySinglePrimitive = new global::Motorola.Common.BinarySerializer.ArraySinglePrimitive<sbyte[]>
							{
								Values = this.a<sbyte>(arrayInfo.Length)
							};
							num = (short)383582216;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Single:
							arraySinglePrimitive = new global::Motorola.Common.BinarySerializer.ArraySinglePrimitive<float[]>
							{
								Values = this.a<float>(arrayInfo.Length)
							};
							num = (short)175374353;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.TimeSpan:
							arraySinglePrimitive = new global::Motorola.Common.BinarySerializer.ArraySinglePrimitive<global::System.TimeSpan[]>
							{
								Values = this.a<global::System.TimeSpan>(arrayInfo.Length)
							};
							num = (short)1231814659;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.DateTime:
							arraySinglePrimitive = new global::Motorola.Common.BinarySerializer.ArraySinglePrimitive<global::System.DateTime[]>
							{
								Values = this.a<global::System.DateTime>(arrayInfo.Length)
							};
							num = (short)419233802;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.UInt16:
							arraySinglePrimitive = new global::Motorola.Common.BinarySerializer.ArraySinglePrimitive<ushort[]>
							{
								Values = this.a<ushort>(arrayInfo.Length)
							};
							num = (short)1759838213;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.UInt32:
							arraySinglePrimitive = new global::Motorola.Common.BinarySerializer.ArraySinglePrimitive<uint[]>
							{
								Values = this.a<uint>(arrayInfo.Length)
							};
							num = (short)425328644;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.UInt64:
							arraySinglePrimitive = new global::Motorola.Common.BinarySerializer.ArraySinglePrimitive<ulong[]>
							{
								Values = this.a<ulong>(arrayInfo.Length)
							};
							num = (short)974258176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)1395130374;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 3:
						goto IL_187;
					case 4:
						goto IL_229;
					case 5:
						goto IL_36C;
					case 6:
						num = (short)449118219;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_46E;
					case 8:
						goto IL_1BD;
					case 9:
						goto IL_4CC;
					case 10:
						goto IL_296;
					case 11:
						goto IL_3DD;
					case 12:
						goto IL_1F4;
					case 13:
						goto IL_302;
					case 14:
						goto IL_3C0;
					case 15:
						goto IL_439;
					case 16:
						goto IL_260;
					case 17:
						goto IL_501;
					}
					goto IL_CB;
				}
				IL_187:
				IL_1BD:
				goto IL_506;
				IL_1C2:
				arraySinglePrimitive = new global::Motorola.Common.BinarySerializer.ArraySinglePrimitive<char[]>
				{
					Values = this.a<char>(arrayInfo.Length)
				};
				goto IL_1DA;
				IL_1F4:
				IL_229:
				IL_260:
				IL_296:
				IL_2CD:
				IL_302:
				IL_337:
				IL_36C:
				goto IL_506;
				IL_371:
				throw new global::System.Runtime.Serialization.SerializationException(string.Format(global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("令\ud9aa쒬슮\ud8b0잲\udcb4솶\udcb8鮺욾뇀ꛂ볆杻뛊꧎뻐ꇒ뛖ꯘ꧚볜ꛞ鋠쏢賤铦짨藪苬鯮퇰髲飴蟶闸黺郼髾漀眂怄挆", a_), primitiveTypeEnumeration));
				IL_3C0:
				goto IL_506;
				IL_3DD:
				num = (short)712114177;
				if (num != 0)
				{
				}
				goto IL_371;
				IL_439:
				IL_46E:
				IL_4CC:
				IL_501:
				IL_506:
				global::Motorola.Common.BinarySerializer.ArraySinglePrimitive arraySinglePrimitive2 = arraySinglePrimitive;
				arraySinglePrimitive2.ArrayInfo = arrayInfo;
				arraySinglePrimitive2.Type = primitiveTypeEnumeration;
				this.u().c.Add(arraySinglePrimitive2.ArrayInfo.ObjectId, arraySinglePrimitive2);
				return arraySinglePrimitive2;
				IL_CB:
				arrayInfo = this.j();
				primitiveTypeEnumeration = (global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration)this.b<byte>();
				num = (short)1656946690;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_7C;
			}
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000037D0 File Offset: 0x000019D0
		private global::Motorola.Common.BinarySerializer.ArraySingleObject h()
		{
			short num = (short)1837760512;
			short num2 = num;
			num = (short)472540719;
			short num3 = num;
			num = (short)1190159919;
			switch (num3 == num)
			{
			}
			num = (short)1013186560;
			if (num != 0)
			{
			}
			num = (short)1325203457;
			if (num != 0)
			{
			}
			global::Motorola.Common.BinarySerializer.ArraySingleObject arraySingleObject = new global::Motorola.Common.BinarySerializer.ArraySingleObject();
			arraySingleObject.ArrayInfo = this.j();
			arraySingleObject.Values = this.c(arraySingleObject.ArrayInfo.Length);
			this.u().c.Add(arraySingleObject.ArrayInfo.ObjectId, arraySingleObject);
			return arraySingleObject;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000038C0 File Offset: 0x00001AC0
		private global::Motorola.Common.BinarySerializer.ArraySingleString g()
		{
			short num = (short)1456799744;
			short num2 = num;
			num = (short)103907639;
			short num3 = num;
			num = (short)693010743;
			switch (num3 == num)
			{
			}
			num = (short)1119354880;
			if (num != 0)
			{
			}
			num = (short)169017345;
			if (num != 0)
			{
			}
			global::Motorola.Common.BinarySerializer.ArraySingleString arraySingleString = new global::Motorola.Common.BinarySerializer.ArraySingleString();
			arraySingleString.ArrayInfo = this.j();
			arraySingleString.Values = this.c(arraySingleString.ArrayInfo.Length);
			this.u().c.Add(arraySingleString.ArrayInfo.ObjectId, arraySingleString);
			return arraySingleString;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000039B0 File Offset: 0x00001BB0
		private global::Motorola.Common.BinarySerializer.BinaryArray f()
		{
			int a_ = 2;
			short num = (short)952631296;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_15B;
				}
				object obj;
				global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration primitiveTypeEnumeration;
				global::Motorola.Common.BinarySerializer.BinaryArrayTypeEnumeration binaryArrayTypeEnumeration;
				global::Motorola.Common.BinarySerializer.BinaryTypeEnumeration binaryTypeEnumeration;
				global::System.Collections.Generic.List<int> list;
				int num5;
				global::Motorola.Common.BinarySerializer.BinaryArray binaryArray2;
				global::System.Collections.Generic.List<int> list2;
				int num7;
				for (;;)
				{
					IL_30:
					global::Motorola.Common.BinarySerializer.BinaryArray binaryArray;
					int num6;
					switch (num2)
					{
					case 0:
						goto IL_EBA;
					case 1:
						num = (short)306642956;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_EBA;
					case 3:
						goto IL_995;
					case 4:
						goto IL_995;
					case 5:
						num = (short)617218114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_995;
					case 7:
						goto IL_995;
					case 8:
						goto IL_EBA;
					case 9:
						goto IL_995;
					case 10:
						num = (short)436142136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						primitiveTypeEnumeration = (global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration)obj;
						num = (short)1776943151;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (binaryArrayTypeEnumeration == global::Motorola.Common.BinarySerializer.BinaryArrayTypeEnumeration.SingleOffset)
						{
							num = (short)266076191;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A7E;
					case 13:
						num = (short)1240072252;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_995;
					case 15:
						goto IL_995;
					case 16:
						goto IL_EBA;
					case 17:
						if (binaryTypeEnumeration == global::Motorola.Common.BinarySerializer.BinaryTypeEnumeration.Primitive)
						{
							num = (short)104595497;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1704656922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num = (short)309264453;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_EBA;
					case 20:
						goto IL_995;
					case 21:
						goto IL_995;
					case 22:
						goto IL_995;
					case 23:
						goto IL_EBA;
					case 24:
						switch (primitiveTypeEnumeration)
						{
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Boolean:
							binaryArray = new global::Motorola.Common.BinarySerializer.BinaryArray<bool[,]>
							{
								Values = this.a<bool>(list[0], list[1])
							};
							num = (short)1840381973;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Byte:
							binaryArray = new global::Motorola.Common.BinarySerializer.BinaryArray<byte[,]>
							{
								Values = this.a<byte>(list[0], list[1])
							};
							num = (short)1021247495;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Char:
							binaryArray = new global::Motorola.Common.BinarySerializer.BinaryArray<char[,]>
							{
								Values = this.a<char>(list[0], list[1])
							};
							num = (short)565575702;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case (global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration)4:
							goto IL_C40;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Decimal:
							binaryArray = new global::Motorola.Common.BinarySerializer.BinaryArray<decimal[,]>
							{
								Values = this.a<decimal>(list[0], list[1])
							};
							num = (short)341442632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Double:
							binaryArray = new global::Motorola.Common.BinarySerializer.BinaryArray<double[,]>
							{
								Values = this.a<double>(list[0], list[1])
							};
							num = (short)1172832281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Int16:
							binaryArray = new global::Motorola.Common.BinarySerializer.BinaryArray<short[,]>
							{
								Values = this.a<short>(list[0], list[1])
							};
							num = (short)761790473;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Int32:
							binaryArray = new global::Motorola.Common.BinarySerializer.BinaryArray<int[,]>
							{
								Values = this.a<int>(list[0], list[1])
							};
							num = (short)1010368518;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Int64:
							binaryArray = new global::Motorola.Common.BinarySerializer.BinaryArray<long[,]>
							{
								Values = this.a<long>(list[0], list[1])
							};
							num = (short)392364047;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.SByte:
							binaryArray = new global::Motorola.Common.BinarySerializer.BinaryArray<sbyte[,]>
							{
								Values = this.a<sbyte>(list[0], list[1])
							};
							num = (short)120848426;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Single:
						{
							binaryArray = new global::Motorola.Common.BinarySerializer.BinaryArray<float[,]>
							{
								Values = this.a<float>(list[0], list[1])
							};
							num = (short)1347420160;
							short num3 = num;
							num = (short)1189478451;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.TimeSpan:
						{
							num = (short)980954175;
							short num4 = num;
							num = (short)1992305727;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_999;
							default:
								num = (short)1622867968;
								if (num != 0)
								{
								}
								binaryArray = new global::Motorola.Common.BinarySerializer.BinaryArray<global::System.TimeSpan[,]>
								{
									Values = this.a<global::System.TimeSpan>(list[0], list[1])
								};
								num = (short)100401156;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.DateTime:
							binaryArray = new global::Motorola.Common.BinarySerializer.BinaryArray<global::System.DateTime[,]>
							{
								Values = this.a<global::System.DateTime>(list[0], list[1])
							};
							num = (short)1224081446;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.UInt16:
							binaryArray = new global::Motorola.Common.BinarySerializer.BinaryArray<ushort[,]>
							{
								Values = this.a<ushort>(list[0], list[1])
							};
							num = (short)468189204;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.UInt32:
							binaryArray = new global::Motorola.Common.BinarySerializer.BinaryArray<uint[,]>
							{
								Values = this.a<uint>(list[0], list[1])
							};
							num = (short)464781315;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.UInt64:
							binaryArray = new global::Motorola.Common.BinarySerializer.BinaryArray<ulong[,]>
							{
								Values = this.a<ulong>(list[0], list[1])
							};
							num = (short)1289289742;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)498794506;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 25:
						goto IL_995;
					case 26:
						if (num5 != 1)
						{
							num = (short)498466821;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						binaryArray2 = new global::Motorola.Common.BinarySerializer.BinaryArray<object[]>
						{
							Values = this.c(list[0])
						};
						num = (short)1346699291;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						goto IL_F45;
					case 28:
						goto IL_EBA;
					case 29:
						goto IL_EBA;
					case 30:
						if (binaryArrayTypeEnumeration != global::Motorola.Common.BinarySerializer.BinaryArrayTypeEnumeration.RectangularOffset)
						{
							num = (short)1232470017;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DE6;
					case 31:
						goto IL_DE6;
					case 32:
						goto IL_9B2;
					case 33:
						goto IL_ED7;
					case 34:
						num = (short)669843486;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						list2 = new global::System.Collections.Generic.List<int>();
						num = (short)1894776871;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						goto IL_EBA;
					case 37:
						goto IL_EBA;
					case 38:
						goto IL_995;
					case 39:
						if (binaryArrayTypeEnumeration != global::Motorola.Common.BinarySerializer.BinaryArrayTypeEnumeration.JaggedOffset)
						{
							num = (short)1999962146;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DE6;
					case 40:
						num = (short)555155505;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						num = (short)1295974471;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						goto IL_995;
					case 43:
						goto IL_EBA;
					case 44:
						num = (short)1504575555;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						goto IL_EBA;
					case 46:
						goto IL_D4F;
					case 47:
						if (num5 == 1)
						{
							num = (short)214302772;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)620167223;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						if (num6 >= num5)
						{
							num = (short)581042237;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						list2.Add(this.b<int>());
						num6++;
						num = (short)309067834;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						goto IL_A42;
					case 50:
						goto IL_9E9;
					case 51:
						goto IL_995;
					case 52:
						num = (short)1010892859;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
						goto IL_9E9;
					case 54:
						goto IL_4A4;
					case 55:
						if (num5 == 2)
						{
							num = (short)301400121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_44B;
					case 56:
						goto IL_DE1;
					case 57:
						num = (short)249954328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
						goto IL_2D2;
					case 59:
						switch (primitiveTypeEnumeration)
						{
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Boolean:
							binaryArray = new global::Motorola.Common.BinarySerializer.BinaryArray<bool[]>
							{
								Values = this.a<bool>(list[0])
							};
							num = (short)2046296083;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Byte:
							binaryArray = new global::Motorola.Common.BinarySerializer.BinaryArray<byte[]>
							{
								Values = this.a<byte>(list[0])
							};
							num = (short)1109262381;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Char:
							binaryArray = new global::Motorola.Common.BinarySerializer.BinaryArray<char[]>
							{
								Values = this.a<char>(list[0])
							};
							num = (short)1787887645;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case (global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration)4:
							goto IL_824;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Decimal:
							binaryArray = new global::Motorola.Common.BinarySerializer.BinaryArray<decimal[]>
							{
								Values = this.a<decimal>(list[0])
							};
							num = (short)271188004;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Double:
							binaryArray = new global::Motorola.Common.BinarySerializer.BinaryArray<double[]>
							{
								Values = this.a<double>(list[0])
							};
							num = (short)490602564;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Int16:
							binaryArray = new global::Motorola.Common.BinarySerializer.BinaryArray<short[]>
							{
								Values = this.a<short>(list[0])
							};
							num = (short)1723138091;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Int32:
							binaryArray = new global::Motorola.Common.BinarySerializer.BinaryArray<int[]>
							{
								Values = this.a<int>(list[0])
							};
							num = (short)1848442882;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Int64:
							binaryArray = new global::Motorola.Common.BinarySerializer.BinaryArray<long[]>
							{
								Values = this.a<long>(list[0])
							};
							num = (short)613285911;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.SByte:
							binaryArray = new global::Motorola.Common.BinarySerializer.BinaryArray<sbyte[]>
							{
								Values = this.a<sbyte>(list[0])
							};
							num = (short)1605697599;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Single:
							binaryArray = new global::Motorola.Common.BinarySerializer.BinaryArray<float[]>
							{
								Values = this.a<float>(list[0])
							};
							num = (short)548470821;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.TimeSpan:
							binaryArray = new global::Motorola.Common.BinarySerializer.BinaryArray<global::System.TimeSpan[]>
							{
								Values = this.a<global::System.TimeSpan>(list[0])
							};
							num = (short)1962082332;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.DateTime:
							binaryArray = new global::Motorola.Common.BinarySerializer.BinaryArray<global::System.DateTime[]>
							{
								Values = this.a<global::System.DateTime>(list[0])
							};
							num = (short)747700240;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.UInt16:
							binaryArray = new global::Motorola.Common.BinarySerializer.BinaryArray<ushort[]>
							{
								Values = this.a<ushort>(list[0])
							};
							num = (short)1520959496;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.UInt32:
							binaryArray = new global::Motorola.Common.BinarySerializer.BinaryArray<uint[]>
							{
								Values = this.a<uint>(list[0])
							};
							num = (short)1755316224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.UInt64:
							binaryArray = new global::Motorola.Common.BinarySerializer.BinaryArray<ulong[]>
							{
								Values = this.a<ulong>(list[0])
							};
							num = (short)901120062;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)1730740268;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 60:
						if (binaryArrayTypeEnumeration != global::Motorola.Common.BinarySerializer.BinaryArrayTypeEnumeration.RectangularOffset)
						{
							num = (short)2021785618;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_50F;
					case 61:
						goto IL_A7E;
					case 62:
						goto IL_EBA;
					case 63:
						goto IL_EBA;
					case 64:
						if (num7 >= num5)
						{
							num = (short)2093547555;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						list.Add(this.b<int>());
						num7++;
						num = (short)240255026;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						if (binaryArrayTypeEnumeration != global::Motorola.Common.BinarySerializer.BinaryArrayTypeEnumeration.JaggedOffset)
						{
							num = (short)1751908365;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_50F;
					case 66:
						if (num5 != 2)
						{
							num = (short)1066467368;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						binaryArray2 = new global::Motorola.Common.BinarySerializer.BinaryArray<object[,]>
						{
							Values = this.b(list[0], list[1])
						};
						num = (short)440664118;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
						goto IL_583;
					case 68:
						goto IL_EBA;
					case 69:
						if (binaryArrayTypeEnumeration == global::Motorola.Common.BinarySerializer.BinaryArrayTypeEnumeration.SingleOffset)
						{
							num = (short)408617006;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1410007057;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
						goto IL_2D2;
					case 71:
						if (obj is global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration)
						{
							num = (short)448987147;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B0;
					case 72:
						goto IL_995;
					}
					goto IL_15B;
					IL_2D2:
					num = (short)267518000;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_999:
					num = (short)410058784;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_995:
					binaryArray2 = binaryArray;
					goto IL_999;
					IL_9E9:
					num = (short)92143680;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A7E:
					binaryTypeEnumeration = (global::Motorola.Common.BinarySerializer.BinaryTypeEnumeration)this.b<byte>();
					obj = this.a(binaryTypeEnumeration);
					num = (short)58261569;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DE6:
					num6 = 0;
					num = (short)1202585670;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_EBA:
					binaryArray2 = binaryArray;
					num = (short)365625377;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_44B:
				throw new global::System.Runtime.Serialization.SerializationException(string.Format(global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("횢햤힦욨\ud9aa\ud9ac쪮햰鎲횶ힸ킺鶼횾꿀蟄껆ꟈ꫊뿌뛎鋒꟔ꗖ룘ꋚ﷜뛞鋠쏢諤触藨鋪췬\udeee퇰鋲鯴鏶\ud9f8짺\uddfc鷾琀眂┄怆昈缊ⴌ琎ℐ渒", a_), num5));
				IL_4A4:
				goto IL_FE5;
				IL_50F:
				throw new global::System.Runtime.Serialization.SerializationException(string.Format(global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("쪢쮤욦\udba8튪趬쎰솲풴캶馸풺\udbbc龾뗀뫂뗄ꋆ냊﷌닎뫒ꛔ럘듚꧜￞裠転闤详賨蛪裬臮藰雲釴", a_), binaryArrayTypeEnumeration));
				IL_583:
				num = (short)904134657;
				if (num != 0)
				{
				}
				goto IL_824;
				IL_5B0:
				throw new global::System.Runtime.Serialization.SerializationException(string.Format(global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("잢솤캦\udda8슪슬솮킰\udfb2閴ﺶힸ\uddba튼龾Ꟁ곂럄駈맊꓌ꋎ룐꟒볔ꇖ볘ﯚ觜ꛞ釠蛢엤軦髨쯪蓬臮鋰鳲蟴藶鳸飺觼\udffe稀㌂砄", a_), obj));
				IL_824:
				throw new global::System.Runtime.Serialization.SerializationException(string.Format(global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("톢첤쪦삨\udfaa쒬\ud9ae풰鎲캶즸\udeba鶼쒾뻂ꇆꛈ맊귎룐뷒듔ꗖꃘﯚ볜귞鏠苢鳤铦짨苪黬쿮鿰鳲致ퟶ郸雺跼鏾搀渂怄椆紈渊椌", a_), primitiveTypeEnumeration));
				IL_9B2:
				goto IL_FE5;
				IL_A42:
				throw new global::System.Runtime.Serialization.SerializationException(string.Format(global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("횢햤힦욨\ud9aa\ud9ac쪮햰鎲횶ힸ킺鶼횾꿀蟄껆ꟈ꫊뿌뛎鋒꟔ꗖ룘ꋚ﷜뛞鋠쏢諤触藨鋪췬\udeee퇰鋲鯴鏶\ud9f8짺\uddfc鷾琀眂┄怆昈缊ⴌ琎ℐ渒", a_), num5));
				IL_C40:
				throw new global::System.Runtime.Serialization.SerializationException(string.Format(global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("톢첤쪦삨\udfaa쒬\ud9ae풰鎲캶즸\udeba鶼쒾뻂ꇆꛈ맊귎룐뷒듔ꗖꃘﯚ볜귞鏠苢鳤铦짨苪黬쿮鿰鳲致ퟶ郸雺跼鏾搀渂怄椆紈渊椌", a_), primitiveTypeEnumeration));
				IL_D4F:
				goto IL_50F;
				IL_DE1:
				goto IL_C40;
				IL_ED7:
				IL_F45:
				IL_FE5:
				int objectId;
				binaryArray2.ObjectId = objectId;
				binaryArray2.BinaryArrayTypeEnum = binaryArrayTypeEnumeration;
				binaryArray2.Rank = num5;
				binaryArray2.Lengths = list;
				binaryArray2.LowerBounds = list2;
				binaryArray2.TypeEnum = binaryTypeEnumeration;
				binaryArray2.AdditionalInfo = obj;
				this.u().c.Add(binaryArray2.ObjectId, binaryArray2);
				return binaryArray2;
				IL_15B:
				objectId = this.b<int>();
				binaryArrayTypeEnumeration = (global::Motorola.Common.BinarySerializer.BinaryArrayTypeEnumeration)this.b<byte>();
				num5 = this.b<int>();
				list = new global::System.Collections.Generic.List<int>();
				num7 = 0;
				num = (short)1319567413;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000049F8 File Offset: 0x00002BF8
		[return: global::System.Runtime.CompilerServices.a(new byte[]
		{
			1,
			2
		})]
		private object[] c(int A_0)
		{
			short num = (short)105840640;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5E;
				}
				object[] array;
				int num4;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_1E8;
					case 1:
						goto IL_232;
					case 2:
					{
						int num3;
						global::Motorola.Common.BinarySerializer.ObjectNullMultiple objectNullMultiple;
						if (num3 >= objectNullMultiple.Count)
						{
							num = (short)1799880713;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array[num4 + num3] = null;
						num3++;
						num = (short)1708654593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::Motorola.Common.BinarySerializer.ObjectNullMultiple objectNullMultiple;
						if (objectNullMultiple != null)
						{
							num = (short)1659633671;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						object obj;
						array[num4] = obj;
						num = (short)2117140480;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_232;
					case 5:
					{
						num = (short)1226601718;
						short num5 = num;
						num = (short)2006283510;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_22D;
						default:
							goto IL_158;
						}
						break;
					}
					case 6:
						goto IL_22D;
					case 7:
					{
						int num3 = 0;
						num = (short)388235268;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_1E8;
					case 9:
					{
						global::Motorola.Common.BinarySerializer.ObjectNullMultiple objectNullMultiple;
						num4 += objectNullMultiple.Count - 1;
						num = (short)1079050248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_EA;
					case 11:
					{
						if (num4 >= A_0)
						{
							num = (short)1856503813;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						object obj = this.e();
						global::Motorola.Common.BinarySerializer.ObjectNullMultiple objectNullMultiple = obj as global::Motorola.Common.BinarySerializer.ObjectNullMultiple;
						num = (short)1339228163;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_5E;
					IL_EA:
					num = (short)331939851;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_22D:
					goto IL_EA;
					IL_1E8:
					num = (short)1033109505;
					if (num != 0)
					{
					}
					num4++;
					num = (short)1032454150;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_232:
					num = (short)1975844866;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_158:
				num = (short)1670774784;
				if (num != 0)
				{
				}
				num = (short)1927610368;
				short num6 = num;
				return array;
				IL_5E:
				array = new object[A_0];
				num4 = 0;
				num = (short)1598226442;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00004CA0 File Offset: 0x00002EA0
		[return: global::System.Runtime.CompilerServices.a(new byte[]
		{
			1,
			2
		})]
		private object[,] b(int A_0, int A_1)
		{
			short num = (short)754188288;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6E;
				}
				object[,] array;
				int num5;
				for (;;)
				{
					IL_27:
					int num3;
					switch (num2)
					{
					case 0:
						goto IL_19C;
					case 1:
					{
						if (num3 >= A_1)
						{
							num = (short)343212037;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						object obj = this.e();
						global::Motorola.Common.BinarySerializer.ObjectNullMultiple objectNullMultiple = obj as global::Motorola.Common.BinarySerializer.ObjectNullMultiple;
						num = (short)1688797196;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						int num4 = 0;
						num = (short)1602355203;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_1D5;
					case 4:
					{
						global::Motorola.Common.BinarySerializer.ObjectNullMultiple objectNullMultiple;
						int num4;
						if (num4 >= objectNullMultiple.Count)
						{
							num = (short)458293258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						array[num5, num3 + num4] = null;
						num4++;
						num = (short)109903872;
						short num6 = num;
						num = (short)21823495;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						num5++;
						num = (short)1553661967;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_92;
					case 7:
						goto IL_1D5;
					case 8:
						goto IL_163;
					case 9:
						if (num5 >= A_0)
						{
							num = (short)408551435;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_145;
					case 10:
					{
						global::Motorola.Common.BinarySerializer.ObjectNullMultiple objectNullMultiple;
						num3 += objectNullMultiple.Count - 1;
						num = (short)1972240390;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						return array;
					case 12:
					{
						global::Motorola.Common.BinarySerializer.ObjectNullMultiple objectNullMultiple;
						if (objectNullMultiple != null)
						{
							num = (short)1947598850;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						object obj;
						array[num5, num3] = obj;
						num = (short)425034859;
						short num7 = num;
						num = (short)1724941419;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_145;
						default:
							num = (short)1236467713;
							if (num != 0)
							{
							}
							num = (short)1034813440;
							if (num != 0)
							{
							}
							num = (short)1337524237;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 13:
						goto IL_92;
					case 14:
						goto IL_163;
					case 15:
						goto IL_19C;
					}
					goto IL_6E;
					IL_92:
					num3++;
					num = (short)1673461774;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_145:
					num3 = 0;
					num = (short)1743781896;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_163:
					num = (short)1741160449;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_19C:
					num = (short)1727397897;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D5:
					num = (short)1026555908;
					num2 = (int)((global::System.IntPtr)num);
				}
				return array;
				IL_6E:
				array = new object[A_0, A_1];
				num5 = 0;
				num = (short)1349255168;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00004FD4 File Offset: 0x000031D4
		[global::System.Runtime.CompilerServices.b(2)]
		private object e()
		{
			int a_ = 12;
			switch (0)
			{
			case 0:
				goto IL_65;
			}
			int num;
			global::Motorola.Common.BinarySerializer.RecordTypeEnumeration recordTypeEnumeration;
			object result;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_24D;
				case 1:
					goto IL_1E3;
				case 2:
					goto IL_35E;
				case 3:
					switch (recordTypeEnumeration)
					{
					case global::Motorola.Common.BinarySerializer.RecordTypeEnumeration.SerializedStreamHeader:
						result = this.t();
						num2 = (short)1562902546;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.Common.BinarySerializer.RecordTypeEnumeration.ClassWithId:
						result = this.k();
						num2 = (short)1749614599;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.Common.BinarySerializer.RecordTypeEnumeration.SystemClassWithMembers:
					case global::Motorola.Common.BinarySerializer.RecordTypeEnumeration.ClassWithMembers:
						goto IL_270;
					case global::Motorola.Common.BinarySerializer.RecordTypeEnumeration.SystemClassWithMembersAndTypes:
						result = this.l();
						num2 = (short)1773862912;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.Common.BinarySerializer.RecordTypeEnumeration.ClassWithMembersAndTypes:
						result = this.m();
						num2 = (short)603783183;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.Common.BinarySerializer.RecordTypeEnumeration.BinaryObjectString:
						result = this.r();
						num2 = (short)176553997;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.Common.BinarySerializer.RecordTypeEnumeration.BinaryArray:
						result = this.f();
						num2 = (short)1546846209;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.Common.BinarySerializer.RecordTypeEnumeration.MemberPrimitiveTyped:
						result = this.p();
						num2 = (short)1592066050;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.Common.BinarySerializer.RecordTypeEnumeration.MemberReference:
						result = this.q();
						num2 = (short)728367116;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.Common.BinarySerializer.RecordTypeEnumeration.ObjectNull:
						result = null;
						num2 = (short)940048389;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.Common.BinarySerializer.RecordTypeEnumeration.MessageEnd:
						result = new global::Motorola.Common.BinarySerializer.MessageEnd();
						num2 = (short)410189835;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.Common.BinarySerializer.RecordTypeEnumeration.BinaryLibrary:
						result = this.s();
						num2 = (short)1515651076;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.Common.BinarySerializer.RecordTypeEnumeration.ObjectNullMultiple256:
						result = this.o();
						num2 = (short)1767768073;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.Common.BinarySerializer.RecordTypeEnumeration.ObjectNullMultiple:
						result = this.n();
						num2 = (short)292749328;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.Common.BinarySerializer.RecordTypeEnumeration.ArraySinglePrimitive:
						num2 = (short)837353473;
						if (num2 != 0)
						{
						}
						result = this.i();
						num2 = (short)2016411656;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.Common.BinarySerializer.RecordTypeEnumeration.ArraySingleObject:
						result = this.h();
						num2 = (short)1681981446;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case global::Motorola.Common.BinarySerializer.RecordTypeEnumeration.ArraySingleString:
						result = this.g();
						num2 = (short)1885470730;
						num = (int)((global::System.IntPtr)num2);
						continue;
					default:
						num2 = (short)1037959185;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				case 4:
					goto IL_2EE;
				case 5:
					goto IL_26B;
				case 6:
					goto IL_22A;
				case 7:
					goto IL_19B;
				case 8:
					goto IL_155;
				case 9:
					goto IL_10A;
				case 10:
					return result;
				case 11:
					goto IL_206;
				case 12:
					goto IL_2AE;
				case 13:
					goto IL_312;
				case 14:
					goto IL_2CA;
				case 15:
					goto IL_178;
				case 16:
					goto IL_382;
				case 17:
					num2 = (short)792789006;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					goto IL_1C0;
				}
				goto IL_65;
			}
			IL_10A:
			IL_155:
			IL_178:
			IL_19B:
			IL_1C0:
			IL_1E3:
			IL_206:
			IL_22A:
			IL_24D:
			IL_26B:
			return result;
			IL_270:
			throw new global::System.Runtime.Serialization.SerializationException(string.Format(global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("寧좬첮\udeb0솲톴鞶슺춼\udabe룂뫆ꋊ뻌뿐볒ꇔ냘뛚규돞蓠転胤触鷨軪觬", a_), recordTypeEnumeration));
			IL_2AE:
			return result;
			IL_2CA:
			goto IL_270;
			IL_2EE:
			return result;
			IL_312:
			num2 = (short)1282670592;
			short num3 = num2;
			IL_35E:
			return result;
			IL_382:
			num2 = (short)300878864;
			short num4 = num2;
			num2 = (short)1585777680;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num2 = (short)1606352896;
				if (num2 != 0)
				{
				}
				break;
			}
			return result;
			IL_65:
			recordTypeEnumeration = (global::Motorola.Common.BinarySerializer.RecordTypeEnumeration)this.b<byte>();
			num2 = (short)1462304771;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000053D4 File Offset: 0x000035D4
		private global::Motorola.Common.BinarySerializer.ClassTypeInfo d()
		{
			short num = (short)1683357697;
			if (num != 0)
			{
			}
			num = (short)2052870582;
			short num2 = num;
			num = (short)311644598;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2034696192;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)486670336;
			if (num != 0)
			{
			}
			return new global::Motorola.Common.BinarySerializer.ClassTypeInfo
			{
				TypeName = this.b<string>(),
				LibraryId = this.b<int>()
			};
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000549C File Offset: 0x0000369C
		private global::Motorola.Common.BinarySerializer.ClassInfo c()
		{
			global::Motorola.Common.BinarySerializer.ClassInfo classInfo;
			for (;;)
			{
				IL_00:
				short num = (short)1323106304;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_48;
				}
				int num3;
				int num4;
				for (;;)
				{
					IL_32:
					switch (num3)
					{
					case 0:
						goto IL_8B;
					case 1:
						return classInfo;
					case 2:
					{
						if (num4 >= classInfo.MemberCount)
						{
							num = (short)852492289;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1788762097;
						short num5 = num;
						num = (short)1792825329;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1421017089;
							if (num != 0)
							{
							}
							num = (short)924123136;
							if (num != 0)
							{
							}
							classInfo.MemberNames.Add(this.b<string>());
							num4++;
							num = (short)913899520;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						goto IL_8B;
					}
					break;
					IL_8B:
					num = (short)18219010;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_48:
				classInfo = new global::Motorola.Common.BinarySerializer.ClassInfo
				{
					ObjectId = this.b<int>(),
					Name = this.b<string>(),
					MemberCount = this.b<int>()
				};
				num4 = 0;
				num = (short)847118339;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			return classInfo;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00005614 File Offset: 0x00003814
		[global::System.Runtime.CompilerServices.b(2)]
		private object a(global::Motorola.Common.BinarySerializer.BinaryTypeEnumeration A_0)
		{
			int a_ = 8;
			short num = (short)599130112;
			int num2 = (int)((global::System.IntPtr)num);
			object result;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_5A;
					}
					continue;
				case 1:
					return result;
				case 2:
					goto IL_1D2;
				case 3:
					num = (short)944766978;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					return result;
				case 5:
					return result;
				case 6:
					return result;
				case 7:
					goto IL_16F;
				case 8:
					goto IL_1B5;
				case 9:
					goto IL_197;
				case 10:
					goto IL_DF;
				}
				IL_5A:
				switch (A_0)
				{
				case global::Motorola.Common.BinarySerializer.BinaryTypeEnumeration.Primitive:
					result = (global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration)this.b<byte>();
					num = (short)1799159817;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case global::Motorola.Common.BinarySerializer.BinaryTypeEnumeration.String:
				{
					num = (short)402048255;
					short num3 = num;
					num = (short)509396223;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
						num = (short)522715137;
						if (num != 0)
						{
						}
						num = (short)1805451264;
						if (num != 0)
						{
						}
						result = null;
						num = (short)1635647495;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
				case global::Motorola.Common.BinarySerializer.BinaryTypeEnumeration.Object:
					result = null;
					num = (short)144900106;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case global::Motorola.Common.BinarySerializer.BinaryTypeEnumeration.SystemClass:
					result = this.b<string>();
					num = (short)1546125318;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case global::Motorola.Common.BinarySerializer.BinaryTypeEnumeration.Class:
					result = this.d();
					num = (short)1607794689;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case global::Motorola.Common.BinarySerializer.BinaryTypeEnumeration.ObjectArray:
					result = null;
					num = (short)363986952;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case global::Motorola.Common.BinarySerializer.BinaryTypeEnumeration.StringArray:
					result = null;
					num = (short)1070923780;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case global::Motorola.Common.BinarySerializer.BinaryTypeEnumeration.PrimitiveArray:
					result = (global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration)this.b<byte>();
					num = (short)189661189;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
				{
					num = (short)1732640768;
					short num4 = num;
					num = (short)109641731;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			IL_DF:
			IL_16F:
			IL_197:
			IL_1B5:
			return result;
			IL_1D2:
			throw new global::System.Runtime.Serialization.SerializationException(string.Format(global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("삨얪첬\uddae좰체잶\udcb8鮺욼达변ꯄ꣆뷈꓌ꋎꇐ뿒냔뫖볘뗚꧜뫞藠", a_), A_0));
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00005898 File Offset: 0x00003A98
		private global::Motorola.Common.BinarySerializer.MemberTypeInfo b(int A_0)
		{
			short num = (short)1257570304;
			short num2 = num;
			num = (short)955645952;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6C;
				}
				int num4;
				global::Motorola.Common.BinarySerializer.MemberTypeInfo memberTypeInfo;
				for (;;)
				{
					IL_51:
					global::System.Collections.Generic.List<global::Motorola.Common.BinarySerializer.BinaryTypeEnumeration>.Enumerator enumerator;
					switch (num3)
					{
					case 0:
						goto IL_235;
					case 1:
						goto IL_1B5;
					case 2:
						if (num4 >= A_0)
						{
							num = (short)976027649;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						memberTypeInfo.BinaryTypeEnums.Add((global::Motorola.Common.BinarySerializer.BinaryTypeEnumeration)this.b<byte>());
						num4++;
						num = (short)561774592;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)860225537;
						if (num != 0)
						{
							goto IL_201;
						}
						goto IL_201;
						IL_201:
						goto IL_8F;
						try
						{
							for (;;)
							{
								IL_8F:
								num = (short)868286468;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										num = (short)898629633;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_1A2;
									case 3:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)644349952;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.Common.BinarySerializer.BinaryTypeEnumeration a_ = enumerator.Current;
										memberTypeInfo.AdditionalInfos.Add(this.a(a_));
										num = (short)944675631;
										short num5 = num;
										num = (short)1761647407;
										switch ((num5 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_8F;
										default:
											num = (short)654770176;
											if (num != 0)
											{
											}
											num = (short)2141519874;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 4:
										switch (0)
										{
										case 0:
											goto IL_C9;
										}
										continue;
									}
									IL_CB:
									num = (short)2092367875;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_C9:
									goto IL_CB;
								}
							}
							IL_1A2:
							return memberTypeInfo;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1B5;
					case 4:
						goto IL_235;
					}
					goto IL_6C;
					IL_1B5:
					enumerator = memberTypeInfo.BinaryTypeEnums.GetEnumerator();
					num = (short)1559822339;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_235:
					num = (short)1601241090;
					num3 = (int)((global::System.IntPtr)num);
				}
				return memberTypeInfo;
				IL_6C:
				memberTypeInfo = new global::Motorola.Common.BinarySerializer.MemberTypeInfo();
				num4 = 0;
				num = (short)703791108;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_51;
			}
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00005B34 File Offset: 0x00003D34
		[return: global::System.Runtime.CompilerServices.a(new byte[]
		{
			1,
			2
		})]
		private global::System.Collections.Generic.List<object> a(global::Motorola.Common.BinarySerializer.MemberTypeInfo A_0)
		{
			int a_ = 11;
			short num = (short)1002438656;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6B;
				}
				global::System.Collections.Generic.List<object> list;
				int num3;
				global::Motorola.Common.BinarySerializer.BinaryTypeEnumeration binaryTypeEnumeration;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
					{
						object obj;
						if (obj is global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration)
						{
							num = (short)728563714;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_126;
					}
					case 1:
						goto IL_244;
					case 2:
					{
						object obj;
						global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration a_2 = (global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration)obj;
						list.Add(this.a(a_2));
						num = (short)1437073412;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (num3 >= A_0.BinaryTypeEnums.Count)
						{
							num = (short)2058027014;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						binaryTypeEnumeration = A_0.BinaryTypeEnums[num3];
						num = (short)1607401481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_18A;
					case 5:
						if (binaryTypeEnumeration - global::Motorola.Common.BinarySerializer.BinaryTypeEnumeration.String > 6)
						{
							num = (short)537985036;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						list.Add(this.e());
						num = (short)818479114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return list;
					case 7:
						goto IL_244;
					case 8:
						goto IL_2F1;
					case 9:
					{
						if (binaryTypeEnumeration != global::Motorola.Common.BinarySerializer.BinaryTypeEnumeration.Primitive)
						{
							goto IL_1D7;
						}
						object obj = A_0.AdditionalInfos[num3];
						num = (short)2040659968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_18A;
					case 11:
						num = (short)1140981761;
						if (num != 0)
						{
						}
						num = (short)2136801285;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)1049624584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6B;
					IL_18A:
					num3++;
					num = (short)24969223;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_244:
					num = (short)1265893379;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_126:
				throw new global::System.Runtime.Serialization.SerializationException(string.Format(global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("좫쪭\ud9af욱\uddb3\ud9b5횷\udbb9킻麽覿곁ꋃ꧅곉ꏋ볍苑ꛓ뿕뗗동꣛럝雟蟡쓣닥釧髩觫컭駯臱퓳鿵雷駹鏻賽狿朁會爅㈇⨉看㸍洏", a_), A_0.AdditionalInfos[num3]));
				IL_2F1:
				throw new global::System.Runtime.Serialization.SerializationException(string.Format(global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("얫삭톯삱춳隵쎹첻\udbbd링믅ꏉ뿋뻏뷑ꃓ뇗럙곛닝藟迡臣裥鳧迩裫", a_), binaryTypeEnumeration));
				IL_6B:
				list = new global::System.Collections.Generic.List<object>();
				num3 = 0;
				num = (short)528924810;
				short num4 = num;
				num = (short)560906378;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_1D7:
					num = (short)956563467;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				default:
				{
					num = (short)1325662208;
					short num5 = num;
					num = (short)1424293888;
					if (num != 0)
					{
					}
					num = (short)861732865;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				}
				break;
			}
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00005E6C File Offset: 0x0000406C
		[global::System.Runtime.CompilerServices.b(2)]
		private object a(global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration A_0)
		{
			int a_ = 8;
			short num = (short)669253633;
			int num2 = (int)((global::System.IntPtr)num);
			object result;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_26E;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_7E;
					}
					continue;
				case 2:
					num = (short)275251207;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return result;
				case 4:
					goto IL_2DD;
				case 5:
					return result;
				case 6:
					goto IL_10D;
				case 7:
					goto IL_340;
				case 8:
					goto IL_324;
				case 9:
					goto IL_186;
				case 10:
					return result;
				case 11:
					goto IL_1F9;
				case 12:
					return result;
				case 13:
					return result;
				case 14:
					goto IL_222;
				case 15:
					return result;
				case 16:
					goto IL_24B;
				case 17:
					goto IL_2BF;
				case 18:
					goto IL_297;
				case 19:
					goto IL_135;
				}
				IL_7E:
				switch (A_0)
				{
				case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Boolean:
					result = this.b<bool>();
					num = (short)1409482765;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Byte:
					result = this.b<byte>();
					num = (short)259063822;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Char:
					result = this.b<char>();
					num = (short)942276617;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case (global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration)4:
					goto IL_2E2;
				case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Decimal:
					result = this.b<decimal>();
					num = (short)1967456261;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Double:
					result = this.b<double>();
					num = (short)1231880209;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Int16:
					result = this.b<short>();
					num = (short)1081999368;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Int32:
				{
					result = this.b<int>();
					num = (short)158859264;
					short num3 = num;
					num = (short)994836483;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Int64:
					result = this.b<long>();
					num = (short)391446540;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.SByte:
					result = this.b<sbyte>();
					num = (short)34078738;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Single:
					result = this.b<float>();
					num = (short)1131151379;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.TimeSpan:
					result = this.b<global::System.TimeSpan>();
					num = (short)664862730;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.DateTime:
					result = this.b<global::System.DateTime>();
					num = (short)647495696;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.UInt16:
					result = this.b<ushort>();
					num = (short)1877868550;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.UInt32:
					result = this.b<uint>();
					num = (short)1057619983;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.UInt64:
				{
					num = (short)563433552;
					short num4 = num;
					num = (short)1258311760;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)978649088;
						if (num != 0)
						{
						}
						result = this.b<ulong>();
						num = (short)956039179;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
				case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.Null:
					result = null;
					num = (short)653000708;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case global::Motorola.Common.BinarySerializer.PrimitiveTypeEnumeration.String:
					result = this.b<string>();
					num = (short)1229979648;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)467795970;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_10D:
			return result;
			IL_135:
			num = (short)880279553;
			if (num != 0)
			{
			}
			IL_186:
			IL_1F9:
			IL_222:
			IL_24B:
			IL_26E:
			IL_297:
			IL_2BF:
			IL_2DD:
			return result;
			IL_2E2:
			throw new global::System.Runtime.Serialization.SerializationException(string.Format(global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("\udba8슪사욮얰\udab2쎴튶馸쒼쾾꓀뻄듈꓌볎뷒뫔ꏖ律닚냜꿞跠蛢裤苦蟨鿪裬诮", a_), A_0));
			IL_324:
			return result;
			IL_340:
			goto IL_2E2;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000062D8 File Offset: 0x000044D8
		private a b<[global::System.Runtime.CompilerServices.a(2)] a>()
		{
			int a_ = 11;
			short num = (short)294649868;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_4FB;
				case 1:
					if (typeof(a) == typeof(global::System.TimeSpan))
					{
						num = (short)868155402;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)214695963;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_494;
				case 3:
					goto IL_429;
				case 4:
					if (typeof(a) == typeof(byte))
					{
						num = (short)1547829269;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1800929310;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_59F;
				case 6:
					if (typeof(a) == typeof(sbyte))
					{
						num = (short)1898053641;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1720123406;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (typeof(a) == typeof(bool))
					{
						num = (short)1633419279;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)348192772;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (typeof(a) == typeof(ulong))
					{
						num = (short)1573257240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7B3;
				case 9:
					goto IL_18A;
				case 10:
					goto IL_139;
				case 11:
					goto IL_54D;
				case 12:
					switch (0)
					{
					case 0:
						goto IL_AF;
					}
					continue;
				case 13:
					goto IL_E5;
				case 14:
					if (typeof(a) == typeof(float))
					{
						num = (short)1433010198;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1250426881;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					goto IL_74A;
				case 16:
				{
					if (!(typeof(a) == typeof(double)))
					{
						num = (short)173539357;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1178532165;
					short num3 = num;
					num = (short)1218246981;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6B5;
					default:
						num = (short)1870790656;
						if (num != 0)
						{
						}
						num = (short)771751962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 17:
					if (typeof(a) == typeof(short))
					{
						num = (short)1636499461;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)879689746;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					if (typeof(a) == typeof(int))
					{
						num = (short)1429536779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)19791895;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					if (typeof(a) == typeof(uint))
					{
						num = (short)453312540;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1400242184;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					goto IL_1F1;
				case 21:
					goto IL_242;
				case 22:
					goto IL_5F1;
				case 23:
					if (typeof(a) == typeof(long))
					{
						num = (short)1521877017;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)139722758;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					goto IL_7AE;
				case 25:
					goto IL_6B5;
				case 26:
					goto IL_31F;
				case 27:
					if (typeof(a) == typeof(global::System.DateTime))
					{
						num = (short)1740832768;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)968884255;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					goto IL_372;
				case 29:
					if (typeof(a) == typeof(decimal))
					{
						num = (short)44826626;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1454637073;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 30:
					num = (short)148832257;
					if (num != 0)
					{
					}
					if (typeof(a) == typeof(char))
					{
						num = (short)294518787;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2029125648;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					if (typeof(a) == typeof(ushort))
					{
						num = (short)652410900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1871446035;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_AF:
				if (typeof(a) == typeof(string))
				{
					num = (short)1476001805;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1085538304;
					short num4 = num;
					num = (short)1873674247;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_E5:
			return (a)((object)this.v().ReadString());
			IL_139:
			return (a)((object)global::System.TimeSpan.FromTicks(this.v().ReadInt64()));
			IL_18A:
			return (a)((object)this.v().ReadSByte());
			IL_1F1:
			return (a)((object)this.v().ReadUInt16());
			IL_242:
			return (a)((object)this.v().ReadByte());
			IL_31F:
			return (a)((object)this.v().ReadDouble());
			IL_372:
			return (a)((object)this.v().ReadUInt32());
			IL_429:
			return (a)((object)this.v().ReadChar());
			IL_494:
			return (a)((object)decimal.Parse(this.a()));
			IL_4FB:
			return (a)((object)global::System.DateTime.FromBinary(this.v().ReadInt64()));
			IL_54D:
			return (a)((object)this.v().ReadInt32());
			IL_59F:
			return (a)((object)this.v().ReadInt16());
			IL_5F1:
			return (a)((object)this.v().ReadSingle());
			IL_6B5:
			return (a)((object)this.v().ReadInt64());
			IL_74A:
			return (a)((object)this.v().ReadBoolean());
			IL_7AE:
			return (a)((object)this.v().ReadUInt64());
			IL_7B3:
			throw new global::System.Runtime.Serialization.SerializationException(string.Format(global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("즫쾭풯\udbb1\udab3통颷솹費쎽ꯁ럃ꛇꗉ룋맏뿑ꓓ뫕뷗럙맛냝铟蟡胣", a_), typeof(a)));
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00006ABC File Offset: 0x00004CBC
		private string a()
		{
			int a_ = 7;
			short num = (short)625868800;
			short num2 = num;
			num = (short)928251905;
			if (num != 0)
			{
			}
			num = (short)1833762816;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A9;
				}
				int num4;
				int num6;
				int num7;
				for (;;)
				{
					IL_82:
					switch (num3)
					{
					case 0:
						goto IL_169;
					case 1:
					{
						byte b;
						if ((b & 128) != 0)
						{
							num = (short)1343815683;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22C;
					}
					case 2:
					{
						if (num4 != 4)
						{
							num4++;
							num = (short)1706229766;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1749695119;
						short num5 = num;
						num = (short)372783759;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_E8;
						default:
							num = (short)947716096;
							if (num != 0)
							{
							}
							num = (short)1049952261;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						num = (short)430964738;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_19F;
					case 5:
						goto IL_227;
					case 6:
						goto IL_169;
					case 7:
					{
						if (num4 >= 5)
						{
							num = (short)1797914628;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte b = this.v().ReadByte();
						num6 += ((int)b & -129) << num7;
						num7 += 7;
						num = (short)1045823489;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_A9;
					IL_169:
					num = (short)908591111;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_E8:
				throw new global::System.Runtime.Serialization.SerializationException(string.Format(global::Motorola.Common.BinarySerializer.BinarySerializerVerificationResult.b("욧즩쎫\udcad슯ힱힳ습颷좻첽ꦿ곁ꏃ꓇꿉ꋋ꧍꓏뫑ꏗꇛ", a_), num6));
				IL_19F:
				goto IL_22C;
				IL_227:
				goto IL_E8;
				IL_22C:
				byte[] bytes = this.v().ReadBytes(num6);
				return global::System.Text.Encoding.UTF8.GetString(bytes);
				IL_A9:
				num6 = 0;
				num7 = 0;
				num4 = 0;
				num = (short)1007550464;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_82;
			}
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00006D10 File Offset: 0x00004F10
		[global::System.Runtime.CompilerServices.b(0)]
		[return: global::System.Runtime.CompilerServices.a(new byte[]
		{
			1,
			0
		})]
		private a[] a<a>(int A_0) where a : struct
		{
			short num = (short)556990464;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_4B;
			}
			int num3;
			int num4;
			a[] array;
			for (;;)
			{
				IL_35:
				switch (num3)
				{
				case 0:
					goto IL_6A;
				case 1:
				{
					num = (short)1745813505;
					if (num != 0)
					{
					}
					if (num4 >= A_0)
					{
						num = (short)293208067;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1434674991;
					short num5 = num;
					num = (short)314926895;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6A;
					default:
						num = (short)231997440;
						if (num != 0)
						{
						}
						array[num4] = this.b<a>();
						num4++;
						num = (short)1320550400;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_6A;
				case 3:
					return array;
				}
				goto IL_4B;
				IL_6A:
				num = (short)1370161153;
				num3 = (int)((global::System.IntPtr)num);
			}
			return array;
			IL_4B:
			array = new a[A_0];
			num4 = 0;
			num = (short)220135426;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_35;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00006E58 File Offset: 0x00005058
		[global::System.Runtime.CompilerServices.b(0)]
		[return: global::System.Runtime.CompilerServices.a(new byte[]
		{
			1,
			0
		})]
		private a[,] a<a>(int A_0, int A_1) where a : struct
		{
			short num = (short)783089664;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_A2;
			}
			int num4;
			a[,] array;
			int num6;
			for (;;)
			{
				IL_33:
				num = (short)1218522223;
				short num3 = num;
				num = (short)1072508015;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1037238272;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						goto IL_135;
					case 1:
					{
						int num5;
						if (num5 >= A_1)
						{
							num = (short)2025717763;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						array[num6, num5] = this.b<a>();
						num5++;
						num = (short)688455681;
						if (num != 0)
						{
						}
						num = (short)1440022533;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						return array;
					case 3:
						num6++;
						num = (short)1006829574;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						if (num6 >= A_0)
						{
							num = (short)1042284546;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num5 = 0;
						num = (short)1925382151;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_1BB;
					case 6:
						goto IL_135;
					case 7:
						goto IL_E4;
					}
					goto IL_A2;
					IL_135:
					num = (short)723648516;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_E4:
				num = (short)1391132673;
				num4 = (int)((global::System.IntPtr)num);
				continue;
				IL_1BB:
				goto IL_E4;
			}
			return array;
			IL_A2:
			array = new a[A_0, A_1];
			num6 = 0;
			num = (short)235012096;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_33;
		}

		// Token: 0x04000006 RID: 6
		[global::System.Runtime.CompilerServices.a(2)]
		private global::System.IO.BinaryReader a;

		// Token: 0x04000007 RID: 7
		[global::System.Runtime.CompilerServices.a(2)]
		private global::Motorola.Common.BinarySerializer.b b;
	}
}
