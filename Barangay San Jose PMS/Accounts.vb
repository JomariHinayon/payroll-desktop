Imports MongoDB.Bson
Imports MongoDB.Bson.Serialization.Attributes

Public Class Accounts
    <BsonId>
    <BsonRepresentation(BsonType.Int32)>
    Property EmployeeIdNo As Integer
    Property FirstName As String
    Property LastName As String
    Property Username As String
    Property Password As String

End Class
