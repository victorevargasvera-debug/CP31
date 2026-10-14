using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationManager;
using Motorola.Common.Communication.Pba;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.Service
{
	// Token: 0x02000007 RID: 7
	[global::System.ServiceModel.ServiceBehavior(ConcurrencyMode = global::System.ServiceModel.ConcurrencyMode.Multiple, InstanceContextMode = global::System.ServiceModel.InstanceContextMode.PerSession)]
	public class MotorolaDeviceOperation : global::Motorola.Common.Communication.Service.IDeviceOperation
	{
		// Token: 0x0600004D RID: 77 RVA: 0x00005B24 File Offset: 0x00003D24
		public global::System.IAsyncResult BeginForceWriteDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)187760881;
			short num2 = num;
			num = (short)1843593457;
			switch (num2 == num)
			{
			}
			num = (short)773390337;
			if (num != 0)
			{
			}
			num = (short)1053818880;
			if (num != 0)
			{
			}
			num = (short)1023606784;
			short num3 = num;
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.a a = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.a();
			a.a = this;
			a.b = deviceInfo;
			a.c = pbaObject;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(a.d));
			this.a.b(c);
			return c;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00005C10 File Offset: 0x00003E10
		public void EndForceWriteDevice(global::System.IAsyncResult asyncResult)
		{
			short num = (short)206732491;
			short num2 = num;
			num = (short)2029485259;
			switch (num2 == num)
			{
			}
			num = (short)1284767745;
			if (num != 0)
			{
			}
			num = (short)1019281408;
			if (num != 0)
			{
			}
			num = (short)1626406912;
			short num3 = num;
			this.a();
			global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00005CC8 File Offset: 0x00003EC8
		public void ForceWriteDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			short num = (short)959527741;
			short num2 = num;
			num = (short)1602632509;
			switch (num2 == num)
			{
			}
			num = (short)1591672833;
			if (num != 0)
			{
			}
			num = (short)1075970048;
			if (num != 0)
			{
			}
			num = (short)83886080;
			short num3 = num;
			global::System.IAsyncResult asyncResult = this.BeginForceWriteDevice(deviceInfo, pbaObject, null, null, null);
			this.EndForceWriteDevice(asyncResult);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00005D84 File Offset: 0x00003F84
		private void f(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.Pba.PbaObject A_1)
		{
			short num = (short)156273552;
			short num2 = num;
			num = (short)2084342672;
			switch (num2 == num)
			{
			}
			num = (short)1275658240;
			if (num != 0)
			{
			}
			num = (short)980287489;
			if (num != 0)
			{
			}
			num = (short)1302855680;
			short num3 = num;
			this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program).ForceWriteDevice(A_1);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00005E3C File Offset: 0x0000403C
		public void DepotForceWriteDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			short num = (short)230595575;
			short num2 = num;
			num = (short)2069208055;
			switch (num2 == num)
			{
			}
			num = (short)2043936769;
			if (num != 0)
			{
			}
			num = (short)690094080;
			if (num != 0)
			{
			}
			num = (short)1785659392;
			short num3 = num;
			global::System.IAsyncResult asyncResult = this.BeginDepotForceWriteDevice(deviceInfo, pbaObject, null, null, null);
			this.EndDepotForceWriteDevice(asyncResult);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00005EF8 File Offset: 0x000040F8
		public global::System.IAsyncResult BeginDepotForceWriteDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)849765229;
			short num2 = num;
			num = (short)563176301;
			switch (num2 == num)
			{
			}
			num = (short)185925633;
			if (num != 0)
			{
			}
			num = (short)1883963392;
			if (num != 0)
			{
			}
			num = (short)515047424;
			short num3 = num;
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.b b = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.b();
			b.a = this;
			b.b = deviceInfo;
			b.c = pbaObject;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(b.d));
			this.a.b(c);
			return c;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00005FE8 File Offset: 0x000041E8
		private void e(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.Pba.PbaObject A_1)
		{
			short num = (short)1821637350;
			short num2 = num;
			num = (short)1359543014;
			switch (num2 == num)
			{
			}
			num = (short)555155456;
			if (num != 0)
			{
			}
			num = (short)115605505;
			if (num != 0)
			{
			}
			num = (short)1522991104;
			short num3 = num;
			this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program).DepotForceWriteDevice(A_1);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000060A4 File Offset: 0x000042A4
		public void EndDepotForceWriteDevice(global::System.IAsyncResult asyncResult)
		{
			short num = (short)1968270178;
			short num2 = num;
			num = (short)119303010;
			switch (num2 == num)
			{
			}
			num = (short)1344602113;
			if (num != 0)
			{
			}
			num = (short)698023936;
			if (num != 0)
			{
			}
			num = (short)1479933952;
			short num3 = num;
			this.a();
			global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x0000615C File Offset: 0x0000435C
		public global::System.IAsyncResult BeginUnkillRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte[] values, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)965028007;
			short num2 = num;
			num = (short)690825383;
			switch (num2 == num)
			{
			}
			num = (short)846594049;
			if (num != 0)
			{
			}
			num = (short)1075249152;
			if (num != 0)
			{
			}
			num = (short)1388183552;
			short num3 = num;
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.c c = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.c();
			c.a = this;
			c.b = deviceInfo;
			c.c = values;
			global::Motorola.Common.Communication.Service.c c2 = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c2.ag(new global::System.EventHandler(c.d));
			this.a.b(c2);
			return c2;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00006248 File Offset: 0x00004448
		public void EndUnkillRadio(global::System.IAsyncResult asyncResult)
		{
			short num = (short)867870865;
			short num2 = num;
			num = (short)920627345;
			switch (num2 == num)
			{
			}
			num = (short)1390149633;
			if (num != 0)
			{
			}
			num = (short)452001792;
			if (num != 0)
			{
			}
			num = (short)1641480192;
			short num3 = num;
			global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000062FC File Offset: 0x000044FC
		public void UnkillRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte[] values)
		{
			short num = (short)651092837;
			short num2 = num;
			num = (short)2035409765;
			switch (num2 == num)
			{
			}
			num = (short)476905473;
			if (num != 0)
			{
			}
			num = (short)2112815104;
			if (num != 0)
			{
			}
			num = (short)1246691328;
			short num3 = num;
			global::System.IAsyncResult asyncResult = this.BeginUnkillRadio(deviceInfo, values, null, null, null);
			this.EndUnkillRadio(asyncResult);
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000063B8 File Offset: 0x000045B8
		private void c(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, byte[] A_1)
		{
			short num = (short)1821884428;
			short num2 = num;
			num = (short)1271906316;
			switch (num2 == num)
			{
			}
			num = (short)1857290241;
			if (num != 0)
			{
			}
			num = (short)350224384;
			if (num != 0)
			{
			}
			num = (short)161873920;
			short num3 = num;
			this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program).UnkillRadio(A_1);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00006470 File Offset: 0x00004670
		public global::System.IAsyncResult BeginReadUnkillChallengeValue(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)1361414934;
			short num2 = num;
			num = (short)682199830;
			switch (num2 == num)
			{
			}
			num = (short)1357578240;
			if (num != 0)
			{
			}
			num = (short)1082195969;
			if (num != 0)
			{
			}
			num = (short)1237778432;
			short num3 = num;
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.d d = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.d();
			d.a = this;
			d.b = deviceInfo;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(d.c));
			this.a.b(c);
			return c;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00006558 File Offset: 0x00004758
		public byte[] EndReadUnkillChallengeValue(global::System.IAsyncResult asyncResult)
		{
			short num = (short)668033512;
			short num2 = num;
			num = (short)663118312;
			switch (num2 == num)
			{
			}
			num = (short)1216806912;
			if (num != 0)
			{
			}
			num = (short)682164225;
			if (num != 0)
			{
			}
			num = (short)1876557824;
			short num3 = num;
			this.a();
			return (byte[])global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00006610 File Offset: 0x00004810
		public byte[] ReadUnkillChallengeValue(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			short num = (short)1981052714;
			short num2 = num;
			num = (short)1438545706;
			switch (num2 == num)
			{
			}
			num = (short)1222508545;
			if (num != 0)
			{
			}
			num = (short)1808793600;
			if (num != 0)
			{
			}
			num = (short)1386872832;
			short num3 = num;
			global::System.IAsyncResult asyncResult = this.BeginReadUnkillChallengeValue(deviceInfo, null, null, null);
			return this.EndReadUnkillChallengeValue(asyncResult);
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000066CC File Offset: 0x000048CC
		private byte[] o(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			int a_ = 5;
			short num = (short)1491542716;
			short num2 = num;
			num = (short)1647256252;
			switch (num2 == num)
			{
			}
			num = (short)420020225;
			if (num != 0)
			{
			}
			num = (short)1643708416;
			if (num != 0)
			{
			}
			num = (short)1667956736;
			short num3 = num;
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.a(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create);
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.a(motoDevice, global::Motorola.Common.Communication.Service.DeviceServiceManager.b("햆\uda8eﾐﲔﮖ\ud89aﺞ춠쾢삤즦캨캪ﮬ캮\uddb0욲킴", a_));
			return motoDevice.ReadUnkillChallengeValue();
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000067A0 File Offset: 0x000049A0
		public global::System.IAsyncResult BeginUpdateSerialNumber(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string serialNumber, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)1478703225;
			short num2 = num;
			num = (short)1936603257;
			switch (num2 == num)
			{
			}
			num = (short)1665925121;
			if (num != 0)
			{
			}
			num = (short)1949368320;
			if (num != 0)
			{
			}
			num = (short)926875648;
			short num3 = num;
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.e e = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.e();
			e.a = this;
			e.b = deviceInfo;
			e.c = serialNumber;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(e.d));
			this.a.b(c);
			return c;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00006894 File Offset: 0x00004A94
		public void EndUpdateSerialNumber(global::System.IAsyncResult asyncResult)
		{
			short num = (short)1328536041;
			short num2 = num;
			num = (short)448387561;
			switch (num2 == num)
			{
			}
			num = (short)352583680;
			if (num != 0)
			{
			}
			num = (short)1760034817;
			if (num != 0)
			{
			}
			num = (short)227016704;
			short num3 = num;
			global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00006940 File Offset: 0x00004B40
		public void UpdateSerialNumber(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string serialNumber)
		{
			short num = (short)2080748556;
			short num2 = num;
			num = (short)317436940;
			switch (num2 == num)
			{
			}
			num = (short)1145503745;
			if (num != 0)
			{
			}
			num = (short)478216192;
			if (num != 0)
			{
			}
			num = (short)1206124544;
			short num3 = num;
			global::System.IAsyncResult asyncResult = this.BeginUpdateSerialNumber(deviceInfo, serialNumber, null, null, null);
			this.EndUpdateSerialNumber(asyncResult);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000069FC File Offset: 0x00004BFC
		private void c(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string serialNumber)
		{
			short num = (short)1285790031;
			short num2 = num;
			num = (short)1988794703;
			switch (num2 == num)
			{
			}
			num = (short)1321598977;
			if (num != 0)
			{
			}
			num = (short)1029308416;
			if (num != 0)
			{
			}
			num = (short)527171584;
			short num3 = num;
			this.a(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program).UpdateSerialNumber(serialNumber);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00006AB4 File Offset: 0x00004CB4
		public global::System.IAsyncResult BeginFactoryReset(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)757536769;
			short num2 = num;
			num = (short)2035750913;
			switch (num2 == num)
			{
			}
			num = (short)817299457;
			if (num != 0)
			{
			}
			num = (short)969342976;
			if (num != 0)
			{
			}
			num = (short)1587937280;
			short num3 = num;
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.f f = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.f();
			f.a = this;
			f.b = deviceInfo;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(f.c));
			this.a.b(c);
			return c;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00006B9C File Offset: 0x00004D9C
		public void FactoryReset(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			short num = (short)295809654;
			short num2 = num;
			num = (short)1767092854;
			switch (num2 == num)
			{
			}
			num = (short)1334116353;
			if (num != 0)
			{
			}
			num = (short)124321792;
			if (num != 0)
			{
			}
			num = (short)2026569728;
			short num3 = num;
			global::System.IAsyncResult asyncResult = this.BeginFactoryReset(deviceInfo, null, null, null);
			this.EndFactoryReset(asyncResult);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00006C54 File Offset: 0x00004E54
		public void EndFactoryReset(global::System.IAsyncResult asyncResult)
		{
			short num = (short)559546369;
			if (num != 0)
			{
			}
			num = (short)187439242;
			short num2 = num;
			num = (short)1035933834;
			switch (num2 == num)
			{
			}
			num = (short)870645760;
			if (num != 0)
			{
			}
			num = (short)1648427008;
			short num3 = num;
			global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00006D04 File Offset: 0x00004F04
		private void n(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			short num = (short)1904307654;
			short num2 = num;
			num = (short)1319923142;
			switch (num2 == num)
			{
			}
			num = (short)1682833409;
			if (num != 0)
			{
			}
			num = (short)1180434432;
			if (num != 0)
			{
			}
			num = (short)1063911424;
			short num3 = num;
			this.a(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program).FactoryReset();
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00006DBC File Offset: 0x00004FBC
		public global::System.IAsyncResult BeginUpdateMACAddress(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte[] macAddress, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)1910087073;
			short num2 = num;
			num = (short)317496737;
			switch (num2 == num)
			{
			}
			num = (short)737017856;
			if (num != 0)
			{
			}
			num = (short)358023169;
			if (num != 0)
			{
			}
			num = (short)491716608;
			short num3 = num;
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.g g = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.g();
			g.a = this;
			g.b = deviceInfo;
			g.c = macAddress;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(g.d));
			this.a.b(c);
			return c;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00006EAC File Offset: 0x000050AC
		public void EndUpdateMACAddress(global::System.IAsyncResult asyncResult)
		{
			short num = (short)1762673453;
			short num2 = num;
			num = (short)1386431277;
			switch (num2 == num)
			{
			}
			num = (short)391380992;
			if (num != 0)
			{
			}
			num = (short)1751121921;
			if (num != 0)
			{
			}
			num = (short)1080164352;
			short num3 = num;
			global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00006F5C File Offset: 0x0000515C
		public void UpdateMACAddress(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte[] macAddress)
		{
			short num = (short)961080488;
			short num2 = num;
			num = (short)1984621736;
			switch (num2 == num)
			{
			}
			num = (short)828964865;
			if (num != 0)
			{
			}
			num = (short)1312817152;
			if (num != 0)
			{
			}
			num = (short)1322516480;
			short num3 = num;
			global::System.IAsyncResult asyncResult = this.BeginUpdateMACAddress(deviceInfo, macAddress, null, null, null);
			this.EndUpdateMACAddress(asyncResult);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00007018 File Offset: 0x00005218
		private void b(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, byte[] A_1)
		{
			short num = (short)1484388460;
			short num2 = num;
			num = (short)659945580;
			switch (num2 == num)
			{
			}
			num = (short)913244161;
			if (num != 0)
			{
			}
			num = (short)1896611840;
			if (num != 0)
			{
			}
			num = (short)878444544;
			short num3 = num;
			this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program).UpdateMACAddress(A_1);
		}

		// Token: 0x06000069 RID: 105 RVA: 0x000070D4 File Offset: 0x000052D4
		public global::System.IAsyncResult BeginSendUpdateIMEType(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte ime, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)1263268920;
			short num2 = num;
			num = (short)1125577784;
			switch (num2 == num)
			{
			}
			num = (short)1076428801;
			if (num != 0)
			{
			}
			num = (short)310050816;
			if (num != 0)
			{
			}
			num = (short)857341952;
			short num3 = num;
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.h h = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.h();
			h.a = this;
			h.b = deviceInfo;
			h.c = ime;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(h.d));
			this.a.b(c);
			return c;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000071C4 File Offset: 0x000053C4
		public void EndSendUpdateIMEType(global::System.IAsyncResult asyncResult)
		{
			short num = (short)254191752;
			short num2 = num;
			num = (short)264218760;
			switch (num2 == num)
			{
			}
			num = (short)203620352;
			if (num != 0)
			{
			}
			num = (short)168886273;
			if (num != 0)
			{
			}
			num = (short)2043609088;
			short num3 = num;
			global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00007274 File Offset: 0x00005474
		public void SendUpdateIMEType(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte ime)
		{
			short num = (short)759518042;
			short num2 = num;
			num = (short)979522394;
			switch (num2 == num)
			{
			}
			num = (short)1193541633;
			if (num != 0)
			{
			}
			num = (short)1461977088;
			if (num != 0)
			{
			}
			num = (short)220069888;
			short num3 = num;
			global::System.IAsyncResult asyncResult = this.BeginSendUpdateIMEType(deviceInfo, ime, null, null, null);
			this.EndSendUpdateIMEType(asyncResult);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00007330 File Offset: 0x00005530
		private void a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, byte A_1)
		{
			short num = (short)1329201153;
			if (num != 0)
			{
			}
			num = (short)1595443855;
			short num2 = num;
			num = (short)1630898831;
			switch (num2 == num)
			{
			}
			num = (short)1072168960;
			if (num != 0)
			{
			}
			num = (short)907542528;
			short num3 = num;
			this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program).SendUpdateIMEType(A_1);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000073E4 File Offset: 0x000055E4
		public global::System.IAsyncResult BeginSendUpdateDateCode(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte[] dateCode, ushort source, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)1727084491;
			short num2 = num;
			num = (short)1218328523;
			switch (num2 == num)
			{
			}
			num = (short)1007681537;
			if (num != 0)
			{
			}
			num = (short)892141568;
			if (num != 0)
			{
			}
			num = (short)668729344;
			short num3 = num;
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.i i = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.i();
			i.a = this;
			i.b = deviceInfo;
			i.c = dateCode;
			i.d = source;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(i.e));
			this.a.b(c);
			return c;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000074DC File Offset: 0x000056DC
		public void EndSendUpdateDateCode(global::System.IAsyncResult asyncResult)
		{
			short num = (short)83296257;
			if (num != 0)
			{
			}
			num = (short)498668003;
			short num2 = num;
			num = (short)1051333091;
			switch (num2 == num)
			{
			}
			num = (short)907083776;
			if (num != 0)
			{
			}
			num = (short)739115008;
			short num3 = num;
			global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000758C File Offset: 0x0000578C
		public void SendUpdateDateCode(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte[] dateCode, ushort source)
		{
			short num = (short)2044940976;
			short num2 = num;
			num = (short)1033065136;
			switch (num2 == num)
			{
			}
			num = (short)489816065;
			if (num != 0)
			{
			}
			num = (short)1418067968;
			if (num != 0)
			{
			}
			num = (short)1140916224;
			short num3 = num;
			global::System.IAsyncResult asyncResult = this.BeginSendUpdateDateCode(deviceInfo, dateCode, source, null, null, null);
			this.EndSendUpdateIMEType(asyncResult);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000764C File Offset: 0x0000584C
		private void a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, byte[] A_1, ushort A_2)
		{
			short num = (short)1144556476;
			short num2 = num;
			num = (short)899910588;
			switch (num2 == num)
			{
			}
			num = (short)180420609;
			if (num != 0)
			{
			}
			num = (short)1433927680;
			if (num != 0)
			{
			}
			num = (short)672464896;
			short num3 = num;
			this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program).SendUpdateDateCode(A_1, A_2);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00007704 File Offset: 0x00005904
		public global::System.IAsyncResult BeginCBIProgramme(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)2019731805;
			short num2 = num;
			num = (short)1329637725;
			switch (num2 == num)
			{
			}
			num = (short)1143996416;
			if (num != 0)
			{
			}
			num = (short)1214578689;
			if (num != 0)
			{
			}
			num = (short)1920139264;
			short num3 = num;
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.j j = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.j();
			j.a = this;
			j.b = deviceInfo;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(j.c));
			this.a.b(c);
			return c;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000077EC File Offset: 0x000059EC
		public void EndCBIProgramme(global::System.IAsyncResult asyncResult)
		{
			short num = (short)1287278663;
			short num2 = num;
			num = (short)1596477511;
			switch (num2 == num)
			{
			}
			num = (short)802160641;
			if (num != 0)
			{
			}
			num = (short)864485376;
			if (num != 0)
			{
			}
			num = (short)57147392;
			short num3 = num;
			global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000078A0 File Offset: 0x00005AA0
		public void CBIProgramme(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			short num = (short)2027443271;
			short num2 = num;
			num = (short)1382044743;
			switch (num2 == num)
			{
			}
			num = (short)397279232;
			if (num != 0)
			{
			}
			num = (short)584450049;
			if (num != 0)
			{
			}
			num = (short)63832064;
			short num3 = num;
			global::System.IAsyncResult asyncResult = this.BeginCBIProgramme(deviceInfo, null, null, null);
			this.EndCBIProgramme(asyncResult);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000795C File Offset: 0x00005B5C
		private void m(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			short num = (short)101793155;
			short num2 = num;
			num = (short)1357004163;
			switch (num2 == num)
			{
			}
			num = (short)547422208;
			if (num != 0)
			{
			}
			num = (short)1211957249;
			if (num != 0)
			{
			}
			num = (short)979304448;
			short num3 = num;
			this.a(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.CBIProgram).CBIProgramme();
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00007A14 File Offset: 0x00005C14
		public global::System.IAsyncResult BeginTurnOffRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)399800406;
			short num2 = num;
			num = (short)1316124758;
			switch (num2 == num)
			{
			}
			num = (short)751173633;
			if (num != 0)
			{
			}
			num = (short)1636564992;
			if (num != 0)
			{
			}
			num = (short)446038016;
			short num3 = num;
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.k k = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.k();
			k.a = this;
			k.b = deviceInfo;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(k.c));
			this.a.b(c);
			return c;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00007AFC File Offset: 0x00005CFC
		public bool EndTurnOffRadio(global::System.IAsyncResult asyncResult)
		{
			short num = (short)1380239075;
			short num2 = num;
			num = (short)926861027;
			switch (num2 == num)
			{
			}
			num = (short)1468530689;
			if (num != 0)
			{
			}
			num = (short)119996416;
			if (num != 0)
			{
			}
			num = (short)595722240;
			short num3 = num;
			return (bool)global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00007BAC File Offset: 0x00005DAC
		public bool TurnOffRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			short num = (short)1002652071;
			short num2 = num;
			num = (short)677921191;
			switch (num2 == num)
			{
			}
			num = (short)1702428672;
			if (num != 0)
			{
			}
			num = (short)102170625;
			if (num != 0)
			{
			}
			num = (short)631242752;
			short num3 = num;
			global::System.IAsyncResult asyncResult = this.BeginTurnOffRadio(deviceInfo, null, null, null);
			return this.EndTurnOffRadio(asyncResult);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00007C68 File Offset: 0x00005E68
		private bool l(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			short num = (short)1907776206;
			short num2 = num;
			num = (short)1179998926;
			switch (num2 == num)
			{
			}
			num = (short)310509569;
			if (num != 0)
			{
			}
			num = (short)1402011648;
			if (num != 0)
			{
			}
			num = (short)1400897536;
			short num3 = num;
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.a(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read);
			global::Motorola.Common.Communication.CommonUtil.DeviceControlInputParams deviceControlInputParams = new global::Motorola.Common.Communication.CommonUtil.DeviceControlInputParams();
			deviceControlInputParams.family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.TetraRadio;
			deviceControlInputParams.type = global::Motorola.Common.Communication.CommonUtil.DeviceControlOperationType.TurnOffRadio;
			global::Motorola.Common.Communication.CommonUtil.DeviceControlOutputParams deviceControlOutputParams = new global::Motorola.Common.Communication.CommonUtil.DeviceControlOutputParams();
			motoDevice.DeviceControl(deviceControlInputParams, ref deviceControlOutputParams);
			return deviceControlOutputParams.result == global::Motorola.Common.Communication.CommonUtil.DeviceControlResult.Success;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00007D48 File Offset: 0x00005F48
		public global::System.IAsyncResult BeginRemoveRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)462053477;
			short num2 = num;
			num = (short)912089189;
			switch (num2 == num)
			{
			}
			num = (short)717225985;
			if (num != 0)
			{
			}
			num = (short)60751872;
			if (num != 0)
			{
			}
			num = (short)1281753088;
			short num3 = num;
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.l l = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.l();
			l.a = this;
			l.b = deviceInfo;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(l.c));
			this.a.b(c);
			return c;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00007E34 File Offset: 0x00006034
		public bool EndRemoveRadio(global::System.IAsyncResult asyncResult)
		{
			short num = (short)114393471;
			short num2 = num;
			num = (short)645955967;
			switch (num2 == num)
			{
			}
			num = (short)430047233;
			if (num != 0)
			{
			}
			num = (short)343670784;
			if (num != 0)
			{
			}
			num = (short)1941307392;
			short num3 = num;
			return (bool)global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00007EE8 File Offset: 0x000060E8
		public bool RemoveRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			short num = (short)2018714501;
			short num2 = num;
			num = (short)532947845;
			switch (num2 == num)
			{
			}
			num = (short)98369537;
			if (num != 0)
			{
			}
			num = (short)357564416;
			if (num != 0)
			{
			}
			num = (short)1235484672;
			short num3 = num;
			global::System.IAsyncResult asyncResult = this.BeginRemoveRadio(deviceInfo, null, null, null);
			return this.EndRemoveRadio(asyncResult);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00007FA4 File Offset: 0x000061A4
		private bool k(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			short num = (short)215843353;
			short num2 = num;
			num = (short)897810969;
			switch (num2 == num)
			{
			}
			num = (short)1535115265;
			if (num != 0)
			{
			}
			num = (short)961544192;
			if (num != 0)
			{
			}
			num = (short)1907163136;
			short num3 = num;
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.a(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read);
			global::Motorola.Common.Communication.CommonUtil.DeviceControlInputParams deviceControlInputParams = new global::Motorola.Common.Communication.CommonUtil.DeviceControlInputParams();
			deviceControlInputParams.family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.TetraRadio;
			deviceControlInputParams.type = global::Motorola.Common.Communication.CommonUtil.DeviceControlOperationType.RemoveRadio;
			global::Motorola.Common.Communication.CommonUtil.DeviceControlOutputParams deviceControlOutputParams = new global::Motorola.Common.Communication.CommonUtil.DeviceControlOutputParams();
			motoDevice.DeviceControl(deviceControlInputParams, ref deviceControlOutputParams);
			return deviceControlOutputParams.result == global::Motorola.Common.Communication.CommonUtil.DeviceControlResult.Success;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00008088 File Offset: 0x00006288
		public global::System.IAsyncResult BeginLLPIsAvailable(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)212074497;
			if (num != 0)
			{
			}
			num = (short)946968399;
			short num2 = num;
			num = (short)1991153487;
			switch (num2 == num)
			{
			}
			num = (short)1750597632;
			if (num != 0)
			{
			}
			num = (short)298385408;
			short num3 = num;
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.m m = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.m();
			m.a = this;
			m.b = deviceInfo;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(m.c));
			this.a.b(c);
			return c;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000816C File Offset: 0x0000636C
		public bool EndLLPIsAvailable(global::System.IAsyncResult asyncResult)
		{
			short num = (short)1273671788;
			short num2 = num;
			num = (short)852799596;
			switch (num2 == num)
			{
			}
			num = (short)1721303040;
			if (num != 0)
			{
			}
			num = (short)675020801;
			if (num != 0)
			{
			}
			num = (short)421068800;
			short num3 = num;
			return (bool)global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00008220 File Offset: 0x00006420
		public bool LLPIsAvailable(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			short num = (short)1074992068;
			short num2 = num;
			num = (short)850531268;
			switch (num2 == num)
			{
			}
			num = (short)1800667137;
			if (num != 0)
			{
			}
			num = (short)902430720;
			if (num != 0)
			{
			}
			num = (short)864419840;
			short num3 = num;
			global::System.IAsyncResult asyncResult = this.BeginLLPIsAvailable(deviceInfo, null, null, null);
			return this.EndLLPIsAvailable(asyncResult);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x000082DC File Offset: 0x000064DC
		private bool j(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			short num = (short)1447946951;
			short num2 = num;
			num = (short)572975815;
			switch (num2 == num)
			{
			}
			num = (short)433455105;
			if (num != 0)
			{
			}
			num = (short)824442880;
			if (num != 0)
			{
			}
			num = (short)607453184;
			short num3 = num;
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.a(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read);
			global::Motorola.Common.Communication.CommonUtil.DeviceControlInputParams deviceControlInputParams = new global::Motorola.Common.Communication.CommonUtil.DeviceControlInputParams();
			deviceControlInputParams.family = global::Motorola.Common.Communication.CommonUtil.ProductFamily.TetraRadio;
			deviceControlInputParams.type = global::Motorola.Common.Communication.CommonUtil.DeviceControlOperationType.LLPIsAvailable;
			global::Motorola.Common.Communication.CommonUtil.DeviceControlOutputParams deviceControlOutputParams = new global::Motorola.Common.Communication.CommonUtil.DeviceControlOutputParams();
			motoDevice.DeviceControl(deviceControlInputParams, ref deviceControlOutputParams);
			return deviceControlOutputParams.result == global::Motorola.Common.Communication.CommonUtil.DeviceControlResult.Success;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x000083BC File Offset: 0x000065BC
		public global::System.IAsyncResult BeginSwitchRadioMode(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.DeviceMode mode, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)469277479;
			short num2 = num;
			num = (short)1620220711;
			switch (num2 == num)
			{
			}
			num = (short)473235457;
			if (num != 0)
			{
			}
			num = (short)727580672;
			if (num != 0)
			{
			}
			num = (short)722010112;
			short num3 = num;
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.n n = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.n();
			n.a = this;
			n.b = deviceInfo;
			n.c = mode;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(n.d));
			this.a.b(c);
			return c;
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000084A8 File Offset: 0x000066A8
		public void EndSwitchRadioMode(global::System.IAsyncResult asyncResult)
		{
			short num = (short)2064351368;
			short num2 = num;
			num = (short)875331720;
			switch (num2 == num)
			{
			}
			num = (short)424214528;
			if (num != 0)
			{
			}
			num = (short)794230785;
			if (num != 0)
			{
			}
			num = (short)1436942336;
			short num3 = num;
			global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000855C File Offset: 0x0000675C
		public void SwitchRadioMode(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.DeviceMode mode)
		{
			short num = (short)2097966741;
			short num2 = num;
			num = (short)1223650965;
			switch (num2 == num)
			{
			}
			num = (short)1228079105;
			if (num != 0)
			{
			}
			num = (short)1521876992;
			if (num != 0)
			{
			}
			num = (short)1907556352;
			short num3 = num;
			global::System.IAsyncResult asyncResult = this.BeginSwitchRadioMode(deviceInfo, mode, null, null, null);
			this.EndSwitchRadioMode(asyncResult);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00008618 File Offset: 0x00006818
		private void a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.CommonUtil.DeviceMode A_1)
		{
			short num = (short)2039762554;
			short num2 = num;
			num = (short)1353010810;
			switch (num2 == num)
			{
			}
			num = (short)232325121;
			if (num != 0)
			{
			}
			num = (short)2071265280;
			if (num != 0)
			{
			}
			num = (short)1831010304;
			short num3 = num;
			this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program).SwitchRadioMode(A_1);
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000086CC File Offset: 0x000068CC
		public global::System.IAsyncResult BeginUpdateRadioDisplay(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)339633216;
			short num2 = num;
			num = (short)1811440704;
			switch (num2 == num)
			{
			}
			num = (short)154271745;
			if (num != 0)
			{
			}
			num = (short)360579072;
			if (num != 0)
			{
			}
			num = (short)780337152;
			short num3 = num;
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.o o = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.o();
			o.a = this;
			o.b = deviceInfo;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(o.c));
			this.a.b(c);
			return c;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000087B0 File Offset: 0x000069B0
		public void EndUpdateRadioDisplay(global::System.IAsyncResult asyncResult)
		{
			short num = (short)2029191169;
			if (num != 0)
			{
			}
			num = (short)1435356535;
			short num2 = num;
			num = (short)1393544567;
			switch (num2 == num)
			{
			}
			num = (short)1830551552;
			if (num != 0)
			{
			}
			num = (short)1171849216;
			short num3 = num;
			global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00008860 File Offset: 0x00006A60
		public void UpdateRadioDisplay(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			short num = (short)1536224751;
			short num2 = num;
			num = (short)1239936495;
			switch (num2 == num)
			{
			}
			num = (short)1166802944;
			if (num != 0)
			{
			}
			num = (short)1164509185;
			if (num != 0)
			{
			}
			num = (short)1336016896;
			short num3 = num;
			global::System.IAsyncResult asyncResult = this.BeginUpdateRadioDisplay(deviceInfo, null, null, null);
			this.EndUpdateRadioDisplay(asyncResult);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000891C File Offset: 0x00006B1C
		private void i(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			short num = (short)1391220938;
			short num2 = num;
			num = (short)1260345546;
			switch (num2 == num)
			{
			}
			num = (short)166330368;
			if (num != 0)
			{
			}
			num = (short)1641086977;
			if (num != 0)
			{
			}
			num = (short)81068032;
			short num3 = num;
			this.a(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program).UpdateRadioDisplay();
		}

		// Token: 0x06000089 RID: 137 RVA: 0x000089D4 File Offset: 0x00006BD4
		public global::System.IAsyncResult BeginWriteSoftware(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)643266244;
			short num2 = num;
			num = (short)652310212;
			switch (num2 == num)
			{
			}
			num = (short)1467482112;
			if (num != 0)
			{
			}
			num = (short)843317249;
			if (num != 0)
			{
			}
			num = (short)1047068672;
			short num3 = num;
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.p p = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.p();
			p.a = this;
			p.b = deviceInfo;
			p.c = pbaObject;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(p.d));
			this.a.b(c);
			return c;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00008AC0 File Offset: 0x00006CC0
		public void EndWriteSoftware(global::System.IAsyncResult asyncResult)
		{
			short num = (short)614662777;
			short num2 = num;
			num = (short)222560889;
			switch (num2 == num)
			{
			}
			num = (short)1855979521;
			if (num != 0)
			{
			}
			num = (short)361037824;
			if (num != 0)
			{
			}
			num = (short)424607744;
			short num3 = num;
			global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00008B70 File Offset: 0x00006D70
		public void WriteSoftware(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			short num = (short)10647337;
			short num2 = num;
			num = (short)1614444329;
			switch (num2 == num)
			{
			}
			num = (short)229048320;
			if (num != 0)
			{
			}
			num = (short)866910209;
			if (num != 0)
			{
			}
			num = (short)1206714368;
			short num3 = num;
			global::System.IAsyncResult asyncResult = this.BeginWriteSoftware(deviceInfo, pbaObject, null, null, null);
			this.EndWriteSoftware(asyncResult);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00008C30 File Offset: 0x00006E30
		private void d(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.Pba.PbaObject A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::Motorola.Common.Communication.IMotoDevice motoDevice;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1772748801;
					if (num2 != 0)
					{
					}
					if (motoDevice is global::Motorola.Common.Communication.ITetraDevSpecialOperation)
					{
						num2 = (short)496762882;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					return;
				case 2:
				{
					(motoDevice as global::Motorola.Common.Communication.ITetraDevSpecialOperation).WriteSoftware(A_1.FWpath);
					num2 = (short)791511071;
					short num3 = num2;
					num2 = (short)1685356575;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num2 = (short)763166720;
						short num4 = num2;
						num2 = (short)646840320;
						if (num2 != 0)
						{
						}
						num2 = (short)885260289;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			motoDevice = this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash);
			num2 = (short)1543372800;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00008D5C File Offset: 0x00006F5C
		public global::System.IAsyncResult BeginSendFPGAErase(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)526144822;
			short num2 = num;
			num = (short)1227904310;
			switch (num2 == num)
			{
			}
			num = (short)80871425;
			if (num != 0)
			{
			}
			num = (short)995753984;
			if (num != 0)
			{
			}
			num = (short)989921280;
			short num3 = num;
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.q q = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.q();
			q.a = this;
			q.b = deviceInfo;
			q.c = fileType;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(q.d));
			this.a.b(c);
			return c;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00008E4C File Offset: 0x0000704C
		public void EndSendFPGAErase(global::System.IAsyncResult asyncResult)
		{
			short num = (short)308435158;
			short num2 = num;
			num = (short)411850966;
			switch (num2 == num)
			{
			}
			num = (short)989921281;
			if (num != 0)
			{
			}
			num = (short)1766981632;
			if (num != 0)
			{
			}
			num = (short)1963655168;
			short num3 = num;
			global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00008F00 File Offset: 0x00007100
		public void SendFPGAErase(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			short num = (short)51021889;
			short num2 = num;
			num = (short)23955521;
			switch (num2 == num)
			{
			}
			num = (short)666042369;
			if (num != 0)
			{
			}
			num = (short)21430272;
			if (num != 0)
			{
			}
			num = (short)920453120;
			short num3 = num;
			global::System.IAsyncResult asyncResult = this.BeginSendFPGAErase(deviceInfo, fileType, null, null, null);
			this.EndSendFPGAErase(asyncResult);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00008FBC File Offset: 0x000071BC
		private void b(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType A_1)
		{
			short num = (short)1525905714;
			short num2 = num;
			num = (short)1867020594;
			switch (num2 == num)
			{
			}
			num = (short)1841889281;
			if (num != 0)
			{
			}
			num = (short)910557184;
			if (num != 0)
			{
			}
			num = (short)637796352;
			short num3 = num;
			this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash).SendFPGAErase(A_1);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00009078 File Offset: 0x00007278
		public global::System.IAsyncResult BeginSendFPGAReset(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)640352257;
			if (num != 0)
			{
			}
			num = (short)859639607;
			short num2 = num;
			num = (short)679022391;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1284636672;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)754843648;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.r r = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.r();
			r.a = this;
			r.b = deviceInfo;
			r.c = fileType;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(r.d));
			this.a.b(c);
			return c;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00009168 File Offset: 0x00007368
		public void EndSendFPGAReset(global::System.IAsyncResult asyncResult)
		{
			short num = (short)1961749358;
			short num2 = num;
			num = (short)1113647982;
			switch (num2 == num)
			{
			}
			num = (short)152633344;
			short num3 = num;
			num = (short)838139905;
			if (num != 0)
			{
			}
			num = (short)1567752192;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00009218 File Offset: 0x00007418
		public void SendFPGAReset(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType fileType)
		{
			short num = (short)1099987295;
			short num2 = num;
			num = (short)646019423;
			switch (num2 == num)
			{
			}
			num = (short)1310195712;
			short num3 = num;
			num = (short)1992359936;
			if (num != 0)
			{
			}
			num = (short)289538049;
			if (num != 0)
			{
			}
			global::System.IAsyncResult asyncResult = this.BeginSendFPGAReset(deviceInfo, fileType, null, null, null);
			this.EndSendFPGAReset(asyncResult);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x000092D4 File Offset: 0x000074D4
		private void a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType A_1)
		{
			short num = (short)2024597554;
			short num2 = num;
			num = (short)464840754;
			switch (num2 == num)
			{
			}
			num = (short)1721565184;
			short num3 = num;
			num = (short)1432616960;
			if (num != 0)
			{
			}
			num = (short)923271169;
			if (num != 0)
			{
			}
			this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash).SendFPGAReset(A_1);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00009390 File Offset: 0x00007590
		public bool WaitForPSUUpgrade(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			int a_ = 0;
			short num = (short)1536394658;
			short num2 = num;
			num = (short)1582400930;
			switch (num2 == num)
			{
			}
			num = (short)261160960;
			short num3 = num;
			num = (short)1035075585;
			if (num != 0)
			{
			}
			num = (short)1813250048;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.a(this.a(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read), global::Motorola.Common.Communication.Service.DeviceServiceManager.b("햁ﲇ첉ﲍ삏솑솓쎕ﶙﾝ쒟잡", a_));
			return true;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00009460 File Offset: 0x00007660
		public global::System.IAsyncResult BeginUpdateDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, bool hostedDepotOperation, string operationId, global::System.AsyncCallback callback, object state, int? userDefersAllowed = null)
		{
			short num = (short)909145736;
			short num2 = num;
			num = (short)355169928;
			switch (num2 == num)
			{
			}
			num = (short)1995702272;
			short num3 = num;
			num = (short)253820928;
			if (num != 0)
			{
			}
			num = (short)1415512065;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.s s = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.s();
			s.a = this;
			s.b = deviceInfo;
			s.c = pbaObject;
			s.d = hostedDepotOperation;
			s.e = userDefersAllowed;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(s.f));
			this.a.b(c);
			return c;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000955C File Offset: 0x0000775C
		public void EndUpdateDevice(global::System.IAsyncResult asyncResult)
		{
			short num = (short)1624645881;
			short num2 = num;
			num = (short)1925980409;
			switch (num2 == num)
			{
			}
			num = (short)178585600;
			short num3 = num;
			num = (short)963772416;
			if (num != 0)
			{
			}
			num = (short)1792278529;
			if (num != 0)
			{
			}
			this.a();
			global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00009614 File Offset: 0x00007814
		public void UpdateDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, bool hostedDepotOperation, int? userDefersAllowed = null)
		{
			short num = (short)1706950657;
			if (num != 0)
			{
			}
			num = (short)284119326;
			short num2 = num;
			num = (short)575230238;
			switch (num2 == num)
			{
			default:
			{
				num = (short)397213696;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1637875712;
			if (num != 0)
			{
			}
			global::System.IAsyncResult asyncResult = this.BeginUpdateDevice(deviceInfo, pbaObject, hostedDepotOperation, null, null, null, userDefersAllowed);
			this.EndUpdateDevice(asyncResult);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x000096D4 File Offset: 0x000078D4
		private void a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.Pba.PbaObject A_1, bool A_2, int? A_3 = null)
		{
			int a_ = 6;
			short num = (short)1684631758;
			short num2 = num;
			num = (short)1946382542;
			switch (num2 == num)
			{
			}
			num = (short)697892864;
			short num3 = num;
			num = (short)1849098240;
			if (num != 0)
			{
			}
			num = (short)1995964417;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash);
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.a(motoDevice, global::Motorola.Common.Communication.Service.DeviceServiceManager.b("\udd87憎킓ﾛﮝ", a_));
			motoDevice.UpdateDevice(A_1, A_2, A_3);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x000097AC File Offset: 0x000079AC
		public global::System.IAsyncResult BeginResetPassword(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte[] resetBytes, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)1325186492;
			short num2 = num;
			num = (short)441695676;
			switch (num2 == num)
			{
			}
			num = (short)80281600;
			short num3 = num;
			num = (short)701825025;
			if (num != 0)
			{
			}
			num = (short)272760832;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.t t = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.t();
			t.a = this;
			t.b = deviceInfo;
			t.c = resetBytes;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(t.d));
			this.a.b(c);
			return c;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00009898 File Offset: 0x00007A98
		public bool EndResetPassword(global::System.IAsyncResult asyncResult)
		{
			short num = (short)820252000;
			short num2 = num;
			num = (short)41618784;
			switch (num2 == num)
			{
			}
			num = (short)125566976;
			short num3 = num;
			num = (short)1935605761;
			if (num != 0)
			{
			}
			num = (short)395182080;
			if (num != 0)
			{
			}
			this.a();
			return (bool)global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00009954 File Offset: 0x00007B54
		public bool ResetPassword(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, byte[] resetBytes)
		{
			short num = (short)1072176161;
			short num2 = num;
			num = (short)2045320225;
			switch (num2 == num)
			{
			}
			num = (short)1874395136;
			short num3 = num;
			num = (short)529006593;
			if (num != 0)
			{
			}
			num = (short)1412562944;
			if (num != 0)
			{
			}
			global::System.IAsyncResult asyncResult = this.BeginResetPassword(deviceInfo, resetBytes, null, null, null);
			return this.EndResetPassword(asyncResult);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00009A10 File Offset: 0x00007C10
		private bool a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, byte[] A_1)
		{
			int a_ = 1;
			short num = (short)151592872;
			short num2 = num;
			num = (short)236134312;
			switch (num2 == num)
			{
			}
			num = (short)1363869696;
			short num3 = num;
			num = (short)1654718465;
			if (num != 0)
			{
			}
			num = (short)1482555392;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.PasswordReset);
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.a(motoDevice, global::Motorola.Common.Communication.Service.DeviceServiceManager.b("톂ﾊ\udd8cﾚ", a_));
			return motoDevice.ResetPassword(A_1);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00009AE8 File Offset: 0x00007CE8
		public global::System.IAsyncResult BeginPreUpdateDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, bool hostedDepotOperation, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)372075150;
			short num2 = num;
			num = (short)910125710;
			switch (num2 == num)
			{
			}
			num = (short)239009792;
			short num3 = num;
			num = (short)361496577;
			if (num != 0)
			{
			}
			num = (short)474742784;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.u u = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.u();
			u.a = this;
			u.b = deviceInfo;
			u.c = pbaObject;
			u.d = hostedDepotOperation;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(u.e));
			this.a.b(c);
			return c;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00009BE4 File Offset: 0x00007DE4
		public void EndPreUpdateDevice(global::System.IAsyncResult asyncResult)
		{
			short num = (short)1344430365;
			short num2 = num;
			num = (short)1351508253;
			switch (num2 == num)
			{
			}
			num = (short)378601472;
			short num3 = num;
			num = (short)401604609;
			if (num != 0)
			{
			}
			num = (short)924975104;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00009C98 File Offset: 0x00007E98
		public void PreUpdateDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, bool hostedDepotOperation)
		{
			short num = (short)1577599947;
			short num2 = num;
			num = (short)1563378635;
			switch (num2 == num)
			{
			}
			num = (short)27000832;
			short num3 = num;
			num = (short)321519617;
			if (num != 0)
			{
			}
			num = (short)185139200;
			if (num != 0)
			{
			}
			global::System.IAsyncResult asyncResult = this.BeginPreUpdateDevice(deviceInfo, pbaObject, hostedDepotOperation, null, null, null);
			this.EndPreUpdateDevice(asyncResult);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00009D54 File Offset: 0x00007F54
		private void a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.Pba.PbaObject A_1, bool A_2)
		{
			int a_ = 19;
			short num = (short)702059716;
			short num2 = num;
			num = (short)982291652;
			switch (num2 == num)
			{
			}
			num = (short)790953984;
			short num3 = num;
			num = (short)970719233;
			if (num != 0)
			{
			}
			num = (short)205848576;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash);
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.a(motoDevice, global::Motorola.Common.Communication.Service.DeviceServiceManager.b("얔ﲘ캚ﮞ삠힢삤첨\uddaa쒬첮풰", a_));
			motoDevice.PreUpdateDevice(A_1, A_2);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00009E30 File Offset: 0x00008030
		public bool SetFWDLConfig(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, ushort tg, string version)
		{
			short num = (short)115501203;
			short num2 = num;
			num = (short)580085907;
			switch (num2 == num)
			{
			}
			num = (short)329777152;
			short num3 = num;
			num = (short)1007222784;
			if (num != 0)
			{
			}
			num = (short)1840381953;
			if (num != 0)
			{
			}
			global::System.IAsyncResult asyncResult = this.BeginSetFWDLConfig(deviceInfo, tg, version, null, null, null);
			return this.EndSetFWDLConfig(asyncResult);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00009EF4 File Offset: 0x000080F4
		private bool a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, ushort A_1, string A_2)
		{
			short num = (short)295956327;
			short num2 = num;
			num = (short)1697116007;
			switch (num2 == num)
			{
			}
			num = (short)589627392;
			short num3 = num;
			num = (short)1703280641;
			if (num != 0)
			{
			}
			num = (short)135004160;
			if (num != 0)
			{
			}
			return this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program).SetFWDLConfig(A_1, A_2);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00009FAC File Offset: 0x000081AC
		public global::System.IAsyncResult BeginSetFWDLConfig(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, ushort tg, string version, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)877705027;
			short num2 = num;
			num = (short)881047363;
			switch (num2 == num)
			{
			}
			num = (short)1757151232;
			short num3 = num;
			num = (short)1669070849;
			if (num != 0)
			{
			}
			num = (short)598016000;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.v v = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.v();
			v.a = this;
			v.b = deviceInfo;
			v.c = tg;
			v.d = version;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(v.e));
			this.a.b(c);
			return c;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000A0A4 File Offset: 0x000082A4
		public bool EndSetFWDLConfig(global::System.IAsyncResult asyncResult)
		{
			short num = (short)653697870;
			short num2 = num;
			num = (short)583770958;
			switch (num2 == num)
			{
			}
			num = (short)841220096;
			short num3 = num;
			num = (short)34078720;
			if (num != 0)
			{
			}
			num = (short)1518731265;
			if (num != 0)
			{
			}
			return (bool)global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000A158 File Offset: 0x00008358
		public global::System.IAsyncResult BeginValidateLocalPassword(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string password, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)971506742;
			short num2 = num;
			num = (short)1432945718;
			switch (num2 == num)
			{
			}
			num = (short)1614151680;
			short num3 = num;
			num = (short)1013579777;
			if (num != 0)
			{
			}
			num = (short)935460864;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.w w = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.w();
			w.a = this;
			w.b = deviceInfo;
			w.c = password;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(w.d));
			this.a.b(c);
			return c;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000A248 File Offset: 0x00008448
		public global::Motorola.Common.Communication.CommonUtil.PasswordStatus EndValidateLocalPassword(global::System.IAsyncResult asyncResult)
		{
			short num = (short)308346881;
			if (num != 0)
			{
			}
			num = (short)280045435;
			short num2 = num;
			num = (short)467281787;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1714946048;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1902575616;
			if (num != 0)
			{
			}
			return (global::Motorola.Common.Communication.CommonUtil.PasswordStatus)global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000A2FC File Offset: 0x000084FC
		public global::Motorola.Common.Communication.CommonUtil.PasswordStatus ValidateLocalPassword(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string password)
		{
			short num = (short)952359909;
			short num2 = num;
			num = (short)1368382437;
			switch (num2 == num)
			{
			}
			num = (short)348520448;
			short num3 = num;
			num = (short)2101739520;
			if (num != 0)
			{
			}
			num = (short)1989738497;
			if (num != 0)
			{
			}
			global::System.IAsyncResult asyncResult = this.BeginValidateLocalPassword(deviceInfo, password, null, null, null);
			return this.EndValidateLocalPassword(asyncResult);
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000A3BC File Offset: 0x000085BC
		private global::Motorola.Common.Communication.CommonUtil.PasswordStatus b(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string password)
		{
			short num = (short)1153917528;
			short num2 = num;
			num = (short)1414488664;
			switch (num2 == num)
			{
			}
			num = (short)202833920;
			short num3 = num;
			num = (short)1696661505;
			if (num != 0)
			{
			}
			num = (short)1153040384;
			if (num != 0)
			{
			}
			return this.a(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Any).ValidateLocalPassword(password);
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000A478 File Offset: 0x00008678
		public global::System.IAsyncResult BeginEnableFxFeature(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string xmlHashInput, global::System.Collections.Generic.List<byte[]> featureCodeIds, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)1000209277;
			short num2 = num;
			num = (short)1789131645;
			switch (num2 == num)
			{
			}
			num = (short)446955520;
			short num3 = num;
			num = (short)1416298496;
			if (num != 0)
			{
			}
			num = (short)1239613441;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.x x = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.x();
			x.a = this;
			x.b = deviceInfo;
			x.c = xmlHashInput;
			x.d = featureCodeIds;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(x.e));
			this.a.b(c);
			return c;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000A570 File Offset: 0x00008770
		public void EndEnableFxFeature(global::System.IAsyncResult asyncResult)
		{
			short num = (short)1181861567;
			short num2 = num;
			num = (short)1912522431;
			switch (num2 == num)
			{
			}
			num = (short)1945436160;
			short num3 = num;
			num = (short)2097020928;
			if (num != 0)
			{
			}
			num = (short)657260545;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000A624 File Offset: 0x00008824
		public void EnableFxFeature(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string xmlHashInput, global::System.Collections.Generic.List<byte[]> featureCodeIDs)
		{
			short num = (short)117863900;
			short num2 = num;
			num = (short)1152677340;
			switch (num2 == num)
			{
			}
			num = (short)1760493568;
			short num3 = num;
			num = (short)299433985;
			if (num != 0)
			{
			}
			num = (short)2044788736;
			if (num != 0)
			{
			}
			global::System.IAsyncResult asyncResult = this.BeginEnableFxFeature(deviceInfo, xmlHashInput, featureCodeIDs, null, null, null);
			this.EndEnableFxFeature(asyncResult);
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000A6E0 File Offset: 0x000088E0
		private void a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, string A_1, global::System.Collections.Generic.List<byte[]> A_2)
		{
			short num = (short)1658277817;
			short num2 = num;
			num = (short)474566585;
			switch (num2 == num)
			{
			}
			num = (short)818348032;
			short num3 = num;
			num = (short)534118401;
			if (num != 0)
			{
			}
			num = (short)1391591424;
			if (num != 0)
			{
			}
			this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.ChargingFeature).EnableFeature(A_0.SoftwareVersion, A_0.SerialNumber, A_1, A_2);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000A7A4 File Offset: 0x000089A4
		public global::System.IAsyncResult BeginReadHashInputAndValidate(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject validatePba, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DataBlockItem> blockList, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)1270727048;
			short num2 = num;
			num = (short)1264435592;
			switch (num2 == num)
			{
			}
			num = (short)1313144832;
			short num3 = num;
			num = (short)1764491265;
			if (num != 0)
			{
			}
			num = (short)1844576256;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.y y = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.y();
			y.a = this;
			y.b = deviceInfo;
			y.c = validatePba;
			y.d = blockList;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(y.e));
			this.a.b(c);
			return c;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000A89C File Offset: 0x00008A9C
		public string EndReadHashInputAndValidate(global::System.IAsyncResult asyncResult)
		{
			short num = (short)136316311;
			short num2 = num;
			num = (short)167839127;
			switch (num2 == num)
			{
			}
			num = (short)1019674624;
			short num3 = num;
			num = (short)237371393;
			if (num != 0)
			{
			}
			num = (short)1875378176;
			if (num != 0)
			{
			}
			this.a();
			return (string)global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000A958 File Offset: 0x00008B58
		public string ReadHashInputAndValidate(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject validatePba, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DataBlockItem> blockList)
		{
			short num = (short)334956430;
			short num2 = num;
			num = (short)404686734;
			switch (num2 == num)
			{
			}
			num = (short)959315968;
			short num3 = num;
			num = (short)1761148928;
			if (num != 0)
			{
			}
			num = (short)1413677057;
			if (num != 0)
			{
			}
			global::System.IAsyncResult asyncResult = this.BeginReadHashInputAndValidate(deviceInfo, validatePba, blockList, null, null, null);
			return this.EndReadHashInputAndValidate(asyncResult);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000AA14 File Offset: 0x00008C14
		private string a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.Pba.PbaObject A_1, global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DataBlockItem> A_2)
		{
			short num = (short)288880958;
			short num2 = num;
			num = (short)27982142;
			switch (num2 == num)
			{
			}
			num = (short)1041301504;
			short num3 = num;
			num = (short)1560281088;
			if (num != 0)
			{
			}
			num = (short)1554776065;
			if (num != 0)
			{
			}
			return this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read).ReadHashInputAndValidate(A_1, A_2);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000AACC File Offset: 0x00008CCC
		public global::System.IAsyncResult BeginReadRadioParameters(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioParameterPairs paramPairs, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)512141906;
			short num2 = num;
			num = (short)788965970;
			switch (num2 == num)
			{
			}
			num = (short)1073086464;
			short num3 = num;
			num = (short)1642528769;
			if (num != 0)
			{
			}
			num = (short)846528512;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.z z = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.z();
			z.a = this;
			z.b = deviceInfo;
			z.c = paramPairs;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(z.d));
			this.a.b(c);
			return c;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000ABB8 File Offset: 0x00008DB8
		public void EndReadRadioParameters(global::System.IAsyncResult asyncResult)
		{
			short num = (short)1970172642;
			short num2 = num;
			num = (short)1652060898;
			switch (num2 == num)
			{
			}
			num = (short)308871168;
			short num3 = num;
			num = (short)1355350017;
			if (num != 0)
			{
			}
			num = (short)48431104;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000AC68 File Offset: 0x00008E68
		public void ReadRadioParameters(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioParameterPairs paramPairs)
		{
			short num = (short)345025504;
			short num2 = num;
			num = (short)1372892128;
			switch (num2 == num)
			{
			}
			num = (short)550436864;
			short num3 = num;
			num = (short)1473118208;
			if (num != 0)
			{
			}
			num = (short)1201209345;
			if (num != 0)
			{
			}
			global::System.IAsyncResult asyncResult = this.BeginReadRadioParameters(deviceInfo, paramPairs, null, null, null);
			this.EndReadRadioParameters(asyncResult);
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000AD28 File Offset: 0x00008F28
		private void a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.CommonUtil.RadioParameterPairs A_1)
		{
			short num = (short)1003173645;
			short num2 = num;
			num = (short)365967117;
			switch (num2 == num)
			{
			}
			num = (short)1464074240;
			short num3 = num;
			num = (short)1795227648;
			if (num != 0)
			{
			}
			num = (short)1299906561;
			if (num != 0)
			{
			}
			this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read).ReadRadioParameters(A_1);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000ADE4 File Offset: 0x00008FE4
		public global::System.IAsyncResult BeginUpgradeFlashStrap(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)985803666;
			short num2 = num;
			num = (short)1167534994;
			switch (num2 == num)
			{
			}
			num = (short)675938304;
			short num3 = num;
			num = (short)341835777;
			if (num != 0)
			{
			}
			num = (short)715259904;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.aa aa = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.aa();
			aa.a = this;
			aa.b = deviceInfo;
			aa.c = pbaObject;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(aa.d));
			this.a.b(c);
			return c;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000AED4 File Offset: 0x000090D4
		public void EndUpgradeFlashStrap(global::System.IAsyncResult asyncResult)
		{
			short num = (short)1345152293;
			short num2 = num;
			num = (short)363095333;
			switch (num2 == num)
			{
			}
			num = (short)1108279296;
			short num3 = num;
			num = (short)307560449;
			if (num != 0)
			{
			}
			num = (short)834535424;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000AF88 File Offset: 0x00009188
		public void UpgradeFlashStrap(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			short num = (short)1288119455;
			short num2 = num;
			num = (short)1130112159;
			switch (num2 == num)
			{
			}
			num = (short)844431360;
			short num3 = num;
			num = (short)672989184;
			if (num != 0)
			{
			}
			num = (short)1208418305;
			if (num != 0)
			{
			}
			global::System.IAsyncResult asyncResult = this.BeginUpgradeFlashStrap(deviceInfo, pbaObject, null, null, null);
			this.EndUpgradeFlashStrap(asyncResult);
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000B048 File Offset: 0x00009248
		private void c(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.Pba.PbaObject A_1)
		{
			short num = (short)333119489;
			if (num != 0)
			{
			}
			num = (short)851992462;
			short num2 = num;
			num = (short)1723096974;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1652883456;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)508493824;
			if (num != 0)
			{
			}
			this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read).UpgradeFlashStrap(A_1);
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000B100 File Offset: 0x00009300
		public global::System.IAsyncResult BeginUpgradeFDT(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string destModel, string destCPVersion, string serialNumber, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)456334710;
			short num2 = num;
			num = (short)1390878070;
			switch (num2 == num)
			{
			}
			num = (short)1689387008;
			short num3 = num;
			num = (short)2003238913;
			if (num != 0)
			{
			}
			num = (short)1095106560;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.ab ab = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.ab();
			ab.a = this;
			ab.b = deviceInfo;
			ab.c = destModel;
			ab.d = destCPVersion;
			ab.e = serialNumber;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(ab.f));
			this.a.b(c);
			return c;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000B200 File Offset: 0x00009400
		public void EndUpgradeFDT(global::System.IAsyncResult asyncResult)
		{
			short num = (short)1488903596;
			short num2 = num;
			num = (short)236379564;
			switch (num2 == num)
			{
			}
			num = (short)75759616;
			short num3 = num;
			num = (short)1067384833;
			if (num != 0)
			{
			}
			num = (short)179634176;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000B2B0 File Offset: 0x000094B0
		public void UpgradeFDT(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string destModel, string destCPVersion, string serialNumber)
		{
			short num = (short)596312065;
			if (num != 0)
			{
			}
			num = (short)1251649156;
			short num2 = num;
			num = (short)820618884;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1753874432;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)599523328;
			if (num != 0)
			{
			}
			global::System.IAsyncResult asyncResult = this.BeginUpgradeFDT(deviceInfo, destModel, destCPVersion, serialNumber, null, null, null);
			this.EndUpgradeFDT(asyncResult);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000B370 File Offset: 0x00009570
		private void a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, string A_1, string A_2, string A_3)
		{
			short num = (short)880197654;
			short num2 = num;
			num = (short)631816214;
			switch (num2 == num)
			{
			}
			num = (short)1165164544;
			short num3 = num;
			num = (short)269287425;
			if (num != 0)
			{
			}
			num = (short)1097203712;
			if (num != 0)
			{
			}
			this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read).UpgradeFDT(A_1, A_2, A_3);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000B42C File Offset: 0x0000962C
		public global::System.IAsyncResult BeginEraseRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::System.Collections.Generic.List<string> sections, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)1693253632;
			short num2 = num;
			num = (short)1394069965;
			short num3 = num;
			num = (short)1548407245;
			switch (num3 == num)
			{
			}
			num = (short)1786380289;
			if (num != 0)
			{
			}
			num = (short)1857552384;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.ac ac = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.ac();
			ac.a = this;
			ac.b = deviceInfo;
			ac.c = sections;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(ac.d));
			this.a.b(c);
			return c;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000B518 File Offset: 0x00009718
		public global::System.IAsyncResult BeginEraseRadioFromTo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, uint startAddress, uint size, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)1750532096;
			short num2 = num;
			num = (short)827129857;
			if (num != 0)
			{
			}
			num = (short)1230911778;
			short num3 = num;
			num = (short)827865378;
			switch (num3 == num)
			{
			}
			num = (short)543358976;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.ad ad = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.ad();
			ad.a = this;
			ad.b = deviceInfo;
			ad.c = startAddress;
			ad.d = size;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(ad.e));
			this.a.b(c);
			return c;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000B610 File Offset: 0x00009810
		public void EndEraseRadio(global::System.IAsyncResult asyncResult)
		{
			short num = (short)116195328;
			short num2 = num;
			num = (short)749997109;
			short num3 = num;
			num = (short)1263340597;
			switch (num3 == num)
			{
			}
			num = (short)688783361;
			if (num != 0)
			{
			}
			num = (short)1525612544;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000B6C0 File Offset: 0x000098C0
		public void EndEraseRadioFromTo(global::System.IAsyncResult asyncResult)
		{
			short num = (short)1844969472;
			short num2 = num;
			num = (short)817406300;
			short num3 = num;
			num = (short)742760796;
			switch (num3 == num)
			{
			}
			num = (short)1988034560;
			if (num != 0)
			{
			}
			num = (short)1396113409;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000B770 File Offset: 0x00009970
		public void EraseRadio(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::System.Collections.Generic.List<string> sections)
		{
			short num = (short)905445376;
			short num2 = num;
			num = (short)1137770497;
			if (num != 0)
			{
			}
			num = (short)1261581150;
			short num3 = num;
			num = (short)1162294110;
			switch (num3 == num)
			{
			}
			num = (short)560070656;
			if (num != 0)
			{
			}
			global::System.IAsyncResult asyncResult = this.BeginEraseRadio(deviceInfo, sections, null, null, null);
			this.EndEraseRadio(asyncResult);
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000B82C File Offset: 0x00009A2C
		public void EraseRadioFromTo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, uint startAddress, uint size)
		{
			short num = (short)1868693504;
			short num2 = num;
			num = (short)368372571;
			short num3 = num;
			num = (short)1877207899;
			switch (num3 == num)
			{
			}
			num = (short)1054015489;
			if (num != 0)
			{
			}
			num = (short)1909325824;
			if (num != 0)
			{
			}
			global::System.IAsyncResult asyncResult = this.BeginEraseRadioFromTo(deviceInfo, startAddress, size, null, null, null);
			this.EndEraseRadioFromTo(asyncResult);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000B8EC File Offset: 0x00009AEC
		private void a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::System.Collections.Generic.List<string> A_1)
		{
			short num = (short)1624768512;
			short num2 = num;
			num = (short)851504291;
			short num3 = num;
			num = (short)276294819;
			switch (num3 == num)
			{
			}
			num = (short)1025638401;
			if (num != 0)
			{
			}
			num = (short)147587072;
			if (num != 0)
			{
			}
			this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read).EraseRadio(A_1);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000B9A4 File Offset: 0x00009BA4
		private void b(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, uint A_1, uint A_2)
		{
			short num = (short)1600913408;
			short num2 = num;
			num = (short)1791125871;
			short num3 = num;
			num = (short)887646575;
			switch (num3 == num)
			{
			}
			num = (short)632815616;
			if (num != 0)
			{
			}
			num = (short)1212809217;
			if (num != 0)
			{
			}
			this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read).EraseRadioFromTo(A_1, A_2);
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000BA5C File Offset: 0x00009C5C
		public global::System.IAsyncResult BeginWriteRamdownloader(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string filePath, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)322502656;
			short num2 = num;
			num = (short)813748478;
			short num3 = num;
			num = (short)443470078;
			switch (num3 == num)
			{
			}
			num = (short)1156513792;
			if (num != 0)
			{
			}
			num = (short)1854734337;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.ae ae = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.ae();
			ae.a = this;
			ae.b = deviceInfo;
			ae.c = filePath;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(ae.d));
			this.a.b(c);
			return c;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000BB4C File Offset: 0x00009D4C
		public bool EndWriteRamdownloader(global::System.IAsyncResult asyncResult)
		{
			short num = (short)616955904;
			short num2 = num;
			num = (short)1430509027;
			short num3 = num;
			num = (short)1469896163;
			switch (num3 == num)
			{
			}
			num = (short)437059584;
			if (num != 0)
			{
			}
			num = (short)1462108161;
			if (num != 0)
			{
			}
			this.a();
			return (bool)global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000BC04 File Offset: 0x00009E04
		public bool WriteRamdownloader(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string filePath)
		{
			short num = (short)282394624;
			short num2 = num;
			num = (short)1799097088;
			short num3 = num;
			num = (short)1839926016;
			switch (num3 == num)
			{
			}
			num = (short)1769799680;
			if (num != 0)
			{
			}
			num = (short)145358849;
			if (num != 0)
			{
			}
			global::System.IAsyncResult asyncResult = this.BeginWriteRamdownloader(deviceInfo, filePath, null, null, null);
			return this.EndWriteRamdownloader(asyncResult);
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000BCBC File Offset: 0x00009EBC
		private bool a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string filePath)
		{
			short num = (short)65667072;
			short num2 = num;
			num = (short)440401921;
			if (num != 0)
			{
			}
			num = (short)803587058;
			short num3 = num;
			num = (short)405259250;
			switch (num3 == num)
			{
			}
			num = (short)2057764864;
			if (num != 0)
			{
			}
			return this.a(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash).WriteRamdownloader(filePath);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000BD74 File Offset: 0x00009F74
		public global::System.IAsyncResult BeginReadImage(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.UpdateDeviceData images, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)1040449536;
			short num2 = num;
			num = (short)1688010753;
			if (num != 0)
			{
			}
			num = (short)1477352825;
			short num3 = num;
			num = (short)85695865;
			switch (num3 == num)
			{
			}
			num = (short)1903034368;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.af af = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.af();
			af.a = this;
			af.b = deviceInfo;
			af.c = images;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(af.d));
			this.a.b(c);
			return c;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000BE60 File Offset: 0x0000A060
		public global::Motorola.Common.Communication.Pba.UpdateDeviceData EndReadImage(global::System.IAsyncResult asyncResult)
		{
			short num = (short)654901248;
			short num2 = num;
			num = (short)101156313;
			short num3 = num;
			num = (short)1021019609;
			switch (num3 == num)
			{
			}
			num = (short)1901395969;
			if (num != 0)
			{
			}
			num = (short)137428992;
			if (num != 0)
			{
			}
			return (global::Motorola.Common.Communication.Pba.UpdateDeviceData)global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000BF18 File Offset: 0x0000A118
		public global::Motorola.Common.Communication.Pba.UpdateDeviceData ReadImage(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.UpdateDeviceData images)
		{
			short num = (short)1606746112;
			short num2 = num;
			num = (short)243698212;
			short num3 = num;
			num = (short)398035492;
			switch (num3 == num)
			{
			}
			num = (short)854065153;
			if (num != 0)
			{
			}
			num = (short)257490944;
			if (num != 0)
			{
			}
			global::System.IAsyncResult asyncResult = this.BeginReadImage(deviceInfo, images, null, null, null);
			return this.EndReadImage(asyncResult);
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000BFD4 File Offset: 0x0000A1D4
		private global::Motorola.Common.Communication.Pba.UpdateDeviceData a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.Pba.UpdateDeviceData A_1)
		{
			short num = (short)1060831232;
			short num2 = num;
			num = (short)1297985480;
			short num3 = num;
			num = (short)1131196360;
			switch (num3 == num)
			{
			}
			num = (short)83296256;
			if (num != 0)
			{
			}
			num = (short)1120927745;
			if (num != 0)
			{
			}
			return this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash).ReadImage(A_1);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000C090 File Offset: 0x0000A290
		public global::System.IAsyncResult BeginGetFdtInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.FDTType fdtType, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)1726152704;
			short num2 = num;
			num = (short)448834333;
			short num3 = num;
			num = (short)1728097053;
			switch (num3 == num)
			{
			}
			num = (short)167247873;
			if (num != 0)
			{
			}
			num = (short)1103036416;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.ag ag = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.ag();
			ag.a = this;
			ag.b = deviceInfo;
			ag.c = fdtType;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(ag.d));
			this.a.b(c);
			return c;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000C180 File Offset: 0x0000A380
		public global::Motorola.Common.Communication.CommonUtil.FDTInfo EndGetFdtInfo(global::System.IAsyncResult asyncResult)
		{
			short num = (short)42270720;
			short num2 = num;
			num = (short)1862009188;
			short num3 = num;
			num = (short)1508639076;
			switch (num3 == num)
			{
			}
			num = (short)770572289;
			if (num != 0)
			{
			}
			num = (short)497287168;
			if (num != 0)
			{
			}
			return (global::Motorola.Common.Communication.CommonUtil.FDTInfo)global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000C234 File Offset: 0x0000A434
		public global::Motorola.Common.Communication.CommonUtil.FDTInfo GetFdtInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.FDTType fdtType)
		{
			short num = (short)2090663936;
			short num2 = num;
			num = (short)1899278150;
			short num3 = num;
			num = (short)1308274502;
			switch (num3 == num)
			{
			}
			num = (short)2113404929;
			if (num != 0)
			{
			}
			num = (short)576126976;
			if (num != 0)
			{
			}
			global::System.IAsyncResult asyncResult = this.BeginGetFdtInfo(deviceInfo, fdtType, null, null, null);
			return this.EndGetFdtInfo(asyncResult);
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000C2F0 File Offset: 0x0000A4F0
		private global::Motorola.Common.Communication.CommonUtil.FDTInfo a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.CommonUtil.FDTType A_1)
		{
			short num = (short)1131544576;
			short num2 = num;
			num = (short)1540161537;
			if (num != 0)
			{
			}
			num = (short)1754314788;
			short num3 = num;
			num = (short)48085028;
			switch (num3 == num)
			{
			}
			num = (short)1446248448;
			if (num != 0)
			{
			}
			return this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Flash).GetFdtInfo(A_1);
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000C3A8 File Offset: 0x0000A5A8
		public global::System.IAsyncResult BeginReadImageByAddress(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, uint startAddress, uint size, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)1570045952;
			short num2 = num;
			num = (short)732759506;
			short num3 = num;
			num = (short)862586322;
			switch (num3 == num)
			{
			}
			num = (short)2129526785;
			if (num != 0)
			{
			}
			num = (short)421396480;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.ah ah = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.ah();
			ah.a = this;
			ah.b = deviceInfo;
			ah.c = startAddress;
			ah.d = size;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(ah.e));
			this.a.b(c);
			return c;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000C4A0 File Offset: 0x0000A6A0
		public global::Motorola.Common.Communication.CommonUtil.MemoryImage EndReadImageByAddress(global::System.IAsyncResult asyncResult)
		{
			short num = (short)868548608;
			short num2 = num;
			num = (short)1609507555;
			short num3 = num;
			num = (short)1186472675;
			switch (num3 == num)
			{
			}
			num = (short)1150353408;
			if (num != 0)
			{
			}
			num = (short)1977942017;
			if (num != 0)
			{
			}
			return (global::Motorola.Common.Communication.CommonUtil.MemoryImage)global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000C554 File Offset: 0x0000A754
		public global::Motorola.Common.Communication.CommonUtil.MemoryImage ReadImageByAddress(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, uint startAddress, uint size)
		{
			short num = (short)1629749248;
			short num2 = num;
			num = (short)38731777;
			if (num != 0)
			{
			}
			num = (short)1596552533;
			short num3 = num;
			num = (short)1140880725;
			switch (num3 == num)
			{
			}
			num = (short)606797824;
			if (num != 0)
			{
			}
			global::System.IAsyncResult asyncResult = this.BeginReadImageByAddress(deviceInfo, startAddress, size, null, null, null);
			return this.EndReadImageByAddress(asyncResult);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000C610 File Offset: 0x0000A810
		private global::Motorola.Common.Communication.CommonUtil.MemoryImage a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, uint A_1, uint A_2)
		{
			short num = (short)1197146112;
			short num2 = num;
			num = (short)255524865;
			if (num != 0)
			{
			}
			num = (short)1008465836;
			short num3 = num;
			num = (short)1121253292;
			switch (num3 == num)
			{
			}
			num = (short)1209008128;
			if (num != 0)
			{
			}
			return this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read).ReadImageByAddress(A_1, A_2);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000C6CC File Offset: 0x0000A8CC
		public global::System.IAsyncResult BeginReadFilesListInDir(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem dir, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)728236032;
			short num2 = num;
			num = (short)940094781;
			short num3 = num;
			num = (short)288142653;
			switch (num3 == num)
			{
			}
			num = (short)1227620353;
			if (num != 0)
			{
			}
			num = (short)171638784;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.ai ai = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.ai();
			ai.a = this;
			ai.b = deviceInfo;
			ai.c = dir;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(ai.d));
			this.a.b(c);
			return c;
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000C7BC File Offset: 0x0000A9BC
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> EndReadFilesListInDir(global::System.IAsyncResult asyncResult)
		{
			short num = (short)1704853504;
			short num2 = num;
			num = (short)202116285;
			short num3 = num;
			num = (short)1348668605;
			switch (num3 == num)
			{
			}
			num = (short)597557248;
			if (num != 0)
			{
			}
			num = (short)1609105409;
			if (num != 0)
			{
			}
			this.a();
			return (global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>)global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000C878 File Offset: 0x0000AA78
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> ReadFilesListInDir(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem dir)
		{
			short num = (short)199819264;
			short num2 = num;
			num = (short)1434544433;
			short num3 = num;
			num = (short)1501194545;
			switch (num3 == num)
			{
			}
			num = (short)2115567617;
			if (num != 0)
			{
			}
			num = (short)2078670848;
			if (num != 0)
			{
			}
			global::System.IAsyncResult asyncResult = this.BeginReadFilesListInDir(deviceInfo, dir, null, null, null);
			return this.EndReadFilesListInDir(asyncResult);
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000C930 File Offset: 0x0000AB30
		private global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> e(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.Pba.FileItem A_1)
		{
			short num = (short)976617472;
			short num2 = num;
			num = (short)1690436461;
			short num3 = num;
			num = (short)423035757;
			switch (num3 == num)
			{
			}
			num = (short)1815478273;
			if (num != 0)
			{
			}
			num = (short)541786112;
			if (num != 0)
			{
			}
			return this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read).ReadFilesListInDir(A_1);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000C9E8 File Offset: 0x0000ABE8
		public global::System.IAsyncResult BeginReadFile(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem file, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)758120448;
			short num2 = num;
			num = (short)1463732935;
			short num3 = num;
			num = (short)129944263;
			switch (num3 == num)
			{
			}
			num = (short)798490624;
			if (num != 0)
			{
			}
			num = (short)282329089;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.aj aj = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.aj();
			aj.a = this;
			aj.b = deviceInfo;
			aj.c = file;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(aj.d));
			this.a.b(c);
			return c;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000CAD8 File Offset: 0x0000ACD8
		public global::Motorola.Common.Communication.Pba.FileItem EndReadFile(global::System.IAsyncResult asyncResult)
		{
			short num = (short)1675624448;
			short num2 = num;
			num = (short)1359108020;
			short num3 = num;
			num = (short)2068142004;
			switch (num3 == num)
			{
			}
			num = (short)1229586433;
			if (num != 0)
			{
			}
			num = (short)2144665600;
			if (num != 0)
			{
			}
			this.a();
			return (global::Motorola.Common.Communication.Pba.FileItem)global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000CB94 File Offset: 0x0000AD94
		public global::Motorola.Common.Communication.Pba.FileItem ReadFile(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem file)
		{
			short num = (short)972881920;
			short num2 = num;
			num = (short)146376152;
			short num3 = num;
			num = (short)1444513240;
			switch (num3 == num)
			{
			}
			num = (short)604962817;
			if (num != 0)
			{
			}
			num = (short)1430388736;
			if (num != 0)
			{
			}
			global::System.IAsyncResult asyncResult = this.BeginReadFile(deviceInfo, file, null, null, null);
			return this.EndReadFile(asyncResult);
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000CC50 File Offset: 0x0000AE50
		private global::Motorola.Common.Communication.Pba.FileItem d(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.Pba.FileItem A_1)
		{
			short num = (short)598736896;
			short num2 = num;
			num = (short)1753884298;
			short num3 = num;
			num = (short)2144872074;
			switch (num3 == num)
			{
			}
			num = (short)2017394689;
			if (num != 0)
			{
			}
			num = (short)93650944;
			if (num != 0)
			{
			}
			return this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read).ReadFile(A_1);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000CD08 File Offset: 0x0000AF08
		public global::System.IAsyncResult BeginWriteFile(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem file, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)1902903296;
			short num2 = num;
			num = (short)1205240055;
			short num3 = num;
			num = (short)349339895;
			switch (num3 == num)
			{
			}
			num = (short)1071316992;
			if (num != 0)
			{
			}
			num = (short)694550529;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.ak ak = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.ak();
			ak.a = this;
			ak.b = deviceInfo;
			ak.c = file;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(ak.d));
			this.a.b(c);
			return c;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0000CDF8 File Offset: 0x0000AFF8
		public void EndWriteFile(global::System.IAsyncResult asyncResult)
		{
			short num = (short)1636761600;
			short num2 = num;
			num = (short)2105212929;
			if (num != 0)
			{
			}
			num = (short)1391008719;
			short num3 = num;
			num = (short)527440847;
			switch (num3 == num)
			{
			}
			num = (short)605290496;
			if (num != 0)
			{
			}
			this.a();
			global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000CEAC File Offset: 0x0000B0AC
		public void WriteFile(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem file)
		{
			short num = (short)854917120;
			short num2 = num;
			num = (short)755433473;
			if (num != 0)
			{
			}
			num = (short)1216651;
			short num3 = num;
			num = (short)1252036747;
			switch (num3 == num)
			{
			}
			num = (short)253231104;
			if (num != 0)
			{
			}
			global::System.IAsyncResult asyncResult = this.BeginWriteFile(deviceInfo, file, null, null, null);
			this.EndWriteFile(asyncResult);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000CF68 File Offset: 0x0000B168
		private void c(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.Pba.FileItem A_1)
		{
			short num = (short)1490485248;
			short num2 = num;
			num = (short)140296795;
			short num3 = num;
			num = (short)1418445403;
			switch (num3 == num)
			{
			}
			num = (short)1385365504;
			if (num != 0)
			{
			}
			num = (short)2022965249;
			if (num != 0)
			{
			}
			this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read).WriteFile(A_1);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000D024 File Offset: 0x0000B224
		public global::System.IAsyncResult BeginDeleteFile(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem file, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)1040056320;
			short num2 = num;
			num = (short)907328138;
			short num3 = num;
			num = (short)945404554;
			switch (num3 == num)
			{
			}
			num = (short)156499969;
			if (num != 0)
			{
			}
			num = (short)1548615680;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.al al = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.al();
			al.a = this;
			al.b = deviceInfo;
			al.c = file;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(al.d));
			this.a.b(c);
			return c;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000D114 File Offset: 0x0000B314
		public void EndDeleteFile(global::System.IAsyncResult asyncResult)
		{
			short num = (short)1310326784;
			short num2 = num;
			num = (short)1137169536;
			short num3 = num;
			num = (short)1911542912;
			switch (num3 == num)
			{
			}
			num = (short)1722548225;
			if (num != 0)
			{
			}
			num = (short)847183872;
			if (num != 0)
			{
			}
			this.a();
			global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000D1C8 File Offset: 0x0000B3C8
		public void DeleteFile(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem file)
		{
			short num = (short)437780480;
			short num2 = num;
			num = (short)1267276891;
			short num3 = num;
			num = (short)700783707;
			switch (num3 == num)
			{
			}
			num = (short)1247084545;
			if (num != 0)
			{
			}
			num = (short)1518403584;
			if (num != 0)
			{
			}
			global::System.IAsyncResult asyncResult = this.BeginDeleteFile(deviceInfo, file, null, null, null);
			this.EndDeleteFile(asyncResult);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000D284 File Offset: 0x0000B484
		private void b(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.Pba.FileItem A_1)
		{
			short num = (short)1780744192;
			short num2 = num;
			num = (short)244700717;
			short num3 = num;
			num = (short)1795675693;
			switch (num3 == num)
			{
			}
			num = (short)481099776;
			if (num != 0)
			{
			}
			num = (short)1081147393;
			if (num != 0)
			{
			}
			this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read).DeleteFile(A_1);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000D33C File Offset: 0x0000B53C
		public global::System.IAsyncResult BeginGetFileOrDirSize(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem fileOrDir, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)688128000;
			short num2 = num;
			num = (short)216930548;
			short num3 = num;
			num = (short)670046452;
			switch (num3 == num)
			{
			}
			num = (short)2060386304;
			if (num != 0)
			{
			}
			num = (short)165347329;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.am am = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.am();
			am.a = this;
			am.b = deviceInfo;
			am.c = fileOrDir;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(am.d));
			this.a.b(c);
			return c;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000D428 File Offset: 0x0000B628
		public long EndGetFileOrDirSize(global::System.IAsyncResult asyncResult)
		{
			short num = (short)1400242176;
			short num2 = num;
			num = (short)1361223199;
			short num3 = num;
			num = (short)954572319;
			switch (num3 == num)
			{
			}
			num = (short)1189806080;
			if (num != 0)
			{
			}
			num = (short)120782849;
			if (num != 0)
			{
			}
			this.a();
			return (long)global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000D4E4 File Offset: 0x0000B6E4
		public long GetFileOrDirSize(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.FileItem fileOrDir)
		{
			short num = (short)407699456;
			short num2 = num;
			num = (short)25045055;
			short num3 = num;
			num = (short)1216227391;
			switch (num3 == num)
			{
			}
			num = (short)1390411776;
			if (num != 0)
			{
			}
			num = (short)2041249793;
			if (num != 0)
			{
			}
			global::System.IAsyncResult asyncResult = this.BeginGetFileOrDirSize(deviceInfo, fileOrDir, null, null, null);
			return this.EndGetFileOrDirSize(asyncResult);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000D5A0 File Offset: 0x0000B7A0
		private long a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.Pba.FileItem A_1)
		{
			short num = (short)586481664;
			short num2 = num;
			num = (short)1022940271;
			short num3 = num;
			num = (short)2059785327;
			switch (num3 == num)
			{
			}
			num = (short)1496186880;
			if (num != 0)
			{
			}
			num = (short)1053753345;
			if (num != 0)
			{
			}
			return this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read).GetFileOrDirSize(A_1);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x0000D65C File Offset: 0x0000B85C
		public global::System.IAsyncResult BeginReadLanguagePacksInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)874250240;
			short num2 = num;
			num = (short)35022817;
			short num3 = num;
			num = (short)1084516321;
			switch (num3 == num)
			{
			}
			num = (short)799932417;
			if (num != 0)
			{
			}
			num = (short)1135280128;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.an an = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.an();
			an.a = this;
			an.b = deviceInfo;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(an.c));
			this.a.b(c);
			return c;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000D744 File Offset: 0x0000B944
		public global::Motorola.Common.Communication.Pba.LanguagePackData EndReadLanguagePacksInfo(global::System.IAsyncResult asyncResult)
		{
			short num = (short)373751808;
			short num2 = num;
			num = (short)16508909;
			short num3 = num;
			num = (short)1458563053;
			switch (num3 == num)
			{
			}
			num = (short)1839595520;
			if (num != 0)
			{
			}
			num = (short)899809281;
			if (num != 0)
			{
			}
			this.a();
			return (global::Motorola.Common.Communication.Pba.LanguagePackData)global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000D804 File Offset: 0x0000BA04
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadLanguagePacksInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			short num = (short)1975255040;
			short num2 = num;
			num = (short)1484298644;
			short num3 = num;
			num = (short)846502292;
			switch (num3 == num)
			{
			}
			num = (short)628228096;
			if (num != 0)
			{
			}
			num = (short)10551297;
			if (num != 0)
			{
			}
			global::System.IAsyncResult asyncResult = this.BeginReadLanguagePacksInfo(deviceInfo, null, null, null);
			return this.EndReadLanguagePacksInfo(asyncResult);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0000D8C0 File Offset: 0x0000BAC0
		private global::Motorola.Common.Communication.Pba.LanguagePackData h(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			short num = (short)356515840;
			short num2 = num;
			num = (short)1827055032;
			short num3 = num;
			num = (short)870622648;
			switch (num3 == num)
			{
			}
			num = (short)218431488;
			if (num != 0)
			{
			}
			num = (short)386727937;
			if (num != 0)
			{
			}
			return this.a(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read).ReadLanguagePacksInfo();
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0000D978 File Offset: 0x0000BB78
		public global::System.IAsyncResult BeginWriteLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)158531584;
			short num2 = num;
			num = (short)326163200;
			short num3 = num;
			num = (short)841538304;
			switch (num3 == num)
			{
			}
			num = (short)209321984;
			if (num != 0)
			{
			}
			num = (short)732823553;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.ao ao = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.ao();
			ao.a = this;
			ao.b = deviceInfo;
			ao.c = languagePackData;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(ao.d));
			this.a.b(c);
			return c;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000DA68 File Offset: 0x0000BC68
		public void EndWriteLanguagePacks(global::System.IAsyncResult asyncResult)
		{
			short num = (short)1132229847;
			short num2 = num;
			num = (short)574387415;
			switch (num2 == num)
			{
			}
			num = (short)1080754176;
			if (num != 0)
			{
			}
			num = (short)1316421632;
			short num3 = num;
			num = (short)227999745;
			if (num != 0)
			{
			}
			this.a();
			global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000DB20 File Offset: 0x0000BD20
		public void WriteLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData)
		{
			short num = (short)1468642417;
			short num2 = num;
			num = (short)1028502641;
			switch (num2 == num)
			{
			}
			num = (short)1011679233;
			if (num != 0)
			{
			}
			num = (short)855048192;
			short num3 = num;
			num = (short)314966016;
			if (num != 0)
			{
			}
			global::System.IAsyncResult asyncResult = this.BeginWriteLanguagePacks(deviceInfo, languagePackData, null, null, null);
			this.EndWriteLanguagePacks(asyncResult);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0000DBDC File Offset: 0x0000BDDC
		private void d(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.Pba.LanguagePackData A_1)
		{
			short num = (short)267983890;
			short num2 = num;
			num = (short)1158224914;
			switch (num2 == num)
			{
			}
			num = (short)121503744;
			if (num != 0)
			{
			}
			num = (short)1639055360;
			short num3 = num;
			num = (short)192741377;
			if (num != 0)
			{
			}
			this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program).WriteLanguagePacks(A_1);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x0000DC98 File Offset: 0x0000BE98
		public global::System.IAsyncResult BeginDeleteLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)1395535462;
			short num2 = num;
			num = (short)350695014;
			switch (num2 == num)
			{
			}
			num = (short)1810104321;
			if (num != 0)
			{
			}
			num = (short)773586944;
			short num3 = num;
			num = (short)1710948352;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.ap ap = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.ap();
			ap.a = this;
			ap.b = deviceInfo;
			ap.c = languagePackData;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(ap.d));
			this.a.b(c);
			return c;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x0000DD84 File Offset: 0x0000BF84
		public void EndDeleteLanguagePacks(global::System.IAsyncResult asyncResult)
		{
			short num = (short)1097138177;
			if (num != 0)
			{
			}
			num = (short)970976863;
			short num2 = num;
			num = (short)727969375;
			switch (num2 == num)
			{
			}
			num = (short)1166802944;
			short num3 = num;
			num = (short)658243584;
			if (num != 0)
			{
			}
			this.a();
			global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0000DE3C File Offset: 0x0000C03C
		public void DeleteLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData)
		{
			short num = (short)1099235329;
			if (num != 0)
			{
			}
			num = (short)711440964;
			short num2 = num;
			num = (short)1458092612;
			switch (num2 == num)
			{
			}
			num = (short)1231355904;
			short num3 = num;
			num = (short)763035648;
			if (num != 0)
			{
			}
			global::System.IAsyncResult asyncResult = this.BeginDeleteLanguagePacks(deviceInfo, languagePackData, null, null, null);
			this.EndDeleteLanguagePacks(asyncResult);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000DEF8 File Offset: 0x0000C0F8
		private void c(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.Pba.LanguagePackData A_1)
		{
			short num = (short)227585769;
			short num2 = num;
			num = (short)1260760809;
			switch (num2 == num)
			{
			}
			num = (short)1322319873;
			if (num != 0)
			{
			}
			num = (short)1447559168;
			short num3 = num;
			num = (short)1102970880;
			if (num != 0)
			{
			}
			this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program).DeleteLanguagePacks(A_1);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000DFB4 File Offset: 0x0000C1B4
		public global::System.IAsyncResult BeginReadRadioFirmwareDefinedFlashPacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)674758657;
			if (num != 0)
			{
			}
			num = (short)1764869068;
			short num2 = num;
			num = (short)2028192716;
			switch (num2 == num)
			{
			}
			num = (short)1940193280;
			short num3 = num;
			num = (short)387973120;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.aq aq = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.aq();
			aq.a = this;
			aq.b = deviceInfo;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(aq.c));
			this.a.b(c);
			return c;
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000E098 File Offset: 0x0000C298
		public global::Motorola.Common.Communication.Pba.LanguagePackData EndReadRadioFirmwareDefinedFlashPacks(global::System.IAsyncResult asyncResult)
		{
			short num = (short)48043145;
			short num2 = num;
			num = (short)2123764873;
			switch (num2 == num)
			{
			}
			num = (short)695468033;
			if (num != 0)
			{
			}
			num = (short)1562640384;
			short num3 = num;
			num = (short)1625227264;
			if (num != 0)
			{
			}
			this.a();
			return (global::Motorola.Common.Communication.Pba.LanguagePackData)global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000E150 File Offset: 0x0000C350
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadRadioFirmwareDefinedFlashPacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			short num = (short)1183186945;
			if (num != 0)
			{
			}
			num = (short)1754917919;
			short num2 = num;
			num = (short)1025043487;
			switch (num2 == num)
			{
			}
			num = (short)1323237376;
			short num3 = num;
			num = (short)2045181952;
			if (num != 0)
			{
			}
			global::System.IAsyncResult asyncResult = this.BeginReadRadioFirmwareDefinedFlashPacks(deviceInfo, null, null, null);
			return this.EndReadRadioFirmwareDefinedFlashPacks(asyncResult);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000E20C File Offset: 0x0000C40C
		private global::Motorola.Common.Communication.Pba.LanguagePackData g(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			global::Motorola.Common.Communication.Pba.LanguagePackData result;
			for (;;)
			{
				IL_00:
				short num = (short)717160448;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_45;
				}
				int num3;
				global::Motorola.Common.Communication.IMotoDevice motoDevice;
				for (;;)
				{
					IL_33:
					switch (num3)
					{
					case 0:
						result = (motoDevice as global::Motorola.Common.Communication.ITetraDevSpecialOperation).ReadRadioFirmwareDefinedFlashPacks();
						num = (short)1436090370;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)918093825;
						if (num != 0)
						{
						}
						if (!(motoDevice is global::Motorola.Common.Communication.ITetraDevSpecialOperation))
						{
							return result;
						}
						num = (short)832644768;
						short num4 = num;
						num = (short)1049568928;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1634009088;
							if (num != 0)
							{
							}
							num = (short)1258553344;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						return result;
					}
					break;
				}
				IL_45:
				motoDevice = this.a(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read);
				result = null;
				num = (short)898760705;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_33;
			}
			return result;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000E340 File Offset: 0x0000C540
		public global::System.IAsyncResult BeginReadTTSLanguagePacksInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)1796309545;
			short num2 = num;
			num = (short)971670057;
			switch (num2 == num)
			{
			}
			num = (short)1804533761;
			if (num != 0)
			{
			}
			num = (short)1398145024;
			short num3 = num;
			num = (short)760676352;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.ar ar = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.ar();
			ar.a = this;
			ar.b = deviceInfo;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(ar.c));
			this.a.b(c);
			return c;
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000E428 File Offset: 0x0000C628
		public global::Motorola.Common.Communication.Pba.LanguagePackData EndReadTTSLanguagePacksInfo(global::System.IAsyncResult asyncResult)
		{
			short num = (short)1677060405;
			short num2 = num;
			num = (short)558950709;
			switch (num2 == num)
			{
			}
			num = (short)384499712;
			if (num != 0)
			{
			}
			num = (short)187170816;
			short num3 = num;
			num = (short)2145845249;
			if (num != 0)
			{
			}
			this.a();
			return (global::Motorola.Common.Communication.Pba.LanguagePackData)global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000E4E0 File Offset: 0x0000C6E0
		public global::Motorola.Common.Communication.Pba.LanguagePackData ReadTTSLanguagePacksInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			short num = (short)190160551;
			short num2 = num;
			num = (short)1962253991;
			switch (num2 == num)
			{
			}
			num = (short)1922301953;
			if (num != 0)
			{
			}
			num = (short)1795227648;
			short num3 = num;
			num = (short)1631715328;
			if (num != 0)
			{
			}
			global::System.IAsyncResult asyncResult = this.BeginReadTTSLanguagePacksInfo(deviceInfo, null, null, null);
			return this.EndReadTTSLanguagePacksInfo(asyncResult);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000E59C File Offset: 0x0000C79C
		private global::Motorola.Common.Communication.Pba.LanguagePackData f(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			short num = (short)1843034442;
			short num2 = num;
			num = (short)1012758858;
			switch (num2 == num)
			{
			}
			num = (short)923074561;
			if (num != 0)
			{
			}
			num = (short)538705920;
			short num3 = num;
			num = (short)880148480;
			if (num != 0)
			{
			}
			return this.a(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read).ReadTTSLanguagePacksInfo();
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000E654 File Offset: 0x0000C854
		public global::System.IAsyncResult BeginWriteTTSLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)843337739;
			short num2 = num;
			num = (short)1655787531;
			switch (num2 == num)
			{
			}
			num = (short)1066074113;
			if (num != 0)
			{
			}
			num = (short)1520041984;
			short num3 = num;
			num = (short)1492844544;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.@as @as = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.@as();
			@as.a = this;
			@as.b = deviceInfo;
			@as.c = languagePackData;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(@as.d));
			this.a.b(c);
			return c;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000E748 File Offset: 0x0000C948
		public void EndWriteTTSLanguagePacks(global::System.IAsyncResult asyncResult)
		{
			short num = (short)1305732214;
			short num2 = num;
			num = (short)682615926;
			switch (num2 == num)
			{
			}
			num = (short)2026242049;
			if (num != 0)
			{
			}
			num = (short)1160773632;
			short num3 = num;
			num = (short)1609170944;
			if (num != 0)
			{
			}
			this.a();
			global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000E800 File Offset: 0x0000CA00
		public void WriteTTSLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData)
		{
			short num = (short)1292107777;
			if (num != 0)
			{
			}
			num = (short)1151746811;
			short num2 = num;
			num = (short)1804616443;
			switch (num2 == num)
			{
			}
			num = (short)362151936;
			short num3 = num;
			num = (short)166199296;
			if (num != 0)
			{
			}
			global::System.IAsyncResult asyncResult = this.BeginWriteTTSLanguagePacks(deviceInfo, languagePackData, null, null, null);
			this.EndWriteTTSLanguagePacks(asyncResult);
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000E8BC File Offset: 0x0000CABC
		private void b(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.Pba.LanguagePackData A_1)
		{
			short num = (short)1404469673;
			short num2 = num;
			num = (short)551518633;
			switch (num2 == num)
			{
			}
			num = (short)628948992;
			if (num != 0)
			{
			}
			num = (short)1851457536;
			short num3 = num;
			num = (short)1572012033;
			if (num != 0)
			{
			}
			this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program).WriteTTSLanguagePacks(A_1);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000E974 File Offset: 0x0000CB74
		public global::System.IAsyncResult BeginDeleteTTSLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)1526003022;
			short num2 = num;
			num = (short)791213390;
			switch (num2 == num)
			{
			}
			num = (short)52690945;
			if (num != 0)
			{
			}
			num = (short)1049886720;
			short num3 = num;
			num = (short)1299316736;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.at at = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.at();
			at.a = this;
			at.b = deviceInfo;
			at.c = languagePackData;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(at.d));
			this.a.b(c);
			return c;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000EA60 File Offset: 0x0000CC60
		public void EndDeleteTTSLanguagePacks(global::System.IAsyncResult asyncResult)
		{
			short num = (short)753846217;
			short num2 = num;
			num = (short)920635337;
			switch (num2 == num)
			{
			}
			num = (short)788070401;
			if (num != 0)
			{
			}
			num = (short)1555365888;
			short num3 = num;
			num = (short)1623064576;
			if (num != 0)
			{
			}
			this.a();
			global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000EB14 File Offset: 0x0000CD14
		public void DeleteTTSLanguagePacks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.LanguagePackData languagePackData)
		{
			short num = (short)1412560190;
			short num2 = num;
			num = (short)1588000062;
			switch (num2 == num)
			{
			}
			num = (short)1054212097;
			if (num != 0)
			{
			}
			num = (short)1410334720;
			short num3 = num;
			num = (short)868417536;
			if (num != 0)
			{
			}
			global::System.IAsyncResult asyncResult = this.BeginDeleteTTSLanguagePacks(deviceInfo, languagePackData, null, null, null);
			this.EndDeleteTTSLanguagePacks(asyncResult);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000EBCC File Offset: 0x0000CDCC
		private void a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.Pba.LanguagePackData A_1)
		{
			short num = (short)826070685;
			short num2 = num;
			num = (short)1381684893;
			switch (num2 == num)
			{
			}
			num = (short)954335232;
			if (num != 0)
			{
			}
			num = (short)947322880;
			short num3 = num;
			num = (short)89194497;
			if (num != 0)
			{
			}
			this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program).DeleteTTSLanguagePacks(A_1);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000EC84 File Offset: 0x0000CE84
		public global::System.IAsyncResult BeginReadDeviceInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)744809736;
			short num2 = num;
			num = (short)11265288;
			switch (num2 == num)
			{
			}
			num = (short)882900993;
			if (num != 0)
			{
			}
			num = (short)1195507712;
			short num3 = num;
			num = (short)398393344;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.au au = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.au();
			au.a = this;
			au.b = deviceInfo;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(au.c));
			this.a.b(c);
			return c;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000ED6C File Offset: 0x0000CF6C
		public global::Motorola.Common.Communication.CommonUtil.DeviceInfo EndReadDeviceInfo(global::System.IAsyncResult asyncResult)
		{
			short num = (short)1224661272;
			short num2 = num;
			num = (short)37607704;
			switch (num2 == num)
			{
			}
			num = (short)1993080833;
			if (num != 0)
			{
			}
			num = (short)763887616;
			short num3 = num;
			num = (short)1629224960;
			if (num != 0)
			{
			}
			return (global::Motorola.Common.Communication.CommonUtil.DeviceInfo)global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000EE24 File Offset: 0x0000D024
		public global::Motorola.Common.Communication.CommonUtil.DeviceInfo ReadDeviceInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			short num = (short)1916968752;
			short num2 = num;
			num = (short)1382391600;
			switch (num2 == num)
			{
			}
			num = (short)750387201;
			if (num != 0)
			{
			}
			num = (short)816447488;
			short num3 = num;
			num = (short)863502336;
			if (num != 0)
			{
			}
			global::System.IAsyncResult asyncResult = this.BeginReadDeviceInfo(deviceInfo, null, null, null);
			return this.EndReadDeviceInfo(asyncResult);
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000EEE4 File Offset: 0x0000D0E4
		private global::Motorola.Common.Communication.CommonUtil.DeviceInfo e(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			short num = (short)366307250;
			short num2 = num;
			num = (short)2132174770;
			switch (num2 == num)
			{
			}
			num = (short)851312640;
			if (num != 0)
			{
			}
			num = (short)1611726848;
			short num3 = num;
			num = (short)2007302145;
			if (num != 0)
			{
			}
			return this.a(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create).ReadDeviceInfo();
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000EF9C File Offset: 0x0000D19C
		public global::System.IAsyncResult BeginReadExtendedDeviceInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)1881209507;
			short num2 = num;
			num = (short)1803680419;
			switch (num2 == num)
			{
			}
			num = (short)259129344;
			if (num != 0)
			{
			}
			num = (short)537067520;
			short num3 = num;
			num = (short)530907137;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.av av = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.av();
			av.a = this;
			av.b = deviceInfo;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(av.c));
			this.a.b(c);
			return c;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000F080 File Offset: 0x0000D280
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo EndReadExtendedDeviceInfo(global::System.IAsyncResult asyncResult)
		{
			short num = (short)86614246;
			short num2 = num;
			num = (short)1685233894;
			switch (num2 == num)
			{
			}
			num = (short)1239810049;
			if (num != 0)
			{
			}
			num = (short)1043136512;
			short num3 = num;
			num = (short)1492713472;
			if (num != 0)
			{
			}
			this.a();
			return (global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo)global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000F13C File Offset: 0x0000D33C
		public global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo ReadExtendedDeviceInfo(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			short num = (short)178425802;
			short num2 = num;
			num = (short)1140953034;
			switch (num2 == num)
			{
			}
			num = (short)2134048768;
			if (num != 0)
			{
			}
			num = (short)1181679616;
			short num3 = num;
			num = (short)1853292545;
			if (num != 0)
			{
			}
			global::System.IAsyncResult asyncResult = this.BeginReadExtendedDeviceInfo(deviceInfo, null, null, null);
			return this.EndReadExtendedDeviceInfo(asyncResult);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000F1F8 File Offset: 0x0000D3F8
		private global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo d(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			int a_ = 12;
			switch (0)
			{
			case 0:
				goto IL_51;
			}
			short num;
			int num3;
			global::Motorola.Common.Communication.IMotoDevice motoDevice;
			global::Motorola.Common.Communication.CommonUtil.ExtendedDeviceInfo result;
			for (;;)
			{
				IL_13:
				num = (short)1205993472;
				short num2 = num;
				switch (num3)
				{
				case 0:
				{
					num = (short)502648143;
					short num4 = num;
					num = (short)1477561679;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A4;
					default:
						goto IL_FA;
					}
					break;
				}
				case 1:
					goto IL_A4;
				case 2:
					if (motoDevice.DifferentialWriteCapableRadio)
					{
						num = (short)920453121;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = motoDevice.ReadExtendedDeviceInfo();
					num = (short)1179189248;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return result;
				}
				goto IL_51;
				IL_A4:
				result = motoDevice.ExtendedDeviceInfo;
				num = (short)1411579905;
				if (num != 0)
				{
				}
				num = (short)1073152003;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_FA:
			num = (short)272891904;
			if (num != 0)
			{
			}
			return result;
			IL_51:
			motoDevice = this.a(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create);
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.a(motoDevice, global::Motorola.Common.Communication.Service.DeviceServiceManager.b("\udc8d펕鍊쒟잡삣춧\udca9얫춭햯ﮱ\udab3킵ힷ", a_));
			num = (short)1325465602;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_13;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000F360 File Offset: 0x0000D560
		public global::System.IAsyncResult BeginReadDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject referencePba, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)1305637672;
			short num2 = num;
			num = (short)1326543656;
			switch (num2 == num)
			{
			}
			num = (short)186056704;
			if (num != 0)
			{
			}
			num = (short)1113063424;
			short num3 = num;
			num = (short)1305018369;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.aw aw = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.aw();
			aw.a = this;
			aw.b = deviceInfo;
			aw.c = referencePba;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(aw.d));
			c.aa(new global::System.EventHandler(aw.e));
			this.a.b(c);
			return c;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000F460 File Offset: 0x0000D660
		public global::Motorola.Common.Communication.Pba.PbaObject EndReadDevice(global::System.IAsyncResult asyncResult)
		{
			short num = (short)2144650104;
			short num2 = num;
			num = (short)848610168;
			switch (num2 == num)
			{
			}
			num = (short)701497345;
			if (num != 0)
			{
			}
			num = (short)304939008;
			short num3 = num;
			num = (short)2012938240;
			if (num != 0)
			{
			}
			this.a();
			return (global::Motorola.Common.Communication.Pba.PbaObject)global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000F518 File Offset: 0x0000D718
		public global::Motorola.Common.Communication.Pba.PbaObject ReadDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject referencePba)
		{
			short num = (short)609364077;
			short num2 = num;
			num = (short)1107109997;
			switch (num2 == num)
			{
			}
			num = (short)1577058305;
			if (num != 0)
			{
			}
			num = (short)683081728;
			short num3 = num;
			num = (short)1658454016;
			if (num != 0)
			{
			}
			global::System.IAsyncResult asyncResult = this.BeginReadDevice(deviceInfo, referencePba, deviceInfo.OperationId, null, null);
			return this.EndReadDevice(asyncResult);
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000F5D8 File Offset: 0x0000D7D8
		private global::Motorola.Common.Communication.Pba.PbaObject b(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.Pba.PbaObject A_1)
		{
			int a_ = 4;
			short num = (short)766727664;
			short num2 = num;
			num = (short)384456176;
			switch (num2 == num)
			{
			}
			num = (short)900202496;
			if (num != 0)
			{
			}
			num = (short)937361408;
			short num3 = num;
			num = (short)445579265;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.IMotoDevice motoDevice = this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read);
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.a(motoDevice, global::Motorola.Common.Communication.Service.DeviceServiceManager.b("풅쪍ﶓﶗ", a_));
			return motoDevice.ReadDevice(A_1);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000F6AC File Offset: 0x0000D8AC
		private void c(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			short num;
			for (;;)
			{
				IL_00:
				num = (short)1375666176;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_45;
				}
				int num3;
				for (;;)
				{
					IL_33:
					switch (num3)
					{
					case 0:
						this.c.WaitForCancelReading();
						num = (short)1964310530;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						if (this.c == null)
						{
							goto IL_100;
						}
						num = (short)38708034;
						short num4 = num;
						num = (short)1332388674;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)551288832;
							if (num != 0)
							{
							}
							num = (short)289406976;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_FE;
					}
					break;
				}
				IL_45:
				this.c = this.d.GetDevice(deviceInfo);
				num = (short)2063269889;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_33;
			}
			IL_FE:
			IL_100:
			num = (short)1155858433;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000F7E0 File Offset: 0x0000D9E0
		public global::System.IAsyncResult BeginReadBlocks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::System.Collections.ICollection blockList, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)1702586821;
			short num2 = num;
			num = (short)1071999429;
			switch (num2 == num)
			{
			}
			num = (short)2030370817;
			if (num != 0)
			{
			}
			num = (short)1105199104;
			short num3 = num;
			num = (short)1630273536;
			if (num != 0)
			{
			}
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.ax ax = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.ax();
			ax.a = this;
			ax.b = deviceInfo;
			ax.c = blockList;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(ax.d));
			this.a.b(c);
			return c;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x0000F8D4 File Offset: 0x0000DAD4
		public global::Motorola.Common.Communication.Pba.PbaObject EndReadBlocks(global::System.IAsyncResult asyncResult)
		{
			short num = (short)58062883;
			short num2 = num;
			num = (short)741079075;
			switch (num2 == num)
			{
			}
			num = (short)940900353;
			if (num != 0)
			{
			}
			num = (short)2012676096;
			short num3 = num;
			num = (short)1075118080;
			if (num != 0)
			{
			}
			this.a();
			return (global::Motorola.Common.Communication.Pba.PbaObject)global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x06000115 RID: 277 RVA: 0x0000F994 File Offset: 0x0000DB94
		public global::Motorola.Common.Communication.Pba.PbaObject ReadBlocks(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::System.Collections.ICollection blockList)
		{
			short num = (short)1383830168;
			short num2 = num;
			num = (short)1786679960;
			switch (num2 == num)
			{
			}
			num = (short)648609792;
			if (num != 0)
			{
			}
			num = (short)1235025920;
			short num3 = num;
			num = (short)768409601;
			if (num != 0)
			{
			}
			global::System.IAsyncResult asyncResult = this.BeginReadBlocks(deviceInfo, blockList, null, null, null);
			return this.EndReadBlocks(asyncResult);
		}

		// Token: 0x06000116 RID: 278 RVA: 0x0000FA50 File Offset: 0x0000DC50
		private global::Motorola.Common.Communication.Pba.PbaObject a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::System.Collections.ICollection A_1)
		{
			short num = (short)617152513;
			if (num != 0)
			{
			}
			num = (short)1623351690;
			short num2 = num;
			num = (short)1182753162;
			switch (num2 == num)
			{
			}
			num = (short)733675520;
			short num3 = num;
			num = (short)1550254080;
			if (num != 0)
			{
			}
			return this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read).ReadBlocks<object>((global::System.Collections.Generic.ICollection<object>)A_1);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0000FB10 File Offset: 0x0000DD10
		public global::System.IAsyncResult BeginWriteDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, string operationId, global::System.AsyncCallback callback, object state, int? userDefersAllowed = null)
		{
			short num = (short)715317665;
			short num2 = num;
			num = (short)52421025;
			switch (num2 == num)
			{
			}
			num = (short)2016215041;
			if (num != 0)
			{
			}
			num = (short)2139422720;
			if (num != 0)
			{
			}
			num = (short)1784741888;
			short num3 = num;
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.ay ay = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.ay();
			ay.a = this;
			ay.b = deviceInfo;
			ay.c = pbaObject;
			ay.d = userDefersAllowed;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(ay.e));
			this.a.b(c);
			return c;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x0000FC08 File Offset: 0x0000DE08
		public global::Motorola.Common.Communication.Pba.PbaObject EndWriteDevice(global::System.IAsyncResult asyncResult)
		{
			short num = (short)1231552142;
			short num2 = num;
			num = (short)1512373902;
			switch (num2 == num)
			{
			}
			num = (short)1129512960;
			if (num != 0)
			{
			}
			num = (short)257753089;
			if (num != 0)
			{
			}
			num = (short)46989312;
			short num3 = num;
			this.a();
			return (global::Motorola.Common.Communication.Pba.PbaObject)global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000FCC0 File Offset: 0x0000DEC0
		public global::Motorola.Common.Communication.Pba.PbaObject WriteDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, int? userDefersAllowed = null)
		{
			short num = (short)967353857;
			short num2 = num;
			num = (short)576366081;
			switch (num2 == num)
			{
			}
			num = (short)646905856;
			if (num != 0)
			{
			}
			num = (short)2046296065;
			if (num != 0)
			{
			}
			num = (short)684523520;
			short num3 = num;
			global::System.IAsyncResult asyncResult = this.BeginWriteDevice(deviceInfo, pbaObject, null, null, null, userDefersAllowed);
			return this.EndWriteDevice(asyncResult);
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000FD80 File Offset: 0x0000DF80
		private global::Motorola.Common.Communication.Pba.PbaObject a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.Pba.PbaObject A_1, int? A_2 = null)
		{
			int a_ = 5;
			short num = (short)29091937;
			short num2 = num;
			num = (short)1070917729;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_D3:
				num = (short)1458962432;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)744685568;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_86;
				}
				break;
			}
			global::Motorola.Common.Communication.IMotoDevice motoDevice;
			global::Motorola.Common.Communication.Pba.PbaObject result;
			for (;;)
			{
				IL_60:
				switch (num3)
				{
				case 0:
					if (A_0.ConnectionInfo != null)
					{
						num = (short)1671299079;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D8;
				case 1:
					goto IL_D3;
				case 2:
					goto IL_1D4;
				case 3:
					num = (short)720896001;
					if (num != 0)
					{
					}
					if (A_0.ConnectionInfo.AuthInfo == null)
					{
						num = (short)529596422;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = motoDevice.WriteDevice(A_1, A_0.ConnectionInfo.AuthInfo.PreSharedKey_ID, A_2);
					num = (short)1104740354;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_F9;
				case 5:
					if (A_0 != null)
					{
						num = (short)2135883777;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D8;
				case 6:
					goto IL_D8;
				case 7:
					num = (short)817627139;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_86;
				IL_D8:
				result = motoDevice.WriteDevice(A_1, null, A_2);
				num = (short)915079172;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_F9:
			return result;
			IL_1D4:
			num = (short)3670016;
			short num4 = num;
			return result;
			IL_86:
			motoDevice = this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Program);
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.a(motoDevice, global::Motorola.Common.Communication.Service.DeviceServiceManager.b("킆ﮈ歷햐ﺖ滛ﺚ", a_));
			result = null;
			num = (short)984416261;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_60;
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000FF8C File Offset: 0x0000E18C
		public global::System.IAsyncResult BeginWriteImage(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.MemoryImage image, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)747566523;
			short num2 = num;
			num = (short)84014523;
			switch (num2 == num)
			{
			}
			num = (short)1412825089;
			if (num != 0)
			{
			}
			num = (short)857079808;
			if (num != 0)
			{
			}
			num = (short)1407647744;
			short num3 = num;
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.az az = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.az();
			az.a = this;
			az.b = deviceInfo;
			az.c = image;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(az.d));
			this.a.b(c);
			return c;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0001007C File Offset: 0x0000E27C
		public void EndWriteImage(global::System.IAsyncResult asyncResult)
		{
			short num = (short)856511491;
			short num2 = num;
			num = (short)1962562563;
			switch (num2 == num)
			{
			}
			num = (short)1727660033;
			if (num != 0)
			{
			}
			num = (short)1185415168;
			if (num != 0)
			{
			}
			num = (short)1860108288;
			short num3 = num;
			global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0001012C File Offset: 0x0000E32C
		public void WriteImage(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.MemoryImage image)
		{
			short num = (short)304164798;
			short num2 = num;
			num = (short)1249390526;
			switch (num2 == num)
			{
			}
			num = (short)1402404864;
			if (num != 0)
			{
			}
			num = (short)1677524993;
			if (num != 0)
			{
			}
			num = (short)151257088;
			short num3 = num;
			global::System.IAsyncResult asyncResult = this.BeginWriteImage(deviceInfo, image, null, null, null);
			this.EndWriteImage(asyncResult);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x000101E8 File Offset: 0x0000E3E8
		private void a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.CommonUtil.MemoryImage A_1)
		{
			short num = (short)1018298232;
			short num2 = num;
			num = (short)1661403000;
			switch (num2 == num)
			{
			}
			num = (short)268632065;
			if (num != 0)
			{
			}
			num = (short)1389363200;
			if (num != 0)
			{
			}
			num = (short)672727040;
			short num3 = num;
			this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read).WriteImage(A_1);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0001029C File Offset: 0x0000E49C
		public global::System.IAsyncResult BeginReadCPData(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string blockID, uint offset, uint size, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)1060220661;
			short num2 = num;
			num = (short)1538961141;
			switch (num2 == num)
			{
			}
			num = (short)289144833;
			if (num != 0)
			{
			}
			num = (short)1002897408;
			if (num != 0)
			{
			}
			num = (short)1804992512;
			short num3 = num;
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.a0 a = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.a0();
			a.a = this;
			a.b = deviceInfo;
			a.c = blockID;
			a.d = offset;
			a.e = size;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(a.f));
			this.a.b(c);
			return c;
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0001039C File Offset: 0x0000E59C
		public byte[] EndReadCPData(global::System.IAsyncResult asyncResult)
		{
			short num = (short)572556387;
			short num2 = num;
			num = (short)772768867;
			switch (num2 == num)
			{
			}
			num = (short)182517761;
			if (num != 0)
			{
			}
			num = (short)1825964032;
			if (num != 0)
			{
			}
			num = (short)983040000;
			short num3 = num;
			return (byte[])global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00010450 File Offset: 0x0000E650
		public byte[] ReadCPData(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string blockID, uint offset, uint size)
		{
			short num = (short)846103403;
			short num2 = num;
			num = (short)782664555;
			switch (num2 == num)
			{
			}
			num = (short)1272315904;
			if (num != 0)
			{
			}
			num = (short)2035613697;
			if (num != 0)
			{
			}
			num = (short)312934400;
			short num3 = num;
			global::System.IAsyncResult asyncResult = this.BeginReadCPData(deviceInfo, blockID, offset, size, null, null, null);
			return this.EndReadCPData(asyncResult);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00010510 File Offset: 0x0000E710
		private byte[] a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, string A_1, uint A_2, uint A_3)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			global::Motorola.Common.Communication.IMotoDevice motoDevice;
			byte[] result;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
				{
					num2 = (short)759562240;
					short num3 = num2;
					if (motoDevice is global::Motorola.Common.Communication.ITetraDevSpecialOperation)
					{
						num2 = (short)1388445697;
						if (num2 != 0)
						{
						}
						num2 = (short)1170604033;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 1:
					result = (motoDevice as global::Motorola.Common.Communication.ITetraDevSpecialOperation).ReadCPData(A_1, A_2, (ushort)A_3);
					num2 = (short)1950482434;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_11F;
				}
				goto IL_1C;
			}
			IL_11F:
			return result;
			IL_1C:
			result = null;
			motoDevice = this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read);
			num2 = (short)379626738;
			short num4 = num2;
			num2 = (short)335258866;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			default:
			{
				num2 = (short)1307836416;
				if (num2 != 0)
				{
				}
				num2 = (short)1752694784;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x00010640 File Offset: 0x0000E840
		public global::System.IAsyncResult BeginGeneralOperation(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)745543658;
			short num2 = num;
			num = (short)1632114666;
			switch (num2 == num)
			{
			}
			num = (short)1494679552;
			if (num != 0)
			{
			}
			num = (short)1156644865;
			if (num != 0)
			{
			}
			num = (short)203096064;
			short num3 = num;
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.a1 a = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.a1();
			a.a = this;
			a.b = deviceInfo;
			a.c = pbaObject;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(a.d));
			this.a.b(c);
			return c;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x00010730 File Offset: 0x0000E930
		public void EndGeneralOperation(global::System.IAsyncResult asyncResult)
		{
			short num = (short)1872212074;
			short num2 = num;
			num = (short)1806938218;
			switch (num2 == num)
			{
			}
			num = (short)843055105;
			if (num != 0)
			{
			}
			num = (short)244318208;
			if (num != 0)
			{
			}
			num = (short)1180696576;
			short num3 = num;
			global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000107E0 File Offset: 0x0000E9E0
		public void GeneralOperation(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.Pba.PbaObject pbaObject)
		{
			short num = (short)1039143734;
			short num2 = num;
			num = (short)350229302;
			switch (num2 == num)
			{
			}
			num = (short)393936897;
			if (num != 0)
			{
			}
			num = (short)1654652928;
			if (num != 0)
			{
			}
			num = (short)1710292992;
			short num3 = num;
			global::System.IAsyncResult asyncResult = this.BeginGeneralOperation(deviceInfo, pbaObject, null, null, null);
			this.EndGeneralOperation(asyncResult);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0001089C File Offset: 0x0000EA9C
		private void a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.Pba.PbaObject A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			global::Motorola.Common.Communication.IMotoDevice motoDevice;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (motoDevice is global::Motorola.Common.Communication.ITetraDevSpecialOperation)
					{
						num2 = (short)1191116801;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					(motoDevice as global::Motorola.Common.Communication.ITetraDevSpecialOperation).GeneralOperation(A_1);
					num2 = (short)1084030978;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_124;
				}
				goto IL_1C;
			}
			IL_124:
			return;
			IL_1C:
			motoDevice = this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Any);
			num2 = (short)1446018968;
			short num3 = num2;
			num2 = (short)582975384;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			default:
			{
				num2 = (short)1119748096;
				if (num2 != 0)
				{
				}
				num2 = (short)1207959553;
				if (num2 != 0)
				{
				}
				num2 = (short)1436745728;
				short num4 = num2;
				num2 = (short)1320484864;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x000109D0 File Offset: 0x0000EBD0
		public MotorolaDeviceOperation(global::Motorola.Common.Communication.Service.IOperationServiceEvent serviceEvent, global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager communicationManager)
		{
			int a_ = 7;
			this.a = global::Motorola.Common.Communication.CommonUtil.SingletonBase<global::Motorola.Common.Communication.Service.d>.Instance();
			base..ctor();
			this.b = new global::Motorola.Common.Communication.Service.e(serviceEvent);
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("있戴꾎햐ﺖ滛ﺚ붜킞토욢힤욦\udda8슪슬솮醰킴얶쾸튺\udebc\udabe胂럄ꋆ꣈뿊꣌ꯎ￐", a_), global::System.Array.Empty<object>());
			this.d = communicationManager;
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00010A28 File Offset: 0x0000EC28
		public bool CancelOperation(string operationId)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			bool flag;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
				{
					num2 = (short)58720256;
					short num3 = num2;
					if (!flag)
					{
						num2 = (short)964100097;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return flag;
				}
				case 1:
					flag = this.a.e(operationId);
					num2 = (short)8585218;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_F1;
				}
				goto IL_1C;
			}
			IL_F1:
			num2 = (short)1013383169;
			if (num2 != 0)
			{
			}
			return flag;
			IL_1C:
			flag = this.a.d(operationId);
			num2 = (short)1076878804;
			short num4 = num2;
			num2 = (short)1414454740;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return flag;
			default:
			{
				num2 = (short)1189675008;
				if (num2 != 0)
				{
				}
				num2 = (short)1159331840;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00010B54 File Offset: 0x0000ED54
		public global::System.IAsyncResult BeginOpenSession(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation operationType, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter, string operationId, global::System.AsyncCallback callback, object state, bool isRecconectRequired = false)
		{
			short num = (short)1045772041;
			short num2 = num;
			num = (short)1688024841;
			switch (num2 == num)
			{
			}
			num = (short)1100283905;
			if (num != 0)
			{
			}
			num = (short)276103168;
			if (num != 0)
			{
			}
			num = (short)17825792;
			short num3 = num;
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.a2 a = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.a2();
			a.a = this;
			a.b = deviceInfo;
			a.c = operationType;
			a.d = sessionParameter;
			a.e = isRecconectRequired;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(a.f));
			this.a.b(c);
			return c;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x00010C54 File Offset: 0x0000EE54
		public ushort EndOpenSession(global::System.IAsyncResult asyncResult)
		{
			short num = (short)2052805965;
			short num2 = num;
			num = (short)1485198669;
			switch (num2 == num)
			{
			}
			num = (short)1747320833;
			if (num != 0)
			{
			}
			num = (short)1956118528;
			if (num != 0)
			{
			}
			num = (short)233439232;
			short num3 = num;
			return (ushort)global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00010D08 File Offset: 0x0000EF08
		public ushort OpenSession(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation operationType, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter, bool isRecconectRequired = false)
		{
			short num = (short)406540078;
			short num2 = num;
			num = (short)1482051374;
			switch (num2 == num)
			{
			}
			num = (short)1688272896;
			if (num != 0)
			{
			}
			num = (short)1332412417;
			if (num != 0)
			{
			}
			num = (short)1011154944;
			short num3 = num;
			global::System.IAsyncResult asyncResult = this.BeginOpenSession(deviceInfo, operationType, sessionParameter, null, null, null, isRecconectRequired);
			return this.EndOpenSession(asyncResult);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x00010DC4 File Offset: 0x0000EFC4
		public bool UpdateProgrammingStatus(global::Motorola.Common.Communication.CommonUtil.DeviceInfo devInfo, global::Motorola.Common.Communication.CommonUtil.ProgrammingStatus status, ushort sessionID)
		{
			short num = (short)1203240961;
			if (num != 0)
			{
			}
			num = (short)804803218;
			short num2 = num;
			num = (short)1150112402;
			switch (num2 == num)
			{
			}
			num = (short)1103167488;
			if (num != 0)
			{
			}
			num = (short)1889337344;
			short num3 = num;
			global::System.IAsyncResult a_ = this.b(devInfo, status, sessionID);
			return this.a(a_);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x00010E80 File Offset: 0x0000F080
		private global::System.IAsyncResult b(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.CommonUtil.ProgrammingStatus A_1, ushort A_2)
		{
			short num = (short)1288811589;
			short num2 = num;
			num = (short)1958523973;
			switch (num2 == num)
			{
			}
			num = (short)1892483072;
			if (num != 0)
			{
			}
			num = (short)808386561;
			if (num != 0)
			{
			}
			num = (short)448856064;
			short num3 = num;
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.a3 a = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.a3();
			a.a = this;
			a.b = A_0;
			a.c = A_1;
			a.d = A_2;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(null, null, null);
			c.ag(new global::System.EventHandler(a.e));
			this.a.b(c);
			return c;
		}

		// Token: 0x0600012E RID: 302 RVA: 0x00010F74 File Offset: 0x0000F174
		private bool a(global::System.IAsyncResult A_0)
		{
			short num = (short)47850214;
			short num2 = num;
			num = (short)1139090150;
			switch (num2 == num)
			{
			}
			num = (short)1696268288;
			if (num != 0)
			{
			}
			num = (short)527695873;
			if (num != 0)
			{
			}
			num = (short)508035072;
			short num3 = num;
			return (bool)global::Motorola.Common.Communication.Service.d.a(A_0);
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0001102C File Offset: 0x0000F22C
		private bool a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.CommonUtil.ProgrammingStatus A_1, ushort A_2)
		{
			short num = (short)1872856254;
			short num2 = num;
			num = (short)1699054782;
			switch (num2 == num)
			{
			}
			num = (short)1822162944;
			if (num != 0)
			{
			}
			num = (short)1505427457;
			if (num != 0)
			{
			}
			num = (short)960233472;
			short num3 = num;
			return this.a(A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Read).UpdateProgrammingStatus(A_1, A_2);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000110E4 File Offset: 0x0000F2E4
		private ushort a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation A_1, global::Motorola.Common.Communication.CommonUtil.SessionParameter A_2, bool A_3 = false)
		{
			int a_ = 6;
			short num = (short)253820928;
			switch (num)
			{
			default:
			{
				num = (short)1907228676;
				int num2 = (int)((global::System.IntPtr)num);
				string text;
				ushort num4;
				string text2;
				for (;;)
				{
					bool flag;
					switch (num2)
					{
					case 0:
						num = (short)667025409;
						if (num != 0)
						{
						}
						if (this.c.radioState != global::Motorola.Common.Communication.CommonUtil.RadioState.Ready)
						{
							num = (short)181796865;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						text = global::Motorola.Common.Communication.Service.DeviceServiceManager.b("\udd87ﾏ望", a_);
						num = (short)1467351056;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_183;
					case 2:
						if (A_0.ConnectionInfo != null)
						{
							num = (short)1541603331;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26D;
					case 3:
						goto IL_1DB;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_9A;
						}
						continue;
					case 5:
						if (A_0.SerialNumber != null)
						{
							num = (short)2121662478;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_188;
					case 6:
						num = (short)1139277829;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						num = (short)1696800463;
						short num3 = num;
						num = (short)1075191503;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1DB;
						default:
							num = (short)831193088;
							if (num != 0)
							{
							}
							if (this.c == null)
							{
								num = (short)1920008200;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)95223808;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
						goto IL_2F5;
					case 9:
						if (this.c == null)
						{
							num = (short)754515979;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26D;
					case 10:
						goto IL_188;
					case 11:
						return 99;
					case 12:
						if (A_0.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.RS232)
						{
							num = (short)437256209;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26D;
					case 13:
						if (this.c.DeviceInfo.ConnectionInfo != null)
						{
							num = (short)603127826;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5C6;
					case 14:
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("\udc87ﺏ뒓몙펛얟첡쎥\udba7\ud9a9얫솭\udeaf銱\udbb3\ud8b5颷솹費쎽뷅劉량", a_), new object[]
						{
							A_0.RadioID,
							A_0.SerialNumber
						});
						num = (short)1980301322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_268;
					case 16:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_3B3;
							}
							for (;;)
							{
								IL_39C:
								switch (num2)
								{
								case 0:
									this.c.DeviceInfo.SecurityCapability = A_0.SecurityCapability;
									num = (short)214630402;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (A_3)
									{
										num = (short)1923678208;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_425;
								case 2:
									goto IL_425;
								case 3:
									goto IL_44D;
								}
								goto IL_3B3;
								IL_425:
								num4 = this.c.OpenSession(A_1, A_2);
								flag = true;
								num = (short)2079129603;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_44D:
							goto IL_341;
							IL_3B3:
							text = this.c.DeviceInfo.RadioID;
							num = (short)975765505;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_39C;
						}
						catch (global::Motorola.Common.CustomException.CommonException ex)
						{
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("춇ﶓ秊몙肟풣쎥욧囹즫\uddad쎯\udbb1\udbb3\ud8b5颷솹費쎽뷅劉량", a_), new object[]
							{
								text,
								ex.Message
							});
							throw;
						}
						catch (global::System.Exception ex2)
						{
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("춇ﶓ秊몙肟풣쎥욧囹즫\uddad쎯\udbb1\udbb3\ud8b5颷솹費쎽뷅劉량", a_), new object[]
							{
								text,
								ex2.Message
							});
							throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerSessionNotOpened, ex2);
						}
						finally
						{
							num = (short)538902528;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_4F0;
									}
									continue;
								case 1:
									this.a(this.c.DeviceInfo, true);
									num = (short)949616642;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_534;
								}
								IL_4F0:
								if (flag)
								{
									break;
								}
								num = (short)1582825473;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_534:;
						}
						goto IL_537;
						IL_341:
						text2 = string.Empty;
						num = (short)661717005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_537;
					case 18:
						text2 = this.c.DeviceInfo.ConnectionInfo.UniqueAddress;
						num = (short)1675558927;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_9A:
					if (A_0.RadioID != null)
					{
						num = (short)738263040;
						short num5 = num;
						num = (short)1071579142;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_188:
					flag = false;
					num4 = 0;
					this.c = this.d.GetDevice(A_0);
					num = (short)1092550658;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DB:
					num = (short)226033676;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_26D:
					num = (short)1520107527;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_537:
					num = (short)607518729;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_183:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerDeviceNotFound);
				IL_268:
				goto IL_5C6;
				IL_2F5:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerDeviceNotFound);
				IL_5C6:
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("잇憎쎏뺝\udb9f銡\ud9a3蚥잧쒩貫\udaad\ud8afힱ钳튵\uddb7첹햻\uddbdꖿ뿃뗇蟍胏꿓ꗗ", a_), new object[]
				{
					num4,
					text,
					text2
				});
				return num4;
			}
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00011734 File Offset: 0x0000F934
		public global::System.IAsyncResult BeginCloseSession(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, bool pendingDeploy, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)1417589623;
			short num2 = num;
			num = (short)1289335671;
			switch (num2 == num)
			{
			}
			num = (short)491126785;
			if (num != 0)
			{
			}
			num = (short)2118975488;
			if (num != 0)
			{
			}
			num = (short)1415839744;
			short num3 = num;
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.a4 a = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.a4();
			a.a = this;
			a.b = deviceInfo;
			a.c = pendingDeploy;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(a.d));
			this.a.b(c);
			return c;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00011820 File Offset: 0x0000FA20
		public void EndCloseSession(global::System.IAsyncResult asyncResult)
		{
			short num = (short)1431027376;
			short num2 = num;
			num = (short)1126743728;
			switch (num2 == num)
			{
			}
			num = (short)1958019072;
			if (num != 0)
			{
			}
			num = (short)703004673;
			if (num != 0)
			{
			}
			num = (short)309657600;
			short num3 = num;
			global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000118D0 File Offset: 0x0000FAD0
		public void CloseSession(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, bool pendingDeploy)
		{
			short num = (short)1629864135;
			short num2 = num;
			num = (short)782287047;
			switch (num2 == num)
			{
			}
			num = (short)1495924737;
			if (num != 0)
			{
			}
			num = (short)1934360576;
			if (num != 0)
			{
			}
			num = (short)701693952;
			short num3 = num;
			global::System.IAsyncResult asyncResult = this.BeginCloseSession(deviceInfo, pendingDeploy, null, null, null);
			this.EndCloseSession(asyncResult);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x00011990 File Offset: 0x0000FB90
		private void a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, bool A_1)
		{
			int a_ = 18;
			short num = (short)946339843;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)159776769;
					if (num != 0)
					{
					}
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("삓劣肟횡쮣蚥용쎫\uddad햯톳억쮷펹펻킽귁꫃돇韛뇋﷏꿓ꗗ龎ﻝ鯟탡駣", a_), new object[]
					{
						A_0.RadioID,
						A_0.SerialNumber,
						A_1
					});
					num = (short)948174849;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)824311808;
					short num3 = num;
					goto IL_399;
				}
				case 2:
					if (this.c == null)
					{
						num = (short)617545733;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)182648840;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				case 4:
					goto IL_E5;
				case 5:
					return;
				case 6:
					if (A_0.SerialNumber != null)
					{
						num = (short)912392192;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_399;
				case 7:
					try
					{
						num = (short)1866661891;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_21C;
							case 1:
								goto IL_28A;
							case 2:
								goto IL_21C;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_1C3;
								}
								continue;
							}
							IL_1C3:
							global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager communicationManager = this.d;
							if (communicationManager == null)
							{
								num = (short)2085289986;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo = this.c.DeviceInfo;
							communicationManager.RemoveNonPlugPlayDevice((deviceInfo != null) ? deviceInfo.RadioID : null);
							IL_206:
							num = (short)1597308928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_21C:
							num = (short)243746999;
							short num4 = num;
							num = (short)1783580855;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_206;
							default:
								num = (short)1516961792;
								if (num != 0)
								{
								}
								this.c.CloseSession(A_1);
								num = (short)1169096705;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
						}
						IL_28A:
						return;
					}
					catch (global::Motorola.Common.CustomException.CommonException ex)
					{
						if (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_CloseSession_Fail)
						{
							if (ex.ErrorCode != global::Motorola.Common.CustomException.CommonErrorCode.Communication_SequenceManager_Astro_Commit_Fail)
							{
								if (ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.ComponentSessionFailure)
								{
									throw;
								}
								return;
							}
						}
						throw;
					}
					catch (global::System.Exception ex2)
					{
						global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("톓ﮗﾙ즟춡쪣蚥솧쒩貫\udcaf\uddb1잳펵\udfb9쾻춽ꦿ귁꫃돇韛뇋﷏꿓ꗗ", a_), new object[]
						{
							A_0.RadioID,
							ex2.Message
						});
						return;
					}
					finally
					{
						this.c = null;
					}
					goto IL_304;
				case 8:
					if (A_0.ConnectionInfo.SessionID != this.c.DeviceInfo.ConnectionInfo.SessionID)
					{
						num = (short)1055326212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)240648199;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_304;
				}
				IL_55:
				if (A_0.RadioID != null)
				{
					num = (short)553713673;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_399;
				IL_304:
				num = (short)1277034502;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_399:
				num = (short)379322370;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_E5:
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.Service.DeviceServiceManager.b("톓ﮗﾙ즟춡쪣蚥솧쒩貫\udcaf\uddb1잳펵\udfb9쾻춽ꦿ귁꫃뿋ꯍꏏꇑ뷓맕뛗龎뗛뫝샟迡跣闥藧诩飫跭飯틱컳훵菷쫹臻\udefd盿焁␃紅㤇眉Ⰻ愍縏㈑怓縕紗㨙砛笝嘟䬡䜣䌥ࠧ儩ḫ匭", a_), new object[]
			{
				A_0.ConnectionInfo.SessionID,
				this.c.DeviceInfo.ConnectionInfo.SessionID,
				A_0.RadioID
			});
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00011DC0 File Offset: 0x0000FFC0
		public global::System.IAsyncResult BeginQueryRadioUpdateStatus(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, string operationId, global::System.AsyncCallback callback, object state)
		{
			short num = (short)1977406983;
			short num2 = num;
			num = (short)2074269191;
			switch (num2 == num)
			{
			}
			num = (short)268632065;
			if (num != 0)
			{
			}
			num = (short)30277632;
			if (num != 0)
			{
			}
			num = (short)89128960;
			short num3 = num;
			global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.a5 a = new global::Motorola.Common.Communication.Service.MotorolaDeviceOperation.a5();
			a.a = this;
			a.b = deviceInfo;
			global::Motorola.Common.Communication.Service.c c = new global::Motorola.Common.Communication.Service.c(operationId, callback, state);
			c.ag(new global::System.EventHandler(a.c));
			this.a.b(c);
			return c;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00011EA4 File Offset: 0x000100A4
		private byte b(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			short num = (short)1392305733;
			short num2 = num;
			num = (short)842720837;
			switch (num2 == num)
			{
			}
			num = (short)1922564096;
			if (num != 0)
			{
			}
			num = (short)1548877825;
			if (num != 0)
			{
			}
			num = (short)61472768;
			short num3 = num;
			return this.c.QueryRadioUpdateStatus();
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00011F54 File Offset: 0x00010154
		public byte EndQueryRadioUpdateStatus(global::System.IAsyncResult asyncResult)
		{
			short num = (short)1450573825;
			if (num != 0)
			{
			}
			num = (short)444656722;
			short num2 = num;
			num = (short)75033682;
			switch (num2 == num)
			{
			}
			num = (short)1695547392;
			if (num != 0)
			{
			}
			num = (short)1404895232;
			short num3 = num;
			return (byte)global::Motorola.Common.Communication.Service.d.a(asyncResult);
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00012008 File Offset: 0x00010208
		public byte QueryRadioUpdateStatus(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			short num = (short)1992601698;
			short num2 = num;
			num = (short)1447800930;
			switch (num2 == num)
			{
			}
			num = (short)1953497089;
			if (num != 0)
			{
			}
			num = (short)700579840;
			if (num != 0)
			{
			}
			num = (short)437387264;
			short num3 = num;
			global::System.IAsyncResult asyncResult = this.BeginQueryRadioUpdateStatus(deviceInfo, null, null, null);
			return this.EndQueryRadioUpdateStatus(asyncResult);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000120C4 File Offset: 0x000102C4
		private global::Motorola.Common.Communication.IMotoDevice a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation A_1)
		{
			short num;
			if (this.c == null)
			{
				num = (short)1533550623;
				short num2 = num;
				num = (short)420159519;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)767033344;
					if (num != 0)
					{
					}
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerDeviceNotFound);
				}
			}
			num = (short)990642177;
			if (num != 0)
			{
			}
			num = (short)13631488;
			short num3 = num;
			this.c.Init(A_0, A_1, this.b);
			return this.c;
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0001219C File Offset: 0x0001039C
		private global::Motorola.Common.Communication.IMotoDevice a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo)
		{
			short num = (short)1840906241;
			if (num != 0)
			{
			}
			num = (short)1816400812;
			short num2 = num;
			num = (short)1574507436;
			switch (num2 == num)
			{
			}
			num = (short)1632567296;
			if (num != 0)
			{
			}
			num = (short)742981632;
			short num3 = num;
			string managedRadioId = this.d.GetManagedRadioId(deviceInfo);
			global::Motorola.Common.Communication.IMotoDevice device = this.d.GetDevice(managedRadioId);
			if (device == null)
			{
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationManagerDeviceNotFound);
			}
			return device;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0001226C File Offset: 0x0001046C
		private void a()
		{
			short num = (short)2023147835;
			short num2 = num;
			num = (short)1169541435;
			switch (num2 == num)
			{
			}
			num = (short)1208352769;
			if (num != 0)
			{
			}
			num = (short)1846935552;
			if (num != 0)
			{
			}
			num = (short)1972305920;
			short num3 = num;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00012314 File Offset: 0x00010514
		private static void a(global::Motorola.Common.Communication.IMotoDevice A_0, string A_1)
		{
			int a_ = 19;
			short num = (short)1628110851;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int num3;
				string text;
				switch (num2)
				{
				case 0:
					if (A_0.DeviceInfo != null)
					{
						num = (short)583663618;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_75;
				case 1:
					num3 = (int)A_0.DeviceInfo.ConnectionInfo.SessionID;
					text = A_0.DeviceInfo.ConnectionInfo.UniqueAddress;
					num = (short)942080005;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)1091829761;
					if (num != 0)
					{
					}
					num = (short)213581828;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				case 4:
					if (A_0.DeviceInfo.ConnectionInfo != null)
					{
						num = (short)1528102913;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_75;
				case 5:
					goto IL_75;
				case 6:
					return;
				case 7:
					if (A_0.DeviceInfo != null)
					{
						num = (short)1973813256;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 8:
				{
					num = (short)655052605;
					short num4 = num;
					num = (short)637554493;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1560805376;
						if (num != 0)
						{
						}
						break;
					}
					num = (short)674824192;
					short num5 = num;
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(A_1 + global::Motorola.Common.Communication.Service.DeviceServiceManager.b("떔뮚列爵힠쪢욤슦覨킪鶬튮鶰鎲운튶쪸좺풼킾꿀諂臄陼니響냌髒藔ꋘꃜ", a_), new object[]
					{
						A_0.DeviceInfo.RadioID,
						num3,
						text
					});
					num = (short)427884550;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 9:
					return;
				}
				IL_55:
				if (A_0 == null)
				{
					num = (short)452067337;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num3 = 0;
				text = string.Empty;
				num = (short)2102132736;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_75:
				num = (short)1024851975;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0400001D RID: 29
		private readonly global::Motorola.Common.Communication.Service.d a;

		// Token: 0x0400001E RID: 30
		private global::Motorola.Common.Communication.IProgressIndicator b;

		// Token: 0x0400001F RID: 31
		private global::Motorola.Common.Communication.IMotoDevice c;

		// Token: 0x04000020 RID: 32
		private readonly global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager d;

		// Token: 0x02000009 RID: 9
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x060001E9 RID: 489 RVA: 0x000125A8 File Offset: 0x000107A8
			internal void d(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1522069052;
				short num2 = num;
				num = (short)2134568508;
				switch (num2 == num)
				{
				}
				num = (short)1356005377;
				if (num != 0)
				{
				}
				num = (short)2083323904;
				if (num != 0)
				{
				}
				num = (short)609746944;
				short num3 = num;
				global::Motorola.Common.Communication.Service.c c = A_0 as global::Motorola.Common.Communication.Service.c;
				this.a.f(this.b, this.c);
				c.t(null);
			}

			// Token: 0x04000021 RID: 33
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x04000022 RID: 34
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x04000023 RID: 35
			public global::Motorola.Common.Communication.Pba.PbaObject c;
		}

		// Token: 0x0200000A RID: 10
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class b
		{
			// Token: 0x060001EB RID: 491 RVA: 0x00012688 File Offset: 0x00010888
			internal void d(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)998567757;
				short num2 = num;
				num = (short)138997581;
				switch (num2 == num)
				{
				}
				num = (short)1524105217;
				if (num != 0)
				{
				}
				num = (short)266928128;
				if (num != 0)
				{
				}
				num = (short)398065664;
				short num3 = num;
				global::Motorola.Common.Communication.Service.c c = A_0 as global::Motorola.Common.Communication.Service.c;
				this.a.e(this.b, this.c);
				c.t(null);
			}

			// Token: 0x04000024 RID: 36
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x04000025 RID: 37
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x04000026 RID: 38
			public global::Motorola.Common.Communication.Pba.PbaObject c;
		}

		// Token: 0x0200000B RID: 11
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class c
		{
			// Token: 0x060001ED RID: 493 RVA: 0x00012768 File Offset: 0x00010968
			internal void d(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)413990913;
				if (num != 0)
				{
				}
				num = (short)1675658516;
				short num2 = num;
				num = (short)1546028308;
				switch (num2 == num)
				{
				}
				num = (short)1965424640;
				if (num != 0)
				{
				}
				num = (short)256835584;
				short num3 = num;
				global::Motorola.Common.Communication.Service.c c = A_0 as global::Motorola.Common.Communication.Service.c;
				this.a.c(this.b, this.c);
				c.t(null);
			}

			// Token: 0x04000027 RID: 39
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x04000028 RID: 40
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x04000029 RID: 41
			public byte[] c;
		}

		// Token: 0x0200000C RID: 12
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class d
		{
			// Token: 0x060001EF RID: 495 RVA: 0x00012848 File Offset: 0x00010A48
			internal void c(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)886206321;
				short num2 = num;
				num = (short)830500721;
				switch (num2 == num)
				{
				}
				num = (short)1167654913;
				if (num != 0)
				{
				}
				num = (short)2098135040;
				if (num != 0)
				{
				}
				num = (short)633536512;
				short num3 = num;
				(A_0 as global::Motorola.Common.Communication.Service.c).t(this.a.o(this.b));
			}

			// Token: 0x0400002A RID: 42
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x0400002B RID: 43
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;
		}

		// Token: 0x0200000D RID: 13
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class e
		{
			// Token: 0x060001F1 RID: 497 RVA: 0x00012924 File Offset: 0x00010B24
			internal void d(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)2020829242;
				short num2 = num;
				num = (short)1776052282;
				switch (num2 == num)
				{
				}
				num = (short)1533607937;
				if (num != 0)
				{
				}
				num = (short)44498944;
				if (num != 0)
				{
				}
				num = (short)1274216448;
				short num3 = num;
				global::Motorola.Common.Communication.Service.c c = A_0 as global::Motorola.Common.Communication.Service.c;
				this.a.c(this.b, this.c);
				c.t(null);
			}

			// Token: 0x0400002C RID: 44
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x0400002D RID: 45
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x0400002E RID: 46
			public string c;
		}

		// Token: 0x0200000E RID: 14
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class f
		{
			// Token: 0x060001F3 RID: 499 RVA: 0x00012A08 File Offset: 0x00010C08
			internal void c(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1277643694;
				short num2 = num;
				num = (short)1405701038;
				switch (num2 == num)
				{
				}
				num = (short)962789377;
				if (num != 0)
				{
				}
				num = (short)1181286400;
				if (num != 0)
				{
				}
				num = (short)617218048;
				short num3 = num;
				global::Motorola.Common.Communication.Service.c c = A_0 as global::Motorola.Common.Communication.Service.c;
				this.a.n(this.b);
				c.t(null);
			}

			// Token: 0x0400002F RID: 47
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x04000030 RID: 48
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;
		}

		// Token: 0x0200000F RID: 15
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class g
		{
			// Token: 0x060001F5 RID: 501 RVA: 0x00012AE4 File Offset: 0x00010CE4
			internal void d(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)411704450;
				short num2 = num;
				num = (short)500505730;
				switch (num2 == num)
				{
				}
				num = (short)1762131968;
				if (num != 0)
				{
				}
				num = (short)1122500609;
				if (num != 0)
				{
				}
				num = (short)747175936;
				short num3 = num;
				global::Motorola.Common.Communication.Service.c c = A_0 as global::Motorola.Common.Communication.Service.c;
				this.a.b(this.b, this.c);
				c.t(null);
			}

			// Token: 0x04000031 RID: 49
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x04000032 RID: 50
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x04000033 RID: 51
			public byte[] c;
		}

		// Token: 0x02000010 RID: 16
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class h
		{
			// Token: 0x060001F7 RID: 503 RVA: 0x00012BC8 File Offset: 0x00010DC8
			internal void d(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)888540255;
				short num2 = num;
				num = (short)843844703;
				switch (num2 == num)
				{
				}
				num = (short)1336868864;
				if (num != 0)
				{
				}
				num = (short)1313931265;
				if (num != 0)
				{
				}
				num = (short)1616642048;
				short num3 = num;
				global::Motorola.Common.Communication.Service.c c = A_0 as global::Motorola.Common.Communication.Service.c;
				this.a.a(this.b, this.c);
				c.t(null);
			}

			// Token: 0x04000034 RID: 52
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x04000035 RID: 53
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x04000036 RID: 54
			public byte c;
		}

		// Token: 0x02000011 RID: 17
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class i
		{
			// Token: 0x060001F9 RID: 505 RVA: 0x00012CA8 File Offset: 0x00010EA8
			internal void e(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1517660;
				short num2 = num;
				num = (short)911288412;
				switch (num2 == num)
				{
				}
				num = (short)1726545921;
				if (num != 0)
				{
				}
				num = (short)248184832;
				if (num != 0)
				{
				}
				num = (short)25690112;
				short num3 = num;
				global::Motorola.Common.Communication.Service.c c = A_0 as global::Motorola.Common.Communication.Service.c;
				this.a.a(this.b, this.c, this.d);
				c.t(null);
			}

			// Token: 0x04000037 RID: 55
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x04000038 RID: 56
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x04000039 RID: 57
			public byte[] c;

			// Token: 0x0400003A RID: 58
			public ushort d;
		}

		// Token: 0x02000012 RID: 18
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class j
		{
			// Token: 0x060001FB RID: 507 RVA: 0x00012D8C File Offset: 0x00010F8C
			internal void c(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)479943486;
				short num2 = num;
				num = (short)1626954558;
				switch (num2 == num)
				{
				}
				num = (short)823001088;
				if (num != 0)
				{
				}
				num = (short)632946689;
				if (num != 0)
				{
				}
				num = (short)7798784;
				short num3 = num;
				global::Motorola.Common.Communication.Service.c c = A_0 as global::Motorola.Common.Communication.Service.c;
				this.a.m(this.b);
				c.t(null);
			}

			// Token: 0x0400003B RID: 59
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x0400003C RID: 60
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;
		}

		// Token: 0x02000013 RID: 19
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class k
		{
			// Token: 0x060001FD RID: 509 RVA: 0x00012E68 File Offset: 0x00011068
			internal void c(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1870271246;
				short num2 = num;
				num = (short)406524686;
				switch (num2 == num)
				{
				}
				num = (short)1356529664;
				if (num != 0)
				{
				}
				num = (short)350617601;
				if (num != 0)
				{
				}
				num = (short)1427898368;
				short num3 = num;
				(A_0 as global::Motorola.Common.Communication.Service.c).t(this.a.l(this.b));
			}

			// Token: 0x0400003D RID: 61
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x0400003E RID: 62
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;
		}

		// Token: 0x02000014 RID: 20
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class l
		{
			// Token: 0x060001FF RID: 511 RVA: 0x00012F48 File Offset: 0x00011148
			internal void c(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1563426817;
				if (num != 0)
				{
				}
				num = (short)1833637174;
				short num2 = num;
				num = (short)1027413302;
				switch (num2 == num)
				{
				}
				num = (short)241958912;
				if (num != 0)
				{
				}
				num = (short)601882624;
				short num3 = num;
				(A_0 as global::Motorola.Common.Communication.Service.c).t(this.a.k(this.b));
			}

			// Token: 0x0400003F RID: 63
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x04000040 RID: 64
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;
		}

		// Token: 0x02000015 RID: 21
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class m
		{
			// Token: 0x06000201 RID: 513 RVA: 0x00013028 File Offset: 0x00011228
			internal void c(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1075041879;
				short num2 = num;
				num = (short)222746199;
				switch (num2 == num)
				{
				}
				num = (short)1100873728;
				short num3 = num;
				num = (short)969146369;
				if (num != 0)
				{
				}
				num = (short)1154416640;
				if (num != 0)
				{
				}
				(A_0 as global::Motorola.Common.Communication.Service.c).t(this.a.j(this.b));
			}

			// Token: 0x04000041 RID: 65
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x04000042 RID: 66
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;
		}

		// Token: 0x02000016 RID: 22
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class n
		{
			// Token: 0x06000203 RID: 515 RVA: 0x00013104 File Offset: 0x00011304
			internal void d(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1624375297;
				if (num != 0)
				{
				}
				num = (short)1003603310;
				short num2 = num;
				num = (short)151897454;
				switch (num2 == num)
				{
				default:
				{
					num = (short)529334272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)594280448;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.Service.c c = A_0 as global::Motorola.Common.Communication.Service.c;
				this.a.a(this.b, this.c);
				c.t(null);
			}

			// Token: 0x04000043 RID: 67
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x04000044 RID: 68
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x04000045 RID: 69
			public global::Motorola.Common.Communication.CommonUtil.DeviceMode c;
		}

		// Token: 0x02000017 RID: 23
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class o
		{
			// Token: 0x06000205 RID: 517 RVA: 0x000131E8 File Offset: 0x000113E8
			internal void c(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1367093947;
				short num2 = num;
				num = (short)658518715;
				switch (num2 == num)
				{
				}
				num = (short)1554644992;
				short num3 = num;
				num = (short)1765081089;
				if (num != 0)
				{
				}
				num = (short)1627717632;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.Service.c c = A_0 as global::Motorola.Common.Communication.Service.c;
				this.a.i(this.b);
				c.t(null);
			}

			// Token: 0x04000046 RID: 70
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x04000047 RID: 71
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;
		}

		// Token: 0x02000018 RID: 24
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class p
		{
			// Token: 0x06000207 RID: 519 RVA: 0x000132C0 File Offset: 0x000114C0
			internal void d(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1180934870;
				short num2 = num;
				num = (short)2144379606;
				switch (num2 == num)
				{
				}
				num = (short)819003392;
				short num3 = num;
				num = (short)1875181569;
				if (num != 0)
				{
				}
				num = (short)1538719744;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.Service.c c = A_0 as global::Motorola.Common.Communication.Service.c;
				this.a.d(this.b, this.c);
				c.t(null);
			}

			// Token: 0x04000048 RID: 72
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x04000049 RID: 73
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x0400004A RID: 74
			public global::Motorola.Common.Communication.Pba.PbaObject c;
		}

		// Token: 0x02000019 RID: 25
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class q
		{
			// Token: 0x06000209 RID: 521 RVA: 0x000133A0 File Offset: 0x000115A0
			internal void d(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)306839553;
				if (num != 0)
				{
				}
				num = (short)1633567593;
				short num2 = num;
				num = (short)406340457;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1803878400;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1406795776;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.Service.c c = A_0 as global::Motorola.Common.Communication.Service.c;
				this.a.b(this.b, this.c);
				c.t(null);
			}

			// Token: 0x0400004B RID: 75
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x0400004C RID: 76
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x0400004D RID: 77
			public global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType c;
		}

		// Token: 0x0200001A RID: 26
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class r
		{
			// Token: 0x0600020B RID: 523 RVA: 0x00013484 File Offset: 0x00011684
			internal void d(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1389563640;
				short num2 = num;
				num = (short)1822035704;
				switch (num2 == num)
				{
				}
				num = (short)358416384;
				short num3 = num;
				num = (short)1881931776;
				if (num != 0)
				{
				}
				num = (short)1070006273;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.Service.c c = A_0 as global::Motorola.Common.Communication.Service.c;
				this.a.a(this.b, this.c);
				c.t(null);
			}

			// Token: 0x0400004E RID: 78
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x0400004F RID: 79
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x04000050 RID: 80
			public global::Motorola.Common.Communication.Pba.RadioImage.UpdateFileType c;
		}

		// Token: 0x0200001B RID: 27
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class s
		{
			// Token: 0x0600020D RID: 525 RVA: 0x00013564 File Offset: 0x00011764
			internal void f(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1309093211;
				short num2 = num;
				num = (short)1662266715;
				switch (num2 == num)
				{
				}
				num = (short)642449408;
				short num3 = num;
				num = (short)1903820800;
				if (num != 0)
				{
				}
				num = (short)1720844289;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.Service.c c = A_0 as global::Motorola.Common.Communication.Service.c;
				this.a.a(this.b, this.c, this.d, this.e);
				c.t(null);
			}

			// Token: 0x04000051 RID: 81
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x04000052 RID: 82
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x04000053 RID: 83
			public global::Motorola.Common.Communication.Pba.PbaObject c;

			// Token: 0x04000054 RID: 84
			public bool d;

			// Token: 0x04000055 RID: 85
			public int? e;
		}

		// Token: 0x0200001C RID: 28
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class t
		{
			// Token: 0x0600020F RID: 527 RVA: 0x00013654 File Offset: 0x00011854
			internal void d(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1961286568;
				short num2 = num;
				num = (short)1002953640;
				switch (num2 == num)
				{
				}
				num = (short)2010775552;
				short num3 = num;
				num = (short)772014080;
				if (num != 0)
				{
				}
				num = (short)1738539009;
				if (num != 0)
				{
				}
				(A_0 as global::Motorola.Common.Communication.Service.c).t(this.a.a(this.b, this.c));
			}

			// Token: 0x04000056 RID: 86
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x04000057 RID: 87
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x04000058 RID: 88
			public byte[] c;
		}

		// Token: 0x0200001D RID: 29
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class u
		{
			// Token: 0x06000211 RID: 529 RVA: 0x00013738 File Offset: 0x00011938
			internal void e(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)992813378;
				short num2 = num;
				num = (short)55648578;
				switch (num2 == num)
				{
				}
				num = (short)1572012032;
				short num3 = num;
				num = (short)1637548033;
				if (num != 0)
				{
				}
				num = (short)1970339840;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.Service.c c = A_0 as global::Motorola.Common.Communication.Service.c;
				this.a.a(this.b, this.c, this.d);
				c.t(null);
			}

			// Token: 0x04000059 RID: 89
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x0400005A RID: 90
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x0400005B RID: 91
			public global::Motorola.Common.Communication.Pba.PbaObject c;

			// Token: 0x0400005C RID: 92
			public bool d;
		}

		// Token: 0x0200001E RID: 30
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class v
		{
			// Token: 0x06000213 RID: 531 RVA: 0x00013820 File Offset: 0x00011A20
			internal void e(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)211798417;
				short num2 = num;
				num = (short)295225745;
				switch (num2 == num)
				{
				}
				num = (short)624754688;
				short num3 = num;
				num = (short)1244987393;
				if (num != 0)
				{
				}
				num = (short)977076224;
				if (num != 0)
				{
				}
				(A_0 as global::Motorola.Common.Communication.Service.c).t(this.a.a(this.b, this.c, this.d));
			}

			// Token: 0x0400005D RID: 93
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x0400005E RID: 94
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x0400005F RID: 95
			public ushort c;

			// Token: 0x04000060 RID: 96
			public string d;
		}

		// Token: 0x0200001F RID: 31
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class w
		{
			// Token: 0x06000215 RID: 533 RVA: 0x00013908 File Offset: 0x00011B08
			internal void d(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1447707203;
				short num2 = num;
				num = (short)974602819;
				switch (num2 == num)
				{
				}
				num = (short)1408630784;
				short num3 = num;
				num = (short)1723334656;
				if (num != 0)
				{
				}
				num = (short)750911489;
				if (num != 0)
				{
				}
				(A_0 as global::Motorola.Common.Communication.Service.c).t(this.a.b(this.b, this.c));
			}

			// Token: 0x04000061 RID: 97
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x04000062 RID: 98
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x04000063 RID: 99
			public string c;
		}

		// Token: 0x02000020 RID: 32
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class x
		{
			// Token: 0x06000217 RID: 535 RVA: 0x000139E8 File Offset: 0x00011BE8
			internal void e(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1868469587;
				short num2 = num;
				num = (short)71996755;
				switch (num2 == num)
				{
				}
				num = (short)1909915648;
				short num3 = num;
				num = (short)108331009;
				if (num != 0)
				{
				}
				num = (short)943915008;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.Service.c c = A_0 as global::Motorola.Common.Communication.Service.c;
				this.a.a(this.b, this.c, this.d);
				c.t(null);
			}

			// Token: 0x04000064 RID: 100
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x04000065 RID: 101
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x04000066 RID: 102
			public string c;

			// Token: 0x04000067 RID: 103
			public global::System.Collections.Generic.List<byte[]> d;
		}

		// Token: 0x02000021 RID: 33
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class y
		{
			// Token: 0x06000219 RID: 537 RVA: 0x00013AD0 File Offset: 0x00011CD0
			internal void e(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)415526646;
				short num2 = num;
				num = (short)2111008502;
				switch (num2 == num)
				{
				}
				num = (short)1208549376;
				short num3 = num;
				num = (short)100663296;
				if (num != 0)
				{
				}
				num = (short)2117271553;
				if (num != 0)
				{
				}
				(A_0 as global::Motorola.Common.Communication.Service.c).t(this.a.a(this.b, this.c, this.d));
			}

			// Token: 0x04000068 RID: 104
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x04000069 RID: 105
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x0400006A RID: 106
			public global::Motorola.Common.Communication.Pba.PbaObject c;

			// Token: 0x0400006B RID: 107
			public global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DataBlockItem> d;
		}

		// Token: 0x02000022 RID: 34
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class z
		{
			// Token: 0x0600021B RID: 539 RVA: 0x00013BB8 File Offset: 0x00011DB8
			internal void d(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1707128513;
				short num2 = num;
				num = (short)1892792001;
				switch (num2 == num)
				{
				}
				num = (short)703594496;
				short num3 = num;
				num = (short)2027094016;
				if (num != 0)
				{
				}
				num = (short)1159462913;
				if (num != 0)
				{
				}
				this.a.a(this.b, this.c);
			}

			// Token: 0x0400006C RID: 108
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x0400006D RID: 109
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x0400006E RID: 110
			public global::Motorola.Common.Communication.CommonUtil.RadioParameterPairs c;
		}

		// Token: 0x02000023 RID: 35
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class aa
		{
			// Token: 0x0600021D RID: 541 RVA: 0x00013C8C File Offset: 0x00011E8C
			internal void d(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)223739905;
				if (num != 0)
				{
				}
				num = (short)1239472366;
				short num2 = num;
				num = (short)108714222;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1136918528;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)967180288;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.Service.c c = A_0 as global::Motorola.Common.Communication.Service.c;
				this.a.c(this.b, this.c);
				c.t(null);
			}

			// Token: 0x0400006F RID: 111
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x04000070 RID: 112
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x04000071 RID: 113
			public global::Motorola.Common.Communication.Pba.PbaObject c;
		}

		// Token: 0x02000024 RID: 36
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class ab
		{
			// Token: 0x0600021F RID: 543 RVA: 0x00013D6C File Offset: 0x00011F6C
			internal void f(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1473420829;
				short num2 = num;
				num = (short)1231199773;
				switch (num2 == num)
				{
				}
				num = (short)275447808;
				short num3 = num;
				num = (short)663224321;
				if (num != 0)
				{
				}
				num = (short)1653604352;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.Service.c c = A_0 as global::Motorola.Common.Communication.Service.c;
				this.a.a(this.b, this.c, this.d, this.e);
				c.t(null);
			}

			// Token: 0x04000072 RID: 114
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x04000073 RID: 115
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x04000074 RID: 116
			public string c;

			// Token: 0x04000075 RID: 117
			public string d;

			// Token: 0x04000076 RID: 118
			public string e;
		}

		// Token: 0x02000025 RID: 37
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class ac
		{
			// Token: 0x06000221 RID: 545 RVA: 0x00013E58 File Offset: 0x00012058
			internal void d(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)353474328;
				short num2 = num;
				num = (short)798856984;
				switch (num2 == num)
				{
				}
				num = (short)185008128;
				short num3 = num;
				num = (short)500760576;
				if (num != 0)
				{
				}
				num = (short)1327824897;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.Service.c c = A_0 as global::Motorola.Common.Communication.Service.c;
				this.a.a(this.b, this.c);
				c.t(null);
			}

			// Token: 0x04000077 RID: 119
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x04000078 RID: 120
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x04000079 RID: 121
			public global::System.Collections.Generic.List<string> c;
		}

		// Token: 0x02000026 RID: 38
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class ad
		{
			// Token: 0x06000223 RID: 547 RVA: 0x00013F38 File Offset: 0x00012138
			internal void e(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)233239696;
				short num2 = num;
				num = (short)355529872;
				switch (num2 == num)
				{
				}
				num = (short)152109056;
				short num3 = num;
				num = (short)215613441;
				if (num != 0)
				{
				}
				num = (short)1547304960;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.Service.c c = A_0 as global::Motorola.Common.Communication.Service.c;
				this.a.b(this.b, this.c, this.d);
				c.t(null);
			}

			// Token: 0x0400007A RID: 122
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x0400007B RID: 123
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x0400007C RID: 124
			public uint c;

			// Token: 0x0400007D RID: 125
			public uint d;
		}

		// Token: 0x02000027 RID: 39
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class ae
		{
			// Token: 0x06000225 RID: 549 RVA: 0x00014020 File Offset: 0x00012220
			internal void d(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1104412673;
				if (num != 0)
				{
				}
				num = (short)940832715;
				short num2 = num;
				num = (short)307558347;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1675755520;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1160642560;
				if (num != 0)
				{
				}
				(A_0 as global::Motorola.Common.Communication.Service.c).t(this.a.a(this.b, this.c));
			}

			// Token: 0x0400007E RID: 126
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x0400007F RID: 127
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x04000080 RID: 128
			public string c;
		}

		// Token: 0x02000028 RID: 40
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class af
		{
			// Token: 0x06000227 RID: 551 RVA: 0x00014104 File Offset: 0x00012304
			internal void d(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)213753022;
				short num2 = num;
				num = (short)1485937854;
				switch (num2 == num)
				{
				}
				num = (short)1385496576;
				short num3 = num;
				num = (short)1966997504;
				if (num != 0)
				{
				}
				num = (short)201981953;
				if (num != 0)
				{
				}
				(A_0 as global::Motorola.Common.Communication.Service.c).t(this.a.a(this.b, this.c));
			}

			// Token: 0x04000081 RID: 129
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x04000082 RID: 130
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x04000083 RID: 131
			public global::Motorola.Common.Communication.Pba.UpdateDeviceData c;
		}

		// Token: 0x02000029 RID: 41
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class ag
		{
			// Token: 0x06000229 RID: 553 RVA: 0x000141E4 File Offset: 0x000123E4
			internal void d(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)698436091;
				short num2 = num;
				num = (short)1550076411;
				switch (num2 == num)
				{
				}
				num = (short)1566834688;
				short num3 = num;
				num = (short)1128005632;
				if (num != 0)
				{
				}
				num = (short)1408630785;
				if (num != 0)
				{
				}
				(A_0 as global::Motorola.Common.Communication.Service.c).t(this.a.a(this.b, this.c));
			}

			// Token: 0x04000084 RID: 132
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x04000085 RID: 133
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x04000086 RID: 134
			public global::Motorola.Common.Communication.CommonUtil.FDTType c;
		}

		// Token: 0x0200002A RID: 42
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class ah
		{
			// Token: 0x0600022B RID: 555 RVA: 0x000142C4 File Offset: 0x000124C4
			internal void e(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)967835649;
				if (num != 0)
				{
				}
				num = (short)1206923355;
				short num2 = num;
				num = (short)981086299;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1360265216;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2135097344;
				if (num != 0)
				{
				}
				(A_0 as global::Motorola.Common.Communication.Service.c).t(this.a.a(this.b, this.c, this.d));
			}

			// Token: 0x04000087 RID: 135
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x04000088 RID: 136
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x04000089 RID: 137
			public uint c;

			// Token: 0x0400008A RID: 138
			public uint d;
		}

		// Token: 0x0200002B RID: 43
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class ai
		{
			// Token: 0x0600022D RID: 557 RVA: 0x000143AC File Offset: 0x000125AC
			internal void d(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1828188055;
				short num2 = num;
				num = (short)1825435543;
				switch (num2 == num)
				{
				}
				num = (short)388038656;
				short num3 = num;
				num = (short)1356726272;
				if (num != 0)
				{
				}
				num = (short)16121857;
				if (num != 0)
				{
				}
				(A_0 as global::Motorola.Common.Communication.Service.c).t(this.a.e(this.b, this.c));
			}

			// Token: 0x0400008B RID: 139
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x0400008C RID: 140
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x0400008D RID: 141
			public global::Motorola.Common.Communication.Pba.FileItem c;
		}

		// Token: 0x0200002C RID: 44
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class aj
		{
			// Token: 0x0600022F RID: 559 RVA: 0x0001448C File Offset: 0x0001268C
			internal void d(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1067403196;
				short num2 = num;
				num = (short)86263740;
				switch (num2 == num)
				{
				}
				num = (short)337379328;
				short num3 = num;
				num = (short)1462239232;
				if (num != 0)
				{
				}
				num = (short)1584201729;
				if (num != 0)
				{
				}
				(A_0 as global::Motorola.Common.Communication.Service.c).t(this.a.d(this.b, this.c));
			}

			// Token: 0x0400008E RID: 142
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x0400008F RID: 143
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x04000090 RID: 144
			public global::Motorola.Common.Communication.Pba.FileItem c;
		}

		// Token: 0x0200002D RID: 45
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class ak
		{
			// Token: 0x06000231 RID: 561 RVA: 0x0001456C File Offset: 0x0001276C
			internal void d(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1594609720;
				short num2 = num;
				num = (short)765513784;
				switch (num2 == num)
				{
				}
				num = (short)1479344128;
				short num3 = num;
				num = (short)1281818625;
				if (num != 0)
				{
				}
				num = (short)49938432;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.Service.c c = A_0 as global::Motorola.Common.Communication.Service.c;
				this.a.c(this.b, this.c);
				c.t(null);
			}

			// Token: 0x04000091 RID: 145
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x04000092 RID: 146
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x04000093 RID: 147
			public global::Motorola.Common.Communication.Pba.FileItem c;
		}

		// Token: 0x0200002E RID: 46
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class al
		{
			// Token: 0x06000233 RID: 563 RVA: 0x0001464C File Offset: 0x0001284C
			internal void d(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)620224444;
				short num2 = num;
				num = (short)1672929212;
				switch (num2 == num)
				{
				}
				num = (short)483459072;
				short num3 = num;
				num = (short)1577189377;
				if (num != 0)
				{
				}
				num = (short)1972371456;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.Service.c c = A_0 as global::Motorola.Common.Communication.Service.c;
				this.a.b(this.b, this.c);
				c.t(null);
			}

			// Token: 0x04000094 RID: 148
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x04000095 RID: 149
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x04000096 RID: 150
			public global::Motorola.Common.Communication.Pba.FileItem c;
		}

		// Token: 0x0200002F RID: 47
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class am
		{
			// Token: 0x06000235 RID: 565 RVA: 0x00014730 File Offset: 0x00012930
			internal void d(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1161423448;
				short num2 = num;
				num = (short)1520167512;
				switch (num2 == num)
				{
				}
				num = (short)1217265664;
				short num3 = num;
				num = (short)1500774401;
				if (num != 0)
				{
				}
				num = (short)1181614080;
				if (num != 0)
				{
				}
				(A_0 as global::Motorola.Common.Communication.Service.c).t(this.a.a(this.b, this.c));
			}

			// Token: 0x04000097 RID: 151
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x04000098 RID: 152
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x04000099 RID: 153
			public global::Motorola.Common.Communication.Pba.FileItem c;
		}

		// Token: 0x02000030 RID: 48
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class an
		{
			// Token: 0x06000237 RID: 567 RVA: 0x00014814 File Offset: 0x00012A14
			internal void c(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)886073495;
				short num2 = num;
				num = (short)94529687;
				switch (num2 == num)
				{
				}
				num = (short)1132724224;
				short num3 = num;
				num = (short)1058537473;
				if (num != 0)
				{
				}
				num = (short)137494528;
				if (num != 0)
				{
				}
				(A_0 as global::Motorola.Common.Communication.Service.c).t(this.a.h(this.b));
			}

			// Token: 0x0400009A RID: 154
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x0400009B RID: 155
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;
		}

		// Token: 0x02000031 RID: 49
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class ao
		{
			// Token: 0x06000239 RID: 569 RVA: 0x000148F0 File Offset: 0x00012AF0
			internal void d(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1069745763;
				short num2 = num;
				num = (short)1848575587;
				switch (num2 == num)
				{
				}
				num = (short)853344256;
				short num3 = num;
				num = (short)446234624;
				if (num != 0)
				{
				}
				num = (short)1388380161;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.Service.c c = A_0 as global::Motorola.Common.Communication.Service.c;
				this.a.d(this.b, this.c);
				c.t(null);
			}

			// Token: 0x0400009C RID: 156
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x0400009D RID: 157
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x0400009E RID: 158
			public global::Motorola.Common.Communication.Pba.LanguagePackData c;
		}

		// Token: 0x02000032 RID: 50
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class ap
		{
			// Token: 0x0600023B RID: 571 RVA: 0x000149D4 File Offset: 0x00012BD4
			internal void d(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)556890207;
				short num2 = num;
				num = (short)1398503519;
				switch (num2 == num)
				{
				}
				num = (short)467664896;
				short num3 = num;
				num = (short)1205600256;
				if (num != 0)
				{
				}
				num = (short)1657602049;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.Service.c c = A_0 as global::Motorola.Common.Communication.Service.c;
				this.a.c(this.b, this.c);
				c.t(null);
			}

			// Token: 0x0400009F RID: 159
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x040000A0 RID: 160
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x040000A1 RID: 161
			public global::Motorola.Common.Communication.Pba.LanguagePackData c;
		}

		// Token: 0x02000033 RID: 51
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class aq
		{
			// Token: 0x0600023D RID: 573 RVA: 0x00014AB4 File Offset: 0x00012CB4
			internal void c(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)89060979;
				short num2 = num;
				num = (short)981923443;
				switch (num2 == num)
				{
				}
				num = (short)514785280;
				short num3 = num;
				num = (short)454754304;
				if (num != 0)
				{
				}
				num = (short)1644036097;
				if (num != 0)
				{
				}
				(A_0 as global::Motorola.Common.Communication.Service.c).t(this.a.g(this.b));
			}

			// Token: 0x040000A2 RID: 162
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x040000A3 RID: 163
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;
		}

		// Token: 0x02000034 RID: 52
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class ar
		{
			// Token: 0x0600023F RID: 575 RVA: 0x00014B8C File Offset: 0x00012D8C
			internal void c(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1105287225;
				short num2 = num;
				num = (short)474175545;
				switch (num2 == num)
				{
				}
				num = (short)1229783040;
				short num3 = num;
				num = (short)4128768;
				if (num != 0)
				{
				}
				num = (short)1740439553;
				if (num != 0)
				{
				}
				(A_0 as global::Motorola.Common.Communication.Service.c).t(this.a.f(this.b));
			}

			// Token: 0x040000A4 RID: 164
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x040000A5 RID: 165
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;
		}

		// Token: 0x02000035 RID: 53
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class @as
		{
			// Token: 0x06000241 RID: 577 RVA: 0x00014C68 File Offset: 0x00012E68
			internal void d(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1108017153;
				if (num != 0)
				{
				}
				num = (short)1541909410;
				short num2 = num;
				num = (short)76852130;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1123680256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)780533760;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.Service.c c = A_0 as global::Motorola.Common.Communication.Service.c;
				this.a.b(this.b, this.c);
				c.t(null);
			}

			// Token: 0x040000A6 RID: 166
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x040000A7 RID: 167
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x040000A8 RID: 168
			public global::Motorola.Common.Communication.Pba.LanguagePackData c;
		}

		// Token: 0x02000036 RID: 54
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class at
		{
			// Token: 0x06000243 RID: 579 RVA: 0x00014D48 File Offset: 0x00012F48
			internal void d(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)915472385;
				if (num != 0)
				{
				}
				num = (short)549497745;
				short num2 = num;
				num = (short)650226577;
				switch (num2 == num)
				{
				default:
				{
					num = (short)849084416;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)266272768;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.Service.c c = A_0 as global::Motorola.Common.Communication.Service.c;
				this.a.a(this.b, this.c);
				c.t(null);
			}

			// Token: 0x040000A9 RID: 169
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x040000AA RID: 170
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x040000AB RID: 171
			public global::Motorola.Common.Communication.Pba.LanguagePackData c;
		}

		// Token: 0x02000037 RID: 55
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class au
		{
			// Token: 0x06000245 RID: 581 RVA: 0x00014E28 File Offset: 0x00013028
			internal void c(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)515928671;
				short num2 = num;
				num = (short)489845343;
				switch (num2 == num)
				{
				}
				num = (short)2037972992;
				short num3 = num;
				num = (short)531562497;
				if (num != 0)
				{
				}
				num = (short)1003552768;
				if (num != 0)
				{
				}
				(A_0 as global::Motorola.Common.Communication.Service.c).t(this.a.e(this.b));
			}

			// Token: 0x040000AC RID: 172
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x040000AD RID: 173
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;
		}

		// Token: 0x02000038 RID: 56
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class av
		{
			// Token: 0x06000247 RID: 583 RVA: 0x00014F00 File Offset: 0x00013100
			internal void c(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1862144152;
				short num2 = num;
				num = (short)2044006552;
				switch (num2 == num)
				{
				}
				num = (short)1431306240;
				short num3 = num;
				num = (short)652673025;
				if (num != 0)
				{
				}
				num = (short)2028863488;
				if (num != 0)
				{
				}
				(A_0 as global::Motorola.Common.Communication.Service.c).t(this.a.d(this.b));
			}

			// Token: 0x040000AE RID: 174
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x040000AF RID: 175
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;
		}

		// Token: 0x02000039 RID: 57
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class aw
		{
			// Token: 0x06000249 RID: 585 RVA: 0x00014FDC File Offset: 0x000131DC
			internal void d(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)307540873;
				short num2 = num;
				num = (short)1026077577;
				switch (num2 == num)
				{
				}
				num = (short)1037565952;
				short num3 = num;
				num = (short)274268161;
				if (num != 0)
				{
				}
				num = (short)1596784640;
				if (num != 0)
				{
				}
				(A_0 as global::Motorola.Common.Communication.Service.c).t(this.a.b(this.b, this.c));
			}

			// Token: 0x0600024A RID: 586 RVA: 0x000150A4 File Offset: 0x000132A4
			internal void e(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)463882620;
				short num2 = num;
				num = (short)1687636348;
				switch (num2 == num)
				{
				}
				num = (short)1852112896;
				short num3 = num;
				num = (short)1161953281;
				if (num != 0)
				{
				}
				num = (short)23134208;
				if (num != 0)
				{
				}
				this.a.c(this.b);
			}

			// Token: 0x040000B0 RID: 176
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x040000B1 RID: 177
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x040000B2 RID: 178
			public global::Motorola.Common.Communication.Pba.PbaObject c;
		}

		// Token: 0x0200003A RID: 58
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class ax
		{
			// Token: 0x0600024C RID: 588 RVA: 0x00015170 File Offset: 0x00013370
			internal void d(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)992439544;
				short num2 = num;
				num = (short)740912376;
				switch (num2 == num)
				{
				}
				num = (short)1864630272;
				short num3 = num;
				num = (short)608174081;
				if (num != 0)
				{
				}
				num = (short)990248960;
				if (num != 0)
				{
				}
				(A_0 as global::Motorola.Common.Communication.Service.c).t(this.a.a(this.b, this.c));
			}

			// Token: 0x040000B3 RID: 179
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x040000B4 RID: 180
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x040000B5 RID: 181
			public global::System.Collections.ICollection c;
		}

		// Token: 0x0200003B RID: 59
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class ay
		{
			// Token: 0x0600024E RID: 590 RVA: 0x0001524C File Offset: 0x0001344C
			internal void e(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1081540609;
				if (num != 0)
				{
				}
				num = (short)1753157926;
				short num2 = num;
				num = (short)2146570534;
				switch (num2 == num)
				{
				default:
				{
					num = (short)27656192;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1324744704;
				if (num != 0)
				{
				}
				(A_0 as global::Motorola.Common.Communication.Service.c).t(this.a.a(this.b, this.c, this.d));
			}

			// Token: 0x040000B6 RID: 182
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x040000B7 RID: 183
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x040000B8 RID: 184
			public global::Motorola.Common.Communication.Pba.PbaObject c;

			// Token: 0x040000B9 RID: 185
			public int? d;
		}

		// Token: 0x0200003C RID: 60
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class az
		{
			// Token: 0x06000250 RID: 592 RVA: 0x00015330 File Offset: 0x00013530
			internal void d(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)43909121;
				if (num != 0)
				{
				}
				num = (short)920643152;
				short num2 = num;
				num = (short)1098704464;
				switch (num2 == num)
				{
				default:
				{
					num = (short)251920384;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)278331392;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.Service.c c = A_0 as global::Motorola.Common.Communication.Service.c;
				this.a.a(this.b, this.c);
				c.t(null);
			}

			// Token: 0x040000BA RID: 186
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x040000BB RID: 187
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x040000BC RID: 188
			public global::Motorola.Common.Communication.CommonUtil.MemoryImage c;
		}

		// Token: 0x0200003D RID: 61
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a0
		{
			// Token: 0x06000252 RID: 594 RVA: 0x00015410 File Offset: 0x00013610
			internal void f(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1961618834;
				short num2 = num;
				num = (short)1335684498;
				switch (num2 == num)
				{
				}
				num = (short)385417216;
				short num3 = num;
				num = (short)265945088;
				if (num != 0)
				{
				}
				num = (short)401080321;
				if (num != 0)
				{
				}
				(A_0 as global::Motorola.Common.Communication.Service.c).t(this.a.a(this.b, this.c, this.d, this.e));
			}

			// Token: 0x040000BD RID: 189
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x040000BE RID: 190
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x040000BF RID: 191
			public string c;

			// Token: 0x040000C0 RID: 192
			public uint d;

			// Token: 0x040000C1 RID: 193
			public uint e;
		}

		// Token: 0x0200003E RID: 62
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a1
		{
			// Token: 0x06000254 RID: 596 RVA: 0x000154F8 File Offset: 0x000136F8
			internal void d(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1050488315;
				short num2 = num;
				num = (short)682175995;
				switch (num2 == num)
				{
				}
				num = (short)692584448;
				short num3 = num;
				num = (short)406913025;
				if (num != 0)
				{
				}
				num = (short)1264058368;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.Service.c c = A_0 as global::Motorola.Common.Communication.Service.c;
				this.a.a(this.b, this.c);
				c.t(null);
			}

			// Token: 0x040000C2 RID: 194
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x040000C3 RID: 195
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x040000C4 RID: 196
			public global::Motorola.Common.Communication.Pba.PbaObject c;
		}

		// Token: 0x0200003F RID: 63
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a2
		{
			// Token: 0x06000256 RID: 598 RVA: 0x000155D8 File Offset: 0x000137D8
			internal void f(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)192816299;
				short num2 = num;
				num = (short)1266164907;
				switch (num2 == num)
				{
				}
				num = (short)153092096;
				short num3 = num;
				num = (short)1879638016;
				if (num != 0)
				{
				}
				num = (short)1729757185;
				if (num != 0)
				{
				}
				(A_0 as global::Motorola.Common.Communication.Service.c).t(this.a.a(this.b, this.c, this.d, this.e));
			}

			// Token: 0x040000C5 RID: 197
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x040000C6 RID: 198
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x040000C7 RID: 199
			public global::Motorola.Common.Communication.CommonUtil.RadioOperation c;

			// Token: 0x040000C8 RID: 200
			public global::Motorola.Common.Communication.CommonUtil.SessionParameter d;

			// Token: 0x040000C9 RID: 201
			public bool e;
		}

		// Token: 0x02000040 RID: 64
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a3
		{
			// Token: 0x06000258 RID: 600 RVA: 0x000156C8 File Offset: 0x000138C8
			internal void e(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1903471882;
				short num2 = num;
				num = (short)1141484810;
				switch (num2 == num)
				{
				}
				num = (short)1537146880;
				short num3 = num;
				num = (short)1553793025;
				if (num != 0)
				{
				}
				num = (short)2114256896;
				if (num != 0)
				{
				}
				(A_0 as global::Motorola.Common.Communication.Service.c).t(this.a.a(this.b, this.c, this.d));
			}

			// Token: 0x040000CA RID: 202
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x040000CB RID: 203
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x040000CC RID: 204
			public global::Motorola.Common.Communication.CommonUtil.ProgrammingStatus c;

			// Token: 0x040000CD RID: 205
			public ushort d;
		}

		// Token: 0x02000041 RID: 65
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a4
		{
			// Token: 0x0600025A RID: 602 RVA: 0x000157B4 File Offset: 0x000139B4
			internal void d(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)1800925121;
				short num2 = num;
				num = (short)631238593;
				switch (num2 == num)
				{
				}
				num = (short)537919488;
				short num3 = num;
				num = (short)569049089;
				if (num != 0)
				{
				}
				num = (short)255852544;
				if (num != 0)
				{
				}
				global::Motorola.Common.Communication.Service.c c = A_0 as global::Motorola.Common.Communication.Service.c;
				this.a.a(this.b, this.c);
				c.t(null);
			}

			// Token: 0x040000CE RID: 206
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x040000CF RID: 207
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;

			// Token: 0x040000D0 RID: 208
			public bool c;
		}

		// Token: 0x02000042 RID: 66
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a5
		{
			// Token: 0x0600025C RID: 604 RVA: 0x00015894 File Offset: 0x00013A94
			internal void c(object A_0, global::System.EventArgs A_1)
			{
				short num = (short)2023424122;
				short num2 = num;
				num = (short)1624047738;
				switch (num2 == num)
				{
				}
				num = (short)930283520;
				short num3 = num;
				num = (short)459538433;
				if (num != 0)
				{
				}
				num = (short)1612513280;
				if (num != 0)
				{
				}
				(A_0 as global::Motorola.Common.Communication.Service.c).t(this.a.b(this.b));
			}

			// Token: 0x040000D1 RID: 209
			public global::Motorola.Common.Communication.Service.MotorolaDeviceOperation a;

			// Token: 0x040000D2 RID: 210
			public global::Motorola.Common.Communication.CommonUtil.DeviceInfo b;
		}
	}
}
