using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000CE RID: 206
	public abstract class ListField : global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase, global::Motorola.CommonCPS.RadioManagement.UIModels.IListEdit, global::Motorola.CommonCPS.RadioManagement.UIModels.IStringEdit
	{
		// Token: 0x060009B1 RID: 2481 RVA: 0x00093454 File Offset: 0x00091654
		public ListField()
		{
		}

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x060009B2 RID: 2482
		public abstract global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem> Items { get; }

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x060009B3 RID: 2483 RVA: 0x00093468 File Offset: 0x00091668
		// (set) Token: 0x060009B4 RID: 2484 RVA: 0x0009352C File Offset: 0x0009172C
		public int SelectedIndex
		{
			get
			{
				short num = (short)1958739968;
				short num2 = num;
				num = (short)1405496587;
				short num3 = num;
				num = (short)1801006347;
				global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem selectedItem;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)490340352;
					if (num != 0)
					{
					}
					num = (short)369098753;
					if (num != 0)
					{
					}
					selectedItem = this.SelectedItem;
					if (selectedItem == null)
					{
						return -1;
					}
					break;
				}
				return this.Items.IndexOf(selectedItem);
			}
			set
			{
				int a_ = 12;
				short num = (short)1671233536;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_4D;
						}
						continue;
					case 1:
						goto IL_6A;
					case 2:
						goto IL_9F;
					case 3:
					{
						if (!this.Items[value].IsVisible)
						{
							num = (short)598802437;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1883766785;
						if (num != 0)
						{
						}
						num = (short)80478932;
						short num3 = num;
						num = (short)94307028;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_217;
						default:
							num = (short)791281664;
							if (num != 0)
							{
							}
							this.SelectedItem = this.Items[value];
							num = (short)943652870;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						return;
					case 5:
						this.SelectInVisableItem(this.SelectedItem, this.SelectedItem, this.Items[value]);
						num = (short)41091074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_186;
					case 7:
						if (value >= this.Items.Count)
						{
							num = (short)2011103236;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1812267011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_4D:
					if (value == -1)
					{
						num = (short)2059534337;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)506331143;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_6A:
				num = (short)582352896;
				short num4 = num;
				this.SelectedItem = null;
				this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᑆⱈ❊⡌ⱎ═㙒ㅔṖ㝘㽚㡜❞", a_));
				return;
				IL_9F:
				IL_186:
				IL_217:
				this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᑆⱈ❊⡌ⱎ═㙒ㅔṖ㝘㽚㡜❞", a_));
			}
		}

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x060009B5 RID: 2485 RVA: 0x00093764 File Offset: 0x00091964
		// (set) Token: 0x060009B6 RID: 2486 RVA: 0x00093824 File Offset: 0x00091A24
		public virtual string Text
		{
			get
			{
				short num = (short)336003072;
				short num2 = num;
				num = (short)1931830253;
				short num3 = num;
				num = (short)834757613;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)28704768;
					if (num != 0)
					{
					}
					if (this.SelectedItem == null)
					{
						return string.Empty;
					}
					break;
				}
				num = (short)1714094081;
				if (num != 0)
				{
				}
				return this.SelectedItem.Name;
			}
			set
			{
				short num = (short)859766784;
				short num2 = num;
				num = (short)835662743;
				short num3 = num;
				num = (short)575812503;
				switch (num3 == num)
				{
				}
				num = (short)1244200961;
				if (num != 0)
				{
				}
				num = (short)1492910080;
				if (num != 0)
				{
				}
			}
		}

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x060009B7 RID: 2487 RVA: 0x000938D0 File Offset: 0x00091AD0
		public virtual int MaxLength
		{
			get
			{
				short num = (short)2088894464;
				short num2 = num;
				num = (short)2132345952;
				short num3 = num;
				num = (short)528614496;
				switch (num3 == num)
				{
				}
				num = (short)777519105;
				if (num != 0)
				{
				}
				num = (short)2061041664;
				if (num != 0)
				{
				}
				return 1024;
			}
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x060009B8 RID: 2488 RVA: 0x00093980 File Offset: 0x00091B80
		// (set) Token: 0x060009B9 RID: 2489 RVA: 0x00093A30 File Offset: 0x00091C30
		public virtual bool SortedDefaultValue
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1013383168;
				short num2 = num;
				num = (short)1063452673;
				if (num != 0)
				{
				}
				num = (short)743468802;
				short num3 = num;
				num = (short)1664184066;
				switch (num3 == num)
				{
				}
				num = (short)648478720;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1878917120;
				short num2 = num;
				num = (short)7429414;
				short num3 = num;
				num = (short)515071270;
				switch (num3 == num)
				{
				}
				num = (short)773718017;
				if (num != 0)
				{
				}
				num = (short)991363072;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x060009BA RID: 2490
		protected abstract void UpdateItemsProperty();

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x060009BB RID: 2491
		public abstract bool IsReferField { get; }

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x060009BC RID: 2492 RVA: 0x00093AE0 File Offset: 0x00091CE0
		// (set) Token: 0x060009BD RID: 2493 RVA: 0x00093B90 File Offset: 0x00091D90
		public virtual bool IsReferParentSet
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)415301632;
				short num2 = num;
				num = (short)2139321338;
				short num3 = num;
				num = (short)308114426;
				switch (num3 == num)
				{
				}
				num = (short)645005313;
				if (num != 0)
				{
				}
				num = (short)167444480;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)552337408;
				short num2 = num;
				num = (short)1736662243;
				short num3 = num;
				num = (short)384064739;
				switch (num3 == num)
				{
				}
				num = (short)2069954561;
				if (num != 0)
				{
				}
				num = (short)490536960;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x060009BE RID: 2494 RVA: 0x00093C40 File Offset: 0x00091E40
		public virtual bool IsShowReferSetsSetName
		{
			get
			{
				short num = (short)2120089600;
				short num2 = num;
				num = (short)1065912420;
				short num3 = num;
				num = (short)615286884;
				switch (num3 == num)
				{
				}
				num = (short)4521985;
				if (num != 0)
				{
				}
				num = (short)602144768;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x00093CEC File Offset: 0x00091EEC
		public virtual global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.UIModels.PreloadSetInfo, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.PreloadFieldInfo>> ReferSetCategorysPreloadFieldNames
		{
			get
			{
				short num = (short)300744704;
				short num2 = num;
				num = (short)1240438777;
				short num3 = num;
				num = (short)1338021881;
				switch (num3 == num)
				{
				}
				num = (short)1266810880;
				if (num != 0)
				{
				}
				num = (short)2065825793;
				if (num != 0)
				{
				}
				return new global::System.Collections.Generic.Dictionary<global::Motorola.CommonCPS.RadioManagement.UIModels.PreloadSetInfo, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.PreloadFieldInfo>>();
			}
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x060009C0 RID: 2496
		// (set) Token: 0x060009C1 RID: 2497
		protected abstract global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem SelectedItem { get; set; }

		// Token: 0x060009C2 RID: 2498 RVA: 0x00093D98 File Offset: 0x00091F98
		public virtual string GetReferredDisplaySetName(global::Motorola.CommonCPS.RadioManagement.UIModels.Set set)
		{
			short num = (short)647036928;
			short num2 = num;
			num = (short)1266302944;
			short num3 = num;
			num = (short)880754656;
			switch (num3 == num)
			{
			}
			num = (short)79167489;
			if (num != 0)
			{
			}
			num = (short)1662255104;
			if (num != 0)
			{
			}
			return this.ToString();
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x00093E48 File Offset: 0x00092048
		public override void RaisePropertyChanged()
		{
			int a_ = 2;
			short num = (short)1864499200;
			short num2 = num;
			num = (short)1268585910;
			short num3 = num;
			num = (short)1803883958;
			switch (num3 == num)
			{
			}
			num = (short)992673792;
			if (num != 0)
			{
			}
			num = (short)78643201;
			if (num != 0)
			{
			}
			base.RaisePropertyChanged();
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("琼䬾⑀⹂㙄", a_));
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("渼娾ⵀ♂♄㍆ⱈ⽊ьⅎ㕐㙒ⵔ", a_));
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("椼娾㥀㝂", a_));
			base.IsSelfChangeOnly = false;
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00093F44 File Offset: 0x00092144
		public override string ToString()
		{
			short num;
			string result;
			try
			{
				num = (short)1444347904;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					IL_1E:
					string text;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_40;
						}
						continue;
					case 1:
						num = (short)429522950;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_D2;
					case 3:
						goto IL_147;
					case 4:
						text = string.Empty;
						goto IL_12E;
					case 5:
						text = this.SelectedItem.Name;
						goto IL_12E;
					case 6:
						if (!this.SelectedItem.IsVisible)
						{
							num = (short)206241794;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1856569349;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_40:
					while (this.SelectedItem != null)
					{
						num = (short)197722836;
						short num3 = num;
						num = (short)358941396;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1749417984;
							if (num != 0)
							{
							}
							num = (short)830865409;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1E;
						}
					}
					IL_D2:
					num = (short)349437956;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12E:
					result = text;
					num = (short)1895694339;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_147:;
			}
			catch (global::System.Exception)
			{
				result = string.Empty;
			}
			num = (short)1300234240;
			short num4 = num;
			num = (short)463798273;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00094110 File Offset: 0x00092310
		public virtual void RefreshChoices(bool isSortRequired)
		{
			short num = (short)2034324223;
			short num2 = num;
			num = (short)1451512575;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1906966528;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2121400321;
			if (num != 0)
			{
			}
			num = (short)1250754560;
			if (num != 0)
			{
			}
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x000941BC File Offset: 0x000923BC
		protected void SelectInVisableItem(global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem lastVisableItem, global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem oldItem, global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem newItem)
		{
			short num = (short)1771044865;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				int num3;
				switch (num2)
				{
				case 0:
					if (num3 != this.Items.Count - 1)
					{
						num = (short)1897594893;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					newItem = lastVisableItem;
					num = (short)2031026193;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_15;
				case 2:
					if (newItem == null)
					{
						num = (short)1753022473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_18D;
				case 3:
				{
					if (num3 != 0)
					{
						num = (short)636092420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					newItem = lastVisableItem;
					num = (short)86900736;
					short num4 = num;
					num = (short)1991835659;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					num = (short)194969601;
					if (num != 0)
					{
					}
					num3--;
					num = (short)536543237;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_CB;
				case 6:
					goto IL_CB;
				case 7:
				{
					if (newItem.IsVisible)
					{
						num = (short)1141571596;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1421789804;
					short num5 = num;
					num = (short)1065798252;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_15;
					default:
					{
						num = (short)75890688;
						if (num != 0)
						{
						}
						int num6 = this.Items.IndexOf(newItem);
						int num7 = this.Items.IndexOf(oldItem);
						num3 = num6;
						num = (short)779288590;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 8:
					num = (short)1828388874;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_128;
				case 10:
					if (oldItem != null)
					{
						num = (short)660537360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 11:
					goto IL_290;
				case 12:
					goto IL_1C6;
				case 13:
					num3++;
					num = (short)847249414;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
				{
					int num6;
					int num7;
					if (num6 > num7)
					{
						num = (short)59834386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)490668035;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 15:
					goto IL_18D;
				case 16:
					num = (short)1474166786;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					goto IL_C5;
				case 18:
					num = (short)1146355712;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_71;
				IL_15:
				switch (0)
				{
				case 0:
					IL_71:
					if (lastVisableItem == null)
					{
						return;
					}
					num = (short)273612808;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				continue;
				IL_CB:
				newItem = this.Items[num3];
				num = (short)1919221775;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_18D:
				num = (short)1054081031;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C5:
			goto IL_357;
			IL_128:
			return;
			IL_1C6:
			IL_290:
			IL_357:
			this.SelectedItem = newItem;
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x00094528 File Offset: 0x00092728
		protected override global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult PasteFromOverride(global::System.Xml.Linq.XElement xmlElement, ref global::System.Collections.Generic.List<global::System.Tuple<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Xml.Linq.XElement>> setsToAdd, ref global::System.Collections.Generic.List<global::System.Tuple<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>>> setsToRemove, global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.PasteContext pasteContext)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			string pasteValue;
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem listFieldItem;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (this.SelectedItem != null)
					{
						num2 = (short)241369092;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult.Unchanged;
				case 1:
					if (this.SelectedItem != null)
					{
						num2 = (short)849936391;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_B7;
				case 2:
				{
					if (listFieldItem != null)
					{
						num2 = (short)329973763;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					pasteContext.Statuses.InvalidFieldValue(this, pasteValue);
					num2 = (short)141211307;
					short num3 = num2;
					num2 = (short)1284945579;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1E8;
					default:
						num2 = (short)747241472;
						if (num2 != 0)
						{
						}
						num2 = (short)1159790598;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					goto IL_10A;
				case 4:
				{
					num2 = (short)2073690112;
					short num4 = num2;
					goto IL_1E8;
				}
				case 5:
					if (this.SelectedItem.Name != pasteValue)
					{
						num2 = (short)1824718856;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult.Unchanged;
				case 6:
					return global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult.Unchanged;
				case 7:
					num2 = (short)410648577;
					if (num2 != 0)
					{
					}
					num2 = (short)1780547584;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					goto IL_B7;
				}
				goto IL_34;
				IL_B7:
				this.RefreshChoices(false);
				listFieldItem = this.Items.FirstOrDefault(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.ListFieldItem itm)
				{
					short num5 = (short)2096255994;
					short num6 = num5;
					num5 = (short)499405818;
					switch (num6 == num5)
					{
					default:
					{
						num5 = (short)169869312;
						short num7 = num5;
						break;
					}
					case true:
						break;
					}
					num5 = (short)1101922304;
					if (num5 != 0)
					{
					}
					num5 = (short)1310261249;
					if (num5 != 0)
					{
					}
					return itm.Name == pasteValue;
				});
				num2 = (short)1282473986;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1E8:
				num2 = (short)610205701;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_10A:
			this.SelectedItem = listFieldItem;
			pasteContext.Statuses.ClearErrors(this, null);
			return global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult.Changed;
			IL_34:
			pasteValue = xmlElement.Value;
			num2 = (short)3407873;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060009C8 RID: 2504 RVA: 0x0009476C File Offset: 0x0009296C
		protected override global::System.Xml.Linq.XElement ToCopyOverride()
		{
			int a_ = 0;
			short num;
			string text2;
			try
			{
				for (;;)
				{
					IL_09:
					num = (short)271187971;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						string text;
						switch (num2)
						{
						case 0:
						{
							num = (short)507575736;
							short num3 = num;
							num = (short)56556984;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_09;
							default:
								num = (short)703528960;
								if (num != 0)
								{
								}
								num = (short)1488519169;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							text = string.Empty;
							goto IL_115;
						case 2:
							text = this.SelectedItem.Name;
							goto IL_115;
						case 3:
							switch (0)
							{
							case 0:
								goto IL_42;
							}
							continue;
						case 4:
							goto IL_12F;
						}
						IL_42:
						num = (short)1320288257;
						if (num != 0)
						{
						}
						if (this.SelectedItem == null)
						{
							num = (short)1164771328;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1842348034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_115:
						text2 = text;
						num = (short)442499076;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_12F:;
			}
			catch (global::System.Exception)
			{
				text2 = string.Empty;
			}
			num = (short)636813312;
			short num4 = num;
			return new global::System.Xml.Linq.XElement(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("崺吼娾ⵀ❂", a_), new object[]
			{
				new global::System.Xml.Linq.XAttribute(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("唺尼刾⑀", a_), base.Name),
				text2
			});
		}

		// Token: 0x0400038D RID: 909
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool a;

		// Token: 0x0400038E RID: 910
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool b;
	}
}
