Imports System.Data.SqlClient
Module DBConnect
    Public command As SqlCommand  '数据控制，控制你对数据库的操作'
    Public dAdapter As SqlDataAdapter '读数据的数据适配器
    Public dSet As DataSet
    Public connectionString = "Data Source=(local);Initial Catalog= BOOKMANAGEMENT;Integrated Security=True"
    Public con As SqlConnection = New SqlConnection(connectionString) '数据库的链接
End Module
