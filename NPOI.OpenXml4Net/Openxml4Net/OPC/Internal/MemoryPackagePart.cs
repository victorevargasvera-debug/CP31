using System;
using System.IO;
using NPOI.OpenXml4Net.OPC.Internal.Marshallers;

namespace NPOI.OpenXml4Net.OPC.Internal
{
	// Token: 0x02000023 RID: 35
	public class MemoryPackagePart : global::NPOI.OpenXml4Net.OPC.PackagePart
	{
		// Token: 0x06000183 RID: 387 RVA: 0x000072DA File Offset: 0x000054DA
		public MemoryPackagePart(global::NPOI.OpenXml4Net.OPC.OPCPackage pack, global::NPOI.OpenXml4Net.OPC.PackagePartName partName, string contentType) : base(pack, partName, contentType)
		{
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00007D81 File Offset: 0x00005F81
		public MemoryPackagePart(global::NPOI.OpenXml4Net.OPC.OPCPackage pack, global::NPOI.OpenXml4Net.OPC.PackagePartName partName, string contentType, bool loadRelationships) : base(pack, partName, new global::NPOI.OpenXml4Net.OPC.Internal.ContentType(contentType), loadRelationships)
		{
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00007D94 File Offset: 0x00005F94
		protected override global::System.IO.Stream GetInputStreamImpl()
		{
			if (this.data == null)
			{
				return new global::System.IO.MemoryStream();
			}
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream((int)this.data.Length);
			this.data.Position = 0L;
			global::NPOI.OpenXml4Net.OPC.StreamHelper.CopyStream(this.data, memoryStream);
			memoryStream.Position = 0L;
			return memoryStream;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00007DE3 File Offset: 0x00005FE3
		protected override global::System.IO.Stream GetOutputStreamImpl()
		{
			return new global::NPOI.OpenXml4Net.OPC.Internal.MemoryPackagePartOutputStream(this);
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000187 RID: 391 RVA: 0x00007DEB File Offset: 0x00005FEB
		public override long Size
		{
			get
			{
				if (this.data != null)
				{
					return this.data.Length;
				}
				return 0L;
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00007E03 File Offset: 0x00006003
		public override void Clear()
		{
			this.data = null;
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000732D File Offset: 0x0000552D
		public override bool Save(global::System.IO.Stream os)
		{
			return new global::NPOI.OpenXml4Net.OPC.Internal.Marshallers.ZipPartMarshaller().Marshall(this, os);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x00007E0C File Offset: 0x0000600C
		public override bool Load(global::System.IO.Stream ios)
		{
			global::NPOI.OpenXml4Net.OPC.StreamHelper.CopyStream(ios, this.data);
			return true;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0000478E File Offset: 0x0000298E
		public override void Close()
		{
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000478E File Offset: 0x0000298E
		public override void Flush()
		{
		}

		// Token: 0x040000A8 RID: 168
		internal global::System.IO.MemoryStream data;
	}
}
