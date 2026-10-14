using System;
using NPOI.OpenXmlFormats.Shared;
using NPOI.XWPF.UserModel;

namespace NPOI.XWPF.Usermodel
{
	// Token: 0x02000010 RID: 16
	public class XWPFRad : global::NPOI.XWPF.UserModel.IRunBody
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x00004760 File Offset: 0x00002960
		public XWPFRad(global::NPOI.OpenXmlFormats.Shared.CT_Rad rad, global::NPOI.XWPF.UserModel.IRunBody p)
		{
			this.rad = rad;
			this.parent = p;
			if (rad.radPr == null)
			{
				rad.radPr = new global::NPOI.OpenXmlFormats.Shared.CT_RadPr();
			}
			if (rad.deg == null)
			{
				rad.deg = new global::NPOI.OpenXmlFormats.Shared.CT_OMathArg();
			}
			this.deg = new global::NPOI.XWPF.Usermodel.XWPFOMathArg(rad.deg, this);
			if (rad.e == null)
			{
				rad.e = new global::NPOI.OpenXmlFormats.Shared.CT_OMathArg();
			}
			this.e = new global::NPOI.XWPF.Usermodel.XWPFOMathArg(rad.e, this);
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x000047DE File Offset: 0x000029DE
		public global::NPOI.XWPF.UserModel.XWPFDocument Document
		{
			get
			{
				return this.parent.Document;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000CA RID: 202 RVA: 0x000047EB File Offset: 0x000029EB
		public global::NPOI.POIXMLDocumentPart Part
		{
			get
			{
				return this.parent.Part;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000CB RID: 203 RVA: 0x000047F8 File Offset: 0x000029F8
		public global::NPOI.XWPF.Usermodel.XWPFOMathArg Degree
		{
			get
			{
				return this.deg;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000CC RID: 204 RVA: 0x00004800 File Offset: 0x00002A00
		public global::NPOI.XWPF.Usermodel.XWPFOMathArg Element
		{
			get
			{
				return this.e;
			}
		}

		// Token: 0x04000031 RID: 49
		private global::NPOI.OpenXmlFormats.Shared.CT_Rad rad;

		// Token: 0x04000032 RID: 50
		private global::NPOI.XWPF.UserModel.IRunBody parent;

		// Token: 0x04000033 RID: 51
		private global::NPOI.XWPF.Usermodel.XWPFOMathArg deg;

		// Token: 0x04000034 RID: 52
		private global::NPOI.XWPF.Usermodel.XWPFOMathArg e;
	}
}
