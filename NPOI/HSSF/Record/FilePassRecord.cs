using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x020003DB RID: 987
	public class FilePassRecord : global::NPOI.HSSF.Record.StandardRecord, global::System.ICloneable
	{
		// Token: 0x06002345 RID: 9029 RVA: 0x0006AB7C File Offset: 0x00068D7C
		private FilePassRecord(global::NPOI.HSSF.Record.FilePassRecord other)
		{
			this._encryptionType = other._encryptionType;
			this._keyData = (global::NPOI.HSSF.Record.FilePassRecord.KeyData)other._keyData.Clone();
		}

		// Token: 0x06002346 RID: 9030 RVA: 0x0006ABA8 File Offset: 0x00068DA8
		public FilePassRecord(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this._encryptionType = in1.ReadUShort();
			int encryptionType = this._encryptionType;
			if (encryptionType != 0)
			{
				if (encryptionType != 1)
				{
					throw new global::NPOI.Util.RecordFormatException("Unknown encryption type " + this._encryptionType.ToString());
				}
				this._keyData = new global::NPOI.HSSF.Record.FilePassRecord.Rc4KeyData();
			}
			else
			{
				this._keyData = new global::NPOI.HSSF.Record.FilePassRecord.XorKeyData();
			}
			this._keyData.Read(in1);
		}

		// Token: 0x06002347 RID: 9031 RVA: 0x0006AC18 File Offset: 0x00068E18
		private static byte[] Read(global::NPOI.HSSF.Record.RecordInputStream in1, int size)
		{
			byte[] array = new byte[size];
			in1.ReadFully(array);
			return array;
		}

		// Token: 0x06002348 RID: 9032 RVA: 0x0006AC34 File Offset: 0x00068E34
		public override void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteShort(this._encryptionType);
			this._keyData.Serialize(out1);
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06002349 RID: 9033 RVA: 0x0006AC4E File Offset: 0x00068E4E
		protected override int DataSize
		{
			get
			{
				return this._keyData.DataSize;
			}
		}

		// Token: 0x0600234A RID: 9034 RVA: 0x0006AC5B File Offset: 0x00068E5B
		public global::NPOI.HSSF.Record.FilePassRecord.Rc4KeyData GetRc4KeyData()
		{
			if (!(this._keyData is global::NPOI.HSSF.Record.FilePassRecord.Rc4KeyData))
			{
				return null;
			}
			return (global::NPOI.HSSF.Record.FilePassRecord.Rc4KeyData)this._keyData;
		}

		// Token: 0x0600234B RID: 9035 RVA: 0x0006AC77 File Offset: 0x00068E77
		public global::NPOI.HSSF.Record.FilePassRecord.XorKeyData GetXorKeyData()
		{
			if (!(this._keyData is global::NPOI.HSSF.Record.FilePassRecord.XorKeyData))
			{
				return null;
			}
			return (global::NPOI.HSSF.Record.FilePassRecord.XorKeyData)this._keyData;
		}

		// Token: 0x0600234C RID: 9036 RVA: 0x0006AC93 File Offset: 0x00068E93
		private global::NPOI.HSSF.Record.FilePassRecord.Rc4KeyData CheckRc4()
		{
			global::NPOI.HSSF.Record.FilePassRecord.Rc4KeyData rc4KeyData = this.GetRc4KeyData();
			if (rc4KeyData == null)
			{
				throw new global::NPOI.Util.RecordFormatException("file pass record doesn't contain a rc4 key.");
			}
			return rc4KeyData;
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x0600234D RID: 9037 RVA: 0x0006ACA9 File Offset: 0x00068EA9
		public override short Sid
		{
			get
			{
				return 47;
			}
		}

		// Token: 0x0600234E RID: 9038 RVA: 0x0006ACAD File Offset: 0x00068EAD
		public override object Clone()
		{
			return new global::NPOI.HSSF.Record.FilePassRecord(this);
		}

		// Token: 0x0600234F RID: 9039 RVA: 0x0006ACB8 File Offset: 0x00068EB8
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append("[FILEPASS]\n");
			stringBuilder.Append("    .type = ").Append(global::NPOI.Util.HexDump.ShortToHex(this._encryptionType)).Append("\n");
			this._keyData.AppendToString(stringBuilder);
			stringBuilder.Append("[/FILEPASS]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x04000EDA RID: 3802
		public const short sid = 47;

		// Token: 0x04000EDB RID: 3803
		private const int ENCRYPTION_XOR = 0;

		// Token: 0x04000EDC RID: 3804
		private const int ENCRYPTION_OTHER = 1;

		// Token: 0x04000EDD RID: 3805
		private int _encryptionType;

		// Token: 0x04000EDE RID: 3806
		private global::NPOI.HSSF.Record.FilePassRecord.KeyData _keyData;

		// Token: 0x0200060D RID: 1549
		private interface KeyData : global::System.ICloneable
		{
			// Token: 0x0600366B RID: 13931
			void Read(global::NPOI.HSSF.Record.RecordInputStream in1);

			// Token: 0x0600366C RID: 13932
			void Serialize(global::NPOI.Util.ILittleEndianOutput out1);

			// Token: 0x17000E1C RID: 3612
			// (get) Token: 0x0600366D RID: 13933
			int DataSize { get; }

			// Token: 0x0600366E RID: 13934
			void AppendToString(global::System.Text.StringBuilder buffer);
		}

		// Token: 0x0200060E RID: 1550
		public class Rc4KeyData : global::NPOI.HSSF.Record.FilePassRecord.KeyData, global::System.ICloneable
		{
			// Token: 0x0600366F RID: 13935 RVA: 0x000A6608 File Offset: 0x000A4808
			public void Read(global::NPOI.HSSF.Record.RecordInputStream in1)
			{
				this._encryptionInfo = in1.ReadUShort();
				int encryptionInfo = this._encryptionInfo;
				if (encryptionInfo != 1)
				{
					if (encryptionInfo - 2 <= 2)
					{
						throw new global::NPOI.EncryptedDocumentException("HSSF does not currently support CryptoAPI encryption");
					}
					throw new global::NPOI.Util.RecordFormatException("Unknown encryption info " + this._encryptionInfo.ToString());
				}
				else
				{
					this._minorVersionNo = in1.ReadUShort();
					if (this._minorVersionNo != 1)
					{
						throw new global::NPOI.Util.RecordFormatException("Unexpected VersionInfo number for RC4Header " + this._minorVersionNo.ToString());
					}
					this._salt = global::NPOI.HSSF.Record.FilePassRecord.Read(in1, 16);
					this._encryptedVerifier = global::NPOI.HSSF.Record.FilePassRecord.Read(in1, 16);
					this._encryptedVerifierHash = global::NPOI.HSSF.Record.FilePassRecord.Read(in1, 16);
					return;
				}
			}

			// Token: 0x06003670 RID: 13936 RVA: 0x000A66B2 File Offset: 0x000A48B2
			public void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
			{
				out1.WriteShort(this._encryptionInfo);
				out1.WriteShort(this._minorVersionNo);
				out1.Write(this._salt);
				out1.Write(this._encryptedVerifier);
				out1.Write(this._encryptedVerifierHash);
			}

			// Token: 0x17000E1D RID: 3613
			// (get) Token: 0x06003671 RID: 13937 RVA: 0x000A4E7E File Offset: 0x000A307E
			public int DataSize
			{
				get
				{
					return 54;
				}
			}

			// Token: 0x17000E1E RID: 3614
			// (get) Token: 0x06003672 RID: 13938 RVA: 0x000A66F0 File Offset: 0x000A48F0
			// (set) Token: 0x06003673 RID: 13939 RVA: 0x000A6702 File Offset: 0x000A4902
			public byte[] Salt
			{
				get
				{
					return (byte[])this._salt.Clone();
				}
				set
				{
					this._salt = (byte[])value.Clone();
				}
			}

			// Token: 0x17000E1F RID: 3615
			// (get) Token: 0x06003674 RID: 13940 RVA: 0x000A6715 File Offset: 0x000A4915
			// (set) Token: 0x06003675 RID: 13941 RVA: 0x000A6727 File Offset: 0x000A4927
			public byte[] EncryptedVerifier
			{
				get
				{
					return (byte[])this._encryptedVerifier.Clone();
				}
				set
				{
					this._encryptedVerifier = (byte[])value.Clone();
				}
			}

			// Token: 0x17000E20 RID: 3616
			// (get) Token: 0x06003676 RID: 13942 RVA: 0x000A673A File Offset: 0x000A493A
			// (set) Token: 0x06003677 RID: 13943 RVA: 0x000A674C File Offset: 0x000A494C
			public byte[] EncryptedVerifierHash
			{
				get
				{
					return (byte[])this._encryptedVerifierHash.Clone();
				}
				set
				{
					this._encryptedVerifierHash = (byte[])value.Clone();
				}
			}

			// Token: 0x06003678 RID: 13944 RVA: 0x000A6760 File Offset: 0x000A4960
			public void AppendToString(global::System.Text.StringBuilder buffer)
			{
				buffer.Append("    .rc4.info = ").Append(global::NPOI.Util.HexDump.ShortToHex(this._encryptionInfo)).Append("\n");
				buffer.Append("    .rc4.ver  = ").Append(global::NPOI.Util.HexDump.ShortToHex(this._minorVersionNo)).Append("\n");
				buffer.Append("    .rc4.salt = ").Append(global::NPOI.Util.HexDump.ToHex(this._salt)).Append("\n");
				buffer.Append("    .rc4.verifier = ").Append(global::NPOI.Util.HexDump.ToHex(this._encryptedVerifier)).Append("\n");
				buffer.Append("    .rc4.verifierHash = ").Append(global::NPOI.Util.HexDump.ToHex(this._encryptedVerifierHash)).Append("\n");
			}

			// Token: 0x06003679 RID: 13945 RVA: 0x000A682C File Offset: 0x000A4A2C
			public object Clone()
			{
				return new global::NPOI.HSSF.Record.FilePassRecord.Rc4KeyData
				{
					_salt = (byte[])this._salt.Clone(),
					_encryptedVerifier = (byte[])this._encryptedVerifier.Clone(),
					_encryptedVerifierHash = (byte[])this._encryptedVerifierHash.Clone(),
					_encryptionInfo = this._encryptionInfo,
					_minorVersionNo = this._minorVersionNo
				};
			}

			// Token: 0x04001A67 RID: 6759
			private const int ENCRYPTION_OTHER_RC4 = 1;

			// Token: 0x04001A68 RID: 6760
			private const int ENCRYPTION_OTHER_CAPI_2 = 2;

			// Token: 0x04001A69 RID: 6761
			private const int ENCRYPTION_OTHER_CAPI_3 = 3;

			// Token: 0x04001A6A RID: 6762
			private const int ENCRYPTION_OTHER_CAPI_4 = 4;

			// Token: 0x04001A6B RID: 6763
			private byte[] _salt;

			// Token: 0x04001A6C RID: 6764
			private byte[] _encryptedVerifier;

			// Token: 0x04001A6D RID: 6765
			private byte[] _encryptedVerifierHash;

			// Token: 0x04001A6E RID: 6766
			private int _encryptionInfo;

			// Token: 0x04001A6F RID: 6767
			private int _minorVersionNo;
		}

		// Token: 0x0200060F RID: 1551
		public class XorKeyData : global::NPOI.HSSF.Record.FilePassRecord.KeyData, global::System.ICloneable
		{
			// Token: 0x0600367B RID: 13947 RVA: 0x000A6898 File Offset: 0x000A4A98
			public void Read(global::NPOI.HSSF.Record.RecordInputStream in1)
			{
				this._key = in1.ReadUShort();
				this._verifier = in1.ReadUShort();
			}

			// Token: 0x0600367C RID: 13948 RVA: 0x000A68B2 File Offset: 0x000A4AB2
			public void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
			{
				out1.WriteShort(this._key);
				out1.WriteShort(this._verifier);
			}

			// Token: 0x17000E21 RID: 3617
			// (get) Token: 0x0600367D RID: 13949 RVA: 0x00017F5F File Offset: 0x0001615F
			public int DataSize
			{
				get
				{
					return 6;
				}
			}

			// Token: 0x17000E22 RID: 3618
			// (get) Token: 0x0600367E RID: 13950 RVA: 0x000A68CC File Offset: 0x000A4ACC
			// (set) Token: 0x0600367F RID: 13951 RVA: 0x000A68D4 File Offset: 0x000A4AD4
			public int Key
			{
				get
				{
					return this._key;
				}
				set
				{
					this._key = value;
				}
			}

			// Token: 0x17000E23 RID: 3619
			// (get) Token: 0x06003680 RID: 13952 RVA: 0x000A68DD File Offset: 0x000A4ADD
			// (set) Token: 0x06003681 RID: 13953 RVA: 0x000A68E5 File Offset: 0x000A4AE5
			public int Verifier
			{
				get
				{
					return this._verifier;
				}
				set
				{
					this._verifier = value;
				}
			}

			// Token: 0x06003682 RID: 13954 RVA: 0x000A68F0 File Offset: 0x000A4AF0
			public void AppendToString(global::System.Text.StringBuilder buffer)
			{
				buffer.Append("    .xor.key = ").Append(global::NPOI.Util.HexDump.IntToHex(this._key)).Append("\n");
				buffer.Append("    .xor.verifier  = ").Append(global::NPOI.Util.HexDump.IntToHex(this._verifier)).Append("\n");
			}

			// Token: 0x06003683 RID: 13955 RVA: 0x000A6949 File Offset: 0x000A4B49
			public object Clone()
			{
				return new global::NPOI.HSSF.Record.FilePassRecord.XorKeyData
				{
					_key = this._key,
					_verifier = this._verifier
				};
			}

			// Token: 0x04001A70 RID: 6768
			private int _key;

			// Token: 0x04001A71 RID: 6769
			private int _verifier;
		}
	}
}
