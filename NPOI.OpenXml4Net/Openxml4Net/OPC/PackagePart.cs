using System;
using System.Collections.Generic;
using System.IO;
using NPOI.OpenXml4Net.Exceptions;
using NPOI.OpenXml4Net.OPC.Internal;

namespace NPOI.OpenXml4Net.OPC
{
	// Token: 0x02000013 RID: 19
	public abstract class PackagePart : global::NPOI.OpenXml4Net.OPC.RelationshipSource, global::System.IComparable<global::NPOI.OpenXml4Net.OPC.PackagePart>
	{
		// Token: 0x06000091 RID: 145 RVA: 0x000041D8 File Offset: 0x000023D8
		protected PackagePart(global::NPOI.OpenXml4Net.OPC.OPCPackage pack, global::NPOI.OpenXml4Net.OPC.PackagePartName partName, global::NPOI.OpenXml4Net.OPC.Internal.ContentType contentType) : this(pack, partName, contentType, true)
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x000041E4 File Offset: 0x000023E4
		protected PackagePart(global::NPOI.OpenXml4Net.OPC.OPCPackage pack, global::NPOI.OpenXml4Net.OPC.PackagePartName partName, global::NPOI.OpenXml4Net.OPC.Internal.ContentType contentType, bool loadRelationships)
		{
			this._partName = partName;
			this._contentType = contentType;
			this._container = (global::NPOI.OpenXml4Net.OPC.ZipPackage)pack;
			this._isRelationshipPart = this._partName.IsRelationshipPartURI();
			if (loadRelationships)
			{
				this.LoadRelationships();
			}
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00004221 File Offset: 0x00002421
		public PackagePart(global::NPOI.OpenXml4Net.OPC.OPCPackage pack, global::NPOI.OpenXml4Net.OPC.PackagePartName partName, string contentType) : this(pack, partName, new global::NPOI.OpenXml4Net.OPC.Internal.ContentType(contentType))
		{
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00004231 File Offset: 0x00002431
		public global::NPOI.OpenXml4Net.OPC.PackageRelationship FindExistingRelation(global::NPOI.OpenXml4Net.OPC.PackagePart packagePart)
		{
			return this._relationships.FindExistingInternalRelation(packagePart);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000423F File Offset: 0x0000243F
		public global::NPOI.OpenXml4Net.OPC.PackageRelationship AddExternalRelationship(string target, string relationshipType)
		{
			return this.AddExternalRelationship(target, relationshipType, null);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000424C File Offset: 0x0000244C
		public global::NPOI.OpenXml4Net.OPC.PackageRelationship AddExternalRelationship(string target, string relationshipType, string id)
		{
			if (target == null)
			{
				throw new global::System.ArgumentException("target");
			}
			if (relationshipType == null)
			{
				throw new global::System.ArgumentException("relationshipType");
			}
			if (this._relationships == null)
			{
				this._relationships = new global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection();
			}
			global::System.Uri targetUri;
			try
			{
				targetUri = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.ParseUri(target, global::System.UriKind.RelativeOrAbsolute);
			}
			catch (global::System.UriFormatException ex)
			{
				string str = "Invalid target - ";
				global::System.UriFormatException ex2 = ex;
				throw new global::System.ArgumentException(str + ((ex2 != null) ? ex2.ToString() : null));
			}
			return this._relationships.AddRelationship(targetUri, global::NPOI.OpenXml4Net.OPC.TargetMode.External, relationshipType, id);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000042D0 File Offset: 0x000024D0
		public global::NPOI.OpenXml4Net.OPC.PackageRelationship AddRelationship(global::NPOI.OpenXml4Net.OPC.PackagePartName targetPartName, global::NPOI.OpenXml4Net.OPC.TargetMode targetMode, string relationshipType)
		{
			return this.AddRelationship(targetPartName, targetMode, relationshipType, null);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000042DC File Offset: 0x000024DC
		public global::NPOI.OpenXml4Net.OPC.PackageRelationship AddRelationship(global::NPOI.OpenXml4Net.OPC.PackagePartName targetPartName, global::NPOI.OpenXml4Net.OPC.TargetMode targetMode, string relationshipType, string id)
		{
			this._container.ThrowExceptionIfReadOnly();
			if (targetPartName == null)
			{
				throw new global::System.ArgumentException("targetPartName");
			}
			if (relationshipType == null)
			{
				throw new global::System.ArgumentException("relationshipType");
			}
			if (this.IsRelationshipPart || targetPartName.IsRelationshipPartURI())
			{
				throw new global::System.InvalidOperationException("Rule M1.25: The Relationships part shall not have relationships to any other part.");
			}
			if (this._relationships == null)
			{
				this._relationships = new global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection();
			}
			return this._relationships.AddRelationship(targetPartName.URI, targetMode, relationshipType, id);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00004353 File Offset: 0x00002553
		public global::NPOI.OpenXml4Net.OPC.PackageRelationship AddRelationship(global::System.Uri targetURI, global::NPOI.OpenXml4Net.OPC.TargetMode targetMode, string relationshipType)
		{
			return this.AddRelationship(targetURI, targetMode, relationshipType, null);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00004360 File Offset: 0x00002560
		public global::NPOI.OpenXml4Net.OPC.PackageRelationship AddRelationship(global::System.Uri targetURI, global::NPOI.OpenXml4Net.OPC.TargetMode targetMode, string relationshipType, string id)
		{
			this._container.ThrowExceptionIfReadOnly();
			if (targetURI == null)
			{
				throw new global::System.ArgumentException("targetPartName");
			}
			if (relationshipType == null)
			{
				throw new global::System.ArgumentException("relationshipType");
			}
			if (this.IsRelationshipPart || global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.IsRelationshipPartURI(targetURI))
			{
				throw new global::System.InvalidOperationException("Rule M1.25: The Relationships part shall not have relationships to any other part.");
			}
			if (this._relationships == null)
			{
				this._relationships = new global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection();
			}
			return this._relationships.AddRelationship(targetURI, targetMode, relationshipType, id);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000043D8 File Offset: 0x000025D8
		public void ClearRelationships()
		{
			if (this._relationships != null)
			{
				this._relationships.Clear();
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000043ED File Offset: 0x000025ED
		public void RemoveRelationship(string id)
		{
			this._container.ThrowExceptionIfReadOnly();
			if (this._relationships != null)
			{
				this._relationships.RemoveRelationship(id);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600009D RID: 157 RVA: 0x0000440E File Offset: 0x0000260E
		public global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection Relationships
		{
			get
			{
				return this.GetRelationshipsCore(null);
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00004417 File Offset: 0x00002617
		public global::NPOI.OpenXml4Net.OPC.PackageRelationship GetRelationship(string id)
		{
			return this._relationships.GetRelationshipByID(id);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00004425 File Offset: 0x00002625
		public global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection GetRelationshipsByType(string relationshipType)
		{
			this._container.ThrowExceptionIfWriteOnly();
			return this.GetRelationshipsCore(relationshipType);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00004439 File Offset: 0x00002639
		private global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection GetRelationshipsCore(string filter)
		{
			this._container.ThrowExceptionIfWriteOnly();
			if (this._relationships == null)
			{
				this.ThrowExceptionIfRelationship();
				this._relationships = new global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection(this);
			}
			return new global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection(this._relationships, filter);
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x0000446C File Offset: 0x0000266C
		public bool HasRelationships
		{
			get
			{
				return !this.IsRelationshipPart && this._relationships != null && this._relationships.Size > 0;
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00004490 File Offset: 0x00002690
		public bool IsRelationshipExists(global::NPOI.OpenXml4Net.OPC.PackageRelationship rel)
		{
			try
			{
				using (global::System.Collections.Generic.IEnumerator<global::NPOI.OpenXml4Net.OPC.PackageRelationship> enumerator = this.Relationships.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						if (enumerator.Current == rel)
						{
							return true;
						}
					}
				}
			}
			catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException)
			{
			}
			return false;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x000044F0 File Offset: 0x000026F0
		public global::NPOI.OpenXml4Net.OPC.PackagePart GetRelatedPart(global::NPOI.OpenXml4Net.OPC.PackageRelationship rel)
		{
			if (!this.IsRelationshipExists(rel))
			{
				string str = "Relationship ";
				string str2 = (rel != null) ? rel.ToString() : null;
				string str3 = " doesn't start with this part ";
				global::NPOI.OpenXml4Net.OPC.PackagePartName partName = this._partName;
				throw new global::System.ArgumentException(str + str2 + str3 + ((partName != null) ? partName.ToString() : null));
			}
			global::System.Uri uri = rel.TargetUri;
			if (uri.OriginalString.IndexOf('#') >= 0)
			{
				string text = uri.ToString();
				try
				{
					uri = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.ParseUri(text.Substring(0, text.IndexOf('#')), global::System.UriKind.Absolute);
				}
				catch (global::System.UriFormatException)
				{
					throw new global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException("Invalid target URI: " + text);
				}
			}
			global::NPOI.OpenXml4Net.OPC.PackagePartName partName2 = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CreatePartName(uri);
			global::NPOI.OpenXml4Net.OPC.PackagePart part = this._container.GetPart(partName2);
			if (part == null)
			{
				throw new global::System.ArgumentException("No part found for relationship " + ((rel != null) ? rel.ToString() : null));
			}
			return part;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000045C8 File Offset: 0x000027C8
		public global::System.IO.Stream GetStream(global::System.IO.FileMode mode)
		{
			return this.GetStream(mode, global::System.IO.FileAccess.Write);
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x000045D2 File Offset: 0x000027D2
		public global::System.IO.Stream GetStream(global::System.IO.FileMode mode, global::System.IO.FileAccess access)
		{
			if (mode == global::System.IO.FileMode.Create && access == global::System.IO.FileAccess.Write)
			{
				return this.GetOutputStream();
			}
			return this.GetInputStream();
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x000045EC File Offset: 0x000027EC
		public global::System.IO.Stream GetInputStream()
		{
			global::System.IO.Stream inputStreamImpl = this.GetInputStreamImpl();
			if (inputStreamImpl == null)
			{
				throw new global::System.IO.IOException("Can't obtain the input stream from " + this._partName.Name);
			}
			return inputStreamImpl;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00004620 File Offset: 0x00002820
		public global::System.IO.Stream GetOutputStream()
		{
			global::System.IO.Stream outputStreamImpl;
			if (this is global::NPOI.OpenXml4Net.OPC.ZipPackagePart)
			{
				this._container.RemovePart(this._partName);
				global::NPOI.OpenXml4Net.OPC.PackagePart packagePart = this._container.CreatePart(this._partName, this._contentType.ToString(), false);
				if (packagePart == null)
				{
					throw new global::System.InvalidOperationException("Can't create a temporary part !");
				}
				packagePart._relationships = this._relationships;
				outputStreamImpl = packagePart.GetOutputStreamImpl();
			}
			else
			{
				outputStreamImpl = this.GetOutputStreamImpl();
			}
			return outputStreamImpl;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000468D File Offset: 0x0000288D
		private void ThrowExceptionIfRelationship()
		{
			if (this.IsRelationshipPart)
			{
				throw new global::System.InvalidOperationException("Can do this operation on a relationship part !");
			}
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x000046A2 File Offset: 0x000028A2
		private void LoadRelationships()
		{
			if (this._relationships == null && !this.IsRelationshipPart)
			{
				this.ThrowExceptionIfRelationship();
				this._relationships = new global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection(this);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000AA RID: 170 RVA: 0x000046C6 File Offset: 0x000028C6
		public global::NPOI.OpenXml4Net.OPC.PackagePartName PartName
		{
			get
			{
				return this._partName;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000AB RID: 171 RVA: 0x000046CE File Offset: 0x000028CE
		// (set) Token: 0x060000AC RID: 172 RVA: 0x000046DB File Offset: 0x000028DB
		public string ContentType
		{
			get
			{
				return this._contentType.ToString();
			}
			set
			{
				if (this._container == null)
				{
					this._contentType = new global::NPOI.OpenXml4Net.OPC.Internal.ContentType(value);
					return;
				}
				this._container.UnregisterPartAndContentType(this._partName);
				this._contentType = new global::NPOI.OpenXml4Net.OPC.Internal.ContentType(value);
				this._container.RegisterPartAndContentType(this);
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000AD RID: 173 RVA: 0x0000471B File Offset: 0x0000291B
		public global::NPOI.OpenXml4Net.OPC.Internal.ContentType ContentTypeDetails
		{
			get
			{
				return this._contentType;
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00004723 File Offset: 0x00002923
		public global::NPOI.OpenXml4Net.OPC.OPCPackage Package
		{
			get
			{
				return this._container;
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000AF RID: 175 RVA: 0x0000472B File Offset: 0x0000292B
		public bool IsRelationshipPart
		{
			get
			{
				return this._isRelationshipPart;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00004733 File Offset: 0x00002933
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x0000473B File Offset: 0x0000293B
		public bool IsDeleted
		{
			get
			{
				return this._isDeleted;
			}
			set
			{
				this._isDeleted = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00004744 File Offset: 0x00002944
		public virtual long Size
		{
			get
			{
				return -1L;
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00004748 File Offset: 0x00002948
		public override string ToString()
		{
			string str = "Name: ";
			global::NPOI.OpenXml4Net.OPC.PackagePartName partName = this._partName;
			return str + ((partName != null) ? partName.ToString() : null) + " - Content Type: " + this._contentType.ToString();
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00004776 File Offset: 0x00002976
		public int CompareTo(global::NPOI.OpenXml4Net.OPC.PackagePart other)
		{
			if (other == null)
			{
				return -1;
			}
			return global::NPOI.OpenXml4Net.OPC.PackagePartName.Compare(this._partName, other._partName);
		}

		// Token: 0x060000B5 RID: 181
		protected abstract global::System.IO.Stream GetInputStreamImpl();

		// Token: 0x060000B6 RID: 182
		protected abstract global::System.IO.Stream GetOutputStreamImpl();

		// Token: 0x060000B7 RID: 183
		public abstract bool Save(global::System.IO.Stream zos);

		// Token: 0x060000B8 RID: 184
		public abstract bool Load(global::System.IO.Stream ios);

		// Token: 0x060000B9 RID: 185
		public abstract void Close();

		// Token: 0x060000BA RID: 186
		public abstract void Flush();

		// Token: 0x060000BB RID: 187 RVA: 0x0000478E File Offset: 0x0000298E
		public virtual void Clear()
		{
		}

		// Token: 0x04000049 RID: 73
		internal global::NPOI.OpenXml4Net.OPC.OPCPackage _container;

		// Token: 0x0400004A RID: 74
		protected global::NPOI.OpenXml4Net.OPC.PackagePartName _partName;

		// Token: 0x0400004B RID: 75
		internal global::NPOI.OpenXml4Net.OPC.Internal.ContentType _contentType;

		// Token: 0x0400004C RID: 76
		private bool _isRelationshipPart;

		// Token: 0x0400004D RID: 77
		private bool _isDeleted;

		// Token: 0x0400004E RID: 78
		private global::NPOI.OpenXml4Net.OPC.PackageRelationshipCollection _relationships;
	}
}
