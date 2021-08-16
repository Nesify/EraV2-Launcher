// Decompiled with JetBrains decompiler
// Type: ERALauncherV2.Properties.Resources
// Assembly: ERALauncherV2, Version=1.4.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6923A52C-9B51-4CC1-B838-ADDD1FEF91EF
// Assembly location: C:\Users\vloge\Downloads\Release\FortniteLauncher.exe

using AcrylicWindow;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ERALauncherV2.Properties
{
  [DebuggerNonUserCode]
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager a;
    private static CultureInfo b;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        int A_1 = 3;
        int num1 = 1;
        short num2;
        while (true)
        {
          switch (num1)
          {
            case 0:
              goto label_10;
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
              num2 = (short) 13138;
              int num3 = (int) num2;
              num2 = (short) 13138;
              int num4 = (int) num2;
              switch (num3 == num4 ? 1 : 0)
              {
                case 0:
                case 2:
                  num2 = (short) 0;
                  num1 = (int) (IntPtr) num2;
                  continue;
                default:
                  num2 = (short) 0;
                  if (num2 == (short) 0)
                    ;
                  ERALauncherV2.Properties.Resources.a = new ResourceManager(App.b("\u2460ㅢ\u2464⭦\u0868Ṫͬ౮ᥰᙲݴⅶ䭸啺\u2D7Cൾ\uEE80\uF382\uE084\uF586ﶈ\uE28A\uE88Cﲎ뾐솒\uF094\uE496\uF698\uEE9A\uEF9Cﲞ쒠킢", A_1), typeof (ERALauncherV2.Properties.Resources).Assembly);
                  goto case 0;
              }
          }
          if (ERALauncherV2.Properties.Resources.a == null)
          {
            num2 = (short) 1;
            if (num2 == (short) 0)
              ;
            num2 = (short) 2;
            num1 = (int) (IntPtr) num2;
          }
          else
            goto label_11;
        }
label_10:
        num2 = (short) 0;
label_11:
        return ERALauncherV2.Properties.Resources.a;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get
      {
        short num1 = 7892;
        int num2 = (int) num1;
        num1 = (short) 7892;
        int num3 = (int) num1;
        switch (num2 == num3)
        {
          case true:
            short num4 = 0;
            if (num4 == (short) 0)
              ;
            num4 = (short) 0;
            num4 = (short) 1;
            if (num4 == (short) 0)
              ;
            return ERALauncherV2.Properties.Resources.b;
          default:
            goto case 1;
        }
      }
      set
      {
        short num1 = 435;
        int num2 = (int) num1;
        num1 = (short) 435;
        int num3 = (int) num1;
        switch (num2 == num3)
        {
          case true:
            short num4 = 0;
            if (num4 == (short) 0)
              ;
            num4 = (short) 0;
            num4 = (short) 1;
            if (num4 == (short) 0)
              ;
            ERALauncherV2.Properties.Resources.b = value;
            break;
          default:
            goto case 1;
        }
      }
    }
  }
}
