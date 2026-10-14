using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using ASK.Interface;

namespace ASK.Core
{
	// Token: 0x02000013 RID: 19
	[global::System.Serializable]
	public class AccessSection : global::ASK.Core.IAcpSecurity
	{
		// Token: 0x060000A4 RID: 164 RVA: 0x00011450 File Offset: 0x0000F650
		public AccessSection(string strName, string strUiName, ushort id)
		{
			this.uId = id;
			this.name = strName;
			this.uiName = strUiName;
			this.items = new global::System.Collections.ObjectModel.Collection<global::ASK.Core.AccessElement>();
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00011484 File Offset: 0x0000F684
		public AccessSection()
		{
			this.uId = 0;
			this.name = null;
			this.uiName = null;
			this.items = new global::System.Collections.ObjectModel.Collection<global::ASK.Core.AccessElement>();
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x000114B8 File Offset: 0x0000F6B8
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x00011568 File Offset: 0x0000F768
		[global::System.Xml.Serialization.XmlAttribute]
		public string Name
		{
			get
			{
				short num = (short)180289536;
				short num2 = num;
				num = (short)2079127446;
				short num3 = num;
				num = (short)1831663510;
				switch (num3 == num)
				{
				}
				num = (short)879230977;
				if (num != 0)
				{
				}
				num = (short)1493172224;
				if (num != 0)
				{
				}
				return this.name;
			}
			set
			{
				short num = (short)1825643837;
				short num2 = num;
				num = (short)749608253;
				switch (num2 == num)
				{
				}
				num = (short)293666816;
				short num3 = num;
				num = (short)1634271233;
				if (num != 0)
				{
				}
				num = (short)1592328192;
				if (num != 0)
				{
				}
				this.name = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00011618 File Offset: 0x0000F818
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x000116C8 File Offset: 0x0000F8C8
		[global::System.Xml.Serialization.XmlAttribute]
		public string UIName
		{
			get
			{
				short num = (short)1746806928;
				short num2 = num;
				num = (short)814753936;
				switch (num2 == num)
				{
				}
				num = (short)1719205888;
				short num3 = num;
				num = (short)1211629569;
				if (num != 0)
				{
				}
				num = (short)1307574272;
				if (num != 0)
				{
				}
				return this.uiName;
			}
			set
			{
				short num = (short)1656062844;
				short num2 = num;
				num = (short)139887484;
				switch (num2 == num)
				{
				}
				num = (short)1158742016;
				short num3 = num;
				num = (short)920780800;
				if (num != 0)
				{
				}
				num = (short)1889075201;
				if (num != 0)
				{
				}
				this.uiName = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000AA RID: 170 RVA: 0x0001177C File Offset: 0x0000F97C
		// (set) Token: 0x060000AB RID: 171 RVA: 0x0001182C File Offset: 0x0000FA2C
		[global::System.Xml.Serialization.XmlAttribute]
		public ushort ID
		{
			get
			{
				short num = (short)1966245483;
				short num2 = num;
				num = (short)1217627755;
				switch (num2 == num)
				{
				}
				num = (short)1232338944;
				short num3 = num;
				num = (short)1570635777;
				if (num != 0)
				{
				}
				num = (short)1498218496;
				if (num != 0)
				{
				}
				return this.uId;
			}
			set
			{
				short num = (short)405762940;
				short num2 = num;
				num = (short)1161982844;
				switch (num2 == num)
				{
				}
				num = (short)1281163264;
				short num3 = num;
				num = (short)192610305;
				if (num != 0)
				{
				}
				num = (short)335151104;
				if (num != 0)
				{
				}
				this.uId = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000AC RID: 172 RVA: 0x000118E0 File Offset: 0x0000FAE0
		[global::System.Xml.Serialization.XmlElement(typeof(global::ASK.Core.AccessOperation))]
		[global::System.Xml.Serialization.XmlElement]
		[global::System.Xml.Serialization.XmlElement(typeof(global::ASK.Core.AccessRangeField))]
		[global::System.Xml.Serialization.XmlElement(typeof(global::ASK.Core.AccessField))]
		public global::System.Collections.ObjectModel.Collection<global::ASK.Core.AccessElement> Items
		{
			get
			{
				short num = (short)876919480;
				short num2 = num;
				num = (short)674413240;
				switch (num2 == num)
				{
				}
				num = (short)734330880;
				short num3 = num;
				num = (short)402259968;
				if (num != 0)
				{
				}
				num = (short)2133000193;
				if (num != 0)
				{
				}
				return this.items;
			}
		}

		// Token: 0x1700002F RID: 47
		public global::ASK.Core.AccessElement this[int id]
		{
			get
			{
				short num = (short)1436352513;
				if (num != 0)
				{
				}
				num = (short)956497920;
				short num2 = num;
				global::ASK.Core.AccessElement result = null;
				global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessElement> enumerator = this.items.GetEnumerator();
				try
				{
					num = (short)919011333;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::ASK.Core.AccessElement accessElement;
						switch (num3)
						{
						case 0:
							if (this.uId == (ushort)accessElement.ID)
							{
								num = (short)28915751;
								short num4 = num;
								num = (short)825964583;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_175;
								default:
									num = (short)247332864;
									if (num != 0)
									{
									}
									num = (short)1073545218;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
							}
							break;
						case 1:
							num = (short)2069495811;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_175;
						case 3:
							goto IL_1AC;
						case 4:
							if (!enumerator.MoveNext())
							{
								num = (short)1142751233;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							accessElement = enumerator.Current;
							num = (short)786038784;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							switch (0)
							{
							case 0:
								goto IL_A2;
							}
							continue;
						case 6:
							goto IL_18F;
						}
						IL_137:
						num = (short)1129840644;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_A2:
						goto IL_137;
						IL_175:
						result = accessElement;
						num = (short)1706950662;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_18F:
					IL_1AC:;
				}
				finally
				{
					num = (short)815923201;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)992608258;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_1E0;
							}
							continue;
						case 2:
							goto IL_214;
						}
						IL_1E0:
						if (enumerator == null)
						{
							break;
						}
						num = (short)942276608;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_214:;
				}
				return result;
			}
		}

		// Token: 0x17000030 RID: 48
		public global::ASK.Core.AccessElement this[string name]
		{
			get
			{
				short num = (short)2078343169;
				if (num != 0)
				{
				}
				num = (short)545259520;
				short num2 = num;
				global::ASK.Core.AccessElement result = null;
				global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessElement> enumerator = this.items.GetEnumerator();
				try
				{
					num = (short)1187315717;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::ASK.Core.AccessElement accessElement;
						switch (num3)
						{
						case 0:
							if (name == accessElement.Name)
							{
								num = (short)2132708845;
								short num4 = num;
								num = (short)287411693;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_175;
								default:
									num = (short)1800142848;
									if (num != 0)
									{
									}
									num = (short)1202847746;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
							}
							break;
						case 1:
							num = (short)1320747011;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_175;
						case 3:
							goto IL_1AB;
						case 4:
							if (!enumerator.MoveNext())
							{
								num = (short)2095841281;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							accessElement = enumerator.Current;
							num = (short)410910720;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							switch (0)
							{
							case 0:
								goto IL_A1;
							}
							continue;
						case 6:
							goto IL_18F;
						}
						IL_139:
						num = (short)1277886468;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_A1:
						goto IL_139;
						IL_175:
						result = accessElement;
						num = (short)1932394502;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_18F:
					IL_1AB:;
				}
				finally
				{
					num = (short)2034302977;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)905510914;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_1DE;
							}
							continue;
						case 2:
							goto IL_212;
						}
						IL_1DE:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1376976896;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_212:;
				}
				return result;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00011E14 File Offset: 0x00010014
		// (set) Token: 0x060000B0 RID: 176 RVA: 0x00012104 File Offset: 0x00010304
		[global::System.Xml.Serialization.XmlIgnore]
		public global::ASK.Interface.AccessLevelType AccessLevel
		{
			get
			{
				short num = (short)1847132160;
				short num2 = num;
				global::ASK.Interface.AccessLevelType result = global::ASK.Interface.AccessLevelType.Editable;
				global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessElement> enumerator = this.items.GetEnumerator();
				try
				{
					num = (short)1165361162;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							global::ASK.Core.AccessElement accessElement;
							if (accessElement is global::ASK.Core.AccessField)
							{
								num = (short)1679228937;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							result = global::ASK.Interface.AccessLevelType.Editable;
							num = (short)1018167302;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							global::ASK.Core.AccessElement accessElement;
							if (((global::ASK.Core.AccessField)accessElement).AccessLevel == global::ASK.Interface.AccessLevelType.ReadOnly)
							{
								num = (short)2063138827;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)659554309;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::ASK.Core.AccessElement accessElement = enumerator.Current;
							num = (short)784203776;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_25B;
						case 5:
							num = (short)354025476;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_23F;
						case 8:
						{
							global::ASK.Core.AccessElement accessElement;
							if (((global::ASK.Core.AccessField)accessElement).AccessLevel == global::ASK.Interface.AccessLevelType.Editable)
							{
								num = (short)1329201153;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1833369602;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							num = (short)1881604104;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							switch (0)
							{
							case 0:
								goto IL_8E;
							}
							continue;
						case 11:
							result = global::ASK.Interface.AccessLevelType.ReadOnly;
							num = (short)688717831;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_D1:
						num = (short)1135757757;
						short num4 = num;
						num = (short)185223613;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_25B;
						default:
							num = (short)2016149505;
							if (num != 0)
							{
							}
							num = (short)1875181568;
							if (num != 0)
							{
							}
							num = (short)1866203139;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_8E:
						goto IL_D1;
					}
					IL_23F:
					IL_25B:;
				}
				finally
				{
					num = (short)697499649;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)120324098;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_28D;
							}
							continue;
						case 2:
							goto IL_2C0;
						}
						IL_28D:
						if (enumerator == null)
						{
							break;
						}
						num = (short)229113856;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_2C0:;
				}
				return result;
			}
			set
			{
				short num = (short)360775681;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessElement> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_A7;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 2:
						try
						{
							num = (short)854065163;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::ASK.Core.AccessElement accessElement;
									((global::ASK.Core.AccessField)accessElement).AccessLevel = value;
									num = (short)1578565640;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_2DB;
								case 3:
								{
									if (value == global::ASK.Interface.AccessLevelType.Editable)
									{
										num = (short)1683488778;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::ASK.Core.AccessElement accessElement;
									((global::ASK.Core.AccessOperation)accessElement).AccessLevel = false;
									num = (short)1224648793;
									short num3 = num;
									num = (short)613853273;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)1070858240;
										if (num != 0)
										{
										}
										num = (short)209911810;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)961413126;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::ASK.Core.AccessElement accessElement = enumerator.Current;
									num = (short)2018181129;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)11468801;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									num = (short)1159004163;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::ASK.Core.AccessElement accessElement;
									if (accessElement is global::ASK.Core.AccessField)
									{
										num = (short)1571422208;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)477757452;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									global::ASK.Core.AccessElement accessElement;
									((global::ASK.Core.AccessOperation)accessElement).AccessLevel = true;
									num = (short)1306918917;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									switch (0)
									{
									case 0:
										goto IL_104;
									}
									continue;
								case 12:
								{
									global::ASK.Core.AccessElement accessElement;
									if (accessElement is global::ASK.Core.AccessOperation)
									{
										num = (short)630128647;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_1BD:
								num = (short)1680080900;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_104:
								goto IL_1BD;
							}
							IL_2DB:
							return;
						}
						finally
						{
							num = (short)986316801;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1637482498;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_310;
									}
									continue;
								case 2:
									goto IL_343;
								}
								IL_310:
								if (enumerator == null)
								{
									break;
								}
								num = (short)712376320;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_343:;
						}
						goto IL_346;
					}
					IL_31:
					num = (short)102563841;
					if (num != 0)
					{
					}
					if (!global::ASK.Core.AcpSecurity.a())
					{
						num = (short)1011613696;
						short num4 = num;
						num = (short)286392320;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_346:
					enumerator = this.items.GetEnumerator();
					num = (short)1615462402;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A7:
				throw new global::ASK.Core.AcpSecurityException();
			}
		}

		// Token: 0x04000035 RID: 53
		private ushort uId;

		// Token: 0x04000036 RID: 54
		private string name;

		// Token: 0x04000037 RID: 55
		private string uiName;

		// Token: 0x04000038 RID: 56
		private global::System.Collections.ObjectModel.Collection<global::ASK.Core.AccessElement> items;
	}
}
