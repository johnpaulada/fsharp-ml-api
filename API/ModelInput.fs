namespace API

open System
open Microsoft.ML.Data

[<CLIMutable>]
type ModelInput = {
    [<ColumnName("col0")>]
    [<LoadColumn(0)>]
    Col0 : string

    [<ColumnName("Label")>]
    [<LoadColumn(1)>]
    Label : bool
}