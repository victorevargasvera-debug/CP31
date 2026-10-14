using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Gibraltar.Server.Client.Data;

namespace Gibraltar.Server.Client
{
	// Token: 0x0200011B RID: 283
	internal class ClientRepositoryUploadRequest : global::Gibraltar.Server.Client.WebChannelRequestBase
	{
		// Token: 0x06000BA6 RID: 2982 RVA: 0x0001DAA0 File Offset: 0x0001BCA0
		public ClientRepositoryUploadRequest(global::Gibraltar.Server.Client.Data.ClientRepositoryXml repositoryXml) : base(true, true)
		{
			this.InputRepository = repositoryXml;
		}

		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06000BA7 RID: 2983 RVA: 0x0001DAB4 File Offset: 0x0001BCB4
		// (set) Token: 0x06000BA8 RID: 2984 RVA: 0x0001DABC File Offset: 0x0001BCBC
		public global::Gibraltar.Server.Client.Data.ClientRepositoryXml InputRepository { get; private set; }

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06000BA9 RID: 2985 RVA: 0x0001DAC8 File Offset: 0x0001BCC8
		// (set) Token: 0x06000BAA RID: 2986 RVA: 0x0001DAD0 File Offset: 0x0001BCD0
		public global::Gibraltar.Server.Client.Data.ClientRepositoryXml ResponseRepository { get; private set; }

		// Token: 0x06000BAB RID: 2987 RVA: 0x0001DADC File Offset: 0x0001BCDC
		protected override void OnProcessRequest(global::Gibraltar.Server.Client.IWebChannelConnection connection)
		{
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(connection.UploadData(this.GenerateResourceUri(), "PUT", "text/xml", global::Gibraltar.Server.Client.WebChannelRequestBase.ConvertXmlToByteArray<global::Gibraltar.Server.Client.Data.ClientRepositoryXml>(this.InputRepository), null, new int?(-1))))
			{
				new global::System.Xml.Serialization.XmlSerializerNamespaces().Add("", "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd");
				global::System.Xml.XmlTextReader xmlReader = new global::System.Xml.XmlTextReader(memoryStream);
				global::Gibraltar.Server.Client.Data.ClientRepositoryXml responseRepository = (global::Gibraltar.Server.Client.Data.ClientRepositoryXml)new global::System.Xml.Serialization.XmlSerializer(typeof(global::Gibraltar.Server.Client.Data.ClientRepositoryXml), "http://www.gibraltarsoftware.com/Gibraltar/Repository.xsd").Deserialize(xmlReader);
				this.ResponseRepository = responseRepository;
			}
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x0001DB7C File Offset: 0x0001BD7C
		private string GenerateResourceUri()
		{
			global::System.Guid guid = new global::System.Guid(this.InputRepository.id);
			return string.Format("/Repositories/{0}/Repository.xml", guid);
		}
	}
}
