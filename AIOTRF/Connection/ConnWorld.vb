﻿Imports System.Data.SqlClient
Module ConnWorld
    'Module Created By O2PSoftlabs
    Public Function connworlds() As SqlConnection
        Dim dcmdworld As New SqlCommand
        Dim conworld As SqlConnection

        conworld = New SqlConnection("server=127.0.0.1;uid=MMODB;pwd=Test;database=RF_World;")
        Return conworld
        conworld = Nothing
    End Function
    Public daworld As SqlDataAdapter
    Public dtworld As New DataTable
    Public conworldc = ConnWorld.connworlds
    Public cmdworld As SqlCommand
    Public riworld As SqlCommand
    Public roworld As SqlDataAdapter
    Public sdbworld As Data.SqlClient.SqlDataAdapter
    Public perintahworld As SqlClient.SqlCommand
End Module
