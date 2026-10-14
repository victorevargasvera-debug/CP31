using SpecialFeatures.AcpReportManagerLib;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Markup;

public class BusyIndicator : ResourceDictionary, IComponentConnector
{
    private bool a;

    public BusyIndicator()
    {
        base..ctor();
        return;
    }

    [GeneratedCode("PresentationBuildTasks", "5.0.10.0"), DebuggerNonUserCode]
    public unsafe void InitializeComponent()
    {
        Uri uri;
        short num;
        int num2;
        short num1;
        short num3;
        num2 = 8;
        num = 0x68bd;
        switch ((((short) *(((short*) &num))) == ((short) *(((short*) &0x68bd)))))
        {
            case 0:
            case 2:
                break;

            default:
            {
            TR_0006:
                num = 1;
                num1 = (short) *(((short*) &num));
            TR_0005:
                if (num1 != null)
                {
                }
            TR_0004:
                if (((short) *(((short*) &0))) != null)
                {
                }
            TR_0003:
                if (this.a)
                {
                    break;
                }
                num = 0;
                num3 = (short) *(((short*) &num));
                short local1 = num3;
                this.a = true;
                uri = new Uri(RptMgrErrorHandler.b("ꒊ\ude8c\uff8eﲔ\udd9a\uf89cﺞ햠횢힤슦\udaa8\u90aa캬삮\udcb0\uc3b2\udab4\ud9b6\udcb8\ud5ba즼邾Ꟁꫂ꧄ꋆꛈ믊꣌뷎냐꟒볔룖럘꣚뷞铠郢鳤軦蟨迪蓬賮郰蟲髴藶ퟸ菺鳼鋾洀", num2), 2);
                Application.LoadComponent(this, uri);
                return;
            }
        }
    TR_0000:
        return;
    }

    [EditorBrowsable(1), DebuggerNonUserCode, GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
    unsafe void IComponentConnector.Connect(int connectionId, object target)
    {
        short num;
        short num1;
        short num2;
        num = 0x357e;
        num = 0x357e;
        switch ((((short) *(((short*) &num))) == ((short) *(((short*) &num)))))
        {
            case 1:
                break;

            default:
            {
            TR_0006:
                num1 = (short) *(((short*) &0));
                short local1 = num1;
                break;
            }
        }
    TR_0004:
        num = 1;
        num2 = (short) *(((short*) &num));
    TR_0003:
        if (num2 != null)
        {
        }
    TR_0001:
        num = 0;
        if (((short) *(((short*) &num))) != null)
        {
        }
    TR_0000:
        this.a = true;
        return;
    }
}

