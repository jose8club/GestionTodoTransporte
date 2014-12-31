Public Class SuggestTextBoxClass
    Inherits CustomTextBoxClass

    Private _Tabla As String
    Private _Columnas As String()

    Public Property Tabla As String
        Get
            Return _Tabla
        End Get
        Set(ByVal value As String)
            _Tabla = value
        End Set
    End Property

    Public Property Columnas As String()
        Get
            Return _Columnas
        End Get
        Set(ByVal value As String())
            _Columnas = value
        End Set
    End Property

    Dim Sugerencias As New AutoCompleteStringCollection()

    Sub New()
        Me.AutoCompleteMode = Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.AutoCompleteSource = Windows.Forms.AutoCompleteSource.CustomSource
        'getData(Sugerencias)
        Me.AutoCompleteCustomSource = Sugerencias
    End Sub

    Sub CargarSugerencias()
        Dim con As New Conexion
        con.CargarDatos(Sugerencias, Me._Tabla, Me._Columnas)
    End Sub

    
End Class
