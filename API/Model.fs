namespace API

open Microsoft.ML

module Model =

    let predict text =
        let mlContext = MLContext()
        let mlModel, schema = mlContext.Model.Load("./MLModel.zip")
        let engine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(mlModel)
        let input = {Col0 = text; Label = true} 
        let output = engine.Predict(input)

        match output.Prediction with
            | true -> "Positive"
            | false -> "Negative"