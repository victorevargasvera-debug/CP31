using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.DataWide
{
	// Token: 0x020004D3 RID: 1235
	[global::System.Serializable]
	public class DataWideRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x0600A34D RID: 41805 RVA: 0x009897F8 File Offset: 0x009879F8
		public DataWideRecset()
		{
			int a_ = 14;
			base..ctor(global::AllFeatures.CodeplugGuid.b("诎냐꟒듔軘닚맜뫞", a_));
			this.SetValues();
		}

		// Token: 0x0600A34E RID: 41806 RVA: 0x00989828 File Offset: 0x00987A28
		public DataWideRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context) : base(info, context)
		{
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::CommonResources.AcgResources.ID_INFO);
			}
			this.SetValues();
		}

		// Token: 0x0600A34F RID: 41807 RVA: 0x00989854 File Offset: 0x00987A54
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)1462152147;
			short num2 = num;
			num = (short)607431635;
			switch (num2 == num)
			{
			default:
			{
				num = (short)908656640;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1623195649;
			if (num != 0)
			{
			}
			num = (short)198836224;
			if (num != 0)
			{
			}
			return new global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide(this);
		}

		// Token: 0x0600A350 RID: 41808 RVA: 0x00989904 File Offset: 0x00987B04
		internal void SetValues()
		{
			int a_ = 15;
			short num = (short)722102019;
			short num2 = num;
			num = (short)1362519811;
			switch (num2 == num)
			{
			default:
			{
				num = (short)935985152;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)335282176;
			if (num != 0)
			{
			}
			num = (short)257622017;
			if (num != 0)
			{
			}
			base.Id = 2028;
			base.SingleInstance = true;
			base.UIPagePath = global::AllFeatures.CodeplugGuid.b("量뻑룓郕뷗믙꣛ꯝ鋟蟡韣\udde5ꯧ藩臫黭鿯鳱釳飵賷꛹룻鿽瓿持␃䔅朇搉樋服眏朑易眕気猙猛瀝簟昡䔣別䤧਩笫䜭启圱栳爵夷丹崻椽⤿♁⅃桅ぇ⭉⅋≍", a_);
			base.UIName = global::CommonResources.AcgResources.ID_DATAWIDE;
			base.DataTransferOrder = 13;
		}
	}
}
