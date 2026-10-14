using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x020002F0 RID: 752
	internal abstract class FacetDescriptionElement : global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement
	{
		// Token: 0x060023C7 RID: 9159 RVA: 0x00064588 File Offset: 0x00062788
		public FacetDescriptionElement(global::System.Data.Entity.Core.SchemaObjectModel.TypeElement type, string name) : base(type, name, null)
		{
		}

		// Token: 0x060023C8 RID: 9160 RVA: 0x00064593 File Offset: 0x00062793
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

		// Token: 0x060023C9 RID: 9161 RVA: 0x000645B4 File Offset: 0x000627B4
		protected override bool HandleAttribute(global::System.Xml.XmlReader reader)
		{
			if (base.HandleAttribute(reader))
			{
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "Minimum"))
			{
				this.HandleMinimumAttribute(reader);
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "Maximum"))
			{
				this.HandleMaximumAttribute(reader);
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "DefaultValue"))
			{
				this.HandleDefaultAttribute(reader);
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "Constant"))
			{
				this.HandleConstantAttribute(reader);
				return true;
			}
			return false;
		}

		// Token: 0x060023CA RID: 9162 RVA: 0x00064628 File Offset: 0x00062828
		protected void HandleMinimumAttribute(global::System.Xml.XmlReader reader)
		{
			int value = -1;
			if (base.HandleIntAttribute(reader, ref value))
			{
				this._minValue = new int?(value);
			}
		}

		// Token: 0x060023CB RID: 9163 RVA: 0x00064650 File Offset: 0x00062850
		protected void HandleMaximumAttribute(global::System.Xml.XmlReader reader)
		{
			int value = -1;
			if (base.HandleIntAttribute(reader, ref value))
			{
				this._maxValue = new int?(value);
			}
		}

		// Token: 0x060023CC RID: 9164
		protected abstract void HandleDefaultAttribute(global::System.Xml.XmlReader reader);

		// Token: 0x060023CD RID: 9165 RVA: 0x00064678 File Offset: 0x00062878
		protected void HandleConstantAttribute(global::System.Xml.XmlReader reader)
		{
			bool isConstant = false;
			if (base.HandleBoolAttribute(reader, ref isConstant))
			{
				this._isConstant = isConstant;
			}
		}

		// Token: 0x1700077C RID: 1916
		// (get) Token: 0x060023CE RID: 9166
		public abstract global::System.Data.Entity.Core.Metadata.Edm.EdmType FacetType { get; }

		// Token: 0x1700077D RID: 1917
		// (get) Token: 0x060023CF RID: 9167 RVA: 0x00064699 File Offset: 0x00062899
		public int? MinValue
		{
			get
			{
				return this._minValue;
			}
		}

		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x060023D0 RID: 9168 RVA: 0x000646A1 File Offset: 0x000628A1
		public int? MaxValue
		{
			get
			{
				return this._maxValue;
			}
		}

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x060023D1 RID: 9169 RVA: 0x000646A9 File Offset: 0x000628A9
		// (set) Token: 0x060023D2 RID: 9170 RVA: 0x000646B1 File Offset: 0x000628B1
		public object DefaultValue { get; set; }

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x060023D3 RID: 9171 RVA: 0x000646BA File Offset: 0x000628BA
		public global::System.Data.Entity.Core.Metadata.Edm.FacetDescription FacetDescription
		{
			get
			{
				return this._facetDescription;
			}
		}

		// Token: 0x060023D4 RID: 9172 RVA: 0x000646C2 File Offset: 0x000628C2
		internal void CreateAndValidateFacetDescription(string declaringTypeName)
		{
			this._facetDescription = new global::System.Data.Entity.Core.Metadata.Edm.FacetDescription(this.Name, this.FacetType, this.MinValue, this.MaxValue, this.DefaultValue, this._isConstant, declaringTypeName);
		}

		// Token: 0x04000CC8 RID: 3272
		private int? _minValue;

		// Token: 0x04000CC9 RID: 3273
		private int? _maxValue;

		// Token: 0x04000CCA RID: 3274
		private bool _isConstant;

		// Token: 0x04000CCB RID: 3275
		private global::System.Data.Entity.Core.Metadata.Edm.FacetDescription _facetDescription;
	}
}
