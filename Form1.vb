Option Strict On
Option Explicit On


Public Class Form1
    'Daniel Booth
    'IT102
    '2/20/16
    'Program #5

    'This program simulates a gambling game. After the user presses the "Roll Me" button, the program generates 
    'random numbers which are stored in a list. The elements of the list are used to define what picuture appears in which picture box
    'using a loop. The elements are also used as arguments in the "if" statement which compares the data.
    'The output is put into a variable that is used to calculate the total amount in the users bank. 

    'I originally used no arrays and a cases blocks to implement the pictures. There seemed like there had to be a more concise,
    'more efficient way to do it, so I started messing with lists and loops. I figured out 'for each' loops, then I figured out
    'how to use the simple 'for' loop when I put the PictureBoxes in an array as well. I put those two previous versions below.

    'There is also a deposit button which prompts the user for an amount of funds to put into the bank. Bank funds are 
    'calculated by adding the balance variable pulled from the label to the users deposit.

    Private Sub btnDeposit_Click(sender As Object, e As EventArgs) Handles btnDeposit.Click
        Dim deposit As Integer
        Dim balance As Integer
        balance = CInt(lblbankAccount.Text)
        deposit = CInt(InputBox("Enter your deposit", "Dice Game"))
        lblbankAccount.Text = CStr(balance + deposit)
    End Sub

    Private Sub btnroll_Click(sender As Object, e As EventArgs) Handles btnroll.Click
        Dim RandomNum As New Random
        Dim dices = New Integer() {RandomNum.Next(1, 7), RandomNum.Next(1, 7), RandomNum.Next(1, 7)}
        Dim Picboxes = New PictureBox() {Picbox1, PicBox2, PicBox3}
        Dim bet, bankroll, balance As Integer
        balance = CInt(lblbankAccount.Text)
        bet = CInt(txtbet.Text)

        For i As Integer = 0 To 2
            Picboxes(i).Image = Image.FromFile("DieSide" & dices(i).ToString & ".gif")
        Next

        If dices(0) = dices(1) And dices(0) = dices(2) Then
            bankroll = (bankroll + (bet * 3))
        ElseIf dices(0) = dices(1) Or dices(0) = dices(2) Or dices(1) = dices(2) Then
            bankroll = (bankroll + (bet * 2))
        Else
            bankroll = (bankroll - bet)
        End If

        balance = bankroll + balance
        lblbankAccount.Text = CStr(balance)
    End Sub
End Class

'For Each dice As Integer In dices
'    Picbox1.Image = Image.FromFile("DieSide" & dices(0) & ".gif")
'    PicBox2.Image = Image.FromFile("DieSide" & dices(1) & ".gif")
'    PicBox3.Image = Image.FromFile("DieSide" & dices(2) & ".gif")
'Next



Select Case dice1
    Case 1
        Picbox1.Image = Image.FromFile("DieSide1.gif")
    Case 2
        Picbox1.Image = Image.FromFile("DieSide2.gif")
    Case 3
        Picbox1.Image = Image.FromFile("DieSide3.gif")
    Case 4
        Picbox1.Image = Image.FromFile("DieSide4.gif")
    Case 5
        Picbox1.Image = Image.FromFile("DieSide5.gif")
    Case 6
        Picbox1.Image = Image.FromFile("DieSide6.gif")
End Select
Select Case dice2
    Case 1
        PicBox2.Image = Image.FromFile("DieSide1.gif")
    Case 2
        PicBox2.Image = Image.FromFile("DieSide2.gif")
    Case 3
        PicBox2.Image = Image.FromFile("DieSide3.gif")
    Case 4
        PicBox2.Image = Image.FromFile("DieSide4.gif")
    Case 5
        PicBox2.Image = Image.FromFile("DieSide5.gif")
    Case 6
        PicBox2.Image = Image.FromFile("DieSide6.gif")
End Select
Select Case dice3
    Case 1
        PicBox3.Image = Image.FromFile("DieSide1.gif")
    Case 2
        PicBox3.Image = Image.FromFile("DieSide2.gif")
    Case 3
        PicBox3.Image = Image.FromFile("DieSide3.gif")
    Case 4
        PicBox3.Image = Image.FromFile("DieSide4.gif")
    Case 5
        PicBox3.Image = Image.FromFile("DieSide5.gif")
    Case 6
        PicBox3.Image = Image.FromFile("DieSide6.gif")
End Select