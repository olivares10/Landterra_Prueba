﻿Imports System.Data.Entity

Namespace Data
    
    Public Class VistaMVCContext
        Inherits DbContext
    
        ' You can add custom code to this file. Changes will not be overwritten.
        ' 
        ' If you want Entity Framework to drop and regenerate your database
        ' automatically whenever you change your model schema, please use data migrations.
        ' For more information refer to the documentation:
        ' http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        Public Sub New()
            MyBase.New("name=VistaMVCContext")
        End Sub

        Public Property Empleados As System.Data.Entity.DbSet(Of ado.Empleados)
    End Class
    
End Namespace
