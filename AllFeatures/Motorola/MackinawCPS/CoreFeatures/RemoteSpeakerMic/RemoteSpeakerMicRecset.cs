using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic
{
	// Token: 0x020002DA RID: 730
	[global::System.Serializable]
	public class RemoteSpeakerMicRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06007805 RID: 30725 RVA: 0x006D0444 File Offset: 0x006CE644
		public RemoteSpeakerMicRecset()
		{
			int a_ = 4;
			base..ctor(global::AllFeatures.CodeplugGuid.b("蓄꓆꫈껊뻌볎뻐ꇒ곔鯘껚꧜ꯞ軠跢雤", a_));
			this.SetValues();
		}

		// Token: 0x06007806 RID: 30726 RVA: 0x006D0474 File Offset: 0x006CE674
		public RemoteSpeakerMicRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x06007807 RID: 30727 RVA: 0x006D04A0 File Offset: 0x006CE6A0
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1176299661;
			short num2 = num;
			num = (short)579594381;
			switch (num2 == num)
			{
			}
			num = (short)951975936;
			if (num != 0)
			{
			}
			num = (short)870187008;
			short num3 = num;
			num = (short)373227521;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMic(this);
		}

		// Token: 0x06007808 RID: 30728 RVA: 0x006D0550 File Offset: 0x006CE750
		internal void SetValues()
		{
			int a_ = 12;
			short num = (short)808449295;
			short num2 = num;
			num = (short)62321935;
			switch (num2 == num)
			{
			}
			num = (short)356712449;
			if (num != 0)
			{
			}
			num = (short)1681784832;
			short num3 = num;
			num = (short)1261436928;
			if (num != 0)
			{
			}
			base.Id = 2036;
			base.SingleInstance = true;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("賌ꏎ뷐闒냔뛖귘껚꿜뫞鋠\ud8e2ꛤ裦蓨鯪苬臮铰鷲致꯶꯸髺駼雾渀⌂䀄甆済搊挌怎簐稒瘔搖㤘堚爜焞䜠䨢䈤刦嬨䨪夬䘮帰崲椴琶嘸唺䤼䴾⹀⽂㙄ᭆᭈ⹊⁌⁎═㙒畔і⥘㹚㱜㑞Ѡᅢ䕤⩦hࡪㅬ㵮ᑰṲᩴͶᱸ⡺ർ᩾쒈ꆎﮖ", a_);
			base.UIName = global::CommonResources.AcgResources.ID_ACCESSORYBUTTONS;
			base.DataTransferOrder = 21;
		}
	}
}
