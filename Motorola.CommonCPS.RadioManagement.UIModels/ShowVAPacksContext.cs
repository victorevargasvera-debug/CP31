using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq.Expressions;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x0200008E RID: 142
	public class ShowVAPacksContext : global::Motorola.CommonCPS.RadioManagement.UIModels.ContextBase
	{
		// Token: 0x1700024F RID: 591
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x0004C644 File Offset: 0x0004A844
		// (set) Token: 0x06000528 RID: 1320 RVA: 0x0004C6F4 File Offset: 0x0004A8F4
		public global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase Radio
		{
			get
			{
				short num = (short)887816193;
				if (num != 0)
				{
				}
				num = (short)549440353;
				short num2 = num;
				num = (short)1184222049;
				switch (num2 == num)
				{
				}
				num = (short)468254720;
				if (num != 0)
				{
				}
				num = (short)567214080;
				short num3 = num;
				return this.a;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)366608386;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ShowVAPacksContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ShowVAPacksContext.get_Radio())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1818230785;
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
							this.a = value;
							num = (short)896860164;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							num = (short)1161442470;
							short num3 = num;
							num = (short)764621990;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num = (short)567345152;
								short num4 = num;
								num = (short)1977679872;
								if (num != 0)
								{
								}
								num = (short)1661468673;
								if (num != 0)
								{
								}
								if (!base.IsLoading)
								{
									num = (short)144179200;
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
						if (this.a == value)
						{
							return;
						}
						num = (short)654573571;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x06000529 RID: 1321 RVA: 0x0004C890 File Offset: 0x0004AA90
		// (set) Token: 0x0600052A RID: 1322 RVA: 0x0004C940 File Offset: 0x0004AB40
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceDetailInfo> VAPacksDetailInfo
		{
			get
			{
				short num = (short)1929194275;
				short num2 = num;
				num = (short)485174051;
				switch (num2 == num)
				{
				}
				num = (short)1017839617;
				if (num != 0)
				{
				}
				num = (short)1084227584;
				if (num != 0)
				{
				}
				num = (short)1161363456;
				short num3 = num;
				return this.b;
			}
			set
			{
				for (;;)
				{
					IL_00:
					short num = (short)382664706;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceDetailInfo>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceDetailInfo>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.ShowVAPacksContext)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.ShowVAPacksContext.get_VAPacksDetailInfo())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1077870593;
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
							this.b = value;
							num = (short)491585540;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							num = (short)1541367780;
							short num3 = num;
							num = (short)1153460196;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							case 1:
								break;
							default:
							{
								num = (short)1839661056;
								short num4 = num;
								break;
							}
							}
							num = (short)1924464640;
							if (num != 0)
							{
							}
							if (!base.IsLoading)
							{
								num = (short)539492352;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						}
						IL_38:
						num = (short)797966337;
						if (num != 0)
						{
						}
						if (this.b == value)
						{
							return;
						}
						num = (short)768671747;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x0600052B RID: 1323 RVA: 0x0004CADC File Offset: 0x0004ACDC
		public int TotalSize
		{
			get
			{
				short num = (short)2117664770;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceDetailInfo> enumerator;
					int num3;
					switch (num2)
					{
					case 0:
						return 0;
					case 1:
						try
						{
							num = (short)200212482;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_13E;
								case 1:
									num = (short)993656832;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_BD;
									}
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)406257665;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceDetailInfo voiceDetailInfo = enumerator.Current;
									num3 += int.Parse(voiceDetailInfo.PackageSize, global::System.Globalization.CultureInfo.CurrentCulture);
									num = (short)1626931204;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_BF:
								num = (short)1551171587;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_BD:
								goto IL_BF;
							}
							IL_13E:
							return num3;
						}
						finally
						{
							num = (short)1022885889;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1F7;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_173;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)343670784;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_173:
								num = (short)715652667;
								short num4 = num;
								num = (short)548863547;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1F9;
								default:
									num = (short)2036662272;
									if (num != 0)
									{
									}
									if (enumerator == null)
									{
										goto IL_1F9;
									}
									num = (short)1960050690;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_1F7:
							IL_1F9:;
						}
						goto IL_1FA;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_38;
						}
						continue;
					case 3:
					{
						num = (short)1514733568;
						short num5 = num;
						num = (short)1905393668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)434438145;
						if (num != 0)
						{
						}
						if (this.b.Count == 0)
						{
							num = (short)841744384;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FA;
					}
					IL_38:
					if (this.b != null)
					{
						num = (short)1047396355;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_1FA:
					num3 = 0;
					enumerator = this.b.GetEnumerator();
					num = (short)1452605441;
					num2 = (int)((global::System.IntPtr)num);
				}
				return 0;
			}
		}

		// Token: 0x0400026A RID: 618
		private global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase a;

		// Token: 0x0400026B RID: 619
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceDetailInfo> b;
	}
}
