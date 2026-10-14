using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq.Expressions;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x0200004F RID: 79
	public class ShowTemplateVAPacksContext : global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase
	{
		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000236 RID: 566 RVA: 0x00022958 File Offset: 0x00020B58
		// (set) Token: 0x06000237 RID: 567 RVA: 0x00022A08 File Offset: 0x00020C08
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceDetailInfo> VAPacksDetailInfo
		{
			get
			{
				short num = (short)1313210368;
				short num2 = num;
				num = (short)568701500;
				short num3 = num;
				num = (short)1894887996;
				switch (num3 == num)
				{
				}
				num = (short)1109721089;
				if (num != 0)
				{
				}
				num = (short)741605376;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)204406784;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1294991360;
						short num3 = num;
						switch (0)
						{
						case 0:
							goto IL_61;
						}
						continue;
					}
					case 1:
						if (!base.IsLoading)
						{
							num = (short)1711996932;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						return;
					case 3:
					{
						num = (short)1359083082;
						short num4 = num;
						num = (short)958199370;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)271450112;
							if (num != 0)
							{
							}
							num = (short)2105016321;
							if (num != 0)
							{
							}
							this.a = value;
							num = (short)1472266241;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceDetailInfo>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceDetailInfo>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ShowTemplateVAPacksContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ShowTemplateVAPacksContext.get_VAPacksDetailInfo())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)125829122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_61:
					if (this.a == value)
					{
						break;
					}
					num = (short)1714356227;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00022B9C File Offset: 0x00020D9C
		public int TotalSize
		{
			get
			{
				short num = (short)600768512;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)525795328;
					short num3 = num;
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceDetailInfo> enumerator;
					int num5;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_61;
						}
						continue;
					case 1:
						num = (short)1323302913;
						if (num != 0)
						{
						}
						if (this.a.Count == 0)
						{
							num = (short)207683588;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F3;
					case 2:
						goto IL_86;
						try
						{
							for (;;)
							{
								IL_86:
								num = (short)1148321792;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										num = (short)1202718368;
										short num4 = num;
										num = (short)873531040;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_86;
										default:
											num = (short)282066944;
											if (num != 0)
											{
											}
											switch (0)
											{
											case 0:
												goto IL_109;
											}
											continue;
										}
										break;
									}
									case 2:
										num = (short)845479940;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1510211586;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceDetailInfo voiceDetailInfo = enumerator.Current;
										num5 += int.Parse(voiceDetailInfo.PackageSize, global::System.Globalization.CultureInfo.CurrentCulture);
										num = (short)1451819009;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										goto IL_187;
									}
									IL_10B:
									num = (short)914489347;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_109:
									goto IL_10B;
								}
							}
							IL_187:
							return num5;
						}
						finally
						{
							num = (short)478871553;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)301596674;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1BD;
									}
									continue;
								case 2:
									goto IL_1F0;
								}
								IL_1BD:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1371930624;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1F0:;
						}
						goto IL_1F3;
					case 3:
						num = (short)247201793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						return 0;
					}
					IL_61:
					if (this.a != null)
					{
						num = (short)1742077955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_1F3:
					num5 = 0;
					enumerator = this.a.GetEnumerator();
					num = (short)280690690;
					num2 = (int)((global::System.IntPtr)num);
				}
				return 0;
			}
		}

		// Token: 0x040000EA RID: 234
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceDetailInfo> a;
	}
}
