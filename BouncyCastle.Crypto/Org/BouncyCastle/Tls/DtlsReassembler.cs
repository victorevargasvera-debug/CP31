using System;
using System.Collections;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000BB RID: 187
	internal sealed class DtlsReassembler
	{
		// Token: 0x06000704 RID: 1796 RVA: 0x0001D182 File Offset: 0x0001B382
		internal DtlsReassembler(short msg_type, int length)
		{
			this.m_msg_type = msg_type;
			this.m_body = new byte[length];
			this.m_missing.Add(new global::Org.BouncyCastle.Tls.DtlsReassembler.Range(0, length));
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000705 RID: 1797 RVA: 0x0001D1BB File Offset: 0x0001B3BB
		internal short MsgType
		{
			get
			{
				return this.m_msg_type;
			}
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x0001D1C3 File Offset: 0x0001B3C3
		internal byte[] GetBodyIfComplete()
		{
			if (this.m_missing.Count <= 0)
			{
				return this.m_body;
			}
			return null;
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x0001D1DC File Offset: 0x0001B3DC
		internal void ContributeFragment(short msg_type, int length, byte[] buf, int off, int fragment_offset, int fragment_length)
		{
			int fragment_end = fragment_offset + fragment_length;
			if (this.m_msg_type != msg_type || this.m_body.Length != length || fragment_end > length)
			{
				return;
			}
			if (fragment_length == 0)
			{
				if (fragment_offset == 0 && this.m_missing.Count > 0 && ((global::Org.BouncyCastle.Tls.DtlsReassembler.Range)this.m_missing[0]).End == 0)
				{
					this.m_missing.RemoveAt(0);
				}
				return;
			}
			for (int i = 0; i < this.m_missing.Count; i++)
			{
				global::Org.BouncyCastle.Tls.DtlsReassembler.Range range = (global::Org.BouncyCastle.Tls.DtlsReassembler.Range)this.m_missing[i];
				if (range.Start >= fragment_end)
				{
					break;
				}
				if (range.End > fragment_offset)
				{
					int copyStart = global::System.Math.Max(range.Start, fragment_offset);
					int copyEnd = global::System.Math.Min(range.End, fragment_end);
					int copyLength = copyEnd - copyStart;
					global::System.Array.Copy(buf, off + copyStart - fragment_offset, this.m_body, copyStart, copyLength);
					if (copyStart == range.Start)
					{
						if (copyEnd == range.End)
						{
							this.m_missing.RemoveAt(i--);
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
							this.m_missing.Insert(++i, new global::Org.BouncyCastle.Tls.DtlsReassembler.Range(copyEnd, range.End));
						}
						range.End = copyStart;
					}
				}
			}
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x0001D31F File Offset: 0x0001B51F
		internal void Reset()
		{
			this.m_missing.Clear();
			this.m_missing.Add(new global::Org.BouncyCastle.Tls.DtlsReassembler.Range(0, this.m_body.Length));
		}

		// Token: 0x040004E0 RID: 1248
		private readonly short m_msg_type;

		// Token: 0x040004E1 RID: 1249
		private readonly byte[] m_body;

		// Token: 0x040004E2 RID: 1250
		private readonly global::System.Collections.IList m_missing = global::Org.BouncyCastle.Utilities.Platform.CreateArrayList();

		// Token: 0x020007A3 RID: 1955
		private sealed class Range
		{
			// Token: 0x06004508 RID: 17672 RVA: 0x00132701 File Offset: 0x00130901
			internal Range(int start, int end)
			{
				this.m_start = start;
				this.m_end = end;
			}

			// Token: 0x17000A6C RID: 2668
			// (get) Token: 0x06004509 RID: 17673 RVA: 0x00132717 File Offset: 0x00130917
			// (set) Token: 0x0600450A RID: 17674 RVA: 0x0013271F File Offset: 0x0013091F
			public int Start
			{
				get
				{
					return this.m_start;
				}
				set
				{
					this.m_start = value;
				}
			}

			// Token: 0x17000A6D RID: 2669
			// (get) Token: 0x0600450B RID: 17675 RVA: 0x00132728 File Offset: 0x00130928
			// (set) Token: 0x0600450C RID: 17676 RVA: 0x00132730 File Offset: 0x00130930
			public int End
			{
				get
				{
					return this.m_end;
				}
				set
				{
					this.m_end = value;
				}
			}

			// Token: 0x040022FF RID: 8959
			private int m_start;

			// Token: 0x04002300 RID: 8960
			private int m_end;
		}
	}
}
