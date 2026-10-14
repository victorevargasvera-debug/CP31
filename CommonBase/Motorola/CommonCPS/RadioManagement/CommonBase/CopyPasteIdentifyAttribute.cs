using System;
using System.Runtime.CompilerServices;

namespace Motorola.CommonCPS.RadioManagement.CommonBase
{
	// Token: 0x02000005 RID: 5
	[global::System.AttributeUsage(global::System.AttributeTargets.Property, AllowMultiple = true)]
	public class CopyPasteIdentifyAttribute : global::System.Attribute
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00004400 File Offset: 0x00002600
		public CopyPasteIdentifyAttribute(string editableConstrainPropertyName, int mappedServerField, bool supportCopyPaste = true)
		{
			this.SupportCopyPaste = supportCopyPaste;
			this.EditableConstrainPropertyName = editableConstrainPropertyName;
			this.MappedServerField = new int?(mappedServerField);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00004430 File Offset: 0x00002630
		public CopyPasteIdentifyAttribute(string editableConstrainPropertyName, bool supportCopyPaste = true)
		{
			this.SupportCopyPaste = supportCopyPaste;
			this.EditableConstrainPropertyName = editableConstrainPropertyName;
			this.MappedServerField = null;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00004460 File Offset: 0x00002660
		public CopyPasteIdentifyAttribute(bool supportCopyPaste)
		{
			this.SupportCopyPaste = supportCopyPaste;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600001A RID: 26 RVA: 0x0000447C File Offset: 0x0000267C
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00004530 File Offset: 0x00002730
		public string EditableConstrainPropertyName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)786903992;
				short num2 = num;
				num = (short)1326003128;
				switch (num2 == num)
				{
				}
				num = (short)1277689856;
				short num3 = num;
				num = (short)1770979329;
				if (num != 0)
				{
				}
				num = (short)35061760;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1790539743;
				short num2 = num;
				num = (short)1160017887;
				switch (num2 == num)
				{
				}
				num = (short)1724907520;
				short num3 = num;
				num = (short)1810169856;
				if (num != 0)
				{
				}
				num = (short)2116026369;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000045E0 File Offset: 0x000027E0
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00004690 File Offset: 0x00002890
		public int? MappedServerField
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1629741196;
				short num2 = num;
				num = (short)2080759948;
				switch (num2 == num)
				{
				}
				num = (short)921960448;
				short num3 = num;
				num = (short)328859648;
				if (num != 0)
				{
				}
				num = (short)772866049;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1832413979;
				short num2 = num;
				num = (short)1619880731;
				switch (num2 == num)
				{
				}
				num = (short)295567360;
				short num3 = num;
				num = (short)916586497;
				if (num != 0)
				{
				}
				num = (short)209518592;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00004744 File Offset: 0x00002944
		// (set) Token: 0x0600001F RID: 31 RVA: 0x000047F4 File Offset: 0x000029F4
		public bool SupportCopyPaste
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)606828525;
				short num2 = num;
				num = (short)1955690477;
				switch (num2 == num)
				{
				}
				num = (short)37617664;
				short num3 = num;
				num = (short)1438187520;
				if (num != 0)
				{
				}
				num = (short)1164378113;
				if (num != 0)
				{
				}
				return this.c;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1637438513;
				short num2 = num;
				num = (short)1055872049;
				switch (num2 == num)
				{
				}
				num = (short)1643184128;
				short num3 = num;
				num = (short)191168513;
				if (num != 0)
				{
				}
				num = (short)427491328;
				if (num != 0)
				{
				}
				this.c = value;
			}
		}

		// Token: 0x04000014 RID: 20
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private string a;

		// Token: 0x04000015 RID: 21
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private int? b;

		// Token: 0x04000016 RID: 22
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool c;
	}
}
