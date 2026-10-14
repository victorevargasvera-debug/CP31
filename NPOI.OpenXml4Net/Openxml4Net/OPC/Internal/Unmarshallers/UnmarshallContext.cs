using System;
using ICSharpCode.SharpZipLib.Zip;

namespace NPOI.OpenXml4Net.OPC.Internal.Unmarshallers
{
	// Token: 0x0200002B RID: 43
	public class UnmarshallContext
	{
		// Token: 0x060001F2 RID: 498 RVA: 0x000090E3 File Offset: 0x000072E3
		public UnmarshallContext(global::NPOI.OpenXml4Net.OPC.OPCPackage targetPackage, global::NPOI.OpenXml4Net.OPC.PackagePartName partName)
		{
			this._package = targetPackage;
			this.partName = partName;
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060001F3 RID: 499 RVA: 0x000090F9 File Offset: 0x000072F9
		// (set) Token: 0x060001F4 RID: 500 RVA: 0x00009101 File Offset: 0x00007301
		internal global::NPOI.OpenXml4Net.OPC.OPCPackage Package
		{
			get
			{
				return this._package;
			}
			set
			{
				this._package = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x0000910A File Offset: 0x0000730A
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x00009112 File Offset: 0x00007312
		internal global::NPOI.OpenXml4Net.OPC.PackagePartName PartName
		{
			get
			{
				return this.partName;
			}
			set
			{
				this.partName = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x0000911B File Offset: 0x0000731B
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x00009123 File Offset: 0x00007323
		internal global::ICSharpCode.SharpZipLib.Zip.ZipEntry ZipEntry
		{
			get
			{
				return this.zipEntry;
			}
			set
			{
				this.zipEntry = value;
			}
		}

		// Token: 0x040000DD RID: 221
		private global::NPOI.OpenXml4Net.OPC.OPCPackage _package;

		// Token: 0x040000DE RID: 222
		private global::NPOI.OpenXml4Net.OPC.PackagePartName partName;

		// Token: 0x040000DF RID: 223
		private global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry;
	}
}
