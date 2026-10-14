using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Switches
{
	// Token: 0x020002BE RID: 702
	[global::System.Serializable]
	public class SwitchesRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060075E2 RID: 30178 RVA: 0x006A6960 File Offset: 0x006A4B60
		public SwitchesRecset()
		{
			int a_ = 4;
			base..ctor(global::AllFeatures.CodeplugGuid.b("雄냆ꃈ뿊껌꟎듐ꃒ", a_));
			this.SetValues();
		}

		// Token: 0x060075E3 RID: 30179 RVA: 0x006A6990 File Offset: 0x006A4B90
		public SwitchesRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x060075E4 RID: 30180 RVA: 0x006A69BC File Offset: 0x006A4BBC
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)712973149;
			short num2 = num;
			num = (short)1565072221;
			switch (num2 == num)
			{
			}
			num = (short)1592655872;
			short num3 = num;
			num = (short)1059323905;
			if (num != 0)
			{
			}
			num = (short)1657143296;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches(this);
		}

		// Token: 0x060075E5 RID: 30181 RVA: 0x006A6A6C File Offset: 0x006A4C6C
		internal void SetValues()
		{
			int a_ = 16;
			short num = (short)1830788571;
			short num2 = num;
			num = (short)1153342939;
			switch (num2 == num)
			{
			}
			num = (short)1743126528;
			short num3 = num;
			num = (short)2065104897;
			if (num != 0)
			{
			}
			num = (short)1994457088;
			if (num != 0)
			{
			}
			base.Id = 2038;
			base.SingleInstance = true;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("郐뿒맔釖볘뫚꧜꫞鏠蛢雤\udce6ꫨ蓪胬鿮黰鷲郴駶跸ꟺ꿼黾攀樂樄✆䰈礊樌怎缐簒研縖稘栚㴜尞丠䴢䌤並丨帪弬丮䔰娲娴夶攸砺刼儾㕀ㅂ⩄⭆㩈ᝊṌ㡎㡐❒㙔㽖㱘⡚Ŝ౞ᙠ੢ᅤѦŨ๪Ṭ䅮॰ቲᡴ᭶", a_);
			base.UIName = global::CommonResources.AcgResources.ID_SWITCHES;
			base.DataTransferOrder = 24;
		}
	}
}
