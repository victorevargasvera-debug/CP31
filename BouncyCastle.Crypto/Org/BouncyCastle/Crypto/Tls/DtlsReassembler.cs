using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000325 RID: 805
	internal class DtlsReassembler
	{
		// Token: 0x060021CA RID: 8650 RVA: 0x0009549D File Offset: 0x0009369D
		internal DtlsReassembler(byte msg_type, int length)
		{
			this.mMsgType = msg_type;
			this.mBody = new byte[length];
			this.mMissing.Add(new global::Org.BouncyCastle.Crypto.Tls.DtlsReassembler.Range(0, length));
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x060021CB RID: 8651 RVA: 0x000954D6 File Offset: 0x000936D6
		internal byte MsgType
		{
			get
			{
				return this.mMsgType;
			}
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x000954DE File Offset: 0x000936DE
		internal byte[] GetBodyIfComplete()
		{
			if (this.mMissing.Count != 0)
			{
				return null;
			}
			return this.mBody;
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x000954F8 File Offset: 0x000936F8
		internal void ContributeFragment(byte msg_type, int length, byte[] buf, int off, int fragment_offset, int fragment_length)
		{
			int fragment_end = fragment_offset + fragment_length;
			if (this.mMsgType != msg_type || this.mBody.Length != length || fragment_end > length)
			{
				return;
			}
			if (fragment_length == 0)
			{
				if (fragment_offset == 0 && this.mMissing.Count > 0 && ((global::Org.BouncyCastle.Crypto.Tls.DtlsReassembler.Range)this.mMissing[0]).End == 0)
				{
					this.mMissing.RemoveAt(0);
				}
				return;
			}
			for (int i = 0; i < this.mMissing.Count; i++)
			{
				global::Org.BouncyCastle.Crypto.Tls.DtlsReassembler.Range range = (global::Org.BouncyCastle.Crypto.Tls.DtlsReassembler.Range)this.mMissing[i];
				if (range.Start >= fragment_end)
				{
					break;
				}
				if (range.End > fragment_offset)
				{
					int copyStart = global::System.Math.Max(range.Start, fragment_offset);
					int copyEnd = global::System.Math.Min(range.End, fragment_end);
					int copyLength = copyEnd - copyStart;
					global::System.Array.Copy(buf, off + copyStart - fragment_offset, this.mBody, copyStart, copyLength);
					if (copyStart == range.Start)
					{
						if (copyEnd == range.End)
						{
							this.mMissing.RemoveAt(i--);
						}
						else
						{
							range.Start = copyEnd;
						}
					}
					else
					{
						if (copyEnd != range.End)
						{
							this.mMissing.Insert(++i, new global::Org.BouncyCastle.Crypto.Tls.DtlsReassembler.Range(copyEnd, range.End));
						}
						range.End = copyStart;
					}
				}
			}
		}

		// Token: 0x060021CE RID: 8654 RVA: 0x0009563B File Offset: 0x0009383B
		internal void Reset()
		{
			this.mMissing.Clear();
			this.mMissing.Add(new global::Org.BouncyCastle.Crypto.Tls.DtlsReassembler.Range(0, this.mBody.Length));
		}

		// Token: 0x04000CEA RID: 3306
		private readonly byte mMsgType;

		// Token: 0x04000CEB RID: 3307
		private readonly byte[] mBody;

		// Token: 0x04000CEC RID: 3308
		private readonly global::System.Collections.IList mMissing = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();

		// Token: 0x020007F6 RID: 2038
		private class Range
		{
			// Token: 0x0600462B RID: 17963 RVA: 0x00136232 File Offset: 0x00134432
			internal Range(int start, int end)
			{
				this.mStart = start;
				this.mEnd = end;
			}

			// Token: 0x17000AA2 RID: 2722
			// (get) Token: 0x0600462C RID: 17964 RVA: 0x00136248 File Offset: 0x00134448
			// (set) Token: 0x0600462D RID: 17965 RVA: 0x00136250 File Offset: 0x00134450
			public int Start
			{
				get
				{
					return this.mStart;
				}
				set
				{
					this.mStart = value;
				}
			}

			// Token: 0x17000AA3 RID: 2723
			// (get) Token: 0x0600462E RID: 17966 RVA: 0x00136259 File Offset: 0x00134459
			// (set) Token: 0x0600462F RID: 17967 RVA: 0x00136261 File Offset: 0x00134461
			public int End
			{
				get
				{
					return this.mEnd;
				}
				set
				{
					this.mEnd = value;
				}
			}

			// Token: 0x0400248F RID: 9359
			private int mStart;

			// Token: 0x04002490 RID: 9360
			private int mEnd;
		}
	}
}
