using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml.Serialization;

namespace AcpASKLib
{
	// Token: 0x0200000E RID: 14
	[global::System.Serializable]
	public class AccessNode : global::AcpASKLib.IAcpSecurity
	{
		// Token: 0x06000039 RID: 57 RVA: 0x00006054 File Offset: 0x00004254
		public AccessNode(string strName, string strUiName, global::AcpASKLib.AccessNodeIDType id)
		{
			this.uId = id;
			this.name = strName;
			this.uiName = strUiName;
			this.sections = new global::System.Collections.ObjectModel.Collection<global::AcpASKLib.AccessSection>();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00006088 File Offset: 0x00004288
		public AccessNode()
		{
			this.uId = global::AcpASKLib.AccessNodeIDType.UNDEFINED;
			this.name = null;
			this.uiName = null;
			this.sections = new global::System.Collections.ObjectModel.Collection<global::AcpASKLib.AccessSection>();
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003B RID: 59 RVA: 0x000060BC File Offset: 0x000042BC
		// (set) Token: 0x0600003C RID: 60 RVA: 0x0000616C File Offset: 0x0000436C
		[global::System.Xml.Serialization.XmlAttribute]
		public string Name
		{
			get
			{
				short num = (short)1992080660;
				short num2 = num;
				num = (short)2054929684;
				switch (num2 == num)
				{
				default:
				{
					num = (short)797573120;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)714145793;
				if (num != 0)
				{
				}
				num = (short)892141568;
				if (num != 0)
				{
				}
				return this.name;
			}
			set
			{
				short num = (short)1459491395;
				short num2 = num;
				num = (short)1042092611;
				switch (num2 == num)
				{
				default:
				{
					num = (short)680001536;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)466550785;
				if (num != 0)
				{
				}
				num = (short)1699151872;
				if (num != 0)
				{
				}
				this.name = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600003D RID: 61 RVA: 0x0000621C File Offset: 0x0000441C
		// (set) Token: 0x0600003E RID: 62 RVA: 0x000062CC File Offset: 0x000044CC
		[global::System.Xml.Serialization.XmlAttribute]
		public string UIName
		{
			get
			{
				short num = (short)1814818953;
				short num2 = num;
				num = (short)263975049;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2112421888;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)104005633;
				if (num != 0)
				{
				}
				num = (short)970326016;
				if (num != 0)
				{
				}
				return this.uiName;
			}
			set
			{
				short num = (short)729303492;
				short num2 = num;
				num = (short)603277764;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1767047168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)761462785;
				if (num != 0)
				{
				}
				num = (short)492306432;
				if (num != 0)
				{
				}
				this.uiName = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600003F RID: 63 RVA: 0x0000637C File Offset: 0x0000457C
		// (set) Token: 0x06000040 RID: 64 RVA: 0x00006428 File Offset: 0x00004628
		[global::System.Xml.Serialization.XmlAttribute]
		public global::AcpASKLib.AccessNodeIDType ID
		{
			get
			{
				short num = (short)974332288;
				short num2 = num;
				num = (short)1855594880;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1964703744;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)510656513;
				if (num != 0)
				{
				}
				num = (short)1178402816;
				if (num != 0)
				{
				}
				return this.uId;
			}
			set
			{
				short num = (short)501672992;
				short num2 = num;
				num = (short)1031007264;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1803747328;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1546977281;
				if (num != 0)
				{
				}
				num = (short)1798242304;
				if (num != 0)
				{
				}
				this.uId = value;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000041 RID: 65 RVA: 0x000064D8 File Offset: 0x000046D8
		[global::System.Xml.Serialization.XmlElement("Section")]
		public global::System.Collections.ObjectModel.Collection<global::AcpASKLib.AccessSection> Sections
		{
			get
			{
				short num = (short)1345908483;
				short num2 = num;
				num = (short)485682947;
				switch (num2 == num)
				{
				default:
				{
					num = (short)459669504;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1435631617;
				if (num != 0)
				{
				}
				num = (short)1151598592;
				if (num != 0)
				{
				}
				return this.sections;
			}
		}

		// Token: 0x17000016 RID: 22
		public global::AcpASKLib.AccessSection this[int id]
		{
			get
			{
				short num = (short)2042494976;
				short num2 = num;
				global::AcpASKLib.AccessSection result = null;
				global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessSection> enumerator = this.sections.GetEnumerator();
				try
				{
					num = (short)1119223813;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							global::AcpASKLib.AccessSection accessSection;
							result = accessSection;
							num = (short)204996611;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							num = (short)772734980;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							global::AcpASKLib.AccessSection accessSection;
							if (id == (int)accessSection.ID)
							{
								num = (short)591790080;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							goto IL_107;
						case 4:
							goto IL_125;
						case 5:
							switch (0)
							{
							case 0:
								goto IL_7B;
							}
							continue;
						case 6:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)145752065;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpASKLib.AccessSection accessSection = enumerator.Current;
							num = (short)749207554;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_B8:
						num = (short)1460731910;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_7B:
						goto IL_B8;
					}
					IL_107:
					IL_125:;
				}
				finally
				{
					num = (short)437977089;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_1DF;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_15B;
							}
							continue;
						case 2:
						{
							enumerator.Dispose();
							num = (short)156587625;
							short num4 = num;
							num = (short)387143273;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_161;
							default:
								num = (short)2095448064;
								if (num != 0)
								{
								}
								num = (short)977534976;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						goto IL_15B;
						IL_161:
						num = (short)1146945538;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_15B:
						if (enumerator != null)
						{
							goto IL_161;
						}
						break;
					}
					IL_1DF:;
				}
				num = (short)643235841;
				if (num != 0)
				{
				}
				return result;
			}
		}

		// Token: 0x17000017 RID: 23
		public global::AcpASKLib.AccessSection this[string name]
		{
			get
			{
				short num = (short)1318322176;
				short num2 = num;
				num = (short)228152723;
				short num3 = num;
				num = (short)119035283;
				global::AcpASKLib.AccessSection result;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)295305216;
					if (num != 0)
					{
					}
					result = null;
					global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessSection> enumerator = this.sections.GetEnumerator();
					try
					{
						num = (short)1659109377;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1509097476;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpASKLib.AccessSection accessSection = enumerator.Current;
								num = (short)1052573698;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								switch (0)
								{
								case 0:
									goto IL_C6;
								}
								continue;
							case 2:
							{
								global::AcpASKLib.AccessSection accessSection;
								if (name == accessSection.Name)
								{
									num = (short)1036058627;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
							{
								global::AcpASKLib.AccessSection accessSection;
								result = accessSection;
								num = (short)1550974981;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								num = (short)1649278982;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								goto IL_157;
							case 6:
								goto IL_174;
							}
							IL_108:
							num = (short)952434688;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_C6:
							goto IL_108;
						}
						IL_157:
						IL_174:;
					}
					finally
					{
						num = (short)1387921408;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_1AA;
								}
								continue;
							case 1:
								num = (short)816906241;
								if (num != 0)
								{
								}
								enumerator.Dispose();
								num = (short)1683161090;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_204;
							}
							IL_1AA:
							if (enumerator == null)
							{
								break;
							}
							num = (short)376504321;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_204:;
					}
					break;
				}
				}
				return result;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000044 RID: 68 RVA: 0x000069DC File Offset: 0x00004BDC
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00006C70 File Offset: 0x00004E70
		[global::System.Xml.Serialization.XmlIgnore]
		public global::AcpASKLib.AccessLevelType AccessLevel
		{
			get
			{
				short num = (short)1857945600;
				short num2 = num;
				num = (short)1245768393;
				short num3 = num;
				num = (short)1378609865;
				global::AcpASKLib.AccessLevelType result;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1503068161;
					if (num != 0)
					{
					}
					num = (short)1050804224;
					if (num != 0)
					{
					}
					result = global::AcpASKLib.AccessLevelType.Editable;
					global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessSection> enumerator = this.sections.GetEnumerator();
					try
					{
						num = (short)112590852;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								result = global::AcpASKLib.AccessLevelType.Editable;
								num = (short)167182338;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)711589894;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpASKLib.AccessSection accessSection = enumerator.Current;
								num = (short)1794637827;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								goto IL_111;
							case 3:
							{
								global::AcpASKLib.AccessSection accessSection;
								if (accessSection.AccessLevel == global::AcpASKLib.AccessLevelType.Editable)
								{
									num = (short)364838912;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1945239560;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								switch (0)
								{
								case 0:
									goto IL_F9;
								}
								continue;
							case 5:
								result = global::AcpASKLib.AccessLevelType.ReadOnly;
								num = (short)2117926919;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								num = (short)107413513;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
							{
								global::AcpASKLib.AccessSection accessSection;
								if (accessSection.AccessLevel == global::AcpASKLib.AccessLevelType.ReadOnly)
								{
									num = (short)797507589;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 9:
								goto IL_200;
							}
							IL_116:
							num = (short)1041891329;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_F9:
							goto IL_116;
						}
						IL_111:
						IL_200:;
					}
					finally
					{
						num = (short)94699520;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_232;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)420020226;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_265;
							}
							IL_232:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1398210561;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_265:;
					}
					break;
				}
				}
				return result;
			}
			set
			{
				short num = (short)671219712;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::AcpASKLib.AccessSection> enumerator;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 1:
					{
						num = (short)1717501952;
						short num3 = num;
						num = (short)447550271;
						short num4 = num;
						num = (short)1543770943;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_16A;
						default:
							goto IL_1F3;
						}
						break;
					}
					case 2:
						try
						{
							num = (short)928710656;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_8E;
									}
									continue;
								case 2:
									if (!enumerator.MoveNext())
									{
										num = (short)541327363;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									enumerator.Current.AccessLevel = value;
									num = (short)1143668737;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)2063335428;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_FC;
								}
								IL_B3:
								num = (short)1984233474;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_8E:
								goto IL_B3;
							}
							IL_FC:
							goto IL_20E;
						}
						finally
						{
							num = (short)1216937984;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_133;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)198049794;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_167;
								}
								IL_133:
								if (enumerator == null)
								{
									break;
								}
								num = (short)70254593;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_167:;
						}
						goto IL_16A;
					}
					IL_31:
					if (!global::AcpASKLib.AcpSecurity.a())
					{
						num = (short)1539571713;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_16A:
					enumerator = this.sections.GetEnumerator();
					num = (short)340262914;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1F3:
				num = (short)790822912;
				if (num != 0)
				{
				}
				throw new global::AcpASKLib.AcpSecurityException();
				IL_20E:
				num = (short)1254096897;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x040000D9 RID: 217
		private global::AcpASKLib.AccessNodeIDType uId;

		// Token: 0x040000DA RID: 218
		private string name;

		// Token: 0x040000DB RID: 219
		private string uiName;

		// Token: 0x040000DC RID: 220
		private global::System.Collections.ObjectModel.Collection<global::AcpASKLib.AccessSection> sections;
	}
}
