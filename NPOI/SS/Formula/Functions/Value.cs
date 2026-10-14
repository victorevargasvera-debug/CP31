using System;
using System.Globalization;
using System.Text;
using NPOI.SS.Formula.Eval;

namespace NPOI.SS.Formula.Functions
{
	// Token: 0x020001FB RID: 507
	public class Value : global::NPOI.SS.Formula.Functions.Fixed1ArgFunction
	{
		// Token: 0x06000CB6 RID: 3254 RVA: 0x00022C08 File Offset: 0x00020E08
		public override global::NPOI.SS.Formula.Eval.ValueEval Evaluate(int srcRowIndex, int srcColumnIndex, global::NPOI.SS.Formula.Eval.ValueEval arg0)
		{
			global::NPOI.SS.Formula.Eval.ValueEval singleValue;
			try
			{
				singleValue = global::NPOI.SS.Formula.Eval.OperandResolver.GetSingleValue(arg0, srcRowIndex, srcColumnIndex);
			}
			catch (global::NPOI.SS.Formula.Eval.EvaluationException ex)
			{
				return ex.GetErrorEval();
			}
			double num = global::NPOI.SS.Formula.Functions.Value.ConvertTextToNumber(global::NPOI.SS.Formula.Eval.OperandResolver.CoerceValueToString(singleValue));
			if (double.IsNaN(num))
			{
				return global::NPOI.SS.Formula.Eval.ErrorEval.VALUE_INVALID;
			}
			return new global::NPOI.SS.Formula.Eval.NumberEval(num);
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x00022C5C File Offset: 0x00020E5C
		private static double ConvertTextToNumber(string strText)
		{
			bool flag = false;
			bool flag2 = false;
			bool flag3 = false;
			bool flag4 = false;
			int length = strText.Length;
			int i = 0;
			while (i < length)
			{
				char c = strText[i];
				if (!char.IsDigit(c) && c != '.')
				{
					if (c <= '$')
					{
						if (c != ' ')
						{
							if (c != '$')
							{
								goto IL_8A;
							}
							if (flag)
							{
								return double.NaN;
							}
							flag = true;
						}
					}
					else if (c != '+')
					{
						if (c != '-')
						{
							goto IL_8A;
						}
						if (flag3 || flag2)
						{
							return double.NaN;
						}
						flag3 = true;
					}
					else
					{
						if (flag3 || flag2)
						{
							return double.NaN;
						}
						flag2 = true;
					}
					i++;
					continue;
					IL_8A:
					return double.NaN;
				}
				break;
			}
			if (i >= length)
			{
				if (flag || flag3 || flag2)
				{
					return double.NaN;
				}
				return 0.0;
			}
			else
			{
				bool flag5 = false;
				int num = -32768;
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(length);
				while (i < length)
				{
					char c2 = strText[i];
					if (!char.IsDigit(c2))
					{
						if (c2 <= ',')
						{
							if (c2 != ' ')
							{
								if (c2 == '%')
								{
									flag4 = true;
									goto IL_204;
								}
								if (c2 == ',')
								{
									if (flag5)
									{
										return double.NaN;
									}
									if (i - num < 4)
									{
										return double.NaN;
									}
									num = i;
									goto IL_204;
								}
							}
							else
							{
								string text = strText.Substring(i).Trim();
								if (text.Equals("%"))
								{
									flag4 = true;
									goto IL_204;
								}
								if (text.Length > 0)
								{
									return double.NaN;
								}
								goto IL_204;
							}
						}
						else if (c2 != '.')
						{
							if (c2 == 'E' || c2 == 'e')
							{
								if (i - num < 4)
								{
									return double.NaN;
								}
								stringBuilder.Append(strText.Substring(i));
								i = length;
								goto IL_204;
							}
						}
						else
						{
							if (flag5)
							{
								return double.NaN;
							}
							if (i - num < 4)
							{
								return double.NaN;
							}
							flag5 = true;
							stringBuilder.Append('.');
							goto IL_204;
						}
						return double.NaN;
					}
					stringBuilder.Append(c2);
					IL_204:
					i++;
				}
				if (!flag5 && i - num < 4)
				{
					return double.NaN;
				}
				double num2;
				try
				{
					num2 = double.Parse(stringBuilder.ToString(), global::System.Globalization.CultureInfo.InvariantCulture);
				}
				catch (global::System.FormatException)
				{
					return double.NaN;
				}
				double num3 = flag3 ? (-num2) : num2;
				if (!flag4)
				{
					return num3;
				}
				return num3 / 100.0;
			}
		}

		// Token: 0x040005D1 RID: 1489
		private const int MIN_DISTANCE_BETWEEN_THOUSANDS_SEPARATOR = 4;

		// Token: 0x040005D2 RID: 1490
		private const double ZERO = 0.0;
	}
}
