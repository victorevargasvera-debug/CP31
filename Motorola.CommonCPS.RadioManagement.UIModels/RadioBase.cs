using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.CommonBase;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000C6 RID: 198
	public abstract class RadioBase : global::Motorola.CommonCPS.RadioManagement.UIModels.EntityWrapper<global::Motorola.CommonCPS.Server.EntityModel.RadioSummary>
	{
		// Token: 0x06000858 RID: 2136 RVA: 0x0007CF34 File Offset: 0x0007B134
		private RadioBase() : base(null)
		{
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x0007CF54 File Offset: 0x0007B154
		protected RadioBase(string deviceIdentifier, global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummaryEntity) : base(radioSummaryEntity)
		{
			this.b = deviceIdentifier;
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x0600085A RID: 2138 RVA: 0x0007CF7C File Offset: 0x0007B17C
		// (set) Token: 0x0600085B RID: 2139 RVA: 0x0007D028 File Offset: 0x0007B228
		public string EditingField
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1281153128;
				short num2 = num;
				num = (short)348248168;
				switch (num2 == num)
				{
				}
				num = (short)1811283969;
				if (num != 0)
				{
				}
				num = (short)263520256;
				short num3 = num;
				num = (short)817102848;
				if (num != 0)
				{
				}
				return this.n;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)434799944;
				short num2 = num;
				num = (short)1450083656;
				switch (num2 == num)
				{
				}
				num = (short)325779456;
				if (num != 0)
				{
				}
				num = (short)1891106816;
				short num3 = num;
				num = (short)462159873;
				if (num != 0)
				{
				}
				this.n = value;
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x0007D0D8 File Offset: 0x0007B2D8
		protected global::Motorola.CommonCPS.Server.EntityModel.RadioSummary RadioSummaryEntity
		{
			get
			{
				short num = (short)610296565;
				short num2 = num;
				num = (short)28861173;
				switch (num2 == num)
				{
				}
				num = (short)156958721;
				if (num != 0)
				{
				}
				num = (short)20643840;
				short num3 = num;
				num = (short)183894016;
				if (num != 0)
				{
				}
				return base.Entity;
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x0600085D RID: 2141 RVA: 0x0007D188 File Offset: 0x0007B388
		// (set) Token: 0x0600085E RID: 2142 RVA: 0x0007D238 File Offset: 0x0007B438
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool SuppressIPConvert
		{
			get
			{
				short num = (short)2082595368;
				short num2 = num;
				num = (short)1173938728;
				switch (num2 == num)
				{
				}
				num = (short)1012072449;
				if (num != 0)
				{
				}
				num = (short)1258160128;
				short num3 = num;
				num = (short)1879113728;
				if (num != 0)
				{
				}
				return this.i;
			}
			set
			{
				short num = (short)468039534;
				short num2 = num;
				num = (short)1324201838;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_C3:
					num = (short)777388033;
					if (num != 0)
					{
					}
					this.i = value;
					num = (short)716046337;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
				{
					num = (short)127336448;
					short num4 = num;
					num = (short)186580992;
					if (num != 0)
					{
					}
					num = (short)1552613376;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_A4;
						}
						continue;
					case 1:
						return;
					case 2:
						goto IL_C1;
					}
					IL_A4:
					if (this.i == value)
					{
						return;
					}
					num = (short)2023817218;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_C1:
				goto IL_C3;
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x0007D34C File Offset: 0x0007B54C
		// (set) Token: 0x06000860 RID: 2144 RVA: 0x0007D424 File Offset: 0x0007B624
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? ProductFamily
		{
			get
			{
				int? productFamily;
				short num;
				for (;;)
				{
					productFamily = this.RadioSummaryEntity.ProductFamily;
					if (productFamily == null)
					{
						break;
					}
					num = (short)412862348;
					short num2 = num;
					num = (short)165857164;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_7D;
					}
				}
				num = (short)736559105;
				if (num != 0)
				{
				}
				return null;
				IL_7D:
				num = (short)1965096960;
				if (num != 0)
				{
				}
				num = (short)883621888;
				short num3 = num;
				return new global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily?((global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily)productFamily.GetValueOrDefault());
			}
			set
			{
				short num = (short)1351614464;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_4E;
					}
					int? num3;
					global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily5;
					for (;;)
					{
						IL_27:
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily;
						global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily3;
						switch (num2)
						{
						case 0:
							productFamily = new global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily?((global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily)num3.GetValueOrDefault());
							goto IL_EC;
						case 1:
							return;
						case 2:
							num = (short)937099270;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily2 = null;
							num = (short)1653866501;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							if (num3 == null)
							{
								num = (short)48758787;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)904724480;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily2;
							productFamily = productFamily2;
							goto IL_EC;
						}
						case 6:
						{
							global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummaryEntity = this.RadioSummaryEntity;
							productFamily3 = value;
							int? productFamily4;
							if (productFamily3 == null)
							{
								num3 = null;
								productFamily4 = num3;
							}
							else
							{
								productFamily4 = new int?((int)productFamily3.GetValueOrDefault());
							}
							radioSummaryEntity.ProductFamily = productFamily4;
							base.RaisePropertyChanged<global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase.get_ProductFamily())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)215470390;
							short num4 = num;
							num = (short)1993593142;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								return;
							default:
							{
								num = (short)1570635776;
								if (num != 0)
								{
								}
								num = (short)1431764992;
								short num5 = num;
								num = (short)1032781825;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 7:
							num = (short)979763201;
							if (num != 0)
							{
							}
							if (!(productFamily5.GetValueOrDefault() == productFamily3.GetValueOrDefault() & productFamily5 != null == (productFamily3 != null)))
							{
								num = (short)1068826626;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						goto IL_4E;
						IL_EC:
						productFamily3 = productFamily;
						num = (short)64880647;
						num2 = (int)((global::System.IntPtr)num);
					}
					return;
					IL_4E:
					productFamily5 = value;
					num3 = this.RadioSummaryEntity.ProductFamily;
					num = (short)1663041540;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06000861 RID: 2145 RVA: 0x0007D6B0 File Offset: 0x0007B8B0
		// (set) Token: 0x06000862 RID: 2146 RVA: 0x0007D760 File Offset: 0x0007B960
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool MismatchFlags
		{
			get
			{
				short num = (short)466293507;
				short num2 = num;
				num = (short)590877443;
				switch (num2 == num)
				{
				}
				num = (short)2061828096;
				if (num != 0)
				{
				}
				num = (short)946012160;
				short num3 = num;
				num = (short)671219713;
				if (num != 0)
				{
				}
				return this.k;
			}
			set
			{
				short num = (short)1140335529;
				short num2 = num;
				num = (short)1408705449;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_E9:
					this.k = value;
					base.RaisePropertyChanged<bool>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase.get_MismatchFlags())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)1767374849;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
				{
					num = (short)1230831616;
					short num4 = num;
					num = (short)796262400;
					if (num != 0)
					{
					}
					num = (short)1985675264;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_A2;
						}
						continue;
					case 1:
						return;
					case 2:
						goto IL_E7;
					}
					IL_A2:
					num = (short)1071579137;
					if (num != 0)
					{
					}
					if (value == this.k)
					{
						return;
					}
					num = (short)1189216258;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_E7:
				goto IL_E9;
			}
		}

		// Token: 0x170003F1 RID: 1009
		// (get) Token: 0x06000863 RID: 2147 RVA: 0x0007D8AC File Offset: 0x0007BAAC
		// (set) Token: 0x06000864 RID: 2148 RVA: 0x0007D95C File Offset: 0x0007BB5C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSet> MismatchOptionList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)172721949;
				short num2 = num;
				num = (short)1847953181;
				switch (num2 == num)
				{
				}
				num = (short)2048393217;
				if (num != 0)
				{
				}
				num = (short)758972416;
				short num3 = num;
				num = (short)1243348992;
				if (num != 0)
				{
				}
				return this.o;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)553302687;
				short num2 = num;
				num = (short)1617279647;
				switch (num2 == num)
				{
				}
				num = (short)1992097793;
				if (num != 0)
				{
				}
				num = (short)211615744;
				short num3 = num;
				num = (short)749862912;
				if (num != 0)
				{
				}
				this.o = value;
			}
		}

		// Token: 0x170003F2 RID: 1010
		// (get) Token: 0x06000865 RID: 2149 RVA: 0x0007DA10 File Offset: 0x0007BC10
		// (set) Token: 0x06000866 RID: 2150 RVA: 0x0007DAC0 File Offset: 0x0007BCC0
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus> RadioFeatureSet
		{
			get
			{
				short num = (short)994436275;
				short num2 = num;
				num = (short)822011059;
				switch (num2 == num)
				{
				}
				num = (short)253755393;
				if (num != 0)
				{
				}
				num = (short)922222592;
				short num3 = num;
				num = (short)152829952;
				if (num != 0)
				{
				}
				return this.p;
			}
			set
			{
				short num = (short)1355087873;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_104;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_36;
						}
						continue;
					case 2:
					{
						num = (short)2026782157;
						short num3 = num;
						num = (short)472923597;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_93;
						default:
							num = (short)1722941440;
							if (num != 0)
							{
							}
							this.p = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus>(value);
							num = (short)2096758784;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						goto IL_93;
					}
					IL_36:
					if (value != null)
					{
						num = (short)1957363714;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						this.p = value;
						num = (short)950992896;
						short num4 = num;
						num = (short)776994819;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_93:
				IL_104:
				num = (short)45416449;
				if (num != 0)
				{
				}
				base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase.get_RadioFeatureSet())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x170003F3 RID: 1011
		// (get) Token: 0x06000867 RID: 2151 RVA: 0x0007DC30 File Offset: 0x0007BE30
		// (set) Token: 0x06000868 RID: 2152 RVA: 0x0007DCE0 File Offset: 0x0007BEE0
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus> ExtendedRadioFeatureSet
		{
			get
			{
				short num = (short)477860498;
				short num2 = num;
				num = (short)1930072722;
				switch (num2 == num)
				{
				}
				num = (short)2066284545;
				if (num != 0)
				{
				}
				num = (short)1711013888;
				short num3 = num;
				num = (short)1526005760;
				if (num != 0)
				{
				}
				return this.q;
			}
			set
			{
				short num = (short)431030273;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_12C;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_34;
						}
						continue;
					case 2:
					{
						num = (short)519859672;
						short num3 = num;
						num = (short)225471960;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_BB;
						default:
							num = (short)734855168;
							if (num != 0)
							{
							}
							this.q = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus>(value);
							num = (short)860553216;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						goto IL_BB;
					}
					IL_34:
					num = (short)1140588545;
					if (num != 0)
					{
					}
					if (value != null)
					{
						num = (short)1063059458;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)695861248;
						short num4 = num;
						this.q = value;
						num = (short)922746883;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_BB:
				IL_12C:
				base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase.get_ExtendedRadioFeatureSet())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x170003F4 RID: 1012
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x0007DE50 File Offset: 0x0007C050
		// (set) Token: 0x0600086A RID: 2154 RVA: 0x0007DF00 File Offset: 0x0007C100
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus> UIRadioFeatureSet
		{
			get
			{
				short num = (short)369098753;
				if (num != 0)
				{
				}
				num = (short)525911849;
				short num2 = num;
				num = (short)581551913;
				switch (num2 == num)
				{
				}
				num = (short)672399360;
				short num3 = num;
				num = (short)1327431680;
				if (num != 0)
				{
				}
				return this.r;
			}
			set
			{
				short num = (short)124387329;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_12D;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_34;
						}
						continue;
					case 2:
					{
						num = (short)2116790286;
						short num3 = num;
						num = (short)86026254;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_BC;
						default:
							num = (short)1085079552;
							if (num != 0)
							{
							}
							this.r = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus>(value);
							num = (short)350486528;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						goto IL_BC;
					}
					IL_34:
					if (value != null)
					{
						num = (short)701693954;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)991100929;
						if (num != 0)
						{
						}
						num = (short)1293352960;
						short num4 = num;
						this.r = value;
						num = (short)295174147;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_BC:
				IL_12D:
				base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase.get_UIRadioFeatureSet())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x170003F5 RID: 1013
		// (get) Token: 0x0600086B RID: 2155 RVA: 0x0007E070 File Offset: 0x0007C270
		// (set) Token: 0x0600086C RID: 2156 RVA: 0x0007E120 File Offset: 0x0007C320
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus> UIExtendedRadioFeatureSet
		{
			get
			{
				short num = (short)1979514881;
				if (num != 0)
				{
				}
				num = (short)84507448;
				short num2 = num;
				num = (short)304708408;
				switch (num2 == num)
				{
				}
				num = (short)2087518208;
				short num3 = num;
				num = (short)1680605184;
				if (num != 0)
				{
				}
				return this.s;
			}
			set
			{
				short num = (short)853082113;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_12E;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_34;
						}
						continue;
					case 2:
					{
						num = (short)282084142;
						short num3 = num;
						num = (short)7029550;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_93;
						default:
							num = (short)1769799680;
							if (num != 0)
							{
							}
							num = (short)663814145;
							if (num != 0)
							{
							}
							this.s = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus>(value);
							num = (short)960430080;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						goto IL_93;
					}
					IL_34:
					if (value != null)
					{
						num = (short)1468137474;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						this.s = value;
						num = (short)461897728;
						short num4 = num;
						num = (short)127139843;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_93:
				IL_12E:
				base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase.get_UIExtendedRadioFeatureSet())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x0600086D RID: 2157 RVA: 0x0007E294 File Offset: 0x0007C494
		// (set) Token: 0x0600086E RID: 2158 RVA: 0x0007E340 File Offset: 0x0007C540
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::System.Collections.Generic.List<int> ConfigurationOptionList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)276630115;
				short num2 = num;
				num = (short)1143671395;
				switch (num2 == num)
				{
				}
				num = (short)1170276353;
				if (num != 0)
				{
				}
				num = (short)1532035072;
				short num3 = num;
				num = (short)762970112;
				if (num != 0)
				{
				}
				return this.t;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1313324465;
				short num2 = num;
				num = (short)856604081;
				switch (num2 == num)
				{
				}
				num = (short)360382465;
				if (num != 0)
				{
				}
				num = (short)2093678592;
				short num3 = num;
				num = (short)56492032;
				if (num != 0)
				{
				}
				this.t = value;
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x0600086F RID: 2159 RVA: 0x0007E3F4 File Offset: 0x0007C5F4
		// (set) Token: 0x06000870 RID: 2160 RVA: 0x0007E4A8 File Offset: 0x0007C6A8
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection RadioOptionCollection
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1734028342;
				short num2 = num;
				num = (short)1202269238;
				switch (num2 == num)
				{
				}
				num = (short)2109472768;
				if (num != 0)
				{
				}
				num = (short)402784256;
				short num3 = num;
				num = (short)1136394241;
				if (num != 0)
				{
				}
				return this.u;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)862726764;
				short num2 = num;
				num = (short)614804076;
				switch (num2 == num)
				{
				}
				num = (short)1236140032;
				if (num != 0)
				{
				}
				num = (short)1132527616;
				short num3 = num;
				num = (short)1075642369;
				if (num != 0)
				{
				}
				this.u = value;
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000871 RID: 2161 RVA: 0x0007E558 File Offset: 0x0007C758
		// (set) Token: 0x06000872 RID: 2162 RVA: 0x0007E60C File Offset: 0x0007C80C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("CodeplugVersion")]
		public string CodeplugVersion
		{
			get
			{
				short num = (short)134291045;
				short num2 = num;
				num = (short)697966181;
				switch (num2 == num)
				{
				}
				num = (short)1317208064;
				if (num != 0)
				{
				}
				num = (short)1240989696;
				short num3 = num;
				num = (short)1681063937;
				if (num != 0)
				{
				}
				return this.RadioSummaryEntity.CodeplugVersion;
			}
			set
			{
				short num = (short)1587216386;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)771424256;
						short num3 = num;
						goto IL_12B;
					}
					case 1:
					{
						this.RadioSummaryEntity.CodeplugVersion = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase.get_CodeplugVersion())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1972285093;
						short num4 = num;
						num = (short)1832758949;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_142;
						default:
							num = (short)1362231296;
							if (num != 0)
							{
							}
							num = (short)1174077444;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_3D;
						}
						continue;
					case 3:
						value = string.Empty;
						num = (short)741277696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						return;
					case 5:
						goto IL_142;
					}
					IL_3D:
					num = (short)1585971201;
					if (num != 0)
					{
					}
					if (value == null)
					{
						num = (short)1876754435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_12B:
					num = (short)1629028357;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_142:
					if (!(value != this.RadioSummaryEntity.CodeplugVersion))
					{
						break;
					}
					num = (short)1425801217;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000873 RID: 2163 RVA: 0x0007E7D8 File Offset: 0x0007C9D8
		// (set) Token: 0x06000874 RID: 2164 RVA: 0x0007E88C File Offset: 0x0007CA8C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::System.Guid DeviceUuid
		{
			get
			{
				short num = (short)1750441678;
				short num2 = num;
				num = (short)1677106894;
				switch (num2 == num)
				{
				}
				num = (short)922025984;
				if (num != 0)
				{
				}
				num = (short)1521876992;
				short num3 = num;
				num = (short)1495203841;
				if (num != 0)
				{
				}
				return this.RadioSummaryEntity.Uuid;
			}
			set
			{
				short num = (short)1580023612;
				short num2 = num;
				num = (short)893992764;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_F5:
					this.RadioSummaryEntity.Uuid = value;
					base.RaisePropertyChanged<global::System.Guid>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Guid>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase.get_DeviceUuid())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)1265762305;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
				{
					num = (short)1892155392;
					short num4 = num;
					num = (short)700383232;
					if (num != 0)
					{
					}
					num = (short)1310916608;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						num = (short)236191745;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_CC;
						}
						continue;
					case 1:
						return;
					case 2:
						goto IL_F3;
					}
					IL_CC:
					if (!(value != this.RadioSummaryEntity.Uuid))
					{
						return;
					}
					num = (short)1481244674;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_F3:
				goto IL_F5;
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x0007E9E8 File Offset: 0x0007CBE8
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x0007EAA0 File Offset: 0x0007CCA0
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string DeviceID
		{
			get
			{
				short num = (short)1535821201;
				short num2 = num;
				num = (short)1025492369;
				switch (num2 == num)
				{
				}
				num = (short)187039744;
				if (num != 0)
				{
				}
				num = (short)600702976;
				short num3 = num;
				num = (short)675545089;
				if (num != 0)
				{
				}
				return this.RadioSummaryEntity.DeviceID;
			}
			set
			{
				short num = (short)1188821409;
				short num2 = num;
				num = (short)743963041;
				int num3;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_D2:
					this.RadioSummaryEntity.DeviceID = value;
					base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase.get_DeviceID())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
					num = (short)1381105665;
					if (num != 0)
					{
					}
					num = (short)268042241;
					num3 = (int)((global::System.IntPtr)num);
					break;
				default:
				{
					num = (short)544931840;
					short num4 = num;
					num = (short)1353515008;
					if (num != 0)
					{
					}
					num = (short)473038848;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
				}
				for (;;)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_A6;
						}
						continue;
					case 1:
						return;
					case 2:
						goto IL_D0;
					}
					IL_A6:
					if (!(value != this.RadioSummaryEntity.DeviceID))
					{
						return;
					}
					num = (short)1269563394;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_D0:
				goto IL_D2;
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x0007EC00 File Offset: 0x0007CE00
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x0007ECBC File Offset: 0x0007CEBC
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string DeviceIdentifier
		{
			get
			{
				short num = (short)1218234696;
				short num2 = num;
				num = (short)1717291336;
				switch (num2 == num)
				{
				}
				num = (short)1737621504;
				if (num != 0)
				{
				}
				num = (short)451018752;
				short num3 = num;
				num = (short)906756097;
				if (num != 0)
				{
				}
				return this.b ?? string.Empty;
			}
			set
			{
				short num = (short)366411777;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1155475984;
					short num3 = num;
					num = (short)578955792;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)202768384;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							num = (short)535887873;
							if (num != 0)
							{
							}
							if (value != this.b)
							{
								goto IL_13C;
							}
							return;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_81;
							}
							continue;
						case 2:
							num = (short)749993984;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							this.b = value;
							num = (short)56819712;
							short num4 = num;
							num = (short)840499204;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							return;
						}
						IL_81:
						if (this.b != null)
						{
							num = (short)1534853122;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_13C:
					num = (short)1616707587;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x0007EE24 File Offset: 0x0007D024
		// (set) Token: 0x0600087A RID: 2170 RVA: 0x0007F034 File Offset: 0x0007D234
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("FirmwareVersion")]
		public string FirmwareVersion
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_30;
				}
				int num;
				short num2;
				global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)555614208;
						short num3 = num2;
						productFamily = this.ProductFamily;
						num2 = (short)1013121031;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 1:
						if (productFamily.Value != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.MNIS)
						{
							num2 = (short)137822208;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1F0;
					case 2:
						goto IL_74;
					case 3:
						productFamily = this.ProductFamily;
						num2 = (short)2102198273;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						if (productFamily != null)
						{
							num2 = (short)2949123;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1F6;
					case 5:
					{
						if (productFamily.Value != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.DMR3Controller)
						{
							goto IL_1F6;
						}
						num2 = (short)346667008;
						short num4 = num2;
						num2 = (short)1464317952;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_74;
						default:
							num2 = (short)1762590720;
							if (num2 != 0)
							{
							}
							num2 = (short)2114650118;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 6:
						goto IL_12C;
					case 7:
						if (productFamily.Value != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.VRC)
						{
							num2 = (short)1349386242;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1F0;
					}
					goto IL_30;
					IL_74:
					productFamily = this.ProductFamily;
					num2 = (short)429522945;
					if (num2 != 0)
					{
					}
					num2 = (short)1546125317;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_12C:
				IL_1F0:
				return global::Motorola.CommonCPS.ResourceRepository.Resources.Not_Applicable;
				IL_1F6:
				return this.RadioSummaryEntity.FirmwareVersion;
				IL_30:
				productFamily = this.ProductFamily;
				num2 = (short)348192772;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			set
			{
				short num = (short)1721827330;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)465698816;
						short num3 = num;
						goto IL_134;
					}
					case 1:
					{
						this.RadioSummaryEntity.FirmwareVersion = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase.get_FirmwareVersion())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)956366849;
						if (num != 0)
						{
						}
						num = (short)1448039680;
						short num4 = num;
						num = (short)473650432;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_14B;
						default:
							num = (short)1203896320;
							if (num != 0)
							{
							}
							num = (short)759103492;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_3E;
						}
						continue;
					case 3:
						value = string.Empty;
						num = (short)1433010176;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						return;
					case 5:
						goto IL_14B;
					}
					IL_3E:
					if (string.IsNullOrEmpty(value))
					{
						num = (short)468058115;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_134:
					num = (short)526123013;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_14B:
					if (!(value != this.RadioSummaryEntity.FirmwareVersion))
					{
						break;
					}
					num = (short)806420481;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x0007F208 File Offset: 0x0007D408
		// (set) Token: 0x0600087C RID: 2172 RVA: 0x0007F2BC File Offset: 0x0007D4BC
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("BBFBundleVersion")]
		public string BBFBundleVersion
		{
			get
			{
				short num = (short)335051120;
				short num2 = num;
				num = (short)1064532336;
				switch (num2 == num)
				{
				}
				num = (short)126418945;
				if (num != 0)
				{
				}
				num = (short)1572143104;
				short num3 = num;
				num = (short)249233408;
				if (num != 0)
				{
				}
				return this.RadioSummaryEntity.BBFBundleVersion;
			}
			set
			{
				short num = (short)799866882;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)589758464;
						short num3 = num;
						goto IL_109;
					}
					case 1:
					{
						this.RadioSummaryEntity.BBFBundleVersion = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase.get_BBFBundleVersion())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)182686020;
						short num4 = num;
						num = (short)953389380;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_147;
						default:
							num = (short)961413120;
							if (num != 0)
							{
							}
							num = (short)295895044;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_3C;
						}
						continue;
					case 3:
						value = string.Empty;
						num = (short)1298923520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						return;
					case 5:
						goto IL_147;
					}
					IL_3C:
					if (string.IsNullOrEmpty(value))
					{
						num = (short)1035272195;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_109:
					num = (short)295829505;
					if (num != 0)
					{
					}
					num = (short)1867513861;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_147:
					if (!(value != this.RadioSummaryEntity.BBFBundleVersion))
					{
						break;
					}
					num = (short)835715073;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x0600087D RID: 2173 RVA: 0x0007F48C File Offset: 0x0007D68C
		// (set) Token: 0x0600087E RID: 2174 RVA: 0x0007F544 File Offset: 0x0007D744
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string JobName
		{
			get
			{
				short num = (short)41249532;
				short num2 = num;
				num = (short)140208892;
				switch (num2 == num)
				{
				}
				num = (short)132775936;
				if (num != 0)
				{
				}
				num = (short)1405550592;
				short num3 = num;
				num = (short)521142273;
				if (num != 0)
				{
				}
				return this.RadioSummaryEntity.LastJobName;
			}
			set
			{
				short num = (short)804080024;
				short num2 = num;
				num = (short)383797656;
				int num4;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_194:
					num = (short)1054408705;
					if (num != 0)
					{
					}
					goto IL_12E;
				default:
				{
					num = (short)1704263680;
					short num3 = num;
					num = (short)1141112832;
					if (num != 0)
					{
					}
					num = (short)2018574336;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				}
				for (;;)
				{
					IL_92:
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_B0;
						}
						continue;
					case 1:
						if (value != this.RadioSummaryEntity.LastJobName)
						{
							num = (short)235864066;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						this.RadioSummaryEntity.LastJobName = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase.get_JobName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1812398083;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return;
					case 4:
						value = string.Empty;
						num = (short)1074003973;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_194;
					}
					IL_B0:
					if (!string.IsNullOrWhiteSpace(value))
					{
						goto IL_12E;
					}
					num = (short)1375076356;
					num4 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_12E:
				num = (short)115802113;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_92;
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x0600087F RID: 2175 RVA: 0x0007F714 File Offset: 0x0007D914
		// (set) Token: 0x06000880 RID: 2176 RVA: 0x0007F7C4 File Offset: 0x0007D9C4
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus? UIJobStatus
		{
			get
			{
				short num = (short)1916796929;
				if (num != 0)
				{
				}
				num = (short)2115986978;
				short num2 = num;
				num = (short)642934306;
				switch (num2 == num)
				{
				}
				num = (short)1664352256;
				short num3 = num;
				num = (short)183107584;
				if (num != 0)
				{
				}
				return this.j;
			}
			set
			{
				short num = (short)1744441925;
				short num2 = num;
				num = (short)1385173573;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_9A;
				case 1:
					goto IL_60;
				default:
				{
					num = (short)449904640;
					short num3 = num;
					goto IL_60;
				}
				}
				int num4;
				global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus? uijobStatus;
				global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus? uijobStatus2;
				for (;;)
				{
					IL_80:
					switch (num4)
					{
					case 0:
						num = (short)142475265;
						if (num != 0)
						{
						}
						if (!base.IsLoading)
						{
							num = (short)1960443908;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						return;
					case 2:
						this.j = value;
						num = (short)637009920;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (!(uijobStatus.GetValueOrDefault() == uijobStatus2.GetValueOrDefault() & uijobStatus != null == (uijobStatus2 != null)))
						{
							num = (short)929169410;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase.get_UIJobStatus())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)69271553;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9A;
				}
				return;
				IL_60:
				num = (short)786104320;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_9A;
				}
				goto IL_80;
				IL_9A:
				uijobStatus = this.j;
				uijobStatus2 = value;
				num = (short)849805315;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_80;
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000881 RID: 2177 RVA: 0x0007F980 File Offset: 0x0007DB80
		// (set) Token: 0x06000882 RID: 2178 RVA: 0x0007FA58 File Offset: 0x0007DC58
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("JobType")]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.JobType? JobType
		{
			get
			{
				short num = (short)1002635264;
				short num2 = num;
				if (this.RadioSummaryEntity.JobType != null)
				{
					for (;;)
					{
						num = (short)1419791853;
						short num3 = num;
						num = (short)35868141;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_7A;
						}
					}
					IL_7A:
					num = (short)706347009;
					if (num != 0)
					{
					}
					num = (short)1303248896;
					if (num != 0)
					{
					}
					return this.RadioSummaryEntity.JobType;
				}
				return null;
			}
			set
			{
				short num = (short)2070675456;
				short num2 = num;
				num = (short)84820044;
				short num3 = num;
				num = (short)1142112332;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1990328320;
					if (num != 0)
					{
					}
					num = (short)494993409;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_B5;
					}
					int num4;
					global::Motorola.CommonCPS.Server.CommonDBConstants.JobType? jobType;
					global::Motorola.CommonCPS.Server.CommonDBConstants.JobType? jobType2;
					for (;;)
					{
						IL_A3:
						switch (num4)
						{
						case 0:
							this.RadioSummaryEntity.JobType = value;
							base.RaisePropertyChanged<global::Motorola.CommonCPS.Server.CommonDBConstants.JobType?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.Server.CommonDBConstants.JobType?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase.get_JobType())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1571160066;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (!(jobType.GetValueOrDefault() == jobType2.GetValueOrDefault() & jobType != null == (jobType2 != null)))
							{
								num = (short)272891904;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 2:
							goto IL_168;
						}
						goto IL_B5;
					}
					IL_168:
					break;
					IL_B5:
					jobType = value;
					jobType2 = this.RadioSummaryEntity.JobType;
					num = (short)1557594113;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_A3;
				}
				}
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x0007FBD0 File Offset: 0x0007DDD0
		// (set) Token: 0x06000884 RID: 2180 RVA: 0x0007FCA0 File Offset: 0x0007DEA0
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.JobStatus? JobStatus
		{
			get
			{
				short num = (short)1591869440;
				short num2 = num;
				if (this.RadioSummaryEntity.JobStatus != null)
				{
					for (;;)
					{
						num = (short)774745119;
						short num3 = num;
						num = (short)10595359;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_73;
						}
					}
					IL_73:
					num = (short)1014300672;
					if (num != 0)
					{
					}
					num = (short)1267007489;
					if (num != 0)
					{
					}
					return this.RadioSummaryEntity.JobStatus;
				}
				return null;
			}
			set
			{
				short num = (short)2132738048;
				short num2 = num;
				if (value != null)
				{
					for (;;)
					{
						num = (short)1479175447;
						short num3 = num;
						num = (short)76705047;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_6D;
						}
					}
					IL_6D:
					num = (short)695664641;
					if (num != 0)
					{
					}
					num = (short)1424883712;
					if (num != 0)
					{
					}
					this.RadioSummaryEntity.JobStatus = value;
					return;
				}
				this.RadioSummaryEntity.JobStatus = null;
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06000885 RID: 2181 RVA: 0x0007FD78 File Offset: 0x0007DF78
		// (set) Token: 0x06000886 RID: 2182 RVA: 0x0007FE60 File Offset: 0x0007E060
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus? CruncherStatus
		{
			get
			{
				short num = (short)179765248;
				short num2 = num;
				if (this.RadioSummaryEntity.CruncherStatus != null)
				{
					for (;;)
					{
						num = (short)1644101633;
						if (num != 0)
						{
						}
						num = (short)1087383351;
						short num3 = num;
						num = (short)550119223;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_9F;
						}
					}
					IL_9F:
					num = (short)1630601216;
					if (num != 0)
					{
					}
					return new global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus?(this.RadioSummaryEntity.CruncherStatus.Value);
				}
				return null;
			}
			set
			{
				short num = (short)823841721;
				short num2 = num;
				num = (short)1587467193;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				case 1:
					goto IL_5E;
				default:
				{
					num = (short)1993932800;
					short num3 = num;
					goto IL_5E;
				}
				}
				int num4;
				global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus? cruncherStatus;
				for (;;)
				{
					IL_92:
					switch (num4)
					{
					case 0:
					{
						global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus? cruncherStatus2;
						if (!(cruncherStatus.GetValueOrDefault() == cruncherStatus2.GetValueOrDefault() & cruncherStatus != null == (cruncherStatus2 != null)))
						{
							num = (short)544210948;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 1:
						return;
					case 2:
						goto IL_CD;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_AC;
						}
						continue;
					case 4:
						this.RadioSummaryEntity.CruncherStatus = new global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus?(value.Value);
						base.RaisePropertyChanged<global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase.get_CruncherStatus())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)914489345;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_AC:
					if (value == null)
					{
						num = (short)818479106;
						num4 = (int)((global::System.IntPtr)num);
					}
					else
					{
						cruncherStatus = value;
						global::Motorola.CommonCPS.Server.CommonDBConstants.CruncherStatus? cruncherStatus2 = this.RadioSummaryEntity.CruncherStatus;
						num = (short)1151336449;
						if (num != 0)
						{
						}
						num = (short)1947467776;
						num4 = (int)((global::System.IntPtr)num);
					}
				}
				IL_CD:
				global::Motorola.CommonCPS.Server.EntityModel.RadioSummary radioSummaryEntity = this.RadioSummaryEntity;
				cruncherStatus = null;
				radioSummaryEntity.CruncherStatus = cruncherStatus;
				return;
				IL_5E:
				num = (short)1091567616;
				if (num != 0)
				{
				}
				num = (short)696909827;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_92;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000887 RID: 2183 RVA: 0x00080048 File Offset: 0x0007E248
		// (set) Token: 0x06000888 RID: 2184 RVA: 0x000800F8 File Offset: 0x0007E2F8
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo> LanguagePacks
		{
			get
			{
				short num = (short)52559873;
				if (num != 0)
				{
				}
				num = (short)329325105;
				short num2 = num;
				num = (short)20716081;
				switch (num2 == num)
				{
				}
				num = (short)280887296;
				short num3 = num;
				num = (short)2103705600;
				if (num != 0)
				{
				}
				return this.c;
			}
			set
			{
				short num = (short)343801856;
				short num2 = num;
				num = (short)546554130;
				short num3 = num;
				num = (short)1027784978;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)477757440;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_91;
					}
					int num4;
					for (;;)
					{
						IL_7F:
						switch (num4)
						{
						case 0:
							base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase.get_LanguagePacks())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1909456897;
							if (num != 0)
							{
							}
							num = (short)1235484674;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (!base.IsLoading)
							{
								num = (short)2127167488;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 2:
							goto IL_142;
						}
						goto IL_91;
					}
					IL_142:
					break;
					IL_91:
					this.c = value;
					num = (short)1672871937;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_7F;
				}
				}
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000889 RID: 2185 RVA: 0x0008024C File Offset: 0x0007E44C
		// (set) Token: 0x0600088A RID: 2186 RVA: 0x000802FC File Offset: 0x0007E4FC
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string LpFilesTotalSize
		{
			get
			{
				short num = (short)963700118;
				short num2 = num;
				num = (short)986572182;
				switch (num2 == num)
				{
				}
				num = (short)1319829505;
				if (num != 0)
				{
				}
				num = (short)1086259200;
				short num3 = num;
				num = (short)1427832832;
				if (num != 0)
				{
				}
				return this.e;
			}
			set
			{
				short num = (short)1060306944;
				short num2 = num;
				num = (short)439794083;
				short num3 = num;
				num = (short)2030418339;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)194969600;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_92;
					}
					int num4;
					for (;;)
					{
						IL_80:
						switch (num4)
						{
						case 0:
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase.get_LpFilesTotalSize())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1142423554;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (!base.IsLoading)
							{
								num = (short)688914433;
								if (num != 0)
								{
								}
								num = (short)954990592;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 2:
							goto IL_143;
						}
						goto IL_92;
					}
					IL_143:
					break;
					IL_92:
					this.e = value;
					num = (short)257753089;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_80;
				}
				}
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x0600088B RID: 2187 RVA: 0x00080450 File Offset: 0x0007E650
		// (set) Token: 0x0600088C RID: 2188 RVA: 0x0008065C File Offset: 0x0007E85C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string LanguagePacksInfo
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_30;
				}
				int num;
				global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (productFamily != null)
						{
							goto IL_59;
						}
						goto IL_1F6;
					case 1:
						if (productFamily.Value != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.MNIS)
						{
							num2 = (short)1872887815;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1F0;
					case 2:
					{
						num2 = (short)1996881920;
						short num3 = num2;
						productFamily = this.ProductFamily;
						num2 = (short)671940612;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 3:
					{
						if (productFamily.Value == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.DMR3Controller)
						{
							goto IL_1F0;
						}
						num2 = (short)46221063;
						short num4 = num2;
						num2 = (short)930170631;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_59;
						default:
							num2 = (short)998244352;
							if (num2 != 0)
							{
							}
							num2 = (short)521797634;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 4:
						if (productFamily.Value == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.VRC)
						{
							num2 = (short)915275781;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1F6;
					case 5:
						goto IL_BB;
					case 6:
						productFamily = this.ProductFamily;
						num2 = (short)404029441;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 7:
						productFamily = this.ProductFamily;
						num2 = (short)1056833537;
						if (num2 != 0)
						{
						}
						num2 = (short)906821635;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_30;
					IL_59:
					num2 = (short)1635057670;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_BB:
				IL_1F0:
				return global::Motorola.CommonCPS.ResourceRepository.Resources.Not_Applicable;
				IL_1F6:
				return this.d;
				IL_30:
				productFamily = this.ProductFamily;
				num2 = (short)1402601472;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			set
			{
				short num = (short)2049572864;
				short num2 = num;
				num = (short)1073414145;
				if (num != 0)
				{
				}
				num = (short)1755814780;
				short num3 = num;
				num = (short)970300284;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)688783360;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_B3;
					}
					int num4;
					for (;;)
					{
						IL_A1:
						switch (num4)
						{
						case 0:
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase.get_LanguagePacksInfo())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)1408565250;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							if (!base.IsLoading)
							{
								num = (short)1057751040;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 2:
							goto IL_139;
						}
						goto IL_B3;
					}
					IL_139:
					break;
					IL_B3:
					this.d = value;
					num = (short)697368577;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_A1;
				}
				}
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x0600088D RID: 2189 RVA: 0x000807A4 File Offset: 0x0007E9A4
		// (set) Token: 0x0600088E RID: 2190 RVA: 0x00080950 File Offset: 0x0007EB50
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("ModelNumber")]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string ModelNumber
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_28;
				}
				int num;
				short num2;
				global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)336328491;
						short num3 = num2;
						num2 = (short)1198847787;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num2 = (short)589824;
							if (num2 != 0)
							{
							}
							if (productFamily != null)
							{
								num2 = (short)858652676;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_194;
						}
						break;
					}
					case 1:
						goto IL_149;
					case 2:
						if (productFamily.Value != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.MNIS)
						{
							num2 = (short)1406402565;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_100;
					case 3:
						if (productFamily.Value == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.VRC)
						{
							num2 = (short)2108096513;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_194;
					case 4:
						num2 = (short)126353409;
						if (num2 != 0)
						{
						}
						productFamily = this.ProductFamily;
						num2 = (short)806486018;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						productFamily = this.ProductFamily;
						num2 = (short)1935409155;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_28;
				}
				IL_100:
				return global::Motorola.CommonCPS.ResourceRepository.Resources.Not_Applicable;
				IL_149:
				goto IL_100;
				IL_194:
				return this.RadioSummaryEntity.ModelNumber;
				IL_28:
				productFamily = this.ProductFamily;
				num2 = (short)1345585152;
				short num4 = num2;
				num2 = (short)1431633920;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			set
			{
				short num = (short)1516087081;
				short num2 = num;
				num = (short)48211753;
				int num4;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_1BD:
					goto IL_12E;
				default:
				{
					num = (short)100728832;
					short num3 = num;
					num = (short)1706819584;
					if (num != 0)
					{
					}
					num = (short)351207424;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				}
				for (;;)
				{
					IL_92:
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_B0;
						}
						continue;
					case 1:
						if (value != this.RadioSummaryEntity.ModelNumber)
						{
							num = (short)1477443586;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						this.RadioSummaryEntity.ModelNumber = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase.get_ModelNumber())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)2032271363;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return;
					case 4:
						value = string.Empty;
						num = (short)1361313797;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_1BD;
					}
					IL_B0:
					if (!string.IsNullOrWhiteSpace(value))
					{
						goto IL_12E;
					}
					num = (short)1902247940;
					num4 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_12E:
				num = (short)1679360001;
				if (num != 0)
				{
				}
				num = (short)2075000833;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_92;
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x0600088F RID: 2191 RVA: 0x00080B20 File Offset: 0x0007ED20
		// (set) Token: 0x06000890 RID: 2192 RVA: 0x00080BD4 File Offset: 0x0007EDD4
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify("IsRadioAliasEditable", 0, true)]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("RadioAlias")]
		public string RadioAlias
		{
			get
			{
				short num = (short)334102529;
				if (num != 0)
				{
				}
				num = (short)1744027579;
				short num2 = num;
				num = (short)1991491515;
				switch (num2 == num)
				{
				}
				num = (short)217776128;
				short num3 = num;
				num = (short)1098579968;
				if (num != 0)
				{
				}
				return this.RadioSummaryEntity.RadioAlias;
			}
			set
			{
				short num = (short)281530660;
				short num2 = num;
				num = (short)191222052;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				case 1:
					break;
				default:
				{
					num = (short)1572798464;
					short num3 = num;
					break;
				}
				}
				num = (short)1522335744;
				if (num != 0)
				{
				}
				num = (short)741998593;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						num = (short)1582825473;
						if (num != 0)
						{
						}
						this.RadioSummaryEntity.RadioAlias = value;
						this.RadioSummaryEntity.RadioAlias = global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.FilterInvalidChar(value);
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase.get_RadioAlias())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)1921187842;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_A6;
						}
						continue;
					case 2:
						return;
					}
					IL_A6:
					if (!(value != this.RadioSummaryEntity.RadioAlias))
					{
						break;
					}
					num = (short)249102336;
					num4 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000891 RID: 2193 RVA: 0x00080D48 File Offset: 0x0007EF48
		// (set) Token: 0x06000892 RID: 2194 RVA: 0x00080E20 File Offset: 0x0007F020
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public int ChangeIndicator
		{
			get
			{
				short num = (short)670892032;
				short num2 = num;
				if (this.RadioSummaryEntity.ChangeIndicator != null)
				{
					for (;;)
					{
						num = (short)236126209;
						if (num != 0)
						{
						}
						num = (short)909552690;
						short num3 = num;
						num = (short)1199746098;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_9F;
						}
					}
					IL_9F:
					num = (short)639762432;
					if (num != 0)
					{
					}
					return this.RadioSummaryEntity.ChangeIndicator.Value;
				}
				return 0;
			}
			set
			{
				short num = (short)1140218588;
				short num2 = num;
				num = (short)1233214172;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				case 1:
					break;
				default:
				{
					num = (short)1530331136;
					short num3 = num;
					break;
				}
				}
				num = (short)1253900289;
				if (num != 0)
				{
				}
				num = (short)999751680;
				if (num != 0)
				{
				}
				num = (short)1187512321;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						this.RadioSummaryEntity.ChangeIndicator = new int?(value);
						base.RaisePropertyChanged<int>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<int>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase.get_UIChangeIndicator())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)388497410;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_C9;
						}
						continue;
					case 2:
						return;
					}
					IL_C9:
					int? changeIndicator = this.RadioSummaryEntity.ChangeIndicator;
					if (value == changeIndicator.GetValueOrDefault() & changeIndicator != null)
					{
						break;
					}
					num = (short)1591607296;
					num4 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000893 RID: 2195 RVA: 0x00080F8C File Offset: 0x0007F18C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool? HasPBA
		{
			get
			{
				short num = (short)1873429647;
				short num2 = num;
				num = (short)341394575;
				switch (num2 == num)
				{
				}
				num = (short)845676544;
				if (num != 0)
				{
				}
				num = (short)1748697088;
				short num3 = num;
				num = (short)762511361;
				if (num != 0)
				{
				}
				return this.RadioSummaryEntity.IsHasPba;
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000894 RID: 2196 RVA: 0x00081044 File Offset: 0x0007F244
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public virtual int UIChangeIndicator
		{
			get
			{
				short num = (short)2146828288;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_5E;
					}
					int? changeIndicator;
					int num3;
					int num4;
					for (;;)
					{
						IL_27:
						long? originalConfigurationVersionStamp;
						long? currentConfigurationVersionStamp;
						switch (num2)
						{
						case 0:
							if (changeIndicator != null)
							{
								num = (short)419233793;
								if (num != 0)
								{
								}
								num = (short)1112997889;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return num3;
						case 1:
						{
							for (;;)
							{
								changeIndicator = this.RadioSummaryEntity.ChangeIndicator;
								num4 = changeIndicator.Value;
								bool? isHasPba = this.RadioSummaryEntity.IsHasPba;
								bool flag = true;
								num = (short)885339011;
								short num5 = num;
								num = (short)51524483;
								switch ((num5 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									goto IL_20C;
								}
							}
							IL_20C:
							num = (short)1789788160;
							if (num != 0)
							{
							}
							num = (short)1760493568;
							short num6 = num;
							num = (short)917569540;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							if (!(originalConfigurationVersionStamp.GetValueOrDefault() == currentConfigurationVersionStamp.GetValueOrDefault() & originalConfigurationVersionStamp != null == (currentConfigurationVersionStamp != null)))
							{
								num = (short)1061027847;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return num4;
						case 3:
							goto IL_F3;
						case 4:
						{
							bool? isHasPba;
							bool flag;
							if (!(isHasPba.GetValueOrDefault() == flag & isHasPba != null))
							{
								num = (short)1252982789;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_F3;
						}
						case 5:
						{
							global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily = this.ProductFamily;
							num = (short)950403081;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
						{
							global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily = this.ProductFamily;
							num = (short)764084235;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							num4 |= 1;
							num = (short)455409674;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_2B4;
						case 9:
						{
							global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily;
							if (productFamily != null)
							{
								num = (short)1521287174;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_29A;
						}
						case 10:
							return num4;
						case 11:
						{
							global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily;
							if (productFamily.Value == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP)
							{
								num = (short)508231683;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_29A;
						}
						}
						goto IL_5E;
						IL_F3:
						originalConfigurationVersionStamp = this.RadioSummaryEntity.OriginalConfigurationVersionStamp;
						currentConfigurationVersionStamp = this.RadioSummaryEntity.CurrentConfigurationVersionStamp;
						num = (short)2081816578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_29A:
						num4 = num3;
						num = (short)815923208;
						num2 = (int)((global::System.IntPtr)num);
					}
					return num4;
					IL_2B4:
					return num4;
					IL_5E:
					num3 = -1;
					changeIndicator = this.RadioSummaryEntity.ChangeIndicator;
					num = (short)1904017408;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000895 RID: 2197 RVA: 0x0008135C File Offset: 0x0007F55C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public virtual bool UIModified
		{
			get
			{
				short num = (short)994902016;
				switch (num)
				{
				default:
				{
					num = (short)930349057;
					if (num != 0)
					{
					}
					num = (short)1071448069;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						long? originalConfigurationVersionStamp;
						long? currentConfigurationVersionStamp;
						int? changeIndicator;
						switch (num2)
						{
						case 0:
							if (!(originalConfigurationVersionStamp.GetValueOrDefault() == currentConfigurationVersionStamp.GetValueOrDefault() & originalConfigurationVersionStamp != null == (currentConfigurationVersionStamp != null)))
							{
								num = (short)138477572;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return false;
						case 1:
							if (changeIndicator != null)
							{
								num = (short)1982267394;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_B6;
						case 2:
						{
							changeIndicator = this.RadioSummaryEntity.ChangeIndicator;
							int num3 = 0;
							num = (short)238944262;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							return true;
						case 4:
							return true;
						case 5:
							switch (0)
							{
							case 0:
								goto IL_90;
							}
							continue;
						case 6:
						{
							int num3;
							if (!(changeIndicator.GetValueOrDefault() == num3 & changeIndicator != null))
							{
								num = (short)2031288320;
								short num4 = num;
								num = (short)497025031;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_B6;
						}
						case 7:
							return true;
						}
						IL_90:
						if (this.RadioStatus == global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus.Modified)
						{
							num = (short)924254211;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						changeIndicator = this.RadioSummaryEntity.ChangeIndicator;
						num = (short)1801263263;
						short num5 = num;
						num = (short)1215371423;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return true;
						default:
							num = (short)1590034432;
							if (num != 0)
							{
							}
							num = (short)1444478977;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_B6:
						originalConfigurationVersionStamp = this.RadioSummaryEntity.OriginalConfigurationVersionStamp;
						currentConfigurationVersionStamp = this.RadioSummaryEntity.CurrentConfigurationVersionStamp;
						num = (short)1786249216;
						num2 = (int)((global::System.IntPtr)num);
					}
					return true;
				}
				}
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06000896 RID: 2198 RVA: 0x000815B4 File Offset: 0x0007F7B4
		// (set) Token: 0x06000897 RID: 2199 RVA: 0x00081670 File Offset: 0x0007F870
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("RadioStatus")]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus RadioStatus
		{
			get
			{
				short num = (short)1119914063;
				short num2 = num;
				num = (short)1430489167;
				switch (num2 == num)
				{
				}
				num = (short)1677852672;
				if (num != 0)
				{
				}
				num = (short)1865940993;
				if (num != 0)
				{
				}
				num = (short)769982464;
				short num3 = num;
				return (global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus)this.RadioSummaryEntity.RadioStatus.GetValueOrDefault();
			}
			set
			{
				short num = (short)577896448;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					case 1:
						this.RadioSummaryEntity.RadioStatus = new int?((int)value);
						base.RaisePropertyChanged<global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase.get_RadioStatus())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)2132148226;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_13B;
					}
					IL_31:
					num = (short)1812204453;
					short num3 = num;
					num = (short)19270565;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)709296128;
						if (num != 0)
						{
						}
						num = (short)1165754369;
						if (num != 0)
						{
						}
						int? radioStatus = this.RadioSummaryEntity.RadioStatus;
						if (value == (global::Motorola.CommonCPS.Server.CommonDBConstants.RadioStatus)radioStatus.GetValueOrDefault() & radioStatus != null)
						{
							goto IL_13D;
						}
						break;
					}
					}
					num = (short)676265985;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_13B:
				IL_13D:
				num = (short)773062656;
				short num4 = num;
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x000817E4 File Offset: 0x0007F9E4
		// (set) Token: 0x06000899 RID: 2201 RVA: 0x00081898 File Offset: 0x0007FA98
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("SerialNumber")]
		public string SerialNumber
		{
			get
			{
				short num = (short)12320769;
				if (num != 0)
				{
				}
				num = (short)457709921;
				short num2 = num;
				num = (short)1477056865;
				switch (num2 == num)
				{
				}
				num = (short)1067974656;
				if (num != 0)
				{
				}
				num = (short)1983709184;
				short num3 = num;
				return this.RadioSummaryEntity.SerialNumber;
			}
			set
			{
				int a_ = 9;
				short num = (short)71303178;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1428881409;
						if (num != 0)
						{
						}
						num = (short)664469512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)296484864;
						short num3 = num;
						value = string.Empty;
						num = (short)1227161602;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_152;
					case 3:
						goto IL_86;
					case 4:
						num = (short)1707606025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_239;
					case 6:
						if (!string.IsNullOrEmpty(value))
						{
							num = (short)88735748;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_239;
					case 7:
						this.RadioSummaryEntity.SerialNumber = value;
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase.get_SerialNumber())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)259719179;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						num = (short)826104417;
						short num4 = num;
						num = (short)565729889;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)1741357056;
							if (num != 0)
							{
							}
							if (!((this.RadioSummaryEntity as global::Motorola.CommonCPS.Server.EntityModel.PBBRadioSummary).ProductIdentifier == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ࡃͅ၇橉ੋ罍恏", a_)))
							{
								num = (short)650838019;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_239;
						}
						break;
					}
					case 9:
						if (this.RadioSummaryEntity is global::Motorola.CommonCPS.Server.EntityModel.PBBRadioSummary)
						{
							num = (short)1615855616;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_86;
					case 10:
						switch (0)
						{
						case 0:
							goto IL_62;
						}
						continue;
					case 11:
						return;
					case 12:
						if (value != this.RadioSummaryEntity.SerialNumber)
						{
							num = (short)2137128967;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					IL_62:
					if (string.IsNullOrWhiteSpace(value))
					{
						num = (short)238223361;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_152;
					IL_86:
					value = value.ToUpper(global::System.Globalization.CultureInfo.CurrentCulture);
					num = (short)1668481029;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_152:
					num = (short)1598488582;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_239:
					num = (short)1551892492;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x00081B94 File Offset: 0x0007FD94
		// (set) Token: 0x0600089B RID: 2203 RVA: 0x00081C5C File Offset: 0x0007FE5C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("TemplateName")]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string TemplateName
		{
			get
			{
				short num;
				while (this.RadioSummaryEntity.TemplateName != null)
				{
					num = (short)3235085;
					short num2 = num;
					num = (short)458120461;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)801636353;
						if (num != 0)
						{
						}
						num = (short)170524672;
						if (num != 0)
						{
						}
						return this.RadioSummaryEntity.TemplateName;
					}
				}
				num = (short)1191510016;
				short num3 = num;
				return string.Empty;
			}
			set
			{
				short num = (short)2057699331;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1040121856;
					short num3 = num;
					num = (short)1723007646;
					short num4 = num;
					num = (short)443024030;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1130889217;
						if (num != 0)
						{
						}
						num = (short)1340407808;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							value = string.Empty;
							num = (short)783286273;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_156;
						case 2:
							return;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_D8;
							}
							continue;
						case 4:
							goto IL_16E;
						case 5:
							this.RadioSummaryEntity.TemplateName = value;
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase.get_TemplateName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)46596098;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_D8:
						if (string.IsNullOrWhiteSpace(value))
						{
							num = (short)373030912;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_156:
						num = (short)2067005444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_16E:
					if (!(value != this.RadioSummaryEntity.TemplateName))
					{
						break;
					}
					num = (short)261095429;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x00081E28 File Offset: 0x00080028
		// (set) Token: 0x0600089D RID: 2205 RVA: 0x00081EDC File Offset: 0x000800DC
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("ConfigurationName")]
		public string ConfigurationName
		{
			get
			{
				short num = (short)1781764018;
				short num2 = num;
				num = (short)1178177458;
				switch (num2 == num)
				{
				}
				num = (short)412876800;
				if (num != 0)
				{
				}
				num = (short)1425866753;
				if (num != 0)
				{
				}
				num = (short)1000800256;
				short num3 = num;
				return this.RadioSummaryEntity.ConfigurationName;
			}
			set
			{
				short num = (short)822214659;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)424017920;
					short num3 = num;
					num = (short)1571931228;
					short num4 = num;
					num = (short)1157874780;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1554251776;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							value = string.Empty;
							num = (short)2113011713;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_15A;
						case 2:
							return;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_B4;
							}
							continue;
						case 4:
							goto IL_172;
						case 5:
							this.RadioSummaryEntity.ConfigurationName = value;
							base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase.get_ConfigurationName())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
							num = (short)2135097345;
							if (num != 0)
							{
							}
							num = (short)1248395266;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_B4:
						if (string.IsNullOrEmpty(value))
						{
							num = (short)876085248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_15A:
						num = (short)736690180;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_172:
					if (!(value != this.RadioSummaryEntity.ConfigurationName))
					{
						break;
					}
					num = (short)1675165701;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x000820AC File Offset: 0x000802AC
		// (set) Token: 0x0600089F RID: 2207 RVA: 0x00082160 File Offset: 0x00080360
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::System.Guid? WorkingCodeplugUUID
		{
			get
			{
				short num = (short)2006253901;
				short num2 = num;
				num = (short)1865548109;
				switch (num2 == num)
				{
				}
				num = (short)1018560512;
				if (num != 0)
				{
				}
				num = (short)1127153665;
				if (num != 0)
				{
				}
				num = (short)706674688;
				short num3 = num;
				return this.RadioSummaryEntity.WorkingCodeplugUuid;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_34;
				}
				short num2;
				global::System.Guid? guid;
				global::System.Guid? workingCodeplugUuid;
				for (;;)
				{
					IL_0A:
					int num;
					bool flag;
					switch (num)
					{
					case 0:
						this.RadioSummaryEntity.WorkingCodeplugUuid = value;
						base.RaisePropertyChanged<global::System.Guid?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Guid?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase.get_WorkingCodeplugUUID())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num2 = (short)2125725698;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						flag = false;
						goto IL_18D;
					case 2:
						goto IL_12A;
					case 3:
						num2 = (short)812056577;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						num2 = (short)1810366471;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						if (guid == null)
						{
							num2 = (short)1982267395;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1874198536;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
						if (guid != null != (workingCodeplugUuid != null))
						{
							num2 = (short)1358036996;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1726939141;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 7:
						flag = true;
						goto IL_18D;
					case 8:
					{
						num2 = (short)491716608;
						short num3 = num2;
						flag = (guid.GetValueOrDefault() != workingCodeplugUuid.GetValueOrDefault());
						goto IL_18D;
					}
					}
					goto IL_34;
					IL_18D:
					if (!flag)
					{
						return;
					}
					num2 = (short)1794899968;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_12A:
				num2 = (short)354025473;
				if (num2 != 0)
				{
				}
				return;
				IL_34:
				guid = value;
				workingCodeplugUuid = this.RadioSummaryEntity.WorkingCodeplugUuid;
				num2 = (short)208208603;
				short num4 = num2;
				num2 = (short)191824603;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
				{
					num2 = (short)1550974976;
					if (num2 != 0)
					{
					}
					num2 = (short)2036989958;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x060008A0 RID: 2208 RVA: 0x000823AC File Offset: 0x000805AC
		// (set) Token: 0x060008A1 RID: 2209 RVA: 0x00082468 File Offset: 0x00080668
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string GroupName
		{
			get
			{
				short num = (short)1354432513;
				if (num != 0)
				{
				}
				num = (short)1738767761;
				short num2 = num;
				num = (short)804289937;
				switch (num2 == num)
				{
				}
				num = (short)98893824;
				if (num != 0)
				{
				}
				num = (short)349634560;
				short num3 = num;
				return this.m ?? global::Motorola.CommonCPS.ResourceRepository.Resources.Group_Field_None;
			}
			set
			{
				short num = (short)794903019;
				short num2 = num;
				num = (short)672481771;
				switch (num2 == num)
				{
				}
				num = (short)746323969;
				if (num != 0)
				{
				}
				num = (short)438763520;
				if (num != 0)
				{
				}
				num = (short)1432158208;
				short num3 = num;
				this.m = value;
			}
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x060008A2 RID: 2210 RVA: 0x00082518 File Offset: 0x00080718
		// (set) Token: 0x060008A3 RID: 2211 RVA: 0x0008269C File Offset: 0x0008089C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::Motorola.CommonCPS.RadioManagement.UIModels.Group CurentGroup
		{
			get
			{
				short num = (short)834404353;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_122;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_35;
						}
						continue;
					case 2:
					{
						num = (short)90570752;
						short num3 = num;
						num = (short)1873608705;
						if (num != 0)
						{
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.Group group = new global::Motorola.CommonCPS.RadioManagement.UIModels.Group();
						group.IsLoading = true;
						num = (short)1173553155;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.Group group;
						group.Name = (this.RadioSummaryEntity.GroupName ?? global::Motorola.CommonCPS.ResourceRepository.Resources.Group_Field_None);
						group.ID = this.RadioSummaryEntity.GroupUuid;
						group.IsLoading = false;
						this.a = group;
						num = (short)1879179264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_35:
					if (this.RadioSummaryEntity == null)
					{
						goto IL_170;
					}
					num = (short)55705602;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_122:
				num = (short)1228630259;
				short num4 = num;
				num = (short)1729849587;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1958608896;
					if (num != 0)
					{
					}
					break;
				}
				IL_170:
				return this.a;
			}
			set
			{
				short num = (short)640808256;
				short num2 = num;
				num = (short)602797376;
				switch (num2 == num)
				{
				}
				num = (short)947716097;
				if (num != 0)
				{
				}
				num = (short)2039414784;
				if (num != 0)
				{
				}
				num = (short)466485248;
				short num3 = num;
				this.RadioSummaryEntity.GroupName = value.Name;
				this.RadioSummaryEntity.GroupUuid = value.ID;
				base.RaisePropertyChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase.get_CurentGroup())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x060008A4 RID: 2212 RVA: 0x0008279C File Offset: 0x0008099C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::System.Guid? CurentGroupID
		{
			get
			{
				short num;
				while (this.CurentGroup == null)
				{
					num = (short)813170689;
					if (num != 0)
					{
					}
					num = (short)1383057942;
					short num2 = num;
					num = (short)700434966;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)270925824;
						if (num != 0)
						{
						}
						return null;
					}
				}
				num = (short)56623104;
				short num3 = num;
				return this.CurentGroup.ID;
			}
		}

		// Token: 0x17000414 RID: 1044
		// (get) Token: 0x060008A5 RID: 2213 RVA: 0x00082868 File Offset: 0x00080A68
		// (set) Token: 0x060008A6 RID: 2214 RVA: 0x0008293C File Offset: 0x00080B3C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.EntitytMemberName("Comments")]
		public override string Comments
		{
			get
			{
				short num;
				while (!string.IsNullOrWhiteSpace(this.RadioSummaryEntity.Comments))
				{
					num = (short)251990418;
					short num2 = num;
					num = (short)227217810;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1192689665;
						if (num != 0)
						{
						}
						num = (short)158334976;
						if (num != 0)
						{
						}
						return this.RadioSummaryEntity.Comments.Trim();
					}
				}
				num = (short)262144;
				short num3 = num;
				return string.Empty;
			}
			set
			{
				short num = (short)679346181;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (!base.IsLoading)
						{
							num = (short)1821573124;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C0;
					case 1:
						goto IL_B3;
					case 2:
						goto IL_1C0;
					case 3:
						num = (short)1278869505;
						if (num != 0)
						{
						}
						value = string.Empty;
						num = (short)282394625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase.get_Comments())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num = (short)2095120384;
						short num3 = num;
						num = (short)416350210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_44;
						}
						continue;
					case 6:
						if (value != this.RadioSummaryEntity.Comments)
						{
							num = (short)979894279;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C0;
					case 7:
						this.RadioSummaryEntity.Comments = value.Trim();
						goto IL_76;
					}
					IL_44:
					if (string.IsNullOrEmpty(value))
					{
						num = (short)689635331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B3;
					IL_76:
					num = (short)189202432;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C0:
					num = (short)692436766;
					short num4 = num;
					num = (short)1648738078;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_76;
					default:
						goto IL_1F7;
					}
					IL_B3:
					num = (short)1981546502;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1F7:
				num = (short)761987072;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000415 RID: 1045
		// (get) Token: 0x060008A7 RID: 2215 RVA: 0x00082B58 File Offset: 0x00080D58
		// (set) Token: 0x060008A8 RID: 2216 RVA: 0x00082C10 File Offset: 0x00080E10
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool? UpgradeAbility
		{
			get
			{
				short num = (short)486146869;
				short num2 = num;
				num = (short)1731265333;
				switch (num2 == num)
				{
				}
				num = (short)1528168449;
				if (num != 0)
				{
				}
				num = (short)1213399040;
				if (num != 0)
				{
				}
				num = (short)251133952;
				short num3 = num;
				return this.RadioSummaryEntity.UpgradeAbility;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_46;
				}
				short num;
				int num3;
				bool? upgradeAbility;
				bool? flag;
				for (;;)
				{
					IL_0A:
					num = (short)1618280448;
					short num2 = num;
					switch (num3)
					{
					case 0:
					{
						if (upgradeAbility.GetValueOrDefault() == flag.GetValueOrDefault() & upgradeAbility != null == (flag != null))
						{
							return;
						}
						num = (short)1093159596;
						short num4 = num;
						num = (short)2095139500;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)1237057536;
							if (num != 0)
							{
							}
							num = (short)79822849;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						this.RadioSummaryEntity.UpgradeAbility = value;
						num = (short)593756162;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return;
					}
					goto IL_46;
				}
				return;
				IL_46:
				num = (short)1686306817;
				if (num != 0)
				{
				}
				upgradeAbility = this.RadioSummaryEntity.UpgradeAbility;
				flag = value;
				num = (short)1282408448;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x17000416 RID: 1046
		// (get) Token: 0x060008A9 RID: 2217 RVA: 0x00082D60 File Offset: 0x00080F60
		// (set) Token: 0x060008AA RID: 2218 RVA: 0x00082E18 File Offset: 0x00081018
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::System.Guid? JobUuid
		{
			get
			{
				short num = (short)1228144641;
				if (num != 0)
				{
				}
				num = (short)643798131;
				short num2 = num;
				num = (short)1329828979;
				switch (num2 == num)
				{
				}
				num = (short)1989541888;
				if (num != 0)
				{
				}
				num = (short)1579286528;
				short num3 = num;
				return this.RadioSummaryEntity.LastJobUuid;
			}
			set
			{
				short num = (short)1253629372;
				short num2 = num;
				num = (short)2095373756;
				switch (num2 == num)
				{
				}
				num = (short)1020657664;
				if (num != 0)
				{
				}
				num = (short)710279169;
				if (num != 0)
				{
				}
				num = (short)909967360;
				short num3 = num;
				this.RadioSummaryEntity.LastJobUuid = value;
			}
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x060008AB RID: 2219 RVA: 0x00082ECC File Offset: 0x000810CC
		// (set) Token: 0x060008AC RID: 2220 RVA: 0x00082F80 File Offset: 0x00081180
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public byte[] RadioTimestamp
		{
			get
			{
				short num = (short)1137836033;
				if (num != 0)
				{
				}
				num = (short)1936349606;
				short num2 = num;
				num = (short)845371814;
				switch (num2 == num)
				{
				}
				num = (short)860684288;
				if (num != 0)
				{
				}
				num = (short)1537736704;
				short num3 = num;
				return this.RadioSummaryEntity.Timestamp;
			}
			set
			{
				short num = (short)1501301741;
				short num2 = num;
				num = (short)1059064813;
				switch (num2 == num)
				{
				}
				num = (short)1073741825;
				if (num != 0)
				{
				}
				num = (short)1829699584;
				short num3 = num;
				num = (short)808517632;
				if (num != 0)
				{
				}
				this.RadioSummaryEntity.Timestamp = value;
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x060008AD RID: 2221 RVA: 0x00083034 File Offset: 0x00081234
		// (set) Token: 0x060008AE RID: 2222 RVA: 0x000830EC File Offset: 0x000812EC
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public byte[] CodeplugTimestamp
		{
			get
			{
				short num = (short)436974233;
				short num2 = num;
				num = (short)177320601;
				switch (num2 == num)
				{
				}
				num = (short)1779105793;
				if (num != 0)
				{
				}
				num = (short)1893793792;
				short num3 = num;
				num = (short)1322778624;
				if (num != 0)
				{
				}
				return this.RadioSummaryEntity.WorkingCodeplugTimestamp;
			}
			set
			{
				short num = (short)1900752331;
				short num2 = num;
				num = (short)1582443979;
				switch (num2 == num)
				{
				}
				num = (short)1036320769;
				if (num != 0)
				{
				}
				num = (short)746520576;
				short num3 = num;
				num = (short)770375680;
				if (num != 0)
				{
				}
				this.RadioSummaryEntity.WorkingCodeplugTimestamp = value;
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x060008AF RID: 2223 RVA: 0x000831A0 File Offset: 0x000813A0
		// (set) Token: 0x060008B0 RID: 2224 RVA: 0x00083254 File Offset: 0x00081454
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public byte[] TemplateTimestamp
		{
			get
			{
				short num = (short)815608549;
				short num2 = num;
				num = (short)972567269;
				switch (num2 == num)
				{
				}
				num = (short)1328218113;
				if (num != 0)
				{
				}
				num = (short)1546125312;
				short num3 = num;
				num = (short)1260912640;
				if (num != 0)
				{
				}
				return this.RadioSummaryEntity.TemplateTimestamp;
			}
			set
			{
				short num = (short)2100695255;
				short num2 = num;
				num = (short)923341015;
				switch (num2 == num)
				{
				}
				num = (short)1195245569;
				if (num != 0)
				{
				}
				num = (short)1750401024;
				short num3 = num;
				num = (short)954531840;
				if (num != 0)
				{
				}
				this.RadioSummaryEntity.TemplateTimestamp = value;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x060008B1 RID: 2225 RVA: 0x00083308 File Offset: 0x00081508
		// (set) Token: 0x060008B2 RID: 2226 RVA: 0x000833BC File Offset: 0x000815BC
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public byte[] JobTimestamp
		{
			get
			{
				short num = (short)1892521285;
				short num2 = num;
				num = (short)922522949;
				switch (num2 == num)
				{
				}
				num = (short)105644033;
				if (num != 0)
				{
				}
				num = (short)410976256;
				short num3 = num;
				num = (short)1705836544;
				if (num != 0)
				{
				}
				return this.RadioSummaryEntity.LastJobTimestamp;
			}
			set
			{
				short num = (short)1012115532;
				short num2 = num;
				num = (short)729000012;
				switch (num2 == num)
				{
				}
				num = (short)926089217;
				if (num != 0)
				{
				}
				num = (short)873332736;
				short num3 = num;
				num = (short)1313996800;
				if (num != 0)
				{
				}
				this.RadioSummaryEntity.LastJobTimestamp = value;
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x060008B3 RID: 2227 RVA: 0x00083470 File Offset: 0x00081670
		// (set) Token: 0x060008B4 RID: 2228 RVA: 0x00083678 File Offset: 0x00081878
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string VAFiles
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_30;
				}
				int num;
				global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_E2;
					case 1:
						if (productFamily.Value != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.VRC)
						{
							num2 = (short)61014020;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1EF;
					case 2:
						productFamily = this.ProductFamily;
						num2 = (short)395378689;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
					{
						num2 = (short)1664352256;
						short num3 = num2;
						if (productFamily.Value == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.MNIS)
						{
							goto IL_1EF;
						}
						num2 = (short)562160914;
						short num4 = num2;
						num2 = (short)971957522;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_92;
						default:
							num2 = (short)517865472;
							if (num2 != 0)
							{
							}
							num2 = (short)1567293442;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 4:
						productFamily = this.ProductFamily;
						num2 = (short)140181510;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						productFamily = this.ProductFamily;
						num2 = (short)260243459;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
						goto IL_92;
					case 7:
						if (productFamily != null)
						{
							num2 = (short)1541537797;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1F5;
					}
					goto IL_30;
					IL_92:
					num2 = (short)1426391041;
					if (num2 != 0)
					{
					}
					if (productFamily.Value != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.DMR3Controller)
					{
						goto IL_1F5;
					}
					num2 = (short)1501429760;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_E2:
				IL_1EF:
				return global::Motorola.CommonCPS.ResourceRepository.Resources.Not_Applicable;
				IL_1F5:
				return this.f;
				IL_30:
				productFamily = this.ProductFamily;
				num2 = (short)1370554375;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				short num2;
				for (;;)
				{
					IL_0A:
					int num;
					switch (num)
					{
					case 0:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase.get_VAFiles())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num2 = (short)784662529;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						return;
					case 2:
						goto IL_80;
					}
					goto IL_1C;
				}
				IL_80:
				num2 = (short)222560257;
				if (num2 != 0)
				{
				}
				num2 = (short)1963982848;
				short num3 = num2;
				if (!base.IsLoading)
				{
					goto IL_D8;
				}
				return;
				IL_1C:
				num2 = (short)496635936;
				short num4 = num2;
				num2 = (short)829624352;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_D8:
					num2 = (short)1620246528;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				default:
				{
					num2 = (short)1891958784;
					if (num2 != 0)
					{
					}
					this.f = value;
					num2 = (short)1891893250;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x060008B5 RID: 2229 RVA: 0x000837C4 File Offset: 0x000819C4
		// (set) Token: 0x060008B6 RID: 2230 RVA: 0x00083874 File Offset: 0x00081A74
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string VaFilesTotalSize
		{
			get
			{
				short num = (short)1436681480;
				short num2 = num;
				num = (short)181470472;
				switch (num2 == num)
				{
				}
				num = (short)1452474369;
				if (num != 0)
				{
				}
				num = (short)202768384;
				short num3 = num;
				num = (short)874708992;
				if (num != 0)
				{
				}
				return this.g;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				short num2;
				for (;;)
				{
					IL_0A:
					int num;
					switch (num)
					{
					case 0:
						base.RaisePropertyChanged<string>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<string>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase.get_VaFilesTotalSize())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num2 = (short)1169162241;
						if (num2 != 0)
						{
						}
						num2 = (short)83951617;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						return;
					case 2:
						goto IL_83;
					}
					goto IL_1C;
				}
				IL_83:
				if (!base.IsLoading)
				{
					goto IL_8E;
				}
				return;
				IL_1C:
				num2 = (short)175059614;
				short num3 = num2;
				num2 = (short)1482961566;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_8E:
					num2 = (short)431095808;
					short num4 = num2;
					num2 = (short)1466695680;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				default:
				{
					num2 = (short)989986816;
					if (num2 != 0)
					{
					}
					this.g = value;
					num2 = (short)104988674;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x060008B7 RID: 2231 RVA: 0x000839C8 File Offset: 0x00081BC8
		// (set) Token: 0x060008B8 RID: 2232 RVA: 0x00083A78 File Offset: 0x00081C78
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceDetailInfo> VoiceFileList
		{
			get
			{
				short num = (short)525531557;
				short num2 = num;
				num = (short)2056714661;
				switch (num2 == num)
				{
				}
				num = (short)1235681280;
				if (num != 0)
				{
				}
				num = (short)757727232;
				short num3 = num;
				num = (short)1873018881;
				if (num != 0)
				{
				}
				return this.h;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				short num2;
				for (;;)
				{
					IL_0A:
					int num;
					switch (num)
					{
					case 0:
						base.RaisePropertyChanged<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceDetailInfo>>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceDetailInfo>>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase.get_VoiceFileList())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num2 = (short)481886209;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						return;
					case 2:
						goto IL_84;
					}
					goto IL_1C;
				}
				IL_84:
				num2 = (short)298713089;
				if (num2 != 0)
				{
				}
				num2 = (short)1522204672;
				short num3 = num2;
				if (!base.IsLoading)
				{
					goto IL_DB;
				}
				return;
				IL_1C:
				num2 = (short)1012123038;
				short num4 = num2;
				num2 = (short)1543619998;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_DB:
					num2 = (short)2047606784;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				default:
				{
					num2 = (short)1122238464;
					if (num2 != 0)
					{
					}
					this.h = value;
					num2 = (short)1352859650;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x060008B9 RID: 2233 RVA: 0x00083BC8 File Offset: 0x00081DC8
		// (set) Token: 0x060008BA RID: 2234 RVA: 0x00083C80 File Offset: 0x00081E80
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::System.Guid? WorkingTemplateUuid
		{
			get
			{
				short num = (short)1002714279;
				short num2 = num;
				num = (short)1912419495;
				switch (num2 == num)
				{
				}
				num = (short)284884992;
				if (num != 0)
				{
				}
				num = (short)919928832;
				short num3 = num;
				num = (short)790888449;
				if (num != 0)
				{
				}
				return this.RadioSummaryEntity.TemplateUuid;
			}
			set
			{
				short num = (short)1237422781;
				short num2 = num;
				num = (short)891130557;
				switch (num2 == num)
				{
				}
				num = (short)2100953088;
				if (num != 0)
				{
				}
				num = (short)1830354944;
				short num3 = num;
				num = (short)1030291457;
				if (num != 0)
				{
				}
				this.RadioSummaryEntity.TemplateUuid = value;
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x060008BB RID: 2235 RVA: 0x00083D38 File Offset: 0x00081F38
		// (set) Token: 0x060008BC RID: 2236 RVA: 0x00083DEC File Offset: 0x00081FEC
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::System.Guid? WorkingConfigurationUuid
		{
			get
			{
				short num = (short)47649462;
				short num2 = num;
				num = (short)277418678;
				switch (num2 == num)
				{
				}
				num = (short)1040384001;
				if (num != 0)
				{
				}
				num = (short)2035417088;
				short num3 = num;
				num = (short)1599799296;
				if (num != 0)
				{
				}
				return this.RadioSummaryEntity.ConfigurationUuid;
			}
			set
			{
				short num = (short)1074776618;
				short num2 = num;
				num = (short)1087752746;
				switch (num2 == num)
				{
				}
				num = (short)239206401;
				if (num != 0)
				{
				}
				num = (short)1471086592;
				short num3 = num;
				num = (short)1011089408;
				if (num != 0)
				{
				}
				this.RadioSummaryEntity.ConfigurationUuid = value;
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x00083EA0 File Offset: 0x000820A0
		// (set) Token: 0x060008BE RID: 2238 RVA: 0x00083F54 File Offset: 0x00082154
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool? IsOutOfSync
		{
			get
			{
				short num = (short)120377627;
				short num2 = num;
				num = (short)1885589787;
				switch (num2 == num)
				{
				}
				num = (short)1447034881;
				if (num != 0)
				{
				}
				num = (short)1182859264;
				short num3 = num;
				num = (short)1587216384;
				if (num != 0)
				{
				}
				return this.RadioSummaryEntity.IsOutOfSync;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				short num2;
				for (;;)
				{
					IL_0A:
					int num;
					switch (num)
					{
					case 0:
						this.RadioSummaryEntity.IsOutOfSync = value;
						base.RaisePropertyChanged<bool?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<bool?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase.get_IsOutOfSync())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num2 = (short)943325185;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						return;
					case 2:
						goto IL_B7;
					}
					goto IL_1C;
				}
				IL_B7:
				num2 = (short)1252261888;
				short num3 = num2;
				bool? flag;
				bool? isOutOfSync;
				if (!(flag.GetValueOrDefault() == isOutOfSync.GetValueOrDefault() & flag != null == (isOutOfSync != null)))
				{
					goto IL_102;
				}
				return;
				IL_1C:
				num2 = (short)468945534;
				short num4 = num2;
				num2 = (short)422218366;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_102:
					num2 = (short)756678656;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				default:
				{
					num2 = (short)675807233;
					if (num2 != 0)
					{
					}
					num2 = (short)218890240;
					if (num2 != 0)
					{
					}
					flag = value;
					isOutOfSync = this.RadioSummaryEntity.IsOutOfSync;
					num2 = (short)356319234;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x000840D8 File Offset: 0x000822D8
		// (set) Token: 0x060008C0 RID: 2240 RVA: 0x0008418C File Offset: 0x0008238C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::Motorola.Common.CustomException.CommonErrorCode? SyncErrorCode
		{
			get
			{
				short num = (short)1817181366;
				short num2 = num;
				num = (short)940309686;
				switch (num2 == num)
				{
				}
				num = (short)650379265;
				if (num != 0)
				{
				}
				num = (short)514392064;
				short num3 = num;
				num = (short)68878336;
				if (num != 0)
				{
				}
				return this.RadioSummaryEntity.SyncErrorCode;
			}
			set
			{
				switch (0)
				{
				case 0:
					goto IL_1C;
				}
				short num2;
				for (;;)
				{
					IL_0A:
					int num;
					switch (num)
					{
					case 0:
						this.RadioSummaryEntity.SyncErrorCode = value;
						base.RaisePropertyChanged<global::Motorola.Common.CustomException.CommonErrorCode?>(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<global::Motorola.Common.CustomException.CommonErrorCode?>>(global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(this, typeof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)), methodof(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase.get_SyncErrorCode())), global::System.Array.Empty<global::System.Linq.Expressions.ParameterExpression>()));
						num2 = (short)1091108865;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						return;
					case 2:
						goto IL_8A;
					}
					goto IL_1C;
				}
				IL_8A:
				num2 = (short)1846804481;
				if (num2 != 0)
				{
				}
				num2 = (short)1523056640;
				short num3 = num2;
				global::Motorola.Common.CustomException.CommonErrorCode? commonErrorCode;
				global::Motorola.Common.CustomException.CommonErrorCode? syncErrorCode;
				if (!(commonErrorCode.GetValueOrDefault() == syncErrorCode.GetValueOrDefault() & commonErrorCode != null == (syncErrorCode != null)))
				{
					goto IL_FE;
				}
				return;
				IL_1C:
				num2 = (short)381740104;
				short num4 = num2;
				num2 = (short)2116936776;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_FE:
					num2 = (short)1269891072;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				default:
				{
					num2 = (short)1854537728;
					if (num2 != 0)
					{
					}
					commonErrorCode = value;
					syncErrorCode = this.RadioSummaryEntity.SyncErrorCode;
					num2 = (short)241631234;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x060008C1 RID: 2241 RVA: 0x0008430C File Offset: 0x0008250C
		// (set) Token: 0x060008C2 RID: 2242 RVA: 0x00084504 File Offset: 0x00082704
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string IPProgramSystemAlias
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_30;
				}
				int num;
				global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily;
				short num2;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (productFamily.Value != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.MNIS)
						{
							num2 = (short)1444020225;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_10A;
					case 1:
						productFamily = this.ProductFamily;
						goto IL_1A6;
					case 2:
						goto IL_1E5;
					case 3:
						if (productFamily.Value == global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.VRC)
						{
							num2 = (short)169803778;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_97;
					case 4:
						goto IL_198;
					case 5:
					{
						productFamily = this.ProductFamily;
						num2 = (short)1533476864;
						short num3 = num2;
						num2 = (short)1825570816;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 6:
					{
						string ipprogramSystemAlias;
						if ((ipprogramSystemAlias = this.RadioSummaryEntity.IPProgramSystemAlias) == null)
						{
							num2 = (short)1107230724;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return ipprogramSystemAlias;
					}
					case 7:
						if (productFamily != null)
						{
							num2 = (short)1301938177;
							if (num2 != 0)
							{
							}
							num2 = (short)1487273989;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_97;
					}
					goto IL_30;
					IL_97:
					num2 = (short)1079555784;
					short num4 = num2;
					num2 = (short)847165128;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_1A6:
						num2 = (short)1931214851;
						num = (int)((global::System.IntPtr)num2);
						break;
					default:
						num2 = (short)1856241664;
						if (num2 != 0)
						{
						}
						num2 = (short)1516503046;
						num = (int)((global::System.IntPtr)num2);
						break;
					}
				}
				IL_10A:
				return global::Motorola.CommonCPS.ResourceRepository.Resources.Not_Applicable;
				IL_198:
				return string.Empty;
				IL_1E5:
				goto IL_10A;
				IL_30:
				productFamily = this.ProductFamily;
				num2 = (short)1438646279;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			set
			{
				short num = (short)1167444341;
				short num2 = num;
				num = (short)2103298421;
				switch (num2 == num)
				{
				}
				num = (short)1340997633;
				if (num != 0)
				{
				}
				num = (short)518717440;
				short num3 = num;
				num = (short)1310326784;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x060008C3 RID: 2243 RVA: 0x000845B0 File Offset: 0x000827B0
		// (set) Token: 0x060008C4 RID: 2244 RVA: 0x0008465C File Offset: 0x0008285C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem CurrentIPProgramSystem
		{
			get
			{
				short num = (short)1657166225;
				short num2 = num;
				num = (short)90921361;
				switch (num2 == num)
				{
				}
				num = (short)1734606849;
				if (num != 0)
				{
				}
				num = (short)277086208;
				short num3 = num;
				num = (short)648478720;
				if (num != 0)
				{
				}
				return null;
			}
			set
			{
				short num = (short)1031966263;
				short num2 = num;
				num = (short)1064537655;
				switch (num2 == num)
				{
				}
				num = (short)325255169;
				if (num != 0)
				{
				}
				num = (short)1226506240;
				short num3 = num;
				num = (short)2073362432;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x00084704 File Offset: 0x00082904
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public global::System.Guid? CurentIPProgramSystemID
		{
			get
			{
				if (this.RadioSummaryEntity != null)
				{
					short num = (short)1659613672;
					short num2 = num;
					num = (short)1830662632;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)11468800;
						short num3 = num;
						num = (short)1484652545;
						if (num != 0)
						{
						}
						num = (short)1068105728;
						if (num != 0)
						{
						}
						break;
					}
					}
					return this.RadioSummaryEntity.IPProgramSystemUuid;
				}
				return null;
			}
		}

		// Token: 0x17000425 RID: 1061
		public override string this[string propertyName]
		{
			get
			{
				int a_ = 9;
				short num = (short)592773132;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1216214436;
						short num3 = num;
						num = (short)1646261668;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_283;
						default:
						{
							num = (short)952172544;
							if (num != 0)
							{
							}
							num = (short)953810944;
							short num4 = num;
							num = (short)1945960456;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 1:
						if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ࡃ❅♇ⵉ㥋⽍㝏㝑ѓ㝕㭗ㅙ⽛᝝๟ѡୣ", a_)))
						{
							num = (short)899940352;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1536229386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (!base.Validate(this.SerialNumberError))
						{
							num = (short)1973092359;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_288;
					case 3:
						goto IL_F2;
					case 4:
						num = (short)1079967745;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1179254785;
						if (num != 0)
						{
						}
						if (!base.Validate(this.VAFilesError))
						{
							num = (short)1774649353;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C4;
					case 6:
						num = (short)1510735875;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_2CB;
					case 8:
						if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ቃ݅็⍉⁋⭍⍏", a_)))
						{
							num = (short)1028063238;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)349241349;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_283;
					case 10:
						if (!base.Validate(this.LanguagePacksInfoError))
						{
							num = (short)1045954571;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_94;
					case 11:
						goto IL_D6;
					case 12:
						switch (0)
						{
						case 0:
							goto IL_61;
						}
						continue;
					}
					IL_61:
					if (!(propertyName == global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᝃ⍅㩇⍉ⵋ≍ṏ❑㥓㑕㵗⡙", a_)))
					{
						num = (short)241041412;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1428029442;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_94:
				return string.Empty;
				IL_D6:
				return base.Error;
				IL_F2:
				return string.Empty;
				IL_1C4:
				return string.Empty;
				IL_283:
				return base.Error;
				IL_288:
				return string.Empty;
				IL_2CB:
				return base.Error;
			}
		}

		// Token: 0x060008C7 RID: 2247 RVA: 0x00084AB4 File Offset: 0x00082CB4
		public override void CleanErrors()
		{
			short num = (short)325566353;
			short num2 = num;
			num = (short)1303691153;
			switch (num2 == num)
			{
			}
			num = (short)648282112;
			if (num != 0)
			{
			}
			num = (short)29163520;
			short num3 = num;
			num = (short)921763841;
			if (num != 0)
			{
			}
			base.CleanErrors();
			this.SerialNumberError = string.Empty;
			this.LanguagePacksInfoError = string.Empty;
			this.VAFilesError = string.Empty;
		}

		// Token: 0x060008C8 RID: 2248 RVA: 0x00084B84 File Offset: 0x00082D84
		public override bool IsValidRecord()
		{
			short num = (short)180682757;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_6F;
				case 1:
				{
					if (!base.Validate(this.SerialNumberError))
					{
						goto IL_5B;
					}
					num = (short)2023222547;
					short num3 = num;
					num = (short)1973611795;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_174;
					default:
					{
						num = (short)1823211521;
						if (num != 0)
						{
						}
						num = (short)732299264;
						if (num != 0)
						{
						}
						num = (short)1495400448;
						short num4 = num;
						num = (short)1408040963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 2:
					goto IL_8A;
				case 3:
					goto IL_174;
				case 4:
					num = (short)1753415681;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				}
				IL_3C:
				if (base.IsValidRecord())
				{
					num = (short)595591172;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_5B:
				num = (short)1158676480;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_174:
				num = (short)1231421442;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_6F:
			return false;
			IL_8A:
			return base.Validate(this.RadioAliasError);
		}

		// Token: 0x060008C9 RID: 2249 RVA: 0x00084D0C File Offset: 0x00082F0C
		public override global::System.Collections.Generic.Dictionary<string, string> InvalidFieldErrorInfo()
		{
			int a_ = 14;
			switch (0)
			{
			case 0:
				goto IL_31;
			}
			int num;
			global::System.Collections.Generic.Dictionary<string, string> dictionary;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					return dictionary;
				case 1:
				{
					num2 = (short)905969664;
					short num3 = num2;
					dictionary.Add(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᭈ⩊⥌♎㹐ቒ㥔㹖㡘⡚", a_), base.Error);
					num2 = (short)128385024;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					num2 = (short)669974529;
					if (num2 != 0)
					{
					}
					if (!base.Validate(this.RadioAliasError))
					{
						num2 = (short)1260584961;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return dictionary;
				case 3:
				{
					num2 = (short)1985763238;
					short num4 = num2;
					num2 = (short)789796774;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6F;
					default:
						num2 = (short)980877312;
						if (num2 != 0)
						{
						}
						goto IL_D4;
					}
					break;
				}
				case 4:
					goto IL_6F;
				case 5:
					if (!base.Validate(this.SerialNumberError))
					{
						num2 = (short)1912012804;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D4;
				}
				goto IL_31;
				IL_6F:
				dictionary.Add(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᩈ⹊㽌♎ぐ㽒᭔≖㑘㥚㡜ⵞ", a_), base.Error);
				num2 = (short)1054343171;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_D4:
				num2 = (short)836763650;
				num = (int)((global::System.IntPtr)num2);
			}
			return dictionary;
			IL_31:
			dictionary = base.InvalidFieldErrorInfo();
			num2 = (short)613810181;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x00084EE0 File Offset: 0x000830E0
		// (set) Token: 0x060008CB RID: 2251 RVA: 0x00084F8C File Offset: 0x0008318C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string SerialNumberError
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1837890019;
				short num2 = num;
				num = (short)2145843683;
				switch (num2 == num)
				{
				}
				num = (short)2120024065;
				if (num != 0)
				{
				}
				num = (short)680656896;
				short num3 = num;
				num = (short)284557312;
				if (num != 0)
				{
				}
				return this.v;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)51380225;
				if (num != 0)
				{
				}
				num = (short)1673305871;
				short num2 = num;
				num = (short)622042895;
				switch (num2 == num)
				{
				}
				num = (short)867762176;
				short num3 = num;
				num = (short)1330642944;
				if (num != 0)
				{
				}
				this.v = value;
			}
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x0008503C File Offset: 0x0008323C
		// (set) Token: 0x060008CD RID: 2253 RVA: 0x000850EC File Offset: 0x000832EC
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string LanguagePacksInfoError
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1352204289;
				if (num != 0)
				{
				}
				num = (short)228130816;
				short num2 = num;
				num = (short)1624521443;
				short num3 = num;
				num = (short)837958371;
				switch (num3 == num)
				{
				}
				num = (short)1075118080;
				if (num != 0)
				{
				}
				return this.w;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)93204137;
				short num2 = num;
				num = (short)951266985;
				switch (num2 == num)
				{
				default:
				{
					num = (short)900071424;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1314586624;
				if (num != 0)
				{
				}
				num = (short)45613057;
				if (num != 0)
				{
				}
				this.w = value;
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x060008CE RID: 2254 RVA: 0x0008519C File Offset: 0x0008339C
		// (set) Token: 0x060008CF RID: 2255 RVA: 0x0008524C File Offset: 0x0008344C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string VAFilesError
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1680539575;
				short num2 = num;
				num = (short)1072299959;
				switch (num2 == num)
				{
				default:
				{
					num = (short)705363968;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1059127297;
				if (num != 0)
				{
				}
				num = (short)1807220736;
				if (num != 0)
				{
				}
				return this.x;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1784374984;
				short num2 = num;
				num = (short)935487176;
				switch (num2 == num)
				{
				}
				num = (short)1222115328;
				if (num != 0)
				{
				}
				num = (short)1356464128;
				short num3 = num;
				num = (short)1028456449;
				if (num != 0)
				{
				}
				this.x = value;
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x060008D0 RID: 2256 RVA: 0x000852FC File Offset: 0x000834FC
		// (set) Token: 0x060008D1 RID: 2257 RVA: 0x000853AC File Offset: 0x000835AC
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public string RadioAliasError
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1333996693;
				short num2 = num;
				num = (short)1084763285;
				switch (num2 == num)
				{
				}
				num = (short)2013134849;
				if (num != 0)
				{
				}
				num = (short)1983250432;
				short num3 = num;
				num = (short)97255424;
				if (num != 0)
				{
				}
				return this.y;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1412573736;
				short num2 = num;
				num = (short)1105930792;
				switch (num2 == num)
				{
				}
				num = (short)1368981505;
				if (num != 0)
				{
				}
				num = (short)1342701568;
				short num3 = num;
				num = (short)1671364608;
				if (num != 0)
				{
				}
				this.y = value;
			}
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x0008545C File Offset: 0x0008365C
		public override bool IsNewVersion(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase sourceUIMode)
		{
			byte[] radioTimestamp = ((global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)sourceUIMode).RadioTimestamp;
			byte[] radioTimestamp2 = this.RadioTimestamp;
			byte[] jobTimestamp = ((global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase)sourceUIMode).JobTimestamp;
			byte[] jobTimestamp2 = this.JobTimestamp;
			if (global::System.Collections.StructuralComparisons.StructuralComparer.Compare(radioTimestamp, radioTimestamp2) < 0)
			{
				short num = (short)285667782;
				short num2 = num;
				num = (short)1812263366;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1207173120;
					short num3 = num;
					num = (short)345636865;
					if (num != 0)
					{
					}
					num = (short)982056960;
					if (num != 0)
					{
					}
					return global::System.Collections.StructuralComparisons.StructuralComparer.Compare(jobTimestamp, jobTimestamp2) >= 0;
				}
				}
			}
			return true;
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x060008D3 RID: 2259 RVA: 0x00085554 File Offset: 0x00083754
		// (set) Token: 0x060008D4 RID: 2260 RVA: 0x0008560C File Offset: 0x0008380C
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public override global::System.Guid? ID
		{
			get
			{
				short num = (short)1256061549;
				short num2 = num;
				num = (short)1409809005;
				switch (num2 == num)
				{
				}
				num = (short)2020605953;
				if (num != 0)
				{
				}
				num = (short)65994752;
				short num3 = num;
				num = (short)816840704;
				if (num != 0)
				{
				}
				return new global::System.Guid?(this.RadioSummaryEntity.Uuid);
			}
			set
			{
				short num = (short)1414594562;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_EF;
					case 1:
						goto IL_9D;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_31;
						}
						continue;
					}
					IL_31:
					num = (short)593894415;
					short num3 = num;
					num = (short)1202068495;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_9D:
						this.RadioSummaryEntity.Uuid = value.Value;
						num = (short)1609695233;
						if (num != 0)
						{
						}
						num = (short)757071872;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)828440576;
						if (num != 0)
						{
						}
						if (value == null)
						{
							return;
						}
						num = (short)457375745;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_EF:
				num = (short)402522112;
				short num4 = num;
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x060008D5 RID: 2261 RVA: 0x00085734 File Offset: 0x00083934
		// (set) Token: 0x060008D6 RID: 2262 RVA: 0x000857E0 File Offset: 0x000839E0
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool IsGroupNameEditable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1744968763;
				short num2 = num;
				num = (short)829037627;
				switch (num2 == num)
				{
				}
				num = (short)2123694081;
				if (num != 0)
				{
				}
				num = (short)1840709632;
				short num3 = num;
				num = (short)674234368;
				if (num != 0)
				{
				}
				return this.z;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1898771130;
				short num2 = num;
				num = (short)785380026;
				switch (num2 == num)
				{
				}
				num = (short)1281884160;
				if (num != 0)
				{
				}
				num = (short)947781632;
				short num3 = num;
				num = (short)87031809;
				if (num != 0)
				{
				}
				this.z = value;
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x060008D7 RID: 2263 RVA: 0x00085890 File Offset: 0x00083A90
		// (set) Token: 0x060008D8 RID: 2264 RVA: 0x00085940 File Offset: 0x00083B40
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool IsSerialNumberEditable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)609056905;
				short num2 = num;
				num = (short)1116502153;
				switch (num2 == num)
				{
				}
				num = (short)1555955712;
				if (num != 0)
				{
				}
				num = (short)747962368;
				short num3 = num;
				num = (short)1417543681;
				if (num != 0)
				{
				}
				return this.aa;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1634799437;
				short num2 = num;
				num = (short)475205453;
				switch (num2 == num)
				{
				}
				num = (short)1971650561;
				if (num != 0)
				{
				}
				num = (short)1267073024;
				short num3 = num;
				num = (short)681771008;
				if (num != 0)
				{
				}
				this.aa = value;
			}
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x060008D9 RID: 2265 RVA: 0x000859F0 File Offset: 0x00083BF0
		// (set) Token: 0x060008DA RID: 2266 RVA: 0x00085AA0 File Offset: 0x00083CA0
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public virtual bool IsRadioAliasEditable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1248620366;
				short num2 = num;
				num = (short)1101426510;
				switch (num2 == num)
				{
				}
				num = (short)1902772225;
				if (num != 0)
				{
				}
				num = (short)724893696;
				short num3 = num;
				num = (short)1115095040;
				if (num != 0)
				{
				}
				return this.ab;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1156001698;
				short num2 = num;
				num = (short)197996450;
				switch (num2 == num)
				{
				}
				num = (short)1557987328;
				if (num != 0)
				{
				}
				num = (short)1833435136;
				short num3 = num;
				num = (short)1968439297;
				if (num != 0)
				{
				}
				this.ab = value;
			}
		}

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x060008DB RID: 2267 RVA: 0x00085B50 File Offset: 0x00083D50
		// (set) Token: 0x060008DC RID: 2268 RVA: 0x00085C00 File Offset: 0x00083E00
		[global::Motorola.CommonCPS.RadioManagement.CommonBase.CopyPasteIdentify(false)]
		public bool IsCommentEditable
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)774045696;
				short num2 = num;
				num = (short)749311343;
				short num3 = num;
				num = (short)1527420271;
				switch (num3 == num)
				{
				}
				num = (short)1970339841;
				if (num != 0)
				{
				}
				num = (short)1518796800;
				if (num != 0)
				{
				}
				return this.ac;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)154468352;
				short num2 = num;
				num = (short)165740545;
				if (num != 0)
				{
				}
				num = (short)1888845525;
				short num3 = num;
				num = (short)1710063317;
				switch (num3 == num)
				{
				}
				num = (short)1470758912;
				if (num != 0)
				{
				}
				this.ac = value;
			}
		}

		// Token: 0x060008DD RID: 2269 RVA: 0x00085CB0 File Offset: 0x00083EB0
		public override string ToString()
		{
			short num = (short)1128005632;
			short num2 = num;
			num = (short)82029672;
			short num3 = num;
			num = (short)1693559912;
			switch (num3 == num)
			{
			}
			num = (short)971112449;
			if (num != 0)
			{
			}
			num = (short)1918107648;
			if (num != 0)
			{
			}
			return this.SerialNumber;
		}

		// Token: 0x0400034A RID: 842
		private global::Motorola.CommonCPS.RadioManagement.UIModels.Group a;

		// Token: 0x0400034B RID: 843
		private string b = string.Empty;

		// Token: 0x0400034C RID: 844
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.LanguageDetailInfo> c;

		// Token: 0x0400034D RID: 845
		private string d;

		// Token: 0x0400034E RID: 846
		private string e;

		// Token: 0x0400034F RID: 847
		private string f;

		// Token: 0x04000350 RID: 848
		private string g;

		// Token: 0x04000351 RID: 849
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.VoiceDetailInfo> h;

		// Token: 0x04000352 RID: 850
		private bool i;

		// Token: 0x04000353 RID: 851
		private global::Motorola.CommonCPS.RadioManagement.UIModels.UIJobStatus? j;

		// Token: 0x04000354 RID: 852
		private bool k;

		// Token: 0x04000355 RID: 853
		private global::Motorola.CommonCPS.Server.EntityModel.IPProgramSystem l;

		// Token: 0x04000356 RID: 854
		private string m;

		// Token: 0x04000357 RID: 855
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string n;

		// Token: 0x04000358 RID: 856
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.RadioFeatureSet> o;

		// Token: 0x04000359 RID: 857
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus> p;

		// Token: 0x0400035A RID: 858
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus> q;

		// Token: 0x0400035B RID: 859
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus> r;

		// Token: 0x0400035C RID: 860
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.FeatureOptionStatus> s;

		// Token: 0x0400035D RID: 861
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.Collections.Generic.List<int> t;

		// Token: 0x0400035E RID: 862
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.CommonCPS.Server.EntityModel.OptionsCollection u;

		// Token: 0x0400035F RID: 863
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string v;

		// Token: 0x04000360 RID: 864
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string w;

		// Token: 0x04000361 RID: 865
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string x;

		// Token: 0x04000362 RID: 866
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string y;

		// Token: 0x04000363 RID: 867
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool z;

		// Token: 0x04000364 RID: 868
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool aa;

		// Token: 0x04000365 RID: 869
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool ab;

		// Token: 0x04000366 RID: 870
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool ac;
	}
}
