using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000207 RID: 519
	[global::System.Runtime.Serialization.DataContract]
	public class SignedExchangeError : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06000FEE RID: 4078 RVA: 0x00011B0D File Offset: 0x0000FD0D
		// (set) Token: 0x06000FEF RID: 4079 RVA: 0x00011B15 File Offset: 0x0000FD15
		[global::System.Runtime.Serialization.DataMember(Name = "message", IsRequired = true)]
		public string Message { get; set; }

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06000FF0 RID: 4080 RVA: 0x00011B1E File Offset: 0x0000FD1E
		// (set) Token: 0x06000FF1 RID: 4081 RVA: 0x00011B26 File Offset: 0x0000FD26
		[global::System.Runtime.Serialization.DataMember(Name = "signatureIndex", IsRequired = false)]
		public int? SignatureIndex { get; set; }

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06000FF2 RID: 4082 RVA: 0x00011B2F File Offset: 0x0000FD2F
		// (set) Token: 0x06000FF3 RID: 4083 RVA: 0x00011B4B File Offset: 0x0000FD4B
		public global::CefSharp.DevTools.Network.SignedExchangeErrorField? ErrorField
		{
			get
			{
				return (global::CefSharp.DevTools.Network.SignedExchangeErrorField?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.SignedExchangeErrorField?), this.errorField);
			}
			set
			{
				this.errorField = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06000FF4 RID: 4084 RVA: 0x00011B5E File Offset: 0x0000FD5E
		// (set) Token: 0x06000FF5 RID: 4085 RVA: 0x00011B66 File Offset: 0x0000FD66
		[global::System.Runtime.Serialization.DataMember(Name = "errorField", IsRequired = false)]
		internal string errorField { get; set; }
	}
}
