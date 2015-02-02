
Public Class frmMCERemote

    Dim HIDTranslationTable(,) As String = New String(,) {{"(None)", ""}, {"0", "27"}, {"1", "1E"}, {"2", "1F"}, {"3", "20"}, {"4", "21"}, {"5", "22"}, {"6", "23"}, {"7", "24"}, {"8", "25"}, {"9", "26"}, {"====================", ""}, _
                                                {"A", "04"}, {"B", "05"}, {"C", "06"}, {"D", "07"}, {"E", "08"}, {"F", "09"}, {"G", "0A"}, {"H", "0B"}, {"I", "0C"}, {"J", "0D"}, {"K", "0E"}, _
                                                {"L", "0F"}, {"M", "10"}, {"N", "11"}, {"O", "12"}, {"P", "13"}, {"Q", "14"}, {"R", "15"}, {"S", "16"}, {"T", "17"}, {"U", "18"}, {"V", "19"}, {"W", "1A"}, {"X", "1B"}, {"Y", "1C"}, {"Z", "1D"}, {"====================", ""}, _
                                                {"Return", "28"}, {"Escape", "29"}, {"Backspace", "2A"}, {"Tab", "2B"}, {"Space", "2C"}, {"====================", ""}, {"OemMinus", "2D"}, {"OemPlus", "2E"}, {"OemOpenBracket", "2F"}, {"OemCloseBracket", "30"}, _
                                                {"OemPipe", "31"}, {"OemSemiColon", "33"}, {"OemQuotes", "34"}, {"OemTilde", "35"}, {"OemComma", "36"}, {"OemPeriod", "37"}, {"OemQuestion", "38"}, _
                                                {"CapsLock", "39"}, {"====================", ""}, {"F1", "3A"}, {"F2", "3B"}, {"F3", "3C"}, {"F4", "3D"}, {"F5", "3E"}, {"F6", "3F"}, {"F7", "40"}, {"F8", "41"}, {"F9", "42"}, {"F10", "43"}, {"F11", "44"}, {"F12", "45"}, {"====================", ""}, _
                                                {"PrintScreen", "46"}, {"ScrollLock", "47"}, {"Break", "48"}, {"Insert", "49"}, {"Home", "4A"}, {"PageUp", "4B"}, {"PageDown", "4E"}, {"Delete", "4C"}, {"End", "4D"}, {"====================", ""}, {"Right", "4F"}, {"Left", "50"}, _
                                                {"Down", "51"}, {"Up", "52"}, {"====================", ""}, {"NumLock", "53"}, {"NumPad /", "54"}, {"NumPad *", "55"}, {"NumPad -", "56"}, {"NumPad +", "57"}, {"NumPad Enter", "58"}, {"NumPad 1", "59"}, {"NumPad 2", "5A"}, {"NumPad 3", "5B"}, {"NumPad 4", "5C"}, _
                                                {"NumPad 5", "5D"}, {"NumPad 6", "5E"}, {"NumPad 7", "5F"}, {"NumPad 8", "60"}, {"NumPad 9", "61"}, {"NumPad 0", "62"}, {"NumPad Del", "63"}, {"====================", ""}, {"App", "65"}, {"Keyboard Power", "66"}, {"Equals", "67"}, {"====================", ""}, {"F13", "68"}, {"F14", "69"}, {"F15", "6A"}, {"F16", "6B"}, _
                                                {"F17", "6C"}, {"F18", "6D"}, {"F19", "6E"}, {"F20", "6F"}, {"F21", "70"}, {"D22", "71"}, {"F23", "72"}, {"F24", "73"}, {"====================", ""}, {"Execute", "74"}, {"Help", "75"}, {"Menu", "76"}, {"Select", "77"}, {"Stop", "78"}, {"Again", "79"}, {"Undo", "7A"}, {"Cut", "7B"}, {"Copy", "7C"}, _
                                                {"Paste", "7D"}, {"Find", "7E"}, {"====================", ""}, {"Keyboard Mute", "7F"}, {"Keyboard VolumeUP", "80"}, {"Keyboard VolumeDown", "81"}, {"========== RAW INPUT MESSAGE", ""}, {"Shutdown", "8100"}, {"Sleep", "8200"}, {"Wake", "8300"}, {"========== WM_APPCOMMAND==", ""}, _
                                                {"Mute", "E200"}, {"Info", "0902"}, {"VolumeUp", "E900"}, {"VolumeDown", "EA00"}, {"ChannelUp", "9C00"}, {"ChannelDown", "9D00"}, {"FastForward", "B300"}, {"Rewind", "B400"}, {"Play", "B000"}, {"Record", "B200"}, {"Pause", "B100"}, {"Stop", "B700"}, _
                                                {"Next/Skip", "B500"}, {"Previous/Replay", "B600"}, {"Back", "2402"}, {"TV Guide", "8D00"}, {"Play/Pause", "CD00"}}

    Dim RemoteButtonTable(,,) As String = New String(,,) {{{"00", "0", ""}, {"01", "1", ""}, {"02", "2", ""}, {"03", "3", ""}, {"04", "4", ""}, {"05", "5", ""}, {"06", "6", ""}, {"07", "7", ""}, {"08", "8", ""}, {"09", "9", ""}, {"0A", "Clear", ""}, {"0B", "Enter", ""}, {"0C", "Power", ""}, {"0D", "Windows", ""}, {"0E", "Mute", ""}, {"0F", "Info/More", ""} _
                                                    , {"10", "Volume Up", ""}, {"11", "Volume Down", ""}, {"12", "Channel Up", ""}, {"13", "Channel Down", ""}, {"14", "Fast Forward", ""}, {"15", "Rewind", ""} _
                                                    , {"16", "Play", ""}, {"17", "Record", ""}, {"18", "Pause", ""}, {"19", "Stop", ""}, {"1A", "Next/Skip", ""}, {"1B", "Previous/Replay", ""}, {"1C", "Hash (#)", "Refresh on 360 Remote"}, {"1D", "Star (*)", "100 on 360 Remote"}, {"1E", "Up", ""}, {"1F", "Down", ""} _
                                                    , {"20", "Left", ""}, {"21", "Right", ""}, {"22", "OK", ""}, {"23", "Back", ""}, {"24", "DVD Menu", ""}, {"25", "Live TV, XBox Red (B)", ""}, {"26", "TV Guide, XBox Yellow (Y)", ""}, {"27", "Zoom/AR (Asrock, Mediagate)", ""}, {"28", "XBox Open/Close", "Only on XBox 360 universal remote"}, {"29", "Power On (Harmony)", "Harmony universal remote"} _
                                                    , {"2A", "Power Off (Harmony)", "Harmony universal remote"}, {"32", "Visualisation (HP)", ""}, {"33", "Slideshow (HP)", ""}, {"34", "Eject (HP)", ""}, {"3B", "Close App/Exit (HP)", ""}, {"46", "My TV (Harmony)", "Logitech Harmony One"}, {"47", "Music Library (Asrock, Harmony)", "Logitech Harmony One (MyMusic)"}, {"48", "Recorded TV", "Logitech Harmony One"}, {"49", "Picture Library (Asrock, Harmony)", "Logitech Harmony One (MyPictures)"}, {"4A", "Video Library  (Asrock, Harmony)", "Logitech Harmony One (MyVideos)"} _
                                                    , {"4B", "DVD Angle (Mediagate MG-IR02BK)", "Present on the Mediagate MG-IR02BK remote"}, {"4C", "DVD Audio (Mediagate MG-IR02BK)", "Present on the Mediagate MG-IR02BK remote"}, {"4D", "Subtitles (Mediagate MG-IR02BK)", "Present on the Mediagate MG-IR02BK remote"}, {"4E", "Print (HP)", "Labelled 'Print' on the HP remote"}, {"4F", "XBox Display", "Labelled 'Display' on the 360 universal remote"}, {"50", "Radio (Asrock, Harmony)", "Logitech Harmony One (MyRadio)"}, {"51", "XBox Title", "Labelled 'Title' on the 360 universal remote"}, {"5A", "Teletext", ""}, {"5B", "Red", ""}, {"5C", "Green", ""} _
                                                    , {"5D", "Yellow", ""}, {"5E", "Blue", ""}, {"64", "XBox 'X' Button", "Large 'X' button on the 360 universal remote"}, {"65", "Power (Microsoft Remote 1039)", ""}, {"66", "XBox Green (A)", "Green button labelled 'A' on the 360 universal remote"}, {"68", "XBox Blue (X)", "Blue button labelled 'X' on the 360 universal remote"}, {"6C", "Xbox Channel Up", "Channel up button on the 360 universal remote"}, {"6D", "XBox Channel Down", "Channel down button on the 360 universal remote"}, {"6E", "Play/Pause (HP HDX)", ""}}}



    Private Sub frmMCERemote_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.dgvMCE.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold)
            InitializeDatagrid()
            LoadMCEKey("FormLoad")
            FillKeyTableComboBox()
        Catch ex As Exception
            MsgBox("Error 01: " & ex.Message, vbExclamation)
        End Try



    End Sub




    Private Sub LoadMCEKey(ByVal LoadFrom As String)

        Try

            Dim sMCECode As String = ""


            If LoadFrom = "FormLoad" Then
                Dim Result As Object = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\HidIr\Remotes\745a17a0-74d3-11d0-b6fe-00a0c90f57da", "ReportMappingTable", Nothing)

                If Result Is Nothing Then

                    If MsgBox("No MCE keys found in the Registry. Do you want to load original MCE Keys?", vbYesNo + vbInformation) = vbNo Then
                        Exit Sub
                    Else
                        LoadFrom = "OriginalMCE"
                    End If


                Else
                    Dim bytes As Byte() = CType(Result, Byte())
                    sMCECode = BitConverter.ToString(bytes)
                    sMCECode = sMCECode.Replace("-", "")
                    Me.dgvMCE.Rows.Clear()
                    InitializeDatagrid()
                End If


            End If


            If LoadFrom = "Registry" Then
                Dim Result As Object = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\HidIr\Remotes\745a17a0-74d3-11d0-b6fe-00a0c90f57da", "ReportMappingTable", Nothing)

                If Result Is Nothing Then
                    MsgBox("No MCE keys found in the Registry.", vbInformation)
                    Exit Sub
                End If

                Dim bytes As Byte() = CType(Result, Byte())
                sMCECode = BitConverter.ToString(bytes)
                sMCECode = sMCECode.Replace("-", "")
                Me.dgvMCE.Rows.Clear()
                InitializeDatagrid()
            End If




            If LoadFrom = "Backup" Then
                Dim Result As Object = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\HidIr\Remotes\745a17a0-74d3-11d0-b6fe-00a0c90f57da", "ReportMappingTable.Backup", Nothing)

                If Result Is Nothing Then
                    MsgBox("No Backup MCE keys found.", vbInformation)
                    Exit Sub
                End If

                Dim bytes As Byte() = CType(Result, Byte())
                sMCECode = BitConverter.ToString(bytes)
                sMCECode = sMCECode.Replace("-", "")
                Me.dgvMCE.Rows.Clear()
                InitializeDatagrid()
            End If



            If LoadFrom = "OriginalMCE" Then
                Me.dgvMCE.Rows.Clear()
                InitializeDatagrid()
                sMCECode = "0100000004001E0200000004001F03000000040020040000000400210500000004002206000000040023070000000400240800000004002509000000040026000000000400270B0000000400280A0000000400291D0000000402251C0000000402201F0000000400511E0000000400522100000004004F20000000040050220000000400284E0000000108020F000000010902230000000124023B0000000104021600000001B0001800000001B1001700000001B2001400000001B3001500000001B4001A00000001B5001B00000001B6001900000001B7006E00000001CD001000000001E9001100000001EA000E00000001E20026000000018D0012000000019C0013000000019D000C000000038200290000000383002A000000038200"
            End If

            If LoadFrom = "SavedFile" Then
                Dim sFileName As String = My.Application.Info.DirectoryPath & "\MCERemote.txt"
                If FileIO.FileSystem.FileExists(sFileName) Then
                    Dim sFileReader = System.IO.File.OpenText(sFileName)
                    sMCECode = sFileReader.ReadLine
                    sFileReader.Close()
                    Me.dgvMCE.Rows.Clear()
                    InitializeDatagrid()
                Else
                    MsgBox("No Saved MCE Keys found.", vbInformation)
                    Exit Sub
                End If


            End If


            Dim MCECodeLength As Integer = sMCECode.Length
            Dim ButtonIDFromMCE As String = ""
            Dim sKeyModifier As String = ""
            Dim DGVRowCount As Integer = Me.dgvMCE.Rows.Count
            Dim ButtonIDFromDGV As String = ""
            Dim sKeyType As String = ""


            '16 00 00 00 04 03 13
            '16 - button id
            '00 00 00 - always same
            '04 - keytype
            '03 - modifier
            '13 - hid value of key


            For i = 0 To MCECodeLength - 14 'Each button code is 14 bits
                ButtonIDFromMCE = sMCECode.Substring(i, 2) 'first two bits are for button id

                For j = 0 To DGVRowCount - 1
                    ButtonIDFromDGV = Me.dgvMCE.Rows(j).Cells(0).Value 'get button codes from datagrid


                    If ButtonIDFromDGV = ButtonIDFromMCE Then

                        sKeyModifier = sMCECode.Substring(i + 11, 1)
                        sKeyType = sMCECode.Substring(i + 8, 2) 'bits 8 and 9

                        Dim sByteValue As String = sMCECode.Substring(i, 14)
                        Dim sTemp As String = ""
                        For k = 0 To (sByteValue.Length - 1) Step 2
                            sTemp = sTemp & "," & sByteValue.Substring(k, 2)
                        Next

                        Me.dgvMCE.Rows(j).Cells(9).Value = sTemp.Trim(",")

                        If sKeyType = "01" Then 'Multimedia key
                            Me.dgvMCE.Rows(j).Cells(10).Value = "Multimedia Key"
                            Dim sHID = GetKeyFromHIDTranslationTable(sMCECode.Substring(i + 10, 4))
                            If sHID <> "Unknown" Then
                                Me.dgvMCE.Rows(j).Cells(7).Value = sHID 'combo box value
                                Me.dgvMCE.Rows(j).Cells(8).Value = sHID
                                Me.dgvMCE.Rows(j).Cells(11).Value = sHID 'old value before edit
                                Me.dgvMCE.Rows(j).Cells(8).Style.BackColor = Color.White
                            End If

                        End If


                        If sKeyType = "03" Then ' Raw Input
                            Me.dgvMCE.Rows(j).Cells(10).Value = "Raw Input"
                            Dim sHID = GetKeyFromHIDTranslationTable(sMCECode.Substring(i + 10, 4))
                            If sHID <> "Unknown" Then
                                Me.dgvMCE.Rows(j).Cells(7).Value = sHID 'combo box value
                                Me.dgvMCE.Rows(j).Cells(8).Value = sHID
                                Me.dgvMCE.Rows(j).Cells(11).Value = sHID 'old value before edit
                                Me.dgvMCE.Rows(j).Cells(8).Style.BackColor = Color.White
                            End If

                            
                        End If


                        If sKeyType = "04" Then ' keypress
                            Me.dgvMCE.Rows(j).Cells(10).Value = "Keyboard Stroke"
                            Dim sHID = GetKeyFromHIDTranslationTable(sMCECode.Substring(i + 12, 2))
                            If sHID <> "Unknown" Then
                                Me.dgvMCE.Rows(j).Cells(7).Value = sHID 'combo box value
                            End If
                            Me.dgvMCE.Rows(j).Cells(8).Value = PopulateModifierKeys(j, sKeyModifier) & sHID
                            Me.dgvMCE.Rows(j).Cells(11).Value = Me.dgvMCE.Rows(j).Cells(8).Value 'old value before edit
                            Me.dgvMCE.Rows(j).Cells(8).Style.BackColor = Color.White
                        End If

                        Exit For

                    Else 'if buttonid not found
                        If j = DGVRowCount - 1 Then
                            Me.dgvMCE.Rows.Add(New DataGridViewRow)
                            Me.dgvMCE.Rows(j).Cells(0).Value = ButtonIDFromMCE
                            Me.dgvMCE.Rows(j).Cells(1).Value = "Unknown"
                            Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.BlankIcon
                            DGVRowCount += 1
                            j = j - 1
                            ' MsgBox("unknown button" & ButtonID)
                        End If


                    End If
                Next
                i = i + 13
            Next
        Catch ex As Exception
            MsgBox("Error 02: " & ex.Message, vbExclamation)
        End Try



    End Sub


    Private Sub InitializeDatagrid()
        Try
            Dim Bound1 As Integer = RemoteButtonTable.GetUpperBound(1)
            Me.dgvMCE.Rows.Add(Bound1)

            For j = 0 To Bound1
                Dim KeyCode As String = RemoteButtonTable(0, j, 0)
                Me.dgvMCE.Rows(j).Cells(0).Value = KeyCode
                Me.dgvMCE.Rows(j).Cells(1).Value = RemoteButtonTable(0, j, 1)
                LoadIcons(KeyCode, j)

            Next
        Catch ex As Exception
            MsgBox("Error 03: " & ex.Message, vbExclamation)
        End Try

    End Sub
    Private Sub LoadIcons(ByVal KeyCode As String, ByVal j As Integer)
        'icons courtesey www.touch-ir.com

        Try
            If KeyCode = "00" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources._0
            If KeyCode = "01" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources._1
            If KeyCode = "02" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources._2
            If KeyCode = "03" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources._3
            If KeyCode = "04" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources._4
            If KeyCode = "05" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources._5
            If KeyCode = "06" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources._6
            If KeyCode = "07" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources._7
            If KeyCode = "08" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources._8
            If KeyCode = "09" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources._9
            If KeyCode = "0A" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.Clear
            If KeyCode = "0B" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.Enter
            If KeyCode = "0C" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.Power
            If KeyCode = "0D" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.GSB
            If KeyCode = "0E" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.Mute
            If KeyCode = "0F" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.Info
            If KeyCode = "10" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.VolumeUp
            If KeyCode = "11" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.VolumeDown
            If KeyCode = "12" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.ChannelUP
            If KeyCode = "13" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.ChannelDown
            If KeyCode = "14" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.FF
            If KeyCode = "15" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.Rew
            If KeyCode = "16" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.Play
            If KeyCode = "17" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.Record
            If KeyCode = "18" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.Pause
            If KeyCode = "19" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources._Stop
            If KeyCode = "1A" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.Fwd
            If KeyCode = "1B" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.Bck
            If KeyCode = "1C" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.Sharp
            If KeyCode = "1D" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.Star
            If KeyCode = "1E" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.ArrowUp
            If KeyCode = "1F" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.ArrowDown
            If KeyCode = "20" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.ArrowLeft
            If KeyCode = "21" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.ArrowRight
            If KeyCode = "22" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.OK
            If KeyCode = "23" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.Back
            If KeyCode = "24" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.DVDMenu
            If KeyCode = "25" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.LiveTV
            If KeyCode = "26" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.Guide
            If KeyCode = "27" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.Zoom
            If KeyCode = "28" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.BlankIcon
            If KeyCode = "29" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources._On
            If KeyCode = "2A" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.Off
            If KeyCode = "32" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.BlankIcon
            If KeyCode = "33" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.BlankIcon
            If KeyCode = "34" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.BlankIcon
            If KeyCode = "3B" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.BlankIcon

            If KeyCode = "46" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.MyTV
            If KeyCode = "47" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.Music
            If KeyCode = "48" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.RecTV
            If KeyCode = "49" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.Picture
            If KeyCode = "4A" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.Video
            If KeyCode = "4B" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.BlankIcon
            If KeyCode = "4C" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.BlankIcon
            If KeyCode = "4D" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.BlankIcon
            If KeyCode = "4E" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.BlankIcon
            If KeyCode = "4F" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.BlankIcon
            If KeyCode = "50" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.BlankIcon
            If KeyCode = "51" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.BlankIcon
            If KeyCode = "5A" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.Teletext
            If KeyCode = "5B" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.ColorRed
            If KeyCode = "5C" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.ColorGreen
            If KeyCode = "5D" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.ColorYellow
            If KeyCode = "5E" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.ColorBlue
            If KeyCode = "64" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.XBox
            If KeyCode = "65" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.BlankIcon
            If KeyCode = "66" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.XBoxA
            If KeyCode = "68" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.XBoxX
            If KeyCode = "6C" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.BlankIcon
            If KeyCode = "6D" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.BlankIcon
            If KeyCode = "6E" Then Me.dgvMCE.Rows(j).Cells(2).Value = My.Resources.PlayPause
        Catch ex As Exception
            MsgBox("Error 04: " & ex.Message, vbExclamation)
        End Try

    End Sub

    Private Function PopulateModifierKeys(ByVal j As Integer, ByVal Modifier As String) As String

        Try
            Dim sModifier As String = ""

            Select Case Modifier
                Case "1" 'Ctrl
                    Me.dgvMCE.Rows(j).Cells(3).Value = True
                    sModifier = "Ctrl"
                Case "2" 'Shift
                    Me.dgvMCE.Rows(j).Cells(4).Value = True
                    sModifier = "Shift"
                Case "3" 'Control-Shift
                    Me.dgvMCE.Rows(j).Cells(3).Value = True 'Ctrl
                    Me.dgvMCE.Rows(j).Cells(4).Value = True 'Shift
                    sModifier = "Ctrl+Shift"
                Case "4" 'Alt
                    Me.dgvMCE.Rows(j).Cells(5).Value = True 'Alt
                    sModifier = "Alt"
                Case "5" 'Control-Alt
                    Me.dgvMCE.Rows(j).Cells(3).Value = True
                    Me.dgvMCE.Rows(j).Cells(5).Value = True
                    sModifier = "Ctrl+Alt"
                Case "6" 'Shift-Alt
                    Me.dgvMCE.Rows(j).Cells(4).Value = True
                    Me.dgvMCE.Rows(j).Cells(5).Value = True
                    sModifier = "Shift+Alt"
                Case "7" 'Control-Shift-Alt
                    Me.dgvMCE.Rows(j).Cells(3).Value = True
                    Me.dgvMCE.Rows(j).Cells(4).Value = True
                    Me.dgvMCE.Rows(j).Cells(5).Value = True
                    sModifier = "Ctrl+Shift+Alt"
                Case "8" 'Windows
                    Me.dgvMCE.Rows(j).Cells(6).Value = True
                    sModifier = "Win"
                Case "9" 'Control-Windows
                    Me.dgvMCE.Rows(j).Cells(3).Value = True
                    Me.dgvMCE.Rows(j).Cells(6).Value = True
                    sModifier = "Ctrl+Win"

                Case "A" 'Shift-Windows
                    Me.dgvMCE.Rows(j).Cells(4).Value = True
                    Me.dgvMCE.Rows(j).Cells(6).Value = True
                    sModifier = "Shift+Win"
                Case "B" 'Control-Shift-Windows
                    Me.dgvMCE.Rows(j).Cells(3).Value = True
                    Me.dgvMCE.Rows(j).Cells(4).Value = True
                    Me.dgvMCE.Rows(j).Cells(6).Value = True
                    sModifier = "Ctrl+Shift+Win"
                Case "C" 'Alt-Windows
                    Me.dgvMCE.Rows(j).Cells(5).Value = True
                    Me.dgvMCE.Rows(j).Cells(6).Value = True
                    sModifier = "Alt+Win"
                Case "D" 'Control-Alt-Windows
                    Me.dgvMCE.Rows(j).Cells(3).Value = True
                    Me.dgvMCE.Rows(j).Cells(5).Value = True
                    Me.dgvMCE.Rows(j).Cells(6).Value = True
                    sModifier = "Ctrl+Alt+Win"
                Case "E" 'Shift-Alt-Windows
                    Me.dgvMCE.Rows(j).Cells(4).Value = True
                    Me.dgvMCE.Rows(j).Cells(5).Value = True
                    Me.dgvMCE.Rows(j).Cells(6).Value = True
                    sModifier = "Shift+Alt+Win"
                Case "F" 'Control-Shift-Alt-Windows
                    Me.dgvMCE.Rows(j).Cells(3).Value = True
                    Me.dgvMCE.Rows(j).Cells(4).Value = True
                    Me.dgvMCE.Rows(j).Cells(5).Value = True
                    Me.dgvMCE.Rows(j).Cells(6).Value = True
                    sModifier = "Ctrl+Shift+Alt+Win"
            End Select
            If sModifier <> "" Then sModifier += "+"
            Return sModifier

        Catch ex As Exception
            MsgBox("Error 05: " & ex.Message, vbExclamation)
            Return ""
        End Try

    End Function


    Private Function GetKeyFromHIDTranslationTable(ByVal HID As String)


        Dim Bound0 As Integer = HIDTranslationTable.GetUpperBound(0)


        For i = 0 To Bound0
            Dim sHID As String = HIDTranslationTable(i, 1)

            If sHID = HID Then
                Return HIDTranslationTable(i, 0)

            End If

        Next

        Return "Unknown"


    End Function



    Private Sub FillKeyTableComboBox()

        Dim Bound0 As Integer = HIDTranslationTable.GetUpperBound(0)

        For i = 0 To Bound0
            Dim sHID As String = HIDTranslationTable(i, 0)

            Me.KeyTable.Items.Add(sHID)
        Next


    End Sub

    Private Sub btnLoadOriginalMCE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadOriginalMCE.Click
        LoadMCEKey("OriginalMCE")
    End Sub

    Private Sub btnLoadFromRegistry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadMCEFromRegistry.Click
        LoadMCEKey("Registry")
    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnILoadSavedMCE.Click
        LoadMCEKey("SavedFile")
    End Sub



    Private Sub btnLoadBackupMCE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadBackupMCE.Click
        LoadMCEKey("Backup")
    End Sub

    Private Sub btnRestoreBackupMCE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestoreBackupMCE.Click
        Try
            Dim Result As Object = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\HidIr\Remotes\745a17a0-74d3-11d0-b6fe-00a0c90f57da", "ReportMappingTable.Backup", Nothing)

            If Result Is Nothing Then
                MsgBox("No Backup MCE keys found.", vbInformation)
                Exit Sub
            Else
                My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\HidIr\Remotes\745a17a0-74d3-11d0-b6fe-00a0c90f57da", "ReportMappingTable", Result)
                Dim Backup = My.Computer.Registry.LocalMachine.OpenSubKey("SYSTEM\CurrentControlSet\Services\HidIr\Remotes\745a17a0-74d3-11d0-b6fe-00a0c90f57da", True)
                Backup.DeleteValue("ReportMappingTable.Backup")
                Backup.Close()
                MsgBox("MCE Keys Restored. Please restart the PC for the change to effect.", vbInformation)
            End If
        Catch ex As Exception
            MsgBox("Error 06: " & ex.Message, vbExclamation)
        End Try

    End Sub

    Private Sub btnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApply.Click
        Try
            Dim Result As Object = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\HidIr\Remotes\745a17a0-74d3-11d0-b6fe-00a0c90f57da", "ReportMappingTable", Nothing) 'Check if key already exists

            If Not (Result Is Nothing) Then
                If My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\HidIr\Remotes\745a17a0-74d3-11d0-b6fe-00a0c90f57da", "ReportMappingTable.Backup", Nothing) Is Nothing Then
                    My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\HidIr\Remotes\745a17a0-74d3-11d0-b6fe-00a0c90f57da", "ReportMappingTable.Backup", Result) 'take backup
                End If

            End If

            Dim parts As String() = BuildMCECode().Split(New Char() {","})
            Dim byteArray(parts.Length - 1) As Byte

            For i As Integer = 0 To parts.Length - 1
                byteArray(i) = Convert.ToByte(parts(i), 16)
            Next

            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\HidIr\Remotes\745a17a0-74d3-11d0-b6fe-00a0c90f57da", "ReportMappingTable", byteArray, Microsoft.Win32.RegistryValueKind.Binary) 'take backup

            For j = 0 To dgvMCE.RowCount - 1
                Me.dgvMCE.Rows(j).Cells(11).Value = Me.dgvMCE.Rows(j).Cells(8).Value 'update old value after save
                Me.dgvMCE.Rows(j).Cells(8).Style.BackColor = Color.White
            Next
            MsgBox("MCE keys added to registry. Please restart the PC for the change to effect.", vbInformation)
        Catch ex As Exception
            MsgBox("Error 07: " & ex.Message, vbExclamation)
        End Try

    End Sub


    Private Sub btnSaveMCEToFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSaveMCEToFile.Click
        Try
            Dim sFileName As String = My.Application.Info.DirectoryPath & "\MCERemote.txt"

            Dim sFileWriter As System.IO.StreamWriter
            sFileWriter = New System.IO.StreamWriter(sFileName)
            sFileWriter.WriteLine(BuildMCECode().Replace(",", ""))
            sFileWriter.Close()
            MsgBox("MCE Keys saved to file.", vbInformation)


        Catch ex As Exception
            MsgBox("Error 08: " & ex.Message, vbExclamation)
        End Try

    End Sub

    Private Function BuildMCECode() As String

        Dim MCEByteCode As String = ""
        Dim ButtonByteCode As String
        For i = 0 To Me.dgvMCE.Rows.Count - 1

            ButtonByteCode = Me.dgvMCE.Rows(i).Cells(9).Value
            If ButtonByteCode <> "" Then MCEByteCode += "," & ButtonByteCode
        Next
        Return MCEByteCode.Trim(",")

    End Function



    Private Sub DataGridView1_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMCE.CellContentClick
        If e.ColumnIndex > 2 And e.ColumnIndex < 8 Then
            Dim selectedkey As String = ""
            If Me.dgvMCE.Rows(e.RowIndex).Cells(7).Value Is Nothing Then
                selectedkey = ""
            Else
                selectedkey = Me.dgvMCE.Rows(e.RowIndex).Cells(7).Value.ToString
            End If

            If selectedkey <> "" And selectedkey <> "(None)" And (selectedkey.StartsWith("=") = False) Then
                Me.dgvMCE.Rows(e.RowIndex).Cells(8).Value = CalculateShortCutKey(e.RowIndex, selectedkey)
            Else
                Me.dgvMCE.Rows(e.RowIndex).Cells(8).Value = ""
            End If

            If Me.dgvMCE.Rows(e.RowIndex).Cells(8).Value <> Me.dgvMCE.Rows(e.RowIndex).Cells(11).Value Then
                Me.dgvMCE.Rows(e.RowIndex).Cells(8).Style.BackColor = Color.Yellow
            Else
                Me.dgvMCE.Rows(e.RowIndex).Cells(8).Style.BackColor = Color.White
            End If

        End If
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMCE.CellContentDoubleClick
        If e.ColumnIndex > 2 And e.ColumnIndex < 8 Then
            Dim selectedkey As String = ""
            If Me.dgvMCE.Rows(e.RowIndex).Cells(7).Value Is Nothing Then
                selectedkey = ""
            Else
                selectedkey = Me.dgvMCE.Rows(e.RowIndex).Cells(7).Value.ToString
            End If

            If selectedkey <> "" And selectedkey <> "(None)" And (selectedkey.StartsWith("=") = False) Then
                Me.dgvMCE.Rows(e.RowIndex).Cells(8).Value = CalculateShortCutKey(e.RowIndex, selectedkey)
            Else
                Me.dgvMCE.Rows(e.RowIndex).Cells(8).Value = ""
            End If

            If Me.dgvMCE.Rows(e.RowIndex).Cells(8).Value <> Me.dgvMCE.Rows(e.RowIndex).Cells(11).Value Then
                Me.dgvMCE.Rows(e.RowIndex).Cells(8).Style.BackColor = Color.Yellow
            Else
                Me.dgvMCE.Rows(e.RowIndex).Cells(8).Style.BackColor = Color.White
            End If
        End If
    End Sub



    Private Sub DataGridView1_EditingControlShowing(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgvMCE.EditingControlShowing

        Dim editingComboBox As ComboBox = e.Control
        AddHandler editingComboBox.SelectedIndexChanged, AddressOf GetSelectedKey
        AddHandler editingComboBox.DropDown, AddressOf combo_DropDown

    End Sub

    Private Sub combo_DropDown(ByVal sender As Object, ByVal e As EventArgs)
        DirectCast(sender, ComboBox).BackColor = Color.White
    End Sub


    Private Sub GetSelectedKey()


        Dim RowIndex As Integer
        RowIndex = dgvMCE.CurrentCell.RowIndex


        Dim selectedkey As String = ""
        If Me.dgvMCE.CurrentCell.GetEditedFormattedValue(RowIndex, DataGridViewDataErrorContexts.Commit) Is Nothing Then
            selectedkey = ""
        Else
            selectedkey = Me.dgvMCE.CurrentCell.GetEditedFormattedValue(RowIndex, DataGridViewDataErrorContexts.Commit)
        End If

        If selectedkey <> "" And selectedkey <> "(None)" And (selectedkey.StartsWith("=") = False) Then
            Me.dgvMCE.Rows(RowIndex).Cells(8).Value = CalculateShortCutKey(RowIndex, selectedkey)
        Else
            Me.dgvMCE.Rows(RowIndex).Cells(8).Value = ""
            Me.dgvMCE.Rows(RowIndex).Cells(9).Value = ""
            Me.dgvMCE.Rows(RowIndex).Cells(10).Value = ""
        End If

        If Me.dgvMCE.Rows(RowIndex).Cells(8).Value <> Me.dgvMCE.Rows(RowIndex).Cells(11).Value Then
            Me.dgvMCE.Rows(RowIndex).Cells(8).Style.BackColor = Color.Yellow
        Else
            Me.dgvMCE.Rows(RowIndex).Cells(8).Style.BackColor = Color.White
        End If

        
    End Sub


    Private Function CalculateShortCutKey(ByVal RowIndex As Integer, ByVal SelectedKey As String) As String


        Dim ButtonByte As String = Me.dgvMCE.Rows(RowIndex).Cells(0).Value
        Dim KeytypeByte As String = ""
        Dim ModifierByte As String = ""
        Dim KeyCodeByte As String = ""

        Me.dgvMCE.CommitEdit(DataGridViewDataErrorContexts.Commit)

        Select Case SelectedKey
            Case "Shutdown"
                KeytypeByte = "03"
                ModifierByte = "81"
                KeyCodeByte = "00"
            Case "Sleep"
                KeytypeByte = "03"
                ModifierByte = "82"
                KeyCodeByte = "00"
            Case "Wake"
                KeytypeByte = "03"
                ModifierByte = "83"
                KeyCodeByte = "00"
            Case "Mute"
                KeytypeByte = "01"
                ModifierByte = "E2"
                KeyCodeByte = "00"
            Case "Info"
                KeytypeByte = "01"
                ModifierByte = "09"
                KeyCodeByte = "02"
            Case "VolumeUp"
                KeytypeByte = "01"
                ModifierByte = "E9"
                KeyCodeByte = "00"
            Case "VolumeDown"
                KeytypeByte = "01"
                ModifierByte = "EA"
                KeyCodeByte = "00"
            Case "ChannelUp"
                KeytypeByte = "01"
                ModifierByte = "9C"
                KeyCodeByte = "00"
            Case "ChannelDown"
                KeytypeByte = "01"
                ModifierByte = "9D"
                KeyCodeByte = "00"
            Case "FastForward"
                KeytypeByte = "01"
                ModifierByte = "B3"
                KeyCodeByte = "00"
            Case "Rewind"
                KeytypeByte = "01"
                ModifierByte = "B4"
                KeyCodeByte = "00"
            Case "Play"
                KeytypeByte = "01"
                ModifierByte = "B0"
                KeyCodeByte = "00"
            Case "Record"
                KeytypeByte = "01"
                ModifierByte = "B2"
                KeyCodeByte = "00"
            Case "Pause"
                KeytypeByte = "01"
                ModifierByte = "B1"
                KeyCodeByte = "00"
            Case "Stop"
                KeytypeByte = "01"
                ModifierByte = "B7"
                KeyCodeByte = "00"
            Case "Next/Skip"
                KeytypeByte = "01"
                ModifierByte = "B5"
                KeyCodeByte = "00"
            Case "Previous/Replay"
                KeytypeByte = "01"
                ModifierByte = "B6"
                KeyCodeByte = "00"
            Case "Back"
                KeytypeByte = "01"
                ModifierByte = "24"
                KeyCodeByte = "02"
            Case "TV Guide"
                KeytypeByte = "01"
                ModifierByte = "8D"
                KeyCodeByte = "00"
            Case "Play/Pause"
                KeytypeByte = "01"
                ModifierByte = "CD"
                KeyCodeByte = "00"
            Case Else
                KeytypeByte = "04"

        End Select

        If KeytypeByte = "01" Then
            Me.dgvMCE.Rows(RowIndex).Cells(10).Value = "Multimedia Key"
        End If

        If KeytypeByte = "03" Then
            Me.dgvMCE.Rows(RowIndex).Cells(10).Value = "Raw Input"
        End If

        Dim modifier As String = ""
        If KeytypeByte = "04" Then



            If Me.dgvMCE.Rows(RowIndex).Cells(3).Value = False And Me.dgvMCE.Rows(RowIndex).Cells(4).Value = False And Me.dgvMCE.Rows(RowIndex).Cells(5).Value = False And Me.dgvMCE.Rows(RowIndex).Cells(6).Value = False Then
                ModifierByte = "00"
                modifier = ""
            End If

            If Me.dgvMCE.Rows(RowIndex).Cells(3).Value = True And Me.dgvMCE.Rows(RowIndex).Cells(4).Value = False And Me.dgvMCE.Rows(RowIndex).Cells(5).Value = False And Me.dgvMCE.Rows(RowIndex).Cells(6).Value = False Then
                ModifierByte = "01"
                modifier = "Ctrl"
            End If

            If Me.dgvMCE.Rows(RowIndex).Cells(3).Value = False And Me.dgvMCE.Rows(RowIndex).Cells(4).Value = True And Me.dgvMCE.Rows(RowIndex).Cells(5).Value = False And Me.dgvMCE.Rows(RowIndex).Cells(6).Value = False Then
                ModifierByte = "02"
                modifier = "Shift"
            End If

            If Me.dgvMCE.Rows(RowIndex).Cells(3).Value = True And Me.dgvMCE.Rows(RowIndex).Cells(4).Value = True And Me.dgvMCE.Rows(RowIndex).Cells(5).Value = False And Me.dgvMCE.Rows(RowIndex).Cells(6).Value = False Then
                ModifierByte = "03"
                modifier = "Ctrl+Shift"
            End If

            If Me.dgvMCE.Rows(RowIndex).Cells(3).Value = False And Me.dgvMCE.Rows(RowIndex).Cells(4).Value = False And Me.dgvMCE.Rows(RowIndex).Cells(5).Value = True And Me.dgvMCE.Rows(RowIndex).Cells(6).Value = False Then
                ModifierByte = "04"
                modifier = "Alt"
            End If

            If Me.dgvMCE.Rows(RowIndex).Cells(3).Value = True And Me.dgvMCE.Rows(RowIndex).Cells(4).Value = False And Me.dgvMCE.Rows(RowIndex).Cells(5).Value = True And Me.dgvMCE.Rows(RowIndex).Cells(6).Value = False Then
                ModifierByte = "05"
                modifier = "Ctrl+Alt"
            End If

            If Me.dgvMCE.Rows(RowIndex).Cells(3).Value = False And Me.dgvMCE.Rows(RowIndex).Cells(4).Value = True And Me.dgvMCE.Rows(RowIndex).Cells(5).Value = True And Me.dgvMCE.Rows(RowIndex).Cells(6).Value = False Then
                ModifierByte = "06"
                modifier = "Shift+Alt"
            End If

            If Me.dgvMCE.Rows(RowIndex).Cells(3).Value = True And Me.dgvMCE.Rows(RowIndex).Cells(4).Value = True And Me.dgvMCE.Rows(RowIndex).Cells(5).Value = True And Me.dgvMCE.Rows(RowIndex).Cells(6).Value = False Then
                ModifierByte = "07"
                modifier = "Ctrl+Shift+Alt"
            End If

            If Me.dgvMCE.Rows(RowIndex).Cells(3).Value = False And Me.dgvMCE.Rows(RowIndex).Cells(4).Value = False And Me.dgvMCE.Rows(RowIndex).Cells(5).Value = False And Me.dgvMCE.Rows(RowIndex).Cells(6).Value = True Then
                ModifierByte = "08"
                modifier = "Win"
            End If

            If Me.dgvMCE.Rows(RowIndex).Cells(3).Value = True And Me.dgvMCE.Rows(RowIndex).Cells(4).Value = False And Me.dgvMCE.Rows(RowIndex).Cells(5).Value = False And Me.dgvMCE.Rows(RowIndex).Cells(6).Value = True Then
                ModifierByte = "09"
                modifier = "Ctrl+Win"
            End If

            If Me.dgvMCE.Rows(RowIndex).Cells(3).Value = False And Me.dgvMCE.Rows(RowIndex).Cells(4).Value = True And Me.dgvMCE.Rows(RowIndex).Cells(5).Value = False And Me.dgvMCE.Rows(RowIndex).Cells(6).Value = True Then
                ModifierByte = "0A"
                modifier = "Shift+Win"
            End If

            If Me.dgvMCE.Rows(RowIndex).Cells(3).Value = True And Me.dgvMCE.Rows(RowIndex).Cells(4).Value = True And Me.dgvMCE.Rows(RowIndex).Cells(5).Value = False And Me.dgvMCE.Rows(RowIndex).Cells(6).Value = True Then
                ModifierByte = "0B"
                modifier = "Ctrl+Shift+Win"
            End If

            If Me.dgvMCE.Rows(RowIndex).Cells(3).Value = False And Me.dgvMCE.Rows(RowIndex).Cells(4).Value = False And Me.dgvMCE.Rows(RowIndex).Cells(5).Value = True And Me.dgvMCE.Rows(RowIndex).Cells(6).Value = True Then
                ModifierByte = "0C"
                modifier = "Alt+Win"
            End If

            If Me.dgvMCE.Rows(RowIndex).Cells(3).Value = True And Me.dgvMCE.Rows(RowIndex).Cells(4).Value = False And Me.dgvMCE.Rows(RowIndex).Cells(5).Value = True And Me.dgvMCE.Rows(RowIndex).Cells(6).Value = True Then
                ModifierByte = "0D"
                modifier = "Ctrl+Alt+Win"
            End If

            If Me.dgvMCE.Rows(RowIndex).Cells(3).Value = False And Me.dgvMCE.Rows(RowIndex).Cells(4).Value = True And Me.dgvMCE.Rows(RowIndex).Cells(5).Value = True And Me.dgvMCE.Rows(RowIndex).Cells(6).Value = True Then
                ModifierByte = "0E"
                modifier = "Shift+Alt+Win"
            End If

            If Me.dgvMCE.Rows(RowIndex).Cells(3).Value = True And Me.dgvMCE.Rows(RowIndex).Cells(4).Value = True And Me.dgvMCE.Rows(RowIndex).Cells(5).Value = True And Me.dgvMCE.Rows(RowIndex).Cells(6).Value = True Then
                ModifierByte = "0F"
                modifier = "Ctrl+Shift+Alt+Win"
            End If



            Dim getindex = Array.IndexOf(HIDTranslationTable.OfType(Of String)().ToArray(), Me.dgvMCE.Rows(RowIndex).Cells(7).GetEditedFormattedValue(RowIndex, DataGridViewDataErrorContexts.Commit))

            KeyCodeByte = HIDTranslationTable((getindex / 2), 1)

            Me.dgvMCE.Rows(RowIndex).Cells(10).Value = "Keyboard Stroke"

        End If



        Dim MCEByteCode As String = ButtonByte & ",00,00,00," & KeytypeByte & "," & ModifierByte & "," & KeyCodeByte
        '  Dim MCEByteCode As String = ButtonByte & "000000" & KeytypeByte & ModifierByte & KeyCodeByte

        Dim val As String = ""
        If Me.dgvMCE.Rows(RowIndex).Cells(7).GetEditedFormattedValue(RowIndex, DataGridViewDataErrorContexts.Commit) Is Nothing Then
            val = ""
        Else
            val = Me.dgvMCE.Rows(RowIndex).Cells(7).GetEditedFormattedValue(RowIndex, DataGridViewDataErrorContexts.Commit)
        End If

        If val = "" Or val = "(None)" Or val.StartsWith("=") Then
            MCEByteCode = ""
        End If

        Me.dgvMCE.Rows(RowIndex).Cells(9).Value = MCEByteCode

        Return (modifier + IIf(modifier = "", "", "+")) + SelectedKey
    End Function

   

    Private Sub btnOpenRegistryEditor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenRegistryEditor.Click
        Try
            My.Computer.Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Applets\Regedit", "LastKey", "HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\HidIr\Remotes\745a17a0-74d3-11d0-b6fe-00a0c90f57da")
            Process.Start("regedit")
        Catch ex As Exception

        End Try
    End Sub
End Class
