using System;
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using Microsoft.Practices.Prism;
using Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree;
using Motorola.CommonCPS.RadioManagement.Controls.UiHelpers;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000B7 RID: 183
	public class RMHomeSetList : global::System.Windows.Controls.UserControl, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x0600049D RID: 1181 RVA: 0x0004BCB4 File Offset: 0x00049EB4
		public RMHomeSetList()
		{
			this.InitializeComponent();
			this.dgrHomeSets.SelectedItems.Records.CollectionChanged += this.Records_CollectionChanged;
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x0004BCF0 File Offset: 0x00049EF0
		// (set) Token: 0x0600049F RID: 1183 RVA: 0x0004BDAC File Offset: 0x00049FAC
		public global::System.ComponentModel.ICollectionView Radios
		{
			get
			{
				short num = (short)1895673535;
				short num2 = num;
				num = (short)1364045503;
				switch (num2 == num)
				{
				}
				num = (short)53805057;
				if (num != 0)
				{
				}
				num = (short)618397696;
				short num3 = num;
				num = (short)967245824;
				if (num != 0)
				{
				}
				return base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMHomeSetList.RadiosProperty) as global::System.ComponentModel.ICollectionView;
			}
			set
			{
				short num = (short)154444636;
				short num2 = num;
				num = (short)414491484;
				switch (num2 == num)
				{
				}
				num = (short)265486336;
				if (num != 0)
				{
				}
				num = (short)1232142336;
				short num3 = num;
				num = (short)1181745153;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMHomeSetList.RadiosProperty, value);
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x0004BE60 File Offset: 0x0004A060
		// (set) Token: 0x060004A1 RID: 1185 RVA: 0x0004BF1C File Offset: 0x0004A11C
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> SelectedRadios
		{
			get
			{
				short num = (short)845024063;
				short num2 = num;
				num = (short)656280383;
				switch (num2 == num)
				{
				}
				num = (short)344457217;
				if (num != 0)
				{
				}
				num = (short)686686208;
				short num3 = num;
				num = (short)1093206016;
				if (num != 0)
				{
				}
				return (global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>)base.GetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMHomeSetList.SelectedRadiosProperty);
			}
			set
			{
				short num = (short)1102192533;
				short num2 = num;
				num = (short)1853104021;
				switch (num2 == num)
				{
				}
				num = (short)28639232;
				if (num != 0)
				{
				}
				num = (short)964689920;
				short num3 = num;
				num = (short)329973761;
				if (num != 0)
				{
				}
				base.SetValue(global::Motorola.CommonCPS.RadioManagement.Controls.RMHomeSetList.SelectedRadiosProperty, value);
			}
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0004BFD4 File Offset: 0x0004A1D4
		private void Records_CollectionChanged(object A_0, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_1)
		{
			short num = (short)1630310141;
			short num2 = num;
			num = (short)1615302397;
			switch (num2 == num)
			{
			}
			num = (short)1137967105;
			if (num != 0)
			{
			}
			num = (short)2009530368;
			short num3 = num;
			num = (short)28573696;
			if (num != 0)
			{
			}
			this.SelectedRadios.Clear();
			this.SelectedRadios.AddRange(this.dgrHomeSets.SelectedItems.GetDataItemsFromSelectedCellsOrRecords<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>());
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x0004C0A4 File Offset: 0x0004A2A4
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		public void InitializeComponent()
		{
			int a_ = 11;
			while (this._contentLoaded)
			{
				short num = (short)1810850024;
				short num2 = num;
				num = (short)2004967656;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)646250496;
					short num3 = num;
					num = (short)2142240768;
					if (num != 0)
					{
					}
					num = (short)752943105;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			this._contentLoaded = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("貢좦\udda8쒪\udfac삮\uddb0튲鮴횸횺킼킾꿀胂闄铆駊곌ꯎ룐볒飔뛖럘뫚뫜뫞賠蛢诤鏦쟨꣪苬臮藰臲髴鯶諸샺黼郾氀猂樄椆氈攊礌‎搐怒瀔攖稘琚猜欞匠䰢䤤否ب太䀬䜮帰帲倴䐶尸伺儼嘾㉀㝂歄㽆⡈♊⅌", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0004C184 File Offset: 0x0004A384
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		internal global::System.Delegate a(global::System.Type A_0, string A_1)
		{
			short num = (short)2110324737;
			if (num != 0)
			{
			}
			num = (short)1513321645;
			short num2 = num;
			num = (short)1801417901;
			switch (num2 == num)
			{
			}
			num = (short)996933632;
			short num3 = num;
			num = (short)147914752;
			if (num != 0)
			{
			}
			return global::System.Delegate.CreateDelegate(A_0, this, A_1);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x0004C238 File Offset: 0x0004A438
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			while (connectionId == 1)
			{
				short num = (short)374586260;
				short num2 = num;
				num = (short)1927068564;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1483866112;
					short num3 = num;
					num = (short)655163392;
					if (num != 0)
					{
					}
					num = (short)1132068865;
					if (num != 0)
					{
					}
					this.dgrHomeSets = (global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid)target;
					return;
				}
				}
			}
			this._contentLoaded = true;
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x0004C300 File Offset: 0x0004A500
		// Note: this type is marked as 'beforefieldinit'.
		static RMHomeSetList()
		{
			int a_ = 4;
			short num = (short)323581824;
			short num2 = num;
			num = (short)1985836928;
			switch (num2 == num)
			{
			}
			num = (short)1295974401;
			if (num != 0)
			{
			}
			num = (short)1120206848;
			short num3 = num;
			num = (short)46071808;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.Controls.RMHomeSetList.RadiosProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("캛ﾝ쒟쮡쮣향", a_), typeof(global::System.ComponentModel.ICollectionView), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMHomeSetList));
			global::Motorola.CommonCPS.RadioManagement.Controls.RMHomeSetList.SelectedRadiosProperty = global::System.Windows.DependencyProperty.Register(global::Motorola.CommonCPS.RadioManagement.Controls.Behaviors.DataTree.CustomRightMouseDownBehaviour.c("쾛ﮝ첟잡잣튥춧캩ﺫ쾭풯\udbb1\udbb3억", a_), typeof(global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>), typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMHomeSetList), new global::System.Windows.PropertyMetadata(new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>()));
		}

		// Token: 0x040001B9 RID: 441
		public static readonly global::System.Windows.DependencyProperty RadiosProperty;

		// Token: 0x040001BA RID: 442
		public static readonly global::System.Windows.DependencyProperty SelectedRadiosProperty;

		// Token: 0x040001BB RID: 443
		internal global::Motorola.CommonCPS.RadioManagement.Controls.RMDataGrid dgrHomeSets;

		// Token: 0x040001BC RID: 444
		private bool _contentLoaded;
	}
}
