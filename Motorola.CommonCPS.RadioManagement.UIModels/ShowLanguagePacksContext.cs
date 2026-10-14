using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq.Expressions;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x0200008F RID: 143
	public class ShowLanguagePacksContext : global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase
	{
		// Token: 0x17000252 RID: 594
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x0004CD9C File Offset: 0x0004AF9C
		// (set) Token: 0x0600052E RID: 1326 RVA: 0x0004CE4C File Offset: 0x0004B04C
		public global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase Radio
		{
			get
			{
				short num = (short)1568163600;
				short num2 = num;
				num = (short)1063208720;
				switch (num2 == num)
				{
				}
				num = (short)1004929024;
				if (num != 0)
				{
				}
				num = (short)2098528257;
				if (num != 0)
				{
				}
				num = (short)1598226432;
				short num3 = num;
				return this.a;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)1286340610;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ShowLanguagePacksContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ShowLanguagePacksContext.get_Radio())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1970274305;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							return;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_38;
							}
							continue;
						case 3:
							this.a = value;
							num = (short)459866113;
							if (num != 0)
							{
							}
							num = (short)1161101316;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							num = (short)265774147;
							short num3 = num;
							num = (short)916153411;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							case 1:
								break;
							default:
							{
								num = (short)1424097280;
								short num4 = num;
								break;
							}
							}
							num = (short)1886519296;
							if (num != 0)
							{
							}
							if (!base.IsLoading)
							{
								num = (short)1020526592;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						}
						IL_38:
						if (this.a == value)
						{
							return;
						}
						num = (short)1079050243;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x0004CFE0 File Offset: 0x0004B1E0
		// (set) Token: 0x06000530 RID: 1328 RVA: 0x0004D08C File Offset: 0x0004B28C
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo> LanguagePacksDetailInfo
		{
			get
			{
				short num = (short)2139070749;
				short num2 = num;
				num = (short)1463001373;
				switch (num2 == num)
				{
				}
				num = (short)1960706049;
				if (num != 0)
				{
				}
				num = (short)2060058624;
				if (num != 0)
				{
				}
				num = (short)1087307776;
				short num3 = num;
				return this.b;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)1916600322;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)12713985;
							if (num != 0)
							{
							}
							base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ShowLanguagePacksContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ShowLanguagePacksContext.get_LanguagePacksDetailInfo())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)2137260033;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							return;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_39;
							}
							continue;
						case 3:
							this.b = value;
							num = (short)1126825988;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							num = (short)845020065;
							short num3 = num;
							num = (short)856947617;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num = (short)839778304;
								short num4 = num;
								num = (short)214106112;
								if (num != 0)
								{
								}
								if (!base.IsLoading)
								{
									num = (short)6619136;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								return;
							}
							}
							break;
						}
						}
						IL_39:
						if (this.b == value)
						{
							return;
						}
						num = (short)1080360963;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000531 RID: 1329 RVA: 0x0004D224 File Offset: 0x0004B424
		public int TotalSize
		{
			get
			{
				short num = (short)1407254530;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo> enumerator;
					int num3;
					switch (num2)
					{
					case 0:
						return 0;
					case 1:
						try
						{
							num = (short)17694722;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_111;
								case 1:
									num = (short)490602496;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_95;
									}
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1236008961;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo languageDetailInfo = enumerator.Current;
									num3 += int.Parse(languageDetailInfo.PackageSize, global::System.Globalization.CultureInfo.CurrentCulture);
									num = (short)800391172;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_97:
								num = (short)748945411;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_95:
								goto IL_97;
							}
							IL_111:
							return num3;
						}
						finally
						{
							num = (short)285671425;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								num = (short)329646081;
								if (num != 0)
								{
								}
								switch (num2)
								{
								case 0:
									goto IL_1F1;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_16C;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1603403776;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_16C:
								num = (short)1856769480;
								short num4 = num;
								num = (short)131206600;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1F3;
								default:
									num = (short)253689856;
									if (num != 0)
									{
									}
									if (enumerator == null)
									{
										goto IL_1F3;
									}
									num = (short)1886846978;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_1F1:
							IL_1F3:;
						}
						goto IL_1F4;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 3:
						num = (short)453836804;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (this.b.Count == 0)
						{
							num = (short)713097216;
							short num5 = num;
							num = (short)996605952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F4;
					}
					IL_38:
					if (this.b != null)
					{
						num = (short)1755054083;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_1F4:
					num3 = 0;
					enumerator = this.b.GetEnumerator();
					num = (short)1887109121;
					num2 = (int)((global::System.IntPtr)num);
				}
				return 0;
			}
		}

		// Token: 0x0400026C RID: 620
		private global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase a;

		// Token: 0x0400026D RID: 621
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo> b;
	}
}
