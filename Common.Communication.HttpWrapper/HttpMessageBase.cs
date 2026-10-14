using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using Motorola.Common.Communication.AmpRequest.Models;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x0200000A RID: 10
	public class HttpMessageBase : global::Motorola.Common.Communication.BaseMessage
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000017 RID: 23 RVA: 0x000034E8 File Offset: 0x000016E8
		// (set) Token: 0x06000018 RID: 24 RVA: 0x0000359C File Offset: 0x0000179C
		public global::System.Net.Http.HttpRequestMessage RequestMessage
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1901592577;
				if (num != 0)
				{
				}
				num = (short)1338217941;
				short num2 = num;
				num = (short)40211925;
				switch (num2 == num)
				{
				}
				num = (short)1151664128;
				short num3 = num;
				num = (short)434438144;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)163053569;
				if (num != 0)
				{
				}
				num = (short)2019244351;
				short num2 = num;
				num = (short)1523530047;
				switch (num2 == num)
				{
				}
				num = (short)627965952;
				short num3 = num;
				num = (short)1515651072;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000019 RID: 25 RVA: 0x00003650 File Offset: 0x00001850
		// (set) Token: 0x0600001A RID: 26 RVA: 0x00003700 File Offset: 0x00001900
		public global::System.Net.Http.HttpResponseMessage ResponseMessage
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)610861486;
				short num2 = num;
				num = (short)2097545646;
				switch (num2 == num)
				{
				}
				num = (short)1192034305;
				if (num != 0)
				{
				}
				num = (short)131268608;
				short num3 = num;
				num = (short)422576128;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			internal set
			{
				short num = (short)2080443028;
				short num2 = num;
				num = (short)179374740;
				switch (num2 == num)
				{
				}
				num = (short)287965185;
				if (num != 0)
				{
				}
				num = (short)37552128;
				short num3 = num;
				num = (short)255918080;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000037B4 File Offset: 0x000019B4
		public global::System.Net.HttpStatusCode ResultCode
		{
			get
			{
				short num = (short)1358926935;
				short num2 = num;
				num = (short)2127598679;
				switch (num2 == num)
				{
				}
				num = (short)699990017;
				if (num != 0)
				{
				}
				num = (short)1757675520;
				short num3 = num;
				num = (short)417923072;
				if (num != 0)
				{
				}
				return this.ResponseMessage.StatusCode;
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00003868 File Offset: 0x00001A68
		protected HttpMessageBase(global::System.Net.Http.HttpMethod method, global::System.Uri relativePath)
		{
			this.RequestMessage = new global::System.Net.Http.HttpRequestMessage(method, relativePath);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003888 File Offset: 0x00001A88
		protected HttpMessageBase(global::System.Net.Http.HttpMethod method, string relativePath)
		{
			this.RequestMessage = new global::System.Net.Http.HttpRequestMessage(method, relativePath);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x000038A8 File Offset: 0x00001AA8
		public override int BuildCommandMessage(byte[] sendBuffer)
		{
			short num = (short)301909118;
			short num2 = num;
			num = (short)1733739646;
			switch (num2 == num)
			{
			}
			num = (short)1647771649;
			if (num != 0)
			{
			}
			num = (short)894369792;
			short num3 = num;
			num = (short)132972544;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003958 File Offset: 0x00001B58
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)1950089217;
			if (num != 0)
			{
			}
			num = (short)1481348379;
			short num2 = num;
			num = (short)688166171;
			switch (num2 == num)
			{
			}
			num = (short)1822425088;
			short num3 = num;
			num = (short)905183232;
			if (num != 0)
			{
			}
			base._myReplyBuffer = new byte[length];
			global::System.Array.Copy(replyBuffer, 0, base._myReplyBuffer, offset, length);
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003A1C File Offset: 0x00001C1C
		public virtual void HandleResponse(global::System.Net.Http.HttpResponseMessage response)
		{
			short num = (short)1467725186;
			short num2 = num;
			num = (short)1839904130;
			switch (num2 == num)
			{
			}
			num = (short)495845377;
			if (num != 0)
			{
			}
			num = (short)729743360;
			short num3 = num;
			num = (short)2037317632;
			if (num != 0)
			{
			}
			this.ResponseMessage = response;
			this.HandleResponseStatusCode(response);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003AD4 File Offset: 0x00001CD4
		protected virtual void HandleResponseStatusCode(global::System.Net.Http.HttpResponseMessage response)
		{
			int a_ = 2;
			short num;
			if (!response.IsSuccessStatusCode)
			{
				num = (short)1348877431;
				short num2 = num;
				num = (short)342965367;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)537264128;
					if (num != 0)
					{
					}
					num = (short)155975681;
					if (num != 0)
					{
					}
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.HttpReplyUnexpectedStatus, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("톾꓀믂뗄ꋆ꫈뿊꣌ꯎ鯒臔菖觘ﯚ꿜뫞鋠鏢諤触髨軪췬鳮藰鋲致苶諸\udbfa黼郾攀昂㼄✆", a_) + ((int)response.StatusCode).ToString());
				}
			}
			num = (short)15597568;
			short num3 = num;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003BC0 File Offset: 0x00001DC0
		public virtual global::System.Net.Http.HttpRequestMessage CloneRequest()
		{
			short num = (short)1114112001;
			if (num != 0)
			{
			}
			num = (short)2058485760;
			switch (num)
			{
			default:
			{
				global::System.Net.Http.HttpRequestMessage httpRequestMessage = new global::System.Net.Http.HttpRequestMessage(this.RequestMessage.Method, this.RequestMessage.RequestUri)
				{
					Version = this.RequestMessage.Version,
					Content = this.CreateRequestContent()
				};
				global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, object>> enumerator = this.RequestMessage.Properties.GetEnumerator();
				try
				{
					num = (short)374538242;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 1:
							goto IL_307;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_243;
							}
							continue;
						case 3:
							if (!enumerator.MoveNext())
							{
								num = (short)579928068;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_27A;
						case 4:
						{
							num = (short)652892801;
							short num3 = num;
							num = (short)1369594497;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_27A;
							default:
								num = (short)1036713984;
								if (num != 0)
								{
								}
								num = (short)510787585;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_245:
						num = (short)1581383683;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_243:
						goto IL_245;
						IL_27A:
						global::System.Collections.Generic.KeyValuePair<string, object> item = enumerator.Current;
						httpRequestMessage.Properties.Add(item);
						num = (short)28901376;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_307:
					goto IL_1CB;
				}
				finally
				{
					num = (short)895680513;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_373;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_33E;
							}
							continue;
						case 2:
							enumerator.Dispose();
							num = (short)1117782016;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_33E:
						if (enumerator == null)
						{
							break;
						}
						num = (short)94437378;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_373:;
				}
				return httpRequestMessage;
				for (;;)
				{
					IL_1CB:
					num = (short)1206714368;
					short num4 = num;
					global::System.Collections.Generic.IEnumerator<global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.IEnumerable<string>>> enumerator2 = this.RequestMessage.Headers.GetEnumerator();
					try
					{
						num = (short)1039400962;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 1:
								goto IL_15B;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_CE;
								}
								continue;
							case 3:
							{
								if (!enumerator2.MoveNext())
								{
									num = (short)785317892;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.IEnumerable<string>> keyValuePair = enumerator2.Current;
								httpRequestMessage.Headers.TryAddWithoutValidation(keyValuePair.Key, keyValuePair.Value);
								num = (short)2095316992;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								num = (short)1791295489;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_D0:
							num = (short)298647555;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_CE:
							goto IL_D0;
						}
						IL_15B:
						break;
					}
					finally
					{
						num = (short)2033713153;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_1C8;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_193;
								}
								continue;
							case 2:
								enumerator2.Dispose();
								num = (short)852951040;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_193:
							if (enumerator2 == null)
							{
								break;
							}
							num = (short)575930370;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1C8:;
					}
				}
				return httpRequestMessage;
			}
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003F78 File Offset: 0x00002178
		protected virtual global::System.Net.Http.HttpContent CreateRequestContent()
		{
			short num;
			if (this.RequestMessage.Content == null)
			{
				num = (short)104176322;
				short num2 = num;
				num = (short)638687938;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)448135168;
					if (num != 0)
					{
					}
					break;
				}
				return null;
			}
			num = (short)208076800;
			short num3 = num;
			num = (short)2102657025;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x04000011 RID: 17
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Net.Http.HttpRequestMessage a;

		// Token: 0x04000012 RID: 18
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Net.Http.HttpResponseMessage b;
	}
}
