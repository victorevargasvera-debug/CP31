using System;
using NPOI.HPSF;
using NPOI.HPSF.Extractor;
using NPOI.POIFS.FileSystem;

namespace NPOI
{
	// Token: 0x02000007 RID: 7
	public abstract class POIOLE2TextExtractor : global::NPOI.POITextExtractor
	{
		// Token: 0x06000020 RID: 32 RVA: 0x000024C7 File Offset: 0x000006C7
		public POIOLE2TextExtractor(global::NPOI.POIDocument document)
		{
			this.document = document;
			base.SetFilesystem(document);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000024DD File Offset: 0x000006DD
		protected POIOLE2TextExtractor(global::NPOI.POIOLE2TextExtractor otherExtractor)
		{
			this.document = otherExtractor.document;
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000022 RID: 34 RVA: 0x000024F1 File Offset: 0x000006F1
		public virtual global::NPOI.HPSF.DocumentSummaryInformation DocSummaryInformation
		{
			get
			{
				return this.document.DocumentSummaryInformation;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000023 RID: 35 RVA: 0x000024FE File Offset: 0x000006FE
		public virtual global::NPOI.HPSF.SummaryInformation SummaryInformation
		{
			get
			{
				return this.document.SummaryInformation;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000024 RID: 36 RVA: 0x0000250B File Offset: 0x0000070B
		public override global::NPOI.POITextExtractor MetadataTextExtractor
		{
			get
			{
				return new global::NPOI.HPSF.Extractor.HPSFPropertiesExtractor(this);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000025 RID: 37 RVA: 0x00002513 File Offset: 0x00000713
		public global::NPOI.POIFS.FileSystem.DirectoryEntry Root
		{
			get
			{
				return this.document.Directory;
			}
		}

		// Token: 0x04000007 RID: 7
		protected global::NPOI.POIDocument document;
	}
}
