Imports System
Imports System.Runtime.InteropServices
Imports System.Security.Cryptography
Imports System.Collections.Generic
Imports System.Text.RegularExpressions

Module Program
    Sub Main(args As String())
        Dim emplist As List(Of emplloyeeDetails) = New List(Of emplloyeeDetails)
        Console.WriteLine("ENTER THE NUMBER OF EMPLOYEES")
        Dim count As Int16
        count = getn()
        Dim empdetails() As emplloyeeDetails = New emplloyeeDetails(count) {}
        For i As Int16 = 0 To count - 1
            empdetails(i) = New emplloyeeDetails()
            Console.WriteLine("enter empid :")
            empdetails(i).employeeId = getid()
            Console.WriteLine("enter emp name :")
            empdetails(i).employeename = getname()
            Console.WriteLine("enter emp salary :")
            empdetails(i).employesalary = getsalary()
            Console.WriteLine("enter experience :")
            empdetails(i).employeeexp = getexp()
        Next
        For i As Int16 = 0 To count - 1
            If empdetails(i).employesalary > 100000 And empdetails(i).employesalary < 200000 Then
                If empdetails(i).employeeexp > 8 Then
                    Console.WriteLine("EMPLOYEE ID : {0},EMPLOYEE NAME :{1},EMPLOYEE SALARY :{2}, EMPLOYEE EXPERIENCE :{3}", empdetails(i).employeeId, empdetails(i).employeename, empdetails(i).employesalary, empdetails(i).employeeexp)
                Else
                    Console.WriteLine("EMPLOYEE MUST HAVE ABOVE 8 YEARS OF EXP")
                End If
            Else
                Console.WriteLine("EMPLOYEE SALARY MUST BE GREATER THAN 1 LAKH AND ABOVE 8 YEARS OF EXPERECE")
            End If
        Next
    End Sub
    Function checknull(str)
        If String.IsNullOrWhiteSpace(str) Then
            Throw New invalidNullException("INPUT SHOULD NOT BE NULL")
        End If
    End Function
    Function getn()
        Dim n As Int16
        Try
            n = Convert.ToInt16(Console.ReadLine())
            checknull(Convert.ToString(n))
            If n <= 0 Then
                Console.WriteLine("enter the valid positive number")
                getn()
            End If
        Catch ex As FormatException
            Console.WriteLine("enter the valid value")
            getn()
        End Try
        Return n
    End Function
    Function getid()
        Dim id As Int16
        Try
            id = Console.ReadLine()
        Catch ex As InvalidCastException
            Console.WriteLine("enter the valid id")
            getid()
        Catch ex As invalidNullException
            Console.WriteLine("enter the valid id")
            getid()
        End Try
        Return id
    End Function
    Function getname()
        Dim name As String
        Try
            name = Console.ReadLine()
            checknull(name)
            Dim pat As String = "^[a-zA-Z]+$"
            If Not Regex.Match(name, pat).Success Then
                Console.WriteLine("NAME SHOULS ONLY CONTAIN ALPHABETS")
                getname()
            End If
        Catch ex As invalidNullException
            Console.WriteLine("enter the valid name")
            getname()
        End Try
        Return name
    End Function
    Function getsalary()
        Dim sal As Int64
        Try
            sal = Console.ReadLine()
            checknull(Convert.ToString(sal))
            If sal < 0 Then
                Console.WriteLine("enter the valid positive number")
                getsalary()
            End If
        Catch ex As InvalidCastException
            Console.WriteLine("enter the valid value")
            getsalary()
        Catch ex As invalidNullException
            Console.WriteLine("enter the valid value")
            getsalary()
        End Try
        Return sal
    End Function
    Function getexp()
        Dim exp As Int16
        Try
            exp = Console.ReadLine()
            checknull(Convert.ToString(exp))
        Catch ex As InvalidCastException
            Console.WriteLine("enter the valid salary")
            getsalary()
        Catch ex As invalidNullException
            Console.WriteLine("enter the valid experence")
            getsalary()
        End Try
        Return exp
    End Function
End Module
