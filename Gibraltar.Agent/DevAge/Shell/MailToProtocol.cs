using System;
using System.Collections;

namespace DevAge.Shell
{
	// Token: 0x020002C7 RID: 711
	internal class MailToProtocol
	{
		// Token: 0x060022CD RID: 8909 RVA: 0x0007A558 File Offset: 0x00078758
		public static string FormatMailToCommand(string[] p_To, string[] p_Cc, string[] p_Bcc, string p_Subject, string p_Body)
		{
			string text = global::DevAge.Shell.MailToProtocol.FormatEMailAddress(p_To);
			string text2 = global::DevAge.Shell.MailToProtocol.FormatEMailAddress(p_Cc);
			string text3 = global::DevAge.Shell.MailToProtocol.FormatEMailAddress(p_Bcc);
			string text4 = "mailto:";
			if (text != null)
			{
				text4 += text;
			}
			global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
			if (text2 != null)
			{
				arrayList.Add("CC=" + text2);
			}
			if (text3 != null)
			{
				arrayList.Add("BCC=" + text3);
			}
			if (p_Subject != null)
			{
				arrayList.Add("subject=" + p_Subject);
			}
			if (p_Body != null)
			{
				arrayList.Add("body=" + p_Body);
			}
			if (arrayList.Count > 0)
			{
				string[] array = new string[arrayList.Count];
				arrayList.CopyTo(array, 0);
				text4 += "?";
				text4 += string.Join("&", array);
			}
			return text4;
		}

		// Token: 0x060022CE RID: 8910 RVA: 0x0007A644 File Offset: 0x00078844
		public static void Exec(string[] p_To)
		{
			global::DevAge.Shell.MailToProtocol.Exec(p_To, null);
		}

		// Token: 0x060022CF RID: 8911 RVA: 0x0007A650 File Offset: 0x00078850
		public static void Exec(string[] p_To, string p_Subject)
		{
			global::DevAge.Shell.MailToProtocol.Exec(p_To, null, null, p_Subject, null);
		}

		// Token: 0x060022D0 RID: 8912 RVA: 0x0007A65C File Offset: 0x0007885C
		public static void Exec(string[] p_To, string[] p_Cc, string[] p_Bcc, string p_Subject, string p_Body)
		{
			try
			{
				global::DevAge.Shell.Utilities.ExecCommand(global::DevAge.Shell.MailToProtocol.FormatMailToCommand(p_To, p_Cc, p_Bcc, p_Subject, p_Body));
			}
			catch (global::System.Exception innerException)
			{
				throw new global::System.ApplicationException("Failed to execute mailto protocol.", innerException);
			}
		}

		// Token: 0x060022D1 RID: 8913 RVA: 0x0007A69C File Offset: 0x0007889C
		public static string FormatEMailAddress(string[] p_EMails)
		{
			if (p_EMails == null || p_EMails.Length <= 0)
			{
				return null;
			}
			return string.Join(";", p_EMails);
		}
	}
}
