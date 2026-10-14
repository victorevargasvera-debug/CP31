using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Data;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Regions;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.Infrastructure;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.ASTRODataProfile
{
	// Token: 0x02000011 RID: 17
	[global::System.ComponentModel.Composition.Export]
	public class RadioDataProfilesViewModel : global::Motorola.CommonCPS.RadioManagement.Infrastructure.CachedTableViewModelBase<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>
	{
		// Token: 0x06000042 RID: 66 RVA: 0x00005A04 File Offset: 0x00003C04
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public RadioDataProfilesViewModel(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator) : base(eventAggregator)
		{
			this.ShowRadioDetailsCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>(this.b));
			base.ShowDetailsCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>(new global::System.Action<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>(this.a));
			this.EnterEditModeCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.RadioDataProfilesViewModel.<>c.<>9.a));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.CommandProxy.GetInstance().ExportRadioDataProfilesCommand = (this.ExportDataProfileToFileCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.d), new global::System.Func<bool>(this.b)));
			this.CellFillEndedCommand = new global::Microsoft.Practices.Prism.Commands.DelegateCommand(new global::System.Action(this.c));
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000043 RID: 67 RVA: 0x00005ABC File Offset: 0x00003CBC
		// (set) Token: 0x06000044 RID: 68 RVA: 0x00005B6C File Offset: 0x00003D6C
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile> ShowRadioDetailsCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)577473026;
				short num2 = num;
				num = (short)1682082306;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1754464256;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2031812609;
				if (num != 0)
				{
				}
				num = (short)607780864;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1687147540;
				short num2 = num;
				num = (short)594859028;
				switch (num2 == num)
				{
				default:
				{
					num = (short)413138944;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1233977345;
				if (num != 0)
				{
				}
				num = (short)1004601344;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00005C1C File Offset: 0x00003E1C
		// (set) Token: 0x06000046 RID: 70 RVA: 0x00005CC8 File Offset: 0x00003EC8
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand EnterEditModeCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1278061290;
				short num2 = num;
				num = (short)1053141738;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1511194624;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1912864768;
				if (num != 0)
				{
				}
				num = (short)1158873089;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2118302826;
				short num2 = num;
				num = (short)231324778;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1151926272;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1290600449;
				if (num != 0)
				{
				}
				num = (short)1969946624;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000047 RID: 71 RVA: 0x00005D78 File Offset: 0x00003F78
		// (set) Token: 0x06000048 RID: 72 RVA: 0x00005E28 File Offset: 0x00004028
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand CellFillEndedCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1449968760;
				short num2 = num;
				num = (short)1930151032;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1521614848;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1821966336;
				if (num != 0)
				{
				}
				num = (short)347865089;
				if (num != 0)
				{
				}
				return this.d;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)785275051;
				short num2 = num;
				num = (short)237721771;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1963589632;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1272643584;
				if (num != 0)
				{
				}
				num = (short)1096351745;
				if (num != 0)
				{
				}
				this.d = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00005ED8 File Offset: 0x000040D8
		// (set) Token: 0x0600004A RID: 74 RVA: 0x00005F88 File Offset: 0x00004188
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand ExportDataProfileToFileCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)469869228;
				short num2 = num;
				num = (short)1242079916;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2145124352;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1563492353;
				if (num != 0)
				{
				}
				num = (short)1484980224;
				if (num != 0)
				{
				}
				return this.e;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
				short num = (short)1422983169;
				if (num != 0)
				{
				}
				num = (short)1947336704;
				short num2 = num;
				num = (short)471312512;
				short num3 = num;
				num = (short)2084022400;
				switch (num3 == num)
				{
				}
				num = (short)57475072;
				if (num != 0)
				{
				}
				this.e = value;
			}
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00006038 File Offset: 0x00004238
		protected override global::System.ComponentModel.ICollectionView GetItems()
		{
			short num = (short)372263127;
			short num2 = num;
			num = (short)1568884951;
			switch (num2 == num)
			{
			default:
			{
				num = (short)2055733248;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1595539456;
			if (num != 0)
			{
			}
			num = (short)44302337;
			if (num != 0)
			{
			}
			return global::System.Windows.Data.CollectionViewSource.GetDefaultView(base.ServiceProxy.LocalService.GetASTRODataProfiles(this.a));
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00006100 File Offset: 0x00004300
		protected override void SaveItem(object[] parameters)
		{
			short num;
			try
			{
				num = (short)1841758209;
				if (num != 0)
				{
				}
				num = (short)47734345;
				short num2 = num;
				num = (short)1890737737;
				switch (num2 == num)
				{
				}
				num = (short)1750466560;
				if (num != 0)
				{
				}
				base.ServiceProxy.CommandHandler.SaveASTRODataProfileCommand.Execute(parameters);
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, true);
				throw;
			}
			num = (short)1280507904;
			short num3 = num;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000061D8 File Offset: 0x000043D8
		protected override void OnSelectedItemsCollectionChanged()
		{
			short num = (short)1368232793;
			short num2 = num;
			num = (short)1166250841;
			switch (num2 == num)
			{
			default:
			{
				num = (short)402325504;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)562233345;
			if (num != 0)
			{
			}
			num = (short)858914816;
			if (num != 0)
			{
			}
			base.OnSelectedItemsCollectionChanged();
			this.ExportDataProfileToFileCommand.RaiseCanExecuteChanged();
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00006290 File Offset: 0x00004490
		private void b(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile A_0)
		{
			int a_ = 11;
			short num;
			try
			{
				num = (short)949161876;
				short num2 = num;
				num = (short)95031188;
				switch (num2 == num)
				{
				}
				num = (short)1017511936;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
				list.Add(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("盛쮩좫잭\udfafﮱ讵", a_) + A_0.DeviceID.ToString());
				list.Add(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("ﮧ쾩\udeab잭톯\udeb1荒쎵햷\ud8b9\ud9bb첽ﶿ", a_) + base.UrlEncode(A_0.SerialNumber));
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.Go(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("睊ﲭ톯횱\uddb3\ud9b5ﲷ\udfb9좻\udfbdꦿ껁럃郅ꇇ꿉믋", a_), list);
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)530513920;
			short num3 = num;
			num = (short)1530396673;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000063CC File Offset: 0x000045CC
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile A_0)
		{
			int a_ = 2;
			short num = (short)1799661376;
			short num2 = num;
			num = (short)1202169664;
			switch (num2 == num)
			{
			default:
			{
				num = (short)645332992;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1739194368;
			if (num != 0)
			{
			}
			num = (short)920453121;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			list.Add(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("\ud89e펠첢키힦邬", a_) + base.UrlEncode(this.a));
			list.Add(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("\udb9e삠힢쒤\udba8쒪쮬욮\uddb0횲ﲴ蒸", a_) + base.UrlEncode(A_0.CustomID));
			list.Add(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("톞삠캢삤骦", a_) + base.UrlEncode(A_0.ProfileName));
			global::Motorola.CommonCPS.RadioManagement.Infrastructure.NavigationHelper.Go(global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("\udb9e삠힢쒤\udba8쒪쮬욮\uddb0횲튶춸\udaba풼펾닀闂계ꋆ뻈", a_), list);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00006508 File Offset: 0x00004708
		private void d()
		{
			short num;
			try
			{
				num = (short)2100981697;
				short num2 = num;
				num = (short)978612161;
				switch (num2 == num)
				{
				}
				num = (short)2023292928;
				if (num != 0)
				{
				}
				base.ServiceProxy.CommandHandler.ExportDataProfileGridToFileCommand.Execute(new object[]
				{
					this.DataProfilesToFileItems.ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>()
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			num = (short)503250944;
			short num3 = num;
			num = (short)1681850369;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000065F8 File Offset: 0x000047F8
		private void c()
		{
			short num = (short)1950670782;
			short num2 = num;
			num = (short)2070273982;
			switch (num2 == num)
			{
			default:
			{
				num = (short)445120512;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1809514496;
			if (num != 0)
			{
			}
			num = (short)1841627137;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.LocalService.RadioCache.Instance.Clear();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x000066B0 File Offset: 0x000048B0
		private bool b()
		{
			short num;
			bool result;
			try
			{
				num = (short)1470809473;
				short num2 = num;
				num = (short)1963115905;
				switch (num2 == num)
				{
				}
				num = (short)1781006336;
				if (num != 0)
				{
				}
				result = base.ServiceProxy.CommandHandler.ExportDataProfileGridToFileCommand.CanExecute(new object[]
				{
					this.DataProfilesToFileItems
				});
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, false, false);
				result = false;
			}
			num = (short)1696071681;
			if (num != 0)
			{
			}
			num = (short)1500053504;
			short num3 = num;
			return result;
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000053 RID: 83 RVA: 0x0000679C File Offset: 0x0000499C
		private global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile> DataProfilesToFileItems
		{
			get
			{
				short num = (short)1214709760;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_30;
						}
						continue;
					case 1:
						goto IL_E0;
					case 2:
					{
						num = (short)400992935;
						short num3 = num;
						num = (short)1795336871;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F4;
						default:
							num = (short)1172373505;
							if (num != 0)
							{
							}
							num = (short)678756352;
							if (num != 0)
							{
							}
							num = (short)62390273;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_30:
					if (base.SelectedItems.Any<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>())
					{
						goto IL_F4;
					}
					num = (short)1287716866;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E0:
				global::System.ComponentModel.ICollectionView items = base.Items;
				if (items == null)
				{
					return null;
				}
				return items.Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile>();
				IL_F4:
				num = (short)1297350656;
				short num4 = num;
				return base.SelectedItems;
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x000068D0 File Offset: 0x00004AD0
		public override void OnNavigatedTo(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			int a_ = 14;
			short num = (short)113377280;
			short num2 = num;
			num = (short)1635527502;
			short num3 = num;
			num = (short)8137550;
			switch (num3 == num)
			{
			}
			num = (short)1215758337;
			if (num != 0)
			{
			}
			num = (short)1436680192;
			if (num != 0)
			{
			}
			base.OnNavigatedTo(navigationContext);
			this.a = navigationContext.Parameters[global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("\udfac삮쒰쎲ﲴ", a_)];
			this.Refresh();
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ActiveMainView = global::Motorola.CommonCPS.RadioManagement.ASTRODataProfile.ModuleASTRODataProfile.b("寧첬쮮\ud8b0\udcb2횶춸\udaba춾껀ꗂ계ꯆ곈룊鯌ꛎ듐ꓒ", a_);
		}

		// Token: 0x0400001D RID: 29
		private string a;

		// Token: 0x0400001E RID: 30
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<global::Motorola.CommonCPS.RadioManagement.UIModels.AstroDataProfile> b;

		// Token: 0x0400001F RID: 31
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand c;

		// Token: 0x04000020 RID: 32
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand d;

		// Token: 0x04000021 RID: 33
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand e;
	}
}
