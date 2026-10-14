using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq.Expressions;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x0200004E RID: 78
	public class ShowTemplateLanguagePacksContext : global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase
	{
		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000232 RID: 562 RVA: 0x0002244C File Offset: 0x0002064C
		// (set) Token: 0x06000233 RID: 563 RVA: 0x000224FC File Offset: 0x000206FC
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo> LanguagePacksDetailInfo
		{
			get
			{
				short num = (short)561643520;
				short num2 = num;
				num = (short)1880801516;
				short num3 = num;
				num = (short)703774956;
				switch (num3 == num)
				{
				}
				num = (short)1880489985;
				if (num != 0)
				{
				}
				num = (short)444727296;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)803405824;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1046413312;
						short num3 = num;
						switch (0)
						{
						case 0:
							goto IL_62;
						}
						continue;
					}
					case 1:
						if (!base.IsLoading)
						{
							num = (short)1844510724;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						return;
					case 3:
					{
						num = (short)418467930;
						short num4 = num;
						num = (short)863391834;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)346423296;
							if (num != 0)
							{
							}
							this.a = value;
							num = (short)1010630657;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						num = (short)764608513;
						if (num != 0)
						{
						}
						base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ShowTemplateLanguagePacksContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ShowTemplateLanguagePacksContext.get_LanguagePacksDetailInfo())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)270073858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_62:
					if (this.a == value)
					{
						break;
					}
					num = (short)1426194435;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000234 RID: 564 RVA: 0x00022694 File Offset: 0x00020894
		public int TotalSize
		{
			get
			{
				short num = (short)2082668544;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)363593728;
					short num3 = num;
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo> enumerator;
					int num5;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_62;
						}
						continue;
					case 1:
						if (this.a.Count == 0)
						{
							num = (short)1333657604;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21A;
					case 2:
						goto IL_B0;
						try
						{
							for (;;)
							{
								IL_B0:
								num = (short)1576861696;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										num = (short)703062978;
										short num4 = num;
										num = (short)1639572418;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_B0;
										default:
											num = (short)1544617984;
											if (num != 0)
											{
											}
											switch (0)
											{
											case 0:
												goto IL_131;
											}
											continue;
										}
										break;
									}
									case 2:
										num = (short)1420099588;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)987365378;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo languageDetailInfo = enumerator.Current;
										num5 += int.Parse(languageDetailInfo.PackageSize, global::System.Globalization.CultureInfo.CurrentCulture);
										num = (short)424738817;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										goto IL_1AE;
									}
									IL_133:
									num = (short)883752963;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_131:
									goto IL_133;
								}
							}
							IL_1AE:
							return num5;
						}
						finally
						{
							num = (short)377028609;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)339279874;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1E3;
									}
									continue;
								case 2:
									goto IL_217;
								}
								IL_1E3:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1030750208;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_217:;
						}
						goto IL_21A;
					case 3:
						num = (short)1344733185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						return 0;
					}
					IL_62:
					num = (short)1667694593;
					if (num != 0)
					{
					}
					if (this.a != null)
					{
						num = (short)296484867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_21A:
					num5 = 0;
					enumerator = this.a.GetEnumerator();
					num = (short)2012020738;
					num2 = (int)((global::System.IntPtr)num);
				}
				return 0;
			}
		}

		// Token: 0x040000E9 RID: 233
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo> a;
	}
}
