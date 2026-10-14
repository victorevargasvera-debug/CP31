using System;
using System.Net;
using System.Threading;
using Motorola.Common.Communication.AmpConfigPackage;
using Motorola.Common.Communication.AmpRequest;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Utils
{
	// Token: 0x0200002F RID: 47
	public class AmpRequestRepeater
	{
		// Token: 0x06000185 RID: 389 RVA: 0x00026CA0 File Offset: 0x00024EA0
		public AmpRequestRepeater(global::Motorola.Common.Communication.IMessageExecutor messageExecutor, global::System.TimeSpan defaultRetryAfter)
		{
			this.a = messageExecutor;
			this.b = defaultRetryAfter;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00026CC4 File Offset: 0x00024EC4
		public T RepeatRequest<T>(T request, int maxRetriesOnServiceUnavailable = 3) where T : global::Motorola.Common.Communication.AmpRequest.HttpAmpMessageBase
		{
			int a_ = 15;
			switch (0)
			{
			case 0:
				goto IL_6D;
			}
			int num;
			short num2;
			int num3;
			for (;;)
			{
				IL_13:
				global::System.TimeSpan? retryAfter2;
				global::System.TimeSpan value;
				switch (num)
				{
				case 0:
					goto IL_39D;
				case 1:
					goto IL_174;
				case 2:
					request.RetryAfter = new global::System.TimeSpan?(this.b);
					num2 = (short)796524562;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_357;
				case 4:
					if (num3 < maxRetriesOnServiceUnavailable - 1)
					{
						num2 = (short)613351426;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3C4;
				case 5:
					num2 = (short)789839880;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num2 = (short)1355546636;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
				{
					if (num3 >= maxRetriesOnServiceUnavailable)
					{
						num2 = (short)270008323;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					this.a.SendAndReceiveMessage(request);
					global::System.TimeSpan? retryAfter = request.RetryAfter;
					num2 = (short)143130640;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 8:
					if (request.ResponseMessage.StatusCode == global::System.Net.HttpStatusCode.BadRequest)
					{
						num2 = (short)636223501;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3C4;
				case 9:
					retryAfter2 = request.RetryAfter;
					num2 = (short)170197009;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					goto IL_2DC;
				case 11:
					goto IL_2DC;
				case 12:
					value = this.b;
					goto IL_1FF;
				case 13:
					num2 = (short)558759940;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					if (retryAfter2 != null)
					{
						num2 = (short)1376714752;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return request;
				case 15:
					goto IL_174;
				case 16:
				{
					if (!(request is global::Motorola.Common.Communication.AmpRequest.HttpAmpPostConfigPackageRequest))
					{
						num2 = (short)1997668357;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::System.TimeSpan? retryAfter;
					request.RetryAfter = retryAfter;
					num2 = (short)1905786891;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 17:
					if (!(retryAfter2.Value < this.b))
					{
						num2 = (short)1906638854;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					retryAfter2 = request.RetryAfter;
					num2 = (short)1089470465;
					if (num2 != 0)
					{
					}
					num2 = (short)1341653011;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					goto IL_2DC;
				case 19:
					value = retryAfter2.Value;
					goto IL_1FF;
				case 20:
					if (retryAfter2 != null)
					{
						num2 = (short)369098761;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_357;
				}
				goto IL_6D;
				IL_174:
				num2 = (short)954925063;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1FF:
				global::System.Threading.Thread.Sleep(value);
				num3++;
				num2 = (short)832150266;
				short num4 = num2;
				num2 = (short)445356794;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num2 = (short)2003107840;
					if (num2 != 0)
					{
					}
					num2 = (short)650838016;
					short num5 = num2;
					num2 = (short)1472266255;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				IL_2DC:
				retryAfter2 = request.RetryAfter;
				num2 = (short)1647771668;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_357:
				retryAfter2 = request.RetryAfter;
				num2 = (short)489619470;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_3C4:
				request.HandleResponse(request.ResponseMessage);
				num2 = (short)1285488650;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_39D:
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(string.Format(global::Motorola.Common.Communication.AmpConfigPackage.PackageGenerator.b("맾怀樂椄戆洈⬊礌怎ㄐ愒瀔琖簘爚欜稞Ġ儢䀤否夨䐪䌬尮吰ጲ匴堶䬸ᬺ䘼༾㱀捂⑄ⅆ㵈⹊㽌潎⍐㙒⅔╖⁘睚絜൞ѠᝢᝤṦ⡨൪ᥬ੮Ͱ卲ᵴቶᡸὺ᡼ൾ뮀ꎂﺄ뚆", a_), request, request.RetryAfter), global::System.Array.Empty<object>());
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_RadioIsInUse);
			IL_6D:
			num3 = 0;
			num2 = (short)1396572161;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x040000CD RID: 205
		private readonly global::Motorola.Common.Communication.IMessageExecutor a;

		// Token: 0x040000CE RID: 206
		private readonly global::System.TimeSpan b;
	}
}
