﻿Public Class done

    Private Sub done_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label2.Left = (Me.Width / 2) - (Label2.Width / 2)
        PictureBox3.Left = (Me.Width / 2) - (PictureBox3.Width / 2)
        Label4.Left = (Me.Width / 2) - (Label4.Width / 2)
        OK.Left = (Me.Width / 2) - (OK.Width / 2)
        'Store this for DFU Helper -- START
        iDevice = iPhoneModel
        PreviousVersion = IPSWVersion
        PreviousModel = ModelVar
        'Store this for DFU Helper -- END
        'Clear old registers
        iPod2GModel = ""
        'End
        ipswFailed = False
        ExitFlag = False
        ipswBuilding = False
        egeneral.Dispose()
        ecustomapps.Dispose()
        ebootlogos.Dispose()
        eunlock.Dispose()
        Expert.Dispose()
        IdentifyIPSW.Dispose()
        ebuilding.Dispose()
        'MsgBox("iBooty files are located at : " & iBootyPath, MsgBoxStyle.Information)
    End Sub



    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        iPhoneModel = ""
        NORFlashDisabled = False
        Expert.Label2.Text = " "
        DFU.MdiParent = MDIMain
        DFU.Show()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ipt2gdone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub NO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DFU.Enabled = True
        DFU.MdiParent = MDIMain
        DFU.Show()
        iDevice = iPhoneModel
        iPhoneModel = ""
        NORFlashDisabled = False
        Expert.Label2.Text = " "
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        DFU.Enabled = True
        DFU.MdiParent = MDIMain
        iDevice = iPhoneModel
        DFU.Show()
        iPhoneModel = ""
        NORFlashDisabled = False
        '        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub ipt1gpwned_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

    End Sub
End Class