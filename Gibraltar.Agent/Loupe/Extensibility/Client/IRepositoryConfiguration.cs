using System;

namespace Loupe.Extensibility.Client
{
	// Token: 0x02000093 RID: 147
	internal interface IRepositoryConfiguration
	{
		// Token: 0x17000343 RID: 835
		// (get) Token: 0x0600068F RID: 1679
		// (set) Token: 0x06000690 RID: 1680
		object Machine { get; set; }

		// Token: 0x17000344 RID: 836
		// (get) Token: 0x06000691 RID: 1681
		// (set) Token: 0x06000692 RID: 1682
		object Common { get; set; }

		// Token: 0x17000345 RID: 837
		// (get) Token: 0x06000693 RID: 1683
		// (set) Token: 0x06000694 RID: 1684
		object Server { get; set; }

		// Token: 0x17000346 RID: 838
		// (get) Token: 0x06000695 RID: 1685
		// (set) Token: 0x06000696 RID: 1686
		object User { get; set; }

		// Token: 0x06000697 RID: 1687
		bool GetServerCredentials(string key, out string account, out string password);

		// Token: 0x06000698 RID: 1688
		bool SetServerCredentials(string key, string account, string password);

		// Token: 0x06000699 RID: 1689
		bool GetMachineCredentials(string key, out string account, out string password);

		// Token: 0x0600069A RID: 1690
		bool SetMachineCredentials(string key, string account, string password);

		// Token: 0x0600069B RID: 1691
		bool GetUserCredentials(string key, out string account, out string password);

		// Token: 0x0600069C RID: 1692
		bool SetUserCredentials(string key, string account, string password);

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x0600069D RID: 1693
		bool ServerCredentialsAvailable { get; }
	}
}
