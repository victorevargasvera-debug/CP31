using System;
using System.Linq;
using System.Net.Http;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.TLS.TlsPskForAstro;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommunicationPipe
{
	// Token: 0x02000003 RID: 3
	public class SecureHttpsCommPipe : global::Motorola.Common.Communication.CommunicationPipe.SecureTlsCommPipe, global::Motorola.Common.Communication.CommunicationPipe.IHttpPipe, global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		public SecureHttpsCommPipe(global::Motorola.Common.Communication.TLS.TlsPskForAstro.AmpTlsHandler securityLayer) : base(securityLayer)
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002130 File Offset: 0x00000330
		public override void SendData(byte[] buffer, int start, int length)
		{
			int a_ = 6;
			short num = (short)2096955394;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				byte[] array;
				switch (num2)
				{
				case 0:
					num = (short)567934977;
					if (num != 0)
					{
					}
					goto IL_65;
				case 1:
					goto IL_F3;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 3:
				{
					num = (short)1880883200;
					short num3 = num;
					array = new byte[length];
					global::System.Array.Copy(buffer, start, array, 0, length);
					num = (short)2118385669;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					if (this._securityLayer.SendData(array, length) != length)
					{
						num = (short)895221761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B9;
				case 5:
					IL_192:
					goto IL_65;
				}
				IL_45:
				if (start > 0)
				{
					num = (short)1062535171;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				array = buffer;
				num = (short)1659568128;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_65:
				num = (short)1301183926;
				short num4 = num;
				num = (short)1279163830;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_192;
				default:
					num = (short)41877504;
					if (num != 0)
					{
					}
					num = (short)148701188;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_F3:
			global::Motorola.Common.CustomException.CommonException ex = new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Send_Failed);
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(ex.Message, global::System.Array.Empty<object>());
			throw ex;
			IL_1B9:
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteInfo(global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe.b("簷嬹䠻弽怿⩁╃㕅桇⡉⥋⭍㹏牑❓㍕㙗⹙籛⥝य़ᙡౣ䙥ѧཀྵɫ७ѯᩱ味൵䡷ݹ", a_), new object[]
			{
				length
			});
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002320 File Offset: 0x00000520
		public void SendDataWithContent(byte[] buffer, global::System.Net.Http.HttpContent content, int start, int length, int timeout)
		{
			int a_ = 13;
			short num = (short)424673280;
			switch (num)
			{
			default:
			{
				num = (short)1222443012;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					byte[] array;
					switch (num2)
					{
					case 0:
					{
						long? contentLength = content.Headers.ContentLength;
						num = (short)792331878;
						short num3 = num;
						num = (short)1835533926;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_12C;
						default:
							num = (short)1864564736;
							if (num != 0)
							{
							}
							num = (short)1861550081;
							if (num != 0)
							{
							}
							num = (short)691666945;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
					{
						long? contentLength;
						if (contentLength == null)
						{
							num = (short)1645871107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2019033097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (this._securityLayer.IsSecurityLayerInitialized)
						{
							num = (short)1949696000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12C;
					case 3:
						goto IL_285;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_77;
						}
						continue;
					case 5:
						goto IL_28A;
					case 6:
						goto IL_E6;
					case 7:
					{
						num = (short)1794179072;
						short num4 = num;
						goto IL_28A;
					}
					case 8:
						array = new byte[length];
						global::System.Array.Copy(buffer, start, array, 0, length);
						num = (short)1358561287;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (((global::Motorola.Common.Communication.TLS.TlsPskForAstro.AmpTlsHandler)this._securityLayer).SendData(array, content, length, timeout) < (long)length)
						{
							num = (short)1662779398;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D0;
					}
					IL_77:
					if (start > 0)
					{
						num = (short)1209532424;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					array = buffer;
					num = (short)489750533;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_28A:
					num = (short)1331953666;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E6:
				global::Motorola.Common.CustomException.CommonException ex = new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Send_Failed);
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(ex.Message, global::System.Array.Empty<object>());
				throw ex;
				IL_12C:
				global::Motorola.Common.CustomException.CommonException ex2 = new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Uninitialize);
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(ex2.Message, global::System.Array.Empty<object>());
				throw ex2;
				IL_285:
				global::Motorola.Common.CustomException.CommonException ex3 = new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Send_Failed);
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(ex3.Message, global::System.Array.Empty<object>());
				throw ex3;
				IL_2D0:
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteInfo(global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe.b("笾⁀㝂⑄杆ⅈ⩊㹌潎㍐㙒ご㥖祘⡚㡜ㅞᕠ䍢ቤ๦ᵨͪ䵬ͮᑰᵲቴͶᅸ孺ټ佾ﲀ", a_), new object[]
				{
					length
				});
				return;
			}
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002628 File Offset: 0x00000828
		public byte[] RequestData(byte[] buffer, global::System.Net.Http.HttpContent content, int start, int length, int timeout)
		{
			int a_ = 19;
			short num = (short)283412744;
			short num2 = num;
			num = (short)1681623304;
			switch (num2 == num)
			{
			}
			num = (short)685703169;
			if (num != 0)
			{
			}
			num = (short)580124672;
			short num3 = num;
			num = (short)1567621120;
			if (num != 0)
			{
			}
			this.SendDataWithContent(buffer, content, start, length, timeout);
			byte[] array = this.ReceiveData();
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteInfo(global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe.b("ᝄ≆⩈⹊⑌㥎㑐㝒畔㍖㡘⽚㱜罞ᙠ੢ᅤས䥨ݪ࡬Ůᙰݲᵴ坶ɸ䭺|", a_), new object[]
			{
				array.Length
			});
			return array;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x0000271C File Offset: 0x0000091C
		public override byte[] ReceiveData()
		{
			int a_ = 3;
			short num = (short)528416768;
			short num2 = num;
			num = (short)848904710;
			short num3 = num;
			num = (short)1408582150;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_9C;
			default:
				num = (short)758775808;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_9C;
				}
				break;
			}
			int num4;
			int num5;
			for (;;)
			{
				IL_86:
				switch (num4)
				{
				case 0:
					if (num5 > 65536)
					{
						num = (short)1262354435;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_175;
				case 1:
					num = (short)596443136;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (num5 > 0)
					{
						num = (short)1467940865;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10C;
				case 3:
					goto IL_173;
				}
				goto IL_9C;
			}
			IL_10C:
			global::Motorola.Common.CustomException.CommonException ex = new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Receive_Failed, global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe.b("昴制娸为似嘾㕀㩂敄⭆⡈㉊⡌㵎煐⅒ご㑖㱘㉚⭜㩞䅠ŢၤŦཨ๪Ὤ佮ᥰቲᅴ坶ၸᕺ୼ṾꞆﮒ", a_));
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(ex.Message, global::System.Array.Empty<object>());
			throw ex;
			IL_173:
			goto IL_10C;
			IL_175:
			byte[] array = this._rxBuffer.Take(num5).ToArray<byte>();
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteInfo(global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe.b("朴制娸帺吼䤾⑀❂敄⍆⡈㽊ⱌ潎♐㩒⅔㽖祘㝚㡜ㅞ٠ᝢ൤䝦ቨ孪ၬ", a_), new object[]
			{
				array.Length
			});
			return array;
			IL_9C:
			num5 = this._securityLayer.ReceiveData(this._rxBuffer, 65536);
			num = (short)1328480257;
			if (num != 0)
			{
			}
			num = (short)1447624706;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_86;
		}
	}
}
