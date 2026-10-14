using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using Motorola.Common.Communication.AmpRequest.Models;

namespace Motorola.Common.Communication.AmpRequest.Utilities
{
	// Token: 0x0200003F RID: 63
	public static class HttpResponseDeserializingUtil
	{
		// Token: 0x06000114 RID: 276 RVA: 0x0000E4C8 File Offset: 0x0000C6C8
		public static void TryGetResponseMessage(byte[] responseData, out global::System.Net.Http.HttpResponseMessage message)
		{
			int a_ = 8;
			short num = (short)1205656393;
			short num2 = num;
			num = (short)1190124361;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)242941952;
				if (num != 0)
				{
				}
				num = (short)948305921;
				if (num != 0)
				{
				}
				num = (short)1916665856;
				short num3 = num;
				num = (short)432930816;
				int num4 = (int)num;
				switch (num4)
				{
				}
				break;
			}
			}
			global::System.Net.Http.HttpResponseMessage httpResponseMessage = new global::System.Net.Http.HttpResponseMessage();
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(responseData);
			try
			{
				switch (0)
				{
				case 0:
					goto IL_140;
				}
				int num4;
				for (;;)
				{
					IL_DD:
					string text;
					long? num6;
					long num7;
					bool flag;
					bool? transferEncodingChunked;
					long? num9;
					string text2;
					switch (num4)
					{
					case 0:
						goto IL_414;
					case 1:
						if (!(string.Empty == text))
						{
							num = (short)2074279939;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32D;
					case 2:
						goto IL_167;
					case 3:
					{
						int num5 = int.Parse(text, global::System.Globalization.NumberStyles.HexNumber);
						num = (short)1109065745;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						flag = (num6.GetValueOrDefault() == num7 & num6 != null);
						goto IL_272;
					case 5:
					{
						if (!transferEncodingChunked.GetValueOrDefault())
						{
							num = (short)1491599367;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.List<byte> list = new global::System.Collections.Generic.List<byte>();
						num = (short)419168274;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						flag = false;
						goto IL_272;
					case 7:
						goto IL_2F7;
					case 8:
						goto IL_167;
					case 9:
					{
						global::System.Net.Http.HttpContent content = httpResponseMessage.Content;
						if (content == null)
						{
							num = (short)808255494;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Net.Http.Headers.HttpContentHeaders headers = content.Headers;
						if (headers == null)
						{
							long? num8 = null;
							num = (short)864354314;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						num9 = headers.ContentLength;
						goto IL_23F;
					}
					case 10:
					{
						long? num8;
						num9 = num8;
						goto IL_23F;
					}
					case 11:
						goto IL_49E;
					case 12:
						if (!string.IsNullOrEmpty(text2))
						{
							num = (short)106102798;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)415498249;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_414;
					case 14:
						global::Motorola.Common.Communication.AmpRequest.Utilities.HttpResponseDeserializingUtil.a(text2, httpResponseMessage);
						num = (short)1377632258;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_2AB;
					case 16:
						goto IL_32D;
					case 17:
					{
						int num5;
						if (num5 != 0)
						{
							num = (short)1140916246;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.List<byte> list;
						httpResponseMessage.Content = new global::System.Net.Http.ByteArrayContent(list.ToArray());
						message = httpResponseMessage;
						num = (short)1048379403;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						goto IL_32D;
					case 19:
						message = httpResponseMessage;
						num = (short)1384316943;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
					{
						global::System.Collections.Generic.List<byte> list;
						byte[] array;
						list.AddRange(array);
						num = (short)2135949328;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
					{
						int num5;
						int num10;
						if (num10 >= num5)
						{
							num = (short)1530724372;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] array;
						array[num10] = (byte)memoryStream.ReadByte();
						num10++;
						num = (short)1842741248;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
					{
						int num5;
						byte[] array = new byte[num5];
						int num10 = 0;
						num = (short)1457782797;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_140;
					IL_167:
					text2 = global::Motorola.Common.Communication.AmpRequest.Utilities.HttpResponseDeserializingUtil.a(memoryStream);
					num = (short)1954480140;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_23F:
					num6 = num9;
					num7 = 0L;
					num = (short)525860868;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_272:
					if (flag)
					{
						num = (short)1428881427;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					transferEncodingChunked = httpResponseMessage.Headers.TransferEncodingChunked;
					num = (short)221446149;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_32D:
					text = global::Motorola.Common.Communication.AmpRequest.Utilities.HttpResponseDeserializingUtil.a(memoryStream);
					num = (short)631177217;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_414:
					num = (short)169869333;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_2AB:
				return;
				IL_2F7:
				throw new global::System.InvalidOperationException(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("賂뇄꿆곈맊믎말닒믔뫘돚꣜뇞苠裢胤菦짨苪黬쿮鿰鳲致ퟶ諸軺跼迾渀焂焄戆洈⨊", a_));
				IL_49E:
				return;
				IL_140:
				global::Motorola.Common.Communication.AmpRequest.Utilities.HttpResponseDeserializingUtil.b(global::Motorola.Common.Communication.AmpRequest.Utilities.HttpResponseDeserializingUtil.a(memoryStream), httpResponseMessage);
				num = (short)1349845000;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_DD;
			}
			finally
			{
				num = (short)1444806656;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_4D2;
						}
						continue;
					case 1:
						((global::System.IDisposable)memoryStream).Dispose();
						num = (short)2041708546;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_507;
					}
					IL_4D2:
					if (memoryStream == null)
					{
						break;
					}
					num = (short)1875836929;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_507:;
			}
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000E9FC File Offset: 0x0000CBFC
		private static byte[] b(global::System.IO.Stream A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			global::System.Collections.Generic.List<byte> list;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					for (;;)
					{
						num2 = (short)1412745386;
						short num3 = num2;
						num2 = (short)2111228074;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_7C;
						}
					}
					IL_7C:
					num2 = (short)1438646272;
					if (num2 != 0)
					{
					}
					num2 = (short)220790785;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (list.LastIndexOf((byte)global::Motorola.Common.Communication.AmpRequest.Utilities.HttpResponseDeserializingUtil.a[1]) == list.Count - 1)
					{
						num2 = (short)770048002;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_17E;
				case 2:
					goto IL_DB;
				case 3:
					goto IL_10A;
				case 4:
					if (list.LastIndexOf((byte)global::Motorola.Common.Communication.AmpRequest.Utilities.HttpResponseDeserializingUtil.a[0]) == list.Count - 2)
					{
						num2 = (short)2054029312;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_17E;
				case 5:
					goto IL_10A;
				}
				goto IL_28;
				IL_10A:
				num2 = (short)1364525057;
				if (num2 != 0)
				{
				}
				num2 = (short)774373380;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_17E:
				list.Add((byte)A_0.ReadByte());
				num2 = (short)1828454403;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_DB:
			num2 = (short)927137792;
			short num4 = num2;
			return list.ToArray();
			IL_28:
			list = new global::System.Collections.Generic.List<byte>();
			num2 = (short)1922564101;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000EBB8 File Offset: 0x0000CDB8
		private static string a(global::System.IO.Stream A_0)
		{
			byte[] array = global::Motorola.Common.Communication.AmpRequest.Utilities.HttpResponseDeserializingUtil.b(A_0);
			if (!array.Any<byte>())
			{
				short num = (short)715719437;
				short num2 = num;
				num = (short)1362756365;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1853751296;
					if (num != 0)
					{
					}
					num = (short)256573440;
					short num3 = num;
					num = (short)1799356417;
					if (num != 0)
					{
					}
					throw new global::System.InvalidOperationException();
				}
				}
			}
			return global::System.Text.Encoding.UTF8.GetString(array).TrimEnd(global::Motorola.Common.Communication.AmpRequest.Utilities.HttpResponseDeserializingUtil.a);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000EC90 File Offset: 0x0000CE90
		private static void b(string A_0, global::System.Net.Http.HttpResponseMessage A_1)
		{
			int a_ = 8;
			if (A_0 == null)
			{
				short num = (short)997659188;
				short num2 = num;
				num = (short)1800737332;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1507262464;
					if (num != 0)
					{
					}
					num = (short)1456275456;
					short num3 = num;
					num = (short)2078801921;
					if (num != 0)
					{
					}
					throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("뇂ꃄ듆마꓊ꏌ볎듐鿒볔맖볘", a_), global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("藂꓄껆ꗈ껊꧌뗐ꛒ꟔뻖럘볚﷜꿞胠釢雤軦蟨質췬鷮铰胲藴飶韸裺飼\udffe爀眂搄猆簈砊ⴌ挎砐紒瀔㤖", a_));
				}
				}
			}
			string[] array = A_0.Split(new char[]
			{
				' '
			});
			global::System.Version version = new global::System.Version(array[0].Replace(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("诂釄鏆駈", a_), string.Empty));
			global::System.Net.HttpStatusCode statusCode = (global::System.Net.HttpStatusCode)int.Parse(array[1]);
			string reasonPhrase = array[2];
			A_1.Version = version;
			A_1.StatusCode = statusCode;
			A_1.ReasonPhrase = reasonPhrase;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000EDC0 File Offset: 0x0000CFC0
		private static void a(string A_0, global::System.Net.Http.HttpResponseMessage A_1)
		{
			int a_ = 18;
			short num = (short)432734211;
			int num2 = (int)((global::System.IntPtr)num);
			string name;
			string text;
			for (;;)
			{
				num = (short)474536050;
				short num3 = num;
				num = (short)1272698994;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_16E;
				default:
				{
					num = (short)1419575296;
					short num4 = num;
					num = (short)1505165312;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						if (name != global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("軌ꃎ뿐꟒냔맖귘釜뫞迠蓢釤迦", a_))
						{
							num = (short)402784257;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_192;
					case 1:
						goto IL_16E;
					case 2:
						goto IL_CA;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_B0;
						}
						continue;
					}
					IL_B0:
					if (A_0 == null)
					{
						num = (short)285802498;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						int num5 = A_0.IndexOf(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("", a_));
						name = A_0.Substring(0, num5);
						text = A_0.Substring(num5 + 1);
						num = (short)848691200;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				}
			}
			IL_CA:
			num = (short)1398734849;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentNullException(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("뿌꫎ꋐꏒ뫔맖꫘뻚釜뛞迠蛢", a_), global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("诌껎룐뿒냔돖律뿚꣜귞裠跢苤쟦駨諪鿬鳮飰鷲鋴ퟶ诸黺軼迾渀洂瘄戆⤈挊栌渎甐瘒朔㜖甘爚猜稞༠", a_));
			IL_16E:
			A_1.Headers.TryAddWithoutValidation(name, text);
			return;
			IL_192:
			A_1.Content = new global::System.Net.Http.ByteArrayContent(global::System.Array.Empty<byte>());
			A_1.Content.Headers.ContentLength = new long?((long)int.Parse(text));
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000EF8C File Offset: 0x0000D18C
		// Note: this type is marked as 'beforefieldinit'.
		static HttpResponseDeserializingUtil()
		{
			short num = (short)855865664;
			short num2 = num;
			num = (short)639269184;
			switch (num2 == num)
			{
			}
			num = (short)33292289;
			if (num != 0)
			{
			}
			num = (short)1270677504;
			short num3 = num;
			num = (short)1076297728;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.AmpRequest.Utilities.HttpResponseDeserializingUtil.a = new char[]
			{
				'\r',
				'\n'
			};
		}

		// Token: 0x0400008E RID: 142
		private static readonly char[] a;
	}
}
