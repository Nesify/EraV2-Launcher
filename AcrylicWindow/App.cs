// Decompiled with JetBrains decompiler
// Type: AcrylicWindow.App
// Assembly: ERALauncherV2, Version=1.4.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6923A52C-9B51-4CC1-B838-ADDD1FEF91EF
// Assembly location: C:\Users\vloge\Downloads\Release\FortniteLauncher.exe

using AutoUpdaterDotNET;
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Windows;

namespace AcrylicWindow
{
  public class App : Application
  {
    private bool a;

    private void a(object A_0, StartupEventArgs A_1)
    {
      int A_1_1 = 5;
      int num1;
      short num2;
      Ping ping;
      bool flag;
      switch (0)
      {
        case 0:
label_2:
          num2 = (short) 0;
          ping = new Ping();
          flag = false;
          num2 = (short) 4;
          num1 = (int) (IntPtr) num2;
          goto default;
        default:
          while (true)
          {
            switch (num1)
            {
              case 0:
                goto label_21;
              case 1:
                num2 = (short) -32533;
                int num3 = (int) num2;
                num2 = (short) -32533;
                int num4 = (int) num2;
                switch (num3 == num4 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    goto label_12;
                  default:
                    num2 = (short) 0;
                    if (num2 == (short) 0)
                      ;
                    Environment.Exit(0);
                    num2 = (short) 0;
                    num1 = (int) (IntPtr) num2;
                    continue;
                }
              case 2:
                if (MessageBox.Show(App.b("≢\u0B64䝦hժᥬ੮ͰᵲၴͶ奸\u187Aቼᅾ\uEF80\uE682\uE684\uF386\uE088\uE48A\uE38C꾎\uF890\uE092떔\uE596ﲘ\uEA9A\uE89C\uF69E펠욢솤螦\uDDA8쒪趬\uDAAE슰횲閴\uF2B6쮸\uDABA鎼떾釀꿂ꃄꛆ뫈껊\uEDCC곎뻐뷒믔닖뫘꿚\uFDDCꯞ軠쏢釤迦賨쯪蓬臮藰雲蟴駶鳸迺폼", A_1_1), App.b("\u2062\u0A64०ݨ\u0E6A\u0E6C᭮兰ݲᩴ坶\u0D78\u137A\u187C彾좀\uED82\uF184\uE286ﮈ\uE58A\uE88Cﮎ", A_1_1), MessageBoxButton.OK, MessageBoxImage.Exclamation) == MessageBoxResult.OK)
                {
                  num2 = (short) 1;
                  num1 = (int) (IntPtr) num2;
                  continue;
                }
                goto label_21;
              case 3:
                num2 = (short) 2;
                num1 = (int) (IntPtr) num2;
                continue;
              case 4:
label_12:
                try
                {
                  num2 = (short) 2;
                  int num5 = (int) (IntPtr) num2;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 0:
                        flag = true;
                        num2 = (short) 3;
                        num5 = (int) (IntPtr) num2;
                        continue;
                      case 1:
                        goto label_8;
                      case 2:
                        switch (0)
                        {
                          case 0:
                            goto label_15;
                          default:
                            continue;
                        }
                      case 3:
                        num2 = (short) 1;
                        num5 = (int) (IntPtr) num2;
                        continue;
                      default:
label_15:
                        if (ping.Send(App.b("ᑢቤၦ䝨ͪ\u086CᵮṰᡲt奶᩸ᑺၼ", A_1_1)) != null)
                        {
                          num2 = (short) 0;
                          num5 = (int) (IntPtr) num2;
                          continue;
                        }
                        goto case 3;
                    }
                  }
                }
                catch (PingException ex)
                {
                  flag = false;
                }
label_8:
                num1 = 5;
                continue;
              case 5:
                num2 = (short) 1;
                if (num2 == (short) 0)
                  ;
                if (!flag)
                {
                  num2 = (short) 3;
                  num1 = (int) (IntPtr) num2;
                  continue;
                }
                goto label_21;
              default:
                goto label_2;
            }
          }
label_21:
          AutoUpdater.Start(App.b("ୢᅤ፦ᥨ兪䉬䁮ᑰŲᑴᅶ\u1778啺ռپﮀ겂\uF384\uE286ﮈ\uF88A\uE48C\uE08Eﾐ붒\uED94殺\uF598", A_1_1), (Assembly) null);
          break;
      }
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent()
    {
      int A_1 = 3;
      while (this.a)
      {
        short num1 = -6790;
        int num2 = (int) num1;
        num1 = (short) -6790;
        int num3 = (int) num1;
        switch (num2 == num3 ? 1 : 0)
        {
          case 0:
          case 2:
            continue;
          case 1:
            num1 = (short) 1;
            if (num1 == (short) 0)
              ;
            num1 = (short) 0;
            if (num1 == (short) 0)
              ;
            return;
          default:
            num1 = (short) 0;
            goto case 1;
        }
      }
      this.a = true;
      this.Startup += new StartupEventHandler(this.a);
      this.StartupUri = new Uri(App.b("Ⱡɢ\u0C64०㹨ɪͬ୮ṰѲ孴ྲྀ\u1878ᙺᅼ", A_1), UriKind.Relative);
      Application.LoadComponent((object) this, new Uri(App.b("习♢㝤♦╨੪ᡬŮተ᭲ၴն⽸䥺䙼᱾\uEE80\uEE82\uF584\uE886\uE788\uEE8A\uE38Cﮎ뺐\uF292\uE594\uE796래\uE39Aﲜ\uF29E춠", A_1), UriKind.Relative));
    }

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [STAThread]
    public static void Main()
    {
      short num1 = 22732;
      int num2 = (int) num1;
      num1 = (short) 22732;
      int num3 = (int) num1;
      switch (num2 == num3)
      {
        case true:
          short num4 = 0;
          num4 = (short) 1;
          if (num4 == (short) 0)
            ;
          num4 = (short) 0;
          if (num4 == (short) 0)
            ;
          App app = new App();
          app.InitializeComponent();
          app.Run();
          break;
        default:
          goto case 1;
      }
    }

    internal static string b(string A_0, int A_1)
    {
      char[] charArray = A_0.ToCharArray();
      int num1 = (int) (800187471 + A_1 + new IntPtr(90) + new IntPtr(60) + new IntPtr(25) + new IntPtr(95));
      int num2 = 0;
      if (num2 < 1)
        goto label_2;
label_1:
      int index1 = num2;
      char[] chArray = charArray;
      int index2 = index1;
      int num3 = (int) (short) charArray[index1];
      int num4 = num3 & (int) byte.MaxValue;
      int num5 = num1;
      int num6 = num5 + 1;
      byte num7 = (byte) (num4 ^ num5);
      int num8 = num3 >> 8;
      int num9 = num6;
      num1 = num9 + 1;
      int num10 = (int) (byte) (num8 ^ num9);
      int num11 = (int) (ushort) ((uint) num7 << 8 | (uint) (byte) num10);
      chArray[index2] = (char) num11;
      ++num2;
label_2:
      if (num2 >= charArray.Length)
        return string.Intern(new string(charArray));
      goto label_1;
    }

    public class JSONData
    {
      public string version
      {
        get
        {
          short num1 = 1359;
          int num2 = (int) num1;
          num1 = (short) 1359;
          int num3 = (int) num1;
          switch (num2 == num3)
          {
            case true:
              short num4 = 0;
              num4 = (short) 1;
              if (num4 == (short) 0)
                ;
              num4 = (short) 0;
              if (num4 == (short) 0)
                ;
              return this.a;
            default:
              goto case 1;
          }
        }
        set
        {
          short num1 = 29475;
          int num2 = (int) num1;
          num1 = (short) 29475;
          int num3 = (int) num1;
          switch (num2 == num3)
          {
            case true:
              short num4 = 0;
              num4 = (short) 1;
              if (num4 == (short) 0)
                ;
              num4 = (short) 0;
              if (num4 == (short) 0)
                ;
              this.a = value;
              break;
            default:
              goto case 1;
          }
        }
      }
    }
  }
}
