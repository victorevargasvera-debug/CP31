using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000370 RID: 880
	public abstract class TlsExtensionsUtilities
	{
		// Token: 0x060023B5 RID: 9141 RVA: 0x0009C55D File Offset: 0x0009A75D
		public static global::System.Collections.IDictionary EnsureExtensionsInitialised(global::System.Collections.IDictionary extensions)
		{
			if (extensions != null)
			{
				return extensions;
			}
			return global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
		}

		// Token: 0x060023B6 RID: 9142 RVA: 0x0009C569 File Offset: 0x0009A769
		public static void AddClientCertificateTypeExtensionClient(global::System.Collections.IDictionary extensions, byte[] certificateTypes)
		{
			extensions[19] = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.CreateCertificateTypeExtensionClient(certificateTypes);
		}

		// Token: 0x060023B7 RID: 9143 RVA: 0x0009C57E File Offset: 0x0009A77E
		public static void AddClientCertificateTypeExtensionServer(global::System.Collections.IDictionary extensions, byte certificateType)
		{
			extensions[19] = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.CreateCertificateTypeExtensionServer(certificateType);
		}

		// Token: 0x060023B8 RID: 9144 RVA: 0x0009C593 File Offset: 0x0009A793
		public static void AddEncryptThenMacExtension(global::System.Collections.IDictionary extensions)
		{
			extensions[22] = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.CreateEncryptThenMacExtension();
		}

		// Token: 0x060023B9 RID: 9145 RVA: 0x0009C5A7 File Offset: 0x0009A7A7
		public static void AddExtendedMasterSecretExtension(global::System.Collections.IDictionary extensions)
		{
			extensions[23] = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.CreateExtendedMasterSecretExtension();
		}

		// Token: 0x060023BA RID: 9146 RVA: 0x0009C5BB File Offset: 0x0009A7BB
		public static void AddHeartbeatExtension(global::System.Collections.IDictionary extensions, global::Org.BouncyCastle.Crypto.Tls.HeartbeatExtension heartbeatExtension)
		{
			extensions[15] = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.CreateHeartbeatExtension(heartbeatExtension);
		}

		// Token: 0x060023BB RID: 9147 RVA: 0x0009C5D0 File Offset: 0x0009A7D0
		public static void AddMaxFragmentLengthExtension(global::System.Collections.IDictionary extensions, byte maxFragmentLength)
		{
			extensions[1] = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.CreateMaxFragmentLengthExtension(maxFragmentLength);
		}

		// Token: 0x060023BC RID: 9148 RVA: 0x0009C5E4 File Offset: 0x0009A7E4
		public static void AddPaddingExtension(global::System.Collections.IDictionary extensions, int dataLength)
		{
			extensions[21] = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.CreatePaddingExtension(dataLength);
		}

		// Token: 0x060023BD RID: 9149 RVA: 0x0009C5F9 File Offset: 0x0009A7F9
		public static void AddServerCertificateTypeExtensionClient(global::System.Collections.IDictionary extensions, byte[] certificateTypes)
		{
			extensions[20] = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.CreateCertificateTypeExtensionClient(certificateTypes);
		}

		// Token: 0x060023BE RID: 9150 RVA: 0x0009C60E File Offset: 0x0009A80E
		public static void AddServerCertificateTypeExtensionServer(global::System.Collections.IDictionary extensions, byte certificateType)
		{
			extensions[20] = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.CreateCertificateTypeExtensionServer(certificateType);
		}

		// Token: 0x060023BF RID: 9151 RVA: 0x0009C623 File Offset: 0x0009A823
		public static void AddServerNameExtension(global::System.Collections.IDictionary extensions, global::Org.BouncyCastle.Crypto.Tls.ServerNameList serverNameList)
		{
			extensions[0] = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.CreateServerNameExtension(serverNameList);
		}

		// Token: 0x060023C0 RID: 9152 RVA: 0x0009C637 File Offset: 0x0009A837
		public static void AddStatusRequestExtension(global::System.Collections.IDictionary extensions, global::Org.BouncyCastle.Crypto.Tls.CertificateStatusRequest statusRequest)
		{
			extensions[5] = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.CreateStatusRequestExtension(statusRequest);
		}

		// Token: 0x060023C1 RID: 9153 RVA: 0x0009C64B File Offset: 0x0009A84B
		public static void AddTruncatedHMacExtension(global::System.Collections.IDictionary extensions)
		{
			extensions[4] = global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.CreateTruncatedHMacExtension();
		}

		// Token: 0x060023C2 RID: 9154 RVA: 0x0009C660 File Offset: 0x0009A860
		public static byte[] GetClientCertificateTypeExtensionClient(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions, 19);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.ReadCertificateTypeExtensionClient(extensionData);
			}
			return null;
		}

		// Token: 0x060023C3 RID: 9155 RVA: 0x0009C684 File Offset: 0x0009A884
		public static short GetClientCertificateTypeExtensionServer(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions, 19);
			if (extensionData != null)
			{
				return (short)global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.ReadCertificateTypeExtensionServer(extensionData);
			}
			return -1;
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x0009C6A8 File Offset: 0x0009A8A8
		public static global::Org.BouncyCastle.Crypto.Tls.HeartbeatExtension GetHeartbeatExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions, 15);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.ReadHeartbeatExtension(extensionData);
			}
			return null;
		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x0009C6CC File Offset: 0x0009A8CC
		public static short GetMaxFragmentLengthExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions, 1);
			if (extensionData != null)
			{
				return (short)global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.ReadMaxFragmentLengthExtension(extensionData);
			}
			return -1;
		}

		// Token: 0x060023C6 RID: 9158 RVA: 0x0009C6EC File Offset: 0x0009A8EC
		public static int GetPaddingExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions, 21);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.ReadPaddingExtension(extensionData);
			}
			return -1;
		}

		// Token: 0x060023C7 RID: 9159 RVA: 0x0009C710 File Offset: 0x0009A910
		public static byte[] GetServerCertificateTypeExtensionClient(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions, 20);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.ReadCertificateTypeExtensionClient(extensionData);
			}
			return null;
		}

		// Token: 0x060023C8 RID: 9160 RVA: 0x0009C734 File Offset: 0x0009A934
		public static short GetServerCertificateTypeExtensionServer(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions, 20);
			if (extensionData != null)
			{
				return (short)global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.ReadCertificateTypeExtensionServer(extensionData);
			}
			return -1;
		}

		// Token: 0x060023C9 RID: 9161 RVA: 0x0009C758 File Offset: 0x0009A958
		public static global::Org.BouncyCastle.Crypto.Tls.ServerNameList GetServerNameExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions, 0);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.ReadServerNameExtension(extensionData);
			}
			return null;
		}

		// Token: 0x060023CA RID: 9162 RVA: 0x0009C778 File Offset: 0x0009A978
		public static global::Org.BouncyCastle.Crypto.Tls.CertificateStatusRequest GetStatusRequestExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions, 5);
			if (extensionData != null)
			{
				return global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.ReadStatusRequestExtension(extensionData);
			}
			return null;
		}

		// Token: 0x060023CB RID: 9163 RVA: 0x0009C798 File Offset: 0x0009A998
		public static bool HasEncryptThenMacExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions, 22);
			return extensionData != null && global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.ReadEncryptThenMacExtension(extensionData);
		}

		// Token: 0x060023CC RID: 9164 RVA: 0x0009C7BC File Offset: 0x0009A9BC
		public static bool HasExtendedMasterSecretExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions, 23);
			return extensionData != null && global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.ReadExtendedMasterSecretExtension(extensionData);
		}

		// Token: 0x060023CD RID: 9165 RVA: 0x0009C7E0 File Offset: 0x0009A9E0
		public static bool HasTruncatedHMacExtension(global::System.Collections.IDictionary extensions)
		{
			byte[] extensionData = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions, 4);
			return extensionData != null && global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.ReadTruncatedHMacExtension(extensionData);
		}

		// Token: 0x060023CE RID: 9166 RVA: 0x0009C800 File Offset: 0x0009AA00
		public static byte[] CreateCertificateTypeExtensionClient(byte[] certificateTypes)
		{
			if (certificateTypes == null || certificateTypes.Length < 1 || certificateTypes.Length > 255)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EncodeUint8ArrayWithUint8Length(certificateTypes);
		}

		// Token: 0x060023CF RID: 9167 RVA: 0x0009C823 File Offset: 0x0009AA23
		public static byte[] CreateCertificateTypeExtensionServer(byte certificateType)
		{
			return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EncodeUint8(certificateType);
		}

		// Token: 0x060023D0 RID: 9168 RVA: 0x0009C82B File Offset: 0x0009AA2B
		public static byte[] CreateEmptyExtensionData()
		{
			return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes;
		}

		// Token: 0x060023D1 RID: 9169 RVA: 0x0009C832 File Offset: 0x0009AA32
		public static byte[] CreateEncryptThenMacExtension()
		{
			return global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.CreateEmptyExtensionData();
		}

		// Token: 0x060023D2 RID: 9170 RVA: 0x0009C839 File Offset: 0x0009AA39
		public static byte[] CreateExtendedMasterSecretExtension()
		{
			return global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.CreateEmptyExtensionData();
		}

		// Token: 0x060023D3 RID: 9171 RVA: 0x0009C840 File Offset: 0x0009AA40
		public static byte[] CreateHeartbeatExtension(global::Org.BouncyCastle.Crypto.Tls.HeartbeatExtension heartbeatExtension)
		{
			if (heartbeatExtension == null)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			heartbeatExtension.Encode(buf);
			return buf.ToArray();
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x0009C86B File Offset: 0x0009AA6B
		public static byte[] CreateMaxFragmentLengthExtension(byte maxFragmentLength)
		{
			return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EncodeUint8(maxFragmentLength);
		}

		// Token: 0x060023D5 RID: 9173 RVA: 0x0009C873 File Offset: 0x0009AA73
		public static byte[] CreatePaddingExtension(int dataLength)
		{
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint16(dataLength);
			return new byte[dataLength];
		}

		// Token: 0x060023D6 RID: 9174 RVA: 0x0009C884 File Offset: 0x0009AA84
		public static byte[] CreateServerNameExtension(global::Org.BouncyCastle.Crypto.Tls.ServerNameList serverNameList)
		{
			if (serverNameList == null)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			serverNameList.Encode(buf);
			return buf.ToArray();
		}

		// Token: 0x060023D7 RID: 9175 RVA: 0x0009C8B0 File Offset: 0x0009AAB0
		public static byte[] CreateStatusRequestExtension(global::Org.BouncyCastle.Crypto.Tls.CertificateStatusRequest statusRequest)
		{
			if (statusRequest == null)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			global::System.IO.MemoryStream buf = new global::System.IO.MemoryStream();
			statusRequest.Encode(buf);
			return buf.ToArray();
		}

		// Token: 0x060023D8 RID: 9176 RVA: 0x0009C8DB File Offset: 0x0009AADB
		public static byte[] CreateTruncatedHMacExtension()
		{
			return global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.CreateEmptyExtensionData();
		}

		// Token: 0x060023D9 RID: 9177 RVA: 0x0009C8E2 File Offset: 0x0009AAE2
		private static bool ReadEmptyExtensionData(byte[] extensionData)
		{
			if (extensionData == null)
			{
				throw new global::System.ArgumentNullException("extensionData");
			}
			if (extensionData.Length != 0)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
			}
			return true;
		}

		// Token: 0x060023DA RID: 9178 RVA: 0x0009C8FF File Offset: 0x0009AAFF
		public static byte[] ReadCertificateTypeExtensionClient(byte[] extensionData)
		{
			byte[] array = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.DecodeUint8ArrayWithUint8Length(extensionData);
			if (array.Length < 1)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(50);
			}
			return array;
		}

		// Token: 0x060023DB RID: 9179 RVA: 0x0009C915 File Offset: 0x0009AB15
		public static byte ReadCertificateTypeExtensionServer(byte[] extensionData)
		{
			return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.DecodeUint8(extensionData);
		}

		// Token: 0x060023DC RID: 9180 RVA: 0x0009C91D File Offset: 0x0009AB1D
		public static bool ReadEncryptThenMacExtension(byte[] extensionData)
		{
			return global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.ReadEmptyExtensionData(extensionData);
		}

		// Token: 0x060023DD RID: 9181 RVA: 0x0009C925 File Offset: 0x0009AB25
		public static bool ReadExtendedMasterSecretExtension(byte[] extensionData)
		{
			return global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.ReadEmptyExtensionData(extensionData);
		}

		// Token: 0x060023DE RID: 9182 RVA: 0x0009C930 File Offset: 0x0009AB30
		public static global::Org.BouncyCastle.Crypto.Tls.HeartbeatExtension ReadHeartbeatExtension(byte[] extensionData)
		{
			if (extensionData == null)
			{
				throw new global::System.ArgumentNullException("extensionData");
			}
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(extensionData, false);
			global::Org.BouncyCastle.Crypto.Tls.HeartbeatExtension heartbeatExtension = global::Org.BouncyCastle.Crypto.Tls.HeartbeatExtension.Parse(memoryStream);
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(memoryStream);
			return heartbeatExtension;
		}

		// Token: 0x060023DF RID: 9183 RVA: 0x0009C95F File Offset: 0x0009AB5F
		public static byte ReadMaxFragmentLengthExtension(byte[] extensionData)
		{
			return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.DecodeUint8(extensionData);
		}

		// Token: 0x060023E0 RID: 9184 RVA: 0x0009C968 File Offset: 0x0009AB68
		public static int ReadPaddingExtension(byte[] extensionData)
		{
			if (extensionData == null)
			{
				throw new global::System.ArgumentNullException("extensionData");
			}
			for (int i = 0; i < extensionData.Length; i++)
			{
				if (extensionData[i] != 0)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(47);
				}
			}
			return extensionData.Length;
		}

		// Token: 0x060023E1 RID: 9185 RVA: 0x0009C9A4 File Offset: 0x0009ABA4
		public static global::Org.BouncyCastle.Crypto.Tls.ServerNameList ReadServerNameExtension(byte[] extensionData)
		{
			if (extensionData == null)
			{
				throw new global::System.ArgumentNullException("extensionData");
			}
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(extensionData, false);
			global::Org.BouncyCastle.Crypto.Tls.ServerNameList serverNameList = global::Org.BouncyCastle.Crypto.Tls.ServerNameList.Parse(memoryStream);
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(memoryStream);
			return serverNameList;
		}

		// Token: 0x060023E2 RID: 9186 RVA: 0x0009C9D4 File Offset: 0x0009ABD4
		public static global::Org.BouncyCastle.Crypto.Tls.CertificateStatusRequest ReadStatusRequestExtension(byte[] extensionData)
		{
			if (extensionData == null)
			{
				throw new global::System.ArgumentNullException("extensionData");
			}
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(extensionData, false);
			global::Org.BouncyCastle.Crypto.Tls.CertificateStatusRequest statusRequest = global::Org.BouncyCastle.Crypto.Tls.CertificateStatusRequest.Parse(memoryStream);
			global::Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(memoryStream);
			return statusRequest;
		}

		// Token: 0x060023E3 RID: 9187 RVA: 0x0009CA03 File Offset: 0x0009AC03
		public static bool ReadTruncatedHMacExtension(byte[] extensionData)
		{
			return global::Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.ReadEmptyExtensionData(extensionData);
		}
	}
}
