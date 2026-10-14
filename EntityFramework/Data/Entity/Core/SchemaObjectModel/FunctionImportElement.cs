using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Resources;
using System.Xml;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x020002F5 RID: 757
	internal class FunctionImportElement : global::System.Data.Entity.Core.SchemaObjectModel.Function
	{
		// Token: 0x0600241B RID: 9243 RVA: 0x00065401 File Offset: 0x00063601
		internal FunctionImportElement(global::System.Data.Entity.Core.SchemaObjectModel.EntityContainer container) : base(container.Schema)
		{
			if (base.Schema.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.EntityDataModel)
			{
				base.OtherContent.Add(base.Schema.SchemaSource);
			}
			this._container = container;
			this._isComposable = false;
		}

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x0600241C RID: 9244 RVA: 0x00065440 File Offset: 0x00063640
		public override bool IsFunctionImport
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x0600241D RID: 9245 RVA: 0x00065443 File Offset: 0x00063643
		public override string FQName
		{
			get
			{
				return this._container.Name + "." + this.Name;
			}
		}

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x0600241E RID: 9246 RVA: 0x00065460 File Offset: 0x00063660
		public override string Identity
		{
			get
			{
				return base.Name;
			}
		}

		// Token: 0x1700079D RID: 1949
		// (get) Token: 0x0600241F RID: 9247 RVA: 0x00065468 File Offset: 0x00063668
		public global::System.Data.Entity.Core.SchemaObjectModel.EntityContainer Container
		{
			get
			{
				return this._container;
			}
		}

		// Token: 0x1700079E RID: 1950
		// (get) Token: 0x06002420 RID: 9248 RVA: 0x00065470 File Offset: 0x00063670
		public global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet EntitySet
		{
			get
			{
				return this._entitySet;
			}
		}

		// Token: 0x06002421 RID: 9249 RVA: 0x00065478 File Offset: 0x00063678
		protected override bool HandleAttribute(global::System.Xml.XmlReader reader)
		{
			if (base.HandleAttribute(reader))
			{
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "EntitySet"))
			{
				string unresolvedEntitySet;
				if (global::System.Data.Entity.Core.SchemaObjectModel.Utils.GetString(base.Schema, reader, out unresolvedEntitySet))
				{
					this._unresolvedEntitySet = unresolvedEntitySet;
				}
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "EntitySetPath"))
			{
				string text;
				if (global::System.Data.Entity.Core.SchemaObjectModel.Utils.GetString(base.Schema, reader, out text))
				{
					this._entitySetPathDefined = true;
				}
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "IsBindable"))
			{
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "IsSideEffecting"))
			{
				bool value = true;
				if (base.HandleBoolAttribute(reader, ref value))
				{
					this._isSideEffecting = new bool?(value);
				}
				return true;
			}
			return false;
		}

		// Token: 0x06002422 RID: 9250 RVA: 0x00065514 File Offset: 0x00063714
		internal override void ResolveTopLevelNames()
		{
			base.ResolveTopLevelNames();
			this.ResolveEntitySet(this, this._unresolvedEntitySet, ref this._entitySet);
		}

		// Token: 0x06002423 RID: 9251 RVA: 0x0006552F File Offset: 0x0006372F
		internal void ResolveEntitySet(global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement owner, string unresolvedEntitySet, ref global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet entitySet)
		{
			if (entitySet == null && unresolvedEntitySet != null)
			{
				entitySet = this._container.FindEntitySet(unresolvedEntitySet);
				if (entitySet == null)
				{
					owner.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.FunctionImportUnknownEntitySet, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.FunctionImportUnknownEntitySet(unresolvedEntitySet, this.FQName));
				}
			}
		}

		// Token: 0x06002424 RID: 9252 RVA: 0x00065564 File Offset: 0x00063764
		internal override void Validate()
		{
			base.Validate();
			this.ValidateFunctionImportReturnType(this, this._type, base.CollectionKind, this._entitySet, this._entitySetPathDefined);
			if (this._returnTypeList != null)
			{
				foreach (global::System.Data.Entity.Core.SchemaObjectModel.ReturnType returnType in this._returnTypeList)
				{
					this.ValidateFunctionImportReturnType(returnType, returnType.Type, returnType.CollectionKind, returnType.EntitySet, returnType.EntitySetPathDefined);
				}
			}
			if (this._isComposable && this._isSideEffecting != null && this._isSideEffecting.Value)
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.FunctionImportComposableAndSideEffectingNotAllowed, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.FunctionImportComposableAndSideEffectingNotAllowed(this.FQName));
			}
			if (this._parameters != null)
			{
				foreach (global::System.Data.Entity.Core.SchemaObjectModel.Parameter parameter in this._parameters)
				{
					if (parameter.IsRefType || parameter.CollectionKind != global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.None)
					{
						base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.FunctionImportCollectionAndRefParametersNotAllowed, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.FunctionImportCollectionAndRefParametersNotAllowed(this.FQName));
					}
					if (!parameter.TypeUsageBuilder.Nullable)
					{
						base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.FunctionImportNonNullableParametersNotAllowed, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.FunctionImportNonNullableParametersNotAllowed(this.FQName));
					}
				}
			}
		}

		// Token: 0x06002425 RID: 9253 RVA: 0x000656C0 File Offset: 0x000638C0
		private void ValidateFunctionImportReturnType(global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement owner, global::System.Data.Entity.Core.SchemaObjectModel.SchemaType returnType, global::System.Data.Entity.Core.Metadata.Edm.CollectionKind returnTypeCollectionKind, global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet entitySet, bool entitySetPathDefined)
		{
			if (returnType != null && !this.ReturnTypeMeetsFunctionImportBasicRequirements(returnType, returnTypeCollectionKind))
			{
				owner.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.FunctionImportUnsupportedReturnType, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, owner, this.GetReturnTypeErrorMessage(this.Name));
			}
			this.ValidateFunctionImportReturnType(owner, returnType, entitySet, entitySetPathDefined);
		}

		// Token: 0x06002426 RID: 9254 RVA: 0x000656F4 File Offset: 0x000638F4
		private bool ReturnTypeMeetsFunctionImportBasicRequirements(global::System.Data.Entity.Core.SchemaObjectModel.SchemaType type, global::System.Data.Entity.Core.Metadata.Edm.CollectionKind returnTypeCollectionKind)
		{
			if (type is global::System.Data.Entity.Core.SchemaObjectModel.ScalarType && returnTypeCollectionKind == global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.Bag)
			{
				return true;
			}
			if (type is global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType && returnTypeCollectionKind == global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.Bag)
			{
				return true;
			}
			if (base.Schema.SchemaVersion == 1.1)
			{
				if (type is global::System.Data.Entity.Core.SchemaObjectModel.ScalarType && returnTypeCollectionKind == global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.None)
				{
					return true;
				}
				if (type is global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType && returnTypeCollectionKind == global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.None)
				{
					return true;
				}
				if (type is global::System.Data.Entity.Core.SchemaObjectModel.SchemaComplexType && returnTypeCollectionKind == global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.None)
				{
					return true;
				}
				if (type is global::System.Data.Entity.Core.SchemaObjectModel.SchemaComplexType && returnTypeCollectionKind == global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.Bag)
				{
					return true;
				}
			}
			return (base.Schema.SchemaVersion >= 2.0 && type is global::System.Data.Entity.Core.SchemaObjectModel.SchemaComplexType && returnTypeCollectionKind == global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.Bag) || (base.Schema.SchemaVersion >= 3.0 && type is global::System.Data.Entity.Core.SchemaObjectModel.SchemaEnumType && returnTypeCollectionKind == global::System.Data.Entity.Core.Metadata.Edm.CollectionKind.Bag);
		}

		// Token: 0x06002427 RID: 9255 RVA: 0x000657B4 File Offset: 0x000639B4
		private void ValidateFunctionImportReturnType(global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement owner, global::System.Data.Entity.Core.SchemaObjectModel.SchemaType returnType, global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet entitySet, bool entitySetPathDefined)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType schemaEntityType = returnType as global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType;
			if (entitySet != null && entitySetPathDefined)
			{
				owner.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.FunctionImportEntitySetAndEntitySetPathDeclared, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.FunctionImportEntitySetAndEntitySetPathDeclared(this.FQName));
			}
			if (schemaEntityType != null)
			{
				if (entitySet == null)
				{
					owner.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.FunctionImportReturnsEntitiesButDoesNotSpecifyEntitySet, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.FunctionImportReturnEntitiesButDoesNotSpecifyEntitySet(this.FQName));
					return;
				}
				if (entitySet.EntityType != null && !schemaEntityType.IsOfType(entitySet.EntityType))
				{
					owner.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.FunctionImportEntityTypeDoesNotMatchEntitySet, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.FunctionImportEntityTypeDoesNotMatchEntitySet(this.FQName, entitySet.EntityType.FQName, entitySet.Name));
					return;
				}
			}
			else
			{
				global::System.Data.Entity.Core.SchemaObjectModel.SchemaComplexType schemaComplexType = returnType as global::System.Data.Entity.Core.SchemaObjectModel.SchemaComplexType;
				if (schemaComplexType != null)
				{
					if (entitySet != null || entitySetPathDefined)
					{
						owner.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.ComplexTypeAsReturnTypeAndDefinedEntitySet, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, owner.LineNumber, owner.LinePosition, global::System.Data.Entity.Resources.Strings.ComplexTypeAsReturnTypeAndDefinedEntitySet(this.FQName, schemaComplexType.Name));
						return;
					}
				}
				else if (entitySet != null || entitySetPathDefined)
				{
					owner.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.FunctionImportSpecifiesEntitySetButDoesNotReturnEntityType, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.FunctionImportSpecifiesEntitySetButNotEntityType(this.FQName));
				}
			}
		}

		// Token: 0x06002428 RID: 9256 RVA: 0x000658A8 File Offset: 0x00063AA8
		private string GetReturnTypeErrorMessage(string functionName)
		{
			string result;
			if (base.Schema.SchemaVersion == 1.0)
			{
				result = global::System.Data.Entity.Resources.Strings.FunctionImportWithUnsupportedReturnTypeV1(functionName);
			}
			else if (base.Schema.SchemaVersion == 1.1)
			{
				result = global::System.Data.Entity.Resources.Strings.FunctionImportWithUnsupportedReturnTypeV1_1(functionName);
			}
			else
			{
				result = global::System.Data.Entity.Resources.Strings.FunctionImportWithUnsupportedReturnTypeV2(functionName);
			}
			return result;
		}

		// Token: 0x06002429 RID: 9257 RVA: 0x000658FC File Offset: 0x00063AFC
		internal override global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement Clone(global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement parentElement)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.FunctionImportElement functionImportElement = new global::System.Data.Entity.Core.SchemaObjectModel.FunctionImportElement((global::System.Data.Entity.Core.SchemaObjectModel.EntityContainer)parentElement);
			base.CloneSetFunctionFields(functionImportElement);
			functionImportElement._container = this._container;
			functionImportElement._entitySet = this._entitySet;
			functionImportElement._unresolvedEntitySet = this._unresolvedEntitySet;
			functionImportElement._entitySetPathDefined = this._entitySetPathDefined;
			return functionImportElement;
		}

		// Token: 0x04000CE2 RID: 3298
		private string _unresolvedEntitySet;

		// Token: 0x04000CE3 RID: 3299
		private bool _entitySetPathDefined;

		// Token: 0x04000CE4 RID: 3300
		private global::System.Data.Entity.Core.SchemaObjectModel.EntityContainer _container;

		// Token: 0x04000CE5 RID: 3301
		private global::System.Data.Entity.Core.SchemaObjectModel.EntityContainerEntitySet _entitySet;

		// Token: 0x04000CE6 RID: 3302
		private bool? _isSideEffecting;
	}
}
