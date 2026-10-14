using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Preload
{
	// Token: 0x0200009F RID: 159
	[global::System.Runtime.Serialization.DataContract]
	public class RuleSet : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700021E RID: 542
		// (get) Token: 0x060005AB RID: 1451 RVA: 0x00008874 File Offset: 0x00006A74
		// (set) Token: 0x060005AC RID: 1452 RVA: 0x0000887C File Offset: 0x00006A7C
		[global::System.Runtime.Serialization.DataMember(Name = "id", IsRequired = true)]
		public string Id { get; set; }

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x060005AD RID: 1453 RVA: 0x00008885 File Offset: 0x00006A85
		// (set) Token: 0x060005AE RID: 1454 RVA: 0x0000888D File Offset: 0x00006A8D
		[global::System.Runtime.Serialization.DataMember(Name = "loaderId", IsRequired = true)]
		public string LoaderId { get; set; }

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x060005AF RID: 1455 RVA: 0x00008896 File Offset: 0x00006A96
		// (set) Token: 0x060005B0 RID: 1456 RVA: 0x0000889E File Offset: 0x00006A9E
		[global::System.Runtime.Serialization.DataMember(Name = "sourceText", IsRequired = true)]
		public string SourceText { get; set; }

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x060005B1 RID: 1457 RVA: 0x000088A7 File Offset: 0x00006AA7
		// (set) Token: 0x060005B2 RID: 1458 RVA: 0x000088C3 File Offset: 0x00006AC3
		public global::CefSharp.DevTools.Preload.RuleSetErrorType? ErrorType
		{
			get
			{
				return (global::CefSharp.DevTools.Preload.RuleSetErrorType?)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.Preload.RuleSetErrorType?), this.errorType);
			}
			set
			{
				this.errorType = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x060005B3 RID: 1459 RVA: 0x000088D6 File Offset: 0x00006AD6
		// (set) Token: 0x060005B4 RID: 1460 RVA: 0x000088DE File Offset: 0x00006ADE
		[global::System.Runtime.Serialization.DataMember(Name = "errorType", IsRequired = false)]
		internal string errorType { get; set; }

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x060005B5 RID: 1461 RVA: 0x000088E7 File Offset: 0x00006AE7
		// (set) Token: 0x060005B6 RID: 1462 RVA: 0x000088EF File Offset: 0x00006AEF
		[global::System.Runtime.Serialization.DataMember(Name = "errorMessage", IsRequired = false)]
		public string ErrorMessage { get; set; }
	}
}
