using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.Keypad
{
	// Token: 0x02000305 RID: 773
	[global::System.Serializable]
	public class KeypadRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06007B34 RID: 31540 RVA: 0x007045AC File Offset: 0x007027AC
		public KeypadRecset()
		{
			int a_ = 5;
			base..ctor(global::AllFeatures.CodeplugGuid.b("跅귇돉볋꿍듏", a_));
			this.SetValues();
		}

		// Token: 0x06007B35 RID: 31541 RVA: 0x007045DC File Offset: 0x007027DC
		public KeypadRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x06007B36 RID: 31542 RVA: 0x00704608 File Offset: 0x00702808
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)819855361;
			if (num != 0)
			{
			}
			num = (short)1347979821;
			short num2 = num;
			num = (short)839682605;
			switch (num2 == num)
			{
			default:
			{
				num = (short)999292928;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)97320960;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.Keypad.Keypad(this);
		}

		// Token: 0x06007B37 RID: 31543 RVA: 0x007046B4 File Offset: 0x007028B4
		internal void SetValues()
		{
			int a_ = 9;
			short num = (short)1174847423;
			short num2 = num;
			num = (short)721207231;
			switch (num2 == num)
			{
			}
			num = (short)1820721152;
			short num3 = num;
			num = (short)1402077184;
			if (num != 0)
			{
			}
			num = (short)347078657;
			if (num != 0)
			{
			}
			base.Id = 4109;
			base.SingleInstance = true;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("诉ꃋꋍ雏럑뗓ꋕ귗꣙맛귝\udbdfꇡ诣该飧藩苫语黯蛱ꣳꓵ駷黹闻釽⃿䜁瘃愅朇搉挋挍礏焑朓㘕嬗甙爛砝䤟䔡儣吥䤧帩䔫䄭帯渱眳夵嘷丹主儽ⰿㅁᡃ൅ⵇ㍉㱋⽍㑏๑ὓ㍕⅗⩙㵛㩝也ᩡգ୥ѧ", a_);
			base.UIName = global::CommonResources.AcgResources.ID_KEYPAD;
			base.DataTransferOrder = 56;
		}
	}
}
