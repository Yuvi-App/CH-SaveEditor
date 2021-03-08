Imports System.IO

Public Class Form1
    Dim LoadedSaveFile As String
    Dim IsSaveLoaded As Boolean
    Dim FileBytes
    Private Sub btnLoadSaveFile_Click(sender As Object, e As EventArgs) Handles btnLoadSaveFile.Click
        OpenFileDialog1.Filter = "SAV files (*.SAV)|*.SAV"
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            LoadedSaveFile = OpenFileDialog1.FileName
            lblLoadedFile.Text = OpenFileDialog1.FileName
            FileBytes = System.IO.File.ReadAllBytes(LoadedSaveFile)
            ReadCurrentSaveData()
            IsSaveLoaded = True
            BtnWriteToSave.Enabled = True
            cbxCharacters.SelectedIndex = 0
        End If
    End Sub


    Private Sub BtnWriteToSave_Click(sender As Object, e As EventArgs) Handles BtnWriteToSave.Click
        'Due to the HashCheck at 0x2C have to open the load game section before writing changes
        MessageBox.Show("Please load Cross Hermit and click Load Game..." + Environment.NewLine + " Verify you see your save game in the list, then click Okay on this Prompt.." + Environment.NewLine + " This will save your changes to the save file, after which load the file in load game list, and save your game right away for the hash check to update.")
        'Write XP
        Dim result = WriteToSaveFileINT16(&H34, nudXPAmount.Value)


        'Save Current Set Stats to List
        Dim StatstoSaveList As New List(Of Int16)
        StatstoSaveList.Add(nudSTR.Value)
        StatstoSaveList.Add(nudAGI.Value)
        StatstoSaveList.Add(nudSEN.Value)
        StatstoSaveList.Add(nudVIR.Value)
        StatstoSaveList.Add(nudINT.Value)
        StatstoSaveList.Add(nudCON.Value)
        StatstoSaveList.Add(nudSPI.Value)

        'Write Stats
        If cbxCharacters.Text = "Cilice" Then
            Dim hexcount = 0
            For Each stat In StatstoSaveList
                WriteToSaveFileINT32(&H18850 + hexcount, stat)
                hexcount = hexcount + 8
            Next
        ElseIf cbxCharacters.Text = "Palmyra" Then
            Dim hexcount = 0
            For Each stat In StatstoSaveList
                WriteToSaveFileINT32(&H183B0 + hexcount, stat)
                hexcount = hexcount + 8
            Next
        ElseIf cbxCharacters.Text = "Irioso" Then
            Dim hexcount = 0
            For Each stat In StatstoSaveList
                WriteToSaveFileINT32(&H19F70 + hexcount, stat)
                hexcount = hexcount + 8
            Next
        End If


        If result = True Then
            MessageBox.Show("Changes saved Successfully")
        End If
    End Sub


    Public Function ReadCurrentSaveData()
        'Data is in LE
        'Get EXP 
        Dim XPBA = GetBytesFromSaveINT16(&H34, 4)
        Dim XPHex = BitConverter.ToString(XPBA)
        Console.WriteLine(XPHex.ToString)
        Dim XPValue As Int32 = BitConverter.ToInt32(XPBA, 0)
        nudXPAmount.Value = XPValue
    End Function

    Public Function ReadCharacterStats(ByVal StartPositon As Int32)
        'Get First Characters Stats
        Dim count = 0
        Dim HexCount = 0
        While Not count = 7
            Dim BA = GetBytesFromSaveINT32(StartPositon + HexCount, 2)
            Dim Hex = BitConverter.ToString(BA)
            Dim Value As Int16 = BitConverter.ToInt16(BA, 0)
            Console.WriteLine(Hex.ToString)

            If count = 0 Then
                nudSTR.Value = Value
            ElseIf count = 1 Then
                nudAGI.Value = Value
            ElseIf count = 2 Then
                nudSEN.Value = Value
            ElseIf count = 3 Then
                nudVIR.Value = Value
            ElseIf count = 4 Then
                nudINT.Value = Value
            ElseIf count = 5 Then
                nudCON.Value = Value
            ElseIf count = 6 Then
                nudSPI.Value = Value
            End If
            HexCount = HexCount + 8
            count = count + 1
        End While
    End Function
    Public Function GetBytesFromSaveINT16(ByVal StartPosition As Int16, ByVal BytesToRead As Int16)
        Dim data = New Byte(BytesToRead) {}

        Using reader As BinaryReader = New BinaryReader(New FileStream(LoadedSaveFile, FileMode.Open))
            reader.BaseStream.Seek(StartPosition, SeekOrigin.Begin)
            Return reader.ReadBytes(data.Length - 1)
        End Using
    End Function

    Public Function GetBytesFromSaveINT32(ByVal StartPosition As Int32, ByVal BytesToRead As Int16)
        Dim data = New Byte(BytesToRead) {}

        Using reader As BinaryReader = New BinaryReader(New FileStream(LoadedSaveFile, FileMode.Open))
            reader.BaseStream.Seek(StartPosition, SeekOrigin.Begin)
            Return reader.ReadBytes(data.Length - 1)
        End Using
    End Function

    Public Function WriteToSaveFileINT16(ByVal StartPosition As Int16, ByVal BytesToWrite As Int32)
        'Convert Int to BA then Write
        Dim WriteValue = BitConverter.GetBytes(BytesToWrite)
        Console.WriteLine(BitConverter.ToString(WriteValue))
        Console.WriteLine(BitConverter.ToInt32(WriteValue, 0))

        Using writer As BinaryWriter = New BinaryWriter(New FileStream(LoadedSaveFile, FileMode.OpenOrCreate))
            writer.BaseStream.Seek(StartPosition, SeekOrigin.Begin)
            Try
                writer.Write(WriteValue, 0, WriteValue.Length)
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Using
    End Function

    Public Function WriteToSaveFileINT32(ByVal StartPosition As Int32, ByVal BytesToWrite As Int16)
        'Convert Int to BA then Write
        Dim WriteValue = BitConverter.GetBytes(BytesToWrite)
        Console.WriteLine(BitConverter.ToString(WriteValue))
        Console.WriteLine(BitConverter.ToInt16(WriteValue, 0))

        Using writer As BinaryWriter = New BinaryWriter(New FileStream(LoadedSaveFile, FileMode.OpenOrCreate))
            writer.BaseStream.Seek(StartPosition, SeekOrigin.Begin)
            Try
                writer.Write(WriteValue, 0, WriteValue.Length)
                Return True
            Catch ex As Exception
                Return False
            End Try
        End Using
    End Function

    Private Sub cbxCharacters_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCharacters.SelectedIndexChanged
        If cbxCharacters.Text = "All Characters" Then
            nudSTR.Value = 0
            nudAGI.Value = 0
            nudCON.Value = 0
            nudINT.Value = 0
            nudSEN.Value = 0
            nudVIR.Value = 0
            nudSPI.Value = 0
        ElseIf cbxCharacters.Text = "Palmyra" Then
            ReadCharacterStats("&H183B0")
        ElseIf cbxCharacters.Text = "Cilice" Then
            ReadCharacterStats("&H18850")
        ElseIf cbxCharacters.Text = "Irioso" Then
            ReadCharacterStats("&H19F70")
        End If
    End Sub
End Class

