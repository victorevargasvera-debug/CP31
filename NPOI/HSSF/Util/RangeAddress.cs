using System;
using System.Globalization;
using System.Text;

namespace NPOI.HSSF.Util
{
	// Token: 0x02000343 RID: 835
	public class RangeAddress
	{
		// Token: 0x060018EA RID: 6378 RVA: 0x0004C762 File Offset: 0x0004A962
		public RangeAddress(string _url)
		{
			this.init(_url);
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x0004C774 File Offset: 0x0004A974
		public RangeAddress(int _startCol, int _startRow, int _endCol, int _endRow)
		{
			this.init(string.Concat(new string[]
			{
				this.NumTo26Sys(_startCol),
				_startRow.ToString(),
				":",
				this.NumTo26Sys(_endCol),
				_endRow.ToString()
			}));
		}

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x060018EC RID: 6380 RVA: 0x0004C7C8 File Offset: 0x0004A9C8
		public string Address
		{
			get
			{
				string text = "";
				if (this.m_sheetName != null)
				{
					text = text + this.m_sheetName + "!";
				}
				if (this.m_cellFrom != null)
				{
					text += this.m_cellFrom;
					if (this.m_cellTo != null)
					{
						text = text + ":" + this.m_cellTo;
					}
				}
				return text;
			}
		}

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x060018ED RID: 6381 RVA: 0x0004C825 File Offset: 0x0004AA25
		public string SheetName
		{
			get
			{
				return this.m_sheetName;
			}
		}

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x060018EE RID: 6382 RVA: 0x0004C830 File Offset: 0x0004AA30
		public string Range
		{
			get
			{
				string text = "";
				if (this.m_cellFrom != null)
				{
					text += this.m_cellFrom;
					if (this.m_cellTo != null)
					{
						text = text + ":" + this.m_cellTo;
					}
				}
				return text;
			}
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x0004C873 File Offset: 0x0004AA73
		public bool IsCellOk(string _cell)
		{
			return _cell != null && (this.GetYPosition(_cell) != -1 && this.GetXPosition(_cell) != -1);
		}

		// Token: 0x060018F0 RID: 6384 RVA: 0x0004C891 File Offset: 0x0004AA91
		public bool IsSheetNameOk()
		{
			return global::NPOI.HSSF.Util.RangeAddress.IsSheetNameOk(this.m_sheetName);
		}

		// Token: 0x060018F1 RID: 6385 RVA: 0x0004C8A0 File Offset: 0x0004AAA0
		private static bool intern_isSheetNameOk(string _sheetName, bool _canBeWaitSpace)
		{
			foreach (char c in _sheetName)
			{
				if (!char.IsLetterOrDigit(c) && c != '_' && (!_canBeWaitSpace || c != ' '))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060018F2 RID: 6386 RVA: 0x0004C8E0 File Offset: 0x0004AAE0
		public static bool IsSheetNameOk(string _sheetName)
		{
			return string.IsNullOrEmpty(_sheetName) || global::NPOI.HSSF.Util.RangeAddress.intern_isSheetNameOk(_sheetName, true);
		}

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x060018F3 RID: 6387 RVA: 0x0004C904 File Offset: 0x0004AB04
		public string FromCell
		{
			get
			{
				return this.m_cellFrom;
			}
		}

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x060018F4 RID: 6388 RVA: 0x0004C90C File Offset: 0x0004AB0C
		public string ToCell
		{
			get
			{
				return this.m_cellTo;
			}
		}

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x060018F5 RID: 6389 RVA: 0x0004C914 File Offset: 0x0004AB14
		public int Width
		{
			get
			{
				if (this.m_cellFrom == null || this.m_cellTo == null)
				{
					return 0;
				}
				int xposition = this.GetXPosition(this.m_cellTo);
				int xposition2 = this.GetXPosition(this.m_cellFrom);
				if (xposition == -1 || xposition2 == -1)
				{
					return 0;
				}
				return xposition - xposition2 + 1;
			}
		}

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x060018F6 RID: 6390 RVA: 0x0004C95C File Offset: 0x0004AB5C
		public int Height
		{
			get
			{
				if (this.m_cellFrom == null || this.m_cellTo == null)
				{
					return 0;
				}
				int yposition = this.GetYPosition(this.m_cellTo);
				int yposition2 = this.GetYPosition(this.m_cellFrom);
				if (yposition == -1 || yposition2 == -1)
				{
					return 0;
				}
				return yposition - yposition2 + 1;
			}
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x0004C9A4 File Offset: 0x0004ABA4
		public void SetSize(int _width, int _height)
		{
			if (this.m_cellFrom == null)
			{
				this.m_cellFrom = "a1";
			}
			int xposition = this.GetXPosition(this.m_cellFrom);
			int yposition = this.GetYPosition(this.m_cellFrom);
			this.m_cellTo = this.NumTo26Sys(xposition + _width - 1);
			this.m_cellTo += (yposition + _height - 1).ToString(global::System.Globalization.CultureInfo.InvariantCulture);
		}

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x060018F8 RID: 6392 RVA: 0x0004CA12 File Offset: 0x0004AC12
		public bool HasSheetName
		{
			get
			{
				return this.m_sheetName != null;
			}
		}

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x060018F9 RID: 6393 RVA: 0x0004CA1F File Offset: 0x0004AC1F
		public bool HasRange
		{
			get
			{
				return this.m_cellFrom != null && this.m_cellTo != null && !this.m_cellFrom.Equals(this.m_cellTo);
			}
		}

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x060018FA RID: 6394 RVA: 0x0004CA47 File Offset: 0x0004AC47
		public bool HasCell
		{
			get
			{
				return this.m_cellFrom != null;
			}
		}

		// Token: 0x060018FB RID: 6395 RVA: 0x0004CA54 File Offset: 0x0004AC54
		private void init(string _url)
		{
			_url = this.RemoveString(_url, "$");
			_url = this.RemoveString(_url, "'");
			string[] array = this.ParseURL(_url);
			this.m_sheetName = array[0];
			this.m_cellFrom = array[1];
			this.m_cellTo = array[2];
			if (this.m_cellTo == null)
			{
				this.m_cellTo = this.m_cellFrom;
			}
			this.m_cellTo = this.RemoveString(this.m_cellTo, ".");
		}

		// Token: 0x060018FC RID: 6396 RVA: 0x0004CACC File Offset: 0x0004ACCC
		private string[] ParseURL(string _url)
		{
			string[] array = new string[3];
			int num = _url.IndexOf(':');
			if (num >= 0)
			{
				string text = _url.Substring(0, num);
				string text2 = _url.Substring(num + 1);
				num = text.IndexOf('!');
				if (num >= 0)
				{
					array[0] = text.Substring(0, num);
					array[1] = text.Substring(num + 1);
				}
				else
				{
					array[1] = text;
				}
				num = text2.IndexOf('!');
				if (num >= 0)
				{
					array[2] = text2.Substring(num + 1);
				}
				else
				{
					array[2] = text2;
				}
			}
			else
			{
				num = _url.IndexOf('!');
				if (num >= 0)
				{
					array[0] = _url.Substring(0, num);
					array[1] = _url.Substring(num + 1);
				}
				else
				{
					array[1] = _url;
				}
			}
			return array;
		}

		// Token: 0x060018FD RID: 6397 RVA: 0x0004CB78 File Offset: 0x0004AD78
		public int GetYPosition(string _subrange)
		{
			int num = -1;
			_subrange = _subrange.Trim();
			if (_subrange.Length != 0)
			{
				string digitPart = this.GetDigitPart(_subrange);
				try
				{
					num = int.Parse(digitPart, global::System.Globalization.CultureInfo.InvariantCulture);
					if (num > 66666)
					{
						num = -1;
					}
				}
				catch (global::System.Exception)
				{
					num = -1;
				}
			}
			return num;
		}

		// Token: 0x060018FE RID: 6398 RVA: 0x0004CBD0 File Offset: 0x0004ADD0
		private static bool IsLetter(string _str)
		{
			bool result = true;
			if (!string.IsNullOrEmpty(_str))
			{
				for (int i = 0; i < _str.Length; i++)
				{
					if (!char.IsLetter(_str[i]))
					{
						result = false;
						break;
					}
				}
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060018FF RID: 6399 RVA: 0x0004CC10 File Offset: 0x0004AE10
		public int GetXPosition(string _subrange)
		{
			int result = -1;
			string text = this.Filter(_subrange);
			text = this.GetCharPart(_subrange);
			if (global::NPOI.HSSF.Util.RangeAddress.IsLetter(text) && (text.Length == 2 || text.Length == 1))
			{
				result = this.Get26Sys(text);
			}
			return result;
		}

		// Token: 0x06001900 RID: 6400 RVA: 0x0004CC54 File Offset: 0x0004AE54
		public string GetDigitPart(string _value)
		{
			string result = "";
			int firstDigitPosition = this.GetFirstDigitPosition(_value);
			if (firstDigitPosition >= 0)
			{
				result = _value.Substring(firstDigitPosition);
			}
			return result;
		}

		// Token: 0x06001901 RID: 6401 RVA: 0x0004CC7C File Offset: 0x0004AE7C
		public string GetCharPart(string _value)
		{
			string result = "";
			int firstDigitPosition = this.GetFirstDigitPosition(_value);
			if (firstDigitPosition >= 0)
			{
				result = _value.Substring(0, firstDigitPosition);
			}
			return result;
		}

		// Token: 0x06001902 RID: 6402 RVA: 0x0004CCA8 File Offset: 0x0004AEA8
		private string Filter(string _range)
		{
			string text = "";
			foreach (char c in _range)
			{
				if (c != '$')
				{
					text += c.ToString();
				}
			}
			return text;
		}

		// Token: 0x06001903 RID: 6403 RVA: 0x0004CCE8 File Offset: 0x0004AEE8
		private int GetFirstDigitPosition(string _value)
		{
			int result = -1;
			if (_value != null && _value.Trim().Length == 0)
			{
				return result;
			}
			_value = _value.Trim();
			int length = _value.Length;
			for (int i = 0; i < length; i++)
			{
				if (char.IsDigit(_value[i]))
				{
					result = i;
					break;
				}
			}
			return result;
		}

		// Token: 0x06001904 RID: 6404 RVA: 0x0004CD38 File Offset: 0x0004AF38
		public int Get26Sys(string _s)
		{
			int num = 0;
			int num2 = 1;
			if (!string.IsNullOrEmpty(_s))
			{
				for (int i = _s.Length - 1; i >= 0; i--)
				{
					int num3 = (int)(char.GetNumericValue(_s[i]) - char.GetNumericValue('A') + 1.0);
					num += num3 * num2;
					num2 *= 26;
				}
				return num;
			}
			return -1;
		}

		// Token: 0x06001905 RID: 6405 RVA: 0x0004CD94 File Offset: 0x0004AF94
		public string NumTo26Sys(int _num)
		{
			string text = "";
			do
			{
				_num--;
				int num = _num % 26;
				char c = (char)(65 + num);
				_num /= 26;
				text = c.ToString() + text;
			}
			while (_num > 0);
			return text;
		}

		// Token: 0x06001906 RID: 6406 RVA: 0x0004CDD0 File Offset: 0x0004AFD0
		public string ReplaceString(string _source, string _oldPattern, string _newPattern)
		{
			return new global::System.Text.StringBuilder(_source).Replace(_oldPattern, _newPattern).ToString();
		}

		// Token: 0x06001907 RID: 6407 RVA: 0x0004CDE4 File Offset: 0x0004AFE4
		public string RemoveString(string _source, string _match)
		{
			return this.ReplaceString(_source, _match, "");
		}

		// Token: 0x040009F7 RID: 2551
		private const int WRONG_POS = -1;

		// Token: 0x040009F8 RID: 2552
		private const int MAX_HEIGHT = 66666;

		// Token: 0x040009F9 RID: 2553
		private string m_sheetName;

		// Token: 0x040009FA RID: 2554
		private string m_cellFrom;

		// Token: 0x040009FB RID: 2555
		private string m_cellTo;
	}
}
