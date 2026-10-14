using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x0200004A RID: 74
	public class BuiltinFormats
	{
		// Token: 0x0600029D RID: 669 RVA: 0x0000AE29 File Offset: 0x00009029
		public static string[] GetAll()
		{
			return (string[])global::NPOI.SS.UserModel.BuiltinFormats._formats.Clone();
		}

		// Token: 0x0600029E RID: 670 RVA: 0x0000AE3A File Offset: 0x0000903A
		public static string GetBuiltinFormat(int index)
		{
			if (index < 0 || index >= global::NPOI.SS.UserModel.BuiltinFormats._formats.Length)
			{
				return null;
			}
			return global::NPOI.SS.UserModel.BuiltinFormats._formats[index];
		}

		// Token: 0x0600029F RID: 671 RVA: 0x0000AE54 File Offset: 0x00009054
		public static int GetBuiltinFormat(string pFmt)
		{
			string value = "TEXT".Equals(pFmt, global::System.StringComparison.OrdinalIgnoreCase) ? "@" : pFmt;
			int num = -1;
			foreach (string text in global::NPOI.SS.UserModel.BuiltinFormats._formats)
			{
				num++;
				if (text.Equals(value))
				{
					return num;
				}
			}
			return -1;
		}

		// Token: 0x0400015E RID: 350
		public const int FIRST_USER_DEFINED_FORMAT_INDEX = 164;

		// Token: 0x0400015F RID: 351
		private static string[] _formats = new string[]
		{
			"General",
			"0",
			"0.00",
			"#,##0",
			"#,##0.00",
			"\"$\"#,##0_);(\"$\"#,##0)",
			"\"$\"#,##0_);[Red](\"$\"#,##0)",
			"\"$\"#,##0.00_);(\"$\"#,##0.00)",
			"\"$\"#,##0.00_);[Red](\"$\"#,##0.00)",
			"0%",
			"0.00%",
			"0.00E+00",
			"# ?/?",
			"# ??/??",
			"m/d/yy",
			"d-mmm-yy",
			"d-mmm",
			"mmm-yy",
			"h:mm AM/PM",
			"h:mm:ss AM/PM",
			"h:mm",
			"h:mm:ss",
			"m/d/yy h:mm",
			"reserved-0x17",
			"reserved-0x18",
			"reserved-0x19",
			"reserved-0x1A",
			"reserved-0x1B",
			"reserved-0x1C",
			"reserved-0x1D",
			"reserved-0x1E",
			"reserved-0x1F",
			"reserved-0x20",
			"reserved-0x21",
			"reserved-0x22",
			"reserved-0x23",
			"reserved-0x24",
			"#,##0_);(#,##0)",
			"#,##0_);[Red](#,##0)",
			"#,##0.00_);(#,##0.00)",
			"#,##0.00_);[Red](#,##0.00)",
			"_(\"$\"* #,##0_);_(\"$\"* (#,##0);_(\"$\"* \"-\"_);_(@_)",
			"_(* #,##0_);_(* (#,##0);_(* \"-\"_);_(@_)",
			"_(* #,##0.00_);_(* (#,##0.00);_(* \"-\"??_);_(@_)",
			"_(\"$\"* #,##0.00_);_(\"$\"* (#,##0.00);_(\"$\"* \"-\"??_);_(@_)",
			"mm:ss",
			"[h]:mm:ss",
			"mm:ss.0",
			"##0.0E+0",
			"@"
		};
	}
}
