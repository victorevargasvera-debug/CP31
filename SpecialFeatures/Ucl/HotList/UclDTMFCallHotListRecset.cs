using System;
using System.Runtime.Serialization;
using AcpBusinessLayer;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001D7 RID: 471
	[global::System.Serializable]
	public class UclDTMFCallHotListRecset : global::AcpBusinessLayer.Recordset
	{
		// Token: 0x060016D3 RID: 5843 RVA: 0x00003A48 File Offset: 0x00001C48
		public UclDTMFCallHotListRecset() : base(global::CommonResources.AppResources.DTMF_Call_Hot_List)
		{
			this.a();
		}

		// Token: 0x060016D4 RID: 5844 RVA: 0x001F6270 File Offset: 0x001F4470
		protected UclDTMFCallHotListRecset(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			int a_ = 17;
			base..ctor(info, context);
			if (info == null)
			{
				throw new global::System.ArgumentNullException(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ﶓﺗ", a_));
			}
			this.a();
		}

		// Token: 0x060016D5 RID: 5845 RVA: 0x001F62B0 File Offset: 0x001F44B0
		public override global::AcpBusinessLayer.FeatureNode CreateDefaultRecord()
		{
			short num = (short)116761776;
			short num2 = num;
			num = (short)618767536;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1481900032;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)579600384;
			if (num != 0)
			{
			}
			num = (short)456261633;
			if (num != 0)
			{
			}
			return new global::SpecialFeatures.Ucl.HotList.UclDTMFCallHotList(this);
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x001F635C File Offset: 0x001F455C
		private void a()
		{
			int a_ = 10;
			short num = (short)432277852;
			short num2 = num;
			num = (short)111216988;
			switch (num2 == num)
			{
			default:
			{
				num = (short)862715904;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2065367040;
			if (num != 0)
			{
			}
			num = (short)964362241;
			if (num != 0)
			{
			}
			base.Id = 2216;
			base.UIPagePath = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude8cﾎﲔ\udd9aﺞ햠횢힤슦\udaa8邪삮\udcb0쎲\udab4\ud9b6\udcb8햺즼邾苀ꋂ꧄ꯆ蟊꓌볎ꗐ雔룖럘뷚드룞铠釢蓤鏦胨蓪菬샮맰鳲致믶郸裺觼탾吀怂椄䌆崈䘊䬌䰎瀐缒礔弖瘘漚儜瘞删圢甤䘦丨个̬圮倰帲头", a_);
			base.UIName = global::CommonResources.AppResources.DTMF_Call_Hot_List;
			base.DataTransferOrder = 815;
		}
	}
}
