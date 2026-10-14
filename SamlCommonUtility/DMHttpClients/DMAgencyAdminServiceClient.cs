using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Motorola.Common.CustomException;

namespace Motorola.Security.SamlCommonUtility.DMHttpClients
{
	// Token: 0x02000025 RID: 37
	public class DMAgencyAdminServiceClient : global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMClientBase, global::Motorola.Security.SamlCommonUtility.DMHttpClients.IDMAgencyAdminServiceClient
	{
		// Token: 0x06000078 RID: 120 RVA: 0x00009D2C File Offset: 0x00007F2C
		public DMAgencyAdminServiceClient(global::Motorola.Security.SamlCommonUtility.DMHttpClients.IHttpHandler httpHandler) : base(httpHandler)
		{
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00009D40 File Offset: 0x00007F40
		public global::Motorola.Security.SamlCommonUtility.DMHttpClients.AgencyInfo GetAgencyInfo(string requestUri)
		{
			int a_ = 17;
			short num = (short)1415839744;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_57;
			}
			int num3;
			global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc userProvAgencyInfoDoc;
			global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMAgencyAdminServiceClient.a a;
			for (;;)
			{
				IL_3D:
				switch (num3)
				{
				case 0:
					if (userProvAgencyInfoDoc != null)
					{
						num = (short)74711043;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_19E;
				case 1:
					goto IL_11D;
				case 2:
				{
					num = (short)229179393;
					if (num != 0)
					{
					}
					num = (short)1526109932;
					short num4 = num;
					num = (short)1901696748;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_176;
					default:
						num = (short)1093337088;
						if (num != 0)
						{
						}
						if (string.IsNullOrEmpty(a.b))
						{
							num = (short)1839595521;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1716912132;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					goto IL_152;
				case 4:
					try
					{
						userProvAgencyInfoDoc = global::System.Threading.Tasks.Task.Run<global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc>(new global::System.Func<global::System.Threading.Tasks.Task<global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc>>(a.c)).Result;
						goto IL_11F;
					}
					catch (global::System.Exception systemException)
					{
						throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, systemException);
					}
					goto IL_176;
					IL_11F:
					num = (short)2018836480;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_57;
			}
			IL_11D:
			goto IL_176;
			IL_152:
			return userProvAgencyInfoDoc.Data;
			IL_176:
			throw new global::System.ArgumentNullException();
			IL_19E:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc.b("펻麽邿냁ꯃ냅ꇇ막ꗋꇍ뻏믑뫓뇕鯙믛믝軟臡鷣웥臧蓩諫臭탯雱鯳闵跷韹駻都瓿∁猃朅笇⨉樋愍攏簑瀓", a_));
			IL_57:
			a = new global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMAgencyAdminServiceClient.a();
			a.a = this;
			a.b = requestUri;
			userProvAgencyInfoDoc = null;
			num = (short)1344274434;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_3D;
		}

		// Token: 0x02000028 RID: 40
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x0600007D RID: 125 RVA: 0x00009F4C File Offset: 0x0000814C
			internal global::System.Threading.Tasks.Task<global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc> c()
			{
				short num = (short)46929298;
				short num2 = num;
				num = (short)1450579346;
				switch (num2 == num)
				{
				}
				num = (short)1003028480;
				short num3 = num;
				num = (short)1105788928;
				if (num != 0)
				{
				}
				num = (short)329646081;
				if (num != 0)
				{
				}
				return this.a.handler.GetResourceAsync<global::Motorola.Security.SamlCommonUtility.DMHttpClients.UserProvAgencyInfoDoc>(this.b);
			}

			// Token: 0x040000D1 RID: 209
			public global::Motorola.Security.SamlCommonUtility.DMHttpClients.DMAgencyAdminServiceClient a;

			// Token: 0x040000D2 RID: 210
			public string b;
		}
	}
}
