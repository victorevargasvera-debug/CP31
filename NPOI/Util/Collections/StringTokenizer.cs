using System;

namespace NPOI.Util.Collections
{
	// Token: 0x0200029A RID: 666
	public class StringTokenizer
	{
		// Token: 0x06001248 RID: 4680 RVA: 0x00036BBF File Offset: 0x00034DBF
		public StringTokenizer(string str) : this(str, " \t\n\r\f", false)
		{
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x00036BCE File Offset: 0x00034DCE
		public StringTokenizer(string str, string delim) : this(str, delim, false)
		{
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x00036BD9 File Offset: 0x00034DD9
		public StringTokenizer(string str, string delim, bool retDelims)
		{
			this.len = str.Length;
			this.str = str;
			this.delim = delim;
			this.retDelims = retDelims;
			this.pos = 0;
		}

		// Token: 0x0600124B RID: 4683 RVA: 0x00036C0C File Offset: 0x00034E0C
		public bool HasMoreTokens()
		{
			if (!this.retDelims)
			{
				while (this.pos < this.len && this.delim.IndexOf(this.str[this.pos]) >= 0)
				{
					this.pos++;
				}
			}
			return this.pos < this.len;
		}

		// Token: 0x0600124C RID: 4684 RVA: 0x00036C6C File Offset: 0x00034E6C
		public string NextToken(string delim)
		{
			this.delim = delim;
			return this.NextToken();
		}

		// Token: 0x0600124D RID: 4685 RVA: 0x00036C7C File Offset: 0x00034E7C
		public string NextToken()
		{
			if (this.pos < this.len && this.delim.IndexOf(this.str[this.pos]) >= 0)
			{
				int num;
				if (this.retDelims)
				{
					string text = this.str;
					num = this.pos;
					this.pos = num + 1;
					return text.Substring(num, 1);
				}
				do
				{
					num = this.pos + 1;
					this.pos = num;
				}
				while (num < this.len && this.delim.IndexOf(this.str[this.pos]) >= 0);
			}
			if (this.pos < this.len)
			{
				int num2 = this.pos;
				int num;
				do
				{
					num = this.pos + 1;
					this.pos = num;
				}
				while (num < this.len && this.delim.IndexOf(this.str[this.pos]) < 0);
				return this.str.Substring(num2, this.pos - num2);
			}
			throw new global::System.IndexOutOfRangeException();
		}

		// Token: 0x0600124E RID: 4686 RVA: 0x00036D7C File Offset: 0x00034F7C
		public int CountTokens()
		{
			int num = 0;
			int num2 = 0;
			bool flag = false;
			int i = this.pos;
			while (i < this.len)
			{
				if (this.delim.IndexOf(this.str[i++]) >= 0)
				{
					if (flag)
					{
						num++;
						flag = false;
					}
					num2++;
				}
				else
				{
					flag = true;
					while (i < this.len && this.delim.IndexOf(this.str[i]) < 0)
					{
						i++;
					}
				}
			}
			if (flag)
			{
				num++;
			}
			if (!this.retDelims)
			{
				return num;
			}
			return num + num2;
		}

		// Token: 0x0400078B RID: 1931
		private int pos;

		// Token: 0x0400078C RID: 1932
		private string str;

		// Token: 0x0400078D RID: 1933
		private int len;

		// Token: 0x0400078E RID: 1934
		private string delim;

		// Token: 0x0400078F RID: 1935
		private bool retDelims;
	}
}
