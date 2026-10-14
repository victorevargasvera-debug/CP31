using System;
using System.Text;
using NPOI.SS.UserModel;

namespace NPOI.SS.Util
{
	// Token: 0x0200002F RID: 47
	public class WorkbookUtil
	{
		// Token: 0x060001DE RID: 478 RVA: 0x00008C7C File Offset: 0x00006E7C
		public static string CreateSafeSheetName(string nameProposal)
		{
			return global::NPOI.SS.Util.WorkbookUtil.CreateSafeSheetName(nameProposal, ' ');
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00008C88 File Offset: 0x00006E88
		public static string CreateSafeSheetName(string nameProposal, char replaceChar)
		{
			if (nameProposal == null)
			{
				return "null";
			}
			if (nameProposal.Length < 1)
			{
				return "empty";
			}
			int num = global::System.Math.Min(31, nameProposal.Length);
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(nameProposal.Substring(0, num));
			int i = 0;
			while (i < num)
			{
				char c = stringBuilder[i];
				if (c <= '*')
				{
					if (c <= '\u0003')
					{
						if (c == '\0' || c == '\u0003')
						{
							goto IL_8B;
						}
					}
					else if (c != '\'')
					{
						if (c == '*')
						{
							goto IL_8B;
						}
					}
					else if (i == 0 || i == num - 1)
					{
						stringBuilder[i] = replaceChar;
					}
				}
				else if (c <= ':')
				{
					if (c == '/' || c == ':')
					{
						goto IL_8B;
					}
				}
				else
				{
					if (c == '?')
					{
						goto IL_8B;
					}
					switch (c)
					{
					case '[':
					case '\\':
					case ']':
						goto IL_8B;
					}
				}
				IL_A6:
				i++;
				continue;
				IL_8B:
				stringBuilder[i] = replaceChar;
				goto IL_A6;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00008D4C File Offset: 0x00006F4C
		public static void ValidateSheetName(string sheetName)
		{
			if (sheetName == null)
			{
				throw new global::System.ArgumentException("sheetName must not be null");
			}
			int length = sheetName.Length;
			if (length < 1 || length > 31)
			{
				throw new global::System.ArgumentException("sheetName '" + sheetName + "' is invalid - character count MUST be greater than or equal to 1 and less than or equal to 31");
			}
			int i = 0;
			while (i < length)
			{
				char c = sheetName[i];
				if (c <= '/')
				{
					if (c == '*' || c == '/')
					{
						goto IL_75;
					}
				}
				else
				{
					if (c == ':' || c == '?')
					{
						goto IL_75;
					}
					switch (c)
					{
					case '[':
					case '\\':
					case ']':
						goto IL_75;
					}
				}
				i++;
				continue;
				IL_75:
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"Invalid char (",
					c.ToString(),
					") found at index (",
					i.ToString(),
					") in sheet name '",
					sheetName,
					"'"
				}));
			}
			if (sheetName[0] == '\'' || sheetName[length - 1] == '\'')
			{
				throw new global::System.ArgumentException("Invalid sheet name '" + sheetName + "'. Sheet names must not begin or end with (').");
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00008E50 File Offset: 0x00007050
		public static void ValidateSheetState(global::NPOI.SS.UserModel.SheetState state)
		{
			switch (state)
			{
			case global::NPOI.SS.UserModel.SheetState.Visible:
			case global::NPOI.SS.UserModel.SheetState.Hidden:
			case global::NPOI.SS.UserModel.SheetState.VeryHidden:
				return;
			default:
				throw new global::System.ArgumentException("Ivalid sheet state : " + state.ToString() + "\nSheet state must beone of the Workbook.SHEET_STATE_* constants");
			}
		}
	}
}
