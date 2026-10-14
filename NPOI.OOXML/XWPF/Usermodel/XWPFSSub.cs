using System;
using NPOI.OpenXmlFormats.Shared;
using NPOI.XWPF.UserModel;

namespace NPOI.XWPF.Usermodel
{
	// Token: 0x02000016 RID: 22
	public class XWPFSSub : global::NPOI.XWPF.UserModel.IRunBody
	{
		// Token: 0x0600010A RID: 266 RVA: 0x00004EE4 File Offset: 0x000030E4
		public XWPFSSub(global::NPOI.OpenXmlFormats.Shared.CT_SSub ssub, global::NPOI.XWPF.UserModel.IRunBody p)
		{
			this.ssub = ssub;
			this.parent = p;
			if (ssub.e == null)
			{
				ssub.e = new global::NPOI.OpenXmlFormats.Shared.CT_OMathArg();
			}
			this.e = new global::NPOI.XWPF.Usermodel.XWPFOMathArg(ssub.e, this);
			if (ssub.sub == null)
			{
				ssub.sub = new global::NPOI.OpenXmlFormats.Shared.CT_OMathArg();
			}
			this.sub = new global::NPOI.XWPF.Usermodel.XWPFOMathArg(ssub.sub, this);
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00004F4F File Offset: 0x0000314F
		public global::NPOI.XWPF.UserModel.XWPFDocument Document
		{
			get
			{
				return this.parent.Document;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600010C RID: 268 RVA: 0x00004F5C File Offset: 0x0000315C
		public global::NPOI.POIXMLDocumentPart Part
		{
			get
			{
				return this.parent.Part;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600010D RID: 269 RVA: 0x00004F69 File Offset: 0x00003169
		public global::NPOI.XWPF.Usermodel.XWPFOMathArg Element
		{
			get
			{
				return this.e;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00004F71 File Offset: 0x00003171
		public global::NPOI.XWPF.Usermodel.XWPFOMathArg Subscript
		{
			get
			{
				return this.sub;
			}
		}

		// Token: 0x04000050 RID: 80
		private global::NPOI.OpenXmlFormats.Shared.CT_SSub ssub;

		// Token: 0x04000051 RID: 81
		private global::NPOI.XWPF.UserModel.IRunBody parent;

		// Token: 0x04000052 RID: 82
		private readonly global::NPOI.XWPF.Usermodel.XWPFOMathArg e;

		// Token: 0x04000053 RID: 83
		private readonly global::NPOI.XWPF.Usermodel.XWPFOMathArg sub;
	}
}
