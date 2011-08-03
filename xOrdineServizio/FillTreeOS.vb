Imports System.XML.Serialization
Imports System.IO
Public Class FillTreeOS

    Dim db As New dbAlegatoADataSet
    Dim feaction As New ActionsLibrary
    Dim log As New XOrseLog

    Public Sub New()

    End Sub

    Public Function fillOS() As ArrayList
        'Popolamento nodiOS

        Dim QOrdineServizio As New dbAlegatoADataSetTableAdapters.QOrdineServizioTableAdapter
        QOrdineServizio.Fill(db.QOrdineServizio)
        Dim Binding As New System.Windows.Forms.BindingSource(db, db.QOrdineServizio.ToString)
        Dim bEsc As Boolean = True
        Dim os As New ArrayList

        'Dim drv As DataRowView = Binding.Current
        Dim drv As DataRowView
        Dim iteratore As IEnumerator = Binding.GetEnumerator()
        iteratore.Reset()
        bEsc = Not iteratore.MoveNext()
        Dim i = (-1)
        While (Not bEsc)
            drv = iteratore.Current
            Dim iId = feaction.valoreDrv(drv, "id")
            'Dim iId As Integer = feaction.leggiCampoDB(iteratore.Current, "id")
            log.xlogWriteEntry("Creazione nodi OrdineServizio (idOS=" & iId & ")", TraceEventType.Information)
            'aggiunge la riga corrente del db all'array degli ordini di servizio
            Dim ordineservizio As New NodoOS
            ordineservizio.OrdineServizio.NomeOS = feaction.valoreDrv(drv, "nome")
            ordineservizio.OrdineServizio.DataOS = feaction.valoreDrv(drv, "data")
            ordineservizio.OrdineServizio.Operatori = feaction.valoreDrv(drv, "operatori")
            'Inserisce le persone nell'oggetto os
            fillPersone(ordineservizio, iId)
            'inserisce gli interventi dell'oggetto os
            '           fillInterventi(ordineservizio, iId)

            os.Add(ordineservizio)
            bEsc = Not iteratore.MoveNext()
        End While
        Return os
    End Function

    Private Sub fillPersone(ByVal os As NodoOS, ByVal sValoreID As Integer)
        Dim qAllegatoA As New dbAlegatoADataSetTableAdapters.QAllegatoATableAdapter()

        qAllegatoA.FillByOS(db.QAllegatoA, sValoreID)

        'ciclo sul binding, recupero tutte le righe del DB e le inserisco nell'ARRAY
        Dim Binding As New BindingSource(db, db.QAllegatoA.ToString)
        Dim iCount As Integer = Binding.Count
        Dim bEsc As Boolean = True
        Dim drv As DataRowView

        Dim iteratore As IEnumerator = Binding.GetEnumerator()
        iteratore.Reset()
        bEsc = Not iteratore.MoveNext()
        Dim i = (-1)
        While (Not bEsc)
            drv = iteratore.Current
            Dim persona As New personaObj
            persona.Cognome = feaction.valoreDrv(drv, "cognome")
            persona.Nome = feaction.valoreDrv(drv, "nome")
            persona.DataNascita = feaction.valoreDrv(drv, "datanascita")
            persona.LuogoNascita = feaction.valoreDrv(drv, "luogonascita")

            os.nodo.arraySoggetti.Add(persona)
            bEsc = Not iteratore.MoveNext()
        End While
    End Sub
    Private Sub fillInterventi(ByVal os As NodoOS, ByVal sValoreID As Integer)
        Dim qInterventi As New dbAlegatoADataSetTableAdapters.QInterventiTableAdapter()

        qInterventi.FillByOS(db.QInterventi, sValoreID, paragrafoOS.interventi)

        'ciclo sul binding, recupero tutte le righe del DB e le inserisco nell'ARRAY
        Dim Binding As New BindingSource(db, db.QAllegatoA.ToString)
        Dim iCount As Integer = Binding.Count
        Dim bEsc As Boolean = True
        Dim drv As DataRowView

        Dim iteratore As IEnumerator = Binding.GetEnumerator()
        iteratore.Reset()
        bEsc = Not iteratore.MoveNext()
        Dim i = (-1)
        While (Not bEsc)
            drv = iteratore.Current
            os.nodo.arraySoggetti.Add(drv)
            bEsc = Not iteratore.MoveNext()
        End While
    End Sub
End Class

<Serializable()> _
Public Class NodoOS
    Public OrdineServizio As New ordineServizioObj
    Public nodo As New NodoInternoOS
End Class

<Serializable()> _
Public Class NodoInternoOS
    Public arrayInterventi As New ArrayList
    Public arraySoggetti As New ArrayList
End Class

<Serializable()> _
Public Class ordineServizioObj
    Private _nomeOS As String
    Private _operatori As String
    Private _data As DateTime

    Public Property NomeOS() As String
        Get
            Return _nomeOS
        End Get
        Set(ByVal Value As String)
            _nomeOS = Value
        End Set
    End Property

    Public Property DataOS() As String
        Get
            Return _data
        End Get
        Set(ByVal Value As String)
            _data = Value
        End Set
    End Property

    Public Property Operatori() As String
        Get
            Return _operatori
        End Get
        Set(ByVal Value As String)
            _operatori = Value
        End Set
    End Property
End Class

<Serializable()> _
Public Class personaObj
    Private _cognome As String
    Private _nome As String
    Private _datanascita As String
    Private _luogonascita As String
    Private _comuneresidenza As String
    Private _residenzavia As String
    Private _documento As String
    Private _precedentiSINO As Boolean
    Private _precedenti As Boolean


    Public Property Nome() As String
        Get
            Return _nome
        End Get
        Set(ByVal Value As String)
            _nome = Value
        End Set
    End Property
    Public Property Cognome() As String
        Get
            Return _cognome
        End Get
        Set(ByVal Value As String)
            _cognome = Value
        End Set
    End Property

    Public Property DataNascita() As String
        Get
            Return _datanascita
        End Get
        Set(ByVal Value As String)
            _datanascita = Value
        End Set
    End Property
    Public Property LuogoNascita() As String
        Get
            Return _luogonascita
        End Get
        Set(ByVal Value As String)
            _luogonascita = Value
        End Set
    End Property

    Public Property ComuneResidenza() As String
        Get
            Return _comuneresidenza
        End Get
        Set(ByVal Value As String)
            _comuneresidenza = Value
        End Set
    End Property
    Public Property Via() As String
        Get
            Return _residenzavia
        End Get
        Set(ByVal Value As String)
            _residenzavia = Value
        End Set
    End Property
    Public Property Documento() As String
        Get
            Return _documento
        End Get
        Set(ByVal Value As String)
            _documento = Value
        End Set
    End Property
    Public Property precedentiSINO() As Boolean
        Get
            Return _precedentiSINO
        End Get
        Set(ByVal Value As Boolean)
            _precedentiSINO = Value
        End Set
    End Property
    Public Property Precedenti() As String
        Get
            Return _precedenti
        End Get
        Set(ByVal Value As String)
            _precedenti = Value
        End Set
    End Property


End Class