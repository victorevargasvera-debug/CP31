using System;
using System.Windows;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000008 RID: 8
	internal class ButtonDropDownAutoSizeBag : global::DevComponents.WpfRibbon.ElementAutoSizeBag
	{
		// Token: 0x06000169 RID: 361 RVA: 0x00025B5C File Offset: 0x00023D5C
		public override void RecordSetting(global::System.Windows.UIElement item)
		{
			short num;
			while (!base.SettingsRecorded)
			{
				num = (short)1011855178;
				short num2 = num;
				num = (short)1021292362;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1796210688;
					if (num != 0)
					{
					}
					global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown = item as global::DevComponents.WpfRibbon.ButtonDropDown;
					this.m_PartVisibility = buttonDropDown.PartVisibility;
					this.m_ImagePosition = buttonDropDown.ImagePosition;
					this.m_UseSmallImage = buttonDropDown.UseSmallImage;
					this.m_ExpandPosition = buttonDropDown.ExpandPosition;
					base.RecordSetting(item);
					return;
				}
				}
			}
			num = (short)1441857536;
			short num3 = num;
			num = (short)1594490881;
			if (num != 0)
			{
			}
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00025C50 File Offset: 0x00023E50
		public override void RestoreSettings()
		{
			short num;
			while (base.SettingsRecorded)
			{
				num = (short)154736303;
				short num2 = num;
				num = (short)254088879;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1683816448;
					if (num != 0)
					{
					}
					global::DevComponents.WpfRibbon.ButtonDropDown buttonDropDown = this.Element as global::DevComponents.WpfRibbon.ButtonDropDown;
					buttonDropDown.PartVisibility = this.m_PartVisibility;
					buttonDropDown.ImagePosition = this.m_ImagePosition;
					buttonDropDown.UseSmallImage = this.m_UseSmallImage;
					buttonDropDown.ExpandPosition = this.m_ExpandPosition;
					base.RestoreSettings();
					return;
				}
				}
			}
			num = (short)9502720;
			short num3 = num;
			num = (short)757137409;
			if (num != 0)
			{
			}
		}

		// Token: 0x04000081 RID: 129
		private global::DevComponents.WpfRibbon.eButtonPartVisibility m_PartVisibility;

		// Token: 0x04000082 RID: 130
		private global::DevComponents.WpfRibbon.eButtonImagePosition m_ImagePosition;

		// Token: 0x04000083 RID: 131
		private bool m_UseSmallImage;

		// Token: 0x04000084 RID: 132
		private global::DevComponents.WpfRibbon.eExpandPosition m_ExpandPosition = global::DevComponents.WpfRibbon.eExpandPosition.Right;
	}
}
