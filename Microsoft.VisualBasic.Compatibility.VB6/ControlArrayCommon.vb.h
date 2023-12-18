'
' ControlArrayCommon.vb.h
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

#define CONCAT_(a,b) a##b
#define CONCAT(a,b) CONCAT_(a,b)

#ifndef CLASSNAME
# define CLASSNAME CONCAT(TYPE,Array)
#endif

<Obsolete()>
Public Partial Class CLASSNAME
Inherits BaseControlArray
Implements IExtenderProvider

	Public Sub New(Container as IContainer)
		MyBase.New (Container)
	End Sub

	'BaseControlArray abstract methods
	Protected Overrides Function GetControlInstanceType () As Type
		GetControlInstanceType = GetType(TYPE)
	End Function

	Protected Overrides Sub HookUpControlEvents (o As Object)
#ifndef SUPPRESSCONTROLEVENTS
		Control_HookupControlEvents (DirectCast(o,TYPE))
#endif
#ifdef TEXTBOXBASE
		TextBoxBase_HookupControlEvents (DirectCast(o,TYPE))
#endif
		CONCAT(TYPE, _HookupControlEvents) (DirectCast(o,TYPE))
	End Sub

	' Public methods
	Public Sub SetIndex (o As TYPE, Index As Short)
		BaseSetIndex (o, Index, fIsEndInitCalled)
	End Sub

	'IExtenderProvider
	Public Function CanExtend (target As Object) As Boolean Implements IExtenderProvider.CanExtend
		Throw New NotImplementedException()
	End Function

#ifndef SUPPRESSCONTROLEVENTS
	' Events on Control type
	Private Sub Control_HookupControlEvents (o As TYPE)
		AddHandler o.AutoSizeChanged, AddressOf Control_AutoSizeChanged
	End Sub

	Public Event AutoSizeChanged As EventHandler
	Private Sub Control_AutoSizeChanged (sender As Object, e As EventArgs)
		RaiseEvent AutoSizeChanged(sender, e)
	End Sub
#endif

#ifdef TEXTBOXBASE
	' Events on TextBoxBase type
	Private Sub TextBoxBase_HookupControlEvents (o As TYPE)
		AddHandler o.AcceptsTabChanged, AddressOf TextBoxBase_AcceptsTabChanged
	End Sub

	Public Event AcceptsTabChanged As EventHandler
	Private Sub TextBoxBase_AcceptsTabChanged (sender As Object, e As EventArgs)
		RaiseEvent AcceptsTabChanged(sender, e)
	End Sub
#endif

End Class

