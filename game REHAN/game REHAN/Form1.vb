Public Class Form1
    Private Sub Show_Tick(sender As Object, e As EventArgs) Handles Show.Tick
        grpITEMS.Left = grpITEMS.Left - 10
        If grpITEMS.Left = 470 Then
            Show.Stop()
        End If

    End Sub

    Private Sub Hide_Tick(sender As Object, e As EventArgs) Handles Hide.Tick
        grpITEMS.Left = grpITEMS.Left + 10
        If grpITEMS.Left = 650 Then
            Hide.Stop()
        End If
    End Sub

    Private Sub btnSHOP_Click(sender As Object, e As EventArgs) Handles btnSHOP.Click
        If grpITEMS.Left = 650 Then
            Show.Start()
            btnSHOP.BackColor = Color.Red
        ElseIf grpITEMS.Left = 470 Then
            Hide.Start()
            btnSHOP.BackColor = Color.Gold
        End If
    End Sub
    Dim hpplayer, hpmonster As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        hpmonster = 25
        hpplayer = 50
        btnNEXT.Hide()
        gbrEFEKPUKUL.Hide()
        Player2.Hide()
        lblNILAILEVEL.Text = 1
        lblNILAIATT.Text = 1
        lblNILAIDEFF.Text = 1
        lblMONEY.Text = 800
        lblMONEY.BackColor = Color.Gold
        lblINFORMASI.Text = ""
        lblINFORMASI.Hide()
        lblNILAIHP.Text = 50
        btnSHOP.BackColor = Color.Gold
        pbMONSTER.Value = lblNILAIHPMON.Text / lblNILAIHPMON.Text * 100
    End Sub


    Private Sub senjata1_Click(sender As Object, e As EventArgs) Handles senjata1.Click
        Dim harga As Integer
        harga = 1400

        If lblMONEY.Text < harga Then
            nomoney.Start()
        Else
            lblNILAIATT.Text = lblNILAIATT.Text + 20
            lblMONEY.Text = lblMONEY.Text - harga
        End If
    End Sub

    Private Sub senjata2_Click_1(sender As Object, e As EventArgs) Handles senjata2.Click
        Dim harga As Integer
        harga = 500

        If lblMONEY.Text < harga Then
            nomoney.Start()

        Else
            lblNILAIATT.Text = lblNILAIATT.Text + 5
            lblMONEY.Text = lblMONEY.Text - harga
        End If
    End Sub



    Private Sub senjata4_Click(sender As Object, e As EventArgs) Handles senjata4.Click
        Dim harga As Integer
        harga = 1800

        If lblMONEY.Text < harga Then
            nomoney.Start()

        Else
            lblNILAIATT.Text = lblNILAIATT.Text + 26
            lblMONEY.Text = lblMONEY.Text - harga
        End If
    End Sub


    Private Sub senjata3_Click(sender As Object, e As EventArgs) Handles senjata3.Click
        Dim harga As Integer
        harga = 800

        If lblMONEY.Text < harga Then
            nomoney.Start()

        Else
            lblNILAIATT.Text = lblNILAIATT.Text + 9
            lblMONEY.Text = lblMONEY.Text - harga
        End If
    End Sub

    Private Sub senjata5_Click(sender As Object, e As EventArgs) Handles senjata5.Click
        Dim harga As Integer
        harga = 1200

        If lblMONEY.Text < harga Then
            nomoney.Start()

        Else
            lblNILAIATT.Text = lblNILAIATT.Text + 18
            lblMONEY.Text = lblMONEY.Text - harga
        End If
    End Sub
    Private Sub nomoney_Tick(sender As Object, e As EventArgs) Handles nomoney.Tick
        lblINFORMASI.Show()

        Select Case lblINFORMASI.Text
            Case ""
                lblINFORMASI.Text = "Not"
            Case "Not"
                lblINFORMASI.ForeColor = Color.DarkRed
                lblINFORMASI.Text = "Not Enough"
                lblMONEY.ForeColor = Color.Red
            Case "Not Enough"
                lblINFORMASI.Text = "Not Enough GOLD!!!"
                lblINFORMASI.ForeColor = Color.Red
                lblMONEY.ForeColor = Color.Black
            Case "Not Enough GOLD!!!"
                lblINFORMASI.Text = "Not Enough GOLD!!! "
                lblINFORMASI.ForeColor = Color.DarkRed
                lblMONEY.ForeColor = Color.Red
            Case "Not Enough GOLD!!! "
                lblINFORMASI.Text = "Not Enough GOLD!!!  "
                lblINFORMASI.ForeColor = Color.Red
                lblMONEY.ForeColor = Color.Black
            Case "Not Enough GOLD!!!  "
                lblMONEY.ForeColor = Color.Black
                lblINFORMASI.Text = ""
                lblINFORMASI.Hide()
                nomoney.Stop()
        End Select
    End Sub

    Private Sub lblMONEY_Click(sender As Object, e As EventArgs) Handles lblMONEY.Click

    End Sub

    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles tornado.Click
        Dim harga As Integer
        harga = 4000

        If lblMONEY.Text < harga Then
            nomoney.Start()

        Else
            sihir1.BackgroundImage = tornado.BackgroundImage
        End If
    End Sub

    Private Sub chainbolt_Click(sender As Object, e As EventArgs) Handles chainbolt.Click
        Dim harga As Integer
        harga = 4600

        If lblMONEY.Text < harga Then
            nomoney.Start()

        Else
            sihir2.BackgroundImage = chainbolt.BackgroundImage
        End If
    End Sub

    Private Sub sunstrike_Click(sender As Object, e As EventArgs) Handles sunstrike.Click
        Dim harga As Integer
        harga = 5000

        If lblMONEY.Text < harga Then
            nomoney.Start()

        Else
            sihir3.BackgroundImage = sunstrike.BackgroundImage
        End If
    End Sub

    Private Sub frostbite_Click(sender As Object, e As EventArgs) Handles frostbite.Click
        Dim harga As Integer
        harga = 5200

        If lblMONEY.Text < harga Then
            nomoney.Start()

        Else
            sihir4.BackgroundImage = frostbite.BackgroundImage
        End If
    End Sub

    Private Sub Lightningbolt_Click(sender As Object, e As EventArgs) Handles Lightningbolt.Click
        Dim harga As Integer
        harga = 5500

        If lblMONEY.Text < harga Then
            nomoney.Start()

        Else
            sihir5.BackgroundImage = Lightningbolt.BackgroundImage
        End If
    End Sub

    Private Sub fireblast_Click(sender As Object, e As EventArgs) Handles fireblast.Click
        Dim harga As Integer
        harga = 8000

        If lblMONEY.Text < harga Then
            nomoney.Start()

        Else
            sihir6.BackgroundImage = fireblast.BackgroundImage
        End If
    End Sub

    Private Sub armor1_Click(sender As Object, e As EventArgs) Handles armor1.Click
        Dim harga As Integer
        harga = 400

        If lblMONEY.Text < harga Then
            nomoney.Start()
        Else
            lblNILAIDEFF.Text = lblNILAIDEFF.Text + 4
            lblMONEY.Text = lblMONEY.Text - harga
        End If
    End Sub

    Private Sub armor2_Click(sender As Object, e As EventArgs) Handles armor2.Click
        Dim harga As Integer
        harga = 700

        If lblMONEY.Text < harga Then
            nomoney.Start()
        Else
            lblNILAIATT.Text = lblNILAIATT.Text + 2
            lblNILAIDEFF.Text = lblNILAIDEFF.Text + 5
            lblMONEY.Text = lblMONEY.Text - harga
        End If
    End Sub

    Private Sub armor3_Click(sender As Object, e As EventArgs) Handles armor3.Click
        Dim harga As Integer
        harga = 1300

        If lblMONEY.Text < harga Then
            nomoney.Start()
        Else
            lblNILAIATT.Text = lblNILAIATT.Text + 5
            lblNILAIDEFF.Text = lblNILAIDEFF.Text + 7
            lblMONEY.Text = lblMONEY.Text - harga
        End If
    End Sub

    Private Sub armor4_Click(sender As Object, e As EventArgs) Handles armor4.Click
        Dim harga As Integer
        harga = 1700

        If lblMONEY.Text < harga Then
            nomoney.Start()
        Else
            lblNILAIATT.Text = lblNILAIATT.Text + 6
            lblNILAIDEFF.Text = lblNILAIDEFF.Text + 9
            lblMONEY.Text = lblMONEY.Text - harga
        End If
    End Sub

    Private Sub armor5_Click(sender As Object, e As EventArgs) Handles armor5.Click
        Dim harga As Integer
        harga = 2200

        If lblMONEY.Text < harga Then
            nomoney.Start()
        Else
            lblNILAIATT.Text = lblNILAIATT.Text + 10
            lblNILAIDEFF.Text = lblNILAIDEFF.Text + 10
            lblMONEY.Text = lblMONEY.Text - harga
        End If
    End Sub

    Private Sub armor6_Click(sender As Object, e As EventArgs) Handles armor6.Click
        Dim harga As Integer
        harga = 100000

        If lblMONEY.Text < harga Then
            nomoney.Start()
        Else
            lblNILAIATT.Text = lblNILAIATT.Text + 5000
            lblNILAIDEFF.Text = lblNILAIDEFF.Text + 5000
            lblMONEY.Text = lblMONEY.Text - harga
        End If
    End Sub

    Private Sub Attack_Tick(sender As Object, e As EventArgs) Handles tmrAttack.Tick

        Dim damage, level As Integer
        Dim damagemonster As Integer
        damagemonster = 4 + (1 * lblNILAILEVEL.Text)
        level = lblNILAILEVEL.Text
        damage = lblNILAIATT.Text
        Player1.Hide()
        Player2.Show()
        Player2.Left = Player2.Left - 6
        Player2.Top = Player2.Top - 6
        If Player2.Left = 322 Then
            tmrPUKUL.Start()
            lblNILAIHPMON.Text = lblNILAIHPMON.Text - damage
            'pbMONSTER.Value = Int((pbMONSTER.Value - damage))
            lblNILAIHP.Text = lblNILAIHP.Text - (damagemonster - (damagemonster * lblNILAIDEFF.Text / 100))
            If lblNILAIHP.Text < 15 Then
                lblNILAIHP.ForeColor = Color.Red
            Else
                lblNILAIHP.ForeColor = Color.Black
            End If
            gbrEFEKPUKUL.Show()
            If lblNILAIHPMON.Text <= 0 Then
                lblHPMONSTER.Hide()
                lblNILAIHPMON.Hide()
                Monsterlevel1.Hide()
                Monsterlevel1.Hide()
                lblNILAILEVEL.Text = lblNILAILEVEL.Text + 1
                lblNILAIHP.Text = 50 + (5 + (1 + (lblNILAILEVEL.Text * lblNILAILEVEL.Text)))
                hpplayer = 50 + (5 + (1 + (lblNILAILEVEL.Text * lblNILAILEVEL.Text)))
                lblNILAIHP.ForeColor = Color.Black
                lblNILAIHPMON.Text = 25 + (20 + (10 * (level * level)))
                hpmonster = 25 + (20 + (10 * (level * level)))
                lblMONEY.Text = lblMONEY.Text + 600 + (50 * level)
                btnNEXT.Show()
                btnATTACK.Enabled = False
                lblBOSS.Hide()
                tmrBOSS.Enabled = False
            ElseIf lblNILAIHP.Text <= 0 Then
                tmrAttack.Stop()
                lblNILAIHP.Text = 0
                Dim a = MessageBox.Show("Game Over!!! You Lose..", "LOSE", MessageBoxButtons.OK, MessageBoxIcon.Error)
                If a = vbOK Then
                    Me.Close()
                End If
            End If
            tmrAttack.Enabled = False
            tmrBACK.Enabled = True
        End If

    End Sub

    Private Sub btnATTACK_Click(sender As Object, e As EventArgs) Handles btnATTACK.Click
        tmrAttack.Enabled = True
    End Sub

    Private Sub tmrBACK_Tick(sender As Object, e As EventArgs) Handles tmrBACK.Tick
        Player2.Left = Player2.Left + 6
        Player2.Top = Player2.Top + 6
        If Player2.Left = 352 Then
            tmrBACK.Enabled = False
            Player2.Hide()
            Player1.Show()
        ElseIf Player2.Left = 340 Then
            gbrEFEKPUKUL.Hide()
        End If
    End Sub

    Private Sub tmrPUKUL_Tick(sender As Object, e As EventArgs) Handles tmrPUKUL.Tick

    End Sub

    Private Sub btnNEXT_Click(sender As Object, e As EventArgs) Handles btnNEXT.Click
        btnATTACK.Enabled = True
        lblNILAIHPMON.Show()
        lblHPMONSTER.Show()
        btnNEXT.Hide()
        Monsterlevel1.Show()
        If lblNILAILEVEL.Text = 2 Then
            Monsterlevel1.BackgroundImage = Image.FromFile("monsterlvl2.png")
        ElseIf lblNILAILEVEL.Text = 3 Then
            Monsterlevel1.BackgroundImage = Image.FromFile("monsterlvl3.png")
        ElseIf lblNILAILEVEL.Text = 4 Then
            Monsterlevel1.BackgroundImage = Image.FromFile("monsterlvl4.png")
        ElseIf lblNILAILEVEL.Text = 5 Then
            Monsterlevel1.BackgroundImage = Image.FromFile("monsterlvl5.png")
        ElseIf lblNILAILEVEL.Text = 6 Then
            Monsterlevel1.BackgroundImage = Image.FromFile("monsterlvl6.png")
        ElseIf lblNILAILEVEL.Text = 7 Then
            Monsterlevel1.BackgroundImage = Image.FromFile("monsterlvl7.png")
        ElseIf lblNILAILEVEL.Text = 8 Then
            Monsterlevel1.BackgroundImage = Image.FromFile("monsterlvl8.png")
        ElseIf lblNILAILEVEL.Text = 9 Then
            Monsterlevel1.BackgroundImage = Image.FromFile("monsterlvl9.png")
        ElseIf lblNILAILEVEL.Text = 10 Then
            tmrBOSS.Enabled = True
            Monsterlevel1.BackgroundImage = Image.FromFile("monsterlvl10.png")
            lblNILAIHPMON.Text = lblNILAIHPMON.Text + 100
            lblBOSS.Show()

        ElseIf lblNILAILEVEL.Text = 11 Then
            Monsterlevel1.BackgroundImage = Image.FromFile("monsterlvl11.png")
        End If

    End Sub

    Private Sub senjata6_Click(sender As Object, e As EventArgs) Handles senjata6.Click
        Dim harga As Integer
        harga = 100000

        If lblMONEY.Text < harga Then
            nomoney.Start()

        Else
            lblNILAIATT.Text = lblNILAIATT.Text + 10000
            lblMONEY.Text = lblMONEY.Text - harga
        End If
    End Sub

    Private Sub Monsterlevel2_Click(sender As Object, e As EventArgs) Handles Monsterlevel1.Click

    End Sub

    Private Sub tmrBOSS_Tick(sender As Object, e As EventArgs) Handles tmrBOSS.Tick
        Select Case lblBOSS.ForeColor
            Case Color.Red
                lblBOSS.ForeColor = Color.Green
            Case Color.Green
                lblBOSS.ForeColor = Color.Gold
            Case Color.Gold
                lblBOSS.ForeColor = Color.Maroon
            Case Color.Maroon
                lblBOSS.ForeColor = Color.Purple
            Case Color.Purple
                lblBOSS.ForeColor = Color.Red
        End Select
    End Sub
End Class
