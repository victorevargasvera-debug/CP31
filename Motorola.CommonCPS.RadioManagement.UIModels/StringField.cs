using System;
using System.Collections.Generic;
using System.Xml.Linq;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000D0 RID: 208
	public class StringField : global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase, global::Motorola.CommonCPS.RadioManagement.UIModels.IStringEdit
	{
		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x060009CC RID: 2508 RVA: 0x00094A20 File Offset: 0x00092C20
		public virtual int MaxLength
		{
			get
			{
				short num = (short)1691615235;
				int num2 = (int)((global::System.IntPtr)num);
				int val;
				int val2;
				for (;;)
				{
					num = (short)1774059520;
					short num3 = num;
					switch (num2)
					{
					case 0:
						return 0;
					case 1:
					{
						num = (short)129236993;
						if (num != 0)
						{
						}
						string text;
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)11337732;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17B;
					}
					case 2:
						goto IL_AB;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_62;
						}
						continue;
					case 4:
					{
						string text;
						val = text.Length;
						num = (short)815005698;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_62:
					if (this.b == 2147483647)
					{
						num = (short)2033319936;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						val2 = global::System.Math.Min(this.b, 5000);
						string text = this.a;
						val = 0;
						num = (short)1781334017;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				return 0;
				IL_AB:
				num = (short)1273602350;
				short num4 = num;
				num = (short)491233582;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return 0;
				default:
					num = (short)443809792;
					if (num != 0)
					{
					}
					break;
				}
				IL_17B:
				return global::System.Math.Max(val2, val);
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x060009CD RID: 2509 RVA: 0x00094BB0 File Offset: 0x00092DB0
		// (set) Token: 0x060009CE RID: 2510 RVA: 0x00094C5C File Offset: 0x00092E5C
		public virtual string Text
		{
			get
			{
				short num = (short)1674902174;
				short num2 = num;
				num = (short)1318910622;
				switch (num2 == num)
				{
				default:
				{
					num = (short)2022768640;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1353646081;
				if (num != 0)
				{
				}
				num = (short)495452160;
				if (num != 0)
				{
				}
				return this.a;
			}
			set
			{
				short num = (short)1095917572;
				short num2 = num;
				num = (short)1913217028;
				int num4;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_90:
					if (string.Equals(value, this.a))
					{
						return;
					}
					num = (short)583991297;
					if (num != 0)
					{
					}
					num = (short)178913280;
					short num3 = num;
					num = (short)347209728;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				default:
					num = (short)104529920;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_68;
					}
					break;
				}
				for (;;)
				{
					IL_56:
					switch (num4)
					{
					case 0:
						base.DoModifyBlValue(delegate
						{
							int a_ = 7;
							short num5 = (short)426802269;
							short num6 = num5;
							num5 = (short)94141533;
							int num7;
							switch ((num6 == num5) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_96:
								if (this.IsLoading)
								{
									return;
								}
								num5 = (short)1654849536;
								num7 = (int)((global::System.IntPtr)num5);
								break;
							default:
								num5 = (short)464977920;
								if (num5 != 0)
								{
								}
								switch (0)
								{
								case 0:
									goto IL_71;
								}
								break;
							}
							for (;;)
							{
								IL_5F:
								switch (num7)
								{
								case 0:
								{
									num5 = (short)1781465088;
									short num8 = num5;
									this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("ᙁ⅃㹅㱇", a_));
									num5 = (short)601161730;
									num7 = (int)((global::System.IntPtr)num5);
									continue;
								}
								case 1:
									goto IL_96;
								case 2:
									goto IL_117;
								}
								goto IL_71;
							}
							IL_117:
							num5 = (short)1313931265;
							if (num5 != 0)
							{
							}
							return;
							IL_71:
							this.a = value;
							num5 = (short)1063387137;
							num7 = (int)((global::System.IntPtr)num5);
							goto IL_5F;
						});
						num = (short)346816514;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_90;
					case 2:
						goto IL_139;
					}
					goto IL_68;
				}
				IL_139:
				return;
				IL_68:
				num = (short)1423966209;
				num4 = (int)((global::System.IntPtr)num);
				goto IL_56;
			}
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00094DA4 File Offset: 0x00092FA4
		public override string ToString()
		{
			short num;
			string result;
			try
			{
				num = (short)446388899;
				short num2 = num;
				num = (short)614947491;
				switch (num2 == num)
				{
				}
				num = (short)936509441;
				if (num != 0)
				{
				}
				num = (short)305463296;
				if (num != 0)
				{
				}
				result = this.Text;
			}
			catch
			{
				result = string.Empty;
			}
			num = (short)1510998016;
			short num3 = num;
			return result;
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00094E74 File Offset: 0x00093074
		public override void RaisePropertyChanged()
		{
			int a_ = 3;
			short num = (short)1500536381;
			short num2 = num;
			num = (short)1961778749;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1277755392;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)864878593;
			if (num != 0)
			{
			}
			num = (short)1411907584;
			if (num != 0)
			{
			}
			base.RaisePropertyChanged();
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("樽┿㩁ぃ", a_));
			this.RaisePropertyChanged(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("猽ℿ㩁ࡃ⍅♇ⵉ㡋♍", a_));
			base.IsSelfChangeOnly = false;
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x00094F60 File Offset: 0x00093160
		protected override void CleanCacheData()
		{
			short num = (short)265868321;
			short num2 = num;
			num = (short)1662768161;
			switch (num2 == num)
			{
			default:
			{
				num = (short)37945344;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1532624897;
			if (num != 0)
			{
			}
			num = (short)1179254784;
			if (num != 0)
			{
			}
			base.CleanCacheData();
			this.a = null;
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x060009D2 RID: 2514 RVA: 0x00095018 File Offset: 0x00093218
		public override string ValueForCompare
		{
			get
			{
				short num = (short)771935686;
				short num2 = num;
				num = (short)47959494;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1014169600;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)659554304;
				if (num != 0)
				{
				}
				num = (short)1248067585;
				if (num != 0)
				{
				}
				return this.Text;
			}
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x000950C8 File Offset: 0x000932C8
		protected override global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult PasteFromOverride(global::System.Xml.Linq.XElement xmlElement, ref global::System.Collections.Generic.List<global::System.Tuple<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Xml.Linq.XElement>> setsToAdd, ref global::System.Collections.Generic.List<global::System.Tuple<global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory, global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Set>>> setsToRemove, global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.PasteContext pasteContext)
		{
			string value = xmlElement.Value;
			short num;
			if (this.Text != value)
			{
				for (;;)
				{
					num = (short)683905806;
					short num2 = num;
					num = (short)444371726;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_79;
					}
					break;
				}
				num = (short)390070272;
				short num3 = num;
				IL_79:
				num = (short)772341760;
				if (num != 0)
				{
				}
				this.Text = value;
				return global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult.Changed;
			}
			num = (short)192610305;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.UIModels.PasteResult.Unchanged;
		}

		// Token: 0x04000390 RID: 912
		private string a;

		// Token: 0x04000391 RID: 913
		private int b;
	}
}
