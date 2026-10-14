using System;
using System.Collections;
using System.IO;
using System.Text;

namespace NPOI.Util.Collections
{
	// Token: 0x02000299 RID: 665
	public class Properties
	{
		// Token: 0x0600123A RID: 4666 RVA: 0x0003672F File Offset: 0x0003492F
		public Properties()
		{
			this._col = new global::System.Collections.Hashtable();
		}

		// Token: 0x0600123B RID: 4667 RVA: 0x00036742 File Offset: 0x00034942
		public string Remove(string key)
		{
			string result = (string)this._col[key];
			this._col.Remove(key);
			return result;
		}

		// Token: 0x0600123C RID: 4668 RVA: 0x00036761 File Offset: 0x00034961
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return this._col.GetEnumerator();
		}

		// Token: 0x0600123D RID: 4669 RVA: 0x0003676E File Offset: 0x0003496E
		public bool ContainsKey(string key)
		{
			return this._col.ContainsKey(key);
		}

		// Token: 0x0600123E RID: 4670 RVA: 0x0003677C File Offset: 0x0003497C
		public virtual void Add(string key, string value)
		{
			this._col[key] = value;
		}

		// Token: 0x0600123F RID: 4671 RVA: 0x0003678C File Offset: 0x0003498C
		public void AddAll(global::NPOI.Util.Collections.Properties col)
		{
			foreach (object obj in col.Keys)
			{
				string key = (string)obj;
				this._col[key] = col[key];
			}
		}

		// Token: 0x1700035B RID: 859
		// (get) Token: 0x06001240 RID: 4672 RVA: 0x000367F4 File Offset: 0x000349F4
		public int Count
		{
			get
			{
				return this._col.Count;
			}
		}

		// Token: 0x1700035C RID: 860
		public virtual string this[string key]
		{
			get
			{
				return (string)this._col[key];
			}
			set
			{
				this._col[key] = value;
			}
		}

		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06001243 RID: 4675 RVA: 0x00036814 File Offset: 0x00034A14
		public global::System.Collections.ICollection Keys
		{
			get
			{
				return this._col.Keys;
			}
		}

		// Token: 0x06001244 RID: 4676 RVA: 0x00036821 File Offset: 0x00034A21
		public void Clear()
		{
			this._col.Clear();
		}

		// Token: 0x06001245 RID: 4677 RVA: 0x00036830 File Offset: 0x00034A30
		public void Load(global::System.IO.Stream inStream)
		{
			global::System.IO.StreamReader streamReader = new global::System.IO.StreamReader(inStream, global::System.Text.Encoding.GetEncoding(1252));
			for (;;)
			{
				string text = streamReader.ReadLine();
				if (text == null)
				{
					break;
				}
				if (text.Length > 0)
				{
					int length = text.Length;
					int num = 0;
					while (num < length && " \t\r\n\f".IndexOf(text[num]) != -1)
					{
						num++;
					}
					if (num != length)
					{
						char c = text[num];
						if (c != '#' && c != '!')
						{
							while (this.ContinueLine(text))
							{
								string text2 = streamReader.ReadLine();
								if (text2 == null)
								{
									text2 = "";
								}
								string str = text.Substring(0, length - 1);
								int num2 = 0;
								while (num2 < text2.Length && " \t\r\n\f".IndexOf(text2[num2]) != -1)
								{
									num2++;
								}
								text2 = text2.Substring(num2, text2.Length - num2);
								text = str + text2;
								length = text.Length;
							}
							int i;
							for (i = num; i < length; i++)
							{
								char c2 = text[i];
								if (c2 == '\\')
								{
									i++;
								}
								else if ("=: \t\r\n\f".IndexOf(c2) != -1)
								{
									break;
								}
							}
							int num3 = i;
							while (num3 < length && " \t\r\n\f".IndexOf(text[num3]) != -1)
							{
								num3++;
							}
							if (num3 < length && "=:".IndexOf(text[num3]) != -1)
							{
								num3++;
							}
							while (num3 < length && " \t\r\n\f".IndexOf(text[num3]) != -1)
							{
								num3++;
							}
							string text3 = text.Substring(num, i - num);
							string text4 = (i < length) ? text.Substring(num3, length - num3) : "";
							text3 = this.LoadConvert(text3);
							text4 = this.LoadConvert(text4);
							this.Add(text3, text4);
						}
					}
				}
			}
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x00036A08 File Offset: 0x00034C08
		private string LoadConvert(string theString)
		{
			int length = theString.Length;
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(length);
			int i = 0;
			while (i < length)
			{
				char c = theString[i++];
				if (c == '\\')
				{
					c = theString[i++];
					if (c == 'u')
					{
						int num = 0;
						int j = 0;
						while (j < 4)
						{
							c = theString[i++];
							switch (c)
							{
							case '0':
							case '1':
							case '2':
							case '3':
							case '4':
							case '5':
							case '6':
							case '7':
							case '8':
							case '9':
								num = (num << 4) + (int)c - 48;
								break;
							case ':':
							case ';':
							case '<':
							case '=':
							case '>':
							case '?':
							case '@':
								goto IL_109;
							case 'A':
							case 'B':
							case 'C':
							case 'D':
							case 'E':
							case 'F':
								num = (num << 4) + 10 + (int)c - 65;
								break;
							default:
								switch (c)
								{
								case 'a':
								case 'b':
								case 'c':
								case 'd':
								case 'e':
								case 'f':
									num = (num << 4) + 10 + (int)c - 97;
									break;
								default:
									goto IL_109;
								}
								break;
							}
							j++;
							continue;
							IL_109:
							throw new global::System.ArgumentException("Malformed \\uxxxx encoding.");
						}
						stringBuilder.Append((char)num);
					}
					else
					{
						if (c == 't')
						{
							c = '\t';
						}
						else if (c == 'r')
						{
							c = '\r';
						}
						else if (c == 'n')
						{
							c = '\n';
						}
						else if (c == 'f')
						{
							c = '\f';
						}
						stringBuilder.Append(c);
					}
				}
				else
				{
					stringBuilder.Append(c);
				}
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x00036B88 File Offset: 0x00034D88
		private bool ContinueLine(string line)
		{
			int num = 0;
			int num2 = line.Length - 1;
			while (num2 >= 0 && line[num2--] == '\\')
			{
				num++;
			}
			return num % 2 == 1;
		}

		// Token: 0x04000787 RID: 1927
		private global::System.Collections.Hashtable _col;

		// Token: 0x04000788 RID: 1928
		private const string whiteSpaceChars = " \t\r\n\f";

		// Token: 0x04000789 RID: 1929
		private const string keyValueSeparators = "=: \t\r\n\f";

		// Token: 0x0400078A RID: 1930
		private const string strictKeyValueSeparators = "=:";
	}
}
