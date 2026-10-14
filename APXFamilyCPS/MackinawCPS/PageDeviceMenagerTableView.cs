using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using AcpUI.Common;
using CommonResources;
using Infragistics.Windows.DataPresenter;
using PreEmptive.SoS.Runtime;

namespace MackinawCPS
{
	// Token: 0x0200002E RID: 46
	public class PageDeviceMenagerTableView : global::System.Windows.Controls.Page, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060000B0 RID: 176 RVA: 0x00012FE8 File Offset: 0x000111E8
		public PageDeviceMenagerTableView()
		{
			this.InitializeComponent();
			global::AcpUI.Common.Utility.SetDirection(this);
			global::System.Data.DataTable dataTable = this.CreateContactEntryDataTable();
			this.DGContactTypes.DataSource = dataTable.DefaultView;
			this.AddSomeRows(dataTable, 4);
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00013028 File Offset: 0x00011228
		private global::System.Data.DataTable CreateContactEntryDataTable()
		{
			int a_ = 12;
			short num = (short)1969160192;
			short num2 = num;
			num = (short)515424707;
			short num3 = num;
			num = (short)1293337027;
			switch (num3 == num)
			{
			}
			num = (short)1908736001;
			if (num != 0)
			{
			}
			num = (short)1197801472;
			if (num != 0)
			{
			}
			global::System.Data.DataTable dataTable = new global::System.Data.DataTable(global::CommonResources.AppResources.SwatiTable_Id);
			global::System.Data.DataColumn column = new global::System.Data.DataColumn(global::CommonResources.AppResources.Asset_ID, typeof(string));
			global::System.Data.DataColumn column2 = new global::System.Data.DataColumn(global::CommonResources.AppResources.Organization_Id, typeof(string));
			global::System.Data.DataColumn column3 = new global::System.Data.DataColumn(global::CommonResources.AppResources.Host_DSP_Version, typeof(string));
			global::System.Data.DataColumn column4 = new global::System.Data.DataColumn(global::CommonResources.AppResources.MACE_Version, typeof(string));
			global::System.Data.DataColumn column5 = new global::System.Data.DataColumn(global::CommonResources.AppResources.Tuner_Version, typeof(string));
			global::System.Data.DataColumn column6 = new global::System.Data.DataColumn(global::CommonResources.AppResources.Model_Number, typeof(string));
			global::System.Data.DataColumn column7 = new global::System.Data.DataColumn(global::CommonResources.AppResources.Serial_Number, typeof(string));
			global::System.Data.DataColumn column8 = new global::System.Data.DataColumn(global::CommonResources.AppResources.FLASHcode_Id, typeof(string));
			global::System.Data.DataColumn dataColumn = new global::System.Data.DataColumn(global::CommonResources.AppResources.Select_Device_S);
			dataColumn.DataType = global::System.Type.GetType(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뿫韭華蛱釳鯵훷룹鏻釽泿朁攃栅", a_));
			dataTable.Columns.Add(dataColumn);
			global::System.Data.DataColumn dataColumn2 = new global::System.Data.DataColumn(global::CommonResources.AppResources.DeviceName_Id);
			dataColumn2.DataType = global::System.Type.GetType(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뿫韭華蛱釳鯵훷꧹裻賽槿氁挃", a_));
			dataColumn2.Unique = false;
			dataColumn2.ReadOnly = false;
			dataTable.Columns.Add(dataColumn2);
			dataTable.Columns.Add(column);
			dataTable.Columns.Add(column2);
			dataTable.Columns.Add(column6);
			dataTable.Columns.Add(column7);
			dataTable.Columns.Add(column8);
			dataTable.Columns.Add(column3);
			dataTable.Columns.Add(column4);
			dataTable.Columns.Add(column5);
			return dataTable;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00013270 File Offset: 0x00011470
		private void AddSomeRows(global::System.Data.DataTable dt, int numRows)
		{
			int a_ = 19;
			short num = (short)1612054528;
			short num2 = num;
			num = (short)127008769;
			if (num != 0)
			{
			}
			num = (short)1989711112;
			short num3 = num;
			num = (short)1837339912;
			switch (num3 == num)
			{
			}
			num = (short)268632064;
			if (num != 0)
			{
			}
			global::System.Data.DataRow dataRow = dt.NewRow();
			dataRow[1] = global::CommonResources.AppResources.Radio_ID1;
			dataRow[2] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꏲ뫴웶쯸죺짼돾䠀", a_);
			dataRow[3] = global::CommonResources.AppResources.Police_Id;
			dataRow[4] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("꯲ꇴ믶쳸쯺췼쿾", a_);
			dataRow[5] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("싲쟴쓶룸맺뻼컾㌀。㄄", a_);
			dataRow[6] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("웲췴쿶째쯺염틾㄀㌂㔄㌆ㄈ㬊", a_);
			dataRow[7] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꇲ열웶ퟸ쯺췼퇾㄀㌂", a_);
			dataRow[8] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꇲ열웶ퟸ쯺췼퇾㄀㌂", a_);
			dataRow[9] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꇲ열웶ퟸ쯺췼퇾㄀㌂", a_);
			dt.Rows.Add(dataRow);
			global::System.Data.DataRow dataRow2 = dt.NewRow();
			dataRow2[1] = global::CommonResources.AppResources.Radio_ID2;
			dataRow2[2] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꏲ뫴쏶쳸췺쫼돾䠀", a_);
			dataRow2[3] = global::CommonResources.AppResources.Police_Id;
			dataRow2[4] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("꯲ꇴ믶쳸쯺췼쿾", a_);
			dataRow2[5] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("쟲쏴쟶듸닺볼쯾㐀㌂㔄", a_);
			dataRow2[6] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("웲췴쿶째쯺염틾㄀㌂㔄㌆ㄈ㬊", a_);
			dataRow2[7] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꇲ열엶ퟸ쯺췼퇾㄀㌂", a_);
			dataRow2[8] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꇲ열엶ퟸ쯺췼퇾㄀㌂", a_);
			dataRow2[9] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꇲ열웶ퟸ쯺췼퇾㄀㌂", a_);
			dt.Rows.Add(dataRow2);
			global::System.Data.DataRow dataRow3 = dt.NewRow();
			dataRow3[1] = global::CommonResources.AppResources.Radio_ID3;
			dataRow3[2] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꏲ뫴쿶샸쯺쳼돾䠀", a_);
			dataRow3[3] = global::CommonResources.AppResources.Police_Id;
			dataRow3[4] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("꯲ꇴ믶쳸쯺췼쿾", a_);
			dataRow3[5] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("쟲쏴쟶꧸럺볼쯾㐀㌂㔄", a_);
			dataRow3[6] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("웲췴쿶째쯺염틾㄀㌂㔄㌆ㄈ㌊", a_);
			dataRow3[7] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꇲ열웶ퟸ쯺췼퇾㄀㌂", a_);
			dataRow3[8] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꇲ열웶ퟸ쯺췼퇾㄀㌂", a_);
			dataRow3[9] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꇲ열웶ퟸ쯺췼퇾㄀㌂", a_);
			dt.Rows.Add(dataRow3);
			global::System.Data.DataRow dataRow4 = dt.NewRow();
			dataRow4[1] = global::CommonResources.AppResources.Radio_ID4;
			dataRow4[2] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뗲보웶쯸죺짼귾䐀", a_);
			dataRow4[3] = global::CommonResources.AppResources.Fire_Id;
			dataRow4[4] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("꯲ꇴ믶쳸쯺췼쿾", a_);
			dataRow4[5] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("쟲쏴쟶꫸껺돼쯾㐀㌂㔄", a_);
			dataRow4[6] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("웲췴쿶째쯺염틾㄀㌂㔄㌆ㄈ㌊", a_);
			dataRow4[7] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꇲ열엶ퟸ쯺췼퇾㄀㌂", a_);
			dataRow4[8] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꇲ열엶ퟸ쯺췼퇾㄀㌂", a_);
			dataRow4[9] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꇲ열엶ퟸ쯺췼퇾㄀㌂", a_);
			dt.Rows.Add(dataRow4);
			global::System.Data.DataRow dataRow5 = dt.NewRow();
			dataRow5[1] = global::CommonResources.AppResources.Radio_ID5;
			dataRow5[2] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뗲보싶쿸쳺염귾䐀", a_);
			dataRow5[3] = global::CommonResources.AppResources.Fire_Id;
			dataRow5[4] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("꯲ꇴ믶쯸컺췼쿾", a_);
			dataRow5[5] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("쟲쏴쟶껸뻺껼쯾㐀㌂㔄", a_);
			dataRow5[6] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("웲췴쿶째쯺염틾㄀㌂㔄㌆ㄈ㌊", a_);
			dataRow5[7] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꇲ열엶ퟸ쯺췼퇾㄀㌂", a_);
			dataRow5[8] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꇲ열엶ퟸ쯺췼퇾㄀㌂", a_);
			dataRow5[9] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꇲ열엶ퟸ쯺췼퇾㄀㌂", a_);
			dt.Rows.Add(dataRow5);
			global::System.Data.DataRow dataRow6 = dt.NewRow();
			dataRow6[1] = global::CommonResources.AppResources.Radio_ID6;
			dataRow6[2] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뗲보컶째쫺쿼귾䐀", a_);
			dataRow6[3] = global::CommonResources.AppResources.Fire_Id;
			dataRow6[4] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("꯲ꇴ믶쯸컺췼쿾", a_);
			dataRow6[5] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("쟲쏴쟶돸뫺ꗼ쯾㐀㌂㔄", a_);
			dataRow6[6] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("웲췴쿶째쯺염틾㄀㌂㔄㌆㤈㌊", a_);
			dataRow6[7] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꇲ열쓶ퟸ쯺췼퇾㄀㌂", a_);
			dataRow6[8] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꇲ열엶ퟸ쯺췼퇾㄀㌂", a_);
			dataRow6[9] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꇲ열엶ퟸ쯺췼퇾㄀㌂", a_);
			dt.Rows.Add(dataRow6);
			global::System.Data.DataRow dataRow7 = dt.NewRow();
			dataRow7[1] = global::CommonResources.AppResources.Radio_ID7;
			dataRow7[2] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뛲룴웶쯸죺짼꯾䀀", a_);
			dataRow7[3] = global::CommonResources.AppResources.EMT_Id;
			dataRow7[4] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("꯲ꇴ믶쯸컺췼쿾", a_);
			dataRow7[5] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("쟲쏴쟶뇸닺볼쯾㐀㌂㔄", a_);
			dataRow7[6] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("웲췴쿶째쯺염틾㄀㌂㔄㌆㤈㌊", a_);
			dataRow7[7] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꇲ열쓶ퟸ쯺췼퇾㄀㌂", a_);
			dataRow7[8] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꇲ열엶ퟸ쯺췼퇾㄀㌂", a_);
			dataRow7[9] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꇲ열엶ퟸ쯺췼퇾㄀㌂", a_);
			dt.Rows.Add(dataRow7);
			global::System.Data.DataRow dataRow8 = dt.NewRow();
			dataRow8[1] = global::CommonResources.AppResources.Radio_ID8;
			dataRow8[2] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뛲룴싶쿸쳺염꯾䌀", a_);
			dataRow8[3] = global::CommonResources.AppResources.EMT_Id;
			dataRow8[4] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("꯲ꇴ믶쯸컺췼쿾", a_);
			dataRow8[5] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("쟲쏴쟶뗸뫺맼쯾㐀㌂㔄", a_);
			dataRow8[6] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("웲췴쿶째쯺염틾㄀㌂㔄㌆ㄈ㌊", a_);
			dataRow8[7] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꇲ열엶ퟸ쯺췼퇾㄀㈂", a_);
			dataRow8[8] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꇲ열엶ퟸ쯺췼퇾㄀㈂", a_);
			dataRow8[9] = global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꇲ열엶ퟸ쯺췼퇾㄀㈂", a_);
			dt.Rows.Add(dataRow8);
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00013944 File Offset: 0x00011B44
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 12;
			short num = (short)105130178;
			short num2 = num;
			num = (short)1247684802;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)107544577;
				if (num != 0)
				{
				}
				num = (short)648282112;
				short num3 = num;
				num = (short)68288512;
				if (num != 0)
				{
				}
				if (!this._contentLoaded)
				{
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("쏫꿭ꃯ꫱닳韵闷鏹郻蟽䏿刁圃㴅欇攉愋縍缏簑焓砕気㔙砛笝嘟䬡䜣䌥䔧䬩䈫伭圯圱䘳ᤵ䠷嬹嬻嬽␿❁㉃⽅⭇⽉⅋⭍㹏㍑㍓㍕⩗⹙㵛㱝౟ݡባཥ൧ᵩ䉫᙭ᅯάᡳ", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				break;
			}
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00013A28 File Offset: 0x00011C28
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1408028954;
			short num2 = num;
			num = (short)1271910682;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)129957889;
				if (num != 0)
				{
				}
				num = (short)698482688;
				short num3 = num;
				num = (short)1325531136;
				if (num != 0)
				{
				}
				if (connectionId != 1)
				{
					this._contentLoaded = true;
					return;
				}
				break;
			}
			}
			this.DGContactTypes = (global::Infragistics.Windows.DataPresenter.XamDataGrid)target;
		}

		// Token: 0x040000B1 RID: 177
		internal global::Infragistics.Windows.DataPresenter.XamDataGrid DGContactTypes;

		// Token: 0x040000B2 RID: 178
		private bool _contentLoaded;

		// Token: 0x040000B3 RID: 179
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
