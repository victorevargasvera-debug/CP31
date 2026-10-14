using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using CommonUtility;

namespace Motorola.CommonCPS.Common.CommonUtility.CSV
{
	// Token: 0x02000019 RID: 25
	[global::System.Serializable]
	public sealed class CsvFile
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x0600007B RID: 123 RVA: 0x0000DB44 File Offset: 0x0000BD44
		// (set) Token: 0x0600007C RID: 124 RVA: 0x0000DBF4 File Offset: 0x0000BDF4
		public bool HasHeaderRangeRow
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1905590272;
				short num2 = num;
				num = (short)1532115107;
				short num3 = num;
				num = (short)538458275;
				switch (num3 == num)
				{
				}
				num = (short)1208811520;
				if (num != 0)
				{
				}
				num = (short)339345409;
				if (num != 0)
				{
				}
				return this.<HasHeaderRangeRow>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1485045760;
				short num2 = num;
				num = (short)873748632;
				short num3 = num;
				num = (short)1387026584;
				switch (num3 == num)
				{
				}
				num = (short)1426784257;
				if (num != 0)
				{
				}
				num = (short)2042888192;
				if (num != 0)
				{
				}
				this.<HasHeaderRangeRow>k__BackingField = value;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600007D RID: 125 RVA: 0x0000DCA8 File Offset: 0x0000BEA8
		public int HeaderCount
		{
			get
			{
				short num = (short)147914752;
				short num2 = num;
				num = (short)1324810241;
				if (num != 0)
				{
				}
				num = (short)1006903931;
				short num3 = num;
				num = (short)2071077499;
				switch (num3 == num)
				{
				}
				num = (short)1435500544;
				if (num != 0)
				{
				}
				return this.Headers.Count;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600007E RID: 126 RVA: 0x0000DD5C File Offset: 0x0000BF5C
		public int RecordCount
		{
			get
			{
				short num = (short)200049017;
				short num2 = num;
				num = (short)1541374329;
				switch (num2 == num)
				{
				default:
				{
					num = (short)188153856;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1385431041;
				if (num != 0)
				{
				}
				num = (short)1404043264;
				if (num != 0)
				{
				}
				return this.Records.Count;
			}
		}

		// Token: 0x17000013 RID: 19
		public global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord this[int recordIndex]
		{
			get
			{
				short num = (short)1046018893;
				short num2 = num;
				num = (short)1767045965;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1224015872;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1943011329;
				if (num != 0)
				{
				}
				num = (short)1797783552;
				if (num != 0)
				{
				}
				return this.Records[recordIndex];
			}
		}

		// Token: 0x17000014 RID: 20
		public string this[int recordIndex, int fieldIndex]
		{
			get
			{
				short num = (short)1938789476;
				short num2 = num;
				num = (short)973313124;
				switch (num2 == num)
				{
				default:
				{
					num = (short)287703040;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1887371264;
				if (num != 0)
				{
				}
				num = (short)994312193;
				if (num != 0)
				{
				}
				return this.Records[recordIndex].Fields[fieldIndex];
			}
			set
			{
				short num = (short)356909057;
				if (num != 0)
				{
				}
				num = (short)548405248;
				short num2 = num;
				num = (short)1851064279;
				short num3 = num;
				num = (short)1819738071;
				switch (num3 == num)
				{
				}
				num = (short)1559298048;
				if (num != 0)
				{
				}
				this.Records[recordIndex].Fields[fieldIndex] = value;
			}
		}

		// Token: 0x17000015 RID: 21
		public string this[int recordIndex, string fieldName]
		{
			get
			{
				int num;
				int num3;
				int num2;
				short num4;
				global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord csvRecord;
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
							num2 = num3;
							num4 = (short)1825832966;
							num = (int)((global::System.IntPtr)num4);
							continue;
						case 1:
							if (num2 < csvRecord.Fields.Count)
							{
								num4 = (short)836763653;
								num = (int)((global::System.IntPtr)num4);
								continue;
							}
							goto IL_216;
						case 2:
							goto IL_86;
						case 3:
							goto IL_1D1;
						case 4:
							if (num3 >= this.Headers.Count)
							{
								num4 = (short)1801846786;
								num = (int)((global::System.IntPtr)num4);
								continue;
							}
							num4 = (short)945946631;
							num = (int)((global::System.IntPtr)num4);
							continue;
						case 5:
							goto IL_C6;
						case 6:
							num4 = (short)1485438977;
							if (num4 != 0)
							{
							}
							goto IL_86;
						case 7:
						{
							if (this.Headers[num3].Equals(fieldName, global::System.StringComparison.Ordinal))
							{
								num4 = (short)1684406272;
								num = (int)((global::System.IntPtr)num4);
								continue;
							}
							num4 = (short)1953197620;
							short num5 = num4;
							num4 = (short)1225485876;
							switch ((num5 == num4) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_45;
							default:
								num4 = (short)1551958016;
								if (num4 != 0)
								{
								}
								num3++;
								num4 = (short)649003011;
								num = (int)((global::System.IntPtr)num4);
								continue;
							}
							break;
						}
						case 8:
						{
							num4 = (short)845217792;
							short num6 = num4;
							goto IL_1D1;
						}
						}
						goto IL_34;
						IL_86:
						num4 = (short)216530945;
						num = (int)((global::System.IntPtr)num4);
						continue;
						IL_1D1:
						num4 = (short)540147716;
						num = (int)((global::System.IntPtr)num4);
					}
					IL_C6:
					return csvRecord.Fields[num2];
					IL_216:
					return null;
				}
				IL_34:
				csvRecord = this.Records[recordIndex];
				num2 = -1;
				num3 = 0;
				IL_45:
				num4 = (short)1459486728;
				num = (int)((global::System.IntPtr)num4);
				goto IL_0A;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_2C;
				}
				int num;
				int num2;
				short num3;
				int index;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_1B1;
					case 1:
						if (num2 >= this.Headers.Count)
						{
							num3 = (short)2102067200;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1576730629;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 2:
						goto IL_126;
					case 3:
						goto IL_175;
					case 4:
						index = num2;
						num3 = (short)619970562;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 5:
					{
						if (this.Headers[num2].Equals(fieldName, global::System.StringComparison.Ordinal))
						{
							num3 = (short)896729092;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)88587113;
						short num4 = num3;
						num3 = (short)1630976873;
						switch ((num4 == num3) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num3 = (short)235208704;
							if (num3 != 0)
							{
							}
							num3 = (short)1853423616;
							short num5 = num3;
							num2++;
							num3 = (short)832634881;
							if (num3 != 0)
							{
							}
							num3 = (short)19202051;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						}
						break;
					}
					case 6:
						goto IL_175;
					}
					goto IL_2C;
					IL_175:
					num3 = (short)1798832129;
					num = (int)((global::System.IntPtr)num3);
				}
				IL_126:
				IL_1B1:
				global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord csvRecord;
				csvRecord.Fields[index] = value;
				return;
				IL_2C:
				csvRecord = this.Records[recordIndex];
				index = -1;
				num2 = 0;
				num3 = (short)2055995398;
				num = (int)((global::System.IntPtr)num3);
				goto IL_0A;
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000E440 File Offset: 0x0000C640
		public void Populate(string filePath, bool hasHeaderRow, bool hasHeaderAlias)
		{
			short num = (short)1053622273;
			if (num != 0)
			{
			}
			num = (short)1886453760;
			short num2 = num;
			num = (short)1111531719;
			short num3 = num;
			num = (short)1943183559;
			switch (num3 == num)
			{
			}
			num = (short)575275008;
			if (num != 0)
			{
			}
			this.Populate(filePath, null, hasHeaderRow, hasHeaderAlias, false);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000E4F4 File Offset: 0x0000C6F4
		public void Populate(string filePath, bool hasHeaderRow, bool hasHeaderAlias, bool trimColumns)
		{
			short num = (short)73727404;
			short num2 = num;
			num = (short)125173164;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2110455808;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1709572097;
			if (num != 0)
			{
			}
			num = (short)1620180992;
			if (num != 0)
			{
			}
			this.Populate(filePath, null, hasHeaderRow, hasHeaderAlias, trimColumns);
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000E5AC File Offset: 0x0000C7AC
		public void Populate(string filePath, global::System.Text.Encoding encoding, bool hasHeaderRow, bool hasHeaderAlias, bool trimColumns)
		{
			global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvReader csvReader = new global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvReader(filePath, encoding);
			short num;
			try
			{
				num = (short)515244033;
				if (num != 0)
				{
				}
				csvReader.HasHeaderRow = hasHeaderRow;
				csvReader.HasHeaderAlias = hasHeaderAlias;
				csvReader.HasHeaderRangeRow = this.HasHeaderRangeRow;
				csvReader.TrimColumns = trimColumns;
				this.a(csvReader);
			}
			finally
			{
				num = (short)694419458;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_112;
					case 1:
						((global::System.IDisposable)csvReader).Dispose();
						num = (short)741867520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)137764701;
						short num3 = num;
						num = (short)607133533;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)285474816;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_DD;
							}
							continue;
						}
						break;
					}
					}
					IL_DD:
					if (csvReader == null)
					{
						break;
					}
					num = (short)623640577;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_112:;
			}
			num = (short)1097924608;
			short num4 = num;
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000E708 File Offset: 0x0000C908
		public void Populate(global::System.IO.Stream stream, bool hasHeaderRow, bool hasHeaderAlias)
		{
			short num = (short)1614155377;
			short num2 = num;
			num = (short)280956529;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1996029952;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2108817408;
			if (num != 0)
			{
			}
			num = (short)972685313;
			if (num != 0)
			{
			}
			this.Populate(stream, null, hasHeaderRow, hasHeaderAlias, false);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000E7BC File Offset: 0x0000C9BC
		public void Populate(global::System.IO.Stream stream, bool hasHeaderRow, bool hasHeaderAlias, bool trimColumns)
		{
			short num = (short)36675884;
			short num2 = num;
			num = (short)1482662188;
			switch (num2 == num)
			{
			default:
			{
				num = (short)131661824;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)860291073;
			if (num != 0)
			{
			}
			num = (short)257294336;
			if (num != 0)
			{
			}
			this.Populate(stream, null, hasHeaderRow, hasHeaderAlias, trimColumns);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000E870 File Offset: 0x0000CA70
		public void Populate(global::System.IO.Stream stream, global::System.Text.Encoding encoding, bool hasHeaderRow, bool hasHeaderAlias, bool trimColumns)
		{
			short num = (short)1901789185;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvReader csvReader = new global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvReader(stream, encoding)
			{
				HasHeaderRow = hasHeaderRow,
				HasHeaderAlias = hasHeaderAlias,
				TrimColumns = trimColumns
			};
			try
			{
				this.a(csvReader);
			}
			finally
			{
				num = (short)1823801346;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_104;
					case 1:
						((global::System.IDisposable)csvReader).Dispose();
						num = (short)895221760;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)722707334;
						short num3 = num;
						num = (short)1131979654;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)774963200;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_D1;
							}
							continue;
						}
						break;
					}
					}
					IL_D1:
					if (csvReader == null)
					{
						break;
					}
					num = (short)502857729;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_104:;
			}
			num = (short)307363840;
			short num4 = num;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000E9C0 File Offset: 0x0000CBC0
		public void Populate(bool hasHeaderRow, bool hasHeaderAlias, string csvContent)
		{
			short num = (short)779776867;
			short num2 = num;
			num = (short)1972925283;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1320157184;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2068119553;
			if (num != 0)
			{
			}
			num = (short)1382744064;
			if (num != 0)
			{
			}
			this.Populate(hasHeaderRow, hasHeaderAlias, csvContent, null, false);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000EA74 File Offset: 0x0000CC74
		public void Populate(bool hasHeaderRow, bool hasHeaderAlias, string csvContent, bool trimColumns)
		{
			short num = (short)475408540;
			short num2 = num;
			num = (short)1046292636;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1445986304;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1518600193;
			if (num != 0)
			{
			}
			num = (short)133693440;
			if (num != 0)
			{
			}
			this.Populate(hasHeaderRow, hasHeaderAlias, csvContent, null, trimColumns);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000EB28 File Offset: 0x0000CD28
		public void Populate(bool hasHeaderRow, bool hasHeaderAlias, string csvContent, global::System.Text.Encoding encoding, bool trimColumns)
		{
			global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvReader csvReader = new global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvReader(encoding, csvContent);
			short num;
			try
			{
				csvReader.HasHeaderRow = hasHeaderRow;
				csvReader.HasHeaderAlias = hasHeaderAlias;
				csvReader.TrimColumns = trimColumns;
				this.a(csvReader);
			}
			finally
			{
				num = (short)1886584834;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_DD;
					case 1:
						((global::System.IDisposable)csvReader).Dispose();
						num = (short)1577713664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)1855232128;
						short num3 = num;
						num = (short)1828755584;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1484390400;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_AA;
							}
							continue;
						}
						break;
					}
					}
					IL_AA:
					if (csvReader == null)
					{
						break;
					}
					num = (short)1381826561;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_DD:;
			}
			num = (short)1603010561;
			if (num != 0)
			{
			}
			num = (short)808321024;
			short num4 = num;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000EC78 File Offset: 0x0000CE78
		public void Populate(bool hasHeaderRow, global::System.Collections.Generic.List<string> headers, global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> rows)
		{
			short num = (short)833093633;
			if (num != 0)
			{
			}
			num = (short)478150665;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_B9;
				case 1:
					if (hasHeaderRow)
					{
						num = (short)1281097736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BE;
				case 2:
					num = (short)589889540;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_316;
				case 4:
					if (headers == null)
					{
						num = (short)818151427;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E2;
				case 5:
					if (hasHeaderRow)
					{
						num = (short)1590362114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E2;
				case 6:
					goto IL_DD;
				case 7:
					goto IL_BE;
				case 8:
					headers.ForEach(new global::System.Action<string>(this.d));
					num = (short)1469317127;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_74;
					}
					continue;
				}
				IL_74:
				num = (short)1968766976;
				short num3 = num;
				if (rows == null)
				{
					num = (short)1050738688;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)517013509;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_BE:
				global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>.Enumerator enumerator = rows.GetEnumerator();
				num = (short)1854865414;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_E2:
				this.Headers.Clear();
				this.Records.Clear();
				num = (short)1670184961;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B9:
			goto IL_2A5;
			IL_DD:
			try
			{
				num = (short)1755578372;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>.Enumerator enumerator;
						if (!enumerator.MoveNext())
						{
							num = (short)1684340739;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.List<string> list = enumerator.Current;
						global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvFile.a a = new global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvFile.a();
						a.a = new global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord();
						list.ForEach(new global::System.Action<string>(a.b));
						this.Records.Add(a.a);
						num = (short)958660610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_292;
					case 2:
					{
						num = (short)2116271946;
						short num4 = num;
						num = (short)2124398410;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_27B;
						default:
							num = (short)848822272;
							if (num != 0)
							{
							}
							break;
						}
						break;
					}
					case 3:
						goto IL_27B;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_19F;
						}
						continue;
					}
					IL_1A1:
					num = (short)1509556224;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_19F:
					goto IL_1A1;
					IL_27B:
					num = (short)1653669889;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_292:
				return;
			}
			finally
			{
				global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>.Enumerator enumerator;
				((global::System.IDisposable)enumerator).Dispose();
			}
			IL_2A5:
			throw new global::System.ArgumentException();
			IL_316:
			throw new global::System.ArgumentException();
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000EFBC File Offset: 0x0000D1BC
		private void a(global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvReader A_0)
		{
			int a_ = 11;
			short num = (short)803209216;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B3;
				}
				bool flag;
				bool flag2;
				bool flag3;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						if (A_0.Fields != null)
						{
							num = (short)574685190;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_540;
					case 1:
						goto IL_59E;
					case 2:
						num = (short)1041104906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (!b.a.Fields[0].StartsWith(global::CommonUtility.VersionUtility.b("ጻᄽ", a_), global::System.StringComparison.Ordinal))
						{
							num = (short)52428807;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_40F;
					case 4:
						if (A_0.Fields != null)
						{
							num = (short)772800526;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F9;
					case 5:
					{
						num = (short)1292828672;
						short num3 = num;
						b.a = new global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord();
						A_0.Fields.ForEach(new global::System.Action<string>(b.b));
						num = (short)823132163;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						A_0.Fields.ForEach(new global::System.Action<string>(this.b));
						num = (short)1201733645;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						this.Records.Add(b.a);
						num = (short)1226981385;
						short num4 = num;
						num = (short)1018183689;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_59E;
						default:
							num = (short)391839744;
							if (num != 0)
							{
							}
							num = (short)1019543569;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
						if (A_0.HasHeaderRangeRow)
						{
							num = (short)772145163;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_560;
					case 9:
						if (A_0.HasHeaderAlias)
						{
							num = (short)1990459394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_352;
					case 10:
						if (!flag)
						{
							num = (short)1257701405;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_352;
					case 11:
						num = (short)811008001;
						if (num != 0)
						{
						}
						num = (short)931856408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (A_0.Fields != null)
						{
							num = (short)1506869249;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_40F;
					case 13:
						goto IL_540;
					case 14:
						A_0.Fields.ForEach(new global::System.Action<string>(this.a));
						num = (short)1499332635;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						return;
					case 16:
						if (A_0.HasHeaderRow)
						{
							num = (short)282656793;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17D;
					case 17:
						goto IL_40F;
					case 18:
						goto IL_40F;
					case 19:
						num = (short)2123366404;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (A_0.Fields.Count != 0)
						{
							num = (short)1833107461;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_40F;
					case 21:
						if (!flag2)
						{
							num = (short)625475606;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17D;
					case 22:
						A_0.Fields.ForEach(new global::System.Action<string>(this.c));
						flag2 = true;
						num = (short)609288218;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (!A_0.ReadNextRecord())
						{
							num = (short)981336079;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1756364816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (!flag3)
						{
							num = (short)1961951251;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_560;
					case 25:
						num = (short)61931541;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						goto IL_40F;
					case 27:
						goto IL_F9;
					case 28:
						goto IL_40F;
					case 29:
						num = (short)1881473024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						goto IL_40F;
					}
					goto IL_B3;
					IL_F9:
					flag3 = true;
					num = (short)1080229906;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_17D:
					num = (short)24772617;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_352:
					num = (short)1200160776;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_40F:
					num = (short)1308229655;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_540:
					flag = true;
					num = (short)324075548;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_560:
					num = (short)1263337484;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_59E:
					num = (short)1106575380;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_B3:
				this.Headers.Clear();
				this.HeaderAlias.Clear();
				this.Records.Clear();
				flag2 = false;
				flag = false;
				flag3 = false;
				num = (short)2138177566;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000F5B0 File Offset: 0x0000D7B0
		public void ExportToCSV(string fileName, global::System.Collections.Generic.List<string> headerList, global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>> dataRecords, global::System.Collections.Generic.List<string> headerListAlias = null, global::System.Collections.Generic.List<string> headerValidationList = null)
		{
			short num = (short)73269249;
			if (num != 0)
			{
			}
			num = (short)1696727040;
			short num2 = num;
			num = (short)335806464;
			switch (num)
			{
			default:
			{
				global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvWriter csvWriter = new global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvWriter();
				try
				{
					num = (short)966459404;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							if (headerValidationList != null)
							{
								num = (short)1459814401;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2F3;
						case 1:
						{
							this.HeaderValidation.AddRange(headerValidationList);
							num = (short)2007942513;
							short num4 = num;
							num = (short)909559153;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_217;
							default:
								num = (short)78446592;
								if (num != 0)
								{
								}
								num = (short)184877067;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							try
							{
								num = (short)1004929028;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 1:
										goto IL_1F8;
									case 2:
										num = (short)1949302785;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
									{
										global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>.Enumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)1330249730;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Collections.Generic.List<string> collection = enumerator.Current;
										global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord csvRecord = new global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord();
										csvRecord.Fields.AddRange(collection);
										this.Records.Add(csvRecord);
										num = (short)352583680;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										switch (0)
										{
										case 0:
											goto IL_162;
										}
										continue;
									}
									IL_1A3:
									num = (short)851968003;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_162:
									goto IL_1A3;
								}
								IL_1F8:
								goto IL_366;
							}
							finally
							{
								global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>.Enumerator enumerator;
								((global::System.IDisposable)enumerator).Dispose();
							}
							goto IL_20B;
						case 3:
							goto IL_20B;
						case 4:
							if (headerListAlias != null)
							{
								num = (short)43974665;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_32C;
						case 5:
							goto IL_EF;
						case 6:
							goto IL_387;
						case 7:
							if (dataRecords != null)
							{
								num = (short)937492490;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_366;
						case 8:
							goto IL_32C;
						case 9:
							this.HeaderAlias.AddRange(headerListAlias);
							num = (short)1741553672;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
						{
							global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>.Enumerator enumerator = dataRecords.GetEnumerator();
							num = (short)54853634;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
							goto IL_2F3;
						case 12:
							switch (0)
							{
							case 0:
								goto IL_D1;
							}
							continue;
						}
						IL_D1:
						if (headerList != null)
						{
							num = (short)1839267843;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_EF:
						num = (short)346095620;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_217:
						num = (short)957939717;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_20B:
						this.Headers.AddRange(headerList);
						goto IL_217;
						IL_2F3:
						num = (short)919339015;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_32C:
						num = (short)127533056;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_366:
						csvWriter.WriteCsv(this, fileName);
						num = (short)735510534;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_387:;
				}
				finally
				{
					num = (short)286326786;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_3F4;
						case 1:
							((global::System.IDisposable)csvWriter).Dispose();
							num = (short)1206517760;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_3BC;
							}
							continue;
						}
						IL_3BC:
						if (csvWriter == null)
						{
							break;
						}
						num = (short)1793785857;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_3F4:;
				}
				return;
			}
			}
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000F9E8 File Offset: 0x0000DBE8
		public void ExportToCSV(string fileName, string[] headerList, string[] headerListAlias, string[] headerValidationList, object[,] dataRecords)
		{
			short num = (short)1411514368;
			short num2 = num;
			num = (short)1419025122;
			short num3 = num;
			num = (short)522033890;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)914096128;
				if (num != 0)
				{
				}
				num = (short)1211367425;
				if (num != 0)
				{
				}
				num = (short)544145408;
				int num4 = (int)num;
				switch (num4)
				{
				}
				break;
			}
			}
			global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvWriter csvWriter = new global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvWriter();
			try
			{
				switch (0)
				{
				case 0:
					goto IL_128;
				}
				int num4;
				for (;;)
				{
					IL_CD:
					switch (num4)
					{
					case 0:
						goto IL_385;
					case 1:
						goto IL_191;
					case 2:
						goto IL_385;
					case 3:
					{
						global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord csvRecord;
						int num5;
						int num6;
						csvRecord.Fields.Add((dataRecords[num5, num6] != null) ? dataRecords[num5, num6].ToString() : "");
						num6++;
						num = (short)2129592320;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						this.Headers.AddRange(headerList);
						num = (short)888930305;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_284;
					case 6:
						if (headerList != null)
						{
							num = (short)1201340420;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_191;
					case 7:
						this.HeaderValidation.AddRange(headerValidationList);
						num = (short)1545732104;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_243;
					case 9:
						if (dataRecords != null)
						{
							num = (short)1303838730;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F2;
					case 10:
					{
						int num5 = 0;
						num = (short)1488846866;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_3F2;
					case 12:
						if (headerListAlias != null)
						{
							num = (short)367001613;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_284;
					case 13:
						this.HeaderAlias.AddRange(headerListAlias);
						num = (short)1973813253;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_344;
					case 15:
					{
						int num5;
						if (num5 >= dataRecords.GetLength(0))
						{
							num = (short)631046155;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord csvRecord = new global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord();
						int num6 = 0;
						num = (short)1644625922;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						int num6;
						if (num6 >= dataRecords.GetLength(1))
						{
							num = (short)128712724;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)925564931;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						if (headerValidationList != null)
						{
							num = (short)1981546503;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_243;
					case 18:
						goto IL_344;
					case 19:
						goto IL_414;
					case 20:
					{
						global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord csvRecord;
						this.Records.Add(csvRecord);
						int num5;
						num5++;
						num = (short)1252327438;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_128;
					IL_191:
					num = (short)2130706444;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_243:
					num = (short)731578377;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_284:
					num = (short)1680932881;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_344:
					num = (short)1776418831;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_385:
					num = (short)2142961680;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_3F2:
					csvWriter.WriteCsv(this, fileName);
					num = (short)848298003;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_414:
				return;
				IL_128:
				csvWriter.ReplaceCarriageReturnsAndLineFeedsFromFieldValues = false;
				csvWriter.WriteSeparator = false;
				num = (short)2038759430;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_CD;
			}
			finally
			{
				num = (short)587464704;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_448;
						}
						continue;
					case 1:
						((global::System.IDisposable)csvWriter).Dispose();
						num = (short)1130823682;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_47F;
					}
					IL_448:
					if (csvWriter == null)
					{
						break;
					}
					num = (short)580124673;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_47F:;
			}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000FED4 File Offset: 0x0000E0D4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void d(string A_0)
		{
			short num = (short)803864576;
			short num2 = num;
			num = (short)390982177;
			short num3 = num;
			num = (short)854649377;
			switch (num3 == num)
			{
			}
			num = (short)1788018689;
			if (num != 0)
			{
			}
			num = (short)1440743424;
			if (num != 0)
			{
			}
			this.Headers.Add(A_0);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000FF88 File Offset: 0x0000E188
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void c(string A_0)
		{
			short num = (short)658964480;
			short num2 = num;
			num = (short)131511821;
			short num3 = num;
			num = (short)1661580813;
			switch (num3 == num)
			{
			}
			num = (short)431620097;
			if (num != 0)
			{
			}
			num = (short)1131282432;
			if (num != 0)
			{
			}
			this.Headers.Add(A_0.Trim());
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00010044 File Offset: 0x0000E244
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void b(string A_0)
		{
			short num = (short)1694498816;
			short num2 = num;
			num = (short)1805458324;
			short num3 = num;
			num = (short)770907028;
			switch (num3 == num)
			{
			}
			num = (short)1498152960;
			if (num != 0)
			{
			}
			num = (short)594411521;
			if (num != 0)
			{
			}
			this.HeaderAlias.Add(A_0.Trim());
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00010104 File Offset: 0x0000E304
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void a(string A_0)
		{
			short num = (short)417071104;
			short num2 = num;
			num = (short)57081857;
			if (num != 0)
			{
			}
			num = (short)300971105;
			short num3 = num;
			num = (short)418935905;
			switch (num3 == num)
			{
			}
			num = (short)1903820800;
			if (num != 0)
			{
			}
			this.HeaderValidation.Add(A_0.Trim());
		}

		// Token: 0x04000028 RID: 40
		public const string CSVSeparatorDescription = "sep=,";

		// Token: 0x04000029 RID: 41
		public const string CSVSeparator = ",";

		// Token: 0x0400002A RID: 42
		public const char QuoteChar = '"';

		// Token: 0x0400002C RID: 44
		public readonly global::System.Collections.Generic.List<string> Headers = new global::System.Collections.Generic.List<string>();

		// Token: 0x0400002D RID: 45
		public readonly global::System.Collections.Generic.List<string> HeaderAlias = new global::System.Collections.Generic.List<string>();

		// Token: 0x0400002E RID: 46
		public readonly global::System.Collections.Generic.List<string> HeaderValidation = new global::System.Collections.Generic.List<string>();

		// Token: 0x0400002F RID: 47
		public readonly global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecords Records = new global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecords();

		// Token: 0x0200001A RID: 26
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06000097 RID: 151 RVA: 0x000101D0 File Offset: 0x0000E3D0
			internal void b(string A_0)
			{
				short num = (short)1218314240;
				short num2 = num;
				num = (short)1089195717;
				short num3 = num;
				num = (short)1576128197;
				switch (num3 == num)
				{
				}
				num = (short)2147155968;
				if (num != 0)
				{
				}
				num = (short)1362427905;
				if (num != 0)
				{
				}
				this.a.Fields.Add(A_0);
			}

			// Token: 0x04000030 RID: 48
			public global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord a;
		}

		// Token: 0x0200001B RID: 27
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class b
		{
			// Token: 0x06000099 RID: 153 RVA: 0x000102A0 File Offset: 0x0000E4A0
			internal void b(string A_0)
			{
				short num = (short)448135168;
				short num2 = num;
				num = (short)2079778812;
				short num3 = num;
				num = (short)730064892;
				switch (num3 == num)
				{
				}
				num = (short)1997012993;
				if (num != 0)
				{
				}
				num = (short)1582039040;
				if (num != 0)
				{
				}
				this.a.Fields.Add(A_0);
			}

			// Token: 0x04000031 RID: 49
			public global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord a;
		}
	}
}
