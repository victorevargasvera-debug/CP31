using System;
using System.IO;

namespace ACPBrowser
{
	// Token: 0x02000007 RID: 7
	public class HelpFilePathProvider
	{
		// Token: 0x06000010 RID: 16 RVA: 0x00002900 File Offset: 0x00000B00
		public HelpFilePathProvider(global::ACPBrowser.IFileService fileService)
		{
			this.a = fileService;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000291C File Offset: 0x00000B1C
		public string BuildPathForCPSHelp(string fragment)
		{
			int a_ = 2;
			switch (0)
			{
			case 0:
				goto IL_39;
			}
			int num;
			string text2;
			short num2;
			string text3;
			for (;;)
			{
				IL_13:
				string text;
				switch (num)
				{
				case 0:
					goto IL_1C1;
				case 1:
					if ((text = text2) == null)
					{
						num2 = (short)990511110;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_180;
				case 2:
					if (this.a.Exists(text3))
					{
						num2 = (short)654901248;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_235;
				case 3:
					if (this.a.Exists(text3))
					{
						num2 = (short)217101954;
						short num3 = num2;
						num2 = (short)251377282;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_181;
						case 1:
							break;
						default:
						{
							num2 = (short)745668608;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)1179582464;
						if (num2 != 0)
						{
						}
						num2 = (short)693698565;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_9B;
				case 4:
					text3 = global::ACPBrowser.Utility.HelpRootDir + fragment;
					num2 = (short)2019622915;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_17B;
				case 6:
					text = "";
					goto IL_180;
				case 7:
					if (fragment != null)
					{
						num2 = (short)1762066436;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_9B;
				}
				goto IL_39;
				IL_9B:
				num2 = (short)2143289345;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_181:
				num2 = (short)1750663170;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_180:
				text3 = text;
				goto IL_181;
			}
			IL_17B:
			return global::ACPBrowser.HelpFilePathProvider.b("鋳鿵铷鿹웻퇽⿿ⴁ", a_) + text2 + global::ACPBrowser.HelpFilePathProvider.b("ퟳ", a_) + fragment;
			IL_1C1:
			num2 = (short)1517158401;
			if (num2 != 0)
			{
			}
			return global::ACPBrowser.HelpFilePathProvider.b("鋳鿵铷鿹웻퇽⿿ⴁ", a_) + text3;
			IL_235:
			return null;
			IL_39:
			text3 = string.Empty;
			text2 = global::System.IO.Path.Combine(global::ACPBrowser.Utility.HelpRootDir, global::ACPBrowser.HelpFilePathProvider.b("闳蛵胷鳹鷻鏽槿渁紃⠅怇縉愋", a_));
			num2 = (short)1519976455;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002B60 File Offset: 0x00000D60
		public string BuildPathForCPSHelpDITA(string fragment)
		{
			int a_ = 10;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			short num2;
			string text;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_114;
				case 1:
				{
					num2 = (short)1850867713;
					if (num2 != 0)
					{
					}
					num2 = (short)1602945024;
					short num3 = num2;
					num2 = (short)1345847296;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_12E;
				case 3:
				{
					if (this.a.Exists(text))
					{
						num2 = (short)1149894657;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)527195007;
					short num4 = num2;
					num2 = (short)1233869695;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_114;
					default:
						goto IL_166;
					}
					break;
				}
				}
				goto IL_29;
				IL_114:
				if (fragment != null)
				{
					break;
				}
				num2 = (short)1883439106;
				num = (int)((global::System.IntPtr)num2);
			}
			return global::ACPBrowser.HelpFilePathProvider.b("髻韽泿朁㸃⤅✇┉", a_) + text + fragment;
			IL_12E:
			return global::ACPBrowser.HelpFilePathProvider.b("髻韽泿朁㸃⤅✇┉", a_) + text;
			IL_166:
			num2 = (short)1097269248;
			if (num2 != 0)
			{
			}
			return null;
			IL_29:
			text = global::System.IO.Path.Combine(global::ACPBrowser.Utility.HelpRootDir, global::ACPBrowser.HelpFilePathProvider.b("闻都擿朁簃⠅怇縉愋戍", a_));
			num2 = (short)1561985027;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002CEC File Offset: 0x00000EEC
		public string BuildPathForMovies(string fragment)
		{
			int a_ = 15;
			switch (0)
			{
			case 0:
				goto IL_39;
			}
			int num;
			short num2;
			string text2;
			string str;
			for (;;)
			{
				IL_13:
				string text;
				switch (num)
				{
				case 0:
					goto IL_1FD;
				case 1:
					if ((text = global::System.IO.Path.Combine(global::ACPBrowser.Utility.HelpRootDir, global::ACPBrowser.HelpFilePathProvider.b("怀猂約愆栈昊搌挎栐㴒純挖琘", a_))) == null)
					{
						num2 = (short)174915590;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1BF;
				case 2:
					if (this.a.Exists(text2))
					{
						num2 = (short)1642135552;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_238;
				case 3:
					if (this.a.Exists(text2))
					{
						num2 = (short)1114524796;
						short num3 = num2;
						num2 = (short)1481854076;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1C0;
						case 1:
							break;
						default:
						{
							num2 = (short)2127167488;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)761790465;
						if (num2 != 0)
						{
						}
						num2 = (short)396754944;
						if (num2 != 0)
						{
						}
						num2 = (short)1713242117;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_82;
				case 4:
					text2 = global::ACPBrowser.Utility.HelpRootDir + fragment;
					str = global::System.IO.Path.Combine(global::ACPBrowser.Utility.HelpRootDir, global::ACPBrowser.HelpFilePathProvider.b("笀礂億爆紈搊缌明瀐缒昔䬖堘䬚䔜䀞氠欢稤眦笨愪焬渮愰欲破堶伸刺堼ᄾ⥀㝂⡄摆杈敊ᅌ慎罐དྷ", a_));
					num2 = (short)663486467;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_1BD;
				case 6:
					text = "";
					goto IL_1BF;
				case 7:
					if (fragment != null)
					{
						num2 = (short)205914116;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_82;
				}
				goto IL_39;
				IL_82:
				num2 = (short)1806893057;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1C0:
				num2 = (short)965476354;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1BF:
				text2 = text;
				goto IL_1C0;
			}
			IL_1BD:
			return global::ACPBrowser.HelpFilePathProvider.b("最樂椄戆㌈␊∌‎", a_) + str + fragment;
			IL_1FD:
			return global::ACPBrowser.HelpFilePathProvider.b("最樂椄戆㌈␊∌‎", a_) + text2;
			IL_238:
			return null;
			IL_39:
			text2 = string.Empty;
			num2 = (short)1198718983;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002F34 File Offset: 0x00001134
		public string BuildPathForCPSTutorials(string tutorialName)
		{
			int a_ = 4;
			switch (0)
			{
			case 0:
				goto IL_39;
			}
			int num;
			short num2;
			string text2;
			for (;;)
			{
				IL_13:
				string text;
				switch (num)
				{
				case 0:
					goto IL_1B9;
				case 1:
					if ((text = global::System.IO.Path.Combine(global::ACPBrowser.Utility.TutorialRootDir, global::ACPBrowser.HelpFilePathProvider.b("ꋵ跷軹鏻賽槿持栃夅䀇攉愋欍䰏娑笓笕紗標紛礝䔟డ䰣別䔧", a_))) == null)
					{
						num2 = (short)651624454;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_17C;
				case 2:
					if (this.a.Exists(text2))
					{
						num2 = (short)1614413824;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_21C;
				case 3:
				{
					if (!this.a.Exists(text2))
					{
						goto IL_82;
					}
					num2 = (short)47249043;
					short num3 = num2;
					num2 = (short)1286469267;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_17D;
					default:
					{
						num2 = (short)397541376;
						if (num2 != 0)
						{
						}
						num2 = (short)1248067584;
						short num4 = num2;
						num2 = (short)708116485;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 4:
					text2 = global::ACPBrowser.Utility.TutorialRootDir + tutorialName;
					num2 = (short)1941897219;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_177;
				case 6:
					text = "";
					goto IL_17C;
				case 7:
					if (tutorialName != null)
					{
						num2 = (short)219938820;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_82;
				}
				goto IL_39;
				IL_82:
				num2 = (short)1007943681;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_17D:
				num2 = (short)1790640130;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_17C:
				text2 = text;
				goto IL_17D;
			}
			IL_177:
			return global::ACPBrowser.HelpFilePathProvider.b("郵釷雹駻쓽⿿ⴁ⬃", a_) + text2;
			IL_1B9:
			num2 = (short)1650262017;
			if (num2 != 0)
			{
			}
			return global::ACPBrowser.HelpFilePathProvider.b("郵釷雹駻쓽⿿ⴁ⬃", a_) + text2;
			IL_21C:
			return null;
			IL_39:
			text2 = string.Empty;
			num2 = (short)418119687;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00003160 File Offset: 0x00001360
		public static string BuildPathForHelpByTagContextMenu(string fileName)
		{
			int a_ = 18;
			short num = (short)1296377640;
			short num2 = num;
			num = (short)2088904488;
			string str;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)867958784;
				short num3 = num;
				num = (short)446562304;
				if (num != 0)
				{
				}
				str = global::System.IO.Path.Combine(global::ACPBrowser.Utility.HelpRootDir, global::ACPBrowser.HelpFilePathProvider.b("洃栅氇漉琋‍砏昑礓稕", a_));
				if (string.IsNullOrEmpty(fileName))
				{
					num = (short)1919942657;
					if (num != 0)
					{
					}
					return null;
				}
				break;
			}
			}
			string str2 = fileName.Replace(global::ACPBrowser.HelpFilePathProvider.b("⨃清簇有怋", a_), string.Empty);
			return global::ACPBrowser.HelpFilePathProvider.b("戃漅搇漉㘋ℍ㼏㴑", a_) + str + global::ACPBrowser.HelpFilePathProvider.b("✃", a_) + str2;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00003274 File Offset: 0x00001474
		public static string BuildPathForHelpByFileContextMenu(string fileName)
		{
			int a_ = 16;
			short num = (short)184520547;
			short num2 = num;
			num = (short)1781501795;
			string str;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2064187392;
				short num3 = num;
				num = (short)1943339008;
				if (num != 0)
				{
				}
				num = (short)613089281;
				if (num != 0)
				{
				}
				str = global::System.IO.Path.Combine(global::ACPBrowser.Utility.HelpRootDir, global::ACPBrowser.HelpFilePathProvider.b("欁樃戅洇爉∋昍搏缑砓", a_));
				if (string.IsNullOrEmpty(fileName))
				{
					return null;
				}
				break;
			}
			}
			return global::ACPBrowser.HelpFilePathProvider.b("搁洃樅洇〉⌋ℍ㼏", a_) + str + global::ACPBrowser.HelpFilePathProvider.b("㴁戃漅搇漉ㄋ", a_) + fileName;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00003370 File Offset: 0x00001570
		public string BuildPathForHelpByFileName(string fileName)
		{
			int a_ = 5;
			string text;
			for (;;)
			{
				IL_09:
				short num = (short)477102080;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_3F;
						}
						continue;
					case 1:
						goto IL_156;
					case 2:
					{
						num = (short)1421620409;
						short num3 = num;
						num = (short)1518023865;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
							num = (short)1862729728;
							if (num != 0)
							{
							}
							if (this.a.Exists(text))
							{
								num = (short)353697793;
								if (num != 0)
								{
								}
								num = (short)1464270849;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_84;
						}
						break;
					}
					case 3:
						text = global::System.IO.Path.Combine(global::ACPBrowser.Utility.HelpRootDir, fileName);
						num = (short)1966473218;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_3F:
					if (fileName == null)
					{
						goto IL_15B;
					}
					num = (short)2086010880;
					short num4 = num;
					num = (short)1358757891;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_84:
			return null;
			IL_156:
			return global::ACPBrowser.HelpFilePathProvider.b("釶郸韺飼엾⸀Ⰲ⨄", a_) + text;
			IL_15B:
			return null;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000034DC File Offset: 0x000016DC
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(475035076 + A_1) + (global::System.IntPtr)15 + (global::System.IntPtr)13 + (global::System.IntPtr)17);
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

		// Token: 0x04000008 RID: 8
		private readonly global::ACPBrowser.IFileService a;

		// Token: 0x04000009 RID: 9
		public const string Prefix = "file:///";

		// Token: 0x0400000A RID: 10
		private const string b = "index.html";

		// Token: 0x0400000B RID: 11
		private const string c = "apxfamily.htm";
	}
}
