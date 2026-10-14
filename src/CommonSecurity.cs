using Motorola.Common.CustomException;
using SpecialFeatures.AcpReportManagerLib;
using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

internal class CommonSecurity
{
    private const uint a = 1;
    private const uint b = 0x18;

    public CommonSecurity()
    {
        base..ctor();
        return;
    }

    private static unsafe byte[] a(uint A_0)
    {
        byte[] buffer;
        RNGCryptoServiceProvider provider;
        int num;
        short num2;
        short num1;
        short num3;
        buffer = new byte[A_0];
        provider = new RNGCryptoServiceProvider();
    TR_0010:
        try
        {
            provider.GetBytes(buffer);
        }
        finally
        {
            num2 = -31026;
            switch ((((short) *(((short*) &num2))) == ((short) *(((short*) &-31026)))))
            {
                case 0:
                case 2:
                    goto TR_0003;

                default:
                TR_000A:
                    if (((short) *(((short*) &0))) != null)
                    {
                    }
                TR_0009:
                    num2 = 1;
                    num1 = (short) *(((short*) &num2));
                TR_0008:
                    if (num1 != null)
                    {
                    }
                TR_0007:
                    num = (IntPtr) ((short) *(((short*) &0)));
                    break;
            }
            goto TR_0006;
        TR_0001:;
        TR_0002:
            if (provider == null)
            {
                goto TR_0001;
            }
            else
            {
                num2 = 2;
                num = (IntPtr) ((short) *(((short*) &num2)));
            }
            goto TR_0006;
        TR_0003:
            switch (0)
            {
                case 0:
                    break;

                default:
                    goto TR_0006;
            }
            goto TR_0002;
        TR_0006:
            while (true)
            {
                switch (num)
                {
                    case 0:
                        break;

                    case 1:
                        goto TR_0001;

                    case 2:
                    {
                        provider.Dispose();
                        num2 = 1;
                        num = (IntPtr) ((short) *(((short*) &num2)));
                        continue;
                    }
                    default:
                        goto TR_0002;
                }
                break;
            }
            goto TR_0003;
        }
    TR_000E:
        num3 = (short) *(((short*) &0));
        short local1 = num3;
        return buffer;
    }

    private static unsafe string a(DateTime A_0, string A_1)
    {
        int num;
        int num2;
        string str;
        string str2;
        string str3;
        int num3;
        byte num4;
        char ch;
        ASCIIEncoding encoding;
        byte[] buffer;
        byte[] buffer2;
        int num5;
        byte[] buffer3;
        int num6;
        short num7;
        char ch2;
        int num8;
        SHA256 sha;
        int num9;
        short num10;
        int num11;
        short num12;
        short num13;
        num11 = 11;
        num9 = (short) *(((short*) &0));
        switch (num9)
        {
            default:
            TR_004D:
                switch (0)
                {
                    case 0:
                        goto TR_0000;

                    default:
                        break;
                }
                break;
        }
        goto TR_004C;
    TR_0000:
        num = A_0.Day;
        num2 = A_0.Month;
        int num1 = A_0.Year;
        str = RptMgrErrorHandler.b("힑ﮓﾕﺗﶙ첝즟잡솣슧\ud8a9\uc3ab\udead\ucaaf莱욳ힷ躹覻趽蛁꿃뇅뫇뫉믋﷍铑뿓뇕꣗뿙껛", num11);
        str2 = string.Empty;
        str3 = string.Empty;
        num3 = num + num2;
        encoding = new ASCIIEncoding();
        buffer = encoding.GetBytes(str);
        buffer2 = encoding.GetBytes(A_0.ToString(RptMgrErrorHandler.b("\udf91\ud993", num11)));
        num5 = buffer2.GetLength(0);
        num7 = 0;
        num10 = 0x1c;
        num9 = (IntPtr) ((short) *(((short*) &num10)));
        goto TR_004C;
    TR_0002:
        ch2 = buffer3[num8];
        str3 = str3 + &ch2.ToString();
        num8 -= 1;
        num10 = 7;
        num9 = (IntPtr) ((short) *(((short*) &num10)));
        goto TR_004C;
    TR_000A:
        num7 = (short) (num7 + 1);
        num10 = 10;
        num9 = (IntPtr) ((short) *(((short*) &num10)));
        goto TR_004C;
    TR_000E:
        num9 = (IntPtr) ((short) *(((short*) &20)));
        goto TR_004C;
    TR_0025:
        return str3;
    TR_0036:
        num4 = (byte) (buffer[num3++] ^ buffer2[num7]);
        num10 = 0x25;
        num9 = (IntPtr) ((short) *(((short*) &num10)));
        goto TR_004C;
    TR_004C:
        while (true)
        {
            switch (num9)
            {
                case 0:
                {
                    num10 = 0x16;
                    num9 = (IntPtr) ((short) *(((short*) &num10)));
                    continue;
                }
                case 1:
                    goto TR_0002;

                case 2:
                {
                    if (num4 == 0x31)
                    {
                        break;
                    }
                    num10 = 0x17;
                    num9 = (IntPtr) ((short) *(((short*) &num10)));
                    continue;
                }
                case 3:
                {
                    ch = buffer2[2];
                    str3 = str3 + &ch.ToString();
                    num10 = 1;
                    num9 = (IntPtr) ((short) *(((short*) &num10)));
                    continue;
                }
                case 4:
                {
                    buffer3 = encoding.GetBytes(str2);
                    num6 = (int) buffer3.Length;
                    num8 = num6 - 1;
                    num9 = (IntPtr) ((short) *(((short*) &0x12)));
                    continue;
                }
                case 5:
                {
                    num10 = 0x11;
                    num9 = (IntPtr) ((short) *(((short*) &num10)));
                    continue;
                }
                case 6:
                    if (num4 < 0x7f)
                    {
                        num9 = (IntPtr) ((short) *(((short*) &5)));
                        continue;
                    }
                    goto TR_000A;

                case 7:
                case 0x12:
                {
                TR_000C:
                    num10 = 0x26;
                    num9 = (IntPtr) ((short) *(((short*) &num10)));
                    continue;
                }
                case 8:
                    break;

                case 9:
                case 0x1a:
                    goto TR_000A;

                case 10:
                case 0x1c:
                {
                TR_000D:
                    num10 = 0x13;
                    num9 = (IntPtr) ((short) *(((short*) &num10)));
                    continue;
                }
                case 11:
                    goto TR_000E;

                case 12:
                {
                    str3 = str3.Remove(11);
                    num10 = 0x23;
                    num9 = (IntPtr) ((short) *(((short*) &num10)));
                    continue;
                }
                case 13:
                {
                    num10 = 2;
                    num9 = (IntPtr) ((short) *(((short*) &num10)));
                    continue;
                }
                case 14:
                {
                    num10 = 0x27;
                    num9 = (IntPtr) ((short) *(((short*) &num10)));
                    continue;
                }
                case 15:
                {
                    num10 = 6;
                    num9 = (IntPtr) ((short) *(((short*) &num10)));
                    continue;
                }
                case 0x10:
                {
                    num12 = (short) *(((short*) &1));
                TR_0015:
                    if (num12 != null)
                    {
                    }
                TR_0014:
                    if (num4 == 0x49)
                    {
                        break;
                    }
                    num10 = 0x24;
                    num9 = (IntPtr) ((short) *(((short*) &num10)));
                    continue;
                }
                case 0x11:
                {
                    num13 = (short) *(((short*) &0));
                    short local1 = num13;
                    if (num4 == 0x30)
                    {
                        break;
                    }
                    num10 = 13;
                    num9 = (IntPtr) ((short) *(((short*) &num10)));
                    continue;
                }
                case 0x13:
                {
                    if (num7 < num5)
                    {
                        num9 = (IntPtr) ((short) *(((short*) &40)));
                        continue;
                    }
                    num10 = 4;
                    num9 = (IntPtr) ((short) *(((short*) &num10)));
                    continue;
                }
                case 20:
                    if (num8 == (num6 - 1))
                    {
                        num9 = (IntPtr) ((short) *(((short*) &3)));
                        continue;
                    }
                    goto TR_0002;

                case 0x15:
                {
                    str3 = A_1 + str3;
                    sha = SHA256.Create();
                    num10 = 0x19;
                    num9 = (IntPtr) ((short) *(((short*) &num10)));
                    continue;
                }
                case 0x16:
                {
                    if (num4 == 0x6c)
                    {
                        break;
                    }
                    num10 = 14;
                    num9 = (IntPtr) ((short) *(((short*) &num10)));
                    continue;
                }
                case 0x17:
                {
                    num9 = (IntPtr) ((short) *(((short*) &0x10)));
                    continue;
                }
                case 0x18:
                    if (str3.Length > 12)
                    {
                        num10 = 12;
                        num9 = (IntPtr) ((short) *(((short*) &num10)));
                        continue;
                    }
                    goto TR_0025;

                case 0x19:
                {
                TR_0035:
                    try
                    {
                        str3 = a(sha, str3);
                    }
                    finally
                    {
                        num10 = -14869;
                        num10 = -14869;
                        switch ((((short) *(((short*) &num10))) == ((short) *(((short*) &num10)))))
                        {
                            case 0:
                            case 2:
                                goto TR_002A;

                            default:
                            TR_002F:
                                num10 = 0;
                                if (((short) *(((short*) &num10))) != null)
                                {
                                }
                            TR_002E:
                                num10 = 0;
                                num9 = (IntPtr) ((short) *(((short*) &num10)));
                                break;
                        }
                        goto TR_002D;
                    TR_0028:;
                    TR_0029:
                        if (sha == null)
                        {
                            goto TR_0028;
                        }
                        else
                        {
                            num10 = 2;
                            num9 = (IntPtr) ((short) *(((short*) &num10)));
                        }
                        goto TR_002D;
                    TR_002A:
                        switch (0)
                        {
                            case 0:
                                break;

                            default:
                                goto TR_002D;
                        }
                        goto TR_0029;
                    TR_002D:
                        while (true)
                        {
                            switch (num9)
                            {
                                case 0:
                                    break;

                                case 1:
                                    goto TR_0028;

                                case 2:
                                {
                                    sha.Dispose();
                                    num10 = 1;
                                    num9 = (IntPtr) ((short) *(((short*) &num10)));
                                    continue;
                                }
                                default:
                                    goto TR_0029;
                            }
                            break;
                        }
                        goto TR_002A;
                    }
                TR_0033:
                    num9 = (IntPtr) ((short) *(((short*) &0x18)));
                    continue;
                }
                case 0x1b:
                    goto TR_0036;

                case 0x1d:
                {
                    num3 = num;
                    num9 = (IntPtr) ((short) *(((short*) &0x1b)));
                    continue;
                }
                case 30:
                {
                    num10 = 0x1f;
                    num9 = (IntPtr) ((short) *(((short*) &num10)));
                    continue;
                }
                case 0x1f:
                    if (num8 == (num6 - 2))
                    {
                        num10 = 0x22;
                        num9 = (IntPtr) ((short) *(((short*) &num10)));
                        continue;
                    }
                    goto TR_000E;

                case 0x20:
                {
                    if (num4 == 0x4f)
                    {
                        break;
                    }
                    num9 = (IntPtr) ((short) *(((short*) &0)));
                    continue;
                }
                case 0x21:
                    if (num6 < 6)
                    {
                        num9 = (IntPtr) ((short) *(((short*) &30)));
                        continue;
                    }
                    goto TR_0002;

                case 0x22:
                {
                    ch = buffer2[3];
                    str3 = str3 + &ch.ToString();
                    num10 = 11;
                    num9 = (IntPtr) ((short) *(((short*) &num10)));
                    continue;
                }
                case 0x23:
                    goto TR_0025;

                case 0x24:
                {
                    num10 = 0x20;
                    num9 = (IntPtr) ((short) *(((short*) &num10)));
                    continue;
                }
                case 0x25:
                    if (num4 > 0x20)
                    {
                        num10 = 15;
                        num9 = (IntPtr) ((short) *(((short*) &num10)));
                        continue;
                    }
                    goto TR_000A;

                case 0x26:
                {
                    if (num8 < 0)
                    {
                        num10 = 0x15;
                        num9 = (IntPtr) ((short) *(((short*) &num10)));
                        continue;
                    }
                    num10 = 0x21;
                    num9 = (IntPtr) ((short) *(((short*) &num10)));
                    continue;
                }
                case 0x27:
                {
                    if (num4 == 0x6f)
                    {
                        num10 = 8;
                        num9 = (IntPtr) ((short) *(((short*) &num10)));
                        continue;
                    }
                    str2 = str2 + &num4.ToString();
                    num10 = 0x1a;
                    num9 = (IntPtr) ((short) *(((short*) &num10)));
                    continue;
                }
                case 40:
                    if (num3 >= 40)
                    {
                        num9 = (IntPtr) ((short) *(((short*) &0x1d)));
                        continue;
                    }
                    goto TR_0036;

                default:
                    goto TR_0000;
            }
        TR_0004:
            str2 = str2 + RptMgrErrorHandler.b("", num11);
            num10 = 9;
            num9 = (IntPtr) ((short) *(((short*) &num10)));
        }
        goto TR_000A;
    }

    private static unsafe string a(SHA256 A_0, string A_1)
    {
        byte[] buffer;
        StringBuilder builder;
        int num;
        int num2;
        short num3;
        int num4;
        short num1;
        short num5;
        num4 = 11;
        num3 = -1165;
        switch ((((short) *(((short*) &-1165))) == ((short) *(((short*) &num3)))))
        {
            case 0:
            case 2:
                break;

            default:
            TR_000D:
                num3 = 1;
                num1 = (short) *(((short*) &num3));
            TR_000C:
                if (num1 != null)
                {
                }
            TR_000A:
                num3 = 0;
                if (((short) *(((short*) &num3))) != null)
                {
                }
            TR_0009:
                switch (0)
                {
                    case 0:
                        goto TR_0000;

                    default:
                        break;
                }
                break;
        }
        goto TR_0008;
    TR_0000:
        buffer = A_0.ComputeHash(Encoding.UTF8.GetBytes(A_1));
        builder = new StringBuilder();
        num = 0;
        num3 = 0;
        num2 = (IntPtr) ((short) *(((short*) &num3)));
        goto TR_0008;
    TR_0008:
        while (true)
        {
            switch (num2)
            {
                case 0:
                case 1:
                {
                TR_0001:
                    num3 = 3;
                    num2 = (IntPtr) ((short) *(((short*) &num3)));
                    continue;
                }
                case 2:
                {
                    num5 = (short) *(((short*) &0));
                    short local1 = num5;
                    return builder.ToString();
                }
                case 3:
                {
                    if (num >= ((int) buffer.Length))
                    {
                        num3 = 2;
                        num2 = (IntPtr) ((short) *(((short*) &num3)));
                        continue;
                    }
                    builder.Append(&(buffer[num]).ToString(RptMgrErrorHandler.b("ꊏ", num4)));
                    num += 1;
                    num3 = 1;
                    num2 = (IntPtr) ((short) *(((short*) &num3)));
                    continue;
                }
                default:
                    break;
            }
            break;
        }
        goto TR_0000;
    }

    private static unsafe byte[] a(string A_0, byte[] A_1)
    {
        byte[] buffer;
        byte[] buffer2;
        SHA256 sha;
        int num;
        short num2;
        short num1;
        short num3;
        num2 = 0;
        num1 = (short) *(((short*) &num2));
        short local1 = num1;
        buffer = Enumerable.ToArray<byte>(Enumerable.Concat<byte>(A_1, Encoding.UTF8.GetBytes(A_0)));
        buffer2 = null;
        sha = SHA256.Create();
    TR_000E:
        try
        {
            buffer2 = sha.ComputeHash(buffer);
        }
        finally
        {
            switch ((((short) *(((short*) &-8222))) == ((short) *(((short*) &-8222)))))
            {
                case 0:
                case 2:
                    goto TR_0003;

                default:
                TR_0008:
                    if (((short) *(((short*) &0))) != null)
                    {
                    }
                TR_0007:
                    num2 = 0;
                    num = (IntPtr) ((short) *(((short*) &num2)));
                    break;
            }
            goto TR_0006;
        TR_0001:;
        TR_0002:
            if (sha == null)
            {
                goto TR_0001;
            }
            else
            {
                num2 = 2;
                num = (IntPtr) ((short) *(((short*) &num2)));
            }
            goto TR_0006;
        TR_0003:
            switch (0)
            {
                case 0:
                    break;

                default:
                    goto TR_0006;
            }
            goto TR_0002;
        TR_0006:
            while (true)
            {
                switch (num)
                {
                    case 0:
                        break;

                    case 1:
                        goto TR_0001;

                    case 2:
                    {
                        sha.Dispose();
                        num2 = 1;
                        num = (IntPtr) ((short) *(((short*) &num2)));
                        continue;
                    }
                    default:
                        goto TR_0002;
                }
                break;
            }
            goto TR_0003;
        }
    TR_000C:
        num2 = 1;
        num3 = (short) *(((short*) &num2));
    TR_000B:
        if (num3 != null)
        {
        }
    TR_000A:
        return buffer2;
    }

    public static unsafe string ComputeHash(string input, byte[] salt, uint algorithm)
    {
        byte[] buffer;
        StringBuilder builder;
        byte[] buffer2;
        byte[] buffer3;
        int num;
        int num2;
        short num3;
        int num4;
        short num1;
        short num5;
        num4 = 8;
        switch (((short) *(((short*) &0))))
        {
            default:
            TR_0020:
                num3 = 2;
                num2 = (IntPtr) ((short) *(((short*) &num3)));
                break;
        }
        goto TR_001F;
    TR_0002:
        if (string.IsNullOrEmpty(input))
        {
            num3 = 1;
            num2 = (IntPtr) ((short) *(((short*) &num3)));
        }
        else
        {
            buffer = null;
            num2 = (IntPtr) ((short) *(((short*) &10)));
        }
        goto TR_001F;
    TR_0003:
        num2 = (IntPtr) ((short) *(((short*) &11)));
        goto TR_001F;
    TR_0006:
        buffer3 = a(input, salt);
        buffer = Enumerable.ToArray<byte>(Enumerable.Concat<byte>(Enumerable.Concat<byte>(buffer2, salt), buffer3));
        num2 = (IntPtr) ((short) *(((short*) &6)));
        goto TR_001F;
    TR_001F:
        while (true)
        {
            switch (num2)
            {
                case 0:
                    goto TR_0003;

                case 1:
                    throw new CommonException(2);

                case 2:
                    switch (0)
                    {
                        case 0:
                            break;

                        default:
                        {
                            continue;
                        }
                    }
                    goto TR_0002;

                case 3:
                {
                    num3 = 0;
                    num5 = (short) *(((short*) &num3));
                    short local1 = num5;
                    goto TR_0006;
                }
                case 4:
                    switch ((((short) *(((short*) &0x75bc))) == ((short) *(((short*) &0x75bc)))))
                    {
                        case 0:
                        case 2:
                            break;

                        default:
                        {
                        TR_000C:
                            num3 = 0;
                            if (((short) *(((short*) &num3))) != null)
                            {
                            }
                        TR_000B:
                            salt = a(0x18);
                            num3 = 1;
                            num1 = (short) *(((short*) &num3));
                        TR_000A:
                            if (num1 != null)
                            {
                            }
                        TR_0009:
                            num3 = 3;
                            num2 = (IntPtr) ((short) *(((short*) &num3)));
                            continue;
                        }
                    }
                    break;

                case 5:
                {
                    Array.Reverse(buffer2);
                    num2 = (IntPtr) ((short) *(((short*) &0)));
                    continue;
                }
                case 6:
                {
                    builder = new StringBuilder();
                    num = 0;
                    num2 = (IntPtr) ((short) *(((short*) &14)));
                    continue;
                }
                case 7:
                case 14:
                {
                TR_0012:
                    num3 = 8;
                    num2 = (IntPtr) ((short) *(((short*) &num3)));
                    continue;
                }
                case 8:
                {
                    if (num < ((int) buffer.Length))
                    {
                        break;
                    }
                    num2 = (IntPtr) ((short) *(((short*) &12)));
                    continue;
                }
                case 9:
                {
                    buffer2 = BitConverter.GetBytes(1);
                    num2 = (IntPtr) ((short) *(((short*) &13)));
                    continue;
                }
                case 10:
                {
                    if (algorithm != 1)
                    {
                        throw new CommonException(4);
                    }
                    num3 = 9;
                    num2 = (IntPtr) ((short) *(((short*) &num3)));
                    continue;
                }
                case 11:
                    if (salt == null)
                    {
                        num2 = (IntPtr) ((short) *(((short*) &4)));
                        continue;
                    }
                    goto TR_0006;

                case 12:
                    return builder.ToString();

                case 13:
                    if (BitConverter.IsLittleEndian)
                    {
                        num2 = (IntPtr) ((short) *(((short*) &5)));
                        continue;
                    }
                    goto TR_0003;

                default:
                    goto TR_0002;
            }
        TR_000E:
            builder.Append(&(buffer[num]).ToString(RptMgrErrorHandler.b("펊뾌", num4)));
            num += 1;
            num3 = 7;
            num2 = (IntPtr) ((short) *(((short*) &num3)));
        }
        goto TR_0006;
    }

    internal static unsafe bool isHiddenPwd(string testPwd, string serialNumber)
    {
        bool flag;
        DateTime time;
        int num;
        short num2;
        short num1;
        short num3;
        num2 = 1;
        num = (IntPtr) ((short) *(((short*) &num2)));
    TR_0015:
        while (true)
        {
            num2 = 0;
            num1 = (short) *(((short*) &num2));
            short local1 = num1;
            switch (num)
            {
                case 0:
                {
                    flag = true;
                    num = (IntPtr) ((short) *(((short*) &5)));
                    continue;
                }
                case 1:
                    switch (0)
                    {
                        case 0:
                            break;

                        default:
                        {
                            continue;
                        }
                    }
                    break;

                case 2:
                case 5:
                    goto TR_000A;

                case 3:
                {
                    if (!(a(time.AddDays(-1.0), serialNumber) == testPwd))
                    {
                        goto TR_000A;
                    }
                    else
                    {
                        num = (IntPtr) ((short) *(((short*) &6)));
                    }
                    continue;
                }
                case 4:
                    throw new CommonException(0x5aa);

                case 6:
                {
                    flag = true;
                    num2 = 2;
                    num = (IntPtr) ((short) *(((short*) &num2)));
                    continue;
                }
                case 7:
                {
                    if (a(time.Date, serialNumber) == testPwd)
                    {
                        num = (IntPtr) ((short) *(((short*) &0)));
                    }
                    else
                    {
                        time = DateTime.Now;
                        num2 = 3;
                        num = (IntPtr) ((short) *(((short*) &num2)));
                    }
                    continue;
                }
                default:
                    break;
            }
        TR_0006:
            num2 = -9612;
            switch ((((short) *(((short*) &-9612))) == ((short) *(((short*) &num2)))))
            {
                case 0:
                case 2:
                    break;

                default:
                {
                TR_0005:
                    if (((short) *(((short*) &0))) != null)
                    {
                    }
                TR_0004:
                    num3 = (short) *(((short*) &1));
                TR_0003:
                    if (num3 != null)
                    {
                    }
                TR_0002:
                    if (string.IsNullOrEmpty(serialNumber))
                    {
                        break;
                    }
                    flag = false;
                    time = DateTime.Now;
                    num2 = 7;
                    num = (IntPtr) ((short) *(((short*) &num2)));
                    continue;
                }
            }
        TR_0000:
            num = (IntPtr) ((short) *(((short*) &4)));
        }
        goto TR_000A;
    TR_000A:
        return flag;
    }
}

