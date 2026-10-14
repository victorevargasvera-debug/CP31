using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace Motorola.CommonCPS.RadioManagement.BatchOp
{
	// Token: 0x02000057 RID: 87
	public class PBBSimpleTouchUtility
	{
		// Token: 0x06000203 RID: 515 RVA: 0x000332D4 File Offset: 0x000314D4
		public bool IsFileValid(string xmlFilePath, out string errorMsg)
		{
			short num;
			for (;;)
			{
				this.a = true;
				errorMsg = null;
				try
				{
					global::System.Xml.XmlReaderSettings settings = this.a();
					global::System.Xml.XmlReader xmlReader = global::System.Xml.XmlReader.Create(xmlFilePath, settings);
					goto IL_1D;
					try
					{
						for (;;)
						{
							IL_1D:
							num = (short)81002497;
							int num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									errorMsg = this.b;
									num = (short)1823670275;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_59;
									}
									continue;
								case 2:
									num = (short)1675296773;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_CF;
								case 4:
									goto IL_E8;
								case 5:
									if (!this.a)
									{
										num = (short)1600847872;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_CF;
								}
								IL_59:
								if (!xmlReader.Read())
								{
									num = (short)1846214658;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
								IL_CF:
								num = (short)1375207428;
								num2 = (int)((global::System.IntPtr)num);
							}
						}
						IL_E8:;
					}
					finally
					{
						num = (short)1406992384;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_11B;
								}
								continue;
							case 1:
								goto IL_151;
							case 2:
								((global::System.IDisposable)xmlReader).Dispose();
								num = (short)954400769;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_11B:
							if (xmlReader == null)
							{
								break;
							}
							num = (short)1104216066;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_151:;
					}
				}
				catch (global::System.Exception ex)
				{
					errorMsg = ex.Message;
					this.a = false;
				}
				num = (short)452254754;
				short num3 = num;
				num = (short)406445090;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					goto IL_1C6;
				}
				break;
			}
			num = (short)314638336;
			short num4 = num;
			IL_1C6:
			num = (short)350879745;
			if (num != 0)
			{
			}
			num = (short)1191510016;
			if (num != 0)
			{
			}
			return this.a;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00033520 File Offset: 0x00031720
		public bool IsDocumentValid(global::System.Xml.XmlDocument document, out string errorMsg)
		{
			short num = (short)456327168;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				this.a = true;
				errorMsg = null;
				try
				{
					global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
					try
					{
						switch (0)
						{
						case 0:
							goto IL_5F;
						}
						global::System.Xml.XmlReader xmlReader;
						for (;;)
						{
							IL_3C:
							switch (num2)
							{
							case 0:
								goto IL_130;
							case 1:
								if (!this.a)
								{
									num = (short)111738885;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_130;
							case 2:
								goto IL_9B;
							case 3:
								goto IL_148;
							case 4:
								if (!xmlReader.Read())
								{
									num = (short)1874526214;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_9B;
							case 5:
								errorMsg = this.b;
								num = (short)2088566784;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								num = (short)626196481;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_5F;
							IL_9B:
							num = (short)1037762564;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_130:
							num = (short)2007433219;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_148:
						goto IL_20D;
						IL_5F:
						document.Save(memoryStream);
						memoryStream.Flush();
						memoryStream.Position = 0L;
						global::System.Xml.XmlReaderSettings settings = this.a();
						xmlReader = global::System.Xml.XmlReader.Create(memoryStream, settings);
						num = (short)1355939842;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_3C;
					}
					finally
					{
						num = (short)910688258;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_20A;
							case 1:
							{
								num = (short)208340606;
								short num3 = num;
								num = (short)121898622;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_20C;
								default:
									num = (short)1749090304;
									if (num != 0)
									{
									}
									((global::System.IDisposable)memoryStream).Dispose();
									num = (short)752943104;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_180;
								}
								continue;
							}
							IL_180:
							if (memoryStream == null)
							{
								break;
							}
							num = (short)522059777;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_20A:
						IL_20C:;
					}
					IL_20D:;
				}
				catch (global::System.Exception ex)
				{
					errorMsg = ex.Message;
					this.a = false;
				}
				num = (short)1802960897;
				if (num != 0)
				{
				}
				num = (short)7405568;
				short num4 = num;
				return this.a;
			}
			}
		}

		// Token: 0x06000205 RID: 517 RVA: 0x000337DC File Offset: 0x000319DC
		public bool IsDocumentValid(global::System.Xml.Linq.XDocument document, out string errorMsg)
		{
			short num = (short)421920769;
			if (num != 0)
			{
			}
			this.a = true;
			errorMsg = null;
			global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
			global::System.Xml.XmlReader xmlReader = document.CreateReader();
			try
			{
				xmlDocument.Load(xmlReader);
			}
			finally
			{
				num = (short)850722818;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_103;
					case 1:
					{
						num = (short)572399896;
						short num3 = num;
						num = (short)497361176;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_105;
						default:
							num = (short)1129381888;
							if (num != 0)
							{
							}
							((global::System.IDisposable)xmlReader).Dispose();
							num = (short)311296000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_7D;
						}
						continue;
					}
					IL_7D:
					if (xmlReader == null)
					{
						break;
					}
					num = (short)1592721409;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_103:
				IL_105:;
			}
			num = (short)1356857344;
			short num4 = num;
			return this.IsDocumentValid(xmlDocument, out errorMsg);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00033934 File Offset: 0x00031B34
		private void a(object A_0, global::System.Xml.Schema.ValidationEventArgs A_1)
		{
			for (;;)
			{
				IL_00:
				short num = (short)1952448513;
				if (num != 0)
				{
				}
				num = (short)1806827522;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						return;
					case 1:
						goto IL_81;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_60;
						}
						continue;
					case 3:
					{
						num = (short)1075622679;
						short num3 = num;
						num = (short)2114106135;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
						{
							num = (short)544735232;
							if (num != 0)
							{
							}
							num = (short)896270336;
							short num4 = num;
							if (A_1.Severity == global::System.Xml.Schema.XmlSeverityType.Error)
							{
								num = (short)131465217;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						}
						break;
					}
					case 4:
						num = (short)812580867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_60:
					if (A_1.Severity != global::System.Xml.Schema.XmlSeverityType.Warning)
					{
						num = (short)108265476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_81:
					this.b = A_1.Message;
					this.a = false;
					num = (short)876412928;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00033AA0 File Offset: 0x00031CA0
		private global::System.Xml.XmlReaderSettings a()
		{
			int a_ = 11;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			global::System.Xml.XmlReaderSettings xmlReaderSettings;
			string text;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					return xmlReaderSettings;
				case 1:
				{
					for (;;)
					{
						global::System.Xml.XmlReader schemaDocument = global::System.Xml.XmlReader.Create(global::System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(text));
						xmlReaderSettings = new global::System.Xml.XmlReaderSettings();
						xmlReaderSettings.Schemas.Add(global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("룏ꛑꃓꛕ귝菟諡臣该觧駩싫迭黯雱蛳駵釷黹틻鷽濿漁⬃朅砇愉⌋簍甏愑㬓甕眗眙㈛猝伟嘡䬣吥䜧䘩䴫崭弯帱䄳䈵儷唹刻䴽渿ㅁⵃ⭅㡇♉⥋㩍㽏❑㝓㹕", a_), schemaDocument);
						xmlReaderSettings.ValidationFlags |= global::System.Xml.Schema.XmlSchemaValidationFlags.ReportValidationWarnings;
						xmlReaderSettings.ValidationType = global::System.Xml.ValidationType.Schema;
						xmlReaderSettings.ValidationEventHandler += this.a;
						num2 = (short)1589930916;
						short num3 = num2;
						num2 = (short)1844341668;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_12F;
						}
					}
					IL_12F:
					num2 = (short)639041536;
					short num4 = num2;
					num2 = (short)1455882240;
					if (num2 != 0)
					{
					}
					num2 = (short)609026048;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					if (global::System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceNames().Contains(text))
					{
						num2 = (short)1490157569;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return xmlReaderSettings;
				}
				goto IL_25;
			}
			return xmlReaderSettings;
			IL_25:
			num2 = (short)1417478145;
			if (num2 != 0)
			{
			}
			xmlReaderSettings = null;
			text = global::Motorola.CommonCPS.RadioManagement.BatchOp.PBBSimpleTouchUtility.b("鷏뷑ꃓ맕꫗뗙냛뿝컟ꇡ诣该藧藩苫귭ꃯꇱ\udaf3ꓵ駷黹闻釽䷿持樃朅漇漉愋欍縏昑㨓夕栗缙減缝吟䬡䬣䠥ا稩䴫䴭嬯匱匳匵ᘷ樹縻簽渿ㅁⵃ⭅㡇♉⥋㩍㽏❑㝓㹕癗≙⽛㩝", a_);
			num2 = (short)124190722;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00033C54 File Offset: 0x00031E54
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(127490049 + A_1) + (global::System.IntPtr)78 + (global::System.IntPtr)25 + (global::System.IntPtr)92);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_5C;
			}
			IL_29:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_5C:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_29;
		}

		// Token: 0x0400009C RID: 156
		private bool a = true;

		// Token: 0x0400009D RID: 157
		private string b;

		// Token: 0x0400009E RID: 158
		private const string c = "http://schemas.android.com/apk/res/com.motorolasolutions.simpletouch";
	}
}
