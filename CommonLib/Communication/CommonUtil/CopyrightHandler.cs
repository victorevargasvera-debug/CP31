using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Motorola.Common.Communication.CommonUtil.Extensions;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200001F RID: 31
	public static class CopyrightHandler
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000DA RID: 218 RVA: 0x0001626C File Offset: 0x0001446C
		private static string CopyrightString
		{
			get
			{
				int a_ = 1;
				short num = (short)1663465210;
				short num2 = num;
				num = (short)1819703034;
				switch (num2 == num)
				{
				}
				num = (short)1628176384;
				if (num != 0)
				{
				}
				num = (short)1334640641;
				if (num != 0)
				{
				}
				num = (short)375717888;
				short num3 = num;
				return string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䘄栆礈爊缌明瘐笒愔㜖ㄘ砚㐜㼞娠ጢ堤ܦ搨䐪夬䀮䌰尲头嘶ᤸ栺刼匾㑀㝂ⱄ⡆❈㡊慌潎ᡐ㵒㙔祖祘ᩚㅜ㍞䅠ㅢ౤fŨὪṬ佮⍰ᙲٴቶ୸ൺ᡼᭾ꆀ", a_), global::System.DateTime.Now.Year.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000DB RID: 219 RVA: 0x00016350 File Offset: 0x00014550
		public static byte[] CopyrightHeaderBytes
		{
			get
			{
				short num = (short)66584577;
				if (num != 0)
				{
				}
				num = (short)1348977769;
				short num2 = num;
				num = (short)1536410729;
				switch (num2 == num)
				{
				}
				num = (short)2050228224;
				if (num != 0)
				{
				}
				num = (short)247726080;
				short num3 = num;
				return global::System.Text.Encoding.UTF8.GetBytes(global::Motorola.Common.Communication.CommonUtil.CopyrightHandler.CopyrightString);
			}
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0001640C File Offset: 0x0001460C
		public static void WriteCopyrightHeader(global::System.IO.Stream stream)
		{
			short num = (short)1175086959;
			short num2 = num;
			num = (short)2051041135;
			switch (num2 == num)
			{
			}
			num = (short)1444937729;
			if (num != 0)
			{
			}
			num = (short)1854996480;
			if (num != 0)
			{
			}
			num = (short)2131689472;
			short num3 = num;
			byte[] copyrightHeaderBytes = global::Motorola.Common.Communication.CommonUtil.CopyrightHandler.CopyrightHeaderBytes;
			stream.Write(copyrightHeaderBytes, 0, copyrightHeaderBytes.Length);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000164C8 File Offset: 0x000146C8
		public static string ReadCopyrightHeader(global::System.IO.BinaryReader reader)
		{
			short num = (short)86775782;
			short num2 = num;
			num = (short)240850918;
			string result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)829947905;
				if (num != 0)
				{
				}
				num = (short)247463936;
				if (num != 0)
				{
				}
				num = (short)446038016;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_A2;
						}
						continue;
					case 1:
						goto IL_134;
					case 2:
					{
						num = (short)1838415872;
						short num4 = num;
						reader.BaseStream.Position -= (long)global::Motorola.Common.Communication.CommonUtil.CopyrightHandler.CopyrightHeaderBytes.Length;
						num = (short)1164378113;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_A2:
					if (global::Motorola.Common.Communication.CommonUtil.CopyrightHandler.a(global::System.Text.Encoding.UTF8.GetString(reader.ReadBytes(global::Motorola.Common.Communication.CommonUtil.CopyrightHandler.CopyrightHeaderBytes.Length)), out result))
					{
						break;
					}
					num = (short)2066022402;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_134:
				break;
			}
			}
			return result;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0001660C File Offset: 0x0001480C
		public static byte[] AddCopyRightHeader(byte[] content)
		{
			while (global::Motorola.Common.Communication.CommonUtil.CopyrightHandler.HasCopyRightHeader(content))
			{
				short num = (short)604714134;
				short num2 = num;
				num = (short)1546335382;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1786576897;
					if (num != 0)
					{
					}
					num = (short)611254272;
					if (num != 0)
					{
					}
					num = (short)2142568448;
					short num3 = num;
					return content;
				}
				}
			}
			return global::Motorola.Common.Communication.CommonUtil.CopyrightHandler.a<byte>(new byte[][]
			{
				global::Motorola.Common.Communication.CommonUtil.CopyrightHandler.CopyrightHeaderBytes,
				content
			});
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000166D8 File Offset: 0x000148D8
		public static byte[] RemoveCopyRightHeader(byte[] combinedData)
		{
			short num;
			byte[] array;
			for (;;)
			{
				num = (short)1069875201;
				if (num != 0)
				{
				}
				if (global::Motorola.Common.Communication.CommonUtil.CopyrightHandler.a(combinedData, out array))
				{
					break;
				}
				num = (short)1264946809;
				short num2 = num;
				num = (short)1131843193;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_87;
				}
			}
			int num3 = combinedData.Length - array.Length;
			byte[] array2 = new byte[num3];
			global::System.Buffer.BlockCopy(combinedData, array.Length, array2, 0, num3);
			return array2;
			IL_87:
			num = (short)1892155392;
			if (num != 0)
			{
			}
			num = (short)1563164672;
			short num4 = num;
			return combinedData;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000167AC File Offset: 0x000149AC
		public static bool HasCopyRightHeader(byte[] content)
		{
			short num = (short)1600810748;
			short num2 = num;
			num = (short)2069589756;
			switch (num2 == num)
			{
			}
			num = (short)1877868544;
			if (num != 0)
			{
			}
			num = (short)2107113473;
			if (num != 0)
			{
			}
			num = (short)1660682240;
			short num3 = num;
			byte[] array;
			return global::Motorola.Common.Communication.CommonUtil.CopyrightHandler.a(content, out array);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0001685C File Offset: 0x00014A5C
		private static a[] a<a>(params a[][] A_0)
		{
			short num = (short)1562050560;
			switch (num)
			{
			default:
			{
				num = (short)782499841;
				int num2 = (int)((global::System.IntPtr)num);
				a[] array2;
				for (;;)
				{
					int num3;
					int num4;
					switch (num2)
					{
					case 0:
						goto IL_194;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_5B;
						}
						continue;
					case 2:
						goto IL_133;
					case 3:
						goto IL_133;
					case 4:
					{
						if (num3 >= A_0.Length)
						{
							num = (short)2095513600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						a[] array = A_0[num3];
						global::System.Buffer.BlockCopy(array, 0, array2, num4, array.Length);
						num4 += array.Length;
						num3++;
						num = (short)877430105;
						short num5 = num;
						num = (short)1761445209;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_133;
						default:
							num = (short)431816704;
							if (num != 0)
							{
							}
							num = (short)54722562;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_5B:
					array2 = new a[A_0.Sum(new global::System.Func<a[], int>(global::Motorola.Common.Communication.CommonUtil.CopyrightHandler.<>c__12<a>.<>9.a))];
					num4 = 0;
					num3 = 0;
					num = (short)1301282819;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_133:
					num = (short)1708589057;
					if (num != 0)
					{
					}
					num = (short)834535428;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_194:
				num = (short)1999044608;
				short num6 = num;
				return array2;
			}
			}
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00016A2C File Offset: 0x00014C2C
		private static bool a(byte[] A_0, out byte[] A_1)
		{
			short num = (short)1861115173;
			short num2 = num;
			num = (short)1969708325;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_C5:
				num = (short)2039414787;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)2024407040;
				if (num != 0)
				{
				}
				num = (short)1998389249;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_C5;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_82;
					}
					continue;
				case 2:
					goto IL_DC;
				case 3:
					goto IL_11F;
				}
				IL_82:
				if (A_0.Length <= 70)
				{
					num = (short)436666368;
					short num4 = num;
					num = (short)722862080;
					num3 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1146552322;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
			IL_DC:
			num = (short)1160904705;
			if (num != 0)
			{
			}
			int num5 = 70;
			goto IL_124;
			IL_11F:
			num5 = A_0.Length;
			IL_124:
			int count = num5;
			string s;
			bool result = global::Motorola.Common.Communication.CommonUtil.CopyrightHandler.a(global::System.Text.Encoding.UTF8.GetString(A_0, 0, count), out s);
			A_1 = global::System.Text.Encoding.UTF8.GetBytes(s);
			return result;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00016B80 File Offset: 0x00014D80
		private static bool a(string A_0, out string A_1)
		{
			int a_ = 17;
			global::System.Text.RegularExpressions.Match match;
			for (;;)
			{
				IL_09:
				short num = (short)637206529;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						match = new global::System.Text.RegularExpressions.Regex(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("䬔吖瘘欚搜洞䠠䐢䴤匦न眪Ԭ䰮洰ᨲᔴ欶崸်ᴼ爾⹀㝂⩄㕆♈❊ⱌ潎ɐ㱒㥔≖ⵘ㉚㉜ㅞበ佢䕤⹦ݨࡪㅬ䅮兰㉲ᥴ᭶奸⥺ᑼ᡾Ꞇ\udb88ﺌ릘", a_), global::System.Text.RegularExpressions.RegexOptions.Compiled).Match(A_0);
						num = (short)1125974018;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_3D;
						}
						continue;
					case 2:
						if (match.Success)
						{
							num = (short)1146880003;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15A;
					case 3:
						goto IL_158;
					}
					IL_3D:
					if (string.IsNullOrEmpty(A_0))
					{
						goto IL_15A;
					}
					num = (short)1202192384;
					short num3 = num;
					num = (short)1595874160;
					short num4 = num;
					num = (short)259332976;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_09;
					default:
						num = (short)479854592;
						if (num != 0)
						{
						}
						num = (short)884015105;
						if (num != 0)
						{
						}
						num = (short)1607401472;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
			}
			IL_158:
			A_1 = match.Value;
			return true;
			IL_15A:
			A_1 = string.Empty;
			return false;
		}

		// Token: 0x040000AB RID: 171
		private const string a = "^Copyright \\(c\\) \\d+ Motorola Solutions, Inc\\. All Rights Reserved ";

		// Token: 0x040000AC RID: 172
		private const int b = 70;

		// Token: 0x040000AD RID: 173
		private const string c = "Copyright (c) {0} Motorola Solutions, Inc. All Rights Reserved ";
	}
}
