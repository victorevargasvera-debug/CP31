using System;
using System.Net;
using Newtonsoft.Json.Linq;

namespace IdentityModel.Client
{
	// Token: 0x02000050 RID: 80
	public abstract class Response
	{
		// Token: 0x06000160 RID: 352 RVA: 0x00005C0C File Offset: 0x00003E0C
		protected Response(string raw)
		{
			this.Raw = raw;
			try
			{
				this.Json = global::Newtonsoft.Json.Linq.JObject.Parse(raw);
			}
			catch (global::System.Exception exception)
			{
				this.ErrorType = 3;
				this.Exception = exception;
				return;
			}
			if (string.IsNullOrWhiteSpace(this.Error))
			{
				this.HttpStatusCode = 200;
				return;
			}
			this.HttpStatusCode = 400;
			this.ErrorType = 1;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00005C80 File Offset: 0x00003E80
		protected Response(global::System.Exception exception)
		{
			this.Exception = exception;
			this.ErrorType = 3;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00005C98 File Offset: 0x00003E98
		protected Response(global::System.Net.HttpStatusCode statusCode, string reason)
		{
			this.HttpStatusCode = statusCode;
			this.HttpErrorReason = reason;
			if (statusCode != global::System.Net.HttpStatusCode.OK)
			{
				this.ErrorType = 2;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000163 RID: 355 RVA: 0x00005CC0 File Offset: 0x00003EC0
		public string Raw { get; }

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00005CC8 File Offset: 0x00003EC8
		public global::Newtonsoft.Json.Linq.JObject Json { get; }

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000165 RID: 357 RVA: 0x00005CD0 File Offset: 0x00003ED0
		// (set) Token: 0x06000166 RID: 358 RVA: 0x00005CD8 File Offset: 0x00003ED8
		public global::System.Exception Exception { get; set; }

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000167 RID: 359 RVA: 0x00005CE4 File Offset: 0x00003EE4
		public bool IsError
		{
			get
			{
				return !string.IsNullOrEmpty(this.Error);
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000168 RID: 360 RVA: 0x00005CF4 File Offset: 0x00003EF4
		public global::IdentityModel.Client.ResponseErrorType ErrorType { get; }

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000169 RID: 361 RVA: 0x00005CFC File Offset: 0x00003EFC
		public global::System.Net.HttpStatusCode HttpStatusCode { get; }

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600016A RID: 362 RVA: 0x00005D04 File Offset: 0x00003F04
		public string HttpErrorReason { get; }

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600016B RID: 363 RVA: 0x00005D0C File Offset: 0x00003F0C
		public string Error
		{
			get
			{
				if (this.ErrorType == global::IdentityModel.Client.ResponseErrorType.Http)
				{
					return this.HttpErrorReason;
				}
				if (this.ErrorType == global::IdentityModel.Client.ResponseErrorType.Exception)
				{
					return this.Exception.Message;
				}
				return this.TryGet("error");
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x00005D40 File Offset: 0x00003F40
		public string TryGet(string name)
		{
			return this.Json.TryGetString(name);
		}
	}
}
