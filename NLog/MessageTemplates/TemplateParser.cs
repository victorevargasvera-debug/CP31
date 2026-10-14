using System;
using System.Collections.Generic;

namespace NLog.MessageTemplates
{
	// Token: 0x02000082 RID: 130
	internal static class TemplateParser
	{
		// Token: 0x060008C9 RID: 2249 RVA: 0x00017174 File Offset: 0x00015374
		public static global::NLog.MessageTemplates.Template Parse(string template)
		{
			if (template == null)
			{
				throw new global::System.ArgumentNullException("template");
			}
			bool isPositional = true;
			global::System.Collections.Generic.List<global::NLog.MessageTemplates.Literal> list = new global::System.Collections.Generic.List<global::NLog.MessageTemplates.Literal>();
			global::System.Collections.Generic.List<global::NLog.MessageTemplates.Hole> list2 = new global::System.Collections.Generic.List<global::NLog.MessageTemplates.Hole>();
			global::NLog.MessageTemplates.TemplateEnumerator templateEnumerator = new global::NLog.MessageTemplates.TemplateEnumerator(template);
			while (templateEnumerator.MoveNext())
			{
				if (templateEnumerator.Current.Literal.Skip == 0)
				{
					list.Add(templateEnumerator.Current.Literal);
				}
				else
				{
					list.Add(templateEnumerator.Current.Literal);
					list2.Add(templateEnumerator.Current.Hole);
					if (templateEnumerator.Current.Hole.Index == -1)
					{
						isPositional = false;
					}
				}
			}
			return new global::NLog.MessageTemplates.Template(template, isPositional, list, list2);
		}
	}
}
