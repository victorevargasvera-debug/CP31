using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml.Serialization;
using ASK.Interface;

namespace ASK.Core
{
	// Token: 0x0200000A RID: 10
	[global::System.Serializable]
	public class AccessNode : global::ASK.Core.IAcpSecurity
	{
		// Token: 0x06000039 RID: 57 RVA: 0x00005CF0 File Offset: 0x00003EF0
		public AccessNode(string strName, string strUiName, global::ASK.Core.AccessNodeIDType id)
		{
			this.uId = id;
			this.name = strName;
			this.uiName = strUiName;
			this.sections = new global::System.Collections.ObjectModel.Collection<global::ASK.Core.AccessSection>();
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00005D24 File Offset: 0x00003F24
		public AccessNode()
		{
			this.uId = global::ASK.Core.AccessNodeIDType.UNDEFINED;
			this.name = null;
			this.uiName = null;
			this.sections = new global::System.Collections.ObjectModel.Collection<global::ASK.Core.AccessSection>();
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00005D58 File Offset: 0x00003F58
		// (set) Token: 0x0600003C RID: 60 RVA: 0x00005E08 File Offset: 0x00004008
		[global::System.Xml.Serialization.XmlAttribute]
		public string Name
		{
			get
			{
				short num = (short)2122531825;
				short num2 = num;
				num = (short)392709105;
				switch (num2 == num)
				{
				}
				num = (short)335675392;
				short num3 = num;
				num = (short)72679425;
				if (num != 0)
				{
				}
				num = (short)1372651520;
				if (num != 0)
				{
				}
				return this.name;
			}
			set
			{
				short num = (short)2063580208;
				short num2 = num;
				num = (short)2070002736;
				switch (num2 == num)
				{
				}
				num = (short)1415643136;
				short num3 = num;
				num = (short)141295617;
				if (num != 0)
				{
				}
				num = (short)209911808;
				if (num != 0)
				{
				}
				this.name = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00005EB8 File Offset: 0x000040B8
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00005F6C File Offset: 0x0000416C
		[global::System.Xml.Serialization.XmlAttribute]
		public string UIName
		{
			get
			{
				short num = (short)133955497;
				short num2 = num;
				num = (short)93650857;
				switch (num2 == num)
				{
				}
				num = (short)1120010240;
				short num3 = num;
				num = (short)1831796737;
				if (num != 0)
				{
				}
				num = (short)1411973120;
				if (num != 0)
				{
				}
				return this.uiName;
			}
			set
			{
				short num = (short)1689619794;
				short num2 = num;
				num = (short)783781202;
				switch (num2 == num)
				{
				}
				num = (short)566558720;
				short num3 = num;
				num = (short)234684417;
				if (num != 0)
				{
				}
				num = (short)1038286848;
				if (num != 0)
				{
				}
				this.uiName = value;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00006018 File Offset: 0x00004218
		// (set) Token: 0x06000040 RID: 64 RVA: 0x000060C8 File Offset: 0x000042C8
		[global::System.Xml.Serialization.XmlAttribute]
		public global::ASK.Core.AccessNodeIDType ID
		{
			get
			{
				short num = (short)1171201514;
				short num2 = num;
				num = (short)602938858;
				switch (num2 == num)
				{
				}
				num = (short)682360832;
				short num3 = num;
				num = (short)1057685505;
				if (num != 0)
				{
				}
				num = (short)152436736;
				if (num != 0)
				{
				}
				return this.uId;
			}
			set
			{
				short num = (short)1949991952;
				short num2 = num;
				num = (short)1693484048;
				switch (num2 == num)
				{
				}
				num = (short)791674880;
				short num3 = num;
				num = (short)1003814913;
				if (num != 0)
				{
				}
				num = (short)1224474624;
				if (num != 0)
				{
				}
				this.uId = value;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000041 RID: 65 RVA: 0x00006178 File Offset: 0x00004378
		[global::System.Xml.Serialization.XmlElement("Section")]
		public global::System.Collections.ObjectModel.Collection<global::ASK.Core.AccessSection> Sections
		{
			get
			{
				short num = (short)898691554;
				short num2 = num;
				num = (short)1734013410;
				switch (num2 == num)
				{
				}
				num = (short)2080964608;
				short num3 = num;
				num = (short)1605173249;
				if (num != 0)
				{
				}
				num = (short)224854016;
				if (num != 0)
				{
				}
				return this.sections;
			}
		}

		// Token: 0x17000015 RID: 21
		public global::ASK.Core.AccessSection this[int id]
		{
			get
			{
				global::ASK.Core.AccessSection result = null;
				global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessSection> enumerator = this.sections.GetEnumerator();
				short num;
				try
				{
					num = (short)692060160;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_52;
							}
							continue;
						case 1:
						{
							global::ASK.Core.AccessSection accessSection;
							result = accessSection;
							num = (short)117047300;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_11D;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1887043586;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::ASK.Core.AccessSection accessSection = enumerator.Current;
							num = (short)525271046;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_139;
						case 5:
							goto IL_155;
						case 6:
						{
							num = (short)868507576;
							short num3 = num;
							num = (short)533487544;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_11D;
							default:
							{
								num = (short)844169216;
								if (num != 0)
								{
								}
								global::ASK.Core.AccessSection accessSection;
								if (id == (int)accessSection.ID)
								{
									num = (short)1343356929;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							break;
						}
						}
						IL_E2:
						num = (short)958398467;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_52:
						goto IL_E2;
						IL_11D:
						num = (short)712900613;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_139:
					IL_155:;
				}
				finally
				{
					num = (short)433324034;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1187053569;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_1BB;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_187;
							}
							continue;
						}
						IL_187:
						if (enumerator == null)
						{
							break;
						}
						num = (short)433520640;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1BB:;
				}
				num = (short)833748992;
				short num4 = num;
				num = (short)1743257601;
				if (num != 0)
				{
				}
				return result;
			}
		}

		// Token: 0x17000016 RID: 22
		public global::ASK.Core.AccessSection this[string name]
		{
			get
			{
				global::ASK.Core.AccessSection result = null;
				global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessSection> enumerator = this.sections.GetEnumerator();
				short num;
				try
				{
					num = (short)901054464;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_50;
							}
							continue;
						case 1:
						{
							global::ASK.Core.AccessSection accessSection;
							result = accessSection;
							num = (short)199360516;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_11C;
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)937164802;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::ASK.Core.AccessSection accessSection = enumerator.Current;
							num = (short)1546518534;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_137;
						case 5:
							goto IL_154;
						case 6:
						{
							num = (short)189670637;
							short num3 = num;
							num = (short)1244669165;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_11C;
							default:
							{
								num = (short)1054212096;
								if (num != 0)
								{
								}
								global::ASK.Core.AccessSection accessSection;
								if (name == accessSection.Name)
								{
									num = (short)315424769;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							break;
						}
						}
						IL_E3:
						num = (short)1054015491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_50:
						goto IL_E3;
						IL_11C:
						num = (short)255459333;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_137:
					IL_154:;
				}
				finally
				{
					num = (short)1322254338;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)2010841089;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_1B9;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_186;
							}
							continue;
						}
						IL_186:
						if (enumerator == null)
						{
							break;
						}
						num = (short)409927680;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1B9:;
				}
				num = (short)1679097856;
				short num4 = num;
				num = (short)1621950465;
				if (num != 0)
				{
				}
				return result;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000044 RID: 68 RVA: 0x0000669C File Offset: 0x0000489C
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00006938 File Offset: 0x00004B38
		[global::System.Xml.Serialization.XmlIgnore]
		public global::ASK.Interface.AccessLevelType AccessLevel
		{
			get
			{
				global::ASK.Interface.AccessLevelType result = global::ASK.Interface.AccessLevelType.Editable;
				global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessSection> enumerator = this.sections.GetEnumerator();
				short num;
				try
				{
					num = (short)1666187266;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							result = global::ASK.Interface.AccessLevelType.ReadOnly;
							num = (short)634454022;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							global::ASK.Core.AccessSection accessSection;
							if (accessSection.AccessLevel == global::ASK.Interface.AccessLevelType.Editable)
							{
								num = (short)1678770180;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1128595459;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_5C;
							}
							continue;
						case 3:
						{
							num = (short)158558118;
							short num3 = num;
							num = (short)75917222;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							default:
							{
								num = (short)861339648;
								if (num != 0)
								{
								}
								global::ASK.Core.AccessSection accessSection;
								if (accessSection.AccessLevel == global::ASK.Interface.AccessLevelType.ReadOnly)
								{
									num = (short)700579840;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							break;
						}
						case 4:
							result = global::ASK.Interface.AccessLevelType.Editable;
							num = (short)1631977479;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							num = (short)279576584;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_74;
						case 8:
							goto IL_1B3;
						case 9:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)20774917;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::ASK.Core.AccessSection accessSection = enumerator.Current;
							num = (short)156237825;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_79:
						num = (short)1701380105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_5C:
						goto IL_79;
					}
					IL_74:
					IL_1B3:;
				}
				finally
				{
					num = (short)1595736066;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1801060353;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_243;
						case 2:
							num = (short)408813569;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_20F;
							}
							continue;
						}
						IL_20F:
						if (enumerator == null)
						{
							break;
						}
						num = (short)61210624;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_243:;
				}
				num = (short)1333526528;
				short num4 = num;
				return result;
			}
			set
			{
				short num = (short)1208156162;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::ASK.Core.AccessSection> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_4F;
					case 1:
					{
						num = (short)977141760;
						short num3 = num;
						try
						{
							num = (short)1004404740;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									goto IL_FC;
								case 2:
									num = (short)643170305;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									if (!enumerator.MoveNext())
									{
										num = (short)1068892162;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									enumerator.Current.AccessLevel = value;
									num = (short)811859968;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_8E;
									}
									continue;
								}
								IL_B2:
								num = (short)1153630211;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_8E:
								goto IL_B2;
							}
							IL_FC:
							goto IL_212;
						}
						finally
						{
							num = (short)591986690;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1B6;
								case 1:
									enumerator.Dispose();
									num = (short)1796669440;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_115;
								}
								goto IL_131;
								IL_115:
								switch (0)
								{
								case 0:
								{
									IL_131:
									if (enumerator == null)
									{
										goto IL_1B8;
									}
									num = (short)602498819;
									short num4 = num;
									num = (short)5007107;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_115;
									default:
										num = (short)146931712;
										if (num != 0)
										{
										}
										num = (short)418316289;
										num2 = (int)((global::System.IntPtr)num);
										break;
									}
									break;
								}
								}
							}
							IL_1B6:
							IL_1B8:;
						}
						goto IL_1B9;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					}
					IL_30:
					if (!global::ASK.Core.AcpSecurity.a())
					{
						num = (short)2022178816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_1B9:
					enumerator = this.sections.GetEnumerator();
					num = (short)101515265;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_4F:
				throw new global::ASK.Core.AcpSecurityException();
				IL_212:
				num = (short)1359151105;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x04000012 RID: 18
		private global::ASK.Core.AccessNodeIDType uId;

		// Token: 0x04000013 RID: 19
		private string name;

		// Token: 0x04000014 RID: 20
		private string uiName;

		// Token: 0x04000015 RID: 21
		private global::System.Collections.ObjectModel.Collection<global::ASK.Core.AccessSection> sections;
	}
}
