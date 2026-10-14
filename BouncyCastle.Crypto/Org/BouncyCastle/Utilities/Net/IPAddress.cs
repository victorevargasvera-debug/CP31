using System;
using System.Globalization;

namespace Org.BouncyCastle.Utilities.Net
{
	// Token: 0x0200004B RID: 75
	public class IPAddress
	{
		// Token: 0x0600037A RID: 890 RVA: 0x0001387D File Offset: 0x00011A7D
		public static bool IsValid(string address)
		{
			return global::Org.BouncyCastle.Utilities.Net.IPAddress.IsValidIPv4(address) || global::Org.BouncyCastle.Utilities.Net.IPAddress.IsValidIPv6(address);
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0001388F File Offset: 0x00011A8F
		public static bool IsValidWithNetMask(string address)
		{
			return global::Org.BouncyCastle.Utilities.Net.IPAddress.IsValidIPv4WithNetmask(address) || global::Org.BouncyCastle.Utilities.Net.IPAddress.IsValidIPv6WithNetmask(address);
		}

		// Token: 0x0600037C RID: 892 RVA: 0x000138A4 File Offset: 0x00011AA4
		public static bool IsValidIPv4(string address)
		{
			try
			{
				return global::Org.BouncyCastle.Utilities.Net.IPAddress.unsafeIsValidIPv4(address);
			}
			catch (global::System.FormatException)
			{
			}
			catch (global::System.OverflowException)
			{
			}
			return false;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x000138E0 File Offset: 0x00011AE0
		private static bool unsafeIsValidIPv4(string address)
		{
			if (address.Length == 0)
			{
				return false;
			}
			int octets = 0;
			string temp = address + ".";
			int start = 0;
			int pos;
			while (start < temp.Length && (pos = temp.IndexOf('.', start)) > start)
			{
				if (octets == 4)
				{
					return false;
				}
				int octet = int.Parse(temp.Substring(start, pos - start));
				if (octet < 0 || octet > 255)
				{
					return false;
				}
				start = pos + 1;
				octets++;
			}
			return octets == 4;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00013954 File Offset: 0x00011B54
		public static bool IsValidIPv4WithNetmask(string address)
		{
			int index = address.IndexOf('/');
			string mask = address.Substring(index + 1);
			return index > 0 && global::Org.BouncyCastle.Utilities.Net.IPAddress.IsValidIPv4(address.Substring(0, index)) && (global::Org.BouncyCastle.Utilities.Net.IPAddress.IsValidIPv4(mask) || global::Org.BouncyCastle.Utilities.Net.IPAddress.IsMaskValue(mask, 32));
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0001399C File Offset: 0x00011B9C
		public static bool IsValidIPv6WithNetmask(string address)
		{
			int index = address.IndexOf('/');
			string mask = address.Substring(index + 1);
			return index > 0 && global::Org.BouncyCastle.Utilities.Net.IPAddress.IsValidIPv6(address.Substring(0, index)) && (global::Org.BouncyCastle.Utilities.Net.IPAddress.IsValidIPv6(mask) || global::Org.BouncyCastle.Utilities.Net.IPAddress.IsMaskValue(mask, 128));
		}

		// Token: 0x06000380 RID: 896 RVA: 0x000139E8 File Offset: 0x00011BE8
		private static bool IsMaskValue(string component, int size)
		{
			int val = int.Parse(component);
			try
			{
				return val >= 0 && val <= size;
			}
			catch (global::System.FormatException)
			{
			}
			catch (global::System.OverflowException)
			{
			}
			return false;
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00013A34 File Offset: 0x00011C34
		public static bool IsValidIPv6(string address)
		{
			try
			{
				return global::Org.BouncyCastle.Utilities.Net.IPAddress.unsafeIsValidIPv6(address);
			}
			catch (global::System.FormatException)
			{
			}
			catch (global::System.OverflowException)
			{
			}
			return false;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00013A70 File Offset: 0x00011C70
		private static bool unsafeIsValidIPv6(string address)
		{
			if (address.Length == 0)
			{
				return false;
			}
			int octets = 0;
			string temp = address + ":";
			bool doubleColonFound = false;
			int start = 0;
			int pos;
			while (start < temp.Length && (pos = temp.IndexOf(':', start)) >= start)
			{
				if (octets == 8)
				{
					return false;
				}
				if (start != pos)
				{
					string value = temp.Substring(start, pos - start);
					if (pos == temp.Length - 1 && value.IndexOf('.') > 0)
					{
						if (!global::Org.BouncyCastle.Utilities.Net.IPAddress.IsValidIPv4(value))
						{
							return false;
						}
						octets++;
					}
					else
					{
						int octet = int.Parse(temp.Substring(start, pos - start), global::System.Globalization.NumberStyles.AllowHexSpecifier);
						if (octet < 0 || octet > 65535)
						{
							return false;
						}
					}
				}
				else
				{
					if (pos != 1 && pos != temp.Length - 1 && doubleColonFound)
					{
						return false;
					}
					doubleColonFound = true;
				}
				start = pos + 1;
				octets++;
			}
			return octets == 8 || doubleColonFound;
		}
	}
}
