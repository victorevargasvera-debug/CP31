using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.TLS.TlsPskForAstro.Interfaces;
using Org.BouncyCastle.Crypto.Tls;

namespace Motorola.Common.Communication.TLS.TlsPskForAstro
{
	// Token: 0x02000028 RID: 40
	public class TlsPskClient : global::Org.BouncyCastle.Crypto.Tls.PskTlsClient, global::Motorola.Common.Communication.TLS.TlsPskForAstro.Interfaces.IOnServerKeyExchangeSubscriber
	{
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0000C400 File Offset: 0x0000A600
		public override global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion ClientVersion
		{
			get
			{
				short num = (short)2040707725;
				short num2 = num;
				num = (short)1501084301;
				switch (num2 == num)
				{
				default:
				{
					num = (short)266207232;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)630390785;
				if (num != 0)
				{
				}
				num = (short)897253376;
				if (num != 0)
				{
				}
				return global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion.TLSv12;
			}
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000C4B4 File Offset: 0x0000A6B4
		public override int[] GetCipherSuites()
		{
			short num = (short)2074411009;
			if (num != 0)
			{
			}
			num = (short)1244659712;
			short num2 = num;
			num = (short)2092824268;
			short num3 = num;
			num = (short)1855387340;
			switch (num3 == num)
			{
			}
			num = (short)1508114432;
			if (num != 0)
			{
			}
			return new int[]
			{
				141
			};
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060000DE RID: 222 RVA: 0x0000C56C File Offset: 0x0000A76C
		// (remove) Token: 0x060000DF RID: 223 RVA: 0x0000C6A4 File Offset: 0x0000A8A4
		public event global::System.EventHandler OnHintReceived
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
				global::System.EventHandler eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						global::System.EventHandler eventHandler2;
						if (eventHandler == eventHandler2)
						{
							num2 = (short)392167425;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_39;
					}
					case 1:
						return;
					case 2:
						goto IL_39;
					}
					goto IL_1C;
					for (;;)
					{
						IL_39:
						global::System.EventHandler eventHandler2 = eventHandler;
						global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Combine(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.a, value2, eventHandler2);
						num2 = (short)1379205120;
						short num3 = num2;
						num2 = (short)1949271423;
						short num4 = num2;
						num2 = (short)682722687;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_B8;
						}
					}
					IL_B8:
					num2 = (short)1649147905;
					if (num2 != 0)
					{
					}
					num2 = (short)2132803584;
					if (num2 != 0)
					{
					}
					num2 = (short)2105737216;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				eventHandler = this.a;
				num2 = (short)665255938;
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
				global::System.EventHandler eventHandler;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						global::System.EventHandler eventHandler2;
						if (eventHandler == eventHandler2)
						{
							num2 = (short)240844801;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_3A;
					}
					case 1:
						return;
					case 2:
						goto IL_3A;
					}
					goto IL_1C;
					for (;;)
					{
						IL_3A:
						global::System.EventHandler eventHandler2 = eventHandler;
						global::System.EventHandler value2 = (global::System.EventHandler)global::System.Delegate.Remove(eventHandler2, value);
						eventHandler = global::System.Threading.Interlocked.CompareExchange<global::System.EventHandler>(ref this.a, value2, eventHandler2);
						num2 = (short)1240334336;
						short num3 = num2;
						num2 = (short)897803165;
						short num4 = num2;
						num2 = (short)271082397;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_B4;
						}
					}
					IL_B4:
					num2 = (short)2073100288;
					if (num2 != 0)
					{
					}
					num2 = (short)1943535617;
					if (num2 != 0)
					{
					}
					num2 = (short)309592064;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_1C:
				eventHandler = this.a;
				num2 = (short)50724866;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000C7DC File Offset: 0x0000A9DC
		public TlsPskClient() : base(null)
		{
			this.IsHintReceivingOnly = true;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000C7F8 File Offset: 0x0000A9F8
		public TlsPskClient(global::Org.BouncyCastle.Crypto.Tls.TlsPskIdentity identity) : base(identity)
		{
			this.IsHintReceivingOnly = false;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x0000C814 File Offset: 0x0000AA14
		protected override global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange CreatePskKeyExchange(int keyExchange)
		{
			if (!this.IsHintReceivingOnly)
			{
				short num = (short)885027176;
				short num2 = num;
				num = (short)1101754728;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1844641793;
					if (num != 0)
					{
					}
					num = (short)19922944;
					short num3 = num;
					num = (short)1501167616;
					if (num != 0)
					{
					}
					break;
				}
				}
				return base.CreatePskKeyExchange(keyExchange);
			}
			return this.CreatePskKeyExchangeForReveivingHintOnly(keyExchange);
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x0000C8DC File Offset: 0x0000AADC
		protected global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange CreatePskKeyExchangeForReveivingHintOnly(int keyExchange)
		{
			short num = (short)126437881;
			short num2 = num;
			num = (short)333072889;
			switch (num2 == num)
			{
			default:
			{
				num = (short)639369216;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)38535168;
			if (num != 0)
			{
			}
			num = (short)1275920385;
			if (num != 0)
			{
			}
			return new global::Motorola.Common.Communication.TLS.TlsPskForAstro.HintOnlyTlsPskKeyExchange(keyExchange, this.mSupportedSignatureAlgorithms, this, null, null, this.mNamedCurves, this.mClientECPointFormats, this.mServerECPointFormats);
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000C9A8 File Offset: 0x0000ABA8
		public void OnServerKeyExchangeMessage(byte[] hintBytes)
		{
			short num = (short)1095645920;
			short num2 = num;
			num = (short)1365785312;
			switch (num2 == num)
			{
			default:
			{
				num = (short)809435136;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1500577793;
			if (num != 0)
			{
			}
			num = (short)1749024768;
			if (num != 0)
			{
			}
			this.ReveivedIdentityHint = hintBytes;
			global::System.EventHandler eventHandler = this.a;
			if (eventHandler == null)
			{
				return;
			}
			eventHandler(this, null);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000CA70 File Offset: 0x0000AC70
		public byte[] GetIdentityHint()
		{
			int a_ = 12;
			short num = (short)928579585;
			if (num != 0)
			{
			}
			if (!this.IsHintReceivingOnly)
			{
				num = (short)1372644631;
				short num2 = num;
				num = (short)945087767;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)956694528;
					short num3 = num;
					num = (short)740032512;
					if (num != 0)
					{
					}
					break;
				}
				}
				global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient.b("砶嬸伺尼嘾⽀⩂⭄⁆楈≊⥌⩎㽐❒㱔⍖⁘筚㕜㙞འᝢ䕤ŦࡨɪŬᩮͰᙲᅴ", a_), global::System.Array.Empty<object>());
				throw new global::System.InvalidOperationException();
			}
			return this.ReveivedIdentityHint;
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000CB58 File Offset: 0x0000AD58
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1576080998 + A_1) + (global::System.IntPtr)66 + (global::System.IntPtr)84 + (global::System.IntPtr)46);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_5C;
			}
			IL_29:
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
			IL_5C:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_29;
		}

		// Token: 0x04000058 RID: 88
		protected bool IsHintReceivingOnly;

		// Token: 0x04000059 RID: 89
		protected byte[] ReveivedIdentityHint;

		// Token: 0x0400005A RID: 90
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.EventHandler a;
	}
}
