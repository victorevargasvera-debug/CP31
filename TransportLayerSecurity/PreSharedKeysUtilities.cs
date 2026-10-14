using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.TLS.TlsPskForAstro;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.TLS
{
	// Token: 0x0200000F RID: 15
	internal static class PreSharedKeysUtilities
	{
		// Token: 0x06000041 RID: 65 RVA: 0x00004710 File Offset: 0x00002910
		public static byte[] GetDerivedKey(string keyId, string deviceId, ref global::System.Collections.Generic.List<global::Motorola.Common.Communication.TLS.AuthenticationMaterials> authMats)
		{
			short num = (short)1760602593;
			short num2 = num;
			num = (short)409643489;
			switch (num2 == num)
			{
			}
			num = (short)1880358912;
			short num3 = num;
			num = (short)264503297;
			if (num != 0)
			{
			}
			num = (short)250347520;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.TLS.PreSharedKeysUtilities.a(global::Motorola.Common.Communication.TLS.PreSharedKeysUtilities.a(keyId, ref authMats), deviceId, 16);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000047C4 File Offset: 0x000029C4
		private static byte[] a(string A_0, ref global::System.Collections.Generic.List<global::Motorola.Common.Communication.TLS.AuthenticationMaterials> A_1)
		{
			int a_ = 14;
			short num = (short)1587117396;
			short num2 = num;
			num = (short)1684438356;
			global::Motorola.Common.Communication.TLS.AuthenticationMaterials authenticationMaterials;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2115633152;
				short num3 = num;
				num = (short)1969160193;
				if (num != 0)
				{
				}
				num = (short)2124414976;
				if (num != 0)
				{
				}
				byte[] keyAlias = global::System.Text.Encoding.UTF8.GetBytes(A_0);
				authenticationMaterials = A_1.FirstOrDefault(delegate(global::Motorola.Common.Communication.TLS.AuthenticationMaterials mat)
				{
					short num4 = (short)2144534528;
					int num5 = (int)((global::System.IntPtr)num4);
					for (;;)
					{
						switch (num5)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_34;
							}
							continue;
						case 1:
							num4 = (short)894369794;
							num5 = (int)((global::System.IntPtr)num4);
							continue;
						case 2:
							num4 = (short)1702035457;
							if (num4 != 0)
							{
							}
							if (mat.PSK_ID.Length == keyAlias.Length)
							{
								num4 = (short)1958412291;
								num5 = (int)((global::System.IntPtr)num4);
								continue;
							}
							return false;
						case 3:
							goto IL_11B;
						}
						IL_34:
						if (mat.CERTTYPE != global::Motorola.Common.Communication.CommonUtil.AuthenticationType.PreSharedKey)
						{
							return false;
						}
						num4 = (short)2000151484;
						short num6 = num4;
						num4 = (short)873391036;
						switch ((num6 == num4) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_11B;
						default:
							num4 = (short)1708392448;
							if (num4 != 0)
							{
							}
							num4 = (short)1688993793;
							num5 = (int)((global::System.IntPtr)num4);
							break;
						}
					}
					IL_11B:
					num4 = (short)1508442112;
					short num7 = num4;
					return mat.PSK_ID.SequenceEqual(keyAlias);
				});
				if (authenticationMaterials == null)
				{
					global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient.b("樸帺帼䨾㍀⩂ㅄ㹆獈歊ᵌᱎᩐ獒㍔㡖⭘筚㩜㙞ᝠ٢୤䝦ࡨݪѬ๮ɰ卲ᱴѶ奸ᙺᑼ౾", a_), global::System.Array.Empty<object>());
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_PreShared_Key_Missing);
				}
				break;
			}
			}
			byte[] array = new byte[authenticationMaterials.PSK_VALUE.Length];
			authenticationMaterials.PSK_VALUE.CopyTo(array, 0);
			return array;
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000048E8 File Offset: 0x00002AE8
		private static byte[] a(byte[] A_0, string A_1, int A_2)
		{
			short num = (short)1575288833;
			if (num != 0)
			{
			}
			num = (short)2141388800;
			short num2 = num;
			num = (short)1122555584;
			short num3 = num;
			num = (short)1122883264;
			byte[] result;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)690487296;
				if (num != 0)
				{
				}
				global::System.Security.Cryptography.HMACSHA256 hmacsha = new global::System.Security.Cryptography.HMACSHA256(A_0);
				try
				{
					byte[] array = hmacsha.ComputeHash(global::System.Text.Encoding.ASCII.GetBytes(A_1));
					global::System.Array.Resize<byte>(ref array, A_2);
					result = array;
				}
				finally
				{
					num = (short)240648192;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_F0;
							}
							continue;
						case 1:
							((global::System.IDisposable)hmacsha).Dispose();
							num = (short)1958281218;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_125;
						}
						IL_F0:
						if (hmacsha == null)
						{
							break;
						}
						num = (short)1977548801;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_125:;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x0400001E RID: 30
		private const int a = 16;
	}
}
