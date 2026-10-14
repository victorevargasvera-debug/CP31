using System;
using System.Text;
using NPOI.Util;

namespace NPOI.HSSF.Record.Common
{
	// Token: 0x0200045F RID: 1119
	public class FeatProtection : global::NPOI.HSSF.Record.Common.SharedFeature
	{
		// Token: 0x06002968 RID: 10600 RVA: 0x0007CC8C File Offset: 0x0007AE8C
		public FeatProtection()
		{
			this.securityDescriptor = new byte[0];
		}

		// Token: 0x06002969 RID: 10601 RVA: 0x0007CCA0 File Offset: 0x0007AEA0
		public FeatProtection(global::NPOI.HSSF.Record.RecordInputStream in1)
		{
			this.fSD = in1.ReadInt();
			this.passwordVerifier = in1.ReadInt();
			this.title = global::NPOI.Util.StringUtil.ReadUnicodeString(in1);
			this.securityDescriptor = in1.ReadRemainder();
		}

		// Token: 0x0600296A RID: 10602 RVA: 0x0007CCD8 File Offset: 0x0007AED8
		public override string ToString()
		{
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
			stringBuilder.Append(" [FEATURE PROTECTION]\n");
			stringBuilder.Append("   Self Relative = " + this.fSD.ToString());
			stringBuilder.Append("   Password Verifier = " + this.passwordVerifier.ToString());
			stringBuilder.Append("   Title = " + this.title);
			stringBuilder.Append("   Security Descriptor Size = " + this.securityDescriptor.Length.ToString());
			stringBuilder.Append(" [/FEATURE PROTECTION]\n");
			return stringBuilder.ToString();
		}

		// Token: 0x0600296B RID: 10603 RVA: 0x0007CD77 File Offset: 0x0007AF77
		public void Serialize(global::NPOI.Util.ILittleEndianOutput out1)
		{
			out1.WriteInt(this.fSD);
			out1.WriteInt(this.passwordVerifier);
			global::NPOI.Util.StringUtil.WriteUnicodeString(out1, this.title);
			out1.Write(this.securityDescriptor);
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x0600296C RID: 10604 RVA: 0x0007CDA9 File Offset: 0x0007AFA9
		public int DataSize
		{
			get
			{
				return 8 + global::NPOI.Util.StringUtil.GetEncodedSize(this.title) + this.securityDescriptor.Length;
			}
		}

		// Token: 0x0600296D RID: 10605 RVA: 0x0007CDC1 File Offset: 0x0007AFC1
		public int GetPasswordVerifier()
		{
			return this.passwordVerifier;
		}

		// Token: 0x0600296E RID: 10606 RVA: 0x0007CDC9 File Offset: 0x0007AFC9
		public void SetPasswordVerifier(int passwordVerifier)
		{
			this.passwordVerifier = passwordVerifier;
		}

		// Token: 0x0600296F RID: 10607 RVA: 0x0007CDD2 File Offset: 0x0007AFD2
		public string GetTitle()
		{
			return this.title;
		}

		// Token: 0x06002970 RID: 10608 RVA: 0x0007CDDA File Offset: 0x0007AFDA
		public void SetTitle(string title)
		{
			this.title = title;
		}

		// Token: 0x06002971 RID: 10609 RVA: 0x0007CDE3 File Offset: 0x0007AFE3
		public int GetFSD()
		{
			return this.fSD;
		}

		// Token: 0x040011EA RID: 4586
		public const long NO_SELF_RELATIVE_SECURITY_FEATURE = 0L;

		// Token: 0x040011EB RID: 4587
		public const long HAS_SELF_RELATIVE_SECURITY_FEATURE = 1L;

		// Token: 0x040011EC RID: 4588
		private int fSD;

		// Token: 0x040011ED RID: 4589
		private int passwordVerifier;

		// Token: 0x040011EE RID: 4590
		private string title;

		// Token: 0x040011EF RID: 4591
		private byte[] securityDescriptor;
	}
}
