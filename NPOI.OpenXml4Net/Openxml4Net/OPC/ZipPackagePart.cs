using System;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;
using NPOI.OpenXml4Net.OPC.Internal.Marshallers;

namespace NPOI.OpenXml4Net.OPC
{
	// Token: 0x0200001F RID: 31
	public class ZipPackagePart : global::NPOI.OpenXml4Net.OPC.PackagePart
	{
		// Token: 0x06000159 RID: 345 RVA: 0x000072DA File Offset: 0x000054DA
		public ZipPackagePart(global::NPOI.OpenXml4Net.OPC.OPCPackage container, global::NPOI.OpenXml4Net.OPC.PackagePartName partName, string contentType) : base(container, partName, contentType)
		{
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000072E5 File Offset: 0x000054E5
		public ZipPackagePart(global::NPOI.OpenXml4Net.OPC.OPCPackage container, global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry, global::NPOI.OpenXml4Net.OPC.PackagePartName partName, string contentType) : base(container, partName, contentType)
		{
			this.zipEntry = zipEntry;
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600015B RID: 347 RVA: 0x000072F8 File Offset: 0x000054F8
		public global::ICSharpCode.SharpZipLib.Zip.ZipEntry ZipArchive
		{
			get
			{
				return this.zipEntry;
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x00007300 File Offset: 0x00005500
		protected override global::System.IO.Stream GetInputStreamImpl()
		{
			return ((global::NPOI.OpenXml4Net.OPC.ZipPackage)this._container).ZipArchive.GetInputStream(this.zipEntry);
		}

		// Token: 0x0600015D RID: 349 RVA: 0x0000731D File Offset: 0x0000551D
		protected override global::System.IO.Stream GetOutputStreamImpl()
		{
			return null;
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00007320 File Offset: 0x00005520
		public override long Size
		{
			get
			{
				return this.zipEntry.Size;
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000732D File Offset: 0x0000552D
		public override bool Save(global::System.IO.Stream os)
		{
			return new global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.ZipPartMarshaller().Marshall(this, os);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000733B File Offset: 0x0000553B
		public override bool Load(global::System.IO.Stream ios)
		{
			throw new global::System.InvalidOperationException("Method not implemented !");
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000733B File Offset: 0x0000553B
		public override void Close()
		{
			throw new global::System.InvalidOperationException("Method not implemented !");
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000733B File Offset: 0x0000553B
		public override void Flush()
		{
			throw new global::System.InvalidOperationException("Method not implemented !");
		}

		// Token: 0x04000095 RID: 149
		private global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry;
	}
}
