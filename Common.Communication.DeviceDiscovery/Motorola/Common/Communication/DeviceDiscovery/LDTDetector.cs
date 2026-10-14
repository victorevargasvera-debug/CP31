using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x02000025 RID: 37
	public class LDTDetector : global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase, global::System.IDisposable
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x0000FCA0 File Offset: 0x0000DEA0
		public LDTDetector()
		{
			this._detectorType = global::Motorola.Common.Communication.DeviceDiscovery.DeviceDetectorType.LTEDetector;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000FCC8 File Offset: 0x0000DEC8
		public override bool Start()
		{
			short num = (short)955656232;
			short num2 = num;
			num = (short)1178544168;
			switch (num2 == num)
			{
			}
			num = (short)1938423809;
			if (num != 0)
			{
			}
			num = (short)1589772288;
			short num3 = num;
			num = (short)1388576768;
			if (num != 0)
			{
			}
			this._isStopping = false;
			this._receiveThread = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.a));
			this._receiveThread.Start();
			return true;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000FD98 File Offset: 0x0000DF98
		public override void Stop()
		{
			short num = (short)240049285;
			short num2 = num;
			num = (short)125492357;
			switch (num2 == num)
			{
			}
			num = (short)1150943233;
			if (num != 0)
			{
			}
			num = (short)1540947968;
			short num3 = num;
			num = (short)1732182016;
			if (num != 0)
			{
			}
			this._isStopping = true;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000FE44 File Offset: 0x0000E044
		private void a()
		{
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_28;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (this._isStopping)
						{
							num2 = (short)529334276;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1036779525;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						return;
					case 2:
						goto IL_1CC;
					case 3:
					{
						try
						{
							num2 = (short)1638400001;
							num = (int)((global::System.IntPtr)num2);
							for (;;)
							{
								switch (num)
								{
								case 0:
									goto IL_176;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_141;
									}
									continue;
								case 2:
									num2 = (short)44564480;
									num = (int)((global::System.IntPtr)num2);
									continue;
								case 3:
									goto IL_1BA;
								}
								IL_141:
								if (this._isStopping)
								{
									num2 = (short)1940717570;
									num = (int)((global::System.IntPtr)num2);
								}
								else
								{
									this.b = new global::System.Net.Sockets.UdpClient(this.a);
									this.b.Client.ReceiveTimeout = 5000;
									num2 = (short)183631875;
									num = (int)((global::System.IntPtr)num2);
								}
							}
							IL_176:
							return;
							IL_1BA:
							goto IL_225;
						}
						catch
						{
							global::System.Threading.Thread.Sleep(1000);
							goto IL_00;
						}
						goto IL_1CC;
						IL_225:
						global::System.Net.IPEndPoint a_ = null;
						num2 = (short)350135177;
						short num3 = num2;
						num2 = (short)1806934921;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1CC;
						default:
							num2 = (short)1345388544;
							if (num2 != 0)
							{
							}
							num2 = (short)1915486210;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 4:
						goto IL_E6;
					case 5:
						try
						{
							global::System.Net.IPEndPoint a_;
							this.a(a_);
							goto IL_1CC;
						}
						catch (global::System.Exception ex)
						{
							global::System.Net.Sockets.SocketException ex2 = ex as global::System.Net.Sockets.SocketException;
							if (ex2 == null || ex2.SocketErrorCode != global::System.Net.Sockets.SocketError.TimedOut)
							{
								global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(ex.Message, global::System.Array.Empty<object>());
							}
							goto IL_1CC;
						}
						finally
						{
							global::System.Threading.Thread.Sleep(1000);
						}
						goto IL_E6;
					}
					break;
					IL_E6:
					this.b.Close();
					num2 = (short)430964737;
					num = (int)((global::System.IntPtr)num2);
					continue;
					IL_1CC:
					num2 = (short)722534400;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_28:
				num2 = (short)810549249;
				if (num2 != 0)
				{
				}
				num2 = (short)917504000;
				short num4 = num2;
				num2 = (short)228196355;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0001010C File Offset: 0x0000E30C
		private void a(global::System.Net.IPEndPoint A_0)
		{
			int a_ = 18;
			switch (0)
			{
			case 0:
				goto IL_55;
			}
			int num;
			short num2;
			byte[] array;
			for (;;)
			{
				IL_13:
				global::Motorola.Common.Communication.DeviceDiscovery.LDTDetector.a a;
				string passwordId;
				switch (num)
				{
				case 0:
					global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.Add(a.a);
					base.b(a.a);
					num2 = (short)1745092614;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)1518206977;
					if (num2 != 0)
					{
					}
					if (this._isStopping)
					{
						num2 = (short)2039611400;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)168755204;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._arrivedDevices.Count(new global::System.Func<global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile, bool>(a.b)) == 0)
					{
						num2 = (short)1459093504;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					passwordId = global::System.Text.Encoding.UTF8.GetString(array).Trim();
					num2 = (short)1406468110;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					if (array == null)
					{
						return;
					}
					num2 = (short)539028980;
					short num3 = num2;
					num2 = (short)866250228;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_34F;
					default:
						num2 = (short)169672704;
						if (num2 != 0)
						{
						}
						num2 = (short)1639317511;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					if (global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._passwords.Count(new global::System.Func<global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo, bool>(a.b)) > 0)
					{
						num2 = (short)1832845321;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(string.Format(global::Motorola.Common.Communication.DeviceDiscovery.UDPRadioProfile.b("Ő㉒♔⑖⹘㑚⽜㭞䅠੢ŤɦݨὪѬ८ᡰᙲݴ坶䕸z䵼ɾ뾀ꎂꦈﾌ붜쒠킢횤삦첨讪쮬\uddae\udeb0\udeb2閴ﺶ膺鶼莾뫀룄阮ꋊꏌ많냐뿒볔돖", a_), a.a.PasswordId, a.a.IPAddress), global::System.Array.Empty<object>());
					num2 = (short)1420361740;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					return;
				case 7:
					num2 = (short)311951370;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					return;
				case 9:
					a.a.Password = global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase._passwords.First(new global::System.Func<global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo, bool>(a.c)).PreSharedKey_Material;
					num2 = (short)395313165;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (array.Length != 0)
					{
						num2 = (short)1119223811;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 11:
					goto IL_34F;
				case 12:
					goto IL_23D;
				case 13:
					goto IL_23D;
				case 14:
					if (array.Length == 10)
					{
						num2 = (short)1212612619;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_55;
				IL_23D:
				num2 = (short)815267842;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_34F:
				num2 = (short)596705280;
				short num4 = num2;
				a = new global::Motorola.Common.Communication.DeviceDiscovery.LDTDetector.a();
				a.a = new global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile();
				a.a.PID = global::Motorola.Common.Communication.DeviceDiscovery.LDTDetectorBase.LTE_REPEATER_PID;
				a.a.IPAddress = A_0.Address.ToString();
				a.a.PasswordId = passwordId;
				a.a.ConnectMode = global::Motorola.Common.Communication.DeviceDiscovery.LDTConnectMode.USB;
				num2 = (short)1393885189;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_55:
			array = this.b.Receive(ref A_0);
			num2 = (short)1235943425;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000104D4 File Offset: 0x0000E6D4
		public void Dispose()
		{
			short num = (short)1235450575;
			short num2 = num;
			num = (short)65305295;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1239220224;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)596115456;
			if (num != 0)
			{
			}
			num = (short)991232001;
			if (num != 0)
			{
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0001058C File Offset: 0x0000E78C
		protected virtual void Dispose(bool disposing)
		{
			short num = (short)36615637;
			short num2 = num;
			num = (short)1013036501;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_9F:
				num = (short)1099890692;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1334312960;
				if (num != 0)
				{
				}
				num = (short)1604255746;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_9F;
				case 1:
				{
					num = (short)1773207552;
					short num4 = num;
					this.b.Close();
					num = (short)646840323;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_84;
					}
					continue;
				case 3:
					return;
				case 4:
					num = (short)271450113;
					if (num != 0)
					{
					}
					if (this.b != null)
					{
						num = (short)784138241;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_84:
				if (!disposing)
				{
					break;
				}
				num = (short)337641472;
				num3 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x04000078 RID: 120
		private int a = 9998;

		// Token: 0x04000079 RID: 121
		private new global::System.Net.Sockets.UdpClient b;

		// Token: 0x02000026 RID: 38
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x060000D0 RID: 208 RVA: 0x00010700 File Offset: 0x0000E900
			internal bool b(global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo A_0)
			{
				while (A_0.AuthType == global::Motorola.Common.Communication.CommonUtil.AuthenticationType.PasswordIndex)
				{
					short num = (short)800915456;
					short num2 = num;
					num = (short)647597793;
					short num3 = num;
					num = (short)2081328865;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1946877953;
						if (num != 0)
						{
						}
						num = (short)17301504;
						if (num != 0)
						{
						}
						return A_0.PreSharedKey_ID == this.a.PasswordId;
					}
				}
				return false;
			}

			// Token: 0x060000D1 RID: 209 RVA: 0x000107D0 File Offset: 0x0000E9D0
			internal bool c(global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo A_0)
			{
				while (A_0.AuthType == global::Motorola.Common.Communication.CommonUtil.AuthenticationType.PasswordIndex)
				{
					short num = (short)705429505;
					if (num != 0)
					{
					}
					num = (short)1580531712;
					short num2 = num;
					num = (short)765501770;
					short num3 = num;
					num = (short)980394314;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1347616768;
						if (num != 0)
						{
						}
						return A_0.PreSharedKey_ID == this.a.PasswordId;
					}
				}
				return false;
			}

			// Token: 0x060000D2 RID: 210 RVA: 0x000108A0 File Offset: 0x0000EAA0
			internal bool b(global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile A_0)
			{
				while (A_0.IPAddress == this.a.IPAddress)
				{
					short num = (short)782303232;
					short num2 = num;
					num = (short)1301504520;
					short num3 = num;
					num = (short)1654743560;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1171324929;
						if (num != 0)
						{
						}
						num = (short)1909456896;
						if (num != 0)
						{
						}
						return string.IsNullOrEmpty(A_0.IMEI);
					}
				}
				return false;
			}

			// Token: 0x0400007A RID: 122
			public global::Motorola.Common.Communication.DeviceDiscovery.LDTRadioProfile a;
		}
	}
}
