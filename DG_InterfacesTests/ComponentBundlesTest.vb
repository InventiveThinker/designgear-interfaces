Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports DG_Interfaces


<TestClass()> Public Class ComponentBundlesTest

    <TestMethod()> Public Sub CreateCompBundleJson()


        'Create test configuration
        Dim compConfig = New Configuration With {.InternalId = Guid.NewGuid.ToString,
            .Name = "Standard Tank Wall: D=9.75M H=5 Rows",
            .Comment = "Test comment."}

        'Add parameters
        compConfig.Parameters.Add(New Parameter With {.Name = "N_Rows",
                                  .DisplayName = "Number of Rows",
                                  .InternalId = Guid.NewGuid.ToString,
                                  .Comment = "Number of sheets in vertical direction",
                                  .IsReadOnly = False,
                                  .IsHidden = False,
                                  .IsMultivalue = True,
                                  .Type = ValueTypeEnum.Double,
                                  .Unit = "ul",
                                  .ValidationString = "",
                                  .ValidationTip = "",
                                  .Value = 4,
                                  .ValueList = {4, 5, 6, 7, 8},
                                  .AllowCustomValues = False})

        compConfig.Parameters.Add(New Parameter With {.Name = "N_Cols",
                                  .DisplayName = "Number of Columns",
                                  .InternalId = Guid.NewGuid.ToString,
                                  .Comment = "Number of sheets in horizontal direction",
                                  .IsReadOnly = False,
                                  .IsHidden = False,
                                  .IsMultivalue = True,
                                  .Type = ValueTypeEnum.Double,
                                  .Unit = "ul",
                                  .Value = 10,
                                  .ValueList = {8, 9, 10, 11, 12, 13, 14},
                                  .AllowCustomValues = False})

        compConfig.Parameters.Add(New Parameter With {.Name = "InletAng",
                                  .DisplayName = "Inlet position",
                                  .InternalId = Guid.NewGuid.ToString,
                                  .Comment = "Angle of inlet position.",
                                  .IsReadOnly = False,
                                  .IsHidden = False,
                                  .IsMultivalue = False,
                                  .Type = ValueTypeEnum.Double,
                                  .Unit = "deg",
                                  .Value = 30,
                                  .ValidationString = "([0-9]|[1-8][0-9]|9[0-9]|[12][0-9]{2}|3[0-5][0-9]|360)",
                                  .ValidationTip = "The value must be from 0 to 360 degrees."})


        compConfig.Parameters.Add(New Parameter With {.Name = "IsFlat",
                                  .InternalId = Guid.NewGuid.ToString,
                                  .IsReadOnly = False,
                                  .IsHidden = True,
                                  .IsMultivalue = False,
                                  .Type = ValueTypeEnum.Boolean,
                                  .Value = False})


        'Create test component definition
        Dim compDef As New Component With {.AllowAddComponents = False,
            .InternalId = Guid.NewGuid.ToString,
            .IsHidden = False,
            .IsReadOnly = False,
            .Type = ComponetTypeEnum.AssemblyInstance}

        'Specify Predefined configurations
        compDef.Configurations.Add(compConfig)
        'Specify default configuration
        compDef.DefaultConfigurationId = compConfig.InternalId

        'Set current configuration
        compDef.CurrentConfiguration = compConfig


        'Create a new instance of component bundle
        Dim compBundle As New ComponentBundle _
            With {.InternalId = Guid.NewGuid.ToString,
            .TargetDocument = "TankWall.iam"}

        'Add dependent files
        compBundle.Dependencies.Add(New Dependency With {.FileName = "TankWall.zip", .IsCompressed = True})

        'Add AllowedTasks
        compBundle.AllowedTasks.Add(New DaTask With {.Type = DaTaskTypeEnum.UpdateModel})
        compBundle.AllowedTasks.Add(New DaTask With {.Type = DaTaskTypeEnum.PublishDocummentation})


        'add 
        compBundle.ComponentDefinition = compDef


        'Save to file
        compBundle.SaveToJsonFile("c:\Temp\BundleDefinition.json")

    End Sub

End Class