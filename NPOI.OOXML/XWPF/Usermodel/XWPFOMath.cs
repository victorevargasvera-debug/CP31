using System;
using NPOI.OpenXmlFormats.Shared;
using NPOI.XWPF.Usermodel;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x02000041 RID: 65
	public class XWPFOMath : global::NPOI.XWPF.Usermodel.MathContainer
	{
		// Token: 0x170000AF RID: 175
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00008A03 File Offset: 0x00006C03
		protected global::NPOI.OpenXmlFormats.Shared.CT_OMath oMath
		{
			get
			{
				return (global::NPOI.OpenXmlFormats.Shared.CT_OMath)this.container;
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00004A79 File Offset: 0x00002C79
		public XWPFOMath(global::NPOI.OpenXmlFormats.Shared.CT_OMath oMath, global::NPOI.XWPF.UserModel.IRunBody p) : base(oMath, p)
		{
		}
	}
}
