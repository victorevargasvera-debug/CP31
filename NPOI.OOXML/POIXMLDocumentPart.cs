using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using NPOI.OpenXml4Net.Exceptions;
using NPOI.OpenXml4Net.OPC;
using NPOI.OpenXml4Net.OPC.Internal;
using NPOI.OpenXml4Net.Util;
using NPOI.Util;

namespace NPOI
{
	// Token: 0x02000003 RID: 3
	public class POIXMLDocumentPart
	{
		// Token: 0x0600000F RID: 15 RVA: 0x000022CB File Offset: 0x000004CB
		private int IncrementRelationCounter()
		{
			this.relationCounter++;
			return this.relationCounter;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000022E1 File Offset: 0x000004E1
		private int DecrementRelationCounter()
		{
			this.relationCounter--;
			return this.relationCounter;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000022F7 File Offset: 0x000004F7
		private int GetRelationCounter()
		{
			return this.relationCounter;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000022FF File Offset: 0x000004FF
		public POIXMLDocumentPart(global::NPOI.OpenXml4Net.OPC.OPCPackage pkg) : this(pkg, "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument")
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002310 File Offset: 0x00000510
		public POIXMLDocumentPart(global::NPOI.OpenXml4Net.OPC.OPCPackage pkg, string coreDocumentRel) : this(global::NPOI.POIXMLDocumentPart.GetPartFromOPCPackage(pkg, coreDocumentRel))
		{
			this.coreDocumentRel = coreDocumentRel;
			global::NPOI.OpenXml4Net.OPC.PackageRelationship relationship = pkg.GetRelationshipsByType(this.coreDocumentRel).GetRelationship(0);
			if (relationship == null)
			{
				relationship = pkg.GetRelationshipsByType("http://purl.oclc.org/ooxml/officeDocument/relationships/officeDocument").GetRelationship(0);
				if (relationship != null)
				{
					throw new global::NPOI.POIXMLException("Strict OOXML isn't currently supported, please see bug #57699");
				}
			}
			if (relationship == null)
			{
				throw new global::NPOI.POIXMLException("OOXML file structure broken/invalid - no core document found!");
			}
			this.packagePart = pkg.GetPart(relationship);
			this.packageRel = relationship;
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002389 File Offset: 0x00000589
		public POIXMLDocumentPart()
		{
			this.coreDocumentRel = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument";
			this.relations = new global::System.Collections.Generic.Dictionary<string, global::NPOI.POIXMLDocumentPart.RelationPart>();
			base..ctor();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000023A7 File Offset: 0x000005A7
		public POIXMLDocumentPart(global::NPOI.OpenXml4Net.OPC.PackagePart part) : this(null, part)
		{
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000023B1 File Offset: 0x000005B1
		public POIXMLDocumentPart(global::NPOI.POIXMLDocumentPart parent, global::NPOI.OpenXml4Net.OPC.PackagePart part)
		{
			this.coreDocumentRel = "http://schemas.openxmlformats.org/officeDocument/2006/relationships/officeDocument";
			this.relations = new global::System.Collections.Generic.Dictionary<string, global::NPOI.POIXMLDocumentPart.RelationPart>();
			base..ctor();
			this.packagePart = part;
			this.parent = parent;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000023A7 File Offset: 0x000005A7
		[global::System.Obsolete("deprecated in POI 3.14, scheduled for removal in POI 3.16")]
		public POIXMLDocumentPart(global::NPOI.OpenXml4Net.OPC.PackagePart part, global::NPOI.OpenXml4Net.OPC.PackageRelationship rel) : this(null, part)
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000023DD File Offset: 0x000005DD
		[global::System.Obsolete("deprecated in POI 3.14, scheduled for removal in POI 3.16")]
		public POIXMLDocumentPart(global::NPOI.POIXMLDocumentPart parent, global::NPOI.OpenXml4Net.OPC.PackagePart part, global::NPOI.OpenXml4Net.OPC.PackageRelationship rel) : this(null, part)
		{
			this.packagePart = part;
			this.packageRel = rel;
			this.parent = parent;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000023FC File Offset: 0x000005FC
		protected void Rebase(global::NPOI.OpenXml4Net.OPC.OPCPackage pkg)
		{
			global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection relationshipsByType = this.packagePart.GetRelationshipsByType(this.coreDocumentRel);
			if (relationshipsByType.Size != 1)
			{
				throw new global::System.InvalidOperationException(string.Concat(new string[]
				{
					"Tried to rebase using ",
					this.coreDocumentRel,
					" but found ",
					relationshipsByType.Size.ToString(),
					" parts of the right type"
				}));
			}
			this.packagePart = this.packagePart.GetRelatedPart(relationshipsByType.GetRelationship(0));
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600001A RID: 26 RVA: 0x0000247F File Offset: 0x0000067F
		public static global::System.Xml.XmlNamespaceManager NamespaceManager
		{
			get
			{
				if (global::NPOI.POIXMLDocumentPart.nsm == null)
				{
					global::NPOI.POIXMLDocumentPart.nsm = global::NPOI.POIXMLDocumentPart.CreateDefaultNSM();
				}
				return global::NPOI.POIXMLDocumentPart.nsm;
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002498 File Offset: 0x00000698
		internal static global::System.Xml.XmlNamespaceManager CreateDefaultNSM()
		{
			global::System.Xml.XmlNamespaceManager xmlNamespaceManager = new global::System.Xml.XmlNamespaceManager(new global::System.Xml.NameTable());
			xmlNamespaceManager.AddNamespace(string.Empty, "http://schemas.openxmlformats.org/spreadsheetml/2006/main");
			xmlNamespaceManager.AddNamespace("d", "http://schemas.openxmlformats.org/spreadsheetml/2006/main");
			xmlNamespaceManager.AddNamespace("a", "http://schemas.openxmlformats.org/drawingml/2006/main");
			xmlNamespaceManager.AddNamespace("xdr", "http://schemas.openxmlformats.org/drawingml/2006/spreadsheetDrawing");
			xmlNamespaceManager.AddNamespace("r", "http://schemas.openxmlformats.org/officeDocument/2006/relationships");
			xmlNamespaceManager.AddNamespace("c", "http://schemas.openxmlformats.org/drawingml/2006/chart");
			xmlNamespaceManager.AddNamespace("vt", "http://schemas.openxmlformats.org/officeDocument/2006/docPropsVTypes");
			xmlNamespaceManager.AddNamespace("w", "http://schemas.openxmlformats.org/wordprocessingml/2006/main");
			xmlNamespaceManager.AddNamespace("wp", "http://schemas.openxmlformats.org/drawingml/2006/wordprocessingDrawing");
			xmlNamespaceManager.AddNamespace("m", "http://schemas.openxmlformats.org/officeDocument/2006/math");
			xmlNamespaceManager.AddNamespace("ve", "http://schemas.openxmlformats.org/markup-compatibility/2006");
			xmlNamespaceManager.AddNamespace("mc", "http://schemas.openxmlformats.org/markup-compatibility/2006");
			xmlNamespaceManager.AddNamespace("o", "urn:schemas-microsoft-com:office:office");
			xmlNamespaceManager.AddNamespace("v", "urn:schemas-microsoft-com:vml");
			xmlNamespaceManager.AddNamespace("wne", "http://schemas.microsoft.com/office/word/2006/wordml");
			xmlNamespaceManager.AddNamespace("xp", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/extended-properties");
			xmlNamespaceManager.AddNamespace("ctp", "http://schemas.openxmlformats.org/officeDocument/2006/relationships/custom-properties");
			xmlNamespaceManager.AddNamespace("cp", global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart.NAMESPACE_CP_URI);
			xmlNamespaceManager.AddNamespace("dc", global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart.NAMESPACE_DC_URI);
			xmlNamespaceManager.AddNamespace("dcterms", global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart.NAMESPACE_DCTERMS_URI);
			xmlNamespaceManager.AddNamespace("dcmitype", "http://purl.org/dc/dcmitype/");
			xmlNamespaceManager.AddNamespace("xsi", global::NPOI.OpenXml4Net.OPC.Internal.PackagePropertiesPart.NAMESPACE_XSI_URI);
			xmlNamespaceManager.AddNamespace("xsd", "http://www.w3.org/2001/XMLSchema");
			return xmlNamespaceManager;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000261F File Offset: 0x0000081F
		public global::NPOI.OpenXml4Net.OPC.PackagePart GetPackagePart()
		{
			return this.packagePart;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002627 File Offset: 0x00000827
		public static global::System.Xml.XmlDocument ConvertStreamToXml(global::System.IO.Stream xmlStream)
		{
			global::System.Xml.XmlDocument xmlDocument = new global::System.Xml.XmlDocument();
			global::NPOI.OpenXml4Net.Util.XmlHelper.LoadXmlSafe(xmlDocument, xmlStream);
			return xmlDocument;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002638 File Offset: 0x00000838
		[global::System.Obsolete("deprecated in POI 3.14, scheduled for removal in POI 3.16")]
		public global::NPOI.OpenXml4Net.OPC.PackageRelationship GetPackageRelationship()
		{
			if (this.parent != null)
			{
				using (global::System.Collections.Generic.List<global::NPOI.POIXMLDocumentPart.RelationPart>.Enumerator enumerator = this.parent.RelationParts.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						global::NPOI.POIXMLDocumentPart.RelationPart relationPart = enumerator.Current;
						if (relationPart.DocumentPart == this)
						{
							return relationPart.Relationship;
						}
					}
					goto IL_B1;
				}
			}
			global::NPOI.OpenXml4Net.OPC.OPCPackage package = this.GetPackagePart().Package;
			string name = this.GetPackagePart().PartName.Name;
			foreach (global::NPOI.OpenXml4Net.OPC.PackageRelationship packageRelationship in package.Relationships)
			{
				if (packageRelationship.TargetUri.ToString().Equals(name))
				{
					return packageRelationship;
				}
			}
			IL_B1:
			return null;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002718 File Offset: 0x00000918
		public global::System.Collections.Generic.List<global::NPOI.POIXMLDocumentPart> GetRelations()
		{
			global::System.Collections.Generic.List<global::NPOI.POIXMLDocumentPart> list = new global::System.Collections.Generic.List<global::NPOI.POIXMLDocumentPart>();
			foreach (global::NPOI.POIXMLDocumentPart.RelationPart relationPart in this.relations.Values)
			{
				list.Add(relationPart.DocumentPart);
			}
			return list;
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000020 RID: 32 RVA: 0x0000277C File Offset: 0x0000097C
		public global::System.Collections.Generic.List<global::NPOI.POIXMLDocumentPart.RelationPart> RelationParts
		{
			get
			{
				return new global::System.Collections.Generic.List<global::NPOI.POIXMLDocumentPart.RelationPart>(this.relations.Values);
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002790 File Offset: 0x00000990
		public global::NPOI.POIXMLDocumentPart GetRelationById(string id)
		{
			if (string.IsNullOrEmpty(id) || !this.relations.ContainsKey(id))
			{
				return null;
			}
			global::NPOI.POIXMLDocumentPart.RelationPart relationPart = this.relations[id];
			if (relationPart != null)
			{
				return relationPart.DocumentPart;
			}
			return null;
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000027D0 File Offset: 0x000009D0
		public string GetRelationId(global::NPOI.POIXMLDocumentPart part)
		{
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::NPOI.POIXMLDocumentPart.RelationPart> keyValuePair in this.relations)
			{
				if (keyValuePair.Value.DocumentPart == part)
				{
					return keyValuePair.Value.Relationship.Id;
				}
			}
			return null;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002844 File Offset: 0x00000A44
		[global::System.Obsolete("deprecated in POI 3.14, scheduled for removal in POI 3.16")]
		public void AddRelation(string id, global::NPOI.POIXMLDocumentPart part)
		{
			global::NPOI.OpenXml4Net.OPC.PackageRelationship relationship = part.GetPackagePart().GetRelationship(id);
			this.AddRelation(relationship, part);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002868 File Offset: 0x00000A68
		public global::NPOI.POIXMLDocumentPart.RelationPart AddRelation(string relId, global::NPOI.POIXMLRelation relationshipType, global::NPOI.POIXMLDocumentPart part)
		{
			global::NPOI.OpenXml4Net.OPC.PackageRelationship packageRelationship = this.packagePart.FindExistingRelation(part.GetPackagePart());
			if (packageRelationship == null)
			{
				global::NPOI.OpenXml4Net.OPC.PackagePartName partName = part.GetPackagePart().PartName;
				string relation = relationshipType.Relation;
				packageRelationship = this.packagePart.AddRelationship(partName, global::NPOI.OpenXml4Net.OPC.TargetMode.Internal, relation, relId);
			}
			this.AddRelation(packageRelationship, part);
			return new global::NPOI.POIXMLDocumentPart.RelationPart(packageRelationship, part);
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000028BC File Offset: 0x00000ABC
		private void AddRelation(global::NPOI.OpenXml4Net.OPC.PackageRelationship pr, global::NPOI.POIXMLDocumentPart part)
		{
			if (this.relations.ContainsKey(pr.Id))
			{
				this.relations[pr.Id] = new global::NPOI.POIXMLDocumentPart.RelationPart(pr, part);
			}
			else
			{
				this.relations.Add(pr.Id, new global::NPOI.POIXMLDocumentPart.RelationPart(pr, part));
			}
			part.IncrementRelationCounter();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002915 File Offset: 0x00000B15
		protected internal void RemoveRelation(global::NPOI.POIXMLDocumentPart part)
		{
			this.RemoveRelation(part, true);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002920 File Offset: 0x00000B20
		protected internal bool RemoveRelation(global::NPOI.POIXMLDocumentPart part, bool RemoveUnusedParts)
		{
			string relationId = this.GetRelationId(part);
			if (relationId == null)
			{
				return false;
			}
			part.DecrementRelationCounter();
			this.GetPackagePart().RemoveRelationship(relationId);
			this.relations.Remove(relationId);
			if (RemoveUnusedParts && part.GetRelationCounter() == 0)
			{
				try
				{
					part.onDocumentRemove();
				}
				catch (global::System.IO.IOException ex)
				{
					throw new global::NPOI.POIXMLException(ex);
				}
				this.GetPackagePart().Package.RemovePart(part.GetPackagePart());
			}
			return true;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000299C File Offset: 0x00000B9C
		public global::NPOI.POIXMLDocumentPart GetParent()
		{
			return this.parent;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000029A4 File Offset: 0x00000BA4
		public override string ToString()
		{
			if (this.packagePart != null)
			{
				return this.packagePart.ToString();
			}
			return string.Empty;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000029BF File Offset: 0x00000BBF
		protected internal virtual void Commit()
		{
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000029C4 File Offset: 0x00000BC4
		protected internal void OnSave(global::System.Collections.Generic.List<global::NPOI.OpenXml4Net.OPC.PackagePart> alreadySaved)
		{
			this.PrepareForCommit();
			this.Commit();
			alreadySaved.Add(this.GetPackagePart());
			foreach (global::NPOI.POIXMLDocumentPart.RelationPart relationPart in this.relations.Values)
			{
				global::NPOI.POIXMLDocumentPart documentPart = relationPart.DocumentPart;
				if (!alreadySaved.Contains(documentPart.GetPackagePart()))
				{
					documentPart.OnSave(alreadySaved);
				}
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002A48 File Offset: 0x00000C48
		protected internal virtual void PrepareForCommit()
		{
			global::NPOI.OpenXml4Net.OPC.PackagePart packagePart = this.GetPackagePart();
			if (packagePart != null)
			{
				packagePart.Clear();
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002A65 File Offset: 0x00000C65
		public global::NPOI.POIXMLDocumentPart CreateRelationship(global::NPOI.POIXMLRelation descriptor, global::NPOI.POIXMLFactory factory)
		{
			return this.CreateRelationship(descriptor, factory, -1, false).DocumentPart;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00002A76 File Offset: 0x00000C76
		public global::NPOI.POIXMLDocumentPart CreateRelationship(global::NPOI.POIXMLRelation descriptor, global::NPOI.POIXMLFactory factory, int idx)
		{
			return this.CreateRelationship(descriptor, factory, idx, false).DocumentPart;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002A88 File Offset: 0x00000C88
		protected global::NPOI.POIXMLDocumentPart.RelationPart CreateRelationship(global::NPOI.POIXMLRelation descriptor, global::NPOI.POIXMLFactory factory, int idx, bool noRelation)
		{
			global::NPOI.POIXMLDocumentPart.RelationPart result;
			try
			{
				global::NPOI.OpenXml4Net.OPC.PackagePartName packagePartName = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CreatePartName(descriptor.GetFileName(idx));
				global::NPOI.OpenXml4Net.OPC.PackageRelationship packageRelationship = null;
				global::NPOI.OpenXml4Net.OPC.PackagePart packagePart = this.packagePart.Package.CreatePart(packagePartName, descriptor.ContentType);
				if (!noRelation)
				{
					packageRelationship = this.packagePart.AddRelationship(packagePartName, global::NPOI.OpenXml4Net.OPC.TargetMode.Internal, descriptor.Relation);
				}
				global::NPOI.POIXMLDocumentPart poixmldocumentPart = factory.NewDocumentPart(descriptor);
				poixmldocumentPart.packageRel = packageRelationship;
				poixmldocumentPart.packagePart = packagePart;
				poixmldocumentPart.parent = this;
				if (!noRelation)
				{
					this.AddRelation(packageRelationship, poixmldocumentPart);
				}
				result = new global::NPOI.POIXMLDocumentPart.RelationPart(packageRelationship, poixmldocumentPart);
			}
			catch (global::NPOI.OpenXml4Net.Exceptions.PartAlreadyExistsException ex)
			{
				throw ex;
			}
			catch (global::System.Exception ex2)
			{
				throw new global::NPOI.POIXMLException(ex2);
			}
			return result;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002B30 File Offset: 0x00000D30
		public TValue PutDictionary<TKey, TValue>(global::System.Collections.Generic.Dictionary<TKey, TValue> dict, TKey key, TValue value)
		{
			TValue result = default(TValue);
			if (dict.ContainsKey(key))
			{
				result = dict[key];
				dict[key] = value;
			}
			else
			{
				dict.Add(key, value);
			}
			return result;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00002B6C File Offset: 0x00000D6C
		public TValue GetDictionary<TKey, TValue>(global::System.Collections.Generic.Dictionary<TKey, TValue> dict, TKey key)
		{
			if (dict.ContainsKey(key))
			{
				return dict[key];
			}
			return default(TValue);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002B94 File Offset: 0x00000D94
		protected void Read(global::NPOI.POIXMLFactory factory, global::System.Collections.Generic.Dictionary<global::NPOI.OpenXml4Net.OPC.PackagePart, global::NPOI.POIXMLDocumentPart> context)
		{
			global::NPOI.OpenXml4Net.OPC.PackagePart packagePart = this.GetPackagePart();
			global::NPOI.POIXMLDocumentPart poixmldocumentPart = this.PutDictionary<global::NPOI.OpenXml4Net.OPC.PackagePart, global::NPOI.POIXMLDocumentPart>(context, packagePart, this);
			if (poixmldocumentPart != null && poixmldocumentPart != this)
			{
				throw new global::NPOI.POIXMLException("Unique PackagePart-POIXMLDocumentPart relation broken!");
			}
			if (!packagePart.HasRelationships)
			{
				return;
			}
			global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection relationships = this.packagePart.Relationships;
			global::System.Collections.Generic.List<global::NPOI.POIXMLDocumentPart> list = new global::System.Collections.Generic.List<global::NPOI.POIXMLDocumentPart>();
			foreach (global::NPOI.OpenXml4Net.OPC.PackageRelationship packageRelationship in relationships)
			{
				global::NPOI.OpenXml4Net.OPC.TargetMode? targetMode = packageRelationship.TargetMode;
				global::NPOI.OpenXml4Net.OPC.TargetMode targetMode2 = global::NPOI.OpenXml4Net.OPC.TargetMode.Internal;
				if (targetMode.GetValueOrDefault() == targetMode2 & targetMode != null)
				{
					global::System.Uri targetUri = packageRelationship.TargetUri;
					global::NPOI.OpenXml4Net.OPC.PackagePartName partName2;
					if (targetUri.OriginalString.IndexOf('#') >= 0)
					{
						string partName = string.Empty;
						try
						{
							partName = targetUri.AbsolutePath;
						}
						catch (global::System.InvalidOperationException)
						{
							partName = targetUri.OriginalString.Substring(0, targetUri.OriginalString.IndexOf('#'));
						}
						partName2 = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CreatePartName(partName);
					}
					else
					{
						partName2 = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CreatePartName(targetUri);
					}
					global::NPOI.OpenXml4Net.OPC.PackagePart part = this.packagePart.Package.GetPart(partName2);
					if (part != null)
					{
						global::NPOI.POIXMLDocumentPart poixmldocumentPart2 = this.GetDictionary<global::NPOI.OpenXml4Net.OPC.PackagePart, global::NPOI.POIXMLDocumentPart>(context, part);
						if (poixmldocumentPart2 == null)
						{
							poixmldocumentPart2 = factory.CreateDocumentPart(this, part);
							poixmldocumentPart2.parent = this;
							this.PutDictionary<global::NPOI.OpenXml4Net.OPC.PackagePart, global::NPOI.POIXMLDocumentPart>(context, part, poixmldocumentPart2);
							list.Add(poixmldocumentPart2);
						}
						this.AddRelation(packageRelationship, poixmldocumentPart2);
					}
				}
			}
			foreach (global::NPOI.POIXMLDocumentPart poixmldocumentPart3 in list)
			{
				poixmldocumentPart3.Read(factory, context);
			}
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002D40 File Offset: 0x00000F40
		protected global::NPOI.OpenXml4Net.OPC.PackagePart GetTargetPart(global::NPOI.OpenXml4Net.OPC.PackageRelationship rel)
		{
			return this.GetPackagePart().GetRelatedPart(rel);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000029BF File Offset: 0x00000BBF
		internal virtual void OnDocumentCreate()
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000029BF File Offset: 0x00000BBF
		internal virtual void OnDocumentRead()
		{
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000029BF File Offset: 0x00000BBF
		protected virtual void onDocumentRemove()
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002D50 File Offset: 0x00000F50
		private static global::NPOI.OpenXml4Net.OPC.PackagePart GetPartFromOPCPackage(global::NPOI.OpenXml4Net.OPC.OPCPackage pkg, string coreDocumentRel)
		{
			global::NPOI.OpenXml4Net.OPC.PackageRelationship relationship = pkg.GetRelationshipsByType(coreDocumentRel).GetRelationship(0);
			if (relationship != null)
			{
				global::NPOI.OpenXml4Net.OPC.PackagePart part = pkg.GetPart(relationship);
				if (part == null)
				{
					string str = "OOXML file structure broken/invalid - core document '";
					global::System.Uri targetUri = relationship.TargetUri;
					throw new global::NPOI.POIXMLException(str + ((targetUri != null) ? targetUri.ToString() : null) + "' not found.");
				}
				return part;
			}
			else
			{
				relationship = pkg.GetRelationshipsByType("http://purl.oclc.org/ooxml/officeDocument/relationships/officeDocument").GetRelationship(0);
				if (relationship != null)
				{
					throw new global::NPOI.POIXMLException("Strict OOXML isn't currently supported, please see bug #57699");
				}
				throw new global::NPOI.POIXMLException("OOXML file structure broken/invalid - no core document found!");
			}
		}

		// Token: 0x04000006 RID: 6
		private static global::NPOI.Util.POILogger logger = global::NPOI.Util.POILogFactory.GetLogger(typeof(global::NPOI.POIXMLDocumentPart));

		// Token: 0x04000007 RID: 7
		private string coreDocumentRel;

		// Token: 0x04000008 RID: 8
		private global::NPOI.OpenXml4Net.OPC.PackagePart packagePart;

		// Token: 0x04000009 RID: 9
		private global::NPOI.OpenXml4Net.OPC.PackageRelationship packageRel;

		// Token: 0x0400000A RID: 10
		private global::NPOI.POIXMLDocumentPart parent;

		// Token: 0x0400000B RID: 11
		private global::System.Collections.Generic.Dictionary<string, global::NPOI.POIXMLDocumentPart.RelationPart> relations;

		// Token: 0x0400000C RID: 12
		private int relationCounter;

		// Token: 0x0400000D RID: 13
		private static global::System.Xml.XmlNamespaceManager nsm = null;

		// Token: 0x0200011D RID: 285
		public class RelationPart
		{
			// Token: 0x06000FD5 RID: 4053 RVA: 0x00038218 File Offset: 0x00036418
			internal RelationPart(global::NPOI.OpenXml4Net.OPC.PackageRelationship relationship, global::NPOI.POIXMLDocumentPart documentPart)
			{
				this.relationship = relationship;
				this.documentPart = documentPart;
			}

			// Token: 0x170003BB RID: 955
			// (get) Token: 0x06000FD6 RID: 4054 RVA: 0x0003822E File Offset: 0x0003642E
			public global::NPOI.OpenXml4Net.OPC.PackageRelationship Relationship
			{
				get
				{
					return this.relationship;
				}
			}

			// Token: 0x06000FD7 RID: 4055 RVA: 0x00038236 File Offset: 0x00036436
			public T GetDocumentPart<T>() where T : global::NPOI.POIXMLDocumentPart
			{
				return (T)((object)this.documentPart);
			}

			// Token: 0x170003BC RID: 956
			// (get) Token: 0x06000FD8 RID: 4056 RVA: 0x00038243 File Offset: 0x00036443
			public global::NPOI.POIXMLDocumentPart DocumentPart
			{
				get
				{
					return this.documentPart;
				}
			}

			// Token: 0x040004EF RID: 1263
			private global::NPOI.OpenXml4Net.OPC.PackageRelationship relationship;

			// Token: 0x040004F0 RID: 1264
			private global::NPOI.POIXMLDocumentPart documentPart;
		}
	}
}
