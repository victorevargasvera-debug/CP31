using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Motorola.Common.Communication.Pba
{
	// Token: 0x02000011 RID: 17
	[global::System.Serializable]
	public class FileSet
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600005F RID: 95 RVA: 0x000060EC File Offset: 0x000042EC
		// (set) Token: 0x06000060 RID: 96 RVA: 0x000061A0 File Offset: 0x000043A0
		[global::System.Xml.Serialization.XmlAttribute("Name")]
		public string Name
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2129639463;
				short num2 = num;
				num = (short)93173799;
				switch (num2 == num)
				{
				}
				num = (short)884473856;
				short num3 = num;
				num = (short)749338624;
				if (num != 0)
				{
				}
				num = (short)1168506881;
				if (num != 0)
				{
				}
				return this.<Name>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1979056129;
				if (num != 0)
				{
				}
				num = (short)1622010084;
				short num2 = num;
				num = (short)653322468;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1728118784;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)533331968;
				if (num != 0)
				{
				}
				this.<Name>k__BackingField = value;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00006250 File Offset: 0x00004450
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00006300 File Offset: 0x00004500
		[global::System.Xml.Serialization.XmlElement("FileList")]
		public global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem> FileItemsList
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)2003519452;
				short num2 = num;
				num = (short)856639452;
				switch (num2 == num)
				{
				}
				num = (short)1980301312;
				short num3 = num;
				num = (short)480313345;
				if (num != 0)
				{
				}
				num = (short)1595998208;
				if (num != 0)
				{
				}
				return this.<FileItemsList>k__BackingField;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2008636542;
				short num2 = num;
				num = (short)200432766;
				switch (num2 == num)
				{
				}
				num = (short)1961164800;
				short num3 = num;
				num = (short)355205121;
				if (num != 0)
				{
				}
				num = (short)2035548160;
				if (num != 0)
				{
				}
				this.<FileItemsList>k__BackingField = value;
			}
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000063B4 File Offset: 0x000045B4
		public FileSet()
		{
			this.FileItemsList = null;
			this.Name = null;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000063D8 File Offset: 0x000045D8
		public FileSet(string name)
		{
			this.FileItemsList = new global::System.Collections.Generic.List<global::Motorola.Common.Communication.Pba.FileItem>();
			this.Name = name;
		}
	}
}
