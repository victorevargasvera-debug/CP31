using System;
using System.Text;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000682 RID: 1666
	public class X509NameTokenizer
	{
		// Token: 0x06003D8D RID: 15757 RVA: 0x00118F40 File Offset: 0x00117140
		public X509NameTokenizer(string oid) : this(oid, ',')
		{
		}

		// Token: 0x06003D8E RID: 15758 RVA: 0x00118F4B File Offset: 0x0011714B
		public X509NameTokenizer(string oid, char separator)
		{
			this.value = oid;
			this.index = -1;
			this.separator = separator;
		}

		// Token: 0x06003D8F RID: 15759 RVA: 0x00118F73 File Offset: 0x00117173
		public bool HasMoreTokens()
		{
			return this.index != this.value.Length;
		}

		// Token: 0x06003D90 RID: 15760 RVA: 0x00118F8C File Offset: 0x0011718C
		public string NextToken()
		{
			if (this.index == this.value.Length)
			{
				return null;
			}
			int end = this.index + 1;
			bool quoted = false;
			bool escaped = false;
			this.buffer.Remove(0, this.buffer.Length);
			while (end != this.value.Length)
			{
				char c = this.value[end];
				if (c == '"')
				{
					if (!escaped)
					{
						quoted = !quoted;
					}
					else
					{
						this.buffer.Append(c);
						escaped = false;
					}
				}
				else if (escaped || quoted)
				{
					if (c == '#' && this.buffer[this.buffer.Length - 1] == '=')
					{
						this.buffer.Append('\\');
					}
					else if (c == '+' && this.separator != '+')
					{
						this.buffer.Append('\\');
					}
					this.buffer.Append(c);
					escaped = false;
				}
				else if (c == '\\')
				{
					escaped = true;
				}
				else
				{
					if (c == this.separator)
					{
						break;
					}
					this.buffer.Append(c);
				}
				end++;
			}
			this.index = end;
			return this.buffer.ToString().Trim();
		}

		// Token: 0x04001B64 RID: 7012
		private string value;

		// Token: 0x04001B65 RID: 7013
		private int index;

		// Token: 0x04001B66 RID: 7014
		private char separator;

		// Token: 0x04001B67 RID: 7015
		private global::System.Text.StringBuilder buffer = new global::System.Text.StringBuilder();
	}
}
