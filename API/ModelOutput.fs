namespace API

open System
open Microsoft.ML.Data

[<CLIMutable>]
type ModelOutput = {
    [<ColumnName("PredictedLabel")>]
    Prediction : bool
    Score : float32
}