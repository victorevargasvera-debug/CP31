using System;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x02000020 RID: 32
	public interface IBodyElement
	{
		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000126 RID: 294
		global::NPOI.XWPF.UserModel.IBody Body { get; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000127 RID: 295
		global::NPOI.POIXMLDocumentPart Part { get; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000128 RID: 296
		global::NPOI.XWPF.UserModel.BodyType PartType { get; }

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000129 RID: 297
		global::NPOI.XWPF.UserModel.BodyElementType ElementType { get; }
	}
}
