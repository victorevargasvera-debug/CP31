using System;

namespace NLog.MessageTemplates
{
	// Token: 0x02000083 RID: 131
	public class TemplateParserException : global::System.Exception
	{
		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x0001721A File Offset: 0x0001541A
		public int Index { get; }

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060008CB RID: 2251 RVA: 0x00017222 File Offset: 0x00015422
		public string Template { get; }

		// Token: 0x060008CC RID: 2252 RVA: 0x0001722A File Offset: 0x0001542A
		public TemplateParserException(string message, int index, string template) : base(message)
		{
			this.Index = index;
			this.Template = template;
		}
	}
}
