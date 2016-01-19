Public Class Main
    Private intAtomicMass() As Decimal = {1.01, 4, 6.94, 9.01, 10.81, 12.01, 14.01, 16, 19, 20.18, 22.99, 24.31, 24.31, 26.98, 28.09, 30.97, 32.07, 35.45, 39.95, 39.1, 40.08, 44.96, 47.88, 50.94, 52, 54.94, 55.85, 58.93, 58.69, 63.55, 65.39, 69.72, 74.92, 78.96, 79.9, 83.8, 85.47, 87.62, 88.91, 91.22, 92.21, 95.94, 98, 101.07, 102.91, 106.42, 107.87, 112.41, 114.82, 118.71, 121.76, 127.6, 126.9, 131.29, 132.91, 137.33, 138.91, 140.12, 140.91, 144.24, 145, 150.36, 151.97, 157.25, 158.93, 162.5, 164.93, 167.26, 168.93, 173.04, 174.97, 178.49, 180.95, 183.84, 186.21, 190.23, 192.22, 195.08, 196.97, 200.59, 204.38, 207.2, 208.98, 209, 210, 222, 223, 226, 227, 232.04, 231.04, 238.03, 237, 244, 243, 247, 247, 251, 252, 257, 258, 259, 262, 261, 262, 263, 262, 265, 266, 271, 272, 277, 284, 289, 288, 291, 294, 294}
    Private strAtomsAbr() As String = {"H", "He", "Li", "Be", "B", "C", "N", "O", "F", "Ne", "Na", "Mg", "Al", "Si", "P", "S", "Cl", "Ar", "K", "Ca", "Sc", "Ti", "V", "Cr", "Mn", "Fe", "Co", "Ni", "Cu", "Zn", "Ga", "Ge", "As", "Se", "Br", "Kr", "Rb", "Sr", "Y", "Zr", "Nb", "Mo", "Tc", "Ru", "Rh", "Pd", "Ag", "Cd", "In", "Sn", "Sb", "Te", "I", "Xe", "Cs", "Ba", "La", "Ce", "Pr", "Nd", "Pm", "Sm", "Eu", "Gd", "Tb", "Dy", "Ho", "Er", "Tm", "Yb", "Lu", "Hf", "Ta", "W", "Re", "Os", "Ir", "Pt", "Au", "Hg", "Tl", "Pb", "Bi", "Po", "At", "Rn", "Fr", "Ra", "Ac", "Th", "Pa", "U", "Np", "Pu", "Am", "Cm", "Bk", "Cf", "Es", "Fm", "Md", "No", "Lr", "Rf", "Db", "Sg", "Bh", "Hs", "Mt", "Ds", "Rg", "Cn", "Ut", "Fl", "Up", "Lv", "Us", "Uo"}
    Private strAtomsFullName() As String
    Private strMolecules() As String = {}
    Const strLetters As String = "QWERTYUIOPASDFGHJKLZXCVBNM"
    Const strMolEnding As String = " +=@"

    Private Sub btnEquOK_Click(sender As Object, e As EventArgs) Handles btnEquOK.Click
        Dim strEquation As String = txtEquation.Text & "@"
        Dim chrChar As Char
        ReDim strMolecules(0)

        For intA As Integer = 1 To strEquation.Length()
            'Parser begins here
            chrChar = GetChar(strEquation, intA)
            If strLetters.Contains(chrChar.ToString()) Then
                'Look for the whole molecule, whether it's "H[2]" or "Al" or "NH[4]ClO[4]"
                Array.Resize(strMolecules, strMolecules.Length + 1)
                strMolecules(strMolecules.Length - 1) = chrChar
                Do Until strMolEnding.Contains(GetChar(strEquation, intA))
                    'Keep searching until a space, + or =
                    If intA < strEquation.Length Then
                        strMolecules(strMolecules.Length - 1) += GetChar(strEquation, intA + 1)
                    End If
                    intA += 1
                Loop
            End If
        Next
        'Update combo boxes
        For intA As Integer = 1 To strMolecules.Length - 1
            If strMolecules(intA).Substring(strMolecules(intA).Length - 2, 1) <> "]" Then
                'adds a [1] for help later
                strMolecules(intA) = strMolecules(intA).Substring(0, strMolecules(intA).Length - 1) & "[1]"
            End If
            cmbMolA.Items.Add(strMolecules(intA))
        Next
        For intA As Integer = 0 To cmbMolA.Items.Count - 1
            cmbMolB.Items.Add(cmbMolA.Items(intA).ToString())
        Next
        'Make the next section visible
        grpConversion.Visible = True
    End Sub

    Private Sub btnConvertOK_Click(sender As Object, e As EventArgs) Handles btnConvertOK.Click
        Dim blnBracket As Boolean = False
        Dim intMolCoef() As Integer = {0, 0}
        Dim decMolMass() As Decimal = {0, 0}
        Dim intMolSubscriptsA As Integer
        Dim intMolSubscriptsB As Integer
        Dim intUnitMode() As Integer = {0, 0}
        Dim decLeftOfMole As Decimal
        Dim decRightOfMole As Decimal
        Dim intTmp1 As Integer
        Dim intTmp As Integer
        Dim StrTmpElmnt As String
        Dim strMolA As String
        Dim strMolB As String
        Dim strElmntA() As String = {""}
        Dim strElmntB() As String = {""}
        Dim decStartingAmount As Decimal
        Dim decFinalnumber As Decimal
        Const strNumbers = "0123456789"
        strMolA = cmbMolA.Text
        strMolB = cmbMolB.Text
        'Find the coefficents of both molecules
        intTmp = txtEquation.Text.IndexOf(strMolA)
        'error checking
        If intTmp = -1 Then
            intTmp = txtEquation.Text.IndexOf(strMolA.Substring(0, strMolA.Length - 3))
        End If
        intTmp1 = intTmp
        If Not strNumbers.Contains(GetChar(txtEquation.Text, intTmp)) Then
            intMolCoef(0) = 1
        Else
            Do Until intTmp = 0 OrElse strMolEnding.Contains(GetChar(txtEquation.Text, intTmp))
                intMolCoef(0) += Val(GetChar(txtEquation.Text, intTmp)) * 10 ^ (intTmp1 - intTmp)
                intTmp -= 1
            Loop
        End If
        intTmp = txtEquation.Text.IndexOf(strMolB)
        'error checking
        If intTmp = -1 Then
            intTmp = txtEquation.Text.IndexOf(strMolB.Substring(0, strMolB.Length - 3))
        End If
        intTmp1 = intTmp
        If Not strNumbers.Contains(GetChar(txtEquation.Text, intTmp)) Then
            intMolCoef(1) = 1
        Else
            Do Until intTmp = 0 OrElse strMolEnding.Contains(GetChar(txtEquation.Text, intTmp))
                intMolCoef(1) += Val(GetChar(txtEquation.Text, intTmp)) * 10 ^ (intTmp1 - intTmp)
                intTmp -= 1
            Loop
        End If
        '0 = grams, 1=moles, 2=liters
        intUnitMode(0) = cmbUnitsA.SelectedIndex()
        intUnitMode(1) = cmbUnitsB.SelectedIndex()
        StrTmpElmnt = ""
        'Parse the element for its mass
        For intA As Integer = 1 To strMolA.Length
            If strLetters.Contains(GetChar(strMolA, intA)) Then
                strElmntA(strElmntA.Length - 1) = StrTmpElmnt
                StrTmpElmnt = ""
                StrTmpElmnt = GetChar(strMolA, intA)
            ElseIf strLetters.ToLower.Contains(GetChar(strMolA, intA)) Then
                StrTmpElmnt += GetChar(strMolA, intA)
            ElseIf GetChar(strMolA, intA) = "[" Then
                blnBracket = True
            ElseIf GetChar(strMolA, intA) = "]" Then
                decMolMass(0) += ConvToMass(StrTmpElmnt, intMolSubscriptsA)
                StrTmpElmnt = ""
                blnBracket = False
            ElseIf strNumbers.Contains(GetChar(strMolA, intA)) And blnBracket Then
                Integer.TryParse(GetChar(strMolA, intA), intMolSubscriptsA)
            End If
        Next
        StrTmpElmnt = ""
        'Element B
        For intA As Integer = 1 To strMolB.Length
            If strLetters.Contains(GetChar(strMolB, intA)) Then
                strElmntA(strElmntA.Length - 1) = StrTmpElmnt
                StrTmpElmnt = ""
                StrTmpElmnt = GetChar(strMolB, intA)
            ElseIf strLetters.ToLower.Contains(GetChar(strMolB, intA)) Then
                StrTmpElmnt += GetChar(strMolB, intA)
            ElseIf GetChar(strMolB, intA) = "[" Then
                blnBracket = True
            ElseIf GetChar(strMolB, intA) = "]" Then
                decMolMass(1) += ConvToMass(StrTmpElmnt, intMolSubscriptsB)
                StrTmpElmnt = ""
                blnBracket = False
            ElseIf strNumbers.Contains(GetChar(strMolB, intA)) And blnBracket Then
                Integer.TryParse(GetChar(strMolB, intA), intMolSubscriptsB)
            End If
        Next
        Decimal.TryParse(txtAmountA.Text, decStartingAmount)
        'Convert Molecule A to moles
        Select Case intUnitMode(0)
            Case 0
                decLeftOfMole = decStartingAmount / decMolMass(0)
            Case 1
                decLeftOfMole = decStartingAmount
            Case 2
                decLeftOfMole = decStartingAmount / 22.4
        End Select
        'Convert Molecule B to moles
        Select Case intUnitMode(1)
            Case 0
                decRightOfMole = decMolMass(1)
            Case 1
                decRightOfMole = 1
            Case 2
                decRightOfMole = 22.4
        End Select
        lblOutput.Visible = True
        decFinalnumber = decLeftOfMole * decRightOfMole * (intMolCoef(1) / intMolCoef(0))
        lblOutput.Text = Decimal.Round(decFinalnumber, 5) & " " & cmbUnitsB.Text & " of " & cmbMolB.Text
    End Sub
    Function ConvToMass(strElement As String, intSubscript As Integer)
        Dim intElementNumber As Integer
        intElementNumber = strAtomsAbr.ToList.IndexOf(strElement)
        Return intAtomicMass(intElementNumber) * intSubscript
    End Function

    Private Sub txtEquation_TextChanged(sender As Object, e As EventArgs) Handles txtEquation.TextChanged
        'Hide everything else
        grpConversion.Visible = False
        lblOutput.Visible = False
        'Clear combo items
        cmbMolA.Text = ""
        cmbMolB.Text = ""
        cmbMolA.Items.Clear()
        cmbMolB.Items.Clear()
        txtAmountA.Text = ""
        cmbUnitsA.SelectedIndex = -1
        cmbUnitsB.SelectedIndex = -1
    End Sub

    Private Sub Changed(sender As Object, e As EventArgs) Handles txtAmountA.TextChanged, cmbMolA.TextChanged, cmbMolB.TextChanged, cmbUnitsA.TextChanged, cmbUnitsB.TextChanged
        'Enable the second OK button if all fields are filled in
        If cmbMolA.SelectedIndex <> -1 And cmbUnitsB.SelectedIndex <> -1 And cmbUnitsA.SelectedIndex <> -1 And cmbUnitsB.SelectedIndex <> -1 And txtAmountA.Text <> "" Then
            btnConvertOK.Visible = True
        Else
            btnConvertOK.Visible = False
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        MsgBox("If a molecule that did not have a [1] at the end of it before has one now, it is because the program added that so that it knows that there should be a subscript of one there" & vbNewLine & "If anything does something it isn't supposed to, send a bug report to github.com/ordelore/'(remember to add this in)'")
    End Sub
End Class
