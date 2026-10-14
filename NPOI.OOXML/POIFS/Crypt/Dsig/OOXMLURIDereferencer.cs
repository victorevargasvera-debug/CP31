using System;
using System.IO;
using System.Security.Cryptography.Xml;
using NPOI.OpenXml4Net.Exceptions;
using NPOI.OpenXml4Net.OPC;

namespace NPOI.POIFS.Crypt.Dsig
{
	// Token: 0x020000F8 RID: 248
	public class OOXMLURIDereferencer : global::NPOI.POIFS.Crypt.Dsig.IURIDereferencer, global::NPOI.POIFS.Crypt.Dsig.ISignatureConfigurable
	{
		// Token: 0x06000EFF RID: 3839 RVA: 0x0003587F File Offset: 0x00033A7F
		public void SetSignatureConfig(global::NPOI.POIFS.Crypt.Dsig.SignatureConfig signatureConfig)
		{
			this.signatureConfig = signatureConfig;
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x00035888 File Offset: 0x00033A88
		public global::NPOI.POIFS.Crypt.Dsig.IData dereference(global::NPOI.POIFS.Crypt.Dsig.IURIReference uriReference, global::System.Security.Cryptography.Xml.SignedXml context)
		{
			if (this.baseUriDereferencer == null)
			{
				throw new global::System.NotImplementedException();
			}
			if (uriReference == null)
			{
				throw new global::System.NullReferenceException("URIReference cannot be null");
			}
			if (context == null)
			{
				throw new global::System.NullReferenceException("XMLCrytoContext cannot be null");
			}
			global::System.Uri uri;
			try
			{
				uri = new global::System.Uri(uriReference.getURI());
			}
			catch (global::System.UriFormatException innerException)
			{
				throw new global::System.Exception("could not URL decode the uri: " + uriReference.getURI(), innerException);
			}
			global::NPOI.OpenXml4Net.OPC.PackagePart packagePart = this.FindPart(uri);
			if (packagePart == null)
			{
				throw new global::System.NotImplementedException();
			}
			try
			{
				packagePart.GetInputStream();
				if (packagePart.PartName.ToString().EndsWith(".rels"))
				{
					new global::System.IO.MemoryStream(new global::System.IO.MemoryStream().ToArray());
					throw new global::System.NotImplementedException();
				}
			}
			catch (global::System.IO.IOException)
			{
				throw new global::System.NotImplementedException();
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x00035958 File Offset: 0x00033B58
		private global::NPOI.OpenXml4Net.OPC.PackagePart FindPart(global::System.Uri uri)
		{
			string absolutePath = uri.AbsolutePath;
			if (absolutePath == null || "".Equals(absolutePath))
			{
				return null;
			}
			global::NPOI.OpenXml4Net.OPC.PackagePartName partName;
			try
			{
				partName = global::NPOI.OpenXml4Net.OPC.PackagingUriHelper.CreatePartName(absolutePath);
			}
			catch (global::NPOI.OpenXml4Net.Exceptions.InvalidFormatException)
			{
				return null;
			}
			return this.signatureConfig.GetOpcPackage().GetPart(partName);
		}

		// Token: 0x0400047A RID: 1146
		private global::NPOI.POIFS.Crypt.Dsig.SignatureConfig signatureConfig;

		// Token: 0x0400047B RID: 1147
		private global::NPOI.POIFS.Crypt.Dsig.IURIDereferencer baseUriDereferencer;
	}
}
