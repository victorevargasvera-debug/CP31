using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Motorola.Security.SamlCommonUtility.DMHttpClients
{
	// Token: 0x0200001F RID: 31
	public class CommonHttpClientHandler : global::Motorola.Security.SamlCommonUtility.DMHttpClients.IHttpHandler
	{
		// Token: 0x06000068 RID: 104 RVA: 0x00008A60 File Offset: 0x00006C60
		public CommonHttpClientHandler(global::System.Net.Http.HttpClient httpClient)
		{
			if (httpClient == null)
			{
				throw new global::System.ArgumentNullException();
			}
			this.a = httpClient;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00008A88 File Offset: 0x00006C88
		public global::System.Threading.Tasks.Task<T> GetResourceAsync<T>(string requestUri)
		{
			short num = (short)391563264;
			short num2 = num;
			num = (short)256100352;
			switch (num2 == num)
			{
			}
			num = (short)623443968;
			short num3 = num;
			num = (short)1468465153;
			if (num != 0)
			{
			}
			num = (short)379453440;
			if (num != 0)
			{
			}
			global::Motorola.Security.SamlCommonUtility.DMHttpClients.CommonHttpClientHandler<T>.a a;
			a.b = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<T>.Create();
			a.c = this;
			a.d = requestUri;
			a.a = -1;
			a.b.Start<global::Motorola.Security.SamlCommonUtility.DMHttpClients.CommonHttpClientHandler<T>.a>(ref a);
			return a.b.Task;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00008B74 File Offset: 0x00006D74
		public global::System.Threading.Tasks.Task<global::System.Collections.Generic.List<T>> GetResourceListAsync<T>(string requestUri)
		{
			short num = (short)1013121941;
			short num2 = num;
			num = (short)528876437;
			switch (num2 == num)
			{
			}
			num = (short)1900085248;
			short num3 = num;
			num = (short)1514668032;
			if (num != 0)
			{
			}
			num = (short)1573126145;
			if (num != 0)
			{
			}
			global::Motorola.Security.SamlCommonUtility.DMHttpClients.CommonHttpClientHandler<T>.b b;
			b.b = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<global::System.Collections.Generic.List<T>>.Create();
			b.c = this;
			b.d = requestUri;
			b.a = -1;
			b.b.Start<global::Motorola.Security.SamlCommonUtility.DMHttpClients.CommonHttpClientHandler<T>.b>(ref b);
			return b.b.Task;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00008C5C File Offset: 0x00006E5C
		private global::System.Threading.Tasks.Task<string> a(string requestUri)
		{
			short num = (short)1752890205;
			short num2 = num;
			num = (short)1367735133;
			switch (num2 == num)
			{
			}
			num = (short)1101201408;
			short num3 = num;
			num = (short)1438515201;
			if (num != 0)
			{
			}
			num = (short)168493056;
			if (num != 0)
			{
			}
			global::Motorola.Security.SamlCommonUtility.DMHttpClients.CommonHttpClientHandler.c c;
			c.b = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<string>.Create();
			c.d = this;
			c.c = requestUri;
			c.a = -1;
			c.b.Start<global::Motorola.Security.SamlCommonUtility.DMHttpClients.CommonHttpClientHandler.c>(ref c);
			return c.b.Task;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00008D44 File Offset: 0x00006F44
		public global::System.Threading.Tasks.Task PutResourceAsync(global::System.Uri requestUri, global::System.Net.Http.HttpContent httpContent)
		{
			short num = (short)528773298;
			short num2 = num;
			num = (short)1537110194;
			switch (num2 == num)
			{
			}
			num = (short)1990656000;
			short num3 = num;
			num = (short)1447559168;
			if (num != 0)
			{
			}
			num = (short)1532493825;
			if (num != 0)
			{
			}
			global::Motorola.Security.SamlCommonUtility.DMHttpClients.CommonHttpClientHandler.d d;
			d.b = global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder.Create();
			d.e = this;
			d.c = requestUri;
			d.d = httpContent;
			d.a = -1;
			d.b.Start<global::Motorola.Security.SamlCommonUtility.DMHttpClients.CommonHttpClientHandler.d>(ref d);
			return d.b.Task;
		}

		// Token: 0x040000B9 RID: 185
		private global::System.Net.Http.HttpClient a;
	}
}
