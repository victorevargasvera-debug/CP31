using System;
using System.Collections.Generic;
using MSI;

namespace CommonLicenseInterfaceWrapper
{
	// Token: 0x02000013 RID: 19
	public class LineItem
	{
		// Token: 0x06000094 RID: 148 RVA: 0x00008C3C File Offset: 0x00006E3C
		public static implicit operator global::MSI.LineItem(global::CommonLicenseInterfaceWrapper.LineItem parameter)
		{
			short num = (short)688315477;
			short num2 = num;
			num = (short)349887573;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1438973952;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1398472705;
			if (num != 0)
			{
			}
			num = (short)1539833856;
			if (num != 0)
			{
			}
			return parameter.a;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00008CF0 File Offset: 0x00006EF0
		public static implicit operator global::CommonLicenseInterfaceWrapper.LineItem(global::MSI.LineItem parameter)
		{
			short num = (short)638929326;
			short num2 = num;
			num = (short)834423214;
			switch (num2 == num)
			{
			default:
			{
				num = (short)833683456;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)621019136;
			if (num != 0)
			{
			}
			num = (short)1226964993;
			if (num != 0)
			{
			}
			return new global::CommonLicenseInterfaceWrapper.LineItem
			{
				a = parameter
			};
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00008DA8 File Offset: 0x00006FA8
		static LineItem()
		{
			short num = (short)213856189;
			short num2 = num;
			num = (short)650129341;
			switch (num2 == num)
			{
			default:
			{
				num = (short)466092032;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)81723393;
			if (num != 0)
			{
			}
			num = (short)990642176;
			if (num != 0)
			{
			}
			global::CommonLicenseInterfaceWrapper.CommonLicenseInterfaceDllLoader.b();
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00008E58 File Offset: 0x00007058
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00008F0C File Offset: 0x0000710C
		public global::System.Collections.Generic.IDictionary<string, string> dictionary
		{
			get
			{
				short num = (short)1007989328;
				short num2 = num;
				num = (short)1996993104;
				switch (num2 == num)
				{
				default:
				{
					num = (short)478543872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1481768961;
				if (num != 0)
				{
				}
				num = (short)1299906560;
				if (num != 0)
				{
				}
				return this.a.dictionary;
			}
			set
			{
				short num = (short)1215812964;
				short num2 = num;
				num = (short)425121124;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1854930944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)545062912;
				if (num != 0)
				{
				}
				num = (short)1269170177;
				if (num != 0)
				{
				}
				this.a.dictionary = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00008FC0 File Offset: 0x000071C0
		// (set) Token: 0x0600009A RID: 154 RVA: 0x000091B4 File Offset: 0x000073B4
		public global::System.Collections.Generic.ICollection<global::CommonLicenseInterfaceWrapper.ProductInfo> productInfoList
		{
			get
			{
				short num = (short)1855586305;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.List<global::CommonLicenseInterfaceWrapper.ProductInfo> list = new global::System.Collections.Generic.List<global::CommonLicenseInterfaceWrapper.ProductInfo>();
				global::System.Collections.Generic.IEnumerator<global::MSI.ProductInfo> enumerator = this.a.productInfoList.GetEnumerator();
				try
				{
					num = (short)1355808772;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1919746051;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::MSI.ProductInfo parameter = enumerator.Current;
							list.Add(parameter);
							num = (short)1031929856;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_EF;
						case 3:
							num = (short)363593730;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_79;
							}
							continue;
						}
						IL_A5:
						num = (short)1018101761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_79:
						goto IL_A5;
					}
					IL_EF:;
				}
				finally
				{
					num = (short)1172963330;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_1AB;
						case 1:
						{
							num = (short)436968332;
							short num3 = num;
							num = (short)1064606604;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_12B;
							default:
								num = (short)532217856;
								if (num != 0)
								{
								}
								enumerator.Dispose();
								num = (short)1205731328;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_125;
							}
							continue;
						}
						goto IL_125;
						IL_12B:
						num = (short)832962561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_125:
						if (enumerator != null)
						{
							goto IL_12B;
						}
						break;
					}
					IL_1AB:;
				}
				num = (short)468320256;
				short num4 = num;
				return list;
			}
			set
			{
				short num = (short)1772224513;
				if (num != 0)
				{
				}
				num = (short)899350528;
				short num2 = num;
				global::System.Collections.Generic.List<global::MSI.ProductInfo> list = new global::System.Collections.Generic.List<global::MSI.ProductInfo>();
				global::System.Collections.Generic.IEnumerator<global::CommonLicenseInterfaceWrapper.ProductInfo> enumerator = value.GetEnumerator();
				try
				{
					num = (short)36789818;
					short num3 = num;
					num = (short)73227834;
					int num4;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_BC:
						switch (0)
						{
						case 0:
							goto IL_E0;
						}
						break;
					default:
						num = (short)941031424;
						if (num != 0)
						{
						}
						num = (short)2133327875;
						num4 = (int)((global::System.IntPtr)num);
						break;
					}
					for (;;)
					{
						IL_C6:
						switch (num4)
						{
						case 0:
							num = (short)826408964;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1159659520;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::CommonLicenseInterfaceWrapper.ProductInfo parameter = enumerator.Current;
							list.Add(parameter);
							num = (short)141885441;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_BC;
						case 4:
							goto IL_156;
						}
						break;
					}
					goto IL_10B;
					IL_156:
					goto IL_1C1;
					IL_E0:
					IL_10B:
					num = (short)135397378;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_C6;
				}
				finally
				{
					num = (short)1347420161;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							enumerator.Dispose();
							num = (short)766574594;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_189;
							}
							continue;
						case 2:
							goto IL_1BE;
						}
						IL_189:
						if (enumerator == null)
						{
							break;
						}
						num = (short)897253376;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_1BE:;
				}
				IL_1C1:
				this.a.productInfoList = list;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600009B RID: 155 RVA: 0x000093A0 File Offset: 0x000075A0
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00009454 File Offset: 0x00007654
		public bool isTrustedType
		{
			get
			{
				short num = (short)1711869083;
				short num2 = num;
				num = (short)832244891;
				switch (num2 == num)
				{
				}
				num = (short)1991770113;
				if (num != 0)
				{
				}
				num = (short)299433984;
				short num3 = num;
				num = (short)704118784;
				if (num != 0)
				{
				}
				return this.a.isTrustedType;
			}
			set
			{
				short num = (short)178841861;
				short num2 = num;
				num = (short)572844293;
				switch (num2 == num)
				{
				}
				num = (short)725549057;
				if (num != 0)
				{
				}
				num = (short)1235091456;
				short num3 = num;
				num = (short)282984448;
				if (num != 0)
				{
				}
				this.a.isTrustedType = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00009508 File Offset: 0x00007708
		// (set) Token: 0x0600009E RID: 158 RVA: 0x000095BC File Offset: 0x000077BC
		public string activationId
		{
			get
			{
				short num = (short)1473573066;
				short num2 = num;
				num = (short)237957322;
				switch (num2 == num)
				{
				}
				num = (short)121176065;
				if (num != 0)
				{
				}
				num = (short)365756416;
				short num3 = num;
				num = (short)153681920;
				if (num != 0)
				{
				}
				return this.a.activationId;
			}
			set
			{
				short num = (short)1554722617;
				short num2 = num;
				num = (short)1385246521;
				switch (num2 == num)
				{
				}
				num = (short)340525056;
				if (num != 0)
				{
				}
				num = (short)683016192;
				short num3 = num;
				num = (short)1371668481;
				if (num != 0)
				{
				}
				this.a.activationId = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00009670 File Offset: 0x00007870
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x00009724 File Offset: 0x00007924
		public string expirationDate
		{
			get
			{
				short num = (short)1981759476;
				short num2 = num;
				num = (short)487800820;
				switch (num2 == num)
				{
				}
				num = (short)2100953089;
				if (num != 0)
				{
				}
				num = (short)1507590144;
				short num3 = num;
				num = (short)1610743808;
				if (num != 0)
				{
				}
				return this.a.expirationDate;
			}
			set
			{
				short num = (short)1800770606;
				short num2 = num;
				num = (short)1158911022;
				switch (num2 == num)
				{
				}
				num = (short)1637613569;
				if (num != 0)
				{
				}
				num = (short)1758855168;
				short num3 = num;
				num = (short)401539072;
				if (num != 0)
				{
				}
				this.a.expirationDate = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x000097D8 File Offset: 0x000079D8
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x0000988C File Offset: 0x00007A8C
		public bool isPermanent
		{
			get
			{
				short num = (short)2003483802;
				short num2 = num;
				num = (short)2033892506;
				switch (num2 == num)
				{
				}
				num = (short)1322909696;
				if (num != 0)
				{
				}
				num = (short)177340416;
				short num3 = num;
				num = (short)2127888385;
				if (num != 0)
				{
				}
				return this.a.isPermanent;
			}
			set
			{
				short num = (short)1076700259;
				short num2 = num;
				num = (short)526525539;
				switch (num2 == num)
				{
				}
				num = (short)1273692161;
				if (num != 0)
				{
				}
				num = (short)459145216;
				short num3 = num;
				num = (short)1566769152;
				if (num != 0)
				{
				}
				this.a.isPermanent = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00009940 File Offset: 0x00007B40
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x000099F4 File Offset: 0x00007BF4
		public int totalCount
		{
			get
			{
				short num = (short)2011766296;
				short num2 = num;
				num = (short)610016792;
				switch (num2 == num)
				{
				}
				num = (short)744161280;
				if (num != 0)
				{
				}
				num = (short)654704640;
				short num3 = num;
				num = (short)134086657;
				if (num != 0)
				{
				}
				return this.a.totalCount;
			}
			set
			{
				short num = (short)268919316;
				short num2 = num;
				num = (short)623862292;
				switch (num2 == num)
				{
				}
				num = (short)662372353;
				if (num != 0)
				{
				}
				num = (short)1690238976;
				short num3 = num;
				num = (short)1322909696;
				if (num != 0)
				{
				}
				this.a.totalCount = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x00009AAC File Offset: 0x00007CAC
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x00009B60 File Offset: 0x00007D60
		public int availableCount
		{
			get
			{
				short num = (short)1104936961;
				if (num != 0)
				{
				}
				num = (short)714364827;
				short num2 = num;
				num = (short)345331611;
				switch (num2 == num)
				{
				}
				num = (short)1920794624;
				short num3 = num;
				num = (short)1208025088;
				if (num != 0)
				{
				}
				return this.a.availableCount;
			}
			set
			{
				short num = (short)863643159;
				short num2 = num;
				num = (short)299705879;
				switch (num2 == num)
				{
				}
				num = (short)2049572865;
				if (num != 0)
				{
				}
				num = (short)1799028736;
				short num3 = num;
				num = (short)1007026176;
				if (num != 0)
				{
				}
				this.a.availableCount = value;
			}
		}

		// Token: 0x04000022 RID: 34
		private global::MSI.LineItem a = new global::MSI.LineItem();
	}
}
