using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.RadioInformation
{
	// Token: 0x020001AF RID: 431
	[global::System.Serializable]
	public class RadioInformationRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060050C3 RID: 20675 RVA: 0x004989F0 File Offset: 0x00496BF0
		public RadioInformationRecset()
		{
			int a_ = 11;
			base..ctor(global::AllFeatures.CodeplugGuid.b("黋꿍듏믑믓釗듙뫛뇝鋟迡藣鋥臧藩苫", a_));
			this.SetValues();
		}

		// Token: 0x060050C4 RID: 20676 RVA: 0x00498A20 File Offset: 0x00496C20
		public RadioInformationRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x060050C5 RID: 20677 RVA: 0x00498A4C File Offset: 0x00496C4C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1346772580;
			short num2 = num;
			num = (short)1719017060;
			switch (num2 == num)
			{
			}
			num = (short)881459200;
			short num3 = num;
			num = (short)173473792;
			if (num != 0)
			{
			}
			num = (short)1835597825;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation(this);
		}

		// Token: 0x060050C6 RID: 20678 RVA: 0x00498AFC File Offset: 0x00496CFC
		internal void SetValues()
		{
			int a_ = 1;
			short num = (short)989272932;
			short num2 = num;
			num = (short)571677540;
			switch (num2 == num)
			{
			}
			num = (short)1195573248;
			short num3 = num;
			num = (short)74448897;
			if (num != 0)
			{
			}
			num = (short)112787456;
			if (num != 0)
			{
			}
			base.Id = 2049;
			base.SingleInstance = true;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("菁ꣃ꫅軇꿉귋뫍ꗏꃑ뇓ꗕ駙돛돝郟跡諣菥蛧黩냫볭釯雱鷳駵\ud8f7돹鋻飽濿瀁椃朅簇按挋怍䰏䀑甓爕焗甙唛瀝䘟䴡嘣䬥䤧帩䔫䄭帯ᰱ䰳圵唷嘹", a_);
			base.UIName = global::CommonResources.AcgResources.ID_RADIOINFORMATION;
			base.DataTransferOrder = 1;
		}
	}
}
