using System;
using System.IO;
using System.Text;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Asn1.Utilities
{
	// Token: 0x02000693 RID: 1683
	public sealed class Asn1Dump
	{
		// Token: 0x06003DF7 RID: 15863 RVA: 0x0011A660 File Offset: 0x00118860
		private Asn1Dump()
		{
		}

		// Token: 0x06003DF8 RID: 15864 RVA: 0x0011A668 File Offset: 0x00118868
		private static void AsString(string indent, bool verbose, global::Org.BouncyCastle.Asn1.Asn1Object obj, global::System.Text.StringBuilder buf)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Null)
			{
				buf.Append(indent);
				buf.Append("NULL");
				buf.Append(global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.NewLine);
				return;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				buf.Append(indent);
				if (obj is global::Org.BouncyCastle.Asn1.BerSequence)
				{
					buf.Append("BER Sequence");
				}
				else if (obj is global::Org.BouncyCastle.Asn1.DerSequence)
				{
					buf.Append("DER Sequence");
				}
				else
				{
					buf.Append("Sequence");
				}
				buf.Append(global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.NewLine);
				global::Org.BouncyCastle.Asn1.Asn1Sequence sequence = (global::Org.BouncyCastle.Asn1.Asn1Sequence)obj;
				string elementsIndent = indent + "    ";
				int i = 0;
				int count = sequence.Count;
				while (i < count)
				{
					global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.AsString(elementsIndent, verbose, sequence[i].ToAsn1Object(), buf);
					i++;
				}
				return;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Set)
			{
				buf.Append(indent);
				if (obj is global::Org.BouncyCastle.Asn1.BerSet)
				{
					buf.Append("BER Set");
				}
				else if (obj is global::Org.BouncyCastle.Asn1.DerSet)
				{
					buf.Append("DER Set");
				}
				else
				{
					buf.Append("Set");
				}
				buf.Append(global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.NewLine);
				global::Org.BouncyCastle.Asn1.Asn1Set set = (global::Org.BouncyCastle.Asn1.Asn1Set)obj;
				string elementsIndent2 = indent + "    ";
				int j = 0;
				int count2 = set.Count;
				while (j < count2)
				{
					global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.AsString(elementsIndent2, verbose, set[j].ToAsn1Object(), buf);
					j++;
				}
				return;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				string tab = indent + "    ";
				buf.Append(indent);
				if (obj is global::Org.BouncyCastle.Asn1.BerTaggedObject)
				{
					buf.Append("BER Tagged [");
				}
				else
				{
					buf.Append("Tagged [");
				}
				global::Org.BouncyCastle.Asn1.Asn1TaggedObject o = (global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj;
				buf.Append(o.TagNo.ToString());
				buf.Append(']');
				if (!o.IsExplicit())
				{
					buf.Append(" IMPLICIT ");
				}
				buf.Append(global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.NewLine);
				if (o.IsEmpty())
				{
					buf.Append(tab);
					buf.Append("EMPTY");
					buf.Append(global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.NewLine);
					return;
				}
				global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.AsString(tab, verbose, o.GetObject(), buf);
				return;
			}
			else
			{
				if (obj is global::Org.BouncyCastle.Asn1.DerObjectIdentifier)
				{
					buf.Append(string.Concat(new string[]
					{
						indent,
						"ObjectIdentifier(",
						((global::Org.BouncyCastle.Asn1.DerObjectIdentifier)obj).Id,
						")",
						global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.NewLine
					}));
					return;
				}
				if (obj is global::Org.BouncyCastle.Asn1.DerBoolean)
				{
					buf.Append(string.Concat(new string[]
					{
						indent,
						"Boolean(",
						((global::Org.BouncyCastle.Asn1.DerBoolean)obj).IsTrue.ToString(),
						")",
						global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.NewLine
					}));
					return;
				}
				if (obj is global::Org.BouncyCastle.Asn1.DerInteger)
				{
					string[] array = new string[5];
					array[0] = indent;
					array[1] = "Integer(";
					int num = 2;
					global::Org.BouncyCastle.Math.BigInteger value = ((global::Org.BouncyCastle.Asn1.DerInteger)obj).Value;
					array[num] = ((value != null) ? value.ToString() : null);
					array[3] = ")";
					array[4] = global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.NewLine;
					buf.Append(string.Concat(array));
					return;
				}
				if (obj is global::Org.BouncyCastle.Asn1.BerOctetString)
				{
					byte[] octets = ((global::Org.BouncyCastle.Asn1.Asn1OctetString)obj).GetOctets();
					string extra = verbose ? global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.dumpBinaryDataAsString(indent, octets) : "";
					buf.Append(string.Concat(new string[]
					{
						indent,
						"BER Octet String[",
						octets.Length.ToString(),
						"] ",
						extra,
						global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.NewLine
					}));
					return;
				}
				if (obj is global::Org.BouncyCastle.Asn1.DerOctetString)
				{
					byte[] octets2 = ((global::Org.BouncyCastle.Asn1.Asn1OctetString)obj).GetOctets();
					string extra2 = verbose ? global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.dumpBinaryDataAsString(indent, octets2) : "";
					buf.Append(string.Concat(new string[]
					{
						indent,
						"DER Octet String[",
						octets2.Length.ToString(),
						"] ",
						extra2,
						global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.NewLine
					}));
					return;
				}
				if (obj is global::Org.BouncyCastle.Asn1.DerBitString)
				{
					global::Org.BouncyCastle.Asn1.DerBitString bt = (global::Org.BouncyCastle.Asn1.DerBitString)obj;
					byte[] bytes = bt.GetBytes();
					string extra3 = verbose ? global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.dumpBinaryDataAsString(indent, bytes) : "";
					buf.Append(string.Concat(new string[]
					{
						indent,
						"DER Bit String[",
						bytes.Length.ToString(),
						", ",
						bt.PadBits.ToString(),
						"] ",
						extra3,
						global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.NewLine
					}));
					return;
				}
				if (obj is global::Org.BouncyCastle.Asn1.DerIA5String)
				{
					buf.Append(string.Concat(new string[]
					{
						indent,
						"IA5String(",
						((global::Org.BouncyCastle.Asn1.DerIA5String)obj).GetString(),
						") ",
						global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.NewLine
					}));
					return;
				}
				if (obj is global::Org.BouncyCastle.Asn1.DerUtf8String)
				{
					buf.Append(string.Concat(new string[]
					{
						indent,
						"UTF8String(",
						((global::Org.BouncyCastle.Asn1.DerUtf8String)obj).GetString(),
						") ",
						global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.NewLine
					}));
					return;
				}
				if (obj is global::Org.BouncyCastle.Asn1.DerPrintableString)
				{
					buf.Append(string.Concat(new string[]
					{
						indent,
						"PrintableString(",
						((global::Org.BouncyCastle.Asn1.DerPrintableString)obj).GetString(),
						") ",
						global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.NewLine
					}));
					return;
				}
				if (obj is global::Org.BouncyCastle.Asn1.DerVisibleString)
				{
					buf.Append(string.Concat(new string[]
					{
						indent,
						"VisibleString(",
						((global::Org.BouncyCastle.Asn1.DerVisibleString)obj).GetString(),
						") ",
						global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.NewLine
					}));
					return;
				}
				if (obj is global::Org.BouncyCastle.Asn1.DerBmpString)
				{
					buf.Append(string.Concat(new string[]
					{
						indent,
						"BMPString(",
						((global::Org.BouncyCastle.Asn1.DerBmpString)obj).GetString(),
						") ",
						global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.NewLine
					}));
					return;
				}
				if (obj is global::Org.BouncyCastle.Asn1.DerT61String)
				{
					buf.Append(string.Concat(new string[]
					{
						indent,
						"T61String(",
						((global::Org.BouncyCastle.Asn1.DerT61String)obj).GetString(),
						") ",
						global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.NewLine
					}));
					return;
				}
				if (obj is global::Org.BouncyCastle.Asn1.DerGraphicString)
				{
					buf.Append(string.Concat(new string[]
					{
						indent,
						"GraphicString(",
						((global::Org.BouncyCastle.Asn1.DerGraphicString)obj).GetString(),
						") ",
						global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.NewLine
					}));
					return;
				}
				if (obj is global::Org.BouncyCastle.Asn1.DerVideotexString)
				{
					buf.Append(string.Concat(new string[]
					{
						indent,
						"VideotexString(",
						((global::Org.BouncyCastle.Asn1.DerVideotexString)obj).GetString(),
						") ",
						global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.NewLine
					}));
					return;
				}
				if (obj is global::Org.BouncyCastle.Asn1.DerUtcTime)
				{
					buf.Append(string.Concat(new string[]
					{
						indent,
						"UTCTime(",
						((global::Org.BouncyCastle.Asn1.DerUtcTime)obj).TimeString,
						") ",
						global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.NewLine
					}));
					return;
				}
				if (obj is global::Org.BouncyCastle.Asn1.DerGeneralizedTime)
				{
					buf.Append(string.Concat(new string[]
					{
						indent,
						"GeneralizedTime(",
						((global::Org.BouncyCastle.Asn1.DerGeneralizedTime)obj).GetTime(),
						") ",
						global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.NewLine
					}));
					return;
				}
				if (obj is global::Org.BouncyCastle.Asn1.BerApplicationSpecific)
				{
					buf.Append(global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.outputApplicationSpecific("BER", indent, verbose, (global::Org.BouncyCastle.Asn1.BerApplicationSpecific)obj));
					return;
				}
				if (obj is global::Org.BouncyCastle.Asn1.DerApplicationSpecific)
				{
					buf.Append(global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.outputApplicationSpecific("DER", indent, verbose, (global::Org.BouncyCastle.Asn1.DerApplicationSpecific)obj));
					return;
				}
				if (obj is global::Org.BouncyCastle.Asn1.DerEnumerated)
				{
					global::Org.BouncyCastle.Asn1.DerEnumerated en = (global::Org.BouncyCastle.Asn1.DerEnumerated)obj;
					string[] array2 = new string[5];
					array2[0] = indent;
					array2[1] = "DER Enumerated(";
					int num2 = 2;
					global::Org.BouncyCastle.Math.BigInteger value2 = en.Value;
					array2[num2] = ((value2 != null) ? value2.ToString() : null);
					array2[3] = ")";
					array2[4] = global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.NewLine;
					buf.Append(string.Concat(array2));
					return;
				}
				if (obj is global::Org.BouncyCastle.Asn1.DerExternal)
				{
					global::Org.BouncyCastle.Asn1.DerExternal ext = (global::Org.BouncyCastle.Asn1.DerExternal)obj;
					buf.Append(indent + "External " + global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.NewLine);
					string tab2 = indent + "    ";
					if (ext.DirectReference != null)
					{
						buf.Append(tab2 + "Direct Reference: " + ext.DirectReference.Id + global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.NewLine);
					}
					if (ext.IndirectReference != null)
					{
						buf.Append(tab2 + "Indirect Reference: " + ext.IndirectReference.ToString() + global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.NewLine);
					}
					if (ext.DataValueDescriptor != null)
					{
						global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.AsString(tab2, verbose, ext.DataValueDescriptor, buf);
					}
					buf.Append(tab2 + "Encoding: " + ext.Encoding.ToString() + global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.NewLine);
					global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.AsString(tab2, verbose, ext.ExternalContent, buf);
					return;
				}
				buf.Append(indent + obj.ToString() + global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.NewLine);
				return;
			}
		}

		// Token: 0x06003DF9 RID: 15865 RVA: 0x0011AF28 File Offset: 0x00119128
		private static string outputApplicationSpecific(string type, string indent, bool verbose, global::Org.BouncyCastle.Asn1.DerApplicationSpecific app)
		{
			global::System.Text.StringBuilder buf = new global::System.Text.StringBuilder();
			if (app.IsConstructed())
			{
				try
				{
					global::Org.BouncyCastle.Asn1.Asn1Sequence s = global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(app.GetObject(16));
					buf.Append(string.Concat(new string[]
					{
						indent,
						type,
						" ApplicationSpecific[",
						app.ApplicationTag.ToString(),
						"]",
						global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.NewLine
					}));
					foreach (object obj in s)
					{
						global::Org.BouncyCastle.Asn1.Asn1Encodable ae = (global::Org.BouncyCastle.Asn1.Asn1Encodable)obj;
						global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.AsString(indent + "    ", verbose, ae.ToAsn1Object(), buf);
					}
				}
				catch (global::System.IO.IOException e)
				{
					buf.Append(e);
				}
				return buf.ToString();
			}
			return string.Concat(new string[]
			{
				indent,
				type,
				" ApplicationSpecific[",
				app.ApplicationTag.ToString(),
				"] (",
				global::Org.BouncyCastle.Utilities.Encoders.Hex.ToHexString(app.GetContents()),
				")",
				global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.NewLine
			});
		}

		// Token: 0x06003DFA RID: 15866 RVA: 0x0011B068 File Offset: 0x00119268
		public static string DumpAsString(global::Org.BouncyCastle.Asn1.Asn1Encodable obj)
		{
			return global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.DumpAsString(obj, false);
		}

		// Token: 0x06003DFB RID: 15867 RVA: 0x0011B074 File Offset: 0x00119274
		public static string DumpAsString(global::Org.BouncyCastle.Asn1.Asn1Encodable obj, bool verbose)
		{
			global::System.Text.StringBuilder buf = new global::System.Text.StringBuilder();
			global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.AsString("", verbose, obj.ToAsn1Object(), buf);
			return buf.ToString();
		}

		// Token: 0x06003DFC RID: 15868 RVA: 0x0011B0A0 File Offset: 0x001192A0
		private static string dumpBinaryDataAsString(string indent, byte[] bytes)
		{
			indent += "    ";
			global::System.Text.StringBuilder buf = new global::System.Text.StringBuilder(global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.NewLine);
			for (int i = 0; i < bytes.Length; i += 32)
			{
				if (bytes.Length - i > 32)
				{
					buf.Append(indent);
					buf.Append(global::Org.BouncyCastle.Utilities.Encoders.Hex.ToHexString(bytes, i, 32));
					buf.Append("    ");
					buf.Append(global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.calculateAscString(bytes, i, 32));
					buf.Append(global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.NewLine);
				}
				else
				{
					buf.Append(indent);
					buf.Append(global::Org.BouncyCastle.Utilities.Encoders.Hex.ToHexString(bytes, i, bytes.Length - i));
					for (int j = bytes.Length - i; j != 32; j++)
					{
						buf.Append("  ");
					}
					buf.Append("    ");
					buf.Append(global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.calculateAscString(bytes, i, bytes.Length - i));
					buf.Append(global::Org.BouncyCastle.Asn1.Utilities.Asn1Dump.NewLine);
				}
			}
			return buf.ToString();
		}

		// Token: 0x06003DFD RID: 15869 RVA: 0x0011B190 File Offset: 0x00119390
		private static string calculateAscString(byte[] bytes, int off, int len)
		{
			global::System.Text.StringBuilder buf = new global::System.Text.StringBuilder();
			for (int i = off; i != off + len; i++)
			{
				char c = (char)bytes[i];
				if (c >= ' ' && c <= '~')
				{
					buf.Append(c);
				}
			}
			return buf.ToString();
		}

		// Token: 0x04001BAB RID: 7083
		private static readonly string NewLine = global::Org.BouncyCastle.Utilities.Platform.NewLine;

		// Token: 0x04001BAC RID: 7084
		private const string Tab = "    ";

		// Token: 0x04001BAD RID: 7085
		private const int SampleSize = 32;
	}
}
