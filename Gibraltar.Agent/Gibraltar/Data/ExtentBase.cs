using System;

namespace Gibraltar.Data
{
	// Token: 0x020000D8 RID: 216
	internal class ExtentBase
	{
		// Token: 0x060008F1 RID: 2289 RVA: 0x0001407C File Offset: 0x0001227C
		protected internal ExtentBase(global::Gibraltar.Data.ExtentPreamble preamble)
		{
			this.m_Preamble = preamble;
		}

		// Token: 0x060008F2 RID: 2290 RVA: 0x0001408C File Offset: 0x0001228C
		protected internal ExtentBase(global::Gibraltar.Data.ExtentTypeCode typeCode, short majorVersion)
		{
			this.m_Preamble = new global::Gibraltar.Data.ExtentPreamble(typeCode, majorVersion);
		}

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x060008F3 RID: 2291 RVA: 0x000140A4 File Offset: 0x000122A4
		protected global::Gibraltar.Data.ExtentPreamble Preamble
		{
			get
			{
				return this.m_Preamble;
			}
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x000140AC File Offset: 0x000122AC
		public global::Gibraltar.Data.ExtentTypeCode TypeCode
		{
			get
			{
				return this.m_Preamble.TypeCode;
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x000140BC File Offset: 0x000122BC
		public short MajorVersion
		{
			get
			{
				return this.m_Preamble.MajorVersion;
			}
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x000140CC File Offset: 0x000122CC
		// (set) Token: 0x060008F7 RID: 2295 RVA: 0x000140DC File Offset: 0x000122DC
		public short MinorVersion
		{
			get
			{
				return this.m_Preamble.MinorVersion;
			}
			internal set
			{
				this.m_Preamble.MinorVersion = value;
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x000140EC File Offset: 0x000122EC
		// (set) Token: 0x060008F9 RID: 2297 RVA: 0x000140FC File Offset: 0x000122FC
		public long Offset
		{
			get
			{
				return this.m_Preamble.Offset;
			}
			internal set
			{
				this.m_Preamble.Offset = value;
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x0001410C File Offset: 0x0001230C
		// (set) Token: 0x060008FB RID: 2299 RVA: 0x0001411C File Offset: 0x0001231C
		public int Checksum
		{
			get
			{
				return this.m_Preamble.Checksum;
			}
			internal set
			{
				this.m_Preamble.Checksum = value;
			}
		}

		// Token: 0x040001F0 RID: 496
		private readonly global::Gibraltar.Data.ExtentPreamble m_Preamble;
	}
}
