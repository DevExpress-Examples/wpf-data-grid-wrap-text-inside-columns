Imports System.Windows
Imports System.Windows.Controls
Imports System.ComponentModel

Namespace WpfApplication1

    ''' <summary>
    ''' Interaction logic for Window1.xaml
    ''' </summary>
    Public Partial Class Window1
        Inherits Window

        Private coll As BindingList(Of ContactItem)

        Public Sub New()
            Me.InitializeComponent()
            coll = New BindingList(Of ContactItem)()
            Dim f1 As ContactItem = New ContactItem()
            f1.Name = "One Two Three Four Five Six Seven Eight Nine Ten Eleven Twelve"
            f1.Salary = 13
            f1.SalaryLimitation = 30
            f1.IsFired = False
            coll.Add(f1)
            f1 = New ContactItem()
            f1.Name = "One"
            f1.Salary = 23
            f1.SalaryLimitation = 50
            coll.Add(f1)
            f1 = New ContactItem()
            f1.Name = "One"
            f1.Salary = 23
            f1.SalaryLimitation = 50
            coll.Add(f1)
            f1 = New ContactItem()
            f1.Name = "Two"
            f1.Salary = 23
            f1.SalaryLimitation = 50
            coll.Add(f1)
            f1 = New ContactItem()
            f1.Name = "Two"
            f1.Salary = 23
            f1.SalaryLimitation = 50
            coll.Add(f1)
            f1 = New ContactItem()
            f1.Name = "Two"
            f1.Salary = 23
            f1.SalaryLimitation = 50
            coll.Add(f1)
            f1 = New ContactItem()
            f1.Name = "One"
            f1.Salary = 23
            f1.SalaryLimitation = 50
            coll.Add(f1)
            f1 = New ContactItem()
            f1.Name = "Two"
            f1.Salary = 23
            f1.SalaryLimitation = 50
            coll.Add(f1)
            f1 = New ContactItem()
            f1.Name = "One"
            f1.Salary = 23
            f1.SalaryLimitation = 50
            coll.Add(f1)
            f1 = New ContactItem()
            f1.Name = "Two"
            f1.Salary = 23
            f1.SalaryLimitation = 50
            coll.Add(f1)
            Me.grid.ItemsSource = coll
        End Sub
    End Class
End Namespace
