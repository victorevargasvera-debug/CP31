using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Events;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000040 RID: 64
	public abstract class CachedTableViewModelBase<U> : global::Motorola.CommonCPS.RadioManagement.Infrastructure.TableViewModelBase<U> where U : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
	{
		// Token: 0x06000175 RID: 373 RVA: 0x00015AAC File Offset: 0x00013CAC
		public CachedTableViewModelBase()
		{
		}

		// Token: 0x06000176 RID: 374 RVA: 0x00015AC0 File Offset: 0x00013CC0
		protected CachedTableViewModelBase(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator) : base(eventAggregator)
		{
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00015AD4 File Offset: 0x00013CD4
		protected CachedTableViewModelBase(global::Microsoft.Practices.Prism.Events.IEventAggregator eventAggregator, string aSTRODataProfile_DataProfileDetails) : base(eventAggregator, aSTRODataProfile_DataProfileDetails)
		{
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00015AEC File Offset: 0x00013CEC
		protected override void SaveItem(object[] parameters)
		{
			short num = (short)238878720;
			short num2 = num;
			num = (short)1774358263;
			short num3 = num;
			num = (short)502894327;
			switch (num3 == num)
			{
			}
			num = (short)752091137;
			if (num != 0)
			{
			}
			num = (short)1229062144;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000179 RID: 377 RVA: 0x00015B98 File Offset: 0x00013D98
		protected override void Refresh()
		{
			short num = (short)280494080;
			short num2 = num;
			num = (short)781017748;
			short num3 = num;
			num = (short)1996448404;
			switch (num3 == num)
			{
			}
			num = (short)129564673;
			if (num != 0)
			{
			}
			num = (short)1048576;
			if (num != 0)
			{
			}
			this.LoadItems();
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600017A RID: 378 RVA: 0x00015C48 File Offset: 0x00013E48
		// (set) Token: 0x0600017B RID: 379 RVA: 0x00015CF8 File Offset: 0x00013EF8
		public global::Microsoft.Practices.Prism.Commands.DelegateCommand<U> ShowDetailsCommand
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)973602816;
				short num2 = num;
				num = (short)1378054843;
				short num3 = num;
				num = (short)607154875;
				switch (num3 == num)
				{
				}
				num = (short)663027713;
				if (num != 0)
				{
				}
				num = (short)1172570112;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
				short num = (short)1160314880;
				short num2 = num;
				num = (short)345600120;
				short num3 = num;
				num = (short)1969188984;
				switch (num3 == num)
				{
				}
				num = (short)485556225;
				if (num != 0)
				{
				}
				num = (short)181993472;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x0600017C RID: 380
		protected abstract global::System.ComponentModel.ICollectionView GetItems();

		// Token: 0x0600017D RID: 381 RVA: 0x00015DA8 File Offset: 0x00013FA8
		protected void LoadItems()
		{
			try
			{
				base.Items = this.GetItems();
			}
			catch (global::System.Exception exception)
			{
				global::Motorola.CommonCPS.RadioManagement.Infrastructure.ExceptionHandler.Receive(exception, true, false);
			}
			short num = (short)329777152;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache viewCache;
				object obj;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_51;
					}
					continue;
				case 1:
					return;
				case 2:
					if (viewCache != null)
					{
						num = (short)1131937795;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
				{
					num = (short)389545984;
					short num3 = num;
					base.IsLoadingItemsFromViewCache = true;
					viewCache.ProcessingCompleted += this.a;
					num = (short)1801715713;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					IL_71:
					num = (short)675086337;
					if (num != 0)
					{
					}
					obj = null;
					goto IL_100;
				}
				IL_51:
				global::System.ComponentModel.ICollectionView items = base.Items;
				if (items == null)
				{
					num = (short)297598980;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				obj = items.SourceCollection;
				IL_100:
				viewCache = (obj as global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache);
				num = (short)434367691;
				short num4 = num;
				num = (short)1857023179;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_71;
				default:
					num = (short)625344512;
					if (num != 0)
					{
					}
					num = (short)1420754946;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00015F4C File Offset: 0x0001414C
		private void a(object A_0, global::System.EventArgs A_1)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				global::System.Collections.IEnumerable enumerable;
				global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache viewCache;
				switch (num)
				{
				case 0:
				{
					global::System.ComponentModel.ICollectionView items = base.Items;
					if (items == null)
					{
						num2 = (short)1546452996;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					enumerable = items.SourceCollection;
					goto IL_95;
				}
				case 1:
					goto IL_90;
				case 2:
					if (viewCache != null)
					{
						num2 = (short)590544899;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_151;
				case 3:
					num2 = (short)1658781697;
					if (num2 != 0)
					{
					}
					viewCache.ProcessingCompleted -= this.a;
					num2 = (short)526909441;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					enumerable = null;
					goto IL_95;
				}
				goto IL_24;
				IL_95:
				viewCache = (enumerable as global::Motorola.CommonCPS.RadioManagement.ViewCache.IViewCache);
				num2 = (short)1522513540;
				short num3 = num2;
				num2 = (short)993441412;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_90;
				default:
					num2 = (short)685047808;
					if (num2 != 0)
					{
					}
					num2 = (short)425066498;
					num = (int)((global::System.IntPtr)num2);
					break;
				}
			}
			IL_90:
			IL_151:
			num2 = (short)1646329856;
			short num4 = num2;
			return;
			IL_24:
			base.IsLoadingItemsFromViewCache = false;
			num2 = (short)1346961408;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040000B8 RID: 184
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Microsoft.Practices.Prism.Commands.DelegateCommand<U> a;
	}
}
