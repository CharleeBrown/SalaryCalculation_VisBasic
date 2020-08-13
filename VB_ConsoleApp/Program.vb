Imports System

Module Program
    Sub Main(args As String())

        ' Request and set name to variable.
        Console.WriteLine("What is your name?")
        Dim name As String
        name = Console.ReadLine()

        ' Request and set age to variable.
        Console.WriteLine("How old are you?")
        Dim age As Double
        age = Console.ReadLine()

        ' Print age and name. 
        Console.WriteLine("Your name is " + name + " and you are " + age.ToString() + " years old.")
        Console.ReadLine()

        ' Request hourly wage.
        Console.WriteLine("Enter your hourly wage to obtain annual salary.")
        Dim pay As Double
        pay = Console.ReadLine()

        ' Call Salary function to calculate salary.
        Call Salary(pay)
        Console.ReadLine()
    End Sub


    Sub Salary(perHour As Double)

        ' Calculate monthly income
        Dim Monthly As Double
        Monthly = (perHour * 80) * 2

        ' Calculate yearly income
        Dim Yearly As String
        Yearly = FormatCurrency(Monthly * 12)

        ' Format monthly income as currency
        Dim monthSal As String
        monthSal = FormatCurrency(Monthly)

        'Print incomes
        Console.WriteLine(Yearly.ToString() + "/Year")
        Console.WriteLine(monthSal + "/Month")
        Console.WriteLine(vbCrLf)
        Console.WriteLine("With Taxes taken that is ")

        ' Calculate income with taxes removed.
        Dim yearWithTax As Double
        yearWithTax = (Monthly * 0.7) * 12

        Yearly = FormatCurrency(yearWithTax)

        Dim monthWithTax As Double
        monthWithTax = Monthly * 0.7
        monthSal = FormatCurrency(monthWithTax)

        ' Print income with taxes removed.
        Console.WriteLine(Yearly.ToString() + "/Year - Taxes Removed")


        Console.WriteLine(monthSal.ToString() + "/month - Taxes Removed")




    End Sub
End Module
