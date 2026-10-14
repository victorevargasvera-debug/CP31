using System;
using NPOI.OpenXml4Net.OPC;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x020000A5 RID: 165
	public class XSSFVBAPart : global::NPOI.POIXMLDocumentPart
	{
		// Token: 0x06000A44 RID: 2628 RVA: 0x0000A972 File Offset: 0x00008B72
		public XSSFVBAPart()
		{
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x0000A97A File Offset: 0x00008B7A
		public XSSFVBAPart(global::NPOI.OpenXml4Net.OPC.PackagePart part) : base(part)
		{
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x00025A97 File Offset: 0x00023C97
		[global::System.Obsolete("deprecated in POI 3.14, scheduled for removal in POI 3.16")]
		protected XSSFVBAPart(global::NPOI.OpenXml4Net.OPC.PackagePart part, global::NPOI.OpenXml4Net.OPC.PackageRelationship rel) : this(part)
		{
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x000029BF File Offset: 0x00000BBF
		protected internal override void PrepareForCommit()
		{
		}
	}
}
