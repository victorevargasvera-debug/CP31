using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DEK
{
	// Token: 0x02000330 RID: 816
	[global::System.Serializable]
	public class DEKRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06007E2F RID: 32303 RVA: 0x00745980 File Offset: 0x00743B80
		public DEKRecset()
		{
			int a_ = 5;
			base..ctor(global::AllFeatures.CodeplugGuid.b("苅跇臉", a_));
			this.SetValues();
		}

		// Token: 0x06007E30 RID: 32304 RVA: 0x007459B0 File Offset: 0x00743BB0
		public DEKRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x06007E31 RID: 32305 RVA: 0x007459DC File Offset: 0x00743BDC
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)2096496640;
			short num2 = num;
			num = (short)1640223587;
			short num3 = num;
			num = (short)495571811;
			switch (num3 == num)
			{
			}
			num = (short)1860435968;
			if (num != 0)
			{
			}
			num = (short)145489921;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.DEK.DEK(this);
		}

		// Token: 0x06007E32 RID: 32306 RVA: 0x00745A8C File Offset: 0x00743C8C
		internal void SetValues()
		{
			int a_ = 1;
			short num = (short)557252608;
			short num2 = num;
			num = (short)2098917426;
			short num3 = num;
			num = (short)2121134130;
			switch (num3 == num)
			{
			}
			num = (short)456261632;
			if (num != 0)
			{
			}
			num = (short)398589953;
			if (num != 0)
			{
			}
			base.Id = 2129;
			base.SingleInstance = true;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("菁ꣃ꫅軇꿉귋뫍ꗏꃑ뇓ꗕ駙돛돝郟跡諣菥蛧黩냫볭釯雱鷳駵\ud8f7뿹軻駽濿氁欃欅愇椉缋⸍匏紑稓瀕焗紙椛氝䄟嘡䴣䤥䘧瘩漫䄭帯䘱䘳夵吷䤹总稽ԿुᡃɅേŉ手㙍ㅏ㽑㡓", a_);
			base.UIName = global::CommonResources.AcgResources.ID_DEK;
			base.DataTransferOrder = 14;
		}
	}
}
