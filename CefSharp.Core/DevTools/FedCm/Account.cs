using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.FedCm
{
	// Token: 0x0200009C RID: 156
	[global::System.Runtime.Serialization.DataContract]
	public class Account : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000583 RID: 1411 RVA: 0x000085F7 File Offset: 0x000067F7
		// (set) Token: 0x06000584 RID: 1412 RVA: 0x000085FF File Offset: 0x000067FF
		[global::System.Runtime.Serialization.DataMember(Name = "accountId", IsRequired = true)]
		public string AccountId { get; set; }

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000585 RID: 1413 RVA: 0x00008608 File Offset: 0x00006808
		// (set) Token: 0x06000586 RID: 1414 RVA: 0x00008610 File Offset: 0x00006810
		[global::System.Runtime.Serialization.DataMember(Name = "email", IsRequired = true)]
		public string Email { get; set; }

		// Token: 0x17000211 RID: 529
		// (get) Token: 0x06000587 RID: 1415 RVA: 0x00008619 File Offset: 0x00006819
		// (set) Token: 0x06000588 RID: 1416 RVA: 0x00008621 File Offset: 0x00006821
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x06000589 RID: 1417 RVA: 0x0000862A File Offset: 0x0000682A
		// (set) Token: 0x0600058A RID: 1418 RVA: 0x00008632 File Offset: 0x00006832
		[global::System.Runtime.Serialization.DataMember(Name = "givenName", IsRequired = true)]
		public string GivenName { get; set; }

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x0600058B RID: 1419 RVA: 0x0000863B File Offset: 0x0000683B
		// (set) Token: 0x0600058C RID: 1420 RVA: 0x00008643 File Offset: 0x00006843
		[global::System.Runtime.Serialization.DataMember(Name = "pictureUrl", IsRequired = true)]
		public string PictureUrl { get; set; }

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x0600058D RID: 1421 RVA: 0x0000864C File Offset: 0x0000684C
		// (set) Token: 0x0600058E RID: 1422 RVA: 0x00008654 File Offset: 0x00006854
		[global::System.Runtime.Serialization.DataMember(Name = "idpConfigUrl", IsRequired = true)]
		public string IdpConfigUrl { get; set; }

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x0600058F RID: 1423 RVA: 0x0000865D File Offset: 0x0000685D
		// (set) Token: 0x06000590 RID: 1424 RVA: 0x00008665 File Offset: 0x00006865
		[global::System.Runtime.Serialization.DataMember(Name = "idpSigninUrl", IsRequired = true)]
		public string IdpSigninUrl { get; set; }

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000591 RID: 1425 RVA: 0x0000866E File Offset: 0x0000686E
		// (set) Token: 0x06000592 RID: 1426 RVA: 0x0000868A File Offset: 0x0000688A
		public global::CefSharp.DevTools.FedCm.LoginState LoginState
		{
			get
			{
				return (global::CefSharp.DevTools.FedCm.LoginState)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.FedCm.LoginState), this.loginState);
			}
			set
			{
				this.loginState = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000593 RID: 1427 RVA: 0x0000869D File Offset: 0x0000689D
		// (set) Token: 0x06000594 RID: 1428 RVA: 0x000086A5 File Offset: 0x000068A5
		[global::System.Runtime.Serialization.DataMember(Name = "loginState", IsRequired = true)]
		internal string loginState { get; set; }

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000595 RID: 1429 RVA: 0x000086AE File Offset: 0x000068AE
		// (set) Token: 0x06000596 RID: 1430 RVA: 0x000086B6 File Offset: 0x000068B6
		[global::System.Runtime.Serialization.DataMember(Name = "termsOfServiceUrl", IsRequired = false)]
		public string TermsOfServiceUrl { get; set; }

		// Token: 0x17000219 RID: 537
		// (get) Token: 0x06000597 RID: 1431 RVA: 0x000086BF File Offset: 0x000068BF
		// (set) Token: 0x06000598 RID: 1432 RVA: 0x000086C7 File Offset: 0x000068C7
		[global::System.Runtime.Serialization.DataMember(Name = "privacyPolicyUrl", IsRequired = false)]
		public string PrivacyPolicyUrl { get; set; }
	}
}
