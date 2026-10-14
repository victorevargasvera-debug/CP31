using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Linq;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x02000317 RID: 791
	internal class SchemaEnumType : global::System.Data.Entity.Core.SchemaObjectModel.SchemaType
	{
		// Token: 0x060025B9 RID: 9657 RVA: 0x0006AA0E File Offset: 0x00068C0E
		public SchemaEnumType(global::System.Data.Entity.Core.SchemaObjectModel.Schema parentElement) : base(parentElement)
		{
			if (base.Schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.EntityDataModel)
			{
				base.OtherContent.Add(base.Schema.SchemaSource);
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x060025BA RID: 9658 RVA: 0x0006AA45 File Offset: 0x00068C45
		public bool IsFlags
		{
			get
			{
				return this._isFlags;
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x060025BB RID: 9659 RVA: 0x0006AA4D File Offset: 0x00068C4D
		public global::System.Data.Entity.Core.SchemaObjectModel.SchemaType UnderlyingType
		{
			get
			{
				return this._underlyingType;
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x060025BC RID: 9660 RVA: 0x0006AA55 File Offset: 0x00068C55
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.SchemaObjectModel.SchemaEnumMember> EnumMembers
		{
			get
			{
				return this._enumMembers;
			}
		}

		// Token: 0x060025BD RID: 9661 RVA: 0x0006AA60 File Offset: 0x00068C60
		protected override bool HandleElement(global::System.Xml.XmlReader reader)
		{
			if (!base.HandleElement(reader))
			{
				if (base.CanHandleElement(reader, "Member"))
				{
					this.HandleMemberElement(reader);
				}
				else
				{
					if (base.CanHandleElement(reader, "ValueAnnotation"))
					{
						this.SkipElement(reader);
						return true;
					}
					if (base.CanHandleElement(reader, "TypeAnnotation"))
					{
						this.SkipElement(reader);
						return true;
					}
					return false;
				}
			}
			return true;
		}

		// Token: 0x060025BE RID: 9662 RVA: 0x0006AAC0 File Offset: 0x00068CC0
		protected override bool HandleAttribute(global::System.Xml.XmlReader reader)
		{
			if (!base.HandleAttribute(reader))
			{
				if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "IsFlags"))
				{
					base.HandleBoolAttribute(reader, ref this._isFlags);
				}
				else
				{
					if (!global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "UnderlyingType"))
					{
						return false;
					}
					global::System.Data.Entity.Core.SchemaObjectModel.Utils.GetDottedName(base.Schema, reader, out this._unresolvedUnderlyingTypeName);
				}
			}
			return true;
		}

		// Token: 0x060025BF RID: 9663 RVA: 0x0006AB18 File Offset: 0x00068D18
		private void HandleMemberElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.SchemaEnumMember schemaEnumMember = new global::System.Data.Entity.Core.SchemaObjectModel.SchemaEnumMember(this);
			schemaEnumMember.Parse(reader);
			if (schemaEnumMember.Value == null)
			{
				if (this._enumMembers.Count == 0)
				{
					schemaEnumMember.Value = new long?(0L);
				}
				else
				{
					long value = this._enumMembers[this._enumMembers.Count - 1].Value.Value;
					if (value < 9223372036854775807L)
					{
						schemaEnumMember.Value = new long?(value + 1L);
					}
					else
					{
						base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.CalculatedEnumValueOutOfRange, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.CalculatedEnumValueOutOfRange);
						schemaEnumMember.Value = new long?(value);
					}
				}
			}
			this._enumMembers.Add(schemaEnumMember);
		}

		// Token: 0x060025C0 RID: 9664 RVA: 0x0006ABCC File Offset: 0x00068DCC
		internal override void ResolveTopLevelNames()
		{
			if (this._unresolvedUnderlyingTypeName == null)
			{
				this._underlyingType = base.Schema.SchemaManager.SchemaTypes.Single((global::System.Data.Entity.Core.SchemaObjectModel.SchemaType t) => t is global::System.Data.Entity.Core.SchemaObjectModel.ScalarType && ((global::System.Data.Entity.Core.SchemaObjectModel.ScalarType)t).TypeKind == global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.Int32);
				return;
			}
			base.Schema.ResolveTypeName(this, this._unresolvedUnderlyingTypeName, out this._underlyingType);
		}

		// Token: 0x060025C1 RID: 9665 RVA: 0x0006AC38 File Offset: 0x00068E38
		internal override void Validate()
		{
			base.Validate();
			global::System.Data.Entity.Core.SchemaObjectModel.ScalarType enumUnderlyingType = this.UnderlyingType as global::System.Data.Entity.Core.SchemaObjectModel.ScalarType;
			if (enumUnderlyingType == null || !global::System.Data.Entity.Core.Metadata.Edm.Helper.IsSupportedEnumUnderlyingType(enumUnderlyingType.TypeKind))
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidEnumUnderlyingType, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidEnumUnderlyingType);
			}
			else
			{
				foreach (global::System.Data.Entity.Core.SchemaObjectModel.SchemaEnumMember schemaEnumMember in from m in this._enumMembers
				where !global::System.Data.Entity.Core.Metadata.Edm.Helper.IsEnumMemberValueInRange(enumUnderlyingType.TypeKind, m.Value.Value)
				select m)
				{
					schemaEnumMember.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.EnumMemberValueOutOfItsUnderylingTypeRange, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.EnumMemberValueOutOfItsUnderylingTypeRange(schemaEnumMember.Value, schemaEnumMember.Name, this.UnderlyingType.Name));
				}
			}
			if ((from o in this._enumMembers
			group o by o.Name into g
			where g.Count<global::System.Data.Entity.Core.SchemaObjectModel.SchemaEnumMember>() > 1
			select g).Any<global::System.Linq.IGrouping<string, global::System.Data.Entity.Core.SchemaObjectModel.SchemaEnumMember>>())
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.DuplicateEnumMember, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.DuplicateEnumMember);
			}
		}

		// Token: 0x04000D42 RID: 3394
		private bool _isFlags;

		// Token: 0x04000D43 RID: 3395
		private string _unresolvedUnderlyingTypeName;

		// Token: 0x04000D44 RID: 3396
		private global::System.Data.Entity.Core.SchemaObjectModel.SchemaType _underlyingType;

		// Token: 0x04000D45 RID: 3397
		private readonly global::System.Collections.Generic.IList<global::System.Data.Entity.Core.SchemaObjectModel.SchemaEnumMember> _enumMembers = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.SchemaEnumMember>();
	}
}
