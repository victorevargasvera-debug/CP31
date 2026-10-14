using System;
using System.Text;

namespace NPOI.SS.Formula
{
	// Token: 0x020000AD RID: 173
	public class NameIdentifier
	{
		// Token: 0x06000601 RID: 1537 RVA: 0x0000DEC2 File Offset: 0x0000C0C2
		public NameIdentifier(string name, bool isQuoted)
		{
			this._name = name;
			this._isQuoted = isQuoted;
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000602 RID: 1538 RVA: 0x0000DED8 File Offset: 0x0000C0D8
		public string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000603 RID: 1539 RVA: 0x0000DEE0 File Offset: 0x0000C0E0
		public bool IsQuoted
		{
			get
			{
				return this._isQuoted;
			}
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x0000DEE8 File Offset: 0x0000C0E8
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(64);
			stringBuilder.Append(base.GetType().Name);
			stringBuilder.Append(" [");
			if (this._isQuoted)
			{
				stringBuilder.Append("'").Append(this._name).Append("'");
			}
			else
			{
				stringBuilder.Append(this._name);
			}
			stringBuilder.Append("]");
			return stringBuilder.ToString();
		}

		// Token: 0x0400038B RID: 907
		private string _name;

		// Token: 0x0400038C RID: 908
		private bool _isQuoted;
	}
}
