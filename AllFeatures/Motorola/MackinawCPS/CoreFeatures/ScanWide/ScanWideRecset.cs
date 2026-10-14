using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.ScanWide
{
	// Token: 0x0200010D RID: 269
	[global::System.Serializable]
	public class ScanWideRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060027A4 RID: 10148 RVA: 0x002684B0 File Offset: 0x002666B0
		public ScanWideRecset()
		{
			int a_ = 14;
			base..ctor(global::AllFeatures.CodeplugGuid.b("鳎닐닒믔軘닚맜뫞", a_));
			this.SetValues();
		}

		// Token: 0x060027A5 RID: 10149 RVA: 0x002684E0 File Offset: 0x002666E0
		public ScanWideRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x060027A6 RID: 10150 RVA: 0x0026850C File Offset: 0x0026670C
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)757662184;
			short num2 = num;
			num = (short)1798373864;
			switch (num2 == num)
			{
			}
			num = (short)458227713;
			if (num != 0)
			{
			}
			num = (short)829358080;
			if (num != 0)
			{
			}
			num = (short)1776484352;
			short num3 = num;
			return new global::Motorola.MackinawCPS.CoreFeatures.ScanWide.ScanWide(this);
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x002685BC File Offset: 0x002667BC
		internal void SetValues()
		{
			int a_ = 7;
			short num = (short)919873153;
			short num2 = num;
			num = (short)1823549057;
			switch (num2 == num)
			{
			}
			num = (short)81920001;
			if (num != 0)
			{
			}
			num = (short)218890240;
			if (num != 0)
			{
			}
			num = (short)1178533888;
			short num3 = num;
			base.Id = 2023;
			base.SingleInstance = true;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("觇ꛉꃋ裍뗏돑ꃓꏕ꫗뿙꿛ꏟ跡解雥蟧蓩觫胭蓯껱ꟳ闵駷铹\udcfb뷽濿氁戃漅漇缉縋漍搏笑笓砕䐗䤙缛缝丟ȡ猣伥䰧伩瀫紭匯匱娳愵儷帹夻ွ㠿⍁⥃⩅", a_);
			base.UIName = global::CommonResources.AcgResources.ID_SCANWIDE;
			base.DataTransferOrder = 11;
		}
	}
}
