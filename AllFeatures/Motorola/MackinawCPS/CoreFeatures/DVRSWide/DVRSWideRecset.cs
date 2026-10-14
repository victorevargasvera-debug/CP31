using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DVRSWide
{
	// Token: 0x020004AE RID: 1198
	[global::System.Serializable]
	public class DVRSWideRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06009DAF RID: 40367 RVA: 0x00935180 File Offset: 0x00933380
		public DVRSWideRecset()
		{
			int a_ = 2;
			base..ctor(global::AllFeatures.CodeplugGuid.b("蟂鏄闆髈髌ꛎ뗐뛒", a_));
			this.SetValues();
		}

		// Token: 0x06009DB0 RID: 40368 RVA: 0x009351B0 File Offset: 0x009333B0
		public DVRSWideRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x06009DB1 RID: 40369 RVA: 0x009351DC File Offset: 0x009333DC
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1521121312;
			short num2 = num;
			num = (short)343570464;
			switch (num2 == num)
			{
			}
			num = (short)1857028096;
			if (num != 0)
			{
			}
			num = (short)1967456256;
			short num3 = num;
			num = (short)60489729;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide(this);
		}

		// Token: 0x06009DB2 RID: 40370 RVA: 0x0093528C File Offset: 0x0093348C
		internal void SetValues()
		{
			int a_ = 4;
			short num = (short)1301523124;
			short num2 = num;
			num = (short)1774430900;
			switch (num2 == num)
			{
			}
			num = (short)1459945473;
			if (num != 0)
			{
			}
			num = (short)1727397888;
			short num3 = num;
			num = (short)352976896;
			if (num != 0)
			{
			}
			base.Id = 4142;
			base.SingleInstance = true;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("蓄ꯆꗈ跊꣌껎ꗐꛒ꟔닖꫘黜냞賠鏢諤触賨藪駬돮뗰ꗲꟴꓶ\ud9f8룺鋼釾最樂戄爆笈樊礌明縐紒䤔化优䤚东㼞瘠䨢䄤䈦用漪第紮戰搲尴匶尸ᔺ䔼帾ⱀ⽂", a_);
			base.UIName = global::CommonResources.AcgResources.ID_DVRSWIDE;
			base.DataTransferOrder = 48;
		}
	}
}
