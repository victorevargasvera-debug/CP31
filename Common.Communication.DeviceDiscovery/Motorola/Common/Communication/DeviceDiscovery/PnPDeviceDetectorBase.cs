using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x0200000A RID: 10
	public abstract class PnPDeviceDetectorBase : global::Motorola.Common.Communication.DeviceDiscovery.IDeviceDetector, global::System.IDisposable
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002A18 File Offset: 0x00000C18
		// (set) Token: 0x0600001F RID: 31 RVA: 0x00002AC8 File Offset: 0x00000CC8
		private protected global::System.Collections.ArrayList _currentExistDevice
		{
			protected get
			{
				short num = (short)926278698;
				short num2 = num;
				num = (short)1083368490;
				switch (num2 == num)
				{
				}
				num = (short)1238695936;
				short num3 = num;
				num = (short)1978662913;
				if (num != 0)
				{
				}
				num = (short)1958608896;
				if (num != 0)
				{
				}
				return this.l;
			}
			private set
			{
				short num = (short)1283421103;
				short num2 = num;
				num = (short)835285935;
				switch (num2 == num)
				{
				}
				num = (short)498991104;
				short num3 = num;
				num = (short)644546560;
				if (num != 0)
				{
				}
				num = (short)1776287745;
				if (num != 0)
				{
				}
				this.l = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002B78 File Offset: 0x00000D78
		protected global::System.Collections.Generic.List<global::System.Guid> lstValidGuid
		{
			get
			{
				short num = (short)1112276993;
				if (num != 0)
				{
				}
				num = (short)1958512383;
				short num2 = num;
				num = (short)662144767;
				switch (num2 == num)
				{
				default:
				{
					num = (short)612040704;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1015939072;
				if (num != 0)
				{
				}
				return this.m;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000021 RID: 33 RVA: 0x00002C28 File Offset: 0x00000E28
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002CD8 File Offset: 0x00000ED8
		protected global::System.Guid _devClass
		{
			get
			{
				short num = (short)2023478379;
				short num2 = num;
				num = (short)1982583915;
				switch (num2 == num)
				{
				}
				num = (short)1345454080;
				short num3 = num;
				num = (short)775618561;
				if (num != 0)
				{
				}
				num = (short)379846656;
				if (num != 0)
				{
				}
				return this.n;
			}
			set
			{
				short num = (short)1323303423;
				short num2 = num;
				num = (short)1202586111;
				switch (num2 == num)
				{
				}
				num = (short)688128000;
				short num3 = num;
				num = (short)1590231041;
				if (num != 0)
				{
				}
				num = (short)861208576;
				if (num != 0)
				{
				}
				this.n = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000023 RID: 35 RVA: 0x00002D88 File Offset: 0x00000F88
		// (set) Token: 0x06000024 RID: 36 RVA: 0x00002E38 File Offset: 0x00001038
		protected global::System.Guid _radioClass
		{
			get
			{
				short num = (short)943063041;
				if (num != 0)
				{
				}
				num = (short)1684157621;
				short num2 = num;
				num = (short)330904757;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1501429760;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2076770304;
				if (num != 0)
				{
				}
				return this.o;
			}
			set
			{
				short num = (short)1663836356;
				short num2 = num;
				num = (short)472326340;
				switch (num2 == num)
				{
				}
				num = (short)1045954560;
				short num3 = num;
				num = (short)769196033;
				if (num != 0)
				{
				}
				num = (short)1661468672;
				if (num != 0)
				{
				}
				this.o = value;
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002EE8 File Offset: 0x000010E8
		protected PnPDeviceDetectorBase()
		{
			this.e = global::System.IntPtr.Zero;
			this.r = false;
			this.h = false;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000026 RID: 38 RVA: 0x00002F44 File Offset: 0x00001144
		public global::System.Collections.Generic.List<string> DeviceGUIDList
		{
			get
			{
				short num = (short)1586102273;
				if (num != 0)
				{
				}
				num = (short)1310235834;
				short num2 = num;
				num = (short)813669562;
				switch (num2 == num)
				{
				default:
				{
					num = (short)546242560;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1220542464;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000027 RID: 39 RVA: 0x00002FF4 File Offset: 0x000011F4
		// (set) Token: 0x06000028 RID: 40 RVA: 0x000030A4 File Offset: 0x000012A4
		public global::Motorola.Common.Communication.DeviceDiscovery.DeviceDetectorType DetectorType
		{
			get
			{
				short num = (short)891434042;
				short num2 = num;
				num = (short)1708602426;
				switch (num2 == num)
				{
				}
				num = (short)1889140736;
				short num3 = num;
				num = (short)1482555393;
				if (num != 0)
				{
				}
				num = (short)570425344;
				if (num != 0)
				{
				}
				return this.b;
			}
			protected set
			{
				short num = (short)1325325993;
				short num2 = num;
				num = (short)679009961;
				switch (num2 == num)
				{
				}
				num = (short)1167261696;
				short num3 = num;
				num = (short)340983809;
				if (num != 0)
				{
				}
				num = (short)1762263040;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003154 File Offset: 0x00001354
		public bool Start()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			bool result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					result = false;
					goto IL_F6;
				case 1:
				{
					num2 = (short)504710835;
					short num3 = num2;
					num2 = (short)425346739;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F6;
					default:
					{
						num2 = (short)1908998145;
						if (num2 != 0)
						{
						}
						num2 = (short)363134976;
						if (num2 != 0)
						{
						}
						num2 = (short)1895366656;
						short num4 = num2;
						if (global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase.g)
						{
							num2 = (short)636551168;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					}
					break;
				}
				case 2:
					return result;
				}
				goto IL_1C;
				IL_F6:
				num2 = (short)2085355522;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_1C:
			result = true;
			this.e();
			num2 = (short)512884737;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00003274 File Offset: 0x00001474
		public void Stop()
		{
			short num = (short)832967769;
			short num2 = num;
			num = (short)1531319385;
			switch (num2 == num)
			{
			}
			num = (short)1231290368;
			short num3 = num;
			num = (short)1201209345;
			if (num != 0)
			{
			}
			num = (short)411697152;
			if (num != 0)
			{
			}
			this.r = true;
			this.p.Set();
			this.Dispose();
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000333C File Offset: 0x0000153C
		internal void b(ref global::System.Windows.Forms.Message A_0)
		{
			short num = (short)345047040;
			short num2 = num;
			num = (short)759234561;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					this.a(ref A_0);
					num = (short)738721793;
					if (num != 0)
					{
					}
					num = (short)344195074;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_59;
					}
					continue;
				case 2:
					return;
				}
				IL_59:
				num = (short)213332023;
				short num4 = num;
				num = (short)1582706743;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)814219264;
					if (num != 0)
					{
					}
					if (A_0.Msg != 537)
					{
						return;
					}
					break;
				}
				num = (short)1167785984;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003458 File Offset: 0x00001658
		private void a(ref global::System.Windows.Forms.Message A_0)
		{
			short num = (short)2145058816;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)431882240;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_B4;
				}
				global::Motorola.Common.Communication.CommonUtil.NativeMethods.DEV_BROADCAST_DEVICEINTERFACE dev_BROADCAST_DEVICEINTERFACE;
				global::Motorola.Common.Communication.CommonUtil.NativeMethods.DEV_BROADCAST_VOLUME dev_BROADCAST_VOLUME;
				long num4;
				global::Motorola.Common.Communication.CommonUtil.NativeMethods.DEV_BROADCAST_VOLUME dev_BROADCAST_VOLUME2;
				global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg originalPnPMsg;
				for (;;)
				{
					IL_51:
					switch (num2)
					{
					case 0:
						if (this.a(dev_BROADCAST_DEVICEINTERFACE.dbcc_classguid))
						{
							num = (short)1295908875;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						if (dev_BROADCAST_VOLUME.dbcv_flags == 0)
						{
							num = (short)2143354885;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						dev_BROADCAST_VOLUME = (global::Motorola.Common.Communication.CommonUtil.NativeMethods.DEV_BROADCAST_VOLUME)global::System.Runtime.InteropServices.Marshal.PtrToStructure(A_0.LParam, typeof(global::Motorola.Common.Communication.CommonUtil.NativeMethods.DEV_BROADCAST_VOLUME));
						num = (short)1741619201;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (((global::Motorola.Common.Communication.CommonUtil.NativeMethods.DEV_BROADCAST_HDR)global::System.Runtime.InteropServices.Marshal.PtrToStructure(A_0.LParam, typeof(global::Motorola.Common.Communication.CommonUtil.NativeMethods.DEV_BROADCAST_HDR))).dbcc_devicetype == 2U)
						{
							num = (short)1570045966;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						dev_BROADCAST_DEVICEINTERFACE = (global::Motorola.Common.Communication.CommonUtil.NativeMethods.DEV_BROADCAST_DEVICEINTERFACE)global::System.Runtime.InteropServices.Marshal.PtrToStructure(A_0.LParam, typeof(global::Motorola.Common.Communication.CommonUtil.NativeMethods.DEV_BROADCAST_DEVICEINTERFACE));
						num = (short)254738447;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)114294787;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_4FF;
					case 6:
						num = (short)1603797002;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (num4 != 32768L)
						{
							num = (short)1572077577;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)180355084;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						return;
					case 9:
						num = (short)166330390;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (((global::Motorola.Common.Communication.CommonUtil.NativeMethods.DEV_BROADCAST_HDR)global::System.Runtime.InteropServices.Marshal.PtrToStructure(A_0.LParam, typeof(global::Motorola.Common.Communication.CommonUtil.NativeMethods.DEV_BROADCAST_HDR))).dbcc_devicetype == 2U)
						{
							num = (short)1863319554;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						dev_BROADCAST_DEVICEINTERFACE = (global::Motorola.Common.Communication.CommonUtil.NativeMethods.DEV_BROADCAST_DEVICEINTERFACE)global::System.Runtime.InteropServices.Marshal.PtrToStructure(A_0.LParam, typeof(global::Motorola.Common.Communication.CommonUtil.NativeMethods.DEV_BROADCAST_DEVICEINTERFACE));
						num = (short)585498624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_39F;
					case 12:
						if (A_0.LParam != global::System.IntPtr.Zero)
						{
							num = (short)463536134;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 13:
						goto IL_33C;
					case 14:
						dev_BROADCAST_VOLUME2 = (global::Motorola.Common.Communication.CommonUtil.NativeMethods.DEV_BROADCAST_VOLUME)global::System.Runtime.InteropServices.Marshal.PtrToStructure(A_0.LParam, typeof(global::Motorola.Common.Communication.CommonUtil.NativeMethods.DEV_BROADCAST_VOLUME));
						num = (short)494272528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (this.a(dev_BROADCAST_DEVICEINTERFACE.dbcc_classguid))
						{
							num = (short)666763281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 16:
						if (dev_BROADCAST_VOLUME2.dbcv_flags == 0)
						{
							num = (short)1233322004;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 17:
						num = (short)1040187410;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (dev_BROADCAST_DEVICEINTERFACE.dbcc_classguid == this._devClass)
						{
							num = (short)1948188691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 19:
					{
						num = (short)1124597761;
						if (num != 0)
						{
						}
						num = (short)12764231;
						short num5 = num;
						num = (short)896189511;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_574;
						default:
							num = (short)926220288;
							if (num != 0)
							{
							}
							originalPnPMsg.m_DeviceAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceDetached;
							originalPnPMsg.sDeviceName = dev_BROADCAST_DEVICEINTERFACE.dbcc_name;
							this.DeviceChanged(originalPnPMsg);
							num = (short)560660493;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 20:
						goto IL_163;
					case 21:
						if (A_0.LParam != global::System.IntPtr.Zero)
						{
							num = (short)1043791876;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 22:
						if (num4 != 32772L)
						{
							num = (short)1445003272;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)327221269;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B4;
				}
				IL_163:
				originalPnPMsg = new global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg();
				originalPnPMsg.m_DeviceAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceDetached;
				originalPnPMsg.sDeviceName = dev_BROADCAST_VOLUME2.dbcv_unitmask.ToString();
				originalPnPMsg.isVolume = true;
				this.DeviceChanged(originalPnPMsg);
				return;
				IL_33C:
				return;
				IL_39F:
				goto IL_574;
				IL_4FF:
				originalPnPMsg = new global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg();
				originalPnPMsg.m_DeviceAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceAttached;
				originalPnPMsg.sDeviceName = dev_BROADCAST_VOLUME.dbcv_unitmask.ToString();
				originalPnPMsg.isVolume = true;
				this.DeviceChanged(originalPnPMsg);
				return;
				IL_574:
				this._devClass = dev_BROADCAST_DEVICEINTERFACE.dbcc_classguid;
				originalPnPMsg.m_DeviceAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceAttached;
				originalPnPMsg.sDeviceName = dev_BROADCAST_DEVICEINTERFACE.dbcc_name;
				this.DeviceChanged(originalPnPMsg);
				return;
				IL_B4:
				originalPnPMsg = new global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg();
				num4 = A_0.WParam.ToInt64();
				num = (short)408944647;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_51;
			}
			}
		}

		// Token: 0x0600002D RID: 45
		protected abstract void HandleDeviceAttached(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg orgPnPMsg);

		// Token: 0x0600002E RID: 46
		protected abstract void HandleDeviceDetached(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg orgPnPMsg);

		// Token: 0x0600002F RID: 47
		protected abstract bool ExtractRadioInformationHelper(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg orgPnPMsg, ref global::Motorola.Common.Communication.IRadioProfile radioInfo);

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000030 RID: 48 RVA: 0x00003A04 File Offset: 0x00001C04
		protected global::Motorola.Common.Communication.CommonUtil.WinAPIWrapper NativeAPISet
		{
			get
			{
				short num = (short)268744391;
				short num2 = num;
				num = (short)113096391;
				switch (num2 == num)
				{
				}
				num = (short)1575944192;
				short num3 = num;
				num = (short)452722689;
				if (num != 0)
				{
				}
				num = (short)529858560;
				if (num != 0)
				{
				}
				return this.c;
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003AB4 File Offset: 0x00001CB4
		private void g()
		{
			short num = (short)391446529;
			if (num != 0)
			{
			}
			num = (short)833993680;
			short num2 = num;
			num = (short)2079374288;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_D3:
				if (global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase.g)
				{
					return;
				}
				num = (short)1410859009;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
			{
				num = (short)1905917952;
				short num4 = num;
				num = (short)786497536;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_B7;
				}
				break;
			}
			}
			for (;;)
			{
				IL_A5:
				switch (num3)
				{
				case 0:
					goto IL_122;
				case 1:
					this.p.Set();
					this.t.WaitOne(100, false);
					num = (short)1579876352;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_D3;
				}
				goto IL_B7;
			}
			IL_122:
			return;
			IL_B7:
			this.r = true;
			num = (short)63176706;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_A5;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003BE8 File Offset: 0x00001DE8
		private void f()
		{
			int a_ = 3;
			short num;
			try
			{
				num = (short)460849152;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_B4;
					}
					global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg originalPnPMsg;
					int num4;
					for (;;)
					{
						IL_31:
						int num3;
						switch (num2)
						{
						case 0:
							if (!this.r)
							{
								num = (short)1521549341;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_55C;
						case 1:
							if (num3 >= this.k.Count)
							{
								num = (short)1541734430;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1541603330;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (!this.r)
							{
								num = (short)1729691664;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_55C;
						case 3:
							goto IL_699;
						case 4:
							goto IL_6E1;
						case 5:
							global::System.Diagnostics.Trace.WriteLine(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("၁⅃╅ⵇ⍉㩋⭍㑏牑ᕓ㡕硗᭙⡛⩝şšౣཥ٧൩䱫⍭ᕯűݳ᝵ίό嵻", a_));
							num = (short)2030436373;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_3FA;
						case 7:
							if (originalPnPMsg.m_DeviceAction == global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceAttached)
							{
								num = (short)1799749637;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1104085002;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
						{
							object syncRoot = this.j.SyncRoot;
							bool flag = false;
							num = (short)225574930;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							try
							{
								this.HandleDeviceDetached(originalPnPMsg);
								goto IL_6E1;
							}
							catch (global::System.Exception ex)
							{
								string str = global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("݁㱃╅ⵇ㩉㡋❍㽏㱑瑓㽕㙗穙ᡛ㭝ᙟୡݣͥⱧཀྵᡫ୭፯ٱ᭳ѵ㩷᭹ཻ᭽멿뢁풃ﶍ슑望욕햗ﮛ쪝좟킡솣장첧邩貫", a_);
								global::System.Exception ex2 = ex;
								global::System.Diagnostics.Trace.WriteLine(str + ((ex2 != null) ? ex2.ToString() : null));
								goto IL_6E1;
							}
							goto IL_1D8;
						case 10:
						{
							if (originalPnPMsg.m_DeviceAction == global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceDetached)
							{
								num = (short)1658585107;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							string format = global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("၁⅃╅ⵇ⍉㩋⭍㑏牑ᕓ㡕硗ཙ㉛㵝౟ݡգࡥ䡧㩩ɫ㹭偯㽱ᅳյ୷᭹᭻᭽ꅿ", a_);
							global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteVerbose(format, global::System.Array.Empty<object>());
							num = (short)1970208772;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
							goto IL_1D8;
						case 12:
							if (!this.r)
							{
								num = (short)1610940424;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1D8;
						case 13:
							if (this.t != null)
							{
								num = (short)1157234712;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_763;
						case 14:
							goto IL_3FA;
						case 15:
							goto IL_E5;
						case 16:
							originalPnPMsg = (global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg)this.k[num3];
							num = (short)2067595271;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							if (num4 >= this.i.Count)
							{
								num = (short)418578455;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.k.Add(this.i[num4]);
							num4++;
							num = (short)842137625;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
							goto IL_256;
						case 19:
							global::System.Diagnostics.Trace.WriteLine(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("၁⅃╅ⵇ⍉㩋⭍㑏牑ᕓ㡕硗ṙ㥛⩝şšౣཥ٧൩䱫⍭ᕯűݳ᝵ίό嵻", a_));
							num = (short)683081737;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
							this.p.Set();
							num = (short)71368719;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 21:
							try
							{
								this.HandleDeviceAttached(originalPnPMsg);
								goto IL_6E1;
							}
							catch (global::System.Exception ex3)
							{
								string str2 = global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("݁㱃╅ⵇ㩉㡋❍㽏㱑瑓㽕㙗穙ᡛ㭝ᙟୡݣͥⱧཀྵᡫ୭፯ٱ᭳ѵ㩷᭹ཻ᭽멿뢁풃ﶍ슑望욕햗ﮛ쪝좟킡솣장첧邩貫", a_);
								global::System.Exception ex4 = ex3;
								global::System.Diagnostics.Trace.WriteLine(str2 + ((ex4 != null) ? ex4.ToString() : null));
								goto IL_6E1;
							}
							goto Block_8;
						case 22:
							if (this.r)
							{
								num = (short)20840459;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_E5;
						case 23:
							num = (short)1226244122;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 24:
							this.t.Set();
							num = (short)184221724;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 25:
							goto IL_699;
						case 26:
							if (this.i.Count > 0)
							{
								num = (short)1719271444;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_E5;
						case 27:
							goto IL_77C;
						case 28:
							goto IL_763;
						case 29:
							num3++;
							num = (short)250150918;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 30:
							goto IL_55C;
						}
						goto IL_B4;
						IL_E5:
						this.p.WaitOne();
						num = (short)591527948;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1D8:
						num = (short)831782925;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3FA:
						num = (short)1458896897;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						Block_8:
						try
						{
							IL_256:
							switch (0)
							{
							case 0:
								goto IL_27B;
							}
							int num5;
							for (;;)
							{
								IL_260:
								switch (num2)
								{
								case 0:
									if (num5 >= this.j.Count)
									{
										num = (short)861863939;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									this.k.Add(this.j[num5]);
									num5++;
									num = (short)226754564;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_2D4;
								case 2:
									goto IL_33A;
								case 3:
									this.j.Clear();
									num = (short)227278850;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_2D4;
								}
								goto IL_27B;
								IL_2D4:
								num = (short)16187392;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_33A:
							goto IL_53B;
							IL_27B:
							object syncRoot;
							bool flag;
							global::System.Threading.Monitor.Enter(syncRoot, ref flag);
							num5 = 0;
							num = (short)455081985;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_260;
						}
						finally
						{
							num = (short)487784450;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_3F7;
								case 1:
								{
									num = (short)1825493251;
									short num6 = num;
									num = (short)2090193155;
									switch ((num6 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_377;
									default:
									{
										num = (short)433192960;
										if (num != 0)
										{
										}
										object syncRoot;
										global::System.Threading.Monitor.Exit(syncRoot);
										num = (short)702218240;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_371;
									}
									continue;
								}
								goto IL_371;
								IL_377:
								num = (short)223936513;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_371:
								bool flag;
								if (flag)
								{
									goto IL_377;
								}
								break;
							}
							IL_3F7:;
						}
						goto IL_3FA;
						IL_53B:
						num3 = 0;
						num = (short)1856241678;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_55C:
						this.k.Clear();
						num = (short)2063990806;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_699:
						num = (short)1429209105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_6E1:
						num = (short)606666752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_763:
						num = (short)1258815515;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_77C:
					break;
					IL_B4:
					originalPnPMsg = new global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg();
					this.a(out this.i);
					num4 = 0;
					num = (short)2105671683;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				}
				}
			}
			catch (global::System.Exception)
			{
			}
			num = (short)2067922945;
			if (num != 0)
			{
			}
			num = (short)1593311232;
			short num7 = num;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0000442C File Offset: 0x0000262C
		private void e()
		{
			int a_ = 4;
			short num;
			try
			{
				num = (short)83847815;
				short num2 = num;
				num = (short)938699399;
				switch (num2 == num)
				{
				}
				num = (short)1738407936;
				if (num != 0)
				{
				}
				this.s = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.d));
				this.s.IsBackground = true;
				this.s.Start();
				this.u.WaitOne(5000, false);
			}
			catch (global::System.TimeoutException ex)
			{
				string text = global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ੂ⭄⹆㵈≊ⱌ⍎㡐⥒㑔⍖じ㑚㍜罞ᅠᅢ੤Ѧ౨ᡪṬ佮ᡰr啴Ͷၸᙺ᡼ၾ", a_);
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ق㵄⑆ⱈ㭊㥌♎㹐㵒潔睖≘歚⁜摞䅠⹢dᑦᩨ੪੬੮䭰卲๴䙶Ѹ", a_), new object[]
				{
					ex,
					text
				});
				global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase.g = true;
			}
			catch (global::System.Exception ex2)
			{
				string text2 = global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ੂ⭄⹆㵈≊ⱌ⍎㡐⥒㑔⍖じ㑚㍜罞ᅠᅢ੤Ѧ౨ᡪṬ佮ᱰᙲŴ坶ᱸͺṼ᩾", a_);
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ق㵄⑆ⱈ㭊㥌♎㹐㵒潔睖≘歚⁜摞䅠⹢dᑦᩨ੪੬੮䭰卲๴䙶Ѹ", a_), new object[]
				{
					ex2,
					text2
				});
				global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase.g = true;
			}
			num = (short)675807233;
			if (num != 0)
			{
			}
			num = (short)1636696064;
			short num3 = num;
		}

		// Token: 0x06000034 RID: 52
		protected abstract void InitDevClassGUIDList();

		// Token: 0x06000035 RID: 53 RVA: 0x000045B8 File Offset: 0x000027B8
		private void d()
		{
			int a_ = 17;
			short num = (short)387922495;
			short num2 = num;
			num = (short)719403583;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_89;
			default:
				num = (short)1173749760;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_89;
				}
				break;
			}
			int num3;
			for (;;)
			{
				IL_5F:
				bool flag;
				switch (num3)
				{
				case 0:
					this.c();
					this.u.Set();
					global::System.Windows.Forms.Application.Run(this.d);
					num = (short)320208901;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					this.InitDevClassGUIDList();
					num = (short)947126275;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_E8;
				case 3:
				{
					num = (short)1349124096;
					short num4 = num;
					goto IL_228;
				}
				case 4:
					if (this.lstValidGuid.Count == 0)
					{
						num = (short)1507065857;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_228;
				case 5:
					return;
				case 6:
				{
					string text = global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ᙏ㍑㵓㩕㵗㹙籛⩝ཟ䉡ᙣͥཧͩὫᩭᕯq味ٵᙷ੹屻፽겋憐ﺑ몙놛뎝趟芡", a_);
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ᕏ⁑♓㥕⩗穙ᅛ㭝፟ᅡգť൧偩䱫ᕭ䁯ཱ", a_), new object[]
					{
						text
					});
					global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase.g = true;
					this.u.Set();
					num = (short)2029060098;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 7:
					if (!flag)
					{
						num = (short)80347142;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E8;
				case 8:
					num = (short)1170407425;
					if (num != 0)
					{
					}
					if (flag)
					{
						num = (short)1879638016;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				goto IL_89;
				IL_E8:
				num = (short)1810890760;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_228:
				global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase.a a_2 = global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase.a.a;
				flag = this.a(a_2);
				num = (short)1598423047;
				num3 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_89:
			this.d = new global::Motorola.Common.Communication.DeviceDiscovery.d(this);
			this.f = this.d.Handle;
			num = (short)1167654916;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_5F;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004834 File Offset: 0x00002A34
		private void c()
		{
			short num = (short)1342243540;
			short num2 = num;
			num = (short)63111892;
			switch (num2 == num)
			{
			}
			num = (short)1377763328;
			short num3 = num;
			num = (short)1146552320;
			if (num != 0)
			{
			}
			num = (short)779681793;
			if (num != 0)
			{
			}
			this.j = new global::System.Collections.ArrayList();
			this.k = new global::System.Collections.ArrayList();
			this._currentExistDevice = new global::System.Collections.ArrayList();
			this.p = new global::System.Threading.AutoResetEvent(false);
			this.t = new global::System.Threading.AutoResetEvent(false);
			this.q = new global::Motorola.Common.Communication.DeviceDiscovery.a(this.f);
			this.q.BeginInvoke(null, null);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00004934 File Offset: 0x00002B34
		private bool a(global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase.a A_0)
		{
			short num = (short)678363136;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				bool result = true;
				global::Motorola.Common.Communication.CommonUtil.NativeMethods.DEV_BROADCAST_DEVICEINTERFACE structure = default(global::Motorola.Common.Communication.CommonUtil.NativeMethods.DEV_BROADCAST_DEVICEINTERFACE);
				int num3 = global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.CommonUtil.NativeMethods.DEV_BROADCAST_DEVICEINTERFACE));
				structure.dbcc_size = (uint)num3;
				structure.dbcc_devicetype = 5U;
				structure.dbcc_classguid = this._radioClass;
				structure.dbcc_reserved = 0U;
				global::System.IntPtr intPtr = global::System.IntPtr.Zero;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_8A;
					}
					for (;;)
					{
						IL_6F:
						switch (num2)
						{
						case 0:
							goto IL_131;
						case 1:
							if (A_0 == global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase.a.a)
							{
								num = (short)1505492996;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							result = this.NativeAPISet.WrapperRegisterDeviceNotification(this.f, intPtr, 1U, ref this.e);
							num = (short)957612035;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_149;
						case 3:
							goto IL_131;
						case 4:
							result = this.NativeAPISet.WrapperRegisterDeviceNotification(this.f, intPtr, 0U, ref this.e);
							num = (short)385482752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8A;
						IL_131:
						num = (short)1606811650;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_149:
					goto IL_21B;
					IL_8A:
					intPtr = global::System.Runtime.InteropServices.Marshal.AllocHGlobal(num3);
					global::System.Runtime.InteropServices.Marshal.StructureToPtr<global::Motorola.Common.Communication.CommonUtil.NativeMethods.DEV_BROADCAST_DEVICEINTERFACE>(structure, intPtr, false);
					num = (short)1041956865;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_6F;
				}
				catch (global::System.Exception)
				{
					result = false;
				}
				finally
				{
					num = (short)393216002;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_218;
						case 1:
						{
							num = (short)1844047702;
							short num4 = num;
							num = (short)2048061270;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_199;
							default:
								num = (short)1511194624;
								if (num != 0)
								{
								}
								global::System.Runtime.InteropServices.Marshal.FreeHGlobal(intPtr);
								num = (short)589234176;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_189;
							}
							continue;
						}
						goto IL_189;
						IL_199:
						num = (short)451280897;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_189:
						if (intPtr != global::System.IntPtr.Zero)
						{
							goto IL_199;
						}
						break;
					}
					IL_218:;
				}
				IL_21B:
				num = (short)1543176193;
				if (num != 0)
				{
				}
				num = (short)1918763008;
				short num5 = num;
				return result;
			}
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00004BCC File Offset: 0x00002DCC
		private bool b()
		{
			short num = (short)1024060650;
			short num2 = num;
			num = (short)2009066730;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1410662400;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_67;
				}
				break;
			}
			int num3;
			bool result;
			for (;;)
			{
				IL_55:
				switch (num3)
				{
				case 0:
					if (this.e != global::System.IntPtr.Zero)
					{
						num = (short)775618561;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 1:
					result = this.NativeAPISet.WrapperUnregisterDeviceNotification(this.e);
					this.e = global::System.IntPtr.Zero;
					num = (short)1030029314;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					return result;
				}
				goto IL_67;
			}
			return result;
			IL_67:
			num = (short)1440743425;
			if (num != 0)
			{
			}
			num = (short)2102919168;
			short num4 = num;
			result = true;
			num = (short)1281949696;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_55;
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004D0C File Offset: 0x00002F0C
		protected static string GetDevCurrentLocationFromDevName(string dbcc_name)
		{
			short num = (short)330104832;
			short num2 = num;
			num = (short)968023878;
			short num3 = num;
			num = (short)100065094;
			switch (num3 == num)
			{
			}
			num = (short)1266089985;
			if (num != 0)
			{
			}
			num = (short)385875968;
			if (num != 0)
			{
			}
			int num4 = dbcc_name.IndexOf('#');
			num4 = dbcc_name.IndexOf('#', num4 + 1);
			int num5 = dbcc_name.IndexOf('#', num4 + 1);
			return dbcc_name.Substring(num4 + 1, num5 - num4 - 1);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00004DE4 File Offset: 0x00002FE4
		protected static string GetPhysicalLocationFromDeviceInstance(string instance_id)
		{
			short num = (short)59965440;
			short num2 = num;
			num = (short)1441208750;
			short num3 = num;
			num = (short)563550638;
			switch (num3 == num)
			{
			}
			num = (short)66781185;
			if (num != 0)
			{
			}
			num = (short)749076480;
			if (num != 0)
			{
			}
			int num4 = instance_id.IndexOf('\\');
			num4 = instance_id.IndexOf('\\', num4 + 1);
			return instance_id.Substring(num4 + 1);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00004EAC File Offset: 0x000030AC
		private void a(out global::System.Collections.ArrayList A_0)
		{
			short num = (short)336986112;
			short num2 = num;
			num = (short)321598129;
			short num3 = num;
			num = (short)442118833;
			switch (num3 == num)
			{
			}
			num = (short)294060032;
			if (num != 0)
			{
			}
			num = (short)1840119809;
			if (num != 0)
			{
			}
			A_0 = new global::System.Collections.ArrayList();
			this.a(A_0, this._radioClass);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00004F6C File Offset: 0x0000316C
		private void a(global::System.Collections.ArrayList A_0, global::System.Guid A_1)
		{
			int a_ = 12;
			short num = (short)888012800;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_8C;
				}
				global::System.IntPtr zero;
				global::Motorola.Common.Communication.CommonUtil.NativeMethods.SP_DEVICE_INTERFACE_DATA sp_DEVICE_INTERFACE_DATA;
				global::Motorola.Common.Communication.CommonUtil.NativeMethods.SP_DEVINFO_DATA devInfoData;
				string text;
				string text3;
				string str;
				bool flag;
				for (;;)
				{
					IL_31:
					int num6;
					switch (num2)
					{
					case 0:
					{
						uint num3;
						int num4;
						if (this.NativeAPISet.WrapperSetupDiGetDeviceInterfaceDetail(zero, ref sp_DEVICE_INTERFACE_DATA, global::System.IntPtr.Zero, 0U, out num3, ref devInfoData, out num4))
						{
							num = (short)1558577157;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_286;
					}
					case 1:
						goto IL_286;
					case 2:
					{
						text = text.Replace('\\', '#');
						string text2 = text3;
						text2 += text;
						text2 += str;
						A_0.Add(new global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg
						{
							sDeviceName = text2,
							m_DeviceAction = global::Motorola.Common.Communication.DeviceDiscovery.DevPnPAction.DeviceAttached,
							isPreAttached = true
						});
						num = (short)1766326273;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						flag = false;
						num = (short)1995440136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (this.a(A_1))
						{
							num = (short)1934295042;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_286;
					case 5:
					{
						num = (short)619304036;
						short num5 = num;
						num = (short)443274340;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_11C;
						default:
							num = (short)1452933120;
							if (num != 0)
							{
							}
							num = (short)1652031506;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						goto IL_398;
					case 7:
						num = (short)2045706244;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (zero != global::System.IntPtr.Zero)
						{
							num = (short)45285387;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24A;
					case 9:
						goto IL_34B;
					case 10:
						if (!this.NativeAPISet.WrapperSetupDiGetClassDevs(ref zero, ref A_1, global::System.IntPtr.Zero))
						{
							goto IL_11C;
						}
						goto IL_24A;
					case 11:
						this.NativeAPISet.WrapperSetupDiDestroyDeviceInfoList(zero);
						num = (short)940834817;
						if (num != 0)
						{
						}
						num = (short)759627788;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_24A;
					case 13:
						num6 = 0;
						num = (short)274333705;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						devInfoData.cbSize = (uint)global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.CommonUtil.NativeMethods.SP_DEVINFO_DATA));
						sp_DEVICE_INTERFACE_DATA.cbSize = (uint)global::System.Runtime.InteropServices.Marshal.SizeOf(typeof(global::Motorola.Common.Communication.CommonUtil.NativeMethods.SP_DEVICE_INTERFACE_DATA));
						num = (short)422838278;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_34B;
					case 16:
						if (flag)
						{
							num = (short)189726734;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_398;
					case 17:
						goto IL_393;
					case 18:
						if (this.NativeAPISet.WrapperSetupDiGetDeviceInstanceId(zero, devInfoData, ref text, 1024))
						{
							num = (short)116391943;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_286;
					case 19:
					{
						if (!this.NativeAPISet.WrapperSetupDiEnumDeviceInterfaces(zero, (uint)num6, ref sp_DEVICE_INTERFACE_DATA, ref A_1))
						{
							num = (short)657457169;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num4 = 0;
						uint num3 = 0U;
						num = (short)647692288;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						if (flag)
						{
							num = (short)1987641357;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4F4;
					}
					goto IL_8C;
					IL_11C:
					num = (short)1417609216;
					short num7 = num;
					num = (short)1714683907;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_24A:
					num = (short)1833173008;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_286:
					num6++;
					num = (short)385286159;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_34B:
					num = (short)1296367635;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_398:
					num = (short)1632239636;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_393:
				IL_4F4:
				this.NativeAPISet.WrapperSetupDiDestroyDeviceInfoList(zero);
				return;
				IL_8C:
				flag = true;
				zero = global::System.IntPtr.Zero;
				devInfoData = default(global::Motorola.Common.Communication.CommonUtil.NativeMethods.SP_DEVINFO_DATA);
				sp_DEVICE_INTERFACE_DATA = default(global::Motorola.Common.Communication.CommonUtil.NativeMethods.SP_DEVICE_INTERFACE_DATA);
				text = "";
				text3 = global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("ᝊᅌ灎൐", a_);
				str = global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("桊㙌", a_) + A_1.ToString() + global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("㙊", a_);
				num = (short)557318154;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000547C File Offset: 0x0000367C
		protected virtual bool ExtractRadioInformation(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg orgPnPMsg, ref global::Motorola.Common.Communication.IRadioProfile radioInfo)
		{
			short num = (short)1807351809;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_5D;
				case 1:
					goto IL_15;
				case 2:
					num = (short)202899459;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					if (orgPnPMsg.radioProfile == null)
					{
						return false;
					}
					num = (short)289715916;
					short num3 = num;
					num = (short)601011916;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15;
					default:
						num = (short)45350912;
						if (num != 0)
						{
						}
						num = (short)1816264708;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					goto IL_118;
				case 5:
					if (orgPnPMsg.isSimulated)
					{
						num = (short)791019522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_184;
				}
				goto IL_3D;
				IL_15:
				switch (0)
				{
				case 0:
					IL_3D:
					if (orgPnPMsg.isVolume)
					{
						num = (short)1349517312;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1724841989;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_5D:
			num = (short)143523840;
			short num4 = num;
			return false;
			IL_118:
			num = (short)1521090561;
			if (num != 0)
			{
			}
			radioInfo = orgPnPMsg.radioProfile;
			return true;
			IL_184:
			return this.ExtractRadioInformationHelper(orgPnPMsg, ref radioInfo);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00005618 File Offset: 0x00003818
		public virtual bool DeviceChanged(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg pnpMsg)
		{
			short num = (short)905296888;
			short num2 = num;
			num = (short)1121041400;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_12A;
			case 1:
				break;
			default:
			{
				num = (short)943718400;
				short num3 = num;
				break;
			}
			}
			num = (short)822804481;
			if (num != 0)
			{
			}
			num = (short)1505886208;
			if (num != 0)
			{
			}
			object syncRoot = this.j.SyncRoot;
			bool flag = false;
			try
			{
				global::System.Threading.Monitor.Enter(syncRoot, ref flag);
				this.j.Add(pnpMsg);
			}
			finally
			{
				num = (short)905773056;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_F3;
						}
						continue;
					case 1:
						global::System.Threading.Monitor.Exit(syncRoot);
						num = (short)1052770306;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_127;
					}
					IL_F3:
					if (!flag)
					{
						break;
					}
					num = (short)753270785;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_127:;
			}
			IL_12A:
			this.p.Set();
			return true;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000576C File Offset: 0x0000396C
		private bool a(global::System.Guid A_0)
		{
			short num = (short)1088206106;
			short num2 = num;
			num = (short)1548072218;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)218955776;
				short num3 = num;
				num = (short)1910964225;
				if (num != 0)
				{
				}
				num = (short)776929280;
				if (num != 0)
				{
				}
				if (this.lstValidGuid.Contains(A_0))
				{
					return true;
				}
				break;
			}
			}
			return false;
		}

		// Token: 0x06000040 RID: 64 RVA: 0x0000582C File Offset: 0x00003A2C
		public void Dispose()
		{
			short num = (short)308543488;
			short num2 = num;
			num = (short)1168179201;
			if (num != 0)
			{
			}
			num = (short)1143246588;
			short num3 = num;
			num = (short)1176014588;
			switch (num3 == num)
			{
			}
			num = (short)444661760;
			if (num != 0)
			{
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000058E0 File Offset: 0x00003AE0
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)61973499;
			short num2 = num;
			num = (short)1281139707;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_5D:
				switch (0)
				{
				case 0:
					goto IL_79;
				}
				break;
			default:
				num = (short)1167196160;
				if (num != 0)
				{
				}
				num = (short)1258356736;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			IL_67:
			switch (num3)
			{
			case 0:
				goto IL_5D;
			case 1:
				return;
			case 2:
				try
				{
					num = (short)120913924;
					num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							if (this.p != null)
							{
								num = (short)1893335052;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2B2;
						case 1:
							num = (short)1253638144;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_2B2;
						case 3:
							goto IL_238;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_125;
							}
							continue;
						case 5:
							if (this.t != null)
							{
								num = (short)1760821255;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_276;
						case 6:
							this.u.Close();
							this.u = null;
							num = (short)553975811;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							this.t.Close();
							this.t = null;
							num = (short)951517193;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_306;
						case 9:
							goto IL_276;
						case 10:
							goto IL_2EF;
						case 11:
							this.a();
							this.d = null;
							num = (short)2018181130;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							this.p.Close();
							this.p = null;
							num = (short)35258370;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							if (this.d != null)
							{
								num = (short)1937440779;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2EF;
						case 14:
							if (this.u != null)
							{
								num = (short)826802182;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_238;
						}
						IL_125:
						if (disposing)
						{
							num = (short)275906561;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2EF;
						IL_238:
						num = (short)72679437;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_276:
						num = (short)1103953934;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_2B2:
						num = (short)1134034949;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_2EF:
						num = (short)1643970568;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_306:
					goto IL_32F;
				}
				finally
				{
					this.h = true;
				}
				goto IL_310;
				IL_32F:
				num = (short)1873870849;
				if (num != 0)
				{
				}
				return;
			}
			IL_79:
			num = (short)108462080;
			short num4 = num;
			if (this.h)
			{
				num = (short)595329025;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_67;
			}
			IL_310:
			num = (short)1338441730;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_67;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00005C60 File Offset: 0x00003E60
		private void a()
		{
			short num = (short)1327291630;
			short num2 = num;
			num = (short)1481825518;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1984954368;
				short num3 = num;
				num = (short)391249920;
				if (num != 0)
				{
				}
				if (this.d.InvokeRequired)
				{
					num = (short)1510866945;
					if (num != 0)
					{
					}
					global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase.b method = new global::Motorola.Common.Communication.DeviceDiscovery.PnPDeviceDetectorBase.b(this.a);
					this.d.BeginInvoke(method);
					return;
				}
				break;
			}
			}
			this.d.Close();
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000043 RID: 67
		// (remove) Token: 0x06000044 RID: 68
		public abstract event global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceAttached;

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000045 RID: 69
		// (remove) Token: 0x06000046 RID: 70
		public abstract event global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceDetached;

		// Token: 0x0400000A RID: 10
		private global::System.Collections.Generic.List<string> a = new global::System.Collections.Generic.List<string>();

		// Token: 0x0400000B RID: 11
		private global::Motorola.Common.Communication.DeviceDiscovery.DeviceDetectorType b;

		// Token: 0x0400000C RID: 12
		private global::Motorola.Common.Communication.CommonUtil.WinAPIWrapper c = new global::Motorola.Common.Communication.CommonUtil.WinAPIWrapper();

		// Token: 0x0400000D RID: 13
		private global::Motorola.Common.Communication.DeviceDiscovery.d d;

		// Token: 0x0400000E RID: 14
		private global::System.IntPtr e;

		// Token: 0x0400000F RID: 15
		private global::System.IntPtr f;

		// Token: 0x04000010 RID: 16
		private static bool g;

		// Token: 0x04000011 RID: 17
		private bool h;

		// Token: 0x04000012 RID: 18
		private global::System.Collections.ArrayList i;

		// Token: 0x04000013 RID: 19
		private global::System.Collections.ArrayList j;

		// Token: 0x04000014 RID: 20
		private global::System.Collections.ArrayList k;

		// Token: 0x04000015 RID: 21
		private global::System.Collections.ArrayList l;

		// Token: 0x04000016 RID: 22
		private global::System.Collections.Generic.List<global::System.Guid> m = new global::System.Collections.Generic.List<global::System.Guid>();

		// Token: 0x04000017 RID: 23
		private global::System.Guid n;

		// Token: 0x04000018 RID: 24
		private global::System.Guid o;

		// Token: 0x04000019 RID: 25
		private global::System.Threading.AutoResetEvent p;

		// Token: 0x0400001A RID: 26
		private global::Motorola.Common.Communication.DeviceDiscovery.a q;

		// Token: 0x0400001B RID: 27
		private bool r;

		// Token: 0x0400001C RID: 28
		private global::System.Threading.Thread s;

		// Token: 0x0400001D RID: 29
		private global::System.Threading.AutoResetEvent t;

		// Token: 0x0400001E RID: 30
		private global::System.Threading.AutoResetEvent u = new global::System.Threading.AutoResetEvent(false);

		// Token: 0x0200000C RID: 12
		private enum a
		{
			// Token: 0x04000020 RID: 32
			a,
			// Token: 0x04000021 RID: 33
			b
		}

		// Token: 0x0200000D RID: 13
		// (Invoke) Token: 0x06000050 RID: 80
		private delegate void b();
	}
}
