using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.SmartKeyFob
{
	// Token: 0x020002D0 RID: 720
	[global::System.Serializable]
	public class SmartKeyFobRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060077DD RID: 30685 RVA: 0x006C5C08 File Offset: 0x006C3E08
		public SmartKeyFobRecset()
		{
			int a_ = 13;
			base..ctor(global::AllFeatures.CodeplugGuid.b("鷍뷏돑ꛓꋕ釙맛꟝샟ꓡ诣蓥죧꣩駫髭蓯鷱髳藵", a_));
			this.SetValues();
		}

		// Token: 0x060077DE RID: 30686 RVA: 0x006C5C38 File Offset: 0x006C3E38
		public SmartKeyFobRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x060077DF RID: 30687 RVA: 0x006C5C64 File Offset: 0x006C3E64
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1498087424;
			short num2 = num;
			num = (short)1530047112;
			short num3 = num;
			num = (short)726051464;
			switch (num3 == num)
			{
			}
			num = (short)870842369;
			if (num != 0)
			{
			}
			num = (short)1752236032;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFob(this);
		}

		// Token: 0x060077E0 RID: 30688 RVA: 0x006C5D10 File Offset: 0x006C3F10
		internal void SetValues()
		{
			int a_ = 5;
			short num = (short)180355072;
			short num2 = num;
			num = (short)864813039;
			short num3 = num;
			num = (short)1027997679;
			switch (num3 == num)
			{
			}
			num = (short)232456193;
			if (num != 0)
			{
			}
			num = (short)541720576;
			if (num != 0)
			{
			}
			base.Id = 4130;
			base.SingleInstance = true;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("蟅꓇ꛉ請ꯍ뇏ꛑꇓꓕ뷗꧙鷝迟迡铣觥蛧迩苫髭곯ꃱ闳鋵釷闹\udcfb믽狿攁欃栅朇有攋洍挏㈑圓礕瘗簙甛礝唟倡䔣別䄧䔩䈫爭猯崱娳䈵䨷唹倻䴽᰿ᅁ⥃❅㩇㹉汋Ս㕏⭑瑓ၕ㝗㡙[൝ൟ͡ᙣብ⍧ཀྵᕫ⡭Ὧၱ婳๵᥷᝹ၻ", a_);
			base.UIName = global::CommonResources.AcgResources.ID_SMARTKEYFOBBUTTONS;
			base.DataTransferOrder = 120;
		}
	}
}
