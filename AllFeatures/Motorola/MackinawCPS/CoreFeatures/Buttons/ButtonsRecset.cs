using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Buttons
{
	// Token: 0x020003FF RID: 1023
	[global::System.Serializable]
	public class ButtonsRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06008DCF RID: 36303 RVA: 0x0085018C File Offset: 0x0084E38C
		public ButtonsRecset()
		{
			int a_ = 16;
			base..ctor(global::AllFeatures.CodeplugGuid.b("鏐ꛒꇔꏖ뛘뗚껜", a_));
			this.SetValues();
		}

		// Token: 0x06008DD0 RID: 36304 RVA: 0x008501BC File Offset: 0x0084E3BC
		public ButtonsRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x06008DD1 RID: 36305 RVA: 0x008501E8 File Offset: 0x0084E3E8
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)145294210;
			short num2 = num;
			num = (short)533726082;
			switch (num2 == num)
			{
			default:
			{
				num = (short)793772032;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1222311937;
			if (num != 0)
			{
			}
			num = (short)2036072448;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.Buttons.Buttons(this);
		}

		// Token: 0x06008DD2 RID: 36306 RVA: 0x00850294 File Offset: 0x0084E494
		internal void SetValues()
		{
			int a_ = 4;
			short num = (short)1508665297;
			short num2 = num;
			num = (short)431318993;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2042757120;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1211105281;
			if (num != 0)
			{
			}
			num = (short)1796079616;
			if (num != 0)
			{
			}
			base.Id = 2042;
			base.SingleInstance = true;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("蓄ꯆꗈ跊꣌껎ꗐꛒ꟔닖꫘黜냞賠鏢諤触賨藪駬돮ꏰ鋲釴黶雸\udbfa룼跾昀氂欄栆搈戊渌簎ㄐ倒稔礖缘爚稜樞匠䈢儤並䘨䔪焬氮帰崲䄴䔶嘸场丼挾̀㙂ㅄ㍆♈╊㹌ፎፐ♒⅔⍖㙘㕚⹜煞ᥠɢࡤ୦", a_);
			base.UIName = global::CommonResources.AcgResources.ID_BUTTONS;
			base.DataTransferOrder = 23;
		}
	}
}
