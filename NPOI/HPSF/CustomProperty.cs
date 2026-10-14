using System;

namespace NPOI.HPSF
{
	// Token: 0x02000509 RID: 1289
	public class CustomProperty : global::NPOI.HPSF.MutableProperty
	{
		// Token: 0x06003017 RID: 12311 RVA: 0x00091DDA File Offset: 0x0008FFDA
		public CustomProperty()
		{
			this.name = null;
		}

		// Token: 0x06003018 RID: 12312 RVA: 0x00091DE9 File Offset: 0x0008FFE9
		public CustomProperty(global::NPOI.HPSF.Property property) : this(property, "")
		{
		}

		// Token: 0x06003019 RID: 12313 RVA: 0x00091DF7 File Offset: 0x0008FFF7
		public CustomProperty(global::NPOI.HPSF.Property property, string name) : base(property)
		{
			this.name = name;
		}

		// Token: 0x17000C8C RID: 3212
		// (get) Token: 0x0600301A RID: 12314 RVA: 0x00091E07 File Offset: 0x00090007
		// (set) Token: 0x0600301B RID: 12315 RVA: 0x00091E0F File Offset: 0x0009000F
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		// Token: 0x0600301C RID: 12316 RVA: 0x00091E18 File Offset: 0x00090018
		public bool EqualsContents(object o)
		{
			global::NPOI.HPSF.CustomProperty customProperty = (global::NPOI.HPSF.CustomProperty)o;
			string text = customProperty.Name;
			string text2 = this.Name;
			bool flag;
			if (text == null)
			{
				flag = (text2 == null);
			}
			else
			{
				flag = text.Equals(text2);
			}
			return flag && customProperty.ID == this.ID && customProperty.Type == this.Type && customProperty.Value.Equals(this.Value);
		}

		// Token: 0x0600301D RID: 12317 RVA: 0x00091E80 File Offset: 0x00090080
		public override int GetHashCode()
		{
			return (int)this.ID;
		}

		// Token: 0x04001586 RID: 5510
		private string name;
	}
}
