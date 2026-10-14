using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;

namespace NPOI.SS.Formula.Function
{
	// Token: 0x020000E4 RID: 228
	internal class FunctionMetadataReader
	{
		// Token: 0x060007B9 RID: 1977 RVA: 0x00015594 File Offset: 0x00013794
		public static global::NPOI.SS.Formula.Function.FunctionMetadataRegistry CreateRegistry()
		{
			global::NPOI.SS.Formula.Function.FunctionMetadataRegistry result;
			using (global::System.IO.StreamReader streamReader = new global::System.IO.StreamReader(typeof(global::NPOI.SS.Formula.Function.FunctionMetadataReader).Assembly.GetManifestResourceStream("functionMetadata.txt")))
			{
				global::NPOI.SS.Formula.Function.FunctionDataBuilder functionDataBuilder = new global::NPOI.SS.Formula.Function.FunctionDataBuilder(400);
				try
				{
					for (;;)
					{
						string text = streamReader.ReadLine();
						if (text == null)
						{
							break;
						}
						if (text.Length >= 1 && text[0] != '#' && text.Trim().Length >= 1)
						{
							global::NPOI.SS.Formula.Function.FunctionMetadataReader.ProcessLine(functionDataBuilder, text);
						}
					}
				}
				catch (global::System.IO.IOException)
				{
					throw;
				}
				result = functionDataBuilder.Build();
			}
			return result;
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x00015638 File Offset: 0x00013838
		private static void ProcessLine(global::NPOI.SS.Formula.Function.FunctionDataBuilder fdb, string line)
		{
			string[] array = new global::System.Text.RegularExpressions.Regex("\\t").Split(line);
			if (array.Length != 8)
			{
				throw new global::System.Exception("Bad line format '" + line + "' - expected 8 data fields");
			}
			int functionIndex = global::NPOI.SS.Formula.Function.FunctionMetadataReader.ParseInt(array[0]);
			string functionName = array[1];
			int minParams = global::NPOI.SS.Formula.Function.FunctionMetadataReader.ParseInt(array[2]);
			int maxParams = global::NPOI.SS.Formula.Function.FunctionMetadataReader.ParseInt(array[3]);
			byte returnClassCode = global::NPOI.SS.Formula.Function.FunctionMetadataReader.ParseReturnTypeCode(array[4]);
			byte[] parameterClassCodes = global::NPOI.SS.Formula.Function.FunctionMetadataReader.ParseOperandTypeCodes(array[5]);
			bool hasFootnote = array[7].Length > 0;
			global::NPOI.SS.Formula.Function.FunctionMetadataReader.ValidateFunctionName(functionName);
			fdb.Add(functionIndex, functionName, minParams, maxParams, returnClassCode, parameterClassCodes, hasFootnote);
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x000156C6 File Offset: 0x000138C6
		private static byte ParseReturnTypeCode(string code)
		{
			if (code.Length == 0)
			{
				return 0;
			}
			return global::NPOI.SS.Formula.Function.FunctionMetadataReader.ParseOperandTypeCode(code);
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x000156D8 File Offset: 0x000138D8
		private static byte[] ParseOperandTypeCodes(string codes)
		{
			if (codes.Length < 1)
			{
				return global::NPOI.SS.Formula.Function.FunctionMetadataReader.EMPTY_BYTE_ARRAY;
			}
			if (global::NPOI.SS.Formula.Function.FunctionMetadataReader.IsDash(codes))
			{
				return global::NPOI.SS.Formula.Function.FunctionMetadataReader.EMPTY_BYTE_ARRAY;
			}
			string[] array = new global::System.Text.RegularExpressions.Regex("\\s").Split(codes);
			int num = array.Length;
			if ("...".Equals(array[num - 1]))
			{
				num--;
			}
			byte[] array2 = new byte[num];
			for (int i = 0; i < num; i++)
			{
				array2[i] = global::NPOI.SS.Formula.Function.FunctionMetadataReader.ParseOperandTypeCode(array[i]);
			}
			return array2;
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x0001574B File Offset: 0x0001394B
		private static bool IsDash(string codes)
		{
			return codes.Length == 1 && codes[0] == '-';
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x00015764 File Offset: 0x00013964
		private static byte ParseOperandTypeCode(string code)
		{
			if (code.Length != 1)
			{
				throw new global::System.Exception("Bad operand type code format '" + code + "' expected single char");
			}
			char c = code[0];
			if (c == 'A')
			{
				return 64;
			}
			if (c == 'R')
			{
				return 0;
			}
			if (c == 'V')
			{
				return 32;
			}
			throw new global::System.ArgumentException(string.Concat(new string[]
			{
				"Unexpected operand type code '",
				code,
				"' (",
				((int)code[0]).ToString(),
				")"
			}));
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x000157F0 File Offset: 0x000139F0
		private static void ValidateFunctionName(string functionName)
		{
			int num = functionName.Length - 1;
			if (!char.IsDigit(functionName[num]))
			{
				return;
			}
			while (num >= 0 && char.IsDigit(functionName[num]))
			{
				num--;
			}
			if (global::NPOI.SS.Formula.Function.FunctionMetadataReader.DIGIT_ENDING_FUNCTION_NAMES_Set.Contains(functionName))
			{
				return;
			}
			throw new global::System.Exception("Invalid function name '" + functionName + "' (is footnote number incorrectly Appended)");
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x0001584E File Offset: 0x00013A4E
		private static int ParseInt(string valStr)
		{
			return int.Parse(valStr, global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x04000410 RID: 1040
		private const string METADATA_FILE_NAME = "functionMetadata.txt";

		// Token: 0x04000411 RID: 1041
		private const string ELLIPSIS = "...";

		// Token: 0x04000412 RID: 1042
		private const string TAB_DELIM_PATTERN = "\\t";

		// Token: 0x04000413 RID: 1043
		private const string SPACE_DELIM_PATTERN = "\\s";

		// Token: 0x04000414 RID: 1044
		private static readonly byte[] EMPTY_BYTE_ARRAY = new byte[0];

		// Token: 0x04000415 RID: 1045
		private static readonly string[] DIGIT_ENDING_FUNCTION_NAMES = new string[]
		{
			"LOG10",
			"ATAN2",
			"DAYS360",
			"SUMXMY2",
			"SUMX2MY2",
			"SUMX2PY2"
		};

		// Token: 0x04000416 RID: 1046
		private static global::System.Collections.Generic.List<string> DIGIT_ENDING_FUNCTION_NAMES_Set = new global::System.Collections.Generic.List<string>(global::NPOI.SS.Formula.Function.FunctionMetadataReader.DIGIT_ENDING_FUNCTION_NAMES);
	}
}
