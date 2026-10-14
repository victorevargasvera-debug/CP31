using System;
using System.IO;
using System.Reflection;
using NPOI.POIFS.FileSystem;
using NPOI.Util;

namespace NPOI.POIFS.Crypt
{
	// Token: 0x02000301 RID: 769
	public class EncryptionInfo
	{
		// Token: 0x0600163D RID: 5693 RVA: 0x000426C3 File Offset: 0x000408C3
		public EncryptionInfo(global::NPOI.POIFS.FileSystem.POIFSFileSystem fs) : this(fs.Root)
		{
		}

		// Token: 0x0600163E RID: 5694 RVA: 0x000426D1 File Offset: 0x000408D1
		public EncryptionInfo(global::NPOI.POIFS.FileSystem.OPOIFSFileSystem fs) : this(fs.Root)
		{
		}

		// Token: 0x0600163F RID: 5695 RVA: 0x000426C3 File Offset: 0x000408C3
		public EncryptionInfo(global::NPOI.POIFS.FileSystem.NPOIFSFileSystem fs) : this(fs.Root)
		{
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x000426DF File Offset: 0x000408DF
		public EncryptionInfo(global::NPOI.POIFS.FileSystem.DirectoryNode dir) : this(dir.CreateDocumentInputStream("EncryptionInfo"), false)
		{
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x000426F4 File Offset: 0x000408F4
		public EncryptionInfo(global::NPOI.Util.ILittleEndianInput dis, bool isCryptoAPI)
		{
			this._versionMajor = (int)dis.ReadShort();
			this._versionMinor = (int)dis.ReadShort();
			global::NPOI.POIFS.Crypt.EncryptionMode encryptionMode;
			if (!isCryptoAPI && this.VersionMajor == global::NPOI.POIFS.Crypt.EncryptionMode.BinaryRC4.VersionMajor && this.VersionMinor == global::NPOI.POIFS.Crypt.EncryptionMode.BinaryRC4.VersionMinor)
			{
				encryptionMode = global::NPOI.POIFS.Crypt.EncryptionMode.BinaryRC4;
				this._encryptionFlags = -1;
			}
			else if (!isCryptoAPI && this.VersionMajor == global::NPOI.POIFS.Crypt.EncryptionMode.Agile.VersionMajor && this.VersionMinor == global::NPOI.POIFS.Crypt.EncryptionMode.Agile.VersionMinor)
			{
				encryptionMode = global::NPOI.POIFS.Crypt.EncryptionMode.Agile;
				this._encryptionFlags = dis.ReadInt();
			}
			else if (!isCryptoAPI && 2 <= this.VersionMajor && this.VersionMajor <= 4 && this.VersionMinor == global::NPOI.POIFS.Crypt.EncryptionMode.Standard.VersionMinor)
			{
				encryptionMode = global::NPOI.POIFS.Crypt.EncryptionMode.Standard;
				this._encryptionFlags = dis.ReadInt();
			}
			else
			{
				if (!isCryptoAPI || 2 > this.VersionMajor || this.VersionMajor > 4 || this.VersionMinor != global::NPOI.POIFS.Crypt.EncryptionMode.CryptoAPI.VersionMinor)
				{
					this._encryptionFlags = dis.ReadInt();
					throw new global::NPOI.EncryptedDocumentException(string.Concat(new string[]
					{
						"Unknown encryption: version major: ",
						this.VersionMajor.ToString(),
						" / version minor: ",
						this.VersionMinor.ToString(),
						" / fCrypto: ",
						global::NPOI.POIFS.Crypt.EncryptionInfo.flagCryptoAPI.IsSet(this.EncryptionFlags).ToString(),
						" / fExternal: ",
						global::NPOI.POIFS.Crypt.EncryptionInfo.flagExternal.IsSet(this.EncryptionFlags).ToString(),
						" / fDocProps: ",
						global::NPOI.POIFS.Crypt.EncryptionInfo.flagDocProps.IsSet(this.EncryptionFlags).ToString(),
						" / fAES: ",
						global::NPOI.POIFS.Crypt.EncryptionInfo.flagAES.IsSet(this.EncryptionFlags).ToString()
					}));
				}
				encryptionMode = global::NPOI.POIFS.Crypt.EncryptionMode.CryptoAPI;
				this._encryptionFlags = dis.ReadInt();
			}
			global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder builder;
			try
			{
				builder = global::NPOI.POIFS.Crypt.EncryptionInfo.GetBuilder(encryptionMode);
			}
			catch (global::System.Exception ex)
			{
				throw new global::System.IO.IOException(ex.Message, ex);
			}
			builder.Initialize(this, dis);
			this._header = builder.GetHeader();
			this._verifier = builder.GetVerifier();
			this._decryptor = builder.GetDecryptor();
			this._encryptor = builder.GetEncryptor();
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x00042954 File Offset: 0x00040B54
		public EncryptionInfo(global::NPOI.POIFS.FileSystem.POIFSFileSystem fs, global::NPOI.POIFS.Crypt.EncryptionMode encryptionMode) : this(encryptionMode)
		{
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x00042954 File Offset: 0x00040B54
		public EncryptionInfo(global::NPOI.POIFS.FileSystem.NPOIFSFileSystem fs, global::NPOI.POIFS.Crypt.EncryptionMode encryptionMode) : this(encryptionMode)
		{
		}

		// Token: 0x06001644 RID: 5700 RVA: 0x00042954 File Offset: 0x00040B54
		public EncryptionInfo(global::NPOI.POIFS.FileSystem.DirectoryNode dir, global::NPOI.POIFS.Crypt.EncryptionMode encryptionMode) : this(encryptionMode)
		{
		}

		// Token: 0x06001645 RID: 5701 RVA: 0x0004295D File Offset: 0x00040B5D
		public EncryptionInfo(global::NPOI.POIFS.FileSystem.POIFSFileSystem fs, global::NPOI.POIFS.Crypt.EncryptionMode encryptionMode, global::NPOI.POIFS.Crypt.CipherAlgorithm cipherAlgorithm, global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm, int keyBits, int blockSize, global::NPOI.POIFS.Crypt.ChainingMode chainingMode) : this(encryptionMode, cipherAlgorithm, hashAlgorithm, keyBits, blockSize, chainingMode)
		{
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x0004295D File Offset: 0x00040B5D
		public EncryptionInfo(global::NPOI.POIFS.FileSystem.NPOIFSFileSystem fs, global::NPOI.POIFS.Crypt.EncryptionMode encryptionMode, global::NPOI.POIFS.Crypt.CipherAlgorithm cipherAlgorithm, global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm, int keyBits, int blockSize, global::NPOI.POIFS.Crypt.ChainingMode chainingMode) : this(encryptionMode, cipherAlgorithm, hashAlgorithm, keyBits, blockSize, chainingMode)
		{
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x0004295D File Offset: 0x00040B5D
		public EncryptionInfo(global::NPOI.POIFS.FileSystem.DirectoryNode dir, global::NPOI.POIFS.Crypt.EncryptionMode encryptionMode, global::NPOI.POIFS.Crypt.CipherAlgorithm cipherAlgorithm, global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm, int keyBits, int blockSize, global::NPOI.POIFS.Crypt.ChainingMode chainingMode) : this(encryptionMode, cipherAlgorithm, hashAlgorithm, keyBits, blockSize, chainingMode)
		{
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x0004296F File Offset: 0x00040B6F
		public EncryptionInfo(global::NPOI.POIFS.Crypt.EncryptionMode encryptionMode) : this(encryptionMode, null, null, -1, -1, null)
		{
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x00042980 File Offset: 0x00040B80
		public EncryptionInfo(global::NPOI.POIFS.Crypt.EncryptionMode encryptionMode, global::NPOI.POIFS.Crypt.CipherAlgorithm cipherAlgorithm, global::NPOI.POIFS.Crypt.HashAlgorithm hashAlgorithm, int keyBits, int blockSize, global::NPOI.POIFS.Crypt.ChainingMode chainingMode)
		{
			this._versionMajor = encryptionMode.VersionMajor;
			this._versionMinor = encryptionMode.VersionMinor;
			this._encryptionFlags = encryptionMode.EncryptionFlags;
			global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder builder;
			try
			{
				builder = global::NPOI.POIFS.Crypt.EncryptionInfo.GetBuilder(encryptionMode);
			}
			catch (global::System.Exception cause)
			{
				throw new global::NPOI.EncryptedDocumentException(cause);
			}
			builder.Initialize(this, cipherAlgorithm, hashAlgorithm, keyBits, blockSize, chainingMode);
			this._header = builder.GetHeader();
			this._verifier = builder.GetVerifier();
			this._decryptor = builder.GetDecryptor();
			this._encryptor = builder.GetEncryptor();
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x00042A18 File Offset: 0x00040C18
		protected static global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder GetBuilder(global::NPOI.POIFS.Crypt.EncryptionMode encryptionMode)
		{
			global::System.Reflection.Assembly[] assemblies = global::System.AppDomain.CurrentDomain.GetAssemblies();
			global::System.Type type = null;
			global::System.Reflection.Assembly[] array = assemblies;
			for (int i = 0; i < array.Length; i++)
			{
				type = array[i].GetType(encryptionMode.Builder);
				if (type != null)
				{
					break;
				}
			}
			if (type == null)
			{
				throw new global::NPOI.EncryptedDocumentException("Not found type " + encryptionMode.Builder);
			}
			return (global::NPOI.POIFS.Crypt.IEncryptionInfoBuilder)type.Assembly.CreateInstance(encryptionMode.Builder);
		}

		// Token: 0x17000452 RID: 1106
		// (get) Token: 0x0600164B RID: 5707 RVA: 0x00042A8D File Offset: 0x00040C8D
		public int VersionMajor
		{
			get
			{
				return this._versionMajor;
			}
		}

		// Token: 0x17000453 RID: 1107
		// (get) Token: 0x0600164C RID: 5708 RVA: 0x00042A95 File Offset: 0x00040C95
		public int VersionMinor
		{
			get
			{
				return this._versionMinor;
			}
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x0600164D RID: 5709 RVA: 0x00042A9D File Offset: 0x00040C9D
		public int EncryptionFlags
		{
			get
			{
				return this._encryptionFlags;
			}
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x0600164E RID: 5710 RVA: 0x00042AA5 File Offset: 0x00040CA5
		public global::NPOI.POIFS.Crypt.EncryptionHeader Header
		{
			get
			{
				return this._header;
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x0600164F RID: 5711 RVA: 0x00042AAD File Offset: 0x00040CAD
		public global::NPOI.POIFS.Crypt.EncryptionVerifier Verifier
		{
			get
			{
				return this._verifier;
			}
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06001650 RID: 5712 RVA: 0x00042AB5 File Offset: 0x00040CB5
		public global::NPOI.POIFS.Crypt.Decryptor Decryptor
		{
			get
			{
				return this._decryptor;
			}
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06001651 RID: 5713 RVA: 0x00042ABD File Offset: 0x00040CBD
		public global::NPOI.POIFS.Crypt.Encryptor Encryptor
		{
			get
			{
				return this._encryptor;
			}
		}

		// Token: 0x04000915 RID: 2325
		public static global::NPOI.Util.BitField flagCryptoAPI = global::NPOI.Util.BitFieldFactory.GetInstance(4);

		// Token: 0x04000916 RID: 2326
		public static global::NPOI.Util.BitField flagDocProps = global::NPOI.Util.BitFieldFactory.GetInstance(8);

		// Token: 0x04000917 RID: 2327
		public static global::NPOI.Util.BitField flagExternal = global::NPOI.Util.BitFieldFactory.GetInstance(16);

		// Token: 0x04000918 RID: 2328
		public static global::NPOI.Util.BitField flagAES = global::NPOI.Util.BitFieldFactory.GetInstance(32);

		// Token: 0x04000919 RID: 2329
		private int _versionMajor;

		// Token: 0x0400091A RID: 2330
		private int _versionMinor;

		// Token: 0x0400091B RID: 2331
		private int _encryptionFlags;

		// Token: 0x0400091C RID: 2332
		private global::NPOI.POIFS.Crypt.EncryptionHeader _header;

		// Token: 0x0400091D RID: 2333
		private global::NPOI.POIFS.Crypt.EncryptionVerifier _verifier;

		// Token: 0x0400091E RID: 2334
		private global::NPOI.POIFS.Crypt.Decryptor _decryptor;

		// Token: 0x0400091F RID: 2335
		private global::NPOI.POIFS.Crypt.Encryptor _encryptor;
	}
}
