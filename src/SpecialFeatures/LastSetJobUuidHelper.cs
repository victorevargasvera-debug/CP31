namespace SpecialFeatures
{
    using AcpCommonLib;
    using Motorola.MackinawCPS.CoreFeatures.RadioWide;
    using SpecialFeatures.AcpReportManagerLib;
    using System;
    using System.Runtime.InteropServices;

    public class LastSetJobUuidHelper
    {
        public LastSetJobUuidHelper()
        {
            base..ctor();
            return;
        }

        public static unsafe void SetLastSetJobUuidField(string guidToSet)
        {
            Guid guid;
            int num;
            short num2;
            int num3;
            short num1;
            short num4;
            num3 = 2;
            num = (IntPtr) ((short) *(((short*) &1)));
            goto TR_000F;
        TR_0003:
            num4 = (short) *(((short*) &1));
        TR_0002:
            if (num4 != null)
            {
            }
        TR_0001:
            guid = Guid.NewGuid();
            guidToSet = guid.ToString(RptMgrErrorHandler.b("쮄", num3)).ToUpper();
            num = (IntPtr) ((short) *(((short*) &3)));
            goto TR_000F;
        TR_000B:
            (FeatureManager.GetFeature(0x7fd).get_Item(0) as Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).Labtool.set_RadWideLabtoolRCLastJobSetUUIDValue(guidToSet);
            return;
        TR_000F:
            while (true)
            {
                switch (num)
                {
                    case 0:
                    {
                        num2 = 4;
                        num = (IntPtr) ((short) *(((short*) &num2)));
                        continue;
                    }
                    case 1:
                    {
                        num1 = (short) *(((short*) &0));
                        short local1 = num1;
                        num2 = 0x7631;
                        switch ((((short) *(((short*) &0x7631))) == ((short) *(((short*) &num2)))))
                        {
                            case 0:
                            case 2:
                                goto TR_0003;

                            default:
                            TR_0007:
                                if (((short) *(((short*) &0))) != null)
                                {
                                }
                            TR_0006:
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
                        }
                        break;
                    }
                    case 2:
                        goto TR_0003;

                    case 3:
                        goto TR_000B;

                    case 4:
                        if (!Guid.TryParse(guidToSet, &guid))
                        {
                            num2 = 2;
                            num = (IntPtr) ((short) *(((short*) &num2)));
                            continue;
                        }
                        goto TR_000B;

                    default:
                        break;
                }
            TR_0004:
                if (guidToSet == null)
                {
                    break;
                }
                num2 = 0;
                num = (IntPtr) ((short) *(((short*) &num2)));
            }
            goto TR_0003;
        }
    }
}

