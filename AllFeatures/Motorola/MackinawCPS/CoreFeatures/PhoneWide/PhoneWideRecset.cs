using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.PhoneWide
{
	// Token: 0x02000442 RID: 1090
	[global::System.Serializable]
	public class PhoneWideRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06009386 RID: 37766 RVA: 0x008AE30C File Offset: 0x008AC50C
		public PhoneWideRecset()
		{
			int a_ = 13;
			base..ctor(global::AllFeatures.CodeplugGuid.b("黍룏뷑뫓돕跙뗛뫝藟", a_));
			this.SetValues();
		}

		// Token: 0x06009387 RID: 37767 RVA: 0x008AE33C File Offset: 0x008AC53C
		public PhoneWideRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x06009388 RID: 37768 RVA: 0x008AE368 File Offset: 0x008AC568
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)18994844;
			short num2 = num;
			num = (short)1539495580;
			switch (num2 == num)
			{
			default:
			{
				num = (short)909574144;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1745879041;
			if (num != 0)
			{
			}
			num = (short)1387921408;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.PhoneWide.PhoneWide(this);
		}

		// Token: 0x06009389 RID: 37769 RVA: 0x008AE418 File Offset: 0x008AC618
		internal void SetValues()
		{
			int a_ = 0;
			short num = (short)560631838;
			short num2 = num;
			num = (short)850104350;
			switch (num2 == num)
			{
			default:
			{
				num = (short)639500288;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1638072320;
			if (num != 0)
			{
			}
			num = (short)274989057;
			if (num != 0)
			{
			}
			base.Id = 2000;
			base.SingleInstance = true;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("胀꿂꧄臆곈꫊만뫎ꏐ뛒ꛔ高듚냜꿞軠跢胤触鷨럪뷬蟮黰鷲郴ퟶ껸鋺駼髾崀匂洄栆月渊娌明甐瘒㬔漖砘瘚焜", a_);
			base.UIName = global::CommonResources.AcgResources.ID_PHONEWIDE;
			base.DataTransferOrder = 2;
		}
	}
}
