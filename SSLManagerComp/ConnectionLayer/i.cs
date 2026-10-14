using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using IACustomException;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Tls;
using Org.BouncyCastle.Security;
using SSLMangrComp.Packets;

namespace SSLMangrComp.ConnectionLayer
{
	// Token: 0x02000046 RID: 70
	internal class i : global::SSLMangrComp.ConnectionLayer.ServerBase, global::SSLMangrComp.ConnectionLayer.f
	{
		// Token: 0x060001B2 RID: 434 RVA: 0x0001A994 File Offset: 0x00018B94
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void d(global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle A_0)
		{
			short num2;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_39;
					case 1:
						goto IL_D7;
					case 2:
					{
						global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle2;
						if (packetRecivedHandle == packetRecivedHandle2)
						{
							num2 = (short)353894401;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_39;
					}
					}
					break;
					IL_39:
					num2 = (short)492339475;
					short num3 = num2;
					num2 = (short)1061847315;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
					{
						num2 = (short)2082996224;
						if (num2 != 0)
						{
						}
						global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle2 = packetRecivedHandle;
						global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle value = (global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle)global::System.Delegate.Combine(packetRecivedHandle2, A_0);
						packetRecivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle>(ref this.e, value, packetRecivedHandle2);
						num2 = (short)1526661122;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				IL_1C:
				packetRecivedHandle = this.e;
				num2 = (short)549781504;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_D7:
			num2 = (short)1247739904;
			short num4 = num2;
			num2 = (short)1891762177;
			if (num2 != 0)
			{
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0001AACC File Offset: 0x00018CCC
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void c(global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle A_0)
		{
			short num;
			for (;;)
			{
				IL_00:
				num = (short)233177089;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_42;
				}
				int num2;
				global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						goto IL_5F;
					case 1:
						goto IL_FC;
					case 2:
					{
						global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle2;
						if (packetRecivedHandle == packetRecivedHandle2)
						{
							num = (short)33882113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5F;
					}
					}
					break;
					IL_5F:
					num = (short)1428364030;
					short num3 = num;
					num = (short)651500286;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_00;
					default:
					{
						num = (short)1630011392;
						if (num != 0)
						{
						}
						global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle2 = packetRecivedHandle;
						global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle value = (global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle)global::System.Delegate.Remove(packetRecivedHandle2, A_0);
						packetRecivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle>(ref this.e, value, packetRecivedHandle2);
						num = (short)502595586;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
				IL_42:
				packetRecivedHandle = this.e;
				num = (short)1419051008;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			IL_FC:
			num = (short)164167680;
			short num4 = num;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0001AC00 File Offset: 0x00018E00
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void e(global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_67;
			}
			short num;
			int num3;
			global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle;
			for (;;)
			{
				IL_0A:
				num = (short)1631810170;
				short num2 = num;
				num = (short)1520464506;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
				{
					num = (short)1133838336;
					if (num != 0)
					{
					}
					global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle2;
					switch (num3)
					{
					case 0:
						if (errorReceivedHandle == errorReceivedHandle2)
						{
							num = (short)1630339073;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D8;
					case 1:
						return;
					case 2:
						goto IL_D8;
					}
					goto IL_67;
					IL_D8:
					errorReceivedHandle2 = errorReceivedHandle;
					global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle value = (global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle)global::System.Delegate.Combine(errorReceivedHandle2, A_0);
					errorReceivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle>(ref this.f, value, errorReceivedHandle2);
					num = (short)1097203712;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			return;
			IL_67:
			num = (short)1879244800;
			short num4 = num;
			errorReceivedHandle = this.f;
			num = (short)180879361;
			if (num != 0)
			{
			}
			num = (short)668729346;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0001AD38 File Offset: 0x00018F38
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private void d(global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_BA;
			}
			short num;
			int num4;
			global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle;
			for (;;)
			{
				IL_0A:
				num = (short)1125457043;
				short num2 = num;
				num = (short)1207245971;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
				{
					num = (short)906625025;
					if (num != 0)
					{
					}
					num = (short)502398976;
					if (num != 0)
					{
					}
					num = (short)1469186048;
					short num3 = num;
					global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle2;
					switch (num4)
					{
					case 0:
						if (errorReceivedHandle == errorReceivedHandle2)
						{
							num = (short)1555562497;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DB;
					case 1:
						return;
					case 2:
						goto IL_DB;
					}
					goto IL_BA;
					IL_DB:
					errorReceivedHandle2 = errorReceivedHandle;
					global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle value = (global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle)global::System.Delegate.Remove(errorReceivedHandle2, A_0);
					errorReceivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle>(ref this.f, value, errorReceivedHandle2);
					num = (short)446627840;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			return;
			IL_BA:
			errorReceivedHandle = this.f;
			num = (short)14221314;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0001AE74 File Offset: 0x00019074
		public void a(global::SSLMangrComp.PNConnectionInfo A_0)
		{
			short num = (short)363279478;
			short num2 = num;
			num = (short)463156342;
			switch (num2 == num)
			{
			}
			num = (short)622657536;
			if (num != 0)
			{
			}
			num = (short)1257701376;
			short num3 = num;
			num = (short)1737031681;
			if (num != 0)
			{
			}
			this.m_LMode = global::SSLMangrComp.Packets.SubscriptionType.Secure;
			this.d = A_0.TLSServerConfig;
			base.ShutdownServer();
			this._lsnrThread = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.c));
			this._lsnrThread.Start();
			global::System.Threading.Thread.Sleep(500);
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0001AF60 File Offset: 0x00019160
		private void c()
		{
			short num;
			try
			{
				num = (short)2078343168;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					object listenLock = this.m_listenLock;
					bool flag = false;
					try
					{
						switch (0)
						{
						case 0:
							goto IL_4E;
						}
						global::Org.BouncyCastle.Crypto.Tls.Certificate a_2;
						global::Org.BouncyCastle.Crypto.Tls.Certificate a_3;
						global::Org.BouncyCastle.Crypto.Parameters.DHParameters a_4;
						global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter a_5;
						for (;;)
						{
							IL_33:
							switch (num2)
							{
							case 0:
								num = (short)1072496641;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_170;
							case 2:
							{
								if (this.m_stop)
								{
									num = (short)626851840;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::System.Net.Sockets.TcpClient a_ = this.m_listener.AcceptTcpClient();
								global::SSLMangrComp.ConnectionLayer.j j = new global::SSLMangrComp.ConnectionLayer.j(a_2, a_3, a_4, a_5, this.c, a_);
								j.c(new global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle(this.c));
								new global::System.Threading.Thread(new global::System.Threading.ThreadStart(j.Read)).Start();
								this.readWorkers.Add(j);
								num = (short)1784217603;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								goto IL_118;
							case 4:
								goto IL_118;
							}
							goto IL_4E;
							IL_118:
							num = (short)1939996674;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_170:
						break;
						IL_4E:
						global::System.Threading.Monitor.Enter(listenLock, ref flag);
						this.c(out a_2, out a_5, out a_3, out a_4);
						this.m_stop = false;
						this.m_listener = new global::System.Net.Sockets.TcpListener(global::System.Net.IPAddress.Any, 0);
						this.m_listener.Start(500);
						num = (short)1085407236;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_33;
					}
					finally
					{
						num = (short)1344405506;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								global::System.Threading.Monitor.Exit(listenLock);
								num = (short)1088421889;
								if (num != 0)
								{
								}
								num = (short)1988296705;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_206;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1A8;
								}
								continue;
							}
							IL_1A8:
							if (!flag)
							{
								break;
							}
							num = (short)2062417920;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_206:;
					}
					break;
				}
				}
			}
			catch (global::System.Exception ex)
			{
				if (!(ex is global::System.Net.Sockets.SocketException) || ((global::System.Net.Sockets.SocketException)ex).ErrorCode != 10004)
				{
					num = (short)382088310;
					short num3 = num;
					num = (short)542323830;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1518010368;
						if (num != 0)
						{
						}
						global::SSLMangrComp.ErrorReport error = new global::SSLMangrComp.ErrorReport(global::SSLMangrComp.ErrorCategory.LinkEstablishmentError, global::IACustomException.IACommonErrorCode.SSL_LE_LinkShutdownFail);
						global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle = this.f;
						if (errorReceivedHandle != null)
						{
							errorReceivedHandle(error);
						}
						base.ShutdownServer();
						break;
					}
					}
				}
			}
			num = (short)1558642688;
			short num4 = num;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0001B280 File Offset: 0x00019480
		private void c(out global::Org.BouncyCastle.Crypto.Tls.Certificate A_0, out global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter A_1, out global::Org.BouncyCastle.Crypto.Tls.Certificate A_2, out global::Org.BouncyCastle.Crypto.Parameters.DHParameters A_3)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::SSLMangrComp.b b;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
					goto IL_1A7;
				case 2:
					if (this.d.DHParameters != null)
					{
						num2 = (short)1418526721;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
				{
					byte[] certBytes;
					try
					{
						certBytes = global::System.Convert.FromBase64String(this.d.ClientCertificate);
						global::SSLMangrComp.CertificateLoader.LoadPfxCertificate(certBytes, b, out A_0, out A_1);
						goto IL_4C;
					}
					finally
					{
						num2 = (short)1919352834;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_13F;
							case 1:
								goto IL_15B;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_124;
								}
								continue;
							}
							IL_124:
							if (b != null)
							{
								num2 = (short)1018036224;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_15B;
							IL_13F:
							((global::System.IDisposable)b).Dispose();
							num2 = (short)187367425;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_15B:
							num2 = (short)2018374855;
							short num3 = num2;
							num2 = (short)960689351;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_13F;
							default:
								goto IL_191;
							}
						}
						IL_191:
						num2 = (short)1177747456;
						if (num2 != 0)
						{
						}
					}
					goto IL_1A7;
					IL_4C:
					num2 = (short)1731264512;
					short num4 = num2;
					certBytes = global::System.Convert.FromBase64String(this.d.CACertificate);
					A_2 = global::SSLMangrComp.CertificateLoader.LoadBcCertificate(certBytes);
					A_3 = null;
					num2 = (short)933822466;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_20;
				IL_1A7:
				num2 = (short)1704263681;
				if (num2 != 0)
				{
				}
				A_3 = global::SSLMangrComp.CertificateLoader.LoadDhParams(this.d.DHParameters);
				num2 = (short)1824915456;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_20:
			b = new global::SSLMangrComp.b(this.d.ClientKeyPassphrase);
			num2 = (short)2113142787;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0001B498 File Offset: 0x00019698
		public void b(global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle A_0)
		{
			short num = (short)2110156303;
			short num2 = num;
			num = (short)2116251151;
			switch (num2 == num)
			{
			}
			num = (short)2022244353;
			if (num != 0)
			{
			}
			num = (short)1548353536;
			short num3 = num;
			num = (short)1056178176;
			if (num != 0)
			{
			}
			this.d(A_0);
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0001B54C File Offset: 0x0001974C
		public void c(global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle A_0)
		{
			short num = (short)2135701748;
			short num2 = num;
			num = (short)565590260;
			switch (num2 == num)
			{
			}
			num = (short)2015952897;
			if (num != 0)
			{
			}
			num = (short)298516480;
			short num3 = num;
			num = (short)489684992;
			if (num != 0)
			{
			}
			this.e(A_0);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0001B5FC File Offset: 0x000197FC
		protected void c(global::SSLMangrComp.Packets.PacketBase A_0)
		{
			object packetLock = this.packetLock;
			bool flag = false;
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_27;
				}
				int num;
				for (;;)
				{
					IL_15:
					switch (num)
					{
					case 0:
						goto IL_64;
					case 1:
					{
						num2 = (short)434970128;
						short num3 = num2;
						num2 = (short)30219792;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_44;
						default:
							goto IL_B9;
						}
						break;
					}
					case 2:
						goto IL_44;
					}
					goto IL_27;
					IL_44:
					global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle = this.e;
					if (packetRecivedHandle == null)
					{
						num2 = (short)32636928;
						num = (int)((global::System.IntPtr)num2);
					}
					else
					{
						packetRecivedHandle(A_0);
						num2 = (short)1081475073;
						num = (int)((global::System.IntPtr)num2);
					}
				}
				IL_64:
				goto IL_164;
				IL_B9:
				num2 = (short)157876224;
				if (num2 != 0)
				{
				}
				goto IL_164;
				IL_27:
				global::System.Threading.Monitor.Enter(packetLock, ref flag);
				num2 = (short)1039138818;
				num = (int)((global::System.IntPtr)num2);
				goto IL_15;
			}
			finally
			{
				num2 = (short)1691615234;
				int num = (int)((global::System.IntPtr)num2);
				for (;;)
				{
					switch (num)
					{
					case 0:
						global::System.Threading.Monitor.Exit(packetLock);
						num2 = (short)532480001;
						if (num2 != 0)
						{
						}
						num2 = (short)1787691009;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						goto IL_161;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_105;
						}
						continue;
					}
					IL_105:
					if (!flag)
					{
						break;
					}
					num2 = (short)322764800;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_161:;
			}
			IL_164:
			num2 = (short)355205120;
			short num4 = num2;
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0001B7A8 File Offset: 0x000199A8
		protected void c(global::SSLMangrComp.ErrorReport A_0)
		{
			object errorLock = this.errorLock;
			bool flag = false;
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_27;
				}
				int num;
				for (;;)
				{
					IL_15:
					switch (num)
					{
					case 0:
						goto IL_64;
					case 1:
					{
						num2 = (short)1493435012;
						short num3 = num2;
						num2 = (short)1301938820;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_44;
						default:
							goto IL_BA;
						}
						break;
					}
					case 2:
						goto IL_44;
					}
					goto IL_27;
					IL_44:
					global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle = this.f;
					if (errorReceivedHandle == null)
					{
						num2 = (short)1056440320;
						num = (int)((global::System.IntPtr)num2);
					}
					else
					{
						errorReceivedHandle(A_0);
						num2 = (short)1525678081;
						num = (int)((global::System.IntPtr)num2);
					}
				}
				IL_64:
				goto IL_167;
				IL_BA:
				num2 = (short)1518469120;
				if (num2 != 0)
				{
				}
				goto IL_167;
				IL_27:
				global::System.Threading.Monitor.Enter(errorLock, ref flag);
				num2 = (short)370147330;
				num = (int)((global::System.IntPtr)num2);
				goto IL_15;
			}
			finally
			{
				num2 = (short)1044381698;
				int num = (int)((global::System.IntPtr)num2);
				for (;;)
				{
					switch (num)
					{
					case 0:
						global::System.Threading.Monitor.Exit(errorLock);
						num2 = (short)1941176321;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						goto IL_13B;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_104;
						}
						continue;
					}
					IL_104:
					if (!flag)
					{
						break;
					}
					num2 = (short)1406992384;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_13B:
				num2 = (short)1846738945;
				if (num2 != 0)
				{
				}
			}
			IL_167:
			num2 = (short)1705312256;
			short num4 = num2;
		}

		// Token: 0x040000EC RID: 236
		private readonly global::Org.BouncyCastle.Security.SecureRandom c = new global::Org.BouncyCastle.Security.SecureRandom();

		// Token: 0x040000ED RID: 237
		private global::SSLMangrComp.SecureServerConfiguration d;

		// Token: 0x040000EE RID: 238
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle e;

		// Token: 0x040000EF RID: 239
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle f;
	}
}
