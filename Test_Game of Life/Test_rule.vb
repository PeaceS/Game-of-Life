Imports System.Drawing
Imports System.Text
Imports Game_of_Life

<TestClass()>
Public Class Test_rule

    Private testContextInstance As TestContext

    '''<summary>
    '''Gets or sets the test context which provides
    '''information about and functionality for the current test run.
    '''</summary>
    Public Property TestContext() As TestContext
        Get
            Return testContextInstance
        End Get
        Set(ByVal value As TestContext)
            testContextInstance = value
        End Set
    End Property

#Region "Additional test attributes"
    '
    ' You can use the following additional attributes as you write your tests:
    '
    ' Use ClassInitialize to run code before running the first test in the class
    ' <ClassInitialize()> Public Shared Sub MyClassInitialize(ByVal testContext As TestContext)
    ' End Sub
    '
    ' Use ClassCleanup to run code after all tests in a class have run
    ' <ClassCleanup()> Public Shared Sub MyClassCleanup()
    ' End Sub
    '
    ' Use TestInitialize to run code before running each test
    ' <TestInitialize()> Public Sub MyTestInitialize()
    ' End Sub
    '
    ' Use TestCleanup to run code after each test has run
    ' <TestCleanup()> Public Sub MyTestCleanup()
    ' End Sub
    '
#End Region

    Dim theBoard As New Board()

    <TestMethod()>
    Public Sub LiveCellWithFewerThan2NeighboursWillDies()
        'Any live cell with fewer than two live neighbours dies, as if caused by under-population
        Dim pointTest As New Point(1, 1)
        Dim theCell As New Cell(pointTest)
        Assert.AreEqual(expected:=Cell.status.live, actual:=theBoard.checkStatus(theCell.location))
    End Sub

End Class
