using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using NPOI.SS.Formula.Constant;
using NPOI.SS.Formula.Function;
using NPOI.SS.Formula.PTG;
using NPOI.SS.UserModel;
using NPOI.SS.Util;

namespace NPOI.SS.Formula
{
	// Token: 0x020000C8 RID: 200
	public class FormulaParser
	{
		// Token: 0x060006A0 RID: 1696 RVA: 0x0000F770 File Offset: 0x0000D970
		public FormulaParser(string formula, global::NPOI.SS.Formula.IFormulaParsingWorkbook book, int sheetIndex, int rowIndex)
		{
			this._formulaString = formula;
			this._pointer = 0;
			this._book = book;
			global::NPOI.SS.Formula.FormulaParser._ssVersion = ((book == null) ? global::NPOI.SS.SpreadsheetVersion.EXCEL97 : book.GetSpreadsheetVersion());
			this._formulaLength = this._formulaString.Length;
			this._sheetIndex = sheetIndex;
			this._rowIndex = rowIndex;
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x0000F7D8 File Offset: 0x0000D9D8
		public static global::NPOI.SS.Formula.PTG.Ptg[] Parse(string formula, global::NPOI.SS.Formula.IFormulaParsingWorkbook workbook, global::NPOI.SS.Formula.FormulaType formulaType, int sheetIndex, int rowIndex)
		{
			global::NPOI.SS.Formula.FormulaParser formulaParser = new global::NPOI.SS.Formula.FormulaParser(formula, workbook, sheetIndex, rowIndex);
			formulaParser.Parse();
			return formulaParser.GetRPNPtg(formulaType);
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x0000F7F0 File Offset: 0x0000D9F0
		public static global::NPOI.SS.Formula.PTG.Ptg[] Parse(string formula, global::NPOI.SS.Formula.IFormulaParsingWorkbook workbook, global::NPOI.SS.Formula.FormulaType formulaType, int sheetIndex)
		{
			return global::NPOI.SS.Formula.FormulaParser.Parse(formula, workbook, formulaType, sheetIndex, -1);
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0000F7FC File Offset: 0x0000D9FC
		public static global::NPOI.SS.Formula.PTG.Area3DPxg ParseStructuredReference(string tableText, global::NPOI.SS.Formula.IFormulaParsingWorkbook workbook, int rowIndex)
		{
			global::NPOI.SS.Formula.PTG.Ptg[] array = global::NPOI.SS.Formula.FormulaParser.Parse(tableText, workbook, global::NPOI.SS.Formula.FormulaType.Cell, 0, rowIndex);
			if (array.Length != 1 || !(array[0] is global::NPOI.SS.Formula.PTG.Area3DPxg))
			{
				throw new global::System.InvalidOperationException("Illegal structured reference");
			}
			return (global::NPOI.SS.Formula.PTG.Area3DPxg)array[0];
		}

		// Token: 0x060006A4 RID: 1700 RVA: 0x0000F838 File Offset: 0x0000DA38
		private void GetChar()
		{
			if (global::NPOI.SS.Formula.FormulaParser.IsWhite(this.look))
			{
				if (this.look == ' ')
				{
					this._inIntersection = true;
				}
			}
			else
			{
				this._inIntersection = false;
			}
			if (this._pointer > this._formulaLength)
			{
				throw new global::System.Exception("too far");
			}
			if (this._pointer < this._formulaLength)
			{
				this.look = this._formulaString[this._pointer];
			}
			else
			{
				this.look = '\0';
				this._inIntersection = false;
			}
			this._pointer++;
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x0000F8C8 File Offset: 0x0000DAC8
		private global::System.Exception expected(string s)
		{
			string msg;
			if (this.look == '=' && this._formulaString.Substring(0, this._pointer - 1).Trim().Length < 1)
			{
				msg = "The specified formula '" + this._formulaString + "' starts with an equals sign which is not allowed.";
			}
			else
			{
				msg = string.Concat(new string[]
				{
					"Parse error near char ",
					(this._pointer - 1).ToString(),
					" '",
					this.look.ToString(),
					"' in specified formula '",
					this._formulaString,
					"'. Expected ",
					s
				});
			}
			return new global::NPOI.SS.Formula.FormulaParseException(msg);
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0000F978 File Offset: 0x0000DB78
		private static bool IsAlpha(char c)
		{
			return char.IsLetter(c) || c == '$' || c == '_';
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x0000F98E File Offset: 0x0000DB8E
		private static bool IsDigit(char c)
		{
			return char.IsDigit(c);
		}

		// Token: 0x060006A8 RID: 1704 RVA: 0x0000F996 File Offset: 0x0000DB96
		private static bool IsAlNum(char c)
		{
			return global::NPOI.SS.Formula.FormulaParser.IsAlpha(c) || global::NPOI.SS.Formula.FormulaParser.IsDigit(c);
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x0000F9A8 File Offset: 0x0000DBA8
		private static bool IsWhite(char c)
		{
			return c == ' ' || c == '\t' || c == '\r' || c == '\n';
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x0000F9C0 File Offset: 0x0000DBC0
		private void SkipWhite()
		{
			while (global::NPOI.SS.Formula.FormulaParser.IsWhite(this.look))
			{
				this.GetChar();
			}
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x0000F9D7 File Offset: 0x0000DBD7
		private void Match(char x)
		{
			if (this.look != x)
			{
				throw this.expected("'" + x.ToString() + "'");
			}
			this.GetChar();
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x0000FA08 File Offset: 0x0000DC08
		private string ParseUnquotedIdentifier()
		{
			if (this.look == '\'')
			{
				throw this.expected("unquoted identifier");
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			while (char.IsLetterOrDigit(this.look) || this.look == '.')
			{
				stringBuilder.Append(this.look);
				this.GetChar();
			}
			if (stringBuilder.Length < 1)
			{
				return null;
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x0000FA70 File Offset: 0x0000DC70
		private string GetNum()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			while (global::NPOI.SS.Formula.FormulaParser.IsDigit(this.look))
			{
				stringBuilder.Append(this.look);
				this.GetChar();
			}
			if (stringBuilder.Length != 0)
			{
				return stringBuilder.ToString();
			}
			return null;
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x0000FAB8 File Offset: 0x0000DCB8
		private global::NPOI.SS.Formula.ParseNode ParseRangeExpression()
		{
			global::NPOI.SS.Formula.ParseNode parseNode = this.ParseRangeable();
			bool flag = false;
			while (this.look == ':')
			{
				int pointer = this._pointer;
				this.GetChar();
				global::NPOI.SS.Formula.ParseNode parseNode2 = this.ParseRangeable();
				this.CheckValidRangeOperand("LHS", pointer, parseNode);
				this.CheckValidRangeOperand("RHS", pointer, parseNode2);
				global::NPOI.SS.Formula.ParseNode[] children = new global::NPOI.SS.Formula.ParseNode[]
				{
					parseNode,
					parseNode2
				};
				parseNode = new global::NPOI.SS.Formula.ParseNode(global::NPOI.SS.Formula.PTG.RangePtg.instance, children);
				flag = true;
			}
			if (flag)
			{
				return global::NPOI.SS.Formula.FormulaParser.AugmentWithMemPtg(parseNode);
			}
			return parseNode;
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x0000FB34 File Offset: 0x0000DD34
		private static global::NPOI.SS.Formula.ParseNode AugmentWithMemPtg(global::NPOI.SS.Formula.ParseNode root)
		{
			global::NPOI.SS.Formula.PTG.Ptg token;
			if (global::NPOI.SS.Formula.FormulaParser.NeedsMemFunc(root))
			{
				token = new global::NPOI.SS.Formula.PTG.MemFuncPtg(root.EncodedSize);
			}
			else
			{
				token = new global::NPOI.SS.Formula.PTG.MemAreaPtg(root.EncodedSize);
			}
			return new global::NPOI.SS.Formula.ParseNode(token, root);
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x0000FB6C File Offset: 0x0000DD6C
		private static bool NeedsMemFunc(global::NPOI.SS.Formula.ParseNode root)
		{
			global::NPOI.SS.Formula.PTG.Ptg token = root.GetToken();
			if (token is global::NPOI.SS.Formula.PTG.AbstractFunctionPtg)
			{
				return true;
			}
			if (token is global::NPOI.SS.Formula.IExternSheetReferenceToken)
			{
				return true;
			}
			if (token is global::NPOI.SS.Formula.PTG.NamePtg || token is global::NPOI.SS.Formula.PTG.NameXPtg)
			{
				return true;
			}
			if (token is global::NPOI.SS.Formula.PTG.OperationPtg || token is global::NPOI.SS.Formula.PTG.ParenthesisPtg)
			{
				global::NPOI.SS.Formula.ParseNode[] children = root.GetChildren();
				for (int i = 0; i < children.Length; i++)
				{
					if (global::NPOI.SS.Formula.FormulaParser.NeedsMemFunc(children[i]))
					{
						return true;
					}
				}
				return false;
			}
			return !(token is global::NPOI.SS.Formula.PTG.OperandPtg) && token is global::NPOI.SS.Formula.PTG.OperationPtg;
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x0000FBEE File Offset: 0x0000DDEE
		private static bool IsValidDefinedNameChar(char ch)
		{
			if (char.IsLetterOrDigit(ch))
			{
				return true;
			}
			if (ch <= '?')
			{
				if (ch != '.' && ch != '?')
				{
					return false;
				}
			}
			else if (ch != '\\' && ch != '_')
			{
				return false;
			}
			return true;
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x0000FC18 File Offset: 0x0000DE18
		private void CheckValidRangeOperand(string sideName, int currentParsePosition, global::NPOI.SS.Formula.ParseNode pn)
		{
			if (!this.IsValidRangeOperand(pn))
			{
				throw new global::NPOI.SS.Formula.FormulaParseException(string.Concat(new string[]
				{
					"The ",
					sideName,
					" of the range operator ':' at position ",
					currentParsePosition.ToString(),
					" is not a proper reference."
				}));
			}
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x0000FC68 File Offset: 0x0000DE68
		private bool IsValidRangeOperand(global::NPOI.SS.Formula.ParseNode a)
		{
			global::NPOI.SS.Formula.PTG.Ptg token = a.GetToken();
			if (token is global::NPOI.SS.Formula.PTG.OperandPtg)
			{
				return true;
			}
			if (token is global::NPOI.SS.Formula.PTG.AbstractFunctionPtg)
			{
				byte defaultOperandClass = ((global::NPOI.SS.Formula.PTG.AbstractFunctionPtg)token).DefaultOperandClass;
				return defaultOperandClass == 0;
			}
			if (token is global::NPOI.SS.Formula.PTG.ValueOperatorPtg)
			{
				return false;
			}
			if (token is global::NPOI.SS.Formula.PTG.OperationPtg)
			{
				return true;
			}
			if (token is global::NPOI.SS.Formula.PTG.ParenthesisPtg)
			{
				return this.IsValidRangeOperand(a.GetChildren()[0]);
			}
			return token == global::NPOI.SS.Formula.PTG.ErrPtg.REF_INVALID;
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x0000FCD8 File Offset: 0x0000DED8
		private global::NPOI.SS.Formula.ParseNode ParseRangeable()
		{
			this.SkipWhite();
			int pointer = this._pointer;
			global::NPOI.SS.Formula.SheetIdentifier sheetIdentifier = this.ParseSheetName();
			if (sheetIdentifier == null)
			{
				this.ResetPointer(pointer);
			}
			else
			{
				this.SkipWhite();
				pointer = this._pointer;
			}
			global::NPOI.SS.Formula.FormulaParser.SimpleRangePart simpleRangePart = this.ParseSimpleRangePart();
			if (simpleRangePart == null)
			{
				if (sheetIdentifier == null)
				{
					return this.ParseNonRange(pointer);
				}
				if (this.look == '#')
				{
					return new global::NPOI.SS.Formula.ParseNode(global::NPOI.SS.Formula.PTG.ErrPtg.ValueOf(this.ParseErrorLiteral()));
				}
				string text = this.ParseAsName();
				if (text.Length == 0)
				{
					throw new global::NPOI.SS.Formula.FormulaParseException("Cell reference or Named Range expected after sheet name at index " + this._pointer.ToString() + ".");
				}
				global::NPOI.SS.Formula.PTG.Ptg nameXPtg = this._book.GetNameXPtg(text, sheetIdentifier);
				if (nameXPtg == null)
				{
					throw new global::NPOI.SS.Formula.FormulaParseException(string.Concat(new string[]
					{
						"Specified name '",
						text,
						"' for sheet ",
						sheetIdentifier.AsFormulaString(),
						" not found"
					}));
				}
				return new global::NPOI.SS.Formula.ParseNode(nameXPtg);
			}
			else
			{
				bool flag = global::NPOI.SS.Formula.FormulaParser.IsWhite(this.look);
				if (flag)
				{
					this.SkipWhite();
				}
				if (this.look == ':')
				{
					int pointer2 = this._pointer;
					this.GetChar();
					this.SkipWhite();
					global::NPOI.SS.Formula.FormulaParser.SimpleRangePart simpleRangePart2 = this.ParseSimpleRangePart();
					if (simpleRangePart2 != null && !simpleRangePart.IsCompatibleForArea(simpleRangePart2))
					{
						simpleRangePart2 = null;
					}
					if (simpleRangePart2 != null)
					{
						return this.CreateAreaRefParseNode(sheetIdentifier, simpleRangePart, simpleRangePart2);
					}
					this.ResetPointer(pointer2);
					if (!simpleRangePart.IsCell)
					{
						string str;
						if (sheetIdentifier == null)
						{
							str = "";
						}
						else
						{
							str = "'" + sheetIdentifier.SheetId.Name + "!";
						}
						throw new global::NPOI.SS.Formula.FormulaParseException(str + simpleRangePart.Rep + "' is not a proper reference.");
					}
					return this.CreateAreaRefParseNode(sheetIdentifier, simpleRangePart, simpleRangePart2);
				}
				else if (this.look == '.')
				{
					this.GetChar();
					int num = 1;
					while (this.look == '.')
					{
						num++;
						this.GetChar();
					}
					bool flag2 = global::NPOI.SS.Formula.FormulaParser.IsWhite(this.look);
					this.SkipWhite();
					global::NPOI.SS.Formula.FormulaParser.SimpleRangePart simpleRangePart3 = this.ParseSimpleRangePart();
					string str2 = this._formulaString.Substring(pointer - 1, this._pointer - pointer);
					if (simpleRangePart3 == null)
					{
						if (sheetIdentifier != null)
						{
							throw new global::NPOI.SS.Formula.FormulaParseException("Complete area reference expected after sheet name at index " + this._pointer.ToString() + ".");
						}
						return this.ParseNonRange(pointer);
					}
					else if (flag || flag2)
					{
						if (simpleRangePart.IsRowOrColumn || simpleRangePart3.IsRowOrColumn)
						{
							throw new global::NPOI.SS.Formula.FormulaParseException("Dotted range (full row or column) expression '" + str2 + "' must not contain whitespace.");
						}
						return this.CreateAreaRefParseNode(sheetIdentifier, simpleRangePart, simpleRangePart3);
					}
					else
					{
						if (num == 1 && simpleRangePart.IsRow && simpleRangePart3.IsRow)
						{
							return this.ParseNonRange(pointer);
						}
						if ((simpleRangePart.IsRowOrColumn || simpleRangePart3.IsRowOrColumn) && num != 2)
						{
							throw new global::NPOI.SS.Formula.FormulaParseException("Dotted range (full row or column) expression '" + str2 + "' must have exactly 2 dots.");
						}
						return this.CreateAreaRefParseNode(sheetIdentifier, simpleRangePart, simpleRangePart3);
					}
				}
				else
				{
					if (simpleRangePart.IsCell && this.IsValidCellReference(simpleRangePart.Rep))
					{
						return this.CreateAreaRefParseNode(sheetIdentifier, simpleRangePart, null);
					}
					if (sheetIdentifier != null)
					{
						throw new global::NPOI.SS.Formula.FormulaParseException("Second part of cell reference expected after sheet name at index " + this._pointer.ToString() + ".");
					}
					return this.ParseNonRange(pointer);
				}
			}
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x0000FFF0 File Offset: 0x0000E1F0
		private global::NPOI.SS.Formula.ParseNode ParseStructuredReference(string tableName)
		{
			if (!global::NPOI.SS.Formula.FormulaParser._ssVersion.Equals(global::NPOI.SS.SpreadsheetVersion.EXCEL2007))
			{
				throw new global::NPOI.SS.Formula.FormulaParseException("Strctured references work only on XSSF (Excel 2007)!");
			}
			global::NPOI.SS.UserModel.ITable table = this._book.GetTable(tableName);
			if (table == null)
			{
				throw new global::NPOI.SS.Formula.FormulaParseException("Illegal table name: '" + tableName + "'");
			}
			string sheetName = table.SheetName;
			int startColIndex = table.StartColIndex;
			int endColIndex = table.EndColIndex;
			int startRowIndex = table.StartRowIndex;
			int endRowIndex = table.EndRowIndex;
			int pointer = this._pointer;
			this.GetChar();
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			bool flag5 = false;
			int num = 0;
			int pointer2;
			string text;
			for (;;)
			{
				pointer2 = this._pointer;
				text = this.ParseAsSpecialQuantifier();
				if (text == null)
				{
					break;
				}
				if (text.Equals(global::NPOI.SS.Formula.FormulaParser.specAll))
				{
					flag5 = true;
				}
				else if (text.Equals(global::NPOI.SS.Formula.FormulaParser.specData))
				{
					flag3 = true;
				}
				else if (text.Equals(global::NPOI.SS.Formula.FormulaParser.specHeaders))
				{
					flag4 = true;
				}
				else if (text.Equals(global::NPOI.SS.Formula.FormulaParser.specThisRow))
				{
					flag2 = true;
				}
				else
				{
					if (!text.Equals(global::NPOI.SS.Formula.FormulaParser.specTotals))
					{
						goto IL_107;
					}
					flag = true;
				}
				num++;
				if (this.look != ',')
				{
					goto IL_134;
				}
				this.GetChar();
			}
			this.ResetPointer(pointer2);
			goto IL_134;
			IL_107:
			throw new global::NPOI.SS.Formula.FormulaParseException("Unknown special quantifier " + text);
			IL_134:
			bool flag6 = false;
			this.SkipWhite();
			if (this.look == '@')
			{
				flag6 = true;
				this.GetChar();
			}
			string text2 = null;
			int num2 = 0;
			pointer2 = this._pointer;
			string text3 = this.ParseAsColumnQuantifier();
			if (text3 == null)
			{
				this.ResetPointer(pointer2);
			}
			else
			{
				num2++;
				if (this.look == ',')
				{
					throw new global::NPOI.SS.Formula.FormulaParseException("The formula " + this._formulaString + "is illegal: you should not use ',' with column quantifiers");
				}
				if (this.look == ':')
				{
					this.GetChar();
					text2 = this.ParseAsColumnQuantifier();
					num2++;
					if (text2 == null)
					{
						throw new global::NPOI.SS.Formula.FormulaParseException("The formula " + this._formulaString + "is illegal: the string after ':' must be column quantifier");
					}
				}
			}
			if (num2 == 0 && num == 0)
			{
				this.ResetPointer(pointer);
				pointer = this._pointer;
				text3 = this.ParseAsColumnQuantifier();
				if (text3 != null)
				{
					num2++;
				}
				else
				{
					this.ResetPointer(pointer);
					string text4 = this.ParseAsSpecialQuantifier();
					if (text4 == null)
					{
						throw new global::NPOI.SS.Formula.FormulaParseException("The formula " + this._formulaString + " is illegal");
					}
					if (text4.Equals(global::NPOI.SS.Formula.FormulaParser.specAll))
					{
						flag5 = true;
					}
					else if (text4.Equals(global::NPOI.SS.Formula.FormulaParser.specData))
					{
						flag3 = true;
					}
					else if (text4.Equals(global::NPOI.SS.Formula.FormulaParser.specHeaders))
					{
						flag4 = true;
					}
					else if (text4.Equals(global::NPOI.SS.Formula.FormulaParser.specThisRow))
					{
						flag2 = true;
					}
					else
					{
						if (!text4.Equals(global::NPOI.SS.Formula.FormulaParser.specTotals))
						{
							throw new global::NPOI.SS.Formula.FormulaParseException("Unknown special quantifier " + text4);
						}
						flag = true;
					}
					num++;
				}
			}
			else
			{
				this.Match(']');
			}
			if (flag && !table.IsHasTotalsRow)
			{
				return new global::NPOI.SS.Formula.ParseNode(global::NPOI.SS.Formula.PTG.ErrPtg.REF_INVALID);
			}
			if ((!flag6 && !flag2) || (this._rowIndex >= startRowIndex && endRowIndex >= this._rowIndex))
			{
				int num3 = startRowIndex;
				int num4 = endRowIndex;
				int num5 = startColIndex;
				int pCol = endColIndex;
				if (num > 0)
				{
					if (num != 1 || !flag5)
					{
						if (flag3 && flag4)
						{
							if (table.IsHasTotalsRow)
							{
								num4 = endRowIndex - 1;
							}
						}
						else if (flag3 && flag)
						{
							num3 = startRowIndex + 1;
						}
						else if (num == 1 && flag3)
						{
							num3 = startRowIndex + 1;
							if (table.IsHasTotalsRow)
							{
								num4 = endRowIndex - 1;
							}
						}
						else if (num == 1 && flag4)
						{
							num4 = num3;
						}
						else if (num == 1 && flag)
						{
							num3 = num4;
						}
						else
						{
							if ((num != 1 || !flag2) && !flag6)
							{
								throw new global::NPOI.SS.Formula.FormulaParseException("The formula " + this._formulaString + " is illegal");
							}
							num3 = this._rowIndex;
							num4 = this._rowIndex;
						}
					}
				}
				else if (flag6)
				{
					num3 = this._rowIndex;
					num4 = this._rowIndex;
				}
				else
				{
					num3++;
				}
				if (num2 == 2)
				{
					if (text3 == null || text2 == null)
					{
						throw new global::System.InvalidOperationException("Fatal error");
					}
					int num6 = table.FindColumnIndex(text3);
					int num7 = table.FindColumnIndex(text2);
					if (num6 == -1 || num7 == -1)
					{
						throw new global::NPOI.SS.Formula.FormulaParseException(string.Concat(new string[]
						{
							"One of the columns ",
							text3,
							", ",
							text2,
							" doesn't exist in table ",
							table.Name
						}));
					}
					num5 = startColIndex + num6;
					pCol = startColIndex + num7;
				}
				else if (num2 == 1 && !flag6)
				{
					if (text3 == null)
					{
						throw new global::System.InvalidOperationException("Fatal error");
					}
					int num8 = table.FindColumnIndex(text3);
					if (num8 == -1)
					{
						throw new global::NPOI.SS.Formula.FormulaParseException("The column " + text3 + " doesn't exist in table " + table.Name);
					}
					num5 = startColIndex + num8;
					pCol = num5;
				}
				global::NPOI.SS.Util.CellReference topLeft = new global::NPOI.SS.Util.CellReference(num3, num5);
				global::NPOI.SS.Util.CellReference botRight = new global::NPOI.SS.Util.CellReference(num4, pCol);
				global::NPOI.SS.Formula.SheetIdentifier sheet = new global::NPOI.SS.Formula.SheetIdentifier(null, new global::NPOI.SS.Formula.NameIdentifier(sheetName, true));
				return new global::NPOI.SS.Formula.ParseNode(this._book.Get3DReferencePtg(new global::NPOI.SS.Util.AreaReference(topLeft, botRight), sheet));
			}
			if (this._rowIndex >= 0)
			{
				return new global::NPOI.SS.Formula.ParseNode(global::NPOI.SS.Formula.PTG.ErrPtg.VALUE_INVALID);
			}
			throw new global::NPOI.SS.Formula.FormulaParseException("Formula contained [#This Row] or [@] structured reference but this row < 0. Row index must be specified for row-referencing structured references.");
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00010508 File Offset: 0x0000E708
		private string ParseAsColumnQuantifier()
		{
			if (this.look != '[')
			{
				return null;
			}
			this.GetChar();
			if (this.look == '#')
			{
				return null;
			}
			if (this.look == '@')
			{
				this.GetChar();
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			while (this.look != ']')
			{
				stringBuilder.Append(this.look);
				this.GetChar();
			}
			this.Match(']');
			return stringBuilder.ToString();
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00010578 File Offset: 0x0000E778
		private string ParseAsSpecialQuantifier()
		{
			if (this.look != '[')
			{
				return null;
			}
			this.GetChar();
			if (this.look != '#')
			{
				return null;
			}
			this.GetChar();
			string text = this.ParseAsName();
			if (text.Equals("This"))
			{
				text = text + " " + this.ParseAsName();
			}
			this.Match(']');
			return text;
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x000105D8 File Offset: 0x0000E7D8
		private global::NPOI.SS.Formula.ParseNode ParseNonRange(int savePointer)
		{
			this.ResetPointer(savePointer);
			if (char.IsDigit(this.look))
			{
				return new global::NPOI.SS.Formula.ParseNode(this.ParseNumber());
			}
			if (this.look == '"')
			{
				return new global::NPOI.SS.Formula.ParseNode(new global::NPOI.SS.Formula.PTG.StringPtg(this.ParseStringLiteral()));
			}
			string text = this.ParseAsName();
			if (this.look == '(')
			{
				return this.Function(text);
			}
			if (this.look == '[')
			{
				return this.ParseStructuredReference(text);
			}
			if (text.Equals("TRUE", global::System.StringComparison.OrdinalIgnoreCase) || text.Equals("FALSE", global::System.StringComparison.OrdinalIgnoreCase))
			{
				return new global::NPOI.SS.Formula.ParseNode(new global::NPOI.SS.Formula.PTG.BoolPtg(text.ToUpper()));
			}
			if (this._book == null)
			{
				throw new global::System.InvalidOperationException("Need book to evaluate name '" + text + "'");
			}
			global::NPOI.SS.Formula.IEvaluationName name = this._book.GetName(text, this._sheetIndex);
			if (name == null)
			{
				throw new global::NPOI.SS.Formula.FormulaParseException("Specified named range '" + text + "' does not exist in the current workbook.");
			}
			if (name.IsRange)
			{
				return new global::NPOI.SS.Formula.ParseNode(name.CreatePtg());
			}
			throw new global::NPOI.SS.Formula.FormulaParseException("Specified name '" + text + "' is not a range as expected.");
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x000106EC File Offset: 0x0000E8EC
		private string ParseAsName()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			if (!char.IsLetter(this.look) && this.look != '_' && this.look != '\\')
			{
				throw this.expected("number, string, defined name, or data table");
			}
			while (global::NPOI.SS.Formula.FormulaParser.IsValidDefinedNameChar(this.look))
			{
				stringBuilder.Append(this.look);
				this.GetChar();
			}
			this.SkipWhite();
			return stringBuilder.ToString();
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x00010758 File Offset: 0x0000E958
		private int GetSheetExtIx(global::NPOI.SS.Formula.SheetIdentifier sheetIden)
		{
			int result;
			if (sheetIden == null)
			{
				result = int.MaxValue;
			}
			else
			{
				string name = sheetIden.SheetId.Name;
				if (sheetIden.BookName == null)
				{
					result = this._book.GetExternalSheetIndex(name);
				}
				else
				{
					result = this._book.GetExternalSheetIndex(sheetIden.BookName, name);
				}
			}
			return result;
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x000107A8 File Offset: 0x0000E9A8
		private global::NPOI.SS.Formula.ParseNode CreateAreaRefParseNode(global::NPOI.SS.Formula.SheetIdentifier sheetIden, global::NPOI.SS.Formula.FormulaParser.SimpleRangePart part1, global::NPOI.SS.Formula.FormulaParser.SimpleRangePart part2)
		{
			global::NPOI.SS.Formula.PTG.Ptg token;
			if (part2 == null)
			{
				global::NPOI.SS.Util.CellReference cellReference = part1.CellReference;
				if (sheetIden == null)
				{
					token = new global::NPOI.SS.Formula.PTG.RefPtg(cellReference);
				}
				else
				{
					token = this._book.Get3DReferencePtg(cellReference, sheetIden);
				}
			}
			else
			{
				global::NPOI.SS.Util.AreaReference areaReference = global::NPOI.SS.Formula.FormulaParser.CreateAreaRef(part1, part2);
				if (sheetIden == null)
				{
					token = new global::NPOI.SS.Formula.PTG.AreaPtg(areaReference);
				}
				else
				{
					token = this._book.Get3DReferencePtg(areaReference, sheetIden);
				}
			}
			return new global::NPOI.SS.Formula.ParseNode(token);
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00010804 File Offset: 0x0000EA04
		private static global::NPOI.SS.Util.AreaReference CreateAreaRef(global::NPOI.SS.Formula.FormulaParser.SimpleRangePart part1, global::NPOI.SS.Formula.FormulaParser.SimpleRangePart part2)
		{
			if (!part1.IsCompatibleForArea(part2))
			{
				throw new global::NPOI.SS.Formula.FormulaParseException(string.Concat(new string[]
				{
					"has incompatible parts: '",
					part1.Rep,
					"' and '",
					part2.Rep,
					"'."
				}));
			}
			if (part1.IsRow)
			{
				return global::NPOI.SS.Util.AreaReference.GetWholeRow(global::NPOI.SS.Formula.FormulaParser._ssVersion, part1.Rep, part2.Rep);
			}
			if (part1.IsColumn)
			{
				return global::NPOI.SS.Util.AreaReference.GetWholeColumn(global::NPOI.SS.Formula.FormulaParser._ssVersion, part1.Rep, part2.Rep);
			}
			return new global::NPOI.SS.Util.AreaReference(part1.CellReference, part2.CellReference);
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x000108A4 File Offset: 0x0000EAA4
		private global::NPOI.SS.Formula.FormulaParser.SimpleRangePart ParseSimpleRangePart()
		{
			int i = this._pointer - 1;
			bool flag = false;
			bool flag2 = false;
			while (i < this._formulaLength)
			{
				char c = this._formulaString[i];
				if (char.IsDigit(c))
				{
					flag = true;
				}
				else if (char.IsLetter(c))
				{
					flag2 = true;
				}
				else if (c != '$' && c != '_')
				{
					break;
				}
				i++;
			}
			if (i <= this._pointer - 1)
			{
				return null;
			}
			string text = this._formulaString.Substring(this._pointer - 1, i - this._pointer + 1);
			if (!new global::System.Text.RegularExpressions.Regex(this.CELL_REF_PATTERN).IsMatch(text))
			{
				return null;
			}
			if (flag2 && flag)
			{
				if (!this.IsValidCellReference(text))
				{
					return null;
				}
			}
			else if (flag2)
			{
				if (!global::NPOI.SS.Util.CellReference.IsColumnWithinRange(text.Replace("$", ""), global::NPOI.SS.Formula.FormulaParser._ssVersion))
				{
					return null;
				}
			}
			else
			{
				if (flag)
				{
					int num;
					try
					{
						num = int.Parse(text.Replace("$", ""), global::System.Globalization.CultureInfo.InvariantCulture);
					}
					catch (global::System.Exception)
					{
						return null;
					}
					if (num < 1 || num > global::NPOI.SS.Formula.FormulaParser._ssVersion.MaxRows)
					{
						return null;
					}
					goto IL_FF;
				}
				return null;
			}
			IL_FF:
			this.ResetPointer(i + 1);
			return new global::NPOI.SS.Formula.FormulaParser.SimpleRangePart(text, flag2, flag);
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x000109D4 File Offset: 0x0000EBD4
		private static global::NPOI.SS.Formula.PTG.Ptg ReduceRangeExpression(global::NPOI.SS.Formula.PTG.Ptg ptgA, global::NPOI.SS.Formula.PTG.Ptg ptgB)
		{
			if (!(ptgB is global::NPOI.SS.Formula.PTG.RefPtg))
			{
				return null;
			}
			global::NPOI.SS.Formula.PTG.RefPtg refPtg = (global::NPOI.SS.Formula.PTG.RefPtg)ptgB;
			if (ptgA is global::NPOI.SS.Formula.PTG.RefPtg)
			{
				global::NPOI.SS.Formula.PTG.RefPtg refPtg2 = (global::NPOI.SS.Formula.PTG.RefPtg)ptgA;
				return new global::NPOI.SS.Formula.PTG.AreaPtg(refPtg2.Row, refPtg.Row, refPtg2.Column, refPtg.Column, refPtg2.IsRowRelative, refPtg.IsRowRelative, refPtg2.IsColRelative, refPtg.IsColRelative);
			}
			if (ptgA is global::NPOI.SS.Formula.PTG.Ref3DPtg)
			{
				global::NPOI.SS.Formula.PTG.Ref3DPtg ref3DPtg = (global::NPOI.SS.Formula.PTG.Ref3DPtg)ptgA;
				return new global::NPOI.SS.Formula.PTG.Area3DPtg(ref3DPtg.Row, refPtg.Row, ref3DPtg.Column, refPtg.Column, ref3DPtg.IsRowRelative, refPtg.IsRowRelative, ref3DPtg.IsColRelative, refPtg.IsColRelative, ref3DPtg.ExternSheetIndex);
			}
			return null;
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00010A84 File Offset: 0x0000EC84
		private global::NPOI.SS.Formula.SheetIdentifier ParseSheetName()
		{
			string text;
			if (this.look == '[')
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				this.GetChar();
				while (this.look != ']')
				{
					stringBuilder.Append(this.look);
					this.GetChar();
				}
				this.GetChar();
				text = stringBuilder.ToString();
			}
			else
			{
				text = null;
			}
			if (this.look == '\'')
			{
				global::System.Text.StringBuilder stringBuilder2 = new global::System.Text.StringBuilder();
				this.Match('\'');
				bool flag = this.look == '\'';
				while (!flag)
				{
					stringBuilder2.Append(this.look);
					this.GetChar();
					if (this.look == '\'')
					{
						this.Match('\'');
						flag = (this.look != '\'');
					}
				}
				global::NPOI.SS.Formula.NameIdentifier nameIdentifier = new global::NPOI.SS.Formula.NameIdentifier(stringBuilder2.ToString(), true);
				this.SkipWhite();
				if (this.look == '!')
				{
					this.GetChar();
					return new global::NPOI.SS.Formula.SheetIdentifier(text, nameIdentifier);
				}
				if (this.look == ':')
				{
					return this.ParseSheetRange(text, nameIdentifier);
				}
				return null;
			}
			else if (this.look == '_' || char.IsLetter(this.look))
			{
				global::System.Text.StringBuilder stringBuilder3 = new global::System.Text.StringBuilder();
				while (this.IsUnquotedSheetNameChar(this.look))
				{
					stringBuilder3.Append(this.look);
					this.GetChar();
				}
				global::NPOI.SS.Formula.NameIdentifier nameIdentifier2 = new global::NPOI.SS.Formula.NameIdentifier(stringBuilder3.ToString(), false);
				this.SkipWhite();
				if (this.look == '!')
				{
					this.GetChar();
					return new global::NPOI.SS.Formula.SheetIdentifier(text, nameIdentifier2);
				}
				if (this.look == ':')
				{
					return this.ParseSheetRange(text, nameIdentifier2);
				}
				return null;
			}
			else
			{
				if (this.look == '!' && text != null)
				{
					this.GetChar();
					return new global::NPOI.SS.Formula.SheetIdentifier(text, null);
				}
				return null;
			}
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00010C1C File Offset: 0x0000EE1C
		private global::NPOI.SS.Formula.SheetIdentifier ParseSheetRange(string bookname, global::NPOI.SS.Formula.NameIdentifier sheet1Name)
		{
			this.GetChar();
			global::NPOI.SS.Formula.SheetIdentifier sheetIdentifier = this.ParseSheetName();
			if (sheetIdentifier != null)
			{
				return new global::NPOI.SS.Formula.SheetRangeIdentifier(bookname, sheet1Name, sheetIdentifier._sheetIdentifier);
			}
			return null;
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00010C48 File Offset: 0x0000EE48
		private bool IsUnquotedSheetNameChar(char ch)
		{
			return char.IsLetterOrDigit(ch) || (ch == '.' || ch == '_');
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00010C61 File Offset: 0x0000EE61
		private void ResetPointer(int ptr)
		{
			this._pointer = ptr;
			if (this._pointer <= this._formulaLength)
			{
				this.look = this._formulaString[this._pointer - 1];
				return;
			}
			this.look = '\0';
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00010C9C File Offset: 0x0000EE9C
		private bool IsValidCellReference(string str)
		{
			bool flag = global::NPOI.SS.Util.CellReference.ClassifyCellReference(str, global::NPOI.SS.Formula.FormulaParser._ssVersion) == global::NPOI.SS.Util.NameType.Cell;
			if (flag && global::NPOI.SS.Formula.Function.FunctionMetadataRegistry.GetFunctionByName(str.ToUpper()) != null)
			{
				int pointer = this._pointer;
				this.ResetPointer(this._pointer + str.Length);
				this.SkipWhite();
				flag = (this.look != '(');
				this.ResetPointer(pointer);
			}
			return flag;
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00010D04 File Offset: 0x0000EF04
		private global::NPOI.SS.Formula.ParseNode Function(string name)
		{
			global::NPOI.SS.Formula.PTG.Ptg ptg = null;
			if (!global::NPOI.SS.Formula.PTG.AbstractFunctionPtg.IsBuiltInFunctionName(name))
			{
				if (this._book == null)
				{
					throw new global::System.InvalidOperationException("Need book to evaluate name '" + name + "'");
				}
				global::NPOI.SS.Formula.IEvaluationName name2 = this._book.GetName(name, this._sheetIndex);
				if (name2 != null)
				{
					if (!name2.IsFunctionName)
					{
						throw new global::NPOI.SS.Formula.FormulaParseException("Attempt to use name '" + name + "' as a function, but defined name in workbook does not refer to a function");
					}
					ptg = name2.CreatePtg();
				}
				else
				{
					ptg = this._book.GetNameXPtg(name, null);
					if (ptg == null)
					{
						string name3 = this._book.GetSpreadsheetVersion().Name;
						if (!(name3 == "EXCEL97"))
						{
							if (!(name3 == "EXCEL2007"))
							{
								throw new global::System.Exception("Unexpected spreadsheet version: " + this._book.GetSpreadsheetVersion().Name);
							}
							ptg = new global::NPOI.SS.Formula.PTG.NameXPxg(name);
						}
						else
						{
							this.AddName(name);
							name2 = this._book.GetName(name, this._sheetIndex);
							ptg = name2.CreatePtg();
						}
					}
				}
			}
			this.Match('(');
			global::NPOI.SS.Formula.ParseNode[] args = this.Arguments();
			this.Match(')');
			return this.GetFunction(name, ptg, args);
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00010E26 File Offset: 0x0000F026
		private void AddName(string functionName)
		{
			global::NPOI.SS.UserModel.IName name = this._book.CreateName();
			name.SetFunction(true);
			name.NameName = functionName;
			name.SheetIndex = this._sheetIndex;
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x00010E4C File Offset: 0x0000F04C
		private global::NPOI.SS.Formula.ParseNode GetFunction(string name, global::NPOI.SS.Formula.PTG.Ptg namePtg, global::NPOI.SS.Formula.ParseNode[] args)
		{
			global::NPOI.SS.Formula.Function.FunctionMetadata functionByName = global::NPOI.SS.Formula.Function.FunctionMetadataRegistry.GetFunctionByName(name.ToUpper());
			int num = args.Length;
			if (functionByName == null)
			{
				if (namePtg == null)
				{
					throw new global::System.InvalidOperationException("NamePtg must be supplied for external Functions");
				}
				global::NPOI.SS.Formula.ParseNode[] array = new global::NPOI.SS.Formula.ParseNode[num + 1];
				array[0] = new global::NPOI.SS.Formula.ParseNode(namePtg);
				global::System.Array.Copy(args, 0, array, 1, num);
				return new global::NPOI.SS.Formula.ParseNode(global::NPOI.SS.Formula.PTG.FuncVarPtg.Create(name, (int)((byte)(num + 1))), array);
			}
			else
			{
				if (namePtg != null)
				{
					throw new global::System.InvalidOperationException("NamePtg no applicable To internal Functions");
				}
				bool flag = !functionByName.HasFixedArgsLength;
				int index = functionByName.Index;
				if (index == 4 && args.Length == 1)
				{
					return new global::NPOI.SS.Formula.ParseNode(global::NPOI.SS.Formula.PTG.AttrPtg.GetSumSingle(), args);
				}
				this.ValidateNumArgs(args.Length, functionByName);
				global::NPOI.SS.Formula.PTG.AbstractFunctionPtg token;
				if (flag)
				{
					token = global::NPOI.SS.Formula.PTG.FuncVarPtg.Create(name, (int)((byte)num));
				}
				else
				{
					token = global::NPOI.SS.Formula.PTG.FuncPtg.Create(index);
				}
				return new global::NPOI.SS.Formula.ParseNode(token, args);
			}
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00010F0C File Offset: 0x0000F10C
		private void ValidateNumArgs(int numArgs, global::NPOI.SS.Formula.Function.FunctionMetadata fm)
		{
			if (numArgs < fm.MinParams)
			{
				string text = "Too few arguments to function '" + fm.Name + "'. ";
				if (fm.HasFixedArgsLength)
				{
					text = text + "Expected " + fm.MinParams.ToString();
				}
				else
				{
					text = text + "At least " + fm.MinParams.ToString() + " were expected";
				}
				text = text + " but got " + numArgs.ToString() + ".";
				throw new global::NPOI.SS.Formula.FormulaParseException(text);
			}
			int num;
			if (fm.HasUnlimitedVarags)
			{
				if (this._book != null)
				{
					num = this._book.GetSpreadsheetVersion().MaxFunctionArgs;
				}
				else
				{
					num = fm.MaxParams;
				}
			}
			else
			{
				num = fm.MaxParams;
			}
			if (numArgs > num)
			{
				string text2 = "Too many arguments to function '" + fm.Name + "'. ";
				if (fm.HasFixedArgsLength)
				{
					text2 = text2 + "Expected " + fm.MaxParams.ToString();
				}
				else
				{
					text2 = text2 + "At most " + fm.MaxParams.ToString() + " were expected";
				}
				text2 = text2 + " but got " + numArgs.ToString() + ".";
				throw new global::NPOI.SS.Formula.FormulaParseException(text2);
			}
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x00011049 File Offset: 0x0000F249
		private static bool IsArgumentDelimiter(char ch)
		{
			return ch == ',' || ch == ')';
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00011058 File Offset: 0x0000F258
		private global::NPOI.SS.Formula.ParseNode[] Arguments()
		{
			global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList(2);
			this.SkipWhite();
			if (this.look == ')')
			{
				return global::NPOI.SS.Formula.ParseNode.EMPTY_ARRAY;
			}
			bool flag = true;
			int num = 0;
			for (;;)
			{
				this.SkipWhite();
				if (global::NPOI.SS.Formula.FormulaParser.IsArgumentDelimiter(this.look))
				{
					if (flag)
					{
						arrayList.Add(new global::NPOI.SS.Formula.ParseNode(global::NPOI.SS.Formula.PTG.MissingArgPtg.instance));
						num++;
					}
					if (this.look == ')')
					{
						goto IL_94;
					}
					this.Match(',');
					flag = true;
				}
				else
				{
					arrayList.Add(this.ComparisonExpression());
					num++;
					flag = false;
					this.SkipWhite();
					if (!global::NPOI.SS.Formula.FormulaParser.IsArgumentDelimiter(this.look))
					{
						break;
					}
				}
			}
			throw this.expected("',' or ')'");
			IL_94:
			return (global::NPOI.SS.Formula.ParseNode[])arrayList.ToArray(typeof(global::NPOI.SS.Formula.ParseNode));
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x00011110 File Offset: 0x0000F310
		private global::NPOI.SS.Formula.ParseNode PowerFactor()
		{
			global::NPOI.SS.Formula.ParseNode parseNode = this.PercentFactor();
			for (;;)
			{
				this.SkipWhite();
				if (this.look != '^')
				{
					break;
				}
				this.Match('^');
				global::NPOI.SS.Formula.ParseNode child = this.PercentFactor();
				parseNode = new global::NPOI.SS.Formula.ParseNode(global::NPOI.SS.Formula.PTG.PowerPtg.instance, parseNode, child);
			}
			return parseNode;
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x00011154 File Offset: 0x0000F354
		private global::NPOI.SS.Formula.ParseNode PercentFactor()
		{
			global::NPOI.SS.Formula.ParseNode parseNode = this.ParseSimpleFactor();
			for (;;)
			{
				this.SkipWhite();
				if (this.look != '%')
				{
					break;
				}
				this.Match('%');
				parseNode = new global::NPOI.SS.Formula.ParseNode(global::NPOI.SS.Formula.PTG.PercentPtg.instance, parseNode);
			}
			return parseNode;
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00011190 File Offset: 0x0000F390
		private global::NPOI.SS.Formula.ParseNode ParseSimpleFactor()
		{
			this.SkipWhite();
			char c = this.look;
			if (c <= '(')
			{
				if (c == '"')
				{
					return new global::NPOI.SS.Formula.ParseNode(new global::NPOI.SS.Formula.PTG.StringPtg(this.ParseStringLiteral()));
				}
				if (c == '#')
				{
					return new global::NPOI.SS.Formula.ParseNode(global::NPOI.SS.Formula.PTG.ErrPtg.ValueOf(this.ParseErrorLiteral()));
				}
				if (c == '(')
				{
					this.Match('(');
					global::NPOI.SS.Formula.ParseNode child = this.UnionExpression();
					this.Match(')');
					return new global::NPOI.SS.Formula.ParseNode(global::NPOI.SS.Formula.PTG.ParenthesisPtg.instance, child);
				}
			}
			else
			{
				if (c == '+')
				{
					this.Match('+');
					return this.ParseUnary(true);
				}
				if (c == '-')
				{
					this.Match('-');
					return this.ParseUnary(false);
				}
				if (c == '{')
				{
					this.Match('{');
					global::NPOI.SS.Formula.ParseNode result = this.ParseArray();
					this.Match('}');
					return result;
				}
			}
			if (global::NPOI.SS.Formula.FormulaParser.IsAlpha(this.look) || char.IsDigit(this.look) || this.look == '\'' || this.look == '[' || this.look == '_' || this.look == '\\')
			{
				return this.ParseRangeExpression();
			}
			if (this.look == '.')
			{
				return new global::NPOI.SS.Formula.ParseNode(this.ParseNumber());
			}
			throw this.expected("cell ref or constant literal");
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x000112BC File Offset: 0x0000F4BC
		private global::NPOI.SS.Formula.ParseNode ParseUnary(bool isPlus)
		{
			bool flag = global::NPOI.SS.Formula.FormulaParser.IsDigit(this.look) || this.look == '.';
			global::NPOI.SS.Formula.ParseNode parseNode = this.PowerFactor();
			if (flag)
			{
				global::NPOI.SS.Formula.PTG.Ptg ptg = parseNode.GetToken();
				if (ptg is global::NPOI.SS.Formula.PTG.NumberPtg)
				{
					if (isPlus)
					{
						return parseNode;
					}
					ptg = new global::NPOI.SS.Formula.PTG.NumberPtg(-((global::NPOI.SS.Formula.PTG.NumberPtg)ptg).Value);
					return new global::NPOI.SS.Formula.ParseNode(ptg);
				}
				else if (ptg is global::NPOI.SS.Formula.PTG.IntPtg)
				{
					if (isPlus)
					{
						return parseNode;
					}
					ptg = new global::NPOI.SS.Formula.PTG.NumberPtg((double)(-(double)((global::NPOI.SS.Formula.PTG.IntPtg)ptg).Value));
					return new global::NPOI.SS.Formula.ParseNode(ptg);
				}
			}
			return new global::NPOI.SS.Formula.ParseNode(isPlus ? global::NPOI.SS.Formula.PTG.UnaryPlusPtg.instance : global::NPOI.SS.Formula.PTG.UnaryMinusPtg.instance, parseNode);
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00011358 File Offset: 0x0000F558
		private global::NPOI.SS.Formula.ParseNode ParseArray()
		{
			global::System.Collections.Generic.List<object[]> list = new global::System.Collections.Generic.List<object[]>();
			for (;;)
			{
				object[] item = this.ParseArrayRow();
				list.Add(item);
				if (this.look == '}')
				{
					goto IL_3E;
				}
				if (this.look != ';')
				{
					break;
				}
				this.Match(';');
			}
			throw this.expected("'}' or ';'");
			IL_3E:
			object[][] array = new object[list.Count][];
			array = list.ToArray();
			int nColumns = array[0].Length;
			this.CheckRowLengths(array, nColumns);
			return new global::NPOI.SS.Formula.ParseNode(new global::NPOI.SS.Formula.PTG.ArrayPtg(array));
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x000113D0 File Offset: 0x0000F5D0
		private void CheckRowLengths(object[][] values2d, int nColumns)
		{
			for (int i = 0; i < values2d.Length; i++)
			{
				int num = values2d[i].Length;
				if (num != nColumns)
				{
					throw new global::NPOI.SS.Formula.FormulaParseException(string.Concat(new string[]
					{
						"Array row ",
						i.ToString(),
						" Has length ",
						num.ToString(),
						" but row 0 Has length ",
						nColumns.ToString()
					}));
				}
			}
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x0001143C File Offset: 0x0000F63C
		private object[] ParseArrayRow()
		{
			global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
			char c;
			for (;;)
			{
				arrayList.Add(this.ParseArrayItem());
				this.SkipWhite();
				c = this.look;
				if (c != ',')
				{
					break;
				}
				this.Match(',');
			}
			if (c != ';' && c != '}')
			{
				throw this.expected("'}' or ','");
			}
			new object[arrayList.Count];
			return arrayList.ToArray();
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x000114A4 File Offset: 0x0000F6A4
		private object ParseArrayItem()
		{
			this.SkipWhite();
			char c = this.look;
			if (c > '-')
			{
				if (c <= 'T')
				{
					if (c != 'F' && c != 'T')
					{
						goto IL_7F;
					}
				}
				else if (c != 'f' && c != 't')
				{
					goto IL_7F;
				}
				return this.ParseBooleanLiteral();
			}
			if (c == '"')
			{
				return this.ParseStringLiteral();
			}
			if (c == '#')
			{
				return global::NPOI.SS.Formula.Constant.ErrorConstant.ValueOf(this.ParseErrorLiteral());
			}
			if (c == '-')
			{
				this.Match('-');
				this.SkipWhite();
				return global::NPOI.SS.Formula.FormulaParser.ConvertArrayNumber(this.ParseNumber(), false);
			}
			IL_7F:
			return global::NPOI.SS.Formula.FormulaParser.ConvertArrayNumber(this.ParseNumber(), true);
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x00011544 File Offset: 0x0000F744
		private bool ParseBooleanLiteral()
		{
			string value = this.ParseUnquotedIdentifier();
			if ("TRUE".Equals(value, global::System.StringComparison.OrdinalIgnoreCase))
			{
				return true;
			}
			if ("FALSE".Equals(value, global::System.StringComparison.OrdinalIgnoreCase))
			{
				return false;
			}
			throw this.expected("'TRUE' or 'FALSE'");
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00011584 File Offset: 0x0000F784
		private static double ConvertArrayNumber(global::NPOI.SS.Formula.PTG.Ptg ptg, bool isPositive)
		{
			double num;
			if (ptg is global::NPOI.SS.Formula.PTG.IntPtg)
			{
				num = (double)((global::NPOI.SS.Formula.PTG.IntPtg)ptg).Value;
			}
			else
			{
				if (!(ptg is global::NPOI.SS.Formula.PTG.NumberPtg))
				{
					throw new global::System.Exception("Unexpected ptg (" + ptg.GetType().Name + ")");
				}
				num = ((global::NPOI.SS.Formula.PTG.NumberPtg)ptg).Value;
			}
			if (!isPositive)
			{
				num = -num;
			}
			return num;
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x000115E8 File Offset: 0x0000F7E8
		private global::NPOI.SS.Formula.PTG.Ptg ParseNumber()
		{
			string text = null;
			string exponent = null;
			string num = this.GetNum();
			if (this.look == '.')
			{
				this.GetChar();
				text = this.GetNum();
			}
			if (this.look == 'E')
			{
				this.GetChar();
				string str = "";
				if (this.look == '+')
				{
					this.GetChar();
				}
				else if (this.look == '-')
				{
					this.GetChar();
					str = "-";
				}
				string num2 = this.GetNum();
				if (num2 == null)
				{
					throw this.expected("int");
				}
				exponent = str + num2;
			}
			if (num == null && text == null)
			{
				throw this.expected("int");
			}
			return global::NPOI.SS.Formula.FormulaParser.GetNumberPtgFromString(num, text, exponent);
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x0001168C File Offset: 0x0000F88C
		private int ParseErrorLiteral()
		{
			this.Match('#');
			string text = this.ParseUnquotedIdentifier().ToUpper();
			char c = text[0];
			if (c <= 'N')
			{
				if (c != 'D')
				{
					if (c == 'N')
					{
						global::NPOI.SS.UserModel.FormulaError formulaError = global::NPOI.SS.UserModel.FormulaError.NAME;
						if (text.Equals(formulaError.Name))
						{
							this.Match('?');
							return (int)formulaError.Code;
						}
						formulaError = global::NPOI.SS.UserModel.FormulaError.NUM;
						if (text.Equals(formulaError.Name))
						{
							this.Match('!');
							return (int)formulaError.Code;
						}
						formulaError = global::NPOI.SS.UserModel.FormulaError.NULL;
						if (text.Equals(formulaError.Name))
						{
							this.Match('!');
							return (int)formulaError.Code;
						}
						formulaError = global::NPOI.SS.UserModel.FormulaError.NA;
						if (!text.Equals("N"))
						{
							throw this.expected("#NAME?, #NUM!, #NULL! or #N/A");
						}
						this.Match('/');
						if (this.look != 'A' && this.look != 'a')
						{
							throw this.expected(formulaError.String);
						}
						this.Match(this.look);
						return (int)formulaError.Code;
					}
				}
				else
				{
					global::NPOI.SS.UserModel.FormulaError div = global::NPOI.SS.UserModel.FormulaError.DIV0;
					if (text.Equals("DIV"))
					{
						this.Match('/');
						this.Match('0');
						this.Match('!');
						return (int)div.Code;
					}
					throw this.expected(div.String);
				}
			}
			else if (c != 'R')
			{
				if (c == 'V')
				{
					global::NPOI.SS.UserModel.FormulaError value = global::NPOI.SS.UserModel.FormulaError.VALUE;
					if (text.Equals(value.Name))
					{
						this.Match('!');
						return (int)value.Code;
					}
					throw this.expected(value.String);
				}
			}
			else
			{
				global::NPOI.SS.UserModel.FormulaError @ref = global::NPOI.SS.UserModel.FormulaError.REF;
				if (text.Equals(@ref.Name))
				{
					this.Match('!');
					return (int)@ref.Code;
				}
				throw this.expected(@ref.String);
			}
			throw this.expected("#VALUE!, #REF!, #DIV/0!, #NAME?, #NUM!, #NULL! or #N/A");
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00011858 File Offset: 0x0000FA58
		private static global::NPOI.SS.Formula.PTG.Ptg GetNumberPtgFromString(string number1, string number2, string exponent)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			if (number2 == null)
			{
				stringBuilder.Append(number1);
				if (exponent != null)
				{
					stringBuilder.Append('E');
					stringBuilder.Append(exponent);
				}
				string text = stringBuilder.ToString();
				int num;
				try
				{
					num = int.Parse(text, global::System.Globalization.CultureInfo.InvariantCulture);
				}
				catch (global::System.FormatException)
				{
					return new global::NPOI.SS.Formula.PTG.NumberPtg(text);
				}
				catch (global::System.OverflowException)
				{
					return new global::NPOI.SS.Formula.PTG.NumberPtg(text);
				}
				if (global::NPOI.SS.Formula.PTG.IntPtg.IsInRange(num))
				{
					return new global::NPOI.SS.Formula.PTG.IntPtg(num);
				}
				return new global::NPOI.SS.Formula.PTG.NumberPtg(text);
			}
			if (number1 != null)
			{
				stringBuilder.Append(number1);
			}
			stringBuilder.Append('.');
			stringBuilder.Append(number2);
			if (exponent != null)
			{
				stringBuilder.Append('E');
				stringBuilder.Append(exponent);
			}
			return new global::NPOI.SS.Formula.PTG.NumberPtg(stringBuilder.ToString());
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x00011924 File Offset: 0x0000FB24
		private string ParseStringLiteral()
		{
			this.Match('"');
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			for (;;)
			{
				if (this.look == '"')
				{
					this.GetChar();
					if (this.look != '"')
					{
						break;
					}
				}
				stringBuilder.Append(this.look);
				this.GetChar();
			}
			return stringBuilder.ToString();
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x00011974 File Offset: 0x0000FB74
		private global::NPOI.SS.Formula.ParseNode Term()
		{
			global::NPOI.SS.Formula.ParseNode parseNode = this.PowerFactor();
			for (;;)
			{
				this.SkipWhite();
				char c = this.look;
				global::NPOI.SS.Formula.PTG.Ptg instance;
				if (c != '*')
				{
					if (c != '/')
					{
						break;
					}
					this.Match('/');
					instance = global::NPOI.SS.Formula.PTG.DividePtg.instance;
				}
				else
				{
					this.Match('*');
					instance = global::NPOI.SS.Formula.PTG.MultiplyPtg.instance;
				}
				global::NPOI.SS.Formula.ParseNode child = this.PowerFactor();
				parseNode = new global::NPOI.SS.Formula.ParseNode(instance, parseNode, child);
			}
			return parseNode;
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x000119D4 File Offset: 0x0000FBD4
		private global::NPOI.SS.Formula.ParseNode ComparisonExpression()
		{
			global::NPOI.SS.Formula.ParseNode parseNode = this.ConcatExpression();
			for (;;)
			{
				this.SkipWhite();
				switch (this.look)
				{
				case '<':
				case '=':
				case '>':
				{
					global::NPOI.SS.Formula.PTG.Ptg comparisonToken = this.GetComparisonToken();
					global::NPOI.SS.Formula.ParseNode child = this.ConcatExpression();
					parseNode = new global::NPOI.SS.Formula.ParseNode(comparisonToken, parseNode, child);
					continue;
				}
				}
				break;
			}
			return parseNode;
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x00011A24 File Offset: 0x0000FC24
		private global::NPOI.SS.Formula.PTG.Ptg GetComparisonToken()
		{
			if (this.look == '=')
			{
				this.Match(this.look);
				return global::NPOI.SS.Formula.PTG.EqualPtg.instance;
			}
			bool flag = this.look == '>';
			this.Match(this.look);
			if (flag)
			{
				if (this.look == '=')
				{
					this.Match('=');
					return global::NPOI.SS.Formula.PTG.GreaterEqualPtg.instance;
				}
				return global::NPOI.SS.Formula.PTG.GreaterThanPtg.instance;
			}
			else
			{
				char c = this.look;
				if (c == '=')
				{
					this.Match('=');
					return global::NPOI.SS.Formula.PTG.LessEqualPtg.instance;
				}
				if (c != '>')
				{
					return global::NPOI.SS.Formula.PTG.LessThanPtg.instance;
				}
				this.Match('>');
				return global::NPOI.SS.Formula.PTG.NotEqualPtg.instance;
			}
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x00011AB8 File Offset: 0x0000FCB8
		private global::NPOI.SS.Formula.ParseNode ConcatExpression()
		{
			global::NPOI.SS.Formula.ParseNode parseNode = this.AdditiveExpression();
			for (;;)
			{
				this.SkipWhite();
				if (this.look != '&')
				{
					break;
				}
				this.Match('&');
				global::NPOI.SS.Formula.ParseNode child = this.AdditiveExpression();
				parseNode = new global::NPOI.SS.Formula.ParseNode(global::NPOI.SS.Formula.PTG.ConcatPtg.instance, parseNode, child);
			}
			return parseNode;
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00011AFC File Offset: 0x0000FCFC
		private global::NPOI.SS.Formula.ParseNode AdditiveExpression()
		{
			global::NPOI.SS.Formula.ParseNode parseNode = this.Term();
			for (;;)
			{
				this.SkipWhite();
				char c = this.look;
				global::NPOI.SS.Formula.PTG.Ptg instance;
				if (c != '+')
				{
					if (c != '-')
					{
						break;
					}
					this.Match('-');
					instance = global::NPOI.SS.Formula.PTG.SubtractPtg.instance;
				}
				else
				{
					this.Match('+');
					instance = global::NPOI.SS.Formula.PTG.AddPtg.instance;
				}
				global::NPOI.SS.Formula.ParseNode child = this.Term();
				parseNode = new global::NPOI.SS.Formula.ParseNode(instance, parseNode, child);
			}
			return parseNode;
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x00011B5C File Offset: 0x0000FD5C
		private void Parse()
		{
			this._pointer = 0;
			this.GetChar();
			this._rootNode = this.UnionExpression();
			if (this._pointer <= this._formulaLength)
			{
				throw new global::NPOI.SS.Formula.FormulaParseException(string.Concat(new string[]
				{
					"Unused input [",
					this._formulaString.Substring(this._pointer - 1),
					"] after attempting to parse the formula [",
					this._formulaString,
					"]"
				}));
			}
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x00011BD8 File Offset: 0x0000FDD8
		private global::NPOI.SS.Formula.ParseNode UnionExpression()
		{
			global::NPOI.SS.Formula.ParseNode parseNode = this.IntersectionExpression();
			bool flag = false;
			for (;;)
			{
				this.SkipWhite();
				if (this.look != ',')
				{
					break;
				}
				this.GetChar();
				flag = true;
				global::NPOI.SS.Formula.ParseNode child = this.IntersectionExpression();
				parseNode = new global::NPOI.SS.Formula.ParseNode(global::NPOI.SS.Formula.PTG.UnionPtg.instance, parseNode, child);
			}
			if (flag)
			{
				return global::NPOI.SS.Formula.FormulaParser.AugmentWithMemPtg(parseNode);
			}
			return parseNode;
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00011C28 File Offset: 0x0000FE28
		private global::NPOI.SS.Formula.ParseNode IntersectionExpression()
		{
			global::NPOI.SS.Formula.ParseNode parseNode = this.ComparisonExpression();
			bool flag = false;
			for (;;)
			{
				this.SkipWhite();
				if (this._inIntersection)
				{
					int pointer = this._pointer;
					try
					{
						global::NPOI.SS.Formula.ParseNode child = this.ComparisonExpression();
						parseNode = new global::NPOI.SS.Formula.ParseNode(global::NPOI.SS.Formula.PTG.IntersectionPtg.instance, parseNode, child);
						flag = true;
						continue;
					}
					catch (global::NPOI.SS.Formula.FormulaParseException)
					{
						this.ResetPointer(pointer);
					}
					break;
				}
				break;
			}
			if (flag)
			{
				return global::NPOI.SS.Formula.FormulaParser.AugmentWithMemPtg(parseNode);
			}
			return parseNode;
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00011C90 File Offset: 0x0000FE90
		private global::NPOI.SS.Formula.PTG.Ptg[] GetRPNPtg(global::NPOI.SS.Formula.FormulaType formulaType)
		{
			new global::NPOI.SS.Formula.OperandClassTransformer(formulaType).TransformFormula(this._rootNode);
			return global::NPOI.SS.Formula.ParseNode.ToTokenArray(this._rootNode);
		}

		// Token: 0x040003B2 RID: 946
		private string _formulaString;

		// Token: 0x040003B3 RID: 947
		private int _formulaLength;

		// Token: 0x040003B4 RID: 948
		private int _pointer;

		// Token: 0x040003B5 RID: 949
		private global::NPOI.SS.Formula.ParseNode _rootNode;

		// Token: 0x040003B6 RID: 950
		private const char TAB = '\t';

		// Token: 0x040003B7 RID: 951
		private const char CR = '\r';

		// Token: 0x040003B8 RID: 952
		private const char LF = '\n';

		// Token: 0x040003B9 RID: 953
		private char look;

		// Token: 0x040003BA RID: 954
		private bool _inIntersection;

		// Token: 0x040003BB RID: 955
		private global::NPOI.SS.Formula.IFormulaParsingWorkbook _book;

		// Token: 0x040003BC RID: 956
		private static global::NPOI.SS.SpreadsheetVersion _ssVersion;

		// Token: 0x040003BD RID: 957
		private int _sheetIndex;

		// Token: 0x040003BE RID: 958
		private int _rowIndex;

		// Token: 0x040003BF RID: 959
		private static string specHeaders = "Headers";

		// Token: 0x040003C0 RID: 960
		private static string specAll = "All";

		// Token: 0x040003C1 RID: 961
		private static string specData = "Data";

		// Token: 0x040003C2 RID: 962
		private static string specTotals = "Totals";

		// Token: 0x040003C3 RID: 963
		private static string specThisRow = "This Row";

		// Token: 0x040003C4 RID: 964
		private string CELL_REF_PATTERN = "(\\$?[A-Za-z]+)?(\\$?[0-9]+)?";

		// Token: 0x02000562 RID: 1378
		private class SimpleRangePart
		{
			// Token: 0x060033AF RID: 13231 RVA: 0x000A15A9 File Offset: 0x0009F7A9
			public static global::NPOI.SS.Formula.FormulaParser.SimpleRangePart.PartType Get(bool hasLetters, bool hasDigits)
			{
				if (hasLetters)
				{
					if (!hasDigits)
					{
						return global::NPOI.SS.Formula.FormulaParser.SimpleRangePart.PartType.Column;
					}
					return global::NPOI.SS.Formula.FormulaParser.SimpleRangePart.PartType.Cell;
				}
				else
				{
					if (!hasDigits)
					{
						throw new global::System.ArgumentException("must have either letters or numbers");
					}
					return global::NPOI.SS.Formula.FormulaParser.SimpleRangePart.PartType.Row;
				}
			}

			// Token: 0x060033B0 RID: 13232 RVA: 0x000A15C4 File Offset: 0x0009F7C4
			public SimpleRangePart(string rep, bool hasLetters, bool hasNumbers)
			{
				this._rep = rep;
				this._type = global::NPOI.SS.Formula.FormulaParser.SimpleRangePart.Get(hasLetters, hasNumbers);
			}

			// Token: 0x17000D95 RID: 3477
			// (get) Token: 0x060033B1 RID: 13233 RVA: 0x000A15E0 File Offset: 0x0009F7E0
			public bool IsCell
			{
				get
				{
					return this._type == global::NPOI.SS.Formula.FormulaParser.SimpleRangePart.PartType.Cell;
				}
			}

			// Token: 0x17000D96 RID: 3478
			// (get) Token: 0x060033B2 RID: 13234 RVA: 0x000A15EB File Offset: 0x0009F7EB
			public bool IsRowOrColumn
			{
				get
				{
					return this._type > global::NPOI.SS.Formula.FormulaParser.SimpleRangePart.PartType.Cell;
				}
			}

			// Token: 0x17000D97 RID: 3479
			// (get) Token: 0x060033B3 RID: 13235 RVA: 0x000A15F6 File Offset: 0x0009F7F6
			public global::NPOI.SS.Util.CellReference CellReference
			{
				get
				{
					if (this._type != global::NPOI.SS.Formula.FormulaParser.SimpleRangePart.PartType.Cell)
					{
						throw new global::System.InvalidOperationException("Not applicable to this type");
					}
					return new global::NPOI.SS.Util.CellReference(this._rep);
				}
			}

			// Token: 0x17000D98 RID: 3480
			// (get) Token: 0x060033B4 RID: 13236 RVA: 0x000A1616 File Offset: 0x0009F816
			public bool IsColumn
			{
				get
				{
					return this._type == global::NPOI.SS.Formula.FormulaParser.SimpleRangePart.PartType.Column;
				}
			}

			// Token: 0x17000D99 RID: 3481
			// (get) Token: 0x060033B5 RID: 13237 RVA: 0x000A1621 File Offset: 0x0009F821
			public bool IsRow
			{
				get
				{
					return this._type == global::NPOI.SS.Formula.FormulaParser.SimpleRangePart.PartType.Row;
				}
			}

			// Token: 0x17000D9A RID: 3482
			// (get) Token: 0x060033B6 RID: 13238 RVA: 0x000A162C File Offset: 0x0009F82C
			public string Rep
			{
				get
				{
					return this._rep;
				}
			}

			// Token: 0x060033B7 RID: 13239 RVA: 0x000A1634 File Offset: 0x0009F834
			public bool IsCompatibleForArea(global::NPOI.SS.Formula.FormulaParser.SimpleRangePart part2)
			{
				return this._type == part2._type;
			}

			// Token: 0x060033B8 RID: 13240 RVA: 0x000A1644 File Offset: 0x0009F844
			public override string ToString()
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(64);
				stringBuilder.Append(base.GetType().Name).Append(" [");
				stringBuilder.Append(this._rep);
				stringBuilder.Append("]");
				return stringBuilder.ToString();
			}

			// Token: 0x0400188A RID: 6282
			private global::NPOI.SS.Formula.FormulaParser.SimpleRangePart.PartType _type;

			// Token: 0x0400188B RID: 6283
			private string _rep;

			// Token: 0x02000645 RID: 1605
			public enum PartType
			{
				// Token: 0x04001ACB RID: 6859
				Cell,
				// Token: 0x04001ACC RID: 6860
				Row,
				// Token: 0x04001ACD RID: 6861
				Column
			}
		}
	}
}
