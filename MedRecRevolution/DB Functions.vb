Imports System.Data.OleDb

Module DB_Functions
    Public Sub Add_to_Appt_Struct()

    End Sub
    Public Sub Insert_into_ApptTable(ByVal fname As String, ByVal lname As String, ByVal group As Integer, ByVal mnum As String, ByVal language As String, ByVal sday As String,
                                     ByVal rday As String, ByVal rtime As String, file_Path As String, clinic As String, MRN As String, Shift As String)

        Dim stopWatch As New Stopwatch()
        stopWatch.Start()
        Try
            Dim con As New OleDbConnection
            Dim cmdInsert As New OleDbCommand

            Dim strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & file_Path & ";Jet OLEDB:Database Password=" & FrmPassword.txtDBPassword.Text

            con.ConnectionString = strConnectionString
            con.Open()

            cmdInsert.CommandText = "INSERT INTO Appts (FName, LName, Grp, mnum, lang, sday, rday1, rtime1, clinic, MRN, shift ) VALUES (@fname,@lname,@group,@mnum,@language,@sday,@rday,@rtime,@clinic, @MRN, @shift)"
            cmdInsert.Parameters.Add("@fname", OleDbType.VarChar).Value = fname
            cmdInsert.Parameters.Add("@lname", OleDbType.VarChar).Value = lname
            cmdInsert.Parameters.Add("@group", OleDbType.VarChar).Value = group
            cmdInsert.Parameters.Add("@mnum", OleDbType.VarChar).Value = mnum
            cmdInsert.Parameters.Add("@language", OleDbType.VarChar).Value = language
            cmdInsert.Parameters.Add("@sday", OleDbType.VarChar).Value = sday
            cmdInsert.Parameters.Add("@rday", OleDbType.VarChar).Value = rday
            cmdInsert.Parameters.Add("@rtime", OleDbType.VarChar).Value = rtime
            cmdInsert.Parameters.Add("@clinic", OleDbType.VarChar).Value = clinic
            cmdInsert.Parameters.Add("@MRN", OleDbType.VarChar).Value = MRN
            cmdInsert.Parameters.Add("@shift", OleDbType.VarChar).Value = Shift

            cmdInsert.CommandType = CommandType.Text
            cmdInsert.Connection = con
            cmdInsert.ExecuteNonQuery()
            cmdInsert.Dispose()
            con.Close()
            con = Nothing

        Catch ex As Exception
            WriteToLog("Insert_into_ApptTable - Exception Follows:" & ex.Message)
            'MessageBox.Show("Insert_into_ApptTable - Exception Follows:" & ex.Message)
        End Try

        stopWatch.Stop()
        ' Get the elapsed time as a TimeSpan value.
        Dim ts As TimeSpan = stopWatch.Elapsed

        ' Format and display the TimeSpan value.
        Dim elapsedTime As String = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds)
        ' MsgBox("SQL Insert Time " + elapsedTime)


    End Sub

    Public Sub UpdateAppt(ID As Integer, fname As String, lname As String, group As Integer, mnum As String, language As String, sday As String,
                          rday As String, rtime As String, lasttxt As String, txtnum As Integer, clinic As String, MRN As String, Shift As String)

        Dim stopWatch As New Stopwatch()
        stopWatch.Start()
        Try

            Dim con As New OleDbConnection
            Dim cmdUpdate As New OleDbCommand
            Dim file_Path As String = Trim(FrmPassword.txtDBPath.Text)
            Dim strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & file_Path & ";Jet OLEDB:Database Password=" & FrmPassword.txtDBPassword.Text


            con.ConnectionString = strConnectionString
            con.Open()

            cmdUpdate.CommandText = "UPDATE Appts SET " &
                "Fname = @fname," &
                " Lname = @lname," &
                " Grp = @group," &
                " mnum = @mnum," &
                " lang = @language," &
                " sday = @sday," &
                " rday1 = @rday," &
                " rtime1 = @rtime," &
                " lasttxt = @lasttxt," &
                " numtxts = @txtnum," &
                " clinic = @clinic," &
                " MRN = @MRN, " &
                 "shift = @shift " &
                " WHERE ID = @ID;"
            cmdUpdate.Parameters.Add("@fname", OleDbType.VarChar).Value = fname
            cmdUpdate.Parameters.Add("@lname", OleDbType.VarChar).Value = lname
            cmdUpdate.Parameters.Add("@group", OleDbType.VarChar).Value = group
            cmdUpdate.Parameters.Add("@mnum", OleDbType.VarChar).Value = mnum
            cmdUpdate.Parameters.Add("@language", OleDbType.VarChar).Value = language
            cmdUpdate.Parameters.Add("@sday", OleDbType.VarChar).Value = sday
            cmdUpdate.Parameters.Add("@rday", OleDbType.VarChar).Value = rday
            cmdUpdate.Parameters.Add("@rtime", OleDbType.VarChar).Value = rtime
            cmdUpdate.Parameters.Add("@lasttxt", OleDbType.VarChar).Value = lasttxt
            cmdUpdate.Parameters.Add("@txtnum", OleDbType.VarChar).Value = txtnum
            cmdUpdate.Parameters.Add("@clinic", OleDbType.VarChar).Value = clinic
            cmdUpdate.Parameters.Add("@MRN", OleDbType.VarChar).Value = MRN
            cmdUpdate.Parameters.Add("@shift", OleDbType.VarChar).Value = Shift

            cmdUpdate.Parameters.Add("@ID", OleDbType.VarChar).Value = ID


            cmdUpdate.CommandType = CommandType.Text
            cmdUpdate.Connection = con
            cmdUpdate.ExecuteNonQuery()
            cmdUpdate.Dispose()
            con.Close()
            con = Nothing

        Catch ex As Exception
            WriteToLog("UpdateAppt - Exception Follows: " & ex.Message)
            ' MessageBox.Show("UpdateAppt - Exception Follows:" & ex.Message)
        End Try

        stopWatch.Stop()
        ' Get the elapsed time as a TimeSpan value.
        Dim ts As TimeSpan = stopWatch.Elapsed

        ' Format and display the TimeSpan value.
        Dim elapsedTime As String = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds)
        ' MsgBox("SQL Update Time " + elapsedTime)

    End Sub

    Public Sub DeleteReminder(ID As Integer)

        Dim stopWatch As New Stopwatch()
        stopWatch.Start()

        Try
            Dim con As New OleDbConnection
            Dim cmdDelete As New OleDbCommand
            Dim strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & FrmPassword.txtDBPath.Text & ";Jet OLEDB:Database Password=Haqcswc!"

            con.ConnectionString = strConnectionString
            con.Open()

            cmdDelete.CommandText = "DELETE FROM Appts WHERE ID = " & ID & ";"

            'MsgBox(cmdUpdate.CommandText)
            cmdDelete.CommandType = CommandType.Text
            cmdDelete.Connection = con
            cmdDelete.ExecuteNonQuery()
            cmdDelete.Dispose()
            con.Close()

        Catch ex As Exception
            WriteToLog("Delete Reminder - Exception Follows:" & ex.Message)
            ' MessageBox.Show("Delete Reminder - Exception Follows:" & ex.Message)
        End Try

        stopWatch.Stop()
        ' Get the elapsed time as a TimeSpan value.
        Dim ts As TimeSpan = stopWatch.Elapsed

        ' Format and display the TimeSpan value.
        Dim elapsedTime As String = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds)
        ' MsgBox("SQL Delete Time " + elapsedTime)

    End Sub



    Public Sub InsertInOutcomesTable(id As String, language As String, fname As String, lname As String,
                                   grp As Integer, mnum As String,
                                   sday As String, rday1 As String,
                                   rtime1 As String, last_txt As String,
                                   num_txts As String, actual_rec_date As String,
                                   happened As Integer, phone_prob As String,
                                   num_meds_brought As String,
                                   num_useful_pics As String, total_pics As String, comment As String,
                                   all_claim As String, useful_list As String, clinic As String, totalList As String, MRN As String, Shift As String)

        Dim stopWatch As New Stopwatch()
        stopWatch.Start()
        Try
            Dim con As New OleDbConnection
            Dim cmdInsert As New OleDbCommand
            Dim str As String = ""

            Dim strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & FrmPassword.txtDBPath.Text & ";Jet OLEDB:Database Password=" & FrmPassword.txtDBPassword.Text

            con.ConnectionString = strConnectionString
            con.Open()

            str = "INSERT INTO Outcomes (id, lang,       fname,  lname,  grp,  mnum,  sday,  rday1,  rtime1,  last_txt,  num_txts,  actual_rec_date,  happened,  phone_prob,  num_meds_brought, num_useful_pics,  total_pics,  comment, all_claim,  useful_list,  clinic, total_list, MRN, shift) VALUES (" &
                                       "@id, @language, @fname, @lname, @grp, @mnum, @sday, @rday1, @rtime1, @last_txt, @num_txts, @actual_rec_date, @happened, @phone_prob, @num_meds_brought,@num_useful_pics, @total_pics, @comment, @allclaim,  @usefulList, @clinic, @totallist, @MRN, @shift);"

            cmdInsert.CommandText = str
            cmdInsert.Parameters.Add("@id", OleDbType.VarChar).Value = id
            cmdInsert.Parameters.Add("@language", OleDbType.VarChar).Value = language
            cmdInsert.Parameters.Add("@fname", OleDbType.VarChar).Value = fname
            cmdInsert.Parameters.Add("@lname", OleDbType.VarChar).Value = lname
            cmdInsert.Parameters.Add("@grp", OleDbType.VarChar).Value = grp
            cmdInsert.Parameters.Add("@mnum", OleDbType.VarChar).Value = mnum
            cmdInsert.Parameters.Add("@sday", OleDbType.VarChar).Value = sday
            cmdInsert.Parameters.Add("@rday1", OleDbType.VarChar).Value = rday1
            cmdInsert.Parameters.Add("@rtime1", OleDbType.VarChar).Value = rtime1
            cmdInsert.Parameters.Add("@last_txt", OleDbType.VarChar).Value = last_txt
            cmdInsert.Parameters.Add("@num_txts", OleDbType.VarChar).Value = num_txts
            cmdInsert.Parameters.Add("@actual_rec_date", OleDbType.VarChar).Value = actual_rec_date
            cmdInsert.Parameters.Add("@happened", OleDbType.VarChar).Value = happened
            cmdInsert.Parameters.Add("@phone_prob", OleDbType.VarChar).Value = phone_prob
            cmdInsert.Parameters.Add("@num_meds_brought", OleDbType.VarChar).Value = num_meds_brought
            cmdInsert.Parameters.Add("@num_useful_pics", OleDbType.VarChar).Value = num_useful_pics
            cmdInsert.Parameters.Add("@total_pics", OleDbType.VarChar).Value = total_pics
            cmdInsert.Parameters.Add("@comment", OleDbType.VarChar).Value = comment
            cmdInsert.Parameters.Add("@allclaim", OleDbType.VarChar).Value = all_claim
            cmdInsert.Parameters.Add("@usefulList", OleDbType.VarChar).Value = useful_list
            cmdInsert.Parameters.Add("@clinic", OleDbType.VarChar).Value = clinic
            cmdInsert.Parameters.Add("@totallist", OleDbType.VarChar).Value = totalList
            cmdInsert.Parameters.Add("@MRN", OleDbType.VarChar).Value = MRN
            cmdInsert.Parameters.Add("@shift", OleDbType.VarChar).Value = Shift

            cmdInsert.CommandType = CommandType.Text
            cmdInsert.Connection = con
            cmdInsert.ExecuteNonQuery()
            cmdInsert.Dispose()
            con.Close()
            con = Nothing

        Catch ex As Exception
            'MessageBox.Show("InsertOutcomesTable - Exception Follows:" & ex.Message)
            WriteToLog("InsertOutcomesTable - Exception Follows:" & ex.Message)
        End Try

        stopWatch.Stop()
        ' Get the elapsed time as a TimeSpan value.
        Dim ts As TimeSpan = stopWatch.Elapsed

        ' Format and display the TimeSpan value.
        Dim elapsedTime As String = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds)
        ' MsgBox("SQL Insert Time " + elapsedTime)


    End Sub


    Public Sub UpdateOutcome(ID As String, sday As String, rday As String, happened As Integer, techProb As Integer, medsBrought As Integer,
                             picsBrought As Integer, totalPics As Integer, comment As String, allClaim As Integer, useFulList As Integer, totallist As Integer, MRN As String, Shift As String)

        Dim stopWatch As New Stopwatch()
        stopWatch.Start()
        Try

            Dim con As New OleDbConnection
            Dim cmdUpdate As New OleDbCommand
            Dim file_Path As String = Trim(FrmPassword.txtDBPath.Text)
            Dim strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & file_Path & ";Jet OLEDB:Database Password=" & FrmPassword.txtDBPassword.Text


            con.ConnectionString = strConnectionString
            con.Open()

            Dim str As String = "UPDATE Outcomes SET " &
                "actual_rec_date =@rday, happened =@happened, phone_prob = @techProb, num_meds_brought = @medsBrought, num_useful_pics = @picsBrought, total_pics = @totalPics, comment =@comment, " &
                "all_claim =@allClaim, useful_list =@useFulList, total_list =@totalList, MRN =@MRN, shift =@shift WHERE (ID = @ID AND sday =@sday);"
            cmdUpdate.CommandText = str

            cmdUpdate.Parameters.Add("@rday", OleDbType.VarChar).Value = rday
            cmdUpdate.Parameters.Add("@happened", OleDbType.VarChar).Value = happened
            cmdUpdate.Parameters.Add("@techProb", OleDbType.VarChar).Value = techProb
            cmdUpdate.Parameters.Add("@medsBrought", OleDbType.VarChar).Value = medsBrought
            cmdUpdate.Parameters.Add("@picsBrought", OleDbType.VarChar).Value = picsBrought
            cmdUpdate.Parameters.Add("@totalPics", OleDbType.VarChar).Value = totalPics
            cmdUpdate.Parameters.Add("@comment", OleDbType.VarChar).Value = comment
            cmdUpdate.Parameters.Add("@allClaim", OleDbType.VarChar).Value = allClaim
            cmdUpdate.Parameters.Add("@useFulList", OleDbType.VarChar).Value = useFulList
            cmdUpdate.Parameters.Add("@totalList", OleDbType.VarChar).Value = totallist
            cmdUpdate.Parameters.Add("@MRN", OleDbType.VarChar).Value = MRN
            cmdUpdate.Parameters.Add("@shift", OleDbType.VarChar).Value = Shift

            cmdUpdate.Parameters.Add("@ID", OleDbType.VarChar).Value = ID
            cmdUpdate.Parameters.Add("@sday", OleDbType.VarChar).Value = sday

            cmdUpdate.CommandType = CommandType.Text
            cmdUpdate.Connection = con
            cmdUpdate.ExecuteNonQuery()
            cmdUpdate.Dispose()
            con.Close()
            con = Nothing

        Catch ex As Exception
            WriteToLog("UpdateAppt - Exception Follows:" & ex.Message)
            ' MessageBox.Show("UpdateAppt - Exception Follows:" & ex.Message)
        End Try

        stopWatch.Stop()
        ' Get the elapsed time as a TimeSpan value.
        Dim ts As TimeSpan = stopWatch.Elapsed

        ' Format and display the TimeSpan value.
        Dim elapsedTime As String = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds)
        ' MsgBox("SQL Update Time " + elapsedTime)

    End Sub






End Module
