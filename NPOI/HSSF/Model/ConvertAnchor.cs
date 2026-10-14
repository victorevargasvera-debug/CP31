using System;
using NPOI.DDF;
using NPOI.HSSF.UserModel;

namespace NPOI.HSSF.Model
{
	// Token: 0x0200032E RID: 814
	public class ConvertAnchor
	{
		// Token: 0x06001721 RID: 5921 RVA: 0x00044DE0 File Offset: 0x00042FE0
		public static global::NPOI.DDF.EscherRecord CreateAnchor(global::NPOI.HSSF.UserModel.HSSFAnchor userAnchor)
		{
			if (userAnchor is global::NPOI.HSSF.UserModel.HSSFClientAnchor)
			{
				global::NPOI.HSSF.UserModel.HSSFClientAnchor hssfclientAnchor = (global::NPOI.HSSF.UserModel.HSSFClientAnchor)userAnchor;
				return new global::NPOI.DDF.EscherClientAnchorRecord
				{
					RecordId = -4080,
					Options = 0,
					Flag = (short)hssfclientAnchor.AnchorType,
					Col1 = (short)global::System.Math.Min(hssfclientAnchor.Col1, hssfclientAnchor.Col2),
					Dx1 = (short)hssfclientAnchor.Dx1,
					Row1 = (short)global::System.Math.Min(hssfclientAnchor.Row1, hssfclientAnchor.Row2),
					Dy1 = (short)hssfclientAnchor.Dy1,
					Col2 = (short)global::System.Math.Max(hssfclientAnchor.Col1, hssfclientAnchor.Col2),
					Dx2 = (short)hssfclientAnchor.Dx2,
					Row2 = (short)global::System.Math.Max(hssfclientAnchor.Row1, hssfclientAnchor.Row2),
					Dy2 = (short)hssfclientAnchor.Dy2
				};
			}
			global::NPOI.HSSF.UserModel.HSSFChildAnchor hssfchildAnchor = (global::NPOI.HSSF.UserModel.HSSFChildAnchor)userAnchor;
			return new global::NPOI.DDF.EscherChildAnchorRecord
			{
				RecordId = -4081,
				Options = 0,
				Dx1 = (int)((short)global::System.Math.Min(hssfchildAnchor.Dx1, hssfchildAnchor.Dx2)),
				Dy1 = (int)((short)global::System.Math.Min(hssfchildAnchor.Dy1, hssfchildAnchor.Dy2)),
				Dx2 = (int)((short)global::System.Math.Max(hssfchildAnchor.Dx2, hssfchildAnchor.Dx1)),
				Dy2 = (int)((short)global::System.Math.Max(hssfchildAnchor.Dy2, hssfchildAnchor.Dy1))
			};
		}
	}
}
