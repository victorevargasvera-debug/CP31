using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.VoiceAnnouncements.Wide
{
	// Token: 0x0200001B RID: 27
	[global::System.Serializable]
	public sealed class VoiceAnnouncementWideRecSet : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06000525 RID: 1317 RVA: 0x00002669 File Offset: 0x00000869
		public VoiceAnnouncementWideRecSet() : base(global::CommonResources.AppResources.Voice_Announcement_Wide)
		{
			this.SetValues();
		}

		// Token: 0x06000526 RID: 1318 RVA: 0x000496B8 File Offset: 0x000478B8
		internal VoiceAnnouncementWideRecSet(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 19;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﾕﲙ", a_));
			}
			this.SetValues();
		}

		// Token: 0x06000527 RID: 1319 RVA: 0x000496F8 File Offset: 0x000478F8
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1091502080;
			short num2 = num;
			num = (short)147037111;
			short num3 = num;
			num = (short)1846123447;
			switch (num3 == num)
			{
			}
			num = (short)1618608129;
			if (num != 0)
			{
			}
			num = (short)1172307968;
			if (num != 0)
			{
			}
			return new global::SpecialFeatures.VoiceAnnouncements.Wide.VoiceAnnouncementWide(this);
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x000497A8 File Offset: 0x000479A8
		internal void SetValues()
		{
			int a_ = 6;
			short num = (short)1859977216;
			short num2 = num;
			num = (short)1528404061;
			short num3 = num;
			num = (short)1895602269;
			switch (num3 == num)
			{
			}
			num = (short)773455873;
			if (num != 0)
			{
			}
			num = (short)949747712;
			if (num != 0)
			{
			}
			base.Id = 2301;
			base.SingleInstance = true;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda88ﮊ璉톖ﲘ漢펠욢횤鲦쒪사\udfae\udeb0\uddb2킴\ud9b6춸킾ꣀꃂꃄ蛆ꟈꗊꋌ뫎뿐냒냔뫖볘뗚꧜곞뷠뗢諤軦諨軪곬臮鿰鳲胴駶髸黺郼髾漀眂刄渆洈渊儌夎縐稒瘔爖堘甚猜瀞吠䴢䘤䈦䐨个䌬嬮昰娲儴制᜸䌺尼刾ⵀ", a_);
			base.UIName = global::CommonResources.AppResources.Voice_Announcement_Wide;
			base.DataTransferOrder = 49;
		}
	}
}
