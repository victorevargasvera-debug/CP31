using System;
using System.IO;

namespace Gibraltar.Data
{
	// Token: 0x020000E8 RID: 232
	internal class FileHeader
	{
		// Token: 0x060009A2 RID: 2466 RVA: 0x000173EC File Offset: 0x000155EC
		public FileHeader() : this((int)global::Gibraltar.Data.FileHeader.DefaultMajorVersion, (int)global::Gibraltar.Data.FileHeader.DefaultMinorVersion)
		{
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x00017400 File Offset: 0x00015600
		public FileHeader(int majorVersion, int minorVersion)
		{
			this.m_TypeCode = 8739037465685924362L;
			this.m_MajorVersion = (short)majorVersion;
			this.m_MinorVersion = (short)minorVersion;
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00017428 File Offset: 0x00015628
		public FileHeader(byte[] data)
		{
			if (data == null)
			{
				throw new global::System.ArgumentNullException("data");
			}
			if (data.Length < 20)
			{
				throw new global::System.ArgumentException("The provided header buffer is too short to be a valid header.", "data");
			}
			global::System.IO.MemoryStream networkBytes = new global::System.IO.MemoryStream(data);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(networkBytes, out this.m_TypeCode);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(networkBytes, out this.m_MajorVersion);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(networkBytes, out this.m_MinorVersion);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(networkBytes, out this.m_DataOffset);
			global::Gibraltar.Data.BinarySerializer.DeserializeValue(networkBytes, out this.m_DataChecksum);
		}

		// Token: 0x060009A5 RID: 2469 RVA: 0x000174AC File Offset: 0x000156AC
		public byte[] RawData()
		{
			byte[] array = new byte[20];
			int num = 0;
			foreach (byte b in global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_TypeCode))
			{
				array[num++] = b;
			}
			foreach (byte b2 in global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_MajorVersion))
			{
				array[num++] = b2;
			}
			foreach (byte b3 in global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_MinorVersion))
			{
				array[num++] = b3;
			}
			foreach (byte b4 in global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_DataOffset))
			{
				array[num++] = b4;
			}
			foreach (byte b5 in global::Gibraltar.Data.BinarySerializer.SerializeValue(this.m_DataChecksum))
			{
				array[num++] = b5;
			}
			return array;
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x060009A6 RID: 2470 RVA: 0x000175A0 File Offset: 0x000157A0
		// (set) Token: 0x060009A7 RID: 2471 RVA: 0x000175A8 File Offset: 0x000157A8
		public long TypeCode
		{
			get
			{
				return this.m_TypeCode;
			}
			set
			{
				this.m_TypeCode = value;
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x060009A8 RID: 2472 RVA: 0x000175B4 File Offset: 0x000157B4
		// (set) Token: 0x060009A9 RID: 2473 RVA: 0x000175BC File Offset: 0x000157BC
		public short MajorVersion
		{
			get
			{
				return this.m_MajorVersion;
			}
			set
			{
				this.m_MajorVersion = value;
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x060009AA RID: 2474 RVA: 0x000175C8 File Offset: 0x000157C8
		// (set) Token: 0x060009AB RID: 2475 RVA: 0x000175D0 File Offset: 0x000157D0
		public short MinorVersion
		{
			get
			{
				return this.m_MinorVersion;
			}
			set
			{
				this.m_MinorVersion = value;
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x060009AC RID: 2476 RVA: 0x000175DC File Offset: 0x000157DC
		// (set) Token: 0x060009AD RID: 2477 RVA: 0x000175E4 File Offset: 0x000157E4
		public int DataOffset
		{
			get
			{
				return this.m_DataOffset;
			}
			set
			{
				this.m_DataOffset = value;
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x060009AE RID: 2478 RVA: 0x000175F0 File Offset: 0x000157F0
		// (set) Token: 0x060009AF RID: 2479 RVA: 0x000175F8 File Offset: 0x000157F8
		public int DataChecksum
		{
			get
			{
				return this.m_DataChecksum;
			}
			set
			{
				this.m_DataChecksum = value;
			}
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x00017604 File Offset: 0x00015804
		public bool IsValid()
		{
			return true;
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x00017608 File Offset: 0x00015808
		public static bool SupportsComputerId(int majorVersion, int minorVersion)
		{
			return majorVersion > 2 || (majorVersion == 2 && minorVersion > 0);
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x00017620 File Offset: 0x00015820
		public static bool SupportsEnvironmentAndPromotion(int majorVersion, int minorVersion)
		{
			return majorVersion > 1;
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x00017628 File Offset: 0x00015828
		public static bool SupportsFragments(int majorVersion, int minorVersion)
		{
			return majorVersion > 1;
		}

		// Token: 0x0400024E RID: 590
		public const int HeaderSize = 20;

		// Token: 0x0400024F RID: 591
		public const long GLFTypeCode = 8739037465685924362L;

		// Token: 0x04000250 RID: 592
		public static short DefaultMajorVersion = 2;

		// Token: 0x04000251 RID: 593
		public static short DefaultMinorVersion = 2;

		// Token: 0x04000252 RID: 594
		private long m_TypeCode;

		// Token: 0x04000253 RID: 595
		private short m_MajorVersion;

		// Token: 0x04000254 RID: 596
		private short m_MinorVersion;

		// Token: 0x04000255 RID: 597
		private int m_DataOffset;

		// Token: 0x04000256 RID: 598
		private int m_DataChecksum;
	}
}
