using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Encaten;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000A RID: 10
	internal sealed class a
	{
		// Token: 0x0600004E RID: 78 RVA: 0x000096E0 File Offset: 0x000078E0
		private string b()
		{
			short num = (short)989903814;
			short num2 = num;
			num = (short)1522514886;
			switch (num2 == num)
			{
			}
			num = (short)330170368;
			if (num != 0)
			{
			}
			num = (short)1442381825;
			if (num != 0)
			{
			}
			num = (short)1158021120;
			short num3 = num;
			return this.b;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00009790 File Offset: 0x00007990
		private void c(string value)
		{
			short num = (short)1942468328;
			short num2 = num;
			num = (short)2144057064;
			switch (num2 == num)
			{
			}
			num = (short)1081278465;
			if (num != 0)
			{
			}
			num = (short)454819840;
			if (num != 0)
			{
			}
			num = (short)1087635456;
			short num3 = num;
			this.b = value;
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00009840 File Offset: 0x00007A40
		private a()
		{
			this.b = string.Empty;
			this.a = null;
			this.d = false;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00009878 File Offset: 0x00007A78
		public a(string path)
		{
			this.b = path;
			this.a = global::Encaten.EncatenWrapperFactory.CreateEncatenWrapper();
			this.d = false;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000098B0 File Offset: 0x00007AB0
		public bool c()
		{
			int a_ = 18;
			switch (0)
			{
			case 0:
				goto IL_41;
			}
			int num;
			short num2;
			bool flag;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1774832520;
					short num3 = num2;
					num2 = (short)131320712;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1F4;
					default:
						num2 = (short)1293680640;
						if (num2 != 0)
						{
						}
						if (global::System.IO.File.Exists(this.b))
						{
							num2 = (short)884473865;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return flag;
					}
					break;
				}
				case 1:
					goto IL_D0;
				case 2:
					if (flag)
					{
						num2 = (short)2037448709;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return flag;
				case 3:
					num2 = (short)944439297;
					if (num2 != 0)
					{
					}
					if (this.a.openAndGetFilePackage(this.b, global::Motorola.Common.Communication.Crc32.c("쟵뫷췹쳻쟽㟿䜁㰃⬅䰇㌉䤋㴍㴏⌑┓爕ⴗ㜙崛ⴝ戟朡णᘥᠧᰩᰫ氭/琱瘳صष༹紻", a_), out this.e) >= 0)
					{
						num2 = (short)1551368198;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D0;
				case 4:
					return flag;
				case 5:
					goto IL_1F4;
				case 6:
					this.a.getFilePackageEncryptionStatus(out flag);
					num2 = (short)1175388161;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (this.d)
					{
						num2 = (short)854982656;
						short num4 = num2;
						num2 = (short)1801650184;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1754267651;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					return true;
				case 9:
					num2 = (short)665976839;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_41;
				IL_D0:
				num2 = (short)487194626;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1F4:
				this.d = true;
				num2 = (short)322437124;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_41:
			flag = false;
			num2 = (short)1354563584;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00009B00 File Offset: 0x00007D00
		private bool a()
		{
			int a_ = 10;
			switch (0)
			{
			case 0:
				goto IL_51;
			}
			int num;
			string componentName;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					componentName = global::Motorola.Common.Communication.Crc32.c("뻭듯꛱뗳", a_);
					num2 = (short)124518412;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (this.d(componentName) < 1)
					{
						num2 = (short)418512899;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_AB;
				case 2:
				{
					num2 = (short)799473664;
					short num3 = num2;
					componentName = global::Motorola.Common.Communication.Crc32.c("ꫭ뛯ꗱ럳", a_);
					num2 = (short)209256457;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					return false;
				case 4:
					if (this.d(componentName) < 1)
					{
						num2 = (short)1785069574;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2DF;
				case 5:
					return false;
				case 6:
					return false;
				case 7:
					componentName = global::Motorola.Common.Communication.Crc32.c("ꛭ뛯ꗱ럳", a_);
					num2 = (short)1608908801;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					num2 = (short)2072576001;
					if (num2 != 0)
					{
					}
					if (this.d(componentName) < 1)
					{
						num2 = (short)1904148487;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_AB;
				case 9:
					if (this.d(componentName) < 1)
					{
						num2 = (short)573833221;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2DF;
				case 10:
					if (this.d(componentName) < 1)
					{
						num2 = (short)1485504514;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2DF;
				case 11:
					if (this.d(componentName) < 1)
					{
						num2 = (short)817299456;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_125;
				case 12:
					if (this.d(componentName) < 1)
					{
						num2 = (short)1010696205;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					componentName = global::Motorola.Common.Communication.Crc32.c("ꛭ뛯ꗱ뗳", a_);
					num2 = (short)1960116232;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					return false;
				}
				goto IL_51;
				IL_AB:
				componentName = global::Motorola.Common.Communication.Crc32.c("ꫭ뛯ꗱ뗳", a_);
				num2 = (short)1622933514;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_125:
				componentName = global::Motorola.Common.Communication.Crc32.c("ꫭ뛯ꗱ냳", a_);
				num2 = (short)506789892;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2DF:
				num2 = (short)651109320;
				short num4 = num2;
				num2 = (short)1286874056;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_125;
				default:
					goto IL_313;
				}
			}
			return false;
			IL_313:
			num2 = (short)1534001152;
			if (num2 != 0)
			{
			}
			return true;
			IL_51:
			string empty = string.Empty;
			string empty2 = string.Empty;
			componentName = global::Motorola.Common.Communication.Crc32.c("ꛭ뛯ꗱꟳ", a_);
			num2 = (short)1975648267;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00009E38 File Offset: 0x00008038
		internal int d(string ComponentName)
		{
			int a_ = 15;
			short num = (short)199688192;
			short num2 = num;
			num = (short)2021195777;
			if (num != 0)
			{
			}
			int num3 = 0;
			global::System.IO.StringReader stringReader = new global::System.IO.StringReader(this.e);
			try
			{
				global::System.Xml.XmlReader xmlReader = global::System.Xml.XmlReader.Create(stringReader);
				try
				{
					switch (0)
					{
					case 0:
						goto IL_BE;
					}
					int num4;
					for (;;)
					{
						IL_7C:
						switch (num4)
						{
						case 0:
							num = (short)1730543620;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)1709441033;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (xmlReader.MoveToFirstAttribute())
							{
								num = (short)1051525120;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1CC;
						case 3:
							if (xmlReader.Name == global::Motorola.Common.Communication.Crc32.c("闲鳴鯶鳸닺觼髾氀", a_))
							{
								num = (short)1495007237;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1CC;
						case 4:
							if (xmlReader.MoveToAttribute(global::Motorola.Common.Communication.Crc32.c("闲鳴鯶鳸뗺鳼鋾搀", a_)))
							{
								num = (short)1638406;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1CC;
						case 5:
							num = (short)777715714;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							num = (short)2083979271;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							if (xmlReader.HasValue)
							{
								num = (short)1796931585;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1CC;
						case 8:
							if (!xmlReader.Read())
							{
								num = (short)860815370;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)277282819;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							if (xmlReader.Value == ComponentName)
							{
								num = (short)1820917774;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1CC;
						case 10:
							num = (short)984154125;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							goto IL_1CC;
						case 12:
							goto IL_1CC;
						case 13:
							goto IL_2AB;
						case 14:
							num3++;
							num = (short)83689483;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BE;
						IL_1CC:
						num = (short)1929773064;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_2AB:
					return num3;
					IL_BE:
					xmlReader.MoveToContent();
					num = (short)946929676;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_7C;
				}
				finally
				{
					num = (short)842530816;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_2E2;
							}
							continue;
						case 1:
							goto IL_318;
						case 2:
							((global::System.IDisposable)xmlReader).Dispose();
							num = (short)127139841;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_2E2:
						if (xmlReader == null)
						{
							break;
						}
						num = (short)1303379970;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_318:;
				}
			}
			finally
			{
				num = (short)373686272;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_34C;
						}
						continue;
					case 1:
						goto IL_3D0;
					case 2:
						for (;;)
						{
							((global::System.IDisposable)stringReader).Dispose();
							num = (short)1125277892;
							short num5 = num;
							num = (short)1496211652;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_3A4;
							}
						}
						IL_3A4:
						num = (short)680656896;
						if (num != 0)
						{
						}
						num = (short)377749505;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_34C:
					if (stringReader == null)
					{
						break;
					}
					num = (short)256704514;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_3D0:;
			}
			return num3;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000A250 File Offset: 0x00008450
		private bool b(string modelNumber)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
				{
					string text = text.Trim();
					num2 = (short)1196359681;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
				{
					string text;
					if (modelNumber.Trim()[0] == text[0])
					{
						num2 = (short)52494339;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 2:
					goto IL_DE;
				case 3:
					result = true;
					num2 = (short)553189380;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_11C;
				}
				goto IL_24;
			}
			IL_11C:
			return result;
			IL_24:
			num2 = (short)1551958017;
			if (num2 != 0)
			{
			}
			num2 = (short)186203100;
			short num3 = num2;
			num2 = (short)1813199836;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_DE:
				string text;
				if (string.IsNullOrEmpty(text))
				{
					num2 = (short)1411252224;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				break;
			}
			default:
			{
				num2 = (short)961937408;
				short num4 = num2;
				num2 = (short)1656160256;
				if (num2 != 0)
				{
				}
				result = false;
				string text = this.d();
				num2 = (short)2134900738;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
			return result;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000A3C8 File Offset: 0x000085C8
		internal string d()
		{
			int a_ = 7;
			short num = (short)483262464;
			short num2 = num;
			string result = string.Empty;
			global::System.IO.StringReader stringReader = new global::System.IO.StringReader(this.e);
			try
			{
				global::System.Xml.XmlReader xmlReader = global::System.Xml.XmlReader.Create(stringReader);
				try
				{
					num = (short)1589641224;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							if (xmlReader.HasValue)
							{
								num = (short)2032009220;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 1:
							if (xmlReader.MoveToAttribute(global::Motorola.Common.Communication.Crc32.c("跪蓬菮铰ꏲ铴银鋸髺髼髾䔀昂瘄猆怈攊氌笎砐簒笔帖眘級爜", a_)))
							{
								num = (short)1814036487;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 2:
							goto IL_17D;
						case 3:
							if (!xmlReader.Read())
							{
								num = (short)24051717;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)937754634;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							result = xmlReader.Value;
							num = (short)260636674;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							num = (short)1908801545;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							num = (short)29818881;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							num = (short)517406720;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							switch (0)
							{
							case 0:
								goto IL_A1;
							}
							continue;
						case 9:
							goto IL_1D7;
						case 10:
							if (xmlReader.MoveToFirstAttribute())
							{
								num = (short)274333702;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						IL_E7:
						num = (short)270663683;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_A1:
						goto IL_E7;
					}
					IL_17D:
					IL_1D7:;
				}
				finally
				{
					num = (short)1025310720;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_20C;
							}
							continue;
						case 1:
							goto IL_240;
						case 2:
							((global::System.IDisposable)xmlReader).Dispose();
							num = (short)1387069441;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_20C:
						if (xmlReader == null)
						{
							break;
						}
						num = (short)1947140098;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_240:;
				}
			}
			finally
			{
				num = (short)1013448704;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_273;
						}
						continue;
					case 1:
						goto IL_2F9;
					case 2:
						for (;;)
						{
							((global::System.IDisposable)stringReader).Dispose();
							num = (short)925655703;
							short num4 = num;
							num = (short)920609431;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_2CC;
							}
						}
						IL_2CC:
						num = (short)484376576;
						if (num != 0)
						{
						}
						num = (short)688783361;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_273:
					if (stringReader == null)
					{
						break;
					}
					num = (short)1197604866;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_2F9:;
			}
			num = (short)708837377;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x0000A730 File Offset: 0x00008930
		private string a(string A_0, bool A_1 = true)
		{
			int a_ = 3;
			switch (0)
			{
			case 0:
				goto IL_35;
			}
			string text;
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					text = text.Replace(global::Motorola.Common.Communication.Crc32.c("짦", a_), "");
					num2 = (short)1250492418;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_1D1;
				case 2:
					goto IL_14D;
				case 3:
					text = this.e(A_0);
					num2 = (short)1349582849;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (this.d(A_0) > 0)
					{
						num2 = (short)278855683;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return text;
				case 5:
				{
					text = text.TrimEnd(global::System.Array.Empty<char>());
					char[] trimChars = new char[]
					{
						'\0',
						' ',
						'\r',
						'\n'
					};
					text = text.TrimEnd(trimChars);
					num2 = (short)226820102;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					if (A_1)
					{
						num2 = (short)1852178432;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return text;
				}
				goto IL_35;
			}
			IL_14D:
			return text;
			IL_35:
			num2 = (short)1459093505;
			if (num2 != 0)
			{
			}
			num2 = (short)376504320;
			short num3 = num2;
			num2 = (short)2062490576;
			short num4 = num2;
			num2 = (short)704715728;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_1D1:
				if (!string.IsNullOrEmpty(text))
				{
					num2 = (short)46530565;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_13;
				}
				break;
			default:
			{
				num2 = (short)23003136;
				if (num2 != 0)
				{
				}
				text = string.Empty;
				string empty = string.Empty;
				num2 = (short)1156120580;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
			return text;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000A938 File Offset: 0x00008B38
		internal string e(string ComponentName)
		{
			int a_ = 16;
			short num = (short)1157890048;
			short num2 = num;
			num = (short)1788084225;
			if (num != 0)
			{
			}
			string result = string.Empty;
			global::System.IO.StringReader stringReader = new global::System.IO.StringReader(this.e);
			try
			{
				global::System.Xml.XmlReader xmlReader = global::System.Xml.XmlReader.Create(stringReader);
				try
				{
					switch (0)
					{
					case 0:
						goto IL_D5;
					}
					int num3;
					for (;;)
					{
						IL_83:
						switch (num3)
						{
						case 0:
							num = (short)1189609477;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)1449525256;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							result = xmlReader.Value;
							num = (short)1479016451;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_155;
						case 4:
							if (!xmlReader.Read())
							{
								num = (short)1820262417;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1845886991;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if (xmlReader.HasValue)
							{
								num = (short)198443010;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1E8;
						case 6:
							num = (short)745406476;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							if (xmlReader.HasValue)
							{
								num = (short)789446669;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1E8;
						case 8:
							if (xmlReader.MoveToFirstAttribute())
							{
								num = (short)899809286;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1E8;
						case 9:
							num = (short)1187446795;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							goto IL_357;
						case 11:
							if (xmlReader.MoveToAttribute(global::Motorola.Common.Communication.Crc32.c("鋳鿵铷鿹꫻鯽狿焁洃椅昇", a_)))
							{
								num = (short)95092736;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1E8;
						case 12:
							if (xmlReader.MoveToAttribute(global::Motorola.Common.Communication.Crc32.c("鋳鿵铷鿹닻鿽淿朁", a_)))
							{
								num = (short)1375797262;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1E8;
						case 13:
							num = (short)671154194;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							num = (short)81461255;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							if (xmlReader.Name == global::Motorola.Common.Communication.Crc32.c("鋳鿵铷鿹뗻諽旿漁", a_))
							{
								num = (short)581500929;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1E8;
						case 16:
							goto IL_1E8;
						case 17:
							num = (short)2044133386;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
							if (xmlReader.Value == ComponentName)
							{
								num = (short)1400700937;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1E8;
						}
						goto IL_D5;
						IL_1E8:
						num = (short)211681284;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_155:
					IL_357:
					return result;
					IL_D5:
					xmlReader.MoveToContent();
					num = (short)1618542608;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_83;
				}
				finally
				{
					num = (short)1638203392;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_38D;
							}
							continue;
						case 1:
							goto IL_3C0;
						case 2:
							((global::System.IDisposable)xmlReader).Dispose();
							num = (short)2042363905;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_38D:
						if (xmlReader == null)
						{
							break;
						}
						num = (short)1320091650;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_3C0:;
				}
			}
			finally
			{
				num = (short)186187776;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_3F4;
						}
						continue;
					case 1:
						goto IL_47C;
					case 2:
						for (;;)
						{
							((global::System.IDisposable)stringReader).Dispose();
							num = (short)1179245700;
							short num4 = num;
							num = (short)2006310020;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_44F;
							}
						}
						IL_44F:
						num = (short)629800960;
						if (num != 0)
						{
						}
						num = (short)691535873;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_3F4:
					if (stringReader == null)
					{
						break;
					}
					num = (short)113573890;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_47C:;
			}
			return result;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000ADFC File Offset: 0x00008FFC
		public void a(string A_0, out string A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (this.d(A_0) > 0)
					{
						num2 = (short)1121189890;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					return;
				case 2:
				{
					num2 = (short)731709441;
					if (num2 != 0)
					{
					}
					A_1 = this.f(A_0);
					num2 = (short)175325604;
					short num3 = num2;
					num2 = (short)1034305956;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)988479488;
						if (num2 != 0)
						{
						}
						num2 = (short)439877633;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			num2 = (short)1534197760;
			short num4 = num2;
			A_1 = string.Empty;
			string empty = string.Empty;
			string empty2 = string.Empty;
			num2 = (short)927793152;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000AF34 File Offset: 0x00009134
		internal string f(string ComponentName)
		{
			int a_ = 7;
			short num = (short)1127284736;
			short num2 = num;
			num = (short)1618754903;
			short num3 = num;
			num = (short)1479687511;
			string result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1501757441;
				if (num != 0)
				{
				}
				num = (short)1623523328;
				if (num != 0)
				{
				}
				num = (short)2131296256;
				int num4 = (int)num;
				switch (num4)
				{
				default:
				{
					result = string.Empty;
					global::System.Xml.XmlReaderSettings xmlReaderSettings = new global::System.Xml.XmlReaderSettings();
					xmlReaderSettings.IgnoreWhitespace = true;
					global::System.IO.StringReader stringReader = new global::System.IO.StringReader(this.e);
					try
					{
						global::System.Xml.XmlReader xmlReader = global::System.Xml.XmlReader.Create(stringReader, xmlReaderSettings);
						try
						{
							switch (0)
							{
							case 0:
								goto IL_150;
							}
							for (;;)
							{
								IL_F9:
								switch (num4)
								{
								case 0:
									if (!xmlReader.Read())
									{
										num = (short)1921187852;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)124518419;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_291;
								case 2:
									result = (global::System.Xml.Linq.XNode.ReadFrom(xmlReader) as global::System.Xml.Linq.XElement).Value.Trim();
									num = (short)127860749;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)1506869266;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)939720713;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									if (xmlReader.Name == global::Motorola.Common.Communication.Crc32.c("跪蓬菮铰뫲致鋶铸", a_))
									{
										num = (short)20840454;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_291;
								case 6:
									num = (short)1851260935;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									if (xmlReader.MoveToFirstAttribute())
									{
										num = (short)1808531460;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_291;
								case 8:
									goto IL_1BF;
								case 9:
									if (xmlReader.MoveToAttribute(global::Motorola.Common.Communication.Crc32.c("跪蓬菮铰뷲铴髶鳸", a_)))
									{
										num = (short)89194499;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_291;
								case 10:
									num = (short)223215624;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									num = (short)2047475726;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									goto IL_291;
								case 13:
									goto IL_291;
								case 14:
									if (xmlReader.Value == ComponentName)
									{
										num = (short)15204362;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_291;
								case 15:
									num = (short)1541603344;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									goto IL_417;
								case 17:
									if (!xmlReader.Read())
									{
										num = (short)908197903;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1773338629;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									if (xmlReader.HasValue)
									{
										num = (short)1502674955;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_291;
								case 19:
									if (xmlReader.Name == global::Motorola.Common.Communication.Crc32.c("跪蓬菮铰럲铴菶飸", a_))
									{
										num = (short)138412034;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1BF;
								}
								goto IL_150;
								IL_1BF:
								num = (short)806617088;
								num4 = (int)((global::System.IntPtr)num);
								continue;
								IL_291:
								num = (short)26804241;
								num4 = (int)((global::System.IntPtr)num);
							}
							IL_417:
							break;
							IL_150:
							xmlReader.MoveToContent();
							num = (short)1388969985;
							num4 = (int)((global::System.IntPtr)num);
							goto IL_F9;
						}
						finally
						{
							num = (short)1183645696;
							num4 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num4)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_44F;
									}
									continue;
								case 1:
									goto IL_485;
								case 2:
									((global::System.IDisposable)xmlReader).Dispose();
									num = (short)1500053505;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_44F:
								if (xmlReader == null)
								{
									break;
								}
								num = (short)694353922;
								num4 = (int)((global::System.IntPtr)num);
							}
							IL_485:;
						}
					}
					finally
					{
						num = (short)1034092544;
						num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_4BA;
								}
								continue;
							case 1:
								goto IL_4EF;
							case 2:
								((global::System.IDisposable)stringReader).Dispose();
								num = (short)527433729;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_4BA:
							if (stringReader == null)
							{
								break;
							}
							num = (short)414973954;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_4EF:;
					}
					break;
				}
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000B468 File Offset: 0x00009668
		private bool a(string A_0, string A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
				{
					if (this.d(A_0) > 0)
					{
						num2 = (short)340656129;
						if (num2 != 0)
						{
						}
						num2 = (short)1130496003;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = false;
					num2 = (short)1339817984;
					short num3 = num2;
					num2 = (short)1870528514;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					return result;
				case 2:
					return result;
				case 3:
					this.a.extractCurrentFileToFile(A_1);
					num2 = (short)2116419585;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			return result;
			IL_20:
			result = true;
			string empty = string.Empty;
			string empty2 = string.Empty;
			num2 = (short)1817159613;
			short num4 = num2;
			num2 = (short)1264756669;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			default:
			{
				num2 = (short)1885274112;
				if (num2 != 0)
				{
				}
				num2 = (short)88014848;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000B5BC File Offset: 0x000097BC
		private bool a(string componentName)
		{
			bool result;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				short num;
				int num3;
				for (;;)
				{
					IL_0A:
					num = (short)878772224;
					short num2 = num;
					switch (num3)
					{
					case 0:
					{
						if (this.d(componentName) <= 0)
						{
							return result;
						}
						num = (short)1572648940;
						short num4 = num;
						num = (short)430225388;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1542914049;
							if (num != 0)
							{
							}
							num = (short)2101018624;
							if (num != 0)
							{
							}
							num = (short)133365762;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						return result;
					case 2:
						result = true;
						num = (short)1704787969;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				IL_44:
				result = false;
				string empty = string.Empty;
				string empty2 = string.Empty;
				num = (short)772931584;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
			return result;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x0000B6E8 File Offset: 0x000098E8
		internal bool g(string modelNumber)
		{
			int a_ = 5;
			short num = (short)1648427008;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1367736320;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_8F;
				}
				global::System.IO.FileStream fileStream;
				byte[] array;
				string text;
				bool result;
				for (;;)
				{
					IL_58:
					switch (num2)
					{
					case 0:
						goto IL_27D;
					case 1:
					{
						try
						{
							long offset = 24L;
							fileStream.Seek(offset, global::System.IO.SeekOrigin.Begin);
							fileStream.Read(array, 0, 64);
							goto IL_303;
						}
						finally
						{
							num = (short)2063335424;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1D7;
								case 1:
									goto IL_27A;
								case 2:
								{
									((global::System.IDisposable)fileStream).Dispose();
									num = (short)145078899;
									short num4 = num;
									num = (short)2054863475;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_1D7;
									default:
										num = (short)1288699904;
										if (num != 0)
										{
										}
										num = (short)1494089729;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								goto IL_1F4;
								IL_1D7:
								switch (0)
								{
								case 0:
									IL_1F4:
									if (fileStream == null)
									{
										goto IL_27C;
									}
									num = (short)509739010;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_27A:
							IL_27C:;
						}
						goto IL_27D;
						IL_303:
						char[] trimChars = new char[]
						{
							'\0',
							' ',
							'\r',
							'\n'
						};
						text = global::System.Text.Encoding.UTF8.GetString(array, 0, array.Length).TrimEnd(trimChars);
						num = (short)1838612490;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (modelNumber[0] == 'L')
						{
							num = (short)1569128454;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 3:
						if (text == global::Motorola.Common.Communication.Crc32.c("跨苪黬賮껰黲髴闶", a_))
						{
							num = (short)243007499;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 4:
						if (modelNumber[0] != 'M')
						{
							num = (short)295174144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_182;
					case 5:
						if (modelNumber[0] != 'H')
						{
							num = (short)1981939719;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_182;
					case 6:
						goto IL_182;
					case 7:
						goto IL_133;
					case 8:
						num = (short)748355589;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						return result;
					case 10:
						if (text == global::Motorola.Common.Communication.Crc32.c("跨苪黬賮껰菲髴藶", a_))
						{
							num = (short)1976434696;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_133;
					case 11:
						num = (short)397869060;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8F;
					IL_133:
					num = (short)1760428035;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_182:
					result = true;
					num = (short)228196361;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_27D:
					num = (short)1169293314;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_8F:
				num = (short)1898905601;
				if (num != 0)
				{
				}
				result = false;
				array = new byte[64];
				text = string.Empty;
				fileStream = global::System.IO.File.OpenRead(this.b);
				num = (short)637009921;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_58;
			}
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x0000BA80 File Offset: 0x00009C80
		public string e()
		{
			short num = (short)1099759616;
			short num2 = num;
			num = (short)1509818368;
			switch (num)
			{
			default:
			{
				num = (short)1225785345;
				if (num != 0)
				{
				}
				string empty = string.Empty;
				byte[] array = new byte[16];
				global::System.IO.FileStream fileStream = global::System.IO.File.OpenRead(this.b);
				try
				{
					long offset = 88L;
					fileStream.Seek(offset, global::System.IO.SeekOrigin.Begin);
					fileStream.Read(array, 0, 16);
				}
				finally
				{
					num = (short)845545472;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_BB;
						case 1:
							goto IL_161;
						case 2:
						{
							((global::System.IDisposable)fileStream).Dispose();
							num = (short)1199013065;
							short num4 = num;
							num = (short)1001749705;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_BB;
							default:
								num = (short)1653342208;
								if (num != 0)
								{
								}
								num = (short)1580531713;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						goto IL_D8;
						IL_BB:
						switch (0)
						{
						case 0:
							IL_D8:
							if (fileStream == null)
							{
								goto IL_163;
							}
							num = (short)1598423042;
							num3 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_161:
					IL_163:;
				}
				char[] trimChars = new char[]
				{
					'\0',
					' ',
					'\r',
					'\n'
				};
				return global::System.Text.Encoding.UTF8.GetString(array, 0, array.Length).TrimEnd(trimChars);
			}
			}
		}

		// Token: 0x0600005F RID: 95 RVA: 0x0000BC28 File Offset: 0x00009E28
		public bool f()
		{
			int a_ = 3;
			short num = (short)1620443137;
			if (num != 0)
			{
			}
			num = (short)673644544;
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
				global::System.IO.FileStream fileStream;
				byte[] array;
				string text;
				bool result;
				for (;;)
				{
					IL_57:
					switch (num2)
					{
					case 0:
						try
						{
							fileStream.Read(array, 0, 8);
							goto IL_CA;
						}
						finally
						{
							num = (short)289865728;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_149;
								case 1:
									goto IL_1EE;
								case 2:
								{
									((global::System.IDisposable)fileStream).Dispose();
									num = (short)809101011;
									short num3 = num;
									num = (short)766699219;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_149;
									default:
										num = (short)435748864;
										if (num != 0)
										{
										}
										num = (short)505020417;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								goto IL_166;
								IL_149:
								switch (0)
								{
								case 0:
									IL_166:
									if (fileStream == null)
									{
										goto IL_1F0;
									}
									num = (short)415629314;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_1EE:
							IL_1F0:;
						}
						goto IL_1F1;
						IL_CA:
						text = global::System.Text.Encoding.UTF8.GetString(array, 0, array.Length);
						num = (short)1873477635;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return result;
					case 2:
						goto IL_1F1;
					case 3:
						if (global::Motorola.Common.Communication.Crc32.c("꟦ꯨꧪ꯬蟮闰臲뗴", a_) == text)
						{
							num = (short)1170800642;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					goto IL_6E;
					IL_1F1:
					result = true;
					num = (short)541655041;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_6E:
				num = (short)1261305856;
				short num4 = num;
				result = false;
				array = new byte[8];
				text = string.Empty;
				fileStream = global::System.IO.File.OpenRead(this.b);
				num = (short)123994112;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_57;
			}
			}
		}

		// Token: 0x06000060 RID: 96 RVA: 0x0000BE54 File Offset: 0x0000A054
		public bool g()
		{
			short num = (short)1176829952;
			short num2 = num;
			num = (short)892010496;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				num = (short)1675624449;
				if (num != 0)
				{
				}
				bool result = false;
				byte[] array = new byte[4];
				byte[] array2 = new byte[4];
				global::System.IO.FileStream fileStream = global::System.IO.File.OpenRead(this.b);
				try
				{
					byte[] buffer = new byte[fileStream.Length - 4L];
					long offset = fileStream.Length - 4L;
					fileStream.Read(buffer, 0, (int)fileStream.Length - 4);
					fileStream.Seek(offset, global::System.IO.SeekOrigin.Begin);
					fileStream.Read(array, 0, 4);
					global::Motorola.Common.Communication.Crc32 crc = new global::Motorola.Common.Communication.Crc32();
					try
					{
						switch (0)
						{
						case 0:
							goto IL_FB;
						}
						int num4;
						byte[] array3;
						int num5;
						for (;;)
						{
							IL_E0:
							switch (num3)
							{
							case 0:
							{
								if (num4 >= array3.Length)
								{
									num = (short)1758134275;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								byte b = array3[num4];
								array2[num5] = b;
								num5++;
								num4++;
								num = (short)146866180;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								goto IL_1A5;
							case 2:
								goto IL_1FA;
							case 3:
								num = (short)1731854338;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_1A5;
							}
							goto IL_FB;
							IL_1A5:
							num = (short)2088042496;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_1FA:
						goto IL_26A;
						IL_FB:
						num5 = 0;
						array3 = crc.ComputeHash(buffer);
						num4 = 0;
						num = (short)1290060992;
						short num6 = num;
						num = (short)329041088;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_E0;
						default:
							num = (short)1745747968;
							if (num != 0)
							{
							}
							num = (short)2116288513;
							num3 = (int)((global::System.IntPtr)num);
							goto IL_E0;
						}
					}
					finally
					{
						num = (short)166133760;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_22E;
								}
								continue;
							case 1:
								goto IL_267;
							case 2:
								((global::System.IDisposable)crc).Dispose();
								num = (short)95027201;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_22E:
							if (crc == null)
							{
								break;
							}
							num = (short)913506306;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_267:;
					}
					IL_26A:
					result = array.SequenceEqual(array2);
				}
				finally
				{
					num = (short)501284864;
					num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_2A7;
							}
							continue;
						case 1:
							goto IL_2DD;
						case 2:
							((global::System.IDisposable)fileStream).Dispose();
							num = (short)350945281;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_2A7:
						if (fileStream == null)
						{
							break;
						}
						num = (short)1330315266;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_2DD:;
				}
				return result;
			}
			}
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000C178 File Offset: 0x0000A378
		public byte[] h()
		{
			short num = (short)1300584446;
			short num2 = num;
			num = (short)1232558078;
			switch (num2 == num)
			{
			}
			num = (short)1326252032;
			short num3 = num;
			num = (short)732037121;
			if (num != 0)
			{
			}
			num = (short)275316736;
			if (num != 0)
			{
			}
			return global::System.IO.File.ReadAllBytes(this.b);
		}

		// Token: 0x04000027 RID: 39
		private global::Encaten.IEncateWrapper a;

		// Token: 0x04000028 RID: 40
		private string b;

		// Token: 0x04000029 RID: 41
		private const string c = "1B7097E8-D9E3-11d5-A3BE-0060B0FB015A";

		// Token: 0x0400002A RID: 42
		private bool d;

		// Token: 0x0400002B RID: 43
		private string e = string.Empty;

		// Token: 0x0400002C RID: 44
		private const string f = "fileItem";

		// Token: 0x0400002D RID: 45
		private const string g = "fileName";

		// Token: 0x0400002E RID: 46
		private const string h = "filePackageDestinationInfo";

		// Token: 0x0400002F RID: 47
		private const string i = "fileVersion";

		// Token: 0x04000030 RID: 48
		private const string j = "fileData";

		// Token: 0x04000031 RID: 49
		private const string k = "@BBFhdr@";

		// Token: 0x04000032 RID: 50
		private const string l = "disc_por";

		// Token: 0x04000033 RID: 51
		private const string m = "disc_mob";
	}
}
