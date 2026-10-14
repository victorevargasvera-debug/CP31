using System;
using System.Collections.Generic;
using System.Text;

namespace NLog.MessageTemplates
{
	// Token: 0x02000084 RID: 132
	internal static class TemplateRenderer
	{
		// Token: 0x060008CD RID: 2253 RVA: 0x00017244 File Offset: 0x00015444
		public static void Render(this string template, global::System.IFormatProvider formatProvider, object[] parameters, bool forceTemplateRenderer, global::System.Text.StringBuilder sb, out global::System.Collections.Generic.IList<global::NLog.MessageTemplates.MessageTemplateParameter> messageTemplateParameters)
		{
			int num = 0;
			int num2 = 0;
			int holeStartPosition = 0;
			messageTemplateParameters = null;
			int length = sb.Length;
			global::NLog.MessageTemplates.TemplateEnumerator templateEnumerator = new global::NLog.MessageTemplates.TemplateEnumerator(template);
			while (templateEnumerator.MoveNext())
			{
				if (num2 == 0 && !forceTemplateRenderer)
				{
					global::NLog.MessageTemplates.LiteralHole literalHole = templateEnumerator.Current;
					if (literalHole.MaybePositionalTemplate && sb.Length == length)
					{
						sb.AppendFormat(formatProvider, template, parameters);
						return;
					}
				}
				global::NLog.MessageTemplates.Literal literal = templateEnumerator.Current.Literal;
				sb.Append(template, num, literal.Print);
				num += literal.Print;
				if (literal.Skip == 0)
				{
					num++;
				}
				else
				{
					num += (int)literal.Skip;
					global::NLog.MessageTemplates.Hole hole = templateEnumerator.Current.Hole;
					if (hole.Alignment != 0)
					{
						holeStartPosition = sb.Length;
					}
					if (hole.Index != -1 && messageTemplateParameters == null)
					{
						num2++;
						global::NLog.MessageTemplates.TemplateRenderer.RenderHole(sb, hole, formatProvider, parameters[(int)hole.Index], true);
					}
					else
					{
						object value = parameters[num2];
						if (messageTemplateParameters == null)
						{
							messageTemplateParameters = new global::NLog.MessageTemplates.MessageTemplateParameter[parameters.Length];
							if (num2 != 0)
							{
								templateEnumerator = new global::NLog.MessageTemplates.TemplateEnumerator(template);
								sb.Length = length;
								num2 = 0;
								num = 0;
								continue;
							}
						}
						messageTemplateParameters[num2++] = new global::NLog.MessageTemplates.MessageTemplateParameter(hole.Name, value, hole.Format, hole.CaptureType);
						global::NLog.MessageTemplates.TemplateRenderer.RenderHole(sb, hole, formatProvider, value, false);
					}
					if (hole.Alignment != 0)
					{
						global::NLog.MessageTemplates.TemplateRenderer.RenderPadding(sb, (int)hole.Alignment, holeStartPosition);
					}
				}
			}
			if (messageTemplateParameters != null && num2 != messageTemplateParameters.Count)
			{
				global::NLog.MessageTemplates.MessageTemplateParameter[] array = new global::NLog.MessageTemplates.MessageTemplateParameter[num2];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = messageTemplateParameters[i];
				}
				messageTemplateParameters = array;
			}
		}

		// Token: 0x060008CE RID: 2254 RVA: 0x000173F8 File Offset: 0x000155F8
		public static void Render(this global::NLog.MessageTemplates.Template template, global::System.Text.StringBuilder sb, global::System.IFormatProvider formatProvider, object[] parameters)
		{
			int num = 0;
			int num2 = 0;
			int holeStartPosition = 0;
			foreach (global::NLog.MessageTemplates.Literal literal in template.Literals)
			{
				sb.Append(template.Value, num, literal.Print);
				num += literal.Print;
				if (literal.Skip == 0)
				{
					num++;
				}
				else
				{
					num += (int)literal.Skip;
					global::NLog.MessageTemplates.Hole hole = template.Holes[num2];
					if (hole.Alignment != 0)
					{
						holeStartPosition = sb.Length;
					}
					object value = template.IsPositional ? parameters[(int)hole.Index] : parameters[num2];
					num2++;
					global::NLog.MessageTemplates.TemplateRenderer.RenderHole(sb, hole, formatProvider, value, template.IsPositional);
					if (hole.Alignment != 0)
					{
						global::NLog.MessageTemplates.TemplateRenderer.RenderPadding(sb, (int)hole.Alignment, holeStartPosition);
					}
				}
			}
		}

		// Token: 0x060008CF RID: 2255 RVA: 0x000174CE File Offset: 0x000156CE
		private static void RenderHole(global::System.Text.StringBuilder sb, global::NLog.MessageTemplates.Hole hole, global::System.IFormatProvider formatProvider, object value, bool legacy = false)
		{
			global::NLog.MessageTemplates.TemplateRenderer.RenderHole(sb, hole.CaptureType, hole.Format, formatProvider, value, legacy);
		}

		// Token: 0x060008D0 RID: 2256 RVA: 0x000174E6 File Offset: 0x000156E6
		public static void RenderHole(global::System.Text.StringBuilder sb, global::NLog.MessageTemplates.CaptureType captureType, string holeFormat, global::System.IFormatProvider formatProvider, object value, bool legacy = false)
		{
			if (value == null)
			{
				sb.Append("NULL");
				return;
			}
			if (captureType == global::NLog.MessageTemplates.CaptureType.Normal && legacy)
			{
				global::NLog.MessageTemplates.ValueFormatter.FormatToString(value, holeFormat, formatProvider, sb);
				return;
			}
			global::NLog.MessageTemplates.ValueFormatter.Instance.FormatValue(value, holeFormat, captureType, formatProvider, sb);
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x00017520 File Offset: 0x00015720
		private static void RenderPadding(global::System.Text.StringBuilder sb, int holeAlignment, int holeStartPosition)
		{
			int num = sb.Length - holeStartPosition;
			int num2 = global::System.Math.Abs(holeAlignment) - num;
			if (num2 > 0)
			{
				if (holeAlignment < 0 || num == 0)
				{
					sb.Append(' ', num2);
					return;
				}
				string value = sb.ToString(holeStartPosition, num);
				sb.Length = holeStartPosition;
				sb.Append(' ', num2);
				sb.Append(value);
			}
		}
	}
}
