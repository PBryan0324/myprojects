'NAME: CAR_PROJECT
'PURPOSE: CALCULATE AND DISPLAY MOST EFFICIENT VEHICLE. 
'PROGRAMMER: BRYAN PEREZ on 10-2-2021


Public Class frmMain
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtTotalCost2.TextChanged


    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        Dim totalMiles As Double 'hold total miles
        Dim totalSavings As Double 'hold total savings value

        Dim totalCostCar1 As Double 'Holds values from the txt conversion
        Dim totalCostCar2 As Double
        Dim dblCar1Mpg As Double
        Dim dblCar2Mpg As Double
        Dim dblCar1Cost As Double
        Dim dblCar2Cost As Double

        '--------------------------
        'Proper way to assign strings to variables to use in calculations
        Double.TryParse(txtTotalMiles.Text, totalMiles) 'assign the total miles from user to variable
        Double.TryParse(txtCar1mpg.Text, dblCar1Mpg)
        Double.TryParse(txtCar2mpg.Text, dblCar2Mpg)
        Double.TryParse(txtCar1Cost.Text, dblCar1Cost)
        Double.TryParse(txtCar1Cost.Text, dblCar2Cost)

        '-----------------------
        'Get total for first Car

        totalCostCar1 = (totalMiles / dblCar1Mpg) * dblCar1Cost 'formula for cost of using car 1

        txtTotalCost1.Text = totalCostCar1.ToString("c2") 'assign total cost of using car 1


        '------------------------
        'Get total for second car

        totalCostCar2 = (totalMiles / dblCar2Mpg) * dblCar2Cost

        txtTotalCost2.Text = totalCostCar2.ToString("C2")

        '-------------------------
        'grab difference between both cars

        If (totalCostCar1 < totalCostCar2) Then

            totalSavings = totalCostCar2 - totalCostCar1 'get difference then display
            txtTotalSavings.Text = totalSavings.ToString("0")
        Else
            totalSavings = totalCostCar1 - totalCostCar2 'get difference then display
            txtTotalSavings.Text = totalSavings.ToString("$0")


        End If

        '-----------------------
        'Create conditionals in order to rate the better car

        If totalCostCar1 < totalCostCar2 Then

            txtBestOption.Text = "Car 1"

        ElseIf totalCostCar1 = totalCostCar2 Then

            txtBestOption.Text = "Car 1"

        Else

            txtBestOption.Text = "Car 2"

        End If



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() 'Give user option to end Program.
    End Sub

    Private Sub txtTotalMiles_TextChanged(sender As Object, e As EventArgs) Handles txtTotalMiles.TextChanged

    End Sub
End Class
