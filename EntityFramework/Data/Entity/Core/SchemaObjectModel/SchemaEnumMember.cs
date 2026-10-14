using System;
using System.Globalization;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x02000316 RID: 790
	internal class SchemaEnumMember : global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement
	{
		// Token: 0x060025B4 RID: 9652 RVA: 0x0006A994 File Offset: 0x00068B94
		public SchemaEnumMember(global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement parentElement) : base(parentElement, null)
		{
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x060025B5 RID: 9653 RVA: 0x0006A99E File Offset: 0x00068B9E
		// (set) Token: 0x060025B6 RID: 9654 RVA: 0x0006A9A6 File Offset: 0x00068BA6
		public long? Value
		{
			get
			{
				return this._value;
			}
			set
			{
				this._value = value;
			}
		}

		// Token: 0x060025B7 RID: 9655 RVA: 0x0006A9B0 File Offset: 0x00068BB0
		protected override bool HandleAttribute(global::System.Xml.XmlReader reader)
		{
			bool flag = base.HandleAttribute(reader);
			if (!flag && (flag = global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "Value")))
			{
				this.HandleValueAttribute(reader);
			}
			return flag;
		}

		// Token: 0x060025B8 RID: 9656 RVA: 0x0006A9E0 File Offset: 0x00068BE0
		private void HandleValueAttribute(global::System.Xml.XmlReader reader)
		{
			long value;
			if (long.TryParse(reader.Value, global::System.Globalization.NumberStyles.AllowLeadingSign, global::System.Globalization.CultureInfo.InvariantCulture, out value))
			{
				this._value = new long?(value);
			}
		}

		// Token: 0x04000D41 RID: 3393
		private long? _value;
	}
}
