using System;
using System.Security.Cryptography;
using AcpUtility;

namespace AcpCryptoLib
{
	// Token: 0x0200001C RID: 28
	public class RsaEncryptionUtil
	{
		// Token: 0x06000070 RID: 112 RVA: 0x0000BB4C File Offset: 0x00009D4C
		static RsaEncryptionUtil()
		{
			short num = (short)2084540849;
			short num2 = num;
			num = (short)157782449;
			switch (num2 == num)
			{
			}
			num = (short)177602561;
			if (num != 0)
			{
			}
			num = (short)1026686976;
			if (num != 0)
			{
			}
			num = (short)1237254144;
			short num3 = num;
			global::AcpUtility.AssemblyValidator.IsCallerAuthorized();
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000BBFC File Offset: 0x00009DFC
		public static string GetPublicKeyFromContainer(string keyContainerName, bool bCreateContainerIfNotExists)
		{
			int a_ = 3;
			string result;
			short num;
			try
			{
				global::System.Security.Cryptography.CspParameters cspParameters = new global::System.Security.Cryptography.CspParameters();
				cspParameters.Flags |= global::System.Security.Cryptography.CspProviderFlags.UseExistingKey;
				cspParameters.KeyContainerName = keyContainerName;
				global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider = new global::System.Security.Cryptography.RSACryptoServiceProvider(cspParameters);
				try
				{
					result = rsacryptoServiceProvider.ToXmlString(false);
				}
				finally
				{
					num = (short)1047986177;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_9F;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_6A;
							}
							continue;
						case 2:
							((global::System.IDisposable)rsacryptoServiceProvider).Dispose();
							num = (short)824573952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_6A:
						if (rsacryptoServiceProvider != null)
						{
							num = (short)759103490;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_9F:
						num = (short)504124849;
						short num3 = num;
						num = (short)1057904049;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6A;
						default:
							goto IL_D3;
						}
					}
					IL_D3:
					num = (short)1984299008;
					if (num != 0)
					{
					}
				}
			}
			catch (global::System.Exception ex)
			{
				if (!bCreateContainerIfNotExists)
				{
					throw new global::System.Exception(global::AcpCryptoLib.XmlEncryptionUtil.b("䜁瘃琅朇砉Ⰻ簍甏昑易缕紗氙甛瀝䜟ȡ吣匥䨧䘩䔫䴭ု怱朳眵ᠷ儹夻䜽怿⑁㙃⥅╇橉❋⭍⥏牑㝓㥕㙗⹙㵛㝝๟ݡᙣ䙥䕧䩩", a_) + keyContainerName + global::AcpCryptoLib.XmlEncryptionUtil.b("∁㸃★", a_) + ex.Message);
				}
				global::AcpCryptoLib.RsaEncryptionUtil.b(keyContainerName);
				result = global::AcpCryptoLib.RsaEncryptionUtil.GetPublicKeyFromContainer(keyContainerName, false);
			}
			num = (short)914751488;
			short num4 = num;
			num = (short)417792001;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000BDA4 File Offset: 0x00009FA4
		private static string a(string A_0, bool A_1)
		{
			int a_ = 12;
			string result;
			short num;
			try
			{
				global::System.Security.Cryptography.CspParameters cspParameters = new global::System.Security.Cryptography.CspParameters();
				cspParameters.Flags |= global::System.Security.Cryptography.CspProviderFlags.UseExistingKey;
				cspParameters.KeyContainerName = A_0;
				global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider = new global::System.Security.Cryptography.RSACryptoServiceProvider(cspParameters);
				try
				{
					result = rsacryptoServiceProvider.ToXmlString(true);
				}
				finally
				{
					num = (short)1639776257;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_9E;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_68;
							}
							continue;
						case 2:
							((global::System.IDisposable)rsacryptoServiceProvider).Dispose();
							num = (short)1386807296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_68:
						if (rsacryptoServiceProvider != null)
						{
							num = (short)1729232898;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_9E:
						num = (short)380493233;
						short num3 = num;
						num = (short)480173489;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_68;
						default:
							goto IL_D4;
						}
					}
					IL_D4:
					num = (short)1447362560;
					if (num != 0)
					{
					}
				}
			}
			catch (global::System.Exception ex)
			{
				if (!A_1)
				{
					throw new global::System.Exception(global::AcpCryptoLib.XmlEncryptionUtil.b("上缌紎縐愒㔔攖簘漚漜瘞䐠唢䰤䤦丨ପ缬簮瀰ጲ帴制䀸ᬺ嬼䴾⹀⹂敄ⱆⱈ㉊浌ⱎ㹐㵒⅔㙖じ㕚㡜ⵞ䅠乢䕤", a_) + A_0 + global::AcpCryptoLib.XmlEncryptionUtil.b("⬊㜌⼎", a_) + ex.Message);
				}
				num = (short)639762433;
				if (num != 0)
				{
				}
				global::AcpCryptoLib.RsaEncryptionUtil.b(A_0);
				result = global::AcpCryptoLib.RsaEncryptionUtil.GetPublicKeyFromContainer(A_0, false);
			}
			num = (short)1315700736;
			short num4 = num;
			return result;
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000BF50 File Offset: 0x0000A150
		private static void b(string A_0)
		{
			int a_ = 9;
			short num = (short)1184235521;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					try
					{
						global::System.Security.Cryptography.CspParameters cspParameters = new global::System.Security.Cryptography.CspParameters();
						cspParameters.Flags |= global::System.Security.Cryptography.CspProviderFlags.UseNonExportableKey;
						cspParameters.KeyContainerName = A_0;
						new global::System.Security.Cryptography.RSACryptoServiceProvider(cspParameters);
						goto IL_152;
					}
					catch (global::System.Exception ex)
					{
						throw new global::System.Exception(global::AcpCryptoLib.XmlEncryptionUtil.b("䴇砉縋愍戏㈑眓搕紗笙栛眝丟䔡У琥笧欩ఫ䔭唯䬱ᐳ唵圷吹䠻弽⤿ⱁ⅃㑅桇杉汋", a_) + A_0 + global::AcpCryptoLib.XmlEncryptionUtil.b("⠇〉Ⰻ", a_) + ex.Message);
					}
					goto IL_D5;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				case 2:
				{
					num = (short)738394113;
					if (num != 0)
					{
					}
					num = (short)1210766424;
					short num3 = num;
					num = (short)2124207192;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D6;
					default:
						goto IL_128;
					}
					break;
				}
				}
				IL_3A:
				if (string.IsNullOrEmpty(A_0))
				{
					num = (short)1699348482;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_D6:
				num = (short)1239089152;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_D5:
				goto IL_D6;
			}
			IL_128:
			num = (short)64225280;
			if (num != 0)
			{
			}
			throw new global::System.ArgumentNullException(global::AcpCryptoLib.XmlEncryptionUtil.b("指漉甋䴍缏簑怓眕焗琙礛氝渟䌡䤣䌥", a_));
			IL_152:
			num = (short)1561067520;
			short num4 = num;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000C0E8 File Offset: 0x0000A2E8
		private static void a(string A_0)
		{
			int a_ = 1;
			short num = (short)1930428417;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					try
					{
						global::System.Security.Cryptography.RSACryptoServiceProvider rsacryptoServiceProvider = new global::System.Security.Cryptography.RSACryptoServiceProvider(new global::System.Security.Cryptography.CspParameters
						{
							KeyContainerName = A_0
						});
						try
						{
							rsacryptoServiceProvider.PersistKeyInCsp = false;
							rsacryptoServiceProvider.Clear();
						}
						finally
						{
							num = (short)574160897;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_111;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_DC;
									}
									continue;
								case 2:
									((global::System.IDisposable)rsacryptoServiceProvider).Dispose();
									num = (short)174522368;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_DC:
								if (rsacryptoServiceProvider != null)
								{
									num = (short)1380581378;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_111:
								num = (short)166737247;
								short num3 = num;
								num = (short)789132639;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_DC;
								default:
									goto IL_145;
								}
							}
							IL_145:
							num = (short)623640576;
							if (num != 0)
							{
							}
						}
						return;
					}
					catch (global::System.Exception ex)
					{
						throw new global::System.Exception(global::AcpCryptoLib.XmlEncryptionUtil.b("䗿瀁瘃椅稇⨉栋欍簏眑怓缕瘗紙㰛䰝猟挡У䴥䴧匩ఫ䴭弯就䀳圵儷吹夻䰽怿潁摃", a_) + A_0 + global::AcpCryptoLib.XmlEncryptionUtil.b("⃿㠁␃", a_) + ex.Message);
					}
					goto IL_18F;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 2:
					goto IL_81;
				}
				IL_39:
				num = (short)1167851521;
				if (num != 0)
				{
				}
				if (string.IsNullOrEmpty(A_0))
				{
					num = (short)931201026;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_18F:
				num = (short)1507655680;
				short num4 = num;
				num = (short)1084096512;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_81:
			throw new global::System.ArgumentNullException(global::AcpCryptoLib.XmlEncryptionUtil.b("毿朁紃䔅朇搉砋漍礏簑焓搕嘗笙焛笝", a_));
		}
	}
}
