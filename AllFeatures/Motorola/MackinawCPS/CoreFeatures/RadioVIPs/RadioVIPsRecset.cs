using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioVIPs
{
	// Token: 0x020002F0 RID: 752
	[global::System.Serializable]
	public class RadioVIPsRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06007A3C RID: 31292 RVA: 0x006F16C0 File Offset: 0x006EF8C0
		public RadioVIPsRecset()
		{
			int a_ = 11;
			base..ctor(global::AllFeatures.CodeplugGuid.b("黋꿍듏믑믓軗鏙賛귝", a_));
			this.SetValues();
		}

		// Token: 0x06007A3D RID: 31293 RVA: 0x006F16F0 File Offset: 0x006EF8F0
		public RadioVIPsRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x06007A3E RID: 31294 RVA: 0x006F171C File Offset: 0x006EF91C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)2115757104;
			short num2 = num;
			num = (short)913630256;
			switch (num2 == num)
			{
			}
			num = (short)687013889;
			if (num != 0)
			{
			}
			num = (short)1324810240;
			short num3 = num;
			num = (short)48889856;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPs(this);
		}

		// Token: 0x06007A3F RID: 31295 RVA: 0x006F17CC File Offset: 0x006EF9CC
		internal void SetValues()
		{
			int a_ = 10;
			short num = (short)2044960165;
			short num2 = num;
			num = (short)111517093;
			switch (num2 == num)
			{
			}
			num = (short)560136193;
			if (num != 0)
			{
			}
			num = (short)515309568;
			short num3 = num;
			num = (short)1883045888;
			if (num != 0)
			{
			}
			base.Id = 2125;
			base.SingleInstance = true;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("諊ꇌꏎ韐뛒듔ꏖ곘꧚룜곞\udae0ꃢ諤諦駨蓪菬諮鿰蟲꧴ꗶ飸鿺铼郾℀䘂眄怆昈攊戌戎砐瀒昔㜖娘琚猜礞䠠䐢値唦䠨弪䐬䀮弰漲瘴堶圸伺似倾ⵀあ᥄ᕆ⡈⽊⑌⁎煐Ւ᱔ݖ⩘ݚཛྷ㹞ՠ੢੤ㅦ⁨㭪Ṭ䅮॰ቲᡴ᭶", a_);
			base.UIName = global::CommonResources.AcgResources.ID_RADIOVIPS;
			base.DataTransferOrder = 15;
		}
	}
}
