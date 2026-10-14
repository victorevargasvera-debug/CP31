using System;
using System.IO;
using System.Text;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Asn1.X500.Style
{
	// Token: 0x02000692 RID: 1682
	public abstract class IetfUtilities
	{
		// Token: 0x06003DEF RID: 15855 RVA: 0x0011A280 File Offset: 0x00118480
		public static string ValueToString(global::Org.BouncyCastle.Asn1.Asn1Encodable value)
		{
			global::System.Text.StringBuilder vBuf = new global::System.Text.StringBuilder();
			if (value is global::Org.BouncyCastle.Asn1.IAsn1String && !(value is global::Org.BouncyCastle.Asn1.DerUniversalString))
			{
				string v = ((global::Org.BouncyCastle.Asn1.IAsn1String)value).GetString();
				if (v.Length > 0 && v[0] == '#')
				{
					vBuf.Append('\\');
				}
				vBuf.Append(v);
			}
			else
			{
				try
				{
					vBuf.Append('#');
					vBuf.Append(global::Org.BouncyCastle.Utilities.Encoders.Hex.ToHexString(value.ToAsn1Object().GetEncoded("DER")));
				}
				catch (global::System.IO.IOException e)
				{
					throw new global::System.ArgumentException("Other value has no encoded form", e);
				}
			}
			int end = vBuf.Length;
			int index = 0;
			if (vBuf.Length >= 2 && vBuf[0] == '\\' && vBuf[1] == '#')
			{
				index += 2;
			}
			while (index != end)
			{
				char c = vBuf[index];
				if (c <= '+')
				{
					if (c != '"' && c != '+')
					{
						goto IL_10C;
					}
				}
				else if (c != ',')
				{
					switch (c)
					{
					case ';':
					case '<':
					case '=':
					case '>':
						break;
					default:
						if (c != '\\')
						{
							goto IL_10C;
						}
						break;
					}
				}
				vBuf.Insert(index, "\\");
				index += 2;
				end++;
				continue;
				IL_10C:
				index++;
			}
			int start = 0;
			if (vBuf.Length > 0)
			{
				while (vBuf.Length > start && vBuf[start] == ' ')
				{
					vBuf.Insert(start, "\\");
					start += 2;
				}
			}
			int endBuf = vBuf.Length - 1;
			while (endBuf >= 0 && vBuf[endBuf] == ' ')
			{
				vBuf.Insert(endBuf, "\\");
				endBuf--;
			}
			return vBuf.ToString();
		}

		// Token: 0x06003DF0 RID: 15856 RVA: 0x0011A41C File Offset: 0x0011861C
		public static string Canonicalize(string s)
		{
			string value = global::Org.BouncyCastle.Utilities.Platform.ToLowerInvariant(s);
			if (value.Length > 0 && value[0] == '#')
			{
				global::Org.BouncyCastle.Asn1.Asn1Object obj = global::Org.BouncyCastle.Asn1.X500.Style.IetfUtilities.DecodeObject(value);
				if (obj is global::Org.BouncyCastle.Asn1.IAsn1String)
				{
					value = global::Org.BouncyCastle.Utilities.Platform.ToLowerInvariant(((global::Org.BouncyCastle.Asn1.IAsn1String)obj).GetString());
				}
			}
			if (value.Length > 1)
			{
				int start = 0;
				while (start + 1 < value.Length && value[start] == '\\' && value[start + 1] == ' ')
				{
					start += 2;
				}
				int end = value.Length - 1;
				while (end - 1 > 0 && value[end - 1] == '\\' && value[end] == ' ')
				{
					end -= 2;
				}
				if (start > 0 || end < value.Length - 1)
				{
					value = value.Substring(start, end + 1 - start);
				}
			}
			return global::Org.BouncyCastle.Asn1.X500.Style.IetfUtilities.StripInternalSpaces(value);
		}

		// Token: 0x06003DF1 RID: 15857 RVA: 0x0011A4E7 File Offset: 0x001186E7
		public static string CanonicalString(global::Org.BouncyCastle.Asn1.Asn1Encodable value)
		{
			return global::Org.BouncyCastle.Asn1.X500.Style.IetfUtilities.Canonicalize(global::Org.BouncyCastle.Asn1.X500.Style.IetfUtilities.ValueToString(value));
		}

		// Token: 0x06003DF2 RID: 15858 RVA: 0x0011A4F4 File Offset: 0x001186F4
		private static global::Org.BouncyCastle.Asn1.Asn1Object DecodeObject(string oValue)
		{
			global::Org.BouncyCastle.Asn1.Asn1Object result;
			try
			{
				result = global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict(oValue, 1, oValue.Length - 1));
			}
			catch (global::System.IO.IOException e)
			{
				string str = "unknown encoding in name: ";
				global::System.IO.IOException ex = e;
				throw new global::System.InvalidOperationException(str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x06003DF3 RID: 15859 RVA: 0x0011A548 File Offset: 0x00118748
		public static string StripInternalSpaces(string str)
		{
			if (str.IndexOf("  ") < 0)
			{
				return str;
			}
			global::System.Text.StringBuilder res = new global::System.Text.StringBuilder();
			char c = str[0];
			res.Append(c);
			for (int i = 1; i < str.Length; i++)
			{
				char c2 = str[i];
				if (' ' != c || ' ' != c2)
				{
					res.Append(c2);
					c = c2;
				}
			}
			return res.ToString();
		}

		// Token: 0x06003DF4 RID: 15860 RVA: 0x0011A5B0 File Offset: 0x001187B0
		public static bool RdnAreEqual(global::Org.BouncyCastle.Asn1.X500.Rdn rdn1, global::Org.BouncyCastle.Asn1.X500.Rdn rdn2)
		{
			if (rdn1.Count != rdn2.Count)
			{
				return false;
			}
			global::Org.BouncyCastle.Asn1.X500.AttributeTypeAndValue[] atvs = rdn1.GetTypesAndValues();
			global::Org.BouncyCastle.Asn1.X500.AttributeTypeAndValue[] atvs2 = rdn2.GetTypesAndValues();
			if (atvs.Length != atvs2.Length)
			{
				return false;
			}
			for (int i = 0; i != atvs.Length; i++)
			{
				if (!global::Org.BouncyCastle.Asn1.X500.Style.IetfUtilities.AtvAreEqual(atvs[i], atvs2[i]))
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06003DF5 RID: 15861 RVA: 0x0011A604 File Offset: 0x00118804
		private static bool AtvAreEqual(global::Org.BouncyCastle.Asn1.X500.AttributeTypeAndValue atv1, global::Org.BouncyCastle.Asn1.X500.AttributeTypeAndValue atv2)
		{
			if (atv1 == atv2)
			{
				return true;
			}
			if (atv1 == null || atv2 == null)
			{
				return false;
			}
			object type = atv1.Type;
			global::Org.BouncyCastle.Asn1.DerObjectIdentifier o2 = atv2.Type;
			if (!type.Equals(o2))
			{
				return false;
			}
			string text = global::Org.BouncyCastle.Asn1.X500.Style.IetfUtilities.CanonicalString(atv1.Value);
			string v2 = global::Org.BouncyCastle.Asn1.X500.Style.IetfUtilities.CanonicalString(atv2.Value);
			return text.Equals(v2);
		}
	}
}
