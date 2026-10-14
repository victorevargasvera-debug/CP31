using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Utilities
{
	// Token: 0x020002EE RID: 750
	public class BasicAlphabetMapper : global::Org.BouncyCastle.Crypto.IAlphabetMapper
	{
		// Token: 0x06002007 RID: 8199 RVA: 0x00090544 File Offset: 0x0008E744
		public BasicAlphabetMapper(string alphabet) : this(alphabet.ToCharArray())
		{
		}

		// Token: 0x06002008 RID: 8200 RVA: 0x00090554 File Offset: 0x0008E754
		public BasicAlphabetMapper(char[] alphabet)
		{
			for (int i = 0; i != alphabet.Length; i++)
			{
				if (this.indexMap.Contains(alphabet[i]))
				{
					throw new global::System.ArgumentException("duplicate key detected in alphabet: " + alphabet[i].ToString());
				}
				this.indexMap.Add(alphabet[i], i);
				this.charMap.Add(i, alphabet[i]);
			}
		}

		// Token: 0x1700046D RID: 1133
		// (get) Token: 0x06002009 RID: 8201 RVA: 0x000905EE File Offset: 0x0008E7EE
		public int Radix
		{
			get
			{
				return this.indexMap.Count;
			}
		}

		// Token: 0x0600200A RID: 8202 RVA: 0x000905FC File Offset: 0x0008E7FC
		public byte[] ConvertToIndexes(char[] input)
		{
			byte[] outBuf;
			if (this.indexMap.Count <= 256)
			{
				outBuf = new byte[input.Length];
				for (int i = 0; i != input.Length; i++)
				{
					outBuf[i] = (byte)((int)this.indexMap[input[i]]);
				}
			}
			else
			{
				outBuf = new byte[input.Length * 2];
				for (int j = 0; j != input.Length; j++)
				{
					int idx = (int)this.indexMap[input[j]];
					outBuf[j * 2] = (byte)(idx >> 8 & 255);
					outBuf[j * 2 + 1] = (byte)(idx & 255);
				}
			}
			return outBuf;
		}

		// Token: 0x0600200B RID: 8203 RVA: 0x000906A4 File Offset: 0x0008E8A4
		public char[] ConvertToChars(byte[] input)
		{
			char[] outBuf;
			if (this.charMap.Count <= 256)
			{
				outBuf = new char[input.Length];
				for (int i = 0; i != input.Length; i++)
				{
					outBuf[i] = (char)this.charMap[(int)(input[i] & byte.MaxValue)];
				}
			}
			else
			{
				if ((input.Length & 1) != 0)
				{
					throw new global::System.ArgumentException("two byte radix and input string odd.Length");
				}
				outBuf = new char[input.Length / 2];
				for (int j = 0; j != input.Length; j += 2)
				{
					outBuf[j / 2] = (char)this.charMap[((int)input[j] << 8 & 65280) | (int)(input[j + 1] & byte.MaxValue)];
				}
			}
			return outBuf;
		}

		// Token: 0x04000B3A RID: 2874
		private readonly global::System.Collections.IDictionary indexMap = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();

		// Token: 0x04000B3B RID: 2875
		private readonly global::System.Collections.IDictionary charMap = global::Org.BouncyCastle.Utilities.Platform.CreateHashtable();
	}
}
