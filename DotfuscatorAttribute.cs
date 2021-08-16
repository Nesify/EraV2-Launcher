// Decompiled with JetBrains decompiler
// Type: DotfuscatorAttribute
// Assembly: ERALauncherV2, Version=1.4.1.0, Culture=neutral, PublicKeyToken=null
// MVID: 6923A52C-9B51-4CC1-B838-ADDD1FEF91EF
// Assembly location: C:\Users\vloge\Downloads\Release\FortniteLauncher.exe

using System;
using System.Runtime.InteropServices;

[ComVisible(false)]
[AttributeUsage(AttributeTargets.Assembly)]
public sealed class DotfuscatorAttribute : Attribute
{
  private string a;
  private bool b;
  private int c;

  public DotfuscatorAttribute(string a, int c, bool b)
  {
    DotfuscatorAttribute dotfuscatorAttribute = this;
    // ISSUE: explicit constructor call
    dotfuscatorAttribute.\u002Ector();
    dotfuscatorAttribute.a = a;
    this.c = c;
    this.b = b;
  }

  public string A => this.a;

  public string a() => this.a;

  public bool B => this.b;

  public bool b() => this.b;

  public int C => this.c;

  public int c() => this.c;
}
