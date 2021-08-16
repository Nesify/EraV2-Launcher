// Decompiled with JetBrains decompiler
// Type: ERALauncherV2.Properties.Settings
// Assembly: ERALauncherV2, Version=1.4.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6923A52C-9B51-4CC1-B838-ADDD1FEF91EF
// Assembly location: C:\Users\vloge\Downloads\Release\FortniteLauncher.exe

using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace ERALauncherV2.Properties
{
  [GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
  [CompilerGenerated]
  internal sealed class Settings : ApplicationSettingsBase
  {
    private static Settings a;

    public static Settings Default
    {
      get
      {
        short num1 = 29850;
        int num2 = (int) num1;
        num1 = (short) 29850;
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
            return Settings.a;
          default:
            goto case 1;
        }
      }
    }

    static Settings()
    {
      short num1 = 31836;
      int num2 = (int) num1;
      num1 = (short) 31836;
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
          // ISSUE: reference to a compiler-generated field
          // ISSUE: object of a compiler-generated type is created
          Settings.a = (Settings) SettingsBase.Synchronized((SettingsBase) new Settings());
          break;
        default:
          goto case 1;
      }
    }
  }
}
