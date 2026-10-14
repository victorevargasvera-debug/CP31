using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Serialization;

namespace Gibraltar.Server.Client
{
	// Token: 0x02000133 RID: 307
	internal abstract class WebChannelRequestBase : global::Gibraltar.Server.Client.IWebRequest
	{
		// Token: 0x14000038 RID: 56
		// (add) Token: 0x06000C8A RID: 3210 RVA: 0x00021888 File Offset: 0x0001FA88
		// (remove) Token: 0x06000C8B RID: 3211 RVA: 0x000218C4 File Offset: 0x0001FAC4
		public event global::Gibraltar.Server.Client.WebRequestEventHandler Canceled;

		// Token: 0x14000039 RID: 57
		// (add) Token: 0x06000C8C RID: 3212 RVA: 0x00021900 File Offset: 0x0001FB00
		// (remove) Token: 0x06000C8D RID: 3213 RVA: 0x0002193C File Offset: 0x0001FB3C
		public event global::Gibraltar.Server.Client.WebRequestEventHandler Complete;

		// Token: 0x06000C8E RID: 3214 RVA: 0x00021978 File Offset: 0x0001FB78
		protected WebChannelRequestBase(bool supportsAuthentication, bool requiresAuthentication)
		{
			this.m_SupportsAuthentication = supportsAuthentication;
			this.m_RequiresAuthentication = requiresAuthentication;
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06000C8F RID: 3215 RVA: 0x0002199C File Offset: 0x0001FB9C
		public bool RequiresAuthentication
		{
			get
			{
				return this.m_RequiresAuthentication;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06000C90 RID: 3216 RVA: 0x000219A4 File Offset: 0x0001FBA4
		public bool SupportsAuthentication
		{
			get
			{
				return this.m_SupportsAuthentication;
			}
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x000219AC File Offset: 0x0001FBAC
		public void ProcessRequest(global::Gibraltar.Server.Client.IWebChannelConnection connection)
		{
			this.OnProcessRequest(connection);
			this.OnComplete();
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x000219BC File Offset: 0x0001FBBC
		public void Cancel()
		{
			object statusLock = this.m_StatusLock;
			lock (statusLock)
			{
				if (!this.m_Canceled)
				{
					this.m_Canceled = true;
					this.OnCancel();
				}
				global::System.Threading.Monitor.PulseAll(this.m_StatusLock);
			}
		}

		// Token: 0x06000C93 RID: 3219
		protected abstract void OnProcessRequest(global::Gibraltar.Server.Client.IWebChannelConnection connection);

		// Token: 0x06000C94 RID: 3220 RVA: 0x00021A18 File Offset: 0x0001FC18
		protected virtual void OnCancel()
		{
			global::Gibraltar.Server.Client.WebRequestEventHandler canceled = this.Canceled;
			if (canceled != null)
			{
				canceled(this, new global::System.EventArgs());
			}
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x00021A44 File Offset: 0x0001FC44
		protected virtual void OnComplete()
		{
			global::Gibraltar.Server.Client.WebRequestEventHandler complete = this.Complete;
			if (complete != null)
			{
				complete(this, new global::System.EventArgs());
			}
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x00021A70 File Offset: 0x0001FC70
		protected static byte[] ConvertXmlToByteArray<T>(T xmlFragment)
		{
			byte[] result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(2048))
			{
				using (global::System.IO.TextWriter textWriter = new global::System.IO.StreamWriter(memoryStream, global::System.Text.Encoding.UTF8))
				{
					global::System.Xml.XmlTextWriter xmlTextWriter = new global::System.Xml.XmlTextWriter(textWriter);
					global::System.Xml.Serialization.XmlSerializer xmlSerializer = new global::System.Xml.Serialization.XmlSerializer(typeof(T));
					global::System.Xml.Serialization.XmlSerializerNamespaces namespaces = new global::System.Xml.Serialization.XmlSerializerNamespaces();
					xmlSerializer.Serialize(xmlTextWriter, xmlFragment, namespaces);
					xmlTextWriter.Flush();
				}
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x040003BD RID: 957
		public const string GZipContentType = "application/gzip";

		// Token: 0x040003BE RID: 958
		public const string BinaryContentType = "application/octet-stream";

		// Token: 0x040003BF RID: 959
		public const string ZipContentType = "application/zipfile";

		// Token: 0x040003C0 RID: 960
		protected const string XmlContentType = "text/xml";

		// Token: 0x040003C1 RID: 961
		private readonly object m_StatusLock = new object();

		// Token: 0x040003C2 RID: 962
		private readonly bool m_SupportsAuthentication;

		// Token: 0x040003C3 RID: 963
		private readonly bool m_RequiresAuthentication;

		// Token: 0x040003C4 RID: 964
		private bool m_Canceled;
	}
}
