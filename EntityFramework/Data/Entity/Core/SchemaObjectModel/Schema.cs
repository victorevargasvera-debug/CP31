using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.Utils;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Metadata.Edm.Provider;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Diagnostics;
using System.IO;
using System.Security;
using System.Xml;
using System.Xml.Schema;

namespace System.Data.Entity.Core.SchemaObjectModel
{
	// Token: 0x02000310 RID: 784
	[global::System.Diagnostics.DebuggerDisplay("Namespace={Namespace}, PublicKeyToken={PublicKeyToken}, Version={Version}")]
	internal class Schema : global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement
	{
		// Token: 0x0600252D RID: 9517 RVA: 0x00068C29 File Offset: 0x00066E29
		public Schema(global::System.Data.Entity.Core.SchemaObjectModel.SchemaManager schemaManager) : base(null, null)
		{
			this._schemaManager = schemaManager;
			this._errors = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError>();
		}

		// Token: 0x0600252E RID: 9518 RVA: 0x00068C50 File Offset: 0x00066E50
		internal global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> Resolve()
		{
			this.ResolveTopLevelNames();
			if (this._errors.Count != 0)
			{
				return this.ResetErrors();
			}
			this.ResolveSecondLevelNames();
			return this.ResetErrors();
		}

		// Token: 0x0600252F RID: 9519 RVA: 0x00068C78 File Offset: 0x00066E78
		internal global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> ValidateSchema()
		{
			this.Validate();
			return this.ResetErrors();
		}

		// Token: 0x06002530 RID: 9520 RVA: 0x00068C86 File Offset: 0x00066E86
		internal void AddError(global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError error)
		{
			this._errors.Add(error);
		}

		// Token: 0x06002531 RID: 9521 RVA: 0x00068C94 File Offset: 0x00066E94
		internal global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> Parse(global::System.Xml.XmlReader sourceReader, string sourceLocation)
		{
			try
			{
				global::System.Xml.XmlReaderSettings settings = this.CreateXmlReaderSettings();
				global::System.Xml.XmlReader sourceReader2 = global::System.Xml.XmlReader.Create(sourceReader, settings);
				return this.InternalParse(sourceReader2, sourceLocation);
			}
			catch (global::System.IO.IOException message)
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.IOException, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, sourceReader, message);
			}
			return this.ResetErrors();
		}

		// Token: 0x06002532 RID: 9522 RVA: 0x00068CE0 File Offset: 0x00066EE0
		private global::System.Collections.Generic.IList<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> InternalParse(global::System.Xml.XmlReader sourceReader, string sourceLocation)
		{
			base.Schema = this;
			this.Location = sourceLocation;
			try
			{
				if (sourceReader.NodeType != global::System.Xml.XmlNodeType.Element)
				{
					while (sourceReader.Read() && sourceReader.NodeType != global::System.Xml.XmlNodeType.Element)
					{
					}
				}
				base.GetPositionInfo(sourceReader);
				global::System.Collections.Generic.List<string> primarySchemaNamespaces = global::System.Data.Entity.Core.SchemaObjectModel.Schema.SomSchemaSetHelper.GetPrimarySchemaNamespaces(this.DataModel);
				if (sourceReader.EOF)
				{
					if (sourceLocation != null)
					{
						base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.EmptyFile, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.EmptyFile(sourceLocation));
					}
					else
					{
						base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.EmptyFile, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.EmptySchemaTextReader);
					}
				}
				else if (!primarySchemaNamespaces.Contains(sourceReader.NamespaceURI))
				{
					global::System.Func<object, object, object, string> func = new global::System.Func<object, object, object, string>(global::System.Data.Entity.Resources.Strings.UnexpectedRootElement);
					if (string.IsNullOrEmpty(sourceReader.NamespaceURI))
					{
						func = new global::System.Func<object, object, object, string>(global::System.Data.Entity.Resources.Strings.UnexpectedRootElementNoNamespace);
					}
					string commaDelimitedString = global::System.Data.Entity.Core.Metadata.Edm.Helper.GetCommaDelimitedString(primarySchemaNamespaces);
					base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.UnexpectedXmlElement, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, func(sourceReader.NamespaceURI, sourceReader.LocalName, commaDelimitedString));
				}
				else
				{
					this.SchemaXmlNamespace = sourceReader.NamespaceURI;
					if (this.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.EntityDataModel)
					{
						if (this.SchemaXmlNamespace == "http://schemas.microsoft.com/ado/2006/04/edm")
						{
							this.SchemaVersion = 1.0;
						}
						else if (this.SchemaXmlNamespace == "http://schemas.microsoft.com/ado/2007/05/edm")
						{
							this.SchemaVersion = 1.1;
						}
						else if (this.SchemaXmlNamespace == "http://schemas.microsoft.com/ado/2008/09/edm")
						{
							this.SchemaVersion = 2.0;
						}
						else
						{
							this.SchemaVersion = 3.0;
						}
					}
					else if (this.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.ProviderDataModel)
					{
						if (this.SchemaXmlNamespace == "http://schemas.microsoft.com/ado/2006/04/edm/ssdl")
						{
							this.SchemaVersion = 1.0;
						}
						else if (this.SchemaXmlNamespace == "http://schemas.microsoft.com/ado/2009/02/edm/ssdl")
						{
							this.SchemaVersion = 2.0;
						}
						else
						{
							this.SchemaVersion = 3.0;
						}
					}
					string localName = sourceReader.LocalName;
					if (localName != null && (localName == "Schema" || localName == "ProviderManifest"))
					{
						this.HandleTopLevelSchemaElement(sourceReader);
						sourceReader.Read();
					}
					else
					{
						base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.UnexpectedXmlElement, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.UnexpectedRootElement(sourceReader.NamespaceURI, sourceReader.LocalName, this.SchemaXmlNamespace));
					}
				}
			}
			catch (global::System.InvalidOperationException ex)
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InternalError, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, ex.Message);
			}
			catch (global::System.UnauthorizedAccessException message)
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.UnauthorizedAccessException, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, sourceReader, message);
			}
			catch (global::System.IO.IOException message2)
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.IOException, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, sourceReader, message2);
			}
			catch (global::System.Security.SecurityException message3)
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.SecurityError, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, sourceReader, message3);
			}
			catch (global::System.Xml.XmlException message4)
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.XmlError, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, sourceReader, message4);
			}
			return this.ResetErrors();
		}

		// Token: 0x06002533 RID: 9523 RVA: 0x00068FD8 File Offset: 0x000671D8
		internal static global::System.Xml.XmlReaderSettings CreateEdmStandardXmlReaderSettings()
		{
			global::System.Xml.XmlReaderSettings xmlReaderSettings = new global::System.Xml.XmlReaderSettings();
			xmlReaderSettings.CheckCharacters = true;
			xmlReaderSettings.CloseInput = false;
			xmlReaderSettings.IgnoreWhitespace = true;
			xmlReaderSettings.ConformanceLevel = global::System.Xml.ConformanceLevel.Auto;
			xmlReaderSettings.IgnoreComments = true;
			xmlReaderSettings.IgnoreProcessingInstructions = true;
			xmlReaderSettings.DtdProcessing = global::System.Xml.DtdProcessing.Prohibit;
			xmlReaderSettings.ValidationFlags &= ~global::System.Xml.Schema.XmlSchemaValidationFlags.ProcessIdentityConstraints;
			xmlReaderSettings.ValidationFlags &= ~global::System.Xml.Schema.XmlSchemaValidationFlags.ProcessSchemaLocation;
			xmlReaderSettings.ValidationFlags &= ~global::System.Xml.Schema.XmlSchemaValidationFlags.ProcessInlineSchema;
			return xmlReaderSettings;
		}

		// Token: 0x06002534 RID: 9524 RVA: 0x00069048 File Offset: 0x00067248
		private global::System.Xml.XmlReaderSettings CreateXmlReaderSettings()
		{
			global::System.Xml.XmlReaderSettings xmlReaderSettings = global::System.Data.Entity.Core.SchemaObjectModel.Schema.CreateEdmStandardXmlReaderSettings();
			xmlReaderSettings.ValidationFlags |= global::System.Xml.Schema.XmlSchemaValidationFlags.ReportValidationWarnings;
			xmlReaderSettings.ValidationEventHandler += this.OnSchemaValidationEvent;
			xmlReaderSettings.ValidationType = global::System.Xml.ValidationType.Schema;
			global::System.Xml.Schema.XmlSchemaSet schemaSet = global::System.Data.Entity.Core.SchemaObjectModel.Schema.SomSchemaSetHelper.GetSchemaSet(this.DataModel);
			xmlReaderSettings.Schemas = schemaSet;
			return xmlReaderSettings;
		}

		// Token: 0x06002535 RID: 9525 RVA: 0x00069094 File Offset: 0x00067294
		internal void OnSchemaValidationEvent(object sender, global::System.Xml.Schema.ValidationEventArgs e)
		{
			global::System.Xml.XmlReader xmlReader = sender as global::System.Xml.XmlReader;
			if (xmlReader != null && !this.IsValidateableXmlNamespace(xmlReader.NamespaceURI, xmlReader.NodeType == global::System.Xml.XmlNodeType.Attribute))
			{
				if (this.SchemaVersion == 1.0 || this.SchemaVersion == 1.1)
				{
					return;
				}
				if (xmlReader.NodeType == global::System.Xml.XmlNodeType.Attribute || e.Severity == global::System.Xml.Schema.XmlSeverityType.Warning)
				{
					return;
				}
			}
			if (this.SchemaVersion >= 2.0 && xmlReader.NodeType == global::System.Xml.XmlNodeType.Attribute && e.Severity == global::System.Xml.Schema.XmlSeverityType.Warning)
			{
				return;
			}
			global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity severity = global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error;
			if (e.Severity == global::System.Xml.Schema.XmlSeverityType.Warning)
			{
				severity = global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Warning;
			}
			base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.XmlError, severity, e.Exception.LineNumber, e.Exception.LinePosition, e.Message);
		}

		// Token: 0x06002536 RID: 9526 RVA: 0x00069150 File Offset: 0x00067350
		public bool IsParseableXmlNamespace(string xmlNamespaceUri, bool isAttribute)
		{
			if (string.IsNullOrEmpty(xmlNamespaceUri) && isAttribute)
			{
				return true;
			}
			if (this._parseableXmlNamespaces == null)
			{
				this._parseableXmlNamespaces = new global::System.Collections.Generic.HashSet<string>();
				foreach (global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource xmlSchemaResource in global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource.GetMetadataSchemaResourceMap(this.SchemaVersion).Values)
				{
					this._parseableXmlNamespaces.Add(xmlSchemaResource.NamespaceUri);
				}
			}
			return this._parseableXmlNamespaces.Contains(xmlNamespaceUri);
		}

		// Token: 0x06002537 RID: 9527 RVA: 0x000691E4 File Offset: 0x000673E4
		public bool IsValidateableXmlNamespace(string xmlNamespaceUri, bool isAttribute)
		{
			if (string.IsNullOrEmpty(xmlNamespaceUri) && isAttribute)
			{
				return true;
			}
			if (this._validatableXmlNamespaces == null)
			{
				global::System.Collections.Generic.HashSet<string> hashSet = new global::System.Collections.Generic.HashSet<string>();
				foreach (global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource schemaResource in global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource.GetMetadataSchemaResourceMap((this.SchemaVersion == 0.0) ? 3.0 : this.SchemaVersion).Values)
				{
					global::System.Data.Entity.Core.SchemaObjectModel.Schema.AddAllSchemaResourceNamespaceNames(hashSet, schemaResource);
				}
				if (this.SchemaVersion == 0.0)
				{
					return hashSet.Contains(xmlNamespaceUri);
				}
				this._validatableXmlNamespaces = hashSet;
			}
			return this._validatableXmlNamespaces.Contains(xmlNamespaceUri);
		}

		// Token: 0x06002538 RID: 9528 RVA: 0x000692A8 File Offset: 0x000674A8
		private static void AddAllSchemaResourceNamespaceNames(global::System.Collections.Generic.HashSet<string> hashSet, global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource schemaResource)
		{
			hashSet.Add(schemaResource.NamespaceUri);
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource schemaResource2 in schemaResource.ImportedSchemas)
			{
				global::System.Data.Entity.Core.SchemaObjectModel.Schema.AddAllSchemaResourceNamespaceNames(hashSet, schemaResource2);
			}
		}

		// Token: 0x06002539 RID: 9529 RVA: 0x000692E8 File Offset: 0x000674E8
		internal override void ResolveTopLevelNames()
		{
			base.ResolveTopLevelNames();
			this.AliasResolver.ResolveNamespaces();
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.SchemaType schemaType in this.SchemaTypes)
			{
				schemaType.ResolveTopLevelNames();
			}
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.Function function in this.Functions)
			{
				function.ResolveTopLevelNames();
			}
		}

		// Token: 0x0600253A RID: 9530 RVA: 0x00069388 File Offset: 0x00067588
		internal override void ResolveSecondLevelNames()
		{
			base.ResolveSecondLevelNames();
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.SchemaType schemaType in this.SchemaTypes)
			{
				schemaType.ResolveSecondLevelNames();
			}
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.Function function in this.Functions)
			{
				function.ResolveSecondLevelNames();
			}
		}

		// Token: 0x0600253B RID: 9531 RVA: 0x00069420 File Offset: 0x00067620
		internal override void Validate()
		{
			if (string.IsNullOrEmpty(this.Namespace))
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.MissingNamespaceAttribute, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.MissingNamespaceAttribute);
				return;
			}
			if (!string.IsNullOrEmpty(this.Alias) && global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection.IsSystemNamespace(this.ProviderManifest, this.Alias))
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.CannotUseSystemNamespaceAsAlias, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.CannotUseSystemNamespaceAsAlias(this.Alias));
			}
			if (this.ProviderManifest != null && global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection.IsSystemNamespace(this.ProviderManifest, this.Namespace))
			{
				base.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.SystemNamespace, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.SystemNamespaceEncountered(this.Namespace));
			}
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.SchemaType schemaType in this.SchemaTypes)
			{
				schemaType.Validate();
			}
			foreach (global::System.Data.Entity.Core.SchemaObjectModel.Function function in this.Functions)
			{
				this.AddFunctionType(function);
				function.Validate();
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x0600253C RID: 9532 RVA: 0x00069540 File Offset: 0x00067740
		// (set) Token: 0x0600253D RID: 9533 RVA: 0x00069548 File Offset: 0x00067748
		internal string SchemaXmlNamespace { get; private set; }

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x0600253E RID: 9534 RVA: 0x00069551 File Offset: 0x00067751
		internal global::System.Data.Entity.Core.Common.DbProviderManifest ProviderManifest
		{
			get
			{
				return this._schemaManager.GetProviderManifest(delegate(string message, global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode code, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity severity)
				{
					base.AddError(code, severity, message);
				});
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x0600253F RID: 9535 RVA: 0x0006956A File Offset: 0x0006776A
		// (set) Token: 0x06002540 RID: 9536 RVA: 0x00069572 File Offset: 0x00067772
		internal double SchemaVersion
		{
			get
			{
				return this._schemaVersion;
			}
			set
			{
				this._schemaVersion = value;
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x06002541 RID: 9537 RVA: 0x0006957B File Offset: 0x0006777B
		// (set) Token: 0x06002542 RID: 9538 RVA: 0x00069583 File Offset: 0x00067783
		internal virtual string Alias { get; private set; }

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x06002543 RID: 9539 RVA: 0x0006958C File Offset: 0x0006778C
		// (set) Token: 0x06002544 RID: 9540 RVA: 0x00069594 File Offset: 0x00067794
		internal virtual string Namespace
		{
			get
			{
				return this._namespaceName;
			}
			private set
			{
				this._namespaceName = value;
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x06002545 RID: 9541 RVA: 0x0006959D File Offset: 0x0006779D
		// (set) Token: 0x06002546 RID: 9542 RVA: 0x000695A5 File Offset: 0x000677A5
		internal string Location
		{
			get
			{
				return this._location;
			}
			private set
			{
				this._location = value;
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x06002547 RID: 9543 RVA: 0x000695B0 File Offset: 0x000677B0
		internal global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty SchemaSource
		{
			get
			{
				if (this._schemaSourceProperty == null)
				{
					this._schemaSourceProperty = new global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty("SchemaSource", global::System.Data.Entity.Core.Metadata.Edm.Provider.EdmProviderManifest.Instance.GetPrimitiveType(global::System.Data.Entity.Core.Metadata.Edm.PrimitiveTypeKind.String), false, (this._location != null) ? this._location : string.Empty);
				}
				return this._schemaSourceProperty;
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x06002548 RID: 9544 RVA: 0x000695FD File Offset: 0x000677FD
		internal global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.SchemaType> SchemaTypes
		{
			get
			{
				if (this._schemaTypes == null)
				{
					this._schemaTypes = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.SchemaType>();
				}
				return this._schemaTypes;
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x06002549 RID: 9545 RVA: 0x00069618 File Offset: 0x00067818
		public override string FQName
		{
			get
			{
				return this.Namespace;
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x0600254A RID: 9546 RVA: 0x00069620 File Offset: 0x00067820
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.Function> Functions
		{
			get
			{
				if (this._functions == null)
				{
					this._functions = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.Function>();
				}
				return this._functions;
			}
		}

		// Token: 0x0600254B RID: 9547 RVA: 0x0006963C File Offset: 0x0006783C
		protected override bool HandleElement(global::System.Xml.XmlReader reader)
		{
			if (base.HandleElement(reader))
			{
				return true;
			}
			if (base.CanHandleElement(reader, "EntityType"))
			{
				this.HandleEntityTypeElement(reader);
				return true;
			}
			if (base.CanHandleElement(reader, "ComplexType"))
			{
				this.HandleInlineTypeElement(reader);
				return true;
			}
			if (base.CanHandleElement(reader, "Association"))
			{
				this.HandleAssociationElement(reader);
				return true;
			}
			if (this.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.EntityDataModel)
			{
				if (base.CanHandleElement(reader, "Using"))
				{
					this.HandleUsingElement(reader);
					return true;
				}
				if (base.CanHandleElement(reader, "Function"))
				{
					this.HandleModelFunctionElement(reader);
					return true;
				}
				if (base.CanHandleElement(reader, "EnumType"))
				{
					this.HandleEnumTypeElement(reader);
					return true;
				}
				if (base.CanHandleElement(reader, "ValueTerm"))
				{
					this.SkipElement(reader);
					return true;
				}
				if (base.CanHandleElement(reader, "Annotations"))
				{
					this.SkipElement(reader);
					return true;
				}
			}
			if (this.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.EntityDataModel || this.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.ProviderDataModel)
			{
				if (base.CanHandleElement(reader, "EntityContainer"))
				{
					this.HandleEntityContainerTypeElement(reader);
					return true;
				}
				if (this.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.ProviderDataModel && base.CanHandleElement(reader, "Function"))
				{
					this.HandleFunctionElement(reader);
					return true;
				}
			}
			else
			{
				if (base.CanHandleElement(reader, "Types"))
				{
					this.SkipThroughElement(reader);
					return true;
				}
				if (base.CanHandleElement(reader, "Functions"))
				{
					this.SkipThroughElement(reader);
					return true;
				}
				if (base.CanHandleElement(reader, "Function"))
				{
					this.HandleFunctionElement(reader);
					return true;
				}
				if (base.CanHandleElement(reader, "Type"))
				{
					this.HandleTypeInformationElement(reader);
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x000697B9 File Offset: 0x000679B9
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

		// Token: 0x0600254D RID: 9549 RVA: 0x000697DC File Offset: 0x000679DC
		protected override bool HandleAttribute(global::System.Xml.XmlReader reader)
		{
			if (this._depth == 1)
			{
				return false;
			}
			if (base.HandleAttribute(reader))
			{
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "Alias"))
			{
				this.HandleAliasAttribute(reader);
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "Namespace"))
			{
				this.HandleNamespaceAttribute(reader);
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "Provider"))
			{
				this.HandleProviderAttribute(reader);
				return true;
			}
			if (global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement.CanHandleAttribute(reader, "ProviderManifestToken"))
			{
				this.HandleProviderManifestTokenAttribute(reader);
				return true;
			}
			if (reader.NamespaceURI == "http://schemas.microsoft.com/ado/2009/02/edm/annotation" && reader.LocalName == "UseStrongSpatialTypes")
			{
				this.HandleUseStrongSpatialTypesAnnotation(reader);
				return true;
			}
			return false;
		}

		// Token: 0x0600254E RID: 9550 RVA: 0x00069885 File Offset: 0x00067A85
		protected override void HandleAttributesComplete()
		{
			if (this._depth < 2)
			{
				return;
			}
			if (this._depth == 2)
			{
				this._schemaManager.EnsurePrimitiveSchemaIsLoaded(this.SchemaVersion);
			}
			base.HandleAttributesComplete();
		}

		// Token: 0x0600254F RID: 9551 RVA: 0x000698B4 File Offset: 0x00067AB4
		protected override void SkipThroughElement(global::System.Xml.XmlReader reader)
		{
			try
			{
				this._depth++;
				base.SkipThroughElement(reader);
			}
			finally
			{
				this._depth--;
			}
		}

		// Token: 0x06002550 RID: 9552 RVA: 0x000698F8 File Offset: 0x00067AF8
		internal bool ResolveTypeName(global::System.Data.Entity.Core.SchemaObjectModel.SchemaElement usingElement, string typeName, out global::System.Data.Entity.Core.SchemaObjectModel.SchemaType type)
		{
			type = null;
			string text;
			string text2;
			global::System.Data.Entity.Core.SchemaObjectModel.Utils.ExtractNamespaceAndName(typeName, out text, out text2);
			string text3 = text;
			if (text3 == null)
			{
				text3 = ((this.ProviderManifest == null) ? this._namespaceName : this.ProviderManifest.NamespaceName);
			}
			string text4;
			if (text == null || !this.AliasResolver.TryResolveAlias(text3, out text4))
			{
				text4 = text3;
			}
			if (!this.SchemaManager.TryResolveType(text4, text2, out type))
			{
				if (text == null)
				{
					usingElement.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.NotInNamespace, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.NotNamespaceQualified(typeName));
				}
				else if (!this.SchemaManager.IsValidNamespaceName(text4))
				{
					usingElement.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.BadNamespace, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.BadNamespaceOrAlias(text));
				}
				else if (text4 != text3)
				{
					usingElement.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.NotInNamespace, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.NotInNamespaceAlias(text2, text4, text3));
				}
				else
				{
					usingElement.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.NotInNamespace, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.NotInNamespaceNoAlias(text2, text4));
				}
				return false;
			}
			if (this.DataModel != global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.EntityDataModel && type.Schema != this && type.Schema != this.SchemaManager.PrimitiveSchema)
			{
				usingElement.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.InvalidNamespaceOrAliasSpecified, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.InvalidNamespaceOrAliasSpecified(text));
				return false;
			}
			return true;
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06002551 RID: 9553 RVA: 0x000699F4 File Offset: 0x00067BF4
		internal global::System.Data.Entity.Core.SchemaObjectModel.AliasResolver AliasResolver
		{
			get
			{
				if (this._aliasResolver == null)
				{
					this._aliasResolver = new global::System.Data.Entity.Core.SchemaObjectModel.AliasResolver(this);
				}
				return this._aliasResolver;
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06002552 RID: 9554 RVA: 0x00069A10 File Offset: 0x00067C10
		internal global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption DataModel
		{
			get
			{
				return this.SchemaManager.DataModel;
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06002553 RID: 9555 RVA: 0x00069A1D File Offset: 0x00067C1D
		internal global::System.Data.Entity.Core.SchemaObjectModel.SchemaManager SchemaManager
		{
			get
			{
				return this._schemaManager;
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06002554 RID: 9556 RVA: 0x00069A28 File Offset: 0x00067C28
		internal bool UseStrongSpatialTypes
		{
			get
			{
				return this._useStrongSpatialTypes ?? true;
			}
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x00069A50 File Offset: 0x00067C50
		private void HandleNamespaceAttribute(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.ReturnValue<string> returnValue = base.HandleDottedNameAttribute(reader, this.Namespace);
			if (!returnValue.Succeeded)
			{
				return;
			}
			this.Namespace = returnValue.Value;
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x00069A80 File Offset: 0x00067C80
		private void HandleAliasAttribute(global::System.Xml.XmlReader reader)
		{
			this.Alias = base.HandleUndottedNameAttribute(reader, this.Alias);
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x00069A98 File Offset: 0x00067C98
		private void HandleProviderAttribute(global::System.Xml.XmlReader reader)
		{
			string value = reader.Value;
			this._schemaManager.ProviderNotification(value, delegate(string message, global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode code, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity severity)
			{
				this.AddError(code, severity, reader, message);
			});
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x00069AE4 File Offset: 0x00067CE4
		private void HandleProviderManifestTokenAttribute(global::System.Xml.XmlReader reader)
		{
			string value = reader.Value;
			this._schemaManager.ProviderManifestTokenNotification(value, delegate(string message, global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode code, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity severity)
			{
				this.AddError(code, severity, reader, message);
			});
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x00069B30 File Offset: 0x00067D30
		private void HandleUseStrongSpatialTypesAnnotation(global::System.Xml.XmlReader reader)
		{
			bool value = false;
			if (base.HandleBoolAttribute(reader, ref value))
			{
				this._useStrongSpatialTypes = new bool?(value);
			}
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x00069B58 File Offset: 0x00067D58
		private void HandleUsingElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.UsingElement usingElement = new global::System.Data.Entity.Core.SchemaObjectModel.UsingElement(this);
			usingElement.Parse(reader);
			this.AliasResolver.Add(usingElement);
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x00069B80 File Offset: 0x00067D80
		private void HandleEnumTypeElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.SchemaEnumType schemaEnumType = new global::System.Data.Entity.Core.SchemaObjectModel.SchemaEnumType(this);
			schemaEnumType.Parse(reader);
			this.TryAddType(schemaEnumType, true);
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x00069BA4 File Offset: 0x00067DA4
		private void HandleTopLevelSchemaElement(global::System.Xml.XmlReader reader)
		{
			try
			{
				this._depth += 2;
				base.Parse(reader);
			}
			finally
			{
				this._depth -= 2;
			}
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x00069BE8 File Offset: 0x00067DE8
		private void HandleEntityTypeElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType schemaEntityType = new global::System.Data.Entity.Core.SchemaObjectModel.SchemaEntityType(this);
			schemaEntityType.Parse(reader);
			this.TryAddType(schemaEntityType, true);
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x00069C0C File Offset: 0x00067E0C
		private void HandleTypeInformationElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.TypeElement typeElement = new global::System.Data.Entity.Core.SchemaObjectModel.TypeElement(this);
			typeElement.Parse(reader);
			this.TryAddType(typeElement, true);
		}

		// Token: 0x0600255F RID: 9567 RVA: 0x00069C30 File Offset: 0x00067E30
		private void HandleFunctionElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.Function function = new global::System.Data.Entity.Core.SchemaObjectModel.Function(this);
			function.Parse(reader);
			this.Functions.Add(function);
		}

		// Token: 0x06002560 RID: 9568 RVA: 0x00069C58 File Offset: 0x00067E58
		private void HandleModelFunctionElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.ModelFunction modelFunction = new global::System.Data.Entity.Core.SchemaObjectModel.ModelFunction(this);
			modelFunction.Parse(reader);
			this.Functions.Add(modelFunction);
		}

		// Token: 0x06002561 RID: 9569 RVA: 0x00069C80 File Offset: 0x00067E80
		private void HandleAssociationElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.Relationship relationship = new global::System.Data.Entity.Core.SchemaObjectModel.Relationship(this, global::System.Data.Entity.Core.Objects.DataClasses.RelationshipKind.Association);
			relationship.Parse(reader);
			this.TryAddType(relationship, true);
		}

		// Token: 0x06002562 RID: 9570 RVA: 0x00069CA4 File Offset: 0x00067EA4
		private void HandleInlineTypeElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.SchemaComplexType schemaComplexType = new global::System.Data.Entity.Core.SchemaObjectModel.SchemaComplexType(this);
			schemaComplexType.Parse(reader);
			this.TryAddType(schemaComplexType, true);
		}

		// Token: 0x06002563 RID: 9571 RVA: 0x00069CC8 File Offset: 0x00067EC8
		private void HandleEntityContainerTypeElement(global::System.Xml.XmlReader reader)
		{
			global::System.Data.Entity.Core.SchemaObjectModel.EntityContainer entityContainer = new global::System.Data.Entity.Core.SchemaObjectModel.EntityContainer(this);
			entityContainer.Parse(reader);
			this.TryAddContainer(entityContainer, true);
		}

		// Token: 0x06002564 RID: 9572 RVA: 0x00069CEB File Offset: 0x00067EEB
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> ResetErrors()
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> errors = this._errors;
			this._errors = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError>();
			return errors;
		}

		// Token: 0x06002565 RID: 9573 RVA: 0x00069CFE File Offset: 0x00067EFE
		protected void TryAddType(global::System.Data.Entity.Core.SchemaObjectModel.SchemaType schemaType, bool doNotAddErrorForEmptyName)
		{
			this.SchemaManager.SchemaTypes.Add(schemaType, doNotAddErrorForEmptyName, new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.TypeNameAlreadyDefinedDuplicate));
			this.SchemaTypes.Add(schemaType);
		}

		// Token: 0x06002566 RID: 9574 RVA: 0x00069D2A File Offset: 0x00067F2A
		protected void TryAddContainer(global::System.Data.Entity.Core.SchemaObjectModel.SchemaType schemaType, bool doNotAddErrorForEmptyName)
		{
			this.SchemaManager.SchemaTypes.Add(schemaType, doNotAddErrorForEmptyName, new global::System.Func<object, string>(global::System.Data.Entity.Resources.Strings.EntityContainerAlreadyExists));
			this.SchemaTypes.Add(schemaType);
		}

		// Token: 0x06002567 RID: 9575 RVA: 0x00069D58 File Offset: 0x00067F58
		protected void AddFunctionType(global::System.Data.Entity.Core.SchemaObjectModel.Function function)
		{
			string p = (this.DataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.EntityDataModel) ? "Conceptual" : "Storage";
			if (this.SchemaVersion >= 2.0 && this.SchemaManager.SchemaTypes.ContainsKey(function.FQName))
			{
				function.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.AlreadyDefined, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.AmbiguousFunctionAndType(function.FQName, p));
				return;
			}
			if (this.SchemaManager.SchemaTypes.TryAdd(function) != global::System.Data.Entity.Core.SchemaObjectModel.AddErrorKind.Succeeded)
			{
				function.AddError(global::System.Data.Entity.Core.SchemaObjectModel.ErrorCode.AlreadyDefined, global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaErrorSeverity.Error, global::System.Data.Entity.Resources.Strings.AmbiguousFunctionOverload(function.FQName, p));
				return;
			}
			this.SchemaTypes.Add(function);
		}

		// Token: 0x04000D1F RID: 3359
		private const int RootDepth = 2;

		// Token: 0x04000D20 RID: 3360
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError> _errors = new global::System.Collections.Generic.List<global::System.Data.Entity.Core.Metadata.Edm.EdmSchemaError>();

		// Token: 0x04000D21 RID: 3361
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.Function> _functions;

		// Token: 0x04000D22 RID: 3362
		private global::System.Data.Entity.Core.SchemaObjectModel.AliasResolver _aliasResolver;

		// Token: 0x04000D23 RID: 3363
		private string _location;

		// Token: 0x04000D24 RID: 3364
		protected string _namespaceName;

		// Token: 0x04000D25 RID: 3365
		private global::System.Collections.Generic.List<global::System.Data.Entity.Core.SchemaObjectModel.SchemaType> _schemaTypes;

		// Token: 0x04000D26 RID: 3366
		private int _depth;

		// Token: 0x04000D27 RID: 3367
		private double _schemaVersion;

		// Token: 0x04000D28 RID: 3368
		private readonly global::System.Data.Entity.Core.SchemaObjectModel.SchemaManager _schemaManager;

		// Token: 0x04000D29 RID: 3369
		private bool? _useStrongSpatialTypes;

		// Token: 0x04000D2A RID: 3370
		private global::System.Collections.Generic.HashSet<string> _validatableXmlNamespaces;

		// Token: 0x04000D2B RID: 3371
		private global::System.Collections.Generic.HashSet<string> _parseableXmlNamespaces;

		// Token: 0x04000D2E RID: 3374
		private global::System.Data.Entity.Core.Metadata.Edm.MetadataProperty _schemaSourceProperty;

		// Token: 0x020009B7 RID: 2487
		private static class SomSchemaSetHelper
		{
			// Token: 0x06005F58 RID: 24408 RVA: 0x00146FC0 File Offset: 0x001451C0
			internal static global::System.Collections.Generic.List<string> GetPrimarySchemaNamespaces(global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption dataModel)
			{
				global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
				if (dataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.EntityDataModel)
				{
					list.Add("http://schemas.microsoft.com/ado/2006/04/edm");
					list.Add("http://schemas.microsoft.com/ado/2007/05/edm");
					list.Add("http://schemas.microsoft.com/ado/2008/09/edm");
					list.Add("http://schemas.microsoft.com/ado/2009/11/edm");
				}
				else if (dataModel == global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption.ProviderDataModel)
				{
					list.Add("http://schemas.microsoft.com/ado/2006/04/edm/ssdl");
					list.Add("http://schemas.microsoft.com/ado/2009/02/edm/ssdl");
					list.Add("http://schemas.microsoft.com/ado/2009/11/edm/ssdl");
				}
				else
				{
					list.Add("http://schemas.microsoft.com/ado/2006/04/edm/providermanifest");
				}
				return list;
			}

			// Token: 0x06005F59 RID: 24409 RVA: 0x00147037 File Offset: 0x00145237
			internal static global::System.Xml.Schema.XmlSchemaSet GetSchemaSet(global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption dataModel)
			{
				return global::System.Data.Entity.Core.SchemaObjectModel.Schema.SomSchemaSetHelper._cachedSchemaSets.Evaluate(dataModel);
			}

			// Token: 0x06005F5A RID: 24410 RVA: 0x00147044 File Offset: 0x00145244
			private static global::System.Xml.Schema.XmlSchemaSet ComputeSchemaSet(global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption dataModel)
			{
				global::System.Collections.Generic.List<string> primarySchemaNamespaces = global::System.Data.Entity.Core.SchemaObjectModel.Schema.SomSchemaSetHelper.GetPrimarySchemaNamespaces(dataModel);
				global::System.Xml.Schema.XmlSchemaSet xmlSchemaSet = new global::System.Xml.Schema.XmlSchemaSet();
				xmlSchemaSet.XmlResolver = null;
				global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource> metadataSchemaResourceMap = global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource.GetMetadataSchemaResourceMap(3.0);
				global::System.Collections.Generic.HashSet<string> schemasAlreadyAdded = new global::System.Collections.Generic.HashSet<string>();
				foreach (string key in primarySchemaNamespaces)
				{
					global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource schemaResource = metadataSchemaResourceMap[key];
					global::System.Data.Entity.Core.SchemaObjectModel.Schema.SomSchemaSetHelper.AddXmlSchemaToSet(xmlSchemaSet, schemaResource, schemasAlreadyAdded);
				}
				xmlSchemaSet.Compile();
				return xmlSchemaSet;
			}

			// Token: 0x06005F5B RID: 24411 RVA: 0x001470D0 File Offset: 0x001452D0
			private static void AddXmlSchemaToSet(global::System.Xml.Schema.XmlSchemaSet schemaSet, global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource schemaResource, global::System.Collections.Generic.HashSet<string> schemasAlreadyAdded)
			{
				foreach (global::System.Data.Entity.Core.SchemaObjectModel.XmlSchemaResource schemaResource2 in schemaResource.ImportedSchemas)
				{
					global::System.Data.Entity.Core.SchemaObjectModel.Schema.SomSchemaSetHelper.AddXmlSchemaToSet(schemaSet, schemaResource2, schemasAlreadyAdded);
				}
				if (!schemasAlreadyAdded.Contains(schemaResource.NamespaceUri))
				{
					global::System.Xml.Schema.XmlSchema schema = global::System.Xml.Schema.XmlSchema.Read(global::System.Data.Entity.Core.SchemaObjectModel.Schema.SomSchemaSetHelper.GetResourceStream(schemaResource.ResourceName), null);
					schemaSet.Add(schema);
					schemasAlreadyAdded.Add(schemaResource.NamespaceUri);
				}
			}

			// Token: 0x06005F5C RID: 24412 RVA: 0x00147137 File Offset: 0x00145337
			private static global::System.IO.Stream GetResourceStream(string resourceName)
			{
				return typeof(global::System.Data.Entity.Core.SchemaObjectModel.Schema).Assembly().GetManifestResourceStream(resourceName);
			}

			// Token: 0x04002805 RID: 10245
			private static readonly global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption, global::System.Xml.Schema.XmlSchemaSet> _cachedSchemaSets = new global::System.Data.Entity.Core.Common.Utils.Memoizer<global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption, global::System.Xml.Schema.XmlSchemaSet>(new global::System.Func<global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption, global::System.Xml.Schema.XmlSchemaSet>(global::System.Data.Entity.Core.SchemaObjectModel.Schema.SomSchemaSetHelper.ComputeSchemaSet), global::System.Collections.Generic.EqualityComparer<global::System.Data.Entity.Core.SchemaObjectModel.SchemaDataModelOption>.Default);
		}
	}
}
