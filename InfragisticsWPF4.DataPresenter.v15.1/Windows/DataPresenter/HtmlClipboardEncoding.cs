using System;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000089 RID: 137
	internal class HtmlClipboardEncoding : global::Infragistics.Windows.DataPresenter.ClipboardEncoding
	{
		// Token: 0x060006C8 RID: 1736 RVA: 0x0001AD70 File Offset: 0x00018F70
		public override bool Equals(object obj)
		{
			return obj != null && obj.GetType() == base.GetType();
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x0001AD88 File Offset: 0x00018F88
		public override object GetClipboardData(global::Infragistics.Windows.DataPresenter.ClipboardCellValueHolderCollection cellValues, bool includeHeaders)
		{
			return this.GetHtmlText(cellValues, includeHeaders);
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x0001AD92 File Offset: 0x00018F92
		public override int GetHashCode()
		{
			return base.GetType().GetHashCode();
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x0001ADA0 File Offset: 0x00018FA0
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		internal global::System.IO.Stream GetHtmlText(global::Infragistics.Windows.DataPresenter.ClipboardCellValueHolderCollection values, bool includeHeaders)
		{
			global::System.Text.Encoding utf = global::System.Text.Encoding.UTF8;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			string newLine = global::System.Environment.NewLine;
			string format = "Version:1.0{4}StartHTML:{0:0000000000}{4}EndHTML:{1:0000000000}{4}StartFragment:{2:0000000000}{4}EndFragment:{3:0000000000}{4}";
			string text = string.Format(format, new object[]
			{
				0,
				0,
				0,
				0,
				newLine
			});
			stringBuilder.Append(text);
			int byteCount = utf.GetByteCount(stringBuilder.ToString());
			stringBuilder.AppendFormat("<html>{1}<head>{1}<meta http-equiv=\"Content-Type\" content=\"text/html;charset={0}\" >{1}</head>{1}", utf.WebName, newLine);
			stringBuilder.Append("<body>").Append(newLine);
			int byteCount2 = utf.GetByteCount(stringBuilder.ToString());
			stringBuilder.Append("<!--StartFragment-->").Append(newLine);
			stringBuilder.Append("<table>").Append(newLine);
			if (includeHeaders)
			{
				stringBuilder.Append(" <tr>").Append(newLine);
				int i = 0;
				int fieldCount = values.FieldCount;
				while (i < fieldCount)
				{
					global::Infragistics.Windows.DataPresenter.CellValueHolder label = values.GetLabel(i);
					string text2 = this.GetHeaderText(label);
					text2 = global::Infragistics.Windows.DataPresenter.HtmlClipboardEncoding.ProcessHtmlValue(text2);
					stringBuilder.AppendFormat("  <th>{0}</th>", text2).Append(newLine);
					i++;
				}
				stringBuilder.Append(" </tr>").Append(newLine);
			}
			int j = 0;
			int recordCount = values.RecordCount;
			while (j < recordCount)
			{
				stringBuilder.Append(" <tr>").Append(newLine);
				int k = 0;
				int fieldCount2 = values.FieldCount;
				while (k < fieldCount2)
				{
					string text3 = this.GetCellText(values[j, k]);
					text3 = global::Infragistics.Windows.DataPresenter.HtmlClipboardEncoding.ProcessHtmlValue(text3);
					stringBuilder.AppendFormat("  <td>{0}</td>", text3).Append(newLine);
					k++;
				}
				stringBuilder.Append(" </tr>").Append(newLine);
				j++;
			}
			stringBuilder.Append("</table>").Append(newLine);
			stringBuilder.Append("<!--EndFragment-->");
			int byteCount3 = utf.GetByteCount(stringBuilder.ToString());
			stringBuilder.Append(newLine);
			stringBuilder.Append("</body></html>").Append(newLine);
			int byteCount4 = utf.GetByteCount(stringBuilder.ToString());
			string newValue = string.Format(format, new object[]
			{
				byteCount,
				byteCount4,
				byteCount2,
				byteCount3,
				newLine
			});
			stringBuilder.Replace(text, newValue, 0, text.Length);
			string s = stringBuilder.ToString();
			return new global::System.IO.MemoryStream(utf.GetBytes(s));
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x0001B028 File Offset: 0x00019228
		private static string HtmlEncode(string text)
		{
			if (string.IsNullOrEmpty(text))
			{
				return text;
			}
			global::System.Text.StringBuilder stringBuilder = null;
			for (int i = 0; i < text.Length; i++)
			{
				char c = text[i];
				string text2 = null;
				if (c <= '>')
				{
					char c2 = c;
					if (c2 != '"')
					{
						if (c2 != '&')
						{
							switch (c2)
							{
							case '<':
								text2 = "&lt;";
								break;
							case '>':
								text2 = "&gt;";
								break;
							}
						}
						else
						{
							text2 = "&amp;";
						}
					}
					else
					{
						text2 = "&quot;";
					}
				}
				else if (c >= '\u00a0' && c < 'Ā')
				{
					string format = "&#{0};";
					int num = (int)c;
					text2 = string.Format(format, num.ToString(global::System.Globalization.CultureInfo.InvariantCulture));
				}
				if (text2 == null)
				{
					if (stringBuilder != null)
					{
						stringBuilder.Append(c);
					}
				}
				else
				{
					if (stringBuilder == null)
					{
						stringBuilder = new global::System.Text.StringBuilder();
						if (i > 0)
						{
							stringBuilder.Append(text.Substring(0, i));
						}
					}
					stringBuilder.Append(text2);
				}
			}
			return (stringBuilder == null) ? text : stringBuilder.ToString();
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x0001B11C File Offset: 0x0001931C
		private static string ProcessHtmlValue(string text)
		{
			if (text != null)
			{
				text = global::Infragistics.Windows.DataPresenter.HtmlClipboardEncoding.HtmlEncode(text);
				text = text.Replace(global::System.Environment.NewLine, "<br>");
			}
			return text;
		}
	}
}
