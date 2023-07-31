Public Class emplloyeeDetails
    Private empId As String
    Private empname As String
    Private empsalary As Double
    Private exp As Int16
    Private num As Int16
    Public Property employeeId As String
        Get
            Return empId
        End Get
        Set(value As String)
            empId = value
        End Set
    End Property
    Public Property employeename As String
        Get
            Return empname
        End Get
        Set(value As String)
            empId = value
        End Set
    End Property
    Public Property employesalary As Double
        Get
            Return empsalary
        End Get
        Set(value As Double)
            empsalary = value
        End Set
    End Property
    Public Property employeeexp As Int16
        Get
            Return exp
        End Get
        Set(value As Int16)
            exp = value
        End Set
    End Property
    Public Property number As Int16
        Get
            Return num
        End Get
        Set(value As Int16)
            num = value
        End Set
    End Property
End Class
Class invalidNullException
    Inherits Exception
    Sub New(ByVal msg As String)
        MyBase.New(msg)
    End Sub
End Class
