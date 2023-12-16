'
' AssemblyInfo.vb
'
' Authors:
'   Esme Povirk <esme@codeweavers.com>
'
' Copyright (C) 2023 CodeWeavers, Inc
'
' Permission is hereby granted, free of charge, to any person obtaining
' a copy of this software and associated documentation files (the
' "Software"), to deal in the Software without restriction, including
' without limitation the rights to use, copy, modify, merge, publish,
' distribute, sublicense, and/or sell copies of the Software, and to
' permit persons to whom the Software is furnished to do so, subject to
' the following conditions:
' 
' The above copyright notice and this permission notice shall be
' included in all copies or substantial portions of the Software.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
' EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
' MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
' NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
' LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
' OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
' WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
'
Imports System
Imports System.Diagnostics
Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Runtime.CompilerServices
Imports System.Resources
Imports System.Security

<Assembly: AssemblyTitle("Microsoft.VisualBasic.Compatibility.dll")> 
<Assembly: AssemblyDescription("Microsoft.VisualBasic.Compatibility.dll")> 
<Assembly: AssemblyCompany("mono-basic-compat project")> 
<Assembly: AssemblyProduct("mono-basic-compat")> 
<Assembly: AssemblyCopyright("(c) mono-basic-compat authors")> 

<Assembly: NeutralResourcesLanguage("en-US")> 
<Assembly: AllowPartiallyTrustedCallers()> 

<Assembly: AssemblyVersion("10.0.0.0")> 
<Assembly: ComVisible(True)> 
<Assembly: CLSCompliant(True)> 
<Assembly: Debuggable(DebuggableAttribute.DebuggingModes.Default Or DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)> 
<Assembly: CompilationRelaxations(CompilationRelaxations.NoStringInterning)> 
<Assembly: RuntimeCompatibility(WrapNonExceptionThrows:=True)> 
<Assembly: SatelliteContractVersion("10.0.0.0")> 
<Assembly: AssemblyInformationalVersion("10.0.30319.17020")> 
<Assembly: AssemblyFileVersion("10.0.30319.17020")> 
<Assembly: AssemblyDefaultAlias("Microsoft.VisualBasic.Compatibility.dll")> 

#If DONTSIGN = False Then
<Assembly: AssemblyDelaySign(True)> 
<Assembly: AssemblyKeyFile("msfinal.pub")> 
#End If
