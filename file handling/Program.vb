
Imports System

    Module Program
    Sub Main()
        GetEmployeeDetails()
    End Sub

    Private Sub GetEmployeeDetails()
        Console.WriteLine("enter the number of employee you wanat to enter")
        Dim n As Int16 = Console.ReadLine()
        For i = 0 To n - 1
            Try
                Console.Write("Enter Employee ID (integer): ")
                Dim employeeId As Integer = Integer.Parse(Console.ReadLine())

                Console.Write("Enter Employee Name (string): ")
                Dim name As String = Console.ReadLine()

                Console.Write("Enter Employee Department (string): ")
                Dim department As String = Console.ReadLine()

                Console.Write("Enter Employee Salary (double): ")
                Dim salary As Double = Double.Parse(Console.ReadLine())

                Console.WriteLine(vbCrLf & "Employee Details:")
                Console.WriteLine($"Employee ID: {employeeId}")
                Console.WriteLine($"Name: {name}")
                Console.WriteLine($"Department: {department}")
                Console.WriteLine($"Salary: {salary}")

            Catch ex As FormatException
                Console.WriteLine("Invalid input. Please enter a valid data type.")
                GetEmployeeDetails()
            End Try
        Next
    End Sub
End Module


