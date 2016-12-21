Imports System.Data.SqlClient
Module DBConnect
    Public con As SqlConnection
    Public command As SqlCommand
    Public dAdapter As SqlDataAdapter
    Public dSet As DataSet
    Public connectionString = "Data Source=(local);Initial Catalog= BOOKMANAGEMENT;Integrated Security=True"
End Module
