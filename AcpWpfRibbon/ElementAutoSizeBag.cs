using System;
using System.Windows;

namespace DevComponents.WpfRibbon
{
	// Token: 0x02000007 RID: 7
	internal class ElementAutoSizeBag
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000164 RID: 356 RVA: 0x00025884 File Offset: 0x00023A84
		// (set) Token: 0x06000165 RID: 357 RVA: 0x00025934 File Offset: 0x00023B34
		protected bool SettingsRecorded
		{
			get
			{
				short num = (short)2043971348;
				short num2 = num;
				num = (short)444368660;
				switch (num2 == num)
				{
				}
				num = (short)1429340161;
				if (num != 0)
				{
				}
				num = (short)1549664256;
				if (num != 0)
				{
				}
				num = (short)173342720;
				short num3 = num;
				return this.m_SettingsRecorded;
			}
			set
			{
				short num = (short)539346732;
				short num2 = num;
				num = (short)1321846572;
				switch (num2 == num)
				{
				}
				num = (short)209453057;
				if (num != 0)
				{
				}
				num = (short)1802764288;
				if (num != 0)
				{
				}
				num = (short)1983250432;
				short num3 = num;
				this.m_SettingsRecorded = value;
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000259E4 File Offset: 0x00023BE4
		public virtual void RecordSetting(global::System.Windows.UIElement item)
		{
			short num = (short)227361762;
			short num2 = num;
			num = (short)1764836322;
			switch (num2 == num)
			{
			}
			num = (short)947716096;
			if (num != 0)
			{
			}
			num = (short)1560084481;
			if (num != 0)
			{
			}
			num = (short)1046085632;
			short num3 = num;
			this.Element = item;
			this.m_SettingsRecorded = true;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00025A98 File Offset: 0x00023C98
		public virtual void RestoreSettings()
		{
			short num = (short)293259376;
			short num2 = num;
			num = (short)1888733296;
			switch (num2 == num)
			{
			}
			num = (short)1421148161;
			if (num != 0)
			{
			}
			num = (short)1859256320;
			if (num != 0)
			{
			}
			num = (short)520224768;
			short num3 = num;
			this.m_SettingsRecorded = false;
		}

		// Token: 0x0400007F RID: 127
		public global::System.Windows.UIElement Element;

		// Token: 0x04000080 RID: 128
		private bool m_SettingsRecorded;
	}
}
