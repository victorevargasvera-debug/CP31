using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.NonGUIFeature
{
	// Token: 0x02000445 RID: 1093
	[global::System.Serializable]
	public class NonGUIFeatureRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600938E RID: 37774 RVA: 0x008AE7D4 File Offset: 0x008AC9D4
		public NonGUIFeatureRecset()
		{
			int a_ = 4;
			base..ctor(global::AllFeatures.CodeplugGuid.b("评꣆ꟈ諌髎飐鏔닖룘꿚꣜귞蓠", a_));
			this.SetValues();
		}

		// Token: 0x0600938F RID: 37775 RVA: 0x008AE804 File Offset: 0x008ACA04
		public NonGUIFeatureRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x06009390 RID: 37776 RVA: 0x008AE830 File Offset: 0x008ACA30
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1926529628;
			short num2 = num;
			num = (short)468353628;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1611792384;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1608056833;
			if (num != 0)
			{
			}
			num = (short)278200320;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.NonGUIFeature.NonGUIFeature(this);
		}

		// Token: 0x06009391 RID: 37777 RVA: 0x008AE8E0 File Offset: 0x008ACAE0
		internal void SetValues()
		{
			int a_ = 10;
			short num = (short)863505239;
			short num2 = num;
			num = (short)1065618263;
			switch (num2 == num)
			{
			default:
			{
				num = (short)522977280;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)351666177;
			if (num != 0)
			{
			}
			num = (short)1215954944;
			if (num != 0)
			{
			}
			base.Id = 0;
			base.SingleInstance = true;
			base.UIPagePath = "";
			base.UIName = global::AllFeatures.CodeplugGuid.b("藊ꋌꇎﳐ铒胔黖律鷚룜뻞闠離韤苦", a_);
			base.DataTransferOrder = 999;
			base.HiddenStatic = true;
		}
	}
}
