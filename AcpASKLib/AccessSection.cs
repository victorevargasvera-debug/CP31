using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace AcpASKLib
{
	// Token: 0x02000016 RID: 22
	[global::System.Serializable]
	public class AccessSection : global::AcpASKLib.IAcpSecurity
	{
		// Token: 0x060000A1 RID: 161 RVA: 0x0000FFD0 File Offset: 0x0000E1D0
		public AccessSection(string strName, string strUiName, ushort id)
		{
			this.uId = id;
			this.name = strName;
			this.uiName = strUiName;
			this.items = new global::System.Collections.ObjectModel.Collection<global::AcpASKLib.AccessElement>();
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00010004 File Offset: 0x0000E204
		public AccessSection()
		{
			this.uId = 0;
			this.name = null;
			this.uiName = null;
			this.items = new global::System.Collections.ObjectModel.Collection<global::AcpASKLib.AccessElement>();
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00010038 File Offset: 0x0000E238
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x000100EC File Offset: 0x0000E2EC
		[global::System.Xml.Serialization.XmlAttribute]
		public string Name
		{
			get
			{
				short num = (short)879522317;
				short num2 = num;
				num = (short)1798271501;
				switch (num2 == num)
				{
				}
				num = (short)1699282945;
				if (num != 0)
				{
				}
				num = (short)871628800;
				if (num != 0)
				{
				}
				num = (short)1432551424;
				short num3 = num;
				return this.name;
			}
			set
			{
				short num = (short)35609924;
				short num2 = num;
				num = (short)1971608900;
				switch (num2 == num)
				{
				}
				num = (short)1321402368;
				if (num != 0)
				{
				}
				num = (short)929234945;
				if (num != 0)
				{
				}
				num = (short)1592000512;
				short num3 = num;
				this.name = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x0001019C File Offset: 0x0000E39C
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x0001024C File Offset: 0x0000E44C
		[global::System.Xml.Serialization.XmlAttribute]
		public string UIName
		{
			get
			{
				short num = (short)1452283143;
				short num2 = num;
				num = (short)273618183;
				switch (num2 == num)
				{
				}
				num = (short)1603993601;
				if (num != 0)
				{
				}
				num = (short)84082688;
				if (num != 0)
				{
				}
				num = (short)838860800;
				short num3 = num;
				return this.uiName;
			}
			set
			{
				short num = (short)198708476;
				short num2 = num;
				num = (short)1358826748;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1570504704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1609957377;
				if (num != 0)
				{
				}
				num = (short)1477050368;
				if (num != 0)
				{
				}
				this.uiName = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x000102FC File Offset: 0x0000E4FC
		// (set) Token: 0x060000A8 RID: 168 RVA: 0x000103AC File Offset: 0x0000E5AC
		[global::System.Xml.Serialization.XmlAttribute]
		public ushort ID
		{
			get
			{
				short num = (short)1744642294;
				short num2 = num;
				num = (short)1091313910;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1136721920;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1518206977;
				if (num != 0)
				{
				}
				num = (short)1300430848;
				if (num != 0)
				{
				}
				return this.uId;
			}
			set
			{
				short num = (short)1378368229;
				short num2 = num;
				num = (short)461454053;
				switch (num2 == num)
				{
				default:
				{
					num = (short)75628544;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)559611904;
				if (num != 0)
				{
				}
				num = (short)2001403905;
				if (num != 0)
				{
				}
				this.uId = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x00010460 File Offset: 0x0000E660
		[global::System.Xml.Serialization.XmlElement(typeof(global::AcpASKLib.AccessRangeField))]
		[global::System.Xml.Serialization.XmlElement(typeof(global::AcpASKLib.AccessField))]
		[global::System.Xml.Serialization.XmlElement]
		[global::System.Xml.Serialization.XmlElement(typeof(global::AcpASKLib.AccessOperation))]
		public global::System.Collections.ObjectModel.Collection<global::AcpASKLib.AccessElement> Items
		{
			get
			{
				short num = (short)1659701308;
				short num2 = num;
				num = (short)46336060;
				switch (num2 == num)
				{
				default:
				{
					num = (short)36831232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1327955969;
				if (num != 0)
				{
				}
				num = (short)1393426432;
				if (num != 0)
				{
				}
				return this.items;
			}
		}

		// Token: 0x17000030 RID: 48
		public global::AcpASKLib.AccessElement this[int id]
		{
			get
			{
				short num = (short)2022113281;
				if (num != 0)
				{
				}
				global::AcpASKLib.AccessElement result = null;
				global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessElement> enumerator = this.items.GetEnumerator();
				try
				{
					num = (short)97910790;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)800260097;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_126;
						case 2:
						{
							global::AcpASKLib.AccessElement accessElement;
							result = accessElement;
							num = (short)2048917509;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::AcpASKLib.AccessElement accessElement;
							if (this.uId == (ushort)accessElement.ID)
							{
								num = (short)352976898;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)2047410176;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpASKLib.AccessElement accessElement = enumerator.Current;
							num = (short)1157758979;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							goto IL_10A;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_78;
							}
							continue;
						}
						IL_BC:
						num = (short)1799749636;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_78:
						goto IL_BC;
					}
					IL_10A:
					IL_126:;
				}
				finally
				{
					num = (short)1247608834;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_1E0;
						case 1:
						{
							enumerator.Dispose();
							num = (short)1317153765;
							short num3 = num;
							num = (short)444083173;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1E2;
							default:
								num = (short)1542062080;
								if (num != 0)
								{
								}
								num = (short)216858624;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_15C;
							}
							continue;
						}
						IL_15C:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1621295105;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1E0:
					IL_1E2:;
				}
				num = (short)1561591808;
				short num4 = num;
				return result;
			}
		}

		// Token: 0x17000031 RID: 49
		public global::AcpASKLib.AccessElement this[string name]
		{
			get
			{
				global::AcpASKLib.AccessElement result = null;
				global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessElement> enumerator = this.items.GetEnumerator();
				short num;
				try
				{
					num = (short)99811334;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)130088961;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_FF;
						case 2:
						{
							global::AcpASKLib.AccessElement accessElement;
							result = accessElement;
							num = (short)256114693;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::AcpASKLib.AccessElement accessElement;
							if (name == accessElement.Name)
							{
								num = (short)183566338;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)472973312;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpASKLib.AccessElement accessElement = enumerator.Current;
							num = (short)14417923;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							goto IL_E2;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_50;
							}
							continue;
						}
						IL_92:
						num = (short)1012072452;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_50:
						goto IL_92;
					}
					IL_E2:
					IL_FF:;
				}
				finally
				{
					num = (short)1286930434;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_1B9;
						case 1:
						{
							enumerator.Dispose();
							num = (short)1572406244;
							short num3 = num;
							num = (short)1897923556;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1BB;
							default:
								num = (short)823721984;
								if (num != 0)
								{
								}
								num = (short)215875584;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_136;
							}
							continue;
						}
						IL_136:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1851523073;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1B9:
					IL_1BB:;
				}
				num = (short)1993408513;
				if (num != 0)
				{
				}
				num = (short)1593049088;
				short num4 = num;
				return result;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00010968 File Offset: 0x0000EB68
		// (set) Token: 0x060000AD RID: 173 RVA: 0x00010C64 File Offset: 0x0000EE64
		[global::System.Xml.Serialization.XmlIgnore]
		public global::AcpASKLib.AccessLevelType AccessLevel
		{
			get
			{
				short num = (short)565575681;
				if (num != 0)
				{
				}
				global::AcpASKLib.AccessLevelType result = global::AcpASKLib.AccessLevelType.Editable;
				global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessElement> enumerator = this.items.GetEnumerator();
				try
				{
					num = (short)1001652235;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_1E4;
						case 1:
							result = global::AcpASKLib.AccessLevelType.ReadOnly;
							num = (short)1018167305;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)112132096;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							global::AcpASKLib.AccessElement accessElement;
							if (((global::AcpASKLib.AccessField)accessElement).AccessLevel == global::AcpASKLib.AccessLevelType.Editable)
							{
								num = (short)481624070;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)130351108;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							global::AcpASKLib.AccessElement accessElement;
							if (((global::AcpASKLib.AccessField)accessElement).AccessLevel == global::AcpASKLib.AccessLevelType.ReadOnly)
							{
								num = (short)403767297;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
						{
							global::AcpASKLib.AccessElement accessElement;
							if (accessElement is global::AcpASKLib.AccessField)
							{
								num = (short)1987248135;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							result = global::AcpASKLib.AccessLevelType.Editable;
							num = (short)1638596618;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							num = (short)1482948611;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1714356226;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpASKLib.AccessElement accessElement = enumerator.Current;
							num = (short)331350021;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
							goto IL_1C8;
						case 11:
							switch (0)
							{
							case 0:
								goto IL_8E;
							}
							continue;
						}
						IL_CF:
						num = (short)4194312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_8E:
						goto IL_CF;
					}
					IL_1C8:
					IL_1E4:;
				}
				finally
				{
					num = (short)1819017218;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_2A3;
						case 1:
						{
							enumerator.Dispose();
							num = (short)1255008718;
							short num3 = num;
							num = (short)1318709710;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_2A5;
							default:
								num = (short)2078998528;
								if (num != 0)
								{
								}
								num = (short)1715994624;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_21B;
							}
							continue;
						}
						IL_21B:
						if (enumerator == null)
						{
							break;
						}
						num = (short)263913473;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2A3:
					IL_2A5:;
				}
				num = (short)561709056;
				short num4 = num;
				return result;
			}
			set
			{
				short num = (short)121569281;
				if (num != 0)
				{
				}
				num = (short)1744437250;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessElement> enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1251737612;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_258;
								case 1:
								{
									global::AcpASKLib.AccessElement accessElement;
									((global::AcpASKLib.AccessOperation)accessElement).AccessLevel = true;
									num = (short)838598658;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)1704722432;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::AcpASKLib.AccessElement accessElement;
									if (accessElement is global::AcpASKLib.AccessField)
									{
										num = (short)120127495;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)431226886;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1616838659;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpASKLib.AccessElement accessElement = enumerator.Current;
									num = (short)87228420;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::AcpASKLib.AccessElement accessElement;
									if (accessElement is global::AcpASKLib.AccessOperation)
									{
										num = (short)558825483;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									global::AcpASKLib.AccessElement accessElement;
									((global::AcpASKLib.AccessField)accessElement).AccessLevel = value;
									num = (short)1222180874;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									if (value == global::AcpASKLib.AccessLevelType.Editable)
									{
										num = (short)1934622721;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpASKLib.AccessElement accessElement;
									((global::AcpASKLib.AccessOperation)accessElement).AccessLevel = false;
									num = (short)857997321;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									num = (short)1966014472;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									switch (0)
									{
									case 0:
										goto IL_D3;
									}
									continue;
								}
								IL_139:
								num = (short)779812869;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D3:
								goto IL_139;
							}
							IL_258:
							goto IL_341;
						}
						finally
						{
							num = (short)2106523650;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_310;
								case 1:
								{
									enumerator.Dispose();
									num = (short)190661066;
									short num3 = num;
									num = (short)343359946;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_312;
									default:
										num = (short)1600323584;
										if (num != 0)
										{
										}
										num = (short)1050673152;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_28D;
									}
									continue;
								}
								IL_28D:
								if (enumerator == null)
								{
									break;
								}
								num = (short)459603969;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_310:
							IL_312:;
						}
						goto IL_313;
					case 1:
						goto IL_76;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_58;
						}
						continue;
					}
					IL_58:
					if (!global::AcpASKLib.AcpSecurity.a())
					{
						num = (short)1462960129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_313:
					enumerator = this.items.GetEnumerator();
					num = (short)1148911616;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_76:
				throw new global::AcpASKLib.AcpSecurityException();
				IL_341:
				num = (short)723255296;
				short num4 = num;
			}
		}

		// Token: 0x040000F2 RID: 242
		private ushort uId;

		// Token: 0x040000F3 RID: 243
		private string name;

		// Token: 0x040000F4 RID: 244
		private string uiName;

		// Token: 0x040000F5 RID: 245
		private global::System.Collections.ObjectModel.Collection<global::AcpASKLib.AccessElement> items;
	}
}
