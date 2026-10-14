using System;
using System.Collections;
using System.IO;
using System.IO.IsolatedStorage;
using System.Threading;
using System.Xml;
using AcpUI.Common;

namespace AcpUI.Mru
{
	// Token: 0x0200005B RID: 91
	public class MruFiles
	{
		// Token: 0x060004E3 RID: 1251 RVA: 0x0005E47C File Offset: 0x0005C67C
		static MruFiles()
		{
			int a_ = 8;
			short num = (short)751381903;
			short num2 = num;
			num = (short)222768527;
			bool flag;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_148:
				if (flag)
				{
					goto IL_251;
				}
				num = (short)693174276;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)890961920;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8C;
				}
				break;
			}
			string[] fileNames;
			int num5;
			for (;;)
			{
				IL_5E:
				switch (num3)
				{
				case 0:
					goto IL_148;
				case 1:
				{
					num = (short)613220352;
					short num4 = num;
					goto IL_215;
				}
				case 2:
					if (fileNames[num5] == global::AcpUI.Common.Utility.c("\udf9d瑱鎣隥颧骩馭薯花蒳좷즹첽떿볃ꯅ꓇", a_))
					{
						num = (short)1970995208;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_167;
				case 3:
					goto IL_1F4;
				case 4:
					global::AcpUI.Mru.MruFiles.a(global::AcpUI.Mru.MruFiles.e);
					num = (short)1750532099;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)1834680320;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_215;
				case 7:
					if (num5 >= fileNames.Length)
					{
						num = (short)855179269;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1493893122;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					flag = true;
					num = (short)2022309897;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_167;
				}
				goto IL_8C;
				IL_167:
				num5++;
				num = (short)521076742;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_215:
				num = (short)641007623;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_1F4:
			goto IL_251;
			IL_8C:
			num = (short)1616117761;
			if (num != 0)
			{
			}
			global::AcpUI.Mru.MruFiles.d = new global::System.Xml.XmlDocument();
			global::AcpUI.Mru.MruFiles.e = global::System.IO.IsolatedStorage.IsolatedStorageFile.GetStore(global::System.IO.IsolatedStorage.IsolatedStorageScope.User | global::System.IO.IsolatedStorage.IsolatedStorageScope.Assembly, null, null);
			flag = false;
			fileNames = global::AcpUI.Mru.MruFiles.e.GetFileNames(global::AcpUI.Common.Utility.c("\udf9d瑱鎣隥颧骩馭薯花蒳좷즹첽떿볃ꯅ꓇", a_));
			num5 = 0;
			num = (short)437387265;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_5E;
			IL_251:
			global::AcpUI.Mru.MruFiles.a();
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x0005E6E0 File Offset: 0x0005C8E0
		private static void a()
		{
			int a_ = 3;
			short num;
			try
			{
				num = (short)500022814;
				short num2 = num;
				num = (short)954514974;
				switch (num2 == num)
				{
				}
				num = (short)2060648448;
				if (num != 0)
				{
				}
				global::System.IO.IsolatedStorage.IsolatedStorageFileStream isolatedStorageFileStream = new global::System.IO.IsolatedStorage.IsolatedStorageFileStream(global::AcpUI.Common.Utility.c("\ud898쮚얜ꢞ醠鎢閤麨麪鶬龮쎲운襁쮸캺鎼잾곀꿂", a_), global::System.IO.FileMode.Open, global::AcpUI.Mru.MruFiles.e);
				global::System.IO.StreamReader streamReader = new global::System.IO.StreamReader(isolatedStorageFileStream);
				global::AcpUI.Mru.MruFiles.d.Load(streamReader);
				streamReader.Close();
				isolatedStorageFileStream.Close();
				isolatedStorageFileStream.Dispose();
			}
			catch (global::System.IO.IOException)
			{
				global::System.Threading.Thread.Sleep(500);
				global::AcpUI.Mru.MruFiles.a();
			}
			num = (short)1327562752;
			short num3 = num;
			num = (short)517668865;
			if (num != 0)
			{
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x0005E7F0 File Offset: 0x0005C9F0
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x0005E8A0 File Offset: 0x0005CAA0
		public static global::System.Xml.XmlDocument MRUDoc
		{
			get
			{
				short num = (short)545062912;
				short num2 = num;
				num = (short)2132983658;
				short num3 = num;
				num = (short)227196778;
				switch (num3 == num)
				{
				}
				num = (short)1098645505;
				if (num != 0)
				{
				}
				num = (short)1240662016;
				if (num != 0)
				{
				}
				return global::AcpUI.Mru.MruFiles.d;
			}
			set
			{
				short num = (short)1291911168;
				short num2 = num;
				num = (short)442813702;
				short num3 = num;
				num = (short)758238470;
				switch (num3 == num)
				{
				}
				num = (short)102432769;
				if (num != 0)
				{
				}
				num = (short)1328742400;
				if (num != 0)
				{
				}
				global::AcpUI.Mru.MruFiles.d = value;
			}
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x0005E950 File Offset: 0x0005CB50
		private static void a(global::System.IO.IsolatedStorage.IsolatedStorageFile A_0)
		{
			int a_ = 1;
			short num = (short)1598881792;
			short num2 = num;
			num = (short)623849420;
			short num3 = num;
			num = (short)620376012;
			switch (num3 == num)
			{
			}
			num = (short)330366977;
			if (num != 0)
			{
			}
			num = (short)774438912;
			if (num != 0)
			{
			}
			global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(new global::System.IO.IsolatedStorage.IsolatedStorageFileStream(global::AcpUI.Common.Utility.c("횖즘쎚ꪜ꾞醠鎢瘝邦鲨鮪鶬솰삲얶첸閺얼튾귀", a_), global::System.IO.FileMode.Create, A_0));
			streamWriter.WriteLine(global::AcpUI.Common.Utility.c("ꮖꚘ膠햢삤햦\udaa8슪슬솮貰醲蒴馶覸馺鶼\udabe꿀ꃂ꫄ꏆꃈꗊ꫌蛒臔釖ￜ\udfe0", a_));
			streamWriter.WriteLine(global::AcpUI.Common.Utility.c("ꮖﶘ漢ﺞ膠\udba2좤쮦잨\ud8aa邬袮隰趲", a_));
			streamWriter.WriteLine(global::AcpUI.Common.Utility.c("ꮖ뚘ﾚﲜ삠鶢", a_));
			streamWriter.Close();
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0005EA5C File Offset: 0x0005CC5C
		public static void UpdateMRU(string pathName)
		{
			int a_ = 6;
			short num = (short)287965184;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_74;
				}
				global::System.Xml.XmlNode documentElement;
				for (;;)
				{
					IL_31:
					global::System.Collections.IEnumerator enumerator;
					int num3;
					switch (num2)
					{
					case 0:
						num = (short)854917121;
						if (num != 0)
						{
						}
						if (documentElement != null)
						{
							num = (short)686882822;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						goto IL_4B9;
					case 2:
						return;
					case 3:
						goto IL_43E;
					case 4:
						goto IL_43E;
					case 5:
						if (documentElement.ChildNodes.Count == 0)
						{
							num = (short)882180110;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_43E;
					case 6:
					{
						global::System.Xml.XmlElement xmlElement = global::AcpUI.Mru.MruFiles.d.CreateElement(global::AcpUI.Common.Utility.c("얟쾡", a_));
						xmlElement.SetAttribute(global::AcpUI.Common.Utility.c("첛ﾝ풟쪡", a_), pathName);
						xmlElement.SetAttribute(global::AcpUI.Common.Utility.c("튛ﾝ춟잡", a_), global::AcpUI.Mru.MruFiles.a(pathName));
						enumerator = documentElement.ChildNodes.GetEnumerator();
						num = (short)355074058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_4B9;
					case 8:
						num = (short)69861379;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						try
						{
							num = (short)1696792576;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_187;
									}
									continue;
								case 1:
									goto IL_221;
								case 3:
									if (!enumerator.MoveNext())
									{
										num = (short)1951006724;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									((global::System.Xml.XmlElement)((global::System.Xml.XmlNode)enumerator.Current)).SetAttribute(global::AcpUI.Common.Utility.c("햛쒟잡\udca3", a_), num3.ToString());
									num3++;
									num = (short)956628994;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)1711341569;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1D1:
								num = (short)1451098115;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_187:
								goto IL_1D1;
							}
							IL_221:
							goto IL_46B;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_243;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_230:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)1132068865;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_29C;
								case 1:
									disposable.Dispose();
									num = (short)1310785538;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_29A;
								}
								goto IL_243;
							}
							IL_29A:
							IL_29C:
							goto EndFinally_15;
							IL_243:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)113442816;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_230;
							EndFinally_15:;
						}
						goto Block_3;
						IL_46B:
						global::System.IO.TextWriter textWriter = new global::System.IO.StreamWriter(new global::System.IO.IsolatedStorage.IsolatedStorageFileStream(global::AcpUI.Common.Utility.c("\udd9b캝閡钣隥颧鮫鮭肯花욵쮷캻쮽뫁꧃꫅", a_), global::System.IO.FileMode.Create, global::AcpUI.Mru.MruFiles.e));
						global::AcpUI.Mru.MruFiles.d.Save(textWriter);
						textWriter.Close();
						num = (short)963903490;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_29D;
					case 11:
						if (documentElement.ChildNodes.Count <= 4)
						{
							num = (short)1496580104;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						documentElement.RemoveChild(documentElement.LastChild);
						num = (short)1313931271;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (documentElement.ChildNodes.Count > 0)
						{
							num = (short)1743323149;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1759969285;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						global::System.Xml.XmlElement xmlElement;
						documentElement.InsertBefore(xmlElement, documentElement.FirstChild);
						num = (short)1173880833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						num = (short)1202209753;
						short num4 = num;
						num = (short)2002076633;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
						{
							num = (short)411041792;
							if (num != 0)
							{
							}
							global::System.Xml.XmlElement xmlElement;
							documentElement.AppendChild(xmlElement);
							num = (short)1923940356;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					}
					goto IL_74;
					IL_43E:
					num3 = 1;
					enumerator = documentElement.ChildNodes.GetEnumerator();
					num = (short)2135425033;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_3:
					try
					{
						IL_29D:
						num = (short)258539521;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1874460675;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Xml.XmlNode xmlNode = (global::System.Xml.XmlNode)enumerator.Current;
								num = (short)1524826114;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								switch (0)
								{
								case 0:
									goto IL_2E0;
								}
								continue;
							case 2:
							{
								global::System.Xml.XmlNode xmlNode;
								if (xmlNode.Attributes[global::AcpUI.Common.Utility.c("첛ﾝ풟쪡", a_)].Value == pathName)
								{
									num = (short)1249050630;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
								num = (short)583598084;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_3C3;
							case 6:
							{
								global::System.Xml.XmlNode xmlNode;
								documentElement.RemoveChild(xmlNode);
								num = (short)482148357;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_2E2:
							num = (short)2001666048;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_2E0:
							goto IL_2E2;
						}
						IL_3C3:
						goto IL_4FF;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_3E5;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_3D2:
							switch (num2)
							{
							case 0:
								if (disposable != null)
								{
									num = (short)2098528257;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_43D;
							case 1:
								disposable.Dispose();
								num = (short)1230241794;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_43B;
							}
							goto IL_3E5;
						}
						IL_43B:
						IL_43D:
						goto EndFinally_14;
						IL_3E5:
						disposable = (enumerator as global::System.IDisposable);
						num = (short)1192493056;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_3D2;
						EndFinally_14:;
					}
					goto IL_43E;
					IL_4FF:
					num = (short)155451404;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4B9:
					num = (short)510525451;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_74:
				num = (short)460652544;
				short num5 = num;
				documentElement = global::AcpUI.Mru.MruFiles.d.DocumentElement;
				num = (short)941883392;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0005F140 File Offset: 0x0005D340
		private static string a(string A_0)
		{
			int a_ = 17;
			string result;
			for (;;)
			{
				IL_09:
				short num = (short)1425539072;
				short num2 = num;
				num = (short)1996488704;
				int num3 = (int)num;
				switch (num3)
				{
				default:
					switch (0)
					{
					case 0:
						goto IL_76;
					}
					for (;;)
					{
						IL_5B:
						switch (num3)
						{
						case 0:
						{
							if (A_0.Length <= 40)
							{
								num = (short)1981153282;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							string text = A_0[0].ToString() + global::AcpUI.Common.Utility.c("ﮦ螨薪莬", a_);
							int startIndex = A_0.Length + text.Length - 40 - 1;
							num = (short)1467875332;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							return result;
						case 2:
							result = A_0;
							num = (short)1370488835;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							return result;
						case 4:
						{
							int startIndex;
							string text2 = A_0.Substring(startIndex);
							int num4 = text2.IndexOf('\\');
							if (num4 == -1)
							{
								num4 = 0;
							}
							string str = text2.Substring(num4);
							string text;
							result = text + str;
							num = (short)2038971133;
							short num5 = num;
							num = (short)1169505021;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_09;
							default:
								num = (short)852885504;
								if (num != 0)
								{
								}
								num = (short)404946945;
								if (num != 0)
								{
								}
								num = (short)1711210497;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						break;
					}
					IL_76:
					result = null;
					num = (short)1195638784;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_5B;
				}
			}
			return result;
		}

		// Token: 0x040002B4 RID: 692
		private const string a = "APX7000_7500CpsMru.xml";

		// Token: 0x040002B5 RID: 693
		private const int b = 40;

		// Token: 0x040002B6 RID: 694
		private const int c = 4;

		// Token: 0x040002B7 RID: 695
		private static global::System.Xml.XmlDocument d;

		// Token: 0x040002B8 RID: 696
		private static global::System.IO.IsolatedStorage.IsolatedStorageFile e;
	}
}
