using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using Encaten;

namespace Motorola.Common.Communication
{
	// Token: 0x02000012 RID: 18
	internal sealed class w
	{
		// Token: 0x060000AD RID: 173 RVA: 0x00016CEC File Offset: 0x00014EEC
		private string b()
		{
			short num = (short)603324417;
			if (num != 0)
			{
			}
			num = (short)1399159201;
			short num2 = num;
			num = (short)2065136033;
			switch (num2 == num)
			{
			}
			num = (short)1910833152;
			short num3 = num;
			num = (short)1011810304;
			if (num != 0)
			{
			}
			return this.b;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00016DA0 File Offset: 0x00014FA0
		private void c(string value)
		{
			short num = (short)157467986;
			short num2 = num;
			num = (short)1072088402;
			switch (num2 == num)
			{
			}
			num = (short)504102913;
			if (num != 0)
			{
			}
			num = (short)624361472;
			short num3 = num;
			num = (short)1144324096;
			if (num != 0)
			{
			}
			this.b = value;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00016E58 File Offset: 0x00015058
		private w()
		{
			this.b = string.Empty;
			this.a = null;
			this.d = false;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00016E90 File Offset: 0x00015090
		public w(string path)
		{
			this.b = path;
			this.a = global::Encaten.EncatenWrapperFactory.CreateEncatenWrapper();
			this.d = false;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00016EC8 File Offset: 0x000150C8
		public bool c()
		{
			int a_ = 13;
			switch (0)
			{
			case 0:
				goto IL_67;
			}
			short num;
			int num2;
			bool flag;
			for (;;)
			{
				IL_13:
				num = (short)1953759233;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					if (this.a.openAndGetFilePackage(this.b, global::Motorola.Common.Communication.Crc32.c("馧鮫麭覯薱躵閷ﺹ薻﮽곇￉迍郑釓ﯕꋟ틡ꋣꓥ\ud8e7\udbe9\ud9eb꿭", a_), out this.e) >= 0)
					{
						num = (short)1254031363;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_AB;
				case 1:
					return flag;
				case 2:
					if (flag)
					{
						num = (short)1827274759;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return flag;
				case 3:
				{
					this.a.getFilePackageEncryptionStatus(out flag);
					num = (short)202833920;
					short num3 = num;
					num = (short)1132593161;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					num = (short)384499720;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					return true;
				case 6:
					goto IL_7E;
				case 7:
				{
					this.d = true;
					num = (short)627422190;
					short num4 = num;
					num = (short)641119214;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7E;
					default:
						num = (short)1082851328;
						if (num != 0)
						{
						}
						num = (short)1467678721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 8:
					if (this.d)
					{
						num = (short)547422213;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)471662592;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_AB;
				}
				goto IL_67;
				IL_7E:
				if (global::System.IO.File.Exists(this.b))
				{
					num = (short)1832452100;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return flag;
				IL_AB:
				num = (short)577503234;
				num2 = (int)((global::System.IntPtr)num);
			}
			return true;
			IL_67:
			flag = false;
			num = (short)1993211910;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00017114 File Offset: 0x00015314
		private bool a()
		{
			int a_ = 12;
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
					if (this.d(componentName) < 1)
					{
						num2 = (short)199032832;
						short num3 = num2;
						num2 = (short)2138701837;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_AD;
				case 1:
					if (this.d(componentName) < 1)
					{
						num2 = (short)1369767945;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_AD;
				case 2:
					return false;
				case 3:
					goto IL_209;
				case 4:
					if (this.d(componentName) < 1)
					{
						num2 = (short)627834888;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 5:
					if (this.d(componentName) < 1)
					{
						num2 = (short)1267925002;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_125;
				case 6:
					if (this.d(componentName) < 1)
					{
						num2 = (short)1605369867;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 7:
					if (this.d(componentName) < 1)
					{
						num2 = (short)699465731;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					componentName = global::Motorola.Common.Communication.Crc32.c("ﲪ", a_);
					num2 = (short)1651310592;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					componentName = global::Motorola.Common.Communication.Crc32.c("ﲪ", a_);
					num2 = (short)1640562700;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					return false;
				case 10:
				{
					componentName = global::Motorola.Common.Communication.Crc32.c("ﾪ", a_);
					num2 = (short)987455325;
					short num4 = num2;
					num2 = (short)1008033629;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_125;
					default:
						num2 = (short)549781504;
						if (num2 != 0)
						{
						}
						num2 = (short)146735111;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 11:
					return false;
				case 12:
					if (this.d(componentName) < 1)
					{
						num2 = (short)1896284162;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 13:
					componentName = global::Motorola.Common.Communication.Crc32.c("ﲪ", a_);
					num2 = (short)599457793;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_51;
				IL_AD:
				componentName = global::Motorola.Common.Communication.Crc32.c("ﲪ", a_);
				num2 = (short)283312132;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_125:
				componentName = global::Motorola.Common.Communication.Crc32.c("ﲪ", a_);
				num2 = (short)681115654;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_209:
			num2 = (short)258080769;
			if (num2 != 0)
			{
			}
			return false;
			IL_51:
			string empty = string.Empty;
			string empty2 = string.Empty;
			componentName = global::Motorola.Common.Communication.Crc32.c("ﲪﺬ", a_);
			num2 = (short)1185742853;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0001744C File Offset: 0x0001564C
		internal int d(string ComponentName)
		{
			int a_ = 18;
			short num = (short)1090650112;
			short num2 = num;
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
						goto IL_E2;
					}
					int num5;
					for (;;)
					{
						IL_54:
						num = (short)1291096712;
						short num4 = num;
						num = (short)2094240392;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)160825344;
							if (num != 0)
							{
							}
							switch (num5)
							{
							case 0:
								goto IL_1B4;
							case 1:
								num3++;
								num = (short)1669791753;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								if (xmlReader.Name == global::Motorola.Common.Communication.Crc32.c("쮬욮\uddb0횲ﲴ쎶\udcb8횺", a_))
								{
									num = (short)927858695;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1F7;
							case 3:
								if (!xmlReader.Read())
								{
									num = (short)1293352973;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1159593986;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								num = (short)785317898;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								num = (short)1097531400;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								goto IL_1F7;
							case 7:
								num = (short)1122500619;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								if (xmlReader.HasValue)
								{
									num = (short)267583488;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1F7;
							case 9:
								goto IL_1F7;
							case 10:
								if (xmlReader.MoveToAttribute(global::Motorola.Common.Communication.Crc32.c("쮬욮\uddb0횲﮴횶풸\udeba", a_)))
								{
									num = (short)1751711749;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1F7;
							case 11:
								if (xmlReader.MoveToFirstAttribute())
								{
									num = (short)1405550596;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1F7;
							case 12:
								if (xmlReader.Value == ComponentName)
								{
									num = (short)847314945;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1F7;
							case 13:
								num = (short)264699918;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							case 14:
								goto IL_2D8;
							}
							goto IL_E2;
							IL_1F7:
							num = (short)1970208771;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1B4:
						num = (short)1094123532;
						num5 = (int)((global::System.IntPtr)num);
					}
					IL_2D8:
					return num3;
					IL_E2:
					xmlReader.MoveToContent();
					num = (short)973537286;
					num5 = (int)((global::System.IntPtr)num);
					goto IL_54;
				}
				finally
				{
					num = (short)1489633280;
					int num5 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num5)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_30D;
							}
							continue;
						case 1:
							((global::System.IDisposable)xmlReader).Dispose();
							num = (short)1728053250;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_341;
						}
						IL_30D:
						if (xmlReader == null)
						{
							break;
						}
						num = (short)72548353;
						num5 = (int)((global::System.IntPtr)num);
					}
					IL_341:;
				}
			}
			finally
			{
				num = (short)1326055424;
				int num5 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num5)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_374;
						}
						continue;
					case 1:
						num = (short)893452289;
						if (num != 0)
						{
						}
						((global::System.IDisposable)stringReader).Dispose();
						num = (short)304545794;
						num5 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_3D0;
					}
					IL_374:
					if (stringReader == null)
					{
						break;
					}
					num = (short)1082327041;
					num5 = (int)((global::System.IntPtr)num);
				}
				IL_3D0:;
			}
			return num3;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00017864 File Offset: 0x00015A64
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
					num2 = (short)36569088;
					short num3 = num2;
					string text;
					if (modelNumber.Trim()[0] == text[0])
					{
						num2 = (short)1830879233;
						if (num2 != 0)
						{
						}
						num2 = (short)1296760836;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 1:
				{
					string text;
					if (string.IsNullOrEmpty(text))
					{
						num2 = (short)250347522;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 2:
				{
					string text = text.Trim();
					num2 = (short)1912799232;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					goto IL_CE;
				case 4:
					goto IL_16F;
				}
				goto IL_24;
			}
			IL_CE:
			return result;
			IL_16F:
			result = true;
			goto IL_B5;
			IL_24:
			num2 = (short)581804271;
			short num4 = num2;
			num2 = (short)2016387311;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_B5:
				num2 = (short)285802499;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1607925760;
				if (num2 != 0)
				{
				}
				result = false;
				string text = this.d();
				num2 = (short)918945793;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000179E8 File Offset: 0x00015BE8
		internal string d()
		{
			int a_ = 9;
			short num = (short)743833600;
			short num2 = num;
			num = (short)1511522305;
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
					num = (short)1150943239;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							result = xmlReader.Value;
							num = (short)255066114;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (xmlReader.MoveToAttribute(global::Motorola.Common.Communication.Crc32.c("슣쾥쒧쾩ﲫ쾭펯\ud9b1햳통\uddb7ﺹ\ud9bb춽뒿ꯁ꫃Ʂ볇ꏉꏋꃍ駏병닓맕", a_)))
							{
								num = (short)1924005893;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 2:
							goto IL_1F8;
						case 3:
							if (xmlReader.MoveToFirstAttribute())
							{
								num = (short)1233256457;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 4:
							if (!xmlReader.Read())
							{
								num = (short)1212547080;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)696516611;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_15D;
						case 6:
							if (xmlReader.HasValue)
							{
								num = (short)849215488;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 7:
							switch (0)
							{
							case 0:
								goto IL_C8;
							}
							continue;
						case 8:
							num = (short)581959690;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
						{
							num = (short)1827572581;
							short num4 = num;
							num = (short)23628645;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_15D;
							default:
								num = (short)1110179840;
								if (num != 0)
								{
								}
								num = (short)440926209;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 10:
							goto IL_252;
						}
						goto IL_C8;
						IL_15D:
						num = (short)1390280710;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_162:
						num = (short)421068804;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_C8:
						goto IL_162;
					}
					IL_1F8:
					IL_252:;
				}
				finally
				{
					num = (short)899153920;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_287;
							}
							continue;
						case 1:
							((global::System.IDisposable)xmlReader).Dispose();
							num = (short)1204617218;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_2BA;
						}
						IL_287:
						if (xmlReader == null)
						{
							break;
						}
						num = (short)954466305;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_2BA:;
				}
			}
			finally
			{
				num = (short)1520041984;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_2EE;
						}
						continue;
					case 1:
						((global::System.IDisposable)stringReader).Dispose();
						num = (short)1902706690;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_324;
					}
					IL_2EE:
					if (stringReader == null)
					{
						break;
					}
					num = (short)1174405121;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_324:;
			}
			return result;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00017D54 File Offset: 0x00015F54
		private string a(string A_0, bool A_1 = true)
		{
			int a_ = 1;
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
					if (!string.IsNullOrEmpty(text))
					{
						num2 = (short)444399622;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return text;
				case 1:
					if (A_1)
					{
						num2 = (short)385613829;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return text;
				case 2:
					text = this.e(A_0);
					num2 = (short)364904448;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (this.d(A_0) > 0)
					{
						num2 = (short)1290665986;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return text;
				case 4:
					goto IL_154;
				case 5:
					goto IL_1B2;
				case 6:
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
					num2 = (short)1396047873;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_35;
			}
			IL_154:
			return text;
			IL_1B2:
			goto IL_123;
			IL_35:
			num2 = (short)1570635777;
			if (num2 != 0)
			{
			}
			num2 = (short)731814383;
			short num3 = num2;
			num2 = (short)2079234543;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_123:
				text = text.Replace(global::Motorola.Common.Communication.Crc32.c("늛", a_), "");
				num2 = (short)182910980;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			case 1:
				break;
			default:
			{
				num2 = (short)509476864;
				short num4 = num2;
				break;
			}
			}
			num2 = (short)1972305920;
			if (num2 != 0)
			{
			}
			text = string.Empty;
			string empty = string.Empty;
			num2 = (short)532873219;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00017F60 File Offset: 0x00016160
		internal string e(string ComponentName)
		{
			int a_ = 9;
			short num;
			string result;
			for (;;)
			{
				num = (short)1764163584;
				short num2 = num;
				result = string.Empty;
				global::System.IO.StringReader stringReader = new global::System.IO.StringReader(this.e);
				try
				{
					global::System.Xml.XmlReader xmlReader = global::System.Xml.XmlReader.Create(stringReader);
					try
					{
						switch (0)
						{
						case 0:
							goto IL_AC;
						}
						int num3;
						for (;;)
						{
							IL_5A:
							switch (num3)
							{
							case 0:
								if (xmlReader.HasValue)
								{
									num = (short)847380486;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1BA;
							case 1:
								num = (short)1403781124;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								num = (short)727908366;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								if (xmlReader.Value == ComponentName)
								{
									num = (short)1596784656;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1BA;
							case 4:
								if (xmlReader.MoveToFirstAttribute())
								{
									num = (short)722599938;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1BA;
							case 5:
								result = xmlReader.Value;
								num = (short)2069561352;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								num = (short)679018499;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
								num = (short)519176209;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								goto IL_12A;
							case 9:
								num = (short)1019936768;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 10:
								goto IL_1BA;
							case 11:
								num = (short)1460404242;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 12:
								if (xmlReader.MoveToAttribute(global::Motorola.Common.Communication.Crc32.c("슣쾥쒧쾩磌쮭슯솱\uddb3\ud9b5횷", a_)))
								{
									num = (short)181927947;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1BA;
							case 13:
								if (xmlReader.Name == global::Motorola.Common.Communication.Crc32.c("슣쾥쒧쾩\udaad햯\udfb1", a_))
								{
									num = (short)256114689;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1BA;
							case 14:
								if (xmlReader.MoveToAttribute(global::Motorola.Common.Communication.Crc32.c("슣쾥쒧쾩쾭\uddafힱ", a_)))
								{
									num = (short)1679163401;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1BA;
							case 15:
								if (!xmlReader.Read())
								{
									num = (short)1226047495;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)594214925;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 16:
								num = (short)1864564748;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 17:
								goto IL_325;
							case 18:
								if (xmlReader.HasValue)
								{
									num = (short)804388869;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1BA;
							}
							goto IL_AC;
							IL_1BA:
							num = (short)1003814927;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_12A:
						IL_325:
						goto IL_3FC;
						IL_AC:
						xmlReader.MoveToContent();
						num = (short)1002504202;
						num3 = (int)((global::System.IntPtr)num);
						goto IL_5A;
					}
					finally
					{
						num = (short)2133655553;
						int num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_38F;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_35B;
								}
								continue;
							case 2:
								((global::System.IDisposable)xmlReader).Dispose();
								num = (short)650248192;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_35B:
							if (xmlReader == null)
							{
								break;
							}
							num = (short)1004535810;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_38F:;
					}
				}
				finally
				{
					num = (short)1262747649;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_3F9;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_3C3;
							}
							continue;
						case 2:
							((global::System.IDisposable)stringReader).Dispose();
							num = (short)782368768;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_3C3:
						if (stringReader == null)
						{
							break;
						}
						num = (short)404750338;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_3F9:;
				}
				IL_3FC:
				num = (short)686918512;
				short num4 = num;
				num = (short)1268091760;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_430;
				}
			}
			IL_430:
			num = (short)1700921345;
			if (num != 0)
			{
			}
			num = (short)312541184;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00018410 File Offset: 0x00016610
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
					return;
				case 1:
					if (this.d(A_0) > 0)
					{
						num2 = (short)261160962;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 2:
				{
					num2 = (short)650332580;
					short num3 = num2;
					num2 = (short)1903249828;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num2 = (short)2086207489;
						if (num2 != 0)
						{
						}
						num2 = (short)1927741440;
						if (num2 != 0)
						{
						}
						num2 = (short)1025572864;
						short num4 = num2;
						A_1 = this.f(A_0);
						num2 = (short)1334968320;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			A_1 = string.Empty;
			string empty = string.Empty;
			string empty2 = string.Empty;
			num2 = (short)1233780737;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00018540 File Offset: 0x00016740
		internal string f(string ComponentName)
		{
			int a_ = 12;
			short num;
			string result;
			for (;;)
			{
				num = (short)846921728;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)1324679168;
					short num3 = num;
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
								goto IL_DA;
							}
							for (;;)
							{
								IL_83:
								switch (num2)
								{
								case 0:
									num = (short)1807024138;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (xmlReader.MoveToAttribute(global::Motorola.Common.Communication.Crc32.c("솦삨잪좬킰\udeb2킴", a_)))
									{
										num = (short)1312227333;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_21A;
								case 2:
									goto IL_21A;
								case 3:
									goto IL_39C;
								case 4:
									if (xmlReader.HasValue)
									{
										num = (short)1368457223;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_21A;
								case 5:
									num = (short)520552452;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_14B;
								case 7:
									num = (short)1024327697;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									num = (short)980877315;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									if (!xmlReader.Read())
									{
										num = (short)1837301774;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)993722386;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									if (xmlReader.MoveToFirstAttribute())
									{
										num = (short)867958803;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_21A;
								case 11:
									goto IL_21A;
								case 12:
									if (!xmlReader.Read())
									{
										num = (short)2078801928;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1586626573;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									if (xmlReader.Name == global::Motorola.Common.Communication.Crc32.c("솦삨잪좬얰횲\ud8b4", a_))
									{
										num = (short)1605632000;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_21A;
								case 14:
									goto IL_21A;
								case 15:
									num = (short)368836614;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									result = (global::System.Xml.Linq.XNode.ReadFrom(xmlReader) as global::System.Xml.Linq.XElement).Value.Trim();
									num = (short)466812930;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
									if (xmlReader.Value == ComponentName)
									{
										num = (short)1939537935;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_21A;
								case 18:
									if (xmlReader.Name == global::Motorola.Common.Communication.Crc32.c("솦삨잪좬킰잲풴", a_))
									{
										num = (short)1343225872;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_14B;
								case 19:
									num = (short)1538326529;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_DA;
								IL_14B:
								num = (short)1853227017;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_21A:
								num = (short)684392460;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_39C:
							goto IL_478;
							IL_DA:
							xmlReader.MoveToContent();
							num = (short)938868747;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_83;
						}
						finally
						{
							num = (short)2076770305;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_409;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_3D3;
									}
									continue;
								case 2:
									((global::System.IDisposable)xmlReader).Dispose();
									num = (short)709230592;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3D3:
								if (xmlReader == null)
								{
									break;
								}
								num = (short)699793410;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_409:;
						}
					}
					finally
					{
						num = (short)1498808321;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_475;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_43E;
								}
								continue;
							case 2:
								((global::System.IDisposable)stringReader).Dispose();
								num = (short)841351168;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_43E:
							if (stringReader == null)
							{
								break;
							}
							num = (short)2026438658;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_475:;
					}
					IL_478:
					num = (short)903839085;
					short num4 = num;
					num = (short)2080996717;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_4AC;
					}
					break;
				}
				}
			}
			IL_4AC:
			num = (short)583991296;
			if (num != 0)
			{
			}
			num = (short)435290113;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00018A6C File Offset: 0x00016C6C
		private bool a(string A_0, string A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (this.d(A_0) > 0)
					{
						num2 = (short)1131282435;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					result = false;
					num2 = (short)1423966209;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return result;
				case 2:
					return result;
				case 3:
				{
					for (;;)
					{
						num2 = (short)305137152;
						short num3 = num2;
						num2 = (short)1726612992;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_B6;
						}
					}
					IL_B6:
					num2 = (short)1691484160;
					if (num2 != 0)
					{
					}
					num2 = (short)228458497;
					if (num2 != 0)
					{
					}
					this.a.extractCurrentFileToFile(A_1);
					num2 = (short)2039218176;
					short num4 = num2;
					num2 = (short)404160514;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_20;
			}
			return result;
			IL_20:
			result = true;
			string empty = string.Empty;
			string empty2 = string.Empty;
			num2 = (short)1335951360;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00018BBC File Offset: 0x00016DBC
		private bool a(string componentName)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			bool result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					if (this.d(componentName) > 0)
					{
						num2 = (short)84475906;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
				{
					num2 = (short)270336001;
					if (num2 != 0)
					{
					}
					num2 = (short)1499056771;
					short num3 = num2;
					num2 = (short)961989251;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return result;
					default:
					{
						num2 = (short)179503104;
						if (num2 != 0)
						{
						}
						num2 = (short)751304704;
						short num4 = num2;
						result = true;
						num2 = (short)1439891456;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_1C;
			}
			return result;
			IL_1C:
			result = false;
			string empty = string.Empty;
			string empty2 = string.Empty;
			num2 = (short)931463169;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00018CE8 File Offset: 0x00016EE8
		internal bool g(string modelNumber)
		{
			int a_ = 17;
			short num = (short)817758208;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_67;
				}
				global::System.IO.FileStream fileStream;
				byte[] array;
				string text;
				bool result;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						goto IL_15D;
					case 1:
						if (modelNumber[0] != 'H')
						{
							num = (short)926941191;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15D;
					case 2:
						if (modelNumber[0] != 'M')
						{
							num = (short)1879965702;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15D;
					case 3:
					{
						try
						{
							long offset = 24L;
							fileStream.Seek(offset, global::System.IO.SeekOrigin.Begin);
							fileStream.Read(array, 0, 64);
							goto IL_30A;
						}
						finally
						{
							for (;;)
							{
								IL_19D:
								num = (short)1133248513;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_257;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_1CF;
										}
										continue;
									case 2:
									{
										((global::System.IDisposable)fileStream).Dispose();
										num = (short)313347146;
										short num3 = num;
										num = (short)1026706506;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_19D;
										default:
											num = (short)1946222592;
											if (num != 0)
											{
											}
											num = (short)1755578368;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									IL_1CF:
									if (fileStream == null)
									{
										goto IL_259;
									}
									num = (short)1122697218;
									num2 = (int)((global::System.IntPtr)num);
								}
							}
							IL_257:
							IL_259:;
						}
						goto IL_25A;
						IL_30A:
						char[] trimChars = new char[]
						{
							'\0',
							' ',
							'\r',
							'\n'
						};
						text = global::System.Text.Encoding.UTF8.GetString(array, 0, array.Length).TrimEnd(trimChars);
						num = (short)1889665032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (text == global::Motorola.Common.Communication.Crc32.c("좫잭쎯톱\udbb5ힷ\ud8b9", a_))
						{
							num = (short)1743912971;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 5:
						return result;
					case 6:
						goto IL_25A;
					case 7:
						num = (short)242941953;
						if (num != 0)
						{
						}
						goto IL_E3;
					case 8:
						if (text == global::Motorola.Common.Communication.Crc32.c("좫잭쎯톱욵ힷ좹", a_))
						{
							num = (short)830996490;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E3;
					case 9:
						if (modelNumber[0] == 'L')
						{
							num = (short)962134016;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 10:
						num = (short)1454702593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						num = (short)880017408;
						short num4 = num;
						num = (short)1143603202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_67;
					IL_E3:
					num = (short)2135293956;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15D:
					result = true;
					num = (short)425328645;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_25A:
					num = (short)1852637193;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_67:
				result = false;
				array = new byte[64];
				text = string.Empty;
				fileStream = global::System.IO.File.OpenRead(this.b);
				num = (short)1434583043;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00019088 File Offset: 0x00017288
		public string e()
		{
			short num = (short)855506944;
			switch (num)
			{
			default:
			{
				string empty = string.Empty;
				byte[] array = new byte[16];
				global::System.IO.FileStream fileStream = global::System.IO.File.OpenRead(this.b);
				try
				{
					num = (short)730726401;
					if (num != 0)
					{
					}
					long offset = 88L;
					fileStream.Seek(offset, global::System.IO.SeekOrigin.Begin);
					fileStream.Read(array, 0, 16);
				}
				finally
				{
					for (;;)
					{
						IL_7F:
						num = (short)739246081;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_137;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_B1;
								}
								continue;
							case 2:
							{
								((global::System.IDisposable)fileStream).Dispose();
								num = (short)1635694251;
								short num3 = num;
								num = (short)2121250475;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_7F;
								default:
									num = (short)66584576;
									if (num != 0)
									{
									}
									num = (short)1433206784;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_B1:
							if (fileStream == null)
							{
								goto IL_139;
							}
							num = (short)1012137986;
							num2 = (int)((global::System.IntPtr)num);
						}
					}
					IL_137:
					IL_139:;
				}
				num = (short)2067791872;
				short num4 = num;
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

		// Token: 0x060000BE RID: 190 RVA: 0x00019230 File Offset: 0x00017430
		public bool f()
		{
			int a_ = 6;
			short num = (short)1226113024;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)118882304;
				short num3 = num;
				num = (short)822673409;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_9B;
				}
				global::System.IO.FileStream fileStream;
				byte[] array;
				string text;
				bool result;
				for (;;)
				{
					IL_84:
					switch (num2)
					{
					case 0:
						try
						{
							fileStream.Read(array, 0, 8);
							goto IL_CD;
						}
						finally
						{
							for (;;)
							{
								IL_134:
								num = (short)1617625089;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_1EC;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_166;
										}
										continue;
									case 2:
									{
										((global::System.IDisposable)fileStream).Dispose();
										num = (short)1486701781;
										short num4 = num;
										num = (short)201802965;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_134;
										default:
											num = (short)1215692800;
											if (num != 0)
											{
											}
											num = (short)783417344;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									IL_166:
									if (fileStream == null)
									{
										goto IL_1EE;
									}
									num = (short)578813954;
									num2 = (int)((global::System.IntPtr)num);
								}
							}
							IL_1EC:
							IL_1EE:;
						}
						goto IL_1EF;
						IL_CD:
						text = global::System.Text.Encoding.UTF8.GetString(array, 0, array.Length);
						num = (short)1796800515;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1EF;
					case 2:
						return result;
					case 3:
						if (global::Motorola.Common.Communication.Crc32.c("솨쾪\udfac", a_) == text)
						{
							num = (short)856358913;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					goto IL_9B;
					IL_1EF:
					result = true;
					num = (short)192675842;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_9B:
				result = false;
				array = new byte[8];
				text = string.Empty;
				fileStream = global::System.IO.File.OpenRead(this.b);
				num = (short)1764229120;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_84;
			}
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0001945C File Offset: 0x0001765C
		public bool g()
		{
			short num = (short)1311113216;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)211353600;
				short num3 = num;
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
							goto IL_D6;
						}
						int num4;
						byte[] array3;
						int num5;
						for (;;)
						{
							IL_BB:
							switch (num2)
							{
							case 0:
								goto IL_182;
							case 1:
								goto IL_12F;
							case 2:
							{
								if (num4 >= array3.Length)
								{
									num = (short)1569849348;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								byte b = array3[num4];
								array2[num5] = b;
								num5++;
								num4++;
								num = (short)1658257409;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								goto IL_12F;
							case 4:
								num = (short)1585512448;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_D6;
							IL_12F:
							num = (short)1648164866;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_182:
						goto IL_1F2;
						IL_D6:
						num5 = 0;
						array3 = crc.ComputeHash(buffer);
						num4 = 0;
						num = (short)1517289475;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_BB;
					}
					finally
					{
						num = (short)110493697;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								((global::System.IDisposable)crc).Dispose();
								num = (short)856358914;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_1B7;
								}
								continue;
							case 2:
								goto IL_1EF;
							}
							IL_1B7:
							if (crc == null)
							{
								break;
							}
							num = (short)116457472;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1EF:;
					}
					IL_1F2:
					result = array.SequenceEqual(array2);
				}
				finally
				{
					num = (short)1774911489;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						IL_21E:
						switch (num2)
						{
						case 0:
							((global::System.IDisposable)fileStream).Dispose();
							num = (short)511115266;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_231;
							}
							continue;
						case 2:
							goto IL_2DE;
						}
						IL_231:
						while (fileStream != null)
						{
							num = (short)774310869;
							short num6 = num;
							num = (short)1323633621;
							switch ((num6 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)984940545;
								if (num != 0)
								{
								}
								num = (short)134742016;
								if (num != 0)
								{
								}
								num = (short)1523843072;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_21E;
							}
						}
						break;
					}
					IL_2DE:;
				}
				return result;
			}
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00019780 File Offset: 0x00017980
		public byte[] h()
		{
			short num = (short)1453611682;
			short num2 = num;
			num = (short)1471896226;
			switch (num2 == num)
			{
			}
			num = (short)1765998593;
			if (num != 0)
			{
			}
			num = (short)1002700800;
			if (num != 0)
			{
			}
			num = (short)1725497344;
			short num3 = num;
			return global::System.IO.File.ReadAllBytes(this.b);
		}

		// Token: 0x0400006E RID: 110
		private global::Encaten.IEncateWrapper a;

		// Token: 0x0400006F RID: 111
		private string b;

		// Token: 0x04000070 RID: 112
		private const string c = "1B7097E8-D9E3-11d5-A3BE-0060B0FB015A";

		// Token: 0x04000071 RID: 113
		private bool d;

		// Token: 0x04000072 RID: 114
		private string e = string.Empty;

		// Token: 0x04000073 RID: 115
		private const string f = "fileItem";

		// Token: 0x04000074 RID: 116
		private const string g = "fileName";

		// Token: 0x04000075 RID: 117
		private const string h = "filePackageDestinationInfo";

		// Token: 0x04000076 RID: 118
		private const string i = "fileVersion";

		// Token: 0x04000077 RID: 119
		private const string j = "fileData";

		// Token: 0x04000078 RID: 120
		private const string k = "@BBFhdr@";

		// Token: 0x04000079 RID: 121
		private const string l = "disc_por";

		// Token: 0x0400007A RID: 122
		private const string m = "disc_mob";
	}
}
