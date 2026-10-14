using System;
using System.ComponentModel.Composition;
using System.Runtime.CompilerServices;
using Microsoft.Practices.Prism.Regions;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000003 RID: 3
	[global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.NonShared)]
	[global::System.ComponentModel.Composition.Export(typeof(global::Motorola.CommonCPS.RadioManagement.Infrastructure.AutoPopulateExportedViewsBehavior))]
	public class AutoPopulateExportedViewsBehavior : global::Microsoft.Practices.Prism.Regions.RegionBehavior, global::System.ComponentModel.Composition.IPartImportsSatisfiedNotification
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		// (set) Token: 0x06000005 RID: 5 RVA: 0x000021CC File Offset: 0x000003CC
		[global::System.ComponentModel.Composition.ImportMany(AllowRecomposition = true)]
		public global::System.Lazy<object, global::Motorola.CommonCPS.RadioManagement.Infrastructure.IViewRegionRegistration>[] RegisteredViews
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)375424704;
				short num2 = num;
				num = (short)474187456;
				switch (num2 == num)
				{
				}
				num = (short)2125856769;
				if (num != 0)
				{
				}
				num = (short)1475739648;
				if (num != 0)
				{
				}
				num = (short)1551695872;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1723072513;
				if (num != 0)
				{
				}
				num = (short)918442380;
				short num2 = num;
				num = (short)554914188;
				switch (num2 == num)
				{
				}
				num = (short)932446208;
				if (num != 0)
				{
				}
				num = (short)237568000;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002278 File Offset: 0x00000478
		public void OnImportsSatisfied()
		{
			short num = (short)349664502;
			short num2 = num;
			num = (short)1347319030;
			switch (num2 == num)
			{
			}
			num = (short)1814757377;
			if (num != 0)
			{
			}
			num = (short)1686765568;
			if (num != 0)
			{
			}
			num = (short)1536622592;
			short num3 = num;
			this.a();
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002324 File Offset: 0x00000524
		protected override void OnAttach()
		{
			short num = (short)1158282791;
			short num2 = num;
			num = (short)1780088359;
			switch (num2 == num)
			{
			}
			num = (short)963706881;
			if (num != 0)
			{
			}
			num = (short)1199505408;
			if (num != 0)
			{
			}
			num = (short)854523904;
			short num3 = num;
			this.a();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000023D0 File Offset: 0x000005D0
		private void a()
		{
			short num = (short)1813774336;
			switch (num)
			{
			default:
			{
				num = (short)1632960522;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num4;
					switch (num2)
					{
					case 0:
						goto IL_125;
					case 1:
					{
						num = (short)1351767207;
						short num3 = num;
						num = (short)1127306407;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_263;
						default:
						{
							num = (short)1570111489;
							if (num != 0)
							{
							}
							num = (short)200998912;
							if (num != 0)
							{
							}
							global::System.Lazy<object, global::Motorola.CommonCPS.RadioManagement.Infrastructure.IViewRegionRegistration>[] registeredViews;
							if (num4 >= registeredViews.Length)
							{
								num = (short)503447560;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Lazy<object, global::Motorola.CommonCPS.RadioManagement.Infrastructure.IViewRegionRegistration> lazy = registeredViews[num4];
							num = (short)383254534;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
					{
						global::System.Lazy<object, global::Motorola.CommonCPS.RadioManagement.Infrastructure.IViewRegionRegistration>[] registeredViews = this.RegisteredViews;
						num4 = 0;
						num = (short)453640199;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_92;
					case 4:
					{
						object value;
						base.Region.Add(value);
						goto IL_263;
					}
					case 5:
					{
						global::System.Lazy<object, global::Motorola.CommonCPS.RadioManagement.Infrastructure.IViewRegionRegistration> lazy;
						object value = lazy.Value;
						num = (short)1621622793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::System.Lazy<object, global::Motorola.CommonCPS.RadioManagement.Infrastructure.IViewRegionRegistration> lazy;
						if (lazy.Metadata.RegionName == base.Region.Name)
						{
							num = (short)1138753541;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_92;
					}
					case 7:
						goto IL_125;
					case 8:
						goto IL_1CD;
					case 9:
					{
						object value;
						if (!base.Region.Views.Contains(value))
						{
							num = (short)811008004;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_92;
					}
					case 10:
						switch (0)
						{
						case 0:
							goto IL_70;
						}
						continue;
					}
					IL_70:
					if (base.Region != null)
					{
						num = (short)239206402;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_92:
					num4++;
					num = (short)876412928;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_125:
					num = (short)1426063361;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_263:
					num = (short)628490243;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1CD:
				num = (short)1206583296;
				short num5 = num;
				return;
			}
			}
		}

		// Token: 0x04000003 RID: 3
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Lazy<object, global::Motorola.CommonCPS.RadioManagement.Infrastructure.IViewRegionRegistration>[] a;
	}
}
