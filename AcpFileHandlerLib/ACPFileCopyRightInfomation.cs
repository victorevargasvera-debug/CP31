using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace AcpFileHandlerLib
{
	// Token: 0x02000004 RID: 4
	public class ACPFileCopyRightInfomation
	{
		// Token: 0x06000016 RID: 22 RVA: 0x00002F24 File Offset: 0x00001124
		private ACPFileCopyRightInfomation()
		{
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002F38 File Offset: 0x00001138
		public static global::AcpFileHandlerLib.ACPFileCopyRightInfomation Instance
		{
			get
			{
				short num = (short)1986199552;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1118961664;
					short num3 = num;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_59;
						}
						continue;
					case 1:
						goto IL_EC;
					case 2:
						global::AcpFileHandlerLib.ACPFileCopyRightInfomation.a = new global::AcpFileHandlerLib.ACPFileCopyRightInfomation();
						num = (short)2015035393;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_59:
					if (global::AcpFileHandlerLib.ACPFileCopyRightInfomation.a != null)
					{
						goto IL_118;
					}
					num = (short)164647644;
					short num4 = num;
					num = (short)1648317148;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_118;
					default:
						num = (short)403243008;
						if (num != 0)
						{
						}
						num = (short)354025474;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_EC:
				num = (short)1499201537;
				if (num != 0)
				{
				}
				IL_118:
				return global::AcpFileHandlerLib.ACPFileCopyRightInfomation.a;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000018 RID: 24 RVA: 0x00003064 File Offset: 0x00001264
		public string CopyRightInformation
		{
			get
			{
				int a_ = 13;
				short num = (short)1872308139;
				short num2 = num;
				num = (short)1356670891;
				switch (num2 == num)
				{
				}
				num = (short)1925971968;
				short num3 = num;
				num = (short)3014656;
				if (num != 0)
				{
				}
				num = (short)402259969;
				if (num != 0)
				{
				}
				return global::AcpFileHandlerLib.AcpSaveFileDialog.b("꿫臭胯诱蛳鿵鿷鋹裻\udefd⣿愁ⴃ★", a_) + global::System.DateTime.Now.Year.ToString() + global::AcpFileHandlerLib.AcpSaveFileDialog.b("쳫ꏭ鿯蛱鯳蓵韷雹鷻\udefd叿洁栃猅簇按挋怍挏㸑㐓引瘗礙㈛㸝感両䠣إ稧䌩䬫䘭䐯䄱ᐳ搵崷䤹夻䰽㘿❁⁃晅", a_);
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003150 File Offset: 0x00001350
		public void SkipCopyRightInfoIfHas(global::System.IO.Stream fs)
		{
			short num = (short)402902484;
			short num2 = num;
			num = (short)925093332;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)698351616;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_68;
				}
				int num3;
				int num4;
				for (;;)
				{
					IL_56:
					switch (num3)
					{
					case 0:
						fs.Seek((long)num4, global::System.IO.SeekOrigin.Begin);
						num = (short)1700855810;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (fs.CanSeek)
						{
							num = (short)1947074560;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						return;
					}
					break;
				}
				IL_68:
				num4 = this.a(fs);
				num = (short)992608257;
				if (num != 0)
				{
				}
				num = (short)1534459904;
				short num5 = num;
				num = (short)805896193;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_56;
			}
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00003280 File Offset: 0x00001480
		public byte[] SkipCopyRightInfoIfHas(byte[] fileBytes)
		{
			short num = (short)294418547;
			short num2 = num;
			num = (short)1575712883;
			switch (num2 == num)
			{
			}
			num = (short)516423680;
			short num3 = num;
			num = (short)31850497;
			if (num != 0)
			{
			}
			num = (short)110821376;
			if (num != 0)
			{
			}
			int num4 = this.a(fileBytes);
			byte[] array = new byte[fileBytes.Length - num4];
			global::System.Array.Copy(fileBytes, num4, array, 0, array.Length);
			return array;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00003348 File Offset: 0x00001548
		private int a(byte[] A_0)
		{
			short num = (short)1939079169;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_DE;
				case 1:
					num = (short)266469377;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				case 2:
					goto IL_C4;
				case 3:
					goto IL_122;
				}
				IL_5C:
				num = (short)2059648;
				short num3 = num;
				num = (short)2035838336;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_C4:
					num = (short)1547173888;
					short num4 = num;
					num = (short)1016070147;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				default:
					num = (short)1199702016;
					if (num != 0)
					{
					}
					if (A_0.Length <= 64)
					{
						num = (short)1726545922;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)769654784;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_DE:
			int num5 = 64;
			goto IL_127;
			IL_122:
			num5 = A_0.Length;
			IL_127:
			int count = num5;
			string @string = global::System.Text.Encoding.UTF8.GetString(A_0, 0, count);
			return this.a(@string);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003494 File Offset: 0x00001694
		private int a(global::System.IO.Stream A_0)
		{
			short num = (short)1628962816;
			short num2 = num;
			num = (short)780409344;
			short num3 = num;
			num = (short)1535842816;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_E6:
				num = (short)1722875905;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1241120768;
				if (num != 0)
				{
				}
				num = (short)1413545984;
				num4 = (int)num;
				switch (num4)
				{
				default:
					switch (0)
					{
					case 0:
						goto IL_B3;
					}
					break;
				}
				break;
			}
			for (;;)
			{
				switch (num4)
				{
				case 0:
					goto IL_138;
				case 1:
					if (A_0.Length <= 64L)
					{
						num = (short)448987138;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)848035840;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)2025062403;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_155;
				}
				goto IL_B3;
			}
			IL_138:
			int num5 = (int)64L;
			goto IL_15D;
			IL_155:
			num5 = (int)A_0.Length;
			IL_15D:
			int num6 = num5;
			byte[] array = new byte[num6];
			int count = A_0.Read(array, 0, num6);
			string @string = global::System.Text.Encoding.UTF8.GetString(array, 0, count);
			return this.a(@string);
			IL_B3:
			num = (short)260964353;
			if (num != 0)
			{
			}
			A_0.Seek(0L, global::System.IO.SeekOrigin.Begin);
			goto IL_E6;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003628 File Offset: 0x00001828
		private int a(string A_0)
		{
			int a_ = 9;
			short num;
			global::System.Text.RegularExpressions.Match match;
			for (;;)
			{
				num = (short)1279524865;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!match.Success)
						{
							num = (short)1764556803;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14E;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_3E;
						}
						continue;
					case 2:
						goto IL_5C;
					case 3:
						return 0;
					}
					IL_3E:
					if (string.IsNullOrEmpty(A_0))
					{
						num = (short)1400307714;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						match = new global::System.Text.RegularExpressions.Regex(global::AcpFileHandlerLib.AcpSaveFileDialog.b("뛧ꧩ菫黭觯胱鷳釵郷軹\udcfbꋽ⣿愁堃⼅⠇嘉栋甍␏漑㐓嬕眗渙猛氝伟両䔣إ笧䔩䀫嬭䐯嬱嬳堵䬷ᘹ᰻眽⸿⅁ᡃ桅桇୉⁋≍灏Q㵓ㅕし⹙⽛繝㉟ݡᝣͥᩧᱩ५੭偯", a_), global::System.Text.RegularExpressions.RegexOptions.Compiled).Match(A_0);
						num = (short)207814656;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_5C:
				num = (short)1086409583;
				short num3 = num;
				num = (short)256592751;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_E7;
				}
			}
			return 0;
			IL_E7:
			num = (short)104464384;
			short num4 = num;
			num = (short)2124611585;
			if (num != 0)
			{
			}
			num = (short)1650065408;
			if (num != 0)
			{
			}
			return 0;
			IL_14E:
			string value = match.Value;
			return global::System.Text.Encoding.UTF8.GetBytes(value).Length;
		}

		// Token: 0x04000005 RID: 5
		private static global::AcpFileHandlerLib.ACPFileCopyRightInfomation a;

		// Token: 0x04000006 RID: 6
		private const string b = "^Copyright \\(c\\) \\d{4} Motorola Solutions, Inc\\. All Rights Reserved ";

		// Token: 0x04000007 RID: 7
		private const int c = 64;
	}
}
