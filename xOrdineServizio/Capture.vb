Imports System
Imports System.Runtime.InteropServices

''' <summary>
''' Modulo per la gestione dei messaggi alla avicap32.dll
''' </summary>
Public Module capture

    ''Di seguito un elenco di costanti necessarie per dialogare con la DLL

    Public Const WM_CAP As Short = &H400S
    Public Const WM_USER As Long = &H400

    Public Const WM_CAP_DRIVER_CONNECT As Integer = WM_CAP + 10
    Public Const WM_CAP_DRIVER_DISCONNECT As Integer = WM_CAP + 11
    Public Const WM_CAP_EDIT_COPY As Integer = WM_CAP + 30
    Public Const WM_CAP_FILE_SAVEDIB As Long = WM_USER + 25
    Public Const WM_CAP_FILE_SAVEAS As Long = WM_USER + 23

    Public Const WM_CAP_SET_PREVIEW As Integer = WM_CAP + 50
    Public Const WM_CAP_SET_PREVIEWRATE As Integer = WM_CAP + 52
    Public Const WM_CAP_SET_SCALE As Integer = WM_CAP + 53
    Public Const WS_CHILD As Integer = &H40000000
    Public Const WS_VISIBLE As Integer = &H10000000
    Public Const SWP_NOMOVE As Short = &H2S
    Public Const SWP_NOSIZE As Short = 1
    Public Const SWP_NOZORDER As Short = &H4S
    Public Const HWND_BOTTOM As Short = 1

    'creiamo delle funzioni che
    'faranno da riferimento a routine esterne della nostra dll

    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
        (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, _
        <MarshalAs(UnmanagedType.AsAny)> ByVal lParam As Object) As Integer

    Public Declare Function SendMessageAsString Lib "user32" Alias "SendMessageA" _
                                                (ByVal hWnd As Long, _
                                                ByVal wMsg As Long, _
                                                ByVal wParam As Long, _
                                                ByVal lParam As String) As Long

    ''' <summary>
    ''' La funzione cambia la dimensione, posizione, 
    ''' e l'ordine della finestra e se in primo piano.
    ''' </summary>
    ''' <param name="hwnd">Handle della finestra</param>
    ''' <param name="hWndInsertAfter">Handle della finestra precede in ordine quella selezionata</param>
    ''' <param name="x">Coordinata X</param>
    ''' <param name="y">Coordinata Y</param>
    ''' <param name="cx">Dimensioni in larghezza</param>
    ''' <param name="cy">Dimensioni in Altezza</param>
    ''' <param name="wFlags">Specifica le opzioni aggiuntive</param>
    ''' <returns>Se ha avuto successo ritorna un valore non zero</returns>
    Public Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" (ByVal hwnd As Integer, _
        ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, _
        ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer

    ''' <summary>
    ''' Metodo che distrugge una finestra
    ''' </summary>
    ''' <param name="hndw">Handle della finestra</param>
    ''' <returns>True o false a seconda dell'esito dell'operazione</returns>
    Public Declare Function DestroyWindow Lib "user32" (ByVal hndw As Integer) As Boolean

    ''' <summary>
    ''' Metodo che dirige il flusso alla finestra di preview
    ''' </summary>
    ''' <param name="lpszWindowName"></param>
    ''' <param name="dwStyle"></param>
    ''' <param name="x"></param>
    ''' <param name="y"></param>
    ''' <param name="nWidth"></param>
    ''' <param name="nHeight"></param>
    ''' <param name="hWndParent"></param>
    ''' <param name="nID"></param>
    ''' <returns></returns>
    Public Declare Function capCreateCaptureWindowA Lib "avicap32.dll" _
        (ByVal lpszWindowName As String, ByVal dwStyle As Integer, _
        ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, _
        ByVal nHeight As Short, ByVal hWndParent As Integer, _
        ByVal nID As Integer) As Integer

    ''' <summary>
    ''' Funzione che ritorna l'esistenza o no di un driver
    ''' </summary>
    ''' <param name="wDriver">Numero del driver</param>
    ''' <param name="lpszName">Nome del driver</param>
    ''' <param name="cbName"></param>
    ''' <param name="lpszVer">Versione del driver</param>
    ''' <param name="cbVer"></param>
    ''' <returns>True se esiste un device, False se non esiste il device</returns>
    Public Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short, _
        ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String, _
        ByVal cbVer As Integer) As Boolean

End Module
