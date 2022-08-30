
Imports System
Imports Wisej.Web
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Collections
Imports System.Drawing

''' <summary>
''' Wrap the TabOrderManager class and supply extendee controls with a custom tab scheme.
''' </summary>
<ProvideProperty("TabScheme", GetType(Control)), _
Description("Wrap the TabOrderManager class and supply extendee controls with a custom tab scheme"), _
ToolboxBitmap(GetType(TabSchemeProvider), "TabSchemeProvider")> _
Public Class TabSchemeProvider
    Inherits Wisej.Base.Component
    Implements IExtenderProvider

#Region "MEMBER VARIABLES"


    ''' <summary>
    ''' Hashtable to store the controls that use our extender property.
    ''' </summary>
    Private extendees As Hashtable = New Hashtable

    ''' <summary>
    ''' The form we're hosted on, which will be calculated by watching the extendees entering the control hierarchy.
    ''' </summary>
    Private topLevelForm As Form = Nothing

#End Region

#Region "PUBLIC PROPERTIES"
#End Region

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub InitializeComponent()

    End Sub

    ''' <summary>
    ''' Get whether or not we're managing a given control.
    ''' </summary>
    ''' <param name="c"></param>
    ''' <returns></returns>
    <DefaultValue(TabOrderManager.TabScheme.None)> _
    Public Function GetTabScheme(ByVal c As Control) As TabOrderManager.TabScheme
        If Not extendees.Contains(c) Then
            Return TabOrderManager.TabScheme.None
        End If

        Return extendees(c)
    End Function

    ''' <summary>
    ''' Hook up to the form load event and indicate that we've done so.
    ''' </summary>
    Private Sub HookFormLoad()
        If Not topLevelForm Is Nothing Then
            AddHandler topLevelForm.Load, AddressOf TopLevelForm_Load
        End If
    End Sub

    ''' <summary>
    ''' Unhook from the form load event and indicate that we need to do so again before applying tab schemes.
    ''' </summary>
    Private Sub UnhookFormLoad()
        If Not topLevelForm Is Nothing Then
            RemoveHandler topLevelForm.Load, AddressOf TopLevelForm_Load
        End If
    End Sub

    ''' <summary>
    ''' Hook up to all of the parent changed events for this control and its ancestors so that we are informed
    ''' if and when they are added to the top-level form (whose load event we need).
    ''' It's not adequate to look at just the control, because it may have been added to its parent, but the parent
    ''' may not be descendent of the form -yet-.
    ''' </summary>
    ''' <param name="c"></param>
    Private Sub HookParentChangedEvents(ByVal c As Control)
        While Not c Is Nothing
            AddHandler c.ParentChanged, AddressOf Extendee_ParentChanged
            c = c.Parent
        End While
    End Sub

    ''' <summary>
    ''' Set the tab scheme to use on a given control
    ''' </summary>
    ''' <param name="c"></param>
    ''' <returns></returns>
    Public Sub SetTabScheme(ByVal c As Control, ByVal val As TabOrderManager.TabScheme)

        If val <> TabOrderManager.TabScheme.None Then
            extendees(c) = val

            If topLevelForm Is Nothing Then
                If Not c.TopLevelControl Is Nothing Then
                    '' We're in luck.
                    '' This is the form, or this control knows about it, so take the opportunity to grab it and wire up to its Load event.
                    topLevelForm = CType(c.TopLevelControl, Form)
                    HookFormLoad()
                Else
                    '' Set up to wait around until this control or one of its ancestors is added to the form's control hierarchy.
                    HookParentChangedEvents(c)
                End If
            End If
        ElseIf (extendees.Contains(c)) Then
            extendees.Remove(c)

            '' If we no longer have any extendees, we don't need to be wired up to the form load event.
            If extendees.Count = 0 Then
                UnhookFormLoad()
            End If
        End If
    End Sub

#Region "IExtenderProvider Members"

    Function CanExtend(ByVal extendee As Object) As Boolean Implements IExtenderProvider.CanExtend
        Return (TypeOf (extendee) Is Form Or TypeOf (extendee) Is Panel Or TypeOf (extendee) Is GroupBox Or TypeOf (extendee) Is UserControl)
    End Function

#End Region

    Public Sub TopLevelForm_Load(ByVal sender As Object, ByVal e As EventArgs)
        Dim f As Form = CType(sender, Form)
        Dim tom As New TabOrderManager(f)

        '// Add an override for everything with a tab scheme set EXCEPT for the form, which
        '// serves as the root of the whole process.
        Dim formScheme As TabOrderManager.TabScheme = TabOrderManager.TabScheme.None
        Dim extendeeEnumerator As IDictionaryEnumerator = extendees.GetEnumerator
        While extendeeEnumerator.MoveNext
            Dim c As Control = CType(extendeeEnumerator.Key, Control)
            Dim scheme As TabOrderManager.TabScheme = CType(extendeeEnumerator.Value, TabOrderManager.TabScheme)

            If c Is f Then
                formScheme = scheme
            Else
                tom.SetSchemeForControl(c, scheme)
            End If
        End While

        tom.SetTabOrder(formScheme)
    End Sub

    ''' <summary>
    ''' We track when each extendee's parent is changed, and also when their parents are changed, until
    ''' SOMEBODY finally changes their parent to the form, at which point we can hook the load to apply
    ''' the tab schemes.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Extendee_ParentChanged(ByVal sender As Object, ByVal e As EventArgs)
        If Not topLevelForm Is Nothing Then
            '// We've already found the form and attached a load event handler, so there's nothing left to do.
            Return
        End If

        Dim c As Control = CType(sender, Control)

        If Not c.TopLevelControl Is Nothing And TypeOf c.TopLevelControl Is Form Then
            '' We found the form, so we're done.
            topLevelForm = CType(c.TopLevelControl, Form)
            HookFormLoad()
        End If
    End Sub
End Class
