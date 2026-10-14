using System;

namespace Loupe.Extensibility.Data
{
	// Token: 0x02000090 RID: 144
	internal interface IUserProfile
	{
		// Token: 0x17000333 RID: 819
		// (get) Token: 0x0600067A RID: 1658
		global::System.Guid Id { get; }

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x0600067B RID: 1659
		string UserName { get; }

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x0600067C RID: 1660
		string UserCaption { get; }

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x0600067D RID: 1661
		string EmailAddress { get; }

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x0600067E RID: 1662
		bool UseHtmlEmail { get; }

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x0600067F RID: 1663
		bool Deleted { get; }

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06000680 RID: 1664
		int PasswordFailures { get; }

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06000681 RID: 1665
		bool IsLockedOut { get; }

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06000682 RID: 1666
		bool IsApproved { get; }

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06000683 RID: 1667
		string TimeZoneCode { get; }

		// Token: 0x1700033D RID: 829
		// (get) Token: 0x06000684 RID: 1668
		global::System.DateTimeOffset LastAccessTimestamp { get; }

		// Token: 0x1700033E RID: 830
		// (get) Token: 0x06000685 RID: 1669
		global::System.DateTimeOffset CreatedTimestamp { get; }

		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000686 RID: 1670
		global::System.DateTimeOffset? LastLockedOutTimestamp { get; }

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000687 RID: 1671
		global::System.DateTimeOffset? LastPasswordChangeTimestamp { get; }

		// Token: 0x17000341 RID: 833
		// (get) Token: 0x06000688 RID: 1672
		global::System.DateTimeOffset? LastPasswordFailureTimestamp { get; }

		// Token: 0x17000342 RID: 834
		// (get) Token: 0x06000689 RID: 1673
		global::Loupe.Extensibility.Data.UserType Type { get; }
	}
}
