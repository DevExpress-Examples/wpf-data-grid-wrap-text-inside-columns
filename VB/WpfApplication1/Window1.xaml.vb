Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Imaging
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports DevExpress.Xpo
Imports System.ComponentModel
Imports DevExpress.Xpf.Grid
Imports System.Windows.Threading
Imports DevExpress.Xpf.Editors.Settings
Imports System.Threading
Imports DevExpress.Data
Imports System.Windows.Markup

Namespace WpfApplication1
	''' <summary>
	''' Interaction logic for Window1.xaml
	''' </summary>
	Partial Public Class Window1
		Inherits Window
		Private coll As BindingList(Of ContactItem)
		Public Sub New()
			InitializeComponent()
			coll = New BindingList(Of ContactItem)()
			Dim f1 As New ContactItem()
			f1.Name = "One Two Three Four Five Six Seven Eight Nine Ten Eleven Twelve"
			f1.Salary = 13
			f1.SalaryLimitation = 30
			f1.IsFired=False
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


			grid.ItemsSource = coll


		End Sub



	End Class

End Namespace
