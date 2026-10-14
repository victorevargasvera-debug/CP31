using System;
using System.IO;
using NPOI.OpenXml4Net.OPC.Internal.Unmarshallers;

namespace NPOI.OpenXml4Net.OPC.Internal
{
	// Token: 0x02000027 RID: 39
	public interface PartUnmarshaller
	{
		// Token: 0x060001CE RID: 462
		global::NPOI.OpenXml4Net.OPC.PackagePart Unmarshall(global::NPOI.OpenXml4Net.OPC.Internal.Unmarshallers.UnmarshallContext context, global::System.IO.Stream in1);
	}
}
