using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO5
{
	// Token: 0x020003AA RID: 938
	[global::System.Serializable]
	public class ControlHeadO5Recset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x06008884 RID: 34948 RVA: 0x007F2DD0 File Offset: 0x007F0FD0
		public ControlHeadO5Recset()
		{
			int a_ = 2;
			base..ctor(global::AllFeatures.CodeplugGuid.b("胂꫄꧆뷈맊ꋌꏎ鯒냔뛖뷘ﯚ￞껠훢", a_));
			this.SetValues();
		}

		// Token: 0x06008885 RID: 34949 RVA: 0x007F2E00 File Offset: 0x007F1000
		public ControlHeadO5Recset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x06008886 RID: 34950 RVA: 0x007F2E2C File Offset: 0x007F102C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1380809065;
			short num2 = num;
			num = (short)211515753;
			switch (num2 == num)
			{
			}
			num = (short)1229455361;
			if (num != 0)
			{
			}
			num = (short)1532362752;
			short num3 = num;
			num = (short)1994194944;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5(this);
		}

		// Token: 0x06008887 RID: 34951 RVA: 0x007F2EDC File Offset: 0x007F10DC
		internal void SetValues()
		{
			int a_ = 15;
			short num = (short)1303620547;
			short num2 = num;
			num = (short)1580379075;
			switch (num2 == num)
			{
			}
			num = (short)352649217;
			if (num != 0)
			{
			}
			num = (short)966197248;
			short num3 = num;
			num = (short)641007616;
			if (num != 0)
			{
			}
			base.Id = 2130;
			base.SingleInstance = true;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("量뻑룓郕뷗믙꣛ꯝ鋟蟡韣\udde5ꯧ藩臫黭鿯鳱釳飵賷꛹껻鿽擿欁欃★䴇砉欋愍縏紑礓缕笗椙㰛崝伟䰡䈣伥伧弩師伭䐯嬱嬳堵搷礹医倽㐿ぁ⭃⩅㭇ᙉཋ⅍㹏♑♓㥕㑗穙ᑛ㭝ş١䑣䭥䡧╩奫㉭㍯ᵱᩳɵ੷ᕹၻ㙽즅붇ꒉﶏﺑ", a_);
			base.UIName = global::CommonResources.AcgResources.ID_CONTROLHEADO5;
			base.DataTransferOrder = 16;
		}
	}
}
