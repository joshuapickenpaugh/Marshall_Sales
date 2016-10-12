Public Class CommissionCalculator

    Private _decSales As Decimal
    Private _bolOverTenYears As Boolean
    Private _bolTraveling As Boolean
    Const OVER_TEN_YEARS_BONUS As Decimal = 500.0
    Const TRAVELING_BONUS As Decimal = 700.0

    Public Property Sales As Decimal
        Get
            Return _decSales
        End Get
        Set(value As Decimal)
            If value > 0 Then
                _decSales = value
            Else
                _decSales = 0
            End If
        End Set
    End Property

    Public Property OverTenYears As Boolean
        Get
            Return _bolOverTenYears
        End Get
        Set(value As Boolean)
            If value = True Then
                _bolOverTenYears = True
            Else
                _bolOverTenYears = False
            End If
        End Set
    End Property

    Public Property Traveling As Boolean
        Get
            Return _bolTraveling
        End Get
        Set(value As Boolean)
            If value = True Then
                _bolTraveling = True
            Else
                _bolTraveling = False
            End If
        End Set
    End Property

    Public Sub New()

        _decSales = 0
        _bolOverTenYears = False
        _bolTraveling = False

    End Sub

    Public Function GetCommission() As Decimal

        Dim commission As Decimal

        If _decSales > 1 AndAlso _decSales < 100000.99 Then
            commission = _decSales * 0.02
        End If



        Return commission
    End Function

End Class
