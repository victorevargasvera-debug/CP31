using System;
using System.IO;

namespace NPOI.OpenXml4Net.OPC.Internal.Marshallers
{
	// Token: 0x0200002C RID: 44
	public class DefaultMarshaller : global::NPOI.OpenXml4Net.OPC.Internal.PartMarshaller
	{
		// Token: 0x060001F9 RID: 505 RVA: 0x0000912C File Offset: 0x0000732C
		public bool Marshall(global::NPOI.OpenXml4Net.OPC.PackagePart part, global::System.IO.Stream out1)
		{
			return part.Save(out1);
		}
	}
}
