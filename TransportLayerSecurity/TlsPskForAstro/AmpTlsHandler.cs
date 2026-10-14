using System;
using System.IO;
using System.Net.Http;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.TLS.TlsPskForAstro
{
	// Token: 0x02000020 RID: 32
	public class AmpTlsHandler : global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsHandler
	{
		// Token: 0x060000B5 RID: 181 RVA: 0x0000A360 File Offset: 0x00008560
		public AmpTlsHandler(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe pipe, global::Motorola.Common.Communication.TLS.TlsPskForAstro.ITlsConnectClientFactory connectClientFactory, global::Motorola.Common.Communication.TLS.TlsPskForAstro.ITlsIdentityClient identityClient, string psk) : base(pipe, connectClientFactory, identityClient, psk)
		{
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000A378 File Offset: 0x00008578
		public long SendData(byte[] requestMessageSerializedHeaders, global::System.Net.Http.HttpContent content, int length, int timeout)
		{
			int a_ = 15;
			short num = (short)1593114624;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1701904384;
				short num3 = num;
				num = (short)200278017;
				if (num != 0)
				{
				}
				global::System.IO.Stream stream = base.Pipe.GetStream();
				int writeTimeout = stream.WriteTimeout;
				long result;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_BC;
					}
					for (;;)
					{
						IL_99:
						switch (num2)
						{
						case 0:
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient.b("椹夻䨽㐿⭁⩃ⅅ桇㹉⑋⭍灏♑㵓㭕㵗㕙⥛⩝䁟ൡ੣䙥ᱧɩ५乭ͯٱٳ፵᥷᝹屻᡽ꚅ몉꺍﶑뒓ꦗ늛", a_), new object[]
							{
								stream.WriteTimeout,
								timeout
							});
							stream.WriteTimeout = timeout;
							num = (short)988151812;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (content != null)
							{
								num = (short)36241413;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_29B;
						case 2:
							if (timeout > 0)
							{
								num = (short)844365824;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_229;
						case 3:
							goto IL_29B;
						case 4:
							goto IL_229;
						case 5:
						{
							num = (short)1452112645;
							short num4 = num;
							num = (short)172849925;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_29B;
							default:
								num = (short)1950941184;
								if (num != 0)
								{
								}
								global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteInfo(global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient.b("椹䠻弽㈿㙁摃㕅ⵇ⑉⡋❍㹏㕑瑓㕕㝗㑙⡛㭝๟ᙡ䩣", a_), global::System.Array.Empty<object>());
								content.CopyToAsync(this._tlsProtocol.Stream).Wait();
								global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteInfo(global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient.b("簹唻倽⤿ㅁⱃ⍅ⱇ橉㽋⭍㹏㙑㵓㡕㽗穙㽛ㅝ๟ᙡţࡥᱧ䑩", a_), global::System.Array.Empty<object>());
								num = (short)1101070339;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							goto IL_2B7;
						}
						goto IL_BC;
						IL_229:
						this._tlsProtocol.Stream.Write(requestMessageSerializedHeaders, 0, length);
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteInfo(global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient.b("簹唻倽⤿ㅁⱃ⍅ⱇ橉㽋⭍㹏㙑㵓㡕㽗穙㑛㭝ş١ţᑥ䡧๩൫ᩭᅯ山", a_), new object[]
						{
							length
						});
						num = (short)1658716161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_29B:
						result = (long)length;
						num = (short)952893446;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_2B7:
					return result;
					IL_BC:
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteInfo(global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient.b("椹䠻弽㈿㙁摃㕅ⵇ⑉⡋❍㹏㕑瑓㹕㵗㭙㡛㭝቟䉡cݥᱧ୩䁫乭ᱯ᝱ᩳᅵ౷ቹ䙻幽ﭿ늁旅", a_), new object[]
					{
						length
					});
					num = (short)1384841218;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_99;
				}
				catch (global::System.Exception systemException)
				{
					global::Motorola.Common.CustomException.CommonException ex = new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Send_Failed, systemException);
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(ex.Message, global::System.Array.Empty<object>());
					throw ex;
				}
				finally
				{
					try
					{
						num = (short)269484032;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_321;
								}
								continue;
							case 1:
								goto IL_3C2;
							case 2:
								stream.WriteTimeout = writeTimeout;
								global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient.b("根夻䴽㐿ⵁ㙃⍅ⱇ橉㡋♍㕏牑㭓⑕ㅗ㵙㕛そş๡䑣ብŧݩ५ŭկٱ味᥵ᙷ婹ࡻᙽꊁ慎뺏", a_), global::System.Array.Empty<object>());
								num = (short)977534979;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_3C2;
							case 4:
								goto IL_3DB;
							}
							IL_321:
							if (stream.CanWrite)
							{
								num = (short)1318453250;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient.b("縹唻娽怿ⱁ⭃㉅桇㡉⥋㵍⑏㵑♓㍕硗⹙㑛㭝䁟ൡᙣཥཧͩɫ཭ᱯ剱sήᕷό፻୽ꊁꢇﺉ낏ﶗﮙ낝肟얣좥ﾧ\ud8a9얫\udaad햯銱쎳ힵ쮷骹잻躽붿", a_), new object[]
							{
								stream.CanWrite
							});
							num = (short)1777270785;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_3C2:
							num = (short)2110586884;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_3DB:;
					}
					catch (global::System.Exception ex2)
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteInfo(global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient.b("礹医䬽ⰿ♁摃⡅❇㹉汋㱍㕏⅑⁓㥕⩗㽙籛⩝࡟ݡ䑣॥ᩧͩ୫ݭṯ፱ᡳ噵౷፹ᅻ᭽ꚅ겋揄뒓鍊ﾝ춟芡삣펥춧誩\ud8ab솭邯욱\udcb3펵颷\udfb9쒻\uddbdꖿ닁냃꿅Ꟈ꓉ꯏ꧓裙맛꿝闟蟡韣鋥跧軩쳫髭駯鿱釳駵跷軹\udcfb觽懿焁␃紅㤇眉", a_), new object[]
						{
							ex2.Message,
							timeout
						});
					}
				}
				return result;
			}
			}
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000A7E8 File Offset: 0x000089E8
		public override int ReceiveData(byte[] buffer, int length)
		{
			int a_ = 4;
			short num = (short)1978357205;
			short num2 = num;
			num = (short)1583568341;
			int result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1915682816;
				if (num != 0)
				{
				}
				num = (short)241434624;
				short num3 = num;
				base.ValidateIsInitialized();
				try
				{
					num = (short)753664001;
					if (num != 0)
					{
					}
					int num4 = this._tlsProtocol.Stream.Read(buffer, 0, length);
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteInfo(global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient.b("欮倰䜲吴᜶䬸帺帼娾⡀㕂⁄⍆杈歊Ō⩎㽐㑒⅔㽖捘筚♜潞ᱠ", a_), new object[]
					{
						num4
					});
					result = num4;
				}
				catch
				{
					global::Motorola.Common.CustomException.CommonException ex = new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Receive_Failed);
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient.b("笮䌰娲倴匶ᤸ伺刼Ἶ㍀♂♄≆⁈㵊⡌潎㕐㉒⅔㙖祘ⱚ㑜⭞ॠ䍢।ɦݨ౪ᥬݮ兰ࡲ䕴੶坸孺㡼ݾ꾎ﲐﲚꖞ膠\ud8a2钤\udaa6", a_), new object[]
					{
						length,
						ex.Message
					});
					throw ex;
				}
				break;
			}
			}
			return result;
		}
	}
}
