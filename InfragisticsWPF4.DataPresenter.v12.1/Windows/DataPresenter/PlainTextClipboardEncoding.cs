using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000085 RID: 133
	internal class PlainTextClipboardEncoding : global::Infragistics.Windows.DataPresenter.ClipboardEncoding
	{
		// Token: 0x06000652 RID: 1618 RVA: 0x00018BA4 File Offset: 0x00016DA4
		public PlainTextClipboardEncoding(string rowSeparator, string cellSeparator, string cellDelimiter, char[] delimiterCriteria, string delimiterEscape, global::System.Text.Encoding encoding)
		{
			this._rowSeparator = (rowSeparator ?? string.Empty);
			this._cellDelimiter = (cellDelimiter ?? string.Empty);
			this._cellSeparator = (cellSeparator ?? string.Empty);
			this._delimiterCriteria = (delimiterCriteria ?? new char[0]);
			this._delimiterEscape = (delimiterEscape ?? this._cellDelimiter) + this._cellDelimiter;
			this._encoding = encoding;
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00018C20 File Offset: 0x00016E20
		public override bool Equals(object obj)
		{
			global::Infragistics.Windows.DataPresenter.PlainTextClipboardEncoding plainTextClipboardEncoding = obj as global::Infragistics.Windows.DataPresenter.PlainTextClipboardEncoding;
			return plainTextClipboardEncoding != null && plainTextClipboardEncoding._rowSeparator == this._rowSeparator && plainTextClipboardEncoding._cellDelimiter == this._cellDelimiter && plainTextClipboardEncoding._cellSeparator == this._cellSeparator && plainTextClipboardEncoding._delimiterEscape == this._delimiterEscape && plainTextClipboardEncoding._delimiterCriteria == this._delimiterCriteria;
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x00018C94 File Offset: 0x00016E94
		public override global::Infragistics.Windows.DataPresenter.CellValueHolder[,] GetCellValues(string format, global::System.Windows.IDataObject dataObject)
		{
			object obj = dataObject.GetDataPresent(format) ? dataObject.GetData(format) : null;
			if (obj == null)
			{
				return null;
			}
			global::System.IO.Stream stream = obj as global::System.IO.Stream;
			string text = null;
			if (stream != null)
			{
				using (global::System.IO.StreamReader streamReader = new global::System.IO.StreamReader(stream))
				{
					text = streamReader.ReadToEnd();
					goto IL_46;
				}
			}
			text = (obj as string);
			IL_46:
			if (string.IsNullOrEmpty(text))
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.CellValueHolder[,] array = null;
			if (text != null)
			{
				int num = 0;
				global::System.Collections.Generic.List<string[]> list = new global::System.Collections.Generic.List<string[]>();
				int num2 = 0;
				string[] array2;
				while (this.ReadLine(text, ref num, out array2))
				{
					if (array2 == null)
					{
						array2 = new string[0];
					}
					list.Add(array2);
					num2 = global::System.Math.Max(num2, array2.Length);
				}
				array = new global::Infragistics.Windows.DataPresenter.CellValueHolder[list.Count, num2];
				int i = 0;
				int count = list.Count;
				while (i < count)
				{
					array2 = list[i];
					for (int j = 0; j < num2; j++)
					{
						string value;
						if (j < array2.Length)
						{
							value = array2[j];
						}
						else
						{
							value = string.Empty;
						}
						array[i, j] = new global::Infragistics.Windows.DataPresenter.CellValueHolder(value, true);
					}
					i++;
				}
			}
			return array;
		}

		// Token: 0x06000655 RID: 1621 RVA: 0x00018DBC File Offset: 0x00016FBC
		public override object GetClipboardData(global::Infragistics.Windows.DataPresenter.ClipboardCellValueHolderCollection cellValues, bool includeHeaders)
		{
			global::System.IO.StringWriter stringWriter = this.CreateWriter();
			string cellSeparator = this._cellSeparator;
			string rowSeparator = this._rowSeparator;
			if (includeHeaders)
			{
				for (int i = 0; i < cellValues.FieldCount; i++)
				{
					global::Infragistics.Windows.DataPresenter.CellValueHolder label = cellValues.GetLabel(i);
					string text = this.GetHeaderText(label);
					if (i > 0)
					{
						stringWriter.Write(cellSeparator);
					}
					text = this.FormatValue(text);
					stringWriter.Write(text);
				}
				stringWriter.Write(rowSeparator);
			}
			int j = 0;
			int recordCount = cellValues.RecordCount;
			while (j < recordCount)
			{
				int k = 0;
				int fieldCount = cellValues.FieldCount;
				while (k < fieldCount)
				{
					string text2 = this.GetCellText(cellValues[j, k]);
					if (k > 0)
					{
						stringWriter.Write(cellSeparator);
					}
					text2 = this.FormatValue(text2);
					stringWriter.Write(text2);
					k++;
				}
				stringWriter.Write(rowSeparator);
				j++;
			}
			string text3 = stringWriter.ToString();
			if (this._encoding != null)
			{
				byte[] bytes = this._encoding.GetBytes(text3);
				return new global::System.IO.MemoryStream(bytes);
			}
			return text3;
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x00018EBB File Offset: 0x000170BB
		public override int GetHashCode()
		{
			return this._rowSeparator.GetHashCode() + this._cellSeparator.GetHashCode() + this._cellDelimiter.GetHashCode();
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x00018EE0 File Offset: 0x000170E0
		private global::System.IO.StringWriter CreateWriter()
		{
			return new global::System.IO.StringWriter();
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00018EE8 File Offset: 0x000170E8
		private string FormatValue(string text)
		{
			if (this._cellDelimiter.Length > 0)
			{
				bool flag = this._delimiterCriteria.Length == 0 || text.IndexOfAny(this._delimiterCriteria) >= 0;
				if (flag)
				{
					text = text.Replace(this._cellDelimiter, this._delimiterEscape);
					text = this._cellDelimiter + text + this._cellDelimiter;
				}
			}
			return text;
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x00018F50 File Offset: 0x00017150
		private bool ReadLine(string data, ref int position, out string[] cells)
		{
			int length = data.Length;
			if (position >= 0 && position < data.Length)
			{
				global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
				int length2 = this._rowSeparator.Length;
				if (!global::Infragistics.Windows.DataPresenter.PlainTextClipboardEncoding.StartsWith(data, position, this._rowSeparator))
				{
					if (this._cellDelimiter.Length == 0)
					{
						int num = data.IndexOf(this._rowSeparator, position);
						string text;
						if (num < 0)
						{
							text = data.Substring(position);
							position = length;
						}
						else
						{
							text = data.Substring(position, num - position);
							position = num + this._rowSeparator.Length;
						}
						string[] collection = text.Split(new string[]
						{
							this._cellSeparator
						}, global::System.StringSplitOptions.None);
						list.AddRange(collection);
					}
					else
					{
						while (position < length)
						{
							bool flag;
							string text2 = this.ReadDelimitedCell(data, ref position, out flag);
							if (position == length && text2 == "\0" && list.Count == 0)
							{
								cells = null;
								return false;
							}
							list.Add(text2);
							if (flag)
							{
								break;
							}
						}
					}
				}
				else
				{
					position += length2;
				}
				cells = list.ToArray();
				return true;
			}
			cells = null;
			return position < data.Length;
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00019074 File Offset: 0x00017274
		private string ReadDelimitedCell(string data, ref int position, out bool isEndOfLine)
		{
			int length = this._cellDelimiter.Length;
			int length2 = this._cellSeparator.Length;
			int length3 = this._delimiterEscape.Length;
			int length4 = data.Length;
			int length5 = this._rowSeparator.Length;
			bool? flag = null;
			isEndOfLine = false;
			int num = position;
			if (position + length <= length4)
			{
				if (!global::Infragistics.Windows.DataPresenter.PlainTextClipboardEncoding.StartsWith(data, position, this._cellDelimiter))
				{
					flag = new bool?(false);
				}
				else
				{
					position += length;
					if (this._delimiterCriteria == null)
					{
						flag = new bool?(true);
					}
				}
			}
			while (position < data.Length)
			{
				if (flag != false && global::Infragistics.Windows.DataPresenter.PlainTextClipboardEncoding.StartsWith(data, position, this._delimiterEscape))
				{
					flag = new bool?(true);
					position += length3;
				}
				else if (flag == null && global::System.Array.IndexOf<char>(this._delimiterCriteria, data[position]) >= 0)
				{
					flag = new bool?(true);
					position++;
				}
				else
				{
					if (flag != true && global::Infragistics.Windows.DataPresenter.PlainTextClipboardEncoding.StartsWith(data, position, this._cellSeparator))
					{
						string cell = data.Substring(num, position - num);
						position += length2;
						return this.UnescapeDelimiter(cell, flag);
					}
					if (flag != true && global::Infragistics.Windows.DataPresenter.PlainTextClipboardEncoding.StartsWith(data, position, this._rowSeparator))
					{
						string cell2 = data.Substring(num, position - num);
						isEndOfLine = true;
						position += length5;
						return this.UnescapeDelimiter(cell2, flag);
					}
					if (flag != false && global::Infragistics.Windows.DataPresenter.PlainTextClipboardEncoding.StartsWith(data, position, this._cellDelimiter))
					{
						if (global::Infragistics.Windows.DataPresenter.PlainTextClipboardEncoding.StartsWith(data, position + length, this._cellSeparator))
						{
							num += length;
							string cell3 = data.Substring(num, position - num);
							position += length + length2;
							return this.UnescapeDelimiter(cell3, flag);
						}
						if (global::Infragistics.Windows.DataPresenter.PlainTextClipboardEncoding.StartsWith(data, position + length, this._rowSeparator))
						{
							if (flag == true)
							{
								num += length;
							}
							else
							{
								position += length;
							}
							string cell4 = data.Substring(num, position - num);
							if (flag == true)
							{
								position += length;
							}
							position += length5;
							isEndOfLine = true;
							return this.UnescapeDelimiter(cell4, flag);
						}
						position += length;
					}
					else
					{
						position++;
					}
				}
			}
			return data.Substring(num, length4 - num);
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x0001932C File Offset: 0x0001752C
		private static bool StartsWith(string data, int index, string comparison)
		{
			int length = comparison.Length;
			if (index + length > data.Length)
			{
				return false;
			}
			if (length == 0)
			{
				return false;
			}
			if (length == 1)
			{
				return data[index] == comparison[0];
			}
			return data.IndexOf(comparison, index, length) == index;
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00019374 File Offset: 0x00017574
		private string UnescapeDelimiter(string cell, bool? inDelimiter)
		{
			if (inDelimiter == true && !string.IsNullOrEmpty(cell))
			{
				cell = cell.Replace(this._delimiterEscape, this._cellDelimiter);
			}
			return cell;
		}

		// Token: 0x040001E9 RID: 489
		private string _rowSeparator;

		// Token: 0x040001EA RID: 490
		private string _cellSeparator;

		// Token: 0x040001EB RID: 491
		private string _cellDelimiter;

		// Token: 0x040001EC RID: 492
		private char[] _delimiterCriteria;

		// Token: 0x040001ED RID: 493
		private string _delimiterEscape;

		// Token: 0x040001EE RID: 494
		private global::System.Text.Encoding _encoding;
	}
}
