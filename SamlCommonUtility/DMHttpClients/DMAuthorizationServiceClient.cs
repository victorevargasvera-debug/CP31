using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Motorola.Common.CustomException;

namespace Motorola.Security.SamlCommonUtility.DMHttpClients
{
	// Token: 0x02000029 RID: 41
	public class DMAuthorizationServiceClient : global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMClientBase, global::Motorola.Security.SamlCommonUtility.DMHttpClients.IDMAuthorizationServiceClient
	{
		// Token: 0x0600007E RID: 126 RVA: 0x0000A00C File Offset: 0x0000820C
		public DMAuthorizationServiceClient(global::Motorola.Security.SamlCommonUtility.DMHttpClients.IHttpHandler httpHandler) : base(httpHandler)
		{
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000A020 File Offset: 0x00008220
		public global::System.Collections.Generic.List<global::Motorola.Security.SamlCommonUtility.DMHttpClients.AgencyId> GetAgencyIds(string requestUri)
		{
			int a_ = 13;
			short num = (short)2064908288;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_55;
			}
			int num3;
			global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyIdDoc userProvAgencyIdDoc;
			global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMAuthorizationServiceClient.a a;
			for (;;)
			{
				IL_3B:
				switch (num3)
				{
				case 0:
					if (userProvAgencyIdDoc != null)
					{
						num = (short)268435459;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_19D;
				case 1:
					goto IL_F2;
				case 2:
				{
					num = (short)1841676229;
					short num4 = num;
					num = (short)1102692293;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14F;
					default:
						num = (short)1665597440;
						if (num != 0)
						{
						}
						if (string.IsNullOrEmpty(a.b))
						{
							num = (short)2137915393;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1938227204;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					goto IL_12B;
				case 4:
					try
					{
						userProvAgencyIdDoc = global::System.Threading.Tasks.Task.Run<global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyIdDoc>(new global::System.Func<global::System.Threading.Tasks.Task<global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyIdDoc>>(a.c)).Result;
						goto IL_F4;
					}
					catch (global::System.Exception systemException)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, systemException);
					}
					goto IL_14F;
					IL_F4:
					num = (short)434372608;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_55;
			}
			IL_F2:
			goto IL_14F;
			IL_12B:
			num = (short)292814849;
			if (num != 0)
			{
			}
			return userProvAgencyIdDoc.Data;
			IL_14F:
			throw new global::System.ArgumentNullException();
			IL_19D:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("ힷ骹춽ꖿ냁雅뫇ꗉ뫋ꟍꏏ믑믓룕뇗듙믛ﻝꇟ藡臣裥诧鏩쳫꟭铯틱郳駵鯷迹釻鯽滿瘁␃焅椇礉Ⰻ栍缏朑稓爕", a_));
			IL_55:
			a = new global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMAuthorizationServiceClient.a();
			a.a = this;
			a.b = requestUri;
			userProvAgencyIdDoc = null;
			num = (short)909377538;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_3B;
		}

		// Token: 0x0200002B RID: 43
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06000082 RID: 130 RVA: 0x0000A204 File Offset: 0x00008404
			internal global::System.Threading.Tasks.Task<global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyIdDoc> c()
			{
				short num = (short)1694123051;
				short num2 = num;
				num = (short)1500136491;
				switch (num2 == num)
				{
				}
				num = (short)1146683392;
				short num3 = num;
				num = (short)414842881;
				if (num != 0)
				{
				}
				num = (short)544145408;
				if (num != 0)
				{
				}
				return this.a.handler.GetResourceAsync<global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyIdDoc>(this.b);
			}

			// Token: 0x040000D3 RID: 211
			public global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMAuthorizationServiceClient a;

			// Token: 0x040000D4 RID: 212
			public string b;
		}
	}
}
