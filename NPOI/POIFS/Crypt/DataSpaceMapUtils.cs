using System;
using System.IO;
using System.Text;
using NPOI.POIFS.Crypt.Standard;
using NPOI.POIFS.EventFileSystem;
using NPOI.POIFS.FileSystem;
using NPOI.Util;

namespace NPOI.POIFS.Crypt
{
	// Token: 0x020002FE RID: 766
	public class DataSpaceMapUtils
	{
		// Token: 0x06001609 RID: 5641 RVA: 0x000421A0 File Offset: 0x000403A0
		public static void AddDefaultDataSpace(global::NPOI.POIFS.FileSystem.DirectoryEntry dir)
		{
			global::NPOI.POIFS.Crypt.DataSpaceMapUtils.DataSpaceMapEntry dataSpaceMapEntry = new global::NPOI.POIFS.Crypt.DataSpaceMapUtils.DataSpaceMapEntry(new int[1], new string[]
			{
				global::NPOI.POIFS.Crypt.Decryptor.DEFAULT_POIFS_ENTRY
			}, "StrongEncryptionDataSpace");
			global::NPOI.POIFS.Crypt.DataSpaceMapUtils.DataSpaceMap @out = new global::NPOI.POIFS.Crypt.DataSpaceMapUtils.DataSpaceMap(new global::NPOI.POIFS.Crypt.DataSpaceMapUtils.DataSpaceMapEntry[]
			{
				dataSpaceMapEntry
			});
			global::NPOI.POIFS.Crypt.DataSpaceMapUtils.CreateEncryptionEntry(dir, "\u0006DataSpaces/DataSpaceMap", @out);
			global::NPOI.POIFS.Crypt.DataSpaceMapUtils.DataSpaceDefInition out2 = new global::NPOI.POIFS.Crypt.DataSpaceMapUtils.DataSpaceDefInition(new string[]
			{
				"StrongEncryptionTransform"
			});
			global::NPOI.POIFS.Crypt.DataSpaceMapUtils.CreateEncryptionEntry(dir, "\u0006DataSpaces/DataSpaceInfo/StrongEncryptionDataSpace", out2);
			global::NPOI.POIFS.Crypt.DataSpaceMapUtils.IRMDSTransformInfo out3 = new global::NPOI.POIFS.Crypt.DataSpaceMapUtils.IRMDSTransformInfo(new global::NPOI.POIFS.Crypt.DataSpaceMapUtils.TransformInfoHeader(1, "{FF9A3F03-56EF-4613-BDD5-5A41C1D07246}", "Microsoft.Container.EncryptionTransform", 1, 0, 1, 0, 1, 0), 0, null);
			global::NPOI.POIFS.Crypt.DataSpaceMapUtils.CreateEncryptionEntry(dir, "\u0006DataSpaces/TransformInfo/StrongEncryptionTransform/\u0006Primary", out3);
			global::NPOI.POIFS.Crypt.DataSpaceMapUtils.DataSpaceVersionInfo out4 = new global::NPOI.POIFS.Crypt.DataSpaceMapUtils.DataSpaceVersionInfo("Microsoft.Container.DataSpaces", 1, 0, 1, 0, 1, 0);
			global::NPOI.POIFS.Crypt.DataSpaceMapUtils.CreateEncryptionEntry(dir, "\u0006DataSpaces/Version", out4);
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x00042258 File Offset: 0x00040458
		public static global::NPOI.POIFS.FileSystem.DocumentEntry CreateEncryptionEntry(global::NPOI.POIFS.FileSystem.DirectoryEntry dir, string path, global::NPOI.POIFS.Crypt.Standard.EncryptionRecord out1)
		{
			string[] array = path.Split("/".ToCharArray());
			for (int i = 0; i < array.Length - 1; i++)
			{
				dir = (dir.HasEntry(array[i]) ? ((global::NPOI.POIFS.FileSystem.DirectoryEntry)dir.GetEntry(array[i])) : dir.CreateDirectory(array[i]));
			}
			byte[] buf = new byte[5000];
			global::NPOI.Util.LittleEndianByteArrayOutputStream littleEndianByteArrayOutputStream = new global::NPOI.Util.LittleEndianByteArrayOutputStream(buf, 0);
			out1.Write(littleEndianByteArrayOutputStream);
			string name = array[array.Length - 1];
			if (dir.HasEntry(name))
			{
				dir.GetEntry(name).Delete();
			}
			return dir.CreateDocument(name, littleEndianByteArrayOutputStream.WriteIndex, new global::NPOI.POIFS.Crypt.DataSpaceMapUtils.POIFSWriterListenerImpl(buf));
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x00042300 File Offset: 0x00040500
		public static string ReadUnicodeLPP4(global::NPOI.Util.ILittleEndianInput is1)
		{
			int num = is1.ReadInt();
			if (num % 2 != 0)
			{
				throw new global::NPOI.EncryptedDocumentException("UNICODE-LP-P4 structure is a multiple of 4 bytes. If PAdding is present, it MUST be exactly 2 bytes long");
			}
			string result = global::NPOI.Util.StringUtil.ReadUnicodeLE(is1, num / 2);
			if (num % 4 == 2)
			{
				is1.ReadShort();
			}
			return result;
		}

		// Token: 0x0600160C RID: 5644 RVA: 0x0004233C File Offset: 0x0004053C
		public static void WriteUnicodeLPP4(global::NPOI.Util.ILittleEndianOutput os, string string1)
		{
			byte[] toUnicodeLE = global::NPOI.Util.StringUtil.GetToUnicodeLE(string1);
			os.WriteInt(toUnicodeLE.Length);
			os.Write(toUnicodeLE);
			if (toUnicodeLE.Length % 4 == 2)
			{
				os.WriteShort(0);
			}
		}

		// Token: 0x0600160D RID: 5645 RVA: 0x00042370 File Offset: 0x00040570
		public static string ReadUtf8LPP4(global::NPOI.Util.ILittleEndianInput is1)
		{
			int num = is1.ReadInt();
			if (num != 0 && num != 4)
			{
				byte[] array = new byte[num];
				is1.ReadFully(array);
				int num2 = num % 4;
				if (num2 > 0)
				{
					for (int i = 0; i < 4 - num2; i++)
					{
						is1.ReadByte();
					}
				}
				return global::System.Text.Encoding.UTF8.GetString(array, 0, array.Length);
			}
			is1.ReadInt();
			if (num != 0)
			{
				return "";
			}
			return null;
		}

		// Token: 0x0600160E RID: 5646 RVA: 0x000423D8 File Offset: 0x000405D8
		public static void WriteUtf8LPP4(global::NPOI.Util.ILittleEndianOutput os, string str)
		{
			if (str == null || "".Equals(str))
			{
				os.WriteInt((str == null) ? 0 : 4);
				os.WriteInt(0);
				return;
			}
			byte[] bytes = global::System.Text.Encoding.UTF8.GetBytes(str);
			os.WriteInt(bytes.Length);
			os.Write(bytes);
			int num = bytes.Length % 4;
			if (num > 0)
			{
				for (int i = 0; i < 4 - num; i++)
				{
					os.WriteByte(0);
				}
			}
		}

		// Token: 0x020005B3 RID: 1459
		public class POIFSWriterListenerImpl : global::NPOI.POIFS.EventFileSystem.POIFSWriterListener
		{
			// Token: 0x060034B3 RID: 13491 RVA: 0x000A3D4C File Offset: 0x000A1F4C
			public POIFSWriterListenerImpl(byte[] buf)
			{
				this.buf = buf;
			}

			// Token: 0x060034B4 RID: 13492 RVA: 0x000A3D5C File Offset: 0x000A1F5C
			public void ProcessPOIFSWriterEvent(global::NPOI.POIFS.EventFileSystem.POIFSWriterEvent event1)
			{
				try
				{
					event1.Stream.Write(this.buf, 0, event1.Limit);
				}
				catch (global::System.IO.IOException cause)
				{
					throw new global::NPOI.EncryptedDocumentException(cause);
				}
			}

			// Token: 0x04001943 RID: 6467
			private byte[] buf;
		}

		// Token: 0x020005B4 RID: 1460
		public class DataSpaceMap : global::NPOI.POIFS.Crypt.Standard.EncryptionRecord
		{
			// Token: 0x060034B5 RID: 13493 RVA: 0x000A3D9C File Offset: 0x000A1F9C
			public DataSpaceMap(global::NPOI.POIFS.Crypt.DataSpaceMapUtils.DataSpaceMapEntry[] entries)
			{
				this.entries = entries;
			}

			// Token: 0x060034B6 RID: 13494 RVA: 0x000A3DAC File Offset: 0x000A1FAC
			public DataSpaceMap(global::NPOI.Util.ILittleEndianInput is1)
			{
				is1.ReadInt();
				int num = is1.ReadInt();
				this.entries = new global::NPOI.POIFS.Crypt.DataSpaceMapUtils.DataSpaceMapEntry[num];
				for (int i = 0; i < num; i++)
				{
					this.entries[i] = new global::NPOI.POIFS.Crypt.DataSpaceMapUtils.DataSpaceMapEntry(is1);
				}
			}

			// Token: 0x060034B7 RID: 13495 RVA: 0x000A3DF4 File Offset: 0x000A1FF4
			public void Write(global::NPOI.Util.LittleEndianByteArrayOutputStream os)
			{
				os.WriteInt(8);
				os.WriteInt(this.entries.Length);
				global::NPOI.POIFS.Crypt.DataSpaceMapUtils.DataSpaceMapEntry[] array = this.entries;
				for (int i = 0; i < array.Length; i++)
				{
					array[i].Write(os);
				}
			}

			// Token: 0x04001944 RID: 6468
			private global::NPOI.POIFS.Crypt.DataSpaceMapUtils.DataSpaceMapEntry[] entries;
		}

		// Token: 0x020005B5 RID: 1461
		public class DataSpaceMapEntry : global::NPOI.POIFS.Crypt.Standard.EncryptionRecord
		{
			// Token: 0x060034B8 RID: 13496 RVA: 0x000A3E34 File Offset: 0x000A2034
			public DataSpaceMapEntry(int[] referenceComponentType, string[] referenceComponent, string dataSpaceName)
			{
				this.referenceComponentType = referenceComponentType;
				this.referenceComponent = referenceComponent;
				this.dataSpaceName = dataSpaceName;
			}

			// Token: 0x060034B9 RID: 13497 RVA: 0x000A3E54 File Offset: 0x000A2054
			public DataSpaceMapEntry(global::NPOI.Util.ILittleEndianInput is1)
			{
				is1.ReadInt();
				int num = is1.ReadInt();
				this.referenceComponentType = new int[num];
				this.referenceComponent = new string[num];
				for (int i = 0; i < num; i++)
				{
					this.referenceComponentType[i] = is1.ReadInt();
					this.referenceComponent[i] = global::NPOI.POIFS.Crypt.DataSpaceMapUtils.ReadUnicodeLPP4(is1);
				}
				this.dataSpaceName = global::NPOI.POIFS.Crypt.DataSpaceMapUtils.ReadUnicodeLPP4(is1);
			}

			// Token: 0x060034BA RID: 13498 RVA: 0x000A3EC4 File Offset: 0x000A20C4
			public void Write(global::NPOI.Util.LittleEndianByteArrayOutputStream os)
			{
				int writeIndex = os.WriteIndex;
				global::NPOI.Util.ILittleEndianOutput littleEndianOutput = os.CreateDelayedOutput(4);
				os.WriteInt(this.referenceComponent.Length);
				for (int i = 0; i < this.referenceComponent.Length; i++)
				{
					os.WriteInt(this.referenceComponentType[i]);
					global::NPOI.POIFS.Crypt.DataSpaceMapUtils.WriteUnicodeLPP4(os, this.referenceComponent[i]);
				}
				global::NPOI.POIFS.Crypt.DataSpaceMapUtils.WriteUnicodeLPP4(os, this.dataSpaceName);
				littleEndianOutput.WriteInt(os.WriteIndex - writeIndex);
			}

			// Token: 0x04001945 RID: 6469
			private int[] referenceComponentType;

			// Token: 0x04001946 RID: 6470
			private string[] referenceComponent;

			// Token: 0x04001947 RID: 6471
			private string dataSpaceName;
		}

		// Token: 0x020005B6 RID: 1462
		public class DataSpaceDefInition : global::NPOI.POIFS.Crypt.Standard.EncryptionRecord
		{
			// Token: 0x060034BB RID: 13499 RVA: 0x000A3F37 File Offset: 0x000A2137
			public DataSpaceDefInition(string[] transformer)
			{
				this.transformer = transformer;
			}

			// Token: 0x060034BC RID: 13500 RVA: 0x000A3F48 File Offset: 0x000A2148
			public DataSpaceDefInition(global::NPOI.Util.ILittleEndianInput is1)
			{
				is1.ReadInt();
				int num = is1.ReadInt();
				this.transformer = new string[num];
				for (int i = 0; i < num; i++)
				{
					this.transformer[i] = global::NPOI.POIFS.Crypt.DataSpaceMapUtils.ReadUnicodeLPP4(is1);
				}
			}

			// Token: 0x060034BD RID: 13501 RVA: 0x000A3F90 File Offset: 0x000A2190
			public void Write(global::NPOI.Util.LittleEndianByteArrayOutputStream bos)
			{
				bos.WriteInt(8);
				bos.WriteInt(this.transformer.Length);
				foreach (string @string in this.transformer)
				{
					global::NPOI.POIFS.Crypt.DataSpaceMapUtils.WriteUnicodeLPP4(bos, @string);
				}
			}

			// Token: 0x04001948 RID: 6472
			private string[] transformer;
		}

		// Token: 0x020005B7 RID: 1463
		public class IRMDSTransformInfo : global::NPOI.POIFS.Crypt.Standard.EncryptionRecord
		{
			// Token: 0x060034BE RID: 13502 RVA: 0x000A3FD2 File Offset: 0x000A21D2
			public IRMDSTransformInfo(global::NPOI.POIFS.Crypt.DataSpaceMapUtils.TransformInfoHeader transformInfoHeader, int extensibilityHeader, string xrMLLicense)
			{
				this.transformInfoHeader = transformInfoHeader;
				this.extensibilityHeader = extensibilityHeader;
				this.xrMLLicense = xrMLLicense;
			}

			// Token: 0x060034BF RID: 13503 RVA: 0x000A3FEF File Offset: 0x000A21EF
			public IRMDSTransformInfo(global::NPOI.Util.ILittleEndianInput is1)
			{
				this.transformInfoHeader = new global::NPOI.POIFS.Crypt.DataSpaceMapUtils.TransformInfoHeader(is1);
				this.extensibilityHeader = is1.ReadInt();
				this.xrMLLicense = global::NPOI.POIFS.Crypt.DataSpaceMapUtils.ReadUtf8LPP4(is1);
			}

			// Token: 0x060034C0 RID: 13504 RVA: 0x000A401B File Offset: 0x000A221B
			public void Write(global::NPOI.Util.LittleEndianByteArrayOutputStream bos)
			{
				this.transformInfoHeader.Write(bos);
				bos.WriteInt(this.extensibilityHeader);
				global::NPOI.POIFS.Crypt.DataSpaceMapUtils.WriteUtf8LPP4(bos, this.xrMLLicense);
				bos.WriteInt(4);
			}

			// Token: 0x04001949 RID: 6473
			private global::NPOI.POIFS.Crypt.DataSpaceMapUtils.TransformInfoHeader transformInfoHeader;

			// Token: 0x0400194A RID: 6474
			private int extensibilityHeader;

			// Token: 0x0400194B RID: 6475
			private string xrMLLicense;
		}

		// Token: 0x020005B8 RID: 1464
		public class TransformInfoHeader : global::NPOI.POIFS.Crypt.Standard.EncryptionRecord
		{
			// Token: 0x060034C1 RID: 13505 RVA: 0x000A4048 File Offset: 0x000A2248
			public TransformInfoHeader(int transformType, string transformerId, string transformerName, int readerVersionMajor, int readerVersionMinor, int updaterVersionMajor, int updaterVersionMinor, int writerVersionMajor, int writerVersionMinor)
			{
				this.transformType = transformType;
				this.transformerId = transformerId;
				this.transformerName = transformerName;
				this.readerVersionMajor = readerVersionMajor;
				this.readerVersionMinor = readerVersionMinor;
				this.updaterVersionMajor = updaterVersionMajor;
				this.updaterVersionMinor = updaterVersionMinor;
				this.writerVersionMajor = writerVersionMajor;
				this.writerVersionMinor = writerVersionMinor;
			}

			// Token: 0x060034C2 RID: 13506 RVA: 0x000A40B8 File Offset: 0x000A22B8
			public TransformInfoHeader(global::NPOI.Util.ILittleEndianInput is1)
			{
				is1.ReadInt();
				this.transformType = is1.ReadInt();
				this.transformerId = global::NPOI.POIFS.Crypt.DataSpaceMapUtils.ReadUnicodeLPP4(is1);
				this.transformerName = global::NPOI.POIFS.Crypt.DataSpaceMapUtils.ReadUnicodeLPP4(is1);
				this.readerVersionMajor = (int)is1.ReadShort();
				this.readerVersionMinor = (int)is1.ReadShort();
				this.updaterVersionMajor = (int)is1.ReadShort();
				this.updaterVersionMinor = (int)is1.ReadShort();
				this.writerVersionMajor = (int)is1.ReadShort();
				this.writerVersionMinor = (int)is1.ReadShort();
			}

			// Token: 0x060034C3 RID: 13507 RVA: 0x000A4154 File Offset: 0x000A2354
			public void Write(global::NPOI.Util.LittleEndianByteArrayOutputStream bos)
			{
				int writeIndex = bos.WriteIndex;
				global::NPOI.Util.ILittleEndianOutput littleEndianOutput = bos.CreateDelayedOutput(4);
				bos.WriteInt(this.transformType);
				global::NPOI.POIFS.Crypt.DataSpaceMapUtils.WriteUnicodeLPP4(bos, this.transformerId);
				littleEndianOutput.WriteInt(bos.WriteIndex - writeIndex);
				global::NPOI.POIFS.Crypt.DataSpaceMapUtils.WriteUnicodeLPP4(bos, this.transformerName);
				bos.WriteShort(this.readerVersionMajor);
				bos.WriteShort(this.readerVersionMinor);
				bos.WriteShort(this.updaterVersionMajor);
				bos.WriteShort(this.updaterVersionMinor);
				bos.WriteShort(this.writerVersionMajor);
				bos.WriteShort(this.writerVersionMinor);
			}

			// Token: 0x0400194C RID: 6476
			private int transformType;

			// Token: 0x0400194D RID: 6477
			private string transformerId;

			// Token: 0x0400194E RID: 6478
			private string transformerName;

			// Token: 0x0400194F RID: 6479
			private int readerVersionMajor = 1;

			// Token: 0x04001950 RID: 6480
			private int readerVersionMinor;

			// Token: 0x04001951 RID: 6481
			private int updaterVersionMajor = 1;

			// Token: 0x04001952 RID: 6482
			private int updaterVersionMinor;

			// Token: 0x04001953 RID: 6483
			private int writerVersionMajor = 1;

			// Token: 0x04001954 RID: 6484
			private int writerVersionMinor;
		}

		// Token: 0x020005B9 RID: 1465
		public class DataSpaceVersionInfo : global::NPOI.POIFS.Crypt.Standard.EncryptionRecord
		{
			// Token: 0x060034C4 RID: 13508 RVA: 0x000A41E8 File Offset: 0x000A23E8
			public DataSpaceVersionInfo(global::NPOI.Util.ILittleEndianInput is1)
			{
				this.featureIdentifier = global::NPOI.POIFS.Crypt.DataSpaceMapUtils.ReadUnicodeLPP4(is1);
				this.readerVersionMajor = (int)is1.ReadShort();
				this.readerVersionMinor = (int)is1.ReadShort();
				this.updaterVersionMajor = (int)is1.ReadShort();
				this.updaterVersionMinor = (int)is1.ReadShort();
				this.writerVersionMajor = (int)is1.ReadShort();
				this.writerVersionMinor = (int)is1.ReadShort();
			}

			// Token: 0x060034C5 RID: 13509 RVA: 0x000A4264 File Offset: 0x000A2464
			public DataSpaceVersionInfo(string featureIdentifier, int readerVersionMajor, int readerVersionMinor, int updaterVersionMajor, int updaterVersionMinor, int writerVersionMajor, int writerVersionMinor)
			{
				this.featureIdentifier = featureIdentifier;
				this.readerVersionMajor = readerVersionMajor;
				this.readerVersionMinor = readerVersionMinor;
				this.updaterVersionMajor = updaterVersionMajor;
				this.updaterVersionMinor = updaterVersionMinor;
				this.writerVersionMajor = writerVersionMajor;
				this.writerVersionMinor = writerVersionMinor;
			}

			// Token: 0x060034C6 RID: 13510 RVA: 0x000A42C4 File Offset: 0x000A24C4
			public void Write(global::NPOI.Util.LittleEndianByteArrayOutputStream bos)
			{
				global::NPOI.POIFS.Crypt.DataSpaceMapUtils.WriteUnicodeLPP4(bos, this.featureIdentifier);
				bos.WriteShort(this.readerVersionMajor);
				bos.WriteShort(this.readerVersionMinor);
				bos.WriteShort(this.updaterVersionMajor);
				bos.WriteShort(this.updaterVersionMinor);
				bos.WriteShort(this.writerVersionMajor);
				bos.WriteShort(this.writerVersionMinor);
			}

			// Token: 0x04001955 RID: 6485
			private string featureIdentifier;

			// Token: 0x04001956 RID: 6486
			private int readerVersionMajor = 1;

			// Token: 0x04001957 RID: 6487
			private int readerVersionMinor;

			// Token: 0x04001958 RID: 6488
			private int updaterVersionMajor = 1;

			// Token: 0x04001959 RID: 6489
			private int updaterVersionMinor;

			// Token: 0x0400195A RID: 6490
			private int writerVersionMajor = 1;

			// Token: 0x0400195B RID: 6491
			private int writerVersionMinor;
		}
	}
}
