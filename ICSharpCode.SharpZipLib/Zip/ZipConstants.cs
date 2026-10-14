using System;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200000F RID: 15
	public static class ZipConstants
	{
		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000061 RID: 97 RVA: 0x0000324B File Offset: 0x0000144B
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00003252 File Offset: 0x00001452
		[global::System.Obsolete("Use ZipStrings instead")]
		public static int DefaultCodePage
		{
			get
			{
				return global::ICSharpCode.SharpZipLib.Zip.ZipStrings.CodePage;
			}
			set
			{
				global::ICSharpCode.SharpZipLib.Zip.ZipStrings.CodePage = value;
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x0000325A File Offset: 0x0000145A
		[global::System.Obsolete("Use ZipStrings.ConvertToString instead")]
		public static string ConvertToString(byte[] data, int count)
		{
			return global::ICSharpCode.SharpZipLib.Zip.ZipStrings.ConvertToString(data, count);
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00003263 File Offset: 0x00001463
		[global::System.Obsolete("Use ZipStrings.ConvertToString instead")]
		public static string ConvertToString(byte[] data)
		{
			return global::ICSharpCode.SharpZipLib.Zip.ZipStrings.ConvertToString(data);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x0000326B File Offset: 0x0000146B
		[global::System.Obsolete("Use ZipStrings.ConvertToStringExt instead")]
		public static string ConvertToStringExt(int flags, byte[] data, int count)
		{
			return global::ICSharpCode.SharpZipLib.Zip.ZipStrings.ConvertToStringExt(flags, data, count);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00003275 File Offset: 0x00001475
		[global::System.Obsolete("Use ZipStrings.ConvertToStringExt instead")]
		public static string ConvertToStringExt(int flags, byte[] data)
		{
			return global::ICSharpCode.SharpZipLib.Zip.ZipStrings.ConvertToStringExt(flags, data);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000327E File Offset: 0x0000147E
		[global::System.Obsolete("Use ZipStrings.ConvertToArray instead")]
		public static byte[] ConvertToArray(string str)
		{
			return global::ICSharpCode.SharpZipLib.Zip.ZipStrings.ConvertToArray(str);
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00003286 File Offset: 0x00001486
		[global::System.Obsolete("Use ZipStrings.ConvertToArray instead")]
		public static byte[] ConvertToArray(int flags, string str)
		{
			return global::ICSharpCode.SharpZipLib.Zip.ZipStrings.ConvertToArray(flags, str);
		}

		// Token: 0x0400004F RID: 79
		public const int VersionMadeBy = 51;

		// Token: 0x04000050 RID: 80
		[global::System.Obsolete("Use VersionMadeBy instead")]
		public const int VERSION_MADE_BY = 51;

		// Token: 0x04000051 RID: 81
		public const int VersionStrongEncryption = 50;

		// Token: 0x04000052 RID: 82
		[global::System.Obsolete("Use VersionStrongEncryption instead")]
		public const int VERSION_STRONG_ENCRYPTION = 50;

		// Token: 0x04000053 RID: 83
		public const int VERSION_AES = 51;

		// Token: 0x04000054 RID: 84
		public const int VersionZip64 = 45;

		// Token: 0x04000055 RID: 85
		public const int VersionBZip2 = 46;

		// Token: 0x04000056 RID: 86
		public const int LocalHeaderBaseSize = 30;

		// Token: 0x04000057 RID: 87
		[global::System.Obsolete("Use LocalHeaderBaseSize instead")]
		public const int LOCHDR = 30;

		// Token: 0x04000058 RID: 88
		public const int Zip64DataDescriptorSize = 24;

		// Token: 0x04000059 RID: 89
		public const int DataDescriptorSize = 16;

		// Token: 0x0400005A RID: 90
		[global::System.Obsolete("Use DataDescriptorSize instead")]
		public const int EXTHDR = 16;

		// Token: 0x0400005B RID: 91
		public const int CentralHeaderBaseSize = 46;

		// Token: 0x0400005C RID: 92
		[global::System.Obsolete("Use CentralHeaderBaseSize instead")]
		public const int CENHDR = 46;

		// Token: 0x0400005D RID: 93
		public const int EndOfCentralRecordBaseSize = 22;

		// Token: 0x0400005E RID: 94
		[global::System.Obsolete("Use EndOfCentralRecordBaseSize instead")]
		public const int ENDHDR = 22;

		// Token: 0x0400005F RID: 95
		public const int CryptoHeaderSize = 12;

		// Token: 0x04000060 RID: 96
		[global::System.Obsolete("Use CryptoHeaderSize instead")]
		public const int CRYPTO_HEADER_SIZE = 12;

		// Token: 0x04000061 RID: 97
		public const int Zip64EndOfCentralDirectoryLocatorSize = 20;

		// Token: 0x04000062 RID: 98
		public const int LocalHeaderSignature = 67324752;

		// Token: 0x04000063 RID: 99
		[global::System.Obsolete("Use LocalHeaderSignature instead")]
		public const int LOCSIG = 67324752;

		// Token: 0x04000064 RID: 100
		public const int SpanningSignature = 134695760;

		// Token: 0x04000065 RID: 101
		[global::System.Obsolete("Use SpanningSignature instead")]
		public const int SPANNINGSIG = 134695760;

		// Token: 0x04000066 RID: 102
		public const int SpanningTempSignature = 808471376;

		// Token: 0x04000067 RID: 103
		[global::System.Obsolete("Use SpanningTempSignature instead")]
		public const int SPANTEMPSIG = 808471376;

		// Token: 0x04000068 RID: 104
		public const int DataDescriptorSignature = 134695760;

		// Token: 0x04000069 RID: 105
		[global::System.Obsolete("Use DataDescriptorSignature instead")]
		public const int EXTSIG = 134695760;

		// Token: 0x0400006A RID: 106
		[global::System.Obsolete("Use CentralHeaderSignature instead")]
		public const int CENSIG = 33639248;

		// Token: 0x0400006B RID: 107
		public const int CentralHeaderSignature = 33639248;

		// Token: 0x0400006C RID: 108
		public const int Zip64CentralFileHeaderSignature = 101075792;

		// Token: 0x0400006D RID: 109
		[global::System.Obsolete("Use Zip64CentralFileHeaderSignature instead")]
		public const int CENSIG64 = 101075792;

		// Token: 0x0400006E RID: 110
		public const int Zip64CentralDirLocatorSignature = 117853008;

		// Token: 0x0400006F RID: 111
		public const int ArchiveExtraDataSignature = 117853008;

		// Token: 0x04000070 RID: 112
		public const int CentralHeaderDigitalSignature = 84233040;

		// Token: 0x04000071 RID: 113
		[global::System.Obsolete("Use CentralHeaderDigitalSignaure instead")]
		public const int CENDIGITALSIG = 84233040;

		// Token: 0x04000072 RID: 114
		public const int EndOfCentralDirectorySignature = 101010256;

		// Token: 0x04000073 RID: 115
		[global::System.Obsolete("Use EndOfCentralDirectorySignature instead")]
		public const int ENDSIG = 101010256;
	}
}
