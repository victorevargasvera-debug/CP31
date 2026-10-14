using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using CommonUtility;

namespace Motorola.CommonCPS.Common.CommonUtility.CSV
{
	// Token: 0x02000021 RID: 33
	public sealed class CsvWriter : global::System.IDisposable
	{
		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000BA RID: 186 RVA: 0x000128AC File Offset: 0x00010AAC
		// (set) Token: 0x060000BB RID: 187 RVA: 0x0001295C File Offset: 0x00010B5C
		public bool ReplaceCarriageReturnsAndLineFeedsFromFieldValues
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1006174208;
				short num2 = num;
				num = (short)550013962;
				short num3 = num;
				num = (short)1709542410;
				switch (num3 == num)
				{
				}
				num = (short)962592768;
				if (num != 0)
				{
				}
				num = (short)1793916929;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)259129344;
				short num2 = num;
				num = (short)1861303590;
				short num3 = num;
				num = (short)1352547622;
				switch (num3 == num)
				{
				}
				num = (short)1764556800;
				if (num != 0)
				{
				}
				num = (short)1585905665;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00012A10 File Offset: 0x00010C10
		// (set) Token: 0x060000BD RID: 189 RVA: 0x00012ABC File Offset: 0x00010CBC
		public bool WriteSeparator
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)839057408;
				short num2 = num;
				num = (short)578108333;
				short num3 = num;
				num = (short)42482605;
				switch (num3 == num)
				{
				}
				num = (short)2144862209;
				if (num != 0)
				{
				}
				num = (short)1341456384;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)75144641;
				short num2 = num;
				num = (short)475962817;
				switch (num2 == num)
				{
				default:
				{
					num = (short)32047104;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)754581504;
				if (num != 0)
				{
				}
				num = (short)1714880513;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000BE RID: 190 RVA: 0x00012B68 File Offset: 0x00010D68
		// (set) Token: 0x060000BF RID: 191 RVA: 0x00012C18 File Offset: 0x00010E18
		public string CarriageReturnAndLineFeedReplacement
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)169242231;
				short num2 = num;
				num = (short)877031031;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1211498496;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)169213952;
				if (num != 0)
				{
				}
				num = (short)977928193;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)372599917;
				short num2 = num;
				num = (short)1563520109;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2099183616;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1391460353;
				if (num != 0)
				{
				}
				num = (short)627310592;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00012CC8 File Offset: 0x00010EC8
		public void WriteCsv(global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvFile csvFile, string filePath)
		{
			short num = (short)286090724;
			short num2 = num;
			num = (short)1435067876;
			switch (num2 == num)
			{
			default:
			{
				num = (short)834797568;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1738735617;
			if (num != 0)
			{
			}
			num = (short)436862976;
			if (num != 0)
			{
			}
			this.WriteCsv(csvFile, filePath, null);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00012D78 File Offset: 0x00010F78
		public void WriteCsv(global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvFile csvFile, string filePath, global::System.Text.Encoding encoding)
		{
			short num = (short)497942532;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.IO.StreamWriter streamWriter;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)664993793;
					if (num != 0)
					{
					}
					global::System.IO.File.Delete(filePath);
					num = (short)1421934593;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_CB;
				case 2:
					goto IL_110;
				case 3:
					streamWriter = new global::System.IO.StreamWriter(filePath, false, encoding ?? global::System.Text.Encoding.UTF8);
					num = (short)403308546;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				}
				IL_39:
				if (global::System.IO.File.Exists(filePath))
				{
					num = (short)195690496;
					short num3 = num;
					num = (short)1400242176;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_CB:
				num = (short)585629699;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_110:
			try
			{
				this.a(csvFile, streamWriter);
				streamWriter.Flush();
				streamWriter.Close();
			}
			finally
			{
				num = (short)1600520194;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_1E3;
					case 1:
					{
						num = (short)238716652;
						short num4 = num;
						num = (short)225871596;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_163;
						default:
							num = (short)662175744;
							if (num != 0)
							{
							}
							((global::System.IDisposable)streamWriter).Dispose();
							num = (short)703594496;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_15D;
						}
						continue;
					}
					goto IL_15D;
					IL_163:
					num = (short)564592641;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15D:
					if (streamWriter != null)
					{
						goto IL_163;
					}
					break;
				}
				IL_1E3:;
			}
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00012F7C File Offset: 0x0001117C
		public void WriteCsv(global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvFile csvFile, global::System.IO.Stream stream)
		{
			short num = (short)1588970910;
			short num2 = num;
			num = (short)916833694;
			switch (num2 == num)
			{
			}
			num = (short)1070858240;
			short num3 = num;
			num = (short)520814593;
			if (num != 0)
			{
			}
			num = (short)610664448;
			if (num != 0)
			{
			}
			this.WriteCsv(csvFile, stream, null);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00013030 File Offset: 0x00011230
		public void WriteCsv(global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvFile csvFile, global::System.IO.Stream stream, global::System.Text.Encoding encoding)
		{
			short num = (short)631052251;
			short num2 = num;
			num = (short)2070812635;
			switch (num2 == num)
			{
			}
			num = (short)563806208;
			short num3 = num;
			num = (short)1397948416;
			if (num != 0)
			{
			}
			num = (short)787611649;
			if (num != 0)
			{
			}
			stream.Position = 0L;
			this.a = new global::System.IO.StreamWriter(stream, encoding ?? global::System.Text.Encoding.Default);
			this.a(csvFile, this.a);
			this.a.Flush();
			stream.Position = 0L;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0001311C File Offset: 0x0001131C
		public string WriteCsv(global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvFile csvFile, global::System.Text.Encoding encoding)
		{
			short num = (short)1477705728;
			switch (num)
			{
			default:
			{
				num = (short)641531905;
				if (num != 0)
				{
				}
				num = (short)346750976;
				short num2 = num;
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				string result;
				try
				{
					global::System.IO.Stream stream = memoryStream;
					global::System.Text.Encoding encoding2 = encoding ?? global::System.Text.Encoding.Default;
					for (;;)
					{
						global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(stream, encoding2);
						try
						{
							this.a(csvFile, streamWriter);
							streamWriter.Flush();
							memoryStream.Position = 0L;
							global::System.IO.Stream stream2 = memoryStream;
							global::System.Text.Encoding encoding3 = encoding ?? global::System.Text.Encoding.Default;
							for (;;)
							{
								global::System.IO.StreamReader streamReader = new global::System.IO.StreamReader(stream2, encoding3);
								try
								{
									result = streamReader.ReadToEnd();
									streamWriter.Close();
									streamReader.Close();
									memoryStream.Close();
									return result;
								}
								finally
								{
									num = (short)244711425;
									int num3 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num3)
										{
										case 0:
											((global::System.IDisposable)streamReader).Dispose();
											num = (short)578748418;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_FE;
											}
											continue;
										case 2:
											goto IL_133;
										}
										IL_FE:
										if (streamReader == null)
										{
											break;
										}
										num = (short)880738304;
										num3 = (int)((global::System.IntPtr)num);
									}
									IL_133:;
								}
							}
						}
						finally
						{
							num = (short)1333723137;
							int num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									((global::System.IDisposable)streamWriter).Dispose();
									num = (short)796196866;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									num = (short)1834201308;
									short num4 = num;
									num = (short)649375964;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_201;
									default:
										num = (short)900988928;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_1C8;
										}
										continue;
									}
									break;
								}
								case 2:
									goto IL_1FF;
								}
								IL_1C8:
								if (streamWriter == null)
								{
									break;
								}
								num = (short)1797193728;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_1FF:
							IL_201:;
						}
					}
				}
				finally
				{
					num = (short)1621753857;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)721813506;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_240;
							}
							continue;
						case 2:
							goto IL_278;
						}
						IL_240:
						if (memoryStream == null)
						{
							break;
						}
						num = (short)1452343296;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_278:;
				}
				return result;
			}
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x000133F4 File Offset: 0x000115F4
		public void WriteCsv(global::System.Data.DataTable dataTable, string filePath)
		{
			short num = (short)1645692437;
			short num2 = num;
			num = (short)1218922005;
			switch (num2 == num)
			{
			}
			num = (short)1861877760;
			short num3 = num;
			num = (short)12124161;
			if (num != 0)
			{
			}
			num = (short)2127691776;
			if (num != 0)
			{
			}
			this.WriteCsv(dataTable, filePath, null);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000134A8 File Offset: 0x000116A8
		public void WriteCsv(global::System.Data.DataTable dataTable, string filePath, global::System.Text.Encoding encoding)
		{
			short num = (short)407502849;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.IO.StreamWriter streamWriter;
			for (;;)
			{
				num = (short)461760951;
				short num3 = num;
				num = (short)390719927;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				case 1:
					goto IL_80;
				default:
				{
					num = (short)14155776;
					short num4 = num;
					goto IL_80;
				}
				}
				IL_16:
				switch (0)
				{
				case 0:
					IL_D7:
					if (!global::System.IO.File.Exists(filePath))
					{
						goto IL_119;
					}
					num = (short)1014104067;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				continue;
				IL_119:
				num = (short)1789984772;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_80:
				num = (short)163708929;
				if (num != 0)
				{
				}
				num = (short)846856192;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_119;
				case 1:
					goto IL_16;
				case 2:
					goto IL_15D;
				case 3:
					global::System.IO.File.Delete(filePath);
					num = (short)628752384;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					streamWriter = new global::System.IO.StreamWriter(filePath, false, encoding ?? global::System.Text.Encoding.Default);
					num = (short)1255342082;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_D7;
			}
			IL_15D:
			try
			{
				this.a(dataTable, streamWriter);
				streamWriter.Flush();
				streamWriter.Close();
			}
			finally
			{
				num = (short)1299709953;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						((global::System.IDisposable)streamWriter).Dispose();
						num = (short)1294073858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_1A6;
						}
						continue;
					case 2:
						goto IL_1DA;
					}
					IL_1A6:
					if (streamWriter == null)
					{
						break;
					}
					num = (short)612761600;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1DA:;
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000136A4 File Offset: 0x000118A4
		public void WriteCsv(global::System.Data.DataTable dataTable, global::System.IO.Stream stream)
		{
			short num = (short)632762930;
			short num2 = num;
			num = (short)1426862642;
			switch (num2 == num)
			{
			}
			num = (short)1821966336;
			short num3 = num;
			num = (short)1642725377;
			if (num != 0)
			{
			}
			num = (short)187236352;
			if (num != 0)
			{
			}
			this.WriteCsv(dataTable, stream, null);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00013754 File Offset: 0x00011954
		public void WriteCsv(global::System.Data.DataTable dataTable, global::System.IO.Stream stream, global::System.Text.Encoding encoding)
		{
			short num = (short)1364930143;
			short num2 = num;
			num = (short)431107679;
			switch (num2 == num)
			{
			}
			num = (short)203816960;
			short num3 = num;
			num = (short)1900019713;
			if (num != 0)
			{
			}
			num = (short)651427840;
			if (num != 0)
			{
			}
			stream.Position = 0L;
			this.a = new global::System.IO.StreamWriter(stream, encoding ?? global::System.Text.Encoding.Default);
			this.a(dataTable, this.a);
			this.a.Flush();
			stream.Position = 0L;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00013840 File Offset: 0x00011A40
		public string WriteCsv(global::System.Data.DataTable dataTable, global::System.Text.Encoding encoding)
		{
			short num = (short)601554944;
			switch (num)
			{
			default:
			{
				num = (short)936181761;
				if (num != 0)
				{
				}
				num = (short)1939537920;
				short num2 = num;
				string result = string.Empty;
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				try
				{
					global::System.IO.Stream stream = memoryStream;
					global::System.Text.Encoding encoding2 = encoding ?? global::System.Text.Encoding.Default;
					for (;;)
					{
						global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(stream, encoding2);
						try
						{
							this.a(dataTable, streamWriter);
							streamWriter.Flush();
							memoryStream.Position = 0L;
							global::System.IO.Stream stream2 = memoryStream;
							global::System.Text.Encoding encoding3 = encoding ?? global::System.Text.Encoding.Default;
							for (;;)
							{
								global::System.IO.StreamReader streamReader = new global::System.IO.StreamReader(stream2, encoding3);
								try
								{
									result = streamReader.ReadToEnd();
									streamWriter.Close();
									streamReader.Close();
									memoryStream.Close();
									return result;
								}
								finally
								{
									num = (short)91750401;
									int num3 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num3)
										{
										case 0:
											((global::System.IDisposable)streamReader).Dispose();
											num = (short)1730543618;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_106;
											}
											continue;
										case 2:
											goto IL_13D;
										}
										IL_106:
										if (streamReader == null)
										{
											break;
										}
										num = (short)1961295872;
										num3 = (int)((global::System.IntPtr)num);
									}
									IL_13D:;
								}
							}
						}
						finally
						{
							num = (short)246874113;
							int num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									((global::System.IDisposable)streamWriter).Dispose();
									num = (short)1053032450;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									num = (short)929745658;
									short num4 = num;
									num = (short)322423546;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_20A;
									default:
										num = (short)1539112960;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_1D3;
										}
										continue;
									}
									break;
								}
								case 2:
									goto IL_208;
								}
								IL_1D3:
								if (streamWriter == null)
								{
									break;
								}
								num = (short)802291712;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_208:
							IL_20A:;
						}
					}
				}
				finally
				{
					num = (short)223477761;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							((global::System.IDisposable)memoryStream).Dispose();
							num = (short)905314306;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_248;
							}
							continue;
						case 2:
							goto IL_27E;
						}
						IL_248:
						if (memoryStream == null)
						{
							break;
						}
						num = (short)1059061760;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_27E:;
				}
				return result;
			}
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00013B1C File Offset: 0x00011D1C
		private void a(global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvFile A_0, global::System.IO.TextWriter A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvWriter.a a;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_1D4;
				case 1:
					goto IL_17E;
				case 2:
					this.a(A_0.HeaderAlias, a.b);
					num2 = (short)1948647427;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_95;
				case 4:
					goto IL_1D6;
				case 5:
					if (A_0.Headers.Count > 0)
					{
						num2 = (short)1962147841;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1D6;
				case 6:
					if (A_0.HeaderValidation.Count > 0)
					{
						num2 = (short)905838599;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_244;
				case 7:
				{
					num2 = (short)56629398;
					short num3 = num2;
					num2 = (short)1002641558;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_17E;
					default:
						num2 = (short)623443968;
						if (num2 != 0)
						{
						}
						this.a(A_0.HeaderValidation, a.b);
						num2 = (short)394592256;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 8:
					num2 = (short)128450561;
					if (num2 != 0)
					{
					}
					if (A_0.HeaderAlias.Count > 0)
					{
						num2 = (short)1829371906;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_95;
				}
				goto IL_34;
				IL_95:
				num2 = (short)1174863872;
				short num4 = num2;
				num2 = (short)467337222;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_17E:
				this.a(A_0.Headers, a.b);
				num2 = (short)1138032644;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1D6:
				num2 = (short)1421344776;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1D4:
			IL_244:
			A_0.Records.ForEach(new global::System.Action<global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord>(a.c));
			return;
			IL_34:
			a = new global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvWriter.a();
			a.a = this;
			a.b = A_1;
			this.a(a.b);
			num2 = (short)1547370501;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00013D84 File Offset: 0x00011F84
		private void a(global::System.Data.DataTable A_0, global::System.IO.TextWriter A_1)
		{
			short num = (short)1275396096;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1415643137;
				if (num != 0)
				{
				}
				num = (short)526450688;
				short num3 = num;
				this.a(A_1);
				global::System.Collections.Generic.IEnumerable<global::System.Data.DataColumn> source = A_0.Columns.Cast<global::System.Data.DataColumn>();
				global::System.Func<global::System.Data.DataColumn, string> selector = new global::System.Func<global::System.Data.DataColumn, string>(global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvWriter.<>c.<>9.a);
				for (;;)
				{
					global::System.Collections.Generic.List<string> list = source.Select(selector).ToList<string>();
					this.a(list, A_1);
					global::System.Collections.IEnumerator enumerator = A_0.Rows.GetEnumerator();
					try
					{
						num = (short)1260388354;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)1372192771;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)386138112;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)952377280;
								short num4 = num;
								num = (short)1244340160;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
								{
									num = (short)117112832;
									if (num != 0)
									{
									}
									global::System.Data.DataRow dataRow = (global::System.Data.DataRow)enumerator.Current;
									list.Clear();
									num = (short)744095748;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								break;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_D0;
								}
								continue;
							case 3:
								goto IL_1F9;
							case 4:
							{
								global::System.Data.DataRow dataRow;
								list.AddRange(dataRow.ItemArray.Select(new global::System.Func<object, string>(global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvWriter.<>c.<>9.a)));
								this.a(list, A_1);
								num = (short)217448453;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_15B:
							num = (short)312803329;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_D0:
							goto IL_15B;
						}
						IL_1F9:
						break;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_21B;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_208:
							switch (num2)
							{
							case 0:
								disposable.Dispose();
								num = (short)156106754;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								if (disposable != null)
								{
									num = (short)1040384000;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_270;
							case 2:
								goto IL_26E;
							}
							goto IL_21B;
						}
						IL_26E:
						IL_270:
						continue;
						IL_21B:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)1049624577;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_208;
					}
				}
				return;
			}
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0001405C File Offset: 0x0001225C
		private void a(global::System.IO.TextWriter A_0)
		{
			int a_ = 18;
			short num = (short)1654194176;
			short num2 = num;
			num = (short)392953856;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_63;
					}
					continue;
				case 1:
					return;
				case 2:
					A_0.WriteLine(global::CommonUtility.VersionUtility.b("あ⁄㝆瑈杊", a_));
					num = (short)1420230657;
					if (num != 0)
					{
					}
					num = (short)1650130945;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_63:
				if (!this.WriteSeparator)
				{
					break;
				}
				num = (short)1764977992;
				short num4 = num;
				num = (short)484339016;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)382795776;
					if (num != 0)
					{
					}
					num = (short)925368322;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00014190 File Offset: 0x00012390
		private void a(global::System.Collections.Generic.IList<string> A_0, global::System.IO.TextWriter A_1)
		{
			int a_ = 15;
			short num = (short)665387008;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_88;
				}
				int num4;
				for (;;)
				{
					IL_31:
					bool flag;
					string text;
					bool flag2;
					string text2;
					bool flag3;
					switch (num2)
					{
					case 0:
					{
						num = (short)1185302919;
						short num3 = num;
						num = (short)1391675783;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1507721216;
							if (num != 0)
							{
							}
							flag = true;
							goto IL_1B9;
						}
						break;
					}
					case 1:
						if (this.ReplaceCarriageReturnsAndLineFeedsFromFieldValues)
						{
							num = (short)1417084939;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3DB;
					case 2:
						goto IL_4B0;
					case 3:
						text = A_0[num4].Replace(global::CommonUtility.VersionUtility.b("房", a_), global::CommonUtility.VersionUtility.b("房恁", a_));
						goto IL_26F;
					case 4:
						if (!A_0[num4].Contains(global::CommonUtility.VersionUtility.b("氿", a_)))
						{
							num = (short)1825374222;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1425080320;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_472;
					case 6:
					{
						num = (short)231211008;
						short num5 = num;
						goto IL_472;
					}
					case 7:
						if (num4 >= A_0.Count)
						{
							num = (short)1755054082;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1708130308;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)1563623434;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_36E;
					case 10:
						text = A_0[num4];
						goto IL_26F;
					case 11:
						num = (short)785842189;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (!flag2)
						{
							num = (short)1371537416;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1744896003;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (!text2.Contains(global::CommonUtility.VersionUtility.b("䴿", a_)))
						{
							num = (short)489160723;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36E;
					case 14:
						num = (short)1119748112;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (text2.Contains(global::CommonUtility.VersionUtility.b("䨿", a_)))
						{
							num = (short)2039480329;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3DB;
					case 16:
						flag = A_0[num4].Contains(global::CommonUtility.VersionUtility.b("䨿", a_));
						goto IL_1B9;
					case 17:
						A_1.Write(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::CommonUtility.VersionUtility.b("㬿牁㥃㵅祇㝉㝋繍ⵏ⥑晓⭕", a_), (flag3 || flag2) ? global::CommonUtility.VersionUtility.b("房", a_) : string.Empty, text2, (num4 < A_0.Count - 1) ? global::CommonUtility.VersionUtility.b("氿", a_) : string.Empty));
						num4++;
						num = (short)371720197;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_3DB;
					case 19:
						num = (short)2052718593;
						if (num != 0)
						{
						}
						num = (short)701235215;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_88;
					IL_1B9:
					flag3 = flag;
					flag2 = A_0[num4].Contains(global::CommonUtility.VersionUtility.b("房", a_));
					num = (short)1896284172;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_26F:
					text2 = text;
					num = (short)1154416641;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_36E:
					flag3 = true;
					text2 = text2.Replace(global::CommonUtility.VersionUtility.b("䴿䡁", a_), this.CarriageReturnAndLineFeedReplacement);
					text2 = text2.Replace(global::CommonUtility.VersionUtility.b("䴿", a_), this.CarriageReturnAndLineFeedReplacement);
					text2 = text2.Replace(global::CommonUtility.VersionUtility.b("䨿", a_), this.CarriageReturnAndLineFeedReplacement);
					num = (short)724959250;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3DB:
					num = (short)673120273;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_472:
					num = (short)1279262727;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_4B0:
				A_1.WriteLine();
				return;
				IL_88:
				num4 = 0;
				num = (short)48889862;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00014658 File Offset: 0x00012858
		public void Dispose()
		{
			short num = (short)1181939989;
			short num2 = num;
			num = (short)957348117;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1263140864;
				short num3 = num;
				num = (short)1621950464;
				if (num != 0)
				{
				}
				num = (short)386334721;
				if (num != 0)
				{
				}
				if (this.a != null)
				{
					this.a.Close();
					this.a.Dispose();
					return;
				}
				break;
			}
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00014724 File Offset: 0x00012924
		public CsvWriter()
		{
			int a_ = 13;
			this.b = true;
			this.c = true;
			this.d = global::CommonUtility.VersionUtility.b("ሽ", a_);
			base..ctor();
		}

		// Token: 0x04000046 RID: 70
		private global::System.IO.StreamWriter a;

		// Token: 0x04000047 RID: 71
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool b;

		// Token: 0x04000048 RID: 72
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool c;

		// Token: 0x04000049 RID: 73
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string d;

		// Token: 0x02000022 RID: 34
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x060000D1 RID: 209 RVA: 0x00014778 File Offset: 0x00012978
			internal void c(global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvRecord A_0)
			{
				short num = (short)1170699291;
				short num2 = num;
				num = (short)121467931;
				switch (num2 == num)
				{
				default:
				{
					num = (short)607453184;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1036845057;
				if (num != 0)
				{
				}
				num = (short)538378240;
				if (num != 0)
				{
				}
				this.a.a(A_0.Fields, this.b);
			}

			// Token: 0x0400004A RID: 74
			public global::Motorola.CommonCPS.Common.CommonUtility.CSV.CsvWriter a;

			// Token: 0x0400004B RID: 75
			public global::System.IO.TextWriter b;
		}
	}
}
