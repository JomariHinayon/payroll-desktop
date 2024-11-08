Imports MongoDB.Bson
Imports MongoDB.Bson.Serialization.Attributes

Public Class Employee
    <BsonId>
    Property EmployeeId As String ' MongoDB ObjectId, represented as a string for better management

    Property LastName As String
    Property FirstName As String
    Property MiddleName As String
    Property Birthday As String
    Property Age As String
    Property Sex As String
    Property Status As String
    Property Address As String

    Property PhoneNum As String ' Store phone numbers as strings to avoid issues with large numbers

    Property TelNum As String ' Same for telephone numbers

    Property Position As String
    Property BasicRate As String ' Use Decimal for salary-related fields to handle financial precision

    Property SSS As String ' Social Security Number, assuming it's a string


    Property TimeIn As String ' Store time as strings or consider using DateTime or TimeSpan


    Property TimeOut As String ' Store time as strings or consider using DateTime or TimeSpan

    Property ProfilePic As Byte() ' Profile picture saved as binary data (Byte array)

    Property Fingerprint As Byte() ' Fingerprint saved as binary data (Byte array)
End Class
