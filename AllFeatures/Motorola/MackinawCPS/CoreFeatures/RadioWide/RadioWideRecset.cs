using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x0200017D RID: 381
	[global::System.Serializable]
	public class RadioWideRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06003E08 RID: 15880 RVA: 0x003A9FE0 File Offset: 0x003A81E0
		public RadioWideRecset()
		{
			int a_ = 2;
			base..ctor(global::AllFeatures.CodeplugGuid.b("釂꓄ꏆꃈ꓊风룐럒냔", a_));
			this.SetValues();
		}

		// Token: 0x06003E09 RID: 15881 RVA: 0x003AA010 File Offset: 0x003A8210
		public RadioWideRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x06003E0A RID: 15882 RVA: 0x003AA03C File Offset: 0x003A823C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)703159241;
			short num2 = num;
			num = (short)629365705;
			switch (num2 == num)
			{
			default:
			{
				num = (short)584253440;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)85393409;
			if (num != 0)
			{
			}
			num = (short)884277248;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide(this);
		}

		// Token: 0x06003E0B RID: 15883 RVA: 0x003AA0EC File Offset: 0x003A82EC
		internal void SetValues()
		{
			int a_ = 1;
			short num = (short)1505060869;
			short num2 = num;
			num = (short)1829070853;
			switch (num2 == num)
			{
			default:
			{
				num = (short)838074368;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2008678400;
			if (num != 0)
			{
			}
			num = (short)2072051713;
			if (num != 0)
			{
			}
			base.Id = 2045;
			base.SingleInstance = true;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("菁ꣃ꫅軇꿉귋뫍ꗏꃑ뇓ꗕ駙돛돝郟跡諣菥蛧黩냫볭釯雱鷳駵\ud8f7극闻髽旿币嘃朅氇按挋复礏瘑焓㠕怗笙焛爝", a_);
			base.UIName = global::CommonResources.AcgResources.ID_RADIOWIDE;
			base.DataTransferOrder = 7;
		}
	}
}
