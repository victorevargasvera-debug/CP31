using System;
using System.Collections;
using System.Collections.Generic;
using Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes;

namespace Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing
{
	// Token: 0x02000105 RID: 261
	public class PasteStatusCollection : global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.IFailType>, global::System.Collections.IEnumerable
	{
		// Token: 0x06000CAE RID: 3246 RVA: 0x000BE350 File Offset: 0x000BC550
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			short num = (short)856752128;
			short num2 = num;
			num = (short)1756758017;
			if (num != 0)
			{
			}
			num = (short)1686431264;
			short num3 = num;
			num = (short)52946464;
			switch (num3 == num)
			{
			}
			num = (short)1309343744;
			if (num != 0)
			{
			}
			return this.GetEnumerator();
		}

		// Token: 0x06000CAF RID: 3247 RVA: 0x000BE404 File Offset: 0x000BC604
		public global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.IFailType> GetEnumerator()
		{
			short num = (short)1034289152;
			short num2 = num;
			num = (short)309305346;
			short num3 = num;
			num = (short)1312202754;
			switch (num3 == num)
			{
			}
			num = (short)191627265;
			if (num != 0)
			{
			}
			num = (short)121634816;
			if (num != 0)
			{
			}
			return this.a.GetEnumerator();
		}

		// Token: 0x06000CB0 RID: 3248 RVA: 0x000BE4C0 File Offset: 0x000BC6C0
		public void SetAddingFailed(global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory parent, string setIdentifier)
		{
			short num = (short)1856110592;
			short num2 = num;
			num = (short)72343380;
			short num3 = num;
			num = (short)1945034580;
			switch (num3 == num)
			{
			}
			num = (short)2008023040;
			if (num != 0)
			{
			}
			num = (short)231276545;
			if (num != 0)
			{
			}
			this.a(new global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetAddingFailed(parent, setIdentifier));
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x000BE578 File Offset: 0x000BC778
		public void ClearSetAddingFailed(global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory parent, string setKey)
		{
			short num = (short)2047737856;
			short num2 = num;
			num = (short)1418301457;
			short num3 = num;
			num = (short)1050316817;
			switch (num3 == num)
			{
			}
			num = (short)1282670592;
			if (num != 0)
			{
			}
			num = (short)780992513;
			if (num != 0)
			{
			}
			this.a.RemoveWhere(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.IFailType fail)
			{
				short num4;
				if (fail.Model != parent)
				{
					num4 = (short)822116434;
					short num5 = num4;
					num4 = (short)755925074;
					switch ((num5 == num4) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num4 = (short)1721892864;
						if (num4 != 0)
						{
						}
						num4 = (short)1805778945;
						if (num4 != 0)
						{
						}
						return false;
					}
				}
				num4 = (short)662831104;
				short num6 = num4;
				return fail.InvalidValue == setKey;
			});
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x000BE650 File Offset: 0x000BC850
		public void SetCountMaxLimitReached(global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory)
		{
			short num = (short)1743716352;
			short num2 = num;
			num = (short)1226956966;
			short num3 = num;
			num = (short)1302519974;
			switch (num3 == num)
			{
			}
			num = (short)1714618369;
			if (num != 0)
			{
			}
			num = (short)1764884480;
			if (num != 0)
			{
			}
			this.a(new global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached(setCategory));
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x000BE704 File Offset: 0x000BC904
		public void ClearSetCountMaxLimitReached(global::Motorola.CommonCPS.RadioManagement.UIModels.SetCategory setCategory)
		{
			short num = (short)59179008;
			short num2 = num;
			num = (short)1095958529;
			if (num != 0)
			{
			}
			num = (short)1511835660;
			short num3 = num;
			num = (short)1541064716;
			switch (num3 == num)
			{
			}
			num = (short)2042232832;
			if (num != 0)
			{
			}
			this.a.RemoveWhere(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.IFailType fail)
			{
				short num4 = (short)1160942874;
				short num5 = num4;
				num4 = (short)933074202;
				switch (num5 == num4)
				{
				}
				num4 = (short)1802895361;
				if (num4 != 0)
				{
				}
				num4 = (short)566624256;
				if (num4 != 0)
				{
				}
				num4 = (short)1280901120;
				short num6 = num4;
				return fail.Model == setCategory;
			});
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x000BE7D4 File Offset: 0x000BC9D4
		public void SetCountMinLimitReached(global::Motorola.CommonCPS.RadioManagement.UIModels.Set set)
		{
			short num = (short)1948385280;
			short num2 = num;
			num = (short)1804715022;
			short num3 = num;
			num = (short)187221006;
			switch (num3 == num)
			{
			}
			num = (short)1283588097;
			if (num != 0)
			{
			}
			num = (short)874184704;
			if (num != 0)
			{
			}
			this.a(new global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMinLimitReached(set));
		}

		// Token: 0x06000CB5 RID: 3253 RVA: 0x000BE88C File Offset: 0x000BCA8C
		public void ClearSetCountMinLimitReached(global::Motorola.CommonCPS.RadioManagement.UIModels.Set set)
		{
			int a_ = 11;
			short num = (short)1851412716;
			short num2 = num;
			num = (short)824594668;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1233911808;
				short num3 = num;
				num = (short)239403009;
				if (num != 0)
				{
				}
				num = (short)440401920;
				if (num != 0)
				{
				}
				if (set != null)
				{
					this.a.RemoveWhere(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.IFailType fail)
					{
						short num4 = (short)385767900;
						short num5 = num4;
						num4 = (short)1477859804;
						switch (num5 == num4)
						{
						}
						num4 = (short)1147404288;
						if (num4 != 0)
						{
						}
						num4 = (short)1910177793;
						if (num4 != 0)
						{
						}
						num4 = (short)1877999616;
						short num6 = num4;
						global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMinLimitReached setCountMinLimitReached = fail as global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMinLimitReached;
						return ((setCountMinLimitReached != null) ? setCountMinLimitReached.Model : null) == set;
					});
					return;
				}
				break;
			}
			}
			throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("㕅ⵇ㹉", a_));
		}

		// Token: 0x06000CB6 RID: 3254 RVA: 0x000BE980 File Offset: 0x000BCB80
		public void FieldNotFound(global::Motorola.CommonCPS.RadioManagement.UIModels.Set set, string fieldName)
		{
			short num = (short)186449920;
			short num2 = num;
			num = (short)1201143809;
			if (num != 0)
			{
			}
			num = (short)576604739;
			short num3 = num;
			num = (short)1597590083;
			switch (num3 == num)
			{
			}
			num = (short)1187381248;
			if (num != 0)
			{
			}
			this.a(new global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.FieldNotFound(set, fieldName));
		}

		// Token: 0x06000CB7 RID: 3255 RVA: 0x000BEA38 File Offset: 0x000BCC38
		public void InvalidXmlNodeName(global::Motorola.CommonCPS.RadioManagement.UIModels.Set set, string childNodeName)
		{
			short num = (short)629342208;
			short num2 = num;
			num = (short)2079727337;
			short num3 = num;
			num = (short)69082857;
			switch (num3 == num)
			{
			}
			num = (short)1801781249;
			if (num != 0)
			{
			}
			num = (short)1458372608;
			if (num != 0)
			{
			}
			this.a(new global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.InvalidXmlNodeName(set, childNodeName));
		}

		// Token: 0x06000CB8 RID: 3256 RVA: 0x000BEAEC File Offset: 0x000BCCEC
		public void InvalidFieldValue(global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase field, string invalidValue)
		{
			short num = (short)411566080;
			short num2 = num;
			num = (short)779190854;
			short num3 = num;
			num = (short)1437106758;
			switch (num3 == num)
			{
			}
			num = (short)875036673;
			if (num != 0)
			{
			}
			num = (short)1880883200;
			if (num != 0)
			{
			}
			this.a(new global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.InvalidFieldValue(field, invalidValue));
		}

		// Token: 0x06000CB9 RID: 3257 RVA: 0x000BEBA4 File Offset: 0x000BCDA4
		public void ClearErrors(global::Motorola.CommonCPS.RadioManagement.UIModels.FieldBase field, string invalidValue = null)
		{
			int a_ = 2;
			short num = (short)300441652;
			short num2 = num;
			num = (short)1860395060;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)475529216;
				short num3 = num;
				num = (short)761397249;
				if (num != 0)
				{
				}
				num = (short)1268776960;
				if (num != 0)
				{
				}
				if (field != null)
				{
					this.a.RemoveWhere(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.IFailType fail)
					{
						if (fail.Model == field)
						{
							short num4 = (short)1051459585;
							if (num4 != 0)
							{
							}
							num4 = (short)173015040;
							short num5 = num4;
						}
						else
						{
							short num4 = (short)1702082891;
							short num6 = num4;
							num4 = (short)914929995;
							switch ((num6 == num4) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num4 = (short)396623872;
								if (num4 != 0)
								{
								}
								return false;
							}
						}
						return fail.InvalidValue == invalidValue;
					});
					return;
				}
				break;
			}
			}
			throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("嬼嘾⑀⽂⅄", a_));
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x000BECA0 File Offset: 0x000BCEA0
		private void a(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.IFailType A_0)
		{
			short num = (short)532021248;
			short num2 = num;
			num = (short)1423130811;
			short num3 = num;
			num = (short)584925371;
			switch (num3 == num)
			{
			}
			num = (short)1582956544;
			if (num != 0)
			{
			}
			num = (short)699793409;
			if (num != 0)
			{
			}
			this.a.Add(A_0);
		}

		// Token: 0x0400047D RID: 1149
		private readonly global::System.Collections.Generic.HashSet<global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.IFailType> a = new global::System.Collections.Generic.HashSet<global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.IFailType>(new global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.PasteStatusCollection.FailTypeComparer());

		// Token: 0x02000106 RID: 262
		private class FailTypeComparer : global::System.Collections.Generic.IEqualityComparer<global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.IFailType>
		{
			// Token: 0x06000CBC RID: 3260 RVA: 0x000BED7C File Offset: 0x000BCF7C
			public bool Equals(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.IFailType x, global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.IFailType y)
			{
				short num = (short)914685957;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1085341702;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return true;
					case 2:
						goto IL_18D;
					case 3:
						if (x.GetType() == y.GetType())
						{
							num = (short)1030750208;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CA;
					case 4:
						num = (short)2024013825;
						if (num != 0)
						{
						}
						num = (short)156303369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_4D;
						}
						continue;
					case 6:
						if (x.Model.Equals(y.Model))
						{
							num = (short)769785858;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CA;
					case 7:
						if (x != null)
						{
							num = (short)1423966212;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 8:
						goto IL_1C5;
					case 9:
						if (y == null)
						{
							num = (short)1180303368;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1587150851;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4D;
					IL_51:
					num = (short)961347585;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CA:
					num = (short)2068529323;
					short num3 = num;
					num = (short)381960363;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_51;
					default:
						goto IL_1FF;
					}
					IL_4D:
					if (x == y)
					{
						goto IL_51;
					}
					num = (short)1122041856;
					short num4 = num;
					num = (short)670433287;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_18D:
				return x.InvalidValue == y.InvalidValue;
				IL_1C5:
				return false;
				IL_1FF:
				num = (short)2039349248;
				if (num != 0)
				{
				}
				return false;
			}

			// Token: 0x06000CBD RID: 3261 RVA: 0x000BEFA0 File Offset: 0x000BD1A0
			public int GetHashCode(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.IFailType obj)
			{
				int a_ = 7;
				short num = (short)569974428;
				short num2 = num;
				num = (short)2049056412;
				switch (num2 == num)
				{
				}
				num = (short)771883009;
				if (num != 0)
				{
				}
				num = (short)1052966912;
				if (num != 0)
				{
				}
				num = (short)1611137024;
				short num3 = num;
				return string.Format(global::Motorola.CommonCPS.RadioManagement.UIModels.ConfigurationEditor.CopyPaste.Failing.FailTypes.SetCountMaxLimitReached.b("㥁瑃㭅晇ㅉ絋㍍繏⥑晓⭕癗⅙潛⍝", a_), new object[]
				{
					obj.GetType().Name,
					obj.Model.GetType().Name,
					obj.Model.ID,
					obj.InvalidValue
				}).GetHashCode();
			}
		}
	}
}
