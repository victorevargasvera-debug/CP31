using System;
using System.Collections.Generic;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Security.Cryptography;
using System.Text;

namespace System.Data.Entity.Core.Mapping
{
	// Token: 0x0200055D RID: 1373
	internal class StringHashBuilder
	{
		// Token: 0x06004335 RID: 17205 RVA: 0x000E65D0 File Offset: 0x000E47D0
		internal StringHashBuilder(global::System.Security.Cryptography.HashAlgorithm hashAlgorithm)
		{
			this._hashAlgorithm = hashAlgorithm;
		}

		// Token: 0x06004336 RID: 17206 RVA: 0x000E65EA File Offset: 0x000E47EA
		internal StringHashBuilder(global::System.Security.Cryptography.HashAlgorithm hashAlgorithm, int startingBufferSize) : this(hashAlgorithm)
		{
			this._cachedBuffer = new byte[startingBufferSize];
		}

		// Token: 0x17000D56 RID: 3414
		// (get) Token: 0x06004337 RID: 17207 RVA: 0x000E65FF File Offset: 0x000E47FF
		internal int CharCount
		{
			get
			{
				return this._totalLength;
			}
		}

		// Token: 0x06004338 RID: 17208 RVA: 0x000E6607 File Offset: 0x000E4807
		internal virtual void Append(string s)
		{
			this.InternalAppend(s);
		}

		// Token: 0x06004339 RID: 17209 RVA: 0x000E6610 File Offset: 0x000E4810
		internal virtual void AppendLine(string s)
		{
			this.InternalAppend(s);
			this.InternalAppend("\n");
		}

		// Token: 0x0600433A RID: 17210 RVA: 0x000E6624 File Offset: 0x000E4824
		private void InternalAppend(string s)
		{
			if (s.Length == 0)
			{
				return;
			}
			this._strings.Add(s);
			this._totalLength += s.Length;
		}

		// Token: 0x0600433B RID: 17211 RVA: 0x000E6650 File Offset: 0x000E4850
		internal string ComputeHash()
		{
			int byteCount = this.GetByteCount();
			if (this._cachedBuffer == null)
			{
				this._cachedBuffer = new byte[byteCount];
			}
			else if (this._cachedBuffer.Length < byteCount)
			{
				int num = global::System.Math.Max(this._cachedBuffer.Length + this._cachedBuffer.Length / 2, byteCount);
				this._cachedBuffer = new byte[num];
			}
			int num2 = 0;
			foreach (string text in this._strings)
			{
				num2 += global::System.Text.Encoding.Unicode.GetBytes(text, 0, text.Length, this._cachedBuffer, num2);
			}
			return global::System.Data.Entity.Core.Mapping.StringHashBuilder.ConvertHashToString(this._hashAlgorithm.ComputeHash(this._cachedBuffer, 0, byteCount));
		}

		// Token: 0x0600433C RID: 17212 RVA: 0x000E6724 File Offset: 0x000E4924
		internal void Clear()
		{
			this._strings.Clear();
			this._totalLength = 0;
		}

		// Token: 0x0600433D RID: 17213 RVA: 0x000E6738 File Offset: 0x000E4938
		public override string ToString()
		{
			global::System.Text.StringBuilder builder = new global::System.Text.StringBuilder();
			this._strings.Each((string s) => builder.Append(s));
			return builder.ToString();
		}

		// Token: 0x0600433E RID: 17214 RVA: 0x000E6778 File Offset: 0x000E4978
		private int GetByteCount()
		{
			int num = 0;
			foreach (string s in this._strings)
			{
				num += global::System.Text.Encoding.Unicode.GetByteCount(s);
			}
			return num;
		}

		// Token: 0x0600433F RID: 17215 RVA: 0x000E67D8 File Offset: 0x000E49D8
		private static string ConvertHashToString(byte[] hash)
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(hash.Length * 2);
			for (int i = 0; i < hash.Length; i++)
			{
				stringBuilder.Append(hash[i].ToString("x2", global::System.Globalization.CultureInfo.InvariantCulture));
			}
			return stringBuilder.ToString();
		}

		// Token: 0x06004340 RID: 17216 RVA: 0x000E6821 File Offset: 0x000E4A21
		public static string ComputeHash(global::System.Security.Cryptography.HashAlgorithm hashAlgorithm, string source)
		{
			global::System.Data.Entity.Core.Mapping.StringHashBuilder stringHashBuilder = new global::System.Data.Entity.Core.Mapping.StringHashBuilder(hashAlgorithm);
			stringHashBuilder.Append(source);
			return stringHashBuilder.ComputeHash();
		}

		// Token: 0x040017FA RID: 6138
		private readonly global::System.Security.Cryptography.HashAlgorithm _hashAlgorithm;

		// Token: 0x040017FB RID: 6139
		private const string NewLine = "\n";

		// Token: 0x040017FC RID: 6140
		private readonly global::System.Collections.Generic.List<string> _strings = new global::System.Collections.Generic.List<string>();

		// Token: 0x040017FD RID: 6141
		private int _totalLength;

		// Token: 0x040017FE RID: 6142
		private byte[] _cachedBuffer;
	}
}
