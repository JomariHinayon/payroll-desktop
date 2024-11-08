Imports MongoDB.Driver
'mongodb://localhost:27017/
'mongodb+srv://mostdangercriminal:cdKhgz4c8nCM720g@cluster0.zaohe.mongodb.net/
Public NotInheritable Class conn
    Public Shared ReadOnly Server As String = "mongodb://localhost:27017/"
    Public Shared ReadOnly Db As String = "BPMS"
    Public Shared ReadOnly collectionUsers As String = "Accounts"
    Public Shared ReadOnly collectionEmployee As String = "Employee"
    Public Shared ReadOnly collectionCounters As String = "Counters"

    Public Shared Function OpenCollectionUsers() As IMongoCollection(Of Accounts)
        Dim client = New MongoClient(conn.Server)
        Dim db = client.GetDatabase(conn.Db)
        Return db.GetCollection(Of Accounts)(conn.collectionUsers)
    End Function
    Public Shared Function OpenCollectionCounters() As IMongoCollection(Of Counters)
        Dim client = New MongoClient(conn.Server)
        Dim db = client.GetDatabase(conn.Db)
        Return db.GetCollection(Of Counters)(conn.collectionCounters)
    End Function

    Public Shared Function OpenCollectionEmployee() As IMongoCollection(Of Employee)
        Dim client = New MongoClient(conn.Server)
        Dim db = client.GetDatabase(conn.Db)
        Return db.GetCollection(Of Employee)(conn.collectionEmployee)
    End Function

End Class
