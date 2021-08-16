// Decompiled with JetBrains decompiler
// Type: EraLauncherV2.MainWindow
// Assembly: ERALauncherV2, Version=1.4.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6923A52C-9B51-4CC1-B838-ADDD1FEF91EF
// Assembly location: C:\Users\vloge\Downloads\Release\FortniteLauncher.exe

using AcrylicWindow;
using DiscordRPC;
using Microsoft.WindowsAPICodePack.Dialogs;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;

namespace EraLauncherV2
{
  public class MainWindow : SourceChord.FluentWPF.AcrylicWindow, IComponentConnector
  {
    public string AD = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
    private bool a;
    public Timestamps _baseTimestamp = new Timestamps()
    {
      Start = new DateTime?(DateTime.UtcNow)
    };
    internal MainWindow c;
    internal Grid d;
    internal Grid e;
    internal Label f;
    internal Grid g;
    internal TextBox h;
    internal System.Windows.Controls.Button i;
    internal System.Windows.Controls.Button j;
    internal Grid k;
    internal Border l;
    internal System.Windows.Controls.Button m;
    internal Grid n;
    internal StackPanel o;
    internal Grid p;
    internal Grid q;
    internal Grid r;
    internal Grid s;
    internal Grid t;
    internal Grid u;
    private bool v;

    [DllImport("kernel32")]
    public static extern IntPtr CreateRemoteThread(
      IntPtr hProcess,
      IntPtr lpThreadAttributes,
      uint dwStackSize,
      UIntPtr lpStartAddress,
      IntPtr lpParameter,
      uint dwCreationFlags,
      out IntPtr lpThreadId);

    [DllImport("kernel32.dll")]
    public static extern IntPtr OpenProcess(
      uint dwDesiredAccess,
      int bInheritHandle,
      int dwProcessId);

    [DllImport("kernel32.dll")]
    public static extern int CloseHandle(IntPtr hObject);

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern bool VirtualFreeEx(IntPtr A_0, IntPtr A_1, UIntPtr A_2, uint A_3);

    [DllImport("kernel32.dll", CharSet = CharSet.Ansi)]
    public static extern UIntPtr GetProcAddress(IntPtr hModule, string procName);

    [DllImport("kernel32.dll", SetLastError = true)]
    private static extern IntPtr VirtualAllocEx(
      IntPtr A_0,
      IntPtr A_1,
      uint A_2,
      uint A_3,
      uint A_4);

    [DllImport("kernel32.dll")]
    private static extern bool WriteProcessMemory(
      IntPtr A_0,
      IntPtr A_1,
      string A_2,
      UIntPtr A_3,
      out IntPtr A_4);

    [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
    public static extern IntPtr GetModuleHandle(string lpModuleName);

    [DllImport("kernel32", SetLastError = true)]
    internal static extern int WaitForSingleObject(IntPtr A_0, int A_1);

    public DiscordRpcClient Client
    {
      get
      {
        short num1 = -3682;
        int num2 = (int) num1;
        num1 = (short) -3682;
        int num3 = (int) num1;
        switch (num2 == num3)
        {
          case true:
            short num4 = 1;
            if (num4 == (short) 0)
              ;
            num4 = (short) 0;
            num4 = (short) 0;
            if (num4 == (short) 0)
              ;
            return this.b;
          default:
            goto case 1;
        }
      }
      private set
      {
        short num1 = -2784;
        int num2 = (int) num1;
        num1 = (short) -2784;
        int num3 = (int) num1;
        switch (num2 == num3)
        {
          case true:
            short num4 = 1;
            if (num4 == (short) 0)
              ;
            num4 = (short) 0;
            num4 = (short) 0;
            if (num4 == (short) 0)
              ;
            this.b = value;
            break;
          default:
            goto case 1;
        }
      }
    }

    private void a()
    {
      int A_1 = 1;
      short num1 = 2500;
      int num2 = (int) num1;
      num1 = (short) 2500;
      int num3 = (int) num1;
      switch (num2 == num3)
      {
        case true:
          short num4 = 1;
          if (num4 == (short) 0)
            ;
          num4 = (short) 0;
          num4 = (short) 0;
          if (num4 == (short) 0)
            ;
          this.Client = new DiscordRpcClient(App.b("杞偠剢坤幦嵨剪幬塮䥰䕲䅴乶䁸佺䕼䡾뚀", A_1));
          this.Client.Initialize();
          DiscordRpcClient client = this.Client;
          RichPresence presence = new RichPresence();
          presence.Details = App.b("ᙞའ乢≤٦Ѩ\u0E6A", A_1);
          presence.State = App.b("ਫ਼በ\u0A62\u0B64f䥨\u2E6AὬ\u0E6E", A_1);
          presence.Timestamps = this._baseTimestamp;
          presence.Assets = new Assets()
          {
            LargeImageKey = App.b("㩞፠ɢ।٦᭨౪\u086C", A_1),
            SmallImageKey = App.b("㩞፠ɢᙤ੦\u0868ݪŬ", A_1),
            LargeImageText = App.b("㭞\u0860ၢ٤\u0866᭨ཪ䍬\u086Eᙰ屲ၴն\u1878ᵺ\u137C", A_1)
          };
          client.SetPresence(presence);
          this.a = true;
          break;
        default:
          goto case 1;
      }
    }

    private void l(object A_0, RoutedEventArgs A_1)
    {
      int A_1_1 = 11;
      int num1 = 0;
      switch (num1)
      {
        default:
          Ping ping;
          bool flag;
          short num2;
          switch (0)
          {
            case 0:
label_3:
              ping = new Ping();
              flag = false;
              num2 = (short) 11;
              num1 = (int) (IntPtr) num2;
              goto default;
            default:
              string path;
              Process[] processesByName;
              while (true)
              {
                switch (num1)
                {
                  case 0:
                    System.IO.File.Create(path).Close();
                    num2 = (short) 1;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 1:
                    num2 = (short) 10;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 2:
                    goto label_35;
                  case 3:
                    int num3 = (int) MessageBox.Show(App.b("⽨ѪὬ᭮ὰᩲŴቶ奸ቺ\u0E7C彾\uE080\uEF82\uF784\uE286\uE888\uEF8A\uF48C꾎\uE390\uE692ﮔ練\uF098\uF59A煮뎞膠펢즤슦좨\uD8AA좬辮튰\uDFB2\uDAB4쒶\uDCB8鮺풼쮾\uE1C0ꋂꯄꏆ\uE9C8뿊뿌뛎\uF1D0닒닔뛖냘뗚\uF3DC", A_1_1), App.b("ⱨᥪὬnͰ", A_1_1), MessageBoxButton.OK, MessageBoxImage.Hand);
                    num2 = (short) 2;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 4:
                    if (flag)
                    {
                      num2 = (short) 8;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    goto label_39;
                  case 5:
                    if (processesByName.Length != 0)
                    {
                      num2 = (short) 3;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    goto label_37;
                  case 6:
                    if (!System.IO.File.Exists(path))
                    {
                      num2 = (short) 15;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    goto label_15;
                  case 7:
                    if (processesByName.Length == 0)
                    {
                      num2 = (short) 12;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    num2 = (short) 5;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 8:
                    processesByName = Process.GetProcessesByName(App.b("⽨ѪὬ᭮ὰᩲŴቶ㩸\u177Aᑼ\u1A7E\uEF80\uF782ꢄ킆\uE088\uE58A뮌뮎벐삒ﶔﺖ\uE998\uEB9A\uF49C\uF19E욠", A_1_1));
                    num2 = (short) 7;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 9:
                    num2 = (short) 1;
                    if (num2 == (short) 0)
                      ;
                    if (!this.a)
                    {
                      num2 = (short) 0;
                      num2 = (short) 16;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    goto case 14;
                  case 10:
                    if (System.IO.File.Exists(System.IO.File.ReadAllText(path) + App.b("⽨ѪὬ᭮ὰᩲŴቶ㹸᩺ၼ\u1A7E\uDD80솂\uEC84\uE986\uE888力\uE48C\uEA8E\uE290쾒슔ﺖ\uF798궚ꦜ쎞\uE7A0첢\uD7A4펦잨슪\uD9AC쪮\uF2B0\uDFB2\uDCB4튶ힸ쾺邼\uE8BEꣀ귂\uF3C4\uF3C6\uE4C8飊ꗌꛎꇐꏒ볔맖뻘\uF5DA룜\uA7DE蓠", A_1_1)))
                    {
                      num2 = (short) 6;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    num2 = (short) 18;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 11:
                    try
                    {
                      ping.Send(App.b("Ṩᱪᩬ䅮ᥰᙲݴᡶቸ\u0E7A卼᱾\uEE80\uEE82", A_1_1));
                      flag = true;
                    }
                    catch (PingException ex)
                    {
                      flag = false;
                      if (MessageBox.Show(App.b("⡨ժ䵬ٮὰݲၴն\u1778Ṻॼ彾\uE280\uEC82\uEB84\uE986\uEC88\uE88A歷\uE68Eﺐﶒ떔ﺖ\uEA98뮚\uEF9C爵킠횢첤햦첨쾪趬\uDBAE\uDEB0鎲살쒶\uDCB8鮺\uF8BC춾ꃀ\uEDC2쿄韆ꗈ껊곌볎듐\uF3D2뛔룖럘뗚룜볞闠쏢釤裦짨\u9FEA藬諮퇰髲鯴菶鳸觺鏼髾甀ⴂ", A_1_1), App.b("⩨ѪͬŮᑰၲŴ坶\u0D78ᑺ嵼\u0B7E\uE980\uE682ꖄ캆\uE788ﾊ\uE88Cﶎﾐ\uF692\uE194", A_1_1), MessageBoxButton.OK, MessageBoxImage.Exclamation) == MessageBoxResult.OK)
                        ((Window) this).Close();
                    }
                    num1 = 4;
                    continue;
                  case 12:
                    num2 = (short) 9;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 13:
                    goto label_15;
                  case 14:
                    path = Path.Combine(this.AD, App.b("\u2468ɪ\u0E6CᵮṰrᩴᅶ\u0D78\u277Aᱼཾ\uE880꺂\uF384떆ꒈ\uE68Aﺌꊎ\uE690朗ﮔ몖滛\uE99A\uE99C늞풠힢첤쮦삨\uDFAA풬芮\uDDB0芲颴蚶钸论鎼\uDBBE귀꿂", A_1_1));
                    num2 = (short) 17;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 15:
                    System.IO.File.Create(path).Close();
                    num2 = (short) 13;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 16:
                    this.a();
                    num2 = (short) 14;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 17:
                    if (!System.IO.File.Exists(path))
                    {
                      num2 = (short) 0;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    goto case 1;
                  case 18:
                    goto label_10;
                  default:
                    goto label_3;
                }
              }
label_35:
              return;
label_10:
              num2 = (short) 24627;
              int num4 = (int) num2;
              num2 = (short) 24627;
              int num5 = (int) num2;
              switch (num4 == num5 ? 1 : 0)
              {
                case 0:
                case 2:
                  int num6 = (int) MessageBox.Show(App.b("㥨ݪ\u086C\u0E6Eɰᙲ啴ᑶᅸᑺቼ\u0C7E\uE480ꎂ\uF184\uEF86\uEC88ꮊ\uEB8C\uE08E\uFD90\uF792\uF094\uE596릘\uEF9A\uF59Cﺞ햠莢욤좦잨\uDFAA첬욮\uDFB0삲閴\uF1B6횸즺즼톾ꣀ럂ꃄ胆\uA8C8ꛊ\uA8CC\uEFCE냐뷒뇔\uF7D6鳘뗚뫜뛞迠蛢쯤", A_1_1), App.b("\u2068ժ᭬\u0E6Eᵰᩲᅴ坶㽸ᑺོ\u0B7E\uEF80\uEA82\uF184\uE286ꦈ\uDB8A\uEC8Cﮎ戀", A_1_1), MessageBoxButton.OK, MessageBoxImage.Hand);
                  return;
                default:
                  num2 = (short) 0;
                  if (num2 == (short) 0)
                    goto case 0;
                  else
                    goto case 0;
              }
label_39:
              return;
label_15:
              this.h.Text = System.IO.File.ReadAllText(path);
              System.IO.File.WriteAllText(path, this.h.Text);
              new Thread(new ThreadStart(MainWindow.StartFortnite.Start)).Start();
              return;
label_37:
              return;
          }
      }
    }

    private void k(object A_0, RoutedEventArgs A_1)
    {
      short num1 = 1;
      if (num1 == (short) 0)
        ;
      num1 = (short) -14889;
      int num2 = (int) num1;
      num1 = (short) -14889;
      int num3 = (int) num1;
      switch (num2 == num3)
      {
        case true:
          num1 = (short) 0;
          if (num1 == (short) 0)
            break;
          break;
        default:
          num1 = (short) 0;
          goto case 1;
      }
    }

    private void j(object A_0, RoutedEventArgs A_1)
    {
      int A_1_1 = 17;
      int num1;
      CommonOpenFileDialog commonOpenFileDialog;
      short num2;
      switch (0)
      {
        case 0:
label_2:
          commonOpenFileDialog = new CommonOpenFileDialog();
          commonOpenFileDialog.IsFolderPicker = true;
          num2 = (short) 1;
          num1 = (int) (IntPtr) num2;
          goto default;
        default:
          while (true)
          {
            switch (num1)
            {
              case 0:
                goto label_8;
              case 1:
                if (commonOpenFileDialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                  num2 = (short) 1;
                  if (num2 == (short) 0)
                    ;
                  num2 = (short) 2;
                  num1 = (int) (IntPtr) num2;
                  continue;
                }
                goto label_10;
              case 2:
                this.h.Text = commonOpenFileDialog.FileName + App.b("㍮", A_1_1);
                num2 = (short) -17040;
                int num3 = (int) num2;
                num2 = (short) -17040;
                int num4 = (int) num2;
                switch (num3 == num4 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    goto label_2;
                  default:
                    num2 = (short) 0;
                    if (num2 == (short) 0)
                      ;
                    num2 = (short) 0;
                    num2 = (short) 0;
                    num1 = (int) (IntPtr) num2;
                    continue;
                }
              default:
                goto label_2;
            }
          }
label_8:
          break;
label_10:
          break;
      }
    }

    private void i(object A_0, RoutedEventArgs A_1)
    {
      int A_1_1 = 7;
      short num1 = -1905;
      int num2 = (int) num1;
      num1 = (short) -1905;
      int num3 = (int) num1;
      switch (num2 == num3)
      {
        case true:
          if (false)
            ;
          if (true)
            ;
          System.IO.File.WriteAllText(Path.Combine(this.AD, App.b("⡤\u0E66੨ᥪɬᱮṰᕲŴ⭶\u1878\u0B7Aᑼ剾\uF780놂ꢄ\uEA86愈Ꚋ戴\uE68Eﾐ뺒\uF694\uE596\uED98뚚\uE89C\uEB9E좠쾢첤펦킨蚪솬麮鲰芲颴螶鞸\uDFBA톼펾", A_1_1)), this.h.Text);
          break;
        default:
          goto case 1;
      }
    }

    private void h(object A_0, RoutedEventArgs A_1)
    {
      short num1 = -16520;
      int num2 = (int) num1;
      num1 = (short) -16520;
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
            break;
          break;
        default:
          goto case 1;
      }
    }

    private void g(object A_0, RoutedEventArgs A_1)
    {
      int A_1_1 = 11;
      this.k.Visibility = Visibility.Visible;
      this.g.Visibility = Visibility.Hidden;
      this.e.Visibility = Visibility.Hidden;
      this.d.Visibility = Visibility.Hidden;
      string path = Path.Combine(this.AD, App.b("\u2468ɪ\u0E6CᵮṰrᩴᅶ\u0D78\u277Aᱼཾ\uE880꺂\uF384떆ꒈ\uE68Aﺌꊎ\uE690朗ﮔ몖滛\uE99A\uE99C늞풠힢첤쮦삨\uDFAA풬芮\uDDB0芲颴蚶钸论鎼\uDBBE귀꿂", A_1_1));
      if (System.IO.File.Exists(path))
      {
        switch (true ? 1 : 0)
        {
          case 0:
          case 2:
            break;
          default:
            if (false)
              ;
            if (true)
              ;
            string contents = System.IO.File.ReadAllText(path);
            System.IO.File.WriteAllText(path, contents);
            return;
        }
      }
      System.IO.File.Create(path).Close();
      System.IO.File.WriteAllText(path, this.h.Text);
    }

    private void f(object A_0, RoutedEventArgs A_1)
    {
      int A_1_1 = 13;
      short num1;
      int num2;
      string path;
      switch (0)
      {
        case 0:
label_3:
          this.g.Visibility = Visibility.Visible;
          this.k.Visibility = Visibility.Hidden;
          this.e.Visibility = Visibility.Hidden;
          this.d.Visibility = Visibility.Hidden;
          path = Path.Combine(this.AD, App.b("♪Ѭ౮ͰᱲٴᡶὸེⅼṾ\uF180\uEA82ꢄ\uF186뮈Ꚋ\uE08Cﲎ벐\uE492ﲔ練뒘\uF89A\uEF9C\uEB9E負횢톤캦얨슪\uD9AC횮鲰\uDFB2蒴骶袸隺趼醾ꗀ꿂꧄", A_1_1));
          num1 = (short) 1;
          num2 = (int) (IntPtr) num1;
          goto default;
        default:
          while (true)
          {
            num1 = (short) 1;
            if (num1 == (short) 0)
              ;
            switch (num2)
            {
              case 0:
                goto label_9;
              case 1:
                if (!System.IO.File.Exists(path))
                {
                  num1 = (short) 2;
                  num2 = (int) (IntPtr) num1;
                  continue;
                }
                goto label_9;
              case 2:
                System.IO.File.Create(path).Close();
                num1 = (short) 27043;
                int num3 = (int) num1;
                num1 = (short) 27043;
                int num4 = (int) num1;
                switch (num3 == num4 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    goto label_3;
                  default:
                    num1 = (short) 0;
                    if (num1 == (short) 0)
                      ;
                    num1 = (short) 0;
                    num1 = (short) 0;
                    num2 = (int) (IntPtr) num1;
                    continue;
                }
              default:
                goto label_3;
            }
          }
label_9:
          this.h.Text = System.IO.File.ReadAllText(path);
          break;
      }
    }

    private void e(object A_0, RoutedEventArgs A_1)
    {
      short num1 = 31184;
      int num2 = (int) num1;
      num1 = (short) 31184;
      int num3 = (int) num1;
      switch (num2 == num3)
      {
        case true:
          short num4 = 0;
          num4 = (short) 0;
          if (num4 == (short) 0)
            ;
          num4 = (short) 1;
          if (num4 == (short) 0)
            ;
          this.e.Visibility = Visibility.Visible;
          this.g.Visibility = Visibility.Hidden;
          this.k.Visibility = Visibility.Hidden;
          this.d.Visibility = Visibility.Hidden;
          break;
        default:
          goto case 1;
      }
    }

    private void d(object A_0, RoutedEventArgs A_1)
    {
      short num1 = 7450;
      int num2 = (int) num1;
      num1 = (short) 7450;
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
          this.e.Visibility = Visibility.Hidden;
          this.g.Visibility = Visibility.Hidden;
          this.k.Visibility = Visibility.Hidden;
          this.d.Visibility = Visibility.Visible;
          break;
        default:
          goto case 1;
      }
    }

    private void a(object A_0, TextChangedEventArgs A_1)
    {
      short num1 = 6;
      int num2 = (int) num1;
      num1 = (short) 6;
      int num3 = (int) num1;
      switch (num2 == num3)
      {
        case true:
          short num4 = 0;
          num4 = (short) 0;
          if (num4 == (short) 0)
            ;
          num4 = (short) 1;
          if (num4 == (short) 0)
            break;
          break;
        default:
          goto case 1;
      }
    }

    private void a(object A_0, MouseButtonEventArgs A_1)
    {
      int num1 = 1;
      short num2;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_9;
          case 1:
            num2 = (short) 1;
            if (num2 == (short) 0)
              ;
            switch (0)
            {
              case 0:
                break;
              default:
                continue;
            }
            break;
          case 2:
label_6:
            ((Window) this).DragMove();
            num2 = (short) -5577;
            int num3 = (int) num2;
            num2 = (short) -5577;
            int num4 = (int) num2;
            switch (num3 == num4 ? 1 : 0)
            {
              case 0:
              case 2:
                goto label_6;
              default:
                num2 = (short) 0;
                if (num2 == (short) 0)
                  ;
                num2 = (short) 0;
                num1 = (int) (IntPtr) num2;
                continue;
            }
        }
        if (A_1.ChangedButton == MouseButton.Left)
        {
          num2 = (short) 2;
          num1 = (int) (IntPtr) num2;
        }
        else
          break;
      }
label_9:
      num2 = (short) 0;
    }

    private void c(object A_0, RoutedEventArgs A_1)
    {
      short num1 = -2125;
      int num2 = (int) num1;
      num1 = (short) -2125;
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
          ((Window) this).Close();
          break;
        default:
          goto case 1;
      }
    }

    private void b(object A_0, RoutedEventArgs A_1)
    {
      int A_1_1 = 4;
      short num1 = 30795;
      int num2 = (int) num1;
      num1 = (short) 30795;
      int num3 = (int) num1;
      switch (num2 == num3)
      {
        case true:
          short num4 = 0;
          if (num4 == (short) 0)
            ;
          num4 = (short) 1;
          if (num4 == (short) 0)
            ;
          Process.Start(App.b("\u0A61ၣብᡧᥩ噫䅭彯ᙱᵳյ᭷ᕹ\u0E7B\u1A7D깿\uE581\uE383ꦅ\uED87\uF889\uED8B\uE88Dﺏ", A_1_1));
          break;
        default:
          goto case 1;
      }
    }

    private void a(object A_0, RoutedEventArgs A_1)
    {
      int A_1_1 = 13;
      int num1 = 0;
      switch (num1)
      {
        default:
          short num2;
          Ping ping;
          bool flag;
          switch (0)
          {
            case 0:
label_4:
              ping = new Ping();
              flag = false;
              num2 = (short) 5;
              num1 = (int) (IntPtr) num2;
              goto default;
            default:
              while (true)
              {
                num2 = (short) 1;
                if (num2 == (short) 0)
                  ;
                float num3;
                float num4;
                switch (num1)
                {
                  case 0:
                    int num5 = (int) MessageBox.Show(App.b("⩪ͬ佮ᑰŲݴᡶ\u0B78孺ቼ᱾\uE280\uF682\uF784\uE286\uED88ꮊ戴\uE78E\uF890ﾒ\uF094랖滛\uF39A\uF89Cﲞ쪠쪢쮤삦覨춪슬\uDDAE醰욲어펶\uD8B8쾺\uD8BC첾\uEFC0짂闄ꯆ곈\uAACA뻌\uAACE\uF1D0\uA7D2냔믖뗘ﯚ鏜냞闠쏢蓤쟦믨蓪迬胮藰탲쏴컶쫸짺\uDDFC黾挀氂瀄猆⤈缊攌明成㴒", A_1_1), App.b("\u2E6AὬᵮṰŲ", A_1_1), MessageBoxButton.OK, MessageBoxImage.Hand);
                    num2 = (short) 4;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 1:
                    goto label_6;
                  case 2:
                    if (flag)
                    {
                      num2 = (short) 3;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    goto label_27;
                  case 3:
label_20:
                    string str = new WebClient().DownloadString(App.b("ͪᥬ᭮Űr佴塶噸ṺོṾ\uE780\uED82ꮄﾆ\uF088\uF18Aꊌ\uE38E\uF090\uE692ﮔ\uF496\uF198ﺚ\uEF9C\uF69E쾠얢쪤覦쎨\uD8AA슬솮", A_1_1));
                    num3 = 1.41f;
                    num4 = float.Parse(JsonConvert.DeserializeObject<MainWindow.JSONData>(str).version);
                    num2 = (short) 7;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 4:
                    goto label_19;
                  case 5:
                    try
                    {
                      ping.Send(App.b("ᱪᩬᡮ彰᭲ၴնᙸၺ\u087C兾\uE280\uEC82\uE884", A_1_1));
                      flag = true;
                    }
                    catch (PingException ex)
                    {
                      flag = false;
                      if (MessageBox.Show(App.b("⩪ͬ佮ᡰᵲŴቶ\u0B78ᕺ\u187C\u0B7Eꆀ\uE082\uEA84\uE986\uE788\uEE8A\uEE8Cﮎ\uF890ﲒﮔ랖\uF098\uE89A붜\uED9E쒠튢키캦\uDBA8캪즬辮얰\uDCB2閴슶쪸\uDEBA鶼諭돀ꋂ\uEBC4췆駈\uA7CA\uA8CC껎ꋐ뛒\uF5D4듖뛘뗚돜뫞苠韢엤鏦蛨쯪駬蟮铰폲鳴駶跸黺迼釾搀眂⬄", A_1_1), App.b("⡪ɬŮὰᙲᙴͶ奸ེቼ彾\uF580\uEB82\uE084Ꞇ삈\uE58A歷\uEA8E\uE390ﶒ\uF094\uE396", A_1_1), MessageBoxButton.OK, MessageBoxImage.Exclamation) == MessageBoxResult.OK)
                        ((Window) this).Close();
                    }
                    num1 = 2;
                    continue;
                  case 6:
                    num2 = (short) -29427;
                    int num6 = (int) num2;
                    num2 = (short) -29427;
                    int num7 = (int) num2;
                    switch (num6 == num7 ? 1 : 0)
                    {
                      case 0:
                      case 2:
                        goto label_20;
                      default:
                        num2 = (short) 0;
                        if (num2 == (short) 0)
                          ;
                        if ((double) num3 != (double) num4)
                        {
                          num2 = (short) 10;
                          num1 = (int) (IntPtr) num2;
                          continue;
                        }
                        num2 = (short) 8;
                        num1 = (int) (IntPtr) num2;
                        continue;
                    }
                  case 7:
                    if ((double) num3 >= (double) num4)
                    {
                      num2 = (short) 6;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    num2 = (short) 11;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  case 8:
                    goto label_5;
                  case 9:
                    if (MessageBox.Show(App.b("⩪ͬ佮ѰͲᅴᙶ\u0D78Ṻ嵼ᙾ\uF280ꎂ\uE484\uF186\uE888\uE28A\uE18C\uEE8E\uF390ﾒ\uF094뚖릘\uDF9A\uF29C뾞\uD8A0첢키螦\uDEA8쪪쎬\uDBAE醰잲\uDAB4鞶첸쮺\uD9BC\uDEBE뗀ꛂ醙", A_1_1), App.b("㹪ᵬ୮ၰݲၴ坶㡸ൺᱼᙾ\uED80\uE282\uE784\uEB86\uEC88ꪊ", A_1_1), MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.Yes)
                    {
                      num2 = (short) 1;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    goto label_23;
                  case 10:
                    num2 = (short) 0;
                    if ((double) num3 > (double) num4)
                    {
                      num2 = (short) 0;
                      num1 = (int) (IntPtr) num2;
                      continue;
                    }
                    goto label_31;
                  case 11:
                    num2 = (short) 9;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_19:
              return;
label_5:
              int num8 = (int) MessageBox.Show(App.b("\u2E6AὬ\u0E6E兰ᩲٴ坶\u0C78\u0B7A嵼\u0B7E\uEE80ꎂ\uE184\uE686ﶈ\uEE8Aꎌ", A_1_1), App.b("㹪ᵬ䉮հᱲ塴㍶\u1878ེ\u187C", A_1_1), MessageBoxButton.OK, MessageBoxImage.Asterisk);
              return;
label_6:
              Process.Start(App.b("ͪᥬ᭮Űr佴塶噸ὺᑼ\u0C7E\uE280\uEC82\uF784\uE386ꞈ\uEC8A\uEA8Cꂎ\uF490\uE192\uF494\uF196\uF798", A_1_1));
              return;
label_31:
              return;
label_27:
              return;
label_23:
              return;
          }
      }
    }

    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    [DebuggerNonUserCode]
    public void InitializeComponent()
    {
      int A_1 = 15;
      short num1;
      if (this.v)
      {
        num1 = (short) 25058;
        int num2 = (int) num1;
        num1 = (short) 25058;
        int num3 = (int) num1;
        switch (num2 == num3 ? 1 : 0)
        {
          case 0:
          case 2:
            break;
          default:
            num1 = (short) 0;
            if (num1 == (short) 0)
              ;
            num1 = (short) 1;
            if (num1 == (short) 0)
              ;
            return;
        }
      }
      num1 = (short) 0;
      this.v = true;
      Application.LoadComponent((object) this, new Uri(App.b("䉬⩮⍰㉲㥴ᙶ\u0C78ᕺṼ\u177E\uE480\uF182펄떆늈\uE88A\uE28C\uE28E\uE190ﲒﮔ\uF296\uF798\uEF9A늜\uF29E삠쪢쮤킦삨얪즬삮우鶲춴횶풸ힺ", A_1), UriKind.Relative));
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    void IComponentConnector.Connect(int connectionId, object target)
    {
      int num1 = 1;
      short num2;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_34;
          case 1:
            switch (0)
            {
              case 0:
                break;
              default:
                continue;
            }
            break;
          case 2:
            num2 = (short) 0;
            num1 = (int) (IntPtr) num2;
            continue;
        }
        switch (connectionId)
        {
          case 1:
            goto label_29;
          case 2:
            goto label_9;
          case 3:
            goto label_21;
          case 4:
            goto label_20;
          case 5:
            goto label_7;
          case 6:
            goto label_13;
          case 7:
            goto label_28;
          case 8:
            goto label_22;
          case 9:
            goto label_18;
          case 10:
            goto label_26;
          case 11:
            goto label_25;
          case 12:
            goto label_31;
          case 13:
            goto label_12;
          case 14:
            goto label_6;
          case 15:
            goto label_27;
          case 16:
            goto label_32;
          case 17:
            goto label_10;
          case 18:
            goto label_5;
          case 19:
            goto label_24;
          case 20:
            goto label_23;
          case 21:
            goto label_8;
          case 22:
            goto label_16;
          case 23:
            goto label_30;
          case 24:
            goto label_11;
          case 25:
            goto label_17;
          default:
            num2 = (short) 2;
            num1 = (int) (IntPtr) num2;
            continue;
        }
      }
label_5:
      ((ButtonBase) target).Click += new RoutedEventHandler(this.d);
      return;
label_6:
      ((ButtonBase) target).Click += new RoutedEventHandler(this.g);
      return;
label_7:
      this.g = (Grid) target;
      return;
label_8:
      this.s = (Grid) target;
      return;
label_9:
      num2 = (short) 0;
      this.d = (Grid) target;
      return;
label_10:
      this.q = (Grid) target;
      return;
label_11:
      ((ButtonBase) target).Click += new RoutedEventHandler(this.c);
      return;
label_12:
      this.o = (StackPanel) target;
      return;
label_13:
      num2 = (short) -6611;
      int num3 = (int) num2;
      num2 = (short) -6611;
      int num4 = (int) num2;
      switch (num3 == num4 ? 1 : 0)
      {
        case 0:
        case 2:
          goto label_25;
        default:
          num2 = (short) 0;
          if (num2 == (short) 0)
            ;
          this.h = (TextBox) target;
          this.h.TextChanged += new TextChangedEventHandler(this.a);
          return;
      }
label_16:
      ((ButtonBase) target).Click += new RoutedEventHandler(this.b);
      return;
label_17:
      this.u = (Grid) target;
      return;
label_18:
      this.k = (Grid) target;
      return;
label_20:
      this.f = (Label) target;
      return;
label_21:
      this.e = (Grid) target;
      return;
label_22:
      this.j = (System.Windows.Controls.Button) target;
      this.j.Click += new RoutedEventHandler(this.i);
      return;
label_23:
      ((ButtonBase) target).Click += new RoutedEventHandler(this.e);
      return;
label_24:
      this.r = (Grid) target;
      return;
label_25:
      this.m = (System.Windows.Controls.Button) target;
      this.m.Click += new RoutedEventHandler(this.l);
      return;
label_26:
      this.l = (Border) target;
      return;
label_27:
      this.p = (Grid) target;
      return;
label_28:
      this.i = (System.Windows.Controls.Button) target;
      this.i.Click += new RoutedEventHandler(this.j);
      return;
label_29:
      this.c = (MainWindow) target;
      ((UIElement) this.c).MouseLeftButtonDown += new MouseButtonEventHandler(this.a);
      return;
label_30:
      this.t = (Grid) target;
      return;
label_31:
      this.n = (Grid) target;
      return;
label_32:
      num2 = (short) 1;
      if (num2 == (short) 0)
        ;
      ((ButtonBase) target).Click += new RoutedEventHandler(this.f);
      return;
label_34:
      this.v = true;
    }

    public class MainWindoww
    {
      public unsafe void InjectDLL(IntPtr hProcess, string strDLLName)
      {
        int A_1 = 6;
        int num1 = 0;
        switch (num1)
        {
          default:
            IntPtr num2;
            IntPtr remoteThread;
            int num3;
            short num4;
            switch (0)
            {
              case 0:
label_3:
                int num5 = strDLLName.Length + 1;
                num2 = MainWindow.VirtualAllocEx(hProcess, (IntPtr) (void*) null, (uint) num5, 4096U, 64U);
                IntPtr num6;
                MainWindow.WriteProcessMemory(hProcess, num2, strDLLName, (UIntPtr) (ulong) num5, out num6);
                UIntPtr procAddress = MainWindow.GetProcAddress(MainWindow.GetModuleHandle(App.b("ལͥᩧѩ५ɭ䍯䁱婳ትᑷᙹ", A_1)), App.b("⡣॥१\u0E69\u206Bݭቯqᕳѵŷ㭹", A_1));
                remoteThread = MainWindow.CreateRemoteThread(hProcess, (IntPtr) (void*) null, 0U, procAddress, num2, 0U, out num6);
                num3 = MainWindow.WaitForSingleObject(remoteThread, 10000);
                num4 = (short) 4;
                num1 = (int) (IntPtr) num4;
                goto default;
              default:
                while (true)
                {
                  switch (num1)
                  {
                    case 0:
                      num4 = (short) 28150;
                      int num7 = (int) num4;
                      num4 = (short) 28150;
                      int num8 = (int) num4;
                      switch (num7 == num8 ? 1 : 0)
                      {
                        case 0:
                        case 2:
                          break;
                        default:
                          num4 = (short) 0;
                          if (num4 == (short) 0)
                            ;
                          num4 = (short) 1;
                          num1 = (int) (IntPtr) num4;
                          continue;
                      }
                      break;
                    case 1:
                      if (num3 == -1)
                      {
                        num4 = (short) 5;
                        num1 = (int) (IntPtr) num4;
                        continue;
                      }
                      goto label_16;
                    case 2:
                      num4 = (short) 3;
                      num1 = (int) (IntPtr) num4;
                      continue;
                    case 3:
                      num4 = (short) 1;
                      if (num4 == (short) 0)
                        ;
                      if (num3 == 258)
                        goto label_6;
                      else
                        break;
                    case 4:
                      num4 = (short) 0;
                      if (num3 != 128)
                      {
                        num4 = (short) 2;
                        num1 = (int) (IntPtr) num4;
                        continue;
                      }
                      goto label_6;
                    case 5:
                      goto label_6;
                    default:
                      goto label_3;
                  }
                  num4 = (short) 0;
                  num1 = (int) (IntPtr) num4;
                }
label_6:
                MainWindow.CloseHandle(remoteThread);
                return;
label_16:
                Thread.Sleep(1000);
                MainWindow.VirtualFreeEx(hProcess, num2, (UIntPtr) 0UL, 32768U);
                MainWindow.CloseHandle(remoteThread);
                return;
            }
        }
      }

      public int GetProcessId(string proc)
      {
        short num1 = 30191;
        int num2 = (int) num1;
        num1 = (short) 30191;
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
            return Process.GetProcessesByName(proc)[0].Id;
          default:
            goto case 1;
        }
      }
    }

    public class Inject
    {
      public static void InjectDLL()
      {
        int A_1 = 14;
        short num1 = -23438;
        int num2 = (int) num1;
        num1 = (short) -23438;
        int num3 = (int) num1;
        switch (num2 == num3)
        {
          case true:
            short num4 = 0;
            num4 = (short) 0;
            if (num4 == (short) 0)
              ;
            num4 = (short) 1;
            if (num4 == (short) 0)
              ;
            string strDLLName = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + App.b("に⭭ɯ\u1371≳䑵噷ṹၻች", A_1));
            string proc = App.b("⩫ŭɯٱᩳή\u0C77ό㽻ች\uE97F\uE781\uEA83\uF285ꖇ\uDD89\uE58B\uE08Dꚏꚑ릓얕\uF097\uF399\uEC9B\uEE9D즟첡쎣", A_1);
            MainWindow.MainWindoww mainWindoww = new MainWindow.MainWindoww();
            mainWindoww.InjectDLL(MainWindow.OpenProcess(2035711U, 1, mainWindoww.GetProcessId(proc)), strDLLName);
            break;
          default:
            goto case 1;
        }
      }
    }

    public class StartFortnite
    {
      public static void Start()
      {
        int A_1 = 1;
        int num1;
        string path;
        short num2;
        switch (0)
        {
          case 0:
label_2:
            path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), App.b("\u125E\u0860bᝤ\u0866ᩨѪ୬᭮⵰ቲմṶ呸ൺ佼剾\uEC80\uF082ꢄ\uF086\uE088\uE58Aꂌ\uEC8E\uE390\uE792뢔\uE296\uED98\uF29A\uF19C\uF69E햠\uDAA2袤쮦風蚪鲬芮膰鶲톴\uDBB6햸", A_1));
            num2 = (short) 1;
            num1 = (int) (IntPtr) num2;
            goto default;
          default:
            while (true)
            {
              switch (num1)
              {
                case 0:
                  goto label_9;
                case 1:
                  if (!System.IO.File.Exists(path))
                  {
                    num2 = (short) 2;
                    num1 = (int) (IntPtr) num2;
                    continue;
                  }
                  goto label_9;
                case 2:
                  System.IO.File.Create(path).Close();
                  num2 = (short) 4479;
                  int num3 = (int) num2;
                  num2 = (short) 4479;
                  int num4 = (int) num2;
                  switch (num3 == num4 ? 1 : 0)
                  {
                    case 0:
                    case 2:
                      goto label_2;
                    default:
                      num2 = (short) 0;
                      if (num2 == (short) 0)
                        ;
                      num2 = (short) 1;
                      if (num2 == (short) 0)
                        ;
                      num2 = (short) 0;
                      num2 = (short) 0;
                      num1 = (int) (IntPtr) num2;
                      continue;
                  }
                default:
                  goto label_2;
              }
            }
label_9:
            string str = System.IO.File.ReadAllText(path) + App.b("ᥞ\u0E60ᅢᅤ०hὪ\u086C⡮ၰṲၴ⭶㭸ቺ\u137CṾ\uF380\uEA82\uE084\uF486했\uDC8A\uE48C\uE18EꞐꞒ즔톖\uF698\uE99A\uE99C\uF19E좠힢삤\uE4A6얨슪좬솮얰麲\uE2B4\uDEB6ힸ趺覼銾鋀ꯂ계럆마ꋊꏌ꣎\uFFD0뛒귔닖", A_1);
            Process process = new Process();
            process.StartInfo.FileName = str;
            process.StartInfo.Arguments = App.b("牞འౢd٦੨䭪䁬ŮṰᅲၴ坶呸ᵺᅼ\u0B7E\uEE80\uE882\uE084\uE986뒈\uE58A\uE28C\uE18E\uF490뎒뢔\uD996\uF698\uD89A\uF29Cﮞ쒠\uE4A2키욦\uDBA8쾪\uDEAC辮鲰횲어\uDEB6\uDAB8\uDABA춼쾾ﳀ藂\uAAC4뗆뷈ꗊ\uA4CC믎듐\uF3D2\uF8D4닖꧘닚뻜뫞迠闢\uD8E4럦鯨蓪觬쿮\uDCF0雲藴黶髸诺鋼跾甀戂椄✆␈渊紌明爐缒稔琖砘眚砜∞䐠䴢ࠤ刦娨ପ,尮娰娲䔴䜶堸伺帼圾≀⭂⁄⑆≈歊恌ŎṐRٔ᭖क़ቚ\u135Cᅞ⡠ⵢ≤䝦䑨⩪㡬㭮㥰Ⱳ㥴㡶㹸㉺㍼䉾쒀톂쒄Ꞇꒈ쪊\uD88C\uDB8E\uD990첒솔캖즘\uDE9Aꂜ爵토쪢욤螦蒨\uEAAA\uF8ACﮮ聆\uECB2\uE5B4\uF6B6\uEAB8\uE8BA\uEABC\uF0BE鏀蟂\uF8C4ꏆ", A_1);
            process.StartInfo.UseShellExecute = false;
            process.Start();
            process.WaitForInputIdle();
            new Thread(new ThreadStart(MainWindow.Inject.InjectDLL)).Start();
            break;
        }
      }
    }

    public class JSONData
    {
      public string version
      {
        get
        {
          short num1 = -17000;
          int num2 = (int) num1;
          num1 = (short) -17000;
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
          short num1 = 1;
          if (num1 == (short) 0)
            ;
          num1 = (short) 4297;
          int num2 = (int) num1;
          num1 = (short) 4297;
          int num3 = (int) num1;
          switch (num2 == num3)
          {
            case true:
              num1 = (short) 0;
              if (num1 == (short) 0)
                ;
              this.a = value;
              break;
            default:
              num1 = (short) 0;
              goto case 1;
          }
        }
      }
    }
  }
}
