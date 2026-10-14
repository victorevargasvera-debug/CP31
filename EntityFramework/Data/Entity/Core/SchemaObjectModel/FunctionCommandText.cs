using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x020002F4 RID: 756
	internal sealed class FunctionCommandText : global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement
	{
		// Token: 0x06002417 RID: 9239 RVA: 0x000653BA File Offset: 0x000635BA
		public FunctionCommandText(global::System.Data.Entity.Core.SchemaObjectModel.Function parentElement) : base(parentElement, null)
		{
		}

		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x06002418 RID: 9240 RVA: 0x000653C4 File Offset: 0x000635C4
		public string CommandText
		{
			get
			{
				return this._commandText;
			}
		}

		// Token: 0x06002419 RID: 9241 RVA: 0x000653CC File Offset: 0x000635CC
		protected override bool HandleText(global::System.Xml.XmlReader reader)
		{
			this._commandText = reader.Value;
			return true;
		}

		// Token: 0x0600241A RID: 9242 RVA: 0x000653DB File Offset: 0x000635DB
		internal override void Validate()
		{
			base.Validate();
			if (string.IsNullOrEmpty(this._commandText))
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.EmptyCommandText, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.EmptyCommandText);
			}
		}

		// Token: 0x04000CE1 RID: 3297
		private string _commandText;
	}
}
