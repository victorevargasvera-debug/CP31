using System;
using System.Net;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Comms;
using SpecialFeatures.Programming;
using SSLMangrComp;
using SSLMangrComp.Packets;

namespace SpecialFeatures.POP25BatchProgrammer
{
	// Token: 0x0200009B RID: 155
	public class ARSGetPOP25BatchIPAddress
	{
		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06000B00 RID: 2816 RVA: 0x000D1048 File Offset: 0x000CF248
		internal global::SpecialFeatures.Programming.OTAPPrescenceResult ARSResult
		{
			get
			{
				short num = (short)594411520;
				short num2 = num;
				num = (short)2091646977;
				if (num != 0)
				{
				}
				num = (short)923677000;
				short num3 = num;
				num = (short)1742090568;
				switch (num3 == num)
				{
				}
				num = (short)455475200;
				if (num != 0)
				{
				}
				return this.d;
			}
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x000D10F8 File Offset: 0x000CF2F8
		internal ARSGetPOP25BatchIPAddress(string strARSIPAddr, ushort portNum1, ushort portNum2, string cipherSuite, global::SSLMangrComp.Packets.SubscriptionType mode, int deviceID, bool conectionType, string Ca_Cert, string Client_Cert, string pssPhrase, byte[] dhk)
		{
			this.a = strARSIPAddr;
			this.e = portNum1;
			this.f = portNum2;
			this.g = cipherSuite;
			this.h = mode;
			this.c = deviceID.ToString();
			this.i = conectionType;
			this.k = Ca_Cert;
			this.l = Client_Cert;
			this.j = pssPhrase;
			this.b = 8;
			this.m = dhk;
			this.n = new global::SSLMangrComp.PresenceNotification();
			this.p = new global::SSLMangrComp.PNConnectionInfo();
		}

		// Token: 0x06000B02 RID: 2818 RVA: 0x000D11A4 File Offset: 0x000CF3A4
		internal void GetIPAddressFromARS()
		{
			int a_ = 12;
			switch (0)
			{
			case 0:
				goto IL_41;
			}
			short num2;
			int num4;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					if (this.i)
					{
						num2 = (short)85262338;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1BE;
				case 1:
					goto IL_23A;
				case 2:
				{
					this.p.TLSClientConfig = new global::SSLMangrComp.SecureClientConfiguration();
					this.p.TLSServerConfig = new global::SSLMangrComp.SecureServerConfiguration();
					this.p.TLSClientConfig.CACertificate = this.k;
					this.p.TLSClientConfig.CipherSuites = this.g;
					this.p.TLSClientConfig.ClientCertificate = this.l;
					this.p.TLSClientConfig.ClientKeyPassphrase = this.j;
					this.p.TLSServerConfig.CACertificate = this.k;
					this.p.TLSServerConfig.CipherSuites = this.g;
					this.p.TLSServerConfig.ClientCertificate = this.l;
					this.p.TLSServerConfig.ClientKeyPassphrase = this.j;
					this.p.TLSServerConfig.DHParameters = this.m;
					num2 = (short)880672768;
					short num3 = num2;
					num2 = (short)1783365636;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					try
					{
						this.n = global::SpecialFeatures.Comms.DeviceManagerSingleTon.Instance.RetrievePresenceInfo(this.p);
						num4 = (int)this.n.PresenceState;
					}
					catch (global::System.Exception ex)
					{
						this.o = ex.Message;
					}
					num2 = (short)837681157;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_1BE;
				case 5:
					if (num4 == 1)
					{
						num2 = (short)1719926791;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)755957768;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (num4 == -7)
					{
						num2 = (short)1196228609;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_43C;
				case 7:
					goto IL_437;
				case 8:
					if (num4 == 2)
					{
						num2 = (short)1381302281;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1DC;
				case 9:
					goto IL_3A2;
				}
				goto IL_41;
				IL_1BE:
				num2 = (short)2060451843;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_23A:
			this.d = new global::SpecialFeatures.Programming.OTAPPrescenceResult(global::SpecialFeatures.Programming.OTAP_SUBSCRIBER_NETWORK_PRESCENCE.OTAP_RADIO_STATUS_TIMEOUT, this.c, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뾎뾐ꎒ뮔Ꞗ래ꮚ", a_), this.o);
			return;
			IL_3A2:
			this.d = new global::SpecialFeatures.Programming.OTAPPrescenceResult(global::SpecialFeatures.Programming.OTAP_SUBSCRIBER_NETWORK_PRESCENCE.OTAP_RADIO_STATUS_ABSENT, this.c, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뾎뾐ꎒ뮔Ꞗ래ꮚ", a_), this.o);
			return;
			IL_437:
			this.d = new global::SpecialFeatures.Programming.OTAPPrescenceResult(global::SpecialFeatures.Programming.OTAP_SUBSCRIBER_NETWORK_PRESCENCE.OTAP_RADIO_STATUS_PRESENT, this.c, this.n.IPAddr, this.o);
			return;
			IL_43C:
			this.d = new global::SpecialFeatures.Programming.OTAPPrescenceResult(global::SpecialFeatures.Programming.OTAP_SUBSCRIBER_NETWORK_PRESCENCE.OTAP_RADIO_STATUS_UNKNOWN, this.c, global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("뾎뾐ꎒ뮔Ꞗ래ꮚ", a_), this.o);
			return;
			IL_41:
			num4 = -1;
			this.p.PNConnectionConfig = new global::SSLMangrComp.ConnectionConfig();
			this.p.PNConnectionConfig.ConnectionAttemptTimeout = this.b;
			this.p.PNConnectionConfig.EntityType = global::SSLMangrComp.Packets.EntitiesTypes.DeviceID;
			this.p.PNConnectionConfig.EntityValue = this.c;
			this.p.PNConnectionConfig.Expiration = 0;
			this.p.PNConnectionConfig.PnIp = global::System.Net.IPAddress.Parse(this.a);
			this.p.PNConnectionConfig.PnPort = (int)this.e;
			this.p.PNConnectionConfig.SubscriptionMode = this.h;
			num2 = (short)145992516;
			short num5 = num2;
			num2 = (short)1994238788;
			switch ((num5 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_1DC:
				num2 = (short)1290993665;
				if (num2 != 0)
				{
				}
				num2 = (short)359530502;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			default:
			{
				num2 = (short)307822592;
				if (num2 != 0)
				{
				}
				num2 = (short)1333723136;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x0400049B RID: 1179
		private string a;

		// Token: 0x0400049C RID: 1180
		private int b;

		// Token: 0x0400049D RID: 1181
		private string c;

		// Token: 0x0400049E RID: 1182
		private global::SpecialFeatures.Programming.OTAPPrescenceResult d;

		// Token: 0x0400049F RID: 1183
		private ushort e;

		// Token: 0x040004A0 RID: 1184
		private ushort f;

		// Token: 0x040004A1 RID: 1185
		private string g;

		// Token: 0x040004A2 RID: 1186
		private global::SSLMangrComp.Packets.SubscriptionType h;

		// Token: 0x040004A3 RID: 1187
		private bool i;

		// Token: 0x040004A4 RID: 1188
		private string j = string.Empty;

		// Token: 0x040004A5 RID: 1189
		private string k = string.Empty;

		// Token: 0x040004A6 RID: 1190
		private string l = string.Empty;

		// Token: 0x040004A7 RID: 1191
		private byte[] m;

		// Token: 0x040004A8 RID: 1192
		private global::SSLMangrComp.PresenceNotification n;

		// Token: 0x040004A9 RID: 1193
		private string o;

		// Token: 0x040004AA RID: 1194
		private global::SSLMangrComp.PNConnectionInfo p;

		// Token: 0x040004AB RID: 1195
		private const string q = "{8442AEE9-C610-4FEB-8577-2977C98C6DE2}";
	}
}
