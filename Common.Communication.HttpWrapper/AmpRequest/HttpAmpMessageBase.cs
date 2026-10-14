using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using Motorola.Common.Communication.AmpRequest.Models;
using Motorola.Common.Communication.AmpRequest.Utilities;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.AmpRequest
{
	// Token: 0x02000007 RID: 7
	public class HttpAmpMessageBase : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x06000009 RID: 9 RVA: 0x000024D0 File Offset: 0x000006D0
		public HttpAmpMessageBase(global::System.Net.Http.HttpMethod method, string relativePath) : base(method, relativePath)
		{
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000024E8 File Offset: 0x000006E8
		// (set) Token: 0x0600000B RID: 11 RVA: 0x00002594 File Offset: 0x00000794
		public bool HasContent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)564330497;
				if (num != 0)
				{
				}
				num = (short)817988734;
				short num2 = num;
				num = (short)1996326014;
				switch (num2 == num)
				{
				}
				num = (short)67502080;
				if (num != 0)
				{
				}
				num = (short)1207304192;
				short num3 = num;
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2098230321;
				short num2 = num;
				num = (short)826373169;
				switch (num2 == num)
				{
				}
				num = (short)1889075200;
				if (num != 0)
				{
				}
				num = (short)1229455361;
				if (num != 0)
				{
				}
				num = (short)1029636096;
				short num3 = num;
				this.b = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002648 File Offset: 0x00000848
		// (set) Token: 0x0600000D RID: 13 RVA: 0x000026F8 File Offset: 0x000008F8
		public global::System.TimeSpan? RetryAfter
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)972302183;
				short num2 = num;
				num = (short)1933715303;
				switch (num2 == num)
				{
				}
				num = (short)1375862784;
				if (num != 0)
				{
				}
				num = (short)1162018817;
				if (num != 0)
				{
				}
				num = (short)910753792;
				short num3 = num;
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1781654832;
				short num2 = num;
				num = (short)1402398000;
				switch (num2 == num)
				{
				}
				num = (short)289275905;
				if (num != 0)
				{
				}
				num = (short)1024196608;
				if (num != 0)
				{
				}
				num = (short)2004484096;
				short num3 = num;
				this.c = value;
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000027A8 File Offset: 0x000009A8
		protected override void HandleResponseStatusCode(global::System.Net.Http.HttpResponseMessage response)
		{
			short num = (short)365690889;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					this.a(response, global::Motorola.Common.CustomException.CommonErrorCode.GenericError);
					num = (short)1535639556;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return;
				case 2:
					num = (short)2122776587;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)1521156102;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_1F4;
				case 5:
					goto IL_240;
				case 6:
				{
					global::System.Net.HttpStatusCode statusCode;
					if (statusCode != global::System.Net.HttpStatusCode.InternalServerError)
					{
						num = (short)1854013442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_91;
				}
				case 7:
				{
					if (response.IsSuccessStatusCode)
					{
						return;
					}
					num = (short)1680304304;
					short num3 = num;
					num = (short)1923573936;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1F9;
					default:
						num = (short)1682505728;
						if (num != 0)
						{
						}
						num = (short)812122122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 8:
					num = (short)975962112;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_58;
					}
					continue;
				case 10:
				{
					global::System.Net.HttpStatusCode statusCode = response.StatusCode;
					num = (short)1432420364;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 11:
				{
					global::System.Net.HttpStatusCode statusCode;
					if (statusCode != global::System.Net.HttpStatusCode.ServiceUnavailable)
					{
						num = (short)145293320;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					this.b(response);
					num = (short)995164161;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 12:
				{
					global::System.Net.HttpStatusCode statusCode;
					if (statusCode != global::System.Net.HttpStatusCode.BadRequest)
					{
						num = (short)1693843459;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F9;
				}
				}
				IL_58:
				global::System.Net.Http.Headers.HttpResponseHeaders headers = response.Headers;
				global::System.TimeSpan? retryAfter;
				if (headers == null)
				{
					retryAfter = null;
				}
				else
				{
					global::System.Net.Http.Headers.RetryConditionHeaderValue retryAfter2 = headers.RetryAfter;
					retryAfter = ((retryAfter2 != null) ? retryAfter2.Delta : null);
				}
				this.RetryAfter = retryAfter;
				num = (short)416874503;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1F9:
				this.a(response);
				num = (short)30932992;
				short num4 = num;
				num = (short)1276706821;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_91:
			this.a(response, global::Motorola.Common.CustomException.CommonErrorCode.GenericError);
			return;
			IL_1F4:
			return;
			IL_240:
			num = (short)1816526849;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002A7C File Offset: 0x00000C7C
		private void b(global::System.Net.Http.HttpResponseMessage A_0)
		{
			short num = (short)389349376;
			short num2 = num;
			num = (short)1871395341;
			short num3 = num;
			num = (short)1445411341;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)787349504;
				if (num != 0)
				{
				}
				num = (short)2056781825;
				if (num != 0)
				{
				}
				global::System.TimeSpan valueOrDefault = A_0.Headers.RetryAfter.Delta.GetValueOrDefault();
				if (!global::Motorola.Common.Communication.AmpRequest.HttpAmpMessageBase.a.Contains(valueOrDefault.TotalSeconds))
				{
					this.RetryAfter = new global::System.TimeSpan?(valueOrDefault);
					return;
				}
				break;
			}
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_RadioIsInUse);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002B6C File Offset: 0x00000D6C
		private void a(global::System.Net.Http.HttpResponseMessage A_0, global::Motorola.Common.CustomException.CommonErrorCode A_1)
		{
			int a_ = 5;
			short num = (short)173146113;
			if (num != 0)
			{
			}
			num = (short)461897728;
			short num2 = num;
			num = (short)1920961483;
			short num3 = num;
			num = (short)1196264395;
			switch (num3 == num)
			{
			}
			num = (short)1223753728;
			if (num != 0)
			{
			}
			string text = string.Format(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("閿곁ꇃ뻅룇꿉꿋뫍뗏뛑黕賗軙賛ﻝ鋟蟡韣雥蟧蓩鿫语탯臱胳韵賷迹迻\udefd揿洁怃挅㈇⨉看㸍洏", a_), (int)A_0.StatusCode);
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(text, global::System.Array.Empty<object>());
			throw new global::Motorola.Common.CustomException.CommonException(A_1, text);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002C58 File Offset: 0x00000E58
		private void a(global::System.Net.Http.HttpResponseMessage A_0)
		{
			int a_ = 0;
			short num = (short)2062352384;
			int num2 = (int)((global::System.IntPtr)num);
			string text3;
			for (;;)
			{
				string text;
				string text2;
				global::Motorola.Common.Communication.AmpRequest.Models.ErrorResponse errorResponse;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_51;
					}
					continue;
				case 1:
					text = null;
					goto IL_1FA;
				case 2:
					if (!string.IsNullOrEmpty(text2))
					{
						num = (short)734527493;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_120;
				case 3:
					goto IL_156;
				case 4:
					goto IL_10C;
				case 5:
					text3 = string.Format(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("펼\udabe맀돂ꃄ꓆뷈껊꧌駐蟒臔蟖律꧚룜곞釠賢诤铦賨쯪黬鯮郰蟲胴蓶\ud9f8飺鋼鯾搀㤂┄簆㤈瘊ⴌ砎砐朒純㜖琘縚渜氞䀠䐢䀤ᴦन倪ᰬ刮", a_), (int)A_0.StatusCode, text2);
					num = (short)773390344;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					text3 = string.Format(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("펼\udabe맀돂ꃄ꓆뷈껊꧌駐蟒臔蟖律꧚룜곞釠賢诤铦賨쯪黬鯮郰蟲胴蓶\ud9f8飺鋼鯾搀㤂┄簆㤈瘊ⴌ砎砐朒純㜖琘縚渜氞䀠䐢䀤ᴦन倪ᰬ刮ᄰ刲嬴匶ᤸ帺似䴾⹀ㅂ㙄絆楈お罌㉎", a_), (int)A_0.StatusCode, errorResponse.Message, this.a(errorResponse.Errors));
					num = (short)717488132;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (errorResponse != null)
					{
						num = (short)1774190598;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)672464897;
					if (num != 0)
					{
					}
					num = (short)487784450;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_1F8;
				}
				goto IL_51;
				IL_120:
				text3 = string.Format(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("펼\udabe맀돂ꃄ꓆뷈껊꧌駐蟒臔蟖律꧚룜곞釠賢诤铦賨쯪黬鯮郰蟲胴蓶\ud9f8飺鋼鯾搀㤂┄簆㤈瘊", a_), (int)A_0.StatusCode);
				num = (short)1445068803;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_51:
				global::System.Net.Http.HttpContent content = A_0.Content;
				if (content == null)
				{
					num = (short)121281565;
					short num3 = num;
					num = (short)1463327773;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_120;
					default:
						num = (short)1356529664;
						if (num != 0)
						{
						}
						num = (short)423559169;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
				}
				else
				{
					text = content.ReadAsStringAsync().Result;
				}
				IL_1FA:
				text2 = text;
				errorResponse = global::Motorola.Common.Communication.JSONHelper.TryDeserializeJson<global::Motorola.Common.Communication.AmpRequest.Models.ErrorResponse>(text2);
				num = (short)1775960071;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_10C:
			IL_156:
			IL_1F8:
			num = (short)1653276672;
			short num4 = num;
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(text3, global::System.Array.Empty<object>());
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, text3);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002EE4 File Offset: 0x000010E4
		public override int BuildCommandMessage(byte[] sendBuffer)
		{
			short num = (short)1027023277;
			short num2 = num;
			num = (short)315171245;
			switch (num2 == num)
			{
			default:
			{
				num = (short)633470976;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1865940993;
			if (num != 0)
			{
			}
			num = (short)1680080896;
			if (num != 0)
			{
			}
			byte[] array = this.a(this);
			global::System.Array.Copy(array, sendBuffer, array.Length);
			return array.Length;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002FA0 File Offset: 0x000011A0
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)1858714056;
			short num2 = num;
			num = (short)1080080840;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1171980288;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1359675393;
			if (num != 0)
			{
			}
			num = (short)1983774720;
			if (num != 0)
			{
			}
			global::System.Net.Http.HttpResponseMessage a_;
			global::Motorola.Common.Communication.AmpRequest.Utilities.HttpResponseDeserializingUtil.TryGetResponseMessage(replyBuffer, out a_);
			base.ResponseMessage = a_;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00003058 File Offset: 0x00001258
		private byte[] a(global::Motorola.Common.Communication.IMessage A_0)
		{
			int a_ = 14;
			short num = (short)864878592;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4B;
				}
				global::Motorola.Common.Communication.AmpRequest.HttpAmpMessageBase httpAmpMessageBase;
				global::System.Text.StringBuilder stringBuilder;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						goto IL_D5;
					case 1:
					{
						if (httpAmpMessageBase == null)
						{
							num = (short)1200422912;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string method = httpAmpMessageBase.RequestMessage.Method.Method;
						string absolutePath = httpAmpMessageBase.RequestMessage.RequestUri.AbsolutePath;
						string host = httpAmpMessageBase.RequestMessage.RequestUri.Host;
						int port = httpAmpMessageBase.RequestMessage.RequestUri.Port;
						stringBuilder = new global::System.Text.StringBuilder();
						stringBuilder.AppendLine(method + global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("", a_) + absolutePath + global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("菊駌鯎臐ﳒ淪", a_));
						stringBuilder.AppendLine(string.Format(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("臈꓊뻌믎껔ꓘꛜ鳠", a_), host, port));
						stringBuilder.AppendLine(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("裈꣊껌꫎ꇐ꟒鋖럘룚닜믞裠跢苤\udde6짨諪鷬鿮鷰髲雴零跸鋺鋼釾⸀椂瘄栆月", a_));
						stringBuilder.AppendLine(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("諈꓊ꏌꇎ듐냒ꇔ뻖뛘뗚￞諠蛢胤韦쓨諪臬蛮蟰雲", a_));
						num = (short)118489092;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_17F;
					case 3:
						stringBuilder.AppendLine(string.Format(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("諈꓊ꏌ믎듐뷒ꇔ𥳐跘ꋚ규뫞\udbe0쏢黤ퟦ铨", a_), httpAmpMessageBase.RequestMessage.Content.Headers.ContentType));
						stringBuilder.AppendLine(string.Format(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("諈꓊ꏌ믎듐뷒ꇔ𥳐闘뻚돜룞闠询\udfe4쟦鋨\udbea郬", a_), httpAmpMessageBase.RequestMessage.Content.Headers.ContentLength));
						num = (short)1483145218;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_262;
					}
					goto IL_4B;
				}
				IL_D5:
				num = (short)1837563904;
				short num3 = num;
				num = (short)1204617217;
				if (num != 0)
				{
				}
				throw new global::System.ArgumentException(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("諈꓊료ꏎ뗐믔룖귘ﯚ뻜뻞鋠韢엤鏦臨軪췬鿮菰鳲菴黶鷸黺駼\udffe氀昂瘄理栈氊栌⼎攐簒㔔弖洘漚洜帞䰠匢栤䈦娨堪䰬䠮吰焲吴䐶尸ᔺ", a_), global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("꓈룊꫌", a_));
				IL_17F:
				goto IL_2D5;
				IL_4B:
				httpAmpMessageBase = (A_0 as global::Motorola.Common.Communication.AmpRequest.HttpAmpMessageBase);
				num = (short)971774242;
				short num4 = num;
				num = (short)346036514;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_262:
					if (httpAmpMessageBase.RequestMessage.Content != null)
					{
						num = (short)568786947;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_30;
					}
					break;
				default:
					num = (short)678035456;
					if (num != 0)
					{
					}
					num = (short)1047330817;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				IL_2D5:
				stringBuilder.AppendLine();
				return global::System.Text.Encoding.UTF8.GetBytes(stringBuilder.ToString());
			}
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00003354 File Offset: 0x00001554
		private string a(global::System.Collections.Generic.IEnumerable<string> A_0)
		{
			int a_ = 5;
			short num = (short)1660092416;
			short num2 = num;
			num = (short)576252736;
			short num3 = num;
			num = (short)1601760064;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)2073952256;
				if (num != 0)
				{
				}
				if (A_0 == null)
				{
					return string.Empty;
				}
				break;
			}
			num = (short)1573781505;
			if (num != 0)
			{
			}
			return string.Join(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("", a_), A_0);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00003428 File Offset: 0x00001628
		// Note: this type is marked as 'beforefieldinit'.
		static HttpAmpMessageBase()
		{
			short num = (short)2070478849;
			if (num != 0)
			{
			}
			num = (short)1008795648;
			short num2 = num;
			num = (short)582821869;
			short num3 = num;
			num = (short)2071275501;
			switch (num3 == num)
			{
			}
			num = (short)850198528;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.AmpRequest.HttpAmpMessageBase.a = new double[]
			{
				60.0,
				600.0,
				6000.0,
				60000.0,
				86400.0
			};
		}

		// Token: 0x04000006 RID: 6
		private static readonly double[] a;

		// Token: 0x04000007 RID: 7
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool b;

		// Token: 0x04000008 RID: 8
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.TimeSpan? c;
	}
}
