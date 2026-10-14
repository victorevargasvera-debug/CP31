using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using CommonUtility;
using Motorola.Common.CustomException;

namespace Motorola.CommonCPS.Common.CommonUtility.CSV
{
	// Token: 0x0200001E RID: 30
	public sealed class CsvReader : global::System.IDisposable
	{
		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00010444 File Offset: 0x0000E644
		// (set) Token: 0x0600009E RID: 158 RVA: 0x000104F4 File Offset: 0x0000E6F4
		public bool TrimColumns
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1643249664;
				short num2 = num;
				num = (short)1528788307;
				short num3 = num;
				num = (short)1163818323;
				switch (num3 == num)
				{
				}
				num = (short)1521942529;
				if (num != 0)
				{
				}
				num = (short)2117337088;
				if (num != 0)
				{
				}
				return this.i;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)991297536;
				short num2 = num;
				num = (short)1982838544;
				short num3 = num;
				num = (short)1364768528;
				switch (num3 == num)
				{
				}
				num = (short)585367553;
				if (num != 0)
				{
				}
				num = (short)951386112;
				if (num != 0)
				{
				}
				this.i = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600009F RID: 159 RVA: 0x000105A4 File Offset: 0x0000E7A4
		// (set) Token: 0x060000A0 RID: 160 RVA: 0x00010654 File Offset: 0x0000E854
		public bool HasHeaderRow
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2009399296;
				short num2 = num;
				num = (short)1696910202;
				short num3 = num;
				num = (short)24169338;
				switch (num3 == num)
				{
				}
				num = (short)846462976;
				if (num != 0)
				{
				}
				num = (short)685113345;
				if (num != 0)
				{
				}
				return this.j;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)757858304;
				short num2 = num;
				num = (short)1880486141;
				short num3 = num;
				num = (short)1622667517;
				switch (num3 == num)
				{
				}
				num = (short)1111031808;
				if (num != 0)
				{
				}
				num = (short)994836481;
				if (num != 0)
				{
				}
				this.j = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00010708 File Offset: 0x0000E908
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x000107B8 File Offset: 0x0000E9B8
		public bool HasHeaderAlias
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)873660416;
				short num2 = num;
				num = (short)1830175607;
				short num3 = num;
				num = (short)1653752695;
				switch (num3 == num)
				{
				}
				num = (short)1171324929;
				if (num != 0)
				{
				}
				num = (short)726335488;
				if (num != 0)
				{
				}
				return this.k;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1361641472;
				short num2 = num;
				num = (short)931432598;
				short num3 = num;
				num = (short)790661270;
				switch (num3 == num)
				{
				}
				num = (short)1657929729;
				if (num != 0)
				{
				}
				num = (short)1351417856;
				if (num != 0)
				{
				}
				this.k = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00010868 File Offset: 0x0000EA68
		// (set) Token: 0x060000A4 RID: 164 RVA: 0x00010918 File Offset: 0x0000EB18
		public bool HasHeaderRangeRow
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)516358144;
				short num2 = num;
				num = (short)1937933253;
				short num3 = num;
				num = (short)55411653;
				switch (num3 == num)
				{
				}
				num = (short)1762918400;
				if (num != 0)
				{
				}
				num = (short)1782644737;
				if (num != 0)
				{
				}
				return this.l;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2096693248;
				short num2 = num;
				num = (short)1126565402;
				short num3 = num;
				num = (short)1939211802;
				switch (num3 == num)
				{
				}
				num = (short)365297665;
				if (num != 0)
				{
				}
				num = (short)1512833024;
				if (num != 0)
				{
				}
				this.l = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x000109C8 File Offset: 0x0000EBC8
		// (set) Token: 0x060000A6 RID: 166 RVA: 0x00010A78 File Offset: 0x0000EC78
		public global::System.Collections.Generic.List<string> Fields
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1889730560;
				short num2 = num;
				num = (short)1941233429;
				short num3 = num;
				num = (short)290512661;
				switch (num3 == num)
				{
				}
				num = (short)362741761;
				if (num != 0)
				{
				}
				num = (short)1054605312;
				if (num != 0)
				{
				}
				return this.m;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1099825152;
				short num2 = num;
				num = (short)1032167275;
				short num3 = num;
				num = (short)469016427;
				switch (num3 == num)
				{
				}
				num = (short)274071552;
				if (num != 0)
				{
				}
				num = (short)1804009473;
				if (num != 0)
				{
				}
				this.m = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x00010B28 File Offset: 0x0000ED28
		public int? FieldCount
		{
			get
			{
				short num;
				for (;;)
				{
					num = (short)2087256064;
					short num2 = num;
					if (this.Fields != null)
					{
						goto IL_B2;
					}
					num = (short)531516207;
					short num3 = num;
					num = (short)781273903;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_69;
					}
				}
				IL_69:
				num = (short)525336577;
				if (num != 0)
				{
				}
				num = (short)57671680;
				if (num != 0)
				{
				}
				return null;
				IL_B2:
				return new int?(this.Fields.Count);
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00010BF8 File Offset: 0x0000EDF8
		public CsvReader(string filePath)
		{
			this.h = global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvReader.a.a;
			this.a(filePath, global::System.Text.Encoding.Default);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00010C2C File Offset: 0x0000EE2C
		public CsvReader(string filePath, global::System.Text.Encoding encoding)
		{
			this.h = global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvReader.a.a;
			this.a(filePath, encoding);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00010C5C File Offset: 0x0000EE5C
		public CsvReader(global::System.IO.Stream stream)
		{
			this.h = global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvReader.a.b;
			this.a(stream, global::System.Text.Encoding.Default);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00010C90 File Offset: 0x0000EE90
		public CsvReader(global::System.IO.Stream stream, global::System.Text.Encoding encoding)
		{
			this.h = global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvReader.a.b;
			this.a(stream, encoding);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00010CC0 File Offset: 0x0000EEC0
		public CsvReader(global::System.Text.Encoding encoding, string csvContent)
		{
			this.h = global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvReader.a.c;
			this.a(encoding, csvContent);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00010CF0 File Offset: 0x0000EEF0
		private void a(string A_0, global::System.Text.Encoding A_1)
		{
			int a_ = 16;
			short num;
			for (;;)
			{
				num = (short)2066808832;
				short num2 = num;
				if (global::System.IO.File.Exists(A_0))
				{
					goto IL_D0;
				}
				num = (short)1790219006;
				short num3 = num;
				num = (short)341480190;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_72;
				}
			}
			IL_72:
			num = (short)1703936001;
			if (num != 0)
			{
			}
			num = (short)622329856;
			if (num != 0)
			{
			}
			throw new global::System.IO.FileNotFoundException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::CommonUtility.VersionUtility.b("ᕀ⭂⁄杆⽈≊⅌⩎煐瑒⹔杖⑘籚絜㭞๠٢ᙤ䝦ݨѪᥬ佮ᑰ୲ᱴѶ൸啺", a_), A_0));
			IL_D0:
			this.a = global::System.IO.File.Open(A_0, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.ReadWrite);
			this.a(this.a, A_1);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00010DEC File Offset: 0x0000EFEC
		private void a(global::System.IO.Stream A_0, global::System.Text.Encoding A_1)
		{
			int a_ = 11;
			short num = (short)742785024;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)12713984;
				short num3 = num;
				num = (short)753270785;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					num = (short)982862782;
					short num4 = num;
					num = (short)915360702;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num = (short)43909120;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_D6;
						}
						continue;
					}
					break;
				}
				case 1:
					goto IL_EE;
				case 2:
					goto IL_12F;
				}
				IL_D6:
				if (A_0 == null)
				{
					num = (short)621871105;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					this.b = A_0;
					this.b.Position = 0L;
					num = (short)1691025410;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_EE:
			throw new global::System.ArgumentNullException(global::CommonUtility.VersionUtility.b("栻嘽┿扁㝃㍅㡇㩉⁋❍㕏㙑瑓╕ⱗ⡙㥛㽝ൟ䉡ൣᕥ䡧ѩᥫɭᱯ山", a_));
			IL_12F:
			this.f = (A_1 ?? global::System.Text.Encoding.Default);
			this.c = new global::System.IO.StreamReader(this.b, this.f);
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00010F54 File Offset: 0x0000F154
		private void a(global::System.Text.Encoding A_0, string A_1)
		{
			int a_ = 8;
			for (;;)
			{
				IL_09:
				short num = (short)905510912;
				short num2 = num;
				num = (short)672464896;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
					{
						num = (short)1854700515;
						short num4 = num;
						num = (short)907705315;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
							num = (short)88670209;
							if (num != 0)
							{
							}
							num = (short)855638016;
							if (num != 0)
							{
							}
							switch (0)
							{
							case 0:
								goto IL_D4;
							}
							continue;
						}
						break;
					}
					case 1:
						goto IL_EB;
					case 2:
						goto IL_116;
					}
					IL_D4:
					if (A_1 == null)
					{
						num = (short)1483538433;
						num3 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)114098178;
						num3 = (int)((global::System.IntPtr)num);
					}
				}
			}
			IL_EB:
			throw new global::System.ArgumentNullException(global::CommonUtility.VersionUtility.b("洸区堼Ἶ㉀㙂㕄㝆╈≊⡌⭎煐げ♔⅖ᩘ㑚㍜⭞Ѡൢᅤ䝦hᡪ䵬ŮѰὲᥴ奶", a_));
			IL_116:
			this.f = (A_0 ?? global::System.Text.Encoding.Default);
			this.e = new global::System.IO.MemoryStream(A_1.Length);
			this.d = new global::System.IO.StreamWriter(this.e);
			this.d.Write(A_1);
			this.d.Flush();
			this.a(this.e, A_0);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000110D4 File Offset: 0x0000F2D4
		public bool ReadNextRecord()
		{
			int a_ = 2;
			switch (0)
			{
			case 0:
				goto IL_35;
			}
			int num;
			string text;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (text == null)
					{
						num2 = (short)555941892;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1975713797;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)959861747;
					short num3 = num2;
					num2 = (short)1009341427;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)2089091072;
						if (num2 != 0)
						{
						}
						text = this.a();
						num2 = (short)1564409858;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					goto IL_153;
				case 3:
					if (text.Equals(global::CommonUtility.VersionUtility.b("䀲倴䜶и᜺", a_), global::System.StringComparison.Ordinal))
					{
						num2 = (short)1566179328;
						short num4 = num2;
						num2 = (short)736559105;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1BC;
				case 4:
					return false;
				case 5:
					num2 = (short)1002045441;
					if (num2 != 0)
					{
					}
					if (string.IsNullOrWhiteSpace(text))
					{
						num2 = (short)476774406;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)368705539;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					return true;
				}
				goto IL_35;
			}
			return false;
			IL_153:
			IL_1BC:
			this.a(text);
			return true;
			IL_35:
			this.Fields = null;
			text = this.a();
			num2 = (short)1468334080;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000112A8 File Offset: 0x0000F4A8
		private string a()
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			string text;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (text != null)
					{
						num2 = (short)1270349827;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return text;
				case 1:
					goto IL_D0;
				case 2:
					goto IL_D0;
				case 3:
					num2 = (short)611713025;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (text.Count(new global::System.Func<char, bool>(global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvReader.<>c.<>9.a)) % 2 == 0)
					{
						num2 = (short)1037107205;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					text += this.c.ReadLine();
					goto IL_B5;
				case 5:
					return text;
				}
				goto IL_28;
				IL_B5:
				num2 = (short)1717764098;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_D0:
				num2 = (short)434438144;
				short num3 = num2;
				num2 = (short)1717309767;
				short num4 = num2;
				num2 = (short)2059407687;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_B5;
				default:
					num2 = (short)330170368;
					if (num2 != 0)
					{
					}
					num2 = (short)709165060;
					num = (int)((global::System.IntPtr)num2);
					break;
				}
			}
			return text;
			IL_28:
			num2 = (short)1217658881;
			if (num2 != 0)
			{
			}
			text = this.c.ReadLine();
			num2 = (short)1777074176;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00011460 File Offset: 0x0000F660
		public global::System.Data.DataTable ReadIntoDataTable()
		{
			short num = (short)1278148608;
			short num2 = num;
			num = (short)597078484;
			short num3 = num;
			num = (short)162247124;
			switch (num3 == num)
			{
			}
			num = (short)35323905;
			if (num != 0)
			{
			}
			num = (short)2139619328;
			if (num != 0)
			{
			}
			return this.ReadIntoDataTable(new global::System.Type[0]);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00011514 File Offset: 0x0000F714
		public global::System.Data.DataTable ReadIntoDataTable(global::System.Type[] columnTypes)
		{
			short num = (short)2120351744;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Data.DataTable dataTable = new global::System.Data.DataTable();
				global::System.Data.DataTable result;
				try
				{
					dataTable.Locale = global::System.Globalization.CultureInfo.InvariantCulture;
					try
					{
						switch (0)
						{
						case 0:
							goto IL_88;
						}
						bool flag;
						for (;;)
						{
							IL_3D:
							switch (num2)
							{
							case 0:
								goto IL_EC;
							case 1:
								num = (short)1537343489;
								if (num != 0)
								{
								}
								result = dataTable;
								num = (short)624427017;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_179;
							case 3:
								goto IL_179;
							case 4:
							{
								int num3;
								dataTable.Columns.Add(this.Fields[num3].Trim(), (columnTypes.Length != 0) ? columnTypes[num3] : typeof(string));
								num3++;
								num = (short)272564229;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								goto IL_1BA;
							case 6:
								goto IL_1BA;
							case 7:
								if (!this.ReadNextRecord())
								{
									num = (short)2097283073;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1362296843;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
							{
								int num4;
								if (num4 >= this.Fields.Count)
								{
									num = (short)1028194320;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Data.DataRow dataRow;
								dataRow[num4] = this.Fields[num4];
								num4++;
								num = (short)2086797324;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 9:
								goto IL_33D;
							case 10:
								goto IL_179;
							case 11:
							{
								if (!flag)
								{
									num = (short)1293615117;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Data.DataRow dataRow = dataTable.NewRow();
								int num4 = 0;
								num = (short)107347968;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 12:
								goto IL_EC;
							case 13:
							{
								int num3 = 0;
								num = (short)1925775366;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 14:
							{
								int num3;
								if (num3 >= this.Fields.Count)
								{
									num = (short)2059337743;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)435486724;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 15:
								flag = true;
								num = (short)1810694147;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 16:
							{
								global::System.Data.DataRow dataRow;
								dataTable.Rows.Add(dataRow);
								num = (short)1700462594;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							goto IL_88;
							IL_EC:
							num = (short)460193800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_179:
							num = (short)1499594759;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1BA:
							num = (short)892862478;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_33D:
						goto IL_401;
						IL_88:
						flag = false;
						this.b.Position = 0L;
						num = (short)462159882;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_3D;
					}
					catch (global::System.Exception)
					{
						dataTable.Dispose();
						throw;
					}
				}
				finally
				{
					num = (short)724434946;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_3B6;
						case 1:
							((global::System.IDisposable)dataTable).Dispose();
							num = (short)880738304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_37D;
							}
							continue;
						}
						IL_37D:
						if (dataTable != null)
						{
							num = (short)1927348225;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_3B6:
						num = (short)426171897;
						short num5 = num;
						num = (short)524344825;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_37D;
						default:
							goto IL_3EB;
						}
					}
					IL_3EB:
					num = (short)255393792;
					if (num != 0)
					{
					}
				}
				IL_401:
				num = (short)1456603136;
				short num6 = num;
				return result;
			}
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00011984 File Offset: 0x0000FB84
		private void a(string A_0)
		{
			int a_ = 18;
			short num = (short)1192558592;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_DF;
				}
				bool flag;
				bool flag2;
				int num3;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
					{
						char c;
						if (c == '"')
						{
							num = (short)19398695;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5D6;
					}
					case 1:
						flag = false;
						flag2 = false;
						num3++;
						num = (short)218562577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)1293221929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						char c;
						if (c == global::CommonUtility.VersionUtility.b("潂", a_)[0])
						{
							num = (short)1750335511;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C2;
					}
					case 4:
						num = (short)54722573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_573;
					case 6:
						if (A_0.Length > num3 + 1)
						{
							num = (short)2016870433;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12D;
					case 7:
					{
						num = (short)1135324411;
						short num4 = num;
						num = (short)854306043;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_175;
						default:
							num = (short)687341568;
							if (num != 0)
							{
							}
							flag = true;
							flag2 = true;
							num = (short)1419313153;
							if (num != 0)
							{
							}
							num = (short)1473052677;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
					{
						char c;
						this.g.Append(c);
						flag2 = true;
						num = (short)485883926;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						num = (short)1803288596;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						this.Fields.Add(this.TrimColumns ? this.g.ToString().Trim() : this.g.ToString());
						num = (short)144834586;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_5D6;
					case 12:
					{
						char c;
						if (c == '"')
						{
							num = (short)1442906146;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5D6;
					}
					case 13:
					{
						char c;
						if (c == '"')
						{
							num = (short)569114631;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_175;
					}
					case 14:
						if (!flag2)
						{
							num = (short)904855556;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_138;
					case 15:
						num = (short)1784479744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_573;
					case 17:
						goto IL_5D6;
					case 18:
						goto IL_1C2;
					case 19:
						goto IL_655;
					case 20:
						if (flag)
						{
							num = (short)969932832;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2002059267;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
					{
						char c;
						if (c != global::CommonUtility.VersionUtility.b("潂", a_)[0])
						{
							num = (short)2078212104;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_138;
					}
					case 22:
						goto IL_573;
					case 23:
						flag2 = false;
						num = (short)432275474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						num = (short)1327628298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						if (flag2)
						{
							num = (short)53411849;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5D6;
					case 26:
						goto IL_3BD;
					case 27:
						if (flag2)
						{
							num = (short)1651507215;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5D6;
					case 28:
					{
						num = (short)593559552;
						short num5 = num;
						num3++;
						num = (short)684589067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
					{
						if (!flag2)
						{
							num = (short)1844314114;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						char c;
						this.g.Append(c);
						num = (short)1827667984;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
					{
						if (num3 >= A_0.Length)
						{
							num = (short)1434255396;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						char c = A_0[num3];
						num = (short)318308366;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
						if (flag2)
						{
							num = (short)209780760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 32:
						num = (short)1594294309;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						num = (short)1883111462;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						num = (short)48103430;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						goto IL_655;
					case 36:
						num = (short)60227615;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						if (this.IsEndQuote(A_0, num3))
						{
							num = (short)654901249;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)27656204;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						if (A_0[num3 + 1] == '"')
						{
							num = (short)902889500;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12D;
					case 39:
						goto IL_4CF;
					case 40:
						goto IL_573;
					case 41:
						this.Fields.Add(this.TrimColumns ? this.g.ToString().Trim() : this.g.ToString());
						this.g.Remove(0, this.g.Length);
						num = (short)1126629416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_DF;
					IL_138:
					num = (short)701956121;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_175:
					num = (short)1180368917;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C2:
					num = (short)1585971227;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_573:
					num3++;
					num = (short)1674903571;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5D6:
					num = (short)1942880285;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_655:
					num = (short)432799774;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_12D:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_ImportCSV_WrongQuote);
				IL_3BD:
				return;
				IL_4CF:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.RMC_ImportCSV_WrongQuote);
				IL_DF:
				this.Fields = new global::System.Collections.Generic.List<string>();
				global::CommonUtility.VersionUtility.b("潂", a_).ToCharArray();
				flag2 = false;
				flag = false;
				this.g.Clear();
				num3 = 0;
				num = (short)1285554211;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00012140 File Offset: 0x00010340
		public bool IsEndQuote(string line, int i)
		{
			int a_ = 1;
			short num = (short)1070399491;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1317863424;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_D1;
				case 1:
					return true;
				case 2:
					goto IL_CC;
				case 3:
					goto IL_1D;
				case 4:
				{
					num = (short)612347094;
					short num4 = num;
					num = (short)1657777366;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1D;
					default:
						num = (short)461373440;
						if (num != 0)
						{
						}
						num = (short)1920532487;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					if (line[i + 1] != global::CommonUtility.VersionUtility.b("ḱ", a_)[0])
					{
						num = (short)1188233216;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 6:
					if (line[i] == '"')
					{
						num = (short)1112735748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 7:
					if (line.Length > i + 1)
					{
						num = (short)287703048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D1;
				case 8:
					num = (short)1965555717;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (i + 1 == line.Length)
					{
						num = (short)1893203969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				goto IL_7E;
				IL_1D:
				switch (0)
				{
				case 0:
					IL_7E:
					if (i > line.Length - 1)
					{
						num = (short)924844033;
						if (num != 0)
						{
						}
						num = (short)1260388354;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1584332806;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				continue;
				IL_D1:
				num = (short)2028863497;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_CC:
			throw new global::System.ArgumentOutOfRangeException();
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00012388 File Offset: 0x00010588
		public void Dispose()
		{
			short num = (short)198508556;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)824311813;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_96;
				case 2:
					goto IL_178;
				case 3:
					num = (short)1139212289;
					if (num != 0)
					{
					}
					if (this.d != null)
					{
						num = (short)1499136006;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_338;
				case 4:
					this.c.Close();
					this.c.Dispose();
					num = (short)576520209;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (this.h == global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvReader.a.a)
					{
						num = (short)2075590658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_377;
				case 6:
				{
					num = (short)345431938;
					short num3 = num;
					num = (short)531226498;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_BA;
					default:
						num = (short)1232404480;
						if (num != 0)
						{
						}
						this.d.Close();
						this.d.Dispose();
						num = (short)432668687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					if (this.e != null)
					{
						num = (short)1588527115;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D6;
				case 8:
					this.a.Close();
					this.a.Dispose();
					num = (short)665911297;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (this.b != null)
					{
						num = (short)26345488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_377;
				case 10:
					if (this.h != global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvReader.a.c)
					{
						goto IL_BA;
					}
					goto IL_178;
				case 11:
					this.e.Close();
					this.e.Dispose();
					num = (short)2009661453;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					switch (0)
					{
					case 0:
						goto IL_71;
					}
					continue;
				case 13:
					goto IL_D6;
				case 14:
					goto IL_252;
				case 15:
					goto IL_338;
				case 16:
					this.b.Close();
					this.b.Dispose();
					num = (short)728825870;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_111;
				case 18:
					if (this.a != null)
					{
						num = (short)1007812616;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_96;
				}
				IL_71:
				if (this.c != null)
				{
					num = (short)1611268100;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_111;
				IL_96:
				num = (short)1844576266;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_BA:
				num = (short)146341888;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D6:
				num = (short)1791885330;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_111:
				num = (short)881197059;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_178:
				num = (short)1686241289;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_338:
				num = (short)1151533063;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_252:
			IL_377:
			num = (short)1279655936;
			short num4 = num;
		}

		// Token: 0x04000033 RID: 51
		private global::System.IO.FileStream a;

		// Token: 0x04000034 RID: 52
		private global::System.IO.Stream b;

		// Token: 0x04000035 RID: 53
		private global::System.IO.StreamReader c;

		// Token: 0x04000036 RID: 54
		private global::System.IO.StreamWriter d;

		// Token: 0x04000037 RID: 55
		private global::System.IO.Stream e;

		// Token: 0x04000038 RID: 56
		private global::System.Text.Encoding f;

		// Token: 0x04000039 RID: 57
		private readonly global::System.Text.StringBuilder g = new global::System.Text.StringBuilder(100);

		// Token: 0x0400003A RID: 58
		private readonly global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvReader.a h;

		// Token: 0x0400003B RID: 59
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool i;

		// Token: 0x0400003C RID: 60
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool j;

		// Token: 0x0400003D RID: 61
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool k;

		// Token: 0x0400003E RID: 62
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool l;

		// Token: 0x0400003F RID: 63
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<string> m;

		// Token: 0x0200001F RID: 31
		private enum a
		{
			// Token: 0x04000041 RID: 65
			a,
			// Token: 0x04000042 RID: 66
			b,
			// Token: 0x04000043 RID: 67
			c
		}
	}
}
