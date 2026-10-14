using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using CommonUtility;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommonUtil.Extensions;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.CustomException;
using Org.BouncyCastle.Crypto.Tls;

namespace Motorola.Common.Communication.TLS.TlsPskForAstro
{
	// Token: 0x02000021 RID: 33
	public class TlsHandler : global::Motorola.Common.Communication.TLS.TlsPskForAstro.ITlsHandler
	{
		// Token: 0x060000B8 RID: 184 RVA: 0x0000A934 File Offset: 0x00008B34
		public TlsHandler(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe pipe, global::Motorola.Common.Communication.TLS.TlsPskForAstro.ITlsConnectClientFactory connectClientFactory, global::Motorola.Common.Communication.TLS.TlsPskForAstro.ITlsIdentityClient identityClient, string psk)
		{
			this.h = pipe;
			this.a = connectClientFactory;
			this.b = identityClient;
			this.c = psk;
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000B9 RID: 185 RVA: 0x0000A974 File Offset: 0x00008B74
		// (set) Token: 0x060000BA RID: 186 RVA: 0x0000AA24 File Offset: 0x00008C24
		public bool IsSecurityLayerInitialized
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1224185660;
				short num2 = num;
				num = (short)1518442300;
				switch (num2 == num)
				{
				}
				num = (short)1765670913;
				if (num != 0)
				{
				}
				num = (short)575799296;
				short num3 = num;
				num = (short)575733760;
				if (num != 0)
				{
				}
				return this.g;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1963196417;
				if (num != 0)
				{
				}
				num = (short)1837099598;
				short num2 = num;
				num = (short)354478670;
				switch (num2 == num)
				{
				}
				num = (short)728629248;
				short num3 = num;
				num = (short)2077163520;
				if (num != 0)
				{
				}
				this.g = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000BB RID: 187 RVA: 0x0000AAD4 File Offset: 0x00008CD4
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe Pipe
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1764128828;
				short num2 = num;
				num = (short)109017148;
				switch (num2 == num)
				{
				}
				num = (short)1171259392;
				if (num != 0)
				{
				}
				num = (short)1298399232;
				short num3 = num;
				num = (short)832372737;
				if (num != 0)
				{
				}
				return this.h;
			}
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000AB84 File Offset: 0x00008D84
		public void Connect(int timeout = -1)
		{
			int a_ = 16;
			short num = (short)1237909504;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				for (;;)
				{
					IL_27:
					num = (short)858783744;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_74;
					}
					byte[] identityHint;
					for (;;)
					{
						IL_59:
						switch (num2)
						{
						case 0:
							goto IL_12A;
						case 1:
						{
							string input;
							if (global::CommonUtility.TlsPskUtility.TryGetDefaultPsk(identityHint, out input))
							{
								num = (short)2038497283;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							byte[] psk = this.c.ToBch();
							num = (short)179896324;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							try
							{
								byte[] psk;
								global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient tlsClient = new global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient(new global::Org.BouncyCastle.Crypto.Tls.BasicTlsPskIdentity(identityHint, psk));
								this._tlsProtocol.Connect(tlsClient);
								global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteInfo(global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient.b("漺儼䰾慀⁂㝄≆⡈㽊⡌⭎煐げ㩔㥖㝘㹚㹜⭞ࡠౢ୤", a_), global::System.Array.Empty<object>());
								return;
							}
							catch (global::Org.BouncyCastle.Crypto.Tls.TlsException ex)
							{
								global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient.b("砺刼儾⽀♂♄㍆⁈⑊⍌潎㝐㉒㱔㭖ⱘ⥚㡜㭞䅠ᑢ౤፦Ũ䭪l੮ɰrᑴၶᱸ䅺嵼Ѿ놀ﺂ", a_), new object[]
								{
									ex.Message
								});
								throw global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsHandler.a(ex);
							}
							goto IL_12A;
						case 3:
						{
							string input;
							byte[] psk = input.ToBch();
							num = (short)348454912;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							num = (short)1635581953;
							if (num != 0)
							{
							}
							goto IL_12A;
						}
						break;
						IL_12A:
						num = (short)25451354;
						short num4 = num;
						num = (short)789666650;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_27;
						default:
							num = (short)476512256;
							if (num != 0)
							{
							}
							this.Pipe.OpenPort(timeout);
							this.a();
							num = (short)542179330;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_74:
					identityHint = this.b.GetIdentityHint();
					num = (short)1567162369;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_59;
				}
				return;
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000ADC0 File Offset: 0x00008FC0
		private void a()
		{
			int a_ = 0;
			short num;
			try
			{
				num = (short)1676355489;
				short num2 = num;
				num = (short)330770337;
				switch (num2 == num)
				{
				}
				num = (short)1260388352;
				if (num != 0)
				{
				}
				this._tlsProtocol = this.a.Create(this.Pipe.GetStream());
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteInfo(global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient.b("缪䄬尮ᄰ瀲头帶尸唺䤼Ἶᅀㅂ⩄㍆♈⡊≌⍎煐㭒㑔⑖祘㥚㡜㩞འ䍢౤०hὪѬ๮ᵰᩲུቶᵸ", a_), global::System.Array.Empty<object>());
				this.IsSecurityLayerInitialized = true;
			}
			catch
			{
				global::Motorola.Common.CustomException.CommonException ex = new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Initialize_Failed);
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(ex.Message, global::System.Array.Empty<object>());
				throw ex;
			}
			num = (short)1681129472;
			short num3 = num;
			num = (short)1440743425;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000AEE8 File Offset: 0x000090E8
		public int ReceiveData(byte[] buffer, int start, int timeout)
		{
			short num;
			int num3;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				int num5;
				for (;;)
				{
					IL_0A:
					num = (short)948499027;
					short num2 = num;
					num = (short)1244525139;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A3;
					default:
						num = (short)2067595264;
						if (num != 0)
						{
						}
						num = (short)2078867457;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							num = (short)384761862;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							return 0;
						case 2:
							this._tlsProtocol.Stream.ReadTimeout = timeout;
							num = (short)1075707908;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							if (this._tlsProtocol.Stream.CanTimeout)
							{
								num = (short)530251776;
								short num4 = num;
								num = (short)1195180032;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_111;
						case 4:
							goto IL_111;
						case 5:
							if (num5 <= 0)
							{
								num = (short)1239613441;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1B6;
						case 6:
							if (timeout > 0)
							{
								num = (short)1619197954;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_111;
						}
						goto IL_9D;
						IL_111:
						num5 = this.ReceivePacketDataSize();
						num = (short)396820485;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				return 0;
				IL_1B6:
				return this.ReceiveDataFromBaseStream(buffer, start, num5);
			}
			}
			IL_9D:
			this.ValidateIsInitialized();
			IL_A3:
			num = (short)1901199363;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000B0B4 File Offset: 0x000092B4
		public virtual int ReceiveData(byte[] buffer, int length)
		{
			short num = (short)692757772;
			short num2 = num;
			num = (short)1341695244;
			switch (num2 == num)
			{
			}
			num = (short)2001928192;
			if (num != 0)
			{
			}
			num = (short)1485832192;
			short num3 = num;
			num = (short)143654913;
			if (num != 0)
			{
			}
			return this.ReceiveData(buffer, 0, -1, length);
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000B168 File Offset: 0x00009368
		public int ReceiveData(byte[] buffer, int start, int timeout, int expectedLength)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1880293382;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return 0;
				case 2:
					this._tlsProtocol.Stream.ReadTimeout = timeout;
					num2 = (short)105644036;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (this._tlsProtocol.Stream.CanTimeout)
					{
						num2 = (short)394526720;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_10E;
				case 4:
					goto IL_16C;
				case 5:
					if (expectedLength <= 0)
					{
						num2 = (short)569769985;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1A7;
				case 6:
					if (timeout > 0)
					{
						num2 = (short)200081410;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_10E;
				}
				goto IL_2C;
			}
			return 0;
			IL_1A7:
			return this.ReceiveDataFromBaseStream(buffer, start, expectedLength);
			IL_2C:
			num2 = (short)107020288;
			short num3 = num2;
			num2 = (short)1701015970;
			short num4 = num2;
			num2 = (short)501379490;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_16C:
				break;
			default:
				num2 = (short)2116419585;
				if (num2 != 0)
				{
				}
				num2 = (short)1615462400;
				if (num2 != 0)
				{
				}
				this.ValidateIsInitialized();
				num2 = (short)1504903171;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_10E:
			num2 = (short)1874657285;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000B328 File Offset: 0x00009528
		public int SendData(byte[] buffer, int len)
		{
			int a_ = 18;
			short num = (short)1990119927;
			short num2 = num;
			num = (short)409850359;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)499318784;
				short num3 = num;
				num = (short)948961280;
				if (num != 0)
				{
				}
				num = (short)1717174273;
				if (num != 0)
				{
				}
				this.ValidateIsInitialized();
				try
				{
					this._tlsProtocol.Stream.Write(buffer, 0, len);
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteInfo(global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient.b("礼帾㕀≂敄㑆ⱈ╊㥌慎煐ὒご㥖㹘⽚㕜敞䅠ᡢ啤ᩦ", a_), new object[]
					{
						len
					});
				}
				catch
				{
					global::Motorola.Common.CustomException.CommonException ex = new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Send_Failed);
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient.b("椼䴾⡀♂⅄杆㵈⑊浌㱎㑐㵒ㅔ睖㵘㩚⥜㹞䅠ᑢ౤፦Ũ䭪Ŭ੮ὰᑲŴὶ奸z䵼ɾ꾀ꎂ삄ﾆﶌﮎﲒﮔ랖ﺚ삠쒢삤鶦覨킪鲬튮", a_), new object[]
					{
						len,
						ex.Message
					});
					throw ex;
				}
				break;
			}
			}
			return len;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000B46C File Offset: 0x0000966C
		public void SendData(byte[] buffer, int offset, int length)
		{
			int a_ = 16;
			switch (0)
			{
			case 0:
				goto IL_25;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					goto IL_8C;
				case 1:
					num2 = (short)439091201;
					if (num2 != 0)
					{
					}
					if (this.f.Length < length + 2)
					{
						num2 = (short)364576768;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_210;
				case 2:
					try
					{
						num2 = (short)1384472414;
						short num3 = num2;
						num2 = (short)1910136670;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
						{
							num2 = (short)371064832;
							if (num2 != 0)
							{
							}
							object syncRoot = this.f.SyncRoot;
							bool flag = false;
							try
							{
								global::System.Threading.Monitor.Enter(syncRoot, ref flag);
								this.f[0] = (byte)(length >> 8);
								this.f[1] = (byte)(length & 255);
								global::System.Buffer.BlockCopy(buffer, offset, this.f, 2, length);
								this._tlsProtocol.Stream.Write(this.f, 0, length + 2);
							}
							finally
							{
								num2 = (short)1188102145;
								num = (int)((global::System.IntPtr)num2);
								for (;;)
								{
									switch (num)
									{
									case 0:
										global::System.Threading.Monitor.Exit(syncRoot);
										num2 = (short)448528386;
										num = (int)((global::System.IntPtr)num2);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_16D;
										}
										continue;
									case 2:
										goto IL_1A3;
									}
									IL_16D:
									if (!flag)
									{
										break;
									}
									num2 = (short)171704320;
									num = (int)((global::System.IntPtr)num2);
								}
								IL_1A3:;
							}
							break;
						}
						}
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteInfo(global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient.b("缺尼䬾⁀捂㙄≆❈㽊捌潎ᵐ㙒㭔ざⵘ㍚杜罞᩠卢ᡤ", a_), new object[]
						{
							length
						});
						return;
					}
					catch (global::System.Exception)
					{
						global::Motorola.Common.CustomException.CommonException ex = new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Send_Failed);
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient.b("漺似嘾⑀❂敄㍆♈歊㹌⩎㽐㝒畔㍖㡘⽚㱜罞ᙠ੢ᅤས䥨ݪ࡬Ůᙰݲᵴ坶ɸ䭺|兾ꆀ욂ﶄﮊ歷ﺐﶒ떔殺ﲘﺞ욠욢龤螦튨骪킬", a_), new object[]
						{
							length,
							ex.Message
						});
						throw ex;
					}
					goto IL_210;
				}
				goto IL_25;
				IL_210:
				num2 = (short)60817408;
				short num4 = num2;
				num2 = (short)486473730;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_8C:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
			IL_25:
			this.ValidateIsInitialized();
			num2 = (short)511442945;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000B70C File Offset: 0x0000990C
		public void Uninitialize()
		{
			int a_ = 19;
			short num;
			try
			{
				num = (short)191823872;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_3D;
						}
						continue;
					case 1:
						goto IL_C6;
					case 2:
					{
						num = (short)898899903;
						short num3 = num;
						num = (short)2115116991;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_C6;
						default:
							num = (short)1202126848;
							if (num != 0)
							{
							}
							goto IL_C8;
						}
						break;
					}
					case 3:
						goto IL_FD;
					}
					IL_3D:
					global::Motorola.Common.Communication.TLS.TlsClientProtocol tlsProtocol = this._tlsProtocol;
					if (tlsProtocol == null)
					{
						num = (short)688521217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					tlsProtocol.Close();
					num = (short)184025090;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C8:
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteInfo(global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient.b("紽ⰿⵁ㝃⽅♇ⵉ汋ⵍ㽏㱑㩓㍕㭗⹙㕛ㅝ๟䉡ᝣ፥୧३५ᵭͯᑱų᩵ᑷ͹屻ᵽﺉ", a_), global::System.Array.Empty<object>());
					num = (short)1263075331;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C6:
					goto IL_C8;
				}
				IL_FD:;
			}
			catch (global::Org.BouncyCastle.Crypto.Tls.TlsException)
			{
				global::Motorola.Common.CustomException.CommonException ex = new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Uninitialize);
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient.b("紽ⰿⵁ㝃⍅桇㹉⁋㵍灏≑♓㥕ⱗ㕙㽛ㅝ౟䉡ɣݥŧ٩५੭偯ձᵳɵၷ婹ᅻ᭽낉겋ꂏ", a_), new object[]
				{
					ex.Message
				});
				throw ex;
			}
			finally
			{
				this.IsSecurityLayerInitialized = false;
			}
			num = (short)725745664;
			short num4 = num;
			num = (short)681902081;
			if (num != 0)
			{
			}
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000B8DC File Offset: 0x00009ADC
		protected int ReceivePacketDataSize()
		{
			short num = (short)983313387;
			short num2 = num;
			num = (short)955788267;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1953890304;
				if (num != 0)
				{
				}
				byte[] array = new byte[2];
				if (this.ReceiveDataFromBaseStream(array, 0, array.Length) > 0)
				{
					num = (short)1465384960;
					short num3 = num;
					return ((int)array[0] << 8) + (int)array[1];
				}
				num = (short)2047213569;
				if (num != 0)
				{
				}
				break;
			}
			}
			return 0;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000B9A8 File Offset: 0x00009BA8
		protected int ReceiveDataFromBaseStream(byte[] buffer, int start, int length)
		{
			int a_ = 2;
			short num;
			for (;;)
			{
				num = (short)651165696;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)1317732352;
					short num3 = num;
					num = (short)1052402235;
					short num4 = num;
					num = (short)566387259;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_83;
					}
					break;
				}
				}
			}
			IL_83:
			num = (short)2110783489;
			if (num != 0)
			{
			}
			num = (short)1489633280;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.ValidateArrayStartLength<byte>(buffer, start, length);
			int num5 = start;
			goto IL_CD;
			int result;
			try
			{
				for (;;)
				{
					IL_CD:
					switch (0)
					{
					case 0:
						goto IL_F6;
					}
					int num2;
					int num6;
					for (;;)
					{
						IL_D7:
						switch (num2)
						{
						case 0:
							num = (short)1141702659;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_1E5;
						case 2:
							if (num6 > 0)
							{
								num = (short)143851524;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_199;
						case 3:
							if (num5 >= length)
							{
								num = (short)659423237;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_CD;
						case 4:
							num5 += num6;
							num = (short)476774400;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteInfo(global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient.b("椬丮䔰刲ᔴ䔶尸堺堼嘾㝀♂⅄楆楈݊⡌ⅎ㙐❒㵔浖祘⁚浜≞", a_), new object[]
							{
								num5
							});
							result = num5;
							num = (short)243924993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					IL_F6:
					num6 = this._tlsProtocol.Stream.Read(buffer, num5, length - num5);
					num = (short)178126850;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_D7;
				}
				IL_199:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeUnexpectedEndOfConnection);
				IL_1E5:;
			}
			catch (global::System.IO.IOException systemException)
			{
				global::Motorola.Common.CustomException.CommonException ex = new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadFailure, systemException);
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient.b("礬崮堰嘲儴᜶䴸吺ᴼ䴾⑀⁂⁄⹆㽈⹊浌⭎ぐ❒㑔睖⹘㉚⥜㝞䅠རd०๨Ὢլ佮ੰ䍲ࡴ奶奸㹺ռ᱾권ﺘﺚꞜ뾞\udaa0銢\ud8a4", a_), new object[]
				{
					length,
					ex.Message
				});
				throw ex;
			}
			catch (global::System.ArgumentOutOfRangeException systemException2)
			{
				global::Motorola.Common.CustomException.CommonException ex2 = new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange, systemException2);
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient.b("礬崮堰嘲儴᜶䴸吺ᴼ䴾⑀⁂⁄⹆㽈⹊浌⭎ぐ❒㑔睖⹘㉚⥜㝞䅠རd०๨Ὢլ佮ੰ䍲ࡴ奶奸㹺ռ᱾권ﺘﺚꞜ뾞\udaa0銢\ud8a4", a_), new object[]
				{
					length,
					ex2.Message
				});
				throw ex2;
			}
			catch
			{
				global::Motorola.Common.CustomException.CommonException ex3 = new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Receive_Failed);
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient.b("礬崮堰嘲儴᜶䴸吺ᴼ䴾⑀⁂⁄⹆㽈⹊浌⭎ぐ❒㑔睖⹘㉚⥜㝞䅠རd०๨Ὢլ佮ੰ䍲ࡴ奶奸㹺ռ᱾권ﺘﺚꞜ뾞\udaa0銢\ud8a4", a_), new object[]
				{
					length,
					ex3.Message
				});
				throw ex3;
			}
			return result;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000BCB0 File Offset: 0x00009EB0
		protected void ValidateIsInitialized()
		{
			int a_ = 18;
			if (!this.IsSecurityLayerInitialized)
			{
				short num = (short)223780221;
				short num2 = num;
				num = (short)442735997;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2011889665;
					if (num != 0)
					{
					}
					num = (short)218038272;
					short num3 = num;
					num = (short)1331101696;
					if (num != 0)
					{
					}
					break;
				}
				}
				global::Motorola.Common.CustomException.CommonException ex = new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Uninitialize, global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient.b("渼娾≀㙂㝄⹆㵈㉊浌⍎ぐ⩒ご╖祘ⱚ㱜ⱞ䅠ൢၤ୦ը", a_));
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(ex.Message, global::System.Array.Empty<object>());
				throw ex;
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000BD9C File Offset: 0x00009F9C
		private static global::System.Exception a(global::Org.BouncyCastle.Crypto.Tls.TlsException A_0)
		{
			if (A_0.InnerException is global::Motorola.Common.CustomException.CommonException)
			{
				short num = (short)1469787129;
				short num2 = num;
				num = (short)2060921849;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2062483457;
					if (num != 0)
					{
					}
					num = (short)1607991296;
					short num3 = num;
					num = (short)1248919552;
					if (num != 0)
					{
					}
					break;
				}
				}
				return A_0.InnerException;
			}
			return new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Handshake_Failed, A_0);
		}

		// Token: 0x0400004C RID: 76
		internal global::Motorola.Common.Communication.TLS.TlsClientProtocol _tlsProtocol;

		// Token: 0x0400004D RID: 77
		private readonly global::Motorola.Common.Communication.TLS.TlsPskForAstro.ITlsConnectClientFactory a;

		// Token: 0x0400004E RID: 78
		private readonly global::Motorola.Common.Communication.TLS.TlsPskForAstro.ITlsIdentityClient b;

		// Token: 0x0400004F RID: 79
		private readonly string c;

		// Token: 0x04000050 RID: 80
		private const int d = 2;

		// Token: 0x04000051 RID: 81
		private const int e = 25000;

		// Token: 0x04000052 RID: 82
		private readonly byte[] f = new byte[25000];

		// Token: 0x04000053 RID: 83
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool g;

		// Token: 0x04000054 RID: 84
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private readonly global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe h;
	}
}
