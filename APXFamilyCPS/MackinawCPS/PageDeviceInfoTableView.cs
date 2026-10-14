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
	// Token: 0x0200002D RID: 45
	public class PageDeviceInfoTableView : global::System.Windows.Controls.Page, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x060000AB RID: 171 RVA: 0x00012A28 File Offset: 0x00010C28
		public PageDeviceInfoTableView()
		{
			this.InitializeComponent();
			global::AcpUI.Common.Utility.SetDirection(this);
			global::System.Data.DataTable dataTable = this.CreateContactEntryDataTable();
			this.DGContactTypes.DataSource = dataTable.DefaultView;
			this.AddSomeRows(dataTable, 4);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00012A68 File Offset: 0x00010C68
		private global::System.Data.DataTable CreateContactEntryDataTable()
		{
			int a_ = 13;
			short num = (short)1905065984;
			short num2 = num;
			num = (short)1728497657;
			short num3 = num;
			num = (short)535021561;
			switch (num3 == num)
			{
			}
			num = (short)100663296;
			if (num != 0)
			{
			}
			num = (short)9830401;
			if (num != 0)
			{
			}
			global::System.Data.DataTable dataTable = new global::System.Data.DataTable(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뻬飮郰蟲鳴ꏶ飸駺釼髾", a_));
			global::System.Data.DataColumn column = new global::System.Data.DataColumn(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꗬ胮苰蟲\udaf4돶꫸꯺\uddfcꧾ搀焂瘄渆昈攊", a_), typeof(string));
			global::System.Data.DataColumn column2 = new global::System.Data.DataColumn(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꃬ껮닰뛲헴ꇶ鳸觺軼雾渀洂", a_), typeof(string));
			global::System.Data.DataColumn column3 = new global::System.Data.DataColumn(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("맬髮鿰雲蟴ퟶ꿸黺迼賾栀氂欄", a_), typeof(string));
			global::System.Data.DataColumn column4 = new global::System.Data.DataColumn(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꃬ胮闰雲駴ퟶ럸軺郼鷾搀焂", a_), typeof(string));
			global::System.Data.DataColumn dataColumn = new global::System.Data.DataColumn(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뻬諮鷰雲雴菶\ud9f8뿺飼觾栀怂怄⠆稈", a_));
			dataColumn.DataType = global::System.Type.GetType(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뻬雮苰蟲郴髶ퟸ꣺觼跾栀洂戄", a_));
			dataTable.Columns.Add(dataColumn);
			global::System.Data.DataColumn dataColumn2 = new global::System.Data.DataColumn(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("ꧬ諮蟰髲雴鋶럸髺郼髾", a_));
			dataColumn2.DataType = global::System.Type.GetType(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("뻬雮苰蟲郴髶ퟸ꣺觼跾栀洂戄", a_));
			dataColumn2.Unique = false;
			dataColumn2.ReadOnly = false;
			dataTable.Columns.Add(dataColumn2);
			dataTable.Columns.Add(column);
			dataTable.Columns.Add(column2);
			dataTable.Columns.Add(column3);
			dataTable.Columns.Add(column4);
			return dataTable;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00012C5C File Offset: 0x00010E5C
		private void AddSomeRows(global::System.Data.DataTable dt, int numRows)
		{
			short num = (short)854654976;
			short num2 = num;
			num = (short)113244860;
			short num3 = num;
			num = (short)1408498364;
			switch (num3 == num)
			{
			}
			num = (short)784334849;
			if (num != 0)
			{
			}
			num = (short)2140078080;
			if (num != 0)
			{
			}
			global::System.Data.DataRow dataRow = dt.NewRow();
			dataRow[1] = global::CommonResources.AppResources.Radio_ID1;
			dataRow[2] = global::CommonResources.AppResources.R01_00_00;
			dataRow[3] = global::CommonResources.AppResources.R01_00_00;
			dataRow[4] = global::CommonResources.AppResources.R01_00_00;
			dataRow[5] = global::CommonResources.AppResources.XTL5000_ID;
			dt.Rows.Add(dataRow);
			global::System.Data.DataRow dataRow2 = dt.NewRow();
			dataRow2[1] = global::CommonResources.AppResources.Radio_ID2;
			dataRow2[2] = global::CommonResources.AppResources.R02_00_00;
			dataRow2[3] = global::CommonResources.AppResources.R02_00_00;
			dataRow2[4] = global::CommonResources.AppResources.R01_00_00;
			dataRow2[5] = global::CommonResources.AppResources.XTL5000_ID;
			dt.Rows.Add(dataRow2);
			global::System.Data.DataRow dataRow3 = dt.NewRow();
			dataRow3[1] = global::CommonResources.AppResources.Radio_ID3;
			dataRow3[2] = global::CommonResources.AppResources.R01_00_00;
			dataRow3[3] = global::CommonResources.AppResources.R01_00_00;
			dataRow3[4] = global::CommonResources.AppResources.R01_00_00;
			dataRow3[5] = global::CommonResources.AppResources.XTL5000_ID;
			dt.Rows.Add(dataRow3);
			global::System.Data.DataRow dataRow4 = dt.NewRow();
			dataRow4[1] = global::CommonResources.AppResources.Radio_ID4;
			dataRow4[2] = global::CommonResources.AppResources.R02_00_00;
			dataRow4[3] = global::CommonResources.AppResources.R02_00_00;
			dataRow4[4] = global::CommonResources.AppResources.R02_00_00;
			dataRow4[5] = global::CommonResources.AppResources.XTL2500_ID;
			dt.Rows.Add(dataRow4);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00012E44 File Offset: 0x00011044
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 18;
			short num = (short)1869584617;
			short num2 = num;
			num = (short)2046138601;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)657129473;
				if (num != 0)
				{
				}
				num = (short)313589760;
				short num3 = num;
				num = (short)708378624;
				if (num != 0)
				{
				}
				if (!this._contentLoaded)
				{
					this._contentLoaded = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::PreEmptive.SoS.Runtime.FixedLengthStream.b("\uddf1뗳꛵ꃷ볹鷻鏽槿渁紃䔅堇変㜋洍缏缑搓礕瘗缙爛樝༟䘡䄣倥䄧䤩䤫䌭儯就唳儵崷䠹ጻ丽ℿ╁⅃≅ⵇ㱉╋ⵍ㕏㭑㩓さ㝗⹙㵛㱝౟ݡባཥ൧ᵩ䉫᙭ᅯάᡳ", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				break;
			}
			}
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00012F24 File Offset: 0x00011124
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)464722207;
			short num2 = num;
			num = (short)1591023903;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)495648768;
				if (num != 0)
				{
				}
				num = (short)979566592;
				short num3 = num;
				if (connectionId != 1)
				{
					this._contentLoaded = true;
					return;
				}
				break;
			}
			}
			num = (short)188219393;
			if (num != 0)
			{
			}
			this.DGContactTypes = (global::Infragistics.Windows.DataPresenter.XamDataGrid)target;
		}

		// Token: 0x040000AE RID: 174
		internal global::Infragistics.Windows.DataPresenter.XamDataGrid DGContactTypes;

		// Token: 0x040000AF RID: 175
		private bool _contentLoaded;

		// Token: 0x040000B0 RID: 176
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
