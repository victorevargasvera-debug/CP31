using System;
using System.Xml;

namespace NPOI.POIFS.Crypt.Dsig
{
	// Token: 0x02000102 RID: 258
	public class SignatureMarshalListener : global::NPOI.POIFS.Crypt.Dsig.IEventListener, global::NPOI.POIFS.Crypt.Dsig.ISignatureConfigurable
	{
		// Token: 0x06000F5D RID: 3933 RVA: 0x000065E4 File Offset: 0x000047E4
		public void handleEvent(global::NPOI.POIFS.Crypt.Dsig.IEvent e)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x000065E4 File Offset: 0x000047E4
		public void handleElement(global::System.Xml.XmlElement el)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x00036318 File Offset: 0x00034518
		protected void SetPrefix(global::System.Xml.XmlNode el)
		{
			string text = this.signatureConfig.GetNamespacePrefixes()[el.NamespaceURI];
			if (text != null && el.Prefix == null)
			{
				el.Prefix = text;
			}
			global::System.Xml.XmlNodeList childNodes = el.ChildNodes;
			for (int i = 0; i < childNodes.Count; i++)
			{
				this.SetPrefix(childNodes.Item(i));
			}
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x00036373 File Offset: 0x00034573
		public void SetSignatureConfig(global::NPOI.POIFS.Crypt.Dsig.SignatureConfig signatureConfig)
		{
			this.signatureConfig = signatureConfig;
		}

		// Token: 0x040004BC RID: 1212
		private global::NPOI.POIFS.Crypt.Dsig.SignatureConfig signatureConfig;
	}
}
