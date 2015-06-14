﻿Imports System.Data.OleDb
Imports System.Runtime.InteropServices



Public Class RootForm
    Const STUDENT_PROFILE = 0
    Const GEAR_LOANING = 3
    Dim formGearLoaning As New GearLoaning()
    Dim formStudentProfile As New StudentProfilesForm()
    Dim formAttendance As New AttendanceForm()
    Dim formLogin As New Login()
    Dim formCalendar As New Calendar()
    Dim topform = formStudentProfile
    Dim intform = STUDENT_PROFILE
    Public Shared connection As New OleDbConnection

    Private WithEvents kbHook As New KeyboardHook

    Private Sub kbHook_KeyDown(ByVal Key As System.Windows.Forms.Keys) Handles kbHook.KeyDown
        If intform = GEAR_LOANING Then
            formGearLoaning.kbhook(Key)
        End If
    End Sub

    Private Sub RootForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        connection.Close()
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        connection = New OleDbConnection(My.Settings.FencingConnectionString)
        connection.Open()

        If (Screen.PrimaryScreen.Bounds.Width > 1366 And Screen.PrimaryScreen.Bounds.Height > 768) Then
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        End If

        'Load Forms

        formAttendance.TopLevel = False
        Me.Panel1.Controls.Add(formAttendance)

        formStudentProfile.TopLevel = False
        Me.Panel1.Controls.Add(formStudentProfile)

        formGearLoaning.TopLevel = False
        Panel1.Controls.Add(formGearLoaning)

        formLogin.TopLevel = False
        Panel1.Controls.Add(formLogin)

        formCalendar.TopLevel = False
        Panel1.Controls.Add(formCalendar)

        ' Show Student Profile on Load 
        'should totes change to login later
        formStudentProfile.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnStudentProf_Click(sender As Object, e As EventArgs) Handles btnStudentProf.Click
        topform.hide()
        topform = formStudentProfile
        intform = STUDENT_PROFILE
        topform.show()
    End Sub

    Private Sub btnAttendance_Click(sender As Object, e As EventArgs) Handles btnAttendance.Click

    End Sub

    Private Sub btnGearLoan_Click(sender As Object, e As EventArgs) Handles btnGearLoan.Click
        topform.hide()
        topform = formGearLoaning
        intform = GEAR_LOANING
        topform.show()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        topform.hide()
        topform = formLogin
        intform = STUDENT_PROFILE
        topform.show()
    End Sub

    Private Sub btnCalendar_Click(sender As Object, e As EventArgs) Handles btnCalendar.Click
        topform.Hide()
        topform = formCalendar
        intform = STUDENT_PROFILE ' Seriously, someone should make constants for the other forms
        topform.Show()
    End Sub
End Class

Public Class KeyboardHook

    <DllImport("User32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)> _
    Private Overloads Shared Function SetWindowsHookEx(ByVal idHook As Integer, ByVal HookProc As KBDLLHookProc, ByVal hInstance As IntPtr, ByVal wParam As Integer) As Integer
    End Function
    <DllImport("User32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)> _
    Private Overloads Shared Function CallNextHookEx(ByVal idHook As Integer, ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer
    End Function
    <DllImport("User32.dll", CharSet:=CharSet.Auto, CallingConvention:=CallingConvention.StdCall)> _
    Private Overloads Shared Function UnhookWindowsHookEx(ByVal idHook As Integer) As Boolean
    End Function

    <StructLayout(LayoutKind.Sequential)> _
    Private Structure KBDLLHOOKSTRUCT
        Public vkCode As UInt32
        Public scanCode As UInt32
        Public flags As KBDLLHOOKSTRUCTFlags
        Public time As UInt32
        Public dwExtraInfo As UIntPtr
    End Structure

    <Flags()> _
    Private Enum KBDLLHOOKSTRUCTFlags As UInt32
        LLKHF_EXTENDED = &H1
        LLKHF_INJECTED = &H10
        LLKHF_ALTDOWN = &H20
        LLKHF_UP = &H80
    End Enum

    Public Shared Event KeyDown(ByVal Key As Keys)
    Public Shared Event KeyUp(ByVal Key As Keys)

    Private Const WH_KEYBOARD_LL As Integer = 13
    Private Const HC_ACTION As Integer = 0
    Private Const WM_KEYDOWN = &H100
    Private Const WM_KEYUP = &H101
    Private Const WM_SYSKEYDOWN = &H104
    Private Const WM_SYSKEYUP = &H105

    Private Delegate Function KBDLLHookProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer

    Private KBDLLHookProcDelegate As KBDLLHookProc = New KBDLLHookProc(AddressOf KeyboardProc)
    Private HHookID As IntPtr = IntPtr.Zero

    Private Function KeyboardProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As Integer
        If (nCode = HC_ACTION) Then
            Dim struct As KBDLLHOOKSTRUCT
            Select Case wParam
                Case WM_KEYDOWN, WM_SYSKEYDOWN
                    RaiseEvent KeyDown(CType(CType(Marshal.PtrToStructure(lParam, struct.GetType()), KBDLLHOOKSTRUCT).vkCode, Keys))
                Case WM_KEYUP, WM_SYSKEYUP
                    RaiseEvent KeyUp(CType(CType(Marshal.PtrToStructure(lParam, struct.GetType()), KBDLLHOOKSTRUCT).vkCode, Keys))
            End Select
        End If
        Return CallNextHookEx(IntPtr.Zero, nCode, wParam, lParam)
    End Function

    Public Sub New()
        HHookID = SetWindowsHookEx(WH_KEYBOARD_LL, KBDLLHookProcDelegate, System.Runtime.InteropServices.Marshal.GetHINSTANCE(System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0)).ToInt32, 0)
        If HHookID = IntPtr.Zero Then
            Throw New Exception("Could not set keyboard hook")
        End If
    End Sub

    Protected Overrides Sub Finalize()
        If Not HHookID = IntPtr.Zero Then
            UnhookWindowsHookEx(HHookID)
        End If
        MyBase.Finalize()
    End Sub
End Class

