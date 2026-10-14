using System;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x02000304 RID: 772
	internal class UsingElement : global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement
	{
		// Token: 0x0600248E RID: 9358 RVA: 0x000668F4 File Offset: 0x00064AF4
		internal UsingElement(global::System.Data.Entity.Core.SchemaObjectModel.Schema parentElement) : base(parentElement, null)
		{
		}

		// Token: 0x170007C3 RID: 1987
		// (get) Token: 0x0600248F RID: 9359 RVA: 0x000668FE File Offset: 0x00064AFE
		// (set) Token: 0x06002490 RID: 9360 RVA: 0x00066906 File Offset: 0x00064B06
		public virtual string Alias { get; private set; }

		// Token: 0x170007C4 RID: 1988
		// (get) Token: 0x06002491 RID: 9361 RVA: 0x0006690F File Offset: 0x00064B0F
		// (set) Token: 0x06002492 RID: 9362 RVA: 0x00066917 File Offset: 0x00064B17
		public virtual string NamespaceName { get; private set; }

		// Token: 0x170007C5 RID: 1989
		// (get) Token: 0x06002493 RID: 9363 RVA: 0x00066920 File Offset: 0x00064B20
		public override string FQName
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06002494 RID: 9364 RVA: 0x00066923 File Offset: 0x00064B23
		protected override bool ProhibitAttribute(string namespaceUri, string localName)
		{
			if (base.ProhibitAttribute(namespaceUri, localName))
			{
				return true;
			}
			if (namespaceUri == null)
			{
				localName == "Name";
				return false;
			}
			return false;
		}

		// Token: 0x06002495 RID: 9365 RVA: 0x00066943 File Offset: 0x00064B43
		protected override bool HandleAttribute(global::System.Xml.XmlReader reader)
		{
			if (base.HandleAttribute(reader))
			{
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "Namespace"))
			{
				this.HandleNamespaceAttribute(reader);
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "Alias"))
			{
				this.HandleAliasAttribute(reader);
				return true;
			}
			return false;
		}

		// Token: 0x06002496 RID: 9366 RVA: 0x00066980 File Offset: 0x00064B80
		private void HandleNamespaceAttribute(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.ReturnValue<string> returnValue = base.HandleDottedNameAttribute(reader, this.NamespaceName);
			if (returnValue.Succeeded)
			{
				this.NamespaceName = returnValue.Value;
			}
		}

		// Token: 0x06002497 RID: 9367 RVA: 0x000669AF File Offset: 0x00064BAF
		private void HandleAliasAttribute(global::System.Xml.XmlReader reader)
		{
			this.Alias = base.HandleUndottedNameAttribute(reader, this.Alias);
		}
	}
}
