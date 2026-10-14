using System;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x02000320 RID: 800
	internal sealed class TextElement : global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement
	{
		// Token: 0x06002611 RID: 9745 RVA: 0x0006BE75 File Offset: 0x0006A075
		public TextElement(global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement parentElement) : base(parentElement, null)
		{
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06002612 RID: 9746 RVA: 0x0006BE7F File Offset: 0x0006A07F
		// (set) Token: 0x06002613 RID: 9747 RVA: 0x0006BE87 File Offset: 0x0006A087
		public string Value { get; private set; }

		// Token: 0x06002614 RID: 9748 RVA: 0x0006BE90 File Offset: 0x0006A090
		protected override bool HandleText(global::System.Xml.XmlReader reader)
		{
			this.TextElementTextHandler(reader);
			return true;
		}

		// Token: 0x06002615 RID: 9749 RVA: 0x0006BE9C File Offset: 0x0006A09C
		private void TextElementTextHandler(global::System.Xml.XmlReader reader)
		{
			string value = reader.Value;
			if (string.IsNullOrEmpty(value))
			{
				return;
			}
			if (string.IsNullOrEmpty(this.Value))
			{
				this.Value = value;
				return;
			}
			this.Value += value;
		}
	}
}
