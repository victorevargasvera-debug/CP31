using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Motorola.Common.CustomException;

namespace Motorola.Security.SamlCommonUtility.DMHttpClients
{
	// Token: 0x0200002D RID: 45
	public class DMIdPDiscoveryClient : global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMClientBase, global::Motorola.Security.SamlCommonUtility.DMHttpClients.IDMIdPDiscoveryClient
	{
		// Token: 0x06000086 RID: 134 RVA: 0x0000A8B4 File Offset: 0x00008AB4
		public DMIdPDiscoveryClient(global::Motorola.Security.SamlCommonUtility.DMHttpClients.IHttpHandler httpHandler) : base(httpHandler)
		{
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000A8C8 File Offset: 0x00008AC8
		public global::Motorola.Security.SamlCommonUtility.DMHttpClients.OAuthApplicationInfo GetApplicationInfo(string requestUri)
		{
			int a_ = 14;
			switch (0)
			{
			case 0:
				goto IL_3D;
			}
			int num;
			global::Motorola.Security.SamlCommonUtility.DMHttpClients.OAuthProviderDocCollection oauthProviderDocCollection;
			short num2;
			global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMIdPDiscoveryClient.a a;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (oauthProviderDocCollection != null)
					{
						num2 = (short)738525191;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_241;
				case 1:
					goto IL_21A;
				case 2:
					try
					{
						oauthProviderDocCollection = global::System.Threading.Tasks.Task.Run<global::Motorola.Security.SamlCommonUtility.DMHttpClients.OAuthProviderDocCollection>(new global::System.Func<global::System.Threading.Tasks.Task<global::Motorola.Security.SamlCommonUtility.DMHttpClients.OAuthProviderDocCollection>>(a.c)).Result;
						goto IL_F8;
					}
					catch (global::System.Exception systemException)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, systemException);
					}
					goto IL_241;
					IL_F8:
					num2 = (short)898433024;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (string.IsNullOrEmpty(a.b))
					{
						num2 = (short)460849160;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)246349826;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (oauthProviderDocCollection.Docs != null)
					{
						num2 = (short)1415970816;
						short num3 = num2;
						num2 = (short)2076442630;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_241;
				case 5:
					if (oauthProviderDocCollection.Docs.Count > 0)
					{
						num2 = (short)433389569;
						if (num2 != 0)
						{
						}
						num2 = (short)2015625217;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_241;
				case 6:
					goto IL_1B5;
				case 7:
				{
					num2 = (short)1629692223;
					short num4 = num2;
					num2 = (short)127476031;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1B5;
					default:
						num2 = (short)1745027072;
						if (num2 != 0)
						{
						}
						num2 = (short)478019588;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 8:
					goto IL_8B;
				}
				goto IL_3D;
				IL_1B5:
				num2 = (short)636026885;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_8B:
			throw new global::System.ArgumentNullException();
			IL_21A:
			return oauthProviderDocCollection.Docs[0].Data;
			IL_241:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("禮횸鮺ﺾ듀럂귄裈믊뷌ꏎ룐냒듔ꏖ냘듚돜￞裠跢菤裦鯨蛪賬鯮飰鳲鯴ퟶ軸髺軼\udffe最氂瀄椆洈", a_));
			IL_3D:
			a = new global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMIdPDiscoveryClient.a();
			a.a = this;
			a.b = requestUri;
			oauthProviderDocCollection = null;
			num2 = (short)1493434371;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0200002F RID: 47
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x0600008A RID: 138 RVA: 0x0000AB50 File Offset: 0x00008D50
			internal global::System.Threading.Tasks.Task<global::Motorola.Security.SamlCommonUtility.DMHttpClients.OAuthProviderDocCollection> c()
			{
				short num = (short)181799007;
				short num2 = num;
				num = (short)15206495;
				switch (num2 == num)
				{
				}
				num = (short)2090139648;
				if (num != 0)
				{
				}
				num = (short)1930952705;
				if (num != 0)
				{
				}
				num = (short)1255407616;
				short num3 = num;
				return this.a.handler.GetResourceAsync<global::Motorola.Security.SamlCommonUtility.DMHttpClients.OAuthProviderDocCollection>(this.b);
			}

			// Token: 0x040000D5 RID: 213
			public global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMIdPDiscoveryClient a;

			// Token: 0x040000D6 RID: 214
			public string b;
		}
	}
}
