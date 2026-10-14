using System;
using System.Net;
using System.Runtime.CompilerServices;
using System.Threading;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Comms;
using SSLMangrComp;
using SSLMangrComp.Packets;

namespace SpecialFeatures.Programming
{
	// Token: 0x02000089 RID: 137
	public class ARSGetIPAddressWorker
	{
		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000A78 RID: 2680 RVA: 0x000C1E80 File Offset: 0x000C0080
		// (remove) Token: 0x06000A79 RID: 2681 RVA: 0x000C1FB8 File Offset: 0x000C01B8
		public event global::SpecialFeatures.Programming.ARSGetIPAddressCompleted GetIPAddressCompletedEvent
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::SpecialFeatures.Programming.ARSGetIPAddressCompleted arsgetIPAddressCompleted;
				short num2;
				for (;;)
				{
					IL_0A:
					global::SpecialFeatures.Programming.ARSGetIPAddressCompleted arsgetIPAddressCompleted2;
					switch (num)
					{
					case 0:
						if (arsgetIPAddressCompleted == arsgetIPAddressCompleted2)
						{
							num2 = (short)623640577;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_62;
					case 1:
						return;
					case 2:
						goto IL_62;
					}
					goto IL_1C;
					IL_62:
					arsgetIPAddressCompleted2 = arsgetIPAddressCompleted;
					global::SpecialFeatures.Programming.ARSGetIPAddressCompleted value2 = (global::SpecialFeatures.Programming.ARSGetIPAddressCompleted)global::System.Delegate.Combine(arsgetIPAddressCompleted2, value);
					arsgetIPAddressCompleted = global::System.Threading.Interlocked.CompareExchange<global::SpecialFeatures.Programming.ARSGetIPAddressCompleted>(ref this.s, value2, arsgetIPAddressCompleted2);
					num2 = (short)511264003;
					short num3 = num2;
					num2 = (short)1830896899;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)1275854848;
						if (num2 != 0)
						{
						}
						num2 = (short)49283072;
						short num4 = num2;
						num2 = (short)92536832;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				num2 = (short)981663745;
				if (num2 != 0)
				{
				}
				arsgetIPAddressCompleted = this.s;
				num2 = (short)433782786;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				int num;
				global::SpecialFeatures.Programming.ARSGetIPAddressCompleted arsgetIPAddressCompleted;
				short num2;
				for (;;)
				{
					IL_0A:
					global::SpecialFeatures.Programming.ARSGetIPAddressCompleted arsgetIPAddressCompleted2;
					switch (num)
					{
					case 0:
						if (arsgetIPAddressCompleted == arsgetIPAddressCompleted2)
						{
							num2 = (short)1965424641;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_5F;
					case 1:
						return;
					case 2:
						num2 = (short)1819344897;
						if (num2 != 0)
						{
						}
						goto IL_5F;
					}
					goto IL_1C;
					IL_5F:
					arsgetIPAddressCompleted2 = arsgetIPAddressCompleted;
					global::SpecialFeatures.Programming.ARSGetIPAddressCompleted value2 = (global::SpecialFeatures.Programming.ARSGetIPAddressCompleted)global::System.Delegate.Remove(arsgetIPAddressCompleted2, value);
					arsgetIPAddressCompleted = global::System.Threading.Interlocked.CompareExchange<global::SpecialFeatures.Programming.ARSGetIPAddressCompleted>(ref this.s, value2, arsgetIPAddressCompleted2);
					num2 = (short)146542742;
					short num3 = num2;
					num2 = (short)989794454;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)1063059456;
						if (num2 != 0)
						{
						}
						num2 = (short)875233280;
						short num4 = num2;
						num2 = (short)421134336;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
					}
				}
				return;
				IL_1C:
				arsgetIPAddressCompleted = this.s;
				num2 = (short)723255298;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x06000A7A RID: 2682 RVA: 0x000C20F0 File Offset: 0x000C02F0
		public ARSGetIPAddressWorker(string strARSIPAddr, ushort portNum1, ushort portNum2, string cipherSuite, global::SSLMangrComp.Packets.SubscriptionType mode, bool conectionType, string Ca_Cert, string Client_Cert, string pssPhrase, int timeout, byte[] dh)
		{
			this.a = strARSIPAddr;
			this.f = portNum1;
			this.g = portNum2;
			this.h = cipherSuite;
			this.i = mode;
			this.j = conectionType;
			this.l = Ca_Cert;
			this.m = Client_Cert;
			this.k = pssPhrase;
			this.b = timeout;
			this.e = null;
			this.p = string.Empty;
			this.o = new global::SSLMangrComp.PresenceNotification();
			this.q = new global::SSLMangrComp.PNConnectionInfo();
			this.n = new byte[dh.Length];
			this.n = dh;
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x000C21B0 File Offset: 0x000C03B0
		// (set) Token: 0x06000A7C RID: 2684 RVA: 0x000C2260 File Offset: 0x000C0460
		internal int SocketTimeout
		{
			get
			{
				short num = (short)802595334;
				short num2 = num;
				num = (short)310026758;
				switch (num2 == num)
				{
				}
				num = (short)368312320;
				if (num != 0)
				{
				}
				num = (short)2038759424;
				short num3 = num;
				num = (short)462749697;
				if (num != 0)
				{
				}
				return this.b;
			}
			set
			{
				short num = (short)371937428;
				short num2 = num;
				num = (short)1963348116;
				switch (num2 == num)
				{
				}
				num = (short)2005336064;
				if (num != 0)
				{
				}
				num = (short)493027328;
				short num3 = num;
				num = (short)1230635009;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x000C2314 File Offset: 0x000C0514
		internal void GetIPAddressAsync(string deviceID, object state)
		{
			short num = (short)337641474;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				bool flag;
				switch (num2)
				{
				case 0:
				{
					num = (short)1566900225;
					if (num != 0)
					{
					}
					num = (short)2082668544;
					short num3 = num;
					goto IL_275;
				}
				case 1:
					try
					{
						switch (0)
						{
						case 0:
							goto IL_CF;
						}
						for (;;)
						{
							IL_B1:
							switch (num2)
							{
							case 0:
							{
								num = (short)2035725400;
								short num4 = num;
								num = (short)339588184;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_17B;
								default:
									num = (short)1592721408;
									if (num != 0)
									{
									}
									goto IL_10A;
								}
								break;
							}
							case 1:
								goto IL_1F0;
							case 2:
								if (this.e != null)
								{
									num = (short)324468741;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_10A;
							case 3:
								goto IL_17B;
							case 4:
								goto IL_209;
							case 5:
								num = (short)1829175299;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_CF;
							IL_10A:
							this.c = deviceID;
							this.d = state;
							this.e = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.a));
							this.e.IsBackground = true;
							this.e.Start();
							num = (short)748421121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_17B:
							if (!this.e.IsAlive)
							{
								num = (short)948830208;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_1F0:
							num = (short)60489732;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_209:
						return;
						IL_CF:
						global::System.Threading.Monitor.Enter(this, ref flag);
						num = (short)1766391810;
						num2 = (int)((global::System.IntPtr)num);
						goto IL_B1;
					}
					finally
					{
						num = (short)3211266;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								global::System.Threading.Monitor.Exit(this);
								num = (short)298385409;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_272;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_23E;
								}
								continue;
							}
							IL_23E:
							if (!flag)
							{
								break;
							}
							num = (short)1268121600;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_272:;
					}
					goto IL_275;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				if (this.s != null)
				{
					num = (short)1105199104;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_275:
				flag = false;
				num = (short)245104641;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x06000A7E RID: 2686 RVA: 0x000C25D4 File Offset: 0x000C07D4
		private void a()
		{
			int a_ = 10;
			short num = (short)1504968704;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7B;
				}
				int num3;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						goto IL_24A;
					case 1:
					{
						global::SpecialFeatures.Programming.OTAPPrescenceResult result;
						this.s(result, this.d);
						num = (short)529334279;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_208;
					case 3:
						if (num3 == 1)
						{
							num = (short)128516111;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2069037061;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_208;
					case 5:
						if (num3 == 2)
						{
							num = (short)812974090;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)234029067;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						try
						{
							this.o = global::SpecialFeatures.Comms.DeviceManagerSingleTon.Instance.RetrievePresenceInfo(this.q);
							num3 = (int)this.o.PresenceState;
							goto IL_4F3;
						}
						catch (global::System.Exception ex)
						{
							this.p = ex.Message;
							goto IL_4F3;
						}
						goto IL_208;
						IL_4F3:
						num = (short)577437699;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						return;
					case 8:
						goto IL_208;
					case 9:
					{
						global::SpecialFeatures.Programming.OTAPPrescenceResult result = new global::SpecialFeatures.Programming.OTAPPrescenceResult(global::SpecialFeatures.Programming.OTAP_SUBSCRIBER_NETWORK_PRESCENCE.OTAP_RADIO_STATUS_TIMEOUT, this.c, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("붌ꆎꆐ붒ꖔ릖ꦘ", a_), this.p);
						num = (short)241696772;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						global::SpecialFeatures.Programming.OTAPPrescenceResult result = new global::SpecialFeatures.Programming.OTAPPrescenceResult(global::SpecialFeatures.Programming.OTAP_SUBSCRIBER_NETWORK_PRESCENCE.OTAP_RADIO_STATUS_ABSENT, this.c, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("붌ꆎꆐ붒ꖔ릖ꦘ", a_), this.p);
						num = (short)114950158;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						if (num3 == -7)
						{
							num = (short)1905197065;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::SpecialFeatures.Programming.OTAPPrescenceResult result = new global::SpecialFeatures.Programming.OTAPPrescenceResult(global::SpecialFeatures.Programming.OTAP_SUBSCRIBER_NETWORK_PRESCENCE.OTAP_RADIO_STATUS_UNKNOWN, this.c, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("붌ꆎꆐ붒ꖔ릖ꦘ", a_), this.p);
						num = (short)2073100290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						if (!this.j)
						{
							goto IL_24A;
						}
						num = (short)1242381502;
						short num4 = num;
						num = (short)1663646910;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_221;
						default:
						{
							num = (short)1196425216;
							if (num != 0)
							{
							}
							num = (short)830406657;
							if (num != 0)
							{
							}
							num = (short)2064252928;
							short num5 = num;
							num = (short)943718413;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 13:
						this.q.TLSClientConfig = new global::SSLMangrComp.SecureClientConfiguration();
						this.q.TLSServerConfig = new global::SSLMangrComp.SecureServerConfiguration();
						this.q.TLSClientConfig.CACertificate = this.l;
						this.q.TLSClientConfig.CipherSuites = this.h;
						this.q.TLSClientConfig.ClientCertificate = this.m;
						this.q.TLSClientConfig.ClientKeyPassphrase = this.k;
						this.q.TLSServerConfig.CACertificate = this.l;
						this.q.TLSServerConfig.CipherSuites = this.h;
						this.q.TLSServerConfig.ClientCertificate = this.m;
						this.q.TLSServerConfig.ClientKeyPassphrase = this.k;
						this.q.TLSServerConfig.DHParameters = this.n;
						num = (short)452788224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_208;
					case 15:
					{
						global::SpecialFeatures.Programming.OTAPPrescenceResult result = new global::SpecialFeatures.Programming.OTAPPrescenceResult(global::SpecialFeatures.Programming.OTAP_SUBSCRIBER_NETWORK_PRESCENCE.OTAP_RADIO_STATUS_PRESENT, this.c, this.o.IPAddr, this.p);
						num = (short)57081864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						goto IL_221;
					}
					goto IL_7B;
					IL_208:
					num = (short)790364176;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_221:
					if (this.s != null)
					{
						num = (short)1749942273;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_24A:
					global::SSLMangrComp.ConnectionConfig connectionConfig = new global::SSLMangrComp.ConnectionConfig();
					connectionConfig.ConnectionAttemptTimeout = this.b;
					connectionConfig.EntityType = global::SSLMangrComp.Packets.EntitiesTypes.DeviceID;
					connectionConfig.EntityValue = this.c;
					connectionConfig.Expiration = 0;
					connectionConfig.PnIp = global::System.Net.IPAddress.Parse(this.a);
					connectionConfig.PnPort = (int)this.f;
					connectionConfig.SubscriptionMode = this.i;
					this.q.PNConnectionConfig = connectionConfig;
					num = (short)878247942;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_7B:
				num3 = -1;
				num = (short)1767374860;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x04000427 RID: 1063
		private string a;

		// Token: 0x04000428 RID: 1064
		private int b;

		// Token: 0x04000429 RID: 1065
		private string c;

		// Token: 0x0400042A RID: 1066
		private object d;

		// Token: 0x0400042B RID: 1067
		private global::System.Threading.Thread e;

		// Token: 0x0400042C RID: 1068
		private ushort f;

		// Token: 0x0400042D RID: 1069
		private ushort g;

		// Token: 0x0400042E RID: 1070
		private string h;

		// Token: 0x0400042F RID: 1071
		private global::SSLMangrComp.Packets.SubscriptionType i;

		// Token: 0x04000430 RID: 1072
		private bool j;

		// Token: 0x04000431 RID: 1073
		private string k = string.Empty;

		// Token: 0x04000432 RID: 1074
		private string l = string.Empty;

		// Token: 0x04000433 RID: 1075
		private string m = string.Empty;

		// Token: 0x04000434 RID: 1076
		private byte[] n;

		// Token: 0x04000435 RID: 1077
		private global::SSLMangrComp.PresenceNotification o;

		// Token: 0x04000436 RID: 1078
		private string p;

		// Token: 0x04000437 RID: 1079
		private global::SSLMangrComp.PNConnectionInfo q;

		// Token: 0x04000438 RID: 1080
		private const string r = "{8442AEE9-C610-4FEB-8577-2977C98C6DE2}";

		// Token: 0x04000439 RID: 1081
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::SpecialFeatures.Programming.ARSGetIPAddressCompleted s;
	}
}
