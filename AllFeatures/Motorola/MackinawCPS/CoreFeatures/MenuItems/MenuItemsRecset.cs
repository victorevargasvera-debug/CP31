using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.MenuItems
{
	// Token: 0x020002FA RID: 762
	[global::System.Serializable]
	public class MenuItemsRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06007AA9 RID: 31401 RVA: 0x006FA988 File Offset: 0x006F8B88
		public MenuItemsRecset()
		{
			int a_ = 8;
			base..ctor(global::AllFeatures.CodeplugGuid.b("蓈껊ꏌ뫎髒ꇔ닖듘꣚", a_));
			this.SetValues();
		}

		// Token: 0x06007AAA RID: 31402 RVA: 0x006FA9B8 File Offset: 0x006F8BB8
		public MenuItemsRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x06007AAB RID: 31403 RVA: 0x006FA9E4 File Offset: 0x006F8BE4
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1920868767;
			short num2 = num;
			num = (short)786899359;
			switch (num2 == num)
			{
			}
			num = (short)548077569;
			if (num != 0)
			{
			}
			num = (short)1440940032;
			if (num != 0)
			{
			}
			num = (short)992083968;
			short num3 = num;
			return new global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems(this);
		}

		// Token: 0x06007AAC RID: 31404 RVA: 0x006FAA94 File Offset: 0x006F8C94
		internal void SetValues()
		{
			int a_ = 8;
			short num = (short)70681758;
			short num2 = num;
			num = (short)1144816798;
			switch (num2 == num)
			{
			}
			num = (short)355074049;
			if (num != 0)
			{
			}
			num = (short)1549139968;
			if (num != 0)
			{
			}
			num = (short)916258816;
			short num3 = num;
			base.Id = 2088;
			base.SingleInstance = true;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("裈ꟊꇌ觎듐닒ꇔꋖꯘ뻚껜ꋠ賢裤韦蛨藪裬臮藰꿲ꟴ零鷸鋺鋼\udffe䐀焂戄栆月搊怌明爐怒㔔吖瘘甚笜瘞䘠嘢圤䘦崨䈪䈬䄮洰瀲娴夶䴸䤺刼匾㉀ὂࡄ≆❈㹊浌َ═㙒㡔⑖՘ᙚ㡜ㅞᑠ⩢ᅤɦѨᡪ䍬ᝮၰṲᥴ", a_);
			base.UIName = global::CommonResources.AcgResources.ID_MENUITEMS;
			base.DataTransferOrder = 6;
		}
	}
}
