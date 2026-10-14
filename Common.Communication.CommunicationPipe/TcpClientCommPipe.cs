using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.Common.Communication.CommunicationPipe
{
	// Token: 0x02000008 RID: 8
	public class TcpClientCommPipe : global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe, global::System.IDisposable
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00003BC0 File Offset: 0x00001DC0
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00003C70 File Offset: 0x00001E70
		public int ReceiveTimeout
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)429093002;
				short num2 = num;
				num = (short)1032220810;
				switch (num2 == num)
				{
				}
				num = (short)1222377472;
				short num3 = num;
				num = (short)425132033;
				if (num != 0)
				{
				}
				num = (short)1060110336;
				if (num != 0)
				{
				}
				return this.i;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)159278803;
				short num2 = num;
				num = (short)1757701843;
				switch (num2 == num)
				{
				}
				num = (short)834666496;
				short num3 = num;
				num = (short)1772814336;
				if (num != 0)
				{
				}
				num = (short)1997668353;
				if (num != 0)
				{
				}
				this.i = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00003D20 File Offset: 0x00001F20
		// (set) Token: 0x06000021 RID: 33 RVA: 0x00003DD4 File Offset: 0x00001FD4
		internal bool NeedExtractHeader
		{
			private get
			{
				short num = (short)489804815;
				short num2 = num;
				num = (short)29283343;
				switch (num2 == num)
				{
				}
				num = (short)16187392;
				short num3 = num;
				num = (short)1874657281;
				if (num != 0)
				{
				}
				num = (short)1298399232;
				if (num != 0)
				{
				}
				return this.c == 2;
			}
			set
			{
				if (!value)
				{
					short num;
					for (;;)
					{
						num = (short)604176384;
						short num2 = num;
						num = (short)971643394;
						short num3 = num;
						num = (short)1596791298;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_67;
						}
					}
					IL_67:
					num = (short)407764993;
					if (num != 0)
					{
					}
					num = (short)1047003136;
					if (num != 0)
					{
					}
					this.c = 0;
					return;
				}
				this.c = 2;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00003E94 File Offset: 0x00002094
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00003F44 File Offset: 0x00002144
		protected global::System.Net.Sockets.TcpClient Client
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1965490177;
				if (num != 0)
				{
				}
				num = (short)459381921;
				short num2 = num;
				num = (short)760913057;
				switch (num2 == num)
				{
				}
				num = (short)1298726912;
				if (num != 0)
				{
				}
				num = (short)1662451712;
				short num3 = num;
				return this.j;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)955842561;
				if (num != 0)
				{
				}
				num = (short)1025123015;
				short num2 = num;
				num = (short)299049671;
				switch (num2 == num)
				{
				}
				num = (short)253820928;
				if (num != 0)
				{
				}
				num = (short)237568000;
				short num3 = num;
				this.j = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000024 RID: 36 RVA: 0x00003FF8 File Offset: 0x000021F8
		// (set) Token: 0x06000025 RID: 37 RVA: 0x000040A8 File Offset: 0x000022A8
		protected global::System.Net.Sockets.NetworkStream Stream
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1408498246;
				short num2 = num;
				num = (short)598538822;
				switch (num2 == num)
				{
				}
				num = (short)995229697;
				if (num != 0)
				{
				}
				num = (short)372375552;
				if (num != 0)
				{
				}
				num = (short)956956672;
				short num3 = num;
				return this.k;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1785331713;
				if (num != 0)
				{
				}
				num = (short)1771893014;
				short num2 = num;
				num = (short)427618582;
				switch (num2 == num)
				{
				}
				num = (short)1896087552;
				if (num != 0)
				{
				}
				num = (short)884015104;
				short num3 = num;
				this.k = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00004158 File Offset: 0x00002358
		public virtual int AvailableReadBytesCount
		{
			get
			{
				short num = (short)538948342;
				short num2 = num;
				num = (short)1059304182;
				switch (num2 == num)
				{
				}
				num = (short)439353345;
				if (num != 0)
				{
				}
				num = (short)547356672;
				if (num != 0)
				{
				}
				num = (short)686227456;
				short num3 = num;
				return this.Client.Available;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00004210 File Offset: 0x00002410
		// (set) Token: 0x06000028 RID: 40 RVA: 0x000042C0 File Offset: 0x000024C0
		public virtual bool IsOpen
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2048107615;
				short num2 = num;
				num = (short)257270879;
				switch (num2 == num)
				{
				}
				num = (short)1049493504;
				if (num != 0)
				{
				}
				num = (short)2126577665;
				if (num != 0)
				{
				}
				num = (short)1958739968;
				short num3 = num;
				return this.l;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)548308213;
				short num2 = num;
				num = (short)1626506485;
				switch (num2 == num)
				{
				}
				num = (short)1455816705;
				if (num != 0)
				{
				}
				num = (short)1490812928;
				if (num != 0)
				{
				}
				num = (short)1312948224;
				short num3 = num;
				this.l = value;
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00004370 File Offset: 0x00002570
		public TcpClientCommPipe(global::System.Net.IPAddress ipAddress, int portNumber, int receiveTimeout, bool noDelay)
		{
			if (portNumber >= 0)
			{
				if (portNumber <= 65535)
				{
					this.f = ipAddress;
					this.g = portNumber;
					this.h = noDelay;
					this.ReceiveTimeout = receiveTimeout;
					return;
				}
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000043D0 File Offset: 0x000025D0
		public TcpClientCommPipe(global::System.Net.IPAddress ipAddress, int portNumber, bool noDelay) : this(ipAddress, portNumber, 2000, noDelay)
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000043EC File Offset: 0x000025EC
		protected override void Finalize()
		{
			short num;
			try
			{
				num = (short)1184004088;
				short num2 = num;
				num = (short)339245048;
				switch (num2 == num)
				{
				}
				num = (short)538116096;
				if (num != 0)
				{
				}
				this.Dispose(false);
			}
			finally
			{
				num = (short)550830081;
				if (num != 0)
				{
				}
				base.Finalize();
			}
			num = (short)1846345728;
			short num3 = num;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000044B4 File Offset: 0x000026B4
		public void OpenPort(int timeout)
		{
			int a_ = 5;
			short num = (short)1628569600;
			switch (num)
			{
			default:
			{
				num = (short)1555562500;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (timeout <= 0)
						{
							num = (short)1065287688;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D6;
					case 1:
						goto IL_D6;
					case 2:
						num = (short)885456907;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						int num3;
						if (!global::Motorola.Common.Communication.CommonUtil.WinAPIWrapper.SetSockOpt(this.Client.Client.Handle, 6, 5, ref num3))
						{
							num = (short)1561460743;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A4;
					}
					case 4:
						switch (0)
						{
						case 0:
							goto IL_7E;
						}
						continue;
					case 5:
						goto IL_D4;
					case 6:
					{
						try
						{
							switch (0)
							{
							case 0:
								goto IL_2BD;
							}
							global::System.IAsyncResult asyncResult;
							for (;;)
							{
								IL_28E:
								switch (num2)
								{
								case 0:
									goto IL_46C;
								case 1:
									this.Client.EndConnect(asyncResult);
									goto IL_3C1;
								case 2:
									goto IL_42F;
								case 3:
									goto IL_485;
								case 4:
								{
									if (!asyncResult.AsyncWaitHandle.WaitOne(5000))
									{
										timeout -= 5000;
										num = (short)540016647;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1215920180;
									short num4 = num;
									num = (short)112162868;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_3C1;
									default:
										num = (short)1185939456;
										if (num != 0)
										{
										}
										num = (short)601554945;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_431;
								case 6:
									goto IL_46C;
								case 7:
									if (timeout <= 0)
									{
										num = (short)281477122;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Diagnostics.Trace.WriteLine(global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe.b("挶儸帺ᴼ尾⹀ⵂ⭄≆⩈㽊⑌⁎㽐獒㱔⑖祘⽚㑜㉞Ѡౢၤ፦౨ཪ䅬佮հŲ౴坶ᙸᕺ᡼彾ꦈﾊ붒뮔릖", a_));
									num = (short)519372809;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									if (timeout <= 0)
									{
										num = (short)1927217158;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1532100612;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									goto IL_431;
								}
								goto IL_2BD;
								IL_3C1:
								num = (short)502988800;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_431:
								num = (short)604897288;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_46C:
								num = (short)76349443;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_42F:
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeOpenTimeout, global::Motorola.CommonCPS.ResourceRepository.Resources.CommunicationPipeOpenTimeout);
							IL_485:
							goto IL_22D;
							IL_2BD:
							asyncResult = this.Client.BeginConnect(this.f, this.g, null, null);
							num = (short)487456773;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_28E;
						}
						catch (global::System.Net.Sockets.SocketException systemException)
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeOpenFailure, systemException);
						}
						catch (global::System.Security.SecurityException systemException2)
						{
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeOpenFailure, systemException2);
						}
						goto IL_4A4;
						IL_22D:
						int num3 = 90;
						num = (short)2036727811;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe.b("搶尸伺ᴼ款ɀፂᩄ੆ࡈፊὌ᭎煐㕒㑔㹖㕘㹚㥜煞", a_), global::System.Array.Empty<object>());
						num = (short)1052442633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						timeout = 15000;
						num = (short)1103298561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_1B7;
					case 10:
						if (this.Client == null)
						{
							num = (short)239730690;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11E;
					case 11:
						if (this.Stream != null)
						{
							num = (short)1708326917;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						this.Client = new global::System.Net.Sockets.TcpClient();
						this.Client.NoDelay = this.h;
						num = (short)269090816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7E:
					global::Motorola.Common.Communication.CommonUtil.TraceLogger instance = global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance;
					string str = global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe.b("挶稸欺ᴼ瀾ㅀ♂⭄ᝆ♈㥊㥌畎煐", a_);
					global::System.Net.IPAddress ipaddress = this.f;
					instance.WriteVerbose(str + ((ipaddress != null) ? ipaddress.ToString() : null) + global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe.b("ശ", a_) + this.g.ToString(), global::System.Array.Empty<object>());
					num = (short)194641930;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D6:
					num = (short)475136006;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_D4:
				IL_11E:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeAlreadyOpened);
				IL_1B7:
				IL_4A4:
				num = (short)696909825;
				if (num != 0)
				{
				}
				num = (short)574029824;
				short num5 = num;
				this.Stream = this.Client.GetStream();
				this.IsOpen = true;
				return;
			}
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00004A00 File Offset: 0x00002C00
		public virtual void ClosePort()
		{
			int a_ = 6;
			switch (0)
			{
			case 0:
				goto IL_31;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					this.Stream.Dispose();
					this.Stream = null;
					num2 = (short)1930493953;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_150;
				case 2:
					if (this.Client != null)
					{
						goto IL_170;
					}
					goto IL_1B8;
				case 3:
					goto IL_14E;
				case 4:
				{
					num2 = (short)813213562;
					short num3 = num2;
					num2 = (short)1181132666;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_170;
					case 1:
						break;
					default:
					{
						num2 = (short)1032388608;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)405995520;
					if (num2 != 0)
					{
					}
					num2 = (short)1016987649;
					if (num2 != 0)
					{
					}
					this.Client.Close();
					this.Client = null;
					num2 = (short)828243971;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					if (this.Stream != null)
					{
						num2 = (short)1881997312;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_150;
				}
				goto IL_31;
				IL_150:
				num2 = (short)1494286338;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_170:
				num2 = (short)2041249796;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_14E:
			IL_1B8:
			this.IsOpen = false;
			return;
			IL_31:
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe.b("氷礹氻ḽ̿⹁⭃㕅ⵇᩉ⍋㱍⑏獑", a_), global::System.Array.Empty<object>());
			num2 = (short)2065301509;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00004BCC File Offset: 0x00002DCC
		public virtual void SendData(byte[] buffer, int start, int length)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				object syncRoot;
				bool flag;
				switch (num)
				{
				case 0:
					num2 = (short)1236664321;
					if (num2 != 0)
					{
					}
					try
					{
						switch (0)
						{
						case 0:
							goto IL_B2;
						}
						for (;;)
						{
							IL_9C:
							switch (num)
							{
							case 0:
								goto IL_162;
							case 1:
								this.e[0] = (byte)(length >> 8);
								this.e[1] = (byte)(length & 255);
								num2 = (short)604045314;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								goto IL_122;
							case 3:
								if (this.NeedExtractHeader)
								{
									num2 = (short)933494785;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_122;
							}
							goto IL_B2;
							IL_122:
							global::System.Buffer.BlockCopy(buffer, start, this.e, this.c, length);
							this.SendDataToBaseStream(this.e, 0, length + this.c);
							num2 = (short)550174720;
							num = (int)((global::System.IntPtr)num2);
						}
						IL_162:
						return;
						IL_B2:
						global::System.Threading.Monitor.Enter(syncRoot, ref flag);
						num2 = (short)845217795;
						num = (int)((global::System.IntPtr)num2);
						goto IL_9C;
					}
					finally
					{
						num2 = (short)638779394;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							IL_186:
							switch (num)
							{
							case 0:
								goto IL_21D;
							case 1:
								global::System.Threading.Monitor.Exit(syncRoot);
								num2 = (short)1684013056;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_198;
								}
								continue;
							}
							IL_198:
							while (flag)
							{
								num2 = (short)388529966;
								short num3 = num2;
								num2 = (short)189497134;
								switch ((num3 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num2 = (short)549060608;
									if (num2 != 0)
									{
									}
									num2 = (short)1693057025;
									num = (int)((global::System.IntPtr)num2);
									goto IL_186;
								}
							}
							break;
						}
						IL_21D:;
					}
					goto IL_220;
				case 1:
					goto IL_63;
				case 2:
					if (this.e.Length < length + this.c)
					{
						num2 = (short)1755512833;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_220;
				}
				goto IL_1C;
				IL_220:
				syncRoot = this.e.SyncRoot;
				flag = false;
				num2 = (short)2028339200;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_63:
			num2 = (short)1865678848;
			short num4 = num2;
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
			IL_1C:
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.ValidateArrayStartLength<byte>(buffer, start, length);
			num2 = (short)901513218;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00004E64 File Offset: 0x00003064
		public byte[] ReceiveData()
		{
			short num = (short)324776570;
			short num2 = num;
			num = (short)85635706;
			switch (num2 == num)
			{
			}
			num = (short)669843457;
			if (num != 0)
			{
			}
			num = (short)1190395904;
			if (num != 0)
			{
			}
			num = (short)2143158272;
			short num3 = num;
			return this.ReceiveData(this.ReceiveTimeout);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00004F1C File Offset: 0x0000311C
		public virtual byte[] ReceiveData(int timeout)
		{
			short num = (short)1709441033;
			int num2 = (int)((global::System.IntPtr)num);
			byte[] array;
			for (;;)
			{
				int num3;
				int num4;
				switch (num2)
				{
				case 0:
					if (this.NeedExtractHeader)
					{
						num = (short)73793541;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_21C;
				case 1:
					num = (short)1704984577;
					if (num != 0)
					{
					}
					this.ReceiveTimeout = num3;
					num = (short)464650243;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (num4 > 0)
					{
						num = (short)991952910;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_183;
				case 3:
					return array;
				case 4:
					if (timeout > 0)
					{
						num = (short)996409352;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A3;
				case 5:
					num4 = this.ReceivePacketSize();
					num = (short)806289414;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					num = (short)2147098684;
					short num5 = num;
					num = (short)1631068220;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_289;
					default:
						num = (short)1948581888;
						if (num != 0)
						{
						}
						goto IL_21C;
					}
					break;
				}
				case 7:
					goto IL_2DB;
				case 8:
					this.Stream.ReadTimeout = timeout;
					num = (short)675217418;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					switch (0)
					{
					case 0:
						goto IL_69;
					}
					continue;
				case 10:
					goto IL_2A3;
				case 11:
					if (num3 > 0)
					{
						num = (short)264110081;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return array;
				case 12:
					goto IL_183;
				case 13:
					num3 = this.ReceiveTimeout;
					this.ReceiveTimeout = timeout;
					goto IL_289;
				case 14:
				{
					num = (short)1683357696;
					short num6 = num;
					array = new byte[num4];
					this.ReceiveDataFromBaseStream(array, 0, num4);
					num = (short)2067595276;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 15:
					if (timeout > 0)
					{
						num = (short)1395523597;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2DB;
				case 16:
					num = (short)1058144260;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_69:
				if (this.Stream.CanTimeout)
				{
					num = (short)1241120784;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_2A3;
				IL_183:
				num = (short)1944190987;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_21C:
				array = null;
				num = (short)475398146;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_289:
				num = (short)919142407;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2A3:
				num3 = 0;
				num = (short)1441267727;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2DB:
				num4 = this.AvailableReadBytesCount;
				num = (short)1762983936;
				num2 = (int)((global::System.IntPtr)num);
			}
			return array;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0000524C File Offset: 0x0000344C
		public int ReceiveData(byte[] buffer, int start)
		{
			short num = (short)1680991107;
			short num2 = num;
			num = (short)882369411;
			switch (num2 == num)
			{
			}
			num = (short)419430400;
			if (num != 0)
			{
			}
			num = (short)1925709825;
			if (num != 0)
			{
			}
			num = (short)663486464;
			short num3 = num;
			return this.ReceiveData(buffer, start, this.ReceiveTimeout);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00005304 File Offset: 0x00003504
		public virtual int ReceiveData(byte[] buffer, int start, int timeout)
		{
			short num = (short)54274096;
			short num2 = num;
			num = (short)487532592;
			switch (num2 == num)
			{
			}
			num = (short)160563200;
			if (num != 0)
			{
			}
			num = (short)1492254721;
			if (num != 0)
			{
			}
			num = (short)586547200;
			short num3 = num;
			return this.ReceiveData(buffer, start, timeout, -1);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000053B8 File Offset: 0x000035B8
		public virtual int ReceiveData(byte[] buffer, int start, int timeout, int expectedlength)
		{
			short num = (short)426967046;
			int num2 = (int)((global::System.IntPtr)num);
			int num5;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (timeout > 0)
					{
						num = (short)479592459;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_219;
				case 1:
					goto IL_108;
				case 2:
					goto IL_11F;
				case 3:
				{
					expectedlength = this.AvailableReadBytesCount;
					num = (short)1365049344;
					short num3 = num;
					num = (short)2027290628;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					if (this.NeedExtractHeader)
					{
						num = (short)597295116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_108;
				case 5:
					goto IL_219;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_5D;
					}
					continue;
				case 7:
					if (timeout > 0)
					{
						num = (short)462487561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A7;
				case 8:
					if (expectedlength < 0)
					{
						num = (short)388497411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_108;
				case 9:
				{
					num = (short)606601217;
					if (num != 0)
					{
					}
					num = (short)497617646;
					short num4 = num;
					num = (short)2060978926;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_135;
					default:
						num = (short)1529151488;
						if (num != 0)
						{
						}
						num5 = this.ReceiveTimeout;
						this.ReceiveTimeout = timeout;
						num = (short)1907884042;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 10:
					goto IL_A7;
				case 11:
					this.Stream.ReadTimeout = timeout;
					num = (short)296615941;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					expectedlength = this.ReceivePacketSize();
					num = (short)2079391745;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					goto IL_135;
				}
				IL_5D:
				if (this.Stream.CanTimeout)
				{
					num = (short)36962317;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_219;
				IL_A7:
				num = (short)2096955400;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_108:
				num = (short)1113784322;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_135:
				num = (short)1271595008;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_219:
				num5 = 0;
				num = (short)1679687687;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_11F:
			int result = this.ReceiveDataFromBaseStream(buffer, start, expectedlength);
			if (num5 > 0)
			{
				this.ReceiveTimeout = num5;
			}
			return result;
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000568C File Offset: 0x0000388C
		public byte[] RequestData(byte[] buffer, int start, int length)
		{
			short num = (short)1791723388;
			short num2 = num;
			num = (short)2113243004;
			switch (num2 == num)
			{
			}
			num = (short)499843072;
			if (num != 0)
			{
			}
			num = (short)2125463553;
			if (num != 0)
			{
			}
			num = (short)427294720;
			short num3 = num;
			return this.RequestData(buffer, start, length, this.ReceiveTimeout);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00005748 File Offset: 0x00003948
		public byte[] RequestData(byte[] buffer, int start, int length, int timeout)
		{
			int a_ = 17;
			short num;
			try
			{
				num = (short)1691222017;
				if (num != 0)
				{
				}
				this.SendData(buffer, start, length);
				goto IL_105;
			}
			catch (global::System.Exception ex)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe.b("ᅂ⁄㙆㱈⹊㹌㭎煐ᝒ㑔⍖㡘獚⹜㩞འݢ䱤䝦ཨ੪Ѭͮᑰᝲ佴坶", a_) + ex.Message, global::System.Array.Empty<object>());
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe.b("ᝂ㵄絆楈݊⡌ⅎ汐⡒敔⩖祘⁚汜≞", a_), new object[]
				{
					length,
					global::Motorola.Common.Communication.CommonUtil.UtilityMethods.ToHexString(buffer, start, length, false)
				});
				throw;
			}
			try
			{
				IL_9C:
				byte[] result = this.ReceiveData(timeout);
				goto IL_109;
			}
			catch (global::System.Exception ex2)
			{
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe.b("ᅂ⁄㙆㱈⹊㹌㭎煐ᝒ㑔⍖㡘獚⽜㩞ɠ٢౤ᅦ౨䉪䵬८ၰᩲᥴቶᵸ䅺嵼", a_) + ex2.Message, global::System.Array.Empty<object>());
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe.b("ᝂ㵄絆楈݊⡌ⅎ汐⡒敔⩖祘⁚汜≞", a_), new object[]
				{
					length,
					global::Motorola.Common.Communication.CommonUtil.UtilityMethods.ToHexString(buffer, start, length, false)
				});
				throw;
			}
			goto IL_105;
			IL_109:
			num = (short)1909301126;
			short num2 = num;
			num = (short)737124230;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_105:
				byte[] result = null;
				goto IL_9C;
			}
			default:
			{
				num = (short)174391296;
				if (num != 0)
				{
				}
				num = (short)1308688384;
				short num3 = num;
				byte[] result;
				return result;
			}
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000058F0 File Offset: 0x00003AF0
		public byte[] PeekData(int length, int timeOut)
		{
			short num;
			byte[] result;
			try
			{
				num = (short)829422667;
				short num2 = num;
				num = (short)482409547;
				switch (num2 == num)
				{
				}
				num = (short)1595801601;
				if (num != 0)
				{
				}
				num = (short)23724032;
				if (num != 0)
				{
				}
				byte[] array = new byte[length];
				this.Client.Client.ReceiveTimeout = timeOut;
				this.Client.Client.Receive(array, length, global::System.Net.Sockets.SocketFlags.Peek);
				result = array;
			}
			catch (global::System.ArgumentOutOfRangeException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange, systemException);
			}
			catch (global::System.Net.Sockets.SocketException systemException2)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipePeekFailure, systemException2);
			}
			catch (global::System.Security.SecurityException systemException3)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipePeekFailure, systemException3);
			}
			num = (short)918355968;
			short num3 = num;
			return result;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00005A18 File Offset: 0x00003C18
		public global::System.IO.Stream GetStream()
		{
			short num = (short)1858640336;
			short num2 = num;
			num = (short)1968282064;
			switch (num2 == num)
			{
			}
			num = (short)549847040;
			short num3 = num;
			num = (short)1964048385;
			if (num != 0)
			{
			}
			num = (short)1074069504;
			if (num != 0)
			{
			}
			return this.Stream;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00005AC4 File Offset: 0x00003CC4
		protected virtual void SendDataToBaseStream(byte[] buffer, int start, int length)
		{
			short num = (short)394919937;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_F3;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				case 2:
					goto IL_131;
				}
				IL_32:
				if (this.Stream == null)
				{
					num = (short)1973360429;
					short num3 = num;
					num = (short)1734678317;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_131;
					default:
					{
						num = (short)610271232;
						if (num != 0)
						{
						}
						num = (short)1792540673;
						if (num != 0)
						{
						}
						num = (short)236322816;
						short num4 = num;
						num = (short)1371930624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
				}
				IL_112:
				global::Motorola.Common.Communication.CommonUtil.UtilityMethods.ValidateArrayStartLength<byte>(buffer, start, length);
				num = (short)1701183490;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_131:
				try
				{
					this.Stream.Write(buffer, start, length);
					return;
				}
				catch (global::System.IO.IOException systemException)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeWriteFailure, systemException);
				}
				goto IL_112;
			}
			IL_F3:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeNotOpened);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00005C20 File Offset: 0x00003E20
		protected virtual int ReceivePacketSize()
		{
			byte[] array = new byte[2];
			if (this.ReceiveDataFromBaseStream(array, 0, array.Length) > 0)
			{
				short num = (short)280931659;
				short num2 = num;
				num = (short)2103291211;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_B8;
				case 1:
					break;
				default:
				{
					num = (short)515112960;
					short num3 = num;
					break;
				}
				}
				num = (short)1270087681;
				if (num != 0)
				{
				}
				num = (short)1174994944;
				if (num != 0)
				{
				}
				IL_B8:
				return ((int)array[0] << 8) + (int)array[1];
			}
			return 0;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00005CF0 File Offset: 0x00003EF0
		protected virtual int ReceiveDataFromBaseStream(byte[] buffer, int start, int length)
		{
			short num;
			for (;;)
			{
				num = (short)666107904;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					num = (short)261043677;
					short num3 = num;
					num = (short)1824011741;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_53;
					}
					break;
				}
				}
			}
			IL_53:
			num = (short)286130177;
			if (num != 0)
			{
			}
			num = (short)1270415360;
			short num4 = num;
			num = (short)1809776640;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.CommonUtil.UtilityMethods.ValidateArrayStartLength<byte>(buffer, start, length);
			int num5 = start;
			goto IL_C5;
			try
			{
				for (;;)
				{
					IL_C5:
					switch (0)
					{
					case 0:
						goto IL_EE;
					}
					int num2;
					int num6;
					for (;;)
					{
						IL_CF:
						switch (num2)
						{
						case 0:
							num = (short)1555628037;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)238813186;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (num5 >= length)
							{
								num = (short)2052849664;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C5;
						case 3:
							if (num6 > 0)
							{
								num = (short)1960509444;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_186;
						case 4:
							num5 += num6;
							num = (short)261029889;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_1AB;
						}
						break;
					}
					IL_EE:
					num6 = this.Stream.Read(buffer, num5, length - num5);
					num = (short)401539075;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_CF;
				}
				IL_186:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeUnexpectedEndOfConnection);
				IL_1AB:;
			}
			catch (global::System.IO.IOException systemException)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationPipeReadFailure, systemException);
			}
			catch (global::System.ArgumentOutOfRangeException systemException2)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange, systemException2);
			}
			return num5;
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00005EE0 File Offset: 0x000040E0
		public void Dispose()
		{
			short num = (short)1075714815;
			short num2 = num;
			num = (short)454630143;
			switch (num2 == num)
			{
			}
			num = (short)1088749568;
			short num3 = num;
			num = (short)1973747713;
			if (num != 0)
			{
			}
			num = (short)295305216;
			if (num != 0)
			{
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00005F94 File Offset: 0x00004194
		protected virtual void Dispose(bool isDisposing)
		{
			short num = (short)1628700675;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_5E;
				case 1:
				{
					if (!isDisposing)
					{
						goto IL_5E;
					}
					num = (short)1913247592;
					short num3 = num;
					num = (short)768923496;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_48;
					default:
						num = (short)2003828736;
						if (num != 0)
						{
						}
						num = (short)1395720197;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 2:
					goto IL_9F;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 4:
					num = (short)1853030401;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					this.ClosePort();
					num = (short)149291008;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_3D;
				IL_48:
				num = (short)187957252;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3D:
				if (!this.m)
				{
					goto IL_48;
				}
				break;
				IL_5E:
				this.m = true;
				num = (short)218103809;
				if (num != 0)
				{
				}
				num = (short)351928322;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_9F:
			num = (short)1322516480;
			short num4 = num;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00006118 File Offset: 0x00004318
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1884609118 + A_1) + (global::System.IntPtr)51 + (global::System.IntPtr)15 + (global::System.IntPtr)3 + (global::System.IntPtr)53 + (global::System.IntPtr)89);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_6A;
			}
			IL_37:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_6A:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_37;
		}

		// Token: 0x04000015 RID: 21
		private const int a = 5;

		// Token: 0x04000016 RID: 22
		private const int b = 6;

		// Token: 0x04000017 RID: 23
		private int c = 2;

		// Token: 0x04000018 RID: 24
		private const int d = 25000;

		// Token: 0x04000019 RID: 25
		private readonly byte[] e = new byte[25000];

		// Token: 0x0400001A RID: 26
		private global::System.Net.IPAddress f;

		// Token: 0x0400001B RID: 27
		private int g;

		// Token: 0x0400001C RID: 28
		private bool h;

		// Token: 0x0400001D RID: 29
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int i;

		// Token: 0x0400001E RID: 30
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Net.Sockets.TcpClient j;

		// Token: 0x0400001F RID: 31
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Net.Sockets.NetworkStream k;

		// Token: 0x04000020 RID: 32
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool l;

		// Token: 0x04000021 RID: 33
		private bool m;
	}
}
