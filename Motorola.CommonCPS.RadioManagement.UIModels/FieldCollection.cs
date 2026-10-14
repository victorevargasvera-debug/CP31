using System;
using System.Collections;
using System.Collections.Generic;

namespace Motorola.CommonCPS.RadioManagement.UIModels
{
	// Token: 0x020000BC RID: 188
	public class FieldCollection : global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase>, global::System.Collections.IEnumerable
	{
		// Token: 0x1700035D RID: 861
		// (get) Token: 0x06000741 RID: 1857 RVA: 0x0006A0E8 File Offset: 0x000682E8
		public static global::Motorola.CommonCPS.RadioManagement.UIModels.FieldCollection Null
		{
			get
			{
				short num = (short)929366016;
				short num2 = num;
				num = (short)505020417;
				if (num != 0)
				{
				}
				num = (short)924745365;
				short num3 = num;
				num = (short)2076212885;
				switch (num3 == num)
				{
				}
				num = (short)1179320320;
				if (num != 0)
				{
				}
				return global::Motorola.CommonCPS.RadioManagement.UIModels.FieldCollection.a;
			}
		}

		// Token: 0x1700035E RID: 862
		// (get) Token: 0x06000742 RID: 1858 RVA: 0x0006A198 File Offset: 0x00068398
		public int Count
		{
			get
			{
				short num = (short)1929510912;
				short num2 = num;
				num = (short)765218612;
				short num3 = num;
				num = (short)1307332404;
				switch (num3 == num)
				{
				}
				num = (short)412418049;
				if (num != 0)
				{
				}
				num = (short)1510080512;
				if (num != 0)
				{
				}
				return this.b.Count;
			}
		}

		// Token: 0x1700035F RID: 863
		public virtual global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase this[string fieldName]
		{
			get
			{
				short num;
				for (;;)
				{
					num = (short)167313408;
					short num2 = num;
					if (this.b.ContainsKey(fieldName))
					{
						goto IL_B1;
					}
					num = (short)1724370360;
					short num3 = num;
					num = (short)944033208;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_6F;
					}
				}
				IL_6F:
				num = (short)1859649537;
				if (num != 0)
				{
				}
				num = (short)2039676928;
				if (num != 0)
				{
				}
				return new global::Motorola.CommonCPS.RadioManagement.UIModels.NullField();
				IL_B1:
				return this.b[fieldName];
			}
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x0006A318 File Offset: 0x00068518
		public void Add(global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase field)
		{
			short num = (short)935133184;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 1:
					if (field is global::Motorola.CommonCPS.RadioManagement.UIModels.NullField)
					{
						num = (short)1166802949;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_89;
				case 2:
					goto IL_5E;
				case 3:
					goto IL_18A;
				case 4:
				{
					num = (short)1055254898;
					short num3 = num;
					num = (short)1857350002;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5E;
					default:
						num = (short)1473773568;
						if (num != 0)
						{
						}
						num = (short)1624571910;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					goto IL_147;
				case 6:
					goto IL_79;
				case 7:
					if (field != null)
					{
						num = (short)1897791492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1707540483;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_45:
				if (field != null)
				{
					num = (short)2040856578;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_89;
				IL_5E:
				num = (short)13697025;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_89:
				num = (short)649789447;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_79:
			string.IsNullOrEmpty(field.Name);
			goto IL_1B6;
			IL_147:
			num = (short)866451456;
			short num4 = num;
			num = (short)1602158593;
			if (num != 0)
			{
			}
			return;
			IL_18A:
			IL_1B6:
			bool flag = this.b.ContainsKey(field.Name);
			this.b.Add(field.Name, field);
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x0006A504 File Offset: 0x00068704
		public void Remove(string name)
		{
			short num = (short)1241120769;
			if (num != 0)
			{
			}
			num = (short)2037648237;
			short num2 = num;
			num = (short)1305086829;
			switch (num2 == num)
			{
			default:
			{
				num = (short)178520064;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)810024960;
			if (num != 0)
			{
			}
			this.b.Remove(name);
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x0006A5BC File Offset: 0x000687BC
		public virtual bool ContainsFieldName(string fieldName)
		{
			short num = (short)907108442;
			short num2 = num;
			num = (short)2096259162;
			switch (num2 == num)
			{
			}
			num = (short)1409482752;
			short num3 = num;
			num = (short)1238761472;
			if (num != 0)
			{
			}
			num = (short)1194590209;
			if (num != 0)
			{
			}
			return this.b.ContainsKey(fieldName);
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x0006A670 File Offset: 0x00068870
		public global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase> GetEnumerator()
		{
			short num = (short)1864322250;
			short num2 = num;
			num = (short)297684170;
			switch (num2 == num)
			{
			}
			num = (short)1727856640;
			short num3 = num;
			num = (short)1739128833;
			if (num != 0)
			{
			}
			num = (short)86769664;
			if (num != 0)
			{
			}
			return this.b.Values.GetEnumerator();
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x0006A734 File Offset: 0x00068934
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			short num = (short)1591347402;
			short num2 = num;
			num = (short)981076170;
			switch (num2 == num)
			{
			}
			num = (short)437780480;
			short num3 = num;
			num = (short)318767105;
			if (num != 0)
			{
			}
			num = (short)1288306688;
			if (num != 0)
			{
			}
			return this.b.Values.GetEnumerator();
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x0006A814 File Offset: 0x00068A14
		// Note: this type is marked as 'beforefieldinit'.
		static FieldCollection()
		{
			short num = (short)297429005;
			short num2 = num;
			num = (short)1144547341;
			switch (num2 == num)
			{
			}
			num = (short)608632832;
			short num3 = num;
			num = (short)1692794881;
			if (num != 0)
			{
			}
			num = (short)1891565568;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.FieldCollection.a = new global::Motorola.CommonCPS.RadioManagement.UIModels.FieldCollection.NullFieldCollection();
		}

		// Token: 0x04000303 RID: 771
		private static readonly global::Motorola.CommonCPS.RadioManagement.UIModels.FieldCollection a;

		// Token: 0x04000304 RID: 772
		private global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase> b = new global::System.Collections.Generic.Dictionary<string, global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase>();

		// Token: 0x020000BD RID: 189
		private class NullFieldCollection : global::Motorola.CommonCPS.RadioManagement.UIModels.FieldCollection
		{
			// Token: 0x17000360 RID: 864
			public override global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase this[string fieldName]
			{
				get
				{
					short num = (short)1766550581;
					short num2 = num;
					num = (short)24538165;
					switch (num2 == num)
					{
					}
					num = (short)1709572096;
					short num3 = num;
					num = (short)383713281;
					if (num != 0)
					{
					}
					num = (short)1277034496;
					if (num != 0)
					{
					}
					return global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase.Null;
				}
			}
		}
	}
}
