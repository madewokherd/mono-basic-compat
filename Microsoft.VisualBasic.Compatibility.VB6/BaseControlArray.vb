'
' BaseControlArray.vb
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
Imports System.ComponentModel

Namespace Microsoft.VisualBasic.Compatibility.VB6

<Obsolete()>
Public MustInherit Class BaseControlArray
	Inherits Component
	Implements ISupportInitialize

	' Constructors
	Protected Sub New ()
		Throw New NotImplementedException()
	End Sub

	Protected Sub New (Container As IContainer)
		Throw New NotImplementedException()
	End Sub

	' Abstract methods
	Protected MustOverride Function GetControlInstanceType () As Type
	Protected MustOverride Sub HookUpControlEvents (o As Object)

	' Method overrides
	Protected Overrides Sub Dispose (disposing as Boolean)
	End Sub

	' ISupportInitialize

	Sub BeginInit () Implements ISupportInitialize.BeginInit
		Throw New NotImplementedException()
	End Sub

	Sub EndInit () Implements ISupportInitialize.EndInit
		Throw New NotImplementedException()
	End Sub

End Class

End Namespace
