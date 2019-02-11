Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class AutomobileTest

    <TestMethod()> Public Sub DefaultAutomobileIsInitializedCorrectly()
        Dim myAuto = New Automobile()
    End Sub

End Class
