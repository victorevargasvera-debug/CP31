using System;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Threading;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Tls;
using Org.BouncyCastle.Security;
using SSLMangrComp.Packets;

namespace SSLMangrComp.ConnectionLayer
{
	// Token: 0x02000047 RID: 71
	internal class j : global::SSLMangrComp.ConnectionLayer.IServerWorker
	{
		// Token: 0x060001BE RID: 446 RVA: 0x0001B978 File Offset: 0x00019B78
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		public void c(global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle A_0)
		{
			short num = (short)1480196097;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_B8;
			}
			int num4;
			global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle;
			for (;;)
			{
				IL_32:
				num = (short)1201498455;
				short num2 = num;
				num = (short)2095212887;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
				{
					num = (short)68091904;
					if (num != 0)
					{
					}
					num = (short)773914624;
					short num3 = num;
					global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle2;
					switch (num4)
					{
					case 0:
						if (packetRecivedHandle == packetRecivedHandle2)
						{
							num = (short)241500161;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D8;
					case 1:
						return;
					case 2:
						goto IL_D8;
					}
					goto IL_B8;
					IL_D8:
					packetRecivedHandle2 = packetRecivedHandle;
					global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle value = (global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle)global::System.Delegate.Combine(packetRecivedHandle2, A_0);
					packetRecivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle>(ref this.h, value, packetRecivedHandle2);
					num = (short)2066808832;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			return;
			IL_B8:
			packetRecivedHandle = this.h;
			num = (short)221970434;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0001BAB0 File Offset: 0x00019CB0
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		public void d(global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_67;
			}
			short num;
			int num3;
			global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle;
			for (;;)
			{
				IL_0A:
				num = (short)651444215;
				short num2 = num;
				num = (short)709246967;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_105;
				default:
				{
					num = (short)1101070336;
					if (num != 0)
					{
					}
					global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle2;
					switch (num3)
					{
					case 0:
						if (packetRecivedHandle == packetRecivedHandle2)
						{
							num = (short)1806827521;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B2;
					case 1:
						goto IL_103;
					case 2:
						goto IL_B2;
					}
					goto IL_67;
					IL_B2:
					packetRecivedHandle2 = packetRecivedHandle;
					global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle value = (global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle)global::System.Delegate.Remove(packetRecivedHandle2, A_0);
					packetRecivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle>(ref this.h, value, packetRecivedHandle2);
					num = (short)847314944;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			IL_103:
			IL_105:
			num = (short)1481572353;
			if (num != 0)
			{
			}
			return;
			IL_67:
			num = (short)1726939136;
			short num4 = num;
			packetRecivedHandle = this.h;
			num = (short)1083572226;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0001BBEC File Offset: 0x00019DEC
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		public void c(global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle A_0)
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
				num = (short)1077438611;
				short num2 = num;
				num = (short)541616275;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
				{
					num = (short)1954086912;
					if (num != 0)
					{
					}
					global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle2;
					switch (num3)
					{
					case 0:
						if (errorReceivedHandle == errorReceivedHandle2)
						{
							num = (short)2146697217;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D5;
					case 1:
						return;
					case 2:
						goto IL_D5;
					}
					goto IL_67;
					IL_D5:
					errorReceivedHandle2 = errorReceivedHandle;
					global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle value = (global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle)global::System.Delegate.Combine(errorReceivedHandle2, A_0);
					errorReceivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle>(ref this.i, value, errorReceivedHandle2);
					num = (short)804978688;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			return;
			IL_67:
			num = (short)1149763584;
			short num4 = num;
			errorReceivedHandle = this.i;
			num = (short)1212612609;
			if (num != 0)
			{
			}
			num = (short)1472593922;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0001BD20 File Offset: 0x00019F20
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		public void d(global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_68;
			}
			short num;
			int num3;
			global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle;
			for (;;)
			{
				IL_0A:
				num = (short)654891937;
				short num2 = num;
				num = (short)1417272225;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_105;
				default:
				{
					num = (short)2009923584;
					if (num != 0)
					{
					}
					global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle errorReceivedHandle2;
					switch (num3)
					{
					case 0:
						if (errorReceivedHandle == errorReceivedHandle2)
						{
							num = (short)617676801;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B3;
					case 1:
						goto IL_103;
					case 2:
						goto IL_B3;
					}
					goto IL_68;
					IL_B3:
					errorReceivedHandle2 = errorReceivedHandle;
					global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle value = (global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle)global::System.Delegate.Remove(errorReceivedHandle2, A_0);
					errorReceivedHandle = global::System.Threading.Interlocked.CompareExchange<global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle>(ref this.i, value, errorReceivedHandle2);
					num = (short)1772093440;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			IL_103:
			IL_105:
			num = (short)1437007873;
			if (num != 0)
			{
			}
			return;
			IL_68:
			num = (short)994377728;
			short num4 = num;
			errorReceivedHandle = this.i;
			num = (short)833814530;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0001BE5C File Offset: 0x0001A05C
		public j(global::Org.BouncyCastle.Crypto.Tls.Certificate A_0, global::Org.BouncyCastle.Crypto.Tls.Certificate A_1, global::Org.BouncyCastle.Crypto.Parameters.DHParameters A_2, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter A_3, global::Org.BouncyCastle.Security.SecureRandom A_4, global::System.Net.Sockets.TcpClient A_5)
		{
			this.a = A_0;
			this.b = A_1;
			this.c = A_3;
			this.d = A_2;
			this.e = A_4;
			this.f = A_5;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0001BEB4 File Offset: 0x0001A0B4
		public void Read()
		{
			short num;
			for (;;)
			{
				num = (short)937689089;
				if (num != 0)
				{
				}
				global::System.IO.Stream a_ = new global::SSLMangrComp.ConnectionLayer.e(this.f.GetStream(), false);
				try
				{
					global::SSLMangrComp.ConnectionLayer.a tlsServer = new global::SSLMangrComp.ConnectionLayer.a(this.a, this.b, this.c, this.d);
					global::SSLMangrComp.a a = new global::SSLMangrComp.a(a_, this.e);
					a.Accept(tlsServer);
					a_ = a.Stream;
					this.c(a_);
					a.Close();
				}
				catch (global::System.Exception)
				{
					global::SSLMangrComp.Packets.Notify packet = new global::SSLMangrComp.Packets.Notify(this.j, 2)
					{
						MessageID = byte.MaxValue,
						IsPacketRecived = true
					};
					global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle packetRecivedHandle = this.h;
					if (packetRecivedHandle != null)
					{
						packetRecivedHandle(packet);
					}
				}
				finally
				{
					this.f.Close();
				}
				num = (short)1915158528;
				short num2 = num;
				num = (short)443757694;
				short num3 = num;
				num = (short)606155902;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_126;
				}
			}
			IL_126:
			num = (short)1658454016;
			if (num != 0)
			{
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0001C018 File Offset: 0x0001A218
		private void c(global::System.IO.Stream A_0)
		{
			short num = (short)1593507840;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_66;
				}
				global::SSLMangrComp.ConnectionLayer.b b;
				byte[] array;
				int num3;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_1A8;
					case 1:
						goto IL_1E0;
					case 2:
						goto IL_9C;
					case 3:
						return;
					case 4:
						b.a(array, num3);
						num = (short)1832452105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						num = (short)1195512726;
						short num4 = num;
						num = (short)363271062;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1E0;
						default:
							num = (short)837812224;
							if (num != 0)
							{
							}
							if (this.h != null)
							{
								num = (short)276430859;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_9C;
						}
						break;
					}
					case 6:
						goto IL_1A8;
					case 7:
					{
						byte[] data;
						if ((data = b.b()) == null)
						{
							num = (short)926482438;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1351286789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						try
						{
							num = (short)1737883649;
							if (num != 0)
							{
							}
							num3 = A_0.Read(array, 0, array.Length);
							goto IL_2A0;
						}
						catch (global::System.Exception)
						{
							num3 = 0;
							goto IL_2A0;
						}
						goto IL_1A8;
						IL_2A0:
						num = (short)711983117;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_9C;
					case 10:
						if (num3 > 0)
						{
							num = (short)1980039169;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 11:
					{
						byte[] data;
						global::SSLMangrComp.Packets.PacketBase packet = global::SSLMangrComp.Packets.PacketFactory.GetPacket(data, 2);
						packet.IsPacketRecived = true;
						this.h(packet);
						num = (short)1410007042;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						if (this.g)
						{
							num = (short)263847936;
							short num5 = num;
							num = (short)657129475;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)992542728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (num3 > 0)
						{
							num = (short)35061764;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_66;
					IL_9C:
					num = (short)4653063;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A8:
					num = (short)34865162;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E0:
					num = (short)1295646732;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_66:
				array = new byte[1024];
				b = new global::SSLMangrComp.ConnectionLayer.b(2048);
				num3 = 10000;
				num = (short)1004470272;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0001C334 File Offset: 0x0001A534
		public void Close()
		{
			short num = (short)292945922;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)142737409;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (this.f.Connected)
					{
						num = (short)1304363015;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E0;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 3:
					num = (short)488177665;
					if (num != 0)
					{
					}
					this.f.GetStream().Close();
					num = (short)424017925;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_1F7;
				case 5:
					goto IL_1B5;
				case 6:
					if (this.f.Connected)
					{
						num = (short)1078263811;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 7:
					num = (short)1681653768;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (this.f.Available > 0)
					{
						num = (short)1071906820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E0;
				}
				IL_49:
				num = (short)1853751296;
				short num3 = num;
				if (this.f == null)
				{
					break;
				}
				num = (short)681738840;
				short num4 = num;
				num = (short)1516929624;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
					num = (short)86638592;
					if (num != 0)
					{
					}
					num = (short)929562624;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_E0:
				num = (short)1068892166;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1B5:
			return;
			IL_1F7:
			this.g = true;
		}

		// Token: 0x040000F0 RID: 240
		private readonly global::Org.BouncyCastle.Crypto.Tls.Certificate a;

		// Token: 0x040000F1 RID: 241
		private readonly global::Org.BouncyCastle.Crypto.Tls.Certificate b;

		// Token: 0x040000F2 RID: 242
		private readonly global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter c;

		// Token: 0x040000F3 RID: 243
		private readonly global::Org.BouncyCastle.Crypto.Parameters.DHParameters d;

		// Token: 0x040000F4 RID: 244
		private readonly global::Org.BouncyCastle.Security.SecureRandom e;

		// Token: 0x040000F5 RID: 245
		private readonly global::System.Net.Sockets.TcpClient f;

		// Token: 0x040000F6 RID: 246
		private bool g;

		// Token: 0x040000F7 RID: 247
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SSLMangrComp.ConnectionLayer.PacketRecivedHandle h;

		// Token: 0x040000F8 RID: 248
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SSLMangrComp.ConnectionLayer.ErrorReceivedHandle i;

		// Token: 0x040000F9 RID: 249
		public byte[] j = new byte[]
		{
			28,
			0,
			4,
			1,
			0,
			3,
			1,
			2,
			1,
			4,
			0,
			174,
			209,
			127,
			10,
			6,
			49,
			0,
			49,
			0,
			49,
			0,
			2,
			2,
			48,
			0,
			14,
			2,
			48,
			0
		};
	}
}
