using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace System.Data.Entity.Core.Common.CommandTrees.Internal
{
	// Token: 0x020006F6 RID: 1782
	internal class XmlExpressionDumper : global::System.Data.Entity.Core.Common.CommandTrees.Internal.ExpressionDumper
	{
		// Token: 0x1700100A RID: 4106
		// (get) Token: 0x060052F4 RID: 21236 RVA: 0x00129937 File Offset: 0x00127B37
		internal static global::System.Text.Encoding DefaultEncoding
		{
			get
			{
				return global::System.Text.Encoding.UTF8;
			}
		}

		// Token: 0x060052F5 RID: 21237 RVA: 0x0012993E File Offset: 0x00127B3E
		internal XmlExpressionDumper(global::System.IO.Stream stream) : this(stream, global::System.Data.Entity.Core.Common.CommandTrees.Internal.XmlExpressionDumper.DefaultEncoding)
		{
		}

		// Token: 0x060052F6 RID: 21238 RVA: 0x0012994C File Offset: 0x00127B4C
		internal XmlExpressionDumper(global::System.IO.Stream stream, global::System.Text.Encoding encoding)
		{
			this._writer = global::System.Xml.XmlWriter.Create(stream, new global::System.Xml.XmlWriterSettings
			{
				CheckCharacters = false,
				Indent = true,
				Encoding = encoding
			});
			this._writer.WriteStartDocument(true);
		}

		// Token: 0x060052F7 RID: 21239 RVA: 0x00129993 File Offset: 0x00127B93
		internal void Close()
		{
			this._writer.WriteEndDocument();
			this._writer.Flush();
			this._writer.Close();
		}

		// Token: 0x060052F8 RID: 21240 RVA: 0x001299B8 File Offset: 0x00127BB8
		internal override void Begin(string name, global::System.Collections.Generic.Dictionary<string, object> attrs)
		{
			this._writer.WriteStartElement(name);
			if (attrs != null)
			{
				foreach (global::System.Collections.Generic.KeyValuePair<string, object> keyValuePair in attrs)
				{
					this._writer.WriteAttributeString(keyValuePair.Key, (keyValuePair.Value == null) ? "" : keyValuePair.Value.ToString());
				}
			}
		}

		// Token: 0x060052F9 RID: 21241 RVA: 0x00129A3C File Offset: 0x00127C3C
		internal override void End(string name)
		{
			this._writer.WriteEndElement();
		}

		// Token: 0x04001DF8 RID: 7672
		private readonly global::System.Xml.XmlWriter _writer;
	}
}
